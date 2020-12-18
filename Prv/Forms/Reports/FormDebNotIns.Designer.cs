namespace Prv.Forms.Reports
{
    partial class FormDebNotIns
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
            this.toolStripNotIns = new System.Windows.Forms.ToolStrip();
            this.tsbToExel = new System.Windows.Forms.ToolStripButton();
            this.dgvefDebNotIns = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsDebNotIns = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogovorDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.NomPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorodokDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.itogDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.sETIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripNotIns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefDebNotIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDebNotIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripNotIns
            // 
            this.toolStripNotIns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbToExel});
            this.toolStripNotIns.Location = new System.Drawing.Point(0, 0);
            this.toolStripNotIns.Name = "toolStripNotIns";
            this.toolStripNotIns.Size = new System.Drawing.Size(796, 25);
            this.toolStripNotIns.TabIndex = 0;
            this.toolStripNotIns.Text = "toolStrip1";
            // 
            // tsbToExel
            // 
            this.tsbToExel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbToExel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbToExel.Image = global::Prv.Properties.Resources._1482423561_export_excel;
            this.tsbToExel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToExel.Name = "tsbToExel";
            this.tsbToExel.Size = new System.Drawing.Size(23, 22);
            this.tsbToExel.Text = "в Exel";
            this.tsbToExel.Click += new System.EventHandler(this.tsbToExel_Click);
            // 
            // dgvefDebNotIns
            // 
            this.dgvefDebNotIns.AllowUserToAddRows = false;
            this.dgvefDebNotIns.AllowUserToDeleteRows = false;
            this.dgvefDebNotIns.AutoGenerateColumns = false;
            this.dgvefDebNotIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefDebNotIns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idPointDataGridViewTextBoxColumn,
            this.idZoneDataGridViewTextBoxColumn,
            this.dogovorDataGridViewTextBoxColumn,
            this.NomPoint,
            this.gorodokDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.itogDataGridViewTextBoxColumn,
            this.sETIDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.monthDebDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.idOwnerDataGridViewTextBoxColumn,
            this.nameFileDataGridViewTextBoxColumn,
            this.idPointRegDataGridViewTextBoxColumn});
            this.dgvefDebNotIns.DataSource = this.bsDebNotIns;
            this.dgvefDebNotIns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvefDebNotIns.Location = new System.Drawing.Point(0, 25);
            this.dgvefDebNotIns.Name = "dgvefDebNotIns";
            this.dgvefDebNotIns.ReadOnly = true;
            this.dgvefDebNotIns.RowHeadersWidth = 21;
            this.dgvefDebNotIns.Size = new System.Drawing.Size(796, 450);
            this.dgvefDebNotIns.TabIndex = 1;
            // 
            // bsDebNotIns
            // 
            this.bsDebNotIns.DataMember = "fn_PrvRepDebNotIns";
            this.bsDebNotIns.DataSource = this.dsRep;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointDataGridViewTextBoxColumn
            // 
            this.idPointDataGridViewTextBoxColumn.DataPropertyName = "idPoint";
            this.idPointDataGridViewTextBoxColumn.HeaderText = "idPoint";
            this.idPointDataGridViewTextBoxColumn.Name = "idPointDataGridViewTextBoxColumn";
            this.idPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointDataGridViewTextBoxColumn.Visible = false;
            // 
            // idZoneDataGridViewTextBoxColumn
            // 
            this.idZoneDataGridViewTextBoxColumn.DataPropertyName = "idZone";
            this.idZoneDataGridViewTextBoxColumn.HeaderText = "idZone";
            this.idZoneDataGridViewTextBoxColumn.Name = "idZoneDataGridViewTextBoxColumn";
            this.idZoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.idZoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // dogovorDataGridViewTextBoxColumn
            // 
            this.dogovorDataGridViewTextBoxColumn.DataPropertyName = "Dogovor";
            this.dogovorDataGridViewTextBoxColumn.HeaderText = "Л.счет";
            this.dogovorDataGridViewTextBoxColumn.Name = "dogovorDataGridViewTextBoxColumn";
            this.dogovorDataGridViewTextBoxColumn.ReadOnly = true;
            this.dogovorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomPoint
            // 
            this.NomPoint.DataPropertyName = "NomPoint";
            this.NomPoint.HeaderText = "№ т.уч.";
            this.NomPoint.Name = "NomPoint";
            this.NomPoint.ReadOnly = true;
            this.NomPoint.Width = 50;
            // 
            // gorodokDataGridViewTextBoxColumn
            // 
            this.gorodokDataGridViewTextBoxColumn.DataPropertyName = "Gorodok";
            this.gorodokDataGridViewTextBoxColumn.HeaderText = "Нас.пункт";
            this.gorodokDataGridViewTextBoxColumn.Name = "gorodokDataGridViewTextBoxColumn";
            this.gorodokDataGridViewTextBoxColumn.ReadOnly = true;
            this.gorodokDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adressDataGridViewTextBoxColumn.Width = 200;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // itogDataGridViewTextBoxColumn
            // 
            this.itogDataGridViewTextBoxColumn.DataPropertyName = "Itog";
            this.itogDataGridViewTextBoxColumn.HeaderText = "кВт";
            this.itogDataGridViewTextBoxColumn.Name = "itogDataGridViewTextBoxColumn";
            this.itogDataGridViewTextBoxColumn.ReadOnly = true;
            this.itogDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sETIDataGridViewTextBoxColumn
            // 
            this.sETIDataGridViewTextBoxColumn.DataPropertyName = "SETI";
            this.sETIDataGridViewTextBoxColumn.HeaderText = "SETI";
            this.sETIDataGridViewTextBoxColumn.Name = "sETIDataGridViewTextBoxColumn";
            this.sETIDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETIDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInDataGridViewTextBoxColumn.Visible = false;
            // 
            // monthDebDataGridViewTextBoxColumn
            // 
            this.monthDebDataGridViewTextBoxColumn.DataPropertyName = "MonthDeb";
            this.monthDebDataGridViewTextBoxColumn.HeaderText = "MonthDeb";
            this.monthDebDataGridViewTextBoxColumn.Name = "monthDebDataGridViewTextBoxColumn";
            this.monthDebDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDebDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idOwnerDataGridViewTextBoxColumn
            // 
            this.idOwnerDataGridViewTextBoxColumn.DataPropertyName = "idOwner";
            this.idOwnerDataGridViewTextBoxColumn.HeaderText = "idOwner";
            this.idOwnerDataGridViewTextBoxColumn.Name = "idOwnerDataGridViewTextBoxColumn";
            this.idOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOwnerDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameFileDataGridViewTextBoxColumn
            // 
            this.nameFileDataGridViewTextBoxColumn.DataPropertyName = "NameFile";
            this.nameFileDataGridViewTextBoxColumn.HeaderText = "NameFile";
            this.nameFileDataGridViewTextBoxColumn.Name = "nameFileDataGridViewTextBoxColumn";
            this.nameFileDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameFileDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointRegDataGridViewTextBoxColumn
            // 
            this.idPointRegDataGridViewTextBoxColumn.DataPropertyName = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.HeaderText = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.Name = "idPointRegDataGridViewTextBoxColumn";
            this.idPointRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointRegDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormDebNotIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 475);
            this.Controls.Add(this.dgvefDebNotIns);
            this.Controls.Add(this.toolStripNotIns);
            this.Name = "FormDebNotIns";
            this.Text = "Не прогружены";
            this.Load += new System.EventHandler(this.FormDebNotIns_Load);
            this.toolStripNotIns.ResumeLayout(false);
            this.toolStripNotIns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefDebNotIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDebNotIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripNotIns;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefDebNotIns;
        private System.Windows.Forms.BindingSource bsDebNotIns;
        private DataSets.DataSetRep dsRep;
        private System.Windows.Forms.ToolStripButton tsbToExel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZoneDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dogovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPoint;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn gorodokDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn adressDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn fIODataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn typeDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn itogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointRegDataGridViewTextBoxColumn;
    }
}