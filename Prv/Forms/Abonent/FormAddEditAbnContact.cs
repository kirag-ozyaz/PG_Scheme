using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Abonent
{
    public partial class FormAddEditAbnContact : FormLbr.FormBase
    {
        public enum ActionAbnContact { Add, Edit, Read };

        private int idAbn = -1;
        private int idAbnContact = -1;
        private ActionAbnContact actContact;

        public FormAddEditAbnContact()
        {
            InitializeComponent();
        }

        public FormAddEditAbnContact(int idAbn, int idAbnContact, ActionAbnContact actContact)
        {
            InitializeComponent();
            this.idAbn = idAbn;
            this.idAbnContact = idAbnContact;
            this.actContact = actContact;
            dateTimePickerDateChange.Value = DateTime.Now.Date;

            switch (actContact)
            {
                case ActionAbnContact.Add:
                    this.Text = "Добавить конт.инфо.";
                    break;
                case ActionAbnContact.Edit:
                    this.Text = "Редактировать конт.инфо.";
                    break;
                case ActionAbnContact.Read:
                    this.Text = "Просмотр конт.инфо.";
                    break;
                default: break;
            }
        }

        private void FormAddEditAbnContact_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnContact, dsAbnContact.tAbn, true, "where id = " + idAbn.ToString());
            txtCodeAbonent.Text = dsAbnContact.tAbn.Rows[0]["CodeAbonent"].ToString();
            switch (actContact)
            {
                case ActionAbnContact.Add:
                    this.SelectSqlData(dsAbnContact.tAbnContact, true, "where idAbn = " +
                        idAbn.ToString() + " order by DateChange desc", null, false, 1);
                    if (dsAbnContact.tAbnContact.Rows.Count > 0)
                        dateTimePickerDateChange.MinDate = Convert.ToDateTime(dsAbnContact.tAbnContact.Rows[0]["DateChange"]).AddDays(1);
                    dsAbnContact.tAbnContact.Clear();
                    DataRow dr = dsAbnContact.tAbnContact.NewRow();
                    dr["idAbn"] = idAbn;
                    dr["DateChange"] = dateTimePickerDateChange.Value;
                    dsAbnContact.tAbnContact.Rows.Add(dr);
                    break;
                case ActionAbnContact.Edit:
                    this.SelectSqlData(dsAbnContact, dsAbnContact.tAbnContact, true, "where id = " + idAbnContact.ToString());
                    dateTimePickerDateChange.Enabled = false;
                    break;
                case ActionAbnContact.Read:
                    this.SelectSqlData(dsAbnContact, dsAbnContact.tAbnContact, true, "where id = " + idAbnContact.ToString());
                    dateTimePickerDateChange.Enabled = false;
                    txtFirstName.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtOtchestvo.ReadOnly = true;
                    richTextBoxPhone.ReadOnly = true;
                    richTextBoxComment.ReadOnly = true;
                    break;
                default: break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            switch (actContact)
            {
                case ActionAbnContact.Add:
                    if (Check())
                    {
                        dsAbnContact.tAbnContact.Rows[0].EndEdit();
                        if (this.InsertSqlData(dsAbnContact, dsAbnContact.tAbnContact))
                        {
                            dsAbnContact.tAbn.Rows[0]["Name"] = txtFirstName.Text + " " +
                                txtName.Text + " " + txtOtchestvo.Text;
                            dsAbnContact.tAbn.Rows[0].EndEdit();
                            this.UpdateSqlData(dsAbnContact, dsAbnContact.tAbn);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    break;
                case ActionAbnContact.Edit:
                    if (Check())
                    {
                        dsAbnContact.tAbnContact.Rows[0].EndEdit();
                        if (this.UpdateSqlData(dsAbnContact, dsAbnContact.tAbnContact))
                        {
                            DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
                            this.SelectSqlData(ds.tAbnContact, true, "where idAbn = " + idAbn.ToString() + " order by datechange desc", null, false, 1);
                            if (Convert.ToInt32(ds.tAbnContact.Rows[0]["id"]) ==
                                Convert.ToInt32(dsAbnContact.tAbnContact.Rows[0]["id"]))
                            {
                                dsAbnContact.tAbn.Rows[0]["Name"] = txtFirstName.Text + " " +
                                txtName.Text + " " + txtOtchestvo.Text;
                                dsAbnContact.tAbn.Rows[0].EndEdit();
                                this.UpdateSqlData(dsAbnContact, dsAbnContact.tAbn);
                            }
                            DialogResult = DialogResult.OK;
                        }
                    }
                    break;
                case ActionAbnContact.Read:
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                default: break;
            }
        }

        private bool Check()
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show ("Не введена фамилия абонента");
                return false;
            }
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Не введено имя абонента");
                return false;
            }
            return true;
        }


    }
}
