using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using Passport.Classes;

namespace Passport.Forms
{
	public class FormPassportCountSwitch : FormBase
	{
		public FormPassportCountSwitch(SQLSettings settings)
		{
			this.method_5();
			this.SqlSettings = settings;
		}

		private void method_0()
		{
			this.bindingSource_0 = PassportData.GetCountEquipmentData(this.SqlSettings);
			this.method_1((DataTable)this.bindingSource_0.DataSource);
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.method_3();
			this.method_2();
		}

		private void method_1(DataTable dataTable_0)
		{
			int num = 0;
			this.dataGridViewExcelFilter_0.DataSource = null;
			this.dataGridViewExcelFilter_0.Columns.Clear();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			dataGridViewCellStyle.Padding = new Padding(1, 5, 5, 0);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.RowHeadersWidth = this.dataGridViewExcelFilter_0.RowHeadersWidth;
			if (dataTable_0.Rows.Count == 0)
			{
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
				dataGridViewTextBoxColumn.HeaderText = "Нет данных";
				dataGridViewTextBoxColumn.Name = "dataGridViewTextBoxColumn1";
				dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dataGridViewTextBoxColumn.ReadOnly = true;
				dataGridViewTextBoxColumn.Visible = true;
				this.dataGridViewExcelFilter_0.Columns.Add(dataGridViewTextBoxColumn);
				this.dataGridView_0.Columns.Add((DataGridViewFilterTextBoxColumn)dataGridViewTextBoxColumn.Clone());
				return;
			}
			foreach (object obj in dataTable_0.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn = new DataGridViewFilterTextBoxColumn();
				dataGridViewFilterTextBoxColumn.DataPropertyName = dataColumn.ColumnName;
				dataGridViewFilterTextBoxColumn.HeaderText = dataColumn.Caption;
				dataGridViewFilterTextBoxColumn.Name = dataColumn.ColumnName;
				dataGridViewFilterTextBoxColumn.ReadOnly = true;
				dataGridViewFilterTextBoxColumn.DefaultCellStyle = new DataGridViewCellStyle
				{
					Alignment = DataGridViewContentAlignment.MiddleRight
				};
				dataGridViewFilterTextBoxColumn.Width = 115;
				dataGridViewFilterTextBoxColumn.Tag = ((num < 2) ? 0 : 1);
				this.dataGridViewExcelFilter_0.Columns.Add(dataGridViewFilterTextBoxColumn);
				this.dataGridView_0.Columns.Add((DataGridViewFilterTextBoxColumn)dataGridViewFilterTextBoxColumn.Clone());
				num++;
			}
		}

		private void method_2()
		{
			this.dataGridView_0.RowHeadersWidth = this.dataGridViewExcelFilter_0.RowHeadersWidth;
			this.dataGridView_0.BorderStyle = BorderStyle.None;
			this.dataGridView_0.Rows[0].HeaderCell.Value = "Итого: ";
			this.dataGridView_0.RowHeadersWidth += TextRenderer.MeasureText("Итого: ", this.dataGridView_0.RowHeadersDefaultCellStyle.Font).Width;
			if (this.dataGridView_0.Columns[0].Width + this.dataGridView_0.RowHeadersWidth != this.dataGridViewExcelFilter_0.RowHeadersWidth + this.dataGridViewExcelFilter_0.Columns[0].Width)
			{
				this.dataGridView_0.Columns[0].Width = this.dataGridViewExcelFilter_0.RowHeadersWidth + this.dataGridViewExcelFilter_0.Columns[0].Width - this.dataGridView_0.RowHeadersWidth;
			}
		}

		private void FormPassportCountSwitch_Load(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void method_3()
		{
			if (this.dataGridViewExcelFilter_0.RowCount > 0)
			{
				if (this.dataGridView_0.Rows.Count == 0)
				{
					this.dataGridView_0.Rows.Add();
				}
				foreach (object obj in this.dataGridViewExcelFilter_0.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					if ((int)dataGridViewColumn.Tag == 1)
					{
						int num = 0;
						foreach (object obj2 in ((IEnumerable)this.dataGridViewExcelFilter_0.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
							if ((int)dataGridViewColumn.Tag == 1)
							{
								int num2 = 0;
								if (int.TryParse(dataGridViewRow.Cells[dataGridViewColumn.Index].Value.ToString(), out num2))
								{
									num += num2;
								}
							}
						}
						this.dataGridView_0.Rows[0].Cells[dataGridViewColumn.Index].Value = num;
					}
				}
			}
		}

		private void dataGridViewExcelFilter_0_Scroll(object sender, ScrollEventArgs e)
		{
			this.dataGridView_0.HorizontalScrollingOffset = this.dataGridViewExcelFilter_0.HorizontalScrollingOffset;
		}

		private void dataGridViewExcelFilter_0_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			if (e.Column.Index == 1)
			{
				this.method_2();
				return;
			}
			this.dataGridView_0.Columns[e.Column.Index].Width = e.Column.Width;
		}

		private void dataGridViewExcelFilter_0_RowHeadersWidthChanged(object sender, EventArgs e)
		{
			this.method_2();
		}

		private void method_4(object sender, EventArgs e)
		{
			this.method_3();
		}

		private void dataGridViewExcelFilter_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.method_3();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_5()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.button_0 = new Button();
			this.dataGridView_0 = new DataGridView();
			this.tableLayoutPanel_0.SuspendLayout();
			this.dataGridViewExcelFilter_0.BeginInit();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17f));
			this.tableLayoutPanel_0.Controls.Add(this.dataGridViewExcelFilter_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 0, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpGeneral";
			this.tableLayoutPanel_0.RowCount = 3;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 37f));
			this.tableLayoutPanel_0.Size = new Size(784, 562);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridViewExcelFilter_0, 2);
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.White;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = Color.White;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(3, 3);
			this.dataGridViewExcelFilter_0.MultiSelect = false;
			this.dataGridViewExcelFilter_0.Name = "dgvGeneral";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(778, 491);
			this.dataGridViewExcelFilter_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.RowHeadersWidthChanged += this.dataGridViewExcelFilter_0_RowHeadersWidthChanged;
			this.dataGridViewExcelFilter_0.ColumnWidthChanged += this.dataGridViewExcelFilter_0_ColumnWidthChanged;
			this.dataGridViewExcelFilter_0.RowsAdded += this.dataGridViewExcelFilter_0_RowsAdded;
			this.dataGridViewExcelFilter_0.Scroll += this.dataGridViewExcelFilter_0_Scroll;
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(670, 532);
			this.button_0.Margin = new Padding(3, 7, 15, 7);
			this.button_0.Name = "button1";
			this.button_0.Size = new Size(82, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeColumns = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.BackgroundColor = SystemColors.Control;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.ColumnHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 500);
			this.dataGridView_0.Name = "dgvTotal";
			this.dataGridView_0.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_0.RowHeadersWidth = 20;
			this.dataGridView_0.ScrollBars = ScrollBars.None;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(761, 22);
			this.dataGridView_0.TabIndex = 2;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(784, 562);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormPassportCountSwitch";
			this.Text = "Количество выключателей в подстанциях";
			base.Load += this.FormPassportCountSwitch_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.dataGridViewExcelFilter_0.EndInit();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			base.ResumeLayout(false);
		}

		private BindingSource bindingSource_0 = new BindingSource();

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private Button button_0;

		private DataGridView dataGridView_0;
	}
}
