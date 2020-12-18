namespace ReferenceWorker
{
	public partial class FormWorkerContactAddEdit : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.labelFIO = new System.Windows.Forms.Label();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.labelTypeContact = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dsWorker = new ReferenceWorker.DataSetWorker();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 9);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "ФИО";
            // 
            // textBox_0
            // 
            this.txtFIO.BackColor = System.Drawing.SystemColors.Window;
            this.txtFIO.Location = new System.Drawing.Point(15, 25);
            this.txtFIO.Name = "textBox_0";
            this.txtFIO.ReadOnly = true;
            this.txtFIO.Size = new System.Drawing.Size(185, 20);
            this.txtFIO.TabIndex = 7;
            // 
            // labelTypeContact
            // 
            this.labelTypeContact.AutoSize = true;
            this.labelTypeContact.Location = new System.Drawing.Point(12, 61);
            this.labelTypeContact.Name = "labelTypeContact";
            this.labelTypeContact.Size = new System.Drawing.Size(154, 13);
            this.labelTypeContact.TabIndex = 0;
            this.labelTypeContact.Text = "Тип контактной информации";
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsWorker, "tR_WorkerContact.Type", true));
            this.comboBoxType.DataSource = this.dsWorker;
            this.comboBoxType.DisplayMember = "tR_Classifier.Name";
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(15, 77);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(185, 21);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.ValueMember = "tR_Classifier.Id";
            // 
            // dsWorker
            // 
            this.dsWorker.DataSetName = "DataSetWorkers";
            this.dsWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(12, 103);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(133, 13);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Контактная информация";
            // 
            // textBoxContact
            // 
            this.textBoxContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsWorker, "tR_WorkerContact.Description", true));
            this.textBoxContact.Location = new System.Drawing.Point(15, 120);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(185, 20);
            this.textBoxContact.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 210);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(125, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsWorker, "tR_WorkerContact.Comment", true));
            this.richTextBox1.Location = new System.Drawing.Point(15, 146);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 58);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // FormWorkerContactAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(216, 244);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelTypeContact);
            this.Controls.Add(this.txtFIO);
            this.Controls.Add(this.labelFIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWorkerContactAddEdit";
            this.Text = "FormWorkerContactAddEdit";
            this.Load += new System.EventHandler(this.FormWorkerContactAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Label labelFIO;

		private System.Windows.Forms.TextBox txtFIO;

		private System.Windows.Forms.Label labelTypeContact;

		private System.Windows.Forms.ComboBox comboBoxType;

		private System.Windows.Forms.Label labelContact;

		private System.Windows.Forms.TextBox textBoxContact;

		private System.Windows.Forms.Button buttonOk;

		private System.Windows.Forms.Button buttonCancel;

		private ReferenceWorker.DataSetWorker dsWorker;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
