
    using DailyReport.DataSets;
   // using Documents.Properties;
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

namespace Documents.Reports
{

/// <summary>
/// Бюллетень аварийных отключений
/// </summary>
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
        private ReportViewer reportViewer;
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
            this.panel_0 = new System.Windows.Forms.Panel();
            this.grpAct = new System.Windows.Forms.GroupBox();
            this.rBtnCrashAct = new System.Windows.Forms.RadioButton();
            this.rBtnAllAct = new System.Windows.Forms.RadioButton();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label_0 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.label_3 = new System.Windows.Forms.Label();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.rBtnPeriod = new System.Windows.Forms.RadioButton();
            this.rBtnYear = new System.Windows.Forms.RadioButton();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsBtnAddFilter = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelFilter = new System.Windows.Forms.ToolStripButton();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel_0.SuspendLayout();
            this.grpAct.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_0
            // 
            this.panel_0.Controls.Add(this.grpAct);
            this.panel_0.Controls.Add(this.panel_1);
            this.panel_0.Controls.Add(this.grpDate);
            this.panel_0.Controls.Add(this.tsMain);
            this.panel_0.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_0.Location = new System.Drawing.Point(0, 0);
            this.panel_0.Name = "panel_0";
            this.panel_0.Padding = new System.Windows.Forms.Padding(3);
            this.panel_0.Size = new System.Drawing.Size(200, 571);
            this.panel_0.TabIndex = 0;
            // 
            // grpAct
            // 
            this.grpAct.Controls.Add(this.rBtnCrashAct);
            this.grpAct.Controls.Add(this.rBtnAllAct);
            this.grpAct.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAct.Location = new System.Drawing.Point(3, 266);
            this.grpAct.Name = "grpAct";
            this.grpAct.Size = new System.Drawing.Size(194, 68);
            this.grpAct.TabIndex = 1;
            this.grpAct.TabStop = false;
            this.grpAct.Text = "Акты";
            // 
            // rBtnCrashAct
            // 
            this.rBtnCrashAct.AutoSize = true;
            this.rBtnCrashAct.Location = new System.Drawing.Point(9, 42);
            this.rBtnCrashAct.Name = "rBtnCrashAct";
            this.rBtnCrashAct.Size = new System.Drawing.Size(110, 17);
            this.rBtnCrashAct.TabIndex = 8;
            this.rBtnCrashAct.TabStop = true;
            this.rBtnCrashAct.Text = "Аварийные акты";
            this.rBtnCrashAct.UseVisualStyleBackColor = true;
            // 
            // rBtnAllAct
            // 
            this.rBtnAllAct.AutoSize = true;
            this.rBtnAllAct.Checked = true;
            this.rBtnAllAct.Location = new System.Drawing.Point(9, 19);
            this.rBtnAllAct.Name = "rBtnAllAct";
            this.rBtnAllAct.Size = new System.Drawing.Size(72, 17);
            this.rBtnAllAct.TabIndex = 7;
            this.rBtnAllAct.TabStop = true;
            this.rBtnAllAct.Text = "Все акты";
            this.rBtnAllAct.UseVisualStyleBackColor = true;
            // 
            // panel_1
            // 
            this.panel_1.Controls.Add(this.txtName);
            this.panel_1.Controls.Add(this.label_0);
            this.panel_1.Controls.Add(this.txtPost);
            this.panel_1.Controls.Add(this.label_3);
            this.panel_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1.Location = new System.Drawing.Point(3, 176);
            this.panel_1.Name = "panel_1";
            this.panel_1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel_1.Size = new System.Drawing.Size(194, 90);
            this.panel_1.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Location = new System.Drawing.Point(0, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 6;
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_0.Location = new System.Drawing.Point(0, 43);
            this.label_0.Name = "label_0";
            this.label_0.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_0.Size = new System.Drawing.Size(34, 18);
            this.label_0.TabIndex = 2;
            this.label_0.Text = "ФИО";
            // 
            // txtPost
            // 
            this.txtPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPost.Location = new System.Drawing.Point(0, 23);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(194, 20);
            this.txtPost.TabIndex = 5;
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_3.Location = new System.Drawing.Point(0, 10);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(65, 13);
            this.label_3.TabIndex = 4;
            this.label_3.Text = "Должность";
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.cmbYear);
            this.grpDate.Controls.Add(this.dtpDateEnd);
            this.grpDate.Controls.Add(this.dtpDateBegin);
            this.grpDate.Controls.Add(this.label_1);
            this.grpDate.Controls.Add(this.label_2);
            this.grpDate.Controls.Add(this.rBtnPeriod);
            this.grpDate.Controls.Add(this.rBtnYear);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(3, 28);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(194, 148);
            this.grpDate.TabIndex = 0;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Дата";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(9, 41);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(179, 21);
            this.cmbYear.TabIndex = 1;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Enabled = false;
            this.dtpDateEnd.Location = new System.Drawing.Point(34, 117);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(154, 20);
            this.dtpDateEnd.TabIndex = 4;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.Enabled = false;
            this.dtpDateBegin.Location = new System.Drawing.Point(34, 91);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(154, 20);
            this.dtpDateBegin.TabIndex = 3;
            this.dtpDateBegin.ValueChanged += new System.EventHandler(this.dtpDateBegin_ValueChanged);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(6, 119);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(22, 13);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "по:";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(6, 91);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(16, 13);
            this.label_2.TabIndex = 3;
            this.label_2.Text = "с:";
            // 
            // rBtnPeriod
            // 
            this.rBtnPeriod.AutoSize = true;
            this.rBtnPeriod.Location = new System.Drawing.Point(9, 68);
            this.rBtnPeriod.Name = "rBtnPeriod";
            this.rBtnPeriod.Size = new System.Drawing.Size(63, 17);
            this.rBtnPeriod.TabIndex = 2;
            this.rBtnPeriod.TabStop = true;
            this.rBtnPeriod.Text = "Период";
            this.rBtnPeriod.UseVisualStyleBackColor = true;
            // 
            // rBtnYear
            // 
            this.rBtnYear.AutoSize = true;
            this.rBtnYear.Checked = true;
            this.rBtnYear.Location = new System.Drawing.Point(9, 19);
            this.rBtnYear.Name = "rBtnYear";
            this.rBtnYear.Size = new System.Drawing.Size(43, 17);
            this.rBtnYear.TabIndex = 0;
            this.rBtnYear.TabStop = true;
            this.rBtnYear.Text = "Год";
            this.rBtnYear.UseVisualStyleBackColor = true;
            this.rBtnYear.CheckedChanged += new System.EventHandler(this.rBtnYear_CheckedChanged);
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAddFilter,
            this.tsBtnDelFilter});
            this.tsMain.Location = new System.Drawing.Point(3, 3);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(194, 25);
            this.tsMain.TabIndex = 9;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsBtnAddFilter
            // 
            this.tsBtnAddFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAddFilter.Image = global::DailyReport.Properties.Resources.filter;
            this.tsBtnAddFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddFilter.Name = "tsBtnAddFilter";
            this.tsBtnAddFilter.Size = new System.Drawing.Size(23, 22);
            this.tsBtnAddFilter.Text = "Применить фильтр";
            this.tsBtnAddFilter.Click += new System.EventHandler(this.tsBtnAddFilter_Click);
            // 
            // tsBtnDelFilter
            // 
            this.tsBtnDelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelFilter.Image = global::DailyReport.Properties.Resources.filter_delete;
            this.tsBtnDelFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelFilter.Name = "tsBtnDelFilter";
            this.tsBtnDelFilter.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelFilter.Text = "Сбросить фильтр";
            this.tsBtnDelFilter.Click += new System.EventHandler(this.tsBtnDelFilter_Click);
            // 
            // reportViewer_0
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(200, 0);
            this.reportViewer.Name = "rView";
            this.reportViewer.Size = new System.Drawing.Size(625, 571);
            this.reportViewer.TabIndex = 1;
            // 
            // FormReportDetectionCrash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 571);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panel_0);
            this.Name = "FormReportDetectionCrash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бюллетень аварийных отключений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReportDetectionCrash_FormClosing);
            this.Load += new System.EventHandler(this.FormReportDetectionCrash_Load);
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
            this.ResumeLayout(false);

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
            DataTable table = new dsDamage.tSettingsDataTable();
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
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Documents.RDLC.ReportEmergencyShutdown.rdlc";
            this.reportViewer.LocalReport.DataSources.Clear();
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
            this.reportViewer.LocalReport.SetParameters(parameters);
            string str = Library.ResourceReader.GetStringAssembly("ReportDetectionCrashByMonth.sql");
            string str2 = Library.ResourceReader.GetStringAssembly("ReportDetectionCrashByNetRegion.sql");
            string str3 = Library.ResourceReader.GetStringAssembly("ReportDetectionReasonCrashEquip.sql");
            string str4 = Library.ResourceReader.GetStringAssembly("ReportDetectionReasonCrash.sql");
            string str5 = Library.ResourceReader.GetStringAssembly("ReportDetectionNoAdmissKWTByNetReg.sql");
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsCrash", this.method_10(this.method_5(str))));
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsNetRegion", this.method_11(this.method_5(str2))));
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsReasonCrashEquip", this.method_5(str3)));
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsReasonCrash", this.method_5(str4)));
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsNoAdmissKWT", this.method_5(str5)));
            this.reportViewer.RefreshReport();
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
                using (SqlCommand command = new SqlCommand(Library.ResourceReader.GetStringAssembly("ReportDetectionCrashByMonth.sql"), connection))
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
                table2 = new dsDamage.tReportDetectionReasonCrashDataTable();
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
                using (SqlCommand command = new SqlCommand(Library.ResourceReader.GetStringAssembly("ReportDetectionReasonCrashEquip.sql"), connection))
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
                table2 = new dsDamage.tReportDetectionReasonCrashDataTable();
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
                using (SqlCommand command = new SqlCommand(Library.ResourceReader.GetStringAssembly("ReportDetectionReasonCrash.sql"), connection))
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
                table2 = new dsDamage.tReportDetectionReasonCrashDataTable();
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

