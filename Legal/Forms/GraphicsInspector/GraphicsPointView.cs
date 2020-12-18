using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;


namespace Legal.Forms.GraphicsInspector
{
    public partial class FormGraphicsView : FormLbr.FormBase
    {
        private string G_Year;
        private int G_Month;
        private DateTime G_Date;
        private int ID = 0;

        private class ItemChecked
        {

            public string Name { get; set; }
            public int Id { get; set; }

            public ItemChecked()
            {
            }

            public ItemChecked(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public FormGraphicsView()
        {
            InitializeComponent();
        }

        public FormGraphicsView(int id)
        {
            InitializeComponent();
            ID = id;
        }


        private void FormGraphicsView_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

           

            groupBoxWait.Visible = false;
            groupBoxWaitBegin.Visible = false;
            //GraphicDGVEF.Columns["check"].Visible = false;
            for (int i = 2009; i <= 2050; i++)
                comboBoxYear.Items.Add(i);
            comboBoxYear.SelectedIndex = comboBoxYear.FindString(DateTime.Today.Year.ToString());

            for (int i = 2009; i <= 2050; i++)
            comboBoxYearRep.Items.Add(i);
            comboBoxYearRep.SelectedIndex = comboBoxYearRep.FindString(DateTime.Today.Year.ToString());

            this.SelectSqlData(dsAbn, dsAbn.Tables["vWorkerGroup"], true, " where idGRoup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + " and dateEnd is null order by FIO");

           // backgroundWorkerGraphBegin.RunWorkerAsync();
            //MessageBox.Show(GraphicDGVEF.ColumnCount.ToString()); 

            cmbView.SelectedIndex = 0;
            //this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointViewSmall, true, "  order by CodeAbonent  ");
            //this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointView, true, "  order by CodeAbonent  "); // where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent 
            if (GraphicDGVEF.RowCount>0) GetData();

            LoadMasters();

            //groupBoxWaitBegin.Visible = false;
            //this.reportViewerRepMastersG.RefreshReport();
          //  this.reportViewerRepMastersAll.RefreshReport();
          //  this.reportViewerRepMastersG_All.RefreshReport();

            Cursor.Current = Cursors.Default;

          //  this.reportViewerNoObsl.RefreshReport();
            this.reportViewerOrder.RefreshReport();

            panelGraph.Visible = true;
            panelGraph1.Visible = false;
            panelGraph2.Visible = false;

            if (ID > 0)
            {
                cmbView.SelectedIndex = 1;
                GraphView();
            }
        }

        private void GetData()
        {
            if (cmbView.SelectedIndex == 1)
            {
                tbAbn.Text = GraphicDGVEF.CurrentRow.Cells["nameAbnDGVTBC"].Value.ToString();
                this.SelectSqlData(dsAbn, dsAbn.vPointReg, true, " where idpoint = " + GraphicDGVEF.CurrentRow.Cells["idPoint"].Value.ToString() + " order by DateBegin desc");
            }
            else
            {
                tbAbn.Text = GraphicDGVEFSmall.CurrentRow.Cells["nameAbnDGVTBCSmall"].Value.ToString();
            }
        }
      
        private void GraphicDGVEF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetData();
        }

        private void GraphicDGVEF_KeyUp(object sender, KeyEventArgs e)
        {
            GetData();
        }

 
        private void cbCheck_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbCheck.CheckState)
            {
                case CheckState.Checked:
                    if (cmbView.SelectedIndex == 1) 
                    for (int i = 0; i < GraphicDGVEF.RowCount; i++)
                    {
                        GraphicDGVEF.Rows[i].Cells["check"].Value = true;
                    }
                    else
                    for (int i = 0; i < GraphicDGVEFSmall.RowCount; i++)
                    {
                        GraphicDGVEFSmall.Rows[i].Cells["checkSmall"].Value = true;
                    }

                    break;
                default:
                    if (cmbView.SelectedIndex == 1) 
                    for (int i = 0; i < GraphicDGVEF.RowCount; i++)
                    {
                        GraphicDGVEF.Rows[i].Cells["check"].Value = false;
                    }
                    for (int i = 0; i < GraphicDGVEFSmall.RowCount; i++)
                    {
                        GraphicDGVEFSmall.Rows[i].Cells["checkSmall"].Value = false;
                    }
                    break;
            }
        }

        private void buttonIns_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(GraphicDGVEF.RowCount.ToString());

            for (int i = 0; i < GraphicDGVEF.RowCount; i++)
            {
                if (GraphicDGVEF.Rows[i].Cells["check"].Value != DBNull.Value && GraphicDGVEF.Rows[i].Cells["check"].Value != null ) //
                {
                    if ((bool)GraphicDGVEF.Rows[i].Cells["check"].Value)
                    {
                        if (NJanuary.Value > 0) InsDate((int)NJanuary.Value, 1 , (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NFebruary.Value > 0) InsDate((int)NFebruary.Value, 2, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NMarch.Value > 0) InsDate((int)NMarch.Value, 3, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NApril.Value > 0) InsDate((int)NApril.Value, 4, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NMay.Value > 0) InsDate((int)NMay.Value,5, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NJune.Value > 0) InsDate((int)NJune.Value, 6, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NJuly.Value > 0) InsDate((int)NJuly.Value, 7, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NAugust.Value > 0) InsDate((int)NAugust.Value, 8, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NSeptember.Value > 0) InsDate((int)NSeptember.Value, 9, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NOctober.Value > 0) InsDate((int)NOctober.Value, 10, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NNovember.Value > 0) InsDate((int)NNovember.Value, 11, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        if (NDecember.Value > 0) InsDate((int)NDecember.Value, 12, (int)GraphicDGVEF.Rows[i].Cells["idPoint"].Value);
                        
      
 
                    }
                }

             }

            this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointView, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");
            MessageBox.Show("Данные успешно внесены.");
        }


        private void InsDate(int D,int M,int idP)
        {
            dsAbn.tG_Graphic.Clear();
            DateTime DateChek = new DateTime((int)comboBoxYear.SelectedItem, M, D);
          //  MessageBox.Show(DateChek.ToString());
            DataRow dr = dsAbn.tG_Graphic.NewRow();
            dr["idPoint"] = idP;
            dr["DateGraph"] = DateChek;
            dsAbn.tG_Graphic.Rows.Add(dr);
            this.InsertSqlDataOneRow(dsAbn, dsAbn.tG_Graphic);
          
  
        }

        private void GraphicDGVEF_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            //DateTime CurD = DateTime.Now;

            //if (e.RowIndex >= 0)
            //{

            //    if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value != DBNull.Value
            //        && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value) < 1)
            //        GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Red;
            //    if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value != DBNull.Value
            //        && (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value) >= 1 && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value) <= 2))
            //        GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Orange;
            //    if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value != DBNull.Value
            //        && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value) > 2)
            //        GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Green;
                
                
            //    if(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value != DBNull.Value 
            //        && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value) < 1)
            //     GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Red;
            //    if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value != DBNull.Value 
            //        && (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value) >= 1 && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value) <= 2 ))
            //        GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Orange;
            //    if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value != DBNull.Value
            //        && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value) >2 )
            //        GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Green;

            //    string[] Month = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };

                

            //    for (int i = 0; i <12; i++)
            //    {
            //        if (GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value !=DBNull.Value)
            //        {
            //            var a = GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value;
            //        if (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value) == 1) GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_v"].Style.ForeColor = Color.Red;
            //        if (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value) == 2) GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_v"].Style.ForeColor = Color.Orange;
            //        if (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value) >= 3) GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_v"].Style.ForeColor = Color.Green;  
            //        }
            //    }

            //    int KvCur = 0;

            //    switch (CurD.Month)
            //    {
            //        case 1:
            //        case 2:
            //        case 3: KvCur = 1; // первый квартал
            //            break;
            //        case 4:
            //        case 5:
            //        case 6: KvCur = 2;  // второй квартал
            //            break;
            //        case 7:
            //        case 8:
            //        case 9: KvCur = 3;  // третий квартал
            //            break;
            //        case 10:
            //        case 11:
            //        case 12: KvCur = 4;  // четвертый квартал
            //            break;
            //    }

            //    if (GraphicDGVEF.Rows[e.RowIndex].Cells["MeterDCheck"].Value != DBNull.Value)
            //    {
            //        int KvMeter = 0;

            //        switch (Convert.ToDateTime(GraphicDGVEF.Rows[e.RowIndex].Cells["MeterDCheck"].Value).Month)
            //        {
            //        case 1:
            //        case 2:
            //        case 3: KvMeter = 1; // первый квартал
            //            break;
            //        case 4:
            //        case 5:
            //        case 6: KvMeter = 2;  // второй квартал
            //            break;
            //        case 7:
            //        case 8:
            //        case 9: KvMeter = 3;  // третий квартал
            //            break;
            //        case 10:
            //        case 11:
            //        case 12: KvMeter = 4;  // четвертый квартал
            //            break;
            //        }

            //        int kvM = KvCur - KvMeter + (CurD.Year - Convert.ToDateTime(GraphicDGVEF.Rows[e.RowIndex].Cells["MeterDCheck"].Value).Year)*4 ;

            //        if (kvM > 2)
            //            GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Green;
            //        if (kvM > 0 && kvM <= 2)
            //            GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Yellow;
            //        if (kvM <= 0 )
            //            GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Red;
            //    }
                



            //    if (GraphicDGVEF.Rows[e.RowIndex].Cells["TransDCheck"].Value != DBNull.Value )
            //    {
            //        int KvTrans = 0;

            //        switch (Convert.ToDateTime(GraphicDGVEF.Rows[e.RowIndex].Cells["TransDCheck"].Value).Month)
            //        {
            //        case 1:
            //        case 2:
            //        case 3: KvTrans = 1; // первый квартал
            //            break;
            //        case 4:
            //        case 5:
            //        case 6: KvTrans = 2;  // второй квартал
            //            break;
            //        case 7:
            //        case 8:
            //        case 9: KvTrans = 3;  // третий квартал
            //            break;
            //        case 10:
            //        case 11:
            //        case 12: KvTrans = 4;  // четвертый квартал
            //            break;
            //        }

            //        int kvT = KvCur - KvTrans + (CurD.Year - Convert.ToDateTime(GraphicDGVEF.Rows[e.RowIndex].Cells["TransDCheck"].Value).Year) * 4;

            //        if (kvT < 2)
            //            GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Red;
            //        if (kvT < 1)
            //            GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Yellow;
            //        if (kvT <= 0)
            //            GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Green;


            //        //if(Convert.ToDateTime(GraphicDGVEF.Rows[e.RowIndex].Cells["TransDCheck"].Value) < CurD)
            //        //GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Red;
            //    }
                
                
           // }
        }

        private void GraphicDGVEF_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            GraphicDGVEF.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }



        // загрузка мастеров для отчета
        private void LoadMasters()
        {
            this.SelectSqlData(dsAbn, dsAbn.vWorkerGroup, true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL.ToString());
            checkedListBoxMaster.Items.Clear();
            foreach (DataRow dr in dsAbn.vWorkerGroup.Rows)
            {
                ItemChecked item = new ItemChecked(dr["FIO"].ToString(),
                        Convert.ToInt32(dr["Id"]));
                checkedListBoxMaster.Items.Add(item, false);
            }

            cmbMaster.ComboBox.DataSource = dsAbn.vWorkerGroup;
            cmbMaster.ComboBox.DisplayMember = "FIO";
            cmbMaster.ComboBox.ValueMember = "id";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            G_Year = comboBoxYearRep.SelectedItem.ToString();
            G_Month = (int)NUDMonth.Value;
            G_Date = dateTimePickerNoObsl.Value;

            groupBoxWait.Visible = true;
           
            progressBarEndLess.AutoProgress = true;
           
            Cursor.Current = Cursors.WaitCursor;

            if (tabControlGraph.SelectedIndex == 0) backgroundWorkerGraphMaster.RunWorkerAsync();
            if (tabControlGraph.SelectedIndex == 1) backgroundWorkerGraphMasterAll.RunWorkerAsync();
            if (tabControlGraph.SelectedIndex == 2) backgroundWorkerGraphMasterNoObsl.RunWorkerAsync();

        }

        private void backgroundWorkerGraphMaster_DoWork(object sender, DoWorkEventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            progressBarEndLess.AutoProgress = true;
            string masters = "";
            string masterstr = "всех мастеров";

            if ((checkedListBoxMaster.CheckedItems.Count != checkedListBoxMaster.Items.Count) &&
            (checkedListBoxMaster.CheckedItems.Count > 0))
            {
                masterstr = "";
                foreach (ItemChecked item in checkedListBoxMaster.CheckedItems)
                {
                    masters += item.Id + ",";
                    masterstr += item.Name + ", ";
                }
                masters = " and MasterID in (" + masters.Remove(masters.Length - 1) + ") ";
                masterstr = masterstr.Remove(masterstr.Length - 2);
                if (checkedListBoxMaster.CheckedItems.Count == 1)
                {
                    masterstr = "мастера " + masterstr;
                }
                else
                {
                    masterstr = "мастеров " + masterstr;
                }
                ;

            }


            // SelectSqlDataTableOther(dsAbn, dsAbn.vG_GraphicPointViewRep, "vG_GraphicPointView", true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + masters);
            this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointViewRepMasters, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") " + masters + " order by CodeAbonent  ");
            // MessageBox.Show(masters);

            ReportParameter d1 = new ReportParameter("RPMasters", masterstr);
            reportViewerRepMasters.LocalReport.SetParameters(new ReportParameter[] { d1 });

            ReportParameter d2 = new ReportParameter("RPYear", G_Year );
            reportViewerRepMasters.LocalReport.SetParameters(new ReportParameter[] { d2 });

            //reportViewerRepMasters.RefreshReport();

            this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointViewRepMastersG, true, " where DA_Y = " + G_Year + " " + masters);

            //reportViewerRepMastersG.RefreshReport();

        }

        private void backgroundWorkerGraphMaster_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            groupBoxWait.Visible = false;

            dataGridViewGraphMasterG.DataSource = null;
            dataGridViewGraphMasterG.DataSource = dsAbn.Tables["vG_GraphicPointViewRepMastersG"];

            reportViewerRepMasters.RefreshReport();
            reportViewerRepMastersG.RefreshReport();
            
            Cursor.Current = Cursors.Default;
        }



        private void backgroundWorkerGraphMasterAll_DoWork(object sender, DoWorkEventArgs e)
        {
            progressBarEndLess.AutoProgress = true;
            string masters = "";
            string masterstr = "всех мастеров";

            if ((checkedListBoxMaster.CheckedItems.Count != checkedListBoxMaster.Items.Count) &&
            (checkedListBoxMaster.CheckedItems.Count > 0))
            {
                masterstr = "";
                foreach (ItemChecked item in checkedListBoxMaster.CheckedItems)
                {
                    masters += item.Id + ",";
                    masterstr += item.Name + ", ";
                }
                masters = " and MasterID in (" + masters.Remove(masters.Length - 1) + ") ";
                masterstr = masterstr.Remove(masterstr.Length - 2);
                if (checkedListBoxMaster.CheckedItems.Count == 1)
                {
                    masterstr = "мастера " + masterstr;
                }
                else
                {
                    masterstr = "мастеров " + masterstr;
                }
                ;

            }


            this.SelectSqlDataTableOther(dsAbn, dsAbn.vG_GraphicPointViewGraph, "vG_GraphicPointView", true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and year_v = " + G_Year + " " + masters +" and Deleted=0 order by CodeAbonent  ");

            ReportParameter d1 = new ReportParameter("RPMasters", masterstr);
            reportViewerRepMastersAll.LocalReport.SetParameters(new ReportParameter[] { d1 });

            ReportParameter d2 = new ReportParameter("RPYear", G_Year);
            reportViewerRepMastersAll.LocalReport.SetParameters(new ReportParameter[] { d2 });

            this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointViewRepMastersG_GraphAll, true, " where DA_Y = " + G_Year + " " + masters +" order by DA_M, Master");

                 }

        private void backgroundWorkerGraphMasterAll_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            groupBoxWait.Visible = false;

            //dataGridViewMastersAll.DataSource = null;
            //dataGridViewMastersAll.DataSource = dsAbn.Tables["vG_GraphicPointViewGraph"];

            dataGridViewMastersAll_G.DataSource = null;
            dataGridViewMastersAll_G.DataSource = dsAbn.Tables["vG_GraphicPointViewRepMastersG_GraphAll"];

            reportViewerRepMastersAll.RefreshReport();
            reportViewerRepMastersG_All.RefreshReport();
            
            Cursor.Current = Cursors.Default;
        }

        private void tabControlGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlGraph.SelectedIndex == 2)
            {
                labelYear.Visible = false;
                comboBoxYearRep.Visible = false;
            }
            else
            {
                labelYear.Visible = true;
                comboBoxYearRep.Visible = true;
            }
        }

        private void backgroundWorkerGraphMasterNoObsl_DoWork(object sender, DoWorkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            progressBarEndLess.AutoProgress = true;
            string masters = "";
            string masterstr = "всех мастеров";

            if ((checkedListBoxMaster.CheckedItems.Count != checkedListBoxMaster.Items.Count) &&
            (checkedListBoxMaster.CheckedItems.Count > 0))
            {
                masterstr = "";
                foreach (ItemChecked item in checkedListBoxMaster.CheckedItems)
                {
                    masters += item.Id + ",";
                    masterstr += item.Name + ", ";
                }
                masters = " and MasterID in (" + masters.Remove(masters.Length - 1) + ") ";
                masterstr = masterstr.Remove(masterstr.Length - 2);
                if (checkedListBoxMaster.CheckedItems.Count == 1)
                {
                    masterstr = "мастера " + masterstr;
                }
                else
                {
                    masterstr = "мастеров " + masterstr;
                }
                ;

            }


            // SelectSqlDataTableOther(dsAbn, dsAbn.vG_GraphicPointViewRep, "vG_GraphicPointView", true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + masters);
            this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointViewRepMasters, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") " + masters + " and (DateAct is null or DateAct <= dateadd(month,-" + G_Month.ToString() + " , '" + G_Date.ToString("yyyyMMdd") + "')) order by CodeAbonent  "); //or DateAct <= '" ++ "'
         //MessageBox.Show(G_Date.ToString("yyyyMMdd"));

            ReportParameter d1 = new ReportParameter("RPMasters", masterstr);
            reportViewerNoObsl.LocalReport.SetParameters(new ReportParameter[] { d1 });

            ReportParameter d2 = new ReportParameter("RPMonth", G_Month.ToString());
            reportViewerNoObsl.LocalReport.SetParameters(new ReportParameter[] { d2 });
        }

        private void backgroundWorkerGraphMasterNoObsl_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            groupBoxWait.Visible = false;

            DGWEFNoObsl.DataSource = null;
            DGWEFNoObsl.DataSource = dsAbn.Tables["vG_GraphicPointViewRepMasters"];

            reportViewerNoObsl.RefreshReport();
                        
            Cursor.Current = Cursors.Default;
        }

        private void GraphOk_Click_1(object sender, EventArgs e)
        {
            panelGraph.Visible = true;
            panelGraph1.Visible = false;
            panelGraph2.Visible = false;
        }

        private void GraphicTSB_Click_1(object sender, EventArgs e)
        {
            panelGraph.Visible = false;
            panelGraph1.Visible = true;
            panelGraph2.Visible = false;
        }

        private void OrderTSB_Click(object sender, EventArgs e)
        {
            panelGraph.Visible = false;
            panelGraph1.Visible = false;
            panelGraph2.Visible = true;

            dsAbn.GraphicPointOrder.Clear();
            int j = 0;
            for (int i = 0; i < GraphicDGVEF.RowCount; i++)
            {
                if (GraphicDGVEF.Rows[i].Cells["check"].Value != DBNull.Value && GraphicDGVEF.Rows[i].Cells["check"].Value != null) //
                {
                    if ((bool)GraphicDGVEF.Rows[i].Cells["check"].Value)
                    {
                        this.SelectSqlData(dsAbn.vG_GraphicPointOrder, true, " where idPoint = " + GraphicDGVEF.Rows[i].Cells["idPoint"].Value.ToString(), null, false, 1);

                        DataRow dr = dsAbn.GraphicPointOrder.NewRow();
                        dr["CodeAbonent"] = (int)dsAbn.vG_GraphicPointOrder.Rows[0]["CodeAbonent"];
                        dr["TypeAbn"] = dsAbn.vG_GraphicPointOrder.Rows[0]["TypeAbn"];
                        dr["Name"] = dsAbn.vG_GraphicPointOrder.Rows[0]["Name"];
                        dr["AbnPhone"] = dsAbn.vG_GraphicPointOrder.Rows[0]["AbnPhone"];
                        dr["Deleted"] = dsAbn.vG_GraphicPointOrder.Rows[0]["Deleted"];
                        dr["idObj"] = dsAbn.vG_GraphicPointOrder.Rows[0]["idObj"];
                        dr["NumberObj"] = dsAbn.vG_GraphicPointOrder.Rows[0]["NumberObj"];
                        dr["NameObj"] = dsAbn.vG_GraphicPointOrder.Rows[0]["NameObj"];
                        dr["ObjAdress"] = dsAbn.vG_GraphicPointOrder.Rows[0]["ObjAdress"];
                        dr["idAbn"] = dsAbn.vG_GraphicPointOrder.Rows[0]["idAbn"];
                        dr["id"] = dsAbn.vG_GraphicPointOrder.Rows[0]["id"];
                        dr["idPoint"] = dsAbn.vG_GraphicPointOrder.Rows[0]["idPoint"];
                        dr["MasterID"] = dsAbn.vG_GraphicPointOrder.Rows[0]["MasterID"];
                        dr["Number"] = dsAbn.vG_GraphicPointOrder.Rows[0]["Number"];
                        dr["NameMeter"] = dsAbn.vG_GraphicPointOrder.Rows[0]["NameMeter"];
                        dr["DateBegin"] = dsAbn.vG_GraphicPointOrder.Rows[0]["DateBegin"];
                        dr["MeterDCheck"] = dsAbn.vG_GraphicPointOrder.Rows[0]["MeterDCheck"];
                        dr["MeterDCheckStr"] = dsAbn.vG_GraphicPointOrder.Rows[0]["MeterDCheckStr"];
                        dr["GosEndMeter"] = dsAbn.vG_GraphicPointOrder.Rows[0]["GosEndMeter"];
                        dr["NameTrans"] = dsAbn.vG_GraphicPointOrder.Rows[0]["NameTrans"];
                        dr["TypeTrans"] = dsAbn.vG_GraphicPointOrder.Rows[0]["TypeTrans"];
                        dr["TransDCheck"] = dsAbn.vG_GraphicPointOrder.Rows[0]["TransDCheck"];
                        dr["TransDCheckStr"] = dsAbn.vG_GraphicPointOrder.Rows[0]["TransDCheckStr"];
                        dr["GosEndTrans"] = dsAbn.vG_GraphicPointOrder.Rows[0]["GosEndTrans"];
                        dr["Ktran"] = dsAbn.vG_GraphicPointOrder.Rows[0]["Ktran"];
                        dr["Values"] = dsAbn.vG_GraphicPointOrder.Rows[0]["Values"];
                        dr["DateAct"] = dsAbn.vG_GraphicPointOrder.Rows[0]["DateAct"];
                        dr["PowerSet"] = dsAbn.vG_GraphicPointOrder.Rows[0]["PowerSet"];
                        dsAbn.GraphicPointOrder.Rows.Add(dr);
                        dsAbn.GraphicPointOrder.Rows[j++].EndEdit();

                        dsAbn.vG_GraphicPointOrder.Clear();
                    }
                }

            }

        }

        private void bCreateOrder_Click(object sender, EventArgs e)
        {
            ReportParameter d1 = new ReportParameter("Number", tbOrderN.Text);
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d1 });

            ReportParameter d2 = new ReportParameter("Whom", cbWhom.Text);
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d2 });

            ReportParameter d3 = new ReportParameter("Who", cbWho.Text);
            reportViewerOrder.LocalReport.SetParameters(new ReportParameter[] { d3 });

            reportViewerOrder.RefreshReport();

        }


        #region toolStripOrderMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvOrder.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxOrderFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvOrder.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxOrderFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvOrder.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxOrderFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvOrder.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxOrderFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvOrder.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvOrder.CopyToExcel(true);
        }
   
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {

            dgvOrder.Refresh();

        }
        #endregion

        #region toolStripMain Events
        // поиск сначала
        private void tsbFind_Click(object sender, EventArgs e)
        {
            if (cmbView.SelectedIndex == 1)
            GraphicDGVEF.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, tstbFind.Text);
            else GraphicDGVEFSmall.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, tstbFind.Text);
        }
        //поиск след
        private void tstbFind_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                if (cmbView.SelectedIndex == 1)
                GraphicDGVEF.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, tstbFind.Text);
                else GraphicDGVEFSmall.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, tstbFind.Text);

        }

        // поиск предыдущего
        private void tsbFindPrev_Click(object sender, EventArgs e)
        {
            if (cmbView.SelectedIndex == 1)
            GraphicDGVEF.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, tstbFind.Text);
            else GraphicDGVEFSmall.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, tstbFind.Text);
        }
        // поиск следующего
        private void tsbFindNext_Click(object sender, EventArgs e)
        {
            if (cmbView.SelectedIndex == 1)
            GraphicDGVEF.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, tstbFind.Text);
            else GraphicDGVEFSmall.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, tstbFind.Text);
        }
        // печать
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (cmbView.SelectedIndex == 1)
            GraphicDGVEF.PrintDataGridView();
            else GraphicDGVEFSmall.PrintDataGridView();
        }
        // экспорт в Excel
        private void tsbExel_Click(object sender, EventArgs e)
        {
            if (cmbView.SelectedIndex == 1)
            GraphicDGVEF.CopyToExcel(true);
            else
                GraphicDGVEFSmall.CopyToExcel(true);
        }
        // Обновить
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            if (cmbView.SelectedIndex == 1)
            GraphicDGVEF.Refresh();
            else GraphicDGVEFSmall.Refresh();
        }

        #endregion
        // изменить привязку мастеров к объектам
        private void btnChangeBinding_Click(object sender, EventArgs e)
        {
            int idWorker = Convert.ToInt32(cmbMaster.ComboBox.SelectedValue);


            if (cmbView.SelectedIndex == 1)
                for (int i = 0; i < GraphicDGVEF.RowCount; i++)
                {
                    if (GraphicDGVEF.Rows[i].Cells["check"].Value != null)
                    {
                        if ((bool)GraphicDGVEF.Rows[i].Cells["check"].Value == true)
                        {
                            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                            try
                            {
                                con.OpenConnection(SqlSettings);

                                string strCmd = "";
                                strCmd = "sp_LegChangeBindingMaster";
                                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                // параметры

                                int idObj = Convert.ToInt32(GraphicDGVEF.Rows[i].Cells["idObjDataGridViewTextBoxColumn"].Value);
                                SqlParameter p1 = new SqlParameter("@id", idObj);
                                sqlCmd.Parameters.Add(p1);

                                SqlParameter p2 = new SqlParameter("@idWorker", idWorker);
                                sqlCmd.Parameters.Add(p2);

                                sqlCmd.CommandTimeout = 0;

                                sqlCmd.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, ex.Source);
                            }
                            finally
                            {
                                con.CloseConnection();
                            }

                        }
                    }
                }
            else
            {
                for (int i = 0; i < GraphicDGVEFSmall.RowCount; i++)
                {
                    if (GraphicDGVEFSmall.Rows[i].Cells["checkSmall"].Value != null)
                    {
                        if ((bool)GraphicDGVEFSmall.Rows[i].Cells["checkSmall"].Value == true)
                        {
                            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                            try
                            {
                                con.OpenConnection(SqlSettings);

                                string strCmd = "";
                                strCmd = "sp_LegChangeBindingMaster";
                                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                // параметры

                                int idObj = Convert.ToInt32(GraphicDGVEFSmall.Rows[i].Cells["idObjDataGridViewTextBoxColumnSmall"].Value);
                                SqlParameter p1 = new SqlParameter("@id", idObj);
                                sqlCmd.Parameters.Add(p1);

                                SqlParameter p2 = new SqlParameter("@idWorker", idWorker);
                                sqlCmd.Parameters.Add(p2);

                                sqlCmd.CommandTimeout = 0;

                                sqlCmd.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, ex.Source);
                            }
                            finally
                            {
                                con.CloseConnection();
                            }

                        }
                    }

                }
            }

            GraphView();
        }

        private void GraphView()
        {
            switch (cmbView.SelectedIndex)
            {
                case 0: GraphicDGVEF.Visible = false;
                    GraphicDGVEFSmall.Visible = true;
                    groupBoxCheckDate.Visible = false;
                    buttonIns.Visible = false;
                    dsAbn.vPointReg.Clear();
                    this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointViewSmall, true, "  order by CodeAbonent  ");
                    break;

                case 1: GraphicDGVEF.Visible = true;
                    this.Cursor = Cursors.WaitCursor;
                    GraphicDGVEFSmall.Visible = false;
                    groupBoxCheckDate.Visible = true;
                    buttonIns.Visible = true;
                    this.SelectSqlData(dsAbn, dsAbn.vG_GraphicPointView, true, "  order by CodeAbonent  "); // where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent 
                    this.Cursor = Cursors.Default;
                    break;
            }
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GraphView();
        }

        private void GraphicDGVEFSmall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetData();
        }

        private void GraphicDGVEFSmall_KeyUp(object sender, KeyEventArgs e)
        {
            GetData();
        }

        private void tsbJournalOrders_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i < GraphicDGVEF.RowCount; i++)
            {
                if (GraphicDGVEF.Rows[i].Cells["check"].Value != DBNull.Value && GraphicDGVEF.Rows[i].Cells["check"].Value != null) //
                {
                    if ((bool)GraphicDGVEF.Rows[i].Cells["check"].Value)
                    {
                        this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.vG_GraphicPointOrder1, "vG_GraphicPointOrder", true, " where idPoint = " + GraphicDGVEF.Rows[i].Cells["idPoint"].Value.ToString(), 1);

                        DataRow dr = dsAbnDocum1.tOrdersInspection.NewRow();
                        dr["CodeAbonent"] = (int)dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["CodeAbonent"];
                        dr["TypeAbn"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["TypeAbn"];
                        dr["Name"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["Name"];
                        dr["AbnPhone"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["AbnPhone"];
                        dr["Deleted"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["Deleted"];
                        dr["idObj"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["idObj"];
                        dr["NumberObj"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["NumberObj"];
                        dr["NameObj"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["NameObj"];
                        dr["ObjAdress"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["ObjAdress"];
                        dr["idAbn"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["idAbn"];
                        dr["id"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["id"];
                        dr["idPoint"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["idPoint"];
                        dr["Number"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["Number"];
                        dr["NameMeter"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["NameMeter"];
                        dr["DateBegin"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["DateBegin"];
                        dr["MeterDCheck"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["MeterDCheck"];
                        dr["MeterDCheckStr"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["MeterDCheckStr"];
                        dr["GosEndMeter"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["GosEndMeter"];
                        dr["NameTrans"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["NameTrans"];
                        dr["TypeTrans"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["TypeTrans"];
                        dr["TransDCheck"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["TransDCheck"];
                        dr["TransDCheckStr"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["TransDCheckStr"];
                        dr["GosEndTrans"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["GosEndTrans"];
                        dr["Ktran"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["Ktran"];
                        dr["Values"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["Values"];
                        dr["DateAct"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["DateAct"];
                        dr["PowerSet"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[0]["PowerSet"];
                        dr["idJournal"] = ID;

                        dsAbnDocum1.tOrdersInspection.Rows.Add(dr);
                        dsAbnDocum1.tOrdersInspection.Rows[j++].EndEdit();

                    }
                }

            }
            if (dsAbnDocum1.tOrdersInspection.Rows.Count > 0)
                InsertSqlData(dsAbnDocum1, dsAbnDocum1.tOrdersInspection);

            this.Close();

        }

        private void GraphicDGVEF_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value != DBNull.Value
                    && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value) < 1)
                    GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Red;
                if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value != DBNull.Value
                    && (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value) >= 1 && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value) <= 2))
                    GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Orange;
                if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value != DBNull.Value
                    && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndMeter"].Value) > 2)
                    GraphicDGVEF.Rows[e.RowIndex].Cells["GosMeter"].Style.ForeColor = Color.Green;


                if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value != DBNull.Value
                    && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value) < 1)
                    GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Red;
                if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value != DBNull.Value
                    && (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value) >= 1 && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value) <= 2))
                    GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Orange;
                if (GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value != DBNull.Value
                    && Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells["GosEndTrans"].Value) > 2)
                    GraphicDGVEF.Rows[e.RowIndex].Cells["GosTrans"].Style.ForeColor = Color.Green;

                string[] Month = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };

                for (int i = 0; i < 12; i++)
                {
                    if (GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value != DBNull.Value)
                    {
                        //var a = GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value;
                        if (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value) == 1) GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_v"].Style.ForeColor = Color.Red;
                        if (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value) == 2) GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_v"].Style.ForeColor = Color.Orange;
                        if (Convert.ToInt16(GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_t"].Value) >= 3) GraphicDGVEF.Rows[e.RowIndex].Cells[Month[i] + "_v"].Style.ForeColor = Color.Green;
                    }
                }
            }


        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            this.GraphicDGVEFSmall.ExportToExcel();
        }
    }
}

     