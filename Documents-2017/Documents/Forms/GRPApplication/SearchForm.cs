namespace Documents.Forms.GRPApplication
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class SearchForm : Form
    {
        private Button buttonCancel;
        private Button buttonOK;
        public ComboBox comboBoxSearchType;
        private IContainer icontainer_0;
        public const string item1 = "Абоненту";
        public const string item2 = "Объекту";
        public const string item3_1 = "Номеру договора";
        public const string item3_2 = "Номеру л/сч";
        private Label label1;
        public RadioButton radioButtonIndiviual;
        public RadioButton radioButtonLegal;
        public TextBox textBoxName;

        public SearchForm()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(SearchForm));
            this.buttonCancel = new Button();
            this.buttonOK = new Button();
            this.radioButtonLegal = new RadioButton();
            this.radioButtonIndiviual = new RadioButton();
            this.textBoxName = new TextBox();
            this.comboBoxSearchType = new ComboBox();
            this.label1 = new Label();
            base.SuspendLayout();
            this.buttonCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(0xb1, 0x66);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x4b, 0x17);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonOK.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.buttonOK.DialogResult = DialogResult.OK;
            this.buttonOK.Location = new Point(0x60, 0x66);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(0x4b, 0x17);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.radioButtonLegal.AutoSize = true;
            this.radioButtonLegal.Location = new Point(12, 12);
            this.radioButtonLegal.Name = "radioButtonLegal";
            this.radioButtonLegal.Size = new Size(120, 0x11);
            this.radioButtonLegal.TabIndex = 1;
            this.radioButtonLegal.Text = "Юридическое лицо";
            this.radioButtonLegal.UseVisualStyleBackColor = true;
            this.radioButtonLegal.CheckedChanged += new EventHandler(this.radioButtonLegal_CheckedChanged);
            this.radioButtonIndiviual.AutoSize = true;
            this.radioButtonIndiviual.Location = new Point(0x8a, 12);
            this.radioButtonIndiviual.Name = "radioButtonIndiviual";
            this.radioButtonIndiviual.Size = new Size(0x74, 0x11);
            this.radioButtonIndiviual.TabIndex = 1;
            this.radioButtonIndiviual.Text = "Физическое лицо";
            this.radioButtonIndiviual.UseVisualStyleBackColor = true;
            this.radioButtonIndiviual.CheckedChanged += new EventHandler(this.radioButtonIndiviual_CheckedChanged);
            this.textBoxName.Location = new Point(12, 0x4c);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(240, 20);
            this.textBoxName.TabIndex = 2;
            this.comboBoxSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSearchType.FormattingEnabled = true;
            object[] items = new object[] { "Абоненту", "Объекту" };
            this.comboBoxSearchType.Items.AddRange(items);
            this.comboBoxSearchType.Location = new Point(0x60, 0x31);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new Size(0x9c, 0x15);
            this.comboBoxSearchType.TabIndex = 3;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 0x34);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по:";
            base.AcceptButton = this.buttonOK;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonCancel;
            base.ClientSize = new Size(0x108, 0x89);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.comboBoxSearchType);
            base.Controls.Add(this.textBoxName);
            base.Controls.Add(this.radioButtonIndiviual);
            base.Controls.Add(this.radioButtonLegal);
            base.Controls.Add(this.buttonOK);
            base.Controls.Add(this.buttonCancel);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SearchForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Поиск";
            base.Load += new EventHandler(this.SearchForm_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void radioButtonIndiviual_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonIndiviual.Checked)
            {
                this.comboBoxSearchType.Items.Clear();
                this.comboBoxSearchType.Items.Add("Абоненту");
                this.comboBoxSearchType.Items.Add("Объекту");
                this.comboBoxSearchType.Items.Add("Номеру л/сч");
                this.comboBoxSearchType.SelectedIndex = 0;
            }
        }

        private void radioButtonLegal_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonLegal.Checked)
            {
                this.comboBoxSearchType.Items.Clear();
                this.comboBoxSearchType.Items.Add("Абоненту");
                this.comboBoxSearchType.Items.Add("Объекту");
                this.comboBoxSearchType.Items.Add("Номеру договора");
                this.comboBoxSearchType.SelectedIndex = 0;
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.radioButtonLegal.Checked = true;
        }
    }
}

