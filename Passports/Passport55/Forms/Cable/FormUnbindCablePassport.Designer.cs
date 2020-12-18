using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.DataSets;
using Passport.Properties;

namespace Passport.Forms.Cable
{
	public class FormUnbindCablePassport : FormBase
	{
		public int IdObjList
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public EquipmentType TypeEquipment
		{
			get
			{
				return this.equipmentType_0;
			}
			set
			{
				this.equipmentType_0 = value;
			}
		}

		public FormUnbindCablePassport()
		{
			this.method_3();
		}

		public FormUnbindCablePassport(SQLSettings settings, int idObjList)
		{
			this.method_3();
			this.SqlSettings = settings;
			this.int_0 = idObjList;
			this.equipmentType_0 = this.method_2(idObjList);
		}

		public FormUnbindCablePassport(SQLSettings settings, int idObjList, EquipmentType equipmentType)
		{
			this.method_3();
			this.SqlSettings = settings;
			this.int_0 = idObjList;
			this.equipmentType_0 = equipmentType;
		}

		private void FormUnbindCablePassport_Load(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void method_0()
		{
			DataTable journalData = PassportData.GetJournalData(this.SqlSettings, new int[]
			{
				this.equipmentType_0
			}, true, false);
			if (this.toolStripButton_0.Checked)
			{
				DataTable journalData2 = PassportData.GetJournalData(this.SqlSettings, new int[]
				{
					this.equipmentType_0
				}, true, true);
				journalData.Merge(journalData2);
			}
			this.dataGridView_0.DataSource = journalData;
		}

		private void FormUnbindCablePassport_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && !this.method_1())
			{
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
				return;
			}
		}

		private bool method_1()
		{
			if (this.dataGridView_0.SelectedRows == null && this.dataGridView_0.SelectedRows.Count == 0)
			{
				MessageBox.Show("Не выбран паспорт для привязки");
				return false;
			}
			if (Convert.ToBoolean(this.dataGridView_0.SelectedRows[0].Cells[this.dataGridViewCheckBoxColumn_0.Name].Value))
			{
				if (SchmObj.BindDeletedPassport(this.SqlSettings, this.int_0, Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_3.Name].Value)))
				{
					MessageBox.Show("Паспорт успешно отвязан.");
					return true;
				}
			}
			else if (SchmObj.BindPassport(this.SqlSettings, this.int_0, (int)this.dataGridView_0.CurrentRow.Cells["idUnbind"].Value))
			{
				MessageBox.Show("Паспорт успешно отвязан.");
				return true;
			}
			return true;
		}

		private void dataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private EquipmentType method_2(int int_1)
		{
			DataTable dataTable = base.SelectSqlData("tSchm_ObjList", true, string.Format("WHERE id = {0}", int_1));
			if (dataTable.Rows.Count <= 0)
			{
				return -1;
			}
			return (int)dataTable.Rows[0]["TypeCodeId"];
		}

		private void toolStripButton_0_CheckedChanged(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void dataGridView_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, e.RowIndex].Value is bool && Convert.ToBoolean(this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, e.RowIndex].Value))
			{
				e.CellStyle.ForeColor = Color.Red;
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

		private void method_3()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridView_0 = new DataGridView();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.dsPassport_0 = new dsPassport();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103f));
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 3;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
			this.tableLayoutPanel_0.Size = new Size(783, 342);
			this.tableLayoutPanel_0.TabIndex = 3;
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(577, 311);
			this.button_0.Margin = new Padding(3, 7, 10, 7);
			this.button_0.Name = "btnAccept";
			this.button_0.Size = new Size(93, 24);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Dock = DockStyle.Left;
			this.button_1.Location = new Point(690, 311);
			this.button_1.Margin = new Padding(10, 7, 3, 7);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 24);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToOrderColumns = true;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.BackgroundColor = Color.White;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewCheckBoxColumn_0
			});
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_0, 2);
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.White;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = Color.White;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 28);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvGeneral";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(777, 273);
			this.dataGridView_0.TabIndex = 0;
			this.dataGridView_0.CellDoubleClick += this.dataGridView_0_CellDoubleClick;
			this.dataGridView_0.CellFormatting += this.dataGridView_0_CellFormatting;
			this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_0, 2);
			this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "tsMain";
			this.toolStrip_0.Size = new Size(783, 25);
			this.toolStrip_0.TabIndex = 3;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.CheckOnClick = true;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.Trash;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tsBtnShowDeleted";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Показать удаленные";
			this.toolStripButton_0.CheckedChanged += this.toolStripButton_0_CheckedChanged;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "idUnbind";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "idPassport";
			this.dataGridViewTextBoxColumn_1.HeaderText = "idPassportUnbind";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_2.HeaderText = "idUnbind";
			this.dataGridViewTextBoxColumn_2.Name = "idUnbind";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "idPassport";
			this.dataGridViewTextBoxColumn_3.HeaderText = "idPassportUnbind";
			this.dataGridViewTextBoxColumn_3.Name = "idPassportUnbind";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "P_Deleted";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "deletedPassport";
			this.dataGridViewCheckBoxColumn_0.Name = "p_deleted";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_1;
			base.ClientSize = new Size(783, 342);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormUnbindCablePassport";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Отвязанные паспорта";
			base.FormClosing += this.FormUnbindCablePassport_FormClosing;
			base.Load += this.FormUnbindCablePassport_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			base.ResumeLayout(false);
		}

		private int int_0;

		private EquipmentType equipmentType_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private Button button_1;

		private DataGridView dataGridView_0;

		private dsPassport dsPassport_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
	}
}
