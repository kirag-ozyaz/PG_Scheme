using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.Scheme;
using Documents.Properties;
using FormLbr;
using FormLbr.Classes;

namespace Documents.Forms.JournalOrder
{
	public partial class FormJournalOrder : FormBase
	{
		public FormJournalOrder()
		{
			Class611.H9nE6ZDzTF9kb();
			this.dateTime_0 = new DateTime(DateTime.Now.Year, 1, 1);
			this.dateTime_1 = new DateTime(DateTime.Now.Year, 12, 31);
			this.dateTime_2 = DateTime.Now.Date;
			this.dateTime_3 = DateTime.Now.Date;
			this.list_1 = new List<int>();
			this.list_2 = new List<int>();
			this.list_3 = new List<int>();
			
			this.method_9();
		}

		public FormJournalOrder(List<int> checkedSubstation)
		{
			Class611.H9nE6ZDzTF9kb();
			this.dateTime_0 = new DateTime(DateTime.Now.Year, 1, 1);
			this.dateTime_1 = new DateTime(DateTime.Now.Year, 12, 31);
			this.dateTime_2 = DateTime.Now.Date;
			this.dateTime_3 = DateTime.Now.Date;
			this.list_1 = new List<int>();
			this.list_2 = new List<int>();
			this.list_3 = new List<int>();
			
			this.method_9();
			this.list_0 = checkedSubstation;
		}

		private void FormJournalOrder_Load(object sender, EventArgs e)
		{
			base.LoadFormConfig(null);
			this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
			this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 12, 31);
			this.method_0();
			this.treeViewSchmObjects_0.SqlSettings = this.SqlSettings;
			this.treeViewSchmObjects_0.Load(this.list_0);
			this.method_1();
			this.method_2();
		}

		private void FormJournalOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			base.SaveFormConfig(null);
		}

		private void method_0()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			base.SelectSqlData(dataTable, true, " where ((ParentKey = ';Other;DivisionOrder;' and isGRoup = 0)\r\n                                            or (ParentKey like ';Other;DivisionOrder;%;' and isGRoup = 1)) and deleted = 0 ", null, false, 0);
			if (dataTable.Rows.Count == 0)
			{
				this.toolStripDropDownButton_0.Visible = false;
				this.splitContainer_1.Panel2Collapsed = true;
				return;
			}
			this.toolStripButton_0.Visible = false;
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				toolStripMenuItem.Click += this.method_3;
				toolStripMenuItem.Text = dataRow["Name"].ToString();
				toolStripMenuItem.Tag = dataRow["id"];
				this.toolStripDropDownButton_0.DropDownItems.Add(toolStripMenuItem);
				bool isChecked = false;
				if (this.list_3 != null && this.list_3.Count != 0)
				{
					if (this.list_3.Contains(Convert.ToInt32(dataRow["id"])))
					{
						isChecked = true;
					}
				}
				else
				{
					isChecked = true;
				}
				this.checkedListBox_0.Items.Add(new FormJournalOrder.Class120(Convert.ToInt32(dataRow["id"]), dataRow["Name"].ToString()), isChecked);
			}
		}

		private void method_1()
		{
			this.Cursor = Cursors.WaitCursor;
			Control control = this.wshoYigBwWu;
			this.panel_0.Enabled = false;
			control.Enabled = false;
			string text = "";
			int num = -1;
			if (this.dataGridViewExcelFilter_0.CurrentRow != null)
			{
				num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_32.Name].Value);
			}
			text = string.Concat(new string[]
			{
				" (datebegin >= '",
				this.dateTime_0.ToString("yyyyMMdd"),
				"' and datebegin <= '",
				this.dateTime_1.ToString("yyyyMMdd"),
				" 23:59:59') "
			});
			string text2 = "";
			if (!this.checkBox_3.Checked && !this.checkBox_2.Checked && !this.checkBox_1.Checked && !this.checkBox_0.Checked)
			{
				text2 = " id < 0 ";
			}
			else
			{
				if (this.checkBox_3.Checked)
				{
					text2 = " (registered = 0)";
				}
				if (this.checkBox_2.Checked)
				{
					if (string.IsNullOrEmpty(text2))
					{
						text2 = " (registered <> 0 and beginRes is null and dateclose is null) ";
					}
					else
					{
						text2 += " or (registered <> 0 and beginRes is null and dateclose is null) ";
					}
				}
				if (this.checkBox_1.Checked)
				{
					if (string.IsNullOrEmpty(text2))
					{
						text2 = " (beginRes is not null and dateClose is null) ";
					}
					else
					{
						text2 += " or (beginRes is not null and dateClose is null) ";
					}
				}
				if (this.checkBox_0.Checked)
				{
					if (string.IsNullOrEmpty(text2))
					{
						text2 = " (dateclose is not null) ";
					}
					else
					{
						text2 += " or (dateclose is not null)";
					}
				}
			}
			if (this.checkedListBox_0.CheckedItems.Count > 0 && this.checkedListBox_0.CheckedItems.Count < this.checkedListBox_0.Items.Count)
			{
				string text3 = "";
				foreach (object obj in this.checkedListBox_0.CheckedItems)
				{
					if (string.IsNullOrEmpty(text3))
					{
						text3 = ((FormJournalOrder.Class120)obj).Id.ToString();
					}
					else
					{
						text3 = text3 + "," + ((FormJournalOrder.Class120)obj).Id.ToString();
					}
				}
				if (string.IsNullOrEmpty(text2))
				{
					text2 = string.Format(" (idDivision in ({0})) ", text3);
				}
				else
				{
					text2 = string.Format("({1}) and (idDivision in ({0})) ", text3, text2);
				}
			}
			if (string.IsNullOrEmpty(text2))
			{
				if (!string.IsNullOrEmpty(text))
				{
					text2 = text;
				}
			}
			else if (!string.IsNullOrEmpty(text))
			{
				text2 = string.Concat(new string[]
				{
					"(",
					text,
					") and (",
					text2,
					")"
				});
			}
			this.list_1 = this.treeViewSchmObjects_0.GetListChecked();
			string text4 = "";
			if (this.list_1.Count > 0)
			{
				foreach (int num2 in this.list_1)
				{
					text4 = text4 + num2.ToString() + ",";
				}
				text4 = text4.Remove(text4.Length - 1);
			}
			if (string.IsNullOrEmpty(text4))
			{
				text2 = " where " + text2;
				base.SelectSqlData(this.class469_0, this.class469_0.vJ_Order, true, text2 + " order by num");
			}
			else
			{
				if (this.checkBox_4.Checked)
				{
					string cmdText = string.Format("with sub (Id, FullName) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text]\r\n                                                    FROM tSchm_ObjList AS o\r\n                                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),\r\n                                                    bus (Id, busName, subid, subname) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name\r\n                                                    FROM tSchm_ObjList AS o \r\n                                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id\r\n                                                    join tSChm_ObjList sub on sub.id = o.idParent\r\n                                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),\r\n                                                    \r\n                                                    cell\t(cellId, cellName, busId, busName, subId, subName) AS\r\n                                                    (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], \r\n                                                    \t\t bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],\r\n                                                    \t\t sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text]\r\n                                                    FROM tSchm_ObjList AS bus\r\n                                                    JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'\r\n                                                    JOIN tSchm_ObjList AS point ON bus.id = point.IdParent\r\n                                                    JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj\r\n                                                    JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id\r\n                                                    JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'\r\n                                                    join tschm_objlist as sub on sub.id = bus.idparent\r\n                                                    JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id \r\n                                                    WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))\r\n                                                    \r\n                                                    select distinct vj_order.*  from vj_order\r\n                                                    \tinner join tL_OrderSchmObjList l on l.idOrder = vj_Order.id\r\n                                                    \tleft join cell on cell.cellid = l.idSchmObj\r\n                                                    \tleft join bus on bus.id = l.idSchmObj\r\n                                                    \tleft join sub on sub.id = l.idSchmObj\r\n                                                    where (l.idschmObj in ({0}) or isnull(cell.subId, ISNULL(bus.subid, sub.id)) in ({0}))\r\n                                                    and {1} ", text4, text2);
					using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
					{
						try
						{
							sqlConnection.Open();
							using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
							{
								SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
								sqlDataAdapter.SelectCommand = sqlCommand;
								this.class469_0.vJ_Order.Clear();
								sqlDataAdapter.Fill(this.class469_0.vJ_Order);
							}
							goto IL_467;
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, ex.Source);
							goto IL_467;
						}
					}
				}
				text2 = " inner join tL_OrderSchmObjList l on l.idOrder = vj_Order.id and l.idSchmObj in (" + text4 + ") where " + text2;
				base.SelectSqlData(this.class469_0, this.class469_0.vJ_Order, true, text2 + " order by num");
			}
			IL_467:
			if (num > 0)
			{
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
			}
			Control control2 = this.wshoYigBwWu;
			this.panel_0.Enabled = true;
			control2.Enabled = true;
			this.Cursor = Cursors.Default;
		}

		private void method_2()
		{
			string text = string.Concat(new string[]
			{
				" (EvntDate >= '",
				this.dateTime_2.ToString("yyyyMMdd"),
				"' and EvntDate <= '",
				this.dateTime_3.ToString("yyyyMMdd"),
				" 23:59:59') "
			});
			if (this.checkedListBox_0.CheckedItems.Count > 0 && this.checkedListBox_0.CheckedItems.Count < this.checkedListBox_0.Items.Count)
			{
				string text2 = "";
				foreach (object obj in this.checkedListBox_0.CheckedItems)
				{
					if (string.IsNullOrEmpty(text2))
					{
						text2 = ((FormJournalOrder.Class120)obj).Id.ToString();
					}
					else
					{
						text2 = text2 + "," + ((FormJournalOrder.Class120)obj).Id.ToString();
					}
				}
				if (string.IsNullOrEmpty(text))
				{
					text = string.Format(" (idDivision in ({0})) ", text2);
				}
				else
				{
					text = string.Format("({1}) and (idDivision in ({0})) ", text2, text);
				}
			}
			this.list_2 = this.treeViewSchmObjects_0.GetListChecked();
			string text3 = "";
			if (this.list_2.Count > 0)
			{
				foreach (int num in this.list_2)
				{
					text3 = text3 + num.ToString() + ",";
				}
				text3 = text3.Remove(text3.Length - 1);
			}
			if (string.IsNullOrEmpty(text3))
			{
				text = " where " + text;
				base.SelectSqlData(this.class469_0, this.class469_0.vJ_OrderEvents, true, text + " order by num");
				return;
			}
			if (this.checkBox_4.Checked)
			{
				string cmdText = string.Format("with sub (Id, FullName) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text]\r\n                                                    FROM tSchm_ObjList AS o\r\n                                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),\r\n                                                    bus (Id, busName, subid, subname) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name\r\n                                                    FROM tSchm_ObjList AS o \r\n                                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id\r\n                                                    join tSChm_ObjList sub on sub.id = o.idParent\r\n                                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),\r\n                                                    \r\n                                                    cell\t(cellId, cellName, busId, busName, subId, subName) AS\r\n                                                    (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], \r\n                                                    \t\t bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],\r\n                                                    \t\t sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text]\r\n                                                    FROM tSchm_ObjList AS bus\r\n                                                    JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'\r\n                                                    JOIN tSchm_ObjList AS point ON bus.id = point.IdParent\r\n                                                    JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj\r\n                                                    JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id\r\n                                                    JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'\r\n                                                    join tschm_objlist as sub on sub.id = bus.idparent\r\n                                                    JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id \r\n                                                    WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))\r\n                                                    \r\n                                                    select distinct vj_orderEvents.*  from vj_orderEvents\r\n                                                    \tinner join tL_OrderSchmObjList l on l.idOrder = vj_orderEvents.id\r\n                                                    \tleft join cell on cell.cellid = l.idSchmObj\r\n                                                    \tleft join bus on bus.id = l.idSchmObj\r\n                                                    \tleft join sub on sub.id = l.idSchmObj\r\n                                                    where (l.idschmObj in ({0}) or isnull(cell.subId, ISNULL(bus.subid, sub.id)) in ({0}))\r\n                                                    and {1} ", text3, text);
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					try
					{
						sqlConnection.Open();
						using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
						{
							SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
							sqlDataAdapter.SelectCommand = sqlCommand;
							this.class469_0.vJ_OrderEvents.Clear();
							sqlDataAdapter.Fill(this.class469_0.vJ_OrderEvents);
						}
						return;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
						return;
					}
				}
			}
			text = " inner join tL_OrderSchmObjList l on l.idOrder = vj_OrderEvents.id and l.idSchmObj in (" + text3 + ") where " + text;
			base.SelectSqlData(this.class469_0, this.class469_0.vJ_OrderEvents, true, text + " order by num");
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			Form29 form = new Form29();
			form.GoToSchema += this.method_4;
			form.SqlSettings = this.SqlSettings;
			form.FormClosed += this.method_5;
			form.MdiParent = base.MdiParent;
			form.Show();
		}

		private void method_3(object sender, EventArgs e)
		{
			Form29 form = new Form29();
			form.IdDivision = new int?(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
			form.GoToSchema += this.method_4;
			form.SqlSettings = this.SqlSettings;
			form.FormClosed += this.method_5;
			form.MdiParent = base.MdiParent;
			form.Show();
		}

		private void method_4(object sender, GoToSchemaEventArgs e)
		{
			this.OnGoToSchema(e);
		}

		private void method_5(object sender, FormClosedEventArgs e)
		{
			this.method_1();
			this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, ((Form29)sender).method_0().ToString(), false);
			this.method_2();
			this.dataGridViewExcelFilter_1.SearchGrid(this.dataGridViewTextBoxColumn_35.Name, ((Form29)sender).method_0().ToString(), false);
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				if (this.dataGridViewExcelFilter_0.CurrentRow == null)
				{
					return;
				}
				Form29 form = new Form29(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_32.Name].Value), false);
				form.GoToSchema += this.method_4;
				form.SqlSettings = this.SqlSettings;
				form.FormClosed += this.method_5;
				form.MdiParent = base.MdiParent;
				try
				{
					form.Show();
					return;
				}
				catch
				{
					return;
				}
			}
			if (this.dataGridViewExcelFilter_1.CurrentRow != null)
			{
				Form29 form2 = new Form29(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_35.Name].Value), false);
				form2.GoToSchema += this.method_4;
				form2.SqlSettings = this.SqlSettings;
				form2.FormClosed += this.method_5;
				form2.MdiParent = base.MdiParent;
				form2.Show();
			}
		}

		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				if (this.dataGridViewExcelFilter_0.CurrentRow != null)
				{
					Form29 form = new Form29(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_32.Name].Value), true);
					form.GoToSchema += this.method_4;
					form.SqlSettings = this.SqlSettings;
					form.MdiParent = base.MdiParent;
					form.Show();
					return;
				}
			}
			else if (this.dataGridViewExcelFilter_1.CurrentRow != null)
			{
				Form29 form2 = new Form29(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_35.Name].Value), true);
				form2.GoToSchema += this.method_4;
				form2.SqlSettings = this.SqlSettings;
				form2.MdiParent = base.MdiParent;
				form2.Show();
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_0 && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				int num = 0;
				using (IEnumerator enumerator = this.dataGridViewExcelFilter_0.SelectedRows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!Convert.ToBoolean(((DataGridViewRow)enumerator.Current).Cells[this.dataGridViewFilterCheckBoxColumn_0.Name].Value))
						{
							num++;
						}
					}
				}
				if (num == 0)
				{
					MessageBox.Show("В выбранном диапазоне нет незарегистрированных нарядов. Удалять можно только их.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (num == this.dataGridViewExcelFilter_0.SelectedRows.Count)
				{
					if (MessageBox.Show("Удалить выбранные наряды?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						return;
					}
					using (IEnumerator enumerator = this.dataGridViewExcelFilter_0.SelectedRows.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							base.DeleteSqlDataById(this.class469_0.tJ_Order, Convert.ToInt32(dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_32.Name].Value));
							this.dataGridViewExcelFilter_0.Rows.Remove(dataGridViewRow);
						}
						return;
					}
				}
				if (MessageBox.Show("Из выбранных нарядов, незарегистрированных - " + num.ToString() + ". Удалить их?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					foreach (object obj2 in this.dataGridViewExcelFilter_0.SelectedRows)
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						if (!Convert.ToBoolean(dataGridViewRow2.Cells[this.dataGridViewFilterCheckBoxColumn_0.Name].Value))
						{
							base.DeleteSqlDataById(this.class469_0.tJ_Order, Convert.ToInt32(dataGridViewRow2.Cells[this.dataGridViewTextBoxColumn_32.Name].Value));
							this.dataGridViewExcelFilter_0.Rows.Remove(dataGridViewRow2);
						}
					}
				}
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				if (this.dataGridViewExcelFilter_0.CurrentRow != null)
				{
					new Form32(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_32.Name].Value))
					{
						SqlSettings = this.SqlSettings,
						MdiParent = base.MdiParent
					}.Show();
					return;
				}
			}
			else if (this.dataGridViewExcelFilter_1.CurrentRow != null)
			{
				new Form32(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_35.Name].Value))
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			this.toolStripButton_4.Enabled = false;
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				if (this.dataGridViewExcelFilter_0.CurrentRow != null)
				{
					Class121.smethod_0(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_32.Name].Value), this.SqlSettings);
				}
			}
			else if (this.dataGridViewExcelFilter_1.CurrentRow != null)
			{
				Class121.smethod_0(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_35.Name].Value), this.SqlSettings);
			}
			this.toolStripButton_4.Enabled = true;
		}

		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				this.dateTimePicker_1.Value = this.dateTime_0;
				this.dateTimePicker_0.Value = this.dateTime_1;
				this.method_1();
				return;
			}
			this.dateTimePicker_1.Value = this.dateTime_2;
			this.dateTimePicker_0.Value = this.dateTime_3;
			this.method_2();
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			new Form30
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
			this.method_1();
		}

		private void checkBox_3_CheckedChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void method_6(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void method_7(object sender, ItemCheckEventArgs e)
		{
			this.itemCheckEventArgs_0 = e;
			this.method_1();
		}

		private void dateTimePicker_1_ValueChanged(object sender, EventArgs e)
		{
			this.dateTimePicker_0.MinDate = this.dateTimePicker_1.Value;
		}

		private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
		{
			this.dateTimePicker_1.MaxDate = this.dateTimePicker_0.Value;
		}

		private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_0.Name, e.RowIndex].Value))
				{
					e.CellStyle.BackColor = Color.Yellow;
				}
				if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_29.Name, e.RowIndex].Value != DBNull.Value)
				{
					e.CellStyle.BackColor = Color.Gray;
					return;
				}
				if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_30.Name, e.RowIndex].Value != DBNull.Value)
				{
					e.CellStyle.BackColor = Color.LawnGreen;
				}
				if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_31.Name, e.RowIndex].Value != DBNull.Value && this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex] == this.dataGridViewFilterTextBoxColumn_8)
				{
					e.CellStyle.BackColor = Color.Red;
				}
			}
		}

		private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				this.toolStripButton_1_Click(sender, e);
			}
		}

		private void dataGridViewExcelFilter_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && Convert.ToInt32(this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_34.Name, e.RowIndex].Value) == 1)
			{
				e.CellStyle.BackColor = Color.Gray;
			}
		}

		private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				this.toolStripButton_1_Click(sender, e);
			}
		}

		private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTimePicker dateTimePicker = this.dateTimePicker_0;
			DateTimePicker dateTimePicker2 = this.dateTimePicker_1;
			DateTime dateTime = new DateTime(2100, 1, 1);
			dateTimePicker2.MaxDate = dateTime;
			dateTimePicker.MaxDate = dateTime;
			DateTimePicker dateTimePicker3 = this.dateTimePicker_0;
			DateTimePicker dateTimePicker4 = this.dateTimePicker_1;
			dateTime = new DateTime(1900, 1, 1);
			dateTimePicker4.MinDate = dateTime;
			dateTimePicker3.MinDate = dateTime;
			this.treeViewSchmObjects_0.ClearTreeChecked();
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				this.dateTimePicker_0.Value = this.dateTime_1;
				this.dateTimePicker_1.Value = this.dateTime_0;
				using (IEnumerator enumerator = this.treeViewSchmObjects_0.Nodes.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						TreeNode treeNode_ = (TreeNode)obj;
						this.method_8(treeNode_, this.list_1);
					}
					return;
				}
			}
			this.dateTimePicker_0.Value = this.dateTime_3;
			this.dateTimePicker_1.Value = this.dateTime_2;
			foreach (object obj2 in this.treeViewSchmObjects_0.Nodes)
			{
				TreeNode treeNode_2 = (TreeNode)obj2;
				this.method_8(treeNode_2, this.list_2);
			}
		}

		private void toolStripButton_10_Click(object sender, EventArgs e)
		{
			this.treeViewSchmObjects_0.Find(this.toolStripTextBox_0.Text);
		}

		private void toolStripButton_11_Click(object sender, EventArgs e)
		{
			this.treeViewSchmObjects_0.FindPrev(this.toolStripTextBox_0.Text);
		}

		private void toolStripButton_12_Click(object sender, EventArgs e)
		{
			this.treeViewSchmObjects_0.FindNext(this.toolStripTextBox_0.Text);
		}

		private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Keys modifiers = e.Modifiers;
				if (modifiers == Keys.None)
				{
					this.treeViewSchmObjects_0.FindNext(this.toolStripTextBox_0.Text);
					return;
				}
				if (modifiers != Keys.Shift)
				{
					return;
				}
				this.treeViewSchmObjects_0.FindPrev(this.toolStripTextBox_0.Text);
			}
		}

		private void toolStripButton_8_Click(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				this.dateTime_0 = this.dateTimePicker_1.Value;
				this.dateTime_1 = this.dateTimePicker_0.Value;
				this.method_1();
				return;
			}
			this.dateTime_2 = this.dateTimePicker_1.Value;
			this.dateTime_3 = this.dateTimePicker_0.Value;
			this.method_2();
		}

		private void toolStripButton_9_Click(object sender, EventArgs e)
		{
			this.treeViewSchmObjects_0.ClearTreeChecked();
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				this.list_1 = new List<int>();
				this.method_1();
				return;
			}
			this.list_2 = new List<int>();
			this.method_2();
		}

		private void method_8(TreeNode treeNode_0, List<int> list_4)
		{
			if (treeNode_0.Level > 0 && list_4.Contains(Convert.ToInt32(treeNode_0.Tag)))
			{
				treeNode_0.Checked = true;
			}
			foreach (object obj in treeNode_0.Nodes)
			{
				TreeNode treeNode_ = (TreeNode)obj;
				this.method_8(treeNode_, list_4);
			}
		}

		protected override XmlDocument CreateXmlConfig()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
			xmlDocument.AppendChild(newChild);
			XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
			xmlDocument.AppendChild(xmlNode);
			foreach (object obj in this.checkedListBox_0.CheckedItems)
			{
				XmlNode xmlNode2 = xmlDocument.CreateElement("CheckDivision");
				XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("Id");
				xmlAttribute.Value = ((FormJournalOrder.Class120)obj).Id.ToString();
				xmlNode2.Attributes.Append(xmlAttribute);
				xmlNode.AppendChild(xmlNode2);
			}
			return xmlDocument;
		}

		protected override void ApplyConfig(XmlDocument doc)
		{
			this.list_3 = new List<int>();
			XmlNode xmlNode = doc.SelectSingleNode(base.Name);
			if (xmlNode == null)
			{
				return;
			}
			foreach (object obj in xmlNode.SelectNodes("CheckDivision"))
			{
				XmlAttribute xmlAttribute = ((XmlNode)obj).Attributes["Id"];
				if (xmlAttribute != null)
				{
					this.list_3.Add(Convert.ToInt32(xmlAttribute.Value));
				}
			}
		}

		private void method_9()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormJournalOrder));
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterDateTimePickerColumn_0 = new DataGridViewFilterDateTimePickerColumn();
			this.dataGridViewFilterDateTimePickerColumn_1 = new DataGridViewFilterDateTimePickerColumn();
			this.dataGridViewFilterDateTimePickerColumn_2 = new DataGridViewFilterDateTimePickerColumn();
			this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
			this.aoQotnQcsvT = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.class469_0 = new Class469();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripButton_7 = new ToolStripButton();
			this.panel_0 = new Panel();
			this.checkBox_0 = new CheckBox();
			this.checkBox_1 = new CheckBox();
			this.checkBox_2 = new CheckBox();
			this.checkBox_3 = new CheckBox();
			this.wshoYigBwWu = new Panel();
			this.panel_1 = new Panel();
			this.splitContainer_1 = new SplitContainer();
			this.checkBox_4 = new CheckBox();
			this.treeViewSchmObjects_0 = new TreeViewSchmObjects();
			this.checkedListBox_0 = new CheckedListBox();
			this.label_2 = new Label();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_8 = new ToolStripButton();
			this.toolStripButton_9 = new ToolStripButton();
			this.toolStripButton_10 = new ToolStripButton();
			this.toolStripTextBox_0 = new ToolStripTextBox();
			this.toolStripButton_11 = new ToolStripButton();
			this.toolStripButton_12 = new ToolStripButton();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_0 = new Label();
			this.dateTimePicker_1 = new DateTimePicker();
			this.label_1 = new Label();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.tabPage_1 = new TabPage();
			this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
			this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.splitContainer_0 = new SplitContainer();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.njcoIhaKsGb = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.DxQoIgYxNuE = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.class469_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			this.wshoYigBwWu.SuspendLayout();
			this.panel_1.SuspendLayout();
			this.splitContainer_1.Panel1.SuspendLayout();
			this.splitContainer_1.Panel2.SuspendLayout();
			this.splitContainer_1.SuspendLayout();
			this.toolStrip_1.SuspendLayout();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_1).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			base.SuspendLayout();
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
				this.dataGridViewFilterTextBoxColumn_8,
				this.dataGridViewFilterTextBoxColumn_9,
				this.dataGridViewFilterDateTimePickerColumn_0,
				this.dataGridViewFilterDateTimePickerColumn_1,
				this.dataGridViewFilterDateTimePickerColumn_2,
				this.dataGridViewFilterCheckBoxColumn_0,
				this.dataGridViewTextBoxColumn_25,
				this.dataGridViewFilterTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_26,
				this.dataGridViewFilterTextBoxColumn_11,
				this.dataGridViewFilterTextBoxColumn_12,
				this.dataGridViewFilterTextBoxColumn_13,
				this.aoQotnQcsvT,
				this.dataGridViewTextBoxColumn_27,
				this.dataGridViewTextBoxColumn_28,
				this.dataGridViewFilterTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_29,
				this.dataGridViewFilterTextBoxColumn_15,
				this.dataGridViewTextBoxColumn_30,
				this.dataGridViewTextBoxColumn_31,
				this.dataGridViewTextBoxColumn_32
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(3, 47);
			this.dataGridViewExcelFilter_0.Name = "dgvOrder";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_0.RowTemplate.Height = 44;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(718, 487);
			this.dataGridViewExcelFilter_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
			this.dataGridViewExcelFilter_0.CellFormatting += this.dataGridViewExcelFilter_0_CellFormatting;
			this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "num";
			this.dataGridViewFilterTextBoxColumn_8.HeaderText = "№";
			this.dataGridViewFilterTextBoxColumn_8.Name = "numDgvColumn";
			this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_8.Width = 50;
			this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "srNum";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewFilterTextBoxColumn_9.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Сетевой район";
			this.dataGridViewFilterTextBoxColumn_9.Name = "srNumDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_9.Width = 80;
			this.dataGridViewFilterDateTimePickerColumn_0.DataPropertyName = "dateOutput";
			dataGridViewCellStyle3.Format = "dd.MM.yyyy HH:mm:ss";
			this.dataGridViewFilterDateTimePickerColumn_0.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewFilterDateTimePickerColumn_0.HeaderText = "Дата выдачи наряда";
			this.dataGridViewFilterDateTimePickerColumn_0.Name = "dateOutputDataGridViewTextBoxColumn";
			this.dataGridViewFilterDateTimePickerColumn_0.ReadOnly = true;
			this.dataGridViewFilterDateTimePickerColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewFilterDateTimePickerColumn_0.Width = 125;
			this.dataGridViewFilterDateTimePickerColumn_1.DataPropertyName = "dateBegin";
			this.dataGridViewFilterDateTimePickerColumn_1.HeaderText = "Дата начала работ";
			this.dataGridViewFilterDateTimePickerColumn_1.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dataGridViewFilterDateTimePickerColumn_1.ReadOnly = true;
			this.dataGridViewFilterDateTimePickerColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterDateTimePickerColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewFilterDateTimePickerColumn_1.Width = 80;
			this.dataGridViewFilterDateTimePickerColumn_2.DataPropertyName = "dateEnd";
			this.dataGridViewFilterDateTimePickerColumn_2.HeaderText = "Дата окончания работ";
			this.dataGridViewFilterDateTimePickerColumn_2.Name = "dateEndDataGridViewTextBoxColumn";
			this.dataGridViewFilterDateTimePickerColumn_2.ReadOnly = true;
			this.dataGridViewFilterDateTimePickerColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterDateTimePickerColumn_2.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewFilterDateTimePickerColumn_2.Width = 80;
			this.dataGridViewFilterCheckBoxColumn_0.DataPropertyName = "registered";
			this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "Зарегистрирован";
			this.dataGridViewFilterCheckBoxColumn_0.Name = "registeredDgvColumn";
			this.dataGridViewFilterCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewFilterCheckBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_25.DataPropertyName = "OutputMaker";
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_25.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn_25.HeaderText = "Наряд выдал Производитель работ";
			this.dataGridViewTextBoxColumn_25.Name = "outputMakerDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "instruction";
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_10.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Содержание работ";
			this.dataGridViewFilterTextBoxColumn_10.Name = "instructionDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_26.DataPropertyName = "Resolution";
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_26.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn_26.HeaderText = "Разрешение выдал";
			this.dataGridViewTextBoxColumn_26.Name = "resolutionDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewTextBoxColumn_26.Width = 120;
			this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "srName";
			this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Сетевой район (имя)";
			this.dataGridViewFilterTextBoxColumn_11.Name = "srNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_11.Visible = false;
			this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "headFio";
			this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Руководитель работ";
			this.dataGridViewFilterTextBoxColumn_12.Name = "headFioDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_12.Visible = false;
			this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "acceptFIO";
			this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Допускайщий";
			this.dataGridViewFilterTextBoxColumn_13.Name = "acceptFIODataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_13.Visible = false;
			this.aoQotnQcsvT.DataPropertyName = "watchFIO";
			this.aoQotnQcsvT.HeaderText = "Наблюдающий";
			this.aoQotnQcsvT.Name = "watchFIODataGridViewTextBoxColumn";
			this.aoQotnQcsvT.ReadOnly = true;
			this.aoQotnQcsvT.Resizable = DataGridViewTriState.True;
			this.aoQotnQcsvT.Visible = false;
			this.dataGridViewTextBoxColumn_27.DataPropertyName = "makerFIO";
			this.dataGridViewTextBoxColumn_27.HeaderText = "Произовдитель работ";
			this.dataGridViewTextBoxColumn_27.Name = "makerFIODataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.Visible = false;
			this.dataGridViewTextBoxColumn_28.DataPropertyName = "otherInstruction";
			this.dataGridViewTextBoxColumn_28.HeaderText = "Отдельные указания";
			this.dataGridViewTextBoxColumn_28.Name = "otherInstructionDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewTextBoxColumn_28.Visible = false;
			this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "outputFIO";
			this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Наряд выдал";
			this.dataGridViewFilterTextBoxColumn_14.Name = "outputFIODataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_29.DataPropertyName = "dateClose";
			this.dataGridViewTextBoxColumn_29.HeaderText = "Дата закрытия";
			this.dataGridViewTextBoxColumn_29.Name = "dateCloseDgvColumn";
			this.dataGridViewTextBoxColumn_29.ReadOnly = true;
			this.dataGridViewTextBoxColumn_29.Visible = false;
			this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "closeFIO";
			this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Закрыл наряд";
			this.dataGridViewFilterTextBoxColumn_15.Name = "closeFIODataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_30.DataPropertyName = "beginRes";
			this.dataGridViewTextBoxColumn_30.HeaderText = "beginRes";
			this.dataGridViewTextBoxColumn_30.Name = "beginResDgvColumn";
			this.dataGridViewTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.Visible = false;
			this.dataGridViewTextBoxColumn_31.DataPropertyName = "EndRes";
			this.dataGridViewTextBoxColumn_31.HeaderText = "EndRes";
			this.dataGridViewTextBoxColumn_31.Name = "EndResDgvColumn";
			this.dataGridViewTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewTextBoxColumn_31.Visible = false;
			this.dataGridViewTextBoxColumn_32.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_32.HeaderText = "id";
			this.dataGridViewTextBoxColumn_32.Name = "idDgvColumn";
			this.dataGridViewTextBoxColumn_32.ReadOnly = true;
			this.dataGridViewTextBoxColumn_32.Visible = false;
			this.bindingSource_0.DataMember = "vJ_Order";
			this.bindingSource_0.DataSource = this.class469_0;
			this.class469_0.DataSetName = "DataSetOrder";
			this.class469_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripDropDownButton_0,
				this.toolStripButton_1,
				this.toolStripButton_5,
				this.toolStripButton_2,
				this.toolStripSeparator_1,
				this.toolStripButton_6,
				this.toolStripSeparator_0,
				this.toolStripButton_3,
				this.toolStripButton_4,
				this.toolStripSeparator_2,
				this.toolStripButton_7
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStripOrder";
			this.toolStrip_0.Size = new Size(918, 25);
			this.toolStrip_0.TabIndex = 2;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.ElementAdd;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolBtnAddOrder";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Создать наряд";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton_0.Image = Resources.ElementAdd;
			this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripDropDownButton_0.Name = "toolBtnAddOrderDivision";
			this.toolStripDropDownButton_0.Size = new Size(29, 22);
			this.toolStripDropDownButton_0.Text = "Создать наряд";
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.ElementEdit;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolBtnEditOrder";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Редактировать";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.ElementInformation1;
			this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_5.Name = "toolBtnReadOrder";
			this.toolStripButton_5.Size = new Size(23, 22);
			this.toolStripButton_5.Text = "Просмотр наряда";
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.ElementDel;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolBtnDelOrder";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Удалить наряд(ы)";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripSeparator_1.Name = "toolStripSeparator2";
			this.toolStripSeparator_1.Size = new Size(6, 25);
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = Resources.refresh_16;
			this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_6.Name = "toolBtnRefresh";
			this.toolStripButton_6.Size = new Size(23, 22);
			this.toolStripButton_6.Text = "Обновить";
			this.toolStripButton_6.Click += this.toolStripButton_6_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = (Image)componentResourceManager.GetObject("toolBtnReport.Image");
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "toolBtnReport";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "toolStripButton1";
			this.toolStripButton_3.Visible = false;
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = Resources.microsoftoffice2007excel_7581;
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "toolBtnReportExcel";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Печать наряда";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripSeparator_2.Name = "toolStripSeparator3";
			this.toolStripSeparator_2.Size = new Size(6, 25);
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = Resources.Orderclose;
			this.toolStripButton_7.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_7.Name = "toolBtnOrderClose";
			this.toolStripButton_7.Size = new Size(23, 22);
			this.toolStripButton_7.Text = "Закрыть наряды";
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.panel_0.Controls.Add(this.checkBox_0);
			this.panel_0.Controls.Add(this.checkBox_1);
			this.panel_0.Controls.Add(this.checkBox_2);
			this.panel_0.Controls.Add(this.checkBox_3);
			this.panel_0.Dock = DockStyle.Top;
			this.panel_0.Location = new Point(3, 3);
			this.panel_0.Name = "panelFilter";
			this.panel_0.Size = new Size(718, 44);
			this.panel_0.TabIndex = 3;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.BackColor = Color.Gray;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(411, 9);
			this.checkBox_0.Name = "checkBoxCloseOrder";
			this.checkBox_0.Size = new Size(78, 17);
			this.checkBox_0.TabIndex = 3;
			this.checkBox_0.Text = "Закрытые";
			this.checkBox_0.UseVisualStyleBackColor = false;
			this.checkBox_0.CheckedChanged += this.checkBox_3_CheckedChanged;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.BackColor = Color.LawnGreen;
			this.checkBox_1.Checked = true;
			this.checkBox_1.CheckState = CheckState.Checked;
			this.checkBox_1.Location = new Point(307, 9);
			this.checkBox_1.Name = "checkBoxCurrentOrder";
			this.checkBox_1.Size = new Size(98, 17);
			this.checkBox_1.TabIndex = 2;
			this.checkBox_1.Text = "Действующие";
			this.checkBox_1.UseVisualStyleBackColor = false;
			this.checkBox_1.CheckedChanged += this.checkBox_3_CheckedChanged;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.BackColor = Color.White;
			this.checkBox_2.Checked = true;
			this.checkBox_2.CheckState = CheckState.Checked;
			this.checkBox_2.Location = new Point(166, 9);
			this.checkBox_2.Name = "checkBoxRegistered";
			this.checkBox_2.Size = new Size(135, 17);
			this.checkBox_2.TabIndex = 1;
			this.checkBox_2.Text = "Зарегистрированные";
			this.checkBox_2.UseVisualStyleBackColor = false;
			this.checkBox_2.CheckedChanged += this.checkBox_3_CheckedChanged;
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.BackColor = Color.Yellow;
			this.checkBox_3.Checked = true;
			this.checkBox_3.CheckState = CheckState.Checked;
			this.checkBox_3.Location = new Point(12, 9);
			this.checkBox_3.Name = "checkBoxNoRegistered";
			this.checkBox_3.Size = new Size(148, 17);
			this.checkBox_3.TabIndex = 0;
			this.checkBox_3.Text = "Незарегистрированные";
			this.checkBox_3.UseVisualStyleBackColor = false;
			this.checkBox_3.CheckedChanged += this.checkBox_3_CheckedChanged;
			this.wshoYigBwWu.Controls.Add(this.panel_1);
			this.wshoYigBwWu.Controls.Add(this.toolStrip_1);
			this.wshoYigBwWu.Controls.Add(this.dateTimePicker_0);
			this.wshoYigBwWu.Controls.Add(this.label_0);
			this.wshoYigBwWu.Controls.Add(this.dateTimePicker_1);
			this.wshoYigBwWu.Controls.Add(this.label_1);
			this.wshoYigBwWu.Dock = DockStyle.Fill;
			this.wshoYigBwWu.Location = new Point(0, 0);
			this.wshoYigBwWu.Name = "panelDateFilter";
			this.wshoYigBwWu.Size = new Size(182, 563);
			this.wshoYigBwWu.TabIndex = 4;
			this.panel_1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_1.Controls.Add(this.splitContainer_1);
			this.panel_1.Location = new Point(0, 106);
			this.panel_1.Name = "panelTree";
			this.panel_1.Size = new Size(182, 457);
			this.panel_1.TabIndex = 10;
			this.splitContainer_1.Dock = DockStyle.Fill;
			this.splitContainer_1.FixedPanel = FixedPanel.Panel2;
			this.splitContainer_1.Location = new Point(0, 0);
			this.splitContainer_1.Name = "splitContainerFilter";
			this.splitContainer_1.Orientation = Orientation.Horizontal;
			this.splitContainer_1.Panel1.Controls.Add(this.checkBox_4);
			this.splitContainer_1.Panel1.Controls.Add(this.treeViewSchmObjects_0);
			this.splitContainer_1.Panel2.Controls.Add(this.checkedListBox_0);
			this.splitContainer_1.Panel2.Controls.Add(this.label_2);
			this.splitContainer_1.Size = new Size(182, 457);
			this.splitContainer_1.SplitterDistance = 352;
			this.splitContainer_1.TabIndex = 10;
			this.checkBox_4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.checkBox_4.AutoSize = true;
			this.checkBox_4.Checked = true;
			this.checkBox_4.CheckState = CheckState.Checked;
			this.checkBox_4.Location = new Point(6, 333);
			this.checkBox_4.Name = "checkBoxWhereSub";
			this.checkBox_4.Size = new Size(180, 17);
			this.checkBox_4.TabIndex = 13;
			this.checkBox_4.Text = "Фильтровать по подстанциям";
			this.checkBox_4.UseVisualStyleBackColor = true;
			this.treeViewSchmObjects_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.treeViewSchmObjects_0.CheckBoxes = true;
			this.treeViewSchmObjects_0.Location = new Point(0, 0);
			this.treeViewSchmObjects_0.Name = "treeViewSchmObjects";
			this.treeViewSchmObjects_0.Size = new Size(182, 327);
			this.treeViewSchmObjects_0.SqlSettings = null;
			this.treeViewSchmObjects_0.TabIndex = 9;
			this.checkedListBox_0.Dock = DockStyle.Fill;
			this.checkedListBox_0.FormattingEnabled = true;
			this.checkedListBox_0.Location = new Point(0, 13);
			this.checkedListBox_0.Name = "checkedListBoxDivision";
			this.checkedListBox_0.Size = new Size(182, 88);
			this.checkedListBox_0.TabIndex = 1;
			this.label_2.AutoSize = true;
			this.label_2.Dock = DockStyle.Top;
			this.label_2.Location = new Point(0, 0);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(87, 13);
			this.label_2.TabIndex = 0;
			this.label_2.Text = "Подразделения";
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_8,
				this.toolStripButton_9,
				this.toolStripButton_10,
				this.toolStripTextBox_0,
				this.toolStripButton_11,
				this.toolStripButton_12
			});
			this.toolStrip_1.Location = new Point(0, 0);
			this.toolStrip_1.Name = "toolStripFilter";
			this.toolStrip_1.Size = new Size(182, 25);
			this.toolStrip_1.TabIndex = 10;
			this.toolStrip_1.Text = "toolStrip1";
			this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_8.Image = Resources.filter;
			this.toolStripButton_8.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_8.Name = "toolBtnFilter";
			this.toolStripButton_8.Size = new Size(23, 22);
			this.toolStripButton_8.Text = "Применить фильтр";
			this.toolStripButton_8.Click += this.toolStripButton_8_Click;
			this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_9.Image = Resources.filter_delete;
			this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_9.Name = "toolBtnFilterClear";
			this.toolStripButton_9.Size = new Size(23, 22);
			this.toolStripButton_9.Text = "Отменить фильтр";
			this.toolStripButton_9.Click += this.toolStripButton_9_Click;
			this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_10.Image = Resources.Find;
			this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_10.Name = "toolBtnFind";
			this.toolStripButton_10.Size = new Size(23, 22);
			this.toolStripButton_10.Text = "Поиск";
			this.toolStripButton_10.Click += this.toolStripButton_10_Click;
			this.toolStripTextBox_0.Name = "toolTextBoxFind";
			this.toolStripTextBox_0.Size = new Size(54, 25);
			this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
			this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_11.Image = Resources.FindPrev;
			this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_11.Name = "toolBtnFindPrev";
			this.toolStripButton_11.Size = new Size(23, 22);
			this.toolStripButton_11.Text = "Поиск назад";
			this.toolStripButton_11.Click += this.toolStripButton_11_Click;
			this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_12.Image = Resources.FindNext;
			this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_12.Name = "toolBtnFindNext";
			this.toolStripButton_12.Size = new Size(23, 22);
			this.toolStripButton_12.Text = "Поиск вперед";
			this.toolStripButton_12.Click += this.toolStripButton_12_Click;
			this.dateTimePicker_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.dateTimePicker_0.Location = new Point(6, 80);
			this.dateTimePicker_0.Name = "dateTimePickerEnd";
			this.dateTimePicker_0.Size = new Size(168, 20);
			this.dateTimePicker_0.TabIndex = 7;
			this.dateTimePicker_0.ValueChanged += this.dateTimePicker_0_ValueChanged;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(3, 64);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(38, 13);
			this.label_0.TabIndex = 6;
			this.label_0.Text = "Конец";
			this.dateTimePicker_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.dateTimePicker_1.Location = new Point(6, 41);
			this.dateTimePicker_1.Name = "dateTimePickerBegin";
			this.dateTimePicker_1.Size = new Size(168, 20);
			this.dateTimePicker_1.TabIndex = 5;
			this.dateTimePicker_1.ValueChanged += this.dateTimePicker_1_ValueChanged;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(3, 25);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(44, 13);
			this.label_1.TabIndex = 4;
			this.label_1.Text = "Начало";
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tabControlOrder";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(732, 563);
			this.tabControl_0.TabIndex = 5;
			this.tabControl_0.SelectedIndexChanged += this.tabControl_0_SelectedIndexChanged;
			this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_0);
			this.tabPage_0.Controls.Add(this.panel_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPageView";
			this.tabPage_0.Padding = new Padding(3, 3, 3, 3);
			this.tabPage_0.Size = new Size(724, 537);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Просмотр";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_1);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tabPageEvents";
			this.tabPage_1.Padding = new Padding(3, 3, 3, 3);
			this.tabPage_1.Size = new Size(770, 542);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "События";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_16,
				this.dataGridViewFilterTextBoxColumn_17,
				this.dataGridViewFilterTextBoxColumn_18,
				this.dataGridViewFilterTextBoxColumn_19,
				this.dataGridViewFilterTextBoxColumn_20,
				this.dataGridViewFilterTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_33,
				this.dataGridViewFilterTextBoxColumn_22,
				this.dataGridViewTextBoxColumn_34,
				this.dataGridViewTextBoxColumn_35
			});
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_1.Location = new Point(3, 3);
			this.dataGridViewExcelFilter_1.Name = "dgvEvents";
			this.dataGridViewExcelFilter_1.ReadOnly = true;
			this.dataGridViewExcelFilter_1.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_1.RowTemplate.Height = 44;
			this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_1.Size = new Size(764, 536);
			this.dataGridViewExcelFilter_1.TabIndex = 0;
			this.dataGridViewExcelFilter_1.CellDoubleClick += this.dataGridViewExcelFilter_1_CellDoubleClick;
			this.dataGridViewExcelFilter_1.CellFormatting += this.dataGridViewExcelFilter_1_CellFormatting;
			this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "num";
			this.dataGridViewFilterTextBoxColumn_16.HeaderText = "№ наряда";
			this.dataGridViewFilterTextBoxColumn_16.Name = "numDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_16.Width = 60;
			this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "srNum";
			this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Сетевой район";
			this.dataGridViewFilterTextBoxColumn_17.Name = "srNumDgvColumn";
			this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_17.Width = 50;
			this.dataGridViewFilterTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "instruction";
			this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Содержание работ";
			this.dataGridViewFilterTextBoxColumn_18.Name = "instructionDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "acceptFIO";
			this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Допускающий";
			this.dataGridViewFilterTextBoxColumn_19.Name = "acceptFIODataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_19.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "makerFio";
			this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Производитель";
			this.dataGridViewFilterTextBoxColumn_20.Name = "makerFioDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_20.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "Evnt";
			this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Состояние работ";
			this.dataGridViewFilterTextBoxColumn_21.Name = "evntDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_21.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_33.DataPropertyName = "EvntDate";
			this.dataGridViewTextBoxColumn_33.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_33.Name = "evntDateDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "disp";
			this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Диспетчер";
			this.dataGridViewFilterTextBoxColumn_22.Name = "dispDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_22.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_34.DataPropertyName = "closed";
			this.dataGridViewTextBoxColumn_34.HeaderText = "closed";
			this.dataGridViewTextBoxColumn_34.Name = "closedDgvColumn";
			this.dataGridViewTextBoxColumn_34.ReadOnly = true;
			this.dataGridViewTextBoxColumn_34.Visible = false;
			this.dataGridViewTextBoxColumn_35.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_35.HeaderText = "id";
			this.dataGridViewTextBoxColumn_35.Name = "idDgvColumnEvent";
			this.dataGridViewTextBoxColumn_35.ReadOnly = true;
			this.dataGridViewTextBoxColumn_35.Visible = false;
			this.bindingSource_1.DataMember = "vJ_OrderEvents";
			this.bindingSource_1.DataSource = this.class469_0;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
			this.splitContainer_0.Location = new Point(0, 25);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Panel1.Controls.Add(this.wshoYigBwWu);
			this.splitContainer_0.Panel2.Controls.Add(this.tabControl_0);
			this.splitContainer_0.Size = new Size(918, 563);
			this.splitContainer_0.SplitterDistance = 182;
			this.splitContainer_0.TabIndex = 6;
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "num";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№";
			this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_0.Width = 50;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "OutputMaker";
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_0.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewTextBoxColumn_0.HeaderText = "Наряд выдал Производитель работ";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Resizable = DataGridViewTriState.False;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "srNum";
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewFilterTextBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Сетевой район";
			this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.False;
			this.dataGridViewFilterTextBoxColumn_1.Width = 80;
			this.dataGridViewFilterTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "instruction";
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_2.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Содержание работ";
			this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
			this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Resolution";
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewTextBoxColumn_1.HeaderText = "Разрешение выдал";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Width = 120;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "idSR";
			this.dataGridViewTextBoxColumn_2.HeaderText = "idSR";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "srName";
			this.dataGridViewTextBoxColumn_3.HeaderText = "srName";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "headworker";
			this.dataGridViewTextBoxColumn_4.HeaderText = "headworker";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "headFio";
			this.dataGridViewTextBoxColumn_5.HeaderText = "headFio";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "acceptworker";
			this.dataGridViewTextBoxColumn_6.HeaderText = "acceptworker";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "acceptFIO";
			this.dataGridViewTextBoxColumn_7.HeaderText = "acceptFIO";
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_8.HeaderText = "id";
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.njcoIhaKsGb.DataPropertyName = "watchWorker";
			this.njcoIhaKsGb.HeaderText = "watchWorker";
			this.njcoIhaKsGb.Name = "dataGridViewTextBoxColumn10";
			this.njcoIhaKsGb.ReadOnly = true;
			this.njcoIhaKsGb.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "watchFIO";
			this.dataGridViewTextBoxColumn_9.HeaderText = "watchFIO";
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "makerWorker";
			this.dataGridViewTextBoxColumn_10.HeaderText = "makerWorker";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "makerFIO";
			this.dataGridViewTextBoxColumn_11.HeaderText = "makerFIO";
			this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "otherInstruction";
			this.dataGridViewTextBoxColumn_12.HeaderText = "otherInstruction";
			this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "outputWorker";
			this.dataGridViewTextBoxColumn_13.HeaderText = "outputWorker";
			this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "outputFIO";
			this.dataGridViewTextBoxColumn_14.HeaderText = "outputFIO";
			this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "dateClose";
			this.dataGridViewTextBoxColumn_15.HeaderText = "dateClose";
			this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "closeWorker";
			this.dataGridViewTextBoxColumn_16.HeaderText = "closeWorker";
			this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Visible = false;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "closeFIO";
			this.dataGridViewTextBoxColumn_17.HeaderText = "closeFIO";
			this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.Visible = false;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "beginRes";
			this.dataGridViewTextBoxColumn_18.HeaderText = "beginRes";
			this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.Visible = false;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "EndRes";
			this.dataGridViewTextBoxColumn_19.HeaderText = "EndRes";
			this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.Visible = false;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "resWorkerId";
			this.dataGridViewTextBoxColumn_20.HeaderText = "resWorkerId";
			this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.Visible = false;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "resWorker";
			this.dataGridViewTextBoxColumn_21.HeaderText = "resWorker";
			this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn23";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.Visible = false;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_22.HeaderText = "id";
			this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.Visible = false;
			this.DxQoIgYxNuE.DataPropertyName = "num";
			this.DxQoIgYxNuE.HeaderText = "№ наряда";
			this.DxQoIgYxNuE.Name = "dataGridViewFilterTextBoxColumn4";
			this.DxQoIgYxNuE.ReadOnly = true;
			this.DxQoIgYxNuE.Resizable = DataGridViewTriState.True;
			this.DxQoIgYxNuE.Width = 60;
			this.dataGridViewFilterTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "instruction";
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Содержание работ";
			this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn5";
			this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "acceptFIO";
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Допускающий";
			this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn6";
			this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "makerFio";
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Производитель";
			this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn7";
			this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "Evnt";
			this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Состояние работ";
			this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn8";
			this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "EvntDate";
			this.dataGridViewTextBoxColumn_23.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.DataPropertyName = "closed";
			this.dataGridViewTextBoxColumn_24.HeaderText = "closed";
			this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn26";
			this.dataGridViewTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.Visible = false;
			this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "disp";
			this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Диспетчер";
			this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn9";
			this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(918, 588);
			base.Controls.Add(this.splitContainer_0);
			base.Controls.Add(this.toolStrip_0);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormJournalOrder";
			this.Text = "Журнал нарядов";
			base.FormClosed += this.FormJournalOrder_FormClosed;
			base.Load += this.FormJournalOrder_Load;
			((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.class469_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			this.wshoYigBwWu.ResumeLayout(false);
			this.wshoYigBwWu.PerformLayout();
			this.panel_1.ResumeLayout(false);
			this.splitContainer_1.Panel1.ResumeLayout(false);
			this.splitContainer_1.Panel1.PerformLayout();
			this.splitContainer_1.Panel2.ResumeLayout(false);
			this.splitContainer_1.Panel2.PerformLayout();
			this.splitContainer_1.ResumeLayout(false);
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_1.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewExcelFilter_1).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private DateTime dateTime_0;

		private DateTime dateTime_1;

		private DateTime dateTime_2;

		private DateTime dateTime_3;

		private List<int> list_0;

		private ItemCheckEventArgs itemCheckEventArgs_0;

		private List<int> list_1;

		private List<int> list_2;

		private List<int> list_3;

		private Class469 class469_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private BindingSource bindingSource_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private ToolStripButton toolStripButton_3;

		private ToolStripButton toolStripButton_4;

		private ToolStripSeparator toolStripSeparator_0;

		private Panel panel_0;

		private CheckBox checkBox_0;

		private CheckBox checkBox_1;

		private CheckBox checkBox_2;

		private CheckBox checkBox_3;

		private Panel wshoYigBwWu;

		private ToolStripButton toolStripButton_5;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripButton toolStripButton_6;

		private ToolStripSeparator toolStripSeparator_2;

		private ToolStripButton toolStripButton_7;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private TabPage tabPage_1;

		private BindingSource bindingSource_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_1;

		private DateTimePicker dateTimePicker_0;

		private Label label_0;

		private DateTimePicker dateTimePicker_1;

		private Label label_1;

		private TreeViewSchmObjects treeViewSchmObjects_0;

		private SplitContainer splitContainer_0;

		private Panel panel_1;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_8;

		private ToolStripButton toolStripButton_9;

		private ToolStripButton toolStripButton_10;

		private ToolStripTextBox toolStripTextBox_0;

		private ToolStripButton toolStripButton_11;

		private ToolStripButton toolStripButton_12;

		private ToolStripDropDownButton toolStripDropDownButton_0;

		private SplitContainer splitContainer_1;

		private CheckedListBox checkedListBox_0;

		private Label label_2;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn njcoIhaKsGb;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private DataGridViewFilterTextBoxColumn DxQoIgYxNuE;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;

		private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_0;

		private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_1;

		private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_2;

		private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;

		private DataGridViewFilterTextBoxColumn aoQotnQcsvT;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_20;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_22;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

		private CheckBox checkBox_4;

		private class Class120
		{
			internal int Id { get; set; }

			internal string Name { get; set; }

			internal Class120(int int_1, string string_1)
			{
				Class611.H9nE6ZDzTF9kb();
				
				this.Id = int_1;
				this.Name = string_1;
			}

			public override string ToString()
			{
				return this.Name;
			}

			[CompilerGenerated]
			private int int_0;

			[CompilerGenerated]
			private string string_0;
		}
	}
}
