using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnAddEdit : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]

        public string Prm
        {
            get { return this.txtCode.Text; }
        }

        public FormAbnAddEdit()
        {
            InitializeComponent();
        }
        
        public FormAbnAddEdit(int id,bool insert)
        {
            InitializeComponent();
            ID = id;
            isInsert = insert;
            this.Text = (isInsert) ? "Добавление контрагента" : "Редактирование контрагента";
            if (isInsert)
                txtCode.Enabled = true;
            else
                txtCode.Enabled = false;
        }

        private void FormAbnAddEdit_Load(object sender, EventArgs e)
        {
            LoadDirectory();

            if (isInsert) // добавление
            {
                DataRow r = dsAbnAddEdit1.tAbn.NewRow();
                r["Name"] = "NoName";
                r["TypeAbn"] = 207;
                r["idWorker"] = 0;
                r["Deleted"] = false;
                dsAbnAddEdit1.tAbn.Rows.Add(r);
            }
            else //редактирование
            {
                this.SelectSqlData(dsAbnAddEdit1, dsAbnAddEdit1.tAbn, true, " where id = " + ID.ToString());
                if (Convert.ToInt32(dsAbnAddEdit1.tAbn[0]["CodeAbonent"]) == -1)
                    txtCode.Enabled = true;
            }
        }

        private void LoadDirectory()
        {
            this.SelectSqlData(dsAbnAddEdit1, dsAbnAddEdit1.vG_Contrl, true, " order by F");

            this.SelectSqlData(dsAbnAddEdit1, dsAbnAddEdit1.tR_Classifier, true,
                " where ParentKey = ';SKUEE;TypeAbn;' and isgroup = 0 and deleted = 0 and id in (" +
                Constants.Constants.TypeAbnLegalAll + ", " + ((int)Constants.AbnType.KontragentLegal).ToString() + ") order by id");
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            if (isInsert)
            {
                if (CheckAbnCode())
                {
                    dsAbnAddEdit1.tAbn.Rows[0].EndEdit();
                    ID = this.InsertSqlDataOneRow(dsAbnAddEdit1, dsAbnAddEdit1.tAbn);
                    if (ID < 0)
                        isOk = false;
                    else
                        isOk = InsertIntotAbnStatus(ID);
                }
            }
            else
            {
                dsAbnAddEdit1.tAbn.Rows[0].EndEdit();
                isOk = this.UpdateSqlData(dsAbnAddEdit1, dsAbnAddEdit1.tAbn);
            }
            if (isOk) this.DialogResult = DialogResult.OK;
        }

        private bool InsertIntotAbnStatus(int abnid)
        {
            DataRow dr = dsAbnAddEdit1.tAbnStatus.NewRow();
            dr["idAbn"] = abnid;
            dr["isactive"] = true;
            dr["DateChange"] = System.DateTime.Now.Date;
            dsAbnAddEdit1.tAbnStatus.Rows.Add(dr);
            dsAbnAddEdit1.tAbnStatus.Rows[0].EndEdit();
            return this.InsertSqlData(dsAbnAddEdit1, dsAbnAddEdit1.tAbnStatus);
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnFindCode_Click(object sender, EventArgs e)
        {
            FindCode();
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            CheckAbnCode();
        }

        private Boolean CheckAbnCode()
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                dsAbnAddEdit1.tAbn1.Clear();
                this.SelectSqlDataTableOther(dsAbnAddEdit1, dsAbnAddEdit1.tAbn1, "tAbn", true, " where CodeAbonent = " + txtCode.Text.ToString()
                    + "and TypeAbn in (207,230,231,206,253)");
                if ((int)dsAbnAddEdit1.tAbn1.Count > 0)
                {
                    MessageBox.Show("Такой код потребителя уже существует...", "Selection error!");
                    FindCode();
                    return false;
                }
                else
                {
                    MessageBox.Show("Код свободен можно использовать.");
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Не введен код потребителя");
                return false;
            }
        }

        private void FindCode()
        {
            if (string.IsNullOrEmpty(txtCode.Text)) txtCode.Text = "1";

            this.SelectSqlDataTableOther(dsAbnAddEdit1, dsAbnAddEdit1.tAbn1, "tAbn", true, " where CodeAbonent = " + txtCode.Text.ToString()
                +"and TypeAbn in (207,230,231,206,253)", 1);
            if (dsAbnAddEdit1.tAbn1.Rows.Count == 0)
            {
                dsAbnAddEdit1.tAbn[0]["CodeAbonent"] = Convert.ToInt32(txtCode.Text);
            }
            else
            {
                this.SelectSqlDataTableOther(dsAbnAddEdit1, dsAbnAddEdit1.tAbn1, "tAbn", true, " where CodeAbonent >= " + txtCode.Text.ToString() +
                    " and codeAbonent+1 not in (select codeAbonent from tAbn) and codeAbonent <= 19999 and TypeAbn in (207,230,231,206,253) order by CodeAbonent", 1);
                if (dsAbnAddEdit1.tAbn1.Rows.Count == 0)
                {
                    txtCode.Text = "1";
                    dsAbnAddEdit1.tAbn[0]["CodeAbonent"] = 1;
                }
                else
                {
                    txtCode.Text = (Convert.ToInt32(dsAbnAddEdit1.tAbn1.Rows[0]["CodeAbonent"]) + 1).ToString();
                    dsAbnAddEdit1.tAbn[0]["CodeAbonent"] = (Convert.ToInt32(dsAbnAddEdit1.tAbn1.Rows[0]["CodeAbonent"]) + 1);
                }
            }

            
        }
    }
}
