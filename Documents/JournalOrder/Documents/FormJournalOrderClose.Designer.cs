using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JournalOrder
{
    internal partial class FormJournalOrderClose
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormJournalOrderClose));
            this.tabControl = new TabControl();
            this.tabPageRegistered = new TabPage();
            this.dgvOrderRegistered = new DataGridViewExcelFilter();
            this.numDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.dateOutputDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.outputMakerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.srNumDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new DataGridViewFilterDateTimePickerColumn();
            this.dateEndDataGridViewTextBoxColumn = new DataGridViewFilterDateTimePickerColumn();
            this.instructionDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idSRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.srNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.headworkerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.headFioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.acceptworkerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.acceptFIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idDgvColumnReg = new DataGridViewTextBoxColumn();
            this.watchWorkerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.watchFIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.makerWorkerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.makerFIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.otherInstructionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.outputWorkerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.outputFIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.registeredDgvColumn = new DataGridViewCheckBoxColumn();
            this.dateCloseDgvColumn = new DataGridViewTextBoxColumn();
            this.closeWorkerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.closeFIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.beginResDgvColumn = new DataGridViewTextBoxColumn();
            this.EndResDgvColumn = new DataGridViewTextBoxColumn();
            this.resWorkerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.resWorkerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.bsOrderRegistered = new BindingSource(this.components);
            this.dsOrderRegistered = new DataSet.DataSetOrder();
            this.panelRegistered = new Panel();
            this.buttonCloseSelReg = new Button();
            this.buttonCloseAllReg = new Button();
            this.dateTimePickerCloseReg = new DateTimePicker();
            this.label2 = new Label();
            this.cmbCloseWorkerRegistered = new ComboBox();
            this.label1 = new Label();
            this.tabPageRes = new TabPage();
            this.dgvOrder = new DataGridViewExcelFilter();
            this.dataGridViewFilterTextBoxColumn1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterDateTimePickerColumn1 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewFilterDateTimePickerColumn2 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewFilterTextBoxColumn3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            this.idDgvColumn = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            this.registeredDgvColumnRes = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            this.beginResDgvColumnRes = new DataGridViewTextBoxColumn();
            this.endResDgvColumnRes = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
            this.bsOrder = new BindingSource(this.components);
            this.dataSetOrder = new DataSet.DataSetOrder();
            this.panel1 = new Panel();
            this.buttonCloseSelRes = new Button();
            this.buttonCloseAllRes = new Button();
            this.dateTimePickerRes = new DateTimePicker();
            this.label3 = new Label();
            this.cmbOrderRes = new ComboBox();
            this.label4 = new Label();
            this.tabControl.SuspendLayout();
            this.tabPageRegistered.SuspendLayout();
            ((ISupportInitialize)this.dgvOrderRegistered).BeginInit();
            ((ISupportInitialize)this.bsOrderRegistered).BeginInit();
            ((ISupportInitialize)this.dsOrderRegistered).BeginInit();
            this.panelRegistered.SuspendLayout();
            this.tabPageRes.SuspendLayout();
            ((ISupportInitialize)this.dgvOrder).BeginInit();
            ((ISupportInitialize)this.bsOrder).BeginInit();
            ((ISupportInitialize)this.dataSetOrder).BeginInit();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.tabControl.Controls.Add(this.tabPageRegistered);
            this.tabControl.Controls.Add(this.tabPageRes);
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.Location = new Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(783, 375);
            this.tabControl.TabIndex = 0;
            this.tabPageRegistered.Controls.Add(this.dgvOrderRegistered);
            this.tabPageRegistered.Controls.Add(this.panelRegistered);
            this.tabPageRegistered.Location = new Point(4, 22);
            this.tabPageRegistered.Name = "tabPageRegistered";
            this.tabPageRegistered.Padding = new Padding(3);
            this.tabPageRegistered.Size = new Size(775, 349);
            this.tabPageRegistered.TabIndex = 0;
            this.tabPageRegistered.Text = "Зарегистрированные";
            this.tabPageRegistered.UseVisualStyleBackColor = true;
            this.dgvOrderRegistered.AllowUserToAddRows = false;
            this.dgvOrderRegistered.AllowUserToDeleteRows = false;
            this.dgvOrderRegistered.AutoGenerateColumns = false;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvOrderRegistered.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvOrderRegistered.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderRegistered.Columns.AddRange(new DataGridViewColumn[]
            {
            this.numDgvColumn,
            this.dateOutputDataGridViewTextBoxColumn,
            this.outputMakerDataGridViewTextBoxColumn,
            this.srNumDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.instructionDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.idSRDataGridViewTextBoxColumn,
            this.srNameDataGridViewTextBoxColumn,
            this.headworkerDataGridViewTextBoxColumn,
            this.headFioDataGridViewTextBoxColumn,
            this.acceptworkerDataGridViewTextBoxColumn,
            this.acceptFIODataGridViewTextBoxColumn,
            this.idDgvColumnReg,
            this.watchWorkerDataGridViewTextBoxColumn,
            this.watchFIODataGridViewTextBoxColumn,
            this.makerWorkerDataGridViewTextBoxColumn,
            this.makerFIODataGridViewTextBoxColumn,
            this.otherInstructionDataGridViewTextBoxColumn,
            this.outputWorkerDataGridViewTextBoxColumn,
            this.outputFIODataGridViewTextBoxColumn,
            this.registeredDgvColumn,
            this.dateCloseDgvColumn,
            this.closeWorkerDataGridViewTextBoxColumn,
            this.closeFIODataGridViewTextBoxColumn,
            this.beginResDgvColumn,
            this.EndResDgvColumn,
            this.resWorkerIdDataGridViewTextBoxColumn,
            this.resWorkerDataGridViewTextBoxColumn
            });
            this.dgvOrderRegistered.DataSource = this.bsOrderRegistered;
            this.dgvOrderRegistered.Dock = DockStyle.Fill;
            this.dgvOrderRegistered.Location = new Point(3, 3);
            this.dgvOrderRegistered.Name = "dgvOrderRegistered";
            this.dgvOrderRegistered.ReadOnly = true;
            this.dgvOrderRegistered.RowHeadersWidth = 21;
            this.dgvOrderRegistered.RowTemplate.Height = 44;
            this.dgvOrderRegistered.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderRegistered.Size = new Size(769, 299);
            this.dgvOrderRegistered.TabIndex = 1;
            this.dgvOrderRegistered.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgvOrderRegistered_CellContentDoubleClick);
            this.numDgvColumn.DataPropertyName = "num";
            this.numDgvColumn.HeaderText = "№";
            this.numDgvColumn.Name = "numDgvColumn";
            this.numDgvColumn.ReadOnly = true;
            this.numDgvColumn.Resizable = DataGridViewTriState.True;
            this.numDgvColumn.Width = 50;
            this.dateOutputDataGridViewTextBoxColumn.DataPropertyName = "dateOutput";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy HH:mm:ss";
            this.dateOutputDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateOutputDataGridViewTextBoxColumn.HeaderText = "Дата выдачи наряда";
            this.dateOutputDataGridViewTextBoxColumn.Name = "dateOutputDataGridViewTextBoxColumn";
            this.dateOutputDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOutputDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            this.dateOutputDataGridViewTextBoxColumn.Width = 125;
            this.outputMakerDataGridViewTextBoxColumn.DataPropertyName = "OutputMaker";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.outputMakerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.outputMakerDataGridViewTextBoxColumn.HeaderText = "Наряд выдал Производитель работ";
            this.outputMakerDataGridViewTextBoxColumn.Name = "outputMakerDataGridViewTextBoxColumn";
            this.outputMakerDataGridViewTextBoxColumn.ReadOnly = true;
            this.outputMakerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            this.srNumDataGridViewTextBoxColumn.DataPropertyName = "srNum";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.srNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.srNumDataGridViewTextBoxColumn.HeaderText = "Сетевой район";
            this.srNumDataGridViewTextBoxColumn.Name = "srNumDataGridViewTextBoxColumn";
            this.srNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.srNumDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            this.srNumDataGridViewTextBoxColumn.Width = 80;
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "dateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Дата начала работ";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateBeginDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dateBeginDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dateBeginDataGridViewTextBoxColumn.Width = 80;
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "dateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Дата окончания работ";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEndDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dateEndDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dateEndDataGridViewTextBoxColumn.Width = 80;
            this.instructionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.instructionDataGridViewTextBoxColumn.DataPropertyName = "instruction";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            this.instructionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.instructionDataGridViewTextBoxColumn.HeaderText = "Содержание работ";
            this.instructionDataGridViewTextBoxColumn.Name = "instructionDataGridViewTextBoxColumn";
            this.instructionDataGridViewTextBoxColumn.ReadOnly = true;
            this.instructionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            this.resolutionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Разрешение выдал";
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.resolutionDataGridViewTextBoxColumn.Visible = false;
            this.resolutionDataGridViewTextBoxColumn.Width = 120;
            this.idSRDataGridViewTextBoxColumn.DataPropertyName = "idSR";
            this.idSRDataGridViewTextBoxColumn.HeaderText = "idSR";
            this.idSRDataGridViewTextBoxColumn.Name = "idSRDataGridViewTextBoxColumn";
            this.idSRDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSRDataGridViewTextBoxColumn.Visible = false;
            this.srNameDataGridViewTextBoxColumn.DataPropertyName = "srName";
            this.srNameDataGridViewTextBoxColumn.HeaderText = "srName";
            this.srNameDataGridViewTextBoxColumn.Name = "srNameDataGridViewTextBoxColumn";
            this.srNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.srNameDataGridViewTextBoxColumn.Visible = false;
            this.headworkerDataGridViewTextBoxColumn.DataPropertyName = "headworker";
            this.headworkerDataGridViewTextBoxColumn.HeaderText = "headworker";
            this.headworkerDataGridViewTextBoxColumn.Name = "headworkerDataGridViewTextBoxColumn";
            this.headworkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.headworkerDataGridViewTextBoxColumn.Visible = false;
            this.headFioDataGridViewTextBoxColumn.DataPropertyName = "headFio";
            this.headFioDataGridViewTextBoxColumn.HeaderText = "headFio";
            this.headFioDataGridViewTextBoxColumn.Name = "headFioDataGridViewTextBoxColumn";
            this.headFioDataGridViewTextBoxColumn.ReadOnly = true;
            this.headFioDataGridViewTextBoxColumn.Visible = false;
            this.acceptworkerDataGridViewTextBoxColumn.DataPropertyName = "acceptworker";
            this.acceptworkerDataGridViewTextBoxColumn.HeaderText = "acceptworker";
            this.acceptworkerDataGridViewTextBoxColumn.Name = "acceptworkerDataGridViewTextBoxColumn";
            this.acceptworkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.acceptworkerDataGridViewTextBoxColumn.Visible = false;
            this.acceptFIODataGridViewTextBoxColumn.DataPropertyName = "acceptFIO";
            this.acceptFIODataGridViewTextBoxColumn.HeaderText = "acceptFIO";
            this.acceptFIODataGridViewTextBoxColumn.Name = "acceptFIODataGridViewTextBoxColumn";
            this.acceptFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.acceptFIODataGridViewTextBoxColumn.Visible = false;
            this.idDgvColumnReg.DataPropertyName = "id";
            this.idDgvColumnReg.HeaderText = "id";
            this.idDgvColumnReg.Name = "idDgvColumnReg";
            this.idDgvColumnReg.ReadOnly = true;
            this.idDgvColumnReg.Visible = false;
            this.watchWorkerDataGridViewTextBoxColumn.DataPropertyName = "watchWorker";
            this.watchWorkerDataGridViewTextBoxColumn.HeaderText = "watchWorker";
            this.watchWorkerDataGridViewTextBoxColumn.Name = "watchWorkerDataGridViewTextBoxColumn";
            this.watchWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.watchWorkerDataGridViewTextBoxColumn.Visible = false;
            this.watchFIODataGridViewTextBoxColumn.DataPropertyName = "watchFIO";
            this.watchFIODataGridViewTextBoxColumn.HeaderText = "watchFIO";
            this.watchFIODataGridViewTextBoxColumn.Name = "watchFIODataGridViewTextBoxColumn";
            this.watchFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.watchFIODataGridViewTextBoxColumn.Visible = false;
            this.makerWorkerDataGridViewTextBoxColumn.DataPropertyName = "makerWorker";
            this.makerWorkerDataGridViewTextBoxColumn.HeaderText = "makerWorker";
            this.makerWorkerDataGridViewTextBoxColumn.Name = "makerWorkerDataGridViewTextBoxColumn";
            this.makerWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.makerWorkerDataGridViewTextBoxColumn.Visible = false;
            this.makerFIODataGridViewTextBoxColumn.DataPropertyName = "makerFIO";
            this.makerFIODataGridViewTextBoxColumn.HeaderText = "makerFIO";
            this.makerFIODataGridViewTextBoxColumn.Name = "makerFIODataGridViewTextBoxColumn";
            this.makerFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.makerFIODataGridViewTextBoxColumn.Visible = false;
            this.otherInstructionDataGridViewTextBoxColumn.DataPropertyName = "otherInstruction";
            this.otherInstructionDataGridViewTextBoxColumn.HeaderText = "otherInstruction";
            this.otherInstructionDataGridViewTextBoxColumn.Name = "otherInstructionDataGridViewTextBoxColumn";
            this.otherInstructionDataGridViewTextBoxColumn.ReadOnly = true;
            this.otherInstructionDataGridViewTextBoxColumn.Visible = false;
            this.outputWorkerDataGridViewTextBoxColumn.DataPropertyName = "outputWorker";
            this.outputWorkerDataGridViewTextBoxColumn.HeaderText = "outputWorker";
            this.outputWorkerDataGridViewTextBoxColumn.Name = "outputWorkerDataGridViewTextBoxColumn";
            this.outputWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.outputWorkerDataGridViewTextBoxColumn.Visible = false;
            this.outputFIODataGridViewTextBoxColumn.DataPropertyName = "outputFIO";
            this.outputFIODataGridViewTextBoxColumn.HeaderText = "outputFIO";
            this.outputFIODataGridViewTextBoxColumn.Name = "outputFIODataGridViewTextBoxColumn";
            this.outputFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.outputFIODataGridViewTextBoxColumn.Visible = false;
            this.registeredDgvColumn.DataPropertyName = "registered";
            this.registeredDgvColumn.HeaderText = "registered";
            this.registeredDgvColumn.Name = "registeredDgvColumn";
            this.registeredDgvColumn.ReadOnly = true;
            this.registeredDgvColumn.Visible = false;
            this.dateCloseDgvColumn.DataPropertyName = "dateClose";
            this.dateCloseDgvColumn.HeaderText = "dateClose";
            this.dateCloseDgvColumn.Name = "dateCloseDgvColumn";
            this.dateCloseDgvColumn.ReadOnly = true;
            this.dateCloseDgvColumn.Visible = false;
            this.closeWorkerDataGridViewTextBoxColumn.DataPropertyName = "closeWorker";
            this.closeWorkerDataGridViewTextBoxColumn.HeaderText = "closeWorker";
            this.closeWorkerDataGridViewTextBoxColumn.Name = "closeWorkerDataGridViewTextBoxColumn";
            this.closeWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.closeWorkerDataGridViewTextBoxColumn.Visible = false;
            this.closeFIODataGridViewTextBoxColumn.DataPropertyName = "closeFIO";
            this.closeFIODataGridViewTextBoxColumn.HeaderText = "closeFIO";
            this.closeFIODataGridViewTextBoxColumn.Name = "closeFIODataGridViewTextBoxColumn";
            this.closeFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.closeFIODataGridViewTextBoxColumn.Visible = false;
            this.beginResDgvColumn.DataPropertyName = "beginRes";
            this.beginResDgvColumn.HeaderText = "beginRes";
            this.beginResDgvColumn.Name = "beginResDgvColumn";
            this.beginResDgvColumn.ReadOnly = true;
            this.beginResDgvColumn.Visible = false;
            this.EndResDgvColumn.DataPropertyName = "EndRes";
            this.EndResDgvColumn.HeaderText = "EndRes";
            this.EndResDgvColumn.Name = "EndResDgvColumn";
            this.EndResDgvColumn.ReadOnly = true;
            this.EndResDgvColumn.Visible = false;
            this.resWorkerIdDataGridViewTextBoxColumn.DataPropertyName = "resWorkerId";
            this.resWorkerIdDataGridViewTextBoxColumn.HeaderText = "resWorkerId";
            this.resWorkerIdDataGridViewTextBoxColumn.Name = "resWorkerIdDataGridViewTextBoxColumn";
            this.resWorkerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.resWorkerIdDataGridViewTextBoxColumn.Visible = false;
            this.resWorkerDataGridViewTextBoxColumn.DataPropertyName = "resWorker";
            this.resWorkerDataGridViewTextBoxColumn.HeaderText = "resWorker";
            this.resWorkerDataGridViewTextBoxColumn.Name = "resWorkerDataGridViewTextBoxColumn";
            this.resWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.resWorkerDataGridViewTextBoxColumn.Visible = false;
            this.bsOrderRegistered.DataMember = "vJ_Order";
            this.bsOrderRegistered.DataSource = this.dsOrderRegistered;
            this.dsOrderRegistered.DataSetName = "DataSetOrder";
            this.dsOrderRegistered.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.panelRegistered.Controls.Add(this.buttonCloseSelReg);
            this.panelRegistered.Controls.Add(this.buttonCloseAllReg);
            this.panelRegistered.Controls.Add(this.dateTimePickerCloseReg);
            this.panelRegistered.Controls.Add(this.label2);
            this.panelRegistered.Controls.Add(this.cmbCloseWorkerRegistered);
            this.panelRegistered.Controls.Add(this.label1);
            this.panelRegistered.Dock = DockStyle.Bottom;
            this.panelRegistered.Location = new Point(3, 302);
            this.panelRegistered.Name = "panelRegistered";
            this.panelRegistered.Size = new Size(769, 44);
            this.panelRegistered.TabIndex = 2;
            this.buttonCloseSelReg.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.buttonCloseSelReg.Location = new Point(622, 16);
            this.buttonCloseSelReg.Name = "buttonCloseSelReg";
            this.buttonCloseSelReg.Size = new Size(142, 23);
            this.buttonCloseSelReg.TabIndex = 5;
            this.buttonCloseSelReg.Text = "Закрыть выделенные";
            this.buttonCloseSelReg.UseVisualStyleBackColor = true;
            this.buttonCloseSelReg.Click += new System.EventHandler(this.buttonCloseSelReg_Click);
            this.buttonCloseAllReg.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.buttonCloseAllReg.Location = new Point(519, 16);
            this.buttonCloseAllReg.Name = "buttonCloseAllReg";
            this.buttonCloseAllReg.Size = new Size(97, 23);
            this.buttonCloseAllReg.TabIndex = 4;
            this.buttonCloseAllReg.Text = "Закрыть все";
            this.buttonCloseAllReg.UseVisualStyleBackColor = true;
            this.buttonCloseAllReg.Click += new System.EventHandler(this.buttonCloseAllReg_Click);
            this.dateTimePickerCloseReg.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerCloseReg.Enabled = false;
            this.dateTimePickerCloseReg.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerCloseReg.Location = new Point(180, 19);
            this.dateTimePickerCloseReg.Name = "dateTimePickerCloseReg";
            this.dateTimePickerCloseReg.Size = new Size(133, 20);
            this.dateTimePickerCloseReg.TabIndex = 3;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(177, 3);
            this.label2.Name = "label2";
            this.label2.Size = new Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата";
            this.cmbCloseWorkerRegistered.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCloseWorkerRegistered.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCloseWorkerRegistered.DataSource = this.dsOrderRegistered;
            this.cmbCloseWorkerRegistered.DisplayMember = "vWorkerGroup.FIO";
            this.cmbCloseWorkerRegistered.FormattingEnabled = true;
            this.cmbCloseWorkerRegistered.Location = new Point(8, 18);
            this.cmbCloseWorkerRegistered.Name = "cmbCloseWorkerRegistered";
            this.cmbCloseWorkerRegistered.Size = new Size(163, 21);
            this.cmbCloseWorkerRegistered.TabIndex = 1;
            this.cmbCloseWorkerRegistered.ValueMember = "vR_Worker.id";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диспетчер";
            this.tabPageRes.Controls.Add(this.dgvOrder);
            this.tabPageRes.Controls.Add(this.panel1);
            this.tabPageRes.Location = new Point(4, 22);
            this.tabPageRes.Name = "tabPageRes";
            this.tabPageRes.Padding = new Padding(3);
            this.tabPageRes.Size = new Size(775, 349);
            this.tabPageRes.TabIndex = 1;
            this.tabPageRes.Text = "Действующие";
            this.tabPageRes.UseVisualStyleBackColor = true;
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new DataGridViewColumn[]
            {
            this.dataGridViewFilterTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewFilterTextBoxColumn2,
            this.dataGridViewFilterDateTimePickerColumn1,
            this.dataGridViewFilterDateTimePickerColumn2,
            this.dataGridViewFilterTextBoxColumn3,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.idDgvColumn,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.registeredDgvColumnRes,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.beginResDgvColumnRes,
            this.endResDgvColumnRes,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23
            });
            this.dgvOrder.DataSource = this.bsOrder;
            this.dgvOrder.Dock = DockStyle.Fill;
            this.dgvOrder.Location = new Point(3, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 21;
            this.dgvOrder.RowTemplate.Height = 44;
            this.dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new Size(769, 299);
            this.dgvOrder.TabIndex = 1;
            this.dgvOrder.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgvOrder_CellContentDoubleClick);
            this.dgvOrder.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvOrder_CellFormatting);
            this.dataGridViewFilterTextBoxColumn1.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn1.HeaderText = "№";
            this.dataGridViewFilterTextBoxColumn1.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn1.Width = 50;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dateOutput";
            dataGridViewCellStyle8.Format = "dd.MM.yyyy HH:mm:ss";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата выдачи наряда";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 125;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OutputMaker";
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "Наряд выдал Производитель работ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            this.dataGridViewFilterTextBoxColumn2.DataPropertyName = "srNum";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFilterTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewFilterTextBoxColumn2.HeaderText = "Сетевой район";
            this.dataGridViewFilterTextBoxColumn2.Name = "dataGridViewFilterTextBoxColumn2";
            this.dataGridViewFilterTextBoxColumn2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn2.Resizable = DataGridViewTriState.False;
            this.dataGridViewFilterTextBoxColumn2.Width = 80;
            this.dataGridViewFilterDateTimePickerColumn1.DataPropertyName = "dateBegin";
            this.dataGridViewFilterDateTimePickerColumn1.HeaderText = "Дата начала работ";
            this.dataGridViewFilterDateTimePickerColumn1.Name = "dataGridViewFilterDateTimePickerColumn1";
            this.dataGridViewFilterDateTimePickerColumn1.ReadOnly = true;
            this.dataGridViewFilterDateTimePickerColumn1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterDateTimePickerColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewFilterDateTimePickerColumn1.Width = 80;
            this.dataGridViewFilterDateTimePickerColumn2.DataPropertyName = "dateEnd";
            this.dataGridViewFilterDateTimePickerColumn2.HeaderText = "Дата окончания работ";
            this.dataGridViewFilterDateTimePickerColumn2.Name = "dataGridViewFilterDateTimePickerColumn2";
            this.dataGridViewFilterDateTimePickerColumn2.ReadOnly = true;
            this.dataGridViewFilterDateTimePickerColumn2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterDateTimePickerColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewFilterDateTimePickerColumn2.Width = 80;
            this.dataGridViewFilterTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn3.DataPropertyName = "instruction";
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewFilterTextBoxColumn3.HeaderText = "Содержание работ";
            this.dataGridViewFilterTextBoxColumn3.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn3.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Resolution";
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn3.HeaderText = "Разрешение выдал";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idSR";
            this.dataGridViewTextBoxColumn4.HeaderText = "idSR";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "srName";
            this.dataGridViewTextBoxColumn5.HeaderText = "srName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "headworker";
            this.dataGridViewTextBoxColumn6.HeaderText = "headworker";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "headFio";
            this.dataGridViewTextBoxColumn7.HeaderText = "headFio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "acceptworker";
            this.dataGridViewTextBoxColumn8.HeaderText = "acceptworker";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "acceptFIO";
            this.dataGridViewTextBoxColumn9.HeaderText = "acceptFIO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.idDgvColumn.DataPropertyName = "id";
            this.idDgvColumn.HeaderText = "id";
            this.idDgvColumn.Name = "idDgvColumn";
            this.idDgvColumn.ReadOnly = true;
            this.idDgvColumn.Visible = false;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "watchWorker";
            this.dataGridViewTextBoxColumn10.HeaderText = "watchWorker";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "watchFIO";
            this.dataGridViewTextBoxColumn11.HeaderText = "watchFIO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "makerWorker";
            this.dataGridViewTextBoxColumn12.HeaderText = "makerWorker";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "makerFIO";
            this.dataGridViewTextBoxColumn13.HeaderText = "makerFIO";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "otherInstruction";
            this.dataGridViewTextBoxColumn14.HeaderText = "otherInstruction";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "outputWorker";
            this.dataGridViewTextBoxColumn15.HeaderText = "outputWorker";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "outputFIO";
            this.dataGridViewTextBoxColumn16.HeaderText = "outputFIO";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            this.registeredDgvColumnRes.DataPropertyName = "registered";
            this.registeredDgvColumnRes.HeaderText = "registered";
            this.registeredDgvColumnRes.Name = "registeredDgvColumnRes";
            this.registeredDgvColumnRes.ReadOnly = true;
            this.registeredDgvColumnRes.Visible = false;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "dateClose";
            this.dataGridViewTextBoxColumn17.HeaderText = "dateClose";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "closeWorker";
            this.dataGridViewTextBoxColumn18.HeaderText = "closeWorker";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "closeFIO";
            this.dataGridViewTextBoxColumn19.HeaderText = "closeFIO";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            this.beginResDgvColumnRes.DataPropertyName = "beginRes";
            this.beginResDgvColumnRes.HeaderText = "beginRes";
            this.beginResDgvColumnRes.Name = "beginResDgvColumnRes";
            this.beginResDgvColumnRes.ReadOnly = true;
            this.beginResDgvColumnRes.Visible = false;
            this.endResDgvColumnRes.DataPropertyName = "EndRes";
            this.endResDgvColumnRes.HeaderText = "EndRes";
            this.endResDgvColumnRes.Name = "endResDgvColumnRes";
            this.endResDgvColumnRes.ReadOnly = true;
            this.endResDgvColumnRes.Visible = false;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "resWorkerId";
            this.dataGridViewTextBoxColumn22.HeaderText = "resWorkerId";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "resWorker";
            this.dataGridViewTextBoxColumn23.HeaderText = "resWorker";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            this.bsOrder.DataMember = "vJ_Order";
            this.bsOrder.DataSource = this.dataSetOrder;
            this.dataSetOrder.DataSetName = "DataSetOrder";
            this.dataSetOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.panel1.Controls.Add(this.buttonCloseSelRes);
            this.panel1.Controls.Add(this.buttonCloseAllRes);
            this.panel1.Controls.Add(this.dateTimePickerRes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbOrderRes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(3, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(769, 44);
            this.panel1.TabIndex = 3;
            this.buttonCloseSelRes.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.buttonCloseSelRes.Location = new Point(622, 16);
            this.buttonCloseSelRes.Name = "buttonCloseSelRes";
            this.buttonCloseSelRes.Size = new Size(142, 23);
            this.buttonCloseSelRes.TabIndex = 5;
            this.buttonCloseSelRes.Text = "Закрыть выделенные";
            this.buttonCloseSelRes.UseVisualStyleBackColor = true;
            this.buttonCloseSelRes.Click += new System.EventHandler(this.buttonCloseSelRes_Click);
            this.buttonCloseAllRes.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.buttonCloseAllRes.Location = new Point(519, 16);
            this.buttonCloseAllRes.Name = "buttonCloseAllRes";
            this.buttonCloseAllRes.Size = new Size(97, 23);
            this.buttonCloseAllRes.TabIndex = 4;
            this.buttonCloseAllRes.Text = "Закрыть все";
            this.buttonCloseAllRes.UseVisualStyleBackColor = true;
            this.buttonCloseAllRes.Click += new System.EventHandler(this.buttonCloseAllRes_Click);
            this.dateTimePickerRes.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerRes.Enabled = false;
            this.dateTimePickerRes.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerRes.Location = new Point(180, 19);
            this.dateTimePickerRes.Name = "dateTimePickerRes";
            this.dateTimePickerRes.Size = new Size(133, 20);
            this.dateTimePickerRes.TabIndex = 3;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(177, 3);
            this.label3.Name = "label3";
            this.label3.Size = new Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата";
            this.cmbOrderRes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbOrderRes.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbOrderRes.DataSource = this.dataSetOrder;
            this.cmbOrderRes.DisplayMember = "vWorkerGroup.FIO";
            this.cmbOrderRes.FormattingEnabled = true;
            this.cmbOrderRes.Location = new Point(8, 18);
            this.cmbOrderRes.Name = "cmbOrderRes";
            this.cmbOrderRes.Size = new Size(163, 21);
            this.cmbOrderRes.TabIndex = 1;
            this.cmbOrderRes.ValueMember = "vR_Worker.id";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Диспетчер";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(783, 375);
            base.Controls.Add(this.tabControl);
            //base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.Name = "FormJournalOrderClose";
            this.Text = "Закрытие нарядов";
            base.Load += new System.EventHandler(this.FormJournalOrderClose_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageRegistered.ResumeLayout(false);
            ((ISupportInitialize)this.dgvOrderRegistered).EndInit();
            ((ISupportInitialize)this.bsOrderRegistered).EndInit();
            ((ISupportInitialize)this.dsOrderRegistered).EndInit();
            this.panelRegistered.ResumeLayout(false);
            this.panelRegistered.PerformLayout();
            this.tabPageRes.ResumeLayout(false);
            ((ISupportInitialize)this.dgvOrder).EndInit();
            ((ISupportInitialize)this.bsOrder).EndInit();
            ((ISupportInitialize)this.dataSetOrder).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
        }


        private TabControl tabControl;
        private TabPage tabPageRegistered;
        private TabPage tabPageRes;
        private DataSet.DataSetOrder dsOrderRegistered;
        private BindingSource bsOrderRegistered;
        private DataGridViewExcelFilter dgvOrderRegistered;
        private Panel panelRegistered;
        private Button buttonCloseSelReg;
        private Button buttonCloseAllReg;
        private DateTimePicker dateTimePickerCloseReg;
        private Label label2;
        private ComboBox cmbCloseWorkerRegistered;
        private Label label1;
        private DataGridViewFilterTextBoxColumn numDgvColumn;
        private DataGridViewTextBoxColumn dateOutputDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outputMakerDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn srNumDataGridViewTextBoxColumn;
        private DataGridViewFilterDateTimePickerColumn dateBeginDataGridViewTextBoxColumn;
        private DataGridViewFilterDateTimePickerColumn dateEndDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn instructionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn srNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headworkerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headFioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acceptworkerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acceptFIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDgvColumnReg;
        private DataGridViewTextBoxColumn watchWorkerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn watchFIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn makerWorkerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn makerFIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn otherInstructionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outputWorkerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outputFIODataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn registeredDgvColumn;
        private DataGridViewTextBoxColumn dateCloseDgvColumn;
        private DataGridViewTextBoxColumn closeWorkerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn closeFIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beginResDgvColumn;
        private DataGridViewTextBoxColumn EndResDgvColumn;
        private DataGridViewTextBoxColumn resWorkerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resWorkerDataGridViewTextBoxColumn;
        private DataSet.DataSetOrder dataSetOrder;
        private BindingSource bsOrder;
        private DataGridViewExcelFilter dgvOrder;
        private Panel panel1;
        private Button buttonCloseSelRes;
        private Button buttonCloseAllRes;
        private DateTimePicker dateTimePickerRes;
        private Label label3;
        private ComboBox cmbOrderRes;
        private Label label4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn2;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn1;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn idDgvColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewCheckBoxColumn registeredDgvColumnRes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn beginResDgvColumnRes;
        private DataGridViewTextBoxColumn endResDgvColumnRes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    }
}