namespace ReferenceWorker
{
	public partial class FormWorkerGroupAddEdit : FormLbr.FormBase
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
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelTypeContact = new System.Windows.Forms.Label();
            this.comboBoxGroupWorker = new System.Windows.Forms.ComboBox();
            this.dsWorker = new ReferenceWorker.DataSetWorker();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
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
            // textBoxFIO
            // 
            this.textBoxFIO.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFIO.Location = new System.Drawing.Point(15, 25);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.ReadOnly = true;
            this.textBoxFIO.Size = new System.Drawing.Size(185, 20);
            this.textBoxFIO.TabIndex = 7;
            // 
            // labelTypeContact
            // 
            this.labelTypeContact.AutoSize = true;
            this.labelTypeContact.Location = new System.Drawing.Point(12, 61);
            this.labelTypeContact.Name = "labelTypeContact";
            this.labelTypeContact.Size = new System.Drawing.Size(98, 13);
            this.labelTypeContact.TabIndex = 0;
            this.labelTypeContact.Text = "Группа работника";
            // 
            // comboBoxGroupWorker
            // 
            this.comboBoxGroupWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGroupWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGroupWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsWorker, "tL_ClassifierWorker.IdGroup", true));
            this.comboBoxGroupWorker.DataSource = this.dsWorker;
            this.comboBoxGroupWorker.DisplayMember = "tR_Classifier.Name";
            this.comboBoxGroupWorker.FormattingEnabled = true;
            this.comboBoxGroupWorker.Location = new System.Drawing.Point(15, 77);
            this.comboBoxGroupWorker.Name = "comboBoxGroupWorker";
            this.comboBoxGroupWorker.Size = new System.Drawing.Size(185, 21);
            this.comboBoxGroupWorker.TabIndex = 1;
            this.comboBoxGroupWorker.ValueMember = "tR_Classifier.Id";
            this.comboBoxGroupWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupWorker_SelectedIndexChanged);
            // 
            // dsWorker
            // 
            this.dsWorker.DataSetName = "DataSetWorkers";
            this.dsWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 114);
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
            this.buttonCancel.Location = new System.Drawing.Point(125, 114);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormWorkerGroupAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(211, 146);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxGroupWorker);
            this.Controls.Add(this.labelTypeContact);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWorkerGroupAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormWorkerContactAddEdit";
            this.Load += new System.EventHandler(this.FormWorkerGroupAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Label labelFIO;

		private System.Windows.Forms.TextBox textBoxFIO;

		private System.Windows.Forms.Label labelTypeContact;

		private System.Windows.Forms.ComboBox comboBoxGroupWorker;

		private System.Windows.Forms.Button buttonOk;

		private System.Windows.Forms.Button buttonCancel;

		private ReferenceWorker.DataSetWorker dsWorker;
	}
}
