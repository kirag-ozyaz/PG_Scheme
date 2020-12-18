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
    public partial class FormJPlomb : FormLbr.FormBase
    {
        #region FormJPlomb Events
        public FormJPlomb()
        {
            InitializeComponent();

            dateTimePickerBeg.Value = new DateTime(System.DateTime.Now.Year, 1, 1);
            dateTimePickerEnd.Value = new DateTime(System.DateTime.Now.Year, 12, 31);
        }
        private void FormJPlomb_Load(object sender, EventArgs e)
        {
            LoadPlombbStatus(dateTimePickerBeg.Value.Date, dateTimePickerEnd.Value.Date);
            LoadTreeMasters(null);
            LoadTreeTypePlomb(null);
        }
        #endregion

        private void LoadPlombbStatus(DateTime dBeg, DateTime dEnd)
        {
            this.SelectSqlData(dsPlomb, dsPlomb.vPlombStatus, true, " where DateInst >= '" + dBeg.ToString("yyyyMMdd") + "' " +
                " and Dateinst <= '" + dEnd.ToString("yyyyMMdd") + "'" + 
                " order by worker, seria, numberstring ");

            this.SelectSqlData(dsPlomb, dsPlomb.vPlomb, true, " order by idActPlomb");
        }

        #region LoadTrees
        // мастера
        private void LoadTreeMasters(TreeNode selNode)
        {
            treeViewMasters.Nodes.Clear();
            DataSets.DataSetPlomb ds = new Prv.DataSets.DataSetPlomb();
            this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';GroupWorker;MasterPlomber;' " + 
                "and isGroup = 1 and deleted = 0");
            if (ds.tR_Classifier.Rows.Count <= 0) return;
            TreeNode root = new TreeNode(ds.tR_Classifier.Rows[0]["Name"].ToString());
            root.Tag = "All";
            treeViewMasters.Nodes.Add(root);

            if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(root.Tag)))
            {   // выделяем элемент, если надо
                treeViewMasters.SelectedNode = root;
                treeViewMasters.SelectedNode.Expand();
            }
            // группы мастеров
            string delete = (toolBtnShowDel.Checked) ? "" : " and deleted = 0 ";
            this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';GroupWorker;MasterPlomber;' " + 
                "and isGroup = 0 " + delete + " order by name");

            foreach (DataRow dr in ds.tR_Classifier.Rows)
            {
                TreeNode nodeGroup = new TreeNode();
                nodeGroup.Text = dr["Name"].ToString();
                nodeGroup.Tag = "Group" + dr["Id"].ToString();
                if (Convert.ToBoolean(dr["Deleted"])) nodeGroup.ForeColor = Color.Red;
                root.Nodes.Add(nodeGroup);

                if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeGroup.Tag)))
                {   // выделяем элемент, если надо
                    treeViewMasters.SelectedNode = nodeGroup;
                    treeViewMasters.SelectedNode.Expand();
                }
                delete = (toolBtnShowDel.Checked) ? "" : " and DateEnd is null ";
                this.SelectSqlData(ds, ds.vWorkerGroup, true, " where idGRoup = " + GetIdFromNodeTag(nodeGroup.Tag).ToString() +
                    delete + " order by fio");
                foreach (DataRow drMaster in ds.vWorkerGroup.Rows)
                {
                    TreeNode nodeMaster = new TreeNode();
                    nodeMaster.Text = drMaster["FIO"].ToString();
                    nodeMaster.Tag = "Master" + drMaster["id"].ToString();
                    if (drMaster["DateEnd"] != DBNull.Value) nodeMaster.ForeColor = Color.Red;
                    nodeGroup.Nodes.Add(nodeMaster);
                    if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeMaster.Tag)))
                    {   // выделяем элемент, если надо
                        treeViewMasters.SelectedNode = nodeMaster;
                        treeViewMasters.SelectedNode.Expand();
                    }
                }
            }
            treeViewMasters.ExpandAll();
        }
        // типы пломб
        private void LoadTreeTypePlomb(TreeNode selNode)
        {
            treeViewTypePlomb.Nodes.Clear();
            DataSets.DataSetPlomb ds = new Prv.DataSets.DataSetPlomb();
            this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';SKUEE;Plomb;TypePlomb;' " +
                "and isGroup = 1 and deleted = 0");
            if (ds.tR_Classifier.Rows.Count <= 0) return;
            TreeNode root = new TreeNode(ds.tR_Classifier.Rows[0]["Name"].ToString());
            treeViewTypePlomb.Nodes.Add(root);
            treeViewTypePlomb.SelectedNode = treeViewTypePlomb.Nodes[0];
            

            string delete = (toolBtnShowDel.Checked) ? "" : " and deleted = 0 ";
            this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';SKUEE;Plomb;TypePlomb;' " +
                "and isGroup = 0 " + delete + " order by name");

            foreach (DataRow dr in ds.tR_Classifier.Rows)
            {
                TreeNode node = new TreeNode();
                node.Text = dr["Name"].ToString();
                node.Tag = dr["Id"];
                if (Convert.ToBoolean(dr["Deleted"])) node.ForeColor = Color.Red;
                root.Nodes.Add(node);

                if ((selNode != null) && (Convert.ToInt32(selNode.Tag) == Convert.ToInt32(node.Tag)))
                {   // выделяем элемент, если надо
                    treeViewTypePlomb.SelectedNode = node;
                    treeViewTypePlomb.SelectedNode.Expand();
                }
            }
            treeViewTypePlomb.ExpandAll();
        }

        // Возвращает Id из ветки
        private int GetIdFromNodeTag(Object tag)
        {
            string stTag = tag.ToString();

            if (stTag.IndexOf("All") >= 0) // all
                return -1;
            if (stTag.IndexOf("Group") >= 0) // ветка group
                return Convert.ToInt32(stTag.Substring(5));
            if (stTag.IndexOf("Master") >= 0) // ветка master
                return Convert.ToInt32(stTag.Substring(6));

            return -1;
        }
        #endregion

        #region toolstripMain
        // показать/скрыть удаленных
        private void toolBtnShowDel_Click(object sender, EventArgs e)
        {
            LoadTreeMasters(treeViewMasters.SelectedNode);
        }
        // выдача пломб
        private void toolBtnPlombAdd_Click(object sender, EventArgs e)
        {
            int idWorker = (treeViewMasters.SelectedNode.Level == 2) ?
                GetIdFromNodeTag(treeViewMasters.SelectedNode.Tag) : -1;
            FormPlombAdd fAdd = new FormPlombAdd(idWorker, -1);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                LoadPlombbStatus(dateTimePickerBeg.Value.Date, dateTimePickerEnd.Value.Date);
            }
        }
        // редактирование пломбы
        private void toolBtnPlombEdit_Click(object sender, EventArgs e)
        {
            if (dgvPlomb.CurrentRow != null)
            {
                if (dgvPlomb.CurrentRow.Cells["statusPlombDgvTxtColumn"].Value.ToString() == checkBoxFree.Text)
                {
                    int idWorker = Convert.ToInt32(dgvPlomb.CurrentRow.Cells["idWorkerDgvTxtColumn"].Value);
                    int idPlomb = Convert.ToInt32(dgvPlomb.CurrentRow.Cells["iDDgvTxtColumn"].Value);

                    FormPlombAdd fEdit = new FormPlombAdd(idWorker, idPlomb);
                    fEdit.SqlSettings = this.SqlSettings;
                    if (fEdit.ShowDialog() == DialogResult.OK)
                    {
                        LoadPlombbStatus(dateTimePickerBeg.Value.Date, dateTimePickerEnd.Value.Date);
                    }
                }
                else
                {
                    MessageBox.Show("Можно редактировать только свободную пломбу");
                }
            }
        }
        // Уничтожить/списать пломбу
        private void toolMenuItemPlombCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранные пломбы?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool isDel = false;
                foreach (DataGridViewRow r in dgvPlomb.SelectedRows)
                {
                    if (r.Cells[statusPlombDgvTxtColumn.Name].Value.ToString() == checkBoxFree.Text)
                    {
                        DataSets.DataSetPlomb ds = new Prv.DataSets.DataSetPlomb();
                        //INSERT
                        DataRow newRow = ds.tPlomb.NewRow();
                        newRow["typePlomb"] = r.Cells[typePlombDgwTxtColumn.Name].Value;
                        newRow["idActPlomb"] = (int)ActPlomb.Destruction;
                        newRow["idWorker"] = r.Cells[idWorkerDgvTxtColumn.Name].Value;
                        newRow["Seria"] = r.Cells[seriaDgvTxtColumn.Name].Value;
                        int outNumb = 0;
                        if (int.TryParse(r.Cells[numberstringDgvTxtColumn.Name].Value.ToString(), out outNumb))
                            newRow["number"] = outNumb;
                        else
                            newRow["Number"] = r.Cells[numberstringDgvTxtColumn.Name].Value;
                        newRow["DigitNumber"] = r.Cells[digitNumberDgvTxtColumn.Name].Value;
                        newRow["Date"] = DateTime.Now.Date;
                        newRow["DateInst"] = DateTime.Now.Date;
                        ds.tPlomb.Rows.Add(newRow);
                        if (this.InsertSqlData(ds, ds.tPlomb))
                            isDel = true;
                    }
                }
                if (isDel)
                {
                    LoadPlombbStatus(dateTimePickerBeg.Value.Date, dateTimePickerEnd.Value.Date);
                    MessageBox.Show("Пломбы успешно удалены");
                }
            }
        }
        // Удалить пломбу из БД
        private void toolMenuItemPlombDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранные пломбы?", "Удаление", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool isDel = false;
                foreach (DataGridViewRow r in dgvPlomb.SelectedRows)
                {
                    if ((r.Cells[statusPlombDgvTxtColumn.Name].Value.ToString() == checkBoxFree.Text) ||
                       (r.Cells[statusPlombDgvTxtColumn.Name].Value.ToString() == checkBoxDel.Text))
                    {
                        if (this.DeleteSqlDataById(new Prv.DataSets.DataSetPlomb().tPlomb,
                                Convert.ToInt32(r.Cells[iDDgvTxtColumn.Name].Value)))
                                isDel = true;
                    }  
                }
                if (isDel)
                {
                    LoadPlombbStatus(dateTimePickerBeg.Value.Date, dateTimePickerEnd.Value.Date);
                    MessageBox.Show("Пломбы успешно удалены");
                }
            }
        }

        // поиск сначала
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            dgvPlomb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Begin, toolStripTextBoxGrid.Text);
        }
        private void toolStripTextBoxGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvPlomb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxGrid.Text);
        }
        // поиск назад
        private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
        {
            dgvPlomb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Prev, toolStripTextBoxGrid.Text);
        }
        // поиск вперед
        private void toolStripButtonFindNext_Click(object sender, EventArgs e)
        {
            dgvPlomb.SearchGrid(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind.Next, toolStripTextBoxGrid.Text);
        }
        // печать
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            dgvPlomb.PrintDataGridView();
        }
        // экспорт в excel
        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            dgvPlomb.CopyToExcel(true);
        }
        // обновить
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadPlombbStatus(dateTimePickerBeg.Value.Date, dateTimePickerEnd.Value.Date);
        }
        #endregion

        // выбор мастера или группы
        private void treeViewMasters_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshFilter();
        }
        // выбор типа пломбы
        private void treeViewTypePlomb_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshFilter();
        }
        // статус пломбы
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshFilter();
        }

        private void RefreshFilter()
        {
            string filter = "";

            if (treeViewMasters.SelectedNode != null)
            {
                switch (treeViewMasters.SelectedNode.Level)
                {
                    case 0: // Все мастера
                        break;
                    case 1: // группа мастеров
                        int idGroup = GetIdFromNodeTag(treeViewMasters.SelectedNode.Tag);
                        DataSets.DataSetPlomb ds = new Prv.DataSets.DataSetPlomb();
                        string delete = (toolBtnShowDel.Checked) ? "" : " and DateEnd is null";
                        this.SelectSqlData(ds, ds.vWorkerGroup, true, " where idGroup = " + idGroup.ToString() + delete);
                        string tmp = "";
                        foreach (DataRow dr in ds.vWorkerGroup.Rows)
                        {
                            tmp += dr["id"].ToString() + ",";
                        }
                        if (!string.IsNullOrEmpty(tmp))
                        {
                            tmp = tmp.Remove(tmp.Length - 1);
                            filter = "idWorker in (" + tmp + ") ";
                        }
                        break;
                    case 2: // отдельный мастер
                        int idMaster = GetIdFromNodeTag(treeViewMasters.SelectedNode.Tag);
                        filter = "idWorker = " + idMaster.ToString() + " ";
                        break;
                }
            }

            
            // тип пломбы
            if (treeViewTypePlomb.SelectedNode != null)
            {
                if (treeViewTypePlomb.SelectedNode != treeViewTypePlomb.Nodes[0])
                {
                    if (string.IsNullOrEmpty(filter))
                        filter = " typePlomb = " + Convert.ToInt32(treeViewTypePlomb.SelectedNode.Tag);
                    else
                        filter += " and typePlomb = " + Convert.ToInt32(treeViewTypePlomb.SelectedNode.Tag);
                }
            }

            // статус
            string filterStatus = "";
            if (checkBoxFree.Checked) filterStatus = "(StatusPlomb = '" + checkBoxFree.Text + "'";

            if (checkBoxUst.Checked) // установлена
                if (String.IsNullOrEmpty(filterStatus))
                    filterStatus = "(StatusPlomb = '" + checkBoxUst.Text + "'";
                else
                    filterStatus += " or StatusPlomb = '" + checkBoxUst.Text + "'";
            
            if (checkBoxDel.Checked)
                if (String.IsNullOrEmpty(filterStatus))
                    filterStatus = "(StatusPlomb = '" + checkBoxDel.Text + "'";
                else
                    filterStatus += " or StatusPlomb = '" + checkBoxDel.Text + "'";

            if (checkBoxDem.Checked)
                if (String.IsNullOrEmpty(filterStatus))
                    filterStatus = "(StatusPlomb = '" + checkBoxDem.Text + "'";
                else
                    filterStatus += " or StatusPlomb = '" + checkBoxDem.Text + "'";
            if (!String.IsNullOrEmpty(filterStatus)) filterStatus += ")";

            if ((!checkBoxFree.Checked) && (!checkBoxDel.Checked) && (!checkBoxUst.Checked) && (!checkBoxDem.Checked))
                filterStatus = "StatusPlomb is null";

            if (string.IsNullOrEmpty(filter))
                filter = filterStatus;
            else
                filter += " and " + filterStatus;

            bindingSourcePlombStatus.Filter = filter;
        }
        //Смена дат 
        private void buttonApply_Click(object sender, EventArgs e)
        {
            LoadPlombbStatus(dateTimePickerBeg.Value.Date, dateTimePickerEnd.Value.Date);
        }

        #region dgvPlomb Evetns
        private void dgvPlomb_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvPlomb.RowCount > 0) && (e.RowIndex >= 0))
            {
                if (dgvPlomb["statusPlombDgvTxtColumn", e.RowIndex].Value.ToString() == checkBoxDel.Text)
                {
                    e.CellStyle.ForeColor = checkBoxDel.ForeColor;
                }

                if (dgvPlomb["statusPlombDgvTxtColumn", e.RowIndex].Value.ToString() == checkBoxUst.Text)
                {
                    e.CellStyle.ForeColor = checkBoxUst.ForeColor;
                }

                if (dgvPlomb["statusPlombDgvTxtColumn", e.RowIndex].Value.ToString() == checkBoxDem.Text)
                {
                    e.CellStyle.ForeColor = checkBoxDem.ForeColor;
                }
            }
        }
        #endregion

        #region dgvHistory
        private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvHistory.Columns[e.ColumnIndex].Name == "codeAbonentDgvTxtColumn") // если код абонента
                    if (dgvHistory[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                    {
                        int codeAbn = (int)dgvHistory[e.ColumnIndex, e.RowIndex].Value;
                        Prv.Forms.Abonent.FormAbonent f =  new Prv.Forms.Abonent.FormAbonent(codeAbn, Constants.Constants.TypeAbnPrivate);
                        f.SqlSettings = this.SqlSettings;
                        f.MdiParent = this.MdiParent;
                        f.Show();
                    }
            }
        }
        #endregion










    }
}
