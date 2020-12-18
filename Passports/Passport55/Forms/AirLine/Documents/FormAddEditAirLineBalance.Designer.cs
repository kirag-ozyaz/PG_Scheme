using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Constants;
using DataSql;
using FormLbr;
using Passport.DataSets;

namespace Passport.Forms.AirLine.Documents
{
	public class FormAddEditAirLineBalance : FormBase
	{
		public StateFormCreate CreateState { get; set; }

		public int IdDoc
		{
			get
			{
				return this.int_1;
			}
		}

		public FormAddEditAirLineBalance(int IdObjList, int IdDoc, decimal TypeDocValue)
		{
			this.method_20();
			this.int_0 = IdObjList;
			this.int_1 = IdDoc;
			this.decimal_0 = TypeDocValue;
		}

		private void FormAddEditAirLineBalance_Load(object sender, EventArgs e)
		{
			this.method_0();
			this.method_1();
			this.method_3();
			StateFormCreate createState = this.CreateState;
			if (createState == null)
			{
				this.method_4();
				this.method_11();
				return;
			}
			if (createState != 1)
			{
				return;
			}
			this.method_2();
			this.method_8();
		}

		private void FormAddEditAirLineBalance_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && !this.method_12())
			{
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
			}
		}

		private void method_0()
		{
			StateFormCreate createState = this.CreateState;
			if (createState != null)
			{
				if (createState == 1)
				{
					Control control = this.comboBox_1;
					this.comboBox_1.Visible = true;
					control.Enabled = true;
					Control control2 = this.numericUpDown_0;
					this.numericUpDown_0.Visible = false;
					control2.Enabled = false;
				}
			}
			else
			{
				Control control3 = this.comboBox_1;
				this.comboBox_1.Visible = false;
				control3.Enabled = false;
				Control control4 = this.numericUpDown_0;
				this.numericUpDown_0.Visible = true;
				control4.Enabled = true;
			}
			if (this.decimal_0 == Convert.ToDecimal(FormAddEditAirLineBalance.Enum7.const_0))
			{
				this.label_3.Text = "От кого";
				this.Text = "Принятие на баланс " + this.method_18(this.int_0);
				return;
			}
			if (this.decimal_0 == Convert.ToDecimal(FormAddEditAirLineBalance.Enum7.const_1))
			{
				this.label_3.Text = "Кто";
				this.Text = "Модернизация/реконструкция " + this.method_18(this.int_0);
			}
		}

		private void method_1()
		{
			base.SelectSqlData(this.dsDocuments_0.tAbn, true, "WHERE Deleted = ((0)) AND TypeAbn IN (207, 230, 231, 614, 683)", false);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.dsDocuments_0.tAbn;
			bindingSource.Sort = "Name";
			this.comboBox_0.DataSource = bindingSource;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
			this.comboBox_0.SelectedIndex = -1;
		}

		private void method_2()
		{
			DataTable dataTable = new DataTable("tSchm_ObjList");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("typeCodeId", typeof(int));
			string text = string.Format("where idParent = '{0}' and deleted = '0'\r\nand typeCodeId in (Select id from tR_Classifier where ParentKey = '{1}' and Value = '1'\r\nand deleted = '0' and isGroup = '0')", this.int_0, ";SCM;Sector;");
			base.SelectSqlData(dataTable, true, text, false);
			this.comboBox_1.DataSource = dataTable;
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.ValueMember = "id";
		}

		private void method_3()
		{
			this.dataTable_0 = new DataTable("tSchm_ObjList");
			this.dataTable_0.Columns.Add("id", typeof(int));
			this.dataTable_0.Columns.Add("Name", typeof(string));
			this.dataTable_0.Columns.Add("typeCodeId", typeof(int));
			string text = string.Format("WHERE ((idParent = '{0}' AND typeCodeId IN (SELECT id FROM tR_Classifier\r\nWHERE ParentKey = ';SCM;Pole;' and deleted = '0' AND isGroup = '0'))\r\nOR (id IN (SELECT idClutchFirst as idPylon FROM tP_CabSection\r\nWHERE idObjList = '{0}' and deleted = '0' UNION\r\nSELECT idClutchSecond as idPylon FROM tP_CabSection\r\nWHERE idObjList = '{0}' and deleted = '0'))) AND deleted = '0'", this.int_0);
			base.SelectSqlData(this.dataTable_0, true, text, false);
		}

		private void method_4()
		{
			this.method_5();
			this.method_6();
		}

		private void method_5()
		{
			DataRow dataRow = this.dsDocuments_0.tP_DocList.NewRow();
			dataRow["ParentId"] = -1;
			dataRow["idObjList"] = this.int_0;
			dataRow["dateDoc"] = this.dateTimePicker_0.Value;
			dataRow["typeDoc"] = this.method_19(";TypeDoc;tPassport;PS;", this.decimal_0);
			dataRow["isActive"] = true;
			dataRow["deleted"] = false;
			this.dsDocuments_0.tP_DocList.Rows.Add(dataRow);
		}

		private void method_6()
		{
			DataRow dataRow = this.dsDocuments_0.tSchm_ObjList.NewRow();
			dataRow["typeCodeId"] = this.method_19(";SCM;Sector;", 1m);
			dataRow["idParent"] = this.int_0;
			dataRow["deleted"] = false;
			this.dsDocuments_0.tSchm_ObjList.Rows.Add(dataRow);
		}

		private void method_7()
		{
			DataRow dataRow = this.dsDocuments_0.tP_BalanceEquipment.NewRow();
			dataRow["idDocList"] = -1;
			this.dsDocuments_0.tP_BalanceEquipment.Rows.Add(dataRow);
		}

		private void method_8()
		{
			this.method_9();
			this.method_10();
			this.method_11();
		}

		private void method_9()
		{
			base.SelectSqlData(this.dsDocuments_0.tP_DocList, true, string.Format("where id = '{0}'", this.int_1), false);
			if (this.dsDocuments_0.tP_DocList.Rows.Count > 0 && this.dsDocuments_0.tP_DocList[0]["DataXml"] != DBNull.Value)
			{
				this.method_17(Convert.ToString(this.dsDocuments_0.tP_DocList[0]["DataXml"]));
			}
		}

		private void method_10()
		{
			if (this.dsDocuments_0.tP_DocList.Rows.Count == 0)
			{
				this.method_6();
				return;
			}
			int num = -1;
			int.TryParse(this.dsDocuments_0.tP_DocList[0]["idSector"].ToString(), out num);
			base.SelectSqlData(this.dsDocuments_0.tSchm_ObjList, true, string.Format("where id = '{0}' and deleted = '0'", num), false);
		}

		private void method_11()
		{
			base.SelectSqlData(this.dsDocuments_0.tP_BalanceEquipment, true, string.Format("where idDocList = '{0}'", this.int_1), false);
		}

		private bool method_12()
		{
			if (!this.method_14())
			{
				return false;
			}
			StateFormCreate createState = this.CreateState;
			if (createState != null)
			{
				if (createState == 1)
				{
					this.dsDocuments_0.tP_DocList[0]["DataXml"] = this.method_16();
					this.dsDocuments_0.tP_DocList[0].EndEdit();
					base.UpdateSqlDataOnlyChange(this.dsDocuments_0.tP_DocList);
				}
			}
			else
			{
				this.dsDocuments_0.tSchm_ObjList[0]["Name"] = this.numericUpDown_0.Value.ToString();
				this.dsDocuments_0.tSchm_ObjList[0].EndEdit();
				int num = base.InsertSqlDataOneRow(this.dsDocuments_0.tSchm_ObjList[0]);
				if (num == -1)
				{
					return false;
				}
				this.dsDocuments_0.tP_DocList[0]["idSector"] = num;
				this.dsDocuments_0.tP_DocList[0]["DataXml"] = this.method_16();
				this.dsDocuments_0.tP_DocList[0].EndEdit();
				this.int_1 = base.InsertSqlDataOneRow(this.dsDocuments_0.tP_DocList[0]);
				if (this.int_1 == -1)
				{
					return false;
				}
			}
			return this.method_15();
		}

		private bool method_13()
		{
			foreach (object obj in this.dsDocuments_0.tP_BalanceEquipment.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				dataRow["idDocList"] = this.int_1;
				dataRow.EndEdit();
			}
			return base.UpdateSqlData(this.dsDocuments_0.tP_BalanceEquipment) && base.InsertSqlData(this.dsDocuments_0.tP_BalanceEquipment) && base.DeleteSqlData(this.dsDocuments_0.tP_BalanceEquipment);
		}

		private bool method_14()
		{
			StateFormCreate createState = this.CreateState;
			if (createState != null)
			{
				if (createState != 1)
				{
					return true;
				}
				if (this.comboBox_1.SelectedIndex == -1)
				{
					MessageBox.Show("Выберите участок.");
					return false;
				}
				int num = Convert.ToInt32(((DataRowView)this.comboBox_1.SelectedItem).Row["Name"]);
				return true;
			}
			else
			{
				if (this.numericUpDown_0.Value <= 0m)
				{
					MessageBox.Show("Номер участка должен быть больше нуля.");
					return false;
				}
				int num = Convert.ToInt32(this.numericUpDown_0.Value);
				DataTable dataTable = new DataTable("tSchm_ObjList");
				dataTable.Columns.Add("id", typeof(int));
				dataTable.Columns.Add("Name", typeof(string));
				dataTable.Columns.Add("typeCodeId", typeof(int));
				string text = string.Format("where idParent = '{0}' and deleted = '0' and Name = '{1}'\r\nand typeCodeId in (select id from tR_Classifier where ParentKey = '{2}' and Value = '1'\r\nand deleted = '0' and isGroup = '0')", this.int_0, num, ";SCM;Sector;");
				base.SelectSqlData(dataTable, true, text, false);
				if (dataTable.Rows.Count > 0)
				{
					MessageBox.Show(string.Format("На линии {0} уже имеется участок с номером - {1}.\r\nПожалуйста, выберите другой номер участка.", this.method_18(this.int_0), num));
					return false;
				}
				return true;
			}
		}

		private bool method_15()
		{
			if (this.dataGridView_0.NewRowIndex == 0)
			{
				StateFormCreate createState = this.CreateState;
				if (createState == null)
				{
					MessageBox.Show("Невозмжно создать документ. Добавьте хотя бы одну опору.");
					return false;
				}
				if (createState == 1)
				{
					string text = "Данный участок будет удален, поскольку на нем не соталось опор.\r\nЖелаете продолжить?";
					return DialogResult.OK == MessageBox.Show(text, "?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				}
			}
			return true;
		}

		private XDocument method_16()
		{
			XDocument xdocument = new XDocument();
			xdocument.Add(new XElement("AddlInfo", new object[]
			{
				new XAttribute("invNumber", this.textBox_1.Text),
				new XAttribute("idAbn", (this.comboBox_0.SelectedItem == null) ? string.Empty : ((DataRowView)this.comboBox_0.SelectedItem).Row["id"].ToString())
			}));
			return xdocument;
		}

		private void method_17(string string_0)
		{
			XElement root = XDocument.Load(new StringReader(string_0)).Root;
			this.textBox_1.Text = Convert.ToString(root.Attribute("invNumber").Value);
			int num;
			if (int.TryParse(root.Attribute("idAbn").Value, out num))
			{
				this.comboBox_0.SelectedValue = num;
			}
		}

		private string method_18(int int_2)
		{
			string text = "select ISNULL(c_ol.SocrName + ' - ', '') + ol.Name as FullName\r\nfrom tSchm_ObjList as ol\r\nleft join tR_Classifier as c_ol on c_ol.id = ol.typeCodeId\r\n" + string.Format("where ol.id = '{0}'", int_2);
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable != null && dataTable.Rows.Count > 0)
			{
				return Convert.ToString(dataTable.Rows[0]["FullName"]);
			}
			return string.Empty;
		}

		private int method_19(string string_0, decimal decimal_1)
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			string text = string.Format("where ParentKey = '{0}' and Value = '{1}'\r\n and deleted = '0' and isGroup = '0'", string_0, decimal_1);
			base.SelectSqlData(dataTable, true, text, false);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToInt32(dataTable.Rows[0]["id"]);
			}
			return -1;
		}

		private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (this.dataTable_0 == null)
			{
				return;
			}
			for (int i = 0; i < e.RowCount; i++)
			{
				DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dataGridView_0[this.dataGridViewComboBoxColumn_0.Name, e.RowIndex + i];
				dataGridViewComboBoxCell.DataSource = new BindingSource
				{
					DataSource = this.dataTable_0.Copy()
				};
				dataGridViewComboBoxCell.DisplayMember = "Name";
				dataGridViewComboBoxCell.ValueMember = "id";
			}
		}

		private void dataGridView_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value is string)
			{
				if (Convert.ToString(e.Value) == "deleted")
				{
					e.CellStyle.ForeColor = Color.Red;
					return;
				}
				if (Convert.ToString(e.Value) == "added")
				{
					e.CellStyle.ForeColor = Color.Green;
				}
			}
		}

		private void dataGridView_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (e.Control is DataGridViewComboBoxEditingControl)
			{
				DataGridViewComboBoxEditingControl dataGridViewComboBoxEditingControl = (DataGridViewComboBoxEditingControl)e.Control;
				dataGridViewComboBoxEditingControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				dataGridViewComboBoxEditingControl.AutoCompleteSource = AutoCompleteSource.ListItems;
				dataGridViewComboBoxEditingControl.DropDownStyle = ComboBoxStyle.DropDown;
				BindingSource bindingSource = (BindingSource)dataGridViewComboBoxEditingControl.DataSource;
				if (bindingSource != null)
				{
					bindingSource.Filter = string.Empty;
					StringBuilder stringBuilder = new StringBuilder();
					DataGridView dataGridView = (DataGridView)sender;
					foreach (object obj in ((IEnumerable)dataGridView.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if ((dataGridView.CurrentCell == null || dataGridView.CurrentCell.RowIndex != dataGridViewRow.Index) && dataGridViewRow.Cells[this.dataGridViewComboBoxColumn_0.Index].Value != null)
						{
							stringBuilder.AppendFormat(",{0}", dataGridViewRow.Cells[this.dataGridViewComboBoxColumn_0.Index].Value);
						}
					}
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Remove(0, 1);
						bindingSource.Filter = string.Format("id not in ({0})", stringBuilder);
					}
					if (dataGridView.CurrentCell != null && dataGridView.CurrentCell.Value != null)
					{
						dataGridViewComboBoxEditingControl.SelectedValue = dataGridView.CurrentCell.Value;
					}
				}
			}
		}

		private void dataGridView_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			e.ThrowException = false;
			e.Cancel = true;
		}

		private void dataGridView_0_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			object value = dataGridView.Rows[e.RowIndex].HeaderCell.Value;
			if (value == null || !value.Equals((e.RowIndex + 1).ToString()))
			{
				dataGridView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_20()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			this.label_0 = new Label();
			this.textBox_0 = new TextBox();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.textBox_1 = new TextBox();
			this.label_3 = new Label();
			this.comboBox_0 = new ComboBox();
			this.label_4 = new Label();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.numericUpDown_0 = new NumericUpDown();
			this.comboBox_1 = new ComboBox();
			this.label_5 = new Label();
			this.dataGridView_0 = new DataGridView();
			this.label_6 = new Label();
			this.richTextBox_0 = new RichTextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsDocuments_0 = new dsDocuments();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 41);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(86, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Номер приказа";
			this.textBox_0.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_DocList.NumberDoc", true));
			this.textBox_0.Location = new Point(104, 38);
			this.textBox_0.Name = "txtDocNum";
			this.textBox_0.Size = new Size(127, 20);
			this.textBox_0.TabIndex = 2;
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dsDocuments_0, "tP_DocList.DateDoc", true));
			this.dateTimePicker_0.Location = new Point(104, 12);
			this.dateTimePicker_0.Name = "dtpDateDoc";
			this.dateTimePicker_0.Size = new Size(127, 20);
			this.dateTimePicker_0.TabIndex = 1;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 15);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(78, 13);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "Дата приказа";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 67);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(44, 13);
			this.label_2.TabIndex = 4;
			this.label_2.Text = "Инв. №";
			this.textBox_1.Location = new Point(104, 64);
			this.textBox_1.Name = "txtInvNum";
			this.textBox_1.Size = new Size(127, 20);
			this.textBox_1.TabIndex = 3;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(12, 93);
			this.label_3.Name = "lblWho";
			this.label_3.Size = new Size(46, 13);
			this.label_3.TabIndex = 6;
			this.label_3.Text = "От кого";
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(104, 90);
			this.comboBox_0.Name = "cmbCompany";
			this.comboBox_0.Size = new Size(193, 21);
			this.comboBox_0.TabIndex = 4;
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(12, 119);
			this.label_4.Name = "label5";
			this.label_4.Size = new Size(83, 13);
			this.label_4.TabIndex = 8;
			this.label_4.Text = "Номер участка";
			this.tableLayoutPanel_0.ColumnCount = 1;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Controls.Add(this.numericUpDown_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 0, 1);
			this.tableLayoutPanel_0.Location = new Point(104, 117);
			this.tableLayoutPanel_0.Name = "tlpSectorNum";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel_0.Size = new Size(127, 42);
			this.tableLayoutPanel_0.TabIndex = 9;
			this.numericUpDown_0.DataBindings.Add(new Binding("Value", this.dsDocuments_0, "tSchm_ObjList.Name", true));
			this.numericUpDown_0.Dock = DockStyle.Fill;
			this.numericUpDown_0.Location = new Point(0, 0);
			this.numericUpDown_0.Margin = new Padding(0);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 100000000;
			numericUpDown.Maximum = new decimal(array);
			NumericUpDown numericUpDown2 = this.numericUpDown_0;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown_0.Name = "nudSectorNum";
			this.numericUpDown_0.Size = new Size(127, 20);
			this.numericUpDown_0.TabIndex = 5;
			NumericUpDown numericUpDown3 = this.numericUpDown_0;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dsDocuments_0, "tP_DocList.idSector", true));
			this.comboBox_1.Dock = DockStyle.Fill;
			this.comboBox_1.Enabled = false;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(0, 20);
			this.comboBox_1.Margin = new Padding(0);
			this.comboBox_1.Name = "cmbSectorNum";
			this.comboBox_1.Size = new Size(127, 21);
			this.comboBox_1.TabIndex = 5;
			this.comboBox_1.Visible = false;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(12, 146);
			this.label_5.Name = "label6";
			this.label_5.Size = new Size(80, 13);
			this.label_5.TabIndex = 10;
			this.label_5.Text = "Оборудование";
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.BackgroundColor = SystemColors.Window;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewComboBoxColumn_0,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5
			});
			this.dataGridView_0.DataSource = this.bindingSource_0;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.Location = new Point(15, 165);
			this.dataGridView_0.Name = "dgvEquipment";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.CellSelect;
			this.dataGridView_0.Size = new Size(378, 150);
			this.dataGridView_0.TabIndex = 6;
			this.dataGridView_0.CellFormatting += this.dataGridView_0_CellFormatting;
			this.dataGridView_0.DataError += this.dataGridView_0_DataError;
			this.dataGridView_0.EditingControlShowing += this.dataGridView_0_EditingControlShowing;
			this.dataGridView_0.RowPrePaint += this.dataGridView_0_RowPrePaint;
			this.dataGridView_0.RowsAdded += this.dataGridView_0_RowsAdded;
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(12, 321);
			this.label_6.Margin = new Padding(3, 3, 3, 0);
			this.label_6.Name = "label7";
			this.label_6.Size = new Size(70, 13);
			this.label_6.TabIndex = 12;
			this.label_6.Text = "Примечание";
			this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_DocList.Comment", true));
			this.richTextBox_0.Location = new Point(15, 337);
			this.richTextBox_0.Name = "rtxtComment";
			this.richTextBox_0.Size = new Size(378, 66);
			this.richTextBox_0.TabIndex = 7;
			this.richTextBox_0.Text = "";
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(318, 424);
			this.button_0.Name = "btnCancel";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 9;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_1_Click;
			this.button_1.DialogResult = DialogResult.OK;
			this.button_1.Location = new Point(237, 424);
			this.button_1.Name = "btnOK";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 8;
			this.button_1.Text = "ОК";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "idDocList";
			dataGridViewCellStyle4.NullValue = "-1";
			this.dataGridViewTextBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn_1.HeaderText = "idDocList";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "action";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Статус";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewComboBoxColumn_0.DataPropertyName = "idEquipment";
			this.dataGridViewComboBoxColumn_0.HeaderText = "Наименование";
			this.dataGridViewComboBoxColumn_0.Name = "idEquipmentDgvEquipment";
			this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewComboBoxColumn_0.Width = 150;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_3.HeaderText = "id";
			this.dataGridViewTextBoxColumn_3.Name = "idDgvEquipment";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "idDocList";
			this.dataGridViewTextBoxColumn_4.HeaderText = "idDocList";
			this.dataGridViewTextBoxColumn_4.Name = "idDocListDgvEquipment";
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "action";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Статус";
			this.dataGridViewTextBoxColumn_5.Name = "actionDgvEquipment";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.bindingSource_0.DataMember = "tP_BalanceEquipment";
			this.bindingSource_0.DataSource = this.dsDocuments_0;
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AcceptButton = this.button_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(405, 460);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.richTextBox_0);
			base.Controls.Add(this.label_6);
			base.Controls.Add(this.dataGridView_0);
			base.Controls.Add(this.label_5);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Controls.Add(this.label_4);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.dateTimePicker_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Name = "FormAddEditAirLineBalance";
			this.Text = "Принятие на баланс";
			base.FormClosing += this.FormAddEditAirLineBalance_FormClosing;
			base.Load += this.FormAddEditAirLineBalance_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0 = -1;

		private int int_1 = -1;

		private decimal decimal_0 = -1m;

		private DataTable dataTable_0;

		[CompilerGenerated]
		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private Label label_0;

		private TextBox textBox_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_1;

		private Label label_2;

		private TextBox textBox_1;

		private Label label_3;

		private ComboBox comboBox_0;

		private Label label_4;

		private TableLayoutPanel tableLayoutPanel_0;

		private NumericUpDown numericUpDown_0;

		private ComboBox comboBox_1;

		private Label label_5;

		private DataGridView dataGridView_0;

		private Label label_6;

		private RichTextBox richTextBox_0;

		private Button button_0;

		private Button button_1;

		private BindingSource bindingSource_0;

		private dsDocuments dsDocuments_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private enum Enum7
		{
			const_0 = 1,
			const_1 = 7
		}
	}
}
