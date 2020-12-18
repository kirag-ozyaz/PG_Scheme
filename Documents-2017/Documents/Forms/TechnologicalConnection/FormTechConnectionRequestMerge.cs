namespace Documents.Forms.TechnologicalConnection
{
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class FormTechConnectionRequestMerge : FormBase
    {
        private Button button_0;
        private Button button_1;
        private ComboBox comboBox_0;
        private IContainer icontainer_0;
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        private Label label_0;

        public FormTechConnectionRequestMerge()
        {
            this.int_0 = -1;
            this.method_0();
        }

        public FormTechConnectionRequestMerge(int idChild)
        {
            this.int_0 = -1;
            this.method_0();
            this.int_0 = idChild;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormTechConnectionRequestMerge_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if (this.comboBox_0.SelectedIndex == -1)
                {
                    MessageBox.Show("Не выбрана основная заявка");
                    e.Cancel = true;
                }
                this.Id = Convert.ToInt32(this.comboBox_0.SelectedValue);
                DataSetTechConnection connection = new DataSetTechConnection();
                base.SelectSqlData(connection.tTC_Doc, true, " where id = " + this.int_0.ToString() + " or idParent = " + this.int_0.ToString(), false);
                foreach (DataRow row in connection.tTC_Doc)
                {
                    row["TypeDoc"] = 0x4b3;
                    row["IdParent"] = this.Id;
                    row.EndEdit();
                    base.SelectSqlData(connection.tTC_DocOut, true, " where idDoc = " + row["id"].ToString(), false);
                    foreach (DataSetTechConnection.Class244 local1 in connection.tTC_DocOut)
                    {
                        local1["idDoc"] = this.Id;
                        local1.EndEdit();
                    }
                    base.UpdateSqlData(connection, connection.tTC_DocOut);
                }
                base.UpdateSqlData(connection, connection.tTC_Doc);
            }
        }

        private void FormTechConnectionRequestMerge_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable("vTC_Request");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("numDateIn", typeof(string));
            base.SelectSqlData(table, true, " where id <> " + this.int_0.ToString() + " order by numdateIn ", false);
            this.comboBox_0.DataSource = table;
            this.comboBox_0.DisplayMember = "numDateIn";
            this.comboBox_0.ValueMember = "id";
            this.comboBox_0.SelectedIndex = -1;
        }

        private void method_0()
        {
            this.label_0 = new Label();
            this.comboBox_0 = new ComboBox();
            this.button_0 = new Button();
            this.button_1 = new Button();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 9);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x60, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Основная заявка";
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(15, 0x19);
            this.comboBox_0.Name = "cmbRequest";
            this.comboBox_0.Size = new Size(270, 0x15);
            this.comboBox_0.TabIndex = 1;
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(15, 0x34);
            this.button_0.Name = "buttonOK";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "ОК";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_1.Location = new Point(210, 0x34);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 3;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_1;
            base.ClientSize = new Size(0x126, 0x54);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.comboBox_0);
            base.Controls.Add(this.label_0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormTechConnectionRequestMerge";
            this.Text = "Привязка заявки";
            base.FormClosing += new FormClosingEventHandler(this.FormTechConnectionRequestMerge_FormClosing);
            base.Load += new EventHandler(this.FormTechConnectionRequestMerge_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public int Id
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            private set
            {
                this.int_1 = value;
            }
        }
    }
}

