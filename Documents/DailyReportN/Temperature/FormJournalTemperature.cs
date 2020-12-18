using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
//using Documents.Properties;
using FormLbr;
/// <summary>
/// Архив погоды
/// </summary>
namespace DailyReportN.Temperature
{
	public partial class FormJournalTemperature : FormBase
	{
        private DateTimePicker dateTimePickerBegin;
        private DateTimePicker dateTimePickerEnd;

        public FormJournalTemperature()
		{
			this.InitializeComponent();

			this.toolBtnLoadOldBase.Visible = false;

            this.dateTimePickerEnd = new DateTimePicker();
			this.dateTimePickerEnd.Format = DateTimePickerFormat.Short;
			this.dateTimePickerEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddDays(-1.0);
			this.dateTimePickerEnd.Size = new Size(100, 20);
			ToolStripControlHost toolStripControlHost = new ToolStripControlHost(this.dateTimePickerEnd);
			toolStripControlHost.Alignment = ToolStripItemAlignment.Right;
			this.toolStrip.Items.Add(toolStripControlHost);
			ToolStripLabel toolStripLabel = new ToolStripLabel("Дата до");
			toolStripLabel.Alignment = ToolStripItemAlignment.Right;
			this.toolStrip.Items.Add(toolStripLabel);

            this.dateTimePickerBegin = new DateTimePicker();
			this.dateTimePickerBegin.Format = DateTimePickerFormat.Short;
			this.dateTimePickerBegin.Value = new DateTime(DateTime.Now.Year, 1, 1);
			this.dateTimePickerBegin.Size = new Size(100, 20);
			ToolStripControlHost toolStripControlHost2 = new ToolStripControlHost(this.dateTimePickerBegin);
			toolStripControlHost2.Alignment = ToolStripItemAlignment.Right;
			this.toolStrip.Items.Add(toolStripControlHost2);
			ToolStripLabel toolStripLabel2 = new ToolStripLabel("Дата от");
			toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
			this.toolStrip.Items.Add(toolStripLabel2);
		}

		private void FormJournalTemperature_Load(object sender, EventArgs e)
		{
			this.LoadTableTemperature(null);
		}

		private void FillColumnWindDirect()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			base.SelectSqlData(dataTable, true, "where ParentKey = ';ReportDaily;WindDirect;' and isGroup = 0 and deleted = 0 order by name", null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.windDgvColumn.DisplayMember = "name";
			this.windDgvColumn.ValueMember = "id";
			this.windDgvColumn.DataSource = bindingSource;
		}

		private void LoadTableTemperature(int? idCurrentWeather = null)
		{
			this.FillColumnWindDirect();
			if (idCurrentWeather == null && this.bsTemperature.Current != null)
			{
				idCurrentWeather = new int?(Convert.ToInt32(((DataRowView)this.bsTemperature.Current).Row["id"]));
			}
			base.SelectSqlData(this.dsDamage.tJ_Temperature, true, string.Format("where dateTemp >= '{0}' and dateTEmp <= '{1}' order by datetemp desc", this.dateTimePickerBegin.Value.ToString("yyyyMMdd"), this.dateTimePickerEnd.Value.ToString("yyyyMMdd")), null, false, 0);
			if (idCurrentWeather != null)
			{
				this.dgv.SearchGrid(this.idDataGridViewTextBoxColumn.Name, idCurrentWeather.ToString(), true);
			}
            this.chartAbnObjPayment.DataBind();
            this.chartAbnObjPayment.Update();
        }

		private void toolBtnAdd_Click(object sender, EventArgs e)
		{
			FormTemperatureAddEdit form = new FormTemperatureAddEdit(null);
			form.MdiParent = base.MdiParent;
			form.SqlSettings = this.SqlSettings;
			form.FormClosed +=new FormClosedEventHandler( this.f_FormClosed);
			form.Show();
		}

		private void f_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormTemperatureAddEdit form = (FormTemperatureAddEdit)sender;
			this.LoadTableTemperature(form.GetIdTemperature());
		}

		private void toolBtnEdit_Click(object sender, EventArgs e)
		{
			if (this.bsTemperature.Current == null)
			{
				MessageBox.Show("Не выбрана запись для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			DataRow row = ((DataRowView)this.bsTemperature.Current).Row;
			if (Convert.ToDateTime(row["dateTemp"]) < DateTime.Now.Date.AddDays(-2.0))
			{
				MessageBox.Show("Редактирование невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			FormTemperatureAddEdit form = new FormTemperatureAddEdit(new int?(Convert.ToInt32(row["id"])));
			form.MdiParent = base.MdiParent;
			form.SqlSettings = this.SqlSettings;
			form.FormClosed +=new FormClosedEventHandler( this.f_FormClosed);
			form.Show();
		}

		private void toolBtnDel_Click(object sender, EventArgs e)
		{
			if (this.dgv.CurrentRow != null)
			{
				int idCurrentWeather = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
				if (base.DeleteSqlDataById(this.dsDamage.tJ_Temperature, idCurrentWeather))
				{
					this.dgv.Rows.Remove(this.dgv.CurrentRow);
					MessageBox.Show("Строка успешно удалена");
					return;
				}
			}
			else
			{
				MessageBox.Show("Не выбрана запись для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void toolBtnRefresh_Click(object sender, EventArgs e)
		{
			this.LoadTableTemperature(null);
		}

		private void toolBtnFind_Click(object sender, EventArgs e)
		{
			this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.txtFind.Text);
		}

		private void toolBtnFindPrev_Click(object sender, EventArgs e)
		{
			this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
		}

		private void toolBtnFindNext_Click(object sender, EventArgs e)
		{
			this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
		}

		private void txtFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (e.Modifiers == Keys.Shift)
				{
					this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
				}
				if (e.Modifiers == Keys.NoName)
				{
					this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
				}
			}
		}

		private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && this.toolBtnEdit.Visible && this.toolBtnEdit.Enabled)
			{
				this.toolBtnEdit_Click(sender, e);
			}
		}

		private void toolBtnLoadOldBase_Click(object sender, EventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				sqlConnection.Open();
				SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("LoadOldTemp");
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.Connection = sqlConnection;
				sqlCommand.Transaction = sqlTransaction;
				try
				{
					sqlCommand.CommandText = "delete tJ_temperature ";
					sqlCommand.ExecuteNonQuery();
					sqlCommand.CommandText = "DBCC CHECKIDENT (tj_temperature, RESEED, 0)";
					sqlCommand.ExecuteNonQuery();
					DataTable dataTable = new SqlDataCommand(new SQLSettings("ulges-sql", "SR", "WINDOWS", "", "")).SelectSqlData("СоставительНизкого", false, "", null);
					sqlCommand.CommandText = "";
					List<DateTime> list = new List<DateTime>();
					foreach (DataRow dataRow in dataTable.Rows)
					{
						if (dataRow["Дата1"] != DBNull.Value && !list.Contains(Convert.ToDateTime(dataRow["Дата1"])))
						{
							list.Add(Convert.ToDateTime(dataRow["Дата1"]));
							string text = "null";
							if (dataRow["Ветер"] != DBNull.Value)
							{
								string text2 = dataRow["Ветер"].ToString();
								uint num = ComputeStringHash(text2);
								if (num <= 1603275976u)
								{
									if (num <= 696002790u)
									{
										if (num != 45186588u)
										{
											if (num == 696002790u)
											{
												if (text2 == "юго-восточный")
												{
													text = "1608";
												}
											}
										}
										else if (text2 == "юго-западный")
										{
											text = "1606";
										}
									}
									else if (num != 1472010880u)
									{
										if (num == 1603275976u)
										{
											if (text2 == "восточный")
											{
												text = "1609";
											}
										}
									}
									else if (text2 == "южный")
									{
										text = "1607";
									}
								}
								else if (num <= 1710837092u)
								{
									if (num != 1707431918u)
									{
										if (num == 1710837092u)
										{
											if (text2 == "северо-западный")
											{
												text = "1604";
											}
										}
									}
									else if (text2 == "западный")
									{
										text = "1605";
									}
								}
								else if (num != 3493755726u)
								{
									if (num == 3496321677u)
									{
										if (text2 == "северный")
										{
											text = "1603";
										}
									}
								}
								else if (text2 == "северо-восточный")
								{
									text = "1610";
								}
							}
							SqlCommand sqlCommand2 = sqlCommand;
							sqlCommand2.CommandText += string.Format(" insert into tJ_Temperature(DateTEmp, NightDown, NightUp, DayDown, DayUp, \r\n                                                        TempAverage, wind, speeddown, speedup, comment, dateOwner, owner) \r\n                                                Values('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", new object[]
							{
								Convert.ToDateTime(dataRow["Дата1"]).ToString("yyyyMMdd"),
								(dataRow["ТемператураНОт"] == DBNull.Value) ? "null" : dataRow["ТемператураНОт"].ToString(),
								(dataRow["ТемператураНДо"] == DBNull.Value) ? "null" : dataRow["ТемператураНДо"].ToString(),
								(dataRow["ТемператураДДо"] == DBNull.Value) ? "null" : dataRow["ТемператураДДо"].ToString(),
								(dataRow["ТемператураДДо"] == DBNull.Value) ? "null" : dataRow["ТемператураДДо"].ToString(),
								(dataRow["TemperatSrSut"] == DBNull.Value) ? "null" : dataRow["TemperatSrSut"].ToString(),
								text,
								(dataRow["СкоростьОт"] == DBNull.Value) ? "null" : dataRow["СкоростьОт"].ToString(),
								(dataRow["СкоростьДо"] == DBNull.Value) ? "null" : dataRow["СкоростьДо"].ToString(),
								(dataRow["Примечание"] == DBNull.Value) ? "null" : ("'" + dataRow["Примечание"].ToString() + "'"),
								(dataRow["Дата"] == DBNull.Value) ? "null" : ("'" + Convert.ToDateTime(dataRow["Дата"]).ToString("yyyyMMdd") + "'"),
								(dataRow["Составил"] == DBNull.Value) ? "null" : ("'" + dataRow["Составил"].ToString() + "'")
							});
						}
					}
					sqlCommand.ExecuteNonQuery();
					sqlTransaction.Commit();
					this.LoadTableTemperature(null);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
					try
					{
						sqlTransaction.Rollback();
					}
					catch (Exception ex2)
					{
						MessageBox.Show(ex2.Message, ex2.Source);
					}
				}
			}
		}

        internal uint ComputeStringHash(string p0)
        {
            uint num = 0;
            if (p0 != null)
            {
                num = 2166136261u;
                for (int i = 0; i < p0.Length; i++)
                {
                    num = ((uint)p0[i] ^ num) * 16777619u;
                }
            }
            return num;

        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && this.dgv.Columns[this.dateTempDataGridViewTextBoxColumn.Name].Index == e.ColumnIndex && (Convert.ToDateTime(this.dgv[e.ColumnIndex, e.RowIndex].Value).DayOfWeek == DayOfWeek.Saturday || Convert.ToDateTime(this.dgv[e.ColumnIndex, e.RowIndex].Value).DayOfWeek == DayOfWeek.Sunday))
			{
				e.CellStyle.ForeColor = Color.Red;
			}
		}

	
	}
}
