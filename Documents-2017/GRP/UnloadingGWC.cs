namespace GRP
{
    using DataSql;
    using FormLbr;
    using Microsoft.Office.Interop.Excel;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    public class UnloadingGWC : FormBase
    {
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_4;
        private Button button_5;
        private Button button_6;
        private CheckBox checkBox_0;
        private CheckBox checkBox_1;
        private CheckBox checkBox_2;
        private CheckBox checkBox_3;
        private CheckBox checkBox_4;
        private CheckBox checkBox_5;
        private CheckBox checkBox_6;
        private CheckBox checkBox_7;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private DateTimePicker dateTimePicker_2;
        private DateTimePicker dateTimePicker_3;
        private DateTimePicker dateTimePicker_4;
        private DateTimePicker dateTimePicker_5;
        private DateTimePicker dateTimePicker_6;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private ProgressBar progressBar_0;
        private ProgressBar progressBar_1;
        private ProgressBar progressBar_2;
        private ProgressBar progressBar_3;
        private ProgressBar progressBar_4;
        private ProgressBar progressBar_5;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TabPage tabPage_3;

        public UnloadingGWC()
        {
            this.method_4();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.button_1.Click += new EventHandler(this.button_3_Click);
            this.button_2.Click += new EventHandler(this.button_3_Click);
            this.button_4.Click += new EventHandler(this.button_3_Click);
            this.button_3.Click += new EventHandler(this.button_3_Click);
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            Class0 class2 = new Class0 {
                unloadingGWC_0 = this
            };
            ((Button) sender).Enabled = false;
            class2.bool_0 = true;
            class2.bool_4 = true;
            class2.bool_3 = true;
            class2.bool_2 = true;
            class2.bool_5 = true;
            class2.bool_1 = true;
            bool flag = true;
            class2.bool_6 = true;
            if (this.checkBox_0.Checked)
            {
                class2.bool_0 = false;
                new Thread(new ThreadStart(class2.method_0)).Start();
            }
            if (this.checkBox_5.Checked)
            {
                Class1 class3 = new Class1 {
                    class0_0 = class2
                };
                class3.class0_0.bool_1 = false;
                class3.object_0 = new object[] { new Struct0("@Date", SqlDbType.SmallDateTime, this.dateTimePicker_4.Value.Date) };
                new Thread(new ThreadStart(class3.method_0)).Start();
            }
            if (this.checkBox_2.Checked)
            {
                Class2 class4 = new Class2 {
                    class0_0 = class2
                };
                class4.class0_0.bool_2 = false;
                class4.object_0 = new object[] { new Struct0("@Date", SqlDbType.SmallDateTime, this.dateTimePicker_0.Value.Date) };
                new Thread(new ThreadStart(class4.method_0)).Start();
            }
            if (this.checkBox_1.Checked)
            {
                Class3 class5 = new Class3 {
                    class0_0 = class2
                };
                class5.class0_0.bool_3 = false;
                class5.object_0 = new object[] { new Struct0("@DateBegin", SqlDbType.SmallDateTime, this.dateTimePicker_3.Value.Date), new Struct0("@DateEnd", SqlDbType.SmallDateTime, this.dateTimePicker_2.Value.Date) };
                new Thread(new ThreadStart(class5.method_0)).Start();
            }
            if (this.checkBox_3.Checked)
            {
                Class4 class6 = new Class4 {
                    class0_0 = class2
                };
                class6.class0_0.bool_4 = false;
                class6.object_0 = new object[] { new Struct0("@Year", SqlDbType.SmallDateTime, this.dateTimePicker_0.Value.Year) };
                new Thread(new ThreadStart(class6.method_0)).Start();
            }
            if (this.checkBox_4.Checked)
            {
                Class5 class7 = new Class5 {
                    class0_0 = class2
                };
                class7.class0_0.bool_5 = false;
                class7.object_0 = new object[] { new Struct0("@Year", SqlDbType.SmallDateTime, this.dateTimePicker_0.Value.Year) };
                new Thread(new ThreadStart(class7.method_0)).Start();
            }
            if (this.checkBox_7.Checked)
            {
                object[] objArray6 = new object[3];
                DateTime time = new DateTime(this.dateTimePicker_6.Value.Year, this.dateTimePicker_6.Value.Month, 1);
                objArray6[0] = new Struct0("@DateBegin", SqlDbType.SmallDateTime, time.ToString());
                time = new DateTime(this.dateTimePicker_6.Value.Year, this.dateTimePicker_6.Value.Month, DateTime.DaysInMonth(this.dateTimePicker_6.Value.Year, this.dateTimePicker_6.Value.Month));
                objArray6[1] = new Struct0("@DateEnd", SqlDbType.SmallDateTime, time.ToString());
                objArray6[2] = new Struct0("@DateLast", SqlDbType.SmallDateTime, this.dateTimePicker_5.Value.Date);
                flag = this.method_0(new bool[0]);
            }
            if (this.checkBox_6.Checked)
            {
                class2.bool_6 = false;
                new Thread(new ThreadStart(class2.method_1)).Start();
            }
            bool[] flagArray1 = new bool[] { flag };
            this.method_1(this.button_6, flagArray1);
            bool[] flagArray2 = new bool[] { class2.bool_6 };
            this.method_1(this.button_5, flagArray2);
            bool[] flagArray3 = new bool[] { class2.bool_0, class2.bool_1 };
            this.method_1(this.button_1, flagArray3);
            bool[] flagArray4 = new bool[] { class2.bool_2 };
            this.method_1(this.button_4, flagArray4);
            bool[] flagArray5 = new bool[] { class2.bool_3 };
            this.method_1(this.button_2, flagArray5);
            bool[] flagArray6 = new bool[] { class2.bool_4, class2.bool_5 };
            this.method_1(this.button_3, flagArray6);
            bool[] flagArray7 = new bool[] { flag };
            this.method_1(this.button_6, flagArray7);
            bool[] flagArray8 = new bool[] { class2.bool_6 };
            this.method_1(this.button_5, flagArray8);
            GC.Collect();
            GC.GetTotalMemory(true);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void label_0_Click(object sender, EventArgs e)
        {
        }

        private bool method_0(params bool[] bool_0)
        {
            try
            {
                return true;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, "Неудачная выгрузка!!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private void method_1(Button button_7, params bool[] bool_0)
        {
            bool[] flagArray = bool_0;
            for (int i = 0; i < flagArray.Length; i++)
            {
                if (!flagArray[i])
                {
                    button_7.Enabled = false;
                    return;
                }
            }
            button_7.Enabled = true;
        }

        private bool method_2(int int_0, string string_0, string string_1, ProgressBar progressBar_6)
        {
            return this.method_3(int_0, string_0, string_1, progressBar_6, null);
        }

        private bool method_3(int int_0, string string_0, string string_1, ProgressBar progressBar_6, object[] object_0)
        {
            bool flag;
            if (progressBar_6.Tag != null)
            {
                return false;
            }
            DataTable dataTable = new DataTable();
            Application application = new ApplicationClass();
            application.set_SheetsInNewWorkbook(1);
            application.get_Workbooks().Add(Type.Missing);
            Worksheet worksheet = (Worksheet) application.get_Workbooks().get__Default(1).get_Worksheets().get_Item(1);
            SQLSettings settings = new SQLSettings(this.get_SqlSettings());
            settings.set_ServerDB("192.168.8.252");
            settings.set_DBName("Org");
            SqlDataConnect connect = new SqlDataConnect();
            connect.OpenConnection(settings);
            progressBar_6.Tag = 1;
            try
            {
                SqlCommand command = new SqlCommand(string_1, connect.get_Connection()) {
                    CommandTimeout = 0
                };
                if (object_0 != null)
                {
                    foreach (object obj2 in object_0)
                    {
                        command.Parameters.AddWithValue(((Struct0) obj2).string_0, ((Struct0) obj2).object_1);
                    }
                }
                new SqlDataAdapter { SelectCommand = command }.Fill(dataTable);
                Range range = (Range) worksheet.get_Cells().get__Default(1, 1);
                range.set_Value2(string_0);
                for (int i = 1; i <= dataTable.Columns.Count; i++)
                {
                    range = (Range) worksheet.get_Cells().get__Default(2, i);
                    range.set_Value2(dataTable.Columns[i - 1].ColumnName);
                }
                progressBar_6.Maximum = dataTable.Rows.Count;
                int num = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    num++;
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        range = (Range) worksheet.get_Cells().get__Default(num + 1, column.Ordinal + 1);
                        if (column.DataType == Type.GetType("System.String"))
                        {
                            range.set_NumberFormat("@");
                        }
                        if (column.DataType == Type.GetType("System.DateTime"))
                        {
                            range.set_NumberFormat("ДД.ММ.ГГГГ");
                        }
                        if (column.DataType == Type.GetType("System.Boolean"))
                        {
                            range.set_NumberFormat("@");
                        }
                        range.set_Value2(row[column]);
                    }
                    progressBar_6.Value = num - 1;
                }
                application.set_Visible(true);
                progressBar_6.Tag = null;
                flag = true;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, "Неудачная выгрузка №" + int_0.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                application = null;
                progressBar_6.Tag = null;
                flag = false;
            }
            finally
            {
                connect.CloseConnection();
            }
            return flag;
        }

        private void method_4()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(UnloadingGWC));
            this.button_0 = new Button();
            this.label_0 = new Label();
            this.checkBox_0 = new CheckBox();
            this.checkBox_1 = new CheckBox();
            this.checkBox_2 = new CheckBox();
            this.progressBar_0 = new ProgressBar();
            this.progressBar_3 = new ProgressBar();
            this.checkBox_3 = new CheckBox();
            this.progressBar_2 = new ProgressBar();
            this.progressBar_1 = new ProgressBar();
            this.label_1 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.checkBox_4 = new CheckBox();
            this.progressBar_4 = new ProgressBar();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.label_5 = new Label();
            this.dateTimePicker_4 = new DateTimePicker();
            this.button_1 = new Button();
            this.checkBox_5 = new CheckBox();
            this.progressBar_5 = new ProgressBar();
            this.tabPage_1 = new TabPage();
            this.label_3 = new Label();
            this.dateTimePicker_2 = new DateTimePicker();
            this.label_4 = new Label();
            this.dateTimePicker_3 = new DateTimePicker();
            this.button_4 = new Button();
            this.button_2 = new Button();
            this.tabPage_2 = new TabPage();
            this.button_3 = new Button();
            this.label_2 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.tabPage_3 = new TabPage();
            this.checkBox_6 = new CheckBox();
            this.button_5 = new Button();
            this.checkBox_7 = new CheckBox();
            this.button_6 = new Button();
            this.label_6 = new Label();
            this.dateTimePicker_5 = new DateTimePicker();
            this.label_7 = new Label();
            this.dateTimePicker_6 = new DateTimePicker();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.tabPage_3.SuspendLayout();
            base.SuspendLayout();
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_0.Location = new Point(0x17d, 0xd7);
            this.button_0.Name = "btnClose";
            this.button_0.Size = new Size(0x51, 0x17);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "Закрыть";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.label_0.Dock = DockStyle.Top;
            this.label_0.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_0.Location = new Point(0, 0);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x1d2, 0x18);
            this.label_0.TabIndex = 2;
            this.label_0.Text = "Выгрузка группы по работе с потребителями";
            this.label_0.Visible = false;
            this.label_0.Click += new EventHandler(this.label_0_Click);
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new Point(6, 6);
            this.checkBox_0.Name = "checkBox1";
            this.checkBox_0.Size = new Size(0x11e, 0x11);
            this.checkBox_0.TabIndex = 3;
            this.checkBox_0.Text = "Контактная информация по потребителям (файл 1)";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Location = new Point(9, 0x6a);
            this.checkBox_1.Name = "checkBox3";
            this.checkBox_1.Size = new Size(0xe3, 0x11);
            this.checkBox_1.TabIndex = 5;
            this.checkBox_1.Text = "Потребление по потребителям (файл 4)";
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.checkBox_2.AutoSize = true;
            this.checkBox_2.Location = new Point(9, 0x22);
            this.checkBox_2.Name = "checkBox5";
            this.checkBox_2.Size = new Size(0x111, 0x11);
            this.checkBox_2.TabIndex = 7;
            this.checkBox_2.Text = "Потребление по объектам потребления (файл 3)";
            this.checkBox_2.UseVisualStyleBackColor = true;
            this.progressBar_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.progressBar_0.Location = new Point(0x124, 6);
            this.progressBar_0.Name = "progressBar1";
            this.progressBar_0.Size = new Size(0x9b, 0x11);
            this.progressBar_0.TabIndex = 9;
            this.progressBar_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.progressBar_3.Location = new Point(0x139, 0x25);
            this.progressBar_3.Name = "progressBar2";
            this.progressBar_3.Size = new Size(0x88, 0x11);
            this.progressBar_3.TabIndex = 0x10;
            this.checkBox_3.AutoSize = true;
            this.checkBox_3.Location = new Point(6, 0x25);
            this.checkBox_3.Name = "checkBox2";
            this.checkBox_3.Size = new Size(250, 0x11);
            this.checkBox_3.TabIndex = 15;
            this.checkBox_3.Text = "Плановые объемы по потребителю (файл 5)";
            this.checkBox_3.UseVisualStyleBackColor = true;
            this.progressBar_2.Location = new Point(0x57, 0x84);
            this.progressBar_2.Name = "progressBar3";
            this.progressBar_2.Size = new Size(0x166, 0x11);
            this.progressBar_2.TabIndex = 13;
            this.progressBar_1.Location = new Point(0x57, 0x39);
            this.progressBar_1.Name = "progressBar5";
            this.progressBar_1.Size = new Size(0x166, 0x11);
            this.progressBar_1.TabIndex = 12;
            this.label_1.Location = new Point(6, 11);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x37, 20);
            this.label_1.TabIndex = 9;
            this.label_1.Text = "Период:";
            this.dateTimePicker_0.CustomFormat = "MMMM yyyy";
            this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_0.Location = new Point(0x43, 9);
            this.dateTimePicker_0.Name = "dtOUT";
            this.dateTimePicker_0.Size = new Size(0x73, 20);
            this.dateTimePicker_0.TabIndex = 8;
            this.checkBox_4.AutoSize = true;
            this.checkBox_4.Location = new Point(6, 60);
            this.checkBox_4.Name = "checkBox6";
            this.checkBox_4.Size = new Size(0x12d, 0x11);
            this.checkBox_4.TabIndex = 0x11;
            this.checkBox_4.Text = "Плановые объемы по объектам потребителя (файл 6)";
            this.checkBox_4.UseVisualStyleBackColor = true;
            this.progressBar_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.progressBar_4.Location = new Point(0x139, 60);
            this.progressBar_4.Name = "progressBar6";
            this.progressBar_4.Size = new Size(0x88, 0x11);
            this.progressBar_4.TabIndex = 0x12;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Controls.Add(this.tabPage_3);
            this.tabControl_0.Location = new Point(5, 0x1b);
            this.tabControl_0.Name = "tabControl1";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x1cd, 0xb8);
            this.tabControl_0.TabIndex = 12;
            this.tabPage_0.BackColor = SystemColors.Control;
            this.tabPage_0.Controls.Add(this.label_5);
            this.tabPage_0.Controls.Add(this.dateTimePicker_4);
            this.tabPage_0.Controls.Add(this.button_1);
            this.tabPage_0.Controls.Add(this.checkBox_0);
            this.tabPage_0.Controls.Add(this.progressBar_0);
            this.tabPage_0.Controls.Add(this.checkBox_5);
            this.tabPage_0.Controls.Add(this.progressBar_5);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPage1";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x1c5, 0x9e);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Информация";
            this.label_5.Location = new Point(6, 0x24);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x37, 20);
            this.label_5.TabIndex = 15;
            this.label_5.Text = "Период:";
            this.dateTimePicker_4.CustomFormat = "MMMM yyyy";
            this.dateTimePicker_4.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_4.Location = new Point(0x43, 0x22);
            this.dateTimePicker_4.Name = "dtOutAbnObj";
            this.dateTimePicker_4.Size = new Size(0x73, 20);
            this.dateTimePicker_4.TabIndex = 14;
            this.button_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_1.Location = new Point(3, 0x81);
            this.button_1.Name = "btnInfo";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 13;
            this.button_1.Text = "Выгрузка";
            this.button_1.UseVisualStyleBackColor = true;
            this.checkBox_5.AutoSize = true;
            this.checkBox_5.Location = new Point(6, 0x3b);
            this.checkBox_5.Name = "checkBox7";
            this.checkBox_5.Size = new Size(0x110, 0x11);
            this.checkBox_5.TabIndex = 7;
            this.checkBox_5.Text = "Информация по объектам потребления (файл 2)";
            this.checkBox_5.UseVisualStyleBackColor = true;
            this.progressBar_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.progressBar_5.Location = new Point(0x124, 0x3d);
            this.progressBar_5.Name = "progressBar7";
            this.progressBar_5.Size = new Size(0x9b, 15);
            this.progressBar_5.TabIndex = 12;
            this.tabPage_1.BackColor = SystemColors.Control;
            this.tabPage_1.Controls.Add(this.label_3);
            this.tabPage_1.Controls.Add(this.dateTimePicker_2);
            this.tabPage_1.Controls.Add(this.label_4);
            this.tabPage_1.Controls.Add(this.dateTimePicker_3);
            this.tabPage_1.Controls.Add(this.button_4);
            this.tabPage_1.Controls.Add(this.button_2);
            this.tabPage_1.Controls.Add(this.checkBox_1);
            this.tabPage_1.Controls.Add(this.progressBar_2);
            this.tabPage_1.Controls.Add(this.checkBox_2);
            this.tabPage_1.Controls.Add(this.progressBar_1);
            this.tabPage_1.Controls.Add(this.label_1);
            this.tabPage_1.Controls.Add(this.dateTimePicker_0);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPage2";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x1c5, 0x9e);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Потребление";
            this.label_3.Location = new Point(0xbf, 80);
            this.label_3.Name = "label5";
            this.label_3.Size = new Size(0x19, 20);
            this.label_3.TabIndex = 20;
            this.label_3.Text = "по:";
            this.label_3.TextAlign = ContentAlignment.MiddleLeft;
            this.dateTimePicker_2.CustomFormat = "MMMM yyyy";
            this.dateTimePicker_2.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_2.Location = new Point(0xe7, 80);
            this.dateTimePicker_2.Name = "dtEnd";
            this.dateTimePicker_2.Size = new Size(0x5f, 20);
            this.dateTimePicker_2.TabIndex = 0x13;
            this.label_4.Location = new Point(6, 80);
            this.label_4.Name = "label4";
            this.label_4.Size = new Size(0x4b, 20);
            this.label_4.TabIndex = 0x12;
            this.label_4.Text = "Период с:";
            this.label_4.TextAlign = ContentAlignment.MiddleLeft;
            this.dateTimePicker_3.CustomFormat = "MMMM yyyy";
            this.dateTimePicker_3.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_3.Location = new Point(0x57, 80);
            this.dateTimePicker_3.Name = "dtBegin";
            this.dateTimePicker_3.Size = new Size(0x5f, 20);
            this.dateTimePicker_3.TabIndex = 0x11;
            this.button_4.Location = new Point(6, 0x37);
            this.button_4.Name = "btnOut1";
            this.button_4.Size = new Size(0x4b, 0x17);
            this.button_4.TabIndex = 0x10;
            this.button_4.Text = "Выгрузка";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_2.Location = new Point(9, 0x81);
            this.button_2.Name = "btnOut";
            this.button_2.Size = new Size(0x4b, 0x17);
            this.button_2.TabIndex = 15;
            this.button_2.Text = "Выгрузка";
            this.button_2.UseVisualStyleBackColor = true;
            this.tabPage_2.BackColor = SystemColors.Control;
            this.tabPage_2.Controls.Add(this.button_3);
            this.tabPage_2.Controls.Add(this.label_2);
            this.tabPage_2.Controls.Add(this.dateTimePicker_1);
            this.tabPage_2.Controls.Add(this.progressBar_4);
            this.tabPage_2.Controls.Add(this.checkBox_3);
            this.tabPage_2.Controls.Add(this.checkBox_4);
            this.tabPage_2.Controls.Add(this.progressBar_3);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPage3";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x1c5, 0x9e);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Плановые объемы";
            this.button_3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_3.Location = new Point(3, 0x84);
            this.button_3.Name = "btnVolume";
            this.button_3.Size = new Size(0x4b, 0x17);
            this.button_3.TabIndex = 0x15;
            this.button_3.Text = "Выгрузка";
            this.button_3.UseVisualStyleBackColor = true;
            this.label_2.Location = new Point(6, 7);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x38, 20);
            this.label_2.TabIndex = 20;
            this.label_2.Text = "Период:";
            this.dateTimePicker_1.CustomFormat = "yyyy";
            this.dateTimePicker_1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_1.Location = new Point(0x5d, 5);
            this.dateTimePicker_1.Name = "dtPlanVolum";
            this.dateTimePicker_1.Size = new Size(0x42, 20);
            this.dateTimePicker_1.TabIndex = 0x13;
            this.tabPage_3.Controls.Add(this.checkBox_6);
            this.tabPage_3.Controls.Add(this.button_5);
            this.tabPage_3.Controls.Add(this.checkBox_7);
            this.tabPage_3.Controls.Add(this.button_6);
            this.tabPage_3.Controls.Add(this.label_6);
            this.tabPage_3.Controls.Add(this.dateTimePicker_5);
            this.tabPage_3.Controls.Add(this.label_7);
            this.tabPage_3.Controls.Add(this.dateTimePicker_6);
            this.tabPage_3.Location = new Point(4, 0x16);
            this.tabPage_3.Name = "tabPage4";
            this.tabPage_3.Padding = new Padding(3);
            this.tabPage_3.Size = new Size(0x1c5, 0x9e);
            this.tabPage_3.TabIndex = 3;
            this.tabPage_3.Text = "Закрытие";
            this.tabPage_3.UseVisualStyleBackColor = true;
            this.checkBox_6.AutoSize = true;
            this.checkBox_6.Location = new Point(0xb3, 0x39);
            this.checkBox_6.Name = "checkBox9";
            this.checkBox_6.Size = new Size(0xcc, 0x11);
            this.checkBox_6.TabIndex = 0x1c;
            this.checkBox_6.Text = "Анализ по объектам потребителей";
            this.checkBox_6.UseVisualStyleBackColor = true;
            this.button_5.Location = new Point(0xb0, 80);
            this.button_5.Name = "btnAnalizAbnObj";
            this.button_5.Size = new Size(0x4b, 0x17);
            this.button_5.TabIndex = 0x1b;
            this.button_5.Text = "Выгрузка";
            this.button_5.UseVisualStyleBackColor = true;
            this.checkBox_7.AutoSize = true;
            this.checkBox_7.Location = new Point(9, 0x39);
            this.checkBox_7.Name = "checkBox8";
            this.checkBox_7.Size = new Size(0x99, 0x11);
            this.checkBox_7.TabIndex = 0x1a;
            this.checkBox_7.Text = "Анализ по потребителям";
            this.checkBox_7.UseVisualStyleBackColor = true;
            this.button_6.Location = new Point(6, 80);
            this.button_6.Name = "btnAnalizAbn";
            this.button_6.Size = new Size(0x4b, 0x17);
            this.button_6.TabIndex = 0x19;
            this.button_6.Text = "Выгрузка";
            this.button_6.UseVisualStyleBackColor = true;
            this.label_6.Location = new Point(6, 0x22);
            this.label_6.Name = "label8";
            this.label_6.Size = new Size(0x7c, 20);
            this.label_6.TabIndex = 0x18;
            this.label_6.Text = "Период прошлый:";
            this.dateTimePicker_5.CustomFormat = "MMMM yyyy";
            this.dateTimePicker_5.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_5.Location = new Point(0x88, 0x22);
            this.dateTimePicker_5.Name = "dtLastAnaliz";
            this.dateTimePicker_5.Size = new Size(0x73, 20);
            this.dateTimePicker_5.TabIndex = 0x17;
            this.label_7.Location = new Point(6, 12);
            this.label_7.Name = "label7";
            this.label_7.Size = new Size(0x7c, 20);
            this.label_7.TabIndex = 0x16;
            this.label_7.Text = "Период текущий:";
            this.dateTimePicker_6.CustomFormat = "MMMM yyyy";
            this.dateTimePicker_6.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_6.Location = new Point(0x88, 8);
            this.dateTimePicker_6.Name = "dtCurrentAnaliz";
            this.dateTimePicker_6.Size = new Size(0x73, 20);
            this.dateTimePicker_6.TabIndex = 0x15;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x1d2, 250);
            base.Controls.Add(this.tabControl_0);
            base.Controls.Add(this.label_0);
            base.Controls.Add(this.button_0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "UnloadingGWC";
            this.Text = "Выгрузка группы по работе с потребителями";
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.tabPage_2.ResumeLayout(false);
            this.tabPage_2.PerformLayout();
            this.tabPage_3.ResumeLayout(false);
            this.tabPage_3.PerformLayout();
            base.ResumeLayout(false);
        }

        [CompilerGenerated]
        private sealed class Class0
        {
            public bool bool_0;
            public bool bool_1;
            public bool bool_2;
            public bool bool_3;
            public bool bool_4;
            public bool bool_5;
            public bool bool_6;
            public UnloadingGWC unloadingGWC_0;

            internal void method_0()
            {
                this.bool_0 = this.unloadingGWC_0.method_2(1, this.unloadingGWC_0.checkBox_0.Text, "Select * FROM fun_Abn_X1()", this.unloadingGWC_0.progressBar_0);
                bool[] flagArray1 = new bool[] { this.bool_0, this.bool_1 };
                this.unloadingGWC_0.method_1(this.unloadingGWC_0.button_1, flagArray1);
            }

            internal void method_1()
            {
                bool[] flagArray1 = new bool[] { this.bool_6 };
                this.unloadingGWC_0.method_1(this.unloadingGWC_0.button_5, flagArray1);
            }
        }

        [CompilerGenerated]
        private sealed class Class1
        {
            public UnloadingGWC.Class0 class0_0;
            public object[] object_0;

            internal void method_0()
            {
                this.class0_0.bool_1 = this.class0_0.unloadingGWC_0.method_3(2, this.class0_0.unloadingGWC_0.checkBox_5.Text, "Select * FROM fun_AbnObj_X7(@Date)", this.class0_0.unloadingGWC_0.progressBar_5, this.object_0);
                bool[] flagArray1 = new bool[] { this.class0_0.bool_0, this.class0_0.bool_1 };
                this.class0_0.unloadingGWC_0.method_1(this.class0_0.unloadingGWC_0.button_1, flagArray1);
            }
        }

        [CompilerGenerated]
        private sealed class Class2
        {
            public UnloadingGWC.Class0 class0_0;
            public object[] object_0;

            internal void method_0()
            {
                this.class0_0.bool_2 = this.class0_0.unloadingGWC_0.method_3(5, this.class0_0.unloadingGWC_0.checkBox_2.Text, "Select * FROM fun_AbnObj_Month_Value_X5(@Date)", this.class0_0.unloadingGWC_0.progressBar_1, this.object_0);
                bool[] flagArray1 = new bool[] { this.class0_0.bool_2 };
                this.class0_0.unloadingGWC_0.method_1(this.class0_0.unloadingGWC_0.button_4, flagArray1);
            }
        }

        [CompilerGenerated]
        private sealed class Class3
        {
            public UnloadingGWC.Class0 class0_0;
            public object[] object_0;

            internal void method_0()
            {
                this.class0_0.bool_3 = this.class0_0.unloadingGWC_0.method_3(3, this.class0_0.unloadingGWC_0.checkBox_1.Text, "Select * FROM fun_Abn_Value_X4(@DateBegin , @DateEnd)", this.class0_0.unloadingGWC_0.progressBar_2, this.object_0);
                bool[] flagArray1 = new bool[] { this.class0_0.bool_3 };
                this.class0_0.unloadingGWC_0.method_1(this.class0_0.unloadingGWC_0.button_2, flagArray1);
            }
        }

        [CompilerGenerated]
        private sealed class Class4
        {
            public UnloadingGWC.Class0 class0_0;
            public object[] object_0;

            internal void method_0()
            {
                this.class0_0.bool_4 = this.class0_0.unloadingGWC_0.method_3(2, this.class0_0.unloadingGWC_0.checkBox_3.Text, "Select * FROM fun_Abn_X2(@Year)", this.class0_0.unloadingGWC_0.progressBar_3, this.object_0);
                bool[] flagArray1 = new bool[] { this.class0_0.bool_4, this.class0_0.bool_5 };
                this.class0_0.unloadingGWC_0.method_1(this.class0_0.unloadingGWC_0.button_3, flagArray1);
            }
        }

        [CompilerGenerated]
        private sealed class Class5
        {
            public UnloadingGWC.Class0 class0_0;
            public object[] object_0;

            internal void method_0()
            {
                this.class0_0.bool_5 = this.class0_0.unloadingGWC_0.method_3(6, this.class0_0.unloadingGWC_0.checkBox_4.Text, "Select * FROM fun_AbnObj_X2(@Year)", this.class0_0.unloadingGWC_0.progressBar_4, this.object_0);
                bool[] flagArray1 = new bool[] { this.class0_0.bool_4, this.class0_0.bool_5 };
                this.class0_0.unloadingGWC_0.method_1(this.class0_0.unloadingGWC_0.button_3, flagArray1);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct0
        {
            public string string_0;
            public object object_0;
            public object object_1;
            public Struct0(string string_1, object object_2, object object_3)
            {
                this.string_0 = string_1;
                this.object_0 = object_2;
                this.object_1 = object_3;
            }
        }
    }
}

