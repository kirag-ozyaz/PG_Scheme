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
    public partial class FormAbnFind : FormLbr.FormBase
    {
        private int selectedAbonent = -1;
        private int selectedTypeAbn = -1;
        private int selectedObj = -1;

        #region Property
        /// <summary>
        /// Выбранный абонент
        /// </summary>
        public int SelectedAbonent
        {
            get
            {
                return selectedAbonent;
            }
        }
        /// <summary>
        /// Выбранный тип абонента
        /// </summary>
        public int SelectedTypeAbn
        {
            get
            {
                return selectedTypeAbn;
            }
        }
        /// <summary>
        /// Выбранный объект
        /// </summary>
        public int SelectedObj
        {
            get
            {
                return selectedObj;
            }
        }
        #endregion

        #region FormAbnFind Events
        public FormAbnFind()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void FormAbnFind_Load(object sender, EventArgs e)
        {
            LoadDirectory();
        }
        // нажатие клавиши
        private void FormAbnFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.None)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }

            if (Control.ModifierKeys == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // fill
                        buttonFill_Click(sender, e);
                        break;
                    case Keys.P: // print
                        dgvFind.PrintDataGridView();
                        break;
                    case Keys.F: // find in datagrid
                        toolStripTextBoxGrid.Focus();
                        toolStripTextBoxGrid.SelectAll();
                        break;
                    default: break;
                }
            }
        }
        #endregion

        // загрузка справочников
        private void LoadDirectory()
        {
            this.SelectSqlData(dsObl, dsObl.Tables["tr_kladrObj"], true,
                " where [Level] = 1 and deleted = 0 order by name, socr");

            cmbObl.SelectedIndex = cmbObl.FindString("Ульяновская обл");
            // загрузка районов/городов
            if (cmbObl.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionObl.Text = "Ульяновск г";
            }

            // справочник типов абонентов
            this.SelectSqlData(dsTypeAbn, dsTypeAbn.Tables["tR_Classifier"], true,
                " where id in (" + Constants.Constants.TypeAbnPrivate.ToString() + "," 
                 + Constants.Constants.TypeAbnLegalAll + "," 
                 + Constants.Constants.TypeAbnPrivateNoDog.ToString() + ") order by name");
            DataRow dr = dsTypeAbn.Tables["tR_Classifier"].NewRow();
            dr["Name"] = "Все";
            dsTypeAbn.Tables["tR_Classifier"].Rows.InsertAt(dr, 0);
            cmbTypeAbn.SelectedIndex = 1;

            // справочник контролеров
            this.SelectSqlData(dsAbnFind, dsAbnFind.vWorkerGroup, true, " where idGroup in ( " + Constants.Constants.WorkerGroupControlerBS.ToString() + "," + Constants.Constants.WorkerGroupControlerUL.ToString() +
                ") and dateEnd is null order by FIO");
            dr = dsAbnFind.vWorkerGroup.NewRow();
            dr["id"] = -1;
            dr["FIO"] = "Все";
            dsAbnFind.vWorkerGroup.Rows.InsertAt(dr, 0);
            cmbControler.SelectedIndex = 0;
        }

        #region ComboBoxAddress Events
        // смена области
        private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // загрузка районов/города выбранной области
            if (cmbObl.SelectedIndex < 0)
                dsRaionObl.Tables["tR_KladrObj"].Clear();
            else
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionCity.SelectedIndex = -1;
            }
             
        }
        // смена района/города
        private void cmbRaionObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // загрузка районов/города выбранной области
            if (cmbRaionObl.SelectedIndex < 0)
                dsPunkts.Tables["tR_KladrObj"].Clear();
            else
            {
                // населенные пункты
                this.SelectSqlData(dsPunkts, dsPunkts.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                DataRow dr = dsPunkts.Tables["tR_kladrObj"].NewRow();
                dr["Name"] = "Все";
                dsPunkts.Tables["tR_kladrObj"].Rows.InsertAt(dr, 0);
                cmbCity.SelectedIndex = 0;

                // районы города/населенного пункта
                DataSets.DataSetPrv dsTmp = new DataSets.DataSetPrv();
                this.SelectSqlData(dsTmp, dsTmp.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " +
                    cmbRaionObl.SelectedValue.ToString());

                if (dsTmp.tR_Classifier.Rows.Count <= 0)
                    dsRaionCity.Tables["tR_Classifier"].Clear();
                else
                {
                    this.SelectSqlData(dsRaionCity, dsRaionCity.Tables["tR_Classifier"], true, "where isGRoup = 0 and parentkey = '" +
                        dsTmp.tR_Classifier.Rows[0]["ParentKey"] + "' and deleted = 0 order by name");
                    dr = dsRaionCity.Tables["tR_Classifier"].NewRow();
                    dr["id"] = -1;
                    dr["Name"] = "Все";
                    dsRaionCity.Tables["tR_Classifier"].Rows.InsertAt(dr, 0);
                    cmbRaionCity.SelectedIndex = 0;
                }

                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true,
                    " where KladrObjId = " + cmbRaionObl.SelectedValue + " and deleted = 0 order by name, socr ");
                dr = dsStreet.Tables["tR_KladrStreet"].NewRow();
                dr["Name"] = "Все";
                dsStreet.Tables["tR_KladrStreet"].Rows.InsertAt(dr, 0);
                cmbStreet.SelectedIndex = 0;
            }
        }
        // смена населенного пункта
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex > 0)
            {
                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true,
                    " where KladrObjId = " + cmbCity.SelectedValue + " and deleted = 0 order by name, socr ");
                DataRow dr = dsStreet.Tables["tR_KladrStreet"].NewRow();
                dr["Name"] = "Все";
                dsStreet.Tables["tR_KladrStreet"].Rows.InsertAt(dr, 0);
                cmbStreet.SelectedIndex = -1;
            }
        }
        #endregion

        // получить условие к sql-запросу
        private string GetWhere(bool isLike)

        {
            string where = "";

            #region Наименование потребителя

            if (!string.IsNullOrEmpty(txtNameAbn.Text))
                if (isLike)
                    if (string.IsNullOrEmpty(where))
                        where = " where (Name LIKE '%" + txtNameAbn.Text + "%') ";
                    else
                        where += " and (Name LIKE '%" + txtNameAbn.Text + "%') ";
                else
                    if (string.IsNullOrEmpty(where))
                        where = " where (Name = '" + txtNameAbn.Text + "') ";
                    else
                        where += " and (Name = '" + txtNameAbn.Text + "') ";
            #endregion

            #region ФИО
            //фамилия
            if (!string.IsNullOrEmpty(txtFamily.Text))
                if (isLike)
                    if (string.IsNullOrEmpty(where))
                        where = " where (F LIKE '%" + txtFamily.Text + "%') ";
                    else
                        where += " and (F LIKE '%" + txtFamily.Text + "%') ";
                else
                    if (string.IsNullOrEmpty(where))
                        where = " where (F = '" + txtFamily.Text + "') ";
                    else
                        where += " and (F = '" + txtFamily.Text + "') ";
            //имя
            if (!string.IsNullOrEmpty(txtName.Text))
                if (isLike)
                    if (string.IsNullOrEmpty(where))
                        where = " where (I LIKE '%" + txtName.Text + "%') ";
                    else
                        where += " and (I LIKE '%" + txtName.Text + "%') ";
                else
                    if (string.IsNullOrEmpty(where))
                        where = " where (I = '" + txtName.Text + "') ";
                    else
                        where += " and (I = '" + txtName.Text + "') ";
            //отчество
            if (!string.IsNullOrEmpty(txtOtchestvo.Text))
                if (isLike)
                    if (string.IsNullOrEmpty(where))
                        where = " where (O LIKE '%" + txtOtchestvo.Text + "%') ";
                    else
                        where += " and (O LIKE '%" + txtOtchestvo.Text + "%') ";
                else
                    if (string.IsNullOrEmpty(where))
                        where = " where (O = '" + txtOtchestvo.Text + "') ";
                    else
                        where += " and (O = '" + txtOtchestvo.Text + "') ";

            #endregion
            
            #region Блок адреса
            // улица
            if (cmbStreet.SelectedIndex > 0)
                if (string.IsNullOrEmpty(where))
                    where = " where (idStreet = " + Convert.ToInt32(cmbStreet.SelectedValue) + ") ";
                else
                    where += " and (idStreet = " + Convert.ToInt32(cmbStreet.SelectedValue) + ") ";

            // район города
            if (cmbRaionCity.SelectedIndex > 0)
                if (string.IsNullOrEmpty(where))
                    where = " where (idRaionCity = " + Convert.ToInt32(cmbRaionCity.SelectedValue) + ") ";
                else
                    where += " and (idRaionCity = " + Convert.ToInt32(cmbRaionCity.SelectedValue) + ") ";

            // нас пункт
            switch (cmbCity.SelectedIndex)
            {
                case -1:
                     if (string.IsNullOrEmpty(where))
                         where = " where (KladrObjId = " + Convert.ToInt32(cmbRaionObl.SelectedValue) + ") ";
                     else
                         where += " and (KladrObjId = " + Convert.ToInt32(cmbRaionObl.SelectedValue) + ") ";
                    break;
                case 0:
                    if (string.IsNullOrEmpty(where))
                        where = " where (KladrObjId = " + Convert.ToInt32(cmbRaionObl.SelectedValue) + 
                            " or KladrObjParent = " + Convert.ToInt32(cmbRaionObl.SelectedValue) + ") ";
                    else
                        where += " and (KladrObjId = " + Convert.ToInt32(cmbRaionObl.SelectedValue) + 
                            " or KladrObjParent = " + Convert.ToInt32(cmbRaionObl.SelectedValue) + ") ";
                    break;
                default:
                     if (string.IsNullOrEmpty(where))
                         where = " where (KladrObjId = " + Convert.ToInt32(cmbCity.SelectedValue) + ") ";
                     else
                         where += " and (KladrObjId = " + Convert.ToInt32(cmbCity.SelectedValue) + ") ";
                    break;
            }

            // Дом
            if (!string.IsNullOrEmpty(txtHouse.Text))
                if (isLike)
                    if (string.IsNullOrEmpty(where))
                        where = " where (str(house) like '%" + txtHouse.Text + "%') ";
                    else
                        where += " and (str(house) like '%" + txtHouse.Text + "%') ";
                else
                    if (string.IsNullOrEmpty(where))
                        where = " where (house = " + txtHouse.Text + ") ";
                    else
                        where += " and (house = " + txtHouse.Text + ") ";

            // префикс дома
            if (!string.IsNullOrEmpty(txtHousePrefix.Text))
                if (isLike)
                    if (string.IsNullOrEmpty(where))
                        where = " where (houseprefix like '%" + txtHousePrefix.Text + "%') ";
                    else
                        where += " and (houseprefix like '%" + txtHousePrefix.Text + "%') ";
                else
                    if (string.IsNullOrEmpty(where))
                        where = " where (houseprefix = '" + txtHousePrefix.Text + "') ";
                    else
                        where += " and (houseprefix = '" + txtHousePrefix.Text + "') ";

            // квартира
            if (!string.IsNullOrEmpty(txtApartment.Text))
                if (isLike)
                    if (string.IsNullOrEmpty(where))
                        where = " where (apartment like '%" + txtApartment.Text + "%') ";
                    else
                        where += " and (apartment like '%" + txtApartment.Text + "%') ";
                else
                    if (string.IsNullOrEmpty(where))
                        where = " where (apartment = '" + txtApartment.Text + "') ";
                    else
                        where += " and (apartment = '" + txtApartment.Text + "') ";

            #endregion

            #region Тип абонента
            if (cmbTypeAbn.SelectedIndex > 0)
                if (string.IsNullOrEmpty(where))
                    where = " where (typeAbn = " + Convert.ToInt32(cmbTypeAbn.SelectedValue) + ") ";
                else
                    where += " and (typeAbn = " + Convert.ToInt32(cmbTypeAbn.SelectedValue) + ") ";
            else
                if (string.IsNullOrEmpty(where))
                    where = " where (typeAbn in (" + Constants.Constants.TypeAbnPrivate.ToString() + ","
                       + Constants.Constants.TypeAbnLegal.ToString() + ","
                       + Constants.Constants.TypeAbnNet.ToString() + ","
                       + Constants.Constants.TypeAbnSale.ToString() + ","
                       + Constants.Constants.TypeAbnPrivateNoDog.ToString() + ")) ";
                else
                    where += " and (typeAbn in (" + Constants.Constants.TypeAbnPrivate.ToString() + ","
                       + Constants.Constants.TypeAbnLegal.ToString() + ","
                       + Constants.Constants.TypeAbnNet.ToString() + ","
                       + Constants.Constants.TypeAbnSale.ToString() + ","
                       + Constants.Constants.TypeAbnPrivateNoDog.ToString() + ")) ";
            #endregion

            #region Controler
            if (cmbControler.SelectedIndex > 0)
                if (string.IsNullOrEmpty(where))
                    where = " where (idWorker = " + Convert.ToInt32(cmbControler.SelectedValue) + ") ";
                else
                    where += " and (idWorker = " + Convert.ToInt32(cmbControler.SelectedValue) + ") ";
            #endregion

            #region Тип объекта
            if (string.IsNullOrEmpty(where))
                where = " where (typeObj in (1146,1147) or typeObj is null) ";
            else
                where += " and (typeObj in (1146,1147) or typeObj is null) ";
            #endregion

            return where;
        }

        // Заполнение
        private void buttonFill_Click(object sender, EventArgs e)
        {
            string where = GetWhere(checkBoxIsLike.Checked);

            this.SelectSqlData(dsAbnFind, dsAbnFind.vAbnFind, true, where);
        }

        private void bindingSourceFind_ListChanged(object sender, ListChangedEventArgs e)
        {
            DataTable dt = dsAbnFind.vAbnFind.Copy();

            if (string.IsNullOrEmpty(bindingSourceFind.Filter))
            {
                toolLabelCountActive.Text = "Активные - " + dt.Select("isActive = 1").Length.ToString();
                toolLabelCountNotActive.Text = "Неактивные - " + dt.Select("isActive = 0").Length.ToString();
                toolLabelCountAll.Text = "Всего - " + dt.Rows.Count.ToString();
            }
            else
            {
                toolLabelCountActive.Text = "Активные - " + dt.Select(bindingSourceFind.Filter + " and isActive = 1").Length.ToString();
                toolLabelCountNotActive.Text = "Неактивные - " + dt.Select(bindingSourceFind.Filter + " and isActive = 0").Length.ToString();
                toolLabelCountAll.Text = "Всего - " + dt.Select(bindingSourceFind.Filter).Length.ToString();
            }
        }

        #region toolStripMain Events
        // поиск снчала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvFind.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxGrid.Text);
        }

        private void toolStripTextBoxGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgvFind.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxGrid.Text);
        }

        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvFind.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxGrid.Text);
        }

        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvFind.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxGrid.Text);
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvFind.PrintDataGridView();
        }

        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvFind.CopyToExcel(true);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            buttonFill_Click(sender, e);
        }
        #endregion

        #region dgvFind Events
        private void dgvFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.None)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvFind.CurrentRow != null)
                    {
                        selectedAbonent = Convert.ToInt32(dgvFind.CurrentRow.Cells["codeAbonentDgvTxtColumn"].Value);
                        selectedTypeAbn = Convert.ToInt32(dgvFind.CurrentRow.Cells["typeAbnDgvTxtColumn"].Value);
                        selectedObj = Convert.ToInt32(dgvFind.CurrentRow.Cells["Objid"].Value);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void dgvFind_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvFind.CurrentRow != null)
            {
                selectedAbonent = Convert.ToInt32(dgvFind.CurrentRow.Cells["codeAbonentDgvTxtColumn"].Value);
                selectedTypeAbn = Convert.ToInt32(dgvFind.CurrentRow.Cells["typeAbnDgvTxtColumn"].Value);
                selectedObj = Convert.ToInt32(dgvFind.CurrentRow.Cells["Objid"].Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvFind_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!Convert.ToBoolean(dgvFind["isActiveDataGridViewCheckBoxColumn", e.RowIndex].Value))
                {
                    e.CellStyle.BackColor = Color.LightYellow;
                }
                if (Convert.ToBoolean(dgvFind["deletedDataGridViewCheckBoxColumn", e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        private void txtHouse_Enter(object sender, EventArgs e)
        {
            txtHouse.SelectAll();
        }
    }
}
