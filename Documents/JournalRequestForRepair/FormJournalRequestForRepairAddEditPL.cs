using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
//using Documents.DataSets;
//using Documents.Forms.RequestForRepair;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using RequestForRepair.DataSets;
//using RequestsClient.Forms.JournalRequestForRepair;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
namespace RequestForRepair
{
    /// <summary>
    /// Журнал аварийных заявок на ремонт оборудования (старый)
    /// Производственная лаборатория
    /// </summary>
    public partial  class FormJournalRequestForRepairAddEditPL : FormBase
    {   
        /// <summary>
        /// Тип заявки (ремонт или авария)
        /// </summary>
        private bool typeRequestRepair;
  

        private DataRow DataRowCurrent;
        //private const int int_2 = 920; //ODS_DIVISION
        //private const int int_3 = 921; //PL_DIVISION
        private int IdRequest = -1;
        private int idDivision_1 = -1;
        private eActionRequestRepair eAction = eActionRequestRepair.Read;
        private DateTime dateTimeBeg = new DateTime(1900, 1, 1);
        private DateTime dateTimeEnd = new DateTime(9000, 1, 1);
        private Dictionary<int, string> dictionary_idSchmObj = new Dictionary<int, string>();
        private int idSR = -1;

        public FormJournalRequestForRepairAddEditPL()
        {
            this.InitializeComponent();
        }

        internal FormJournalRequestForRepairAddEditPL(DataRow row)
        {
            this.InitializeComponent();
            this.IdRequest = -1;
            this.idDivision_1 = Convert.ToInt32(row["idDivision"]);
            this.eAction = eActionRequestRepair.Add;
            this.DataRowCurrent = row;
        }

        internal FormJournalRequestForRepairAddEditPL(int idRequest, int idDivision, eActionRequestRepair action, bool isCrash = false)
        {
            this.InitializeComponent();
            this.IdRequest = idRequest;
            this.idDivision_1 = idDivision;
            this.eAction = action;
            this.typeRequestRepair = isCrash;
        }

        protected override void ApplyConfig(XmlDocument xmlDoc)
        {
            XmlNode node = xmlDoc.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlAttribute attribute = node.Attributes["X"];
                int? nullable = null;
                int? nullable2 = null;
                if (attribute != null)
                {
                    nullable = new int?(Convert.ToInt32(attribute.Value));
                }
                attribute = node.Attributes["Y"];
                if (attribute != null)
                {
                    nullable2 = new int?(Convert.ToInt32(attribute.Value));
                }
                if (nullable.HasValue && nullable2.HasValue)
                {
                    int? nullable3 = nullable;
                    if ((nullable3.GetValueOrDefault() < 0) ? nullable3.HasValue : false)
                    {
                        nullable = 0;
                    }
                    nullable3 = nullable2;
                    if ((nullable3.GetValueOrDefault() < 0) ? nullable3.HasValue : false)
                    {
                        nullable2 = 0;
                    }
                    base.Location = new Point(nullable.Value, nullable2.Value);
                }
                attribute = node.Attributes["SR"];
                if (attribute != null)
                {
                    this.idSR = Convert.ToInt32(attribute.Value);
                }
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("X");
            node.Value = base.Location.X.ToString();
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("Y");
            node.Value = base.Location.Y.ToString();
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("SR");
            if (this.eAction == eActionRequestRepair.Add)
            {
                node.Value = this.cmbSR.SelectedValue.ToString();
            }
            else
            {
                node.Value = this.idSR.ToString();
            }
            node2.Attributes.Append(node);
            return document1;
        }

        private void toolBtnViewDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["Document"];
                string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["FileName"].ToString()));

                FileStream stream1 = File.Create(path);
                stream1.Write(buffer, 0, buffer.Length);
                stream1.Close();
                new Process
                {
                    StartInfo =
                    {
                        FileName = path,
                        UseShellExecute = true
                    }
                }.Start();
            }
        }

        private void toolBtnSaveDoc_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                string path = this.dgvDocs.CurrentRow.Cells[this.dataGridViewLinkColumn_0.Name].Value.ToString();
                string extension = Path.GetExtension(path);
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "(*" + extension + ")|*" + extension,
                    FileName = path
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.method_2(num)["Document"];
                    byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["Document"];
                    FileStream stream1 = File.Create(dialog.FileName);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    MessageBox.Show("Файл успешно сохранен", "Сохранение");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void toolBtnCopy_Click(object sender, EventArgs e)
        {
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                DataRow row = this.dataSetN.tJ_RequestForRepair.NewRow();
                row.ItemArray = this.dataSetN.tJ_RequestForRepair.Rows[0].ItemArray;
                this.dataSetN.tJ_RequestForRepairDoc.Clear();
                this.dataSetN.tJ_RequestForRepairDaily.Clear();
                DataRow row2 = this.dataSetN.tJ_RequestForRepair.NewRow();
                row2["num"] = 0;
                row2["dateCreate"] = DateTime.Now;
                if (row["idWorker"] != DBNull.Value)
                {
                    row2["idWorker"] = row["idWorker"];
                }
                row2["reguestFiled"] = row["reguestFiled"];
                row2["idSR"] = row["idSR"];
                row2["schmObj"] = row["schmObj"];
                row2["Purpose"] = row["Purpose"];
                row2["IsPlanned"] = row["IsPlanned"];
                row2["Crash"] = row["Crash"];
                row2["agreed"] = false;
                row2["iddivision"] = row["iddivision"];
                DataTable table = this.GetTableUser();
                base.SelectSqlData(table, true, " where [Login] = SYSTEM_USER ");
                if (table.Rows.Count > 0)
                {
                    row2["idUserCreate"] = table.Rows[0]["iduser"];
                    if (table.Rows[0]["idWorker"] != DBNull.Value)
                    {
                        row2["IdWorker"] = table.Rows[0]["idWorker"];
                    }
                }
                if (row2["idWorker"] == DBNull.Value)
                {
                    row2["idWorker"] = -1;
                }
                this.IdRequest = -1;
                this.eAction = eActionRequestRepair.Add;
                this.dataSetN.tJ_RequestForRepair.Rows.Add(row2);
                this.dataSetN.tJ_RequestForRepair.Rows.RemoveAt(0);
            }
        }

        private void UpdateSchmObjList()
        {
            foreach (DataRow row in this.dataSetN.tL_RequestForRepairSchmObjList)
            {
                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                {
                    row["idRequest"] = this.IdRequest;
                    row.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            base.UpdateSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            base.DeleteSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void SetVisibleControl()
        {
            DataTable table = new DataTable("tUser");
            table.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(table, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;Dispatchers;' and tuser.login = SYSTEM_USER");
            if (table.Rows.Count == 0)
            {
                this.groupBoxODS.Enabled = false;
                this.dtpDateCreate.Enabled = false;
                this.dtpFactEnd.Enabled = false;
            }
            else
            {
                this.groupBoxODS.Enabled = true;
                this.dtpDateCreate.Enabled = true;
                this.dtpFactEnd.Enabled = true;
            }
        }

        private void CreateCaptionNames()
        {
            if (this.idDivision_1 > 0)
            {
                base.SelectSqlData(this.dataSetN, this.dataSetN.tR_Classifier, true, "where id = " + this.idDivision_1.ToString());
            }
            string str = "";
            if (this.dataSetN.tR_Classifier.Rows.Count > 0)
            {
                str = " " + this.dataSetN.tR_Classifier.Rows[0]["SocrName"].ToString() + " (PL)";
            }
            switch (this.eAction)
            {
                case eActionRequestRepair.Add:
                    if (!this.typeRequestRepair)
                    {
                        this.Text = "Создать новую заявку" + str;
                        return;
                    }
                    this.Text = "Создать новую аварийную заявку" + str;
                    return;

                case eActionRequestRepair.Edit:
                    if (!this.typeRequestRepair)
                    {
                        this.Text = "Редактирование заявки" + str;
                        return;
                    }
                    this.Text = "Редактирование аварийной заявки" + str;
                    return;

                case eActionRequestRepair.Read:
                    if (!this.typeRequestRepair)
                    {
                        this.Text = "Просмотр заявки" + str;
                        return;
                    }
                    this.Text = "Просмотр аварийной заявки" + str;
                    return;
            }
        }

        private void FillComboBoxs()
        {
            DataTable table = this.GetTableUser();
            base.SelectSqlData(table, true, " order by name ");
            this.cmbUserCreate.DataSource = table;
            this.cmbUserCreate.DisplayMember = "NAME";
            this.cmbUserCreate.ValueMember = "IDUSER";

            DataTable table2 = this.GeTabletWorkerGroup();
            base.SelectSqlData(table2, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ");
            this.cmbWorker.DataSource = table2;
            this.cmbWorker.DisplayMember = "FIO";
            this.cmbWorker.ValueMember = "ID";

            this.cmbRequestFiled.DataSource = table2;
            this.cmbRequestFiled.DisplayMember = "FIO";
            this.cmbRequestFiled.ValueMember = "ID";

            DataTable table3 = this.GeTabletWorkerGroup();
            base.SelectSqlData(table3, true, " where ParentKey in (';GroupWorker;ReconcileRequestRepair;')  and dateend is null group by id, fio, groupelectrical order by fio ");
            this.cmbDispatcher.DataSource = table3;
            this.cmbDispatcher.DisplayMember = "FIO";
            this.cmbDispatcher.ValueMember = "ID";

            base.SelectSqlData(this.dataSetN, this.dataSetN.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
            this.cmbSR.DataSource = this.dataSetN.tR_Classifier;
            this.cmbSR.DisplayMember = "name";
            this.cmbSR.ValueMember = "ID";
        }

        private void FillComboBoxStatus()
        {
            this.dataTable_0 = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.dataTable_0, true, "where type = 5 order by name");

            DataTable table = new DataTable("tR_RequestForRepairClient");
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("value", typeof(int));
            this.cmbStatus.DataSource = table;
            this.cmbStatus.DisplayMember = "Name";
            this.cmbStatus.ValueMember = "Value";
            if (table.Rows.Count == 0)
            {
                foreach (DataRow row in this.dataTable_0.Rows)
                {
                    object[] values = new object[] { row["name"], row["Value"] };
                    table.Rows.Add(values);
                }
            }
        }

        private void LoadTableLinkObjects()
        {
            this.dataSetDoc.Tables[this.tableLinkObjects.TableName].Clear();
            if (this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Count > 0)
            {
                DataRow row3;
                DataView defaultView = this.dataSetN.tL_RequestForRepairSchmObjList.DefaultView;
                defaultView.Sort = "Num";
                int num = 0;
                List<string> list = new List<string>();
                DateTime now = DateTime.Now;
                DateTime time2 = DateTime.Now;
                string str = "";
                foreach (DataRow row in defaultView.ToTable().Rows)
                {
                    if (num == Convert.ToInt16(row["num"]))
                    {
                        string[] textArray1 = new string[] { row["idSchmObj"].ToString() };
                        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString());
                    }
                    else
                    {
                        if (list.Count > 0)
                        {
                            list.Sort();
                            DataRow row2 = this.dataSetDoc.Tables[this.tableLinkObjects.TableName].NewRow();
                            row2["Objects"] = "";
                            foreach (string str2 in list)
                            {
                                row3 = row2;
                                row3["Objects"] = row3["Objects"] + str2 + "\n";
                            }
                            row2["Objects"] = ((string)row2["Objects"]).Remove(row2["Objects"].ToString().Length - 1);
                            row2["DateBeg"] = now;
                            row2["DateEnd"] = time2;
                            row2["Duration"] = str;
                            row2["Num"] = num;
                            this.dataSetDoc.Tables[this.tableLinkObjects.TableName].Rows.Add(row2);
                        }
                        list = new List<string>();
                        string[] textArray2 = new string[] { row["idSchmObj"].ToString() };
                        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray2).ToString());
                        now = Convert.ToDateTime(row["DateBeg"]);
                        time2 = Convert.ToDateTime(row["DateEnd"]);
                        str = row["Duration"].ToString();
                        num = Convert.ToInt16(row["Num"]);
                    }
                }
                if (list.Count > 0)
                {
                    list.Sort();
                    DataRow row4 = this.dataSetDoc.Tables[this.tableLinkObjects.TableName].NewRow();
                    row4["Objects"] = "";
                    foreach (string str3 in list)
                    {
                        row3 = row4;
                        row3["Objects"] = row3["Objects"] + str3 + "\n";
                    }
                    row4["Objects"] = ((string)row4["Objects"]).Remove(row4["Objects"].ToString().Length - 1);
                    row4["DateBeg"] = now;
                    row4["DateEnd"] = time2;
                    row4["Duration"] = str;
                    row4["Num"] = num;
                    this.dataSetDoc.Tables[this.tableLinkObjects.TableName].Rows.Add(row4);
                }
                if (this.dataSetDoc.Tables[this.tableLinkObjects.TableName].Rows.Count > 0)
                {
                    this.toolBtnViewSChmObj.Enabled = true;
                }
                else
                {
                    this.toolBtnViewSChmObj.Enabled = false;
                }
            }
        }

        private void LoadTableSchmObjects()
        {
            base.SelectSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.IdRequest.ToString());
            this.LoadTableLinkObjects();
        }

        private void UpdateRepairDoc()
        {
            foreach (DataRow row in this.dataSetN.tJ_RequestForRepairDoc)
            {
                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                {
                    row["idRequest"] = this.IdRequest;
                    row.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void FormJournalRequestForRepairAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if ((this.eAction != eActionRequestRepair.Read) && !this.CheckRequiredFields())
                {
                    MessageBox.Show("Не введены обязательные поля", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    e.Cancel = true;
                }
                else
                {
                    switch (this.eAction)
                    {
                        case eActionRequestRepair.Add:
                            this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                            this.IdRequest = base.InsertSqlDataOneRow(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                            foreach (DataRow row in this.dataSetN.tJ_RequestForRepairDaily)
                            {
                                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                                {
                                    row["idRequest"] = this.IdRequest;
                                    row.EndEdit();
                                }
                            }
                            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            this.UpdateSchmObjList();
                            this.UpdateRepairDoc();
                            break;

                        case eActionRequestRepair.Edit:
                            this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                            foreach (DataRow row2 in this.dataSetN.tJ_RequestForRepairDaily)
                            {
                                if ((row2.RowState != DataRowState.Detached) && (row2.RowState != DataRowState.Deleted))
                                {
                                    row2["idRequest"] = this.IdRequest;
                                    row2.EndEdit();
                                }
                            }
                            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            this.UpdateSchmObjList();
                            this.UpdateRepairDoc();
                            break;
                    }
                }
            }
        }

        private void toolBtnLinkSchmObjEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvLinkObjects.CurrentRow != null)
            {
                DataRow[] rowArray = this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + this.dgvLinkObjects.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString());
                this.dictionary_idSchmObj.Clear();
                if (rowArray.Length != 0)
                {
                    FormLinkRequestAndSchm schm = new FormLinkRequestAndSchm();
                    schm.SqlSettings = (this.SqlSettings);
                    schm.set_DateBeg(Convert.ToDateTime(rowArray[0]["dateBeg"]));
                    schm.set_DateEnd(Convert.ToDateTime(rowArray[0]["dateEnd"]));
                    schm.Duration = rowArray[0]["Duration"].ToString();
                    schm.set_Num(Convert.ToInt16(rowArray[0]["Num"]));
                    foreach (DataRow row in rowArray)
                    {
                        string[] textArray1 = new string[] { row["idSchmObj"].ToString() };
                        this.dictionary_idSchmObj.Add(Convert.ToInt32(row["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString());
                    }
                    schm.set_LinkObjects(this.dictionary_idSchmObj);
                    if (schm.ShowDialog() == DialogResult.OK)
                    {
                        this.dictionary_idSchmObj = schm.GetLinkObjects();
                        foreach (DataRow row2 in rowArray)
                        {
                            if (this.dictionary_idSchmObj.ContainsKey(Convert.ToInt32(row2["idSchmObj"])))
                            {
                                row2["DAteBeg"] = schm.get_DateBeg();
                                row2["DAteEnd"] = schm.get_DateEnd();
                                row2["duration"] = schm.Duration;
                                this.dictionary_idSchmObj.Remove(Convert.ToInt32(row2["idSchmObj"]));
                            }
                            else
                            {
                                row2.Delete();
                            }
                        }
                        foreach (int num2 in this.dictionary_idSchmObj.Keys)
                        {
                            DataRow row3 = this.dataSetN.tL_RequestForRepairSchmObjList.NewRow();
                            row3["idRequest"] = this.IdRequest;
                            row3["idSchmObj"] = num2;
                            row3["DAteBeg"] = schm.get_DateBeg();
                            row3["DAteEnd"] = schm.get_DateEnd();
                            row3["duration"] = schm.Duration;
                            row3["num"] = schm.get_Num();
                            this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Add(row3);
                        }
                        this.LoadTableLinkObjects();
                    }
                }
            }
        }

        private void toolBtnDelSchmObj_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvLinkObjects.SelectedRows)
            {
                DataRow[] rowArray = this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + row.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString());
                for (int i = 0; i < rowArray.Length; i++)
                {
                    rowArray[i].Delete();
                }
            }
            this.LoadTableLinkObjects();
        }

        private void toolBtnViewSChmObj_Click(object sender, EventArgs e)
        {
            this.dictionary_idSchmObj.Clear();
            foreach (DataGridViewRow row in this.dgvLinkObjects.SelectedRows)
            {
                foreach (DataRow row2 in this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + row.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString()))
                {
                    if (!this.dictionary_idSchmObj.ContainsKey(Convert.ToInt32(row2["idSchmObj"])))
                    {
                        this.dictionary_idSchmObj.Add(Convert.ToInt32(row2["idSchmObj"]), "");
                    }
                }
            }
            GoToSchemaEventArgs args = new GoToSchemaEventArgs(this.dictionary_idSchmObj.Keys.ToList<int>());
            this.OnGoToSchema(args);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void toolBtnAddDoc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Multiselect = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        DataRow row = this.dataSetN.tJ_RequestForRepairDoc.NewRow();
                        row["idRequest"] = this.IdRequest;
                        row["Document"] = File.ReadAllBytes(dialog.FileNames[i]);
                        row["FileName"] = Path.GetFileName(dialog.FileNames[i]);
                        this.dataSetN.tJ_RequestForRepairDoc.Rows.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void toolBtnDelDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                this.dgvDocs.Rows.Remove(this.dgvDocs.CurrentRow);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного файла");
            }
        }

        private void FormJournalRequestForRepairAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value.AddMinutes(1.0);
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value.AddMinutes(-1.0);
        }

        private void buttonDaily_Click(object sender, EventArgs e)
        {
            bool flag = false;
            this.dgvDaily.RowsAdded -= new DataGridViewRowsAddedEventHandler(this.dgvDaily_RowsAdded);
            if (this.checkBoxDaily.Checked)
            {
                int num = 0;
                while (true)
                {
                    TimeSpan span = (TimeSpan)(this.dateTimePickerEnd.Value - this.dateTimePickerBeg.Value);
                    if (num > span.Days)
                    {
                        goto Label_022F;
                    }
                    if (this.checkBoxWeekEnd.Checked || ((this.dateTimePickerBeg.Value.AddDays((double)num).DayOfWeek != DayOfWeek.Saturday) && (this.dateTimePickerBeg.Value.AddDays((double)num).DayOfWeek != DayOfWeek.Sunday)))
                    {
                        try
                        {
                            DataRow row = this.dataSetN.tJ_RequestForRepairDaily.NewRow();
                            row["idRequest"] = this.IdRequest;
                            row["dateBeg"] = this.dateTimePickerBeg.Value.AddDays((double)num);
                            row["dateEnd"] = this.dateTimePickerBeg.Value.AddDays((double)num).Date + this.dateTimePickerEnd.Value.TimeOfDay;
                            this.dataSetN.tJ_RequestForRepairDaily.Rows.Add(row);
                            flag = true;
                            this.groupBoxDaily.ForeColor = SystemColors.ControlText;
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    num++;
                }
            }
            try
            {
                DataRow row2 = this.dataSetN.tJ_RequestForRepairDaily.NewRow();
                row2["idRequest"] = this.IdRequest;
                row2["dateBeg"] = this.dateTimePickerBeg.Value;
                row2["dateEnd"] = this.dateTimePickerEnd.Value;
                this.dataSetN.tJ_RequestForRepairDaily.Rows.Add(row2);
                flag = true;
                this.groupBoxDaily.ForeColor = SystemColors.ControlText;
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message, exception2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Label_022F:
            this.dgvDaily.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgvDaily_RowsAdded);
            if (flag)
            {
                //DataRow row3 = this.dataSetN.tJ_RequestForRepairDaily
                //    .Where<DataSetGES.Class51>((C_1.C_9__32_0 ?? (C_1.C_9__32_0 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_5))))
                //    .OrderByDescending<DataSetGES.Class51, DateTime>((C_1.C_9__32_1 ?? (C_1.C_9__32_1 = new Func<DataSetGES.Class51, DateTime>(C_1.C_9.method_6))))
                //    .First<DataSetGES.Class51>();
                DataRow row3 = this.dataSetN.tJ_RequestForRepairDaily
                    .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
                    .OrderByDescending(r => r.dateEnd)
                    .First();

                if (Convert.ToDateTime(row3["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
                {
                    this.dateTimePickerBeg.MaxDate = this.dateTimeEnd;
                }
                this.dateTimePickerBeg.MinDate = Convert.ToDateTime(row3["DateEnd"]);
            }
        }

        private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbWorker.SelectedIndex >= 0)
            {
                this.labelWorker.ForeColor = SystemColors.ControlText;
            }
        }

        private void dgvDaily_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DayOfWeek dayOfWeek = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, e.RowIndex].Value).DayOfWeek;
                DayOfWeek week2 = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, e.RowIndex].Value).DayOfWeek;
                if (((dayOfWeek == DayOfWeek.Sunday) || (dayOfWeek == DayOfWeek.Saturday)) && (this.dgvDaily.Columns[e.ColumnIndex] == this.dateBegDataGridViewTextBoxColumn))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (((week2 == DayOfWeek.Sunday) || (week2 == DayOfWeek.Saturday)) && (this.dgvDaily.Columns[e.ColumnIndex] == this.dateEndDataGridViewTextBoxColumn))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void cmbSR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSR.SelectedIndex >= 0)
            {
                this.labelSR.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtObject_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtObject.Text))
            {
                this.labelObject.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtPurpose_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPurpose.Text))
            {
                this.labelObject.ForeColor = SystemColors.ControlText;
            }
        }

        private void checkBoxAgreed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAgreed.Checked)
            {
                if ((this.dataSetN.tJ_RequestForRepair.Rows.Count > 0) && (this.dateTimePickerDateAgreed.Value == null))
                {
                    object obj2;
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"] = true;
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["DateAgreed"] = obj2 = DateTime.Now;
                    this.dateTimePickerDateAgreed.Value = (obj2);
                }
            }
            else if ((this.dataSetN.tJ_RequestForRepair.Rows.Count > 0) && (this.dateTimePickerDateAgreed.Value != null))
            {
                this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"] = false;
                this.dateTimePickerDateAgreed.Value = (null);
                this.dataSetN.tJ_RequestForRepair.Rows[0]["DateAgreed"] = DBNull.Value;
            }
        }

        private void toolBtnLinkSchmObj_Click(object sender, EventArgs e)
        {
            FormLinkRequestAndSchm schm = new FormLinkRequestAndSchm();
            schm.SqlSettings = (this.SqlSettings);
            if (schm.ShowDialog() == DialogResult.OK)
            {
                int num = 1;
                if (this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Count > 0)
                {
                    //num = this.dataSetN.tL_RequestForRepairSchmObjList
                    //    .Max<DataSetGES.Class53, short>((C_1.C_9__42_0 ?? (C_1.C_9__42_0 = new Func<DataSetGES.Class53, short>(C_1.C_9.method_7)))) + 1;
                    num = this.dataSetN.tL_RequestForRepairSchmObjList
                         .Max(r => r.Num) + 1;
                }
                this.dictionary_idSchmObj = schm.GetLinkObjects();
                foreach (int num2 in this.dictionary_idSchmObj.Keys)
                {
                    DataRow row = this.dataSetN.tL_RequestForRepairSchmObjList.NewRow();
                    row["idRequest"] = this.IdRequest;
                    row["idSchmObj"] = num2;
                    row["DAteBeg"] = schm.get_DateBeg();
                    row["DAteEnd"] = schm.get_DateEnd();
                    row["duration"] = schm.Duration;
                    row["num"] = num;
                    this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Add(row);
                }
                this.LoadTableLinkObjects();
            }
        }

        private void dgvLinkObjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolBtnLinkSchmObjEdit_Click(sender, e);
        }

        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                if (e.ColumnIndex == this.dgvDocs.Columns[this.dataGridViewLinkColumn_0.Name].Index)
                {
                    byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["Document"];
                    string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["FileName"].ToString()));

                    FileStream stream1 = File.Create(path);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    new Process
                    {
                        StartInfo =
                        {
                            FileName = path,
                            UseShellExecute = true
                        }
                    }.Start();
                }
            }
        }

        private void dgvDocs_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (((this.dgvDocs.RowCount > 0) && (this.dgvDocs[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value != null)) && (e.ColumnIndex == this.dgvDocs.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index))
            {
                e.Value = FileInfo.IconOfFile(this.dgvDocs[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString()).ToBitmap();
            }
        }

        private void dgvDaily_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == (this.dgvDaily.Rows.Count - 1))
            {
                DateTime time = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, e.RowIndex].Value);
                if (time > this.dateTimePickerBeg.MaxDate)
                {
                    this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
                }
                this.dateTimePickerBeg.MinDate = time;
            }
        }

        private void FormJournalRequestForRepairAddEdit_Load(object sender, EventArgs e)
        {
            this.dtpDateCreate.Value = (DateTime.Now);
            this.dateTimePickerBeg.Value = DateTime.Now.Date.AddHours(8.0);
            this.dateTimePickerEnd.Value = DateTime.Now.Date.AddHours(17.0);
            this.CreateCaptionNames();
            this.FillComboBoxs();
            this.FillComboBoxStatus();
            this.SetVisibleControl();
            base.LoadFormConfig(null);
            switch (this.eAction)
            {
                case eActionRequestRepair.Add:
                    {
                        if (this.DataRowCurrent == null)
                        {
                            DataRow row2 = this.dataSetN.tJ_RequestForRepair.NewRow();
                            row2["num"] = 0;
                            row2["dateCreate"] = DateTime.Now;
                            row2["idWorker"] = -1;
                            row2["reguestFiled"] = "";
                            row2["idSR"] = this.idSR;
                            row2["schmObj"] = "";
                            row2["Purpose"] = "";
                            row2["Crash"] = this.typeRequestRepair;
                            if (this.typeRequestRepair)
                            {
                                row2["isPlanned"] = false;
                            }
                            else
                            {
                                row2["IsPlanned"] = true;
                            }
                            row2["agreed"] = false;
                            row2["iddivision"] = this.idDivision_1;
                            DataTable table2 = this.GetTableUser();
                            base.SelectSqlData(table2, true, " where [Login] = SYSTEM_USER ");
                            if (table2.Rows.Count > 0)
                            {
                                row2["idUserCreate"] = table2.Rows[0]["iduser"];
                                if (table2.Rows[0]["idWorker"] != DBNull.Value)
                                {
                                    row2["IdWorker"] = table2.Rows[0]["idWorker"];
                                }
                            }
                            this.dataSetN.tJ_RequestForRepair.Rows.Add(row2);
                            if (this.typeRequestRepair)
                            {
                                this.cmbIsPlanned.SelectedIndex = 0;
                            }
                            else
                            {
                                this.cmbIsPlanned.SelectedIndex = 1;
                            }
                            if (this.cmbWorker.SelectedItem != null)
                            {
                                row2["reguestFiled"] = this.cmbWorker.Text;
                            }
                            break;
                        }
                        DataRow row = this.dataSetN.tJ_RequestForRepair.NewRow();
                        row["num"] = 0;
                        row["dateCreate"] = DateTime.Now;
                        row["idWorker"] = this.DataRowCurrent["idWorker"];
                        row["reguestFiled"] = this.DataRowCurrent["reguestFiled"];
                        row["idSR"] = this.DataRowCurrent["idSR"];
                        row["schmObj"] = this.DataRowCurrent["schmObj"];
                        row["Purpose"] = this.DataRowCurrent["Purpose"];
                        row["IsPlanned"] = this.DataRowCurrent["IsPlanned"];
                        row["agreed"] = this.DataRowCurrent["agreed"];
                        row["iddivision"] = this.DataRowCurrent["iddivision"];
                        row["Crash"] = this.DataRowCurrent["Crash"];
                        DataTable table = this.GetTableUser();
                        base.SelectSqlData(table, true, " where [Login] = SYSTEM_USER ");
                        if (table.Rows.Count > 0)
                        {
                            row["idUserCreate"] = table.Rows[0]["iduser"];
                            if (table.Rows[0]["idWorker"] != DBNull.Value)
                            {
                                row["IdWorker"] = table.Rows[0]["idWorker"];
                            }
                        }
                        this.dataSetN.tJ_RequestForRepair.Rows.Add(row);
                        break;
                    }
                case eActionRequestRepair.Edit:
                    if (this.IdRequest > 0)
                    {
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdRequest.ToString());
                        this.LoadTableSchmObjects();
                    }
                    break;

                case eActionRequestRepair.Read:
                    if (this.IdRequest > 0)
                    {
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdRequest.ToString());
                        this.LoadTableSchmObjects();
                    }
                    this.cmbWorker.Enabled = false;
                    this.cmbRequestFiled.Enabled = false;
                    this.cmbSR.Enabled = false;
                    this.txtObject.ReadOnly = true;
                    this.txtPurpose.ReadOnly = true;
                    this.cmbIsPlanned.Enabled = false;
                    this.groupBoxDaily.Enabled = false;
                    this.txtAgreeWith.ReadOnly = true;
                    this.txtComment.ReadOnly = true;
                    this.txtAdress.ReadOnly = true;
                    this.checkBoxAgreed.Enabled = false;
                    this.dateTimePickerDateAgreed.Enabled = false;
                    this.cmbDispatcher.Enabled = false;
                    break;
            }
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.idDivision_1 <= 0)
                {
                    this.idDivision_1 = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["IdDivision"]);
                }
                if (Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"]))
                {
                    this.cmbIsPlanned.SelectedIndex = 1;
                }
                else
                {
                    this.cmbIsPlanned.SelectedIndex = 0;
                }
                if ((this.dataSetN.tJ_RequestForRepair.Rows[0]["Crash"] != DBNull.Value) && Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["Crash"]))
                {
                    this.cmbIsPlanned.Enabled = false;
                }
            }
            if (this.idDivision_1 == 0x399)
            {
                this.groupBoxODS.Visible = false;
            }
        }

        private void groupBoxODS_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.groupBoxODS.Visible)
            {
                this.tabControl.Height = 325;
                base.Height = 391;
                this.buttonCancel.Location = new Point(this.buttonCancel.Location.X, 331);
                this.buttonOK.Location = new Point(this.buttonOK.Location.X, 331);
            }
            else
            {
                this.tabControl.Height = 581;
                base.Height = 647;
                this.buttonCancel.Location = new Point(this.buttonCancel.Location.X, 587);
                this.buttonOK.Location = new Point(this.buttonOK.Location.X, 587);
            }
        }

        private void cmbIsPlanned_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbIsPlanned.SelectedIndex >= 0)
            {
                this.labelIsPlanned.ForeColor = SystemColors.ControlText;
            }
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.cmbIsPlanned.SelectedIndex == 0)
                {
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"] = false;
                }
                else
                {
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"] = true;
                }
            }
        }

        private void checkBoxDaily_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxWeekEnd.Enabled = this.checkBoxDaily.Checked;
        }

        private void dgvDaily_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataRow row = this.dataSetN.tJ_RequestForRepairDaily
                .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
                .OrderByDescending(r => r.dateEnd)
                .First();

            if (Convert.ToDateTime(row["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
            {
                this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
            }
            this.dateTimePickerBeg.MinDate = Convert.ToDateTime(row["DateEnd"]);
        }

        private void dgvDaily_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DateTimePicker)
            {
                if (this.dgvDaily.CurrentCell.OwningColumn.Name == this.dateBegDataGridViewTextBoxColumn.Name)
                {
                    (e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex].Value);
                    if (this.dgvDaily.CurrentCell.RowIndex == 0)
                    {
                        (e.Control as DateTimePicker).MinDate = new DateTime(2000, 1, 1);
                    }
                    if (this.dgvDaily.CurrentCell.RowIndex > 0)
                    {
                        (e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex - 1].Value);
                    }
                }
                if (this.dgvDaily.CurrentCell.OwningColumn.Name == this.dateEndDataGridViewTextBoxColumn.Name)
                {
                    (e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex].Value);
                    if (this.dgvDaily.CurrentCell.RowIndex == (this.dgvDaily.Rows.Count - 1))
                    {
                        (e.Control as DateTimePicker).MaxDate = new DateTime(9998, 12, 31);
                    }
                    if (this.dgvDaily.CurrentCell.RowIndex < (this.dgvDaily.Rows.Count - 1))
                    {
                        (e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex + 1].Value);
                    }
                }
            }
        }

        private bool CheckRequiredFields()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(this.cmbRequestFiled.Text))
            {
                this.labelRequestFiled.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbSR.SelectedIndex < 0)
            {
                this.labelSR.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.txtObject.Text))
            {
                this.labelObject.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.txtPurpose.Text))
            {
                this.labelPurpose.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbIsPlanned.SelectedIndex < 0)
            {
                this.labelIsPlanned.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dataSetN.tJ_RequestForRepairDaily.Rows.Count <= 0)
            {
                List<Color> list = new List<Color>();
                foreach (Control control in this.groupBoxDaily.Controls)
                {
                    list.Add(control.ForeColor);
                }
                this.groupBoxDaily.ForeColor = Color.Red;
                int num = 0;
                
                foreach (object obj in groupBoxDaily.Controls)
                {
                    ((Control)obj).ForeColor = list[num];
                    num++;
                }
                flag = false;
            }
            if ((this.checkBoxAgreed.Checked && (this.idDivision_1 == 920)) && (this.cmbStatus.SelectedIndex < 0))
            {
                this.labelStatus.ForeColor = Color.Red;
                flag = false;
            }
            return flag;
        }

        private DataTable GeTabletWorkerGroup()
        {
            Type dataType = Type.GetType("System.Int32");
            DataTable table = new DataTable("vWorkerGroup");
            DataColumn column = new DataColumn("id", dataType);
            table.Columns.Add(column);
            DataColumn column2 = new DataColumn("fio", Type.GetType("System.String"));
            table.Columns.Add(column2);
            DataColumn column3 = new DataColumn("GroupElectrical", dataType);
            table.Columns.Add(column3);
            table.PrimaryKey = new DataColumn[] { column };
            DataColumn column4 = new DataColumn("GroupRoman", Type.GetType("System.String"))
            {
                Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))"
            };
            table.Columns.Add(column4);
            return table;
        }

        private DataTable GetTableUser()
        {
            Type dataType = Type.GetType("System.Int32");
            DataTable table = new DataTable("tUser");
            DataColumn column = new DataColumn("idUser", dataType);
            table.Columns.Add(column);
            DataColumn column2 = new DataColumn("idWorker", dataType);
            table.Columns.Add(column2);
            DataColumn column3 = new DataColumn("name", Type.GetType("System.String"));
            table.Columns.Add(column3);
            table.PrimaryKey = new DataColumn[] { column };
            return table;
        }

        private void dgvDaily_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataSetN.tJ_RequestForRepairDaily.Rows.Count > 0)
            {
                if (this.dataSetN.tJ_RequestForRepairDaily
                    .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
                    .Count() > 0)
                {
                    DataRow row = this.dataSetN.tJ_RequestForRepairDaily
                        .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
                        .OrderByDescending(r => r.dateEnd)
                        .First();
                    this.dateTimePickerBeg.MinDate = Convert.ToDateTime(row["DateEnd"]);
                }
                else
                {
                    this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
                }
            }
            else
            {
                this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
            }
        }
    }

}