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
    public partial class FormAbnContactAdd : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]
        private int AUTHOR = -1;

        public FormAbnContactAdd()
        {
            InitializeComponent();
        }
        
        public FormAbnContactAdd(int id, bool insert)
        {
            InitializeComponent();
            ID = id;
            isInsert = insert;
            this.Text = (isInsert) ? "Новый контакт" : "Редактирование контакта";
        }

        public FormAbnContactAdd(int id, bool insert, int Author)
        {
            InitializeComponent();
            ID = id;
            isInsert = insert;
            this.Text = (isInsert) ? "Новый контакт" : "Редактирование контакта";
            AUTHOR = Author;
        }


        private void FormAbnContactAdd_Load(object sender, EventArgs e)
        {
            if (isInsert) // добавление
            {
                DataRow r = dsAbn.tAbnContact.NewRow();
                r["idAbn"] = ID;
                r["F"] = "";
                r["I"] = "";
                r["O"] = "";
                r["Post"] = "";
                r["Phone"] = "";
                r["Comment"] = "";
                r["DateChange"] = System.DateTime.Now.Date ;
                r["email"] = "";
                r["Author"] = AUTHOR;
                dsAbn.tAbnContact.Rows.Add(r);
            }
            else //редактирование
            {
                this.SelectSqlData(dsAbn, dsAbn.tAbnContact, true, " where id = " + ID.ToString());
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            dsAbn.tAbnContact.Rows[0].EndEdit();
            if (isInsert)
            {
                isOk = this.InsertSqlData(dsAbn, dsAbn.tAbnContact);
            }
            else
                isOk = this.UpdateSqlData(dsAbn, dsAbn.tAbnContact);
            if (isOk) this.DialogResult = DialogResult.OK;
        }

  
    }
}
