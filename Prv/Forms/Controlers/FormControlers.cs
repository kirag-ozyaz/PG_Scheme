using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Prv.Forms.Controlers
{
    public partial class FormControlers : FormLbr.FormBase
    {
        class ItemHouse
        {
            public string Name { get; set; }
            public int    Id   { get; set; }

            public ItemHouse()
            {
            }

            public ItemHouse(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public FormControlers()
        {
            InitializeComponent();
        }
        // загрузка формы
        private void FormControlers_Load(object sender, EventArgs e)
        {
            // загрузка областей
            this.SelectSqlData(dsObl, dsObl.Tables["tR_KladrObj"], true,
                " where [Level] = 1 and deleted = 0 order by name, socr");

            cmbObl.SelectedIndex = cmbObl.FindString("Ульяновская обл");
            // загрузка районов/городов
            if (cmbObl.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsRaionObl, dsRaionObl.Tables["tR_kladrObj"], true,
                    " where ParentId = " + cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
                cmbRaionObl.Text = "Ульяновск г";
            }

            // загрука тиов домов
            DataTable dtClassifier =  this.SelectSqlData("tR_Classifier", true, " where ParentKey = ';HouseParam;HouseType;' " +
                " and isGroup = 0 and deleted = 0 order by name");
            cmbHouseType.Items.Add(new ItemHouse("Все", -1));
            foreach (DataRow dr in dtClassifier.Rows)
                cmbHouseType.Items.Add(new ItemHouse(dr["Name"].ToString(), Convert.ToInt32(dr["Id"])));
            cmbHouseType.Items.Add(new ItemHouse("абонентов <=6", 6));
            cmbHouseType.Items.Add(new ItemHouse("Отдельные дома", 0));


            // загрузка контролеров
            this.SelectSqlData(dsControlerArea, dsControlerArea.Tables["vWorkerGroup"], true,
                " where DateEnd is null and idgroup = " + Constants.Constants.WorkerGroupControlerBS.ToString() +
                " order by fio ");
            cmbControler.SelectedIndex = -1;


            // Загрузка участков контролеров
            this.SelectSqlData(dsControlerArea, dsControlerArea.Tables["vPrv_ControlerArea"], true,
                " order by Worker, KladrObj, Street, House, HousePrefix");
        }

        #region comboBox Events
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
            }
        }
        // смена района/города области
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
                cmbCity.SelectedIndex = -1;

                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true,
                    " where KladrObjId = " + cmbRaionObl.SelectedValue + " and deleted = 0 order by name, socr ");
                cmbStreet.SelectedIndex = -1;
            }

        }
        // смена нас пункта
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true,
                    " where KladrObjId = " + cmbCity.SelectedValue + " and deleted = 0 order by name, socr ");
                cmbStreet.SelectedIndex = -1;
            }
        }
        // смена улицы
        private void cmbStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxHouse.Items.Clear();

            if (cmbStreet.SelectedIndex >= 0)
            {
                this.SelectSqlData(dsControlerArea.Tables["tMapObj"], true,
                    " left join tAbnObj obj on tMapObj.idMap = obj.idMap " +
                    " left join tAbn abn on abn.id = obj.idabn and abn.typeAbn = " + Constants.Constants.TypeAbnPrivate.ToString() +
                    " where not abn.id is null and tMapObj.Street = " + cmbStreet.SelectedValue.ToString() + 
                    " order by house, houseprefix", null, true);

                foreach (DataRow dataRow in dsControlerArea.Tables["tMapObj"].Rows)
                {
                    listBoxHouse.Items.Add(new ItemHouse(dataRow["House"].ToString() + dataRow["HousePrefix"].ToString(), 
                        Convert.ToInt32(dataRow["IdMap"])));
                }
            }
        }
        // тип дома
        private void cmbHouseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHouseType.SelectedIndex == (cmbHouseType.Items.Count - 1))
                listBoxHouse.Enabled = true;
            else
                listBoxHouse.Enabled = false;
        }
        #endregion

        // загрузка участков (либо по улицам либо по домаом)
        private void radioButtonGroupStreet_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            if (radioButtonGroupStreet.Checked)
            {
                dgvControlers.Columns["houseAllDgvTxtColumn"].Visible = false;

                //ЗДЕСЬ ПОКА НИЧЕГО УМНЕЕ НЕ ПРИДУМАЛ
                DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                try
                {
                    sql.OpenConnection(this.SqlSettings);

                    string select = "select idWorker, worker, kladrobjid, kladrobj, idStreet, " + 
                        " street, null as house, null as houseprefix, null as houseall, sum(countcontroler) as CountControler, sum(countall) as CountAll " +
                        " from vPrv_ControlerArea " +
                        " group by idWorker, worker, kladrobjid, kladrobj, idStreet, street " +
                        " order by Worker, KladrObj, Street ";

                    dsControlerArea.Tables["vPrv_ControlerArea"].Clear();
                    System.Data.SqlClient.SqlDataAdapter dAdapt = new System.Data.SqlClient.SqlDataAdapter(select, sql.Connection);
                    dAdapt.Fill(dsControlerArea, "vPrv_ControlerArea");
                }
                catch (Exception ex) // Если ошибка
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {   // В любом случае коннект надо закрыть
                    sql.CloseConnection();
                }

            }
            else
            {
                dgvControlers.Columns["houseAllDgvTxtColumn"].Visible = true;
                this.SelectSqlData(dsControlerArea, dsControlerArea.Tables["vPrv_ControlerArea"], true,
                    " order by Worker, KladrObj, Street, House, HousePrefix");
            }
            this.Cursor = Cursors.Default;
        }
        // Фильтр по некорректным
        private void checkBoxIncorrect_CheckedChanged(object sender, EventArgs e)
        {
            string newfilter = " (countControler <> countAll or Worker is null) ";
            if (checkBoxIncorrect.Checked)
            {
                if (String.IsNullOrEmpty(bindingSource.Filter))
                    bindingSource.Filter = newfilter;
                else
                    bindingSource.Filter += " AND " + newfilter;
            }
            else
            {
                string currentfilter = bindingSource.Filter;
                if (String.IsNullOrEmpty(currentfilter))
                    return;

                if (currentfilter.IndexOf(newfilter) > 0)
                {
                    currentfilter = currentfilter.Replace(" AND " + newfilter, String.Empty);
                }
                else
                {
                    if (currentfilter.Length > newfilter.Length)
                    {
                        currentfilter = currentfilter.Replace(newfilter + " AND ", String.Empty);
                    }
                    else
                    {
                        currentfilter = "";
                    }
                }
                bindingSource.Filter = currentfilter;
            }
        }


        #region dgvControlers Evetns
        private void dgvControlers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (((int)dgvControlers["countControlerDgvTxtColumn", e.RowIndex].Value !=
                    (int)dgvControlers["countAllDgvTxtColumn", e.RowIndex].Value) ||
                    (dgvControlers["workerDgvTxtColumn", e.RowIndex].Value == DBNull.Value))
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void dgvControlers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                toolMenuItemOpen.Text = "Открыть " +
                    dgvControlers.CurrentRow.Cells["streetDataGrvTxtColumn"].Value.ToString();
                if (!String.IsNullOrEmpty(dgvControlers.CurrentRow.Cells["houseAllDgvTxtColumn"].Value.ToString()))
                    toolMenuItemOpen.Text += " д." +
                        dgvControlers.CurrentRow.Cells["houseAllDgvTxtColumn"].Value.ToString();
                this.contextMenuControlers.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        #endregion

        #region toolStripMain Events
        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvControlers.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxFind.Text);
        }
        // поиск след
        private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvControlers.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // поиск предыдущего
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvControlers.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxFind.Text);
        }
        // поиск следующего
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvControlers.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxFind.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvControlers.PrintDataGridView();
        }
        // экспорт в Excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvControlers.CopyToExcel(true);
        }
        // Обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            radioButtonGroupStreet_CheckedChanged(sender, e);
        }
        #endregion

        #region contextMenuControlers

        private void toolMenuItemOpen_Click(object sender, EventArgs e)
        {
            FormAreaAbonents fAbn = new FormAreaAbonents(
                (int)dgvControlers.CurrentRow.Cells["idStreetDataGridViewTextBoxColumn"].Value,
                dgvControlers.CurrentRow.Cells["houseDataGridViewTextBoxColumn"].Value, 
                dgvControlers.CurrentRow.Cells["housePrefixDataGridViewTextBoxColumn"].Value);
            fAbn.SqlSettings = this.SqlSettings;
            fAbn.MdiParent = this.MdiParent;
            fAbn.Show();
        }
        // копировать
        private void toolMenuItemCopy_Click(object sender, EventArgs e)
        {
            dgvControlers.CopyToBuffer(false);
        }
        // экспорт
        private void toolMenuItemExcel_Click(object sender, EventArgs e)
        {
            dgvControlers.CopyToExcel(false);
        }
        // печать
        private void еoolMenuItemPrint_Click(object sender, EventArgs e)
        {
            dgvControlers.PrintDataGridView();
        }
        #endregion

        // Обновить
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateControlerArea())
                radioButtonGroupStreet_CheckedChanged(sender, e);
        }

        private bool UpdateControlerArea()
        {
           DialogResult dialogResult = MessageBox.Show("Изменить контролера?", "Изменить", MessageBoxButtons.YesNo);
           if (dialogResult == DialogResult.Yes)
           {
               if (cmbControler.SelectedIndex < 0)
               {
                   MessageBox.Show("Не выбран контролер");
                   return false;
               }

               if (cmbHouseType.SelectedIndex >= 0)
               {
                   if (cmbStreet.SelectedIndex < 0)        //выбрана ли улица?
                   {
                       MessageBox.Show("Не выбрана улица");
                       return false;
                   }

                   DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                   try
                   {
                       sql.OpenConnection(this.SqlSettings);

                       string update = "";
                       switch (((ItemHouse)cmbHouseType.SelectedItem).Id)
                       {
                           case -1: // Все дома на улице
                               update = " update tAbn " +
                                        " set idWorker = " + cmbControler.SelectedValue.ToString() +
                                        " where typeAbn = 206 and " +
                                        " id in (select idAbn from TAbnObj " +
                                        " where idMap in (select idMap from tMapObj where street = " +
                                        cmbStreet.SelectedValue.ToString() + " )) ";
                               break;
                           case 0:  // Отдельные дома
                               if (listBoxHouse.SelectedItems.Count <= 0)
                               {
                                   MessageBox.Show("Не выбраны дома");
                                   return false;
                               }
                               string idMap = "";
                               foreach (ItemHouse item in listBoxHouse.SelectedItems)
                                   idMap += item.Id.ToString() + ",";
                               update = " update tAbn " +
                                        " set idWorker = " + cmbControler.SelectedValue.ToString() +
                                        " where typeAbn = 206 and " +
                                        " id in (select idAbn from TAbnObj " +
                                        " where idMap in (" + idMap.Remove(idMap.Length - 1) + " )) ";
                               break;
                           case 6: //квартир <= 6
                               update = " update tAbn " +
                                        " set idWorker = " + cmbControler.SelectedValue.ToString() +
                                        " where typeAbn = 206 and " +
                                        " id in (select idAbn from TAbnObj " +
                                        " where idMap in (select mo.idMap  " +
                                                           " from tMapObj mo  " +
                                                           " left join (select idMap,count(*) [Apps] " +
                                                           " 		   from tAbn abn " +
                                                           " 		   left join tAbnObj obj on obj.idAbn = abn.id " +
                                                           " 		   where TypeAbn = 206 " +
                                                           " 		   group by idMap) CApp on CApp.idMap = mo.idmap " +
                                                           " where CApp.Apps <= 6 and mo.street = " +
                                                                     cmbStreet.SelectedValue.ToString() + " )) ";
                               break;
                           default: // по типу
                               update = " update tAbn " +
                                        " set idWorker = " + cmbControler.SelectedValue.ToString() +
                                        " where typeAbn = 206 and " +
                                        " id in (select idAbn from TAbnObj " +
                                        " where idMap in (select idMap from tMapObj " +
                                                   " left join tMapObjParameter p on p.id = " +
                                                                   " (select top 1 id " +
                                                                   " from tMapObjParameter " +
                                                                   " where MapObjId = tMapObj.idmap " +
                                                                   " and typeObj = " + ((ItemHouse)cmbHouseType.SelectedItem).Id.ToString() +
                                                                   " order by DateBegin desc) " +
                                                                   " where not p.id is null and street = " +
                                                                     cmbStreet.SelectedValue.ToString() + " )) ";
                               break;
                       }
                       System.Data.SqlClient.SqlCommand sqlCom = new System.Data.SqlClient.SqlCommand(
                           update, sql.Connection);
                       int rows = sqlCom.ExecuteNonQuery();
                     
                       if (rows >= 0)
                           MessageBox.Show("Обновлено " + rows.ToString() + " записей ");
                       else
                           return false;
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message, ex.Source);
                       return false;
                   }
                   finally
                   {
                       sql.CloseConnection();
                   }
                   return true;
               }
               else
               {
                   MessageBox.Show("Не выбран тип дома");
                   return false;
               }
           }
           return false;
        }

        private void bView_Click(object sender, EventArgs e)
        {

            if (cmbHouseType.SelectedIndex >= 0)
            {
                if (cmbStreet.SelectedIndex < 0)        //выбрана ли улица?
                {
                    MessageBox.Show("Не выбрана улица");
                }

                DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                try
                {
                    sql.OpenConnection(this.SqlSettings);

                    string select = "";
                    switch (((ItemHouse)cmbHouseType.SelectedItem).Id)
                    {
                        case -1: // Все дома на улице
                            select = " where idMap in (select idMap from tMapObj where street = " +
                                     cmbStreet.SelectedValue.ToString() + " ) ";
                            break;
                        case 0:  // Отдельные дома
                            if (listBoxHouse.SelectedItems.Count <= 0)
                            {
                                MessageBox.Show("Не выбраны дома");

                            }
                            string idMap = "";
                            foreach (ItemHouse item in listBoxHouse.SelectedItems)
                                idMap += item.Id.ToString() + ",";
                            select =  " where idMap in (" + idMap.Remove(idMap.Length - 1) + " ) ";
                            break;
                        case 6: //квартир <= 6
                            select = " where idMap in (select mo.idMap  " +
                                                        " from tMapObj mo  " +
                                                        " left join (select idMap,count(*) [Apps] " +
                                                        " 		   from tAbn abn " +
                                                        " 		   left join tAbnObj obj on obj.idAbn = abn.id " +
                                                        " 		   where TypeAbn = 206 " +
                                                        " 		   group by idMap) CApp on CApp.idMap = mo.idmap " +
                                                        " where CApp.Apps <= 6 and mo.street = " +
                                                                  cmbStreet.SelectedValue.ToString() + " ) ";
                            break;
                        default: // по типу
                            select =  " where idMap in (select idMap from tMapObj " +
                                                " left join tMapObjParameter p on p.id = " +
                                                                " (select top 1 id " +
                                                                " from tMapObjParameter " +
                                                                " where MapObjId = tMapObj.idmap " +
                                                                " and typeObj = " + ((ItemHouse)cmbHouseType.SelectedItem).Id.ToString() +
                                                                " order by DateBegin desc) " +
                                                                " where not p.id is null and street = " +
                                                                  cmbStreet.SelectedValue.ToString() + " ) ";
                            break;
                    }
                    this.Cursor = Cursors.AppStarting;
                    if (radioButtonGroupStreet.Checked)
                    {

                        dgvControlers.Columns["houseAllDgvTxtColumn"].Visible = false;

                        //ЗДЕСЬ ПОКА НИЧЕГО УМНЕЕ НЕ ПРИДУМАЛ
                        try
                        {
                            sql.OpenConnection(this.SqlSettings);

                             select = "select idWorker, worker, kladrobjid, kladrobj, idStreet, " +
                                " street, null as house, null as houseprefix, null as houseall, sum(countcontroler) as CountControler, sum(countall) as CountAll " +
                                " from vPrv_ControlerArea " + select +
                                " group by idWorker, worker, kladrobjid, kladrobj, idStreet, street " +
                                " order by Worker, KladrObj, Street ";

                            dsControlerArea.Tables["vPrv_ControlerArea"].Clear();
                            System.Data.SqlClient.SqlDataAdapter dAdapt = new System.Data.SqlClient.SqlDataAdapter(select, sql.Connection);
                            dAdapt.Fill(dsControlerArea, "vPrv_ControlerArea");
                        }
                        catch (Exception ex) // Если ошибка
                        {
                            MessageBox.Show(ex.Message, ex.Source);
                        }
                        finally
                        {   // В любом случае коннект надо закрыть
                            sql.CloseConnection();
                        }

                    }
                    else
                    {
                        dgvControlers.Columns["houseAllDgvTxtColumn"].Visible = true;
                        this.SelectSqlData(dsControlerArea, dsControlerArea.Tables["vPrv_ControlerArea"], true,
                            select + " order by Worker, KladrObj, Street, House, HousePrefix");
                    }
                    this.Cursor = Cursors.Default;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);

                }
                finally
                {
                    sql.CloseConnection();
                }

            }
            else
            {
                MessageBox.Show("Не выбран тип дома");

            }
        }
    }
}
