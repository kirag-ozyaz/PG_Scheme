using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Prv.Forms.Plombs
{
    public partial class FormPlombAdd : FormLbr.FormBase
    {
        private int idWorker = -1;
        private int idPoint = -1;

        #region FormPlombAdd Evetns
        public FormPlombAdd()
        {
            InitializeComponent();
        }

        public FormPlombAdd(int idWorker, int idPoint)
        {
            InitializeComponent();
            this.idWorker = idWorker;
            this.idPoint = idPoint;
            dateTimePickerDateInst.Value = DateTime.Now.Date;

        }

        private void FormPlombAdd_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsWorker.Tables["vWorkerGroup"], true, " where ParentKey = ';GroupWorker;MasterPlomber;' " +
                "and dateEnd is null order by fio", null, true);
            if (idWorker == -1) cmbControler.SelectedIndex = -1;
            else cmbControler.SelectedValue = idWorker;

            this.SelectSqlData(dsWorker.Tables["tR_Classifier"], true, " where ParentKey = ';SKUEE;Plomb;TypePlomb;' " +
                "and isGroup = 0 and deleted = 0");
            cmbTypePlomb.SelectedIndex = -1;

            if (idPoint != -1) //update
            {
                this.SelectSqlData(dsPlomb, dsPlomb.tPlomb, true, " where id = " + idPoint.ToString());
                cmbControler.SelectedValue = dsPlomb.tPlomb.Rows[0]["idWorker"];
                cmbTypePlomb.SelectedValue = dsPlomb.tPlomb.Rows[0]["typePlomb"];
                cmbTypePlomb.Enabled = false;
                txtSeria.Text = dsPlomb.tPlomb.Rows[0]["Seria"].ToString();
                if (!string.IsNullOrEmpty(txtSeria.Text)) checkBoxSeria.Checked = true;
                checkBoxSeria.Enabled = false;
                txtSeria.Enabled = false;
                if (dsPlomb.tPlomb.Rows[0]["DigitNumber"] != DBNull.Value)
                    numericUpDownDigit.Value = Convert.ToInt32(dsPlomb.tPlomb.Rows[0]["DigitNumber"]);
                numericUpDownDigit.Enabled = false;
                maskedTextBoxNumber.Text = dsPlomb.tPlomb.Rows[0]["Number"].ToString();
                radioButtonNumber.Enabled = false;
                maskedTextBoxNumber.Enabled = false;
                radioButtonDiapason.Enabled = false;
                dateTimePickerDateInst.Value = Convert.ToDateTime(dsPlomb.tPlomb.Rows[0]["DateInst"]);
            }
        }
        #endregion


        #region Controls Events
        private void checkBoxSeria_CheckedChanged(object sender, EventArgs e)
        {
            txtSeria.Enabled = checkBoxSeria.Checked;
        }
        private void radioButtonNumber_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxNumber.Enabled = radioButtonNumber.Checked;
            maskedTextBoxNumberBeg.Enabled = !radioButtonNumber.Checked;
            maskedTextBoxNumberEnd.Enabled = !radioButtonNumber.Checked;
        }
        private void numericUpDownDigit_ValueChanged(object sender, EventArgs e)
        {
           maskedTextBoxNumber.Mask = new string('0', Convert.ToInt32(numericUpDownDigit.Value));
           maskedTextBoxNumberBeg.Mask = new string('0', Convert.ToInt32(numericUpDownDigit.Value));
           maskedTextBoxNumberEnd.Mask = new string('0', Convert.ToInt32(numericUpDownDigit.Value));

        }
        #endregion

        // Проверка
        private bool Check()
        {
            // Контролер
            if (cmbControler.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран контролер");
                return false;
            }
            // тип пломбы
            if (cmbTypePlomb.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран тип пломбы");
                return false;
            }
            // серия
            if (checkBoxSeria.Checked)
                if (string.IsNullOrEmpty(txtSeria.Text))
                {
                    MessageBox.Show("Не введена серия");
                    return false;
                }
            // диапазон
            if (radioButtonDiapason.Checked)
            {
                if ((string.IsNullOrEmpty(maskedTextBoxNumberBeg.Text)) || (string.IsNullOrEmpty(maskedTextBoxNumberEnd.Text)))
                {
                    MessageBox.Show("Некорректно введен диапазон");
                    return false;
                }
                if ((Convert.ToInt32(maskedTextBoxNumberBeg.Text)) > (Convert.ToInt32(maskedTextBoxNumberEnd.Text)))
                {
                    MessageBox.Show("Некорректно введен диапазон");
                    return false;
                }
            }
            else // номер
            {
                if (string.IsNullOrEmpty(maskedTextBoxNumber.Text))
                {
                    MessageBox.Show("Пустое значение номера пломбы");
                    return false;
                }
            }
            return true;
        }
        // добавить пломбы!!!
        private bool AddNumPlomb()
        {
            // Проверка
            if (!Check()) return false;  

            /*index: typeplomb, seria, numberstring, digitnumber*/
            DataSets.DataSetPlomb ds = new Prv.DataSets.DataSetPlomb();
            if (radioButtonNumber.Checked) // одна пломба
            {
                string seria = (checkBoxSeria.Checked) ? " and seria = '" + txtSeria.Text + "' " :
                    " and seria is null ";
                this.SelectSqlData(ds, ds.vPlombStatus, true, " where typeplomb = " + cmbTypePlomb.SelectedValue.ToString() + 
                    seria + " and numberstring = " + maskedTextBoxNumber.Text + " and digitnumber = " + numericUpDownDigit.Value.ToString());
                if (ds.vPlombStatus.Rows.Count > 0)
                {
                    MessageBox.Show("Данная пломба уже выдана.\n ФИО контролера: " + ds.vPlombStatus.Rows[0]["Worker"].ToString());
                    return false;
                }
                else
                {
                    //INSERT
                    DataRow newRow = ds.tPlomb.NewRow();
                    newRow["typePlomb"] = cmbTypePlomb.SelectedValue;
                    newRow["idActPlomb"] = (int)ActPlomb.Extradition;
                    newRow["idWorker"] = cmbControler.SelectedValue;
                    if (checkBoxSeria.Checked) newRow["Seria"] = txtSeria.Text;
                    newRow["Number"] = maskedTextBoxNumber.Text;
                    newRow["DigitNumber"] = Convert.ToInt32(numericUpDownDigit.Value);
                    newRow["Date"] = DateTime.Now.Date;
                    newRow["DateInst"] = dateTimePickerDateInst.Value.Date;
                    ds.tPlomb.Rows.Add(newRow);
                    return this.InsertSqlData(ds, ds.tPlomb);
                }
            }
            else
            {
                string seria = (checkBoxSeria.Checked) ? " and seria = '" + txtSeria.Text + "' " :
                    " and seria is null ";
                this.SelectSqlData(ds, ds.vPlombStatus, true, " where typeplomb = " + cmbTypePlomb.SelectedValue.ToString() +
                    seria + " and numberstring >= " + maskedTextBoxNumberBeg.Text + 
                    " and numberstring <= " + maskedTextBoxNumberEnd.Text + " and digitnumber = " + numericUpDownDigit.Value.ToString());

                string existNumber = "";
                foreach (DataRow dr in ds.vPlombStatus.Rows)
                {
                    if (string.IsNullOrEmpty(existNumber))
                        existNumber = dr["Seria"].ToString() + " " + dr["NumberString"].ToString();
                    else
                        existNumber += ", " + dr["Seria"].ToString() + " " + dr["NumberString"].ToString();
                }
                if (!string.IsNullOrEmpty(existNumber))
                {
                    MessageBox.Show("Некоторые пломбы из введенного диапазона уже выданы\n" + existNumber);
                    return false;
                }
                else
                {
                    // INSERT
                    for (int i = Convert.ToInt32(maskedTextBoxNumberBeg.Text); i <= Convert.ToInt32(maskedTextBoxNumberEnd.Text); i++)
                    {
                        DataRow newRow = ds.tPlomb.NewRow();
                        newRow["typePlomb"] = cmbTypePlomb.SelectedValue;
                        newRow["idActPlomb"] = (int)ActPlomb.Extradition;
                        newRow["idWorker"] = cmbControler.SelectedValue;
                        if (checkBoxSeria.Checked) newRow["Seria"] = txtSeria.Text;
                        newRow["Number"] = i;
                        newRow["DigitNumber"] = Convert.ToInt32(numericUpDownDigit.Value);
                        newRow["Date"] = DateTime.Now.Date;
                        newRow["DateInst"] = dateTimePickerDateInst.Value.Date;
                        ds.tPlomb.Rows.Add(newRow);
                    }
                    return this.InsertSqlData(ds, ds.tPlomb);
                }
            }
        }
        
        //изменить пломбу
        private bool UpdNumPlomb()
        {
            // Контролер
            if (cmbControler.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран контролер");
                return false;
            }

                //UPDATE
            dsPlomb.tPlomb.Rows[0]["idWorker"] = cmbControler.SelectedValue;
            dsPlomb.tPlomb.Rows[0]["DateInst"] = dateTimePickerDateInst.Value.Date;
            dsPlomb.tPlomb.Rows[0].EndEdit();
            return this.UpdateSqlData(dsPlomb, dsPlomb.tPlomb);

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (idPoint == -1)
            {
                if (AddNumPlomb()) DialogResult = DialogResult.OK;
            }
            else
            {
                if (UpdNumPlomb()) DialogResult = DialogResult.OK;
            }
               
        }

        private void FormPlombAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                buttonOk_Click(sender, e);
        }



    }
}
