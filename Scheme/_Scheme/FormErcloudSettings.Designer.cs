internal partial class FormErcloudSettings : global::FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FormErcloudSettings));
		this.BbeKmRyXmC = new global::System.Windows.Forms.SplitContainer();
		this.qTgKdykitv = new global::System.Windows.Forms.Button();
		this.buttonAdd = new global::System.Windows.Forms.Button();
		this.buttonEdit = new global::System.Windows.Forms.Button();
		this.txtPassword = new global::System.Windows.Forms.TextBox();
		this.txtLogin = new global::System.Windows.Forms.TextBox();
		this.label6 = new global::System.Windows.Forms.Label();
		this.label5 = new global::System.Windows.Forms.Label();
		this.txtPort = new global::System.Windows.Forms.TextBox();
		this.txtAddress = new global::System.Windows.Forms.TextBox();
		this.label4 = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.txtNameConnect = new global::System.Windows.Forms.TextBox();
		this.label2 = new global::System.Windows.Forms.Label();
		this.listBoxConnect = new global::System.Windows.Forms.ListBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.dataSet_0 = new global::System.Data.DataSet();
		this.dataTable_0 = new global::System.Data.DataTable();
		this.dataColumn_0 = new global::System.Data.DataColumn();
		this.dataColumn_1 = new global::System.Data.DataColumn();
		this.dataColumn_2 = new global::System.Data.DataColumn();
		this.BbeKmRyXmC.Panel1.SuspendLayout();
		this.BbeKmRyXmC.Panel2.SuspendLayout();
		this.BbeKmRyXmC.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
		base.SuspendLayout();
		this.BbeKmRyXmC.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.BbeKmRyXmC.Location = new global::System.Drawing.Point(0, 0);
		this.BbeKmRyXmC.Name = "splitContainer1";
		this.BbeKmRyXmC.Panel1.Controls.Add(this.qTgKdykitv);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.buttonAdd);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.buttonEdit);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.txtPassword);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.txtLogin);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label6);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label5);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.txtPort);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.txtAddress);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label4);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label3);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.txtNameConnect);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label2);
		this.BbeKmRyXmC.Panel2.Controls.Add(this.listBoxConnect);
		this.BbeKmRyXmC.Panel2.Controls.Add(this.label1);
		this.BbeKmRyXmC.Size = new global::System.Drawing.Size(848, 411);
		this.BbeKmRyXmC.SplitterDistance = 450;
		this.BbeKmRyXmC.TabIndex = 0;
		this.qTgKdykitv.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.qTgKdykitv.Location = new global::System.Drawing.Point(372, 140);
		this.qTgKdykitv.Name = "buttonRemove";
		this.qTgKdykitv.Size = new global::System.Drawing.Size(75, 23);
		this.qTgKdykitv.TabIndex = 12;
		this.qTgKdykitv.Text = "Удалить";
		this.qTgKdykitv.UseVisualStyleBackColor = true;
		this.qTgKdykitv.Click += new global::System.EventHandler(this.qTgKdykitv_Click);
		this.buttonAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.buttonAdd.Location = new global::System.Drawing.Point(192, 140);
		this.buttonAdd.Name = "buttonAdd";
		this.buttonAdd.Size = new global::System.Drawing.Size(75, 23);
		this.buttonAdd.TabIndex = 11;
		this.buttonAdd.Text = "Добавить";
		this.buttonAdd.UseVisualStyleBackColor = true;
		this.buttonAdd.Click += new global::System.EventHandler(this.buttonAdd_Click);
		this.buttonEdit.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.buttonEdit.Location = new global::System.Drawing.Point(273, 140);
		this.buttonEdit.Name = "buttonEdit";
		this.buttonEdit.Size = new global::System.Drawing.Size(93, 23);
		this.buttonEdit.TabIndex = 10;
		this.buttonEdit.Text = "Редактировать";
		this.buttonEdit.UseVisualStyleBackColor = true;
		this.buttonEdit.Click += new global::System.EventHandler(this.buttonEdit_Click);
		this.txtPassword.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.txtPassword.Location = new global::System.Drawing.Point(215, 103);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.PasswordChar = '*';
		this.txtPassword.Size = new global::System.Drawing.Size(232, 20);
		this.txtPassword.TabIndex = 9;
		this.txtLogin.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.txtLogin.Location = new global::System.Drawing.Point(11, 103);
		this.txtLogin.Name = "txtLogin";
		this.txtLogin.Size = new global::System.Drawing.Size(196, 20);
		this.txtLogin.TabIndex = 8;
		this.label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.label6.AutoSize = true;
		this.label6.Location = new global::System.Drawing.Point(212, 87);
		this.label6.Name = "label6";
		this.label6.Size = new global::System.Drawing.Size(45, 13);
		this.label6.TabIndex = 7;
		this.label6.Text = "Пароль";
		this.label5.AutoSize = true;
		this.label5.Location = new global::System.Drawing.Point(12, 87);
		this.label5.Name = "label5";
		this.label5.Size = new global::System.Drawing.Size(38, 13);
		this.label5.TabIndex = 6;
		this.label5.Text = "Логин";
		this.txtPort.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.txtPort.Location = new global::System.Drawing.Point(319, 64);
		this.txtPort.Name = "txtPort";
		this.txtPort.Size = new global::System.Drawing.Size(128, 20);
		this.txtPort.TabIndex = 5;
		this.txtPort.Text = "8082";
		this.txtPort.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
		this.txtAddress.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.txtAddress.Location = new global::System.Drawing.Point(11, 64);
		this.txtAddress.Name = "txtAddress";
		this.txtAddress.Size = new global::System.Drawing.Size(304, 20);
		this.txtAddress.TabIndex = 4;
		this.txtAddress.Text = "95.182.111.130";
		this.label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.label4.AutoSize = true;
		this.label4.Location = new global::System.Drawing.Point(316, 48);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(32, 13);
		this.label4.TabIndex = 3;
		this.label4.Text = "Порт";
		this.label3.AutoSize = true;
		this.label3.Location = new global::System.Drawing.Point(12, 48);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(83, 13);
		this.label3.TabIndex = 2;
		this.label3.Text = "Адрес сервера";
		this.txtNameConnect.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.txtNameConnect.Location = new global::System.Drawing.Point(11, 25);
		this.txtNameConnect.Name = "txtNameConnect";
		this.txtNameConnect.Size = new global::System.Drawing.Size(436, 20);
		this.txtNameConnect.TabIndex = 1;
		this.txtNameConnect.Text = "Ercloud";
		this.label2.AutoSize = true;
		this.label2.Location = new global::System.Drawing.Point(12, 9);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(99, 13);
		this.label2.TabIndex = 0;
		this.label2.Text = "Имя подключения";
		this.listBoxConnect.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.listBoxConnect.FormattingEnabled = true;
		this.listBoxConnect.Location = new global::System.Drawing.Point(3, 25);
		this.listBoxConnect.Name = "listBoxConnect";
		this.listBoxConnect.Size = new global::System.Drawing.Size(391, 381);
		this.listBoxConnect.TabIndex = 1;
		this.listBoxConnect.SelectedIndexChanged += new global::System.EventHandler(this.listBoxConnect_SelectedIndexChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new global::System.Drawing.Point(3, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(95, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Список серверов";
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new global::System.Data.DataTable[]
		{
			this.dataTable_0
		});
		this.dataTable_0.Columns.AddRange(new global::System.Data.DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2
		});
		this.dataTable_0.Constraints.AddRange(new global::System.Data.Constraint[]
		{
			new global::System.Data.UniqueConstraint("Constraint1", new string[]
			{
				"id"
			}, true)
		});
		this.dataTable_0.PrimaryKey = new global::System.Data.DataColumn[]
		{
			this.dataColumn_0
		};
		this.dataTable_0.TableName = "tSettings";
		this.dataColumn_0.AllowDBNull = false;
		this.dataColumn_0.AutoIncrement = true;
		this.dataColumn_0.ColumnName = "id";
		this.dataColumn_0.DataType = typeof(int);
		this.dataColumn_1.ColumnName = "settings";
		this.dataColumn_2.ColumnName = "module";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(848, 411);
		base.Controls.Add(this.BbeKmRyXmC);
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "FormErcloudSettings";
		this.Text = "Настройки подключения к Ercloud";
		base.TopMost = true;
		base.Load += new global::System.EventHandler(this.FormErcloudSettings_Load);
		this.BbeKmRyXmC.Panel1.ResumeLayout(false);
		this.BbeKmRyXmC.Panel1.PerformLayout();
		this.BbeKmRyXmC.Panel2.ResumeLayout(false);
		this.BbeKmRyXmC.Panel2.PerformLayout();
		this.BbeKmRyXmC.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
		base.ResumeLayout(false);
	}

	private global::System.ComponentModel.IContainer icontainer_0;

	private global::System.Windows.Forms.SplitContainer BbeKmRyXmC;

	private global::System.Windows.Forms.Button buttonAdd;

	private global::System.Windows.Forms.Button buttonEdit;

	private global::System.Windows.Forms.TextBox txtPassword;

	private global::System.Windows.Forms.TextBox txtLogin;

	private global::System.Windows.Forms.Label label6;

	private global::System.Windows.Forms.Label label5;

	private global::System.Windows.Forms.TextBox txtPort;

	private global::System.Windows.Forms.TextBox txtAddress;

	private global::System.Windows.Forms.Label label4;

	private global::System.Windows.Forms.Label label3;

	private global::System.Windows.Forms.TextBox txtNameConnect;

	private global::System.Windows.Forms.Label label2;

	private global::System.Windows.Forms.ListBox listBoxConnect;

	private global::System.Windows.Forms.Label label1;

	private global::System.Windows.Forms.Button qTgKdykitv;

	private global::System.Data.DataSet dataSet_0;

	private global::System.Data.DataTable dataTable_0;

	private global::System.Data.DataColumn dataColumn_0;

	private global::System.Data.DataColumn dataColumn_1;

	private global::System.Data.DataColumn dataColumn_2;
}
