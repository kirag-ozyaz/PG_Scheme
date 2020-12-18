using DataSql;
using Documents.DataSets;
using FormLbr;
using Passport.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class FormCoefficientLoadihgParam : FormBase
{
    private Button button_0;
    private Button button_1;
    private CheckBox checkBox_0;
    private CheckBox checkBox_1;
    private ComboBox cbNetworkAreas;
    private ComboBox cbYear;
    private ComboBox cbIsPowerLarge;
    private ComboBox cbIsCoeffLarge;
    private DataSetMeasurementN dsJournal;

    private IContainer components = null;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private NumericUpDown numericUpDown_0;
    private TableLayoutPanel tableLayoutPanel_0;
    private TextBox textBox_0;

    internal FormCoefficientLoadihgParam()
    {
        this.InitializeComponent();
    }

    internal FormCoefficientLoadihgParam(SQLSettings sqlsettings, ReportType type)
    {
        this.InitializeComponent();
        this.SqlSettings = (sqlsettings);
        // this.setReportType(type);
        ReportType = (type);
    }

    private void button_1_Click(object sender, EventArgs e)
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

    private void FormCoefficientLoadihgParam_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            new Documents.Forms.Measurement.FormMeasurementReports(
                this.SqlSettings, 
                // this.getReportType(), 
                this.ReportType,
                (int) this.cbYear.SelectedValue, 
                (int) this.cbNetworkAreas.SelectedValue, 
                (this.textBox_0.Text.Length > 0) ? int.Parse(this.textBox_0.Text) : -1,
                this.cbIsPowerLarge.SelectedItem.ToString() == ">",
                this.numericUpDown_0.Value,
                this.cbIsCoeffLarge.SelectedItem.ToString() == ">",
                this.checkBox_0.Checked, 
                this.checkBox_1.Checked)
            { MdiParent = base.MdiParent }.Show();
        }
    }

    private void FormCoefficientLoadihgParam_Load(object sender, EventArgs e)
    {
        //this.Text = (this.getReportType() == ReportType.CoefficientLoading) ? "Анализ коэффициента загрузки" : ((this.getReportType() == ReportType.CoefficientIrregularity) ? "Анализ коэффициента неравномерности фаз" : "");
        this.Text = (this.ReportType == ReportType.CoefficientLoading) ? "Анализ коэффициента загрузки" : ((this.ReportType == ReportType.CoefficientIrregularity) ? "Анализ коэффициента неравномерности фаз" : "");
        //this.label_3.Text = (this.getReportType() == ReportType.CoefficientLoading) ? "Коэффициент загрузки" : ((this.getReportType() == ReportType.CoefficientIrregularity) ? "Коэффициент неравномерности" : "");
        this.label_3.Text = (this.ReportType == ReportType.CoefficientLoading) ? "Коэффициент загрузки" : ((this.ReportType == ReportType.CoefficientIrregularity) ? "Коэффициент неравномерности" : "");
        base.SelectSqlData(this.dsJournal, this.dsJournal.tR_Classifier, true, "WHERE ParentKey = ';NetworkAreas;' AND isGroup = 0 AND Deleted = 0");

        DataSetMeasurementN.tR_ClassifierRow row = this.dsJournal.tR_Classifier.NewtR_ClassifierRow();
        row.Id = -1;
        row.Name = "Все";
        row.IsGroup = false;
        row.Deleted = false;
        this.dsJournal.tR_Classifier.AddtR_ClassifierRow(row);

        //this.DataSetGES.tR_Classifier.OrderBy<DataSetGES.Class50, string>(ClassC.c9__6_0 ?? (ClassC.c9__6_0 = new Func<DataSetGES.Class50, string>(ClassC.c9.method_0)));
        dsJournal.tR_Classifier.OrderBy(r => r.Name);
        //from r in dsJournal.tR_Classifier
        //orderby r.Name
        //select r;

        this.cbNetworkAreas.DataSource = this.dsJournal.tR_Classifier;
        this.cbNetworkAreas.DisplayMember = "Name";
        this.cbNetworkAreas.ValueMember = "Id";
        DataTable source = new DataTable();
        source.Columns.Add("Year", typeof(int));
        for (int i = DateTime.Now.Year - 30; i < (DateTime.Now.Year + 1); i++)
        {
            object[] values = new object[] { i };
            source.Rows.Add(values);
        }
        //source.AsEnumerable().OrderBy<DataRow, int>(ClassC.c9__6_1 ?? (ClassC.c9__6_1 = new Func<DataRow, int>(ClassC.c9.method_1)));
        source.AsEnumerable().OrderBy(r => r.Field<int>("Year"));
        //from r in source.AsEnumerable()
        //orderby r.Field<int>("Year")
        //select r;

        this.cbYear.DataSource = source;
        this.cbYear.DisplayMember = "Year";
        this.cbYear.ValueMember = "Year";
        this.cbYear.SelectedValue = DateTime.Now.Year;
        this.cbIsPowerLarge.SelectedIndex = 0;
        this.cbIsCoeffLarge.SelectedIndex = 0;
    }


    //private ReportType ReportType;
    public ReportType ReportType
    {
        get;
        set;
    }
    //internal ReportType getReportType()
    //{
    //    return this.ReportType;
    //}

    //internal void setReportType(ReportType type)
    //{
    //    this.ReportType = type;
    //}

    private void InitializeComponent()
    {
            this.label_0 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.cbNetworkAreas = new System.Windows.Forms.ComboBox();
            this.label_2 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_0 = new System.Windows.Forms.TableLayoutPanel();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.dsJournal = new Documents.DataSets.DataSetMeasurementN();
            this.textBox_0 = new System.Windows.Forms.TextBox();
            this.cbIsPowerLarge = new System.Windows.Forms.ComboBox();
            this.cbIsCoeffLarge = new System.Windows.Forms.ComboBox();
            this.label_3 = new System.Windows.Forms.Label();
            this.checkBox_0 = new System.Windows.Forms.CheckBox();
            this.checkBox_1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown_0 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_0)).BeginInit();
            this.SuspendLayout();
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(12, 67);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(149, 13);
            this.label_0.TabIndex = 13;
            this.label_0.Text = "Мощность трансформатора";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(12, 41);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(82, 13);
            this.label_1.TabIndex = 11;
            this.label_1.Text = "Сетевой район";
            // 
            // comboBox_0
            // 
            this.cbNetworkAreas.FormattingEnabled = true;
            this.cbNetworkAreas.Location = new System.Drawing.Point(187, 38);
            this.cbNetworkAreas.Name = "comboBox_0";
            this.cbNetworkAreas.Size = new System.Drawing.Size(143, 21);
            this.cbNetworkAreas.TabIndex = 10;
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(12, 14);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(25, 13);
            this.label_2.TabIndex = 9;
            this.label_2.Text = "Год";
            // 
            // comboBox_1
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(187, 11);
            this.cbYear.Name = "comboBox_1";
            this.cbYear.Size = new System.Drawing.Size(143, 21);
            this.cbYear.TabIndex = 8;
            // 
            // tableLayoutPanel_0
            // 
            this.tableLayoutPanel_0.ColumnCount = 2;
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel_0.Controls.Add(this.button_0, 0, 0);
            this.tableLayoutPanel_0.Controls.Add(this.button_1, 1, 0);
            this.tableLayoutPanel_0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_0.Location = new System.Drawing.Point(0, 151);
            this.tableLayoutPanel_0.Name = "tableLayoutPanel_0";
            this.tableLayoutPanel_0.RowCount = 1;
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_0.Size = new System.Drawing.Size(340, 35);
            this.tableLayoutPanel_0.TabIndex = 7;
            // 
            // button_0
            // 
            this.button_0.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_0.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_0.Location = new System.Drawing.Point(141, 6);
            this.button_0.Margin = new System.Windows.Forms.Padding(3, 6, 10, 6);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(92, 23);
            this.button_0.TabIndex = 0;
            this.button_0.Text = "Применить";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_1
            // 
            this.button_1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_1.Location = new System.Drawing.Point(253, 6);
            this.button_1.Margin = new System.Windows.Forms.Padding(10, 6, 3, 6);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(70, 23);
            this.button_1.TabIndex = 1;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // dataSetGES_0
            // 
            this.dsJournal.DataSetName = "DataSetMeasurement";
            this.dsJournal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_0
            // 
            this.textBox_0.Location = new System.Drawing.Point(240, 64);
            this.textBox_0.Name = "textBox_0";
            this.textBox_0.Size = new System.Drawing.Size(90, 20);
            this.textBox_0.TabIndex = 14;
            this.textBox_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_0_KeyPress);
            // 
            // comboBox_2
            // 
            this.cbIsPowerLarge.FormattingEnabled = true;
            this.cbIsPowerLarge.Items.AddRange(new object[] {
            ">",
            "<"});
            this.cbIsPowerLarge.Location = new System.Drawing.Point(187, 63);
            this.cbIsPowerLarge.Name = "comboBox_2";
            this.cbIsPowerLarge.Size = new System.Drawing.Size(47, 21);
            this.cbIsPowerLarge.TabIndex = 15;
            // 
            // comboBox_3
            // 
            this.cbIsCoeffLarge.FormattingEnabled = true;
            this.cbIsCoeffLarge.Items.AddRange(new object[] {
            ">",
            "<"});
            this.cbIsCoeffLarge.Location = new System.Drawing.Point(187, 90);
            this.cbIsCoeffLarge.Name = "comboBox_3";
            this.cbIsCoeffLarge.Size = new System.Drawing.Size(47, 21);
            this.cbIsCoeffLarge.TabIndex = 18;
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(12, 93);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(126, 13);
            this.label_3.TabIndex = 16;
            this.label_3.Text = "Коэффициент загрузки";
            // 
            // checkBox_0
            // 
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new System.Drawing.Point(194, 121);
            this.checkBox_0.Name = "checkBox_0";
            this.checkBox_0.Size = new System.Drawing.Size(53, 17);
            this.checkBox_0.TabIndex = 19;
            this.checkBox_0.Text = "День";
            this.checkBox_0.UseVisualStyleBackColor = true;
            // 
            // checkBox_1
            // 
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Location = new System.Drawing.Point(263, 121);
            this.checkBox_1.Name = "checkBox_1";
            this.checkBox_1.Size = new System.Drawing.Size(51, 17);
            this.checkBox_1.TabIndex = 20;
            this.checkBox_1.Text = "Ночь";
            this.checkBox_1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_0
            // 
            this.numericUpDown_0.Location = new System.Drawing.Point(240, 90);
            this.numericUpDown_0.Name = "numericUpDown_0";
            this.numericUpDown_0.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_0.TabIndex = 21;
            // 
            // FormCoefficientLoadihgParam
            // 
            this.AcceptButton = this.button_0;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_1;
            this.ClientSize = new System.Drawing.Size(340, 186);
            this.Controls.Add(this.numericUpDown_0);
            this.Controls.Add(this.checkBox_1);
            this.Controls.Add(this.checkBox_0);
            this.Controls.Add(this.cbIsCoeffLarge);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.cbIsPowerLarge);
            this.Controls.Add(this.textBox_0);
            this.Controls.Add(this.label_0);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.cbNetworkAreas);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.tableLayoutPanel_0);
            this.Name = "FormCoefficientLoadihgParam";
            this.Text = "Анализ коэффициента загрузки\t";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCoefficientLoadihgParam_FormClosing);
            this.Load += new System.EventHandler(this.FormCoefficientLoadihgParam_Load);
            this.tableLayoutPanel_0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void textBox_0_KeyPress(object sender, KeyPressEventArgs e)
    {
        InputCheck.OnlyDigit(sender, e);
    }

    //[Serializable, CompilerGenerated]
    //private sealed class ClassC
    //{
    //    public static readonly FormCoefficientLoadihgParam.ClassC c9 = new FormCoefficientLoadihgParam.ClassC();
    //    public static Func<DataSetGES.Class50, string> c9__6_0;
    //    public static Func<DataRow, int> c9__6_1;

    //    internal string method_0(DataSetGES.Class50 class50_0)
    //    {
    //        return class50_0.Name;
    //    }

    //    internal int method_1(DataRow dataRow_0)
    //    {
    //        return dataRow_0.Field<int>("Year");
    //    }
    //}
}

