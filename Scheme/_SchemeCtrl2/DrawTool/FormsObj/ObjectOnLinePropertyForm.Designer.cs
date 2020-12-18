namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class ObjectOnLinePropertyForm : global::System.Windows.Forms.Form
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
			this.vertMirrorCheckBox = new global::System.Windows.Forms.CheckBox();
			this.checkBoxNormal = new global::System.Windows.Forms.CheckBox();
			this.gorMirrorCheckBox = new global::System.Windows.Forms.CheckBox();
			this.groupBoxNormal = new global::System.Windows.Forms.GroupBox();
			this.radioButtonNormalLeft = new global::System.Windows.Forms.RadioButton();
			this.radioButtonNormalRight = new global::System.Windows.Forms.RadioButton();
			this.radioButtonNormalBottom = new global::System.Windows.Forms.RadioButton();
			this.radioButtonNormalTop = new global::System.Windows.Forms.RadioButton();
			this.textBoxName = new global::System.Windows.Forms.TextBox();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.onRadioButton = new global::System.Windows.Forms.RadioButton();
			this.offRadioButton = new global::System.Windows.Forms.RadioButton();
			this.groupBoxName = new global::System.Windows.Forms.GroupBox();
			this.radioButtonRB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonRT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonNotVisible = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonR = new global::System.Windows.Forms.RadioButton();
			this.radioButtonB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonL = new global::System.Windows.Forms.RadioButton();
			this.panelNormalSection = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panelOnOff = new global::System.Windows.Forms.Panel();
			this.labelOnOff = new global::System.Windows.Forms.Label();
			this.tabControl = new global::System.Windows.Forms.TabControl();
			this.tabPageGEneral = new global::System.Windows.Forms.TabPage();
			this.tabPageState = new global::System.Windows.Forms.TabPage();
			this.checkBoxSetComplexSwitchgear = new global::System.Windows.Forms.CheckBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.checkBoxKey = new global::System.Windows.Forms.CheckBox();
			this.groupBoxKey = new global::System.Windows.Forms.GroupBox();
			this.radioButtonKeyRB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonKeyRT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonKeyLB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonKeyLT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonKeyR = new global::System.Windows.Forms.RadioButton();
			this.radioButtonKeyB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonKeyT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonKeyL = new global::System.Windows.Forms.RadioButton();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.checkBoxDamage = new global::System.Windows.Forms.CheckBox();
			this.groupBoxDamage = new global::System.Windows.Forms.GroupBox();
			this.radioButtonDamageRB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDamageRT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDamageLB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDamageLT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDamageR = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDamageB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDamageT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDamageL = new global::System.Windows.Forms.RadioButton();
			this.panelButton = new global::System.Windows.Forms.Panel();
			this.panelColorAndFont = new global::System.Windows.Forms.Panel();
			this.buttonFontObj = new global::System.Windows.Forms.Button();
			this.panelColorObj = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkBoxUseSettingsCanvas = new global::System.Windows.Forms.CheckBox();
			this.panelMagneticStarter = new global::System.Windows.Forms.Panel();
			this.checkBoxCPhase = new global::System.Windows.Forms.CheckBox();
			this.checkBoxBPhase = new global::System.Windows.Forms.CheckBox();
			this.checkBoxAPhase = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBoxNormal.SuspendLayout();
			this.groupBoxName.SuspendLayout();
			this.panelNormalSection.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelOnOff.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageGEneral.SuspendLayout();
			this.tabPageState.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBoxKey.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBoxDamage.SuspendLayout();
			this.panelButton.SuspendLayout();
			this.panelColorAndFont.SuspendLayout();
			this.panelMagneticStarter.SuspendLayout();
			base.SuspendLayout();
			this.vertMirrorCheckBox.AutoSize = true;
			this.vertMirrorCheckBox.Location = new global::System.Drawing.Point(6, 31);
			this.vertMirrorCheckBox.Name = "vertMirrorCheckBox";
			this.vertMirrorCheckBox.Size = new global::System.Drawing.Size(149, 17);
			this.vertMirrorCheckBox.TabIndex = 16;
			this.vertMirrorCheckBox.Text = "Отражение вдоль линии";
			this.vertMirrorCheckBox.UseVisualStyleBackColor = true;
			this.checkBoxNormal.AutoSize = true;
			this.checkBoxNormal.Location = new global::System.Drawing.Point(3, 10);
			this.checkBoxNormal.Name = "checkBoxNormal";
			this.checkBoxNormal.Size = new global::System.Drawing.Size(131, 17);
			this.checkBoxNormal.TabIndex = 6;
			this.checkBoxNormal.Text = "Нормальный разрез";
			this.checkBoxNormal.UseVisualStyleBackColor = true;
			this.checkBoxNormal.CheckedChanged += new global::System.EventHandler(this.checkBoxNormal_CheckedChanged);
			this.gorMirrorCheckBox.AutoSize = true;
			this.gorMirrorCheckBox.Location = new global::System.Drawing.Point(6, 8);
			this.gorMirrorCheckBox.Name = "gorMirrorCheckBox";
			this.gorMirrorCheckBox.Size = new global::System.Drawing.Size(161, 17);
			this.gorMirrorCheckBox.TabIndex = 16;
			this.gorMirrorCheckBox.Text = "Отражение поперёк линии";
			this.gorMirrorCheckBox.UseVisualStyleBackColor = true;
			this.groupBoxNormal.Controls.Add(this.radioButtonNormalLeft);
			this.groupBoxNormal.Controls.Add(this.radioButtonNormalRight);
			this.groupBoxNormal.Controls.Add(this.radioButtonNormalBottom);
			this.groupBoxNormal.Controls.Add(this.radioButtonNormalTop);
			this.groupBoxNormal.Enabled = false;
			this.groupBoxNormal.Location = new global::System.Drawing.Point(3, 33);
			this.groupBoxNormal.Name = "groupBoxNormal";
			this.groupBoxNormal.Size = new global::System.Drawing.Size(131, 85);
			this.groupBoxNormal.TabIndex = 7;
			this.groupBoxNormal.TabStop = false;
			this.radioButtonNormalLeft.AutoSize = true;
			this.radioButtonNormalLeft.Location = new global::System.Drawing.Point(6, 39);
			this.radioButtonNormalLeft.Name = "radioButtonNormalLeft";
			this.radioButtonNormalLeft.Size = new global::System.Drawing.Size(55, 17);
			this.radioButtonNormalLeft.TabIndex = 2;
			this.radioButtonNormalLeft.TabStop = true;
			this.radioButtonNormalLeft.Text = "слева";
			this.radioButtonNormalLeft.UseVisualStyleBackColor = true;
			this.radioButtonNormalRight.AutoSize = true;
			this.radioButtonNormalRight.Location = new global::System.Drawing.Point(67, 39);
			this.radioButtonNormalRight.Name = "radioButtonNormalRight";
			this.radioButtonNormalRight.Size = new global::System.Drawing.Size(61, 17);
			this.radioButtonNormalRight.TabIndex = 3;
			this.radioButtonNormalRight.TabStop = true;
			this.radioButtonNormalRight.Text = "справа";
			this.radioButtonNormalRight.UseVisualStyleBackColor = true;
			this.radioButtonNormalBottom.AutoSize = true;
			this.radioButtonNormalBottom.Location = new global::System.Drawing.Point(28, 62);
			this.radioButtonNormalBottom.Name = "radioButtonNormalBottom";
			this.radioButtonNormalBottom.Size = new global::System.Drawing.Size(54, 17);
			this.radioButtonNormalBottom.TabIndex = 5;
			this.radioButtonNormalBottom.TabStop = true;
			this.radioButtonNormalBottom.Text = "снизу";
			this.radioButtonNormalBottom.UseVisualStyleBackColor = true;
			this.radioButtonNormalTop.AutoSize = true;
			this.radioButtonNormalTop.Checked = true;
			this.radioButtonNormalTop.Location = new global::System.Drawing.Point(28, 16);
			this.radioButtonNormalTop.Name = "radioButtonNormalTop";
			this.radioButtonNormalTop.Size = new global::System.Drawing.Size(59, 17);
			this.radioButtonNormalTop.TabIndex = 4;
			this.radioButtonNormalTop.TabStop = true;
			this.radioButtonNormalTop.Text = "сверху";
			this.radioButtonNormalTop.UseVisualStyleBackColor = true;
			this.textBoxName.Location = new global::System.Drawing.Point(6, 19);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new global::System.Drawing.Size(159, 20);
			this.textBoxName.TabIndex = 6;
			this.buttonCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(326, 11);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(4, 11);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 13;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.onRadioButton.AutoSize = true;
			this.onRadioButton.Location = new global::System.Drawing.Point(21, 33);
			this.onRadioButton.Name = "onRadioButton";
			this.onRadioButton.Size = new global::System.Drawing.Size(44, 17);
			this.onRadioButton.TabIndex = 15;
			this.onRadioButton.TabStop = true;
			this.onRadioButton.Text = "Вкл";
			this.onRadioButton.UseVisualStyleBackColor = true;
			this.offRadioButton.AutoSize = true;
			this.offRadioButton.Location = new global::System.Drawing.Point(21, 56);
			this.offRadioButton.Name = "offRadioButton";
			this.offRadioButton.Size = new global::System.Drawing.Size(52, 17);
			this.offRadioButton.TabIndex = 15;
			this.offRadioButton.TabStop = true;
			this.offRadioButton.Text = "Выкл";
			this.offRadioButton.UseVisualStyleBackColor = true;
			this.groupBoxName.Controls.Add(this.radioButtonRB);
			this.groupBoxName.Controls.Add(this.radioButtonRT);
			this.groupBoxName.Controls.Add(this.radioButtonNotVisible);
			this.groupBoxName.Controls.Add(this.radioButtonLB);
			this.groupBoxName.Controls.Add(this.radioButtonLT);
			this.groupBoxName.Controls.Add(this.radioButtonR);
			this.groupBoxName.Controls.Add(this.radioButtonB);
			this.groupBoxName.Controls.Add(this.radioButtonT);
			this.groupBoxName.Controls.Add(this.radioButtonL);
			this.groupBoxName.Controls.Add(this.textBoxName);
			this.groupBoxName.Location = new global::System.Drawing.Point(0, 3);
			this.groupBoxName.Name = "groupBoxName";
			this.groupBoxName.Size = new global::System.Drawing.Size(176, 146);
			this.groupBoxName.TabIndex = 17;
			this.groupBoxName.TabStop = false;
			this.groupBoxName.Text = "Имя";
			this.radioButtonRB.AutoSize = true;
			this.radioButtonRB.Location = new global::System.Drawing.Point(107, 91);
			this.radioButtonRB.Name = "radioButtonRB";
			this.radioButtonRB.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonRB.TabIndex = 19;
			this.radioButtonRB.TabStop = true;
			this.radioButtonRB.Text = "RB";
			this.radioButtonRB.UseVisualStyleBackColor = true;
			this.radioButtonRT.AutoSize = true;
			this.radioButtonRT.Location = new global::System.Drawing.Point(107, 45);
			this.radioButtonRT.Name = "radioButtonRT";
			this.radioButtonRT.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonRT.TabIndex = 18;
			this.radioButtonRT.TabStop = true;
			this.radioButtonRT.Text = "RT";
			this.radioButtonRT.UseVisualStyleBackColor = true;
			this.radioButtonNotVisible.AutoSize = true;
			this.radioButtonNotVisible.Location = new global::System.Drawing.Point(40, 114);
			this.radioButtonNotVisible.Name = "radioButtonNotVisible";
			this.radioButtonNotVisible.Size = new global::System.Drawing.Size(100, 17);
			this.radioButtonNotVisible.TabIndex = 11;
			this.radioButtonNotVisible.TabStop = true;
			this.radioButtonNotVisible.Text = "не отображать";
			this.radioButtonNotVisible.UseVisualStyleBackColor = true;
			this.radioButtonLB.AutoSize = true;
			this.radioButtonLB.Location = new global::System.Drawing.Point(25, 91);
			this.radioButtonLB.Name = "radioButtonLB";
			this.radioButtonLB.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonLB.TabIndex = 17;
			this.radioButtonLB.TabStop = true;
			this.radioButtonLB.Text = "LB";
			this.radioButtonLB.UseVisualStyleBackColor = true;
			this.radioButtonLT.AutoSize = true;
			this.radioButtonLT.Location = new global::System.Drawing.Point(25, 45);
			this.radioButtonLT.Name = "radioButtonLT";
			this.radioButtonLT.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonLT.TabIndex = 16;
			this.radioButtonLT.TabStop = true;
			this.radioButtonLT.Text = "LT";
			this.radioButtonLT.UseVisualStyleBackColor = true;
			this.radioButtonR.AutoSize = true;
			this.radioButtonR.Location = new global::System.Drawing.Point(107, 68);
			this.radioButtonR.Name = "radioButtonR";
			this.radioButtonR.Size = new global::System.Drawing.Size(33, 17);
			this.radioButtonR.TabIndex = 13;
			this.radioButtonR.TabStop = true;
			this.radioButtonR.Text = "R";
			this.radioButtonR.UseVisualStyleBackColor = true;
			this.radioButtonB.AutoSize = true;
			this.radioButtonB.Location = new global::System.Drawing.Point(69, 91);
			this.radioButtonB.Name = "radioButtonB";
			this.radioButtonB.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonB.TabIndex = 15;
			this.radioButtonB.TabStop = true;
			this.radioButtonB.Text = "B";
			this.radioButtonB.UseVisualStyleBackColor = true;
			this.radioButtonT.AutoSize = true;
			this.radioButtonT.Location = new global::System.Drawing.Point(69, 45);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonT.TabIndex = 14;
			this.radioButtonT.TabStop = true;
			this.radioButtonT.Text = "T";
			this.radioButtonT.UseVisualStyleBackColor = true;
			this.radioButtonL.AutoSize = true;
			this.radioButtonL.Location = new global::System.Drawing.Point(25, 68);
			this.radioButtonL.Name = "radioButtonL";
			this.radioButtonL.Size = new global::System.Drawing.Size(31, 17);
			this.radioButtonL.TabIndex = 12;
			this.radioButtonL.TabStop = true;
			this.radioButtonL.Text = "L";
			this.radioButtonL.UseVisualStyleBackColor = true;
			this.panelNormalSection.Controls.Add(this.checkBoxNormal);
			this.panelNormalSection.Controls.Add(this.groupBoxNormal);
			this.panelNormalSection.Location = new global::System.Drawing.Point(0, 3);
			this.panelNormalSection.Name = "panelNormalSection";
			this.panelNormalSection.Size = new global::System.Drawing.Size(136, 118);
			this.panelNormalSection.TabIndex = 18;
			this.panel1.Controls.Add(this.vertMirrorCheckBox);
			this.panel1.Controls.Add(this.gorMirrorCheckBox);
			this.panel1.Location = new global::System.Drawing.Point(182, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(176, 59);
			this.panel1.TabIndex = 19;
			this.panelOnOff.Controls.Add(this.labelOnOff);
			this.panelOnOff.Controls.Add(this.onRadioButton);
			this.panelOnOff.Controls.Add(this.offRadioButton);
			this.panelOnOff.Location = new global::System.Drawing.Point(182, 71);
			this.panelOnOff.Name = "panelOnOff";
			this.panelOnOff.Size = new global::System.Drawing.Size(176, 78);
			this.panelOnOff.TabIndex = 20;
			this.labelOnOff.AutoSize = true;
			this.labelOnOff.Location = new global::System.Drawing.Point(3, 9);
			this.labelOnOff.Name = "labelOnOff";
			this.labelOnOff.Size = new global::System.Drawing.Size(132, 13);
			this.labelOnOff.TabIndex = 16;
			this.labelOnOff.Text = "Состояние выключателя";
			this.tabControl.Controls.Add(this.tabPageGEneral);
			this.tabControl.Controls.Add(this.tabPageState);
			this.tabControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.tabControl.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new global::System.Drawing.Size(413, 181);
			this.tabControl.TabIndex = 21;
			this.tabPageGEneral.Controls.Add(this.groupBoxName);
			this.tabPageGEneral.Controls.Add(this.panelOnOff);
			this.tabPageGEneral.Controls.Add(this.panel1);
			this.tabPageGEneral.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageGEneral.Name = "tabPageGEneral";
			this.tabPageGEneral.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageGEneral.Size = new global::System.Drawing.Size(405, 155);
			this.tabPageGEneral.TabIndex = 0;
			this.tabPageGEneral.Text = "Общие";
			this.tabPageGEneral.UseVisualStyleBackColor = true;
			this.tabPageState.Controls.Add(this.panelMagneticStarter);
			this.tabPageState.Controls.Add(this.checkBoxSetComplexSwitchgear);
			this.tabPageState.Controls.Add(this.panel3);
			this.tabPageState.Controls.Add(this.panel2);
			this.tabPageState.Controls.Add(this.panelNormalSection);
			this.tabPageState.Location = new global::System.Drawing.Point(4, 22);
			this.tabPageState.Name = "tabPageState";
			this.tabPageState.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageState.Size = new global::System.Drawing.Size(405, 155);
			this.tabPageState.TabIndex = 1;
			this.tabPageState.Text = "Статусы";
			this.tabPageState.UseVisualStyleBackColor = true;
			this.checkBoxSetComplexSwitchgear.AutoSize = true;
			this.checkBoxSetComplexSwitchgear.Location = new global::System.Drawing.Point(3, 127);
			this.checkBoxSetComplexSwitchgear.Name = "checkBoxSetComplexSwitchgear";
			this.checkBoxSetComplexSwitchgear.Size = new global::System.Drawing.Size(197, 17);
			this.checkBoxSetComplexSwitchgear.TabIndex = 21;
			this.checkBoxSetComplexSwitchgear.Text = "Комплексное распредустройство";
			this.checkBoxSetComplexSwitchgear.UseVisualStyleBackColor = true;
			this.panel3.Controls.Add(this.checkBoxKey);
			this.panel3.Controls.Add(this.groupBoxKey);
			this.panel3.Location = new global::System.Drawing.Point(272, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(136, 118);
			this.panel3.TabIndex = 20;
			this.checkBoxKey.AutoSize = true;
			this.checkBoxKey.Location = new global::System.Drawing.Point(3, 10);
			this.checkBoxKey.Name = "checkBoxKey";
			this.checkBoxKey.Size = new global::System.Drawing.Size(89, 17);
			this.checkBoxKey.TabIndex = 6;
			this.checkBoxKey.Text = "Спец. замок";
			this.checkBoxKey.UseVisualStyleBackColor = true;
			this.checkBoxKey.CheckedChanged += new global::System.EventHandler(this.checkBoxKey_CheckedChanged);
			this.groupBoxKey.Controls.Add(this.radioButtonKeyRB);
			this.groupBoxKey.Controls.Add(this.radioButtonKeyRT);
			this.groupBoxKey.Controls.Add(this.radioButtonKeyLB);
			this.groupBoxKey.Controls.Add(this.radioButtonKeyLT);
			this.groupBoxKey.Controls.Add(this.radioButtonKeyR);
			this.groupBoxKey.Controls.Add(this.radioButtonKeyB);
			this.groupBoxKey.Controls.Add(this.radioButtonKeyT);
			this.groupBoxKey.Controls.Add(this.radioButtonKeyL);
			this.groupBoxKey.Enabled = false;
			this.groupBoxKey.Location = new global::System.Drawing.Point(3, 33);
			this.groupBoxKey.Name = "groupBoxKey";
			this.groupBoxKey.Size = new global::System.Drawing.Size(131, 85);
			this.groupBoxKey.TabIndex = 7;
			this.groupBoxKey.TabStop = false;
			this.radioButtonKeyRB.AutoSize = true;
			this.radioButtonKeyRB.Location = new global::System.Drawing.Point(86, 57);
			this.radioButtonKeyRB.Name = "radioButtonKeyRB";
			this.radioButtonKeyRB.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonKeyRB.TabIndex = 27;
			this.radioButtonKeyRB.Text = "RB";
			this.radioButtonKeyRB.UseVisualStyleBackColor = true;
			this.radioButtonKeyRT.AutoSize = true;
			this.radioButtonKeyRT.Location = new global::System.Drawing.Point(86, 11);
			this.radioButtonKeyRT.Name = "radioButtonKeyRT";
			this.radioButtonKeyRT.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonKeyRT.TabIndex = 26;
			this.radioButtonKeyRT.Text = "RT";
			this.radioButtonKeyRT.UseVisualStyleBackColor = true;
			this.radioButtonKeyLB.AutoSize = true;
			this.radioButtonKeyLB.Location = new global::System.Drawing.Point(4, 57);
			this.radioButtonKeyLB.Name = "radioButtonKeyLB";
			this.radioButtonKeyLB.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonKeyLB.TabIndex = 25;
			this.radioButtonKeyLB.Text = "LB";
			this.radioButtonKeyLB.UseVisualStyleBackColor = true;
			this.radioButtonKeyLT.AutoSize = true;
			this.radioButtonKeyLT.Location = new global::System.Drawing.Point(4, 11);
			this.radioButtonKeyLT.Name = "radioButtonKeyLT";
			this.radioButtonKeyLT.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonKeyLT.TabIndex = 24;
			this.radioButtonKeyLT.Text = "LT";
			this.radioButtonKeyLT.UseVisualStyleBackColor = true;
			this.radioButtonKeyR.AutoSize = true;
			this.radioButtonKeyR.Location = new global::System.Drawing.Point(86, 34);
			this.radioButtonKeyR.Name = "radioButtonKeyR";
			this.radioButtonKeyR.Size = new global::System.Drawing.Size(33, 17);
			this.radioButtonKeyR.TabIndex = 21;
			this.radioButtonKeyR.Text = "R";
			this.radioButtonKeyR.UseVisualStyleBackColor = true;
			this.radioButtonKeyB.AutoSize = true;
			this.radioButtonKeyB.Location = new global::System.Drawing.Point(48, 57);
			this.radioButtonKeyB.Name = "radioButtonKeyB";
			this.radioButtonKeyB.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonKeyB.TabIndex = 23;
			this.radioButtonKeyB.Text = "B";
			this.radioButtonKeyB.UseVisualStyleBackColor = true;
			this.radioButtonKeyT.AutoSize = true;
			this.radioButtonKeyT.Checked = true;
			this.radioButtonKeyT.Location = new global::System.Drawing.Point(48, 11);
			this.radioButtonKeyT.Name = "radioButtonKeyT";
			this.radioButtonKeyT.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonKeyT.TabIndex = 22;
			this.radioButtonKeyT.TabStop = true;
			this.radioButtonKeyT.Text = "T";
			this.radioButtonKeyT.UseVisualStyleBackColor = true;
			this.radioButtonKeyL.AutoSize = true;
			this.radioButtonKeyL.Location = new global::System.Drawing.Point(4, 34);
			this.radioButtonKeyL.Name = "radioButtonKeyL";
			this.radioButtonKeyL.Size = new global::System.Drawing.Size(31, 17);
			this.radioButtonKeyL.TabIndex = 20;
			this.radioButtonKeyL.Text = "L";
			this.radioButtonKeyL.UseVisualStyleBackColor = true;
			this.panel2.Controls.Add(this.checkBoxDamage);
			this.panel2.Controls.Add(this.groupBoxDamage);
			this.panel2.Location = new global::System.Drawing.Point(137, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(136, 118);
			this.panel2.TabIndex = 19;
			this.checkBoxDamage.AutoSize = true;
			this.checkBoxDamage.Location = new global::System.Drawing.Point(3, 10);
			this.checkBoxDamage.Name = "checkBoxDamage";
			this.checkBoxDamage.Size = new global::System.Drawing.Size(84, 17);
			this.checkBoxDamage.TabIndex = 6;
			this.checkBoxDamage.Text = "Поврежден";
			this.checkBoxDamage.UseVisualStyleBackColor = true;
			this.checkBoxDamage.CheckedChanged += new global::System.EventHandler(this.checkBoxDamage_CheckedChanged);
			this.groupBoxDamage.Controls.Add(this.radioButtonDamageRB);
			this.groupBoxDamage.Controls.Add(this.radioButtonDamageRT);
			this.groupBoxDamage.Controls.Add(this.radioButtonDamageLB);
			this.groupBoxDamage.Controls.Add(this.radioButtonDamageLT);
			this.groupBoxDamage.Controls.Add(this.radioButtonDamageR);
			this.groupBoxDamage.Controls.Add(this.radioButtonDamageB);
			this.groupBoxDamage.Controls.Add(this.radioButtonDamageT);
			this.groupBoxDamage.Controls.Add(this.radioButtonDamageL);
			this.groupBoxDamage.Enabled = false;
			this.groupBoxDamage.Location = new global::System.Drawing.Point(3, 33);
			this.groupBoxDamage.Name = "groupBoxDamage";
			this.groupBoxDamage.Size = new global::System.Drawing.Size(131, 85);
			this.groupBoxDamage.TabIndex = 7;
			this.groupBoxDamage.TabStop = false;
			this.radioButtonDamageRB.AutoSize = true;
			this.radioButtonDamageRB.Location = new global::System.Drawing.Point(86, 57);
			this.radioButtonDamageRB.Name = "radioButtonDamageRB";
			this.radioButtonDamageRB.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonDamageRB.TabIndex = 27;
			this.radioButtonDamageRB.Text = "RB";
			this.radioButtonDamageRB.UseVisualStyleBackColor = true;
			this.radioButtonDamageRT.AutoSize = true;
			this.radioButtonDamageRT.Location = new global::System.Drawing.Point(86, 11);
			this.radioButtonDamageRT.Name = "radioButtonDamageRT";
			this.radioButtonDamageRT.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonDamageRT.TabIndex = 26;
			this.radioButtonDamageRT.Text = "RT";
			this.radioButtonDamageRT.UseVisualStyleBackColor = true;
			this.radioButtonDamageLB.AutoSize = true;
			this.radioButtonDamageLB.Location = new global::System.Drawing.Point(4, 57);
			this.radioButtonDamageLB.Name = "radioButtonDamageLB";
			this.radioButtonDamageLB.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonDamageLB.TabIndex = 25;
			this.radioButtonDamageLB.Text = "LB";
			this.radioButtonDamageLB.UseVisualStyleBackColor = true;
			this.radioButtonDamageLT.AutoSize = true;
			this.radioButtonDamageLT.Location = new global::System.Drawing.Point(4, 11);
			this.radioButtonDamageLT.Name = "radioButtonDamageLT";
			this.radioButtonDamageLT.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonDamageLT.TabIndex = 24;
			this.radioButtonDamageLT.Text = "LT";
			this.radioButtonDamageLT.UseVisualStyleBackColor = true;
			this.radioButtonDamageR.AutoSize = true;
			this.radioButtonDamageR.Location = new global::System.Drawing.Point(86, 34);
			this.radioButtonDamageR.Name = "radioButtonDamageR";
			this.radioButtonDamageR.Size = new global::System.Drawing.Size(33, 17);
			this.radioButtonDamageR.TabIndex = 21;
			this.radioButtonDamageR.Text = "R";
			this.radioButtonDamageR.UseVisualStyleBackColor = true;
			this.radioButtonDamageB.AutoSize = true;
			this.radioButtonDamageB.Location = new global::System.Drawing.Point(48, 57);
			this.radioButtonDamageB.Name = "radioButtonDamageB";
			this.radioButtonDamageB.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonDamageB.TabIndex = 23;
			this.radioButtonDamageB.Text = "B";
			this.radioButtonDamageB.UseVisualStyleBackColor = true;
			this.radioButtonDamageT.AutoSize = true;
			this.radioButtonDamageT.Checked = true;
			this.radioButtonDamageT.Location = new global::System.Drawing.Point(48, 11);
			this.radioButtonDamageT.Name = "radioButtonDamageT";
			this.radioButtonDamageT.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonDamageT.TabIndex = 22;
			this.radioButtonDamageT.TabStop = true;
			this.radioButtonDamageT.Text = "T";
			this.radioButtonDamageT.UseVisualStyleBackColor = true;
			this.radioButtonDamageL.AutoSize = true;
			this.radioButtonDamageL.Location = new global::System.Drawing.Point(4, 34);
			this.radioButtonDamageL.Name = "radioButtonDamageL";
			this.radioButtonDamageL.Size = new global::System.Drawing.Size(31, 17);
			this.radioButtonDamageL.TabIndex = 20;
			this.radioButtonDamageL.Text = "L";
			this.radioButtonDamageL.UseVisualStyleBackColor = true;
			this.panelButton.Controls.Add(this.buttonOK);
			this.panelButton.Controls.Add(this.buttonCancel);
			this.panelButton.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelButton.Location = new global::System.Drawing.Point(0, 246);
			this.panelButton.Name = "panelButton";
			this.panelButton.Size = new global::System.Drawing.Size(413, 46);
			this.panelButton.TabIndex = 22;
			this.panelColorAndFont.Controls.Add(this.buttonFontObj);
			this.panelColorAndFont.Controls.Add(this.panelColorObj);
			this.panelColorAndFont.Controls.Add(this.label1);
			this.panelColorAndFont.Controls.Add(this.checkBoxUseSettingsCanvas);
			this.panelColorAndFont.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelColorAndFont.Location = new global::System.Drawing.Point(0, 181);
			this.panelColorAndFont.Name = "panelColorAndFont";
			this.panelColorAndFont.Size = new global::System.Drawing.Size(413, 65);
			this.panelColorAndFont.TabIndex = 23;
			this.buttonFontObj.Enabled = false;
			this.buttonFontObj.Location = new global::System.Drawing.Point(12, 29);
			this.buttonFontObj.Name = "buttonFontObj";
			this.buttonFontObj.Size = new global::System.Drawing.Size(75, 23);
			this.buttonFontObj.TabIndex = 3;
			this.buttonFontObj.Text = "Шрифт";
			this.buttonFontObj.UseVisualStyleBackColor = true;
			this.buttonFontObj.Click += new global::System.EventHandler(this.buttonFontObj_Click);
			this.panelColorObj.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelColorObj.Enabled = false;
			this.panelColorObj.Location = new global::System.Drawing.Point(186, 29);
			this.panelColorObj.Name = "panelColorObj";
			this.panelColorObj.Size = new global::System.Drawing.Size(71, 22);
			this.panelColorObj.TabIndex = 2;
			this.panelColorObj.DoubleClick += new global::System.EventHandler(this.panelColorObj_DoubleClick);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(189, 13);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(32, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Цвет";
			this.checkBoxUseSettingsCanvas.AutoSize = true;
			this.checkBoxUseSettingsCanvas.Checked = true;
			this.checkBoxUseSettingsCanvas.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBoxUseSettingsCanvas.Location = new global::System.Drawing.Point(12, 6);
			this.checkBoxUseSettingsCanvas.Name = "checkBoxUseSettingsCanvas";
			this.checkBoxUseSettingsCanvas.Size = new global::System.Drawing.Size(110, 17);
			this.checkBoxUseSettingsCanvas.TabIndex = 0;
			this.checkBoxUseSettingsCanvas.Text = "Свойства схемы";
			this.checkBoxUseSettingsCanvas.UseVisualStyleBackColor = true;
			this.checkBoxUseSettingsCanvas.CheckedChanged += new global::System.EventHandler(this.checkBoxUseSettingsCanvas_CheckedChanged);
			this.panelMagneticStarter.Controls.Add(this.label2);
			this.panelMagneticStarter.Controls.Add(this.checkBoxAPhase);
			this.panelMagneticStarter.Controls.Add(this.checkBoxBPhase);
			this.panelMagneticStarter.Controls.Add(this.checkBoxCPhase);
			this.panelMagneticStarter.Location = new global::System.Drawing.Point(206, 118);
			this.panelMagneticStarter.Name = "panelMagneticStarter";
			this.panelMagneticStarter.Size = new global::System.Drawing.Size(200, 37);
			this.panelMagneticStarter.TabIndex = 22;
			this.panelMagneticStarter.Visible = false;
			this.checkBoxCPhase.AutoSize = true;
			this.checkBoxCPhase.Location = new global::System.Drawing.Point(162, 9);
			this.checkBoxCPhase.Name = "checkBoxCPhase";
			this.checkBoxCPhase.Size = new global::System.Drawing.Size(33, 17);
			this.checkBoxCPhase.TabIndex = 0;
			this.checkBoxCPhase.Text = "C";
			this.checkBoxCPhase.UseVisualStyleBackColor = true;
			this.checkBoxBPhase.AutoSize = true;
			this.checkBoxBPhase.Location = new global::System.Drawing.Point(123, 9);
			this.checkBoxBPhase.Name = "checkBoxBPhase";
			this.checkBoxBPhase.Size = new global::System.Drawing.Size(33, 17);
			this.checkBoxBPhase.TabIndex = 0;
			this.checkBoxBPhase.Text = "B";
			this.checkBoxBPhase.UseVisualStyleBackColor = true;
			this.checkBoxAPhase.AutoSize = true;
			this.checkBoxAPhase.Location = new global::System.Drawing.Point(84, 9);
			this.checkBoxAPhase.Name = "checkBoxAPhase";
			this.checkBoxAPhase.Size = new global::System.Drawing.Size(33, 17);
			this.checkBoxAPhase.TabIndex = 0;
			this.checkBoxAPhase.Text = "A";
			this.checkBoxAPhase.UseVisualStyleBackColor = true;
			this.label2.Location = new global::System.Drawing.Point(3, 6);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(75, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Подключен-   ные фазы";
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(413, 292);
			base.Controls.Add(this.panelColorAndFont);
			base.Controls.Add(this.panelButton);
			base.Controls.Add(this.tabControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ObjectOnLinePropertyForm";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Свойства объекта на линии";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.ObjectOnLinePropertyForm_FormClosing);
			this.groupBoxNormal.ResumeLayout(false);
			this.groupBoxNormal.PerformLayout();
			this.groupBoxName.ResumeLayout(false);
			this.groupBoxName.PerformLayout();
			this.panelNormalSection.ResumeLayout(false);
			this.panelNormalSection.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelOnOff.ResumeLayout(false);
			this.panelOnOff.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageGEneral.ResumeLayout(false);
			this.tabPageState.ResumeLayout(false);
			this.tabPageState.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.groupBoxKey.ResumeLayout(false);
			this.groupBoxKey.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBoxDamage.ResumeLayout(false);
			this.groupBoxDamage.PerformLayout();
			this.panelButton.ResumeLayout(false);
			this.panelColorAndFont.ResumeLayout(false);
			this.panelColorAndFont.PerformLayout();
			this.panelMagneticStarter.ResumeLayout(false);
			this.panelMagneticStarter.PerformLayout();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.TextBox textBoxName;

		private global::System.Windows.Forms.RadioButton radioButtonNormalBottom;

		private global::System.Windows.Forms.RadioButton radioButtonNormalTop;

		private global::System.Windows.Forms.RadioButton radioButtonNormalRight;

		private global::System.Windows.Forms.RadioButton radioButtonNormalLeft;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.RadioButton onRadioButton;

		private global::System.Windows.Forms.RadioButton offRadioButton;

		private global::System.Windows.Forms.GroupBox groupBoxNormal;

		private global::System.Windows.Forms.CheckBox checkBoxNormal;

		private global::System.Windows.Forms.CheckBox gorMirrorCheckBox;

		private global::System.Windows.Forms.CheckBox vertMirrorCheckBox;

		private global::System.Windows.Forms.GroupBox groupBoxName;

		private global::System.Windows.Forms.RadioButton radioButtonRB;

		private global::System.Windows.Forms.RadioButton radioButtonRT;

		private global::System.Windows.Forms.RadioButton radioButtonNotVisible;

		private global::System.Windows.Forms.RadioButton radioButtonLB;

		private global::System.Windows.Forms.RadioButton radioButtonLT;

		private global::System.Windows.Forms.RadioButton radioButtonR;

		private global::System.Windows.Forms.RadioButton radioButtonB;

		private global::System.Windows.Forms.RadioButton radioButtonT;

		private global::System.Windows.Forms.RadioButton radioButtonL;

		private global::System.Windows.Forms.Panel panelNormalSection;

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.Panel panelOnOff;

		private global::System.Windows.Forms.Label labelOnOff;

		private global::System.Windows.Forms.TabControl tabControl;

		private global::System.Windows.Forms.TabPage tabPageGEneral;

		private global::System.Windows.Forms.TabPage tabPageState;

		private global::System.Windows.Forms.Panel panel2;

		private global::System.Windows.Forms.CheckBox checkBoxDamage;

		private global::System.Windows.Forms.GroupBox groupBoxDamage;

		private global::System.Windows.Forms.RadioButton radioButtonDamageRB;

		private global::System.Windows.Forms.RadioButton radioButtonDamageRT;

		private global::System.Windows.Forms.RadioButton radioButtonDamageLB;

		private global::System.Windows.Forms.RadioButton radioButtonDamageLT;

		private global::System.Windows.Forms.RadioButton radioButtonDamageR;

		private global::System.Windows.Forms.RadioButton radioButtonDamageB;

		private global::System.Windows.Forms.RadioButton radioButtonDamageT;

		private global::System.Windows.Forms.RadioButton radioButtonDamageL;

		private global::System.Windows.Forms.Panel panel3;

		private global::System.Windows.Forms.CheckBox checkBoxKey;

		private global::System.Windows.Forms.GroupBox groupBoxKey;

		private global::System.Windows.Forms.RadioButton radioButtonKeyRB;

		private global::System.Windows.Forms.RadioButton radioButtonKeyRT;

		private global::System.Windows.Forms.RadioButton radioButtonKeyLB;

		private global::System.Windows.Forms.RadioButton radioButtonKeyLT;

		private global::System.Windows.Forms.RadioButton radioButtonKeyR;

		private global::System.Windows.Forms.RadioButton radioButtonKeyB;

		private global::System.Windows.Forms.RadioButton radioButtonKeyT;

		private global::System.Windows.Forms.RadioButton radioButtonKeyL;

		private global::System.Windows.Forms.Panel panelButton;

		private global::System.Windows.Forms.Panel panelColorAndFont;

		private global::System.Windows.Forms.CheckBox checkBoxUseSettingsCanvas;

		private global::System.Windows.Forms.Panel panelColorObj;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.CheckBox checkBoxSetComplexSwitchgear;

		private global::System.Windows.Forms.Button buttonFontObj;

		private global::System.Windows.Forms.Panel panelMagneticStarter;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.CheckBox checkBoxAPhase;

		private global::System.Windows.Forms.CheckBox checkBoxBPhase;

		private global::System.Windows.Forms.CheckBox checkBoxCPhase;
	}
}
