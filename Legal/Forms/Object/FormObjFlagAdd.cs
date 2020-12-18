using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Object
{
    public partial class FormObjFlagAdd : FormLbr.FormBase
    {
        private int idObj = -1;

        public FormObjFlagAdd()
        {
            InitializeComponent();
        }

        public FormObjFlagAdd(int idObj)
        {
            InitializeComponent();
            this.idObj = idObj;
        }

        private void FormObjFlagAdd_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbn, dsAbn.vG_ObjFlagsName, true, " order by Name");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFlagAdd_Click(object sender, EventArgs e)
        {
            //this.SelectSqlData(dsAbn, dsAbn.tAbnObjFlags, true, " where idFlag = " + comboBoxFlagsName.SelectedValue.ToString()+ " order by Name");

            //if (dsAbn.tAbnObjFlags.Rows.Count > 0)
            //{

            //}

            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
              try
                   {
                       sql.OpenConnection(this.SqlSettings);
                       string update = "update tAbnObjFlags  set deleted = 1 where idAbnObj = " + idObj.ToString() + " and idFlag = " + comboBoxFlagsName.SelectedValue.ToString() ;
                       System.Data.SqlClient.SqlCommand sqlCom = new System.Data.SqlClient.SqlCommand(update, sql.Connection);
                       sqlCom.ExecuteNonQuery();
                   }
             catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message, ex.Source);
                  }
             finally
                  {
                      sql.CloseConnection();
                  }

            DataRow r = dsAbn.tAbnObjFlags.NewRow();
            r["idAbnObj"]= idObj;
            r["idFlag"] = comboBoxFlagsName.SelectedValue;
            r["Status"] = 1 ;
            r["Date"] = dateTimePickerBegin.Value;
            r["Deleted"] = 0;
            dsAbn.tAbnObjFlags.Rows.Add(r);

            int idFlag = this.InsertSqlDataOneRow(dsAbn, dsAbn.tAbnObjFlags);
            if (idFlag > 0)
            {
                MessageBox.Show("Признак внесен.");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Невозможно внести признак."); 
            }
        }


    }
}
