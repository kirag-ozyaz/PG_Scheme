﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.DataSets;
using Passport.Forms.PassportChars;
using Passport.Properties;
using Reference.Forms;

namespace Passport.Forms.AirLine
{
	public class FormAddEditAirLineSpan : FormBase
	{
		[DefaultValue(-1)]
		public int IdSpan { get; set; }

		[DefaultValue(-1)]
		public int IdAirLine { get; set; }

		public StateFormCreate CreateState { get; set; }

		public FormAddEditAirLineSpan(SQLSettings settings, int idSpan, int idAirline, StateFormCreate state)
		{
			this.method_16();
			this.textBox_0.DataBindings.Clear();
			this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Length", true, DataSourceUpdateMode.OnValidation, "", "N0"));
			this.SqlSettings = settings;
			this.IdSpan = idSpan;
			this.IdAirLine = idAirline;
			this.CreateState = state;
			if (state == null)
			{
				this.Text = "Добавление пролета";
				this.textBox_3.ReadOnly = true;
			}
			else if (state == 1)
			{
				this.Text = "Редактирование пролета";
				this.textBox_3.ReadOnly = false;
			}
			else if (state == 11)
			{
				this.Text = "Копирование пролета";
				this.textBox_3.ReadOnly = true;
			}
			this.textBox_7.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.textBox_7.DataBindings[0].NullValue = string.Empty;
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			this.method_0(AirLinePole.First);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_0(AirLinePole.Second);
		}

		private void button_7_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (button.Tag == null)
			{
				return;
			}
			int num = Convert.ToInt32(button.Tag);
			if (num == 1)
			{
				this.method_1(AirLinePole.First);
				return;
			}
			if (num != 2)
			{
				return;
			}
			this.method_1(AirLinePole.Second);
		}

		private void method_0(AirLinePole airLinePole_0)
		{
			FormAddEditPylone formAddEditPylone = new FormAddEditPylone(-1, this.IdAirLine);
			formAddEditPylone.CreateState = 0;
			formAddEditPylone.SqlSettings = this.SqlSettings;
			formAddEditPylone.MdiParent = base.MdiParent;
			formAddEditPylone.LocationPole = airLinePole_0;
			formAddEditPylone.FormClosed += this.method_2;
			formAddEditPylone.Show();
		}

		private void method_1(AirLinePole airLinePole_0)
		{
			FormChoosePylone formChoosePylone = new FormChoosePylone();
			formChoosePylone.IdAirLine = this.IdAirLine;
			formChoosePylone.SqlSettings = this.SqlSettings;
			if (formChoosePylone.ShowDialog() == DialogResult.OK)
			{
				if (airLinePole_0 != AirLinePole.First)
				{
					if (airLinePole_0 == AirLinePole.Second)
					{
						((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idClutchSecond = formChoosePylone.PylonId;
						this.method_5(this.textBox_6, formChoosePylone.PylonId);
					}
				}
				else
				{
					((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idClutchFirst = formChoosePylone.PylonId;
					this.method_5(this.textBox_5, formChoosePylone.PylonId);
				}
				this.method_3(formChoosePylone.PylonId);
			}
		}

		private void method_2(object sender, FormClosedEventArgs e)
		{
			if (sender.GetType() == typeof(FormAddEditPylone))
			{
				FormAddEditPylone formAddEditPylone = (FormAddEditPylone)sender;
				if (formAddEditPylone.DialogResult == DialogResult.OK)
				{
					this.method_6(formAddEditPylone.LocationPole, formAddEditPylone.IdPole);
					return;
				}
			}
			else
			{
				this.method_9();
			}
		}

		private void method_3(int int_2)
		{
			DataTable dataTable = new DataTable("tP_CabSection");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("idEquipment", typeof(int));
			base.SelectSqlData(dataTable, true, string.Format("where (idClutchFirst = '{0}' or idClutchSecond = '{0}') and idObjList = '{1}'  and idEquipment is not null and deleted = '0' ", int_2, this.IdAirLine), false);
			if (dataTable.Rows.Count == 0)
			{
				return;
			}
			int num = Convert.ToInt32(dataTable.Rows[0]["idEquipment"]);
			((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idEquipment = num;
			this.method_15(num, true);
		}

		private void method_4(ref ComboBox comboBox_6)
		{
			comboBox_6.DataSource = base.SelectSqlData("tSchm_ObjList", true, "WHERE Deleted = ((0)) AND TypeCodeId IN (SELECT id FROM tR_Classifier WHERE ParentKey = ';SCM;Pole;' AND Deleted = ((0))) AND idParentAddl = " + this.IdAirLine.ToString());
			comboBox_6.ValueMember = "id";
			comboBox_6.DisplayMember = "Name";
		}

		private void method_5(TextBox textBox_8, int int_2)
		{
			DataTable dataTable = base.SelectSqlData("tSchm_ObjList", true, "WHERE Deleted = ((0)) AND id = " + int_2.ToString());
			if (dataTable != null && dataTable.Rows.Count != 0)
			{
				textBox_8.Text = dataTable.Rows[0]["Name"].ToString();
				return;
			}
			textBox_8.Text = string.Empty;
			MessageBox.Show("Опора не найдена");
		}

		private void method_6(AirLinePole airLinePole_0, int int_2)
		{
			if (airLinePole_0 == AirLinePole.First)
			{
				((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idClutchFirst = int_2;
				this.method_5(this.textBox_5, int_2);
				return;
			}
			((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idClutchSecond = int_2;
			this.method_5(this.textBox_6, int_2);
		}

		private void button_4_Click(object sender, EventArgs e)
		{
			FormReferValueLists formReferValueLists = new FormReferValueLists(this.SqlSettings);
			formReferValueLists.GroupKey = ";Param;Wire;Makeup;";
			formReferValueLists.MdiParent = base.MdiParent;
			formReferValueLists.FormClosed += this.method_2;
			formReferValueLists.Show();
		}

		private void FormAddEditAirLineSpan_Load(object sender, EventArgs e)
		{
			this.method_7();
			this.method_9();
			if (this.CreateState == null)
			{
				DataTable dataTable = base.SelectSqlData("vP_CableLine", true, "WHERE id = " + this.IdAirLine.ToString());
				dsPassport.Class58 @class = this.dsPassport_0.tP_CabSection.method_5();
				@class.idObjList = this.IdAirLine;
				@class.idClutchFirst = -1;
				@class.idClutchSecond = -1;
				@class.Number = this.method_8(this.IdAirLine).ToString();
				if (dataTable != null && dataTable.Rows.Count > 0 && !dataTable.Rows[0].IsNull("Voltage"))
				{
					@class.Voltage = Convert.ToDecimal(dataTable.Rows[0]["Voltage"]);
				}
				@class.Deleted = false;
				int activePassport = PassportData.GetActivePassport(this.SqlSettings, this.IdAirLine);
				DataTable dataTable2 = base.SelectSqlData("tP_ObjectChar", true, string.Format("WHERE idPassport = {0} and idObjChar in (select id from [tP_CharList] where [ParentKey] = ';EquipChar;Passp;VozdushnayaLiniya;Obshhie;' and Name = 'Год постройки' and Deleted = 0)and Deleted = 0", activePassport));
				if (dataTable2 != null && dataTable2.Rows.Count > 0 && !dataTable2.Rows[0].IsNull("Value") && dataTable2.Rows[0]["Value"].ToString() != "-1")
				{
					@class.YearCommissioning = new DateTime(Convert.ToInt32(dataTable2.Rows[0]["Value"]), 1, 1);
				}
				this.dsPassport_0.tP_CabSection.method_0(@class);
			}
			if (this.CreateState == 1)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection, true, "WHERE Deleted = ((0)) AND id = " + this.IdSpan.ToString());
			}
			if (this.CreateState == 11)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection, true, "WHERE Deleted = ((0)) AND id = " + this.IdSpan.ToString());
				if (this.dsPassport_0.tP_CabSection.Rows.Count > 0)
				{
					this.dsPassport_0.tP_CabSection[0].Number = this.method_8(this.IdAirLine).ToString();
				}
			}
			this.bindingSource_0.ResetBindings(false);
			if (((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idClutchFirst != -1)
			{
				this.method_5(this.textBox_5, ((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idClutchFirst);
			}
			if (((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idClutchSecond != -1)
			{
				this.method_5(this.textBox_6, ((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idClutchSecond);
			}
			if (!((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).method_22())
			{
				this.method_15(((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idEquipment, false);
			}
		}

		private void FormAddEditAirLineSpan_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && (!this.method_10() || (!this.method_13() && this.CreateState == 11)))
			{
				e.Cancel = true;
			}
		}

		private void method_7()
		{
			DataTable dataTable = new DataTable("tP_ValueLists");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			base.SelectSqlData(dataTable, true, " where ParentKey = ';Param;Crossing;' and deleted = 0 and isGroup = 0 ", false);
			dataTable.Rows.Add(dataTable.NewRow());
			DataView defaultView = dataTable.DefaultView;
			defaultView.Sort = "Name";
			this.comboBox_4.DataSource = defaultView.ToTable();
			this.comboBox_4.DisplayMember = "name";
			this.comboBox_4.ValueMember = "id";
			this.comboBox_4.SelectedIndex = -1;
			DataTable dataTable2 = new DataTable("tP_ValueLists");
			dataTable2.Columns.Add("id", typeof(int));
			dataTable2.Columns.Add("name", typeof(string));
			base.SelectSqlData(dataTable2, true, " where ParentKey = ';Param;Terrain;' and deleted = 0 and isGroup = 0 ", false);
			dataTable2.Rows.Add(dataTable2.NewRow());
			DataView defaultView2 = dataTable2.DefaultView;
			defaultView2.Sort = "Name";
			this.comboBox_3.DataSource = defaultView2.ToTable();
			this.comboBox_3.DisplayMember = "name";
			this.comboBox_3.ValueMember = "id";
			this.comboBox_3.SelectedIndex = -1;
			DataTable dataTable3 = new DataTable("tP_ValueLists");
			dataTable3.Columns.Add("id", typeof(int));
			dataTable3.Columns.Add("Name", typeof(string));
			base.SelectSqlData(dataTable3, true, "where ParentKey = ';Param;RoadType;' and deleted = '0' and isGroup = '0'", false);
			dataTable3.Rows.Add(dataTable3.NewRow());
			DataView defaultView3 = dataTable3.DefaultView;
			defaultView3.Sort = "Name";
			this.comboBox_5.DataSource = defaultView3.ToTable();
			this.comboBox_5.DisplayMember = "Name";
			this.comboBox_5.ValueMember = "id";
			this.comboBox_5.SelectedIndex = -1;
		}

		private int method_8(int int_2)
		{
			string text = "select ISNULL(MAX(Number), 0) + 1 as Number FROM tP_CabSection\r\nwhere deleted = '0' and idObjList = " + int_2.ToString();
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToInt32(dataTable.Rows[0]["Number"]);
			}
			return 1;
		}

		private void method_9()
		{
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_ValueLists, true, "WHERE Deleted = ((0)) AND isGroup = ((0)) AND ParentKey = ';Param;Wire;Makeup;'");
			this.bindingSource_1.ResetBindings(false);
		}

		private bool method_10()
		{
			bool flag = true;
			if (Convert.ToInt32(this.dsPassport_0.tP_CabSection[0]["idClutchFirst"]) == -1)
			{
				new ToolTip().Show("!", this.textBox_5, 10, 5, 3000);
				flag = false;
			}
			if (Convert.ToInt32(this.dsPassport_0.tP_CabSection[0]["idClutchSecond"]) == -1)
			{
				new ToolTip().Show("!", this.textBox_6, 10, 5, 3000);
				flag = false;
			}
			if (!flag)
			{
				MessageBox.Show("Выберите опору.");
				return false;
			}
			if (!this.method_11())
			{
				return false;
			}
			if (!this.method_12())
			{
				return false;
			}
			if (this.numericUpDown_0.Value <= 0m)
			{
				new ToolTip().Show("!", this.numericUpDown_0, 10, 5, 3000);
				return false;
			}
			string text = string.Format("where idObjList = '{0}' and [Number] = '{1}' and deleted = '0'", this.IdAirLine, this.numericUpDown_0.Value);
			if (this.CreateState == 1)
			{
				text += string.Format(" and id <> '{0}'", this.IdSpan);
			}
			if (base.SelectSqlData("tP_CabSection", true, text).Rows.Count > 0)
			{
				new ToolTip().Show("!", this.numericUpDown_0, 10, 5, 3000);
				MessageBox.Show("Номер пролета не является уникальным.");
				return false;
			}
			if (this.nullableDateTimePicker_0.Value == null)
			{
				MessageBox.Show("Введите дату ввода в эксплуатацию.");
				return false;
			}
			return flag;
		}

		private bool method_11()
		{
			int idClutchFirst = this.dsPassport_0.tP_CabSection[0].idClutchFirst;
			int idClutchSecond = this.dsPassport_0.tP_CabSection[0].idClutchSecond;
			StringBuilder stringBuilder = new StringBuilder(string.Format("where idObjList = '{0}' and idClutchFirst = '{1}' and idClutchSecond = '{2}' and deleted = '0'", this.IdAirLine, idClutchFirst, idClutchSecond));
			if (this.CreateState == 1)
			{
				stringBuilder.AppendFormat(" and id <> '{0}'", this.IdSpan);
			}
			DataTable dataTable = new DataTable("tP_CabSection");
			base.SelectSqlData(dataTable, true, stringBuilder.ToString(), false);
			if (dataTable.Rows.Count > 0)
			{
				MessageBox.Show("Пролет с идентичными опорами уже существует.");
				return false;
			}
			return true;
		}

		private bool method_12()
		{
			int idClutchSecond = this.dsPassport_0.tP_CabSection[0].idClutchSecond;
			StringBuilder stringBuilder = new StringBuilder(string.Format("where idObjList = '{0}' and idClutchSecond = '{1}' and deleted = '0'", this.IdAirLine, idClutchSecond));
			if (this.CreateState == 1)
			{
				stringBuilder.AppendFormat(" and id <> '{0}'", this.IdSpan);
			}
			DataTable dataTable = new DataTable("tP_CabSection");
			base.SelectSqlData(dataTable, true, stringBuilder.ToString(), false);
			if (dataTable.Rows.Count > 0)
			{
				MessageBox.Show("Пролет c индентичной второй опорой уже существует.");
				return false;
			}
			return true;
		}

		private bool method_13()
		{
			StateFormCreate createState = this.CreateState;
			if (createState == null)
			{
				this.bindingSource_0.EndEdit();
				this.IdSpan = base.InsertSqlDataOneRow(this.dsPassport_0, this.dsPassport_0.tP_CabSection);
				return true;
			}
			if (createState == 1)
			{
				this.bindingSource_0.EndEdit();
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection);
				return true;
			}
			if (createState != 11)
			{
				return false;
			}
			this.bindingSource_0.EndEdit();
			this.dsPassport_0.tP_CabSection[0].AcceptChanges();
			this.dsPassport_0.tP_CabSection[0].SetAdded();
			this.IdSpan = base.InsertSqlDataOneRow(this.dsPassport_0, this.dsPassport_0.tP_CabSection);
			return true;
		}

		private void button_3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void textBox_4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\b')
			{
				return;
			}
			if (char.IsControl(e.KeyChar))
			{
				return;
			}
			string text = ((TextBox)sender).Text;
			if (char.IsDigit(e.KeyChar))
			{
				return;
			}
			if (e.KeyChar == '.')
			{
				e.KeyChar = ',';
			}
			if (e.KeyChar == ',')
			{
				if (text.IndexOf(',') != -1 && text.Length != 0)
				{
					e.Handled = true;
				}
				return;
			}
			e.Handled = true;
		}

		private void button_5_Click(object sender, EventArgs e)
		{
			FormCable formCable = new FormCable();
			formCable.FormClosed += this.method_14;
			formCable.MdiParent = base.MdiParent;
			formCable.SqlSettings = this.SqlSettings;
			formCable.ViewButtons = true;
			formCable.Show();
		}

		private void method_14(object sender, FormClosedEventArgs e)
		{
			FormCable formCable = (FormCable)sender;
			if (formCable.DialogResult == DialogResult.OK)
			{
				((dsPassport.Class58)((DataRowView)this.bindingSource_0.Current).Row).idEquipment = formCable.Id;
				this.method_15(formCable.Id, true);
			}
		}

		private void method_15(int int_2, bool bool_0)
		{
			DataTable dataTable = base.SelectSqlData("vR_Cable", true, "WHERE id = " + int_2.ToString());
			if (dataTable != null && dataTable.Rows.Count >= 0)
			{
				this.textBox_4.Text = dataTable.Rows[0]["CableMakeup"].ToString();
				if (bool_0)
				{
					this.textBox_1.Text = Convert.ToSingle(dataTable.Rows[0]["CrossSection"]).ToString();
					this.textBox_2.Text = Convert.ToInt32(dataTable.Rows[0]["Wires"]).ToString();
					this.textBox_3.Text = Convert.ToDouble(dataTable.Rows[0]["VoltageValue"]).ToString();
				}
				return;
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

		private void method_16()
		{
			this.icontainer_0 = new Container();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.comboBox_0 = new ComboBox();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsPassport_0 = new dsPassport();
			this.comboBox_1 = new ComboBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.label_4 = new Label();
			this.label_5 = new Label();
			this.label_6 = new Label();
			this.label_7 = new Label();
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.textBox_2 = new TextBox();
			this.textBox_3 = new TextBox();
			this.comboBox_2 = new ComboBox();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.numericUpDown_0 = new NumericUpDown();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.nullableDateTimePicker_0 = new NullableDateTimePicker();
			this.label_8 = new Label();
			this.button_4 = new Button();
			this.textBox_4 = new TextBox();
			this.button_5 = new Button();
			this.groupBox_0 = new GroupBox();
			this.textBox_5 = new TextBox();
			this.button_6 = new Button();
			this.button_7 = new Button();
			this.textBox_6 = new TextBox();
			this.groupBox_1 = new GroupBox();
			this.checkBox_0 = new CheckBox();
			this.textBox_7 = new TextBox();
			this.label_12 = new Label();
			this.comboBox_5 = new ComboBox();
			this.label_11 = new Label();
			this.comboBox_3 = new ComboBox();
			this.label_9 = new Label();
			this.comboBox_4 = new ComboBox();
			this.label_10 = new Label();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(276, 26);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(76, 13);
			this.label_0.TabIndex = 23;
			this.label_0.Text = "Вторая опора";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 26);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(78, 13);
			this.label_1.TabIndex = 24;
			this.label_1.Text = "Первая опора";
			this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "idClutchSecond", true));
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(393, 22);
			this.comboBox_0.Name = "cbSecondPole";
			this.comboBox_0.Size = new Size(113, 21);
			this.comboBox_0.TabIndex = 21;
			this.comboBox_0.Tag = "2";
			this.comboBox_0.Visible = false;
			this.bindingSource_0.DataMember = "tP_CabSection";
			this.bindingSource_0.DataSource = this.dsPassport_0;
			this.bindingSource_0.Sort = "";
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "idClutchFirst", true));
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(119, 22);
			this.comboBox_1.Name = "cbFirstPole";
			this.comboBox_1.Size = new Size(113, 21);
			this.comboBox_1.TabIndex = 19;
			this.comboBox_1.Tag = "1";
			this.comboBox_1.Visible = false;
			this.button_0.Image = Resources._1304662999_bullet_toggle_plus;
			this.button_0.Location = new Point(512, 21);
			this.button_0.Name = "btnAddPoleSecond";
			this.button_0.Size = new Size(23, 23);
			this.button_0.TabIndex = 5;
			this.button_0.Text = "...";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Image = Resources._1304662999_bullet_toggle_plus;
			this.button_1.Location = new Point(238, 21);
			this.button_1.Name = "btnAddPoleFirst";
			this.button_1.Size = new Size(23, 23);
			this.button_1.TabIndex = 2;
			this.button_1.UseVisualStyleBackColor = false;
			this.button_1.Click += this.button_1_Click;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 91);
			this.label_2.Name = "label8";
			this.label_2.Size = new Size(40, 13);
			this.label_2.TabIndex = 31;
			this.label_2.Text = "Длина";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(264, 50);
			this.label_3.Name = "label7";
			this.label_3.Size = new Size(72, 13);
			this.label_3.TabIndex = 33;
			this.label_3.Text = "Сечение жил";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(6, 50);
			this.label_4.Name = "label6";
			this.label_4.Size = new Size(89, 13);
			this.label_4.TabIndex = 32;
			this.label_4.Text = "Количество жил";
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(276, 91);
			this.label_5.Name = "label5";
			this.label_5.Size = new Size(71, 13);
			this.label_5.TabIndex = 34;
			this.label_5.Text = "Напряжение";
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(6, 23);
			this.label_6.Name = "label4";
			this.label_6.Size = new Size(85, 13);
			this.label_6.TabIndex = 36;
			this.label_6.Text = "Марка провода";
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(12, 64);
			this.label_7.Name = "label3";
			this.label_7.Size = new Size(83, 13);
			this.label_7.TabIndex = 35;
			this.label_7.Text = "Номер участка";
			this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Length", true));
			this.textBox_0.Location = new Point(119, 88);
			this.textBox_0.Name = "tbLength";
			this.textBox_0.Size = new Size(142, 20);
			this.textBox_0.TabIndex = 8;
			this.textBox_0.KeyPress += this.textBox_4_KeyPress;
			this.textBox_1.DataBindings.Add(new Binding("Text", this.bindingSource_0, "CrossSection", true));
			this.textBox_1.Location = new Point(381, 47);
			this.textBox_1.Name = "tbCrossSection";
			this.textBox_1.ReadOnly = true;
			this.textBox_1.Size = new Size(136, 20);
			this.textBox_1.TabIndex = 13;
			this.textBox_1.KeyPress += this.textBox_4_KeyPress;
			this.textBox_2.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Wires", true));
			this.textBox_2.Location = new Point(107, 47);
			this.textBox_2.Name = "tbWires";
			this.textBox_2.ReadOnly = true;
			this.textBox_2.Size = new Size(136, 20);
			this.textBox_2.TabIndex = 12;
			this.textBox_2.KeyPress += this.textBox_4_KeyPress;
			this.textBox_3.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Voltage", true));
			this.textBox_3.Location = new Point(393, 88);
			this.textBox_3.Name = "tbVoltage";
			this.textBox_3.Size = new Size(142, 20);
			this.textBox_3.TabIndex = 9;
			this.textBox_3.KeyPress += this.textBox_4_KeyPress;
			this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "CableMakeup", true));
			this.comboBox_2.DataSource = this.bindingSource_1;
			this.comboBox_2.DisplayMember = "Name";
			this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(107, 20);
			this.comboBox_2.Name = "cbCableMakeup";
			this.comboBox_2.Size = new Size(113, 21);
			this.comboBox_2.TabIndex = 26;
			this.comboBox_2.ValueMember = "id";
			this.comboBox_2.Visible = false;
			this.bindingSource_1.DataMember = "tP_ValueLists";
			this.bindingSource_1.DataSource = this.dsPassport_0;
			this.numericUpDown_0.DataBindings.Add(new Binding("Value", this.bindingSource_0, "Number", true));
			this.numericUpDown_0.Location = new Point(119, 62);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 100000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown_0.Name = "nudNumberSector";
			this.numericUpDown_0.Size = new Size(142, 20);
			this.numericUpDown_0.TabIndex = 6;
			this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(461, 401);
			this.button_2.Name = "btnCancel";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 20;
			this.button_2.Text = "Отмена";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_3_Click;
			this.button_3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_3.DialogResult = DialogResult.OK;
			this.button_3.Location = new Point(380, 401);
			this.button_3.Name = "btnSave";
			this.button_3.Size = new Size(75, 23);
			this.button_3.TabIndex = 19;
			this.button_3.Text = "Применить";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.Click += this.button_3_Click;
			this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.bindingSource_0, "YearCommissioning", true));
			this.nullableDateTimePicker_0.Location = new Point(393, 62);
			this.nullableDateTimePicker_0.Name = "dtpYearCommissioning";
			this.nullableDateTimePicker_0.Size = new Size(142, 20);
			this.nullableDateTimePicker_0.TabIndex = 7;
			this.nullableDateTimePicker_0.Value = new DateTime(2013, 3, 13, 20, 53, 45, 109);
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(276, 64);
			this.label_8.Name = "label12";
			this.label_8.Size = new Size(111, 13);
			this.label_8.TabIndex = 42;
			this.label_8.Text = "Дата ввода в экспл.";
			this.button_4.Image = Resources._1304662999_bullet_toggle_plus;
			this.button_4.Location = new Point(220, 18);
			this.button_4.Name = "btnAddWireMakeup";
			this.button_4.Size = new Size(23, 23);
			this.button_4.TabIndex = 43;
			this.button_4.UseVisualStyleBackColor = false;
			this.button_4.Visible = false;
			this.button_4.Click += this.button_4_Click;
			this.textBox_4.Location = new Point(107, 20);
			this.textBox_4.Name = "tbCableMakeup";
			this.textBox_4.ReadOnly = true;
			this.textBox_4.Size = new Size(136, 20);
			this.textBox_4.TabIndex = 11;
			this.textBox_4.KeyPress += this.textBox_4_KeyPress;
			this.button_5.Location = new Point(267, 18);
			this.button_5.Name = "btnEquipmentChoose";
			this.button_5.Size = new Size(250, 23);
			this.button_5.TabIndex = 10;
			this.button_5.Text = "Справочник";
			this.button_5.UseVisualStyleBackColor = true;
			this.button_5.Click += this.button_5_Click;
			this.groupBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_0.Controls.Add(this.button_5);
			this.groupBox_0.Controls.Add(this.textBox_4);
			this.groupBox_0.Controls.Add(this.textBox_2);
			this.groupBox_0.Controls.Add(this.textBox_1);
			this.groupBox_0.Controls.Add(this.label_6);
			this.groupBox_0.Controls.Add(this.label_4);
			this.groupBox_0.Controls.Add(this.label_3);
			this.groupBox_0.Controls.Add(this.comboBox_2);
			this.groupBox_0.Controls.Add(this.button_4);
			this.groupBox_0.Location = new Point(12, 114);
			this.groupBox_0.Name = "gbEquipment";
			this.groupBox_0.Size = new Size(523, 82);
			this.groupBox_0.TabIndex = 44;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Оборудование";
			this.textBox_5.Location = new Point(119, 23);
			this.textBox_5.Name = "tbFirstPyloneName";
			this.textBox_5.ReadOnly = true;
			this.textBox_5.Size = new Size(84, 20);
			this.textBox_5.TabIndex = 0;
			this.button_6.Image = Resources.grey_view_choose;
			this.button_6.Location = new Point(209, 21);
			this.button_6.Name = "btnChooseFirstPylone";
			this.button_6.Size = new Size(23, 23);
			this.button_6.TabIndex = 20;
			this.button_6.Tag = "1";
			this.button_6.UseVisualStyleBackColor = false;
			this.button_6.Click += this.button_7_Click;
			this.button_7.Image = Resources.grey_view_choose;
			this.button_7.Location = new Point(483, 20);
			this.button_7.Name = "button2";
			this.button_7.Size = new Size(23, 23);
			this.button_7.TabIndex = 4;
			this.button_7.Tag = "2";
			this.button_7.UseVisualStyleBackColor = false;
			this.button_7.Click += this.button_7_Click;
			this.textBox_6.Location = new Point(393, 22);
			this.textBox_6.Name = "tbSecondPyloneName";
			this.textBox_6.ReadOnly = true;
			this.textBox_6.Size = new Size(84, 20);
			this.textBox_6.TabIndex = 3;
			this.groupBox_1.Controls.Add(this.checkBox_0);
			this.groupBox_1.Controls.Add(this.textBox_7);
			this.groupBox_1.Controls.Add(this.label_12);
			this.groupBox_1.Controls.Add(this.comboBox_5);
			this.groupBox_1.Controls.Add(this.label_11);
			this.groupBox_1.Controls.Add(this.comboBox_3);
			this.groupBox_1.Controls.Add(this.label_9);
			this.groupBox_1.Controls.Add(this.comboBox_4);
			this.groupBox_1.Controls.Add(this.label_10);
			this.groupBox_1.Location = new Point(12, 202);
			this.groupBox_1.Name = "groupBox1";
			this.groupBox_1.Size = new Size(523, 179);
			this.groupBox_1.TabIndex = 45;
			this.groupBox_1.TabStop = false;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.DataBindings.Add(new Binding("Checked", this.bindingSource_0, "haveTree", true));
			this.checkBox_0.Location = new Point(168, 19);
			this.checkBox_0.Name = "chbHaveTree";
			this.checkBox_0.Size = new Size(120, 17);
			this.checkBox_0.TabIndex = 14;
			this.checkBox_0.Text = "Наличие деревьев";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.textBox_7.DataBindings.Add(new Binding("Text", this.bindingSource_0, "wayCharacteristic", true));
			this.textBox_7.Location = new Point(168, 125);
			this.textBox_7.Multiline = true;
			this.textBox_7.Name = "txtWayCharact";
			this.textBox_7.Size = new Size(297, 40);
			this.textBox_7.TabIndex = 18;
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(6, 128);
			this.label_12.Name = "label13";
			this.label_12.Size = new Size(86, 13);
			this.label_12.TabIndex = 6;
			this.label_12.Text = "Хар-ка проезда";
			this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_5.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "idRoadType", true));
			this.comboBox_5.FormattingEnabled = true;
			this.comboBox_5.Location = new Point(168, 98);
			this.comboBox_5.Name = "cmbRoadType";
			this.comboBox_5.Size = new Size(297, 21);
			this.comboBox_5.TabIndex = 17;
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(6, 101);
			this.label_11.Name = "label11";
			this.label_11.Size = new Size(110, 13);
			this.label_11.TabIndex = 4;
			this.label_11.Text = "Вид проезжей части";
			this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "idTerrain", true));
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(168, 71);
			this.comboBox_3.Name = "cmbTerrain";
			this.comboBox_3.Size = new Size(297, 21);
			this.comboBox_3.TabIndex = 16;
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(6, 74);
			this.label_9.Name = "label10";
			this.label_9.Size = new Size(147, 13);
			this.label_9.TabIndex = 2;
			this.label_9.Text = "Характеристика местности";
			this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_4.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "idCrossing", true));
			this.comboBox_4.FormattingEnabled = true;
			this.comboBox_4.Location = new Point(168, 42);
			this.comboBox_4.Name = "cmbCrossing";
			this.comboBox_4.Size = new Size(297, 21);
			this.comboBox_4.TabIndex = 15;
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(6, 45);
			this.label_10.Name = "label9";
			this.label_10.Size = new Size(135, 13);
			this.label_10.TabIndex = 0;
			this.label_10.Text = "Переходы и пересечения";
			base.AcceptButton = this.button_3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_2;
			base.ClientSize = new Size(548, 436);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.textBox_6);
			base.Controls.Add(this.textBox_5);
			base.Controls.Add(this.groupBox_0);
			base.Controls.Add(this.nullableDateTimePicker_0);
			base.Controls.Add(this.label_8);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_3);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_5);
			base.Controls.Add(this.label_7);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.textBox_3);
			base.Controls.Add(this.numericUpDown_0);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.button_7);
			base.Controls.Add(this.button_6);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.comboBox_1);
			base.Name = "FormAddEditAirLineSpan";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddEditAirLinePole";
			base.FormClosing += this.FormAddEditAirLineSpan_FormClosing;
			base.Load += this.FormAddEditAirLineSpan_Load;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private Button button_0;

		private Button button_1;

		private Label label_0;

		private Label label_1;

		private ComboBox comboBox_0;

		private ComboBox comboBox_1;

		private Label label_2;

		private Label label_3;

		private Label label_4;

		private Label label_5;

		private Label label_6;

		private Label label_7;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private TextBox textBox_2;

		private TextBox textBox_3;

		private ComboBox comboBox_2;

		private NumericUpDown numericUpDown_0;

		private Button button_2;

		private Button button_3;

		private NullableDateTimePicker nullableDateTimePicker_0;

		private Label label_8;

		private dsPassport dsPassport_0;

		private BindingSource bindingSource_0;

		private BindingSource bindingSource_1;

		private Button button_4;

		private TextBox textBox_4;

		private Button button_5;

		private GroupBox groupBox_0;

		private TextBox textBox_5;

		private Button button_6;

		private Button button_7;

		private TextBox textBox_6;

		private GroupBox groupBox_1;

		private ComboBox comboBox_3;

		private Label label_9;

		private ComboBox comboBox_4;

		private Label label_10;

		private ComboBox comboBox_5;

		private Label label_11;

		private CheckBox checkBox_0;

		private TextBox textBox_7;

		private Label label_12;
	}
}