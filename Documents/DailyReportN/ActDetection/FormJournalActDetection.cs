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
using DataSql;
using DailyReportN.Reports;
using FormLbr;
using SchemeModel;
using DailyReportN.DataSet;
/// <summary>
/// Журнал актов расследования
/// </summary>
namespace DailyReportN.JournalActDetection
{
    public partial class FormJournalActDetection : FormBase
    {
        private List<int> listCheckedSubstation;

        public FormJournalActDetection()
        {
            this.InitializeComponent();
            this.toolBTnLoadOld.Visible = false;
        }

        public FormJournalActDetection(List<int> checkedSubstation)
        {
            this.InitializeComponent();
            this.listCheckedSubstation = checkedSubstation;
            this.toolBTnLoadOld.Visible = false;
        }

        private void FormJournalActDetection_Load(object sender, EventArgs e)
        {
            this.Get_VisibleBtnDamageApply();
            this.FillParametersForFilter();
            base.LoadFormConfig(null);
            this.treeViewSchmObjects.SqlSettings = this.SqlSettings;
            this.treeViewSchmObjects.Load(this.listCheckedSubstation);
            this.SearchIdDamage(-1);
        }

        private void FormJournalActDetection_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }
        /// <summary>
        /// Заполним параметры для фильтров
        /// </summary>
        private void FillParametersForFilter()
        {
            this.dtpFilterEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            this.dtpFilterBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.treeViewSchmObjects.ClearTreeChecked();
        }

        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            this.OpenDokument(null, false);
        }

        private void toolBtnEdit_Click(object sender, EventArgs e)
        {
            if (this.bsDamage.Current != null)
            {
                DataRow row = ((DataRowView)this.bsDamage.Current).Row;
                this.OpenDokument(new int?(Convert.ToInt32(row["id"])), false);
            }
        }

        private void toolBtnInfo_Click(object sender, EventArgs e)
        {
            if (this.bsDamage.Current != null)
            {
                DataRow row = ((DataRowView)this.bsDamage.Current).Row;
                this.OpenDokument(new int?(Convert.ToInt32(row["id"])), true);
            }
        }

        private void OpenDokument(int? idDamage = null, bool statusPositioningOnCloseForm = false)
        {
            FormActDetectionAddEdit form = new FormActDetectionAddEdit(idDamage);
            form.SqlSettings = this.SqlSettings;
            form.MdiParent = base.MdiParent;
            form.SetFormViewMode(statusPositioningOnCloseForm);
            if (!statusPositioningOnCloseForm)
            {
                form.FormClosed += new FormClosedEventHandler(this.Dokument_FormClosed);
            }
            form.Show();
        }

        private void Dokument_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is Form && ((Form)sender).DialogResult == DialogResult.OK)
            {
                int idDamage = -1;
                if (sender is FormActDetectionAddEdit && ((FormActDetectionAddEdit)sender).GetIdDocument() != null)
                {
                    idDamage = ((FormActDetectionAddEdit)sender).GetIdDocument().Value;
                }
                this.SearchIdDamage(idDamage);
            }
        }

        private void toolBtnDel_Click(object sender, EventArgs e)
        {
            if (this.bsDamage.Current != null)
            {
                if (this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != DBNull.Value && this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != null && Convert.ToBoolean(this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value))
                {
                    MessageBox.Show("Невозможно удалить исполненный документ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите удалить выбранный документ и подчиненные данному документу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idParentDoc = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
                    if (base.DeleteSqlDataById(this.dsDamage.tJ_Damage, idParentDoc))
                    {
                        this.DeleteDokumentsLink(idParentDoc);
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
        private void DeleteDokumentsLink(int idParent)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = string.Format("update tj_damage \r\n                                                          set idParent = null\r\n                                                          where idParent = {0} and isApply = 1", idParent);
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.CommandText = string.Format("delete tj_damage \r\n                                                          where idParent = {0} and (isApply = 0 or isApply is null)", idParent.ToString());
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
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.txtFind.Text);
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (e.Modifiers == Keys.None)
                {
                    this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
                }
                if (e.Modifiers == Keys.Shift)
                {
                    this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
                }
            }
        }

        private void toolBtnExportExcel_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.ExportToExcel();
        }

        private void toolBtnPrint_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.PrintDataGridView();
        }

        private void toolBtnFilterApply_Click(object sender, EventArgs e)
        {
            this.SearchIdDamage(-1);
        }

        private void toolBtnFilterDelete_Click(object sender, EventArgs e)
        {
            this.FillParametersForFilter();
            this.dgvActDetection.ClearFilter();
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
            if (this.dtpFilterBeg.Value > this.dtpFilterEnd.Value)
            {
                this.dtpFilterEnd.Value = this.dtpFilterBeg.Value;
            }
        }

        private void dtpFilterEnd_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpFilterEnd.Value < this.dtpFilterBeg.Value)
            {
                this.dtpFilterBeg.Value = this.dtpFilterEnd.Value;
            }
        }
        /// <summary>
        /// Поиск строки по idDamage, с позиционированеим
        /// фильрация по подразделениям
        /// </summary>
        private void SearchIdDamage(int IdDamage = -1)
        {
            if (IdDamage == -1 && this.dgvActDetection.CurrentRow != null)
            {
                IdDamage = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
            }
            string text = "select d.*, c_sc.Name as signCrashType, c_sc.Name + ' ' + c_sc.Comment as signCrashName,\r\nc_te.Name as typeEquip, c_te.Name + ' ' + c_te.Comment as typeEquipName,\r\nc_rce.Name as reasonCrashEquipType, c_rce.Name + ' ' + c_rce.Comment as reasonCrashEquipName,\r\nc_rc.Name as reasonCrashType, c_rc.Name + ' ' + c_rc.Comment as reasonCrashName\r\n, Case docParent.TypeDoc when 1401 then 'НН' when 1402 then 'ВН' end Voltage \r\n from vJ_Damage as d\r\nleft join tJ_DamageActDetection as dAct on dAct.idDamage = d.id\r\nleft join tR_Classifier as c_sc on c_sc.Id = dAct.idSignCrash\r\nleft join tR_Classifier as c_te on c_te.Id = dAct.idTypeEquipment\r\nleft join tR_Classifier as c_rce on c_rce.Id = dAct.idReasonCrashEquipment\r\nleft join tR_Classifier as c_rc on c_rc.Id = dAct.idReasonCrash\r\n";
            text += " left join tj_damage docParent on  docParent.id = d.idParent ";
            string text2 = "";
            text2 = string.Format(" where (d.deleted = 0) and   ((d.dateDoc >= '{0}' and d.dateDoc < '{1}') or d.dateDoc is null)", this.dtpFilterBeg.Value.ToString("yyyyMMdd"), this.dtpFilterEnd.Value.AddDays(1.0).ToString("yyyyMMdd"));
            text2 += string.Format(" and (d.TypeDoc = {0}) ", (int)eTypeDocuments.ActDetection);
            List<int> listChecked = this.treeViewSchmObjects.GetListChecked();
            if (listChecked.Count > 0)
            {
                string text3 = "";
                foreach (int num in listChecked)
                {
                    if (string.IsNullOrEmpty(text3))
                    {
                        text3 = num.ToString();
                    }
                    else
                    {
                        text3 = text3 + "," + num.ToString();
                    }
                }
                if (this.checkBoxWhereSub.Checked)
                {
                    text2 += string.Format(" and (d.idSchmObj in ({0}) or d.idSub in ({0}))", text3);
                }
                else
                {
                    text2 += string.Format(" and (d.idSchmObj in ({0}))", text3);
                }
            }
            text += text2;
            text += " order by d.dateDoc desc";
            DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
            this.dgvActDetection.AutoGenerateColumns = false;
            this.bsDamage.DataSource = dataSource;
            this.dgvActDetection.SearchGrid(this.idDataGridViewTextBoxColumn.Name, IdDamage.ToString(), true);
        }

        private void dgvActDetection_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
        private void dgvActDetection_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dgvActDetection[this.VoltageDgvColumn.Name, e.RowIndex].Value.ToString() == "ВН")
                {
                    e.CellStyle.BackColor = Color.LightGray;
                    //this.dgvActDetection[this.VoltageDgvColumn.Name, e.RowIndex].Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }

                if (this.dgvActDetection[this.isApplyDgvColumn.Name, e.RowIndex].Value != DBNull.Value && this.dgvActDetection[this.isApplyDgvColumn.Name, e.RowIndex].Value != null && Convert.ToBoolean(this.dgvActDetection[this.isApplyDgvColumn.Name, e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (this.dgvActDetection[this.dateDocDgvColumn.Name, e.RowIndex].Value != DBNull.Value && this.dgvActDetection[this.dateDocDgvColumn.Name, e.RowIndex].Value != null && Convert.ToDateTime(this.dgvActDetection[this.dateDocDgvColumn.Name, e.RowIndex].Value).Date < DateTime.Now.Date.AddDays(-10.0))
                {
                    e.CellStyle.ForeColor = Color.Red;
                    return;
                }
            }  
        }

        private void dgvActDetection_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvActDetection.AutoResizeRow(e.RowIndex);
        }

        private void dgvActDetection_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void tsMenuAmergencyShutdown_Click(object sender, EventArgs e)
        {
            new FormReportDetectionCrash
            {
                SqlSettings = this.SqlSettings,
                MdiParent = base.MdiParent
            }.Show();
        }

        private void tsMenuReportAccidents_Click(object sender, EventArgs e)
        {
            new FormReportAccidents
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
                            //using (IEnumerator enumerator = dataTable.Rows.GetEnumerator())
                            //{
                            //	while (enumerator.MoveNext())
                            //	{
                            //    DataRow dr = (DataRow)enumerator.Current;
                            foreach (DataRow dr in dataTable.Rows)
                            {

                                if (dr["dateDoc"] != DBNull.Value)
                                {
                                    ElectricModel electricModel = new ElectricModel();
                                    electricModel.SqlSettings = this.SqlSettings;
                                    electricModel.LoadSchema(Convert.ToDateTime(dr["dateDoc"]));
                                    electricModel.PoweringReportForDrawObject(Convert.ToInt32(dr["idSchmObj"]), true);
                                    IEnumerable<ElectricObject> source = from obj in electricModel.Objects
                                                                         where obj.Id == Convert.ToInt32(dr["idSchmObj"])
                                                                         select obj;
                                    if (source.Count<ElectricObject>() > 0)
                                    {
                                        List<ElectricObject> list = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
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

        private void Get_VisibleBtnDamageApply()
        {
            DataTable dataTable = new DataTable("tUser");
            dataTable.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(dataTable, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;DailyReport;AdminActDetection;' and tuser.login = SYSTEM_USER", null, false, 0);
            if (dataTable.Rows.Count > 0)
            {
                this.toolBtnDamageNoApply.Visible = true;
                return;
            }
            this.toolBtnDamageNoApply.Visible = false;
        }

        private void toolBtnDamageNoApply_Click(object sender, EventArgs e)
        {
            if (this.bsDamage.Current != null)
            {
                if (this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != DBNull.Value && this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != null && Convert.ToBoolean(this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value))
                {
                    if (MessageBox.Show("Вы действительно хотите разблокировать текущий документ?", "Разблокировка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                    int num = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
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

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(newChild);
            XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
            xmlDocument.AppendChild(xmlNode);
            XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("dateBeg");
            xmlAttribute.Value = this.dtpFilterBeg.Value.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("dateEnd");
            xmlAttribute.Value = this.dtpFilterEnd.Value.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            return xmlDocument;
        }

        protected override void ApplyConfig(XmlDocument doc)
        {
            List<int> list = new List<int>();
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
            XmlAttribute xmlAttribute2 = xmlNode.Attributes["dateBeg"];
            if (xmlAttribute2.Value != null)
            {
                this.dtpFilterBeg.Value = Convert.ToDateTime(xmlAttribute2.Value);
            }
            xmlAttribute2 = xmlNode.Attributes["dateEnd"];
            if (xmlAttribute2.Value != null)
            {
                this.dtpFilterEnd.Value = Convert.ToDateTime(xmlAttribute2.Value);
            }
        }

        private void contextMenuDamage_Opening(object sender, CancelEventArgs e)
        {
            if (this.bsDamage.Current != null)
            {
                this.toolItemEdit.Enabled = true;
                this.toolItemInfo.Enabled = true;
                this.toolItemDel.Enabled = true;
                return;
            }
            this.toolItemEdit.Enabled = false;
            this.toolItemInfo.Enabled = false;
            this.toolItemDel.Enabled = false;
        }

    }

}