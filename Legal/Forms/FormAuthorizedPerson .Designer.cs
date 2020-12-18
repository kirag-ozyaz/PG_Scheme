namespace Legal.Forms
{
    partial class FormAuthorizedPerson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorizedPerson));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsCntVal1 = new Legal.DataSet.dsCntVal();
            this.dgvAuthorPerson = new System.Windows.Forms.DataGridView();
            this.tRClassifierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWorkerGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRClassifier1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsAuthorPerson = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntValBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPaymentDoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PostHead = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idWorker = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idPostWorker = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idOrder = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClassifierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWorkerGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClassifier1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuthorPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntValBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCntVal1
            // 
            this.dsCntVal1.DataSetName = "dsCntVal";
            this.dsCntVal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvAuthorPerson
            // 
            this.dgvAuthorPerson.AutoGenerateColumns = false;
            this.dgvAuthorPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthorPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaymentDoc,
            this.PostHead,
            this.idWorker,
            this.idPostWorker,
            this.idOrder});
            this.dgvAuthorPerson.DataSource = this.bsAuthorPerson;
            resources.ApplyResources(this.dgvAuthorPerson, "dgvAuthorPerson");
            this.dgvAuthorPerson.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvAuthorPerson.MultiSelect = false;
            this.dgvAuthorPerson.Name = "dgvAuthorPerson";
            this.dgvAuthorPerson.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAuthorPerson_DataError);
            // 
            // tRClassifierBindingSource
            // 
            this.tRClassifierBindingSource.DataMember = "tR_Classifier";
            this.tRClassifierBindingSource.DataSource = this.dsCntVal1;
            // 
            // vWorkerGroupBindingSource
            // 
            this.vWorkerGroupBindingSource.DataMember = "vWorkerGroup";
            this.vWorkerGroupBindingSource.DataSource = this.dsCntVal1;
            // 
            // tRClassifier1BindingSource
            // 
            this.tRClassifier1BindingSource.DataMember = "tR_Classifier1";
            this.tRClassifier1BindingSource.DataSource = this.dsCntVal1;
            // 
            // bsAuthorPerson
            // 
            this.bsAuthorPerson.DataMember = "tG_AuthorPerson";
            this.bsAuthorPerson.DataSource = this.dsCntVal1;
            // 
            // dsCntValBindingSource
            // 
            this.dsCntValBindingSource.PositionChanged += new System.EventHandler(this.dsCntValBindingSource_PositionChanged);
            // 
            // idPaymentDoc
            // 
            this.idPaymentDoc.DataPropertyName = "idPaymentDoc";
            this.idPaymentDoc.DataSource = this.tRClassifierBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.idPaymentDoc.DefaultCellStyle = dataGridViewCellStyle6;
            this.idPaymentDoc.DisplayMember = "Name";
            resources.ApplyResources(this.idPaymentDoc, "idPaymentDoc");
            this.idPaymentDoc.Name = "idPaymentDoc";
            this.idPaymentDoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPaymentDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPaymentDoc.ValueMember = "Id";
            // 
            // PostHead
            // 
            this.PostHead.DataPropertyName = "PostHead";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PostHead.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.PostHead, "PostHead");
            this.PostHead.Items.AddRange(new object[] {
            "Директор",
            "Главный бухгалтер"});
            this.PostHead.Name = "PostHead";
            this.PostHead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PostHead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idWorker
            // 
            this.idWorker.DataPropertyName = "idWorker";
            this.idWorker.DataSource = this.vWorkerGroupBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.idWorker.DefaultCellStyle = dataGridViewCellStyle8;
            this.idWorker.DisplayMember = "FIO";
            resources.ApplyResources(this.idWorker, "idWorker");
            this.idWorker.Name = "idWorker";
            this.idWorker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idWorker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idWorker.ValueMember = "id";
            // 
            // idPostWorker
            // 
            this.idPostWorker.DataPropertyName = "idPostWorker";
            this.idPostWorker.DataSource = this.vWorkerGroupBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.idPostWorker.DefaultCellStyle = dataGridViewCellStyle9;
            this.idPostWorker.DisplayMember = "Description";
            resources.ApplyResources(this.idPostWorker, "idPostWorker");
            this.idPostWorker.Name = "idPostWorker";
            this.idPostWorker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPostWorker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPostWorker.ValueMember = "idDescription";
            // 
            // idOrder
            // 
            this.idOrder.DataPropertyName = "idOrder";
            this.idOrder.DataSource = this.tRClassifier1BindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.idOrder.DefaultCellStyle = dataGridViewCellStyle10;
            this.idOrder.DisplayMember = "Name";
            resources.ApplyResources(this.idOrder, "idOrder");
            this.idOrder.Name = "idOrder";
            this.idOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idOrder.ValueMember = "Id";
            // 
            // FormAuthorizedPerson
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dgvAuthorPerson);
            this.Name = "FormAuthorizedPerson";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthorizedPerson_FormClosed);
            this.Load += new System.EventHandler(this.FormAuthorizedPerson__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClassifierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWorkerGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClassifier1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuthorPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntValBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet.dsCntVal dsCntVal1;
        private System.Windows.Forms.DataGridView dgvAuthorPerson;
        private System.Windows.Forms.BindingSource bsAuthorPerson;
        private System.Windows.Forms.BindingSource tRClassifierBindingSource;
        private System.Windows.Forms.BindingSource tRClassifier1BindingSource;
        private System.Windows.Forms.BindingSource vWorkerGroupBindingSource;
        private System.Windows.Forms.BindingSource dsCntValBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPaymentDoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn PostHead;
        private System.Windows.Forms.DataGridViewComboBoxColumn idWorker;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPostWorker;
        private System.Windows.Forms.DataGridViewComboBoxColumn idOrder;
    }
}
