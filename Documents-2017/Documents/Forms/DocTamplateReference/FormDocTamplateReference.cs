namespace Documents.Forms.DocTamplateReference
{
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class FormDocTamplateReference : FormBase
    {
        private BackgroundWorker backgroundWorker_0;
        private BackgroundWorker backgroundWorker_1;
        private BindingSource bindingSource_0;
        private bool bool_0;
        private bool bool_1;
        private Button button_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataSetGES dataSetGES_0;
        private IContainer icontainer_0;
        private int int_0;
        private Label label_0;
        private ProgressBar progressBar_0;
        private SqlConnection sqlConnection_0;
        private TableLayoutPanel tableLayoutPanel_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripComboBox toolStripComboBox_0;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;

        public FormDocTamplateReference()
        {
            this.int_0 = -1;
            this.method_3();
        }

        public FormDocTamplateReference(int classifierValue)
        {
            this.int_0 = -1;
            this.method_3();
            this.int_0 = classifierValue;
        }

        private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWorkAsyncArgs argument = (DoWorkAsyncArgs) e.Argument;
            try
            {
                FileBinary binary = new FileBinary(argument.FileName);
                this.method_1("Соединение...");
                this.sqlConnection_0 = new SqlConnection(argument.SqlSettings.GetConnectionString());
                SqlCommand command1 = new SqlCommand {
                    Connection = this.sqlConnection_0,
                    CommandText = "INSERT INTO tR_DocTemplate (idTypeDoc, FileName, FileData, Size, LastChange, DateIn) VALUES (@idTypeDoc, @FileName, @FileData, @Size, @LastChange, @DateIn)"
                };
                command1.Parameters.Add("@idTypeDoc", SqlDbType.Int).Value = argument.Id;
                command1.Parameters.Add("@FileName", SqlDbType.VarChar).Value = binary.get_Name();
                command1.Parameters.Add("@FileData", SqlDbType.VarBinary).Value = binary.get_ByteArray();
                command1.Parameters.Add("@Size", SqlDbType.Float).Value = binary.get_KbSize();
                command1.Parameters.Add("@LastChange", SqlDbType.SmallDateTime).Value = DateTime.Now;
                command1.Parameters.Add("@DateIn", SqlDbType.SmallDateTime).Value = DateTime.Now;
                this.sqlConnection_0.Open();
                this.method_1("Добавление шаблона...");
                this.method_2(true);
                this.bool_0 = true;
                command1.ExecuteNonQuery();
                e.Result = binary.get_Name();
            }
            catch (SqlException exception1)
            {
                this.bool_0 = false;
                if (exception1.Number != 0xa29)
                {
                    throw;
                }
                this.method_1(string.Format("Ошибка: '{0}'", "Файл с таким именем уже существует!"));
                if (this.sqlConnection_0 != null)
                {
                    this.sqlConnection_0.Close();
                }
            }
            catch (Exception exception)
            {
                this.bool_0 = false;
                this.method_1(string.Format("Ошибка: '{0}'", exception.Message));
                if (this.sqlConnection_0 != null)
                {
                    this.sqlConnection_0.Close();
                }
            }
            finally
            {
                if ((this.sqlConnection_0 != null) && (this.sqlConnection_0.State != ConnectionState.Closed))
                {
                    this.sqlConnection_0.Close();
                }
            }
        }

        private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.method_2(false);
            this.method_1("Шаблон '" + e.Result.ToString() + "' добавлен.");
            this.method_0();
            this.bool_0 = false;
        }

        private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.bool_1 = true;
                DoWorkAsyncArgs argument = (DoWorkAsyncArgs) e.Argument;
                this.method_1("Соединение...");
                this.sqlConnection_0 = new SqlConnection(argument.SqlSettings.GetConnectionString());
                this.sqlConnection_0.Open();
                SqlCommand selectCommand = this.sqlConnection_0.CreateCommand();
                selectCommand.CommandText = "SELECT id, idTypeDoc, FileName, FileData, Size, LastChange, DateIn FROM tR_DocTemplate WHERE id = " + argument.IdTemplate.ToString();
                this.method_1("Открытие шаблона...");
                this.dataSetGES_0.tR_DocTemplate.Clear();
                new SqlDataAdapter(selectCommand).Fill(this.dataSetGES_0.tR_DocTemplate);
                FileBinary binary = new FileBinary(this.dataSetGES_0.tR_DocTemplate.First<DataSetGES.Class90>().FileData, this.dataSetGES_0.tR_DocTemplate.First<DataSetGES.Class90>().FileName, this.dataSetGES_0.tR_DocTemplate.First<DataSetGES.Class90>().LastChange);
                binary.SaveToDisk(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + @"\");
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + @"\" + binary.get_Name());
                this.method_1("");
            }
            catch (Exception exception)
            {
                this.bool_1 = false;
                this.method_1(string.Format("Ошибка: '{0}'", exception.Message));
                if (this.sqlConnection_0 != null)
                {
                    this.sqlConnection_0.Close();
                }
            }
            finally
            {
                if ((this.sqlConnection_0 != null) && (this.sqlConnection_0.State != ConnectionState.Closed))
                {
                    this.sqlConnection_0.Close();
                }
            }
        }

        private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.bool_1 = false;
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.bool_1)
            {
                MessageBox.Show((IWin32Window) this, "Выполняется обработка данных. Пожалуйста подождите завершения.");
            }
            else if ((this.dataGridViewExcelFilter_0.SelectedRows != null) && (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0))
            {
                DoWorkAsyncArgs argument = new DoWorkAsyncArgs(this.get_SqlSettings(), (int) this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Cells["id"].Value);
                this.backgroundWorker_1.RunWorkerAsync(argument);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormDocTamplateReference_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bool_0 || this.bool_1)
            {
                MessageBox.Show("Пока выполняется обработка данных, окно не закроется. Пожалуйста подождите...", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }

        private void FormDocTamplateReference_Load(object sender, EventArgs e)
        {
            this.toolStripComboBox_0.ComboBox.DataSource = this.bindingSource_0;
            this.toolStripComboBox_0.ComboBox.DisplayMember = "Name";
            this.toolStripComboBox_0.ComboBox.ValueMember = "id";
            string str = "WHERE ParentKey = ';TypeDoc;tR_DocTemplate;' AND Deleted = ((0)) AND isGroup = ((0))" + ((this.int_0 != -1) ? (" AND Value = " + this.int_0.ToString()) : "");
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tR_Classifier, true, str);
            if (this.int_0 != -1)
            {
                this.toolStripComboBox_0.Visible = false;
                this.Text = this.Text + " : " + this.dataSetGES_0.tR_Classifier.First<DataSetGES.Class50>().Name;
            }
            this.method_0();
        }

        private void method_0()
        {
            if (this.bindingSource_0.Current != null)
            {
                DataTable table = new SqlDataCommand(this.get_SqlSettings()).SelectSqlData("SELECT id, FileName, LastChange FROM tR_DocTemplate WHERE Deleted = ((0)) AND idTypeDoc = " + ((DataRowView) this.bindingSource_0.Current)["id"].ToString());
                BindingSource source = new BindingSource {
                    DataSource = table
                };
                this.dataGridViewExcelFilter_0.DataSource = source;
            }
        }

        private void method_1(string string_0)
        {
            Class325 class2 = new Class325 {
                formDocTamplateReference_0 = this,
                string_0 = string_0
            };
            if (this.label_0.InvokeRequired)
            {
                Dispatcher.Invoke(this, new AsyncAction(class2, (IntPtr) this.method_0));
            }
            else
            {
                this.label_0.Text = class2.string_0;
            }
        }

        private void method_2(bool bool_2)
        {
            Class326 class2 = new Class326 {
                formDocTamplateReference_0 = this,
                bool_0 = bool_2
            };
            if (this.progressBar_0.InvokeRequired)
            {
                Dispatcher.Invoke(this, new AsyncAction(class2, (IntPtr) this.method_0));
            }
            else
            {
                this.progressBar_0.Style = class2.bool_0 ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            }
        }

        private void method_3()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.tableLayoutPanel_0 = new TableLayoutPanel();
            this.button_0 = new Button();
            this.progressBar_0 = new ProgressBar();
            this.label_0 = new Label();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripComboBox_0 = new ToolStripComboBox();
            this.dataSetGES_0 = new DataSetGES();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.backgroundWorker_0 = new BackgroundWorker();
            this.backgroundWorker_1 = new BackgroundWorker();
            this.tableLayoutPanel_0.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.dataSetGES_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel_0.ColumnCount = 3;
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 383f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111f));
            this.tableLayoutPanel_0.Controls.Add(this.button_0, 2, 2);
            this.tableLayoutPanel_0.Controls.Add(this.progressBar_0, 0, 3);
            this.tableLayoutPanel_0.Controls.Add(this.label_0, 1, 2);
            this.tableLayoutPanel_0.Controls.Add(this.dataGridViewExcelFilter_0, 0, 1);
            this.tableLayoutPanel_0.Dock = DockStyle.Fill;
            this.tableLayoutPanel_0.Location = new Point(0, 0);
            this.tableLayoutPanel_0.Name = "tableLayoutPanel2";
            this.tableLayoutPanel_0.RowCount = 5;
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 8f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 8f));
            this.tableLayoutPanel_0.Size = new Size(0x299, 0x152);
            this.tableLayoutPanel_0.TabIndex = 0x1d;
            this.button_0.Dock = DockStyle.Left;
            this.button_0.Location = new Point(0x234, 0x12f);
            this.button_0.Margin = new Padding(10, 6, 3, 6);
            this.button_0.Name = "btnCancel";
            this.tableLayoutPanel_0.SetRowSpan(this.button_0, 3);
            this.button_0.Size = new Size(0x4b, 0x1d);
            this.button_0.TabIndex = 6;
            this.button_0.Text = "Закрыть";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.progressBar_0.Dock = DockStyle.Fill;
            this.progressBar_0.Location = new Point(8, 0x134);
            this.progressBar_0.Margin = new Padding(8, 3, 3, 3);
            this.progressBar_0.Name = "pbStatus";
            this.progressBar_0.Size = new Size(160, 0x13);
            this.progressBar_0.TabIndex = 7;
            this.label_0.AutoSize = true;
            this.label_0.Dock = DockStyle.Fill;
            this.label_0.Location = new Point(0xb3, 0x129);
            this.label_0.Margin = new Padding(8, 0, 3, 0);
            this.label_0.Name = "lbStatus";
            this.tableLayoutPanel_0.SetRowSpan(this.label_0, 3);
            this.label_0.Size = new Size(0x174, 0x29);
            this.label_0.TabIndex = 8;
            this.label_0.TextAlign = ContentAlignment.MiddleLeft;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewTextBoxColumn_1 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.tableLayoutPanel_0.SetColumnSpan(this.dataGridViewExcelFilter_0, 3);
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_0.Name = "dgvDocTemplates";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x293, 0x10a);
            this.dataGridViewExcelFilter_0.TabIndex = 9;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "id";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "FileName";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Наименование файла";
            this.dataGridViewFilterTextBoxColumn_0.Name = "FileName";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "Size";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Размер файла, кБ";
            this.dataGridViewFilterTextBoxColumn_1.Name = "SizeFile";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "LastChange";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Дата последнего изменения";
            this.dataGridViewFilterTextBoxColumn_2.Name = "LastChange";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.Width = 150;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "Deleted";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Deleted";
            this.dataGridViewTextBoxColumn_1.Name = "Deleted";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_2, this.toolStripSeparator_0, this.toolStripButton_1, this.toolStripSeparator_1, this.toolStripComboBox_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip1";
            this.toolStrip_0.Size = new Size(0x299, 0x19);
            this.toolStrip_0.TabIndex = 30;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "tsbAddFile";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить шаблон";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "tsbDeleteFile";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить шаблон";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.PrintPreView;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "tsbShowFile";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Отобразить шаблон";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStripComboBox_0.Name = "tscbTypeDoc";
            this.toolStripComboBox_0.Size = new Size(270, 0x19);
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.bindingSource_0.DataMember = "tR_Classifier";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
            this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
            this.backgroundWorker_1.DoWork += new DoWorkEventHandler(this.backgroundWorker_1_DoWork);
            this.backgroundWorker_1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_1_RunWorkerCompleted);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x299, 0x152);
            base.Controls.Add(this.toolStrip_0);
            base.Controls.Add(this.tableLayoutPanel_0);
            base.Name = "FormDocTamplateReference";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Справочник шаблонов";
            base.FormClosing += new FormClosingEventHandler(this.FormDocTamplateReference_FormClosing);
            base.Load += new EventHandler(this.FormDocTamplateReference_Load);
            this.tableLayoutPanel_0.ResumeLayout(false);
            this.tableLayoutPanel_0.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.dataSetGES_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                MessageBox.Show((IWin32Window) this, "Выполняется обработка данных. Пожалуйста подождите завершения.");
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DoWorkAsyncArgs argument = new DoWorkAsyncArgs(this.get_SqlSettings(), (int) ((DataRowView) this.bindingSource_0.Current)["id"], dialog.FileName);
                    this.backgroundWorker_0.RunWorkerAsync(argument);
                }
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.bool_1)
            {
                MessageBox.Show((IWin32Window) this, "Выполняется обработка данных. Пожалуйста подождите завершения.");
            }
            else if ((this.dataGridViewExcelFilter_0.SelectedRows != null) && (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0))
            {
                DoWorkAsyncArgs argument = new DoWorkAsyncArgs(this.get_SqlSettings(), (int) this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["id"].Value);
                this.backgroundWorker_1.RunWorkerAsync(argument);
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.SelectedRows != null) && (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)) && (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                try
                {
                    this.method_1("Удаление шаблона...");
                    this.sqlConnection_0 = new SqlConnection(this.get_SqlSettings().GetConnectionString());
                    this.sqlConnection_0.Open();
                    string str = this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["FileName"].Value.ToString();
                    new SqlCommand("DELETE FROM tR_DocTemplate WHERE id = " + this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["id"].Value.ToString(), this.sqlConnection_0).ExecuteNonQuery();
                    this.method_0();
                    this.method_1("Шаблон '" + str + "' удален.");
                }
                catch (Exception exception)
                {
                    this.method_1(string.Format("Ошибка: '{0}'", exception.Message));
                    if (this.sqlConnection_0 != null)
                    {
                        this.sqlConnection_0.Close();
                    }
                }
                finally
                {
                    if ((this.sqlConnection_0 != null) && (this.sqlConnection_0.State != ConnectionState.Closed))
                    {
                        this.sqlConnection_0.Close();
                    }
                }
            }
        }

        [DefaultValue(-1)]
        public int ClassifierValue
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        [CompilerGenerated]
        private sealed class Class325
        {
            public FormDocTamplateReference formDocTamplateReference_0;
            public string string_0;

            internal void method_0()
            {
                this.formDocTamplateReference_0.label_0.Text = this.string_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class326
        {
            public bool bool_0;
            public FormDocTamplateReference formDocTamplateReference_0;

            internal void method_0()
            {
                this.formDocTamplateReference_0.progressBar_0.Style = this.bool_0 ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            }
        }

        private delegate void Delegate186(string string_0);

        private delegate void Delegate187();
    }
}

