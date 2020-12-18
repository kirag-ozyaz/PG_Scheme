using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Microsoft.Reporting.WinForms;
using Scheme.Properties;
using SchemeModel;
using SchemeModel.Calculations;

namespace Scheme.Forms.Reports
{
	public class FormMeasuringReport : FormBase
	{
		public FormMeasuringReport()
		{
			Class63.AGd1PxHzk5wxP();
			this.string_0 = "Scheme.FileReports.ReportMeasurement.rdlc";
			this.dataTable_0 = new DataTable();
			this.dataTable_1 = new DataTable();
			this.dataTable_2 = new DataTable();
			this.int_0 = 2014;
			base..ctor();
			this.method_1();
			for (int i = DateTime.Now.Year + 2; i >= 2000; i--)
			{
				this.toolStripComboBox_0.Items.Add(i);
			}
			this.toolStripComboBox_0.SelectedItem = DateTime.Now.Year;
			this.toolStripComboBox_0.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
		}

		private void FormMeasuringReport_Load(object sender, EventArgs e)
		{
			this.HvfDivLaqP();
		}

		private void HvfDivLaqP()
		{
			this.panel_0.Visible = true;
			this.progressBarEndLess_0.AutoProgress = true;
			this.panel_0.Left = base.Width / 2 - this.panel_0.Width / 2;
			this.panel_0.Top = base.Height / 2 - this.panel_0.Height / 2;
			this.panel_1.Enabled = false;
			this.panel_1.Visible = false;
			this.panel_2.Enabled = false;
			this.dataGridViewExcelFilter_1.DataSource = null;
			this.dataGridViewExcelFilter_0.DataSource = null;
			if (this.toolStripComboBox_0.SelectedItem != null)
			{
				this.int_0 = Convert.ToInt32(this.toolStripComboBox_0.SelectedItem);
			}
			this.backgroundWorker_0.RunWorkerAsync();
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			this.method_0();
		}

		private void method_0()
		{
			ElectricModel electricModel = new ElectricModel();
			electricModel.SqlSettings = this.SqlSettings;
			electricModel.LoadSchema(false);
			List<ElectricObject> list = new List<ElectricObject>();
			list.AddRange(from o in electricModel.Objects
			where o is ElectricBus && o.Parent != null && o.Parent is ElectricSubstation && ((ElectricSubstation)o.Parent).TypeSubstation == eTypeRectangleTool.CP
			select o);
			Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
			Dictionary<int, int[]> dictionary2 = dictionary;
			int key = 10;
			int[] array = new int[2];
			array[0] = 60;
			dictionary2.Add(key, array);
			dictionary.Add(16, new int[]
			{
				80,
				75
			});
			dictionary.Add(25, new int[]
			{
				105,
				90
			});
			dictionary.Add(35, new int[]
			{
				125,
				115
			});
			dictionary.Add(50, new int[]
			{
				155,
				140
			});
			dictionary.Add(70, new int[]
			{
				190,
				165
			});
			dictionary.Add(95, new int[]
			{
				225,
				205
			});
			dictionary.Add(120, new int[]
			{
				260,
				240
			});
			dictionary.Add(150, new int[]
			{
				300,
				275
			});
			dictionary.Add(185, new int[]
			{
				340,
				310
			});
			dictionary.Add(240, new int[]
			{
				390,
				355
			});
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
				{
					"Select mat1.[IdBus],mat1.[idObjList],mat1.Ia,mat1.Ib,mat1.Ic, maxI.I, m1.DateD, disp.fio as disp, m1.TemperatureD\r\n                                                                                                from [tJ_MeasAmperageTransf] as mat1 inner join\r\n\t                                                                                                (SELECT mat.[IdBus],mat.[idObjList],m.[TypeDoc],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) then max([Ia]) else case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) then max([Ic]) end end end) as I, max([Ia]) as a, max([Ib]) as b, max([Ic]) as c\r\n\t                                                                                                FROM [tJ_MeasAmperageTransf] as mat\r\n\t                                                                                                inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n\t                                                                                                where  mat.deleted = 0 and m.[TypeDoc] = 1192 and  ((year(m.[DateD]) = ",
					this.int_0,
					" and month(m.[DateD]) between 1 and 11)or(year(m.[DateD]) = ",
					this.int_0,
					"-1 and month(m.[DateD])=12) ) and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n\t                                                                                                group by mat.[IdBus], mat.[idObjList], m.[TypeDoc]) as maxI \r\n                                                                                                on mat1.[IdBus]=maxI.[IdBus] and mat1.[idObjList]=maxI.[idObjList] and mat1.Ia = maxI.a and mat1.Ib= maxI.b and mat1.Ic = maxI.c \r\n                                                                                                inner join [tJ_Measurement] as m1 on mat1.[idMeasurement] = m1.id and m1.[TypeDoc]=1192\r\n                                                                                                left join vR_Worker disp on m1.idWorkerCheck = disp.id\r\n                                                                                                where mat1.deleted = 0 and ((year(m1.[DateD]) = ",
					this.int_0,
					" and month(m1.[DateD]) between 1 and 11)or(year(m1.[DateD]) = ",
					this.int_0,
					"-1 and month(m1.[DateD])=12) ) and  mat1.[Ia] is not null and  mat1.[Ib] is not null and  mat1.[Ic] is not null and mat1.idbus is not null"
				}));
				sqlCommand.Connection = sqlConnection;
				sqlConnection.Open();
				SqlDataReader reader = sqlCommand.ExecuteReader();
				this.dataTable_2.Clear();
				this.dataTable_2.Load(reader);
				sqlCommand.CommandText = "SELECT tSchm_ObjList.id, tSchm_ObjList.name, p.[Power]\r\n                                                                                                    FROM tSchm_ObjList\r\n                                                                                                    inner join tR_Classifier on tSchm_ObjList.[TypeCodeId]=tR_Classifier.id and tR_Classifier.[ParentKey] like ';SCM;INLINE_OBJ;SWITCH;' and tR_Classifier.Value = 11\r\n                                                                                                    outer apply dbo.fn_J_MeasTransfPassport(tSchm_ObjList.[Id]) p\r\n                                                                                                    where tSchm_ObjList.Deleted=0";
				reader = sqlCommand.ExecuteReader();
				this.dataTable_0.Clear();
				this.dataTable_0.Load(reader);
				sqlCommand.CommandText = "select tSchm_ObjList.id, tSchm_ObjList.name, minsect.CrossSection\r\n                                            from tSchm_ObjList \r\n                                            inner join (SELECT [idObjList],min([CrossSection])as CrossSection\r\n                                              FROM [tP_CabSection]  \r\n                                              where deleted=0 and [Length]>10\r\n                                              group by idobjlist)as minsect on tSchm_ObjList.id=minsect.idObjList \r\n                                            inner join tP_Passport pas on pas.idObjlist = tSchm_ObjList.id";
				reader = sqlCommand.ExecuteReader();
				this.dataTable_1.Clear();
				this.dataTable_1.Load(reader);
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			this.class19_0.MeasurementReport1.Clear();
			this.class19_0.MeasurementReport2.Clear();
			foreach (ElectricObject electricObject in list)
			{
				TreeNodeObj treeNodeObj = electricModel.PoweringReportForDrawObject(electricObject, true);
				if (treeNodeObj.Nodes.Count<TreeNodeObj>() != 0)
				{
					Dictionary<ElectricLine, List<ElectricObject>> dictionary3 = new Dictionary<ElectricLine, List<ElectricObject>>();
					if (electricObject.GetType() == typeof(ElectricBus))
					{
						using (IEnumerator<ElectricObject> enumerator2 = (from s in electricObject.ChildObjects
						where s.GetType() == typeof(ElectricPoint)
						select s).GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								ElectricObject electricObject2 = enumerator2.Current;
								ElectricPoint electricPoint = (ElectricPoint)electricObject2;
								if (electricPoint.Relations.Count == 1 && electricPoint.Relations[0].Parent.GetType() == typeof(ElectricLine) && ((ElectricLine)electricPoint.Relations[0].Parent).IsCell())
								{
									dictionary3.Add((ElectricLine)electricPoint.Relations[0].Parent, new List<ElectricObject>());
								}
							}
							goto IL_428;
						}
						goto IL_3F3;
					}
					goto IL_3F3;
					IL_428:
					Dictionary<ElectricBus, object[,]> dictionary4 = new Dictionary<ElectricBus, object[,]>();
					Dictionary<ElectricRelation, int> relationsMeasurement = new Dictionary<ElectricRelation, int>();
					foreach (TreeNodeObj treeNodeObj2 in treeNodeObj.LeafsList)
					{
						ElectricObject electricObject3 = null;
						List<ElectricObject> list2 = new List<ElectricObject>();
						bool flag = false;
						int num = 0;
						while (treeNodeObj2.Parent != null)
						{
							if (treeNodeObj2.Tag == null)
							{
								MessageBox.Show("В элементе дерева нет объекта схемы");
								return;
							}
							if (treeNodeObj2.Tag.GetType() == typeof(ElectricBus) && (((ElectricBus)treeNodeObj2.Tag).TypeBus == eTypeShinaTool.Shina_6 || ((ElectricBus)treeNodeObj2.Tag).TypeBus == eTypeShinaTool.Shina_10))
							{
								ElectricBus electricBus = (ElectricBus)treeNodeObj2.Tag;
								if (!dictionary4.ContainsKey(electricBus))
								{
									DataRow[] array2 = this.dataTable_2.Select("IdBus = " + electricBus.Id.ToString());
									if (array2.Length != 0)
									{
										object[,] array3 = new object[array2.Length, 8];
										for (int i = 0; i < array2.Length; i++)
										{
											array3[i, 0] = array2[i][1];
											array3[i, 1] = array2[i][5];
											array3[i, 2] = array2[i][2];
											array3[i, 3] = array2[i][3];
											array3[i, 4] = array2[i][4];
											array3[i, 5] = array2[i][6];
											array3[i, 6] = array2[i][7];
											array3[i, 7] = array2[i][8];
											num += (int)array3[i, 1];
										}
										dictionary4.Add(electricBus, array3);
									}
									else
									{
										dictionary4.Add(electricBus, new object[1, 1]);
									}
								}
								flag = true;
								if (!list2.Contains(electricBus))
								{
									list2.Add(electricBus);
								}
							}
							else if (treeNodeObj2.Tag.GetType() == typeof(ElectricLine))
							{
								if (electricObject3 == null)
								{
									electricObject3 = (ElectricObject)treeNodeObj2.Tag;
									treeNodeObj2 = treeNodeObj2.Parent;
									continue;
								}
								ElectricLine electricLine = (ElectricLine)treeNodeObj2.Tag;
								List<ElectricRelation> list3 = new List<ElectricRelation>();
								ElectricPoint linkPoint = ElectricObject.GetLinkPoint(electricLine, electricObject3);
								ElectricObject dob = (ElectricObject)treeNodeObj2.Parent.Tag;
								ElectricPoint linkPoint2 = ElectricObject.GetLinkPoint(electricLine, dob);
								electricLine.getRelationWay(linkPoint, linkPoint2, null, list3);
								foreach (ElectricRelation key2 in list3)
								{
									if (relationsMeasurement.ContainsKey(key2))
									{
										relationsMeasurement[key2] += num;
									}
									else
									{
										relationsMeasurement[key2] = num;
									}
								}
								if (!list2.Contains(electricLine) && flag)
								{
									list2.Add(electricLine);
								}
							}
							electricObject3 = (ElectricObject)treeNodeObj2.Tag;
							treeNodeObj2 = treeNodeObj2.Parent;
							if (treeNodeObj2.Tag.GetType() == typeof(ElectricLine) && ((ElectricLine)treeNodeObj2.Tag).IsCell() && dictionary3.ContainsKey((ElectricLine)treeNodeObj2.Tag))
							{
								foreach (ElectricObject item in list2)
								{
									if (!dictionary3[(ElectricLine)treeNodeObj2.Tag].Contains(item))
									{
										dictionary3[(ElectricLine)treeNodeObj2.Tag].Add(item);
									}
								}
							}
						}
					}
					Func<ElectricObject, bool> <>9__2;
					foreach (ElectricLine electricLine2 in dictionary3.Keys)
					{
						int num2 = 0;
						foreach (ElectricObject electricObject4 in dictionary3[electricLine2])
						{
							if (electricObject4.GetType() == typeof(ElectricBus))
							{
								ElectricBus key3 = (ElectricBus)electricObject4;
								object[,] array4 = dictionary4[key3];
								if (array4.Length != 1)
								{
									for (int j = 0; j < array4.Length / 6; j++)
									{
										num2 += (int)array4[j, 1];
									}
								}
							}
						}
						foreach (ElectricObject electricObject5 in dictionary3[electricLine2])
						{
							if (electricObject5.GetType() == typeof(ElectricBus))
							{
								ElectricBus electricBus2 = (ElectricBus)electricObject5;
								object[,] array5 = dictionary4[electricBus2];
								if (array5.Length == 1)
								{
									DataRow dataRow = this.class19_0.MeasurementReport1.NewRow();
									dataRow["roottp"] = electricLine2.Parent.ToString();
									dataRow["cell"] = electricLine2.ToString();
									dataRow["tp"] = electricBus2.Parent.ToString();
									dataRow["I"] = num2.ToString();
									dataRow["Comment"] = ((((ElectricSubstation)electricBus2.Parent).Tag == null || !Convert.ToBoolean(((ElectricSubstation)electricBus2.Parent).Tag)) ? string.Empty : "Абонентская");
									this.class19_0.MeasurementReport1.Rows.Add(dataRow);
								}
								else
								{
									for (int k = 0; k < array5.Length / 6; k++)
									{
										DataRow dataRow2 = this.class19_0.MeasurementReport1.NewRow();
										dataRow2["roottp"] = electricLine2.Parent.ToString();
										dataRow2["cell"] = electricLine2.ToString();
										dataRow2["tp"] = electricBus2.Parent.ToString();
										DataRow[] array6 = this.dataTable_0.Select("id = " + ((int)array5[k, 0]).ToString());
										if (array6.Length != 0)
										{
											dataRow2["trans"] = array6[0][1];
											dataRow2["PkVA"] = array6[0][2];
										}
										else
										{
											dataRow2["trans"] = ((int)array5[k, 0]).ToString();
										}
										dataRow2["I"] = num2.ToString();
										dataRow2["A"] = array5[k, 2].ToString();
										dataRow2["B"] = array5[k, 3].ToString();
										dataRow2["C"] = array5[k, 4].ToString();
										dataRow2["Date"] = ((DateTime)array5[k, 5]).ToString("dd.MM.yy");
										dataRow2["Time"] = ((DateTime)array5[k, 5]).ToString("HH:mm");
										dataRow2["Disp"] = array5[k, 6].ToString();
										dataRow2["TemperatureD"] = array5[k, 7].ToString();
										this.class19_0.MeasurementReport1.Rows.Add(dataRow2);
									}
								}
							}
							else if (electricObject5.GetType() == typeof(ElectricLine))
							{
								ElectricLine electricLine3 = (ElectricLine)electricObject5;
								int num3 = 0;
								int num4 = 0;
								IEnumerable<ElectricObject> childObjects = electricLine3.ChildObjects;
								Func<ElectricObject, bool> predicate;
								if ((predicate = <>9__2) == null)
								{
									predicate = (<>9__2 = ((ElectricObject c) => c is ElectricRelation && relationsMeasurement.ContainsKey((ElectricRelation)c)));
								}
								foreach (ElectricObject electricObject6 in childObjects.Where(predicate))
								{
									ElectricRelation electricRelation = (ElectricRelation)electricObject6;
									if (relationsMeasurement[electricRelation] > num3)
									{
										num3 = relationsMeasurement[electricRelation];
									}
									num4 = (int)((ElectricBus)electricLine3.Amperages[electricRelation.amperagePoint].Source).TypeBus;
								}
								DataRow dataRow3 = this.class19_0.MeasurementReport2.NewRow();
								dataRow3["roottp"] = electricLine2.Parent.ToString();
								dataRow3["cell"] = electricLine2.ToString();
								dataRow3["KLVL"] = electricLine3.ToString();
								DataRow[] array7 = this.dataTable_1.Select("id = " + electricLine3.Id.ToString());
								if (array7.Length != 0)
								{
									int key4 = Convert.ToInt32(array7[0][2]);
									dataRow3["section"] = key4.ToString();
									if (dictionary.ContainsKey(key4))
									{
										int value = 0;
										if (num4 == 541)
										{
											value = dictionary[key4][0];
										}
										else if (num4 == 564)
										{
											value = dictionary[key4][1];
										}
										dataRow3["pload"] = value.ToString();
										dataRow3["loading"] = Math.Round((double)(Convert.ToSingle(num3) / Convert.ToSingle(value) * 100f)).ToString();
									}
								}
								dataRow3["measurement"] = num3;
								this.class19_0.MeasurementReport2.Rows.Add(dataRow3);
							}
						}
					}
					continue;
					IL_3F3:
					if (electricObject.GetType() == typeof(ElectricLine) && ((ElectricLine)electricObject).IsCell())
					{
						dictionary3.Add((ElectricLine)electricObject, new List<ElectricObject>());
						goto IL_428;
					}
					goto IL_428;
				}
			}
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			ReportDataSource reportDataSource = new ReportDataSource();
			reportDataSource.Name = "TPMeasurement";
			reportDataSource.Value = this.class19_0.MeasurementReport1;
			this.reportViewer_0.LocalReport.DataSources.Add(reportDataSource);
			ReportDataSource reportDataSource2 = new ReportDataSource();
			reportDataSource2.Name = "CabMeasurement";
			reportDataSource2.Value = this.class19_0.MeasurementReport2;
			this.reportViewer_0.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = this.string_0;
			this.reportViewer_0.RefreshReport();
			this.panel_0.Visible = false;
			this.progressBarEndLess_0.AutoProgress = false;
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.panel_1.Enabled = true;
			this.panel_1.Visible = true;
		}

		private void FormMeasuringReport_Resize(object sender, EventArgs e)
		{
			this.panel_0.Left = base.Width / 2 - this.progressBarEndLess_0.Width / 2;
			this.panel_0.Top = base.Height / 2 - this.progressBarEndLess_0.Height / 2;
		}

		private void toolStripButton_0_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				this.toolStripButton_1.Checked = !this.toolStripButton_0.Checked;
				this.bool_0 = false;
			}
			this.panel_1.Enabled = (this.panel_1.Visible = this.toolStripButton_0.Checked);
		}

		private void toolStripButton_1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				this.toolStripButton_0.Checked = !this.toolStripButton_1.Checked;
				this.bool_0 = false;
			}
			this.panel_2.Enabled = (this.panel_2.Visible = this.toolStripButton_1.Checked);
		}

		private void toolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.HvfDivLaqP();
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			if (this.toolStripMenuItem_0.Tag != null && this.toolStripMenuItem_0.Tag.GetType() == typeof(DataGridViewExcelFilter))
			{
				((DataGridViewExcelFilter)this.toolStripMenuItem_0.Tag).CopyToExcel(true);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormMeasuringReport.mqdstyKsuJ1hev8ii8g(this, disposing);
		}

		private void method_1()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormMeasuringReport));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.reportViewer_0 = new ReportViewer();
			this.panel_0 = new Panel();
			this.label_0 = new Label();
			this.progressBarEndLess_0 = new ProgressBarEndLess();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.panel_1 = new Panel();
			this.splitContainer_0 = new SplitContainer();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.class19_0 = new Class19();
			this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.panel_2 = new Panel();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripLabel_0 = new ToolStripLabel();
			this.toolStripComboBox_0 = new ToolStripComboBox();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.FldPwnhOrm = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.FxjPobYexM = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.panel_0.SuspendLayout();
			this.panel_1.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.dataGridViewExcelFilter_0.BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.class19_0).BeginInit();
			this.dataGridViewExcelFilter_1.BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.contextMenuStrip_0.SuspendLayout();
			this.panel_2.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.reportViewer_0.Dock = DockStyle.Fill;
			this.reportViewer_0.Location = new Point(0, 0);
			this.reportViewer_0.Name = "reportViewer1";
			this.reportViewer_0.Size = new Size(1169, 475);
			this.reportViewer_0.TabIndex = 0;
			this.panel_0.BackColor = SystemColors.Control;
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Controls.Add(this.progressBarEndLess_0);
			this.panel_0.Location = new Point(54, 139);
			this.panel_0.Name = "panelProgress";
			this.panel_0.Size = new Size(431, 74);
			this.panel_0.TabIndex = 8;
			this.panel_0.Visible = false;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(111, 12);
			this.label_0.Name = "label3";
			this.label_0.Size = new Size(194, 13);
			this.label_0.TabIndex = 6;
			this.label_0.Text = "Подождите... Идет загрузка из базы";
			this.progressBarEndLess_0.AutoProgressSpeed = 130;
			this.progressBarEndLess_0.Dock = DockStyle.Bottom;
			this.progressBarEndLess_0.Location = new Point(0, 39);
			this.progressBarEndLess_0.Name = "progressBarEndLess";
			this.progressBarEndLess_0.NormalImage = (Image)componentResourceManager.GetObject("progressBarEndLess.NormalImage");
			this.progressBarEndLess_0.PointImage = (Image)componentResourceManager.GetObject("progressBarEndLess.PointImage");
			this.progressBarEndLess_0.Position = 0;
			this.progressBarEndLess_0.ProgressStyle = 1;
			this.progressBarEndLess_0.ProgressType = 1;
			this.progressBarEndLess_0.Size = new Size(431, 35);
			this.progressBarEndLess_0.TabIndex = 5;
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.panel_1.Controls.Add(this.splitContainer_0);
			this.panel_1.Dock = DockStyle.Fill;
			this.panel_1.Location = new Point(0, 25);
			this.panel_1.Name = "panelDataGrid";
			this.panel_1.Size = new Size(1169, 475);
			this.panel_1.TabIndex = 9;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(0, 0);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Orientation = Orientation.Horizontal;
			this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
			this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_1);
			this.splitContainer_0.Size = new Size(1169, 475);
			this.splitContainer_0.SplitterDistance = 234;
			this.splitContainer_0.TabIndex = 2;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewFilterTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.FldPwnhOrm,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13,
				this.FxjPobYexM,
				this.dataGridViewFilterTextBoxColumn_3,
				this.dataGridViewFilterTextBoxColumn_4,
				this.dataGridViewFilterTextBoxColumn_5
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_0.Name = "dataGridViewTrans";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(1169, 234);
			this.dataGridViewExcelFilter_0.TabIndex = 0;
			this.bindingSource_0.DataMember = "MeasurementReport1";
			this.bindingSource_0.DataSource = this.class19_0;
			this.class19_0.DataSetName = "DataSetScheme";
			this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_1.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6
			});
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_1.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_1.Name = "dataGridViewCab";
			this.dataGridViewExcelFilter_1.ReadOnly = true;
			this.dataGridViewExcelFilter_1.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_1.Size = new Size(1169, 237);
			this.dataGridViewExcelFilter_1.TabIndex = 0;
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "roottp";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "";
			this.dataGridViewFilterTextBoxColumn_0.Name = "roottpDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "cell";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_0.Name = "cellDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "KLVL";
			this.dataGridViewTextBoxColumn_1.HeaderText = "КЛ, ВЛ";
			this.dataGridViewTextBoxColumn_1.Name = "kLVLDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "section";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Сечение";
			this.dataGridViewTextBoxColumn_2.Name = "sectionDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "pload";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Доп. нагрузка";
			this.dataGridViewTextBoxColumn_3.Name = "ploadDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "measurement";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Замеры";
			this.dataGridViewTextBoxColumn_4.Name = "measurementDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "loading";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Загрузка";
			this.dataGridViewTextBoxColumn_5.Name = "loadingDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Коментарий";
			this.dataGridViewTextBoxColumn_6.Name = "commentDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.bindingSource_1.DataMember = "MeasurementReport2";
			this.bindingSource_1.DataSource = this.class19_0;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0
			});
			this.contextMenuStrip_0.Name = "contextMenuStrip1";
			this.contextMenuStrip_0.Size = new Size(209, 26);
			this.toolStripMenuItem_0.Name = "экспортТаблицыВExcelToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new Size(208, 22);
			this.toolStripMenuItem_0.Text = "Экспорт таблицы в Excel";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.panel_2.Controls.Add(this.reportViewer_0);
			this.panel_2.Dock = DockStyle.Fill;
			this.panel_2.Enabled = false;
			this.panel_2.Location = new Point(0, 25);
			this.panel_2.Name = "panelReport";
			this.panel_2.Size = new Size(1169, 475);
			this.panel_2.TabIndex = 0;
			this.panel_2.Visible = false;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripLabel_0,
				this.toolStripComboBox_0
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip1";
			this.toolStrip_0.Size = new Size(1169, 25);
			this.toolStrip_0.TabIndex = 0;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.Checked = true;
			this.toolStripButton_0.CheckOnClick = true;
			this.toolStripButton_0.CheckState = CheckState.Checked;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_62();
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolStripButtonGrid";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Таблицы";
			this.toolStripButton_0.CheckedChanged += this.toolStripButton_0_CheckedChanged;
			this.toolStripButton_1.CheckOnClick = true;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_52();
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolStripButtonReport";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Печатная форма";
			this.toolStripButton_1.CheckedChanged += this.toolStripButton_1_CheckedChanged;
			this.toolStripLabel_0.Name = "toolStripLabel1";
			this.toolStripLabel_0.Size = new Size(26, 22);
			this.toolStripLabel_0.Text = "Год";
			this.toolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.toolStripComboBox_0.Name = "cmbYear";
			this.toolStripComboBox_0.Size = new Size(121, 25);
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "roottp";
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "";
			this.dataGridViewFilterTextBoxColumn_1.Name = "roottpDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "cell";
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle.Format = "F0";
			this.dataGridViewTextBoxColumn_7.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewTextBoxColumn_7.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_7.Name = "cellDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "tp";
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "№ ТП";
			this.dataGridViewFilterTextBoxColumn_2.Name = "tpDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "trans";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Тр-р";
			this.dataGridViewTextBoxColumn_8.Name = "transDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "PkVA";
			this.dataGridViewTextBoxColumn_9.HeaderText = "Р, кВА";
			this.dataGridViewTextBoxColumn_9.Name = "pkVADataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.FldPwnhOrm.DataPropertyName = "A";
			this.FldPwnhOrm.HeaderText = "A";
			this.FldPwnhOrm.Name = "aDataGridViewTextBoxColumn";
			this.FldPwnhOrm.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "B";
			this.dataGridViewTextBoxColumn_10.HeaderText = "B";
			this.dataGridViewTextBoxColumn_10.Name = "bDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "C";
			this.dataGridViewTextBoxColumn_11.HeaderText = "C";
			this.dataGridViewTextBoxColumn_11.Name = "cDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "I";
			this.dataGridViewTextBoxColumn_12.HeaderText = "Сумма";
			this.dataGridViewTextBoxColumn_12.Name = "iDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_13.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_13.Name = "dateDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.FxjPobYexM.DataPropertyName = "Time";
			this.FxjPobYexM.HeaderText = "Время";
			this.FxjPobYexM.Name = "timeDataGridViewTextBoxColumn";
			this.FxjPobYexM.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "Disp";
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Диспетчер";
			this.dataGridViewFilterTextBoxColumn_3.Name = "dispDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Comment";
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Комментарий";
			this.dataGridViewFilterTextBoxColumn_4.Name = "commentDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "TemperatureD";
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Температура дн.";
			this.dataGridViewFilterTextBoxColumn_5.Name = "TemperatureD";
			this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1169, 500);
			base.Controls.Add(this.panel_0);
			base.Controls.Add(this.panel_1);
			base.Controls.Add(this.panel_2);
			base.Controls.Add(this.toolStrip_0);
			base.Name = "FormMeasuringReport";
			this.Text = "Замеры";
			base.WindowState = FormWindowState.Maximized;
			base.Load += this.FormMeasuringReport_Load;
			base.Resize += this.FormMeasuringReport_Resize;
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			this.panel_1.ResumeLayout(false);
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.dataGridViewExcelFilter_0.EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.class19_0).EndInit();
			this.dataGridViewExcelFilter_1.EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.contextMenuStrip_0.ResumeLayout(false);
			this.panel_2.ResumeLayout(false);
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void mqdstyKsuJ1hev8ii8g(Form form_0, bool bool_1)
		{
			form_0.Dispose(bool_1);
		}

		private string string_0;

		private DataTable dataTable_0;

		private DataTable dataTable_1;

		private DataTable dataTable_2;

		private int int_0;

		private bool bool_0;

		private IContainer icontainer_0;

		private ReportViewer reportViewer_0;

		private Panel panel_0;

		private Label label_0;

		private ProgressBarEndLess progressBarEndLess_0;

		private BackgroundWorker backgroundWorker_0;

		private Panel panel_1;

		private SplitContainer splitContainer_0;

		private Panel panel_2;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_1;

		private BindingSource bindingSource_0;

		private Class19 class19_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private BindingSource bindingSource_1;

		private ContextMenuStrip contextMenuStrip_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripLabel toolStripLabel_0;

		private ToolStripComboBox toolStripComboBox_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn FldPwnhOrm;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn FxjPobYexM;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
	}
}
