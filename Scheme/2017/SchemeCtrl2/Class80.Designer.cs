using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using Legal.Forms;
using Microsoft.Office.Interop.Excel;
using Prv.Forms.Abonent;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Properties;
using SchemeModel;
using WinFormsUI.Docking;

internal class Class80 : DockContentBase
{
	internal Class80()
	{
		Class90.TDroV38zslI2T();
		this.list_0 = new List<RectangleTool>();
		this.int_0 = -1;
		this.eSimulationMode_0 = eSimulationMode.Online;
		this.class46_0 = new Class22.Class46();
		base..ctor();
		this.method_15();
		this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
	}

	internal Class80(DrawObjectBase drawObjectBase_0, bool bool_2, SQLSettings sqlsettings_0)
	{
		Class90.TDroV38zslI2T();
		this.list_0 = new List<RectangleTool>();
		this.int_0 = -1;
		this.eSimulationMode_0 = eSimulationMode.Online;
		this.class46_0 = new Class22.Class46();
		base..ctor();
		this.method_15();
		this.method_0();
		this.int_0 = drawObjectBase_0.IdBase;
		this.eSimulationMode_0 = drawObjectBase_0.Layer.Parent.SimulationMode;
		this.bool_0 = bool_2;
		this.SqlSettings = sqlsettings_0;
		if (bool_2)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			if (drawObjectBase_0 is RectangleTool)
			{
				list = ((RectangleTool)drawObjectBase_0).GetRecipientsPower();
			}
			if (drawObjectBase_0 is ShinaTool)
			{
				list = ((ShinaTool)drawObjectBase_0).GetRecipientsPower();
			}
			if (drawObjectBase_0 is LineTool)
			{
				list = ((LineTool)drawObjectBase_0).GetRecipientsPower();
			}
			if (list != null)
			{
				foreach (DrawObjectBase drawObjectBase in from o in list
				where o.GetType() == typeof(ShinaTool) && o.Parent != null
				select o)
				{
					if (!this.list_0.Contains((RectangleTool)drawObjectBase.Parent))
					{
						this.list_0.Add((RectangleTool)drawObjectBase.Parent);
					}
				}
			}
			if (this.list_0.Count > 0)
			{
				this.Text = this.Text + this.list_0[0].ToString() + " и далее...";
			}
		}
		else
		{
			if (drawObjectBase_0 is RectangleTool)
			{
				this.list_0.Add((RectangleTool)drawObjectBase_0);
			}
			else if (drawObjectBase_0.Parent != null && drawObjectBase_0.Parent is RectangleTool)
			{
				this.list_0.Add((RectangleTool)drawObjectBase_0.Parent);
			}
			if (this.list_0.Count > 0)
			{
				this.Text += this.list_0[0].ToString();
			}
		}
		this.bindingSource_0.Sort = "codeAbonent";
		this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
	}

	private void method_0()
	{
		if (!this.bool_0)
		{
			this.checkBox_0 = new CheckBox();
			this.checkBox_0.Text = "Показать по отключенным рубильникам";
			this.checkBox_0.Checked = true;
			this.bool_1 = this.checkBox_0.Checked;
			this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
			this.QqHjskOslg.Items.Insert(2, new ToolStripControlHost(this.checkBox_0));
		}
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		this.bool_1 = this.checkBox_0.Checked;
		if (this.bool_1)
		{
			this.bindingSource_2.Filter = string.Empty;
		}
		else
		{
			this.bindingSource_2.Filter = "isOn = true or isOn is null";
		}
		this.method_11();
		this.method_13();
	}

	private void method_1()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		base.SelectSqlData(dataTable, true, "where ParentKey like ';SKUEE;ObjFlags;%' and isGroup = 0 and deleted = 0 ", null, false, 0);
		this.comboBox_0 = new ComboBox();
		this.QqHjskOslg.Items.Insert(5, new ToolStripControlHost(this.comboBox_0));
		this.comboBox_0.DisplayMember = "name";
		this.comboBox_0.ValueMember = "id";
		this.comboBox_0.DataSource = dataTable;
		this.comboBox_0.SelectedIndex = -1;
		this.comboBox_0.TextChanged += this.comboBox_0_TextChanged;
		this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
		base.LoadFormConfig(null);
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.method_11();
		this.method_13();
	}

	private void comboBox_0_TextChanged(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.comboBox_0.Text))
		{
			this.comboBox_0.SelectedIndex = -1;
		}
	}

	private void Class80_Load(object sender, EventArgs e)
	{
		this.method_1();
		this.tabControl_0.TabPages.Remove(this.tabPage_0);
		this.method_3();
	}

	private void Class80_DockStateChanged(object sender, EventArgs e)
	{
		if (base.DockState == 1)
		{
			base.FloatPane.FindForm().FormBorderStyle = FormBorderStyle.Sizable;
		}
	}

	private void Class80_FormClosing(object sender, FormClosingEventArgs e)
	{
		base.SaveFormConfig(null);
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		this.method_3();
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		if (this.tabControl_0.SelectedTab == this.tabPage_0)
		{
			this.dataGridViewExcelFilter_0.CopyToExcel(true);
		}
		if (this.tabControl_0.SelectedTab == this.tabPage_1)
		{
			if (this.tabControlVertical_0.SelectedTab == this.tabPage_3)
			{
				this.method_2(new DataGridView[]
				{
					this.treeDataGridView_0,
					this.treeDataGridView_1
				});
				return;
			}
			this.method_2(new DataGridView[]
			{
				this.dataGridViewExcelFilter_3,
				this.dataGridViewExcelFilter_2
			});
		}
	}

	private void method_2(params DataGridView[] dgvList)
	{
		_Application application = new ApplicationClass();
		_Workbook workbook = application.Workbooks.Add(Type.Missing);
		for (int i = 0; i < dgvList.Length; i++)
		{
			DataGridView dataGridView = dgvList[i];
			application.Visible = false;
			_Worksheet worksheet;
			if (i == workbook.Worksheets.Count - 1)
			{
				worksheet = (Worksheet)workbook.Worksheets.get__Default(i + 1);
			}
			else
			{
				worksheet = (Worksheet)workbook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			}
			if (dataGridView.Tag != null)
			{
				worksheet.Name = dataGridView.Tag.ToString();
			}
			else
			{
				worksheet.Name = dataGridView.Name;
			}
			int num = 0;
			for (int j = 0; j < dataGridView.Columns.Count; j++)
			{
				if (dataGridView.Columns[j].Visible)
				{
					int num2 = dataGridView.Columns[j].DisplayIndex + 1 - num;
					worksheet.Cells.set__Default(1, num2, dataGridView.Columns[j].HeaderText);
					((Range)worksheet.Cells.get__Default(1, num2)).Font.Bold = true;
				}
				else
				{
					num++;
				}
			}
			for (int k = 0; k < dataGridView.Rows.Count; k++)
			{
				num = 0;
				for (int l = 0; l < dataGridView.Columns.Count; l++)
				{
					if (dataGridView.Columns[l].Visible)
					{
						int num3 = dataGridView.Columns[l].DisplayIndex + 1 - num;
						if (dataGridView.Rows[k].Cells[l].Value == null)
						{
							worksheet.Cells.set__Default(k + 2, num3, "");
						}
						else
						{
							worksheet.Cells.set__Default(k + 2, num3, dataGridView.Rows[k].Cells[l].Value.ToString());
						}
						((Range)worksheet.Cells.get__Default(k + 2, num3)).WrapText = true;
					}
					else
					{
						num++;
					}
				}
			}
		}
		application.Visible = true;
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void method_3()
	{
		this.QqHjskOslg.Enabled = false;
		this.tabControlVertical_0.Enabled = false;
		this.panel_0.Visible = true;
		this.juXjixQvHf.AutoProgress = true;
		this.panel_0.Left = this.tabControlVertical_0.Width / 2 - this.juXjixQvHf.Width / 2;
		this.panel_0.Top = this.tabControlVertical_0.Height / 2 - this.juXjixQvHf.Height / 2;
		this.dataGridViewExcelFilter_2.DataSource = null;
		this.dataGridViewExcelFilter_3.DataSource = null;
		this.dataGridViewExcelFilter_4.DataSource = null;
		this.dataGridViewExcelFilter_5.DataSource = null;
		this.dataTable_0 = new DataTable("vL_SchmAbnFull");
		this.dataTable_0.Columns.Add("subname", typeof(string));
		this.dataTable_0.Columns.Add("busname", typeof(string));
		this.dataTable_0.Columns.Add("cellname", typeof(string));
		this.dataTable_0.Columns.Add("StreetName", typeof(string));
		this.dataTable_0.Columns.Add("house", typeof(string));
		this.backgroundWorker_0.RunWorkerAsync();
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		ElectricModel electricModel = new ElectricModel();
		electricModel.SqlSettings = this.SqlSettings;
		electricModel.LoadSchema(this.eSimulationMode_0 == eSimulationMode.Normal);
		IEnumerable<ElectricObject> source = electricModel.Objects.Where(new Func<ElectricObject, bool>(this.method_16));
		if (source.Count<ElectricObject>() > 0)
		{
			ElectricObject objFind = source.First<ElectricObject>();
			ElectricObject objParent = null;
			if (!this.bool_0)
			{
				if (objFind is ElectricSubstation)
				{
					objParent = objFind;
				}
				if (objFind is ElectricBus || (objFind is ElectricLine && ((ElectricLine)objFind).IsCell()))
				{
					objParent = objFind.Parent;
				}
			}
			List<ElectricObject> list = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
			string text = "";
			IEnumerable<ElectricObject> enumerable;
			if (this.bool_0)
			{
				enumerable = list;
			}
			else if (objParent == null)
			{
				enumerable = from obj in electricModel.Objects
				where obj == objFind
				select obj;
			}
			else
			{
				enumerable = from obj in electricModel.Objects
				where obj == objFind || obj == objParent || obj.Parent == objParent
				select obj;
			}
			if (enumerable != null && enumerable.Count<ElectricObject>() > 0)
			{
				foreach (ElectricObject electricObject in enumerable)
				{
					if (string.IsNullOrEmpty(text))
					{
						text = electricObject.Id.ToString();
					}
					else
					{
						text = text + "," + electricObject.Id.ToString();
					}
				}
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					try
					{
						sqlConnection.Open();
						this.method_8(sqlConnection, text);
						this.method_9(sqlConnection, text);
						if (!this.dataTable_0.Columns.Contains("isOn"))
						{
							this.dataTable_0.Columns.Add("isOn", typeof(bool));
						}
						foreach (object obj3 in this.dataTable_0.Rows)
						{
							DataRow dataRow = (DataRow)obj3;
							int o = (int)dataRow["idSchmObj"];
							ElectricObject electricObject2 = electricModel.Objects.First((ElectricObject t) => t.Id == o);
							if (electricObject2.GetType() == typeof(ElectricBus))
							{
								dataRow["isOn"] = (((ElectricBus)electricObject2).Amperage != null);
							}
							if (electricObject2.GetType() == typeof(ElectricLine) && ((ElectricLine)electricObject2).IsCell())
							{
								dataRow["isOn"] = (((ElectricLine)electricObject2).AmperageCount > 0 && !((ElectricLine)electricObject2).IsRelationOff());
							}
						}
						this.class22_0.vL_SchmAbnFull.Clear();
						if (!this.class22_0.vL_SchmAbnFull.Columns.Contains("isOn"))
						{
							this.class22_0.vL_SchmAbnFull.Columns.Add("isOn", typeof(bool));
							this.dataGridViewTextBoxColumn_82.DataPropertyName = "isOn";
						}
						if (!this.class22_0.vL_SchmAbnFull.Columns.Contains("ConsumerGRoup"))
						{
							this.class22_0.vL_SchmAbnFull.Columns.Add("ConsumerGRoup", typeof(int));
						}
						if (!string.IsNullOrEmpty(text))
						{
							new SqlDataAdapter("select v.idAbn, v.codeAbonent, v.nameAbn, v.typeAbn, v.idAbnObj, v.nameObj, \r\n\t\t                                                v.id, v.streetname, v.house, v.categoryname, v.tarifname, v.powerset, \r\n\t\t                                                v.powerfact, v.contact, v.idschmObj, v.cellid, v.cellname, v.busid, \r\n\t\t                                                v.busname, v.subid, v.subname, v.abnnet, abnServicing.name as abnServicing, \r\n                                                        v.idSchmObj, objREg.CountPeoples, objREg.ConsumerGRoup,\r\n                                                        tu.numDoc as numTU, tu.dateDoc as dateTU\r\n                                                from vl_SchmAbnFull v\r\n                                                    left join tAbnObjReg objREg on objREg.id = (select top 1 id \r\n\t\t\t\t\t\t\t\t\t\t\t\t                                                from tAbnObjREg\r\n\t\t\t\t\t\t\t\t\t\t\t\t                                                where idAbnObj = v.idAbnObj\r\n\t\t\t\t\t\t\t\t\t\t\t\t                                                order by dateChange desc)\r\n                                                    left join tAbn abnServicing on abnSErvicing.id = objREg.idAbnServicing\r\n                                                    left join vtc_tu tu on tu.id = (select top 1 id from vtc_tu\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    where idAbnObj = v.idAbnObj\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\torder by dateDoc desc)\t\r\n                                                where v.abnActive = 1 and v.objActive = 1 and v.idSchmObj in (" + text + ") and v.typeAbn in (207,231,230) group by v.idAbn, v.codeAbonent, v.nameAbn, v.typeAbn, v.idAbnObj, v.nameObj, \r\n\t\t                                                v.id, v.streetname, v.house, v.categoryname, v.tarifname, v.powerset, \r\n\t\t                                                v.powerfact, v.contact, v.idschmObj, v.cellid, v.cellname, v.busid, \r\n\t\t                                                v.busname, v.subid, v.subname, v.abnnet, abnServicing.name, v.idSchmObj, \r\n                                                        objREg.CountPeoples, objREg.ConsumerGRoup, tu.numDoc, tu.dateDoc\r\n                                                order by v.subname, v.busname, v.cellname, v.nameAbn, v.nameObj ", sqlConnection)
							{
								SelectCommand = 
								{
									CommandTimeout = 0
								}
							}.Fill(this.class22_0.vL_SchmAbnFull);
						}
						foreach (object obj2 in this.class22_0.vL_SchmAbnFull.Rows)
						{
							DataRow dataRow2 = (DataRow)obj2;
							int o = (int)dataRow2["idSchmObj"];
							ElectricObject electricObject3 = electricModel.Objects.First((ElectricObject t) => t.Id == o);
							if (electricObject3.GetType() == typeof(ElectricBus))
							{
								dataRow2["isOn"] = (((ElectricBus)electricObject3).Amperage != null);
							}
							if (electricObject3.GetType() == typeof(ElectricLine) && ((ElectricLine)electricObject3).IsCell())
							{
								dataRow2["isOn"] = (((ElectricLine)electricObject3).AmperageCount > 0 && !((ElectricLine)electricObject3).IsRelationOff());
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
					}
				}
			}
		}
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		this.method_4();
		this.method_11();
		this.method_13();
		this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
		this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
		this.splitContainer_3.SplitterDistance++;
		this.splitContainer_3.SplitterDistance--;
		this.dataGridViewExcelFilter_4.DataSource = this.class46_0;
		this.tabControlVertical_0.Enabled = true;
		this.panel_0.Visible = false;
		this.juXjixQvHf.AutoProgress = false;
		this.QqHjskOslg.Enabled = true;
	}

	private void method_4()
	{
		try
		{
			var source = from row in this.class22_0.vL_SchmAbnFull.AsEnumerable<Class22.Class76>()
			group row by row.Field("idAbn") into abns
			orderby abns.Key
			select new
			{
				IdAbn = abns.Key,
				CountAbn = abns.Count<Class22.Class76>()
			};
			this.textBox_1.Text = source.Count().ToString();
			source = from row in this.class22_0.vL_SchmAbnFull.AsEnumerable<Class22.Class76>()
			group row by row.Field("idAbnObj") into abns
			orderby abns.Key
			select new
			{
				IdAbn = abns.Key,
				CountAbn = abns.Count<Class22.Class76>()
			};
			this.textBox_0.Text = source.Count().ToString();
			var source2 = from row in this.class22_0.vL_SchmAbnFull.AsEnumerable<Class22.Class76>()
			group row by new
			{
				ID = row.Field("idAbnObj"),
				Peoples = row.Field("CountPeoples")
			} into grp
			select new
			{
				IdAbnObj = grp.Key.ID,
				CountPeoples = grp.Key.Peoples
			};
			this.textBox_5.Text = source2.AsEnumerable().Sum(x => x.CountPeoples).ToString();
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("Name", typeof(string));
			base.SelectSqlData(dataTable, true, "where ParentKey = ';SKUEE;Category;' and isGRoup = 0 and deleted = 0 order by name ", null, false, 0);
			this.dataGridView_1.DataSource = this.method_5(this.class22_0.vL_SchmAbnFull, dataTable);
			this.dataGridView_2.DataSource = this.method_5(this.dataTable_0, dataTable);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.class22_0.vL_SchmAbnFull;
			bindingSource.Filter = "ConsumerGRoup in (786,787)";
			this.dataGridViewExcelFilter_5.DataSource = bindingSource;
			source = from row in this.dataTable_0.AsEnumerable()
			group row by row.Field("idAbn") into abns
			orderby abns.Key
			select new
			{
				IdAbn = abns.Key,
				CountAbn = abns.Count<DataRow>()
			};
			this.textBox_3.Text = source.Count().ToString();
			source = from row in this.dataTable_0.AsEnumerable()
			group row by row.Field("idAbnObj") into abns
			orderby abns.Key
			select new
			{
				IdAbn = abns.Key,
				CountAbn = abns.Count<DataRow>()
			};
			this.textBox_2.Text = source.Count().ToString();
			source2 = from row in this.dataTable_0.AsEnumerable()
			group row by new
			{
				ID = row.Field("idAbnObj"),
				Peoples = row.Field("CountPeoples")
			} into grp
			select new
			{
				IdAbnObj = grp.Key.ID,
				CountPeoples = grp.Key.Peoples
			};
			this.textBox_4.Text = source2.AsEnumerable().Sum(x => x.CountPeoples).ToString();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
		}
	}

	private DataTable method_5(DataTable dataTable_3, DataTable dataTable_4)
	{
		var source = (from row in dataTable_3.AsEnumerable()
		group row by row.Field("categoryName") into abns
		orderby abns.Key
		select new
		{
			CategoryName = abns.Key,
			CountCategory = abns.Count<DataRow>()
		}).ToList();
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("CategoryName", typeof(string));
		dataTable.Columns.Add("CountCategory", typeof(string));
		using (IEnumerator enumerator = dataTable_4.Rows.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				DataRow r = (DataRow)enumerator.Current;
				var source2 = from categ in source
				where categ.CategoryName == r["Name"].ToString()
				select categ;
				if (source2.Count() == 0)
				{
					dataTable.Rows.Add(new object[]
					{
						r["Name"],
						DBNull.Value
					});
				}
				else
				{
					dataTable.Rows.Add(new object[]
					{
						source2.First().CategoryName,
						source2.First().CountCategory
					});
				}
			}
		}
		var source3 = from categ in source
		where string.IsNullOrEmpty(categ.CategoryName)
		select categ;
		if (source3.Count() > 0)
		{
			dataTable.Rows.Add(new object[]
			{
				source3.First().CategoryName,
				source3.First().CountCategory
			});
		}
		return dataTable;
	}

	private int method_6()
	{
		if (!this.comboBox_0.InvokeRequired)
		{
			return this.comboBox_0.SelectedIndex;
		}
		return (int)base.Invoke(new Class80.Delegate33(this.method_6), null);
	}

	private object method_7()
	{
		if (!this.comboBox_0.InvokeRequired)
		{
			return this.comboBox_0.SelectedValue;
		}
		return base.Invoke(new Class80.Delegate34(this.method_7), null);
	}

	private void method_8(SqlConnection sqlConnection_0, string string_0)
	{
		this.dataTable_2.Clear();
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		new SqlDataAdapter(string.Format("with sub (Id, FullName, deleted) AS\r\n                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted\r\n                                    FROM tSchm_ObjList AS o\r\n                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id\r\n                                    WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),\r\n                                    \r\n                                    bus (Id, busName, subid, subname, deleted) AS\r\n                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, \r\n                                    \t\tcase when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end\r\n                                    FROM tSchm_ObjList AS o \r\n                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id\r\n                                    join tSChm_ObjList sub on sub.id = o.idParent\r\n                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id\r\n                                    WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),\r\n                                    \r\n                                    cell\t(cellId, cellName, busId, busName, subId, subName, deleted) AS\r\n                                    (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], \r\n                                    \t\t bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],\r\n                                    \t\t sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text], \r\n                                    \t\t case when cell.deleted = 0 and bus.deleted = 0 and sub.deleted = 0 then 0 else 1 end\r\n                                    FROM tSchm_ObjList AS bus\r\n                                    JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'\r\n                                    JOIN tSchm_ObjList AS point ON bus.id = point.IdParent\r\n                                    JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj\r\n                                    JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id\r\n                                    JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'\r\n                                    join tschm_objlist as sub on sub.id = bus.idparent\r\n                                    JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id \r\n                                    \r\n                                    WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))\r\n                                    \r\n                                    \r\n                                    select street.name + isnull(' ' + street.socr, '') as streetname, \r\n                                    \t   CONVERT(varchar(10), map.House) + ISNULL(map.HousePrefix, '') AS house ,\r\n                                           cell.CellName,  \r\n                                    \t   isnull(cell.BusName, bus.busname) as busname,\r\n                                           isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,\r\n                                           count(distinct abn.id) as CountAbn\r\n                                    from tAbn abn\r\n                                    \t\tleft JOIN dbo.tAbnStatus AS statusAbn ON statusAbn.id =\r\n                                    \t\t\t\t\t\t\t\t\t\t\t\t(SELECT     TOP (1) id\r\n                                    \t\t\t\t\t\t\t\t\t\t\t\t FROM dbo.tAbnStatus\r\n                                    \t\t\t\t\t\t\t\t\t\t\t\t WHERE (idAbn = abn.id)\r\n                                    \t\t\t\t\t\t\t\t\t\t\t\t ORDER BY DateChange DESC)\r\n                                    \t\tleft join tAbnObj abnObj on abnObj.idAbn = abn.id \t\r\n                                    \t\tleft join tl_SchmAbn link on link.idAbnObj = abnObj.id and link.idSchmObj in ({0})\r\n                                    \t\tleft join cell on cell.cellid = link.idSchmObj and cell.cellid in ({0})\r\n                                    \t\tleft join bus on bus.id = link.idSChmObj\r\n                                    \t\tleft join sub on sub.id = link.idSChmObj\r\n                                    \t\t\r\n                                    \t\tleft join tMapObj AS map ON map.idMap = abnObj.idMap\r\n                                    \t\tleft join tR_KladrStreet AS street ON street.Id = map.Street \r\n                                    where \tlink.idSchmObj is not null\r\n                                    \t\tand abn.typeAbn in (206,253) and abn.deleted = 0\r\n                                    \t\tand isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0\r\n                                    \t\tand (statusAbn.isActive = 1 or statusAbn.isActive is null)\r\n                                    group by street.name, street.socr, map.House, map.HousePrefix, \r\n                                            cell.CellName, cell.BusName, bus.busname, cell.subname, bus.subname, sub.fullname\r\n                                    order by isnull(cell.subname, isnull(bus.subname, sub.fullname)), isnull(cell.busname, bus.busname), cell.cellname,\r\n                                        street.name, street.socr, map.House, map.HousePrefix", string_0), sqlConnection_0)
		{
			SelectCommand = 
			{
				CommandTimeout = 0
			}
		}.Fill(this.dataTable_2);
	}

	private void method_9(SqlConnection sqlConnection_0, string string_0)
	{
		this.dataTable_0.Clear();
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		new SqlDataAdapter(string.Format("with sub (Id, FullName, deleted) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted\r\n                                                    FROM tSchm_ObjList AS o\r\n                                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),\r\n                                                    \r\n                                                    bus (Id, busName, subid, subname, deleted) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, \r\n                                                    \t\tcase when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end\r\n                                                    FROM tSchm_ObjList AS o \r\n                                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id\r\n                                                    join tSChm_ObjList sub on sub.id = o.idParent\r\n                                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),\r\n                                                    \r\n                                                    cell\t(cellId, cellName, busId, busName, subId, subName, deleted) AS\r\n                                                    (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], \r\n                                                    \t\t bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],\r\n                                                    \t\t sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text], \r\n                                                    \t\t case when cell.deleted = 0 and bus.deleted = 0 and sub.deleted = 0 then 0 else 1 end\r\n                                                    FROM tSchm_ObjList AS bus\r\n                                                    JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'\r\n                                                    JOIN tSchm_ObjList AS point ON bus.id = point.IdParent\r\n                                                    JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj\r\n                                                    JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id\r\n                                                    JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'\r\n                                                    join tschm_objlist as sub on sub.id = bus.idparent\r\n                                                    JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id \r\n                                                    \r\n                                                    WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))\r\n                                                    \r\n                                                    \r\n                                                    select link.idSchmObj,\r\n                                                    \t   isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,\r\n                                                    \t   isnull(cell.BusName, bus.busname) as busname,\r\n                                                    \t   cell.CellName,  \r\n                                                    \t   street.name + isnull(' ' + street.socr, '') as streetname, \r\n                                                    \t   CONVERT(varchar(10), map.House) + ISNULL(map.HousePrefix, '') AS house ,\r\n                                                           abn.id as idAbn,\r\n                                                    \t   abn.codeAbonent,\r\n                                                    \t   abn.name as nameAbn,\r\n                                                    \t   street.Name + ' ' + street.Socr + ', д.' + CAST(map.House AS varchar(10)) + ISNULL(map.HousePrefix, '') + isnull(', кв.' + abnObj.name,'') as nameObj,\r\n                                                    \t   contact.details as contact,\r\n                                                    \t   abnObj.id as idAbnObj,\r\n                                                           objREg.CountPeoples,\r\n                                                           cCategory.name as categoryName\r\n                                                    from tAbn abn\r\n                                                    \t\tleft JOIN dbo.tAbnStatus AS statusAbn ON statusAbn.id =\r\n                                                    \t\t\t\t\t\t\t\t\t\t\t\t(SELECT     TOP (1) id\r\n                                                    \t\t\t\t\t\t\t\t\t\t\t\t FROM dbo.tAbnStatus\r\n                                                    \t\t\t\t\t\t\t\t\t\t\t\t WHERE (idAbn = abn.id)\r\n                                                    \t\t\t\t\t\t\t\t\t\t\t\t ORDER BY DateChange DESC)\r\n                                                    \t\tleft join tAbnObj abnObj on abnObj.idAbn = abn.id \t\r\n                                                    \t\tleft join tl_SchmAbn link on link.idAbnObj = abnObj.id and link.idSchmObj in ({0})\r\n                                    \t\t                left join cell on cell.cellid = link.idSchmObj and cell.cellid in ({0})\r\n                                                    \t\tleft join bus on bus.id = link.idSChmObj\r\n                                                    \t\tleft join sub on sub.id = link.idSChmObj\r\n                                                    \t\t\r\n                                                    \t\tleft join tMapObj AS map ON map.idMap = abnObj.idMap\r\n                                                    \t\tleft join tR_KladrStreet AS street ON street.Id = map.Street \r\n                                                    \t\tleft join (select t.id,\r\n                                                    \t\t\t\t\tDetails = (select td.Phone + '; ' from tabncontact td where t.id = td.idAbn for xml path(''))\r\n                                                    \t\t\t\t   from\ttabn t) as contact on contact.id = abn.id\r\n                                                    \t\tleft join tAbnObjReg objReg on objReg.id = (select top 1 id from tAbnObjReg where idAbnObj = abnobj.id order by datechange desc)\r\n                                                            left join tr_Classifier cCategory on cCategory.id = objREg.Category\r\n                                                    where \tlink.idSchmObj is not null and abn.typeAbn in (206,253) and abn.deleted = 0\r\n                                                    \t\tand isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0\r\n                                                    \t\tand (statusAbn.isActive = 1 or statusAbn.isActive is null)\r\n                                                    group by link.idSchmObj,cell.subname, bus.subname, sub.fullname,\r\n                                                    \t\t cell.BusName, bus.busname, cell.CellName, street.name, street.socr, \r\n                                                             map.House, map.HousePrefix, abn.codeAbonent, abn.name, abn.id,\r\n                                                    \t\t street.Name, street.Socr, abnObj.name, contact.details, abnObj.id, objReg.CountPeoples, cCategory.name\r\n                                                      order by isnull(cell.subname, isnull(bus.subname, sub.fullname)), isnull(cell.busname, bus.busname), cell.cellname,\r\n                                                            street.name, street.socr, map.House, map.HousePrefix", string_0), sqlConnection_0)
		{
			SelectCommand = 
			{
				CommandTimeout = 0
			}
		}.Fill(this.dataTable_0);
	}

	private void method_10()
	{
		if (!this.class22_0.vL_SchmAbnFull.Columns.Contains("abnObjFlag"))
		{
			this.class22_0.vL_SchmAbnFull.Columns.Add("abnObjFlag", typeof(string));
			this.dataGridViewFilterTextBoxColumn_25.DataPropertyName = "abnObjFlag";
		}
		if (this.class22_0.vL_SchmAbnFull.Rows.Count == 0)
		{
			return;
		}
		if (this.method_6() < 0)
		{
			return;
		}
		string text = "";
		foreach (DataRow dataRow in this.class22_0.vL_SchmAbnFull)
		{
			if (string.IsNullOrEmpty(text))
			{
				text = dataRow["idAbnObj"].ToString();
			}
			else
			{
				text = text + "," + dataRow["idAbnObj"].ToString();
			}
			dataRow["AbnObjFlag"] = DBNull.Value;
		}
		DataTable dataTable = new DataTable("vG_AbnObjFlags");
		dataTable.Columns.Add("idAbnObj", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		base.SelectSqlData(dataTable, true, "where idAbnObj in (" + text + ") and idFlag = " + this.method_7().ToString(), null, false, 0);
		foreach (object obj in dataTable.Rows)
		{
			DataRow dataRow2 = (DataRow)obj;
			DataRow[] array = this.class22_0.vL_SchmAbnFull.Select("idAbnObj = " + dataRow2["idAbnObj"].ToString());
			for (int i = 0; i < array.Length; i++)
			{
				array[i]["AbnObjFlag"] = dataRow2["name"];
			}
		}
	}

	private void method_11()
	{
		this.method_10();
		string b = "";
		TreeDataGridViewNode treeDataGridViewNode = null;
		this.treeDataGridView_0.Nodes.Clear();
		foreach (DataRow dataRow in this.class22_0.vL_SchmAbnFull)
		{
			if (this.checkBox_0.Checked || dataRow["isOn"] == DBNull.Value || Convert.ToBoolean(dataRow["IsOn"]))
			{
				if (dataRow["subName"].ToString() != b)
				{
					b = dataRow["subname"].ToString();
					treeDataGridViewNode = this.treeDataGridView_0.Nodes.Add(new object[]
					{
						dataRow["subname"]
					});
					treeDataGridViewNode.Expand();
				}
				treeDataGridViewNode.Nodes.Add(new object[]
				{
					dataRow["busname"],
					dataRow["cellname"],
					dataRow["codeAbonent"],
					dataRow["nameAbn"],
					dataRow["idAbnObj"],
					dataRow["nameObj"],
					dataRow["categoryname"],
					dataRow["tarifname"],
					dataRow["powerset"],
					dataRow["powerfact"],
					dataRow["contact"],
					dataRow["isOn"],
					dataRow["AbnObjFlag"],
					dataRow["numTU"],
					dataRow["dateTU"]
				});
			}
		}
	}

	private void method_12()
	{
		if (!this.dataTable_0.Columns.Contains("abnObjFlag"))
		{
			this.dataTable_0.Columns.Add("abnObjFlag", typeof(string));
		}
		if (this.dataTable_0 == null)
		{
			return;
		}
		if (this.dataTable_0.Rows.Count == 0)
		{
			return;
		}
		string text = "";
		foreach (object obj in this.dataTable_0.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			if (string.IsNullOrEmpty(text))
			{
				text = dataRow["idAbnObj"].ToString();
			}
			else
			{
				text = text + "," + dataRow["idAbnObj"].ToString();
			}
			dataRow["AbnObjFlag"] = DBNull.Value;
		}
		DataTable dataTable = new DataTable("vG_AbnObjFlags");
		dataTable.Columns.Add("idAbnObj", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		if (this.method_6() < 0)
		{
			base.SelectSqlData(dataTable, true, "where idAbnObj in (" + text + ")", null, false, 0);
		}
		else
		{
			base.SelectSqlData(dataTable, true, "where idAbnObj in (" + text + ") and idFlag = " + this.method_7().ToString(), null, false, 0);
		}
		foreach (object obj2 in dataTable.Rows)
		{
			DataRow dataRow2 = (DataRow)obj2;
			foreach (DataRow dataRow3 in this.dataTable_0.Select("idAbnObj = " + dataRow2["idAbnObj"].ToString()))
			{
				if (dataRow3["AbnObjFlag"] != DBNull.Value)
				{
					dataRow3["AbnObjFlag"] = dataRow3["AbnObjFlag"].ToString() + "\r\n" + dataRow2["name"].ToString();
				}
				else
				{
					dataRow3["AbnObjFlag"] = dataRow2["name"];
				}
			}
		}
	}

	private void method_13()
	{
		if (this.dataTable_0 == null)
		{
			return;
		}
		this.method_12();
		TreeDataGridViewNode treeDataGridViewNode = null;
		this.treeDataGridView_1.Nodes.Clear();
		string b = string.Empty;
		foreach (object obj in this.dataTable_0.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			if (this.checkBox_0.Checked || dataRow["isOn"] == DBNull.Value || Convert.ToBoolean(dataRow["IsOn"]))
			{
				if (dataRow["subName"].ToString() != b)
				{
					b = dataRow["subname"].ToString();
					treeDataGridViewNode = this.treeDataGridView_1.Nodes.Add(new object[]
					{
						dataRow["subname"]
					});
					treeDataGridViewNode.Expand();
				}
				treeDataGridViewNode.Nodes.Add(new object[]
				{
					dataRow["busname"],
					dataRow["cellname"],
					dataRow["CodeAbonent"],
					dataRow["nameAbn"],
					dataRow["Streetname"],
					dataRow["house"],
					dataRow["nameObj"],
					dataRow["contact"],
					dataRow["isOn"],
					dataRow["AbnObjFlag"]
				});
			}
		}
	}

	private void tabControlVertical_0_Resize(object sender, EventArgs e)
	{
		this.panel_0.Left = this.tabControlVertical_0.Width / 2 - this.juXjixQvHf.Width / 2;
		this.panel_0.Top = this.tabControlVertical_0.Height / 2 - this.juXjixQvHf.Height / 2;
	}

	private void bindingSource_2_CurrentChanged(object sender, EventArgs e)
	{
		if (this.bindingSource_2.Current != null)
		{
			int num = Convert.ToInt32(((DataRowView)this.bindingSource_2.Current).Row["idAbn"]);
			base.SelectSqlData(this.class46_0, true, "where [idAbn] = " + num, null, false, 0);
			return;
		}
		this.class46_0.Clear();
	}

	private void dataGridViewExcelFilter_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		{
			int num = Convert.ToInt32(this.dataGridViewExcelFilter_2[this.dataGridViewFilterTextBoxColumn_15.Name, e.RowIndex].Value);
			int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_72.Name, e.RowIndex].Value);
			new FormAbn(num, num2)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.DockPanel.FindForm().MdiParent
			}.Show();
		}
	}

	private void dataGridViewExcelFilter_2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			if (this.dataGridViewExcelFilter_2.Rows[e.RowIndex].Cells[this.dataGridViewTextBoxColumn_82.Name].Value == DBNull.Value)
			{
				e.CellStyle.ForeColor = Color.Blue;
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				return;
			}
			if (!(bool)this.dataGridViewExcelFilter_2.Rows[e.RowIndex].Cells[this.dataGridViewTextBoxColumn_82.Name].Value)
			{
				e.CellStyle.ForeColor = Color.Red;
			}
		}
	}

	private void treeDataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		{
			int num = Convert.ToInt32(this.treeDataGridView_0[this.dataGridViewTextBoxColumn_59.Name, e.RowIndex].Value);
			int num2 = Convert.ToInt32(this.treeDataGridView_0[this.dataGridViewTextBoxColumn_61.Name, e.RowIndex].Value);
			new FormAbn(num, num2)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.DockPanel.FindForm().MdiParent
			}.Show();
		}
	}

	private void treeDataGridView_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			if (this.treeDataGridView_0.Rows[e.RowIndex].Cells[this.dataGridViewCheckBoxColumn_2.Name].Value == DBNull.Value || this.treeDataGridView_0.Rows[e.RowIndex].Cells[this.dataGridViewCheckBoxColumn_2.Name].Value == null)
			{
				e.CellStyle.ForeColor = Color.Blue;
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				return;
			}
			if (!(bool)this.treeDataGridView_0.Rows[e.RowIndex].Cells[this.dataGridViewCheckBoxColumn_2.Name].Value)
			{
				e.CellStyle.ForeColor = Color.Red;
			}
		}
	}

	private void treeDataGridView_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		{
			new FormAbonent(Convert.ToInt32(this.treeDataGridView_1[this.dataGridViewTextBoxColumn_84.Name, e.RowIndex].Value), -1)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.DockPanel.FindForm().MdiParent
			}.Show();
		}
	}

	private void treeDataGridView_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			if (this.treeDataGridView_1.Rows[e.RowIndex].Cells[this.dataGridViewCheckBoxColumn_4.Name].Value == DBNull.Value || this.treeDataGridView_1.Rows[e.RowIndex].Cells[this.dataGridViewCheckBoxColumn_4.Name].Value == null)
			{
				e.CellStyle.ForeColor = Color.Blue;
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				return;
			}
			if (!(bool)this.treeDataGridView_1.Rows[e.RowIndex].Cells[this.dataGridViewCheckBoxColumn_4.Name].Value)
			{
				e.CellStyle.ForeColor = Color.Red;
			}
		}
	}

	private void method_14()
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
		string text = string.Empty;
		foreach (RectangleTool rectangleTool in this.list_0)
		{
			if (text != string.Empty)
			{
				text += ", ";
			}
			text = string.Concat(new string[]
			{
				text,
				"'",
				rectangleTool.Text,
				"', '",
				rectangleTool.ToString(),
				"'"
			});
		}
		if (text != string.Empty)
		{
			sqlDataCommand.SelectSqlData(this.class22_0.v_AbnObjRazresh, true, "where [tpname] in (" + text + ") group by idabn, codeAbonent, nameAbn, idObj, nameObj, categoryName, tariffname, razresh, tpname, bushigh, buslow, rubilnik,power, id_razr, contact ", null, false, 0);
			this.bindingSource_0.Position = 0;
			try
			{
				new SqlDataCommand(new SQLSettings("ulges-sql", "Scheme_NL", "WINDOWS", "", "")).SelectSqlData(this.dataTable_1, false, "where [group] in (" + text + ") order by street, inthouse", null, false, 0);
			}
			catch
			{
			}
		}
	}

	private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
	{
		Class22.Class73 @class = (Class22.Class73)((DataRowView)this.bindingSource_0.Current).Row;
		new SqlDataCommand(this.SqlSettings).SelectSqlData(this.class22_0.tAbnContact, true, "where [idAbn] = " + @class.idAbn, null, false, 0);
	}

	private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		{
			int num = Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_23.Name, e.RowIndex].Value);
			int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_25.Name, e.RowIndex].Value);
			new FormAbn(num, num2)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.DockPanel.FindForm().MdiParent
			}.Show();
		}
	}

	private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_29.Name, e.RowIndex].Value != null)
			{
				if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_29.Name, e.RowIndex].Value != DBNull.Value)
				{
					e.CellStyle.ForeColor = Color.OrangeRed;
					return;
				}
			}
			e.CellStyle.ForeColor = Color.Green;
			return;
		}
	}

	protected override void ApplyConfig(XmlDocument xmlDocument_0)
	{
		XmlNode xmlNode = xmlDocument_0.SelectSingleNode(base.Name);
		if (xmlNode != null)
		{
			XmlAttribute xmlAttribute = xmlNode.Attributes["AbnObjFlags"];
			if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
			{
				this.comboBox_0.SelectedValue = Convert.ToInt32(xmlAttribute.Value);
			}
		}
	}

	protected override XmlDocument CreateXmlConfig()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
		xmlDocument.AppendChild(newChild);
		XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
		xmlDocument.AppendChild(xmlNode);
		if (this.comboBox_0.SelectedIndex >= 0)
		{
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("AbnObjFlags");
			xmlAttribute.Value = this.comboBox_0.SelectedValue.ToString();
			xmlNode.Attributes.Append(xmlAttribute);
		}
		return xmlDocument;
	}

	private void treeDataGridView_1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
	{
		this.treeDataGridView_1.AutoResizeRow(e.RowIndex);
	}

	protected override void Dispose(bool bool_2)
	{
		if (bool_2 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Class80.z4TdGPpL18XAo1Orn9WQ(this, bool_2);
	}

	private void method_15()
	{
		this.icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class80));
		DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
		this.button_0 = new Button();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.class22_0 = new Class22();
		this.bindingSource_1 = new BindingSource(this.icontainer_0);
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
		this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
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
		this.label_0 = new Label();
		this.QqHjskOslg = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripSeparator_0 = new ToolStripSeparator();
		this.toolStripLabel_0 = new ToolStripLabel();
		this.dataSet_0 = new DataSet();
		this.dataTable_1 = new DataTable();
		this.dataColumn_0 = new DataColumn();
		this.dataColumn_1 = new DataColumn();
		this.dataColumn_2 = new DataColumn();
		this.dataColumn_3 = new DataColumn();
		this.dataTable_2 = new DataTable();
		this.dataColumn_4 = new DataColumn();
		this.dataColumn_5 = new DataColumn();
		this.dataColumn_6 = new DataColumn();
		this.dataColumn_7 = new DataColumn();
		this.dataColumn_8 = new DataColumn();
		this.dataColumn_9 = new DataColumn();
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
		this.tabControl_0 = new TabControl();
		this.tabPage_1 = new TabPage();
		this.tabControlVertical_0 = new TabControlVertical();
		this.tabPage_3 = new TabPage();
		this.splitContainer_3 = new SplitContainer();
		this.treeDataGridView_0 = new TreeDataGridView();
		this.treeGridColumn_0 = new TreeGridColumn();
		this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
		this.IjtOxmvGoe = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
		this.treeDataGridView_1 = new TreeDataGridView();
		this.tabPage_2 = new TabPage();
		this.splitContainer_0 = new SplitContainer();
		this.dataGridViewExcelFilter_2 = new DataGridViewExcelFilter();
		this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_77 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_78 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_79 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_80 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_81 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_24 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_82 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_25 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_26 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_27 = new DataGridViewFilterTextBoxColumn();
		this.bindingSource_2 = new BindingSource(this.icontainer_0);
		this.splitContainer_1 = new SplitContainer();
		this.dataGridViewExcelFilter_3 = new DataGridViewExcelFilter();
		this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
		this.epoRjLusWF = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
		this.bindingSource_3 = new BindingSource(this.icontainer_0);
		this.dataGridViewExcelFilter_4 = new DataGridViewExcelFilter();
		this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
		this.VbJjefZcrm = new DataGridViewTextBoxColumn();
		this.pLnjzbiuxH = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
		this.tabPage_0 = new TabPage();
		this.splitContainer_2 = new SplitContainer();
		this.label_1 = new Label();
		this.tabPage_4 = new TabPage();
		this.label_8 = new Label();
		this.dataGridViewExcelFilter_5 = new DataGridViewExcelFilter();
		this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
		this.groupBox_1 = new GroupBox();
		this.dataGridView_2 = new DataGridView();
		this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
		this.textBox_4 = new TextBox();
		this.label_6 = new Label();
		this.textBox_2 = new TextBox();
		this.label_4 = new Label();
		this.textBox_3 = new TextBox();
		this.label_5 = new Label();
		this.groupBox_0 = new GroupBox();
		this.dataGridView_1 = new DataGridView();
		this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
		this.textBox_5 = new TextBox();
		this.label_7 = new Label();
		this.textBox_0 = new TextBox();
		this.label_2 = new Label();
		this.textBox_1 = new TextBox();
		this.label_3 = new Label();
		this.panel_0 = new Panel();
		this.mmGjoKudhc = new Label();
		this.juXjixQvHf = new ProgressBarEndLess();
		this.backgroundWorker_0 = new BackgroundWorker();
		this.treeGridColumn_1 = new TreeGridColumn();
		this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.class22_0).BeginInit();
		((ISupportInitialize)this.bindingSource_1).BeginInit();
		this.dataGridViewExcelFilter_0.BeginInit();
		this.dataGridViewExcelFilter_1.BeginInit();
		this.QqHjskOslg.SuspendLayout();
		((ISupportInitialize)this.dataSet_0).BeginInit();
		((ISupportInitialize)this.dataTable_1).BeginInit();
		((ISupportInitialize)this.dataTable_2).BeginInit();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		this.tabControl_0.SuspendLayout();
		this.tabPage_1.SuspendLayout();
		this.tabControlVertical_0.SuspendLayout();
		this.tabPage_3.SuspendLayout();
		this.splitContainer_3.Panel1.SuspendLayout();
		this.splitContainer_3.Panel2.SuspendLayout();
		this.splitContainer_3.SuspendLayout();
		this.treeDataGridView_0.BeginInit();
		this.treeDataGridView_1.BeginInit();
		this.tabPage_2.SuspendLayout();
		this.splitContainer_0.Panel1.SuspendLayout();
		this.splitContainer_0.Panel2.SuspendLayout();
		this.splitContainer_0.SuspendLayout();
		this.dataGridViewExcelFilter_2.BeginInit();
		((ISupportInitialize)this.bindingSource_2).BeginInit();
		this.splitContainer_1.Panel1.SuspendLayout();
		this.splitContainer_1.Panel2.SuspendLayout();
		this.splitContainer_1.SuspendLayout();
		this.dataGridViewExcelFilter_3.BeginInit();
		((ISupportInitialize)this.bindingSource_3).BeginInit();
		this.dataGridViewExcelFilter_4.BeginInit();
		this.tabPage_0.SuspendLayout();
		this.splitContainer_2.Panel1.SuspendLayout();
		this.splitContainer_2.Panel2.SuspendLayout();
		this.splitContainer_2.SuspendLayout();
		this.tabPage_4.SuspendLayout();
		this.dataGridViewExcelFilter_5.BeginInit();
		this.groupBox_1.SuspendLayout();
		((ISupportInitialize)this.dataGridView_2).BeginInit();
		this.groupBox_0.SuspendLayout();
		((ISupportInitialize)this.dataGridView_1).BeginInit();
		this.panel_0.SuspendLayout();
		base.SuspendLayout();
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.OK;
		this.button_0.Location = new Point(866, 661);
		this.button_0.Name = "buttonClose";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 0;
		this.button_0.Text = "Закрыть";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.bindingSource_0.DataMember = "v_AbnObjRazresh";
		this.bindingSource_0.DataSource = this.class22_0;
		this.class22_0.DataSetName = "DataSetScheme";
		this.class22_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.bindingSource_1.DataMember = "tAbnContact";
		this.bindingSource_1.DataSource = this.class22_0;
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
		this.dataGridViewExcelFilter_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_22,
			this.dataGridViewTextBoxColumn_23,
			this.dataGridViewTextBoxColumn_24,
			this.dataGridViewTextBoxColumn_25,
			this.dataGridViewTextBoxColumn_26,
			this.dataGridViewTextBoxColumn_27,
			this.dataGridViewTextBoxColumn_28,
			this.dataGridViewTextBoxColumn_29,
			this.dataGridViewTextBoxColumn_30,
			this.dataGridViewTextBoxColumn_31,
			this.dataGridViewTextBoxColumn_32,
			this.dataGridViewTextBoxColumn_33,
			this.dataGridViewTextBoxColumn_34,
			this.dataGridViewTextBoxColumn_35,
			this.dataGridViewTextBoxColumn_36
		});
		this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
		this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
		this.dataGridViewExcelFilter_0.MultiSelect = false;
		this.dataGridViewExcelFilter_0.Name = "dgvLegalOld";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
		this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_0.Size = new Size(931, 366);
		this.dataGridViewExcelFilter_0.TabIndex = 3;
		this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
		this.dataGridViewExcelFilter_0.CellFormatting += this.dataGridViewExcelFilter_0_CellFormatting;
		this.dataGridViewTextBoxColumn_22.DataPropertyName = "idAbn";
		this.dataGridViewTextBoxColumn_22.HeaderText = "idAbn";
		this.dataGridViewTextBoxColumn_22.Name = "idAbnDgvColumn";
		this.dataGridViewTextBoxColumn_22.ReadOnly = true;
		this.dataGridViewTextBoxColumn_22.Visible = false;
		this.dataGridViewTextBoxColumn_23.DataPropertyName = "codeAbonent";
		this.dataGridViewTextBoxColumn_23.HeaderText = "№ договора";
		this.dataGridViewTextBoxColumn_23.Name = "codeAbonentDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_23.ReadOnly = true;
		this.dataGridViewTextBoxColumn_23.Width = 40;
		this.dataGridViewTextBoxColumn_24.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_24.DataPropertyName = "nameAbn";
		this.dataGridViewTextBoxColumn_24.HeaderText = "Абонент";
		this.dataGridViewTextBoxColumn_24.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn_24.Name = "nameAbnDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_24.ReadOnly = true;
		this.dataGridViewTextBoxColumn_25.DataPropertyName = "idObj";
		this.dataGridViewTextBoxColumn_25.HeaderText = "idObj";
		this.dataGridViewTextBoxColumn_25.Name = "idObjDgvColumn";
		this.dataGridViewTextBoxColumn_25.ReadOnly = true;
		this.dataGridViewTextBoxColumn_25.Visible = false;
		this.dataGridViewTextBoxColumn_26.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_26.DataPropertyName = "nameObj";
		this.dataGridViewTextBoxColumn_26.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_26.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn_26.Name = "nameObjDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_26.ReadOnly = true;
		this.dataGridViewTextBoxColumn_27.DataPropertyName = "categoryName";
		this.dataGridViewTextBoxColumn_27.HeaderText = "Кат.";
		this.dataGridViewTextBoxColumn_27.Name = "categoryNameDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_27.ReadOnly = true;
		this.dataGridViewTextBoxColumn_27.Width = 30;
		this.dataGridViewTextBoxColumn_28.DataPropertyName = "tariffName";
		this.dataGridViewTextBoxColumn_28.HeaderText = "Тар.";
		this.dataGridViewTextBoxColumn_28.Name = "tariffNameDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_28.ReadOnly = true;
		this.dataGridViewTextBoxColumn_28.Width = 45;
		this.dataGridViewTextBoxColumn_29.DataPropertyName = "Razresh";
		this.dataGridViewTextBoxColumn_29.HeaderText = "Разрешение";
		this.dataGridViewTextBoxColumn_29.Name = "razreshDgvColumn";
		this.dataGridViewTextBoxColumn_29.ReadOnly = true;
		this.dataGridViewTextBoxColumn_30.DataPropertyName = "tpName";
		this.dataGridViewTextBoxColumn_30.HeaderText = "ПС";
		this.dataGridViewTextBoxColumn_30.Name = "tpNameDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_30.ReadOnly = true;
		this.dataGridViewTextBoxColumn_30.Width = 70;
		this.dataGridViewTextBoxColumn_31.DataPropertyName = "busHigh";
		this.dataGridViewTextBoxColumn_31.HeaderText = "СШ 6/10";
		this.dataGridViewTextBoxColumn_31.Name = "busHighDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_31.ReadOnly = true;
		this.dataGridViewTextBoxColumn_31.Width = 40;
		this.dataGridViewTextBoxColumn_32.DataPropertyName = "busLow";
		this.dataGridViewTextBoxColumn_32.HeaderText = "СШ 0,4";
		this.dataGridViewTextBoxColumn_32.Name = "busLowDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_32.ReadOnly = true;
		this.dataGridViewTextBoxColumn_32.Width = 40;
		this.dataGridViewTextBoxColumn_33.DataPropertyName = "rubilnik";
		this.dataGridViewTextBoxColumn_33.HeaderText = "Руб.";
		this.dataGridViewTextBoxColumn_33.Name = "rubilnikDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_33.ReadOnly = true;
		this.dataGridViewTextBoxColumn_33.Width = 30;
		this.dataGridViewTextBoxColumn_34.DataPropertyName = "Power";
		this.dataGridViewTextBoxColumn_34.HeaderText = "кВт";
		this.dataGridViewTextBoxColumn_34.Name = "powerDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_34.ReadOnly = true;
		this.dataGridViewTextBoxColumn_34.Width = 30;
		this.dataGridViewTextBoxColumn_35.DataPropertyName = "id_razr";
		this.dataGridViewTextBoxColumn_35.HeaderText = "id_razr";
		this.dataGridViewTextBoxColumn_35.Name = "idrazrDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_35.ReadOnly = true;
		this.dataGridViewTextBoxColumn_35.Visible = false;
		this.dataGridViewTextBoxColumn_36.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_36.DataPropertyName = "Contact";
		this.dataGridViewTextBoxColumn_36.FillWeight = 50f;
		this.dataGridViewTextBoxColumn_36.HeaderText = "Контактные телефоны";
		this.dataGridViewTextBoxColumn_36.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn_36.Name = "contactDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_36.ReadOnly = true;
		this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
		this.dataGridViewExcelFilter_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_1.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
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
			this.dataGridViewTextBoxColumn_9
		});
		this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
		this.dataGridViewExcelFilter_1.Location = new Point(0, 385);
		this.dataGridViewExcelFilter_1.MultiSelect = false;
		this.dataGridViewExcelFilter_1.Name = "dataGridViewExcelFilter2";
		this.dataGridViewExcelFilter_1.ReadOnly = true;
		this.dataGridViewExcelFilter_1.RowHeadersWidth = 21;
		this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_1.Size = new Size(931, 73);
		this.dataGridViewExcelFilter_1.TabIndex = 3;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_0.HeaderText = "id";
		this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "idAbn";
		this.dataGridViewTextBoxColumn_1.HeaderText = "idAbn";
		this.dataGridViewTextBoxColumn_1.Name = "idAbnDataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.dataGridViewTextBoxColumn_2.DataPropertyName = "Post";
		this.dataGridViewTextBoxColumn_2.HeaderText = "Должность";
		this.dataGridViewTextBoxColumn_2.Name = "postDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_3.DataPropertyName = "F";
		this.dataGridViewTextBoxColumn_3.HeaderText = "Фамилия";
		this.dataGridViewTextBoxColumn_3.MinimumWidth = 50;
		this.dataGridViewTextBoxColumn_3.Name = "fDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "I";
		this.dataGridViewTextBoxColumn_4.HeaderText = "Имя";
		this.dataGridViewTextBoxColumn_4.MinimumWidth = 50;
		this.dataGridViewTextBoxColumn_4.Name = "iDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "O";
		this.dataGridViewTextBoxColumn_5.HeaderText = "Отчество";
		this.dataGridViewTextBoxColumn_5.MinimumWidth = 50;
		this.dataGridViewTextBoxColumn_5.Name = "oDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "Phone";
		this.dataGridViewTextBoxColumn_6.HeaderText = "Телефон";
		this.dataGridViewTextBoxColumn_6.Name = "phoneDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "DateChange";
		this.dataGridViewTextBoxColumn_7.HeaderText = "DateChange";
		this.dataGridViewTextBoxColumn_7.Name = "dateChangeDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.Visible = false;
		this.dataGridViewTextBoxColumn_8.DataPropertyName = "Comment";
		this.dataGridViewTextBoxColumn_8.HeaderText = "Коментарий";
		this.dataGridViewTextBoxColumn_8.Name = "commentDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_8.ReadOnly = true;
		this.dataGridViewTextBoxColumn_8.Width = 120;
		this.dataGridViewTextBoxColumn_9.DataPropertyName = "email";
		this.dataGridViewTextBoxColumn_9.HeaderText = "e`mail";
		this.dataGridViewTextBoxColumn_9.Name = "emailDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_9.ReadOnly = true;
		this.label_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(0, 369);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(59, 13);
		this.label_0.TabIndex = 4;
		this.label_0.Text = "Контакты:";
		this.QqHjskOslg.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripButton_1,
			this.toolStripSeparator_0,
			this.toolStripLabel_0
		});
		this.QqHjskOslg.Location = new Point(0, 0);
		this.QqHjskOslg.Name = "toolStrip1";
		this.QqHjskOslg.Size = new Size(945, 25);
		this.QqHjskOslg.TabIndex = 5;
		this.QqHjskOslg.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.microsoftoffice2007excel_7581;
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolBtnExportToExcel";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "Экспорт в Excel";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.refresh_16;
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolStripButtonRefresh";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Обновить";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.toolStripSeparator_0.Name = "toolStripSeparator1";
		this.toolStripSeparator_0.Size = new Size(6, 25);
		this.toolStripLabel_0.Name = "toolStripLabel1";
		this.toolStripLabel_0.Size = new Size(54, 22);
		this.toolStripLabel_0.Text = "Признак";
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new DataTable[]
		{
			this.dataTable_1,
			this.dataTable_2
		});
		this.dataTable_1.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2,
			this.dataColumn_3
		});
		this.dataTable_1.TableName = "ABN_NASELENIE";
		this.dataColumn_0.ColumnName = "Street";
		this.dataColumn_1.ColumnName = "House";
		this.dataColumn_2.ColumnName = "num_abonent";
		this.dataColumn_2.DataType = typeof(int);
		this.dataColumn_3.ColumnName = "group";
		this.dataTable_2.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_4,
			this.dataColumn_5,
			this.dataColumn_6,
			this.dataColumn_7,
			this.dataColumn_8,
			this.dataColumn_9
		});
		this.dataTable_2.TableName = "vL_SchmAbnFull";
		this.dataColumn_4.ColumnName = "StreetName";
		this.dataColumn_5.ColumnName = "house";
		this.dataColumn_6.ColumnName = "subname";
		this.dataColumn_7.ColumnName = "busname";
		this.dataColumn_8.ColumnName = "cellname";
		this.dataColumn_9.ColumnName = "countAbn";
		this.dataColumn_9.DataType = typeof(int);
		this.dataGridView_0.AllowUserToAddRows = false;
		this.dataGridView_0.AllowUserToDeleteRows = false;
		this.dataGridView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.dataGridView_0.AutoGenerateColumns = false;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_10,
			this.dataGridViewTextBoxColumn_11,
			this.dataGridViewTextBoxColumn_12,
			this.dataGridViewTextBoxColumn_13
		});
		this.dataGridView_0.DataMember = "ABN_NASELENIE";
		this.dataGridView_0.DataSource = this.dataSet_0;
		this.dataGridView_0.Location = new Point(0, 27);
		this.dataGridView_0.Name = "dgvPrv";
		this.dataGridView_0.ReadOnly = true;
		this.dataGridView_0.Size = new Size(931, 103);
		this.dataGridView_0.TabIndex = 6;
		this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_10.DataPropertyName = "Street";
		this.dataGridViewTextBoxColumn_10.HeaderText = "Улица";
		this.dataGridViewTextBoxColumn_10.Name = "streetDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_10.ReadOnly = true;
		this.dataGridViewTextBoxColumn_11.DataPropertyName = "House";
		this.dataGridViewTextBoxColumn_11.HeaderText = "Дом";
		this.dataGridViewTextBoxColumn_11.Name = "houseDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_11.ReadOnly = true;
		this.dataGridViewTextBoxColumn_12.DataPropertyName = "num_abonent";
		this.dataGridViewTextBoxColumn_12.HeaderText = "Кол-во аб";
		this.dataGridViewTextBoxColumn_12.Name = "numabonentDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_12.ReadOnly = true;
		this.dataGridViewTextBoxColumn_13.DataPropertyName = "group";
		this.dataGridViewTextBoxColumn_13.HeaderText = "ПС";
		this.dataGridViewTextBoxColumn_13.Name = "groupDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_13.ReadOnly = true;
		this.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_4);
		this.tabControl_0.Location = new Point(0, 28);
		this.tabControl_0.Name = "tabControl";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(945, 627);
		this.tabControl_0.TabIndex = 7;
		this.tabPage_1.Controls.Add(this.tabControlVertical_0);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "tabPageNew";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(937, 601);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Новая привязка";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.tabControlVertical_0.Alignment = TabAlignment.Right;
		this.tabControlVertical_0.Controls.Add(this.tabPage_3);
		this.tabControlVertical_0.Controls.Add(this.tabPage_2);
		this.tabControlVertical_0.Dock = DockStyle.Fill;
		this.tabControlVertical_0.Location = new Point(3, 3);
		this.tabControlVertical_0.Multiline = true;
		this.tabControlVertical_0.Name = "tabControlNewSchmAbn";
		this.tabControlVertical_0.SelectedIndex = 0;
		this.tabControlVertical_0.Size = new Size(931, 595);
		this.tabControlVertical_0.TabIndex = 2;
		this.tabControlVertical_0.Resize += this.tabControlVertical_0_Resize;
		this.tabPage_3.Controls.Add(this.splitContainer_3);
		this.tabPage_3.Location = new Point(4, 4);
		this.tabPage_3.Name = "tabPageGroup";
		this.tabPage_3.Padding = new Padding(3);
		this.tabPage_3.Size = new Size(904, 587);
		this.tabPage_3.TabIndex = 1;
		this.tabPage_3.Text = "Группировка";
		this.tabPage_3.UseVisualStyleBackColor = true;
		this.splitContainer_3.Dock = DockStyle.Fill;
		this.splitContainer_3.Location = new Point(3, 3);
		this.splitContainer_3.Name = "splitContainer3";
		this.splitContainer_3.Orientation = Orientation.Horizontal;
		this.splitContainer_3.Panel1.Controls.Add(this.treeDataGridView_0);
		this.splitContainer_3.Panel2.Controls.Add(this.treeDataGridView_1);
		this.splitContainer_3.Size = new Size(898, 581);
		this.splitContainer_3.SplitterDistance = 290;
		this.splitContainer_3.TabIndex = 2;
		this.treeDataGridView_0.AllowUserToAddRows = false;
		this.treeDataGridView_0.AllowUserToDeleteRows = false;
		this.treeDataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.treeGridColumn_0,
			this.dataGridViewTextBoxColumn_58,
			this.dataGridViewTextBoxColumn_59,
			this.dataGridViewTextBoxColumn_60,
			this.dataGridViewTextBoxColumn_61,
			this.dataGridViewTextBoxColumn_62,
			this.IjtOxmvGoe,
			this.dataGridViewTextBoxColumn_63,
			this.dataGridViewTextBoxColumn_64,
			this.dataGridViewTextBoxColumn_65,
			this.dataGridViewTextBoxColumn_66,
			this.dataGridViewCheckBoxColumn_2,
			this.dataGridViewTextBoxColumn_67,
			this.dataGridViewTextBoxColumn_68,
			this.dataGridViewTextBoxColumn_69
		});
		this.treeDataGridView_0.Dock = DockStyle.Fill;
		this.treeDataGridView_0.EditMode = DataGridViewEditMode.EditProgrammatically;
		this.treeDataGridView_0.ImageList = null;
		this.treeDataGridView_0.Location = new Point(0, 0);
		this.treeDataGridView_0.Name = "dgvTreeLegal";
		this.treeDataGridView_0.Size = new Size(898, 290);
		this.treeDataGridView_0.TabIndex = 1;
		this.treeDataGridView_0.Tag = "Юридические лица";
		this.treeDataGridView_0.CellDoubleClick += this.treeDataGridView_0_CellDoubleClick;
		this.treeDataGridView_0.CellFormatting += this.treeDataGridView_0_CellFormatting;
		this.treeGridColumn_0.DefaultNodeImage = null;
		this.treeGridColumn_0.HeaderText = "Подстанция\\шина";
		this.treeGridColumn_0.Name = "columnDgvSubstation";
		this.treeGridColumn_0.Resizable = DataGridViewTriState.True;
		this.treeGridColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_58.HeaderText = "Ячейка";
		this.dataGridViewTextBoxColumn_58.Name = "Column3";
		this.dataGridViewTextBoxColumn_58.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_58.Width = 55;
		this.dataGridViewTextBoxColumn_59.HeaderText = "Код";
		this.dataGridViewTextBoxColumn_59.Name = "codeAbnTreeLegalDgvColumn";
		this.dataGridViewTextBoxColumn_59.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_59.Width = 55;
		this.dataGridViewTextBoxColumn_60.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_60.HeaderText = "Абонент";
		this.dataGridViewTextBoxColumn_60.Name = "Column4";
		this.dataGridViewTextBoxColumn_60.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_61.HeaderText = "idAbnObj";
		this.dataGridViewTextBoxColumn_61.Name = "idAbnObjTreeLegalDgvColumn";
		this.dataGridViewTextBoxColumn_61.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_61.Visible = false;
		this.dataGridViewTextBoxColumn_62.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_62.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_62.Name = "Column5";
		this.dataGridViewTextBoxColumn_62.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.IjtOxmvGoe.HeaderText = "Кат";
		this.IjtOxmvGoe.Name = "Column6";
		this.IjtOxmvGoe.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.IjtOxmvGoe.Width = 60;
		this.dataGridViewTextBoxColumn_63.HeaderText = "Тар";
		this.dataGridViewTextBoxColumn_63.Name = "Column12";
		this.dataGridViewTextBoxColumn_63.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_63.Width = 50;
		this.dataGridViewTextBoxColumn_64.HeaderText = "Уст мощность";
		this.dataGridViewTextBoxColumn_64.Name = "Column13";
		this.dataGridViewTextBoxColumn_64.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_65.HeaderText = "Факт мощность";
		this.dataGridViewTextBoxColumn_65.Name = "Column14";
		this.dataGridViewTextBoxColumn_65.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_66.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_66.FillWeight = 70f;
		this.dataGridViewTextBoxColumn_66.HeaderText = "Телефоны";
		this.dataGridViewTextBoxColumn_66.Name = "Column15";
		this.dataGridViewTextBoxColumn_66.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewCheckBoxColumn_2.HeaderText = "IsOn";
		this.dataGridViewCheckBoxColumn_2.Name = "isOnTreeLegalDgvColumn";
		this.dataGridViewCheckBoxColumn_2.Visible = false;
		this.dataGridViewTextBoxColumn_67.HeaderText = "Признак";
		this.dataGridViewTextBoxColumn_67.Name = "flagObjTreeLegalDgvColumn";
		this.dataGridViewTextBoxColumn_67.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_68.HeaderText = "№ ТУ";
		this.dataGridViewTextBoxColumn_68.Name = "numTUDgvTree";
		this.dataGridViewTextBoxColumn_68.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_68.Width = 40;
		dataGridViewCellStyle.Format = "d";
		dataGridViewCellStyle.NullValue = null;
		this.dataGridViewTextBoxColumn_69.DefaultCellStyle = dataGridViewCellStyle;
		this.dataGridViewTextBoxColumn_69.HeaderText = "Дата ТУ";
		this.dataGridViewTextBoxColumn_69.Name = "dateTUDgvTRee";
		this.dataGridViewTextBoxColumn_69.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_69.Width = 80;
		this.treeDataGridView_1.AllowUserToAddRows = false;
		this.treeDataGridView_1.AllowUserToDeleteRows = false;
		this.treeDataGridView_1.Columns.AddRange(new DataGridViewColumn[]
		{
			this.treeGridColumn_1,
			this.dataGridViewTextBoxColumn_83,
			this.dataGridViewTextBoxColumn_84,
			this.dataGridViewTextBoxColumn_85,
			this.dataGridViewTextBoxColumn_86,
			this.dataGridViewTextBoxColumn_87,
			this.dataGridViewTextBoxColumn_88,
			this.dataGridViewTextBoxColumn_89,
			this.dataGridViewCheckBoxColumn_4,
			this.dataGridViewTextBoxColumn_90
		});
		this.treeDataGridView_1.Dock = DockStyle.Fill;
		this.treeDataGridView_1.EditMode = DataGridViewEditMode.EditProgrammatically;
		this.treeDataGridView_1.ImageList = null;
		this.treeDataGridView_1.Location = new Point(0, 0);
		this.treeDataGridView_1.Name = "dgvTreePrv";
		this.treeDataGridView_1.Size = new Size(898, 287);
		this.treeDataGridView_1.TabIndex = 2;
		this.treeDataGridView_1.Tag = "Физические лица";
		this.treeDataGridView_1.CellDoubleClick += this.treeDataGridView_1_CellDoubleClick;
		this.treeDataGridView_1.CellFormatting += this.treeDataGridView_1_CellFormatting;
		this.treeDataGridView_1.RowPostPaint += this.treeDataGridView_1_RowPostPaint;
		this.tabPage_2.Controls.Add(this.splitContainer_0);
		this.tabPage_2.Location = new Point(4, 4);
		this.tabPage_2.Name = "tabPageList";
		this.tabPage_2.Padding = new Padding(3);
		this.tabPage_2.Size = new Size(904, 587);
		this.tabPage_2.TabIndex = 0;
		this.tabPage_2.Text = "Список";
		this.tabPage_2.UseVisualStyleBackColor = true;
		this.splitContainer_0.Dock = DockStyle.Fill;
		this.splitContainer_0.Location = new Point(3, 3);
		this.splitContainer_0.Name = "splitContainerList";
		this.splitContainer_0.Orientation = Orientation.Horizontal;
		this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_2);
		this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
		this.splitContainer_0.Size = new Size(898, 581);
		this.splitContainer_0.SplitterDistance = 290;
		this.splitContainer_0.TabIndex = 7;
		this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_2.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_2.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewFilterTextBoxColumn_12,
			this.dataGridViewFilterTextBoxColumn_13,
			this.dataGridViewFilterTextBoxColumn_14,
			this.dataGridViewTextBoxColumn_70,
			this.dataGridViewFilterTextBoxColumn_15,
			this.dataGridViewFilterTextBoxColumn_16,
			this.dataGridViewTextBoxColumn_71,
			this.dataGridViewCheckBoxColumn_3,
			this.dataGridViewTextBoxColumn_72,
			this.dataGridViewFilterTextBoxColumn_17,
			this.dataGridViewTextBoxColumn_73,
			this.dataGridViewTextBoxColumn_74,
			this.dataGridViewTextBoxColumn_75,
			this.dataGridViewTextBoxColumn_76,
			this.dataGridViewFilterTextBoxColumn_18,
			this.dataGridViewFilterTextBoxColumn_19,
			this.dataGridViewFilterTextBoxColumn_20,
			this.dataGridViewFilterTextBoxColumn_21,
			this.dataGridViewFilterTextBoxColumn_22,
			this.dataGridViewTextBoxColumn_77,
			this.dataGridViewTextBoxColumn_78,
			this.dataGridViewTextBoxColumn_79,
			this.dataGridViewTextBoxColumn_80,
			this.dataGridViewTextBoxColumn_81,
			this.dataGridViewFilterTextBoxColumn_23,
			this.dataGridViewFilterTextBoxColumn_24,
			this.dataGridViewTextBoxColumn_82,
			this.dataGridViewFilterTextBoxColumn_25,
			this.dataGridViewFilterTextBoxColumn_26,
			this.dataGridViewFilterTextBoxColumn_27
		});
		this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
		this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_2.Location = new Point(0, 0);
		this.dataGridViewExcelFilter_2.Name = "dgvListLegal";
		this.dataGridViewExcelFilter_2.ReadOnly = true;
		this.dataGridViewExcelFilter_2.RowHeadersWidth = 21;
		this.dataGridViewExcelFilter_2.Size = new Size(898, 290);
		this.dataGridViewExcelFilter_2.TabIndex = 0;
		this.dataGridViewExcelFilter_2.Tag = "Юридические лица";
		this.dataGridViewExcelFilter_2.CellDoubleClick += this.dataGridViewExcelFilter_2_CellDoubleClick;
		this.dataGridViewExcelFilter_2.CellFormatting += this.dataGridViewExcelFilter_2_CellFormatting;
		this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "subname";
		this.dataGridViewFilterTextBoxColumn_12.HeaderText = "ПС";
		this.dataGridViewFilterTextBoxColumn_12.Name = "subnameDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_12.Width = 65;
		this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "busname";
		this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Шина";
		this.dataGridViewFilterTextBoxColumn_13.Name = "busnameDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_13.Width = 55;
		this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "CellName";
		this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Ячейка";
		this.dataGridViewFilterTextBoxColumn_14.Name = "cellNameDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_14.Width = 55;
		this.dataGridViewTextBoxColumn_70.DataPropertyName = "idAbn";
		this.dataGridViewTextBoxColumn_70.HeaderText = "idAbn";
		this.dataGridViewTextBoxColumn_70.Name = "idAbnListLegalDgvColumn";
		this.dataGridViewTextBoxColumn_70.ReadOnly = true;
		this.dataGridViewTextBoxColumn_70.Visible = false;
		this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "codeAbonent";
		this.dataGridViewFilterTextBoxColumn_15.HeaderText = "№ договора";
		this.dataGridViewFilterTextBoxColumn_15.Name = "codeAbnListlegalDgvColumn";
		this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_15.Width = 70;
		this.dataGridViewFilterTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "nameAbn";
		this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Абонент";
		this.dataGridViewFilterTextBoxColumn_16.Name = "nameAbnDataGridViewTextBoxColumn1";
		this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_71.DataPropertyName = "typeAbn";
		this.dataGridViewTextBoxColumn_71.HeaderText = "typeAbn";
		this.dataGridViewTextBoxColumn_71.Name = "typeAbnDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_71.ReadOnly = true;
		this.dataGridViewTextBoxColumn_71.Visible = false;
		this.dataGridViewCheckBoxColumn_3.DataPropertyName = "aBnActive";
		this.dataGridViewCheckBoxColumn_3.HeaderText = "aBnActive";
		this.dataGridViewCheckBoxColumn_3.Name = "aBnActiveDataGridViewCheckBoxColumn";
		this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_3.Visible = false;
		this.dataGridViewTextBoxColumn_72.DataPropertyName = "idAbnObj";
		this.dataGridViewTextBoxColumn_72.HeaderText = "idAbnObj";
		this.dataGridViewTextBoxColumn_72.Name = "idAbnObjListLegalDvColumn";
		this.dataGridViewTextBoxColumn_72.ReadOnly = true;
		this.dataGridViewTextBoxColumn_72.Visible = false;
		this.dataGridViewFilterTextBoxColumn_17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "nameObj";
		this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Объект";
		this.dataGridViewFilterTextBoxColumn_17.Name = "nameObjDataGridViewTextBoxColumn1";
		this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_17.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_73.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_73.HeaderText = "id";
		this.dataGridViewTextBoxColumn_73.Name = "idDataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_73.ReadOnly = true;
		this.dataGridViewTextBoxColumn_73.Visible = false;
		this.dataGridViewTextBoxColumn_74.DataPropertyName = "streetname";
		this.dataGridViewTextBoxColumn_74.HeaderText = "streetname";
		this.dataGridViewTextBoxColumn_74.Name = "streetnameDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_74.ReadOnly = true;
		this.dataGridViewTextBoxColumn_74.Visible = false;
		this.dataGridViewTextBoxColumn_75.DataPropertyName = "house";
		this.dataGridViewTextBoxColumn_75.HeaderText = "house";
		this.dataGridViewTextBoxColumn_75.Name = "houseDataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_75.ReadOnly = true;
		this.dataGridViewTextBoxColumn_75.Visible = false;
		this.dataGridViewTextBoxColumn_76.DataPropertyName = "objActive";
		this.dataGridViewTextBoxColumn_76.HeaderText = "objActive";
		this.dataGridViewTextBoxColumn_76.Name = "objActiveDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_76.ReadOnly = true;
		this.dataGridViewTextBoxColumn_76.Visible = false;
		this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "CategoryName";
		this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Кат";
		this.dataGridViewFilterTextBoxColumn_18.Name = "categoryNameDataGridViewTextBoxColumn1";
		this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_18.Width = 40;
		this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "TarifName";
		this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Тар";
		this.dataGridViewFilterTextBoxColumn_19.Name = "tarifNameDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_19.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_19.Width = 40;
		this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "PowerSet";
		this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Уст мощность";
		this.dataGridViewFilterTextBoxColumn_20.Name = "powerSetDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_20.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "PowerFact";
		this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Факт мощность";
		this.dataGridViewFilterTextBoxColumn_21.Name = "powerFactDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_21.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "contact";
		this.dataGridViewFilterTextBoxColumn_22.FillWeight = 70f;
		this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Телефоны";
		this.dataGridViewFilterTextBoxColumn_22.Name = "contactDataGridViewTextBoxColumn1";
		this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_22.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_77.DataPropertyName = "idSchmObj";
		this.dataGridViewTextBoxColumn_77.HeaderText = "idSchmObj";
		this.dataGridViewTextBoxColumn_77.Name = "idSchmObjDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_77.ReadOnly = true;
		this.dataGridViewTextBoxColumn_77.Visible = false;
		this.dataGridViewTextBoxColumn_78.DataPropertyName = "cellId";
		this.dataGridViewTextBoxColumn_78.HeaderText = "cellId";
		this.dataGridViewTextBoxColumn_78.Name = "cellIdDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_78.ReadOnly = true;
		this.dataGridViewTextBoxColumn_78.Visible = false;
		this.dataGridViewTextBoxColumn_79.DataPropertyName = "busid";
		this.dataGridViewTextBoxColumn_79.HeaderText = "busid";
		this.dataGridViewTextBoxColumn_79.Name = "busidDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_79.ReadOnly = true;
		this.dataGridViewTextBoxColumn_79.Visible = false;
		this.dataGridViewTextBoxColumn_80.DataPropertyName = "subid";
		this.dataGridViewTextBoxColumn_80.HeaderText = "subid";
		this.dataGridViewTextBoxColumn_80.Name = "subidDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_80.ReadOnly = true;
		this.dataGridViewTextBoxColumn_80.Visible = false;
		this.dataGridViewTextBoxColumn_81.DataPropertyName = "schmObjName";
		this.dataGridViewTextBoxColumn_81.HeaderText = "schmObjName";
		this.dataGridViewTextBoxColumn_81.Name = "schmObjNameDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_81.ReadOnly = true;
		this.dataGridViewTextBoxColumn_81.Visible = false;
		this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "AbnNet";
		this.dataGridViewFilterTextBoxColumn_23.HeaderText = "Сетевая орг-ция";
		this.dataGridViewFilterTextBoxColumn_23.Name = "abnNetdgvColumn";
		this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_24.DataPropertyName = "abnServicing";
		this.dataGridViewFilterTextBoxColumn_24.HeaderText = "Обслуж-ая орг-ция";
		this.dataGridViewFilterTextBoxColumn_24.Name = "abnServicingdgvColumn";
		this.dataGridViewFilterTextBoxColumn_24.ReadOnly = true;
		this.dataGridViewTextBoxColumn_82.HeaderText = "isOnColumn";
		this.dataGridViewTextBoxColumn_82.Name = "isOnColumn";
		this.dataGridViewTextBoxColumn_82.ReadOnly = true;
		this.dataGridViewTextBoxColumn_82.Visible = false;
		this.dataGridViewFilterTextBoxColumn_25.DataPropertyName = "idAbn";
		this.dataGridViewFilterTextBoxColumn_25.HeaderText = "Признак";
		this.dataGridViewFilterTextBoxColumn_25.Name = "flagObjListLegalDgvColumn";
		this.dataGridViewFilterTextBoxColumn_25.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_26.DataPropertyName = "numTU";
		this.dataGridViewFilterTextBoxColumn_26.HeaderText = "№ ТУ";
		this.dataGridViewFilterTextBoxColumn_26.Name = "numTUDgvList";
		this.dataGridViewFilterTextBoxColumn_26.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_26.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_26.Visible = false;
		this.dataGridViewFilterTextBoxColumn_27.DataPropertyName = "dateTU";
		this.dataGridViewFilterTextBoxColumn_27.HeaderText = "Дата ТУ";
		this.dataGridViewFilterTextBoxColumn_27.Name = "dateTUDgvList";
		this.dataGridViewFilterTextBoxColumn_27.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_27.Visible = false;
		this.bindingSource_2.DataMember = "vL_SchmAbnFull";
		this.bindingSource_2.DataSource = this.class22_0;
		this.bindingSource_2.CurrentChanged += this.bindingSource_2_CurrentChanged;
		this.splitContainer_1.Dock = DockStyle.Fill;
		this.splitContainer_1.Location = new Point(0, 0);
		this.splitContainer_1.Name = "splitContainer1";
		this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_3);
		this.splitContainer_1.Panel2.Controls.Add(this.dataGridViewExcelFilter_4);
		this.splitContainer_1.Size = new Size(898, 287);
		this.splitContainer_1.SplitterDistance = 453;
		this.splitContainer_1.TabIndex = 0;
		this.dataGridViewExcelFilter_3.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_3.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_3.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_3.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_3.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_37,
			this.dataGridViewTextBoxColumn_38,
			this.dataGridViewTextBoxColumn_39,
			this.dataGridViewTextBoxColumn_40,
			this.epoRjLusWF,
			this.dataGridViewTextBoxColumn_41
		});
		this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
		this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_3.Location = new Point(0, 0);
		this.dataGridViewExcelFilter_3.Name = "dgvListPrv";
		this.dataGridViewExcelFilter_3.ReadOnly = true;
		this.dataGridViewExcelFilter_3.RowHeadersWidth = 21;
		this.dataGridViewExcelFilter_3.Size = new Size(453, 287);
		this.dataGridViewExcelFilter_3.TabIndex = 0;
		this.dataGridViewExcelFilter_3.Tag = "Физические лица";
		this.dataGridViewTextBoxColumn_37.DataPropertyName = "subname";
		this.dataGridViewTextBoxColumn_37.HeaderText = "ПС";
		this.dataGridViewTextBoxColumn_37.Name = "subnameDataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_37.ReadOnly = true;
		this.dataGridViewTextBoxColumn_38.DataPropertyName = "busname";
		this.dataGridViewTextBoxColumn_38.HeaderText = "Шина";
		this.dataGridViewTextBoxColumn_38.Name = "busnameDataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_38.ReadOnly = true;
		this.dataGridViewTextBoxColumn_39.DataPropertyName = "cellname";
		this.dataGridViewTextBoxColumn_39.HeaderText = "Ячейка";
		this.dataGridViewTextBoxColumn_39.Name = "cellnameDataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_39.ReadOnly = true;
		this.dataGridViewTextBoxColumn_40.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_40.DataPropertyName = "StreetName";
		this.dataGridViewTextBoxColumn_40.HeaderText = "Улица";
		this.dataGridViewTextBoxColumn_40.Name = "streetNameDataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_40.ReadOnly = true;
		this.epoRjLusWF.DataPropertyName = "house";
		this.epoRjLusWF.HeaderText = "Дом";
		this.epoRjLusWF.Name = "houseDataGridViewTextBoxColumn2";
		this.epoRjLusWF.ReadOnly = true;
		this.dataGridViewTextBoxColumn_41.DataPropertyName = "countAbn";
		this.dataGridViewTextBoxColumn_41.HeaderText = "Кол-во аб-ов";
		this.dataGridViewTextBoxColumn_41.Name = "countAbnDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_41.ReadOnly = true;
		this.dataGridViewTextBoxColumn_41.Width = 120;
		this.bindingSource_3.DataMember = "vL_SchmAbnFull";
		this.bindingSource_3.DataSource = this.dataSet_0;
		this.dataGridViewExcelFilter_4.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_4.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_4.AllowUserToResizeRows = false;
		this.dataGridViewExcelFilter_4.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_4.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_4.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_14,
			this.VbJjefZcrm,
			this.pLnjzbiuxH,
			this.dataGridViewTextBoxColumn_15,
			this.dataGridViewTextBoxColumn_16,
			this.dataGridViewTextBoxColumn_17,
			this.dataGridViewTextBoxColumn_18,
			this.dataGridViewTextBoxColumn_19,
			this.dataGridViewTextBoxColumn_20,
			this.dataGridViewTextBoxColumn_21
		});
		this.dataGridViewExcelFilter_4.DataSource = this.bindingSource_1;
		this.dataGridViewExcelFilter_4.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_4.Location = new Point(0, 0);
		this.dataGridViewExcelFilter_4.MultiSelect = false;
		this.dataGridViewExcelFilter_4.Name = "dgvListLegalContact";
		this.dataGridViewExcelFilter_4.ReadOnly = true;
		this.dataGridViewExcelFilter_4.RowHeadersWidth = 21;
		this.dataGridViewExcelFilter_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_4.Size = new Size(441, 287);
		this.dataGridViewExcelFilter_4.TabIndex = 4;
		this.dataGridViewTextBoxColumn_14.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_14.HeaderText = "id";
		this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_14.ReadOnly = true;
		this.dataGridViewTextBoxColumn_14.Visible = false;
		this.VbJjefZcrm.DataPropertyName = "idAbn";
		this.VbJjefZcrm.HeaderText = "idAbn";
		this.VbJjefZcrm.Name = "dataGridViewTextBoxColumn2";
		this.VbJjefZcrm.ReadOnly = true;
		this.VbJjefZcrm.Visible = false;
		this.pLnjzbiuxH.DataPropertyName = "Post";
		this.pLnjzbiuxH.HeaderText = "Должность";
		this.pLnjzbiuxH.Name = "dataGridViewTextBoxColumn3";
		this.pLnjzbiuxH.ReadOnly = true;
		this.dataGridViewTextBoxColumn_15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_15.DataPropertyName = "F";
		this.dataGridViewTextBoxColumn_15.HeaderText = "Фамилия";
		this.dataGridViewTextBoxColumn_15.MinimumWidth = 50;
		this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn4";
		this.dataGridViewTextBoxColumn_15.ReadOnly = true;
		this.dataGridViewTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_16.DataPropertyName = "I";
		this.dataGridViewTextBoxColumn_16.HeaderText = "Имя";
		this.dataGridViewTextBoxColumn_16.MinimumWidth = 50;
		this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn5";
		this.dataGridViewTextBoxColumn_16.ReadOnly = true;
		this.dataGridViewTextBoxColumn_17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_17.DataPropertyName = "O";
		this.dataGridViewTextBoxColumn_17.HeaderText = "Отчество";
		this.dataGridViewTextBoxColumn_17.MinimumWidth = 50;
		this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn6";
		this.dataGridViewTextBoxColumn_17.ReadOnly = true;
		this.dataGridViewTextBoxColumn_18.DataPropertyName = "Phone";
		this.dataGridViewTextBoxColumn_18.HeaderText = "Телефон";
		this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn7";
		this.dataGridViewTextBoxColumn_18.ReadOnly = true;
		this.dataGridViewTextBoxColumn_19.DataPropertyName = "DateChange";
		this.dataGridViewTextBoxColumn_19.HeaderText = "DateChange";
		this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn8";
		this.dataGridViewTextBoxColumn_19.ReadOnly = true;
		this.dataGridViewTextBoxColumn_19.Visible = false;
		this.dataGridViewTextBoxColumn_20.DataPropertyName = "Comment";
		this.dataGridViewTextBoxColumn_20.HeaderText = "Коментарий";
		this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn9";
		this.dataGridViewTextBoxColumn_20.ReadOnly = true;
		this.dataGridViewTextBoxColumn_20.Width = 120;
		this.dataGridViewTextBoxColumn_21.DataPropertyName = "email";
		this.dataGridViewTextBoxColumn_21.HeaderText = "e`mail";
		this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn10";
		this.dataGridViewTextBoxColumn_21.ReadOnly = true;
		this.tabPage_0.Controls.Add(this.splitContainer_2);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "tabPageOld";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(937, 601);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Старая база";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.splitContainer_2.Dock = DockStyle.Fill;
		this.splitContainer_2.FixedPanel = FixedPanel.Panel2;
		this.splitContainer_2.Location = new Point(3, 3);
		this.splitContainer_2.Name = "splitContainer2";
		this.splitContainer_2.Orientation = Orientation.Horizontal;
		this.splitContainer_2.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
		this.splitContainer_2.Panel1.Controls.Add(this.label_0);
		this.splitContainer_2.Panel1.Controls.Add(this.dataGridViewExcelFilter_1);
		this.splitContainer_2.Panel2.Controls.Add(this.label_1);
		this.splitContainer_2.Panel2.Controls.Add(this.dataGridView_0);
		this.splitContainer_2.Size = new Size(931, 595);
		this.splitContainer_2.SplitterDistance = 461;
		this.splitContainer_2.TabIndex = 8;
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(5, 11);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(36, 13);
		this.label_1.TabIndex = 7;
		this.label_1.Text = "Дома";
		this.tabPage_4.Controls.Add(this.label_8);
		this.tabPage_4.Controls.Add(this.dataGridViewExcelFilter_5);
		this.tabPage_4.Controls.Add(this.groupBox_1);
		this.tabPage_4.Controls.Add(this.groupBox_0);
		this.tabPage_4.Location = new Point(4, 22);
		this.tabPage_4.Name = "tabPageReport";
		this.tabPage_4.Padding = new Padding(3);
		this.tabPage_4.Size = new Size(937, 601);
		this.tabPage_4.TabIndex = 2;
		this.tabPage_4.Text = "Сводный отчет";
		this.tabPage_4.UseVisualStyleBackColor = true;
		this.label_8.AutoSize = true;
		this.label_8.Location = new Point(14, 395);
		this.label_8.Name = "label10";
		this.label_8.Size = new Size(163, 13);
		this.label_8.TabIndex = 3;
		this.label_8.Text = "Социально-значимые объекты";
		this.dataGridViewExcelFilter_5.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_5.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_5.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.dataGridViewExcelFilter_5.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_5.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_5.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewFilterTextBoxColumn_0,
			this.dataGridViewFilterTextBoxColumn_1,
			this.dataGridViewFilterTextBoxColumn_2,
			this.dataGridViewTextBoxColumn_46,
			this.dataGridViewFilterTextBoxColumn_3,
			this.dataGridViewFilterTextBoxColumn_4,
			this.dataGridViewTextBoxColumn_47,
			this.dataGridViewCheckBoxColumn_0,
			this.dataGridViewTextBoxColumn_48,
			this.dataGridViewFilterTextBoxColumn_5,
			this.dataGridViewTextBoxColumn_49,
			this.dataGridViewTextBoxColumn_50,
			this.dataGridViewTextBoxColumn_51,
			this.dataGridViewTextBoxColumn_52,
			this.dataGridViewFilterTextBoxColumn_6,
			this.dataGridViewFilterTextBoxColumn_7,
			this.dataGridViewFilterTextBoxColumn_8,
			this.dataGridViewFilterTextBoxColumn_9,
			this.dataGridViewFilterTextBoxColumn_10,
			this.dataGridViewTextBoxColumn_53,
			this.dataGridViewTextBoxColumn_54,
			this.dataGridViewTextBoxColumn_55,
			this.dataGridViewTextBoxColumn_56,
			this.dataGridViewTextBoxColumn_57,
			this.dataGridViewFilterTextBoxColumn_11,
			this.dataGridViewCheckBoxColumn_1
		});
		this.dataGridViewExcelFilter_5.DataSource = this.bindingSource_2;
		this.dataGridViewExcelFilter_5.Location = new Point(0, 411);
		this.dataGridViewExcelFilter_5.Name = "dgvSocial";
		this.dataGridViewExcelFilter_5.ReadOnly = true;
		this.dataGridViewExcelFilter_5.RowHeadersWidth = 21;
		this.dataGridViewExcelFilter_5.Size = new Size(937, 194);
		this.dataGridViewExcelFilter_5.TabIndex = 2;
		this.dataGridViewExcelFilter_5.Tag = "Юридические лица";
		this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "subname";
		this.dataGridViewFilterTextBoxColumn_0.HeaderText = "ПС";
		this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
		this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_0.Width = 65;
		this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "busname";
		this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Шина";
		this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
		this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_1.Width = 55;
		this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "CellName";
		this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Ячейка";
		this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
		this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_2.Width = 55;
		this.dataGridViewTextBoxColumn_46.DataPropertyName = "idAbn";
		this.dataGridViewTextBoxColumn_46.HeaderText = "idAbn";
		this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn13";
		this.dataGridViewTextBoxColumn_46.ReadOnly = true;
		this.dataGridViewTextBoxColumn_46.Visible = false;
		this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "codeAbonent";
		this.dataGridViewFilterTextBoxColumn_3.HeaderText = "№ договора";
		this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
		this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_3.Width = 70;
		this.dataGridViewFilterTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "nameAbn";
		this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Абонент";
		this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
		this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_47.DataPropertyName = "typeAbn";
		this.dataGridViewTextBoxColumn_47.HeaderText = "typeAbn";
		this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn14";
		this.dataGridViewTextBoxColumn_47.ReadOnly = true;
		this.dataGridViewTextBoxColumn_47.Visible = false;
		this.dataGridViewCheckBoxColumn_0.DataPropertyName = "aBnActive";
		this.dataGridViewCheckBoxColumn_0.HeaderText = "aBnActive";
		this.dataGridViewCheckBoxColumn_0.Name = "dataGridViewCheckBoxColumn1";
		this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_48.DataPropertyName = "idAbnObj";
		this.dataGridViewTextBoxColumn_48.HeaderText = "idAbnObj";
		this.dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn15";
		this.dataGridViewTextBoxColumn_48.ReadOnly = true;
		this.dataGridViewTextBoxColumn_48.Visible = false;
		this.dataGridViewFilterTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "nameObj";
		this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Объект";
		this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn6";
		this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_49.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_49.HeaderText = "id";
		this.dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn16";
		this.dataGridViewTextBoxColumn_49.ReadOnly = true;
		this.dataGridViewTextBoxColumn_49.Visible = false;
		this.dataGridViewTextBoxColumn_50.DataPropertyName = "streetname";
		this.dataGridViewTextBoxColumn_50.HeaderText = "streetname";
		this.dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn17";
		this.dataGridViewTextBoxColumn_50.ReadOnly = true;
		this.dataGridViewTextBoxColumn_50.Visible = false;
		this.dataGridViewTextBoxColumn_51.DataPropertyName = "house";
		this.dataGridViewTextBoxColumn_51.HeaderText = "house";
		this.dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn18";
		this.dataGridViewTextBoxColumn_51.ReadOnly = true;
		this.dataGridViewTextBoxColumn_51.Visible = false;
		this.dataGridViewTextBoxColumn_52.DataPropertyName = "objActive";
		this.dataGridViewTextBoxColumn_52.HeaderText = "objActive";
		this.dataGridViewTextBoxColumn_52.Name = "dataGridViewTextBoxColumn19";
		this.dataGridViewTextBoxColumn_52.ReadOnly = true;
		this.dataGridViewTextBoxColumn_52.Visible = false;
		this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "CategoryName";
		this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Кат";
		this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn7";
		this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_6.Width = 40;
		this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "TarifName";
		this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Тар";
		this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn8";
		this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_7.Width = 40;
		this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "PowerSet";
		this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Уст мощность";
		this.dataGridViewFilterTextBoxColumn_8.Name = "dataGridViewFilterTextBoxColumn9";
		this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "PowerFact";
		this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Факт мощность";
		this.dataGridViewFilterTextBoxColumn_9.Name = "dataGridViewFilterTextBoxColumn10";
		this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "contact";
		this.dataGridViewFilterTextBoxColumn_10.FillWeight = 70f;
		this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Телефоны";
		this.dataGridViewFilterTextBoxColumn_10.Name = "dataGridViewFilterTextBoxColumn11";
		this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_53.DataPropertyName = "idSchmObj";
		this.dataGridViewTextBoxColumn_53.HeaderText = "idSchmObj";
		this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn20";
		this.dataGridViewTextBoxColumn_53.ReadOnly = true;
		this.dataGridViewTextBoxColumn_53.Visible = false;
		this.dataGridViewTextBoxColumn_54.DataPropertyName = "cellId";
		this.dataGridViewTextBoxColumn_54.HeaderText = "cellId";
		this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn21";
		this.dataGridViewTextBoxColumn_54.ReadOnly = true;
		this.dataGridViewTextBoxColumn_54.Visible = false;
		this.dataGridViewTextBoxColumn_55.DataPropertyName = "busid";
		this.dataGridViewTextBoxColumn_55.HeaderText = "busid";
		this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn22";
		this.dataGridViewTextBoxColumn_55.ReadOnly = true;
		this.dataGridViewTextBoxColumn_55.Visible = false;
		this.dataGridViewTextBoxColumn_56.DataPropertyName = "subid";
		this.dataGridViewTextBoxColumn_56.HeaderText = "subid";
		this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn23";
		this.dataGridViewTextBoxColumn_56.ReadOnly = true;
		this.dataGridViewTextBoxColumn_56.Visible = false;
		this.dataGridViewTextBoxColumn_57.DataPropertyName = "schmObjName";
		this.dataGridViewTextBoxColumn_57.HeaderText = "schmObjName";
		this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn24";
		this.dataGridViewTextBoxColumn_57.ReadOnly = true;
		this.dataGridViewTextBoxColumn_57.Visible = false;
		this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "AbnNet";
		this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Сетевая орг-ция";
		this.dataGridViewFilterTextBoxColumn_11.Name = "dataGridViewFilterTextBoxColumn12";
		this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_1.DataPropertyName = "idAbn";
		this.dataGridViewCheckBoxColumn_1.HeaderText = "isOnColumn";
		this.dataGridViewCheckBoxColumn_1.Name = "dataGridViewCheckBoxColumn2";
		this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
		this.dataGridViewCheckBoxColumn_1.Visible = false;
		this.groupBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.groupBox_1.Controls.Add(this.dataGridView_2);
		this.groupBox_1.Controls.Add(this.textBox_4);
		this.groupBox_1.Controls.Add(this.label_6);
		this.groupBox_1.Controls.Add(this.textBox_2);
		this.groupBox_1.Controls.Add(this.label_4);
		this.groupBox_1.Controls.Add(this.textBox_3);
		this.groupBox_1.Controls.Add(this.label_5);
		this.groupBox_1.Location = new Point(8, 201);
		this.groupBox_1.Name = "groupBoxPrv";
		this.groupBox_1.Size = new Size(921, 184);
		this.groupBox_1.TabIndex = 1;
		this.groupBox_1.TabStop = false;
		this.groupBox_1.Text = "Физические лица";
		this.dataGridView_2.AllowUserToAddRows = false;
		this.dataGridView_2.AllowUserToDeleteRows = false;
		this.dataGridView_2.AllowUserToResizeColumns = false;
		this.dataGridView_2.AllowUserToResizeRows = false;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = SystemColors.Control;
		dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		this.dataGridView_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_2.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_44,
			this.dataGridViewTextBoxColumn_45
		});
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = SystemColors.Window;
		dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
		this.dataGridView_2.DefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridView_2.Location = new Point(9, 45);
		this.dataGridView_2.Name = "dgvCategoryPrv";
		this.dataGridView_2.ReadOnly = true;
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = SystemColors.Control;
		dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
		this.dataGridView_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.dataGridView_2.RowHeadersVisible = false;
		this.dataGridView_2.Size = new Size(240, 139);
		this.dataGridView_2.TabIndex = 8;
		this.dataGridViewTextBoxColumn_44.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_44.DataPropertyName = "CategoryName";
		this.dataGridViewTextBoxColumn_44.HeaderText = "Категория";
		this.dataGridViewTextBoxColumn_44.Name = "dataGridViewTextBoxColumn11";
		this.dataGridViewTextBoxColumn_44.ReadOnly = true;
		this.dataGridViewTextBoxColumn_45.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_45.DataPropertyName = "CountCategory";
		this.dataGridViewTextBoxColumn_45.HeaderText = "Кол-во";
		this.dataGridViewTextBoxColumn_45.Name = "dataGridViewTextBoxColumn12";
		this.dataGridViewTextBoxColumn_45.ReadOnly = true;
		this.textBox_4.BackColor = SystemColors.Window;
		this.textBox_4.Location = new Point(560, 19);
		this.textBox_4.Name = "txtCountPrvPeoples";
		this.textBox_4.ReadOnly = true;
		this.textBox_4.Size = new Size(100, 20);
		this.textBox_4.TabIndex = 7;
		this.label_6.AutoSize = true;
		this.label_6.Location = new Point(462, 22);
		this.label_6.Name = "label9";
		this.label_6.Size = new Size(89, 13);
		this.label_6.TabIndex = 6;
		this.label_6.Text = "Население (чел)";
		this.textBox_2.BackColor = SystemColors.Window;
		this.textBox_2.Location = new Point(330, 19);
		this.textBox_2.Name = "txtCountPrvAbnObj";
		this.textBox_2.ReadOnly = true;
		this.textBox_2.Size = new Size(100, 20);
		this.textBox_2.TabIndex = 3;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(232, 22);
		this.label_4.Name = "label6";
		this.label_4.Size = new Size(92, 13);
		this.label_4.TabIndex = 2;
		this.label_4.Text = "Кол-во объектов";
		this.textBox_3.BackColor = SystemColors.Window;
		this.textBox_3.Location = new Point(126, 19);
		this.textBox_3.Name = "txtCountPrvAbn";
		this.textBox_3.ReadOnly = true;
		this.textBox_3.Size = new Size(100, 20);
		this.textBox_3.TabIndex = 1;
		this.label_5.AutoSize = true;
		this.label_5.Location = new Point(6, 22);
		this.label_5.Name = "label7";
		this.label_5.Size = new Size(114, 13);
		this.label_5.TabIndex = 0;
		this.label_5.Text = "Кол-во потребителей";
		this.groupBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.groupBox_0.Controls.Add(this.dataGridView_1);
		this.groupBox_0.Controls.Add(this.textBox_5);
		this.groupBox_0.Controls.Add(this.label_7);
		this.groupBox_0.Controls.Add(this.textBox_0);
		this.groupBox_0.Controls.Add(this.label_2);
		this.groupBox_0.Controls.Add(this.textBox_1);
		this.groupBox_0.Controls.Add(this.label_3);
		this.groupBox_0.Location = new Point(8, 6);
		this.groupBox_0.Name = "groupBoxLegal";
		this.groupBox_0.Size = new Size(921, 189);
		this.groupBox_0.TabIndex = 0;
		this.groupBox_0.TabStop = false;
		this.groupBox_0.Text = "Юридические лица";
		this.dataGridView_1.AllowUserToAddRows = false;
		this.dataGridView_1.AllowUserToDeleteRows = false;
		this.dataGridView_1.AllowUserToResizeColumns = false;
		this.dataGridView_1.AllowUserToResizeRows = false;
		this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_42,
			this.dataGridViewTextBoxColumn_43
		});
		this.dataGridView_1.Location = new Point(9, 45);
		this.dataGridView_1.Name = "dgvCategoryLegal";
		this.dataGridView_1.ReadOnly = true;
		this.dataGridView_1.RowHeadersVisible = false;
		this.dataGridView_1.Size = new Size(240, 138);
		this.dataGridView_1.TabIndex = 6;
		this.dataGridViewTextBoxColumn_42.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_42.DataPropertyName = "CategoryName";
		this.dataGridViewTextBoxColumn_42.HeaderText = "Категория";
		this.dataGridViewTextBoxColumn_42.Name = "columnLegalCategoryName";
		this.dataGridViewTextBoxColumn_42.ReadOnly = true;
		this.dataGridViewTextBoxColumn_43.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_43.DataPropertyName = "CountCategory";
		this.dataGridViewTextBoxColumn_43.HeaderText = "Кол-во";
		this.dataGridViewTextBoxColumn_43.Name = "columnLegalCountCategory";
		this.dataGridViewTextBoxColumn_43.ReadOnly = true;
		this.textBox_5.BackColor = SystemColors.Window;
		this.textBox_5.Location = new Point(560, 19);
		this.textBox_5.Name = "txtCountLegalPeoples";
		this.textBox_5.ReadOnly = true;
		this.textBox_5.Size = new Size(100, 20);
		this.textBox_5.TabIndex = 5;
		this.label_7.AutoSize = true;
		this.label_7.Location = new Point(462, 22);
		this.label_7.Name = "label8";
		this.label_7.Size = new Size(89, 13);
		this.label_7.TabIndex = 4;
		this.label_7.Text = "Население (чел)";
		this.textBox_0.BackColor = SystemColors.Window;
		this.textBox_0.Location = new Point(330, 19);
		this.textBox_0.Name = "txtCountLegalAbnObj";
		this.textBox_0.ReadOnly = true;
		this.textBox_0.Size = new Size(100, 20);
		this.textBox_0.TabIndex = 3;
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(232, 22);
		this.label_2.Name = "label5";
		this.label_2.Size = new Size(92, 13);
		this.label_2.TabIndex = 2;
		this.label_2.Text = "Кол-во объектов";
		this.textBox_1.BackColor = SystemColors.Window;
		this.textBox_1.Location = new Point(126, 19);
		this.textBox_1.Name = "txtCountLegalAbn";
		this.textBox_1.ReadOnly = true;
		this.textBox_1.Size = new Size(100, 20);
		this.textBox_1.TabIndex = 1;
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(6, 22);
		this.label_3.Name = "label4";
		this.label_3.Size = new Size(114, 13);
		this.label_3.TabIndex = 0;
		this.label_3.Text = "Кол-во потребителей";
		this.panel_0.BackColor = SystemColors.Control;
		this.panel_0.Controls.Add(this.mmGjoKudhc);
		this.panel_0.Controls.Add(this.juXjixQvHf);
		this.panel_0.Location = new Point(280, 12);
		this.panel_0.Name = "panelProgress";
		this.panel_0.Size = new Size(431, 74);
		this.panel_0.TabIndex = 6;
		this.panel_0.Visible = false;
		this.mmGjoKudhc.AutoSize = true;
		this.mmGjoKudhc.Location = new Point(125, 11);
		this.mmGjoKudhc.Name = "label3";
		this.mmGjoKudhc.Size = new Size(194, 13);
		this.mmGjoKudhc.TabIndex = 6;
		this.mmGjoKudhc.Text = "Подождите... Идет загрузка из базы";
		this.juXjixQvHf.AutoProgressSpeed = 130;
		this.juXjixQvHf.Dock = DockStyle.Bottom;
		this.juXjixQvHf.Location = new Point(0, 39);
		this.juXjixQvHf.Name = "progressBarEndLess";
		this.juXjixQvHf.NormalImage = (Image)componentResourceManager.GetObject("progressBarEndLess.NormalImage");
		this.juXjixQvHf.PointImage = (Image)componentResourceManager.GetObject("progressBarEndLess.PointImage");
		this.juXjixQvHf.Position = 0;
		this.juXjixQvHf.ProgressStyle = 1;
		this.juXjixQvHf.ProgressType = 1;
		this.juXjixQvHf.Size = new Size(431, 35);
		this.juXjixQvHf.TabIndex = 5;
		this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
		this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
		this.treeGridColumn_1.DefaultNodeImage = null;
		this.treeGridColumn_1.HeaderText = "Подстанция\\шина";
		this.treeGridColumn_1.Name = "Column16";
		this.treeGridColumn_1.Resizable = DataGridViewTriState.True;
		this.treeGridColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_83.HeaderText = "Ячейка";
		this.dataGridViewTextBoxColumn_83.Name = "Column17";
		this.dataGridViewTextBoxColumn_83.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_83.Width = 50;
		this.dataGridViewTextBoxColumn_84.HeaderText = "Код";
		this.dataGridViewTextBoxColumn_84.Name = "codeAbnTreePrvdgvColumn";
		this.dataGridViewTextBoxColumn_84.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_84.Width = 80;
		this.dataGridViewTextBoxColumn_85.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_85.HeaderText = "Абонент";
		this.dataGridViewTextBoxColumn_85.Name = "Column19";
		this.dataGridViewTextBoxColumn_85.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_86.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_86.HeaderText = "Улица";
		this.dataGridViewTextBoxColumn_86.Name = "Column20";
		this.dataGridViewTextBoxColumn_86.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_87.HeaderText = "Дом";
		this.dataGridViewTextBoxColumn_87.Name = "Column21";
		this.dataGridViewTextBoxColumn_87.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_88.HeaderText = "Квартира";
		this.dataGridViewTextBoxColumn_88.Name = "Column22";
		this.dataGridViewTextBoxColumn_88.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_89.HeaderText = "Телефоны";
		this.dataGridViewTextBoxColumn_89.Name = "Column1";
		this.dataGridViewTextBoxColumn_89.SortMode = DataGridViewColumnSortMode.NotSortable;
		this.dataGridViewTextBoxColumn_89.Width = 150;
		this.dataGridViewCheckBoxColumn_4.HeaderText = "isOn";
		this.dataGridViewCheckBoxColumn_4.Name = "isOnTreePrvDgvColumn";
		this.dataGridViewCheckBoxColumn_4.Visible = false;
		this.dataGridViewTextBoxColumn_90.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_90.DefaultCellStyle = dataGridViewCellStyle5;
		this.dataGridViewTextBoxColumn_90.HeaderText = "Признак";
		this.dataGridViewTextBoxColumn_90.Name = "flagObjTreePrvDgvColumn";
		this.dataGridViewTextBoxColumn_90.SortMode = DataGridViewColumnSortMode.NotSortable;
		base.AcceptButton = this.button_0;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(945, 696);
		base.Controls.Add(this.panel_0);
		base.Controls.Add(this.tabControl_0);
		base.Controls.Add(this.QqHjskOslg);
		base.Controls.Add(this.button_0);
		this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.MinimumSize = new Size(774, 424);
		base.Name = "FormAbnFromOldSchema";
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Абоненты ";
		base.DockStateChanged += this.Class80_DockStateChanged;
		base.FormClosing += this.Class80_FormClosing;
		base.Load += this.Class80_Load;
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.class22_0).EndInit();
		((ISupportInitialize)this.bindingSource_1).EndInit();
		this.dataGridViewExcelFilter_0.EndInit();
		this.dataGridViewExcelFilter_1.EndInit();
		this.QqHjskOslg.ResumeLayout(false);
		this.QqHjskOslg.PerformLayout();
		((ISupportInitialize)this.dataSet_0).EndInit();
		((ISupportInitialize)this.dataTable_1).EndInit();
		((ISupportInitialize)this.dataTable_2).EndInit();
		((ISupportInitialize)this.dataGridView_0).EndInit();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_1.ResumeLayout(false);
		this.tabControlVertical_0.ResumeLayout(false);
		this.tabPage_3.ResumeLayout(false);
		this.splitContainer_3.Panel1.ResumeLayout(false);
		this.splitContainer_3.Panel2.ResumeLayout(false);
		this.splitContainer_3.ResumeLayout(false);
		this.treeDataGridView_0.EndInit();
		this.treeDataGridView_1.EndInit();
		this.tabPage_2.ResumeLayout(false);
		this.splitContainer_0.Panel1.ResumeLayout(false);
		this.splitContainer_0.Panel2.ResumeLayout(false);
		this.splitContainer_0.ResumeLayout(false);
		this.dataGridViewExcelFilter_2.EndInit();
		((ISupportInitialize)this.bindingSource_2).EndInit();
		this.splitContainer_1.Panel1.ResumeLayout(false);
		this.splitContainer_1.Panel2.ResumeLayout(false);
		this.splitContainer_1.ResumeLayout(false);
		this.dataGridViewExcelFilter_3.EndInit();
		((ISupportInitialize)this.bindingSource_3).EndInit();
		this.dataGridViewExcelFilter_4.EndInit();
		this.tabPage_0.ResumeLayout(false);
		this.splitContainer_2.Panel1.ResumeLayout(false);
		this.splitContainer_2.Panel1.PerformLayout();
		this.splitContainer_2.Panel2.ResumeLayout(false);
		this.splitContainer_2.Panel2.PerformLayout();
		this.splitContainer_2.ResumeLayout(false);
		this.tabPage_4.ResumeLayout(false);
		this.tabPage_4.PerformLayout();
		this.dataGridViewExcelFilter_5.EndInit();
		this.groupBox_1.ResumeLayout(false);
		this.groupBox_1.PerformLayout();
		((ISupportInitialize)this.dataGridView_2).EndInit();
		this.groupBox_0.ResumeLayout(false);
		this.groupBox_0.PerformLayout();
		((ISupportInitialize)this.dataGridView_1).EndInit();
		this.panel_0.ResumeLayout(false);
		this.panel_0.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private bool method_16(ElectricObject electricObject_0)
	{
		return electricObject_0.Id == this.int_0;
	}

	internal static void z4TdGPpL18XAo1Orn9WQ(Form form_0, bool bool_2)
	{
		form_0.Dispose(bool_2);
	}

	private List<RectangleTool> list_0;

	private int int_0;

	private bool bool_0;

	private eSimulationMode eSimulationMode_0;

	private CheckBox checkBox_0;

	private ComboBox comboBox_0;

	private bool bool_1;

	private Class22.Class46 class46_0;

	private DataTable dataTable_0;

	private IContainer icontainer_0;

	private Button button_0;

	private BindingSource bindingSource_0;

	private Class22 class22_0;

	private BindingSource bindingSource_1;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private DataGridViewExcelFilter dataGridViewExcelFilter_1;

	private Label label_0;

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

	private ToolStrip QqHjskOslg;

	private ToolStripButton toolStripButton_0;

	private DataSet dataSet_0;

	private DataTable dataTable_1;

	private DataColumn dataColumn_0;

	private DataColumn dataColumn_1;

	private DataColumn dataColumn_2;

	private DataColumn dataColumn_3;

	private DataGridView dataGridView_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private Label label_1;

	private TabPage tabPage_1;

	private DataGridViewExcelFilter dataGridViewExcelFilter_2;

	private BindingSource bindingSource_2;

	private BackgroundWorker backgroundWorker_0;

	private TreeDataGridView treeDataGridView_0;

	private TabControlVertical tabControlVertical_0;

	private TabPage tabPage_2;

	private TabPage tabPage_3;

	private Panel panel_0;

	private Label mmGjoKudhc;

	private ProgressBarEndLess juXjixQvHf;

	private SplitContainer splitContainer_0;

	private SplitContainer splitContainer_1;

	private DataGridViewExcelFilter dataGridViewExcelFilter_3;

	private BindingSource bindingSource_3;

	private DataGridViewExcelFilter dataGridViewExcelFilter_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

	private DataGridViewTextBoxColumn VbJjefZcrm;

	private DataGridViewTextBoxColumn pLnjzbiuxH;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

	private SplitContainer splitContainer_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

	private SplitContainer splitContainer_3;

	private TreeDataGridView treeDataGridView_1;

	private DataTable dataTable_2;

	private DataColumn dataColumn_4;

	private DataColumn dataColumn_5;

	private DataColumn dataColumn_6;

	private DataColumn dataColumn_7;

	private DataColumn dataColumn_8;

	private DataColumn dataColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

	private DataGridViewTextBoxColumn epoRjLusWF;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

	private ToolStripButton toolStripButton_1;

	private ToolStripSeparator toolStripSeparator_0;

	private ToolStripLabel toolStripLabel_0;

	private TabPage tabPage_4;

	private GroupBox groupBox_0;

	private TextBox textBox_0;

	private Label label_2;

	private TextBox textBox_1;

	private Label label_3;

	private GroupBox groupBox_1;

	private TextBox textBox_2;

	private Label label_4;

	private TextBox textBox_3;

	private Label label_5;

	private TextBox textBox_4;

	private Label label_6;

	private TextBox textBox_5;

	private Label label_7;

	private DataGridView dataGridView_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

	private DataGridView dataGridView_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

	private Label label_8;

	private DataGridViewExcelFilter dataGridViewExcelFilter_5;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

	private TreeGridColumn treeGridColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

	private DataGridViewTextBoxColumn IjtOxmvGoe;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_20;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_21;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_23;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_25;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_26;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_27;

	private TreeGridColumn treeGridColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;

	private delegate int Delegate33();

	private delegate object Delegate34();
}
