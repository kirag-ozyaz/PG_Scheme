using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Document
{
    public partial class FormOrderAddEdit : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]
        private int IDJournal;

        public FormOrderAddEdit()
        {
            InitializeComponent();
        }

        public FormOrderAddEdit(int id, bool insert, int idJournal)
        {
            InitializeComponent();
            ID = id;
            isInsert = insert;
            IDJournal = idJournal;
            this.Text = (isInsert) ? "Новая запись" : "Редактирование записи";
        }

        private void FormOrderAddEdit_Load(object sender, EventArgs e)
        {
            if (isInsert) // добавление
            {
// Farit 31.03.2017
                dtAct.CustomFormat = " ";
                DataRow r = dsAbnDocum1.tOrdersInspection.NewRow();
                r["idJournal"] = IDJournal;
                r["Deleted"] = 0;
                r["Name"] = "";
                r["AbnPhone"] = "";
                r["NameObj"] = "";
                r["ObjAdress"] = "";
                r["Number"] = "";
                r["NameMeter"] = "";
                r["Ktran"] = "";
                r["Values"] = "";
//                r["DateAct"] = System.DBNull.Value;
                dsAbnDocum1.tOrdersInspection.Rows.Add(r);
            }
            else //редактирование
            {
                this.SelectSqlData(dsAbnDocum1 , dsAbnDocum1.tOrdersInspection, true, " where id = " + ID.ToString());
                if (dsAbnDocum1.tOrdersInspection[0]["DateAct"] == System.DBNull.Value)
                    dtAct.CustomFormat = " ";
            }
 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            dsAbnDocum1.tOrdersInspection.Rows[0].EndEdit();
            if (isInsert)
            {
                isOk = this.InsertSqlData(dsAbnDocum1, dsAbnDocum1.tOrdersInspection);
            }
            else
                isOk = this.UpdateSqlData(dsAbnDocum1, dsAbnDocum1.tOrdersInspection);
            if (isOk) this.DialogResult = DialogResult.OK;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
