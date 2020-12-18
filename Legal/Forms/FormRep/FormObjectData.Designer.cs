namespace Legal.Forms.FormRep
{
    partial class FormObjectData
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntVal1 = new Legal.DataSet.dsCntVal();
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSelectObject = new System.Windows.Forms.Button();
            this.cbSelectObject = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbAbn = new System.Windows.Forms.RadioButton();
            this.cbObj = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtObjectData";
            this.bindingSource1.DataSource = this.dsCntVal1;
            // 
            // dsCntVal1
            // 
            this.dsCntVal1.DataSetName = "dsCntVal";
            this.dsCntVal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerRus1.Location = new System.Drawing.Point(-2, 97);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(677, 443);
            this.reportViewerRus1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Период выборки начислений";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(48, 56);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 42;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(48, 27);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(565, 54);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(565, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 44;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSelectObject
            // 
            this.btnSelectObject.Location = new System.Drawing.Point(28, 36);
            this.btnSelectObject.Name = "btnSelectObject";
            this.btnSelectObject.Size = new System.Drawing.Size(89, 23);
            this.btnSelectObject.TabIndex = 46;
            this.btnSelectObject.Text = "Выбрать";
            this.btnSelectObject.UseVisualStyleBackColor = true;
            this.btnSelectObject.Click += new System.EventHandler(this.btnSelectObject_Click);
            // 
            // cbSelectObject
            // 
            this.cbSelectObject.AutoSize = true;
            this.cbSelectObject.Location = new System.Drawing.Point(6, 18);
            this.cbSelectObject.Name = "cbSelectObject";
            this.cbSelectObject.Size = new System.Drawing.Size(171, 17);
            this.cbSelectObject.TabIndex = 47;
            this.cbSelectObject.Text = "Только выбранные объекты";
            this.cbSelectObject.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbObj);
            this.groupBox1.Controls.Add(this.cbAbn);
            this.groupBox1.Location = new System.Drawing.Point(199, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 64);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Группировка ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSelectObject);
            this.groupBox2.Controls.Add(this.btnSelectObject);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 65);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Фильтр ";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "dtObjectData1";
            this.bindingSource2.DataSource = this.dsCntVal1;
            // 
            // cbAbn
            // 
            this.cbAbn.AutoSize = true;
            this.cbAbn.Location = new System.Drawing.Point(6, 17);
            this.cbAbn.Name = "cbAbn";
            this.cbAbn.Size = new System.Drawing.Size(63, 17);
            this.cbAbn.TabIndex = 0;
            this.cbAbn.TabStop = true;
            this.cbAbn.Text = "по дате";
            this.cbAbn.UseVisualStyleBackColor = true;
            this.cbAbn.Click += new System.EventHandler(this.cbAbn_Click);
            // 
            // cbObj
            // 
            this.cbObj.AutoSize = true;
            this.cbObj.Location = new System.Drawing.Point(6, 40);
            this.cbObj.Name = "cbObj";
            this.cbObj.Size = new System.Drawing.Size(110, 17);
            this.cbObj.TabIndex = 1;
            this.cbObj.TabStop = true;
            this.cbObj.Text = "по дате, объекту";
            this.cbObj.UseVisualStyleBackColor = true;
            this.cbObj.Click += new System.EventHandler(this.cbObj_Click);
            // 
            // FormObjectData
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(675, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormObjectData";
            this.Text = "Отчет по начислениям по потребителю";
            this.Load += new System.EventHandler(this.FormObjectData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private DataSet.dsCntVal dsCntVal1;
        private System.Windows.Forms.Button btnSelectObject;
        private System.Windows.Forms.CheckBox cbSelectObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.RadioButton cbObj;
        private System.Windows.Forms.RadioButton cbAbn;
    }
}
