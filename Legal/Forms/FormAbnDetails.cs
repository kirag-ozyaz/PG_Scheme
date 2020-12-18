using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnDetails : FormLbr.FormBase
    {
        private int ID = -1;
        private bool isInsert = false;  // false - update]


        public FormAbnDetails()
        {
            InitializeComponent();
        }
        
        public FormAbnDetails(int id,bool insert)
        {
            InitializeComponent();
            ID = id;
            isInsert = insert;
            this.Text = (isInsert) ? "Новые Реквизиты" : "Редактировать";
        }

        private void FormAbnDetails_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnDetails1, dsAbnDetails1.tBanks, true, " order by NameShort");
            if (isInsert) // добавление
            {
                this.SelectSqlData(dsAbnDetails1, dsAbnDetails1.tBanks, true, " where [Default] = 1");
                this.SelectSqlData(dsAbnDetails1.vG_AbnDetails, true, " where idAbn = " + ID.ToString() + " order by DateChange, id Desc", null, false, 1);
                DataRow r = dsAbnDetails1.tG_AbnInfo.NewRow();
              //  if (dsAbnDetails1.vG_AbnDetails.Rows.Count > 0) 
              //  { 
              //      r["idAbn"] = ID;
              //      r["NameShort"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["NameShort"];
              //      r["NameFull"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["NameFull"];
              //      r["INN"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["INN"];
              //      r["KPP"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["KPP"];
              //      r["OKPO"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["OKPO"];
              //      r["OKVED"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["OKVED"];
              //      r["BankID"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["BankID"];
              //      r["BankDest"] = dsAbnDetails1.tBanks.Rows[0]["BankID"]; 
              //      r["BankAcnt"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["BankAcnt"];
              //      r["DateChange"] = System.DateTime.Now.Date;
              ////      r["NameODS"] = dsAbnDetails1.vG_AbnDetails.Rows[0]["NameODS"];
              //      INNmaskedTextBox.Enabled = false;
              //      maskedTextBox1.Enabled = false; 

              //  }
              //  else
              //  {
                this.SelectSqlData(dsAbnDetails1, dsAbnDetails1.tAbn, true, " where id = " + ID.ToString());
                r["idAbn"] = ID;
                r["NameShort"] = dsAbnDetails1.tAbn.Rows[0]["Name"];
                r["NameFull"] = "";
                r["INN"] = "";
                r["KPP"] = "";
                r["OKPO"] = "";
                r["OKVED"] = "";
                r["BankID"] = 0;
                r["BankDest"] = dsAbnDetails1.tBanks.Rows[0]["BankID"];
                r["BankAcnt"] = "";
                r["DateChange"] = System.DateTime.Now.Date;
                INNmaskedTextBox.Enabled = false;
                maskedTextBox1.Enabled = false; 
              //  }
                dsAbnDetails1.tG_AbnInfo.Rows.Add(r);
            }
            else //редактирование
            {
                INNmaskedTextBox.Enabled = true;
                maskedTextBox1.Enabled = true; 

                this.SelectSqlData(dsAbnDetails1.tG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange Desc", null, false, 1);


                if (dsAbnDetails1.tG_AbnInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Данных для редактирования по этому абоненту не существует");
                    this.Close();
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // проверим ИНН на валидность
            // должно быть 10 или 12 цифр
            
            string value = INNmaskedTextBox.Text.Trim();
            if (value.Length > 0)
            {
                if (!(value.Length == 10 || value.Length == 12))
                {
                    MessageBox.Show("Длина ИНН должна быть 10 или 12 знаков");
                    return;
                }
                else
                {
                    try
                    {
                        if (IsINN(long.Parse(value)) == false)
                        {
                            MessageBox.Show("Код ИНН не прошел проверку");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка в ходе проверки ИНН");
                        return;
                    }
                }
                // проверим ИНН на дублирование
                //string INN = INNmaskedTextBox.Text.Trim();
                //SelectSqlData(dsAbnDetails1, dsAbnDetails1.vG_INN, true, " where INN like " + INN + " and id <> " + ID);
                //if (dsAbnDetails1.vG_INN.Rows.Count > 0)
                //{
                //    string code = dsAbnDetails1.vG_INN.Rows[0]["AbnCode"].ToString();
                //    MessageBox.Show("Такой ИНН уже существует у абонента " + code);
                //    return;
                //}
            }
            if (txtEmail.Text.Length > 0)
            {
                if (txtEmail.Text.IndexOf("@") < 1)
                {
                    MessageBox.Show("Неверно набран адрес электронной почты!");
                    return;
                }
                if (txtEmail.Text.IndexOf(".") < 3)
                {
                    MessageBox.Show("Неверно набран адрес электронной почты!");
                    return;
                }
            }


            bool isOk = false;
            dsAbnDetails1.tG_AbnInfo.Rows[0].EndEdit();
            if (isInsert)
            {
                isOk = this.InsertSqlData(dsAbnDetails1, dsAbnDetails1.tG_AbnInfo);
            }
            else
                isOk = this.UpdateSqlData(dsAbnDetails1, dsAbnDetails1.tG_AbnInfo);
            if (isOk) this.DialogResult = DialogResult.OK;
        }
        
        // новые рекизиты для вышестоящей организации
        private void btnParent_Click(object sender, EventArgs e)
        {
            FormAbnParent fAdd = new FormAbnParent(ID, true);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // редактировать реквизиты для вышестоящей организации
        private void button1_Click(object sender, EventArgs e)
        {
            FormAbnParent fAdd = new FormAbnParent(ID, false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void bankPayerComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && string.IsNullOrEmpty(cmb.Text))
            {
                cmb.SelectedIndex = -1;
                dsAbnDetails1.tG_AbnInfo.Rows[0]["BankID"] = DBNull.Value;
            }
        }


        private void bankPayeeComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && string.IsNullOrEmpty(cmb.Text))
            {
                cmb.SelectedIndex = -1;
                dsAbnDetails1.tG_AbnInfo.Rows[0]["BankDest"] = DBNull.Value;
            }
        }

        private static bool IsINN(long value)
        {
            int[] arrMul10 = {2, 4, 10, 3, 5, 9, 4, 6, 8};
            int[] arrMul121 = {7, 2, 4, 10, 3, 5, 9, 4, 6, 8};
            int[] arrMul122 = {3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8};


            // должно быть 10 или 12 цифр
            if (value < 1000000000 || value >= 1000000000000)
                return false;

            int digits = (int)Math.Log10(value) + 1;
            if (!(digits == 10 || digits == 12))
                return false;

            // вычисляем контрольную сумму
            string s = value.ToString("D" + digits.ToString());
            int[] factors = digits == 10 ? arrMul10 : arrMul122;

        startCheck:

            long sum = 0;
            for (int i = 0; i < factors.Length; i++)
                sum += byte.Parse(s[i].ToString()) * factors[i];
            sum %= 11;
            sum %= 10;
            if (sum != byte.Parse(s[factors.Length].ToString()))
                return false;
            else if (digits == 12)
            {
                // используется маленький трюк:
                // запускается повторная проверка, начиная с метки startCheck,
                // но с другими коэффициентами, а чтобы исключить повторный вход 
                // в эту ветку, сбрасываем digits
                factors = arrMul121;
                digits = 0;
                goto startCheck;
            }
            else
                return true;
        }

        private void btnInnCheck_Click(object sender, EventArgs e)
        {
            // проверим ИНН на дублирование
            string INN = INNmaskedTextBox.Text.Trim();
            SelectSqlData(dsAbnDetails1, dsAbnDetails1.vG_INN, true, " where INN like " + INN + " and id <> " + ID);
            int rowsCount = dsAbnDetails1.vG_INN.Rows.Count;
            if (rowsCount > 0)
            {
                string code = "";
                for (int i = 0; i < rowsCount; i++)
                {
                    code += dsAbnDetails1.vG_INN.Rows[i]["AbnCode"].ToString() + " ";
                }
                MessageBox.Show("Такой ИНН уже существует у абонентов " + code);
                return;
            }
            else
                MessageBox.Show("Такой ИНН не найден у других абонентов ..");
        }




    }
}
