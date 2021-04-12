namespace Test1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet11 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonExportExcel3 = new Library.ToolStripButtonExportExcel(this.components);
            this.toolStripButtonMail1 = new Library.ToolStripButtonMail(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lInterval = new System.Windows.Forms.ToolStripLabel();
            this.tsbInterval = new System.Windows.Forms.ToolStripTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LoadSchemaMain = new System.Windows.Forms.Button();
            this.rtbSchemaMain = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "NewDataSet";
            this.dataSet11.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Column2";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Column3";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Column4";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonExportExcel3,
            this.toolStripButtonMail1,
            this.lInterval,
            this.tsbInterval});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonExportExcel3
            // 
            this.toolStripButtonExportExcel3.DataGridView = null;
            this.toolStripButtonExportExcel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportExcel3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportExcel3.Name = "toolStripButtonExportExcel3";
            this.toolStripButtonExportExcel3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExportExcel3.Text = "Экспорт в Excel";
            // 
            // toolStripButtonMail1
            // 
            this.toolStripButtonMail1.DataGridView = this.dataGridView1;
            this.toolStripButtonMail1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMail1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMail1.Name = "toolStripButtonMail1";
            this.toolStripButtonMail1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMail1.Text = "Отправить почту";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 59);
            this.dataGridView1.TabIndex = 3;
            // 
            // lInterval
            // 
            this.lInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lInterval.Name = "lInterval";
            this.lInterval.Size = new System.Drawing.Size(62, 22);
            this.lInterval.Text = "Интервал";
            // 
            // tsbInterval
            // 
            this.tsbInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsbInterval.MaxLength = 100;
            this.tsbInterval.Name = "tsbInterval";
            this.tsbInterval.Size = new System.Drawing.Size(35, 25);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(223, 77);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoadSchemaMain
            // 
            this.LoadSchemaMain.Location = new System.Drawing.Point(435, 136);
            this.LoadSchemaMain.Name = "LoadSchemaMain";
            this.LoadSchemaMain.Size = new System.Drawing.Size(75, 23);
            this.LoadSchemaMain.TabIndex = 6;
            this.LoadSchemaMain.Text = "LoadSchemaMain";
            this.LoadSchemaMain.UseVisualStyleBackColor = true;
            this.LoadSchemaMain.Click += new System.EventHandler(this.LoadSchemaMain_Click);
            // 
            // rtbSchemaMain
            // 
            this.rtbSchemaMain.Location = new System.Drawing.Point(435, 166);
            this.rtbSchemaMain.Name = "rtbSchemaMain";
            this.rtbSchemaMain.Size = new System.Drawing.Size(353, 272);
            this.rtbSchemaMain.TabIndex = 7;
            this.rtbSchemaMain.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSchemaMain);
            this.Controls.Add(this.LoadSchemaMain);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.DataSet dataSet11;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Library.ToolStripButtonExportExcel toolStripButtonExportExcel3;
        private Library.ToolStripButtonMail toolStripButtonMail1;
        private Library.PageReestrDocs buttonTest1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Library.PageReestrDocs pageReestrDocs1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LoadSchemaMain;
        private System.Windows.Forms.RichTextBox rtbSchemaMain;
        private System.Windows.Forms.ToolStripLabel lInterval;
        private System.Windows.Forms.ToolStripTextBox tsbInterval;
    }
}