using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;

namespace Passport.Forms.Cable
{
	public class FormLoadOldCablePassport : FormBase
	{
		public int IdObjList { get; set; }

		public FormLoadOldCablePassport()
		{
			this.method_1();
		}

		public FormLoadOldCablePassport(SQLSettings settings, int idObjList)
		{
			this.method_1();
			this.SqlSettings = settings;
			this.IdObjList = idObjList;
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void method_0()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			string text = "SELECT [Код] idOldPassport, [Имя] Name, [ТП/РП] Type1, [ТП1] SS1 , [Яч] Cell1, [ТП/РП/П] Type2, [ТП2] SS2, [PrimVL], [Ячейка] Cell2 FROM [ULGES-SQL].[Kab].[dbo].[Паспорт Кабеля] WHERE [Имя] LIKE '%" + this.textBox_0.Text + "%' ORDER BY [Имя]";
			DataTable dataSource = sqlDataCommand.SelectSqlData(text);
			this.dataGridView_0.DataSource = dataSource;
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.RowCount > 0)
			{
				int int_ = (int)this.dataGridView_0.SelectedRows[0].Cells["idOldPassport"].Value;
				new Class3().method_2(this.SqlSettings, this.IdObjList, int_);
			}
			base.Close();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void textBox_0_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				this.method_0();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_1()
		{
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.textBox_0 = new TextBox();
			this.button_2 = new Button();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 3;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 478f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123f));
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 2);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.button_2, 2, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 3;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 43f));
			this.tableLayoutPanel_0.Size = new Size(730, 384);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.BackgroundColor = Color.White;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8
			});
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_0, 3);
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 39);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvOldCablePassport";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(724, 299);
			this.dataGridView_0.TabIndex = 0;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "idOldPassport";
			this.dataGridViewTextBoxColumn_0.HeaderText = "idOldPassport";
			this.dataGridViewTextBoxColumn_0.Name = "idOldPassport";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_1.Name = "NameCable";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Width = 200;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Type1";
			this.dataGridViewTextBoxColumn_2.HeaderText = "ТП/РП";
			this.dataGridViewTextBoxColumn_2.Name = "Type1";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Width = 60;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "SS1";
			this.dataGridViewTextBoxColumn_3.HeaderText = "ТП1";
			this.dataGridViewTextBoxColumn_3.Name = "SS1";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "Cell1";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_4.Name = "Cell1";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Width = 50;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Type2";
			this.dataGridViewTextBoxColumn_5.HeaderText = "ТП/РП/П";
			this.dataGridViewTextBoxColumn_5.Name = "Type2";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Width = 60;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "SS2";
			this.dataGridViewTextBoxColumn_6.HeaderText = "ТП2";
			this.dataGridViewTextBoxColumn_6.Name = "SS2";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "PrimVL";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Прим. ВЛ";
			this.dataGridViewTextBoxColumn_7.Name = "PrimVL";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "Cell2";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_8.Name = "Cell2";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Width = 50;
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(497, 351);
			this.button_0.Margin = new Padding(3, 10, 10, 10);
			this.button_0.Name = "btnAccept";
			this.button_0.Size = new Size(100, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Dock = DockStyle.Left;
			this.button_1.Location = new Point(617, 351);
			this.button_1.Margin = new Padding(10, 10, 3, 10);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(100, 23);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.tableLayoutPanel_0.SetColumnSpan(this.textBox_0, 2);
			this.textBox_0.Dock = DockStyle.Fill;
			this.textBox_0.Location = new Point(10, 10);
			this.textBox_0.Margin = new Padding(10, 10, 10, 3);
			this.textBox_0.Name = "tbOldCableName";
			this.textBox_0.Size = new Size(587, 20);
			this.textBox_0.TabIndex = 3;
			this.textBox_0.KeyPress += this.textBox_0_KeyPress;
			this.button_2.Location = new Point(617, 8);
			this.button_2.Margin = new Padding(10, 8, 10, 3);
			this.button_2.Name = "btnFind";
			this.button_2.Size = new Size(100, 23);
			this.button_2.TabIndex = 4;
			this.button_2.Text = "Найти";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "idOldPassport";
			this.dataGridViewTextBoxColumn_9.HeaderText = "idOldPassport";
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_10.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_10.Width = 200;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "Type1";
			this.dataGridViewTextBoxColumn_11.HeaderText = "ТП/РП";
			this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_11.Width = 60;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "SS1";
			this.dataGridViewTextBoxColumn_12.HeaderText = "ТП1";
			this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "Cell1";
			this.dataGridViewTextBoxColumn_13.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_13.Width = 50;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "Type2";
			this.dataGridViewTextBoxColumn_14.HeaderText = "ТП/РП/П";
			this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_14.Width = 60;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "SS2";
			this.dataGridViewTextBoxColumn_15.HeaderText = "ТП2";
			this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "PrimVL";
			this.dataGridViewTextBoxColumn_16.HeaderText = "Прим. ВЛ";
			this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "Cell2";
			this.dataGridViewTextBoxColumn_17.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_17.Width = 50;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(730, 384);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormLoadOldCablePassport";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Загрузка паспорта кабеля из старой БД";
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			base.ResumeLayout(false);
		}

		[CompilerGenerated]
		private int int_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private DataGridView dataGridView_0;

		private Button button_0;

		private Button button_1;

		private TextBox textBox_0;

		private Button button_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
	}
}
