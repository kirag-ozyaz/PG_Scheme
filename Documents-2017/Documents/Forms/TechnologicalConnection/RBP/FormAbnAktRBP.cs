namespace Documents.Forms.TechnologicalConnection.RBP
{
    using Constants;
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
    using ControlsLbr.WPF;
    using DataSql;
    using Documents.DataSets;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Forms.TechnologicalConnection.TU;
    using FormLbr;
    using FormLbr.Classes;
    using OfficeLB.Word;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Forms.Integration;

    public class FormAbnAktRBP : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_4;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBoxReadOnly comboBoxReadOnly_0;
        private ContextMenuStrip contextMenuStrip_0;
        private ContextMenuStrip contextMenuStrip_1;
        private DataGridView dataGridView_0;
        private DataGridView dataGridView_1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewImageColumn dataGridViewImageColumn_0;
        private DataGridViewImageColumn dataGridViewImageColumn_1;
        private DataGridViewImageColumn dataGridViewImageColumn_2;
        private DataGridViewImageColumn dataGridViewImageColumn_3;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_1;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataRow dataRow_0;
        private DataRow dataRow_1;
        private DataSetGES dataSetGES_0;
        private DataSetGES dataSetGES_1;
        private DataSetTechConnection dataSetTechConnection_0;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private Dictionary<string, FileWatcherArgsAddl> dictionary_0;
        private ElementHost elementHost_0;
        private ElementHost elementHost_1;
        private ElementHost elementHost_2;
        private ElementHost elementHost_3;
        private ElementHost elementHost_4;
        private ElementHost elementHost_5;
        private ElementHost elementHost_6;
        private ElementHost elementHost_7;
        private ElementHost elementHost_8;
        private Enum2 enum2_0;
        private IContainer icontainer_0;
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label label_16;
        private Label label_17;
        private Label label_18;
        private Label label_19;
        private Label label_2;
        private Label label_20;
        private Label label_21;
        private Label label_22;
        private Label label_23;
        private Label label_24;
        private Label label_25;
        private Label label_26;
        private Label label_27;
        private Label label_28;
        private Label label_29;
        private Label label_3;
        private Label label_30;
        private Label label_31;
        private Label label_32;
        private Label label_33;
        private Label label_34;
        private Label label_35;
        private Label label_36;
        private Label label_37;
        private Label label_38;
        private Label label_39;
        private Label label_4;
        private Label label_40;
        private Label label_41;
        private Label label_42;
        private Label label_43;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private int? nullable_0;
        private Panel panel_0;
        private Panel panel_1;
        private PictureBox pictureBox_0;
        private Process process_0;
        private string string_0;
        private TabControl tabControl_0;
        private TableLayoutPanel tableLayoutPanel_0;
        private TableLayoutPanel tableLayoutPanel_1;
        private TableLayoutPanel tableLayoutPanel_2;
        private TableLayoutPanel tableLayoutPanel_3;
        private TableLayoutPanel tableLayoutPanel_4;
        private TableLayoutPanel tableLayoutPanel_5;
        private TableLayoutPanel tableLayoutPanel_6;
        private TableLayoutPanel tableLayoutPanel_7;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TabPage tabPage_3;
        private TabPage tabPage_4;
        private TabPage tabPage_5;
        private TabPage tabPage_6;
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
        private TextBox textBox_3;
        private TextBox textBox_4;
        private TextBox textBox_5;
        private TextBox textBox_6;
        private TextBox textBox_7;
        private TextBox textBox_8;
        private TextBox textBox_9;
        private TextBoxDropDown textBoxDropDown_0;
        private TextBoxDropDown textBoxDropDown_1;
        private TextBoxDropDown textBoxDropDown_2;
        private TextBoxDropDown textBoxDropDown_3;
        private TextBoxDropDown textBoxDropDown_4;
        private TextBoxDropDown textBoxDropDown_5;
        private TextBoxDropDown textBoxDropDown_6;
        private TextBoxDropDown textBoxDropDown_7;
        private TextBoxDropDown textBoxDropDown_8;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_10;
        private ToolStripButton toolStripButton_11;
        private ToolStripButton toolStripButton_12;
        private ToolStripButton toolStripButton_13;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripDropDownButton toolStripDropDownButton_0;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripMenuItem toolStripMenuItem_5;
        private ToolStripMenuItem toolStripMenuItem_6;
        private ToolStripMenuItem toolStripMenuItem_7;
        private ToolStripMenuItem toolStripMenuItem_8;
        private ToolStripMenuItem toolStripMenuItem_9;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripSeparator toolStripSeparator_4;
        private Constants.TypeDocValue typeDocValue_0;

        public FormAbnAktRBP()
        {
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.process_0 = new Process();
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.textBoxDropDown_0 = Activator.CreateInstance<TextBoxDropDown>();
            this.method_36();
            this.method_0();
        }

        public FormAbnAktRBP(SQLSettings settings, int idAbnObj, int idList)
        {
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.process_0 = new Process();
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_36();
            this.method_0();
            this.set_SqlSettings(settings);
            this.IdAbn = this.method_17(idAbnObj);
            this.IdAbnObj = idAbnObj;
            this.IdList = idList;
            this.IdActTehConnection = -1;
            this.TypeDocValue = this.method_3(idList);
            this.enum2_0 = Enum2.const_2;
            this.method_8();
            this.method_9();
            this.method_4(idList);
            this.method_6();
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_Image, true, "where idList=" + idList + " order by id");
            if (this.dataSetGES_0.tAbnObjDoc_Image.Count > 0)
            {
                for (int i = 0; i < this.dataSetGES_0.tAbnObjDoc_Image.Count; i++)
                {
                    if (this.dataSetGES_0.tAbnObjDoc_Image.Rows[i]["Scan"] != DBNull.Value)
                    {
                        this.method_10((byte[]) this.dataSetGES_0.tAbnObjDoc_Image.Rows[i]["Scan"], (int) this.dataSetGES_0.tAbnObjDoc_Image.Rows[i]["id"]);
                    }
                }
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    this.pictureBox_0.Image = (Bitmap) this.dataGridViewExcelFilter_0.CurrentRow.Cells["ImageOriginal"].Value;
                }
                this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            this.Text = "Редактирование акта разграничения " + ((this.TypeDocValue == 1) ? "балансовой принадлежности" : "эксплуатационной ответственности");
        }

        public FormAbnAktRBP(SQLSettings settings, bool bool_3, int idAbn, Constants.TypeDocValue value)
        {
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.process_0 = new Process();
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_36();
            this.method_0();
            this.set_SqlSettings(settings);
            this.IdAbn = idAbn;
            this.TypeDocValue = value;
            this.IdActTehConnection = -1;
            this.IdList = -1;
            this.enum2_0 = Enum2.const_0;
            this.method_8();
            this.method_9();
            this.method_6();
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnDoc_Dogovor, true, " where idAbn = " + idAbn.ToString() + " and FlagBreak = 0");
            if ((this.dataSetGES_0.tAbnDoc_Dogovor.Count > 0) && (this.dataSetGES_0.tAbnDoc_Dogovor.Rows[0]["BasisOF"] != DBNull.Value))
            {
                this.textBox_5.Text = this.dataSetGES_0.tAbnDoc_Dogovor.First<DataSetGES.Class130>().BasisOF;
            }
            else
            {
                this.textBox_5.Text = "устава";
            }
            this.textBox_1.Text = "до границы раздела " + ((this.TypeDocValue == 1) ? "балансовой принадлежности" : "эксплуатационной ответственности") + " со стороны потребителя";
            string str = "";
            string str2 = "";
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tG_AbnChief, true, " where idAbn = " + idAbn.ToString());
            if (this.dataSetGES_0.tG_AbnChief.Rows.Count > 0)
            {
                str = this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_F;
                if ((str.Length > 0) && (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_I.Length > 0))
                {
                    str = str + " " + this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_I.Substring(0, 1) + ".";
                }
                if ((str.Length > 0) && (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_O.Length > 0))
                {
                    str = str + " " + this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_O.Substring(0, 1) + ".";
                }
                str2 = ((this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>()["R_Post"] != DBNull.Value) ? this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_Post : "") + " " + str;
            }
            this.textBox_6.Text = str2;
            this.textBox_0.Text = str;
        }

        public FormAbnAktRBP(SQLSettings settings, int idActTeh, int idTU, Constants.TypeDocValue value)
        {
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.process_0 = new Process();
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_36();
            this.method_0();
            this.set_SqlSettings(settings);
            this.IdActTehConnection = idActTeh;
            this.IdTU = idTU;
            this.method_26();
            string selectCommandText = "select id, idAbn, idAbnObj from vtc_tu where id = " + idTU.ToString();
            DataTable dataTable = new DataTable();
            SqlDataConnect connect = new SqlDataConnect();
            if (connect.OpenConnection(this.get_SqlSettings()))
            {
                try
                {
                    new SqlDataAdapter(selectCommandText, connect.get_Connection()).Fill(dataTable);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
            if (dataTable.Rows.Count > 0)
            {
                this.IdAbn = (dataTable.Rows[0]["idAbn"] != DBNull.Value) ? ((int) dataTable.Rows[0]["idAbn"]) : -1;
                this.IdAbnObj = (dataTable.Rows[0]["idAbnObj"] != DBNull.Value) ? ((int) dataTable.Rows[0]["idAbnObj"]) : -1;
            }
            else
            {
                this.IdAbn = -1;
                this.IdAbnObj = -1;
            }
            this.method_2(value);
        }

        public FormAbnAktRBP(SQLSettings settings, int idAbnObj, int idList, bool bool_3)
        {
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.process_0 = new Process();
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_36();
            this.method_0();
            this.set_SqlSettings(settings);
            this.IdAbnObj = idAbnObj;
            this.IdList = idList;
            this.IdActTehConnection = -1;
            this.TypeDocValue = this.method_3(idList);
            this.enum2_0 = Enum2.const_3;
            this.method_8();
            this.method_9();
            this.method_4(idList);
            this.method_1(false);
            this.method_6();
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_Image, true, "where idList=" + idList + " order by id");
            if (this.dataSetGES_0.tAbnObjDoc_Image.Count > 0)
            {
                for (int i = 0; i < this.dataSetGES_0.tAbnObjDoc_Image.Count; i++)
                {
                    this.method_10((byte[]) this.dataSetGES_0.tAbnObjDoc_Image.Rows[i]["Scan"], (int) this.dataSetGES_0.tAbnObjDoc_Image.Rows[i]["id"]);
                }
                this.pictureBox_0.Image = (Bitmap) this.dataGridViewExcelFilter_0.CurrentRow.Cells["ImageOriginal"].Value;
                this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            this.button_3.Enabled = false;
            this.Text = "Просмотр акта разграничения " + ((this.TypeDocValue == 1) ? "балансовой принадлежности" : "эксплуатационной ответственности");
        }

        public FormAbnAktRBP(SQLSettings settings, int idAbnObj, int idList, int idAbn)
        {
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.process_0 = new Process();
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_36();
            this.method_0();
            this.set_SqlSettings(settings);
            this.IdAbnObj = idAbnObj;
            this.IdList = idList;
            this.IdAbn = idAbn;
            this.IdActTehConnection = -1;
            this.enum2_0 = Enum2.const_1;
            this.TypeDocValue = this.method_3(idList);
            this.method_8();
            this.method_9();
            this.method_6();
            this.method_4(idList);
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnDoc_Dogovor, true, " where idAbn = " + idAbn.ToString() + " and FlagBreak = 0");
            if ((this.dataSetGES_0.tAbnDoc_Dogovor.Count > 0) && (this.dataSetGES_0.tAbnDoc_Dogovor.Rows[0]["BasisOF"] != DBNull.Value))
            {
                this.textBox_5.Text = this.dataSetGES_0.tAbnDoc_Dogovor.First<DataSetGES.Class130>().BasisOF;
            }
            else
            {
                this.textBox_5.Text = "устава";
            }
            this.textBox_1.Text = "до границы раздела " + ((this.TypeDocValue == 1) ? "балансовой принадлежности" : "эксплуатационной ответственности") + " со стороны потребителя";
            string str = "";
            string str2 = "";
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tG_AbnChief, true, " where idAbn = " + idAbn.ToString());
            if (this.dataSetGES_0.tG_AbnChief.Rows.Count > 0)
            {
                str = this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_F;
                if ((str.Length > 0) && (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_I.Length > 0))
                {
                    str = str + " " + this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_I.Substring(0, 1) + ".";
                }
                if ((str.Length > 0) && (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_O.Length > 0))
                {
                    str = str + " " + this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_O.Substring(0, 1) + ".";
                }
                str2 = ((this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>()["R_Post"] != DBNull.Value) ? this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_Post : "") + " " + str;
            }
            this.textBox_6.Text = str2;
            this.textBox_0.Text = str;
            this.method_13(this.TypeDocValue);
            this.IdList = -1;
            this.Text = "Копирование акта разграничения" + ((this.TypeDocValue == 1) ? "балансовой принадлежности" : "эксплуатационной ответственности");
        }

        public FormAbnAktRBP(SQLSettings settings, bool bool_3, bool inf1, int idAbn, int idAbnObj, Constants.TypeDocValue value)
        {
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.process_0 = new Process();
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_36();
            this.method_0();
            this.set_SqlSettings(settings);
            this.IdAbnObj = idAbnObj;
            this.IdAbn = idAbn;
            this.IdActTehConnection = -1;
            this.method_2(value);
        }

        private void bindingSource_2_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_2.Current != null)
            {
                this.IdActTehConnection = (int) ((DataRowView) this.bindingSource_2.Current)["id"];
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tTC_ActTC, true, string.Format("WHERE id = {0} ", this.IdActTehConnection));
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vTC_TUPointAttach, true, string.Format("WHERE idTU = {0} and (typeDoc is null or typeDoc = {1})", this.IdActTehConnection, 0x4d8));
            }
            else
            {
                this.IdActTehConnection = -1;
                this.dataSetGES_0.tTC_ActTC.Rows.Clear();
                this.dataSetGES_0.vTC_TUPointAttach.Rows.Clear();
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            this.textBox_3.Text = this.textBoxDropDown_1.get_Text();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            this.textBox_4.Text = this.textBoxDropDown_8.get_Text();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            try
            {
                this.bool_2 = this.method_33();
                if (this.bool_2)
                {
                    base.DialogResult = DialogResult.OK;
                    base.Close();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            FormTechConnectionAddAbn abn1 = new FormTechConnectionAddAbn(this.int_3, this.int_4, true);
            abn1.add_ShowForm(new ShowFormEventHandler(this, this.method_35));
            abn1.set_SqlSettings(this.get_SqlSettings());
            abn1.MdiParent = base.MdiParent;
            abn1.FormClosed += new FormClosedEventHandler(this.method_34);
            abn1.Show();
        }

        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                FileStream stream1 = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                stream1.Write(byteArray, 0, byteArray.Length);
                stream1.Close();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
                exception.ToString();
            }
            return false;
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_0.SelectedValue is int) && (this.enum2_0 == Enum2.const_0))
            {
                this.method_13(this.TypeDocValue);
            }
        }

        private void comboBoxReadOnly_0_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.comboBoxReadOnly_0.SelectedValue != null) || (this.comboBoxReadOnly_0.SelectedValue != DBNull.Value))
            {
                this.IdAbnObj = Convert.ToInt32(this.comboBoxReadOnly_0.SelectedValue);
            }
        }

        public void CreateActRbp(string AbnName, string fullFileName)
        {
            string phone = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string representation = "";
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnDoc_List, true, string.Format(" where idAbn = {0} and idDocType = {1} and isActive <> 0 and Deleted = 0", this.IdAbn, 0x1f5), true);
            if (this.dataSetGES_0.tAbnDoc_List.Rows.Count > 0)
            {
                str6 = string.Format("Приложение №4 к договору № {0} от {1} г.", this.dataSetGES_0.tAbnDoc_List.First<DataSetGES.Class137>().DocNumber.Trim(), this.dataSetGES_0.tAbnDoc_List.First<DataSetGES.Class137>().DocDate.ToShortDateString());
            }
            base.SelectSqlData(this.dataSetGES_1, this.dataSetGES_1.tG_AbnAddress, true, string.Format(" where idAbn = {0} and idTypeAddress = {1} order by DateChange desc", this.IdAbn, 0x36), true);
            if (this.dataSetGES_1.tG_AbnAddress.Count > 0)
            {
                representation = this.dataSetGES_1.tG_AbnAddress.First<DataSetGES.Class138>().Representation;
            }
            base.SelectSqlData(this.dataSetGES_1, this.dataSetGES_1.tAbnContact, true, " where idAbn = " + this.IdAbn + " and Post LIKE 'ОДС'", true);
            if (this.dataSetGES_1.tAbnContact.Count > 0)
            {
                phone = this.dataSetGES_1.tAbnContact.First<DataSetGES.Class136>().Phone;
            }
            if (this.IdActTehConnection != -1)
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tTC_Doc, true, string.Format("WHERE id = {0}", this.IdActTehConnection));
                if (this.dataSetGES_0.tTC_Doc.Rows.Count > 0)
                {
                    str2 = (this.dataSetGES_0.tTC_Doc.First<DataSetGES.Class144>()["dateDoc"] == DBNull.Value) ? "" : this.dataSetGES_0.tTC_Doc.First<DataSetGES.Class144>().dateDoc.ToShortDateString();
                    str3 = (this.dataSetGES_0.tTC_Doc.First<DataSetGES.Class144>()["numDoc"] == DBNull.Value) ? "" : this.dataSetGES_0.tTC_Doc.First<DataSetGES.Class144>().numDoc.ToString();
                }
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tTC_ActTC, true, string.Format("WHERE id = {0}", this.IdActTehConnection));
                if (this.dataSetGES_0.tTC_ActTC.Rows.Count > 0)
                {
                    str4 = (this.dataSetGES_0.tTC_ActTC.First<DataSetGES.Class141>()["PowerSum"] == DBNull.Value) ? "" : this.dataSetGES_0.tTC_ActTC.First<DataSetGES.Class141>().PowerSum.ToString();
                    str5 = "";
                }
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vTC_TUPointAttach, true, string.Format("WHERE idTU = {0} and (typeDoc is null or typeDoc = {1})", this.IdActTehConnection, 0x4d8));
            }
            Application application = null;
            Selection selection = null;
            try
            {
                application = new Application();
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутствует предустановленный MS Office Word", "Ошибка MS Office", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (application != null)
            {
                try
                {
                    application.get_Documents().Open(fullFileName);
                    selection = application.get_Selection();
                    if (str6.Length > 0)
                    {
                        selection.FindAndReplace("[Привязка_кдоговору]", str6, true);
                    }
                    else
                    {
                        selection.FindAndReplace("[Привязка_кдоговору]", "", true);
                    }
                    selection.FindAndReplace("[Абонент_наименование]", AbnName + " " + representation, true);
                    selection.FindAndReplace("[Телефон]", "32-32-34", true);
                    selection.FindAndReplace("[Телефон2]", phone, true);
                    string str8 = "";
                    string str9 = "";
                    DataTable table = base.SelectSqlData("tR_Classifier", true, "WHERE id = " + this.comboBox_0.SelectedValue.ToString());
                    str8 = (table.Rows.Count > 0) ? Math.Round((decimal) table.Rows[0]["Value"], 0).ToString() : "";
                    selection.FindAndReplace("[Номер_района]", str8, true);
                    string str10 = "";
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vP_Worker, true, string.Format(" where ParentKey = ';GroupWorker;HeadRegionApart;' AND Value = {0}", (table.Rows.Count > 0) ? table.Rows[0]["Value"].ToString().Replace(',', '.') : "-1"), true);
                    if (this.dataSetGES_0.vP_Worker.Rows.Count > 0)
                    {
                        str10 = this.dataSetGES_0.vP_Worker.Rows[0]["FIO"].ToString().Trim();
                    }
                    selection.FindAndReplace("[Начальник_района]", str10, true);
                    selection.FindAndReplace("[Дата_Акта]", this.dateTimePicker_0.Value.ToShortDateString(), true);
                    string[] textArray1 = new string[] { str8, "/", this.textBox_7.Text, "/", this.dateTimePicker_0.Value.Year.ToString().Substring(2, 2) };
                    str9 = string.Concat(textArray1);
                    selection.FindAndReplace("[Номер_Акта]", str9, true);
                    selection.FindAndReplace("[Потребитель_влице]", this.textBox_6.Text, true);
                    selection.FindAndReplace("[Потребитель_Основание]", this.textBox_5.Text, true);
                    selection.get_Find().ClearFormatting();
                    selection.get_Find().set_Text("[Сетевая_оборудование]");
                    if (selection.get_Find().Execute())
                    {
                        selection.FindAndReplace("[Сетевая_оборудование]", this.textBoxDropDown_8.get_Text(), false);
                        selection.FindAndReplace("[Сетевая_оборудование]", "", true);
                    }
                    selection.get_Find().ClearFormatting();
                    selection.get_Find().set_Text("[Потребитель_оборудование]");
                    if (selection.get_Find().Execute())
                    {
                        selection.FindAndReplace("[Потребитель_оборудование]", this.textBoxDropDown_1.get_Text(), false);
                        selection.FindAndReplace("[Потребитель_оборудование]", "", true);
                    }
                    selection.get_Find().ClearFormatting();
                    selection.get_Find().set_Text("[Граница]");
                    if (selection.get_Find().Execute())
                    {
                        selection.FindAndReplace("[Граница]", this.textBoxDropDown_0.get_Text(), false);
                        selection.FindAndReplace("[Граница]", "", true);
                    }
                    selection.FindAndReplace("[Сетевая_эксплуатация]", this.textBox_4.Text, false);
                    selection.FindAndReplace("[Сетевая_эксплуатация]", "", true);
                    selection.FindAndReplace("[Потребитель_эксплуатация]", this.textBox_3.Text, false);
                    selection.FindAndReplace("[Потребитель_эксплуатация]", "", true);
                    selection.FindAndReplace("[Ответственность]", this.textBox_2.Text, false);
                    selection.FindAndReplace("[Ответственность]", "", true);
                    if (selection.FindAndReplace("[Ответственность2]", "[Ответственность2]", true))
                    {
                        selection.FindAndReplace("[Ответственность2]", this.textBox_2.Text, false);
                    }
                    selection.FindAndReplace("[Потребитель_допуск]", this.textBox_1.Text, false);
                    selection.FindAndReplace("[Потребитель_допуск]", "", true);
                    selection.FindAndReplace("[Потребитель_подпись]", this.textBox_0.Text, true);
                    selection.FindAndReplace("[Дата тех прис]", (str2.Length == 0) ? "                  " : str2, true);
                    selection.FindAndReplace("[Номер тех прис]", (str3.Length == 0) ? "                  " : str3, true);
                    selection.FindAndReplace("[Макс мощность]", (str4.Length == 0) ? "        " : str4, true);
                    selection.FindAndReplace("[Ном мощность]", (str5.Length == 0) ? "        " : str5, true);
                    selection.FindAndReplace("[Адрес границы]", "                                                                                                                                                                      ", true);
                    if (this.textBox_21.Text.Length > 0)
                    {
                        selection.FindAndReplace("[Прочее]", this.textBox_21.Text, false);
                    }
                    else
                    {
                        selection.FindAndReplace("[Прочее]", "                                                                                                                                                                   ", true);
                    }
                    if (((application.get_ActiveDocument().get_Tables().get_Count() == 3) && (application.get_ActiveDocument().get_Tables().get_Item(1).get_Columns().get_Count() == 7)) && ((application.get_ActiveDocument().get_Tables().get_Item(2).get_Columns().get_Count() == 2) && (application.get_ActiveDocument().get_Tables().get_Item(3).get_Columns().get_Count() == 1)))
                    {
                        Table table2 = application.get_ActiveDocument().get_Tables().get_Item(1);
                        for (int i = 0; i < this.dataSetGES_0.vTC_TUPointAttach.Count; i++)
                        {
                            Row row1 = table2.get_Rows().get_Item(i + 2);
                            row1.get_Cells().get_Item(1).get_Range();
                            row1.get_Cells().get_Item(1).get_Range().set_Text(this.dataSetGES_0.vTC_TUPointAttach.Rows[i]["AttachmentPoint"].ToString());
                            row1.get_Cells().get_Item(2).get_Range().set_Text(this.dataSetGES_0.vTC_TUPointAttach.Rows[i]["PowerSupply"].ToString());
                            row1.get_Cells().get_Item(3).get_Range().set_Text("");
                            row1.get_Cells().get_Item(4).get_Range().set_Text(this.dataSetGES_0.vTC_TUPointAttach.Rows[i]["voltagelevelname"].ToString());
                            row1.get_Cells().get_Item(5).get_Range().set_Text(this.dataSetGES_0.vTC_TUPointAttach.Rows[i]["powersum"].ToString());
                            row1.get_Cells().get_Item(6).get_Range().set_Text("");
                            row1.get_Cells().get_Item(7).get_Range().set_Text(this.dataSetGES_0.vTC_TUPointAttach.Rows[i]["Category"].ToString());
                            if (table2.get_Rows().get_Count() != (this.dataSetGES_0.vTC_TUPointAttach.Count + 1))
                            {
                                table2.get_Rows().Add();
                            }
                        }
                        Table table1 = application.get_ActiveDocument().get_Tables().get_Item(2);
                        table1.get_Rows().get_Item(2).get_Cells().get_Item(1).get_Range().set_Text(this.textBoxDropDown_8.get_Text());
                        table1.get_Rows().get_Item(2).get_Cells().get_Item(2).get_Range().set_Text(this.textBoxDropDown_1.get_Text());
                    }
                    selection.FindAndReplace("[Владелец_имя]", this.textBox_8.Text, true);
                    selection.FindAndReplace("[Владелец_влице]", this.textBox_10.Text, true);
                    selection.FindAndReplace("[Владелец_основание]", this.textBox_9.Text, true);
                    selection.FindAndReplace("[Владелец_оборудование]", this.textBoxDropDown_7.get_Text(), false);
                    selection.FindAndReplace("[Владелец_оборудование]", "", true);
                    selection.FindAndReplace("[Владелец_эксплуатация]", this.textBoxDropDown_6.get_Text(), false);
                    selection.FindAndReplace("[Владелец_эксплуатация]", "", true);
                    selection.FindAndReplace("[Граница2]", this.textBoxDropDown_5.get_Text(), false);
                    selection.FindAndReplace("[Граница2]", "", true);
                    selection.FindAndReplace("[Владелец_подпись]", this.textBox_11.Text, true);
                    selection.FindAndReplace("[Номер_ОТО]", this.textBox_14.Text, false);
                    selection.FindAndReplace("[Номер_ОТО]", "", true);
                    selection.FindAndReplace("[Договор_ОТО2]", this.textBox_13.Text, false);
                    selection.FindAndReplace("[Договор_ОТО2]", "", true);
                    selection.FindAndReplace("[Договор_OTO1]", this.textBox_12.Text, false);
                    selection.FindAndReplace("[Договор_OTO1]", "", true);
                    selection.FindAndReplace("[Владелец2_имя]", this.textBox_18.Text, true);
                    selection.FindAndReplace("[Владелец2_влице]", this.textBox_15.Text, true);
                    selection.FindAndReplace("[Владелец2_основание]", this.textBox_16.Text, true);
                    selection.FindAndReplace("[Владелец2_оборудование]", this.textBoxDropDown_4.get_Text(), false);
                    selection.FindAndReplace("[Владелец2_оборудование]", "", true);
                    selection.FindAndReplace("[Владелец2_эксплуатация]", this.textBoxDropDown_3.get_Text(), false);
                    selection.FindAndReplace("[Владелец2_эксплуатация]", "", true);
                    selection.FindAndReplace("[Граница3]", this.textBoxDropDown_2.get_Text(), false);
                    selection.FindAndReplace("[Граница3]", "", true);
                    selection.FindAndReplace("[Владелец2_подпись]", this.textBox_15.Text, true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось создать документ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                selection = null;
                try
                {
                    application.get_ActiveDocument().Save();
                    application.set_Visible(true);
                }
                catch (Exception)
                {
                    application.Quit();
                    MessageBox.Show("Не удалось сохранить документ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void dataGridView_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.toolStripButton_10.Visible && this.toolStripButton_10.Enabled))
            {
                this.toolStripButton_10_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (e.RowIndex >= 0))
            {
                this.pictureBox_0.Image = (Bitmap) this.dataGridViewExcelFilter_0.CurrentRow.Cells["ImageOriginal"].Value;
                this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if ((e.Button == MouseButtons.Right) && (e.RowIndex >= 0))
            {
                this.pictureBox_0.Image = (Bitmap) this.dataGridViewExcelFilter_0.CurrentRow.Cells["ImageOriginal"].Value;
                this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
                this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Selected = true;
                this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0[0, e.RowIndex];
                this.pictureBox_0.Image = (Bitmap) this.dataGridViewExcelFilter_0.CurrentRow.Cells["ImageOriginal"].Value;
                this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
                this.contextMenuStrip_0.Show(Cursor.Position);
            }
        }

        private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripMenuItem_6_Click(sender, e);
        }

        private void dataGridViewExcelFilter_1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            string key = this.dataGridViewExcelFilter_1[e.ColumnIndex, e.RowIndex].Value.ToString() + Path.GetExtension(this.string_0);
            if (key != this.string_0)
            {
                if (this.dictionary_0.ContainsKey(this.string_0))
                {
                    FileWatcherArgsAddl addl = this.dictionary_0[this.string_0];
                    addl.set_OriginalName(key);
                    this.dictionary_0.Remove(this.string_0);
                    this.dictionary_0.Add(key, addl);
                }
                this.dataGridViewExcelFilter_1[e.ColumnIndex, e.RowIndex].Value = key;
                this.bool_1 = true;
                this.string_0 = null;
            }
        }

        private void dataGridViewExcelFilter_1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (e.Button == MouseButtons.Right))
            {
                this.dataGridViewExcelFilter_1.ClearSelection();
                this.dataGridViewExcelFilter_1.Rows[e.RowIndex].Selected = true;
                this.dataGridViewExcelFilter_1.CurrentCell = this.dataGridViewExcelFilter_1[e.ColumnIndex, e.RowIndex];
                Rectangle rectangle = this.dataGridViewExcelFilter_1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                this.contextMenuStrip_1.Show((Control) sender, (int) (rectangle.Left + e.X), (int) (rectangle.Top + e.Y));
            }
        }

        private void dataGridViewExcelFilter_1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (((e.ColumnIndex == 1) && (e.RowIndex >= 0)) && !string.IsNullOrEmpty(this.string_0))
            {
                string key = e.FormattedValue + Path.GetExtension(this.string_0);
                if ((key != this.string_0) && this.dictionary_0.ContainsKey(key))
                {
                    MessageBox.Show("Файл с таким именем уже существует", "");
                    e.Cancel = true;
                }
            }
        }

        private void dataGridViewExcelFilter_1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((((DataGridView) sender).RowCount > 0) && (this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value != null))
            {
                if (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    if (!string.IsNullOrEmpty(Path.GetFileName(this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString())))
                    {
                        e.Value = Path.GetFileName(this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
                    }
                    else
                    {
                        e.Value = this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString();
                    }
                }
                if (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    Icon icon = FileInfo.IconOfFile(this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
                    if (icon != null)
                    {
                        e.Value = icon.ToBitmap();
                    }
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

        private void FormAbnAktRBP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((((this.enum2_0 != Enum2.const_3) && (base.DialogResult != DialogResult.OK)) && (!this.bool_2 && this.bool_1)) && (MessageBox.Show("Документ изменен. Сохранить текущие изменения?", "Сохранение.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    if (this.method_33())
                    {
                        base.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                catch (Exception exception1)
                {
                    if (MessageBox.Show(exception1.Message + Environment.NewLine + "Закрыть окно?", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void FormAbnAktRBP_Load(object sender, EventArgs e)
        {
            this.label_5.Text = this.label_18.Text = this.label_27.Text = "Границей " + ((this.TypeDocValue == 1) ? "балансовой принадлежности" : ((this.TypeDocValue == 4) ? "эксплуатационной ответственности" : "")) + " сторон является:";
            if (this.tabControl_0.TabPages.Contains(this.tabPage_5))
            {
                this.tabControl_0.TabPages.Remove(this.tabPage_5);
            }
            if (this.IdList > 0)
            {
                this.method_25();
            }
            if ((this.IdActTehConnection <= 0) && (this.IdTU > 0))
            {
                DataTable table = base.SelectSqlData("ttc_doc", true, " where idParent = " + this.IdTU.ToString() + " and typeDoc = " + 0x4d8.ToString());
                if (table.Rows.Count > 0)
                {
                    this.IdActTehConnection = Convert.ToInt32(table.Rows[0]["id"]);
                }
            }
            if (((this.IdAbn <= 0) || (this.int_4 <= 0)) && (this.IdList > 0))
            {
                DataSetGES.tAbnObjDoc_ListDataTable table2 = new DataSetGES.tAbnObjDoc_ListDataTable();
                base.SelectSqlData(table2, true, "where id = " + this.IdList.ToString(), false);
                if (((table2.Rows.Count > 0) && (table2.Rows[0]["idAbnObj"] != DBNull.Value)) && (this.IdAbnObj <= 0))
                {
                    this.IdAbnObj = Convert.ToInt32(table2.Rows[0]["idAbnObj"]);
                }
                if ((table2.Rows[0]["idAbn"] != DBNull.Value) && (this.IdAbn <= 0))
                {
                    this.IdAbn = Convert.ToInt32(table2.Rows[0]["idAbn"]);
                }
            }
        }

        private void FormAbnAktRBP_Shown(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        public void GetTepmlate(int idTemplate, out string fileName, out byte[] fileData)
        {
            fileName = "";
            fileData = null;
            string cmdText = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
            using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                command.Parameters.Add("@idTemplate", SqlDbType.Int);
                command.Parameters["@idTemplate"].Value = idTemplate;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        fileName = (string) reader.GetValue(0);
                        fileData = (byte[]) reader.GetValue(1);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        private void method_0()
        {
            this.textBoxDropDown_0 = new TextBoxDropDown();
            this.elementHost_6.Child = this.textBoxDropDown_0;
            this.textBoxDropDown_0.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
            this.textBoxDropDown_1 = new TextBoxDropDown();
            this.elementHost_7.Child = this.textBoxDropDown_1;
            this.textBoxDropDown_1.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
            this.textBoxDropDown_8 = new TextBoxDropDown();
            this.elementHost_5.Child = this.textBoxDropDown_8;
            this.textBoxDropDown_8.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
            this.textBoxDropDown_5 = new TextBoxDropDown();
            this.elementHost_0.Child = this.textBoxDropDown_5;
            this.textBoxDropDown_5.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
            this.textBoxDropDown_6 = new TextBoxDropDown();
            this.elementHost_1.Child = this.textBoxDropDown_6;
            this.textBoxDropDown_6.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
            this.textBoxDropDown_7 = new TextBoxDropDown();
            this.elementHost_8.Child = this.textBoxDropDown_7;
            this.textBoxDropDown_7.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
            this.textBoxDropDown_2 = new TextBoxDropDown();
            this.elementHost_2.Child = this.textBoxDropDown_2;
            this.textBoxDropDown_2.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
            this.textBoxDropDown_3 = new TextBoxDropDown();
            this.elementHost_3.Child = this.textBoxDropDown_3;
            this.textBoxDropDown_3.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
            this.textBoxDropDown_4 = new TextBoxDropDown();
            this.elementHost_4.Child = this.textBoxDropDown_4;
            this.textBoxDropDown_4.add_TextChanged(new TextChangedEventHandler(this.textBox_16_TextChanged));
        }

        private void method_1(bool bool_3)
        {
            this.comboBox_1.Enabled = bool_3;
            this.comboBox_0.Enabled = bool_3;
            this.textBox_7.ReadOnly = bool_3;
            this.textBox_1.ReadOnly = bool_3;
            this.textBoxDropDown_5.set_ReadOnly(bool_3);
            this.textBoxDropDown_2.set_ReadOnly(bool_3);
            this.textBoxDropDown_0.set_ReadOnly(bool_3);
            this.textBox_14.ReadOnly = bool_3;
            this.textBoxDropDown_7.set_ReadOnly(bool_3);
            this.textBoxDropDown_4.set_ReadOnly(bool_3);
            this.textBoxDropDown_8.set_ReadOnly(bool_3);
            this.textBoxDropDown_6.set_ReadOnly(bool_3);
            this.textBoxDropDown_3.set_ReadOnly(bool_3);
            this.textBoxDropDown_1.set_ReadOnly(bool_3);
            this.textBox_5.ReadOnly = bool_3;
            this.textBox_4.ReadOnly = bool_3;
            this.textBox_6.ReadOnly = bool_3;
            this.textBox_21.ReadOnly = bool_3;
            this.textBox_9.ReadOnly = bool_3;
            this.textBox_16.ReadOnly = bool_3;
            this.textBox_10.ReadOnly = bool_3;
            this.textBox_17.ReadOnly = bool_3;
            this.textBox_11.ReadOnly = bool_3;
            this.textBox_15.ReadOnly = bool_3;
            this.textBox_8.ReadOnly = bool_3;
            this.textBox_18.ReadOnly = bool_3;
            this.textBox_3.ReadOnly = bool_3;
            this.textBox_0.ReadOnly = bool_3;
            this.textBox_20.ReadOnly = bool_3;
            this.textBox_19.ReadOnly = bool_3;
            this.textBox_2.ReadOnly = bool_3;
            this.textBox_12.ReadOnly = bool_3;
            this.textBox_13.ReadOnly = bool_3;
            this.toolStripButton_0.Enabled = bool_3;
            this.toolStripButton_1.Enabled = bool_3;
            this.toolStripDropDownButton_0.Enabled = bool_3;
            this.toolStripButton_4.Enabled = bool_3;
            this.toolStripButton_6.Enabled = bool_3;
            this.toolStripButton_7.Enabled = bool_3;
            this.button_3.Enabled = bool_3;
            this.button_1.Enabled = bool_3;
            this.button_0.Enabled = bool_3;
        }

        private void method_10(byte[] byte_0, int int_5)
        {
            try
            {
                Bitmap original = ImageCompress.LoadBitmap(byte_0);
                if (original != null)
                {
                    object[] values = new object[] { new Bitmap(original, 120, 160), original, true, int_5 };
                    this.dataGridViewExcelFilter_0.Rows.Add(values);
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString());
            }
        }

        private void method_11(object sender, EventArgs e)
        {
            if (this.textBox_14.Text != "")
            {
                this.textBox_2.Text = "";
                this.textBox_2.Enabled = false;
            }
            else
            {
                this.textBox_2.Enabled = true;
            }
        }

        private void method_12()
        {
            DataSetTechConnection.tAbnDataTable table = new DataSetTechConnection.tAbnDataTable();
            base.SelectSqlData(table, true, " where id = " + this.IdAbn.ToString(), false);
            if (table.Rows.Count > 0)
            {
                this.comboBoxReadOnly_0.SelectedValueChanged -= new EventHandler(this.comboBoxReadOnly_0_SelectedValueChanged);
                int num2 = Convert.ToInt32(table.Rows[0]["typeAbn"]);
                DataSetTechConnection.vAbnObjAddressDataTable table2 = new DataSetTechConnection.vAbnObjAddressDataTable();
                DataColumn column = new DataColumn("AddressFL") {
                    Expression = "street + ', д. ' + houseall + isnull(', кв. ' + name, '')"
                };
                table2.Columns.Add(column);
                column = new DataColumn("AddressUL") {
                    Expression = "street + ', д. ' + houseall"
                };
                table2.Columns.Add(column);
                base.SelectSqlData(table2, true, "where idAbn = " + this.IdAbn.ToString() + " order by name", false);
                this.comboBoxReadOnly_0.ValueMember = "id";
                this.comboBoxReadOnly_0.DataSource = table2;
                if (((num2 != 0xce) && (num2 != 0xfd)) && (num2 != 0x40d))
                {
                    this.comboBoxReadOnly_0.DisplayMember = "name";
                }
                else
                {
                    this.comboBoxReadOnly_0.DisplayMember = "AddressFL";
                }
                this.comboBoxReadOnly_0.SelectedValue = this.IdAbnObj;
                if (this.comboBoxReadOnly_0.SelectedValue == null)
                {
                    this.IdAbnObj = -1;
                }
                this.comboBoxReadOnly_0.SelectedValueChanged += new EventHandler(this.comboBoxReadOnly_0_SelectedValueChanged);
            }
            else
            {
                this.comboBoxReadOnly_0.Items.Clear();
                this.IdAbnObj = -1;
            }
        }

        private void method_13(int int_5)
        {
            if (((int) this.comboBox_0.SelectedValue) != -1)
            {
                SqlDataConnect connect = new SqlDataConnect();
                try
                {
                    connect.OpenConnection(this.get_SqlSettings());
                    SqlParameter parameter = new SqlParameter("@Region", (int) this.comboBox_0.SelectedValue);
                    SqlCommand command1 = new SqlCommand("select dbo.fn_GetMaxNumAct(@Region, @ActYear, @TypeDocValue)", connect.get_Connection());
                    command1.Parameters.Add(parameter);
                    SqlParameter parameter2 = new SqlParameter("@ActYear", this.dateTimePicker_0.Value.Year);
                    command1.Parameters.Add(parameter2);
                    SqlParameter parameter3 = new SqlParameter("@TypeDocValue", int_5);
                    command1.Parameters.Add(parameter3);
                    command1.CommandTimeout = 0;
                    string str = command1.ExecuteScalar().ToString();
                    this.textBox_7.Text = str;
                    return;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                    return;
                }
                finally
                {
                    connect.CloseConnection();
                }
            }
            this.textBox_7.Text = "";
        }

        private void method_14(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private string method_15(string string_1)
        {
            string str = string.IsNullOrEmpty(string_1) ? string_1 : "tmp";
            string path = Path.GetTempPath() + @"\" + str + @"\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private void method_16(string string_1, string string_2, object object_0, bool bool_3 = false)
        {
            byte[] buffer;
            string str2;
            string str4;
            string abnName = this.method_18(this.IdAbn);
            int tag = (int) ((ToolStripMenuItem) object_0).Tag;
            this.GetTepmlate(tag, out str2, out buffer);
            if (string.IsNullOrEmpty(string_2))
            {
                DateTime time = this.dateTimePicker_0.Value;
                string[] textArray1 = new string[7];
                string[] textArray2 = new string[] { this.IdAbnObj.ToString() };
                textArray1[0] = base.CallSQLScalarFunction("dbo.TPStr", textArray2).ToString();
                textArray1[1] = " ";
                textArray1[2] = abnName;
                textArray1[3] = " ";
                textArray1[4] = this.textBox_7.Text;
                textArray1[5] = " ";
                textArray1[6] = time.ToString("ddMMyy");
                string_2 = string.Concat(textArray1).Replace("\"", string.Empty) + ".doc";
            }
            string extension = new FileInfo(string_2).Extension;
            uint num3 = Class227.smethod_0(extension);
            if (num3 <= 0x667e718c)
            {
                if (num3 <= 0x1df63c41)
                {
                    if (num3 == 0x1c03050e)
                    {
                        if (extension == ".xlsx")
                        {
                        }
                    }
                    else if ((num3 == 0x1df63c41) && (extension == ".xltx"))
                    {
                        goto Label_01BA;
                    }
                }
                else if (num3 != 0x60538713)
                {
                    if ((num3 == 0x667e718c) && (extension == ".dotx"))
                    {
                        goto Label_01F9;
                    }
                }
                else if (extension == ".docx")
                {
                }
                goto Label_0224;
            }
            if (num3 > 0xbdb3c702)
            {
                if (num3 == 0xc107d4f9)
                {
                    if (extension == ".doc")
                    {
                    }
                    goto Label_0224;
                }
                if ((num3 != 0xd207efbc) || (extension != ".dot"))
                {
                    goto Label_0224;
                }
                goto Label_01F9;
            }
            if (num3 != 0xb8b3bf23)
            {
                if ((num3 == 0xbdb3c702) && (extension != ".xls"))
                {
                }
                goto Label_0224;
            }
            if (extension != ".xlt")
            {
                goto Label_0224;
            }
        Label_01BA:
            string_2 = string_2.Replace(extension, extension.Replace("t", "s"));
            goto Label_0224;
        Label_01F9:
            string_2 = string_2.Replace(extension, extension.Replace("t", "c"));
        Label_0224:
            str4 = string.IsNullOrEmpty(string_1) ? this.method_15(this.textBox_7.Text) : string_1;
            string str5 = FileBinary.GetNewFileNameIsExists(str4, string_2, false);
            string str6 = this.method_21(string_2, new int?(tag), buffer, bool_3);
            if (!string.IsNullOrEmpty(str6))
            {
                this.bool_1 = true;
                FileBinary binary = new FileBinary(buffer, str5, DateTime.Now);
                binary.SaveToDisk(str4);
                extension = new FileInfo(string_2).Extension;
                if (bool_3)
                {
                    if (this.dictionary_0.ContainsKey(str6))
                    {
                        FileWatcher watcher = new FileWatcher(str4, binary.get_Name());
                        watcher.add_AnyChanged(new FileSystemEventHandler(this.method_19));
                        watcher.Start();
                        this.dictionary_0[str6].set_TempName(str5);
                        this.dictionary_0[str6].set_Watcher(watcher);
                        this.dictionary_0[str6].set_OpenState(1);
                    }
                    else
                    {
                        MessageBox.Show("Что то пошло не так");
                    }
                }
                this.CreateActRbp(abnName, str4 + @"\" + str5);
            }
        }

        private int method_17(int int_5)
        {
            int num = -1;
            DataTable table = base.SelectSqlData("tAbnObj", true, string.Format(" where id = {0}", int_5));
            if (table.Rows.Count > 0)
            {
                num = (int) table.Rows[0]["idAbn"];
            }
            return num;
        }

        private string method_18(int int_5)
        {
            string str = "";
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vAbn, true, string.Format(" where id = {0}", int_5), true);
            if (this.dataSetGES_0.vAbn.Rows.Count > 0)
            {
                str = this.dataSetGES_0.vAbn.First<DataSetGES.Class143>().Name.Trim();
            }
            return str;
        }

        private void method_19(object sender, FileSystemEventArgs e)
        {
            Class285 class2 = new Class285 {
                fileSystemEventArgs_0 = e
            };
            class2.ienumerable_0 = this.dictionary_0.Where<KeyValuePair<string, FileWatcherArgsAddl>>(new Func<KeyValuePair<string, FileWatcherArgsAddl>, bool>(class2.method_0));
            if (class2.ienumerable_0.Count<KeyValuePair<string, FileWatcherArgsAddl>>() > 0)
            {
                FileBinary binary = new FileBinary(class2.fileSystemEventArgs_0.FullPath);
                EnumerableRowCollection<DataSetGES.Class140> source = this.dataSetGES_0.tAbnObjDoc_File.Where<DataSetGES.Class140>(new Func<DataSetGES.Class140, bool>(class2.method_1));
                if (source.Count<DataSetGES.Class140>() == 0)
                {
                    DataSetGES.Class140 class3 = this.dataSetGES_0.tAbnObjDoc_File.method_5();
                    class3.Int32_0 = (this.dataSetGES_0.tAbnObjDoc_File.Min<DataSetGES.Class140>((<>c.<>9__87_2 ?? (<>c.<>9__87_2 = new Func<DataSetGES.Class140, int>(<>c.<>9.method_0)))) < 0) ? (this.dataSetGES_0.tAbnObjDoc_File.Min<DataSetGES.Class140>((<>c.<>9__87_3 ?? (<>c.<>9__87_3 = new Func<DataSetGES.Class140, int>(<>c.<>9.method_1)))) - 1) : -1;
                    class3.idList = this.IdList;
                    class3.FileName = class2.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_OriginalName();
                    class3.File = binary.get_ByteArray();
                    class3.dateChange = binary.get_LastChanged();
                    class3.idTemplate = class2.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_IdTemplate().Value;
                    this.dataSetGES_0.tAbnObjDoc_File.method_0(class3);
                }
                else
                {
                    source.First<DataSetGES.Class140>().File = binary.get_ByteArray();
                    source.First<DataSetGES.Class140>().dateChange = binary.get_LastChanged();
                    source.First<DataSetGES.Class140>().EndEdit();
                    this.bool_1 = true;
                }
                this.method_20();
                this.bool_1 = true;
            }
        }

        private void method_2(Constants.TypeDocValue typeDocValue_1)
        {
            this.IdList = -1;
            this.TypeDocValue = typeDocValue_1;
            this.enum2_0 = Enum2.const_0;
            this.method_8();
            this.method_9();
            this.method_6();
            this.Text = (this.TypeDocValue == 1) ? "Добавление акта разграничения балансовой принадлежности" : ((this.TypeDocValue == 4) ? "Добавление акта разграничения эксплуатационной ответственности" : "");
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnDoc_Dogovor, true, " where idAbn = " + this.IdAbn.ToString() + " and FlagBreak = 0");
            if ((this.dataSetGES_0.tAbnDoc_Dogovor.Count > 0) && (this.dataSetGES_0.tAbnDoc_Dogovor.Rows[0]["BasisOF"] != DBNull.Value))
            {
                this.textBox_5.Text = this.dataSetGES_0.tAbnDoc_Dogovor.First<DataSetGES.Class130>().BasisOF;
            }
            else
            {
                this.textBox_5.Text = "устава";
            }
            this.textBox_1.Text = "до границы раздела " + ((this.TypeDocValue == 1) ? "балансовой принадлежности" : "эксплуатационной ответственности") + " со стороны потребителя";
            string str = "";
            string str2 = "";
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tG_AbnChief, true, " where idAbn = " + this.IdAbn.ToString());
            if (this.dataSetGES_0.tG_AbnChief.Rows.Count > 0)
            {
                if ((((this.dataSetGES_0.tG_AbnChief[0]["R_Post"] != DBNull.Value) && (this.dataSetGES_0.tG_AbnChief[0]["R_F"] != DBNull.Value)) && (this.dataSetGES_0.tG_AbnChief[0]["R_I"] != DBNull.Value)) && (this.dataSetGES_0.tG_AbnChief[0]["R_O"] != DBNull.Value))
                {
                    str2 = this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_F;
                    if ((str2.Length > 0) && (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_I.Length > 0))
                    {
                        str2 = str2 + " " + this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_I.Substring(0, 1) + ".";
                    }
                    if ((str2.Length > 0) && (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_O.Length > 0))
                    {
                        str2 = str2 + " " + this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_O.Substring(0, 1) + ".";
                    }
                    str2 = ((this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>()["R_Post"] != DBNull.Value) ? (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().R_Post + " ") : "") + str2;
                }
                else
                {
                    MessageBox.Show("Не заполнены должность и/или ФИО руководителя организациии в родительном падеже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                if ((((this.dataSetGES_0.tG_AbnChief[0]["I_Post"] != DBNull.Value) && (this.dataSetGES_0.tG_AbnChief[0]["I_F"] != DBNull.Value)) && (this.dataSetGES_0.tG_AbnChief[0]["I_I"] != DBNull.Value)) && (this.dataSetGES_0.tG_AbnChief[0]["I_O"] != DBNull.Value))
                {
                    str = this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().I_F;
                    if ((str.Length > 0) && (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().I_I.Length > 0))
                    {
                        str = str + " " + this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().I_I.Substring(0, 1) + ".";
                    }
                    if ((str.Length > 0) && (this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().I_O.Length > 0))
                    {
                        str = str + " " + this.dataSetGES_0.tG_AbnChief.First<DataSetGES.Class139>().I_O.Substring(0, 1) + ".";
                    }
                }
                else
                {
                    MessageBox.Show("Не заполнены должность и/или ФИО руководителя организациии в именительном падеже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Не заполнены должность и ФИО руководителя организациии.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            this.textBox_6.Text = str2;
            this.textBox_0.Text = str;
        }

        private void method_20()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new Action(this.method_37));
            }
            else
            {
                this.bindingSource_0.ResetBindings(false);
            }
        }

        private string method_21(string string_1, int? nullable_1 = new int?(), byte[] byte_0 = null, bool bool_3 = false)
        {
            // This item is obfuscated and can not be translated.
            string fileName = Path.GetFileName(string_1);
            bool flag = true;
            while (base.SelectSqlData("tAbnObjDoc_File", true, string.Format("where idList = {0} AND FileName = '{1}'", this.IdList, fileName)).Rows.Count > 0)
            {
            Label_000C:
                if (!(true & bool_3))
                {
                    goto Label_008B;
                }
                if (MessageBox.Show("Файл с именем " + fileName + " уже существует. Изменить имя файла на другое?", "Внимание.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    flag = false;
                    goto Label_008B;
                }
                FormNewFileName name = new FormNewFileName(fileName);
                if (name.ShowDialog() == DialogResult.OK)
                {
                    fileName = name.method_0();
                }
            }
            goto Label_000C;
        Label_008B:
            if (!flag)
            {
                return null;
            }
            if (bool_3)
            {
                FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable_1, fileName, null, 2);
                this.dictionary_0.Add(fileName, addl);
                DataSetGES.Class140 class2 = this.dataSetGES_0.tAbnObjDoc_File.method_5();
                class2.Int32_0 = (this.dataSetGES_0.tAbnObjDoc_File.Count > 0) ? (this.dataSetGES_0.tAbnObjDoc_File.Where<DataSetGES.Class140>((<>c.<>9__89_0 ?? (<>c.<>9__89_0 = new Func<DataSetGES.Class140, bool>(<>c.<>9.method_2)))).Min<DataSetGES.Class140>((<>c.<>9__89_1 ?? (<>c.<>9__89_1 = new Func<DataSetGES.Class140, int>(<>c.<>9.method_3)))) - 1) : -1;
                class2.idList = this.IdList;
                class2.FileName = fileName;
                if (byte_0 == null)
                {
                    FileBinary binary = new FileBinary(string_1);
                    class2.File = binary.get_ByteArray();
                    class2.dateChange = binary.get_LastChanged();
                }
                else
                {
                    class2.File = byte_0;
                    class2.dateChange = DateTime.Now;
                }
                if (nullable_1.HasValue)
                {
                    class2.idTemplate = nullable_1.Value;
                }
                this.dataSetGES_0.tAbnObjDoc_File.method_0(class2);
                class2.EndEdit();
                this.bool_1 = true;
            }
            return fileName;
        }

        private void method_22(bool bool_3 = false)
        {
            if (this.bindingSource_0.Current != null)
            {
                byte[] file;
                DataSetGES.Class140 row = (DataSetGES.Class140) ((DataRowView) this.bindingSource_0.Current).Row;
                string fileName = row.FileName;
                string str2 = this.method_15(this.textBox_7.Text);
                string str3 = FileBinary.GetNewFileNameIsExists(str2, fileName, false);
                int? nullable = null;
                if (row["idTemplate"] != DBNull.Value)
                {
                    nullable = new int?(row.idTemplate);
                }
                DateTime dateChange = row.dateChange;
                if (row["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                        {
                            connection.Open();
                            SqlDataReader reader = new SqlCommand("SELECT [File] FROM tTC_DocFile WHERE id = " + row["id"].ToString(), connection).ExecuteReader();
                            while (reader.Read())
                            {
                                row["File"] = reader["File"];
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                    }
                }
                try
                {
                    file = row.File;
                }
                catch
                {
                    MessageBox.Show("Нет содержимого файла");
                    return;
                }
                FileBinary binary = new FileBinary(file, str3, DateTime.Now);
                binary.SaveToDisk(str2);
                Process.Start(str2 + @"\" + binary.get_Name());
                if (bool_3)
                {
                    if (this.dictionary_0.ContainsKey(fileName))
                    {
                        if (this.dictionary_0[fileName].get_Watcher() == null)
                        {
                            FileWatcher watcher = new FileWatcher(str2, str3);
                            watcher.add_AnyChanged(new FileSystemEventHandler(this.method_19));
                            watcher.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher);
                        }
                        else
                        {
                            this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_19));
                            this.dictionary_0[fileName].get_Watcher().Stop();
                            FileWatcher watcher2 = new FileWatcher(str2, str3);
                            watcher2.add_AnyChanged(new FileSystemEventHandler(this.method_19));
                            watcher2.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher2);
                        }
                        this.dictionary_0[fileName].set_TempName(str3);
                        this.dictionary_0[fileName].set_OpenState(1);
                    }
                    else
                    {
                        FileWatcher watcher3 = new FileWatcher(str2, str3);
                        watcher3.add_AnyChanged(new FileSystemEventHandler(this.method_19));
                        watcher3.Start();
                        FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable, fileName, str3, watcher3, 1);
                        this.dictionary_0.Add(fileName, addl);
                    }
                    this.bool_1 = true;
                }
            }
        }

        private bool method_23(int int_5)
        {
            foreach (DataRow row in this.dataSetGES_0.tAbnObjDoc_File)
            {
                if (((row.RowState != DataRowState.Deleted) && (row.RowState != DataRowState.Detached)) && (Convert.ToInt32(row["idList"]) != int_5))
                {
                    row["idList"] = int_5;
                    row.EndEdit();
                }
            }
            if ((base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_File) && base.UpdateSqlDataOnlyChange(this.dataSetGES_0.tAbnObjDoc_File)) && base.DeleteSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_File))
            {
                this.dataSetGES_0.tAbnObjDoc_File.AcceptChanges();
                return true;
            }
            return false;
        }

        private void method_24(int int_5)
        {
            this.bindingSource_2.RaiseListChangedEvents = true;
            this.bindingSource_2.CurrentChanged -= new EventHandler(this.bindingSource_2_CurrentChanged);
            string selectCommandText = "select  d.id, d.numdoc, d.datedoc,  isnull(d.numdoc + ' ', '') + 'от ' + isnull(convert( varchar(10),d.Datedoc, 104), '') as numDatedoc  from ttc_doc d  where typeDoc = " + 0x4d8.ToString() + "union select -1, null, null, '' order by numDoc, dateDoc ";
            DataTable dataTable = new DataTable();
            SqlDataConnect connect = new SqlDataConnect();
            if (connect.OpenConnection(this.get_SqlSettings()))
            {
                try
                {
                    new SqlDataAdapter(selectCommandText, connect.get_Connection()).Fill(dataTable);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
            this.bindingSource_2.DataSource = dataTable;
            this.bindingSource_2.Sort = "numDoc, dateDoc";
            this.comboBox_1.DataSource = this.bindingSource_2;
            this.comboBox_1.DisplayMember = "numDateDoc";
            this.comboBox_1.ValueMember = "id";
            if (int_5 != -1)
            {
                this.bindingSource_2.Position = this.bindingSource_2.Find("id", int_5);
            }
            this.bindingSource_2.CurrentChanged += new EventHandler(this.bindingSource_2_CurrentChanged);
            this.bindingSource_2.RaiseListChangedEvents = false;
            this.bindingSource_2_CurrentChanged(this.bindingSource_2, new EventArgs());
        }

        private void method_25()
        {
            this.dataGridView_1.Rows.Clear();
            if (this.IdList > 0)
            {
                string[] textArray1 = new string[] { " where idTU = ", this.IdList.ToString(), " and typeDoc = ", this.nullable_0.ToString(), "  order by num" };
                string str = string.Concat(textArray1);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUPointAttach, true, str);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_TUPointAttach, true, str);
                foreach (DataRow row in this.dataSetTechConnection_0.vTC_TUPointAttach)
                {
                    object[] values = new object[] { 
                        row["id"], row["num"], row["idSubPoint"], row["SubPoint"], row["idBusPoint"], row["BusPoint"], row["idCellPoint"], row["CellPoint"], row["idSubCP"], row["SubCP"], row["idBusCP"], row["BusCP"], row["idCellCP"], row["CellCP"], row["VoltageLevel"], row["VoltageLevelName"],
                        row["PowerSum"]
                    };
                    this.dataGridView_1.Rows.Add(values);
                }
            }
        }

        private void method_26()
        {
            this.dataGridView_1.Rows.Clear();
            string[] textArray1 = new string[] { " where idTU = ", this.IdTU.ToString(), " and (typeDoc is null or typeDoc = ", 0x463.ToString(), ")  order by num" };
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_TUPointAttach, true, string.Concat(textArray1));
            foreach (DataRow row in this.dataSetTechConnection_0.vTC_TUPointAttach)
            {
                object[] values = new object[] { 
                    -1, -1, row["idSubPoint"], row["SubPoint"], row["idBusPoint"], row["BusPoint"], row["idCellPoint"], row["CellPoint"], row["idSubCP"], row["SubCP"], row["idBusCP"], row["BusCP"], row["idCellCP"], row["CellCP"], row["VoltageLevel"], row["VoltageLevelName"],
                    row["PowerSum"]
                };
                this.dataGridView_1.Rows.Add(values);
            }
        }

        private bool method_27()
        {
            if (!this.method_28(this.dataSetTechConnection_0.tTC_TUPointAttach, this.IdList, Convert.ToInt32(this.nullable_0)))
            {
                return false;
            }
            if (this.IdActTehConnection > 0)
            {
                string[] textArray1 = new string[] { " where idTU = ", this.IdActTehConnection.ToString(), " and (typeDoc is null or typeDoc = ", 0x4d8.ToString(), ")   order by num" };
                string str = string.Concat(textArray1);
                DataSetTechConnection.tTC_TUPointAttachDataTable table = new DataSetTechConnection.tTC_TUPointAttachDataTable();
                base.SelectSqlData(table, true, str, false);
                if (!this.method_28(table, this.IdActTehConnection, 0x4d8))
                {
                    return false;
                }
                this.method_30();
            }
            return true;
        }

        private bool method_28(DataTable dataTable_0, int int_5, int int_6)
        {
            foreach (DataGridViewRow row in (IEnumerable) this.dataGridView_1.Rows)
            {
                if (row.Index < dataTable_0.Rows.Count)
                {
                    dataTable_0.Rows[row.Index]["idTU"] = int_5;
                    dataTable_0.Rows[row.Index]["num"] = row.Index + 1;
                    dataTable_0.Rows[row.Index]["idSubPoint"] = (row.Cells[this.dataGridViewTextBoxColumn_62.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_62.Name].Value : DBNull.Value;
                    dataTable_0.Rows[row.Index]["idBusPoint"] = (row.Cells[this.dataGridViewTextBoxColumn_64.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_64.Name].Value : DBNull.Value;
                    dataTable_0.Rows[row.Index]["idCellPoint"] = (row.Cells[this.dataGridViewTextBoxColumn_66.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_66.Name].Value : DBNull.Value;
                    dataTable_0.Rows[row.Index]["idSubCP"] = (row.Cells[this.dataGridViewTextBoxColumn_68.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_68.Name].Value : DBNull.Value;
                    dataTable_0.Rows[row.Index]["idBusCP"] = (row.Cells[this.dataGridViewTextBoxColumn_70.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_70.Name].Value : DBNull.Value;
                    dataTable_0.Rows[row.Index]["idCellCP"] = (row.Cells[this.dataGridViewTextBoxColumn_72.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_72.Name].Value : DBNull.Value;
                    dataTable_0.Rows[row.Index]["voltageLevel"] = (row.Cells[this.dataGridViewTextBoxColumn_74.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_74.Name].Value : DBNull.Value;
                    dataTable_0.Rows[row.Index]["PowerSum"] = (row.Cells[this.dataGridViewTextBoxColumn_76.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_76.Name].Value : DBNull.Value;
                    dataTable_0.Rows[row.Index]["TypeDoc"] = int_6;
                    dataTable_0.Rows[row.Index].EndEdit();
                }
                else
                {
                    DataRow row2 = dataTable_0.NewRow();
                    row2["idTU"] = int_5;
                    row2["num"] = row.Index + 1;
                    if (row.Cells[this.dataGridViewTextBoxColumn_62.Name].Value != null)
                    {
                        row2["idSubPoint"] = row.Cells[this.dataGridViewTextBoxColumn_62.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_64.Name].Value != null)
                    {
                        row2["idBusPoint"] = row.Cells[this.dataGridViewTextBoxColumn_64.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_66.Name].Value != null)
                    {
                        row2["idCellPoint"] = row.Cells[this.dataGridViewTextBoxColumn_66.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_68.Name].Value != null)
                    {
                        row2["idSubCP"] = row.Cells[this.dataGridViewTextBoxColumn_68.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_70.Name].Value != null)
                    {
                        row2["idBusCP"] = row.Cells[this.dataGridViewTextBoxColumn_70.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_72.Name].Value != null)
                    {
                        row2["idCellCP"] = row.Cells[this.dataGridViewTextBoxColumn_72.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_74.Name].Value != null)
                    {
                        row2["voltageLevel"] = row.Cells[this.dataGridViewTextBoxColumn_74.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_76.Name].Value != null)
                    {
                        row2["PowerSum"] = row.Cells[this.dataGridViewTextBoxColumn_76.Name].Value;
                    }
                    row2["TypeDoc"] = int_6;
                    dataTable_0.Rows.Add(row2);
                }
            }
            for (int i = dataTable_0.Rows.Count - 1; i > (this.dataGridView_1.Rows.Count - 1); i--)
            {
                dataTable_0.Rows[i].Delete();
            }
            base.InsertSqlData(dataTable_0);
            base.UpdateSqlData(dataTable_0);
            base.DeleteSqlData(dataTable_0);
            this.method_25();
            return true;
        }

        private bool method_29()
        {
            if (!this.panel_1.Visible)
            {
                if ((this.IdAbn <= 0) || (this.IdAbnObj <= 0))
                {
                    return true;
                }
                DataSetTechConnection.tL_SchmAbnDataTable table = new DataSetTechConnection.tL_SchmAbnDataTable();
                base.SelectSqlData(table, true, " where idDoc = " + this.IdList.ToString() + " and typeDoc = " + this.nullable_0.ToString(), false);
                List<int> list = new List<int>();
                foreach (DataRow row in this.dataSetTechConnection_0.tTC_TUPointAttach)
                {
                    int num2 = -1;
                    if (row["idCellPoint"] != DBNull.Value)
                    {
                        num2 = Convert.ToInt32(row["idCellPoint"]);
                    }
                    else if (row["idBusPoint"] != DBNull.Value)
                    {
                        num2 = Convert.ToInt32(row["idBusPoint"]);
                    }
                    else if (row["idSubPoint"] != DBNull.Value)
                    {
                        num2 = Convert.ToInt32(row["idSubPoint"]);
                    }
                    if (num2 != -1)
                    {
                        DataRow[] source = table.Select("idSChmObj = " + num2.ToString());
                        if (source.Count<DataRow>() > 0)
                        {
                            source[0]["idAbn"] = this.IdAbn;
                            source[0]["idAbnObj"] = this.IdAbnObj;
                            source[0]["idPoint"] = DBNull.Value;
                            source[0]["idDoc"] = this.IdList;
                            source[0]["typeDoc"] = this.nullable_0;
                            source[0].EndEdit();
                            list.Add((int) source[0]["id"]);
                        }
                        else
                        {
                            DataRow row2 = table.NewRow();
                            row2["idSchmObj"] = num2;
                            row2["idAbn"] = this.IdAbn;
                            row2["idAbnObj"] = this.IdAbnObj;
                            row2["idPoint"] = DBNull.Value;
                            row2["idDoc"] = this.IdList;
                            row2["typeDoc"] = this.nullable_0;
                            table.Rows.Add(row2);
                        }
                    }
                }
                foreach (DataRow row3 in table.Rows)
                {
                    if ((row3.RowState != DataRowState.Added) && !list.Contains(Convert.ToInt32(row3["id"])))
                    {
                        base.DeleteSqlDataById(table, Convert.ToInt32(row3["id"]));
                    }
                }
                if (!base.InsertSqlData(table))
                {
                    return false;
                }
                if (!base.UpdateSqlData(table))
                {
                    return false;
                }
            }
            return true;
        }

        private Constants.TypeDocValue method_3(int int_5)
        {
            string selectCommandText = "select c.Value from tAbnObjDoc_List d join tR_Classifier c on d.idDocType = c.id where d.id = " + int_5.ToString();
            int num = 0;
            DataTable dataTable = new DataTable();
            SqlDataConnect connect = new SqlDataConnect();
            if (connect.OpenConnection(this.get_SqlSettings()))
            {
                try
                {
                    new SqlDataAdapter(selectCommandText, connect.get_Connection()).Fill(dataTable);
                    num = ((dataTable.Rows.Count <= 0) || (dataTable.Rows[0]["Value"] == DBNull.Value)) ? 0 : int.Parse(Math.Round((decimal) dataTable.Rows[0]["Value"], 0).ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
            if (num <= 0)
            {
                return 0;
            }
            return (Constants.TypeDocValue) num;
        }

        private bool method_30()
        {
            DataSetTechConnection.tL_SchmAbnDataTable table = new DataSetTechConnection.tL_SchmAbnDataTable();
            base.SelectSqlData(table, true, " where idDoc = " + this.IdActTehConnection.ToString() + " and typeDoc = " + 0x4d8.ToString(), false);
            foreach (DataRow row in table.Rows)
            {
                base.DeleteSqlDataById(table, Convert.ToInt32(row["id"]));
            }
            return true;
        }

        private bool method_31()
        {
            if ((this.IdAbn > 0) && (this.IdAbnObj > 0))
            {
                DataSetTechConnection.tAbnDataTable table = new DataSetTechConnection.tAbnDataTable();
                base.SelectSqlData(table, true, "where id = " + this.IdAbn.ToString(), false);
                DataSetTechConnection.tAbnObjDataTable table2 = new DataSetTechConnection.tAbnObjDataTable();
                base.SelectSqlData(table2, true, "where id = " + this.IdAbnObj.ToString(), false);
                if (table.Rows.Count > 0)
                {
                    if (Convert.ToInt32(table.Rows[0]["TypeAbn"]) == 0x40d)
                    {
                        table.Rows[0]["TypeAbn"] = 0xce;
                    }
                    if (Convert.ToInt32(table.Rows[0]["TypeAbn"]) == 0x40e)
                    {
                        table.Rows[0]["TypeAbn"] = 0xcf;
                    }
                    table.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(table))
                    {
                        return false;
                    }
                }
                if ((table2.Rows.Count > 0) && (table2.Rows[0]["typeObj"] != DBNull.Value))
                {
                    if (Convert.ToInt32(table2.Rows[0]["typeObj"]) == 0x47c)
                    {
                        table2.Rows[0]["typeObj"] = 0x47a;
                    }
                    if (Convert.ToInt32(table2.Rows[0]["typeObj"]) == 0x47d)
                    {
                        table2.Rows[0]["typeObj"] = 0x47b;
                    }
                    table2.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(table2))
                    {
                        return false;
                    }
                }
                DataSetTechConnection.tAbnStatusDataTable table3 = new DataSetTechConnection.tAbnStatusDataTable();
                base.SelectSqlData(table3, true, string.Format(" where idAbn = {0}", this.IdAbn), false);
                if (table3.Rows.Count == 0)
                {
                    DataRow row = table3.NewRow();
                    row["idAbn"] = this.IdAbn;
                    row["isActive"] = true;
                    row["dateChange"] = this.dateTimePicker_0.Value;
                    table3.Rows.Add(row);
                    if (!base.InsertSqlData(table3))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private int method_32(int int_5, string string_1, DateTime dateTime_0, int int_6)
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_List, true, " where idAbnObj = " + int_5.ToString() + " and  idDocType=" + int_6.ToString() + " and isActive = 1", true);
            if (this.dataSetGES_0.tAbnObjDoc_List.Rows.Count > 0)
            {
                this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().isActive = false;
                base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_List);
            }
            this.dataRow_0 = this.dataSetGES_0.tAbnObjDoc_List.NewRow();
            this.dataRow_0["idAbnObj"] = int_5;
            this.dataRow_0["DocNumber"] = string_1;
            this.dataRow_0["DocDate"] = dateTime_0;
            this.dataRow_0["idDocType"] = int_6;
            this.dataRow_0["isActive"] = true;
            this.dataRow_0["Deleted"] = false;
            this.dataRow_0["idAbn"] = this.IdAbn;
            this.dataSetGES_0.tAbnObjDoc_List.Rows.Add(this.dataRow_0);
            base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_List);
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_List, true, " where idAbnObj = " + int_5.ToString() + " and  idDocType=" + int_6.ToString() + " and  isActive = 1 order by id desc ", true);
            if (this.dataSetGES_0.tAbnObjDoc_List.Rows.Count > 0)
            {
                return Convert.ToInt32(this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().Int32_0);
            }
            MessageBox.Show("Не удалось добавить документ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return -1;
        }

        private bool method_33()
        {
            if (((this.comboBox_0.SelectedValue != null) && (((int) this.comboBox_0.SelectedValue) != -1)) && (this.textBox_7.Text != ""))
            {
                try
                {
                    int num = -1;
                    int num2 = -1;
                    string[] textArray1 = new string[] { ";TypeDoc;tAbnObj;", ((int) this.TypeDocValue).ToString() };
                    int num3 = (int) base.CallSQLScalarFunction("dbo.fn_GetIdClassifier", textArray1);
                    this.button_3.DialogResult = DialogResult.OK;
                    if (this.IdList == -1)
                    {
                        this.IdList = this.method_32(this.IdAbnObj, this.textBox_7.Text, this.dateTimePicker_0.Value, num3);
                        if (this.IdList != -1)
                        {
                            this.dataRow_0 = this.dataSetGES_0.tAbnObjDoc_AktRBP.NewRow();
                            this.dataRow_0["idList"] = this.IdList;
                            if (this.IdActTehConnection != -1)
                            {
                                this.dataRow_0["idActTehConnection"] = this.IdActTehConnection;
                            }
                            else
                            {
                                this.dataRow_0["idActTehConnection"] = DBNull.Value;
                            }
                            if (this.IdTU != -1)
                            {
                                this.dataRow_0["idTU"] = this.IdTU;
                            }
                            else
                            {
                                this.dataRow_0["idTU"] = DBNull.Value;
                            }
                            this.dataRow_0["ActData"] = this.dateTimePicker_0.Value.ToShortDateString();
                            this.dataRow_0["NetRegion"] = (int) this.comboBox_0.SelectedValue;
                            this.dataRow_0["DataNumber"] = this.textBox_7.Text;
                            this.dataRow_0["OrgFace"] = this.textBox_6.Text;
                            this.dataRow_0["OrgBase"] = this.textBox_5.Text;
                            this.dataRow_0["OrgBalance"] = this.textBoxDropDown_8.get_Text();
                            this.dataRow_0["PotrBalance"] = this.textBoxDropDown_1.get_Text();
                            this.dataRow_0["BorderBalance"] = this.textBoxDropDown_0.get_Text();
                            this.dataRow_0["OrgExpl"] = this.textBox_4.Text;
                            this.dataRow_0["PotrExpl"] = this.textBox_3.Text;
                            this.dataRow_0["Responsibility"] = this.textBox_2.Text;
                            this.dataRow_0["Admission"] = this.textBox_1.Text;
                            this.dataRow_0["PotrSignature"] = this.textBox_0.Text;
                            this.dataRow_0["Other"] = this.textBox_21.Text;
                            this.dataRow_0["OwnerName"] = this.textBox_8.Text;
                            this.dataRow_0["OwnerChief"] = this.textBox_10.Text;
                            this.dataRow_0["OwnerBase"] = this.textBox_9.Text;
                            this.dataRow_0["OrganizExpl"] = this.textBoxDropDown_7.get_Text();
                            this.dataRow_0["PotrebExpl"] = this.textBoxDropDown_6.get_Text();
                            this.dataRow_0["BorderExpl"] = this.textBoxDropDown_5.get_Text();
                            this.dataRow_0["OwnerChief2"] = this.textBox_11.Text;
                            this.dataRow_0["tbDogByOTONum"] = this.textBox_14.Text;
                            this.dataRow_0["tbTO2"] = this.textBox_13.Text;
                            this.dataRow_0["tbTO1"] = this.textBox_12.Text;
                            this.dataRow_0["OwnerName_Four"] = this.textBox_18.Text;
                            this.dataRow_0["OwnerChief_Four"] = this.textBox_17.Text;
                            this.dataRow_0["OwnerBase_Four"] = this.textBox_16.Text;
                            this.dataRow_0["OrganizExpl_Four"] = this.textBoxDropDown_4.get_Text();
                            this.dataRow_0["Border2Expl_Four"] = this.textBoxDropDown_2.get_Text();
                            this.dataRow_0["OwnerExpl_Four"] = this.textBoxDropDown_3.get_Text();
                            this.dataRow_0["OwnerChief2_Four"] = this.textBox_15.Text;
                            this.dataSetGES_0.tAbnObjDoc_AktRBP.Rows.Add(this.dataRow_0);
                            base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_AktRBP);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось сохранить акт.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_AktRBP, true, " where idList = " + this.IdList);
                        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_List, true, "where id = " + this.IdList);
                        if (this.dataSetGES_0.tAbnObjDoc_List.Rows.Count > 0)
                        {
                            if (this.dataSetGES_0.tAbnObjDoc_List.Rows[0]["idAbnObj"] != DBNull.Value)
                            {
                                num2 = Convert.ToInt32(this.dataSetGES_0.tAbnObjDoc_List.Rows[0]["idAbnObj"]);
                            }
                            if (this.dataSetGES_0.tAbnObjDoc_List.Rows[0]["idAbn"] != DBNull.Value)
                            {
                                num = Convert.ToInt32(this.dataSetGES_0.tAbnObjDoc_List.Rows[0]["idAbn"]);
                            }
                        }
                        if (this.IdActTehConnection != -1)
                        {
                            this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>()["idActTehConnection"] = this.IdActTehConnection;
                        }
                        else
                        {
                            this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>()["idActTehConnection"] = DBNull.Value;
                        }
                        if (this.IdTU != -1)
                        {
                            this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>()["idTU"] = this.IdTU;
                            this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().isActive = true;
                        }
                        else
                        {
                            this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>()["idTU"] = DBNull.Value;
                        }
                        if (((num <= 0) || (num2 <= 0)) && (this.IdTU != -1))
                        {
                            DataTable table = base.SelectSqlData("vtc_tu", true, "where id = " + this.IdTU.ToString());
                            if (table.Rows.Count > 0)
                            {
                                if (table.Rows[0]["idAbn"] != DBNull.Value)
                                {
                                    this.IdAbn = Convert.ToInt32(table.Rows[0]["idAbn"]);
                                    this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().idAbn = this.IdAbn;
                                }
                                if (table.Rows[0]["idAbnObj"] != DBNull.Value)
                                {
                                    this.IdAbnObj = Convert.ToInt32(table.Rows[0]["idAbnobj"]);
                                    this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().idAbnObj = this.IdAbnObj;
                                }
                            }
                        }
                        if (num != this.IdAbn)
                        {
                            this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().idAbn = this.IdAbn;
                        }
                        if (num2 != this.IdAbnObj)
                        {
                            this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().idAbnObj = this.IdAbnObj;
                        }
                        this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().DocDate = this.dateTimePicker_0.Value;
                        this.dataSetGES_0.tAbnObjDoc_List.First<DataSetGES.Class135>().DocNumber = this.textBox_7.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().ActData = this.dateTimePicker_0.Value.ToShortDateString();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().NetRegion = (int) this.comboBox_0.SelectedValue;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().DataNumber = this.textBox_7.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrgFace = this.textBox_6.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrgBase = this.textBox_5.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrgBalance = this.textBoxDropDown_8.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().PotrBalance = this.textBoxDropDown_1.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().BorderBalance = this.textBoxDropDown_0.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrgExpl = this.textBox_4.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().PotrExpl = this.textBox_3.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().Responsibility = this.textBox_2.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().Admission = this.textBox_1.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().PotrSignature = this.textBox_0.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().Other = this.textBox_21.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerName = this.textBox_8.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerChief = this.textBox_10.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerBase = this.textBox_9.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrganizExpl = this.textBoxDropDown_7.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().PotrebExpl = this.textBoxDropDown_6.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().BorderExpl = this.textBoxDropDown_5.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerChief2 = this.textBox_11.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().tbDogByOTONum = this.textBox_14.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().tbTO2 = this.textBox_13.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().tbTO1 = this.textBox_12.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerName_Four = this.textBox_18.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerChief_Four = this.textBox_17.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerBase_Four = this.textBox_16.Text;
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrganizExpl_Four = this.textBoxDropDown_4.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().Border2Expl_Four = this.textBoxDropDown_2.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerExpl_Four = this.textBoxDropDown_3.get_Text();
                        this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerChief2_Four = this.textBox_15.Text;
                        base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_List);
                        base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_AktRBP);
                    }
                    if ((this.TypeDocValue == 1) && !this.method_31())
                    {
                        return false;
                    }
                    if (!this.method_27())
                    {
                        return false;
                    }
                    if ((this.TypeDocValue == 1) && !this.method_29())
                    {
                        return false;
                    }
                    this.method_23(this.IdList);
                    base.DialogResult = DialogResult.OK;
                    return true;
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
            }
            MessageBox.Show("Не выбран район или отсутствует номер акта");
            return false;
        }

        private void method_34(object sender, FormClosedEventArgs e)
        {
            FormTechConnectionAddAbn abn = (FormTechConnectionAddAbn) sender;
            if (abn.DialogResult == DialogResult.OK)
            {
                this.textBox_22.Text = abn.AbnName;
                this.int_3 = abn.IdAbn;
                this.int_4 = abn.IdAbnObj;
                this.method_12();
            }
        }

        private FormBase method_35(object object_0, ShowFormEventArgs showFormEventArgs_0)
        {
            return this.OnShowForm(showFormEventArgs_0);
        }

        private void method_36()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormAbnAktRBP));
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            DataGridViewCellStyle style8 = new DataGridViewCellStyle();
            DataGridViewCellStyle style9 = new DataGridViewCellStyle();
            DataGridViewCellStyle style10 = new DataGridViewCellStyle();
            DataGridViewCellStyle style11 = new DataGridViewCellStyle();
            DataGridViewCellStyle style12 = new DataGridViewCellStyle();
            DataGridViewCellStyle style13 = new DataGridViewCellStyle();
            DataGridViewCellStyle style14 = new DataGridViewCellStyle();
            this.tableLayoutPanel_0 = new TableLayoutPanel();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.tableLayoutPanel_5 = new TableLayoutPanel();
            this.label_12 = new Label();
            this.label_2 = new Label();
            this.label_1 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_11 = new Label();
            this.button_0 = new Button();
            this.textBox_1 = new TextBox();
            this.elementHost_6 = new ElementHost();
            this.textBox_2 = new TextBox();
            this.button_1 = new Button();
            this.textBox_3 = new TextBox();
            this.comboBox_0 = new ComboBox();
            this.elementHost_7 = new ElementHost();
            this.label_10 = new Label();
            this.elementHost_5 = new ElementHost();
            this.textBox_7 = new TextBox();
            this.textBox_4 = new TextBox();
            this.label_9 = new Label();
            this.textBox_6 = new TextBox();
            this.label_3 = new Label();
            this.label_8 = new Label();
            this.textBox_5 = new TextBox();
            this.label_7 = new Label();
            this.label_4 = new Label();
            this.label_6 = new Label();
            this.label_5 = new Label();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.label_38 = new Label();
            this.textBox_21 = new TextBox();
            this.label_39 = new Label();
            this.textBox_22 = new TextBox();
            this.label_40 = new Label();
            this.comboBoxReadOnly_0 = new ComboBoxReadOnly();
            this.button_4 = new Button();
            this.tabPage_6 = new TabPage();
            this.dataGridView_1 = new DataGridView();
            this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
            this.panel_1 = new Panel();
            this.textBox_24 = new TextBox();
            this.label_41 = new Label();
            this.label_42 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.textBox_23 = new TextBox();
            this.label_43 = new Label();
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripButton_11 = new ToolStripButton();
            this.toolStripSeparator_4 = new ToolStripSeparator();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripButton_13 = new ToolStripButton();
            this.tabPage_5 = new TabPage();
            this.tableLayoutPanel_2 = new TableLayoutPanel();
            this.panel_0 = new Panel();
            this.tableLayoutPanel_6 = new TableLayoutPanel();
            this.textBox_20 = new TextBox();
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.dataSetGES_0 = new DataSetGES();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.label_36 = new Label();
            this.label_35 = new Label();
            this.label_34 = new Label();
            this.label_33 = new Label();
            this.textBox_19 = new TextBox();
            this.comboBox_1 = new ComboBox();
            this.label_37 = new Label();
            this.tabPage_1 = new TabPage();
            this.tableLayoutPanel_3 = new TableLayoutPanel();
            this.label_23 = new Label();
            this.label_13 = new Label();
            this.label_15 = new Label();
            this.textBox_8 = new TextBox();
            this.label_14 = new Label();
            this.textBox_10 = new TextBox();
            this.label_16 = new Label();
            this.textBox_9 = new TextBox();
            this.label_19 = new Label();
            this.elementHost_8 = new ElementHost();
            this.textBox_14 = new TextBox();
            this.label_18 = new Label();
            this.label_17 = new Label();
            this.textBox_11 = new TextBox();
            this.textBox_12 = new TextBox();
            this.label_21 = new Label();
            this.label_24 = new Label();
            this.label_22 = new Label();
            this.label_20 = new Label();
            this.textBox_13 = new TextBox();
            this.elementHost_1 = new ElementHost();
            this.elementHost_0 = new ElementHost();
            this.tabPage_3 = new TabPage();
            this.tableLayoutPanel_4 = new TableLayoutPanel();
            this.label_32 = new Label();
            this.textBox_15 = new TextBox();
            this.label_31 = new Label();
            this.label_25 = new Label();
            this.textBox_18 = new TextBox();
            this.elementHost_3 = new ElementHost();
            this.label_26 = new Label();
            this.label_30 = new Label();
            this.elementHost_2 = new ElementHost();
            this.label_27 = new Label();
            this.textBox_17 = new TextBox();
            this.label_28 = new Label();
            this.label_29 = new Label();
            this.elementHost_4 = new ElementHost();
            this.textBox_16 = new TextBox();
            this.tabPage_2 = new TabPage();
            this.tableLayoutPanel_7 = new TableLayoutPanel();
            this.pictureBox_0 = new PictureBox();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_1 = new DataGridViewImageColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.tabPage_4 = new TabPage();
            this.tableLayoutPanel_1 = new TableLayoutPanel();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.button_2 = new Button();
            this.button_3 = new Button();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.contextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripMenuItem_5 = new ToolStripMenuItem();
            this.toolStripMenuItem_6 = new ToolStripMenuItem();
            this.toolStripMenuItem_7 = new ToolStripMenuItem();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripMenuItem_8 = new ToolStripMenuItem();
            this.toolStripMenuItem_9 = new ToolStripMenuItem();
            this.dataGridViewImageColumn_2 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_3 = new DataGridViewImageColumn();
            this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumnNotNull_1 = new DataGridViewImageColumnNotNull();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.dataSetGES_1 = new DataSetGES();
            this.tableLayoutPanel_0.SuspendLayout();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.tableLayoutPanel_5.SuspendLayout();
            this.tabPage_6.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_1).BeginInit();
            this.panel_1.SuspendLayout();
            this.toolStrip_2.SuspendLayout();
            this.tabPage_5.SuspendLayout();
            this.tableLayoutPanel_2.SuspendLayout();
            this.panel_0.SuspendLayout();
            this.tableLayoutPanel_6.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            this.dataSetGES_0.BeginInit();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.tabPage_1.SuspendLayout();
            this.tableLayoutPanel_3.SuspendLayout();
            this.tabPage_3.SuspendLayout();
            this.tableLayoutPanel_4.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.tableLayoutPanel_7.SuspendLayout();
            ((ISupportInitialize) this.pictureBox_0).BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            this.tabPage_4.SuspendLayout();
            this.tableLayoutPanel_1.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.dataGridViewExcelFilter_1.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            this.contextMenuStrip_0.SuspendLayout();
            this.contextMenuStrip_1.SuspendLayout();
            this.dataSetTechConnection_0.BeginInit();
            this.dataSetGES_1.BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel_0.ColumnCount = 2;
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122f));
            this.tableLayoutPanel_0.Controls.Add(this.tabControl_0, 0, 0);
            this.tableLayoutPanel_0.Controls.Add(this.button_2, 1, 1);
            this.tableLayoutPanel_0.Controls.Add(this.button_3, 0, 1);
            this.tableLayoutPanel_0.Dock = DockStyle.Fill;
            this.tableLayoutPanel_0.Location = new Point(0, 0);
            this.tableLayoutPanel_0.Margin = new Padding(3, 3, 10, 3);
            this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
            this.tableLayoutPanel_0.RowCount = 2;
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 45f));
            this.tableLayoutPanel_0.Size = new Size(0x2f5, 0x2d8);
            this.tableLayoutPanel_0.TabIndex = 0;
            this.tableLayoutPanel_0.SetColumnSpan(this.tabControl_0, 2);
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_6);
            this.tabControl_0.Controls.Add(this.tabPage_5);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_3);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Controls.Add(this.tabPage_4);
            this.tabControl_0.Dock = DockStyle.Fill;
            this.tabControl_0.Location = new Point(3, 3);
            this.tabControl_0.Name = "tpMain";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x2ef, 0x2a5);
            this.tabControl_0.TabIndex = 0;
            this.tabControl_0.SelectedIndexChanged += new EventHandler(this.tabControl_0_SelectedIndexChanged);
            this.tabPage_0.Controls.Add(this.tableLayoutPanel_5);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tpPrimerAkt";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x2e7, 0x28b);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Параметры акта";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.tableLayoutPanel_5.ColumnCount = 9;
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11f));
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63f));
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152f));
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86f));
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155f));
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124f));
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80f));
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31f));
            this.tableLayoutPanel_5.Controls.Add(this.label_12, 1, 0);
            this.tableLayoutPanel_5.Controls.Add(this.label_2, 1, 0x11);
            this.tableLayoutPanel_5.Controls.Add(this.label_1, 1, 0x13);
            this.tableLayoutPanel_5.Controls.Add(this.dateTimePicker_0, 2, 0);
            this.tableLayoutPanel_5.Controls.Add(this.label_11, 3, 0);
            this.tableLayoutPanel_5.Controls.Add(this.button_0, 8, 15);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_1, 1, 20);
            this.tableLayoutPanel_5.Controls.Add(this.elementHost_6, 1, 10);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_2, 1, 0x12);
            this.tableLayoutPanel_5.Controls.Add(this.button_1, 8, 12);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_3, 1, 15);
            this.tableLayoutPanel_5.Controls.Add(this.comboBox_0, 4, 0);
            this.tableLayoutPanel_5.Controls.Add(this.elementHost_7, 1, 8);
            this.tableLayoutPanel_5.Controls.Add(this.label_10, 5, 0);
            this.tableLayoutPanel_5.Controls.Add(this.elementHost_5, 1, 6);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_7, 6, 0);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_4, 1, 12);
            this.tableLayoutPanel_5.Controls.Add(this.label_9, 1, 3);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_6, 1, 4);
            this.tableLayoutPanel_5.Controls.Add(this.label_3, 1, 14);
            this.tableLayoutPanel_5.Controls.Add(this.label_8, 4, 3);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_5, 4, 4);
            this.tableLayoutPanel_5.Controls.Add(this.label_7, 1, 5);
            this.tableLayoutPanel_5.Controls.Add(this.label_4, 1, 11);
            this.tableLayoutPanel_5.Controls.Add(this.label_6, 1, 7);
            this.tableLayoutPanel_5.Controls.Add(this.label_5, 1, 9);
            this.tableLayoutPanel_5.Controls.Add(this.label_0, 1, 0x15);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_0, 3, 0x15);
            this.tableLayoutPanel_5.Controls.Add(this.label_38, 1, 0x16);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_21, 3, 0x16);
            this.tableLayoutPanel_5.Controls.Add(this.label_39, 1, 1);
            this.tableLayoutPanel_5.Controls.Add(this.textBox_22, 1, 2);
            this.tableLayoutPanel_5.Controls.Add(this.label_40, 4, 1);
            this.tableLayoutPanel_5.Controls.Add(this.comboBoxReadOnly_0, 4, 2);
            this.tableLayoutPanel_5.Controls.Add(this.button_4, 8, 2);
            this.tableLayoutPanel_5.Dock = DockStyle.Fill;
            this.tableLayoutPanel_5.Location = new Point(3, 3);
            this.tableLayoutPanel_5.Name = "tableLayoutPanel7";
            this.tableLayoutPanel_5.RowCount = 0x17;
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 19f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 19f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 53f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 21f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 60f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 21f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 63f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 21f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 8f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 19f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 16f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 21f));
            this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 8f));
            this.tableLayoutPanel_5.Size = new Size(0x2e1, 0x285);
            this.tableLayoutPanel_5.TabIndex = 40;
            this.label_12.AutoSize = true;
            this.label_12.Dock = DockStyle.Fill;
            this.label_12.Location = new Point(14, 0);
            this.label_12.Name = "lbData";
            this.label_12.Size = new Size(0x39, 0x1a);
            this.label_12.TabIndex = 3;
            this.label_12.Text = "Дата";
            this.label_12.TextAlign = ContentAlignment.MiddleRight;
            this.label_2.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_2, 8);
            this.label_2.Dock = DockStyle.Fill;
            this.label_2.Location = new Point(14, 0x1ec);
            this.label_2.Name = "lbOtvetst";
            this.label_2.Size = new Size(720, 0x10);
            this.label_2.TabIndex = 20;
            this.label_2.Text = "Ответственность за состояние и обслуживание контактных соединений:";
            this.label_2.TextAlign = ContentAlignment.BottomLeft;
            this.label_1.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_1, 8);
            this.label_1.Dock = DockStyle.Fill;
            this.label_1.Location = new Point(14, 0x216);
            this.label_1.Name = "lbPotrOb";
            this.label_1.Size = new Size(720, 20);
            this.label_1.TabIndex = 0x16;
            this.label_1.Text = "Потребитель допущен к оперативным действиям со следующим оборудованием:";
            this.label_1.TextAlign = ContentAlignment.BottomLeft;
            this.dateTimePicker_0.Dock = DockStyle.Fill;
            this.dateTimePicker_0.Location = new Point(0x4d, 3);
            this.dateTimePicker_0.Name = "dtpActDate";
            this.dateTimePicker_0.Size = new Size(0x92, 20);
            this.dateTimePicker_0.TabIndex = 8;
            this.label_11.AutoSize = true;
            this.label_11.Dock = DockStyle.Fill;
            this.label_11.Location = new Point(0xe5, 0);
            this.label_11.Name = "lbRaion";
            this.label_11.Size = new Size(80, 0x1a);
            this.label_11.TabIndex = 4;
            this.label_11.Text = "Район";
            this.label_11.TextAlign = ContentAlignment.MiddleRight;
            this.button_0.Location = new Point(0x2c5, 0x1b4);
            this.button_0.Name = "btnPotrExpl";
            this.button_0.Size = new Size(0x18, 0x16);
            this.button_0.TabIndex = 0x1b;
            this.button_0.Text = ",,,";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_1, 8);
            this.textBox_1.Dock = DockStyle.Fill;
            this.textBox_1.Location = new Point(14, 0x22d);
            this.textBox_1.Name = "tbAdmission";
            this.textBox_1.Size = new Size(720, 20);
            this.textBox_1.TabIndex = 0x17;
            this.textBox_1.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.tableLayoutPanel_5.SetColumnSpan(this.elementHost_6, 8);
            this.elementHost_6.Dock = DockStyle.Fill;
            this.elementHost_6.Location = new Point(14, 0x129);
            this.elementHost_6.Name = "hostBorderBalance";
            this.elementHost_6.Size = new Size(720, 0x39);
            this.elementHost_6.TabIndex = 0x25;
            this.elementHost_6.Text = "elementHost3";
            this.elementHost_6.Child = null;
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_2, 8);
            this.textBox_2.Dock = DockStyle.Fill;
            this.textBox_2.Location = new Point(14, 0x1ff);
            this.textBox_2.Name = "tbResponsibility";
            this.textBox_2.Size = new Size(720, 20);
            this.textBox_2.TabIndex = 0x15;
            this.textBox_2.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.button_1.Location = new Point(0x2c5, 0x17d);
            this.button_1.Name = "btnOrgExpl";
            this.button_1.Size = new Size(0x18, 0x16);
            this.button_1.TabIndex = 0x1a;
            this.button_1.Text = ",,,";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_3, 7);
            this.textBox_3.Dock = DockStyle.Fill;
            this.textBox_3.ForeColor = SystemColors.ControlText;
            this.textBox_3.Location = new Point(14, 0x1b4);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "tbPotrExpl";
            this.tableLayoutPanel_5.SetRowSpan(this.textBox_3, 2);
            this.textBox_3.Size = new Size(0x2b1, 0x35);
            this.textBox_3.TabIndex = 0x13;
            this.textBox_3.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.comboBox_0.Dock = DockStyle.Fill;
            this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x13b, 3);
            this.comboBox_0.Name = "cbRegion";
            this.comboBox_0.Size = new Size(0x95, 0x15);
            this.comboBox_0.TabIndex = 6;
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.tableLayoutPanel_5.SetColumnSpan(this.elementHost_7, 8);
            this.elementHost_7.Dock = DockStyle.Fill;
            this.elementHost_7.Location = new Point(14, 0xd8);
            this.elementHost_7.Name = "hostPotrBalance";
            this.elementHost_7.Size = new Size(720, 0x36);
            this.elementHost_7.TabIndex = 0x24;
            this.elementHost_7.Text = "elementHost2";
            this.elementHost_7.Child = null;
            this.label_10.AutoSize = true;
            this.label_10.Dock = DockStyle.Fill;
            this.label_10.Location = new Point(470, 0);
            this.label_10.Name = "lbMumber";
            this.label_10.Size = new Size(0x76, 0x1a);
            this.label_10.TabIndex = 5;
            this.label_10.Text = "Порядковый номер";
            this.label_10.TextAlign = ContentAlignment.MiddleRight;
            this.tableLayoutPanel_5.SetColumnSpan(this.elementHost_5, 8);
            this.elementHost_5.Dock = DockStyle.Fill;
            this.elementHost_5.Location = new Point(14, 0x8e);
            this.elementHost_5.Name = "hostOrgBalance";
            this.elementHost_5.Size = new Size(720, 0x2f);
            this.elementHost_5.TabIndex = 0x23;
            this.elementHost_5.Text = "elementHost1";
            this.elementHost_5.Child = null;
            this.textBox_7.Dock = DockStyle.Fill;
            this.textBox_7.Location = new Point(0x252, 3);
            this.textBox_7.Name = "tbActNumber";
            this.textBox_7.Size = new Size(0x4a, 20);
            this.textBox_7.TabIndex = 7;
            this.textBox_7.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_4, 7);
            this.textBox_4.Dock = DockStyle.Fill;
            this.textBox_4.ForeColor = SystemColors.ControlText;
            this.textBox_4.Location = new Point(14, 0x17d);
            this.textBox_4.Multiline = true;
            this.textBox_4.Name = "tbOrgExpl";
            this.tableLayoutPanel_5.SetRowSpan(this.textBox_4, 2);
            this.textBox_4.Size = new Size(0x2b1, 30);
            this.textBox_4.TabIndex = 0x11;
            this.textBox_4.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_9.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_9, 3);
            this.label_9.Dock = DockStyle.Fill;
            this.label_9.Location = new Point(14, 0x4c);
            this.label_9.Name = "lbAbn";
            this.label_9.Size = new Size(0x127, 0x13);
            this.label_9.TabIndex = 10;
            this.label_9.Text = "Абонент в лице:";
            this.label_9.TextAlign = ContentAlignment.MiddleLeft;
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_6, 3);
            this.textBox_6.Dock = DockStyle.Fill;
            this.textBox_6.Location = new Point(14, 0x62);
            this.textBox_6.Name = "tbOrgFace";
            this.textBox_6.Size = new Size(0x127, 20);
            this.textBox_6.TabIndex = 9;
            this.textBox_6.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_3.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_3, 8);
            this.label_3.Dock = DockStyle.Fill;
            this.label_3.Location = new Point(14, 0x19e);
            this.label_3.Name = "lbPotrExpl";
            this.label_3.Size = new Size(720, 0x13);
            this.label_3.TabIndex = 0x12;
            this.label_3.Text = "В эксплуатации Потребителя находится:";
            this.label_3.TextAlign = ContentAlignment.BottomLeft;
            this.label_8.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_8, 5);
            this.label_8.Dock = DockStyle.Fill;
            this.label_8.Location = new Point(0x13b, 0x4c);
            this.label_8.Name = "lbOsn";
            this.label_8.Size = new Size(0x1a3, 0x13);
            this.label_8.TabIndex = 11;
            this.label_8.Text = "Действующий на основании:";
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_5, 5);
            this.textBox_5.Dock = DockStyle.Fill;
            this.textBox_5.Location = new Point(0x13b, 0x62);
            this.textBox_5.Name = "tbOrgBase";
            this.textBox_5.Size = new Size(0x1a3, 20);
            this.textBox_5.TabIndex = 12;
            this.textBox_5.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_7.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_7, 8);
            this.label_7.Dock = DockStyle.Fill;
            this.label_7.Location = new Point(14, 120);
            this.label_7.Name = "lbOrganiz";
            this.label_7.Size = new Size(720, 0x13);
            this.label_7.TabIndex = 13;
            this.label_7.Text = "На балансе Сетевой организации находится:";
            this.label_7.TextAlign = ContentAlignment.BottomLeft;
            this.label_4.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_4, 8);
            this.label_4.Dock = DockStyle.Fill;
            this.label_4.Location = new Point(14, 0x165);
            this.label_4.Name = "lbOrgExpl";
            this.label_4.Size = new Size(720, 0x15);
            this.label_4.TabIndex = 0x10;
            this.label_4.Text = "В эксплуатации Сетевой организации находится:";
            this.label_4.TextAlign = ContentAlignment.BottomLeft;
            this.label_6.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_6, 8);
            this.label_6.Dock = DockStyle.Fill;
            this.label_6.Location = new Point(14, 0xc0);
            this.label_6.Name = "lbPotreb";
            this.label_6.Size = new Size(720, 0x15);
            this.label_6.TabIndex = 14;
            this.label_6.Text = "На балансе Потребителя находится:";
            this.label_6.TextAlign = ContentAlignment.BottomLeft;
            this.label_5.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_5, 8);
            this.label_5.Dock = DockStyle.Fill;
            this.label_5.Location = new Point(14, 0x111);
            this.label_5.Name = "lbBorder";
            this.label_5.Size = new Size(720, 0x15);
            this.label_5.TabIndex = 15;
            this.label_5.Text = "Границей балансовой принадлежности является:";
            this.label_5.TextAlign = ContentAlignment.BottomLeft;
            this.label_0.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_0, 2);
            this.label_0.Dock = DockStyle.Fill;
            this.label_0.Location = new Point(14, 580);
            this.label_0.Name = "lbPodpis";
            this.label_0.Size = new Size(0xd1, 0x15);
            this.label_0.TabIndex = 0x18;
            this.label_0.Text = "Потребитель(для подписи):";
            this.label_0.TextAlign = ContentAlignment.MiddleRight;
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_0, 6);
            this.textBox_0.Dock = DockStyle.Fill;
            this.textBox_0.Location = new Point(0xe5, 0x247);
            this.textBox_0.Name = "tbPotrSignature";
            this.textBox_0.Size = new Size(0x1f9, 20);
            this.textBox_0.TabIndex = 0x19;
            this.textBox_0.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_38.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_38, 2);
            this.label_38.Dock = DockStyle.Fill;
            this.label_38.Location = new Point(14, 0x259);
            this.label_38.Name = "label17";
            this.label_38.Size = new Size(0xd1, 0x2c);
            this.label_38.TabIndex = 0x26;
            this.label_38.Text = "Прочее";
            this.label_38.TextAlign = ContentAlignment.MiddleRight;
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_21, 6);
            this.textBox_21.Dock = DockStyle.Fill;
            this.textBox_21.ForeColor = SystemColors.ControlText;
            this.textBox_21.Location = new Point(0xe5, 0x25c);
            this.textBox_21.Multiline = true;
            this.textBox_21.Name = "tbOther";
            this.textBox_21.Size = new Size(0x1f9, 0x26);
            this.textBox_21.TabIndex = 0x27;
            this.label_39.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_39, 3);
            this.label_39.Dock = DockStyle.Fill;
            this.label_39.Location = new Point(14, 0x1a);
            this.label_39.Name = "label2";
            this.label_39.Size = new Size(0x127, 0x19);
            this.label_39.TabIndex = 40;
            this.label_39.Text = "Абонент";
            this.label_39.TextAlign = ContentAlignment.MiddleLeft;
            this.textBox_22.BackColor = SystemColors.Window;
            this.tableLayoutPanel_5.SetColumnSpan(this.textBox_22, 3);
            this.textBox_22.Dock = DockStyle.Fill;
            this.textBox_22.Location = new Point(14, 0x36);
            this.textBox_22.Name = "txtAbn";
            this.textBox_22.ReadOnly = true;
            this.textBox_22.Size = new Size(0x127, 20);
            this.textBox_22.TabIndex = 0x29;
            this.label_40.AutoSize = true;
            this.tableLayoutPanel_5.SetColumnSpan(this.label_40, 3);
            this.label_40.Dock = DockStyle.Fill;
            this.label_40.Location = new Point(0x13b, 0x1a);
            this.label_40.Name = "label7";
            this.label_40.Size = new Size(0x161, 0x19);
            this.label_40.TabIndex = 0x2a;
            this.label_40.Text = "Объект";
            this.label_40.TextAlign = ContentAlignment.MiddleLeft;
            this.tableLayoutPanel_5.SetColumnSpan(this.comboBoxReadOnly_0, 4);
            this.comboBoxReadOnly_0.Dock = DockStyle.Fill;
            this.comboBoxReadOnly_0.FormattingEnabled = true;
            this.comboBoxReadOnly_0.Location = new Point(0x13b, 0x36);
            this.comboBoxReadOnly_0.Name = "cmbAbnObj";
            this.comboBoxReadOnly_0.set_ReadOnlyBackColor(SystemColors.Control);
            this.comboBoxReadOnly_0.set_ReadOnlyForeColor(SystemColors.WindowText);
            this.comboBoxReadOnly_0.Size = new Size(0x184, 0x15);
            this.comboBoxReadOnly_0.TabIndex = 0x2b;
            this.comboBoxReadOnly_0.SelectedValueChanged += new EventHandler(this.comboBoxReadOnly_0_SelectedValueChanged);
            this.button_4.Dock = DockStyle.Fill;
            this.button_4.Location = new Point(0x2c5, 0x36);
            this.button_4.Name = "btnChangeAbn";
            this.button_4.Size = new Size(0x19, 0x13);
            this.button_4.TabIndex = 0x2c;
            this.button_4.Text = ",,,";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new EventHandler(this.button_4_Click);
            this.tabPage_6.Controls.Add(this.dataGridView_1);
            this.tabPage_6.Controls.Add(this.panel_1);
            this.tabPage_6.Controls.Add(this.toolStrip_2);
            this.tabPage_6.Location = new Point(4, 0x16);
            this.tabPage_6.Name = "tabPagePointAttach";
            this.tabPage_6.Padding = new Padding(3);
            this.tabPage_6.Size = new Size(0x2e7, 0x28b);
            this.tabPage_6.TabIndex = 6;
            this.tabPage_6.Text = "Точки присоединения";
            this.tabPage_6.UseVisualStyleBackColor = true;
            this.dataGridView_1.AllowUserToAddRows = false;
            this.dataGridView_1.AllowUserToDeleteRows = false;
            this.dataGridView_1.AllowUserToResizeColumns = false;
            this.dataGridView_1.AllowUserToResizeRows = false;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView_1.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_60, this.dataGridViewTextBoxColumn_61, this.dataGridViewTextBoxColumn_62, this.dataGridViewTextBoxColumn_63, this.dataGridViewTextBoxColumn_64, this.dataGridViewTextBoxColumn_65, this.dataGridViewTextBoxColumn_66, this.dataGridViewTextBoxColumn_67, this.dataGridViewTextBoxColumn_68, this.dataGridViewTextBoxColumn_69, this.dataGridViewTextBoxColumn_70, this.dataGridViewTextBoxColumn_71, this.dataGridViewTextBoxColumn_72, this.dataGridViewTextBoxColumn_73, this.dataGridViewTextBoxColumn_74, this.dataGridViewTextBoxColumn_75,
                this.dataGridViewTextBoxColumn_76
            };
            this.dataGridView_1.Columns.AddRange(dataGridViewColumns);
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridView_1.DefaultCellStyle = style2;
            this.dataGridView_1.Dock = DockStyle.Fill;
            this.dataGridView_1.Location = new Point(3, 0x57);
            this.dataGridView_1.MultiSelect = false;
            this.dataGridView_1.Name = "dgvPointAttach";
            this.dataGridView_1.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridView_1.RowHeadersDefaultCellStyle = style3;
            this.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_1.Size = new Size(0x2e1, 0x231);
            this.dataGridView_1.TabIndex = 20;
            this.dataGridView_1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_1_CellDoubleClick);
            this.dataGridViewTextBoxColumn_60.HeaderText = "id";
            this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn_60.ReadOnly = true;
            this.dataGridViewTextBoxColumn_60.Visible = false;
            this.dataGridViewTextBoxColumn_61.HeaderText = "num";
            this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn_61.ReadOnly = true;
            this.dataGridViewTextBoxColumn_61.Visible = false;
            this.dataGridViewTextBoxColumn_62.HeaderText = "idSubPoint";
            this.dataGridViewTextBoxColumn_62.Name = "idSubPointColumn";
            this.dataGridViewTextBoxColumn_62.ReadOnly = true;
            this.dataGridViewTextBoxColumn_62.Visible = false;
            this.dataGridViewTextBoxColumn_63.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_63.HeaderText = "ТП/РП";
            this.dataGridViewTextBoxColumn_63.Name = "subPointDgvColumn";
            this.dataGridViewTextBoxColumn_63.ReadOnly = true;
            this.dataGridViewTextBoxColumn_63.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_64.HeaderText = "idBusPoint";
            this.dataGridViewTextBoxColumn_64.Name = "idBusPointColumn";
            this.dataGridViewTextBoxColumn_64.ReadOnly = true;
            this.dataGridViewTextBoxColumn_64.Visible = false;
            this.dataGridViewTextBoxColumn_65.HeaderText = "Шина";
            this.dataGridViewTextBoxColumn_65.Name = "busPointDgvColumn";
            this.dataGridViewTextBoxColumn_65.ReadOnly = true;
            this.dataGridViewTextBoxColumn_65.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_65.Width = 50;
            this.dataGridViewTextBoxColumn_66.HeaderText = "idCellPoint";
            this.dataGridViewTextBoxColumn_66.Name = "idCellPointColumn";
            this.dataGridViewTextBoxColumn_66.ReadOnly = true;
            this.dataGridViewTextBoxColumn_66.Visible = false;
            this.dataGridViewTextBoxColumn_67.HeaderText = "Ячейка";
            this.dataGridViewTextBoxColumn_67.Name = "cellPoinDgvColumn";
            this.dataGridViewTextBoxColumn_67.ReadOnly = true;
            this.dataGridViewTextBoxColumn_67.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_67.Width = 50;
            this.dataGridViewTextBoxColumn_68.HeaderText = "idSubCP";
            this.dataGridViewTextBoxColumn_68.Name = "idSubCPColumn";
            this.dataGridViewTextBoxColumn_68.ReadOnly = true;
            this.dataGridViewTextBoxColumn_68.Visible = false;
            this.dataGridViewTextBoxColumn_69.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_69.HeaderText = "ЦП";
            this.dataGridViewTextBoxColumn_69.Name = "subCPDgvColumn";
            this.dataGridViewTextBoxColumn_69.ReadOnly = true;
            this.dataGridViewTextBoxColumn_69.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_70.HeaderText = "idBusCP";
            this.dataGridViewTextBoxColumn_70.Name = "idBusCPColumn";
            this.dataGridViewTextBoxColumn_70.ReadOnly = true;
            this.dataGridViewTextBoxColumn_70.Visible = false;
            this.dataGridViewTextBoxColumn_71.HeaderText = "Шина";
            this.dataGridViewTextBoxColumn_71.Name = "busCPDgvColumn";
            this.dataGridViewTextBoxColumn_71.ReadOnly = true;
            this.dataGridViewTextBoxColumn_71.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_71.Width = 50;
            this.dataGridViewTextBoxColumn_72.HeaderText = "idCellCP";
            this.dataGridViewTextBoxColumn_72.Name = "idCellCPColumn";
            this.dataGridViewTextBoxColumn_72.ReadOnly = true;
            this.dataGridViewTextBoxColumn_72.Visible = false;
            this.dataGridViewTextBoxColumn_73.HeaderText = "Ячейка";
            this.dataGridViewTextBoxColumn_73.Name = "cellCPDgvColumn";
            this.dataGridViewTextBoxColumn_73.ReadOnly = true;
            this.dataGridViewTextBoxColumn_73.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_73.Width = 50;
            this.dataGridViewTextBoxColumn_74.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_74.Name = "voltageLevelDgvColumn";
            this.dataGridViewTextBoxColumn_74.ReadOnly = true;
            this.dataGridViewTextBoxColumn_74.Visible = false;
            this.dataGridViewTextBoxColumn_75.HeaderText = "Напр-ние";
            this.dataGridViewTextBoxColumn_75.Name = "voltageLevelNameDgvColumn";
            this.dataGridViewTextBoxColumn_75.ReadOnly = true;
            this.dataGridViewTextBoxColumn_76.HeaderText = "Мощ-сть";
            this.dataGridViewTextBoxColumn_76.Name = "powerSumDgvColumn";
            this.dataGridViewTextBoxColumn_76.ReadOnly = true;
            this.panel_1.Controls.Add(this.textBox_24);
            this.panel_1.Controls.Add(this.label_41);
            this.panel_1.Controls.Add(this.label_42);
            this.panel_1.Controls.Add(this.dateTimePicker_1);
            this.panel_1.Controls.Add(this.textBox_23);
            this.panel_1.Controls.Add(this.label_43);
            this.panel_1.Dock = DockStyle.Top;
            this.panel_1.Location = new Point(3, 0x1c);
            this.panel_1.Name = "panelActRebinding";
            this.panel_1.Size = new Size(0x2e1, 0x3b);
            this.panel_1.TabIndex = 0x15;
            this.panel_1.Visible = false;
            this.textBox_24.BackColor = SystemColors.Window;
            this.textBox_24.Location = new Point(0x128, 0x1b);
            this.textBox_24.Name = "txtTypeDocRebindning";
            this.textBox_24.ReadOnly = true;
            this.textBox_24.Size = new Size(0xbf, 20);
            this.textBox_24.TabIndex = 6;
            this.label_41.AutoSize = true;
            this.label_41.Location = new Point(0x130, 11);
            this.label_41.Name = "label20";
            this.label_41.Size = new Size(0x53, 13);
            this.label_41.TabIndex = 5;
            this.label_41.Text = "Тип документа";
            this.label_42.AutoSize = true;
            this.label_42.Location = new Point(0x8f, 11);
            this.label_42.Name = "label19";
            this.label_42.Size = new Size(0x21, 13);
            this.label_42.TabIndex = 3;
            this.label_42.Text = "Дата";
            this.dateTimePicker_1.Enabled = false;
            this.dateTimePicker_1.Location = new Point(0x84, 0x1b);
            this.dateTimePicker_1.Name = "dtpDateDocRebindning";
            this.dateTimePicker_1.Size = new Size(0x91, 20);
            this.dateTimePicker_1.TabIndex = 2;
            this.textBox_23.BackColor = SystemColors.Window;
            this.textBox_23.Location = new Point(0x11, 0x1b);
            this.textBox_23.Name = "txtNumDocRebindning";
            this.textBox_23.ReadOnly = true;
            this.textBox_23.Size = new Size(100, 20);
            this.textBox_23.TabIndex = 1;
            this.label_43.AutoSize = true;
            this.label_43.Location = new Point(0x18, 11);
            this.label_43.Name = "label18";
            this.label_43.Size = new Size(0x48, 13);
            this.label_43.TabIndex = 0;
            this.label_43.Text = "Документ №";
            this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_9, this.toolStripButton_10, this.toolStripButton_11, this.toolStripSeparator_4, this.toolStripButton_12, this.toolStripButton_13 };
            this.toolStrip_2.Items.AddRange(toolStripItems);
            this.toolStrip_2.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip_2.Location = new Point(3, 3);
            this.toolStrip_2.Name = "toolStripDGVPointAttach";
            this.toolStrip_2.Size = new Size(0x2e1, 0x19);
            this.toolStrip_2.TabIndex = 0x13;
            this.toolStrip_2.Text = "toolStrip1";
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = (Image) manager.GetObject("toolBtnAddLink.Image");
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnAddLink";
            this.toolStripButton_9.Size = new Size(0x17, 0x16);
            this.toolStripButton_9.Text = "Добавить";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = (Image) manager.GetObject("toolBtnEditLink.Image");
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnEditLink";
            this.toolStripButton_10.Size = new Size(0x17, 0x16);
            this.toolStripButton_10.Text = "Редактировать";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = (Image) manager.GetObject("toolBtnDelLink.Image");
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnDelLink";
            this.toolStripButton_11.Size = new Size(0x17, 0x16);
            this.toolStripButton_11.Text = "Удалить";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
            this.toolStripSeparator_4.Name = "toolStripSeparator1";
            this.toolStripSeparator_4.Size = new Size(6, 0x19);
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = (Image) manager.GetObject("toolBtnUpLink.Image");
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnUpLink";
            this.toolStripButton_12.Size = new Size(0x17, 0x16);
            this.toolStripButton_12.Text = "Вверх";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_13.Image = (Image) manager.GetObject("toolBtnDownLink.Image");
            this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_13.Name = "toolBtnDownLink";
            this.toolStripButton_13.Size = new Size(0x17, 0x16);
            this.toolStripButton_13.Text = "Вниз";
            this.toolStripButton_13.Click += new EventHandler(this.toolStripButton_13_Click);
            this.tabPage_5.Controls.Add(this.tableLayoutPanel_2);
            this.tabPage_5.Location = new Point(4, 0x16);
            this.tabPage_5.Name = "tpActTehConnection";
            this.tabPage_5.Padding = new Padding(3);
            this.tabPage_5.Size = new Size(0x2e7, 0x28b);
            this.tabPage_5.TabIndex = 5;
            this.tabPage_5.Text = "Акт о тех. присоединении";
            this.tabPage_5.UseVisualStyleBackColor = true;
            this.tableLayoutPanel_2.ColumnCount = 1;
            this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_2.Controls.Add(this.panel_0, 0, 0);
            this.tableLayoutPanel_2.Dock = DockStyle.Fill;
            this.tableLayoutPanel_2.Location = new Point(3, 3);
            this.tableLayoutPanel_2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel_2.RowCount = 1;
            this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 727f));
            this.tableLayoutPanel_2.Size = new Size(0x2e1, 0x285);
            this.tableLayoutPanel_2.TabIndex = 0;
            this.panel_0.Controls.Add(this.tableLayoutPanel_6);
            this.panel_0.Dock = DockStyle.Fill;
            this.panel_0.Location = new Point(3, 3);
            this.panel_0.Name = "pnlActTehConnection";
            this.panel_0.Size = new Size(0x2db, 0x2d1);
            this.panel_0.TabIndex = 0;
            this.tableLayoutPanel_6.ColumnCount = 5;
            this.tableLayoutPanel_6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel_6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 291f));
            this.tableLayoutPanel_6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151f));
            this.tableLayoutPanel_6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133f));
            this.tableLayoutPanel_6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_6.Controls.Add(this.textBox_20, 3, 3);
            this.tableLayoutPanel_6.Controls.Add(this.dataGridView_0, 0, 6);
            this.tableLayoutPanel_6.Controls.Add(this.label_36, 2, 3);
            this.tableLayoutPanel_6.Controls.Add(this.label_35, 1, 4);
            this.tableLayoutPanel_6.Controls.Add(this.label_34, 4, 4);
            this.tableLayoutPanel_6.Controls.Add(this.label_33, 4, 3);
            this.tableLayoutPanel_6.Controls.Add(this.textBox_19, 3, 4);
            this.tableLayoutPanel_6.Controls.Add(this.comboBox_1, 3, 1);
            this.tableLayoutPanel_6.Controls.Add(this.label_37, 1, 1);
            this.tableLayoutPanel_6.Dock = DockStyle.Fill;
            this.tableLayoutPanel_6.Location = new Point(0, 0);
            this.tableLayoutPanel_6.Name = "tableLayoutPanel5";
            this.tableLayoutPanel_6.RowCount = 7;
            this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Absolute, 11f));
            this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_6.Size = new Size(0x2db, 0x2d1);
            this.tableLayoutPanel_6.TabIndex = 9;
            this.textBox_20.DataBindings.Add(new Binding("Text", this.bindingSource_3, "PowerSum", true));
            this.textBox_20.Dock = DockStyle.Fill;
            this.textBox_20.Location = new Point(0x1d1, 0x45);
            this.textBox_20.Name = "tbPowerMax";
            this.textBox_20.ReadOnly = true;
            this.textBox_20.Size = new Size(0x7f, 20);
            this.textBox_20.TabIndex = 1;
            this.bindingSource_3.DataMember = "tTC_ActTC";
            this.bindingSource_3.DataSource = this.dataSetGES_0;
            this.dataSetGES_0.DataSetName = "dsAbnObjAkt";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            style4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.Highlight;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dataGridView_0.ColumnHeadersDefaultCellStyle = style4;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36, this.dataGridViewTextBoxColumn_37, this.dataGridViewTextBoxColumn_38, this.dataGridViewTextBoxColumn_39, this.dataGridViewTextBoxColumn_40, this.dataGridViewTextBoxColumn_41, this.dataGridViewTextBoxColumn_42, this.dataGridViewTextBoxColumn_43, this.dataGridViewTextBoxColumn_44, this.dataGridViewTextBoxColumn_45, this.dataGridViewTextBoxColumn_46, this.dataGridViewTextBoxColumn_47, this.dataGridViewTextBoxColumn_48, this.dataGridViewTextBoxColumn_49, this.dataGridViewTextBoxColumn_50,
                this.dataGridViewTextBoxColumn_51, this.dataGridViewTextBoxColumn_52, this.dataGridViewTextBoxColumn_53, this.dataGridViewTextBoxColumn_54, this.dataGridViewTextBoxColumn_55, this.dataGridViewTextBoxColumn_56, this.dataGridViewTextBoxColumn_57, this.dataGridViewTextBoxColumn_58, this.dataGridViewTextBoxColumn_59
            };
            this.dataGridView_0.Columns.AddRange(columnArray2);
            this.tableLayoutPanel_6.SetColumnSpan(this.dataGridView_0, 5);
            this.dataGridView_0.DataSource = this.bindingSource_1;
            style5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style5.BackColor = SystemColors.Window;
            style5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style5.ForeColor = SystemColors.ControlText;
            style5.SelectionBackColor = SystemColors.Highlight;
            style5.SelectionForeColor = SystemColors.HighlightText;
            style5.WrapMode = DataGridViewTriState.False;
            this.dataGridView_0.DefaultCellStyle = style5;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.Location = new Point(3, 130);
            this.dataGridView_0.Name = "dgvPointAttachTC";
            style6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style6.BackColor = SystemColors.Control;
            style6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style6.ForeColor = SystemColors.WindowText;
            style6.SelectionBackColor = SystemColors.Highlight;
            style6.SelectionForeColor = SystemColors.HighlightText;
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridView_0.RowHeadersDefaultCellStyle = style6;
            this.dataGridView_0.RowHeadersVisible = false;
            this.dataGridView_0.Size = new Size(0x2d5, 0x24c);
            this.dataGridView_0.TabIndex = 3;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_35.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_35.Name = "idTUDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_35.Visible = false;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_36.HeaderText = "id";
            this.dataGridViewTextBoxColumn_36.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_36.Visible = false;
            this.dataGridViewTextBoxColumn_37.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_37.HeaderText = "num";
            this.dataGridViewTextBoxColumn_37.Name = "numDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_37.Visible = false;
            this.dataGridViewTextBoxColumn_38.DataPropertyName = "idSubPoint";
            this.dataGridViewTextBoxColumn_38.HeaderText = "idSubPoint";
            this.dataGridViewTextBoxColumn_38.Name = "idSubPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_38.Visible = false;
            this.dataGridViewTextBoxColumn_39.DataPropertyName = "SubPoint";
            this.dataGridViewTextBoxColumn_39.HeaderText = "SubPoint";
            this.dataGridViewTextBoxColumn_39.Name = "subPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_39.ReadOnly = true;
            this.dataGridViewTextBoxColumn_39.Visible = false;
            this.dataGridViewTextBoxColumn_40.DataPropertyName = "idBusPoint";
            this.dataGridViewTextBoxColumn_40.HeaderText = "idBusPoint";
            this.dataGridViewTextBoxColumn_40.Name = "idBusPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_40.Visible = false;
            this.dataGridViewTextBoxColumn_41.DataPropertyName = "BusPoint";
            this.dataGridViewTextBoxColumn_41.HeaderText = "BusPoint";
            this.dataGridViewTextBoxColumn_41.Name = "busPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_41.Visible = false;
            this.dataGridViewTextBoxColumn_42.DataPropertyName = "BusFullPoint";
            this.dataGridViewTextBoxColumn_42.HeaderText = "BusFullPoint";
            this.dataGridViewTextBoxColumn_42.Name = "busFullPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_42.ReadOnly = true;
            this.dataGridViewTextBoxColumn_42.Visible = false;
            this.dataGridViewTextBoxColumn_43.DataPropertyName = "idCellPoint";
            this.dataGridViewTextBoxColumn_43.HeaderText = "idCellPoint";
            this.dataGridViewTextBoxColumn_43.Name = "idCellPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_43.Visible = false;
            this.dataGridViewTextBoxColumn_44.DataPropertyName = "CellPoint";
            this.dataGridViewTextBoxColumn_44.HeaderText = "CellPoint";
            this.dataGridViewTextBoxColumn_44.Name = "cellPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_44.Visible = false;
            this.dataGridViewTextBoxColumn_45.DataPropertyName = "CellFullPoint";
            this.dataGridViewTextBoxColumn_45.HeaderText = "CellFullPoint";
            this.dataGridViewTextBoxColumn_45.Name = "cellFullPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_45.ReadOnly = true;
            this.dataGridViewTextBoxColumn_45.Visible = false;
            this.dataGridViewTextBoxColumn_46.DataPropertyName = "idSubCP";
            this.dataGridViewTextBoxColumn_46.HeaderText = "idSubCP";
            this.dataGridViewTextBoxColumn_46.Name = "idSubCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_46.Visible = false;
            this.dataGridViewTextBoxColumn_47.DataPropertyName = "SubCP";
            this.dataGridViewTextBoxColumn_47.HeaderText = "SubCP";
            this.dataGridViewTextBoxColumn_47.Name = "subCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_47.ReadOnly = true;
            this.dataGridViewTextBoxColumn_47.Visible = false;
            this.dataGridViewTextBoxColumn_48.DataPropertyName = "idBusCP";
            this.dataGridViewTextBoxColumn_48.HeaderText = "idBusCP";
            this.dataGridViewTextBoxColumn_48.Name = "idBusCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_48.Visible = false;
            this.dataGridViewTextBoxColumn_49.DataPropertyName = "BusCP";
            this.dataGridViewTextBoxColumn_49.HeaderText = "BusCP";
            this.dataGridViewTextBoxColumn_49.Name = "busCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_49.Visible = false;
            this.dataGridViewTextBoxColumn_50.DataPropertyName = "idCellCP";
            this.dataGridViewTextBoxColumn_50.HeaderText = "idCellCP";
            this.dataGridViewTextBoxColumn_50.Name = "idCellCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_50.Visible = false;
            this.dataGridViewTextBoxColumn_51.DataPropertyName = "CellCP";
            this.dataGridViewTextBoxColumn_51.HeaderText = "CellCP";
            this.dataGridViewTextBoxColumn_51.Name = "cellCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_51.Visible = false;
            this.dataGridViewTextBoxColumn_52.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_52.DataPropertyName = "AttachmentPoint";
            this.dataGridViewTextBoxColumn_52.HeaderText = "Точка присоединения";
            this.dataGridViewTextBoxColumn_52.Name = "attachmentPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_52.ReadOnly = true;
            this.dataGridViewTextBoxColumn_53.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_53.DataPropertyName = "PowerSupply";
            this.dataGridViewTextBoxColumn_53.HeaderText = "Источник питания (наименование питающих линий)";
            this.dataGridViewTextBoxColumn_53.Name = "powerSupplyDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_53.ReadOnly = true;
            this.dataGridViewTextBoxColumn_54.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_54.HeaderText = "Описание точки присоединения";
            this.dataGridViewTextBoxColumn_54.Name = "APDescription";
            this.dataGridViewTextBoxColumn_55.DataPropertyName = "voltagelevel";
            this.dataGridViewTextBoxColumn_55.HeaderText = "voltagelevel";
            this.dataGridViewTextBoxColumn_55.Name = "voltagelevelDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_55.Visible = false;
            this.dataGridViewTextBoxColumn_56.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_56.DataPropertyName = "voltagelevelname";
            this.dataGridViewTextBoxColumn_56.HeaderText = "Уровень напряжения (кВ)";
            this.dataGridViewTextBoxColumn_56.Name = "voltagelevelnameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_57.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_57.DataPropertyName = "powersum";
            this.dataGridViewTextBoxColumn_57.HeaderText = "Максимальная мощность (кВт)";
            this.dataGridViewTextBoxColumn_57.Name = "powersumDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_58.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_58.HeaderText = "Величина номинальной мощности присоединенных троансформаторов (кВА)";
            this.dataGridViewTextBoxColumn_58.Name = "PowerTransfNom";
            this.dataGridViewTextBoxColumn_59.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_59.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn_59.HeaderText = "Категория надежности электроснабжения";
            this.dataGridViewTextBoxColumn_59.Name = "categoryDataGridViewTextBoxColumn";
            this.bindingSource_1.DataMember = "vTC_TUPointAttach";
            this.bindingSource_1.DataSource = this.dataSetGES_0;
            this.bindingSource_1.Sort = "";
            this.label_36.AutoSize = true;
            this.label_36.Dock = DockStyle.Fill;
            this.label_36.Location = new Point(0x13a, 0x42);
            this.label_36.Name = "label13";
            this.label_36.Size = new Size(0x91, 0x19);
            this.label_36.TabIndex = 5;
            this.label_36.Text = "Максимальная мощность";
            this.label_36.TextAlign = ContentAlignment.MiddleRight;
            this.label_35.AutoSize = true;
            this.tableLayoutPanel_6.SetColumnSpan(this.label_35, 2);
            this.label_35.Dock = DockStyle.Fill;
            this.label_35.Location = new Point(0x17, 0x5b);
            this.label_35.Name = "label14";
            this.label_35.Size = new Size(0x1b4, 0x19);
            this.label_35.TabIndex = 6;
            this.label_35.Text = "Совокупная величина номинальной мощности присоединенных трансформаторов";
            this.label_35.TextAlign = ContentAlignment.MiddleRight;
            this.label_34.AutoSize = true;
            this.label_34.Dock = DockStyle.Fill;
            this.label_34.Location = new Point(0x256, 0x5b);
            this.label_34.Name = "label15";
            this.label_34.Size = new Size(130, 0x19);
            this.label_34.TabIndex = 7;
            this.label_34.Text = "кВА";
            this.label_34.TextAlign = ContentAlignment.MiddleLeft;
            this.label_33.AutoSize = true;
            this.label_33.Dock = DockStyle.Fill;
            this.label_33.Location = new Point(0x256, 0x42);
            this.label_33.Name = "label16";
            this.label_33.Size = new Size(130, 0x19);
            this.label_33.TabIndex = 8;
            this.label_33.Text = "кВт";
            this.label_33.TextAlign = ContentAlignment.MiddleLeft;
            this.textBox_19.Dock = DockStyle.Fill;
            this.textBox_19.Location = new Point(0x1d1, 0x5e);
            this.textBox_19.Name = "tbPowerNom";
            this.textBox_19.ReadOnly = true;
            this.textBox_19.Size = new Size(0x7f, 20);
            this.textBox_19.TabIndex = 2;
            this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_1.DisplayMember = "id";
            this.comboBox_1.Dock = DockStyle.Fill;
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x1d1, 0x17);
            this.comboBox_1.Name = "cbActTehConnection";
            this.comboBox_1.Size = new Size(0x7f, 0x15);
            this.comboBox_1.TabIndex = 0;
            this.comboBox_1.ValueMember = "id";
            this.label_37.AutoSize = true;
            this.tableLayoutPanel_6.SetColumnSpan(this.label_37, 2);
            this.label_37.Dock = DockStyle.Fill;
            this.label_37.Location = new Point(0x17, 20);
            this.label_37.Name = "label12";
            this.label_37.Size = new Size(0x1b4, 0x1a);
            this.label_37.TabIndex = 4;
            this.label_37.Text = "Акт технологического присоединения";
            this.label_37.TextAlign = ContentAlignment.MiddleRight;
            this.tabPage_1.Controls.Add(this.tableLayoutPanel_3);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tpDopoln";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x2e7, 0x28b);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Дополнительно-1";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.tableLayoutPanel_3.ColumnCount = 6;
            this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11f));
            this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184f));
            this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 179f));
            this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118f));
            this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8f));
            this.tableLayoutPanel_3.Controls.Add(this.label_23, 4, 15);
            this.tableLayoutPanel_3.Controls.Add(this.label_13, 1, 0);
            this.tableLayoutPanel_3.Controls.Add(this.label_15, 1, 1);
            this.tableLayoutPanel_3.Controls.Add(this.textBox_8, 1, 2);
            this.tableLayoutPanel_3.Controls.Add(this.label_14, 1, 3);
            this.tableLayoutPanel_3.Controls.Add(this.textBox_10, 1, 4);
            this.tableLayoutPanel_3.Controls.Add(this.label_16, 1, 5);
            this.tableLayoutPanel_3.Controls.Add(this.textBox_9, 1, 6);
            this.tableLayoutPanel_3.Controls.Add(this.label_19, 1, 7);
            this.tableLayoutPanel_3.Controls.Add(this.elementHost_8, 1, 8);
            this.tableLayoutPanel_3.Controls.Add(this.textBox_14, 3, 15);
            this.tableLayoutPanel_3.Controls.Add(this.label_18, 1, 9);
            this.tableLayoutPanel_3.Controls.Add(this.label_17, 1, 11);
            this.tableLayoutPanel_3.Controls.Add(this.textBox_11, 2, 13);
            this.tableLayoutPanel_3.Controls.Add(this.textBox_12, 1, 0x12);
            this.tableLayoutPanel_3.Controls.Add(this.label_21, 1, 13);
            this.tableLayoutPanel_3.Controls.Add(this.label_24, 1, 15);
            this.tableLayoutPanel_3.Controls.Add(this.label_22, 1, 0x11);
            this.tableLayoutPanel_3.Controls.Add(this.label_20, 1, 14);
            this.tableLayoutPanel_3.Controls.Add(this.textBox_13, 1, 0x10);
            this.tableLayoutPanel_3.Controls.Add(this.elementHost_1, 1, 12);
            this.tableLayoutPanel_3.Controls.Add(this.elementHost_0, 1, 10);
            this.tableLayoutPanel_3.Dock = DockStyle.Fill;
            this.tableLayoutPanel_3.Location = new Point(3, 3);
            this.tableLayoutPanel_3.Name = "tableLayoutPanel4";
            this.tableLayoutPanel_3.RowCount = 20;
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 66f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 61f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 18f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 58f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 43f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 86f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel_3.Size = new Size(0x2e1, 0x285);
            this.tableLayoutPanel_3.TabIndex = 0x24;
            this.label_23.AutoSize = true;
            this.label_23.Dock = DockStyle.Fill;
            this.label_23.Location = new Point(0x266, 0x1f3);
            this.label_23.Name = "lbTO2";
            this.label_23.Size = new Size(0x70, 0x1a);
            this.label_23.TabIndex = 0x1a;
            this.label_23.Text = "в эксплуатации";
            this.label_23.TextAlign = ContentAlignment.MiddleCenter;
            this.label_13.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_13, 4);
            this.label_13.Dock = DockStyle.Fill;
            this.label_13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_13.Location = new Point(14, 0);
            this.label_13.Name = "lbCaptionDop";
            this.label_13.Size = new Size(0x2c8, 0x22);
            this.label_13.TabIndex = 0;
            this.label_13.Text = "Дополнительные поля для 3-х стороннего акта";
            this.label_15.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_15, 4);
            this.label_15.Dock = DockStyle.Fill;
            this.label_15.Location = new Point(14, 0x22);
            this.label_15.Name = "lbOwnerName";
            this.label_15.Size = new Size(0x2c8, 20);
            this.label_15.TabIndex = 1;
            this.label_15.Text = "Владелец сетей:";
            this.label_15.TextAlign = ContentAlignment.BottomLeft;
            this.tableLayoutPanel_3.SetColumnSpan(this.textBox_8, 4);
            this.textBox_8.Dock = DockStyle.Fill;
            this.textBox_8.Location = new Point(14, 0x39);
            this.textBox_8.Name = "tbOwnerName";
            this.textBox_8.Size = new Size(0x2c8, 20);
            this.textBox_8.TabIndex = 2;
            this.textBox_8.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_14.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_14, 4);
            this.label_14.Dock = DockStyle.Fill;
            this.label_14.Location = new Point(14, 0x4e);
            this.label_14.Name = "lbOwnerChief";
            this.label_14.Size = new Size(0x2c8, 0x1a);
            this.label_14.TabIndex = 3;
            this.label_14.Text = "в лице:";
            this.label_14.TextAlign = ContentAlignment.BottomLeft;
            this.tableLayoutPanel_3.SetColumnSpan(this.textBox_10, 4);
            this.textBox_10.Dock = DockStyle.Fill;
            this.textBox_10.Location = new Point(14, 0x6b);
            this.textBox_10.Name = "tbOwnerChief";
            this.textBox_10.Size = new Size(0x2c8, 20);
            this.textBox_10.TabIndex = 4;
            this.textBox_10.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_16.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_16, 4);
            this.label_16.Dock = DockStyle.Fill;
            this.label_16.Location = new Point(14, 0x81);
            this.label_16.Name = "lbOwnerBase";
            this.label_16.Size = new Size(0x2c8, 0x18);
            this.label_16.TabIndex = 5;
            this.label_16.Text = "действующий на основании:";
            this.label_16.TextAlign = ContentAlignment.BottomLeft;
            this.tableLayoutPanel_3.SetColumnSpan(this.textBox_9, 4);
            this.textBox_9.Dock = DockStyle.Fill;
            this.textBox_9.Location = new Point(14, 0x9c);
            this.textBox_9.Name = "tbOwnerBase";
            this.textBox_9.Size = new Size(0x2c8, 20);
            this.textBox_9.TabIndex = 6;
            this.textBox_9.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_19.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_19, 4);
            this.label_19.Dock = DockStyle.Fill;
            this.label_19.Location = new Point(14, 0xb3);
            this.label_19.Name = "lbOwnerApp";
            this.label_19.Size = new Size(0x2c8, 0x17);
            this.label_19.TabIndex = 7;
            this.label_19.Text = "На балансе Владельца сетей находится:";
            this.label_19.TextAlign = ContentAlignment.BottomLeft;
            this.tableLayoutPanel_3.SetColumnSpan(this.elementHost_8, 4);
            this.elementHost_8.Dock = DockStyle.Fill;
            this.elementHost_8.Location = new Point(14, 0xcd);
            this.elementHost_8.Name = "elementHost1";
            this.elementHost_8.Size = new Size(0x2c8, 60);
            this.elementHost_8.TabIndex = 0x23;
            this.elementHost_8.Text = "elementHost1";
            this.elementHost_8.Child = null;
            this.textBox_14.Dock = DockStyle.Fill;
            this.textBox_14.Location = new Point(0x179, 0x1f6);
            this.textBox_14.Name = "tbDogByOTONum";
            this.textBox_14.Size = new Size(0xe7, 20);
            this.textBox_14.TabIndex = 0x19;
            this.textBox_14.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_18.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_18, 4);
            this.label_18.Dock = DockStyle.Fill;
            this.label_18.Location = new Point(14, 0x10c);
            this.label_18.Name = "lbBorder2Expl";
            this.label_18.Size = new Size(0x2c8, 0x1c);
            this.label_18.TabIndex = 0x13;
            this.label_18.Text = "Границей балансовой принадлежности сторон является:";
            this.label_18.TextAlign = ContentAlignment.BottomLeft;
            this.label_17.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_17, 4);
            this.label_17.Dock = DockStyle.Fill;
            this.label_17.Location = new Point(14, 0x165);
            this.label_17.Name = "label1";
            this.label_17.Size = new Size(0x2c8, 0x12);
            this.label_17.TabIndex = 20;
            this.label_17.Text = "В эксплуатации владельца сетей находится:";
            this.label_17.TextAlign = ContentAlignment.BottomLeft;
            this.tableLayoutPanel_3.SetColumnSpan(this.textBox_11, 3);
            this.textBox_11.Dock = DockStyle.Fill;
            this.textBox_11.Location = new Point(0xc6, 0x1b4);
            this.textBox_11.Name = "tbOwnerChief2";
            this.textBox_11.Size = new Size(0x210, 20);
            this.textBox_11.TabIndex = 0x16;
            this.textBox_11.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.tableLayoutPanel_3.SetColumnSpan(this.textBox_12, 4);
            this.textBox_12.Dock = DockStyle.Fill;
            this.textBox_12.Location = new Point(14, 0x241);
            this.textBox_12.Name = "tbTO1";
            this.textBox_12.Size = new Size(0x2c8, 20);
            this.textBox_12.TabIndex = 0x1d;
            this.textBox_12.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_21.AutoSize = true;
            this.label_21.Dock = DockStyle.Fill;
            this.label_21.Location = new Point(14, 0x1b1);
            this.label_21.Name = "lbOwnerChief2";
            this.label_21.Size = new Size(0xb2, 0x17);
            this.label_21.TabIndex = 0x15;
            this.label_21.Text = "Владелец сетей(для подписи):";
            this.label_21.TextAlign = ContentAlignment.MiddleLeft;
            this.label_24.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_24, 2);
            this.label_24.Dock = DockStyle.Fill;
            this.label_24.Location = new Point(14, 0x1f3);
            this.label_24.Name = "lbDogByOTONum";
            this.label_24.Size = new Size(0x165, 0x1a);
            this.label_24.TabIndex = 0x18;
            this.label_24.Text = "При наличии договора на Оперативно-техническое обслуживание № ";
            this.label_24.TextAlign = ContentAlignment.MiddleLeft;
            this.label_22.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_22, 4);
            this.label_22.Dock = DockStyle.Fill;
            this.label_22.Location = new Point(14, 0x225);
            this.label_22.Name = "lbTO1";
            this.label_22.Size = new Size(0x2c8, 0x19);
            this.label_22.TabIndex = 0x1c;
            this.label_22.Text = "При наличии договора на Оперативно-техническое обслуживание ответственность";
            this.label_22.TextAlign = ContentAlignment.BottomLeft;
            this.label_20.AutoSize = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.label_20, 4);
            this.label_20.Dock = DockStyle.Fill;
            this.label_20.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_20.Location = new Point(14, 0x1c8);
            this.label_20.Name = "label3";
            this.label_20.Size = new Size(0x2c8, 0x2b);
            this.label_20.TabIndex = 0x17;
            this.label_20.Text = "Дополнительные поля для акта c ТО";
            this.label_20.TextAlign = ContentAlignment.MiddleCenter;
            this.label_20.UseWaitCursor = true;
            this.tableLayoutPanel_3.SetColumnSpan(this.textBox_13, 4);
            this.textBox_13.Dock = DockStyle.Fill;
            this.textBox_13.Location = new Point(14, 0x210);
            this.textBox_13.Name = "tbTO2";
            this.textBox_13.Size = new Size(0x2c8, 20);
            this.textBox_13.TabIndex = 0x1b;
            this.textBox_13.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.tableLayoutPanel_3.SetColumnSpan(this.elementHost_1, 4);
            this.elementHost_1.Dock = DockStyle.Fill;
            this.elementHost_1.Location = new Point(14, 0x17a);
            this.elementHost_1.Name = "hostOwnerExpl";
            this.elementHost_1.Size = new Size(0x2c8, 0x34);
            this.elementHost_1.TabIndex = 0x21;
            this.elementHost_1.Text = "elementHost5";
            this.elementHost_1.Child = null;
            this.tableLayoutPanel_3.SetColumnSpan(this.elementHost_0, 4);
            this.elementHost_0.Dock = DockStyle.Fill;
            this.elementHost_0.Location = new Point(14, 0x12b);
            this.elementHost_0.Name = "hostBorder2Expl";
            this.elementHost_0.Size = new Size(0x2c8, 0x37);
            this.elementHost_0.TabIndex = 0x22;
            this.elementHost_0.Text = "elementHost6";
            this.elementHost_0.Child = null;
            this.tabPage_3.Controls.Add(this.tableLayoutPanel_4);
            this.tabPage_3.Location = new Point(4, 0x16);
            this.tabPage_3.Name = "tpDopoln2";
            this.tabPage_3.Padding = new Padding(3);
            this.tabPage_3.Size = new Size(0x2e7, 0x28b);
            this.tabPage_3.TabIndex = 3;
            this.tabPage_3.Text = "Дополнительно-2";
            this.tabPage_3.UseVisualStyleBackColor = true;
            this.tableLayoutPanel_4.ColumnCount = 4;
            this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13f));
            this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181f));
            this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14f));
            this.tableLayoutPanel_4.Controls.Add(this.label_32, 1, 0);
            this.tableLayoutPanel_4.Controls.Add(this.textBox_15, 2, 13);
            this.tableLayoutPanel_4.Controls.Add(this.label_31, 1, 1);
            this.tableLayoutPanel_4.Controls.Add(this.label_25, 1, 13);
            this.tableLayoutPanel_4.Controls.Add(this.textBox_18, 1, 2);
            this.tableLayoutPanel_4.Controls.Add(this.elementHost_3, 1, 12);
            this.tableLayoutPanel_4.Controls.Add(this.label_26, 1, 11);
            this.tableLayoutPanel_4.Controls.Add(this.label_30, 1, 3);
            this.tableLayoutPanel_4.Controls.Add(this.elementHost_2, 1, 10);
            this.tableLayoutPanel_4.Controls.Add(this.label_27, 1, 9);
            this.tableLayoutPanel_4.Controls.Add(this.textBox_17, 1, 4);
            this.tableLayoutPanel_4.Controls.Add(this.label_28, 1, 7);
            this.tableLayoutPanel_4.Controls.Add(this.label_29, 1, 5);
            this.tableLayoutPanel_4.Controls.Add(this.elementHost_4, 1, 8);
            this.tableLayoutPanel_4.Controls.Add(this.textBox_16, 1, 6);
            this.tableLayoutPanel_4.Dock = DockStyle.Fill;
            this.tableLayoutPanel_4.Location = new Point(3, 3);
            this.tableLayoutPanel_4.Name = "tableLayoutPanel3";
            this.tableLayoutPanel_4.RowCount = 15;
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 23f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 66f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 23f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 73f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_4.Size = new Size(0x2e1, 0x285);
            this.tableLayoutPanel_4.TabIndex = 0x31;
            this.label_32.AutoSize = true;
            this.tableLayoutPanel_4.SetColumnSpan(this.label_32, 2);
            this.label_32.Dock = DockStyle.Fill;
            this.label_32.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_32.Location = new Point(0x10, 0);
            this.label_32.Name = "label4";
            this.label_32.Size = new Size(0x2c0, 0x20);
            this.label_32.TabIndex = 1;
            this.label_32.Text = "Дополнительные поля для 4-х стороннего акта";
            this.label_32.TextAlign = ContentAlignment.MiddleCenter;
            this.textBox_15.Dock = DockStyle.Fill;
            this.textBox_15.Location = new Point(0xc5, 0x1dc);
            this.textBox_15.Name = "tbOwnerChief2_Four";
            this.textBox_15.Size = new Size(0x20b, 20);
            this.textBox_15.TabIndex = 0x2d;
            this.textBox_15.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_31.AutoSize = true;
            this.tableLayoutPanel_4.SetColumnSpan(this.label_31, 2);
            this.label_31.Dock = DockStyle.Fill;
            this.label_31.Location = new Point(0x10, 0x20);
            this.label_31.Name = "label11";
            this.label_31.Size = new Size(0x2c0, 0x26);
            this.label_31.TabIndex = 0x23;
            this.label_31.Text = "Владелец сетей:";
            this.label_31.TextAlign = ContentAlignment.BottomLeft;
            this.label_25.AutoSize = true;
            this.label_25.Dock = DockStyle.Fill;
            this.label_25.Location = new Point(0x10, 0x1d9);
            this.label_25.Name = "label5";
            this.label_25.Size = new Size(0xaf, 0x19);
            this.label_25.TabIndex = 0x2c;
            this.label_25.Text = "Владелец сетей(для подписи):";
            this.label_25.TextAlign = ContentAlignment.MiddleLeft;
            this.tableLayoutPanel_4.SetColumnSpan(this.textBox_18, 2);
            this.textBox_18.Dock = DockStyle.Fill;
            this.textBox_18.Location = new Point(0x10, 0x49);
            this.textBox_18.Name = "tbOwnerName_Four";
            this.textBox_18.Size = new Size(0x2c0, 20);
            this.textBox_18.TabIndex = 0x24;
            this.textBox_18.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.tableLayoutPanel_4.SetColumnSpan(this.elementHost_3, 2);
            this.elementHost_3.Dock = DockStyle.Fill;
            this.elementHost_3.Location = new Point(0x10, 0x193);
            this.elementHost_3.Name = "hostOwnerExpl_Four";
            this.elementHost_3.Size = new Size(0x2c0, 0x43);
            this.elementHost_3.TabIndex = 0x2f;
            this.elementHost_3.Text = "elementHost5";
            this.elementHost_3.Child = null;
            this.label_26.AutoSize = true;
            this.tableLayoutPanel_4.SetColumnSpan(this.label_26, 2);
            this.label_26.Dock = DockStyle.Fill;
            this.label_26.Location = new Point(0x10, 0x179);
            this.label_26.Name = "label6";
            this.label_26.Size = new Size(0x2c0, 0x17);
            this.label_26.TabIndex = 0x2b;
            this.label_26.Text = "В эксплуатации владельца сетей находится:";
            this.label_26.TextAlign = ContentAlignment.BottomLeft;
            this.label_30.AutoSize = true;
            this.tableLayoutPanel_4.SetColumnSpan(this.label_30, 2);
            this.label_30.Dock = DockStyle.Fill;
            this.label_30.Location = new Point(0x10, 0x5f);
            this.label_30.Name = "label10";
            this.label_30.Size = new Size(0x2c0, 0x18);
            this.label_30.TabIndex = 0x25;
            this.label_30.Text = "в лице:";
            this.label_30.TextAlign = ContentAlignment.BottomLeft;
            this.tableLayoutPanel_4.SetColumnSpan(this.elementHost_2, 2);
            this.elementHost_2.Dock = DockStyle.Fill;
            this.elementHost_2.Location = new Point(0x10, 310);
            this.elementHost_2.Name = "hostBorder2Expl_Four";
            this.elementHost_2.Size = new Size(0x2c0, 0x40);
            this.elementHost_2.TabIndex = 0x30;
            this.elementHost_2.Text = "elementHost6";
            this.elementHost_2.Child = null;
            this.label_27.AutoSize = true;
            this.tableLayoutPanel_4.SetColumnSpan(this.label_27, 2);
            this.label_27.Dock = DockStyle.Fill;
            this.label_27.Location = new Point(0x10, 0x11a);
            this.label_27.Name = "lbBorder2Expl_Four";
            this.label_27.Size = new Size(0x2c0, 0x19);
            this.label_27.TabIndex = 0x2a;
            this.label_27.Text = "Границей балансовой принадлежности сторон является:";
            this.label_27.TextAlign = ContentAlignment.BottomLeft;
            this.tableLayoutPanel_4.SetColumnSpan(this.textBox_17, 2);
            this.textBox_17.Dock = DockStyle.Fill;
            this.textBox_17.Location = new Point(0x10, 0x7a);
            this.textBox_17.Name = "tbOwnerChief_Four";
            this.textBox_17.Size = new Size(0x2c0, 20);
            this.textBox_17.TabIndex = 0x26;
            this.textBox_17.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.label_28.AutoSize = true;
            this.tableLayoutPanel_4.SetColumnSpan(this.label_28, 2);
            this.label_28.Dock = DockStyle.Fill;
            this.label_28.Location = new Point(0x10, 0xc0);
            this.label_28.Name = "label8";
            this.label_28.Size = new Size(0x2c0, 0x18);
            this.label_28.TabIndex = 0x29;
            this.label_28.Text = "На балансе Владельца сетей находится:";
            this.label_28.TextAlign = ContentAlignment.BottomLeft;
            this.label_29.AutoSize = true;
            this.tableLayoutPanel_4.SetColumnSpan(this.label_29, 2);
            this.label_29.Dock = DockStyle.Fill;
            this.label_29.Location = new Point(0x10, 0x90);
            this.label_29.Name = "label9";
            this.label_29.Size = new Size(0x2c0, 0x17);
            this.label_29.TabIndex = 0x27;
            this.label_29.Text = "действующий на основании:";
            this.label_29.TextAlign = ContentAlignment.BottomLeft;
            this.tableLayoutPanel_4.SetColumnSpan(this.elementHost_4, 2);
            this.elementHost_4.Dock = DockStyle.Fill;
            this.elementHost_4.Location = new Point(0x10, 0xdb);
            this.elementHost_4.Name = "hostOrganizExpl_Four";
            this.elementHost_4.Size = new Size(0x2c0, 60);
            this.elementHost_4.TabIndex = 0x2e;
            this.elementHost_4.Text = "elementHost4";
            this.elementHost_4.Child = null;
            this.tableLayoutPanel_4.SetColumnSpan(this.textBox_16, 2);
            this.textBox_16.Dock = DockStyle.Fill;
            this.textBox_16.Location = new Point(0x10, 170);
            this.textBox_16.Name = "tbOwnerBase_Four";
            this.textBox_16.Size = new Size(0x2c0, 20);
            this.textBox_16.TabIndex = 40;
            this.textBox_16.TextChanged += new EventHandler(this.textBox_16_TextChanged);
            this.tabPage_2.Controls.Add(this.tableLayoutPanel_7);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tpPrivyazka";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x2e7, 0x28b);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Изображение";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.tableLayoutPanel_7.ColumnCount = 2;
            this.tableLayoutPanel_7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.90953f));
            this.tableLayoutPanel_7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.09047f));
            this.tableLayoutPanel_7.Controls.Add(this.pictureBox_0, 1, 1);
            this.tableLayoutPanel_7.Controls.Add(this.toolStrip_0, 0, 0);
            this.tableLayoutPanel_7.Controls.Add(this.dataGridViewExcelFilter_0, 0, 1);
            this.tableLayoutPanel_7.Dock = DockStyle.Fill;
            this.tableLayoutPanel_7.Location = new Point(3, 3);
            this.tableLayoutPanel_7.Name = "tableLayoutPanel6";
            this.tableLayoutPanel_7.RowCount = 2;
            this.tableLayoutPanel_7.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_7.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            this.tableLayoutPanel_7.Size = new Size(0x2e1, 0x285);
            this.tableLayoutPanel_7.TabIndex = 40;
            this.pictureBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.pictureBox_0.Location = new Point(0xb3, 0x1d);
            this.pictureBox_0.Name = "pbScanDoc";
            this.pictureBox_0.Size = new Size(0x22b, 0x265);
            this.pictureBox_0.TabIndex = 1;
            this.pictureBox_0.TabStop = false;
            this.tableLayoutPanel_7.SetColumnSpan(this.toolStrip_0, 2);
            this.toolStrip_0.Dock = DockStyle.Fill;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3 };
            this.toolStrip_0.Items.AddRange(itemArray2);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripImage";
            this.toolStrip_0.Size = new Size(0x2e1, 0x1a);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = (Image) manager.GetObject("tsbImage.Image");
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "tsbImage";
            this.toolStripButton_0.Size = new Size(0x17, 0x17);
            this.toolStripButton_0.Text = "Добавить изображение";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = (Image) manager.GetObject("tsbRemoveImage.Image");
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "tsbRemoveImage";
            this.toolStripButton_1.Size = new Size(0x17, 0x17);
            this.toolStripButton_1.Text = "Удалить изображение";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
            this.toolStripButton_2.Alignment = ToolStripItemAlignment.Right;
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = (Image) manager.GetObject("tsbSaveImage.Image");
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "tsbSaveImage";
            this.toolStripButton_2.Size = new Size(0x17, 0x17);
            this.toolStripButton_2.Text = "Сохранить изображение в файл для просмотра и печати";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripButton_3.Alignment = ToolStripItemAlignment.Right;
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = (Image) manager.GetObject("toolStripButton1.Image");
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolStripButton1";
            this.toolStripButton_3.Size = new Size(0x17, 0x17);
            this.toolStripButton_3.Text = "Открытие и печать изображения";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            style7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style7.BackColor = SystemColors.Control;
            style7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style7.ForeColor = SystemColors.WindowText;
            style7.SelectionBackColor = SystemColors.Highlight;
            style7.SelectionForeColor = SystemColors.HighlightText;
            style7.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style7;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcelFilter_0.ColumnHeadersVisible = false;
            DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { this.dataGridViewImageColumn_0, this.dataGridViewImageColumn_1, this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_0 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(columnArray3);
            style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style8.BackColor = SystemColors.Window;
            style8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style8.ForeColor = SystemColors.ControlText;
            style8.SelectionBackColor = SystemColors.Highlight;
            style8.SelectionForeColor = SystemColors.HighlightText;
            style8.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_0.DefaultCellStyle = style8;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1d);
            this.dataGridViewExcelFilter_0.Name = "dataGridViewImages";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            style9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style9.BackColor = SystemColors.Control;
            style9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style9.ForeColor = SystemColors.WindowText;
            style9.SelectionBackColor = SystemColors.Highlight;
            style9.SelectionForeColor = SystemColors.HighlightText;
            style9.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = style9;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 4;
            this.dataGridViewExcelFilter_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewExcelFilter_0.RowTemplate.Height = 200;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(170, 0x265);
            this.dataGridViewExcelFilter_0.TabIndex = 0x27;
            this.dataGridViewExcelFilter_0.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_0_CellMouseClick);
            this.dataGridViewImageColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn_0.HeaderText = "image";
            this.dataGridViewImageColumn_0.Name = "image";
            this.dataGridViewImageColumn_0.ReadOnly = true;
            this.dataGridViewImageColumn_1.HeaderText = "ImageOriginal";
            this.dataGridViewImageColumn_1.Name = "ImageOriginal";
            this.dataGridViewImageColumn_1.ReadOnly = true;
            this.dataGridViewImageColumn_1.Visible = false;
            this.dataGridViewCheckBoxColumn_0.HeaderText = "Compressed";
            this.dataGridViewCheckBoxColumn_0.Name = "Compressed";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "id";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.tabPage_4.Controls.Add(this.tableLayoutPanel_1);
            this.tabPage_4.Location = new Point(4, 0x16);
            this.tabPage_4.Name = "tpFiles";
            this.tabPage_4.Size = new Size(0x2e7, 0x28b);
            this.tabPage_4.TabIndex = 4;
            this.tabPage_4.Text = "Файлы";
            this.tabPage_4.UseVisualStyleBackColor = true;
            this.tableLayoutPanel_1.ColumnCount = 1;
            this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_1.Controls.Add(this.toolStrip_1, 0, 0);
            this.tableLayoutPanel_1.Controls.Add(this.dataGridViewExcelFilter_1, 0, 1);
            this.tableLayoutPanel_1.Dock = DockStyle.Fill;
            this.tableLayoutPanel_1.Location = new Point(0, 0);
            this.tableLayoutPanel_1.Name = "tlpFiles";
            this.tableLayoutPanel_1.RowCount = 2;
            this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
            this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel_1.Size = new Size(0x2e7, 0x28b);
            this.tableLayoutPanel_1.TabIndex = 0;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_4, this.toolStripButton_5, this.toolStripButton_6, this.toolStripSeparator_1, this.toolStripButton_7, this.toolStripButton_8 };
            this.toolStrip_1.Items.AddRange(itemArray3);
            this.toolStrip_1.Location = new Point(0, 0);
            this.toolStrip_1.Name = "toolStripFile";
            this.toolStrip_1.Size = new Size(0x2e7, 0x18);
            this.toolStrip_1.TabIndex = 8;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripMenuItem_2, this.toolStripSeparator_0 };
            this.toolStripDropDownButton_0.DropDownItems.AddRange(itemArray4);
            this.toolStripDropDownButton_0.Image = (Image) manager.GetObject("toolBtnAddFile.Image");
            this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton_0.Name = "toolBtnAddFile";
            this.toolStripDropDownButton_0.Size = new Size(0x1d, 0x15);
            this.toolStripDropDownButton_0.Text = "Добавить файл";
            this.toolStripMenuItem_2.Name = "toolItemAddExistFile";
            this.toolStripMenuItem_2.Size = new Size(190, 0x16);
            this.toolStripMenuItem_2.Text = "Сущесвующий файл";
            this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_4_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator2";
            this.toolStripSeparator_0.Size = new Size(0xbb, 6);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = (Image) manager.GetObject("toolBtnEditFile.Image");
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnEditFile";
            this.toolStripButton_4.Size = new Size(0x17, 0x15);
            this.toolStripButton_4.Text = "Редактировать файл";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripMenuItem_5_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = (Image) manager.GetObject("toolBtnOpenFile.Image");
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnOpenFile";
            this.toolStripButton_5.Size = new Size(0x17, 0x15);
            this.toolStripButton_5.Text = "Открыть файл";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripMenuItem_6_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = (Image) manager.GetObject("toolBtnDelFile.Image");
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnDelFile";
            this.toolStripButton_6.Size = new Size(0x17, 0x15);
            this.toolStripButton_6.Text = "Удалить файл";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripMenuItem_7_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator3";
            this.toolStripSeparator_1.Size = new Size(6, 0x18);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = (Image) manager.GetObject("toolBtnRenameFile.Image");
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnRenameFile";
            this.toolStripButton_7.Size = new Size(0x17, 0x15);
            this.toolStripButton_7.Text = "Переименовать";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripMenuItem_8_Click);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = (Image) manager.GetObject("toolBtnSaveFile.Image");
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBtnSaveFile";
            this.toolStripButton_8.Size = new Size(0x17, 0x15);
            this.toolStripButton_8.Text = "Сохранить файл на диск";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripMenuItem_9_Click);
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            style10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style10.BackColor = SystemColors.Control;
            style10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style10.ForeColor = SystemColors.WindowText;
            style10.SelectionBackColor = SystemColors.Highlight;
            style10.SelectionForeColor = SystemColors.HighlightText;
            style10.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_1.ColumnHeadersDefaultCellStyle = style10;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewImageColumnNotNull_0 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray4);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_0;
            style11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style11.BackColor = SystemColors.Window;
            style11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style11.ForeColor = SystemColors.ControlText;
            style11.SelectionBackColor = SystemColors.Highlight;
            style11.SelectionForeColor = SystemColors.HighlightText;
            style11.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_1.DefaultCellStyle = style11;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExcelFilter_1.Location = new Point(3, 0x1b);
            this.dataGridViewExcelFilter_1.MultiSelect = false;
            this.dataGridViewExcelFilter_1.Name = "dgvFile";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            style12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style12.BackColor = SystemColors.Control;
            style12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style12.ForeColor = SystemColors.WindowText;
            style12.SelectionBackColor = SystemColors.Highlight;
            style12.SelectionForeColor = SystemColors.HighlightText;
            style12.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_1.RowHeadersDefaultCellStyle = style12;
            this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(0x2e1, 0x26d);
            this.dataGridViewExcelFilter_1.TabIndex = 7;
            this.dataGridViewExcelFilter_1.VirtualMode = true;
            this.dataGridViewExcelFilter_1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellDoubleClick);
            this.dataGridViewExcelFilter_1.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellEndEdit);
            this.dataGridViewExcelFilter_1.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_1_CellMouseClick);
            this.dataGridViewExcelFilter_1.CellValidating += new DataGridViewCellValidatingEventHandler(this.dataGridViewExcelFilter_1_CellValidating);
            this.dataGridViewExcelFilter_1.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_1_CellValueNeeded);
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_1.HeaderText = "id";
            this.dataGridViewTextBoxColumn_1.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idList";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idList";
            this.dataGridViewTextBoxColumn_2.Name = "idListDgvColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "FileName";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Файл";
            this.dataGridViewFilterTextBoxColumn_0.Name = "fileNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_3.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_3.Name = "dateChangeDgvColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_4.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_4.Name = "idTemplateDgvColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            style13.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style13;
            this.dataGridViewImageColumnNotNull_0.HeaderText = "";
            this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumnNotNull_0.Name = "imageDgvColumn";
            this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_0.Width = 30;
            this.bindingSource_0.DataMember = "tAbnObjDoc_File";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.button_2.BackColor = Color.LightGray;
            this.button_2.DialogResult = DialogResult.Cancel;
            this.button_2.Dock = DockStyle.Left;
            this.button_2.Location = new Point(0x281, 0x2b0);
            this.button_2.Margin = new Padding(6, 5, 3, 12);
            this.button_2.Name = "btnCancel";
            this.button_2.Size = new Size(0x5e, 0x1c);
            this.button_2.TabIndex = 0x22;
            this.button_2.Text = "Отменить";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new EventHandler(this.button_2_Click);
            this.button_3.BackColor = Color.LightGray;
            this.button_3.DialogResult = DialogResult.OK;
            this.button_3.Dock = DockStyle.Right;
            this.button_3.Location = new Point(0x217, 0x2b0);
            this.button_3.Margin = new Padding(3, 5, 6, 12);
            this.button_3.Name = "btnComplit";
            this.button_3.Size = new Size(0x5e, 0x1c);
            this.button_3.TabIndex = 0x21;
            this.button_3.Text = "Готово";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new EventHandler(this.button_3_Click);
            this.bindingSource_2.CurrentChanged += new EventHandler(this.bindingSource_2_CurrentChanged);
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1 };
            this.contextMenuStrip_0.Items.AddRange(itemArray5);
            this.contextMenuStrip_0.Name = "contextMenuStripImage";
            this.contextMenuStrip_0.Size = new Size(0x7f, 0x30);
            this.toolStripMenuItem_0.Image = (Image) manager.GetObject("добавитьToolStripMenuItem.Image");
            this.toolStripMenuItem_0.Name = "добавитьToolStripMenuItem";
            this.toolStripMenuItem_0.Size = new Size(0x7e, 0x16);
            this.toolStripMenuItem_0.Text = "Добавить";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.toolStripMenuItem_1.Image = (Image) manager.GetObject("удалитьToolStripMenuItem.Image");
            this.toolStripMenuItem_1.Name = "удалитьToolStripMenuItem";
            this.toolStripMenuItem_1.Size = new Size(0x7e, 0x16);
            this.toolStripMenuItem_1.Text = "Удалить";
            this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolStripMenuItem_3, this.toolStripMenuItem_5, this.toolStripMenuItem_6, this.toolStripMenuItem_7, this.toolStripSeparator_3, this.toolStripMenuItem_8, this.toolStripMenuItem_9 };
            this.contextMenuStrip_1.Items.AddRange(itemArray6);
            this.contextMenuStrip_1.Name = "contextMenuFile";
            this.contextMenuStrip_1.Size = new Size(0xb1, 0x8e);
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.toolStripMenuItem_4, this.toolStripSeparator_2 };
            this.toolStripMenuItem_3.DropDownItems.AddRange(itemArray7);
            this.toolStripMenuItem_3.Image = (Image) manager.GetObject("toolMenuItemAddFile.Image");
            this.toolStripMenuItem_3.Name = "toolMenuItemAddFile";
            this.toolStripMenuItem_3.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_3.Text = "Добавить";
            this.toolStripMenuItem_4.Name = "toolMenuItemAddExistsFile";
            this.toolStripMenuItem_4.Size = new Size(0xc3, 0x16);
            this.toolStripMenuItem_4.Text = "Существующий файл";
            this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator5";
            this.toolStripSeparator_2.Size = new Size(0xc0, 6);
            this.toolStripMenuItem_5.Image = (Image) manager.GetObject("toolMenuItemEditFile.Image");
            this.toolStripMenuItem_5.Name = "toolMenuItemEditFile";
            this.toolStripMenuItem_5.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_5.Text = "Редактировать";
            this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripMenuItem_5_Click);
            this.toolStripMenuItem_6.Image = (Image) manager.GetObject("toolMenuItemViewFile.Image");
            this.toolStripMenuItem_6.Name = "toolMenuItemViewFile";
            this.toolStripMenuItem_6.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_6.Text = "Просмотр";
            this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
            this.toolStripMenuItem_7.Image = (Image) manager.GetObject("toolMenuItemDelFile.Image");
            this.toolStripMenuItem_7.Name = "toolMenuItemDelFile";
            this.toolStripMenuItem_7.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_7.Text = "Удалить";
            this.toolStripMenuItem_7.Click += new EventHandler(this.toolStripMenuItem_7_Click);
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(0xad, 6);
            this.toolStripMenuItem_8.Image = (Image) manager.GetObject("toolMenuItemRenameFile.Image");
            this.toolStripMenuItem_8.Name = "toolMenuItemRenameFile";
            this.toolStripMenuItem_8.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_8.Text = "Переименовать";
            this.toolStripMenuItem_8.Click += new EventHandler(this.toolStripMenuItem_8_Click);
            this.toolStripMenuItem_9.Image = (Image) manager.GetObject("toolMenuItemSaveFile.Image");
            this.toolStripMenuItem_9.Name = "toolMenuItemSaveFile";
            this.toolStripMenuItem_9.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_9.Text = "Сохранить на диск";
            this.toolStripMenuItem_9.Click += new EventHandler(this.toolStripMenuItem_9_Click);
            this.dataGridViewImageColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn_2.HeaderText = "image";
            this.dataGridViewImageColumn_2.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn_2.ReadOnly = true;
            this.dataGridViewImageColumn_3.HeaderText = "ImageOriginal";
            this.dataGridViewImageColumn_3.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn_3.ReadOnly = true;
            this.dataGridViewImageColumn_3.Visible = false;
            this.dataGridViewCheckBoxColumn_1.HeaderText = "Compressed";
            this.dataGridViewCheckBoxColumn_1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_1.Visible = false;
            style14.NullValue = null;
            this.dataGridViewImageColumnNotNull_1.DefaultCellStyle = style14;
            this.dataGridViewImageColumnNotNull_1.HeaderText = "";
            this.dataGridViewImageColumnNotNull_1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumnNotNull_1.Name = "dataGridViewImageColumnNotNull1";
            this.dataGridViewImageColumnNotNull_1.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_1.Width = 30;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_5.HeaderText = "id";
            this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_6.HeaderText = "id";
            this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "idList";
            this.dataGridViewTextBoxColumn_7.HeaderText = "idList";
            this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_8.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_9.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "idBusPoint";
            this.dataGridViewTextBoxColumn_10.HeaderText = "idBusPoint";
            this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_10.Visible = false;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "BusPoint";
            this.dataGridViewTextBoxColumn_11.HeaderText = "BusPoint";
            this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn_11.Visible = false;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "BusFullPoint";
            this.dataGridViewTextBoxColumn_12.HeaderText = "BusFullPoint";
            this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.Visible = false;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "idCellPoint";
            this.dataGridViewTextBoxColumn_13.HeaderText = "idCellPoint";
            this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn_13.Visible = false;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "CellPoint";
            this.dataGridViewTextBoxColumn_14.HeaderText = "CellPoint";
            this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn_14.Visible = false;
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "CellFullPoint";
            this.dataGridViewTextBoxColumn_15.HeaderText = "CellFullPoint";
            this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.Visible = false;
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "idSubCP";
            this.dataGridViewTextBoxColumn_16.HeaderText = "idSubCP";
            this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn_16.Visible = false;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "SubCP";
            this.dataGridViewTextBoxColumn_17.HeaderText = "SubCP";
            this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.Visible = false;
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "idBusCP";
            this.dataGridViewTextBoxColumn_18.HeaderText = "idBusCP";
            this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn_18.Visible = false;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "BusCP";
            this.dataGridViewTextBoxColumn_19.HeaderText = "BusCP";
            this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn_19.Visible = false;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "idCellCP";
            this.dataGridViewTextBoxColumn_20.HeaderText = "idCellCP";
            this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn_20.Visible = false;
            this.dataGridViewTextBoxColumn_21.DataPropertyName = "CellCP";
            this.dataGridViewTextBoxColumn_21.HeaderText = "CellCP";
            this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn_21.Visible = false;
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "AttachmentPoint";
            this.dataGridViewTextBoxColumn_22.HeaderText = "Точка присоединения";
            this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "PowerSupply";
            this.dataGridViewTextBoxColumn_23.HeaderText = "Источник питания (наименование питающих линий)";
            this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewTextBoxColumn_24.HeaderText = "Описание точки присоединения";
            this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "voltagelevel";
            this.dataGridViewTextBoxColumn_25.HeaderText = "voltagelevel";
            this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn_25.Visible = false;
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "voltagelevelname";
            this.dataGridViewTextBoxColumn_26.HeaderText = "Уровень напряжения (кВ)";
            this.dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "powersum";
            this.dataGridViewTextBoxColumn_27.HeaderText = "Максимальная мощность (кВт)";
            this.dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn_28.HeaderText = "Величина номинальной мощности присоединенных троансформаторов (кВА)";
            this.dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn_29.HeaderText = "Категория надежности электроснабжения";
            this.dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn_30.HeaderText = "id";
            this.dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.Visible = false;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_31.HeaderText = "id";
            this.dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewTextBoxColumn_31.Visible = false;
            this.dataGridViewTextBoxColumn_32.DataPropertyName = "idList";
            this.dataGridViewTextBoxColumn_32.HeaderText = "idList";
            this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewTextBoxColumn_32.Visible = false;
            this.dataGridViewFilterTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "FileName";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Файл";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_33.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_33.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewTextBoxColumn_33.Visible = false;
            this.dataGridViewTextBoxColumn_34.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_34.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn_34.ReadOnly = true;
            this.dataGridViewTextBoxColumn_34.Visible = false;
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataSetGES_1.DataSetName = "dsAbnDocum";
            this.dataSetGES_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            base.AcceptButton = this.button_3;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_2;
            base.ClientSize = new Size(0x2f5, 0x2d8);
            base.Controls.Add(this.tableLayoutPanel_0);
            base.Name = "FormAbnAktRBP";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Акт разграничения балансовой принадлежности";
            base.FormClosing += new FormClosingEventHandler(this.FormAbnAktRBP_FormClosing);
            base.Load += new EventHandler(this.FormAbnAktRBP_Load);
            base.Shown += new EventHandler(this.FormAbnAktRBP_Shown);
            this.tableLayoutPanel_0.ResumeLayout(false);
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tableLayoutPanel_5.ResumeLayout(false);
            this.tableLayoutPanel_5.PerformLayout();
            this.tabPage_6.ResumeLayout(false);
            this.tabPage_6.PerformLayout();
            ((ISupportInitialize) this.dataGridView_1).EndInit();
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.tabPage_5.ResumeLayout(false);
            this.tableLayoutPanel_2.ResumeLayout(false);
            this.panel_0.ResumeLayout(false);
            this.tableLayoutPanel_6.ResumeLayout(false);
            this.tableLayoutPanel_6.PerformLayout();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            this.dataSetGES_0.EndInit();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.tabPage_1.ResumeLayout(false);
            this.tableLayoutPanel_3.ResumeLayout(false);
            this.tableLayoutPanel_3.PerformLayout();
            this.tabPage_3.ResumeLayout(false);
            this.tableLayoutPanel_4.ResumeLayout(false);
            this.tableLayoutPanel_4.PerformLayout();
            this.tabPage_2.ResumeLayout(false);
            this.tableLayoutPanel_7.ResumeLayout(false);
            this.tableLayoutPanel_7.PerformLayout();
            ((ISupportInitialize) this.pictureBox_0).EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            this.tabPage_4.ResumeLayout(false);
            this.tableLayoutPanel_1.ResumeLayout(false);
            this.tableLayoutPanel_1.PerformLayout();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.dataGridViewExcelFilter_1.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            this.contextMenuStrip_0.ResumeLayout(false);
            this.contextMenuStrip_1.ResumeLayout(false);
            this.dataSetTechConnection_0.EndInit();
            this.dataSetGES_1.EndInit();
            base.ResumeLayout(false);
        }

        [CompilerGenerated]
        private void method_37()
        {
            this.bindingSource_0.ResetBindings(false);
        }

        private void method_4(int int_5)
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_AktRBP, true, string.Format(" where idList = {0}", int_5));
            if (this.dataSetGES_0.tAbnObjDoc_AktRBP.Count > 0)
            {
                this.IdActTehConnection = (this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>()["idActTehConnection"] == DBNull.Value) ? -1 : this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().idActTehConnection;
                this.IdTU = (this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>()["idTU"] == DBNull.Value) ? -1 : this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().idTU;
                this.dateTimePicker_0.Value = DateTime.Parse(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().ActData);
                this.comboBox_0.SelectedValue = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().NetRegion;
                this.textBox_7.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().DataNumber;
                this.textBox_6.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrgFace;
                this.textBox_5.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrgBase;
                this.textBoxDropDown_8.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrgBalance);
                this.textBoxDropDown_1.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().PotrBalance);
                this.textBoxDropDown_0.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().BorderBalance);
                this.textBox_4.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrgExpl;
                this.textBox_3.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().PotrExpl;
                this.textBox_2.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().Responsibility;
                this.textBox_1.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().Admission;
                this.textBox_0.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().PotrSignature;
                this.textBox_21.Text = (this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>()["Other"] == DBNull.Value) ? "" : this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().Other;
                this.textBox_8.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerName;
                this.textBox_10.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerChief;
                this.textBox_9.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerBase;
                this.textBoxDropDown_7.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrganizExpl);
                this.textBoxDropDown_6.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().PotrebExpl);
                this.textBoxDropDown_5.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().BorderExpl);
                this.textBox_11.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerChief2;
                this.textBox_14.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().tbDogByOTONum;
                this.textBox_13.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().tbTO2;
                this.textBox_12.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().tbTO1;
                this.textBox_18.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerName_Four;
                this.textBox_17.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerChief_Four;
                this.textBox_16.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerBase_Four;
                this.textBoxDropDown_4.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OrganizExpl_Four);
                this.textBoxDropDown_2.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().Border2Expl_Four);
                this.textBoxDropDown_3.set_Text(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerExpl_Four);
                this.textBox_15.Text = this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().OwnerChief2_Four;
                if (this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>()["idActRebinding"] != DBNull.Value)
                {
                    this.method_5(this.dataSetGES_0.tAbnObjDoc_AktRBP.First<DataSetGES.Class131>().idActRebinding);
                }
            }
        }

        private void method_5(int int_5)
        {
            DataSetTechConnection.vTC_DocDataTable table = new DataSetTechConnection.vTC_DocDataTable();
            base.SelectSqlData(table, true, "where id = " + int_5.ToString(), false);
            if (table.Rows.Count > 0)
            {
                this.panel_1.Visible = true;
                this.toolStrip_2.Enabled = false;
                this.dataGridView_1.Enabled = false;
                if (table.Rows[0]["numDoc"] != DBNull.Value)
                {
                    this.textBox_23.Text = table.Rows[0]["numDoc"].ToString();
                }
                if (table.Rows[0]["dateDoc"] != DBNull.Value)
                {
                    this.dateTimePicker_1.Value = Convert.ToDateTime(table.Rows[0]["dateDoc"]);
                }
                if (table.Rows[0]["typeDocName"] != DBNull.Value)
                {
                    this.textBox_24.Text = table.Rows[0]["typeDocName"].ToString();
                }
            }
        }

        private void method_6()
        {
            foreach (DataRow row in new SqlDataCommand(this.get_SqlSettings()).SelectSqlData(" SELECT doc.id, doc.FileName  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 3 and doc.deleted = 0").Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem {
                    Text = row["FileName"].ToString(),
                    Tag = row["id"]
                };
                item.Click += new EventHandler(this.method_7);
                this.toolStripDropDownButton_0.DropDownItems.Add(item);
                ToolStripMenuItem item2 = new ToolStripMenuItem {
                    Text = row["FileName"].ToString(),
                    Tag = row["id"]
                };
                item2.Click += new EventHandler(this.method_7);
                this.toolStripMenuItem_3.DropDownItems.Add(item2);
            }
        }

        private void method_7(object sender, EventArgs e)
        {
            string str = "";
            string str2 = "";
            this.method_16(str, str2, sender, true);
        }

        private void method_8()
        {
            DataTable table = base.SelectSqlData("tR_Classifier", true, "WHERE ParentKey = ';NetworkAreas;' AND isGroup = ((0)) AND Deleted = ((0))");
            DataRow row = table.NewRow();
            row["id"] = -1;
            row["Name"] = "";
            row["isGroup"] = 0;
            row["Deleted"] = 0;
            table.Rows.Add(row);
            this.comboBox_0.DataSource = table;
            this.comboBox_0.DisplayMember = "Name";
            this.comboBox_0.ValueMember = "Id";
            this.comboBox_0.SelectedValue = -1;
        }

        private void method_9()
        {
            string connectionString = this.get_SqlSettings().GetConnectionString();
            this.textBoxDropDown_8.set_TextBoxWidth((double) this.elementHost_5.Width);
            this.textBoxDropDown_8.set_Connection(connectionString);
            this.textBoxDropDown_8.set_NumberField(1);
            this.textBoxDropDown_1.set_TextBoxWidth((double) this.elementHost_7.Width);
            this.textBoxDropDown_1.set_Connection(connectionString);
            this.textBoxDropDown_1.set_NumberField(2);
            this.textBoxDropDown_0.set_TextBoxWidth((double) this.elementHost_6.Width);
            this.textBoxDropDown_0.set_Connection(connectionString);
            this.textBoxDropDown_0.set_NumberField(3);
        }

        private void process_0_Exited(object sender, EventArgs e)
        {
            this.process_0.Exited -= new EventHandler(this.process_0_Exited);
        }

        private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.tabControl_0.SelectedTab == this.tabPage_4) && (this.dataSetGES_0.tAbnObjDoc_File.Select<DataSetGES.Class140, bool>((<>c.<>9__93_0 ?? (<>c.<>9__93_0 = new Func<DataSetGES.Class140, bool>(<>c.<>9.method_4)))).Count<bool>() == 0))
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_File, true, "where idList = " + this.IdList.ToString());
            }
            if (this.tabControl_0.SelectedTab == this.tabPage_5)
            {
                this.method_24(this.IdActTehConnection);
            }
        }

        private void textBox_16_TextChanged(object sender, EventArgs e)
        {
            this.bool_1 = this.bool_0;
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_1.CurrentRow != null)
            {
                FormLinkTUAndSchmObj obj2 = new FormLinkTUAndSchmObj(this.dataGridView_1.CurrentRow);
                obj2.set_SqlSettings(this.get_SqlSettings());
                if (obj2.ShowDialog() == DialogResult.OK)
                {
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_62.Name].Value = obj2.idSubPoint;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_63.Name].Value = obj2.SubPoint;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_64.Name].Value = obj2.idBusPoint;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_65.Name].Value = obj2.BusPoint;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_66.Name].Value = obj2.idCellPoint;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_67.Name].Value = obj2.CellPoint;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_68.Name].Value = obj2.idSubCP;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_69.Name].Value = obj2.SubCP;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_70.Name].Value = obj2.idBusCP;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_71.Name].Value = obj2.BusCP;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_72.Name].Value = obj2.idCellCP;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_73.Name].Value = obj2.CellCP;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_74.Name].Value = obj2.idVoltagelevel;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_75.Name].Value = obj2.VoltageLevel;
                    this.dataGridView_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_76.Name].Value = obj2.PowerSum;
                    this.bool_1 = true;
                }
            }
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_1.CurrentRow != null)
            {
                this.dataGridView_1.Rows.Remove(this.dataGridView_1.CurrentRow);
                this.bool_1 = true;
            }
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            if ((this.dataGridView_1.CurrentRow != null) && (this.dataGridView_1.CurrentRow.Index > 0))
            {
                int index = this.dataGridView_1.CurrentRow.Index;
                DataGridViewRow currentRow = this.dataGridView_1.CurrentRow;
                this.dataGridView_1.Rows.Remove(this.dataGridView_1.CurrentRow);
                this.dataGridView_1.Rows.Insert(index - 1, currentRow);
                this.dataGridView_1.FirstDisplayedScrollingRowIndex = index - 1;
                this.dataGridView_1[this.dataGridViewTextBoxColumn_63.Name, index - 1].Selected = true;
                this.dataGridView_1.CurrentCell = this.dataGridView_1[this.dataGridViewTextBoxColumn_63.Name, index - 1];
                this.bool_1 = true;
            }
        }

        private void toolStripButton_13_Click(object sender, EventArgs e)
        {
            if ((this.dataGridView_1.CurrentRow != null) && (this.dataGridView_1.CurrentRow.Index < (this.dataGridView_1.Rows.Count - 1)))
            {
                int index = this.dataGridView_1.CurrentRow.Index;
                DataGridViewRow currentRow = this.dataGridView_1.CurrentRow;
                this.dataGridView_1.Rows.Remove(this.dataGridView_1.CurrentRow);
                this.dataGridView_1.Rows.Insert(index + 1, currentRow);
                this.dataGridView_1.FirstDisplayedScrollingRowIndex = index + 1;
                this.dataGridView_1[this.dataGridViewTextBoxColumn_63.Name, index + 1].Selected = true;
                this.dataGridView_1.CurrentCell = this.dataGridView_1[this.dataGridViewTextBoxColumn_63.Name, index + 1];
                this.bool_1 = true;
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog {
                DefaultExt = ".jpg",
                FileName = "Temp",
                Title = "Сохраните файл с изображением в любой папке"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(this.pictureBox_0.Image, dialog.FileName);
                MessageBox.Show("Изображение успешно сохранено.");
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog {
                DefaultExt = ".jpg",
                FileName = "Temp",
                Title = "Сохраните файл с изображением в любой папке"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(this.pictureBox_0.Image, dialog.FileName);
            }
            if (dialog.FileName != "")
            {
                this.process_0.StartInfo.FileName = dialog.FileName;
                this.process_0.EnableRaisingEvents = true;
                this.process_0.Exited += new EventHandler(this.process_0_Exited);
                this.process_0.Start();
            }
            else
            {
                MessageBox.Show("Отсутствует имя файла!");
            }
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            FormLinkTUAndSchmObj obj2 = new FormLinkTUAndSchmObj();
            obj2.set_SqlSettings(this.get_SqlSettings());
            if (obj2.ShowDialog() == DialogResult.OK)
            {
                object[] values = new object[] { 
                    -1, -1, obj2.idSubPoint, obj2.SubPoint, obj2.idBusPoint, obj2.BusPoint, obj2.idCellPoint, obj2.CellPoint, obj2.idSubCP, obj2.SubCP, obj2.idBusCP, obj2.BusCP, obj2.idCellCP, obj2.CellCP, obj2.idVoltagelevel, obj2.VoltageLevel,
                    obj2.PowerSum
                };
                this.dataGridView_1.Rows.Add(values);
                this.bool_1 = true;
            }
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "JPEG Documents|*.jpg"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap original = new Bitmap(dialog.FileName);
                this.dataRow_1 = this.dataSetGES_0.tAbnObjDoc_Image.NewRow();
                this.dataRow_1["idList"] = this.IdList;
                this.dataRow_1["Scan"] = ImageCompress.GetCompressBytes(original, 30L);
                this.dataSetGES_0.tAbnObjDoc_Image.Rows.Add(this.dataRow_1);
                base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tAbnObjDoc_Image);
                this.dataRow_1.AcceptChanges();
                this.pictureBox_0.Image = ImageCompress.LoadBitmap(dialog.FileName);
                this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
                object[] values = new object[] { new Bitmap(original, 120, 160), ImageCompress.LoadBitmap(dialog.FileName), false };
                this.dataGridViewExcelFilter_0.Rows.Add(values);
                original.Dispose();
                this.bool_1 = true;
            }
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            if (base.DeleteSqlDataById(this.dataSetGES_0.tAbnObjDoc_Image, (int) this.dataGridViewExcelFilter_0.CurrentRow.Cells["id"].Value))
            {
                this.dataGridViewExcelFilter_0.Rows.RemoveAt(this.dataGridViewExcelFilter_0.CurrentRow.Index);
                MessageBox.Show("Изображение удалено..");
                this.bool_1 = true;
            }
            else
            {
                MessageBox.Show("Изображение удалить не удалось..");
            }
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Multiselect = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string str in dialog.FileNames)
                {
                    int? nullable = null;
                    if (!string.IsNullOrEmpty(this.method_21(str, nullable, null, true)))
                    {
                        this.bool_1 = true;
                    }
                }
            }
        }

        private void toolStripMenuItem_5_Click(object sender, EventArgs e)
        {
            this.method_22(true);
        }

        private void toolStripMenuItem_6_Click(object sender, EventArgs e)
        {
            this.method_22(false);
        }

        private void toolStripMenuItem_7_Click(object sender, EventArgs e)
        {
            if ((this.bindingSource_0.Current != null) && (MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                DataSetGES.Class140 row = (DataSetGES.Class140) ((DataRowView) this.bindingSource_0.Current).Row;
                string fileName = row.FileName;
                if (this.dictionary_0.ContainsKey(fileName))
                {
                    if (this.dictionary_0[fileName].get_Watcher() != null)
                    {
                        this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_19));
                        this.dictionary_0[fileName].get_Watcher().Stop();
                    }
                    this.dictionary_0.Remove(fileName);
                }
                row.Delete();
                this.bool_1 = true;
            }
        }

        private void toolStripMenuItem_8_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                this.string_0 = this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name].Value.ToString();
                this.dataGridViewExcelFilter_1.CurrentCell = this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name];
                this.dataGridViewExcelFilter_1.CurrentCell.Value = Path.GetFileNameWithoutExtension(this.string_0);
                this.dataGridViewExcelFilter_1.ReadOnly = false;
                this.dataGridViewFilterTextBoxColumn_0.ReadOnly = false;
                this.dataGridViewExcelFilter_1.BeginEdit(true);
            }
        }

        private void toolStripMenuItem_9_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                DataSetGES.Class140 row = (DataSetGES.Class140) ((DataRowView) this.bindingSource_0.Current).Row;
                if (row["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                        {
                            connection.Open();
                            SqlDataReader reader = new SqlCommand("SELECT [File] FROM tTC_DocFile WHERE id = " + row["id"].ToString(), connection).ExecuteReader();
                            while (reader.Read())
                            {
                                row["File"] = reader["File"];
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                    }
                }
                byte[] file = row.File;
                SaveFileDialog dialog = new SaveFileDialog {
                    FileName = row.FileName
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.ByteArrayToFile(dialog.FileName, file);
                }
            }
        }

        public int IdAbn
        {
            get
            {
                return this.int_3;
            }
            set
            {
                this.int_3 = value;
                if (value == -1)
                {
                    this.textBox_22.Text = "";
                }
                else
                {
                    DataTable table = new DataTable("tAbn");
                    table.Columns.Add("name", typeof(string));
                    base.SelectSqlData(table, true, "where id = " + this.int_3.ToString(), false);
                    if (table.Rows.Count > 0)
                    {
                        this.textBox_22.Text = table.Rows[0]["name"].ToString();
                    }
                    else
                    {
                        this.textBox_22.Text = "";
                    }
                    this.method_12();
                }
            }
        }

        public int IdAbnObj
        {
            get
            {
                return this.int_4;
            }
            set
            {
                if (this.int_4 != value)
                {
                    this.int_4 = value;
                    this.comboBoxReadOnly_0.SelectedValue = this.int_4;
                }
            }
        }

        public int IdActTehConnection
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            set
            {
                this.int_1 = value;
            }
        }

        public int IdList
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            set
            {
                this.int_0 = value;
            }
        }

        public int IdTU
        {
            get
            {
                return this.int_2;
            }
            set
            {
                this.int_2 = value;
                if (value != -1)
                {
                    this.comboBoxReadOnly_0.set_ReadOnly(true);
                    this.button_4.Enabled = false;
                    DataTable table = base.SelectSqlData("vtc_tu", true, "where id = " + this.IdTU.ToString());
                    if (table.Rows.Count > 0)
                    {
                        if (table.Rows[0]["idAbn"] != DBNull.Value)
                        {
                            this.IdAbn = Convert.ToInt32(table.Rows[0]["idAbn"]);
                        }
                        if (table.Rows[0]["idAbnObj"] != DBNull.Value)
                        {
                            this.IdAbnObj = Convert.ToInt32(table.Rows[0]["idAbnobj"]);
                        }
                    }
                }
                else
                {
                    this.comboBoxReadOnly_0.set_ReadOnly(false);
                    this.button_4.Enabled = true;
                }
            }
        }

        private Constants.TypeDocValue TypeDocValue
        {
            get
            {
                return this.typeDocValue_0;
            }
            set
            {
                if (this.typeDocValue_0 != value)
                {
                    this.typeDocValue_0 = value;
                    if (this.get_SqlSettings() != null)
                    {
                        string[] textArray1 = new string[] { ";TypeDoc;tAbnObj;", ((int) this.typeDocValue_0).ToString() };
                        this.nullable_0 = new int?((int) base.CallSQLScalarFunction("dbo.fn_GetIdClassifier", textArray1));
                    }
                    Constants.TypeDocValue value2 = this.typeDocValue_0;
                    if (value2 != 1)
                    {
                        if ((value2 == 4) && this.tabControl_0.TabPages.Contains(this.tabPage_6))
                        {
                            this.tabControl_0.TabPages.Remove(this.tabPage_6);
                        }
                    }
                    else if (!this.tabControl_0.TabPages.Contains(this.tabPage_6))
                    {
                        this.tabControl_0.TabPages.Insert(1, this.tabPage_6);
                    }
                }
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly FormAbnAktRBP.<>c <>9 = new FormAbnAktRBP.<>c();
            public static Func<DataSetGES.Class140, int> <>9__87_2;
            public static Func<DataSetGES.Class140, int> <>9__87_3;
            public static Func<DataSetGES.Class140, bool> <>9__89_0;
            public static Func<DataSetGES.Class140, int> <>9__89_1;
            public static Func<DataSetGES.Class140, bool> <>9__93_0;

            internal int method_0(DataSetGES.Class140 class140_0)
            {
                return class140_0.Int32_0;
            }

            internal int method_1(DataSetGES.Class140 class140_0)
            {
                return class140_0.Int32_0;
            }

            internal bool method_2(DataSetGES.Class140 class140_0)
            {
                return (class140_0.RowState != DataRowState.Deleted);
            }

            internal int method_3(DataSetGES.Class140 class140_0)
            {
                return class140_0.Int32_0;
            }

            internal bool method_4(DataSetGES.Class140 class140_0)
            {
                if ((class140_0.RowState != DataRowState.Added) && (class140_0.RowState != DataRowState.Modified))
                {
                    return (class140_0.RowState == DataRowState.Deleted);
                }
                return true;
            }
        }

        [CompilerGenerated]
        private sealed class Class285
        {
            public FileSystemEventArgs fileSystemEventArgs_0;
            public IEnumerable<KeyValuePair<string, FileWatcherArgsAddl>> ienumerable_0;

            internal bool method_0(KeyValuePair<string, FileWatcherArgsAddl> keyValuePair_0)
            {
                return (keyValuePair_0.Value.get_TempName() == this.fileSystemEventArgs_0.Name);
            }

            internal bool method_1(DataSetGES.Class140 class140_0)
            {
                return ((class140_0.RowState != DataRowState.Deleted) && (class140_0.FileName == this.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_OriginalName()));
            }
        }
    }
}

