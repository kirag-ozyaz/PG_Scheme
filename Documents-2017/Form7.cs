using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

internal class Form7 : FormBase
{
    private BindingSource bindingSource_0;
    private Button button_0;
    private Button button_1;
    private DataColumn dataColumn_0;
    private DataColumn dataColumn_1;
    private DataGridView dataGridView_0;
    private DataGridView dataGridView_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataSet dataSet_0;
    private DataTable dataTable_0;
    private DataTable dataTable_1;
    private IContainer icontainer_0;
    private const string string_0 = "TypeWorkTU";

    internal Form7()
    {
        this.method_1();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form7_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            for (int i = this.dataGridView_0.Rows.Count - 2; i >= 0; i--)
            {
                if (((this.dataGridView_0[this.dataGridViewTextBoxColumn_1.Name, i].Value == null) || (this.dataGridView_0[this.dataGridViewTextBoxColumn_1.Name, i].Value == DBNull.Value)) || string.IsNullOrEmpty(this.dataGridView_0[this.dataGridViewTextBoxColumn_1.Name, i].Value.ToString()))
                {
                    this.dataGridView_0.Rows.RemoveAt(i);
                }
            }
            for (int j = this.dataGridView_1.Rows.Count - 2; j >= 0; j--)
            {
                if (((this.dataGridView_1[this.dataGridViewTextBoxColumn_0.Name, j].Value == null) || (this.dataGridView_1[this.dataGridViewTextBoxColumn_0.Name, j].Value == DBNull.Value)) || string.IsNullOrEmpty(this.dataGridView_1[this.dataGridViewTextBoxColumn_0.Name, j].Value.ToString()))
                {
                    this.dataGridView_1.Rows.RemoveAt(j);
                }
            }
            StringWriter w = new StringWriter();
            this.dataSet_0.WriteXml(new XmlTextWriter(w));
            XmlDocument document = new XmlDocument();
            string xml = w.ToString();
            document.LoadXml(xml);
            DataTable table = this.method_0();
            base.SelectSqlData(table, true, string.Format("where Module = '{0}'", "TypeWorkTU"), false);
            if (table.Rows.Count > 0)
            {
                table.Rows[0]["Settings"] = document.InnerXml;
                table.Rows[0].EndEdit();
                if (!base.UpdateSqlData(table))
                {
                    e.Cancel = true;
                }
            }
            else
            {
                DataRow row = table.NewRow();
                row["Module"] = "TypeWorkTU";
                row["settings"] = document.InnerXml;
                table.Rows.Add(row);
                if (!base.InsertSqlData(table))
                {
                    e.Cancel = true;
                }
            }
        }
    }

    private void Form7_Load(object sender, EventArgs e)
    {
        DataTable table = this.method_0();
        base.SelectSqlData(table, true, string.Format("where Module = '{0}'", "TypeWorkTU"), false);
        try
        {
            if ((table.Rows.Count > 0) && (table.Rows[0]["Settings"] != DBNull.Value))
            {
                XmlDocument node = new XmlDocument();
                node.LoadXml(table.Rows[0]["Settings"].ToString());
                XmlNodeReader reader = new XmlNodeReader(node);
                this.dataSet_0.ReadXml(reader);
                reader.Close();
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, exception.Source);
        }
    }

    private DataTable method_0()
    {
        DataTable table = new DataTable("tSettings");
        DataColumn column = table.Columns.Add("id", typeof(int));
        column.AutoIncrement = true;
        table.PrimaryKey = new DataColumn[] { column };
        table.Columns.Add("settings", typeof(string));
        table.Columns.Add("module", typeof(string));
        return table;
    }

    private void method_1()
    {
        this.icontainer_0 = new Container();
        this.dataSet_0 = new DataSet();
        this.dataTable_0 = new DataTable();
        this.dataTable_1 = new DataTable();
        this.dataColumn_0 = new DataColumn();
        this.dataColumn_1 = new DataColumn();
        this.dataGridView_0 = new DataGridView();
        this.dataGridView_1 = new DataGridView();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataSet_0.BeginInit();
        this.dataTable_0.BeginInit();
        this.dataTable_1.BeginInit();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        ((ISupportInitialize) this.dataGridView_1).BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        base.SuspendLayout();
        this.dataSet_0.DataSetName = "NewDataSet";
        DataTable[] tables = new DataTable[] { this.dataTable_0, this.dataTable_1 };
        this.dataSet_0.Tables.AddRange(tables);
        DataColumn[] columns = new DataColumn[] { this.dataColumn_0 };
        this.dataTable_0.Columns.AddRange(columns);
        this.dataTable_0.TableName = "netWork";
        DataColumn[] columnArray2 = new DataColumn[] { this.dataColumn_1 };
        this.dataTable_1.Columns.AddRange(columnArray2);
        this.dataTable_1.TableName = "clientWork";
        this.dataColumn_0.ColumnName = "Name";
        this.dataColumn_1.ColumnName = "Name";
        this.dataGridView_0.AllowUserToResizeColumns = false;
        this.dataGridView_0.AllowUserToResizeRows = false;
        this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.dataGridView_0.AutoGenerateColumns = false;
        this.dataGridView_0.BackgroundColor = SystemColors.Window;
        this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_1 };
        this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridView_0.DataSource = this.bindingSource_0;
        this.dataGridView_0.Location = new Point(0, -1);
        this.dataGridView_0.Name = "dgvNet";
        this.dataGridView_0.Size = new Size(0x27c, 0xf4);
        this.dataGridView_0.TabIndex = 0;
        this.dataGridView_1.AllowUserToResizeColumns = false;
        this.dataGridView_1.AllowUserToResizeRows = false;
        this.dataGridView_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.dataGridView_1.AutoGenerateColumns = false;
        this.dataGridView_1.BackgroundColor = SystemColors.Window;
        this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0 };
        this.dataGridView_1.Columns.AddRange(columnArray4);
        this.dataGridView_1.DataMember = "clientWork";
        this.dataGridView_1.DataSource = this.dataSet_0;
        this.dataGridView_1.Location = new Point(0, 0xef);
        this.dataGridView_1.Name = "dgvClient";
        this.dataGridView_1.Size = new Size(0x27c, 0xf4);
        this.dataGridView_1.TabIndex = 1;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(12, 0x1e9);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 2;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(550, 0x1e9);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 3;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "Name";
        this.dataGridViewTextBoxColumn_0.HeaderText = "Работы заказчика";
        this.dataGridViewTextBoxColumn_0.Name = "clientWorkDgvColumn";
        this.bindingSource_0.DataMember = "netWork";
        this.bindingSource_0.DataSource = this.dataSet_0;
        this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
        this.dataGridViewTextBoxColumn_1.HeaderText = "Работы сетевой организации";
        this.dataGridViewTextBoxColumn_1.Name = "netWorkDgvColumn";
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x27d, 0x20a);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.dataGridView_1);
        base.Controls.Add(this.dataGridView_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormReferenceTypeWork";
        this.Text = "Справочник типов работ";
        base.FormClosing += new FormClosingEventHandler(this.Form7_FormClosing);
        base.Load += new EventHandler(this.Form7_Load);
        this.dataSet_0.EndInit();
        this.dataTable_0.EndInit();
        this.dataTable_1.EndInit();
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        ((ISupportInitialize) this.dataGridView_1).EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        base.ResumeLayout(false);
    }
}

