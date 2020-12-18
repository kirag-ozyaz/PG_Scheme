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
    public partial class FormRepAbnFlag : FormLbr.FormBase
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

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }


        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvefAbnFlags.CopyToExcel(true);
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {

           dgvefAbnFlags.Refresh();

        }
        #endregion

        public FormRepAbnFlag()
        {
            InitializeComponent();
            
        }

        private void FormRepAbnFlag_Load(object sender, EventArgs e)
        {
            SelectSqlDataTableOther(dsRep, dsRep.tR_Classifier_GroupFlags, "tR_Classifier", true, "where ParentId = 927 and id != 1354 and IsGroup = 1 and Deleted = 0 ");
            LoadFlags();
        }

        private void LoadFlags()
        {
            SelectSqlDataTableOther(dsRep, dsRep.tR_Classifier_Flags, "tR_Classifier", true, "where (ParentId = " + cbGroupFlags.SelectedValue.ToString() + " or ParentId = 1354) and IsGroup = 0 and Deleted = 0 ");

            clbFlags.Items.Clear();

            ItemChecked item = new ItemChecked("Все", 1);
            clbFlags.Items.Add(item, true);

             foreach (DataRow dr in dsRep.tR_Classifier_Flags.Rows)
            {
                 item = new ItemChecked(dr["Name"].ToString(),
                    Convert.ToInt32(dr["Id"]));
                clbFlags.Items.Add(item, true);
            }


        }

        private void cbGroupFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupFlags.SelectedValue != null) LoadFlags();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            int f = 1;
            string filter = "";


            bsAbnFlags.Filter = filter;

            string select = "select *";

            int items = clbFlags.CheckedItems.Count;

            foreach (object itemChecked in clbFlags.CheckedItems)
            {
                if ((int)(((ItemChecked)itemChecked).Id) == 1) f = 0;
                if ((int)(((ItemChecked)itemChecked).Id) > 1)
                {
                    select += ",(select top 1 count(*) from dbo.tAbnObjFlags where deleted = 0 and idAbnObj = vAbn_HouseFlags.id and idFlag = " + ((ItemChecked)itemChecked).Id.ToString() + ") [" + itemChecked.ToString() + "]";
                    if (f > 1) { filter += " OR [" + itemChecked.ToString() + "] = 1 "; f++; }
                    if (f == 1) { filter +=" ["+ itemChecked.ToString() + "] = 1 "; f++; }

                }

            //  MessageBox.Show( itemChecked.ToString() + " " + ((ItemChecked)itemChecked).Id.ToString() );
            }
            select += "from [vAbn_HouseFlags]  ";

            switch ((int)cbGroupFlags.SelectedValue)
            {                      
                case 930:
                    select += " where vAbn_HouseFlags.TypeAbn = " + Constants.Constants.TypeAbnLegal.ToString() +
                              " and vAbn_HouseFlags.id in (select tG_Dog_Obj.idObj from  tAbnDoc_List " +
                                           " left join tAbnDoc_Dogovor on tAbnDoc_List.id = tAbnDoc_Dogovor.idList " +
                                           " left join tG_Dog_Obj on tG_Dog_Obj.idDog = tAbnDoc_Dogovor.id " +
                                           " where  tAbnDoc_List.isActive <> 0  " +
                                           " and tAbnDoc_List .Deleted = 0  " +
                                           " and tAbnDoc_Dogovor.FlagBreak = 0  " +
                                           " and tG_Dog_Obj.DateEnd is null ) " +
                              " order by vAbn_HouseFlags.CodeAbonent ";
                    
                    break;
                case 936:
                    select += " where TypeAbn = " + Constants.Constants.TypeAbnPrivate.ToString() + " order by [CodeAbonent]";
                    break;
            }

            dgvefAbnFlags.AutoGenerateColumns = true;

            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {

                sql.OpenConnection(this.SqlSettings);
    
                int ColumnsCount = dsRep.vAbn_HouseFlags.Columns.Count;
                for (int i = 13; i < ColumnsCount; i++)
                    {
                        dsRep.vAbn_HouseFlags.Columns.RemoveAt(13);
                    }

                dsRep.Tables["vAbn_HouseFlags"].Clear();


                SqlCommand sqlCmd = new SqlCommand(select, sql.Connection);

                sqlCmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsRep, "vAbn_HouseFlags");

                

                if ((int)clbFlags.CheckedItems.Count == 0) 
                {
    
 
                    bsAbnFlags.Filter = "CountFlags = 0";
                }
                else
                {
                    if (filter != "") bsAbnFlags.Filter = filter;
                }

            }
            catch (Exception ex) // Если ошибка
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {   // В любом случае коннект надо закрыть
                sql.CloseConnection();
            }
          //  SelectSqlData(dsRep, dsRep.vAbn_HouseFlags, true, "order by CodeAbonent");

            Cursor.Current = Cursors.Default;
        }


    }
}
