using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using Documents.Properties;
using FormLbr.Classes;
using Legal.Forms;
using Passport.Forms;
using Prv.Forms.Abonent;
using WinFormsUI.Docking;

namespace Documents.Forms.Abonent
{
	public partial class FormJournalAbn : DockContentBase
	{
		public FormJournalAbn()
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.method_16();
		}

		private void FormJournalAbn_Load(object sender, EventArgs e)
		{
			this.method_0();
			base.LoadFormConfig(null);
		}

		private void FormJournalAbn_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		private void method_0()
		{
			this.method_1();
			List<DataRow> list_ = new List<DataRow>();
			this.method_2(2, list_);
			this.method_3(list_);
			this.method_8();
		}

		private void method_1()
		{
			DataTable dataTable = this.method_4();
			string arg = string.Concat(new string[]
			{
				683.ToString(),
				",",
				680.ToString(),
				",",
				614.ToString(),
				",",
				581.ToString()
			});
			base.SelectSqlData(dataTable, true, string.Format(" where ParentKey = ';SKUEE;TypeAbn;' and id not in ({0}) and isGroup = 0 and deleted = 0 order by name", arg), null, false, 0);
			this.checkedListBox_0.Items.Clear();
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				this.checkedListBox_0.Items.Add(new Class229(Convert.ToInt32(dataRow["id"]), dataRow["name"].ToString()), true);
			}
		}

		private void method_2(int int_0, List<DataRow> list_0)
		{
			DataTable dataTable = this.method_5();
			base.SelectSqlData(dataTable, true, " where id = " + int_0.ToString(), null, false, 0);
			if (dataTable.Rows.Count != 0 && (dataTable.Rows[0]["PrimaryKey"] == DBNull.Value || !(dataTable.Rows[0]["PrimaryKey"].ToString() == "Country")))
			{
				if (dataTable.Rows[0]["ParentId"] != DBNull.Value)
				{
					list_0.Add(dataTable.Rows[0]);
					this.method_2(Convert.ToInt32(dataTable.Rows[0]["ParentId"]), list_0);
					return;
				}
			}
		}

		private void method_3(List<DataRow> list_0)
		{
			DataTable dataTable = this.method_5();
			switch (list_0.Count)
			{
			case 0:
				this.comboBox_2.SelectedIndex = -1;
				this.comboBox_2.DisplayMember = "namefull";
				this.comboBox_2.ValueMember = "id";
				this.comboBox_2.DataSource = dataTable;
				base.SelectSqlData(dataTable, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
				this.comboBox_2.SelectedIndex = -1;
				this.comboBox_2.SelectedIndex = 0;
				return;
			case 1:
				this.comboBox_2.SelectedIndex = -1;
				this.comboBox_2.DisplayMember = "namefull";
				this.comboBox_2.ValueMember = "id";
				this.comboBox_2.DataSource = dataTable;
				base.SelectSqlData(dataTable, true, " where ParentId = " + list_0[0]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
				this.comboBox_2.SelectedIndex = -1;
				this.comboBox_2.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
				return;
			case 2:
				this.comboBox_2.SelectedIndex = -1;
				this.comboBox_2.DisplayMember = "namefull";
				this.comboBox_2.ValueMember = "id";
				this.comboBox_2.DataSource = dataTable;
				base.SelectSqlData(dataTable, true, " where ParentId = " + list_0[1]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
				this.comboBox_2.SelectedIndex = -1;
				this.comboBox_2.SelectedValue = Convert.ToInt32(list_0[1]["Id"]);
				this.comboBox_1.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
				return;
			}
			this.comboBox_2.SelectedIndex = -1;
			this.comboBox_2.DisplayMember = "namefull";
			this.comboBox_2.ValueMember = "id";
			this.comboBox_2.DataSource = dataTable;
			base.SelectSqlData(dataTable, true, " where ParentId = " + list_0[2]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
			this.comboBox_2.SelectedIndex = -1;
			this.comboBox_2.SelectedValue = Convert.ToInt32(list_0[2]["Id"]);
			this.comboBox_1.SelectedValue = Convert.ToInt32(list_0[1]["Id"]);
			this.comboBox_0.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
		}

		private DataTable method_4()
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

		private DataTable method_5()
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
						"ParentId",
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
						"namefull",
						typeof(string),
						"name + ' ' + socr"
					},
					{
						"primarykey",
						typeof(string)
					}
				}
			};
		}

		private DataTable method_6()
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
						"namefull",
						typeof(string),
						"name + ' ' + socr"
					},
					{
						"index",
						typeof(string)
					}
				}
			};
		}

		private void method_7()
		{
			DataTable dataTable = new DataTable("tR_MarkMeter");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Columns.Add("digit", typeof(int));
			dataTable.Columns.Add("phaze", typeof(int));
			dataTable.Columns.Add("voltage", typeof(int));
			dataTable.Columns.Add("precision", typeof(decimal));
			base.SelectSqlData(dataTable, true, " where deleted = 0 order by name, digit", null, false, 0);
			this.multiColumnComboBox_0.DataSource = dataTable;
			this.multiColumnComboBox_0.DisplayMember = "Name";
			this.multiColumnComboBox_0.ValueMember = "Id";
			this.multiColumnComboBox_0.SelectedIndex = -1;
		}

		private void method_8()
		{
			if (!this.checkBox_4.Checked && !this.checkBox_7.Checked && !this.checkBox_6.Checked && !this.checkBox_5.Checked)
			{
				DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn = this.dataGridViewFilterTextBoxColumn_25;
				this.dataGridViewFilterTextBoxColumn_25.Visible = false;
				dataGridViewFilterTextBoxColumn.AllowUserVisibleColumn = false;
				DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn2 = this.dataGridViewFilterTextBoxColumn_26;
				this.dataGridViewFilterTextBoxColumn_26.Visible = false;
				dataGridViewFilterTextBoxColumn2.AllowUserVisibleColumn = false;
				DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn3 = this.dataGridViewFilterTextBoxColumn_27;
				this.dataGridViewFilterTextBoxColumn_27.Visible = false;
				dataGridViewFilterTextBoxColumn3.AllowUserVisibleColumn = false;
				DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn4 = this.dataGridViewFilterTextBoxColumn_28;
				this.dataGridViewFilterTextBoxColumn_28.Visible = false;
				dataGridViewFilterTextBoxColumn4.AllowUserVisibleColumn = false;
				DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn5 = this.dataGridViewFilterTextBoxColumn_29;
				this.dataGridViewFilterTextBoxColumn_29.Visible = false;
				dataGridViewFilterTextBoxColumn5.AllowUserVisibleColumn = false;
			}
			else
			{
				if (this.checkBox_7.Checked && !this.dataGridViewFilterTextBoxColumn_25.AllowUserVisibleColumn)
				{
					this.dataGridViewFilterTextBoxColumn_25.AllowUserVisibleColumn = true;
					this.dataGridViewFilterTextBoxColumn_25.Visible = true;
				}
				if (this.checkBox_6.Checked && !this.dataGridViewFilterTextBoxColumn_26.AllowUserVisibleColumn)
				{
					this.dataGridViewFilterTextBoxColumn_26.AllowUserVisibleColumn = true;
					this.dataGridViewFilterTextBoxColumn_26.Visible = true;
				}
				if (this.checkBox_5.Checked && !this.dataGridViewFilterTextBoxColumn_27.AllowUserVisibleColumn)
				{
					this.dataGridViewFilterTextBoxColumn_27.AllowUserVisibleColumn = true;
					this.dataGridViewFilterTextBoxColumn_27.Visible = true;
				}
				if (this.checkBox_4.Checked && !this.dataGridViewFilterTextBoxColumn_28.AllowUserVisibleColumn)
				{
					this.dataGridViewFilterTextBoxColumn_28.AllowUserVisibleColumn = true;
					this.dataGridViewFilterTextBoxColumn_28.Visible = true;
				}
			}
			this.dataGridViewFilterTextBoxColumn_32.AllowUserVisibleColumn = (this.dataGridViewFilterTextBoxColumn_32.Visible = this.checkBox_9.Checked);
			this.dataGridViewFilterTextBoxColumn_33.AllowUserVisibleColumn = (this.dataGridViewFilterTextBoxColumn_33.Visible = this.checkBox_8.Checked);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			this.button_0.Enabled = false;
			this.dataGridViewExcelFilter_0.Enabled = false;
			this.dataGridViewExcelFilter_0.DataSource = null;
			this.toolStripProgressBar_0.Visible = true;
			this.method_8();
			this.backgroundWorker_0.RunWorkerAsync(this.method_9());
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			this.dataTable_0.Clear();
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					try
					{
						using (SqlCommand sqlCommand = new SqlCommand())
						{
							sqlCommand.Connection = sqlConnection;
							sqlCommand.CommandTimeout = 0;
							sqlCommand.CommandText = e.Argument.ToString();
							using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
							{
								sqlDataAdapter.Fill(this.dataTable_0);
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					finally
					{
						sqlConnection.Close();
					}
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.button_0.Enabled = true;
			this.dataGridViewExcelFilter_0.Enabled = true;
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.toolStripProgressBar_0.Visible = false;
			base.SaveFormConfig(null);
		}

		private string method_9()
		{
			return string.Concat(new string[]
			{
				"with ActiveObj (idAbnObj,isActive) as\r\n                                        (select  abnObjDog.id,1 from  tAbnDoc_List lst \r\n\t\t\t\t\t\t                        inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id \r\n\t\t\t\t\t                            inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id\r\n\t\t\t\t\t\t                        inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj \r\n\t\t\t\t                         where  lst.deleted = 0 and lst.isActive <> 0 and dog.FlagBreak = 0 and obj.dateEnd is null\r\n\t\t\t\t                         group by abnObjDog.id) ",
				this.method_11(),
				" select a.idAbn, a.codeAbonent, a.name as nameAbn, a.typeAbn, \r\n\t                                 a.TypeAbnName, a.deleted as deletedAbn, a.isActive as activeAbn,\r\n                                     a.id as idAbnObj, a.nameObj as nameAbnObj, a.KladrObjName, a.streetname,\r\n                                     cast(a.house as varchar(10)) + isnull(a.houseprefix, '') as house,\r\n                                     case when a.TypeAbn in (207,230,231) then isnull(ActiveObj.isActive, 0) else 1 end as objActive ",
				this.method_10(),
				" from vAbnObj a \r\n                                   left join ActiveObj on ActiveObj.idAbnObj = a.id ",
				this.method_12()
			}) + "\r\n" + this.method_13();
		}

		private string method_10()
		{
			string text = "";
			if (this.checkBox_4.Checked || this.checkBox_7.Checked || this.checkBox_6.Checked || this.checkBox_5.Checked)
			{
				text += "\r\n,link.idSchmObj ";
				if (this.checkBox_5.Checked)
				{
					text += "\r\n,cell.CellName ";
				}
				if (this.checkBox_6.Checked)
				{
					text += "\r\n,isnull(cell.BusName, bus.busname) as busname ";
				}
				if (this.checkBox_7.Checked)
				{
					text += "\r\n,isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname ";
				}
				if (this.checkBox_4.Checked)
				{
					text += "\r\n ,isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+\r\n\t\t\t                isnull('\\' + isnull(cell.BusName, bus.busname), '')+isnull('\\'+cell.CellName, '') as schmObjName ";
				}
				if (this.checkBox_4.Checked || this.checkBox_7.Checked)
				{
					text += "\r\n, isnull(cell.subid, isnull(bus.subid, sub.id)) as IdSub ";
				}
			}
			if (this.checkBox_9.Checked)
			{
				text += "\r\n,meter.Name as PointTypeMeter";
			}
			if (this.checkBox_8.Checked)
			{
				text += "\r\n,pReg.Number as PointNumber";
			}
			return text;
		}

		private string method_11()
		{
			string text = "";
			if (this.checkBox_4.Checked || this.checkBox_7.Checked || this.checkBox_6.Checked || this.checkBox_5.Checked)
			{
				text += ", cell\t(cellId, cellName, busId, busName, subId, subName, deleted) AS\r\n                            (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], \r\n\t\t                    bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],\r\n\t\t                    sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text], \r\n\t\t                    case when cell.deleted = 0 and bus.deleted = 0 and sub.deleted = 0 then 0 else 1 end\r\n                         FROM tSchm_ObjList AS bus\r\n\t                            JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'\r\n\t                            JOIN tSchm_ObjList AS point ON bus.id = point.IdParent\r\n\t                            JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj\r\n\t                            JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id\r\n\t                            JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'\r\n\t                            join tschm_objlist as sub on sub.id = bus.idparent\r\n\t                            JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id \r\n                            WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))\r\n";
				if (this.checkBox_4.Checked || this.checkBox_7.Checked || this.checkBox_6.Checked)
				{
					text += ", bus (Id, busName, subid, subname, deleted) AS\r\n                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, \r\n\t\t                                case when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end\r\n                                     FROM tSchm_ObjList AS o \r\n\t                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id\r\n\t                                    join tSChm_ObjList sub on sub.id = o.idParent\r\n\t                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id\r\n                                     WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0)))\r\n";
				}
				if (this.checkBox_4.Checked || this.checkBox_7.Checked)
				{
					text += ", sub (Id, FullName, deleted) AS\r\n                                (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted\r\n                                 FROM tSchm_ObjList AS o\r\n                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id\r\n                                 WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0)))\r\n";
				}
			}
			return text;
		}

		private string method_12()
		{
			string text = "";
			if (this.checkBox_4.Checked || this.checkBox_7.Checked || this.checkBox_6.Checked || this.checkBox_5.Checked)
			{
				text += " left join tl_SchmAbn link on link.idAbnObj = a.id\r\n";
				text += " left join cell on cell.cellid = link.idSchmObj\r\n";
				if (this.checkBox_4.Checked || this.checkBox_7.Checked || this.checkBox_6.Checked)
				{
					text += " left join bus on bus.id = link.idSChmObj\r\n";
				}
				if (this.checkBox_4.Checked || this.checkBox_7.Checked)
				{
					text += " left join sub on sub.id = link.idSChmObj\r\n";
				}
			}
			if (this.multiColumnComboBox_0.SelectedIndex >= 0 || this.checkBox_9.Checked || !string.IsNullOrEmpty(this.textBox_5.Text) || this.checkBox_8.Checked)
			{
				text += " left join tPoint p on p.idAbnObj = a.id\r\n";
				if (this.radioButton_1.Checked)
				{
					text += " left join tPointReg pReg on pReg.id = (select top 1 id \r\n                                                                          from tPointReg\r\n                                                                          where idPoint = p.id and [type] in (245,247,248)\r\n                                                                          order by datebegin desc)\r\n";
				}
				else
				{
					text += " left join tPointReg pReg on pReg.idPoint = p.id and pREg.[type] in (245,247,248)\r\n";
				}
				if (this.checkBox_9.Checked)
				{
					text += " left join tR_MarkMeter meter on meter.id = pREg.idMark\r\n";
				}
			}
			return text;
		}

		private string method_13()
		{
			string text = "";
			if (!string.IsNullOrEmpty(this.textBox_1.Text))
			{
				text += string.Format(" where (a.codeAbonent = {0}) ", this.textBox_1.Text);
			}
			if (!string.IsNullOrEmpty(this.textBox_0.Text))
			{
				string string_;
				if (this.checkBox_0.Checked)
				{
					string_ = string.Format("(a.name = '{0}') ", this.textBox_0.Text);
				}
				else
				{
					string_ = string.Format("(a.name like '%{0}%') ", this.textBox_0.Text);
				}
				text = this.method_14(text, string_);
			}
			if (this.checkedListBox_0.CheckedItems.Count > 0)
			{
				List<string> list = new List<string>();
				foreach (object obj in this.checkedListBox_0.CheckedItems)
				{
					list.Add(((Class229)obj).int_0.ToString());
				}
				string string_ = string.Format("(a.TypeAbn in ({0})) ", string.Join(",", list.ToArray()));
				text = this.method_14(text, string_);
			}
			if (this.checkBox_2.Checked)
			{
				string string_ = "(a.isActive = 1) ";
				text = this.method_14(text, string_);
			}
			if (!this.checkBox_1.Checked)
			{
				string string_ = "(a.deleted = 0) ";
				text = this.method_14(text, string_);
			}
			if (!string.IsNullOrEmpty(this.textBox_2.Text))
			{
				string string_;
				if (this.checkBox_0.Checked)
				{
					string_ = string.Format("(a.nameObj = '{0}') ", this.textBox_2.Text);
				}
				else
				{
					string_ = string.Format("(a.nameObj like '%{0}%') ", this.textBox_2.Text);
				}
				text = this.method_14(text, string_);
			}
			if (this.comboBox_3.SelectedIndex < 0)
			{
				if (this.comboBox_0.SelectedIndex >= 0)
				{
					string string_ = string.Format("(a.KladrObjId = {0})", this.comboBox_0.SelectedValue);
					text = this.method_14(text, string_);
				}
				else if (this.comboBox_1.SelectedIndex >= 0)
				{
					string string_;
					if (this.method_15(Convert.ToInt32(this.comboBox_1.SelectedValue)) > 0)
					{
						string_ = string.Format("(a.KladrObjId = {0})", this.comboBox_1.SelectedValue);
					}
					else
					{
						string_ = string.Format("(a.KladrObjParent = {0})", this.comboBox_1.SelectedValue);
					}
					text = this.method_14(text, string_);
				}
			}
			else
			{
				string string_ = string.Format("(a.idStreet = {0})", this.comboBox_3.SelectedValue);
				text = this.method_14(text, string_);
			}
			if (!string.IsNullOrEmpty(this.textBox_4.Text))
			{
				string string_ = string.Format("(a.house = {0})", this.textBox_4.Text);
				text = this.method_14(text, string_);
			}
			if (!string.IsNullOrEmpty(this.textBox_3.Text))
			{
				string string_;
				if (this.checkBox_0.Checked)
				{
					string_ = string.Format("(a.housePrefix = '{0}')", this.textBox_3.Text);
				}
				else
				{
					string_ = string.Format("(a.housePrefix like '%{0}%')", this.textBox_3.Text);
				}
				text = this.method_14(text, string_);
			}
			if (this.checkBox_3.Checked)
			{
				string string_ = "(a.TypeAbn not in (207,230,231) or activeObj.isActive = 1) ";
				text = this.method_14(text, string_);
			}
			if (this.multiColumnComboBox_0.SelectedIndex >= 0)
			{
				string string_ = string.Format("(pREg.idMark = {0})", this.multiColumnComboBox_0.SelectedValue);
				text = this.method_14(text, string_);
			}
			if (!string.IsNullOrEmpty(this.textBox_5.Text))
			{
				string string_;
				if (this.checkBox_0.Checked)
				{
					string_ = string.Format("(pReg.Number = '{0}')", this.textBox_5.Text);
				}
				else
				{
					string_ = string.Format("(pReg.Number like '%{0}%')", this.textBox_5.Text);
				}
				text = this.method_14(text, string_);
			}
			return text;
		}

		private string method_14(string string_0, string string_1)
		{
			if (string.IsNullOrEmpty(string_0))
			{
				string_0 = " where " + string_1;
			}
			else
			{
				string_0 = string_0 + "and " + string_1;
			}
			return string_0;
		}

		private int method_15(int int_0)
		{
			int result = 0;
			int result2;
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					try
					{
						using (SqlCommand sqlCommand = new SqlCommand())
						{
							sqlCommand.Connection = sqlConnection;
							sqlCommand.CommandTimeout = 0;
							sqlCommand.CommandText = "select count(*) from vAbnObj where KladrObjId = " + int_0.ToString();
							result = Convert.ToInt32(sqlCommand.ExecuteScalar());
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					finally
					{
						sqlConnection.Close();
					}
					return result;
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result2 = 0;
				}
			}
			return result2;
		}

		private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				if (Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_0.Name, e.RowIndex].Value))
				{
					e.CellStyle.BackColor = Color.Red;
					return;
				}
				int num = Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_23.Name, e.RowIndex].Value);
				if (num != 207)
				{
					if (num != 230)
					{
						if (num == 231)
						{
							e.CellStyle.ForeColor = Color.Blue;
						}
					}
					else
					{
						e.CellStyle.ForeColor = Color.Green;
					}
				}
				else
				{
					e.CellStyle.BackColor = Color.LightGray;
				}
				if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_1.Name, e.RowIndex].Value))
				{
					DataGridViewColumn dataGridViewColumn = this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex];
					if (dataGridViewColumn == this.dataGridViewFilterTextBoxColumn_16 || dataGridViewColumn == this.dataGridViewFilterTextBoxColumn_17 || dataGridViewColumn == this.dataGridViewFilterTextBoxColumn_18)
					{
						e.CellStyle.BackColor = Color.LightYellow;
					}
				}
				if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_2.Name, e.RowIndex].Value) && this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex] == this.dataGridViewFilterTextBoxColumn_19)
				{
					e.CellStyle.BackColor = Color.LightYellow;
				}
			}
		}

		private void dataGridViewExcelFilter_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right && e.Clicks == 1 && this.dataGridViewExcelFilter_0.CurrentRow != null)
			{
				DataGridViewRow currentRow = this.dataGridViewExcelFilter_0.CurrentRow;
				this.contextMenuStrip_0.Show(Cursor.Position);
			}
		}

		private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_2.SelectedIndex < 0)
			{
				this.comboBox_1.DataSource = null;
				return;
			}
			DataTable dataTable = this.method_5();
			this.comboBox_1.DisplayMember = "nameFull";
			this.comboBox_1.ValueMember = "id";
			this.comboBox_1.DataSource = dataTable;
			base.SelectSqlData(dataTable, true, " where ParentId = " + this.comboBox_2.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
			this.comboBox_1.SelectedIndex = -1;
		}

		private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedIndex < 0)
			{
				this.comboBox_0.DataSource = null;
				this.comboBox_3.DataSource = null;
				return;
			}
			DataTable dataTable = this.method_5();
			this.comboBox_0.DisplayMember = "namefull";
			this.comboBox_0.ValueMember = "id";
			this.comboBox_0.DataSource = dataTable;
			base.SelectSqlData(dataTable, true, " where ParentId = " + this.comboBox_1.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
			this.comboBox_0.SelectedIndex = -1;
			dataTable = this.method_6();
			this.comboBox_3.SelectedIndex = -1;
			this.comboBox_3.DisplayMember = "namefull";
			this.comboBox_3.ValueMember = "id";
			this.comboBox_3.DataSource = dataTable;
			base.SelectSqlData(dataTable, true, " where KladrObjId = " + this.comboBox_1.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
			this.comboBox_3.SelectedIndex = -1;
		}

		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_0.SelectedIndex < 0)
			{
				this.comboBox_3.DataSource = null;
				return;
			}
			DataTable dataTable = this.method_6();
			this.comboBox_3.SelectedIndex = -1;
			this.comboBox_3.DisplayMember = "namefull";
			this.comboBox_3.ValueMember = "id";
			this.comboBox_3.DataSource = dataTable;
			base.SelectSqlData(dataTable, true, " where KladrObjId = " + this.comboBox_0.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
			this.comboBox_3.SelectedIndex = -1;
		}

		private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.CurrentRow != null)
			{
				if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterCheckBoxColumn_0.Name].Value))
				{
					int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_23.Name].Value);
					if (num <= 207)
					{
						if (num == 206)
						{
							goto IL_AA;
						}
						if (num == 207)
						{
							goto IL_B8;
						}
					}
					else
					{
						if (num == 230 || num == 231)
						{
							goto IL_B8;
						}
						if (num == 253)
						{
							goto IL_AA;
						}
					}
					this.toolStripMenuItem_0.Enabled = false;
					goto IL_D2;
					IL_AA:
					this.toolStripMenuItem_0.Enabled = true;
					goto IL_D2;
					IL_B8:
					this.toolStripMenuItem_0.Enabled = true;
				}
				else
				{
					this.toolStripMenuItem_0.Enabled = false;
				}
				IL_D2:
				if (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_29.Name].Value == DBNull.Value)
				{
					this.toolStripMenuItem_1.Enabled = false;
					this.toolStripMenuItem_1.Tag = null;
				}
				else
				{
					this.toolStripMenuItem_1.Tag = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_29.Name].Value;
					this.toolStripMenuItem_1.Enabled = true;
				}
				if (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_30.Name].Value == DBNull.Value)
				{
					this.toolStripMenuItem_3.Enabled = false;
					this.toolStripMenuItem_3.Tag = null;
					this.toolStripMenuItem_4.Enabled = false;
					this.toolStripMenuItem_4.Tag = null;
					return;
				}
				this.toolStripMenuItem_3.Tag = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_30.Name].Value;
				this.toolStripMenuItem_3.Enabled = true;
				this.toolStripMenuItem_4.Tag = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_30.Name].Value;
				this.toolStripMenuItem_4.Enabled = true;
			}
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			if (sender is ToolStripMenuItem && ((ToolStripMenuItem)sender).Tag != null)
			{
				this.OnGoToSchema(new GoToSchemaEventArgs(Convert.ToInt32(((ToolStripMenuItem)sender).Tag)));
			}
		}

		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			if (sender is ToolStripMenuItem && ((ToolStripMenuItem)sender).Tag != null)
			{
				this.OnGoToSchema(new GoToSchemaEventArgs(Convert.ToInt32(((ToolStripMenuItem)sender).Tag)));
			}
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_23.Name].Value);
			if (num <= 207)
			{
				if (num != 206)
				{
					if (num != 207)
					{
						return;
					}
					goto IL_FF;
				}
			}
			else
			{
				if (num == 230 || num == 231)
				{
					goto IL_FF;
				}
				if (num != 253)
				{
					return;
				}
			}
			FormAbonent formAbonent = new FormAbonent(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_16.Name].Value), Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_23.Name].Value));
			formAbonent.SqlSettings = this.SqlSettings;
			if (base.DockPanel == null)
			{
				formAbonent.MdiParent = base.MdiParent;
			}
			else
			{
				formAbonent.MdiParent = base.DockPanel.FindForm().MdiParent;
			}
			formAbonent.Show();
			return;
			IL_FF:
			FormAbn formAbn = new FormAbn(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_16.Name].Value), Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_31.Name].Value));
			formAbn.SqlSettings = this.SqlSettings;
			if (base.DockPanel == null)
			{
				formAbn.MdiParent = base.MdiParent;
			}
			else
			{
				formAbn.MdiParent = base.DockPanel.FindForm().MdiParent;
			}
			formAbn.Show();
		}

		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			FormDockPassport formDockPassport = new FormDockPassport(this.SqlSettings, Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
			if (base.DockPanel == null)
			{
				formDockPassport.MdiParent = base.MdiParent;
				formDockPassport.Show();
				return;
			}
			formDockPassport.Show(base.DockPanel);
		}

		protected override XmlDocument CreateXmlConfig()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
			xmlDocument.AppendChild(newChild);
			XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
			xmlDocument.AppendChild(xmlNode);
			XmlNode xmlNode2 = xmlDocument.CreateElement("AddColumn");
			xmlNode.AppendChild(xmlNode2);
			if (this.checkBox_7.Checked)
			{
				XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("ColSub");
				xmlAttribute.Value = this.checkBox_7.Checked.ToString();
				xmlNode2.Attributes.Append(xmlAttribute);
			}
			if (this.checkBox_6.Checked)
			{
				XmlAttribute xmlAttribute2 = xmlDocument.CreateAttribute("ColBus");
				xmlAttribute2.Value = this.checkBox_6.Checked.ToString();
				xmlNode2.Attributes.Append(xmlAttribute2);
			}
			if (this.checkBox_5.Checked)
			{
				XmlAttribute xmlAttribute3 = xmlDocument.CreateAttribute("ColCell");
				xmlAttribute3.Value = this.checkBox_5.Checked.ToString();
				xmlNode2.Attributes.Append(xmlAttribute3);
			}
			if (this.checkBox_4.Checked)
			{
				XmlAttribute xmlAttribute4 = xmlDocument.CreateAttribute("ColSchmObj");
				xmlAttribute4.Value = this.checkBox_4.Checked.ToString();
				xmlNode2.Attributes.Append(xmlAttribute4);
			}
			XmlNode xmlNode3 = xmlDocument.CreateElement("TypeAbn");
			xmlNode.AppendChild(xmlNode3);
			foreach (object obj in this.checkedListBox_0.CheckedItems)
			{
				XmlNode xmlNode4 = xmlDocument.CreateElement("row");
				xmlNode4.InnerText = ((Class229)obj).int_0.ToString();
				xmlNode3.AppendChild(xmlNode4);
			}
			int num;
			if (this.comboBox_0.SelectedIndex >= 0)
			{
				num = Convert.ToInt32(this.comboBox_0.SelectedValue);
			}
			else if (this.comboBox_1.SelectedIndex >= 0)
			{
				num = Convert.ToInt32(this.comboBox_1.SelectedValue);
			}
			else
			{
				num = Convert.ToInt32(this.comboBox_2.SelectedValue);
			}
			XmlAttribute xmlAttribute5 = xmlDocument.CreateAttribute("IdKladrObj");
			xmlAttribute5.Value = num.ToString();
			xmlNode.Attributes.Append(xmlAttribute5);
			return xmlDocument;
		}

		protected override void ApplyConfig(XmlDocument doc)
		{
			new List<int>();
			XmlNode xmlNode = doc.SelectSingleNode(base.Name);
			if (xmlNode == null)
			{
				return;
			}
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("AddColumn");
			if (xmlNode2 != null)
			{
				XmlAttribute xmlAttribute = xmlNode2.Attributes["ColSub"];
				if (xmlAttribute != null)
				{
					this.checkBox_7.Checked = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = xmlNode2.Attributes["ColBus"];
				if (xmlAttribute != null)
				{
					this.checkBox_6.Checked = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = xmlNode2.Attributes["ColCell"];
				if (xmlAttribute != null)
				{
					this.checkBox_5.Checked = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = xmlNode2.Attributes["ColSchmObj"];
				if (xmlAttribute != null)
				{
					this.checkBox_4.Checked = Convert.ToBoolean(xmlAttribute.Value);
				}
			}
			XmlNode xmlNode3 = xmlNode.SelectSingleNode("TypeAbn");
			if (xmlNode3 != null)
			{
				List<int> list = new List<int>();
				foreach (object obj in xmlNode3.SelectNodes("row"))
				{
					XmlNode xmlNode4 = (XmlNode)obj;
					if (!string.IsNullOrEmpty(xmlNode4.InnerText))
					{
						list.Add(Convert.ToInt32(xmlNode4.InnerText));
					}
				}
				for (int i = 0; i < this.checkedListBox_0.Items.Count; i++)
				{
					if (list.Contains(((Class229)this.checkedListBox_0.Items[i]).int_0))
					{
						this.checkedListBox_0.SetItemChecked(i, true);
					}
					else
					{
						this.checkedListBox_0.SetItemChecked(i, false);
					}
				}
			}
			XmlAttribute xmlAttribute2 = xmlNode.Attributes["IdKladrObj"];
			if (xmlAttribute2 != null)
			{
				List<DataRow> list_ = new List<DataRow>();
				this.method_2(Convert.ToInt32(xmlAttribute2.Value), list_);
				this.method_3(list_);
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBox_0.Text);
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBox_0.Text);
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBox_0.Text);
		}

		private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (e.Modifiers == Keys.None)
				{
					this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBox_0.Text);
				}
				if (e.Modifiers == Keys.Shift)
				{
					this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBox_0.Text);
				}
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			this.dataGridViewExcelFilter_0.ExportToExcel();
		}

		private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_1 && this.multiColumnComboBox_0.Items.Count == 0)
			{
				this.method_7();
			}
		}

		private void multiColumnComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.multiColumnComboBox_0.SelectedIndex < 0)
			{
				this.checkBox_9.Checked = false;
				return;
			}
			this.checkBox_9.Checked = true;
		}

		private void textBox_5_TextChanged(object sender, EventArgs e)
		{
			this.checkBox_8.Checked = !string.IsNullOrEmpty(this.textBox_5.Text);
		}

		private void method_16()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripProgressBar_0 = new ToolStripProgressBar();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripTextBox_0 = new ToolStripTextBox();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_3 = new ToolStripButton();
			this.splitContainer_0 = new SplitContainer();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.groupBox_1 = new GroupBox();
			this.checkBox_3 = new CheckBox();
			this.label_8 = new Label();
			this.textBox_3 = new TextBox();
			this.textBox_4 = new TextBox();
			this.label_9 = new Label();
			this.comboBox_3 = new ComboBox();
			this.label_7 = new Label();
			this.label_4 = new Label();
			this.comboBox_0 = new ComboBox();
			this.comboBox_1 = new ComboBox();
			this.label_5 = new Label();
			this.comboBox_2 = new ComboBox();
			this.label_6 = new Label();
			this.textBox_2 = new TextBox();
			this.label_3 = new Label();
			this.groupBox_0 = new GroupBox();
			this.checkBox_1 = new CheckBox();
			this.checkBox_2 = new CheckBox();
			this.checkedListBox_0 = new CheckedListBox();
			this.label_0 = new Label();
			this.textBox_0 = new TextBox();
			this.label_1 = new Label();
			this.textBox_1 = new TextBox();
			this.label_2 = new Label();
			this.tabPage_1 = new TabPage();
			this.groupBox_3 = new GroupBox();
			this.label_11 = new Label();
			this.textBox_5 = new TextBox();
			this.multiColumnComboBox_0 = new MultiColumnComboBox();
			this.label_10 = new Label();
			this.radioButton_0 = new RadioButton();
			this.radioButton_1 = new RadioButton();
			this.tabPage_2 = new TabPage();
			this.groupBox_4 = new GroupBox();
			this.checkBox_8 = new CheckBox();
			this.checkBox_9 = new CheckBox();
			this.groupBox_2 = new GroupBox();
			this.checkBox_4 = new CheckBox();
			this.checkBox_5 = new CheckBox();
			this.checkBox_6 = new CheckBox();
			this.checkBox_7 = new CheckBox();
			this.checkBox_0 = new CheckBox();
			this.button_0 = new Button();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
			this.dataGridViewFilterCheckBoxColumn_1 = new DataGridViewFilterCheckBoxColumn();
			this.dataGridViewFilterCheckBoxColumn_2 = new DataGridViewFilterCheckBoxColumn();
			this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_24 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_25 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_26 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_27 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_28 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_29 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_30 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_31 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_32 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_33 = new DataGridViewFilterTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
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
			this.dataColumn_8 = new DataColumn();
			this.dataColumn_9 = new DataColumn();
			this.dataColumn_10 = new DataColumn();
			this.dataColumn_11 = new DataColumn();
			this.dataColumn_12 = new DataColumn();
			this.dataColumn_13 = new DataColumn();
			this.dataColumn_14 = new DataColumn();
			this.dataColumn_15 = new DataColumn();
			this.dataColumn_16 = new DataColumn();
			this.dataColumn_17 = new DataColumn();
			this.dataColumn_18 = new DataColumn();
			this.dataColumn_19 = new DataColumn();
			this.dataColumn_20 = new DataColumn();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			this.toolStrip_0.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			this.groupBox_3.SuspendLayout();
			this.tabPage_2.SuspendLayout();
			this.groupBox_4.SuspendLayout();
			this.groupBox_2.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			this.contextMenuStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripProgressBar_0,
				this.toolStripButton_0,
				this.toolStripTextBox_0,
				this.toolStripButton_1,
				this.toolStripButton_2,
				this.toolStripSeparator_0,
				this.toolStripButton_3
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStripMain";
			this.toolStrip_0.Size = new Size(1083, 25);
			this.toolStrip_0.TabIndex = 0;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripProgressBar_0.Alignment = ToolStripItemAlignment.Right;
			this.toolStripProgressBar_0.Name = "progressBar";
			this.toolStripProgressBar_0.Size = new Size(100, 22);
			this.toolStripProgressBar_0.Style = ProgressBarStyle.Marquee;
			this.toolStripProgressBar_0.Visible = false;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.Find;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolBtnFind";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Поиск";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripTextBox_0.Name = "toolTextFind";
			this.toolStripTextBox_0.Size = new Size(100, 25);
			this.toolStripTextBox_0.ToolTipText = "Текст для поиска";
			this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.FindPrev;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolBtnFindPrev";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Поиск назад";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.FindNext;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolBtnFindNext";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Поиск вперед";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.microsoftoffice2007excel_7581;
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "tooBtnExportToExcel";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Экспорт в Excel";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(0, 25);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Panel1.Controls.Add(this.tabControl_0);
			this.splitContainer_0.Panel1.Controls.Add(this.checkBox_0);
			this.splitContainer_0.Panel1.Controls.Add(this.button_0);
			this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_0);
			this.splitContainer_0.Size = new Size(1083, 643);
			this.splitContainer_0.SplitterDistance = 265;
			this.splitContainer_0.TabIndex = 1;
			this.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Controls.Add(this.tabPage_2);
			this.tabControl_0.Location = new Point(4, 3);
			this.tabControl_0.Name = "tabControlFilter";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(259, 559);
			this.tabControl_0.TabIndex = 0;
			this.tabControl_0.SelectedIndexChanged += this.tabControl_0_SelectedIndexChanged;
			this.tabPage_0.AutoScroll = true;
			this.tabPage_0.Controls.Add(this.groupBox_1);
			this.tabPage_0.Controls.Add(this.groupBox_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPageFilter";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(251, 533);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Фильтр";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.groupBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_1.Controls.Add(this.checkBox_3);
			this.groupBox_1.Controls.Add(this.label_8);
			this.groupBox_1.Controls.Add(this.textBox_3);
			this.groupBox_1.Controls.Add(this.textBox_4);
			this.groupBox_1.Controls.Add(this.label_9);
			this.groupBox_1.Controls.Add(this.comboBox_3);
			this.groupBox_1.Controls.Add(this.label_7);
			this.groupBox_1.Controls.Add(this.label_4);
			this.groupBox_1.Controls.Add(this.comboBox_0);
			this.groupBox_1.Controls.Add(this.comboBox_1);
			this.groupBox_1.Controls.Add(this.label_5);
			this.groupBox_1.Controls.Add(this.comboBox_2);
			this.groupBox_1.Controls.Add(this.label_6);
			this.groupBox_1.Controls.Add(this.textBox_2);
			this.groupBox_1.Controls.Add(this.label_3);
			this.groupBox_1.Location = new Point(0, 253);
			this.groupBox_1.Name = "groupBoxAbnObj";
			this.groupBox_1.Size = new Size(251, 206);
			this.groupBox_1.TabIndex = 1;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Объект абонента";
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.Checked = true;
			this.checkBox_3.CheckState = CheckState.Checked;
			this.checkBox_3.Location = new Point(9, 180);
			this.checkBox_3.Name = "chkActiveAbnObj";
			this.checkBox_3.Size = new Size(115, 17);
			this.checkBox_3.TabIndex = 27;
			this.checkBox_3.Text = "Только активные";
			this.checkBox_3.UseVisualStyleBackColor = true;
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(106, 157);
			this.label_8.Name = "label7";
			this.label_8.Size = new Size(35, 13);
			this.label_8.TabIndex = 25;
			this.label_8.Text = "Преф";
			this.textBox_3.Location = new Point(147, 154);
			this.textBox_3.Name = "txtHousePrefix";
			this.textBox_3.Size = new Size(38, 20);
			this.textBox_3.TabIndex = 26;
			this.textBox_4.Location = new Point(48, 154);
			this.textBox_4.Name = "txtHouse";
			this.textBox_4.Size = new Size(41, 20);
			this.textBox_4.TabIndex = 24;
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(5, 157);
			this.label_9.Name = "label8";
			this.label_9.Size = new Size(30, 13);
			this.label_9.TabIndex = 23;
			this.label_9.Text = "Дом";
			this.comboBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_3.DisplayMember = "tR_KladrStreet.NameSocr";
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(92, 130);
			this.comboBox_3.Name = "cmbStreet";
			this.comboBox_3.Size = new Size(152, 21);
			this.comboBox_3.TabIndex = 22;
			this.comboBox_3.ValueMember = "tR_KladrStreet.Id";
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(6, 133);
			this.label_7.Name = "label6";
			this.label_7.Size = new Size(39, 13);
			this.label_7.TabIndex = 21;
			this.label_7.Text = "Улица";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(6, 106);
			this.label_4.Name = "label5";
			this.label_4.Size = new Size(61, 13);
			this.label_4.TabIndex = 19;
			this.label_4.Text = "Нас. пункт";
			this.comboBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.DisplayMember = "tR_KladrObj.NameSocr";
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(92, 103);
			this.comboBox_0.Name = "cmbCity";
			this.comboBox_0.Size = new Size(152, 21);
			this.comboBox_0.TabIndex = 20;
			this.comboBox_0.ValueMember = "tR_KladrObj.Id";
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			this.comboBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_1.DisplayMember = "tR_KladrObj.NameSocr";
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(92, 75);
			this.comboBox_1.Name = "cmbRaionObl";
			this.comboBox_1.Size = new Size(152, 21);
			this.comboBox_1.TabIndex = 18;
			this.comboBox_1.ValueMember = "tR_KladrObj.Id";
			this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(3, 78);
			this.label_5.Name = "labelRaionObl";
			this.label_5.Size = new Size(72, 13);
			this.label_5.TabIndex = 17;
			this.label_5.Text = "Район/город";
			this.comboBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.comboBox_2.DisplayMember = "tR_KladrObj.NameSocr";
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(92, 48);
			this.comboBox_2.Name = "cmbObl";
			this.comboBox_2.Size = new Size(152, 21);
			this.comboBox_2.TabIndex = 16;
			this.comboBox_2.ValueMember = "tR_KladrObj.Id";
			this.comboBox_2.SelectedIndexChanged += this.comboBox_2_SelectedIndexChanged;
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(6, 51);
			this.label_6.Name = "labelObl";
			this.label_6.Size = new Size(50, 13);
			this.label_6.TabIndex = 15;
			this.label_6.Text = "Область";
			this.textBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_2.Location = new Point(92, 22);
			this.textBox_2.Name = "txtNameAbnObj";
			this.textBox_2.Size = new Size(153, 20);
			this.textBox_2.TabIndex = 5;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(6, 25);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(83, 13);
			this.label_3.TabIndex = 4;
			this.label_3.Text = "Наименование";
			this.groupBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_0.Controls.Add(this.checkBox_1);
			this.groupBox_0.Controls.Add(this.checkBox_2);
			this.groupBox_0.Controls.Add(this.checkedListBox_0);
			this.groupBox_0.Controls.Add(this.label_0);
			this.groupBox_0.Controls.Add(this.textBox_0);
			this.groupBox_0.Controls.Add(this.label_1);
			this.groupBox_0.Controls.Add(this.textBox_1);
			this.groupBox_0.Controls.Add(this.label_2);
			this.groupBox_0.Location = new Point(0, 0);
			this.groupBox_0.Name = "groupBoxAbn";
			this.groupBox_0.Size = new Size(251, 253);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Абонент";
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Location = new Point(9, 230);
			this.checkBox_1.Name = "chkShowDelAbn";
			this.checkBox_1.Size = new Size(132, 17);
			this.checkBox_1.TabIndex = 7;
			this.checkBox_1.Text = "Показать удаленных";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Checked = true;
			this.checkBox_2.CheckState = CheckState.Checked;
			this.checkBox_2.Location = new Point(9, 207);
			this.checkBox_2.Name = "chkActiveAbn";
			this.checkBox_2.Size = new Size(115, 17);
			this.checkBox_2.TabIndex = 6;
			this.checkBox_2.Text = "Только активные";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.checkedListBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.checkedListBox_0.CheckOnClick = true;
			this.checkedListBox_0.FormattingEnabled = true;
			this.checkedListBox_0.Location = new Point(6, 92);
			this.checkedListBox_0.Name = "chkTypeAbn";
			this.checkedListBox_0.Size = new Size(239, 109);
			this.checkedListBox_0.TabIndex = 5;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(6, 76);
			this.label_0.Name = "label3";
			this.label_0.Size = new Size(76, 13);
			this.label_0.TabIndex = 4;
			this.label_0.Text = "Тип абонента";
			this.textBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_0.Location = new Point(92, 48);
			this.textBox_0.Name = "txtNameAbn";
			this.textBox_0.Size = new Size(153, 20);
			this.textBox_0.TabIndex = 3;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(6, 51);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(83, 13);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Наименование";
			this.textBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_1.Location = new Point(92, 22);
			this.textBox_1.Name = "txtCodeAbn";
			this.textBox_1.Size = new Size(153, 20);
			this.textBox_1.TabIndex = 1;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(6, 25);
			this.label_2.Name = "label1";
			this.label_2.Size = new Size(26, 13);
			this.label_2.TabIndex = 0;
			this.label_2.Text = "Код";
			this.tabPage_1.AutoScroll = true;
			this.tabPage_1.Controls.Add(this.groupBox_3);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tabPageFilterAdd";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(251, 533);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Расширенный фильтр";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.groupBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_3.Controls.Add(this.label_11);
			this.groupBox_3.Controls.Add(this.textBox_5);
			this.groupBox_3.Controls.Add(this.multiColumnComboBox_0);
			this.groupBox_3.Controls.Add(this.label_10);
			this.groupBox_3.Controls.Add(this.radioButton_0);
			this.groupBox_3.Controls.Add(this.radioButton_1);
			this.groupBox_3.Location = new Point(0, 0);
			this.groupBox_3.Name = "groupBoxPoint";
			this.groupBox_3.Size = new Size(251, 337);
			this.groupBox_3.TabIndex = 0;
			this.groupBox_3.TabStop = false;
			this.groupBox_3.Text = "Точка учета";
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(6, 72);
			this.label_11.Name = "label10";
			this.label_11.Size = new Size(89, 13);
			this.label_11.TabIndex = 6;
			this.label_11.Text = "Номер счетчика";
			this.textBox_5.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_5.Location = new Point(101, 69);
			this.textBox_5.Name = "txtPointNumber";
			this.textBox_5.Size = new Size(143, 20);
			this.textBox_5.TabIndex = 5;
			this.textBox_5.TextChanged += this.textBox_5_TextChanged;
			this.multiColumnComboBox_0.AutoComplete = true;
			this.multiColumnComboBox_0.AutoDropdown = true;
			this.multiColumnComboBox_0.BackColorEven = Color.White;
			this.multiColumnComboBox_0.BackColorOdd = Color.White;
			this.multiColumnComboBox_0.ColumnNames = "";
			this.multiColumnComboBox_0.ColumnWidthDefault = 75;
			this.multiColumnComboBox_0.ColumnWidths = "0;100;25;25;30;25";
			this.multiColumnComboBox_0.DrawMode = DrawMode.OwnerDrawVariable;
			this.multiColumnComboBox_0.FormattingEnabled = true;
			this.multiColumnComboBox_0.LinkedColumnIndex = 0;
			this.multiColumnComboBox_0.LinkedTextBox = null;
			this.multiColumnComboBox_0.Location = new Point(101, 42);
			this.multiColumnComboBox_0.Name = "cmbPointTypeMeter";
			this.multiColumnComboBox_0.Size = new Size(144, 21);
			this.multiColumnComboBox_0.TabIndex = 4;
			this.multiColumnComboBox_0.SelectedIndexChanged += this.multiColumnComboBox_0_SelectedIndexChanged;
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(6, 45);
			this.label_10.Name = "label9";
			this.label_10.Size = new Size(74, 13);
			this.label_10.TabIndex = 2;
			this.label_10.Text = "Тип счетчика";
			this.radioButton_0.AutoSize = true;
			this.radioButton_0.Location = new Point(120, 19);
			this.radioButton_0.Name = "rbPointAll";
			this.radioButton_0.Size = new Size(44, 17);
			this.radioButton_0.TabIndex = 1;
			this.radioButton_0.TabStop = true;
			this.radioButton_0.Text = "Все";
			this.toolTip_0.SetToolTip(this.radioButton_0, "Все счетчики, включая демонтированные");
			this.radioButton_0.UseVisualStyleBackColor = true;
			this.radioButton_1.AutoSize = true;
			this.radioButton_1.Checked = true;
			this.radioButton_1.Location = new Point(8, 19);
			this.radioButton_1.Name = "rbPointCurrent";
			this.radioButton_1.Size = new Size(97, 17);
			this.radioButton_1.TabIndex = 0;
			this.radioButton_1.TabStop = true;
			this.radioButton_1.Text = "Действующие";
			this.toolTip_0.SetToolTip(this.radioButton_1, "Счетчики, которые установлены в данный момент");
			this.radioButton_1.UseVisualStyleBackColor = true;
			this.tabPage_2.AutoScroll = true;
			this.tabPage_2.Controls.Add(this.groupBox_4);
			this.tabPage_2.Controls.Add(this.groupBox_2);
			this.tabPage_2.Location = new Point(4, 22);
			this.tabPage_2.Name = "tabPageAddColumn";
			this.tabPage_2.Padding = new Padding(3);
			this.tabPage_2.Size = new Size(251, 533);
			this.tabPage_2.TabIndex = 2;
			this.tabPage_2.Text = "Доп столбцы";
			this.tabPage_2.UseVisualStyleBackColor = true;
			this.groupBox_4.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_4.Controls.Add(this.checkBox_8);
			this.groupBox_4.Controls.Add(this.checkBox_9);
			this.groupBox_4.Location = new Point(0, 111);
			this.groupBox_4.Name = "groupBoxPointAddColumn";
			this.groupBox_4.Size = new Size(251, 100);
			this.groupBox_4.TabIndex = 1;
			this.groupBox_4.TabStop = false;
			this.groupBox_4.Text = "Точка учета";
			this.checkBox_8.AutoSize = true;
			this.checkBox_8.Location = new Point(8, 42);
			this.checkBox_8.Name = "chkPointNumber";
			this.checkBox_8.Size = new Size(108, 17);
			this.checkBox_8.TabIndex = 1;
			this.checkBox_8.Text = "Номер счетчика";
			this.checkBox_8.UseVisualStyleBackColor = true;
			this.checkBox_9.AutoSize = true;
			this.checkBox_9.Location = new Point(8, 19);
			this.checkBox_9.Name = "chkPointTypeMeter";
			this.checkBox_9.Size = new Size(93, 17);
			this.checkBox_9.TabIndex = 0;
			this.checkBox_9.Text = "Тип счетчика";
			this.checkBox_9.UseVisualStyleBackColor = true;
			this.groupBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_2.Controls.Add(this.checkBox_4);
			this.groupBox_2.Controls.Add(this.checkBox_5);
			this.groupBox_2.Controls.Add(this.checkBox_6);
			this.groupBox_2.Controls.Add(this.checkBox_7);
			this.groupBox_2.Location = new Point(0, 0);
			this.groupBox_2.Name = "groupBoxLinkSchm";
			this.groupBox_2.Size = new Size(251, 115);
			this.groupBox_2.TabIndex = 0;
			this.groupBox_2.TabStop = false;
			this.groupBox_2.Text = "Привязка к схеме";
			this.checkBox_4.AutoSize = true;
			this.checkBox_4.Location = new Point(8, 88);
			this.checkBox_4.Name = "chkSchmObjName";
			this.checkBox_4.Size = new Size(183, 17);
			this.checkBox_4.TabIndex = 3;
			this.checkBox_4.Text = "Наименование объекта схемы";
			this.checkBox_4.UseVisualStyleBackColor = true;
			this.checkBox_5.AutoSize = true;
			this.checkBox_5.Location = new Point(8, 65);
			this.checkBox_5.Name = "chkCellName";
			this.checkBox_5.Size = new Size(63, 17);
			this.checkBox_5.TabIndex = 2;
			this.checkBox_5.Text = "Ячейка";
			this.checkBox_5.UseVisualStyleBackColor = true;
			this.checkBox_6.AutoSize = true;
			this.checkBox_6.Location = new Point(8, 42);
			this.checkBox_6.Name = "chkBusName";
			this.checkBox_6.Size = new Size(53, 17);
			this.checkBox_6.TabIndex = 1;
			this.checkBox_6.Text = "Шина";
			this.checkBox_6.UseVisualStyleBackColor = true;
			this.checkBox_7.AutoSize = true;
			this.checkBox_7.Location = new Point(8, 19);
			this.checkBox_7.Name = "chkSubName";
			this.checkBox_7.Size = new Size(110, 17);
			this.checkBox_7.TabIndex = 0;
			this.checkBox_7.Text = "Имя подстанции";
			this.checkBox_7.UseVisualStyleBackColor = true;
			this.checkBox_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Location = new Point(16, 565);
			this.checkBox_0.Name = "chkPrecision";
			this.checkBox_0.Size = new Size(134, 17);
			this.checkBox_0.TabIndex = 1;
			this.checkBox_0.Text = "Точное соответствие";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.button_0.Location = new Point(16, 608);
			this.button_0.Name = "buttonApplyFilter";
			this.button_0.Size = new Size(236, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterCheckBoxColumn_0,
				this.dataGridViewFilterCheckBoxColumn_1,
				this.dataGridViewFilterCheckBoxColumn_2,
				this.dataGridViewFilterTextBoxColumn_16,
				this.dataGridViewFilterTextBoxColumn_17,
				this.dataGridViewFilterTextBoxColumn_18,
				this.dataGridViewFilterTextBoxColumn_19,
				this.dataGridViewFilterTextBoxColumn_20,
				this.dataGridViewFilterTextBoxColumn_21,
				this.dataGridViewFilterTextBoxColumn_22,
				this.dataGridViewFilterTextBoxColumn_23,
				this.dataGridViewFilterTextBoxColumn_24,
				this.dataGridViewFilterTextBoxColumn_25,
				this.dataGridViewFilterTextBoxColumn_26,
				this.dataGridViewFilterTextBoxColumn_27,
				this.dataGridViewFilterTextBoxColumn_28,
				this.dataGridViewFilterTextBoxColumn_29,
				this.dataGridViewFilterTextBoxColumn_30,
				this.dataGridViewFilterTextBoxColumn_31,
				this.dataGridViewFilterTextBoxColumn_32,
				this.dataGridViewFilterTextBoxColumn_33
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_0.Name = "dgv";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewExcelFilter_0.Size = new Size(814, 643);
			this.dataGridViewExcelFilter_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.CellFormatting += this.dataGridViewExcelFilter_0_CellFormatting;
			this.dataGridViewExcelFilter_0.CellMouseClick += this.dataGridViewExcelFilter_0_CellMouseClick;
			this.dataGridViewFilterCheckBoxColumn_0.DataPropertyName = "deletedAbn";
			this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "Абонент удален";
			this.dataGridViewFilterCheckBoxColumn_0.Name = "deletedAbnDgvColumn";
			this.dataGridViewFilterCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewFilterCheckBoxColumn_0.Visible = false;
			this.dataGridViewFilterCheckBoxColumn_0.Width = 40;
			this.dataGridViewFilterCheckBoxColumn_1.DataPropertyName = "activeAbn";
			this.dataGridViewFilterCheckBoxColumn_1.HeaderText = "Активный абонент";
			this.dataGridViewFilterCheckBoxColumn_1.Name = "activeAbnDgvColumn";
			this.dataGridViewFilterCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterCheckBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterCheckBoxColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewFilterCheckBoxColumn_1.Visible = false;
			this.dataGridViewFilterCheckBoxColumn_2.DataPropertyName = "objActive";
			this.dataGridViewFilterCheckBoxColumn_2.HeaderText = "Активный объект";
			this.dataGridViewFilterCheckBoxColumn_2.Name = "objActiveDgvColumn";
			this.dataGridViewFilterCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewFilterCheckBoxColumn_2.Visible = false;
			this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "CodeAbonent";
			this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Код";
			this.dataGridViewFilterTextBoxColumn_16.Name = "codeAbonentDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "NameAbn";
			this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Абонент";
			this.dataGridViewFilterTextBoxColumn_17.Name = "nameAbnDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_17.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "TypeAbnName";
			this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Тип абонента";
			this.dataGridViewFilterTextBoxColumn_18.Name = "typeAbnNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "nameAbnObj";
			this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Объект";
			this.dataGridViewFilterTextBoxColumn_19.Name = "nameAbnObjDgvColumn";
			this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "KladrObjName";
			this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Нас. пункт";
			this.dataGridViewFilterTextBoxColumn_20.Name = "KladrObjNameDgvColumn";
			this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "StreetName";
			this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Улица";
			this.dataGridViewFilterTextBoxColumn_21.Name = "StreetNameDgvColumn";
			this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "House";
			this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Дом";
			this.dataGridViewFilterTextBoxColumn_22.Name = "houseDgvColumn";
			this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_23.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "TypeAbn";
			this.dataGridViewFilterTextBoxColumn_23.HeaderText = "TypeAbn";
			this.dataGridViewFilterTextBoxColumn_23.Name = "typeAbnDgvColumn";
			this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_23.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_23.Visible = false;
			this.dataGridViewFilterTextBoxColumn_24.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_24.DataPropertyName = "idAbn";
			this.dataGridViewFilterTextBoxColumn_24.HeaderText = "idAbn";
			this.dataGridViewFilterTextBoxColumn_24.Name = "idAbnDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_24.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_24.Visible = false;
			this.dataGridViewFilterTextBoxColumn_25.DataPropertyName = "SubName";
			this.dataGridViewFilterTextBoxColumn_25.HeaderText = "Подстанция";
			this.dataGridViewFilterTextBoxColumn_25.Name = "subNameDgvColumn";
			this.dataGridViewFilterTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_26.DataPropertyName = "BusName";
			this.dataGridViewFilterTextBoxColumn_26.HeaderText = "Шина";
			this.dataGridViewFilterTextBoxColumn_26.Name = "busNameDgvColumn";
			this.dataGridViewFilterTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_27.DataPropertyName = "CellName";
			this.dataGridViewFilterTextBoxColumn_27.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_27.Name = "cellNameDgvColumn";
			this.dataGridViewFilterTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_28.DataPropertyName = "SchmObjName";
			this.dataGridViewFilterTextBoxColumn_28.HeaderText = "Объект схемы";
			this.dataGridViewFilterTextBoxColumn_28.Name = "schmObjNameDgvColumn";
			this.dataGridViewFilterTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_29.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_29.DataPropertyName = "idSchmObj";
			this.dataGridViewFilterTextBoxColumn_29.HeaderText = "idSchmObj";
			this.dataGridViewFilterTextBoxColumn_29.Name = "idSchmObjDgvColumn";
			this.dataGridViewFilterTextBoxColumn_29.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_29.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_29.Visible = false;
			this.dataGridViewFilterTextBoxColumn_30.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_30.DataPropertyName = "IdSub";
			this.dataGridViewFilterTextBoxColumn_30.HeaderText = "IdSub";
			this.dataGridViewFilterTextBoxColumn_30.Name = "IdSubDgvColumn";
			this.dataGridViewFilterTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_30.Visible = false;
			this.dataGridViewFilterTextBoxColumn_31.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_31.DataPropertyName = "idAbnObj";
			this.dataGridViewFilterTextBoxColumn_31.HeaderText = "idAbnObj";
			this.dataGridViewFilterTextBoxColumn_31.Name = "idAbnObjDgvColumn";
			this.dataGridViewFilterTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_31.Visible = false;
			this.dataGridViewFilterTextBoxColumn_32.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_32.DataPropertyName = "PointTypeMeter";
			this.dataGridViewFilterTextBoxColumn_32.HeaderText = "Тип счетчика";
			this.dataGridViewFilterTextBoxColumn_32.Name = "pointTypeMeterDgvColumn";
			this.dataGridViewFilterTextBoxColumn_32.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_32.Visible = false;
			this.dataGridViewFilterTextBoxColumn_33.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_33.DataPropertyName = "PointNumber";
			this.dataGridViewFilterTextBoxColumn_33.HeaderText = "№ счетчика";
			this.dataGridViewFilterTextBoxColumn_33.Name = "pointNumberDgvColumn";
			this.dataGridViewFilterTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_33.Visible = false;
			this.bindingSource_0.DataMember = "TableFindAbn";
			this.bindingSource_0.DataSource = this.dataSet_0;
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_0
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
				this.dataColumn_9,
				this.dataColumn_10,
				this.dataColumn_11,
				this.dataColumn_12,
				this.dataColumn_13,
				this.dataColumn_14,
				this.dataColumn_15,
				this.dataColumn_16,
				this.dataColumn_17,
				this.dataColumn_18,
				this.dataColumn_19,
				this.dataColumn_20
			});
			this.dataTable_0.TableName = "TableFindAbn";
			this.dataColumn_0.ColumnName = "idAbn";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "CodeAbonent";
			this.dataColumn_1.DataType = typeof(int);
			this.dataColumn_2.ColumnName = "NameAbn";
			this.dataColumn_3.ColumnName = "TypeAbn";
			this.dataColumn_3.DataType = typeof(int);
			this.dataColumn_4.ColumnName = "TypeAbnName";
			this.dataColumn_5.ColumnName = "deletedAbn";
			this.dataColumn_5.DataType = typeof(bool);
			this.dataColumn_6.ColumnName = "activeAbn";
			this.dataColumn_6.DataType = typeof(bool);
			this.dataColumn_7.ColumnName = "nameAbnObj";
			this.dataColumn_8.ColumnName = "KladrObjName";
			this.dataColumn_9.ColumnName = "StreetName";
			this.dataColumn_10.ColumnName = "House";
			this.dataColumn_11.ColumnName = "objActive";
			this.dataColumn_11.DataType = typeof(bool);
			this.dataColumn_12.ColumnName = "SubName";
			this.dataColumn_13.ColumnName = "BusName";
			this.dataColumn_14.ColumnName = "CellName";
			this.dataColumn_15.ColumnName = "SchmObjName";
			this.dataColumn_16.ColumnName = "idSchmObj";
			this.dataColumn_17.ColumnName = "idAbnObj";
			this.dataColumn_17.DataType = typeof(int);
			this.dataColumn_18.ColumnName = "IdSub";
			this.dataColumn_18.DataType = typeof(int);
			this.dataColumn_19.ColumnName = "PointTypeMeter";
			this.dataColumn_20.ColumnName = "PointNumber";
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_2,
				this.toolStripMenuItem_4
			});
			this.contextMenuStrip_0.Name = "contextMenuDgv";
			this.contextMenuStrip_0.Size = new Size(190, 70);
			this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
			this.toolStripMenuItem_0.Image = Resources.Person;
			this.toolStripMenuItem_0.Name = "toolMenuShowAbn";
			this.toolStripMenuItem_0.Size = new Size(189, 22);
			this.toolStripMenuItem_0.Text = "Открыть карточку";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_2.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_3
			});
			this.toolStripMenuItem_2.Image = Resources.Scheme_Old;
			this.toolStripMenuItem_2.Name = "toolMenuSchema";
			this.toolStripMenuItem_2.Size = new Size(189, 22);
			this.toolStripMenuItem_2.Text = "Схема";
			this.toolStripMenuItem_1.Name = "toolMenuGoToSchemaSchmObj";
			this.toolStripMenuItem_1.Size = new Size(195, 22);
			this.toolStripMenuItem_1.Text = "Показать на схеме";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_3.Name = "toolMenuGoToSchemaSubstation";
			this.toolStripMenuItem_3.Size = new Size(195, 22);
			this.toolStripMenuItem_3.Text = "Показать подстанцию";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.toolStripMenuItem_4.Name = "toolMenuItemPassportSubstation";
			this.toolStripMenuItem_4.Size = new Size(189, 22);
			this.toolStripMenuItem_4.Text = "Паспорт подстанции";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.dataGridViewFilterTextBoxColumn_0.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "CodeAbonent";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Код";
			this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_1.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "NameAbn";
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Абонент";
			this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_2.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "TypeAbnName";
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Тип абонента";
			this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
			this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_3.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "nameAbnObj";
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Объект";
			this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
			this.dataGridViewFilterTextBoxColumn_4.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "KladrObjName";
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Нас. пункт";
			this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
			this.dataGridViewFilterTextBoxColumn_5.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "StreetName";
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Улица";
			this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn6";
			this.dataGridViewFilterTextBoxColumn_6.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "House";
			this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Дом";
			this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn7";
			this.dataGridViewFilterTextBoxColumn_7.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "SubName";
			this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Подстанция";
			this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn8";
			this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_7.Visible = false;
			this.dataGridViewFilterTextBoxColumn_8.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "BusName";
			this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Шина";
			this.dataGridViewFilterTextBoxColumn_8.Name = "dataGridViewFilterTextBoxColumn9";
			this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_8.Visible = false;
			this.dataGridViewFilterTextBoxColumn_9.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "CellName";
			this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_9.Name = "dataGridViewFilterTextBoxColumn10";
			this.dataGridViewFilterTextBoxColumn_10.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "SchmObjName";
			this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Объект схемы";
			this.dataGridViewFilterTextBoxColumn_10.Name = "dataGridViewFilterTextBoxColumn11";
			this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "CellName";
			this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_11.Name = "dataGridViewFilterTextBoxColumn12";
			this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "SchmObjName";
			this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Объект схемы";
			this.dataGridViewFilterTextBoxColumn_12.Name = "dataGridViewFilterTextBoxColumn13";
			this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "idSchmObj";
			this.dataGridViewFilterTextBoxColumn_13.HeaderText = "idSchmObj";
			this.dataGridViewFilterTextBoxColumn_13.Name = "dataGridViewFilterTextBoxColumn14";
			this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_13.Visible = false;
			this.dataGridViewFilterTextBoxColumn_14.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "IdSub";
			this.dataGridViewFilterTextBoxColumn_14.HeaderText = "IdSub";
			this.dataGridViewFilterTextBoxColumn_14.Name = "dataGridViewFilterTextBoxColumn15";
			this.dataGridViewFilterTextBoxColumn_14.Visible = false;
			this.dataGridViewFilterTextBoxColumn_15.AllowUserVisibleColumn = false;
			this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "idAbnObj";
			this.dataGridViewFilterTextBoxColumn_15.HeaderText = "idAbnObj";
			this.dataGridViewFilterTextBoxColumn_15.Name = "dataGridViewFilterTextBoxColumn16";
			this.dataGridViewFilterTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "TypeAbn";
			this.dataGridViewTextBoxColumn_0.HeaderText = "TypeAbn";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_1.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_2.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_2.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1083, 668);
			base.Controls.Add(this.splitContainer_0);
			base.Controls.Add(this.toolStrip_0);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Name = "FormJournalAbn";
			this.Text = "Журнал контрагентов";
			base.FormClosed += this.FormJournalAbn_FormClosed;
			base.Load += this.FormJournalAbn_Load;
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel1.PerformLayout();
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.tabPage_1.ResumeLayout(false);
			this.groupBox_3.ResumeLayout(false);
			this.groupBox_3.PerformLayout();
			this.tabPage_2.ResumeLayout(false);
			this.groupBox_4.ResumeLayout(false);
			this.groupBox_4.PerformLayout();
			this.groupBox_2.ResumeLayout(false);
			this.groupBox_2.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			this.contextMenuStrip_0.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void XRBwlkrlggkwFfmSF1g2(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private ToolStrip toolStrip_0;

		private SplitContainer splitContainer_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private GroupBox groupBox_0;

		private CheckedListBox checkedListBox_0;

		private Label label_0;

		private TextBox textBox_0;

		private Label label_1;

		private TextBox textBox_1;

		private Label label_2;

		private TabPage tabPage_1;

		private Button button_0;

		private ToolStripProgressBar toolStripProgressBar_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private BindingSource bindingSource_0;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		private BackgroundWorker backgroundWorker_0;

		private CheckBox checkBox_0;

		private DataColumn dataColumn_6;

		private CheckBox checkBox_1;

		private CheckBox checkBox_2;

		private GroupBox groupBox_1;

		private TextBox textBox_2;

		private Label label_3;

		private DataColumn dataColumn_7;

		private Label label_4;

		private ComboBox comboBox_0;

		private ComboBox comboBox_1;

		private Label label_5;

		private ComboBox comboBox_2;

		private Label label_6;

		private ComboBox comboBox_3;

		private Label label_7;

		private Label label_8;

		private TextBox textBox_3;

		private TextBox textBox_4;

		private Label label_9;

		private DataColumn dataColumn_8;

		private DataColumn dataColumn_9;

		private DataColumn dataColumn_10;

		private CheckBox checkBox_3;

		private DataColumn dataColumn_11;

		private TabPage tabPage_2;

		private GroupBox groupBox_2;

		private CheckBox checkBox_4;

		private CheckBox checkBox_5;

		private CheckBox checkBox_6;

		private CheckBox checkBox_7;

		private DataColumn dataColumn_12;

		private DataColumn dataColumn_13;

		private DataColumn dataColumn_14;

		private DataColumn dataColumn_15;

		private DataColumn dataColumn_16;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;

		private ContextMenuStrip contextMenuStrip_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private DataColumn dataColumn_17;

		private ToolStripButton toolStripButton_0;

		private ToolStripTextBox toolStripTextBox_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripButton toolStripButton_3;

		private DataColumn dataColumn_18;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripMenuItem toolStripMenuItem_4;

		private GroupBox groupBox_3;

		private Label label_10;

		private RadioButton radioButton_0;

		private ToolTip toolTip_0;

		private RadioButton radioButton_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;

		private Label label_11;

		private TextBox textBox_5;

		private MultiColumnComboBox multiColumnComboBox_0;

		private GroupBox groupBox_4;

		private CheckBox checkBox_8;

		private CheckBox checkBox_9;

		private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;

		private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_1;

		private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_2;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_20;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_21;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_22;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_23;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_24;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_25;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_26;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_27;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_28;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_29;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_30;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_31;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_32;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_33;

		private DataColumn dataColumn_19;

		private DataColumn dataColumn_20;
	}
}
