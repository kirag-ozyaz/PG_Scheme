using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;


namespace Legal.Forms.Meter
{
    public partial class FormMeterAddEdit : FormLbr.FormBase
    {
        private int IDP;
        private int IDO;
        private int idMeter;
        private int idTrans;
        private bool INF;
        private int FlagUpdateKtr;

        public int IdPoint { get; set; }

        //позиционирование в гриде
        private int GetRowIndexByKey(DataGridView dgv, string columnName, int key)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (Convert.ToInt32(dr.Cells[columnName].Value) == key)
                    return dr.Index;
            }
            return 0;
        }


        public FormMeterAddEdit()
        {
            InitializeComponent();
        }
        
        public FormMeterAddEdit(int idObj,int idPoint, bool info)
        {
            InitializeComponent();
            IDP = idPoint;
            IDO = idObj;
            INF = info;
            dateTimePickerEnd.Value = null;
        }

        private void FormMeterAddEdit_Load(object sender, EventArgs e)
        {
            if (IDP == -1)
            {
                 EnabledComponent(false);
            }
            else
                LoadPoint();
        }

        private void EnabledComponent(bool value)
        {
            tcMeter.Enabled = value;
            groupBoxNewEdit.Enabled = value;
            groupBoxMeterTrans.Enabled = value;
            buttonOK.Enabled = value;
        }

        private void LoadPoint()
        {
            this.SelectSqlData(dsPoint, dsPoint.tPoint, true, " where id = " + IDP.ToString());

            GetData();

            dateTimePickerBeg.Value = Convert.ToDateTime(dsPoint.tPoint.Rows[0]["DateBegin"]);
            dateTimePickerEnd.Value = (dsPoint.tPoint.Rows[0]["DateEnd"] == DBNull.Value) ? null :  dsPoint.tPoint.Rows[0]["DateEnd"] ;
            if (dsPoint.tPoint.Rows[0]["DateEnd"] != DBNull.Value) buttonOK.Enabled = false;
            rtbLocation.Text = dsPoint.tPoint.Rows[0]["Location"].ToString();
            NUDN.Value = (dsPoint.tPoint.Rows[0]["Name"] == DBNull.Value) ? 0 : Convert.ToInt32(dsPoint.tPoint.Rows[0]["Name"]);

            this.SelectSqlData(dsPoint, dsPoint.vPointReg, true, " where idpoint = " + IDP.ToString() + " order by DateBegin desc");
            
            GetPoint();

            dateTimePickerDateDem.Value = null;
            dateTimePickerTransdateDem.Value = null;
            dateTimePickerDateMade.Value = null;

            if (dgvObjMeter.Rows.Count > 0)
            {
                radioButtonNew.Checked = false;
                radioButtonEdit.Checked = true;
            }
            else
            {
                radioButtonEdit.Checked = false;
                radioButtonNew.Checked = true;
            }

            gbMeter.Enabled = true;
            gbTrans.Enabled = false;


            if (INF == true)
            {
                buttonOK.Visible = false;
                groupBoxNewEdit.Visible = false;
                groupBoxMeterTrans.Visible = false;
                buttonNewPoint.Visible = false;
                buttonEditPoint.Visible = false;
                gbMeter.Enabled = true;
                gbTrans.Enabled = true;

            }

        }
        private void GetData()
        {
            this.SelectSqlData(dsPoint, dsPoint.tR_Classifier, true, " where ParentKey in (';SKUEE;TypeTension;', " +
                   "';SKUEE;PointLocation;', ';SKUEE;TypePoint;') and IsGRoup = 0 and deleted = 0");
            bsTypeMeter.Filter = "ParentKey = ';SKUEE;TypePoint;' and id <> " + ((int)Constants.DevicePointType.TransAmperage).ToString();

            // справочник счетчиков
            this.SelectSqlData(dsPoint, dsPoint.tR_MarkMeter, true, " order by name, digit");
            //cmbMarkMeter.DataSource = dsPoint.tR_MarkMeter;
            //cmbMarkMeter.DisplayMember = "Name";
            //cmbMarkMeter.ValueMember = "Id";
            //cmbMarkMeter.SelectedIndex = -1;

            cmbMarkMeter1.DataSource = dsPoint.tR_MarkMeter;
            cmbMarkMeter1.DisplayMember = "Name";
            cmbMarkMeter1.ValueMember = "Id";
            cmbMarkMeter1.SelectedIndex = -1;

            // справочник трансформаторов
            this.SelectSqlData(dsPoint, dsPoint.vG_MarkTrans, true, " order by SocrName desc, name, [primary], [secondary]");
            //cmbMarkTrans.DataSource = dsPoint.tR_MarkTrans;
            //cmbMarkTrans.DisplayMember = "Name";
            //cmbMarkTrans.ValueMember = "Id";
            //cmbMarkTrans.SelectedIndex = -1;

            cmbMarkTrans1.DataSource = dsPoint.vG_MarkTrans;
            cmbMarkTrans1.DisplayMember = "Name";
            cmbMarkTrans1.ValueMember = "Id";
            cmbMarkTrans1.SelectedIndex = -1;

            // справочник мастеров (уст. счетчиков)
            this.SelectSqlData(dsPoint, dsPoint.Tables["vWorkerGroup"], true, " where idGRoup = " + Constants.Constants.WorkerGroupMasterUL.ToString() +
                " and dateEnd is null order by FIO");
            cmbWorkerUst.SelectedIndex = -1;
            cmbWorkerDem.SelectedIndex = -1;
            cmbTransMasterUst.SelectedIndex = -1;
            cmbTransMasterDem.SelectedIndex = -1;


            // справочник зон
            this.SelectSqlData(dsZone, dsZone.Tables["tR_Classifier"], true, " where ParentKey like ';SKUEE;TimeZone;%' " +
                " and ParentKey <> ';SKUEE;TimeZone;' and isGroup = 1");
            cmbZone.SelectedIndex = -1;


            // года для даты госповерки
            for (int i = System.DateTime.Now.Year; i >= 1950; i--)
            {
                cmbMeterCheckYear.Items.Add(i);          // счетчика
                cmbTransCheckYear.Items.Add(i);     // трансформатора
            }
        }

        private void GetPoint()
        {
            if (radioButtonNew.Checked) //новый
            {
                //счетчик

                cmbMarkMeter1.SelectedIndex = -1;

                dateTimePickerDateDem.Value = null; 
                dateTimePickerDateDem.Enabled = false;
                cmbWorkerDem.Enabled = false;

                

                txtNumberMeter.Text = "";
                richTextBoxComment.Text = "";

                cmbWorkerUst.SelectedValue = -1;
                cmbWorkerDem.SelectedValue = -1;

                dateTimePickerDateMade.Value = null;

                nudTRK.Value = 1; //коэффициент трансформации по умочанию 1
                
                //трансформатор
                cmbMarkTrans1.SelectedValue = -1;
                dateTimePickerTransdateDem.Value = null;
                dateTimePickerTransdateDem.Enabled = false;
                cmbTransMasterUst.SelectedValue = -1;
                cmbTransMasterDem.SelectedValue = -1;
                cmbTransMasterDem.Enabled = false;
                txtTransNumber.Text = "";
                richTextBoxTransComment.Text ="";
                dateTimePickerTransDateMade.Value = null;


                

            }
            if (radioButtonEdit.Checked)  //редактирование
            {
                if (dgvObjMeter.RowCount > 0) //(dgvObjMeter.CurrentRow.Cells["idMarkMeterDGVTBC"].Value != null)
                {
                    cmbMarkMeter1.SelectedValue = dgvObjMeter.CurrentRow.Cells["idMarkMeterDGVTBC"].Value;

                    cmbWorkerUst.SelectedValue = dgvObjMeter.CurrentRow.Cells["idworkerbeginMeterDGVTBC"].Value;
                    cmbWorkerDem.Enabled = true;
                    cmbWorkerDem.SelectedValue = dgvObjMeter.CurrentRow.Cells["idWorkerEndMeterDGVTBC"].Value;

                    dateTimePickerDateUst.Value = Convert.ToDateTime(dgvObjMeter.CurrentRow.Cells["datebeginMeterDGVTBC"].Value);
                    dateTimePickerDateDem.Enabled = true;
                    dateTimePickerDateDem.Value = dgvObjMeter.CurrentRow.Cells["dateendMeterDGVTBC"].Value;

                    dateTimePickerTransdateDem.Enabled = true;

                    txtNumberMeter.Text = dgvObjMeter.CurrentRow.Cells["numberMeterDGVTBC"].Value.ToString();
                    richTextBoxComment.Text = dgvObjMeter.CurrentRow.Cells["commentMeterDGVTBC"].Value.ToString();

                    dateTimePickerDateMade.Value = dgvObjMeter.CurrentRow.Cells["datemadeMeterDGVTBC"].Value;

                    if (dgvObjMeter.CurrentRow.Cells["datecheckMeterDGVTBC"].Value != DBNull.Value)
                        GetCheckDateMeterKvartalAndYear(dgvObjMeter.CurrentRow.Cells["datecheckMeterDGVTBC"].Value);
                    else { cmbMeterCheckKvartal.SelectedIndex = -1; cmbMeterCheckYear.SelectedIndex = -1; };

                    if (dgvObjMeter.CurrentRow.Cells["idzone"].Value != DBNull.Value) cmbZone.SelectedValue = dgvObjMeter.CurrentRow.Cells["idzone"].Value;

                    if (dgvObjMeter.CurrentRow.Cells["TR_K"].Value != DBNull.Value) nudTRK.Value = (int)dgvObjMeter.CurrentRow.Cells["TR_K"].Value;

                    txtActUstanov.Text = dgvObjMeter.CurrentRow.Cells["ActUstanov"].Value.ToString();
                    txtActDemontag.Text = dgvObjMeter.CurrentRow.Cells["ActDemontag"].Value.ToString();

                }
                else
                {

                    MessageBox.Show("Отсутствуют счетчики для редактирования!");
                    radioButtonEdit.Checked = false;
                    radioButtonNew.Checked = true;
                }

                if (dgvObjTrans.RowCount>0) // ||  dgvObjTrans.CurrentRow.Cells["idMarkTransDGVTBC"].Value != null)
                {
                    cmbMarkTrans1.SelectedValue = dgvObjTrans.CurrentRow.Cells["idMarkTransDGVTBC"].Value;
                    dateTimePickerTransdateDem.Enabled = true;

                    if (dgvObjTrans.CurrentRow.Cells["datebeginTransDGVTBC"].Value != DBNull.Value)
                        dateTimePickerTransDateUst.Value = Convert.ToDateTime(dgvObjTrans.CurrentRow.Cells["datebeginTransDGVTBC"].Value) ;
                    dateTimePickerTransdateDem.Value = dgvObjTrans.CurrentRow.Cells["dateendTransDGVTBC"].Value;
                    dateTimePickerTransdateDem.Enabled = true;
                    
                    cmbTransMasterUst.SelectedValue = dgvObjTrans.CurrentRow.Cells["idworkerbeginTransDGVTBC"].Value;
                    cmbTransMasterDem.Enabled = true;
                    cmbTransMasterDem.SelectedValue = dgvObjTrans.CurrentRow.Cells["idWorkerEndTrans"].Value;

                    txtTransNumber.Text = dgvObjTrans.CurrentRow.Cells["numberTransDGVTBC"].Value.ToString();
                    richTextBoxTransComment.Text = dgvObjTrans.CurrentRow.Cells["commentTransDGVTBC"].Value.ToString();
                    dateTimePickerTransDateMade.Value = dgvObjTrans.CurrentRow.Cells["datemadeTransDGVTBC"].Value;

                    if (dgvObjTrans.CurrentRow.Cells["datecheckTransDGVTBC"].Value != DBNull.Value)
                        GetCheckDateTransKvartalAndYear(dgvObjTrans.CurrentRow.Cells["datecheckTransDGVTBC"].Value);
                    else { cmbTransCheckKvartal.SelectedIndex = -1; cmbTransCheckYear.SelectedIndex = -1; };
                    
                }
                else
                {
                    MessageBox.Show("Отсутствуют трансформаторы для редактирования!");
                }

            }            
        

        }

        private void radioButtonNew_CheckedChanged(object sender, EventArgs e)
        {
            GetPoint();
        }

        private void radioButtonEdit_CheckedChanged(object sender, EventArgs e)
        {
            GetPoint();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonNew.Checked)
            {
                //новый счетчик
                if (rbMeter.Checked)
                {
                    for (int i = 0; i < dgvObjMeter.RowCount; i++)
                        if (dgvObjMeter["dateendMeterDGVTBC", i].FormattedValue.ToString() == "")
                        {
                            MessageBox.Show("Предыдущий счетчик не демонтирован.");
                            return;
                        }
                   
                        DataRow dr = dsPoint.tPointReg.NewRow();
                        dr["IdPoint"] = IDP;                        
                        dr["idMark"] = (Int32)cmbMarkMeter1.SelectedValue;
                        dr["DateBegin"] = dateTimePickerDateUst.Value.Date;     
                        dr["Type"] = (int)Constants.DevicePointType.Meter;  // тип точки - СЧЕТЧИК
                        if (cmbWorkerUst.SelectedValue != null)
                        {
                            dr["idWorkerBegin"] = cmbWorkerUst.SelectedValue;
                        }
                        else
                        {
                            MessageBox.Show("Не введен мастер установки счетчика.");
                            return;
                        };
                       
                       if (txtNumberMeter.Text != "")
                        {
                            dr["Number"] = txtNumberMeter.Text.Trim();
                        }
                        else
                        {
                            MessageBox.Show("Не введен заводской номер счетчика.");
                            return;
                        }
                        
                        dr["Comment"] = richTextBoxComment.Text;
                        if (dateTimePickerDateMade.Value != null) dr["DateMade"] = dateTimePickerDateMade.Value;

                        // Farit 20191022
                        dr["ActUstanov"] = txtActUstanov.Text.Trim();
                        dr["ActDemontag"] = txtActDemontag.Text.Trim();

                        try
                        {
                            dr["DateCheck"] = GetCheckDate(Convert.ToInt32(cmbMeterCheckYear.SelectedItem),
                                    cmbMeterCheckKvartal.SelectedIndex + 1);  //дата госповерки
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.Source);
                        }
                    
                        if(cmbZone.SelectedValue != null)
                        {
                            dr["IdZone"] = cmbZone.SelectedValue;
                        }
                        else
                        {
                            MessageBox.Show("Не установлена зона.");
                            return;
                        };

                        dr["TR_K"] = nudTRK.Value;
                           
                        dsPoint.tPointReg.Rows.Add(dr);
                        this.InsertSqlDataOneRow(dsPoint, dsPoint.tPointReg);
                        MessageBox.Show("Внесен новый счетчик.");
                        FlagUpdateKtr = 0;
                        nudTRK.BackColor = Color.White;
                };

                //новый трансформатор
                if (rbTrans.Checked)
                {

                    DataRow dr = dsPoint.tPointReg.NewRow();
                    dr["IdPoint"] = IDP;                        // id точки учета
                    dr["idMark"] = (Int32)cmbMarkTrans1.SelectedValue;
                    dr["DateBegin"] = dateTimePickerTransDateUst.Value.Date;      // дата установки
                    dr["Type"] = ((int)Constants.DevicePointType.TransAmperage);   // тип точки - ТРАНСФОРМАТОР

                    //if (txtNumberMeter.Text == "")
                    //{
                        dr["Number"] = txtTransNumber.Text;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Не введен заводской номер трансформатора.");
                    //}

                    dr["Comment"] = richTextBoxTransComment.Text;
                    if (dateTimePickerTransDateMade.Value != null) dr["DateMade"] = dateTimePickerTransDateMade.Value;

                    if (cmbTransCheckYear.SelectedItem == null || cmbTransCheckKvartal.SelectedIndex == -1)
                    {
                        MessageBox.Show("Не корректно введена дата госповерки трансформатора.");
                        return;
                    }

                    dr["DateCheck"] =
                        GetCheckDate(Convert.ToInt32(cmbTransCheckYear.SelectedItem), cmbTransCheckKvartal.SelectedIndex + 1);

                    if (cmbTransMasterUst.SelectedValue != null)
                    {
                        dr["idWorkerBegin"] = cmbTransMasterUst.SelectedValue;
                    }
                    else
                    {
                        MessageBox.Show("Не введен мастер установки трансформатора.");
                        return;
                    };

     
                    dsPoint.tPointReg.Rows.Add(dr); 
                    this.InsertSqlDataOneRow(dsPoint, dsPoint.tPointReg);

                    MessageBox.Show("Внесен новый трансформатор.");

                }

                this.SelectSqlData(dsPoint, dsPoint.vPointReg, true, " where idpoint = " + IDP.ToString() + " order by DateBegin desc");  
            }

            // редактирование
            if (radioButtonEdit.Checked)
            {
                if (rbMeter.Checked)
                {
                    idMeter = Convert.ToInt32(dgvObjMeter.CurrentRow.Cells["idMeterRegDGVTBC"].Value);
                 
                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tPointReg, true, "where id = " + idMeter.ToString());

                    ds.tPointReg.Rows[0]["IdMark"] = cmbMarkMeter1.SelectedValue;
                    ds.tPointReg.Rows[0]["DateBegin"] = dateTimePickerDateUst.Value;
                    if (dateTimePickerDateDem.Value != null) ds.tPointReg.Rows[0]["DateEnd"] = dateTimePickerDateDem.Value;
                    if (cmbWorkerUst.SelectedValue != null) ds.tPointReg.Rows[0]["idWorkerBegin"] = cmbWorkerUst.SelectedValue;
                    if (cmbWorkerDem.SelectedValue != null) ds.tPointReg.Rows[0]["idWorkerEnd"] = cmbWorkerDem.SelectedValue;
                    if (txtNumberMeter.Text != "") ds.tPointReg.Rows[0]["Number"] = txtNumberMeter.Text;
                    ds.tPointReg.Rows[0]["Comment"] = richTextBoxComment.Text;
                    if (dateTimePickerDateMade.Value != null) ds.tPointReg.Rows[0]["DateMade"] = dateTimePickerDateMade.Value;

                    // Farit 20191022
                     ds.tPointReg.Rows[0]["ActUstanov"] = txtActUstanov.Text.Trim();
                     ds.tPointReg.Rows[0]["ActDemontag"] = txtActDemontag.Text.Trim();

                    if (cmbMeterCheckYear.SelectedItem != null) ds.tPointReg.Rows[0]["DateCheck"] = GetCheckDate(Convert.ToInt32(cmbMeterCheckYear.SelectedItem),
                            cmbMeterCheckKvartal.SelectedIndex + 1);  //дат госповерки
                    if (cmbZone.SelectedValue != null) ds.tPointReg.Rows[0]["IdZone"] = cmbZone.SelectedValue ;

                    ds.tPointReg.Rows[0]["TR_K"] = nudTRK.Value;

                    if (this.UpdateSqlData(ds, ds.tPointReg))
                    {
                        MessageBox.Show("Данные счетчика изменены.");
                        FlagUpdateKtr = 0;
                        nudTRK.BackColor = Color.White;
                    }

                }
                if (rbTrans.Checked)
                {
                    idTrans = Convert.ToInt32(dgvObjTrans.CurrentRow.Cells["idTransDGVTBC"].Value);
                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tPointReg, true, "where id = " + idTrans.ToString());

                    ds.tPointReg.Rows[0]["IdMark"] = cmbMarkTrans1.SelectedValue;
                    ds.tPointReg.Rows[0]["DateBegin"] = dateTimePickerTransDateUst.Value;
                    if (dateTimePickerTransdateDem.Value != null) ds.tPointReg.Rows[0]["DateEnd"] = dateTimePickerTransdateDem.Value;
                    if (cmbTransMasterUst.SelectedValue != null) ds.tPointReg.Rows[0]["idWorkerBegin"] = cmbTransMasterUst.SelectedValue;
                    if (cmbTransMasterDem.SelectedValue != null) ds.tPointReg.Rows[0]["idWorkerEnd"] = cmbTransMasterDem.SelectedValue;
                    if (txtNumberMeter.Text != "") ds.tPointReg.Rows[0]["Number"] = txtTransNumber.Text;
                    ds.tPointReg.Rows[0]["Comment"] = richTextBoxTransComment.Text;
                    if (dateTimePickerTransDateMade.Value != null) ds.tPointReg.Rows[0]["DateMade"] = dateTimePickerTransDateMade.Value;

                    if (cmbTransCheckYear.SelectedItem != null ) ds.tPointReg.Rows[0]["DateCheck"] =
                        GetCheckDate(Convert.ToInt32(cmbTransCheckYear.SelectedItem), cmbTransCheckKvartal.SelectedIndex + 1);

                    if (this.UpdateSqlData(ds, ds.tPointReg))
                    {
                        MessageBox.Show("Данные трансформатора изменены.");
                    }

                }
                this.SelectSqlData(dsPoint, dsPoint.vPointReg, true, " where idpoint = " + IDP.ToString() + " order by DateBegin desc");

                if (radioButtonEdit.Checked) dgvObjMeter.CurrentCell = dgvObjMeter["datebeginMeterDGVTBC", GetRowIndexByKey(dgvObjMeter, "idMeterRegDGVTBC", idMeter)];
            }
                
        }

        private void dgvObjMeter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetPoint();
        }


        private void rbMeter_CheckedChanged(object sender, EventArgs e)
        {
            gbMeter.Enabled = true;
            gbTrans.Enabled = false;
        }

        private void rbTrans_CheckedChanged(object sender, EventArgs e)
        {
            gbMeter.Enabled = false;
            gbTrans.Enabled = true;
        }

        private void dgvObjTrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetPoint();
        }

        //Новая точка учета
        private void buttonNewPoint_Click(object sender, EventArgs e)
        {
            DataRow dr = dsPoint.tPoint.NewRow();
            dr["idAbnObj"] = IDO;                        // id объекта
            dr["DateBegin"] = dateTimePickerBeg.Value;
            dr["Location"] = rtbLocation.Text;

            dsPoint.tPoint.Rows.Add(dr);
            int id = this.InsertSqlDataOneRow(dsPoint, dsPoint.tPoint);
            if (id > 0)
            {
                IDP = id;
                IdPoint = id;
                MessageBox.Show("Создана новая точка учета.");
                EnabledComponent(false);
                LoadPoint();
            }
            else
            {
                MessageBox.Show("Не удалось создать точку учета.");
            }            
        }

        private void buttonEditPoint_Click(object sender, EventArgs e)
        {
            DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
            this.SelectSqlData(ds, ds.tPoint, true, "where id = " + IDP.ToString());
            ds.tPoint.Rows[0]["DateBegin"] = dateTimePickerBeg.Value;
            if (dateTimePickerEnd.Value != null) ds.tPoint.Rows[0]["DateEnd"] = dateTimePickerEnd.Value;
            ds.tPoint.Rows[0]["Location"] = rtbLocation.Text;
            ds.tPoint.Rows[0]["Name"] = NUDN.Value.ToString();

            if (this.UpdateSqlData(ds, ds.tPoint))
            {
                MessageBox.Show("Данные точки учета изменены.");
            }

        }


        #region Госповекрка
        private void GetCheckDateTransKvartalAndYear(object value)
        {
            if (!String.IsNullOrEmpty(value.ToString()))
            {
                DateTime checkDate = Convert.ToDateTime(value);
                cmbTransCheckYear.SelectedItem = checkDate.Year;
                switch (checkDate.Month)
                {
                    case 1:
                    case 2:
                    case 3: cmbTransCheckKvartal.SelectedIndex = 0; // первый квартал
                        break;
                    case 4:
                    case 5:
                    case 6: cmbTransCheckKvartal.SelectedIndex = 1;  // второй квартал
                        break;
                    case 7:
                    case 8:
                    case 9: cmbTransCheckKvartal.SelectedIndex = 2;  // третий квартал
                        break;
                    case 10:
                    case 11:
                    case 12: cmbTransCheckKvartal.SelectedIndex = 3;  // четвертый квартал
                        break;
                }
            }
        }
        private void GetCheckDateMeterKvartalAndYear(object value)
        {
            if (!String.IsNullOrEmpty(value.ToString()))
            {
                DateTime checkDate = Convert.ToDateTime(value);
                cmbMeterCheckYear.SelectedItem = checkDate.Year;
                switch (checkDate.Month)
                {
                    case 1:
                    case 2:
                    case 3: cmbMeterCheckKvartal.SelectedIndex = 0; // первый квартал
                        break;
                    case 4:
                    case 5:
                    case 6: cmbMeterCheckKvartal.SelectedIndex = 1;  // второй квартал
                        break;
                    case 7:
                    case 8:
                    case 9: cmbMeterCheckKvartal.SelectedIndex = 2;  // третий квартал
                        break;
                    case 10:
                    case 11:
                    case 12: cmbMeterCheckKvartal.SelectedIndex = 3;  // четвертый квартал
                        break;
                }
            }
        }
        private DateTime GetCheckDate(int year, int kvartal)
        {
            int month = 1;

            switch (kvartal)
            {
                case 1: // первый квартал
                    month = 4; break;
                case 2: // второй квартал
                    month = 7; break;
                case 3: // третий квартал
                    month = 10; break;
                case 4: // четвертый квартал
                    month = 1;
                    year++; break;
                default: break;
            }

            DateTime date = new DateTime(year, month, 1);
            date = date.AddDays(-1);
            return date;
        }
        #endregion

        private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex >= 0)
            {

                this.SelectSqlData(dsZone, dsZone.Tables["vR_Zone"], true, " where idZoneName = " +
                    ((ComboBox)sender).SelectedValue.ToString());
                // если это не новый счетчик
                if ((dgvObjMeter.Rows.Count > 0) && (dgvObjMeter.CurrentRow.Cells["idMeterRegDGVTBC"].Value != DBNull.Value))
                {
                    idMeter = Convert.ToInt32(dgvObjMeter.CurrentRow.Cells["idMeterRegDGVTBC"].Value);
                    for (int i = 0; i < dsZone.Tables["vR_ZOne"].Rows.Count; i++)
                    {
                        DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                        this.SelectSqlData( ds.tDocAct, true, " where idPointReg = " + idMeter.ToString() +
                            " and idDocType = " + ((int)Constants.DocType.ActUst).ToString() +
                            " and idZone = " + dsZone.Tables["vR_Zone"].Rows[i]["idSubZoneName"].ToString(), null, false, 1);
                        if (ds.tDocAct.Rows.Count > 0)
                            dsZone.Tables["vR_ZOne"].Rows[i]["VAlueBegin"] = ds.tDocAct.Rows[0]["ValueKWT"];

                        this.SelectSqlData(ds.tDocAct, true, " where idPointReg = " + idMeter.ToString() +
                            " and idDocType = " + ((int)Constants.DocType.ActDem).ToString() +
                            " and idZone = " + dsZone.Tables["vR_Zone"].Rows[i]["idSubZoneName"].ToString(), null, false, 1);
                        if (ds.tDocAct.Rows.Count > 0)
                            dsZone.Tables["vR_ZOne"].Rows[i]["VAlueEnd"] = ds.tDocAct.Rows[0]["ValueKWT"];
                    }
                }

            }
            dgvZoneIndicator.Columns[0].Visible = false;
        }

        private void cmbMarkTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbMarkTrans.SelectedIndex != -1)
            //{
            //    // рассчитаем новый коэффициент трансформации
            //    int prim = Convert.ToInt32(dsPoint.tR_MarkTrans.Rows[cmbMarkTrans.SelectedIndex]["Primary"]);
            //    int sec = Convert.ToInt32(dsPoint.tR_MarkTrans.Rows[cmbMarkTrans.SelectedIndex]["Secondary"]);
            //    int ktr = prim / sec;

            //    // если коэффициент трансформации изменился обновим поле в реквизитах счетчика
            //    if (nudTRK.Value != ktr)
            //    {
            //        MessageBox.Show("Изменился коэффициент трансформации - сохраните реквизиты счетчика");
            //        nudTRK.Value = ktr;
            //        nudTRK.BackColor = Color.Yellow;
            //        FlagUpdateKtr = 1;
            //    }
            //    else
            //        FlagUpdateKtr = 0;
            //}
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //if (FlagUpdateKtr == 1)
            //{
            //    MessageBox.Show("Изменился коэффициент трансформации - сохраните реквизиты счетчика");
            //}

        }

        private void cmbMarkTrans1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbMarkTrans1.SelectedIndex != -1)
            //{
            //    // рассчитаем новый коэффициент трансформации
            //    int prim = Convert.ToInt32(dsPoint.vG_MarkTrans.Rows[cmbMarkTrans1.SelectedIndex]["Primary"]);
            //    int sec = Convert.ToInt32(dsPoint.vG_MarkTrans.Rows[cmbMarkTrans1.SelectedIndex]["Secondary"]);
            //    int ktr = prim / sec;

            //    // если коэффициент трансформации изменился обновим поле в реквизитах счетчика
            //    if (nudTRK.Value != ktr)
            //    {
            //        MessageBox.Show("Изменился коэффициент трансформации - сохраните реквизиты счетчика");
            //        nudTRK.Value = ktr;
            //        nudTRK.BackColor = Color.Yellow;
            //        FlagUpdateKtr = 1;
            //    }
            //    else
            //        FlagUpdateKtr = 0;
            //}
        }

        private void cmbMarkMeter1_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(cmbMarkMeter1, "наименование|разрядность|фаза|напряжение|точность");
        }

        private void cmbMarkTrans1_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(cmbMarkTrans1, "наименование|перв|втор|точность|интервал|тип");
        }

        private void btnMeter_Restore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите восстановить этот счетчик?", "Восстановление",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvObjMeter.Rows.Count > 0)
                {
                    // проверим нет ли уже активного счетчика в списке
                    for (int i = 0; i < dgvObjMeter.RowCount; i++)
                        if (dgvObjMeter["dateendMeterDGVTBC", i].FormattedValue.ToString() == "")
                        {
                            MessageBox.Show("Предыдущий счетчик не демонтирован.");
                            return;
                        }

                    idMeter = Convert.ToInt32(dgvObjMeter.CurrentRow.Cells["idMeterRegDGVTBC"].Value);

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tPointReg, true, "where id = " + idMeter.ToString());

                    ds.tPointReg.Rows[0]["DateEnd"] = System.DBNull.Value;

                    if (this.UpdateSqlData(ds, ds.tPointReg))
                    {
                        this.SelectSqlData(dsPoint, dsPoint.vPointReg, true, " where idpoint = " + IDP.ToString() + " order by DateBegin desc");
                        if (radioButtonEdit.Checked) dgvObjMeter.CurrentCell = dgvObjMeter["datebeginMeterDGVTBC", GetRowIndexByKey(dgvObjMeter, "idMeterRegDGVTBC", idMeter)];
                        dateTimePickerDateDem.Value = null;
                        MessageBox.Show("Счетчик восстановлен...");
                    }
                }
            }

        }

        private void btnTrans_Restore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите восстановить этот трансформатор?", "Восстановление",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvObjTrans.Rows.Count > 0)
                {
                    idTrans = Convert.ToInt32(dgvObjTrans.CurrentRow.Cells["idTransDGVTBC"].Value);

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tPointReg, true, "where id = " + idTrans.ToString());

                    ds.tPointReg.Rows[0]["DateEnd"] = System.DBNull.Value;

                    if (this.UpdateSqlData(ds, ds.tPointReg))
                    {
                        this.SelectSqlData(dsPoint, dsPoint.vPointReg, true, " where idpoint = " + IDP.ToString() + " order by DateBegin desc");
                        if (radioButtonEdit.Checked) dgvObjTrans.CurrentCell = dgvObjTrans["datebeginTransDGVTBC", GetRowIndexByKey(dgvObjTrans, "idTransRegDGVTBC", idTrans)];
                        dateTimePickerTransdateDem.Value = null;
                        MessageBox.Show("Трансформатор восстановлен...");
                    }
                }
            }
        }

        private void cmbWorkerUst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMeterParameters_Log_Click(object sender, EventArgs e)
        {
            Legal.Forms.Meter.FormMeterParameters_Log frm = new Legal.Forms.Meter.FormMeterParameters_Log(idMeter);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }





    }
}
