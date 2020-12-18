namespace Legal.Forms
{
    partial class FormAbnAddress
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DateTimePicker dtChange;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbnAddress));
            this.dsAbnAddress1 = new Legal.DataSet.dsAbnAddress();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAddressType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHouse = new System.Windows.Forms.TextBox();
            this.tbHousing = new System.Windows.Forms.TextBox();
            this.tbApartment = new System.Windows.Forms.TextBox();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbCansel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbRepresentation = new System.Windows.Forms.RichTextBox();
            this.groupBoxRepresentation = new System.Windows.Forms.GroupBox();
            this.buttonCreateView = new System.Windows.Forms.Button();
            dtChange = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnAddress1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBoxRepresentation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtChange
            // 
            dtChange.Location = new System.Drawing.Point(105, 343);
            dtChange.Name = "dtChange";
            dtChange.Size = new System.Drawing.Size(153, 20);
            dtChange.TabIndex = 34;
            // 
            // dsAbnAddress1
            // 
            this.dsAbnAddress1.DataSetName = "dsAbnAddress";
            this.dsAbnAddress1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Индекс:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(46, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Город:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Нас. пункт:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(39, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Регион:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(44, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Улица:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(55, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Дом:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(167, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Корпус:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(285, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Кв.:";
            // 
            // cmbAddressType
            // 
            this.cmbAddressType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbnAddress1, "tG_AbnAddress.idTypeAddress", true));
            this.cmbAddressType.DataSource = this.dsAbnAddress1;
            this.cmbAddressType.DisplayMember = "tR_Classifier.Name";
            this.cmbAddressType.FormattingEnabled = true;
            this.cmbAddressType.Location = new System.Drawing.Point(105, 17);
            this.cmbAddressType.Name = "cmbAddressType";
            this.cmbAddressType.Size = new System.Drawing.Size(266, 21);
            this.cmbAddressType.TabIndex = 22;
            this.cmbAddressType.ValueMember = "tR_Classifier.Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Вид адреса:";
            // 
            // tbHouse
            // 
            this.tbHouse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnAddress1, "tG_AbnAddress.House", true));
            this.tbHouse.Location = new System.Drawing.Point(105, 174);
            this.tbHouse.Name = "tbHouse";
            this.tbHouse.Size = new System.Drawing.Size(50, 20);
            this.tbHouse.TabIndex = 27;
            // 
            // tbHousing
            // 
            this.tbHousing.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnAddress1, "tG_AbnAddress.Housing", true));
            this.tbHousing.Location = new System.Drawing.Point(226, 175);
            this.tbHousing.Name = "tbHousing";
            this.tbHousing.Size = new System.Drawing.Size(50, 20);
            this.tbHousing.TabIndex = 28;
            // 
            // tbApartment
            // 
            this.tbApartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnAddress1, "tG_AbnAddress.Apartment", true));
            this.tbApartment.Location = new System.Drawing.Point(321, 175);
            this.tbApartment.Name = "tbApartment";
            this.tbApartment.Size = new System.Drawing.Size(50, 20);
            this.tbApartment.TabIndex = 29;
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(105, 204);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(100, 20);
            this.tbIndex.TabIndex = 30;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCansel,
            this.toolStripSeparator1,
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbSelect,
            this.tsbCopy,
            this.toolStripSeparator3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 369);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(387, 25);
            this.toolStrip2.TabIndex = 33;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbCansel
            // 
            this.tsbCansel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCansel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCansel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCansel.Name = "tsbCansel";
            this.tsbCansel.Size = new System.Drawing.Size(65, 22);
            this.tsbCansel.Text = "Отменить";
            this.tsbCansel.Click += new System.EventHandler(this.tsbCansel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(61, 22);
            this.tsbSave.Text = "Записать";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSelect
            // 
            this.tsbSelect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(93, 22);
            this.tsbSelect.Text = "Подбор улицы";
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(76, 22);
            this.tsbCopy.Text = "Копировать";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Дата:";
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(105, 52);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(266, 20);
            this.tbRegion.TabIndex = 36;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(105, 82);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(266, 20);
            this.tbCity.TabIndex = 37;
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(105, 112);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(266, 20);
            this.tbLocal.TabIndex = 38;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(105, 142);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(266, 20);
            this.tbStreet.TabIndex = 39;
            // 
            // tbRepresentation
            // 
            this.tbRepresentation.AcceptsTab = true;
            this.tbRepresentation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRepresentation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRepresentation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnAddress1, "tG_AbnAddress.Representation", true));
            this.tbRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRepresentation.Location = new System.Drawing.Point(6, 17);
            this.tbRepresentation.Name = "tbRepresentation";
            this.tbRepresentation.Size = new System.Drawing.Size(357, 82);
            this.tbRepresentation.TabIndex = 40;
            this.tbRepresentation.Text = "";
            // 
            // groupBoxRepresentation
            // 
            this.groupBoxRepresentation.Controls.Add(this.tbRepresentation);
            this.groupBoxRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRepresentation.Location = new System.Drawing.Point(12, 232);
            this.groupBoxRepresentation.Name = "groupBoxRepresentation";
            this.groupBoxRepresentation.Size = new System.Drawing.Size(369, 105);
            this.groupBoxRepresentation.TabIndex = 41;
            this.groupBoxRepresentation.TabStop = false;
            this.groupBoxRepresentation.Text = "Представление";
            // 
            // buttonCreateView
            // 
            this.buttonCreateView.Image = global::Legal.Properties.Resources.arrow_down;
            this.buttonCreateView.Location = new System.Drawing.Point(337, 207);
            this.buttonCreateView.Name = "buttonCreateView";
            this.buttonCreateView.Size = new System.Drawing.Size(34, 26);
            this.buttonCreateView.TabIndex = 42;
            this.buttonCreateView.UseVisualStyleBackColor = true;
            this.buttonCreateView.Click += new System.EventHandler(this.buttonCreateView_Click);
            // 
            // FormAbnAddress
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(387, 394);
            this.Controls.Add(this.buttonCreateView);
            this.Controls.Add(this.groupBoxRepresentation);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbLocal);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.label2);
            this.Controls.Add(dtChange);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.tbApartment);
            this.Controls.Add(this.tbHousing);
            this.Controls.Add(this.tbHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAddressType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbnAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Адрес";
            this.Load += new System.EventHandler(this.FormAbnAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnAddress1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBoxRepresentation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAddressType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHouse;
        private System.Windows.Forms.TextBox tbHousing;
        private System.Windows.Forms.TextBox tbApartment;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbCansel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label2;
        private Legal.DataSet.dsAbnAddress dsAbnAddress1;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.RichTextBox tbRepresentation;
        private System.Windows.Forms.GroupBox groupBoxRepresentation;
        private System.Windows.Forms.Button buttonCreateView;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
