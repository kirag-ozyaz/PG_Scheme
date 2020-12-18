using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using Passport.Controls.PanelPivotGrid;

namespace Passport.Controls.TabPageSwitchgear
{
	public class TabPageSwitchgear : Panel
	{
		public TabPageSwitchgear()
		{
			this.InitializeComponent();
		}

		public TabPageSwitchgear(SQLSettings sqlSettings, int idSwitchgear)
		{
			this.InitializeComponent();
			this.sqlsettings_0 = sqlSettings;
			this.int_0 = idSwitchgear;
			this.sqlDataCommand_0 = new SqlDataCommand(sqlSettings);
		}

		[Description("Задает или получает объект класса SQLSettings.")]
		[Browsable(false)]
		[Category("Behavior")]
		public SQLSettings SqlSettings
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

		[Description("Задает или получает идентификатор распределительного устройства.")]
		[Category("Behavior")]
		[Browsable(false)]
		public int IdSwitchgear
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

		public void ViewData(int idSwitchgear)
		{
			string text = string.Format("where idObjList = {0}", idSwitchgear);
			this.sqlDataCommand_0.SelectSqlDataTableOther(this.dsSwitchgears_0, this.dsSwitchgears_0.vPassportShowSwitchgears, "vPassportShowData", true, text);
			text = string.Format("where idObjList = {0}", idSwitchgear);
			this.sqlDataCommand_0.SelectSqlDataTableOther(this.dsSwitchgears_0, this.dsSwitchgears_0.vPassportShowBus, "vPassportShowData", true, text);
			text = string.Format("where idObjList = {0}", idSwitchgear);
			this.sqlDataCommand_0.SelectSqlDataTableOther(this.dsSwitchgears_0, this.dsSwitchgears_0.vPassportShowCells, "vPassportShowData", true, text);
			text = string.Format("where idObjList = {0}", idSwitchgear);
			this.sqlDataCommand_0.SelectSqlDataTableOther(this.dsSwitchgears_0, this.dsSwitchgears_0.vPassportShowSwitches, "vPassportShowData", true, text);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dsSwitchgears_0 = new dsSwitchgears();
			this.tableLayoutPanel3 = new TableLayoutPanel();
			this.ppgSwitchgear = new PanelPivotGrid();
			this.tcSwitchgearEquipments = new TabControl();
			this.tpBus = new TabPage();
			this.ppgBus = new PanelPivotGrid();
			this.tpCells = new TabPage();
			this.ppgCells = new PanelPivotGrid();
			this.tpSwitch = new TabPage();
			this.ppgSwitch = new PanelPivotGrid();
			((ISupportInitialize)this.dsSwitchgears_0).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.tcSwitchgearEquipments.SuspendLayout();
			this.tpBus.SuspendLayout();
			this.tpCells.SuspendLayout();
			this.tpSwitch.SuspendLayout();
			base.SuspendLayout();
			this.dsSwitchgears_0.DataSetName = "dsSwitchgears";
			this.dsSwitchgears_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel3.Controls.Add(this.ppgSwitchgear, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tcSwitchgearEquipments, 0, 1);
			this.tableLayoutPanel3.Dock = DockStyle.Fill;
			this.tableLayoutPanel3.Location = new Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30.42394f));
			this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 69.57606f));
			this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel3.Size = new Size(573, 401);
			this.tableLayoutPanel3.TabIndex = 2;
			this.ppgSwitchgear.BorderStyle = BorderStyle.FixedSingle;
			this.ppgSwitchgear.ButtonHistoryVisible = false;
			this.ppgSwitchgear.ButtonRefreshVisible = false;
			this.ppgSwitchgear.Dock = DockStyle.Fill;
			this.ppgSwitchgear.Location = new Point(3, 3);
			this.ppgSwitchgear.Name = "ppgSwitchgear";
			this.ppgSwitchgear.Size = new Size(567, 116);
			this.ppgSwitchgear.SqlSettings = null;
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
			this.ppgBus.ButtonHistoryVisible = false;
			this.ppgBus.ButtonRefreshVisible = false;
			this.ppgBus.Dock = DockStyle.Fill;
			this.ppgBus.Location = new Point(3, 3);
			this.ppgBus.Name = "ppgBus";
			this.ppgBus.Size = new Size(553, 241);
			this.ppgBus.SqlSettings = null;
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
			this.ppgCells.ButtonHistoryVisible = false;
			this.ppgCells.ButtonRefreshVisible = false;
			this.ppgCells.Dock = DockStyle.Fill;
			this.ppgCells.Location = new Point(3, 3);
			this.ppgCells.Name = "ppgCells";
			this.ppgCells.Size = new Size(553, 241);
			this.ppgCells.SqlSettings = null;
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
			this.ppgSwitch.ButtonHistoryVisible = false;
			this.ppgSwitch.ButtonRefreshVisible = false;
			this.ppgSwitch.Dock = DockStyle.Fill;
			this.ppgSwitch.Location = new Point(3, 3);
			this.ppgSwitch.Name = "ppgSwitch";
			this.ppgSwitch.Size = new Size(553, 241);
			this.ppgSwitch.SqlSettings = null;
			this.ppgSwitch.TabIndex = 1;
			this.ppgSwitch.Text = " ";
			base.Controls.Add(this.tableLayoutPanel3);
			base.Name = "TabPageSwitchgear";
			base.Size = new Size(573, 401);
			((ISupportInitialize)this.dsSwitchgears_0).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tcSwitchgearEquipments.ResumeLayout(false);
			this.tpBus.ResumeLayout(false);
			this.tpCells.ResumeLayout(false);
			this.tpSwitch.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private SQLSettings sqlsettings_0;

		private int int_0;

		private SqlDataCommand sqlDataCommand_0;

		private IContainer icontainer_0;

		private dsSwitchgears dsSwitchgears_0;

		private TableLayoutPanel tableLayoutPanel3;

		private PanelPivotGrid ppgSwitchgear;

		private TabControl tcSwitchgearEquipments;

		private TabPage tpBus;

		private PanelPivotGrid ppgBus;

		private TabPage tpCells;

		private PanelPivotGrid ppgCells;

		private TabPage tpSwitch;

		private PanelPivotGrid ppgSwitch;
	}
}
