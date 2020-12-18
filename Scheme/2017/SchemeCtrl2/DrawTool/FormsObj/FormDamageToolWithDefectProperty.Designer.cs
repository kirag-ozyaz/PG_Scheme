using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ControlsLbr;
using FormLbr;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public class FormDamageToolWithDefectProperty : FormBase
	{
		public FormDamageToolWithDefectProperty(LineTool lineDefect = null)
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.method_17();
			this.dateTimePicker_0.Value = DateTime.Now;
			this.dateTimePicker_1.Value = DateTime.Now;
			this.lineTool_0 = lineDefect;
		}

		private void FormDamageToolWithDefectProperty_Load(object sender, EventArgs e)
		{
			this.ItOqdmucME();
			this.method_8();
			this.method_7();
			this.method_9();
			this.method_11();
			DataRow dataRow = this.dataTable_0.NewRow();
			dataRow["dateOwner"] = DateTime.Now;
			this.dataTable_0.Rows.Add(dataRow);
			this.method_0();
			this.method_16();
			this.method_15();
			this.method_10();
		}

		private void method_0()
		{
			if (this.lineTool_0 != null)
			{
				List<DrawObjectBase> powerSource = this.lineTool_0.GetPowerSource();
				bool flag = false;
				bool flag2 = false;
				foreach (DrawObjectBase drawObjectBase in powerSource)
				{
					if (drawObjectBase is BranchCollection && !flag)
					{
						using (IEnumerator<Branch> enumerator2 = ((BranchCollection)drawObjectBase).Collection.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								Branch branch = enumerator2.Current;
								if (branch.Parent is LineCellTool && !flag)
								{
									this.dataTable_0.Rows[0]["idSChmObj"] = branch.Parent.IdBase;
									object obj = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
									{
										branch.Parent.IdBase.ToString()
									});
									if (obj != null)
									{
										this.textBox_4.Text = obj.ToString();
									}
									flag = true;
									break;
								}
							}
							goto IL_1FA;
						}
						goto IL_106;
					}
					goto IL_1FA;
					IL_16E:
					if (drawObjectBase is ShinaTool && !flag2)
					{
						if (((ShinaTool)drawObjectBase).TypeShinaTool == eTypeShinaTool.Shina_023)
						{
							goto IL_1C9;
						}
						if (((ShinaTool)drawObjectBase).TypeShinaTool == eTypeShinaTool.Shina_04)
						{
							goto IL_1C9;
						}
						this.dataTable_0.Rows[0]["typeDoc"] = 1844;
						IL_1EE:
						flag2 = true;
						goto IL_1F0;
						IL_1C9:
						this.dataTable_0.Rows[0]["typeDoc"] = 1403;
						goto IL_1EE;
					}
					IL_1F0:
					if (flag2 && flag)
					{
						break;
					}
					continue;
					IL_106:
					if (!flag)
					{
						this.dataTable_0.Rows[0]["idSChmObj"] = drawObjectBase.IdBase;
						object obj2 = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
						{
							drawObjectBase.IdBase.ToString()
						});
						if (obj2 != null)
						{
							this.textBox_4.Text = obj2.ToString();
						}
						flag = true;
						goto IL_16E;
					}
					goto IL_16E;
					IL_1FA:
					if (drawObjectBase is LineCellTool)
					{
						goto IL_106;
					}
					goto IL_16E;
				}
				if (!flag2)
				{
					DataTable dataTable = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Напряжение'", this.lineTool_0.IdBase));
					if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["CharValue"] == DBNull.Value)
					{
						this.checkBox_1.Checked = false;
						this.checkBox_1.Enabled = false;
						return;
					}
					decimal d;
					if (!decimal.TryParse(dataTable.Rows[0]["CharValue"].ToString(), out d))
					{
						this.checkBox_1.Checked = false;
						this.checkBox_1.Enabled = false;
						return;
					}
					if (d > 1m)
					{
						this.dataTable_0.Rows[0]["typeDoc"] = 1844;
						return;
					}
					this.dataTable_0.Rows[0]["typeDoc"] = 1403;
					return;
				}
			}
			else
			{
				this.checkBox_1.Checked = false;
				this.checkBox_1.Enabled = false;
			}
		}

		private void FormDamageToolWithDefectProperty_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult != DialogResult.OK)
			{
				base.DialogResult = DialogResult.Cancel;
				return;
			}
			if (this.checkBox_1.Checked)
			{
				if (!this.method_1() || !this.method_2())
				{
					base.DialogResult = DialogResult.None;
					e.Cancel = true;
					return;
				}
				int? nullable_ = this.method_3();
				if (nullable_ == null)
				{
					base.DialogResult = DialogResult.None;
					e.Cancel = true;
					return;
				}
				if (this.checkBox_0.Checked)
				{
					base.DialogResult = DialogResult.OK;
					return;
				}
				if (this.method_6(nullable_))
				{
					base.DialogResult = DialogResult.OK;
					return;
				}
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
				return;
			}
			else
			{
				if (this.checkBox_0.Checked)
				{
					base.DialogResult = DialogResult.OK;
					return;
				}
				if (this.method_6(null))
				{
					base.DialogResult = DialogResult.OK;
					return;
				}
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
				return;
			}
		}

		private bool method_1()
		{
			bool flag = true;
			if (Convert.ToDateTime(this.dateTimePicker_0.Value).Year < 2016 && string.IsNullOrEmpty(this.textBox_0.Text))
			{
				this.label_2.ForeColor = Color.Red;
				flag = false;
			}
			if (this.comboBoxReadOnly_1.SelectedIndex < 0)
			{
				this.label_4.ForeColor = Color.Red;
				flag = false;
			}
			if (string.IsNullOrEmpty(this.textBox_4.Text))
			{
				this.label_15.ForeColor = Color.Red;
				flag = false;
			}
			if (this.comboBoxReadOnly_5.SelectedIndex < 0)
			{
				this.label_14.ForeColor = Color.Red;
				flag = false;
			}
			if (this.dataGridView_0.Rows.Count <= 1)
			{
				this.label_13.ForeColor = Color.Red;
				flag = false;
			}
			if (!flag)
			{
				MessageBox.Show("Не заполнены обязательный поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return flag;
		}

		private bool method_2()
		{
			if (this.dataTable_0.Rows.Count > 0)
			{
				DataTable dataTable = new DataTable("tJ_Damage");
				dataTable.Columns.Add("id", typeof(int));
				dataTable.Columns.Add("numREquest", typeof(string));
				dataTable.Columns.Add("dateDoc", typeof(DateTime));
				int num = Convert.ToInt32(this.dataTable_0.Rows[0]["TypeDoc"]);
				base.SelectSqlData(dataTable, true, string.Format("where numRequest = '{0}' and year(dateDoc) = {1} and typeDoc = {2} and id <> {3} and idDivision = {4}", new object[]
				{
					this.dataTable_0.Rows[0]["numRequest"].ToString(),
					this.dateTimePicker_0.Value.Year,
					num,
					this.dataTable_0.Rows[0]["id"].ToString(),
					Convert.ToInt32(this.dataTable_0.Rows[0]["idDivision"])
				}), null, false, 0);
				return dataTable.Rows.Count <= 0 || MessageBox.Show(string.Format("Заявка с номером {0} в текущем году уже была. Хотите все равно сохранить?", dataTable.Rows[0]["numRequest"].ToString()), "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
			}
			return true;
		}

		private int? method_3()
		{
			if (this.comboBoxReadOnly_3.SelectedIndex >= 0 && !string.IsNullOrEmpty(this.textBox_3.Text))
			{
				int num = this.method_5();
				if (num == -1)
				{
					MessageBox.Show("Не удается создать объект - дом");
					return null;
				}
				this.dataTable_0.Rows[0]["idMap"] = num;
			}
			else
			{
				this.dataTable_0.Rows[0]["idMap"] = DBNull.Value;
			}
			this.dataTable_0.Rows[0]["dateDoc"] = this.dateTimePicker_0.Value;
			int num2 = base.InsertSqlDataOneRow(this.dataTable_0.Rows[0]);
			if (num2 == -1)
			{
				return null;
			}
			if (!this.method_4(num2))
			{
				return null;
			}
			return new int?(num2);
		}

		private bool method_4(int int_0)
		{
			base.SelectSqlData(this.dataTable_2, true, "where idDamage = " + int_0.ToString(), null, false, 0);
			for (int i = this.dataGridView_0.Rows.Count - 1; i < this.dataTable_2.Rows.Count; i++)
			{
				this.dataTable_2.Rows[i].Delete();
			}
			for (int j = 0; j < this.dataGridView_0.Rows.Count - 1; j++)
			{
				if (j < this.dataTable_2.Rows.Count)
				{
					this.dataTable_2.Rows[j]["idDamage"] = int_0;
					if (this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_0.Name].Value != null)
					{
						this.dataTable_2.Rows[j]["col1"] = this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_0.Name].Value;
					}
					else
					{
						this.dataTable_2.Rows[j]["col1"] = DBNull.Value;
					}
					if (this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_2.Name].Value != null)
					{
						this.dataTable_2.Rows[j]["col2"] = this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_2.Name].Value;
					}
					else
					{
						this.dataTable_2.Rows[j]["col2"] = DBNull.Value;
					}
					if (this.dataGridView_0.Rows[j].Cells[this.sjjgoXoOy0.Name].Value != null)
					{
						this.dataTable_2.Rows[j]["col3"] = this.dataGridView_0.Rows[j].Cells[this.sjjgoXoOy0.Name].Value;
					}
					else
					{
						this.dataTable_2.Rows[j]["col3"] = DBNull.Value;
					}
					if (this.dataGridView_0.Rows[j].Cells[this.dataGridViewTextBoxColumn_1.Name].Value != null)
					{
						this.dataTable_2.Rows[j]["idSchmObj"] = this.dataGridView_0.Rows[j].Cells[this.dataGridViewTextBoxColumn_1.Name].Value;
					}
					else
					{
						this.dataTable_2.Rows[j]["idSchmObj"] = DBNull.Value;
					}
					if (this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_1.Name].Value != null)
					{
						this.dataTable_2.Rows[j]["idLineSection"] = this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_1.Name].Value;
					}
					else
					{
						this.dataTable_2.Rows[j]["idLineSection"] = DBNull.Value;
					}
					this.dataTable_2.Rows[j].EndEdit();
				}
				else
				{
					DataRow dataRow = this.dataTable_2.NewRow();
					dataRow["idDamage"] = int_0;
					if (this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_0.Name].Value != null)
					{
						dataRow["col1"] = this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_0.Name].Value;
					}
					if (this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_2.Name].Value != null)
					{
						dataRow["col2"] = this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_2.Name].Value;
					}
					if (this.dataGridView_0.Rows[j].Cells[this.sjjgoXoOy0.Name].Value != null)
					{
						dataRow["col3"] = this.dataGridView_0.Rows[j].Cells[this.sjjgoXoOy0.Name].Value;
					}
					if (this.dataGridView_0.Rows[j].Cells[this.dataGridViewTextBoxColumn_1.Name].Value != null)
					{
						dataRow["idSchmObj"] = this.dataGridView_0.Rows[j].Cells[this.dataGridViewTextBoxColumn_1.Name].Value;
					}
					if (this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_1.Name].Value != null)
					{
						dataRow["idLineSection"] = this.dataGridView_0.Rows[j].Cells[this.dataGridViewComboBoxColumn_1.Name].Value;
					}
					this.dataTable_2.Rows.Add(dataRow);
				}
			}
			if (!base.DeleteSqlData(this.dataTable_2))
			{
				return false;
			}
			if (!base.UpdateSqlData(this.dataTable_2))
			{
				return false;
			}
			if (!base.InsertSqlData(this.dataTable_2))
			{
				return false;
			}
			base.SelectSqlData(this.dataTable_2, true, "where idDamage = " + int_0.ToString(), null, false, 0);
			return true;
		}

		private int method_5()
		{
			string text = string.IsNullOrEmpty(this.textBox_2.Text) ? " and HousePrefix is null " : (" and HousePrefix = '" + this.textBox_2.Text + "'");
			base.SelectSqlData(this.dataTable_1, true, string.Concat(new string[]
			{
				"where Street = ",
				this.comboBoxReadOnly_3.SelectedValue.ToString(),
				" and House = ",
				this.textBox_3.Text,
				text,
				" and IsHouse = 1 and Name is null"
			}), null, false, 0);
			if (this.dataTable_1.Rows.Count > 0)
			{
				return Convert.ToInt32(this.dataTable_1.Rows[0]["idMap"]);
			}
			DataRow dataRow = this.dataTable_1.NewRow();
			dataRow["Street"] = this.comboBoxReadOnly_3.SelectedValue;
			dataRow["House"] = this.textBox_3.Text;
			if (!string.IsNullOrEmpty(this.textBox_2.Text))
			{
				dataRow["HousePrefix"] = this.textBox_2.Text;
			}
			dataRow["IsHouse"] = true;
			dataRow["Deleted"] = 0;
			this.dataTable_1.Rows.Add(dataRow);
			this.dataTable_1.Rows[0].EndEdit();
			return base.InsertSqlDataOneRow(this.dataTable_1.Rows[0]);
		}

		private bool method_6(int? nullable_0 = null)
		{
			if (this.lineTool_0 == null)
			{
				return true;
			}
			Class22.Class44 @class = new Class22.Class44();
			DataRow dataRow = @class.NewRow();
			dataRow["idObjList"] = this.lineTool_0.IdBase;
			dataRow["DateDecommissioning"] = this.dateTimePicker_0.Value;
			dataRow["Reason"] = this.comboBox_0.SelectedValue;
			dataRow["Deleted"] = false;
			if (nullable_0 != null)
			{
				dataRow["idDamage"] = nullable_0;
			}
			@class.Rows.Add(dataRow);
			return base.InsertSqlData(@class);
		}

		private void ItOqdmucME()
		{
			DataTable dataSource = base.SelectSqlData("tP_ValueLists", false, "where ParentKey like ';Cable;Addl;OperReason;' and isGroup = 0");
			this.comboBox_0.DataSource = dataSource;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
		}

		private void method_7()
		{
			DataTable dataTable = new DataTable("vWorkerGroup");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("FIO", typeof(string));
			dataTable.Columns.Add("idGroup", typeof(int));
			base.SelectSqlData(dataTable, true, "where ParentKey like ';GroupWorker;DailyReport;' and dateEnd is null order by fio ", null, false, 0);
			this.comboBoxReadOnly_1.DisplayMember = "FIO";
			this.comboBoxReadOnly_1.ValueMember = "id";
			this.comboBoxReadOnly_1.DataSource = dataTable;
			this.comboBoxReadOnly_1.SelectedIndex = -1;
		}

		private DataTable vxmqmLrOsk()
		{
			return new DataTable("tR_Classifier")
			{
				Columns = 
				{
					{
						"id",
						typeof(int)
					},
					{
						"name",
						typeof(string)
					}
				}
			};
		}

		private void method_8()
		{
			DataTable dataTable = this.vxmqmLrOsk();
			base.SelectSqlData(dataTable, true, " where ParentKey = ';GroupWorker;DailyREport;' and isgroup = 0 and deleted = 0", null, false, 0);
			this.comboBoxReadOnly_0.DisplayMember = "name";
			this.comboBoxReadOnly_0.ValueMember = "id";
			this.comboBoxReadOnly_0.DataSource = dataTable;
			this.comboBoxReadOnly_0.SelectedIndex = -1;
		}

		private void method_9()
		{
			DataTable dataTable = this.vxmqmLrOsk();
			base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;DamageReason;LV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
			this.comboBoxReadOnly_5.DisplayMember = "name";
			this.comboBoxReadOnly_5.ValueMember = "id";
			this.comboBoxReadOnly_5.DataSource = dataTable;
			this.comboBoxReadOnly_5.SelectedIndex = -1;
		}

		private void method_10()
		{
			DataTable dataTable = new DataTable("tUser");
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Columns.Add("idWorker", typeof(string));
			base.SelectSqlData(dataTable, true, "where [login] = SYSTEM_USER", null, false, 0);
			if (dataTable.Rows.Count > 0)
			{
				if (dataTable.Rows[0]["name"] != DBNull.Value)
				{
					this.textBox_1.Text = dataTable.Rows[0]["name"].ToString();
				}
				if (dataTable.Rows[0]["idWorker"] != DBNull.Value)
				{
					DataRow[] array = ((DataTable)this.comboBoxReadOnly_1.DataSource).Select("id = " + dataTable.Rows[0]["idWorker"]);
					if (array.Count<DataRow>() > 0 && this.dataTable_0.Rows.Count > 0)
					{
						this.dataTable_0.Rows[0]["idCompiler"] = array[0]["id"];
					}
				}
			}
		}

		private void comboBoxReadOnly_1_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.dataTable_0.Rows.Count > 0)
			{
				if (this.comboBoxReadOnly_1.SelectedValue == null)
				{
					this.comboBoxReadOnly_0.SelectedValue = null;
					return;
				}
				this.label_4.ForeColor = Color.Black;
				DataRow[] array = ((DataTable)this.comboBoxReadOnly_1.DataSource).Select("id = " + this.comboBoxReadOnly_1.SelectedValue.ToString());
				if (array.Count<DataRow>() > 0)
				{
					this.comboBoxReadOnly_0.SelectedValue = array[0]["idGRoup"];
				}
			}
		}

		private void method_11()
		{
			DataTable dataTable = FormDamageToolWithDefectProperty.smethod_0();
			base.SelectSqlData(dataTable, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
			this.LgtgjZhXlu.DisplayMember = "fullname";
			this.LgtgjZhXlu.ValueMember = "id";
			this.LgtgjZhXlu.DataSource = dataTable;
		}

		private void LgtgjZhXlu_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.LgtgjZhXlu.SelectedIndex < 0)
			{
				this.comboBoxReadOnly_2.DataSource = null;
				return;
			}
			this.label_7.ForeColor = Color.Black;
			DataTable dataTable = FormDamageToolWithDefectProperty.smethod_0();
			base.SelectSqlData(dataTable, true, " where ParentId = " + this.LgtgjZhXlu.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
			this.comboBoxReadOnly_2.DisplayMember = "fullname";
			this.comboBoxReadOnly_2.ValueMember = "id";
			this.comboBoxReadOnly_2.DataSource = dataTable;
			this.comboBoxReadOnly_2.SelectedIndex = -1;
		}

		private void comboBoxReadOnly_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBoxReadOnly_2.SelectedIndex < 0)
			{
				this.comboBoxReadOnly_4.DataSource = null;
				this.comboBoxReadOnly_3.DataSource = null;
				return;
			}
			this.label_9.ForeColor = Color.Black;
			DataTable dataTable = FormDamageToolWithDefectProperty.smethod_0();
			base.SelectSqlData(dataTable, true, " where ParentId = " + this.comboBoxReadOnly_2.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
			this.comboBoxReadOnly_4.DisplayMember = "fullname";
			this.comboBoxReadOnly_4.ValueMember = "id";
			this.comboBoxReadOnly_4.DataSource = dataTable;
			this.comboBoxReadOnly_4.SelectedIndex = -1;
			DataTable dataTable2 = FormDamageToolWithDefectProperty.smethod_1();
			base.SelectSqlData(dataTable2, true, " where KladrObjId = " + this.comboBoxReadOnly_2.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
			this.comboBoxReadOnly_3.DisplayMember = "fullname";
			this.comboBoxReadOnly_3.ValueMember = "id";
			this.comboBoxReadOnly_3.DataSource = dataTable2;
			this.comboBoxReadOnly_3.SelectedIndex = -1;
		}

		private void comboBoxReadOnly_4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBoxReadOnly_4.SelectedIndex >= 0)
			{
				DataTable dataTable = FormDamageToolWithDefectProperty.smethod_1();
				base.SelectSqlData(dataTable, true, " where KladrObjId = " + this.comboBoxReadOnly_4.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
				this.comboBoxReadOnly_3.DisplayMember = "fullname";
				this.comboBoxReadOnly_3.ValueMember = "id";
				this.comboBoxReadOnly_3.DataSource = dataTable;
				this.comboBoxReadOnly_3.SelectedIndex = -1;
			}
		}

		private void comboBoxReadOnly_3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBoxReadOnly_3.SelectedIndex >= 0)
			{
				this.label_11.ForeColor = Color.Black;
			}
		}

		private void textBox_3_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.textBox_3.Text))
			{
				this.label_10.ForeColor = Color.Black;
			}
		}

		private void method_12()
		{
			if (this.dataTable_0.Rows[0]["idmap"] == DBNull.Value)
			{
				return;
			}
			base.SelectSqlData(this.dataTable_1, true, " where idMap = " + this.dataTable_0.Rows[0]["idmap"].ToString(), null, false, 0);
			this.textBox_3.Text = this.dataTable_1.Rows[0]["House"].ToString();
			this.textBox_2.Text = this.dataTable_1.Rows[0]["HousePrefix"].ToString();
			DataTable dataTable = FormDamageToolWithDefectProperty.smethod_1();
			base.SelectSqlData(dataTable, true, " where id = " + this.dataTable_1.Rows[0]["Street"].ToString(), null, false, 0);
			int int_ = 24;
			if (dataTable.Rows.Count > 0)
			{
				int_ = Convert.ToInt32(dataTable.Rows[0]["KladrObjId"]);
			}
			List<DataRow> list_ = new List<DataRow>();
			this.method_13(int_, list_);
			this.method_14(list_);
			if (this.dataTable_1.Rows[0]["Street"] != DBNull.Value)
			{
				this.comboBoxReadOnly_3.SelectedValue = this.dataTable_1.Rows[0]["Street"];
			}
		}

		internal static DataTable smethod_0()
		{
			return new DataTable("tR_KladrObj")
			{
				Columns = 
				{
					{
						"id",
						typeof(int)
					},
					{
						"parentid",
						typeof(int)
					},
					{
						"name",
						typeof(string)
					},
					{
						"primarykey",
						typeof(string)
					},
					{
						"socr",
						typeof(string)
					},
					{
						"fullname",
						typeof(string),
						"name + isnull(' ' + socr, '')"
					}
				}
			};
		}

		internal static DataTable smethod_1()
		{
			return new DataTable("tR_KladrStreet")
			{
				Columns = 
				{
					{
						"id",
						typeof(int)
					},
					{
						"KladrObjId",
						typeof(int)
					},
					{
						"name",
						typeof(string)
					},
					{
						"socr",
						typeof(string)
					},
					{
						"fullname",
						typeof(string),
						"name + isnull(' ' + socr, '')"
					}
				}
			};
		}

		private void method_13(int int_0, List<DataRow> list_0)
		{
			DataTable dataTable = FormDamageToolWithDefectProperty.smethod_0();
			base.SelectSqlData(dataTable, true, " where id = " + int_0.ToString(), null, false, 0);
			if (dataTable.Rows.Count != 0 && (dataTable.Rows[0]["PrimaryKey"] == DBNull.Value || !(dataTable.Rows[0]["PrimaryKey"].ToString() == "Country")))
			{
				if (dataTable.Rows[0]["ParentId"] != DBNull.Value)
				{
					list_0.Add(dataTable.Rows[0]);
					this.method_13(Convert.ToInt32(dataTable.Rows[0]["ParentId"]), list_0);
					return;
				}
			}
		}

		private void method_14(List<DataRow> list_0)
		{
			DataTable dataTable = FormDamageToolWithDefectProperty.smethod_0();
			switch (list_0.Count)
			{
			case 0:
				this.LgtgjZhXlu.SelectedIndex = -1;
				this.LgtgjZhXlu.DisplayMember = "namefull";
				this.LgtgjZhXlu.ValueMember = "id";
				this.LgtgjZhXlu.DataSource = dataTable;
				base.SelectSqlData(dataTable, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
				this.LgtgjZhXlu.SelectedIndex = -1;
				this.LgtgjZhXlu.SelectedIndex = 0;
				return;
			case 1:
				this.LgtgjZhXlu.SelectedIndex = -1;
				this.LgtgjZhXlu.DisplayMember = "namefull";
				this.LgtgjZhXlu.ValueMember = "id";
				this.LgtgjZhXlu.DataSource = dataTable;
				base.SelectSqlData(dataTable, true, " where ParentId = " + list_0[0]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
				this.LgtgjZhXlu.SelectedIndex = -1;
				this.LgtgjZhXlu.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
				return;
			case 2:
				this.LgtgjZhXlu.SelectedIndex = -1;
				this.LgtgjZhXlu.DisplayMember = "namefull";
				this.LgtgjZhXlu.ValueMember = "id";
				this.LgtgjZhXlu.DataSource = dataTable;
				base.SelectSqlData(dataTable, true, " where ParentId = " + list_0[1]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
				this.LgtgjZhXlu.SelectedIndex = -1;
				this.LgtgjZhXlu.SelectedValue = Convert.ToInt32(list_0[1]["Id"]);
				this.comboBoxReadOnly_2.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
				return;
			}
			this.LgtgjZhXlu.SelectedIndex = -1;
			this.LgtgjZhXlu.DisplayMember = "namefull";
			this.LgtgjZhXlu.ValueMember = "id";
			this.LgtgjZhXlu.DataSource = dataTable;
			base.SelectSqlData(dataTable, true, " where ParentId = " + list_0[2]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
			this.LgtgjZhXlu.SelectedIndex = -1;
			this.LgtgjZhXlu.SelectedValue = Convert.ToInt32(list_0[2]["Id"]);
			this.comboBoxReadOnly_2.SelectedValue = Convert.ToInt32(list_0[1]["Id"]);
			this.comboBoxReadOnly_4.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
		}

		private void method_15()
		{
			this.dataGridView_0.Rows.Clear();
			if (this.lineTool_0 != null)
			{
				int num = Convert.ToInt32(this.dataTable_0.Rows[0]["TypeDoc"]);
				LineToolType type = this.lineTool_0.Type;
				if (type <= LineToolType.AirLine)
				{
					if (type == LineToolType.CabelLine)
					{
						goto IL_15C;
					}
					if (type != LineToolType.AirLine)
					{
						goto IL_21A;
					}
				}
				else
				{
					switch (type)
					{
					case LineToolType.CellLine_6:
					case LineToolType.CellLine_10:
					case LineToolType.CellLine_04:
					case LineToolType.CellLine_023:
						goto IL_15C;
					case (LineToolType)677:
						goto IL_21A;
					default:
						if (type != LineToolType.AirLineProtected)
						{
							goto IL_21A;
						}
						break;
					}
				}
				this.dataGridView_0.Rows.Add();
				this.dataGridView_0.CurrentCell = this.dataGridView_0.Rows[0].Cells[this.dataGridViewComboBoxColumn_0.Name];
				if (num == 1403)
				{
					this.dataGridView_0.Rows[0].Cells[this.dataGridViewComboBoxColumn_0.Name].Value = 1440;
					goto IL_21A;
				}
				if (num == 1844)
				{
					this.dataGridView_0.Rows[0].Cells[this.dataGridViewComboBoxColumn_0.Name].Value = 1518;
					goto IL_21A;
				}
				goto IL_21A;
				IL_15C:
				this.dataGridView_0.Rows.Add();
				this.dataGridView_0.CurrentCell = this.dataGridView_0.Rows[0].Cells[this.dataGridViewComboBoxColumn_0.Name];
				if (num != 1403)
				{
					if (num == 1844)
					{
						this.dataGridView_0.Rows[0].Cells[this.dataGridViewComboBoxColumn_0.Name].Value = 1519;
					}
				}
				else
				{
					this.dataGridView_0.Rows[0].Cells[this.dataGridViewComboBoxColumn_0.Name].Value = 1443;
				}
				IL_21A:
				if (this.dataGridView_0.Rows[0].Cells[this.dataGridViewComboBoxColumn_0.Name].Value != null)
				{
					DataTable dataTable = this.vxmqmLrOsk();
					base.SelectSqlData(dataTable, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", this.dataGridView_0.Rows[0].Cells[this.dataGridViewComboBoxColumn_0.Name].Value), null, false, 0);
					DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dataGridView_0[this.dataGridViewComboBoxColumn_2.Index, 0] as DataGridViewComboBoxCell;
					dataGridViewComboBoxCell.DataSource = dataTable;
					dataGridViewComboBoxCell.DisplayMember = "name";
					dataGridViewComboBoxCell.ValueMember = "id";
				}
				if (this.lineTool_0.IdBase != 0)
				{
					this.dataGridView_0[this.dataGridViewTextBoxColumn_1.Index, 0].Value = this.lineTool_0.IdBase;
					object obj = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
					{
						this.lineTool_0.IdBase.ToString()
					});
					if (obj != null && obj != DBNull.Value)
					{
						this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Index, 0].Value = obj.ToString();
					}
					DataGridViewComboBoxCell dataGridViewComboBoxCell2 = this.dataGridView_0[this.dataGridViewComboBoxColumn_1.Index, 0] as DataGridViewComboBoxCell;
					DataTable dataTable2 = new DataTable("tP_CabSection");
					dataTable2.Columns.Add("id", typeof(int));
					dataTable2.Columns.Add("number", typeof(int));
					base.SelectSqlData(dataTable2, true, "where idObjList = " + this.lineTool_0.IdBase.ToString() + " order by number", null, false, 0);
					dataGridViewComboBoxCell2.DataSource = dataTable2;
					dataGridViewComboBoxCell2.ValueMember = "id";
					dataGridViewComboBoxCell2.DisplayMember = "number";
					dataGridViewComboBoxCell2.ReadOnly = false;
				}
			}
		}

		private void method_16()
		{
			int num = Convert.ToInt32(this.dataTable_0.Rows[0]["TypeDoc"]);
			this.dataGridViewTextBoxColumn_0.Visible = (this.dataGridViewComboBoxColumn_1.Visible = (num == 1844));
			this.dataGridViewButtonColumn_0.Visible = (num == 1844);
			DataGridViewBand dataGridViewBand = this.dataGridViewComboBoxColumn_2;
			this.sjjgoXoOy0.Visible = true;
			dataGridViewBand.Visible = true;
			DataTable dataTable = this.vxmqmLrOsk();
			if (num != 1403)
			{
				if (num == 1844)
				{
					base.SelectSqlData(dataTable, true, "where ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;') \r\n                                        and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
				}
			}
			else
			{
				base.SelectSqlData(dataTable, true, "where ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') \r\n                                        and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
			}
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			bindingSource.Position = -1;
			this.dataGridViewComboBoxColumn_0.DisplayMember = "name";
			this.dataGridViewComboBoxColumn_0.ValueMember = "id";
			this.dataGridViewComboBoxColumn_0.DataSource = bindingSource;
		}

		private void dataGridView_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (this.dataGridView_0.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
			{
				e.Cancel = true;
			}
		}

		private void dataGridView_0_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dataGridView_0.IsCurrentCellDirty)
			{
				this.dataGridView_0.CommitEdit(DataGridViewDataErrorContexts.Commit);
				this.label_13.ForeColor = Color.Black;
				if ((this.dataGridView_0.CurrentCell.ColumnIndex == 0 || this.dataGridView_0.CurrentCell.ColumnIndex == 1) && this.dataGridView_0.CurrentCell.Value != null)
				{
					DataTable dataTable = this.vxmqmLrOsk();
					base.SelectSqlData(dataTable, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", this.dataGridView_0.CurrentCell.Value), null, false, 0);
					int columnIndex = (this.dataGridView_0.CurrentCell.ColumnIndex == this.dataGridViewComboBoxColumn_0.Index) ? this.dataGridViewComboBoxColumn_2.Index : ((this.dataGridView_0.CurrentCell.ColumnIndex == this.dataGridViewComboBoxColumn_2.Index) ? this.sjjgoXoOy0.Index : -1);
					DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dataGridView_0[columnIndex, this.dataGridView_0.CurrentRow.Index] as DataGridViewComboBoxCell;
					dataGridViewComboBoxCell.DataSource = dataTable;
					dataGridViewComboBoxCell.DisplayMember = "name";
					dataGridViewComboBoxCell.ValueMember = "id";
					if (dataGridViewComboBoxCell.Value != null && dataTable.Select("id = " + dataGridViewComboBoxCell.Value.ToString()).Length == 0)
					{
						dataGridViewComboBoxCell.Value = null;
					}
					if (dataGridViewComboBoxCell.Value == null && dataGridViewComboBoxCell.ColumnIndex == this.dataGridViewComboBoxColumn_2.Index)
					{
						DataGridViewComboBoxCell dataGridViewComboBoxCell2 = this.dataGridView_0[this.sjjgoXoOy0.Index, this.dataGridView_0.CurrentRow.Index] as DataGridViewComboBoxCell;
						dataGridViewComboBoxCell2.DataSource = null;
						dataGridViewComboBoxCell2.Value = null;
					}
				}
			}
		}

		private void dataGridView_0_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.dataGridView_0.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.RowHeader)
			{
				this.dataGridView_0.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
				this.dataGridView_0.EndEdit();
				return;
			}
			this.dataGridView_0.EditMode = DataGridViewEditMode.EditOnEnter;
		}

		private void dataGridView_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == this.dataGridViewButtonColumn_0.Index && e.RowIndex >= 0)
			{
				if (this.dataGridView_0[this.dataGridViewComboBoxColumn_0.Index, e.RowIndex].Value == null)
				{
					MessageBox.Show("Не выбран тип объекта");
					return;
				}
				DataTable dataTable = this.vxmqmLrOsk();
				dataTable.Columns.Add("ParentKey", typeof(string));
				base.SelectSqlData(dataTable, true, " where id = " + this.dataGridView_0[this.dataGridViewComboBoxColumn_0.Index, e.RowIndex].Value.ToString(), null, false, 0);
				if (dataTable.Rows.Count == 0)
				{
					return;
				}
				List<int> list = new List<int>();
				string a = dataTable.Rows[0]["ParentKey"].ToString();
				if (!(a == ";ReportDaily;NatureDamage;HV;AirLine;"))
				{
					if (!(a == ";ReportDaily;NatureDamage;HV;CableLine;"))
					{
						if (a == ";ReportDaily;NatureDamage;HV;Subs;")
						{
							list.Add(536);
							list.Add(535);
							list.Add(537);
							list.Add(1034);
							list.Add(538);
							list.Add(1275);
						}
					}
					else
					{
						list.Add(546);
						list.Add(548);
					}
				}
				else
				{
					list.Add(547);
					list.Add(983);
					list.Add(548);
				}
				Form6 form = new Form6(list);
				form.method_4(false);
				form.SqlSettings = this.SqlSettings;
				if (form.ShowDialog() == DialogResult.OK)
				{
					this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, e.RowIndex].Value = form.method_0().string_0;
					this.dataGridView_0[this.dataGridViewTextBoxColumn_1.Name, e.RowIndex].Value = form.method_0().int_0;
					DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dataGridView_0[this.dataGridViewComboBoxColumn_1.Index, e.RowIndex] as DataGridViewComboBoxCell;
					if (dataTable.Rows[0]["ParentKey"].ToString() == ";ReportDaily;NatureDamage;HV;AirLine;" || dataTable.Rows[0]["ParentKey"].ToString() == ";ReportDaily;NatureDamage;HV;CableLine;")
					{
						DataTable dataTable2 = new DataTable("tP_CabSection");
						dataTable2.Columns.Add("id", typeof(int));
						dataTable2.Columns.Add("number", typeof(int));
						base.SelectSqlData(dataTable2, true, "where idObjList = " + form.method_0().int_0.ToString() + " order by number", null, false, 0);
						dataGridViewComboBoxCell.DataSource = dataTable2;
						dataGridViewComboBoxCell.ValueMember = "id";
						dataGridViewComboBoxCell.DisplayMember = "number";
						dataGridViewComboBoxCell.Value = null;
						dataGridViewComboBoxCell.ReadOnly = false;
						return;
					}
					dataGridViewComboBoxCell.DataSource = null;
					dataGridViewComboBoxCell.Value = null;
					dataGridViewComboBoxCell.ReadOnly = true;
				}
			}
		}

		private void checkBox_1_CheckedChanged(object sender, EventArgs e)
		{
			this.comboBoxReadOnly_1.Enabled = (this.comboBoxReadOnly_0.Enabled = (this.groupBox_0.Enabled = this.checkBox_1.Checked));
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			Form7 form = new Form7();
			form.SqlSettings = this.SqlSettings;
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			Form form2 = form;
			form.MaximizeBox = false;
			form2.MinimizeBox = false;
			if (form.ShowDialog() == DialogResult.OK)
			{
				if (form.method_0().Count > 0)
				{
					this.dataTable_0.Rows[0]["idSchmObj"] = form.method_0().First<KeyValuePair<int, string>>().Key;
					this.textBox_4.Text = form.method_0().First<KeyValuePair<int, string>>().Value;
					return;
				}
				this.dataTable_0.Rows[0]["idSchmObj"] = DBNull.Value;
				this.textBox_4.Text = string.Empty;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormDamageToolWithDefectProperty.gRur8OIzSVG3qlOn7vM(this, disposing);
		}

		private void method_17()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			this.checkBox_0 = new CheckBox();
			this.dateTimePicker_0 = new DateTimePicker();
			this.comboBox_0 = new ComboBox();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.checkBox_1 = new CheckBox();
			this.label_2 = new Label();
			this.textBox_0 = new TextBox();
			this.comboBoxReadOnly_0 = new ComboBoxReadOnly();
			this.label_3 = new Label();
			this.label_4 = new Label();
			this.comboBoxReadOnly_1 = new ComboBoxReadOnly();
			this.dateTimePicker_1 = new DateTimePicker();
			this.label_5 = new Label();
			this.label_6 = new Label();
			this.textBox_1 = new TextBox();
			this.groupBox_0 = new GroupBox();
			this.richTextBox_0 = new RichTextBox();
			this.tQngrxwalG = new Label();
			this.groupBox_1 = new GroupBox();
			this.textBox_2 = new TextBox();
			this.label_7 = new Label();
			this.label_8 = new Label();
			this.LgtgjZhXlu = new ComboBoxReadOnly();
			this.textBox_3 = new TextBox();
			this.label_9 = new Label();
			this.label_10 = new Label();
			this.comboBoxReadOnly_2 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_3 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_4 = new ComboBoxReadOnly();
			this.label_11 = new Label();
			this.label_12 = new Label();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
			this.dataGridViewButtonColumn_0 = new DataGridViewButtonColumn();
			this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
			this.dataGridViewComboBoxColumn_2 = new DataGridViewComboBoxColumn();
			this.sjjgoXoOy0 = new DataGridViewComboBoxColumn();
			this.label_13 = new Label();
			this.comboBoxReadOnly_5 = new ComboBoxReadOnly();
			this.label_14 = new Label();
			this.label_15 = new Label();
			this.textBox_4 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataSet_0 = new DataSet();
			this.dataTable_0 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.dataColumn_5 = new DataColumn();
			this.dataColumn_6 = new DataColumn();
			this.dataColumn_7 = new DataColumn();
			this.button_2 = new Button();
			this.dataColumn_8 = new DataColumn();
			this.dataTable_1 = new DataTable();
			this.dataColumn_9 = new DataColumn();
			this.dataColumn_10 = new DataColumn();
			this.dataColumn_11 = new DataColumn();
			this.dataColumn_12 = new DataColumn();
			this.dataColumn_13 = new DataColumn();
			this.dataColumn_14 = new DataColumn();
			this.dataColumn_15 = new DataColumn();
			this.dataColumn_16 = new DataColumn();
			this.dataTable_2 = new DataTable();
			this.dataColumn_17 = new DataColumn();
			this.dataColumn_18 = new DataColumn();
			this.dataColumn_19 = new DataColumn();
			this.dataColumn_20 = new DataColumn();
			this.dataColumn_21 = new DataColumn();
			this.dataColumn_22 = new DataColumn();
			this.dataColumn_23 = new DataColumn();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			((ISupportInitialize)this.dataTable_1).BeginInit();
			((ISupportInitialize)this.dataTable_2).BeginInit();
			base.SuspendLayout();
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Location = new Point(15, 38);
			this.checkBox_0.Name = "checkBoxDoNotMark";
			this.checkBox_0.Size = new Size(145, 17);
			this.checkBox_0.TabIndex = 9;
			this.checkBox_0.Text = "Не отмечать в журнале";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
			this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
			this.dateTimePicker_0.Location = new Point(98, 12);
			this.dateTimePicker_0.Name = "dateTimePickerInstalAtr";
			this.dateTimePicker_0.Size = new Size(200, 20);
			this.dateTimePicker_0.TabIndex = 8;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(373, 12);
			this.comboBox_0.Name = "comboBoxReason";
			this.comboBox_0.Size = new Size(194, 21);
			this.comboBox_0.TabIndex = 7;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(313, 18);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(50, 13);
			this.label_0.TabIndex = 5;
			this.label_0.Text = "Причина";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 18);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(74, 13);
			this.label_1.TabIndex = 6;
			this.label_1.Text = "Дата вывода";
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Location = new Point(15, 61);
			this.checkBox_1.Name = "chkDefect";
			this.checkBox_1.Size = new Size(108, 17);
			this.checkBox_1.TabIndex = 10;
			this.checkBox_1.Text = "Создать дефект";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_1.CheckedChanged += this.checkBox_1_CheckedChanged;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 87);
			this.label_2.Name = "labelNumRequest";
			this.label_2.Size = new Size(80, 13);
			this.label_2.TabIndex = 11;
			this.label_2.Text = "Номер заявки";
			this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSet_0, "tJ_Damage.numRequest", true));
			this.textBox_0.Enabled = false;
			this.textBox_0.Location = new Point(98, 84);
			this.textBox_0.Name = "txtNumRequest";
			this.textBox_0.Size = new Size(161, 20);
			this.textBox_0.TabIndex = 12;
			this.comboBoxReadOnly_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBoxReadOnly_0.BackColor = SystemColors.Window;
			this.comboBoxReadOnly_0.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tJ_Damage.idDivision", true, DataSourceUpdateMode.OnPropertyChanged));
			this.comboBoxReadOnly_0.Enabled = false;
			this.comboBoxReadOnly_0.ForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_0.FormattingEnabled = true;
			this.comboBoxReadOnly_0.Location = new Point(358, 136);
			this.comboBoxReadOnly_0.Name = "cmbDivision";
			this.comboBoxReadOnly_0.ReadOnly = true;
			this.comboBoxReadOnly_0.ReadOnlyBackColor = SystemColors.Window;
			this.comboBoxReadOnly_0.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_0.Size = new Size(209, 21);
			this.comboBoxReadOnly_0.TabIndex = 20;
			this.comboBoxReadOnly_0.TabStop = false;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(265, 140);
			this.label_3.Name = "label6";
			this.label_3.Size = new Size(87, 13);
			this.label_3.TabIndex = 19;
			this.label_3.Text = "Подразделение";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(12, 144);
			this.label_4.Name = "labelCompiler";
			this.label_4.Size = new Size(72, 13);
			this.label_4.TabIndex = 17;
			this.label_4.Text = "Составитель";
			this.comboBoxReadOnly_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_1.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tJ_Damage.idCompiler", true));
			this.comboBoxReadOnly_1.Enabled = false;
			this.comboBoxReadOnly_1.FormattingEnabled = true;
			this.comboBoxReadOnly_1.Location = new Point(98, 137);
			this.comboBoxReadOnly_1.Name = "cmbCompiler";
			this.comboBoxReadOnly_1.ReadOnlyBackColor = SystemColors.Window;
			this.comboBoxReadOnly_1.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_1.Size = new Size(161, 21);
			this.comboBoxReadOnly_1.TabIndex = 18;
			this.comboBoxReadOnly_1.SelectedValueChanged += this.comboBoxReadOnly_1_SelectedValueChanged;
			this.dateTimePicker_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.dateTimePicker_1.DataBindings.Add(new Binding("Value", this.dataSet_0, "tJ_Damage.dateOwner", true));
			this.dateTimePicker_1.Enabled = false;
			this.dateTimePicker_1.Location = new Point(358, 110);
			this.dateTimePicker_1.Name = "dtpDateOwner";
			this.dateTimePicker_1.Size = new Size(209, 20);
			this.dateTimePicker_1.TabIndex = 16;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(265, 116);
			this.label_5.Name = "label4";
			this.label_5.Size = new Size(84, 13);
			this.label_5.TabIndex = 15;
			this.label_5.Text = "Дата создания";
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(12, 117);
			this.label_6.Name = "label3";
			this.label_6.Size = new Size(76, 13);
			this.label_6.TabIndex = 13;
			this.label_6.Text = "Автор заявки";
			this.textBox_1.Enabled = false;
			this.textBox_1.Location = new Point(98, 110);
			this.textBox_1.Name = "txtOwner";
			this.textBox_1.ReadOnly = true;
			this.textBox_1.Size = new Size(161, 20);
			this.textBox_1.TabIndex = 14;
			this.groupBox_0.Controls.Add(this.button_2);
			this.groupBox_0.Controls.Add(this.richTextBox_0);
			this.groupBox_0.Controls.Add(this.tQngrxwalG);
			this.groupBox_0.Controls.Add(this.groupBox_1);
			this.groupBox_0.Controls.Add(this.dataGridView_0);
			this.groupBox_0.Controls.Add(this.label_13);
			this.groupBox_0.Controls.Add(this.comboBoxReadOnly_5);
			this.groupBox_0.Controls.Add(this.label_14);
			this.groupBox_0.Controls.Add(this.label_15);
			this.groupBox_0.Controls.Add(this.textBox_4);
			this.groupBox_0.Enabled = false;
			this.groupBox_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.groupBox_0.Location = new Point(0, 164);
			this.groupBox_0.Name = "groupBoxDefectData";
			this.groupBox_0.Size = new Size(573, 357);
			this.groupBox_0.TabIndex = 21;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Исходные данные";
			this.richTextBox_0.AcceptsTab = true;
			this.richTextBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.richTextBox_0.BackColor = SystemColors.Window;
			this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSet_0, "tJ_Damage.DefectLocation", true));
			this.richTextBox_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.richTextBox_0.Location = new Point(128, 178);
			this.richTextBox_0.Name = "txtLocation";
			this.richTextBox_0.Size = new Size(439, 40);
			this.richTextBox_0.TabIndex = 6;
			this.richTextBox_0.Text = "";
			this.tQngrxwalG.AutoSize = true;
			this.tQngrxwalG.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.tQngrxwalG.Location = new Point(12, 178);
			this.tQngrxwalG.Name = "label7";
			this.tQngrxwalG.Size = new Size(110, 13);
			this.tQngrxwalG.TabIndex = 5;
			this.tQngrxwalG.Text = "Место повреждения";
			this.groupBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_1.Controls.Add(this.textBox_2);
			this.groupBox_1.Controls.Add(this.label_7);
			this.groupBox_1.Controls.Add(this.label_8);
			this.groupBox_1.Controls.Add(this.LgtgjZhXlu);
			this.groupBox_1.Controls.Add(this.textBox_3);
			this.groupBox_1.Controls.Add(this.label_9);
			this.groupBox_1.Controls.Add(this.label_10);
			this.groupBox_1.Controls.Add(this.comboBoxReadOnly_2);
			this.groupBox_1.Controls.Add(this.comboBoxReadOnly_3);
			this.groupBox_1.Controls.Add(this.comboBoxReadOnly_4);
			this.groupBox_1.Controls.Add(this.label_11);
			this.groupBox_1.Controls.Add(this.label_12);
			this.groupBox_1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.groupBox_1.Location = new Point(9, 72);
			this.groupBox_1.Name = "groupBoxAddress";
			this.groupBox_1.Size = new Size(558, 100);
			this.groupBox_1.TabIndex = 4;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Адрес";
			this.textBox_2.BackColor = SystemColors.Window;
			this.textBox_2.Location = new Point(352, 72);
			this.textBox_2.Name = "txtHousePrefix";
			this.textBox_2.Size = new Size(64, 20);
			this.textBox_2.TabIndex = 11;
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(6, 16);
			this.label_7.Name = "labelObl";
			this.label_7.Size = new Size(50, 13);
			this.label_7.TabIndex = 0;
			this.label_7.Text = "Область";
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(349, 56);
			this.label_8.Name = "labelHousePrefix";
			this.label_8.Size = new Size(53, 13);
			this.label_8.TabIndex = 10;
			this.label_8.Text = "Префикс";
			this.LgtgjZhXlu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.LgtgjZhXlu.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.LgtgjZhXlu.DisplayMember = "tR_KladrObj.NameSocr";
			this.LgtgjZhXlu.FormattingEnabled = true;
			this.LgtgjZhXlu.Location = new Point(6, 32);
			this.LgtgjZhXlu.Name = "cmbObl";
			this.LgtgjZhXlu.ReadOnlyBackColor = SystemColors.Window;
			this.LgtgjZhXlu.ReadOnlyForeColor = SystemColors.WindowText;
			this.LgtgjZhXlu.Size = new Size(179, 21);
			this.LgtgjZhXlu.TabIndex = 1;
			this.LgtgjZhXlu.ValueMember = "tR_KladrObj.Id";
			this.LgtgjZhXlu.SelectedIndexChanged += this.LgtgjZhXlu_SelectedIndexChanged;
			this.textBox_3.BackColor = SystemColors.Window;
			this.textBox_3.Location = new Point(273, 72);
			this.textBox_3.Name = "txtHouse";
			this.textBox_3.Size = new Size(63, 20);
			this.textBox_3.TabIndex = 9;
			this.textBox_3.TextChanged += this.textBox_3_TextChanged;
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(203, 16);
			this.label_9.Name = "labelRaionObl";
			this.label_9.Size = new Size(72, 13);
			this.label_9.TabIndex = 2;
			this.label_9.Text = "Район/город";
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(270, 56);
			this.label_10.Name = "labelHouse";
			this.label_10.Size = new Size(30, 13);
			this.label_10.TabIndex = 8;
			this.label_10.Text = "Дом";
			this.comboBoxReadOnly_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_2.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_2.DisplayMember = "tR_KladrObj.NameSocr";
			this.comboBoxReadOnly_2.FormattingEnabled = true;
			this.comboBoxReadOnly_2.Location = new Point(195, 32);
			this.comboBoxReadOnly_2.Name = "cmbRaionObl";
			this.comboBoxReadOnly_2.ReadOnlyBackColor = SystemColors.Window;
			this.comboBoxReadOnly_2.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_2.Size = new Size(172, 21);
			this.comboBoxReadOnly_2.TabIndex = 3;
			this.comboBoxReadOnly_2.ValueMember = "tR_KladrObj.Id";
			this.comboBoxReadOnly_2.SelectedIndexChanged += this.comboBoxReadOnly_2_SelectedIndexChanged;
			this.comboBoxReadOnly_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_3.DisplayMember = "tR_KladrStreet.NameSocr";
			this.comboBoxReadOnly_3.FormattingEnabled = true;
			this.comboBoxReadOnly_3.Location = new Point(6, 72);
			this.comboBoxReadOnly_3.Name = "cmbStreet";
			this.comboBoxReadOnly_3.ReadOnlyBackColor = SystemColors.Window;
			this.comboBoxReadOnly_3.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_3.Size = new Size(244, 21);
			this.comboBoxReadOnly_3.TabIndex = 7;
			this.comboBoxReadOnly_3.ValueMember = "tR_KladrStreet.Id";
			this.comboBoxReadOnly_3.SelectedIndexChanged += this.comboBoxReadOnly_3_SelectedIndexChanged;
			this.comboBoxReadOnly_4.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBoxReadOnly_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_4.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_4.DisplayMember = "tR_KladrObj.NameSocr";
			this.comboBoxReadOnly_4.FormattingEnabled = true;
			this.comboBoxReadOnly_4.Location = new Point(373, 32);
			this.comboBoxReadOnly_4.Name = "cmbCity";
			this.comboBoxReadOnly_4.ReadOnlyBackColor = SystemColors.Window;
			this.comboBoxReadOnly_4.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_4.Size = new Size(179, 21);
			this.comboBoxReadOnly_4.TabIndex = 5;
			this.comboBoxReadOnly_4.ValueMember = "tR_KladrObj.Id";
			this.comboBoxReadOnly_4.SelectedIndexChanged += this.comboBoxReadOnly_4_SelectedIndexChanged;
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(6, 56);
			this.label_11.Name = "labelStreet";
			this.label_11.Size = new Size(39, 13);
			this.label_11.TabIndex = 6;
			this.label_11.Text = "Улица";
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(382, 16);
			this.label_12.Name = "labelCity";
			this.label_12.Size = new Size(102, 13);
			this.label_12.TabIndex = 4;
			this.label_12.Text = "Населенный пункт";
			this.dataGridView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewComboBoxColumn_0,
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewButtonColumn_0,
				this.dataGridViewComboBoxColumn_1,
				this.dataGridViewComboBoxColumn_2,
				this.sjjgoXoOy0
			});
			this.dataGridView_0.EditMode = DataGridViewEditMode.EditOnEnter;
			this.dataGridView_0.Location = new Point(0, 237);
			this.dataGridView_0.Name = "dgvCharacterDamage";
			this.dataGridView_0.Size = new Size(573, 120);
			this.dataGridView_0.TabIndex = 8;
			this.dataGridView_0.CellContentClick += this.dataGridView_0_CellContentClick;
			this.dataGridView_0.CurrentCellDirtyStateChanged += this.dataGridView_0_CurrentCellDirtyStateChanged;
			this.dataGridView_0.DataError += this.dataGridView_0_DataError;
			this.dataGridView_0.MouseClick += this.dataGridView_0_MouseClick;
			this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.dataGridViewComboBoxColumn_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
			this.dataGridViewComboBoxColumn_0.HeaderText = "Тип объекта";
			this.dataGridViewComboBoxColumn_0.Name = "Column1";
			this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewButtonColumn_0.HeaderText = "";
			this.dataGridViewButtonColumn_0.Name = "ColumnBtn";
			this.dataGridViewButtonColumn_0.Text = "...";
			this.dataGridViewButtonColumn_0.ToolTipText = "Выбрать объект";
			this.dataGridViewButtonColumn_0.Visible = false;
			this.dataGridViewButtonColumn_0.Width = 25;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.dataGridViewComboBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewComboBoxColumn_1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
			this.dataGridViewComboBoxColumn_1.HeaderText = "Участок";
			this.dataGridViewComboBoxColumn_1.Name = "ColumnCabSection";
			this.dataGridViewComboBoxColumn_1.ReadOnly = true;
			this.dataGridViewComboBoxColumn_1.Width = 60;
			this.dataGridViewComboBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.dataGridViewComboBoxColumn_2.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewComboBoxColumn_2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
			this.dataGridViewComboBoxColumn_2.HeaderText = "Повреждение";
			this.dataGridViewComboBoxColumn_2.Name = "Column2";
			this.sjjgoXoOy0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.sjjgoXoOy0.DefaultCellStyle = dataGridViewCellStyle4;
			this.sjjgoXoOy0.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
			this.sjjgoXoOy0.HeaderText = "Уточнение";
			this.sjjgoXoOy0.Name = "Column3";
			this.label_13.AutoSize = true;
			this.label_13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label_13.Location = new Point(6, 221);
			this.label_13.Name = "label1ChatacterDamage";
			this.label_13.Size = new Size(126, 13);
			this.label_13.TabIndex = 7;
			this.label_13.Text = "Характер повреждения";
			this.comboBoxReadOnly_5.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBoxReadOnly_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_5.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_5.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tJ_Damage.idReason", true));
			this.comboBoxReadOnly_5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.comboBoxReadOnly_5.FormattingEnabled = true;
			this.comboBoxReadOnly_5.Location = new Point(128, 45);
			this.comboBoxReadOnly_5.Name = "cmbReason";
			this.comboBoxReadOnly_5.ReadOnlyBackColor = SystemColors.Window;
			this.comboBoxReadOnly_5.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_5.Size = new Size(439, 21);
			this.comboBoxReadOnly_5.TabIndex = 3;
			this.label_14.AutoSize = true;
			this.label_14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label_14.Location = new Point(6, 48);
			this.label_14.Name = "labelReason";
			this.label_14.Size = new Size(86, 13);
			this.label_14.TabIndex = 2;
			this.label_14.Text = "Неисправность";
			this.label_15.AutoSize = true;
			this.label_15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label_15.Location = new Point(6, 22);
			this.label_15.Name = "labelSchmObj";
			this.label_15.Size = new Size(108, 13);
			this.label_15.TabIndex = 0;
			this.label_15.Text = "Подстанция\\ячейка";
			this.textBox_4.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_4.BackColor = SystemColors.Window;
			this.textBox_4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.textBox_4.Location = new Point(128, 19);
			this.textBox_4.Name = "txtSchmObj";
			this.textBox_4.ReadOnly = true;
			this.textBox_4.Size = new Size(415, 20);
			this.textBox_4.TabIndex = 1;
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(486, 541);
			this.button_0.Name = "buttonCancel";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 22;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.OK;
			this.button_1.Location = new Point(18, 541);
			this.button_1.Name = "buttonOK";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 23;
			this.button_1.Text = "ОК";
			this.button_1.UseVisualStyleBackColor = true;
			dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.dataGridViewTextBoxColumn_2.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn_2.HeaderText = "Объект";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.dataGridViewTextBoxColumn_3.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn_3.HeaderText = "IdSchmObj";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.dataGridViewTextBoxColumn_0.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewTextBoxColumn_0.HeaderText = "Объект";
			this.dataGridViewTextBoxColumn_0.Name = "ColumnSchmObj";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.dataGridViewTextBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewTextBoxColumn_1.HeaderText = "IdSchmObj";
			this.dataGridViewTextBoxColumn_1.Name = "ColumnIdSchmObj";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_0,
				this.dataTable_1,
				this.dataTable_2
			});
			this.dataTable_0.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3,
				this.dataColumn_4,
				this.dataColumn_5,
				this.dataColumn_6,
				this.dataColumn_7,
				this.dataColumn_8,
				this.dataColumn_13,
				this.dataColumn_14
			});
			this.dataTable_0.Constraints.AddRange(new Constraint[]
			{
				new UniqueConstraint("Constraint1", new string[]
				{
					"id"
				}, true)
			});
			this.dataTable_0.PrimaryKey = new DataColumn[]
			{
				this.dataColumn_0
			};
			this.dataTable_0.TableName = "tJ_Damage";
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.ColumnName = "id";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "datedoc";
			this.dataColumn_1.DataType = typeof(DateTime);
			this.dataColumn_2.ColumnName = "typedoc";
			this.dataColumn_2.DataType = typeof(int);
			this.dataColumn_3.ColumnName = "numRequest";
			this.dataColumn_4.ColumnName = "idCompiler";
			this.dataColumn_4.DataType = typeof(int);
			this.dataColumn_5.ColumnName = "idDivision";
			this.dataColumn_5.DataType = typeof(int);
			this.dataColumn_6.ColumnName = "idSchmObj";
			this.dataColumn_6.DataType = typeof(int);
			this.dataColumn_7.ColumnName = "dateOwner";
			this.dataColumn_7.DataType = typeof(DateTime);
			this.button_2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.button_2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.button_2.Location = new Point(540, 19);
			this.button_2.Name = "btnChoiceSchmObj";
			this.button_2.Size = new Size(27, 20);
			this.button_2.TabIndex = 9;
			this.button_2.Text = "...";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.dataColumn_8.ColumnName = "idMap";
			this.dataColumn_8.DataType = typeof(int);
			this.dataTable_1.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_9,
				this.dataColumn_10,
				this.dataColumn_11,
				this.dataColumn_12,
				this.dataColumn_15,
				this.dataColumn_16
			});
			this.dataTable_1.Constraints.AddRange(new Constraint[]
			{
				new UniqueConstraint("Constraint1", new string[]
				{
					"idMap"
				}, true)
			});
			this.dataTable_1.PrimaryKey = new DataColumn[]
			{
				this.dataColumn_9
			};
			this.dataTable_1.TableName = "tMapObj";
			this.dataColumn_9.AllowDBNull = false;
			this.dataColumn_9.AutoIncrement = true;
			this.dataColumn_9.ColumnName = "idMap";
			this.dataColumn_9.DataType = typeof(int);
			this.dataColumn_10.ColumnName = "Street";
			this.dataColumn_10.DataType = typeof(int);
			this.dataColumn_11.ColumnName = "House";
			this.dataColumn_11.DataType = typeof(int);
			this.dataColumn_12.ColumnName = "HousePrefix";
			this.dataColumn_13.ColumnName = "idReason";
			this.dataColumn_13.DataType = typeof(int);
			this.dataColumn_14.ColumnName = "DefectLocation";
			this.dataColumn_15.ColumnName = "isHouse";
			this.dataColumn_15.DataType = typeof(bool);
			this.dataColumn_16.ColumnName = "deleted";
			this.dataColumn_16.DataType = typeof(bool);
			this.dataTable_2.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_17,
				this.dataColumn_18,
				this.dataColumn_19,
				this.dataColumn_20,
				this.dataColumn_21,
				this.dataColumn_22,
				this.dataColumn_23
			});
			this.dataTable_2.Constraints.AddRange(new Constraint[]
			{
				new UniqueConstraint("Constraint1", new string[]
				{
					"id"
				}, true)
			});
			this.dataTable_2.PrimaryKey = new DataColumn[]
			{
				this.dataColumn_17
			};
			this.dataTable_2.TableName = "tJ_DamageCharacter";
			this.dataColumn_17.AllowDBNull = false;
			this.dataColumn_17.AutoIncrement = true;
			this.dataColumn_17.ColumnName = "id";
			this.dataColumn_17.DataType = typeof(int);
			this.dataColumn_18.AllowDBNull = false;
			this.dataColumn_18.ColumnName = "idDamage";
			this.dataColumn_18.DataType = typeof(int);
			this.dataColumn_19.ColumnName = "col1";
			this.dataColumn_19.DataType = typeof(int);
			this.dataColumn_20.ColumnName = "col2";
			this.dataColumn_20.DataType = typeof(int);
			this.dataColumn_21.ColumnName = "col3";
			this.dataColumn_21.DataType = typeof(int);
			this.dataColumn_22.ColumnName = "idSchmObj";
			this.dataColumn_22.DataType = typeof(int);
			this.dataColumn_23.ColumnName = "idLineSection";
			this.dataColumn_23.DataType = typeof(int);
			base.AcceptButton = this.button_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(573, 570);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.groupBox_0);
			base.Controls.Add(this.comboBoxReadOnly_0);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_4);
			base.Controls.Add(this.comboBoxReadOnly_1);
			base.Controls.Add(this.dateTimePicker_1);
			base.Controls.Add(this.label_5);
			base.Controls.Add(this.label_6);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.checkBox_1);
			base.Controls.Add(this.checkBox_0);
			base.Controls.Add(this.dateTimePicker_0);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.label_1);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormDamageToolWithDefectProperty";
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Вывод кабеля из эксплуатации";
			base.FormClosing += this.FormDamageToolWithDefectProperty_FormClosing;
			base.Load += this.FormDamageToolWithDefectProperty_Load;
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			((ISupportInitialize)this.dataTable_1).EndInit();
			((ISupportInitialize)this.dataTable_2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void gRur8OIzSVG3qlOn7vM(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private LineTool lineTool_0;

		private IContainer icontainer_0;

		private CheckBox checkBox_0;

		private DateTimePicker dateTimePicker_0;

		private ComboBox comboBox_0;

		private Label label_0;

		private Label label_1;

		private CheckBox checkBox_1;

		private Label label_2;

		private TextBox textBox_0;

		private ComboBoxReadOnly comboBoxReadOnly_0;

		private Label label_3;

		private Label label_4;

		private ComboBoxReadOnly comboBoxReadOnly_1;

		private DateTimePicker dateTimePicker_1;

		private Label label_5;

		private Label label_6;

		private TextBox textBox_1;

		private GroupBox groupBox_0;

		private RichTextBox richTextBox_0;

		private Label tQngrxwalG;

		private GroupBox groupBox_1;

		private TextBox textBox_2;

		private Label label_7;

		private Label label_8;

		private ComboBoxReadOnly LgtgjZhXlu;

		private TextBox textBox_3;

		private Label label_9;

		private Label label_10;

		private ComboBoxReadOnly comboBoxReadOnly_2;

		private ComboBoxReadOnly comboBoxReadOnly_3;

		private ComboBoxReadOnly comboBoxReadOnly_4;

		private Label label_11;

		private Label label_12;

		private DataGridView dataGridView_0;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewButtonColumn dataGridViewButtonColumn_0;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		private DataGridViewComboBoxColumn sjjgoXoOy0;

		private Label label_13;

		private ComboBoxReadOnly comboBoxReadOnly_5;

		private Label label_14;

		private Label label_15;

		private TextBox textBox_4;

		private Button button_0;

		private Button button_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataColumn dataColumn_7;

		private Button button_2;

		private DataColumn dataColumn_8;

		private DataTable dataTable_1;

		private DataColumn dataColumn_9;

		private DataColumn dataColumn_10;

		private DataColumn dataColumn_11;

		private DataColumn dataColumn_12;

		private DataColumn dataColumn_13;

		private DataColumn dataColumn_14;

		private DataColumn dataColumn_15;

		private DataColumn dataColumn_16;

		private DataTable dataTable_2;

		private DataColumn dataColumn_17;

		private DataColumn dataColumn_18;

		private DataColumn dataColumn_19;

		private DataColumn dataColumn_20;

		private DataColumn dataColumn_21;

		private DataColumn dataColumn_22;

		private DataColumn dataColumn_23;
	}
}
