namespace SchemeCtrl2.Layers.Forms
{
	public partial class FormPatternSettings : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SchemeCtrl2.Layers.Forms.FormPatternSettings));
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cmbTypeSubstation = new global::System.Windows.Forms.ComboBox();
			this.bindingSource_0 = new global::System.Windows.Forms.BindingSource(this.icontainer_0);
			this.dataSet_0 = new global::System.Data.DataSet();
			this.dataTable_0 = new global::System.Data.DataTable();
			this.dataColumn_0 = new global::System.Data.DataColumn();
			this.dataColumn_1 = new global::System.Data.DataColumn();
			this.dataColumn_2 = new global::System.Data.DataColumn();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBoxSubstation = new global::System.Windows.Forms.GroupBox();
			this.groupBoxTextDirect = new global::System.Windows.Forms.GroupBox();
			this.radioButtonVertical = new global::System.Windows.Forms.RadioButton();
			this.radioButtonGorizontal = new global::System.Windows.Forms.RadioButton();
			this.groupBoxOrientation = new global::System.Windows.Forms.GroupBox();
			this.radioButtonLT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonL = new global::System.Windows.Forms.RadioButton();
			this.radioButtonNotVisible = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonRB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonR = new global::System.Windows.Forms.RadioButton();
			this.radioButtonRT = new global::System.Windows.Forms.RadioButton();
			this.txtNameSubstation = new global::System.Windows.Forms.TextBox();
			this.canvasPattern = new global::SchemeCtrl2.Canvas.CanvasControl();
			this.groupBoxShins = new global::System.Windows.Forms.GroupBox();
			this.numericUpDownDistanceShins = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.checkBoxVisibleTextShins = new global::System.Windows.Forms.CheckBox();
			this.cmbTypeShins = new global::System.Windows.Forms.ComboBox();
			this.bindingSource_1 = new global::System.Windows.Forms.BindingSource(this.icontainer_0);
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.radioButtonVericalShins = new global::System.Windows.Forms.RadioButton();
			this.radioButtonGorizontalShins = new global::System.Windows.Forms.RadioButton();
			this.label3 = new global::System.Windows.Forms.Label();
			this.numericUpDownCountShins = new global::System.Windows.Forms.NumericUpDown();
			this.groupBoxCells = new global::System.Windows.Forms.GroupBox();
			this.groupBoxOrientCells = new global::System.Windows.Forms.GroupBox();
			this.radioButtonCellsBottom = new global::System.Windows.Forms.RadioButton();
			this.radioButtonCellsTop = new global::System.Windows.Forms.RadioButton();
			this.numericUpDownCountCells = new global::System.Windows.Forms.NumericUpDown();
			this.label6 = new global::System.Windows.Forms.Label();
			this.dgvSwitchs = new global::System.Windows.Forms.DataGridView();
			this.columnTypeSwitch = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
			this.bindingSource_2 = new global::System.Windows.Forms.BindingSource(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
			this.groupBoxSubstation.SuspendLayout();
			this.groupBoxTextDirect.SuspendLayout();
			this.groupBoxOrientation.SuspendLayout();
			this.groupBoxShins.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownDistanceShins).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource_1).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownCountShins).BeginInit();
			this.groupBoxCells.SuspendLayout();
			this.groupBoxOrientCells.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownCountCells).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSwitchs).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource_2).BeginInit();
			base.SuspendLayout();
			this.buttonOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(12, 404);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(281, 404);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(9, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(26, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Тип";
			this.cmbTypeSubstation.DataSource = this.bindingSource_0;
			this.cmbTypeSubstation.DisplayMember = "name";
			this.cmbTypeSubstation.FormattingEnabled = true;
			this.cmbTypeSubstation.Location = new global::System.Drawing.Point(9, 32);
			this.cmbTypeSubstation.Name = "cmbTypeSubstation";
			this.cmbTypeSubstation.Size = new global::System.Drawing.Size(108, 21);
			this.cmbTypeSubstation.TabIndex = 4;
			this.cmbTypeSubstation.ValueMember = "ID";
			this.cmbTypeSubstation.SelectedValueChanged += new global::System.EventHandler(this.cmbTypeSubstation_SelectedValueChanged);
			this.bindingSource_0.DataMember = "tR_Classifier";
			this.bindingSource_0.DataSource = this.dataSet_0;
			this.bindingSource_0.Filter = "parentKey = ';SCM;PS;'";
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new global::System.Data.DataTable[]
			{
				this.dataTable_0
			});
			this.dataTable_0.Columns.AddRange(new global::System.Data.DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2
			});
			this.dataTable_0.TableName = "tR_Classifier";
			this.dataColumn_0.ColumnName = "ID";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "name";
			this.dataColumn_2.ColumnName = "ParentKey";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(136, 16);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(29, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Имя";
			this.groupBoxSubstation.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.groupBoxSubstation.Controls.Add(this.groupBoxTextDirect);
			this.groupBoxSubstation.Controls.Add(this.groupBoxOrientation);
			this.groupBoxSubstation.Controls.Add(this.txtNameSubstation);
			this.groupBoxSubstation.Controls.Add(this.label1);
			this.groupBoxSubstation.Controls.Add(this.label2);
			this.groupBoxSubstation.Controls.Add(this.cmbTypeSubstation);
			this.groupBoxSubstation.Location = new global::System.Drawing.Point(3, -1);
			this.groupBoxSubstation.Name = "groupBoxSubstation";
			this.groupBoxSubstation.Size = new global::System.Drawing.Size(353, 161);
			this.groupBoxSubstation.TabIndex = 6;
			this.groupBoxSubstation.TabStop = false;
			this.groupBoxSubstation.Text = "Подстанция";
			this.groupBoxTextDirect.AutoSize = true;
			this.groupBoxTextDirect.Controls.Add(this.radioButtonVertical);
			this.groupBoxTextDirect.Controls.Add(this.radioButtonGorizontal);
			this.groupBoxTextDirect.Location = new global::System.Drawing.Point(234, 59);
			this.groupBoxTextDirect.Name = "groupBoxTextDirect";
			this.groupBoxTextDirect.Size = new global::System.Drawing.Size(115, 92);
			this.groupBoxTextDirect.TabIndex = 15;
			this.groupBoxTextDirect.TabStop = false;
			this.groupBoxTextDirect.Text = "Направление текста";
			this.radioButtonVertical.AutoSize = true;
			this.radioButtonVertical.Location = new global::System.Drawing.Point(7, 56);
			this.radioButtonVertical.Name = "radioButtonVertical";
			this.radioButtonVertical.Size = new global::System.Drawing.Size(91, 17);
			this.radioButtonVertical.TabIndex = 1;
			this.radioButtonVertical.Text = "Вертикально";
			this.radioButtonVertical.UseVisualStyleBackColor = true;
			this.radioButtonGorizontal.AutoSize = true;
			this.radioButtonGorizontal.Checked = true;
			this.radioButtonGorizontal.Location = new global::System.Drawing.Point(7, 33);
			this.radioButtonGorizontal.Name = "radioButtonGorizontal";
			this.radioButtonGorizontal.Size = new global::System.Drawing.Size(102, 17);
			this.radioButtonGorizontal.TabIndex = 0;
			this.radioButtonGorizontal.TabStop = true;
			this.radioButtonGorizontal.Text = "Горизонтально";
			this.radioButtonGorizontal.UseVisualStyleBackColor = true;
			this.radioButtonGorizontal.CheckedChanged += new global::System.EventHandler(this.radioButtonGorizontal_CheckedChanged);
			this.groupBoxOrientation.Controls.Add(this.radioButtonLT);
			this.groupBoxOrientation.Controls.Add(this.radioButtonT);
			this.groupBoxOrientation.Controls.Add(this.radioButtonL);
			this.groupBoxOrientation.Controls.Add(this.radioButtonNotVisible);
			this.groupBoxOrientation.Controls.Add(this.radioButtonLB);
			this.groupBoxOrientation.Controls.Add(this.radioButtonRB);
			this.groupBoxOrientation.Controls.Add(this.radioButtonB);
			this.groupBoxOrientation.Controls.Add(this.radioButtonR);
			this.groupBoxOrientation.Controls.Add(this.radioButtonRT);
			this.groupBoxOrientation.Location = new global::System.Drawing.Point(9, 59);
			this.groupBoxOrientation.Name = "groupBoxOrientation";
			this.groupBoxOrientation.Size = new global::System.Drawing.Size(221, 92);
			this.groupBoxOrientation.TabIndex = 14;
			this.groupBoxOrientation.TabStop = false;
			this.groupBoxOrientation.Text = "Ориентация";
			this.radioButtonLT.AutoSize = true;
			this.radioButtonLT.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonLT.Name = "radioButtonLT";
			this.radioButtonLT.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonLT.TabIndex = 3;
			this.radioButtonLT.Text = "LT";
			this.radioButtonLT.UseVisualStyleBackColor = true;
			this.radioButtonLT.CheckedChanged += new global::System.EventHandler(this.radioButtonRT_CheckedChanged);
			this.radioButtonT.AutoSize = true;
			this.radioButtonT.Location = new global::System.Drawing.Point(50, 19);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonT.TabIndex = 2;
			this.radioButtonT.Text = "T";
			this.radioButtonT.UseVisualStyleBackColor = true;
			this.radioButtonT.CheckedChanged += new global::System.EventHandler(this.radioButtonRT_CheckedChanged);
			this.radioButtonL.AutoSize = true;
			this.radioButtonL.Location = new global::System.Drawing.Point(6, 42);
			this.radioButtonL.Name = "radioButtonL";
			this.radioButtonL.Size = new global::System.Drawing.Size(31, 17);
			this.radioButtonL.TabIndex = 4;
			this.radioButtonL.Text = "L";
			this.radioButtonL.UseVisualStyleBackColor = true;
			this.radioButtonL.CheckedChanged += new global::System.EventHandler(this.radioButtonRT_CheckedChanged);
			this.radioButtonNotVisible.AutoSize = true;
			this.radioButtonNotVisible.Checked = true;
			this.radioButtonNotVisible.Location = new global::System.Drawing.Point(134, 33);
			this.radioButtonNotVisible.Name = "radioButtonNotVisible";
			this.radioButtonNotVisible.Size = new global::System.Drawing.Size(85, 30);
			this.radioButtonNotVisible.TabIndex = 10;
			this.radioButtonNotVisible.TabStop = true;
			this.radioButtonNotVisible.Text = "не \r\nотображать";
			this.radioButtonNotVisible.UseVisualStyleBackColor = true;
			this.radioButtonNotVisible.CheckedChanged += new global::System.EventHandler(this.radioButtonNotVisible_CheckedChanged);
			this.radioButtonLB.AutoSize = true;
			this.radioButtonLB.Location = new global::System.Drawing.Point(6, 65);
			this.radioButtonLB.Name = "radioButtonLB";
			this.radioButtonLB.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonLB.TabIndex = 5;
			this.radioButtonLB.Text = "LB";
			this.radioButtonLB.UseVisualStyleBackColor = true;
			this.radioButtonLB.CheckedChanged += new global::System.EventHandler(this.radioButtonRT_CheckedChanged);
			this.radioButtonRB.AutoSize = true;
			this.radioButtonRB.Location = new global::System.Drawing.Point(88, 65);
			this.radioButtonRB.Name = "radioButtonRB";
			this.radioButtonRB.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonRB.TabIndex = 9;
			this.radioButtonRB.Text = "RB";
			this.radioButtonRB.UseVisualStyleBackColor = true;
			this.radioButtonRB.CheckedChanged += new global::System.EventHandler(this.radioButtonRT_CheckedChanged);
			this.radioButtonB.AutoSize = true;
			this.radioButtonB.Location = new global::System.Drawing.Point(50, 65);
			this.radioButtonB.Name = "radioButtonB";
			this.radioButtonB.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonB.TabIndex = 6;
			this.radioButtonB.Text = "B";
			this.radioButtonB.UseVisualStyleBackColor = true;
			this.radioButtonB.CheckedChanged += new global::System.EventHandler(this.radioButtonRT_CheckedChanged);
			this.radioButtonR.AutoSize = true;
			this.radioButtonR.Location = new global::System.Drawing.Point(88, 42);
			this.radioButtonR.Name = "radioButtonR";
			this.radioButtonR.Size = new global::System.Drawing.Size(33, 17);
			this.radioButtonR.TabIndex = 8;
			this.radioButtonR.Text = "R";
			this.radioButtonR.UseVisualStyleBackColor = true;
			this.radioButtonR.CheckedChanged += new global::System.EventHandler(this.radioButtonRT_CheckedChanged);
			this.radioButtonRT.AutoSize = true;
			this.radioButtonRT.Location = new global::System.Drawing.Point(88, 19);
			this.radioButtonRT.Name = "radioButtonRT";
			this.radioButtonRT.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonRT.TabIndex = 7;
			this.radioButtonRT.Text = "RT";
			this.radioButtonRT.UseVisualStyleBackColor = true;
			this.radioButtonRT.CheckedChanged += new global::System.EventHandler(this.radioButtonRT_CheckedChanged);
			this.txtNameSubstation.Location = new global::System.Drawing.Point(139, 32);
			this.txtNameSubstation.Name = "txtNameSubstation";
			this.txtNameSubstation.Size = new global::System.Drawing.Size(208, 20);
			this.txtNameSubstation.TabIndex = 6;
			this.txtNameSubstation.TextChanged += new global::System.EventHandler(this.txtNameSubstation_TextChanged);
			this.canvasPattern.ActiveLayer = null;
			this.canvasPattern.AllowDrop = true;
			this.canvasPattern.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.canvasPattern.CurrentMetric = global::SchemeCtrl2.Canvas.eMetric.sm;
			this.canvasPattern.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.canvasPattern.DeltaPoint = (global::System.Drawing.PointF)componentResourceManager.GetObject("canvasPattern.DeltaPoint");
			this.canvasPattern.Location = new global::System.Drawing.Point(362, -1);
			this.canvasPattern.Name = "canvasPattern";
			this.canvasPattern.Mode = global::SchemeCtrl2.Canvas.eCanvasEditingMode.ReadOnly;
			this.canvasPattern.SchemeName = "schema1";
			this.canvasPattern.Size = new global::System.Drawing.Size(382, 439);
			this.canvasPattern.SqlSettings = null;
			this.canvasPattern.StatusStripVisible = false;
			this.canvasPattern.TabIndex = 0;
			this.canvasPattern.TypeCanvas = global::SchemeCtrl2.Canvas.eTypeCanvas.SchemeMain;
			this.canvasPattern.UseObjectFromDB = false;
			this.canvasPattern.VisibleCanvasSchemeMap = false;
			this.canvasPattern.VisibleSaveProgressBar = false;
			this.canvasPattern.WorkerCounter = 0;
			this.canvasPattern.Zoom = 1f;
			this.canvasPattern.Resize += new global::System.EventHandler(this.canvasPattern_Resize);
			this.groupBoxShins.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.groupBoxShins.Controls.Add(this.numericUpDownDistanceShins);
			this.groupBoxShins.Controls.Add(this.label5);
			this.groupBoxShins.Controls.Add(this.checkBoxVisibleTextShins);
			this.groupBoxShins.Controls.Add(this.cmbTypeShins);
			this.groupBoxShins.Controls.Add(this.label4);
			this.groupBoxShins.Controls.Add(this.groupBox1);
			this.groupBoxShins.Controls.Add(this.label3);
			this.groupBoxShins.Controls.Add(this.numericUpDownCountShins);
			this.groupBoxShins.Location = new global::System.Drawing.Point(3, 166);
			this.groupBoxShins.Name = "groupBoxShins";
			this.groupBoxShins.Size = new global::System.Drawing.Size(353, 81);
			this.groupBoxShins.TabIndex = 7;
			this.groupBoxShins.TabStop = false;
			this.groupBoxShins.Text = "Шины";
			this.numericUpDownDistanceShins.DecimalPlaces = 1;
			this.numericUpDownDistanceShins.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownDistanceShins.Location = new global::System.Drawing.Point(295, 53);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownDistanceShins;
			int[] array = new int[4];
			array[0] = 10;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDownDistanceShins.Minimum = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownDistanceShins.Name = "numericUpDownDistanceShins";
			this.numericUpDownDistanceShins.Size = new global::System.Drawing.Size(52, 20);
			this.numericUpDownDistanceShins.TabIndex = 21;
			this.numericUpDownDistanceShins.Value = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownDistanceShins.ValueChanged += new global::System.EventHandler(this.sRgGqySrTa);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(243, 56);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(46, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Раст-ие";
			this.checkBoxVisibleTextShins.Checked = true;
			this.checkBoxVisibleTextShins.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBoxVisibleTextShins.Location = new global::System.Drawing.Point(243, 9);
			this.checkBoxVisibleTextShins.Name = "checkBoxVisibleTextShins";
			this.checkBoxVisibleTextShins.Size = new global::System.Drawing.Size(104, 38);
			this.checkBoxVisibleTextShins.TabIndex = 19;
			this.checkBoxVisibleTextShins.Text = "Показать номера шин";
			this.checkBoxVisibleTextShins.UseVisualStyleBackColor = true;
			this.checkBoxVisibleTextShins.CheckedChanged += new global::System.EventHandler(this.checkBoxVisibleTextShins_CheckedChanged);
			this.cmbTypeShins.DataSource = this.bindingSource_1;
			this.cmbTypeShins.DisplayMember = "name";
			this.cmbTypeShins.FormattingEnabled = true;
			this.cmbTypeShins.Location = new global::System.Drawing.Point(56, 53);
			this.cmbTypeShins.Name = "cmbTypeShins";
			this.cmbTypeShins.Size = new global::System.Drawing.Size(61, 21);
			this.cmbTypeShins.TabIndex = 18;
			this.cmbTypeShins.ValueMember = "ID";
			this.cmbTypeShins.SelectedIndexChanged += new global::System.EventHandler(this.cmbTypeShins_SelectedIndexChanged);
			this.bindingSource_1.DataMember = "tR_Classifier";
			this.bindingSource_1.DataSource = this.dataSet_0;
			this.bindingSource_1.Filter = "parentKey like ';SCM;BUS;%'";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(12, 56);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(26, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Тип";
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.radioButtonVericalShins);
			this.groupBox1.Controls.Add(this.radioButtonGorizontalShins);
			this.groupBox1.Location = new global::System.Drawing.Point(123, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(114, 75);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Направление шин";
			this.radioButtonVericalShins.AutoSize = true;
			this.radioButtonVericalShins.Location = new global::System.Drawing.Point(6, 39);
			this.radioButtonVericalShins.Name = "radioButtonVericalShins";
			this.radioButtonVericalShins.Size = new global::System.Drawing.Size(91, 17);
			this.radioButtonVericalShins.TabIndex = 1;
			this.radioButtonVericalShins.Text = "Вертикально";
			this.radioButtonVericalShins.UseVisualStyleBackColor = true;
			this.radioButtonGorizontalShins.AutoSize = true;
			this.radioButtonGorizontalShins.Checked = true;
			this.radioButtonGorizontalShins.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonGorizontalShins.Name = "radioButtonGorizontalShins";
			this.radioButtonGorizontalShins.Size = new global::System.Drawing.Size(102, 17);
			this.radioButtonGorizontalShins.TabIndex = 0;
			this.radioButtonGorizontalShins.TabStop = true;
			this.radioButtonGorizontalShins.Text = "Горизонтально";
			this.radioButtonGorizontalShins.UseVisualStyleBackColor = true;
			this.radioButtonGorizontalShins.CheckedChanged += new global::System.EventHandler(this.radioButtonGorizontalShins_CheckedChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(9, 21);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(41, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Кол-во";
			this.numericUpDownCountShins.Location = new global::System.Drawing.Point(56, 19);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDownCountShins;
			int[] array2 = new int[4];
			array2[0] = 10;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDownCountShins.Name = "numericUpDownCountShins";
			this.numericUpDownCountShins.Size = new global::System.Drawing.Size(61, 20);
			this.numericUpDownCountShins.TabIndex = 0;
			this.numericUpDownCountShins.ValueChanged += new global::System.EventHandler(this.numericUpDownCountShins_ValueChanged);
			this.groupBoxCells.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.groupBoxCells.Controls.Add(this.groupBoxOrientCells);
			this.groupBoxCells.Controls.Add(this.numericUpDownCountCells);
			this.groupBoxCells.Controls.Add(this.label6);
			this.groupBoxCells.Location = new global::System.Drawing.Point(3, 253);
			this.groupBoxCells.Name = "groupBoxCells";
			this.groupBoxCells.Size = new global::System.Drawing.Size(353, 60);
			this.groupBoxCells.TabIndex = 8;
			this.groupBoxCells.TabStop = false;
			this.groupBoxCells.Text = "Ячейки";
			this.groupBoxOrientCells.AutoSize = true;
			this.groupBoxOrientCells.Controls.Add(this.radioButtonCellsBottom);
			this.groupBoxOrientCells.Controls.Add(this.radioButtonCellsTop);
			this.groupBoxOrientCells.Location = new global::System.Drawing.Point(164, 14);
			this.groupBoxOrientCells.Name = "groupBoxOrientCells";
			this.groupBoxOrientCells.Size = new global::System.Drawing.Size(183, 55);
			this.groupBoxOrientCells.TabIndex = 17;
			this.groupBoxOrientCells.TabStop = false;
			this.groupBoxOrientCells.Text = "Направление ячеек";
			this.radioButtonCellsBottom.AutoSize = true;
			this.radioButtonCellsBottom.Location = new global::System.Drawing.Point(98, 19);
			this.radioButtonCellsBottom.Name = "radioButtonCellsBottom";
			this.radioButtonCellsBottom.Size = new global::System.Drawing.Size(55, 17);
			this.radioButtonCellsBottom.TabIndex = 1;
			this.radioButtonCellsBottom.Text = "Снизу";
			this.radioButtonCellsBottom.UseVisualStyleBackColor = true;
			this.radioButtonCellsTop.AutoSize = true;
			this.radioButtonCellsTop.Checked = true;
			this.radioButtonCellsTop.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonCellsTop.Name = "radioButtonCellsTop";
			this.radioButtonCellsTop.Size = new global::System.Drawing.Size(60, 17);
			this.radioButtonCellsTop.TabIndex = 0;
			this.radioButtonCellsTop.TabStop = true;
			this.radioButtonCellsTop.Text = "Сверху";
			this.radioButtonCellsTop.UseVisualStyleBackColor = true;
			this.radioButtonCellsTop.CheckedChanged += new global::System.EventHandler(this.radioButtonCellsTop_CheckedChanged);
			this.numericUpDownCountCells.Location = new global::System.Drawing.Point(103, 28);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDownCountCells;
			int[] array3 = new int[4];
			array3[0] = 10;
			numericUpDown3.Maximum = new decimal(array3);
			this.numericUpDownCountCells.Name = "numericUpDownCountCells";
			this.numericUpDownCountCells.Size = new global::System.Drawing.Size(61, 20);
			this.numericUpDownCountCells.TabIndex = 1;
			this.numericUpDownCountCells.ValueChanged += new global::System.EventHandler(this.numericUpDownCountCells_ValueChanged);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(12, 30);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(85, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Кол-во на шине";
			this.dgvSwitchs.AllowUserToResizeColumns = false;
			this.dgvSwitchs.AllowUserToResizeRows = false;
			this.dgvSwitchs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.dgvSwitchs.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSwitchs.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.columnTypeSwitch
			});
			this.dgvSwitchs.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgvSwitchs.Location = new global::System.Drawing.Point(3, 309);
			this.dgvSwitchs.Name = "dgvSwitchs";
			this.dgvSwitchs.RowHeadersWidth = 10;
			this.dgvSwitchs.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSwitchs.Size = new global::System.Drawing.Size(220, 89);
			this.dgvSwitchs.TabIndex = 9;
			this.dgvSwitchs.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSwitchs_CellValueChanged);
			this.dgvSwitchs.CurrentCellDirtyStateChanged += new global::System.EventHandler(this.dgvSwitchs_CurrentCellDirtyStateChanged);
			this.dgvSwitchs.EditingControlShowing += new global::System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSwitchs_EditingControlShowing);
			this.dgvSwitchs.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSwitchs_RowsAdded);
			this.dgvSwitchs.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvSwitchs_RowsRemoved);
			this.columnTypeSwitch.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnTypeSwitch.DataSource = this.bindingSource_2;
			this.columnTypeSwitch.DisplayMember = "name";
			this.columnTypeSwitch.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.columnTypeSwitch.HeaderText = "Коммутационный аппарат";
			this.columnTypeSwitch.Name = "columnTypeSwitch";
			this.columnTypeSwitch.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.columnTypeSwitch.ValueMember = "ID";
			this.bindingSource_2.DataMember = "tR_Classifier";
			this.bindingSource_2.DataSource = this.dataSet_0;
			this.bindingSource_2.Filter = "parentKey = ';SCM;INLINE_OBJ;SWITCH;'";
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(744, 439);
			base.Controls.Add(this.dgvSwitchs);
			base.Controls.Add(this.groupBoxCells);
			base.Controls.Add(this.groupBoxShins);
			base.Controls.Add(this.groupBoxSubstation);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.canvasPattern);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Name = "FormPatternSettings";
			this.Text = "Шаблон ТП";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormPatternSettings_FormClosing);
			base.Load += new global::System.EventHandler(this.FormPatternSettings_Load);
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
			this.groupBoxSubstation.ResumeLayout(false);
			this.groupBoxSubstation.PerformLayout();
			this.groupBoxTextDirect.ResumeLayout(false);
			this.groupBoxTextDirect.PerformLayout();
			this.groupBoxOrientation.ResumeLayout(false);
			this.groupBoxOrientation.PerformLayout();
			this.groupBoxShins.ResumeLayout(false);
			this.groupBoxShins.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownDistanceShins).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource_1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownCountShins).EndInit();
			this.groupBoxCells.ResumeLayout(false);
			this.groupBoxCells.PerformLayout();
			this.groupBoxOrientCells.ResumeLayout(false);
			this.groupBoxOrientCells.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownCountCells).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSwitchs).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource_2).EndInit();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::SchemeCtrl2.Canvas.CanvasControl canvasPattern;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.ComboBox cmbTypeSubstation;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.GroupBox groupBoxSubstation;

		private global::System.Windows.Forms.TextBox txtNameSubstation;

		private global::System.Windows.Forms.GroupBox groupBoxOrientation;

		private global::System.Windows.Forms.RadioButton radioButtonLT;

		private global::System.Windows.Forms.RadioButton radioButtonT;

		private global::System.Windows.Forms.RadioButton radioButtonL;

		private global::System.Windows.Forms.RadioButton radioButtonNotVisible;

		private global::System.Windows.Forms.RadioButton radioButtonLB;

		private global::System.Windows.Forms.RadioButton radioButtonRB;

		private global::System.Windows.Forms.RadioButton radioButtonB;

		private global::System.Windows.Forms.RadioButton radioButtonR;

		private global::System.Windows.Forms.RadioButton radioButtonRT;

		private global::System.Windows.Forms.GroupBox groupBoxTextDirect;

		private global::System.Windows.Forms.RadioButton radioButtonVertical;

		private global::System.Windows.Forms.RadioButton radioButtonGorizontal;

		private global::System.Data.DataSet dataSet_0;

		private global::System.Data.DataTable dataTable_0;

		private global::System.Data.DataColumn dataColumn_0;

		private global::System.Data.DataColumn dataColumn_1;

		private global::System.Windows.Forms.GroupBox groupBoxShins;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.NumericUpDown numericUpDownCountShins;

		private global::System.Windows.Forms.ComboBox cmbTypeShins;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.RadioButton radioButtonVericalShins;

		private global::System.Windows.Forms.RadioButton radioButtonGorizontalShins;

		private global::System.Windows.Forms.BindingSource bindingSource_0;

		private global::System.Data.DataColumn dataColumn_2;

		private global::System.Windows.Forms.BindingSource bindingSource_1;

		private global::System.Windows.Forms.CheckBox checkBoxVisibleTextShins;

		private global::System.Windows.Forms.NumericUpDown numericUpDownDistanceShins;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.GroupBox groupBoxCells;

		private global::System.Windows.Forms.NumericUpDown numericUpDownCountCells;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.GroupBox groupBoxOrientCells;

		private global::System.Windows.Forms.RadioButton radioButtonCellsBottom;

		private global::System.Windows.Forms.RadioButton radioButtonCellsTop;

		private global::System.Windows.Forms.DataGridView dgvSwitchs;

		private global::System.Windows.Forms.BindingSource bindingSource_2;

		private global::System.Windows.Forms.DataGridViewComboBoxColumn columnTypeSwitch;
	}
}
