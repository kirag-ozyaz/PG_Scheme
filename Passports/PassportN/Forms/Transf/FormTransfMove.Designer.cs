using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Passport.Classes;

namespace Passport.Forms.Transf
{
	public class FormTransfMove : FormBase
	{
		public string Direction
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

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

		public bool AllowUserToAddMoveTransf
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public FormTransfMove()
		{
			Class330.Mus9JxKz1CNxy();
			this.string_0 = "";
			this.bindingSource_0 = new BindingSource();
			base..ctor();
			this.method_10();
		}

		public FormTransfMove(SQLSettings sqlSettings, int idTransf)
		{
			Class330.Mus9JxKz1CNxy();
			this.string_0 = "";
			this.bindingSource_0 = new BindingSource();
			base..ctor();
			this.method_10();
			this.SqlSettings = sqlSettings;
			this.int_0 = idTransf;
		}

		private TransfMove method_0()
		{
			if (((DataRowView)this.comboBox_0.SelectedItem)[1].ToString().IndexOf("Сетевой") > -1)
			{
				if (!this.bool_0)
				{
					return TransfMove.ToSubstation;
				}
				return TransfMove.AddToSubstation;
			}
			else if (((DataRowView)this.comboBox_0.SelectedItem)[1].ToString().IndexOf("Склад 4") > -1)
			{
				if (!this.bool_0)
				{
					return TransfMove.ToWarehouse_4;
				}
				return TransfMove.AddToWarehouse_4;
			}
			else if (((DataRowView)this.comboBox_0.SelectedItem)[1].ToString().IndexOf("Склад") > -1)
			{
				if (!this.bool_0)
				{
					return TransfMove.ToWarehouse;
				}
				return TransfMove.AddToWarehouse;
			}
			else if (((DataRowView)this.comboBox_0.SelectedItem)[1].ToString().IndexOf("Цех") > -1)
			{
				if (!this.bool_0)
				{
					return TransfMove.ToRapairShop;
				}
				return TransfMove.AddToRepairShop;
			}
			else
			{
				if (((DataRowView)this.comboBox_0.SelectedItem)[1].ToString().IndexOf("Списан") > -1)
				{
					return TransfMove.Dispose;
				}
				return TransfMove.None;
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			Class324 @class = new Class324(this.SqlSettings);
			try
			{
				if ((decimal)((DataRowView)this.comboBox_4.SelectedItem)[2] == 2m)
				{
					switch (this.method_0())
					{
					case TransfMove.ToSubstation:
						if (!Class323.smethod_1(this.SqlSettings, this.int_0, this.comboBox_3.SelectedValue.ToString(), this.dateTimePicker_0.Value, (!this.comboBox_2.Enabled || this.comboBox_2.SelectedValue == null) ? ((int)this.comboBox_5.SelectedValue) : ((int)this.comboBox_2.SelectedValue), this.string_0, (int)this.comboBox_4.SelectedValue, this.textBox_0.Text))
						{
							return;
						}
						break;
					case TransfMove.ToWarehouse:
					case TransfMove.ToWarehouse_4:
					case TransfMove.ToRapairShop:
						if (!Class323.smethod_0(this.SqlSettings, this.int_0, (int)this.comboBox_0.SelectedValue, this.dateTimePicker_0.Value, this.string_0, ((DataRowView)this.comboBox_0.SelectedItem)[1].ToString(), (int)this.comboBox_4.SelectedValue, this.textBox_0.Text))
						{
							return;
						}
						break;
					case TransfMove.AddToSubstation:
						if (!@class.method_20(this.int_0, -1, -1, -1, -1, "", "", "", "", this.dateTimePicker_0.Value, (int)this.comboBox_4.SelectedValue, this.comboBox_1.Text, this.textBox_0.Text, false))
						{
							throw new Exception("Move to substation errors.", new Exception("Insert data in tSchm_Move caused the exception. FormTransMove.cs Line: ###"));
						}
						@class.method_4();
						break;
					case TransfMove.AddToWarehouse:
					case TransfMove.AddToRepairShop:
					case TransfMove.AddToWarehouse_4:
						if (!@class.method_20(this.int_0, -1, -1, -1, -1, "", "", "", "", this.dateTimePicker_0.Value, (int)this.comboBox_4.SelectedValue, ((DataRowView)this.comboBox_0.SelectedItem)[1].ToString(), this.textBox_0.Text, false))
						{
							throw new Exception("Move to substation errors.", new Exception("Insert data in tSchm_Move caused the exception. FormTransMove.cs Line: ###"));
						}
						@class.method_4();
						break;
					case TransfMove.Dispose:
						Class323.smethod_2(this.SqlSettings, this.int_0, this.dateTimePicker_0.Value, this.textBox_0.Text);
						break;
					}
				}
				else
				{
					if (!@class.method_20(this.int_0, -1, -1, -1, -1, "", "", "", "", this.dateTimePicker_0.Value, (int)this.comboBox_4.SelectedValue, "", this.textBox_0.Text, false))
					{
						throw new Exception("Add testing/repair data errors.", new Exception("Insert data in tSchm_Move caused the exception. FormTransMove.cs Line: ###"));
					}
					@class.method_4();
				}
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
			catch (Exception)
			{
				@class.method_5();
			}
			finally
			{
				@class.method_0();
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void FormTransfMove_Load(object sender, EventArgs e)
		{
			Class324 @class = new Class324(this.SqlSettings);
			try
			{
				@class = new Class324(this.SqlSettings);
				this.comboBox_0.DataSource = this.method_1();
				this.comboBox_0.DisplayMember = "Name";
				this.comboBox_0.ValueMember = "Id";
				this.comboBox_4.DataSource = this.method_2();
				this.comboBox_4.DisplayMember = "Name";
				this.comboBox_4.ValueMember = "Id";
				this.method_7();
				@class.method_4();
			}
			catch (Exception)
			{
				@class.method_5();
			}
			finally
			{
				@class.method_0();
			}
		}

		private DataTable method_1()
		{
			string text = "WHERE (ParentKey = ';NetworkAreas;' OR ParentKey = ';Passport;ObjLocation;' AND Value NOT IN (2, 8)) AND Deleted = ((0)) AND IsGroup = ((0))";
			return new SqlDataCommand(this.SqlSettings).SelectSqlData(this.class107_0.tR_Classifier.TableName, true, text, null);
		}

		private DataTable method_2()
		{
			string commandText = "SELECT Id, Name, Value FROM tR_Classifier WHERE ParentKey = ';Passport;MoveAction;' AND IsGroup = 0 AND Deleted = 0";
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand
			{
				Connection = this.method_8(this.SqlSettings),
				CommandType = CommandType.Text,
				CommandText = commandText
			});
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			return dataTable;
		}

		private DataTable method_3(int int_1)
		{
			string commandText = "SELECT DISTINCT o.id, ISNULL(o_c.SocrName + ' - ' + o.Name, o.Name) AS Name FROM tSchm_ObjList AS o INNER JOIN tR_Classifier AS o_c ON o.TypeCodeId = o_c.Id INNER JOIN tP_Passport AS p ON o.id = p.idObjList INNER JOIN tP_ObjectChar AS c ON p.Id = c.idPassport WHERE c.idObjChar = 86 AND c.Value = " + int_1.ToString() + " AND o.Deleted = ((0)) ORDER BY ISNULL(o_c.SocrName + ' - ' + o.Name, o.Name)";
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand
			{
				Connection = this.method_8(this.SqlSettings),
				CommandType = CommandType.Text,
				CommandText = commandText
			});
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			return dataTable;
		}

		private BindingSource method_4(int int_1)
		{
			string commandText = string.Format("SELECT o.id, ISNULL(o_c.SocrName + ' - ' + o.Name, o.Name) AS Name, o_c.ParentKey FROM tSchm_ObjList AS o JOIN tR_Classifier AS o_c ON o.TypeCodeId = o_c.Id WHERE (o_c.ParentKey LIKE ';SCM;BUS;%' OR o_c.ParentKey LIKE ';SCM;Line;%') AND (o.IdParent = {0} OR o.IdParentAddl = {0}) AND o.Deleted = ((0)) ORDER BY ISNULL(o_c.SocrName + ' - ' + o.Name, o.Name)", int_1);
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = this.method_8(this.SqlSettings);
			sqlCommand.Connection.Open();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = commandText;
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlCommand.Connection.Close();
			return new BindingSource
			{
				DataSource = dataTable
			};
		}

		private DataTable method_5(int int_1)
		{
			string commandText = "SELECT edge.id, ISNULL(c.SocrName + ' - ' + edge.Name, edge.Name) AS Name FROM tSchm_ObjList AS o JOIN tSchm_ObjList AS point on o.id = point.IdParent JOIN tSchm_Relation  on point.id = tSchm_Relation.SourceObj or point.id = tSchm_Relation.DestObj JOIN tSchm_ObjList as edge on tSchm_Relation.Edge = edge.id JOIN tR_Classifier as c on edge.TypeCodeId = c.id WHERE c.ParentKey LIKE ';SCM;Cell;%' AND o.Id = " + int_1.ToString() + " AND edge.Deleted = ((0)) ORDER BY ISNULL(c.SocrName + ' - ' + edge.Name, edge.Name)";
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = this.method_8(this.SqlSettings);
			sqlCommand.Connection.Open();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = commandText;
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlCommand.Connection.Close();
			return dataTable;
		}

		private DataTable method_6(int int_1)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Id", typeof(int));
			dataTable.Columns.Add("Name", typeof(int));
			for (int i = 0; i < 11; i++)
			{
				dataTable.Rows.Add(new object[]
				{
					i,
					i
				});
			}
			return dataTable;
		}

		private void method_7()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Id", typeof(int));
			dataTable.Columns.Add("Name", typeof(int));
			for (int i = 0; i < 11; i++)
			{
				dataTable.Rows.Add(new object[]
				{
					i,
					i
				});
			}
			this.comboBox_3.DataSource = dataTable;
			this.comboBox_3.ValueMember = "Name";
			this.comboBox_3.ValueMember = "Id";
			string commandText = "SELECT right(Name, 1 + len(Name) - patindex('%[0-9]%', Name)) AS NUMBER FROM tSchm_objlist WHERE ISNUMERIC(right(Name, 1 + len(Name) - patindex('%[0-9]%', Name))) = 1 AND id = " + this.int_0.ToString();
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = this.method_8(this.SqlSettings);
			sqlCommand.Connection.Open();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = commandText;
			int num;
			if (int.TryParse(Convert.ToString(sqlCommand.ExecuteScalar()), out num) && num <= 10)
			{
				this.comboBox_3.SelectedValue = num;
				return;
			}
			this.comboBox_3.SelectedValue = 0;
		}

		private SqlConnection method_8(SQLSettings sqlsettings_0)
		{
			if (sqlsettings_0.Autentification.ToUpper() == "WINDOWS")
			{
				return new SqlConnection(string.Concat(new string[]
				{
					"Server=",
					sqlsettings_0.ServerDB,
					"; dataBase=",
					sqlsettings_0.DBName,
					"; Integrated Security=true; Connection TimeOut = 180"
				}));
			}
			return new SqlConnection(string.Concat(new string[]
			{
				"Server=",
				sqlsettings_0.ServerDB,
				"; dataBase=",
				sqlsettings_0.DBName,
				"; uid=",
				sqlsettings_0.SqlUserConnect,
				";pwd=",
				sqlsettings_0.SqlPasswConnect,
				";Integrated Security=false; Connection TimeOut = 180"
			}));
		}

		private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = ((DataRowView)this.comboBox_0.SelectedItem)[1].ToString().IndexOf("Сетевой район") > -1;
			this.comboBox_5.Enabled = flag;
			this.comboBox_1.Enabled = flag;
			this.comboBox_2.Enabled = flag;
			this.comboBox_3.Enabled = flag;
			if (flag && this.comboBox_0.SelectedValue.GetType() != typeof(DataRowView))
			{
				this.comboBox_1.DataSource = Class320.smethod_3(this.SqlSettings, (int)this.comboBox_0.SelectedValue);
				this.comboBox_1.DisplayMember = "FullName";
				this.comboBox_1.ValueMember = "Id";
			}
		}

		private void comboBox_4_SelectedValueChanged(object sender, EventArgs e)
		{
			this.comboBox_5.Enabled = (this.comboBox_1.Enabled = (this.comboBox_2.Enabled = (this.comboBox_3.Enabled = (this.comboBox_0.Enabled = ((decimal)((DataRowView)this.comboBox_4.SelectedItem)[2] == 2m)))));
		}

		private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedValue != null && this.comboBox_1.SelectedValue.GetType() != typeof(DataRowView))
			{
				this.bindingSource_0 = this.method_4((int)this.comboBox_1.SelectedValue);
				this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
				this.comboBox_5.DataSource = this.bindingSource_0;
				this.comboBox_5.DisplayMember = "Name";
				this.comboBox_5.ValueMember = "Id";
				this.method_9();
			}
		}

		private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
		{
			this.method_9();
		}

		private void method_9()
		{
			if (this.bindingSource_0.Current != null)
			{
				if (((DataRowView)this.bindingSource_0.Current)["ParentKey"].ToString().IndexOf(";SCM;Line;") == -1)
				{
					this.comboBox_2.Enabled = true;
					this.comboBox_2.DataSource = this.method_5((int)this.comboBox_5.SelectedValue);
					this.comboBox_2.DisplayMember = "Name";
					this.comboBox_2.ValueMember = "Id";
					return;
				}
				this.comboBox_2.Enabled = false;
			}
		}

		private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormTransfMove.j739EDVzbE1CpnF7f73(this, disposing);
		}

		private void method_10()
		{
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.aeCmEzItBig = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.comboBox_1 = new ComboBox();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.label_4 = new Label();
			this.textBox_0 = new TextBox();
			this.comboBox_2 = new ComboBox();
			this.comboBox_3 = new ComboBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_5 = new Label();
			this.comboBox_5 = new ComboBox();
			this.label_6 = new Label();
			this.comboBox_4 = new ComboBox();
			this.comboBox_0 = new ComboBox();
			this.class107_0 = new Class107();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.class107_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 4;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30f));
			this.tableLayoutPanel_0.Controls.Add(this.aeCmEzItBig, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.dateTimePicker_0, 1, 1);
			this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.label_1, 0, 4);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 1, 4);
			this.tableLayoutPanel_0.Controls.Add(this.label_2, 0, 6);
			this.tableLayoutPanel_0.Controls.Add(this.label_3, 0, 7);
			this.tableLayoutPanel_0.Controls.Add(this.label_4, 0, 8);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 1, 8);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_2, 1, 6);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_3, 1, 7);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 9);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 9);
			this.tableLayoutPanel_0.Controls.Add(this.label_5, 0, 3);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_5, 1, 5);
			this.tableLayoutPanel_0.Controls.Add(this.label_6, 0, 5);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_4, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_0, 1, 3);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 10;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 41f));
			this.tableLayoutPanel_0.Size = new Size(333, 301);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.aeCmEzItBig.AutoSize = true;
			this.aeCmEzItBig.Dock = DockStyle.Fill;
			this.aeCmEzItBig.Location = new Point(3, 10);
			this.aeCmEzItBig.Name = "label1";
			this.aeCmEzItBig.Size = new Size(104, 25);
			this.aeCmEzItBig.TabIndex = 8;
			this.aeCmEzItBig.Text = "Дата";
			this.aeCmEzItBig.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.dateTimePicker_0, 3);
			this.dateTimePicker_0.Dock = DockStyle.Fill;
			this.dateTimePicker_0.Location = new Point(113, 13);
			this.dateTimePicker_0.Name = "dtpDate";
			this.dateTimePicker_0.Size = new Size(217, 20);
			this.dateTimePicker_0.TabIndex = 0;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Fill;
			this.label_0.Location = new Point(3, 35);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(104, 25);
			this.label_0.TabIndex = 9;
			this.label_0.Text = "Действие";
			this.label_0.TextAlign = ContentAlignment.MiddleRight;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Fill;
			this.label_1.Location = new Point(3, 85);
			this.label_1.Name = "label3";
			this.label_1.Size = new Size(104, 25);
			this.label_1.TabIndex = 10;
			this.label_1.Text = "Подстанция";
			this.label_1.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_1, 3);
			this.comboBox_1.Dock = DockStyle.Fill;
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(113, 88);
			this.comboBox_1.Name = "cbSubstation";
			this.comboBox_1.Size = new Size(217, 21);
			this.comboBox_1.TabIndex = 2;
			this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
			this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
			this.label_2.AutoSize = true;
			this.label_2.Dock = DockStyle.Fill;
			this.label_2.Location = new Point(3, 135);
			this.label_2.Name = "label4";
			this.label_2.Size = new Size(104, 25);
			this.label_2.TabIndex = 11;
			this.label_2.Text = "Ячейка";
			this.label_2.TextAlign = ContentAlignment.MiddleRight;
			this.label_3.AutoSize = true;
			this.label_3.Dock = DockStyle.Fill;
			this.label_3.Location = new Point(3, 160);
			this.label_3.Name = "label5";
			this.label_3.Size = new Size(104, 25);
			this.label_3.TabIndex = 12;
			this.label_3.Text = "Новый №";
			this.label_3.TextAlign = ContentAlignment.MiddleRight;
			this.label_4.AutoSize = true;
			this.label_4.Dock = DockStyle.Fill;
			this.label_4.Location = new Point(3, 185);
			this.label_4.Name = "label6";
			this.label_4.Size = new Size(104, 75);
			this.label_4.TabIndex = 13;
			this.label_4.Text = "Комментарий";
			this.label_4.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.textBox_0, 3);
			this.textBox_0.Dock = DockStyle.Fill;
			this.textBox_0.Location = new Point(113, 188);
			this.textBox_0.Multiline = true;
			this.textBox_0.Name = "tbComment";
			this.textBox_0.Size = new Size(217, 69);
			this.textBox_0.TabIndex = 5;
			this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_2, 3);
			this.comboBox_2.Dock = DockStyle.Fill;
			this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(113, 138);
			this.comboBox_2.Name = "cbCell";
			this.comboBox_2.Size = new Size(217, 21);
			this.comboBox_2.TabIndex = 3;
			this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_3, 3);
			this.comboBox_3.Dock = DockStyle.Fill;
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(113, 163);
			this.comboBox_3.Name = "cbTransfNumber";
			this.comboBox_3.Size = new Size(217, 21);
			this.comboBox_3.TabIndex = 4;
			this.button_0.Dock = DockStyle.Fill;
			this.button_0.Location = new Point(140, 270);
			this.button_0.Margin = new Padding(30, 10, 10, 10);
			this.button_0.Name = "btnMove";
			this.button_0.Size = new Size(96, 21);
			this.button_0.TabIndex = 6;
			this.button_0.Text = "Переместить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.tableLayoutPanel_0.SetColumnSpan(this.button_1, 2);
			this.button_1.Dock = DockStyle.Fill;
			this.button_1.Location = new Point(256, 270);
			this.button_1.Margin = new Padding(10);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(67, 21);
			this.button_1.TabIndex = 7;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.label_5.AutoSize = true;
			this.label_5.Dock = DockStyle.Fill;
			this.label_5.Location = new Point(3, 60);
			this.label_5.Name = "label7";
			this.label_5.Size = new Size(104, 25);
			this.label_5.TabIndex = 14;
			this.label_5.Text = "Направление";
			this.label_5.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_5, 3);
			this.comboBox_5.Dock = DockStyle.Fill;
			this.comboBox_5.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_5.FormattingEnabled = true;
			this.comboBox_5.Location = new Point(113, 113);
			this.comboBox_5.Name = "cbBus";
			this.comboBox_5.Size = new Size(217, 21);
			this.comboBox_5.TabIndex = 16;
			this.label_6.AutoSize = true;
			this.label_6.Dock = DockStyle.Fill;
			this.label_6.Location = new Point(3, 110);
			this.label_6.Name = "label8";
			this.label_6.Size = new Size(104, 25);
			this.label_6.TabIndex = 17;
			this.label_6.Text = "Шина / Кабель";
			this.label_6.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_4, 3);
			this.comboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_4.FormattingEnabled = true;
			this.comboBox_4.Location = new Point(113, 38);
			this.comboBox_4.Name = "cbAction";
			this.comboBox_4.Size = new Size(217, 21);
			this.comboBox_4.TabIndex = 15;
			this.comboBox_4.SelectedValueChanged += this.comboBox_4_SelectedValueChanged;
			this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_0, 3);
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(113, 63);
			this.comboBox_0.Name = "cbDirection";
			this.comboBox_0.Size = new Size(217, 21);
			this.comboBox_0.TabIndex = 1;
			this.comboBox_0.SelectedValueChanged += this.comboBox_0_SelectedValueChanged;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(333, 301);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.MaximizeBox = false;
			base.Name = "FormTransfMove";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Перемещение";
			base.Load += this.FormTransfMove_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			((ISupportInitialize)this.class107_0).EndInit();
			base.ResumeLayout(false);
		}

		internal static void j739EDVzbE1CpnF7f73(Form form_0, bool bool_1)
		{
			form_0.Dispose(bool_1);
		}

		private int int_0;

		private string string_0;

		private bool bool_0;

		private BindingSource bindingSource_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private Label aeCmEzItBig;

		private DateTimePicker dateTimePicker_0;

		private Label label_0;

		private Label label_1;

		private ComboBox comboBox_0;

		private ComboBox comboBox_1;

		private Label label_2;

		private Label label_3;

		private Label label_4;

		private TextBox textBox_0;

		private ComboBox comboBox_2;

		private ComboBox comboBox_3;

		private Button button_0;

		private Button button_1;

		private Class107 class107_0;

		private Label label_5;

		private ComboBox comboBox_4;

		private ComboBox comboBox_5;

		private Label label_6;
	}
}
