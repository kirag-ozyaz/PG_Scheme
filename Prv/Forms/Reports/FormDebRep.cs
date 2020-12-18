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
    public partial class FormDebRep : FormLbr.FormBase
    {
        private int Code = 0;
        private DateTime Period;
        private int KWT1;
        private int KWT2;

        public FormDebRep()
        {
          
            InitializeComponent();

            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
            d_c = d_c.AddMonths(-1))
                cBoxPeriod.Items.Add(d_c);
                cBoxPeriod.SelectedIndex = 0;

 
        }

        private void FormDebRep_Load(object sender, EventArgs e)
        {
            groupBoxWait.Visible = false;
            this.reportViewerDebRep.RefreshReport();
        }

        private void LoadTable(int cod)
        {
            Code = cod;
            if (cBoxPeriod.SelectedItem != null)
                Period = Convert.ToDateTime(cBoxPeriod.SelectedItem);
            else
                Period = new DateTime(2001, 1, 1);

            if (mTBoxS.Text != "")
                KWT1 = Convert.ToInt32(mTBoxS.Text);
            else
                KWT1 = Int32.MinValue;
            if (mTBoxPo.Text != "")
                KWT2 = Convert.ToInt32(mTBoxPo.Text);
            else
                KWT2 = Int32.MinValue;
                        
            
            groupBoxWait.Visible = true;
            progressBarEndLess.AutoProgress = true;
           
            dsRep.TableDeb.Clear();
            backgroundWorkerRepDeb.RunWorkerAsync();
        
        }


        private void buttonOurkWt_Click(object sender, EventArgs e)
        {
            LoadTable(2);                                 
        }
        private void buttonUEkWt_Click(object sender, EventArgs e)
        {
            LoadTable(3);
        }
        private void buttonRaznost_Click(object sender, EventArgs e)
        {
            LoadTable(4);
        }
        private void buttonApplay_Click(object sender, EventArgs e)
        {
            if (radioButtonOurNotDeb.Checked)
                LoadTable(6); // у нас не расчитались
            if (radioButtonNoOurYesUE.Checked)
                LoadTable(4);  //нет у нас есть у них
            if (radioButtonYesOurNoUE.Checked)
                LoadTable(5);   // есть у нас нет у них
        }


        private void backgroundWorkerRepDeb_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            con.OpenConnection(SqlSettings);

            string strCmd = "select * from fn_PrvRepDeb(@date, @kwt1, @kwt2, @Code)";

            SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

            cmd.Parameters.Add("@Date", SqlDbType.SmallDateTime);
            cmd.Parameters["@Date"].Value = Period;
            cmd.Parameters.Add("@Kwt1", SqlDbType.Int);
            cmd.Parameters["@Kwt1"].Value = KWT1 ;
            
            cmd.Parameters.Add("@Kwt2", SqlDbType.Int);
            cmd.Parameters["@Kwt2"].Value = KWT2;
         
            cmd.Parameters.Add("@Code", SqlDbType.TinyInt);
            cmd.Parameters["@Code"].Value = Code;

            cmd.CommandTimeout = 600;

            SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);
           
            dAdapt.Fill(dsRep, "TableDeb");

       
        }
        private void backgroundWorkerRepDeb_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            groupBoxWait.Visible = false;
            reportViewerDebRep.RefreshReport();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void reportViewerDebRep_Load(object sender, EventArgs e)
        {

        }

        private void buttonDebAllAbn_Click(object sender, EventArgs e)
        {
            FormDebAllAbn f = new FormDebAllAbn();
            f.MdiParent = this.MdiParent;
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }

        private void buttonDebPrognoz_Click(object sender, EventArgs e)
        {
            FormDebPrognoz f = new FormDebPrognoz();
            f.MdiParent = this.MdiParent;
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }

        private void buttonDebNotIns_Click(object sender, EventArgs e)
        {
            FormDebNotIns f = new FormDebNotIns(Convert.ToInt32(Convert.ToDateTime(cBoxPeriod.SelectedItem).ToString("yyyyMM")), cBoxPeriod.Text);
            f.MdiParent = this.MdiParent;
            f.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            f.Show();
        }

 


    
     
 


   
    }
}
