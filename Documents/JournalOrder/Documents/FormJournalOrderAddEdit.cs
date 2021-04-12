using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;

namespace JournalOrder
{
    internal partial class FormJournalOrderAddEdit : FormBase
    {

        private int idOrder = -1;
        private bool isRead = true;
        private DateTime minDate = new DateTime(1900, 1, 1);
        private DateTime maxDate = new DateTime(9000, 1, 1);
        [CompilerGenerated]
        //private int? nullable_0;

        private bool isToResolution = true;

        private Dictionary<int, string> linkObjects = new Dictionary<int, string>();
        internal int? IdDivision { get; set; }

        public int IdOrder
        {
            get
            {
                return this.idOrder;
            }
        }

        internal FormJournalOrderAddEdit()
        {
            this.InitializeComponent();
        }

        internal FormJournalOrderAddEdit(int id, bool isRead)
        {
            this.InitializeComponent();
            this.idOrder = id;
            this.isRead = isRead;
            this.brigadeWorkerColumn.AutoComplete = true;
        }

        private void FormJournalOrderAddEdit_Load(object sender, EventArgs e)
        {
            this.InitCmdDivision();
            if (this.idOrder < 0)
            {
                DateTime now = DateTime.Now;
                this.dateTimePickerDateEndExt.Value = null;
                this.dateTimePickerDateBegin.Value = now;
                this.dateTimePickerDateBegin.Value = null;
                this.dateTimePickerDateOutput.Value = now;
                this.dateTimePickerDateOutput.Value = null;
                this.dateTimePickerDateBegin.MaxDate = this.maxDate;
                this.dateTimePickerResolution.MinDate = this.minDate;
                if (this.dateTimePickerDateOutput.Value != null)
                {
                    this.dateTimePickerDateEnd.MinDate = (DateTime)this.dateTimePickerDateOutput.Value;
                }
                else
                {
                    this.dateTimePickerDateOutput.MinDate = this.minDate;
                }
                if (this.dateTimePickerDateEnd.Value != null)
                {
                    this.dateTimePickerDateOutput.MaxDate = (DateTime)this.dateTimePickerDateEnd.Value;
                }
                else
                {
                    this.dateTimePickerDateOutput.MaxDate = this.maxDate;
                }
            }
            base.LoadFormConfig(null);
            if (base.Location.X < 0)
            {
                base.Location = new Point(0, base.Location.Y);
            }
            if (base.Location.Y < 0)
            {
                base.Location = new Point(base.Location.X, 0);
            }
            if (base.Right > base.Parent.Right)
            {
                base.Width -= base.Right - base.Parent.Right;
            }
            if (base.Bottom > base.Parent.Bottom)
            {
                base.Height -= base.Bottom - base.Parent.Bottom;
            }
            this.InitNetworkAreas();
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vWorkerGroup, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;', ';GroupWorker;Dispatchers;')  and dateend is null order by fio ");
            DataSet.DataSetOrder dataSetOrder = new DataSet.DataSetOrder();
            this.idJobTitleDgvColumn.DataSource = dataSetOrder;
            this.idJobTitleDgvColumn.ValueMember = "tR_Classifier.Id";
            this.idJobTitleDgvColumn.DisplayMember = "tR_Classifier.Name";
            base.SelectSqlData(dataSetOrder, dataSetOrder.tR_Classifier, true, " where parentkey = ';Other;JobTitle;' and isgroup = 0 and deleted = 0 order by [name]");
            this.InitCmbWorker();
            if (this.idOrder == -1)
            {
                this.Text = "Новый наряд";
                if (this.IdDivision != null && this.cmbDivision.Visible)
                {
                    this.cmbDivision.SelectedValue = this.IdDivision;
                }
            }
            else
            {
                this.toolBtnCopyOrder.Enabled = true;
                this.toolBtnReport.Enabled = true;
                this.Load_Order();
                base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderBrigade, true, " where idorder = " + this.idOrder.ToString());
                base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderInstruction, true, " where idorder = " + this.idOrder.ToString() + " order by rec_num");
                base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderResolution, true, " where idorder = " + this.idOrder.ToString() + " order by datebegin ");
                base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tL_OrderSchmObjList, true, " where idOrder = " + this.idOrder.ToString());
                this.linkObjects.Clear();
                foreach (DataRow dataRow in this.dataSetOrder.tL_OrderSchmObjList)
                {
                    this.linkObjects.Add(Convert.ToInt32(dataRow["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                    dataRow["idSchmObj"].ToString()
                    }).ToString());
                }
                if (this.linkObjects.Count > 0)
                {
                    this.toolBtnViewSChmObj.Enabled = true;
                }
                this.LoadLinkObjkectsListBox();
                if (this.isRead)
                {
                    this.Text = "Просмотр наряда №" + this.dataSetOrder.tJ_Order.Rows[0]["num"].ToString();
                }
                else
                {
                    this.Text = "Редактирование наряда №" + this.dataSetOrder.tJ_Order.Rows[0]["num"].ToString();
                }
                if (this.dateTimePickerDateEndExt.Value != null)
                {
                    if (this.dateTimePickerDateOutput.MaxDate > (DateTime)this.dateTimePickerDateEndExt.Value)
                    {
                        this.dateTimePickerDateOutput.MaxDate = (DateTime)this.dateTimePickerDateEndExt.Value;
                    }
                    this.dateTimePickerResolution.MaxDate = (DateTime)this.dateTimePickerDateEndExt.Value;
                }
            }
            this.InitControls();
        }

        private void FormJournalOrderAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalOrderAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dataSetOrder.tJ_Order.Rows.Count > 0 && (this.dataSetOrder.tJ_Order.Rows[0]["Registered"] == DBNull.Value || !Convert.ToBoolean(this.dataSetOrder.tJ_Order.Rows[0]["Registered"])))
            {
                this.dataSetOrder.tJ_Order.Rows[0].EndEdit();
                DataTable changes = this.dataSetOrder.tJ_Order.GetChanges();
                if (changes != null && changes.Rows.Count > 0)
                {
                    if (MessageBox.Show("Сохранить внесенные изменения в наряд?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (this.IsCanSave())
                        {
                            this.Save_Order();
                            return;
                        }
                        e.Cancel = false;
                        return;
                    }
                }
                else
                {
                    foreach (DataRow dataRow in this.dataSetOrder.tJ_OrderBrigade.Rows)
                    {
                        if (dataRow.RowState != DataRowState.Deleted)
                        {
                            if (Convert.ToInt32(dataRow["idorder"]) != this.IdOrder)
                            {
                                dataRow["idorder"] = this.idOrder;
                            }
                            dataRow.EndEdit();
                        }
                    }
                    changes = this.dataSetOrder.tJ_OrderBrigade.GetChanges();
                    if (changes != null && changes.Rows.Count > 0)
                    {
                        if (MessageBox.Show("Сохранить внесенные изменения в наряд?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (this.IsCanSave())
                            {
                                this.Save_Order();
                                return;
                            }
                            e.Cancel = false;
                            return;
                        }
                    }
                    else
                    {
                        int i = 0;
                        foreach (DataRow dataRow2 in this.dataSetOrder.tJ_OrderInstruction.Rows)
                        {
                            if (dataRow2.RowState != DataRowState.Deleted)
                            {
                                if (Convert.ToInt32(dataRow2["idorder"]) != this.IdOrder)
                                {
                                    dataRow2["idorder"] = this.idOrder;
                                }
                                if (dataRow2["rec_num"] == DBNull.Value || Convert.ToInt32(dataRow2["rec_num"]) != i++)
                                {
                                    dataRow2["rec_num"] = i;
                                }
                                dataRow2.EndEdit();
                            }
                        }
                        changes = this.dataSetOrder.tJ_OrderInstruction.GetChanges();
                        if (changes != null && changes.Rows.Count > 0)
                        {
                            if (MessageBox.Show("Сохранить внесенные изменения в наряд?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (this.IsCanSave())
                                {
                                    this.Save_Order();
                                    return;
                                }
                                e.Cancel = false;
                                return;
                            }
                        }
                        else
                        {
                            foreach (int num in this.linkObjects.Keys)
                            {
                                if (this.dataSetOrder.tL_OrderSchmObjList.Select(" idSChmObj = " + num.ToString()).Length == 0)
                                {
                                    DataRow dataRow3 = this.dataSetOrder.tL_OrderSchmObjList.NewRow();
                                    dataRow3["idOrder"] = this.IdOrder;
                                    dataRow3["idSchmObj"] = num;
                                    this.dataSetOrder.tL_OrderSchmObjList.Rows.Add(dataRow3);
                                }
                            }
                            for (i = 0; i < this.dataSetOrder.tL_OrderSchmObjList.Rows.Count; i++)
                            {
                                if (this.dataSetOrder.tL_OrderSchmObjList.Rows[i].RowState != DataRowState.Deleted && !this.linkObjects.ContainsKey(Convert.ToInt32(this.dataSetOrder.tL_OrderSchmObjList.Rows[i]["idSChmObj"])))
                                {
                                    this.dataSetOrder.tL_OrderSchmObjList.Rows[i].Delete();
                                }
                            }
                            changes = this.dataSetOrder.tL_OrderSchmObjList.GetChanges();
                            if (changes != null && changes.Rows.Count > 0 && MessageBox.Show("Сохранить внесенные изменения в наряд?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (this.IsCanSave())
                                {
                                    this.Save_Order();
                                    return;
                                }
                                e.Cancel = false;
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void InitNetworkAreas()
        {
            if (this.IdDivision == null && this.IdOrder > 0)
            {
                DataTable dataTable = new DataTable("tJ_Order");
                dataTable.Columns.Add("idDivision", typeof(int));
                base.SelectSqlData(dataTable, true, " where id = " + this.IdOrder.ToString(), null, false, 0);
                if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["idDivision"] != DBNull.Value)
                {
                    this.IdDivision = new int?(Convert.ToInt32(dataTable.Rows[0]["idDivision"]));
                }
            }
            if (this.IdDivision != null)
            {
                base.SelectSqlData(this.dataSetOrder.tR_Classifier, true, string.Format(" where ParentId = {0} and isGRoup = 0 and deleted = 0 ", this.IdDivision.Value), null, false, 0);
            }
            if (this.dataSetOrder.tR_Classifier.Rows.Count == 0)
            {
                base.SelectSqlData(this.dataSetOrder.tR_Classifier, true, " where parentkey = ';NetworkAreas;' and isgroup = 0 and deleted = 0", null, false, 0);
            }
        }

        private void InitCmdDivision()
        {
            DataTable dataTable = new DataTable("tR_Classifier");
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("value", typeof(decimal));
            base.SelectSqlData(dataTable, true, " where ((ParentKey = ';Other;DivisionOrder;' and isGRoup = 0) " +
                "  or (ParentKey like ';Other;DivisionOrder;%;' and isGRoup = 1)) and deleted = 0 ", null, false, 0);
            if (dataTable.Rows.Count == 0)
            {
                this.labelDivision.Visible = false;
                this.cmbDivision.Visible = false;
                return;
            }
            this.cmbDivision.DisplayMember = "name";
            this.cmbDivision.ValueMember = "id";
            this.cmbDivision.DataSource = dataTable;
        }

        private DataTable InitTableWork()
        {
            Type type = Type.GetType("System.Int32");
            DataTable dataTable = new DataTable("vWorkerGroup");
            DataColumn dataColumn = new DataColumn("id", type);
            dataTable.Columns.Add(dataColumn);
            DataColumn column = new DataColumn("fio", Type.GetType("System.String"));
            dataTable.Columns.Add(column);
            DataColumn column2 = new DataColumn("GroupElectrical", type);
            dataTable.Columns.Add(column2);
            dataTable.PrimaryKey = new DataColumn[]
            {
            dataColumn
            };
            DataColumn dataColumn2 = new DataColumn("GroupRoman", Type.GetType("System.String"));
            dataColumn2.Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))";
            dataTable.Columns.Add(dataColumn2);
            DataColumn dataColumn3 = new DataColumn("fioGroup", Type.GetType("System.String"));
            dataColumn3.Expression = "fio + ' (' + GroupRoman + ')'";
            dataTable.Columns.Add(dataColumn3);
            return dataTable;
        }

        private void InitCmbWorker()
        {
            DataTable dataTable = this.InitTableWork();
            base.SelectSqlData(dataTable, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.cmbHeadWorker.DataSource = dataTable;
            this.cmbHeadWorker.DisplayMember = "FIOGROUP";
            this.cmbHeadWorker.ValueMember = "ID";
            DataTable dataTable2 = this.InitTableWork();
            base.SelectSqlData(dataTable2, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;', ';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.cmbAcceptWorker.DataSource = dataTable2;
            this.cmbAcceptWorker.DisplayMember = "FIOGROUP";
            this.cmbAcceptWorker.ValueMember = "ID";
            DataTable dataTable3 = this.InitTableWork();
            base.SelectSqlData(dataTable3, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.cmbWatchWorker.DataSource = dataTable3;
            this.cmbWatchWorker.DisplayMember = "FIOGROUP";
            this.cmbWatchWorker.ValueMember = "ID";
            DataTable dataTable4 = this.InitTableWork();
            base.SelectSqlData(dataTable4, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.cmbMakerWorker.DataSource = dataTable4;
            this.cmbMakerWorker.DisplayMember = "FIOGROUP";
            this.cmbMakerWorker.ValueMember = "ID";
            DataTable dataTable5 = this.InitTableWork();
            base.SelectSqlData(dataTable5, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.cmbOutputWorker.DataSource = dataTable5;
            this.cmbOutputWorker.DisplayMember = "FIOGROUP";
            this.cmbOutputWorker.ValueMember = "ID";
            DataTable dataTable6 = this.InitTableWork();
            base.SelectSqlData(dataTable6, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.cmbExtWorker.DataSource = dataTable6;
            this.cmbExtWorker.DisplayMember = "FIOGROUP";
            this.cmbExtWorker.ValueMember = "ID";
            DataTable dataTable7 = this.InitTableWork();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable7;
            base.SelectSqlData(dataTable7, true, " where ParentKey in (';GroupWorker;Workers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.brigadeWorkerColumn.DataSource = bindingSource;
            this.brigadeWorkerColumn.DisplayMember = "FIOGROUP";
            this.brigadeWorkerColumn.ValueMember = "ID";
            this.InitCloseWorker();
        }

        private void InitCloseWorker()
        {
            int? idDivision = null;
            if (this.idOrder > 0)
            {
                DataTable dataTable = new DataTable("tJ_Order");
                dataTable.Columns.Add("idDivision", typeof(int));
                base.SelectSqlData(dataTable, true, " where id = " + this.idOrder.ToString(), null, false, 0);
                if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["idDivision"] != DBNull.Value)
                {
                    idDivision = new int?(Convert.ToInt32(dataTable.Rows[0]["idDivision"]));
                }
            }
            if (idDivision == null)
            {
                idDivision = this.IdDivision;
            }
            decimal? TypeDispatchers = null;
            if (idDivision != null)
            {
                DataTable dataTable2 = new DataTable("tR_Classifier");
                dataTable2.Columns.Add("Value", typeof(decimal));
                base.SelectSqlData(dataTable2, true, "where id = " + idDivision.ToString(), null, false, 0);
                if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["Value"] != DBNull.Value)
                {
                    TypeDispatchers = new decimal?(Convert.ToDecimal(dataTable2.Rows[0]["Value"]));
                }
            }
            DataTable dataTable3 = this.InitTableWork();
            if (TypeDispatchers == 2)
            {
                base.SelectSqlData(dataTable3, true, " where ParentKey in (';GroupWorker;DispatchersSESNO;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            }
            else
            {
                base.SelectSqlData(dataTable3, true, " where ParentKey in (';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            }
            this.workerResolutionColumn.DataSource = dataTable3;
            this.workerResolutionColumn.DisplayMember = "FIOGROUP";
            this.workerResolutionColumn.ValueMember = "ID";
            this.cmbWorkerResolution.DataSource = dataTable3;
            this.cmbWorkerResolution.DisplayMember = "FIOGROUP";
            this.cmbWorkerResolution.ValueMember = "ID";
            DataTable dataTable4 = this.InitTableWork();
            if (TypeDispatchers == 2)
            {
                base.SelectSqlData(dataTable4, true, " where ParentKey in (';GroupWorker;DispatchersSESNO;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            }
            else
            {
                base.SelectSqlData(dataTable4, true, " where ParentKey in (';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            }
            this.cmbCloseWorker.DataSource = dataTable4;
            this.cmbCloseWorker.DisplayMember = "FIOGROUP";
            this.cmbCloseWorker.ValueMember = "ID";
        }

        private void InitControls()
        {
            this.cmbWorkerResolution.SelectedIndex = -1;
            if (this.idOrder == -1)
            {
                this.dateTimePickerDateBegin.Value = null;
                this.dateTimePickerDateEnd.Value = null;
                this.txtNumOrder.BackColor = Color.Yellow;
                this.cmbSR.SelectedIndex = -1;
                this.cmbHeadWorker.SelectedIndex = -1;
                this.cmbAcceptWorker.SelectedIndex = -1;
                this.cmbWatchWorker.SelectedIndex = -1;
                this.cmbMakerWorker.SelectedIndex = -1;
                this.cmbOutputWorker.SelectedIndex = -1;
                this.dateTimePickerDateOutput.Value = null;
                this.cmbExtWorker.SelectedIndex = -1;
                this.dateTimePickerDateEndExt.Value = null;
                this.buttonRegister.Enabled = false;
            }
            else if (this.dataSetOrder.tJ_Order.Rows.Count > 0)
            {
                if (Convert.ToBoolean(this.dataSetOrder.tJ_Order.Rows[0]["Registered"]))
                {
                    this.txtNumOrder.BackColor = Color.White;
                    this.panelExtension.Enabled = true;
                    this.dateTimePickerDateBegin.Enabled = false;
                    this.dateTimePickerDateEnd.Enabled = false;
                    this.cmbSR.Enabled = false;
                    this.cmbHeadWorker.Enabled = false;
                    this.cmbAcceptWorker.Enabled = false;
                    this.cmbWatchWorker.Enabled = false;
                    this.cmbMakerWorker.Enabled = false;
                    this.cmbOutputWorker.Enabled = false;
                    this.richTxtInstruction.ReadOnly = true;
                    this.richTxtOtrherInstructions.ReadOnly = true;
                    this.dateTimePickerDateOutput.Enabled = false;
                    this.dgvBrigade.ReadOnly = true;
                    this.dgvBrigade.AllowUserToAddRows = false;
                    this.dgvInstruction.ReadOnly = true;
                    this.dgvInstruction.AllowUserToAddRows = false;
                    this.buttonRegister.Enabled = false;
                    this.buttonSave.Enabled = false;
                    this.toolBtnDelSchmObj.Enabled = false;
                    this.toolBtnLinkSchmObj.Enabled = false;
                    this.cmbWorkerResolution.Enabled = true;
                    int count = this.dataSetOrder.tJ_OrderResolution.Rows.Count;
                    if (count > 0)
                    {
                        this.txtNumOrder.BackColor = Color.LawnGreen;
                        if (this.dataSetOrder.tJ_OrderResolution.Rows[count - 1]["DateEnd"] == DBNull.Value)
                        {
                            this.dateTimePickerResolution.MinDate = (DateTime)this.dataSetOrder.tJ_OrderResolution.Rows[count - 1]["DateBegin"];
                            if (this.dateTimePickerResolution.MinDate <= DateTime.Now)
                            {
                                if (this.dateTimePickerResolution.MaxDate >= DateTime.Now)
                                {
                                    this.dateTimePickerResolution.Value = DateTime.Now;
                                }
                                else
                                {
                                    this.dateTimePickerResolution.Value = this.dateTimePickerResolution.MaxDate;
                                }
                            }
                            else
                            {
                                this.dateTimePickerResolution.Value = this.dateTimePickerResolution.MinDate;
                            }
                            this.buttonResolution.Text = "Закончить работу";
                            this.cmbWorkerResolution.Enabled = false;
                            this.isToResolution = false;
                        }
                        else
                        {
                            this.dateTimePickerResolution.MinDate = (DateTime)this.dataSetOrder.tJ_OrderResolution.Rows[count - 1]["DateEnd"];
                            this.dateTimePickerResolution.Value = null;
                            this.buttonResolution.Text = "Выдать разрешение";
                            this.cmbWorkerResolution.Enabled = true;
                            this.isToResolution = true;
                        }
                    }
                    else
                    {
                        this.dateTimePickerResolution.Value = null;
                    }
                    this.dateTimePickerResolution.Enabled = true;
                    this.buttonResolution.Enabled = true;
                    this.cmbCloseWorker.Enabled = true;
                    this.dateTimePickerClose.Enabled = true;
                    this.buttonCloseOrder.Enabled = true;
                    if (Convert.ToDateTime(this.dateTimePickerDateEnd.Value) < DateTime.Now)
                    {
                        //if (this.dateTimePickerDateEndExt.Value != null)
                        //{
                        //	if (this.dateTimePickerDateEndExt.Value != DBNull.Value)
                        //	{
                        //		if (Convert.ToDateTime(this.dateTimePickerDateEndExt.Value) < DateTime.Now)
                        //		{
                        //			this.buttonResolution.Enabled = false;
                        //                           goto IL_567;
                        //                       }
                        //                       goto IL_567;
                        //                   }
                        //               }
                        //this.buttonResolution.Enabled = false;

                        if (this.dateTimePickerDateEndExt.Value == null)
                        {
                            this.buttonResolution.Enabled = false;
                        }
                        else if (this.dateTimePickerDateEndExt.Value != null && this.dateTimePickerDateEndExt.Value == DBNull.Value)
                        {
                            this.buttonResolution.Enabled = false;
                        }
                        else if (Convert.ToDateTime(this.dateTimePickerDateEndExt.Value) < DateTime.Now)
                        {
                            this.buttonResolution.Enabled = false;
                        }
                        //if (this.dateTimePickerDateEndExt.Value == null || this.dateTimePickerDateEndExt.Value == DBNull.Value)
                        //{
                        //    this.buttonResolution.Enabled = false;
                        //}
                        //else if (Convert.ToDateTime(this.dateTimePickerDateEndExt.Value) < DateTime.Now)
                        //{
                        //    this.buttonResolution.Enabled = false;
                        //}

                    }
                }
                else
                {
                    this.txtNumOrder.BackColor = Color.Yellow;
                    this.panelExtension.Enabled = false;
                    this.dateTimePickerDateBegin.Enabled = true;
                    this.dateTimePickerDateEnd.Enabled = true;
                    this.cmbSR.Enabled = true;
                    this.cmbHeadWorker.Enabled = true;
                    this.cmbAcceptWorker.Enabled = true;
                    this.cmbWatchWorker.Enabled = true;
                    this.cmbMakerWorker.Enabled = true;
                    this.cmbOutputWorker.Enabled = true;
                    this.richTxtInstruction.ReadOnly = false;
                    this.richTxtOtrherInstructions.ReadOnly = false;
                    this.dateTimePickerDateOutput.Enabled = true;
                    this.dgvBrigade.ReadOnly = false;
                    this.dgvBrigade.AllowUserToAddRows = true;
                    this.dgvInstruction.ReadOnly = false;
                    this.dgvInstruction.AllowUserToAddRows = true;
                    this.buttonRegister.Enabled = true;
                    this.buttonSave.Enabled = true;
                    this.toolBtnDelSchmObj.Enabled = true;
                    this.toolBtnLinkSchmObj.Enabled = true;
                }
                //IL_567:
                if (this.dataSetOrder.tJ_Order.Rows[0]["dateClose"] != DBNull.Value)
                {
                    this.txtNumOrder.BackColor = Color.Gray;
                    this.panelExtension.Enabled = false;
                    this.cmbWorkerResolution.Enabled = false;
                    this.dateTimePickerResolution.Enabled = false;
                    this.buttonResolution.Enabled = false;
                    this.cmbCloseWorker.Enabled = false;
                    this.dateTimePickerClose.Enabled = false;
                    this.buttonCloseOrder.Enabled = false;
                }
                if (this.dataSetOrder.tJ_Order.Rows[0]["dateEndExt"] != DBNull.Value)
                {
                    this.buttonExtension.Visible = false;
                    this.panelExtension.Enabled = false;
                }
            }
            if (this.isRead)
            {
                this.dateTimePickerDateBegin.Enabled = false;
                this.dateTimePickerDateEnd.Enabled = false;
                this.cmbSR.Enabled = false;
                this.cmbHeadWorker.Enabled = false;
                this.cmbAcceptWorker.Enabled = false;
                this.cmbWatchWorker.Enabled = false;
                this.cmbMakerWorker.Enabled = false;
                this.cmbOutputWorker.Enabled = false;
                this.richTxtInstruction.ReadOnly = true;
                this.richTxtOtrherInstructions.ReadOnly = true;
                this.dateTimePickerDateOutput.Enabled = false;
                this.dgvBrigade.ReadOnly = true;
                this.dgvBrigade.AllowUserToAddRows = false;
                this.dgvInstruction.ReadOnly = true;
                this.dgvInstruction.AllowUserToAddRows = false;
                this.buttonRegister.Enabled = false;
                this.buttonSave.Enabled = false;
                this.cmbWorkerResolution.Enabled = false;
                this.cmbWorkerResolution.Enabled = false;
                this.dateTimePickerResolution.Enabled = false;
                this.buttonResolution.Enabled = false;
                this.cmbCloseWorker.Enabled = false;
                this.dateTimePickerClose.Enabled = false;
                this.buttonCloseOrder.Enabled = false;
            }
            if (base.PermissionsControlsEnabled || base.PermissionsControlsVisible)
            {
                base.SetControlsPropertiesUser();
            }
        }

        private void dateTimePickerDateBegin_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePickerDateBegin.Value != null)
            {
                this.labelDateBegin.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                this.dateTimePickerDateEnd.MaxDate = Convert.ToDateTime(this.dateTimePickerDateBegin.Value).AddDays(15.0);
                this.dateTimePickerDateEnd.MinDate = (DateTime)this.dateTimePickerDateBegin.Value;
                this.dateTimePickerDateOutput.MaxDate = (DateTime)this.dateTimePickerDateBegin.Value;
                this.dateTimePickerResolution.MinDate = (DateTime)this.dateTimePickerDateBegin.Value;
                return;
            }
            this.dateTimePickerDateEnd.MaxDate = this.maxDate;
            this.dateTimePickerResolution.MinDate = this.minDate;
            if (this.dateTimePickerDateOutput.Value != null)
            {
                this.dateTimePickerDateEnd.MinDate = (DateTime)this.dateTimePickerDateOutput.Value;
            }
            else
            {
                this.dateTimePickerDateOutput.MinDate = this.minDate;
            }
            if (this.dateTimePickerDateEnd.Value != null)
            {
                this.dateTimePickerDateOutput.MaxDate = (DateTime)this.dateTimePickerDateEnd.Value;
                return;
            }
            this.dateTimePickerDateOutput.MaxDate = this.maxDate;
        }

        private void dateTimePickerDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePickerDateEnd.Value != null)
            {
                this.labelDateEnd.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                this.dateTimePickerDateBegin.MaxDate = (DateTime)this.dateTimePickerDateEnd.Value;
                if (this.dateTimePickerDateOutput.Value != null && Convert.ToDateTime(this.dateTimePickerDateOutput.Value) > Convert.ToDateTime(this.dateTimePickerDateEnd.Value).AddDays(-15.0))
                {
                    this.dateTimePickerDateBegin.MinDate = (DateTime)this.dateTimePickerDateOutput.Value;
                }
                else
                {
                    this.dateTimePickerDateBegin.MinDate = Convert.ToDateTime(this.dateTimePickerDateEnd.Value).AddDays(-15.0);
                }
                if (this.dateTimePickerDateOutput.MaxDate > (DateTime)this.dateTimePickerDateEnd.Value)
                {
                    this.dateTimePickerDateOutput.MaxDate = (DateTime)this.dateTimePickerDateEnd.Value;
                }
                if (this.dateTimePickerDateEndExt.Value != null)
                {
                    this.dateTimePickerResolution.MaxDate = (DateTime)this.dateTimePickerDateEndExt.Value;
                }
                else
                {
                    this.dateTimePickerResolution.MaxDate = (DateTime)this.dateTimePickerDateEnd.Value;
                }
                this.dateTimePickerDateEndExt.MinDate = (DateTime)this.dateTimePickerDateEnd.Value;
                return;
            }
            this.dateTimePickerDateEndExt.MinDate = this.minDate;
            this.dateTimePickerDateBegin.MaxDate = this.maxDate;
            this.dateTimePickerResolution.MaxDate = this.maxDate;
            if (this.dateTimePickerDateOutput.Value != null)
            {
                this.dateTimePickerDateBegin.MinDate = (DateTime)this.dateTimePickerDateOutput.Value;
            }
            else
            {
                this.dateTimePickerDateBegin.MinDate = this.minDate;
            }
            if (this.dateTimePickerDateBegin.Value != null)
            {
                this.dateTimePickerDateOutput.MaxDate = (DateTime)this.dateTimePickerDateBegin.Value;
                return;
            }
            this.dateTimePickerDateOutput.MaxDate = this.maxDate;
        }

        private void dateTimePickerDateOutput_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePickerDateOutput.Value != null)
            {
                this.labelOutputDate.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                if (this.cmbOutputWorker.SelectedValue != null)
                {
                    this.labelOutput.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                }
                if (this.dateTimePickerDateEnd.Value != null && Convert.ToDateTime(this.dateTimePickerDateOutput.Value) < Convert.ToDateTime(this.dateTimePickerDateEnd.Value).AddDays(-15.0))
                {
                    this.dateTimePickerDateBegin.MinDate = Convert.ToDateTime(this.dateTimePickerDateEnd.Value).AddDays(-15.0);
                }
                else
                {
                    this.dateTimePickerDateBegin.MinDate = (DateTime)this.dateTimePickerDateOutput.Value;
                }
                if (this.dateTimePickerDateEnd.MinDate < (DateTime)this.dateTimePickerDateOutput.Value)
                {
                    this.dateTimePickerDateEnd.MinDate = (DateTime)this.dateTimePickerDateOutput.Value;
                }
                this.dateTimePickerClose.MinDate = (DateTime)this.dateTimePickerDateOutput.Value;
                return;
            }
            this.dateTimePickerDateBegin.MinDate = this.minDate;
            if (this.dateTimePickerDateBegin.Value != null)
            {
                this.dateTimePickerDateEnd.MinDate = (DateTime)this.dateTimePickerDateBegin.Value;
                return;
            }
            this.dateTimePickerDateEnd.MinDate = this.minDate;
        }

        private void richTxtInstruction_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.richTxtInstruction.Text))
            {
                this.labelInstruction.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void cmbSR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbSR.SelectedValue != null)
            {
                this.labelSR.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void cmbAcceptWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbAcceptWorker.SelectedValue != null)
            {
                this.labelAccept.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void cmbMakerWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbMakerWorker.SelectedValue != null)
            {
                this.labelMaker.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void cmbOutputWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbOutputWorker.SelectedValue != null && this.dateTimePickerDateOutput.Value != null)
            {
                this.labelOutput.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.IsCanSave())
            {
                this.Save_Order();
            }
        }

        private void Load_Order()
        {
            if (this.IdOrder > 0)
            {
                base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_Order, true, " where id = " + this.idOrder);
                if (this.dataSetOrder.tJ_Order.Rows.Count > 0)
                {
                    this.dateTimePickerClose.Value = this.dataSetOrder.tJ_Order.Rows[0]["DateClose"];
                    this.cmbCloseWorker.SelectedValue = this.dataSetOrder.tJ_Order.Rows[0]["closeWorker"];
                    if (this.cmbDivision.Visible && this.dataSetOrder.tJ_Order.Rows[0]["idDivision"] == DBNull.Value)
                    {
                        DataRow[] array = ((DataTable)this.cmbDivision.DataSource).Select("VAlue = 1");
                        if (array.Length != 0)
                        {
                            this.cmbDivision.SelectedValue = array[0]["id"];
                        }
                    }
                }
            }
        }

        private bool Save_Order()
        {
            if (this.idOrder != -1)
            {
                this.dataSetOrder.tJ_Order.Rows[0].EndEdit();
                if (base.UpdateSqlData(this.dataSetOrder, this.dataSetOrder.tJ_Order))
                {
                    this.Load_Order();
                    this.SaveLinkObjects();
                    if (this.SaveBrigade() && this.SaveInstructions())
                    {
                        return true;
                    }
                }
                return false;
            }
            DataRow dataRow = this.dataSetOrder.tJ_Order.NewRow();
            dataRow["num"] = 0;
            dataRow["DateBegin"] = this.dateTimePickerDateBegin.Value;
            dataRow["DateEnd"] = this.dateTimePickerDateEnd.Value;
            dataRow["idSR"] = this.cmbSR.SelectedValue;
            dataRow["Instruction"] = this.richTxtInstruction.Text;
            dataRow["headWorker"] = ((this.cmbHeadWorker.SelectedValue == null) ? DBNull.Value : this.cmbHeadWorker.SelectedValue);
            dataRow["acceptWorker"] = this.cmbAcceptWorker.SelectedValue;
            dataRow["watchWorker"] = ((this.cmbWatchWorker.SelectedValue == null) ? DBNull.Value : this.cmbWatchWorker.SelectedValue);
            dataRow["makerWorker"] = this.cmbMakerWorker.SelectedValue;
            if (!string.IsNullOrEmpty(this.richTxtOtrherInstructions.Text))
            {
                dataRow["otherInstruction"] = this.richTxtOtrherInstructions.Text;
            }
            dataRow["dateOutput"] = this.dateTimePickerDateOutput.Value;
            dataRow["outputWorker"] = this.cmbOutputWorker.SelectedValue;
            dataRow["Registered"] = false;
            dataRow["idDivision"] = ((this.cmbDivision.SelectedValue == null) ? DBNull.Value : this.cmbDivision.SelectedValue);
            this.dataSetOrder.tJ_Order.Rows.Add(dataRow);
            this.dataSetOrder.tJ_Order.Rows[0].EndEdit();
            this.idOrder = base.InsertSqlDataOneRow(this.dataSetOrder, this.dataSetOrder.tJ_Order);
            if (this.idOrder != -1)
            {
                this.toolBtnCopyOrder.Enabled = true;
                this.toolBtnReport.Enabled = true;
                this.Load_Order();
                this.buttonRegister.Enabled = true;
                this.SaveLinkObjects();
                return this.SaveBrigade() && this.SaveInstructions();
            }
            return false;
        }

        private void SaveLinkObjects()
        {
            foreach (int num in this.linkObjects.Keys)
            {
                if (this.dataSetOrder.tL_OrderSchmObjList.Select(" idSChmObj = " + num.ToString()).Length == 0)
                {
                    DataRow dataRow = this.dataSetOrder.tL_OrderSchmObjList.NewRow();
                    dataRow["idOrder"] = this.IdOrder;
                    dataRow["idSchmObj"] = num;
                    this.dataSetOrder.tL_OrderSchmObjList.Rows.Add(dataRow);
                }
            }
            for (int i = 0; i < this.dataSetOrder.tL_OrderSchmObjList.Rows.Count; i++)
            {
                if (this.dataSetOrder.tL_OrderSchmObjList.Rows[i].RowState != DataRowState.Deleted && !this.linkObjects.ContainsKey(Convert.ToInt32(this.dataSetOrder.tL_OrderSchmObjList.Rows[i]["idSChmObj"])))
                {
                    this.dataSetOrder.tL_OrderSchmObjList.Rows[i].Delete();
                }
            }
            base.InsertSqlData(this.dataSetOrder, this.dataSetOrder.tL_OrderSchmObjList);
            base.DeleteSqlData(this.dataSetOrder, this.dataSetOrder.tL_OrderSchmObjList);
            this.dataSetOrder.tL_OrderSchmObjList.AcceptChanges();
        }

        private bool IsCanSave()
        {
            bool flag = true;
            if (this.dateTimePickerDateBegin.Value == null)
            {
                this.labelDateBegin.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dateTimePickerDateEnd.Value == null)
            {
                this.labelDateEnd.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.richTxtInstruction.Text))
            {
                this.labelInstruction.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbSR.SelectedValue == null)
            {
                this.labelSR.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbAcceptWorker.SelectedValue == null)
            {
                this.labelAccept.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbMakerWorker.SelectedValue == null)
            {
                this.labelMaker.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbOutputWorker.SelectedValue == null)
            {
                this.labelOutput.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dateTimePickerDateOutput.Value == null)
            {
                this.labelOutputDate.ForeColor = Color.Red;
                flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Не введены обязательные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return flag;
        }

        private bool IsCanRegistered()
        {
            if (!this.IsCanSave())
            {
                return false;
            }
            if (this.listBoxLinkScmObjects.Items.Count <= 0)
            {
                MessageBox.Show("Наряд не привязан к объектам схемы!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (this.dataSetOrder.tJ_OrderBrigade.Rows.Count <= 0)
            {
                MessageBox.Show("Нет ни одного члена бригады!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (this.dataSetOrder.tJ_Order.Rows.Count > 0 && this.IsCanRegistered())
            {
                if (this.Save_Order())
                {
                    this.dataSetOrder.tJ_Order.Rows[0]["Registered"] = true;
                    this.dataSetOrder.tJ_Order.Rows[0].EndEdit();
                    if (base.UpdateSqlData(this.dataSetOrder, this.dataSetOrder.tJ_Order))
                    {
                        this.Load_Order();
                        this.InitControls();
                        return;
                    }
                    this.dataSetOrder.tJ_Order.Rows[0]["Registered"] = false;
                    return;
                }
                else
                {
                    this.dataSetOrder.tJ_Order.Rows[0]["Registered"] = false;
                }
            }
        }

        private void buttonExtension_Click(object sender, EventArgs e)
        {
            if (this.dataSetOrder.tJ_Order.Rows.Count > 0)
            {
                if (this.cmbExtWorker.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбран сотрудник, продливающий наряд");
                    return;
                }
                if (this.dateTimePickerDateEndExt.Value == null)
                {
                    MessageBox.Show("Не выбрана дата продления");
                    return;
                }
                if (this.Save_Order())
                {
                    this.InitControls();
                    if (this.dateTimePickerDateEndExt.Value != null)
                    {
                        if (this.dateTimePickerDateOutput.MaxDate > (DateTime)this.dateTimePickerDateEndExt.Value)
                        {
                            this.dateTimePickerDateOutput.MaxDate = (DateTime)this.dateTimePickerDateEndExt.Value;
                        }
                        this.dateTimePickerResolution.MaxDate = (DateTime)this.dateTimePickerDateEndExt.Value;
                    }
                }
            }
        }

        private void dgvBrigade_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < e.RowCount; i++)
            {
                DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dgvBrigade[this.brigadeWorkerColumn.Name, e.RowIndex + i];
                if (!string.IsNullOrEmpty(this.SqlSettings.ServerDB))
                {
                    DataTable dataTable = this.InitTableWork();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    base.SelectSqlData(dataTable, true, " where ParentKey in (';GroupWorker;Workers;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
                    dataGridViewComboBoxCell.DataSource = bindingSource;
                    dataGridViewComboBoxCell.DisplayMember = "FIOGROUP";
                    dataGridViewComboBoxCell.ValueMember = "ID";
                }
                if (this.dgvBrigade[this.brigadeWorkerColumn.Name, e.RowIndex + i].Value != null)
                {
                    DataRow dataRow = ((dataGridViewComboBoxCell.DataSource as BindingSource).DataSource as DataTable).Rows.Find(dataGridViewComboBoxCell.Value);
                    if (dataRow != null && dataRow["GroupElectrical"] != DBNull.Value)
                    {
                        switch (Convert.ToInt32(dataRow["GroupElectrical"]))
                        {
                            case 1:
                                this.dgvBrigade[this.GroupElectricalTxtColumn.Name, e.RowIndex + i].Value = "I";
                                break;
                            case 2:
                                this.dgvBrigade[this.GroupElectricalTxtColumn.Name, e.RowIndex + i].Value = "II";
                                break;
                            case 3:
                                this.dgvBrigade[this.GroupElectricalTxtColumn.Name, e.RowIndex + i].Value = "III";
                                break;
                            case 4:
                                this.dgvBrigade[this.GroupElectricalTxtColumn.Name, e.RowIndex + i].Value = "IV";
                                break;
                            case 5:
                                this.dgvBrigade[this.GroupElectricalTxtColumn.Name, e.RowIndex + i].Value = "V";
                                break;
                            default:
                                this.dgvBrigade[this.GroupElectricalTxtColumn.Name, e.RowIndex + i].Value = "";
                                break;
                        }
                    }
                }
            }
        }

        private void dgvBrigade_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (this.dgvBrigade[this.idOrderDataGridViewTextBoxColumn.Name, e.RowIndex].Value == DBNull.Value || Convert.ToInt32(this.dgvBrigade[this.idOrderDataGridViewTextBoxColumn.Name, e.RowIndex].Value) != this.idOrder))
            {
                this.dgvBrigade[this.idOrderDataGridViewTextBoxColumn.Name, e.RowIndex].Value = this.idOrder;
            }
        }

        private void dgvBrigade_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.dgvBrigade.Columns[e.ColumnIndex].Name == this.brigadeWorkerColumn.Name && this.dgvBrigade[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
            {
                foreach (DataGridViewRow dataGridViewRow in ((IEnumerable)this.dgvBrigade.Rows))
                {
                    if (e.RowIndex != dataGridViewRow.Index && dataGridViewRow.Cells["brigadeWorkerColumn"].Value != null && this.dgvBrigade[e.ColumnIndex, e.RowIndex].Value != null && Convert.ToInt32(dataGridViewRow.Cells["brigadeWorkerColumn"].Value) == Convert.ToInt32(this.dgvBrigade[e.ColumnIndex, e.RowIndex].Value))
                    {
                        DataRow[] array = this.dataSetOrder.vWorkerGroup.Select("id = " + this.dgvBrigade[e.ColumnIndex, e.RowIndex].Value);
                        string str = "";
                        if (array.Length != 0)
                        {
                            str = array[0]["FIO"].ToString();
                        }
                        MessageBox.Show("Работник " + str + " уже введен в данный наряд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        this.dgvBrigade.BeginEdit(true);
                        break;
                    }
                }
            }
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
                e.Cancel = true;
                if (e.ColumnIndex >= 0 && e.ColumnIndex < ((DataGridView)sender).Columns.Count && e.RowIndex >= 0 && e.RowIndex < ((DataGridView)sender).Rows.Count)
                {
                    ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = e.Exception.Message;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvBrigade_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dgvBrigade.CurrentCell != null && this.dgvBrigade.Columns[this.dgvBrigade.CurrentCell.ColumnIndex] == this.idJobTitleDgvColumn)
            {
                return;
            }
            if (e.Control is ComboBox)
            {
                (e.Control as ComboBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                (e.Control as ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems;
                BindingSource bindingSource = (BindingSource)(e.Control as ComboBox).DataSource;
                if (bindingSource != null)
                {
                    bindingSource.Filter = "";
                    string text = "";
                    foreach (DataGridViewRow dataGridViewRow in ((IEnumerable)this.dgvBrigade.Rows))
                    {
                        if ((this.dgvBrigade.CurrentCell == null || this.dgvBrigade.CurrentCell.RowIndex != dataGridViewRow.Index) && dataGridViewRow.Cells[this.brigadeWorkerColumn.Name].Value != null)
                        {
                            text = text + dataGridViewRow.Cells[this.brigadeWorkerColumn.Name].Value.ToString() + ",";
                        }
                    }
                    if (text.Length > 0)
                    {
                        bindingSource.Filter = "id not in (" + text.Remove(text.Length - 1) + ")";
                    }
                    if (this.dgvBrigade.CurrentCell != null && this.dgvBrigade.CurrentCell.Value != null)
                    {
                        (e.Control as ComboBox).SelectedValue = this.dgvBrigade.CurrentCell.Value;
                    }
                }
                (e.Control as ComboBox).SelectedValueChanged -= new EventHandler(this.FormJournalOrderAddEdit_SelectedValueChanged);
                (e.Control as ComboBox).SelectedValueChanged += new EventHandler(this.FormJournalOrderAddEdit_SelectedValueChanged);
            }
        }

        private void dgvBrigade_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.dgvBrigade.CurrentCell != null && this.dgvBrigade.Columns[this.dgvBrigade.CurrentCell.ColumnIndex] == this.idJobTitleDgvColumn && Control.ModifierKeys == Keys.None && e.KeyCode == Keys.Delete)
            {
                this.dgvBrigade.CurrentCell.Value = DBNull.Value;
            }
        }

        private void FormJournalOrderAddEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.dgvBrigade.CurrentCell != null && ((ComboBox)sender).SelectedValue != null && ((ComboBox)sender).SelectedValue.GetType() != typeof(DataRowView))
            {
                BindingSource bindingSource = ((ComboBox)sender).DataSource as BindingSource;
                if (bindingSource != null)
                {
                    DataTable dataTable = bindingSource.DataSource as DataTable;
                    if (dataTable != null)
                    {
                        DataRow dataRow = dataTable.Rows.Find(((ComboBox)sender).SelectedValue);
                        if (dataRow["GroupElectrical"] != DBNull.Value)
                        {
                            switch (Convert.ToInt32(dataRow["GroupElectrical"]))
                            {
                                case 1:
                                    this.dgvBrigade[this.GroupElectricalTxtColumn.Name, this.dgvBrigade.CurrentCell.RowIndex].Value = "I";
                                    return;
                                case 2:
                                    this.dgvBrigade[this.GroupElectricalTxtColumn.Name, this.dgvBrigade.CurrentCell.RowIndex].Value = "II";
                                    return;
                                case 3:
                                    this.dgvBrigade[this.GroupElectricalTxtColumn.Name, this.dgvBrigade.CurrentCell.RowIndex].Value = "III";
                                    return;
                                case 4:
                                    this.dgvBrigade[this.GroupElectricalTxtColumn.Name, this.dgvBrigade.CurrentCell.RowIndex].Value = "IV";
                                    return;
                                case 5:
                                    this.dgvBrigade[this.GroupElectricalTxtColumn.Name, this.dgvBrigade.CurrentCell.RowIndex].Value = "V";
                                    return;
                                default:
                                    this.dgvBrigade[this.GroupElectricalTxtColumn.Name, this.dgvBrigade.CurrentCell.RowIndex].Value = "";
                                    return;
                            }
                        }
                        else
                        {
                            this.dgvBrigade[this.GroupElectricalTxtColumn.Name, this.dgvBrigade.CurrentCell.RowIndex].Value = "";
                        }
                    }
                }
            }
        }

        private bool SaveBrigade()
        {
            foreach (DataRow dataRow in this.dataSetOrder.tJ_OrderBrigade.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    dataRow["idorder"] = this.idOrder;
                    dataRow.EndEdit();
                }
            }
            if (base.InsertSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderBrigade) && base.UpdateSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderBrigade) && base.DeleteSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderBrigade))
            {
                base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderBrigade, true, " where idorder = " + this.idOrder.ToString());
                return true;
            }
            return false;
        }

        private void dgvInstruction_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.dgvInstruction["idOrderDgvColumnInstruction", e.RowIndex].Value = this.idOrder;
            }
        }

        private void dgvInstruction_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Cancel = true;
        }

        private void dgvInstruction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                DataRow dataRow = this.dataSetOrder.tJ_OrderInstruction.NewRow();
                dataRow["idorder"] = this.idOrder;
                dataRow["NameObj"] = "-";
                dataRow["Instruction"] = "-";
                this.dataSetOrder.tJ_OrderInstruction.Rows.InsertAt(dataRow, e.RowIndex);
            }
        }

        private bool SaveInstructions()
        {
            int num = 0;
            foreach (DataRow dataRow in this.dataSetOrder.tJ_OrderInstruction.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    dataRow["idorder"] = this.idOrder;
                    dataRow["rec_num"] = num++;
                    dataRow.EndEdit();
                }
            }
            if (base.InsertSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderInstruction) && base.UpdateSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderInstruction) && base.DeleteSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderInstruction))
            {
                base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderInstruction, true, " where idorder = " + this.idOrder.ToString() + " order by rec_num");
                return true;
            }
            return false;
        }

        private void cmbWorkerResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbWorkerResolution.SelectedValue != null && this.dateTimePickerResolution.Value == null)
            {
                if (this.dateTimePickerResolution.MaxDate >= DateTime.Now)
                {
                    if (this.dateTimePickerResolution.MinDate <= DateTime.Now)
                    {
                        this.dateTimePickerResolution.Value = DateTime.Now;
                        return;
                    }
                    this.dateTimePickerResolution.Value = this.dateTimePickerResolution.MinDate;
                    return;
                }
                else
                {
                    this.dateTimePickerResolution.Value = this.dateTimePickerResolution.MinDate;
                }
            }
        }

        private void buttonResolution_Click(object sender, EventArgs e)
        {
            if (this.isToResolution)
            {
                if (this.idOrder > 0)
                {
                    if (this.dateTimePickerResolution.Value == null)
                    {
                        MessageBox.Show("Не введена дата выдачи разрешения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    if (this.cmbWorkerResolution.SelectedValue == null)
                    {
                        MessageBox.Show("Не выбран диспетчер, выдающий разрешение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    if (DateTime.Now < Convert.ToDateTime(this.dateTimePickerDateBegin.Value) && MessageBox.Show("Текущее время, меньше чем дата начала работ.\n Вы уверены, что хотите выдать разрешение?", "Нельзя выдать разрешение", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    DataRow dataRow = this.dataSetOrder.tJ_OrderResolution.NewRow();
                    dataRow["idOrder"] = this.idOrder;
                    dataRow["idWorker"] = this.cmbWorkerResolution.SelectedValue;
                    dataRow["datebegin"] = Convert.ToDateTime(this.dateTimePickerResolution.Value).AddSeconds((double)(-(double)Convert.ToDateTime(this.dateTimePickerResolution.Value).Second));
                    this.dataSetOrder.tJ_OrderResolution.Rows.Add(dataRow);
                    base.InsertSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderResolution);
                }
            }
            else if (this.idOrder > 0)
            {
                int count = this.dataSetOrder.tJ_OrderResolution.Rows.Count;
                if (count > 0)
                {
                    if (this.dateTimePickerResolution.Value == null)
                    {
                        MessageBox.Show("Не введена дата окончания работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    this.dataSetOrder.tJ_OrderResolution.Rows[count - 1]["dateEnd"] = Convert.ToDateTime(this.dateTimePickerResolution.Value).AddSeconds((double)(-(double)Convert.ToDateTime(this.dateTimePickerResolution.Value).Second));
                    this.dataSetOrder.tJ_OrderResolution.Rows[count - 1].EndEdit();
                    base.UpdateSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderResolution);
                }
            }
            this.LoadResolution();
        }

        private void LoadResolution()
        {
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderResolution, true, " where idorder = " + this.idOrder.ToString() + " order by datebegin ");
            this.InitControls();
        }

        private void cmbCloseWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dataSetOrder.tJ_Order.Rows.Count > 0 && this.cmbCloseWorker.SelectedValue != null && this.dateTimePickerClose.Value == null)
            {
                if (this.dateTimePickerClose.MaxDate >= DateTime.Now)
                {
                    if (this.dateTimePickerClose.MinDate <= DateTime.Now)
                    {
                        try
                        {
                            this.dateTimePickerClose.Value = DateTime.Now;
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    if (this.idOrder > 0 && this.dataSetOrder.tJ_Order.Rows.Count > 0)
                    {
                        this.dataSetOrder.tJ_Order.Rows[0]["dateclose"] = this.dateTimePickerClose.MinDate;
                        return;
                    }
                    this.dateTimePickerClose.Value = this.dateTimePickerClose.MinDate;
                    return;
                }
                else
                {
                    if (this.idOrder > 0 && this.dataSetOrder.tJ_Order.Rows.Count > 0)
                    {
                        this.dataSetOrder.tJ_Order.Rows[0]["dateclose"] = this.dateTimePickerClose.MaxDate;
                        return;
                    }
                    this.dateTimePickerClose.Value = this.dateTimePickerClose.MaxDate;
                }
            }
        }

        private void buttonCloseOrder_Click(object sender, EventArgs e)
        {
            if (this.dateTimePickerClose.Value == null)
            {
                MessageBox.Show("Не введена дата закрытия наряда", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (this.cmbCloseWorker.SelectedValue == null)
            {
                MessageBox.Show("Не выбран диспетчер, закрывающий наряд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (this.dataSetOrder.tJ_Order.Rows.Count > 0 && Convert.ToBoolean(this.dataSetOrder.tJ_Order.Rows[0]["Registered"]))
            {
                this.dataSetOrder.tJ_Order.Rows[0]["DateClose"] = Convert.ToDateTime(this.dateTimePickerClose.Value).AddSeconds((double)(-(double)Convert.ToDateTime(this.dateTimePickerClose.Value).Second));
                this.dataSetOrder.tJ_Order.Rows[0]["closeWorker"] = this.cmbCloseWorker.SelectedValue;
                this.Save_Order();
            }
            this.Load_Order();
            this.InitControls();
        }

        private void toolBtnReport_Click(object sender, EventArgs e)
        {
            if (this.IdOrder > 0)
            {
                ReportOrderToExcel.Report(this.IdOrder, this.SqlSettings);
            }
        }

        private void toolBtnCopyOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Скопировать текущий наряд?", "Копирование", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.idOrder = -1;
                this.dataSetOrder.tL_OrderSchmObjList.Clear();
                new DataSet.DataSetOrder();
                DataTable dataTable = this.dataSetOrder.tJ_OrderBrigade.Copy();
                this.dataSetOrder.tJ_OrderBrigade.Clear();
                this.dgvBrigade.DataMember = "";
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    DataRow dataRow2 = this.dataSetOrder.tJ_OrderBrigade.NewRow();
                    dataRow2["idOrder"] = this.IdOrder;
                    dataRow2["idWorker"] = dataRow["idWorker"];
                    dataRow2["idJobTitle"] = dataRow["idJobTitle"];
                    dataRow2["isUnderstudy"] = dataRow["isUnderstudy"];
                    this.dataSetOrder.tJ_OrderBrigade.Rows.Add(dataRow2);
                }
                this.dgvBrigade.DataMember = "tJ_OrderBrigade";
                DataTable dataTable2 = this.dataSetOrder.tJ_OrderInstruction.Copy();
                this.dataSetOrder.tJ_OrderInstruction.Clear();
                foreach (DataRow dataRow3 in dataTable2.Rows)
                {
                    DataRow dataRow4 = this.dataSetOrder.tJ_OrderInstruction.NewRow();
                    dataRow4["idOrder"] = this.IdOrder;
                    dataRow4["nameObj"] = dataRow3["nameObj"];
                    dataRow4["Instruction"] = dataRow3["Instruction"];
                    dataRow4["rec_num"] = dataRow3["rec_num"];
                    this.dataSetOrder.tJ_OrderInstruction.Rows.Add(dataRow4);
                }
                this.dataSetOrder.tJ_OrderResolution.Clear();
                this.Copy_Order();
                this.txtNumOrder.BackColor = Color.Yellow;
                this.panelExtension.Enabled = false;
                this.dateTimePickerDateBegin.Enabled = true;
                this.dateTimePickerDateEnd.Enabled = true;
                this.cmbSR.Enabled = true;
                this.cmbHeadWorker.Enabled = true;
                this.cmbAcceptWorker.Enabled = true;
                this.cmbWatchWorker.Enabled = true;
                this.cmbMakerWorker.Enabled = true;
                this.cmbOutputWorker.Enabled = true;
                this.richTxtInstruction.ReadOnly = false;
                this.richTxtOtrherInstructions.ReadOnly = false;
                this.dateTimePickerDateOutput.Enabled = true;
                this.dgvBrigade.ReadOnly = false;
                this.dgvBrigade.AllowUserToAddRows = true;
                this.dgvInstruction.ReadOnly = false;
                this.dgvInstruction.AllowUserToAddRows = true;
                this.buttonRegister.Enabled = true;
                this.buttonSave.Enabled = true;
                this.toolBtnDelSchmObj.Enabled = true;
                this.toolBtnLinkSchmObj.Enabled = true;
                this.panelExtension.Enabled = false;
                this.cmbWorkerResolution.Enabled = false;
                this.dateTimePickerResolution.Enabled = false;
                this.buttonResolution.Enabled = false;
                this.cmbCloseWorker.Enabled = false;
                this.dateTimePickerClose.Enabled = false;
                this.buttonCloseOrder.Enabled = false;
                this.panelExtension.Enabled = false;
                this.toolBtnCopyOrder.Enabled = false;
                this.toolBtnReport.Enabled = false;
                if (base.PermissionsControlsEnabled || base.PermissionsControlsVisible)
                {
                    base.SetControlsPropertiesUser();
                }
            }
        }

        private void Copy_Order()
        {
            object value = this.dateTimePickerDateBegin.Value;
            object value2 = this.dateTimePickerDateEnd.Value;
            object selectedValue = this.cmbSR.SelectedValue;
            object text = this.richTxtInstruction.Text;
            object selectedValue2 = this.cmbHeadWorker.SelectedValue;
            object selectedValue3 = this.cmbAcceptWorker.SelectedValue;
            object selectedValue4 = this.cmbWatchWorker.SelectedValue;
            object selectedValue5 = this.cmbMakerWorker.SelectedValue;
            object text2 = this.richTxtOtrherInstructions.Text;
            object value3 = this.dateTimePickerDateOutput.Value;
            object selectedValue6 = this.cmbOutputWorker.SelectedValue;
            object selectedValue7 = this.cmbDivision.SelectedValue;
            this.dataSetOrder.tJ_Order.Clear();
            this.dateTimePickerDateBegin.Value = null;
            this.dateTimePickerDateEnd.Value = null;
            if (selectedValue == null)
            {
                this.cmbSR.SelectedIndex = -1;
            }
            else
            {
                this.cmbSR.SelectedValue = selectedValue;
            }
            this.richTxtInstruction.Text = text.ToString();
            if (selectedValue2 == null)
            {
                this.cmbHeadWorker.SelectedIndex = -1;
            }
            else
            {
                this.cmbHeadWorker.SelectedValue = selectedValue2;
            }
            if (selectedValue3 == null)
            {
                this.cmbAcceptWorker.SelectedIndex = -1;
            }
            else
            {
                this.cmbAcceptWorker.SelectedValue = selectedValue3;
            }
            if (selectedValue4 == null)
            {
                this.cmbWatchWorker.SelectedIndex = -1;
            }
            else
            {
                this.cmbWatchWorker.SelectedValue = selectedValue4;
            }
            if (selectedValue5 == null)
            {
                this.cmbMakerWorker.SelectedIndex = -1;
            }
            else
            {
                this.cmbMakerWorker.SelectedValue = selectedValue5;
            }
            if (selectedValue7 == null)
            {
                this.cmbDivision.SelectedIndex = -1;
            }
            else
            {
                this.cmbDivision.SelectedValue = selectedValue7;
            }
            this.richTxtOtrherInstructions.Text = text2.ToString();
            this.dateTimePickerDateOutput.Value = null;
            this.cmbOutputWorker.SelectedValue = DBNull.Value;
            this.linkObjects.Clear();
            this.LoadLinkObjkectsListBox();
            this.toolBtnViewSChmObj.Enabled = false;
        }

        private void FormJournalOrderAddEdit_KeyDown(object sender, KeyEventArgs e)
        {
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(newChild);
            XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
            xmlDocument.AppendChild(xmlNode);
            XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("X");
            xmlAttribute.Value = base.Location.X.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("Y");
            xmlAttribute.Value = base.Location.Y.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("Width");
            xmlAttribute.Value = base.Width.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("Height");
            xmlAttribute.Value = base.Height.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("SplitterDistance");
            xmlAttribute.Value = this.splitContainer.SplitterDistance.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            return xmlDocument;
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            XmlNode xmlNode = xmlDocument_0.SelectSingleNode(base.Name);
            if (xmlNode != null)
            {
                XmlAttribute xmlAttribute = xmlNode.Attributes["X"];
                int? num = null;
                int? num2 = null;
                if (xmlAttribute != null)
                {
                    num = new int?(Convert.ToInt32(xmlAttribute.Value));
                }
                xmlAttribute = xmlNode.Attributes["Y"];
                if (xmlAttribute != null)
                {
                    num2 = new int?(Convert.ToInt32(xmlAttribute.Value));
                }
                if (num != null && num2 != null)
                {
                    base.Location = new Point(num.Value, num2.Value);
                }
                xmlAttribute = xmlNode.Attributes["Width"];
                if (xmlAttribute != null)
                {
                    base.Width = Convert.ToInt32(xmlAttribute.Value);
                }
                xmlAttribute = xmlNode.Attributes["Height"];
                if (xmlAttribute != null)
                {
                    base.Height = Convert.ToInt32(xmlAttribute.Value);
                }
                xmlAttribute = xmlNode.Attributes["SplitterDistance"];
                if (xmlAttribute != null)
                {
                    this.splitContainer.SplitterDistance = Convert.ToInt32(xmlAttribute.Value);
                }
            }
        }

        private void toolBtnLinkSchmObj_Click(object sender, EventArgs e)
        {
            FormLinkOrderAndSchm form = new FormLinkOrderAndSchm();
            form.LinkObjects = this.linkObjects;
            form.SqlSettings = this.SqlSettings;
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.linkObjects = form.LinkObjects;
                if (this.linkObjects.Count > 0)
                {
                    this.toolBtnViewSChmObj.Enabled = true;
                }
                this.LoadLinkObjkectsListBox();
            }
        }

        private void toolBtnDelSchmObj_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.listBoxLinkScmObjects.SelectedItems)
            {
                this.linkObjects.Remove(((Documents.Forms.JournalOrder.SchmObject)obj).Id);
            }
            this.LoadLinkObjkectsListBox();
            if (this.linkObjects.Count > 0)
            {
                this.toolBtnViewSChmObj.Enabled = true;
                return;
            }
            this.toolBtnViewSChmObj.Enabled = false;
        }

        private void LoadLinkObjkectsListBox()
        {
            this.listBoxLinkScmObjects.Items.Clear();
            foreach (int num in this.linkObjects.Keys)
            {
                this.listBoxLinkScmObjects.Items.Add(new Documents.Forms.JournalOrder.SchmObject(num, this.linkObjects[num]));
            }
        }

        private void toolBtnViewSChmObj_Click(object sender, EventArgs e)
        {
            GoToSchemaEventArgs e2 = new GoToSchemaEventArgs(this.linkObjects.Keys.ToList<int>());
            this.OnGoToSchema(e2);
        }

        private void ChangeGroupElcetrical(ComboBox cmb, TextBox txt)
        {
            if (cmb.SelectedValue == null)
            {
                txt.Text = "";
                return;
            }
            DataRow dataRow = (cmb.DataSource as DataTable).Rows.Find(cmb.SelectedValue);
            if (dataRow["GroupElectrical"] == DBNull.Value)
            {
                txt.Text = "";
                return;
            }
            switch (Convert.ToInt32(dataRow["GroupElectrical"]))
            {
                case 1:
                    txt.Text = "I";
                    return;
                case 2:
                    txt.Text = "II";
                    return;
                case 3:
                    txt.Text = "III";
                    return;
                case 4:
                    txt.Text = "IV";
                    return;
                case 5:
                    txt.Text = "V";
                    return;
                default:
                    txt.Text = "";
                    return;
            }
        }

        private void cmbHeadWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChangeGroupElcetrical((ComboBox)sender, this.txtHeadWorker);
        }

        private void cmbOutputWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChangeGroupElcetrical((ComboBox)sender, this.txtOutputWorker);
            if (this.cmbOutputWorker.SelectedValue != null && this.dateTimePickerDateOutput.Value == null)
            {
                if (this.dateTimePickerDateOutput.MaxDate >= DateTime.Now)
                {
                    if (this.dateTimePickerDateOutput.MinDate <= DateTime.Now)
                    {
                        this.dateTimePickerDateOutput.Value = DateTime.Now;
                        return;
                    }
                    this.dateTimePickerDateOutput.Value = this.dateTimePickerDateOutput.MinDate;
                    return;
                }
                else
                {
                    this.dateTimePickerDateOutput.Value = this.dateTimePickerDateOutput.MaxDate;
                }
            }
        }

        private void cmbAcceptWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChangeGroupElcetrical((ComboBox)sender, this.txtAcceptWorker);
        }

        private void cmbWatchWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChangeGroupElcetrical((ComboBox)sender, this.txtWatchWorker);
        }

        private void cmbMakerWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChangeGroupElcetrical((ComboBox)sender, this.txtMakerWorker);
        }

        private void cmbHeadWorker_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((ComboBox)sender).Text))
            {
                ((ComboBox)sender).SelectedIndex = -1;
                if (this.dataSetOrder.tJ_Order.Rows.Count > 0)
                {
                    this.dataSetOrder.tJ_Order.Rows[0]["headWorker"] = DBNull.Value;
                }
                this.ChangeGroupElcetrical((ComboBox)sender, this.txtHeadWorker);
            }
        }

        private void cmbWatchWorker_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((ComboBox)sender).Text))
            {
                ((ComboBox)sender).SelectedIndex = -1;
                if (this.dataSetOrder.tJ_Order.Rows.Count > 0)
                {
                    this.dataSetOrder.tJ_Order.Rows[0]["watchWorker"] = DBNull.Value;
                }
                this.ChangeGroupElcetrical((ComboBox)sender, this.txtWatchWorker);
            }
        }

        private void cmbOutputWorker_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((ComboBox)sender).Text))
            {
                ((ComboBox)sender).SelectedIndex = -1;
                this.ChangeGroupElcetrical((ComboBox)sender, this.txtOutputWorker);
            }
        }

        private void cmbAcceptWorker_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((ComboBox)sender).Text))
            {
                ((ComboBox)sender).SelectedIndex = -1;
                this.ChangeGroupElcetrical((ComboBox)sender, this.txtAcceptWorker);
            }
        }

        private void cmbMakerWorker_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((ComboBox)sender).Text))
            {
                ((ComboBox)sender).SelectedIndex = -1;
                this.ChangeGroupElcetrical((ComboBox)sender, this.txtMakerWorker);
            }
        }



        //private struct SchmObject
        //{
        //	public SchmObject(int id, string text)
        //	{

        //		this.Text = text;
        //		this.Id = id;
        //	}

        //	public override string ToString()
        //	{
        //		return this.Text;
        //	}

        //	public string Text;

        //	public int Id;
        //}
    }
}