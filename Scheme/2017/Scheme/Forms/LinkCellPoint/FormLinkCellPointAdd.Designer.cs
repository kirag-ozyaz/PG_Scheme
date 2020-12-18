using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using DataSql;
using FormLbr;

namespace Scheme.Forms.LinkCellPoint
{
	public class FormLinkCellPointAdd : FormBase
	{
		public override SQLSettings SqlSettings
		{
			get
			{
				return base.SqlSettings;
			}
			set
			{
				base.SqlSettings = value;
				if (value != null)
				{
					this.kladrStreetControl_0.SqlSettings = value;
				}
			}
		}

		public FormLinkCellPointAdd()
		{
			Class63.AGd1PxHzk5wxP();
			this.string_0 = "";
			this.string_1 = "";
			this.string_2 = "";
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_4();
			this.dateTimePicker_0.Value = DateTime.Now.Date;
			this.method_0();
		}

		public FormLinkCellPointAdd(int idSubstation, int idCell)
		{
			Class63.AGd1PxHzk5wxP();
			this.string_0 = "";
			this.string_1 = "";
			this.string_2 = "";
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_4();
			this.dateTimePicker_0.Value = DateTime.Now.Date;
			this.method_0();
			this.int_0 = idSubstation;
			this.int_1 = idCell;
		}

		private void method_0()
		{
			foreach (object obj in Enum.GetValues(typeof(SchmTypeSubstation)))
			{
				SchmTypeSubstation schmTypeSubstation = (SchmTypeSubstation)obj;
				this.string_0 = this.string_0 + Convert.ToInt32(schmTypeSubstation).ToString() + ",";
			}
			foreach (object obj2 in Enum.GetValues(typeof(SchmTypeCell)))
			{
				SchmTypeCell schmTypeCell = (SchmTypeCell)obj2;
				this.string_1 = this.string_1 + Convert.ToInt32(schmTypeCell).ToString() + ",";
			}
			this.bindingSource_0.Filter = "typeCodeId in (" + this.string_0.Remove(this.string_0.Length - 1) + ")";
			this.string_2 = this.string_0 + this.string_1;
			if (!string.IsNullOrEmpty(this.string_2))
			{
				this.string_2 = this.string_2.Remove(this.string_2.Length - 1);
			}
		}

		private void FormLinkCellPointAdd_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class19_0, this.class19_0.vSchm_ObjList, true, " where typeCodeId in (" + this.string_2 + ")");
			this.method_1();
			if (this.int_0 != -1)
			{
				this.comboBox_0.SelectedValue = this.int_0;
			}
			if (this.int_1 != -1)
			{
				this.comboBox_1.SelectedValue = this.int_1;
			}
		}

		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void method_1()
		{
			if (this.comboBox_0.SelectedValue != null)
			{
				this.bindingSource_1.Filter = "typecodeId in (" + this.string_1.Remove(this.string_1.Length - 1) + ") and idParent = " + this.comboBox_0.SelectedValue.ToString();
			}
		}

		private void method_2()
		{
			this.listBox_0.Items.Clear();
			if (this.kladrStreetControl_0.SelectedStreet.SelectedIndex >= 0)
			{
				string text = "";
				if (this.checkBox_1.Checked)
				{
					text = 206.ToString();
				}
				if (this.checkBox_0.Checked)
				{
					if (string.IsNullOrEmpty(text))
					{
						text = "207,231,230";
					}
					else
					{
						text += ",207,231,230";
					}
				}
				if (!string.IsNullOrEmpty(text))
				{
					base.SelectSqlData(this.dataTable_0, true, string.Concat(new string[]
					{
						" left join tAbnObj obj on tMapObj.idMap = obj.idMap  left join tAbn abn on abn.id = obj.idabn and abn.typeAbn in (",
						text,
						")  where not abn.id is null and tMapObj.Street = ",
						this.kladrStreetControl_0.SelectedStreet.SelectedValue.ToString(),
						" order by house, houseprefix"
					}), null, true, 0);
					foreach (object obj in this.dataSet_0.Tables["tMapObj"].Rows)
					{
						DataRow dataRow = (DataRow)obj;
						this.listBox_0.Items.Add(new FormLinkCellPointAdd.Class4(dataRow["House"].ToString() + dataRow["HousePrefix"].ToString(), Convert.ToInt32(dataRow["IdMap"])));
					}
				}
			}
		}

		private void kladrStreetControl_0_ChangeOblSelect(object sender, EventArgs e)
		{
			this.method_2();
		}

		private void kladrStreetControl_0_ChangeRaionOblSelect(object sender, EventArgs e)
		{
			this.method_2();
		}

		private void kladrStreetControl_0_ChangePunktsSelect(object sender, EventArgs e)
		{
			this.method_2();
		}

		private void kladrStreetControl_0_ChangeStreetSelect(object sender, EventArgs e)
		{
			this.method_2();
			this.method_3();
		}

		private void kladrStreetControl_0_ChangeTypeHouseSelect(object sender, EventArgs e)
		{
			if (((ComboBox)sender).SelectedIndex == ((ComboBox)sender).Items.Count - 1)
			{
				this.listBox_0.Enabled = true;
			}
			else
			{
				this.listBox_0.Enabled = false;
			}
			this.method_3();
		}

		private void checkBox_1_CheckedChanged(object sender, EventArgs e)
		{
			this.method_2();
			this.method_3();
		}

		private void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_3();
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedIndex < 0)
			{
				MessageBox.Show("Не выбрана ячейка");
				return;
			}
			int num = Convert.ToInt32(this.comboBox_1.SelectedValue);
			this.backgroundWorker_0.RunWorkerAsync(num);
		}

		private void method_3()
		{
			if (this.kladrStreetControl_0.SelectedStreet.SelectedIndex < 0)
			{
				this.class19_0.vMapObjAbnPoint.Clear();
				return;
			}
			if (this.kladrStreetControl_0.SelectedHouseType.SelectedIndex < 0)
			{
				this.class19_0.vMapObjAbnPoint.Clear();
				return;
			}
			string text = "";
			if (this.checkBox_1.Checked)
			{
				text = text + 206.ToString() + "," + 253.ToString();
			}
			if (this.checkBox_0.Checked)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += ",";
				}
				text += "207,231,230";
			}
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			int num = Convert.ToInt32(this.kladrStreetControl_0.SelectedHouseType.SelectedValue);
			string text2;
			if (num != -1)
			{
				if (num != 0)
				{
					text2 = string.Concat(new string[]
					{
						" where street =  ",
						this.kladrStreetControl_0.SelectedStreet.SelectedValue.ToString(),
						" and typeAbn in (",
						text,
						") and typeObjMap = ",
						this.kladrStreetControl_0.SelectedHouseType.SelectedValue.ToString()
					});
				}
				else
				{
					if (this.listBox_0.SelectedItems.Count <= 0)
					{
						this.class19_0.vMapObjAbnPoint.Clear();
						return;
					}
					string text3 = "";
					foreach (object obj in this.listBox_0.SelectedItems)
					{
						FormLinkCellPointAdd.Class4 @class = (FormLinkCellPointAdd.Class4)obj;
						text3 = text3 + @class.Id.ToString() + ",";
					}
					text2 = string.Concat(new string[]
					{
						" where idMap in ( ",
						text3.Remove(text3.Length - 1),
						") and typeAbn in (",
						text,
						")"
					});
				}
			}
			else
			{
				text2 = string.Concat(new string[]
				{
					" where street =  ",
					this.kladrStreetControl_0.SelectedStreet.SelectedValue.ToString(),
					" and typeAbn in (",
					text,
					")"
				});
			}
			base.SelectSqlData(this.class19_0, this.class19_0.vMapObjAbnPoint, true, text2);
		}

		private void dataGridView_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if ((int)this.dataGridView_0["typeAbnDgvColumn", e.RowIndex].Value != 206)
				{
					if ((int)this.dataGridView_0["typeAbnDgvColumn", e.RowIndex].Value != 253)
					{
						e.CellStyle.BackColor = Color.LightGray;
						return;
					}
				}
				e.CellStyle.BackColor = Color.White;
				return;
			}
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			int num = Convert.ToInt32(e.Argument);
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			try
			{
				sqlDataConnect.OpenConnection(this.SqlSettings);
				int count = this.class19_0.vMapObjAbnPoint.Rows.Count;
				int num2 = 1;
				foreach (object obj in this.class19_0.vMapObjAbnPoint.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					try
					{
						if (dataRow["idPoint"] != DBNull.Value)
						{
							int num3 = Convert.ToInt32(dataRow["idPoint"]);
							string cmdText = string.Concat(new string[]
							{
								"insert into tl_CellPoint(idSChmObj, idPoint)  select ",
								num.ToString(),
								" , ",
								num3.ToString(),
								" where not exists(select id from tl_CellPoint where idSChmObj = ",
								num.ToString(),
								" and idPoint = ",
								num3.ToString(),
								")"
							});
							SqlTransaction sqlTransaction = sqlDataConnect.Connection.BeginTransaction();
							SqlCommand sqlCommand = new SqlCommand(cmdText, sqlDataConnect.Connection);
							sqlCommand.Transaction = sqlTransaction;
							int num4;
							if (sqlCommand.ExecuteNonQuery() > 0)
							{
								sqlCommand.CommandText = "select IDENT_CURRENT('tL_CellPoint')";
								num4 = Convert.ToInt32(sqlCommand.ExecuteScalar());
							}
							else
							{
								sqlCommand.CommandText = "select id from tl_cellpoint where idsChmObj = " + num.ToString() + " and idPoint = " + num3.ToString();
								num4 = (int)sqlCommand.ExecuteScalar();
							}
							if (num4 > -1)
							{
								sqlCommand.CommandText = string.Concat(new string[]
								{
									"insert into tL_cellPointReg (idLink, OnPoint, DateChange)  values (",
									num4.ToString(),
									",",
									Convert.ToInt32(this.checkBox_2.Checked).ToString(),
									",'",
									this.dateTimePicker_0.Value.ToString("yyyyMMdd"),
									"')"
								});
								sqlCommand.ExecuteNonQuery();
							}
							sqlTransaction.Commit();
							this.backgroundWorker_0.ReportProgress(num2 * 100 / count);
							num2++;
						}
					}
					catch (Exception ex)
					{
						if (MessageBox.Show(ex.Message + "\n Продолжить привязку?", ex.Source, MessageBoxButtons.YesNo) == DialogResult.No)
						{
							break;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message, ex2.Source);
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
		}

		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.progressBar_0.Value = e.ProgressPercentage;
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

		private void method_4()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.class19_0 = new Class19();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.label_0 = new Label();
			this.comboBox_0 = new ComboBox();
			this.label_1 = new Label();
			this.comboBox_1 = new ComboBox();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.label_3 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.checkBox_2 = new CheckBox();
			this.label_2 = new Label();
			this.listBox_0 = new ListBox();
			this.kladrStreetControl_0 = new KladrStreetControl();
			this.groupBox_0 = new GroupBox();
			this.checkBox_0 = new CheckBox();
			this.checkBox_1 = new CheckBox();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.dataSet_0 = new DataSet();
			this.dataTable_0 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.button_0 = new Button();
			this.groupBox_1 = new GroupBox();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.progressBar_0 = new ProgressBar();
			((ISupportInitialize)this.class19_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			this.groupBox_1.SuspendLayout();
			base.SuspendLayout();
			this.class19_0.DataSetName = "DataSetScheme";
			this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.bindingSource_0.DataMember = "vSchm_ObjList";
			this.bindingSource_0.DataSource = this.class19_0;
			this.bindingSource_0.Sort = "TypeCode, Name";
			this.label_0.AutoSize = true;
			this.label_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label_0.Location = new Point(3, 13);
			this.label_0.Name = "labelSubstation";
			this.label_0.Size = new Size(68, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Подстанция";
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.DataSource = this.bindingSource_0;
			this.comboBox_0.DisplayMember = "NameType";
			this.comboBox_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(6, 29);
			this.comboBox_0.Name = "cmbSubstation";
			this.comboBox_0.Size = new Size(121, 21);
			this.comboBox_0.TabIndex = 2;
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			this.label_1.AutoSize = true;
			this.label_1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label_1.Location = new Point(3, 64);
			this.label_1.Name = "labelCell";
			this.label_1.Size = new Size(44, 13);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "Ячейки";
			this.comboBox_1.DataSource = this.bindingSource_1;
			this.comboBox_1.DisplayMember = "NameTypeSocr";
			this.comboBox_1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(6, 80);
			this.comboBox_1.Name = "cmbCell";
			this.comboBox_1.Size = new Size(121, 21);
			this.comboBox_1.TabIndex = 4;
			this.comboBox_1.ValueMember = "Id";
			this.bindingSource_1.DataMember = "vSchm_ObjList";
			this.bindingSource_1.DataSource = this.class19_0;
			this.bindingSource_1.Sort = "TypeCodeSocr, Name";
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Location = new Point(142, 0);
			this.tabControl_0.Name = "tabControlPoints";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(413, 242);
			this.tabControl_0.TabIndex = 5;
			this.tabPage_0.BackColor = SystemColors.Control;
			this.tabPage_0.Controls.Add(this.label_3);
			this.tabPage_0.Controls.Add(this.dateTimePicker_0);
			this.tabPage_0.Controls.Add(this.checkBox_2);
			this.tabPage_0.Controls.Add(this.label_2);
			this.tabPage_0.Controls.Add(this.listBox_0);
			this.tabPage_0.Controls.Add(this.kladrStreetControl_0);
			this.tabPage_0.Controls.Add(this.groupBox_0);
			this.tabPage_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPageMapObj";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(405, 216);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Дома";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(268, 174);
			this.label_3.Name = "label2";
			this.label_3.Size = new Size(33, 13);
			this.label_3.TabIndex = 6;
			this.label_3.Text = "Дата";
			this.dateTimePicker_0.Location = new Point(265, 190);
			this.dateTimePicker_0.Name = "dateTimePickerReg";
			this.dateTimePicker_0.Size = new Size(134, 20);
			this.dateTimePicker_0.TabIndex = 5;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Location = new Point(271, 154);
			this.checkBox_2.Name = "checkBoxOnPoint";
			this.checkBox_2.Size = new Size(131, 17);
			this.checkBox_2.TabIndex = 4;
			this.checkBox_2.Text = "Включить абонентов";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(174, 8);
			this.label_2.Name = "label1";
			this.label_2.Size = new Size(36, 13);
			this.label_2.TabIndex = 3;
			this.label_2.Text = "Дома";
			this.listBox_0.Enabled = false;
			this.listBox_0.FormattingEnabled = true;
			this.listBox_0.Location = new Point(177, 24);
			this.listBox_0.Name = "listBoxHouse";
			this.listBox_0.SelectionMode = SelectionMode.MultiSimple;
			this.listBox_0.Size = new Size(82, 186);
			this.listBox_0.TabIndex = 2;
			this.listBox_0.SelectedIndexChanged += this.listBox_0_SelectedIndexChanged;
			this.kladrStreetControl_0.Location = new Point(7, 8);
			this.kladrStreetControl_0.Margin = new Padding(4, 5, 4, 5);
			this.kladrStreetControl_0.Name = "kladrStreetControl";
			this.kladrStreetControl_0.Size = new Size(173, 208);
			this.kladrStreetControl_0.SqlSettings = null;
			this.kladrStreetControl_0.TabIndex = 1;
			this.kladrStreetControl_0.VisibleCmbTypeHouse = true;
			this.kladrStreetControl_0.ChangeOblSelect += this.kladrStreetControl_0_ChangeOblSelect;
			this.kladrStreetControl_0.ChangeRaionOblSelect += this.kladrStreetControl_0_ChangeRaionOblSelect;
			this.kladrStreetControl_0.ChangePunktsSelect += this.kladrStreetControl_0_ChangePunktsSelect;
			this.kladrStreetControl_0.ChangeStreetSelect += this.kladrStreetControl_0_ChangeStreetSelect;
			this.kladrStreetControl_0.ChangeTypeHouseSelect += this.kladrStreetControl_0_ChangeTypeHouseSelect;
			this.groupBox_0.Controls.Add(this.checkBox_0);
			this.groupBox_0.Controls.Add(this.checkBox_1);
			this.groupBox_0.Location = new Point(265, 6);
			this.groupBox_0.Name = "groupBoxMapObjTypeAbn";
			this.groupBox_0.Size = new Size(134, 69);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Типы абонентов";
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(6, 41);
			this.checkBox_0.Name = "checkBoxMapTypeUL";
			this.checkBox_0.Size = new Size(121, 17);
			this.checkBox_0.TabIndex = 1;
			this.checkBox_0.Text = "Юридическое лицо";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.CheckedChanged += this.checkBox_1_CheckedChanged;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Checked = true;
			this.checkBox_1.CheckState = CheckState.Checked;
			this.checkBox_1.Location = new Point(6, 19);
			this.checkBox_1.Name = "checkBoxMapAbnFL";
			this.checkBox_1.Size = new Size(117, 17);
			this.checkBox_1.TabIndex = 0;
			this.checkBox_1.Text = "Физическое лицо";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_1.CheckedChanged += this.checkBox_1_CheckedChanged;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridView_0.AutoGenerateColumns = false;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13
			});
			this.dataGridView_0.DataSource = this.bindingSource_2;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.Location = new Point(2, 246);
			this.dataGridView_0.Name = "dgvPoint";
			this.dataGridView_0.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(553, 226);
			this.dataGridView_0.TabIndex = 4;
			this.dataGridView_0.VirtualMode = true;
			this.dataGridView_0.CellFormatting += this.dataGridView_0_CellFormatting;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "CodeAbonent";
			this.dataGridViewTextBoxColumn_0.FillWeight = 20f;
			this.dataGridViewTextBoxColumn_0.HeaderText = "Код";
			this.dataGridViewTextBoxColumn_0.Name = "codeAbonentDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_1.FillWeight = 35f;
			this.dataGridViewTextBoxColumn_1.HeaderText = "Абонент";
			this.dataGridViewTextBoxColumn_1.Name = "nameDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "objName";
			this.dataGridViewTextBoxColumn_2.FillWeight = 35f;
			this.dataGridViewTextBoxColumn_2.HeaderText = "Объект";
			this.dataGridViewTextBoxColumn_2.Name = "objNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "pName";
			this.dataGridViewTextBoxColumn_3.FillWeight = 10f;
			this.dataGridViewTextBoxColumn_3.HeaderText = "Т.у.";
			this.dataGridViewTextBoxColumn_3.Name = "pNameDgvColumn";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "idMap";
			this.dataGridViewTextBoxColumn_4.HeaderText = "idMap";
			this.dataGridViewTextBoxColumn_4.Name = "idMapDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Street";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Street";
			this.dataGridViewTextBoxColumn_5.Name = "streetDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "House";
			this.dataGridViewTextBoxColumn_6.HeaderText = "House";
			this.dataGridViewTextBoxColumn_6.Name = "houseDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "HousePrefix";
			this.dataGridViewTextBoxColumn_7.HeaderText = "HousePrefix";
			this.dataGridViewTextBoxColumn_7.Name = "housePrefixDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "typeObjMAp";
			this.dataGridViewTextBoxColumn_8.HeaderText = "typeObjMAp";
			this.dataGridViewTextBoxColumn_8.Name = "typeObjMApDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "idPoint";
			this.dataGridViewTextBoxColumn_9.HeaderText = "idPoint";
			this.dataGridViewTextBoxColumn_9.Name = "idPointDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "DateBegin";
			this.dataGridViewTextBoxColumn_10.HeaderText = "DateBegin";
			this.dataGridViewTextBoxColumn_10.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "DateEnd";
			this.dataGridViewTextBoxColumn_11.HeaderText = "DateEnd";
			this.dataGridViewTextBoxColumn_11.Name = "dateEndDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "TypeAbn";
			this.dataGridViewTextBoxColumn_12.HeaderText = "TypeAbn";
			this.dataGridViewTextBoxColumn_12.Name = "typeAbnDgvColumn";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "StreetName";
			this.dataGridViewTextBoxColumn_13.HeaderText = "StreetName";
			this.dataGridViewTextBoxColumn_13.Name = "StreetNameDgvColumn";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.bindingSource_2.DataMember = "vMapObjAbnPoint";
			this.bindingSource_2.DataSource = this.class19_0;
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_0
			});
			this.dataTable_0.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2
			});
			this.dataTable_0.TableName = "tMapObj";
			this.dataColumn_0.ColumnName = "idMap";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "House";
			this.dataColumn_2.ColumnName = "HousePrefix";
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.button_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.button_0.Location = new Point(2, 487);
			this.button_0.Name = "buttonLink";
			this.button_0.Size = new Size(553, 23);
			this.button_0.TabIndex = 4;
			this.button_0.Text = "Привязать";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.groupBox_1.BackColor = SystemColors.Control;
			this.groupBox_1.Controls.Add(this.comboBox_0);
			this.groupBox_1.Controls.Add(this.label_0);
			this.groupBox_1.Controls.Add(this.label_1);
			this.groupBox_1.Controls.Add(this.comboBox_1);
			this.groupBox_1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.groupBox_1.Location = new Point(2, 6);
			this.groupBox_1.Name = "groupBoxSchm";
			this.groupBox_1.Size = new Size(134, 112);
			this.groupBox_1.TabIndex = 6;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Объект схемы";
			this.backgroundWorker_0.WorkerReportsProgress = true;
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.progressBar_0.Location = new Point(2, 212);
			this.progressBar_0.Name = "progressBar1";
			this.progressBar_0.Size = new Size(127, 23);
			this.progressBar_0.TabIndex = 7;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(556, 510);
			base.Controls.Add(this.progressBar_0);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.dataGridView_0);
			base.Controls.Add(this.tabControl_0);
			base.Name = "FormLinkCellPointAdd";
			this.Text = "Привязка точек учета.";
			base.Load += this.FormLinkCellPointAdd_Load;
			((ISupportInitialize)this.class19_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_0.PerformLayout();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			base.ResumeLayout(false);
		}

		private string string_0;

		private string string_1;

		private string string_2;

		private int int_0;

		private int int_1;

		private IContainer icontainer_0;

		private Class19 class19_0;

		private BindingSource bindingSource_0;

		private Label label_0;

		private ComboBox comboBox_0;

		private Label label_1;

		private ComboBox comboBox_1;

		private BindingSource bindingSource_1;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private GroupBox groupBox_0;

		private CheckBox checkBox_0;

		private CheckBox checkBox_1;

		private KladrStreetControl kladrStreetControl_0;

		private Label label_2;

		private ListBox listBox_0;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private BindingSource bindingSource_2;

		private Button button_0;

		private DataGridView dataGridView_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private GroupBox groupBox_1;

		private Label label_3;

		private DateTimePicker dateTimePicker_0;

		private CheckBox checkBox_2;

		private BackgroundWorker backgroundWorker_0;

		private ProgressBar progressBar_0;

		private class Class4
		{
			public string Name { get; set; }

			public int Id { get; set; }

			public Class4()
			{
				Class63.AGd1PxHzk5wxP();
				base..ctor();
			}

			public Class4(string string_1, int int_1)
			{
				Class63.AGd1PxHzk5wxP();
				base..ctor();
				this.Name = string_1;
				this.Id = int_1;
			}

			public override string ToString()
			{
				return this.Name;
			}

			[CompilerGenerated]
			private string string_0;

			[CompilerGenerated]
			private int int_0;
		}
	}
}
