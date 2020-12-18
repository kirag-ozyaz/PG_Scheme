using System.Windows.Forms;

namespace EIS.Forms
{
    partial class FormWindowsList
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindowsList));
            this.buttonActivate = new System.Windows.Forms.Button();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.listViewWindows = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FiimageListWindowseld2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // buttonActivate
            // 
            this.buttonActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonActivate.Location = new System.Drawing.Point(319, 12);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(105, 23);
            this.buttonActivate.TabIndex = 1;
            this.buttonActivate.Text = "Активировать";
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseWindow.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonCloseWindow.Location = new System.Drawing.Point(319, 41);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(105, 23);
            this.buttonCloseWindow.TabIndex = 2;
            this.buttonCloseWindow.Text = "Закрыть окно(а)";
            this.buttonCloseWindow.UseVisualStyleBackColor = true;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(319, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(105, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // listViewWindows
            // 
            this.listViewWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewWindows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewWindows.FullRowSelect = true;
            this.listViewWindows.LargeImageList = this.FiimageListWindowseld2;
            this.listViewWindows.Location = new System.Drawing.Point(12, 12);
            this.listViewWindows.Name = "listViewWindows";
            this.listViewWindows.Size = new System.Drawing.Size(301, 238);
            this.listViewWindows.SmallImageList = this.FiimageListWindowseld2;
            this.listViewWindows.TabIndex = 5;
            this.listViewWindows.UseCompatibleStateImageBehavior = false;
            this.listViewWindows.View = System.Windows.Forms.View.Details;
            this.listViewWindows.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewWindows_MouseDoubleClick);
            this.listViewWindows.Resize += new System.EventHandler(this.listViewWindows_Resize);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя окна";
            this.columnHeaderName.Width = 100;
            // 
            // FiimageListWindowseld2
            // 
            this.FiimageListWindowseld2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.FiimageListWindowseld2.ImageSize = new System.Drawing.Size(16, 16);
            this.FiimageListWindowseld2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormWindowsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 262);
            this.Controls.Add(this.listViewWindows);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCloseWindow);
            this.Controls.Add(this.buttonActivate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWindowsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окна";
            this.ResumeLayout(false);

        }
        private Button buttonActivate;
        private Button buttonCloseWindow;
        private Button buttonOK;
        private ListView listViewWindows;
        private ImageList FiimageListWindowseld2;
        private ColumnHeader columnHeaderName;

    }
}
