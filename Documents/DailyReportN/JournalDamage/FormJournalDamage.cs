using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.Scheme;
using DailyReportN.DataSet;
using DataSql;
using FormLbr;
using SchemeModelN;

namespace DailyReportN.JournalDamage
{
    /// <summary>
    /// Журнал технологических нарушений
    /// </summary>
    public partial class FormJournalDamage : FormBase
    {
        /// <summary>
        /// список типов отображаемых документов
        /// </summary>
        private List<eTypeDocuments> listTypeDoc;
        /// <summary>
        /// список выбранных подстанций
        /// </summary>
        private List<int> listCheckedSubstation;
        /// <summary>
        /// список колонок для сортировки
        /// </summary>
        private string listSortColumn = "";

        private int intSplitterDistance = 400;

        public FormJournalDamage()
        {
            this.InitializeComponent();
        }

        public FormJournalDamage(List<eTypeDocuments> eListTypeDoc, string capture = "")
        {
            this.InitializeComponent();
            listTypeDoc = eListTypeDoc;
            if (capture != "") this.Text = capture;
        }

        public FormJournalDamage(List<int> checkedSubstation)
		{
            this.InitializeComponent();
            this.listCheckedSubstation = checkedSubstation;
		}

		private void FormJournalDamage_Load(object sender, EventArgs e)
		{
			this.GetVisibleBtnDamageApply();
			this.FillParametersForFilter();
			this.SetSizeSplitterContaineLinkDoks();
			base.LoadFormConfig(null);
			this.FillControlsOperationsWithDocuments();
			this.treeViewSchmObjects.SqlSettings = this.SqlSettings;
			this.treeViewSchmObjects.Load(this.listCheckedSubstation);
			this.SearchIdDamage(-1);

            this.toolBTnLoadOld.Visible = false;
        }

		private void FormJournalDamage_FormClosed(object sender, FormClosedEventArgs e)
		{
			base.SaveFormConfig(null);
		}
        /// <summary>
        /// Заполним параметры для фильтров
        /// </summary>
		private void FillParametersForFilter()
		{
			this.dtpFilterBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
			this.dtpFilterEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);

            DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Columns.Add("socrname", typeof(string));
            
            //---------- Заполним подразделения заявителей
            this.checkedListBoxDivision.Items.Clear();
            base.SelectSqlData(dataTable, true, "where ParentKey = ';GroupWorker;DailyReport;' and isGroup = 0 and Deleted = 0", null, false, 0);
            foreach (DataRow dataRow in dataTable.Rows)
			{
				this.checkedListBoxDivision.Items.Add(new FormJournalDamage.StructDivisions(Convert.ToInt32(dataRow["id"]), dataRow["SocrName"].ToString()), true);
			}
            //----------------------
            this.treeViewSchmObjects.ClearTreeChecked();
            //----------------- Заполним подразделения исполнителей
            this.checkedListBoxDivisionApply.Items.Clear();

            base.SelectSqlData(dataTable, true, "where ParentKey = ';GroupWorker;DailyReport;' and isGroup = 0 and Deleted = 0", null, false, 0);
			foreach (DataRow dataRow2 in dataTable.Rows)
			{
				this.checkedListBoxDivisionApply.Items.Add(new FormJournalDamage.StructDivisions(Convert.ToInt32(dataRow2["id"]), dataRow2["SocrName"].ToString()), true);
			}

            base.SelectSqlData(dataTable, true, "where ParentKey = ';ReportDaily;DivisionApply;' and isGroup = 0 and Deleted = 0", null, false, 0);
			foreach (DataRow dataRow3 in dataTable.Rows)
			{
				this.checkedListBoxDivisionApply.Items.Add(new FormJournalDamage.StructDivisions(Convert.ToInt32(dataRow3["id"]), dataRow3["Name"].ToString()), true);
			}
			this.checkedListBoxDivisionApply.Items.Add(new FormJournalDamage.StructDivisions(-1, "Производственная лаборатория"), true);
		}
        /// <summary>
        /// Заполним выпадающие контекстное меню и выпадающую кнопку
        /// </summary>
		private void FillControlsOperationsWithDocuments() // FillControlsOperationsWithcuments
        {
            string strWhereTypeDoc = "";
            if (listTypeDoc != null)
                if (listTypeDoc.Count != 0)
                {
                    foreach (var en in listTypeDoc)
                        strWhereTypeDoc += (int)en + ",";
                    strWhereTypeDoc = strWhereTypeDoc.Remove(strWhereTypeDoc.Length - 1);
                    strWhereTypeDoc = $" and id in ({strWhereTypeDoc})";
                }
            DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
            base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;TypeDoc;' and isgroup = 0 and deleted = 0 and value = 1" + strWhereTypeDoc, null, false, 0);
			foreach (DataRow dataRow in dataTable.Rows)
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				toolStripMenuItem.Click += new EventHandler(this.toolStripMenuItem_Click);
				toolStripMenuItem.Text = dataRow["Name"].ToString();
				toolStripMenuItem.Tag = dataRow["id"];
				this.toolBtnAdd.DropDownItems.Add(toolStripMenuItem);

                ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
				toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem_Click);
				toolStripMenuItem2.Text = dataRow["Name"].ToString();
				toolStripMenuItem2.Tag = dataRow["id"];
				this.toolItemAdd.DropDownItems.Add(toolStripMenuItem2);
			}
		}

		private void toolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			if (toolStripMenuItem.Tag == null)
			{
				return;
			}
			this.OpenDokument(Convert.ToInt32(toolStripMenuItem.Tag), -1);
		}

		private void toolBtnEdit_Click(object sender, EventArgs e)
		{
			if (this.bsDamage.Current != null)
			{
				DataRow row = ((DataRowView)this.bsDamage.Current).Row;
				this.OpenDokument(Convert.ToInt32(row["TypeDoc"]), Convert.ToInt32(row["id"]), Convert.ToDateTime(row["dateDoc"]), false);
			}
		}

		private void toolBtnInfo_Click(object sender, EventArgs e)
		{
			if (this.bsDamage.Current != null)
			{
				DataRow row = ((DataRowView)this.bsDamage.Current).Row;
				this.OpenDokument(Convert.ToInt32(row["TypeDoc"]), Convert.ToInt32(row["id"]), Convert.ToDateTime(row["dateDoc"]), true);
			}
		}

		private void OpenDokument(int TypeDoc, int idDoc = -1,  DateTime DateDoc = default(DateTime), bool statusViewMode = false)
        {
            bool isNewVersionDoc = VersionDocDamage.isNew(this.SqlSettings, idDoc, DateDoc);
            switch (TypeDoc)
            {
                case (int)eTypeDocuments.DamageSL: // 2254
                case (int)eTypeDocuments.DamageLV: // 1401 или 2254
                    {
                        //if (DateDoc.Year < 2019 && idDoc != -1)
                        if (isNewVersionDoc == false)
                        {
                            DailyReport.JournalDamage.FormDamageLVAddEdit form4 = new DailyReport.JournalDamage.FormDamageLVAddEdit(idDoc, TypeDoc);
                            form4.SqlSettings = this.SqlSettings;
                            form4.MdiParent = base.MdiParent;
                            form4.FormViewMode(statusViewMode);
                            if (!statusViewMode)
                            {
                                form4.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
                            }
                            form4.Show();
                        }
                        else
                        {
                            DailyReportN.JournalDamage.FormDamageLVAddEdit form4 = new DailyReportN.JournalDamage.FormDamageLVAddEdit(idDoc, (eTypeDocuments)TypeDoc);
                            form4.SqlSettings = this.SqlSettings;
                            form4.MdiParent = base.MdiParent;
                            form4.SetFormViewMode(statusViewMode);
                            if (!statusViewMode)
                            {
                                form4.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
                            }
                            form4.Show();
                        }
                        break;
                    }
                case (int)eTypeDocuments.DamageHV:// 1402:
                    {
                        //if (DateDoc.Year < 2019 && idDoc != -1)
                        if (isNewVersionDoc == false)
                        {
                            DailyReport.JournalDamage.FormDamageHVAddEdit form = new DailyReport.JournalDamage.FormDamageHVAddEdit(idDoc);
                            form.SqlSettings = this.SqlSettings;
                            form.MdiParent = base.MdiParent;
                            form.FormViewMode(statusViewMode);
                            if (!statusViewMode)
                            {
                                form.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
                            }
                            form.Show();
                        }
                        else
                        {
                            DailyReportN.JournalDamage.FormDamageHVAddEdit form = new DailyReportN.JournalDamage.FormDamageHVAddEdit(idDoc);
                            form.SqlSettings = this.SqlSettings;
                            form.MdiParent = base.MdiParent;
                            form.SetFormViewMode(statusViewMode);
                            if (!statusViewMode)
                            {
                                form.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
                            }
                            form.Show();
                        }
                        break;
                    }
                case (int)eTypeDocuments.DefectLV:// 1403:
                                                  //break;
                case (int)eTypeDocuments.DefectHV:// 1844:
                    if (DateDoc.Year < 2019 && idDoc != -1)
                    {
                        DailyReport.JournalDamage.FormDefectAddEdit form2 = new DailyReport.JournalDamage.FormDefectAddEdit(idDoc, TypeDoc);
                        form2.SqlSettings = this.SqlSettings;
                        form2.MdiParent = base.MdiParent;
                        form2.FormViewMode(statusViewMode);
                        if (!statusViewMode)
                        {
                            form2.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
                        }
                        form2.Show();
                    }
                    else
                    {
                        DailyReportN.JournalDamage.FormDefectAddEdit form2 = new DailyReportN.JournalDamage.FormDefectAddEdit(idDoc, TypeDoc);
                        form2.SqlSettings = this.SqlSettings;
                        form2.MdiParent = base.MdiParent;
                        form2.SetFormViewMode(statusViewMode);
                        if (!statusViewMode)
                        {
                            form2.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
                        }
                        form2.Show();
                    }
                    break;
                case (int)eTypeDocuments.ActDetection:// 1874:
                    {
                        //if (!isNewVersionDoc)
                        //if (DateDoc.Year < 2019 && idDoc != -1)
                        //{
                        //    DailyReport.JournalActDetection.FormActDetectionAddEdit form3 = new DailyReport.JournalActDetection.FormActDetectionAddEdit(new int?(idDoc));
                        //    form3.SqlSettings = this.SqlSettings;
                        //    form3.MdiParent = base.MdiParent;
                        //    form3.FormViewMode(statusViewMode);
                        //    form3.Show();
                        //}
                        //else
                        {
                            DailyReportN.JournalActDetection.FormActDetectionAddEdit form3 = new DailyReportN.JournalActDetection.FormActDetectionAddEdit(new int?(idDoc));
                            form3.SqlSettings = this.SqlSettings;
                            form3.MdiParent = base.MdiParent;
                            form3.SetFormViewMode(statusViewMode);
                            form3.Show();
                        }
                        break;
                    }
                default:
                    break;
            }
            
        }
      
        private void Dokument_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (sender is Form && ((Form)sender).DialogResult == DialogResult.OK)
			{
				int id = -1;
				if (sender is DailyReportN.JournalDamage.FormDamageLVAddEdit)
				{
					id = ((DailyReportN.JournalDamage.FormDamageLVAddEdit)sender).GetIdDocument();
				}
				if (sender is DailyReportN.JournalDamage.FormDefectAddEdit)
				{
					id = ((DailyReportN.JournalDamage.FormDefectAddEdit)sender).GetIdDocument();
				}
                if (sender is DailyReport.JournalDamage.FormDamageLVAddEdit)
                {
                    id = ((DailyReport.JournalDamage.FormDamageLVAddEdit)sender).getIdUseDoc();
                }
                if (sender is DailyReport.JournalDamage.FormDefectAddEdit)
                {
                    id = ((DailyReport.JournalDamage.FormDefectAddEdit)sender).getIdUseDoc();
                }
                this.SearchIdDamage(id);
			}
		}

		private void toolBtnDel_Click(object sender, EventArgs e)
		{
			if (this.bsDamage.Current != null)
			{
				if (this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != DBNull.Value && this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != null && Convert.ToBoolean(this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value))
				{
					MessageBox.Show("Невозможно удалить исполненный документ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if ((Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.typeDocDgvColumn.Name].Value) == 1403 || Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.typeDocDgvColumn.Name].Value) == 1844) && this.dgvDamage.CurrentRow.Cells[this.idParentDgvColumn.Name].Value != DBNull.Value && this.dgvDamage.CurrentRow.Cells[this.idParentDgvColumn.Name].Value != null)
				{
					DataTable dataTable = new DataTable("VJ_Damage");
					dataTable.Columns.Add("Division", typeof(string));
					base.SelectSqlData(dataTable, true, " where id = " + this.dgvDamage.CurrentRow.Cells[this.idParentDgvColumn.Name].Value.ToString(), null, false, 0);
					string str = "";
					if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Division"] != DBNull.Value)
					{
						str = dataTable.Rows[0]["division"].ToString();
					}
					MessageBox.Show("Для удаления данного документа обратитесь в службу " + str, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (MessageBox.Show("Вы действительно хотите удалить выбранный документ и подчиненные данному документу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					int idDamage = Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
					if (base.DeleteSqlDataById(this.dsDamageN.tJ_Damage, idDamage))
					{
						this.DeleteDokumentsLink(idDamage);
						this.SearchIdDamage(-1);
						MessageBox.Show("Документ успешно удален");
						return;
					}
				}
			}
			else
			{
				MessageBox.Show("Не выбран документ для удаления");
			}
		}
        /// <summary>
        /// удаление подчиненных документов
        /// </summary>
		private void DeleteDokumentsLink(int idDamage) 
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					sqlConnection.Open();
					using (SqlCommand sqlCommand = new SqlCommand())
					{
						sqlCommand.Connection = sqlConnection;
						sqlCommand.CommandText = string.Format("update tj_damage \r\n                                                          set idParent = null\r\n                                                          where idParent = {0} and isApply = 1", idDamage);
						sqlCommand.ExecuteNonQuery();
						sqlCommand.CommandText = string.Format("delete tj_damage \r\n                                                          where idParent = {0} and (isApply = 0 or isApply is null)", idDamage);
						sqlCommand.ExecuteNonQuery();
					}
					sqlConnection.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void toolBtnRefresh_Click(object sender, EventArgs e)
		{
			this.SearchIdDamage(-1);
		}

		private void toolBtnFind_Click(object sender, EventArgs e)
		{
			this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.txtFind.Text);
		}

		private void toolBtnFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
		}

		private void toolBtnFindNext_Click(object sender, EventArgs e)
		{
			this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
		}

		private void txtFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (e.Modifiers == Keys.None)
				{
					this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
				}
				if (e.Modifiers == Keys.Shift)
				{
					this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
				}
			}
		}

		private void toolBtnExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvDamage.ExportToExcel();
		}

		private void toolBtnPrint_Click(object sender, EventArgs e)
		{
			this.dgvDamage.PrintDataGridView();
		}

		private void toolBtnFilterApply_Click(object sender, EventArgs e)
		{
			this.SearchIdDamage(-1);
		}

		private void toolBtnFilterDelete_Click(object sender, EventArgs e)
		{
			this.FillParametersForFilter();
			this.dgvDamage.ClearFilter();
			this.SearchIdDamage(-1);
		}

		private void toolBtnPrevYear_Click(object sender, EventArgs e)
		{
			this.dtpFilterBeg.Value = new DateTime(this.dtpFilterBeg.Value.Year - 1, this.dtpFilterBeg.Value.Month, this.dtpFilterBeg.Value.Day);
			this.dtpFilterEnd.Value = new DateTime(this.dtpFilterEnd.Value.Year - 1, this.dtpFilterEnd.Value.Month, this.dtpFilterEnd.Value.Day);
		}

		private void toolBtnNextYear_Click(object sender, EventArgs e)
		{
			this.dtpFilterEnd.Value = new DateTime(this.dtpFilterEnd.Value.Year + 1, this.dtpFilterEnd.Value.Month, this.dtpFilterEnd.Value.Day);
			this.dtpFilterBeg.Value = new DateTime(this.dtpFilterBeg.Value.Year + 1, this.dtpFilterBeg.Value.Month, this.dtpFilterBeg.Value.Day);
		}

		private void dtpFilterBeg_ValueChanged(object sender, EventArgs e)
		{
			this.dtpFilterEnd.MinDate = this.dtpFilterBeg.Value;
		}

		private void dtpFilterEnd_ValueChanged(object sender, EventArgs e)
		{
			this.dtpFilterBeg.MaxDate = this.dtpFilterEnd.Value;
		}

        /// <summary>
        /// отбор документов на основании фильтра по подразделениям и объектам схемы
        /// </summary>
		private void SelectionDocDamageWithFilters(int idDamage = -1)
		{
			this.toolStrip.Enabled = false;
			this.progressBar.Visible = true;
			this.splitContainer.Enabled = false;
			this.listSortColumn = this.bsDamage.Sort;
			this.bsDamage.Sort = string.Empty;
			this.bsDamage.DataMember = null;
			this.backgroundWorker.RunWorkerAsync(idDamage);
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			string str = "";
			str = string.Format(" where (deleted = 0) and (dateDoc >= '{0}' and dateDoc < '{1}') ", this.dtpFilterBeg.Value.ToString("yyyyMMdd"), this.dtpFilterEnd.Value.AddDays(1.0).ToString("yyyyMMdd"));
			if (this.checkedListBoxDivision.CheckedItems.Count > 0 && this.checkedListBoxDivision.CheckedItems.Count < this.checkedListBoxDivision.Items.Count)
			{
				string listDivision = "";// список подразделений
                foreach (FormJournalDamage.StructDivisions obj in this.checkedListBoxDivision.CheckedItems)
				{
					if (string.IsNullOrEmpty(listDivision))
					{
						listDivision = obj.id.ToString();
					}
					else
					{
						string str2 = listDivision;
						string str3 = ",";
						listDivision = str2 + str3 + obj.id.ToString();
					}
				}
				str += string.Format(" and (idDivision in ({0}))", listDivision);
			}
			List<int> listCheckedSchmObjects = this.treeViewSchmObjects.GetListChecked();
			if (listCheckedSchmObjects.Count > 0)
			{
				string listSchmObj = "";// список объектов схемы
                foreach (int num in listCheckedSchmObjects)
				{
					if (string.IsNullOrEmpty(listSchmObj))
					{
						listSchmObj = num.ToString();
					}
					else
					{
						listSchmObj = listSchmObj + "," + num.ToString();
					}
				}
				if (this.checkBoxWhereSub.Checked)
				{
					str += string.Format(" and (idSchmObj in ({0}) or idSub in ({0}))", listSchmObj);
				}
				else
				{
					str += string.Format(" and (idSchmObj in ({0}))", listSchmObj);
				}
			}

            string strTypedoc = "";
            string strTypeDocPL = "";
            if (listTypeDoc != null)
                if (listTypeDoc.Count != 0)
                {
                    strTypedoc =  string.Join(",", listTypeDoc.Select(x => ((int)x).ToString()).ToArray());
                    if (strTypedoc != "") strTypedoc = " and (typedoc in (" + strTypedoc + ")) ";

                    strTypeDocPL = string.Join(",", listTypeDoc.Select(x => ((int)x).ToString()).Where(w => w == "1403" || w == "1844").ToArray());
                    if (strTypeDocPL != "") strTypeDocPL = " and typedoc in (" + strTypeDocPL + ")";
                }

            if (this.checkedListBoxDivisionApply.Items.Count > 0)
            {
                if (this.checkedListBoxDivisionApply.CheckedItems.Count == 0)
                {
                    str += " and (idDivisionApply is null and (isLaboratory is null or isLaboratory = 0)) "+ strTypedoc;
                }
                else 
                    if (this.checkedListBoxDivisionApply.CheckedItems.Count < this.checkedListBoxDivisionApply.Items.Count)
                      {
                    bool flag = false;
                    string listDivisionApply = "";
                    foreach (FormJournalDamage.StructDivisions obj in this.checkedListBoxDivisionApply.CheckedItems)
                    {
                        if (obj.id == -1)
                        {
                            flag = true;
                        }
                        else if (string.IsNullOrEmpty(listDivisionApply))
                        {
                            listDivisionApply = obj.id.ToString();
                        }
                        else
                        {
                            string str4 = listDivisionApply;
                            string str5 = ",";
                            listDivisionApply = str4 + str5 + obj.id.ToString();
                        }
                    }
                    if (string.IsNullOrEmpty(listDivisionApply))
                    {
                        if (flag)
                        {
                            str += " and (IsLaboratory = 1 " + strTypeDocPL + ") ";
                        }
                        else
                            str += strTypedoc;
                    }
                    else if (flag)
                    {
                        str += string.Format(" and ((idDivisionApply in ({0})" + strTypedoc + ") or (isLaboratory = 1 " + strTypeDocPL + ")  or (idDivisionApply is null and (isLaboratory is null or isLaboratory = 0)" + strTypedoc + "))", listDivisionApply);
                    }
                    else
                    {
                        str += string.Format(" and (idDivisionApply in ({0}) or  (idDivisionApply is null and (isLaboratory is null or isLaboratory = 0)))" + strTypedoc, listDivisionApply);
                    }
                }
                else str += strTypedoc;
            }
            else
                str += strTypedoc;
            base.SelectSqlData(this.dsDamageN.vJ_Damage, true, str + " order by dateDoc desc", new int?(0), false, 0);
			e.Result = e.Argument;
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.toolStrip.Enabled = true;
			this.progressBar.Visible = false;
			this.splitContainer.Enabled = true;
			this.bsDamage.DataMember = this.dsDamageN.vJ_Damage.TableName;
			this.bsDamage.Sort = this.listSortColumn;
			if (e.Result != null && Convert.ToInt32(e.Result) > 0)
			{
				this.dgvDamage.SearchGrid(this.idDataGridViewTextBoxColumn.Name, e.Result.ToString(), true);
			}
		}
        /// <summary>
        /// Поиск строки по idDamage, с позиционированеим
        /// фильрация по подразделениям
        /// </summary>
		private void SearchIdDamage(int idDamage = -1)
		{
			if (idDamage == -1 && this.dgvDamage.CurrentRow != null)
			{
				idDamage = Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			}
			this.SelectionDocDamageWithFilters(idDamage);
		}

		private void dgvDamage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				if (this.toolBtnEdit.Enabled && this.toolBtnEdit.Visible)
				{
					this.toolBtnEdit_Click(sender, e);
					return;
				}
				if (this.toolBtnInfo.Enabled && this.toolBtnInfo.Visible)
				{
					this.toolBtnInfo_Click(sender, e);
				}
			}
		}

		private void dgvDamage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (this.dgvDamage[this.isApplyDgvColumn.Name, e.RowIndex].Value != DBNull.Value && this.dgvDamage[this.isApplyDgvColumn.Name, e.RowIndex].Value != null && Convert.ToBoolean(this.dgvDamage[this.isApplyDgvColumn.Name, e.RowIndex].Value))
				{
					e.CellStyle.ForeColor = Color.Green;
				}
				else
				{
					if (this.dgvDamage[this.datePlanEndDgvColumn.Name, e.RowIndex].Value != DBNull.Value && this.dgvDamage[this.datePlanEndDgvColumn.Name, e.RowIndex].Value != null)
					{
						DateTime dateTime = Convert.ToDateTime(this.dgvDamage[this.datePlanEndDgvColumn.Name, e.RowIndex].Value);
						if (dateTime.Date.AddDays(1.0) < DateTime.Now)
						{
							e.CellStyle.ForeColor = Color.Red;
							if (e.ColumnIndex == this.completedWorkDataGridViewTextBoxColumn.Index)
							{
								e.CellStyle.ForeColor = Color.Gray;
								e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 1f, FontStyle.Italic);
								e.Value = "Просрочено на " + (DateTime.Now.Date - dateTime.Date).Days.ToString() + " дн.";
							}
						}
						else if (dateTime.Date == DateTime.Now.Date)
						{
							if (e.ColumnIndex == this.completedWorkDataGridViewTextBoxColumn.Index)
							{
								e.CellStyle.ForeColor = Color.Gray;
								e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 1f, FontStyle.Italic);
								e.Value = "Просрочится сегодня";
							}
						}
						else if (e.ColumnIndex == this.completedWorkDataGridViewTextBoxColumn.Index)
						{
							e.CellStyle.ForeColor = Color.Gray;
							e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 1f, FontStyle.Italic);
							e.Value = "Осталось по плану " + (dateTime.Date - DateTime.Now.Date).Days.ToString() + " дн.";
						}
					}
					if (this.dgvDamage[this.idReqForRepairDgvColumn.Name, e.RowIndex].Value != DBNull.Value && this.dgvDamage[this.idReasonDgvColumn.Name, e.RowIndex].Value == DBNull.Value)
					{
						e.CellStyle.BackColor = Color.LightPink;
						if (e.ColumnIndex != this.completedWorkDataGridViewTextBoxColumn.Index)
						{
							e.CellStyle.ForeColor = Color.Red;
							e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
						}
					}
				}
				if (Convert.ToBoolean(this.dgvDamage[this.isNoSESNODgvColumn.Name, e.RowIndex].Value) && e.ColumnIndex == this.dateDocDgvColumn.Index)
				{
					e.CellStyle.BackColor = Color.Orange;
				}
			}
		}

		private void dgvDamage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			this.dgvDamage.AutoResizeRow(e.RowIndex);
		}

		private void dgvDamage_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
			{
				this.contextMenuDamage.Show(Cursor.Position);
			}
		}

		private void toolBtnFindTreeSchmObj_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
			{
				this.treeViewSchmObjects.Find(this.txtFindTreeSchmObj.Text);
			}
		}

		private void toolBtnFindPrevTreeSchmObj_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
			{
				this.treeViewSchmObjects.FindPrev(this.txtFindTreeSchmObj.Text);
			}
		}

		private void toolBtnFindNextTreeSchmObj_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
			{
				this.treeViewSchmObjects.FindNext(this.txtFindTreeSchmObj.Text);
			}
		}

		private void txtFindTreeSchmObj_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Keys modifiers = e.Modifiers;
				if (modifiers != Keys.None)
				{
					if (modifiers != Keys.Shift)
					{
						return;
					}
					if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
					{
						this.treeViewSchmObjects.FindPrev(this.txtFindTreeSchmObj.Text);
					}
				}
				else if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
				{
					this.treeViewSchmObjects.FindNext(this.txtFindTreeSchmObj.Text);
					return;
				}
			}
		}

		private void toolMenuItemReportDailyLV_Click(object sender, EventArgs e)
		{
			new FormReportDailyLV
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolMenuItemSheetInterruptLV_Click(object sender, EventArgs e)
		{
			new FormReportInterruptLV
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolMenuItemReportDailyDefect_Click(object sender, EventArgs e)
		{
			new FormReportDailyDefect
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolMenuItemReportDailyHV_Click(object sender, EventArgs e)
		{
			new FormReportDailyHV
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void tsMenuAmergencyShutdown_Click(object sender, EventArgs e)
		{
			new FormReportDetectionCrash
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolMenuItemReport81_Click(object sender, EventArgs e)
		{
			new FormReport81
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolBtnLoadOldDamageLV_Click(object sender, EventArgs e)
		{
			LoadOldDamageLV.Load(this.SqlSettings, new SQLSettings("ulges-sql", "SR4", "WINDOWS", "", ""));
			this.SearchIdDamage(-1);
		}

		private void toolBtnLoadOldDamageLVMySQL_Click(object sender, EventArgs e)
		{
			ImportDataSESNO.Load(this.SqlSettings);
			this.SearchIdDamage(-1);
		}

		private void toolBtnLoadOldDefect_Click(object sender, EventArgs e)
		{
			LoadOldDefect.Load(this.SqlSettings);
			this.SearchIdDamage(-1);
		}

		private void toolBtnLoadAbnDefectLV_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					try
					{
						sqlConnection.Open();
						SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
						try
						{
							DataTable dataTable = new DataTable();
							using (SqlCommand sqlCommand = new SqlCommand())
							{
								sqlCommand.Connection = sqlConnection;
								sqlCommand.Transaction = sqlTransaction;
								sqlCommand.CommandText = "select d.id, d.idSchmObj, d.dateDoc, dLv.iddamage, dlv.abnOff from tj_damage d\r\n\t                                                left join tj_damagelv dlv on dlv.iddamage = d.id\r\n                                                where d.typeDoc = 1401\r\n\t                                                    and d.idSchmObj is not null\r\n\t                                                    and d.datedoc >= '20150101'\r\n\t                                                    and dlv.abnOff is null\r\n                                            and d.id not in (48483, 48485, 48487,48615,48888,48897)";
								new SqlDataAdapter(sqlCommand).Fill(dataTable);
							}

                            foreach (DataRow dr in dataTable.Rows)
                            {
                                if (dr["dateDoc"] != DBNull.Value)
                                {
                                    ElectricModel electricModel = new ElectricModel();
                                    electricModel.SqlSettings = this.SqlSettings;
                                    electricModel.LoadSchema(Convert.ToDateTime(dr["dateDoc"]));
                                    electricModel.PoweringReportForDrawObject(Convert.ToInt32(dr["idSchmObj"]), true);
                                    var source = from obj in electricModel.Objects
                                                                         where obj.Id == Convert.ToInt32(dr["idSchmObj"])
                                                                         select obj;
                                    if (source.Count<ElectricObject>() > 0)
                                    {
                                        var list = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
                                        System.Data.DataSet dataSet = new System.Data.DataSet();
                                        DataTable dataTable2 = new DataTable("vL_SchmAbnFull");
                                        dataTable2.Columns.Add("idAbn", typeof(int));
                                        dataTable2.Columns.Add("idAbnObj", typeof(int));
                                        dataSet.Tables.Add(dataTable2);
                                        if (list.Count > 0)
                                        {
                                            string text = "";
                                            foreach (ElectricObject electricObject in list)
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
                                            base.SelectSqlData(dataTable2, true, " where idSchmObj in (" + text + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
                                        }
                                        else
                                        {
                                            dataTable2.Clear();
                                        }
                                        DataTable dataTable3 = new DataTable("tj_damagelv");
                                        DataColumn dataColumn = dataTable3.Columns.Add("idDamage", typeof(int));
                                        dataTable3.Columns.Add("abnoff", typeof(string));
                                        dataTable3.PrimaryKey = new DataColumn[]
                                        {
                                                dataColumn
                                        };
                                        base.SelectSqlData(dataTable3, true, "where iddamage = " + dr["id"].ToString(), null, false, 0);
                                        if (dataTable3.Rows.Count == 0)
                                        {
                                            DataRow dataRow = dataTable3.NewRow();
                                            dataRow["idDamage"] = dr["id"];
                                            dataRow["abnOff"] = CreateReferenceTables.CreateXmlAbnOff(dataTable2).InnerXml;
                                            dataTable3.Rows.Add(dataRow);
                                            base.InsertSqlData(dataTable3);
                                        }
                                        else
                                        {
                                            dataTable3.Rows[0]["abnOff"] = CreateReferenceTables.CreateXmlAbnOff(dataTable2).InnerXml;
                                            dataTable3.Rows[0].EndEdit();
                                            base.UpdateSqlData(dataTable3);
                                        }
                                    }
                                }
                            }
                                     //	}
							//}
							sqlTransaction.Commit();
						}
						catch (Exception ex)
						{
							sqlTransaction.Rollback();
							MessageBox.Show(ex.Message, ex.Source);
						}
					}
					catch (Exception ex2)
					{
						MessageBox.Show(ex2.Message, ex2.Source);
					}
				}
			}
			catch (Exception ex3)
			{
				MessageBox.Show(ex3.Message, ex3.Source);
			}
		}

		private void toolBtnLoadOldDamageНV_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
#pragma warning disable CS0436 // Тип конфликтует с импортированным типом
                LoadOldDamageНV.Load(openFileDialog.FileName, new StaticFormData { Sqlsettings = this.SqlSettings, eForm = this });
#pragma warning restore CS0436 // Тип конфликтует с импортированным типом
            }
		}

        private void damageHVToDamageMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyReportN.DataSet.dsDamage ds = new dsDamage();
            // base.SelectSqlData(ds.tJ_Damage, true, " where TypeDoc = 1402", null, false, 0);
            base.SelectSqlData(ds.tJ_Damage, true,string.Format( " where TypeDoc = {0}", (int)eTypeDocuments.DamageHV), null, false, 0);
            base.SelectSqlData(ds.tJ_DamageHV, true, "", null, false, 0);
            foreach (DataRow dataRow in ds.tJ_Damage)
            {
                DataRow[] array = ds.tJ_DamageHV.Select("idDamage = " + dataRow["id"].ToString());
                if (array.Length != 0)
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    if (dataRow["CommentXml"] != DBNull.Value)
                    {
                        try
                        {
                            xmlDocument.LoadXml(dataRow["CommentXml"].ToString());
                        }
                        catch
                        {
                        }

                        XmlNode xmlNodeDoc = xmlDocument.SelectSingleNode("Doc");
                        if (xmlNodeDoc == null)
                        {
                            xmlNodeDoc = xmlDocument.CreateElement("Doc");
                            xmlDocument.AppendChild(xmlNodeDoc);
                        }

                        XmlNode xmlNodeAbnOff = xmlNodeDoc.SelectSingleNode("AbnOff");
                        if (xmlNodeAbnOff != null)
                        {
                            xmlNodeDoc.RemoveChild(xmlNodeAbnOff);
                        }
                        if (array[0]["AbnOff"] != DBNull.Value)
                        {
                            XmlDocument xmlDocument2 = new XmlDocument();
                            xmlDocument2.LoadXml(array[0]["AbnOff"].ToString());
                            XmlNode xmlNode3 = xmlDocument2.SelectSingleNode("AbnOff");
                            if (xmlNode3 != null)
                            {
                                xmlNodeDoc.AppendChild(xmlDocument.ImportNode(xmlNode3, true));
                            }
                        }

                        XmlNode xmlNodeTransOff = xmlNodeDoc.SelectSingleNode("TransOff");
                        if (xmlNodeTransOff != null)
                        {
                            xmlNodeDoc.RemoveChild(xmlNodeTransOff);
                        }
                        if (array[0]["TransOff"] != DBNull.Value)
                        {
                            XmlDocument xmlDocument3 = new XmlDocument();
                            xmlDocument3.LoadXml(array[0]["TransOff"].ToString());
                            XmlNode xmlNode5 = xmlDocument3.SelectSingleNode("TransOff");
                            if (xmlNode5 != null)
                            {
                                xmlNodeDoc.AppendChild(xmlDocument.ImportNode(xmlNode5, true));
                            }
                        }

                        dataRow["CommentXml"] = xmlDocument.InnerXml;
                        dataRow.EndEdit();
                        base.UpdateSqlDataOnlyChange(ds.tJ_Damage);
                        ds.tJ_Damage.AcceptChanges();
                    }
                }
            }


        }

        private void damageLVToDamageMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyReportN.DataSet.dsDamage ds = new dsDamage();
            // base.SelectSqlData(ds.tJ_Damage, true, " where TypeDoc = 1401", null, false, 0);
            base.SelectSqlData(ds.tJ_Damage, true, string.Format(" where TypeDoc = {0}",(int)eTypeDocuments.DamageLV), null, false, 0);
            base.SelectSqlData(ds.tJ_DamageLV, true, "", null, false, 0);
            foreach (DataRow dataRow in ds.tJ_Damage)
            {
                DataRow[] array = ds.tJ_DamageLV.Select("idDamage = " + dataRow["id"].ToString());
                if (array.Length != 0)
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    if (dataRow["CommentXml"] != DBNull.Value)
                    {
                        try
                        {
                            xmlDocument.LoadXml(dataRow["CommentXml"].ToString());
                        }
                        catch
                        {
                        }

                        XmlNode xmlNodeDoc = xmlDocument.SelectSingleNode("Doc");
                        if (xmlNodeDoc == null)
                        {
                            xmlNodeDoc = xmlDocument.CreateElement("Doc");
                            xmlDocument.AppendChild(xmlNodeDoc);
                        }

                        XmlNode xmlNodeAbnOff = xmlNodeDoc.SelectSingleNode("AbnOff");
                        if (xmlNodeAbnOff != null)
                        {
                            xmlNodeDoc.RemoveChild(xmlNodeAbnOff);
                        }
                        if (array[0]["AbnOff"] != DBNull.Value)
                        {
                            XmlDocument xmlDocument2 = new XmlDocument();
                            xmlDocument2.LoadXml(array[0]["AbnOff"].ToString());
                            XmlNode xmlNode3 = xmlDocument2.SelectSingleNode("AbnOff");
                            if (xmlNode3 != null)
                            {
                                xmlNodeDoc.AppendChild(xmlDocument.ImportNode(xmlNode3, true));
                            }
                        }

                        // сюда затолкать трансформаторы надо
                        dataRow["CommentXml"] = xmlDocument.InnerXml;
                        dataRow.EndEdit();
                        base.UpdateSqlDataOnlyChange(ds.tJ_Damage);
                        ds.tJ_Damage.AcceptChanges();
                    }
                }
            }


        }
        private void GetVisibleBtnDamageApply()
        {
            DataTable dataTable = new DataTable("tUser");
            dataTable.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(dataTable, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;DailyReport;Admin;' and tuser.login = SYSTEM_USER", null, false, 0);
            if (dataTable.Rows.Count > 0)
            {
                this.toolBtnDamageNoApply.Visible = true;
                this.toolBtnUnLockSend.Visible = true;
            }
            else
            {
                this.toolBtnDamageNoApply.Visible = false;
                this.toolBtnUnLockSend.Visible = false;
            }
		}

		private void toolBtnDamageNoApply_Click(object sender, EventArgs e)
		{
			if (this.bsDamage.Current != null)
			{
				if (this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != DBNull.Value && this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != null && Convert.ToBoolean(this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value))
				{
					if (MessageBox.Show("Вы действительно хотите разблокировать текущий документ?", "Разблокировка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						return;
					}
					int num = Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
					try
					{
						using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
						{
							sqlConnection.Open();
							using (SqlCommand sqlCommand = new SqlCommand())
							{
								sqlCommand.Connection = sqlConnection;
								sqlCommand.CommandText = string.Format("update tj_damage \r\n                                                                  set isapply = 0\r\n                                                                   where id = {0}", num);
								if (sqlCommand.ExecuteNonQuery() > 0)
								{
									this.SearchIdDamage(-1);
								}
							}
							sqlConnection.Close();
							MessageBox.Show("Документ успешно разблокирован");
						}
						return;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
						return;
					}
				}
				MessageBox.Show("Документ уже разблокирован");
			}
		}
        /// <summary>
        /// разблокировка отправки в минэнерго
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnUnLockSend_Click(object sender, EventArgs e)
        {
            if (this.bsDamage.Current != null)
            {
                if (this.dgvDamage.CurrentRow.Cells[this.isSendSiteMeDgvColumn.Name].Value != DBNull.Value && this.dgvDamage.CurrentRow.Cells[this.isSendSiteMeDgvColumn.Name].Value != null && Convert.ToBoolean(this.dgvDamage.CurrentRow.Cells[this.isSendSiteMeDgvColumn.Name].Value))
                {
                    if (MessageBox.Show("Вы действительно хотите разблокировать для отправки в МЭ текущий документ?", "Разблокировка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    int num = Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                        {
                            sqlConnection.Open();
                            using (SqlCommand sqlCommand = new SqlCommand())
                            {
                                sqlCommand.Connection = sqlConnection;
                                sqlCommand.CommandText = string.Format("update tj_damage \r\n                                                                  set isSendSiteMe = 0\r\n                                                                   where id = {0} and isSendSiteMe in {1}",  num, "(2,5,7,10,11,12,24)" );
                                if (sqlCommand.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Документ успешно разблокирован");
                                    this.SearchIdDamage(-1);
                                }
                                else
                                    MessageBox.Show("Документ не возможно разблокировать (статус = отправлен)");
                            }
                            sqlConnection.Close();
                            
                        }
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                        return;
                    }
                }
                MessageBox.Show("Документ уже разблокирован");
            }
        }
        protected override XmlDocument CreateXmlConfig()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
			xmlDocument.AppendChild(newChild);
			XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
			xmlDocument.AppendChild(xmlNode);
			foreach (FormJournalDamage.StructDivisions obj in this.checkedListBoxDivision.CheckedItems)
			{
				XmlNode xmlCheckDivision = xmlDocument.CreateElement("CheckDivision");
				XmlAttribute xmlId = xmlDocument.CreateAttribute("Id");
                xmlId.Value = obj.id.ToString();
				xmlCheckDivision.Attributes.Append(xmlId);
				xmlNode.AppendChild(xmlCheckDivision);
			}
			XmlNode xmlDivisionApply = xmlDocument.CreateElement("DivisionApply");
			xmlNode.AppendChild(xmlDivisionApply);
			foreach (FormJournalDamage.StructDivisions obj in this.checkedListBoxDivisionApply.CheckedItems)
			{
				XmlNode xmlNode5 = xmlDocument.CreateElement("CheckDivisionApply");
				XmlAttribute xmlId = xmlDocument.CreateAttribute("Id");
                xmlId.Value = obj.id.ToString();
				xmlNode5.Attributes.Append(xmlId);
				xmlDivisionApply.AppendChild(xmlNode5);
			}
			XmlAttribute xmlDateBeg = xmlDocument.CreateAttribute("dateBeg");
			xmlDateBeg.Value = this.dtpFilterBeg.Value.ToString();
			xmlNode.Attributes.Append(xmlDateBeg);
			xmlDateBeg = xmlDocument.CreateAttribute("dateEnd");
			xmlDateBeg.Value = this.dtpFilterEnd.Value.ToString();
			xmlNode.Attributes.Append(xmlDateBeg);
			return xmlDocument;
		}

		protected override void ApplyConfig(XmlDocument doc)
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
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
					list.Add(Convert.ToInt32(xmlAttribute.Value));
				}
			}
			for (int i = 0; i < this.checkedListBoxDivision.Items.Count; i++)
			{
				if (list.Contains(((FormJournalDamage.StructDivisions)this.checkedListBoxDivision.Items[i]).id))
				{
					this.checkedListBoxDivision.SetItemChecked(i, true);
				}
				else
				{
					this.checkedListBoxDivision.SetItemChecked(i, false);
				}
			}
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("DivisionApply");
			if (xmlNode2 != null)
			{
				foreach (object obj2 in xmlNode2.SelectNodes("CheckDivisionApply"))
				{
					XmlAttribute xmlAttribute2 = ((XmlNode)obj2).Attributes["Id"];
					if (xmlAttribute2 != null)
					{
						list2.Add(Convert.ToInt32(xmlAttribute2.Value));
					}
				}
				for (int j = 0; j < this.checkedListBoxDivisionApply.Items.Count; j++)
				{
					if (list2.Contains(((FormJournalDamage.StructDivisions)this.checkedListBoxDivisionApply.Items[j]).id))
					{
						this.checkedListBoxDivisionApply.SetItemChecked(j, true);
					}
					else
					{
						this.checkedListBoxDivisionApply.SetItemChecked(j, false);
					}
				}
			}
			XmlAttribute xmlAttribute3 = xmlNode.Attributes["dateBeg"];
			if (xmlAttribute3.Value != null)
			{
				this.dtpFilterBeg.Value = Convert.ToDateTime(xmlAttribute3.Value);
			}
			xmlAttribute3 = xmlNode.Attributes["dateEnd"];
			if (xmlAttribute3.Value != null)
			{
				this.dtpFilterEnd.Value = Convert.ToDateTime(xmlAttribute3.Value);
			}
		}

		private void ccontextMenuDamage_Opening(object sender, CancelEventArgs e)
		{
			if (this.bsDamage.Current == null)
			{
				this.toolItemEdit.Enabled = false;
				this.toolItemInfo.Enabled = false;
				this.toolItemDel.Enabled = false;
				this.toolItemActDetection.Visible = false;
				return;
			}
			this.toolItemEdit.Enabled = true;
			this.toolItemInfo.Enabled = true;
			this.toolItemDel.Enabled = true;
            //if (Convert.ToInt32(((DataRowView)this.bsDamage.Current).Row["TypeDoc"]) == (int)eTypeDocuments.DamageHV)
            //	this.toolItemActDetection.Visible = true;
            //else
            //	this.toolItemActDetection.Visible = false;
            this.toolItemActDetection.Visible = true;
        }

		private void toolItemActDetectionAdd_Click(object sender, EventArgs e)
		{
			if (this.bsDamage.Current != null)
			{
				DataRow row = ((DataRowView)this.bsDamage.Current).Row;
				if (Convert.ToInt32(row["TypeDoc"]) == (int)eTypeDocuments.DamageHV || Convert.ToInt32(row["TypeDoc"]) == (int)eTypeDocuments.DamageLV)
				{
					int value = Convert.ToInt32(row["id"]);
					FormChooseDamageCharacter form = new FormChooseDamageCharacter(new int?(value), null, null);
					form.SqlSettings = this.SqlSettings;
					if (form.ShowDialog() == DialogResult.OK)
					{
						new DailyReportN.JournalActDetection.FormActDetectionAddEdit(new int?(value), form.getListDamage().ToList<int>())
						{
							SqlSettings = this.SqlSettings,
							MdiParent = base.MdiParent
						}.Show();
					}
				}
			}
		}

        /// <summary>
        /// определим размер контрейнера содержащего связанные документы
        /// </summary>
		private void SetSizeSplitterContaineLinkDoks()
        {
			this.splitContainerDgv.SplitterDistance = this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth - this.lbLinkDoc.Height;
			this.splitContainerDgv.IsSplitterFixed = true;
		}

		private void lbLinkDoc_Click(object sender, EventArgs e)
		{
			if (this.lbLinkDoc.Cursor == Cursors.PanNorth)
			{
				this.splitContainerDgv.SplitterDistance = this.intSplitterDistance;
				this.splitContainerDgv.IsSplitterFixed = false;
				this.lbLinkDoc.Cursor = Cursors.PanSouth;
				return;
			}
			if (this.lbLinkDoc.Cursor == Cursors.PanSouth)
			{
				this.intSplitterDistance = this.splitContainerDgv.SplitterDistance;
				this.splitContainerDgv.SplitterDistance = this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth - this.lbLinkDoc.Height;
				this.splitContainerDgv.IsSplitterFixed = true;
				this.lbLinkDoc.Cursor = Cursors.PanNorth;
			}
		}
        /// <summary>
        /// Загрузка подчиненных документов
        /// </summary>
		private void FillDokumentsLink() 
		{
			if (this.bsDamage.Current != null && this.bsDamage.Current is DataRowView)
			{
				this.dtLinkDocs.Clear();
				Convert.ToInt32(((DataRowView)this.bsDamage.Current).Row["id"]);
				try
				{
					using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
					{
						sqlConnection.Open();
						if (((DataRowView)this.bsDamage.Current).Row["idParent"] != DBNull.Value)
						{
							using (SqlCommand sqlCommand = new SqlCommand())
							{
								sqlCommand.CommandText = " select id, typeDoc, typedocName, \r\n                                                      numRequest as numDoc, dateDoc, idReqForRepair, (1) as isParent\r\n                                                    from vj_damage \r\n                                                    where id = " + ((DataRowView)this.bsDamage.Current).Row["idParent"] + " and deleted = 0 ";
								sqlCommand.Connection = sqlConnection;
								new SqlDataAdapter(sqlCommand).Fill(this.dtLinkDocs);
							}
						}
						if (this.dtLinkDocs.Rows.Count > 0 && this.dtLinkDocs.Rows[0]["idReqForRepair"] != DBNull.Value)
						{
							using (SqlCommand sqlCommand2 = new SqlCommand())
							{
								sqlCommand2.CommandText = " select id, -1 as typeDoc, 'Аварийная заявка' as typedocName, \r\n                                                      num as numDoc, datecreate as dateDoc, null as idReqForRepair, (1) as isParent\r\n                                                    from tJ_RequestForRepair \r\n                                                    where id = " + this.dtLinkDocs.Rows[0]["idReqForRepair"].ToString() + " and deleted = 0 ";
								sqlCommand2.Connection = sqlConnection;
								new SqlDataAdapter(sqlCommand2).Fill(this.dtLinkDocs);
							}
						}
						if (((DataRowView)this.bsDamage.Current).Row["idReqForRepair"] != DBNull.Value)
						{
							using (SqlCommand sqlCommand3 = new SqlCommand())
							{
								sqlCommand3.CommandText = " select id, -1 as typeDoc, 'Аварийная заявка' as typedocName, \r\n                                                      num as numDoc, datecreate as dateDoc, null as idReqForRepair, (1) as isParent\r\n                                                    from tJ_RequestForRepair \r\n                                                    where id = " + ((DataRowView)this.bsDamage.Current).Row["idReqForRepair"] + " and deleted = 0 ";
								sqlCommand3.Connection = sqlConnection;
								new SqlDataAdapter(sqlCommand3).Fill(this.dtLinkDocs);
							}
						}
						using (SqlCommand sqlCommand4 = new SqlCommand())
						{
							sqlCommand4.CommandText = " select id, typeDoc, typedocName, \r\n                                                      numRequest as numDoc, dateDoc\r\n                                                    from vj_damage \r\n                                                    where idParent = " + ((DataRowView)this.bsDamage.Current).Row["id"] + " and deleted = 0 ";
							sqlCommand4.Connection = sqlConnection;
							new SqlDataAdapter(sqlCommand4).Fill(this.dtLinkDocs);
						}
					}
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
					return;
				}
			}
			this.dtLinkDocs.Clear();
		}

		private void dgvLinkDocs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && this.bsDamage.Current != null && this.bsDamage.Current is DataRowView)
			{
				if (((DataRowView)this.bsDamage.Current).Row["idParent"] != DBNull.Value && Convert.ToInt32(this.dgvLinkDocs[this.idLinkDocDgvColumn.Name, e.RowIndex].Value) == Convert.ToInt32(((DataRowView)this.bsDamage.Current).Row["idParent"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
				if (((DataRowView)this.bsDamage.Current).Row["idReqForRepair"] != DBNull.Value && Convert.ToInt32(this.dgvLinkDocs[this.idLinkDocDgvColumn.Name, e.RowIndex].Value) == Convert.ToInt32(((DataRowView)this.bsDamage.Current).Row["idReqForRepair"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
				if (this.dgvLinkDocs[this.isParentDgvColumn.Name, e.RowIndex].Value != DBNull.Value && Convert.ToBoolean(this.dgvLinkDocs[this.isParentDgvColumn.Name, e.RowIndex].Value))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
		}

		private void bsDamage_CurrentChanged(object sender, EventArgs e)
		{
			this.FillDokumentsLink();
		}

		private void bsDamage_ListChanged(object sender, ListChangedEventArgs e)
		{
			string arg = "";
			if (this.bsDamage.Filter != null && !string.IsNullOrEmpty(this.bsDamage.Filter))
			{
				arg = string.Format("({0}) and ", this.bsDamage.Filter);
			}
			this.txtLegendApply.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} isApply = 1", arg)).ToString() + " - устранено";
			this.txtLegendInWork.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} (isApply is null or isApply = 0) \r\n                    and (datePlanEnd is null or datePlanEnd >= '{1}')\r\n                    and not (idReqForRepair is not null and idReason is null)", arg, DateTime.Now.Date.ToString("yyyy-MM-dd") + " 00:00:00")).ToString() + " - в работе";
			this.txtLegendOverdue.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} (isApply is null or isApply = 0) \r\n                    and (datePlanEnd < '{1}')\r\n                    and not (idReqForRepair is not null and idReason is null)", arg, DateTime.Now.Date.ToString("yyyy-MM-dd") + " 00:00:00")).ToString() + " - просрочено";
			this.txtLegendUnExec.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} (isApply is null or isApply = 0) \r\n                    and (idReqForRepair is not null and idReason is null)", arg)).ToString() + " - неоформлено";
			this.txtLegendNoSESNO.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} (isNoSESNO = 1)", arg)).ToString() + " - нет сетей Горсвет";
		}

		private void toolBtnSettingMail_Click(object sender, EventArgs e)
		{
			new FormDamageSettingMail
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private struct StructDivisions
		{
			internal StructDivisions(int a, string b)
			{
				this.id = a;
				this.name = b;
			}

			public override string ToString()
			{
				return this.name;
			}

			internal int id;
			internal string name;
		}

        private void отчетРуководителюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StatementsForME.FormReportToManager
            {
                SqlSettings = this.SqlSettings,
                MdiParent = base.MdiParent
            }.Show();
        }
    }
}
