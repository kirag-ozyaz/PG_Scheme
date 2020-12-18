namespace Prv.Forms.Reports
{
    partial class FormDebCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebCalc));
            this.cBoxBegin = new System.Windows.Forms.ComboBox();
            this.cBoxEnd = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerCalc = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.bgWCalc = new System.ComponentModel.BackgroundWorker();
            this.buttonCount = new System.Windows.Forms.Button();
            this.bgWCount = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cBoxBegin
            // 
            this.cBoxBegin.FormatString = "MMMM yyyy";
            this.cBoxBegin.FormattingEnabled = true;
            this.cBoxBegin.Location = new System.Drawing.Point(33, 31);
            this.cBoxBegin.Name = "cBoxBegin";
            this.cBoxBegin.Size = new System.Drawing.Size(135, 21);
            this.cBoxBegin.TabIndex = 1;
            // 
            // cBoxEnd
            // 
            this.cBoxEnd.FormatString = "MMMM yyyy";
            this.cBoxEnd.FormattingEnabled = true;
            this.cBoxEnd.Location = new System.Drawing.Point(205, 31);
            this.cBoxEnd.Name = "cBoxEnd";
            this.cBoxEnd.Size = new System.Drawing.Size(135, 21);
            this.cBoxEnd.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "по";
            // 
            // timerCalc
            // 
            this.timerCalc.Interval = 1000;
            this.timerCalc.Tick += new System.EventHandler(this.timerCalc_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(345, 66);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(38, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(389, 66);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(39, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Visible = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(83, 71);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(247, 13);
            this.labelTimer.TabIndex = 8;
            this.labelTimer.Text = "Время выполнения часов: 0  минут: 0 секунд: 0";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.ForeColor = System.Drawing.Color.Red;
            this.labelEnd.Location = new System.Drawing.Point(83, 9);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(0, 13);
            this.labelEnd.TabIndex = 9;
            // 
            // bgWCalc
            // 
            this.bgWCalc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWCalc_DoWork);
            this.bgWCalc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWCalc_RunWorkerCompleted);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(434, 66);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(36, 23);
            this.buttonCount.TabIndex = 10;
            this.buttonCount.Text = "?";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // bgWCount
            // 
            this.bgWCount.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWCount_DoWork);
            // 
            // FormDebCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 101);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBoxEnd);
            this.Controls.Add(this.cBoxBegin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDebCalc";
            this.Text = "Расчет начислений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxBegin;
        private System.Windows.Forms.ComboBox cBoxEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerCalc;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelEnd;
        private System.ComponentModel.BackgroundWorker bgWCalc;
        private System.Windows.Forms.Button buttonCount;
        private System.ComponentModel.BackgroundWorker bgWCount;
    }
}