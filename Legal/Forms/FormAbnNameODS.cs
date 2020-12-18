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
    public partial class FormAbnNameODS : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]

        public FormAbnNameODS()
        {
            InitializeComponent();
        }

        public FormAbnNameODS(int idAbn, bool insert)
        {
            InitializeComponent();
            ID = idAbn;
            isInsert = insert;
            this.Text = (isInsert) ? "Новая запись" : "Редактировать";
                        
        }

        private void FormAbnNameODS_Load(object sender, EventArgs e)
        {
            if (isInsert) // добавление
            {
                DataRow r = dsAbnDocum1.tG_AbnNameODS.NewRow();
                r["idAbn"] = ID;
                r["NameODS"] = "";
                dsAbnDocum1.tG_AbnNameODS.Rows.Add(r);
            }
            else //редактирование
            {
                this.SelectSqlData(dsAbnDocum1.tG_AbnNameODS, true, " where idAbn = " + ID.ToString());
                if (dsAbnDocum1.tG_AbnNameODS.Rows.Count == 0)
                {
                    MessageBox.Show("Данных для редактирования по этому абоненту не существует");
                    this.Close();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            dsAbnDocum1.tG_AbnNameODS.Rows[0].EndEdit();

            if (this.txtName.Text.Trim() == "")
                dsAbnDocum1.tG_AbnNameODS.Rows[0]["NameOds"] = null;
            if (isInsert)
            {
                isOk = this.InsertSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnNameODS);
            }
            else
                isOk = this.UpdateSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnNameODS);
            if (isOk) this.DialogResult = DialogResult.OK;
        }

    }
}
