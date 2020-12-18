
// Fields
using FormLbr.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

private Label f000018;
    private Label f000029;
    private Label f00002b;
    private bool f000034;
    private int f00004d;
    private int f000072;
    private Label f000084;
    private DateTime f0000dd;
    private Label f00010e;
    private Label f000110;
    private TextBox f000115;
    private TextBox f00011a;
    private Label f00011f;
    private Label f00014c;
    private Label f00015a;
    private DataGridViewTextBoxColumn f00017f;
    private Label f00019d;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter f0001b3;
    private DataGridViewTextBoxColumn f0001b6;
    private DataGridViewTextBoxColumn f0001b7;
    private DataGridViewTextBoxColumn f0001b8;
    private ToolStripButton f0001c0;
    private DataGridViewTextBoxColumn f0001c5;
    private DataGridViewTextBoxColumn f0001c9;
    private RequestForRepair.DataSets.DataSetN dataSetN;
    private Label f000234;
    private ComboBox f00023c;
    private ComboBox f000243;
    private DataGridViewTextBoxColumn f00025c;
    private ToolStripButton f0002e2;
    private DataGridViewTextBoxColumn f0002ea;
    private const int f00030d = 920;
    private Label f000317;
    private TextBox f00043d;
    private Label f000445;
    private BindingSource f000458;
    private int f00050c;
    private GroupBox f000581;
    private Button f000583;
    private Button f000584;
    private Label f000588;
    private enum095 f000598;
    private DateTime f000599;
    private DataRow f00059a;
    private DataTable f00059b;
    private Dictionary<int, string> f00059c;
    private IContainer f00059d;
    private ComboBox f00059e;
    private GroupBox f00059f;
    private ComboBox f0005a0;
    private TextBox f0005a1;
    private TextBox f0005a2;
    private Label f0005a3;
    private NullableDateTimePicker f0005a4;
    private CheckBox f0005a5;
    private GroupBox f0005a6;
    private Button f0005a7;
    private DataGridView f0005a8;
    private CheckBox f0005a9;
    private CheckBox f0005aa;
    private DateTimePicker f0005ab;
    private DateTimePicker f0005ac;
    private NullableDateTimePicker f0005ad;
    private ToolStrip f0005ae;
    private ToolStripButton f0005af;
    private ToolStripButton f0005b0;
    private ToolStripButton f0005b1;
    private TabControl f0005b2;
    private TabPage f0005b3;
    private TabPage f0005b4;
    private TabPage f0005b5;
    private DataSet f0005b6;
    private DataTable f0005b7;
    private DataColumn f0005b8;
    private DataColumn f0005b9;
    private DataColumn f0005ba;
    private DataColumn f0005bb;
    private DataColumn f0005bc;
    private ToolStripButton f0005bd;
    private BindingSource f0005be;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter f0005bf;
    private ToolStrip f0005c0;
    private ToolStripButton f0005c1;
    private DataTable f0005c2;
    private DataColumn f0005c3;
    private DataColumn f0005c4;
    private DataColumn f0005c5;
    private DataColumn f0005c6;
    private ToolStripButton f0005c7;
    private DataGridViewTextBoxColumn f0005c8;
    private DataGridViewImageColumnNotNull f0005c9;
    private DataGridViewTextBoxColumn f0005ca;
    private DataGridViewLinkColumn f0005cb;
    private Button f0005cc;
    private ToolStrip f0005cd;
    private ToolStripButton f0005ce;
    private DataGridViewFilterDateTimePickerColumn f0005cf;
    private DataGridViewFilterDateTimePickerColumn f0005d0;
    private TextBox f0005d1;
    private ComboBox f0005d2;
    private Label f0005d3;
    private NullableDateTimePicker f0005d4;
    private ComboBox f0005d5;
    private Label f0005d6;
    private ComboBox f0005d7;
    private Label f0005d8;

namespace RequestForRepair
{
    /// <summary>
    /// Журнал аварийных заявок и на ремонт оборудования
    /// версия крайняя. Производственная лаборатория
    /// RequestsClient.dll
    /// </summary>/// 
    internal class c000096 : FormBase
    {
        // Methods
        public c000096()
        {
            this.f000072 = -1;
            this.f00004d = -1;
            this.f000598 = enum095.f000598;
            this.f0000dd = new DateTime(0x76c, 1, 1);
            this.f000599 = new DateTime(0x2328, 1, 1);
            this.f00059c = new Dictionary<int, string>();
            this.f00050c = -1;
            this.InitializeComponent();
        }

        public c000096(DataRow A_0)
        {
            this.f000072 = -1;
            this.f00004d = -1;
            this.f000598 = enum095.f000598;
            this.f0000dd = new DateTime(0x76c, 1, 1);
            this.f000599 = new DateTime(0x2328, 1, 1);
            this.f00059c = new Dictionary<int, string>();
            this.f00050c = -1;
            this.InitializeComponent();
            this.f000072 = -1;
            this.f00004d = Convert.ToInt32(A_0["idDivision"]);
            this.f000598 = enum095.f000596;
            this.f00059a = A_0;
        }

        public c000096(int A_0, int A_1, enum095 A_2, [Optional, DefaultParameterValue(false)] bool A_3)
        {
            this.f000072 = -1;
            this.f00004d = -1;
            this.f000598 = enum095.f000598;
            this.f0000dd = new DateTime(0x76c, 1, 1);
            this.f000599 = new DateTime(0x2328, 1, 1);
            this.f00059c = new Dictionary<int, string>();
            this.f00050c = -1;
            this.InitializeComponent();
            this.f000072 = A_0;
            this.f00004d = A_1;
            this.f000598 = A_2;
            this.f000034 = A_3;
        }

        protected override void ApplyConfig(XmlDocument doc)
        {
            XmlNode node = doc.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlAttribute attribute = node.Attributes["X"];
                int? nullable = null;
                int? nullable2 = null;
                if (attribute != null)
                {
                    nullable = new int?(Convert.ToInt32(attribute.Value));
                }
                attribute = node.Attributes["Y"];
                if (attribute != null)
                {
                    nullable2 = new int?(Convert.ToInt32(attribute.Value));
                }
                if (nullable.HasValue && nullable2.HasValue)
                {
                    int? nullable3 = nullable;
                    int num = 0;
                    if ((nullable3.GetValueOrDefault() < num) ? nullable3.HasValue : false)
                    {
                        nullable = 0;
                    }
                    nullable3 = nullable2;
                    num = 0;
                    if ((nullable3.GetValueOrDefault() < num) ? nullable3.HasValue : false)
                    {
                        nullable2 = 0;
                    }
                    base.Location = new Point(nullable.Value, nullable2.Value);
                }
                attribute = node.Attributes["SR"];
                if (attribute != null)
                {
                    this.f00050c = Convert.ToInt32(attribute.Value);
                }
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("X");
            node.Value = base.Location.X.ToString();
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("Y");
            node.Value = base.Location.Y.ToString();
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("SR");
            if (this.f000598 == enum095.f000596)
            {
                node.Value = this.f00059e.SelectedValue.ToString();
            }
            else
            {
                node.Value = this.f00050c.ToString();
            }
            node2.Attributes.Append(node);
            return document1;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.f00059d != null))
            {
                this.f00059d.Dispose();
            }
            base.Dispose(disposing);
        }

        private void m000001(object A_0, EventArgs A_1)
        {
            if (this.f0005bf.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.f0005bf.CurrentRow.Cells[this.f0005c8.Name].Value);
                byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.m00023a(num)["Document"];
                string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.m00023a(num)["FileName"].ToString()));
                FileStream stream1 = File.Create(path);
                stream1.Write(buffer, 0, buffer.Length);
                stream1.Close();
                new Process
                {
                    StartInfo = {
                FileName = path,
                UseShellExecute = true
            }
                }.Start();
            }
        }

        private void m000006(object A_0, EventArgs A_1)
        {
            try
            {
                int num = Convert.ToInt32(this.f0005bf.CurrentRow.Cells[this.f0005c8.Name].Value);
                string path = this.f0005bf.CurrentRow.Cells[this.f0005cb.Name].Value.ToString();
                string extension = Path.GetExtension(path);
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "(*" + extension + ")|*" + extension,
                    FileName = path
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.m00023a(num)["Document"];
                    FileStream stream1 = File.Create(dialog.FileName);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    MessageBox.Show("Файл успешно сохранен", "Сохранение");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void m000007(object A_0, EventArgs A_1)
        {
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                DataRow row = this.dataSetN.tJ_RequestForRepair.NewRow();
                row.ItemArray = this.dataSetN.tJ_RequestForRepair.Rows[0].ItemArray;
                this.dataSetN.tJ_RequestForRepairDoc.Clear();
                this.dataSetN.tJ_RequestForRepairDaily.Clear();
                DataRow row2 = this.dataSetN.tJ_RequestForRepair.NewRow();
                row2["num"] = 0;
                row2["dateCreate"] = DateTime.Now;
                if (row["idWorker"] != DBNull.Value)
                {
                    row2["idWorker"] = row["idWorker"];
                }
                row2["reguestFiled"] = row["reguestFiled"];
                row2["idSR"] = row["idSR"];
                row2["schmObj"] = row["schmObj"];
                row2["Purpose"] = row["Purpose"];
                row2["IsPlanned"] = row["IsPlanned"];
                row2["Crash"] = row["Crash"];
                row2["agreed"] = false;
                row2["iddivision"] = row["iddivision"];
                DataTable table = this.m000591();
                base.SelectSqlData(table, true, " where [Login] = SYSTEM_USER ", false);
                if (table.Rows.Count > 0)
                {
                    row2["idUserCreate"] = table.Rows[0]["iduser"];
                    if (table.Rows[0]["idWorker"] != DBNull.Value)
                    {
                        row2["IdWorker"] = table.Rows[0]["idWorker"];
                    }
                }
                if (row2["idWorker"] == DBNull.Value)
                {
                    row2["idWorker"] = -1;
                }
                this.f000072 = -1;
                this.f000598 = enum095.f000596;
                this.dataSetN.tJ_RequestForRepair.Rows.Add(row2);
                this.dataSetN.tJ_RequestForRepair.Rows.RemoveAt(0);
            }
        }

        private void InitializeComponent()
        {
            this.f00059d = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.dataSetN = new DataSets.DataSetN();
            this.f00010e = new Label();
            this.f000084 = new Label();
            this.f000110 = new Label();
            this.f00059e = new ComboBox();
            this.f00059f = new GroupBox();
            this.f0005a0 = new ComboBox();
            this.f000234 = new Label();
            this.f000018 = new Label();
            this.f000115 = new TextBox();
            this.f0005a1 = new TextBox();
            this.f0005d7 = new ComboBox();
            this.f000317 = new Label();
            this.f0005d8 = new Label();
            this.f0005ae = new ToolStrip();
            this.f0005af = new ToolStripButton();
            this.f0005bd = new ToolStripButton();
            this.f0005b0 = new ToolStripButton();
            this.f0005b1 = new ToolStripButton();
            this.f0005a6 = new GroupBox();
            this.f0005a7 = new Button();
            this.f0005a8 = new DataGridView();
            this.f0001c9 = new DataGridViewTextBoxColumn();
            this.f0002ea = new DataGridViewTextBoxColumn();
            this.f0005cf = new DataGridViewFilterDateTimePickerColumn();
            this.f0005d0 = new DataGridViewFilterDateTimePickerColumn();
            this.f0005a9 = new CheckBox();
            this.f0005aa = new CheckBox();
            this.f0005ab = new DateTimePicker();
            this.f00019d = new Label();
            this.f0005ac = new DateTimePicker();
            this.f00014c = new Label();
            this.f0005d4 = new NullableDateTimePicker();
            this.f0005d3 = new Label();
            this.f000581 = new GroupBox();
            this.f0005d5 = new ComboBox();
            this.f0005d6 = new Label();
            this.f0005d1 = new TextBox();
            this.f00023c = new ComboBox();
            this.f00015a = new Label();
            this.f0005a3 = new Label();
            this.f0005a4 = new NullableDateTimePicker();
            this.f0005a5 = new CheckBox();
            this.f0005ad = new NullableDateTimePicker();
            this.f000445 = new Label();
            this.f00011f = new Label();
            this.f000588 = new Label();
            this.f000029 = new Label();
            this.f0005a2 = new TextBox();
            this.f00011a = new TextBox();
            this.f000583 = new Button();
            this.f000584 = new Button();
            this.f000243 = new ComboBox();
            this.f00002b = new Label();
            this.f00043d = new TextBox();
            this.f0005b2 = new TabControl();
            this.f0005b3 = new TabPage();
            this.f0005d2 = new ComboBox();
            this.f0005cd = new ToolStrip();
            this.f0005ce = new ToolStripButton();
            this.f0005b4 = new TabPage();
            this.f0001b3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.f00025c = new DataGridViewTextBoxColumn();
            this.f0001b6 = new DataGridViewTextBoxColumn();
            this.f0001b7 = new DataGridViewTextBoxColumn();
            this.f0001b8 = new DataGridViewTextBoxColumn();
            this.f00017f = new DataGridViewTextBoxColumn();
            this.f0005be = new BindingSource(this.f00059d);
            this.f0005b6 = new DataSet();
            this.f0005b7 = new DataTable();
            this.f0005b8 = new DataColumn();
            this.f0005b9 = new DataColumn();
            this.f0005ba = new DataColumn();
            this.f0005bb = new DataColumn();
            this.f0005bc = new DataColumn();
            this.f0005c2 = new DataTable();
            this.f0005c3 = new DataColumn();
            this.f0005c4 = new DataColumn();
            this.f0005c5 = new DataColumn();
            this.f0005c6 = new DataColumn();
            this.f0005b5 = new TabPage();
            this.f0005bf = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.f0005c8 = new DataGridViewTextBoxColumn();
            this.f0005c9 = new DataGridViewImageColumnNotNull();
            this.f0005ca = new DataGridViewTextBoxColumn();
            this.f0005cb = new DataGridViewLinkColumn();
            this.f0001c5 = new DataGridViewTextBoxColumn();
            this.f000458 = new BindingSource(this.f00059d);
            this.f0005c0 = new ToolStrip();
            this.f0005c1 = new ToolStripButton();
            this.f0002e2 = new ToolStripButton();
            this.f0005c7 = new ToolStripButton();
            this.f0001c0 = new ToolStripButton();
            this.f0005cc = new Button();
            this.dataSetN.BeginInit();
            this.f00059f.SuspendLayout();
            this.f0005ae.SuspendLayout();
            this.f0005a6.SuspendLayout();
            ((ISupportInitialize)this.f0005a8).BeginInit();
            this.f000581.SuspendLayout();
            this.f0005b2.SuspendLayout();
            this.f0005b3.SuspendLayout();
            this.f0005cd.SuspendLayout();
            this.f0005b4.SuspendLayout();
            ((ISupportInitialize)this.f0001b3).BeginInit();
            ((ISupportInitialize)this.f0005be).BeginInit();
            this.f0005b6.BeginInit();
            this.f0005b7.BeginInit();
            this.f0005c2.BeginInit();
            this.f0005b5.SuspendLayout();
            ((ISupportInitialize)this.f0005bf).BeginInit();
            ((ISupportInitialize)this.f000458).BeginInit();
            this.f0005c0.SuspendLayout();
            base.SuspendLayout();
            this.dataSetN.DataSetName = "DataSetGES";
            this.dataSetN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.f00010e.AutoSize = true;
            this.f00010e.Location = new Point(0x3a, 8);
            this.f00010e.Name = "label1";
            this.f00010e.Size = new Size(0x25, 13);
            this.f00010e.TabIndex = 0;
            this.f00010e.Text = "Автор";
            this.f000084.AutoSize = true;
            this.f000084.Location = new Point(0x13, 0x23);
            this.f000084.Name = "labelRequestFiled";
            this.f000084.Size = new Size(0x4c, 13);
            this.f000084.TabIndex = 4;
            this.f000084.Text = "Заявку подал";
            this.f000110.AutoSize = true;
            this.f000110.Location = new Point(0x12e, 0x23);
            this.f000110.Name = "labelSR";
            this.f000110.Size = new Size(0x26, 13);
            this.f000110.TabIndex = 6;
            this.f000110.Text = "Район";
            this.f00059e.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.f00059e.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.f00059e.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idSR", true));
            this.f00059e.FormattingEnabled = true;
            this.f00059e.Location = new Point(0x166, 0x20);
            this.f00059e.Name = "cmbSR";
            this.f00059e.Size = new Size(0xc6, 0x15);
            this.f00059e.TabIndex = 7;
            this.f00059e.SelectedIndexChanged += new EventHandler(this.m00007f);
            this.f00059f.Controls.Add(this.f0005a0);
            this.f00059f.Controls.Add(this.f000234);
            this.f00059f.Controls.Add(this.f000018);
            this.f00059f.Controls.Add(this.f000115);
            this.f00059f.Controls.Add(this.f0005a1);
            this.f00059f.Controls.Add(this.f0005d7);
            this.f00059f.Controls.Add(this.f000317);
            this.f00059f.Controls.Add(this.f0005d8);
            this.f00059f.Location = new Point(11, 0x35);
            this.f00059f.Name = "groupBox1";
            this.f00059f.Size = new Size(0x221, 0x61);
            this.f00059f.TabIndex = 8;
            this.f00059f.TabStop = false;
            this.f0005a0.FormattingEnabled = true;
            object[] items = new object[] { "Аварийный", "Плановый" };
            this.f0005a0.Items.AddRange(items);
            this.f0005a0.Location = new Point(0x65, 0x44);
            this.f0005a0.Name = "cmbIsPlanned";
            this.f0005a0.Size = new Size(0x79, 0x15);
            this.f0005a0.TabIndex = 5;
            this.f0005a0.SelectedIndexChanged += new EventHandler(this.m0000ba);
            this.f000234.AutoSize = true;
            this.f000234.Location = new Point(6, 0x47);
            this.f000234.Name = "labelIsPlanned";
            this.f000234.Size = new Size(0x59, 13);
            this.f000234.TabIndex = 4;
            this.f000234.Text = "Вид отключения";
            this.f000018.AutoSize = true;
            this.f000018.Location = new Point(6, 0x2d);
            this.f000018.Name = "labelPurpose";
            this.f000018.Size = new Size(0x21, 13);
            this.f000018.TabIndex = 3;
            this.f000018.Text = "Цель";
            this.f000115.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.Purpose", true));
            this.f000115.Location = new Point(0x65, 0x2a);
            this.f000115.Name = "txtPurpose";
            this.f000115.Size = new Size(0x1b6, 20);
            this.f000115.TabIndex = 2;
            this.f000115.TextChanged += new EventHandler(this.m000081);
            this.f0005a1.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.schmObj", true));
            this.f0005a1.Location = new Point(0x65, 0x10);
            this.f0005a1.Name = "txtObject";
            this.f0005a1.Size = new Size(0x1b6, 20);
            this.f0005a1.TabIndex = 1;
            this.f0005a1.TextChanged += new EventHandler(this.m000080);
            this.f0005d7.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.f0005d7.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.f0005d7.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idWorker", true));
            this.f0005d7.FormattingEnabled = true;
            this.f0005d7.Location = new Point(0x13f, 0x44);
            this.f0005d7.Name = "cmbWorker";
            this.f0005d7.Size = new Size(0xc6, 0x15);
            this.f0005d7.TabIndex = 3;
            this.f0005d7.Visible = false;
            this.f0005d7.SelectedIndexChanged += new EventHandler(this.m000077);
            this.f000317.AutoSize = true;
            this.f000317.Location = new Point(6, 0x10);
            this.f000317.Name = "labelObject";
            this.f000317.Size = new Size(0x2d, 13);
            this.f000317.TabIndex = 0;
            this.f000317.Text = "Объект";
            this.f0005d8.AutoSize = true;
            this.f0005d8.Location = new Point(0xfe, 0x47);
            this.f0005d8.Name = "labelWorker";
            this.f0005d8.Size = new Size(0x38, 13);
            this.f0005d8.TabIndex = 15;
            this.f0005d8.Text = "Оператор";
            this.f0005d8.Visible = false;
            this.f0005ae.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.f0005af, this.f0005bd, this.f0005b0, this.f0005b1 };
            this.f0005ae.Items.AddRange(toolStripItems);
            this.f0005ae.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.f0005ae.Location = new Point(3, 3);
            this.f0005ae.Name = "toolStripScheme";
            this.f0005ae.Size = new Size(0x232, 0x19);
            this.f0005ae.TabIndex = 0x2f;
            this.f0005ae.Text = "toolStrip1";
            this.f0005af.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0005af.Image = Resources.ElementAdd;
            this.f0005af.ImageTransparentColor = Color.Magenta;
            this.f0005af.Name = "toolBtnLinkSchmObj";
            this.f0005af.Size = new Size(0x17, 0x16);
            this.f0005af.Text = "Привязать к схеме";
            this.f0005af.Click += new EventHandler(this.m000083);
            this.f0005bd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0005bd.Image = Resources.ElementEdit;
            this.f0005bd.ImageTransparentColor = Color.Magenta;
            this.f0005bd.Name = "toolBtnLinkSchmObjEdit";
            this.f0005bd.Size = new Size(0x17, 0x16);
            this.f0005bd.Text = "Редактировать";
            this.f0005bd.Click += new EventHandler(this.m00005c);
            this.f0005b0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0005b0.Image = Resources.ElementDel;
            this.f0005b0.ImageTransparentColor = Color.Magenta;
            this.f0005b0.Name = "toolBtnDelSchmObj";
            this.f0005b0.Size = new Size(0x17, 0x16);
            this.f0005b0.Text = "Удалить";
            this.f0005b0.Click += new EventHandler(this.m00005e);
            this.f0005b1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0005b1.Enabled = false;
            this.f0005b1.Image = Resources.ElementInformation;
            this.f0005b1.ImageTransparentColor = Color.Magenta;
            this.f0005b1.Name = "toolBtnViewSChmObj";
            this.f0005b1.Size = new Size(0x17, 0x16);
            this.f0005b1.Text = "Показать на схеме";
            this.f0005b1.Click += new EventHandler(this.m00005f);
            this.f0005a6.Controls.Add(this.f0005a7);
            this.f0005a6.Controls.Add(this.f0005a8);
            this.f0005a6.Controls.Add(this.f0005a9);
            this.f0005a6.Controls.Add(this.f0005aa);
            this.f0005a6.Controls.Add(this.f0005ab);
            this.f0005a6.Controls.Add(this.f00019d);
            this.f0005a6.Controls.Add(this.f0005ac);
            this.f0005a6.Controls.Add(this.f00014c);
            this.f0005a6.Location = new Point(11, 0x97);
            this.f0005a6.Name = "groupBoxDaily";
            this.f0005a6.Size = new Size(0x221, 0x8d);
            this.f0005a6.TabIndex = 10;
            this.f0005a6.TabStop = false;
            this.f0005a6.Text = "Даты отключения";
            this.f0005a7.Location = new Point(9, 0x73);
            this.f0005a7.Name = "buttonDaily";
            this.f0005a7.Size = new Size(0x4b, 0x17);
            this.f0005a7.TabIndex = 13;
            this.f0005a7.Text = "Добавить";
            this.f0005a7.UseVisualStyleBackColor = true;
            this.f0005a7.Click += new EventHandler(this.m000076);
            this.f0005a8.AllowUserToAddRows = false;
            this.f0005a8.AllowUserToResizeColumns = false;
            this.f0005a8.AllowUserToResizeRows = false;
            this.f0005a8.AutoGenerateColumns = false;
            this.f0005a8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.f0001c9, this.f0002ea, this.f0005cf, this.f0005d0 };
            this.f0005a8.Columns.AddRange(dataGridViewColumns);
            this.f0005a8.DataMember = "tJ_RequestForRepairDaily";
            this.f0005a8.DataSource = this.dataSetN;
            this.f0005a8.Location = new Point(0xb2, 8);
            this.f0005a8.Name = "dgvDaily";
            this.f0005a8.RowHeadersWidth = 30;
            this.f0005a8.Size = new Size(0x16f, 0x65);
            this.f0005a8.TabIndex = 12;
            this.f0005a8.VirtualMode = true;
            this.f0005a8.CellEndEdit += new DataGridViewCellEventHandler(this.m000096);
            this.f0005a8.CellFormatting += new DataGridViewCellFormattingEventHandler(this.m00007d);
            this.f0005a8.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.m0000be);
            this.f0005a8.RowsAdded += new DataGridViewRowsAddedEventHandler(this.m0000bc);
            this.f0005a8.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.m000592);
            this.f0001c9.DataPropertyName = "id";
            this.f0001c9.HeaderText = "id";
            this.f0001c9.Name = "idDataGridViewTextBoxColumn";
            this.f0001c9.ReadOnly = true;
            this.f0001c9.Visible = false;
            this.f0002ea.DataPropertyName = "idRequest";
            this.f0002ea.HeaderText = "idRequest";
            this.f0002ea.Name = "idRequestDataGridViewTextBoxColumn";
            this.f0002ea.Visible = false;
            this.f0005cf.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.f0005cf.DataPropertyName = "dateBeg";
            style.Format = "dd.MM.yyyy HH:mm";
            this.f0005cf.DefaultCellStyle = style;
            this.f0005cf.FillWeight = 50f;
            this.f0005cf.HeaderText = "Начало";
            this.f0005cf.Name = "dateBegDataGridViewTextBoxColumn";
            this.f0005cf.Resizable = DataGridViewTriState.True;
            this.f0005d0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.f0005d0.DataPropertyName = "dateEnd";
            style2.Format = "dd.MM.yyyy HH:mm";
            this.f0005d0.DefaultCellStyle = style2;
            this.f0005d0.FillWeight = 50f;
            this.f0005d0.HeaderText = "Окончание";
            this.f0005d0.Name = "dateEndDataGridViewTextBoxColumn";
            this.f0005d0.Resizable = DataGridViewTriState.True;
            this.f0005a9.AutoSize = true;
            this.f0005a9.Checked = true;
            this.f0005a9.CheckState = CheckState.Checked;
            this.f0005a9.Enabled = false;
            this.f0005a9.Location = new Point(9, 0x5c);
            this.f0005a9.Name = "checkBoxWeekEnd";
            this.f0005a9.Size = new Size(0x4e, 0x11);
            this.f0005a9.TabIndex = 11;
            this.f0005a9.Text = "Выходные";
            this.f0005a9.UseVisualStyleBackColor = true;
            this.f0005aa.AutoSize = true;
            this.f0005aa.Location = new Point(9, 0x45);
            this.f0005aa.Name = "checkBoxDaily";
            this.f0005aa.Size = new Size(0x53, 0x11);
            this.f0005aa.TabIndex = 10;
            this.f0005aa.Text = "Ежедневно";
            this.f0005aa.UseVisualStyleBackColor = true;
            this.f0005aa.CheckedChanged += new EventHandler(this.m0000bb);
            this.f0005ab.CustomFormat = "dd.MM.yyyy HH:mm";
            this.f0005ab.Format = DateTimePickerFormat.Custom;
            this.f0005ab.Location = new Point(30, 0x2b);
            this.f0005ab.Name = "dateTimePickerEnd";
            this.f0005ab.Size = new Size(0x7c, 20);
            this.f0005ab.TabIndex = 1;
            this.f0005ab.ValueChanged += new EventHandler(this.m000075);
            this.f00019d.AutoSize = true;
            this.f00019d.Location = new Point(6, 50);
            this.f00019d.Name = "label9";
            this.f00019d.Size = new Size(0x13, 13);
            this.f00019d.TabIndex = 9;
            this.f00019d.Text = "по";
            this.f0005ac.CustomFormat = "dd.MM.yyyy HH:mm";
            this.f0005ac.Format = DateTimePickerFormat.Custom;
            this.f0005ac.Location = new Point(30, 0x13);
            this.f0005ac.Name = "dateTimePickerBeg";
            this.f0005ac.Size = new Size(0x7c, 20);
            this.f0005ac.TabIndex = 0;
            this.f0005ac.ValueChanged += new EventHandler(this.m000074);
            this.f00014c.AutoSize = true;
            this.f00014c.Location = new Point(11, 0x16);
            this.f00014c.Name = "label8";
            this.f00014c.Size = new Size(13, 13);
            this.f00014c.TabIndex = 8;
            this.f00014c.Text = "с";
            this.f0005d4.CustomFormat = "dd.MM.yyyy HH:mm";
            this.f0005d4.DataBindings.Add(new Binding("Value", this.dataSetN, "tJ_RequestForRepair.dateFactEnd", true));
            this.f0005d4.Format = DateTimePickerFormat.Custom;
            this.f0005d4.Location = new Point(0x93, 0x2d);
            this.f0005d4.Name = "dtpFactEnd";
            this.f0005d4.Size = new Size(0xe3, 20);
            this.f0005d4.TabIndex = 0x11;
            this.f0005d4.Value = new DateTime(0x7df, 8, 10, 13, 0x39, 6, 0x16);
            this.f0005d3.AutoSize = true;
            this.f0005d3.Location = new Point(10, 0x33);
            this.f0005d3.Name = "label3";
            this.f0005d3.Size = new Size(0x83, 13);
            this.f0005d3.TabIndex = 14;
            this.f0005d3.Text = "Время закрытия заявки";
            this.f000581.Controls.Add(this.f0005d4);
            this.f000581.Controls.Add(this.f0005d3);
            this.f000581.Controls.Add(this.f0005d5);
            this.f000581.Controls.Add(this.f0005d6);
            this.f000581.Controls.Add(this.f0005d1);
            this.f000581.Controls.Add(this.f00023c);
            this.f000581.Controls.Add(this.f00015a);
            this.f000581.Controls.Add(this.f0005a3);
            this.f000581.Controls.Add(this.f0005a4);
            this.f000581.Controls.Add(this.f0005a5);
            this.f000581.Controls.Add(this.f0005ad);
            this.f000581.Controls.Add(this.f000445);
            this.f000581.Controls.Add(this.f00011f);
            this.f000581.Controls.Add(this.f000588);
            this.f000581.Controls.Add(this.f000029);
            this.f000581.Controls.Add(this.f0005a2);
            this.f000581.Controls.Add(this.f00011a);
            this.f000581.Location = new Point(11, 0x126);
            this.f000581.Name = "groupBoxODS";
            this.f000581.Size = new Size(0x221, 0x100);
            this.f000581.TabIndex = 9;
            this.f000581.TabStop = false;
            this.f000581.VisibleChanged += new EventHandler(this.m0000b9);
            this.f0005d5.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.status", true));
            this.f0005d5.FormattingEnabled = true;
            this.f0005d5.Location = new Point(0xa5, 0xe0);
            this.f0005d5.Name = "cmbStatus";
            this.f0005d5.Size = new Size(0x176, 0x15);
            this.f0005d5.TabIndex = 15;
            this.f0005d6.AutoSize = true;
            this.f0005d6.Location = new Point(0x4f, 0xe3);
            this.f0005d6.Name = "labelStatus";
            this.f0005d6.Size = new Size(80, 13);
            this.f0005d6.TabIndex = 14;
            this.f0005d6.Text = "Статус заявки";
            this.f0005d1.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.Address", true));
            this.f0005d1.Location = new Point(0x6a, 0x7e);
            this.f0005d1.Multiline = true;
            this.f0005d1.Name = "txtAdress";
            this.f0005d1.Size = new Size(0x1b1, 0x40);
            this.f0005d1.TabIndex = 11;
            this.f00023c.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.f00023c.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.f00023c.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.WorkerAgreed", true));
            this.f00023c.FormattingEnabled = true;
            this.f00023c.Location = new Point(400, 0xc4);
            this.f00023c.Name = "cmbDispatcher";
            this.f00023c.Size = new Size(0x8b, 0x15);
            this.f00023c.TabIndex = 10;
            this.f00015a.AutoSize = true;
            this.f00015a.Location = new Point(0x13c, 0xc6);
            this.f00015a.Name = "label14";
            this.f00015a.Size = new Size(0x4e, 13);
            this.f00015a.TabIndex = 9;
            this.f00015a.Text = "Руководитель";
            this.f0005a3.AutoSize = true;
            this.f0005a3.Location = new Point(0x6c, 0xc6);
            this.f0005a3.Name = "label13";
            this.f0005a3.Size = new Size(0x21, 13);
            this.f0005a3.TabIndex = 8;
            this.f0005a3.Text = "Дата";
            this.f0005a4.DataBindings.Add(new Binding("Value", this.dataSetN, "tJ_RequestForRepair.DateAgreed", true));
            this.f0005a4.Location = new Point(0x93, 0xc4);
            this.f0005a4.Name = "dateTimePickerDateAgreed";
            this.f0005a4.Size = new Size(0xa3, 20);
            this.f0005a4.TabIndex = 7;
            this.f0005a4.Value = new DateTime(0x7dc, 9, 0x1a, 9, 0x3a, 0x1c, 0x3a4);
            this.f0005a5.AutoSize = true;
            this.f0005a5.DataBindings.Add(new Binding("Checked", this.dataSetN, "tJ_RequestForRepair.Agreed", true));
            this.f0005a5.Location = new Point(14, 0xc7);
            this.f0005a5.Name = "checkBoxAgreed";
            this.f0005a5.Size = new Size(0x53, 0x11);
            this.f0005a5.TabIndex = 6;
            this.f0005a5.Text = "Разрешено";
            this.f0005a5.UseVisualStyleBackColor = true;
            this.f0005a5.CheckedChanged += new EventHandler(this.m000082);
            this.f0005ad.CustomFormat = "dd.MM.yyyy HH:mm";
            this.f0005ad.DataBindings.Add(new Binding("Value", this.dataSetN, "tJ_RequestForRepair.dateOpenRequest", true));
            this.f0005ad.Format = DateTimePickerFormat.Custom;
            this.f0005ad.Location = new Point(0x93, 0x13);
            this.f0005ad.Name = "dtpDateCreate";
            this.f0005ad.Size = new Size(0xe3, 20);
            this.f0005ad.TabIndex = 0x11;
            this.f0005ad.Value = new DateTime(0x7dc, 10, 0x12, 8, 0x27, 0x29, 0xb2);
            this.f000445.AutoSize = true;
            this.f000445.Location = new Point(11, 0x15);
            this.f000445.Name = "label2";
            this.f000445.Size = new Size(130, 13);
            this.f000445.TabIndex = 0x10;
            this.f000445.Text = "Время открытия заявки";
            this.f00011f.AutoSize = true;
            this.f00011f.Location = new Point(11, 0x81);
            this.f00011f.Name = "label12";
            this.f00011f.Size = new Size(0x2c, 13);
            this.f00011f.TabIndex = 5;
            this.f00011f.Text = "Адреса";
            this.f000588.AutoSize = true;
            this.f000588.Location = new Point(11, 0x67);
            this.f000588.Name = "label11";
            this.f000588.Size = new Size(0x4d, 13);
            this.f000588.TabIndex = 4;
            this.f000588.Text = "Комментарий";
            this.f000029.AutoSize = true;
            this.f000029.Location = new Point(11, 0x4d);
            this.f000029.Name = "label10";
            this.f000029.Size = new Size(0x51, 13);
            this.f000029.TabIndex = 3;
            this.f000029.Text = "Согласовать с";
            this.f0005a2.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.Comment", true));
            this.f0005a2.Location = new Point(0x6a, 100);
            this.f0005a2.Name = "txtComment";
            this.f0005a2.Size = new Size(0x1b1, 20);
            this.f0005a2.TabIndex = 1;
            this.f00011a.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.AgreeWith", true));
            this.f00011a.Location = new Point(0x6a, 0x4a);
            this.f00011a.Name = "txtAgreeWith";
            this.f00011a.Size = new Size(0x1b1, 20);
            this.f00011a.TabIndex = 0;
            this.f000583.DialogResult = DialogResult.OK;
            this.f000583.Location = new Point(15, 0x24b);
            this.f000583.Name = "buttonOK";
            this.f000583.Size = new Size(0x4b, 0x17);
            this.f000583.TabIndex = 10;
            this.f000583.Text = "ОК";
            this.f000583.UseVisualStyleBackColor = true;
            this.f000583.Click += new EventHandler(this.m000060);
            this.f000584.DialogResult = DialogResult.Cancel;
            this.f000584.Location = new Point(0x1e5, 0x24b);
            this.f000584.Name = "buttonCancel";
            this.f000584.Size = new Size(0x4b, 0x17);
            this.f000584.TabIndex = 11;
            this.f000584.Text = "Отмена";
            this.f000584.UseVisualStyleBackColor = true;
            this.f000584.Click += new EventHandler(this.m000061);
            this.f000243.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idUserCreate", true));
            this.f000243.Enabled = false;
            this.f000243.FormattingEnabled = true;
            this.f000243.Location = new Point(0x65, 5);
            this.f000243.Name = "cmbUserCreate";
            this.f000243.Size = new Size(0xb5, 0x15);
            this.f000243.TabIndex = 12;
            this.f00002b.AutoSize = true;
            this.f00002b.Location = new Point(0x12e, 8);
            this.f00002b.Name = "label15";
            this.f00002b.Size = new Size(0x29, 13);
            this.f00002b.TabIndex = 13;
            this.f00002b.Text = "Номер";
            this.f00043d.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.num", true));
            this.f00043d.Location = new Point(0x166, 5);
            this.f00043d.Name = "txtNum";
            this.f00043d.ReadOnly = true;
            this.f00043d.Size = new Size(0xc6, 20);
            this.f00043d.TabIndex = 14;
            this.f0005b2.Controls.Add(this.f0005b3);
            this.f0005b2.Controls.Add(this.f0005b4);
            this.f0005b2.Controls.Add(this.f0005b5);
            this.f0005b2.Location = new Point(0, 0);
            this.f0005b2.Name = "tabControl";
            this.f0005b2.SelectedIndex = 0;
            this.f0005b2.Size = new Size(0x240, 0x245);
            this.f0005b2.TabIndex = 0x31;
            this.f0005b3.Controls.Add(this.f0005d2);
            this.f0005b3.Controls.Add(this.f0005cd);
            this.f0005b3.Controls.Add(this.f00059e);
            this.f0005b3.Controls.Add(this.f00010e);
            this.f0005b3.Controls.Add(this.f0005a6);
            this.f0005b3.Controls.Add(this.f000084);
            this.f0005b3.Controls.Add(this.f000581);
            this.f0005b3.Controls.Add(this.f00059f);
            this.f0005b3.Controls.Add(this.f000110);
            this.f0005b3.Controls.Add(this.f000243);
            this.f0005b3.Controls.Add(this.f00043d);
            this.f0005b3.Controls.Add(this.f00002b);
            this.f0005b3.Location = new Point(4, 0x16);
            this.f0005b3.Name = "tabPageGeneral";
            this.f0005b3.Padding = new Padding(3);
            this.f0005b3.Size = new Size(0x238, 0x22b);
            this.f0005b3.TabIndex = 0;
            this.f0005b3.Text = "Общие";
            this.f0005b3.UseVisualStyleBackColor = true;
            this.f0005d2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.f0005d2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.f0005d2.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.reguestFiled", true));
            this.f0005d2.FormattingEnabled = true;
            this.f0005d2.Location = new Point(0x65, 0x20);
            this.f0005d2.Name = "txtRequestFiled";
            this.f0005d2.Size = new Size(0xb5, 0x15);
            this.f0005d2.TabIndex = 0x13;
            this.f0005cd.Dock = DockStyle.None;
            this.f0005cd.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.f0005ce };
            this.f0005cd.Items.AddRange(itemArray2);
            this.f0005cd.Location = new Point(0, 0);
            this.f0005cd.Name = "toolStripMain";
            this.f0005cd.Size = new Size(0x1a, 0x19);
            this.f0005cd.TabIndex = 0x12;
            this.f0005cd.Text = "toolStrip1";
            this.f0005ce.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0005ce.Image = Resources.CopyBuffer;
            this.f0005ce.ImageTransparentColor = Color.Magenta;
            this.f0005ce.Name = "toolBtnCopy";
            this.f0005ce.Size = new Size(0x17, 0x16);
            this.f0005ce.Text = "Копировать";
            this.f0005ce.Click += new EventHandler(this.m000007);
            this.f0005b4.Controls.Add(this.f0001b3);
            this.f0005b4.Controls.Add(this.f0005ae);
            this.f0005b4.Location = new Point(4, 0x16);
            this.f0005b4.Name = "tabPageSwitching";
            this.f0005b4.Padding = new Padding(3);
            this.f0005b4.Size = new Size(0x238, 0x22b);
            this.f0005b4.TabIndex = 1;
            this.f0005b4.Text = "Оперативные переключения";
            this.f0005b4.UseVisualStyleBackColor = true;
            this.f0001b3.AllowUserToAddRows = false;
            this.f0001b3.AllowUserToDeleteRows = false;
            this.f0001b3.AllowUserToOrderColumns = true;
            this.f0001b3.AllowUserToVisibleColumns = false;
            this.f0001b3.AutoGenerateColumns = false;
            this.f0001b3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.f0001b3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.f00025c, this.f0001b6, this.f0001b7, this.f0001b8, this.f00017f };
            this.f0001b3.Columns.AddRange(columnArray2);
            this.f0001b3.DataSource = this.f0005be;
            this.f0001b3.Dock = DockStyle.Fill;
            this.f0001b3.Location = new Point(3, 0x1c);
            this.f0001b3.Name = "dgvLinkObjects";
            this.f0001b3.ReadOnly = true;
            this.f0001b3.RowHeadersWidth = 0x15;
            this.f0001b3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.f0001b3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.f0001b3.Size = new Size(0x232, 0x20c);
            this.f0001b3.TabIndex = 0x31;
            this.f0001b3.CellDoubleClick += new DataGridViewCellEventHandler(this.m000085);
            this.f00025c.DataPropertyName = "Objects";
            style3.WrapMode = DataGridViewTriState.True;
            this.f00025c.DefaultCellStyle = style3;
            this.f00025c.HeaderText = "Объекты";
            this.f00025c.Name = "objectsDataGridViewTextBoxColumn1";
            this.f00025c.ReadOnly = true;
            this.f00025c.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.f00025c.Width = 250;
            this.f0001b6.DataPropertyName = "DateBeg";
            this.f0001b6.HeaderText = "Начало";
            this.f0001b6.Name = "dateBegDataGridViewTextBoxColumn2";
            this.f0001b6.ReadOnly = true;
            this.f0001b6.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.f0001b6.Width = 90;
            this.f0001b7.DataPropertyName = "DateEnd";
            this.f0001b7.HeaderText = "Окончание";
            this.f0001b7.Name = "dateEndDataGridViewTextBoxColumn2";
            this.f0001b7.ReadOnly = true;
            this.f0001b7.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.f0001b7.Width = 90;
            this.f0001b8.DataPropertyName = "Duration";
            this.f0001b8.HeaderText = "Длительность";
            this.f0001b8.Name = "durationDataGridViewTextBoxColumn1";
            this.f0001b8.ReadOnly = true;
            this.f0001b8.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.f0001b8.Width = 90;
            this.f00017f.DataPropertyName = "Num";
            this.f00017f.HeaderText = "Num";
            this.f00017f.Name = "numDataGridViewTextBoxColumn1";
            this.f00017f.ReadOnly = true;
            this.f00017f.Visible = false;
            this.f0005be.DataMember = "tableLinkObjects";
            this.f0005be.DataSource = this.f0005b6;
            this.f0005be.Sort = "Num";
            this.f0005b6.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.f0005b7, this.f0005c2 };
            this.f0005b6.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.f0005b8, this.f0005b9, this.f0005ba, this.f0005bb, this.f0005bc };
            this.f0005b7.Columns.AddRange(columns);
            this.f0005b7.TableName = "tableLinkObjects";
            this.f0005b8.ColumnName = "Objects";
            this.f0005b9.ColumnName = "DateBeg";
            this.f0005b9.DataType = typeof(DateTime);
            this.f0005ba.ColumnName = "DateEnd";
            this.f0005ba.DataType = typeof(DateTime);
            this.f0005bb.ColumnName = "Duration";
            this.f0005bc.ColumnName = "Num";
            this.f0005bc.DataType = typeof(short);
            DataColumn[] columnArray4 = new DataColumn[] { this.f0005c3, this.f0005c4, this.f0005c5, this.f0005c6 };
            this.f0005c2.Columns.AddRange(columnArray4);
            Constraint[] constraints = new Constraint[1];
            string[] columnNames = new string[] { "id" };
            constraints[0] = new UniqueConstraint("Constraint1", columnNames, true);
            this.f0005c2.Constraints.AddRange(constraints);
            this.f0005c2.PrimaryKey = new DataColumn[] { this.f0005c3 };
            this.f0005c2.TableName = "tJ_RequestForReapirDoc";
            this.f0005c3.AllowDBNull = false;
            this.f0005c3.AutoIncrement = true;
            this.f0005c3.ColumnName = "id";
            this.f0005c3.DataType = typeof(int);
            this.f0005c4.AllowDBNull = false;
            this.f0005c4.ColumnName = "idRequest";
            this.f0005c4.DataType = typeof(int);
            this.f0005c5.ColumnName = "FileName";
            this.f0005c6.ColumnName = "Comment";
            this.f0005b5.Controls.Add(this.f0005bf);
            this.f0005b5.Controls.Add(this.f0005c0);
            this.f0005b5.Location = new Point(4, 0x16);
            this.f0005b5.Name = "tabPageDocuments";
            this.f0005b5.Padding = new Padding(3);
            this.f0005b5.Size = new Size(0x238, 0x22b);
            this.f0005b5.TabIndex = 2;
            this.f0005b5.Text = "Документы";
            this.f0005b5.UseVisualStyleBackColor = true;
            this.f0005bf.AllowUserToAddRows = false;
            this.f0005bf.AllowUserToDeleteRows = false;
            this.f0005bf.AutoGenerateColumns = false;
            this.f0005bf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray6 = new DataGridViewColumn[] { this.f0005c8, this.f0005c9, this.f0005ca, this.f0005cb, this.f0001c5 };
            this.f0005bf.Columns.AddRange(columnArray6);
            this.f0005bf.DataSource = this.f000458;
            this.f0005bf.Dock = DockStyle.Fill;
            this.f0005bf.Location = new Point(3, 0x1c);
            this.f0005bf.Name = "dgvDocs";
            this.f0005bf.RowHeadersWidth = 0x15;
            this.f0005bf.Size = new Size(0x232, 0x20c);
            this.f0005bf.TabIndex = 1;
            this.f0005bf.VirtualMode = true;
            this.f0005bf.CellContentClick += new DataGridViewCellEventHandler(this.m000086);
            this.f0005bf.CellValueNeeded += new DataGridViewCellValueEventHandler(this.m000089);
            this.f0005c8.DataPropertyName = "id";
            this.f0005c8.HeaderText = "id";
            this.f0005c8.Name = "idDataGridViewTextBoxColumnDoc";
            this.f0005c8.ReadOnly = true;
            this.f0005c8.Visible = false;
            style4.NullValue = null;
            this.f0005c9.DefaultCellStyle = style4;
            this.f0005c9.HeaderText = "";
            this.f0005c9.Name = "ColumnImage";
            this.f0005c9.ReadOnly = true;
            this.f0005c9.Resizable = DataGridViewTriState.False;
            this.f0005c9.Width = 30;
            this.f0005ca.DataPropertyName = "idRequest";
            this.f0005ca.HeaderText = "idRequest";
            this.f0005ca.Name = "idRequestDataGridViewTextBoxColumn1";
            this.f0005ca.Visible = false;
            this.f0005cb.DataPropertyName = "FileName";
            this.f0005cb.HeaderText = "Файл";
            this.f0005cb.Name = "fileNameDataGridViewTextBoxColumn";
            this.f0005cb.ReadOnly = true;
            this.f0005cb.Resizable = DataGridViewTriState.True;
            this.f0005cb.SortMode = DataGridViewColumnSortMode.Automatic;
            this.f0005cb.Width = 200;
            this.f0001c5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.f0001c5.DataPropertyName = "Comment";
            this.f0001c5.HeaderText = "Комментарий";
            this.f0001c5.Name = "commentDataGridViewTextBoxColumn";
            this.f000458.DataMember = "tJ_RequestForRepairDoc";
            this.f000458.DataSource = this.dataSetN;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.f0005c1, this.f0002e2, this.f0005c7, this.f0001c0 };
            this.f0005c0.Items.AddRange(itemArray3);
            this.f0005c0.Location = new Point(3, 3);
            this.f0005c0.Name = "toolStripDocuments";
            this.f0005c0.Size = new Size(0x232, 0x19);
            this.f0005c0.TabIndex = 0;
            this.f0005c0.Text = "toolStrip1";
            this.f0005c1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0005c1.Image = Resources.ElementAdd;
            this.f0005c1.ImageTransparentColor = Color.Magenta;
            this.f0005c1.Name = "toolBtnAddDoc";
            this.f0005c1.Size = new Size(0x17, 0x16);
            this.f0005c1.Text = "Добавить документ";
            this.f0005c1.Click += new EventHandler(this.m000062);
            this.f0002e2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0002e2.Image = Resources.ElementDel;
            this.f0002e2.ImageTransparentColor = Color.Magenta;
            this.f0002e2.Name = "toolBtnDelDoc";
            this.f0002e2.Size = new Size(0x17, 0x16);
            this.f0002e2.Text = "Удалить документ";
            this.f0002e2.Click += new EventHandler(this.m000063);
            this.f0005c7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0005c7.Image = Resources.ElementInformation;
            this.f0005c7.ImageTransparentColor = Color.Magenta;
            this.f0005c7.Name = "toolBtnViewDoc";
            this.f0005c7.Size = new Size(0x17, 0x16);
            this.f0005c7.Text = "Открыть документ";
            this.f0005c7.Click += new EventHandler(this.m000001);
            this.f0001c0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.f0001c0.Image = Resources.ElementGo;
            this.f0001c0.ImageTransparentColor = Color.Magenta;
            this.f0001c0.Name = "toolBtnSaveDoc";
            this.f0001c0.Size = new Size(0x17, 0x16);
            this.f0001c0.Text = "Сохранить документ";
            this.f0001c0.Click += new EventHandler(this.m000006);
            this.f0005cc.Location = new Point(240, 0x24b);
            this.f0005cc.Name = "buttonCopy";
            this.f0005cc.Size = new Size(0x4b, 0x17);
            this.f0005cc.TabIndex = 50;
            this.f0005cc.Text = "Копировать";
            this.f0005cc.UseVisualStyleBackColor = true;
            this.f0005cc.Visible = false;
            this.f0005cc.Click += new EventHandler(this.m000007);
            base.AcceptButton = this.f000583;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.f000584;
            base.ClientSize = new Size(0x23c, 0x26b);
            base.Controls.Add(this.f0005cc);
            base.Controls.Add(this.f0005b2);
            base.Controls.Add(this.f000584);
            base.Controls.Add(this.f000583);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.Name = "FormJournalRequestForRepairAddEdit";
            this.Text = "FormJournalRequestForRepairAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.m00005b);
            base.FormClosed += new FormClosedEventHandler(this.m000070);
            base.Load += new EventHandler(this.m0000b8);
            this.dataSetN.EndInit();
            this.f00059f.ResumeLayout(false);
            this.f00059f.PerformLayout();
            this.f0005ae.ResumeLayout(false);
            this.f0005ae.PerformLayout();
            this.f0005a6.ResumeLayout(false);
            this.f0005a6.PerformLayout();
            ((ISupportInitialize)this.f0005a8).EndInit();
            this.f000581.ResumeLayout(false);
            this.f000581.PerformLayout();
            this.f0005b2.ResumeLayout(false);
            this.f0005b3.ResumeLayout(false);
            this.f0005b3.PerformLayout();
            this.f0005cd.ResumeLayout(false);
            this.f0005cd.PerformLayout();
            this.f0005b4.ResumeLayout(false);
            this.f0005b4.PerformLayout();
            ((ISupportInitialize)this.f0001b3).EndInit();
            ((ISupportInitialize)this.f0005be).EndInit();
            this.f0005b6.EndInit();
            this.f0005b7.EndInit();
            this.f0005c2.EndInit();
            this.f0005b5.ResumeLayout(false);
            this.f0005b5.PerformLayout();
            ((ISupportInitialize)this.f0005bf).EndInit();
            ((ISupportInitialize)this.f000458).EndInit();
            this.f0005c0.ResumeLayout(false);
            this.f0005c0.PerformLayout();
            base.ResumeLayout(false);
        }
        /// <summary>
        /// UpdateSchmObjList
        /// </summary>
        private void m00000b()
        {
            foreach (DataRow row in this.dataSetN.tL_RequestForRepairSchmObjList)
            {
                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                {
                    row["idRequest"] = this.f000072;
                    row.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            base.UpdateSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            base.DeleteSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }
        /// <summary>
        ///  SetVisibleControl()
        /// </summary>
        private void m000034()
        {
            DataTable table = new DataTable("tUser");
            table.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(table, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;Dispatchers;' and tuser.login = SYSTEM_USER", false);
            if (table.Rows.Count == 0)
            {
                this.f000581.Enabled = false;
                this.f0005ad.Enabled = false;
                this.f0005d4.Enabled = false;
            }
            else
            {
                this.f000581.Enabled = true;
                this.f0005ad.Enabled = true;
                this.f0005d4.Enabled = true;
            }
        }
        /// <summary>
        /// CreateCaptionNames
        /// </summary>
        private void m000035()
        {
            if (this.f00004d > 0)
            {
                base.SelectSqlData(this.dataSetN, this.dataSetN.tR_Classifier, true, "where id = " + this.f00004d.ToString());
            }
            string str = "";
            if (this.dataSetN.tR_Classifier.Rows.Count > 0)
            {
                str = " " + this.dataSetN.tR_Classifier.Rows[0]["SocrName"].ToString();
            }
            switch (this.f000598)
            {
                case enum095.f000596:
                    if (!this.f000034)
                    {
                        this.Text = "Создать новую заявку" + str;
                        return;
                    }
                    this.Text = "Создать новую аварийную заявку" + str;
                    return;

                case enum095.f000597:
                    if (!this.f000034)
                    {
                        this.Text = "Редактирование заявки" + str;
                        return;
                    }
                    this.Text = "Редактирование аварийной заявки" + str;
                    return;

                case enum095.f000598:
                    if (!this.f000034)
                    {
                        this.Text = "Просмотр заявки" + str;
                        return;
                    }
                    this.Text = "Просмотр аварийной заявки" + str;
                    return;
            }
        }
        /// <summary>
        /// FillComboBoxs
        /// </summary>
        private void m00003a()
        {
            DataTable table = this.m000591();
            base.SelectSqlData(table, true, " order by name ", false);
            this.f000243.DataSource = table;
            this.f000243.DisplayMember = "NAME";
            this.f000243.ValueMember = "IDUSER";
            DataTable table2 = this.m000590();
            base.SelectSqlData(table2, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
            this.f0005d7.DataSource = table2;
            this.f0005d7.DisplayMember = "FIO";
            this.f0005d7.ValueMember = "ID";
            this.f0005d2.DataSource = table2;
            this.f0005d2.DisplayMember = "FIO";
            this.f0005d2.ValueMember = "ID";
            DataTable table3 = this.m000590();
            base.SelectSqlData(table3, true, " where ParentKey in (';GroupWorker;ReconcileRequestRepair;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
            this.f00023c.DataSource = table3;
            this.f00023c.DisplayMember = "FIO";
            this.f00023c.ValueMember = "ID";
            base.SelectSqlData(this.dataSetN, this.dataSetN.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
            this.f00059e.DataSource = this.dataSetN.tR_Classifier;
            this.f00059e.DisplayMember = "name";
            this.f00059e.ValueMember = "ID";
        }
        /// <summary>
        /// FillComboBoxStatus
        /// </summary>
        private void m00003b()
        {
            this.f00059b = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.f00059b, true, "where type = 5 order by name", false);
            DataTable table = new DataTable("tR_RequestForRepairClient");
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("value", typeof(int));
            this.f0005d5.DataSource = table;
            this.f0005d5.DisplayMember = "Name";
            this.f0005d5.ValueMember = "Value";
            if (table.Rows.Count == 0)
            {
                foreach (DataRow row in this.f00059b.Rows)
                {
                    object[] values = new object[] { row["name"], row["Value"] };
                    table.Rows.Add(values);
                }
            }
        }
        /// <summary>
        /// LoadTableLinkObjects
        /// </summary>
        private void m000057()
        {
            this.f0005b6.Tables[this.f0005b7.TableName].Clear();
            if (this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Count > 0)
            {
                DataRow row3;
                DataView defaultView = this.dataSetN.tL_RequestForRepairSchmObjList.DefaultView;
                defaultView.Sort = "Num";
                int num = 0;
                List<string> list = new List<string>();
                DateTime now = DateTime.Now;
                DateTime time2 = DateTime.Now;
                string str = "";
                foreach (DataRow row in defaultView.ToTable().Rows)
                {
                    if (num == Convert.ToInt16(row["num"]))
                    {
                        string[] param = new string[] { row["idSchmObj"].ToString() };
                        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", param).ToString());
                    }
                    else
                    {
                        if (list.Count > 0)
                        {
                            list.Sort();
                            DataRow row2 = this.f0005b6.Tables[this.f0005b7.TableName].NewRow();
                            row2["Objects"] = "";
                            foreach (string str2 in list)
                            {
                                row3 = row2;
                                row3["Objects"] = row3["Objects"] + str2 + "\n";
                            }
                            row2["Objects"] = ((string)row2["Objects"]).Remove(row2["Objects"].ToString().Length - 1);
                            row2["DateBeg"] = now;
                            row2["DateEnd"] = time2;
                            row2["Duration"] = str;
                            row2["Num"] = num;
                            this.f0005b6.Tables[this.f0005b7.TableName].Rows.Add(row2);
                        }
                        list = new List<string>();
                        string[] textArray2 = new string[] { row["idSchmObj"].ToString() };
                        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray2).ToString());
                        now = Convert.ToDateTime(row["DateBeg"]);
                        time2 = Convert.ToDateTime(row["DateEnd"]);
                        str = row["Duration"].ToString();
                        num = Convert.ToInt16(row["Num"]);
                    }
                }
                if (list.Count > 0)
                {
                    list.Sort();
                    DataRow row4 = this.f0005b6.Tables[this.f0005b7.TableName].NewRow();
                    row4["Objects"] = "";
                    foreach (string str3 in list)
                    {
                        row3 = row4;
                        row3["Objects"] = row3["Objects"] + str3 + "\n";
                    }
                    row4["Objects"] = ((string)row4["Objects"]).Remove(row4["Objects"].ToString().Length - 1);
                    row4["DateBeg"] = now;
                    row4["DateEnd"] = time2;
                    row4["Duration"] = str;
                    row4["Num"] = num;
                    this.f0005b6.Tables[this.f0005b7.TableName].Rows.Add(row4);
                }
                if (this.f0005b6.Tables[this.f0005b7.TableName].Rows.Count > 0)
                {
                    this.f0005b1.Enabled = true;
                }
                else
                {
                    this.f0005b1.Enabled = false;
                }
            }
        }
        /// <summary>
        /// LoadTableSchmObjects
        /// </summary>
        private void m000058()
        {
            base.SelectSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.f000072.ToString());
            this.m000057();
        }
        /// <summary>
        /// UpdateRepairDoc
        /// </summary>
        private void m000059()
        {
            foreach (DataRow row in this.dataSetN.tJ_RequestForRepairDoc)
            {
                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                {
                    row["idRequest"] = this.f000072;
                    row.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void m00005b(object A_0, FormClosingEventArgs A_1)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if ((this.f000598 != enum095.f000598) && !this.m0000c0())
                {
                    MessageBox.Show("Не введены обязательные поля", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    A_1.Cancel = true;
                }
                else
                {
                    enum095 enum2 = this.f000598;
                    if (enum2 != enum095.f000596)
                    {
                        if (enum2 != enum095.f000597)
                        {
                            return;
                        }
                    }
                    else
                    {
                        this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                        this.f000072 = base.InsertSqlDataOneRow(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                        foreach (DataRow row in this.dataSetN.tJ_RequestForRepairDaily)
                        {
                            if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                            {
                                row["idRequest"] = this.f000072;
                                row.EndEdit();
                            }
                        }
                        base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                        base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                        base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                        this.m00000b();
                        this.m000059();
                        return;
                    }
                    this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                    foreach (DataRow row2 in this.dataSetN.tJ_RequestForRepairDaily)
                    {
                        if ((row2.RowState != DataRowState.Detached) && (row2.RowState != DataRowState.Deleted))
                        {
                            row2["idRequest"] = this.f000072;
                            row2.EndEdit();
                        }
                    }
                    base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                    base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                    base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                    this.m00000b();
                    this.m000059();
                }
            }
        }

        private void m00005c(object A_0, EventArgs A_1)
        {
            if (this.f0001b3.CurrentRow != null)
            {
                DataRow[] rowArray = this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + this.f0001b3.CurrentRow.Cells[this.f00017f.Name].Value.ToString());
                this.f00059c.Clear();
                if (rowArray.Length != 0)
                {
                    FormLinkRequestAndSchm schm = new FormLinkRequestAndSchm
                    {
                        SqlSettings = this.SqlSettings,
                        DateBeg = Convert.ToDateTime(rowArray[0]["dateBeg"]),
                        DateEnd = Convert.ToDateTime(rowArray[0]["dateEnd"]),
                        Duration = rowArray[0]["Duration"].ToString(),
                        Num = Convert.ToInt16(rowArray[0]["Num"])
                    };
                    foreach (DataRow row in rowArray)
                    {
                        string[] param = new string[] { row["idSchmObj"].ToString() };
                        this.f00059c.Add(Convert.ToInt32(row["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", param).ToString());
                    }
                    schm.LinkObjects = this.f00059c;
                    if (schm.ShowDialog() == DialogResult.OK)
                    {
                        this.f00059c = schm.LinkObjects;
                        foreach (DataRow row2 in rowArray)
                        {
                            if (this.f00059c.ContainsKey(Convert.ToInt32(row2["idSchmObj"])))
                            {
                                row2["DAteBeg"] = schm.DateBeg;
                                row2["DAteEnd"] = schm.DateEnd;
                                row2["duration"] = schm.Duration;
                                this.f00059c.Remove(Convert.ToInt32(row2["idSchmObj"]));
                            }
                            else
                            {
                                row2.Delete();
                            }
                        }
                        foreach (int num2 in this.f00059c.Keys)
                        {
                            DataRow row3 = this.dataSetN.tL_RequestForRepairSchmObjList.NewRow();
                            row3["idRequest"] = this.f000072;
                            row3["idSchmObj"] = num2;
                            row3["DAteBeg"] = schm.DateBeg;
                            row3["DAteEnd"] = schm.DateEnd;
                            row3["duration"] = schm.Duration;
                            row3["num"] = schm.Num;
                            this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Add(row3);
                        }
                        this.m000057();
                    }
                }
            }
        }

        private void m00005e(object A_0, EventArgs A_1)
        {
            foreach (DataGridViewRow row in this.f0001b3.SelectedRows)
            {
                DataRow[] rowArray = this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + row.Cells[this.f00017f.Name].Value.ToString());
                for (int i = 0; i < rowArray.Length; i++)
                {
                    rowArray[i].Delete();
                }
            }
            this.m000057();
        }

        private void m00005f(object A_0, EventArgs A_1)
        {
            this.f00059c.Clear();
            foreach (DataGridViewRow row in this.f0001b3.SelectedRows)
            {
                foreach (DataRow row2 in this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + row.Cells[this.f00017f.Name].Value.ToString()))
                {
                    if (!this.f00059c.ContainsKey(Convert.ToInt32(row2["idSchmObj"])))
                    {
                        this.f00059c.Add(Convert.ToInt32(row2["idSchmObj"]), "");
                    }
                }
            }
            GoToSchemaEventArgs e = new GoToSchemaEventArgs(this.f00059c.Keys.ToList<int>());
            this.OnGoToSchema(e);
        }

        private void m000060(object A_0, EventArgs A_1)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void m000061(object A_0, EventArgs A_1)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void m000062(object A_0, EventArgs A_1)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Multiselect = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        DataRow row = this.dataSetN.tJ_RequestForRepairDoc.NewRow();
                        row["idRequest"] = this.f000072;
                        row["Document"] = File.ReadAllBytes(dialog.FileNames[i]);
                        row["FileName"] = Path.GetFileName(dialog.FileNames[i]);
                        this.dataSetN.tJ_RequestForRepairDoc.Rows.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void m000063(object A_0, EventArgs A_1)
        {
            if (this.f0005bf.CurrentRow != null)
            {
                Convert.ToInt32(this.f0005bf.CurrentRow.Cells[this.f0005c8.Name].Value);
                this.f0005bf.Rows.Remove(this.f0005bf.CurrentRow);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного файла");
            }
        }

        private void m000070(object A_0, FormClosedEventArgs A_1)
        {
            base.SaveFormConfig(null);
        }

        private void m000074(object A_0, EventArgs A_1)
        {
            this.f0005ab.MinDate = this.f0005ac.Value.AddMinutes(1.0);
        }

        private void m000075(object A_0, EventArgs A_1)
        {
            this.f0005ac.MaxDate = this.f0005ab.Value.AddMinutes(-1.0);
        }

        private void m000076(object A_0, EventArgs A_1)
        {
            TimeSpan span;
            bool flag = false;
            this.f0005a8.RowsAdded -= new DataGridViewRowsAddedEventHandler(this.m0000bc);
            if (!this.f0005aa.Checked)
            {
                try
                {
                    DataRow row2 = this.dataSetN.tJ_RequestForRepairDaily.NewRow();
                    row2["idRequest"] = this.f000072;
                    row2["dateBeg"] = this.f0005ac.Value;
                    row2["dateEnd"] = this.f0005ab.Value;
                    this.dataSetN.tJ_RequestForRepairDaily.Rows.Add(row2);
                    flag = true;
                    this.f0005a6.ForeColor = SystemColors.ControlText;
                }
                catch (Exception exception2)
                {
                    MessageBox.Show(exception2.Message, exception2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                goto Label_0243;
            }
            int num = 0;
            Label_0167:
            span = (TimeSpan)(this.f0005ab.Value - this.f0005ac.Value);
            if (num <= span.Days)
            {
                if (this.f0005a9.Checked || ((this.f0005ac.Value.AddDays((double)num).DayOfWeek != DayOfWeek.Saturday) && (this.f0005ac.Value.AddDays((double)num).DayOfWeek != DayOfWeek.Sunday)))
                {
                    try
                    {
                        DataRow row = this.dataSetN.tJ_RequestForRepairDaily.NewRow();
                        row["idRequest"] = this.f000072;
                        row["dateBeg"] = this.f0005ac.Value.AddDays((double)num);
                        row["dateEnd"] = this.f0005ac.Value.AddDays((double)num).Date + this.f0005ab.Value.TimeOfDay;
                        this.dataSetN.tJ_RequestForRepairDaily.Rows.Add(row);
                        flag = true;
                        this.f0005a6.ForeColor = SystemColors.ControlText;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                num++;
                goto Label_0167;
            }
            Label_0243:
            this.f0005a8.RowsAdded += new DataGridViewRowsAddedEventHandler(this.m0000bc);
            if (flag)
            {
                if (c000097.f0005de == null)
                {
                }
                if (c000097.f0005df == null)
                {
                }
                DataRow row3 = this.dataSetN.tJ_RequestForRepairDaily.Where<DataSetGES.c0003b2>((c000097.f0005de = new Func<DataSetGES.c0003b2, bool>(c000097.f00022f.m000598))).OrderByDescending<DataSetGES.c0003b2, DateTime>((c000097.f0005df = new Func<DataSetGES.c0003b2, DateTime>(c000097.f00022f.m000599))).First<DataSetGES.c0003b2>();
                if (Convert.ToDateTime(row3["DateEnd"]) > this.f0005ac.MaxDate)
                {
                    this.f0005ac.MaxDate = this.f000599;
                }
                this.f0005ac.MinDate = Convert.ToDateTime(row3["DateEnd"]);
            }
        }
    
        private void m000077(object A_0, EventArgs A_1)
        {
            if (this.f0005d7.SelectedIndex >= 0)
            {
                this.f0005d8.ForeColor = SystemColors.ControlText;
            }
        }
   
        //private void m000078(object A_0, EventArgs A_1)
        //{
        //    if (!string.IsNullOrEmpty(this.f0005d2.Text))
        //    {
        //        this.f000084.ForeColor = SystemColors.ControlText;
        //    }
        //}

        private void m00007d(object A_0, DataGridViewCellFormattingEventArgs A_1)
        {
            if (A_1.RowIndex >= 0)
            {
                DayOfWeek dayOfWeek = Convert.ToDateTime(this.f0005a8[this.f0005cf.Name, A_1.RowIndex].Value).DayOfWeek;
                DayOfWeek week2 = Convert.ToDateTime(this.f0005a8[this.f0005d0.Name, A_1.RowIndex].Value).DayOfWeek;
                if (((dayOfWeek == DayOfWeek.Sunday) || (dayOfWeek == DayOfWeek.Saturday)) && (this.f0005a8.Columns[A_1.ColumnIndex] == this.f0005cf))
                {
                    A_1.CellStyle.ForeColor = Color.Red;
                }
                if (((week2 == DayOfWeek.Sunday) || (week2 == DayOfWeek.Saturday)) && (this.f0005a8.Columns[A_1.ColumnIndex] == this.f0005d0))
                {
                    A_1.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void m00007f(object A_0, EventArgs A_1)
        {
            if (this.f00059e.SelectedIndex >= 0)
            {
                this.f000110.ForeColor = SystemColors.ControlText;
            }
        }

        private void m000080(object A_0, EventArgs A_1)
        {
            if (!string.IsNullOrEmpty(this.f0005a1.Text))
            {
                this.f000317.ForeColor = SystemColors.ControlText;
            }
        }

        private void m000081(object A_0, EventArgs A_1)
        {
            if (!string.IsNullOrEmpty(this.f000115.Text))
            {
                this.f000317.ForeColor = SystemColors.ControlText;
            }
        }

        private void m000082(object A_0, EventArgs A_1)
        {
            if (this.f0005a5.Checked)
            {
                if ((this.dataSetN.tJ_RequestForRepair.Rows.Count > 0) && (this.f0005a4.Value == null))
                {
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"] = true;
                    this.f0005a4.Value = this.dataSetN.tJ_RequestForRepair.Rows[0]["DateAgreed"] = DateTime.Now;
                }
            }
            else if ((this.dataSetN.tJ_RequestForRepair.Rows.Count > 0) && (this.f0005a4.Value != null))
            {
                this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"] = false;
                this.f0005a4.Value = null;
                this.dataSetN.tJ_RequestForRepair.Rows[0]["DateAgreed"] = DBNull.Value;
            }
        }

        private void m000083(object A_0, EventArgs A_1)
        {
            FormLinkRequestAndSchm schm = new FormLinkRequestAndSchm
            {
                SqlSettings = this.SqlSettings
            };
            if (schm.ShowDialog() == DialogResult.OK)
            {
                int num = 1;
                if (this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Count > 0)
                {
                    num = this.dataSetN.tL_RequestForRepairSchmObjList.Max<DataSetGES.c0003b6, short>((c000097.f0005e0 ?? (c000097.f0005e0 = new Func<DataSetGES.c0003b6, short>(c000097.f00022f.m00059a)))) + 1;
                }
                this.f00059c = schm.LinkObjects;
                foreach (int num2 in this.f00059c.Keys)
                {
                    DataRow row = this.dataSetN.tL_RequestForRepairSchmObjList.NewRow();
                    row["idRequest"] = this.f000072;
                    row["idSchmObj"] = num2;
                    row["DAteBeg"] = schm.DateBeg;
                    row["DAteEnd"] = schm.DateEnd;
                    row["duration"] = schm.Duration;
                    row["num"] = num;
                    this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Add(row);
                }
                this.m000057();
            }
        }
 
        private void m000085(object A_0, DataGridViewCellEventArgs A_1)
        {
            this.m00005c(A_0, A_1);
        }

        private void m000086(object A_0, DataGridViewCellEventArgs A_1)
        {
            if (this.f0005bf.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.f0005bf.CurrentRow.Cells[this.f0005c8.Name].Value);
                if (A_1.ColumnIndex == this.f0005bf.Columns[this.f0005cb.Name].Index)
                {
                    byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.m00023a(num)["Document"];
                    string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.m00023a(num)["FileName"].ToString()));
                    FileStream stream1 = File.Create(path);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    new Process
                    {
                        StartInfo = {
                    FileName = path,
                    UseShellExecute = true
                }
                    }.Start();
                }
            }
        }




        private void m000089(object A_0, DataGridViewCellValueEventArgs A_1)
        {
            if (((this.f0005bf.RowCount > 0) && (this.f0005bf[this.f0005cb.Name, A_1.RowIndex].Value != null)) && (A_1.ColumnIndex == this.f0005bf.Columns[this.f0005c9.Name].Index))
            {
                A_1.Value = FileInfo.IconOfFile(this.f0005bf[this.f0005cb.Name, A_1.RowIndex].Value.ToString()).ToBitmap();
            }
        }

        private void m000096(object A_0, DataGridViewCellEventArgs A_1)
        {
            if (A_1.RowIndex == (this.f0005a8.Rows.Count - 1))
            {
                DateTime time = Convert.ToDateTime(this.f0005a8[this.f0005d0.Name, A_1.RowIndex].Value);
                if (time > this.f0005ac.MaxDate)
                {
                    this.f0005ac.MaxDate = DateTimePicker.MaximumDateTime;
                }
                this.f0005ac.MinDate = time;
            }
        }

        /// <summary>
        /// FormJournalRequestForRepairAddEdit_Load
        /// </summary>
        /// <param name="A_0"></param>
        /// <param name="A_1"></param>
        private void m0000b8(object A_0, EventArgs A_1)
        {
            this.f0005ad.Value = DateTime.Now;
            this.f0005ac.Value = DateTime.Now.Date.AddHours(8.0);
            this.f0005ab.Value = DateTime.Now.Date.AddHours(17.0);
            this.m000035();
            this.m00003a();
            this.m00003b();
            this.m000034();
            base.LoadFormConfig(null);
            switch (this.f000598)
            {
                case enum095.f000596:
                    {
                        if (this.f00059a == null)
                        {
                            DataRow row2 = this.dataSetN.tJ_RequestForRepair.NewRow();
                            row2["num"] = 0;
                            row2["dateCreate"] = DateTime.Now;
                            row2["idWorker"] = -1;
                            row2["reguestFiled"] = "";
                            row2["idSR"] = this.f00050c;
                            row2["schmObj"] = "";
                            row2["Purpose"] = "";
                            row2["Crash"] = this.f000034;
                            if (this.f000034)
                            {
                                row2["isPlanned"] = false;
                            }
                            else
                            {
                                row2["IsPlanned"] = true;
                            }
                            row2["agreed"] = false;
                            row2["iddivision"] = this.f00004d;
                            DataTable table2 = this.m000591();
                            base.SelectSqlData(table2, true, " where [Login] = SYSTEM_USER ", false);
                            if (table2.Rows.Count > 0)
                            {
                                row2["idUserCreate"] = table2.Rows[0]["iduser"];
                                if (table2.Rows[0]["idWorker"] != DBNull.Value)
                                {
                                    row2["IdWorker"] = table2.Rows[0]["idWorker"];
                                }
                            }
                            this.dataSetN.tJ_RequestForRepair.Rows.Add(row2);
                            if (this.f000034)
                            {
                                this.f0005a0.SelectedIndex = 0;
                            }
                            else
                            {
                                this.f0005a0.SelectedIndex = 1;
                            }
                            if (this.f0005d7.SelectedItem != null)
                            {
                                row2["reguestFiled"] = this.f0005d7.Text;
                            }
                            break;
                        }
                        DataRow row = this.dataSetN.tJ_RequestForRepair.NewRow();
                        row["num"] = 0;
                        row["dateCreate"] = DateTime.Now;
                        row["idWorker"] = this.f00059a["idWorker"];
                        row["reguestFiled"] = this.f00059a["reguestFiled"];
                        row["idSR"] = this.f00059a["idSR"];
                        row["schmObj"] = this.f00059a["schmObj"];
                        row["Purpose"] = this.f00059a["Purpose"];
                        row["IsPlanned"] = this.f00059a["IsPlanned"];
                        row["agreed"] = this.f00059a["agreed"];
                        row["iddivision"] = this.f00059a["iddivision"];
                        row["Crash"] = this.f00059a["Crash"];
                        DataTable table = this.m000591();
                        base.SelectSqlData(table, true, " where [Login] = SYSTEM_USER ", false);
                        if (table.Rows.Count > 0)
                        {
                            row["idUserCreate"] = table.Rows[0]["iduser"];
                            if (table.Rows[0]["idWorker"] != DBNull.Value)
                            {
                                row["IdWorker"] = table.Rows[0]["idWorker"];
                            }
                        }
                        this.dataSetN.tJ_RequestForRepair.Rows.Add(row);
                        break;
                    }
                case enum095.f000597:
                    if (this.f000072 > 0)
                    {
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.f000072.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.f000072.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc, true, " where idRequest = " + this.f000072.ToString());
                        this.m000058();
                    }
                    break;

                case enum095.f000598:
                    if (this.f000072 > 0)
                    {
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.f000072.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.f000072.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc, true, " where idRequest = " + this.f000072.ToString());
                        this.m000058();
                    }
                    this.f0005d7.Enabled = false;
                    this.f0005d2.Enabled = false;
                    this.f00059e.Enabled = false;
                    this.f0005a1.ReadOnly = true;
                    this.f000115.ReadOnly = true;
                    this.f0005a0.Enabled = false;
                    this.f0005a6.Enabled = false;
                    this.f00011a.ReadOnly = true;
                    this.f0005a2.ReadOnly = true;
                    this.f0005d1.ReadOnly = true;
                    this.f0005a5.Enabled = false;
                    this.f0005a4.Enabled = false;
                    this.f00023c.Enabled = false;
                    break;
            }
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.f00004d <= 0)
                {
                    this.f00004d = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["IdDivision"]);
                }
                if (Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"]))
                {
                    this.f0005a0.SelectedIndex = 1;
                }
                else
                {
                    this.f0005a0.SelectedIndex = 0;
                }
                if ((this.dataSetN.tJ_RequestForRepair.Rows[0]["Crash"] != DBNull.Value) && Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["Crash"]))
                {
                    this.f0005a0.Enabled = false;
                }
            }
            if (this.f00004d == 0x399)
            {
                this.f000581.Visible = false;
            }
        }

        private void m0000b9(object A_0, EventArgs A_1)
        {
            if (!this.f000581.Visible)
            {
                this.f0005b2.Height = 0x145;
                base.Height = 0x187;
                this.f000584.Location = new Point(this.f000584.Location.X, 0x14b);
                this.f000583.Location = new Point(this.f000583.Location.X, 0x14b);
            }
            else
            {
                this.f0005b2.Height = 0x245;
                base.Height = 0x287;
                this.f000584.Location = new Point(this.f000584.Location.X, 0x24b);
                this.f000583.Location = new Point(this.f000583.Location.X, 0x24b);
            }
        }

        private void m0000ba(object A_0, EventArgs A_1)
        {
            if (this.f0005a0.SelectedIndex >= 0)
            {
                this.f000234.ForeColor = SystemColors.ControlText;
            }
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.f0005a0.SelectedIndex == 0)
                {
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"] = false;
                }
                else
                {
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"] = true;
                }
            }
        }
 
        private void m0000bb(object A_0, EventArgs A_1)
        {
            this.f0005a9.Enabled = this.f0005aa.Checked;
        }

        private void m0000bc(object A_0, DataGridViewRowsAddedEventArgs A_1)
        {
            DataRow row = this.dataSetN.tJ_RequestForRepairDaily.Where<DataSetGES.c0003b2>((c000097.f0005d9 ?? (c000097.f0005d9 = new Func<DataSetGES.c0003b2, bool>(c000097.f00022f.m000593)))).OrderByDescending<DataSetGES.c0003b2, DateTime>((c000097.f0005da ?? (c000097.f0005da = new Func<DataSetGES.c0003b2, DateTime>(c000097.f00022f.m000594)))).First<DataSetGES.c0003b2>();
            if (Convert.ToDateTime(row["DateEnd"]) > this.f0005ac.MaxDate)
            {
                this.f0005ac.MaxDate = DateTimePicker.MaximumDateTime;
            }
            this.f0005ac.MinDate = Convert.ToDateTime(row["DateEnd"]);
        }

        private void m0000be(object A_0, DataGridViewEditingControlShowingEventArgs A_1)
        {
            if (A_1.Control is DateTimePicker)
            {
                if (this.f0005a8.CurrentCell.OwningColumn.Name == this.f0005cf.Name)
                {
                    (A_1.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.f0005a8[this.f0005d0.Name, this.f0005a8.CurrentCell.RowIndex].Value);
                    if (this.f0005a8.CurrentCell.RowIndex == 0)
                    {
                        (A_1.Control as DateTimePicker).MinDate = new DateTime(0x7d0, 1, 1);
                    }
                    if (this.f0005a8.CurrentCell.RowIndex > 0)
                    {
                        (A_1.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.f0005a8[this.f0005d0.Name, this.f0005a8.CurrentCell.RowIndex - 1].Value);
                    }
                }
                if (this.f0005a8.CurrentCell.OwningColumn.Name == this.f0005d0.Name)
                {
                    (A_1.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.f0005a8[this.f0005cf.Name, this.f0005a8.CurrentCell.RowIndex].Value);
                    if (this.f0005a8.CurrentCell.RowIndex == (this.f0005a8.Rows.Count - 1))
                    {
                        (A_1.Control as DateTimePicker).MaxDate = new DateTime(0x270e, 12, 0x1f);
                    }
                    if (this.f0005a8.CurrentCell.RowIndex < (this.f0005a8.Rows.Count - 1))
                    {
                        (A_1.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.f0005a8[this.f0005cf.Name, this.f0005a8.CurrentCell.RowIndex + 1].Value);
                    }
                }
            }
        }

        private bool m0000c0()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(this.f0005d2.Text))
            {
                this.f000084.ForeColor = Color.Red;
                flag = false;
            }
            if (this.f00059e.SelectedIndex < 0)
            {
                this.f000110.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.f0005a1.Text))
            {
                this.f000317.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.f000115.Text))
            {
                this.f000018.ForeColor = Color.Red;
                flag = false;
            }
            if (this.f0005a0.SelectedIndex < 0)
            {
                this.f000234.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dataSetN.tJ_RequestForRepairDaily.Rows.Count <= 0)
            {
                List<Color> list = new List<Color>();
                foreach (Control control in this.f0005a6.Controls)
                {
                    list.Add(control.ForeColor);
                }
                this.f0005a6.ForeColor = Color.Red;
                int num = 0;
                using (IEnumerator enumerator = this.f0005a6.Controls.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ((Control)enumerator.Current).ForeColor = list[num];
                        num++;
                    }
                }
                flag = false;
            }
            if ((this.f0005a5.Checked && (this.f00004d == 920)) && (this.f0005d5.SelectedIndex < 0))
            {
                this.f0005d6.ForeColor = Color.Red;
                flag = false;
            }
            return flag;
        }

        private DataTable m000590()
        {
            Type dataType = Type.GetType("System.Int32");
            DataTable table = new DataTable("vWorkerGroup");
            DataColumn column = new DataColumn("id", dataType);
            table.Columns.Add(column);
            DataColumn column2 = new DataColumn("fio", Type.GetType("System.String"));
            table.Columns.Add(column2);
            DataColumn column3 = new DataColumn("GroupElectrical", dataType);
            table.Columns.Add(column3);
            table.PrimaryKey = new DataColumn[] { column };
            DataColumn column4 = new DataColumn("GroupRoman", Type.GetType("System.String"))
            {
                Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))"
            };
            table.Columns.Add(column4);
            return table;
        }
        /// <summary>
        /// GetTableUser()
        /// </summary>
        /// <returns></returns>
        private DataTable m000591()
        {
            Type dataType = Type.GetType("System.Int32");
            DataTable table = new DataTable("tUser");
            DataColumn column = new DataColumn("idUser", dataType);
            table.Columns.Add(column);
            DataColumn column2 = new DataColumn("idWorker", dataType);
            table.Columns.Add(column2);
            DataColumn column3 = new DataColumn("name", Type.GetType("System.String"));
            table.Columns.Add(column3);
            table.PrimaryKey = new DataColumn[] { column };
            return table;
        }
        /**********************************************************/
        private void m000592(object A_0, DataGridViewRowsRemovedEventArgs A_1)
        {
            if (this.dataSetN.tJ_RequestForRepairDaily.Rows.Count > 0)
            {
                if (this.dataSetN.tJ_RequestForRepairDaily.Where<DataSetGES.c0003b2>((c000097.f0005db ?? (c000097.f0005db = new Func<DataSetGES.c0003b2, bool>(c000097.f00022f.m000595)))).Count<DataSetGES.c0003b2>() > 0)
                {
                    DataRow row = this.dataSetN.tJ_RequestForRepairDaily.Where<DataSetGES.c0003b2>((c000097.f0005dc ?? (c000097.f0005dc = new Func<DataSetGES.c0003b2, bool>(c000097.f00022f.m000596)))).OrderByDescending<DataSetGES.c0003b2, DateTime>((c000097.f0005dd ?? (c000097.f0005dd = new Func<DataSetGES.c0003b2, DateTime>(c000097.f00022f.m000597)))).First<DataSetGES.c0003b2>();
                    this.f0005ac.MinDate = Convert.ToDateTime(row["DateEnd"]);
                }
                else
                {
                    this.f0005ac.MinDate = this.f0000dd;
                }
            }
            else
            {
                this.f0005ac.MinDate = this.f0000dd;
            }
        }

        // Nested Types
        [Serializable, CompilerGenerated]
        private sealed class c000097
        {
            // Fields
            public static readonly c000096.c000097 f00022f = new c000096.c000097();
            public static Func<DataSetGES.c0003b2, bool> f0005d9;
            public static Func<DataSetGES.c0003b2, DateTime> f0005da;
            public static Func<DataSetGES.c0003b2, bool> f0005db;
            public static Func<DataSetGES.c0003b2, bool> f0005dc;
            public static Func<DataSetGES.c0003b2, DateTime> f0005dd;
            public static Func<DataSetGES.c0003b2, bool> f0005de;
            public static Func<DataSetGES.c0003b2, DateTime> f0005df;
            public static Func<DataSetGES.c0003b6, short> f0005e0;

            // Methods
            internal bool m000593(DataSetGES.c0003b2 A_0)
            {
                return ((A_0.RowState != DataRowState.Deleted) && (A_0.RowState != DataRowState.Detached));
            }

            internal DateTime m000594(DataSetGES.c0003b2 A_0)
            {
                return A_0.dateEnd;
            }

            internal bool m000595(DataSetGES.c0003b2 A_0)
            {
                return ((A_0.RowState != DataRowState.Deleted) && (A_0.RowState != DataRowState.Detached));
            }

            internal bool m000596(DataSetGES.c0003b2 A_0)
            {
                return ((A_0.RowState != DataRowState.Deleted) && (A_0.RowState != DataRowState.Detached));
            }

            internal DateTime m000597(DataSetGES.c0003b2 A_0)
            {
                return A_0.dateEnd;
            }

            internal bool m000598(DataSetGES.c0003b2 A_0)
            {
                return ((A_0.RowState != DataRowState.Deleted) && (A_0.RowState != DataRowState.Detached));
            }

            internal DateTime m000599(DataSetGES.c0003b2 A_0)
            {
                return A_0.dateEnd;
            }

            internal short m00059a(DataSetGES.c0003b6 A_0)
            {
                return A_0.Num;
            }
        }
    }


}


