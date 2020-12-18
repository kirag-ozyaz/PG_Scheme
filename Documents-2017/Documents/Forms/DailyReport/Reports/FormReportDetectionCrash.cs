namespace Documents.Forms.DailyReport.Reports
{
    using Documents.Forms.DailyReport.DataSets;
    using Documents.Properties;
    using FormLbr;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    public class FormReportDetectionCrash : FormBase
    {
        private Approver approver_0;
        private bool bool_0;
        private ComboBox cmbYear;
        private DateTime dateTime_0;
        private DateTime dateTime_1;
        private DateTimePicker dtpDateEnd;
        private DateTimePicker dtpDateBegin;
        private GroupBox grpAct;
        private GroupBox grpDate;
        private IContainer components=null;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Panel panel_0;
        private Panel panel_1;
        private RadioButton rBtnCrashAct;
        private RadioButton rBtnAllAct;
        private RadioButton rBtnPeriod;
        private RadioButton rBtnYear;
        private ReportViewer reportViewer_0;
        private TextBox txtName;
        private TextBox txtPost;
        private ToolStrip tsMain;
        private ToolStripButton tsBtnAddFilter;
        private ToolStripButton tsBtnDelFilter;

        public FormReportDetectionCrash()
        {
            this.InitializeComponent();
        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpDateEnd.Value < this.dtpDateBegin.Value)
            {
                this.dtpDateBegin.Value = this.dtpDateEnd.Value;
            }
        }

        private void dtpDateBegin_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpDateBegin.Value > this.dtpDateEnd.Value)
            {
                this.dtpDateEnd.Value = this.dtpDateBegin.Value;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormReportDetectionCrash_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.method_3();
        }

        private void FormReportDetectionCrash_Load(object sender, EventArgs e)
        {
            this.method_0();
            this.method_1();
            this.method_4();
        }

        private void method_0()
        {
            this.dtpDateEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            this.dtpDateBegin.Value = new DateTime(DateTime.Now.Year, 1, 1);
            DataTable table = new DataTable();
            table.Columns.Add("year", typeof(int));
            for (int i = 0x757; i <= DateTime.Now.Year; i++)
            {
                DataRow row = table.NewRow();
                row["year"] = i;
                row.EndEdit();
                table.Rows.Add(row);
            }
            this.cmbYear.DisplayMember = "year";
            this.cmbYear.ValueMember = "year";
            this.cmbYear.DataSource = table;
            this.cmbYear.SelectedValue = DateTime.Now.Year;
        }

        private void method_1()
        {
            DataTable table = new DataTable("tSettings");
            base.SelectSqlData(table, true, "where module = 'ReportDetectApprover'", null, false, 0);
            if (table.Rows.Count > 0)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Approver));
                StringReader textReader = new StringReader(table.Rows[0]["Settings"].ToString());
                this.approver_0 = (Approver) serializer.Deserialize(textReader);
            }
            else
            {
                this.approver_0 = new Approver();
            }
            this.method_2();
        }

        private DataTable method_10(DataTable dataTable_0)
        {
            for (int i = 1; i <= 12; i++)
            {
                DataView view1 = new DataView(dataTable_0) {
                    RowFilter = string.Format("[month] = '{0}'", i)
                };
                if (view1.Count == 0)
                {
                    DataRow row = dataTable_0.NewRow();
                    row["month"] = i;
                    row.EndEdit();
                    dataTable_0.Rows.Add(row);
                }
            }
            return dataTable_0;
        }

        private DataTable method_11(DataTable dataTable_0)
        {
            DataTable table = new DataTable("tR_Classifier");
            base.SelectSqlData(table, true, "Where ParentKey = ';NetworkAreas;' and deleted = '0' and isGroup = '0'", null, false, 0);
            foreach (DataRow row in table.Rows)
            {
                DataView view1 = new DataView(dataTable_0) {
                    RowFilter = string.Format("typeNetReg = '{0}'", row["id"])
                };
                if (view1.Count == 0)
                {
                    DataRow row2 = dataTable_0.NewRow();
                    row2["typeNetReg"] = row["id"];
                    row2.EndEdit();
                    dataTable_0.Rows.Add(row2);
                }
            }
            return dataTable_0;
        }

        private void InitializeComponent()
        {
            this.panel_0 = new Panel();
            this.grpAct = new GroupBox();
            this.rBtnCrashAct = new RadioButton();
            this.rBtnAllAct = new RadioButton();
            this.panel_1 = new Panel();
            this.txtName = new TextBox();
            this.label_0 = new Label();
            this.txtPost = new TextBox();
            this.label_3 = new Label();
            this.grpDate = new GroupBox();
            this.cmbYear = new ComboBox();
            this.dtpDateEnd = new DateTimePicker();
            this.dtpDateBegin = new DateTimePicker();
            this.label_1 = new Label();
            this.label_2 = new Label();
            this.rBtnPeriod = new RadioButton();
            this.rBtnYear = new RadioButton();
            this.tsMain = new ToolStrip();
            this.tsBtnAddFilter = new ToolStripButton();
            this.tsBtnDelFilter = new ToolStripButton();
            this.reportViewer_0 = new ReportViewer();
            this.panel_0.SuspendLayout();
            this.grpAct.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.tsMain.SuspendLayout();
            base.SuspendLayout();
            this.panel_0.Controls.Add(this.grpAct);
            this.panel_0.Controls.Add(this.panel_1);
            this.panel_0.Controls.Add(this.grpDate);
            this.panel_0.Controls.Add(this.tsMain);
            this.panel_0.Dock = DockStyle.Left;
            this.panel_0.Location = new Point(0, 0);
            this.panel_0.Name = "panel1";
            this.panel_0.Padding = new Padding(3);
            this.panel_0.Size = new Size(200, 0x23b);
            this.panel_0.TabIndex = 0;
            this.grpAct.Controls.Add(this.rBtnCrashAct);
            this.grpAct.Controls.Add(this.rBtnAllAct);
            this.grpAct.Dock = DockStyle.Top;
            this.grpAct.Location = new Point(3, 0x10a);
            this.grpAct.Name = "grpAct";
            this.grpAct.Size = new Size(0xc2, 0x44);
            this.grpAct.TabIndex = 1;
            this.grpAct.TabStop = false;
            this.grpAct.Text = "Акты";
            this.rBtnCrashAct.AutoSize = true;
            this.rBtnCrashAct.Location = new Point(9, 0x2a);
            this.rBtnCrashAct.Name = "rBtnCrashAct";
            this.rBtnCrashAct.Size = new Size(110, 0x11);
            this.rBtnCrashAct.TabIndex = 8;
            this.rBtnCrashAct.TabStop = true;
            this.rBtnCrashAct.Text = "Аварийные акты";
            this.rBtnCrashAct.UseVisualStyleBackColor = true;
            this.rBtnAllAct.AutoSize = true;
            this.rBtnAllAct.Checked = true;
            this.rBtnAllAct.Location = new Point(9, 0x13);
            this.rBtnAllAct.Name = "rBtnAllAct";
            this.rBtnAllAct.Size = new Size(0x48, 0x11);
            this.rBtnAllAct.TabIndex = 7;
            this.rBtnAllAct.TabStop = true;
            this.rBtnAllAct.Text = "Все акты";
            this.rBtnAllAct.UseVisualStyleBackColor = true;
            this.panel_1.Controls.Add(this.txtName);
            this.panel_1.Controls.Add(this.label_0);
            this.panel_1.Controls.Add(this.txtPost);
            this.panel_1.Controls.Add(this.label_3);
            this.panel_1.Dock = DockStyle.Top;
            this.panel_1.Location = new Point(3, 0xb0);
            this.panel_1.Name = "panel2";
            this.panel_1.Padding = new Padding(0, 10, 0, 0);
            this.panel_1.Size = new Size(0xc2, 90);
            this.panel_1.TabIndex = 4;
            this.txtName.BackColor = SystemColors.Window;
            this.txtName.Dock = DockStyle.Top;
            this.txtName.Location = new Point(0, 0x3d);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(0xc2, 20);
            this.txtName.TabIndex = 6;
            this.label_0.AutoSize = true;
            this.label_0.Dock = DockStyle.Top;
            this.label_0.Location = new Point(0, 0x2b);
            this.label_0.Name = "label1";
            this.label_0.Padding = new Padding(0, 5, 0, 0);
            this.label_0.Size = new Size(0x22, 0x12);
            this.label_0.TabIndex = 2;
            this.label_0.Text = "ФИО";
            this.txtPost.Dock = DockStyle.Top;
            this.txtPost.Location = new Point(0, 0x17);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new Size(0xc2, 20);
            this.txtPost.TabIndex = 5;
            this.label_3.AutoSize = true;
            this.label_3.Dock = DockStyle.Top;
            this.label_3.Location = new Point(0, 10);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x41, 13);
            this.label_3.TabIndex = 4;
            this.label_3.Text = "Должность";
            this.grpDate.Controls.Add(this.cmbYear);
            this.grpDate.Controls.Add(this.dtpDateEnd);
            this.grpDate.Controls.Add(this.dtpDateBegin);
            this.grpDate.Controls.Add(this.label_1);
            this.grpDate.Controls.Add(this.label_2);
            this.grpDate.Controls.Add(this.rBtnPeriod);
            this.grpDate.Controls.Add(this.rBtnYear);
            this.grpDate.Dock = DockStyle.Top;
            this.grpDate.Location = new Point(3, 0x1c);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new Size(0xc2, 0x94);
            this.grpDate.TabIndex = 0;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Дата";
            this.cmbYear.AutoCompleteMode = AutoCompleteMode.Append;
            this.cmbYear.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new Point(9, 0x29);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new Size(0xb3, 0x15);
            this.cmbYear.TabIndex = 1;
            this.dtpDateEnd.Enabled = false;
            this.dtpDateEnd.Location = new Point(0x22, 0x75);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new Size(0x9a, 20);
            this.dtpDateEnd.TabIndex = 4;
            this.dtpDateEnd.ValueChanged += new EventHandler(this.dtpDateEnd_ValueChanged);
            this.dtpDateBegin.Enabled = false;
            this.dtpDateBegin.Location = new Point(0x22, 0x5b);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new Size(0x9a, 20);
            this.dtpDateBegin.TabIndex = 3;
            this.dtpDateBegin.ValueChanged += new EventHandler(this.dtpDateBegin_ValueChanged);
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(6, 0x77);
            this.label_1.Name = "label3";
            this.label_1.Size = new Size(0x16, 13);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "по:";
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(6, 0x5b);
            this.label_2.Name = "label2";
            this.label_2.Size = new Size(0x10, 13);
            this.label_2.TabIndex = 3;
            this.label_2.Text = "с:";
            this.rBtnPeriod.AutoSize = true;
            this.rBtnPeriod.Location = new Point(9, 0x44);
            this.rBtnPeriod.Name = "rBtnPeriod";
            this.rBtnPeriod.Size = new Size(0x3f, 0x11);
            this.rBtnPeriod.TabIndex = 2;
            this.rBtnPeriod.TabStop = true;
            this.rBtnPeriod.Text = "Период";
            this.rBtnPeriod.UseVisualStyleBackColor = true;
            this.rBtnYear.AutoSize = true;
            this.rBtnYear.Checked = true;
            this.rBtnYear.Location = new Point(9, 0x13);
            this.rBtnYear.Name = "rBtnYear";
            this.rBtnYear.Size = new Size(0x2b, 0x11);
            this.rBtnYear.TabIndex = 0;
            this.rBtnYear.TabStop = true;
            this.rBtnYear.Text = "Год";
            this.rBtnYear.UseVisualStyleBackColor = true;
            this.rBtnYear.CheckedChanged += new EventHandler(this.rBtnYear_CheckedChanged);
            this.tsMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.tsBtnAddFilter, this.tsBtnDelFilter };
            this.tsMain.Items.AddRange(toolStripItems);
            this.tsMain.Location = new Point(3, 3);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new Size(0xc2, 0x19);
            this.tsMain.TabIndex = 9;
            this.tsMain.Text = "toolStrip1";
            this.tsBtnAddFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolStripButton_0.Image = Resources.filter;
            this.tsBtnAddFilter.Image = global::Properties.Resources.filter;
            this.tsBtnAddFilter.ImageTransparentColor = Color.Magenta;
            this.tsBtnAddFilter.Name = "tsBtnAddFilter";
            this.tsBtnAddFilter.Size = new Size(0x17, 0x16);
            this.tsBtnAddFilter.Text = "Применить фильтр";
            this.tsBtnAddFilter.Click += new EventHandler(this.tsBtnAddFilter_Click);
            this.tsBtnDelFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolStripButton_1.Image = Resources.filter_delete;
            this.tsBtnDelFilter.Image = global::Properties.Resources.filter_delete;
            this.tsBtnDelFilter.ImageTransparentColor = Color.Magenta;
            this.tsBtnDelFilter.Name = "tsBtnDelFilter";
            this.tsBtnDelFilter.Size = new Size(0x17, 0x16);
            this.tsBtnDelFilter.Text = "Сбросить фильтр";
            this.tsBtnDelFilter.Click += new EventHandler(this.tsBtnDelFilter_Click);
            this.reportViewer_0.Dock = DockStyle.Fill;
            this.reportViewer_0.Location = new Point(200, 0);
            this.reportViewer_0.Name = "rView";
            this.reportViewer_0.Size = new Size(0x271, 0x23b);
            this.reportViewer_0.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x339, 0x23b);
            base.Controls.Add(this.reportViewer_0);
            base.Controls.Add(this.panel_0);
            base.Name = "FormReportDetectionCrash";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Бюллетень аварийных отключений";
            base.FormClosing += new FormClosingEventHandler(this.FormReportDetectionCrash_FormClosing);
            base.Load += new EventHandler(this.FormReportDetectionCrash_Load);
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            this.grpAct.ResumeLayout(false);
            this.grpAct.PerformLayout();
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            base.ResumeLayout(false);
        }

        private void method_2()
        {
            this.txtName.Text = this.approver_0.Name;
            this.txtPost.Text = this.approver_0.Post;
        }

        private void method_3()
        {
            this.approver_0.Name = this.txtName.Text.Trim();
            this.approver_0.Post = this.txtPost.Text.Trim();
            new XDocument();
            StringWriter writer = new StringWriter();
            new XmlSerializer(typeof(Approver)).Serialize((TextWriter) writer, this.approver_0);
            DataTable table = new DataSetDamage.tSettingsDataTable();
            base.SelectSqlData(table, true, "where module = 'ReportDetectApprover'", null, false, 0);
            if (table.Rows.Count == 0)
            {
                DataRow row = table.NewRow();
                row["Settings"] = writer.ToString();
                row["Module"] = "ReportDetectApprover";
                row.EndEdit();
                table.Rows.Add(row);
                base.InsertSqlData(table);
            }
            else
            {
                table.Rows[0]["Settings"] = writer.ToString();
                table.Rows[0].EndEdit();
                base.UpdateSqlDataOnlyChange(table);
            }
        }

        private void method_4()
        {
            this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.ReportEmergencyShutdown.rdlc";
            this.reportViewer_0.LocalReport.DataSources.Clear();
            List<ReportParameter> parameters = new List<ReportParameter> {
                new ReportParameter("post", this.txtPost.Text.Trim()),
                new ReportParameter("worker", this.txtName.Text.Trim())
            };
            this.bool_0 = this.rBtnCrashAct.Checked;
            if (this.rBtnYear.Checked)
            {
                if (this.cmbYear.SelectedValue == null)
                {
                    new ToolTip().Show("!", this.cmbYear, 10, 5, 0xbb8);
                    return;
                }
                this.dateTime_0 = new DateTime(Convert.ToInt32(this.cmbYear.SelectedValue), 1, 1);
                this.dateTime_1 = new DateTime(Convert.ToInt32(this.cmbYear.SelectedValue) + 1, 1, 1).AddSeconds(-1.0);
                parameters.Add(new ReportParameter("year", this.cmbYear.SelectedValue.ToString()));
            }
            else
            {
                this.dateTime_0 = this.dtpDateBegin.Value.Date;
                this.dateTime_1 = this.dtpDateEnd.Value.Date;
                parameters.Add(new ReportParameter("year", ""));
                parameters.Add(new ReportParameter("dateBegin", this.dateTime_0.ToString("dd.MM.yyyy")));
                parameters.Add(new ReportParameter("dateEnd", this.dateTime_1.ToString("dd.MM.yyyy")));
            }
            this.reportViewer_0.LocalReport.SetParameters(parameters);
            string str = ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDetectionCrashByMonth.sql");
            string str2 = ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDetectionCrashByNetRegion.sql");
            string str3 = ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDetectionReasonCrashEquip.sql");
            string str4 = ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDetectionReasonCrash.sql");
            string str5 = ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDetectionNoAdmissKWTByNetReg.sql");
            this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsCrash", this.method_10(this.method_5(str))));
            this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsNetRegion", this.method_11(this.method_5(str2))));
            this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsReasonCrashEquip", this.method_5(str3)));
            this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsReasonCrash", this.method_5(str4)));
            this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsNoAdmissKWT", this.method_5(str5)));
            this.reportViewer_0.RefreshReport();
        }

        private DataTable method_5(string string_0)
        {
            DataTable table2;
            SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString());
            try
            {
                connection.Open();
                if (this.bool_0)
                {
                    string_0 = string_0 + "\r\n where isCrash = '1'";
                }
                using (SqlCommand command = new SqlCommand(string_0, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = this.dateTime_0;
                    command.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTime_1;
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(command).Fill(dataTable);
                    this.method_9(dataTable);
                    table2 = dataTable;
                }
            }
            catch
            {
                connection.Close();
                table2 = new DataTable();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return table2;
        }

        private DataTable method_6()
        {
            DataTable table2;
            SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString());
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDetectionCrashByMonth.sql"), connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = this.dateTime_0;
                    command.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTime_1;
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(command).Fill(dataTable);
                    this.method_9(dataTable);
                    table2 = dataTable;
                }
            }
            catch
            {
                connection.Close();
                table2 = new DataSetDamage.tReportDetectionReasonCrashDataTable();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return table2;
        }

        private DataTable method_7()
        {
            DataTable table2;
            SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString());
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDetectionReasonCrashEquip.sql"), connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = this.dateTime_0;
                    command.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTime_1;
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(command).Fill(dataTable);
                    this.method_9(dataTable);
                    table2 = dataTable;
                }
            }
            catch
            {
                connection.Close();
                table2 = new DataSetDamage.tReportDetectionReasonCrashDataTable();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return table2;
        }

        private DataTable method_8()
        {
            DataTable table2;
            SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString());
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDetectionReasonCrash.sql"), connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = this.dateTime_0;
                    command.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTime_1;
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(command).Fill(dataTable);
                    this.method_9(dataTable);
                    table2 = dataTable;
                }
            }
            catch
            {
                connection.Close();
                table2 = new DataSetDamage.tReportDetectionReasonCrashDataTable();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return table2;
        }

        private void method_9(DataTable dataTable_0)
        {
            foreach (DataColumn column in dataTable_0.Columns)
            {
                int num;
                if (int.TryParse(column.ColumnName, out num))
                {
                    column.ColumnName = "id" + column.ColumnName;
                }
            }
        }

        private void rBtnYear_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbYear.Enabled = this.rBtnYear.Checked;
            this.dtpDateBegin.Enabled = this.dtpDateEnd.Enabled = !this.rBtnYear.Checked;
        }

        private void tsBtnAddFilter_Click(object sender, EventArgs e)
        {
            this.method_4();
        }

        private void tsBtnDelFilter_Click(object sender, EventArgs e)
        {
            this.rBtnYear.Checked = true;
            this.rBtnAllAct.Checked = true;
            this.method_0();
        }
    }
}

