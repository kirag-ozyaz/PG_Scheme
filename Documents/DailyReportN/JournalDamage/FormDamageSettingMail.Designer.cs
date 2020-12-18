using ControlsLbr;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormDamageSettingMail : global::FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}
    private System.ComponentModel.IContainer components = null;

    private void InitializeComponent()
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDamageSettingMail));
        this.chkSendMail = new CheckBox();
        this.label27 = new Label();
        this.groupBoxSender = new GroupBox();
        this.label26 = new Label();
        this.txtSenderNamePlanned = new TextBox();
        this.label25 = new Label();
        this.txtSenderAddressPlanned = new TextBox();
        this.groupBoxSMTP = new GroupBox();
        this.label24 = new Label();
        this.txtPwdSMTPPlanned = new TextBox();
        this.label23 = new Label();
        this.txtLoginSMTPPlanned = new TextBox();
        this.label22 = new Label();
        this.txtSMTPServerPortPlanned = new NumericUpDown();
        this.label21 = new Label();
        this.txtSMTPServerPlanned = new TextBox();
        this.buttonSave = new Button();
        this.buttonClose = new Button();
        this.dataSet1 = new DataSet();
        this.tSettings = new DataTable();
        this.dataColumnid = new DataColumn();
        this.dataColumnsettings = new DataColumn();
        this.dataColumnmodule = new DataColumn();
        this.dgvTree = new TreeDataGridView();
        this.tagColumn = new TreeGridColumn();
        this.idDivisionColumn = new DataGridViewTextBoxColumn();
        this.workerColumn = new DataGridViewTextBoxColumn();
        this.idWorkerColumn = new DataGridViewTextBoxColumn();
        this.contactColumn = new DataGridViewTextBoxColumn();
        this.toolStrip1 = new ToolStrip();
        this.toolBtnAdd = new ToolStripDropDownButton();
        this.toolMenuItemTagAdd = new ToolStripMenuItem();
        this.toolMenuItemDivisionAdd = new ToolStripMenuItem();
        this.toolMenuItemContactAdd = new ToolStripMenuItem();
        this.toolBtnEdit = new ToolStripButton();
        this.toolBtnDel = new ToolStripButton();
        this.groupBoxSender.SuspendLayout();
        this.groupBoxSMTP.SuspendLayout();
        ((ISupportInitialize)this.txtSMTPServerPortPlanned).BeginInit();
        ((ISupportInitialize)this.dataSet1).BeginInit();
        ((ISupportInitialize)this.tSettings).BeginInit();
        ((ISupportInitialize)this.dgvTree).BeginInit();
        this.toolStrip1.SuspendLayout();
        base.SuspendLayout();
        this.chkSendMail.AutoSize = true;
        this.chkSendMail.Location = new Point(12, 12);
        this.chkSendMail.Name = "chkSendMail";
        this.chkSendMail.Size = new Size(116, 17);
        this.chkSendMail.TabIndex = 0;
        this.chkSendMail.Text = "Отправлять почту";
        this.chkSendMail.UseVisualStyleBackColor = true;
        this.chkSendMail.CheckedChanged += new System.EventHandler( this.chkSendMail_CheckedChanged);
        this.label27.AutoSize = true;
        this.label27.Location = new Point(9, 191);
        this.label27.Name = "label27";
        this.label27.Size = new Size(97, 13);
        this.label27.TabIndex = 32;
        this.label27.Text = "Тэги получателей";
        this.groupBoxSender.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        this.groupBoxSender.Controls.Add(this.label26);
        this.groupBoxSender.Controls.Add(this.txtSenderNamePlanned);
        this.groupBoxSender.Controls.Add(this.label25);
        this.groupBoxSender.Controls.Add(this.txtSenderAddressPlanned);
        this.groupBoxSender.Location = new Point(3, 114);
        this.groupBoxSender.Name = "groupBoxSender";
        this.groupBoxSender.Size = new Size(802, 74);
        this.groupBoxSender.TabIndex = 31;
        this.groupBoxSender.TabStop = false;
        this.groupBoxSender.Text = "Отправитель";
        this.label26.AutoSize = true;
        this.label26.Location = new Point(6, 48);
        this.label26.Name = "label26";
        this.label26.Size = new Size(29, 13);
        this.label26.TabIndex = 4;
        this.label26.Text = "Имя";
        this.txtSenderNamePlanned.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        this.txtSenderNamePlanned.Location = new Point(80, 45);
        this.txtSenderNamePlanned.Name = "txtSenderNamePlanned";
        this.txtSenderNamePlanned.Size = new Size(716, 20);
        this.txtSenderNamePlanned.TabIndex = 3;
        this.label25.AutoSize = true;
        this.label25.Location = new Point(6, 22);
        this.label25.Name = "label25";
        this.label25.Size = new Size(38, 13);
        this.label25.TabIndex = 2;
        this.label25.Text = "Адрес";
        this.txtSenderAddressPlanned.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        this.txtSenderAddressPlanned.Location = new Point(80, 19);
        this.txtSenderAddressPlanned.Name = "txtSenderAddressPlanned";
        this.txtSenderAddressPlanned.Size = new Size(716, 20);
        this.txtSenderAddressPlanned.TabIndex = 1;
        this.groupBoxSMTP.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        this.groupBoxSMTP.Controls.Add(this.label24);
        this.groupBoxSMTP.Controls.Add(this.txtPwdSMTPPlanned);
        this.groupBoxSMTP.Controls.Add(this.label23);
        this.groupBoxSMTP.Controls.Add(this.txtLoginSMTPPlanned);
        this.groupBoxSMTP.Controls.Add(this.label22);
        this.groupBoxSMTP.Controls.Add(this.txtSMTPServerPortPlanned);
        this.groupBoxSMTP.Controls.Add(this.label21);
        this.groupBoxSMTP.Controls.Add(this.txtSMTPServerPlanned);
        this.groupBoxSMTP.Location = new Point(3, 35);
        this.groupBoxSMTP.Name = "groupBoxSMTP";
        this.groupBoxSMTP.Size = new Size(802, 73);
        this.groupBoxSMTP.TabIndex = 30;
        this.groupBoxSMTP.TabStop = false;
        this.groupBoxSMTP.Text = "SMTP-сервер (сервер отправки)";
        this.label24.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
        this.label24.AutoSize = true;
        this.label24.Location = new Point(608, 48);
        this.label24.Name = "label24";
            this.label24.Size = new Size(45, 13);
        this.label24.TabIndex = 7;
        this.label24.Text = "Пароль";
        this.txtPwdSMTPPlanned.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
        this.txtPwdSMTPPlanned.Location = new Point(659, 45);
        this.txtPwdSMTPPlanned.Name = "txtPwdSMTPPlanned";
        this.txtPwdSMTPPlanned.PasswordChar = '*';
        this.txtPwdSMTPPlanned.Size = new Size(137, 20);
        this.txtPwdSMTPPlanned.TabIndex = 6;
        this.label23.AutoSize = true;
        this.label23.Location = new Point(6, 48);
        this.label23.Name = "label23";
        this.label23.Size = new Size(38, 13);
        this.label23.TabIndex = 5;
        this.label23.Text = "Логин";
        this.txtLoginSMTPPlanned.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        this.txtLoginSMTPPlanned.Location = new Point(80, 45);
        this.txtLoginSMTPPlanned.Name = "txtLoginSMTPPlanned";
        this.txtLoginSMTPPlanned.Size = new Size(522, 20);
        this.txtLoginSMTPPlanned.TabIndex = 4;
        this.label22.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
        this.label22.AutoSize = true;
        this.label22.Location = new Point(679, 22);
        this.label22.Name = "label22";
        this.label22.Size = new Size(32, 13);
        this.label22.TabIndex = 3;
        this.label22.Text = "Порт";
        this.txtSMTPServerPortPlanned.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
        this.txtSMTPServerPortPlanned.Location = new Point(717, 19);
                    //NumericUpDown numericUpDown = this.txtSMTPServerPortPlanned;
                    int[] array = new int[4];
                    array[0] = 999999;
                    //numericUpDown.Maximum = new decimal(array);
                    txtSMTPServerPortPlanned.Maximum = new decimal(array);
        this.txtSMTPServerPortPlanned.Name = "txtSMTPServerPortPlanned";
        this.txtSMTPServerPortPlanned.Size = new Size(79, 20);
        this.txtSMTPServerPortPlanned.TabIndex = 2;
        this.label21.AutoSize = true;
        this.label21.Location = new Point(6, 22);
        this.label21.Name = "label21";
        this.label21.Size = new Size(74, 13);
        this.label21.TabIndex = 1;
        this.label21.Text = "Имя сервера";
        this.txtSMTPServerPlanned.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        this.txtSMTPServerPlanned.Location = new Point(80, 19);
        this.txtSMTPServerPlanned.Name = "txtSMTPServerPlanned";
        this.txtSMTPServerPlanned.Size = new Size(593, 20);
        this.txtSMTPServerPlanned.TabIndex = 0;
        this.buttonSave.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        this.buttonSave.Location = new Point(12, 352);
        this.buttonSave.Name = "buttonSave";
        this.buttonSave.Size = new Size(75, 23);
        this.buttonSave.TabIndex = 34;
        this.buttonSave.Text = "Сохранить";
        this.buttonSave.UseVisualStyleBackColor = true;
        this.buttonSave.Click += new System.EventHandler( this.buttonSave_Click);
        this.buttonClose.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        this.buttonClose.Location = new Point(720, 352);
        this.buttonClose.Name = "buttonClose";
        this.buttonClose.Size = new Size(75, 23);
        this.buttonClose.TabIndex = 36;
        this.buttonClose.Text = "Закрыть";
        this.buttonClose.UseVisualStyleBackColor = true;
        this.buttonClose.Click +=new System.EventHandler( this.buttonClose_Click);
        this.dataSet1.DataSetName = "NewDataSet";
        this.dataSet1.Tables.AddRange(new DataTable[]
        {
            this.tSettings
        });
        this.tSettings.Columns.AddRange(new DataColumn[]
        {
            this.dataColumnid,
            this.dataColumnsettings,
            this.dataColumnmodule
        });
        this.tSettings.Constraints.AddRange(new Constraint[]
        {
            new UniqueConstraint("Constraint1", new string[]
            {
                "id"
            }, true)
        });
        this.tSettings.PrimaryKey = new DataColumn[]
        {
            this.dataColumnid
        };
        this.tSettings.TableName = "tSettings";
        this.dataColumnid.AllowDBNull = false;
        this.dataColumnid.AutoIncrement = true;
        this.dataColumnid.ColumnName = "id";
        this.dataColumnid.DataType = typeof(int);
        this.dataColumnsettings.ColumnName = "settings";
        this.dataColumnmodule.ColumnName = "module";
        this.dgvTree.AllowUserToAddRows = false;
        this.dgvTree.AllowUserToDeleteRows = false;
        this.dgvTree.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        this.dgvTree.Columns.AddRange(new DataGridViewColumn[]
        {
            this.tagColumn,
            this.idDivisionColumn,
            this.workerColumn,
            this.idWorkerColumn,
            this.contactColumn
        });
        this.dgvTree.EditMode = DataGridViewEditMode.EditProgrammatically;
        this.dgvTree.ImageList = null;
        this.dgvTree.Location = new Point(3, 232);
        this.dgvTree.MultiSelect = false;
        this.dgvTree.Name = "dgvTree";
        this.dgvTree.Size = new Size(802, 114);
        this.dgvTree.TabIndex = 37;
        this.tagColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.tagColumn.DefaultNodeImage = null;
        this.tagColumn.HeaderText = "Тэг\\Подразделение";
        this.tagColumn.Name = "tagColumn";
        this.tagColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.idDivisionColumn.HeaderText = "idDivision";
        this.idDivisionColumn.Name = "idDivisionColumn";
        this.idDivisionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.idDivisionColumn.Visible = false;
        this.workerColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.workerColumn.HeaderText = "ФИО";
        this.workerColumn.Name = "workerColumn";
        this.workerColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.idWorkerColumn.HeaderText = "idWorker";
        this.idWorkerColumn.Name = "idWorkerColumn";
        this.idWorkerColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.idWorkerColumn.Visible = false;
        this.contactColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.contactColumn.HeaderText = "Контакт";
        this.contactColumn.Name = "contactColumn";
        this.contactColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.toolStrip1.Dock = DockStyle.None;
        this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
        this.toolStrip1.Items.AddRange(new ToolStripItem[]
        {
            this.toolBtnAdd,
            this.toolBtnEdit,
            this.toolBtnDel
        });
        this.toolStrip1.Location = new Point(13, 204);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new Size(78, 25);
        this.toolStrip1.TabIndex = 38;
        this.toolStrip1.Text = "toolStrip1";
        this.toolBtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolBtnAdd.DropDownItems.AddRange(new ToolStripItem[]
        {
            this.toolMenuItemTagAdd,
            this.toolMenuItemDivisionAdd,
            this.toolMenuItemContactAdd
        });
        this.toolBtnAdd.Image = (Image)resources.GetObject("toolBtnAdd.Image");
        this.toolBtnAdd.ImageTransparentColor = Color.Magenta;
        this.toolBtnAdd.Name = "toolBtnAdd";
        this.toolBtnAdd.Size = new Size(29, 22);
        this.toolBtnAdd.Text = "Добавить";
        this.toolMenuItemTagAdd.Name = "toolMenuItemTagAdd";
        this.toolMenuItemTagAdd.Size = new Size(159, 22);
        this.toolMenuItemTagAdd.Text = "Тэг";
        this.toolMenuItemTagAdd.Click +=new System.EventHandler( this.toolMenuItemTagAdd_Click);
        this.toolMenuItemDivisionAdd.Name = "toolMenuItemDivisionAdd";
        this.toolMenuItemDivisionAdd.Size = new Size(159, 22);
        this.toolMenuItemDivisionAdd.Text = "Подразделение";
        this.toolMenuItemDivisionAdd.Click +=new System.EventHandler( this.toolMenuItemDivisionAdd_Click);
        this.toolMenuItemContactAdd.Name = "toolMenuItemContactAdd";
        this.toolMenuItemContactAdd.Size = new Size(159, 22);
        this.toolMenuItemContactAdd.Text = "Контакт";
        this.toolMenuItemContactAdd.Click +=new System.EventHandler( this.toolMenuItemContactAdd_Click);
        this.toolBtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolBtnEdit.Image = (Image)resources.GetObject("toolBtnEdit.Image");
        this.toolBtnEdit.ImageTransparentColor = Color.Magenta;
        this.toolBtnEdit.Name = "toolBtnEdit";
        this.toolBtnEdit.Size = new Size(23, 22);
        this.toolBtnEdit.Text = "Редактировать";
        this.toolBtnEdit.Click +=new System.EventHandler( this.toolBtnEdit_Click);
        this.toolBtnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolBtnDel.Image = (Image)resources.GetObject("toolBtnDel.Image");
        this.toolBtnDel.ImageTransparentColor = Color.Magenta;
        this.toolBtnDel.Name = "toolBtnDel";
        this.toolBtnDel.Size = new Size(23, 22);
        this.toolBtnDel.Text = "Удалить";
        this.toolBtnDel.Click +=new System.EventHandler( this.toolBtnDel_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(810, 387);
        base.Controls.Add(this.toolStrip1);
        base.Controls.Add(this.dgvTree);
        base.Controls.Add(this.buttonClose);
        base.Controls.Add(this.buttonSave);
        base.Controls.Add(this.label27);
        base.Controls.Add(this.groupBoxSender);
        base.Controls.Add(this.groupBoxSMTP);
        base.Controls.Add(this.chkSendMail);
        base.Name = "FormDamageSettingMail";
        this.Text = "Настройки отправки почты (смс)";
        base.Load +=new System.EventHandler( this.FormDamageSettingMail_Load);
        this.groupBoxSender.ResumeLayout(false);
        this.groupBoxSender.PerformLayout();
        this.groupBoxSMTP.ResumeLayout(false);
        this.groupBoxSMTP.PerformLayout();
        ((ISupportInitialize)this.txtSMTPServerPortPlanned).EndInit();
        ((ISupportInitialize)this.dataSet1).EndInit();
        ((ISupportInitialize)this.tSettings).EndInit();
        ((ISupportInitialize)this.dgvTree).EndInit();
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
    

    private CheckBox chkSendMail;

    private Label label27;

    private GroupBox groupBoxSender;

    private Label label26;

    private TextBox txtSenderNamePlanned;

    private Label label25;

    private TextBox txtSenderAddressPlanned;

    private GroupBox groupBoxSMTP;

    private Label label24;

    private TextBox txtPwdSMTPPlanned;

    private Label label23;

    private TextBox txtLoginSMTPPlanned;

    private Label label22;

    private NumericUpDown txtSMTPServerPortPlanned;

    private Label label21;

    private TextBox txtSMTPServerPlanned;

    private Button buttonSave;

    private Button buttonClose;

    private DataSet dataSet1;

    private DataTable tSettings;

    private DataColumn dataColumnid;

    private DataColumn dataColumnsettings;

    private DataColumn dataColumnmodule;

    private TreeDataGridView dgvTree;

    private ToolStrip toolStrip1;

    private ToolStripDropDownButton toolBtnAdd;

    private ToolStripMenuItem toolMenuItemTagAdd;

    private ToolStripMenuItem toolMenuItemDivisionAdd;

    private ToolStripMenuItem toolMenuItemContactAdd;

    private TreeGridColumn tagColumn;

    private DataGridViewTextBoxColumn idDivisionColumn;

    private DataGridViewTextBoxColumn workerColumn;

    private DataGridViewTextBoxColumn idWorkerColumn;

    private DataGridViewTextBoxColumn contactColumn;

    private ToolStripButton toolBtnEdit;

    private ToolStripButton toolBtnDel;
}
