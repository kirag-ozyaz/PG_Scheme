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
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;

namespace JournalOrder
{
	public partial class FormJournalOrder : FormBase
	{
        private ItemCheckEventArgs itemCheckEventArgs;
        private List<int> listSchmObject;
        private List<int> listSchmObjectEvents;
        private List<int> listDivisionOrder;

        public FormJournalOrder()
		{
			
			this.DateBegin = new DateTime(DateTime.Now.Year, 1, 1);
			this.DateEnd = new DateTime(DateTime.Now.Year, 12, 31);
			this.DateBeginEventDate = DateTime.Now.Date;
			this.DateEndEventDate = DateTime.Now.Date;
			this.listSchmObject = new List<int>();
			this.listSchmObjectEvents = new List<int>();
			this.listDivisionOrder = new List<int>();
			
			this.InitializeComponent();
		}

		public FormJournalOrder(List<int> checkedSubstation)
		{
			
			this.DateBegin = new DateTime(DateTime.Now.Year, 1, 1);
			this.DateEnd = new DateTime(DateTime.Now.Year, 12, 31);
			this.DateBeginEventDate = DateTime.Now.Date;
			this.DateEndEventDate = DateTime.Now.Date;
			this.listSchmObject = new List<int>();
			this.listSchmObjectEvents = new List<int>();
			this.listDivisionOrder = new List<int>();
			
			this.InitializeComponent();
			this.listSubStation = checkedSubstation;
		}

		private void FormJournalOrder_Load(object sender, EventArgs e)
		{
			base.LoadFormConfig(null);
			this.dateTimePickerBegin.Value = new DateTime(DateTime.Now.Year, 1, 1);
			this.dateTimePickerEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);
			this.Load_Division();
			this.treeViewSchmObjects.SqlSettings = this.SqlSettings;
			this.treeViewSchmObjects.Load(this.listSubStation);
			this.Load_Order();
			this.Load_OrderEvents();
		}

		private void FormJournalOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			base.SaveFormConfig(null);
		}

		private void Load_Division()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			base.SelectSqlData(dataTable, true, " where ((ParentKey = ';Other;DivisionOrder;' and isGRoup = 0)\r\n     " +
                "  or (ParentKey like ';Other;DivisionOrder;%;' and isGRoup = 1)) and deleted = 0 ", null, false, 0);
			if (dataTable.Rows.Count == 0)
			{
				this.toolBtnAddOrderDivision.Visible = false;
				this.splitContainerFilter.Panel2Collapsed = true;
				return;
			}
			this.toolBtnAddOrder.Visible = false;
			foreach (DataRow dataRow in dataTable.Rows)
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				toolStripMenuItem.Click += new EventHandler( this.toolStripMenuItem_Click);
				toolStripMenuItem.Text = dataRow["Name"].ToString();
				toolStripMenuItem.Tag = dataRow["id"];
				this.toolBtnAddOrderDivision.DropDownItems.Add(toolStripMenuItem);
				bool isChecked = false;
				if (this.listDivisionOrder != null && this.listDivisionOrder.Count != 0)
				{
					if (this.listDivisionOrder.Contains(Convert.ToInt32(dataRow["id"])))
					{
						isChecked = true;
					}
				}
				else
				{
					isChecked = true;
				}
				this.checkedListBoxDivision.Items.Add(new FormJournalOrder.StructObject(Convert.ToInt32(dataRow["id"]), dataRow["Name"].ToString()), isChecked);
			}
		}

		private void Load_Order()
		{
			this.Cursor = Cursors.WaitCursor;
			Control control = this.panelDateFilter;
			this.panelFilter.Enabled = false;
			control.Enabled = false;
			string whereDateDiaposon = "";
			int idDokument = -1;
			if (this.dgvOrder.CurrentRow != null)
			{
				idDokument = Convert.ToInt32(this.dgvOrder.CurrentRow.Cells[this.idDgvColumn.Name].Value);
			}
			whereDateDiaposon = string.Concat(new string[]
			{
				" (datebegin >= '",
				this.DateBegin.ToString("yyyyMMdd"),
				"' and datebegin <= '",
				this.DateEnd.ToString("yyyyMMdd"),
				" 23:59:59') "
			});
			string strWhere = "";
			if (!this.checkBoxNoRegistered.Checked && !this.checkBoxRegistered.Checked && !this.checkBoxCurrentOrder.Checked && !this.checkBoxCloseOrder.Checked)
			{
				strWhere = " id < 0 ";
			}
			else
			{
				if (this.checkBoxNoRegistered.Checked)
				{
					strWhere = " (registered = 0)";
				}
				if (this.checkBoxRegistered.Checked)
				{
					if (string.IsNullOrEmpty(strWhere))
					{
						strWhere = " (registered <> 0 and beginRes is null and dateclose is null) ";
					}
					else
					{
						strWhere += " or (registered <> 0 and beginRes is null and dateclose is null) ";
					}
				}
				if (this.checkBoxCurrentOrder.Checked)
				{
					if (string.IsNullOrEmpty(strWhere))
					{
						strWhere = " (beginRes is not null and dateClose is null) ";
					}
					else
					{
						strWhere += " or (beginRes is not null and dateClose is null) ";
					}
				}
				if (this.checkBoxCloseOrder.Checked)
				{
					if (string.IsNullOrEmpty(strWhere))
					{
						strWhere = " (dateclose is not null) ";
					}
					else
					{
						strWhere += " or (dateclose is not null)";
					}
				}
			}
			if (this.checkedListBoxDivision.CheckedItems.Count > 0 && this.checkedListBoxDivision.CheckedItems.Count < this.checkedListBoxDivision.Items.Count)
			{
				string strListDivisions = "";
				foreach (object obj in this.checkedListBoxDivision.CheckedItems)
				{
					if (string.IsNullOrEmpty(strListDivisions))
					{
						strListDivisions = ((FormJournalOrder.StructObject)obj).Id.ToString();
					}
					else
					{
						strListDivisions = strListDivisions + "," + ((FormJournalOrder.StructObject)obj).Id.ToString();
					}
				}
				if (string.IsNullOrEmpty(strWhere))
				{
					strWhere = string.Format(" (idDivision in ({0})) ", strListDivisions);
				}
				else
				{
					strWhere = string.Format("({1}) and (idDivision in ({0})) ", strListDivisions, strWhere);
				}
			}
			if (string.IsNullOrEmpty(strWhere))
			{
				if (!string.IsNullOrEmpty(whereDateDiaposon))
				{
					strWhere = whereDateDiaposon;
				}
			}
			else if (!string.IsNullOrEmpty(whereDateDiaposon))
			{
				strWhere = string.Concat(new string[]
				{
					"(",whereDateDiaposon,") and (",	strWhere,")"
				});
			}
			this.listSchmObject = this.treeViewSchmObjects.GetListChecked();
			string whereSchmObject = "";
			if (this.listSchmObject.Count > 0)
			{
				foreach (int num2 in this.listSchmObject)
				{
					whereSchmObject = whereSchmObject + num2.ToString() + ",";
				}
				whereSchmObject = whereSchmObject.Remove(whereSchmObject.Length - 1);
			}
			if (string.IsNullOrEmpty(whereSchmObject))
			{
				strWhere = " where " + strWhere;
				base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vJ_Order, true, strWhere + " order by num");
			}
			else
			{
                if (this.checkBoxWhereSub.Checked)
                {
                    string cmdText = string.Format("with sub (Id, FullName) AS        " +
                         " (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text] " +
                         " FROM tSchm_ObjList AS o " +
                         " LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id " +
                         " WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))), " +
                         " bus (Id, busName, subid, subname) AS " +
                         " (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name " +
                         " FROM tSchm_ObjList AS o " +
                         " JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id " +
                         " join tSChm_ObjList sub on sub.id = o.idParent " +
                         " join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id " +
                         " WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))), " +
                         " " +
                         " cell (cellId, cellName, busId, busName, subId, subName) AS " +
                         " (SELECT cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], " +
                         " bus.id, ISNULL(cBus.SocrName + '-', '') + bus.Name [Text], " +
                         " sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name [Text] " +
                         " FROM tSchm_ObjList AS bus " +
                         " JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%' " +
                         " JOIN tSchm_ObjList AS point ON bus.id = point.IdParent " +
                         " JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj " +
                         " JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id " +
                         " JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%' " +
                         " join tschm_objlist as sub on sub.id = bus.idparent " +
                         " JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id " +
                         " WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0))) " +
                         " select distinct vj_order.* from vj_order " +
                         " inner join tL_OrderSchmObjList l on l.idOrder = vj_Order.id " +
                         " left join cell on cell.cellid = l.idSchmObj " +
                         "" +
                         " left join bus on bus.id = l.idSchmObj left join sub on sub.id = l.idSchmObj " +
                         " where (l.idschmObj in ({0}) or isnull(cell.subId, ISNULL(bus.subid, sub.id)) in ({0})) " +
                         " and {1} ", whereSchmObject, strWhere);
                    using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                    {
                        try
                        {
                            sqlConnection.Open();
                            using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
                            {
                                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                                sqlDataAdapter.SelectCommand = sqlCommand;
                                this.dataSetOrder.vJ_Order.Clear();
                                sqlDataAdapter.Fill(this.dataSetOrder.vJ_Order);
                            }
                   //         goto IL_467;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.Source);
                 //           goto IL_467;
                        }
                    }
                }
                else
                {
                    strWhere = " inner join tL_OrderSchmObjList l on l.idOrder = vj_Order.id and l.idSchmObj in (" + whereSchmObject + ") where " + strWhere;
                    base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vJ_Order, true, strWhere + " order by num");
                }
			}
			//IL_467:
			if (idDokument > 0)
			{
				this.dgvOrder.SearchGrid(this.idDgvColumn.Name, idDokument.ToString(), false);
			}
			Control control2 = this.panelDateFilter;
			this.panelFilter.Enabled = true;
			control2.Enabled = true;
			this.Cursor = Cursors.Default;
		}

		private void Load_OrderEvents()
		{
			string whereDivision = string.Concat(new string[]
			{
				" (EvntDate >= '",
				this.DateBeginEventDate.ToString("yyyyMMdd"),
				"' and EvntDate <= '",
				this.DateEndEventDate.ToString("yyyyMMdd"),
				" 23:59:59') "
			});
			if (this.checkedListBoxDivision.CheckedItems.Count > 0 && this.checkedListBoxDivision.CheckedItems.Count < this.checkedListBoxDivision.Items.Count)
			{
				string strListDivisions = "";
				foreach (object obj in this.checkedListBoxDivision.CheckedItems)
				{
					if (string.IsNullOrEmpty(strListDivisions))
					{
						strListDivisions = ((FormJournalOrder.StructObject)obj).Id.ToString();
					}
					else
					{
						strListDivisions = strListDivisions + "," + ((FormJournalOrder.StructObject)obj).Id.ToString();
					}
				}
				if (string.IsNullOrEmpty(whereDivision))
				{
					whereDivision = string.Format(" (idDivision in ({0})) ", strListDivisions);
				}
				else
				{
					whereDivision = string.Format("({1}) and (idDivision in ({0})) ", strListDivisions, whereDivision);
				}
			}
			this.listSchmObjectEvents = this.treeViewSchmObjects.GetListChecked();
			string strIdSchmObj = "";
			if (this.listSchmObjectEvents.Count > 0)
			{
				foreach (int num in this.listSchmObjectEvents)
				{
					strIdSchmObj = strIdSchmObj + num.ToString() + ",";
				}
				strIdSchmObj = strIdSchmObj.Remove(strIdSchmObj.Length - 1);
			}
			if (string.IsNullOrEmpty(strIdSchmObj))
			{
				whereDivision = " where " + whereDivision;
				base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vJ_OrderEvents, true, whereDivision + " order by num");
				return;
			}
			if (this.checkBoxWhereSub.Checked)
			{
				string cmdText = string.Format("with sub (Id, FullName) AS " +
                         " (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text] " +
                         " FROM tSchm_ObjList AS o " +
                         " LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id " +
                         " WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))), " +
                         " bus (Id, busName, subid, subname) AS " +
                         " (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name " +
                         " FROM tSchm_ObjList AS o " +
                         " JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id " +
                         " join tSChm_ObjList sub on sub.id = o.idParent " +
                         " join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id " +
                         " WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))), " +
                         " " +
                         " cell (cellId, cellName, busId, busName, subId, subName) AS " +
                         " (SELECT cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], " +
                         " bus.id, ISNULL(cBus.SocrName + '-', '') + bus.Name [Text], " +
                         " sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name [Text] " +
                         " FROM tSchm_ObjList AS bus " +
                         " JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%' " +
                         " JOIN tSchm_ObjList AS point ON bus.id = point.IdParent " +
                         " JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj " +
                         " JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id " +
                         " JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%' " +
                         " join tschm_objlist as sub on sub.id = bus.idparent " +
                         " JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id " +
                         " WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0))) " +
                         " " +
                         " select distinct vj_orderEvents.* from vj_orderEvents " +
                         " inner join tL_OrderSchmObjList l on l.idOrder = vj_orderEvents.id " +
                         " left join cell on cell.cellid = l.idSchmObj " +
                         " left join bus on bus.id = l.idSchmObj " +
                         " left join sub on sub.id = l.idSchmObj " +
                         " where (l.idschmObj in ({0}) or isnull(cell.subId, ISNULL(bus.subid, sub.id)) in ({0})) " +
                         " and {1} ", strIdSchmObj, whereDivision);
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					try
					{
						sqlConnection.Open();
						using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
						{
							SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
							sqlDataAdapter.SelectCommand = sqlCommand;
							this.dataSetOrder.vJ_OrderEvents.Clear();
							sqlDataAdapter.Fill(this.dataSetOrder.vJ_OrderEvents);
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
			whereDivision = " inner join tL_OrderSchmObjList l on l.idOrder = vj_OrderEvents.id and l.idSchmObj in (" + strIdSchmObj + ") where " + whereDivision;
			base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vJ_OrderEvents, true, whereDivision + " order by num");
		}

		private void toolBtnAddOrder_Click(object sender, EventArgs e)
		{
			FormJournalOrderAddEdit form = new FormJournalOrderAddEdit();
			form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
			form.SqlSettings = this.SqlSettings;
			form.FormClosed += new FormClosedEventHandler( this.f_FormClosed);
			form.MdiParent = base.MdiParent;
			form.Show();
		}

		private void toolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormJournalOrderAddEdit form = new FormJournalOrderAddEdit();
			form.IdDivision = new int?(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
			form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
			form.SqlSettings = this.SqlSettings;
			form.FormClosed += new FormClosedEventHandler( this.f_FormClosed);
			form.MdiParent = base.MdiParent;
			form.Show();
		}

		private void f_GoToSchema(object sender, GoToSchemaEventArgs e)
		{
			this.OnGoToSchema(e);
		}

		private void f_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Load_Order();
			this.dgvOrder.SearchGrid(this.idDgvColumn.Name, ((FormJournalOrderAddEdit)sender).IdOrder.ToString(), false);
			this.Load_OrderEvents();
			this.dgvEvents.SearchGrid(this.idDgvColumnEvent.Name, ((FormJournalOrderAddEdit)sender).IdOrder.ToString(), false);
		}

		private void toolBtnEditOrder_Click(object sender, EventArgs e)
		{
			if (this.tabControlOrder.SelectedTab == this.tabPageView)
			{
				if (this.dgvOrder.CurrentRow == null)
				{
					return;
				}
				FormJournalOrderAddEdit form = new FormJournalOrderAddEdit(Convert.ToInt32(this.dgvOrder.CurrentRow.Cells[this.idDgvColumn.Name].Value), false);
				form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
				form.SqlSettings = this.SqlSettings;
				form.FormClosed += new FormClosedEventHandler( this.f_FormClosed);
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
			if (this.dgvEvents.CurrentRow != null)
			{
				FormJournalOrderAddEdit form2 = new FormJournalOrderAddEdit(Convert.ToInt32(this.dgvEvents.CurrentRow.Cells[this.idDgvColumnEvent.Name].Value), false);
				form2.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
				form2.SqlSettings = this.SqlSettings;
				form2.FormClosed += new  FormClosedEventHandler(this.f_FormClosed);
				form2.MdiParent = base.MdiParent;
				form2.Show();
			}
		}

		private void toolBtnReadOrder_Click(object sender, EventArgs e)
		{
			if (this.tabControlOrder.SelectedTab == this.tabPageView)
			{
				if (this.dgvOrder.CurrentRow != null)
				{
					FormJournalOrderAddEdit form = new FormJournalOrderAddEdit(Convert.ToInt32(this.dgvOrder.CurrentRow.Cells[this.idDgvColumn.Name].Value), true);
					form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
					form.SqlSettings = this.SqlSettings;
					form.MdiParent = base.MdiParent;
					form.Show();
					return;
				}
			}
			else if (this.dgvEvents.CurrentRow != null)
			{
				FormJournalOrderAddEdit form2 = new FormJournalOrderAddEdit(Convert.ToInt32(this.dgvEvents.CurrentRow.Cells[this.idDgvColumnEvent.Name].Value), true);
				form2.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
				form2.SqlSettings = this.SqlSettings;
				form2.MdiParent = base.MdiParent;
				form2.Show();
			}
		}

		private void toolBtnDelOrder_Click(object sender, EventArgs e)
		{
			if (this.tabControlOrder.SelectedTab == this.tabPageView && this.dgvOrder.SelectedRows.Count > 0)
			{
				int num = 0;
				//using (IEnumerator enumerator = this.dataGridViewExcelFilter_0.SelectedRows.GetEnumerator())
				//{
				//	while (enumerator.MoveNext())
				//	{
				//		if (!Convert.ToBoolean(((DataGridViewRow)enumerator.Current).Cells[this.dataGridViewFilterCheckBoxColumn_0.Name].Value))
				//		{
				//			num++;
				//		}
				//	}
				//}
                foreach(var row in this.dgvOrder.SelectedRows)
                {
                    if (!Convert.ToBoolean(((DataGridViewRow)row).Cells[this.registeredDgvColumn.Name].Value))
                    {
                        num++;
                    }

                }
				if (num == 0)
				{
					MessageBox.Show("В выбранном диапазоне нет незарегистрированных нарядов. Удалять можно только их.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (num == this.dgvOrder.SelectedRows.Count)
				{
					if (MessageBox.Show("Удалить выбранные наряды?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						return;
					}
					//using (IEnumerator enumerator = this.dataGridViewExcelFilter_0.SelectedRows.GetEnumerator())
					//{
					//	while (enumerator.MoveNext())
					//	{
     //                       object obj = enumerator.Current;
                            foreach (DataGridViewRow row in this.dgvOrder.SelectedRows)
                            {
                                //object obj = enumerator;
                                //DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                                base.DeleteSqlDataById(this.dataSetOrder.tJ_Order, Convert.ToInt32(row.Cells[this.idDgvColumn.Name].Value));
                                this.dgvOrder.Rows.Remove(row);
                            }
					//	}
					//	return;
					//}
				}
				if (MessageBox.Show("Из выбранных нарядов, незарегистрированных - " + num.ToString() + ". Удалить их?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					foreach (DataGridViewRow row in this.dgvOrder.SelectedRows)
					{
						//DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						if (!Convert.ToBoolean(row.Cells[this.registeredDgvColumn.Name].Value))
						{
							base.DeleteSqlDataById(this.dataSetOrder.tJ_Order, Convert.ToInt32(row.Cells[this.idDgvColumn.Name].Value));
							this.dgvOrder.Rows.Remove(row);
						}
					}
				}
			}
		}

		private void toolBtnReport_Click(object sender, EventArgs e)
		{
			if (this.tabControlOrder.SelectedTab == this.tabPageView)
			{
				if (this.dgvOrder.CurrentRow != null)
				{
					new FormReportOrder(Convert.ToInt32(this.dgvOrder.CurrentRow.Cells[this.idDgvColumn.Name].Value))
					{
						SqlSettings = this.SqlSettings,
						MdiParent = base.MdiParent
					}.Show();
					return;
				}
			}
			else if (this.dgvEvents.CurrentRow != null)
			{
				new FormReportOrder(Convert.ToInt32(this.dgvEvents.CurrentRow.Cells[this.idDgvColumnEvent.Name].Value))
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolBtnReportExcel_Click(object sender, EventArgs e)
		{
			this.toolBtnReportExcel.Enabled = false;
			if (this.tabControlOrder.SelectedTab == this.tabPageView)
			{
				if (this.dgvOrder.CurrentRow != null)
				{
					ReportOrderToExcel.Report(Convert.ToInt32(this.dgvOrder.CurrentRow.Cells[this.idDgvColumn.Name].Value), this.SqlSettings);
				}
			}
			else if (this.dgvEvents.CurrentRow != null)
			{
				ReportOrderToExcel.Report(Convert.ToInt32(this.dgvEvents.CurrentRow.Cells[this.idDgvColumnEvent.Name].Value), this.SqlSettings);
			}
			this.toolBtnReportExcel.Enabled = true;
		}

		private void toolBtnRefresh_Click(object sender, EventArgs e)
		{
			if (this.tabControlOrder.SelectedTab == this.tabPageView)
			{
				this.dateTimePickerBegin.Value = this.DateBegin;
				this.dateTimePickerEnd.Value = this.DateEnd;
				this.Load_Order();
				return;
			}
			this.dateTimePickerBegin.Value = this.DateBeginEventDate;
			this.dateTimePickerEnd.Value = this.DateEndEventDate;
			this.Load_OrderEvents();
		}

		private void toolBtnOrderClose_Click(object sender, EventArgs e)
		{
			new FormJournalOrderClose
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
			this.Load_Order();
		}

		private void checkBoxRegistered_CheckedChanged(object sender, EventArgs e)
		{
			this.Load_Order();
		}

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Load_Order();
        }

        private void checkedListBoxMonth_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.itemCheckEventArgs = e;
            this.Load_Order();
        }

        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
		{
			this.dateTimePickerEnd.MinDate = this.dateTimePickerBegin.Value;
		}

		private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
		{
			this.dateTimePickerBegin.MaxDate = this.dateTimePickerEnd.Value;
		}

		private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (!Convert.ToBoolean(this.dgvOrder[this.registeredDgvColumn.Name, e.RowIndex].Value))
				{
					e.CellStyle.BackColor = Color.Yellow;
				}
				if (this.dgvOrder[this.dateCloseDgvColumn.Name, e.RowIndex].Value != DBNull.Value)
				{
					e.CellStyle.BackColor = Color.Gray;
					return;
				}
				if (this.dgvOrder[this.beginResDgvColumn.Name, e.RowIndex].Value != DBNull.Value)
				{
					e.CellStyle.BackColor = Color.LawnGreen;
				}
				if (this.dgvOrder[this.EndResDgvColumn.Name, e.RowIndex].Value != DBNull.Value && this.dgvOrder.Columns[e.ColumnIndex] == this.numDgvColumn)
				{
					e.CellStyle.BackColor = Color.Red;
				}
			}
		}

		private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				this.toolBtnEditOrder_Click(sender, e);
			}
		}

		private void dgvEvents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && Convert.ToInt32(this.dgvEvents[this.closedDgvColumn.Name, e.RowIndex].Value) == 1)
			{
				e.CellStyle.BackColor = Color.Gray;
			}
		}

		private void dgvEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				this.toolBtnEditOrder_Click(sender, e);
			}
		}

		private void tabControlOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTimePicker dateTimePicker = this.dateTimePickerEnd;
			DateTimePicker dateTimePicker2 = this.dateTimePickerBegin;
			DateTime dateTime = new DateTime(2100, 1, 1);
			dateTimePicker2.MaxDate = dateTime;
			dateTimePicker.MaxDate = dateTime;
			DateTimePicker dateTimePicker3 = this.dateTimePickerEnd;
			DateTimePicker dateTimePicker4 = this.dateTimePickerBegin;
			dateTime = new DateTime(1900, 1, 1);
			dateTimePicker4.MinDate = dateTime;
			dateTimePicker3.MinDate = dateTime;
			this.treeViewSchmObjects.ClearTreeChecked();
            if (this.tabControlOrder.SelectedTab == this.tabPageView)
            {
                this.dateTimePickerEnd.Value = this.DateEnd;
                this.dateTimePickerBegin.Value = this.DateBegin;
                //using (IEnumerator enumerator = this.treeViewSchmObjects_0.Nodes.GetEnumerator())
                //{
                //	while (enumerator.MoveNext())
                //	{
                foreach (TreeNode node in this.treeViewSchmObjects.Nodes)
                {
                    //object obj = enumerator;
                    //TreeNode treeNode_ = (TreeNode)obj;
                    this.CheckedTreeView(node, this.listSchmObject);
                }
                //	}
                //	return;
                //}
            }
            else
            {
                this.dateTimePickerEnd.Value = this.DateEndEventDate;
                this.dateTimePickerBegin.Value = this.DateBeginEventDate;
                foreach (TreeNode node in this.treeViewSchmObjects.Nodes)
                {
                    this.CheckedTreeView(node, this.listSchmObjectEvents);
                }
            }
		}

		private void toolBtnFind_Click(object sender, EventArgs e)
		{
			this.treeViewSchmObjects.Find(this.toolTextBoxFind.Text);
		}

		private void toolBtnFindPrev_Click(object sender, EventArgs e)
		{
			this.treeViewSchmObjects.FindPrev(this.toolTextBoxFind.Text);
		}

		private void toolBtnFindNext_Click(object sender, EventArgs e)
		{
			this.treeViewSchmObjects.FindNext(this.toolTextBoxFind.Text);
		}

		private void toolTextBoxFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Keys modifiers = e.Modifiers;
				if (modifiers == Keys.None)
				{
					this.treeViewSchmObjects.FindNext(this.toolTextBoxFind.Text);
					return;
				}
				if (modifiers != Keys.Shift)
				{
					return;
				}
				this.treeViewSchmObjects.FindPrev(this.toolTextBoxFind.Text);
			}
		}

		private void toolBtnFilter_Click(object sender, EventArgs e)
		{
			if (this.tabControlOrder.SelectedTab == this.tabPageView)
			{
				this.DateBegin = this.dateTimePickerBegin.Value;
				this.DateEnd = this.dateTimePickerEnd.Value;
				this.Load_Order();
				return;
			}
			this.DateBeginEventDate = this.dateTimePickerBegin.Value;
			this.DateEndEventDate = this.dateTimePickerEnd.Value;
			this.Load_OrderEvents();
		}

		private void toolBtnFilterClear_Click(object sender, EventArgs e)
		{
			this.treeViewSchmObjects.ClearTreeChecked();
			if (this.tabControlOrder.SelectedTab == this.tabPageView)
			{
				this.listSchmObject = new List<int>();
				this.Load_Order();
				return;
			}
			this.listSchmObjectEvents = new List<int>();
			this.Load_OrderEvents();
		}

		private void CheckedTreeView(TreeNode treeNode, List<int> checkednodes)
		{
			if (treeNode.Level > 0 && checkednodes.Contains(Convert.ToInt32(treeNode.Tag)))
			{
				treeNode.Checked = true;
			}
			foreach (TreeNode node in treeNode.Nodes)
			{
				this.CheckedTreeView(node, checkednodes);
			}
		}

		protected override XmlDocument CreateXmlConfig()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
			xmlDocument.AppendChild(newChild);
			XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
			xmlDocument.AppendChild(xmlNode);
			foreach (object obj in this.checkedListBoxDivision.CheckedItems)
			{
				XmlNode xmlNode2 = xmlDocument.CreateElement("CheckDivision");
				XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("Id");
				xmlAttribute.Value = ((FormJournalOrder.StructObject)obj).Id.ToString();
				xmlNode2.Attributes.Append(xmlAttribute);
				xmlNode.AppendChild(xmlNode2);
			}
			return xmlDocument;
		}

		protected override void ApplyConfig(XmlDocument doc)
		{
			this.listDivisionOrder = new List<int>();
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
					this.listDivisionOrder.Add(Convert.ToInt32(xmlAttribute.Value));
				}
			}
		}

		private DateTime DateBegin;
		private DateTime DateEnd;
		private DateTime DateBeginEventDate;
		private DateTime DateEndEventDate;
		private List<int> listSubStation;
		

		private class StructObject
		{
			internal int Id { get; set; }

			internal string Name { get; set; }

			internal StructObject(int id, string namee)
			{
				this.Id = id;
				this.Name = namee;
			}

			public override string ToString()
			{
				return this.Name;
			}
		}
	}
}
