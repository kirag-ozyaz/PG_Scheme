using ControlsLbr;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
/// <summary>
/// Настройки отправки почты (смс)
/// </summary>
internal class FormDamageSettingMail : FormBase
{
    private Button buttonSave;
    private Button buttonClose;
    private CheckBox chkSendMail;
    private DataColumn dataColumn_0;
    private DataColumn dataColumn_1;
    private DataColumn dataColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataSet dataSet_0;
    private DataTable dataTable_0;
    private GroupBox groupBoxSender;
    private GroupBox groupBoxSMTP;
    private IContainer components = null;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private Label label_6;
    private NumericUpDown txtSMTPServerPortPlanned;
    private const string string_0 = "DamageMail";
    private TextBox txtSenderNamePlanned;
    private TextBox txtSenderAddressPlanned;
    private TextBox txtPwdSMTPPlanned;
    private TextBox txtLoginSMTPPlanned;
    private TextBox txtSMTPServerPlanned;
    private ToolStrip toolStrip_0;
    private ToolStripButton toolBtnEdit;
    private ToolStripButton toolBtnDel;
    private ToolStripDropDownButton toolBtnAdd;
    private ToolStripMenuItem toolMenuItemTagAdd;
    private ToolStripMenuItem toolMenuItemDivisionAdd;
    private ToolStripMenuItem toolMenuItemContactAdd;
    private TreeDataGridView dgvTree;
    private TreeGridColumn treeGridColumn_0;

    internal FormDamageSettingMail()
    {
        this.InitializeComponent();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        if (this.dataTable_0.Rows.Count == 0)
        {
            DataRow row = this.dataTable_0.NewRow();
            this.dataTable_0.Rows.Add(row);
        }
        this.dataTable_0.Rows[0]["Settings"] = this.method_1().InnerXml;
        this.dataTable_0.Rows[0]["Module"] = "DamageMail";
        this.dataTable_0.Rows[0].EndEdit();
        if (base.InsertSqlData(this.dataTable_0) && base.UpdateSqlData(this.dataTable_0))
        {
            base.Close();
        }
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void chkSendMail_CheckedChanged(object sender, EventArgs e)
    {
        this.groupBoxSender.Enabled = this.groupBoxSMTP.Enabled = this.dgvTree.Enabled = this.chkSendMail.Checked;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormDamageSettingMail_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataTable_0, true, string.Format("where module = '{0}'", "DamageMail"), null, false, 0);
        if (this.dataTable_0.Rows.Count > 0)
        {
            this.method_0();
        }
    }

    private void method_0()
    {
        if ((this.dataTable_0.Rows.Count > 0) && (this.dataTable_0.Rows[0]["Settings"] != DBNull.Value))
        {
            XmlDocument document1 = new XmlDocument();
            document1.LoadXml(this.dataTable_0.Rows[0]["Settings"].ToString());
            XmlNode node = document1.SelectSingleNode("DamageMail");
            if (node != null)
            {
                XmlAttribute attribute = node.Attributes["useMail"];
                if (attribute != null)
                {
                    this.chkSendMail.Checked = Convert.ToBoolean(attribute.Value);
                }
                XmlNode node2 = node.SelectSingleNode("SMTP");
                if (node2 != null)
                {
                    attribute = node2.Attributes["Name"];
                    if (attribute != null)
                    {
                        this.txtSMTPServerPlanned.Text = attribute.Value;
                    }
                    attribute = node2.Attributes["Port"];
                    if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                    {
                        this.txtSMTPServerPortPlanned.Value = Convert.ToInt32(attribute.Value);
                    }
                    attribute = node2.Attributes["Login"];
                    if (attribute != null)
                    {
                        this.txtLoginSMTPPlanned.Text = attribute.Value;
                    }
                    attribute = node2.Attributes["Pwd"];
                    if (attribute != null)
                    {
                        this.txtPwdSMTPPlanned.Text = attribute.Value;
                    }
                }
                XmlNode node3 = node.SelectSingleNode("Sender");
                if (node3 != null)
                {
                    attribute = node3.Attributes["Address"];
                    if (attribute != null)
                    {
                        this.txtSenderAddressPlanned.Text = attribute.Value;
                    }
                    attribute = node3.Attributes["Name"];
                    if (attribute != null)
                    {
                        this.txtSenderNamePlanned.Text = attribute.Value;
                    }
                }
            }
            DataTable table = Class198.smethod_1(document1, this.SqlSettings);
            this.method_2(table);
        }
    }

    private XmlDocument method_1()
    {
        XmlDocument document = new XmlDocument();
        XmlNode newChild = document.CreateElement("DamageMail");
        document.AppendChild(newChild);
        XmlAttribute node = document.CreateAttribute("useMail");
        node.Value = this.chkSendMail.Checked.ToString();
        newChild.Attributes.Append(node);
        XmlNode node2 = document.CreateElement("SMTP");
        newChild.AppendChild(node2);
        node = document.CreateAttribute("Name");
        node.Value = this.txtSMTPServerPlanned.Text;
        node2.Attributes.Append(node);
        node = document.CreateAttribute("Port");
        node.Value = this.txtSMTPServerPortPlanned.Value.ToString();
        node2.Attributes.Append(node);
        node = document.CreateAttribute("Login");
        node.Value = this.txtLoginSMTPPlanned.Text;
        node2.Attributes.Append(node);
        node = document.CreateAttribute("Pwd");
        node.Value = this.txtPwdSMTPPlanned.Text;
        node2.Attributes.Append(node);
        XmlNode node3 = document.CreateElement("Sender");
        newChild.AppendChild(node3);
        node = document.CreateAttribute("Address");
        node.Value = this.txtSenderAddressPlanned.Text;
        node3.Attributes.Append(node);
        node = document.CreateAttribute("Name");
        node.Value = this.txtSenderNamePlanned.Text;
        node3.Attributes.Append(node);
        XmlNode node4 = document.CreateElement("Recipients");
        newChild.AppendChild(node4);
        foreach (TreeDataGridViewNode node5 in this.dgvTree.Nodes)
        {
            XmlNode node6 = document.CreateElement("TagName");
            node4.AppendChild(node6);
            node = document.CreateAttribute("TagName");
            node.Value = node5.Cells[0].Value.ToString();
            node6.Attributes.Append(node);
            foreach (TreeDataGridViewNode node7 in node5.Nodes)
            {
                XmlNode node8 = document.CreateElement("Division");
                node6.AppendChild(node8);
                node = document.CreateAttribute("DivName");
                node.Value = node7.Cells[0].Value.ToString();
                node8.Attributes.Append(node);
                node = document.CreateAttribute("DivId");
                node.Value = node7.Cells[1].Value.ToString();
                node8.Attributes.Append(node);
                foreach (TreeDataGridViewNode node9 in node7.Nodes)
                {
                    XmlNode node10 = document.CreateElement("Contact");
                    node8.AppendChild(node10);
                    node = document.CreateAttribute("FIO");
                    node.Value = node9.Cells[2].Value.ToString();
                    node10.Attributes.Append(node);
                    node = document.CreateAttribute("IdWorker");
                    node.Value = node9.Cells[3].Value.ToString();
                    node10.Attributes.Append(node);
                    node = document.CreateAttribute("Contact");
                    node.Value = node9.Cells[4].Value.ToString();
                    node10.Attributes.Append(node);
                }
            }
        }
        return document;
    }

    private void method_2(DataTable dataTable_1)
    {
        this.dgvTree.Nodes.Clear();
        string str = "";
        int? nullable = null;
        TreeDataGridViewNode node = null;
        TreeDataGridViewNode node2 = null;
        foreach (DataRow row in dataTable_1.Rows)
        {
            if (row["Tag"].ToString() != str)
            {
                str = row["Tag"].ToString();
                node = this.dgvTree.Nodes.Add(str);
                nullable = null;
                node2 = null;
            }
            if (row["DivId"] != DBNull.Value)
            {
                int? nullable2 = nullable;
                if (((Convert.ToInt32(row["divId"]) == nullable2.GetValueOrDefault()) ? !nullable2.HasValue : true) && (node != null))
                {
                    nullable = new int?(Convert.ToInt32(Convert.ToInt32(row["divId"])));
                    object[] objArray1 = new object[] { row["DivName"].ToString(), nullable };
                    node2 = node.Nodes.Add(objArray1);
                }
            }
            if ((row["idWorker"] != DBNull.Value) && (node2 != null))
            {
                object[] objArray2 = new object[] { "", "", row["FIO"].ToString(), Convert.ToInt32(row["idWorker"]), row["Contact"].ToString() };
                node2.Nodes.Add(objArray2);
            }
        }
    }

    private void InitializeComponent()
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDamageSettingMail));
        this.chkSendMail = new CheckBox();
        this.label_0 = new Label();
        this.groupBoxSender = new GroupBox();
        this.label_1 = new Label();
        this.txtSenderNamePlanned = new TextBox();
        this.label_2 = new Label();
        this.txtSenderAddressPlanned = new TextBox();
        this.groupBoxSMTP = new GroupBox();
        this.label_3 = new Label();
        this.txtPwdSMTPPlanned = new TextBox();
        this.label_4 = new Label();
        this.txtLoginSMTPPlanned = new TextBox();
        this.label_5 = new Label();
        this.txtSMTPServerPortPlanned = new NumericUpDown();
        this.label_6 = new Label();
        this.txtSMTPServerPlanned = new TextBox();
        this.buttonSave = new Button();
        this.buttonClose = new Button();
        this.dataSet_0 = new DataSet();
        this.dataTable_0 = new DataTable();
        this.dataColumn_0 = new DataColumn();
        this.dataColumn_1 = new DataColumn();
        this.dataColumn_2 = new DataColumn();
        this.dgvTree = new TreeDataGridView();
        this.treeGridColumn_0 = new TreeGridColumn();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        this.toolStrip_0 = new ToolStrip();
        this.toolBtnAdd = new ToolStripDropDownButton();
        this.toolMenuItemTagAdd = new ToolStripMenuItem();
        this.toolMenuItemDivisionAdd = new ToolStripMenuItem();
        this.toolMenuItemContactAdd = new ToolStripMenuItem();
        this.toolBtnEdit = new ToolStripButton();
        this.toolBtnDel = new ToolStripButton();
        this.groupBoxSender.SuspendLayout();
        this.groupBoxSMTP.SuspendLayout();
        this.txtSMTPServerPortPlanned.BeginInit();
        this.dataSet_0.BeginInit();
        this.dataTable_0.BeginInit();
        ((ISupportInitialize)this.dgvTree).BeginInit();
        this.toolStrip_0.SuspendLayout();
        base.SuspendLayout();
        this.chkSendMail.AutoSize = true;
        this.chkSendMail.Location = new Point(12, 12);
        this.chkSendMail.Name = "chkSendMail";
        this.chkSendMail.Size = new Size(0x74, 0x11);
        this.chkSendMail.TabIndex = 0;
        this.chkSendMail.Text = "Отправлять почту";
        this.chkSendMail.UseVisualStyleBackColor = true;
        this.chkSendMail.CheckedChanged += new EventHandler(this.chkSendMail_CheckedChanged);
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(9, 0xbf);
        this.label_0.Name = "label27";
        this.label_0.Size = new Size(0x61, 13);
        this.label_0.TabIndex = 0x20;
        this.label_0.Text = "Тэги получателей";
        this.groupBoxSender.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.groupBoxSender.Controls.Add(this.label_1);
        this.groupBoxSender.Controls.Add(this.txtSenderNamePlanned);
        this.groupBoxSender.Controls.Add(this.label_2);
        this.groupBoxSender.Controls.Add(this.txtSenderAddressPlanned);
        this.groupBoxSender.Location = new Point(3, 0x72);
        this.groupBoxSender.Name = "groupBoxSender";
        this.groupBoxSender.Size = new Size(0x322, 0x4a);
        this.groupBoxSender.TabIndex = 0x1f;
        this.groupBoxSender.TabStop = false;
        this.groupBoxSender.Text = "Отправитель";
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(6, 0x30);
        this.label_1.Name = "label26";
        this.label_1.Size = new Size(0x1d, 13);
        this.label_1.TabIndex = 4;
        this.label_1.Text = "Имя";
        this.txtSenderNamePlanned.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.txtSenderNamePlanned.Location = new Point(80, 0x2d);
        this.txtSenderNamePlanned.Name = "txtSenderNamePlanned";
        this.txtSenderNamePlanned.Size = new Size(0x2cc, 20);
        this.txtSenderNamePlanned.TabIndex = 3;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(6, 0x16);
        this.label_2.Name = "label25";
        this.label_2.Size = new Size(0x26, 13);
        this.label_2.TabIndex = 2;
        this.label_2.Text = "Адрес";
        this.txtSenderAddressPlanned.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.txtSenderAddressPlanned.Location = new Point(80, 0x13);
        this.txtSenderAddressPlanned.Name = "txtSenderAddressPlanned";
        this.txtSenderAddressPlanned.Size = new Size(0x2cc, 20);
        this.txtSenderAddressPlanned.TabIndex = 1;
        this.groupBoxSMTP.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.groupBoxSMTP.Controls.Add(this.label_3);
        this.groupBoxSMTP.Controls.Add(this.txtPwdSMTPPlanned);
        this.groupBoxSMTP.Controls.Add(this.label_4);
        this.groupBoxSMTP.Controls.Add(this.txtLoginSMTPPlanned);
        this.groupBoxSMTP.Controls.Add(this.label_5);
        this.groupBoxSMTP.Controls.Add(this.txtSMTPServerPortPlanned);
        this.groupBoxSMTP.Controls.Add(this.label_6);
        this.groupBoxSMTP.Controls.Add(this.txtSMTPServerPlanned);
        this.groupBoxSMTP.Location = new Point(3, 0x23);
        this.groupBoxSMTP.Name = "groupBoxSMTP";
        this.groupBoxSMTP.Size = new Size(0x322, 0x49);
        this.groupBoxSMTP.TabIndex = 30;
        this.groupBoxSMTP.TabStop = false;
        this.groupBoxSMTP.Text = "SMTP-сервер (сервер отправки)";
        this.label_3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(0x260, 0x30);
        this.label_3.Name = "label24";
        this.label_3.Size = new Size(0x2d, 13);
        this.label_3.TabIndex = 7;
        this.label_3.Text = "Пароль";
        this.txtPwdSMTPPlanned.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.txtPwdSMTPPlanned.Location = new Point(0x293, 0x2d);
        this.txtPwdSMTPPlanned.Name = "txtPwdSMTPPlanned";
        this.txtPwdSMTPPlanned.PasswordChar = '*';
        this.txtPwdSMTPPlanned.Size = new Size(0x89, 20);
        this.txtPwdSMTPPlanned.TabIndex = 6;
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(6, 0x30);
        this.label_4.Name = "label23";
        this.label_4.Size = new Size(0x26, 13);
        this.label_4.TabIndex = 5;
        this.label_4.Text = "Логин";
        this.txtLoginSMTPPlanned.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.txtLoginSMTPPlanned.Location = new Point(80, 0x2d);
        this.txtLoginSMTPPlanned.Name = "txtLoginSMTPPlanned";
        this.txtLoginSMTPPlanned.Size = new Size(0x20a, 20);
        this.txtLoginSMTPPlanned.TabIndex = 4;
        this.label_5.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(0x2a7, 0x16);
        this.label_5.Name = "label22";
        this.label_5.Size = new Size(0x20, 13);
        this.label_5.TabIndex = 3;
        this.label_5.Text = "Порт";
        this.txtSMTPServerPortPlanned.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.txtSMTPServerPortPlanned.Location = new Point(0x2cd, 0x13);
        int[] bits = new int[4];
        bits[0] = 0xf423f;
        this.txtSMTPServerPortPlanned.Maximum = new decimal(bits);
        this.txtSMTPServerPortPlanned.Name = "txtSMTPServerPortPlanned";
        this.txtSMTPServerPortPlanned.Size = new Size(0x4f, 20);
        this.txtSMTPServerPortPlanned.TabIndex = 2;
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(6, 0x16);
        this.label_6.Name = "label21";
        this.label_6.Size = new Size(0x4a, 13);
        this.label_6.TabIndex = 1;
        this.label_6.Text = "Имя сервера";
        this.txtSMTPServerPlanned.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.txtSMTPServerPlanned.Location = new Point(80, 0x13);
        this.txtSMTPServerPlanned.Name = "txtSMTPServerPlanned";
        this.txtSMTPServerPlanned.Size = new Size(0x251, 20);
        this.txtSMTPServerPlanned.TabIndex = 0;
        this.buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.buttonSave.Location = new Point(12, 0x160);
        this.buttonSave.Name = "buttonSave";
        this.buttonSave.Size = new Size(0x4b, 0x17);
        this.buttonSave.TabIndex = 0x22;
        this.buttonSave.Text = "Сохранить";
        this.buttonSave.UseVisualStyleBackColor = true;
        this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
        this.buttonClose.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.buttonClose.Location = new Point(720, 0x160);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new Size(0x4b, 0x17);
        this.buttonClose.TabIndex = 0x24;
        this.buttonClose.Text = "Закрыть";
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
        this.dataSet_0.DataSetName = "NewDataSet";
        DataTable[] tables = new DataTable[] { this.dataTable_0 };
        this.dataSet_0.Tables.AddRange(tables);
        DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2 };
        this.dataTable_0.Columns.AddRange(columns);
        Constraint[] constraints = new Constraint[1];
        string[] columnNames = new string[] { "id" };
        constraints[0] = new UniqueConstraint("Constraint1", columnNames, true);
        this.dataTable_0.Constraints.AddRange(constraints);
        this.dataTable_0.PrimaryKey = new DataColumn[] { this.dataColumn_0 };
        this.dataTable_0.TableName = "tSettings";
        this.dataColumn_0.AllowDBNull = false;
        this.dataColumn_0.AutoIncrement = true;
        this.dataColumn_0.ColumnName = "id";
        this.dataColumn_0.DataType = typeof(int);
        this.dataColumn_1.ColumnName = "settings";
        this.dataColumn_2.ColumnName = "module";
        this.dgvTree.AllowUserToAddRows = false;
        this.dgvTree.AllowUserToDeleteRows = false;
        this.dgvTree.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.treeGridColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3 };
        this.dgvTree.Columns.AddRange(dataGridViewColumns);
        this.dgvTree.EditMode = DataGridViewEditMode.EditProgrammatically;
        this.dgvTree.ImageList=(null);
        this.dgvTree.Location = new Point(3, 0xe8);
        this.dgvTree.MultiSelect = false;
        this.dgvTree.Name = "dgvTree";
        this.dgvTree.Size = new Size(0x322, 0x72);
        this.dgvTree.TabIndex = 0x25;
        this.treeGridColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.treeGridColumn_0.DefaultNodeImage=(null);
        this.treeGridColumn_0.HeaderText = @"Тэг\Подразделение";
        this.treeGridColumn_0.Name = "tagColumn";
        this.treeGridColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.dataGridViewTextBoxColumn_0.HeaderText = "idDivision";
        this.dataGridViewTextBoxColumn_0.Name = "idDivisionColumn";
        this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.dataGridViewTextBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_1.HeaderText = "ФИО";
        this.dataGridViewTextBoxColumn_1.Name = "workerColumn";
        this.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.dataGridViewTextBoxColumn_2.HeaderText = "idWorker";
        this.dataGridViewTextBoxColumn_2.Name = "idWorkerColumn";
        this.dataGridViewTextBoxColumn_2.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.dataGridViewTextBoxColumn_2.Visible = false;
        this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_3.HeaderText = "Контакт";
        this.dataGridViewTextBoxColumn_3.Name = "contactColumn";
        this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.toolStrip_0.Dock = DockStyle.None;
        this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolBtnAdd, this.toolBtnEdit, this.toolBtnDel };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.Location = new Point(13, 0xcc);
        this.toolStrip_0.Name = "toolStrip1";
        this.toolStrip_0.Size = new Size(0x4e, 0x19);
        this.toolStrip_0.TabIndex = 0x26;
        this.toolStrip_0.Text = "toolStrip1";
        this.toolBtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
        ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolMenuItemTagAdd, this.toolMenuItemDivisionAdd, this.toolMenuItemContactAdd };
        this.toolBtnAdd.DropDownItems.AddRange(itemArray2);
        this.toolBtnAdd.Image = (Image) resources.GetObject("toolBtnAdd.Image");
        this.toolBtnAdd.ImageTransparentColor = Color.Magenta;
        this.toolBtnAdd.Name = "toolBtnAdd";
        this.toolBtnAdd.Size = new Size(0x1d, 0x16);
        this.toolBtnAdd.Text = "Добавить";
        this.toolMenuItemTagAdd.Name = "toolMenuItemTagAdd";
        this.toolMenuItemTagAdd.Size = new Size(0x9f, 0x16);
        this.toolMenuItemTagAdd.Text = "Тэг";
        this.toolMenuItemTagAdd.Click += new EventHandler(this.toolMenuItemTagAdd_Click);
        this.toolMenuItemDivisionAdd.Name = "toolMenuItemDivisionAdd";
        this.toolMenuItemDivisionAdd.Size = new Size(0x9f, 0x16);
        this.toolMenuItemDivisionAdd.Text = "Подразделение";
        this.toolMenuItemDivisionAdd.Click += new EventHandler(this.toolMenuItemDivisionAdd_Click);
        this.toolMenuItemContactAdd.Name = "toolMenuItemContactAdd";
        this.toolMenuItemContactAdd.Size = new Size(0x9f, 0x16);
        this.toolMenuItemContactAdd.Text = "Контакт";
        this.toolMenuItemContactAdd.Click += new EventHandler(this.toolMenuItemContactAdd_Click);
        this.toolBtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolBtnEdit.Image = (Image) resources.GetObject("toolBtnEdit.Image");
        this.toolBtnEdit.ImageTransparentColor = Color.Magenta;
        this.toolBtnEdit.Name = "toolBtnEdit";
        this.toolBtnEdit.Size = new Size(0x17, 0x16);
        this.toolBtnEdit.Text = "Редактировать";
        this.toolBtnEdit.Click += new EventHandler(this.toolBtnEdit_Click);
        this.toolBtnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolBtnDel.Image = (Image) resources.GetObject("toolBtnDel.Image");
        this.toolBtnDel.ImageTransparentColor = Color.Magenta;
        this.toolBtnDel.Name = "toolBtnDel";
        this.toolBtnDel.Size = new Size(0x17, 0x16);
        this.toolBtnDel.Text = "Удалить";
        this.toolBtnDel.Click += new EventHandler(this.toolBtnDel_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(810, 0x183);
        base.Controls.Add(this.toolStrip_0);
        base.Controls.Add(this.dgvTree);
        base.Controls.Add(this.buttonClose);
        base.Controls.Add(this.buttonSave);
        base.Controls.Add(this.label_0);
        base.Controls.Add(this.groupBoxSender);
        base.Controls.Add(this.groupBoxSMTP);
        base.Controls.Add(this.chkSendMail);
        base.Name = "FormDamageSettingMail";
        this.Text = "Настройки отправки почты (смс)";
        base.Load += new EventHandler(this.FormDamageSettingMail_Load);
        this.groupBoxSender.ResumeLayout(false);
        this.groupBoxSender.PerformLayout();
        this.groupBoxSMTP.ResumeLayout(false);
        this.groupBoxSMTP.PerformLayout();
        this.txtSMTPServerPortPlanned.EndInit();
        this.dataSet_0.EndInit();
        this.dataTable_0.EndInit();
        ((ISupportInitialize)this.dgvTree).EndInit();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void toolBtnEdit_Click(object sender, EventArgs e)
    {
        if (this.dgvTree.CurrentRow == null)
        {
            MessageBox.Show("Выберите строку для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(this.dgvTree.CurrentRow);
            FormTagContactAddEdit.SelectTypeFieldContact enum2 = FormTagContactAddEdit.SelectTypeFieldContact.Tag;
            switch (nodeForRow.Level)
            {
                case 1:
                    enum2 = FormTagContactAddEdit.SelectTypeFieldContact.Tag;
                    break;

                case 2:
                    enum2 = FormTagContactAddEdit.SelectTypeFieldContact.Division;
                    break;

                case 3:
                    enum2 = FormTagContactAddEdit.SelectTypeFieldContact.Contact;
                    break;
            }
            FormTagContactAddEdit form = new FormTagContactAddEdit(FormTagContactAddEdit.EditMode.Edit, enum2, nodeForRow);
            form.SqlSettings=(this.SqlSettings);
            if (form.ShowDialog() == DialogResult.OK)
            {
                switch (nodeForRow.Level)
                {
                    case 1:
                        nodeForRow.Cells[0].Value = form.method_0();
                        return;

                    case 2:
                        nodeForRow.Cells[0].Value = form.method_1();
                        nodeForRow.Cells[1].Value = form.method_2();
                        return;

                    case 3:
                        nodeForRow.Cells[2].Value = form.method_3();
                        nodeForRow.Cells[3].Value = form.method_4();
                        nodeForRow.Cells[4].Value = form.method_5();
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private void toolBtnDel_Click(object sender, EventArgs e)
    {
        if (this.dgvTree.CurrentRow != null)
        {
            TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(this.dgvTree.CurrentRow);
            if (nodeForRow.Parent == null)
            {
                this.dgvTree.Nodes.Remove(nodeForRow);
            }
            else
            {
                nodeForRow.Parent.Nodes.Remove(nodeForRow);
            }
        }
    }

    private void toolMenuItemTagAdd_Click(object sender, EventArgs e)
    {
        FormTagContactAddEdit form = new FormTagContactAddEdit(FormTagContactAddEdit.EditMode.Add, FormTagContactAddEdit.SelectTypeFieldContact.Tag, null);
        form.SqlSettings=(this.SqlSettings);
        if (form.ShowDialog() == DialogResult.OK)
        {
            this.dgvTree.Nodes.Add(form.method_0());
        }
    }

    private void toolMenuItemDivisionAdd_Click(object sender, EventArgs e)
    {
        if (this.dgvTree.CurrentRow == null)
        {
            MessageBox.Show("Невозможно добавить подразделение. Сначала добавьте тэг.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(this.dgvTree.CurrentRow);
            FormTagContactAddEdit form = new FormTagContactAddEdit(FormTagContactAddEdit.EditMode.Add, FormTagContactAddEdit.SelectTypeFieldContact.Division, nodeForRow);
            form.SqlSettings=(this.SqlSettings);
            if (form.ShowDialog() == DialogResult.OK)
            {
                switch (nodeForRow.Level)
                {
                    case 1:
                    {
                        object[] objArray1 = new object[] { form.method_1(), form.method_2() };
                        nodeForRow.Nodes.Add(objArray1);
                        return;
                    }
                    case 2:
                    {
                        object[] objArray2 = new object[] { form.method_1(), form.method_2() };
                        nodeForRow.Parent.Nodes.Add(objArray2);
                        return;
                    }
                    case 3:
                    {
                        object[] objArray3 = new object[] { form.method_1(), form.method_2() };
                        nodeForRow.Parent.Parent.Nodes.Add(objArray3);
                        break;
                    }
                    default:
                        return;
                }
            }
        }
    }

    private void toolMenuItemContactAdd_Click(object sender, EventArgs e)
    {
        if (this.dgvTree.CurrentRow == null)
        {
            MessageBox.Show("Невозможно добавить контакт. Сначала добавьте тэг и подразделение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(this.dgvTree.CurrentRow);
            if (nodeForRow.Level == 1)
            {
                MessageBox.Show("Невозможно добавить контакт. Выберите подразделение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                FormTagContactAddEdit form = new FormTagContactAddEdit(FormTagContactAddEdit.EditMode.Add, FormTagContactAddEdit.SelectTypeFieldContact.Contact, nodeForRow);
                form.SqlSettings=(this.SqlSettings);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    switch (nodeForRow.Level)
                    {
                        case 2:
                        {
                            object[] objArray2 = new object[] { "", "", form.method_3(), form.method_4(), form.method_5() };
                            nodeForRow.Nodes.Add(objArray2);
                            break;
                        }
                        case 3:
                        {
                            object[] objArray1 = new object[] { "", "", form.method_3(), form.method_4(), form.method_5() };
                            nodeForRow.Parent.Nodes.Add(objArray1);
                            break;
                        }
                    }
                }
            }
        }
    }
}

