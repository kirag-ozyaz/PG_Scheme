using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Passport.DataSets;
using Passport.Properties;

namespace Passport.Forms.PassportChars
{
	public class FormReferValueLists : FormBase
	{
		public FormReferValueLists(SQLSettings settings)
		{
			this.method_14();
			this.SqlSettings = settings;
		}

		public int Id { get; set; }

		public int IdParent { get; set; }

		public string GroupKey { get; set; }

		private void method_0()
		{
			base.SelectSqlDataTableOther(this.dsPassport_0, this.dsPassport_0.vP_GetGroupList, "vP_GetValueList", true, "WHERE Deleted = ((0)) AND isGroup = ((1)) AND ParentKey = '" + this.GroupKey + "' ORDER BY Name");
			this.bindingSource_0.ResetBindings(true);
		}

		private void method_1()
		{
			FormAddGroupElementList formAddGroupElementList = new FormAddGroupElementList();
			formAddGroupElementList.SqlSettings = this.SqlSettings;
			formAddGroupElementList.stateFormCreate = 3;
			formAddGroupElementList.TableName = TableNameEnum.tP_ValueLists;
			if (formAddGroupElementList.ShowDialog() == DialogResult.OK)
			{
				this.IdParent = formAddGroupElementList.IdParent;
				this.method_10(this.IdParent);
				this.method_11(this.IdParent);
			}
		}

		private void method_2()
		{
			if (this.dataGridView_0.CurrentRow != null)
			{
				FormAddGroupElementList formAddGroupElementList = new FormAddGroupElementList();
				formAddGroupElementList.SqlSettings = this.SqlSettings;
				formAddGroupElementList.stateFormCreate = 5;
				formAddGroupElementList.TableName = TableNameEnum.tP_ValueLists;
				formAddGroupElementList.Id = this.IdParent;
				if (formAddGroupElementList.ShowDialog() == DialogResult.OK)
				{
					this.method_10(formAddGroupElementList.Id);
				}
			}
		}

		private void method_3()
		{
			if (this.dataGridView_0.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить группу?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.method_7(this.IdParent);
				this.method_9();
			}
		}

		private void method_4()
		{
			TableNameEnum tableNameEnum = this.method_8();
			if (tableNameEnum != TableNameEnum.tAbn)
			{
				if (tableNameEnum != TableNameEnum.tP_ValueLists)
				{
					MessageBox.Show("Невозможно добавить элемент в выбранную группу", "Добавление.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			FormAddGroupElementList formAddGroupElementList = new FormAddGroupElementList();
			formAddGroupElementList.SqlSettings = this.SqlSettings;
			formAddGroupElementList.IdParent = this.IdParent;
			formAddGroupElementList.stateFormCreate = 4;
			formAddGroupElementList.TableName = tableNameEnum;
			if (formAddGroupElementList.ShowDialog() == DialogResult.OK)
			{
				this.method_12(this.IdParent, formAddGroupElementList.Id);
				return;
			}
		}

		private void method_5()
		{
			if (this.dataGridView_1.CurrentRow != null && this.method_8() == TableNameEnum.tP_ValueLists)
			{
				FormAddGroupElementList formAddGroupElementList = new FormAddGroupElementList();
				formAddGroupElementList.SqlSettings = this.SqlSettings;
				formAddGroupElementList.stateFormCreate = 6;
				formAddGroupElementList.TableName = this.method_8();
				formAddGroupElementList.Id = this.Id;
				if (formAddGroupElementList.ShowDialog() == DialogResult.OK)
				{
					this.method_12(this.IdParent, formAddGroupElementList.Id);
					return;
				}
			}
			else
			{
				MessageBox.Show("Невозможно редактировать элемент в выбранной группе", "Редактирование.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void method_6()
		{
			if (this.dataGridView_1.CurrentRow != null)
			{
				if (this.method_8() == TableNameEnum.tP_ValueLists)
				{
					if (MessageBox.Show("Вы действительно хотите удалить значение?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
					{
						this.method_7(this.Id);
						this.method_11(this.IdParent);
						return;
					}
				}
				else
				{
					MessageBox.Show("Удалить выбранное значение невозможно", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				}
			}
		}

		private bool method_7(int int_2)
		{
			base.SelectSqlDataTableOther(this.dsPassport_0, this.dsPassport_0.tP_ValueList, "tP_Valuelists", true, "WHERE Id = " + int_2.ToString());
			if (this.dsPassport_0.tP_ValueList.Rows.Count == 0)
			{
				return false;
			}
			((dsPassport.Class34)this.dsPassport_0.tP_ValueList.Rows[0]).method_5(true);
			return base.UpdateSqlDataTableOther(this.dsPassport_0, this.dsPassport_0.tP_ValueList, "tP_Valuelists");
		}

		private TableNameEnum method_8()
		{
			string a = (this.dataGridView_1.RowCount > 0) ? this.dataGridView_1.Rows[0].Cells["tableNameValue"].Value.ToString() : "tP_ValueLists";
			if (a == "tP_ValueLists")
			{
				return TableNameEnum.tP_ValueLists;
			}
			if (a == "tR_KladrObj")
			{
				return TableNameEnum.tR_KladrObj;
			}
			if (a == "tR_KladrStreet")
			{
				return TableNameEnum.tR_KladrStreet;
			}
			if (a == "tAbn")
			{
				return TableNameEnum.tAbn;
			}
			if (a == "tR_Classifier")
			{
				return TableNameEnum.tR_Classifier;
			}
			if (!(a == "vP_Worker"))
			{
				return TableNameEnum.None;
			}
			return TableNameEnum.vP_Worker;
		}

		private void method_9()
		{
			int firstDisplayedScrollingRowIndex = this.dataGridView_0.FirstDisplayedScrollingRowIndex;
			base.SelectSqlDataTableOther(this.dsPassport_0, this.dsPassport_0.vP_GetGroupList, "vP_GetValueList", true, "WHERE Deleted = ((0))" + ((this.GroupKey == null || this.GroupKey.Length <= 0) ? "" : (" AND ParentKey LIKE '" + this.GroupKey + "'")) + " AND isGroup = ((1)) ORDER BY Name");
			this.bindingSource_0.ResetBindings(true);
			if (this.dataGridView_0.RowCount > 0 && firstDisplayedScrollingRowIndex != -1)
			{
				this.dataGridView_0.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
			}
		}

		private void method_10(int int_2)
		{
			int firstDisplayedScrollingRowIndex = this.dataGridView_0.FirstDisplayedScrollingRowIndex;
			base.SelectSqlDataTableOther(this.dsPassport_0, this.dsPassport_0.vP_GetGroupList, "vP_GetValueList", true, "WHERE Deleted = ((0)) AND isGroup = ((1)) ORDER BY Name");
			this.bindingSource_0.Position = this.bindingSource_0.Find("Id", int_2);
			if (this.dataGridView_0.RowCount > 0 && firstDisplayedScrollingRowIndex != -1)
			{
				this.dataGridView_0.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
			}
		}

		private void method_11(int int_2)
		{
			int firstDisplayedScrollingRowIndex = this.dataGridView_1.FirstDisplayedScrollingRowIndex;
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_GetValueList, true, "WHERE Deleted = ((0)) AND isGroup = ((0)) AND ParentId = " + int_2.ToString() + " ORDER BY Name");
			if (this.dataGridView_1.RowCount > 0 && firstDisplayedScrollingRowIndex != -1)
			{
				this.dataGridView_1.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
			}
		}

		private void method_12(int int_2, int int_3)
		{
			int firstDisplayedScrollingRowIndex = this.dataGridView_1.FirstDisplayedScrollingRowIndex;
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_GetValueList, true, "WHERE Deleted = ((0)) AND isGroup = ((0)) AND ParentId = " + int_2.ToString() + " ORDER BY Name");
			this.bindingSource_1.Position = this.bindingSource_1.Find("Id", int_3);
			if (this.dataGridView_1.RowCount > 0 && firstDisplayedScrollingRowIndex != -1)
			{
				this.dataGridView_1.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
			}
		}

		private void toolStripButton_7_VisibleChanged(object sender, EventArgs e)
		{
			this.toolStripSeparator_1.Visible = this.toolStripButton_7.Visible;
		}

		private void toolStripButton_3_VisibleChanged(object sender, EventArgs e)
		{
			this.toolStripSeparator_0.Visible = this.toolStripButton_3.Visible;
		}

		private void dataGridView_0_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dataGridView_0.CurrentRow != null)
			{
				this.IdParent = (int)this.dataGridView_0.CurrentRow.Cells["IdGroup"].Value;
				if (this.bool_0)
				{
					this.method_11(this.IdParent);
					this.toolStripButton_4.Enabled = (this.toolStripButton_6.Enabled = (this.toolStripButton_5.Enabled = ((int)this.dataGridView_0.CurrentRow.Cells["IdGroup"].Value != 107 && this.method_8() != TableNameEnum.vP_Worker)));
					this.method_13();
				}
			}
		}

		private void dataGridView_1_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dataGridView_1.CurrentRow != null && this.bool_0)
			{
				this.Id = (int)this.dataGridView_1.CurrentRow.Cells["IdValue"].Value;
				this.method_13();
			}
		}

		private void method_13()
		{
			int num = -1;
			if (this.dataGridView_1.SelectedRows != null && this.dataGridView_1.SelectedRows.Count > 0 && this.dataGridView_1.SelectedRows[0].Cells["tableNameValue"].Value.ToString() == TableNameEnum.tAbn.ToString())
			{
				if (int.TryParse(this.dataGridView_1.SelectedRows[0].Cells["ParentIdAddl"].Value.ToString(), out num) && num == 683)
				{
					this.toolStripButton_4.Enabled = true;
					this.toolStripButton_5.Enabled = true;
					this.toolStripButton_6.Enabled = true;
					return;
				}
				this.toolStripButton_4.Enabled = true;
				this.toolStripButton_5.Enabled = false;
				this.toolStripButton_6.Enabled = false;
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			this.method_2();
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			this.method_3();
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.CurrentRow != null)
			{
				this.method_10(this.IdParent);
				return;
			}
			this.method_9();
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			this.method_4();
		}

		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			this.method_5();
		}

		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			this.method_6();
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_1.CurrentRow != null)
			{
				this.method_12(this.IdParent, this.Id);
				return;
			}
			this.method_11(this.IdParent);
		}

		private void FormReferValueLists_Shown(object sender, EventArgs e)
		{
			this.bool_0 = true;
			this.method_9();
			this.method_11(this.IdParent);
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

		private void method_14()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.dsPassport_0 = new dsPassport();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dataGridView_1 = new DataGridView();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripButton_7 = new ToolStripButton();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dataGridView_1).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.toolStrip_1.SuspendLayout();
			base.SuspendLayout();
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableLayoutPanel_0.ColumnCount = 3;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.07828f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.92172f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136f));
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 2, 2);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_1, 1, 1);
			this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.toolStrip_1, 1, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpGeneral";
			this.tableLayoutPanel_0.RowCount = 3;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 43f));
			this.tableLayoutPanel_0.Size = new Size(612, 432);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.button_0.Dock = DockStyle.Left;
			this.button_0.Location = new Point(482, 399);
			this.button_0.Margin = new Padding(7, 10, 3, 10);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Dock = DockStyle.Right;
			this.button_1.Location = new Point(385, 399);
			this.button_1.Margin = new Padding(3, 10, 7, 10);
			this.button_1.Name = "btnSave";
			this.button_1.Size = new Size(83, 23);
			this.button_1.TabIndex = 1;
			this.button_1.Text = "Сохранить";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Visible = false;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.BackgroundColor = Color.White;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1
			});
			this.dataGridView_0.DataSource = this.bindingSource_0;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Window;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = Color.White;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 29);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvGroup";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(279, 357);
			this.dataGridView_0.TabIndex = 2;
			this.dataGridView_0.SelectionChanged += this.dataGridView_0_SelectionChanged;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "isGroup";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "isGroup";
			this.dataGridViewCheckBoxColumn_0.Name = "isGroupGroup";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewCheckBoxColumn_1.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_1.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_1.Name = "DeletedGroup";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "idGroup";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Наименование группы";
			this.dataGridViewTextBoxColumn_1.Name = "NameGroup";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.bindingSource_0.DataMember = "vP_GetGroupList";
			this.bindingSource_0.DataSource = this.dsPassport_0;
			this.bindingSource_0.Sort = "Name";
			this.dataGridView_1.AllowUserToAddRows = false;
			this.dataGridView_1.AllowUserToDeleteRows = false;
			this.dataGridView_1.AllowUserToResizeRows = false;
			this.dataGridView_1.AutoGenerateColumns = false;
			this.dataGridView_1.BackgroundColor = Color.White;
			this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_2,
				this.dataGridViewCheckBoxColumn_3,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13
			});
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_1, 2);
			this.dataGridView_1.DataSource = this.bindingSource_1;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.White;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_1.Dock = DockStyle.Fill;
			this.dataGridView_1.Location = new Point(288, 29);
			this.dataGridView_1.MultiSelect = false;
			this.dataGridView_1.Name = "dgvValue";
			this.dataGridView_1.ReadOnly = true;
			this.dataGridView_1.RowHeadersVisible = false;
			this.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_1.Size = new Size(321, 357);
			this.dataGridView_1.TabIndex = 3;
			this.dataGridView_1.SelectionChanged += this.dataGridView_1_SelectionChanged;
			this.dataGridViewCheckBoxColumn_2.DataPropertyName = "isGroup";
			this.dataGridViewCheckBoxColumn_2.HeaderText = "isGroup";
			this.dataGridViewCheckBoxColumn_2.Name = "isGroupValue";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_2.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			this.dataGridViewCheckBoxColumn_3.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_3.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_3.Name = "DeletedValue";
			this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_3.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewCheckBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_9.HeaderText = "id";
			this.dataGridViewTextBoxColumn_9.Name = "idValue";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_10.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_10.Name = "ParentIdValue";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "ParentIdAddl";
			this.dataGridViewTextBoxColumn_11.HeaderText = "ParentIdAddl";
			this.dataGridViewTextBoxColumn_11.Name = "ParentIdAddl";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_12.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_12.Name = "NameValue";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "TableName";
			this.dataGridViewTextBoxColumn_13.HeaderText = "TableName";
			this.dataGridViewTextBoxColumn_13.Name = "tableNameValue";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.bindingSource_1.DataMember = "vP_GetValueList";
			this.bindingSource_1.DataSource = this.dsPassport_0;
			this.bindingSource_1.Sort = "Name";
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2,
				this.toolStripSeparator_0,
				this.toolStripButton_3
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "tsGroup";
			this.toolStrip_0.Size = new Size(285, 25);
			this.toolStrip_0.TabIndex = 4;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources._1353328228_folder_add;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tsbAddGroup";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Добавить группу";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.FolderEditYellow;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "tsbEditGroup";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Редактировать группу";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources._1353328250_folder_open_delete;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "tsbDeleteGroup";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Удалить группу";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripSeparator_0.Name = "tssRefreshGroup";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.refresh_16;
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "tsbRefreshGroup";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Обновить";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripButton_3.VisibleChanged += this.toolStripButton_3_VisibleChanged;
			this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_1, 2);
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_4,
				this.toolStripButton_5,
				this.toolStripButton_6,
				this.toolStripSeparator_1,
				this.toolStripButton_7
			});
			this.toolStrip_1.Location = new Point(285, 0);
			this.toolStrip_1.Name = "tsValue";
			this.toolStrip_1.Size = new Size(327, 25);
			this.toolStrip_1.TabIndex = 5;
			this.toolStrip_1.Text = "toolStrip2";
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = Resources.ElementAdd;
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "tsbAddValue";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Добавить элемент";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.ElementEdit;
			this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_5.Name = "tsbEditValue";
			this.toolStripButton_5.Size = new Size(23, 22);
			this.toolStripButton_5.Text = "Редактировать элемент";
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = Resources.ElementDel;
			this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_6.Name = "tsbDeleteValue";
			this.toolStripButton_6.Size = new Size(23, 22);
			this.toolStripButton_6.Text = "Удалить элемент";
			this.toolStripButton_6.Click += this.toolStripButton_6_Click;
			this.toolStripSeparator_1.Name = "tssRefreshValue";
			this.toolStripSeparator_1.Size = new Size(6, 25);
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = Resources.refresh_16;
			this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_7.Name = "tsbRefreshValue";
			this.toolStripButton_7.Size = new Size(23, 22);
			this.toolStripButton_7.Text = "Обновить";
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.toolStripButton_7.VisibleChanged += this.toolStripButton_7_VisibleChanged;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_2.HeaderText = "id";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_3.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Наименование группы";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_5.HeaderText = "id";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_6.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "TableName";
			this.dataGridViewTextBoxColumn_8.HeaderText = "TableName";
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(612, 432);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormReferValueLists";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Значения характеристик оборудования";
			base.Shown += this.FormReferValueLists_Shown;
			((ISupportInitialize)this.dsPassport_0).EndInit();
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dataGridView_1).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			base.ResumeLayout(false);
		}

		private bool bool_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_0;

		private IContainer icontainer_0;

		private dsPassport dsPassport_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private Button button_1;

		private DataGridView dataGridView_0;

		private DataGridView dataGridView_1;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripButton toolStripButton_3;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_4;

		private ToolStripButton toolStripButton_5;

		private ToolStripButton toolStripButton_6;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripButton toolStripButton_7;

		private BindingSource bindingSource_0;

		private BindingSource bindingSource_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
	}
}
