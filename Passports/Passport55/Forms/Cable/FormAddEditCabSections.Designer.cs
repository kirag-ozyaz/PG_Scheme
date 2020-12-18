using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.DataSets;
using Passport.Forms.PassportChars;
using Passport.Properties;

namespace Passport.Forms.Cable
{
	public class FormAddEditCabSections : FormBase
	{
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

		public int IdCabSection
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

		public FormAddEditCabSections(SQLSettings settings, int idCable)
		{
			this.method_14();
			this.SqlSettings = settings;
			this.int_1 = idCable;
			this.Text = "Добавление участка кабеля";
			this.stateFormCreate_0 = 0;
			this.nullableDateTimePicker_1.Value = null;
			this.nullableDateTimePicker_2.Value = null;
			this.nullableDateTimePicker_0.Value = null;
			this.numericUpDown_0.Value = this.method_0(idCable);
			this.method_5();
			this.method_2();
			this.method_4();
			this.method_13();
			this.int_2 = Class110.smethod_0(this.SqlSettings, base.Name);
		}

		public FormAddEditCabSections(SQLSettings settings, int idCabSecttion, int idCable, StateFormCreate state)
		{
			this.method_14();
			this.SqlSettings = settings;
			this.int_1 = idCable;
			this.int_0 = idCabSecttion;
			this.stateFormCreate_0 = state;
			this.Text = ((state == null) ? "Добавление" : "Редактирование") + " участка кабеля";
			this.method_5();
			this.method_2();
			this.method_4();
			this.method_13();
			if (state == 1)
			{
				this.method_6(this.int_0);
			}
			else
			{
				this.nullableDateTimePicker_1.Value = null;
				this.nullableDateTimePicker_2.Value = null;
				this.nullableDateTimePicker_0.Value = null;
				this.numericUpDown_0.Value = this.method_0(idCable);
			}
			this.int_2 = Class110.smethod_0(this.SqlSettings, base.Name);
		}

		private int method_0(int int_5)
		{
			string text = "select ISNULL(MAX(Number), 0) + 1 as Number FROM tP_CabSection\r\nwhere deleted = '0' and idObjList = " + int_5.ToString();
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToInt32(dataTable.Rows[0]["Number"]);
			}
			return 1;
		}

		private void method_1(int int_5)
		{
			this.method_2();
			this.comboBox_0.SelectedValue = int_5;
		}

		private void method_2()
		{
			string text = string.Format("WHERE idParent = {0} AND Deleted = ((0)) AND Name != '02'", this.int_1);
			DataTable dataSource = base.SelectSqlData("tSchm_ObjList", true, text);
			this.comboBox_0.DataSource = dataSource;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
		}

		private void method_3(int int_5)
		{
			this.method_4();
			this.comboBox_1.SelectedValue = int_5;
		}

		private void method_4()
		{
			string text = string.Format("WHERE idParent = {0} AND Deleted = ((0)) AND Name != '01'", this.int_1);
			DataTable dataSource = base.SelectSqlData("tSchm_ObjList", true, text);
			this.comboBox_1.DataSource = dataSource;
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.ValueMember = "id";
		}

		private void method_5()
		{
			string text = string.Format("WHERE ParentKey = ';Param;Cable;Makeup;' AND isGroup = ((0)) AND Deleted = ((0))", this.int_1);
			DataTable dataSource = base.SelectSqlData("tP_ValueLists", true, text);
			this.comboBox_2.DataSource = dataSource;
			this.comboBox_2.DisplayMember = "Name";
			this.comboBox_2.ValueMember = "id";
		}

		private void method_6(int int_5)
		{
			int num = -1;
			int num2 = -1;
			int num3 = 0;
			int num4 = 0;
			string text = string.Format("WHERE id = {0} AND Deleted = ((0))", int_5);
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection, true, text);
			int.TryParse(this.dsPassport_0.tP_CabSection.Rows[0]["idClutchFirst"].ToString(), out num);
			int.TryParse(this.dsPassport_0.tP_CabSection.Rows[0]["idClutchSecond"].ToString(), out num2);
			this.comboBox_0.SelectedValue = num;
			this.comboBox_1.SelectedValue = num2;
			this.numericUpDown_0.Value = (int.TryParse(this.dsPassport_0.tP_CabSection.Rows[0]["Number"].ToString(), out num3) ? num3 : 0);
			this.comboBox_2.SelectedValue = (int.TryParse(this.dsPassport_0.tP_CabSection.Rows[0]["CableMakeup"].ToString(), out num4) ? num4 : -1);
			this.textBox_0.Text = this.dsPassport_0.tP_CabSection.Rows[0]["Voltage"].ToString();
			this.textBox_1.Text = this.dsPassport_0.tP_CabSection.Rows[0]["Wires"].ToString();
			this.textBox_2.Text = this.dsPassport_0.tP_CabSection.Rows[0]["CrossSection"].ToString();
			this.textBox_3.Text = this.dsPassport_0.tP_CabSection.Rows[0]["Length"].ToString();
			this.comboBox_3.SelectedValue = ((this.dsPassport_0.tP_CabSection.Rows[0]["Conditions"] != DBNull.Value) ? ((int)this.dsPassport_0.tP_CabSection.Rows[0]["Conditions"]) : -1);
			this.numericUpDown_1.Text = this.dsPassport_0.tP_CabSection.Rows[0]["Count"].ToString();
			this.nullableDateTimePicker_2.Value = this.dsPassport_0.tP_CabSection.Rows[0]["YearLaying"];
			this.nullableDateTimePicker_1.Value = this.dsPassport_0.tP_CabSection.Rows[0]["YearCommissioning"];
			this.nullableDateTimePicker_0.Value = this.dsPassport_0.tP_CabSection.Rows[0]["YearRenovation"];
			this.textBox_4.Text = this.dsPassport_0.tP_CabSection.Rows[0]["Comment"].ToString();
		}

		private bool method_7()
		{
			if (this.method_10(this.int_0))
			{
				return false;
			}
			if (this.dsPassport_0.tP_CabSection.Rows.Count == 0)
			{
				string text = string.Format("WHERE id = {0} AND Deleted = ((0))", this.int_0);
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection, true, text);
			}
			dsPassport.Class58 @class = (dsPassport.Class58)this.dsPassport_0.tP_CabSection.Rows[0];
			@class.idClutchFirst = (int)this.comboBox_0.SelectedValue;
			@class.idClutchSecond = (int)this.comboBox_1.SelectedValue;
			@class.Number = this.numericUpDown_0.Value.ToString();
			@class.CableMakeup = (int)this.comboBox_2.SelectedValue;
			@class.Voltage = (decimal.TryParse(this.textBox_0.Text, out this.decimal_0) ? this.decimal_0 : 0m);
			@class.Wires = (int.TryParse(this.textBox_1.Text, out this.int_3) ? this.int_3 : 0);
			@class.CrossSection = (decimal.TryParse(this.textBox_2.Text, out this.decimal_1) ? this.decimal_1 : 0m);
			@class.Length = (decimal.TryParse(this.textBox_3.Text, out this.decimal_2) ? this.decimal_2 : 0m);
			@class["Conditions"] = ((this.comboBox_3.SelectedValue == null) ? DBNull.Value : this.comboBox_3.SelectedValue);
			@class["Count"] = (int.TryParse(this.numericUpDown_1.Text, out this.int_4) ? this.int_4 : 0);
			@class["YearLaying"] = ((this.nullableDateTimePicker_2.Value == null) ? DBNull.Value : this.nullableDateTimePicker_2.Value);
			@class["YearCommissioning"] = ((this.nullableDateTimePicker_1.Value == null) ? DBNull.Value : this.nullableDateTimePicker_1.Value);
			@class["YearRenovation"] = ((this.nullableDateTimePicker_0.Value == null) ? DBNull.Value : this.nullableDateTimePicker_0.Value);
			@class.Comment = this.textBox_4.Text;
			return base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection);
		}

		private bool method_8()
		{
			dsPassport.Class58 @class = this.dsPassport_0.tP_CabSection.method_5();
			if (this.method_9())
			{
				return false;
			}
			@class.idClutchFirst = (int)this.comboBox_0.SelectedValue;
			@class.idClutchSecond = (int)this.comboBox_1.SelectedValue;
			@class.idObjList = this.int_1;
			@class.Number = this.numericUpDown_0.Value.ToString();
			@class.CableMakeup = (int)this.comboBox_2.SelectedValue;
			@class.Voltage = (decimal.TryParse(this.textBox_0.Text, out this.decimal_0) ? this.decimal_0 : 0m);
			@class.Wires = (int.TryParse(this.textBox_1.Text, out this.int_3) ? this.int_3 : 0);
			@class.CrossSection = (decimal.TryParse(this.textBox_2.Text, out this.decimal_1) ? this.decimal_1 : 0m);
			@class.Length = (decimal.TryParse(this.textBox_3.Text, out this.decimal_2) ? this.decimal_2 : 0m);
			if (this.comboBox_3.SelectedValue is int)
			{
				@class.Conditions = (int)this.comboBox_3.SelectedValue;
			}
			@class.Count = (int.TryParse(this.numericUpDown_1.Text, out this.int_4) ? this.int_4 : 0);
			@class["YearLaying"] = ((this.nullableDateTimePicker_2.Value == null) ? DBNull.Value : this.nullableDateTimePicker_2.Value);
			@class["YearCommissioning"] = ((this.nullableDateTimePicker_1.Value == null) ? DBNull.Value : this.nullableDateTimePicker_1.Value);
			@class["YearRenovation"] = ((this.nullableDateTimePicker_0.Value == null) ? DBNull.Value : this.nullableDateTimePicker_0.Value);
			@class.Comment = this.textBox_4.Text;
			@class.Deleted = false;
			this.dsPassport_0.tP_CabSection.method_0(@class);
			this.int_0 = base.InsertSqlDataOneRow(this.dsPassport_0, this.dsPassport_0.tP_CabSection);
			if (this.int_0 > 0)
			{
				return true;
			}
			MessageBox.Show("Ошибка при редактировании.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}

		private bool method_9()
		{
			return this.method_10(-1);
		}

		private bool method_10(int int_5)
		{
			if (Clutch.isExistIntoCabSection(this.SqlSettings, this.int_1, int_5, (int)this.comboBox_0.SelectedValue, SectionClutch.First))
			{
				MessageBox.Show("Невозможно выбрать данную муфту.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.comboBox_0.Focus();
				this.comboBox_0.DroppedDown = true;
				return true;
			}
			if (Clutch.isExistIntoCabSection(this.SqlSettings, this.int_1, int_5, (int)this.comboBox_1.SelectedValue, SectionClutch.Second))
			{
				MessageBox.Show("Невозможно выбрать данную муфту.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.comboBox_1.Focus();
				this.comboBox_1.DroppedDown = true;
				return true;
			}
			return false;
		}

		private void textBox_3_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputCheck.OnlyDigit(sender, e);
		}

		private void FormAddEditCabSections_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.comboBox_2.SelectedValue != null)
				{
					if ((int)this.comboBox_2.SelectedValue != -1)
					{
						if (this.comboBox_0.SelectedValue != null)
						{
							if ((int)this.comboBox_0.SelectedValue != -1)
							{
								if (this.comboBox_1.SelectedValue != null)
								{
									if ((int)this.comboBox_1.SelectedValue != -1)
									{
										if (this.textBox_0.Text.Length == 0)
										{
											MessageBox.Show("Не введено напряжение.");
											this.textBox_0.Focus();
											e.Cancel = true;
											return;
										}
										if (this.textBox_1.Text.Length == 0)
										{
											MessageBox.Show("Не введено количество жил.");
											this.textBox_0.Focus();
											e.Cancel = true;
											return;
										}
										if (this.textBox_2.Text.Length == 0)
										{
											MessageBox.Show("Не введено сечение жил.");
											this.textBox_0.Focus();
											e.Cancel = true;
											return;
										}
										if (this.textBox_3.Text.Length == 0)
										{
											MessageBox.Show("Не введена длина участка.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
											this.textBox_0.Focus();
											e.Cancel = true;
											return;
										}
										if (this.stateFormCreate_0 == null)
										{
											if (!this.method_8())
											{
												e.Cancel = true;
												return;
											}
										}
										else if (!this.method_7())
										{
											e.Cancel = true;
											return;
										}
										Class110.smethod_2(this.SqlSettings, this.int_2, this.stateFormCreate_0);
										goto IL_1EE;
									}
								}
								MessageBox.Show("Не выбрана вторая муфта.");
								this.comboBox_1.Focus();
								e.Cancel = true;
								return;
							}
						}
						MessageBox.Show("Не выбрана первая муфта.");
						this.comboBox_0.Focus();
						e.Cancel = true;
						return;
					}
				}
				MessageBox.Show("Не выбрана марка кабеля.");
				this.comboBox_2.Focus();
				e.Cancel = true;
				return;
			}
			IL_1EE:
			Class110.smethod_1(this.SqlSettings, this.int_2);
		}

		private void button_3_Click(object sender, EventArgs e)
		{
			FormAddEditClutch formAddEditClutch = new FormAddEditClutch(this.SqlSettings, this.int_1, 0);
			formAddEditClutch.ClutchType = TypeClutch.End;
			if (formAddEditClutch.ShowDialog() == DialogResult.OK)
			{
				this.method_1(formAddEditClutch.Id);
			}
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			FormAddEditClutch formAddEditClutch = new FormAddEditClutch(this.SqlSettings, this.int_1, 0);
			formAddEditClutch.ClutchType = TypeClutch.End;
			if (formAddEditClutch.ShowDialog() == DialogResult.OK)
			{
				this.method_3(formAddEditClutch.Id);
			}
		}

		private void button_4_Click(object sender, EventArgs e)
		{
			this.method_11();
			FormReferValueLists formReferValueLists = new FormReferValueLists(this.SqlSettings);
			formReferValueLists.GroupKey = ";Param;CableSection;Laying;";
			formReferValueLists.FormClosed += this.method_12;
			formReferValueLists.Show();
		}

		private void method_11()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			if (sqlDataCommand.SelectSqlData("SELECT * FROM tP_ValueLists WHERE ParentKey = ';Param;CableSection;Laying;' AND isGroup = ((1)) AND Deleted = ((0))").Rows.Count <= 0)
			{
				dsPassport.Class79 @class = this.dsPassport_0.tP_ValueLists.method_5();
				@class.method_5(false);
				@class.method_3(true);
				@class.Name = "Условия прокладки участка кабеля";
				@class.ParentKey = ";Param;CableSection;Laying;";
				this.dsPassport_0.tP_ValueLists.method_0(@class);
				sqlDataCommand.InsertSqlData(this.dsPassport_0, this.dsPassport_0.tP_ValueLists);
			}
		}

		private void method_12(object sender, FormClosedEventArgs e)
		{
			this.method_13();
		}

		private void method_13()
		{
			base.SelectSqlDataTableOther(this.dsPassport_0, this.dsPassport_0.tP_ValueList, "tP_ValueLists", true, "WHERE ParentKey = ';Param;CableSection;Laying;' AND Deleted = ((0)) AND isGroup = ((0))");
		}

		private void button_0_Click(object sender, EventArgs e)
		{
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
			this.comboBox_0 = new ComboBox();
			this.comboBox_1 = new ComboBox();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.numericUpDown_0 = new NumericUpDown();
			this.comboBox_2 = new ComboBox();
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.textBox_2 = new TextBox();
			this.textBox_3 = new TextBox();
			this.textBox_4 = new TextBox();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.label_4 = new Label();
			this.label_5 = new Label();
			this.label_6 = new Label();
			this.label_7 = new Label();
			this.label_8 = new Label();
			this.label_9 = new Label();
			this.label_10 = new Label();
			this.label_11 = new Label();
			this.label_12 = new Label();
			this.label_13 = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.numericUpDown_1 = new NumericUpDown();
			this.dsPassport_0 = new dsPassport();
			this.button_3 = new Button();
			this.button_2 = new Button();
			this.nullableDateTimePicker_0 = new NullableDateTimePicker();
			this.nullableDateTimePicker_1 = new NullableDateTimePicker();
			this.nullableDateTimePicker_2 = new NullableDateTimePicker();
			this.comboBox_3 = new ComboBox();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.button_4 = new Button();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.numericUpDown_1).BeginInit();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			this.tableLayoutPanel_0.SuspendLayout();
			base.SuspendLayout();
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(117, 24);
			this.comboBox_0.Name = "cbFirstClutch";
			this.comboBox_0.Size = new Size(96, 21);
			this.comboBox_0.TabIndex = 0;
			this.comboBox_0.Tag = "1";
			this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(376, 24);
			this.comboBox_1.Name = "cbSecondClutch";
			this.comboBox_1.Size = new Size(159, 21);
			this.comboBox_1.TabIndex = 2;
			this.comboBox_1.Tag = "2";
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(31, 27);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(80, 13);
			this.label_0.TabIndex = 18;
			this.label_0.Text = "Первая муфта";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(292, 28);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(78, 13);
			this.label_1.TabIndex = 18;
			this.label_1.Text = "Вторая муфта";
			this.numericUpDown_0.Location = new Point(117, 62);
			this.numericUpDown_0.Name = "nudNumberSector";
			this.numericUpDown_0.Size = new Size(121, 20);
			this.numericUpDown_0.TabIndex = 4;
			this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(117, 88);
			this.comboBox_2.Name = "cbCableMakeup";
			this.comboBox_2.Size = new Size(121, 21);
			this.comboBox_2.TabIndex = 5;
			this.textBox_0.Location = new Point(117, 115);
			this.textBox_0.Name = "tbVoltage";
			this.textBox_0.Size = new Size(122, 20);
			this.textBox_0.TabIndex = 6;
			this.textBox_0.KeyPress += this.textBox_3_KeyPress;
			this.textBox_1.Location = new Point(117, 139);
			this.textBox_1.Name = "tbWires";
			this.textBox_1.Size = new Size(122, 20);
			this.textBox_1.TabIndex = 7;
			this.textBox_1.KeyPress += this.textBox_3_KeyPress;
			this.textBox_2.Location = new Point(118, 165);
			this.textBox_2.Name = "tbCrossSection";
			this.textBox_2.Size = new Size(121, 20);
			this.textBox_2.TabIndex = 8;
			this.textBox_2.KeyPress += this.textBox_3_KeyPress;
			this.textBox_3.Location = new Point(117, 191);
			this.textBox_3.Name = "tbLength";
			this.textBox_3.Size = new Size(122, 20);
			this.textBox_3.TabIndex = 9;
			this.textBox_3.KeyPress += this.textBox_3_KeyPress;
			this.textBox_4.Location = new Point(376, 191);
			this.textBox_4.Name = "tbComment";
			this.textBox_4.Size = new Size(188, 20);
			this.textBox_4.TabIndex = 15;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(13, 64);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(83, 13);
			this.label_2.TabIndex = 18;
			this.label_2.Text = "Номер участка";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(13, 90);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(79, 13);
			this.label_3.TabIndex = 18;
			this.label_3.Text = "Марка кабеля";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(13, 118);
			this.label_4.Name = "label5";
			this.label_4.Size = new Size(71, 13);
			this.label_4.TabIndex = 18;
			this.label_4.Text = "Напряжение";
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(13, 142);
			this.label_5.Name = "label6";
			this.label_5.Size = new Size(89, 13);
			this.label_5.TabIndex = 18;
			this.label_5.Text = "Количество жил";
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(13, 168);
			this.label_6.Name = "label7";
			this.label_6.Size = new Size(72, 13);
			this.label_6.TabIndex = 18;
			this.label_6.Text = "Сечение жил";
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(13, 194);
			this.label_7.Name = "label8";
			this.label_7.Size = new Size(40, 13);
			this.label_7.TabIndex = 18;
			this.label_7.Text = "Длина";
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(262, 64);
			this.label_8.Name = "label9";
			this.label_8.Size = new Size(108, 13);
			this.label_8.TabIndex = 18;
			this.label_8.Text = "Условия прокладки";
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(262, 91);
			this.label_9.Name = "label10";
			this.label_9.Size = new Size(66, 13);
			this.label_9.TabIndex = 18;
			this.label_9.Text = "Количество";
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(262, 118);
			this.label_10.Name = "label11";
			this.label_10.Size = new Size(90, 13);
			this.label_10.TabIndex = 18;
			this.label_10.Text = "Дата прокладки";
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(262, 142);
			this.label_11.Name = "label12";
			this.label_11.Size = new Size(111, 13);
			this.label_11.TabIndex = 18;
			this.label_11.Text = "Дата ввода в экспл.";
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(262, 168);
			this.label_12.Name = "label13";
			this.label_12.Size = new Size(112, 13);
			this.label_12.TabIndex = 18;
			this.label_12.Text = "Дата реконструкции";
			this.label_13.AutoSize = true;
			this.label_13.Location = new Point(262, 194);
			this.label_13.Name = "label14";
			this.label_13.Size = new Size(77, 13);
			this.label_13.TabIndex = 18;
			this.label_13.Text = "Комментарий";
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(369, 6);
			this.button_0.Margin = new Padding(3, 6, 10, 6);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(105, 24);
			this.button_0.TabIndex = 16;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Dock = DockStyle.Left;
			this.button_1.Location = new Point(494, 6);
			this.button_1.Margin = new Padding(10, 6, 3, 6);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 24);
			this.button_1.TabIndex = 17;
			this.button_1.Text = "Отменить";
			this.button_1.UseVisualStyleBackColor = true;
			this.numericUpDown_1.Location = new Point(376, 88);
			this.numericUpDown_1.Name = "nudCount";
			this.numericUpDown_1.Size = new Size(188, 20);
			this.numericUpDown_1.TabIndex = 11;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.button_3.Image = Resources._1304662999_bullet_toggle_plus;
			this.button_3.Location = new Point(216, 23);
			this.button_3.Name = "btnAddClutchFirst";
			this.button_3.Size = new Size(23, 23);
			this.button_3.TabIndex = 1;
			this.button_3.UseVisualStyleBackColor = false;
			this.button_3.Click += this.button_3_Click;
			this.button_2.Image = Resources._1304662999_bullet_toggle_plus;
			this.button_2.Location = new Point(541, 23);
			this.button_2.Name = "btnAddClutchSecond";
			this.button_2.Size = new Size(23, 23);
			this.button_2.TabIndex = 3;
			this.button_2.Text = "...";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.nullableDateTimePicker_0.Location = new Point(376, 165);
			this.nullableDateTimePicker_0.Name = "dtpYearRenovation";
			this.nullableDateTimePicker_0.Size = new Size(188, 20);
			this.nullableDateTimePicker_0.TabIndex = 14;
			this.nullableDateTimePicker_0.Value = new DateTime(2016, 8, 24, 13, 21, 12, 385);
			this.nullableDateTimePicker_1.Location = new Point(376, 139);
			this.nullableDateTimePicker_1.Name = "dtpYearCommissioning";
			this.nullableDateTimePicker_1.Size = new Size(188, 20);
			this.nullableDateTimePicker_1.TabIndex = 13;
			this.nullableDateTimePicker_1.Value = new DateTime(2016, 8, 24, 13, 21, 12, 383);
			this.nullableDateTimePicker_2.Location = new Point(376, 115);
			this.nullableDateTimePicker_2.Name = "dtpYearLaying";
			this.nullableDateTimePicker_2.Size = new Size(188, 20);
			this.nullableDateTimePicker_2.TabIndex = 12;
			this.nullableDateTimePicker_2.Value = new DateTime(2016, 8, 24, 13, 21, 12, 381);
			this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_3.DataSource = this.bindingSource_0;
			this.comboBox_3.DisplayMember = "Name";
			this.comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_3.FlatStyle = FlatStyle.System;
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(376, 61);
			this.comboBox_3.Name = "cbConditions";
			this.comboBox_3.Size = new Size(159, 21);
			this.comboBox_3.TabIndex = 19;
			this.comboBox_3.ValueMember = "id";
			this.bindingSource_0.DataMember = "tP_ValueList";
			this.bindingSource_0.DataSource = this.dsPassport_0;
			this.button_4.Image = Resources._1304662999_bullet_toggle_plus;
			this.button_4.Location = new Point(541, 59);
			this.button_4.Name = "btnAddEditConditionLists";
			this.button_4.Size = new Size(23, 23);
			this.button_4.TabIndex = 20;
			this.button_4.Text = "...";
			this.button_4.UseVisualStyleBackColor = true;
			this.button_4.Click += this.button_4_Click;
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 1, 0);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 0, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Bottom;
			this.tableLayoutPanel_0.Location = new Point(0, 229);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 1;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Size = new Size(584, 36);
			this.tableLayoutPanel_0.TabIndex = 21;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_1;
			base.ClientSize = new Size(584, 265);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Controls.Add(this.button_4);
			base.Controls.Add(this.comboBox_3);
			base.Controls.Add(this.nullableDateTimePicker_2);
			base.Controls.Add(this.nullableDateTimePicker_1);
			base.Controls.Add(this.nullableDateTimePicker_0);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_3);
			base.Controls.Add(this.numericUpDown_1);
			base.Controls.Add(this.label_13);
			base.Controls.Add(this.label_12);
			base.Controls.Add(this.label_11);
			base.Controls.Add(this.label_10);
			base.Controls.Add(this.label_9);
			base.Controls.Add(this.label_8);
			base.Controls.Add(this.label_7);
			base.Controls.Add(this.label_6);
			base.Controls.Add(this.label_5);
			base.Controls.Add(this.label_4);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.textBox_4);
			base.Controls.Add(this.textBox_3);
			base.Controls.Add(this.textBox_2);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.comboBox_2);
			base.Controls.Add(this.numericUpDown_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.comboBox_1);
			base.Controls.Add(this.comboBox_0);
			base.Name = "FormAddEditCabSections";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddEditCabSections";
			base.FormClosing += this.FormAddEditCabSections_FormClosing;
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.numericUpDown_1).EndInit();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			this.tableLayoutPanel_0.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0;

		private int int_1;

		private int int_2;

		private StateFormCreate stateFormCreate_0;

		private decimal decimal_0;

		private decimal decimal_1;

		private decimal decimal_2;

		private int int_3;

		private int int_4;

		private IContainer icontainer_0;

		private ComboBox comboBox_0;

		private ComboBox comboBox_1;

		private Label label_0;

		private Label label_1;

		private NumericUpDown numericUpDown_0;

		private ComboBox comboBox_2;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private TextBox textBox_2;

		private TextBox textBox_3;

		private TextBox textBox_4;

		private Label label_2;

		private Label label_3;

		private Label label_4;

		private Label label_5;

		private Label label_6;

		private Label label_7;

		private Label label_8;

		private Label label_9;

		private Label label_10;

		private Label label_11;

		private Label label_12;

		private Label label_13;

		private Button button_0;

		private Button button_1;

		private dsPassport dsPassport_0;

		private NumericUpDown numericUpDown_1;

		private Button button_2;

		private Button button_3;

		private NullableDateTimePicker nullableDateTimePicker_0;

		private NullableDateTimePicker nullableDateTimePicker_1;

		private NullableDateTimePicker nullableDateTimePicker_2;

		private ComboBox comboBox_3;

		private Button button_4;

		private BindingSource bindingSource_0;

		private TableLayoutPanel tableLayoutPanel_0;
	}
}
