using DataSql;
using FormLbr.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EIS.Forms
{
    public class FormConnect : Form
    {
        #region переменные
        private EISSettings EISSettings;
       
        private Button btnOK;
        private TextBox fldPassword;
        private Label Field10;
        private Label Field9;
        private TextBox fldUser;
        private ComboBox fldAuthentication;
        private Label Field6;
        private TextBox fldServer;
        private Label Field4;
        private Button btnCansel;
        private Label Field2;
        private TextBox fldBD;
        #endregion

        public SQLSettings SqlSetting
        {
            get
            {
                SQLSettings sqlSettings = new SQLSettings();
                sqlSettings.ServerDB = this.fldServer.Text;
                sqlSettings.DBName = this.fldBD.Text;
                if (this.fldAuthentication.SelectedIndex == 0)
                    sqlSettings.Autentification = "WINDOWS";
                else
                    sqlSettings.Autentification = "SQL";
                sqlSettings.SqlUserConnect = this.fldUser.Text;
                sqlSettings.SqlPasswConnect = this.fldPassword.Text;
                return sqlSettings;
            }
        }

        public FormConnect()
        {
            this.InitializeComponent();
            this.EISSettings = new EISSettings();
            this.fldUser.Enabled = false;
            this.fldPassword.Enabled = false;
        }

        public FormConnect(SQLSettings sqlSettings)
        {
            this.InitializeComponent();
            this.fldServer.Text = sqlSettings.ServerDB;
            this.fldBD.Text = sqlSettings.DBName;
            if (sqlSettings.Autentification.ToUpper() == "WINDOWS")
                this.fldAuthentication.SelectedIndex = 0;
            else
                this.fldAuthentication.SelectedIndex = 1;
            this.fldUser.Text = sqlSettings.SqlUserConnect;
            this.fldPassword.Text = sqlSettings.SqlPasswConnect;
        }

        private void Method3(object sender, EventArgs e)
        {
            this.fldUser.Enabled = this.fldAuthentication.SelectedIndex != 0;
            this.fldPassword.Enabled = this.fldAuthentication.SelectedIndex != 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.fldAuthentication.SelectedIndex == 0)
            {
                if (new SqlDataConnect().CheckConnection(this.fldServer.Text, this.fldBD.Text))
                    return;
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (new SqlDataConnect().CheckConnection(this.fldServer.Text, this.fldBD.Text, this.fldUser.Text, this.fldPassword.Text))
                    return;
                this.DialogResult = DialogResult.None;
            }
        }

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnect));
            this.btnOK = new System.Windows.Forms.Button();
            this.fldPassword = new System.Windows.Forms.TextBox();
            this.Field10 = new System.Windows.Forms.Label();
            this.Field9 = new System.Windows.Forms.Label();
            this.fldUser = new System.Windows.Forms.TextBox();
            this.fldAuthentication = new System.Windows.Forms.ComboBox();
            this.Field6 = new System.Windows.Forms.Label();
            this.fldServer = new System.Windows.Forms.TextBox();
            this.Field4 = new System.Windows.Forms.Label();
            this.btnCansel = new System.Windows.Forms.Button();
            this.Field2 = new System.Windows.Forms.Label();
            this.fldBD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // fldPassword
            // 
            this.fldPassword.Location = new System.Drawing.Point(23, 184);
            this.fldPassword.Name = "fldPassword";
            this.fldPassword.PasswordChar = '*';
            this.fldPassword.Size = new System.Drawing.Size(191, 20);
            this.fldPassword.TabIndex = 9;
            // 
            // Field10
            // 
            this.Field10.AutoSize = true;
            this.Field10.Location = new System.Drawing.Point(20, 168);
            this.Field10.Name = "Field10";
            this.Field10.Size = new System.Drawing.Size(45, 13);
            this.Field10.TabIndex = 8;
            this.Field10.Text = "Пароль";
            // 
            // Field9
            // 
            this.Field9.AutoSize = true;
            this.Field9.Location = new System.Drawing.Point(20, 129);
            this.Field9.Name = "Field9";
            this.Field9.Size = new System.Drawing.Size(80, 13);
            this.Field9.TabIndex = 6;
            this.Field9.Text = "Пользователь";
            // 
            // fldUser
            // 
            this.fldUser.Location = new System.Drawing.Point(23, 145);
            this.fldUser.Name = "fldUser";
            this.fldUser.Size = new System.Drawing.Size(191, 20);
            this.fldUser.TabIndex = 7;
            // 
            // fldAuthentication
            // 
            this.fldAuthentication.DisplayMember = "0";
            this.fldAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fldAuthentication.FormattingEnabled = true;
            this.fldAuthentication.Items.AddRange(new object[] {
            "Windows аутентификация",
            "SQL Server аутентификация"});
            this.fldAuthentication.Location = new System.Drawing.Point(12, 105);
            this.fldAuthentication.Name = "fldAuthentication";
            this.fldAuthentication.Size = new System.Drawing.Size(202, 21);
            this.fldAuthentication.TabIndex = 5;
            this.fldAuthentication.SelectedIndexChanged += new System.EventHandler(this.Method3);
            // 
            // Field6
            // 
            this.Field6.AutoSize = true;
            this.Field6.Location = new System.Drawing.Point(9, 89);
            this.Field6.Name = "Field6";
            this.Field6.Size = new System.Drawing.Size(91, 13);
            this.Field6.TabIndex = 4;
            this.Field6.Text = "Аутентификация";
            // 
            // fldServer
            // 
            this.fldServer.Location = new System.Drawing.Point(12, 26);
            this.fldServer.Name = "fldServer";
            this.fldServer.Size = new System.Drawing.Size(202, 20);
            this.fldServer.TabIndex = 1;
            this.fldServer.Text = "asu-sasha\\sqlexpress";
            // 
            // Field4
            // 
            this.Field4.AutoSize = true;
            this.Field4.Location = new System.Drawing.Point(9, 10);
            this.Field4.Name = "Field4";
            this.Field4.Size = new System.Drawing.Size(74, 13);
            this.Field4.TabIndex = 0;
            this.Field4.Text = "Имя сервера";
            // 
            // btnCansel
            // 
            this.btnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCansel.Location = new System.Drawing.Point(139, 230);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 11;
            this.btnCansel.Text = "Отмена";
            this.btnCansel.UseVisualStyleBackColor = true;
            // 
            // Field2
            // 
            this.Field2.AutoSize = true;
            this.Field2.Location = new System.Drawing.Point(9, 49);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(72, 13);
            this.Field2.TabIndex = 2;
            this.Field2.Text = "База данных";
            // 
            // fldBD
            // 
            this.fldBD.Location = new System.Drawing.Point(12, 66);
            this.fldBD.Name = "fldBD";
            this.fldBD.Size = new System.Drawing.Size(202, 20);
            this.fldBD.TabIndex = 3;
            // 
            // FormConnect
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCansel;
            this.ClientSize = new System.Drawing.Size(229, 265);
            this.Controls.Add(this.fldBD);
            this.Controls.Add(this.Field2);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.fldPassword);
            this.Controls.Add(this.Field10);
            this.Controls.Add(this.Field9);
            this.Controls.Add(this.fldUser);
            this.Controls.Add(this.fldAuthentication);
            this.Controls.Add(this.Field6);
            this.Controls.Add(this.fldServer);
            this.Controls.Add(this.Field4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConnect";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к БД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
