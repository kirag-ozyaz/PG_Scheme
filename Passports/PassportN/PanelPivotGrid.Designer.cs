using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using Passport.Classes;

internal class PanelPivotGrid : UserControl
{
	internal PanelPivotGrid()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.iuVaajuavsm();
	}

	internal PanelPivotGrid(SQLSettings sqlsettings_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.iuVaajuavsm();
		this.sqlsettings_0 = sqlsettings_1;
		this.sqlDataCommand_0 = new SqlDataCommand(sqlsettings_1);
	}

	[DefaultValue(true)]
	[Description("Задает или получает состояние отображения кнопки \"История\" и прилегающего к ней сепаратора")]
	[Category("Behavior")]
	[Browsable(true)]
	internal bool Boolean_0
	{
		get
		{
			return this.tsbHistoryData.Visible;
		}
		set
		{
			this.tsbHistoryData.Visible = value;
			this.tssHistoryData.Visible = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Задает или получает состояние отображения кнопки \"Обновить\" и прилегающего к ней сепаратора")]
	[Browsable(true)]
	internal bool Boolean_1
	{
		get
		{
			return this.tsbRefreshData.Visible;
		}
		set
		{
			this.tsbRefreshData.Visible = value;
			this.tssRefreshData.Visible = value;
		}
	}

	[Description("Задает или получает объект класса SQLSettings.")]
	[Category("Behavior")]
	[Browsable(false)]
	internal SQLSettings SQLSettings_0
	{
		get
		{
			return this.sqlsettings_0;
		}
		set
		{
			this.sqlsettings_0 = value;
			this.sqlDataCommand_0 = new SqlDataCommand(this.sqlsettings_0);
		}
	}

	[DefaultValue("")]
	[Browsable(true)]
	[Description("Задает или получает текст в правом углу меню")]
	[Category("Behavior")]
	internal new string Text
	{
		get
		{
			return this.tslText.Text;
		}
		set
		{
			this.tslText.Text = value;
		}
	}

	[Description("Скрывает указанные колонки")]
	internal void method_0(string[] string_0)
	{
		foreach (string b in string_0)
		{
			foreach (object obj in this.dgvGeneral.Columns)
			{
				DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
				if (dataGridViewColumn.Name == b)
				{
					dataGridViewColumn.Visible = false;
					break;
				}
			}
		}
	}

	[Description("Загружает данные в DataGridView")]
	internal void method_1(int int_0)
	{
		string string_ = string.Format("where idObjList in (select id from tSchm_ObjList where TypeCodeId = {0} and idParentAddl = {1}) and isActive = ((1)) and Deleted = ((0))", 556, int_0);
		this.method_9(string_);
	}

	[Description("Загружает данные в DataGridView")]
	internal void method_2(int int_0)
	{
		string str = string.Format("SELECT sw.Id FROM tSchm_ObjList AS sw LEFT JOIN tR_Classifier AS c ON sw.TypeCodeId = c.id WHERE c.ParentKey LIKE ';SCM;SwGear;%' AND sw.Deleted = ((0)) AND sw.IdParent = {0}", int_0);
		string string_ = string.Format("where idObjList in (" + str + ") and isActive = ((1)) and Deleted = ((0))", 556, int_0);
		this.method_9(string_);
	}

	[Description("Загружает данные паспортов шин в DataGridView.")]
	internal void method_3(string[] string_0)
	{
		string string_ = "where idObjList in (" + string.Join(", ", string_0) + ") and isActive = ((1)) and Deleted = ((0))";
		this.method_9(string_);
	}

	[Description("Загружает данные паспортов шин в DataGridView.")]
	internal void method_4(int int_0)
	{
		string str = string.Format("SELECT bus.Id FROM tSchm_ObjList AS ru INNER JOIN tR_Classifier AS c_ru ON ru.TypeCodeId = c_ru.Id INNER JOIN tR_Classifier AS c_bus ON c_ru.Value = c_bus.Value INNER JOIN tSchm_ObjList AS bus ON c_bus.Id = bus.TypeCodeId AND ru.IdParent = bus.IdParent WHERE c_ru.ParentKey LIKE ';SCM;SwGear;%' AND c_bus.ParentKey LIKE ';SCM;BUS;%' AND ru.id = {0}", int_0);
		string string_ = "where idObjList in (" + str + ") and isActive = ((1)) and Deleted = ((0))";
		this.method_9(string_);
	}

	[Description("Загружает данные паспортов ячеек в DataGridView.")]
	internal void method_5(string[] string_0)
	{
		string string_ = "where idObjList in (" + string.Join(", ", string_0) + ") and isActive = ((1)) and Deleted = ((0))";
		this.method_9(string_);
	}

	[Description("Загружает данные паспортов ячеек в DataGridView.")]
	internal void method_6(int int_0)
	{
		string str = string.Format("SELECT cells.Id FROM tSchm_ObjList AS bus JOIN tR_Classifier AS c_bus ON bus.TypeCodeId = c_bus.id JOIN tSchm_ObjList AS point ON bus.id = point.IdParent JOIN tSchm_Relation AS rel ON point.id =  rel.SourceObj or point.id = rel.DestObj JOIN tSchm_ObjList AS cells ON rel.Edge = cells.id JOIN tR_Classifier AS c_cells ON cells.TypeCodeId = c_cells.id WHERE cells.Id != bus.Id AND bus.IdRuParent = {0} AND c_bus.ParentKey LIKE ';SCM;BUS;%' AND c_cells.ParentKey LIKE ';SCM;Cell;%' AND bus.Deleted = ((0)) AND point.Deleted = ((0)) AND cells.Deleted = ((0))", int_0);
		string string_ = "where idObjList in (" + str + ") and isActive = ((1)) and Deleted = ((0))";
		this.method_9(string_);
	}

	[Description("Загружает данные паспортов коммутационных устройст в DataGridView.")]
	internal void method_7(string[] string_0)
	{
		string string_ = "where idObjList in (" + string.Join(", ", string_0) + ") and isActive = ((1)) and Deleted = ((0))";
		this.method_9(string_);
	}

	[Description("Загружает данные паспортов коммутационных устройст в DataGridView.")]
	internal void method_8(int int_0)
	{
		string str = string.Format("SELECT o.id FROM tSchm_ObjList AS o JOIN tSchm_Relation AS rel ON o.IdParent = rel.id JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id JOIN tSchm_ObjList AS cell ON rel.Edge = cell.Id WHERE o.Deleted = ((0)) AND o.TypeCodeId != 556 AND cell.IdParent = {0}", int_0);
		string string_ = "where idObjList in (" + str + ") and isActive = ((1)) and Deleted = ((0))";
		this.method_9(string_);
	}

	[Description("Загружает данные в DataGridView")]
	internal void method_9(string string_0)
	{
		this.sqlDataCommand_0.SelectSqlData(this.class313_0.vPassportShowData, true, string_0, null, false, 0);
		DataTable inversedDataTable = PivotTable.GetInversedDataTable(this.class313_0.vPassportShowData, this.class313_0.vPassportShowData.DataColumn_5.ColumnName, this.class313_0.vPassportShowData.DataColumn_0.ColumnName, this.class313_0.vPassportShowData.DataColumn_6.ColumnName, "", false);
		this.dgvGeneral.DataSource = inversedDataTable;
	}

	private void tsbAddData_Click(object sender, EventArgs e)
	{
	}

	private void tsbEditData_Click(object sender, EventArgs e)
	{
	}

	private void WnsaaPcnVo8_Click(object sender, EventArgs e)
	{
	}

	private void tsbHistoryData_Click(object sender, EventArgs e)
	{
	}

	private void tsbRefreshData_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.RjhaaDbyOr1 != null)
		{
			this.RjhaaDbyOr1.Dispose();
		}
		base.Dispose(disposing);
	}

	private void iuVaajuavsm()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PanelPivotGrid));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		this.tlpGeneral = new TableLayoutPanel();
		this.tsGeneral = new ToolStrip();
		this.tsbAddData = new ToolStripButton();
		this.tsbEditData = new ToolStripButton();
		this.WnsaaPcnVo8 = new ToolStripButton();
		this.tssHistoryData = new ToolStripSeparator();
		this.tsbHistoryData = new ToolStripButton();
		this.tssRefreshData = new ToolStripSeparator();
		this.tsbRefreshData = new ToolStripButton();
		this.tslText = new ToolStripLabel();
		this.dgvGeneral = new DataGridView();
		this.class313_0 = new Class313();
		this.id = new DataGridViewTextBoxColumn();
		this.Naim = new DataGridViewTextBoxColumn();
		this.ParentId = new DataGridViewTextBoxColumn();
		this.tlpGeneral.SuspendLayout();
		this.tsGeneral.SuspendLayout();
		((ISupportInitialize)this.dgvGeneral).BeginInit();
		((ISupportInitialize)this.class313_0).BeginInit();
		base.SuspendLayout();
		this.tlpGeneral.ColumnCount = 1;
		this.tlpGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.tlpGeneral.Controls.Add(this.tsGeneral, 0, 0);
		this.tlpGeneral.Controls.Add(this.dgvGeneral, 0, 1);
		this.tlpGeneral.Dock = DockStyle.Fill;
		this.tlpGeneral.Location = new Point(0, 0);
		this.tlpGeneral.Name = "tlpGeneral";
		this.tlpGeneral.RowCount = 2;
		this.tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
		this.tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		this.tlpGeneral.Size = new Size(411, 147);
		this.tlpGeneral.TabIndex = 3;
		this.tsGeneral.BackColor = Color.White;
		this.tsGeneral.Items.AddRange(new ToolStripItem[]
		{
			this.tsbAddData,
			this.tsbEditData,
			this.WnsaaPcnVo8,
			this.tssHistoryData,
			this.tsbHistoryData,
			this.tssRefreshData,
			this.tsbRefreshData,
			this.tslText
		});
		this.tsGeneral.Location = new Point(0, 0);
		this.tsGeneral.Name = "tsGeneral";
		this.tsGeneral.Size = new Size(411, 24);
		this.tsGeneral.TabIndex = 8;
		this.tsGeneral.Text = "toolStrip1";
		this.tsbAddData.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.tsbAddData.Image = (Image)componentResourceManager.GetObject("tsbAddData.Image");
		this.tsbAddData.ImageTransparentColor = Color.Transparent;
		this.tsbAddData.Name = "tsbAddData";
		this.tsbAddData.Size = new Size(23, 21);
		this.tsbAddData.Text = "Добавить паспорт";
		this.tsbAddData.Click += this.tsbAddData_Click;
		this.tsbEditData.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.tsbEditData.Image = (Image)componentResourceManager.GetObject("tsbEditData.Image");
		this.tsbEditData.ImageTransparentColor = Color.Transparent;
		this.tsbEditData.Name = "tsbEditData";
		this.tsbEditData.Size = new Size(23, 21);
		this.tsbEditData.Text = "Изменить паспорт";
		this.tsbEditData.Click += this.tsbEditData_Click;
		this.WnsaaPcnVo8.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.WnsaaPcnVo8.Image = (Image)componentResourceManager.GetObject("tsbDeleteData.Image");
		this.WnsaaPcnVo8.ImageTransparentColor = Color.Transparent;
		this.WnsaaPcnVo8.Name = "tsbDeleteData";
		this.WnsaaPcnVo8.Size = new Size(23, 21);
		this.WnsaaPcnVo8.Text = "Удалить паспорт";
		this.WnsaaPcnVo8.Click += this.WnsaaPcnVo8_Click;
		this.tssHistoryData.Name = "tssHistoryData";
		this.tssHistoryData.Size = new Size(6, 24);
		this.tsbHistoryData.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.tsbHistoryData.Image = (Image)componentResourceManager.GetObject("tsbHistoryData.Image");
		this.tsbHistoryData.ImageTransparentColor = Color.Magenta;
		this.tsbHistoryData.Name = "tsbHistoryData";
		this.tsbHistoryData.Size = new Size(23, 21);
		this.tsbHistoryData.Text = "История паспортов объекта";
		this.tsbHistoryData.Click += this.tsbHistoryData_Click;
		this.tssRefreshData.Name = "tssRefreshData";
		this.tssRefreshData.Size = new Size(6, 24);
		this.tsbRefreshData.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.tsbRefreshData.Image = (Image)componentResourceManager.GetObject("tsbRefreshData.Image");
		this.tsbRefreshData.ImageTransparentColor = Color.Transparent;
		this.tsbRefreshData.Name = "tsbRefreshData";
		this.tsbRefreshData.Size = new Size(23, 21);
		this.tsbRefreshData.Text = "Обновление данных";
		this.tsbRefreshData.Click += this.tsbRefreshData_Click;
		this.tslText.Alignment = ToolStripItemAlignment.Right;
		this.tslText.DisplayStyle = ToolStripItemDisplayStyle.Text;
		this.tslText.Name = "tslText";
		this.tslText.Size = new Size(10, 21);
		this.tslText.Text = " ";
		this.dgvGeneral.AllowUserToAddRows = false;
		this.dgvGeneral.AllowUserToDeleteRows = false;
		this.dgvGeneral.AllowUserToResizeRows = false;
		this.dgvGeneral.BackgroundColor = Color.White;
		this.dgvGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvGeneral.Columns.AddRange(new DataGridViewColumn[]
		{
			this.id,
			this.Naim,
			this.ParentId
		});
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = Color.White;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle.SelectionBackColor = Color.White;
		dataGridViewCellStyle.SelectionForeColor = Color.Blue;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
		this.dgvGeneral.DefaultCellStyle = dataGridViewCellStyle;
		this.dgvGeneral.Dock = DockStyle.Fill;
		this.dgvGeneral.Location = new Point(3, 27);
		this.dgvGeneral.MultiSelect = false;
		this.dgvGeneral.Name = "dgvGeneral";
		this.dgvGeneral.ReadOnly = true;
		this.dgvGeneral.RowHeadersVisible = false;
		this.dgvGeneral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dgvGeneral.Size = new Size(405, 117);
		this.dgvGeneral.TabIndex = 9;
		this.class313_0.DataSetName = "dsPivotGrid";
		this.class313_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.id.DataPropertyName = "id";
		this.id.HeaderText = "id";
		this.id.Name = "id";
		this.id.ReadOnly = true;
		this.id.Visible = false;
		this.Naim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.Naim.DataPropertyName = "Наименование";
		this.Naim.HeaderText = "Наименование";
		this.Naim.Name = "Naim";
		this.Naim.ReadOnly = true;
		this.ParentId.DataPropertyName = "ParentId";
		this.ParentId.HeaderText = "ParentId";
		this.ParentId.Name = "ParentId";
		this.ParentId.ReadOnly = true;
		this.ParentId.Visible = false;
		base.BorderStyle = BorderStyle.FixedSingle;
		base.Controls.Add(this.tlpGeneral);
		base.Name = "PanelPivotGrid";
		base.Size = new Size(411, 147);
		this.tlpGeneral.ResumeLayout(false);
		this.tlpGeneral.PerformLayout();
		this.tsGeneral.ResumeLayout(false);
		this.tsGeneral.PerformLayout();
		((ISupportInitialize)this.dgvGeneral).EndInit();
		((ISupportInitialize)this.class313_0).EndInit();
		base.ResumeLayout(false);
	}

	private SQLSettings sqlsettings_0;

	private SqlDataCommand sqlDataCommand_0;

	private IContainer RjhaaDbyOr1;

	private TableLayoutPanel tlpGeneral;

	private ToolStrip tsGeneral;

	private ToolStripButton tsbAddData;

	private ToolStripButton tsbEditData;

	private ToolStripButton WnsaaPcnVo8;

	private ToolStripSeparator tssHistoryData;

	private ToolStripButton tsbHistoryData;

	private ToolStripSeparator tssRefreshData;

	private ToolStripButton tsbRefreshData;

	private ToolStripLabel tslText;

	private Class313 class313_0;

	public DataGridView dgvGeneral;

	private DataGridViewTextBoxColumn id;

	private DataGridViewTextBoxColumn Naim;

	private DataGridViewTextBoxColumn ParentId;

	private enum Enum10
	{

	}
}
