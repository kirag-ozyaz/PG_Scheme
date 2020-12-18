using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Reports
{
    public partial class FormWorkControllers : FormLbr.FormBase
    {
        public FormWorkControllers()
        {
            InitializeComponent();

            panelWait.Visible = false;

            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
                d_c = d_c.AddMonths(-1))
            {
                toolStripComboBoxPeriod.Items.Add(d_c.ToString("MMMM yyyy"));
               
            }
            toolStripComboBoxPeriod.SelectedIndex = 0;

        }

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvefWork.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefWork.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvefWork.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvefWork.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvefWork.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvefWork.CopyToExcel(true);
        }


        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Convert.ToDateTime(toolStripComboBoxPeriod.SelectedItem).ToString());

            panelWait.Visible = true;

            panelWait.Refresh();
            Cursor.Current = Cursors.WaitCursor;

            LoadRepDate();

            string period = Convert.ToDateTime(toolStripComboBoxPeriod.SelectedItem).ToString("MMMM yyyy");
            period = period + " года.";

            Microsoft.Reporting.WinForms.ReportParameter p = new Microsoft.Reporting.WinForms.ReportParameter("RepMonth", period);
            this.RWRepWorkControllers.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p });

            this.RWRepWorkControllers.RefreshReport();  
        }

        #endregion

        private void LoadRepDate()
        {

            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {

                sql.OpenConnection(this.SqlSettings);

                dsRep.Tables["fn_PrvRepWorkController"].Clear();

                string select = "select * from fn_PrvRepWorkController(@date)";

                SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                sqlCmd.Parameters.Add("@Date", SqlDbType.SmallDateTime);
                sqlCmd.Parameters["@Date"].Value = Convert.ToDateTime(toolStripComboBoxPeriod.SelectedItem);

                sqlCmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsRep, "fn_PrvRepWorkController");


            }
            catch (Exception ex) // Если ошибка
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {   // В любом случае коннект надо закрыть
                sql.CloseConnection();
            }

            panelWait.Visible = false;
            Cursor.Current = Cursors.Default;
        }

        private void FormWorkControllers_Load(object sender, EventArgs e)
        {

            this.RWRepWorkControllers.RefreshReport();
        }

        private void bsRepWorkController_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
