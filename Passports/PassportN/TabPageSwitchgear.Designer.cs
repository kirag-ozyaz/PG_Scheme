using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;

internal class TabPageSwitchgear : Panel
{
	internal TabPageSwitchgear()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.InitializeComponent();
	}

	internal TabPageSwitchgear(SQLSettings sqlsettings_1, int int_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.InitializeComponent();
		this.sqlsettings_0 = sqlsettings_1;
		this.int_0 = int_1;
		this.sqlDataCommand_0 = new SqlDataCommand(sqlsettings_1);
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

	[Browsable(false)]
	[Category("Behavior")]
	[Description("Задает или получает идентификатор распределительного устройства.")]
	internal int Int32_0
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

	internal void method_0(int int_1)
	{
		string text = string.Format("where idObjList = {0}", int_1);
		this.sqlDataCommand_0.SelectSqlDataTableOther(this.class302_0, this.class302_0.vPassportShowSwitchgears, "vPassportShowData", true, text);
		text = string.Format("where idObjList = {0}", int_1);
		this.sqlDataCommand_0.SelectSqlDataTableOther(this.class302_0, this.class302_0.vPassportShowBus, "vPassportShowData", true, text);
		text = string.Format("where idObjList = {0}", int_1);
		this.sqlDataCommand_0.SelectSqlDataTableOther(this.class302_0, this.class302_0.vPassportShowCells, "vPassportShowData", true, text);
		text = string.Format("where idObjList = {0}", int_1);
		this.sqlDataCommand_0.SelectSqlDataTableOther(this.class302_0, this.class302_0.vPassportShowSwitches, "vPassportShowData", true, text);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.IbPamgJuwki != null)
		{
			this.IbPamgJuwki.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.class302_0 = new Class302();
		this.GunamodgkhI = new TableLayoutPanel();
		this.ppgSwitchgear = new PanelPivotGrid();
		this.tcSwitchgearEquipments = new TabControl();
		this.tpBus = new TabPage();
		this.ppgBus = new PanelPivotGrid();
		this.tpCells = new TabPage();
		this.ppgCells = new PanelPivotGrid();
		this.tpSwitch = new TabPage();
		this.ppgSwitch = new PanelPivotGrid();
		((ISupportInitialize)this.class302_0).BeginInit();
		this.GunamodgkhI.SuspendLayout();
		this.tcSwitchgearEquipments.SuspendLayout();
		this.tpBus.SuspendLayout();
		this.tpCells.SuspendLayout();
		this.tpSwitch.SuspendLayout();
		base.SuspendLayout();
		this.class302_0.DataSetName = "dsSwitchgears";
		this.class302_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.GunamodgkhI.ColumnCount = 1;
		this.GunamodgkhI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.GunamodgkhI.Controls.Add(this.ppgSwitchgear, 0, 0);
		this.GunamodgkhI.Controls.Add(this.tcSwitchgearEquipments, 0, 1);
		this.GunamodgkhI.Dock = DockStyle.Fill;
		this.GunamodgkhI.Location = new Point(0, 0);
		this.GunamodgkhI.Name = "tableLayoutPanel3";
		this.GunamodgkhI.RowCount = 2;
		this.GunamodgkhI.RowStyles.Add(new RowStyle(SizeType.Percent, 30.42394f));
		this.GunamodgkhI.RowStyles.Add(new RowStyle(SizeType.Percent, 69.57606f));
		this.GunamodgkhI.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		this.GunamodgkhI.Size = new Size(573, 401);
		this.GunamodgkhI.TabIndex = 2;
		this.ppgSwitchgear.BorderStyle = BorderStyle.FixedSingle;
		this.ppgSwitchgear.Boolean_0 = false;
		this.ppgSwitchgear.Boolean_1 = false;
		this.ppgSwitchgear.Dock = DockStyle.Fill;
		this.ppgSwitchgear.Location = new Point(3, 3);
		this.ppgSwitchgear.Name = "ppgSwitchgear";
		this.ppgSwitchgear.Size = new Size(567, 116);
		this.ppgSwitchgear.SQLSettings_0 = null;
		this.ppgSwitchgear.TabIndex = 0;
		this.ppgSwitchgear.Text = " ";
		this.tcSwitchgearEquipments.Controls.Add(this.tpBus);
		this.tcSwitchgearEquipments.Controls.Add(this.tpCells);
		this.tcSwitchgearEquipments.Controls.Add(this.tpSwitch);
		this.tcSwitchgearEquipments.Dock = DockStyle.Fill;
		this.tcSwitchgearEquipments.Location = new Point(3, 125);
		this.tcSwitchgearEquipments.Name = "tcSwitchgearEquipments";
		this.tcSwitchgearEquipments.SelectedIndex = 0;
		this.tcSwitchgearEquipments.Size = new Size(567, 273);
		this.tcSwitchgearEquipments.TabIndex = 1;
		this.tpBus.Controls.Add(this.ppgBus);
		this.tpBus.Location = new Point(4, 22);
		this.tpBus.Name = "tpBus";
		this.tpBus.Padding = new Padding(3);
		this.tpBus.Size = new Size(559, 247);
		this.tpBus.TabIndex = 0;
		this.tpBus.Text = "Шины";
		this.tpBus.UseVisualStyleBackColor = true;
		this.ppgBus.BorderStyle = BorderStyle.FixedSingle;
		this.ppgBus.Boolean_0 = false;
		this.ppgBus.Boolean_1 = false;
		this.ppgBus.Dock = DockStyle.Fill;
		this.ppgBus.Location = new Point(3, 3);
		this.ppgBus.Name = "ppgBus";
		this.ppgBus.Size = new Size(553, 241);
		this.ppgBus.SQLSettings_0 = null;
		this.ppgBus.TabIndex = 1;
		this.ppgBus.Text = " ";
		this.tpCells.Controls.Add(this.ppgCells);
		this.tpCells.Location = new Point(4, 22);
		this.tpCells.Name = "tpCells";
		this.tpCells.Padding = new Padding(3);
		this.tpCells.Size = new Size(559, 247);
		this.tpCells.TabIndex = 1;
		this.tpCells.Text = "Ячейки";
		this.tpCells.UseVisualStyleBackColor = true;
		this.ppgCells.BorderStyle = BorderStyle.FixedSingle;
		this.ppgCells.Boolean_0 = false;
		this.ppgCells.Boolean_1 = false;
		this.ppgCells.Dock = DockStyle.Fill;
		this.ppgCells.Location = new Point(3, 3);
		this.ppgCells.Name = "ppgCells";
		this.ppgCells.Size = new Size(553, 241);
		this.ppgCells.SQLSettings_0 = null;
		this.ppgCells.TabIndex = 1;
		this.ppgCells.Text = " ";
		this.tpSwitch.Controls.Add(this.ppgSwitch);
		this.tpSwitch.Location = new Point(4, 22);
		this.tpSwitch.Name = "tpSwitch";
		this.tpSwitch.Padding = new Padding(3);
		this.tpSwitch.Size = new Size(559, 247);
		this.tpSwitch.TabIndex = 2;
		this.tpSwitch.Text = "Коммутационные устройства";
		this.tpSwitch.UseVisualStyleBackColor = true;
		this.ppgSwitch.BorderStyle = BorderStyle.FixedSingle;
		this.ppgSwitch.Boolean_0 = false;
		this.ppgSwitch.Boolean_1 = false;
		this.ppgSwitch.Dock = DockStyle.Fill;
		this.ppgSwitch.Location = new Point(3, 3);
		this.ppgSwitch.Name = "ppgSwitch";
		this.ppgSwitch.Size = new Size(553, 241);
		this.ppgSwitch.SQLSettings_0 = null;
		this.ppgSwitch.TabIndex = 1;
		this.ppgSwitch.Text = " ";
		base.Controls.Add(this.GunamodgkhI);
		base.Name = "TabPageSwitchgear";
		base.Size = new Size(573, 401);
		((ISupportInitialize)this.class302_0).EndInit();
		this.GunamodgkhI.ResumeLayout(false);
		this.tcSwitchgearEquipments.ResumeLayout(false);
		this.tpBus.ResumeLayout(false);
		this.tpCells.ResumeLayout(false);
		this.tpSwitch.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private SQLSettings sqlsettings_0;

	private int int_0;

	private SqlDataCommand sqlDataCommand_0;

	private IContainer IbPamgJuwki;

	private Class302 class302_0;

	private TableLayoutPanel GunamodgkhI;

	private PanelPivotGrid ppgSwitchgear;

	private TabControl tcSwitchgearEquipments;

	private TabPage tpBus;

	private PanelPivotGrid ppgBus;

	private TabPage tpCells;

	private PanelPivotGrid ppgCells;

	private TabPage tpSwitch;

	private PanelPivotGrid ppgSwitch;
}
