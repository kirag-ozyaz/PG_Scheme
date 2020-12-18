using ControlsLbr.DataGridViewExcelFilter;
using Documents.DataSets;
using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Form16 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private DataColumn dataColumn_0;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataSet dataSet_0;
    private DataSetGES dataSetGES_0;
    private DataTable dataTable_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private List<int> list_0;
    private int? nullable_0;
    private TextBox textBox_0;
    private TextBox textBox_1;

    internal Form16(int int_1, List<int> list_1 = null)
    {
        this.method_0();
        this.int_0 = int_1;
        this.list_0 = list_1;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form16_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (!this.nullable_0.HasValue)
            {
                base.DialogResult = DialogResult.Cancel;
            }
            else
            {
                int? nullable = this.nullable_0;
                int num = Convert.ToInt32(this.comboBox_0.SelectedValue);
                if (((nullable.GetValueOrDefault() == num) ? !nullable.HasValue : true) && (MessageBox.Show("Вы уверены что хотите изменить тип контрагента?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.dataSetGES_0.tAbn.Rows[0].EndEdit();
                    if (base.UpdateSqlData(this.dataSetGES_0.tAbn))
                    {
                        int? nullable2 = null;
                        switch (Convert.ToInt32(this.dataSetGES_0.tAbn.Rows[0]["TypeAbn"]))
                        {
                            case 0xce:
                                nullable2 = 0x47a;
                                break;

                            case 0xcf:
                                nullable2 = 0x47b;
                                break;

                            case 0x40d:
                                nullable2 = 0x47c;
                                break;

                            case 0x40e:
                                nullable2 = 0x47d;
                                break;
                        }
                        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                        {
                            try
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand(string.Format("update tAbnObj set typeObj = {0} where idAbn = {1}", nullable2, this.int_0), connection))
                                {
                                    command.ExecuteNonQuery();
                                }
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message, exception.Source);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
            }
        }
    }

    private void Form16_Load(object sender, EventArgs e)
    {
        if ((this.list_0 != null) && (this.list_0.Count != 0))
        {
            string str = "";
            foreach (int num in this.list_0)
            {
                if (string.IsNullOrEmpty(str))
                {
                    str = num.ToString();
                }
                else
                {
                    str = str + "," + num.ToString();
                }
            }
            base.SelectSqlData(this.dataSetGES_0.tR_Classifier, true, string.Format("where id in ({0}) order by name", str), false);
        }
        else
        {
            base.SelectSqlData(this.dataSetGES_0.tR_Classifier, true, "where ParentKey = ';SKUEE;TypeAbn;' and isGRoup = 0 and deleted = 0 order by name", false);
        }
        base.SelectSqlData(this.dataSetGES_0.tAbn, true, "where id = " + this.int_0.ToString(), false);
        if (this.dataSetGES_0.tAbn.Rows.Count > 0)
        {
            base.SelectSqlData(this.dataTable_0, true, "where idAbn = " + this.int_0.ToString(), false);
            this.nullable_0 = new int?(Convert.ToInt32(this.dataSetGES_0.tAbn.Rows[0]["TypeAbn"]));
            if (this.dataSetGES_0.tR_Classifier.Select("id = " + this.nullable_0.ToString()).Length == 0)
            {
                DataSetGES.tR_ClassifierDataTable table = new DataSetGES.tR_ClassifierDataTable();
                base.SelectSqlData(table, true, "where id = " + this.nullable_0.ToString(), false);
                if (table.Rows.Count > 0)
                {
                    this.dataSetGES_0.tR_Classifier.ImportRow(table.Rows[0]);
                    this.comboBox_0.SelectedValue = this.nullable_0.ToString();
                }
            }
        }
    }

    private void method_0()
    {
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.dataSetGES_0 = new DataSetGES();
        this.label_1 = new Label();
        this.textBox_1 = new TextBox();
        this.label_2 = new Label();
        this.comboBox_0 = new ComboBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.dataSet_0 = new DataSet();
        this.dataTable_0 = new DataTable();
        this.dataColumn_0 = new DataColumn();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataSetGES_0.BeginInit();
        this.dataGridViewExcelFilter_0.BeginInit();
        this.dataSet_0.BeginInit();
        this.dataTable_0.BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(0x17, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x1a, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Код";
        this.textBox_0.BackColor = SystemColors.Window;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tAbn.CodeAbonent", true));
        this.textBox_0.Location = new Point(12, 0x19);
        this.textBox_0.Name = "textBox1";
        this.textBox_0.ReadOnly = true;
        this.textBox_0.Size = new Size(100, 20);
        this.textBox_0.TabIndex = 1;
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(0x86, 9);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x5f, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Имя контрагента";
        this.textBox_1.BackColor = SystemColors.Window;
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tAbn.Name", true));
        this.textBox_1.Location = new Point(0x7f, 0x19);
        this.textBox_1.Name = "textBox2";
        this.textBox_1.ReadOnly = true;
        this.textBox_1.Size = new Size(0x13d, 20);
        this.textBox_1.TabIndex = 3;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0x17, 60);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x5c, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Тип контрагента";
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tAbn.TypeAbn", true));
        this.comboBox_0.DataSource = this.dataSetGES_0;
        this.comboBox_0.DisplayMember = "tR_Classifier.Name";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(15, 0x4c);
        this.comboBox_0.Name = "cmbTypeAbn";
        this.comboBox_0.Size = new Size(0x1ad, 0x15);
        this.comboBox_0.TabIndex = 5;
        this.comboBox_0.ValueMember = "tR_Classifier.Id";
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(15, 0x113);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 6;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x171, 0x113);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 7;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
        this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
        this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
        this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0 };
        this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridViewExcelFilter_0.DataMember = "vAbnObj";
        this.dataGridViewExcelFilter_0.DataSource = this.dataSet_0;
        this.dataGridViewExcelFilter_0.Location = new Point(12, 0x67);
        this.dataGridViewExcelFilter_0.Name = "dgvAbnObj";
        this.dataGridViewExcelFilter_0.ReadOnly = true;
        this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
        this.dataGridViewExcelFilter_0.Size = new Size(0x1b0, 0xa6);
        this.dataGridViewExcelFilter_0.TabIndex = 8;
        this.dataSet_0.DataSetName = "NewDataSet";
        DataTable[] tables = new DataTable[] { this.dataTable_0 };
        this.dataSet_0.Tables.AddRange(tables);
        DataColumn[] columns = new DataColumn[] { this.dataColumn_0 };
        this.dataTable_0.Columns.AddRange(columns);
        this.dataTable_0.TableName = "vAbnObj";
        this.dataColumn_0.ColumnName = "NameObj";
        this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "NameObj";
        this.dataGridViewTextBoxColumn_0.HeaderText = "Объекты";
        this.dataGridViewTextBoxColumn_0.Name = "nameObjDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x1c8, 310);
        base.Controls.Add(this.dataGridViewExcelFilter_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormChangeTypeConsumer";
        this.Text = "Тип контрагента";
        base.FormClosing += new FormClosingEventHandler(this.Form16_FormClosing);
        base.Load += new EventHandler(this.Form16_Load);
        this.dataSetGES_0.EndInit();
        this.dataGridViewExcelFilter_0.EndInit();
        this.dataSet_0.EndInit();
        this.dataTable_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

