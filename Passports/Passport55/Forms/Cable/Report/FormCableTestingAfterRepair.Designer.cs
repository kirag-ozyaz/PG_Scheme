using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using Passport.DataSets;

namespace Passport.Forms.Cable.Report
{
	public class FormCableTestingAfterRepair : FormBase
	{
		public FormCableTestingAfterRepair()
		{
			this.method_0();
		}

		public FormCableTestingAfterRepair(SQLSettings settings)
		{
			this.method_0();
			this.SqlSettings = settings;
		}

		private void FormCableTestingAfterRepair_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_PR_CableTestingAfterRepair, true, " ORDER BY RowNum");
			this.bindingSource_0.ResetBindings(false);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsDocuments_0 = new dsDocuments();
			this.button_0 = new Button();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterDateTimePickerColumn_0 = new DataGridViewFilterDateTimePickerColumn();
			this.dataGridViewFilterDateTimePickerColumn_1 = new DataGridViewFilterDateTimePickerColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterDateTimePickerColumn_2 = new DataGridViewFilterDateTimePickerColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterDateTimePickerColumn_3 = new DataGridViewFilterDateTimePickerColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			this.dataGridViewExcelFilter_0.BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120f));
			this.tableLayoutPanel_0.Controls.Add(this.dataGridViewExcelFilter_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpGeneral";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
			this.tableLayoutPanel_0.Size = new Size(1314, 562);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = Color.White;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = Color.White;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeight = 55;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_0,
				this.dataGridViewFilterTextBoxColumn_1,
				this.dataGridViewFilterTextBoxColumn_2,
				this.dataGridViewFilterDateTimePickerColumn_0,
				this.dataGridViewFilterDateTimePickerColumn_1,
				this.dataGridViewFilterTextBoxColumn_3,
				this.dataGridViewFilterDateTimePickerColumn_2,
				this.dataGridViewFilterTextBoxColumn_4,
				this.dataGridViewFilterDateTimePickerColumn_3,
				this.dataGridViewFilterTextBoxColumn_5,
				this.dataGridViewFilterTextBoxColumn_6,
				this.dataGridViewFilterTextBoxColumn_7,
				this.dataGridViewFilterTextBoxColumn_8
			});
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridViewExcelFilter_0, 2);
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(3, 3);
			this.dataGridViewExcelFilter_0.Name = "dgvGeneral";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(1308, 520);
			this.dataGridViewExcelFilter_0.TabIndex = 0;
			this.bindingSource_0.DataMember = "vP_PR_CableTestingAfterRepair";
			this.bindingSource_0.DataSource = this.dsDocuments_0;
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.button_0.Location = new Point(1197, 533);
			this.button_0.Margin = new Padding(3, 7, 3, 3);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(91, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "RowNum";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№";
			this.dataGridViewFilterTextBoxColumn_0.Name = "rowNum";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_0.Width = 50;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "id";
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "id";
			this.dataGridViewFilterTextBoxColumn_1.Name = "id";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_1.Visible = false;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "Name";
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Наименование кабельной линии";
			this.dataGridViewFilterTextBoxColumn_2.Name = "cableName";
			this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_2.Width = 200;
			this.dataGridViewFilterDateTimePickerColumn_0.DataPropertyName = "DateExpl";
			dataGridViewCellStyle2.Format = "d";
			this.dataGridViewFilterDateTimePickerColumn_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewFilterDateTimePickerColumn_0.HeaderText = "Дата ввода в эксплуатацию";
			this.dataGridViewFilterDateTimePickerColumn_0.Name = "DateExpl";
			this.dataGridViewFilterDateTimePickerColumn_0.ReadOnly = true;
			this.dataGridViewFilterDateTimePickerColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterDateTimePickerColumn_1.DataPropertyName = "DateDecommissioning";
			dataGridViewCellStyle3.Format = "d";
			this.dataGridViewFilterDateTimePickerColumn_1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewFilterDateTimePickerColumn_1.HeaderText = "Дата выявления повреждения";
			this.dataGridViewFilterDateTimePickerColumn_1.Name = "dateDecommissioning";
			this.dataGridViewFilterDateTimePickerColumn_1.ReadOnly = true;
			this.dataGridViewFilterDateTimePickerColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "Reason";
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Причина повреждения";
			this.dataGridViewFilterTextBoxColumn_3.Name = "reason";
			this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_3.Width = 150;
			this.dataGridViewFilterDateTimePickerColumn_2.DataPropertyName = "DateCommissioning";
			dataGridViewCellStyle4.Format = "d";
			this.dataGridViewFilterDateTimePickerColumn_2.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewFilterDateTimePickerColumn_2.HeaderText = "Дата включения в эксплуатацию";
			this.dataGridViewFilterDateTimePickerColumn_2.Name = "dateCommissioning";
			this.dataGridViewFilterDateTimePickerColumn_2.ReadOnly = true;
			this.dataGridViewFilterDateTimePickerColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Period";
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Продолжительность эксплуатации";
			this.dataGridViewFilterTextBoxColumn_4.Name = "period";
			this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.Width = 130;
			this.dataGridViewFilterDateTimePickerColumn_3.DataPropertyName = "DateTesting";
			dataGridViewCellStyle5.Format = "d";
			this.dataGridViewFilterDateTimePickerColumn_3.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewFilterDateTimePickerColumn_3.HeaderText = "Дата испытания";
			this.dataGridViewFilterDateTimePickerColumn_3.Name = "dateTesting";
			this.dataGridViewFilterDateTimePickerColumn_3.ReadOnly = true;
			this.dataGridViewFilterDateTimePickerColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "ReasonTesting";
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Причина испытания";
			this.dataGridViewFilterTextBoxColumn_5.Name = "reasonTesting";
			this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.Width = 150;
			this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "Voltage";
			this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Испытательное напряжение, кВ";
			this.dataGridViewFilterTextBoxColumn_6.Name = "voltage";
			this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_6.Width = 120;
			this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "Duration";
			this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Продолжительность испытания, мин.";
			this.dataGridViewFilterTextBoxColumn_7.Name = "duration";
			this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_7.Width = 130;
			this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "Conclusion";
			this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Заключение";
			this.dataGridViewFilterTextBoxColumn_8.Name = "conclusion";
			this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1314, 562);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormCableTestingAfterRepair";
			this.Text = "Контроль ввода в эксплуатацию кабельных линий";
			base.Load += this.FormCableTestingAfterRepair_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.dataGridViewExcelFilter_0.EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			base.ResumeLayout(false);
		}

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private Button button_0;

		private dsDocuments dsDocuments_0;

		private BindingSource bindingSource_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_0;

		private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_2;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_3;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
	}
}
