namespace Documents.Forms.JournalExcavation.Reports
{
    using Constants;
    using ControlsLbr.ReportViewerRus;
    using Documents.Forms.JournalExcavation;
    using FormLbr;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormReportExcavation : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private Button button_0;
        private CheckBox checkBox_0;
        private CheckedListBox checkedListBox_0;
        private CheckedListBox checkedListBox_1;
        private CheckState checkState_0;
        private CheckState checkState_1;
        private CheckState checkState_2;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private DataSetExcavation dataSetExcavation_0;
        private DataSetExcavation dataSetExcavation_1;
        private DateTimePicker dateTimePicker_0;
        private GroupBox groupBox_0;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Panel panel_0;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus_0;
        private ToolStrip toolStrip_0;
        private ToolStripComboBox toolStripComboBox_0;

        public FormReportExcavation()
        {
            this.method_5();
            this.dateTimePicker_0.Value = DateTime.Now.Date;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (this.toolStripComboBox_0.SelectedIndex == 0)
            {
                this.method_0();
            }
            else if (this.toolStripComboBox_0.SelectedIndex == 1)
            {
                this.method_1();
            }
        }

        private void checkedListBox_1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    this.checkState_0 = e.NewValue;
                    return;

                case 1:
                    this.checkState_1 = e.NewValue;
                    return;

                case 2:
                    this.checkState_2 = e.NewValue;
                    return;
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

        private void FormReportExcavation_Load(object sender, EventArgs e)
        {
            this.toolStripComboBox_0.SelectedIndex = 0;
            base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tR_Classifier, true, "where ParentKey = ';CityRaion;UlyanovskRaion;' and isGRoup = 0 and deleted = 0 order by name ");
            foreach (DataRow row in this.dataSetExcavation_0.tR_Classifier)
            {
                this.checkedListBox_0.Items.Add(row["Name"], true);
            }
        }

        private void method_0()
        {
            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalExcavation.Reports.ReportExcavation.rdlc";
            this.reportViewerRus_0.LocalReport.DataSources.Clear();
            ReportParameter parameter = new ReportParameter("dateReport", this.dateTimePicker_0.Value.ToString());
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter("Owner", this.method_2()));
            base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.vAbnType, true, " where typeKontragent = " + 0x45b.ToString());
            string str = "";
            foreach (DataRow row in this.dataSetExcavation_0.vAbnType)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    str = str + ",";
                }
                str = str + row["idAbn"].ToString();
            }
            string str2 = string.Format("left join tj_excavationstatus sOrder on sOrder.id = (select top 1 id \r\n                                                from tj_excavationstatus \r\n                                                where idExcavation = vj_excavation.id and idType = 1 and dateChange <= '{0}'\r\n                                                order by datechange desc) \r\n                                            left join tr_classifier cOrder on cOrder.id = sOrder.idStatus \r\n                                            left join tj_excavationstatus sWork on sWork.id = (select top 1 id \r\n                                                from tj_excavationstatus \r\n                                                where idExcavation = vj_excavation.id and idType = 2 and dateChange <= '{0}'\r\n                                                order by datechange desc)\r\n                                            left join tr_classifier cStatusWork on cStatusWork.id = sWork.idStatus \r\n                                            where (cOrder.value not in (1,6) or cOrder.id is null) \r\n                                                and (cStatusWork.ParentKey <> ';Excavation;StatusWork;RealEnd;' or cStatusWork.id is null) \r\n                                                and (vj_excavation.dateBeg <= '{0}')\r\n                                                and (vj_excavation.dateEndPlanned is null or vj_excavation.dateEndPlanned >= '{0}') ", this.dateTimePicker_0.Value.ToString("yyyyMMdd"));
            if (this.checkBox_0.Checked)
            {
                str2 = str2 + " and (vj_excavation.agreed = 1) ";
            }
            if ((this.checkedListBox_0.CheckedItems.Count > 0) && (this.checkedListBox_0.CheckedItems.Count != this.checkedListBox_0.Items.Count))
            {
                string str4 = "";
                foreach (object obj2 in this.checkedListBox_0.CheckedItems)
                {
                    if (!string.IsNullOrEmpty(str4))
                    {
                        str4 = str4 + ",";
                    }
                    str4 = str4 + "'" + obj2.ToString() + "'";
                }
                str2 = str2 + " and (region in (" + str4 + ")) ";
            }
            string str3 = str2;
            if (!string.IsNullOrEmpty(str))
            {
                str2 = str2 + " and (vj_excavation.idContractor in (" + str + ")) ";
                str3 = str3 + " and (vj_excavation.idContractor not in (" + str + ")) ";
            }
            base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.vJ_Excavation, true, str2);
            base.SelectSqlData(this.dataSetExcavation_1, this.dataSetExcavation_1.vJ_Excavation, true, str3);
            this.reportViewerRus_0.LocalReport.DataSources.Add(new ReportDataSource("DataSetExc", this.dataSetExcavation_0.vJ_Excavation));
            this.reportViewerRus_0.LocalReport.DataSources.Add(new ReportDataSource("DataSetExcContractor", this.dataSetExcavation_1.vJ_Excavation));
            bool flag = this.dataSetExcavation_1.vJ_Excavation.Rows.Count == 0;
            ReportParameter parameter2 = new ReportParameter("hideContr", flag.ToString());
            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter2 };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
            ReportParameter parameter3 = new ReportParameter("JobTitle", this.comboBox_1.Text);
            ReportParameter[] parameterArray3 = new ReportParameter[] { parameter3 };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray3);
            ReportParameter parameter4 = new ReportParameter("Worker", this.comboBox_0.Text);
            ReportParameter[] parameterArray4 = new ReportParameter[] { parameter4 };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray4);
            this.reportViewerRus_0.RefreshReport();
        }

        private void method_1()
        {
            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalExcavation.Reports.ReportExcavation_ver2.rdlc";
            List<ReportParameter> parameters = new List<ReportParameter> {
                new ReportParameter("Owner", this.method_2()),
                new ReportParameter("dateReport", this.dateTimePicker_0.Value.ToString()),
                new ReportParameter("JobTitle", this.comboBox_1.Text),
                new ReportParameter("Worker", this.comboBox_0.Text)
            };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            this.reportViewerRus_0.LocalReport.DataSources.Clear();
            this.method_3(this.checkState_0, this.checkState_1, this.checkState_2);
            this.reportViewerRus_0.RefreshReport();
        }

        private string method_2()
        {
            DataTable table = new DataTable("vAbnType");
            base.SelectSqlData(table, true, string.Format("where typeKontragent = '{0}' and deleted = '0'", Convert.ToInt32((KontragentType) 0x45b)), false);
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["Name"].ToString();
            }
            return string.Empty;
        }

        private void method_3(CheckState checkState_3, CheckState checkState_4, CheckState checkState_5)
        {
            DataTable dataSourceValue = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            string str = string.Empty;
            if (checkState_3 == CheckState.Checked)
            {
                str = Class219.smethod_2("Documents.Forms.JournalExcavation.Reports.SqlScript.ExcavationWithoutGroupingAddr.sql");
            }
            else if (checkState_3 == CheckState.Unchecked)
            {
                str = Class219.smethod_2("Documents.Forms.JournalExcavation.Reports.SqlScript.ExcavationWithGroupingAddr.sql");
            }
            base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.vAbnType, true, " where typeKontragent = " + 0x45b.ToString());
            string str2 = "";
            foreach (DataRow row in this.dataSetExcavation_0.vAbnType)
            {
                if (!string.IsNullOrEmpty(str2))
                {
                    str2 = str2 + ",";
                }
                str2 = str2 + row["idAbn"].ToString();
            }
            if (this.checkBox_0.Checked)
            {
                str = str + "\r\n and (exc.agreed = 1) ";
            }
            if ((this.checkedListBox_0.CheckedItems.Count > 0) && (this.checkedListBox_0.CheckedItems.Count != this.checkedListBox_0.Items.Count))
            {
                string str4 = "";
                foreach (object obj2 in this.checkedListBox_0.CheckedItems)
                {
                    if (!string.IsNullOrEmpty(str4))
                    {
                        str4 = str4 + ",";
                    }
                    str4 = str4 + "'" + obj2.ToString() + "'";
                }
                str = str + "\r\n and (region in (" + str4 + ")) ";
            }
            if (checkState_5 == CheckState.Checked)
            {
                string str5 = str + "\r\n and exc.typeWork = 1053";
                str = str + "\r\n and (exc.typeWork <> 1053 or exc.typeWork is null)";
                this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter("hideSTP", "false"));
                table3 = this.method_4(str5);
            }
            else if (checkState_5 == CheckState.Unchecked)
            {
                this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter("hideSTP", "true"));
                table3.Clear();
            }
            string str3 = str;
            if (!string.IsNullOrEmpty(str2))
            {
                str = str + "\r\n and (exc.idContractor in (" + str2 + ")) ";
                str3 = str3 + "\r\n and (exc.idContractor not in (" + str2 + ")) ";
            }
            if (checkState_4 == CheckState.Checked)
            {
                this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter("hideContr", "false"));
                table2 = this.method_4(str3);
            }
            else if (checkState_4 == CheckState.Unchecked)
            {
                this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter("hideContr", "true"));
                table2.Clear();
            }
            dataSourceValue = this.method_4(str);
            this.reportViewerRus_0.LocalReport.DataSources.Add(new ReportDataSource("DataSetExc", dataSourceValue));
            this.reportViewerRus_0.LocalReport.DataSources.Add(new ReportDataSource("DataSetExcContractor", table2));
            this.reportViewerRus_0.LocalReport.DataSources.Add(new ReportDataSource("dsExcSTP", table3));
        }

        private DataTable method_4(string string_0)
        {
            DataTable table2;
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (SqlCommand command = new SqlCommand(string_0, connection))
                    {
                        command.CommandTimeout = 0;
                        command.Transaction = transaction;
                        command.Parameters.Add("dateBeg", SqlDbType.VarChar).Value = this.dateTimePicker_0.Value.ToString("yyyyMMdd");
                        command.Parameters.Add("dateEnd", SqlDbType.VarChar).Value = this.dateTimePicker_0.Value.ToString("yyyyMMdd");
                        new SqlDataAdapter(command).Fill(dataTable);
                    }
                    return dataTable;
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    MessageBox.Show(exception.Message, exception.Source);
                    table2 = null;
                }
                finally
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                    }
                }
            }
            return table2;
        }

        private void method_5()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormReportExcavation));
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetExcavation_0 = new DataSetExcavation();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.dataSetExcavation_1 = new DataSetExcavation();
            this.panel_0 = new Panel();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripComboBox_0 = new ToolStripComboBox();
            this.checkedListBox_1 = new CheckedListBox();
            this.groupBox_0 = new GroupBox();
            this.comboBox_0 = new ComboBox();
            this.label_1 = new Label();
            this.comboBox_1 = new ComboBox();
            this.label_2 = new Label();
            this.checkBox_0 = new CheckBox();
            this.checkedListBox_0 = new CheckedListBox();
            this.button_0 = new Button();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_0 = new Label();
            this.reportViewerRus_0 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetExcavation_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.dataSetExcavation_1.BeginInit();
            this.panel_0.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            this.groupBox_0.SuspendLayout();
            base.SuspendLayout();
            this.bindingSource_0.DataMember = "vJ_Excavation";
            this.bindingSource_0.DataSource = this.dataSetExcavation_0;
            this.dataSetExcavation_0.DataSetName = "DataSetExcavation";
            this.dataSetExcavation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.bindingSource_1.DataMember = "vJ_Excavation";
            this.bindingSource_1.DataSource = this.dataSetExcavation_1;
            this.dataSetExcavation_1.DataSetName = "DataSetExcavation";
            this.dataSetExcavation_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.panel_0.Controls.Add(this.toolStrip_0);
            this.panel_0.Controls.Add(this.checkedListBox_1);
            this.panel_0.Controls.Add(this.groupBox_0);
            this.panel_0.Controls.Add(this.checkBox_0);
            this.panel_0.Controls.Add(this.checkedListBox_0);
            this.panel_0.Controls.Add(this.button_0);
            this.panel_0.Controls.Add(this.dateTimePicker_0);
            this.panel_0.Controls.Add(this.label_0);
            this.panel_0.Dock = DockStyle.Left;
            this.panel_0.Location = new Point(0, 0);
            this.panel_0.Name = "panel1";
            this.panel_0.Size = new Size(0xac, 0x1ba);
            this.panel_0.TabIndex = 0;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripComboBox_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip1";
            this.toolStrip_0.Size = new Size(0xac, 0x19);
            this.toolStrip_0.TabIndex = 7;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
            object[] items = new object[] { "Версия 2013 г.", "Версия 2016 г." };
            this.toolStripComboBox_0.Items.AddRange(items);
            this.toolStripComboBox_0.Margin = new Padding(5, 0, 1, 0);
            this.toolStripComboBox_0.Name = "tsCBVersion";
            this.toolStripComboBox_0.Size = new Size(0x79, 0x19);
            this.toolStripComboBox_0.SelectedIndexChanged += new EventHandler(this.toolStripComboBox_0_SelectedIndexChanged);
            this.checkedListBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.checkedListBox_1.CheckOnClick = true;
            this.checkedListBox_1.FormattingEnabled = true;
            object[] objArray2 = new object[] { "Разгруппировать по адресам", "Показать подрядчиков", "СТП раскопки" };
            this.checkedListBox_1.Items.AddRange(objArray2);
            this.checkedListBox_1.Location = new Point(3, 0x130);
            this.checkedListBox_1.Name = "chListBoxVer2";
            this.checkedListBox_1.Size = new Size(0xa3, 0x31);
            this.checkedListBox_1.TabIndex = 6;
            this.checkedListBox_1.ItemCheck += new ItemCheckEventHandler(this.checkedListBox_1_ItemCheck);
            this.groupBox_0.Controls.Add(this.comboBox_0);
            this.groupBox_0.Controls.Add(this.label_1);
            this.groupBox_0.Controls.Add(this.comboBox_1);
            this.groupBox_0.Controls.Add(this.label_2);
            this.groupBox_0.Location = new Point(3, 0xc5);
            this.groupBox_0.Name = "groupBoxSign";
            this.groupBox_0.Size = new Size(0xa3, 0x65);
            this.groupBox_0.TabIndex = 5;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Подпись";
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(6, 0x48);
            this.comboBox_0.Name = "cmbWorker";
            this.comboBox_0.Size = new Size(0x97, 0x15);
            this.comboBox_0.TabIndex = 3;
            this.comboBox_0.Text = "Демченко Л.Н.";
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(9, 0x38);
            this.label_1.Name = "label3";
            this.label_1.Size = new Size(0x22, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "ФИО";
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(6, 0x20);
            this.comboBox_1.Name = "cmbJobTitle";
            this.comboBox_1.Size = new Size(0x97, 0x15);
            this.comboBox_1.TabIndex = 1;
            this.comboBox_1.Text = "Главный инженер";
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(6, 0x10);
            this.label_2.Name = "label2";
            this.label_2.Size = new Size(0x41, 13);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Должность";
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new Point(3, 0xae);
            this.checkBox_0.Name = "checkBoxAgreed";
            this.checkBox_0.Size = new Size(0x6a, 0x11);
            this.checkBox_0.TabIndex = 4;
            this.checkBox_0.Text = "Согласованные";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkedListBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.checkedListBox_0.CheckOnClick = true;
            this.checkedListBox_0.FormattingEnabled = true;
            this.checkedListBox_0.Location = new Point(3, 0x4a);
            this.checkedListBox_0.Name = "checkedListBoxRegion";
            this.checkedListBox_0.Size = new Size(0xa3, 0x5e);
            this.checkedListBox_0.TabIndex = 3;
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.Location = new Point(3, 0x197);
            this.button_0.Name = "buttonLoad";
            this.button_0.Size = new Size(0xa3, 0x17);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "Сформировать";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.Location = new Point(3, 0x30);
            this.dateTimePicker_0.Name = "dateTimePicker1";
            this.dateTimePicker_0.Size = new Size(0xa3, 20);
            this.dateTimePicker_0.TabIndex = 1;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0x20);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x5c, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "по состоянию на";
            this.reportViewerRus_0.Dock = DockStyle.Fill;
            this.reportViewerRus_0.Location = new Point(0xac, 0);
            this.reportViewerRus_0.Name = "reportViewerRus1";
            this.reportViewerRus_0.Size = new Size(0x1fc, 0x1ba);
            this.reportViewerRus_0.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(680, 0x1ba);
            base.Controls.Add(this.reportViewerRus_0);
            base.Controls.Add(this.panel_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormReportExcavation";
            this.Text = "Сведения о раскопках";
            base.Load += new EventHandler(this.FormReportExcavation_Load);
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetExcavation_0.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.dataSetExcavation_1.EndInit();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            base.ResumeLayout(false);
        }

        private void toolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.toolStripComboBox_0.SelectedIndex == 0)
            {
                this.checkedListBox_1.Enabled = false;
                this.checkedListBox_1.Visible = false;
                this.method_0();
            }
            else if (this.toolStripComboBox_0.SelectedIndex == 1)
            {
                this.checkedListBox_1.Enabled = true;
                this.checkedListBox_1.Visible = true;
                this.method_1();
            }
        }
    }
}

