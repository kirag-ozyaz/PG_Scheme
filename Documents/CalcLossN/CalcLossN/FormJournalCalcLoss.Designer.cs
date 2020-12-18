using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


	public partial class FormJournalCalcLoss 
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private System.ComponentModel.IContainer components=null;
        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ComponentResourceManager resource = new ComponentResourceManager(typeof(FormJournalCalcLoss));
            this.toolStripMain = new ToolStrip();
            this.toolBtnAddCalc = new ToolStripDropDownButton();
            this.toolBtnEditCalc = new ToolStripButton();
            this.toolBtnDelCalc = new ToolStripButton();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolBtnRefresh = new ToolStripButton();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolBtnReport = new ToolStripButton();
            this.dsCalcN = new CalcLossN.DataSet.DataSetCalc();
            this.dgvCalcLoss = new DataGridViewExcelFilter();
            this.idDgvColumn = new DataGridViewTextBoxColumn();
            this.numDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.idTypeCalcDgvColumn = new DataGridViewTextBoxColumn();
            this.typeCalcDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.dateCalcDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.nameCalcDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.codeAbonentDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idAbnBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameAbnBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idOwnerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameOwnerDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            this.coeffLossesDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.bindingSourceCalcLoss = new BindingSource(this.components);
            this.toolStripMain.SuspendLayout();
            ((ISupportInitialize)this.dsCalcN).BeginInit();
            ((ISupportInitialize)this.dgvCalcLoss).BeginInit();
            ((ISupportInitialize)this.bindingSourceCalcLoss).BeginInit();
            base.SuspendLayout();
            this.toolStripMain.Items.AddRange(new ToolStripItem[]
            {
                this.toolBtnAddCalc,
                this.toolBtnEditCalc,
                this.toolBtnDelCalc,
                this.toolStripSeparator2,
                this.toolBtnRefresh,
                this.toolStripSeparator1,
                this.toolBtnReport
            });
            this.toolStripMain.Location = new Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new Size(876, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";

            this.toolBtnAddCalc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnAddCalc.Image = global::CalcLossN.Properties.Resources.ElementAdd;
            this.toolBtnAddCalc.ImageTransparentColor = Color.Magenta;
            this.toolBtnAddCalc.Name = "toolBtnAddCalc";
            this.toolBtnAddCalc.Size = new Size(29, 22);
            this.toolBtnAddCalc.Text = "Добавить расчет";

            this.toolBtnEditCalc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnEditCalc.Image = global::CalcLossN.Properties.Resources.ElementEdit;
            this.toolBtnEditCalc.ImageTransparentColor = Color.Magenta;
            this.toolBtnEditCalc.Name = "toolBtnEditCalc";
            this.toolBtnEditCalc.Size = new Size(23, 22);
            this.toolBtnEditCalc.Text = "Редактировать расчет";
            this.toolBtnEditCalc.Click +=new System.EventHandler( this.toolBtnEditCalc_Click);

            this.toolBtnDelCalc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnDelCalc.Image = global::CalcLossN.Properties.Resources.ElementDel;
            this.toolBtnDelCalc.ImageTransparentColor = Color.Magenta;
            this.toolBtnDelCalc.Name = "toolBtnDelCalc";
            this.toolBtnDelCalc.Size = new Size(23, 22);
            this.toolBtnDelCalc.Text = "Удаление";
            this.toolBtnDelCalc.Click +=new System.EventHandler( this.toolBtnDelCalc_Click);

            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(6, 25);

            this.toolBtnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::CalcLossN.Properties.Resources.refresh_16;
            this.toolBtnRefresh.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new Size(23, 22);
            this.toolBtnRefresh.Text = "Обновить";
            this.toolBtnRefresh.Click +=new System.EventHandler( this.toolBtnRefresh_Click);

            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(6, 25);
            this.toolBtnReport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnReport.Image = global::CalcLossN.Properties.Resources.Print;
            this.toolBtnReport.ImageTransparentColor = Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new Size(23, 22);
            this.toolBtnReport.Text = "Печать";
            this.toolBtnReport.Click +=new System.EventHandler( this.toolBtnReport_Click);

            this.dsCalcN.DataSetName = "DataSetCalc";
            this.dsCalcN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;

            this.dgvCalcLoss.AllowUserToAddRows = false;
            this.dgvCalcLoss.AllowUserToDeleteRows = false;
            dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            this.dgvCalcLoss.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
            this.dgvCalcLoss.AutoGenerateColumns = false;
            this.dgvCalcLoss.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalcLoss.Columns.AddRange(new DataGridViewColumn[]
            {
                this.idDgvColumn,
                this.numDgvColumn,
                this.idTypeCalcDgvColumn,
                this.typeCalcDataGridViewTextBoxColumn,
                this.dateCalcDataGridViewTextBoxColumn,
                this.nameCalcDataGridViewTextBoxColumn,
                this.idAbnDataGridViewTextBoxColumn,
                this.codeAbonentDgvColumn,
                this.nameAbnDataGridViewTextBoxColumn,
                this.idAbnObjDataGridViewTextBoxColumn,
                this.nameObjDataGridViewTextBoxColumn,
                this.idAbnBalanceDataGridViewTextBoxColumn,
                this.nameAbnBalanceDataGridViewTextBoxColumn,
                this.idOwnerDataGridViewTextBoxColumn,
                this.nameOwnerDataGridViewTextBoxColumn,
                this.commentDataGridViewTextBoxColumn,
                this.isActiveDataGridViewCheckBoxColumn,
                this.deletedDataGridViewCheckBoxColumn,
                this.coeffLossesDataGridViewTextBoxColumn
            });
            this.dgvCalcLoss.DataSource = this.bindingSourceCalcLoss;
            this.dgvCalcLoss.Dock = DockStyle.Fill;
            this.dgvCalcLoss.Location = new Point(0, 25);
            this.dgvCalcLoss.Name = "dgvCalcLoss";
            this.dgvCalcLoss.ReadOnly = true;
            this.dgvCalcLoss.RowHeadersWidth = 21;
            this.dgvCalcLoss.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalcLoss.Size = new Size(876, 334);
            this.dgvCalcLoss.TabIndex = 1;
            this.dgvCalcLoss.CellDoubleClick +=new DataGridViewCellEventHandler( this.dgvCalcLoss_CellDoubleClick);

            this.idDgvColumn.DataPropertyName = "id";
            this.idDgvColumn.HeaderText = "id";
            this.idDgvColumn.Name = "idDgvColumn";
            this.idDgvColumn.ReadOnly = true;
            this.idDgvColumn.Visible = false;

            this.numDgvColumn.DataPropertyName = "num";
            this.numDgvColumn.HeaderText = "№";
            this.numDgvColumn.Name = "numDgvColumn";
            this.numDgvColumn.ReadOnly = true;
            this.numDgvColumn.Width = 70;

            this.idTypeCalcDgvColumn.DataPropertyName = "idTypeCalc";
            this.idTypeCalcDgvColumn.HeaderText = "idTypeCalc";
            this.idTypeCalcDgvColumn.Name = "idTypeCalcDgvColumn";
            this.idTypeCalcDgvColumn.ReadOnly = true;
            this.idTypeCalcDgvColumn.Visible = false;

            this.typeCalcDataGridViewTextBoxColumn.DataPropertyName = "typeCalc";
            this.typeCalcDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeCalcDataGridViewTextBoxColumn.Name = "typeCalcDataGridViewTextBoxColumn";
            this.typeCalcDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeCalcDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dateCalcDataGridViewTextBoxColumn.DataPropertyName = "DateCalc";
            this.dateCalcDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateCalcDataGridViewTextBoxColumn.Name = "dateCalcDataGridViewTextBoxColumn";
            this.dateCalcDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateCalcDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dateCalcDataGridViewTextBoxColumn.Width = 70;
            this.nameCalcDataGridViewTextBoxColumn.DataPropertyName = "nameCalc";
            this.nameCalcDataGridViewTextBoxColumn.HeaderText = "Имя расчета";
            this.nameCalcDataGridViewTextBoxColumn.Name = "nameCalcDataGridViewTextBoxColumn";
            this.nameCalcDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameCalcDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.nameCalcDataGridViewTextBoxColumn.Width = 150;
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            this.codeAbonentDgvColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDgvColumn.HeaderText = "Код абонента";
            this.codeAbonentDgvColumn.Name = "codeAbonentDgvColumn";
            this.codeAbonentDgvColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.DataPropertyName = "nameAbn";
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.idAbnObjDataGridViewTextBoxColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.idAbnObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn.Visible = false;
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "nameObj";
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.idAbnBalanceDataGridViewTextBoxColumn.DataPropertyName = "idAbnBalance";
            this.idAbnBalanceDataGridViewTextBoxColumn.HeaderText = "idAbnBalance";
            this.idAbnBalanceDataGridViewTextBoxColumn.Name = "idAbnBalanceDataGridViewTextBoxColumn";
            this.idAbnBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnBalanceDataGridViewTextBoxColumn.Visible = false;
            this.nameAbnBalanceDataGridViewTextBoxColumn.DataPropertyName = "nameAbnBalance";
            this.nameAbnBalanceDataGridViewTextBoxColumn.HeaderText = "nameAbnBalance";
            this.nameAbnBalanceDataGridViewTextBoxColumn.Name = "nameAbnBalanceDataGridViewTextBoxColumn";
            this.nameAbnBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnBalanceDataGridViewTextBoxColumn.Visible = false;
            this.idOwnerDataGridViewTextBoxColumn.DataPropertyName = "idOwner";
            this.idOwnerDataGridViewTextBoxColumn.HeaderText = "idOwner";
            this.idOwnerDataGridViewTextBoxColumn.Name = "idOwnerDataGridViewTextBoxColumn";
            this.idOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOwnerDataGridViewTextBoxColumn.Visible = false;
            this.nameOwnerDataGridViewTextBoxColumn.DataPropertyName = "nameOwner";
            this.nameOwnerDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.nameOwnerDataGridViewTextBoxColumn.Name = "nameOwnerDataGridViewTextBoxColumn";
            this.nameOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOwnerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Visible = false;
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Visible = false;

            this.coeffLossesDataGridViewTextBoxColumn.DataPropertyName = "CoeffLosses";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.coeffLossesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.coeffLossesDataGridViewTextBoxColumn.HeaderText = "Коэффициент";
            this.coeffLossesDataGridViewTextBoxColumn.Name = "coeffLossesDataGridViewTextBoxColumn";
            this.coeffLossesDataGridViewTextBoxColumn.ReadOnly = true;
            this.coeffLossesDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.bindingSourceCalcLoss.DataMember = "vJ_CalcLoss";
            this.bindingSourceCalcLoss.DataSource = this.dsCalcN;
            this.bindingSourceCalcLoss.CurrentChanged +=new System.EventHandler( this.bindingSourceCalcLoss_CurrentChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(876, 359);
            base.Controls.Add(this.dgvCalcLoss);
            base.Controls.Add(this.toolStripMain);
            base.Icon = (System.Drawing.Icon)global::CalcLossN.Properties.Resources.icon2;
            base.Name = "FormJournalCalcLoss";
            this.Text = "Журнал расчетов потерь (N)";
            base.Load +=new System.EventHandler( this.FormJournalCalcLoss_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((ISupportInitialize)this.dsCalcN).EndInit();
            ((ISupportInitialize)this.dgvCalcLoss).EndInit();
            ((ISupportInitialize)this.bindingSourceCalcLoss).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private ToolStrip toolStripMain;

        // private dsCalc dsCalcN;
        private CalcLossN.DataSet.DataSetCalc dsCalcN;

        private DataGridViewExcelFilter dgvCalcLoss;

        private BindingSource bindingSourceCalcLoss;

        private ToolStripButton toolBtnEditCalc;

        private ToolStripButton toolBtnDelCalc;

        private ToolStripDropDownButton toolBtnAddCalc;

        private ToolStripSeparator toolStripSeparator1;

        private ToolStripButton toolBtnReport;

        private ToolStripSeparator toolStripSeparator2;

        private ToolStripButton toolBtnRefresh;

        private DataGridViewTextBoxColumn idDgvColumn;

        private DataGridViewFilterTextBoxColumn numDgvColumn;

        private DataGridViewTextBoxColumn idTypeCalcDgvColumn;

        private DataGridViewFilterTextBoxColumn typeCalcDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn dateCalcDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameCalcDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn codeAbonentDgvColumn;

        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idAbnBalanceDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn nameAbnBalanceDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idOwnerDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameOwnerDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;

        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;

        private DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;

        private DataGridViewFilterTextBoxColumn coeffLossesDataGridViewTextBoxColumn;
    }

