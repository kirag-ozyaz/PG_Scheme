namespace Documents.Forms.JournalCalcLoss
{
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.DataSets;
    using Documents.Forms.JournalCalcLoss.Report;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using System.Xml;

    public class FormAddEditCalcCable : FormBase
    {
        private BindingSource bindingSource_0;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_4;
        private CheckBox checkBox_0;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataGridView dataGridView_0;
        private DataGridView dataGridView_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataSet dataSet_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DataTable dataTable_2;
        private DateTimePicker dateTimePicker_0;
        private Dictionary<int, int> dictionary_0;
        private dsCalc dsCalc_0;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private int int_5;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private RichTextBox richTextBox_0;
        private SplitContainer splitContainer_0;
        private const string string_0 = "calcLossIsolation";
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_10;
        private TextBox textBox_11;
        private TextBox textBox_12;
        private TextBox textBox_13;
        private TextBox textBox_14;
        private TextBox textBox_15;
        private TextBox textBox_16;
        private TextBox textBox_17;
        private TextBox textBox_18;
        private TextBox textBox_19;
        private TextBox textBox_2;
        private TextBox textBox_20;
        private TextBox textBox_21;
        private TextBox textBox_22;
        private TextBox textBox_23;
        private TextBox textBox_24;
        private TextBox textBox_25;
        private TextBox textBox_26;
        private TextBox textBox_27;
        private TextBox textBox_28;
        private TextBox textBox_29;
        private TextBox textBox_3;
        private TextBox textBox_30;
        private TextBox textBox_31;
        private TextBox textBox_32;
        private TextBox textBox_33;
        private TextBox textBox_34;
        private TextBox textBox_35;
        private TextBox textBox_36;
        private TextBox textBox_37;
        private TextBox textBox_38;
        private TextBox textBox_39;
        private TextBox textBox_4;
        private TextBox textBox_40;
        private TextBox textBox_41;
        private TextBox textBox_42;
        private TextBox textBox_43;
        private TextBox textBox_44;
        private TextBox textBox_45;
        private TextBox textBox_46;
        private TextBox textBox_47;
        private TextBox textBox_48;
        private TextBox textBox_49;
        private TextBox textBox_5;
        private TextBox textBox_50;
        private TextBox textBox_51;
        private TextBox textBox_52;
        private TextBox textBox_53;
        private TextBox textBox_54;
        private TextBox textBox_55;
        private TextBox textBox_56;
        private TextBox textBox_57;
        private TextBox textBox_58;
        private TextBox textBox_59;
        private TextBox textBox_6;
        private TextBox textBox_60;
        private TextBox textBox_61;
        private TextBox textBox_62;
        private TextBox textBox_7;
        private TextBox textBox_8;
        private TextBox textBox_9;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;

        public FormAddEditCalcCable()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.int_5 = -1;
            this.dictionary_0 = new Dictionary<int, int>();
            this.method_32();
            this.method_0();
        }

        public FormAddEditCalcCable(int int_6, int typeCalc, int idAbn = -1, int idAbnObj = -1)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.int_5 = -1;
            this.dictionary_0 = new Dictionary<int, int>();
            this.method_32();
            this.int_0 = int_6;
            this.int_2 = typeCalc;
            this.int_3 = this.int_5 = idAbn;
            this.int_4 = idAbnObj;
            this.method_0();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            FormTechConnectionAddAbn abn1 = new FormTechConnectionAddAbn(this.int_5, -1, true);
            abn1.add_ShowForm(new ShowFormEventHandler(this, this.method_7));
            abn1.set_SqlSettings(this.get_SqlSettings());
            abn1.MdiParent = base.MdiParent;
            abn1.FormClosed += new FormClosedEventHandler(this.method_9);
            abn1.Show();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            FormSelectCable cable1 = new FormSelectCable();
            cable1.add_ShowForm(new ShowFormEventHandler(this, this.method_7));
            cable1.set_SqlSettings(this.get_SqlSettings());
            cable1.MdiParent = base.MdiParent;
            cable1.FormClosed += new FormClosedEventHandler(this.method_10);
            cable1.Show();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (this.method_25())
            {
                this.method_31();
                if (this.Id == -1)
                {
                    this.dsCalc_0.tJ_CalcLoss.Rows[0].EndEdit();
                    this.Id = base.InsertSqlDataOneRow(this.dsCalc_0, this.dsCalc_0.tJ_CalcLoss);
                    if ((this.Id >= 0) && this.method_23())
                    {
                        this.method_24();
                        this.int_1 = base.InsertSqlDataOneRow(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossCable);
                        if (this.int_1 > 0)
                        {
                            base.DialogResult = DialogResult.OK;
                            base.Close();
                        }
                    }
                }
                else
                {
                    this.dsCalc_0.tJ_CalcLoss.Rows[0].EndEdit();
                    if (base.UpdateSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLoss) && this.method_23())
                    {
                        this.method_24();
                        if (this.int_1 == -1)
                        {
                            this.int_1 = base.InsertSqlDataOneRow(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossCable);
                            if (this.int_1 > 0)
                            {
                                base.DialogResult = DialogResult.OK;
                                base.Close();
                            }
                        }
                        else if (base.UpdateSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossCable))
                        {
                            base.DialogResult = DialogResult.OK;
                            base.Close();
                        }
                    }
                }
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            this.dsCalc_0.tJ_CalcLoss.Rows[0].EndEdit();
            this.method_24();
            FormReportCalcLoss loss1 = new FormReportCalcLoss(this.dsCalc_0.tJ_CalcLoss, this.dsCalc_0.tJ_CalcLossCable) {
                MdiParent = base.MdiParent
            };
            loss1.set_SqlSettings(this.get_SqlSettings());
            loss1.Show();
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_59.Enabled = this.checkBox_0.Checked;
        }

        private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_1.SelectedValue != null) || (this.comboBox_1.SelectedValue != DBNull.Value))
            {
                this.comboBox_1.Tag = this.int_4 = Convert.ToInt32(this.comboBox_1.SelectedValue);
            }
        }

        private void dataGridViewExcelFilter_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewLinkColumn_0.Name].Index)
            {
                this.toolStripButton_3_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.RowCount > 0) && (this.dataGridViewExcelFilter_0[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value != null)) && (e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index))
            {
                e.Value = FileInfo.IconOfFile(this.dataGridViewExcelFilter_0[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString()).ToBitmap();
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

        private void FormAddEditCalcCable_Load(object sender, EventArgs e)
        {
            this.method_1();
            this.method_27();
            if (this.Id == -1)
            {
                this.method_2();
            }
            else
            {
                base.SelectSqlData(this.dsCalc_0.tUser, true, "", false);
                base.SelectSqlData(this.dsCalc_0.tJ_CalcLoss, true, "where id = " + this.int_0.ToString(), false);
                if (this.dsCalc_0.tJ_CalcLoss.Rows.Count > 0)
                {
                    if (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value)
                    {
                        this.textBox_1.Tag = this.int_3 = Convert.ToInt32(this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"]);
                        base.SelectSqlData(this.dsCalc_0.tAbn, true, "where id = " + this.int_3.ToString(), false);
                        if (this.dsCalc_0.tAbn.Rows.Count > 0)
                        {
                            this.textBox_1.Text = this.dsCalc_0.tAbn.Rows[0]["Name"].ToString();
                        }
                        if (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnObj"] != DBNull.Value)
                        {
                            this.comboBox_1.Tag = this.int_4 = Convert.ToInt32(this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnObj"]);
                        }
                        this.method_8();
                    }
                    if (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"] != DBNull.Value)
                    {
                        this.textBox_2.Tag = this.int_5 = Convert.ToInt32(this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"]);
                        base.SelectSqlData(this.dsCalc_0.tAbn, true, "where id = " + this.int_5.ToString(), false);
                        if (this.dsCalc_0.tAbn.Rows.Count > 0)
                        {
                            this.textBox_2.Text = this.dsCalc_0.tAbn.Rows[0]["Name"].ToString();
                        }
                    }
                    base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossCable, true, " where idCalc = " + this.int_0.ToString());
                    if (this.dsCalc_0.tJ_CalcLossCable.Rows.Count == 0)
                    {
                        this.method_3();
                    }
                    else
                    {
                        this.int_1 = Convert.ToInt32(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["id"]);
                        base.SelectSqlData(this.dsCalc_0.vR_Cable, true, "where id= " + this.dsCalc_0.tJ_CalcLossCable.Rows[0]["makeupCable"].ToString(), false);
                        if (this.dsCalc_0.vR_Cable.Rows.Count > 0)
                        {
                            this.textBox_4.Text = this.dsCalc_0.vR_Cable.Rows[0]["FullName"].ToString();
                        }
                    }
                    this.method_26();
                }
                else
                {
                    this.method_2();
                }
            }
            if (this.int_2 != 0x4ae)
            {
                this.method_21();
            }
        }

        private void method_0()
        {
            this.textBox_7.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_7.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_8.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_8.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_23.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_23.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_20.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_20.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_17.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_17.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_35.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_35.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_14.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_14.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_11.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_11.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_32.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_32.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_29.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_29.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_26.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_26.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_44.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_44.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_48.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_48.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_52.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_52.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
            this.textBox_59.TextChanged += new EventHandler(this.textBox_59_TextChanged);
            this.textBox_59.KeyPress += new KeyPressEventHandler(this.textBox_59_KeyPress);
        }

        private void method_1()
        {
            this.dictionary_0.Add(6, 310);
            this.dictionary_0.Add(10, 510);
            this.dictionary_0.Add(15, 750);
            this.dictionary_0.Add(20, 0x3e8);
            this.dictionary_0.Add(0x23, 0x42e);
        }

        private void method_10(object sender, FormClosedEventArgs e)
        {
            if (((Form) sender).DialogResult == DialogResult.OK)
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["makeupCable"] = ((FormSelectCable) sender).Id;
                this.textBox_4.Text = ((FormSelectCable) sender).MakeupCable;
                if (!((FormSelectCable) sender).Resistance.HasValue)
                {
                    this.textBox_8.Text = null;
                    this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UdResistance"] = DBNull.Value;
                }
                else
                {
                    this.textBox_8.Text = ((FormSelectCable) sender).Resistance.ToString();
                    this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UdResistance"] = ((FormSelectCable) sender).Resistance;
                }
                if (!((FormSelectCable) sender).VoltageValue.HasValue)
                {
                    this.textBox_11.Text = null;
                    this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] = DBNull.Value;
                }
                else
                {
                    this.textBox_11.Text = this.method_12(Convert.ToDecimal(((FormSelectCable) sender).VoltageValue), 2).ToString();
                    this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] = this.method_12(Convert.ToDecimal(((FormSelectCable) sender).VoltageValue), 2);
                }
                if (!((FormSelectCable) sender).CrossSection.HasValue)
                {
                    this.method_11();
                }
                else
                {
                    int num2 = this.int_2;
                    if (num2 != 0x4ad)
                    {
                        if ((num2 == 0x4ae) && (this.dataTable_1.Rows.Count > 0))
                        {
                            if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value)
                            {
                                if ((Convert.ToSingle(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]) == 6f) && (this.dataTable_1.Rows[0]["Isolation6"] != DBNull.Value))
                                {
                                    this.textBox_59.Text = this.dataTable_1.Rows[0]["Isolation6"].ToString();
                                    this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = Convert.ToSingle(this.dataTable_1.Rows[0]["Isolation6"]);
                                }
                                else if ((Convert.ToSingle(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]) == 10f) && (this.dataTable_1.Rows[0]["Isolation10"] != DBNull.Value))
                                {
                                    this.textBox_59.Text = this.dataTable_1.Rows[0]["Isolation10"].ToString();
                                    this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = Convert.ToSingle(this.dataTable_1.Rows[0]["Isolation10"]);
                                }
                                else
                                {
                                    this.method_11();
                                }
                            }
                            else
                            {
                                this.method_11();
                            }
                        }
                    }
                    else
                    {
                        DataRow[] rowArray = this.dataTable_0.Select("Section = " + ((FormSelectCable) sender).CrossSection.ToString());
                        if (rowArray.Length != 0)
                        {
                            if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value)
                            {
                                if ((Convert.ToSingle(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]) == 6f) && (rowArray[0]["Isolation6"] != DBNull.Value))
                                {
                                    this.textBox_59.Text = rowArray[0]["Isolation6"].ToString();
                                    this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = Convert.ToSingle(rowArray[0]["Isolation6"]);
                                }
                                else if ((Convert.ToSingle(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]) == 10f) && (rowArray[0]["Isolation10"] != DBNull.Value))
                                {
                                    this.textBox_59.Text = rowArray[0]["Isolation10"].ToString();
                                    this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = Convert.ToSingle(rowArray[0]["Isolation10"]);
                                }
                                else
                                {
                                    this.method_11();
                                }
                            }
                            else
                            {
                                this.method_11();
                            }
                        }
                        else
                        {
                            this.method_11();
                        }
                    }
                }
            }
        }

        private void method_11()
        {
            this.textBox_59.Text = null;
            this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = DBNull.Value;
            this.textBox_56.Text = null;
            this.dsCalc_0.tJ_CalcLossCable.Rows[0]["IsolationLosses"] = DBNull.Value;
        }

        private decimal method_12(decimal decimal_0, int int_6)
        {
            if (decimal_0 == decimal.Zero)
            {
                return decimal_0;
            }
            decimal num = Math.Round(decimal_0, int_6);
            if ((int_6 < 15) && !(num != decimal.Zero))
            {
                return this.method_12(decimal_0, int_6 + 1);
            }
            return num;
        }

        private void method_13()
        {
            if ((!string.IsNullOrEmpty(this.textBox_8.Text) && !string.IsNullOrEmpty(this.textBox_7.Text)) && !string.IsNullOrEmpty(this.textBox_23.Text))
            {
                this.textBox_32.Text = this.method_12((Convert.ToDecimal(this.textBox_8.Text) * Convert.ToDecimal(this.textBox_7.Text)) / Convert.ToDecimal(this.textBox_23.Text), 5).ToString();
            }
            else
            {
                this.textBox_32.Text = null;
            }
        }

        private void method_14()
        {
            if (!string.IsNullOrEmpty(this.textBox_20.Text) && !string.IsNullOrEmpty(this.textBox_17.Text))
            {
                this.textBox_35.Text = this.method_12((0.001M * Convert.ToDecimal(this.textBox_20.Text)) / Convert.ToDecimal(this.textBox_17.Text), 5).ToString();
            }
            else
            {
                this.textBox_35.Text = null;
            }
        }

        private void method_15()
        {
            if ((!string.IsNullOrEmpty(this.textBox_35.Text) && !string.IsNullOrEmpty(this.textBox_14.Text)) && (!string.IsNullOrEmpty(this.textBox_11.Text) && !string.IsNullOrEmpty(this.textBox_32.Text)))
            {
                this.textBox_38.Text = this.method_12(((((1000M * Convert.ToDecimal(this.textBox_35.Text)) * Convert.ToDecimal(this.textBox_35.Text)) * Convert.ToDecimal(this.textBox_32.Text)) * (decimal.One + (Convert.ToDecimal(this.textBox_14.Text) * Convert.ToDecimal(this.textBox_14.Text)))) / (Convert.ToDecimal(this.textBox_11.Text) * Convert.ToDecimal(this.textBox_11.Text)), 5).ToString();
            }
            else
            {
                this.textBox_38.Text = null;
            }
        }

        private void method_16()
        {
            if ((!string.IsNullOrEmpty(this.textBox_29.Text) && !string.IsNullOrEmpty(this.textBox_26.Text)) && (!string.IsNullOrEmpty(this.textBox_38.Text) && !string.IsNullOrEmpty(this.textBox_17.Text)))
            {
                this.textBox_41.Text = this.method_12(((Convert.ToDecimal(this.textBox_26.Text) * Convert.ToDecimal(this.textBox_38.Text)) * Convert.ToDecimal(this.textBox_17.Text)) * Convert.ToDecimal(this.textBox_29.Text), 5).ToString();
            }
            else
            {
                this.textBox_41.Text = null;
            }
        }

        private void method_17()
        {
            if (!string.IsNullOrEmpty(this.textBox_44.Text) && !string.IsNullOrEmpty(this.textBox_7.Text))
            {
                this.textBox_48.Text = this.method_12(Convert.ToDecimal(this.textBox_7.Text) * Convert.ToDecimal(this.textBox_44.Text), 5).ToString();
            }
            else
            {
                this.textBox_48.Text = null;
            }
        }

        private void method_18()
        {
            if (!string.IsNullOrEmpty(this.textBox_48.Text) && !string.IsNullOrEmpty(this.textBox_41.Text))
            {
                this.textBox_52.Text = (Convert.ToDecimal(this.textBox_48.Text) + Convert.ToDecimal(this.textBox_41.Text)).ToString();
            }
            else
            {
                this.textBox_52.Text = null;
            }
        }

        private void method_19()
        {
            if (string.IsNullOrEmpty(this.textBox_52.Text))
            {
                if (!string.IsNullOrEmpty(this.textBox_41.Text) && !string.IsNullOrEmpty(this.textBox_20.Text))
                {
                    this.textBox_51.Text = this.method_12((100M * Convert.ToDecimal(this.textBox_41.Text)) / Convert.ToDecimal(this.textBox_20.Text), 3).ToString();
                }
                else
                {
                    this.textBox_51.Text = null;
                }
            }
            else if (!string.IsNullOrEmpty(this.textBox_20.Text))
            {
                this.textBox_51.Text = this.method_12((100M * Convert.ToDecimal(this.textBox_52.Text)) / Convert.ToDecimal(this.textBox_20.Text), 3).ToString();
            }
            else
            {
                this.textBox_51.Text = null;
            }
        }

        private void method_2()
        {
            base.SelectSqlData(this.dsCalc_0.tUser, true, "where Login = SYSTEM_USER", false);
            this.comboBox_0.SelectedIndex = -1;
            base.SelectSqlData(this.dsCalc_0.tR_Classifier, true, "where id = " + this.int_2.ToString(), false);
            DataRow row = this.dsCalc_0.tJ_CalcLoss.NewRow();
            row["typeCalc"] = this.int_2;
            if (this.dsCalc_0.tR_Classifier.Rows.Count > 0)
            {
                row["nameCalc"] = this.dsCalc_0.tR_Classifier.Rows[0]["name"];
            }
            row["idAbnObj"] = -1;
            row["idAbnBalance"] = -1;
            row["DateCalc"] = DateTime.Now.Date;
            if (this.dsCalc_0.tUser.Rows.Count > 0)
            {
                row["idowner"] = this.dsCalc_0.tUser.Rows[0]["idUser"];
            }
            row["isActive"] = true;
            row["deleted"] = false;
            row["tpName"] = "Источник питания: ";
            this.dsCalc_0.tJ_CalcLoss.Rows.Add(row);
            this.method_4();
            this.method_3();
        }

        private void method_20()
        {
            if ((!string.IsNullOrEmpty(this.textBox_7.Text) && !string.IsNullOrEmpty(this.textBox_59.Text)) && !string.IsNullOrEmpty(this.textBox_23.Text))
            {
                this.textBox_56.Text = (((Convert.ToDecimal(this.textBox_7.Text) * Convert.ToDecimal(this.textBox_59.Text)) * Convert.ToDecimal(this.textBox_23.Text)) * 1000M).ToString();
            }
            else
            {
                this.textBox_56.Text = null;
            }
        }

        private void method_21()
        {
            this.textBox_52.Visible = false;
            this.textBox_53.Visible = false;
            this.textBox_54.Visible = false;
            this.textBox_48.Visible = false;
            this.textBox_44.Visible = false;
            this.textBox_45.Visible = false;
            this.textBox_47.Visible = false;
            this.textBox_46.Visible = false;
            this.textBox_51.Top = 0x192;
            this.textBox_50.Top = 0x192;
            this.textBox_49.Top = 0x192;
            this.checkBox_0.Top = 0x1a5;
            this.textBox_62.Top = 0x1a5;
            this.textBox_59.Top = 440;
            this.textBox_60.Top = 440;
            this.textBox_61.Top = 440;
            this.textBox_56.Top = 460;
            this.textBox_57.Top = 460;
            this.textBox_58.Top = 460;
            this.richTextBox_0.Top = 0x1e6;
            this.label_8.Top = 0x1e6;
            this.richTextBox_0.Height = (base.Height - 0x43) - 0x1e6;
            this.MinimumSize = new Size(550, 640);
        }

        private void method_22()
        {
            this.textBox_52.Visible = true;
            this.textBox_53.Visible = true;
            this.textBox_54.Visible = true;
            this.textBox_48.Visible = true;
            this.textBox_44.Visible = true;
            this.textBox_45.Visible = true;
            this.textBox_47.Visible = true;
            this.textBox_46.Visible = true;
            this.textBox_51.Top = 0x1ce;
            this.textBox_50.Top = 0x1ce;
            this.textBox_49.Top = 0x1ce;
            this.checkBox_0.Top = 0x1e1;
            this.textBox_62.Top = 0x1e1;
            this.textBox_59.Top = 500;
            this.textBox_60.Top = 500;
            this.textBox_61.Top = 500;
            this.textBox_56.Top = 520;
            this.textBox_57.Top = 520;
            this.textBox_58.Top = 520;
            this.richTextBox_0.Top = 0x222;
            this.label_8.Top = 0x222;
            this.richTextBox_0.Height = (base.Height - 0x43) - 0x222;
            this.MinimumSize = new Size(550, 700);
        }

        private bool method_23()
        {
            try
            {
                foreach (DataRow row in this.dsCalc_0.tJ_CalcLossFile)
                {
                    if ((row.RowState != DataRowState.Deleted) && (row.RowState != DataRowState.Detached))
                    {
                        row["idCalc"] = this.int_0;
                        row.EndEdit();
                    }
                }
                base.InsertSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossFile);
                base.UpdateSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossFile);
                base.DeleteSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossFile);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
                return false;
            }
        }

        private void method_24()
        {
            this.dsCalc_0.tJ_CalcLossCable.Rows[0]["idCalc"] = this.int_0;
            if (string.IsNullOrEmpty(this.textBox_59.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["coeffIsolation"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["coeffIsolation"] = Convert.ToDecimal(this.textBox_59.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_56.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["isolationlosses"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["isolationlosses"] = Convert.ToDecimal(this.textBox_56.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_8.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UdResistance"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UdResistance"] = Convert.ToDecimal(this.textBox_8.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_11.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] = this.textBox_11.Text;
            }
            if (string.IsNullOrEmpty(this.textBox_7.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["lenghtCable"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["lenghtCable"] = Convert.ToDecimal(this.textBox_7.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_20.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["consumption"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["consumption"] = this.textBox_20.Text;
            }
            if (string.IsNullOrEmpty(this.textBox_17.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["period"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["period"] = this.textBox_17.Text;
            }
            if (string.IsNullOrEmpty(this.textBox_14.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"] = Convert.ToDecimal(this.textBox_14.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_29.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"] = Convert.ToDecimal(this.textBox_29.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_26.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffDifferences"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffDifferences"] = Convert.ToDecimal(this.textBox_26.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_23.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CountChain"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CountChain"] = this.textBox_23.Text;
            }
            if (string.IsNullOrEmpty(this.textBox_32.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["ActiveResistance"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["ActiveResistance"] = Convert.ToDecimal(this.textBox_32.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_38.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"] = Convert.ToDecimal(this.textBox_38.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_35.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadAverage"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadAverage"] = Convert.ToDecimal(this.textBox_35.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_41.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadLosses"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadLosses"] = Convert.ToDecimal(this.textBox_41.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_44.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UnitYearLoss"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UnitYearLoss"] = Convert.ToDecimal(this.textBox_44.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_48.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["YearLoss"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["YearLoss"] = Convert.ToDecimal(this.textBox_48.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_52.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SumLoadLosses"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SumLoadLosses"] = Convert.ToDecimal(this.textBox_52.Text);
            }
            if (string.IsNullOrEmpty(this.textBox_51.Text))
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffLosses"] = DBNull.Value;
            }
            else
            {
                this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffLosses"] = Convert.ToDecimal(this.textBox_51.Text);
            }
            this.dsCalc_0.tJ_CalcLossCable.Rows[0].EndEdit();
        }

        private bool method_25()
        {
            if (this.comboBox_1.SelectedIndex < 0)
            {
                MessageBox.Show("Не указан объект абонента");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox_2.Text))
            {
                MessageBox.Show("Не указана балансовая принадлежность");
                return false;
            }
            return true;
        }

        private void method_26()
        {
            base.SelectSqlData(this.dsCalc_0.tJ_CalcLossFile, true, " where idCalc = " + this.int_0.ToString(), false);
        }

        private void method_27()
        {
            base.SelectSqlData(this.dataTable_2, true, " where Module = 'calcLossIsolation'", false);
            if ((this.dataTable_2.Rows.Count > 0) && (this.dataTable_2.Rows[0]["settings"] != DBNull.Value))
            {
                XmlDocument document = new XmlDocument();
                try
                {
                    document.LoadXml(this.dataTable_2.Rows[0]["Settings"].ToString());
                    XmlNode node = document.SelectSingleNode("Isolation");
                    this.dataTable_0.Clear();
                    foreach (XmlNode node2 in node.SelectSingleNode("dtKLIsolation").SelectNodes("Rows"))
                    {
                        object[] values = new object[] { node2.Attributes["Section"].Value, node2.Attributes["Isolation6"].Value, node2.Attributes["Isolation10"].Value };
                        this.dataTable_0.Rows.Add(values);
                    }
                    if (this.dataTable_0.Rows.Count == 0)
                    {
                        this.method_29();
                    }
                    this.dataTable_1.Clear();
                    foreach (XmlNode node3 in node.SelectSingleNode("dtVLIsolation").SelectNodes("Rows"))
                    {
                        object[] objArray2 = new object[] { node3.Attributes["Isolation6"].Value, node3.Attributes["Isolation10"].Value };
                        this.dataTable_1.Rows.Add(objArray2);
                    }
                    if (this.dataTable_1.Rows.Count == 0)
                    {
                        this.method_30();
                    }
                }
                catch
                {
                    this.method_28();
                }
            }
            else
            {
                this.method_28();
            }
        }

        private void method_28()
        {
            this.method_29();
            this.method_30();
        }

        private void method_29()
        {
            this.dataTable_0.Clear();
            object[] values = new object[] { 10, 0.14, 0.33 };
            this.dataTable_0.Rows.Add(values);
            object[] objArray2 = new object[] { 0x10, 0.17, 0.37 };
            this.dataTable_0.Rows.Add(objArray2);
            object[] objArray3 = new object[] { 0x19, 0.26, 0.55 };
            this.dataTable_0.Rows.Add(objArray3);
            object[] objArray4 = new object[] { 0x23, 0.29, 0.68 };
            this.dataTable_0.Rows.Add(objArray4);
            object[] objArray5 = new object[] { 50, 0.33, 0.75 };
            this.dataTable_0.Rows.Add(objArray5);
            object[] objArray6 = new object[] { 70, 0.42, 0.86 };
            this.dataTable_0.Rows.Add(objArray6);
            object[] objArray7 = new object[] { 0x5f, 0.55, 0.99 };
            this.dataTable_0.Rows.Add(objArray7);
            object[] objArray8 = new object[] { 120, 0.6, 1.08 };
            this.dataTable_0.Rows.Add(objArray8);
            object[] objArray9 = new object[] { 150, 0.67, 1.17 };
            this.dataTable_0.Rows.Add(objArray9);
            object[] objArray10 = new object[] { 0xb9, 0.74, 1.28 };
            this.dataTable_0.Rows.Add(objArray10);
            object[] objArray11 = new object[] { 240, 0.83, 1.67 };
            this.dataTable_0.Rows.Add(objArray11);
        }

        private void method_3()
        {
            DataRow row = this.dsCalc_0.tJ_CalcLossCable.NewRow();
            row["idCalc"] = -1;
            row["makeupCable"] = -1;
            row["CoeffPowerREactive"] = 0.6;
            row["CountChain"] = 1;
            row["SquareCoeffFromGraph"] = 1.33;
            row["CoeffDifferences"] = 0.99;
            this.dsCalc_0.tJ_CalcLossCable.Rows.Add(row);
        }

        private void method_30()
        {
            this.dataTable_1.Clear();
            object[] values = new object[] { 0.31, 0.51 };
            this.dataTable_1.Rows.Add(values);
        }

        private void method_31()
        {
            if (this.dataTable_2 != null)
            {
                XmlDocument document = new XmlDocument();
                XmlNode newChild = document.CreateElement("Isolation");
                document.AppendChild(newChild);
                XmlNode node2 = document.CreateElement("dtKLIsolation");
                newChild.AppendChild(node2);
                foreach (DataRow row in this.dataTable_0.Rows)
                {
                    XmlNode node4 = document.CreateElement("Rows");
                    node2.AppendChild(node4);
                    XmlAttribute node = document.CreateAttribute("Section");
                    node.Value = row["Section"].ToString();
                    node4.Attributes.Append(node);
                    node = document.CreateAttribute("Isolation6");
                    node.Value = row["Isolation6"].ToString();
                    node4.Attributes.Append(node);
                    node = document.CreateAttribute("Isolation10");
                    node.Value = row["isolation10"].ToString();
                    node4.Attributes.Append(node);
                }
                XmlNode node3 = document.CreateElement("dtVLIsolation");
                newChild.AppendChild(node3);
                foreach (DataRow row2 in this.dataTable_1.Rows)
                {
                    XmlNode node5 = document.CreateElement("Rows");
                    node3.AppendChild(node5);
                    XmlAttribute attribute2 = document.CreateAttribute("Isolation6");
                    attribute2.Value = row2["Isolation6"].ToString();
                    node5.Attributes.Append(attribute2);
                    attribute2 = document.CreateAttribute("Isolation10");
                    attribute2.Value = row2["isolation10"].ToString();
                    node5.Attributes.Append(attribute2);
                }
                if (this.dataTable_2.Rows.Count == 0)
                {
                    DataRow row3 = this.dataTable_2.NewRow();
                    row3["settings"] = document.InnerXml;
                    row3["module"] = "calcLossIsolation";
                    this.dataTable_2.Rows.Add(row3);
                    base.InsertSqlData(this.dataTable_2);
                    this.method_27();
                }
                else
                {
                    this.dataTable_2.Rows[0]["Settings"] = document.InnerXml;
                    this.dataTable_2.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataTable_2);
                }
            }
        }

        private void method_32()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormAddEditCalcCable));
            this.label_0 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.dsCalc_0 = new dsCalc();
            this.label_1 = new Label();
            this.comboBox_0 = new ComboBox();
            this.label_2 = new Label();
            this.textBox_0 = new TextBox();
            this.comboBox_1 = new ComboBox();
            this.label_3 = new Label();
            this.textBox_1 = new TextBox();
            this.label_4 = new Label();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.textBox_2 = new TextBox();
            this.label_5 = new Label();
            this.button_0 = new Button();
            this.label_6 = new Label();
            this.textBox_3 = new TextBox();
            this.label_7 = new Label();
            this.textBox_4 = new TextBox();
            this.button_1 = new Button();
            this.textBox_5 = new TextBox();
            this.textBox_6 = new TextBox();
            this.textBox_7 = new TextBox();
            this.textBox_8 = new TextBox();
            this.textBox_9 = new TextBox();
            this.textBox_10 = new TextBox();
            this.textBox_11 = new TextBox();
            this.textBox_12 = new TextBox();
            this.textBox_13 = new TextBox();
            this.textBox_14 = new TextBox();
            this.textBox_15 = new TextBox();
            this.textBox_16 = new TextBox();
            this.textBox_17 = new TextBox();
            this.textBox_18 = new TextBox();
            this.textBox_19 = new TextBox();
            this.textBox_20 = new TextBox();
            this.textBox_21 = new TextBox();
            this.textBox_22 = new TextBox();
            this.textBox_23 = new TextBox();
            this.textBox_24 = new TextBox();
            this.textBox_25 = new TextBox();
            this.textBox_26 = new TextBox();
            this.textBox_27 = new TextBox();
            this.textBox_28 = new TextBox();
            this.textBox_29 = new TextBox();
            this.textBox_30 = new TextBox();
            this.textBox_31 = new TextBox();
            this.button_2 = new Button();
            this.textBox_32 = new TextBox();
            this.textBox_33 = new TextBox();
            this.textBox_34 = new TextBox();
            this.textBox_35 = new TextBox();
            this.textBox_36 = new TextBox();
            this.textBox_37 = new TextBox();
            this.textBox_38 = new TextBox();
            this.textBox_39 = new TextBox();
            this.textBox_40 = new TextBox();
            this.textBox_41 = new TextBox();
            this.textBox_42 = new TextBox();
            this.textBox_43 = new TextBox();
            this.textBox_44 = new TextBox();
            this.textBox_45 = new TextBox();
            this.textBox_46 = new TextBox();
            this.textBox_47 = new TextBox();
            this.textBox_48 = new TextBox();
            this.textBox_49 = new TextBox();
            this.textBox_50 = new TextBox();
            this.textBox_51 = new TextBox();
            this.textBox_52 = new TextBox();
            this.textBox_53 = new TextBox();
            this.textBox_54 = new TextBox();
            this.button_3 = new Button();
            this.richTextBox_0 = new RichTextBox();
            this.label_8 = new Label();
            this.button_4 = new Button();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.textBox_56 = new TextBox();
            this.textBox_57 = new TextBox();
            this.textBox_58 = new TextBox();
            this.textBox_59 = new TextBox();
            this.textBox_60 = new TextBox();
            this.textBox_61 = new TextBox();
            this.checkBox_0 = new CheckBox();
            this.textBox_62 = new TextBox();
            this.textBox_55 = new TextBox();
            this.label_9 = new Label();
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.tabPage_2 = new TabPage();
            this.splitContainer_0 = new SplitContainer();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataTable_1 = new DataTable();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataTable_2 = new DataTable();
            this.dataColumn_5 = new DataColumn();
            this.dataColumn_6 = new DataColumn();
            this.dataColumn_7 = new DataColumn();
            this.dataGridView_1 = new DataGridView();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dsCalc_0.BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.toolStrip_1.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.dataTable_1.BeginInit();
            this.dataTable_2.BeginInit();
            ((ISupportInitialize) this.dataGridView_1).BeginInit();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 14);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(90, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Дата документа";
            this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dsCalc_0, "tJ_CalcLoss.DateCalc", true));
            this.dateTimePicker_0.Location = new Point(0x6c, 12);
            this.dateTimePicker_0.Name = "dateTimePickerDateCalc";
            this.dateTimePicker_0.Size = new Size(0xa5, 20);
            this.dateTimePicker_0.TabIndex = 1;
            this.dsCalc_0.DataSetName = "dsCalc";
            this.dsCalc_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0x1a1, 14);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(80, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Пользователь";
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dsCalc_0, "tJ_CalcLoss.idOwner", true));
            this.comboBox_0.DataSource = this.dsCalc_0;
            this.comboBox_0.DisplayMember = "tUser.Name";
            this.comboBox_0.Enabled = false;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x1f7, 11);
            this.comboBox_0.Name = "cmbOwner";
            this.comboBox_0.Size = new Size(0xf9, 0x15);
            this.comboBox_0.TabIndex = 3;
            this.comboBox_0.ValueMember = "tUser.IDUser";
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0x29);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x48, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Имя расчета";
            this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLoss.nameCalc", true));
            this.textBox_0.Location = new Point(0x6c, 0x26);
            this.textBox_0.Name = "txtNameCalc";
            this.textBox_0.Size = new Size(0x284, 20);
            this.textBox_0.TabIndex = 5;
            this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_1.DataBindings.Add(new Binding("Tag", this.dsCalc_0, "tJ_CalcLoss.idAbnObj", true));
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x6c, 0x4c);
            this.comboBox_1.Name = "cmbAbnObj";
            this.comboBox_1.Size = new Size(0x269, 0x15);
            this.comboBox_1.TabIndex = 0x16;
            this.comboBox_1.SelectedValueChanged += new EventHandler(this.comboBox_1_SelectedValueChanged);
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(12, 0x4f);
            this.label_3.Name = "label5";
            this.label_3.Size = new Size(0x2d, 13);
            this.label_3.TabIndex = 0x15;
            this.label_3.Text = "Объект";
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_1.BackColor = SystemColors.Window;
            this.textBox_1.DataBindings.Add(new Binding("Tag", this.dsCalc_0, "tJ_CalcLoss.idAbn", true));
            this.textBox_1.Location = new Point(0x6c, 0x39);
            this.textBox_1.Name = "txtAbn";
            this.textBox_1.ReadOnly = true;
            this.textBox_1.Size = new Size(0x269, 20);
            this.textBox_1.TabIndex = 20;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(12, 60);
            this.label_4.Name = "label4";
            this.label_4.Size = new Size(0x31, 13);
            this.label_4.TabIndex = 0x13;
            this.label_4.Text = "Абонент";
            this.toolStrip_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.toolStrip_0.Dock = DockStyle.None;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0x2d7, 0x41);
            this.toolStrip_0.Name = "toolStripAbnObj";
            this.toolStrip_0.Size = new Size(0x1a, 0x19);
            this.toolStrip_0.TabIndex = 0x17;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.partners;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnContractor";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Выбрать контрагента";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_2.BackColor = SystemColors.Window;
            this.textBox_2.DataBindings.Add(new Binding("Tag", this.dsCalc_0, "tJ_CalcLoss.idAbnBalance", true));
            this.textBox_2.Location = new Point(0x6c, 0x5f);
            this.textBox_2.Name = "txtAbnBalance";
            this.textBox_2.ReadOnly = true;
            this.textBox_2.Size = new Size(0x269, 20);
            this.textBox_2.TabIndex = 0x18;
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(12, 0x62);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x2c, 13);
            this.label_5.TabIndex = 0x19;
            this.label_5.Text = "Баланс";
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.button_0.Location = new Point(0x2d6, 0x5f);
            this.button_0.Name = "buttonAbnBalance";
            this.button_0.Size = new Size(0x1a, 20);
            this.button_0.TabIndex = 0x1a;
            this.button_0.Text = "...";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(12, 0x75);
            this.label_6.Name = "label7";
            this.label_6.Size = new Size(0x44, 13);
            this.label_6.TabIndex = 0x1b;
            this.label_6.Text = "Подстанции";
            this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_3.BackColor = SystemColors.Window;
            this.textBox_3.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLoss.tpName", true));
            this.textBox_3.Location = new Point(0x6c, 0x72);
            this.textBox_3.Name = "txtTPName";
            this.textBox_3.Size = new Size(0x284, 20);
            this.textBox_3.TabIndex = 0x1c;
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(12, 0x88);
            this.label_7.Name = "label8";
            this.label_7.Size = new Size(0x55, 13);
            this.label_7.TabIndex = 0x1d;
            this.label_7.Text = "Марка провода";
            this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_4.BackColor = SystemColors.Window;
            this.textBox_4.DataBindings.Add(new Binding("Tag", this.dsCalc_0, "tJ_CalcLossCable.makeupCable", true));
            this.textBox_4.Location = new Point(0x6c, 0x84);
            this.textBox_4.Name = "txtMakeupCable";
            this.textBox_4.ReadOnly = true;
            this.textBox_4.Size = new Size(0x269, 20);
            this.textBox_4.TabIndex = 30;
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.button_1.Location = new Point(0x2d6, 0x84);
            this.button_1.Name = "buttonMakeupCable";
            this.button_1.Size = new Size(0x1a, 20);
            this.button_1.TabIndex = 0x1f;
            this.button_1.Text = "...";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.textBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_5.BackColor = SystemColors.ControlLight;
            this.textBox_5.Location = new Point(15, 0x9e);
            this.textBox_5.Name = "textBox1";
            this.textBox_5.ReadOnly = true;
            this.textBox_5.Size = new Size(0x223, 20);
            this.textBox_5.TabIndex = 0x21;
            this.textBox_5.TabStop = false;
            this.textBox_5.Text = "Длина линии";
            this.textBox_6.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_6.BackColor = SystemColors.ControlLight;
            this.textBox_6.Location = new Point(0x231, 0x9e);
            this.textBox_6.Name = "textBox2";
            this.textBox_6.ReadOnly = true;
            this.textBox_6.Size = new Size(100, 20);
            this.textBox_6.TabIndex = 0x22;
            this.textBox_6.TabStop = false;
            this.textBox_6.Text = "L, км";
            this.textBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_7.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.lenghtCable", true));
            this.textBox_7.Location = new Point(660, 0x9e);
            this.textBox_7.Name = "txtLineLenght";
            this.textBox_7.Size = new Size(0x5d, 20);
            this.textBox_7.TabIndex = 0x23;
            this.textBox_7.TextAlign = HorizontalAlignment.Right;
            this.textBox_8.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_8.BackColor = SystemColors.Window;
            this.textBox_8.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.UdResistance", true));
            this.textBox_8.Location = new Point(660, 0xb1);
            this.textBox_8.Name = "txtUdActiveResistance";
            this.textBox_8.Size = new Size(0x5d, 20);
            this.textBox_8.TabIndex = 0x26;
            this.textBox_8.TextAlign = HorizontalAlignment.Right;
            this.textBox_9.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_9.BackColor = SystemColors.ControlLight;
            this.textBox_9.Location = new Point(0x231, 0xb1);
            this.textBox_9.Name = "textBox4";
            this.textBox_9.ReadOnly = true;
            this.textBox_9.Size = new Size(100, 20);
            this.textBox_9.TabIndex = 0x25;
            this.textBox_9.TabStop = false;
            this.textBox_9.Text = "r0, Ом/км";
            this.textBox_10.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_10.BackColor = SystemColors.ControlLight;
            this.textBox_10.Location = new Point(15, 0xb1);
            this.textBox_10.Name = "textBox5";
            this.textBox_10.ReadOnly = true;
            this.textBox_10.Size = new Size(0x223, 20);
            this.textBox_10.TabIndex = 0x24;
            this.textBox_10.TabStop = false;
            this.textBox_10.Text = "Удельное активное сопротивление линии на 1 км провода";
            this.textBox_11.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_11.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.Voltage", true));
            this.textBox_11.Location = new Point(660, 0xc3);
            this.textBox_11.Name = "txtVoltageValue";
            this.textBox_11.Size = new Size(0x5d, 20);
            this.textBox_11.TabIndex = 0x29;
            this.textBox_11.TextAlign = HorizontalAlignment.Right;
            this.textBox_11.TextChanged += new EventHandler(this.textBox_11_TextChanged);
            this.textBox_12.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_12.BackColor = SystemColors.ControlLight;
            this.textBox_12.Location = new Point(0x231, 0xc3);
            this.textBox_12.Name = "textBox7";
            this.textBox_12.ReadOnly = true;
            this.textBox_12.Size = new Size(100, 20);
            this.textBox_12.TabIndex = 40;
            this.textBox_12.TabStop = false;
            this.textBox_12.Text = "Uср, кВ";
            this.textBox_13.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_13.BackColor = SystemColors.ControlLight;
            this.textBox_13.Location = new Point(15, 0xc3);
            this.textBox_13.Name = "textBox8";
            this.textBox_13.ReadOnly = true;
            this.textBox_13.Size = new Size(0x223, 20);
            this.textBox_13.TabIndex = 0x27;
            this.textBox_13.TabStop = false;
            this.textBox_13.Text = "Среднее напряжение линии";
            this.textBox_14.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_14.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.CoeffPowerREactive", true));
            this.textBox_14.Location = new Point(660, 250);
            this.textBox_14.Name = "txtCoeffPowerReactive";
            this.textBox_14.Size = new Size(0x5d, 20);
            this.textBox_14.TabIndex = 50;
            this.textBox_14.TextAlign = HorizontalAlignment.Right;
            this.textBox_15.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_15.BackColor = SystemColors.ControlLight;
            this.textBox_15.Location = new Point(0x231, 250);
            this.textBox_15.Name = "textBox10";
            this.textBox_15.ReadOnly = true;
            this.textBox_15.Size = new Size(100, 20);
            this.textBox_15.TabIndex = 0x31;
            this.textBox_15.TabStop = false;
            this.textBox_15.Text = "tg φ";
            this.textBox_16.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_16.BackColor = SystemColors.ControlLight;
            this.textBox_16.Location = new Point(15, 250);
            this.textBox_16.Name = "textBox11";
            this.textBox_16.ReadOnly = true;
            this.textBox_16.Size = new Size(0x223, 20);
            this.textBox_16.TabIndex = 0x30;
            this.textBox_16.TabStop = false;
            this.textBox_16.Text = "Коэффициент реактивной мощности";
            this.textBox_17.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_17.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.period", true));
            this.textBox_17.Location = new Point(660, 0xe8);
            this.textBox_17.Name = "txtPeriod";
            this.textBox_17.Size = new Size(0x5d, 20);
            this.textBox_17.TabIndex = 0x2f;
            this.textBox_17.TextAlign = HorizontalAlignment.Right;
            this.textBox_18.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_18.BackColor = SystemColors.ControlLight;
            this.textBox_18.Location = new Point(0x231, 0xe8);
            this.textBox_18.Name = "textBox13";
            this.textBox_18.ReadOnly = true;
            this.textBox_18.Size = new Size(100, 20);
            this.textBox_18.TabIndex = 0x2e;
            this.textBox_18.TabStop = false;
            this.textBox_18.Text = "Т, час";
            this.textBox_19.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_19.BackColor = SystemColors.ControlLight;
            this.textBox_19.Location = new Point(15, 0xe8);
            this.textBox_19.Name = "textBox14";
            this.textBox_19.ReadOnly = true;
            this.textBox_19.Size = new Size(0x223, 20);
            this.textBox_19.TabIndex = 0x2d;
            this.textBox_19.TabStop = false;
            this.textBox_19.Text = "Базовый (расчетный) период";
            this.textBox_20.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_20.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.consumption", true));
            this.textBox_20.Location = new Point(660, 0xd5);
            this.textBox_20.Name = "txtConsumtion";
            this.textBox_20.Size = new Size(0x5d, 20);
            this.textBox_20.TabIndex = 0x2c;
            this.textBox_20.TextAlign = HorizontalAlignment.Right;
            this.textBox_21.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_21.BackColor = SystemColors.ControlLight;
            this.textBox_21.Location = new Point(0x231, 0xd5);
            this.textBox_21.Name = "textBox16";
            this.textBox_21.ReadOnly = true;
            this.textBox_21.Size = new Size(100, 20);
            this.textBox_21.TabIndex = 0x2b;
            this.textBox_21.TabStop = false;
            this.textBox_21.Text = "Wт, кВт*ч";
            this.textBox_22.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_22.BackColor = SystemColors.ControlLight;
            this.textBox_22.Location = new Point(15, 0xd5);
            this.textBox_22.Name = "textBox17";
            this.textBox_22.ReadOnly = true;
            this.textBox_22.Size = new Size(0x223, 20);
            this.textBox_22.TabIndex = 0x2a;
            this.textBox_22.TabStop = false;
            this.textBox_22.Text = "Потребление активной электроэнергии за базовый период по счетчику";
            this.textBox_23.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_23.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.CountChain", true));
            this.textBox_23.Location = new Point(660, 0x132);
            this.textBox_23.Name = "txtCountChain";
            this.textBox_23.Size = new Size(0x5d, 20);
            this.textBox_23.TabIndex = 0x3b;
            this.textBox_23.TextAlign = HorizontalAlignment.Right;
            this.textBox_24.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_24.BackColor = SystemColors.ControlLight;
            this.textBox_24.Location = new Point(0x231, 0x132);
            this.textBox_24.Name = "textBox19";
            this.textBox_24.ReadOnly = true;
            this.textBox_24.Size = new Size(100, 20);
            this.textBox_24.TabIndex = 0x3a;
            this.textBox_24.TabStop = false;
            this.textBox_24.Text = "nц, шт";
            this.textBox_25.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_25.BackColor = SystemColors.ControlLight;
            this.textBox_25.Location = new Point(15, 0x132);
            this.textBox_25.Name = "textBox20";
            this.textBox_25.ReadOnly = true;
            this.textBox_25.Size = new Size(0x223, 20);
            this.textBox_25.TabIndex = 0x39;
            this.textBox_25.TabStop = false;
            this.textBox_25.Text = "Количество параллельных цепей, шт.";
            this.textBox_26.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_26.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.CoeffDifferences", true));
            this.textBox_26.Location = new Point(660, 0x120);
            this.textBox_26.Name = "txtCoeffDifference";
            this.textBox_26.Size = new Size(0x5d, 20);
            this.textBox_26.TabIndex = 0x38;
            this.textBox_26.TextAlign = HorizontalAlignment.Right;
            this.textBox_27.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_27.BackColor = SystemColors.ControlLight;
            this.textBox_27.Location = new Point(0x231, 0x120);
            this.textBox_27.Name = "textBox22";
            this.textBox_27.ReadOnly = true;
            this.textBox_27.Size = new Size(100, 20);
            this.textBox_27.TabIndex = 0x37;
            this.textBox_27.TabStop = false;
            this.textBox_27.Text = "kк, о.е.";
            this.textBox_28.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_28.BackColor = SystemColors.ControlLight;
            this.textBox_28.Location = new Point(15, 0x120);
            this.textBox_28.Name = "textBox23";
            this.textBox_28.ReadOnly = true;
            this.textBox_28.Size = new Size(0x223, 20);
            this.textBox_28.TabIndex = 0x36;
            this.textBox_28.TabStop = false;
            this.textBox_28.Text = "Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагрузки";
            this.textBox_29.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_29.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.SquareCoeffFromGraph", true));
            this.textBox_29.Location = new Point(660, 0x10d);
            this.textBox_29.Name = "txtSquareCoeff";
            this.textBox_29.Size = new Size(0x5d, 20);
            this.textBox_29.TabIndex = 0x35;
            this.textBox_29.TextAlign = HorizontalAlignment.Right;
            this.textBox_30.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_30.BackColor = SystemColors.ControlLight;
            this.textBox_30.Location = new Point(0x231, 0x10d);
            this.textBox_30.Name = "textBox25";
            this.textBox_30.ReadOnly = true;
            this.textBox_30.Size = new Size(100, 20);
            this.textBox_30.TabIndex = 0x34;
            this.textBox_30.TabStop = false;
            this.textBox_30.Text = "kφ\x00b2, о.е.";
            this.textBox_31.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_31.BackColor = SystemColors.ControlLight;
            this.textBox_31.Location = new Point(15, 0x10d);
            this.textBox_31.Name = "textBox26";
            this.textBox_31.ReadOnly = true;
            this.textBox_31.Size = new Size(0x223, 20);
            this.textBox_31.TabIndex = 0x33;
            this.textBox_31.TabStop = false;
            this.textBox_31.Text = "Квадрат коэффициента формы графика за базовый период";
            this.button_2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_2.Location = new Point(0x13, 0x285);
            this.button_2.Name = "buttonOK";
            this.button_2.Size = new Size(0x4b, 0x17);
            this.button_2.TabIndex = 0x55;
            this.button_2.Text = "ОК";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new EventHandler(this.button_2_Click);
            this.textBox_32.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_32.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.ActiveResistance", true));
            this.textBox_32.Location = new Point(660, 330);
            this.textBox_32.Name = "txtActiveResistance";
            this.textBox_32.ReadOnly = true;
            this.textBox_32.Size = new Size(0x5d, 20);
            this.textBox_32.TabIndex = 0x3f;
            this.textBox_32.TextAlign = HorizontalAlignment.Right;
            this.textBox_33.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_33.BackColor = SystemColors.Info;
            this.textBox_33.Location = new Point(0x231, 330);
            this.textBox_33.Name = "textBox6";
            this.textBox_33.ReadOnly = true;
            this.textBox_33.Size = new Size(100, 20);
            this.textBox_33.TabIndex = 0x3e;
            this.textBox_33.TabStop = false;
            this.textBox_33.Text = "Rкл, Ом";
            this.textBox_34.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_34.BackColor = SystemColors.Info;
            this.textBox_34.Location = new Point(15, 330);
            this.textBox_34.Name = "textBox27";
            this.textBox_34.ReadOnly = true;
            this.textBox_34.Size = new Size(0x223, 20);
            this.textBox_34.TabIndex = 0x3d;
            this.textBox_34.TabStop = false;
            this.textBox_34.Text = "Активное сопротивление линии";
            this.textBox_35.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_35.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.LoadAverage", true));
            this.textBox_35.Location = new Point(660, 0x15c);
            this.textBox_35.Name = "txtLoadAverage";
            this.textBox_35.ReadOnly = true;
            this.textBox_35.Size = new Size(0x5d, 20);
            this.textBox_35.TabIndex = 0x42;
            this.textBox_35.TextAlign = HorizontalAlignment.Right;
            this.textBox_36.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_36.BackColor = SystemColors.Info;
            this.textBox_36.Location = new Point(0x231, 0x15c);
            this.textBox_36.Name = "textBox18";
            this.textBox_36.ReadOnly = true;
            this.textBox_36.Size = new Size(100, 20);
            this.textBox_36.TabIndex = 0x41;
            this.textBox_36.TabStop = false;
            this.textBox_36.Text = "Рср, МВт";
            this.textBox_37.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_37.BackColor = SystemColors.Info;
            this.textBox_37.Location = new Point(15, 0x15c);
            this.textBox_37.Name = "textBox28";
            this.textBox_37.ReadOnly = true;
            this.textBox_37.Size = new Size(0x223, 20);
            this.textBox_37.TabIndex = 0x40;
            this.textBox_37.TabStop = false;
            this.textBox_37.Text = "Cреднее значение активной мощности за базовый период";
            this.textBox_38.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_38.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.LoadPowerLoss", true));
            this.textBox_38.Location = new Point(660, 0x16f);
            this.textBox_38.Name = "txtLoadPowerLoss";
            this.textBox_38.ReadOnly = true;
            this.textBox_38.Size = new Size(0x5d, 20);
            this.textBox_38.TabIndex = 0x45;
            this.textBox_38.TextAlign = HorizontalAlignment.Right;
            this.textBox_39.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_39.BackColor = SystemColors.Info;
            this.textBox_39.Location = new Point(0x231, 0x16f);
            this.textBox_39.Name = "textBox12";
            this.textBox_39.ReadOnly = true;
            this.textBox_39.Size = new Size(100, 20);
            this.textBox_39.TabIndex = 0x44;
            this.textBox_39.TabStop = false;
            this.textBox_39.Text = "∆Pср, кВт";
            this.textBox_40.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_40.BackColor = SystemColors.Info;
            this.textBox_40.Location = new Point(15, 0x16f);
            this.textBox_40.Name = "textBox15";
            this.textBox_40.ReadOnly = true;
            this.textBox_40.Size = new Size(0x223, 20);
            this.textBox_40.TabIndex = 0x43;
            this.textBox_40.TabStop = false;
            this.textBox_40.Text = "Нагрузочные потери мощности в линии";
            this.textBox_41.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_41.Location = new Point(660, 0x181);
            this.textBox_41.Name = "txtLoadLosses";
            this.textBox_41.ReadOnly = true;
            this.textBox_41.Size = new Size(0x5d, 20);
            this.textBox_41.TabIndex = 0x48;
            this.textBox_41.TextAlign = HorizontalAlignment.Right;
            this.textBox_42.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_42.BackColor = SystemColors.Info;
            this.textBox_42.Location = new Point(0x231, 0x181);
            this.textBox_42.Name = "textBox9";
            this.textBox_42.ReadOnly = true;
            this.textBox_42.Size = new Size(100, 20);
            this.textBox_42.TabIndex = 0x47;
            this.textBox_42.TabStop = false;
            this.textBox_42.Text = "∆Wн, кВт*ч";
            this.textBox_43.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_43.BackColor = SystemColors.Info;
            this.textBox_43.Location = new Point(15, 0x181);
            this.textBox_43.Name = "textBox29";
            this.textBox_43.ReadOnly = true;
            this.textBox_43.Size = new Size(0x223, 20);
            this.textBox_43.TabIndex = 70;
            this.textBox_43.TabStop = false;
            this.textBox_43.Text = "Нагрузочные потери электроэнергии в линии";
            this.textBox_44.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_44.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.UnitYearLoss", true));
            this.textBox_44.Location = new Point(660, 0x194);
            this.textBox_44.Name = "txtUnitYearLoss";
            this.textBox_44.Size = new Size(0x5d, 20);
            this.textBox_44.TabIndex = 0x4b;
            this.textBox_44.TextAlign = HorizontalAlignment.Right;
            this.textBox_45.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_45.BackColor = SystemColors.Info;
            this.textBox_45.Location = new Point(0x231, 0x194);
            this.textBox_45.Name = "labelParamUnitYearLoss";
            this.textBox_45.ReadOnly = true;
            this.textBox_45.Size = new Size(100, 20);
            this.textBox_45.TabIndex = 0x4a;
            this.textBox_45.TabStop = false;
            this.textBox_45.Text = "1км/ кВт.ч год";
            this.textBox_46.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_46.BackColor = SystemColors.Info;
            this.textBox_46.Location = new Point(15, 0x194);
            this.textBox_46.Name = "labelUnitYearLoss";
            this.textBox_46.ReadOnly = true;
            this.textBox_46.Size = new Size(0x223, 20);
            this.textBox_46.TabIndex = 0x49;
            this.textBox_46.TabStop = false;
            this.textBox_46.Text = "Удельные годовые потери электроэнергии от токов утечки ВЛ";
            this.textBox_47.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_47.BackColor = SystemColors.Info;
            this.textBox_47.Location = new Point(0x231, 0x1a8);
            this.textBox_47.Name = "labelParamYearLoss";
            this.textBox_47.ReadOnly = true;
            this.textBox_47.Size = new Size(100, 20);
            this.textBox_47.TabIndex = 0x4c;
            this.textBox_47.TabStop = false;
            this.textBox_47.Text = "км/ кВт.ч год";
            this.textBox_48.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_48.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.YearLoss", true));
            this.textBox_48.Location = new Point(660, 0x1a8);
            this.textBox_48.Name = "txtYearLoss";
            this.textBox_48.ReadOnly = true;
            this.textBox_48.Size = new Size(0x5d, 20);
            this.textBox_48.TabIndex = 0x4d;
            this.textBox_48.TextAlign = HorizontalAlignment.Right;
            this.textBox_49.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_49.BackColor = SystemColors.Info;
            this.textBox_49.Location = new Point(15, 0x1ce);
            this.textBox_49.Name = "labelCoefLoss";
            this.textBox_49.ReadOnly = true;
            this.textBox_49.Size = new Size(0x223, 20);
            this.textBox_49.TabIndex = 0x51;
            this.textBox_49.TabStop = false;
            this.textBox_49.Text = "Доля нагрузочных потерь в потребление активной электроэнергии";
            this.textBox_50.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_50.BackColor = SystemColors.Info;
            this.textBox_50.Location = new Point(0x231, 0x1ce);
            this.textBox_50.Name = "labelParamCoefLoss";
            this.textBox_50.ReadOnly = true;
            this.textBox_50.Size = new Size(100, 20);
            this.textBox_50.TabIndex = 0x52;
            this.textBox_50.TabStop = false;
            this.textBox_50.Text = "%";
            this.textBox_51.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_51.Location = new Point(660, 0x1ce);
            this.textBox_51.Name = "txtCoefLoss";
            this.textBox_51.ReadOnly = true;
            this.textBox_51.Size = new Size(0x5d, 20);
            this.textBox_51.TabIndex = 0x53;
            this.textBox_51.TextAlign = HorizontalAlignment.Right;
            this.textBox_52.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_52.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.SumLoadLosses", true));
            this.textBox_52.Location = new Point(660, 0x1bb);
            this.textBox_52.Name = "txtSumLoadLoss";
            this.textBox_52.ReadOnly = true;
            this.textBox_52.Size = new Size(0x5d, 20);
            this.textBox_52.TabIndex = 80;
            this.textBox_52.TextAlign = HorizontalAlignment.Right;
            this.textBox_53.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_53.BackColor = SystemColors.Info;
            this.textBox_53.Location = new Point(0x231, 0x1bb);
            this.textBox_53.Name = "labelParamSumLoadLoss";
            this.textBox_53.ReadOnly = true;
            this.textBox_53.Size = new Size(100, 20);
            this.textBox_53.TabIndex = 0x4f;
            this.textBox_53.TabStop = false;
            this.textBox_53.Text = "∆Wн, кВт*ч";
            this.textBox_54.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_54.BackColor = SystemColors.Info;
            this.textBox_54.Location = new Point(15, 0x1bb);
            this.textBox_54.Name = "labelSumLoadLoss";
            this.textBox_54.ReadOnly = true;
            this.textBox_54.Size = new Size(0x223, 20);
            this.textBox_54.TabIndex = 0x4e;
            this.textBox_54.TabStop = false;
            this.textBox_54.Text = "Суммарные потери электроэенргии в ВЛ";
            this.button_3.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_3.Location = new Point(0x2aa, 0x285);
            this.button_3.Name = "buttonCancel";
            this.button_3.Size = new Size(0x4b, 0x17);
            this.button_3.TabIndex = 0x56;
            this.button_3.Text = "Отмена";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new EventHandler(this.button_3_Click);
            this.richTextBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLoss.Comment", true));
            this.richTextBox_0.Location = new Point(0x5f, 0x222);
            this.richTextBox_0.Name = "txtComment";
            this.richTextBox_0.Size = new Size(0x291, 0x43);
            this.richTextBox_0.TabIndex = 0x55;
            this.richTextBox_0.Text = "";
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(13, 0x21f);
            this.label_8.Name = "labelComment";
            this.label_8.Size = new Size(0x4d, 13);
            this.label_8.TabIndex = 0x56;
            this.label_8.Text = "Комментарий";
            this.button_4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_4.Location = new Point(100, 0x285);
            this.button_4.Name = "buttonPrint";
            this.button_4.Size = new Size(0x4b, 0x17);
            this.button_4.TabIndex = 0x57;
            this.button_4.Text = "Печать";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new EventHandler(this.button_4_Click);
            this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x2fc, 0x27f);
            this.tabControl_0.TabIndex = 0x58;
            this.tabPage_0.Controls.Add(this.textBox_56);
            this.tabPage_0.Controls.Add(this.textBox_57);
            this.tabPage_0.Controls.Add(this.textBox_58);
            this.tabPage_0.Controls.Add(this.textBox_59);
            this.tabPage_0.Controls.Add(this.textBox_60);
            this.tabPage_0.Controls.Add(this.textBox_61);
            this.tabPage_0.Controls.Add(this.checkBox_0);
            this.tabPage_0.Controls.Add(this.textBox_62);
            this.tabPage_0.Controls.Add(this.textBox_55);
            this.tabPage_0.Controls.Add(this.label_9);
            this.tabPage_0.Controls.Add(this.label_8);
            this.tabPage_0.Controls.Add(this.richTextBox_0);
            this.tabPage_0.Controls.Add(this.textBox_52);
            this.tabPage_0.Controls.Add(this.textBox_53);
            this.tabPage_0.Controls.Add(this.textBox_54);
            this.tabPage_0.Controls.Add(this.textBox_51);
            this.tabPage_0.Controls.Add(this.textBox_50);
            this.tabPage_0.Controls.Add(this.textBox_49);
            this.tabPage_0.Controls.Add(this.textBox_48);
            this.tabPage_0.Controls.Add(this.textBox_47);
            this.tabPage_0.Controls.Add(this.textBox_44);
            this.tabPage_0.Controls.Add(this.textBox_45);
            this.tabPage_0.Controls.Add(this.textBox_46);
            this.tabPage_0.Controls.Add(this.textBox_41);
            this.tabPage_0.Controls.Add(this.textBox_42);
            this.tabPage_0.Controls.Add(this.textBox_43);
            this.tabPage_0.Controls.Add(this.textBox_38);
            this.tabPage_0.Controls.Add(this.textBox_39);
            this.tabPage_0.Controls.Add(this.textBox_40);
            this.tabPage_0.Controls.Add(this.textBox_35);
            this.tabPage_0.Controls.Add(this.textBox_36);
            this.tabPage_0.Controls.Add(this.textBox_37);
            this.tabPage_0.Controls.Add(this.textBox_32);
            this.tabPage_0.Controls.Add(this.textBox_33);
            this.tabPage_0.Controls.Add(this.textBox_34);
            this.tabPage_0.Controls.Add(this.textBox_23);
            this.tabPage_0.Controls.Add(this.textBox_24);
            this.tabPage_0.Controls.Add(this.textBox_25);
            this.tabPage_0.Controls.Add(this.textBox_26);
            this.tabPage_0.Controls.Add(this.textBox_27);
            this.tabPage_0.Controls.Add(this.textBox_28);
            this.tabPage_0.Controls.Add(this.textBox_29);
            this.tabPage_0.Controls.Add(this.textBox_30);
            this.tabPage_0.Controls.Add(this.textBox_31);
            this.tabPage_0.Controls.Add(this.textBox_14);
            this.tabPage_0.Controls.Add(this.textBox_15);
            this.tabPage_0.Controls.Add(this.textBox_16);
            this.tabPage_0.Controls.Add(this.textBox_17);
            this.tabPage_0.Controls.Add(this.textBox_18);
            this.tabPage_0.Controls.Add(this.textBox_19);
            this.tabPage_0.Controls.Add(this.textBox_20);
            this.tabPage_0.Controls.Add(this.textBox_21);
            this.tabPage_0.Controls.Add(this.textBox_22);
            this.tabPage_0.Controls.Add(this.textBox_11);
            this.tabPage_0.Controls.Add(this.textBox_12);
            this.tabPage_0.Controls.Add(this.textBox_13);
            this.tabPage_0.Controls.Add(this.textBox_8);
            this.tabPage_0.Controls.Add(this.textBox_9);
            this.tabPage_0.Controls.Add(this.textBox_10);
            this.tabPage_0.Controls.Add(this.textBox_7);
            this.tabPage_0.Controls.Add(this.textBox_6);
            this.tabPage_0.Controls.Add(this.textBox_5);
            this.tabPage_0.Controls.Add(this.button_1);
            this.tabPage_0.Controls.Add(this.textBox_4);
            this.tabPage_0.Controls.Add(this.label_7);
            this.tabPage_0.Controls.Add(this.textBox_3);
            this.tabPage_0.Controls.Add(this.label_6);
            this.tabPage_0.Controls.Add(this.button_0);
            this.tabPage_0.Controls.Add(this.label_5);
            this.tabPage_0.Controls.Add(this.textBox_2);
            this.tabPage_0.Controls.Add(this.toolStrip_0);
            this.tabPage_0.Controls.Add(this.comboBox_1);
            this.tabPage_0.Controls.Add(this.label_3);
            this.tabPage_0.Controls.Add(this.textBox_1);
            this.tabPage_0.Controls.Add(this.label_4);
            this.tabPage_0.Controls.Add(this.textBox_0);
            this.tabPage_0.Controls.Add(this.label_2);
            this.tabPage_0.Controls.Add(this.comboBox_0);
            this.tabPage_0.Controls.Add(this.label_1);
            this.tabPage_0.Controls.Add(this.dateTimePicker_0);
            this.tabPage_0.Controls.Add(this.label_0);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageCalc";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x2f4, 0x265);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Расчет";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.textBox_56.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_56.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.IsolationLosses", true));
            this.textBox_56.Enabled = false;
            this.textBox_56.Location = new Point(660, 520);
            this.textBox_56.Name = "txtIsolationLoss";
            this.textBox_56.Size = new Size(0x5d, 20);
            this.textBox_56.TabIndex = 0x61;
            this.textBox_56.TextAlign = HorizontalAlignment.Right;
            this.textBox_57.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_57.BackColor = SystemColors.Info;
            this.textBox_57.Location = new Point(0x231, 520);
            this.textBox_57.Name = "labelUnitIsolationLoss";
            this.textBox_57.ReadOnly = true;
            this.textBox_57.Size = new Size(100, 20);
            this.textBox_57.TabIndex = 0x60;
            this.textBox_57.TabStop = false;
            this.textBox_57.Text = "кВт*ч";
            this.textBox_58.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_58.BackColor = SystemColors.Info;
            this.textBox_58.Location = new Point(15, 520);
            this.textBox_58.Name = "labelIsolationLoss";
            this.textBox_58.ReadOnly = true;
            this.textBox_58.Size = new Size(0x223, 20);
            this.textBox_58.TabIndex = 0x5f;
            this.textBox_58.TabStop = false;
            this.textBox_58.Text = "Потери электроэенргии в изоляции (изоляторах)";
            this.textBox_59.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_59.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLossCable.CoeffIsolation", true));
            this.textBox_59.Enabled = false;
            this.textBox_59.Location = new Point(660, 500);
            this.textBox_59.Name = "txtCoeffIsolation";
            this.textBox_59.Size = new Size(0x5d, 20);
            this.textBox_59.TabIndex = 0x5e;
            this.textBox_59.TextAlign = HorizontalAlignment.Right;
            this.textBox_60.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_60.BackColor = SystemColors.Info;
            this.textBox_60.Location = new Point(0x231, 500);
            this.textBox_60.Name = "labelUnitCoeffIsolation";
            this.textBox_60.ReadOnly = true;
            this.textBox_60.Size = new Size(100, 20);
            this.textBox_60.TabIndex = 0x5d;
            this.textBox_60.TabStop = false;
            this.textBox_60.Text = "тыс.кВт*ч/км в год";
            this.textBox_61.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_61.BackColor = SystemColors.Info;
            this.textBox_61.Location = new Point(15, 500);
            this.textBox_61.Name = "labelCoeffIsolataion";
            this.textBox_61.ReadOnly = true;
            this.textBox_61.Size = new Size(0x223, 20);
            this.textBox_61.TabIndex = 0x5c;
            this.textBox_61.TabStop = false;
            this.textBox_61.Text = "Удельные потери в изоляции (изоляторах)";
            this.checkBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.DataBindings.Add(new Binding("Checked", this.dsCalc_0, "tJ_CalcLossCable.isIsolation", true));
            this.checkBox_0.Location = new Point(0x2ba, 0x1e4);
            this.checkBox_0.Name = "checkBoxIsIsolation";
            this.checkBox_0.Size = new Size(15, 14);
            this.checkBox_0.TabIndex = 0x5b;
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            this.textBox_62.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_62.BackColor = SystemColors.Info;
            this.textBox_62.Location = new Point(15, 0x1e1);
            this.textBox_62.Name = "labelIsIsolation";
            this.textBox_62.ReadOnly = true;
            this.textBox_62.Size = new Size(0x223, 20);
            this.textBox_62.TabIndex = 90;
            this.textBox_62.TabStop = false;
            this.textBox_62.Text = "Потери электроэнергии в изоляторах (изоляции)";
            this.textBox_55.DataBindings.Add(new Binding("Text", this.dsCalc_0, "tJ_CalcLoss.num", true));
            this.textBox_55.Location = new Point(0x146, 12);
            this.textBox_55.Name = "txtNum";
            this.textBox_55.ReadOnly = true;
            this.textBox_55.Size = new Size(0x55, 20);
            this.textBox_55.TabIndex = 0x59;
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(0x117, 14);
            this.label_9.Name = "label9";
            this.label_9.Size = new Size(0x29, 13);
            this.label_9.TabIndex = 0x58;
            this.label_9.Text = "Номер";
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_1.Controls.Add(this.toolStrip_1);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageFile";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x2f4, 0x265);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Файлы";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_0.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.BackgroundColor = SystemColors.Window;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewLinkColumn_0, this.dataGridViewTextBoxColumn_1 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.GridColor = SystemColors.Window;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_0.Name = "dgvFiles";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(750, 0x246);
            this.dataGridViewExcelFilter_0.TabIndex = 2;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellContentClick);
            this.dataGridViewExcelFilter_0.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_0_CellValueNeeded);
            style.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style;
            this.dataGridViewImageColumnNotNull_0.HeaderText = "";
            this.dataGridViewImageColumnNotNull_0.Name = "ColumnImage";
            this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_0.Resizable = DataGridViewTriState.False;
            this.dataGridViewImageColumnNotNull_0.Width = 20;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "idCalc";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "idCalc";
            this.dataGridViewFilterTextBoxColumn_0.Name = "idCalcDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.Visible = false;
            this.dataGridViewLinkColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewLinkColumn_0.DataPropertyName = "FileName";
            this.dataGridViewLinkColumn_0.HeaderText = "Файл";
            this.dataGridViewLinkColumn_0.Name = "fileNameDataGridViewTextBoxColumn";
            this.dataGridViewLinkColumn_0.ReadOnly = true;
            this.dataGridViewLinkColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewLinkColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "DateIn";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_1.Name = "dateInDgvColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Width = 120;
            this.bindingSource_0.DataMember = "tJ_CalcLossFile";
            this.bindingSource_0.DataSource = this.dsCalc_0;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3, this.toolStripButton_4 };
            this.toolStrip_1.Items.AddRange(itemArray2);
            this.toolStrip_1.Location = new Point(3, 3);
            this.toolStrip_1.Name = "toolStripFile";
            this.toolStrip_1.Size = new Size(750, 0x19);
            this.toolStrip_1.TabIndex = 1;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = (Image) manager.GetObject("toolBtnFileAdd.Image");
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnFileAdd";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Добавить файлы";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = (Image) manager.GetObject("toolBtnFileDelete.Image");
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnFileDelete";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить файлы";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = (Image) manager.GetObject("toolBtnFileView.Image");
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnFileView";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Просмотр файла";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = (Image) manager.GetObject("toolBtnFileSave.Image");
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnFileSave";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Сохранить файл";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.tabPage_2.Controls.Add(this.splitContainer_0);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPageIsolation";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x2f4, 0x265);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Изоляция";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.Location = new Point(3, 3);
            this.splitContainer_0.Name = "splitContainerIsolation";
            this.splitContainer_0.Orientation = Orientation.Horizontal;
            this.splitContainer_0.Panel1.Controls.Add(this.dataGridView_0);
            this.splitContainer_0.Panel2.Controls.Add(this.dataGridView_1);
            this.splitContainer_0.Size = new Size(750, 0x25f);
            this.splitContainer_0.SplitterDistance = 0x155;
            this.splitContainer_0.TabIndex = 0;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4 };
            this.dataGridView_0.Columns.AddRange(columnArray2);
            this.dataGridView_0.DataMember = "dtKLIsolation";
            this.dataGridView_0.DataSource = this.dataSet_0;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.Location = new Point(0, 0);
            this.dataGridView_0.Name = "dataGridView1";
            this.dataGridView_0.Size = new Size(750, 0x155);
            this.dataGridView_0.TabIndex = 0;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "section";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Сечение, мм2";
            this.dataGridViewTextBoxColumn_2.Name = "sectionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "Isolation6";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Уд. потери в изоляции (6кВ)";
            this.dataGridViewTextBoxColumn_3.Name = "isolation6DataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "Isolation10";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Уд. потери в изоляции (10кВ)";
            this.dataGridViewTextBoxColumn_4.Name = "isolation10DataGridViewTextBoxColumn1";
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0, this.dataTable_1, this.dataTable_2 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "dtKLIsolation";
            this.dataColumn_0.ColumnName = "section";
            this.dataColumn_0.DataType = typeof(decimal);
            this.dataColumn_1.ColumnName = "Isolation6";
            this.dataColumn_1.DataType = typeof(decimal);
            this.dataColumn_2.ColumnName = "Isolation10";
            this.dataColumn_2.DataType = typeof(decimal);
            DataColumn[] columnArray4 = new DataColumn[] { this.dataColumn_3, this.dataColumn_4 };
            this.dataTable_1.Columns.AddRange(columnArray4);
            this.dataTable_1.TableName = "dtVLIsolation";
            this.dataColumn_3.ColumnName = "Isolation6";
            this.dataColumn_3.DataType = typeof(decimal);
            this.dataColumn_4.ColumnName = "Isolation10";
            this.dataColumn_4.DataType = typeof(decimal);
            DataColumn[] columnArray5 = new DataColumn[] { this.dataColumn_5, this.dataColumn_6, this.dataColumn_7 };
            this.dataTable_2.Columns.AddRange(columnArray5);
            Constraint[] constraints = new Constraint[1];
            string[] columnNames = new string[] { "id" };
            constraints[0] = new UniqueConstraint("Constraint1", columnNames, true);
            this.dataTable_2.Constraints.AddRange(constraints);
            this.dataTable_2.PrimaryKey = new DataColumn[] { this.dataColumn_5 };
            this.dataTable_2.TableName = "tSettings";
            this.dataColumn_5.AllowDBNull = false;
            this.dataColumn_5.AutoIncrement = true;
            this.dataColumn_5.ColumnName = "id";
            this.dataColumn_5.DataType = typeof(int);
            this.dataColumn_6.ColumnName = "settings";
            this.dataColumn_7.ColumnName = "module";
            this.dataGridView_1.AllowUserToAddRows = false;
            this.dataGridView_1.AllowUserToDeleteRows = false;
            this.dataGridView_1.AutoGenerateColumns = false;
            this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray7 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6 };
            this.dataGridView_1.Columns.AddRange(columnArray7);
            this.dataGridView_1.DataMember = "dtVLIsolation";
            this.dataGridView_1.DataSource = this.dataSet_0;
            this.dataGridView_1.Dock = DockStyle.Fill;
            this.dataGridView_1.Location = new Point(0, 0);
            this.dataGridView_1.Name = "dataGridView2";
            this.dataGridView_1.Size = new Size(750, 0x106);
            this.dataGridView_1.TabIndex = 0;
            this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "Isolation6";
            this.dataGridViewTextBoxColumn_5.HeaderText = "Уд. потери по изоляторам (6кВ)";
            this.dataGridViewTextBoxColumn_5.Name = "isolation6DataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "Isolation10";
            this.dataGridViewTextBoxColumn_6.HeaderText = "Уд. потери по изоляторам (10кВ)";
            this.dataGridViewTextBoxColumn_6.Name = "isolation10DataGridViewTextBoxColumn";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2fc, 0x29f);
            base.Controls.Add(this.tabControl_0);
            base.Controls.Add(this.button_2);
            base.Controls.Add(this.button_4);
            base.Controls.Add(this.button_3);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            this.MinimumSize = new Size(550, 0x26f);
            base.Name = "FormAddEditCalcCable";
            this.Text = "Расчет потерь в КЛ/ВЛ";
            base.Load += new EventHandler(this.FormAddEditCalcCable_Load);
            this.dsCalc_0.EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.tabPage_2.ResumeLayout(false);
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.dataTable_1.EndInit();
            this.dataTable_2.EndInit();
            ((ISupportInitialize) this.dataGridView_1).EndInit();
            base.ResumeLayout(false);
        }

        private void method_4()
        {
            if (this.int_3 != -1)
            {
                this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"] = this.int_3;
                base.SelectSqlData(this.dsCalc_0.tAbn, true, "where id = " + this.int_3.ToString(), false);
                if (this.dsCalc_0.tAbn.Rows.Count > 0)
                {
                    this.textBox_1.Text = this.dsCalc_0.tAbn.Rows[0]["Name"].ToString();
                }
            }
            if (this.int_5 != -1)
            {
                this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.int_5;
                base.SelectSqlData(this.dsCalc_0.tAbn, true, "where id = " + this.int_5.ToString(), false);
                if (this.dsCalc_0.tAbn.Rows.Count > 0)
                {
                    this.textBox_2.Text = this.dsCalc_0.tAbn.Rows[0]["Name"].ToString();
                }
            }
            if (this.int_4 != -1)
            {
                this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnObj"] = this.int_4;
            }
            this.method_8();
            this.method_5();
        }

        private void method_5()
        {
            if (string.IsNullOrEmpty(this.textBox_3.Text))
            {
                base.SelectSqlData(this.dsCalc_0.vL_SchmAbn, true, "where idAbn = " + this.int_3.ToString() + " or idAbnObj = " + this.int_4.ToString(), false);
                foreach (DataRow row in this.dsCalc_0.vL_SchmAbn)
                {
                    if (!string.IsNullOrEmpty(this.textBox_3.Text))
                    {
                        this.textBox_3.Text = this.textBox_3.Text + ", ";
                    }
                    this.textBox_3.Text = this.textBox_3.Text + row["SchmObjName"].ToString();
                }
            }
        }

        private void method_6(object sender, FormClosedEventArgs e)
        {
            FormTechConnectionAddAbn abn = (FormTechConnectionAddAbn) sender;
            if (abn.DialogResult == DialogResult.OK)
            {
                this.textBox_1.Text = abn.AbnName;
                if (string.IsNullOrEmpty(this.textBox_2.Text))
                {
                    this.textBox_2.Text = abn.AbnName;
                    this.textBox_2.Tag = this.int_5 = abn.IdAbn;
                    this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.int_5;
                }
                this.textBox_1.Tag = this.int_3 = abn.IdAbn;
                this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"] = this.int_3;
                this.comboBox_1.Tag = this.int_4 = abn.IdAbnObj;
                this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnObj"] = this.int_4;
                this.method_8();
                this.method_5();
            }
        }

        private FormBase method_7(object object_0, ShowFormEventArgs showFormEventArgs_0)
        {
            return this.OnShowForm(showFormEventArgs_0);
        }

        private void method_8()
        {
            dsCalc.tAbnDataTable table = new dsCalc.tAbnDataTable();
            base.SelectSqlData(table, true, " where id = " + this.int_3.ToString(), false);
            if (table.Rows.Count > 0)
            {
                this.comboBox_1.SelectedValueChanged -= new EventHandler(this.comboBox_1_SelectedValueChanged);
                int num = Convert.ToInt32(table.Rows[0]["typeAbn"]);
                dsCalc.vAbnObjAddressDataTable table2 = new dsCalc.vAbnObjAddressDataTable();
                DataColumn column = new DataColumn("AddressFL") {
                    Expression = "street + ', д. ' + houseall + ', кв. ' + name"
                };
                table2.Columns.Add(column);
                column = new DataColumn("AddressUL") {
                    Expression = "street + ', д. ' + houseall"
                };
                table2.Columns.Add(column);
                base.SelectSqlData(table2, true, "where idAbn = " + this.int_3.ToString() + " order by name", false);
                this.comboBox_1.ValueMember = "id";
                this.comboBox_1.DataSource = table2;
                if (((num != 0xce) && (num != 0xfd)) && (num != 0x40d))
                {
                    this.comboBox_1.DisplayMember = "name";
                }
                else
                {
                    this.comboBox_1.DisplayMember = "AddressFL";
                }
                this.comboBox_1.SelectedValue = this.int_4;
                this.comboBox_1.SelectedValueChanged += new EventHandler(this.comboBox_1_SelectedValueChanged);
            }
            else
            {
                this.comboBox_1.Items.Clear();
            }
        }

        private void method_9(object sender, FormClosedEventArgs e)
        {
            FormTechConnectionAddAbn abn = (FormTechConnectionAddAbn) sender;
            if (abn.DialogResult == DialogResult.OK)
            {
                this.textBox_2.Text = abn.AbnName;
                this.textBox_2.Tag = this.int_5 = abn.IdAbn;
                this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.int_5;
            }
        }

        private void textBox_11_TextChanged(object sender, EventArgs e)
        {
            float num;
            if (!string.IsNullOrEmpty(this.textBox_11.Text) && float.TryParse(this.textBox_11.Text, out num))
            {
                if (num < 1f)
                {
                    this.method_21();
                }
                else if (this.int_2 == 0x4ae)
                {
                    int num2;
                    this.method_22();
                    if (int.TryParse(this.textBox_11.Text, out num2))
                    {
                        if (this.dictionary_0.ContainsKey(num2))
                        {
                            int num3 = this.dictionary_0[num2];
                            this.textBox_44.Text = num3.ToString();
                        }
                        else if (string.IsNullOrEmpty(this.textBox_44.Text))
                        {
                            this.textBox_44.Text = this.dictionary_0[6].ToString();
                        }
                    }
                    else
                    {
                        this.textBox_44.Text = null;
                    }
                }
            }
        }

        private void textBox_59_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberFormatInfo numberFormat = CultureInfo.CurrentCulture.NumberFormat;
            string numberDecimalSeparator = numberFormat.NumberDecimalSeparator;
            string numberGroupSeparator = numberFormat.NumberGroupSeparator;
            string negativeSign = numberFormat.NegativeSign;
            char ch = '\x00a0';
            if (numberGroupSeparator == ch.ToString())
            {
                numberGroupSeparator = " ";
            }
            string str4 = e.KeyChar.ToString();
            if (((!char.IsDigit(e.KeyChar) && !str4.Equals(numberDecimalSeparator)) && (!str4.Equals(numberGroupSeparator) && !str4.Equals(negativeSign))) && ((e.KeyChar != '\b') && (!this.bool_0 || (e.KeyChar != ' '))))
            {
                e.Handled = true;
            }
        }

        private void textBox_59_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.method_13();
                this.method_14();
                this.method_15();
                this.method_16();
                this.method_17();
                this.method_18();
                this.method_19();
                this.method_20();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormTechConnectionAddAbn abn1 = new FormTechConnectionAddAbn(this.int_3, this.int_4, true);
            abn1.add_ShowForm(new ShowFormEventHandler(this, this.method_7));
            abn1.set_SqlSettings(this.get_SqlSettings());
            abn1.MdiParent = base.MdiParent;
            abn1.FormClosed += new FormClosedEventHandler(this.method_6);
            abn1.Show();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog {
                    Multiselect = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        DataRow row = this.dsCalc_0.tJ_CalcLossFile.NewRow();
                        row["idCalc"] = this.int_0;
                        row["File"] = File.ReadAllBytes(dialog.FileNames[i]);
                        row["FileName"] = Path.GetFileName(dialog.FileNames[i]);
                        row["DateIn"] = DateTime.Now;
                        this.dsCalc_0.tJ_CalcLossFile.Rows.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного файла");
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                DataRow[] rowArray = this.dsCalc_0.tJ_CalcLossFile.Select("id = " + num.ToString());
                if (rowArray.Length != 0)
                {
                    byte[] buffer = (byte[]) rowArray[0]["File"];
                    string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(rowArray[0]["FileName"].ToString()));
                    FileStream stream1 = File.Create(path);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    new Process { StartInfo = { 
                        FileName = path,
                        UseShellExecute = true
                    } }.Start();
                }
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                DataRow[] rowArray = this.dsCalc_0.tJ_CalcLossFile.Select("id = " + num.ToString());
                if (rowArray.Length != 0)
                {
                    string path = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewLinkColumn_0.Name].Value.ToString();
                    string extension = Path.GetExtension(path);
                    SaveFileDialog dialog = new SaveFileDialog {
                        Filter = "(*" + extension + ")|*" + extension,
                        FileName = path
                    };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        byte[] buffer = (byte[]) rowArray[0]["file"];
                        FileStream stream1 = File.Create(dialog.FileName);
                        stream1.Write(buffer, 0, buffer.Length);
                        stream1.Close();
                        MessageBox.Show("Файл успешно сохранен", "Сохранение");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        public int Id
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
    }
}

