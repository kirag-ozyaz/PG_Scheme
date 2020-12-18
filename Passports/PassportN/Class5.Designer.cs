using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using Passport.Controls;
using Passport.Properties;
using WinFormsUI.Docking;

internal class Class5 : DockContentBase
{
	internal Class5(SQLSettings sqlsettings_0, int int_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_1();
		this.int_0 = int_1;
		this.SqlSettings = sqlsettings_0;
		this.method_0(int_1);
	}

	private void method_0(int int_1)
	{
		base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where idObjList = {0} order by isActive desc", int_1), null, true, 0);
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
	}

	private void dataGridView_2_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
	{
	}

	private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
	{
		if (this.bindingSource_0.Current != null)
		{
			this.dataGridViewPassport_0.AddRowViewingParameters(this.SqlSettings, (int)((DataRowView)this.bindingSource_0.Current)["id"]);
			if (((DataRowView)this.bindingSource_0.Current)["deleted"] is bool)
			{
				if ((bool)((DataRowView)this.bindingSource_0.Current)["deleted"])
				{
					this.toolStripButton_7.Text = "Восстановить";
				}
				else
				{
					this.toolStripButton_7.Text = "Удалить";
				}
			}
			if (((DataRowView)this.bindingSource_0.Current)["isActive"] is bool)
			{
				if ((bool)((DataRowView)this.bindingSource_0.Current)["isActive"])
				{
					this.toolStripButton_8.Text = "Деактивировать";
					return;
				}
				this.toolStripButton_8.Text = "Активировать";
			}
		}
	}

	private void Class5_Load(object sender, EventArgs e)
	{
		this.tabPage_1.Parent = null;
		this.tabPage_2.Parent = null;
	}

	private void toolStripButton_7_Click(object sender, EventArgs e)
	{
		if (this.bindingSource_0.Current == null)
		{
			return;
		}
		DataRowView dataRowView = (DataRowView)this.bindingSource_0.Current;
		int int_ = Convert.ToInt32(dataRowView["id"]);
		if (Convert.ToBoolean(dataRowView["deleted"]))
		{
			this.nKaUtmUfWS(int_, "set deleted = '0', isActive = '0'");
		}
		else
		{
			this.nKaUtmUfWS(int_, "set deleted = '1', isActive = '0'");
		}
		this.method_0(this.int_0);
	}

	private void toolStripButton_8_Click(object sender, EventArgs e)
	{
		if (this.bindingSource_0.Current == null)
		{
			return;
		}
		DataRowView dataRowView = (DataRowView)this.bindingSource_0.Current;
		int num = Convert.ToInt32(dataRowView["id"]);
		if (Convert.ToBoolean(dataRowView["deleted"]))
		{
			if (MessageBox.Show("Выбранный паспорт удален.\r\nХотите восстановить его для продолжения активации?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				return;
			}
			this.nKaUtmUfWS(num, "set deleted = '0', isActive = '0'");
		}
		if (Convert.ToBoolean(dataRowView["isActive"]))
		{
			this.nKaUtmUfWS(num, "set isActive = '0'");
		}
		else
		{
			if (new DataView(((DataSet)this.bindingSource_0.DataSource).Tables["tP_Passport"])
			{
				RowFilter = "isActive = true"
			}.Count > 0)
			{
				if (MessageBox.Show("Уже имеется действующий паспорт. При продолжении действия действующим станет выбранный паспорт.\r\nПродолжить?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
				{
					return;
				}
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
				DataTable dataTable = new DataTable("tP_Passport");
				string text = string.Format("where id != '{0}' and idObjList = '{1}' and deleted = '0'", num, this.int_0);
				sqlDataCommand.UpdateSqlData(dataTable, "set isActive = '0'", text);
			}
			this.nKaUtmUfWS(num, "set isActive = '1'");
		}
		this.method_0(this.int_0);
	}

	private void nKaUtmUfWS(int int_1, string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
		try
		{
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand();
			string commandText = "update tP_Passport " + string_0 + " where id = " + int_1.ToString();
			sqlCommand.CommandText = commandText;
			sqlCommand.Connection = sqlConnection;
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}
		catch
		{
			sqlConnection.Close();
		}
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Class5.fRa0bLLZU16S7oYIUKE(this, bool_0);
	}

	private void method_1()
	{
		this.icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class5));
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		this.tableLayoutPanel_0 = new TableLayoutPanel();
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.tableLayoutPanel_1 = new TableLayoutPanel();
		this.tabPage_1 = new TabPage();
		this.dataGridView_0 = new DataGridView();
		this.toolStrip_0 = new ToolStrip();
		this.toolStripSplitButton_0 = new ToolStripSplitButton();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripButton_2 = new ToolStripButton();
		this.toolStripButton_3 = new ToolStripButton();
		this.tabPage_2 = new TabPage();
		this.tableLayoutPanel_2 = new TableLayoutPanel();
		this.pictureBox_0 = new PictureBox();
		this.dataGridView_1 = new DataGridView();
		this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
		this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
		this.toolStrip_1 = new ToolStrip();
		this.toolStripButton_4 = new ToolStripButton();
		this.toolStripButton_5 = new ToolStripButton();
		this.toolStripButton_6 = new ToolStripButton();
		this.dataGridView_2 = new DataGridView();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.class107_0 = new Class107();
		this.toolStrip_2 = new ToolStrip();
		this.toolStripButton_7 = new ToolStripButton();
		this.toolStripButton_8 = new ToolStripButton();
		this.dataGridViewCheckBoxColumn_10 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_9 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_8 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_7 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_6 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_5 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_11 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
		this.cXyUrmtHsx = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
		this.dataGridViewPassport_0 = new DataGridViewPassport();
		this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_12 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_13 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_14 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
		this.tableLayoutPanel_0.SuspendLayout();
		this.tabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		this.tableLayoutPanel_1.SuspendLayout();
		this.tabPage_1.SuspendLayout();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		this.toolStrip_0.SuspendLayout();
		this.tabPage_2.SuspendLayout();
		this.tableLayoutPanel_2.SuspendLayout();
		((ISupportInitialize)this.pictureBox_0).BeginInit();
		((ISupportInitialize)this.dataGridView_1).BeginInit();
		this.toolStrip_1.SuspendLayout();
		((ISupportInitialize)this.dataGridView_2).BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.class107_0).BeginInit();
		this.toolStrip_2.SuspendLayout();
		((ISupportInitialize)this.dataGridViewPassport_0).BeginInit();
		base.SuspendLayout();
		this.tableLayoutPanel_0.ColumnCount = 2;
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229f));
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.Controls.Add(this.tabControl_0, 1, 0);
		this.tableLayoutPanel_0.Controls.Add(this.dataGridView_2, 0, 1);
		this.tableLayoutPanel_0.Controls.Add(this.toolStrip_2, 0, 0);
		this.tableLayoutPanel_0.Dock = DockStyle.Fill;
		this.tableLayoutPanel_0.Location = new Point(0, 0);
		this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
		this.tableLayoutPanel_0.RowCount = 2;
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 27f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		this.tableLayoutPanel_0.Size = new Size(746, 400);
		this.tableLayoutPanel_0.TabIndex = 0;
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Controls.Add(this.tabPage_2);
		this.tabControl_0.Dock = DockStyle.Fill;
		this.tabControl_0.Location = new Point(232, 3);
		this.tabControl_0.Name = "tcPassport";
		this.tableLayoutPanel_0.SetRowSpan(this.tabControl_0, 2);
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(511, 394);
		this.tabControl_0.TabIndex = 2;
		this.tabPage_0.Controls.Add(this.tableLayoutPanel_1);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "tpGeneral";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(503, 368);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Общие";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.tableLayoutPanel_1.ColumnCount = 1;
		this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_1.Controls.Add(this.dataGridViewPassport_0, 0, 0);
		this.tableLayoutPanel_1.Dock = DockStyle.Fill;
		this.tableLayoutPanel_1.Location = new Point(3, 3);
		this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
		this.tableLayoutPanel_1.RowCount = 1;
		this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 362f));
		this.tableLayoutPanel_1.Size = new Size(497, 362);
		this.tableLayoutPanel_1.TabIndex = 0;
		this.tabPage_1.Controls.Add(this.dataGridView_0);
		this.tabPage_1.Controls.Add(this.toolStrip_0);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "tpDocuments";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(503, 368);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Документы";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.dataGridView_0.BackgroundColor = Color.White;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Dock = DockStyle.Fill;
		this.dataGridView_0.GridColor = Color.White;
		this.dataGridView_0.Location = new Point(3, 3);
		this.dataGridView_0.Name = "dataGridView1";
		this.dataGridView_0.Size = new Size(497, 337);
		this.dataGridView_0.TabIndex = 3;
		this.toolStrip_0.Dock = DockStyle.Bottom;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripSplitButton_0,
			this.toolStripButton_0,
			this.toolStripButton_1,
			this.toolStripButton_2,
			this.toolStripButton_3
		});
		this.toolStrip_0.Location = new Point(3, 340);
		this.toolStrip_0.Name = "ObjDoctoolStrip";
		this.toolStrip_0.Size = new Size(497, 25);
		this.toolStrip_0.TabIndex = 2;
		this.toolStrip_0.Text = "Документы объекта";
		this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripSplitButton_0.Name = "tssbPasspDocAdd";
		this.toolStripSplitButton_0.Size = new Size(16, 22);
		this.toolStripSplitButton_0.Text = "Добавление";
		this.toolStripSplitButton_0.TextImageRelation = TextImageRelation.TextAboveImage;
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "tsbPasspDocEdit";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "Редактирование";
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "tsbPasspDocDel";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Удалить";
		this.toolStripButton_2.Alignment = ToolStripItemAlignment.Right;
		this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_2.Name = "tsbPasspDocPrint";
		this.toolStripButton_2.Size = new Size(23, 22);
		this.toolStripButton_2.Text = "Печать";
		this.toolStripButton_3.Alignment = ToolStripItemAlignment.Right;
		this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_3.Name = "tsbPasspDocInfo";
		this.toolStripButton_3.Size = new Size(23, 22);
		this.toolStripButton_3.Text = "Информация";
		this.tabPage_2.Controls.Add(this.tableLayoutPanel_2);
		this.tabPage_2.Controls.Add(this.toolStrip_1);
		this.tabPage_2.Location = new Point(4, 22);
		this.tabPage_2.Name = "tpImage";
		this.tabPage_2.Padding = new Padding(3);
		this.tabPage_2.Size = new Size(503, 368);
		this.tabPage_2.TabIndex = 2;
		this.tabPage_2.Text = "Изображение";
		this.tabPage_2.UseVisualStyleBackColor = true;
		this.tableLayoutPanel_2.ColumnCount = 2;
		this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.11475f));
		this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.88525f));
		this.tableLayoutPanel_2.Controls.Add(this.pictureBox_0, 1, 0);
		this.tableLayoutPanel_2.Controls.Add(this.dataGridView_1, 0, 0);
		this.tableLayoutPanel_2.Dock = DockStyle.Fill;
		this.tableLayoutPanel_2.Location = new Point(3, 28);
		this.tableLayoutPanel_2.Name = "tableLayoutPanel4";
		this.tableLayoutPanel_2.RowCount = 1;
		this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		this.tableLayoutPanel_2.Size = new Size(497, 337);
		this.tableLayoutPanel_2.TabIndex = 5;
		this.pictureBox_0.Dock = DockStyle.Fill;
		this.pictureBox_0.Location = new Point(68, 3);
		this.pictureBox_0.Name = "pbImage";
		this.pictureBox_0.Size = new Size(426, 331);
		this.pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
		this.pictureBox_0.TabIndex = 0;
		this.pictureBox_0.TabStop = false;
		this.dataGridView_1.AllowUserToAddRows = false;
		this.dataGridView_1.BackgroundColor = Color.White;
		this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_1.ColumnHeadersVisible = false;
		this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_0,
			this.dataGridViewTextBoxColumn_1,
			this.dataGridViewTextBoxColumn_2,
			this.dataGridViewTextBoxColumn_3,
			this.dataGridViewImageColumn_0,
			this.dataGridViewTextBoxColumn_4,
			this.dataGridViewTextBoxColumn_5,
			this.dataGridViewCheckBoxColumn_0
		});
		this.dataGridView_1.Dock = DockStyle.Fill;
		this.dataGridView_1.GridColor = Color.White;
		this.dataGridView_1.Location = new Point(3, 3);
		this.dataGridView_1.Name = "dgvImage";
		this.dataGridView_1.RowHeadersVisible = false;
		this.dataGridView_1.Size = new Size(59, 331);
		this.dataGridView_1.TabIndex = 1;
		this.dataGridViewImageColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewImageColumn_0.DataPropertyName = "Image";
		this.dataGridViewImageColumn_0.HeaderText = "Image";
		this.dataGridViewImageColumn_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
		this.dataGridViewImageColumn_0.Name = "Image";
		this.dataGridViewImageColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewImageColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
		this.dataGridViewCheckBoxColumn_0.HeaderText = "Compressed";
		this.dataGridViewCheckBoxColumn_0.Name = "Compressed";
		this.dataGridViewCheckBoxColumn_0.Visible = false;
		this.toolStrip_1.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_4,
			this.toolStripButton_5,
			this.toolStripButton_6
		});
		this.toolStrip_1.Location = new Point(3, 3);
		this.toolStrip_1.Name = "tsImage";
		this.toolStrip_1.Size = new Size(497, 25);
		this.toolStrip_1.TabIndex = 4;
		this.toolStrip_1.Text = "toolStrip1";
		this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_4.Image = Resources.smethod_41();
		this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_4.Name = "tsbImageAdd";
		this.toolStripButton_4.Size = new Size(23, 22);
		this.toolStripButton_4.Text = "Добавить изображение";
		this.toolStripButton_4.Click += this.toolStripButton_4_Click;
		this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_5.Image = Resources.smethod_42();
		this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_5.Name = "tsbImageDelete";
		this.toolStripButton_5.Size = new Size(23, 22);
		this.toolStripButton_5.Text = "Удалить";
		this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_6.Image = Resources.smethod_22();
		this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_6.Name = "tsbImageSettings";
		this.toolStripButton_6.Size = new Size(23, 22);
		this.toolStripButton_6.Text = "Настройки сжатия изображения";
		this.dataGridView_2.AllowUserToAddRows = false;
		this.dataGridView_2.AutoGenerateColumns = false;
		this.dataGridView_2.BackgroundColor = Color.White;
		this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_2.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_65,
			this.dataGridViewTextBoxColumn_66,
			this.dataGridViewTextBoxColumn_67,
			this.dataGridViewTextBoxColumn_68,
			this.dataGridViewTextBoxColumn_69,
			this.dataGridViewTextBoxColumn_70,
			this.dataGridViewCheckBoxColumn_13,
			this.dataGridViewCheckBoxColumn_14,
			this.dataGridViewTextBoxColumn_71,
			this.dataGridViewTextBoxColumn_72
		});
		this.dataGridView_2.DataSource = this.bindingSource_0;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = Color.White;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle.ForeColor = Color.Black;
		dataGridViewCellStyle.SelectionBackColor = Color.White;
		dataGridViewCellStyle.SelectionForeColor = Color.Blue;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
		this.dataGridView_2.DefaultCellStyle = dataGridViewCellStyle;
		this.dataGridView_2.Dock = DockStyle.Fill;
		this.dataGridView_2.Location = new Point(3, 30);
		this.dataGridView_2.MultiSelect = false;
		this.dataGridView_2.Name = "dgvPassports";
		this.dataGridView_2.ReadOnly = true;
		this.dataGridView_2.RowHeadersVisible = false;
		this.dataGridView_2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_2.Size = new Size(223, 367);
		this.dataGridView_2.TabIndex = 3;
		this.dataGridView_2.CellValueNeeded += this.dataGridView_2_CellValueNeeded;
		this.bindingSource_0.DataMember = "tP_Passport";
		this.bindingSource_0.DataSource = this.class107_0;
		this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
		this.class107_0.DataSetName = "dsPassport";
		this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.toolStrip_2.Dock = DockStyle.Fill;
		this.toolStrip_2.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_7,
			this.toolStripButton_8
		});
		this.toolStrip_2.Location = new Point(0, 0);
		this.toolStrip_2.Name = "tsPassport";
		this.toolStrip_2.Size = new Size(229, 27);
		this.toolStrip_2.TabIndex = 4;
		this.toolStrip_2.Text = "toolStrip1";
		this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_7.Image = Resources.smethod_58();
		this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_7.Name = "tsBtnDelPassp";
		this.toolStripButton_7.Size = new Size(23, 24);
		this.toolStripButton_7.Text = "Удалить";
		this.toolStripButton_7.Click += this.toolStripButton_7_Click;
		this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_8.Image = (Image)componentResourceManager.GetObject("tsBtnActivePassp.Image");
		this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_8.Name = "tsBtnActivePassp";
		this.toolStripButton_8.Size = new Size(23, 24);
		this.toolStripButton_8.Text = "Активировать";
		this.toolStripButton_8.Click += this.toolStripButton_8_Click;
		this.dataGridViewCheckBoxColumn_10.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_10.Name = "dataGridViewCheckBoxColumn10";
		this.dataGridViewCheckBoxColumn_10.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_10.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_10.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_10.Visible = false;
		this.dataGridViewCheckBoxColumn_9.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_9.Name = "dataGridViewCheckBoxColumn9";
		this.dataGridViewCheckBoxColumn_9.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_9.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_9.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_9.Visible = false;
		this.dataGridViewCheckBoxColumn_8.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_8.Name = "dataGridViewCheckBoxColumn8";
		this.dataGridViewCheckBoxColumn_8.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_8.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_8.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_8.Visible = false;
		this.dataGridViewCheckBoxColumn_7.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_7.Name = "dataGridViewCheckBoxColumn7";
		this.dataGridViewCheckBoxColumn_7.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_7.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_7.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_7.Visible = false;
		this.dataGridViewCheckBoxColumn_6.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_6.Name = "dataGridViewCheckBoxColumn6";
		this.dataGridViewCheckBoxColumn_6.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_6.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_6.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_6.Visible = false;
		this.dataGridViewCheckBoxColumn_5.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_5.Name = "dataGridViewCheckBoxColumn5";
		this.dataGridViewCheckBoxColumn_5.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_5.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_5.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_5.Visible = false;
		this.dataGridViewCheckBoxColumn_4.HeaderText = "IsGroupChar";
		this.dataGridViewCheckBoxColumn_4.Name = "dataGridViewCheckBoxColumn4";
		this.dataGridViewCheckBoxColumn_4.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_4.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_4.Visible = false;
		this.dataGridViewCheckBoxColumn_3.HeaderText = "IsGroupChar";
		this.dataGridViewCheckBoxColumn_3.Name = "dataGridViewCheckBoxColumn3";
		this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_3.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_3.Visible = false;
		this.dataGridViewCheckBoxColumn_2.HeaderText = "IsGroupChar";
		this.dataGridViewCheckBoxColumn_2.Name = "dataGridViewCheckBoxColumn2";
		this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_2.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_2.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_2.Visible = false;
		this.dataGridViewCheckBoxColumn_1.HeaderText = "IsGroupChar";
		this.dataGridViewCheckBoxColumn_1.Name = "dataGridViewCheckBoxColumn1";
		this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_1.Visible = false;
		this.dataGridViewCheckBoxColumn_11.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_11.Name = "dataGridViewCheckBoxColumn11";
		this.dataGridViewCheckBoxColumn_11.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_11.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_11.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_11.Visible = false;
		this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_6.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_6.Visible = false;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "idPasspDoc";
		this.dataGridViewTextBoxColumn_7.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn2";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_7.Visible = false;
		this.dataGridViewTextBoxColumn_8.DataPropertyName = "DateIn";
		this.dataGridViewTextBoxColumn_8.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn_8.ReadOnly = true;
		this.dataGridViewTextBoxColumn_8.Visible = false;
		this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_9.DataPropertyName = "FileName";
		this.dataGridViewTextBoxColumn_9.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_9.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn4";
		this.dataGridViewTextBoxColumn_9.ReadOnly = true;
		this.dataGridViewTextBoxColumn_9.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_9.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_9.Visible = false;
		this.cXyUrmtHsx.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.cXyUrmtHsx.DataPropertyName = "isActive";
		this.cXyUrmtHsx.HeaderText = "Значение";
		this.cXyUrmtHsx.Name = "dataGridViewTextBoxColumn5";
		this.cXyUrmtHsx.ReadOnly = true;
		this.cXyUrmtHsx.Resizable = DataGridViewTriState.True;
		this.cXyUrmtHsx.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.cXyUrmtHsx.Visible = false;
		this.dataGridViewTextBoxColumn_10.DataPropertyName = "Deleted";
		this.dataGridViewTextBoxColumn_10.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn6";
		this.dataGridViewTextBoxColumn_10.ReadOnly = true;
		this.dataGridViewTextBoxColumn_10.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_10.Visible = false;
		this.dataGridViewTextBoxColumn_11.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_11.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn7";
		this.dataGridViewTextBoxColumn_11.ReadOnly = true;
		this.dataGridViewTextBoxColumn_11.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_11.Visible = false;
		this.dataGridViewTextBoxColumn_12.DataPropertyName = "ParentId";
		this.dataGridViewTextBoxColumn_12.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn8";
		this.dataGridViewTextBoxColumn_12.ReadOnly = true;
		this.dataGridViewTextBoxColumn_12.Visible = false;
		this.dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_13.DataPropertyName = "idObjList";
		this.dataGridViewTextBoxColumn_13.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_13.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn9";
		this.dataGridViewTextBoxColumn_13.ReadOnly = true;
		this.dataGridViewTextBoxColumn_13.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_13.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_13.Visible = false;
		this.dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_14.DataPropertyName = "idEquipment";
		this.dataGridViewTextBoxColumn_14.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn10";
		this.dataGridViewTextBoxColumn_14.ReadOnly = true;
		this.dataGridViewTextBoxColumn_14.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_14.Visible = false;
		this.dataGridViewTextBoxColumn_15.DataPropertyName = "Number";
		this.dataGridViewTextBoxColumn_15.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn11";
		this.dataGridViewTextBoxColumn_15.ReadOnly = true;
		this.dataGridViewTextBoxColumn_15.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_15.Visible = false;
		this.dataGridViewTextBoxColumn_16.DataPropertyName = "Date";
		this.dataGridViewTextBoxColumn_16.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn12";
		this.dataGridViewTextBoxColumn_16.ReadOnly = true;
		this.dataGridViewTextBoxColumn_16.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_16.Visible = false;
		this.dataGridViewTextBoxColumn_17.DataPropertyName = "DateIn";
		this.dataGridViewTextBoxColumn_17.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn13";
		this.dataGridViewTextBoxColumn_17.ReadOnly = true;
		this.dataGridViewTextBoxColumn_17.Visible = false;
		this.dataGridViewTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_18.DataPropertyName = "idOldPassport";
		this.dataGridViewTextBoxColumn_18.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_18.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn14";
		this.dataGridViewTextBoxColumn_18.ReadOnly = true;
		this.dataGridViewTextBoxColumn_18.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_18.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_18.Visible = false;
		this.dataGridViewPassport_0.AllowUserToAddRows = false;
		this.dataGridViewPassport_0.AllowUserToDeleteRows = false;
		this.dataGridViewPassport_0.AllowUserToResizeColumns = false;
		this.dataGridViewPassport_0.AllowUserToResizeRows = false;
		this.dataGridViewPassport_0.BackgroundColor = Color.White;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = SystemColors.Control;
		dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		this.dataGridViewPassport_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridViewPassport_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = Color.White;
		dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = Color.White;
		dataGridViewCellStyle3.SelectionForeColor = Color.Blue;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
		this.dataGridViewPassport_0.DefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridViewPassport_0.Dock = DockStyle.Fill;
		this.dataGridViewPassport_0.DragDropComplite = false;
		this.dataGridViewPassport_0.EditMode = DataGridViewEditMode.EditProgrammatically;
		this.dataGridViewPassport_0.Location = new Point(3, 3);
		this.dataGridViewPassport_0.MultiSelect = false;
		this.dataGridViewPassport_0.Name = "DataGridViewPassport1";
		this.dataGridViewPassport_0.ReadOnly = true;
		this.dataGridViewPassport_0.RowHeadersVisible = false;
		this.dataGridViewPassport_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewPassport_0.Size = new Size(491, 356);
		this.dataGridViewPassport_0.TabIndex = 0;
		this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_19.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn15";
		this.dataGridViewTextBoxColumn_19.ReadOnly = true;
		this.dataGridViewTextBoxColumn_19.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_19.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_19.Visible = false;
		this.dataGridViewTextBoxColumn_20.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn16";
		this.dataGridViewTextBoxColumn_20.ReadOnly = true;
		this.dataGridViewTextBoxColumn_20.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_20.Visible = false;
		this.dataGridViewTextBoxColumn_21.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn17";
		this.dataGridViewTextBoxColumn_21.ReadOnly = true;
		this.dataGridViewTextBoxColumn_21.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_21.Visible = false;
		this.dataGridViewCheckBoxColumn_12.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_12.Name = "dataGridViewCheckBoxColumn12";
		this.dataGridViewCheckBoxColumn_12.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_12.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_12.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_12.Visible = false;
		this.dataGridViewTextBoxColumn_22.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_22.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_22.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn18";
		this.dataGridViewTextBoxColumn_22.ReadOnly = true;
		this.dataGridViewTextBoxColumn_22.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_22.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_22.Visible = false;
		this.dataGridViewTextBoxColumn_23.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_23.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_23.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn19";
		this.dataGridViewTextBoxColumn_23.ReadOnly = true;
		this.dataGridViewTextBoxColumn_23.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_23.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_0.HeaderText = "idImage";
		this.dataGridViewTextBoxColumn_0.Name = "idImage";
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "idPasspDoc";
		this.dataGridViewTextBoxColumn_1.HeaderText = "idPasspDocImage";
		this.dataGridViewTextBoxColumn_1.Name = "idPasspDocImage";
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.dataGridViewTextBoxColumn_2.DataPropertyName = "DateIn";
		this.dataGridViewTextBoxColumn_2.HeaderText = "DateInImage";
		this.dataGridViewTextBoxColumn_2.Name = "DateInImage";
		this.dataGridViewTextBoxColumn_2.Visible = false;
		this.dataGridViewTextBoxColumn_3.DataPropertyName = "FileName";
		this.dataGridViewTextBoxColumn_3.HeaderText = "FileNameImage";
		this.dataGridViewTextBoxColumn_3.Name = "FileNameImage";
		this.dataGridViewTextBoxColumn_3.Visible = false;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "isActive";
		this.dataGridViewTextBoxColumn_4.HeaderText = "isActiveImage";
		this.dataGridViewTextBoxColumn_4.Name = "isActiveImage";
		this.dataGridViewTextBoxColumn_4.Visible = false;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "Deleted";
		this.dataGridViewTextBoxColumn_5.HeaderText = "DeletedImage";
		this.dataGridViewTextBoxColumn_5.Name = "DeletedImage";
		this.dataGridViewTextBoxColumn_5.Visible = false;
		this.dataGridViewTextBoxColumn_60.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn56";
		this.dataGridViewTextBoxColumn_60.ReadOnly = true;
		this.dataGridViewTextBoxColumn_60.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_60.Visible = false;
		this.dataGridViewTextBoxColumn_61.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn57";
		this.dataGridViewTextBoxColumn_61.ReadOnly = true;
		this.dataGridViewTextBoxColumn_61.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_61.Visible = false;
		this.dataGridViewTextBoxColumn_62.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn58";
		this.dataGridViewTextBoxColumn_62.ReadOnly = true;
		this.dataGridViewTextBoxColumn_62.Visible = false;
		this.dataGridViewTextBoxColumn_63.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_63.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_63.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn59";
		this.dataGridViewTextBoxColumn_63.ReadOnly = true;
		this.dataGridViewTextBoxColumn_63.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_63.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_64.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_64.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn60";
		this.dataGridViewTextBoxColumn_64.ReadOnly = true;
		this.dataGridViewTextBoxColumn_64.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_64.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_55.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn51";
		this.dataGridViewTextBoxColumn_55.ReadOnly = true;
		this.dataGridViewTextBoxColumn_55.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_55.Visible = false;
		this.dataGridViewTextBoxColumn_56.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn52";
		this.dataGridViewTextBoxColumn_56.ReadOnly = true;
		this.dataGridViewTextBoxColumn_56.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_56.Visible = false;
		this.dataGridViewTextBoxColumn_57.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn53";
		this.dataGridViewTextBoxColumn_57.ReadOnly = true;
		this.dataGridViewTextBoxColumn_57.Visible = false;
		this.dataGridViewTextBoxColumn_58.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_58.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_58.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn54";
		this.dataGridViewTextBoxColumn_58.ReadOnly = true;
		this.dataGridViewTextBoxColumn_58.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_58.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_59.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_59.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn55";
		this.dataGridViewTextBoxColumn_59.ReadOnly = true;
		this.dataGridViewTextBoxColumn_59.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_59.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_50.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn46";
		this.dataGridViewTextBoxColumn_50.ReadOnly = true;
		this.dataGridViewTextBoxColumn_50.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_50.Visible = false;
		this.dataGridViewTextBoxColumn_51.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn47";
		this.dataGridViewTextBoxColumn_51.ReadOnly = true;
		this.dataGridViewTextBoxColumn_51.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_51.Visible = false;
		this.dataGridViewTextBoxColumn_52.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_52.Name = "dataGridViewTextBoxColumn48";
		this.dataGridViewTextBoxColumn_52.ReadOnly = true;
		this.dataGridViewTextBoxColumn_52.Visible = false;
		this.dataGridViewTextBoxColumn_53.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_53.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_53.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn49";
		this.dataGridViewTextBoxColumn_53.ReadOnly = true;
		this.dataGridViewTextBoxColumn_53.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_53.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_54.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_54.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn50";
		this.dataGridViewTextBoxColumn_54.ReadOnly = true;
		this.dataGridViewTextBoxColumn_54.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_54.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_45.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_45.Name = "dataGridViewTextBoxColumn41";
		this.dataGridViewTextBoxColumn_45.ReadOnly = true;
		this.dataGridViewTextBoxColumn_45.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_45.Visible = false;
		this.dataGridViewTextBoxColumn_46.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn42";
		this.dataGridViewTextBoxColumn_46.ReadOnly = true;
		this.dataGridViewTextBoxColumn_46.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_46.Visible = false;
		this.dataGridViewTextBoxColumn_47.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn43";
		this.dataGridViewTextBoxColumn_47.ReadOnly = true;
		this.dataGridViewTextBoxColumn_47.Visible = false;
		this.dataGridViewTextBoxColumn_48.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_48.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_48.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn44";
		this.dataGridViewTextBoxColumn_48.ReadOnly = true;
		this.dataGridViewTextBoxColumn_48.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_48.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_49.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_49.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn45";
		this.dataGridViewTextBoxColumn_49.ReadOnly = true;
		this.dataGridViewTextBoxColumn_49.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_49.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_40.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_40.Name = "dataGridViewTextBoxColumn36";
		this.dataGridViewTextBoxColumn_40.ReadOnly = true;
		this.dataGridViewTextBoxColumn_40.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_40.Visible = false;
		this.dataGridViewTextBoxColumn_41.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_41.Name = "dataGridViewTextBoxColumn37";
		this.dataGridViewTextBoxColumn_41.ReadOnly = true;
		this.dataGridViewTextBoxColumn_41.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_41.Visible = false;
		this.dataGridViewTextBoxColumn_42.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_42.Name = "dataGridViewTextBoxColumn38";
		this.dataGridViewTextBoxColumn_42.ReadOnly = true;
		this.dataGridViewTextBoxColumn_42.Visible = false;
		this.dataGridViewTextBoxColumn_43.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_43.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_43.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_43.Name = "dataGridViewTextBoxColumn39";
		this.dataGridViewTextBoxColumn_43.ReadOnly = true;
		this.dataGridViewTextBoxColumn_43.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_43.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_44.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_44.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_44.Name = "dataGridViewTextBoxColumn40";
		this.dataGridViewTextBoxColumn_44.ReadOnly = true;
		this.dataGridViewTextBoxColumn_44.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_44.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_35.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn31";
		this.dataGridViewTextBoxColumn_35.ReadOnly = true;
		this.dataGridViewTextBoxColumn_35.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_35.Visible = false;
		this.dataGridViewTextBoxColumn_36.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn32";
		this.dataGridViewTextBoxColumn_36.ReadOnly = true;
		this.dataGridViewTextBoxColumn_36.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_36.Visible = false;
		this.dataGridViewTextBoxColumn_37.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn33";
		this.dataGridViewTextBoxColumn_37.ReadOnly = true;
		this.dataGridViewTextBoxColumn_37.Visible = false;
		this.dataGridViewTextBoxColumn_38.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_38.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_38.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn34";
		this.dataGridViewTextBoxColumn_38.ReadOnly = true;
		this.dataGridViewTextBoxColumn_38.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_38.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_39.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_39.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn35";
		this.dataGridViewTextBoxColumn_39.ReadOnly = true;
		this.dataGridViewTextBoxColumn_39.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_39.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_30.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn26";
		this.dataGridViewTextBoxColumn_30.ReadOnly = true;
		this.dataGridViewTextBoxColumn_30.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_30.Visible = false;
		this.dataGridViewTextBoxColumn_31.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn27";
		this.dataGridViewTextBoxColumn_31.ReadOnly = true;
		this.dataGridViewTextBoxColumn_31.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_31.Visible = false;
		this.dataGridViewTextBoxColumn_32.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn28";
		this.dataGridViewTextBoxColumn_32.ReadOnly = true;
		this.dataGridViewTextBoxColumn_32.Visible = false;
		this.dataGridViewTextBoxColumn_33.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_33.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_33.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn29";
		this.dataGridViewTextBoxColumn_33.ReadOnly = true;
		this.dataGridViewTextBoxColumn_33.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_33.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_34.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_34.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn30";
		this.dataGridViewTextBoxColumn_34.ReadOnly = true;
		this.dataGridViewTextBoxColumn_34.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_34.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_25.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn21";
		this.dataGridViewTextBoxColumn_25.ReadOnly = true;
		this.dataGridViewTextBoxColumn_25.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_25.Visible = false;
		this.dataGridViewTextBoxColumn_26.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn22";
		this.dataGridViewTextBoxColumn_26.ReadOnly = true;
		this.dataGridViewTextBoxColumn_26.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_26.Visible = false;
		this.dataGridViewTextBoxColumn_27.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn23";
		this.dataGridViewTextBoxColumn_27.ReadOnly = true;
		this.dataGridViewTextBoxColumn_27.Visible = false;
		this.dataGridViewTextBoxColumn_28.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_28.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_28.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn24";
		this.dataGridViewTextBoxColumn_28.ReadOnly = true;
		this.dataGridViewTextBoxColumn_28.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_28.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_29.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_29.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn25";
		this.dataGridViewTextBoxColumn_29.ReadOnly = true;
		this.dataGridViewTextBoxColumn_29.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_29.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_24.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_24.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn20";
		this.dataGridViewTextBoxColumn_24.ReadOnly = true;
		this.dataGridViewTextBoxColumn_24.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_24.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_65.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_65.HeaderText = "id";
		this.dataGridViewTextBoxColumn_65.Name = "idDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_65.ReadOnly = true;
		this.dataGridViewTextBoxColumn_65.Visible = false;
		this.dataGridViewTextBoxColumn_66.DataPropertyName = "ParentId";
		this.dataGridViewTextBoxColumn_66.HeaderText = "ParentId";
		this.dataGridViewTextBoxColumn_66.Name = "parentIdDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_66.ReadOnly = true;
		this.dataGridViewTextBoxColumn_66.Visible = false;
		this.dataGridViewTextBoxColumn_67.DataPropertyName = "idObjList";
		this.dataGridViewTextBoxColumn_67.HeaderText = "idObjList";
		this.dataGridViewTextBoxColumn_67.Name = "idObjListDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_67.ReadOnly = true;
		this.dataGridViewTextBoxColumn_67.Visible = false;
		this.dataGridViewTextBoxColumn_68.DataPropertyName = "idEquipment";
		this.dataGridViewTextBoxColumn_68.HeaderText = "idEquipment";
		this.dataGridViewTextBoxColumn_68.Name = "idEquipmentDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_68.ReadOnly = true;
		this.dataGridViewTextBoxColumn_68.Visible = false;
		this.dataGridViewTextBoxColumn_69.DataPropertyName = "Number";
		this.dataGridViewTextBoxColumn_69.HeaderText = "Number";
		this.dataGridViewTextBoxColumn_69.Name = "numberDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_69.ReadOnly = true;
		this.dataGridViewTextBoxColumn_69.Visible = false;
		this.dataGridViewTextBoxColumn_70.DataPropertyName = "Date";
		this.dataGridViewTextBoxColumn_70.HeaderText = "Дата";
		this.dataGridViewTextBoxColumn_70.Name = "dateDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_70.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_13.DataPropertyName = "Deleted";
		this.dataGridViewCheckBoxColumn_13.HeaderText = "Удален";
		this.dataGridViewCheckBoxColumn_13.Name = "deletedDataGridViewCheckBoxColumn";
		this.dataGridViewCheckBoxColumn_13.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_13.Width = 60;
		this.dataGridViewCheckBoxColumn_14.DataPropertyName = "isActive";
		this.dataGridViewCheckBoxColumn_14.HeaderText = "Активен";
		this.dataGridViewCheckBoxColumn_14.Name = "isActiveDataGridViewCheckBoxColumn";
		this.dataGridViewCheckBoxColumn_14.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_14.Width = 60;
		this.dataGridViewTextBoxColumn_71.DataPropertyName = "DateIn";
		this.dataGridViewTextBoxColumn_71.HeaderText = "DateIn";
		this.dataGridViewTextBoxColumn_71.Name = "dateInDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_71.ReadOnly = true;
		this.dataGridViewTextBoxColumn_71.Visible = false;
		this.dataGridViewTextBoxColumn_72.DataPropertyName = "idOldPassport";
		this.dataGridViewTextBoxColumn_72.HeaderText = "idOldPassport";
		this.dataGridViewTextBoxColumn_72.Name = "idOldPassportDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_72.ReadOnly = true;
		this.dataGridViewTextBoxColumn_72.Visible = false;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(746, 400);
		base.Controls.Add(this.tableLayoutPanel_0);
		this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "FormPassportHistory";
		this.Text = "История паспортов объекта";
		base.Load += this.Class5_Load;
		this.tableLayoutPanel_0.ResumeLayout(false);
		this.tableLayoutPanel_0.PerformLayout();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.tableLayoutPanel_1.ResumeLayout(false);
		this.tabPage_1.ResumeLayout(false);
		this.tabPage_1.PerformLayout();
		((ISupportInitialize)this.dataGridView_0).EndInit();
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		this.tabPage_2.ResumeLayout(false);
		this.tabPage_2.PerformLayout();
		this.tableLayoutPanel_2.ResumeLayout(false);
		((ISupportInitialize)this.pictureBox_0).EndInit();
		((ISupportInitialize)this.dataGridView_1).EndInit();
		this.toolStrip_1.ResumeLayout(false);
		this.toolStrip_1.PerformLayout();
		((ISupportInitialize)this.dataGridView_2).EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.class107_0).EndInit();
		this.toolStrip_2.ResumeLayout(false);
		this.toolStrip_2.PerformLayout();
		((ISupportInitialize)this.dataGridViewPassport_0).EndInit();
		base.ResumeLayout(false);
	}

	internal static void fRa0bLLZU16S7oYIUKE(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private int int_0;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private TabPage tabPage_1;

	private DataGridView dataGridView_0;

	private ToolStrip toolStrip_0;

	private ToolStripSplitButton toolStripSplitButton_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ToolStripButton toolStripButton_3;

	private TabPage tabPage_2;

	private TableLayoutPanel tableLayoutPanel_2;

	private PictureBox pictureBox_0;

	private DataGridView dataGridView_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewImageColumn dataGridViewImageColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

	private ToolStrip toolStrip_1;

	private ToolStripButton toolStripButton_4;

	private ToolStripButton toolStripButton_5;

	private ToolStripButton toolStripButton_6;

	private DataGridView dataGridView_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

	private DataGridViewTextBoxColumn cXyUrmtHsx;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

	private Class107 class107_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

	private DataGridViewPassport dataGridViewPassport_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

	private BindingSource bindingSource_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

	private ToolStrip toolStrip_2;

	private ToolStripButton toolStripButton_7;

	private ToolStripButton toolStripButton_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_13;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;
}
