namespace Prv.Forms.Reports
{
    partial class FormDebRep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSourceRepDeb = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDebPrognoz = new System.Windows.Forms.Button();
            this.buttonDebAllAbn = new System.Windows.Forms.Button();
            this.groupBoxWait = new System.Windows.Forms.GroupBox();
            this.progressBarEndLess = new ControlsLbr.ProgressBarEndLess();
            this.gBoxNoDeb = new System.Windows.Forms.GroupBox();
            this.buttonApplay = new System.Windows.Forms.Button();
            this.radioButtonYesOurNoUE = new System.Windows.Forms.RadioButton();
            this.radioButtonNoOurYesUE = new System.Windows.Forms.RadioButton();
            this.radioButtonOurNotDeb = new System.Windows.Forms.RadioButton();
            this.gBoxV = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRaznost = new System.Windows.Forms.Button();
            this.buttonUEkWt = new System.Windows.Forms.Button();
            this.buttonOurkWt = new System.Windows.Forms.Button();
            this.labelkWt = new System.Windows.Forms.Label();
            this.mTBoxPo = new System.Windows.Forms.MaskedTextBox();
            this.labelPo = new System.Windows.Forms.Label();
            this.mTBoxS = new System.Windows.Forms.MaskedTextBox();
            this.labelS = new System.Windows.Forms.Label();
            this.gBoxPeriod = new System.Windows.Forms.GroupBox();
            this.cBoxPeriod = new System.Windows.Forms.ComboBox();
            this.reportViewerDebRep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.backgroundWorkerRepDeb = new System.ComponentModel.BackgroundWorker();
            this.buttonDebNotIns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRepDeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxWait.SuspendLayout();
            this.gBoxNoDeb.SuspendLayout();
            this.gBoxV.SuspendLayout();
            this.gBoxPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceRepDeb
            // 
            this.bindingSourceRepDeb.DataMember = "TableDeb";
            this.bindingSourceRepDeb.DataSource = this.dsRep;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonDebNotIns);
            this.panel1.Controls.Add(this.buttonDebPrognoz);
            this.panel1.Controls.Add(this.buttonDebAllAbn);
            this.panel1.Controls.Add(this.groupBoxWait);
            this.panel1.Controls.Add(this.gBoxNoDeb);
            this.panel1.Controls.Add(this.gBoxV);
            this.panel1.Controls.Add(this.gBoxPeriod);
            this.panel1.Location = new System.Drawing.Point(675, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 557);
            this.panel1.TabIndex = 0;
            // 
            // buttonDebPrognoz
            // 
            this.buttonDebPrognoz.Location = new System.Drawing.Point(6, 480);
            this.buttonDebPrognoz.Name = "buttonDebPrognoz";
            this.buttonDebPrognoz.Size = new System.Drawing.Size(148, 24);
            this.buttonDebPrognoz.TabIndex = 25;
            this.buttonDebPrognoz.Text = "Прогноз";
            this.buttonDebPrognoz.UseVisualStyleBackColor = true;
            this.buttonDebPrognoz.Click += new System.EventHandler(this.buttonDebPrognoz_Click);
            // 
            // buttonDebAllAbn
            // 
            this.buttonDebAllAbn.Location = new System.Drawing.Point(6, 448);
            this.buttonDebAllAbn.Name = "buttonDebAllAbn";
            this.buttonDebAllAbn.Size = new System.Drawing.Size(148, 26);
            this.buttonDebAllAbn.TabIndex = 24;
            this.buttonDebAllAbn.Text = "Анализ";
            this.buttonDebAllAbn.UseVisualStyleBackColor = true;
            this.buttonDebAllAbn.Click += new System.EventHandler(this.buttonDebAllAbn_Click);
            // 
            // groupBoxWait
            // 
            this.groupBoxWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWait.Controls.Add(this.progressBarEndLess);
            this.groupBoxWait.Location = new System.Drawing.Point(4, 512);
            this.groupBoxWait.Name = "groupBoxWait";
            this.groupBoxWait.Size = new System.Drawing.Size(150, 35);
            this.groupBoxWait.TabIndex = 23;
            this.groupBoxWait.TabStop = false;
            this.groupBoxWait.Text = "Подождите...";
            // 
            // progressBarEndLess
            // 
            this.progressBarEndLess.AutoProgressSpeed = 100;
            this.progressBarEndLess.IndicatorColor = System.Drawing.Color.LightGreen;
            this.progressBarEndLess.Location = new System.Drawing.Point(2, 16);
            this.progressBarEndLess.Name = "progressBarEndLess";
            this.progressBarEndLess.NormalImage = null;
            this.progressBarEndLess.PointImage = null;
            this.progressBarEndLess.Position = 0;
            this.progressBarEndLess.ProgressBoxStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessBoxStyleConstants.SolidSameSize;
            this.progressBarEndLess.ProgressStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessStyleConstants.LeftToRight;
            this.progressBarEndLess.ProgressType = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessTypeConstants.GraphicType;
            this.progressBarEndLess.ShowBorder = false;
            this.progressBarEndLess.Size = new System.Drawing.Size(144, 13);
            this.progressBarEndLess.TabIndex = 21;
            // 
            // gBoxNoDeb
            // 
            this.gBoxNoDeb.Controls.Add(this.buttonApplay);
            this.gBoxNoDeb.Controls.Add(this.radioButtonYesOurNoUE);
            this.gBoxNoDeb.Controls.Add(this.radioButtonNoOurYesUE);
            this.gBoxNoDeb.Controls.Add(this.radioButtonOurNotDeb);
            this.gBoxNoDeb.Location = new System.Drawing.Point(4, 279);
            this.gBoxNoDeb.Name = "gBoxNoDeb";
            this.gBoxNoDeb.Size = new System.Drawing.Size(150, 131);
            this.gBoxNoDeb.TabIndex = 4;
            this.gBoxNoDeb.TabStop = false;
            this.gBoxNoDeb.Text = "Сравнение";
            // 
            // buttonApplay
            // 
            this.buttonApplay.Location = new System.Drawing.Point(7, 92);
            this.buttonApplay.Name = "buttonApplay";
            this.buttonApplay.Size = new System.Drawing.Size(133, 23);
            this.buttonApplay.TabIndex = 3;
            this.buttonApplay.Text = "Выполнить";
            this.buttonApplay.UseVisualStyleBackColor = true;
            this.buttonApplay.Click += new System.EventHandler(this.buttonApplay_Click);
            // 
            // radioButtonYesOurNoUE
            // 
            this.radioButtonYesOurNoUE.AutoSize = true;
            this.radioButtonYesOurNoUE.Location = new System.Drawing.Point(7, 68);
            this.radioButtonYesOurNoUE.Name = "radioButtonYesOurNoUE";
            this.radioButtonYesOurNoUE.Size = new System.Drawing.Size(123, 17);
            this.radioButtonYesOurNoUE.TabIndex = 2;
            this.radioButtonYesOurNoUE.TabStop = true;
            this.radioButtonYesOurNoUE.Text = "у нас есть у УЭ нет";
            this.radioButtonYesOurNoUE.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoOurYesUE
            // 
            this.radioButtonNoOurYesUE.AutoSize = true;
            this.radioButtonNoOurYesUE.Location = new System.Drawing.Point(7, 44);
            this.radioButtonNoOurYesUE.Name = "radioButtonNoOurYesUE";
            this.radioButtonNoOurYesUE.Size = new System.Drawing.Size(123, 17);
            this.radioButtonNoOurYesUE.TabIndex = 1;
            this.radioButtonNoOurYesUE.TabStop = true;
            this.radioButtonNoOurYesUE.Text = "у нас нет у УЭ есть";
            this.radioButtonNoOurYesUE.UseVisualStyleBackColor = true;
            // 
            // radioButtonOurNotDeb
            // 
            this.radioButtonOurNotDeb.AutoSize = true;
            this.radioButtonOurNotDeb.Location = new System.Drawing.Point(7, 20);
            this.radioButtonOurNotDeb.Name = "radioButtonOurNotDeb";
            this.radioButtonOurNotDeb.Size = new System.Drawing.Size(133, 17);
            this.radioButtonOurNotDeb.TabIndex = 0;
            this.radioButtonOurNotDeb.TabStop = true;
            this.radioButtonOurNotDeb.Text = "у нас не расчиталось";
            this.radioButtonOurNotDeb.UseVisualStyleBackColor = true;
            // 
            // gBoxV
            // 
            this.gBoxV.Controls.Add(this.label1);
            this.gBoxV.Controls.Add(this.buttonRaznost);
            this.gBoxV.Controls.Add(this.buttonUEkWt);
            this.gBoxV.Controls.Add(this.buttonOurkWt);
            this.gBoxV.Controls.Add(this.labelkWt);
            this.gBoxV.Controls.Add(this.mTBoxPo);
            this.gBoxV.Controls.Add(this.labelPo);
            this.gBoxV.Controls.Add(this.mTBoxS);
            this.gBoxV.Controls.Add(this.labelS);
            this.gBoxV.Location = new System.Drawing.Point(4, 68);
            this.gBoxV.Name = "gBoxV";
            this.gBoxV.Size = new System.Drawing.Size(150, 202);
            this.gBoxV.TabIndex = 3;
            this.gBoxV.TabStop = false;
            this.gBoxV.Text = "По объемам";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "кВт";
            // 
            // buttonRaznost
            // 
            this.buttonRaznost.Location = new System.Drawing.Point(13, 166);
            this.buttonRaznost.Name = "buttonRaznost";
            this.buttonRaznost.Size = new System.Drawing.Size(127, 25);
            this.buttonRaznost.TabIndex = 7;
            this.buttonRaznost.Text = "Разность";
            this.buttonRaznost.UseVisualStyleBackColor = true;
            this.buttonRaznost.Click += new System.EventHandler(this.buttonRaznost_Click);
            // 
            // buttonUEkWt
            // 
            this.buttonUEkWt.Location = new System.Drawing.Point(12, 136);
            this.buttonUEkWt.Name = "buttonUEkWt";
            this.buttonUEkWt.Size = new System.Drawing.Size(128, 24);
            this.buttonUEkWt.TabIndex = 6;
            this.buttonUEkWt.Text = "Объем УЭ";
            this.buttonUEkWt.UseVisualStyleBackColor = true;
            this.buttonUEkWt.Click += new System.EventHandler(this.buttonUEkWt_Click);
            // 
            // buttonOurkWt
            // 
            this.buttonOurkWt.Location = new System.Drawing.Point(10, 104);
            this.buttonOurkWt.Name = "buttonOurkWt";
            this.buttonOurkWt.Size = new System.Drawing.Size(130, 25);
            this.buttonOurkWt.TabIndex = 5;
            this.buttonOurkWt.Text = "Наш Объем";
            this.buttonOurkWt.UseVisualStyleBackColor = true;
            this.buttonOurkWt.Click += new System.EventHandler(this.buttonOurkWt_Click);
            // 
            // labelkWt
            // 
            this.labelkWt.AutoSize = true;
            this.labelkWt.Location = new System.Drawing.Point(105, 35);
            this.labelkWt.Name = "labelkWt";
            this.labelkWt.Size = new System.Drawing.Size(25, 13);
            this.labelkWt.TabIndex = 4;
            this.labelkWt.Text = "кВт";
            // 
            // mTBoxPo
            // 
            this.mTBoxPo.Location = new System.Drawing.Point(9, 77);
            this.mTBoxPo.Mask = "#########";
            this.mTBoxPo.Name = "mTBoxPo";
            this.mTBoxPo.Size = new System.Drawing.Size(95, 20);
            this.mTBoxPo.TabIndex = 3;
            this.mTBoxPo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // labelPo
            // 
            this.labelPo.AutoSize = true;
            this.labelPo.Location = new System.Drawing.Point(9, 60);
            this.labelPo.Name = "labelPo";
            this.labelPo.Size = new System.Drawing.Size(19, 13);
            this.labelPo.TabIndex = 2;
            this.labelPo.Text = "по";
            // 
            // mTBoxS
            // 
            this.mTBoxS.Location = new System.Drawing.Point(9, 32);
            this.mTBoxS.Mask = "#########";
            this.mTBoxS.Name = "mTBoxS";
            this.mTBoxS.Size = new System.Drawing.Size(95, 20);
            this.mTBoxS.TabIndex = 1;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(6, 16);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(13, 13);
            this.labelS.TabIndex = 0;
            this.labelS.Text = "c";
            // 
            // gBoxPeriod
            // 
            this.gBoxPeriod.Controls.Add(this.cBoxPeriod);
            this.gBoxPeriod.Location = new System.Drawing.Point(3, 8);
            this.gBoxPeriod.Name = "gBoxPeriod";
            this.gBoxPeriod.Size = new System.Drawing.Size(151, 54);
            this.gBoxPeriod.TabIndex = 2;
            this.gBoxPeriod.TabStop = false;
            this.gBoxPeriod.Text = "Период";
            // 
            // cBoxPeriod
            // 
            this.cBoxPeriod.FormatString = "MMMM yyyy";
            this.cBoxPeriod.FormattingEnabled = true;
            this.cBoxPeriod.Location = new System.Drawing.Point(6, 19);
            this.cBoxPeriod.Name = "cBoxPeriod";
            this.cBoxPeriod.Size = new System.Drawing.Size(135, 21);
            this.cBoxPeriod.TabIndex = 0;
            // 
            // reportViewerDebRep
            // 
            this.reportViewerDebRep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetRep_TableDeb";
            reportDataSource1.Value = this.bindingSourceRepDeb;
            this.reportViewerDebRep.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDebRep.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportRepDeb.rdlc";
            this.reportViewerDebRep.Location = new System.Drawing.Point(4, 2);
            this.reportViewerDebRep.Name = "reportViewerDebRep";
            this.reportViewerDebRep.Size = new System.Drawing.Size(669, 557);
            this.reportViewerDebRep.TabIndex = 1;
            this.reportViewerDebRep.Load += new System.EventHandler(this.reportViewerDebRep_Load);
            // 
            // backgroundWorkerRepDeb
            // 
            this.backgroundWorkerRepDeb.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRepDeb_DoWork);
            this.backgroundWorkerRepDeb.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerRepDeb_RunWorkerCompleted);
            // 
            // buttonDebNotIns
            // 
            this.buttonDebNotIns.Location = new System.Drawing.Point(6, 416);
            this.buttonDebNotIns.Name = "buttonDebNotIns";
            this.buttonDebNotIns.Size = new System.Drawing.Size(148, 26);
            this.buttonDebNotIns.TabIndex = 26;
            this.buttonDebNotIns.Text = "Не прогружены";
            this.buttonDebNotIns.UseVisualStyleBackColor = true;
            this.buttonDebNotIns.Click += new System.EventHandler(this.buttonDebNotIns_Click);
            // 
            // FormDebRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 561);
            this.Controls.Add(this.reportViewerDebRep);
            this.Controls.Add(this.panel1);
            this.Name = "FormDebRep";
            this.Text = "Анализ рассчитаных объемов кВт";
            this.Load += new System.EventHandler(this.FormDebRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRepDeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxWait.ResumeLayout(false);
            this.gBoxNoDeb.ResumeLayout(false);
            this.gBoxNoDeb.PerformLayout();
            this.gBoxV.ResumeLayout(false);
            this.gBoxV.PerformLayout();
            this.gBoxPeriod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cBoxPeriod;
        private System.Windows.Forms.GroupBox gBoxV;
        private System.Windows.Forms.MaskedTextBox mTBoxS;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.GroupBox gBoxPeriod;
        private System.Windows.Forms.MaskedTextBox mTBoxPo;
        private System.Windows.Forms.Label labelPo;
        private System.Windows.Forms.Button buttonRaznost;
        private System.Windows.Forms.Button buttonUEkWt;
        private System.Windows.Forms.Button buttonOurkWt;
        private System.Windows.Forms.Label labelkWt;
        private System.Windows.Forms.GroupBox gBoxNoDeb;
        private System.Windows.Forms.Button buttonApplay;
        private System.Windows.Forms.RadioButton radioButtonYesOurNoUE;
        private System.Windows.Forms.RadioButton radioButtonNoOurYesUE;
        private System.Windows.Forms.RadioButton radioButtonOurNotDeb;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDebRep;
        private System.Windows.Forms.GroupBox groupBoxWait;
        private ControlsLbr.ProgressBarEndLess progressBarEndLess;
        private Prv.DataSets.DataSetRep dsRep;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRepDeb;
        private System.Windows.Forms.BindingSource bindingSourceRepDeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDebAllAbn;
        private System.Windows.Forms.Button buttonDebPrognoz;
        private System.Windows.Forms.Button buttonDebNotIns;
    }
}