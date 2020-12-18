namespace Documents
{
    using ControlsLbr.DataGridViewExcelFilter;
    using FormLbr;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormSelectAbonent : FormBase
    {
        private Button button_0;
        private Cache cache_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private FormBase formBase_0;
        public ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter GridView;
        private IContainer icontainer_0;
        private int int_0 = 50;
        private Panel panel_0;
        private ClassesDoc.ParametryColumnsDataGridView parametryColumnsDataGridView_0;
        private string string_0 = "tAbn";

        public FormSelectAbonent()
        {
            this.method_0();
            this.GridView.VirtualMode = true;
            this.GridView.ReadOnly = true;
            this.GridView.CellValueNeeded += new DataGridViewCellValueEventHandler(this.GridView_CellValueNeeded);
            base.Load += new EventHandler(this.FormSelectAbonent_Load);
            this.GridView.DataError += new DataGridViewDataErrorEventHandler(this.GridView_DataError);
            base.KeyPreview = true;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormSelectAbonent_Load(object sender, EventArgs e)
        {
            this.GridView.Columns.Clear();
            this.dataTable_0 = base.SelectSqlData("tR_Classifier", true, "where [ParentKey] = ';SKUEE;TypeAbn;' and [ISGroup] = 'false'");
            try
            {
                ArrayList listOfColumnNamesGridView = new ArrayList {
                    new ClassesDoc.ParametryColumnsDataGridView("id", "", false)
                };
                ClassesDoc.ParametryColumnsDataGridView view1 = new ClassesDoc.ParametryColumnsDataGridView {
                    Column = "CodeAbonent",
                    Name = "Код"
                };
                listOfColumnNamesGridView.Add(view1);
                listOfColumnNamesGridView.Add(new ClassesDoc.ParametryColumnsDataGridView("Name", "Наименование"));
                listOfColumnNamesGridView.Add(new ClassesDoc.ParametryColumnsDataGridView("TypeAbn", "Тип абонента", true, this.dataTable_0, "Name", "Id"));
                listOfColumnNamesGridView.Add(new ClassesDoc.ParametryColumnsDataGridView("Deleted", "", false));
                DataRetriever dataSupplier = new DataRetriever(this.get_SqlSettings(), this.string_0, listOfColumnNamesGridView);
                this.cache_0 = new Cache(dataSupplier, this.int_0);
                foreach (object obj2 in listOfColumnNamesGridView)
                {
                    DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn {
                        ReadOnly = true
                    };
                    this.GridView.Columns.Add(dataGridViewColumn);
                    if (((ClassesDoc.ParametryColumnsDataGridView) obj2).DataSource != null)
                    {
                        dataGridViewColumn.Visible = false;
                        dataGridViewColumn.Name = (string) ((ClassesDoc.ParametryColumnsDataGridView) obj2).Column;
                        DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn {
                            DataPropertyName = (string) ((ClassesDoc.ParametryColumnsDataGridView) obj2).Column
                        };
                        object[] objArray1 = new object[] { (ClassesDoc.ParametryColumnsDataGridView) obj2, dataGridViewColumn.Index };
                        column2.Tag = objArray1;
                        column2.HeaderText = ((ClassesDoc.ParametryColumnsDataGridView) obj2).Name;
                        column2.Name = (string) ((ClassesDoc.ParametryColumnsDataGridView) obj2).Column;
                        column2.Visible = true;
                        column2.Width = 150;
                        this.GridView.Columns.Add(column2);
                    }
                    else
                    {
                        dataGridViewColumn.Name = (string) ((ClassesDoc.ParametryColumnsDataGridView) obj2).Column;
                        dataGridViewColumn.HeaderText = ((ClassesDoc.ParametryColumnsDataGridView) obj2).Name;
                        dataGridViewColumn.Visible = ((ClassesDoc.ParametryColumnsDataGridView) obj2).Visible;
                    }
                }
                this.GridView.RowCount = dataSupplier.RowCount;
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection could not be established. Verify that the connection string is valid.");
                Application.Exit();
            }
            this.GridView.Select();
        }

        private void GridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClassesDoc.Parametry parametry1 = new ClassesDoc.Parametry {
                Id = this.GridView.CurrentRow.Cells["id"].Value,
                Name = this.GridView.CurrentRow.Cells["Name"].Value
            };
            this.FormParent.Tag = parametry1;
            base.Close();
        }

        private void GridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((this.GridView.Columns[e.ColumnIndex].DataPropertyName != null) && (this.GridView.Columns[e.ColumnIndex].DataPropertyName != ""))
            {
                if (this.GridView.Columns[e.ColumnIndex].Tag != null)
                {
                    this.parametryColumnsDataGridView_0 = (ClassesDoc.ParametryColumnsDataGridView) ((object[]) this.GridView.Columns[e.ColumnIndex].Tag)[0];
                    this.dataTable_1 = (DataTable) this.parametryColumnsDataGridView_0.DataSource;
                    try
                    {
                        e.Value = this.dataTable_1.Select(this.parametryColumnsDataGridView_0.ValueMember + " = " + this.GridView[3, e.RowIndex].Value)[0][this.parametryColumnsDataGridView_0.DisplayMember];
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                e.Value = this.cache_0.RetrieveElement(e.RowIndex, e.ColumnIndex);
            }
        }

        private void GridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error happened " + e.Context.ToString());
            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }
            if (e.Exception is ConstraintException)
            {
                DataGridView view1 = (DataGridView) sender;
                view1.Rows[e.RowIndex].ErrorText = "an error";
                view1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";
                e.ThrowException = false;
            }
        }

        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (((e.KeyCode == Keys.Enter) && (this.GridView.CurrentCell != null)) && !this.GridView.CurrentCell.IsInEditMode)
            {
                ClassesDoc.Parametry parametry1 = new ClassesDoc.Parametry {
                    Id = this.GridView.CurrentRow.Cells["id"].Value,
                    Name = this.GridView.CurrentRow.Cells["Name"].Value
                };
                this.FormParent.Tag = parametry1;
                base.Close();
            }
        }

        private void method_0()
        {
            this.panel_0 = new Panel();
            this.button_0 = new Button();
            this.GridView = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.panel_0.SuspendLayout();
            this.GridView.BeginInit();
            base.SuspendLayout();
            this.panel_0.Controls.Add(this.button_0);
            this.panel_0.Dock = DockStyle.Bottom;
            this.panel_0.Location = new Point(0, 0xd6);
            this.panel_0.Name = "panel1";
            this.panel_0.Size = new Size(0x185, 0x22);
            this.panel_0.TabIndex = 3;
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.button_0.DialogResult = DialogResult.Cancel;
            this.button_0.Location = new Point(0x13e, 6);
            this.button_0.Name = "btnClose";
            this.button_0.Size = new Size(0x44, 0x17);
            this.button_0.TabIndex = 13;
            this.button_0.Text = "Закрыть";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.BackgroundColor = SystemColors.Control;
            this.GridView.BorderStyle = BorderStyle.None;
            this.GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = DockStyle.Fill;
            this.GridView.Location = new Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 0x15;
            this.GridView.Size = new Size(0x185, 0xd6);
            this.GridView.TabIndex = 6;
            this.GridView.VirtualMode = true;
            this.GridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.GridView_CellMouseDoubleClick);
            this.GridView.KeyDown += new KeyEventHandler(this.GridView_KeyDown);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_0;
            base.ClientSize = new Size(0x185, 0xf8);
            base.Controls.Add(this.GridView);
            base.Controls.Add(this.panel_0);
            base.MinimizeBox = false;
            base.Name = "FormSelectAbonent";
            this.Text = "Выбор абонента...";
            this.panel_0.ResumeLayout(false);
            this.GridView.EndInit();
            base.ResumeLayout(false);
        }

        [Browsable(false)]
        public FormBase FormParent
        {
            get
            {
                return this.formBase_0;
            }
            set
            {
                this.formBase_0 = value;
            }
        }
    }
}

