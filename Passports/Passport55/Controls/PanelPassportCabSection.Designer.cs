using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using DataSql;
using Passport.DataSets;

namespace Passport.Controls
{
	public class PanelPassportCabSection : Panel
	{
		public PanelPassportCabSection()
		{
			this.InitializeComponent();
		}

		public PanelPassportCabSection(SQLSettings settings, int idCable)
		{
			this.InitializeComponent();
			this.sqlsettings_0 = settings;
			this.int_1 = idCable;
		}

		public StateFormCreate CreateState
		{
			get
			{
				return this.stateFormCreate_0;
			}
			set
			{
				this.stateFormCreate_0 = value;
			}
		}

		public SQLSettings SqlSettings
		{
			get
			{
				return this.sqlsettings_0;
			}
			set
			{
				this.sqlsettings_0 = value;
			}
		}

		public int Id
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

		public int IdCable
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public int IdClutchFirst
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		public int IdClutchSecond
		{
			get
			{
				return this.int_3;
			}
			set
			{
				this.int_3 = value;
			}
		}

		internal DataRow CabSectionRow
		{
			get
			{
				this.dsPassport_0.tP_CabSection.Rows[0]["idObjList"] = this.int_1;
				this.dsPassport_0.tP_CabSection.Rows[0]["idClutchFirst"] = this.int_2;
				this.dsPassport_0.tP_CabSection.Rows[0]["idClutchSecond"] = this.int_3;
				this.dsPassport_0.tP_CabSection.Rows[0]["Deleted"] = false;
				this.bindingSource_0.EndEdit();
				dsPassport.Class58 @class = this.dsPassport_0.tP_CabSection.method_5();
				@class.ItemArray = (this.dsPassport_0.tP_CabSection.Rows[0].ItemArray.Clone() as object[]);
				this.dsPassport_0.tP_CabSection.Rows.Clear();
				return @class;
			}
		}

		public void Fill()
		{
			this.method_0();
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate == null)
			{
				dsPassport.Class58 @class = this.dsPassport_0.tP_CabSection.method_5();
				@class["idObjList"] = this.int_1;
				@class["idClutchFirst"] = this.int_2;
				@class["idClutchSecond"] = this.int_3;
				@class["Deleted"] = false;
				this.dsPassport_0.tP_CabSection.method_0(@class);
				return;
			}
			if (stateFormCreate == 1)
			{
				this.method_1(this.int_0);
				return;
			}
			if (stateFormCreate != 7)
			{
				return;
			}
			this.method_1(this.int_0);
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				if (control.GetType() == typeof(TextBox))
				{
					((TextBox)control).ReadOnly = true;
				}
				if (control.GetType() == typeof(TextBox))
				{
					((ComboBox)control).Enabled = true;
				}
			}
		}

		public void Fill(SQLSettings settings, int int_4, StateFormCreate state)
		{
			this.Fill(settings, int_4, this.int_2, this.int_3, state);
		}

		public void Fill(SQLSettings settings, int int_4, int idClutchFirst, int idClutchSecond, StateFormCreate state)
		{
			this.SqlSettings = settings;
			if (state == null)
			{
				this.int_1 = int_4;
				this.dtpYearCommissioning.Value = null;
				this.dtpYearLaying.Value = null;
				this.dtpYearRenovation.Value = null;
			}
			if (state == 1)
			{
				this.int_0 = int_4;
			}
			this.stateFormCreate_0 = state;
			this.Fill();
		}

		public bool Save(int idClutchFirst, int idClutchSecond)
		{
			if (this.stateFormCreate_0 == null)
			{
				this.sqlDataCommand_0 = new SqlDataCommand(this.sqlsettings_0);
				this.bindingSource_0.EndEdit();
				this.int_0 = this.sqlDataCommand_0.InsertSqlDataOneRow(this.dsPassport_0.tP_CabSection);
				return this.int_0 > 0;
			}
			if (this.stateFormCreate_0 == 1)
			{
				this.sqlDataCommand_0 = new SqlDataCommand(this.sqlsettings_0);
				this.bindingSource_0.EndEdit();
				return this.sqlDataCommand_0.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection);
			}
			return false;
		}

		public bool Save()
		{
			return this.Save(this.int_2, this.int_3);
		}

		public bool CheckData()
		{
			if (this.cbCableMakeup.SelectedValue != null)
			{
				if ((int)this.cbCableMakeup.SelectedValue != -1)
				{
					if (this.tbVoltage.Text.Length == 0)
					{
						MessageBox.Show("Не введено напряжение.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.tbVoltage.Focus();
						return false;
					}
					if (this.tbWires.Text.Length == 0)
					{
						MessageBox.Show("Не введено количество жил.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.tbVoltage.Focus();
						return false;
					}
					if (this.tbCrossSection.Text.Length == 0)
					{
						MessageBox.Show("Не введено сечение жил.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.tbVoltage.Focus();
						return false;
					}
					if (this.tbLength.Text.Length == 0)
					{
						MessageBox.Show("Не введена длина участка.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.tbVoltage.Focus();
						return false;
					}
					return true;
				}
			}
			MessageBox.Show("Не выбрана марка кабеля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			this.cbCableMakeup.Focus();
			return false;
		}

		private void method_0()
		{
			this.sqlDataCommand_0 = new SqlDataCommand(this.sqlsettings_0);
			string text = string.Format("WHERE ParentKey = ';Param;Cable;Makeup;' AND isGroup = ((0)) AND Deleted = ((0))", this.int_1);
			DataTable dataSource = this.sqlDataCommand_0.SelectSqlData("tP_ValueLists", true, text, null);
			this.cbCableMakeup.DataSource = dataSource;
			this.cbCableMakeup.DisplayMember = "Name";
			this.cbCableMakeup.ValueMember = "id";
		}

		private void method_1(int int_4)
		{
			string text = string.Format("WHERE id = {0} AND Deleted = ((0))", int_4);
			this.sqlDataCommand_0.SelectSqlData(this.dsPassport_0.tP_CabSection, true, text, null, false, 0);
			this.bindingSource_0.ResetBindings(false);
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
			this.icontainer_0 = new Container();
			this.nudCount = new NumericUpDown();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsPassport_0 = new dsPassport();
			this.label14 = new Label();
			this.label13 = new Label();
			this.label12 = new Label();
			this.label11 = new Label();
			this.label10 = new Label();
			this.label9 = new Label();
			this.label8 = new Label();
			this.label7 = new Label();
			this.label6 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.tbComment = new TextBox();
			this.tbConditions = new TextBox();
			this.tbLength = new TextBox();
			this.tbCrossSection = new TextBox();
			this.tbWires = new TextBox();
			this.tbVoltage = new TextBox();
			this.cbCableMakeup = new ComboBox();
			this.nudNumberSector = new NumericUpDown();
			this.dtpYearRenovation = new NullableDateTimePicker();
			this.dtpYearCommissioning = new NullableDateTimePicker();
			this.dtpYearLaying = new NullableDateTimePicker();
			((ISupportInitialize)this.nudCount).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			((ISupportInitialize)this.nudNumberSector).BeginInit();
			base.SuspendLayout();
			this.nudCount.DataBindings.Add(new Binding("Value", this.bindingSource_0, "Count", true));
			this.nudCount.Location = new Point(145, 250);
			this.nudCount.Name = "nudCount";
			this.nudCount.Size = new Size(177, 20);
			this.nudCount.TabIndex = 54;
			this.bindingSource_0.DataMember = "tP_CabSection";
			this.bindingSource_0.DataSource = this.dsPassport_0;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label14.AutoSize = true;
			this.label14.Location = new Point(17, 382);
			this.label14.Name = "label14";
			this.label14.Size = new Size(77, 13);
			this.label14.TabIndex = 53;
			this.label14.Text = "Комментарий";
			this.label13.AutoSize = true;
			this.label13.Location = new Point(17, 352);
			this.label13.Name = "label13";
			this.label13.Size = new Size(104, 13);
			this.label13.TabIndex = 52;
			this.label13.Text = "Год реконструкции";
			this.label12.AutoSize = true;
			this.label12.Location = new Point(17, 319);
			this.label12.Name = "label12";
			this.label12.Size = new Size(103, 13);
			this.label12.TabIndex = 51;
			this.label12.Text = "Год ввода в экспл.";
			this.label11.AutoSize = true;
			this.label11.Location = new Point(18, 286);
			this.label11.Name = "label11";
			this.label11.Size = new Size(82, 13);
			this.label11.TabIndex = 50;
			this.label11.Text = "Год прокладки";
			this.label10.AutoSize = true;
			this.label10.Location = new Point(17, 252);
			this.label10.Name = "label10";
			this.label10.Size = new Size(66, 13);
			this.label10.TabIndex = 49;
			this.label10.Text = "Количество";
			this.label9.AutoSize = true;
			this.label9.Location = new Point(17, 220);
			this.label9.Name = "label9";
			this.label9.Size = new Size(108, 13);
			this.label9.TabIndex = 48;
			this.label9.Text = "Условия прокладки";
			this.label8.AutoSize = true;
			this.label8.Location = new Point(17, 187);
			this.label8.Name = "label8";
			this.label8.Size = new Size(40, 13);
			this.label8.TabIndex = 47;
			this.label8.Text = "Длина";
			this.label7.AutoSize = true;
			this.label7.Location = new Point(17, 154);
			this.label7.Name = "label7";
			this.label7.Size = new Size(72, 13);
			this.label7.TabIndex = 46;
			this.label7.Text = "Сечение жил";
			this.label6.AutoSize = true;
			this.label6.Location = new Point(17, 121);
			this.label6.Name = "label6";
			this.label6.Size = new Size(89, 13);
			this.label6.TabIndex = 45;
			this.label6.Text = "Количество жил";
			this.label5.AutoSize = true;
			this.label5.Location = new Point(17, 88);
			this.label5.Name = "label5";
			this.label5.Size = new Size(71, 13);
			this.label5.TabIndex = 44;
			this.label5.Text = "Напряжение";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(17, 54);
			this.label4.Name = "label4";
			this.label4.Size = new Size(79, 13);
			this.label4.TabIndex = 43;
			this.label4.Text = "Марка кабеля";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(17, 20);
			this.label3.Name = "label3";
			this.label3.Size = new Size(83, 13);
			this.label3.TabIndex = 42;
			this.label3.Text = "Номер участка";
			this.tbComment.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Comment", true));
			this.tbComment.Location = new Point(145, 382);
			this.tbComment.Name = "tbComment";
			this.tbComment.Size = new Size(177, 20);
			this.tbComment.TabIndex = 41;
			this.tbConditions.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Conditions", true));
			this.tbConditions.Location = new Point(144, 217);
			this.tbConditions.Name = "tbConditions";
			this.tbConditions.Size = new Size(177, 20);
			this.tbConditions.TabIndex = 37;
			this.tbLength.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Length", true));
			this.tbLength.Location = new Point(144, 184);
			this.tbLength.Name = "tbLength";
			this.tbLength.Size = new Size(177, 20);
			this.tbLength.TabIndex = 36;
			this.tbCrossSection.DataBindings.Add(new Binding("Text", this.bindingSource_0, "CrossSection", true));
			this.tbCrossSection.Location = new Point(145, 151);
			this.tbCrossSection.Name = "tbCrossSection";
			this.tbCrossSection.Size = new Size(176, 20);
			this.tbCrossSection.TabIndex = 35;
			this.tbWires.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Wires", true));
			this.tbWires.Location = new Point(143, 118);
			this.tbWires.Name = "tbWires";
			this.tbWires.Size = new Size(177, 20);
			this.tbWires.TabIndex = 34;
			this.tbVoltage.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Voltage", true));
			this.tbVoltage.Location = new Point(143, 85);
			this.tbVoltage.Name = "tbVoltage";
			this.tbVoltage.Size = new Size(177, 20);
			this.tbVoltage.TabIndex = 33;
			this.cbCableMakeup.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "CableMakeup", true));
			this.cbCableMakeup.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbCableMakeup.FormattingEnabled = true;
			this.cbCableMakeup.Location = new Point(143, 51);
			this.cbCableMakeup.Name = "cbCableMakeup";
			this.cbCableMakeup.Size = new Size(177, 21);
			this.cbCableMakeup.TabIndex = 32;
			this.nudNumberSector.DataBindings.Add(new Binding("Value", this.bindingSource_0, "Number", true));
			this.nudNumberSector.Location = new Point(144, 18);
			this.nudNumberSector.Name = "nudNumberSector";
			this.nudNumberSector.Size = new Size(177, 20);
			this.nudNumberSector.TabIndex = 31;
			this.dtpYearRenovation.DataBindings.Add(new Binding("Value", this.bindingSource_0, "YearRenovation", true));
			this.dtpYearRenovation.Location = new Point(145, 349);
			this.dtpYearRenovation.Name = "dtpYearRenovation";
			this.dtpYearRenovation.Size = new Size(177, 20);
			this.dtpYearRenovation.TabIndex = 55;
			this.dtpYearRenovation.Value = new DateTime(2013, 3, 13, 20, 47, 26, 940);
			this.dtpYearCommissioning.Location = new Point(145, 316);
			this.dtpYearCommissioning.Name = "dtpYearCommissioning";
			this.dtpYearCommissioning.Size = new Size(177, 20);
			this.dtpYearCommissioning.TabIndex = 56;
			this.dtpYearCommissioning.Value = new DateTime(2013, 3, 13, 20, 49, 4, 199);
			this.dtpYearLaying.Location = new Point(145, 283);
			this.dtpYearLaying.Name = "dtpYearLaying";
			this.dtpYearLaying.Size = new Size(177, 20);
			this.dtpYearLaying.TabIndex = 57;
			this.dtpYearLaying.Value = new DateTime(2013, 3, 13, 20, 49, 37, 895);
			base.Controls.Add(this.dtpYearLaying);
			base.Controls.Add(this.dtpYearCommissioning);
			base.Controls.Add(this.dtpYearRenovation);
			base.Controls.Add(this.nudCount);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.tbComment);
			base.Controls.Add(this.tbConditions);
			base.Controls.Add(this.tbLength);
			base.Controls.Add(this.tbCrossSection);
			base.Controls.Add(this.tbWires);
			base.Controls.Add(this.tbVoltage);
			base.Controls.Add(this.cbCableMakeup);
			base.Controls.Add(this.nudNumberSector);
			base.Name = "PanelPassportCabSection";
			base.Size = new Size(341, 415);
			((ISupportInitialize)this.nudCount).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			((ISupportInitialize)this.nudNumberSector).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private SQLSettings sqlsettings_0;

		private StateFormCreate stateFormCreate_0;

		private SqlDataCommand sqlDataCommand_0;

		private IContainer icontainer_0;

		private NumericUpDown nudCount;

		private Label label14;

		private Label label13;

		private Label label12;

		private Label label11;

		private Label label10;

		private Label label9;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;

		private Label label4;

		private Label label3;

		private TextBox tbComment;

		private TextBox tbConditions;

		private TextBox tbLength;

		private TextBox tbCrossSection;

		private TextBox tbWires;

		private TextBox tbVoltage;

		private ComboBox cbCableMakeup;

		private NumericUpDown nudNumberSector;

		private dsPassport dsPassport_0;

		private BindingSource bindingSource_0;

		private NullableDateTimePicker dtpYearRenovation;

		private NullableDateTimePicker dtpYearCommissioning;

		private NullableDateTimePicker dtpYearLaying;
	}
}
