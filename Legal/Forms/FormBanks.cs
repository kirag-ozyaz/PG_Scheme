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
    public partial class FormBanks : FormLbr.FormBase
    {
        private int ID;
        
        public FormBanks()
        {
            InitializeComponent();
        }

        private void FormBanks_Load(object sender, EventArgs e)
        {
            buttonSave.Visible = false;
            buttonSaveCancel.Visible = false;

            panelMode.Visible = false;

            this.SelectSqlData(dsAbn, dsAbn.tBanks, true, " where Deleted=0 order by NameFull ");

            this.SelectSqlDataTableOther(dsAbn, "tBanksDafault", "tBanks", true, " where Deleted=0 and [Default] =1 order by NameFull  ", 1, false);

            //dgvBankDefault.ClearSelection();

            BanksDetails();
            
        }

        private void BanksDetails()
        {
            if (dgvefBanks.RowCount <= 0) return;
            textBoxName.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["nameFull"].Value);
            textBoxNameShort.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["nameShort"].Value);
            textBoxZIP.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["ZIP"].Value);
            textBoxCity.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["City"].Value);
            textBoxMFO.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["MFO"].Value); 
            textBoxCORSCHET.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["CORSCHET"].Value);
            textBoxLOCALSCH.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["LOCALSCH"].Value);

            if (dgvefBanks.CurrentRow.Cells["ParentBank"].Value != DBNull.Value) comboBoxParentBank.SelectedValue = (int)dgvefBanks.CurrentRow.Cells["ParentBank"].Value;
            else comboBoxParentBank.SelectedIndex = -1;

            if (dgvefBanks.CurrentRow.Cells["BankDest"].Value != DBNull.Value) comboBoxBankDest.SelectedValue = (int)dgvefBanks.CurrentRow.Cells["BankDest"].Value;
            else comboBoxBankDest.SelectedIndex = -1;

            textBoxParentAccount.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["ParentAccount"].Value);

            if ((bool)dgvefBanks.CurrentRow.Cells["REESTR"].Value) checkBoxReestr.Checked = true;
            else checkBoxReestr.Checked = false;

            if ((bool)dgvefBanks.CurrentRow.Cells["FILIAL"].Value) checkBoxFilial.Checked = true;
            else checkBoxFilial.Checked = false;

            if ((bool)dgvefBanks.CurrentRow.Cells["KAZN"].Value) checkBoxKAZN.Checked = true;
            else checkBoxKAZN.Checked = false;

            maskedTextBoxTREB.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["ReestrCount"].Value);
            maskedTextBoxReestrCount.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["TREB"].Value);


            if ((bool)dgvefBanks.CurrentRow.Cells["DefaultDGVCBC"].Value) checkBoxBankDefault.Checked = true;
            else checkBoxBankDefault.Checked = false;

            if ((bool)dgvefBanks.CurrentRow.Cells["UseSelfAccount"].Value) checkBoxUseSelfAccount.Checked = true;
            else checkBoxUseSelfAccount.Checked = false;

            textBoxPhones.Text = Convert.ToString(dgvefBanks.CurrentRow.Cells["Phones"].Value); 
            
        }

        private void dgvefBanks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BanksDetails();

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && toolStripButtonBankAdd.Visible == true) // если правой кнопкой
            {
                this.dgvefBanks.Rows[e.RowIndex].Selected = true;
                ///-----------
                dgvefBanks.CurrentCell = dgvefBanks["nameFull", e.RowIndex]; //делаем текущей
                this.contextMenuStripBanks.Show(System.Windows.Forms.Cursor.Position);

            }
        }

        private void dgvefBanks_KeyUp(object sender, KeyEventArgs e)
        {
            BanksDetails();
        
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvBankDefault_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FindeBank(Convert.ToInt32(dgvBankDefault.CurrentRow.Cells["bankIDDefault"].Value));
            
        }

        private void FindeBank(int IDBank)
        {
            for (int i = 0; i < dgvefBanks.RowCount; i++)
                if ((int)dgvefBanks[0, i].Value == IDBank) 
                {
                    dgvefBanks.CurrentCell = dgvefBanks["nameFull", i];
                    BanksDetails();
                    return;
                }
        }


        private void toolStripButtonBankAdd_Click(object sender, EventArgs e)
        {

            textBoxName.Text = "";
            textBoxNameShort.Text = "";
            textBoxZIP.Text = "";
            textBoxCity.Text = "";
            textBoxMFO.Text = "";
            textBoxCORSCHET.Text = "";
            textBoxLOCALSCH.Text = "";

            
            comboBoxParentBank.SelectedIndex = -1;
            
            comboBoxBankDest.SelectedIndex = -1;

            textBoxParentAccount.Text = "";

            checkBoxReestr.Checked = false;
                        
            checkBoxFilial.Checked = false;
                       
            checkBoxKAZN.Checked = false;

            maskedTextBoxTREB.Text = "";
            maskedTextBoxReestrCount.Text = "";
                                   
            checkBoxBankDefault.Checked = false;

            checkBoxUseSelfAccount.Checked = false;

            textBoxPhones.Text = "";

            dgvefBanks.Enabled = false;
            dgvefBanks.DefaultCellStyle.BackColor = Color.Gainsboro;
            dgvBankDefault.Enabled = false;
            dgvBankDefault.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
           

            buttonSave.Text = "Создать";
            buttonSave.Visible = true;
            buttonSaveCancel.Visible = true;

            labelMode.Text = "Добавление";
            panelMode.Visible = true;
            
        }

        private void toolStripButtonBankEdit_Click(object sender, EventArgs e)
        {
            BanksDetails();
            buttonSave.Text = "Сохранить";
            buttonSave.Visible = true;
            buttonSaveCancel.Visible = true;

            labelMode.Text = "Редактирование";
            panelMode.Visible = true;
            
            dgvefBanks.Enabled = false;
            dgvefBanks.DefaultCellStyle.BackColor = Color.Gainsboro;
            dgvBankDefault.Enabled = false;
            dgvBankDefault.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Введите полное наименование банка.");
                return;
            }

            if (buttonSave.Text == "Создать")
            {
                DataRow dr = dsAbn.tBanks.NewRow();

                dr["NameShort"] = textBoxNameShort.Text;
                dr["NameFull"] =  textBoxName.Text;
                dr["City"] = textBoxCity.Text; 
                dr["MFO"] = textBoxMFO.Text;
                dr["CORSCHET"] = textBoxCORSCHET.Text;
                dr["LOCALSCH"] = textBoxLOCALSCH.Text;
                //dr["Contacts"] =
                dr["Phones"] = textBoxPhones.Text;
                dr["UseSelfAccount"] = checkBoxUseSelfAccount.Checked;
                dr["ParentBank"] = (comboBoxParentBank.SelectedValue == null) ? DBNull.Value : comboBoxParentBank.SelectedValue;
                dr["ParentAccount"] = textBoxParentAccount.Text;
                dr["BankDest"] = (comboBoxBankDest.SelectedValue == null) ? DBNull.Value : comboBoxBankDest.SelectedValue;
                //dr["CALCSTATE"] =
                dr["ZIP"] = textBoxZIP.Text;
                //dr["BANKCODE"] =
                dr["TREB"] = (maskedTextBoxTREB.Text == "") ? 0 : Convert.ToInt32(maskedTextBoxTREB.Text);
                dr["REESTR"] = checkBoxReestr.Checked;
                dr["ReestrCount"] = (maskedTextBoxReestrCount.Text == "") ? 0 : Convert.ToInt32(maskedTextBoxReestrCount.Text);
                dr["PENI"] = 0;
                dr["DOPSCHET"] = 0;
                dr["FILIAL"] = checkBoxFilial.Checked;
                dr["KAZN"] = checkBoxKAZN.Checked;
                dr["Deleted"] = 0;
                dr["Default"] = 0;

                if (checkBoxBankDefault.Checked)
                {
                    if (MessageBox.Show("Вы действительно хотите сделать текущий банк по умолчанию?", "Банк по умолчанию",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (dsAbn.tBanksDafault.Rows.Count > 0)
                        {
                            int IDfefault = Convert.ToInt32(dsAbn.tBanksDafault.Rows[0]["BankID"]);
                            DataSet.DataSetAbn dsd = new Legal.DataSet.DataSetAbn();
                            this.SelectSqlData(dsd, dsd.tBanks, true, "where BankID = " + Convert.ToString(IDfefault));
                            dsd.tBanks.Rows[0]["Default"] = false;
                            dsd.tBanks.Rows[0].EndEdit();
                            this.UpdateSqlData(dsd, dsd.tBanks);
                        }

                        dr["Default"] = checkBoxBankDefault.Checked;

                    }
                }
                dsAbn.tBanks.Rows.Add(dr);
                ID = this.InsertSqlDataOneRow(dsAbn, dsAbn.tBanks);

                this.SelectSqlData(dsAbn, dsAbn.tBanks, true, " where Deleted=0 order by NameFull  ");
                this.SelectSqlDataTableOther(dsAbn, "tBanksDafault", "tBanks", true, " where Deleted=0 and [Default] =1 order by NameFull  ", 1, false);

                FindeBank(ID);

                MessageBox.Show("Внесен новый банк.");



            }

            if (buttonSave.Text == "Сохранить")
            {

                if (MessageBox.Show("Сохранить изменения?", "Редактирование реквизитов банка",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ID = (int)dgvefBanks.CurrentRow.Cells["bankID"].Value;

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tBanks, true, "where BankID = " + ID);

                    ds.tBanks.Rows[0]["NameShort"] = textBoxNameShort.Text;
                    ds.tBanks.Rows[0]["NameFull"] = textBoxName.Text;
                    ds.tBanks.Rows[0]["City"] = textBoxCity.Text;
                    ds.tBanks.Rows[0]["MFO"] = textBoxMFO.Text;
                    ds.tBanks.Rows[0]["CORSCHET"] = textBoxCORSCHET.Text;
                    ds.tBanks.Rows[0]["LOCALSCH"] = textBoxLOCALSCH.Text;
                    //ds.tBanks.Rows[0]["Contacts"] =
                    ds.tBanks.Rows[0]["Phones"] = textBoxPhones.Text;
                    
                    ds.tBanks.Rows[0]["UseSelfAccount"] = checkBoxUseSelfAccount.Checked;
                    ds.tBanks.Rows[0]["ParentBank"] = (comboBoxParentBank.SelectedValue == null) ? DBNull.Value : comboBoxParentBank.SelectedValue;
                    ds.tBanks.Rows[0]["ParentAccount"] = textBoxParentAccount.Text;
                    ds.tBanks.Rows[0]["BankDest"] = (comboBoxBankDest.SelectedValue == null) ? DBNull.Value : comboBoxBankDest.SelectedValue;
                    //ds.tBanks.Rows[0]["CALCSTATE"] =
                    ds.tBanks.Rows[0]["ZIP"] = textBoxZIP.Text;
                    //ds.tBanks.Rows[0]["BANKCODE"] =
                    ds.tBanks.Rows[0]["TREB"] = (maskedTextBoxTREB.Text == "") ? 0 : Convert.ToInt32(maskedTextBoxTREB.Text);
                    ds.tBanks.Rows[0]["REESTR"] = checkBoxReestr.Checked;
                    ds.tBanks.Rows[0]["ReestrCount"] = (maskedTextBoxReestrCount.Text == "") ? 0 : Convert.ToInt32(maskedTextBoxReestrCount.Text);
                    ds.tBanks.Rows[0]["PENI"] = 0;
                    ds.tBanks.Rows[0]["DOPSCHET"] = 0;
                    ds.tBanks.Rows[0]["FILIAL"] = checkBoxFilial.Checked;
                    ds.tBanks.Rows[0]["KAZN"] = checkBoxKAZN.Checked;
                    ds.tBanks.Rows[0]["Deleted"] = 0;


                    if (checkBoxBankDefault.Checked)
                    {
                        if (MessageBox.Show("Вы действительно хотите сделать текущий банк по умолчанию?", "Банк по умолчанию",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (dsAbn.tBanksDafault.Rows.Count > 0)
                            {
                                int IDfefault = Convert.ToInt32(dsAbn.tBanksDafault.Rows[0]["BankID"]);
                                DataSet.DataSetAbn dsd = new Legal.DataSet.DataSetAbn();
                                this.SelectSqlData(dsd, dsd.tBanks, true, "where BankID = " + Convert.ToString(IDfefault));
                                dsd.tBanks.Rows[0]["Default"] = false;
                                dsd.tBanks.Rows[0].EndEdit();
                                this.UpdateSqlData(dsd, dsd.tBanks);
                            }
                            
                            ds.tBanks.Rows[0]["Default"] = checkBoxBankDefault.Checked;

                            
                        }
                    }


                    if (this.UpdateSqlData(ds, ds.tBanks))
                    {
                        MessageBox.Show("Реквизиты отредактированы.");
                        this.SelectSqlData(dsAbn, dsAbn.tBanks, true, " where Deleted=0 order by NameFull  ");
                        this.SelectSqlDataTableOther(dsAbn, "tBanksDafault", "tBanks", true, " where Deleted=0 and [Default] =1 order by NameFull  ", 1, false);
                        FindeBank(ID);

                    }
                }

            }
            dgvefBanks.Enabled = true;
            dgvefBanks.DefaultCellStyle.BackColor = SystemColors.Window;
            dgvBankDefault.Enabled =true;
            dgvBankDefault.DefaultCellStyle.SelectionBackColor = SystemColors.Window;
            
            buttonSave.Visible = false;
            buttonSaveCancel.Visible = false;

            panelMode.Visible = false;
        }

        private void buttonSaveCancel_Click(object sender, EventArgs e)
        {
            
            dgvefBanks.Enabled = true;
            dgvefBanks.DefaultCellStyle.BackColor = SystemColors.Window;
            dgvBankDefault.Enabled = true;
            dgvBankDefault.DefaultCellStyle.SelectionBackColor = SystemColors.Window;

            buttonSave.Visible = false;
            buttonSaveCancel.Visible = false;
            panelMode.Visible = false;
        }

        private void toolStripButtonBankDel_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Вы действительно хотите удалить текущий банк?", "Удаление",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                ID = (int)dgvefBanks.CurrentRow.Cells["bankID"].Value;
                    
                if (dsAbn.tBanks.Rows.Count > 0)
                {

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tBanks, true, "where BankID = " + ID);
                    if ((bool)ds.tBanks.Rows[0]["Default"]) 
                    {
                        MessageBox.Show("Удаление невозможно! Данный банк выбран по умолчанию.");
                        return;
                    }
                    ds.tBanks.Rows[0]["Deleted"] = true;
                    ds.tBanks.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tBanks))
                    {
                       this.SelectSqlData(dsAbn.tBanks, true, "where deleted=0 and BankID > " + ID + " order by NameFull ", null, false, 1);
                       if (dsAbn.tBanks.Rows.Count > 0) ID = (int)dsAbn.tBanks.Rows[0]["BankID"];
                       this.SelectSqlData(dsAbn.tBanks, true, " where Deleted=0 order by NameFull  ");
                       this.SelectSqlDataTableOther(dsAbn, "tBanksDafault", "tBanks", true, " where Deleted=0 and [Default] =1 order by NameFull  ", 1, false);
                       if (ID > 0)
                       {
                          FindeBank(ID);
                       }

                       MessageBox.Show("Банк успешно удален");

                    }
                }


 
            }


        }

      
   

   
    }
}
