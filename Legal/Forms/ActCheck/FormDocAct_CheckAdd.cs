using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataSql;
using System.Data.SqlClient;
using Constants;
//using Prv.Forms.Plombs;
using Legal.DataSet;

namespace Legal.Forms.ActCheck
{
    public partial class FormDocAct_CheckAdd : FormActBase
    {
        #region Variables
        string ids = "";
        int idAbnObj;
        int idDocAct;
        int idActCheck;
        int idAbnObjMeter = -1, idAbnObjTransCurrent = -1, idAbnObjTransVoltage = -1;
        int idPointMeter = -1, idPointTransCurrent = -1, idPointTransVoltage = -1;
        int idPointRegMeter = -1, idPointRegTransCurrent = -1, idPointRegTransVoltage = -1;
        int idDeviceMeter = -1, idDeviceTransCurrent = -1, idDeviceTransVoltage = -1;
        int idZone = 0;
        int ValueKWT = 0;
        //decimal a, b, c, t, n, s, cos, p;
        //DateTime TransU;
        //SqlConnection conn;
        BindingSource bdsJobTitle = new BindingSource(),
            bdsWorker = new BindingSource(), 
            bdsSealMeter = new BindingSource(), 
            bdsSealTransI = new BindingSource(), 
            bdsSealTransU = new BindingSource();
        //DataRow[] drMalfunction, drStrikeReveal;
        DataTable dtId;
        FormDocAct_DemUst frmDeviceInstDem;
        //перед редактированием формы раскомментировать
        private new DataSet.dsAbnObjAct dsAbnObjAkt1;
        #endregion

        #region Constructor

        public FormDocAct_CheckAdd()
        {
            InitializeComponent();
            FormDocAct_CheckAdd_Load();
        }

        public FormDocAct_CheckAdd(SQLSettings settings, int idAbnObj, int idAct)
        {
            InitializeComponent();
            FormDocAct_CheckAdd_Load();

            this.idAbnObj = idAbnObj;
            this.SqlSettings = settings;
            this.idActCheck = idAct;

            //MessageBox.Show("idAct = " + idAct.ToString());
            panelPoint.Enabled = false;

            try
            {
                SelectSqlData(dsAbn.tDocAct_Check, true, "where id = " + idActCheck.ToString(), null, false, 1);
                idDocAct = (int)dsAbn.tDocAct_Check.Rows[0]["idDocAct"];
                SelectSqlData(dsAbn.tDocAct, true, "where id = " + idDocAct.ToString(), null, false, 1);

                bdsJobTitle.DataSource = dsAbnObjAkt1;
                bdsJobTitle.DataMember = dsAbnObjAkt1.tR_Classifier.TableName;
                bdsJobTitle.CurrentChanged += new EventHandler(bdsJobTitle_CurrentChanged);

                bdsWorker.DataSource = dsAbnObjAkt1;
                bdsWorker.DataMember = dsAbnObjAkt1.vP_Worker.TableName;
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vP_Worker, true);

                SelectSqlData(this.dsAbnObjAkt1, dsAbnObjAkt1.tR_Classifier, true, "where ParentKey = ';GroupWorker;ActMeter;' AND Deleted = 0 AND isGroup = 0");
                cbOwnerJobTitle.DataSource = bdsJobTitle;
                cbOwnerJobTitle.DisplayMember = "Name";
                cbOwnerJobTitle.ValueMember = "id";
                cbOwnerJobTitle.SelectedIndex = -1;

                SelectSqlData(dsAbnObjAkt1.vPointCheckMeterFill, true, String.Format("where idAbnObj = {0} and Type = {1}  and PointDateEnd is null ", idAbnObj, 245), null, true); //and PointRegDateEnd is null
                bdsJobTitle_CurrentChanged(bdsJobTitle, new EventArgs());

                //Должность состовителя акта
                for (int i = 0; i < dsAbnObjAkt1.vP_Worker.Rows.Count; i++)
                {
                    if ((int)dsAbnObjAkt1.vP_Worker.Rows[i]["id"] == (int)dsAbn.tDocAct.Rows[0]["IdWorker"])
                        cbOwnerJobTitle.SelectedValue = (int)dsAbnObjAkt1.vP_Worker.Rows[i]["idGroup"];
                }

                //ФИО состовителя акта
                cbOwnerFIO.DataSource = bdsWorker;
                cbOwnerFIO.DisplayMember = "FIO";
                cbOwnerFIO.ValueMember = "id";
                cbOwnerFIO.SelectedIndex = -1;
                cbOwnerFIO.SelectedValue = (int)dsAbn.tDocAct.Rows[0]["IdWorker"];

                //Показания акта
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vDocAct_Value, true, "where idDocAct = " + idDocAct.ToString());


                cbNumMeter.DataSource = dsAbnObjAkt1.vPointCheckMeterFill;
                cbNumMeter.DisplayMember = "Number";
                cbNumMeter.ValueMember = "idPointReg";
                cbNumMeter.SelectedIndex = -1;
                cbTypeMeter.DataSource = dsAbnObjAkt1.vPointCheckMeterFill;
                cbTypeMeter.DisplayMember = "Name";
                cbTypeMeter.ValueMember = "idPointReg";
                cbTypeMeter.SelectedIndex = -1;

                SelectSqlDataTableOther(dsAbn, dsAbn.tR_Classifier_ActType, "tR_Classifier", true, String.Format("where id in ({0},{1},{2},{3},{4})", (int)DocType.ActCheck, (int)DocType.ActMeterDismantling, (int)DocType.ActMeterInstallation, (int)DocType.ActMeterkReplacement, (int)DocType.ActKO));
                
               FillDataGridView();
               

                FillDataTransComboBoxControl(idAbnObj);
                DataSql.SqlDataConnect con = new SqlDataConnect();
                con.OpenConnection(SqlSettings);
                
                SqlCommand cmd = new SqlCommand("select tPointReg.idPoint, tPointReg.id from tPoint inner join tPointReg on tPointReg.idPoint = tPoint.id where tPoint.idAbnObj = " + idAbnObj, con.Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtId = new DataTable();
                da.Fill(dtId);

                //Девайсы
                SelectSqlData(this.dsAbn, dsAbn.vPointRegCheck, true, "where idAbnObj = " + idAbnObj.ToString());

                for (int i = 0; i < dgvPointRegCheck.RowCount; i++)
                    //if (dgvPointRegCheck["idMPR", i].FormattedValue.ToString().
                    //    Contains(dsAbn.tDocAct.Rows[0]["idMPR"].ToString().Trim()))
                    if (dgvPointRegCheck["idMPR", i].Value != System.DBNull.Value && dsAbn.tDocAct.Rows[0]["IdPoint"] != System.DBNull.Value)
                        if (Convert.ToInt32(dgvPointRegCheck["idMPR", i].Value) == Convert.ToInt32(dsAbn.tDocAct.Rows[0]["IdPoint"]))
                        {
                            dgvPointRegCheck.CurrentCell = dgvPointRegCheck[1, i];
                            return;
                        }
                
                //FillPointDevice();

                //Заполнение элементов
                cbActType.SelectedValue = (int)dsAbn.tDocAct.Rows[0]["idDocType"];
                tbActNumber.Text = dsAbn.tDocAct.Rows[0]["DocNumber"].ToString();
                dtpActDate.Value = Convert.ToDateTime(dsAbn.tDocAct.Rows[0]["DateAct"]);

                // Farit 27.03.2017
                // пользователь и дата ввода
                dtInput.Value = Convert.ToDateTime(dsAbn.tDocAct.Rows[0]["DateIn"]);
                int idDoc = Convert.ToInt32(dsAbn.tDocAct.Rows[0]["id"].ToString());
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vG_DocActAuthor, true, " where id = " + idDoc);
                txtAuthor.Text = dsAbnObjAkt1.vG_DocActAuthor.Rows[0]["Username"].ToString();
                // распоряжение
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vG_ActOrder, true, " where idObj = " + idAbnObj);
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tG_ActOrder, true, " where idAct = " + idActCheck);

                if (dsAbnObjAkt1.tG_ActOrder.Rows.Count > 0)
                    cmbOrder.SelectedItem = dsAbnObjAkt1.tG_ActOrder.Rows[0]["idOrder"];
                else
                    cmbOrder.SelectedIndex = -1;



                //
                if (dsAbn.tDocAct_Check.Rows[0]["Fa"] != DBNull.Value) nudFa.Value = Convert.ToDecimal(dsAbn.tDocAct_Check.Rows[0]["Fa"]);
                if (dsAbn.tDocAct_Check.Rows[0]["Fb"] != DBNull.Value) nudFb.Value = Convert.ToDecimal(dsAbn.tDocAct_Check.Rows[0]["Fb"]);
                if (dsAbn.tDocAct_Check.Rows[0]["Fc"] != DBNull.Value) nudFc.Value = Convert.ToDecimal(dsAbn.tDocAct_Check.Rows[0]["Fc"]);
                if (dsAbn.tDocAct_Check.Rows[0]["n"] != DBNull.Value) nudTime.Value = Convert.ToDecimal(dsAbn.tDocAct_Check.Rows[0]["n"]);
                if (dsAbn.tDocAct_Check.Rows[0]["t"] != DBNull.Value) nudSec.Value = Convert.ToDecimal(dsAbn.tDocAct_Check.Rows[0]["t"]);
                if (dsAbn.tDocAct_Check.Rows[0]["Sfakt"] != DBNull.Value) nudS.Value = Convert.ToDecimal(dsAbn.tDocAct_Check.Rows[0]["Sfakt"]);
                if (dsAbn.tDocAct_Check.Rows[0]["Psch"] != DBNull.Value) nudP.Value = Convert.ToDecimal(dsAbn.tDocAct_Check.Rows[0]["Psch"]);
                if (dsAbn.tDocAct_Check.Rows[0]["cos"] != DBNull.Value) nudCos.Value = Convert.ToDecimal(dsAbn.tDocAct_Check.Rows[0]["cos"]);
                //tbFa.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["Fa"]);
                //tbFb.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["Fb"]);
                //tbFc.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["Fc"]);
                //tbTime.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["n"]);
                //tbSec.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["t"]);
                //tbS.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["Sfakt"]);
                //tbP.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["Psch"]);

                tbRepresentPost.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["RepresentPost"]);
                tbRepresentFIO.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["RepresentFIO"]);
                cbConformityRate.SelectedIndex = Convert.ToInt16(dsAbn.tDocAct_Check.Rows[0]["ConformityRate"]);
                tbConformityRateNote.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["ConformityRateNote"]);
                cbPrincipScheme.SelectedIndex = Convert.ToInt16(dsAbn.tDocAct_Check.Rows[0]["PrincipScheme"]);
                tbPrincipSchemeNote.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["PrincipSchemeNote"]);
                cbFactConsuption.SelectedIndex = Convert.ToInt16(dsAbn.tDocAct_Check.Rows[0]["FactConsuption"]);
                tbFactConsuptionNote.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["FactConsuptionNote"]);

                //tabControl1.SelectedIndex = 1;

                if (dsAbn.tDocAct_Check.Rows[0]["Malfunction"] != null)
                {
                    string[] MalfunctionArr = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["Malfunction"]).Split(';');
                    for (int i = 0; i < MalfunctionArr.Length; i++) //i <dgvMalfunction.RowCount &&
                        dgvMalfunction.Rows[i].Cells["MalfunctionValue"].Value = (MalfunctionArr[i] == "1") ? true : false;
                }

                if (dsAbn.tDocAct_Check.Rows[0]["StrikeReveal"] != null)
                {
                    string[] StrikeRevealArr = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["StrikeReveal"]).Split(';');
                    for (int i = 0; i < StrikeRevealArr.Length; i++) //i < dgvStrikeRreveal.RowCount &&

                        dgvStrikeRreveal.Rows[i].Cells["StrikeRevealValue"].Value = (StrikeRevealArr[i] == "1") ? true : false;
                }


                tbMalfunctionNote.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["MalfunctionNote"]);
                tbStrikeRrevealNote.Text = Convert.ToString(dsAbn.tDocAct_Check.Rows[0]["StrikeRevealNote"]);

                dtpStrikeRrevealDate.Value = (dsAbn.tDocAct_Check.Rows[0]["StrikeRevealDate"].ToString() != "") ? Convert.ToDateTime(dsAbn.tDocAct_Check.Rows[0]["StrikeRevealDate"]) : Convert.ToDateTime("1917.11.07");

                dgvMalfunction.Columns[0].Visible = false;
                dgvStrikeRreveal.Columns[0].Visible = false;



                if (SelectSqlData(dsAbnObjAkt1.vPointCheckActDevice, true, "where idDocAct = " + idDocAct, null, false, 1))
                {
                    if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idMDAD"] != DBNull.Value)
                    {
                        SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombMeter, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idMDAD"]));
                        if (dsAbnObjAkt1.vPointCheckPlombMeter.Rows.Count > 0)
                            for (int i = 0; i < dsAbnObjAkt1.vPointCheckPlombMeter.Rows.Count; i++)
                                SealRowsAdd((int)dsAbnObjAkt1.vPointCheckPlombMeter.Rows[i]["id"],
                                            dsAbnObjAkt1.vPointCheckPlombMeter.Rows[i]["SeriaNumber"].ToString(),
                                            (int)dsAbnObjAkt1.vPointCheckPlombMeter.Rows[i]["idWorker"],
                                            dsAbnObjAkt1.vPointCheckPlombMeter.Rows[i]["Location"].ToString(),
                                            dsAbnObjAkt1.vPointCheckPlombMeter.Rows[i]["Comment"].ToString(),
                                            Seal.New,
                                            Device.Meter);
                    }
                    if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTIDAD"] != DBNull.Value)
                    {
                        SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombTransCurrent, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTIDAD"]));
                        if (dsAbnObjAkt1.vPointCheckPlombTransCurrent.Rows.Count > 0)
                            for (int i = 0; i < dsAbnObjAkt1.vPointCheckPlombTransCurrent.Rows.Count; i++)
                                SealRowsAdd((int)dsAbnObjAkt1.vPointCheckPlombTransCurrent.Rows[i]["id"],
                                            dsAbnObjAkt1.vPointCheckPlombTransCurrent.Rows[i]["SeriaNumber"].ToString(),
                                            (int)dsAbnObjAkt1.vPointCheckPlombTransCurrent.Rows[i]["idWorker"],
                                            dsAbnObjAkt1.vPointCheckPlombTransCurrent.Rows[i]["Location"].ToString(),
                                            dsAbnObjAkt1.vPointCheckPlombTransCurrent.Rows[i]["Comment"].ToString(),
                                            Seal.New,
                                            Device.TransCurrent);
                    }
                    if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTUDAD"] != DBNull.Value)
                    {
                        SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombTransVoltage, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTUDAD"]));
                        if (dsAbnObjAkt1.vPointCheckPlombTransVoltage.Rows.Count > 0)
                            for (int i = 0; i < dsAbnObjAkt1.vPointCheckPlombTransVoltage.Rows.Count; i++)
                                SealRowsAdd((int)dsAbnObjAkt1.vPointCheckPlombTransVoltage.Rows[i]["id"],
                                            dsAbnObjAkt1.vPointCheckPlombTransVoltage.Rows[i]["SeriaNumber"].ToString(),
                                            (int)dsAbnObjAkt1.vPointCheckPlombTransVoltage.Rows[i]["idWorker"],
                                            dsAbnObjAkt1.vPointCheckPlombTransVoltage.Rows[i]["Location"].ToString(),
                                            dsAbnObjAkt1.vPointCheckPlombTransVoltage.Rows[i]["Comment"].ToString(),
                                            Seal.New,
                                            Device.TransVoltage);
                    }

                    //tbNumMeter.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NumberM"].ToString();
                    //tbTypeMeter.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NameM"].ToString();
                    //tbCapasityMeter.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DigitM"].ToString();
                    //// tbCurentValue.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["ValueKWT"].ToString();
                    //if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckM"].ToString() != "") qybCalibrationMeter.Date = DateTime.Parse(dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckM"].ToString());

                    //tbNumTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NumberTI"].ToString();
                    //tbTypeTransTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NameTI"].ToString();
                    //tbNomTransBegTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["PrimaryTI"].ToString();
                    //tbNomTransEndTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["SecondaryTI"].ToString();
                    //tbTransRatioTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["RatioTI"].ToString();
                    //if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckTI"].ToString() != "") qybCalibrationTransTI.Date = DateTime.Parse(dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckTI"].ToString());

                    //tbNumTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NumberTU"].ToString();
                    //tbTypeTransTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NameTU"].ToString();
                    //tbNomTransBegTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["PrimaryTU"].ToString();
                    //tbNomTransEndTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["SecondaryTU"].ToString();
                    //tbTransRatioTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["RatioTU"].ToString();
                    //if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckTU"].ToString() != "") qybCalibrationTransTU.Date = DateTime.Parse(dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckTU"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        public FormDocAct_CheckAdd(SQLSettings settings, int idAbnObj)
        {

            InitializeComponent();
            FormDocAct_CheckAdd_Load();
            this.idAbnObj = idAbnObj;
            this.SqlSettings = settings;
            try
            {
                bdsJobTitle.DataSource = dsAbnObjAkt1;
                bdsJobTitle.DataMember = dsAbnObjAkt1.tR_Classifier.TableName;
                bdsJobTitle.CurrentChanged += new EventHandler(bdsJobTitle_CurrentChanged);
                bdsWorker.DataSource = dsAbnObjAkt1;
                bdsWorker.DataMember = dsAbnObjAkt1.vP_Worker.TableName;
                cbOwnerJobTitle.DataSource = bdsJobTitle;
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vP_Worker, true, "WHERE idGroup IS NOT NULL");
                SelectSqlData(this.dsAbnObjAkt1, dsAbnObjAkt1.tR_Classifier, true, "where ParentKey = ';GroupWorker;ActMeter;' AND Deleted = 0 AND isGroup = 0");
                cbOwnerJobTitle.DisplayMember = "Name";
                cbOwnerJobTitle.ValueMember = "id";
                cbOwnerJobTitle.SelectedIndex = -1;
                SelectSqlData(dsAbnObjAkt1.vPointCheckMeterFill, true, String.Format("where idAbnObj = {0} and Type = {1}  and PointDateEnd is null ", idAbnObj, 245), null, true); //and PointRegDateEnd is null

                cbNumMeter.DataSource = dsAbnObjAkt1.vPointCheckMeterFill;
                cbNumMeter.DisplayMember = "Number";
                cbNumMeter.ValueMember = "idPointReg";
                cbNumMeter.SelectedIndex = -1;
                cbTypeMeter.DataSource = dsAbnObjAkt1.vPointCheckMeterFill;
                cbTypeMeter.DisplayMember = "Name";
                cbTypeMeter.ValueMember = "idPointReg";
                cbTypeMeter.SelectedIndex = -1;

 //               SelectSqlDataTableOther(dsAbn, dsAbn.tR_Classifier_ActType, "tR_Classifier", true, String.Format("where id in ({0},{1},{2},{3})", (int)DocType.ActCheck, (int)DocType.ActMeterDismantling, (int)DocType.ActMeterInstallation, (int)DocType.ActMeterkReplacement));
                SelectSqlDataTableOther(dsAbn, dsAbn.tR_Classifier_ActType, "tR_Classifier", true, String.Format("where id in ({0},{1},{2},{3},{4})", (int)DocType.ActCheck, (int)DocType.ActMeterDismantling, (int)DocType.ActMeterInstallation, (int)DocType.ActMeterkReplacement, (int)DocType.ActKO));
                 

                FillDataGridView();
                FillDataTransComboBoxControl(idAbnObj);
                DataSql.SqlDataConnect conn = new SqlDataConnect();
                conn.OpenConnection(settings);
                
                SqlCommand cmd = new SqlCommand("select tPointReg.idPoint, tPointReg.id from tPoint inner join tPointReg on tPointReg.idPoint = tPoint.id where tPoint.idAbnObj = " + idAbnObj, conn.Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtId = new DataTable();
                da.Fill(dtId);

                SelectSqlData(this.dsAbn, dsAbn.vPointRegCheck, true, "where idAbnObj = "+ idAbnObj.ToString());
                //FillPointDevice();
                
                // распоряжение
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vG_ActOrder, true, " where idObj = " + idAbnObj);
                if (dsAbnObjAkt1.tG_ActOrder.Rows.Count > 0)
                    cmbOrder.SelectedItem = dsAbnObjAkt1.tG_ActOrder.Rows[0]["idOrder"];
                else
                    cmbOrder.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        //private void FormDocAct_CheckAdd_Load(object sender, EventArgs e)
        private void FormDocAct_CheckAdd_Load()
        {
            this.dsAbnObjAkt1.DataSetName = "dsAbnObjAkt";
            this.dsAbnObjAkt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            this.bsTransfU.DataSource = this.dsAbnObjAkt1;
            this.bsTransfI.DataSource = this.dsAbnObjAkt1;
            this.bsActClassifierStrikeReveal.DataSource = this.dsAbnObjAkt1;
            this.bsActClassifierMalfunction.DataSource = this.dsAbnObjAkt1;

            //this.tsbEditPoint.Image = global::Legal.Properties.Resources._1304663141_Pen;
            ////this.tsbEditPoint.Image = global::Legal.Properties.Resources._1304663141_Pen;
            //this.tsbSealTransUDelete.Image = global::Legal.Properties.Resources.Delete;
            //this.tsbSealTransIAdd.Image = global::Legal.Properties.Resources._1304663065_Add;
            //this.tsbSealTransIDelete.Image = global::Legal.Properties.Resources.Delete;
            //this.tsbSealMeterAdd.Image = global::Legal.Properties.Resources._1304663065_Add;
            //this.tsbSealMeterDelete.Image = global::Legal.Properties.Resources.Delete;


        }
        #endregion

        void bdsJobTitle_CurrentChanged(object sender, EventArgs e)
        {
            if (cbNumMeter.Visible && bdsJobTitle.Current != null)
            {
                bdsWorker.Filter = String.Format("idGroup = {0}", (int)((DataRowView)bdsJobTitle.Current)["id"]);

                cbOwnerFIO.DataSource = bdsWorker;
                cbOwnerFIO.DisplayMember = "FIO";
                cbOwnerFIO.ValueMember = "id";
                if (dsAbn.tDocAct.Rows.Count > 0)
                    cbOwnerFIO.SelectedValue = (int)dsAbn.tDocAct.Rows[0]["IdWorker"];

            }
        }

        /// <summary> Очистка компонентов отображения информации по счетчикам
        /// </summary>
        private void ClearDataMeterControls(ComboBoxName value)
        {
            switch (value)
            {
                case ComboBoxName.cbNumMeter: cbTypeMeter.SelectedIndex = -1; break;
                case ComboBoxName.cbTypeMeter: cbNumMeter.SelectedIndex = -1; break;
                case ComboBoxName.cbAllMeter: cbTypeMeter.SelectedIndex = -1; cbNumMeter.SelectedIndex = -1; break;
                default: break;
            }
            tbCapasityMeter.Clear();
 
            qybCalibrationMeter.Clear();
        }

        /// <summary> Очистка компонентов отображения информации по трансформаторам
        /// </summary>
        private void ClearDataTransIControls(ComboBoxName value)
        {
            switch (value)
            {
                case ComboBoxName.cbNumMeter: cbTypeTransI.SelectedIndex = -1; break;
                case ComboBoxName.cbTypeMeter: tbNumTransI.Clear(); break;
                case ComboBoxName.cbAllMeter: tbNumTransI.Clear(); cbTypeTransI.SelectedIndex = -1; break;
                default: break;
            }
            tbNumTransI.Clear();
            cbTypeTransI.SelectedIndex = -1;
            tbNomTransIBeg.Clear();
            tbNomTransIEnd.Clear();
            tbRatioTransI.Clear();
            qybCalibrationTransI.Clear();
        }

        /// <summary> Очистка компонентов отображения информации по трансформаторам
        /// </summary>
        private void ClearDataTransUControls(ComboBoxName value)
        {
            switch (value)
            {
                case ComboBoxName.cbNumMeter: cbTypeTransU.SelectedIndex = -1; break;
                case ComboBoxName.cbTypeMeter: tbNumTransU.Clear(); break;
                case ComboBoxName.cbAllMeter: tbNumTransU.Clear(); cbTypeTransU.SelectedIndex = -1; break;
                default: break;
            }
            tbNomTransUBeg.Clear();
            tbNomTransUEnd.Clear();
            tbRatioTransU.Clear();
            qybCalibrationTransU.Clear();
        }

        /// <summary> Заполнения компонентов отображения информации по счетчикам
        /// </summary>
        private void FillDataMeterControls(int idAbnObj, string ColumnName, string ColumnValue)
        {
            DataRow[] dr = dsAbnObjAkt1.vPointCheckMeterFill.Select(ColumnName + " = '" + ColumnValue + "'");
            DateTime DateCheck;
            if (dr.Length > 0)
            {

                cbTypeMeter.Text = dr[0]["Name"].ToString();
                cbNumMeter.Text = dr[0]["Number"].ToString();

                tbCapasityMeter.Text = dr[0]["Digit"].ToString();
                if (DateTime.TryParse(dr[0]["DateCheck"].ToString(), out DateCheck)) qybCalibrationMeter.Date = DateCheck; else qybCalibrationMeter.Clear();
                idAbnObjMeter = (int)dr[0]["idAbnObj"];
                idPointMeter = (int)dr[0]["idPoint"];
                idPointRegMeter = (int)dr[0]["idPointReg"];
                if (!int.TryParse(dr[0]["idZone"].ToString(), out idZone)) idZone = (int)OnePartTariffType.TwentyFourHours;

                this.SelectSqlData(dsZone, dsZone.Tables["vR_Zone"], true, " where idZoneName = " + idZone.ToString());


                for (int i = 0; i < dsZone.Tables["vr_Zone"].Rows.Count; i++)
                {
                    //dsZone.Tables["vr_Zone"].Rows[i]["ValueBegin"] = 23;
                    for (int j = 0; j < dsAbnObjAkt1.vDocAct_Value.Rows.Count; j++)
                        if ((int)dsZone.Tables["vR_Zone"].Rows[i]["idSubZoneName"] == (int)dsAbnObjAkt1.vDocAct_Value.Rows[j]["idZone"])
                            dsZone.Tables["vR_Zone"].Rows[i]["valueBegin"] = (int)dsAbnObjAkt1.vDocAct_Value.Rows[j]["Value"];
                }

            }
            else
            {
                ClearDataMeterControls(ComboBoxName.cbTypeMeter);
                idAbnObjMeter = -1;
                idPointMeter = -1;
                idPointRegMeter = -1;
                cbTypeTransI.DataSource = null;
                cbTypeTransU.DataSource = null;
            }
        }

        /// <summary> Заполнение ComboBox-ов трансформаторов
        /// </summary>
        /// <param name="idAbnObj">Идентификатор объекта абонента</param>
        private void FillDataTransComboBoxControl(int idAbnObj)
        {
            SelectSqlData(dsAbnObjAkt1.vPointCheckTransFill, true, 
                String.Format("where idAbnObj = {0} and Type = {1} and PointRegDateEnd is null and PointDateEnd is null", idAbnObj, (int)DevicePointType.TransAmperage), null, true);

            var rowI = dsAbnObjAkt1.vPointCheckTransFill.NewvPointCheckTransFillRow();
            rowI.idAbnObj = -1;
            rowI.idPoint = -1;
            rowI.idPointReg = -1;
            rowI.Type = -1;
            rowI.Primary = 0;
            rowI.Secondary = 0;
            rowI.TypeTrans = 68;
            rowI.Name = "";
            dsAbnObjAkt1.vPointCheckTransFill.AddvPointCheckTransFillRow(rowI);

            var rowU = dsAbnObjAkt1.vPointCheckTransFill.NewvPointCheckTransFillRow();
            rowU.idAbnObj = -1;
            rowU.idPoint = -1;
            rowU.idPointReg = -1;
            rowU.Type = -1;
            rowU.Primary = 0;
            rowU.Secondary = 0;
            rowU.TypeTrans = 69;
            rowU.Name = "";
            dsAbnObjAkt1.vPointCheckTransFill.AddvPointCheckTransFillRow(rowU);

            //var tTransI = dsAbnObjAkt1.vPointCheckTransFill.Select("TypeTrans = " + (int)TransPointType.TransCurrent);
            //if (tTransI.Length > 0)
            //{
            //    cbTypeTransI.DataSource = tTransI.CopyToDataTable<DataRow>();
            //    cbTypeTransI.DisplayMember = "Name";
            //    cbTypeTransI.ValueMember = "idPointReg";
            //    cbTypeTransI.SelectedIndex = -1;
            //    idPointTransCurrent = (int)tTransI[0]["idPoint"];
            //}
            //else
            //    cbTypeTransI.DataSource = null;
            //var tTransU = dsAbnObjAkt1.vPointCheckTransFill.Select("TypeTrans = " + (int)TransPointType.TransVoltage);
            //if (tTransU.Length > 0)
            //{
            //    cbTypeTransU.DataSource = tTransU.CopyToDataTable<DataRow>();
            //    cbTypeTransU.DisplayMember = "Name";
            //    cbTypeTransU.ValueMember = "idPointReg";
            //    cbTypeTransU.SelectedIndex = -1;
            //    idPointTransVoltage = (int)tTransU[0]["idPoint"]; 
            //}
            //else
            //    cbTypeTransU.DataSource = null;
        }

        private void bsTransfI_CurrentChanged(object sender, EventArgs e)
        {
            FillDataTransControls(TransPointType.TransCurrent);
        }

        private void bsTransfU_CurrentChanged(object sender, EventArgs e)
        {
            //FillDataTransControls(TransPointType.TransVoltage, (int)((DataRowView)bsTransfU.Current)["idPointReg"]);
        }

        /// <summary> Заполнение компонентов отображения информации по трансформаторам
        /// </summary>
        private void FillDataTransControls(TransPointType Type)
        {
            switch (Type)
            {
                case TransPointType.TransCurrent:
                    //tbNumTransI.Text = ((DataRowView)bsTransfI.Current)["Number"].ToString();
                    //tbNomTransIBeg.Text = ((DataRowView)bsTransfI.Current)["Primary"].ToString();
                    //tbNomTransIEnd.Text = ((DataRowView)bsTransfI.Current)["Secondary"].ToString();
                    if (((DataRowView)bsTransfI.Current)["DateCheck"].ToString() != "")
                            qybCalibrationTransI.Date = DateTime.Parse(((DataRowView)bsTransfI.Current)["DateCheck"].ToString());
                    tbRatioTransI.Text = (int)((DataRowView)bsTransfI.Current)["Secondary"] == 0 ? "" :
                        int.Parse(((int)((DataRowView)bsTransfI.Current)["Primary"] / (int)((DataRowView)bsTransfI.Current)["Secondary"]).ToString()).ToString();
                        idAbnObjTransCurrent = (int)((DataRowView)bsTransfI.Current)["idAbnObj"];
                        idPointTransCurrent = (int)((DataRowView)bsTransfI.Current)["idPoint"];
                        idPointRegTransCurrent = (int)((DataRowView)bsTransfI.Current)["idPointReg"];
                    break;
                case TransPointType.TransVoltage:
                        tbNumTransU.Text = ((DataRowView)bsTransfU.Current)["Number"].ToString();
                        tbNomTransUBeg.Text = ((DataRowView)bsTransfU.Current)["Primary"].ToString();
                        tbNomTransUEnd.Text = ((DataRowView)bsTransfU.Current)["Secondary"].ToString();
                        if (((DataRowView)bsTransfU.Current)["DateCheck"].ToString() != "")  
                            qybCalibrationTransU.Date = DateTime.Parse(((DataRowView)bsTransfU.Current)["DateCheck"].ToString());
                        tbRatioTransU.Text = int.Parse((int.Parse(tbNomTransUBeg.Text) / int.Parse(tbNomTransUEnd.Text)).ToString()).ToString();
                        idAbnObjTransVoltage = (int)((DataRowView)bsTransfU.Current)["idAbnObj"];
                        idPointTransVoltage = (int)((DataRowView)bsTransfU.Current)["idPoint"];
                        idPointRegTransVoltage = (int)((DataRowView)bsTransfU.Current)["idPointReg"];
                    break;
                default:
                    idPointRegMeter = -1;
                    break;
            }
        }

        /// <summary> Заполнение данными dgvMalfunction и dgvStrikeReveal
        /// </summary>
        private void FillDataGridView()
        {

            SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.tR_ActClassifierMalfunction, "tR_ActClassifier", true, "where idParent = 1 order by id asc");
            SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.tR_ActClassifierStrikeReveal, "tR_ActClassifier", true, "where idParent = 2 order by id asc");

            for (int i = 0; i < dgvMalfunction.Rows.Count; i++) 
                dgvMalfunction.Rows[i].Cells["MalfunctionValue"].Value = false;
            for (int i = 0; i < dgvStrikeRreveal.Rows.Count; i++)
                dgvStrikeRreveal.Rows[i].Cells["StrikeRevealValue"].Value = false;

            dgvMalfunction.Columns[0].Visible = false;
            dgvStrikeRreveal.Columns[0].Visible = false;

        }

        private void PreservationOfData()
        {
            try
            {
                if (idPointMeter != -1)
                {
                    if (idPointRegTransCurrent != -1)
                    {
                        SelectSqlData(dsAbnObjAkt1.tPointReg, true, string.Format("where id = {0}", idPointRegTransCurrent), null, true);
                        if (dsAbnObjAkt1.tPointReg.Rows.Count == 0)
                        {
                            if (MessageBox.Show("Трансформатор тока не соответствует данной точке учета. \n\rПровести замену оборудования?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                            {
                                frmDeviceInstDem = new FormDocAct_DemUst(this.SqlSettings, idAbnObj, DocType.ActMeterkReplacement);
                                frmDeviceInstDem.ShowDialog();
                                return;
                            }
                        }
                    }


                    if (idPointRegTransVoltage != -1)
                    {
                        SelectSqlData(dsAbnObjAkt1.tPointReg, true, string.Format("where id = {0}", idPointRegTransVoltage), null, true);
                        if (dsAbnObjAkt1.tPointReg.Rows.Count == 0)
                        {
                            if (MessageBox.Show("Трансформатор напряжения не соответствует данной точке учета. \n\rПровести замену оборудования?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                            {
                                frmDeviceInstDem = new FormDocAct_DemUst(this.SqlSettings, idAbnObj, DocType.ActMeterkReplacement);
                                frmDeviceInstDem.ShowDialog();
                                return;
                            }
                        }
                    }

                   
                    idDocAct = tDocActInsert(idPointMeter, idPointRegMeter, (int)cbActType.SelectedValue, 0 , DateTime.Now, dtpActDate.Value, (int)cbOwnerFIO.SelectedValue, tbActNumber.Text);
                    //Добавляем показания
                    for (int i = 0; i < dsZone.Tables["vR_Zone"].Rows.Count; i++)
                    {
                        DataRow dr = dsAbn.tDocAct_Value.NewRow();
                        dr["idDocAct"] = idDocAct;
                        dr["idZone"] = (int)dsZone.Tables["vR_Zone"].Rows[i]["idSubZoneName"];
                        dr["Value"] =  (int)dsZone.Tables["vR_Zone"].Rows[i]["VAlueBegin"] ;
                        dsAbn.tDocAct_Value.Rows.Add(dr);
                        dsAbn.tDocAct_Value.Rows[i].EndEdit();
                    }
                    InsertSqlData(dsAbn, dsAbn.tDocAct_Value);

                    // Добаляем новую запись в таблицу tDocAct_Check
                    dsAbnObjAkt1.tDocAct_Check.AddtDocAct_CheckRow(idDocAct, tbRepresentPost.Text, tbRepresentFIO.Text, CollectionMalfunction(dgvMalfunction).Trim(), tbMalfunctionNote.Text,
                    nudFa.Value ,
                    nudFb.Value ,
                    nudFc.Value ,
                    nudTime.Value ,
                    nudSec.Value ,
                    nudS.Value ,
                    nudP.Value ,
                        //decimal.Parse(tbFa.Text),
                        //decimal.Parse(tbFb.Text),
                        //decimal.Parse(tbFc.Text), 
                        //decimal.Parse(tbTime.Text), 
                        //decimal.Parse(tbSec.Text), 
                        //decimal.Parse(tbS.Text),
                        //decimal.Parse(tbP.Text),
                        Convert.ToBoolean(cbConformityRate.SelectedIndex), tbConformityRateNote.Text, Convert.ToBoolean(cbPrincipScheme.SelectedIndex), tbPrincipSchemeNote.Text,
                        Convert.ToBoolean(cbFactConsuption.SelectedIndex), tbFactConsuptionNote.Text, dtpStrikeRrevealDate.Value, CollectionStrikeReveal(dgvStrikeRreveal), tbStrikeRrevealNote.Text, (int)ActObjState.Normal,
                        nudCos.Value);
                    idActCheck = InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tDocAct_Check);

                    //Добавляем новуя запись в таблицу tDocActDevice
                    dsAbnObjAkt1.tDocAct_Device.AddtDocAct_DeviceRow(idDocAct, idPointRegMeter, "", "", qybCalibrationMeter.Date);
                    idDeviceMeter = InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tDocAct_Device);
                    
                    
                    //Внесение пломб
                    InstSealFromDataTable((DataTable)dsAbnObjAkt1.SealMeterInst, idPointRegMeter, idDeviceMeter);
                    if (idPointRegTransCurrent > 0)
                    {
                        dsAbnObjAkt1.tDocAct_Device.Clear();
                        dsAbnObjAkt1.tDocAct_Device.AddtDocAct_DeviceRow(idDocAct, idPointRegTransCurrent, "", "", qybCalibrationTransI.Date);
                        idDeviceTransCurrent = InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tDocAct_Device);
                        InstSealFromDataTable(dsAbnObjAkt1.SealTransCurrentInst, idPointRegTransCurrent, idDeviceTransCurrent);
                    }
                    if (idPointRegTransVoltage > 0)
                    {
                        dsAbnObjAkt1.tDocAct_Device.Clear();
                        dsAbnObjAkt1.tDocAct_Device.AddtDocAct_DeviceRow(idDocAct, idPointRegTransVoltage, "", "", qybCalibrationTransU.Date);
                        idDeviceTransVoltage = InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tDocAct_Device);
                        InstSealFromDataTable(dsAbnObjAkt1.SealTransVoltageInst, idPointRegTransVoltage, idDeviceTransVoltage);
                    }                    

                    if (idActCheck != -1 && idDocAct != -1)
                    {
                        MessageBox.Show("Запись успешно добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormAbn frm = (FormAbn)Application.OpenForms["FormAbn"];
                        frm.ActReload(idAbnObj);
                        Close();
                    }
                    else
                    {
                        //DeleteSqlDataById(dsAbnObjAct1.tDocAct_Check, idActCheck);
                        //DeleteSqlDataById(dsAbnObjAct1.tDocAct, idDocAct);
                        //DeleteDevicePlomb(idDeviceMeter);
                        //DeleteDevicePlomb(idDeviceTransCurrent);
                        //DeleteDevicePlomb(idDeviceTransVoltage);
                    }
                }
                else
                {
                    if (MessageBox.Show("Добавить новую точку учета электроэнергии?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        frmDeviceInstDem = new FormDocAct_DemUst(this.SqlSettings, idAbnObj, DocType.ActMeterInstallation);
                        frmDeviceInstDem.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //DeleteSqlDataById(dsAbnObjAct1.tDocAct_Check, idActCheck);
                //DeleteSqlDataById(dsAbnObjAct1.tDocAct, idDocAct);
                //DeleteDevicePlomb(idDeviceMeter);
                //DeleteDevicePlomb(idDeviceTransCurrent);
                //DeleteDevicePlomb(idDeviceTransVoltage);
            }
        }

        //private void ActPointStateCheck()
        //{
        //    if (idPointRegMeter != -1)
        //    {
        //        // Meter corresponds to the point of electricity metering 
        //        MeterState = ActPointState.Normal;
        //        if (idPointRegTransCurrent != -1)
        //        {
        //            if (idPointMeter == idPointTransCurrent)
        //            {
        //                // Current transformer corresponds to the point of electricity metering 
        //                TransCurrentState = ActPointState.Normal;
        //            }
        //            else
        //            {
        //                // Current transformer is not corresponds to reality
        //                TransCurrentState = ActPointState.OtherPoint;
        //            }
        //        }
        //        else
        //        {
        //            // Сhecking for the presence of a current transformer
        //            TransCurrentState = ActPointState.NoPoint;
        //        }
        //        if (idPointRegTransVoltage != -1)
        //        {
        //            if (idPointMeter == idPointTransVoltage)
        //            {
        //                // Voltage transformer corresponds to the point of electricity metering 
        //                TransVoltageState = ActPointState.Normal;
        //            }
        //            else
        //            {
        //                // Voltage transformer is not corresponds to reality
        //                TransVoltageState = ActPointState.OtherPoint;
        //            }
        //        }
        //        else
        //        {
        //            // Checking for the presence of a voltage transformer
        //            TransVoltageState = ActPointState.NoPoint;
        //        }
        //    }
        //    else
        //    {
        //        // Checking for the presence of a meter
        //        MeterState = ActPointState.NoPoint;
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cbOwnerJobTitle.SelectedValue == null || cbOwnerFIO.SelectedValue == null) { MessageBox.Show("Выберите должность и/или фамилию составителя акта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (tbRepresentPost.Text == "" || tbRepresentFIO.Text == "") { MessageBox.Show("Выберите должность и/или фамилию представителя потребителя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (idPointMeter > 0 && qybCalibrationMeter.isNull) { MessageBox.Show("Не внесена дата поверки счетчика", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (idPointTransCurrent > 0 && qybCalibrationTransI.isNull) { MessageBox.Show("Не внесена дата поверки трансформатора тока", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (idPointRegTransVoltage > 0 && qybCalibrationTransU.isNull) { MessageBox.Show("Не внесена дата поверки трансформатора напряжения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            for (int i = 0; i < dsZone.Tables["vR_Zone"].Rows.Count; i++)
            {
                if (!int.TryParse(dsZone.Tables["vR_Zone"].Rows[i]["VAlueBegin"].ToString(), out ValueKWT)) { MessageBox.Show("Показания счетчика отсутствуют, либо введены не верно", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); dgvZoneIndicator.Focus(); return; };
            }

            PreservationOfData();
        }

        #region Event Control
        private void cbOwnerJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbNumMeter_Leave(object sender, EventArgs e)
        {
            DataRow[] drResult = dsAbnObjAkt1.vPointCheckMeterFill.Select("Name like '" + cbNumMeter.Text + "'");
            if (drResult.Length == 0)
            {

            }
        }

        private void cbNumMeter_TextChanged(object sender, EventArgs e)
        {
            if (cbNumMeter.Focused)
            {
                FillDataMeterControls(idAbnObj, "idPointReg", cbNumMeter.SelectedValue.ToString());
            }
        }

        private void cbTypeMeter_TextChanged(object sender, EventArgs e)
        {
            if (cbTypeMeter.Focused)
            {
                FillDataMeterControls(idAbnObj, "idPointReg", cbNumMeter.SelectedValue.ToString());
            }
        }

        //private void cbTypeTransI_TextChanged(object sender, EventArgs e)
        //{
        //    if (bsTransfI.Current != null)
        //    {
        //        FillDataTransControls(TransPointType.TransCurrent);
        //    }
        //    else
        //    {
        //        bsTransfI.Position = -1;
        //        tbNumTransI.Text = "";
        //        tbNomTransIBeg.Text = "";
        //        tbNomTransIEnd.Text = "";
        //        tbRatioTransI.Text = "";
        //        qybCalibrationTransI.Clear();
        //    }
        //}

        //private void cbTypeTransU_TextChanged(object sender, EventArgs e)
        //{
        //    if (bsTransfU.Current != null)
        //    {
        //        FillDataTransControls(TransPointType.TransVoltage);
        //    }
        //    else
        //    {
        //        bsTransfU.Position = -1;
        //        tbNumTransU.Text = "";
        //        tbNomTransUBeg.Text = "";
        //        tbNomTransUEnd.Text = "";
        //        tbRatioTransU.Text = "";
        //        qybCalibrationTransU.Clear();
        //    }
        //}

        //private void tbCos_TextChanged(object sender, EventArgs e)
        //{
        //    if (decimal.TryParse(tbS.Text, out s) && decimal.TryParse(tbCos.Text, out cos))
        //        tbP.Text = (s * cos).ToString();
        //}
        #endregion

        #region Заполнение DataTable'ов информацией об установке и демонтаже пломб
        public void SealRowsAdd(int idSeal, string Number, int idWorker, string Location, string Comment, Seal value, Device device)
        {
            switch (device)
            {
                case Device.Meter:
                    if (value == Seal.New) dsAbnObjAkt1.SealMeterInst.AddSealMeterInstRow(idSeal.ToString(), Number, "Установка", Location, Comment, idWorker.ToString());
                    if (value == Seal.Dis) dsAbnObjAkt1.SealMeterInst.AddSealMeterInstRow(idSeal.ToString(), Number, "Демонтаж", Location, Comment, idWorker.ToString());
                    dgvSealMeter.DataSource = dsAbnObjAkt1.SealMeterInst;                        
                    break;
                case Device.TransCurrent:
                    if (value == Seal.New) dsAbnObjAkt1.SealTransCurrentInst.AddSealTransCurrentInstRow(idSeal.ToString(), Number, "Установка", Location, Comment, idWorker.ToString());
                    if (value == Seal.Dis) dsAbnObjAkt1.SealTransCurrentInst.AddSealTransCurrentInstRow(idSeal.ToString(), Number, "Демонтаж", Location, Comment, idWorker.ToString());
                    dgvSealTransI.DataSource = dsAbnObjAkt1.SealTransCurrentInst;
                    break;
                case Device.TransVoltage:
                    if (value == Seal.New) dsAbnObjAkt1.SealTransVoltageInst.AddSealTransVoltageInstRow(idSeal.ToString(), Number, "Установка", Location, Comment, idWorker.ToString());
                    if (value == Seal.Dis) dsAbnObjAkt1.SealTransVoltageInst.AddSealTransVoltageInstRow(idSeal.ToString(), Number, "Демонтаж", Location, Comment, idWorker.ToString());
                    dgvSealTransU.DataSource = dsAbnObjAkt1.SealTransVoltageInst;
                    break;
                default:
                    break;
            }
        }

        public void SealRowsAdd(int idSeal, string Number, string Location, string Comment, Seal value, Device device)
        {
            switch (device)
            {
                case Device.Meter:
                    dsAbnObjAkt1.SealMeterInst.AddSealMeterInstRow(idSeal.ToString(), Number, "Установлена", Location, Comment, "-1");
                    dgvSealMeter.DataSource = dsAbnObjAkt1.SealMeterInst;
                    break;
                case Device.TransCurrent:
                    dsAbnObjAkt1.SealTransCurrentInst.AddSealTransCurrentInstRow(idSeal.ToString(), Number, "Установлена", Location, Comment, "-1");
                    dgvSealTransI.DataSource = dsAbnObjAkt1.SealTransCurrentInst;
                    break;
                case Device.TransVoltage:
                    dsAbnObjAkt1.SealTransVoltageInst.AddSealTransVoltageInstRow(idSeal.ToString(), Number, "Установлена", Location, Comment, "-1");
                    dgvSealTransU.DataSource = dsAbnObjAkt1.SealTransVoltageInst;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Обработка событий по нажатию клавиш установки пломб
        private void tsbSealMeterAdd_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbNumMeter.SelectedValue != null)
            {
                for (int i = 0; i < dgvSealMeter.RowCount; i++)
                    ids = dgvSealMeter.Rows[i].Cells["idMeter"].Value.ToString() + ",";
                if (ids.Length > 0) ids = ids.Remove(ids.Length - 1);
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceMeter, Convert.ToInt32(cbNumMeter.SelectedValue), ActPlomb.Installation, Device.Meter, ids);
             frm.ShowDialog();

                //if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombMeter, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", frm.idDevice));
                //    idDeviceMeter = frm.idDevice;
                //}


            }
            else
                MessageBox.Show("Выберите счетчик электроэнергии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbSealTransIAdd_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeTransI.SelectedValue != null)
            {
                for (int i = 0; i < dgvSealTransI.RowCount; i++)
                    ids = dgvSealTransI.Rows[i].Cells["idTransI"].Value.ToString() + ",";
                if (ids.Length > 0) ids = ids.Remove(ids.Length - 1);
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceTransCurrent, Convert.ToInt32(cbTypeTransI.SelectedValue), ActPlomb.Installation, Device.TransCurrent, ids);
                frm.ShowDialog();
                //if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombTransCurrent, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", frm.idDevice));
                //    idDeviceTransCurrent = frm.idDevice;
                //}
            }
            else
                MessageBox.Show("Выберите трансформатор тока", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bsOrder_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tsbSealTransUAdd_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeTransU.SelectedValue != null)
            {
                for (int i = 0; i < dgvSealTransU.RowCount; i++)
                    ids = dgvSealTransU.Rows[i].Cells["idTransU"].Value.ToString() + ",";
                if (ids.Length > 0) ids = ids.Remove(ids.Length - 1);
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceTransVoltage, Convert.ToInt32(cbTypeTransU.SelectedValue), ActPlomb.Installation, Device.TransVoltage, ids);
                frm.ShowDialog();
                //if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombTransVoltage, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", frm.idDevice));
                //    idDeviceTransVoltage = frm.idDevice;
                //}

            }
            else
                MessageBox.Show("Выберите трансформатор напряжения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Обработка событий по нажатию клавиш демонтажа пломб
        private void tsbSealMeterDelete_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbNumMeter.SelectedValue != null)
            {
                for (int i = 0; i < dgvSealMeter.RowCount; i++)
                    if (dgvSealMeter.Rows[i].Cells["ActMeter"].Value.ToString() != "Демонтаж")
                        ids = dgvSealMeter.Rows[i].Cells["idMeter"].Value.ToString() + ",";
                if (ids.Length > 0) ids = ids.Remove(ids.Length - 1);
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceMeter, Convert.ToInt32(cbTypeMeter.SelectedValue), ActPlomb.Dismantling, Device.Meter, ids);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombMeter, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", frm.idDevice));
                    idDeviceMeter = frm.idDevice;           
                }
            }
            else
                MessageBox.Show("Выберите счетчик электроэнергии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbSealTransIDelete_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeTransI.SelectedValue != null)
            {
                for (int i = 0; i < dgvSealMeter.RowCount; i++)
                    if (dgvSealMeter.Rows[i].Cells["ActTransI"].Value.ToString() != "Демонтаж")
                        ids = dgvSealMeter.Rows[i].Cells["idTransI"].Value.ToString() + ",";
                if (ids.Length > 0) ids = ids.Remove(ids.Length - 1);
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceTransCurrent, Convert.ToInt32(cbTypeTransI.SelectedValue), ActPlomb.Dismantling, Device.TransCurrent, ids);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombTransCurrent, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", frm.idDevice));
                    idDeviceTransCurrent = frm.idDevice;
                }
            }
            else
                MessageBox.Show("Выберите трансформатор тока", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbSealTransUDelete_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeTransU.SelectedValue != null)
            {
                for (int i = 0; i < dgvSealMeter.RowCount; i++)
                    if (dgvSealMeter.Rows[i].Cells["ActTransU"].Value.ToString() != "Демонтаж")
                        ids = dgvSealMeter.Rows[i].Cells["idTransU"].Value.ToString() + ",";
                if (ids.Length > 0) ids = ids.Remove(ids.Length - 1);
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceTransVoltage, Convert.ToInt32(cbTypeTransU.SelectedValue), ActPlomb.Dismantling, Device.TransVoltage, ids);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombTransVoltage, "vPointCheckPlomb", true, String.Format("where idDevice = {0}", frm.idDevice));
                    idDeviceTransVoltage = frm.idDevice;
                }
            }
            else
                MessageBox.Show("Выберите трансформатор напряжения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        private void tsSealTransI_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //FillPointDevice();
            bsPointReg_CurrentChanged(bsPointReg, e);
        }

        private void tsbEditPoint_Click(object sender, EventArgs e)
        {
            if (dgvPointRegCheck.RowCount > 0)
            {
                int idPoint = Convert.ToInt32(dgvPointRegCheck.CurrentRow.Cells["idPoint"].Value);
                Meter.FormMeterAddEdit fAdd = new Meter.FormMeterAddEdit(idAbnObj, idPoint, false);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.ShowDialog();
                SelectSqlData(dsAbn.vPointRegCheck, true, "where idAbnObj = " + idAbnObj.ToString());

                SelectSqlData(dsAbnObjAkt1.vPointCheckMeterFill, true, String.Format("where idAbnObj = {0} and Type = {1}  and PointDateEnd is null ", idAbnObj, 245), null, true); //and PointRegDateEnd is null

                // dsAbnObjAct1.vPointCheckMeterFill.AddvPointCheckMeterFillRow(-1, -1, -1, -1, "Другой номер", "Другой", 0, -1, DateTime.Now, DateTime.Now, DateTime.Now);     

                cbNumMeter.DataSource = dsAbnObjAkt1.vPointCheckMeterFill;
                cbNumMeter.DisplayMember = "Number";
                cbNumMeter.ValueMember = "idPointReg";
                cbNumMeter.SelectedIndex = -1;
                cbTypeMeter.DataSource = dsAbnObjAkt1.vPointCheckMeterFill;
                cbTypeMeter.DisplayMember = "Name";
                cbTypeMeter.ValueMember = "idPointReg";
                cbTypeMeter.SelectedIndex = -1;
                FillDataGridView();
                FillDataTransComboBoxControl(idAbnObj);
  
                //FillPointDevice();

            }
        }

        //private void FillPointDevice()
        //{
        //    int idCurrent = -1;

        //    if (dgvPointRegCheck.RowCount > 0)
        //    {
        //        if (idDocAct > 0)
        //        {

        //            if (SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckActDevice, true, "where idDocAct = " + idDocAct, 1))
        //            {
        //                if (dgvPointRegCheck.CurrentRow.Cells["idMPR"].Value.ToString() != "") cbNumMeter.SelectedValue = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idMPR"].ToString(); // dgvPointRegCheck.CurrentRow.Cells["idMPR"].Value.ToString();
        //                FillDataMeterControls(idAbnObj, "idPointReg", cbNumMeter.SelectedValue.ToString());

        //                // dgvPointRegCheck.CurrentRow.Cells["idTIPR"].Value.ToString();
        //                if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTIPR"].ToString() != "")
        //                {
        //                    bsTransfI.Position = bsTransfI.Find("idPointReg", (int)dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTIPR"]);
        //                    //FillDataTransControls(TransPointType.TransCurrent);
        //                }
        //                else
        //                {
        //                    bsTransfI.Position = -1;
        //                }
        //                //dgvPointRegCheck.CurrentRow.Cells["idTUPR"].Value.ToString();
        //                if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTUPR"].ToString() != "") 
        //                {
        //                    FillDataTransControls(TransPointType.TransVoltage);
        //                    cbTypeTransU.SelectedValue = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTUPR"].ToString();
        //                }
        //                else
        //                {
        //                    bsTransfU.Position = -1;
        //                    tbNumTransU.Text = "";
        //                    tbNomTransUBeg.Text = "";
        //                    tbNomTransUEnd.Text = "";
        //                    tbRatioTransU.Text = "";
        //                    qybCalibrationTransU.Clear();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (dgvPointRegCheck.CurrentRow.Cells["idMPR"].Value.ToString() != "") 
        //                cbNumMeter.SelectedValue = dgvPointRegCheck.CurrentRow.Cells["idMPR"].Value.ToString();
        //            FillDataMeterControls(idAbnObj, "idPointReg", cbNumMeter.SelectedValue.ToString());

                    
        //            if (int.TryParse(dgvPointRegCheck.CurrentRow.Cells["idTIPR"].Value.ToString(), out idCurrent))
        //            {

        //                bsTransfI.Position = bsTransfI.Find("idPointReg", idCurrent);
        //                //cbTypeTransI.SelectedValue = dgvPointRegCheck.CurrentRow.Cells["idTIPR"].Value.ToString();
        //                //FillDataTransControls(TransPointType.TransCurrent);
        //            }
        //            else
        //            {
        //                bsTransfI.Position = -1;
        //                //tbNumTransI.Text = "";
        //                //tbNomTransIBeg.Text = "";
        //                //tbNomTransIEnd.Text = "";
        //                //tbRatioTransI.Text = "";
        //                //qybCalibrationTransI.Clear();
        //            }
        //            if (int.TryParse(dgvPointRegCheck.CurrentRow.Cells["idTUPR"].Value.ToString(), out idCurrent))
        //            {
        //                cbTypeTransU.SelectedValue = idCurrent;
        //                FillDataTransControls(TransPointType.TransVoltage);
        //            }
        //            else
        //            {
        //                bsTransfU.Position = -1;
        //                tbNumTransU.Text = "";
        //                tbNomTransUBeg.Text = "";
        //                tbNomTransUEnd.Text = "";
        //                tbRatioTransU.Text = "";
        //                qybCalibrationTransU.Clear();
        //            }
        //        }

        //    }
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        // принудительно завершить редактирование ячейки(галочки)
        private void dgvMalfunction_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvMalfunction.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }

        private void FormDocAct_CheckAdd_Shown(object sender, EventArgs e)
        {
            bdsJobTitle_CurrentChanged(bdsJobTitle, new EventArgs());
        }

        private void bsPointReg_CurrentChanged(object sender, EventArgs e)
        {
            int idCurrent = -1;
            if (bsPointReg.Current != null)
            {
                if (idDocAct > 0)
                {
                    if (SelectSqlData(dsAbnObjAkt1.vPointCheckActDevice, true, "where idDocAct = " + idDocAct, null,false,1))
                    {
                        if (dgvPointRegCheck.CurrentRow.Cells["idMPR"].Value.ToString() != "")
                            cbNumMeter.SelectedValue = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idMPR"].ToString(); // dgvPointRegCheck.CurrentRow.Cells["idMPR"].Value.ToString();
                        FillDataMeterControls(idAbnObj, "idPointReg", cbNumMeter.SelectedValue.ToString());

                        if (int.TryParse(dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTIPR"].ToString(), out idCurrent))
                        {
                            bsTransfI.Position = bsTransfI.Find("idPointReg", idCurrent);
                        }
                        else
                        {
                            cbTypeTransI.SelectedValue = -1;
                            tbNumTransI.Text = "";
                            tbNomTransIBeg.Text = "";
                            tbNomTransIEnd.Text = "";
                            tbRatioTransI.Text = "";
                            qybCalibrationTransI.Clear();
                        }

                        if (int.TryParse(dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTUPR"].ToString(), out idCurrent))
                        {
                            bsTransfU.Position = bsTransfU.Find("idPointReg", idCurrent);
                        }
                        else
                        {
                            cbTypeTransU.SelectedValue = -1;
                            tbNumTransU.Text = "";
                            tbNomTransUBeg.Text = "";
                            tbNomTransUEnd.Text = "";
                            tbRatioTransU.Text = "";
                            qybCalibrationTransU.Clear();
                        }
                    }
                }
                else
                {
                    if (int.TryParse(((DataRowView)bsPointReg.Current)["idMPR"].ToString(), out idCurrent))
                        cbNumMeter.SelectedValue = idCurrent;                    
                    FillDataMeterControls(idAbnObj, "idPointReg", cbNumMeter.SelectedValue.ToString());

                    if (int.TryParse(((DataRowView)bsPointReg.Current)["idTIPR"].ToString(), out idCurrent))
                    {
                        bsTransfI.Position = bsTransfI.Find("idPointReg", idCurrent);
                        if (bsTransfI.Position == 0)
                        {
                            //cbTypeTransI.SelectedValue = -1;
                            //tbNumTransI.Text = "";
                            //tbNomTransIBeg.Text = "";
                            //tbNomTransIEnd.Text = "";
                            //tbRatioTransI.Text = "";
                            //qybCalibrationTransI.Clear();
                        }

                    }
                    else
                    {
                        cbTypeTransI.SelectedValue = -1;
                        tbNumTransI.Text = "";
                        tbNomTransIBeg.Text = "";
                        tbNomTransIEnd.Text = "";
                        tbRatioTransI.Text = "";
                        qybCalibrationTransI.Clear();
                    }

                    if (int.TryParse(((DataRowView)bsPointReg.Current)["idTUPR"].ToString(), out idCurrent))
                    {
                        bsTransfU.Position = bsTransfU.Find("idPointReg", idCurrent);
                        if (bsTransfU.Position == 0)
                        {
                            //cbTypeTransU.SelectedValue = -1;
                            //tbNumTransU.Text = "";
                            //tbNomTransUBeg.Text = "";
                            //tbNomTransUEnd.Text = "";
                            //tbRatioTransU.Text = "";
                            //qybCalibrationTransU.Clear();
                        }
                    }
                    else
                    {
                        cbTypeTransU.SelectedValue = -1;
                        tbNumTransU.Text = "";
                        tbNomTransUBeg.Text = "";
                        tbNomTransUEnd.Text = "";
                        tbRatioTransU.Text = "";
                        qybCalibrationTransU.Clear();
                    }
                }
            }
        }

        private void btnOrderSave_Click(object sender, EventArgs e)
        {
            if (dsAbnObjAkt1.tG_ActOrder.Rows.Count > 0)
            {
                // обновим привязку акта к распоряжению
                dsAbnObjAkt1.tG_ActOrder.Rows[0].BeginEdit();
                dsAbnObjAkt1.tG_ActOrder.Rows[0]["idAct"] = idActCheck ; 
                dsAbnObjAkt1.tG_ActOrder.Rows[0]["idOrder"] = Convert.ToInt32(cmbOrder.SelectedValue);
                dsAbnObjAkt1.tG_ActOrder.Rows[0]["idObj"] = idAbnObj;
                dsAbnObjAkt1.tG_ActOrder.Rows[0].EndEdit();
                bool isOk = false;
                isOk = UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tG_ActOrder);
                if (isOk)
                    MessageBox.Show("Акт привязан к распоряжению..");
                else
                    MessageBox.Show("Сохранение не удалось..");
            }
            else
            // создадим новую привязку
            {
                DataRow dr = dsAbnObjAkt1.tG_ActOrder.NewRow();
                dr["idAct"] = idActCheck;
                dr["idOrder"] = Convert.ToInt32(cmbOrder.SelectedValue);
                dr["idObj"] = idAbnObj;
                dsAbnObjAkt1.tG_ActOrder.Rows.Add(dr);
                int id = 0;
                id = InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tG_ActOrder);
                if (id > 0)
                    MessageBox.Show("Акт привязан к распоряжению..");
                else
                    MessageBox.Show("Сохранение не удалось..");
            }

        }

        

    }
}
