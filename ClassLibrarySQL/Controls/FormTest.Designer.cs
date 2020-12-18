namespace Library
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DataSql.SQLSettings sqlSettings1 = new DataSql.SQLSettings();
            this.pageReestrDocs1 = new Library.PageReestrDocs(this.components);
            this.SuspendLayout();
            // 
            // pageReestrDocs1
            // 
            this.pageReestrDocs1.IdDocument = 0;
            this.pageReestrDocs1.Location = new System.Drawing.Point(0, 0);
            this.pageReestrDocs1.Name = "pageReestrDocs1";
            this.pageReestrDocs1.Size = new System.Drawing.Size(396, 217);
            sqlSettings1.Autentification = "WINDOWS";
            sqlSettings1.DBName = "GES";
            sqlSettings1.ServerDB = "ulges-sql2";
            sqlSettings1.SqlPasswConnect = "";
            sqlSettings1.SqlUserConnect = "";
            this.pageReestrDocs1.SqlSettings = sqlSettings1;
            this.pageReestrDocs1.TabIndex = 0;
            this.pageReestrDocs1.TableDocumentDoc = "tJ_DamageDoc";
            this.pageReestrDocs1.TypeDocument = 0;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 463);
            this.Controls.Add(this.pageReestrDocs1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private PageReestrDocs pageReestrDocs1;
    }
}