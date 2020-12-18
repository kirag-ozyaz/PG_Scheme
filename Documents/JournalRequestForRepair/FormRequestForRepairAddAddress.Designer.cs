using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RequestForRepair
{
    partial class FormRequestForRepairAddAddress
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
            this.listBoxHouse = new System.Windows.Forms.ListBox();
            this.kladrStreetControl = new ControlsLbr.KladrStreetControl();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHouse
            // 
            this.listBoxHouse.Enabled = false;
            this.listBoxHouse.FormattingEnabled = true;
            this.listBoxHouse.Location = new System.Drawing.Point(181, 1);
            this.listBoxHouse.Name = "listBoxHouse";
            this.listBoxHouse.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxHouse.Size = new System.Drawing.Size(82, 199);
            this.listBoxHouse.TabIndex = 4;
            // 
            // kladrStreetControl
            // 
            this.kladrStreetControl.Location = new System.Drawing.Point(1, 1);
            this.kladrStreetControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kladrStreetControl.Name = "kladrStreetControl";
            this.kladrStreetControl.Size = new System.Drawing.Size(173, 208);
            this.kladrStreetControl.SqlSettings = null;
            this.kladrStreetControl.TabIndex = 3;
            this.kladrStreetControl.VisibleCmbTypeHouse = true;
            this.kladrStreetControl.ChangeOblSelect += new System.EventHandler(this.kladrStreetControl_ChangeOblSelect);
            this.kladrStreetControl.ChangeRaionOblSelect += new System.EventHandler(this.kladrStreetControl_ChangeRaionOblSelect);
            this.kladrStreetControl.ChangePunktsSelect += new System.EventHandler(this.kladrStreetControl_ChangePunktsSelect);
            this.kladrStreetControl.ChangeStreetSelect += new System.EventHandler(this.kladrStreetControl_ChangeStreetSelect);
            this.kladrStreetControl.ChangeTypeHouseSelect += new System.EventHandler(this.kladrStreetControl_ChangeTypeHouseSelect);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 217);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(188, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormRequestForRepairAddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 249);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listBoxHouse);
            this.Controls.Add(this.kladrStreetControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRequestForRepairAddAddress";
            this.Text = "Добавление адреса";
            this.Load += new System.EventHandler(this.FormRequestForRepairAddAddress_Load);
            this.ResumeLayout(false);

        }
        #endregion
        public DataTable tbl = new DataTable();
        private ListBox listBoxHouse;
        private ControlsLbr.KladrStreetControl kladrStreetControl;
        private Button buttonOK;
        private Button buttonCancel;
    }
}