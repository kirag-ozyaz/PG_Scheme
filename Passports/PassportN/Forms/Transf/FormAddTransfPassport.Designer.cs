using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Passport.Controls;

namespace Passport.Forms.Transf
{
	public class FormAddTransfPassport : FormBase
	{
		public int Id { get; set; }

		[DefaultValue(false)]
		public bool WithPassport { get; set; }

		public FormAddTransfPassport()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
			this.method_0(this.WithPassport);
		}

		public FormAddTransfPassport(SQLSettings settings, bool withPassport)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
			this.SqlSettings = settings;
			this.WithPassport = withPassport;
			this.method_0(withPassport);
		}

		private void method_0(bool bool_1)
		{
			float value = (float)this.tableLayoutPanel_0.Height - (this.tableLayoutPanel_0.RowStyles[0].Height + this.tableLayoutPanel_0.RowStyles[1].Height + this.tableLayoutPanel_0.RowStyles[2].Height + this.tableLayoutPanel_0.RowStyles[3].Height + this.tableLayoutPanel_0.RowStyles[4].Height) + 4f;
			this.tableLayoutPanel_0.RowStyles[5] = (bool_1 ? new RowStyle(SizeType.Percent, 100f) : new RowStyle(SizeType.Absolute, 0f));
			base.Height = (bool_1 ? base.Height : (base.Height - Convert.ToInt32(value)));
		}

		private DataTable method_1()
		{
			string text = "WHERE ParentKey = ';Passport;ObjLocation;' OR ParentKey = ';NetworkAreas;'AND Deleted = ((0)) AND IsGroup = ((0)) AND Name NOT LIKE 'Реестр'";
			return new SqlDataCommand(this.SqlSettings).SelectSqlData(this.class107_0.tR_Classifier.TableName, true, text, null);
		}

		private void FormAddTransfPassport_Load(object sender, EventArgs e)
		{
			Class107.Class244 @class = this.class107_0.tSchm_ObjList.method_5();
			@class.TypeCodeId = 556;
			@class.Deleted = false;
			this.class107_0.tSchm_ObjList.method_0(@class);
			this.comboBox_0.DataSource = this.method_1();
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "Id";
			this.dataGridViewPassport_0.AddRowAddingParemeter(556, this.SqlSettings);
		}

		private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (int.TryParse(this.comboBox_0.SelectedValue.ToString(), out num))
			{
				bool flag = ((DataRowView)this.comboBox_0.SelectedItem)[1].ToString().IndexOf("Сетевой район") > -1;
				this.comboBox_1.Enabled = flag;
				this.numericUpDown_0.Enabled = flag;
				if (flag)
				{
					this.class107_0.tSchm_ObjList.Rows[0]["Location"] = DBNull.Value;
					this.comboBox_1.DataSource = Class320.smethod_3(this.SqlSettings, num);
					this.comboBox_1.DisplayMember = "FullName";
					this.comboBox_1.ValueMember = "Id";
					return;
				}
				this.comboBox_1.SelectedValue = -1;
				this.class107_0.tSchm_ObjList.Rows[0]["Location"] = num;
				this.class107_0.tSchm_ObjList.Rows[0]["Deleted"] = (num == 909);
				this.class107_0.tSchm_ObjList.Rows[0]["idParent"] = DBNull.Value;
				this.class107_0.tSchm_ObjList.Rows[0]["idParentAddl"] = DBNull.Value;
			}
		}

		private void FormAddTransfPassport_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.comboBox_0.SelectedValue == null || (int)this.comboBox_0.SelectedValue <= 0)
				{
					MessageBox.Show("Направление трансформатора не выбрано!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					this.comboBox_0.Focus();
					e.Cancel = true;
					return;
				}
				this.class107_0.tSchm_ObjList.Rows[0]["Name"] = "Т" + this.numericUpDown_0.Value.ToString();
				this.class107_0.tSchm_ObjList.Rows[0].EndEdit();
				this.Id = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tSchm_ObjList);
				if (this.Id <= 0)
				{
					MessageBox.Show("Ошибка при добавлении трансформатора!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					return;
				}
				if (this.WithPassport)
				{
					this.dataGridViewPassport_0.SaveInsertedData(this.Id, this.dateTimePicker_0.Value, 0);
					return;
				}
			}
		}

		private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
		{
			int num = -1;
			if (this.comboBox_1.SelectedValue != null && int.TryParse(this.comboBox_1.SelectedValue.ToString(), out num))
			{
				if (num != -1)
				{
					this.class107_0.tSchm_ObjList.Rows[0]["idParent"] = num;
					this.class107_0.tSchm_ObjList.Rows[0]["idParentAddl"] = num;
					return;
				}
				this.class107_0.tSchm_ObjList.Rows[0]["idParent"] = DBNull.Value;
				this.class107_0.tSchm_ObjList.Rows[0]["idParentAddl"] = DBNull.Value;
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

		private void method_2()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.label_3 = new Label();
			this.label_2 = new Label();
			this.button_0 = new Button();
			this.label_0 = new Label();
			this.comboBox_0 = new ComboBox();
			this.class107_0 = new Class107();
			this.label_1 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.numericUpDown_0 = new NumericUpDown();
			this.comboBox_1 = new ComboBox();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dataGridViewPassport_0 = new DataGridViewPassport();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.class107_0).BeginInit();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dataGridViewPassport_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231f));
			this.tableLayoutPanel_0.Controls.Add(this.label_3, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.label_2, 0, 3);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 6);
			this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_0, 1, 1);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridViewPassport_0, 0, 5);
			this.tableLayoutPanel_0.Controls.Add(this.label_1, 0, 4);
			this.tableLayoutPanel_0.Controls.Add(this.dateTimePicker_0, 1, 4);
			this.tableLayoutPanel_0.Controls.Add(this.numericUpDown_0, 1, 3);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 1, 2);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpGeneral";
			this.tableLayoutPanel_0.RowCount = 7;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 6f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 37f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Size = new Size(384, 565);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.label_3.AutoSize = true;
			this.label_3.Dock = DockStyle.Fill;
			this.label_3.Location = new Point(3, 31);
			this.label_3.Name = "label1";
			this.label_3.Size = new Size(147, 25);
			this.label_3.TabIndex = 25;
			this.label_3.Text = "Подстанция";
			this.label_3.TextAlign = ContentAlignment.MiddleRight;
			this.label_2.AutoSize = true;
			this.label_2.Dock = DockStyle.Right;
			this.label_2.Location = new Point(109, 56);
			this.label_2.Name = "label4";
			this.label_2.Size = new Size(41, 25);
			this.label_2.TabIndex = 20;
			this.label_2.Text = "Номер";
			this.label_2.TextAlign = ContentAlignment.MiddleRight;
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(286, 535);
			this.button_0.Margin = new Padding(3, 7, 7, 7);
			this.button_0.Name = "btnAccept";
			this.button_0.Size = new Size(91, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Right;
			this.label_0.Location = new Point(75, 6);
			this.label_0.Margin = new Padding(3, 0, 3, 6);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(75, 19);
			this.label_0.TabIndex = 3;
			this.label_0.Text = "Направление";
			this.label_0.TextAlign = ContentAlignment.BottomRight;
			this.comboBox_0.Dock = DockStyle.Bottom;
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(156, 9);
			this.comboBox_0.Name = "cbDirection";
			this.comboBox_0.Size = new Size(225, 21);
			this.comboBox_0.TabIndex = 4;
			this.comboBox_0.SelectedValueChanged += this.comboBox_0_SelectedValueChanged;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Fill;
			this.label_1.Location = new Point(3, 88);
			this.label_1.Margin = new Padding(3, 7, 3, 0);
			this.label_1.Name = "label3";
			this.label_1.Size = new Size(147, 18);
			this.label_1.TabIndex = 7;
			this.label_1.Text = "Дата паспорта";
			this.label_1.TextAlign = ContentAlignment.TopRight;
			this.dateTimePicker_0.Dock = DockStyle.Top;
			this.dateTimePicker_0.Location = new Point(156, 84);
			this.dateTimePicker_0.Name = "dtpDatePassport";
			this.dateTimePicker_0.Size = new Size(225, 20);
			this.dateTimePicker_0.TabIndex = 8;
			this.numericUpDown_0.Dock = DockStyle.Fill;
			this.numericUpDown_0.Location = new Point(156, 59);
			this.numericUpDown_0.Name = "nudTransfNumber";
			this.numericUpDown_0.Size = new Size(225, 20);
			this.numericUpDown_0.TabIndex = 21;
			this.comboBox_1.Dock = DockStyle.Fill;
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(156, 34);
			this.comboBox_1.Name = "cbSubstation";
			this.comboBox_1.Size = new Size(225, 21);
			this.comboBox_1.TabIndex = 22;
			this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
			this.dataGridViewCheckBoxColumn_0.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_0.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.bindingSource_0.DataSource = this.class107_0;
			this.bindingSource_0.Position = 0;
			this.dataGridViewPassport_0.AllowUserToAddRows = false;
			this.dataGridViewPassport_0.AllowUserToDeleteRows = false;
			this.dataGridViewPassport_0.AllowUserToResizeRows = false;
			this.dataGridViewPassport_0.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewPassport_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewPassport_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridViewPassport_0, 2);
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.White;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridViewPassport_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewPassport_0.Dock = DockStyle.Fill;
			this.dataGridViewPassport_0.DragDropComplite = false;
			this.dataGridViewPassport_0.EditMode = DataGridViewEditMode.EditOnEnter;
			this.dataGridViewPassport_0.Location = new Point(3, 109);
			this.dataGridViewPassport_0.MultiSelect = false;
			this.dataGridViewPassport_0.Name = "DataGridViewPassport1";
			this.dataGridViewPassport_0.RowHeadersVisible = false;
			this.dataGridViewPassport_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPassport_0.Size = new Size(378, 416);
			this.dataGridViewPassport_0.TabIndex = 6;
			this.dataGridViewTextBoxColumn_0.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_3.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_3.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_3.Width = 5;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(384, 565);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormAddTransf";
			this.Text = "Добавление трансформатора";
			base.FormClosing += this.FormAddTransfPassport_FormClosing;
			base.Load += this.FormAddTransfPassport_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			((ISupportInitialize)this.class107_0).EndInit();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dataGridViewPassport_0).EndInit();
			base.ResumeLayout(false);
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private bool bool_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private Class107 class107_0;

		private Label label_0;

		private ComboBox comboBox_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private Label label_1;

		private DateTimePicker dateTimePicker_0;

		private DataGridViewPassport dataGridViewPassport_0;

		private Label label_2;

		private NumericUpDown numericUpDown_0;

		private BindingSource bindingSource_0;

		private ComboBox comboBox_1;

		private Label label_3;
	}
}
