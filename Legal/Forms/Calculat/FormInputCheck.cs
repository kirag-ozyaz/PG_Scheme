using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Legal.Forms.Calculat
{
    public partial class FormInputCheck : FormLbr.FormBase
    {
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

        public FormInputCheck()
        {
            InitializeComponent();
        }

        private void FormInputCheck_Load(object sender, EventArgs e)
        {
            // загрузка месяцев
            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
            d_c = d_c.AddMonths(-1))
                cBoxPeriod.Items.Add(d_c);

            cBoxPeriod.SelectedIndex = 1;

            LoadControllers();

       //     this.reportViewerRus1.RefreshReport();
        }

        // загрузка контролеров
        private void LoadControllers()
        {
            this.SelectSqlData(dsCntVal1, dsCntVal1.Tables["vWorkerGroup"], true," where idgroup = " + Constants.Constants.WorkerGroupControlerUL + " and DateEnd is null order by fio ");

            for (int i = 0; i < dsCntVal1.vWorkerGroup.Rows.Count; i++)
            {
                checkedListBoxController.Items.Add(new myList(dsCntVal1.vWorkerGroup[i]["id"].ToString(), dsCntVal1.vWorkerGroup[i]["FIO"].ToString()));
            }
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            dsCntVal1.dtAbnObjCheck.Clear();

            Cursor.Current = Cursors.WaitCursor;
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegRepCheck(@dtBegin, @dtEnd, @dtLimit, @PercentMinus, @PercentPlus) ";
                strCmd += BuildWhereContrl() + " order by CodeAbonent, NumberObj, NumberSubObj ";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime dt = ((DateTime)cBoxPeriod.SelectedItem).Date;

                DateTime dtBegin = new DateTime(dt.Year, dt.Month, 1);
                SqlParameter p1 = new SqlParameter("@dtBegin", dtBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                DateTime dtEnd = dtBegin.AddMonths(1).AddDays(-1);
                SqlParameter p2 = new SqlParameter("@dtEnd", dtEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                DateTime dtLimit = dtBegin.AddMonths(-(int)numMonth.Value);
                SqlParameter p3 = new SqlParameter("@dtLimit", dtLimit.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p3);

                int PercentMinus = Convert.ToInt32(numMinus.Value);
                SqlParameter p4 = new SqlParameter("@PercentMinus", PercentMinus);
                sqlCmd.Parameters.Add(p4);

                int PercentPlus = Convert.ToInt32(numPlus.Value);
                SqlParameter p5 = new SqlParameter("@PercentPlus", PercentPlus);
                sqlCmd.Parameters.Add(p5);
                                
                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCntVal1, "dtAbnObjCheck");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
            this.reportViewerRus1.RefreshReport();
            Cursor.Current = Cursors.Default;
        }

        public class myList
        {
            private string id, name;
            public string Id
            {
                get { return id; }
            }
            public myList(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }

       private string BuildWhereContrl()
       {
            string whereContrl = "";
            if ((checkedListBoxController.CheckedItems.Count <= 0) || (checkedListBoxController.CheckedItems.Count == checkedListBoxController.Items.Count))
                return whereContrl;
            else
            {
                for (int i = 0; i <= (checkedListBoxController.CheckedItems.Count) - 1; i++)
                {
                    myList mylist = (myList)checkedListBoxController.CheckedItems[0];
                    whereContrl += mylist.Id + ",";
                }
                whereContrl = "where idWorker in (" + whereContrl.Remove(whereContrl.Length - 1) + ")";
                return whereContrl;
            }
       }


    }
}
