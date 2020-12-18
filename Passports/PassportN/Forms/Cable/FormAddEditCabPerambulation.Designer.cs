using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using FormLbr.Classes;
using Passport.Properties;

namespace Passport.Forms.Cable
{
	public class FormAddEditCabPerambulation : FormBase
	{
		public int Id { get; set; }

		public int IdObjList { get; set; }

		public StateFormCreate StateCreate { get; set; }

		public FormAddEditCabPerambulation()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_6();
		}

		public FormAddEditCabPerambulation(SQLSettings settings, int id, StateFormCreate state)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_6();
			this.SqlSettings = settings;
			this.Id = ((state == 1) ? id : -1);
			this.IdObjList = ((state == null) ? id : -1);
			this.StateCreate = state;
		}

		private void FormAddEditCabPerambulation_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.vP_Worker, true, string.Format("WHERE ParentKey = ';GroupWorker;CableService;Check;'", new object[0]));
			if (this.StateCreate == 1)
			{
				this.method_0();
				return;
			}
			Class107.Class275 @class = this.class107_0.tP_CabPerambulation.method_5();
			@class.idObjList = this.IdObjList;
			@class.Deleted = false;
			this.class107_0.tP_CabPerambulation.method_0(@class);
		}

		private void method_0()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CabPerambulation, true, string.Format("WHERE id = {0} AND Deleted = ((0))", this.Id));
			this.bindingSource_2.ResetBindings(false);
			this.method_1();
			this.method_2();
		}

		private void method_1()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CabPeramWorker, true, string.Format("WHERE idPerambulation = {0} AND Deleted = ((0))", (int)this.class107_0.tP_CabPerambulation.Rows[0]["id"]));
			this.bindingSource_1.ResetBindings(false);
		}

		private void method_2()
		{
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				SqlCommand selectCommand = new SqlCommand(string.Format("SELECT [id],[idPasspDoc],[DateIn],[DateCreate],[FileName],[Icon],[isActive],[Deleted] FROM [tP_Image] WHERE idPasspDoc = {0} AND Deleted = ((0))", (int)this.class107_0.tP_CabPerambulation.Rows[0]["id"]), sqlConnection);
				sqlConnection.Open();
				DbDataAdapter dbDataAdapter = new SqlDataAdapter(selectCommand);
				this.class107_0.tP_Image.Clear();
				dbDataAdapter.Fill(this.class107_0.tP_Image);
			}
			this.bindingSource_0.ResetBindings(false);
		}

		private bool method_3()
		{
			this.bindingSource_2.EndEdit();
			if (this.StateCreate == null)
			{
				if (this.Id == -1)
				{
					this.Id = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_CabPerambulation);
				}
				else
				{
					base.UpdateSqlData(this.class107_0, this.class107_0.tP_CabPerambulation);
				}
			}
			else
			{
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_CabPerambulation);
			}
			this.method_0();
			base.DialogResult = DialogResult.OK;
			return true;
		}

		private void dataGridView_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.Columns[e.ColumnIndex].Name == "idWorkerDataGridViewTextBoxColumn" && e.RowIndex >= 0 && dgv["idWorkerDataGridViewTextBoxColumn", e.RowIndex].Value is int)
			{
				e.Value = (from row in this.class107_0.vP_Worker
				where row.Id == (int)dgv["idWorkerDataGridViewTextBoxColumn", e.RowIndex].Value
				select row.FIO).First<string>();
				e.FormattingApplied = true;
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			this.method_3();
		}

		private void dataGridView_0_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && this.dataGridView_0.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value is int)
			{
				this.method_4();
			}
		}

		private void method_4()
		{
			new FormImageView
			{
				SqlSettings = this.SqlSettings,
				IdParent = this.Id,
				IdImage = (int)this.dataGridView_0.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			if (this.button_1.Enabled)
			{
				this.method_3();
			}
			FormAddEditWorker formAddEditWorker = new FormAddEditWorker(this.class107_0.vP_Worker);
			formAddEditWorker.StartPosition = FormStartPosition.CenterScreen;
			if (formAddEditWorker.ShowDialog() == DialogResult.OK)
			{
				Class107.Class274 @class = this.class107_0.tP_CabPeramWorker.method_5();
				@class.idPerambulation = this.Id;
				@class.idWorker = formAddEditWorker.IdWorker;
				@class.Deleted = false;
				this.class107_0.tP_CabPeramWorker.method_0(@class);
				int num = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_CabPeramWorker);
				this.method_1();
				this.bindingSource_1.Position = this.bindingSource_1.Find("id", num);
			}
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_1.SelectedRows != null && this.dataGridView_1.SelectedRows.Count > 0)
			{
				FormAddEditWorker formAddEditWorker = new FormAddEditWorker(this.class107_0.vP_Worker, (int)this.dataGridView_1.SelectedRows[0].Cells["idWorkerDataGridViewTextBoxColumn"].Value);
				formAddEditWorker.StartPosition = FormStartPosition.CenterScreen;
				if (formAddEditWorker.ShowDialog() == DialogResult.OK)
				{
					this.dataGridView_1.SelectedRows[0].Cells["idWorkerDataGridViewTextBoxColumn"].Value = formAddEditWorker.IdWorker;
					int num = (int)this.dataGridView_1.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;
					this.bindingSource_1.EndEdit();
					base.UpdateSqlData(this.class107_0, this.class107_0.tP_CabPeramWorker);
					this.method_1();
					this.bindingSource_1.Position = this.bindingSource_1.Find("id", num);
				}
			}
		}

		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_1.SelectedRows != null && this.dataGridView_1.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					DbCommand dbCommand = new SqlCommand("UPDATE tP_CabPeramWorker SET Deleted = ((1)) WHERE Id = " + ((DataRowView)this.bindingSource_1.Current)["id"].ToString(), sqlConnection);
					sqlConnection.Open();
					dbCommand.ExecuteNonQuery();
				}
				this.method_1();
			}
		}

		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			if (this.button_1.Enabled)
			{
				this.method_3();
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Файлы изображений (*.bmp, *.jpg)|*.bmp;*.jpg";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.method_5(openFileDialog.FileName);
			}
		}

		private void method_5(string string_0)
		{
			Image image = Image.FromFile(string_0);
			FileInfo fileInfo = new FileInfo(string_0);
			DataRow dataRow = this.class107_0.tP_Image.NewRow();
			dataRow["idPasspDoc"] = this.Id;
			dataRow["DateIn"] = DateTime.Now;
			dataRow["DateCreate"] = File.GetCreationTime(string_0);
			dataRow["FileName"] = fileInfo.Name;
			dataRow["Icon"] = ((ImageCompress.TypeOfFile(Path.GetExtension(string_0)).IndexOf("Image") > -1) ? ImageCompress.GetBytes(image) : ImageCompress.GetBytes(ImageCompress.GetIcon(string_0).ToBitmap()));
			dataRow["Image"] = File.ReadAllBytes(string_0);
			dataRow["isActive"] = true;
			dataRow["Deleted"] = false;
			this.class107_0.tP_Image.Rows.Add(dataRow);
			int num = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_Image);
			this.method_2();
			this.bindingSource_0.Position = this.bindingSource_0.Find("id", num);
		}

		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0 && this.dataGridView_0.SelectedRows[0].Cells["imageDataGridViewImageColumn"].Value is byte[])
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Файлы изображений (*.bmp, *.jpg)|*.bmp;*.jpg";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					DataTable dataTable = base.SelectSqlData("tP_image", true, "WHERE id = " + ((int)this.dataGridView_0.SelectedRows[0].Cells["idDataGridViewImageColumn"].Value).ToString());
					File.WriteAllBytes(saveFileDialog.FileName, (byte[])dataTable.Rows[0]["Image"]);
				}
			}
		}

		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					DbCommand dbCommand = new SqlCommand("UPDATE tP_Image SET Deleted = ((1)) WHERE Id = " + ((DataRowView)this.bindingSource_0.Current)["id"].ToString(), sqlConnection);
					sqlConnection.Open();
					dbCommand.ExecuteNonQuery();
				}
				this.method_2();
			}
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void FormAddEditCabPerambulation_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && this.button_1.Enabled && !this.method_3())
			{
				e.Cancel = true;
			}
		}

		private void textBox_1_TextChanged(object sender, EventArgs e)
		{
			this.button_1.Enabled = true;
		}

		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0)
			{
				this.method_4();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormAddEditCabPerambulation.wsuALY9IQyP48RQjhcNd(this, disposing);
		}

		private void method_6()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_6 = new ToolStripButton();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_1 = new DataGridViewImageColumn();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.class107_0 = new Class107();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripButton_5 = new ToolStripButton();
			this.dataGridView_1 = new DataGridView();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.button_2 = new Button();
			this.panel_0 = new Panel();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.contextMenuStrip_1.SuspendLayout();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.class107_0).BeginInit();
			this.toolStrip_1.SuspendLayout();
			((ISupportInitialize)this.dataGridView_1).BeginInit();
			this.contextMenuStrip_0.SuspendLayout();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 5;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99f));
			this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 3, 0);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 3, 1);
			this.tableLayoutPanel_0.Controls.Add(this.toolStrip_1, 0, 5);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_1, 0, 6);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 7);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 7);
			this.tableLayoutPanel_0.Controls.Add(this.button_2, 4, 7);
			this.tableLayoutPanel_0.Controls.Add(this.panel_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.dateTimePicker_0, 1, 0);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_1, 1, 3);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 8;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 15f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 51f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 51f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 8f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel_0.Size = new Size(711, 354);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_0, 2);
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2,
				this.toolStripButton_6
			});
			this.toolStrip_0.Location = new Point(536, 0);
			this.toolStrip_0.Name = "tsImage";
			this.toolStrip_0.Size = new Size(175, 25);
			this.toolStrip_0.TabIndex = 7;
			this.toolStrip_0.Text = "tsImage";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_41();
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tsbAddImage";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Добавить";
			this.toolStripButton_0.Click += this.toolStripMenuItem_5_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_43();
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "tsbSaveImage";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Сохранить как...";
			this.toolStripButton_1.Click += this.toolStripMenuItem_4_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.smethod_42();
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "tsbDeleteImage";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Удалить";
			this.toolStripButton_2.Click += this.toolStripMenuItem_6_Click;
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = Resources.smethod_40();
			this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_6.Name = "tsbShowImage";
			this.toolStripButton_6.Size = new Size(23, 22);
			this.toolStripButton_6.Text = "Открыть";
			this.toolStripButton_6.Click += this.toolStripMenuItem_3_Click;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeColumns = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_0.BackgroundColor = SystemColors.Control;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.ColumnHeadersVisible = false;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewImageColumn_0,
				this.dataGridViewImageColumn_1,
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewCheckBoxColumn_2,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13,
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_15
			});
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_0, 2);
			this.dataGridView_0.ContextMenuStrip = this.contextMenuStrip_1;
			this.dataGridView_0.DataSource = this.bindingSource_0;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.Control;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Control;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.Control;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.GridColor = SystemColors.Control;
			this.dataGridView_0.Location = new Point(539, 28);
			this.dataGridView_0.Name = "dgvImage";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.RowHeadersVisible = false;
			this.tableLayoutPanel_0.SetRowSpan(this.dataGridView_0, 6);
			this.dataGridView_0.ScrollBars = ScrollBars.Vertical;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(169, 283);
			this.dataGridView_0.TabIndex = 6;
			this.dataGridView_0.CellContentDoubleClick += this.dataGridView_0_CellContentDoubleClick;
			this.dataGridViewImageColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewImageColumn_0.DataPropertyName = "Icon";
			this.dataGridViewImageColumn_0.HeaderText = "Icon";
			this.dataGridViewImageColumn_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn_0.Name = "iconDataGridViewImageColumn";
			this.dataGridViewImageColumn_0.ReadOnly = true;
			this.dataGridViewImageColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewImageColumn_1.DataPropertyName = "Image";
			this.dataGridViewImageColumn_1.HeaderText = "Image";
			this.dataGridViewImageColumn_1.ImageLayout = DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn_1.Name = "imageDataGridViewImageColumn";
			this.dataGridViewImageColumn_1.ReadOnly = true;
			this.dataGridViewImageColumn_1.Visible = false;
			this.dataGridViewCheckBoxColumn_1.DataPropertyName = "isActive";
			this.dataGridViewCheckBoxColumn_1.HeaderText = "isActive";
			this.dataGridViewCheckBoxColumn_1.Name = "isActiveDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Visible = false;
			this.dataGridViewCheckBoxColumn_2.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_2.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_2.Name = "deletedDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_11.HeaderText = "id";
			this.dataGridViewTextBoxColumn_11.Name = "idDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "idPasspDoc";
			this.dataGridViewTextBoxColumn_12.HeaderText = "idPasspDoc";
			this.dataGridViewTextBoxColumn_12.Name = "idPasspDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "DateIn";
			this.dataGridViewTextBoxColumn_13.HeaderText = "DateIn";
			this.dataGridViewTextBoxColumn_13.Name = "dateInDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "DateCreate";
			this.dataGridViewTextBoxColumn_14.HeaderText = "DateCreate";
			this.dataGridViewTextBoxColumn_14.Name = "dateCreateDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "FileName";
			this.dataGridViewTextBoxColumn_15.HeaderText = "FileName";
			this.dataGridViewTextBoxColumn_15.Name = "fileNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.contextMenuStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_3,
				this.toolStripMenuItem_4,
				this.toolStripSeparator_1,
				this.toolStripMenuItem_5,
				this.toolStripSeparator_2,
				this.toolStripMenuItem_6
			});
			this.contextMenuStrip_1.Name = "cmsImage";
			this.contextMenuStrip_1.Size = new Size(163, 104);
			this.toolStripMenuItem_3.Image = Resources.smethod_40();
			this.toolStripMenuItem_3.Name = "tsmiShowImage";
			this.toolStripMenuItem_3.Size = new Size(162, 22);
			this.toolStripMenuItem_3.Text = "Открыть";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.toolStripMenuItem_4.Image = Resources.smethod_43();
			this.toolStripMenuItem_4.Name = "tsmiSaveImage";
			this.toolStripMenuItem_4.Size = new Size(162, 22);
			this.toolStripMenuItem_4.Text = "Сохранить как...";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.toolStripSeparator_1.Name = "toolStripSeparator3";
			this.toolStripSeparator_1.Size = new Size(159, 6);
			this.toolStripMenuItem_5.Image = Resources.smethod_41();
			this.toolStripMenuItem_5.Name = "tsmiAddImage";
			this.toolStripMenuItem_5.Size = new Size(162, 22);
			this.toolStripMenuItem_5.Text = "Добавить";
			this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
			this.toolStripSeparator_2.Name = "toolStripSeparator2";
			this.toolStripSeparator_2.Size = new Size(159, 6);
			this.toolStripMenuItem_6.Image = Resources.smethod_42();
			this.toolStripMenuItem_6.Name = "tsmiDeleteImage";
			this.toolStripMenuItem_6.Size = new Size(162, 22);
			this.toolStripMenuItem_6.Text = "Удалить";
			this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
			this.bindingSource_0.DataMember = "tP_Image";
			this.bindingSource_0.DataSource = this.class107_0;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_1, 3);
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_3,
				this.toolStripButton_4,
				this.toolStripButton_5
			});
			this.toolStrip_1.Location = new Point(0, 150);
			this.toolStrip_1.Name = "tsWorker";
			this.toolStrip_1.Size = new Size(536, 25);
			this.toolStrip_1.TabIndex = 8;
			this.toolStrip_1.Text = "toolStrip2";
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.smethod_24();
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "tsbAddWorker";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Добавить";
			this.toolStripButton_3.Click += this.toolStripMenuItem_0_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = Resources.smethod_26();
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "tsbEditWorker";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Редактировать";
			this.toolStripButton_4.Click += this.toolStripMenuItem_1_Click;
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.smethod_25();
			this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_5.Name = "tsbDeleteWorker";
			this.toolStripButton_5.Size = new Size(23, 22);
			this.toolStripButton_5.Text = "Удалить";
			this.toolStripButton_5.Click += this.toolStripMenuItem_2_Click;
			this.dataGridView_1.AllowUserToAddRows = false;
			this.dataGridView_1.AllowUserToDeleteRows = false;
			this.dataGridView_1.AutoGenerateColumns = false;
			this.dataGridView_1.BackgroundColor = Color.White;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2
			});
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_1, 3);
			this.dataGridView_1.ContextMenuStrip = this.contextMenuStrip_0;
			this.dataGridView_1.DataSource = this.bindingSource_1;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.White;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.White;
			dataGridViewCellStyle3.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.dataGridView_1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_1.Dock = DockStyle.Fill;
			this.dataGridView_1.Location = new Point(3, 178);
			this.dataGridView_1.Name = "dgvWorker";
			this.dataGridView_1.ReadOnly = true;
			this.dataGridView_1.RowHeadersVisible = false;
			this.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_1.Size = new Size(530, 133);
			this.dataGridView_1.TabIndex = 10;
			this.dataGridView_1.CellFormatting += this.dataGridView_1_CellFormatting;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_0.Name = "deletedDataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "idPerambulation";
			this.dataGridViewTextBoxColumn_1.HeaderText = "idPerambulation";
			this.dataGridViewTextBoxColumn_1.Name = "idPerambulationDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "idWorker";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Фамилия И.О.";
			this.dataGridViewTextBoxColumn_2.Name = "idWorkerDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1,
				this.toolStripSeparator_0,
				this.toolStripMenuItem_2
			});
			this.contextMenuStrip_0.Name = "cmsWork";
			this.contextMenuStrip_0.Size = new Size(155, 76);
			this.toolStripMenuItem_0.Image = Resources.smethod_24();
			this.toolStripMenuItem_0.Name = "tsmiAddWorker";
			this.toolStripMenuItem_0.Size = new Size(154, 22);
			this.toolStripMenuItem_0.Text = "Добавить";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_1.Image = Resources.smethod_26();
			this.toolStripMenuItem_1.Name = "tsmiEditWorker";
			this.toolStripMenuItem_1.Size = new Size(154, 22);
			this.toolStripMenuItem_1.Text = "Редактировать";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(151, 6);
			this.toolStripMenuItem_2.Image = Resources.smethod_25();
			this.toolStripMenuItem_2.Name = "tsmiDeleteWorker";
			this.toolStripMenuItem_2.Size = new Size(154, 22);
			this.toolStripMenuItem_2.Text = "Удалить";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.bindingSource_1.DataMember = "tP_CabPeramWorker";
			this.bindingSource_1.DataSource = this.class107_0;
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(396, 322);
			this.button_0.Margin = new Padding(3, 8, 10, 7);
			this.button_0.Name = "btnAccept";
			this.button_0.Size = new Size(80, 25);
			this.button_0.TabIndex = 11;
			this.button_0.Text = "Ок";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.tableLayoutPanel_0.SetColumnSpan(this.button_1, 2);
			this.button_1.Dock = DockStyle.Left;
			this.button_1.Location = new Point(496, 322);
			this.button_1.Margin = new Padding(10, 8, 3, 7);
			this.button_1.Name = "btnSave";
			this.button_1.Size = new Size(87, 25);
			this.button_1.TabIndex = 12;
			this.button_1.Text = "Сохранить";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_2.Cursor = Cursors.Default;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Dock = DockStyle.Right;
			this.button_2.Location = new Point(622, 322);
			this.button_2.Margin = new Padding(10, 8, 15, 7);
			this.button_2.Name = "btnClose";
			this.button_2.Size = new Size(74, 25);
			this.button_2.TabIndex = 13;
			this.button_2.Text = "Закрыть";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Controls.Add(this.label_1);
			this.panel_0.Controls.Add(this.label_2);
			this.panel_0.Controls.Add(this.label_3);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(3, 3);
			this.panel_0.Name = "panel2";
			this.tableLayoutPanel_0.SetRowSpan(this.panel_0, 5);
			this.panel_0.Size = new Size(166, 144);
			this.panel_0.TabIndex = 14;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(9, 107);
			this.label_0.Name = "label4";
			this.label_0.Size = new Size(147, 13);
			this.label_0.TabIndex = 10;
			this.label_0.Text = "устранинию неисправности";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(9, 44);
			this.label_1.Name = "label3";
			this.label_1.Size = new Size(156, 13);
			this.label_1.TabIndex = 9;
			this.label_1.Text = "Обнаружение неисправности";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(9, 18);
			this.label_2.Name = "label2";
			this.label_2.Size = new Size(71, 13);
			this.label_2.TabIndex = 8;
			this.label_2.Text = "Дата обхода";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(9, 91);
			this.label_3.Name = "label1";
			this.label_3.Size = new Size(106, 13);
			this.label_3.TabIndex = 7;
			this.label_3.Text = "Меры, принятые по";
			this.tableLayoutPanel_0.SetColumnSpan(this.dateTimePicker_0, 2);
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.bindingSource_2, "Date", true));
			this.dateTimePicker_0.Dock = DockStyle.Bottom;
			this.dateTimePicker_0.Location = new Point(175, 17);
			this.dateTimePicker_0.Name = "dtpDate";
			this.tableLayoutPanel_0.SetRowSpan(this.dateTimePicker_0, 2);
			this.dateTimePicker_0.Size = new Size(358, 20);
			this.dateTimePicker_0.TabIndex = 15;
			this.bindingSource_2.DataMember = "tP_CabPerambulation";
			this.bindingSource_2.DataSource = this.class107_0;
			this.tableLayoutPanel_0.SetColumnSpan(this.textBox_0, 2);
			this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_2, "Defect", true));
			this.textBox_0.Dock = DockStyle.Fill;
			this.textBox_0.Location = new Point(175, 43);
			this.textBox_0.Multiline = true;
			this.textBox_0.Name = "tbDefect";
			this.textBox_0.Size = new Size(358, 45);
			this.textBox_0.TabIndex = 16;
			this.textBox_0.TextChanged += this.textBox_1_TextChanged;
			this.tableLayoutPanel_0.SetColumnSpan(this.textBox_1, 2);
			this.textBox_1.DataBindings.Add(new Binding("Text", this.bindingSource_2, "Repair", true));
			this.textBox_1.Dock = DockStyle.Fill;
			this.textBox_1.Location = new Point(175, 94);
			this.textBox_1.Multiline = true;
			this.textBox_1.Name = "tbRepair";
			this.textBox_1.Size = new Size(358, 45);
			this.textBox_1.TabIndex = 17;
			this.textBox_1.TextChanged += this.textBox_1_TextChanged;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_3.HeaderText = "id";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "idPasspDoc";
			this.dataGridViewTextBoxColumn_4.HeaderText = "idPasspDoc";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "DateIn";
			this.dataGridViewTextBoxColumn_5.HeaderText = "DateIn";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "DateCreate";
			this.dataGridViewTextBoxColumn_6.HeaderText = "DateCreate";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "FileName";
			this.dataGridViewTextBoxColumn_7.HeaderText = "FileName";
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_8.HeaderText = "id";
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "idPerambulation";
			this.dataGridViewTextBoxColumn_9.HeaderText = "idPerambulation";
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "idWorker";
			this.dataGridViewTextBoxColumn_10.HeaderText = "Фамилия И.О.";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_2;
			base.ClientSize = new Size(711, 354);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormAddEditCabPerambulation";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Обход трассы кабельной линии";
			base.FormClosing += this.FormAddEditCabPerambulation_FormClosing;
			base.Load += this.FormAddEditCabPerambulation_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.contextMenuStrip_1.ResumeLayout(false);
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.class107_0).EndInit();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			((ISupportInitialize)this.dataGridView_1).EndInit();
			this.contextMenuStrip_0.ResumeLayout(false);
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			base.ResumeLayout(false);
		}

		internal static void wsuALY9IQyP48RQjhcNd(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private DataGridView dataGridView_0;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_3;

		private ToolStripButton toolStripButton_4;

		private ToolStripButton toolStripButton_5;

		private DataGridView dataGridView_1;

		private Button button_0;

		private Button button_1;

		private Button button_2;

		private BindingSource bindingSource_0;

		private Class107 class107_0;

		private BindingSource bindingSource_1;

		private BindingSource bindingSource_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private Panel panel_0;

		private Label label_0;

		private Label label_1;

		private Label label_2;

		private Label label_3;

		private DateTimePicker dateTimePicker_0;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private DataGridViewImageColumn dataGridViewImageColumn_0;

		private DataGridViewImageColumn dataGridViewImageColumn_1;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private ToolStripButton toolStripButton_6;

		private ContextMenuStrip contextMenuStrip_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ContextMenuStrip contextMenuStrip_1;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripMenuItem toolStripMenuItem_4;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripMenuItem toolStripMenuItem_5;

		private ToolStripSeparator toolStripSeparator_2;

		private ToolStripMenuItem toolStripMenuItem_6;
	}
}
