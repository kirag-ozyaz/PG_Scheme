    using ControlsLbr.DataGridViewExcelFilter;
    using ControlsLbr.Scheme;
    using DataSql;
    using Documents.Forms.DailyReport.DataSets;
    using Documents.Forms.DailyReport.Reports;
    using FormLbr;
    using SchemeModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using System.Xml;
namespace Documents.Forms.DailyReport.ActDetection
{
    /// <summary>
    /// Журнал актов расследования
    /// </summary>
    public class FormJournalActDetection : FormBase
    {
        private BindingSource bindingSource_0;
        private CheckBox checkBoxWhereSub;
        private ContextMenuStrip contextMenuDamage;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvActDetection;
        private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;
        private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_20;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_21;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_22;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_23;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_24;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_25;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_26;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_27;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataSetDamage dataSetDamage_0;
        private DateTimePicker dtpFilterEnd;
        private DateTimePicker dtpFilterBeg;
        private IContainer components = null;
        private Label label_0;
        private Label label_1;
        private List<int> list_0;
        private SplitContainer splitContainer_0;
        private ToolStrip toolStrip;
        private ToolStrip toolStripFilter;
        private ToolStrip toolStripTreeSchmObj;
        private ToolStripButton toolBtnFilterApply;
        private ToolStripButton toolBtnFilterDelete;
        private ToolStripButton toolBtnRefresh;
        private ToolStripButton toolBtnFind;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripButton toolBtnFindNext;
        private ToolStripButton toolBtnDamageNoApply;
        private ToolStripButton toolBtnExportExcel;
        private ToolStripButton toolBtnPrint;
        private ToolStripButton toolBtnAdd;
        private ToolStripButton toolBtnPrevYear;
        private ToolStripButton toolBtnNextYear;
        private ToolStripButton toolBtnEdit;
        private ToolStripButton toolBtnInfo;
        private ToolStripButton toolBtnFindTreeSchmObj;
        private ToolStripButton toolBtnFindPrevTreeSchmObj;
        private ToolStripButton toolBtnFindNextTreeSchmObj;
        private ToolStripButton toolBtnDel;
        private ToolStripDropDownButton toolBtnReport;
        private ToolStripDropDownButton toolBTnLoadOld;
        private ToolStripMenuItem toolBtnLoadOldDamageLV;
        private ToolStripMenuItem toolBtnLoadOldDefect;
        private ToolStripMenuItem toolBtnLoadAbnDefectLV;
        private ToolStripMenuItem toolBtnLoadOldDamageНV;
        private ToolStripMenuItem toolItemAdd;
        private ToolStripMenuItem toolItemEdit;
        private ToolStripMenuItem toolItemInfo;
        private ToolStripMenuItem toolItemDel;
        private ToolStripMenuItem tsMenuAmergencyShutdown;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripTextBox txtFindTreeSchmObj;
        private ToolStripTextBox txtFind;
        private TreeViewSchmObjects treeViewSchmObjects;

        public FormJournalActDetection()
        {
            this.InitializeComponent();
            this.toolBTnLoadOld.Visible = false;
        }

        public FormJournalActDetection(List<int> checkedSubstation)
        {
            this.InitializeComponent();
            this.list_0 = checkedSubstation;
            this.toolBTnLoadOld.Visible = false;
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            List<int> list = new List<int>();
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                //using (IEnumerator enumerator = node.SelectNodes("CheckDivision").GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                    foreach (IEnumerator enumerator in node.SelectNodes("CheckDivision"))
                    {
                        XmlAttribute attribute2 = ((XmlNode) enumerator.Current).Attributes["Id"];
                        if (attribute2 != null)
                        {
                            list.Add(Convert.ToInt32(attribute2.Value));
                        }
                    }
                //}
                XmlAttribute attribute = node.Attributes["dateBeg"];
                if (attribute.Value != null)
                {
                    this.dtpFilterBeg.Value = Convert.ToDateTime(attribute.Value);
                }
                attribute = node.Attributes["dateEnd"];
                if (attribute.Value != null)
                {
                    this.dtpFilterEnd.Value = Convert.ToDateTime(attribute.Value);
                }
            }
        }

        private void contextMenuDamage_Opening(object sender, CancelEventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                this.toolItemEdit.Enabled = true;
                this.toolItemInfo.Enabled = true;
                this.toolItemDel.Enabled = true;
            }
            else
            {
                this.toolItemEdit.Enabled = false;
                this.toolItemInfo.Enabled = false;
                this.toolItemDel.Enabled = false;
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("dateBeg");
            node.Value = this.dtpFilterBeg.Value.ToString();
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("dateEnd");
            node.Value = this.dtpFilterEnd.Value.ToString();
            node2.Attributes.Append(node);
            return document1;
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                if (this.toolBtnEdit.Enabled && this.toolBtnEdit.Visible)
                {
                    this.toolBtnEdit_Click(sender, e);
                }
                else if (this.toolBtnInfo.Enabled && this.toolBtnInfo.Visible)
                {
                    this.toolBtnInfo_Click(sender, e);
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (((this.dgvActDetection[this.dataGridViewFilterCheckBoxColumn_1.Name, e.RowIndex].Value != DBNull.Value) && (this.dgvActDetection[this.dataGridViewFilterCheckBoxColumn_1.Name, e.RowIndex].Value != null)) && Convert.ToBoolean(this.dgvActDetection[this.dataGridViewFilterCheckBoxColumn_1.Name, e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (((this.dgvActDetection[this.dataGridViewFilterTextBoxColumn_2.Name, e.RowIndex].Value != DBNull.Value) && (this.dgvActDetection[this.dataGridViewFilterTextBoxColumn_2.Name, e.RowIndex].Value != null)) && (Convert.ToDateTime(this.dgvActDetection[this.dataGridViewFilterTextBoxColumn_2.Name, e.RowIndex].Value).Date < DateTime.Now.Date.AddDays(-10.0)))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (e.Button == MouseButtons.Right))
            {
                this.contextMenuDamage.Show(Cursor.Position);
            }
        }

        private void dataGridViewExcelFilter_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvActDetection.AutoResizeRow(e.RowIndex);
        }

        private void dtpFilterEnd_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpFilterEnd.Value < this.dtpFilterBeg.Value)
            {
                this.dtpFilterBeg.Value = this.dtpFilterEnd.Value;
            }
        }

        private void ddtpFilterBeg_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpFilterBeg.Value > this.dtpFilterEnd.Value)
            {
                this.dtpFilterEnd.Value = this.dtpFilterBeg.Value;
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

        private void FormJournalActDetection_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalActDetection_Load(object sender, EventArgs e)
        {
            this.method_5();
            this.method_0();
            base.LoadFormConfig(null);
            this.treeViewSchmObjects.SqlSettings=(this.SqlSettings);
            this.treeViewSchmObjects.Load(this.list_0);
            this.method_4(-1);
        }

        private void method_0()
        {
            this.dtpFilterEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            this.dtpFilterBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.treeViewSchmObjects.ClearTreeChecked();
        }

        private void method_1(int? nullable_0 = new int?(), bool bool_0 = false)
        {
            FormActDetectionAddEdit form = new FormActDetectionAddEdit(nullable_0);
            form.SqlSettings = (this.SqlSettings);
            form.MdiParent = base.MdiParent;
            form.method_1(bool_0);
            if (!bool_0)
            {
                form.FormClosed += new FormClosedEventHandler(this.method_2);
            }
            form.Show();
        }

        private void method_2(object sender, FormClosedEventArgs e)
        {
            if ((sender is Form) && (((Form) sender).DialogResult == DialogResult.OK))
            {
                int num = -1;
                if ((sender is FormActDetectionAddEdit) && ((FormActDetectionAddEdit) sender).method_2().HasValue)
                {
                    num = ((FormActDetectionAddEdit) sender).method_2().Value;
                }
                this.method_4(num);
            }
        }

        private void method_3(int int_0)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("update tj_damage \r\n                                                          set idParent = null\r\n                                                          where idParent = {0} and isApply = 1", int_0);
                        command.ExecuteNonQuery();
                        command.CommandText = string.Format("delete tj_damage \r\n                                                          where idParent = {0} and (isApply = 0 or isApply is null)", int_0.ToString());
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void method_4(int int_0 = -1)
        {
            if ((int_0 == -1) && (this.dgvActDetection.CurrentRow != null))
            {
                int_0 = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.dataGridViewTextBoxColumn_3.Name].Value);
            }
            string str = "select d.*, c_sc.Name as signCrashType, c_sc.Name + ' ' + c_sc.Comment as signCrashName,\r\nc_te.Name as typeEquip, c_te.Name + ' ' + c_te.Comment as typeEquipName,\r\nc_rce.Name as reasonCrashEquipType, c_rce.Name + ' ' + c_rce.Comment as reasonCrashEquipName,\r\nc_rc.Name as reasonCrashType, c_rc.Name + ' ' + c_rc.Comment as reasonCrashName\r\nfrom vJ_Damage as d\r\nleft join tJ_DamageActDetection as dAct on dAct.idDamage = d.id\r\nleft join tR_Classifier as c_sc on c_sc.Id = dAct.idSignCrash\r\nleft join tR_Classifier as c_te on c_te.Id = dAct.idTypeEquipment\r\nleft join tR_Classifier as c_rce on c_rce.Id = dAct.idReasonCrashEquipment\r\nleft join tR_Classifier as c_rc on c_rc.Id = dAct.idReasonCrash\r\n";
            string str2 = "";
            str2 = string.Format(" where (d.deleted = 0) and ((d.dateDoc >= '{0}' and d.dateDoc < '{1}') or d.dateDoc is null)", this.dtpFilterBeg.Value.ToString("yyyyMMdd"), this.dtpFilterEnd.Value.AddDays(1.0).ToString("yyyyMMdd")) + string.Format(" and (d.TypeDoc = {0}) ", 0x752);
            List<int> listChecked = this.treeViewSchmObjects.GetListChecked();
            if (listChecked.Count > 0)
            {
                string str3 = "";
                foreach (int num in listChecked)
                {
                    if (string.IsNullOrEmpty(str3))
                    {
                        str3 = num.ToString();
                    }
                    else
                    {
                        str3 = str3 + "," + num.ToString();
                    }
                }
                if (this.checkBoxWhereSub.Checked)
                {
                    str2 = str2 + string.Format(" and (d.idSchmObj in ({0}) or d.idSub in ({0}))", str3);
                }
                else
                {
                    str2 = str2 + string.Format(" and (d.idSchmObj in ({0}))", str3);
                }
            }
            str = str + str2;
            DataTable table = new SqlDataCommand(this.SqlSettings).SelectSqlData(str);
            this.dgvActDetection.AutoGenerateColumns = false;
            this.bindingSource_0.DataSource = table;
            this.dgvActDetection.SearchGrid(this.dataGridViewTextBoxColumn_3.Name, int_0.ToString(), true);
        }

        private void method_5()
        {
            DataTable table = new DataTable("tUser");
            table.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(table, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;DailyReport;AdminActDetection;' and tuser.login = SYSTEM_USER", null, false, 0);
            if (table.Rows.Count > 0)
            {
                this.toolBtnDamageNoApply.Visible = true;
            }
            else
            {
                this.toolBtnDamageNoApply.Visible = false;
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormJournalActDetection));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            DataGridViewCellStyle style8 = new DataGridViewCellStyle();
            DataGridViewCellStyle style9 = new DataGridViewCellStyle();
            DataGridViewCellStyle style10 = new DataGridViewCellStyle();
            this.toolStrip = new ToolStrip();
            this.toolBtnAdd = new ToolStripButton();
            this.toolBtnEdit = new ToolStripButton();
            this.toolBtnInfo = new ToolStripButton();
            this.toolBtnDel = new ToolStripButton();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolBtnRefresh = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolBtnFind = new ToolStripButton();
            this.txtFind = new ToolStripTextBox();
            this.toolBtnFindPrev = new ToolStripButton();
            this.toolBtnFindNext = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolBtnReport = new ToolStripDropDownButton();
            this.toolBTnLoadOld = new ToolStripDropDownButton();
            this.toolBtnLoadOldDamageLV = new ToolStripMenuItem();
            this.toolBtnLoadOldDefect = new ToolStripMenuItem();
            this.toolBtnLoadAbnDefectLV = new ToolStripMenuItem();
            this.toolBtnLoadOldDamageНV = new ToolStripMenuItem();
            this.toolBtnDamageNoApply = new ToolStripButton();
            this.toolBtnExportExcel = new ToolStripButton();
            this.toolBtnPrint = new ToolStripButton();
            this.splitContainer_0 = new SplitContainer();
            this.checkBoxWhereSub = new CheckBox();
            this.toolStripTreeSchmObj = new ToolStrip();
            this.toolBtnFindTreeSchmObj = new ToolStripButton();
            this.txtFindTreeSchmObj = new ToolStripTextBox();
            this.toolBtnFindPrevTreeSchmObj = new ToolStripButton();
            this.toolBtnFindNextTreeSchmObj = new ToolStripButton();
            this.treeViewSchmObjects = new TreeViewSchmObjects();
            this.dtpFilterEnd = new DateTimePicker();
            this.label_0 = new Label();
            this.dtpFilterBeg = new DateTimePicker();
            this.label_1 = new Label();
            this.toolStripFilter = new ToolStrip();
            this.toolBtnFilterApply = new ToolStripButton();
            this.toolBtnFilterDelete = new ToolStripButton();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolBtnPrevYear = new ToolStripButton();
            this.toolBtnNextYear = new ToolStripButton();
            this.dgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterCheckBoxColumn_1 = new DataGridViewFilterCheckBoxColumn();
            this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_24 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_25 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_26 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_27 = new DataGridViewFilterTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.components);
            this.dataSetDamage_0 = new DataSetDamage();
            this.toolItemAdd = new ToolStripMenuItem();
            this.toolItemEdit = new ToolStripMenuItem();
            this.toolItemInfo = new ToolStripMenuItem();
            this.toolItemDel = new ToolStripMenuItem();
            this.contextMenuDamage = new ContextMenuStrip(this.components);
            this.tsMenuAmergencyShutdown = new ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStripTreeSchmObj.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            ((ISupportInitialize)this.dgvActDetection).BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetDamage_0.BeginInit();
            this.contextMenuDamage.SuspendLayout();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { 
                this.toolBtnAdd, this.toolBtnEdit, this.toolBtnInfo, this.toolBtnDel, this.toolStripSeparator1, this.toolBtnRefresh, this.toolStripSeparator_1, this.toolBtnFind, this.txtFind, this.toolBtnFindPrev, this.toolBtnFindNext, this.toolStripSeparator_2, this.toolBtnReport, this.toolBTnLoadOld, this.toolBtnDamageNoApply, this.toolBtnExportExcel,
                this.toolBtnPrint
            };
            this.toolStrip.Items.AddRange(toolStripItems);
            this.toolStrip.Location = new Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new Size(0x3fe, 0x19);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolBtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnAdd.Image = (Image) resources.GetObject("toolBtnAdd.Image");
            this.toolBtnAdd.Image = global::Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new Size(0x17, 0x16);
            this.toolBtnAdd.Text = "Добавить";
            this.toolBtnAdd.Click += new EventHandler(this.toolItemAdd_Click);
            this.toolBtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ///this.toolBtnEdit.Image = (Image) resources.GetObject("toolBtnEdit.Image");
            this.toolBtnEdit.Image = global::Properties.Resources.ElementEdit;
            this.toolBtnEdit.ImageTransparentColor = Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new Size(0x17, 0x16);
            this.toolBtnEdit.Text = "Редактировать";
            this.toolBtnEdit.Click += new EventHandler(this.toolBtnEdit_Click);
            this.toolBtnInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnInfo.Image = (Image) resources.GetObject("toolBtnInfo.Image");
            this.toolBtnInfo.Image = global::Properties.Resources.ElementInformation;
            this.toolBtnInfo.ImageTransparentColor = Color.Magenta;
            this.toolBtnInfo.Name = "toolBtnInfo";
            this.toolBtnInfo.Size = new Size(0x17, 0x16);
            this.toolBtnInfo.Text = "Информация";
            this.toolBtnInfo.Click += new EventHandler(this.toolBtnInfo_Click);
            this.toolBtnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnDel.Image = (Image) resources.GetObject("toolBtnDel.Image");
            this.toolBtnDel.Image = global::Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new Size(0x17, 0x16);
            this.toolBtnDel.Text = "Удалить документ";
            this.toolBtnDel.Click += new EventHandler(this.toolBtnDel_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(6, 0x19);
            this.toolBtnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnRefresh.Image = (Image) resources.GetObject("toolBtnRefresh.Image");
            this.toolBtnRefresh.Image = global::Properties.Resources.Refresh;
            this.toolBtnRefresh.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new Size(0x17, 0x16);
            this.toolBtnRefresh.Text = "Обновить";
            this.toolBtnRefresh.Click += new EventHandler(this.toolBtnRefresh_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolBtnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnFind.Image = (Image) resources.GetObject("toolBtnFind.Image");
            this.toolBtnFind.Image = global::Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new Size(0x17, 0x16);
            this.toolBtnFind.Text = "Искать";
            this.toolBtnFind.Click += new EventHandler(this.toolBtnFind_Click);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new Size(100, 0x19);
            this.txtFind.ToolTipText = "Текст для поиска";
            this.txtFind.KeyDown += new KeyEventHandler(this.txtFind_KeyDown);
            this.toolBtnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnFindPrev.Image = (Image) resources.GetObject("toolBtnFindPrev.Image");
            this.toolBtnFindPrev.Image = global::Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new Size(0x17, 0x16);
            this.toolBtnFindPrev.Text = "Искать назад";
            this.toolBtnFindPrev.Click += new EventHandler(this.toolBtnFindPrev_Click);
            this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnFindNext.Image = (Image) resources.GetObject("toolBtnFindNext.Image");
            this.toolBtnFindNext.Image = global::Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new Size(0x17, 0x16);
            this.toolBtnFindNext.Text = "Искать вперед";
            this.toolBtnFindNext.Click += new EventHandler(this.toolBtnFindNext_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolBtnReport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.tsMenuAmergencyShutdown };
            this.toolBtnReport.DropDownItems.AddRange(itemArray2);
            //this.toolBtnReport.Image = (Image) resources.GetObject("toolBtnReport.Image");
            this.toolBtnReport.Image = global::Properties.Resources.Report;
            this.toolBtnReport.ImageTransparentColor = Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new Size(0x1d, 0x16);
            this.toolBtnReport.Text = "Отчеты";
            this.toolBTnLoadOld.Alignment = ToolStripItemAlignment.Right;
            this.toolBTnLoadOld.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolBtnLoadOldDamageLV, this.toolBtnLoadOldDefect, this.toolBtnLoadAbnDefectLV, this.toolBtnLoadOldDamageНV };
            this.toolBTnLoadOld.DropDownItems.AddRange(itemArray3);
            //this.toolBTnLoadOld.Image = (Image) resources.GetObject("toolBTnLoadOld.Image");
            this.toolBTnLoadOld.Image = global::Properties.Resources.Load;
            this.toolBTnLoadOld.ImageTransparentColor = Color.Magenta;
            this.toolBTnLoadOld.Name = "toolBTnLoadOld";
            this.toolBTnLoadOld.Size = new Size(0x1d, 0x16);
            this.toolBTnLoadOld.Text = "Загрузка из старой базы";
            this.toolBtnLoadOldDamageLV.Name = "toolBtnLoadOldDamageLV";
            this.toolBtnLoadOldDamageLV.Size = new Size(210, 0x16);
            this.toolBtnLoadOldDamageLV.Text = "0.4кВ";
            this.toolBtnLoadOldDamageLV.Click += new EventHandler(this.toolBtnLoadOldDamageLV_Click);
            this.toolBtnLoadOldDefect.Name = "toolBtnLoadOldDefect";
            this.toolBtnLoadOldDefect.Size = new Size(210, 0x16);
            this.toolBtnLoadOldDefect.Text = "Дефект";
            this.toolBtnLoadOldDefect.Click += new EventHandler(this.toolBtnLoadOldDefect_Click);
            this.toolBtnLoadAbnDefectLV.Name = "toolBtnLoadAbnDefectLV";
            this.toolBtnLoadAbnDefectLV.Size = new Size(210, 0x16);
            this.toolBtnLoadAbnDefectLV.Text = "Загрузить абонентов НН";
            this.toolBtnLoadAbnDefectLV.Click += new EventHandler(this.toolBtnLoadAbnDefectLV_Click);
            this.toolBtnLoadOldDamageНV.Name = "toolBtnLoadOldDamageНV";
            this.toolBtnLoadOldDamageНV.Size = new Size(210, 0x16);
            this.toolBtnLoadOldDamageНV.Text = "ВН";
            this.toolBtnLoadOldDamageНV.Click += new EventHandler(this.toolBtnLoadOldDamageНV_Click);
            this.toolBtnDamageNoApply.Alignment = ToolStripItemAlignment.Right;
            this.toolBtnDamageNoApply.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnDamageNoApply.Image = (Image) resources.GetObject("toolBtnDamageNoApply.Image");
            this.toolBtnDamageNoApply.Image = global::Properties.Resources.ElementAccept;
            this.toolBtnDamageNoApply.ImageTransparentColor = Color.Magenta;
            this.toolBtnDamageNoApply.Name = "toolBtnDamageNoApply";
            this.toolBtnDamageNoApply.Size = new Size(0x17, 0x16);
            this.toolBtnDamageNoApply.Text = "Разблокировать документ";
            this.toolBtnDamageNoApply.Visible = false;
            this.toolBtnDamageNoApply.Click += new EventHandler(this.toolBtnDamageNoApply_Click);
            this.toolBtnExportExcel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolStripButton_15.Image = (Image) resources.GetObject("toolBtnExportExcel.Image");
            this.toolBtnExportExcel.Image = global::Properties.Resources.Excel;
            this.toolBtnExportExcel.ImageTransparentColor = Color.Magenta;
            this.toolBtnExportExcel.Name = "toolBtnExportExcel";
            this.toolBtnExportExcel.Size = new Size(0x17, 0x16);
            this.toolBtnExportExcel.Text = "Экспорт в Excel";
            this.toolBtnExportExcel.Click += new EventHandler(this.toolBtnExportExcel_Click);
            this.toolBtnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolStripButton_16.Image = (Image) resources.GetObject("toolBtnPrint.Image");
            this.toolBtnPrint.Image = global::Properties.Resources.Print;
            this.toolBtnPrint.ImageTransparentColor = Color.Magenta;
            this.toolBtnPrint.Name = "toolBtnPrint";
            this.toolBtnPrint.Size = new Size(0x17, 0x16);
            this.toolBtnPrint.Text = "Печать";
            this.toolBtnPrint.Click += new EventHandler(this.toolStripButton_16_Click);
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer";
            this.splitContainer_0.Panel1.Controls.Add(this.checkBoxWhereSub);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStripTreeSchmObj);
            this.splitContainer_0.Panel1.Controls.Add(this.treeViewSchmObjects);
            this.splitContainer_0.Panel1.Controls.Add(this.dtpFilterEnd);
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dtpFilterBeg);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStripFilter);
            this.splitContainer_0.Panel2.Controls.Add(this.dgvActDetection);
            this.splitContainer_0.Size = new Size(0x3fe, 0x241);
            this.splitContainer_0.SplitterDistance = 0x102;
            this.splitContainer_0.TabIndex = 1;
            this.checkBoxWhereSub.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.checkBoxWhereSub.AutoSize = true;
            this.checkBoxWhereSub.Checked = true;
            this.checkBoxWhereSub.CheckState = CheckState.Checked;
            this.checkBoxWhereSub.Location = new Point(15, 0x22b);
            this.checkBoxWhereSub.Name = "checkBoxWhereSub";
            this.checkBoxWhereSub.Size = new Size(180, 0x11);
            this.checkBoxWhereSub.TabIndex = 12;
            this.checkBoxWhereSub.Text = "Фильтровать по подстанциям";
            this.checkBoxWhereSub.UseVisualStyleBackColor = true;
            this.toolStripTreeSchmObj.Dock = DockStyle.None;
            this.toolStripTreeSchmObj.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolBtnFindTreeSchmObj, this.txtFindTreeSchmObj, this.toolBtnFindPrevTreeSchmObj, this.toolBtnFindNextTreeSchmObj };
            this.toolStripTreeSchmObj.Items.AddRange(itemArray4);
            this.toolStripTreeSchmObj.Location = new Point(15, 0x67);
            this.toolStripTreeSchmObj.Name = "toolStripTreeSchmObj";
            this.toolStripTreeSchmObj.Size = new Size(0xae, 0x19);
            this.toolStripTreeSchmObj.TabIndex = 11;
            this.toolStripTreeSchmObj.Text = "toolStrip1";
            this.toolBtnFindTreeSchmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnFindTreeSchmObj.Image = (Image) resources.GetObject("toolBtnFindTreeSchmObj.Image");
            this.toolBtnFindTreeSchmObj.Image = global::Properties.Resources.Find;
            this.toolBtnFindTreeSchmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindTreeSchmObj.Name = "toolBtnFindTreeSchmObj";
            this.toolBtnFindTreeSchmObj.Size = new Size(0x17, 0x16);
            this.toolBtnFindTreeSchmObj.Text = "Искать";
            this.toolBtnFindTreeSchmObj.Click += new EventHandler(this.toolBtnFindTreeSchmObj_Click);

            this.txtFindTreeSchmObj.Name = "txtFindTreeSchmObj";
            this.txtFindTreeSchmObj.Size = new Size(100, 0x19);
            this.txtFindTreeSchmObj.ToolTipText = "Текст для поиска";
            this.txtFindTreeSchmObj.KeyDown += new KeyEventHandler(this.txtFindTreeSchmObj_KeyDown);

            this.toolBtnFindPrevTreeSchmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnFindPrevTreeSchmObj.Image = (Image) resources.GetObject("toolBtnFindPrevTreeSchmObj.Image");
            this.toolBtnFindPrevTreeSchmObj.Image = global::Properties.Resources.FindPrev;
            this.toolBtnFindPrevTreeSchmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrevTreeSchmObj.Name = "toolBtnFindPrevTreeSchmObj";
            this.toolBtnFindPrevTreeSchmObj.Size = new Size(0x17, 0x16);
            this.toolBtnFindPrevTreeSchmObj.Text = "Искать назад";
            this.toolBtnFindPrevTreeSchmObj.Click += new EventHandler(this.toolBtnFindPrevTreeSchmObj_Click);
            this.toolBtnFindNextTreeSchmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnFindNextTreeSchmObj.Image = (Image) resources.GetObject("toolBtnFindNextTreeSchmObj.Image");
            this.toolBtnFindNextTreeSchmObj.Image = global::Properties.Resources.FindNext;
            this.toolBtnFindNextTreeSchmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNextTreeSchmObj.Name = "toolBtnFindNextTreeSchmObj";
            this.toolBtnFindNextTreeSchmObj.Size = new Size(0x17, 0x16);
            this.toolBtnFindNextTreeSchmObj.Text = "Искать вперед";
            this.toolBtnFindNextTreeSchmObj.Click += new EventHandler(this.toolBtnFindNextTreeSchmObj_Click);
            this.treeViewSchmObjects.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.treeViewSchmObjects.CheckBoxes = true;
            this.treeViewSchmObjects.Location = new Point(12, 0x7e);
            this.treeViewSchmObjects.Name = "treeViewSchmObjects";
            this.treeViewSchmObjects.Size = new Size(0xea, 0x1a7);
            this.treeViewSchmObjects.SqlSettings=(null);
            this.treeViewSchmObjects.TabIndex = 10;
            this.dtpFilterEnd.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpFilterEnd.CausesValidation = false;
            this.dtpFilterEnd.Location = new Point(12, 80);
            this.dtpFilterEnd.Name = "dtpFilterEnd";
            this.dtpFilterEnd.Size = new Size(0xea, 20);
            this.dtpFilterEnd.TabIndex = 4;
            this.dtpFilterEnd.ValueChanged += new EventHandler(this.dtpFilterEnd_ValueChanged);
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0x40);
            this.label_0.Name = "label2";
            this.label_0.Size = new Size(0x16, 13);
            this.label_0.TabIndex = 3;
            this.label_0.Text = "До";
            this.dtpFilterBeg.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpFilterBeg.CausesValidation = false;
            this.dtpFilterBeg.Location = new Point(12, 0x29);
            this.dtpFilterBeg.Name = "dtpFilterBeg";
            this.dtpFilterBeg.Size = new Size(0xea, 20);
            this.dtpFilterBeg.TabIndex = 2;
            this.dtpFilterBeg.ValueChanged += new EventHandler(this.ddtpFilterBeg_ValueChanged);
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x19);
            this.label_1.Name = "label1";
            this.label_1.Size = new Size(20, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "От";
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolBtnFilterApply, this.toolBtnFilterDelete, this.toolStripSeparator_3, this.toolBtnPrevYear, this.toolBtnNextYear };
            this.toolStripFilter.Items.AddRange(itemArray5);
            this.toolStripFilter.Location = new Point(0, 0);
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new Size(0x102, 0x19);
            this.toolStripFilter.TabIndex = 0;
            this.toolStripFilter.Text = "toolStrip1";

            this.toolBtnFilterApply.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnFilterApply.Image = (Image) resources.GetObject("toolBtnFilterApply.Image");
            this.toolBtnFilterApply.Image = global::Properties.Resources.filter;
            this.toolBtnFilterApply.Image = global::Properties.Resources.filter;
            this.toolBtnFilterApply.ImageTransparentColor = Color.Magenta;
            this.toolBtnFilterApply.Name = "toolBtnFilterApply";
            this.toolBtnFilterApply.Size = new Size(0x17, 0x16);
            this.toolBtnFilterApply.Text = "Применить фильтр";
            this.toolBtnFilterApply.Click += new EventHandler(this.toolBtnFilterApply_Click);
            this.toolBtnFilterDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolStripButton_1.Image = (Image) resources.GetObject("toolBtnFilterDelete.Image");
            this.toolBtnFilterDelete.Image = global::Properties.Resources.filter_delete;
            this.toolBtnFilterDelete.ImageTransparentColor = Color.Magenta;
            this.toolBtnFilterDelete.Name = "toolBtnFilterDelete";
            this.toolBtnFilterDelete.Size = new Size(0x17, 0x16);
            this.toolBtnFilterDelete.Text = "Убрать фильтр";
            this.toolBtnFilterDelete.Click += new EventHandler(this.toolBtnFilterDelete_Click);
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(6, 0x19);
            this.toolBtnPrevYear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolStripButton_2.Image = (Image) resources.GetObject("toolBtnPrevYear.Image");
            this.toolBtnPrevYear.Image = global::Properties.Resources.arrowPrev;
            this.toolBtnPrevYear.ImageTransparentColor = Color.Magenta;
            this.toolBtnPrevYear.Name = "toolBtnPrevYear";
            this.toolBtnPrevYear.Size = new Size(0x17, 0x16);
            this.toolBtnPrevYear.Text = "Предыдущий год";
            this.toolBtnPrevYear.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolBtnNextYear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolStripButton_3.Image = (Image) resources.GetObject("toolBtnNextYear.Image");
            this.toolBtnNextYear.Image = global::Properties.Resources.arrowNext;
            this.toolBtnNextYear.ImageTransparentColor = Color.Magenta;
            this.toolBtnNextYear.Name = "toolBtnNextYear";
            this.toolBtnNextYear.Size = new Size(0x17, 0x16);
            this.toolBtnNextYear.Text = "Следующий год";
            this.toolBtnNextYear.Click += new EventHandler(this.toolBtnNextYear_Click);
            this.dgvActDetection.AllowUserToAddRows = false;
            this.dgvActDetection.AllowUserToDeleteRows = false;
            this.dgvActDetection.AllowUserToOrderColumns = true;
            this.dgvActDetection.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvActDetection.AutoGenerateColumns = false;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dgvActDetection.ColumnHeadersDefaultCellStyle = style;
            this.dgvActDetection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewFilterTextBoxColumn_6, this.dataGridViewFilterTextBoxColumn_7, this.dataGridViewFilterTextBoxColumn_8, this.dataGridViewFilterTextBoxColumn_9, this.dataGridViewFilterTextBoxColumn_10, this.dataGridViewFilterCheckBoxColumn_0, this.dataGridViewFilterTextBoxColumn_11, this.dataGridViewFilterCheckBoxColumn_1, this.dataGridViewFilterTextBoxColumn_12, this.dataGridViewFilterTextBoxColumn_13,
                this.dataGridViewFilterTextBoxColumn_14, this.dataGridViewFilterTextBoxColumn_15, this.dataGridViewFilterTextBoxColumn_16, this.dataGridViewFilterTextBoxColumn_17, this.dataGridViewTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_18, this.dataGridViewFilterTextBoxColumn_19, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewFilterTextBoxColumn_20, this.dataGridViewFilterTextBoxColumn_21, this.dataGridViewFilterTextBoxColumn_22, this.dataGridViewFilterTextBoxColumn_23, this.dataGridViewFilterTextBoxColumn_24, this.dataGridViewFilterTextBoxColumn_25,
                this.dataGridViewFilterTextBoxColumn_26, this.dataGridViewFilterTextBoxColumn_27
            };
            this.dgvActDetection.Columns.AddRange(dataGridViewColumns);
            this.dgvActDetection.DataSource = this.bindingSource_0;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dgvActDetection.DefaultCellStyle = style2;
            //this.dgvActDetection.Dock = DockStyle.Fill;
            this.dgvActDetection.Location = new Point(0, 0);
            this.dgvActDetection.Name = "dgvActDetection";
            this.dgvActDetection.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dgvActDetection.RowHeadersDefaultCellStyle = style3;
            this.dgvActDetection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvActDetection.Size = new Size(760, 0x241);
            this.dgvActDetection.TabIndex = 0;
            this.dgvActDetection.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dgvActDetection.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dgvActDetection.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_0_CellMouseClick);
            this.dgvActDetection.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "numrequest";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№ заявки";
            this.dataGridViewFilterTextBoxColumn_0.Name = "numrequestDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "numDoc";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "№ документа";
            this.dataGridViewFilterTextBoxColumn_1.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "dateDoc";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Дата заявки";
            this.dataGridViewFilterTextBoxColumn_2.Name = "dateDocDgvColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "TypeDocName";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Тип";
            this.dataGridViewFilterTextBoxColumn_3.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.Visible = false;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Division";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Подразделение";
            this.dataGridViewFilterTextBoxColumn_4.Name = "divisionDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.Visible = false;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "schmObjName";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Электроустановка";
            this.dataGridViewFilterTextBoxColumn_5.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_5.Width = 200;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "NetRegionSub";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Сетевой район";
            this.dataGridViewFilterTextBoxColumn_6.Name = "netRegionSubDgvColumn";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "numcrash";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Номер аварии";
            this.dataGridViewFilterTextBoxColumn_7.Name = "numcrashDgvColumn";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "defectLocation";
            style4.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.DefaultCellStyle = style4;
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Место повреждения";
            this.dataGridViewFilterTextBoxColumn_8.Name = "defectLocationDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.Visible = false;
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "Reason";
            style5.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.DefaultCellStyle = style5;
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Причина";
            this.dataGridViewFilterTextBoxColumn_9.Name = "reasonDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.Visible = false;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "DivisionApply";
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_10.DefaultCellStyle = style6;
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Подразделение исполнитель";
            this.dataGridViewFilterTextBoxColumn_10.Name = "divisionApplyDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_10.Visible = false;
            this.dataGridViewFilterCheckBoxColumn_0.DataPropertyName = "isLaboratory";
            this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "ПЛ";
            this.dataGridViewFilterCheckBoxColumn_0.Name = "isLaboratoryDgvColumn";
            this.dataGridViewFilterCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterCheckBoxColumn_0.Visible = false;
            this.dataGridViewFilterCheckBoxColumn_0.Width = 40;
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "dateApply";
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Дата устранения";
            this.dataGridViewFilterTextBoxColumn_11.Name = "dateApplyDgvColumn";
            this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_11.Visible = false;
            this.dataGridViewFilterCheckBoxColumn_1.DataPropertyName = "isApply";
            this.dataGridViewFilterCheckBoxColumn_1.HeaderText = "Выполнено";
            this.dataGridViewFilterCheckBoxColumn_1.Name = "isApplyDgvColumn";
            this.dataGridViewFilterCheckBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterCheckBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterCheckBoxColumn_1.SortMode=(DataGridViewColumnSortMode.NotSortable);
            this.dataGridViewFilterCheckBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "workerApply";
            this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Выполнил";
            this.dataGridViewFilterTextBoxColumn_12.Name = "workerApplyDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_12.Visible = false;
            this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "completedWork";
            style7.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_13.DefaultCellStyle = style7;
            this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Выполненная работа";
            this.dataGridViewFilterTextBoxColumn_13.Name = "completedWorkDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_13.Visible = false;
            this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "compiler";
            this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Составитель";
            this.dataGridViewFilterTextBoxColumn_14.Name = "compilerDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_14.Visible = false;
            this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "Instruction";
            style8.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_15.DefaultCellStyle = style8;
            this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Указания";
            this.dataGridViewFilterTextBoxColumn_15.Name = "InstructionDgvColumn";
            this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_15.Visible = false;
            this.dataGridViewFilterTextBoxColumn_15.Width = 120;
            this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "ownerName";
            this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Автор";
            this.dataGridViewFilterTextBoxColumn_16.Name = "nameOwnerDgvColumn";
            this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_16.Visible = false;
            this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "dateOwner";
            this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Дата создания";
            this.dataGridViewFilterTextBoxColumn_17.Name = "dateOwnerDgvColumn";
            this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_17.Visible = false;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "ComletedWorkText";
            style9.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_0.DefaultCellStyle = style9;
            this.dataGridViewTextBoxColumn_0.HeaderText = "Выполненная работа текст";
            this.dataGridViewTextBoxColumn_0.Name = "comletedWorkTextDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "KodPTS";
            style10.Format = "N0";
            style10.NullValue = null;
            this.dataGridViewFilterTextBoxColumn_18.DefaultCellStyle = style10;
            this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Код повреждения";
            this.dataGridViewFilterTextBoxColumn_18.Name = "KodPTSDgvColumn";
            this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_18.Visible = false;
            this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "KodPTSStr";
            this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Код повреждения (стр)";
            this.dataGridViewFilterTextBoxColumn_19.Name = "kodPTSStrDgvColumn";
            this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_19.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_19.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idParent";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Родитель";
            this.dataGridViewTextBoxColumn_1.Name = "idParentDgvColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_2.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_2.Name = "typeDocDgvColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_3.HeaderText = "id";
            this.dataGridViewTextBoxColumn_3.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "signCrashType";
            this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Код учетного признака аварии";
            this.dataGridViewFilterTextBoxColumn_20.Name = "signCrashTypeDgvActDetection";
            this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_20.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "signCrashName";
            this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Учетный признак аварии";
            this.dataGridViewFilterTextBoxColumn_21.Name = "signCrashNameDgvActDetection";
            this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_21.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "typeEquip";
            this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Код оборудования";
            this.dataGridViewFilterTextBoxColumn_22.Name = "typeEquipDgvActDetection";
            this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_22.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "typeEquipName";
            this.dataGridViewFilterTextBoxColumn_23.HeaderText = "Вид оборудования";
            this.dataGridViewFilterTextBoxColumn_23.Name = "typeEquipNameDgvActDetection";
            this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_23.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_24.DataPropertyName = "reasonCrashEquipType";
            this.dataGridViewFilterTextBoxColumn_24.HeaderText = "Код технической причины";
            this.dataGridViewFilterTextBoxColumn_24.Name = "reasonCrashEquipTypeDgvActDetection";
            this.dataGridViewFilterTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_24.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_25.DataPropertyName = "reasonCrashEquipName";
            this.dataGridViewFilterTextBoxColumn_25.HeaderText = "Техническая причина";
            this.dataGridViewFilterTextBoxColumn_25.Name = "reasonCrashEquipNameDgvActDetection";
            this.dataGridViewFilterTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_25.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_26.DataPropertyName = "reasonCrashType";
            this.dataGridViewFilterTextBoxColumn_26.HeaderText = "Код организ. причины аварии";
            this.dataGridViewFilterTextBoxColumn_26.Name = "reasonCrashTypeDgvActDetection";
            this.dataGridViewFilterTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_26.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_27.DataPropertyName = "reasonCrashName";
            this.dataGridViewFilterTextBoxColumn_27.HeaderText = "Организ. причина аварии";
            this.dataGridViewFilterTextBoxColumn_27.Name = "reasonCrashNameDgvActDetection";
            this.dataGridViewFilterTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_27.Resizable = DataGridViewTriState.True;
            this.bindingSource_0.DataMember = "vJ_Damage";
            this.bindingSource_0.DataSource = this.dataSetDamage_0;
            this.dataSetDamage_0.DataSetName = "DataSetDamage";
            this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            //this.toolItemAdd.Image = (Image) resources.GetObject("toolItemAdd.Image");
            this.toolItemAdd.Image = global::Properties.Resources.ElementAdd;
            this.toolItemAdd.Name = "toolItemAdd";
            this.toolItemAdd.Size = new Size(0x87, 0x1a);
            this.toolItemAdd.Text = "Добавить";
            this.toolItemAdd.Click += new EventHandler(this.toolItemAdd_Click);
            
            //this.toolStripMenuItem_5.Image = (Image) resources.GetObject("toolItemEdit.Image");
            this.toolItemEdit.Image = global::Properties.Resources.ElementEdit;
            this.toolItemEdit.Name = "toolItemEdit";
            this.toolItemEdit.Size = new Size(0x87, 0x1a);
            this.toolItemEdit.Text = "Изменить";
            this.toolItemEdit.Click += new EventHandler(this.toolBtnEdit_Click);

            //this.toolStripMenuItem_6.Image = (Image) resources.GetObject("toolItemInfo.Image");
            this.toolItemInfo.Image = global::Properties.Resources.ElementInformation;
            this.toolItemInfo.Name = "toolItemInfo";
            this.toolItemInfo.Size = new Size(0x87, 0x1a);
            this.toolItemInfo.Text = "Просмотр";
            this.toolItemInfo.Click += new EventHandler(this.toolBtnInfo_Click);

            //this.toolStripMenuItem_7.Image = (Image) resources.GetObject("toolItemDel.Image");
            this.toolItemDel.Image = global::Properties.Resources.ElementDel;
            this.toolItemDel.Name = "toolItemDel";
            this.toolItemDel.Size = new Size(0x87, 0x1a);
            this.toolItemDel.Text = "Удалить";
            this.toolItemDel.Click += new EventHandler(this.toolBtnDel_Click);

            this.contextMenuDamage.ImageScalingSize = new Size(20, 20);
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolItemAdd, this.toolItemEdit, this.toolItemInfo, this.toolItemDel };
            this.contextMenuDamage.Items.AddRange(itemArray6);
            this.contextMenuDamage.Name = "contextMenuDamage";
            this.contextMenuDamage.Size = new Size(0x88, 0x6c);
            this.contextMenuDamage.Opening += new CancelEventHandler(this.contextMenuDamage_Opening);
            this.tsMenuAmergencyShutdown.Name = "tsMenuAmergencyShutdown";
            this.tsMenuAmergencyShutdown.Size = new Size(270, 0x16);
            this.tsMenuAmergencyShutdown.Text = "Бюллетень аварийных отключений";
            this.tsMenuAmergencyShutdown.Click += new EventHandler(this.tsMenuAmergencyShutdown_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3fe, 0x25a);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip);
            base.Name = "FormJournalActDetection";
            this.Text = "Журнал актов расследования";
            base.FormClosed += new FormClosedEventHandler(this.FormJournalActDetection_FormClosed);
            base.Load += new EventHandler(this.FormJournalActDetection_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.toolStripTreeSchmObj.ResumeLayout(false);
            this.toolStripTreeSchmObj.PerformLayout();
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            ((ISupportInitialize) this.dgvActDetection).EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetDamage_0.EndInit();
            this.contextMenuDamage.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolBtnFilterApply_Click(object sender, EventArgs e)
        {
            this.method_4(-1);
        }

        private void toolBtnFilterDelete_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.dgvActDetection.ClearFilter();
            this.method_4(-1);
        }

        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            this.method_4(-1);
        }

        private void toolBtnFind_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.txtFind.Text);
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
        }

        private void toolBtnDamageNoApply_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                if (((this.dgvActDetection.CurrentRow.Cells[this.dataGridViewFilterCheckBoxColumn_1.Name].Value != DBNull.Value) && (this.dgvActDetection.CurrentRow.Cells[this.dataGridViewFilterCheckBoxColumn_1.Name].Value != null)) && Convert.ToBoolean(this.dgvActDetection.CurrentRow.Cells[this.dataGridViewFilterCheckBoxColumn_1.Name].Value))
                {
                    if (MessageBox.Show("Вы действительно хотите разблокировать текущий документ?", "Разблокировка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int num = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.dataGridViewTextBoxColumn_3.Name].Value);
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand())
                                {
                                    command.Connection = connection;
                                    command.CommandText = string.Format("update tj_damage \r\n                                                                  set isapply = 0\r\n                                                                   where id = {0}", num);
                                    if (command.ExecuteNonQuery() > 0)
                                    {
                                        this.method_4(-1);
                                    }
                                }
                                connection.Close();
                                MessageBox.Show("Документ успешно разблокирован");
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.Source);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Документ уже разблокирован");
                }
            }
        }

        private void toolBtnExportExcel_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.ExportToExcel();
        }

        private void toolStripButton_16_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.PrintDataGridView();
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            this.dtpFilterBeg.Value = new DateTime(this.dtpFilterBeg.Value.Year - 1, this.dtpFilterBeg.Value.Month, this.dtpFilterBeg.Value.Day);
            this.dtpFilterEnd.Value = new DateTime(this.dtpFilterEnd.Value.Year - 1, this.dtpFilterEnd.Value.Month, this.dtpFilterEnd.Value.Day);
        }

        private void toolBtnNextYear_Click(object sender, EventArgs e)
        {
            this.dtpFilterEnd.Value = new DateTime(this.dtpFilterEnd.Value.Year + 1, this.dtpFilterEnd.Value.Month, this.dtpFilterEnd.Value.Day);
            this.dtpFilterBeg.Value = new DateTime(this.dtpFilterBeg.Value.Year + 1, this.dtpFilterBeg.Value.Month, this.dtpFilterBeg.Value.Day);
        }

        private void toolBtnFindTreeSchmObj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
            {
                this.treeViewSchmObjects.Find(this.txtFindTreeSchmObj.Text);
            }
        }

        private void toolBtnFindPrevTreeSchmObj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
            {
                this.treeViewSchmObjects.FindPrev(this.txtFindTreeSchmObj.Text);
            }
        }

        private void toolBtnFindNextTreeSchmObj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
            {
                this.treeViewSchmObjects.FindNext(this.txtFindTreeSchmObj.Text);
            }
        }

        private void toolBtnLoadOldDamageLV_Click(object sender, EventArgs e)
        {
            LoadOldDamageLV.Load(this.SqlSettings, new SQLSettings("ulges-sql", "SR4", "WINDOWS", "", ""));
            this.method_4(-1);
        }

        private void toolBtnLoadOldDefect_Click(object sender, EventArgs e)
        {
            ImportOldDefectExcel.Load(this.SqlSettings);
            this.method_4(-1);
        }

        private void toolBtnLoadAbnDefectLV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                {
                    try
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        try
                        {
                            DataTable dataTable = new DataTable();
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = connection;
                                command.Transaction = transaction;
                                command.CommandText = "select d.id, d.idSchmObj, d.dateDoc, dLv.iddamage, dlv.abnOff from tj_damage d\r\n\t                                                left join tj_damagelv dlv on dlv.iddamage = d.id\r\n                                                where d.typeDoc = 1401\r\n\t                                                    and d.idSchmObj is not null\r\n\t                                                    and d.datedoc >= '20150101'\r\n\t                                                    and dlv.abnOff is null\r\n                                            and d.id not in (48483, 48485, 48487,48615,48888,48897)";
                                new SqlDataAdapter(command).Fill(dataTable);
                            }
                            //using (IEnumerator enumerator = dataTable.Rows.GetEnumerator())
                            //{
                            //    while (enumerator.MoveNext())
                            //    {
                            //        Class351 class2 = new Class351 {
                            //            dataRow_0 = (DataRow) enumerator.Current
                            //        };
                                    foreach (DataRow dataRow_0 in dataTable.Rows)
                                    {
                                        if (dataRow_0["dateDoc"] != DBNull.Value)
                                    {
                                        ElectricModel model = new ElectricModel();
                                        model.SqlSettings = (this.SqlSettings);
                                        model.LoadSchema(Convert.ToDateTime(dataRow_0["dateDoc"]));
                                        model.PoweringReportForDrawObject(Convert.ToInt32(dataRow_0["idSchmObj"]), true);
                                    // IEnumerable<ElectricObject> source = model.Objects.Where<ElectricObject>(new Func<ElectricObject, bool>(class2.method_0));
                                    IEnumerable<ElectricObject> source = model.Objects.Where((ElectricObject r) => r.Id == Convert.ToInt32(dataRow_0["idSchmObj"]));
                                    if (source.Count<ElectricObject>() > 0)
                                        {
                                            List<ElectricObject> list = model.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
                                            DataSet set = new DataSet();
                                            DataTable table = new DataTable("vL_SchmAbnFull");
                                            table.Columns.Add("idAbn", typeof(int));
                                            table.Columns.Add("idAbnObj", typeof(int));
                                            set.Tables.Add(table);
                                            if (list.Count > 0)
                                            {
                                                string str = "";
                                                foreach (ElectricObject obj2 in list)
                                                {
                                                    if (string.IsNullOrEmpty(str))
                                                    {
                                                        str = obj2.Id.ToString();
                                                    }
                                                    else
                                                    {
                                                        str = str + "," + obj2.Id.ToString();
                                                    }
                                                }
                                            //base.SelectSqlData(set, table.TableName, true, " where idSchmObj in (" + str + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
                                            base.SelectSqlData(table, true, " where idSchmObj in (" + str + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
                                        }
                                            else
                                            {
                                                table.Clear();
                                            }
                                            DataTable table3 = new DataTable("tj_damagelv");
                                            DataColumn column = table3.Columns.Add("idDamage", typeof(int));
                                            table3.Columns.Add("abnoff", typeof(string));
                                            table3.PrimaryKey = new DataColumn[] { column };
                                            base.SelectSqlData(table3, true, "where iddamage = " + dataRow_0["id"].ToString(), null, false, 0);
                                            if (table3.Rows.Count == 0)
                                            {
                                                DataRow row = table3.NewRow();
                                                row["idDamage"] = dataRow_0["id"];
                                                row["abnOff"] = CreateReferenceTables.CreateXmlAbnOff(table).InnerXml;
                                                table3.Rows.Add(row);
                                                base.InsertSqlData(table3);
                                            }
                                            else
                                            {
                                                table3.Rows[0]["abnOff"] = CreateReferenceTables.CreateXmlAbnOff(table).InnerXml;
                                                table3.Rows[0].EndEdit();
                                                base.UpdateSqlData(table3);
                                            }
                                        }
                                    }
                                }
                            //}
                            transaction.Commit();
                        }
                        catch (Exception exception)
                        {
                            transaction.Rollback();
                            MessageBox.Show(exception.Message, exception.Source);
                        }
                    }
                    catch (Exception exception2)
                    {
                        MessageBox.Show(exception2.Message, exception2.Source);
                    }
                }
            }
            catch (Exception exception3)
            {
                MessageBox.Show(exception3.Message, exception3.Source);
            }
        }

        private void toolBtnLoadOldDamageНV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImportOldData.ImportOldDamage(dialog.FileName, this.SqlSettings);
            }
        }

        private void toolItemAdd_Click(object sender, EventArgs e)
        {
            this.method_1(null, false);
        }

        private void toolBtnEdit_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                DataRow row = ((DataRowView) this.bindingSource_0.Current).Row;
                this.method_1(new int?(Convert.ToInt32(row["id"])), false);
            }
        }

        private void toolBtnInfo_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                DataRow row = ((DataRowView) this.bindingSource_0.Current).Row;
                this.method_1(new int?(Convert.ToInt32(row["id"])), true);
            }
        }

        private void toolBtnDel_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                if (((this.dgvActDetection.CurrentRow.Cells[this.dataGridViewFilterCheckBoxColumn_1.Name].Value != DBNull.Value) && (this.dgvActDetection.CurrentRow.Cells[this.dataGridViewFilterCheckBoxColumn_1.Name].Value != null)) && Convert.ToBoolean(this.dgvActDetection.CurrentRow.Cells[this.dataGridViewFilterCheckBoxColumn_1.Name].Value))
                {
                    MessageBox.Show("Невозможно удалить исполненный документ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (MessageBox.Show("Вы действительно хотите удалить выбранный документ и подчиненные данному документу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int num = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.dataGridViewTextBoxColumn_3.Name].Value);
                    if (base.DeleteSqlDataById(this.dataSetDamage_0.tJ_Damage, num))
                    {
                        this.method_3(num);
                        this.method_4(-1);
                        MessageBox.Show("Документ успешно удален");
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран документ для удаления");
            }
        }

        private void tsMenuAmergencyShutdown_Click(object sender, EventArgs e)
        {
            FormReportDetectionCrash crash1 = new FormReportDetectionCrash();
            crash1.SqlSettings = (this.SqlSettings);
            crash1.MdiParent = base.MdiParent;
            crash1.Show();
        }

        private void txtFindTreeSchmObj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Keys modifiers = e.Modifiers;
                if (modifiers != Keys.None)
                {
                    if ((modifiers == Keys.Shift) && !string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
                    {
                        this.treeViewSchmObjects.FindPrev(this.txtFindTreeSchmObj.Text);
                    }
                }
                else if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
                {
                    this.treeViewSchmObjects.FindNext(this.txtFindTreeSchmObj.Text);
                }
            }
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.None)
                {
                    this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
                }
                if (e.Modifiers == Keys.Shift)
                {
                    this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
                }
            }
        }

        //[CompilerGenerated]
        //private sealed class Class351
        //{
        //    public DataRow dataRow_0;

        //    internal bool method_0(ElectricObject electricObject_0)
        //    {
        //        return (electricObject_0.get_Id() == Convert.ToInt32(this.dataRow_0["idSchmObj"]));
        //    }
        //}
    }
}

