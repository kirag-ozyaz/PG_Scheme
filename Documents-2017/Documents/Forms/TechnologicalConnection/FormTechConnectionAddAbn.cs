namespace Documents.Forms.TechnologicalConnection
{
    using Constants;
    using Contractor.Forms;
    using ControlsLbr.DataGridViewExcelFilter;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class FormTechConnectionAddAbn : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private CheckBox checkBox_0;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_10;
        private DataColumn dataColumn_11;
        private DataColumn dataColumn_12;
        private DataColumn dataColumn_13;
        private DataColumn dataColumn_14;
        private DataColumn dataColumn_15;
        private DataColumn dataColumn_16;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataColumn dataColumn_9;
        private DataGridView dataGridView_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSet dataSet_0;
        private DataSet dataSet_1;
        private DataSet dataSet_2;
        private DataSet dataSet_3;
        private DataSetTechConnection dataSetTechConnection_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DataTable dataTable_2;
        private DataTable dataTable_3;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private GroupBox groupBox_3;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private RadioButton radioButton_0;
        private RadioButton radioButton_1;
        private RadioButton radioButton_2;
        private RadioButton radioButton_3;
        private RichTextBox richTextBox_0;
        private RichTextBox richTextBox_1;
        private SplitContainer splitContainer_0;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;
        private TabControl tabControl_0;
        private TabControl tabControl_1;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TabPage tabPage_3;
        private TabPage tabPage_4;
        private TabPage tabPage_5;
        private TabPage tabPage_6;
        private TabPage tabPage_7;
        private TabPage tabPage_8;
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
        private TextBox textBox_3;
        private TextBox textBox_4;
        private TextBox textBox_5;
        private TextBox textBox_6;
        private TextBox textBox_7;
        private TextBox textBox_8;
        private TextBox textBox_9;
        private Timer timer_0;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStrip toolStrip_3;
        private ToolStrip toolStrip_4;
        private ToolStrip toolStrip_5;
        private ToolStrip toolStrip_6;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_10;
        private ToolStripButton toolStripButton_11;
        private ToolStripButton toolStripButton_12;
        private ToolStripButton toolStripButton_13;
        private ToolStripButton toolStripButton_14;
        private ToolStripButton toolStripButton_15;
        private ToolStripButton toolStripButton_16;
        private ToolStripButton toolStripButton_17;
        private ToolStripButton toolStripButton_18;
        private ToolStripButton toolStripButton_19;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripSeparator toolStripSeparator_0;
        private DataSetTechConnection.vAbnObjAddressDataTable vAbnObjAddressDataTable_0;

        public FormTechConnectionAddAbn()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.method_4();
            this.method_0();
        }

        internal FormTechConnectionAddAbn(int int_3 = -1, int int_4 = -1, bool bool_1 = false)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.method_4();
            this.IdAbn = int_3;
            this.IdAbnObj = int_4;
            this.bool_0 = bool_1;
            this.method_0();
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                this.int_0 = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current)["id"]);
                this.int_2 = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current)["typeAbn"]);
                this.AbnName = ((DataRowView) this.bindingSource_0.Current)["name"].ToString();
                base.SelectSqlData(this.vAbnObjAddressDataTable_0, true, "where idAbn = " + this.int_0.ToString(), false);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vG_AbnInfo, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tG_AbnChief, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vG_AbnAddressL, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vG_AbnAddressP, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tAbnContact, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc");
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbnType, true, " where idAbn = " + this.int_0.ToString());
            }
            else
            {
                this.int_0 = -1;
                this.int_2 = -1;
                this.AbnName = null;
                this.vAbnObjAddressDataTable_0.Clear();
                this.dataSetTechConnection_0.vG_AbnInfo.Clear();
                this.dataSetTechConnection_0.tG_AbnChief.Clear();
                this.dataSetTechConnection_0.vG_AbnAddressL.Clear();
                this.dataSetTechConnection_0.vG_AbnAddressP.Clear();
                this.dataSetTechConnection_0.tAbnContact.Clear();
                this.dataSetTechConnection_0.vAbnType.Clear();
            }
        }

        private void bindingSource_1_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_1.Current != null)
            {
                this.int_1 = Convert.ToInt32(((DataRowView) this.bindingSource_1.Current)["id"]);
                if (this.radioButton_1.Checked)
                {
                    this.AbnObjName = ((DataRowView) this.bindingSource_1.Current)["AddressFl"].ToString();
                }
                else
                {
                    this.AbnObjName = ((DataRowView) this.bindingSource_1.Current)["Name"].ToString();
                }
            }
            else
            {
                this.int_1 = -1;
                this.AbnObjName = null;
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_0.SelectedIndex < 0)
            {
                this.dataSet_2.Tables["tR_KladrObj"].Clear();
            }
            else
            {
                base.SelectSqlData(this.dataSet_2, "tR_kladrObj", true, " where ParentId = " + this.comboBox_0.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
            }
        }

        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_2.SelectedIndex >= 0)
            {
                base.SelectSqlData(this.dataSet_0, "tR_KladrStreet", true, " where KladrObjId = " + this.comboBox_2.SelectedValue + " and deleted = 0 order by name, socr ");
            }
            else if (this.comboBox_3.SelectedIndex >= 0)
            {
                base.SelectSqlData(this.dataSet_0, "tR_KladrStreet", true, " where KladrObjId = " + this.comboBox_3.SelectedValue + " and deleted = 0 order by name, socr ");
            }
            this.comboBox_1.SelectedIndex = -1;
            this.method_1();
        }

        private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_3.SelectedIndex < 0)
            {
                this.dataSet_1.Tables["tR_KladrObj"].Clear();
                this.dataSet_0.Tables["tR_KladrStreet"].Clear();
            }
            else
            {
                base.SelectSqlData(this.dataSet_1, "tR_kladrObj", true, " where ParentId = " + this.comboBox_3.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                this.comboBox_2.SelectedIndex = -1;
                base.SelectSqlData(this.dataSet_0, "tR_KladrStreet", true, " where KladrObjId = " + this.comboBox_3.SelectedValue + " and deleted = 0 order by name, socr ");
                this.comboBox_1.SelectedIndex = -1;
            }
            this.method_1();
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_41.Name, e.RowIndex].Value) == 0xce)
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
                if (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_41.Name, e.RowIndex].Value) == 0xcf)
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                if (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_41.Name, e.RowIndex].Value) == 0xe7)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_41.Name, e.RowIndex].Value) == 230)
                {
                    e.CellStyle.ForeColor = Color.Purple;
                }
                if (Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_1.Name, e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if ((this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_2.Name, e.RowIndex].Value != DBNull.Value) && !Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_2.Name, e.RowIndex].Value))
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
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

        private void FormTechConnectionAddAbn_Load(object sender, EventArgs e)
        {
            if (this.IdAbn != -1)
            {
                DataSetTechConnection connection = new DataSetTechConnection();
                base.SelectSqlData(connection, connection.vAbn, true, "where id = " + this.IdAbn.ToString());
                if (connection.vAbn.Rows.Count > 0)
                {
                    switch (Convert.ToInt32(connection.vAbn.Rows[0]["typeAbn"]))
                    {
                        case 0x40d:
                        case 0xce:
                        case 0xfd:
                            this.radioButton_1.Checked = true;
                            break;
                    }
                    this.textBox_0.Text = connection.vAbn.Rows[0]["Name"].ToString();
                }
            }
            this.method_3();
            this.method_1();
        }

        private void method_0()
        {
            this.vAbnObjAddressDataTable_0 = new DataSetTechConnection.vAbnObjAddressDataTable();
            DataColumn column = new DataColumn("AddressFL") {
                Expression = "isnull(street + ', ', '') + 'д. ' + houseall + isnull(' - ' + name, '')"
            };
            this.vAbnObjAddressDataTable_0.Columns.Add(column);
            column = new DataColumn("AddressUL") {
                Expression = "isnull(street + ', ', '') + 'д. ' + houseall"
            };
            this.vAbnObjAddressDataTable_0.Columns.Add(column);
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "AddressFL";
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "AddressUL";
            this.bindingSource_1.DataSource = this.vAbnObjAddressDataTable_0;
            if (!this.bool_0)
            {
                this.button_1.Visible = false;
                this.button_0.Visible = false;
                this.Text = "Контрагенты";
                this.splitContainer_0.Height += 0x21;
                this.tabControl_0.Top += 0x21;
            }
        }

        private void method_1()
        {
            int num = this.int_0;
            int num2 = this.int_1;
            string str = this.toolStripButton_16.Checked ? " " : " and deleted = 0 ";
            string str2 = this.checkBox_0.Checked ? " " : " and (isActive = 1 or isActive is null) ";
            str = str + str2;
            string str3 = string.Empty;
            foreach (AbnType type in Enum.GetValues(typeof(AbnType)))
            {
                if (((type != 0x40d) && (type != 0xce)) && (type != 0xfd))
                {
                    if (!string.IsNullOrEmpty(str3))
                    {
                        str3 = str3 + ",";
                    }
                    str3 = str3 + ((int) type).ToString();
                }
            }
            if (this.radioButton_0.Checked)
            {
                if (this.radioButton_2.Checked)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where typeAbn in (" + str3 + ") " + str + " order by name");
                    if (!string.IsNullOrEmpty(this.textBox_0.Text))
                    {
                        this.bindingSource_0.Filter = "Name like '%" + this.textBox_0.Text + "%'";
                    }
                    else
                    {
                        this.bindingSource_0.Filter = "";
                    }
                }
                else
                {
                    if (this.comboBox_1.SelectedIndex < 0)
                    {
                        if (this.comboBox_2.SelectedIndex < 0)
                        {
                            if (this.comboBox_3.SelectedIndex < 0)
                            {
                                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where typeAbn in (" + str3 + ") " + str + " order by name");
                            }
                            else
                            {
                                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where typeAbn in (" + str3 + ") " + str + " and id in (select idAbn from vAbnObjAddress where idCity = " + this.comboBox_3.SelectedValue.ToString() + ")  order by name");
                            }
                        }
                        else
                        {
                            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where typeAbn in (" + str3 + ") " + str + " and id in (select idAbn from vAbnObjAddress where idCity = " + this.comboBox_2.SelectedValue.ToString() + ")  order by name");
                        }
                    }
                    else if (string.IsNullOrEmpty(this.textBox_3.Text) && string.IsNullOrEmpty(this.textBox_2.Text))
                    {
                        base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where typeAbn in (" + str3 + ") " + str + " and id in (select idAbn from vAbnObjAddress where idStreet = " + this.comboBox_1.SelectedValue.ToString() + ")  order by name");
                    }
                    else
                    {
                        base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where typeAbn in (" + str3 + ") " + str + " and id in (select idAbn from vAbnObjAddress where idStreet = " + this.comboBox_1.SelectedValue.ToString() + " and HouseAll like '%" + this.textBox_3.Text + this.textBox_2.Text + "%')  order by name");
                    }
                    this.bindingSource_0.Filter = "";
                }
            }
            else if (this.radioButton_2.Checked)
            {
                if (string.IsNullOrEmpty(this.textBox_0.Text))
                {
                    this.dataSetTechConnection_0.vAbn.Clear();
                }
                else
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where name like '%" + this.textBox_0.Text + "%' and typeAbn not in (" + str3 + ") " + str + " order by name");
                }
            }
            else
            {
                if (this.comboBox_1.SelectedIndex < 0)
                {
                    this.dataSetTechConnection_0.vAbn.Clear();
                }
                else if (string.IsNullOrEmpty(this.textBox_3.Text) && string.IsNullOrEmpty(this.textBox_2.Text))
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where typeAbn not in (" + str3 + ") " + str + " and id in (select idAbn from vAbnObjAddress where idStreet = " + this.comboBox_1.SelectedValue.ToString() + ")  order by name");
                }
                else
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbn, true, " where typeAbn not in (" + str3 + ") " + str + " and id in (select idAbn from vAbnObjAddress where idStreet = " + this.comboBox_1.SelectedValue.ToString() + " and HouseAll like '%" + this.textBox_3.Text + this.textBox_2.Text + "%')  order by name");
                }
                this.bindingSource_0.Filter = "";
            }
            this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_38.Name, num.ToString(), false);
            this.dataGridViewExcelFilter_1.SearchGrid(this.dataGridViewTextBoxColumn_10.Name, num2.ToString(), false);
        }

        private bool method_2()
        {
            return ((((this.int_2 != 0xcf) && (this.int_2 != 0xe7)) && ((this.int_2 != 0xce) && (this.int_2 != 0xfd))) && (this.int_2 != 230));
        }

        private void method_3()
        {
            if (this.get_SqlSettings() != null)
            {
                base.SelectSqlData(this.dataSet_3, "tR_KladrObj", true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");
                if (this.comboBox_0.SelectedIndex >= 0)
                {
                    base.SelectSqlData(this.dataSet_2, "tR_kladrObj", true, " where ParentId = " + this.comboBox_0.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                    this.comboBox_3.Text = "Ульяновск г";
                }
            }
        }

        private void method_4()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormTechConnectionAddAbn));
            this.groupBox_0 = new GroupBox();
            this.radioButton_1 = new RadioButton();
            this.radioButton_0 = new RadioButton();
            this.textBox_0 = new TextBox();
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.timer_0 = new Timer(this.icontainer_0);
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
            this.splitContainer_0 = new SplitContainer();
            this.toolStrip_4 = new ToolStrip();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripButton_11 = new ToolStripButton();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_16 = new ToolStripButton();
            this.toolStrip_5 = new ToolStrip();
            this.toolStripButton_13 = new ToolStripButton();
            this.toolStripButton_14 = new ToolStripButton();
            this.toolStripButton_15 = new ToolStripButton();
            this.groupBox_1 = new GroupBox();
            this.textBox_1 = new TextBox();
            this.label_4 = new Label();
            this.textBox_2 = new TextBox();
            this.label_5 = new Label();
            this.textBox_3 = new TextBox();
            this.label_6 = new Label();
            this.comboBox_1 = new ComboBox();
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.label_0 = new Label();
            this.comboBox_2 = new ComboBox();
            this.dataSet_1 = new DataSet();
            this.dataTable_1 = new DataTable();
            this.dataColumn_5 = new DataColumn();
            this.dataColumn_6 = new DataColumn();
            this.dataColumn_7 = new DataColumn();
            this.dataColumn_8 = new DataColumn();
            this.label_1 = new Label();
            this.comboBox_3 = new ComboBox();
            this.dataSet_2 = new DataSet();
            this.dataTable_2 = new DataTable();
            this.dataColumn_9 = new DataColumn();
            this.dataColumn_10 = new DataColumn();
            this.dataColumn_11 = new DataColumn();
            this.dataColumn_12 = new DataColumn();
            this.label_2 = new Label();
            this.label_3 = new Label();
            this.comboBox_0 = new ComboBox();
            this.dataSet_3 = new DataSet();
            this.dataTable_3 = new DataTable();
            this.dataColumn_13 = new DataColumn();
            this.dataColumn_14 = new DataColumn();
            this.dataColumn_15 = new DataColumn();
            this.dataColumn_16 = new DataColumn();
            this.radioButton_3 = new RadioButton();
            this.radioButton_2 = new RadioButton();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.textBox_4 = new TextBox();
            this.textBox_5 = new TextBox();
            this.textBox_6 = new TextBox();
            this.textBox_7 = new TextBox();
            this.textBox_8 = new TextBox();
            this.textBox_9 = new TextBox();
            this.textBox_10 = new TextBox();
            this.textBox_11 = new TextBox();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.tabPage_1 = new TabPage();
            this.tabControl_1 = new TabControl();
            this.tabPage_2 = new TabPage();
            this.textBox_12 = new TextBox();
            this.textBox_13 = new TextBox();
            this.textBox_14 = new TextBox();
            this.textBox_15 = new TextBox();
            this.tabPage_3 = new TabPage();
            this.textBox_16 = new TextBox();
            this.textBox_17 = new TextBox();
            this.textBox_18 = new TextBox();
            this.textBox_19 = new TextBox();
            this.tabPage_4 = new TabPage();
            this.textBox_20 = new TextBox();
            this.textBox_21 = new TextBox();
            this.textBox_22 = new TextBox();
            this.textBox_23 = new TextBox();
            this.tabPage_5 = new TabPage();
            this.textBox_24 = new TextBox();
            this.textBox_25 = new TextBox();
            this.textBox_26 = new TextBox();
            this.textBox_27 = new TextBox();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.tabPage_6 = new TabPage();
            this.groupBox_2 = new GroupBox();
            this.richTextBox_0 = new RichTextBox();
            this.groupBox_3 = new GroupBox();
            this.richTextBox_1 = new RichTextBox();
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_6 = new ToolStripButton();
            this.tabPage_7 = new TabPage();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.toolStrip_3 = new ToolStrip();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.toolStripButton_9 = new ToolStripButton();
            this.tabPage_8 = new TabPage();
            this.dataGridViewExcelFilter_2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.toolStrip_6 = new ToolStrip();
            this.toolStripButton_17 = new ToolStripButton();
            this.toolStripButton_18 = new ToolStripButton();
            this.toolStripButton_19 = new ToolStripButton();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.checkBox_0 = new CheckBox();
            this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
            Label label = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Label label4 = new Label();
            Label label5 = new Label();
            Label label6 = new Label();
            Label label7 = new Label();
            Label label8 = new Label();
            Label label9 = new Label();
            Label label10 = new Label();
            Label label11 = new Label();
            Label label12 = new Label();
            Label label13 = new Label();
            Label label14 = new Label();
            Label label15 = new Label();
            Label label16 = new Label();
            Label label17 = new Label();
            Label label18 = new Label();
            Label label19 = new Label();
            Label label20 = new Label();
            Label label21 = new Label();
            Label label22 = new Label();
            Label label23 = new Label();
            Label label24 = new Label();
            this.groupBox_0.SuspendLayout();
            this.dataSetTechConnection_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.dataGridViewExcelFilter_1.BeginInit();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStrip_4.SuspendLayout();
            this.toolStrip_5.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.dataSet_1.BeginInit();
            this.dataTable_1.BeginInit();
            this.dataSet_2.BeginInit();
            this.dataTable_2.BeginInit();
            this.dataSet_3.BeginInit();
            this.dataTable_3.BeginInit();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.tabControl_1.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.tabPage_3.SuspendLayout();
            this.tabPage_4.SuspendLayout();
            this.tabPage_5.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.tabPage_6.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.groupBox_3.SuspendLayout();
            this.toolStrip_2.SuspendLayout();
            this.tabPage_7.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            this.toolStrip_3.SuspendLayout();
            this.tabPage_8.SuspendLayout();
            this.dataGridViewExcelFilter_2.BeginInit();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            this.toolStrip_6.SuspendLayout();
            base.SuspendLayout();
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label.Location = new Point(0x1f, 7);
            label.Name = "nameFullLabel";
            label.Size = new Size(0x52, 13);
            label.TabIndex = 0x25;
            label.Text = "Полное имя:";
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label2.Location = new Point(60, 0xab);
            label2.Name = "bankAcntLabel";
            label2.Size = new Size(0x69, 13);
            label2.TabIndex = 0x33;
            label2.Text = "Расчетный счет:";
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label3.Location = new Point(0x4b, 0x44);
            label3.Name = "iNNLabel";
            label3.Size = new Size(0x26, 13);
            label3.TabIndex = 0x27;
            label3.Text = "ИНН:";
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label4.Location = new Point(0x37, 0x91);
            label4.Name = "bankDestLabel";
            label4.Size = new Size(0x6f, 13);
            label4.TabIndex = 0x31;
            label4.Text = "Банк получателя:";
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label5.Location = new Point(0x165, 0x44);
            label5.Name = "kPPLabel";
            label5.Size = new Size(0x25, 13);
            label5.TabIndex = 0x29;
            label5.Text = "КПП:";
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label6.Location = new Point(0x29, 0x77);
            label6.Name = "bankIDLabel";
            label6.Size = new Size(0x7f, 13);
            label6.TabIndex = 0x2f;
            label6.Text = "Банк плательщика :";
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label7.Location = new Point(0x3d, 90);
            label7.Name = "oKVEDLabel";
            label7.Size = new Size(0x36, 13);
            label7.TabIndex = 0x2b;
            label7.Text = "ОКВЕД:";
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label8.Location = new Point(0x15d, 90);
            label8.Name = "oKPOLabel";
            label8.Size = new Size(0x2e, 13);
            label8.TabIndex = 0x2d;
            label8.Text = "ОКПО:";
            label9.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label9.Location = new Point(12, 15);
            label9.Name = "postLabel";
            label9.Size = new Size(0x5f, 0x11);
            label9.TabIndex = 0x20;
            label9.Text = "Должность:";
            label10.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label10.Location = new Point(0x17, 130);
            label10.Name = "i_OLabel";
            label10.Size = new Size(0x54, 0x11);
            label10.TabIndex = 0x2a;
            label10.Text = "Отчество:";
            label11.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label11.Location = new Point(0x40, 0x5f);
            label11.Name = "i_ILabel";
            label11.Size = new Size(0x2b, 0x11);
            label11.TabIndex = 40;
            label11.Text = "Имя:";
            label12.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label12.Location = new Point(0x19, 0x3a);
            label12.Name = "i_FLabel";
            label12.Size = new Size(0x52, 0x11);
            label12.TabIndex = 0x26;
            label12.Text = "Фамилия:";
            label13.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label13.Location = new Point(12, 15);
            label13.Name = "label6";
            label13.Size = new Size(0x5f, 0x11);
            label13.TabIndex = 0x22;
            label13.Text = "Должность:";
            label14.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label14.Location = new Point(0x17, 130);
            label14.Name = "r_OLabel";
            label14.Size = new Size(0x54, 0x11);
            label14.TabIndex = 0x34;
            label14.Text = "Отчество:";
            label15.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label15.Location = new Point(0x40, 0x5f);
            label15.Name = "r_ILabel";
            label15.Size = new Size(0x2b, 0x11);
            label15.TabIndex = 50;
            label15.Text = "Имя:";
            label16.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label16.Location = new Point(0x19, 0x3a);
            label16.Name = "r_FLabel";
            label16.Size = new Size(0x52, 0x11);
            label16.TabIndex = 0x30;
            label16.Text = "Фамилия:";
            label16.TextAlign = ContentAlignment.TopCenter;
            label17.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label17.Location = new Point(0x17, 130);
            label17.Name = "d_OLabel";
            label17.Size = new Size(0x54, 0x11);
            label17.TabIndex = 0x3a;
            label17.Text = "Отчество:";
            label18.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label18.Location = new Point(12, 15);
            label18.Name = "label9";
            label18.Size = new Size(0x5f, 0x11);
            label18.TabIndex = 0x24;
            label18.Text = "Должность:";
            label19.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label19.Location = new Point(0x40, 0x5f);
            label19.Name = "d_ILabel";
            label19.Size = new Size(0x2b, 0x11);
            label19.TabIndex = 0x38;
            label19.Text = "Имя:";
            label20.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label20.Location = new Point(0x19, 0x3a);
            label20.Name = "d_FLabel";
            label20.Size = new Size(0x52, 0x11);
            label20.TabIndex = 0x36;
            label20.Text = "Фамилия:";
            label21.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label21.Location = new Point(12, 15);
            label21.Name = "label10";
            label21.Size = new Size(0x5f, 0x11);
            label21.TabIndex = 0x24;
            label21.Text = "Должность:";
            label22.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label22.AutoSize = true;
            label22.CausesValidation = false;
            label22.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label22.Location = new Point(0x17, 130);
            label22.Name = "t_OLabel";
            label22.Size = new Size(0x54, 0x11);
            label22.TabIndex = 0x40;
            label22.Text = "Отчество:";
            label23.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label23.AutoSize = true;
            label23.CausesValidation = false;
            label23.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label23.Location = new Point(0x40, 0x5f);
            label23.Name = "t_ILabel";
            label23.Size = new Size(0x2b, 0x11);
            label23.TabIndex = 0x3e;
            label23.Text = "Имя:";
            label24.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            label24.AutoSize = true;
            label24.CausesValidation = false;
            label24.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            label24.Location = new Point(0x19, 0x3a);
            label24.Name = "t_FLabel";
            label24.Size = new Size(0x52, 0x11);
            label24.TabIndex = 60;
            label24.Text = "Фамилия:";
            this.groupBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_0.Controls.Add(this.radioButton_1);
            this.groupBox_0.Controls.Add(this.radioButton_0);
            this.groupBox_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBox_0.Location = new Point(2, 0);
            this.groupBox_0.Name = "groupBox1";
            this.groupBox_0.Size = new Size(720, 0x25);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.TabStop = false;
            this.radioButton_1.AutoSize = true;
            this.radioButton_1.Location = new Point(0x9c, 12);
            this.radioButton_1.Name = "radioButtonFL";
            this.radioButton_1.Size = new Size(0x83, 0x11);
            this.radioButton_1.TabIndex = 1;
            this.radioButton_1.Text = "Физическое лицо";
            this.radioButton_1.UseVisualStyleBackColor = true;
            this.radioButton_0.AutoSize = true;
            this.radioButton_0.Checked = true;
            this.radioButton_0.Location = new Point(10, 12);
            this.radioButton_0.Name = "radioButtonUL";
            this.radioButton_0.Size = new Size(0x88, 0x11);
            this.radioButton_0.TabIndex = 0;
            this.radioButton_0.TabStop = true;
            this.radioButton_0.Text = "Юридическое лицо";
            this.radioButton_0.UseVisualStyleBackColor = true;
            this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
            this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_0.Location = new Point(0x6d, 10);
            this.textBox_0.Name = "txtCurrentAbn";
            this.textBox_0.Size = new Size(0x25d, 20);
            this.textBox_0.TabIndex = 2;
            this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.bindingSource_0.DataMember = "vAbn";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_37, this.dataGridViewTextBoxColumn_38, this.dataGridViewTextBoxColumn_39, this.dataGridViewTextBoxColumn_40, this.dataGridViewTextBoxColumn_41, this.dataGridViewCheckBoxColumn_1, this.dataGridViewCheckBoxColumn_2 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_0.DefaultCellStyle = style2;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0x18, 0);
            this.dataGridViewExcelFilter_0.Name = "dgvAbn";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = style3;
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.Size = new Size(0x142, 0xa2);
            this.dataGridViewExcelFilter_0.TabIndex = 3;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.timer_0.Interval = 300;
            this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
            this.bindingSource_1.DataMember = "vAbnObjAddress";
            this.bindingSource_1.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_1.CurrentChanged += new EventHandler(this.bindingSource_1_CurrentChanged);
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_10, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_15, this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19, this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21, this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24, this.dataGridViewTextBoxColumn_25,
                this.dataGridViewTextBoxColumn_26, this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32
            };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.Location = new Point(0x18, 0);
            this.dataGridViewExcelFilter_1.Name = "dgvObj";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_1.Size = new Size(0x15a, 0xa2);
            this.dataGridViewExcelFilter_1.TabIndex = 6;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_10.HeaderText = "id";
            this.dataGridViewTextBoxColumn_10.Name = "idObjDgvColumn";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.Visible = false;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "idObjReg";
            this.dataGridViewTextBoxColumn_11.HeaderText = "idObjReg";
            this.dataGridViewTextBoxColumn_11.Name = "idObjRegDgvColumn";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.Visible = false;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_12.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_12.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.Visible = false;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "idMap";
            this.dataGridViewTextBoxColumn_13.HeaderText = "idMap";
            this.dataGridViewTextBoxColumn_13.Name = "idMapDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.Visible = false;
            this.dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn_14.HeaderText = "Объект";
            this.dataGridViewTextBoxColumn_14.Name = "nameObjDgvColumn";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_15.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn_15.Name = "addressULDgvColumn";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_16.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn_16.Name = "addressFLDgvColumn";
            this.dataGridViewTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewTextBoxColumn_16.Visible = false;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_17.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn_17.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.Visible = false;
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "idCity";
            this.dataGridViewTextBoxColumn_18.HeaderText = "idCity";
            this.dataGridViewTextBoxColumn_18.Name = "idCityDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Visible = false;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn_19.HeaderText = "City";
            this.dataGridViewTextBoxColumn_19.Name = "cityDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_19.Visible = false;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "idRaion";
            this.dataGridViewTextBoxColumn_20.HeaderText = "idRaion";
            this.dataGridViewTextBoxColumn_20.Name = "idRaionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewTextBoxColumn_20.Visible = false;
            this.dataGridViewTextBoxColumn_21.DataPropertyName = "Raion";
            this.dataGridViewTextBoxColumn_21.HeaderText = "Raion";
            this.dataGridViewTextBoxColumn_21.Name = "raionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewTextBoxColumn_21.Visible = false;
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "idStreet";
            this.dataGridViewTextBoxColumn_22.HeaderText = "idStreet";
            this.dataGridViewTextBoxColumn_22.Name = "idStreetDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewTextBoxColumn_22.Visible = false;
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn_23.HeaderText = "Street";
            this.dataGridViewTextBoxColumn_23.Name = "streetDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.Visible = false;
            this.dataGridViewTextBoxColumn_24.DataPropertyName = "House";
            this.dataGridViewTextBoxColumn_24.HeaderText = "House";
            this.dataGridViewTextBoxColumn_24.Name = "houseDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewTextBoxColumn_24.Visible = false;
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "HousePrefix";
            this.dataGridViewTextBoxColumn_25.HeaderText = "HousePrefix";
            this.dataGridViewTextBoxColumn_25.Name = "housePrefixDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewTextBoxColumn_25.Visible = false;
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "HouseAll";
            this.dataGridViewTextBoxColumn_26.HeaderText = "HouseAll";
            this.dataGridViewTextBoxColumn_26.Name = "houseAllDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewTextBoxColumn_26.Visible = false;
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "IsHouse";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "IsHouse";
            this.dataGridViewCheckBoxColumn_0.Name = "isHouseDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "Index";
            this.dataGridViewTextBoxColumn_27.HeaderText = "Index";
            this.dataGridViewTextBoxColumn_27.Name = "indexDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewTextBoxColumn_27.Visible = false;
            this.dataGridViewTextBoxColumn_28.DataPropertyName = "Latitude";
            this.dataGridViewTextBoxColumn_28.HeaderText = "Latitude";
            this.dataGridViewTextBoxColumn_28.Name = "latitudeDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewTextBoxColumn_28.Visible = false;
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "Longitude";
            this.dataGridViewTextBoxColumn_29.HeaderText = "Longitude";
            this.dataGridViewTextBoxColumn_29.Name = "longitudeDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewTextBoxColumn_29.Visible = false;
            this.dataGridViewTextBoxColumn_30.DataPropertyName = "idObjParent";
            this.dataGridViewTextBoxColumn_30.HeaderText = "idObjParent";
            this.dataGridViewTextBoxColumn_30.Name = "idObjParentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.Visible = false;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "TypeObj";
            this.dataGridViewTextBoxColumn_31.HeaderText = "TypeObj";
            this.dataGridViewTextBoxColumn_31.Name = "typeObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewTextBoxColumn_31.Visible = false;
            this.dataGridViewTextBoxColumn_32.DataPropertyName = "TypeObjName";
            this.dataGridViewTextBoxColumn_32.HeaderText = "TypeObjName";
            this.dataGridViewTextBoxColumn_32.Name = "typeObjNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewTextBoxColumn_32.Visible = false;
            this.splitContainer_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.splitContainer_0.Location = new Point(2, 0xa8);
            this.splitContainer_0.Name = "splitContainerDgv";
            this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_4);
            this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_1);
            this.splitContainer_0.Panel2.Controls.Add(this.toolStrip_5);
            this.splitContainer_0.Size = new Size(720, 0xa2);
            this.splitContainer_0.SplitterDistance = 0x15a;
            this.splitContainer_0.TabIndex = 7;
            this.toolStrip_4.Dock = DockStyle.Left;
            this.toolStrip_4.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_10, this.toolStripButton_11, this.toolStripButton_12, this.toolStripSeparator_0, this.toolStripButton_16 };
            this.toolStrip_4.Items.AddRange(toolStripItems);
            this.toolStrip_4.Location = new Point(0, 0);
            this.toolStrip_4.Name = "toolStripCont";
            this.toolStrip_4.Size = new Size(0x18, 0xa2);
            this.toolStrip_4.TabIndex = 4;
            this.toolStrip_4.Text = "toolStrip1";
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = (Image) manager.GetObject("toolBtnAddCont.Image");
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnAddCont";
            this.toolStripButton_10.Size = new Size(0x15, 20);
            this.toolStripButton_10.Text = "Создание контрагента";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = (Image) manager.GetObject("toolBtnEditCont.Image");
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnEditCont";
            this.toolStripButton_11.Size = new Size(0x15, 20);
            this.toolStripButton_11.Text = "Редактирование Контрагента";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = (Image) manager.GetObject("toolBtnDelCont.Image");
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnDelCont";
            this.toolStripButton_12.Size = new Size(0x15, 20);
            this.toolStripButton_12.Text = "Удаление контрагента";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(0x15, 6);
            this.toolStripButton_16.CheckOnClick = true;
            this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_16.Image = (Image) manager.GetObject("toolBtnShowDelAbn.Image");
            this.toolStripButton_16.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_16.Name = "toolBtnShowDelAbn";
            this.toolStripButton_16.Size = new Size(0x15, 20);
            this.toolStripButton_16.Text = "Показать удаленных";
            this.toolStripButton_16.Click += new EventHandler(this.toolStripButton_16_Click);
            this.toolStrip_5.Dock = DockStyle.Left;
            this.toolStrip_5.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_13, this.toolStripButton_14, this.toolStripButton_15 };
            this.toolStrip_5.Items.AddRange(itemArray2);
            this.toolStrip_5.Location = new Point(0, 0);
            this.toolStrip_5.Name = "toolStripObj";
            this.toolStrip_5.Size = new Size(0x18, 0xa2);
            this.toolStrip_5.TabIndex = 7;
            this.toolStrip_5.Text = "toolStrip2";
            this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_13.Image = (Image) manager.GetObject("toolBtnAddObj.Image");
            this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_13.Name = "toolBtnAddObj";
            this.toolStripButton_13.Size = new Size(0x15, 20);
            this.toolStripButton_13.Text = "Добавление объекта";
            this.toolStripButton_13.Click += new EventHandler(this.toolStripButton_13_Click);
            this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_14.Image = (Image) manager.GetObject("toolBtnEditObj.Image");
            this.toolStripButton_14.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_14.Name = "toolBtnEditObj";
            this.toolStripButton_14.Size = new Size(0x15, 20);
            this.toolStripButton_14.Text = "Редактирование объекта";
            this.toolStripButton_14.Click += new EventHandler(this.toolStripButton_14_Click);
            this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_15.Image = (Image) manager.GetObject("toolBtnDelObj.Image");
            this.toolStripButton_15.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_15.Name = "toolBtnDelObj";
            this.toolStripButton_15.Size = new Size(0x15, 20);
            this.toolStripButton_15.Text = "Удаление объекта";
            this.toolStripButton_15.Click += new EventHandler(this.toolStripButton_15_Click);
            this.groupBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_1.Controls.Add(this.textBox_1);
            this.groupBox_1.Controls.Add(this.label_4);
            this.groupBox_1.Controls.Add(this.textBox_2);
            this.groupBox_1.Controls.Add(this.label_5);
            this.groupBox_1.Controls.Add(this.textBox_3);
            this.groupBox_1.Controls.Add(this.label_6);
            this.groupBox_1.Controls.Add(this.comboBox_1);
            this.groupBox_1.Controls.Add(this.label_0);
            this.groupBox_1.Controls.Add(this.comboBox_2);
            this.groupBox_1.Controls.Add(this.label_1);
            this.groupBox_1.Controls.Add(this.comboBox_3);
            this.groupBox_1.Controls.Add(this.label_2);
            this.groupBox_1.Controls.Add(this.label_3);
            this.groupBox_1.Controls.Add(this.comboBox_0);
            this.groupBox_1.Controls.Add(this.radioButton_3);
            this.groupBox_1.Controls.Add(this.radioButton_2);
            this.groupBox_1.Controls.Add(this.textBox_0);
            this.groupBox_1.Location = new Point(2, 0x23);
            this.groupBox_1.Name = "groupBoxSelect";
            this.groupBox_1.Size = new Size(720, 0x6d);
            this.groupBox_1.TabIndex = 8;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Фильтр";
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_1.Enabled = false;
            this.textBox_1.Location = new Point(0x289, 0x52);
            this.textBox_1.Name = "txtFlat";
            this.textBox_1.Size = new Size(0x3d, 20);
            this.textBox_1.TabIndex = 0x13;
            this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
            this.label_4.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(0x289, 70);
            this.label_4.Name = "label8";
            this.label_4.Size = new Size(0x37, 13);
            this.label_4.TabIndex = 0x12;
            this.label_4.Text = "Квартира";
            this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_2.Enabled = false;
            this.textBox_2.Location = new Point(0x25b, 0x52);
            this.textBox_2.Name = "txtHousePrefix";
            this.textBox_2.Size = new Size(40, 20);
            this.textBox_2.TabIndex = 0x11;
            this.textBox_2.TextChanged += new EventHandler(this.textBox_2_TextChanged);
            this.label_5.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(600, 70);
            this.label_5.Name = "label7";
            this.label_5.Size = new Size(0x2b, 13);
            this.label_5.TabIndex = 0x10;
            this.label_5.Text = "Корпус";
            this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_3.Enabled = false;
            this.textBox_3.Location = new Point(0x234, 0x52);
            this.textBox_3.Name = "txtHouse";
            this.textBox_3.Size = new Size(0x21, 20);
            this.textBox_3.TabIndex = 14;
            this.textBox_3.TextChanged += new EventHandler(this.textBox_3_TextChanged);
            this.label_6.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(0x234, 70);
            this.label_6.Name = "label5";
            this.label_6.Size = new Size(30, 13);
            this.label_6.TabIndex = 13;
            this.label_6.Text = "Дом";
            this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_1.DataSource = this.dataSet_0;
            this.comboBox_1.DisplayMember = "tR_KladrStreet.NameSocr";
            this.comboBox_1.Enabled = false;
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0xb1, 0x52);
            this.comboBox_1.Name = "cmbStreet";
            this.comboBox_1.Size = new Size(0x17d, 0x15);
            this.comboBox_1.TabIndex = 12;
            this.comboBox_1.ValueMember = "tR_KladrStreet.Id";
            this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "tR_KladrStreet";
            this.dataColumn_0.ColumnName = "Id";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "Name";
            this.dataColumn_2.ColumnName = "Socr";
            this.dataColumn_3.ColumnName = "NameSocr";
            this.dataColumn_3.Expression = "Name + ' ' + isnull(socr, '')";
            this.dataColumn_3.ReadOnly = true;
            this.dataColumn_4.ColumnName = "Index";
            this.label_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0xae, 0x43);
            this.label_0.Name = "label4";
            this.label_0.Size = new Size(0x27, 13);
            this.label_0.TabIndex = 11;
            this.label_0.Text = "Улица";
            this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_2.DataSource = this.dataSet_1;
            this.comboBox_2.DisplayMember = "tR_KladrObj.NameSocr";
            this.comboBox_2.Enabled = false;
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(6, 0x52);
            this.comboBox_2.Name = "cmbPunkt";
            this.comboBox_2.Size = new Size(0x9c, 0x15);
            this.comboBox_2.TabIndex = 10;
            this.comboBox_2.ValueMember = "tR_KladrObj.Id";
            this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_2_SelectedIndexChanged);
            this.dataSet_1.DataSetName = "NewDataSet";
            DataTable[] tableArray2 = new DataTable[] { this.dataTable_1 };
            this.dataSet_1.Tables.AddRange(tableArray2);
            DataColumn[] columnArray4 = new DataColumn[] { this.dataColumn_5, this.dataColumn_6, this.dataColumn_7, this.dataColumn_8 };
            this.dataTable_1.Columns.AddRange(columnArray4);
            this.dataTable_1.TableName = "tR_KladrObj";
            this.dataColumn_5.ColumnName = "Id";
            this.dataColumn_5.DataType = typeof(int);
            this.dataColumn_6.ColumnName = "Name";
            this.dataColumn_7.ColumnName = "Socr";
            this.dataColumn_8.ColumnName = "NameSocr";
            this.dataColumn_8.Expression = "Name + ' ' + isnull(socr, '')";
            this.dataColumn_8.ReadOnly = true;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(7, 0x43);
            this.label_1.Name = "label3";
            this.label_1.Size = new Size(0x3d, 13);
            this.label_1.TabIndex = 9;
            this.label_1.Text = "Нас. пункт";
            this.comboBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_3.DataSource = this.dataSet_2;
            this.comboBox_3.DisplayMember = "tR_KladrObj.NameSocr";
            this.comboBox_3.Enabled = false;
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(0x10a, 0x2e);
            this.comboBox_3.Name = "cmbCity";
            this.comboBox_3.Size = new Size(0x1bf, 0x15);
            this.comboBox_3.TabIndex = 8;
            this.comboBox_3.ValueMember = "tR_KladrObj.Id";
            this.comboBox_3.SelectedIndexChanged += new EventHandler(this.comboBox_3_SelectedIndexChanged);
            this.dataSet_2.DataSetName = "NewDataSet";
            DataTable[] tableArray3 = new DataTable[] { this.dataTable_2 };
            this.dataSet_2.Tables.AddRange(tableArray3);
            DataColumn[] columnArray5 = new DataColumn[] { this.dataColumn_9, this.dataColumn_10, this.dataColumn_11, this.dataColumn_12 };
            this.dataTable_2.Columns.AddRange(columnArray5);
            this.dataTable_2.TableName = "tR_KladrObj";
            this.dataColumn_9.ColumnName = "Id";
            this.dataColumn_9.DataType = typeof(int);
            this.dataColumn_10.ColumnName = "Name";
            this.dataColumn_11.ColumnName = "Socr";
            this.dataColumn_12.ColumnName = "NameSocr";
            this.dataColumn_12.Expression = "Name + ' ' + isnull(socr, '')";
            this.dataColumn_12.ReadOnly = true;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(0x107, 0x1f);
            this.label_2.Name = "label2";
            this.label_2.Size = new Size(0x25, 13);
            this.label_2.TabIndex = 7;
            this.label_2.Text = "Город";
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(0x6a, 0x1f);
            this.label_3.Name = "label1";
            this.label_3.Size = new Size(0x2b, 13);
            this.label_3.TabIndex = 6;
            this.label_3.Text = "Регион";
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.DataSource = this.dataSet_3;
            this.comboBox_0.DisplayMember = "tR_KladrObj.NameSocr";
            this.comboBox_0.Enabled = false;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x6d, 0x2e);
            this.comboBox_0.Name = "cmbObl";
            this.comboBox_0.Size = new Size(0x8d, 0x15);
            this.comboBox_0.TabIndex = 5;
            this.comboBox_0.ValueMember = "tR_KladrObj.Id";
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.dataSet_3.DataSetName = "NewDataSet";
            DataTable[] tableArray4 = new DataTable[] { this.dataTable_3 };
            this.dataSet_3.Tables.AddRange(tableArray4);
            DataColumn[] columnArray6 = new DataColumn[] { this.dataColumn_13, this.dataColumn_14, this.dataColumn_15, this.dataColumn_16 };
            this.dataTable_3.Columns.AddRange(columnArray6);
            this.dataTable_3.TableName = "tR_KladrObj";
            this.dataColumn_13.ColumnName = "Id";
            this.dataColumn_13.DataType = typeof(int);
            this.dataColumn_14.ColumnName = "Name";
            this.dataColumn_15.ColumnName = "Socr";
            this.dataColumn_16.ColumnName = "NameSocr";
            this.dataColumn_16.Expression = "Name + ' ' + isnull(socr, '')";
            this.dataColumn_16.ReadOnly = true;
            this.radioButton_3.AutoSize = true;
            this.radioButton_3.Location = new Point(6, 0x2b);
            this.radioButton_3.Name = "radioButtonSelAddress";
            this.radioButton_3.Size = new Size(0x4b, 0x11);
            this.radioButton_3.TabIndex = 4;
            this.radioButton_3.Text = "по адресу";
            this.radioButton_3.UseVisualStyleBackColor = true;
            this.radioButton_2.AutoSize = true;
            this.radioButton_2.Checked = true;
            this.radioButton_2.Location = new Point(6, 11);
            this.radioButton_2.Name = "radioButtonSelectName";
            this.radioButton_2.Size = new Size(0x48, 0x11);
            this.radioButton_2.TabIndex = 3;
            this.radioButton_2.TabStop = true;
            this.radioButton_2.Text = "по имени";
            this.radioButton_2.UseVisualStyleBackColor = true;
            this.radioButton_2.CheckedChanged += new EventHandler(this.radioButton_2_CheckedChanged);
            this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_6);
            this.tabControl_0.Controls.Add(this.tabPage_7);
            this.tabControl_0.Controls.Add(this.tabPage_8);
            this.tabControl_0.Location = new Point(1, 0x14b);
            this.tabControl_0.Name = "tabControlContr";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x2d7, 0xd9);
            this.tabControl_0.TabIndex = 9;
            this.tabPage_0.Controls.Add(this.textBox_4);
            this.tabPage_0.Controls.Add(this.textBox_5);
            this.tabPage_0.Controls.Add(this.textBox_6);
            this.tabPage_0.Controls.Add(this.textBox_7);
            this.tabPage_0.Controls.Add(this.textBox_8);
            this.tabPage_0.Controls.Add(this.textBox_9);
            this.tabPage_0.Controls.Add(this.textBox_10);
            this.tabPage_0.Controls.Add(this.textBox_11);
            this.tabPage_0.Controls.Add(label);
            this.tabPage_0.Controls.Add(label2);
            this.tabPage_0.Controls.Add(label3);
            this.tabPage_0.Controls.Add(label4);
            this.tabPage_0.Controls.Add(label5);
            this.tabPage_0.Controls.Add(label6);
            this.tabPage_0.Controls.Add(label7);
            this.tabPage_0.Controls.Add(label8);
            this.tabPage_0.Controls.Add(this.toolStrip_0);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageAbnInfo";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x2cf, 0xbf);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Реквизиты";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_4.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnInfo.NameFull", true));
            this.textBox_4.Location = new Point(0x77, 3);
            this.textBox_4.Multiline = true;
            this.textBox_4.Name = "nameFullTextBox";
            this.textBox_4.ReadOnly = true;
            this.textBox_4.Size = new Size(0x24f, 0x34);
            this.textBox_4.TabIndex = 0x26;
            this.textBox_5.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnInfo.INN", true));
            this.textBox_5.Location = new Point(0x77, 0x41);
            this.textBox_5.Name = "iNNTextBox";
            this.textBox_5.ReadOnly = true;
            this.textBox_5.Size = new Size(230, 20);
            this.textBox_5.TabIndex = 40;
            this.textBox_6.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnInfo.BankAcnt", true));
            this.textBox_6.Location = new Point(0xa7, 0xa8);
            this.textBox_6.Name = "bankAcntTextBox";
            this.textBox_6.ReadOnly = true;
            this.textBox_6.Size = new Size(0xdf, 20);
            this.textBox_6.TabIndex = 0x34;
            this.textBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_7.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnInfo.KPP", true));
            this.textBox_7.Location = new Point(0x18c, 0x3d);
            this.textBox_7.Name = "kPPTextBox";
            this.textBox_7.ReadOnly = true;
            this.textBox_7.Size = new Size(0x13a, 20);
            this.textBox_7.TabIndex = 0x2a;
            this.textBox_8.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_8.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnInfo.BankDestName", true));
            this.textBox_8.Location = new Point(0xa7, 0x8e);
            this.textBox_8.Name = "bankDestTextBox";
            this.textBox_8.ReadOnly = true;
            this.textBox_8.Size = new Size(0x21f, 20);
            this.textBox_8.TabIndex = 50;
            this.textBox_9.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnInfo.OKVED", true));
            this.textBox_9.Location = new Point(0x77, 0x57);
            this.textBox_9.Name = "oKVEDTextBox";
            this.textBox_9.ReadOnly = true;
            this.textBox_9.Size = new Size(230, 20);
            this.textBox_9.TabIndex = 0x2c;
            this.textBox_10.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_10.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnInfo.BankName", true));
            this.textBox_10.Location = new Point(0xa7, 0x74);
            this.textBox_10.Name = "bankIDTextBox";
            this.textBox_10.ReadOnly = true;
            this.textBox_10.Size = new Size(0x21f, 20);
            this.textBox_10.TabIndex = 0x30;
            this.textBox_11.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_11.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnInfo.OKPO", true));
            this.textBox_11.Location = new Point(0x18c, 0x57);
            this.textBox_11.Name = "oKPOTextBox";
            this.textBox_11.ReadOnly = true;
            this.textBox_11.Size = new Size(0x13a, 20);
            this.textBox_11.TabIndex = 0x2e;
            this.toolStrip_0.Dock = DockStyle.Left;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2 };
            this.toolStrip_0.Items.AddRange(itemArray3);
            this.toolStrip_0.Location = new Point(3, 3);
            this.toolStrip_0.Name = "tsAbnInfo";
            this.toolStrip_0.Size = new Size(0x18, 0xb9);
            this.toolStrip_0.TabIndex = 0x24;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = (Image) manager.GetObject("tsbAddAbnInfo.Image");
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "tsbAddAbnInfo";
            this.toolStripButton_0.Size = new Size(0x15, 20);
            this.toolStripButton_0.Text = "Новые реквизиты";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = (Image) manager.GetObject("tsbEditInfo.Image");
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "tsbEditInfo";
            this.toolStripButton_1.Size = new Size(0x15, 20);
            this.toolStripButton_1.Text = "Редактировать реквизиты";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = (Image) manager.GetObject("tsbInfoHistory.Image");
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "tsbInfoHistory";
            this.toolStripButton_2.Size = new Size(0x15, 20);
            this.toolStripButton_2.Text = "Истрия реквизитов";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.tabPage_1.Controls.Add(this.tabControl_1);
            this.tabPage_1.Controls.Add(this.toolStrip_1);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageDirector";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x2cf, 0xbf);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Руководитель";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.tabControl_1.Controls.Add(this.tabPage_2);
            this.tabControl_1.Controls.Add(this.tabPage_3);
            this.tabControl_1.Controls.Add(this.tabPage_4);
            this.tabControl_1.Controls.Add(this.tabPage_5);
            this.tabControl_1.Dock = DockStyle.Fill;
            this.tabControl_1.Location = new Point(0x1b, 3);
            this.tabControl_1.Name = "tabControlDirectorFIO";
            this.tabControl_1.SelectedIndex = 0;
            this.tabControl_1.Size = new Size(0x2b1, 0xb9);
            this.tabControl_1.TabIndex = 40;
            this.tabPage_2.Controls.Add(this.textBox_12);
            this.tabPage_2.Controls.Add(label9);
            this.tabPage_2.Controls.Add(label10);
            this.tabPage_2.Controls.Add(this.textBox_13);
            this.tabPage_2.Controls.Add(label11);
            this.tabPage_2.Controls.Add(this.textBox_14);
            this.tabPage_2.Controls.Add(label12);
            this.tabPage_2.Controls.Add(this.textBox_15);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPageI";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x2a9, 0x9f);
            this.tabPage_2.TabIndex = 0;
            this.tabPage_2.Text = "Именительный (кто)";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.textBox_12.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_12.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.I_Post", true));
            this.textBox_12.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_12.Location = new Point(0x71, 15);
            this.textBox_12.Multiline = true;
            this.textBox_12.Name = "I_postTextBox";
            this.textBox_12.ReadOnly = true;
            this.textBox_12.Size = new Size(0x228, 0x19);
            this.textBox_12.TabIndex = 0x21;
            this.textBox_13.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_13.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.I_O", true));
            this.textBox_13.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_13.Location = new Point(0x71, 0x7f);
            this.textBox_13.Name = "i_OTextBox";
            this.textBox_13.ReadOnly = true;
            this.textBox_13.Size = new Size(0x228, 0x17);
            this.textBox_13.TabIndex = 0x2b;
            this.textBox_14.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_14.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.I_I", true));
            this.textBox_14.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_14.Location = new Point(0x71, 0x5c);
            this.textBox_14.Name = "i_ITextBox";
            this.textBox_14.ReadOnly = true;
            this.textBox_14.Size = new Size(0x228, 0x17);
            this.textBox_14.TabIndex = 0x29;
            this.textBox_15.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_15.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.I_F", true));
            this.textBox_15.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_15.Location = new Point(0x71, 0x37);
            this.textBox_15.Name = "i_FTextBox";
            this.textBox_15.ReadOnly = true;
            this.textBox_15.Size = new Size(0x228, 0x17);
            this.textBox_15.TabIndex = 0x27;
            this.tabPage_3.Controls.Add(this.textBox_16);
            this.tabPage_3.Controls.Add(label13);
            this.tabPage_3.Controls.Add(label14);
            this.tabPage_3.Controls.Add(this.textBox_17);
            this.tabPage_3.Controls.Add(label15);
            this.tabPage_3.Controls.Add(this.textBox_18);
            this.tabPage_3.Controls.Add(label16);
            this.tabPage_3.Controls.Add(this.textBox_19);
            this.tabPage_3.Location = new Point(4, 0x16);
            this.tabPage_3.Name = "tabPageR";
            this.tabPage_3.Padding = new Padding(3);
            this.tabPage_3.Size = new Size(0x2a9, 0x9f);
            this.tabPage_3.TabIndex = 1;
            this.tabPage_3.Text = "Родительный (кого)";
            this.tabPage_3.UseVisualStyleBackColor = true;
            this.textBox_16.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_16.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.R_Post", true));
            this.textBox_16.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_16.Location = new Point(0x71, 15);
            this.textBox_16.Multiline = true;
            this.textBox_16.Name = "R_postTextBox";
            this.textBox_16.ReadOnly = true;
            this.textBox_16.Size = new Size(0x228, 0x19);
            this.textBox_16.TabIndex = 0x23;
            this.textBox_17.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_17.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.R_O", true));
            this.textBox_17.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_17.Location = new Point(0x71, 0x7f);
            this.textBox_17.Name = "r_OTextBox";
            this.textBox_17.ReadOnly = true;
            this.textBox_17.Size = new Size(0x228, 0x17);
            this.textBox_17.TabIndex = 0x35;
            this.textBox_18.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_18.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.R_I", true));
            this.textBox_18.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_18.Location = new Point(0x71, 0x5c);
            this.textBox_18.Name = "r_ITextBox";
            this.textBox_18.ReadOnly = true;
            this.textBox_18.Size = new Size(0x228, 0x17);
            this.textBox_18.TabIndex = 0x33;
            this.textBox_19.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_19.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.R_F", true));
            this.textBox_19.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_19.Location = new Point(0x71, 0x37);
            this.textBox_19.Name = "r_FTextBox";
            this.textBox_19.ReadOnly = true;
            this.textBox_19.Size = new Size(0x228, 0x17);
            this.textBox_19.TabIndex = 0x31;
            this.tabPage_4.Controls.Add(this.textBox_20);
            this.tabPage_4.Controls.Add(label17);
            this.tabPage_4.Controls.Add(label18);
            this.tabPage_4.Controls.Add(this.textBox_21);
            this.tabPage_4.Controls.Add(label19);
            this.tabPage_4.Controls.Add(this.textBox_22);
            this.tabPage_4.Controls.Add(label20);
            this.tabPage_4.Controls.Add(this.textBox_23);
            this.tabPage_4.Location = new Point(4, 0x16);
            this.tabPage_4.Name = "tabPageD";
            this.tabPage_4.Padding = new Padding(3);
            this.tabPage_4.Size = new Size(0x2a9, 0x9f);
            this.tabPage_4.TabIndex = 2;
            this.tabPage_4.Text = "Дательный (кому)";
            this.tabPage_4.UseVisualStyleBackColor = true;
            this.textBox_20.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_20.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.D_Post", true));
            this.textBox_20.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_20.Location = new Point(0x71, 15);
            this.textBox_20.Multiline = true;
            this.textBox_20.Name = "D_postTextBox";
            this.textBox_20.ReadOnly = true;
            this.textBox_20.Size = new Size(0x228, 0x19);
            this.textBox_20.TabIndex = 0x25;
            this.textBox_21.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_21.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.D_O", true));
            this.textBox_21.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_21.Location = new Point(0x71, 0x7f);
            this.textBox_21.Name = "d_OTextBox";
            this.textBox_21.ReadOnly = true;
            this.textBox_21.Size = new Size(0x228, 0x17);
            this.textBox_21.TabIndex = 0x3b;
            this.textBox_22.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_22.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.D_I", true));
            this.textBox_22.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_22.Location = new Point(0x71, 0x5c);
            this.textBox_22.Name = "d_ITextBox";
            this.textBox_22.ReadOnly = true;
            this.textBox_22.Size = new Size(0x228, 0x17);
            this.textBox_22.TabIndex = 0x39;
            this.textBox_23.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_23.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.D_F", true));
            this.textBox_23.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_23.Location = new Point(0x71, 0x37);
            this.textBox_23.Name = "d_FTextBox";
            this.textBox_23.ReadOnly = true;
            this.textBox_23.Size = new Size(0x228, 0x17);
            this.textBox_23.TabIndex = 0x37;
            this.tabPage_5.CausesValidation = false;
            this.tabPage_5.Controls.Add(this.textBox_24);
            this.tabPage_5.Controls.Add(label21);
            this.tabPage_5.Controls.Add(label22);
            this.tabPage_5.Controls.Add(this.textBox_25);
            this.tabPage_5.Controls.Add(label23);
            this.tabPage_5.Controls.Add(this.textBox_26);
            this.tabPage_5.Controls.Add(label24);
            this.tabPage_5.Controls.Add(this.textBox_27);
            this.tabPage_5.Location = new Point(4, 0x16);
            this.tabPage_5.Name = "tabPageT";
            this.tabPage_5.Padding = new Padding(3);
            this.tabPage_5.Size = new Size(0x2a9, 0x9f);
            this.tabPage_5.TabIndex = 3;
            this.tabPage_5.Text = "Творительный (кем)";
            this.tabPage_5.UseVisualStyleBackColor = true;
            this.textBox_24.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_24.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.T_Post", true));
            this.textBox_24.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_24.Location = new Point(0x71, 15);
            this.textBox_24.Multiline = true;
            this.textBox_24.Name = "T_postTextBox";
            this.textBox_24.ReadOnly = true;
            this.textBox_24.Size = new Size(0x228, 0x19);
            this.textBox_24.TabIndex = 0x25;
            this.textBox_25.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_25.CausesValidation = false;
            this.textBox_25.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.T_O", true));
            this.textBox_25.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_25.Location = new Point(0x71, 0x7f);
            this.textBox_25.Name = "t_OTextBox";
            this.textBox_25.ReadOnly = true;
            this.textBox_25.Size = new Size(0x228, 0x17);
            this.textBox_25.TabIndex = 0x41;
            this.textBox_26.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_26.CausesValidation = false;
            this.textBox_26.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.T_I", true));
            this.textBox_26.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_26.Location = new Point(0x71, 0x5c);
            this.textBox_26.Name = "t_ITextBox";
            this.textBox_26.ReadOnly = true;
            this.textBox_26.Size = new Size(0x228, 0x17);
            this.textBox_26.TabIndex = 0x3f;
            this.textBox_27.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox_27.CausesValidation = false;
            this.textBox_27.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tG_AbnChief.T_F", true));
            this.textBox_27.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.textBox_27.Location = new Point(0x71, 0x37);
            this.textBox_27.Name = "t_FTextBox";
            this.textBox_27.ReadOnly = true;
            this.textBox_27.Size = new Size(0x228, 0x17);
            this.textBox_27.TabIndex = 0x3d;
            this.toolStrip_1.Dock = DockStyle.Left;
            this.toolStrip_1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripButton_3, this.toolStripButton_4, this.toolStripButton_5 };
            this.toolStrip_1.Items.AddRange(itemArray4);
            this.toolStrip_1.Location = new Point(3, 3);
            this.toolStrip_1.Name = "tsDirector";
            this.toolStrip_1.Size = new Size(0x18, 0xb9);
            this.toolStrip_1.TabIndex = 0x27;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = (Image) manager.GetObject("tsbDirectorAdd.Image");
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "tsbDirectorAdd";
            this.toolStripButton_3.Size = new Size(0x15, 20);
            this.toolStripButton_3.Text = "Новый руководитель";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = (Image) manager.GetObject("tsbDirectorEdit.Image");
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "tsbDirectorEdit";
            this.toolStripButton_4.Size = new Size(0x15, 20);
            this.toolStripButton_4.Text = "Редактировать руководителя";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = (Image) manager.GetObject("tsbDirectorHistory.Image");
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "tsbDirectorHistory";
            this.toolStripButton_5.Size = new Size(0x15, 20);
            this.toolStripButton_5.Text = "История руководителей";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.tabPage_6.Controls.Add(this.groupBox_2);
            this.tabPage_6.Controls.Add(this.groupBox_3);
            this.tabPage_6.Controls.Add(this.toolStrip_2);
            this.tabPage_6.Location = new Point(4, 0x16);
            this.tabPage_6.Name = "tabPageAddress";
            this.tabPage_6.Padding = new Padding(3);
            this.tabPage_6.Size = new Size(0x2cf, 0xbf);
            this.tabPage_6.TabIndex = 2;
            this.tabPage_6.Text = "Адреса";
            this.tabPage_6.UseVisualStyleBackColor = true;
            this.groupBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.groupBox_2.Controls.Add(this.richTextBox_0);
            this.groupBox_2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBox_2.Location = new Point(30, 0x5d);
            this.groupBox_2.Name = "groupBoxAddressP";
            this.groupBox_2.Size = new Size(0x2ae, 0x65);
            this.groupBox_2.TabIndex = 7;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Почтовый адрес";
            this.richTextBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnAddressP.Representation", true));
            this.richTextBox_0.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.richTextBox_0.Location = new Point(12, 0x13);
            this.richTextBox_0.Name = "richTextBoxAddressP";
            this.richTextBox_0.ReadOnly = true;
            this.richTextBox_0.Size = new Size(0x290, 0x41);
            this.richTextBox_0.TabIndex = 0;
            this.richTextBox_0.Text = "";
            this.groupBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.groupBox_3.Controls.Add(this.richTextBox_1);
            this.groupBox_3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBox_3.Location = new Point(30, 1);
            this.groupBox_3.Name = "groupBoxAddressL";
            this.groupBox_3.Size = new Size(0x2af, 0x61);
            this.groupBox_3.TabIndex = 6;
            this.groupBox_3.TabStop = false;
            this.groupBox_3.Text = "Юридический адрес";
            this.richTextBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.richTextBox_1.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "vG_AbnAddressL.Representation", true));
            this.richTextBox_1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.richTextBox_1.Location = new Point(13, 0x13);
            this.richTextBox_1.Name = "richTextBoxAddressL";
            this.richTextBox_1.ReadOnly = true;
            this.richTextBox_1.Size = new Size(0x290, 0x43);
            this.richTextBox_1.TabIndex = 1;
            this.richTextBox_1.Text = "";
            this.toolStrip_2.Dock = DockStyle.Left;
            this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolStripButton_6 };
            this.toolStrip_2.Items.AddRange(itemArray5);
            this.toolStrip_2.Location = new Point(3, 3);
            this.toolStrip_2.Name = "tsAddress";
            this.toolStrip_2.Size = new Size(0x18, 0xb9);
            this.toolStrip_2.TabIndex = 5;
            this.toolStrip_2.Text = "toolStrip1";
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = (Image) manager.GetObject("tsbAddressHistory.Image");
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "tsbAddressHistory";
            this.toolStripButton_6.Size = new Size(0x15, 20);
            this.toolStripButton_6.Text = "История адресов";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.tabPage_7.Controls.Add(this.dataGridView_0);
            this.tabPage_7.Controls.Add(this.toolStrip_3);
            this.tabPage_7.Location = new Point(4, 0x16);
            this.tabPage_7.Name = "tabPageContacts";
            this.tabPage_7.Padding = new Padding(3);
            this.tabPage_7.Size = new Size(0x2cf, 0xbf);
            this.tabPage_7.TabIndex = 3;
            this.tabPage_7.Text = "Контакты";
            this.tabPage_7.UseVisualStyleBackColor = true;
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray7 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9 };
            this.dataGridView_0.Columns.AddRange(columnArray7);
            this.dataGridView_0.DataSource = this.bindingSource_2;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.Location = new Point(0x1b, 3);
            this.dataGridView_0.MultiSelect = false;
            this.dataGridView_0.Name = "dGVAbnContact";
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.RowHeadersWidth = 5;
            this.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_0.RowTemplate.Height = 0x18;
            this.dataGridView_0.Size = new Size(0x2b1, 0xb9);
            this.dataGridView_0.TabIndex = 6;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDGVTBC";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_1.Name = "idAbnDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "Post";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn_2.Name = "postDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "F";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn_3.Name = "fDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "I";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn_4.Name = "iDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "O";
            this.dataGridViewTextBoxColumn_5.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn_5.Name = "oDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn_6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn_6.Name = "phoneDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn_7.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn_7.Name = "emailDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "DateChange";
            this.dataGridViewTextBoxColumn_8.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_8.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_9.HeaderText = "Коментарий";
            this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.bindingSource_2.DataMember = "tAbnContact";
            this.bindingSource_2.DataSource = this.dataSetTechConnection_0;
            this.toolStrip_3.Dock = DockStyle.Left;
            this.toolStrip_3.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolStripButton_7, this.toolStripButton_8, this.toolStripButton_9 };
            this.toolStrip_3.Items.AddRange(itemArray6);
            this.toolStrip_3.Location = new Point(3, 3);
            this.toolStrip_3.Name = "toolStripContact";
            this.toolStrip_3.Size = new Size(0x18, 0xb9);
            this.toolStrip_3.TabIndex = 3;
            this.toolStrip_3.Text = "toolStrip1";
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = (Image) manager.GetObject("toolStripButtonNewContact.Image");
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolStripButtonNewContact";
            this.toolStripButton_7.Size = new Size(0x15, 20);
            this.toolStripButton_7.Text = "Новый контакт";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = (Image) manager.GetObject("toolStripButtonEditContac.Image");
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolStripButtonEditContac";
            this.toolStripButton_8.Size = new Size(0x15, 20);
            this.toolStripButton_8.Text = "Редактировать контакт";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = (Image) manager.GetObject("toolStripButtonDelContact.Image");
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolStripButtonDelContact";
            this.toolStripButton_9.Size = new Size(0x15, 20);
            this.toolStripButton_9.Text = "Удалить контакт";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
            this.tabPage_8.Controls.Add(this.dataGridViewExcelFilter_2);
            this.tabPage_8.Controls.Add(this.toolStrip_6);
            this.tabPage_8.Location = new Point(4, 0x16);
            this.tabPage_8.Name = "tabPageTypeAbn";
            this.tabPage_8.Padding = new Padding(3);
            this.tabPage_8.Size = new Size(0x2cf, 0xbf);
            this.tabPage_8.TabIndex = 4;
            this.tabPage_8.Text = "Принадлежность к типу";
            this.tabPage_8.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray8 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_33, this.dataGridViewTextBoxColumn_34, this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36 };
            this.dataGridViewExcelFilter_2.Columns.AddRange(columnArray8);
            this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_3;
            this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_2.Location = new Point(0x1b, 3);
            this.dataGridViewExcelFilter_2.Name = "dgvAbnType";
            this.dataGridViewExcelFilter_2.ReadOnly = true;
            this.dataGridViewExcelFilter_2.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_2.Size = new Size(0x2b1, 0xb9);
            this.dataGridViewExcelFilter_2.TabIndex = 0x26;
            this.dataGridViewTextBoxColumn_33.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_33.DataPropertyName = "typeKontragentName";
            this.dataGridViewTextBoxColumn_33.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn_33.Name = "typeKontragentNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewTextBoxColumn_34.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_34.HeaderText = "id";
            this.dataGridViewTextBoxColumn_34.Name = "idAbnTypeDgvColumn";
            this.dataGridViewTextBoxColumn_34.ReadOnly = true;
            this.dataGridViewTextBoxColumn_34.Visible = false;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "CodeAbonent";
            this.dataGridViewTextBoxColumn_35.HeaderText = "CodeAbonent";
            this.dataGridViewTextBoxColumn_35.Name = "codeAbonentDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_35.ReadOnly = true;
            this.dataGridViewTextBoxColumn_35.Visible = false;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "typeKontragent";
            this.dataGridViewTextBoxColumn_36.HeaderText = "typeKontragent";
            this.dataGridViewTextBoxColumn_36.Name = "typeKontragentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_36.ReadOnly = true;
            this.dataGridViewTextBoxColumn_36.Visible = false;
            this.bindingSource_3.DataMember = "vAbnType";
            this.bindingSource_3.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_3.Sort = "typeKontragentName";
            this.toolStrip_6.Dock = DockStyle.Left;
            this.toolStrip_6.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.toolStripButton_17, this.toolStripButton_18, this.toolStripButton_19 };
            this.toolStrip_6.Items.AddRange(itemArray7);
            this.toolStrip_6.Location = new Point(3, 3);
            this.toolStrip_6.Name = "toolStripAbnType";
            this.toolStrip_6.Size = new Size(0x18, 0xb9);
            this.toolStrip_6.TabIndex = 0x25;
            this.toolStrip_6.Text = "toolStrip1";
            this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_17.Image = (Image) manager.GetObject("toolStripButton1.Image");
            this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_17.Name = "toolStripButton1";
            this.toolStripButton_17.Size = new Size(0x15, 20);
            this.toolStripButton_17.Text = "Добавить";
            this.toolStripButton_17.Click += new EventHandler(this.toolStripButton_17_Click);
            this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_18.Image = (Image) manager.GetObject("toolStripButton2.Image");
            this.toolStripButton_18.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_18.Name = "toolStripButton2";
            this.toolStripButton_18.Size = new Size(0x15, 20);
            this.toolStripButton_18.Text = "Редактировать";
            this.toolStripButton_18.Click += new EventHandler(this.toolStripButton_18_Click);
            this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_19.Image = (Image) manager.GetObject("toolStripButton3.Image");
            this.toolStripButton_19.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_19.Name = "toolStripButton3";
            this.toolStripButton_19.Size = new Size(0x15, 20);
            this.toolStripButton_19.Text = "Удалить";
            this.toolStripButton_19.Click += new EventHandler(this.toolStripButton_19_Click);
            this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(12, 0x22a);
            this.button_0.Name = "buttonОК";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 10;
            this.button_0.Text = "ОК";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.DialogResult = DialogResult.Cancel;
            this.button_1.Location = new Point(0x281, 0x22a);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 11;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new Point(12, 0x91);
            this.checkBox_0.Name = "chkVisibleNoActiveAbn";
            this.checkBox_0.Size = new Size(0xc2, 0x11);
            this.checkBox_0.TabIndex = 12;
            this.checkBox_0.Text = "Показать неактивных абонентов";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            this.dataGridViewTextBoxColumn_37.DataPropertyName = "CodeAbonent";
            this.dataGridViewTextBoxColumn_37.HeaderText = "Код";
            this.dataGridViewTextBoxColumn_37.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_37.ReadOnly = true;
            this.dataGridViewTextBoxColumn_37.Width = 80;
            this.dataGridViewTextBoxColumn_38.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_38.HeaderText = "id";
            this.dataGridViewTextBoxColumn_38.Name = "idKontragentDgvColumn";
            this.dataGridViewTextBoxColumn_38.ReadOnly = true;
            this.dataGridViewTextBoxColumn_38.Visible = false;
            this.dataGridViewTextBoxColumn_39.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_39.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn_39.HeaderText = "Контрагент";
            this.dataGridViewTextBoxColumn_39.Name = "nameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_39.ReadOnly = true;
            this.dataGridViewTextBoxColumn_40.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_40.DataPropertyName = "TypeNameSocr";
            this.dataGridViewTextBoxColumn_40.FillWeight = 20f;
            this.dataGridViewTextBoxColumn_40.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn_40.Name = "typeNameSocrDgvColumn";
            this.dataGridViewTextBoxColumn_40.ReadOnly = true;
            this.dataGridViewTextBoxColumn_41.DataPropertyName = "TypeAbn";
            this.dataGridViewTextBoxColumn_41.HeaderText = "TypeAbn";
            this.dataGridViewTextBoxColumn_41.Name = "typeAbnDgvColumn";
            this.dataGridViewTextBoxColumn_41.ReadOnly = true;
            this.dataGridViewTextBoxColumn_41.Visible = false;
            this.dataGridViewCheckBoxColumn_1.DataPropertyName = "Deleted";
            this.dataGridViewCheckBoxColumn_1.HeaderText = "Deleted";
            this.dataGridViewCheckBoxColumn_1.Name = "deletedKontragentDgvColumn";
            this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_1.Visible = false;
            this.dataGridViewCheckBoxColumn_2.DataPropertyName = "isActive";
            this.dataGridViewCheckBoxColumn_2.HeaderText = "isActive";
            this.dataGridViewCheckBoxColumn_2.Name = "isActiveDgvColumn";
            this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_2.Visible = false;
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_1;
            base.ClientSize = new Size(0x2d7, 0x242);
            base.Controls.Add(this.checkBox_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.tabControl_0);
            base.Controls.Add(this.groupBox_1);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.groupBox_0);
            base.Name = "FormTechConnectionAddAbn";
            this.Text = "Выбор/создание контрагента";
            base.Load += new EventHandler(this.FormTechConnectionAddAbn_Load);
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.dataSetTechConnection_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.dataGridViewExcelFilter_1.EndInit();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.Panel2.PerformLayout();
            this.splitContainer_0.ResumeLayout(false);
            this.toolStrip_4.ResumeLayout(false);
            this.toolStrip_4.PerformLayout();
            this.toolStrip_5.ResumeLayout(false);
            this.toolStrip_5.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.dataSet_1.EndInit();
            this.dataTable_1.EndInit();
            this.dataSet_2.EndInit();
            this.dataTable_2.EndInit();
            this.dataSet_3.EndInit();
            this.dataTable_3.EndInit();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.tabControl_1.ResumeLayout(false);
            this.tabPage_2.ResumeLayout(false);
            this.tabPage_2.PerformLayout();
            this.tabPage_3.ResumeLayout(false);
            this.tabPage_3.PerformLayout();
            this.tabPage_4.ResumeLayout(false);
            this.tabPage_4.PerformLayout();
            this.tabPage_5.ResumeLayout(false);
            this.tabPage_5.PerformLayout();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.tabPage_6.ResumeLayout(false);
            this.tabPage_6.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_3.ResumeLayout(false);
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.tabPage_7.ResumeLayout(false);
            this.tabPage_7.PerformLayout();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            this.toolStrip_3.ResumeLayout(false);
            this.toolStrip_3.PerformLayout();
            this.tabPage_8.ResumeLayout(false);
            this.tabPage_8.PerformLayout();
            this.dataGridViewExcelFilter_2.EndInit();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            this.toolStrip_6.ResumeLayout(false);
            this.toolStrip_6.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void radioButton_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_0.Checked)
            {
                this.dataGridViewTextBoxColumn_16.Visible = false;
                this.dataGridViewTextBoxColumn_15.Visible = true;
                this.dataGridViewTextBoxColumn_14.Visible = true;
                if (!this.tabControl_0.TabPages.Contains(this.tabPage_1))
                {
                    this.tabControl_0.TabPages.Insert(1, this.tabPage_1);
                }
                if (!string.IsNullOrEmpty(this.textBox_0.Text))
                {
                    this.bindingSource_0.Filter = "Name like '%" + this.textBox_0.Text + "%'";
                }
                else
                {
                    this.bindingSource_0.Filter = "";
                }
            }
            else
            {
                this.dataGridViewTextBoxColumn_16.Visible = true;
                this.dataGridViewTextBoxColumn_15.Visible = false;
                this.dataGridViewTextBoxColumn_14.Visible = false;
                if (this.tabControl_0.TabPages.Contains(this.tabPage_1))
                {
                    this.tabControl_0.TabPages.Remove(this.tabPage_1);
                }
                this.bindingSource_0.Filter = "";
            }
            this.method_1();
        }

        private void radioButton_2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_0.Enabled = this.radioButton_2.Checked;
            this.comboBox_0.Enabled = !this.radioButton_2.Checked;
            this.comboBox_3.Enabled = !this.radioButton_2.Checked;
            this.comboBox_2.Enabled = !this.radioButton_2.Checked;
            this.comboBox_1.Enabled = !this.radioButton_2.Checked;
            this.textBox_3.Enabled = !this.radioButton_2.Checked;
            this.textBox_2.Enabled = !this.radioButton_2.Checked;
            this.textBox_1.Enabled = !this.radioButton_2.Checked;
            this.method_1();
        }

        private void textBox_0_TextChanged(object sender, EventArgs e)
        {
            if (this.radioButton_0.Checked)
            {
                if (!string.IsNullOrEmpty(this.textBox_0.Text))
                {
                    this.bindingSource_0.Filter = "Name like '%" + this.textBox_0.Text + "%'";
                }
                else
                {
                    this.bindingSource_0.Filter = "";
                }
            }
            else
            {
                this.timer_0.Stop();
                this.timer_0.Start();
            }
        }

        private void textBox_1_TextChanged(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void textBox_2_TextChanged(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void textBox_3_TextChanged(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.method_1();
            this.timer_0.Stop();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            if (!this.method_2())
            {
                MessageBox.Show("Редактирование данного контрагента невозможно");
            }
            else
            {
                ShowFormEventArgs args = new ShowFormEventArgs();
                args.set_TypeForm("Legal.Forms.FormAbnDetails, Legal");
                args.set_FormMode(0);
                args.set_Param(new object[2]);
                args.get_Param()[0] = this.int_0;
                args.get_Param()[1] = true;
                args.set_SQLSettings(this.get_SqlSettings());
                this.OnShowForm(args);
                if (args.get_DialogResult() == DialogResult.OK)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vG_AbnInfo, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                }
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (!this.method_2())
            {
                MessageBox.Show("Редактирование данного контрагента невозможно");
            }
            else
            {
                ShowFormEventArgs args = new ShowFormEventArgs();
                args.set_TypeForm("Legal.Forms.FormAbnDetails, Legal");
                args.set_FormMode(0);
                args.set_Param(new object[2]);
                args.get_Param()[0] = this.int_0;
                args.get_Param()[1] = false;
                args.set_SQLSettings(this.get_SqlSettings());
                this.OnShowForm(args);
                if (args.get_DialogResult() == DialogResult.OK)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vG_AbnInfo, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                }
            }
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            FormAddEditContracor contracor = new FormAddEditContracor(-1, this.radioButton_1.Checked ? ((AbnType) 0x40d) : ((AbnType) 0x40e), string.IsNullOrEmpty(this.textBox_0.Text) ? "NoName" : this.textBox_0.Text);
            contracor.set_SqlSettings(this.get_SqlSettings());
            if (contracor.ShowDialog() == DialogResult.OK)
            {
                if (contracor.get_TypeAbn() == 0x40e)
                {
                    this.radioButton_0.Checked = true;
                }
                else
                {
                    this.radioButton_1.Checked = true;
                }
                this.textBox_0.Text = contracor.get_NameAbn();
                this.method_1();
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_38.Name, contracor.get_Id().ToString(), false);
            }
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                if (!this.method_2())
                {
                    MessageBox.Show("Редактирование данного контрагента невозможно");
                }
                else
                {
                    FormAddEditContracor contracor = new FormAddEditContracor(this.int_0, this.radioButton_1.Checked ? ((AbnType) 0x40d) : ((AbnType) 0x40e), string.IsNullOrEmpty(this.textBox_0.Text) ? "NoName" : this.textBox_0.Text);
                    contracor.set_SqlSettings(this.get_SqlSettings());
                    if (contracor.ShowDialog() == DialogResult.OK)
                    {
                        if (contracor.get_TypeAbn() == 0x40e)
                        {
                            this.radioButton_0.Checked = true;
                        }
                        else
                        {
                            this.radioButton_1.Checked = true;
                        }
                        this.textBox_0.Text = contracor.get_NameAbn();
                        this.method_1();
                        this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_38.Name, this.int_0.ToString(), false);
                    }
                }
            }
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                if (!this.method_2())
                {
                    MessageBox.Show("Удаление данного контрагента невозможно");
                }
                else if (MessageBox.Show(Convert.ToBoolean(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewCheckBoxColumn_1.Name].Value) ? "Вы действительно хотите восстановить текущего контрагента" : "Вы действительно хотите удалить текущего контрагента?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int num = -1;
                    if (this.dataGridViewExcelFilter_0.CurrentRow.Index > 0)
                    {
                        num = Convert.ToInt32(this.dataGridViewExcelFilter_0.Rows[this.dataGridViewExcelFilter_0.CurrentRow.Index - 1].Cells[this.dataGridViewTextBoxColumn_38.Name].Value);
                    }
                    DataSetTechConnection connection = new DataSetTechConnection();
                    base.SelectSqlData(connection, connection.tAbn, true, "where id = " + this.int_0);
                    connection.tAbn.Rows[0]["Deleted"] = !Convert.ToBoolean(connection.tAbn.Rows[0]["Deleted"]);
                    connection.tAbn.Rows[0].EndEdit();
                    if (base.UpdateSqlData(connection, connection.tAbn))
                    {
                        if (Convert.ToBoolean(connection.tAbn.Rows[0]["Deleted"]))
                        {
                            MessageBox.Show("Абонент успешно удален");
                        }
                        else
                        {
                            MessageBox.Show("Абонент успешно восстановлен");
                        }
                    }
                    this.method_1();
                    if (Convert.ToBoolean(connection.tAbn.Rows[0]["Deleted"]) && !this.toolStripButton_16.Checked)
                    {
                        this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_38.Name, num.ToString(), false);
                    }
                }
            }
        }

        private void toolStripButton_13_Click(object sender, EventArgs e)
        {
            KontragentObjType type = (((this.int_2 == 0xce) || (this.int_2 == 0xfd)) || (this.int_2 == 0x40d)) ? ((KontragentObjType) 0x47c) : ((KontragentObjType) 0x47d);
            FormAddEditObj obj1 = new FormAddEditObj(this.int_0, -1, 0, -1, 0, this.int_2, type);
            obj1.set_SqlSettings(this.get_SqlSettings());
            if (obj1.ShowDialog() == DialogResult.OK)
            {
                base.SelectSqlData(this.vAbnObjAddressDataTable_0, true, "where idAbn = " + this.int_0.ToString(), false);
            }
        }

        private void toolStripButton_14_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_10.Name].Value);
                int num2 = (this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_11.Name].Value == DBNull.Value) ? 0 : Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_11.Name].Value);
                KontragentObjType type = (((this.int_2 == 0xce) || (this.int_2 == 0xfd)) || (this.int_2 == 0x40d)) ? ((KontragentObjType) 0x47c) : ((KontragentObjType) 0x47d);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tAbnObj, true, "where id = " + num.ToString());
                if ((this.dataSetTechConnection_0.tAbnObj.Rows.Count > 0) && ((this.dataSetTechConnection_0.tAbnObj.Rows[0]["typeObj"] == DBNull.Value) || ((Convert.ToInt32(this.dataSetTechConnection_0.tAbnObj.Rows[0]["typeObj"]) != 0x47c) && (Convert.ToInt32(this.dataSetTechConnection_0.tAbnObj.Rows[0]["typeObj"]) != 0x47d))))
                {
                    MessageBox.Show("Редактирование данного объекта невозможно");
                }
                else
                {
                    FormAddEditObj obj1 = new FormAddEditObj(this.int_0, num, 1, num2, 1, this.int_2, type);
                    obj1.set_SqlSettings(this.get_SqlSettings());
                    if (obj1.ShowDialog() == DialogResult.OK)
                    {
                        base.SelectSqlData(this.vAbnObjAddressDataTable_0, true, "where idAbn = " + this.int_0.ToString(), false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нечего редактировать.");
            }
        }

        private void toolStripButton_15_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_1.CurrentRow != null) && (MessageBox.Show("Удалить текущий объект?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)) && (MessageBox.Show("Уверены? ВСЕ ТЕКУЩИЕ ДАННЫЕ БУДУТ ПОТЕРЯНЫ!!!", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                MessageBox.Show("Функция отключена. Обратитесь в ОА.");
            }
        }

        private void toolStripButton_16_Click(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void toolStripButton_17_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                FormaddEditAbnType type1 = new FormaddEditAbnType(-1, this.int_0);
                type1.set_SqlSettings(this.get_SqlSettings());
                if (type1.ShowDialog() == DialogResult.OK)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbnType, true, " where idAbn = " + this.int_0.ToString());
                }
            }
        }

        private void toolStripButton_18_Click(object sender, EventArgs e)
        {
            if ((this.int_0 != -1) && (this.dataGridViewExcelFilter_2.CurrentRow != null))
            {
                FormaddEditAbnType type1 = new FormaddEditAbnType(Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_34.Name].Value), this.int_0);
                type1.set_SqlSettings(this.get_SqlSettings());
                if (type1.ShowDialog() == DialogResult.OK)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbnType, true, " where idAbn = " + this.int_0.ToString());
                }
            }
        }

        private void toolStripButton_19_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_2.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                base.DeleteSqlDataById(this.dataSetTechConnection_0.tAbnType, Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_34.Name].Value));
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vAbnType, true, " where idAbn = " + this.int_0.ToString());
                MessageBox.Show("Запись успешно удалена");
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            ShowFormEventArgs args = new ShowFormEventArgs();
            args.set_TypeForm("Legal.Forms.FormAbnDetailsHistory, Legal");
            if (base.MdiParent == null)
            {
                args.set_FormMode(0);
            }
            else
            {
                args.set_FormMode(1);
            }
            args.set_Param(new object[1]);
            args.get_Param()[0] = this.int_0;
            args.set_SQLSettings(this.get_SqlSettings());
            this.OnShowForm(args);
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (!this.method_2())
            {
                MessageBox.Show("Редактирование данного контрагента невозможно");
            }
            else
            {
                ShowFormEventArgs args = new ShowFormEventArgs();
                args.set_TypeForm("Legal.Forms.FormAbnChief, Legal");
                args.set_FormMode(0);
                args.set_Param(new object[2]);
                args.get_Param()[0] = this.int_0;
                args.get_Param()[1] = true;
                args.set_SQLSettings(this.get_SqlSettings());
                this.OnShowForm(args);
                if (args.get_DialogResult() == DialogResult.OK)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tG_AbnChief, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                }
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            if (!this.method_2())
            {
                MessageBox.Show("Редактирование данного контрагента невозможно");
            }
            else
            {
                ShowFormEventArgs args = new ShowFormEventArgs();
                args.set_TypeForm("Legal.Forms.FormAbnChief, Legal");
                args.set_FormMode(0);
                args.set_Param(new object[2]);
                args.get_Param()[0] = this.int_0;
                args.get_Param()[1] = false;
                args.set_SQLSettings(this.get_SqlSettings());
                this.OnShowForm(args);
                if (args.get_DialogResult() == DialogResult.OK)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tG_AbnChief, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                }
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            ShowFormEventArgs args = new ShowFormEventArgs();
            args.set_TypeForm("Legal.Forms.FormAbnChiefHistory, Legal");
            args.set_FormMode((base.MdiParent == null) ? ((eFormMode) 0) : ((eFormMode) 1));
            args.set_Param(new object[1]);
            args.get_Param()[0] = this.int_0;
            args.set_SQLSettings(this.get_SqlSettings());
            this.OnShowForm(args);
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if (!this.method_2())
            {
                MessageBox.Show("Редактирование данного контрагента невозможно");
            }
            else
            {
                ShowFormEventArgs args = new ShowFormEventArgs();
                args.set_TypeForm("Legal.Forms.FormAbnAddressHistory, Legal");
                args.set_FormMode(0);
                args.set_Param(new object[1]);
                args.get_Param()[0] = this.int_0;
                args.set_SQLSettings(this.get_SqlSettings());
                this.OnShowForm(args);
                if (args.get_DialogResult() == DialogResult.OK)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vG_AbnAddressL, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vG_AbnAddressP, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc", 1);
                }
            }
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            ShowFormEventArgs args = new ShowFormEventArgs();
            args.set_TypeForm("Legal.Forms.FormAbnContactAdd, Legal");
            args.set_FormMode(0);
            args.set_Param(new object[2]);
            args.get_Param()[0] = this.int_0;
            args.get_Param()[1] = true;
            args.set_SQLSettings(this.get_SqlSettings());
            this.OnShowForm(args);
            if (args.get_DialogResult() == DialogResult.OK)
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tAbnContact, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc");
            }
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            ShowFormEventArgs args = new ShowFormEventArgs();
            args.set_TypeForm("Legal.Forms.FormAbnContactAdd, Legal");
            args.set_FormMode(0);
            args.set_Param(new object[2]);
            args.get_Param()[0] = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDGVTBC"].Value);
            args.get_Param()[1] = false;
            args.set_SQLSettings(this.get_SqlSettings());
            this.OnShowForm(args);
            if (args.get_DialogResult() == DialogResult.OK)
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tAbnContact, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc");
            }
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите удалить контакт?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                base.DeleteSqlDataById(this.dataSetTechConnection_0.tAbnContact, Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDGVTBC"].Value));
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tAbnContact, true, " where idAbn = " + this.int_0.ToString() + " order by DateChange desc");
            }
        }

        internal string AbnName
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }

        internal string AbnObjName
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            private set
            {
                this.string_1 = value;
            }
        }

        internal int IdAbn
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

        internal int IdAbnObj
        {
            get
            {
                return this.int_1;
            }
            set
            {
                this.int_1 = value;
            }
        }
    }
}

