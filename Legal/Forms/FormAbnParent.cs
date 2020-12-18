using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnParent : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]

        public FormAbnParent()
        {
            InitializeComponent();
        }

        public FormAbnParent(int idAbn, bool insert)
        {
            InitializeComponent();
            ID = idAbn;
            isInsert = insert;
            this.Text = (isInsert) ? "Новая запись" : "Редактировать";
        }

        private void FormAbnParent_Load(object sender, EventArgs e)
        {
            if (isInsert) // добавление
            {
                DataRow r = dsAbnDetails1.tG_AbnParent.NewRow();
                r["idAbn"] = ID;
                r["ParentName"] = "";
                r["ParentAddress"] = "";
                r["ParentINN"] = "";
//                r["DateChange"] = System.DateTime.Now.Date;
                dsAbnDetails1.tG_AbnParent.Rows.Add(r);
            }
            else //редактирование
            {
                this.SelectSqlData(dsAbnDetails1.tG_AbnParent, true, " where idAbn = " + ID.ToString() + " order by DateChange Desc", null,false, 1);
                if (dsAbnDetails1.tG_AbnParent.Rows.Count == 0)
                {
                    MessageBox.Show("Данных для редактирования по этому абоненту не существует");
                    this.Close();
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            dsAbnDetails1.tG_AbnParent.Rows[0].EndEdit();
            if (isInsert)
            {
                isOk = this.InsertSqlData(dsAbnDetails1, dsAbnDetails1.tG_AbnParent);
            }
            else
                isOk = this.UpdateSqlData(dsAbnDetails1, dsAbnDetails1.tG_AbnParent);
            if (isOk) this.DialogResult = DialogResult.OK;
        }

    }
}
