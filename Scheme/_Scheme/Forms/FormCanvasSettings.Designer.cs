namespace Scheme.Forms
{
	public partial class FormCanvasSettings : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Scheme.Forms.FormCanvasSettings));
			global::System.Windows.Forms.TreeNode treeNode = new global::System.Windows.Forms.TreeNode("Фон");
			global::System.Windows.Forms.TreeNode treeNode2 = new global::System.Windows.Forms.TreeNode("Сетка");
			global::System.Windows.Forms.TreeNode treeNode3 = new global::System.Windows.Forms.TreeNode("Выделенные объекты");
			global::System.Windows.Forms.TreeNode treeNode4 = new global::System.Windows.Forms.TreeNode("Отмеченные объекты");
			global::System.Windows.Forms.TreeNode treeNode5 = new global::System.Windows.Forms.TreeNode("Мерцающие объекты");
			global::System.Windows.Forms.TreeNode treeNode6 = new global::System.Windows.Forms.TreeNode("ЦП");
			global::System.Windows.Forms.TreeNode treeNode7 = new global::System.Windows.Forms.TreeNode("ТП");
			global::System.Windows.Forms.TreeNode treeNode8 = new global::System.Windows.Forms.TreeNode("РП");
			global::System.Windows.Forms.TreeNode treeNode9 = new global::System.Windows.Forms.TreeNode("ПП");
			global::System.Windows.Forms.TreeNode treeNode10 = new global::System.Windows.Forms.TreeNode("СП");
			global::System.Windows.Forms.TreeNode treeNode11 = new global::System.Windows.Forms.TreeNode("ППНО");
			global::System.Windows.Forms.TreeNode treeNode12 = new global::System.Windows.Forms.TreeNode("Подстанции", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode6,
				treeNode7,
				treeNode8,
				treeNode9,
				treeNode10,
				treeNode11
			});
			global::System.Windows.Forms.TreeNode treeNode13 = new global::System.Windows.Forms.TreeNode("Шина 110 кВ");
			global::System.Windows.Forms.TreeNode treeNode14 = new global::System.Windows.Forms.TreeNode("Шина 35 кВ");
			global::System.Windows.Forms.TreeNode treeNode15 = new global::System.Windows.Forms.TreeNode("Шина 10 кВ");
			global::System.Windows.Forms.TreeNode treeNode16 = new global::System.Windows.Forms.TreeNode("Шина 6 кВ");
			global::System.Windows.Forms.TreeNode treeNode17 = new global::System.Windows.Forms.TreeNode("Шина 0,4 кВ");
			global::System.Windows.Forms.TreeNode treeNode18 = new global::System.Windows.Forms.TreeNode("Шина 0,23 кВ");
			global::System.Windows.Forms.TreeNode treeNode19 = new global::System.Windows.Forms.TreeNode("Шины", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode13,
				treeNode14,
				treeNode15,
				treeNode16,
				treeNode17,
				treeNode18
			});
			global::System.Windows.Forms.TreeNode treeNode20 = new global::System.Windows.Forms.TreeNode("Ячейка 110 кВ");
			global::System.Windows.Forms.TreeNode treeNode21 = new global::System.Windows.Forms.TreeNode("Ячейка 35 кВ");
			global::System.Windows.Forms.TreeNode treeNode22 = new global::System.Windows.Forms.TreeNode("Ячейка 10 кВ");
			global::System.Windows.Forms.TreeNode treeNode23 = new global::System.Windows.Forms.TreeNode("Ячейка 6 кВ");
			global::System.Windows.Forms.TreeNode treeNode24 = new global::System.Windows.Forms.TreeNode("Ячейка 0,4 кВ");
			global::System.Windows.Forms.TreeNode treeNode25 = new global::System.Windows.Forms.TreeNode("Ячейка 0,23 кВ");
			global::System.Windows.Forms.TreeNode treeNode26 = new global::System.Windows.Forms.TreeNode("Ячейки", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode20,
				treeNode21,
				treeNode22,
				treeNode23,
				treeNode24,
				treeNode25
			});
			global::System.Windows.Forms.TreeNode treeNode27 = new global::System.Windows.Forms.TreeNode("Линия 110 кВ");
			global::System.Windows.Forms.TreeNode treeNode28 = new global::System.Windows.Forms.TreeNode("Линия 35 кВ");
			global::System.Windows.Forms.TreeNode treeNode29 = new global::System.Windows.Forms.TreeNode("Линия 10 кВ");
			global::System.Windows.Forms.TreeNode treeNode30 = new global::System.Windows.Forms.TreeNode("Линия 6 кВ");
			global::System.Windows.Forms.TreeNode treeNode31 = new global::System.Windows.Forms.TreeNode("Линия 0,4 кВ");
			global::System.Windows.Forms.TreeNode treeNode32 = new global::System.Windows.Forms.TreeNode("Линия 0,23 кВ");
			global::System.Windows.Forms.TreeNode treeNode33 = new global::System.Windows.Forms.TreeNode("Линии", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode27,
				treeNode28,
				treeNode29,
				treeNode30,
				treeNode31,
				treeNode32
			});
			global::System.Windows.Forms.TreeNode treeNode34 = new global::System.Windows.Forms.TreeNode("Маслянный выключатель");
			global::System.Windows.Forms.TreeNode treeNode35 = new global::System.Windows.Forms.TreeNode("Линейный разъединитель");
			global::System.Windows.Forms.TreeNode treeNode36 = new global::System.Windows.Forms.TreeNode("Выключатель нагрузки");
			global::System.Windows.Forms.TreeNode treeNode37 = new global::System.Windows.Forms.TreeNode("Трансформатор");
			global::System.Windows.Forms.TreeNode treeNode38 = new global::System.Windows.Forms.TreeNode("Вакуумный выключатель");
			global::System.Windows.Forms.TreeNode treeNode39 = new global::System.Windows.Forms.TreeNode("Наружный линейный разъединитель");
			global::System.Windows.Forms.TreeNode treeNode40 = new global::System.Windows.Forms.TreeNode("Концевая разделка");
			global::System.Windows.Forms.TreeNode treeNode41 = new global::System.Windows.Forms.TreeNode("Текст");
			global::System.Windows.Forms.TreeNode treeNode42 = new global::System.Windows.Forms.TreeNode("Перенос нагрузки");
			global::System.Windows.Forms.TreeNode treeNode43 = new global::System.Windows.Forms.TreeNode("Заземление");
			global::System.Windows.Forms.TreeNode treeNode44 = new global::System.Windows.Forms.TreeNode("Повреждение кабеля");
			global::System.Windows.Forms.TreeNode treeNode45 = new global::System.Windows.Forms.TreeNode("Отключение кабеля");
			global::System.Windows.Forms.TreeNode treeNode46 = new global::System.Windows.Forms.TreeNode("Несфазировано");
			global::System.Windows.Forms.TreeNode treeNode47 = new global::System.Windows.Forms.TreeNode("Спец. замок");
			global::System.Windows.Forms.TreeNode treeNode48 = new global::System.Windows.Forms.TreeNode("Повреждение");
			global::System.Windows.Forms.TreeNode treeNode49 = new global::System.Windows.Forms.TreeNode("Статусы", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode47,
				treeNode48
			});
			global::System.Windows.Forms.TreeNode treeNode50 = new global::System.Windows.Forms.TreeNode("Объекты на линии", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode34,
				treeNode35,
				treeNode36,
				treeNode37,
				treeNode38,
				treeNode39,
				treeNode40,
				treeNode41,
				treeNode42,
				treeNode43,
				treeNode44,
				treeNode45,
				treeNode46,
				treeNode49
			});
			global::System.Windows.Forms.TreeNode treeNode51 = new global::System.Windows.Forms.TreeNode("АВР");
			global::System.Windows.Forms.TreeNode treeNode52 = new global::System.Windows.Forms.TreeNode("Спец. замок");
			global::System.Windows.Forms.TreeNode treeNode53 = new global::System.Windows.Forms.TreeNode("ТМ");
			global::System.Windows.Forms.TreeNode treeNode54 = new global::System.Windows.Forms.TreeNode("ТМ-Охрана");
			global::System.Windows.Forms.TreeNode treeNode55 = new global::System.Windows.Forms.TreeNode("Ответсвенный абонент");
			global::System.Windows.Forms.TreeNode treeNode56 = new global::System.Windows.Forms.TreeNode("Примечание");
			global::System.Windows.Forms.TreeNode treeNode57 = new global::System.Windows.Forms.TreeNode("Обозначения", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode51,
				treeNode52,
				treeNode53,
				treeNode54,
				treeNode55,
				treeNode56
			});
			global::System.Windows.Forms.TreeNode treeNode58 = new global::System.Windows.Forms.TreeNode("Качество изображения");
			this.tabControl = new global::System.Windows.Forms.TabControl();
			this.tabPageColor = new global::System.Windows.Forms.TabPage();
			this.panelFontNoVisible = new global::System.Windows.Forms.Panel();
			this.numericUpDownFontNoVisible = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupBoxGrid = new global::System.Windows.Forms.GroupBox();
			this.radioButtonNoVisibleGrid = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLine = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDots = new global::System.Windows.Forms.RadioButton();
			this.panelZoomSimply = new global::System.Windows.Forms.Panel();
			this.numericUpDownZoomSimply = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.panelColorNormal = new global::System.Windows.Forms.Panel();
			this.panelColorNormalSel = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonFont = new global::System.Windows.Forms.Button();
			this.panelColorOff = new global::System.Windows.Forms.Panel();
			this.panelColorOffSel = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panelSelectedColor = new global::System.Windows.Forms.Panel();
			this.panelSelctedColorSel = new global::System.Windows.Forms.Panel();
			this.labelSelectedColor = new global::System.Windows.Forms.Label();
			this.panelColor = new global::System.Windows.Forms.Panel();
			this.panelColorSel = new global::System.Windows.Forms.Panel();
			this.labelColor = new global::System.Windows.Forms.Label();
			this.canvasColor = new global::SchemeCtrl2.Canvas.CanvasControl();
			this.treeViewColors = new global::System.Windows.Forms.TreeView();
			this.checkBoxColorLine = new global::System.Windows.Forms.CheckBox();
			this.cmbQualityImage = new global::System.Windows.Forms.ComboBox();
			this.tabPagePassport = new global::System.Windows.Forms.TabPage();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.groupBoxCablePassport = new global::System.Windows.Forms.GroupBox();
			this.cablePropDataGridView = new global::System.Windows.Forms.DataGridView();
			this.NameProperty = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ValueProperty = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.checkBoxCableLenght = new global::System.Windows.Forms.CheckBox();
			this.checkBoxCableCrossSection = new global::System.Windows.Forms.CheckBox();
			this.checkBoxCableWires = new global::System.Windows.Forms.CheckBox();
			this.checkBoxCableVoltage = new global::System.Windows.Forms.CheckBox();
			this.JkIeHaOeLT = new global::System.Windows.Forms.CheckBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.hmoeAwgdZN = new global::System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tabPageInterface = new global::System.Windows.Forms.TabPage();
			this.numericFontSize = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.numericSizeIcon = new global::System.Windows.Forms.NumericUpDown();
			this.labelSizeIcon = new global::System.Windows.Forms.Label();
			this.tabPageOPCConfig = new global::System.Windows.Forms.TabPage();
			this.groupBoxMeasurement = new global::System.Windows.Forms.GroupBox();
			this.comboBoxMeasurementYear = new global::System.Windows.Forms.ComboBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.groupBox_0 = new global::System.Windows.Forms.GroupBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.groupBoxAutoReconnect = new global::System.Windows.Forms.GroupBox();
			this.textBoxItervalReconnect = new global::System.Windows.Forms.TextBox();
			this.labelIntervalReconnect = new global::System.Windows.Forms.Label();
			this.checkBoxAutoReconnect = new global::System.Windows.Forms.CheckBox();
			this.textBoxIPAddressOPCServer = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.textBoxPortOPCServer = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.textBoxServerOPCConfig = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.textBoxBaseOPCConfig = new global::System.Windows.Forms.TextBox();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.colorDialog_0 = new global::System.Windows.Forms.ColorDialog();
			this.fontDialog_0 = new global::System.Windows.Forms.FontDialog();
			this.groupBoxSettings = new global::System.Windows.Forms.GroupBox();
			this.radioButtonIndividual = new global::System.Windows.Forms.RadioButton();
			this.radioButtonGeneral = new global::System.Windows.Forms.RadioButton();
			this.buttonApply = new global::System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPageColor.SuspendLayout();
			this.panelFontNoVisible.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownFontNoVisible).BeginInit();
			this.groupBoxGrid.SuspendLayout();
			this.panelZoomSimply.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownZoomSimply).BeginInit();
			this.panelColorNormal.SuspendLayout();
			this.panelColorOff.SuspendLayout();
			this.panelSelectedColor.SuspendLayout();
			this.panelColor.SuspendLayout();
			this.tabPagePassport.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBoxCablePassport.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cablePropDataGridView).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.hmoeAwgdZN).BeginInit();
			this.tabPageInterface.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericFontSize).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSizeIcon).BeginInit();
			this.tabPageOPCConfig.SuspendLayout();
			this.groupBoxMeasurement.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			this.groupBoxAutoReconnect.SuspendLayout();
			this.groupBoxSettings.SuspendLayout();
			base.SuspendLayout();
			this.tabControl.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabControl.Controls.Add(this.tabPageColor);
			this.tabControl.Controls.Add(this.tabPagePassport);
			this.tabControl.Controls.Add(this.tabPageInterface);
			this.tabControl.Controls.Add(this.tabPageOPCConfig);
			this.tabControl.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new global::System.Drawing.Size(713, 480);
			this.tabControl.TabIndex = 0;
			this.tabPageColor.Controls.Add(this.panelFontNoVisible);
			this.tabPageColor.Controls.Add(this.groupBoxGrid);
			this.tabPageColor.Controls.Add(this.panelZoomSimply);
			this.tabPageColor.Controls.Add(this.panelColorNormal);
			this.tabPageColor.Controls.Add(this.buttonFont);
			this.tabPageColor.Controls.Add(this.panelColorOff);
			this.tabPageColor.Controls.Add(this.panelSelectedColor);
			this.tabPageColor.Controls.Add(this.panelColor);
			this.tabPageColor.Controls.Add(this.canvasColor);
			this.tabPageColor.Controls.Add(this.treeViewColors);
			this.tabPageColor.Controls.Add(this.checkBoxColorLine);
			this.tabPageColor.Controls.Add(this.cmbQualityImage);
			this.tabPageColor.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageColor.Name = "tabPageColor";
			this.tabPageColor.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageColor.Size = new global::System.Drawing.Size(705, 457);
			this.tabPageColor.TabIndex = 0;
			this.tabPageColor.Text = "Цвета";
			this.tabPageColor.UseVisualStyleBackColor = true;
			this.panelFontNoVisible.Controls.Add(this.numericUpDownFontNoVisible);
			this.panelFontNoVisible.Controls.Add(this.label4);
			this.panelFontNoVisible.Location = new global::System.Drawing.Point(518, 415);
			this.panelFontNoVisible.Name = "panelFontNoVisible";
			this.panelFontNoVisible.Size = new global::System.Drawing.Size(181, 42);
			this.panelFontNoVisible.TabIndex = 13;
			this.numericUpDownFontNoVisible.DecimalPlaces = 1;
			this.numericUpDownFontNoVisible.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownFontNoVisible.Location = new global::System.Drawing.Point(10, 18);
			this.numericUpDownFontNoVisible.Name = "numericUpDownFontNoVisible";
			this.numericUpDownFontNoVisible.Size = new global::System.Drawing.Size(120, 20);
			this.numericUpDownFontNoVisible.TabIndex = 1;
			this.numericUpDownFontNoVisible.ValueChanged += new global::System.EventHandler(this.numericUpDownFontNoVisible_ValueChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(7, 3);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(163, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Минимальный размер шрифта";
			this.groupBoxGrid.Controls.Add(this.radioButtonNoVisibleGrid);
			this.groupBoxGrid.Controls.Add(this.radioButtonLine);
			this.groupBoxGrid.Controls.Add(this.radioButtonDots);
			this.groupBoxGrid.Location = new global::System.Drawing.Point(567, 346);
			this.groupBoxGrid.Name = "groupBoxGrid";
			this.groupBoxGrid.Size = new global::System.Drawing.Size(132, 65);
			this.groupBoxGrid.TabIndex = 2;
			this.groupBoxGrid.TabStop = false;
			this.groupBoxGrid.Text = "Сетка";
			this.radioButtonNoVisibleGrid.AutoSize = true;
			this.radioButtonNoVisibleGrid.Location = new global::System.Drawing.Point(28, 42);
			this.radioButtonNoVisibleGrid.Name = "radioButtonNoVisibleGrid";
			this.radioButtonNoVisibleGrid.Size = new global::System.Drawing.Size(103, 17);
			this.radioButtonNoVisibleGrid.TabIndex = 5;
			this.radioButtonNoVisibleGrid.TabStop = true;
			this.radioButtonNoVisibleGrid.Text = "Не показывать";
			this.radioButtonNoVisibleGrid.UseVisualStyleBackColor = true;
			this.radioButtonNoVisibleGrid.CheckedChanged += new global::System.EventHandler(this.radioButtonNoVisibleGrid_CheckedChanged);
			this.radioButtonLine.AutoSize = true;
			this.radioButtonLine.Location = new global::System.Drawing.Point(67, 18);
			this.radioButtonLine.Name = "radioButtonLine";
			this.radioButtonLine.Size = new global::System.Drawing.Size(57, 17);
			this.radioButtonLine.TabIndex = 4;
			this.radioButtonLine.TabStop = true;
			this.radioButtonLine.Text = "Линии";
			this.radioButtonLine.UseVisualStyleBackColor = true;
			this.radioButtonLine.CheckedChanged += new global::System.EventHandler(this.radioButtonLine_CheckedChanged);
			this.radioButtonDots.AutoSize = true;
			this.radioButtonDots.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonDots.Name = "radioButtonDots";
			this.radioButtonDots.Size = new global::System.Drawing.Size(55, 17);
			this.radioButtonDots.TabIndex = 3;
			this.radioButtonDots.TabStop = true;
			this.radioButtonDots.Text = "Точки";
			this.radioButtonDots.UseVisualStyleBackColor = true;
			this.radioButtonDots.CheckedChanged += new global::System.EventHandler(this.radioButtonDots_CheckedChanged);
			this.panelZoomSimply.Controls.Add(this.numericUpDownZoomSimply);
			this.panelZoomSimply.Controls.Add(this.label3);
			this.panelZoomSimply.Location = new global::System.Drawing.Point(521, 343);
			this.panelZoomSimply.Name = "panelZoomSimply";
			this.panelZoomSimply.Size = new global::System.Drawing.Size(181, 42);
			this.panelZoomSimply.TabIndex = 12;
			this.numericUpDownZoomSimply.Location = new global::System.Drawing.Point(10, 18);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownZoomSimply;
			int[] array = new int[4];
			array[0] = 1000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDownZoomSimply.Name = "numericUpDownZoomSimply";
			this.numericUpDownZoomSimply.Size = new global::System.Drawing.Size(120, 20);
			this.numericUpDownZoomSimply.TabIndex = 1;
			this.numericUpDownZoomSimply.ValueChanged += new global::System.EventHandler(this.numericUpDownZoomSimply_ValueChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(7, 3);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(112, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Масштаб упрощения";
			this.panelColorNormal.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.panelColorNormal.Controls.Add(this.panelColorNormalSel);
			this.panelColorNormal.Controls.Add(this.label2);
			this.panelColorNormal.Location = new global::System.Drawing.Point(364, 384);
			this.panelColorNormal.Name = "panelColorNormal";
			this.panelColorNormal.Size = new global::System.Drawing.Size(151, 35);
			this.panelColorNormal.TabIndex = 9;
			this.panelColorNormalSel.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelColorNormalSel.Location = new global::System.Drawing.Point(72, 5);
			this.panelColorNormalSel.Name = "panelColorNormalSel";
			this.panelColorNormalSel.Size = new global::System.Drawing.Size(69, 24);
			this.panelColorNormalSel.TabIndex = 1;
			this.panelColorNormalSel.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.panelColorNormalSel_MouseClick);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(3, 11);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(62, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Норм разр";
			this.buttonFont.Location = new global::System.Drawing.Point(207, 425);
			this.buttonFont.Name = "buttonFont";
			this.buttonFont.Size = new global::System.Drawing.Size(63, 23);
			this.buttonFont.TabIndex = 8;
			this.buttonFont.Text = "Шрифт";
			this.buttonFont.UseVisualStyleBackColor = true;
			this.buttonFont.Click += new global::System.EventHandler(this.buttonFont_Click);
			this.panelColorOff.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.panelColorOff.Controls.Add(this.panelColorOffSel);
			this.panelColorOff.Controls.Add(this.label1);
			this.panelColorOff.Location = new global::System.Drawing.Point(364, 343);
			this.panelColorOff.Name = "panelColorOff";
			this.panelColorOff.Size = new global::System.Drawing.Size(151, 35);
			this.panelColorOff.TabIndex = 7;
			this.panelColorOffSel.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelColorOffSel.Location = new global::System.Drawing.Point(72, 5);
			this.panelColorOffSel.Name = "panelColorOffSel";
			this.panelColorOffSel.Size = new global::System.Drawing.Size(69, 24);
			this.panelColorOffSel.TabIndex = 1;
			this.panelColorOffSel.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.panelColorOffSel_MouseClick);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Откючено";
			this.panelSelectedColor.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.panelSelectedColor.Controls.Add(this.panelSelctedColorSel);
			this.panelSelectedColor.Controls.Add(this.labelSelectedColor);
			this.panelSelectedColor.Location = new global::System.Drawing.Point(207, 384);
			this.panelSelectedColor.Name = "panelSelectedColor";
			this.panelSelectedColor.Size = new global::System.Drawing.Size(151, 35);
			this.panelSelectedColor.TabIndex = 6;
			this.panelSelctedColorSel.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelSelctedColorSel.Location = new global::System.Drawing.Point(72, 5);
			this.panelSelctedColorSel.Name = "panelSelctedColorSel";
			this.panelSelctedColorSel.Size = new global::System.Drawing.Size(69, 24);
			this.panelSelctedColorSel.TabIndex = 1;
			this.labelSelectedColor.AutoSize = true;
			this.labelSelectedColor.Location = new global::System.Drawing.Point(3, 11);
			this.labelSelectedColor.Name = "labelSelectedColor";
			this.labelSelectedColor.Size = new global::System.Drawing.Size(72, 13);
			this.labelSelectedColor.TabIndex = 0;
			this.labelSelectedColor.Text = "Выделенный";
			this.panelColor.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.panelColor.Controls.Add(this.panelColorSel);
			this.panelColor.Controls.Add(this.labelColor);
			this.panelColor.Location = new global::System.Drawing.Point(207, 343);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new global::System.Drawing.Size(151, 35);
			this.panelColor.TabIndex = 5;
			this.panelColorSel.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelColorSel.Location = new global::System.Drawing.Point(72, 5);
			this.panelColorSel.Name = "panelColorSel";
			this.panelColorSel.Size = new global::System.Drawing.Size(69, 24);
			this.panelColorSel.TabIndex = 1;
			this.panelColorSel.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.panelColorSel_MouseClick);
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new global::System.Drawing.Point(3, 11);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new global::System.Drawing.Size(32, 13);
			this.labelColor.TabIndex = 0;
			this.labelColor.Text = "Цвет";
			this.canvasColor.ActiveLayer = null;
			this.canvasColor.AllowDrop = true;
			this.canvasColor.Connected = false;
			this.canvasColor.CurrentMetric = global::SchemeCtrl2.Canvas.eMetric.sm;
			this.canvasColor.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.canvasColor.DeltaPoint = (global::System.Drawing.PointF)componentResourceManager.GetObject("canvasColor.DeltaPoint");
			this.canvasColor.Endpoint = null;
			this.canvasColor.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.canvasColor.IdRect = 0;
			this.canvasColor.LineInformationVisible = false;
			this.canvasColor.Location = new global::System.Drawing.Point(207, 0);
			this.canvasColor.MaxMode = global::SchemeCtrl2.Canvas.eCanvasEditingMode.Edit;
			this.canvasColor.MeasurementLabelVisible = false;
			this.canvasColor.Mode = global::SchemeCtrl2.Canvas.eCanvasEditingMode.ReadOnly;
			this.canvasColor.Monopoly = true;
			this.canvasColor.Name = "canvasColor";
			this.canvasColor.OpcClient = null;
			this.canvasColor.PagesHeigth = 1;
			this.canvasColor.PagesWidth = 1;
			this.canvasColor.SchemeName = "schema1";
			this.canvasColor.SimulationMode = global::SchemeCtrl2.Canvas.eSimulationMode.Online;
			this.canvasColor.Size = new global::System.Drawing.Size(498, 337);
			this.canvasColor.SqlSettings = null;
			this.canvasColor.StatusStripVisible = false;
			this.canvasColor.TabIndex = 4;
			this.canvasColor.TelemetryLabelVisible = false;
			this.canvasColor.TypeCanvas = global::SchemeCtrl2.Canvas.eTypeCanvas.SchemeMain;
			this.canvasColor.UseObjectFromDB = false;
			this.canvasColor.VisibleCanvasSchemeMap = false;
			this.canvasColor.VisibleSaveProgressBar = false;
			this.canvasColor.WorkerCounter = 0;
			this.canvasColor.WorkerPrint = null;
			this.canvasColor.Zoom = 1f;
			this.treeViewColors.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.treeViewColors.Location = new global::System.Drawing.Point(0, 0);
			this.treeViewColors.Name = "treeViewColors";
			treeNode.Name = "Node0";
			treeNode.Text = "Фон";
			treeNode2.Name = "Node1";
			treeNode2.Text = "Сетка";
			treeNode3.Name = "Node0";
			treeNode3.Text = "Выделенные объекты";
			treeNode4.Name = "Node0";
			treeNode4.Text = "Отмеченные объекты";
			treeNode5.Name = "Node0";
			treeNode5.Text = "Мерцающие объекты";
			treeNode6.Name = "Node3";
			treeNode6.Text = "ЦП";
			treeNode7.Name = "Node5";
			treeNode7.Text = "ТП";
			treeNode8.Name = "Node6";
			treeNode8.Text = "РП";
			treeNode9.Name = "Node7";
			treeNode9.Text = "ПП";
			treeNode10.Name = "Node1";
			treeNode10.Text = "СП";
			treeNode11.Name = "PPNONode";
			treeNode11.Text = "ППНО";
			treeNode12.Name = "Node2";
			treeNode12.Text = "Подстанции";
			treeNode13.Name = "nodeBus110";
			treeNode13.Text = "Шина 110 кВ";
			treeNode14.Name = "nodeBus35";
			treeNode14.Text = "Шина 35 кВ";
			treeNode15.Name = "Node1";
			treeNode15.Text = "Шина 10 кВ";
			treeNode16.Name = "Node2";
			treeNode16.Text = "Шина 6 кВ";
			treeNode17.Name = "Node3";
			treeNode17.Text = "Шина 0,4 кВ";
			treeNode18.Name = "Node4";
			treeNode18.Text = "Шина 0,23 кВ";
			treeNode19.Name = "Node0";
			treeNode19.Text = "Шины";
			treeNode20.Name = "nodeCell110";
			treeNode20.Text = "Ячейка 110 кВ";
			treeNode21.Name = "nodeCell35";
			treeNode21.Text = "Ячейка 35 кВ";
			treeNode22.Name = "Node1";
			treeNode22.Text = "Ячейка 10 кВ";
			treeNode23.Name = "Node6";
			treeNode23.Text = "Ячейка 6 кВ";
			treeNode24.Name = "Node7";
			treeNode24.Text = "Ячейка 0,4 кВ";
			treeNode25.Name = "Node8";
			treeNode25.Text = "Ячейка 0,23 кВ";
			treeNode26.Name = "Node0";
			treeNode26.Text = "Ячейки";
			treeNode27.Name = "nodeLine110";
			treeNode27.Text = "Линия 110 кВ";
			treeNode28.Name = "nodeLine35";
			treeNode28.Text = "Линия 35 кВ";
			treeNode29.Name = "Node1";
			treeNode29.Text = "Линия 10 кВ";
			treeNode30.Name = "Node2";
			treeNode30.Text = "Линия 6 кВ";
			treeNode31.Name = "Node3";
			treeNode31.Text = "Линия 0,4 кВ";
			treeNode32.Name = "Node4";
			treeNode32.Text = "Линия 0,23 кВ";
			treeNode33.Name = "Node0";
			treeNode33.Text = "Линии";
			treeNode34.Name = "Node1";
			treeNode34.Text = "Маслянный выключатель";
			treeNode35.Name = "Node2";
			treeNode35.Text = "Линейный разъединитель";
			treeNode36.Name = "Node3";
			treeNode36.Text = "Выключатель нагрузки";
			treeNode37.Name = "Node5";
			treeNode37.Text = "Трансформатор";
			treeNode38.Name = "Node7";
			treeNode38.Text = "Вакуумный выключатель";
			treeNode39.Name = "Node8";
			treeNode39.Text = "Наружный линейный разъединитель";
			treeNode40.Name = "Node9";
			treeNode40.Text = "Концевая разделка";
			treeNode41.Name = "Node11";
			treeNode41.Text = "Текст";
			treeNode42.Name = "Node1";
			treeNode42.Text = "Перенос нагрузки";
			treeNode43.Name = "Node4";
			treeNode43.NodeFont = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 204);
			treeNode43.Text = "Заземление";
			treeNode44.Name = "Node6";
			treeNode44.NodeFont = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 204);
			treeNode44.Text = "Повреждение кабеля";
			treeNode45.Name = "Node0";
			treeNode45.NodeFont = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 204);
			treeNode45.Text = "Отключение кабеля";
			treeNode46.Name = "Node1";
			treeNode46.NodeFont = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 204);
			treeNode46.Text = "Несфазировано";
			treeNode47.Name = "Node1";
			treeNode47.Text = "Спец. замок";
			treeNode48.Name = "Node2";
			treeNode48.Text = "Повреждение";
			treeNode49.Name = "Node0";
			treeNode49.NodeFont = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			treeNode49.Text = "Статусы";
			treeNode50.Name = "Node0";
			treeNode50.Text = "Объекты на линии";
			treeNode51.Name = "Node1";
			treeNode51.Text = "АВР";
			treeNode52.Name = "Node2";
			treeNode52.Text = "Спец. замок";
			treeNode53.Name = "Node3";
			treeNode53.Text = "ТМ";
			treeNode54.Name = "Node5";
			treeNode54.Text = "ТМ-Охрана";
			treeNode55.Name = "Node6";
			treeNode55.Text = "Ответсвенный абонент";
			treeNode56.Name = "Node0";
			treeNode56.Text = "Примечание";
			treeNode57.Name = "Node0";
			treeNode57.Text = "Обозначения";
			treeNode58.Name = "Node0";
			treeNode58.Text = "Качество изображения";
			this.treeViewColors.Nodes.AddRange(new global::System.Windows.Forms.TreeNode[]
			{
				treeNode,
				treeNode2,
				treeNode3,
				treeNode4,
				treeNode5,
				treeNode12,
				treeNode19,
				treeNode26,
				treeNode33,
				treeNode50,
				treeNode57,
				treeNode58
			});
			this.treeViewColors.Size = new global::System.Drawing.Size(204, 457);
			this.treeViewColors.TabIndex = 3;
			this.treeViewColors.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeViewColors_AfterSelect);
			this.checkBoxColorLine.AutoSize = true;
			this.checkBoxColorLine.Location = new global::System.Drawing.Point(522, 397);
			this.checkBoxColorLine.Name = "checkBoxColorLine";
			this.checkBoxColorLine.Size = new global::System.Drawing.Size(84, 17);
			this.checkBoxColorLine.TabIndex = 10;
			this.checkBoxColorLine.Text = "Цвет линии";
			this.checkBoxColorLine.UseVisualStyleBackColor = true;
			this.checkBoxColorLine.CheckedChanged += new global::System.EventHandler(this.checkBoxColorLine_CheckedChanged);
			this.cmbQualityImage.FormattingEnabled = true;
			this.cmbQualityImage.Items.AddRange(new object[]
			{
				"Отсутствие сглаживания",
				"Визуализация со сглаживанием"
			});
			this.cmbQualityImage.Location = new global::System.Drawing.Point(208, 345);
			this.cmbQualityImage.Name = "cmbQualityImage";
			this.cmbQualityImage.Size = new global::System.Drawing.Size(153, 21);
			this.cmbQualityImage.TabIndex = 11;
			this.cmbQualityImage.SelectedIndexChanged += new global::System.EventHandler(this.cmbQualityImage_SelectedIndexChanged);
			this.tabPagePassport.Controls.Add(this.splitContainer1);
			this.tabPagePassport.Location = new global::System.Drawing.Point(4, 22);
			this.tabPagePassport.Name = "tabPagePassport";
			this.tabPagePassport.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPagePassport.Size = new global::System.Drawing.Size(705, 457);
			this.tabPagePassport.TabIndex = 3;
			this.tabPagePassport.Text = "Паспорт";
			this.tabPagePassport.UseVisualStyleBackColor = true;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.groupBoxCablePassport);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Size = new global::System.Drawing.Size(699, 451);
			this.splitContainer1.SplitterDistance = 340;
			this.splitContainer1.TabIndex = 1;
			this.groupBoxCablePassport.Controls.Add(this.cablePropDataGridView);
			this.groupBoxCablePassport.Controls.Add(this.checkBoxCableLenght);
			this.groupBoxCablePassport.Controls.Add(this.checkBoxCableCrossSection);
			this.groupBoxCablePassport.Controls.Add(this.checkBoxCableWires);
			this.groupBoxCablePassport.Controls.Add(this.checkBoxCableVoltage);
			this.groupBoxCablePassport.Controls.Add(this.JkIeHaOeLT);
			this.groupBoxCablePassport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBoxCablePassport.Location = new global::System.Drawing.Point(0, 0);
			this.groupBoxCablePassport.Name = "groupBoxCablePassport";
			this.groupBoxCablePassport.Size = new global::System.Drawing.Size(340, 451);
			this.groupBoxCablePassport.TabIndex = 0;
			this.groupBoxCablePassport.TabStop = false;
			this.groupBoxCablePassport.Text = "Кабель";
			this.cablePropDataGridView.AllowUserToAddRows = false;
			this.cablePropDataGridView.AllowUserToDeleteRows = false;
			this.cablePropDataGridView.BackgroundColor = global::System.Drawing.Color.White;
			this.cablePropDataGridView.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cablePropDataGridView.ColumnHeadersVisible = false;
			this.cablePropDataGridView.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.NameProperty,
				this.ValueProperty
			});
			this.cablePropDataGridView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.cablePropDataGridView.Location = new global::System.Drawing.Point(3, 16);
			this.cablePropDataGridView.MultiSelect = false;
			this.cablePropDataGridView.Name = "cablePropDataGridView";
			this.cablePropDataGridView.RowHeadersVisible = false;
			this.cablePropDataGridView.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.cablePropDataGridView.Size = new global::System.Drawing.Size(334, 432);
			this.cablePropDataGridView.TabIndex = 5;
			this.cablePropDataGridView.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.cablePropDataGridView_CellContentClick);
			this.NameProperty.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameProperty.HeaderText = "Column1";
			this.NameProperty.Name = "NameProperty";
			this.NameProperty.ReadOnly = true;
			this.NameProperty.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.ValueProperty.FillWeight = 25f;
			this.ValueProperty.HeaderText = "Column1";
			this.ValueProperty.Name = "ValueProperty";
			this.ValueProperty.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.ValueProperty.Width = 25;
			this.checkBoxCableLenght.AutoSize = true;
			this.checkBoxCableLenght.Location = new global::System.Drawing.Point(220, 19);
			this.checkBoxCableLenght.Name = "checkBoxCableLenght";
			this.checkBoxCableLenght.Size = new global::System.Drawing.Size(98, 17);
			this.checkBoxCableLenght.TabIndex = 4;
			this.checkBoxCableLenght.Text = "Длина кабеля";
			this.checkBoxCableLenght.UseVisualStyleBackColor = true;
			this.checkBoxCableLenght.CheckedChanged += new global::System.EventHandler(this.checkBoxCableLenght_CheckedChanged);
			this.checkBoxCableCrossSection.AutoSize = true;
			this.checkBoxCableCrossSection.Location = new global::System.Drawing.Point(139, 42);
			this.checkBoxCableCrossSection.Name = "checkBoxCableCrossSection";
			this.checkBoxCableCrossSection.Size = new global::System.Drawing.Size(107, 17);
			this.checkBoxCableCrossSection.TabIndex = 3;
			this.checkBoxCableCrossSection.Text = "Сечение кабеля";
			this.checkBoxCableCrossSection.UseVisualStyleBackColor = true;
			this.checkBoxCableCrossSection.CheckedChanged += new global::System.EventHandler(this.checkBoxCableCrossSection_CheckedChanged);
			this.checkBoxCableWires.AutoSize = true;
			this.checkBoxCableWires.Location = new global::System.Drawing.Point(139, 19);
			this.checkBoxCableWires.Name = "checkBoxCableWires";
			this.checkBoxCableWires.Size = new global::System.Drawing.Size(147, 17);
			this.checkBoxCableWires.TabIndex = 2;
			this.checkBoxCableWires.Text = "Количество жил кабеля";
			this.checkBoxCableWires.UseVisualStyleBackColor = true;
			this.checkBoxCableWires.CheckedChanged += new global::System.EventHandler(this.checkBoxCableWires_CheckedChanged);
			this.checkBoxCableVoltage.AutoSize = true;
			this.checkBoxCableVoltage.Location = new global::System.Drawing.Point(6, 42);
			this.checkBoxCableVoltage.Name = "checkBoxCableVoltage";
			this.checkBoxCableVoltage.Size = new global::System.Drawing.Size(129, 17);
			this.checkBoxCableVoltage.TabIndex = 1;
			this.checkBoxCableVoltage.Text = "Напряжение кабеля";
			this.checkBoxCableVoltage.UseVisualStyleBackColor = true;
			this.checkBoxCableVoltage.CheckedChanged += new global::System.EventHandler(this.checkBoxCableVoltage_CheckedChanged);
			this.JkIeHaOeLT.AutoSize = true;
			this.JkIeHaOeLT.Location = new global::System.Drawing.Point(6, 19);
			this.JkIeHaOeLT.Name = "checkBoxCableMakeup";
			this.JkIeHaOeLT.Size = new global::System.Drawing.Size(98, 17);
			this.JkIeHaOeLT.TabIndex = 0;
			this.JkIeHaOeLT.Text = "Марка кабеля";
			this.JkIeHaOeLT.UseVisualStyleBackColor = true;
			this.JkIeHaOeLT.CheckedChanged += new global::System.EventHandler(this.JkIeHaOeLT_CheckedChanged);
			this.groupBox1.Controls.Add(this.hmoeAwgdZN);
			this.groupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(355, 451);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Трансформатор";
			this.hmoeAwgdZN.AllowUserToAddRows = false;
			this.hmoeAwgdZN.AllowUserToDeleteRows = false;
			this.hmoeAwgdZN.BackgroundColor = global::System.Drawing.Color.White;
			this.hmoeAwgdZN.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.hmoeAwgdZN.ColumnHeadersVisible = false;
			this.hmoeAwgdZN.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn1,
				this.dataGridViewCheckBoxColumn1
			});
			this.hmoeAwgdZN.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.hmoeAwgdZN.Location = new global::System.Drawing.Point(3, 16);
			this.hmoeAwgdZN.MultiSelect = false;
			this.hmoeAwgdZN.Name = "TransPropDataGridView";
			this.hmoeAwgdZN.RowHeadersVisible = false;
			this.hmoeAwgdZN.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.hmoeAwgdZN.Size = new global::System.Drawing.Size(349, 432);
			this.hmoeAwgdZN.TabIndex = 5;
			this.hmoeAwgdZN.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.hmoeAwgdZN_CellContentClick);
			this.dataGridViewTextBoxColumn1.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewCheckBoxColumn1.FillWeight = 25f;
			this.dataGridViewCheckBoxColumn1.HeaderText = "Column1";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewCheckBoxColumn1.Width = 25;
			this.tabPageInterface.Controls.Add(this.numericFontSize);
			this.tabPageInterface.Controls.Add(this.label5);
			this.tabPageInterface.Controls.Add(this.numericSizeIcon);
			this.tabPageInterface.Controls.Add(this.labelSizeIcon);
			this.tabPageInterface.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageInterface.Name = "tabPageInterface";
			this.tabPageInterface.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageInterface.Size = new global::System.Drawing.Size(705, 454);
			this.tabPageInterface.TabIndex = 1;
			this.tabPageInterface.Text = "Интерфейс";
			this.tabPageInterface.UseVisualStyleBackColor = true;
			this.numericFontSize.DecimalPlaces = 1;
			this.numericFontSize.Increment = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			this.numericFontSize.Location = new global::System.Drawing.Point(107, 58);
			this.numericFontSize.Name = "numericFontSize";
			this.numericFontSize.Size = new global::System.Drawing.Size(120, 20);
			this.numericFontSize.TabIndex = 3;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(16, 60);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(88, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Размер шрифта";
			this.numericSizeIcon.Location = new global::System.Drawing.Point(107, 17);
			this.numericSizeIcon.Name = "numericSizeIcon";
			this.numericSizeIcon.Size = new global::System.Drawing.Size(120, 20);
			this.numericSizeIcon.TabIndex = 1;
			this.labelSizeIcon.AutoSize = true;
			this.labelSizeIcon.Location = new global::System.Drawing.Point(16, 19);
			this.labelSizeIcon.Name = "labelSizeIcon";
			this.labelSizeIcon.Size = new global::System.Drawing.Size(85, 13);
			this.labelSizeIcon.TabIndex = 0;
			this.labelSizeIcon.Text = "Размер иконок";
			this.tabPageOPCConfig.Controls.Add(this.groupBoxMeasurement);
			this.tabPageOPCConfig.Controls.Add(this.groupBox_0);
			this.tabPageOPCConfig.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageOPCConfig.Name = "tabPageOPCConfig";
			this.tabPageOPCConfig.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageOPCConfig.Size = new global::System.Drawing.Size(705, 454);
			this.tabPageOPCConfig.TabIndex = 2;
			this.tabPageOPCConfig.Text = "Сопутствующие данные";
			this.tabPageOPCConfig.UseVisualStyleBackColor = true;
			this.groupBoxMeasurement.Controls.Add(this.comboBoxMeasurementYear);
			this.groupBoxMeasurement.Controls.Add(this.label10);
			this.groupBoxMeasurement.Location = new global::System.Drawing.Point(6, 166);
			this.groupBoxMeasurement.Name = "groupBoxMeasurement";
			this.groupBoxMeasurement.Size = new global::System.Drawing.Size(690, 63);
			this.groupBoxMeasurement.TabIndex = 10;
			this.groupBoxMeasurement.TabStop = false;
			this.groupBoxMeasurement.Text = "Замеры";
			this.comboBoxMeasurementYear.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMeasurementYear.FormattingEnabled = true;
			this.comboBoxMeasurementYear.Location = new global::System.Drawing.Point(170, 23);
			this.comboBoxMeasurementYear.Name = "comboBoxMeasurementYear";
			this.comboBoxMeasurementYear.Size = new global::System.Drawing.Size(100, 21);
			this.comboBoxMeasurementYear.TabIndex = 5;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(6, 26);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(72, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Год замеров";
			this.groupBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox_0.Controls.Add(this.label6);
			this.groupBox_0.Controls.Add(this.groupBoxAutoReconnect);
			this.groupBox_0.Controls.Add(this.textBoxIPAddressOPCServer);
			this.groupBox_0.Controls.Add(this.label9);
			this.groupBox_0.Controls.Add(this.textBoxPortOPCServer);
			this.groupBox_0.Controls.Add(this.label8);
			this.groupBox_0.Controls.Add(this.textBoxServerOPCConfig);
			this.groupBox_0.Controls.Add(this.label7);
			this.groupBox_0.Controls.Add(this.textBoxBaseOPCConfig);
			this.groupBox_0.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox_0.Name = "groupBoxOPC";
			this.groupBox_0.Size = new global::System.Drawing.Size(690, 154);
			this.groupBox_0.TabIndex = 9;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Конфигурация OPC";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(6, 33);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(158, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "IP адрес сервера телеметрии";
			this.groupBoxAutoReconnect.Controls.Add(this.textBoxItervalReconnect);
			this.groupBoxAutoReconnect.Controls.Add(this.labelIntervalReconnect);
			this.groupBoxAutoReconnect.Controls.Add(this.checkBoxAutoReconnect);
			this.groupBoxAutoReconnect.Location = new global::System.Drawing.Point(288, 19);
			this.groupBoxAutoReconnect.Name = "groupBoxAutoReconnect";
			this.groupBoxAutoReconnect.Size = new global::System.Drawing.Size(221, 114);
			this.groupBoxAutoReconnect.TabIndex = 8;
			this.groupBoxAutoReconnect.TabStop = false;
			this.textBoxItervalReconnect.Enabled = false;
			this.textBoxItervalReconnect.Location = new global::System.Drawing.Point(6, 72);
			this.textBoxItervalReconnect.Name = "textBoxItervalReconnect";
			this.textBoxItervalReconnect.Size = new global::System.Drawing.Size(204, 20);
			this.textBoxItervalReconnect.TabIndex = 2;
			this.labelIntervalReconnect.AutoSize = true;
			this.labelIntervalReconnect.Location = new global::System.Drawing.Point(6, 50);
			this.labelIntervalReconnect.Name = "labelIntervalReconnect";
			this.labelIntervalReconnect.Size = new global::System.Drawing.Size(150, 13);
			this.labelIntervalReconnect.TabIndex = 1;
			this.labelIntervalReconnect.Text = "Интервал переподключения";
			this.checkBoxAutoReconnect.AutoSize = true;
			this.checkBoxAutoReconnect.Location = new global::System.Drawing.Point(6, 14);
			this.checkBoxAutoReconnect.Name = "checkBoxAutoReconnect";
			this.checkBoxAutoReconnect.Size = new global::System.Drawing.Size(204, 17);
			this.checkBoxAutoReconnect.TabIndex = 0;
			this.checkBoxAutoReconnect.Text = "Автоматическое переподключение";
			this.checkBoxAutoReconnect.UseVisualStyleBackColor = true;
			this.checkBoxAutoReconnect.CheckedChanged += new global::System.EventHandler(this.checkBoxAutoReconnect_CheckedChanged);
			this.textBoxIPAddressOPCServer.Location = new global::System.Drawing.Point(170, 26);
			this.textBoxIPAddressOPCServer.Name = "textBoxIPAddressOPCServer";
			this.textBoxIPAddressOPCServer.Size = new global::System.Drawing.Size(100, 20);
			this.textBoxIPAddressOPCServer.TabIndex = 0;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(6, 116);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(107, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "База конфигурации";
			this.textBoxPortOPCServer.Location = new global::System.Drawing.Point(170, 55);
			this.textBoxPortOPCServer.Name = "textBoxPortOPCServer";
			this.textBoxPortOPCServer.Size = new global::System.Drawing.Size(100, 20);
			this.textBoxPortOPCServer.TabIndex = 1;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(6, 90);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(119, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Сервер конфигурации";
			this.textBoxServerOPCConfig.Location = new global::System.Drawing.Point(170, 84);
			this.textBoxServerOPCConfig.Name = "textBoxServerOPCConfig";
			this.textBoxServerOPCConfig.Size = new global::System.Drawing.Size(100, 20);
			this.textBoxServerOPCConfig.TabIndex = 2;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(6, 64);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(140, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Порт сервера телеметрии";
			this.textBoxBaseOPCConfig.Location = new global::System.Drawing.Point(170, 113);
			this.textBoxBaseOPCConfig.Name = "textBoxBaseOPCConfig";
			this.textBoxBaseOPCConfig.Size = new global::System.Drawing.Size(100, 20);
			this.textBoxBaseOPCConfig.TabIndex = 3;
			this.buttonOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(465, 498);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(627, 498);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Закрыть";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.fontDialog_0.ShowColor = true;
			this.groupBoxSettings.BackColor = global::System.Drawing.SystemColors.ControlDark;
			this.groupBoxSettings.Controls.Add(this.radioButtonIndividual);
			this.groupBoxSettings.Controls.Add(this.radioButtonGeneral);
			this.groupBoxSettings.Location = new global::System.Drawing.Point(2, 489);
			this.groupBoxSettings.Name = "groupBoxSettings";
			this.groupBoxSettings.Size = new global::System.Drawing.Size(325, 40);
			this.groupBoxSettings.TabIndex = 3;
			this.groupBoxSettings.TabStop = false;
			this.groupBoxSettings.Text = "Использовать";
			this.radioButtonIndividual.AutoSize = true;
			this.radioButtonIndividual.Location = new global::System.Drawing.Point(143, 17);
			this.radioButtonIndividual.Name = "radioButtonIndividual";
			this.radioButtonIndividual.Size = new global::System.Drawing.Size(166, 17);
			this.radioButtonIndividual.TabIndex = 1;
			this.radioButtonIndividual.Text = "индивидуальные настройки";
			this.radioButtonIndividual.UseVisualStyleBackColor = true;
			this.radioButtonGeneral.AutoSize = true;
			this.radioButtonGeneral.Checked = true;
			this.radioButtonGeneral.Location = new global::System.Drawing.Point(6, 17);
			this.radioButtonGeneral.Name = "radioButtonGeneral";
			this.radioButtonGeneral.Size = new global::System.Drawing.Size(114, 17);
			this.radioButtonGeneral.TabIndex = 0;
			this.radioButtonGeneral.TabStop = true;
			this.radioButtonGeneral.Text = "общие настройки";
			this.radioButtonGeneral.UseVisualStyleBackColor = true;
			this.radioButtonGeneral.CheckedChanged += new global::System.EventHandler(this.radioButtonGeneral_CheckedChanged);
			this.buttonApply.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonApply.Location = new global::System.Drawing.Point(546, 498);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new global::System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 4;
			this.buttonApply.Text = "Применить";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new global::System.EventHandler(this.buttonApply_Click);
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(714, 533);
			base.Controls.Add(this.buttonApply);
			base.Controls.Add(this.groupBoxSettings);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.tabControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "FormCanvasSettings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Настройки";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormCanvasSettings_FormClosing);
			this.tabControl.ResumeLayout(false);
			this.tabPageColor.ResumeLayout(false);
			this.tabPageColor.PerformLayout();
			this.panelFontNoVisible.ResumeLayout(false);
			this.panelFontNoVisible.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownFontNoVisible).EndInit();
			this.groupBoxGrid.ResumeLayout(false);
			this.groupBoxGrid.PerformLayout();
			this.panelZoomSimply.ResumeLayout(false);
			this.panelZoomSimply.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownZoomSimply).EndInit();
			this.panelColorNormal.ResumeLayout(false);
			this.panelColorNormal.PerformLayout();
			this.panelColorOff.ResumeLayout(false);
			this.panelColorOff.PerformLayout();
			this.panelSelectedColor.ResumeLayout(false);
			this.panelSelectedColor.PerformLayout();
			this.panelColor.ResumeLayout(false);
			this.panelColor.PerformLayout();
			this.tabPagePassport.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.groupBoxCablePassport.ResumeLayout(false);
			this.groupBoxCablePassport.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cablePropDataGridView).EndInit();
			this.groupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.hmoeAwgdZN).EndInit();
			this.tabPageInterface.ResumeLayout(false);
			this.tabPageInterface.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericFontSize).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSizeIcon).EndInit();
			this.tabPageOPCConfig.ResumeLayout(false);
			this.groupBoxMeasurement.ResumeLayout(false);
			this.groupBoxMeasurement.PerformLayout();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBoxAutoReconnect.ResumeLayout(false);
			this.groupBoxAutoReconnect.PerformLayout();
			this.groupBoxSettings.ResumeLayout(false);
			this.groupBoxSettings.PerformLayout();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.TabControl tabControl;

		private global::System.Windows.Forms.TabPage tabPageColor;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.GroupBox groupBoxGrid;

		private global::System.Windows.Forms.RadioButton radioButtonLine;

		private global::System.Windows.Forms.RadioButton radioButtonDots;

		private global::System.Windows.Forms.ColorDialog colorDialog_0;

		private global::SchemeCtrl2.Canvas.CanvasControl canvasColor;

		private global::System.Windows.Forms.TreeView treeViewColors;

		private global::System.Windows.Forms.Panel panelSelectedColor;

		private global::System.Windows.Forms.Panel panelSelctedColorSel;

		private global::System.Windows.Forms.Label labelSelectedColor;

		private global::System.Windows.Forms.Panel panelColor;

		private global::System.Windows.Forms.Panel panelColorSel;

		private global::System.Windows.Forms.Label labelColor;

		private global::System.Windows.Forms.Panel panelColorOff;

		private global::System.Windows.Forms.Panel panelColorOffSel;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.RadioButton radioButtonNoVisibleGrid;

		private global::System.Windows.Forms.Button buttonFont;

		private global::System.Windows.Forms.FontDialog fontDialog_0;

		private global::System.Windows.Forms.Panel panelColorNormal;

		private global::System.Windows.Forms.Panel panelColorNormalSel;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.CheckBox checkBoxColorLine;

		private global::System.Windows.Forms.ComboBox cmbQualityImage;

		private global::System.Windows.Forms.GroupBox groupBoxSettings;

		private global::System.Windows.Forms.RadioButton radioButtonIndividual;

		private global::System.Windows.Forms.RadioButton radioButtonGeneral;

		private global::System.Windows.Forms.Button buttonApply;

		private global::System.Windows.Forms.Panel panelZoomSimply;

		private global::System.Windows.Forms.NumericUpDown numericUpDownZoomSimply;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.Panel panelFontNoVisible;

		private global::System.Windows.Forms.NumericUpDown numericUpDownFontNoVisible;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.TabPage tabPageInterface;

		private global::System.Windows.Forms.NumericUpDown numericSizeIcon;

		private global::System.Windows.Forms.Label labelSizeIcon;

		private global::System.Windows.Forms.NumericUpDown numericFontSize;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.TabPage tabPageOPCConfig;

		private global::System.Windows.Forms.Label label8;

		private global::System.Windows.Forms.Label label7;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.TextBox textBoxBaseOPCConfig;

		private global::System.Windows.Forms.TextBox textBoxServerOPCConfig;

		private global::System.Windows.Forms.TextBox textBoxPortOPCServer;

		private global::System.Windows.Forms.TextBox textBoxIPAddressOPCServer;

		private global::System.Windows.Forms.Label label9;

		private global::System.Windows.Forms.GroupBox groupBoxAutoReconnect;

		private global::System.Windows.Forms.TextBox textBoxItervalReconnect;

		private global::System.Windows.Forms.Label labelIntervalReconnect;

		private global::System.Windows.Forms.CheckBox checkBoxAutoReconnect;

		private global::System.Windows.Forms.TabPage tabPagePassport;

		private global::System.Windows.Forms.GroupBox groupBoxCablePassport;

		private global::System.Windows.Forms.CheckBox JkIeHaOeLT;

		private global::System.Windows.Forms.CheckBox checkBoxCableCrossSection;

		private global::System.Windows.Forms.CheckBox checkBoxCableWires;

		private global::System.Windows.Forms.CheckBox checkBoxCableVoltage;

		private global::System.Windows.Forms.CheckBox checkBoxCableLenght;

		private global::System.Windows.Forms.SplitContainer splitContainer1;

		private global::System.Windows.Forms.DataGridView cablePropDataGridView;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn NameProperty;

		private global::System.Windows.Forms.DataGridViewCheckBoxColumn ValueProperty;

		private global::System.Windows.Forms.DataGridView hmoeAwgdZN;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		private global::System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;

		private global::System.Windows.Forms.GroupBox groupBoxMeasurement;

		private global::System.Windows.Forms.ComboBox comboBoxMeasurementYear;

		private global::System.Windows.Forms.Label label10;

		private global::System.Windows.Forms.GroupBox groupBox_0;
	}
}
