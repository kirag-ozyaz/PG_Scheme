namespace Documents
{
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.DataSets;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class SelectElementForm : FormBase
    {
        private Button button_0;
        private dsCalc dsCalc_0;
        private FormBase formBase_0;
        public ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter GridView;
        private IContainer icontainer_0;
        private Panel panel_0;

        public SelectElementForm()
        {
            this.method_0();
            this.GridView.DataSource = this.dsCalc_0;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void GridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void method_0()
        {
            this.panel_0 = new Panel();
            this.button_0 = new Button();
            this.GridView = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dsCalc_0 = new dsCalc();
            this.panel_0.SuspendLayout();
            this.GridView.BeginInit();
            this.dsCalc_0.BeginInit();
            base.SuspendLayout();
            this.panel_0.Controls.Add(this.button_0);
            this.panel_0.Dock = DockStyle.Bottom;
            this.panel_0.Location = new Point(0, 0x141);
            this.panel_0.Name = "panel1";
            this.panel_0.Size = new Size(0x278, 0x22);
            this.panel_0.TabIndex = 2;
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.button_0.Location = new Point(0x231, 6);
            this.button_0.Name = "btnClose";
            this.button_0.Size = new Size(0x44, 0x17);
            this.button_0.TabIndex = 13;
            this.button_0.Text = "Закрыть";
            this.button_0.UseVisualStyleBackColor = true;
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.BackgroundColor = SystemColors.Control;
            this.GridView.BorderStyle = BorderStyle.None;
            this.GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = DockStyle.Fill;
            this.GridView.Location = new Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.set_NumbLineVisible(false);
            this.GridView.ReadOnly = true;
            this.GridView.Size = new Size(0x278, 0x141);
            this.GridView.TabIndex = 5;
            this.GridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.GridView_CellMouseDoubleClick);
            this.GridView.KeyDown += new KeyEventHandler(this.GridView_KeyDown);
            this.dsCalc_0.DataSetName = "dsCalc";
            this.dsCalc_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x278, 0x163);
            base.Controls.Add(this.GridView);
            base.Controls.Add(this.panel_0);
            base.Name = "SelectElementForm";
            this.Text = "SelectElemnetForm";
            this.panel_0.ResumeLayout(false);
            this.GridView.EndInit();
            this.dsCalc_0.EndInit();
            base.ResumeLayout(false);
        }

        [Browsable(false)]
        public FormBase FormParent
        {
            get
            {
                return this.formBase_0;
            }
            set
            {
                this.formBase_0 = value;
            }
        }
    }
}

