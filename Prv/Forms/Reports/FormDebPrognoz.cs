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
    public partial class FormDebPrognoz : FormLbr.FormBase
    {
        private int Period;
        private int Month;
        private int Key;

        public FormDebPrognoz()
        {
            InitializeComponent();


            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
            d_c = d_c.AddMonths(-1))
                cBoxPeriod.Items.Add(d_c);
            cBoxPeriod.SelectedIndex = 0;
            comboBoxKey.SelectedIndex = 0;


        }

        private void buttonCreatePrognoz_Click(object sender, EventArgs e)
        {
            Period = Convert.ToInt32(Convert.ToDateTime(cBoxPeriod.SelectedItem).ToString("yyyyMM"));
            Month = Convert.ToInt32(numericUpDownMonth.Value);
            Key = 0;

            switch (comboBoxKey.SelectedItem.ToString())
            {
                case "Дорасчет по данным УЭ по месяцам." :
                      Key = 0;
                break;

                case "Дорасчет по данным УЭ по дням.":
                      Key = 1;
                break;

                case "Нет дорасчета.":
                      Key = 2;
                break;
            }


            dsRep.fn_AbnDebitorkaBS_new.Clear();
            dgwefPrognoz.Refresh();

            Cursor.Current = Cursors.WaitCursor;

            DataGridAdd();

        }

        private void DataGridAdd()
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            con.OpenConnection(SqlSettings);

            string strCmd = "select * from dbo.fn_AbnDebitorkaBS_new( @date, @M, @Key )";

            SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

            cmd.Parameters.Add("@Date", SqlDbType.Int);
            cmd.Parameters["@Date"].Value = Period;
          
            cmd.Parameters.Add("@M", SqlDbType.Int);
            cmd.Parameters["@M"].Value = Month;

            cmd.Parameters.Add("@Key", SqlDbType.Int);
            cmd.Parameters["@Key"].Value = Key;


            cmd.CommandTimeout = 600;

            SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

            dAdapt.Fill(dsRep, "fn_AbnDebitorkaBS_new");


            //int SumKWT = 0;

            //foreach (DataGridViewRow row in dgwefPrognoz.Rows)
            //{
            //   // double incom;
            //   // double.TryParse((row.Cells[8].Value ?? "0").ToString().Replace(".", ","), out incom);
            //    SumKWT += (row.Cells["KWT"].Value is DBNull) ? 0 : Convert.ToInt32(row.Cells["KWT"].Value);
            //}

            //toolStripLabelSumKWT.Text = "Итого:    " + string.Format("{0:#,##0}", SumKWT) + " кВт   ";  
      
            Cursor.Current = Cursors.Default;
        }

        private void backgroundWorkerPrognoz_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void buttonExel_Click(object sender, EventArgs e)
        {
            dgwefPrognoz.CopyToExcel(true);
        }


        private void toolStripButtonRefreshSum_Click(object sender, EventArgs e)
        {
            int SumKWT = 0;

            foreach (DataGridViewRow row in dgwefPrognoz.Rows)
            {
                // double incom;
                // double.TryParse((row.Cells[8].Value ?? "0").ToString().Replace(".", ","), out incom);
                SumKWT += (row.Cells["KWT"].Value is DBNull) ? 0 : Convert.ToInt32(row.Cells["KWT"].Value);
            }

            toolStripLabelSumKWT.Text = "Итого:    " + string.Format("{0:#,##0}", SumKWT) + "   кВт   ";
        }

        private void dgwefPrognoz_Paint(object sender, PaintEventArgs e)
        {
            int SumKWT = 0;

            foreach (DataGridViewRow row in dgwefPrognoz.Rows)
            {
                // double incom;
                // double.TryParse((row.Cells[8].Value ?? "0").ToString().Replace(".", ","), out incom);
                SumKWT += (row.Cells["KWT"].Value is DBNull) ? 0 : Convert.ToInt32(row.Cells["KWT"].Value);
            }

            toolStripLabelSumKWT.Text = "Итого:    " + string.Format("{0:#,##0}", SumKWT) + "   кВт   ";
        }
    }
}
