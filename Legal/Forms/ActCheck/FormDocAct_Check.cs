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

namespace Legal.Forms
{
    public partial class FormDocAct_Check : FormLbr.FormBase
    {
        int idAbnObj, idActCheck;
        //DataRow[] drMalfunction, drStrikeReveal;

        public FormDocAct_Check()
        {
            InitializeComponent();
        }

        public FormDocAct_Check(SQLSettings settings, int idAbnObj)
        {
            InitializeComponent();
            dgvMalfunction.Columns[0].Visible = false;

            this.SqlSettings = settings;
            this.idAbnObj = idAbnObj;
            FillDataGridView();
            FilldgvAkt(idAbnObj);
            if (dgvAkt.RowCount > 0) LoadAct();
        }

        public FormDocAct_Check(SQLSettings settings, int idAbnObj, int idActCheck)
        {
            InitializeComponent();

            dgvMalfunction.Columns[0].Visible = false;

            this.SqlSettings = settings;
            this.idAbnObj = idAbnObj;
            this.idActCheck = idActCheck;
            FillDataGridView();
            FilldgvAkt(idAbnObj);
            if (dgvAkt.RowCount > 0)
            {
                dgvAkt.Focus();
                LoadAct();
            }

        }

        #region Procedures
        private void FilldgvAkt(int idAbnObj)
        {
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vDocActCheck, true, "where idAbnObj = " + idAbnObj + " Order by DateAct desc");

            
        }
        #endregion


        public void LoadAct()
        {
            idActCheck = Convert.ToInt32(dgvAkt.CurrentRow.Cells["idDocAct"].Value);

            ClearAll();

                SelectSqlData(dsAbnObjAkt1.tDocAct_Check, true, "where idDocAct = " + idActCheck, null, false, 1);

                tbA.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["Fa"]);
                tbB.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["Fb"]);
                tbC.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["Fc"]);
                tbt.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["n"]);
                tbSek.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["t"]);
                tbS.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["Sfakt"]);
                tbP.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["Psch"]);

                cbConformityRate.SelectedIndex = Convert.ToInt16(dsAbnObjAkt1.tDocAct_Check.Rows[0]["ConformityRate"]);
                tbConformityRateNote.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["ConformityRateNote"]);
                cbPrincipScheme.SelectedIndex = Convert.ToInt16(dsAbnObjAkt1.tDocAct_Check.Rows[0]["PrincipScheme"]);
                tbPrincipSchemeNote.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["PrincipSchemeNote"]);
                cbFactConsuption.SelectedIndex = Convert.ToInt16(dsAbnObjAkt1.tDocAct_Check.Rows[0]["FactConsuption"]);
                tbFactConsuptionNote.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["FactConsuptionNote"]);
                //if (dsAbnObjAct1.tDocAct_Check.Rows[0]["Malfunction"] != null)
                //{
                //    string[] MalfunctionArr = Convert.ToString(dsAbnObjAct1.tDocAct_Check.Rows[0]["Malfunction"]).Split(';');
                //    for (int i = 0; i < dgvMalfunction.RowCount && i < MalfunctionArr.Length; i++) dgvMalfunction.Rows[i].Cells["MalfunctionValue"].Value = (MalfunctionArr[i] == "1") ? true : false;
                //}
                //if (dsAbnObjAct1.tDocAct_Check.Rows[0]["StrikeReveal"] != null)
                //{
                //    string[] StrikeRevealArr = Convert.ToString(dsAbnObjAct1.tDocAct_Check.Rows[0]["StrikeReveal"]).Split(';');
                //    for (int i = 0; i < dgvStrikeRreveal.RowCount && i < StrikeRevealArr.Length; i++) dgvStrikeRreveal.Rows[i].Cells["StrikeRevealValue"].Value = (StrikeRevealArr[i] == "1") ? true : false;
                //}

              //  MessageBox.Show(dsAbnObjAkt1.tDocAct_Check.Rows[0]["Malfunction"].ToString());

                if (dsAbnObjAkt1.tDocAct_Check.Rows[0]["Malfunction"] != null)
                {
                    string[] MalfunctionArr = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["Malfunction"]).Split(';');
                    for (int i = 0; i < MalfunctionArr.Length; i++) //i <dgvMalfunction.RowCount &&
                        dsAbnObjAkt1.tR_ActClassifierMalfunction.Rows[i]["MalfunctionValue"] = (MalfunctionArr[i] == "1") ? true : false;
                }
            

                if (dsAbnObjAkt1.tDocAct_Check.Rows[0]["StrikeReveal"] != null)
                {
                    string[] StrikeRevealArr = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["StrikeReveal"]).Split(';');
                    for (int i = 0; i < StrikeRevealArr.Length; i++) //i < dgvStrikeRreveal.RowCount &&
                        dsAbnObjAkt1.tR_ActClassifierStrikeReveal.Rows[i]["StrikeRevealValue"] = (StrikeRevealArr[i] == "1") ? true : false;
                }


                tbMalfunctionNote.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["MalfunctionNote"]);
                tbStrikeRrevealNote.Text = Convert.ToString(dsAbnObjAkt1.tDocAct_Check.Rows[0]["StrikeRevealNote"]);

                dtpStrikeRrevealDate.Value = (dsAbnObjAkt1.tDocAct_Check.Rows[0]["StrikeRevealDate"].ToString() != "") ? Convert.ToDateTime(dsAbnObjAkt1.tDocAct_Check.Rows[0]["StrikeRevealDate"]) : Convert.ToDateTime("1917.11.07");


                cbAllDataMalfunction.CheckState = CheckState.Checked;
                cbAllDataStrikeReveal.CheckState = CheckState.Checked;

                dgvMalfunction.Columns[0].Visible = false;
                dgvStrikeRreveal.Columns[0].Visible = false;
                //bsActClassifierMalfunction.Filter = "MalfunctionValue = true";
                //bsActClassifierStrikeReveal.Filter = "StrikeRevealValue = true";


                if (SelectSqlData(dsAbnObjAkt1.vPointCheckActDevice, true, "where idDocAct = " + idActCheck, null, false, 1))
                {
                    tbNumMeter.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NumberM"].ToString();
                    tbTypeMeter.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NameM"].ToString();
                    tbCapasityMeter.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DigitM"].ToString();
                   // tbCurentValue.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["ValueKWT"].ToString();
                    if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckM"].ToString() != "") qybCalibrationMeter.Date = DateTime.Parse(dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckM"].ToString());

                    tbNumTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NumberTI"].ToString();
                    tbTypeTransTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NameTI"].ToString();
                    tbNomTransBegTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["PrimaryTI"].ToString();
                    tbNomTransEndTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["SecondaryTI"].ToString();
                    tbTransRatioTI.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["RatioTI"].ToString();
                    if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckTI"].ToString() != "") qybCalibrationTransTI.Date = DateTime.Parse(dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckTI"].ToString());

                    tbNumTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NumberTU"].ToString();
                    tbTypeTransTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["NameTU"].ToString();
                    tbNomTransBegTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["PrimaryTU"].ToString();
                    tbNomTransEndTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["SecondaryTU"].ToString();
                    tbTransRatioTU.Text = dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["RatioTU"].ToString();
                    if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckTU"].ToString() != "") qybCalibrationTransTU.Date = DateTime.Parse(dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["DateCheckTU"].ToString());
                }
            //Показания акта
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vDocAct_Value, true, "where idDocAct = " + idActCheck);


                if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idMDAD"].ToString() != "" ) 
                    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombMeter, "vPointCheckPlomb", true, "where idDevice = " + dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idMDAD"].ToString());
                dgvSealTransM.Columns[0].Visible = false;

                if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTIDAD"].ToString() != "")
                    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombTransCurrent, "vPointCheckPlomb", true, "where idDevice = " + dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTIDAD"].ToString());
                dgvSealTransTI.Columns[0].Visible = false;
                if (dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTUDAD"].ToString() != "")
                    SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombTransVoltage, "vPointCheckPlomb", true, "where idDevice = " + dsAbnObjAkt1.vPointCheckActDevice.Rows[0]["idTUDAD"].ToString());
                dgvSealTransTU.Columns[0].Visible = false;


        } 
        private void FillDataGridView()
        {
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tR_ActClassifier, true);

            SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.tR_ActClassifierMalfunction, "tR_ActClassifier", true, "where idParent = 1 order by id asc");
            SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.tR_ActClassifierStrikeReveal, "tR_ActClassifier", true, "where idParent = 2 order by id asc");

            dgvMalfunction.Columns[0].Visible = false;
            dgvStrikeRreveal.Columns[0].Visible = false;
            //drMalfunction = dsAbnObjAct1.tR_ActClassifier.Select("idParent = 1");
            //drStrikeReveal = dsAbnObjAct1.tR_ActClassifier.Select("idParent = 2");
            //dgvMalfunction.DataSource = drMalfunction.CopyToDataTable<DataRow>();
            //dgvStrikeRreveal.DataSource = drStrikeReveal.CopyToDataTable<DataRow>();

        }

        private void tcCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMalfunction.Columns[0].Visible = false;
            dgvStrikeRreveal.Columns[0].Visible = false;
        }

        private void cbAllDataMalfunction_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllDataMalfunction.Checked)
            {
                bsActClassifierMalfunction.Filter = "MalfunctionValue = true";
            }
            else
            {
                bsActClassifierMalfunction.Filter = "";
            }
        }

        private void cbAllDataStrikeReveal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllDataStrikeReveal.Checked)
            {
                bsActClassifierStrikeReveal.Filter = "StrikeRevealValue = true";
            }
            else
            {
                bsActClassifierStrikeReveal.Filter = "";
            }
        }


        private void ClearAll ()
        { 
               
                tbA.Text = "";
                tbB.Text = "";
                tbC.Text = "";
                tbt.Text = "";
                tbSek.Text = "";
                tbS.Text = "";
                tbP.Text = "";

                

                for (int i = 0; i < dsAbnObjAkt1.tR_ActClassifierMalfunction.Rows.Count; i++)
                {
                    dsAbnObjAkt1.tR_ActClassifierMalfunction.Rows[i]["MalfunctionValue"] = false;
                }
                for (int i = 0; i <  dsAbnObjAkt1.tR_ActClassifierStrikeReveal.Rows.Count; i++)
                {
                    dsAbnObjAkt1.tR_ActClassifierStrikeReveal.Rows[i]["StrikeRevealValue"] = false;
                }

                dgvMalfunction.Columns[0].Visible = false;
                dgvStrikeRreveal.Columns[0].Visible = false;

                tbNumMeter.Text = "";
                tbTypeMeter.Text = "";
                tbCapasityMeter.Text = "";
                //tbCurentValue.Text = "";
                qybCalibrationMeter.Clear();
            
                tbNumTI.Text = "";
                tbTypeTransTI.Text = "";
                tbNomTransBegTI.Text = "";
                tbNomTransEndTI.Text = "";
                tbTransRatioTI.Text = "";
                qybCalibrationTransTI.Clear();

                tbNumTU.Text = "";
                tbTypeTransTU.Text = "";
                tbNomTransBegTU.Text = "";
                tbNomTransEndTU.Text = "";
                tbTransRatioTU.Text = "";
                qybCalibrationTransTU.Clear();


        }

        private void dgvAkt_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadAct();
        }

        private void dgvAkt_KeyUp(object sender, KeyEventArgs e)
        {
            LoadAct();
        }

    
    }
}
