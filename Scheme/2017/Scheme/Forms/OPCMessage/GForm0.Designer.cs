using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty;
using FormLbr;
using Scheme.Properties;

namespace Scheme.Forms.OPCMessage
{
	public class GForm0 : FormBase
	{
		public GForm0()
		{
			Class63.AGd1PxHzk5wxP();
			base..ctor();
			this.method_0();
		}

		private void GForm0_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tOPC_MessageConfig"], true);
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (new FormOPCMessageAddEdit(0, -1)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tOPC_MessageConfig"], true);
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.CurrentRow != null && new FormOPCMessageAddEdit(1, Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells["idDgvColumn"].Value))
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tOPC_MessageConfig"], true);
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.CurrentRow != null && MessageBox.Show("Вы уверены, что хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes && base.DeleteSqlDataById(this.dataSet_0.Tables["tOPC_MessageConfig"], Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells["idDgvColumn"].Value)))
			{
				this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
			}
		}

		private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex].Name == "audioDgvColumn")
			{
				((DataGridViewDisableButtonColumn)this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex]).Text = "Play";
				DataGridViewDisableButtonCell dataGridViewDisableButtonCell = (DataGridViewDisableButtonCell)this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex];
				dataGridViewDisableButtonCell.UseColumnTextForButtonValue = true;
				if (this.dataGridViewExcelFilter_0["audioDgvColumnBinary", e.RowIndex].Value == DBNull.Value)
				{
					dataGridViewDisableButtonCell.Enabled = false;
				}
			}
		}

		private void dataGridViewExcelFilter_0_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex].Name == "audioDgvColumn" && ((DataGridViewDisableButtonCell)this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex]).Enabled)
			{
				new SoundPlayer(new MemoryStream((byte[])this.dataGridViewExcelFilter_0["audioDgvColumnBinary", e.RowIndex].Value, true)).Play();
			}
		}

		private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex].Name != "audioDgvColumn" && new FormOPCMessageAddEdit(1, Convert.ToInt32(this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Cells["idDgvColumn"].Value))
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tOPC_MessageConfig"], true);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			GForm0.WHSpW832nsHVY907fZi(this, disposing);
		}

		private void method_0()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.dataSet_0 = new DataSet();
			this.dataTable_0 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
			this.dataGridViewDisableButtonColumn_0 = new DataGridViewDisableButtonColumn();
			this.dataGridViewImageColumnNotNull_1 = new DataGridViewImageColumnNotNull();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.dataGridViewExcelFilter_0.BeginInit();
			base.SuspendLayout();
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
				this.dataColumn_4
			});
			this.dataTable_0.Constraints.AddRange(new Constraint[]
			{
				new UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dataTable_0.PrimaryKey = new DataColumn[]
			{
				this.dataColumn_0
			};
			this.dataTable_0.TableName = "tOPC_MessageConfig";
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.ColumnName = "Id";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_1.ColumnName = "KeySource";
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_2.ColumnName = "KeyMessage";
			this.dataColumn_3.ColumnName = "Icon";
			this.dataColumn_3.DataType = typeof(byte[]);
			this.dataColumn_4.ColumnName = "Audio";
			this.dataColumn_4.DataType = typeof(byte[]);
			this.bindingSource_0.DataMember = "tOPC_MessageConfig";
			this.bindingSource_0.DataSource = this.dataSet_0;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip";
			this.toolStrip_0.Size = new Size(695, 25);
			this.toolStrip_0.TabIndex = 1;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_19();
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolBtnAdd";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Добавить";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_21();
			this.toolStripButton_1.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_1.Name = "toolBtnEdit";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Редактировать";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.smethod_20();
			this.toolStripButton_2.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_2.Name = "toolBtnDel";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Удалить";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
			this.dataGridViewExcelFilter_0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewImageColumnNotNull_0,
				this.dataGridViewDisableButtonColumn_0,
				this.dataGridViewImageColumnNotNull_1
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 25);
			this.dataGridViewExcelFilter_0.MultiSelect = false;
			this.dataGridViewExcelFilter_0.Name = "dgvOPC";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(695, 290);
			this.dataGridViewExcelFilter_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.VirtualMode = true;
			this.dataGridViewExcelFilter_0.CellClick += this.dataGridViewExcelFilter_0_CellClick;
			this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
			this.dataGridViewExcelFilter_0.CellFormatting += this.dataGridViewExcelFilter_0_CellFormatting;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Id";
			this.dataGridViewTextBoxColumn_0.Name = "idDgvColumn";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "KeySource";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Ключ события";
			this.dataGridViewTextBoxColumn_1.Name = "keySourceDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Width = 150;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "KeyMessage";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Ключ сообщения";
			this.dataGridViewTextBoxColumn_2.Name = "keyMessageDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Width = 150;
			this.dataGridViewImageColumnNotNull_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumnNotNull_0.DataPropertyName = "Icon";
			dataGridViewCellStyle2.NullValue = null;
			this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewImageColumnNotNull_0.HeaderText = "Иконка";
			this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumnNotNull_0.Name = "iconDgvColumn";
			this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
			this.dataGridViewImageColumnNotNull_0.Width = 51;
			this.dataGridViewDisableButtonColumn_0.DataPropertyName = "Audio";
			this.dataGridViewDisableButtonColumn_0.HeaderText = "Аудио";
			this.dataGridViewDisableButtonColumn_0.Name = "audioDgvColumn";
			this.dataGridViewDisableButtonColumn_0.ReadOnly = true;
			this.dataGridViewDisableButtonColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewDisableButtonColumn_0.Width = 43;
			this.dataGridViewImageColumnNotNull_1.DataPropertyName = "Audio";
			dataGridViewCellStyle3.NullValue = null;
			this.dataGridViewImageColumnNotNull_1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewImageColumnNotNull_1.HeaderText = "Audio";
			this.dataGridViewImageColumnNotNull_1.Name = "audioDgvColumnBinary";
			this.dataGridViewImageColumnNotNull_1.ReadOnly = true;
			this.dataGridViewImageColumnNotNull_1.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(695, 315);
			base.Controls.Add(this.dataGridViewExcelFilter_0);
			base.Controls.Add(this.toolStrip_0);
			base.Name = "FormOPCMessageConfig";
			this.Text = "Настройка сообщений телеметрии";
			base.Load += this.GForm0_Load;
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.dataGridViewExcelFilter_0.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void WHSpW832nsHVY907fZi(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private IContainer icontainer_0;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private BindingSource bindingSource_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;

		private DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn_0;

		private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_1;
	}
}
