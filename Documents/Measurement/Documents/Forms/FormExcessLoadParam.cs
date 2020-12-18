using Measurement.DataSets;
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
    private Measurement.DataSets.DataSetMeasurementN dsMeasurementN;
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
            new Documents.Measurement.FormMeasurementReports(this.SqlSettings, (int) this.cbYear.SelectedValue, (int) this.cbNetworkAreas.SelectedValue, this.nudFactor.Value)
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label_0 = new System.Windows.Forms.Label();
            this.cbNetworkAreas = new System.Windows.Forms.ComboBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.nudFactor = new System.Windows.Forms.NumericUpDown();
            this.label_2 = new System.Windows.Forms.Label();
            this.dsMeasurementN = new Measurement.DataSets.DataSetMeasurementN();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurementN)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Controls.Add(this.btnAccept, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccept.Location = new System.Drawing.Point(70, 6);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 6, 10, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(83, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Применить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(173, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 6, 3, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(100, 22);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(149, 21);
            this.cbYear.TabIndex = 1;
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(12, 25);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(25, 13);
            this.label_0.TabIndex = 2;
            this.label_0.Text = "Год";
            // 
            // cbNetworkAreas
            // 
            this.cbNetworkAreas.FormattingEnabled = true;
            this.cbNetworkAreas.Location = new System.Drawing.Point(100, 49);
            this.cbNetworkAreas.Name = "cbNetworkAreas";
            this.cbNetworkAreas.Size = new System.Drawing.Size(149, 21);
            this.cbNetworkAreas.TabIndex = 3;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(12, 52);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(82, 13);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "Сетевой район";
            // 
            // nudFactor
            // 
            this.nudFactor.DecimalPlaces = 1;
            this.nudFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFactor.Location = new System.Drawing.Point(101, 76);
            this.nudFactor.Name = "nudFactor";
            this.nudFactor.Size = new System.Drawing.Size(148, 20);
            this.nudFactor.TabIndex = 5;
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(12, 78);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(77, 13);
            this.label_2.TabIndex = 6;
            this.label_2.Text = "Коэффициент";
            // 
            // dsMeasurementN
            // 
            this.dsMeasurementN.DataSetName = "DataSetMeasurementN";
            this.dsMeasurementN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormExcessLoadParam
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(261, 156);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.nudFactor);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.cbNetworkAreas);
            this.Controls.Add(this.label_0);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormExcessLoadParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Превышение нагрузки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExcessLoadParam_FormClosing);
            this.Load += new System.EventHandler(this.FormExcessLoadParam_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurementN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

