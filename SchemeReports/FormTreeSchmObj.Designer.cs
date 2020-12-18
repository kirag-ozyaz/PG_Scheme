using System;
using System.ComponentModel;

namespace SchemeReports
{
    partial class FormTreeSchmObj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTreeSchmObj));
            this.contextMenuDgvTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvTreeSub = new ControlsLbr.TreeDataGridView();
            this.subNameColumn = new ControlsLbr.TreeGridColumn();
            this.idSubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCellColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noAdmissionKWTColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tsbLoadTreeSchmema = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreeSub)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuDgvTree
            // 
            this.contextMenuDgvTree.Name = "contextMenuDgvTree";
            this.contextMenuDgvTree.Size = new System.Drawing.Size(61, 4);

            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadTreeSchmema});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvTreeSub
            // 
            this.dgvTreeSub.AllowUserToAddRows = false;
            this.dgvTreeSub.AllowUserToDeleteRows = false;
            this.dgvTreeSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subNameColumn
            ,
            this.idSubColumn,
            this.busNameColumn,
            this.idBusColumn,
            this.cellNameColumn,
            this.idCellColumn,
            this.trNameColumn,
            this.idTrColumn,
            this.powerColumn,
            this.loadColumn,
            this.dateOnColumn,
            this.noAdmissionKWTColumn
            });
            this.dgvTreeSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreeSub.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTreeSub.ImageList = null;
            this.dgvTreeSub.Location = new System.Drawing.Point(0, 25);
            this.dgvTreeSub.Name = "dgvTreeSub";
            this.dgvTreeSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreeSub.Size = new System.Drawing.Size(800, 425);
            this.dgvTreeSub.TabIndex = 4;
            this.dgvTreeSub.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTree_CellFormatting);
            this.dgvTreeSub.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTree_CellMouseClick);
            // 
            // subNameColumn
            // 
            //this.subNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subNameColumn.DataPropertyName = "SubName";
            this.subNameColumn.DefaultNodeImage = null;
            this.subNameColumn.HeaderText = "Подстанция";
            this.subNameColumn.Name = "subNameColumn";
            this.subNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.subNameColumn.Width = 200;
            // 
            // idSubColumn
            // 
            this.idSubColumn.DataPropertyName = "idSub";
            this.idSubColumn.HeaderText = "idSub";
            this.idSubColumn.Name = "idSubColumn";
            this.idSubColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idSubColumn.Visible = false;
            // 
            // busNameColumn
            // 
            this.busNameColumn.DataPropertyName = "BusName";
            this.busNameColumn.HeaderText = "Шина";
            this.busNameColumn.Name = "busNameColumn";
            this.busNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idBusColumn
            // 
            this.idBusColumn.DataPropertyName = "idBus";
            this.idBusColumn.HeaderText = "idBus";
            this.idBusColumn.Name = "idBusColumn";
            this.idBusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idBusColumn.Visible = false;
            // 
            // cellNameColumn
            // 
            this.cellNameColumn.DataPropertyName = "CellName";
            this.cellNameColumn.HeaderText = "Ячейка";
            this.cellNameColumn.Name = "cellNameColumn";
            this.cellNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idCellColumn
            // 
            this.idCellColumn.DataPropertyName = "idCell";
            this.idCellColumn.HeaderText = "idCell";
            this.idCellColumn.Name = "idCellColumn";
            this.idCellColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idCellColumn.Visible = false;
            // 
            // trNameColumn
            // 
            this.trNameColumn.DataPropertyName = "TrName";
            this.trNameColumn.HeaderText = "Трансформатор";
            this.trNameColumn.Name = "trNameColumn";
            this.trNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idTrColumn
            // 
            this.idTrColumn.DataPropertyName = "idTr";
            this.idTrColumn.HeaderText = "idTr";
            this.idTrColumn.Name = "idTrColumn";
            this.idTrColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idTrColumn.Visible = false;
            // 
            // powerColumn
            // 
            this.powerColumn.DataPropertyName = "Power";
            this.powerColumn.HeaderText = "Мощность";
            this.powerColumn.Name = "powerColumn";
            this.powerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // loadColumn
            // 
            this.loadColumn.DataPropertyName = "Load";
            this.loadColumn.HeaderText = "Нагрузка";
            this.loadColumn.Name = "loadColumn";
            this.loadColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateOnColumn
            // 
            this.dateOnColumn.DataPropertyName = "DateOn";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.dateOnColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateOnColumn.HeaderText = "Дата включения";
            this.dateOnColumn.Name = "dateOnColumn";
            this.dateOnColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // noAdmissionKWTColumn
            // 
            this.noAdmissionKWTColumn.DataPropertyName = "noAddmissionKWT";
            this.noAdmissionKWTColumn.HeaderText = "Недоотпуск";
            this.noAdmissionKWTColumn.Name = "noAdmissionKWTColumn";
            this.noAdmissionKWTColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tsbLoadTreeSchmema
            // 
            this.tsbLoadTreeSchmema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoadTreeSchmema.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadTreeSchmema.Image")));
            this.tsbLoadTreeSchmema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadTreeSchmema.Name = "tsbLoadTreeSchmema";
            this.tsbLoadTreeSchmema.Size = new System.Drawing.Size(70, 22);
            this.tsbLoadTreeSchmema.Text = "Заполнить";
            this.tsbLoadTreeSchmema.Click += new System.EventHandler(this.tsbLoadTreeSchmema_Click);
            // 
            // FormTreeSchmObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTreeSub);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTreeSchmObj";
            this.Text = "Дерево объектов схемы";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreeSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private ControlsLbr.TreeDataGridView dgvTreeSub;
        private ControlsLbr.TreeGridColumn subNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCellColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOnColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuDgvTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn noAdmissionKWTColumn;
        private System.Windows.Forms.ToolStripButton tsbLoadTreeSchmema;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}