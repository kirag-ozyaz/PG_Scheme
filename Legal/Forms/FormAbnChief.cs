using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnChief : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]
        private string FNAME = "";


        public FormAbnChief()
        {
            InitializeComponent();
        }

        public FormAbnChief(int id, bool insert)
        {
            InitializeComponent();
            ID = id;
            isInsert = insert;
            this.Text = (isInsert) ? "Новый руководитель" : "Редактировать";
        }

        public FormAbnChief(int id, bool insert, string fname)
        {
            InitializeComponent();
            ID = id;
            isInsert = insert;
            this.Text = (isInsert) ? "Новый руководитель" : "Редактировать";
            FNAME = fname;
        }


        private void FormAbnChief_Load(object sender, EventArgs e)
        {
            if (isInsert) // добавление
            {
                DataRow r = dsAbnChief.tG_AbnChief.NewRow();
                r["idAbn"] = ID;
                r["I_Post"] = "";
                r["I_F"] = "";
                r["I_I"] = "";
                r["I_O"] = "";
                r["R_Post"] = "";
                r["R_F"] = "";
                r["R_I"] = "";
                r["R_O"] = "";
                r["D_Post"] = "";
                r["D_F"] = "";
                r["D_I"] = "";
                r["D_O"] = "";
                r["T_Post"] = "";
                r["T_F"] = "";
                r["T_I"] = "";
                r["T_O"] = "";
                r["DocBase"] = "";
                r["DateChange"] = System.DateTime.Now.Date;
                dsAbnChief.tG_AbnChief.Rows.Add(r);
            }
            else //редактирование
            {
                if (FNAME == "FormAbnChiefHistory")
                {
                    this.SelectSqlData(dsAbnChief, dsAbnChief.tG_AbnChief, true, " where id = " + ID.ToString());
                    if (dsAbnChief.tG_AbnChief.Rows.Count == 0)
                    {
                        MessageBox.Show("Данных для редактирования по этому абоненту не существует");
                        this.Close();
                    }
                    foreach (Control c in this.Controls)
                    {
                        if (c.Name == "buttonOK")
                            c.Enabled = false;
                    }

                }
                else
                {
                    this.SelectSqlData(dsAbnChief.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange Desc", null, false, 1);
                    if (dsAbnChief.tG_AbnChief.Rows.Count == 0)
                    {
                        MessageBox.Show("Данных для редактирования по этому абоненту не существует");
                        this.Close();
                    }
                }
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            dsAbnChief.tG_AbnChief.Rows[0].EndEdit();
            if (isInsert)
            {
                isOk = this.InsertSqlData(dsAbnChief, dsAbnChief.tG_AbnChief);
            }
            else
                isOk = this.UpdateSqlData(dsAbnChief, dsAbnChief.tG_AbnChief);
            if (isOk) this.DialogResult = DialogResult.OK;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            R_postTextBox.Text = I_postTextBox.Text;
            r_FTextBox.Text = i_FTextBox.Text;
            r_ITextBox.Text = i_ITextBox.Text;
            r_OTextBox.Text = i_OTextBox.Text;

            D_postTextBox.Text = I_postTextBox.Text;
            d_FTextBox.Text = i_FTextBox.Text;
            d_ITextBox.Text = i_ITextBox.Text;
            d_OTextBox.Text = i_OTextBox.Text;

            T_postTextBox.Text = I_postTextBox.Text;
            t_FTextBox.Text = i_FTextBox.Text;
            t_ITextBox.Text = i_ITextBox.Text;
            t_OTextBox.Text = i_OTextBox.Text;
        }
    }
}
