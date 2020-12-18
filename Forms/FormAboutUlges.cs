using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace EIS
{
    
    internal class FormAboutUlges : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private DataGridView dgvDlls;
        private DataGridViewTextBoxColumn ColumnDLL;
        private Label label3;
        private DataGridViewTextBoxColumn columnDescription;
        private Label labelName;
        private DataGridViewTextBoxColumn columnVersion;
        private PictureBox pictureBoxCoder;
        private Button buttonOK;
        private Label label2;
        private DataGridViewTextBoxColumn columnLicense;

        public FormAboutUlges()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutUlges));
            this.pictureBoxCoder = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.dgvDlls = new System.Windows.Forms.DataGridView();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDLL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDlls)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCoder
            // 
            this.pictureBoxCoder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCoder.Image = global::EIS.Properties.Resources.logo_full_trans;
            this.pictureBoxCoder.Location = new System.Drawing.Point(9, 9);
            this.pictureBoxCoder.Name = "pictureBoxCoder";
            this.pictureBoxCoder.Size = new System.Drawing.Size(666, 183);
            this.pictureBoxCoder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoder.TabIndex = 0;
            this.pictureBoxCoder.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(9, 195);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(666, 34);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Программно-технический комплекс \"Энергосхема\"";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(600, 443);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.Click_buttonOK);
            // 
            // dgvDlls
            // 
            this.dgvDlls.AllowUserToAddRows = false;
            this.dgvDlls.AllowUserToDeleteRows = false;
            this.dgvDlls.AllowUserToOrderColumns = true;
            this.dgvDlls.AllowUserToResizeRows = false;
            this.dgvDlls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDlls.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDlls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDlls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDescription,
            this.ColumnDLL,
            this.columnVersion,
            this.columnLicense});
            this.dgvDlls.Location = new System.Drawing.Point(9, 241);
            this.dgvDlls.MultiSelect = false;
            this.dgvDlls.Name = "dgvDlls";
            this.dgvDlls.ReadOnly = true;
            this.dgvDlls.RowHeadersVisible = false;
            this.dgvDlls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDlls.Size = new System.Drawing.Size(666, 163);
            this.dgvDlls.TabIndex = 4;
            // 
            // columnDescription
            // 
            this.columnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDescription.HeaderText = "Установленные модули";
            this.columnDescription.Name = "columnDescription";
            this.columnDescription.ReadOnly = true;
            // 
            // ColumnDLL
            // 
            this.ColumnDLL.HeaderText = "DLL";
            this.ColumnDLL.Name = "ColumnDLL";
            this.ColumnDLL.ReadOnly = true;
            this.ColumnDLL.Visible = false;
            // 
            // columnVersion
            // 
            this.columnVersion.HeaderText = "Версия";
            this.columnVersion.Name = "columnVersion";
            this.columnVersion.ReadOnly = true;
            this.columnVersion.Width = 200;
            // 
            // columnLicense
            // 
            this.columnLicense.HeaderText = "Лицензии";
            this.columnLicense.Name = "columnLicense";
            this.columnLicense.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(6, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Специализированная версия для МУП \"Ульяновские городские электрические сети\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "© 2011-2016 ООО \"Кодер.Ул\"";
            // 
            // FormAboutUlges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDlls);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxCoder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutUlges";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.Load_FormAboutUlges);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDlls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Click_buttonOK(object p0, EventArgs p1)
        {
            base.Close();
        }

        private void Load_FormAboutUlges(object p0, EventArgs p1)
        {
            this.dgvDlls.Rows.Clear();
            // Scheme
            Version version = new Version();
            try
            {
                version = Assembly.LoadFrom("Scheme.dll").GetName().Version;
            }
            catch
            {
            }
            object[] values = new object[] { @"ЭнергоСхема\Схема", "Scheme.dll", version.ToString(), 80 };
            this.dgvDlls.Rows.Add(values);

            // Passport
            version = new Version();
            try
            {
                version = Assembly.LoadFrom("Passport.dll").GetName().Version;
                object[] objArray6 = new object[] { @"ЭнергоСхема\Паспорт", "Passport.dll", version.ToString(), 80 };
                this.dgvDlls.Rows.Add(objArray6);
            }
            catch
            {
            }

            // Telemetry
            version = new Version();
            try
            {
                //version = (Version)m000053(Assembly.LoadFrom("Telemetry.dll").GetName());
                version = Assembly.LoadFrom("Telemetry.dll").GetName().Version;
            }
            catch
            {
            }
            object[] objArray2 = new object[] { @"ЭнергоСхема\Телеметрия", "Telemetry.dll", version.ToString(), 80 };
            this.dgvDlls.Rows.Add((object[])objArray2);

            // Prv
            version = new Version();
            try
            {
                // version = (Version)m000053(Assembly.LoadFrom("Prv.dll").GetName());
                version = Assembly.LoadFrom("Prv.dll").GetName().Version;
            }
            catch
            {
            }
            object[] objArray3 = new object[] { @"ЭнергоСхема\Лицевые счета", "Prv.dll", version.ToString(), 0x2b };
            this.dgvDlls.Rows.Add(objArray3);

            // Legal
            version = new Version();
            try
            {
                version = Assembly.LoadFrom("Legal.dll").GetName().Version;
                object[] objArray4 = new object[] { @"ЭнергоСхема\Сетевая организация", "Legal.dll", version.ToString(), 0x53 };
                this.dgvDlls.Rows.Add(objArray4);
            }
            catch
            {
            }

            // Documents
            version = new Version();
            try
            {
                version = Assembly.LoadFrom("Documents.dll").GetName().Version;
            }
            catch
            {
            }
            object[] objArray5 = new object[] { @"ЭнергоСхема\Документооборот", "Documents.dll", version.ToString(), 80 };
            this.dgvDlls.Rows.Add(objArray5);
            return;
        }




        [SpecialName]
        public string GetName()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        [SpecialName]
        public string GetDescription()
        {
            object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            if (customAttributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
        }

        [SpecialName]
        public string GetCodeBase()
        {
            object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (customAttributes.Length != 0)
            {
                AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
                if (assemblyTitleAttribute.Title != "")
                    return assemblyTitleAttribute.Title;
            }
            return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
        }

        [SpecialName]
        public string GetCompany()
        {
            object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            if (customAttributes.Length == 0)
                return "";
            return ((AssemblyCompanyAttribute)customAttributes[0]).Company;
        }

        [SpecialName]
        public string GetProduct()
        {
            object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (customAttributes.Length == 0)
                return "";
            return ((AssemblyProductAttribute)customAttributes[0]).Product;
        }

        [SpecialName]
        public string GetCopyright()
        {
            object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (customAttributes.Length == 0)
                return "";
            return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
        }
    }

    

}
