using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Passport.Classes;
using SchemeCtrl2.Canvas.Forms;
using SchemeCtrl2.DrawTool;

internal class Form5 : FormBase
{
	internal Form5()
	{
		Class90.TDroV38zslI2T();
		base..ctor();
		this.method_1();
	}

	internal Form5(LineTool lineTool_0)
	{
		Class90.TDroV38zslI2T();
		base..ctor();
		this.method_1();
		this.textBox_0.Text = lineTool_0.IdBase.ToString();
		this.textBox_1.Text = lineTool_0.ToString();
	}

	private void Form5_Load(object sender, EventArgs e)
	{
		this.tabControl_0.TabPages.Remove(this.tabPage_0);
		this.method_0();
	}

	private void Form5_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				if (this.dataGridViewExcelFilter_0.CurrentRow == null)
				{
					MessageBox.Show("Не выбран паспорт для привязки");
					e.Cancel = true;
					return;
				}
				int idObjList = Convert.ToInt32(this.textBox_0.Text);
				int cod = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
				Cable.InsertPassportCable(this.SqlSettings, cod, idObjList);
			}
			if (this.tabControl_0.SelectedTab == this.tabPage_1)
			{
				if (this.dataGridView_0.SelectedRows == null || this.dataGridView_0.SelectedRows.Count == 0)
				{
					MessageBox.Show("Не выбран паспорт для привязки");
					e.Cancel = true;
					return;
				}
				int num = Convert.ToInt32(this.textBox_0.Text);
				int num2 = (int)this.dataGridView_0.SelectedRows[0].Cells["idUnbind"].Value;
				SchmObj.BindPassport(this.SqlSettings, num, num2);
			}
		}
	}

	private void method_0()
	{
		if (this.tabControl_0.SelectedTab == this.tabPage_1)
		{
			this.dataGridView_0.DataSource = PassportData.GetJournalData(this.SqlSettings, new int[]
			{
				546
			}, true, false);
		}
	}

	private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.method_0();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form5.wNGsAQphxBp5jQvpGEqQ(this, bool_0);
	}

	private void method_1()
	{
		this.icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		this.label_0 = new Label();
		this.textBox_0 = new TextBox();
		this.textBox_1 = new TextBox();
		this.label_1 = new Label();
		this.label_2 = new Label();
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.dataSet_0 = new DataSet();
		this.dataTable_0 = new DataTable();
		this.dataColumn_0 = new DataColumn();
		this.dataColumn_1 = new DataColumn();
		this.dataColumn_2 = new DataColumn();
		this.dataColumn_3 = new DataColumn();
		this.dataColumn_4 = new DataColumn();
		this.dataColumn_5 = new DataColumn();
		this.dataColumn_6 = new DataColumn();
		this.dataColumn_7 = new DataColumn();
		this.dataColumn_8 = new DataColumn();
		this.dataColumn_9 = new DataColumn();
		this.dataColumn_10 = new DataColumn();
		this.dataColumn_11 = new DataColumn();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.tabPage_1 = new TabPage();
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.vflvioHoDE = new DataGridViewTextBoxColumn();
		this.dataGridViewExcelFilter_0.BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.dataSet_0).BeginInit();
		((ISupportInitialize)this.dataTable_0).BeginInit();
		this.tabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		this.tabPage_1.SuspendLayout();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		base.SuspendLayout();
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(16, 11);
		this.label_0.Margin = new Padding(4, 0, 4, 0);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(63, 17);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Id линии";
		this.textBox_0.BackColor = SystemColors.Window;
		this.textBox_0.Location = new Point(103, 7);
		this.textBox_0.Margin = new Padding(4, 4, 4, 4);
		this.textBox_0.Name = "txtLineId";
		this.textBox_0.ReadOnly = true;
		this.textBox_0.Size = new Size(221, 22);
		this.textBox_0.TabIndex = 1;
		this.textBox_1.BackColor = SystemColors.Window;
		this.textBox_1.Location = new Point(103, 43);
		this.textBox_1.Margin = new Padding(4, 4, 4, 4);
		this.textBox_1.Name = "txtLineName";
		this.textBox_1.ReadOnly = true;
		this.textBox_1.Size = new Size(221, 22);
		this.textBox_1.TabIndex = 2;
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(16, 47);
		this.label_1.Margin = new Padding(4, 0, 4, 0);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(79, 17);
		this.label_1.TabIndex = 3;
		this.label_1.Text = "Имя линии";
		this.label_2.AutoSize = true;
		this.label_2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.label_2.Location = new Point(16, 84);
		this.label_2.Margin = new Padding(4, 0, 4, 0);
		this.label_2.Name = "label3";
		this.label_2.Size = new Size(80, 17);
		this.label_2.TabIndex = 4;
		this.label_2.Text = "Паспорта";
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
		this.dataGridViewExcelFilter_0.AllowUserToVisibleColumns = false;
		dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
		this.dataGridViewExcelFilter_0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_0,
			this.dataGridViewFilterTextBoxColumn_0,
			this.dataGridViewFilterTextBoxColumn_1,
			this.dataGridViewFilterTextBoxColumn_2,
			this.dataGridViewFilterTextBoxColumn_3,
			this.dataGridViewFilterTextBoxColumn_4,
			this.dataGridViewTextBoxColumn_1,
			this.dataGridViewTextBoxColumn_2,
			this.dataGridViewTextBoxColumn_3,
			this.dataGridViewTextBoxColumn_4,
			this.dataGridViewTextBoxColumn_5,
			this.dataGridViewTextBoxColumn_6
		});
		this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
		this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_0.Location = new Point(4, 4);
		this.dataGridViewExcelFilter_0.Margin = new Padding(4, 4, 4, 4);
		this.dataGridViewExcelFilter_0.Name = "dgv";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
		this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_0.Size = new Size(996, 193);
		this.dataGridViewExcelFilter_0.TabIndex = 5;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "Код";
		this.dataGridViewTextBoxColumn_0.HeaderText = "Код";
		this.dataGridViewTextBoxColumn_0.Name = "codeDgvTxtColumn";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "Имя";
		this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Имя";
		this.dataGridViewFilterTextBoxColumn_0.Name = "имяDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "ТП1";
		this.dataGridViewFilterTextBoxColumn_1.HeaderText = "ТП1";
		this.dataGridViewFilterTextBoxColumn_1.Name = "тП1DataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "Яч";
		this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Яч";
		this.dataGridViewFilterTextBoxColumn_2.Name = "ячDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "ТП2";
		this.dataGridViewFilterTextBoxColumn_3.HeaderText = "ТП2";
		this.dataGridViewFilterTextBoxColumn_3.Name = "тП2DataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Ячейка";
		this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Ячейка";
		this.dataGridViewFilterTextBoxColumn_4.Name = "ячейкаDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "U";
		this.dataGridViewTextBoxColumn_1.HeaderText = "U";
		this.dataGridViewTextBoxColumn_1.Name = "uDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.DataPropertyName = "Количество";
		this.dataGridViewTextBoxColumn_2.HeaderText = "Количество";
		this.dataGridViewTextBoxColumn_2.Name = "количествоDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.DataPropertyName = "Длина";
		this.dataGridViewTextBoxColumn_3.HeaderText = "Длина";
		this.dataGridViewTextBoxColumn_3.Name = "длинаDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "Год прокладки";
		this.dataGridViewTextBoxColumn_4.HeaderText = "Год прокладки";
		this.dataGridViewTextBoxColumn_4.Name = "годПрокладкиDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "Год ввода в экспл.";
		this.dataGridViewTextBoxColumn_5.HeaderText = "Год ввода в экспл.";
		this.dataGridViewTextBoxColumn_5.Name = "годВводаВЭксплDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "Принадлежность";
		this.dataGridViewTextBoxColumn_6.HeaderText = "Принадлежность";
		this.dataGridViewTextBoxColumn_6.Name = "принадлежностьDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.bindingSource_0.DataMember = "vP_UnrecordedPassportCable";
		this.bindingSource_0.DataSource = this.dataSet_0;
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new DataTable[]
		{
			this.dataTable_0
		});
		this.dataTable_0.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2,
			this.dataColumn_3,
			this.dataColumn_4,
			this.dataColumn_5,
			this.dataColumn_6,
			this.dataColumn_7,
			this.dataColumn_8,
			this.dataColumn_9,
			this.dataColumn_10,
			this.dataColumn_11
		});
		this.dataTable_0.TableName = "vP_UnrecordedPassportCable";
		this.dataColumn_0.ColumnName = "Код";
		this.dataColumn_0.DataType = typeof(int);
		this.dataColumn_1.ColumnName = "Имя";
		this.dataColumn_2.ColumnName = "ТП1";
		this.dataColumn_3.ColumnName = "Яч";
		this.dataColumn_3.DataType = typeof(int);
		this.dataColumn_4.ColumnName = "ТП2";
		this.dataColumn_5.ColumnName = "Ячейка";
		this.dataColumn_5.DataType = typeof(int);
		this.dataColumn_6.ColumnName = "U";
		this.dataColumn_6.DataType = typeof(double);
		this.dataColumn_7.ColumnName = "Количество";
		this.dataColumn_8.ColumnName = "Длина";
		this.dataColumn_8.DataType = typeof(double);
		this.dataColumn_9.ColumnName = "Год прокладки";
		this.dataColumn_9.DataType = typeof(short);
		this.dataColumn_10.ColumnName = "Год ввода в экспл.";
		this.dataColumn_10.DataType = typeof(short);
		this.dataColumn_11.ColumnName = "Принадлежность";
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_0.DialogResult = DialogResult.OK;
		this.button_0.Location = new Point(20, 341);
		this.button_0.Margin = new Padding(4, 4, 4, 4);
		this.button_0.Name = "buttonApply";
		this.button_0.Size = new Size(100, 28);
		this.button_0.TabIndex = 6;
		this.button_0.Text = "Привязать";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.Cancel;
		this.button_1.Location = new Point(896, 341);
		this.button_1.Margin = new Padding(4, 4, 4, 4);
		this.button_1.Name = "buttonCancel";
		this.button_1.Size = new Size(100, 28);
		this.button_1.TabIndex = 7;
		this.button_1.Text = "Отмена";
		this.button_1.UseVisualStyleBackColor = true;
		this.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Location = new Point(0, 103);
		this.tabControl_0.Margin = new Padding(4, 4, 4, 4);
		this.tabControl_0.Name = "tcGeneral";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(1012, 230);
		this.tabControl_0.TabIndex = 8;
		this.tabControl_0.SelectedIndexChanged += this.tabControl_0_SelectedIndexChanged;
		this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_0);
		this.tabPage_0.Location = new Point(4, 25);
		this.tabPage_0.Margin = new Padding(4, 4, 4, 4);
		this.tabPage_0.Name = "tpOldBase";
		this.tabPage_0.Padding = new Padding(4, 4, 4, 4);
		this.tabPage_0.Size = new Size(1004, 201);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Из старой базы";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.tabPage_1.Controls.Add(this.dataGridView_0);
		this.tabPage_1.Location = new Point(4, 25);
		this.tabPage_1.Margin = new Padding(4, 4, 4, 4);
		this.tabPage_1.Name = "tpNewBase";
		this.tabPage_1.Padding = new Padding(4, 4, 4, 4);
		this.tabPage_1.Size = new Size(1004, 201);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Из новой базы";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.dataGridView_0.AllowUserToAddRows = false;
		this.dataGridView_0.AllowUserToDeleteRows = false;
		this.dataGridView_0.AllowUserToOrderColumns = true;
		this.dataGridView_0.AllowUserToResizeRows = false;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_7,
			this.vflvioHoDE
		});
		this.dataGridView_0.Dock = DockStyle.Fill;
		this.dataGridView_0.Location = new Point(4, 4);
		this.dataGridView_0.Margin = new Padding(4, 4, 4, 4);
		this.dataGridView_0.MultiSelect = false;
		this.dataGridView_0.Name = "dgvGeneral";
		this.dataGridView_0.ReadOnly = true;
		this.dataGridView_0.RowHeadersVisible = false;
		this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_0.Size = new Size(996, 193);
		this.dataGridView_0.TabIndex = 3;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_7.HeaderText = "idUnbind";
		this.dataGridViewTextBoxColumn_7.Name = "idUnbind";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_7.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_7.Visible = false;
		this.vflvioHoDE.DataPropertyName = "idPassport";
		this.vflvioHoDE.HeaderText = "idPassportUnbind";
		this.vflvioHoDE.Name = "idPassportUnbind";
		this.vflvioHoDE.ReadOnly = true;
		this.vflvioHoDE.Resizable = DataGridViewTriState.True;
		this.vflvioHoDE.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.vflvioHoDE.Visible = false;
		base.AcceptButton = this.button_0;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_1;
		base.ClientSize = new Size(1012, 384);
		base.Controls.Add(this.tabControl_0);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.textBox_1);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.label_0);
		base.Margin = new Padding(4, 4, 4, 4);
		base.Name = "FormLinkLineCable";
		this.Text = "Привязать кабельную линию к старому паспорту";
		base.FormClosing += this.Form5_FormClosing;
		base.Load += this.Form5_Load;
		this.dataGridViewExcelFilter_0.EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.dataSet_0).EndInit();
		((ISupportInitialize)this.dataTable_0).EndInit();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.tabPage_1.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal static void wNGsAQphxBp5jQvpGEqQ(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private IContainer icontainer_0;

	private Label label_0;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private Label label_1;

	private Label label_2;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private Button button_0;

	private Button button_1;

	private BindingSource bindingSource_0;

	private DataSet dataSet_0;

	private DataTable dataTable_0;

	private DataColumn dataColumn_0;

	private DataColumn dataColumn_1;

	private DataColumn dataColumn_2;

	private DataColumn dataColumn_3;

	private DataColumn dataColumn_4;

	private DataColumn dataColumn_5;

	private DataColumn dataColumn_6;

	private DataColumn dataColumn_7;

	private DataColumn dataColumn_8;

	private DataColumn dataColumn_9;

	private DataColumn dataColumn_10;

	private DataColumn dataColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private DataGridView dataGridView_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewTextBoxColumn vflvioHoDE;
}
