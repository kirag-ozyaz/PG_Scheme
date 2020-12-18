namespace Documents.Forms.JournalCalcLoss
{
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.DataSets;
    using Documents.Forms.JournalCalcLoss.Report;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormJournalCalcLoss : FormBase
    {
        private BindingSource bindingSource_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private dsCalc dsCalc_0;
        private IContainer icontainer_0;
        private int int_0 = -1;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripDropDownButton toolStripDropDownButton_0;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;

        public FormJournalCalcLoss()
        {
            this.method_3();
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                this.int_0 = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current)["id"]);
            }
            else
            {
                this.int_0 = -1;
            }
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.toolStripButton_0.Enabled && this.toolStripButton_0.Visible) && ((e.RowIndex >= 0) && (e.ColumnIndex >= 0)))
            {
                this.toolStripButton_0_Click(sender, e);
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

        private void FormJournalCalcLoss_Load(object sender, EventArgs e)
        {
            this.method_0();
            base.SelectSqlData(this.dsCalc_0.tR_Classifier, true, "where ParentKey = ';TypeDoc;tJ_CalcLoss;' and isGroup = 0 and deleted = 0 order by name", false);
            foreach (DataRow row in this.dsCalc_0.tR_Classifier)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(row["Name"].ToString()) {
                    Tag = row["id"]
                };
                this.toolStripDropDownButton_0.DropDownItems.Add(item);
                item.Click += new EventHandler(this.method_1);
            }
        }

        private void method_0()
        {
            base.SelectSqlData(this.dsCalc_0.vJ_CalcLoss, true, "where isActive = 1 and deleted = 0 order by dateCalc desc, num desc", false);
            this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_0.Name, this.int_0.ToString(), false);
        }

        private void method_1(object sender, EventArgs e)
        {
            int typeCalc = Convert.ToInt32(((ToolStripMenuItem) sender).Tag);
            if (typeCalc == 0x4af)
            {
                FormAddEditCalcTrans trans1 = new FormAddEditCalcTrans(-1, typeCalc, -1, -1) {
                    MdiParent = base.MdiParent
                };
                trans1.set_SqlSettings(this.get_SqlSettings());
                trans1.FormClosed += new FormClosedEventHandler(this.method_2);
                trans1.Show();
            }
            else
            {
                FormAddEditCalcCable cable1 = new FormAddEditCalcCable(-1, typeCalc, -1, -1) {
                    MdiParent = base.MdiParent
                };
                cable1.set_SqlSettings(this.get_SqlSettings());
                cable1.FormClosed += new FormClosedEventHandler(this.method_2);
                cable1.Show();
            }
        }

        private void method_2(object sender, FormClosedEventArgs e)
        {
            if (((Form) sender).DialogResult == DialogResult.OK)
            {
                if (sender is FormAddEditCalcCable)
                {
                    this.int_0 = ((FormAddEditCalcCable) sender).Id;
                }
                if (sender is FormAddEditCalcTrans)
                {
                    this.int_0 = ((FormAddEditCalcTrans) sender).Id;
                }
                this.method_0();
            }
        }

        private void method_3()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalCalcLoss));
            this.toolStrip_0 = new ToolStrip();
            this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_2 = new ToolStripButton();
            this.dsCalc_0 = new dsCalc();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.toolStrip_0.SuspendLayout();
            this.dsCalc_0.BeginInit();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_0, this.toolStripButton_1, this.toolStripSeparator_1, this.toolStripButton_3, this.toolStripSeparator_0, this.toolStripButton_2 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripMain";
            this.toolStrip_0.Size = new Size(0x36c, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton_0.Image = Resources.ElementAdd;
            this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton_0.Name = "toolBtnAddCalc";
            this.toolStripDropDownButton_0.Size = new Size(0x1d, 0x16);
            this.toolStripDropDownButton_0.Text = "Добавить расчет";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementEdit;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnEditCalc";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Редактировать расчет";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementDel;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnDelCalc";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Удаление";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.refresh_16;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnRefresh";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Обновить";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.printer;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnReport";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Печать";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.dsCalc_0.DataSetName = "dsCalc";
            this.dsCalc_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dataGridViewExcelFilter_0.AlternatingRowsDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewTextBoxColumn_3, this.dataGridViewFilterTextBoxColumn_6, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewFilterTextBoxColumn_7, this.dataGridViewTextBoxColumn_7,
                this.dataGridViewCheckBoxColumn_0, this.dataGridViewCheckBoxColumn_1, this.dataGridViewFilterTextBoxColumn_8
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0x19);
            this.dataGridViewExcelFilter_0.Name = "dgvCalcLoss";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x36c, 0x14e);
            this.dataGridViewExcelFilter_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№";
            this.dataGridViewFilterTextBoxColumn_0.Name = "numDgvColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Width = 70;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idTypeCalc";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idTypeCalc";
            this.dataGridViewTextBoxColumn_1.Name = "idTypeCalcDgvColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "typeCalc";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Тип";
            this.dataGridViewFilterTextBoxColumn_1.Name = "typeCalcDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "DateCalc";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn_2.Name = "dateCalcDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.Width = 70;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "nameCalc";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Имя расчета";
            this.dataGridViewFilterTextBoxColumn_3.Name = "nameCalcDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.Width = 150;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_2.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "CodeAbonent";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Код абонента";
            this.dataGridViewFilterTextBoxColumn_4.Name = "codeAbonentDgvColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "nameAbn";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Абонент";
            this.dataGridViewFilterTextBoxColumn_5.Name = "nameAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_3.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_3.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "nameObj";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_6.Name = "nameObjDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "idAbnBalance";
            this.dataGridViewTextBoxColumn_4.HeaderText = "idAbnBalance";
            this.dataGridViewTextBoxColumn_4.Name = "idAbnBalanceDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "nameAbnBalance";
            this.dataGridViewTextBoxColumn_5.HeaderText = "nameAbnBalance";
            this.dataGridViewTextBoxColumn_5.Name = "nameAbnBalanceDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "idOwner";
            this.dataGridViewTextBoxColumn_6.HeaderText = "idOwner";
            this.dataGridViewTextBoxColumn_6.Name = "idOwnerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "nameOwner";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Пользователь";
            this.dataGridViewFilterTextBoxColumn_7.Name = "nameOwnerDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_7.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn_7.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "isActive";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "isActive";
            this.dataGridViewCheckBoxColumn_0.Name = "isActiveDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Visible = false;
            this.dataGridViewCheckBoxColumn_1.DataPropertyName = "deleted";
            this.dataGridViewCheckBoxColumn_1.HeaderText = "deleted";
            this.dataGridViewCheckBoxColumn_1.Name = "deletedDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "CoeffLosses";
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            style2.Format = "N3";
            style2.NullValue = null;
            this.dataGridViewFilterTextBoxColumn_8.DefaultCellStyle = style2;
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Коэффициент";
            this.dataGridViewFilterTextBoxColumn_8.Name = "coeffLossesDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.bindingSource_0.DataMember = "vJ_CalcLoss";
            this.bindingSource_0.DataSource = this.dsCalc_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x36c, 0x167);
            base.Controls.Add(this.dataGridViewExcelFilter_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormJournalCalcLoss";
            this.Text = "Журнал расчетов";
            base.Load += new EventHandler(this.FormJournalCalcLoss_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.dsCalc_0.EndInit();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                int typeCalc = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value);
                int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                if (typeCalc == 0x4af)
                {
                    FormAddEditCalcTrans trans1 = new FormAddEditCalcTrans(num2, typeCalc, -1, -1) {
                        MdiParent = base.MdiParent
                    };
                    trans1.set_SqlSettings(this.get_SqlSettings());
                    trans1.FormClosed += new FormClosedEventHandler(this.method_2);
                    trans1.Show();
                }
                else
                {
                    FormAddEditCalcCable cable1 = new FormAddEditCalcCable(num2, typeCalc, -1, -1) {
                        MdiParent = base.MdiParent
                    };
                    cable1.set_SqlSettings(this.get_SqlSettings());
                    cable1.FormClosed += new FormClosedEventHandler(this.method_2);
                    cable1.Show();
                }
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные записи?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string str = "";
                    foreach (DataGridViewRow row in this.dataGridViewExcelFilter_0.SelectedRows)
                    {
                        if (string.IsNullOrEmpty(str))
                        {
                            str = row.Cells[this.dataGridViewTextBoxColumn_0.Name].Value.ToString();
                        }
                        else
                        {
                            str = str + "," + row.Cells[this.dataGridViewTextBoxColumn_0.Name].Value.ToString();
                        }
                    }
                    base.SelectSqlData(this.dsCalc_0.tJ_CalcLoss, true, "where id in (" + str + ")", false);
                    foreach (dsCalc.Class392 local1 in this.dsCalc_0.tJ_CalcLoss)
                    {
                        local1["deleted"] = 1;
                        local1.EndEdit();
                    }
                    base.UpdateSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLoss);
                    this.method_0();
                    MessageBox.Show("Записи успешно удалены");
                }
            }
            else
            {
                MessageBox.Show("Выделите строки для удаления");
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if ((this.int_0 != -1) && (this.dataGridViewExcelFilter_0.CurrentRow != null))
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value) == 0x4af)
                {
                    FormReportCalcLossTrans trans1 = new FormReportCalcLossTrans(this.int_0) {
                        MdiParent = base.MdiParent
                    };
                    trans1.set_SqlSettings(this.get_SqlSettings());
                    trans1.Show();
                }
                else
                {
                    FormReportCalcLoss loss1 = new FormReportCalcLoss(this.int_0) {
                        MdiParent = base.MdiParent
                    };
                    loss1.set_SqlSettings(this.get_SqlSettings());
                    loss1.Show();
                }
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            this.method_0();
        }
    }
}

