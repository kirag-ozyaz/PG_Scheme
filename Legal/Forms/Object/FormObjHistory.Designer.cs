namespace Legal.Forms.Object
{
    partial class FormObjHistory
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewObjReg = new System.Windows.Forms.DataGridView();
            this.vGAbnObjRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj = new Legal.DataSet.dsObj();
            this.idObjReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tariff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePowerFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalcLoss = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.abnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abnNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SubNetComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGAbnObjRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewObjReg
            // 
            this.dataGridViewObjReg.AllowUserToAddRows = false;
            this.dataGridViewObjReg.AllowUserToDeleteRows = false;
            this.dataGridViewObjReg.AutoGenerateColumns = false;
            this.dataGridViewObjReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObjReg,
            this.idAbnObj,
            this.dateChange,
            this.AbnName,
            this.statusName,
            this.Tariff,
            this.powerSet,
            this.powerOther,
            this.powerFact,
            this.DatePowerFact,
            this.regime,
            this.kLoss,
            this.CalcLoss,
            this.abnSale,
            this.abnNet,
            this.category,
            this.NumberTP,
            this.DateTP,
            this.NumberTU,
            this.DateTU,
            this.SubNet,
            this.SubNetComment,
            this.comment});
            this.dataGridViewObjReg.DataSource = this.vGAbnObjRegBindingSource;
            this.dataGridViewObjReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewObjReg.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewObjReg.Name = "dataGridViewObjReg";
            this.dataGridViewObjReg.ReadOnly = true;
            this.dataGridViewObjReg.RowTemplate.Height = 24;
            this.dataGridViewObjReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewObjReg.Size = new System.Drawing.Size(992, 668);
            this.dataGridViewObjReg.TabIndex = 0;
            // 
            // vGAbnObjRegBindingSource
            // 
            this.vGAbnObjRegBindingSource.DataMember = "vG_AbnObjReg";
            this.vGAbnObjRegBindingSource.DataSource = this.dsObj;
            // 
            // dsObj
            // 
            this.dsObj.DataSetName = "dsObj";
            this.dsObj.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idObjReg
            // 
            this.idObjReg.DataPropertyName = "id";
            this.idObjReg.HeaderText = "id";
            this.idObjReg.Name = "idObjReg";
            this.idObjReg.ReadOnly = true;
            this.idObjReg.Visible = false;
            // 
            // idAbnObj
            // 
            this.idAbnObj.DataPropertyName = "idAbnObj";
            this.idAbnObj.HeaderText = "idAbnObj";
            this.idAbnObj.Name = "idAbnObj";
            this.idAbnObj.ReadOnly = true;
            this.idAbnObj.Visible = false;
            // 
            // dateChange
            // 
            this.dateChange.DataPropertyName = "DateChange";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dateChange.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateChange.HeaderText = "Дата";
            this.dateChange.Name = "dateChange";
            this.dateChange.ReadOnly = true;
            // 
            // AbnName
            // 
            this.AbnName.DataPropertyName = "AbnName";
            this.AbnName.HeaderText = "Владелец";
            this.AbnName.Name = "AbnName";
            this.AbnName.ReadOnly = true;
            // 
            // statusName
            // 
            this.statusName.DataPropertyName = "StatusName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusName.DefaultCellStyle = dataGridViewCellStyle2;
            this.statusName.HeaderText = "Статус";
            this.statusName.Name = "statusName";
            this.statusName.ReadOnly = true;
            this.statusName.Width = 150;
            // 
            // Tariff
            // 
            this.Tariff.DataPropertyName = "Tariff";
            this.Tariff.HeaderText = "Тариф";
            this.Tariff.Name = "Tariff";
            this.Tariff.ReadOnly = true;
            // 
            // powerSet
            // 
            this.powerSet.DataPropertyName = "PowerSet";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.powerSet.DefaultCellStyle = dataGridViewCellStyle3;
            this.powerSet.HeaderText = "P разр.";
            this.powerSet.Name = "powerSet";
            this.powerSet.ReadOnly = true;
            this.powerSet.Width = 75;
            // 
            // powerOther
            // 
            this.powerOther.DataPropertyName = "PowerOther";
            this.powerOther.HeaderText = "P догов.";
            this.powerOther.Name = "powerOther";
            this.powerOther.ReadOnly = true;
            this.powerOther.Width = 75;
            // 
            // powerFact
            // 
            this.powerFact.DataPropertyName = "PowerFact";
            this.powerFact.HeaderText = "P измер.";
            this.powerFact.Name = "powerFact";
            this.powerFact.ReadOnly = true;
            this.powerFact.Width = 75;
            // 
            // DatePowerFact
            // 
            this.DatePowerFact.DataPropertyName = "DatePowerFact";
            this.DatePowerFact.HeaderText = "Дата измер.";
            this.DatePowerFact.Name = "DatePowerFact";
            this.DatePowerFact.ReadOnly = true;
            // 
            // regime
            // 
            this.regime.DataPropertyName = "Regime";
            this.regime.HeaderText = "Режим";
            this.regime.Name = "regime";
            this.regime.ReadOnly = true;
            this.regime.Width = 75;
            // 
            // kLoss
            // 
            this.kLoss.DataPropertyName = "KLoss";
            this.kLoss.HeaderText = "Потери";
            this.kLoss.Name = "kLoss";
            this.kLoss.ReadOnly = true;
            this.kLoss.Width = 75;
            // 
            // CalcLoss
            // 
            this.CalcLoss.DataPropertyName = "CalcLoss";
            this.CalcLoss.HeaderText = "Рассч. потери";
            this.CalcLoss.Name = "CalcLoss";
            this.CalcLoss.ReadOnly = true;
            // 
            // abnSale
            // 
            this.abnSale.DataPropertyName = "AbnSale";
            this.abnSale.HeaderText = "Сбыт";
            this.abnSale.Name = "abnSale";
            this.abnSale.ReadOnly = true;
            this.abnSale.Width = 200;
            // 
            // abnNet
            // 
            this.abnNet.DataPropertyName = "AbnNet";
            this.abnNet.HeaderText = "Сеть";
            this.abnNet.Name = "abnNet";
            this.abnNet.ReadOnly = true;
            this.abnNet.Width = 200;
            // 
            // category
            // 
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Категория";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 75;
            // 
            // NumberTP
            // 
            this.NumberTP.DataPropertyName = "NumberTP";
            this.NumberTP.HeaderText = "№ ТП";
            this.NumberTP.Name = "NumberTP";
            this.NumberTP.ReadOnly = true;
            // 
            // DateTP
            // 
            this.DateTP.DataPropertyName = "DateTP";
            this.DateTP.HeaderText = "Дата ТП";
            this.DateTP.Name = "DateTP";
            this.DateTP.ReadOnly = true;
            // 
            // NumberTU
            // 
            this.NumberTU.DataPropertyName = "NumberTU";
            this.NumberTU.HeaderText = "№ ТУ";
            this.NumberTU.Name = "NumberTU";
            this.NumberTU.ReadOnly = true;
            // 
            // DateTU
            // 
            this.DateTU.DataPropertyName = "DateTU";
            this.DateTU.HeaderText = "Дата ТУ";
            this.DateTU.Name = "DateTU";
            this.DateTU.ReadOnly = true;
            // 
            // SubNet
            // 
            this.SubNet.DataPropertyName = "SubNet";
            this.SubNet.HeaderText = "Опосред.";
            this.SubNet.Name = "SubNet";
            this.SubNet.ReadOnly = true;
            // 
            // SubNetComment
            // 
            this.SubNetComment.DataPropertyName = "SubNetComment";
            this.SubNetComment.HeaderText = "Опосред.прим.";
            this.SubNetComment.Name = "SubNetComment";
            this.SubNetComment.ReadOnly = true;
            // 
            // comment
            // 
            this.comment.DataPropertyName = "Comment";
            this.comment.HeaderText = "Коммент.";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.Width = 300;
            // 
            // FormObjHistory
            // 
            this.ClientSize = new System.Drawing.Size(992, 668);
            this.Controls.Add(this.dataGridViewObjReg);
            this.Name = "FormObjHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История параметров объекта";
            this.Load += new System.EventHandler(this.FormObjHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGAbnObjRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewObjReg;
        private System.Windows.Forms.BindingSource vGAbnObjRegBindingSource;
        private Legal.DataSet.dsObj dsObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tariff;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePowerFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn regime;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLoss;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CalcLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTU;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SubNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNetComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    }
}
