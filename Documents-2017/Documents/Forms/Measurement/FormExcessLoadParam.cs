using Documents.DataSets;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class FormExcessLoadParam : FormBase
{
    private Button btnAccept;
    private Button btnCancel;
    private ComboBox cbYear;
    private ComboBox cbNetworkAreas;
    private DataSetMeasurementN dsMeasurementN;
    private IContainer components = null;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private NumericUpDown nudFactor;
    private TableLayoutPanel tableLayoutPanel1;

    internal FormExcessLoadParam()
    {
        this.InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormExcessLoadParam_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            new Documents.Forms.Measurement.FormMeasurementReports(this.SqlSettings, (int) this.cbYear.SelectedValue, (int) this.cbNetworkAreas.SelectedValue, this.nudFactor.Value)
            {
                MdiParent = base.MdiParent
            }.Show();
        }
    }

    private void FormExcessLoadParam_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.tR_Classifier, true, "WHERE ParentKey = ';NetworkAreas;' AND isGroup = 0 AND Deleted = 0");
        DataSetMeasurementN.tR_ClassifierRow row = this.dsMeasurementN.tR_Classifier.NewtR_ClassifierRow();
        row.Id = -1;
        row.Name = "Все";
        row.IsGroup = false;
        row.Deleted = false;
        this.dsMeasurementN.tR_Classifier.AddtR_ClassifierRow(row);

        //this.dsMeasurementN.tR_Classifier.OrderBy(C__1.C_9__1_0 ?? (C__1.C_9__1_0 = new Func<DataSetMeasurementN.tR_ClassifierRow, string>(C__1.C_9.method_0)));

        this.dsMeasurementN.tR_Classifier
            .OrderBy(r => r.Name);
        //from r in this.dsMeasurementN.tR_Classifier orderby r.Name select r;

        this.cbNetworkAreas.DataSource = this.dsMeasurementN.tR_Classifier;
        this.cbNetworkAreas.DisplayMember = "Name";
        this.cbNetworkAreas.ValueMember = "Id";
        DataTable tbl = new DataTable();
        tbl.Columns.Add("Year", typeof(int));
        for (int i = DateTime.Now.Year - 30; i < (DateTime.Now.Year + 1); i++)
        {
            object[] values = new object[] { i };
            tbl.Rows.Add(values);
        }
        //tbl.AsEnumerable().OrderBy(C__1.C_9__1_1 ?? (C__1.C_9__1_1 = new Func<DataRow, int>(C__1.C_9.method_1)));

        tbl.AsEnumerable().OrderBy(r => r.Field<int>("Year"));
        
        //from r in dataTable.AsEnumerable()
        //orderby r.Field("Year")
        //select r;
        this.cbYear.DataSource = tbl;
        this.cbYear.DisplayMember = "Year";
        this.cbYear.ValueMember = "Year";
        this.cbYear.SelectedValue = DateTime.Now.Year;
    }

    private void InitializeComponent()
    {
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.btnAccept = new Button();
        this.btnCancel = new Button();
        this.cbYear = new ComboBox();
        this.label_0 = new Label();
        this.cbNetworkAreas = new ComboBox();
        this.label_1 = new Label();
        this.nudFactor = new NumericUpDown();
        this.label_2 = new Label();
        this.dsMeasurementN = new DataSetMeasurementN();
        this.tableLayoutPanel1.SuspendLayout();
        this.nudFactor.BeginInit();
        this.dsMeasurementN.BeginInit();
        base.SuspendLayout();
        this.tableLayoutPanel1.ColumnCount = 2;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98f));
        this.tableLayoutPanel1.Controls.Add(this.btnAccept, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Bottom;
        this.tableLayoutPanel1.Location = new Point(0, 0x79);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
        this.tableLayoutPanel1.Size = new Size(0x105, 0x23);
        this.tableLayoutPanel1.TabIndex = 0;
        this.btnAccept.DialogResult = DialogResult.OK;
        this.btnAccept.Dock = DockStyle.Right;
        this.btnAccept.Location = new Point(0x3d, 6);
        this.btnAccept.Margin = new Padding(3, 6, 10, 6);
        this.btnAccept.Name = "btnAccept";
        this.btnAccept.Size = new Size(0x5c, 0x17);
        this.btnAccept.TabIndex = 0;
        this.btnAccept.Text = "Применить";
        this.btnAccept.UseVisualStyleBackColor = true;
        this.btnAccept.Click += new EventHandler(this.btnCancel_Click);
        this.btnCancel.DialogResult = DialogResult.Cancel;
        this.btnCancel.Dock = DockStyle.Left;
        this.btnCancel.Location = new Point(0xad, 6);
        this.btnCancel.Margin = new Padding(10, 6, 3, 6);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(70, 0x17);
        this.btnCancel.TabIndex = 1;
        this.btnCancel.Text = "Отмена";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
        this.cbYear.FormattingEnabled = true;
        this.cbYear.Location = new Point(100, 0x16);
        this.cbYear.Name = "cbYear";
        this.cbYear.Size = new Size(0x95, 0x15);
        this.cbYear.TabIndex = 1;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 0x19);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x19, 13);
        this.label_0.TabIndex = 2;
        this.label_0.Text = "Год";
        this.cbNetworkAreas.FormattingEnabled = true;
        this.cbNetworkAreas.Location = new Point(100, 0x31);
        this.cbNetworkAreas.Name = "cbNetworkAreas";
        this.cbNetworkAreas.Size = new Size(0x95, 0x15);
        this.cbNetworkAreas.TabIndex = 3;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 0x34);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x52, 13);
        this.label_1.TabIndex = 4;
        this.label_1.Text = "Сетевой район";
        this.nudFactor.DecimalPlaces = 1;
        int[] bits = new int[4];
        bits[0] = 1;
        bits[3] = 0x10000;
        this.nudFactor.Increment = new decimal(bits);
        this.nudFactor.Location = new Point(0x65, 0x4c);
        this.nudFactor.Name = "nudFactor";
        this.nudFactor.Size = new Size(0x94, 20);
        this.nudFactor.TabIndex = 5;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x4e);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x4d, 13);
        this.label_2.TabIndex = 6;
        this.label_2.Text = "Коэффициент";
        this.dsMeasurementN.DataSetName = "DataSetMeasurementN";
        this.dsMeasurementN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        base.AcceptButton = this.btnAccept;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.btnCancel;
        base.ClientSize = new Size(0x105, 0x9c);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.nudFactor);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.cbNetworkAreas);
        base.Controls.Add(this.label_0);
        base.Controls.Add(this.cbYear);
        base.Controls.Add(this.tableLayoutPanel1);
        base.Name = "FormExcessLoadParam";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Превышение нагрузки";
        base.FormClosing += new FormClosingEventHandler(this.FormExcessLoadParam_FormClosing);
        base.Load += new EventHandler(this.FormExcessLoadParam_Load);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.nudFactor.EndInit();
        this.dsMeasurementN.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    //[Serializable, CompilerGenerated]
    //private sealed class C__1
    //{
    //    public static readonly C__1 C_9 = new C__1();
    //    public static Func<DataSetMeasurementN.tR_ClassifierRow, string> C_9__1_0;
    //    public static Func<DataRow, int> C_9__1_1;

    //    internal string method_0(DataSetMeasurementN.tR_ClassifierRow class50_0)
    //    {
    //        return class50_0.Name;
    //    }

    //    internal int method_1(DataRow dataRow_0)
    //    {
    //        return dataRow_0.Field<int>("Year");
    //    }
    //}
}

