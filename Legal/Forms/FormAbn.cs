using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Constants;
using Legal.Forms.ActCheck;
using System.IO;
using Documents.Forms.JournalCalcLoss;
using FormLbr.Classes;
using Legal.DataSet;
using System.Diagnostics;

namespace Legal.Forms
{
    public partial class FormAbn : FormLbr.FormBase
    {
        private int ID, idList;
        private int IDOBJSELECT;
        public int ABNSELECT;
        private int AbnFilter = 0;
        private int IDABNOBJ = 0;
        private int CodeAbnBeg = -1;
        private int idObjBeg = -1;


        public FormAbn()
        {
            InitializeComponent();
        }

        public FormAbn(int idAbn, int idAbnObj)
        {
            InitializeComponent();
            CodeAbnBeg = idAbn;
            idObjBeg = idAbnObj;
        }

        //позиционирование в гриде
        private int GetRowIndexByKey(DataGridView dgv, string columnName, int key)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (Convert.ToInt32(dr.Cells[columnName].Value) == key)
                    return dr.Index;
            }
            return 0;
        }

        private void FormAbn_Load(object sender, EventArgs e)
        {
            cmbContact.SelectedIndex = 0;

            LoadToolStripMenuCalcLoss();

            this.SelectSqlData(dsAbn, dsAbn.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");
            LoadAbonent();

            cmbObjActive.SelectedIndex = 0;
            cmbPoint_Active.SelectedIndex = 1;

            toolStripTextBoxAbnSearch.Focus();

            if (CodeAbnBeg > 0) // криво надо переделать
            {

                for (int i = 0; i < AbnMiniDGV.RowCount; i++)
                {
                    if (AbnMiniDGV[1, i].FormattedValue.ToString().
                        Contains(CodeAbnBeg.ToString().Trim()))
                    {
                        AbnMiniDGV.CurrentCell = AbnMiniDGV[1, i];
                        LoadAbonent();

                        if (idObjBeg > 0)
                        {
                            if (dGVEFObj.RowCount > 0)
                            {
                                for (int j = 0; j < dGVEFObj.RowCount; j++)
                                {
                                    if (dGVEFObj["idObj", j].FormattedValue.ToString().
                                    Contains(idObjBeg.ToString().Trim()))
                                    {
                                        dGVEFObj.CurrentCell = dGVEFObj["NameObj", j];
                                        LoadObj();
                                        return;
                                    }
                                }
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        break;
                    }
                }
            }
        
        }

        private void LoadAbonent()
        {
            if (AbnMiniDGV.CurrentRow == null) return;
            ID = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value); ;
            this.SelectSqlData(dsAbn.vG_Abn, true, " where id = " + ID.ToString());
            //Объекты
            if (cmbObjActive.SelectedIndex == 0)
               // this.SelectSqlData(dsAbn, dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " + ID.ToString() + " OR idAbnDog IS NULL) and DateEnd Is Null and idStatus != 243 and DocNumber Is Not Null order by NumberObj, NumberSubObj");
                    this.SelectSqlData(dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " + 
                    ID.ToString() + " OR idAbnDog IS NULL) and DateEnd Is Null and DocNumber Is Not Null order by NumberObj, NumberSubObj");
            else
                this.SelectSqlData(dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " + ID.ToString() + " OR idAbnDog IS NULL) order by NumberObj, NumberSubObj");
            // реквизиты
            this.SelectSqlData(dsAbn.vG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc, id desc", null, false, 1);
            // руководитель
            this.SelectSqlData(dsAbn.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            //адреса
            this.SelectSqlData(dsAbn.vG_AbnAddressL, true, " where idAbn = " + ID.ToString() + " order by DateChange desc, id desc", null, false, 1);
            this.SelectSqlData(dsAbn.vG_AbnAddressP, true, " where idAbn = " + ID.ToString() + " order by DateChange desc, id desc", null, false, 1);
            //контакты
            //LoadContact();
            //Документы
            this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + ID.ToString() + " order by DocDate desc");
            //Файлы
            SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and ParentID = 0 and idAbn = " + ID.ToString() + " order by IsGroup desc,ParentId asc ");
            inFolder = 0;
            // ОДС
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnNameODS, true, " where idAbn = " + ID.ToString());


            tSTBController.Text = Convert.ToString(dsAbn.vG_Abn.Rows[0]["Famil"]);
            tSTBActive.Text = Convert.ToString(dsAbn.vG_Abn.Rows[0]["Status"]);
            tSTBDogovor.Text = Convert.ToString(dsAbn.vG_Abn.Rows[0]["TypeDog"]);
            tSTBTypeAbn.Text = Convert.ToString(dsAbn.vG_Abn.Rows[0]["TypeName"]);

            //Объекты

            if (dGVEFObj.RowCount > 0) LoadObj();
            else
            {
                IDOBJSELECT = -1;
                LoadContact();

                dsAbn.vG_AbnObj.Clear();
                MastertSTB.Text = "";
                tlSLObjCount.Text = "0";
                ObjDogovorSTB.Text = "";
                dsAbn.vG_SchetAll.Clear();

                ClearFieldObject();
            }
        }

        // загрузка реквизитов объектов
        private void LoadObj()
        {
            ClearFieldObject();

            IDOBJSELECT = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);
            
            LoadContact();

            this.SelectSqlData(dsAbn.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll 
                                                             + ") and id = " + IDOBJSELECT.ToString(), null, false, 1);
            //Адрес объекта
            this.SelectSqlData(dsAbn.vAbnObjAddress, true, " where id = " + IDOBJSELECT.ToString(), null, false, 1);
            //Количество объектов
            tlSLObjCount.Text = dGVEFObj.RowCount.ToString();
            //Мастер объекта
            MastertSTB.Text = Convert.ToString(dsAbn.vG_AbnObj.Rows[0]["Master"]);
            //Статус объекта
            // tSTBStatusName.Text = Convert.ToString(dsAbn.vG_AbnObj.Rows[0]["StatusName"]);
            //Тариф
            ObjTariffSTB.Text = Convert.ToString(dsAbn.vG_AbnObj.Rows[0]["TarifName"]);
            //ТП
            TP_STB.Text = Convert.ToString(dsAbn.vG_AbnObj.Rows[0]["Name_Group"]);
            //Категория
            ObjCategorySTB.Text = Convert.ToString(dsAbn.vG_AbnObj.Rows[0]["CategoryName"]);
            //Номер договора
            ObjDogNumberSTB.Text = Convert.ToString(dGVEFObj.CurrentRow.Cells["DocNumber"].Value);
            //Тип договора
            ObjDogovorSTB.Text = Convert.ToString(dGVEFObj.CurrentRow.Cells["DocName"].Value);
            //Счетчики
            LoadObjMeters();
            //Начисления
            this.SelectSqlData(dsAbn, dsAbn.vG_SchetAll, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " Order by dtCalc desc");
            //Документы объектов
            this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " Order by DocDate desc");
            //Заявленные объемы и мощности
            this.SelectSqlData(dsAbn, dsAbn.tG_ObjMax, true, " where ObjID = " + IDOBJSELECT.ToString() + " Order by Year desc");
            //Признаки
            this.SelectSqlData(dsAbn, dsAbn.vG_AbnObjFlags, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " Order by Name desc");
            if (dsAbn.vG_AbnObjFlags.Rows.Count > 0) this.SelectSqlData(dsAbn, dsAbn.tAbnObjFlags, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " Order by Date desc");
                else dsAbn.tAbnObjFlags.Clear();
            //Ограничения
            this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vG_LimitingConsumption, true, " where AbnObjID = " + IDOBJSELECT.ToString() + " Order by DateAction desc");
        }

        private void dGVEFAbonent_KeyUp(object sender, KeyEventArgs e)
        {
            LoadAbonent();
        }
        private void dGVEFAbonent_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
            {
                dGVEFObj.Focus();

            }
        }

        // Поиск
        private void toolStripTextBoxAbnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                AbnMiniDGV.Focus();
        }

        private void toolStripTextBoxAbnSearch_KeyUp(object sender, KeyEventArgs e)
        {

            for (int i = 0; i < AbnMiniDGV.RowCount; i++)
                if (AbnMiniDGV[1, i].FormattedValue.ToString().
                    Contains(toolStripTextBoxAbnSearch.Text.Trim()))
                {
                    AbnMiniDGV.CurrentCell = AbnMiniDGV[1, i];
                    return;
                }

        }

        #region Добавление абонента
        private void AddAbn()
        {
            FormAbnAddEdit fAdd = new FormAbnAddEdit(-1, true);
            fAdd.SqlSettings = this.SqlSettings;

            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");
                int id = int.Parse(fAdd.Prm);

                AbnMiniDGV.CurrentCell = AbnMiniDGV["codeAbonentDGVTBC", GetRowIndexByKey(AbnMiniDGV, "codeAbonentDGVTBC", id)];

            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddAbn();
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAbn();

        }
        #endregion

        #region Редактирование абонента
        private void EditAbn()
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnAddEdit fAdd = new FormAbnAddEdit(id, false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");
                AbnMiniDGV.CurrentCell = AbnMiniDGV["codeAbonentDGVTBC", GetRowIndexByKey(AbnMiniDGV, "AbnidDGVTBC", id)];
                LoadAbonent();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            EditAbn();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAbn();
        }
        #endregion

        // Расскраска грида абонента
        //private void dGVEFAbonent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        if (dGVEFAbonent.Rows[e.RowIndex].Cells[5].Value.ToString() == "передача")
        //            e.CellStyle.ForeColor = Color.Blue;

        //        if (dGVEFAbonent.Rows[e.RowIndex].Cells[5].Value.ToString() == "снабжение")
        //            e.CellStyle.ForeColor = Color.Green;

        //        if (dGVEFAbonent.Rows[e.RowIndex].Cells[5].Value.ToString() == "смешанный")
        //            e.CellStyle.BackColor = Color.LemonChiffon;

        //        if (dGVEFAbonent.Rows[e.RowIndex].Cells[5].Value.ToString() == "")
        //            e.CellStyle.BackColor = Color.WhiteSmoke;
        //        if (dGVEFAbonent.Rows[e.RowIndex].Cells["TypeName"].Value.ToString() == "Сетевая организация")
        //            e.CellStyle.BackColor = Color.PaleTurquoise;
        //        if (dGVEFAbonent.Rows[e.RowIndex].Cells["TypeName"].Value.ToString() == "Сбытовая организация")
        //            e.CellStyle.BackColor = Color.Wheat;


        //    }
        //}
        // Расскраска грида объекта

        private void dGVEFObj_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            if (dGVEFObj.Rows[e.RowIndex].Cells["DocNumber"].Value == DBNull.Value) 
                e.CellStyle.ForeColor = Color.Red;
        }

        #region Удаление абонента
        private void DelAbn()
        {
            if (MessageBox.Show("Вы действительно хотите удалить текущего контрагента?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
                int CA = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["codeAbonentDGVTBC"].Value);

                if (dsAbn.vG_Abn.Rows.Count > 0)
                {

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tAbn, true, "where id = " + id);
                    ds.tAbn.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tAbn.Rows[0]["Deleted"]);
                    ds.tAbn.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tAbn))
                    {
                        if (Convert.ToBoolean(ds.tAbn.Rows[0]["Deleted"]))
                        {
                            MessageBox.Show("Абонент успешно удален");
                            //    FindLS(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]), GoAbonent.Next, Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]), toolBtnShowDelAbn.Checked);
                        }
                        else
                        {
                            MessageBox.Show("Абонент успешно восстановлен");
                            //    FindLS(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]), GoAbonent.Current, Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]), toolBtnShowDelAbn.Checked);
                        }
                    }
                }
                this.SelectSqlData(dsAbn.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");

                dsAbn.tAbn.Clear();
                this.SelectSqlData(dsAbn.tAbn, true, "where deleted=0 and CodeAbonent >= " + CA + " order by CodeAbonent ", null, false, 1);
                CA = (int)dsAbn.tAbn.Rows[0]["CodeAbonent"];
                if (CA > 0)
                {
                    this.SelectSqlData(dsAbn.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");
                    // dGVEFAbonent.CurrentCell = dGVEFAbonent["dGVFTBColumnСodeAbonent", GetRowIndexByKey(dGVEFAbonent, "dGVFTBColumnСodeAbonent", CA)];
                    AbnMiniDGV.CurrentCell = AbnMiniDGV["codeAbonentDGVTBC", GetRowIndexByKey(AbnMiniDGV, "codeAbonentDGVTBC", CA)];
                }
                LoadAbonent();
            }
        }
        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            DelAbn();
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelAbn();
        }
        #endregion

        //новый статус абонента
        private void tSBStatus_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnStat fAdd = new FormAbnStat(id);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.Cancel)
            {
                LoadAbonent();
            }


        }

        #region Реквизиты
        //История реквизитов
        private void buttonAbnInfHistory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnDetailsHistory fAdd = new FormAbnDetailsHistory(id);
            fAdd.SqlSettings = this.SqlSettings;
            fAdd.MdiParent = this.MdiParent;
            fAdd.Show();
        }

        //Новые реквизиты
        private void buttonAbnInfNew_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnDetails fAdd = new FormAbnDetails(id, true);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn.vG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc, id desc", null, false, 1);
            }
        }
        //редактирование текущих реквизитов абонента
        private void buttonAbnInfoEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnDetails fAdd = new FormAbnDetails(id, false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn.vG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc, id desc", null, false, 1);
            }
        }
        #endregion

        #region Руководитель
        //История руководителя
        private void buttonDirectorHistory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnChiefHistory fAdd = new FormAbnChiefHistory(id);
            fAdd.SqlSettings = this.SqlSettings;
            fAdd.MdiParent = this.MdiParent;
            fAdd.Show();
            //if (fAdd.ShowDialog() == DialogResult.OK)
            //{
                //this.SelectSqlData(dsAbn, dsAbn.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
            //}
        }
        //Новый руководитель
        private void buttonDirectorNew_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnChief fAdd = new FormAbnChief(id, true);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            }
        }
        //Редактирование руководителя
        private void buttonDirectorEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnChief fAdd = new FormAbnChief(id, false);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", null, false, 1);
            }
        }
        #endregion

        #region Адреса
        private void buttonAddressHistory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbnAddressHistory frm = new FormAbnAddressHistory(id);
            frm.SqlSettings = this.SqlSettings;
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += new FormClosedEventHandler(FormAbnAddressHistory_FormClosed);
            frm.Show();
        }

        void FormAbnAddressHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SelectSqlData(dsAbn.vG_AbnAddressL, true, " where idAbn = " + ID.ToString() + " order by DateChange desc, id desc", null, false, 1);
            this.SelectSqlData(dsAbn.vG_AbnAddressP, true, " where idAbn = " + ID.ToString() + " order by DateChange desc, id desc", null, false, 1);
        }
        #endregion

        #region Работа с контактами
        private void toolStripButtonNewContact_Click(object sender, EventArgs e)
        {
            int Author = Constants.Constants.AuthorContact_CS;
            if (cmbContact.SelectedIndex == 4)
                Author = Constants.Constants.AuthorContact_ODS;
            FormAbnContactAdd fAdd = new FormAbnContactAdd(Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value), true, Author);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                LoadContact();
            }
        }

        private void toolStripButtonEditContac_Click(object sender, EventArgs e)
        {
            if (dGVAbnContact.CurrentRow != null)
            {
                FormAbnContactAdd fAdd = new FormAbnContactAdd(Convert.ToInt32(dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value), false);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    LoadContact();
                }
            }
        }

        private void toolStripButtonDelContact_Click(object sender, EventArgs e)
        {
            if (dGVAbnContact.CurrentRow != null)
            {
                if (MessageBox.Show("Хотите удалить контакт?", "Удаление",
                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteSqlDataById(dsAbn.tAbnContact, Convert.ToInt32(dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value));
                    LoadContact();
                }
            }
        }
        //Контекстное меню контактов
        private void dGVAbnContact_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && toolStripButtonNewContact.Visible == true) // если правой кнопкой
            {
                this.dGVAbnContact.Rows[e.RowIndex].Selected = true;
                ///-----------
                dGVAbnContact.CurrentCell = dGVAbnContact["postDataGridViewTextBoxColumn", e.RowIndex]; //делаем текущей
                this.contextMenuAbnContact.Show(System.Windows.Forms.Cursor.Position);
            }
        }



        #endregion

        #region Работа с документами
       private void tssbAbnDocEdit_ButtonClick(object sender, EventArgs e)
        {
            tssbAbnDocEdit.ShowDropDown();
        }



        //Внесение документа передачи
        private void DocPerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbnDoc_Dogovor fDog = new FormAbnDoc_Dogovor(Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value), -1, (int)Constants.DocType.Dogovor, true);

            fDog.SqlSettings = this.SqlSettings;
            if (fDog.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + ID.ToString() + " order by DocDate desc");
                int idDoc = int.Parse(fDog.Prm);
                dgvAbnDoc.CurrentCell = dgvAbnDoc["docNumberDGVTBC", GetRowIndexByKey(dgvAbnDoc, "docNumberDGVTBC", idDoc)];
                int AbnIndex = AbnMiniDGV.CurrentRow.Index;
                this.SelectSqlData(dsAbn, dsAbn.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");
                AbnMiniDGV.CurrentCell = AbnMiniDGV["codeAbonentDGVTBC", AbnIndex];
            }
        }
        //Внесение документа энергоснабжения
        private void DocEnergoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbnDoc_Dogovor fDog = new FormAbnDoc_Dogovor(Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value), -1, (int)Constants.DocType.DogovorEnergo, true);
            fDog.SqlSettings = this.SqlSettings;
            if (fDog.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + ID.ToString() + " order by DocDate desc");
                int idDoc = int.Parse(fDog.Prm);
                dgvAbnDoc.CurrentCell = dgvAbnDoc["docNumberDGVTBC", GetRowIndexByKey(dgvAbnDoc, "docNumberDGVTBC", idDoc)];
                int AbnIndex = AbnMiniDGV.CurrentRow.Index;
                this.SelectSqlData(dsAbn, dsAbn.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");
                AbnMiniDGV.CurrentCell = AbnMiniDGV["codeAbonentDGVTBC", AbnIndex];
            }
        }
        //Изменение документа
        private void tsbAbnDocEdit_Click(object sender, EventArgs e)
        {
            if (dgvAbnDoc.RowCount > 0)
            {
                int IDABN = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
                int idType = Convert.ToInt32(dgvAbnDoc.CurrentRow.Cells["idDocTypeDGVTBC"].Value);
                int IDLIST = Convert.ToInt32(dgvAbnDoc.CurrentRow.Cells["idDocDGVTBC"].Value);

                switch (idType)
                {
                    case (int)Constants.DocType.Dogovor:
                        FormAbnDoc_Dogovor fDog = new FormAbnDoc_Dogovor(IDABN, IDLIST, idType, false);
                        fDog.SqlSettings = this.SqlSettings;
                        if (fDog.ShowDialog() == DialogResult.OK)
                        {
                            int DocIndex = dgvAbnDoc.CurrentRow.Index;
                            this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + ID.ToString() + " order by DocDate desc");
                            dgvAbnDoc.CurrentCell = dgvAbnDoc["docNumberDGVTBC", DocIndex];
                        }
                        break;
                    case (int)Constants.DocType.DogovorEnergo:
                        FormAbnDoc_Dogovor fDogEnergo = new FormAbnDoc_Dogovor(IDABN, IDLIST, idType, false);
                        fDogEnergo.SqlSettings = this.SqlSettings;
                        if (fDogEnergo.ShowDialog() == DialogResult.OK)
                        {
                            int DocIndex = dgvAbnDoc.CurrentRow.Index;
                            this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + ID.ToString() + " order by DocDate desc");
                            dgvAbnDoc.CurrentCell = dgvAbnDoc["docNumberDGVTBC", DocIndex];
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        //Удаление документа
        private void tsbAbnDocDel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
                int idDoc = Convert.ToInt32(dgvAbnDoc.CurrentRow.Cells["idDocDGVTBC"].Value);
                int DocIndex = dgvAbnDoc.CurrentRow.Index;

                if (dsAbn.vAbnDoc_List.Count > 0)
                {

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tAbnDoc_List, true, "where id = " + idDoc);
                    ds.tAbnDoc_List.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tAbnDoc_List.Rows[0]["Deleted"]);
                    ds.tAbnDoc_List.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tAbnDoc_List))
                    {
                        if (Convert.ToBoolean(ds.tAbnDoc_List.Rows[0]["Deleted"]))
                        {
                            this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + ID.ToString() + " order by DocDate desc");

                            if (dgvAbnDoc.RowCount > DocIndex) dgvAbnDoc.CurrentCell = dgvAbnDoc["docNumberDGVTBC", DocIndex];

                            int AbnIndex = AbnMiniDGV.CurrentRow.Index;
                            this.SelectSqlData(dsAbn, dsAbn.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and Deleted=0 order by CodeAbonent  ");
                            AbnMiniDGV.CurrentCell = AbnMiniDGV["codeAbonentDGVTBC", AbnIndex];

                            MessageBox.Show("Документ успешно удален");
                            //    FindLS(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]), GoAbonent.Next, Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]), toolBtnShowDelAbn.Checked);
                        }
                        else
                        {
                            MessageBox.Show("Документ успешно восстановлен");
                            //    FindLS(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]), GoAbonent.Current, Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]), toolBtnShowDelAbn.Checked);
                        }
                    }
                }

            }

        }

        //Контекстное меню документов
        private void dgvAbnDoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && tssbAbnDocEdit.Visible == true) // если правой кнопкой
            {
                this.dgvAbnDoc.Rows[e.RowIndex].Selected = true;
                ///-----------
                dgvAbnDoc.CurrentCell = dgvAbnDoc["docNumberDGVTBC", e.RowIndex]; //делаем текущей
                this.contextMenuAbnDoc.Show(System.Windows.Forms.Cursor.Position);

            }
        }


        #endregion

        //Объекты

        // прикрепить объект к новому владельцу
        private void ObjAddtoolStripButton_Click(object sender, EventArgs e)
        {
            // выберем объекты без владельца для прикрепления
            FormObjSelect fSelect = new FormObjSelect(ID, 0, FormObjSelect.SelectionMethod.Many);
            fSelect.SqlSettings = this.SqlSettings;
            if (fSelect.ShowDialog() == DialogResult.OK)
            {
                if (fSelect.idObjPar > 0)
                {
                    // если выбран один объект
                    IDOBJSELECT = fSelect.idObjPar;
                    // меняем владельца объекта в tAbnObj
                    this.SelectSqlData(dsAbn, dsAbn.tAbnObj, true, " where id = " + IDOBJSELECT.ToString());
                    dsAbn.tAbnObj.Rows[0]["idAbn"] = ID;
                    dsAbn.tAbnObj.Rows[0].EndEdit();
                    UpdateSqlData(dsAbn, dsAbn.tAbnObj);

                    // записываем новые параметры объекта в tAbnObjReg
                    DataTable dt = dsAbn.tAbnObjReg;
                    this.SelectSqlData(dt, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DateChange desc", null, false, 1);
                    DataRow dr = dt.NewRow();
                    dr["idAbn"] = ID;
                    dr["DateChange"] = System.DateTime.Now.Date;
                    dr["idAbnObj"] = dt.Rows[0]["idAbnObj"];
                    dr["idAbnNet"] = dt.Rows[0]["idAbnNet"];
                    dr["idAbnSale"] = dt.Rows[0]["idAbnSale"];
                    dr["idStatus"] = dt.Rows[0]["idStatus"];
                    dr["Regime"] = dt.Rows[0]["Regime"];
                    dr["PowerSet"] = dt.Rows[0]["PowerSet"];
                    dr["PowerOther"] = dt.Rows[0]["PowerOther"];
                    dr["PowerFact"] = dt.Rows[0]["PowerFact"];
                    dr["KLoss"] = dt.Rows[0]["Kloss"];
                    dr["Category"] = dt.Rows[0]["Category"];
                    dr["Comment"] = dt.Rows[0]["Comment"];
                    dr["CommonType"] = dt.Rows[0]["CommonType"];
                    dr["CommonPercent"] = dt.Rows[0]["CommonPercent"];
                    dr["CommonValue"] = dt.Rows[0]["CommonValue"];
                    dr["CalcLoss"] = dt.Rows[0]["CalcLoss"];
                    dr["idTariff"] = dt.Rows[0]["idTariff"];
                    dr["NumberTP"] = dt.Rows[0]["NumberTP"];
                    dr["DateTP"] = dt.Rows[0]["DateTP"];
                    dr["NumberTU"] = dt.Rows[0]["NumberTU"];
                    dr["DateTU"] = dt.Rows[0]["DateTU"];
                    dr["DatePowerFact"] = dt.Rows[0]["DatePowerFact"];
                    dr["idAbnObjSame"] = dt.Rows[0]["idAbnObjSame"];
                    dr["SubNet"] = dt.Rows[0]["SubNet"];
                    dr["SubNetComment"] = dt.Rows[0]["SubNetComment"];

                    dsAbn.tAbnObjReg.Rows.Add(dr);

                    InsertSqlData(dsAbn, dt);
                }
                else
                {
                    // если выбрано несколько объектов
                    for (int i = 0; i < fSelect.idArray.Length; i++)
                    {
                        if (fSelect.idArray[i] > 0) // MessageBox.Show(fSelect.idArray[i].ToString());
                        {
                            IDOBJSELECT =fSelect.idArray[i];
                            
                            this.SelectSqlData(dsAbn, dsAbn.tAbnObj, true, " where id = " + IDOBJSELECT.ToString());
                            dsAbn.tAbnObj.Rows[0]["idAbn"] = ID;
                            dsAbn.tAbnObj.Rows[0].EndEdit();
                            UpdateSqlData(dsAbn, dsAbn.tAbnObj);

                            // записываем новые параметры объекта в tAbnObjReg
                            DataTable dt = dsAbn.tAbnObjReg;
                            this.SelectSqlData(dt, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DateChange desc", null, false, 1);
                            DataRow dr = dt.NewRow();
                            dr["idAbn"] = ID;
                            dr["DateChange"] = System.DateTime.Now.Date;
                            dr["idAbnObj"] = dt.Rows[0]["idAbnObj"];
                            dr["idAbnNet"] = dt.Rows[0]["idAbnNet"];
                            dr["idAbnSale"] = dt.Rows[0]["idAbnSale"];
                            dr["idStatus"] = dt.Rows[0]["idStatus"];
                            dr["Regime"] = dt.Rows[0]["Regime"];
                            dr["PowerSet"] = dt.Rows[0]["PowerSet"];
                            dr["PowerOther"] = dt.Rows[0]["PowerOther"];
                            dr["PowerFact"] = dt.Rows[0]["PowerFact"];
                            dr["KLoss"] = dt.Rows[0]["Kloss"];
                            dr["Category"] = dt.Rows[0]["Category"];
                            dr["Comment"] = dt.Rows[0]["Comment"];
                            dr["CommonType"] = dt.Rows[0]["CommonType"];
                            dr["CommonPercent"] = dt.Rows[0]["CommonPercent"];
                            dr["CommonValue"] = dt.Rows[0]["CommonValue"];
                            dr["CalcLoss"] = dt.Rows[0]["CalcLoss"];
                            dr["idTariff"] = dt.Rows[0]["idTariff"];
                            dr["NumberTP"] = dt.Rows[0]["NumberTP"];
                            dr["DateTP"] = dt.Rows[0]["DateTP"];
                            dr["NumberTU"] = dt.Rows[0]["NumberTU"];
                            dr["DateTU"] = dt.Rows[0]["DateTU"];
                            dr["DatePowerFact"] = dt.Rows[0]["DatePowerFact"];
                            dr["idAbnObjSame"] = dt.Rows[0]["idAbnObjSame"];
                            dr["SubNet"] = dt.Rows[0]["SubNet"];
                            dr["SubNetComment"] = dt.Rows[0]["SubNetComment"];

                            dsAbn.tAbnObjReg.Rows.Add(dr);

                            InsertSqlData(dsAbn, dt);
                        }
                    }

                }

                if (cmbObjActive.SelectedIndex == 0)
                    this.SelectSqlData(dsAbn, dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " + ID.ToString() + " OR idAbnDog IS NULL) and DateEnd Is Null and idStatus != 243 and DocNumber Is Not Null order by NumberObj, NumberSubObj");
                else
                    this.SelectSqlData(dsAbn, dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " + ID.ToString() + " OR idAbnDog IS NULL) order by NumberObj, NumberSubObj");


                if (dGVEFObj.RowCount > 0) LoadObj();
                else
                {
                    dsAbn.vG_AbnObj.Clear();
                    MastertSTB.Text = "";
                    tlSLObjCount.Text = "0";
                    ObjDogovorSTB.Text = "";
                    dsAbn.vG_SchetAll.Clear();
                }
            }

        }

        // открепить объект от владельца
        private void ObjDeltoolStripButton_Click(object sender, EventArgs e)
        {
            if (dGVEFObj.RowCount > 0)
            {
                if (MessageBox.Show("Открепить объект?", "Объект",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int IDOBJSELECT = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);
                    // удаляем владельца объекта в tAbnObj
                    this.SelectSqlData(dsAbn, dsAbn.tAbnObj, true, " where id = " + IDOBJSELECT.ToString());
                    dsAbn.tAbnObj.Rows[0]["idAbn"] = 220863;
                    dsAbn.tAbnObj.Rows[0].EndEdit();
                    UpdateSqlData(dsAbn, dsAbn.tAbnObj);

                    // записываем новые параметры объекта в tAbnObjReg
                    DataTable dt = dsAbn.tAbnObjReg;
                    this.SelectSqlData(dt, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DateChange desc", null, false, 1);
                    DataRow dr = dt.NewRow();
                    dr["idAbn"] = 0;
                    dr["DateChange"] = System.DateTime.Now.Date;
                    dr["idAbnObj"] = dt.Rows[0]["idAbnObj"];
                    dr["idAbnNet"] = dt.Rows[0]["idAbnNet"];
                    dr["idAbnSale"] = dt.Rows[0]["idAbnSale"];
                    dr["idStatus"] = dt.Rows[0]["idStatus"];
                    dr["Regime"] = dt.Rows[0]["Regime"];
                    dr["PowerSet"] = dt.Rows[0]["PowerSet"];
                    dr["PowerOther"] = dt.Rows[0]["PowerOther"];
                    dr["PowerFact"] = dt.Rows[0]["PowerFact"];
                    dr["KLoss"] = dt.Rows[0]["Kloss"];
                    dr["Category"] = dt.Rows[0]["Category"];
                    dr["Comment"] = dt.Rows[0]["Comment"];
                    dr["CommonType"] = dt.Rows[0]["CommonType"];
                    dr["CommonPercent"] = dt.Rows[0]["CommonPercent"];
                    dr["CommonValue"] = dt.Rows[0]["CommonValue"];
                    dr["CalcLoss"] = dt.Rows[0]["CalcLoss"];
                    dr["idTariff"] = dt.Rows[0]["idTariff"];
                    dr["NumberTP"] = dt.Rows[0]["NumberTP"];
                    dr["DateTP"] = dt.Rows[0]["DateTP"];
                    dr["NumberTU"] = dt.Rows[0]["NumberTU"];
                    dr["DateTU"] = dt.Rows[0]["DateTU"];
                    dr["DatePowerFact"] = dt.Rows[0]["DatePowerFact"];
                    dr["idAbnObjSame"] = dt.Rows[0]["idAbnObjSame"];
                    dr["SubNet"] = dt.Rows[0]["SubNet"];
                    dr["SubNetComment"] = dt.Rows[0]["SubNetComment"];

                    dsAbn.tAbnObjReg.Rows.Add(dr);

                    InsertSqlData(dsAbn, dt);

                    if (cmbObjActive.SelectedIndex == 0)
                        this.SelectSqlData(dsAbn, dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " + ID.ToString() + " OR idAbnDog IS NULL) and DateEnd Is Null and idStatus != 243 and DocNumber Is Not Null order by NumberObj, NumberSubObj");
                    else
                        this.SelectSqlData(dsAbn, dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " + ID.ToString() + " OR idAbnDog IS NULL) order by NumberObj, NumberSubObj");

                    if (dGVEFObj.RowCount > 0) LoadObj();
                    else
                    {
                        dsAbn.vG_AbnObj.Clear();
                        MastertSTB.Text = "";
                        tlSLObjCount.Text = "0";
                        ObjDogovorSTB.Text = "";
                        dsAbn.vG_SchetAll.Clear();
                    }
                }
            }


        }

        private void dGVEFObj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVEFObj.RowCount > 0) LoadObj();
        }

        private void dGVEFObj_KeyUp(object sender, KeyEventArgs e)
        {
            if (dGVEFObj.RowCount > 0) LoadObj();
        }

        //Счетчики
        private void LoadObjMeters()
        {
            dsAbn.vG_MeterValAll.Clear();
            dsAbn.vG_ObjTrans.Clear();
            IDOBJSELECT = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);

            if (cmbPoint_Active.SelectedIndex == 0)
                this.SelectSqlData(dsAbn, dsAbn.vG_ObjMeter, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " and Number is not null");
            else
                this.SelectSqlData(dsAbn, dsAbn.vG_ObjMeter, true, " where idAbnObj = " + IDOBJSELECT.ToString());
            if (objMeterdgv.RowCount > 0) LoadMeter();


        }

        private void LoadMeter()
        {
            if (Convert.ToString(objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value) != "")
            {
                if ((objMeterdgv.CurrentRow.Cells["idZoneDGV"].Value) !=DBNull.Value) 
                    this.SelectSqlData(dsAbn, dsAbn.vG_MeterValAll, true, " where MeterID = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value) + " and idZone = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["idZoneDGV"].Value) + " ORDER BY DateAct desc");
                else
                    this.SelectSqlData(dsAbn, dsAbn.vG_MeterValAll, true, " where MeterID = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value) + " ORDER BY DateAct desc");
                this.SelectSqlData(dsAbn, dsAbn.vG_ObjTrans, true, " where PointID = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value));
                //Тарифы
                this.SelectSqlData(dsAbn, dsAbn.vG_TariffPoint, true, " where idPoint = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value + " ORDER BY SetDate desc "));
                //Дата Счетчика
                MeterDatatextBox.Text = (objMeterdgv.CurrentRow.Cells["dateBeginDGVTBC"].Value == DBNull.Value) ? "" : Convert.ToDateTime(objMeterdgv.CurrentRow.Cells["dateBeginDGVTBC"].Value).ToString("dd.MM.yyyy");
                //Разрядность счетчика
                MeterDigittextBox.Text = Convert.ToString(objMeterdgv.CurrentRow.Cells["digitDGVTBC"].Value);
                //Тип трансформатора
                TransTypetextBox.Text = Convert.ToString(objTransdgv.CurrentRow.Cells["typeTransDGVTBC"].Value);
                //Пломбы
                this.SelectSqlData(dsAbn, dsAbn.vPointPlomb, true, " where idPoint = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value) + " order by DateInst desc ");
                //Замеры
                this.SelectSqlData(dsAbnObjAkt1 , dsAbnObjAkt1.vG_MeasurementsOfCounters, true, " where idPointReg = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value));
                //Потери
                this.SelectSqlData(dsAbn, dsAbn.vG_PointKLossTrans, true, " where idPoint = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value) + " order by DateChange desc ");
            }
        }

        // Раскрас грида счетчиков
        private void objMeterdgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (objMeterdgv.Rows[e.RowIndex].Cells["PDateEnd"].Value != DBNull.Value)
                e.CellStyle.ForeColor = Color.Gray;
        }

        private void objMeterdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (objMeterdgv.RowCount > 0) LoadMeter();

        }

        private void AbnMiniDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadAbonent();
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && toolStripButtonAdd.Visible == true) // если правой кнопкой
            {
                this.AbnMiniDGV.Rows[e.RowIndex].Selected = true;
                ///-----------
                AbnMiniDGV.CurrentCell = AbnMiniDGV[1, e.RowIndex]; //делаем текущей
                this.contextMenuAbn.Show(System.Windows.Forms.Cursor.Position);
            }
        }
       
        private void AbnMiniDGV_KeyUp(object sender, KeyEventArgs e)
        {
            LoadAbonent();
        }

        // Работа Абонентом
        private void AbnMiniDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
            {
                dGVEFObj.Focus();

            }
        }

        private void AbnMiniDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(AbnMiniDGV.Rows[e.RowIndex].Cells[3].Value) == 231)
                    e.CellStyle.ForeColor = Color.Blue;

                if (Convert.ToInt32(AbnMiniDGV.Rows[e.RowIndex].Cells[3].Value) == 230)
                    e.CellStyle.ForeColor = Color.Green;

            }

        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            Object.FormObjAE fAdd = new Object.FormObjAE(ID, -1, Object.FormObjAE.ActionAbnObj.Add, -1, Object.FormObjAE.ActionAbnObjReg.Add);
            fAdd.SqlSettings = this.SqlSettings;

            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString());
                if (dGVEFObj.RowCount > 0) LoadObj();
            }

        }

        private void toolStripButtonObjEdit_Click(object sender, EventArgs e)
        {
            if (dGVEFObj.RowCount > 0)
            {
                int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);
                int idObjReg = 0;
                if (dsAbn.vG_AbnObj.Rows[0]["idReg"] != System.DBNull.Value)
                {
                    idObjReg = Convert.ToInt32(dsAbn.vG_AbnObj.Rows[0]["idReg"]);
                }

                Object.FormObjAE fAdd = new Object.FormObjAE(ID, idObj, Object.FormObjAE.ActionAbnObj.Edit, idObjReg, Object.FormObjAE.ActionAbnObjReg.Edit); ;
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsAbn, dsAbn.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString());
                    if (dGVEFObj.RowCount > 0) LoadObj();
                }
            }
            else
            { 
                MessageBox.Show("Нечего редактировать.");
            }
        }

        //Поиск абонента по имени
        private void toolStripTextBoxSearchName_KeyUp(object sender, KeyEventArgs e)
        {

            for (int i = 0; i < AbnMiniDGV.RowCount; i++)
                if (AbnMiniDGV["NameAbnDGVTBC", i].FormattedValue.ToString().
                    Contains(toolStripTextBoxSearchName.Text.Trim()))
                {
                    AbnMiniDGV.CurrentCell = AbnMiniDGV[1, i];
                    return;
                }
        }

        //Фильтр Абонента по имени
        private void FiltertoolStripButton_Click(object sender, EventArgs e)
        {
            if (AbnFilter == 1)
            {
                bsAbnMini.Filter = null;
                AbnFilter = 0;
            }

            else
            {
                bsAbnMini.Filter = "Name like '%" + toolStripTextBoxSearchName.Text.Trim() + "%' ";
                AbnFilter = 1;
            }

            AbnMiniDGV.Refresh();
        }

        //Удаление документа объекта
        private void tsbObjDocDel_Click(object sender, EventArgs e)
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление",
                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);
                    int idDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value);
                    int idDocType = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idDocObjType"].Value);
                    int DocIndex = dgvObjDoc.CurrentRow.Index;

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();

                    switch (idDocType)
                    {
                        case (int)DocType.ActRBP:

                            this.SelectSqlData(ds, ds.tAbnObjDoc_List, true, "where id = " + idDoc);
                            ds.tAbnObjDoc_List.First().Deleted = !ds.tAbnObjDoc_List.First().Deleted;
                            ds.tAbnObjDoc_List.First().EndEdit();
                            if (this.UpdateSqlData(ds, ds.tAbnObjDoc_List))
                            {
                                if (ds.tAbnObjDoc_List.First().Deleted)
                                {
                                    this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, " where idAbnObj = " + idObj.ToString() + " order by DocDate desc");

                                    if (dgvObjDoc.RowCount > DocIndex) dgvObjDoc.CurrentCell = dgvObjDoc["ObjdocNumberDGVTBC", DocIndex];


                                    MessageBox.Show("Документ успешно удален");
                                }
                                else
                                {
                                    MessageBox.Show("Документ успешно восстановлен");
                                }
                            }
                            break;

                        case (int)DocType.ActKO:
                        case (int)DocType.ActCheck:
                        case (int)DocType.ActMeterInstallation:
                        case (int)DocType.ActMeterDismantling:
                        case (int)DocType.ActMeterkReplacement:
                            this.SelectSqlData(ds.tDocAct_Check, true, "where id = " + idDoc, null, false, 1);
                            this.SelectSqlData(ds.tDocAct, true, "where id = " + ds.tDocAct_Check.Rows[0]["idDocAct"], null, false, 1);
                            ds.tDocAct.First().Deleted = !ds.tDocAct.First().Deleted;
                            ds.tDocAct.First().EndEdit();
                            if (this.UpdateSqlData(ds, ds.tDocAct))
                            {
                                if (ds.tDocAct.First().Deleted)
                                {
                                    this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, " where idAbnObj = " + idObj.ToString() + " order by DocDate desc");

                                    if (dgvObjDoc.RowCount > DocIndex) dgvObjDoc.CurrentCell = dgvObjDoc["ObjdocNumberDGVTBC", DocIndex];


                                    MessageBox.Show("Документ успешно удален");
                                }
                                else
                                {
                                    MessageBox.Show("Документ успешно восстановлен");
                                }
                            }
                            break;
                        #region Расчет потерь 17.09.2013 Шумилов А.И.
                        case (int)TypeCalcLoss.TypeKL:
                        case (int)TypeCalcLoss.TypeVL:
                        case (int)TypeCalcLoss.TypeTrans:
                            if (tsmiCalcLoss.Enabled)
                            {
                                this.SelectSqlData(dsAbn.tJ_CalcLoss, true, "where id = " + idDoc.ToString());
                                if (dsAbn.tJ_CalcLoss.Rows.Count > 0)
                                {
                                    dsAbn.tJ_CalcLoss.Rows[0]["deleted"] = 1;
                                    dsAbn.tJ_CalcLoss.Rows[0].EndEdit();
                                    if (this.UpdateSqlData(dsAbn, dsAbn.tJ_CalcLoss))
                                    {
                                        this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true,
                                            " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DocDate desc");
                                        MessageBox.Show("Документ успешно удален");
                                    }
                                }
                            }
                            break;
                        #endregion
                        default:
                            MessageBox.Show("Невозможно удалить текущий документ");
                            break;

                    } //end switch
                }
            }
            else
            {
                MessageBox.Show("Не выбран документ для удаления");
            }
        }

        //Редактирование Документов объекта
        private void tsbObjAktEdit_Click(object sender, EventArgs e)
        {
            if (tsbObjAktEdit.Enabled && tsbObjAktEdit.Visible)
                EditDocObj();
        }

        //Добавление Документов объекта
        private void tsmiActBalanceAdd_Click(object sender, EventArgs e)
        {
            if (AbnMiniDGV.CurrentRow != null && dGVEFObj.CurrentRow != null)
            {
                Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                    new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, false, true, 
                        Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value)
                    , Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value), TypeDocValue.ActBalance);
                frmAktRBP.MdiParent = this.MdiParent;
                frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                frmAktRBP.Show();
            }
        }

        void frmAktRBP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DocDate desc");
        }

        //Добавление Документов объекта
        private void tsmiActLiabilityAdd_Click(object sender, EventArgs e)
        {
            if (AbnMiniDGV.CurrentRow != null && dGVEFObj.CurrentRow != null)
            {
                Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                    new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, false, true, 
                        Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value)
                    , Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value), TypeDocValue.ActLiability);
                frmAktRBP.MdiParent = this.MdiParent;
                frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                frmAktRBP.Show();
            }
        }

        //Информация
        private void tsbObjDocInfo_Click(object sender, EventArgs e)
        {
            if (dgvObjDoc.CurrentRow != null)
                switch (Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value))
                {
                    case (int)DocType.DogovorTransferEnergy:
                        break;
                    case (int)DocType.ActUst:
                        break;
                    case (int)DocType.ActDem:
                        break;
                    case (int)DocType.LossCalculation:
                        break;
                    case (int)DocType.ActPerehod:
                        break;
                    // Акт разграничения балансовой принадлежности
                    case (int)DocType.ActLiability:
                    case (int)DocType.ActRBP:
                        Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                            new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value), Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value), true);
                        frmAktRBP.MdiParent = this.MdiParent;
                        frmAktRBP.Show();
                        break;
                    case (int)DocType.ActTP:
                        break;
                    case (int)DocType.ActKO:
                    case (int)DocType.ActMeterInstallation:
                    case (int)DocType.ActMeterDismantling:
                    case (int)DocType.ActMeterkReplacement:
                    case (int)DocType.ActCheck:
                        FormDocAct_Check frmActCheck = new FormDocAct_Check(this.SqlSettings, Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value), Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value));
                        frmActCheck.ShowDialog();
                        break;
                    case (int)DocType.Dogovor:
                        break;
                    case (int)DocType.DogovorEnergo:
                        break;
                    #region Расчет потерь 17.09.2013 Шумилов А.И.
                    case (int)TypeCalcLoss.TypeKL:
                    case (int)TypeCalcLoss.TypeVL:
                    case (int)TypeCalcLoss.TypeTrans:
                        ReportCalcLoss();
                        break;
                    #endregion
                    #region акт осмотра эл, выполнения ту, акт о тп (22/10/2014 Shumilov A/I/)
                    case (int)eTypeDocTC.ActTC:
                    case (int)eTypeDocTC.ActElectricalInspection:
                    case (int)eTypeDocTC.ActPerformingTU:
                    case (int)eTypeDocTC.ChangeSwitch:
                        ReportActTC();
                        break;
                    #endregion
                    default:
                        break;
                }
        }

        //Создание точки учета
        private void tsbMeterNew_Click(object sender, EventArgs e)
        {
            if (dGVEFObj.RowCount > 0)
            {
                int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);


                    Meter.FormNewPoint fAdd = new Meter.FormNewPoint(idObj);
                    fAdd.SqlSettings = this.SqlSettings;
                    fAdd.ShowDialog();

                    LoadObjMeters();

             
            }
        }

        //Внесение Точки учета
        private void tsbMeterAdd_Click(object sender, EventArgs e)
        {
            if (dGVEFObj.RowCount > 0)
            {
                int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);

                if (objMeterdgv.RowCount > 0)
                {
                    int idPoint = Convert.ToInt32(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value);
                    Meter.FormMeterAddEdit fAdd = new Meter.FormMeterAddEdit(idObj, idPoint, false);
                    fAdd.SqlSettings = this.SqlSettings;
                    fAdd.ShowDialog();

                    LoadObjMeters();

                }
                //else
                //{
                //    Meter.FormMeterAddEdit fAdd = new Meter.FormMeterAddEdit(idObj, -1, false);
                //    fAdd.SqlSettings = this.SqlSettings;
                //    fAdd.ShowDialog();

                //    LoadObjMeters();

                //}
            }
        }

        //Инфо Точки учета
        private void tsbMeterInfo_Click(object sender, EventArgs e)
        {
            if (objMeterdgv.RowCount > 0)
            {
                int idPoint = Convert.ToInt32(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value);
                int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);

                Meter.FormMeterAddEdit fAdd = new Meter.FormMeterAddEdit(idObj, idPoint, true);
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    LoadObjMeters();
                }
            }
        }

        private void dgvObjDoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvObjDoc.SelectedRows != null && dgvObjDoc.SelectedRows.Count != 0) idList = (Int32)dgvObjDoc.SelectedRows[0].Cells["idObjDocDGVBC"].Value;
        }

        private void tsmiActCheckAdd_Click(object sender, EventArgs e)
        {
            if (objMeterdgv.RowCount > 0)
            {
                FormDocAct_CheckAdd frmActCheckAdd = new FormDocAct_CheckAdd(this.SqlSettings, Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value));
                frmActCheckAdd.Show();
            }
        }

        //Внесение тарифа
        private void tsbTariff_Click(object sender, EventArgs e)
        {
            //int idPoint = Convert.ToInt32(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value);
            int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);

            Meter.FormAddTariff fAdd = new Meter.FormAddTariff(idObj);
            fAdd.SqlSettings = this.SqlSettings;
            fAdd.ShowDialog();

            LoadObjMeters();

        }

        private void tsmiActInstDevice_Click(object sender, EventArgs e)
        {

            FormDocAct_DemUst frm = new FormDocAct_DemUst(this.SqlSettings, IDOBJSELECT, DocType.ActMeterInstallation);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DocDate desc");
            }
        }

        private void tsmiActDisDevice_Click(object sender, EventArgs e)
        {
            FormDocAct_DemUst frm = new FormDocAct_DemUst(this.SqlSettings, IDOBJSELECT, DocType.ActMeterDismantling);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DocDate desc");
            }
        }

        private void tsmiActReplaceDevice_Click(object sender, EventArgs e)
        {
            FormDocAct_DemUst frm = new FormDocAct_DemUst(this.SqlSettings, IDOBJSELECT, DocType.ActMeterkReplacement);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DocDate desc");
            }
        }

        public void ActReload(int idAbnObj)
        {
            this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, String.Format(" where idAbnObj = {0} order by DocDate desc", idAbnObj));
        }

        private void bsObjMeter_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormAbn_Shown(object sender, EventArgs e)
        {
            toolStripTextBoxAbnSearch.Focus();
        }

        // добавить заявленную мощность
        private void tsbObjPowerAdd_Click(object sender, EventArgs e)
        {
            Object.FormObjPower frm = new Object.FormObjPower(Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value));
            frm.SqlSettings = this.SqlSettings;
            frm.ShowDialog();
            this.SelectSqlData(dsAbn, dsAbn.tG_ObjMax, true, " where ObjID = " + IDOBJSELECT.ToString() + " Order by Year desc");
        }

        // редактировать заявленную мощность
        private void tsbObjPowerEdit_Click(object sender, EventArgs e)
        {
            if (dsAbn.tG_ObjMax.Count > 0)
            {
                Object.FormObjPower frm = new Object.FormObjPower(Convert.ToInt32(dgvObjCallPower.CurrentRow.Cells["ObjMaxIDdgv"].Value), Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value), true);
                frm.SqlSettings = this.SqlSettings;
                frm.ShowDialog();
                this.SelectSqlData(dsAbn, dsAbn.tG_ObjMax, true, " where ObjID = " + IDOBJSELECT.ToString() + " Order by Year desc");
            }
        }

        // удалить заявленную мощность
        private void tsbObjPowerDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dsAbn.tG_ObjMax.Count > 0)
                {
                    //DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                    try
                    {
                        int id = Convert.ToInt32(dgvObjCallPower.CurrentRow.Cells["objMaxIDdgv"].Value);
                        this.DeleteSqlDataById(dsAbn.tG_ObjMax, id);
                        /*con.OpenConnection(SqlSettings);

                        string strCmd = "";
                        strCmd = "Leg_DelCallPower";
                        SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@id", id);
                        sqlCmd.Parameters.Add(p1);

                        sqlCmd.CommandTimeout = 0;
                        sqlCmd.ExecuteNonQuery();*/
                        this.SelectSqlData(dsAbn, dsAbn.tG_ObjMax, true, " where ObjID = " + IDOBJSELECT.ToString() + " Order by Year desc");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                    //finally
                    //{
                        //con.CloseConnection();
                    //}
                }
            }

        }

        // копировать заявленную мощность
        private void tsbObjPowerCopy_Click(object sender, EventArgs e)
        {
            if (dsAbn.tG_ObjMax.Count > 0)
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    int id = Convert.ToInt32(dgvObjCallPower.CurrentRow.Cells["objMaxIDdgv"].Value);
                    con.OpenConnection(SqlSettings);

                    string strCmd = " INSERT tG_ObjMax SELECT [ObjID], [Year], Month01, Month02, Month03, Month04, Month05, Month06,	Month07, Month08, Month09, Month10, Month11, Month12, " +
                                    " Volume01, Volume02, Volume03, Volume04, Volume05, Volume06, Volume07, Volume08, Volume09, Volume10, Volume11, Volume12 " +
                                    " FROM tG_ObjMax WHERE ObjMaxID  = @id ";
                    //strCmd = "Leg_CopyCallPower";

                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    //sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@id", id);
                    sqlCmd.Parameters.Add(p1);

                    sqlCmd.CommandTimeout = 0;
                    sqlCmd.ExecuteNonQuery();
                    this.SelectSqlData(dsAbn, dsAbn.tG_ObjMax, true, " where ObjID = " + IDOBJSELECT.ToString() + " Order by Year desc");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        // показывать объекты активные/все
        private void cmbObjActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbObjActive.SelectedIndex == 0)
                this.SelectSqlData(dsAbn, dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " + 
                    ID.ToString() + " OR idAbnDog IS NULL) and DateEnd Is Null and DocNumber Is Not Null order by NumberObj, NumberSubObj");
            else
                this.SelectSqlData(dsAbn, dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " order by NumberObj, NumberSubObj");
            //this.SelectSqlData(dsAbn, dsAbn.vG_Obj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString() + " and (idAbnDog = " +
            //    ID.ToString() + " OR idAbnDog IS NULL) order by NumberObj, NumberSubObj");

            if (IDABNOBJ != 0)
            {
                dGVEFObj.CurrentCell = dGVEFObj["NumberObj", GetRowIndexByKey(dGVEFObj, "idObj", IDABNOBJ)];
                IDABNOBJ = 0;
            }

            if (dsAbn.vG_Obj.Rows.Count > 0) LoadObj();
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            FormAbnObjFind f = new FormAbnObjFind();
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                toolStripTextBoxAbnSearch.Text = ABNSELECT.ToString();
                for (int i = 0; i < AbnMiniDGV.RowCount; i++)
                    if (AbnMiniDGV[1, i].FormattedValue.ToString().
                        Contains(toolStripTextBoxAbnSearch.Text.Trim()))
                    {
                        AbnMiniDGV.CurrentCell = AbnMiniDGV[1, i];
                        return;
                    }
            }
        }

        private void tssbObjDocActAdd_ButtonClick(object sender, EventArgs e)
        {
            tssbObjDocActAdd.ShowDropDown();
        }

        private void toolStripButtonObjHistory_Click(object sender, EventArgs e)
        {
            if (dGVEFObj.RowCount > 0)
            {
                int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);
                int idObjReg = Convert.ToInt32(dsAbn.vG_AbnObj.Rows[0]["idReg"]);

                Object.FormObjHistory fAdd = new Object.FormObjHistory(idObj); ;
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsAbn, dsAbn.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString());
                    if (dGVEFObj.RowCount > 0) LoadObj();
                }
            }
            else
            {
                MessageBox.Show("Объекты отсутствуют.");
            }
        }

        // копирование объекта
        private void toolStripButtonObjCopy_Click(object sender, EventArgs e)
        {
            if (dGVEFObj.RowCount > 0)
            {
                int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);
                int idObjReg = Convert.ToInt32(dsAbn.vG_AbnObj.Rows[0]["idReg"]);

                Object.FormObjCopy fAdd = new Object.FormObjCopy(idObj); 
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsAbn, dsAbn.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString());
                    if (dGVEFObj.RowCount > 0) LoadObj();
                }
            }
            else
            {
                MessageBox.Show("Нечего копировать");
            }

        }

        private void tsbPointRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите восстановить эту точку учета?", "Восстановление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (objMeterdgv.Rows.Count > 0)
                {
                    DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                    try
                    {
                        con.OpenConnection(SqlSettings);

                        string strCmd = "";
                        strCmd = "Leg_PointRestore";
                        SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // параметры

                        int idPoint = Convert.ToInt32(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value);

                        SqlParameter p = new SqlParameter("@idPoint", idPoint);
                        sqlCmd.Parameters.Add(p);

                        sqlCmd.CommandTimeout = 0;

                        sqlCmd.ExecuteNonQuery();

                        LoadObjMeters();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                    finally
                    {
                        con.CloseConnection();
                    }
                }
            }
        }
 
        private void ObjFlagAddTSB_Click(object sender, EventArgs e)
        {
            if (dGVEFObj.RowCount > 0)
            {
                int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);
                int idObjReg = Convert.ToInt32(dsAbn.vG_AbnObj.Rows[0]["idReg"]);

                Object.FormObjFlagAdd fAdd = new Object.FormObjFlagAdd(idObj); ;
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsAbn, dsAbn.vG_AbnObjFlags, true, " where idAbnObj = " + idObj.ToString() + " Order by Name desc");
                    this.SelectSqlData(dsAbn, dsAbn.tAbnObjFlags, true, " where idAbnObj = " + idObj.ToString() + " Order by Date desc");
                }
            }
            else
            {
                MessageBox.Show("Нет объектов.");
            }
        }

        private void AbnObjFlagNameDGV_SelectionChanged(object sender, EventArgs e)
        {
           if (AbnObjFlagNameDGV.RowCount > 0) bsAbnObjFlagsDate.Filter = "idFlag =" + AbnObjFlagNameDGV.CurrentRow.Cells["idFlag"].Value.ToString();
        }

        private void ObjFlagDelTSB_Click(object sender, EventArgs e)
        {
            if (AbnObjFlagNameDGV.RowCount > 0)
            {
                 DialogResult dialogResult = MessageBox.Show("Удалить текущий признак?", "Удаление", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {
                     DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                     this.SelectSqlData(ds, ds.tAbnObjFlags, true, "where id = " + AbnObjFlagNameDGV.CurrentRow.Cells["idDGV"].Value.ToString());
                     ds.tAbnObjFlags.Rows[0]["Deleted"] = 1;
                     ds.tAbnObjFlags.Rows[0].EndEdit();
                     if (this.UpdateSqlData(ds, ds.tAbnObjFlags))
                     {
                         this.SelectSqlData(dsAbn, dsAbn.vG_AbnObjFlags, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " Order by Name desc");
                         if (dsAbn.vG_AbnObjFlags.Rows.Count > 0) this.SelectSqlData(dsAbn, dsAbn.tAbnObjFlags, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " Order by Date desc");
                         else dsAbn.tAbnObjFlags.Clear();
                     }
                 }
            }

        }

        private void FlagDateDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(FlagDateDGV.Rows[e.RowIndex].Cells["deleted"].Value) == 1)
                    e.CellStyle.ForeColor = Color.Gainsboro;
              
            }

        }

        private void btnAddMeasur_Click(object sender, EventArgs e)
        {

            if (objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value != System.DBNull.Value)
            {
                Meter.FormMeasurementsOfCounters frm = new Meter.FormMeasurementsOfCounters((Int32)objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value, false, Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value));
                frm.SqlSettings = this.SqlSettings;
                frm.ShowDialog();
                this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vG_MeasurementsOfCounters, true, " where idPointReg = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value));
            }
        }

        private void btnEditMeasur_Click(object sender, EventArgs e)
        {
            if (dgvMeasur.Rows.Count > 0)
            {
                Meter.FormMeasurementsOfCounters frm = new Meter.FormMeasurementsOfCounters((Int32)dgvMeasur.CurrentRow.Cells["idDGVMeasur"].Value, true, Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value));
                frm.SqlSettings = this.SqlSettings;
                frm.ShowDialog();
                this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vG_MeasurementsOfCounters, true, " where idPointReg = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value));
            }
        }

        private void btnDelMeasur_Click(object sender, EventArgs e)
        {
            if (dgvMeasur.Rows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущую строку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                    try
                    {
                        int id = (Int32)dgvMeasur.CurrentRow.Cells["idDGVMeasur"].Value;
                        DateTime InputDate = Convert.ToDateTime(dgvMeasur.CurrentRow.Cells["dateOfIntroductionDataGridViewTextBoxColumn"].Value);
                        this.DeleteSqlDataById(dsAbn.tG_MeasurementsOfCounters, id);
                        /*con.OpenConnection(SqlSettings);

                        string strCmd = "";
                        strCmd = "Leg_DelMeasur";
                        SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@id", id);
                        sqlCmd.Parameters.Add(p1);

                        sqlCmd.CommandTimeout = 0;
                        sqlCmd.ExecuteNonQuery();*/
                        this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vG_MeasurementsOfCounters, true, " where idPointReg = " + Convert.ToString(objMeterdgv.CurrentRow.Cells["meterIDDGVTBC"].Value));
                        MeasurementsOfCountersToMeasurementsOfObject(InputDate);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                    //finally
                    //{
                    //    con.CloseConnection();
                    //}
                }
            }
        }

        private void MeasurementsOfCountersToMeasurementsOfObject(DateTime InputDate)
        {
            // пересчитать замеры объекта
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "MeasurementsOfCountersToMeasurementsOfObject";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@idObj", Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@InputDate", InputDate);
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        private void dGVEFObj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVEFObj.RowCount > 0)
            {
                int idObj = Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value);
                
                int idObjReg = Convert.ToInt32(dsAbn.vG_AbnObj.Rows[0]["idReg"]);

                Object.FormObjAE fAdd = new Object.FormObjAE(ID, idObj, Object.FormObjAE.ActionAbnObj.Edit, idObjReg, Object.FormObjAE.ActionAbnObjReg.Edit); ;
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsAbn, dsAbn.vG_AbnObj, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegalAll + ") and idAbn = " + ID.ToString());
                    if (dGVEFObj.RowCount > 0) LoadObj();
                }
            }
            else
            {
                MessageBox.Show("Нечего редактировать.");
            }
        }

        private void AbnMiniDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditAbn();
        }

        private void dGVAbnContact_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (toolStripButtonEditContac.Visible && toolStripButtonEditContac.Enabled)
                {
                    FormAbnContactAdd fAdd = new FormAbnContactAdd(Convert.ToInt32(dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value), false);
                    fAdd.SqlSettings = this.SqlSettings;
                    if (fAdd.ShowDialog() == DialogResult.OK)
                        LoadContact();
                }
            }
        }

        private void dgvAbnDoc_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAbnDoc.RowCount > 0)
            {
                int IDABN = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
                int idType = Convert.ToInt32(dgvAbnDoc.CurrentRow.Cells["idDocTypeDGVTBC"].Value);
                int IDLIST = Convert.ToInt32(dgvAbnDoc.CurrentRow.Cells["idDocDGVTBC"].Value);

                switch (idType)
                {
                    case (int)Constants.DocType.Dogovor:
                        FormAbnDoc_Dogovor fDog = new FormAbnDoc_Dogovor(IDABN, IDLIST, idType, false);
                        fDog.SqlSettings = this.SqlSettings;
                        if (fDog.ShowDialog() == DialogResult.OK)
                        {
                            int DocIndex = dgvAbnDoc.CurrentRow.Index;
                            this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + ID.ToString() + " order by DocDate desc");
                            dgvAbnDoc.CurrentCell = dgvAbnDoc["docNumberDGVTBC", DocIndex];
                        }
                        break;
                    case (int)Constants.DocType.DogovorEnergo:
                        FormAbnDoc_Dogovor fDogEnergo = new FormAbnDoc_Dogovor(IDABN, IDLIST, idType, false);
                        fDogEnergo.SqlSettings = this.SqlSettings;
                        if (fDogEnergo.ShowDialog() == DialogResult.OK)
                        {
                            int DocIndex = dgvAbnDoc.CurrentRow.Index;
                            this.SelectSqlData(dsAbn, dsAbn.vAbnDoc_List, true, " where idAbn = " + ID.ToString() + " order by DocDate desc");
                            dgvAbnDoc.CurrentCell = dgvAbnDoc["docNumberDGVTBC", DocIndex];
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void dgvObjCallPower_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsAbn.tG_ObjMax.Count > 0)
            {
                Object.FormObjPower frm = new Object.FormObjPower(Convert.ToInt32(dgvObjCallPower.CurrentRow.Cells["ObjMaxIDdgv"].Value), Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value), true);
                frm.SqlSettings = this.SqlSettings;
                frm.ShowDialog();
                this.SelectSqlData(dsAbn, dsAbn.tG_ObjMax, true, " where ObjID = " + IDOBJSELECT.ToString() + " Order by Year desc");
            }
        }

        private void dgvObjDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDocObj();
        }

        private void tbAbnLog_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            FormAbn_Log f = new FormAbn_Log(id);
            f.SqlSettings = this.SqlSettings;
            f.ShowDialog();
        }

        private void tsbKlossMonth_Click(object sender, EventArgs e)
        {
            int idPoint = Convert.ToInt32(objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value);
            string Point = objMeterdgv.CurrentRow.Cells["numberDataGridViewTextBoxColumn"].Value.ToString(); 

            Object.FormObjKLossTrans f = new Object.FormObjKLossTrans(idPoint, Point);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            { };
        }

        private void tsbKlossEdit_Click(object sender, EventArgs e)
        {
            if (dgvKloss.Rows.Count > 0)
            {
                Meter.FormPointKLoss frm = new Meter.FormPointKLoss((Int32)dgvKloss.CurrentRow.Cells["idKLoss"].Value, (Int32)dgvKloss.CurrentRow.Cells["idPoint"].Value, Meter.FormPointKLoss.ActionKLoss.Edit);
                frm.SqlSettings = this.SqlSettings;
                frm.ShowDialog();
                this.SelectSqlData(dsAbn, dsAbn.vG_PointKLossTrans, true, " where idPoint = " + objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value.ToString());
            }
        }

        private void tsbKlossAdd_Click(object sender, EventArgs e)
        {
            if (objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value != System.DBNull.Value)
            {
                Meter.FormPointKLoss frm = new Meter.FormPointKLoss(-1, (Int32)objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value, Meter.FormPointKLoss.ActionKLoss.Add);
                frm.SqlSettings = this.SqlSettings;
                frm.ShowDialog();
                this.SelectSqlData(dsAbn, dsAbn.vG_PointKLossTrans, true, " where idPoint = " + objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value.ToString());
            }

        }

        private void tsbKlossDel_Click(object sender, EventArgs e)
        {
            if (dgvKloss.Rows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущую строку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (Int32)dgvKloss.CurrentRow.Cells["idKLoss"].Value;
                    DataSet.DataSetAbn ds = new DataSet.DataSetAbn();
                    this.SelectSqlData(ds.tG_PointKLossTrans, true, "where id = " + id.ToString());
                    if (ds.tG_PointKLossTrans.Rows.Count > 0)
                    {
                        ds.tG_PointKLossTrans.Rows[0]["deleted"] = true;
                        ds.tG_PointKLossTrans.Rows[0].EndEdit();
                        this.UpdateSqlData(ds, ds.tG_PointKLossTrans);
                        this.SelectSqlData(dsAbn, dsAbn.vG_PointKLossTrans, true, " where idPoint = " + objMeterdgv.CurrentRow.Cells["pointIDDGVTBC"].Value.ToString());
                    }
                }
            }

        }

        private void EditDocObj()
        {
            if (dgvObjDoc.CurrentRow != null)
                switch (Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value))
                {
                    case (int)DocType.DogovorTransferEnergy:
                        break;
                    case (int)DocType.ActUst:
                        break;
                    case (int)DocType.ActDem:
                        break;
                    case (int)DocType.LossCalculation:
                        break;
                    case (int)DocType.ActPerehod:
                        break;
                    // Акт разграничения балансовой принадлежности
                    case (int)DocType.ActLiability:
                    case (int)DocType.ActRBP:
                        Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP = 
                            new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, Convert.ToInt32(dGVEFObj.CurrentRow.Cells[idObj.Name].Value), 
                            Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idObjDocDGVBC.Name].Value));
                        frmAktRBP.MdiParent = this.MdiParent;
                        frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                        frmAktRBP.Show();
                        break;
                    case (int)DocType.ActTP:
                        break;
                    case (int)DocType.ActKO: 
                    case (int)DocType.ActMeterInstallation:
                    case (int)DocType.ActMeterDismantling:
                    case (int)DocType.ActMeterkReplacement:
                    case (int)DocType.ActCheck:
                        FormDocAct_CheckAdd frmActCheckAdd = new FormDocAct_CheckAdd(this.SqlSettings, Convert.ToInt32(dGVEFObj.CurrentRow.Cells["idObj"].Value), Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value));
                        frmActCheckAdd.Show();
                        break;
                    case (int)DocType.Dogovor:
                        break;
                    case (int)DocType.DogovorEnergo:
                        break;
                    #region Расчет потерь 17.09.2013 Шумилов А.И.
                    case (int)TypeCalcLoss.TypeKL:
                    case (int)TypeCalcLoss.TypeVL:
                    case (int)TypeCalcLoss.TypeTrans:
                        if (tsmiCalcLoss.Enabled)
                            EditCalcLoss();
                        break;
                    #endregion
                    #region акт осмотра эл, выполнения ту, акт о тп (22/10/2014 Shumilov A/I/)
                    case (int)eTypeDocTC.ActTC :
                    case (int)eTypeDocTC.ActElectricalInspection:
                    case (int)eTypeDocTC.ActPerformingTU:
                    case (int)eTypeDocTC.ChangeSwitch:
                        EditActTC();
                        break;
                    #endregion
                    default:
                        break;
                }
        }

        #region акт осмотра эл, выполнения ту, акт о тп (22/10/2014 Shumilov A/I/)
        private void EditActTC()
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                int typeDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value);
                int idDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idObjDocDGVBC.Name].Value);

                switch (typeDoc)
                {
                    case (int)eTypeDocTC.ActTC:
                        Documents.Forms.TechnologicalConnection.ActTC.FormTCAddEdit fTC =
                            new Documents.Forms.TechnologicalConnection.ActTC.FormTCAddEdit
                                (idDoc);
                        fTC.SqlSettings = this.SqlSettings;
                        fTC.MdiParent = this.MdiParent;
                        fTC.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        fTC.Show();
                        break;
                    case (int)eTypeDocTC.ActPerformingTU:  // акт о выполении ТУ
                        Documents.Forms.TechnologicalConnection.Acts.FormActPerformingTU fPerf =
                            new Documents.Forms.TechnologicalConnection.Acts.FormActPerformingTU(idDoc);
                        fPerf.SqlSettings = this.SqlSettings;
                        fPerf.MdiParent = this.MdiParent;
                        fPerf.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        fPerf.Show();
                        break;
                    case (int)eTypeDocTC.ActElectricalInspection:
                        Documents.Forms.TechnologicalConnection.Acts.FormActElectricalInspection f =
                            new Documents.Forms.TechnologicalConnection.Acts.FormActElectricalInspection(idDoc);
                        f.SqlSettings = this.SqlSettings;
                        f.MdiParent = this.MdiParent;
                        f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        f.Show();
                        break;
                    case (int)eTypeDocTC.ChangeSwitch:
                        Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch fChangeSwitch =
                            new Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch(idDoc);
                        fChangeSwitch.SqlSettings = this.SqlSettings;
                        fChangeSwitch.MdiParent = this.MdiParent;
                        fChangeSwitch.FormClosed += new FormClosedEventHandler(f_FormClosed);
                        fChangeSwitch.Show();
                        break;
                }
            }
        }

        private void ReportActTC()
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                int idDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idObjDocDGVBC.Name].Value);
                int typeDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value);

                switch (typeDoc)
                {
                    case (int)eTypeDocTC.ActTC:
                    case (int)eTypeDocTC.ActPerformingTU:  // акт о выполении ТУ
                    case (int)eTypeDocTC.ActElectricalInspection:
                        Documents.Forms.TechnologicalConnection.Acts.FormReportActElectricalInspection f =
                           new Documents.Forms.TechnologicalConnection.Acts.FormReportActElectricalInspection(idDoc);
                        f.SqlSettings = this.SqlSettings;
                        f.MdiParent = this.MdiParent;
                        f.Show();                        
                        break;
                    case (int)eTypeDocTC.ChangeSwitch:
                        Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch fChSw =
                            new Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch(idDoc, true);
                        fChSw.SqlSettings = this.SqlSettings;
                        fChSw.MdiParent = this.MdiParent;
                        fChSw.Show();
                        break;
                }
            }
        }
        #endregion
        
        #region Расчет потерь 16.09.2013 Шумилов А.И.
        private void LoadToolStripMenuCalcLoss()
        {
            DataSet.DataSetAbn.tR_ClassifierDataTable dt = new DataSet.DataSetAbn.tR_ClassifierDataTable();
            this.SelectSqlData(dt, true, "where ParentKey = ';TypeDoc;tJ_CalcLoss;' and isGroup = 0 and deleted = 0 order by name");
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(r["Name"].ToString());
                item.Tag = r["id"];
                tsmiCalcLoss.DropDownItems.Add(item);
                item.Click += new EventHandler(toolBtnAddCalc_Click);
            }
        }
        // Добавить расчет
        private void toolBtnAddCalc_Click(object sender, EventArgs e)
        {
            int typeCalc = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
            if (typeCalc == (int)Constants.TypeCalcLoss.TypeTrans)
            {
                FormAddEditCalcTrans f = new FormAddEditCalcTrans(-1, typeCalc, ID, IDOBJSELECT);
                f.MdiParent = this.MdiParent;
                f.SqlSettings = this.SqlSettings;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.Show();
            }
            else // КЛ/ВЛ
            {
                FormAddEditCalcCable f = new FormAddEditCalcCable(-1, typeCalc, ID, IDOBJSELECT);
                f.MdiParent = this.MdiParent;
                f.SqlSettings = this.SqlSettings;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.Show();
            }
        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((Form)sender).DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectSqlData(dsAbn, dsAbn.vAbnObjDoc_List, true, 
                    " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DocDate desc");
            }
        }
        private void EditCalcLoss()
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                int typeCalc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value);
                int idCalc =Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idObjDocDGVBC.Name].Value);
                if (typeCalc == (int)Constants.TypeCalcLoss.TypeTrans)
                {
                    FormAddEditCalcTrans f = new FormAddEditCalcTrans(idCalc, typeCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                    f.Show();
                }
                else // КЛ/ВЛ
                {
                    FormAddEditCalcCable f = new FormAddEditCalcCable(idCalc, typeCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                    f.Show();
                }
            }
        }

        private void ReportCalcLoss()
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                int idCalc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idObjDocDGVBC.Name].Value);
                if (Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value) ==
                    (int)Constants.TypeCalcLoss.TypeTrans)
                {
                    Documents.Forms.JournalCalcLoss.Report.FormReportCalcLossTrans f = new Documents.Forms.JournalCalcLoss.Report.FormReportCalcLossTrans(idCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.Show();
                }
                else
                {
                    Documents.Forms.JournalCalcLoss.Report.FormReportCalcLoss f = new Documents.Forms.JournalCalcLoss.Report.FormReportCalcLoss(idCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.Show();
                }
            }
        }
        #endregion

        private void cmbPoint_Active_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoint_Active.SelectedIndex == 0)
                // активные счетчики
                this.SelectSqlData(dsAbn, dsAbn.vG_ObjMeter, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " and Number is not null");
            else
                // все счетчики
                this.SelectSqlData(dsAbn, dsAbn.vG_ObjMeter, true, " where idAbnObj = " + IDOBJSELECT.ToString());
        }
        public void FindAbonent()
        {

            FormAbnFindAddress f = new FormAbnFindAddress();
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (f.SelectedType == Constants.Constants.TypeAbnLegal
                   || f.SelectedType == Constants.Constants.TypeAbnNet
                   || f.SelectedType == Constants.Constants.TypeAbnNet)
                {
                    for (int i = 0; i < AbnMiniDGV.RowCount; i++)
                        if (AbnMiniDGV[1, i].FormattedValue.ToString().
                            Contains(f.SelectedAbn.ToString().Trim()))
                        {
                            AbnMiniDGV.CurrentCell = AbnMiniDGV[1, i];
                            LoadAbonent();
                            if (dGVEFObj.RowCount > 0)
                            {
                                for (int j = 0; j < dGVEFObj.RowCount; j++)
                                {
                                    if (dGVEFObj["idObj", j].FormattedValue.ToString().
                                    Contains(f.SelectedObj.ToString().Trim()))
                                    {
                                        dGVEFObj.CurrentCell = dGVEFObj["NameObj", j];
                                        LoadObj();
                                        return;
                                    }
                                }

                                return;
                            }
                            else return;
                        }

                }

                if (f.SelectedType == Constants.Constants.TypeAbnPrivate
                    || f.SelectedType == Constants.Constants.TypeAbnPrivateNoDog)
                {
                    Prv.Forms.Abonent.FormAbonent prvAbn = new Prv.Forms.Abonent.FormAbonent(f.SelectedAbn, f.SelectedType);
                    prvAbn.SqlSettings = this.SqlSettings;
                    prvAbn.MdiParent = this.MdiParent;

                    prvAbn.Show();
                }
            }

        }
        private void toolStripButtonFindAddress_Click(object sender, EventArgs e)
        {
            FindAbonent();

        }

        #region Ктонтакты всех организаций 28/03/2014 Шумилов А.И.
        // смена принадлежности контактов
        private void cmbContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContact.SelectedIndex == 0 || cmbContact.SelectedIndex == 4)
            {
                toolStripButtonNewContact.Enabled = true;
                toolStripButtonEditContac.Enabled = true;
                toolStripButtonDelContact.Enabled = true;
            }
            else
            {
                toolStripButtonNewContact.Enabled = false;
                toolStripButtonEditContac.Enabled = false;
                toolStripButtonDelContact.Enabled = false;
            }
            LoadContact();
        }
        // Загрузка контактов
        private void LoadContact()
        {
            DataSet.DataSetAbn dsTmp = new DataSet.DataSetAbn();
            switch (cmbContact.SelectedIndex)
            {
                case 0: // текущая организация
                    this.SelectSqlData(dsAbn.tAbnContact, true, " where idAbn = " + ID.ToString() + " and Author = " + Constants.Constants.AuthorContact_CS.ToString() + " order by DateChange desc");
                    break;
                case 1: // сетевая организация
                    this.SelectSqlData(dsTmp.tAbnObjReg, true, " where idAbnObj = " + IDOBJSELECT.ToString() +
                        " order by dateChange desc", null, false, 1);
                    if (dsTmp.tAbnObjReg.Rows.Count > 0 && dsTmp.tAbnObjReg.Rows[0]["idAbnNet"] != DBNull.Value)
                        this.SelectSqlData(dsAbn.tAbnContact, true, " where idAbn = " + dsTmp.tAbnObjReg.Rows[0]["idAbnNet"].ToString() + " and Author = " + Constants.Constants.AuthorContact_CS.ToString() + " order by DateChange desc");
                    else
                        dsAbn.tAbnContact.Clear();
                    break;
                case 2: // сбытовая организация
                    this.SelectSqlData(dsTmp.tAbnObjReg, true, " where idAbnObj = " + IDOBJSELECT.ToString() +
                        " order by dateChange desc", null, false, 1);
                    if (dsTmp.tAbnObjReg.Rows.Count > 0 && dsTmp.tAbnObjReg.Rows[0]["idAbnSale"] != DBNull.Value)
                        this.SelectSqlData(dsAbn, dsAbn.tAbnContact, true, " where idAbn = " + dsTmp.tAbnObjReg.Rows[0]["idAbnsale"].ToString() + " and Author = " + Constants.Constants.AuthorContact_CS.ToString() + " order by DateChange desc");
                    else
                        dsAbn.tAbnContact.Clear();
                    break;
                case 3: // обслуживающая организация
                    this.SelectSqlData(dsTmp.tAbnObjReg, true, " where idAbnObj = " + IDOBJSELECT.ToString() +
                        " order by dateChange desc", null, false, 1);
                    if (dsTmp.tAbnObjReg.Rows.Count > 0 && dsTmp.tAbnObjReg.Rows[0]["idAbnServicing"] != DBNull.Value)
                        this.SelectSqlData(dsAbn.tAbnContact, true, " where idAbn = " + dsTmp.tAbnObjReg.Rows[0]["idAbnServicing"].ToString() + " and Author = " + Constants.Constants.AuthorContact_CS.ToString() + " order by DateChange desc");
                    else
                        dsAbn.tAbnContact.Clear();
                    break;
                case 4: // только контакты ОДС
                    this.SelectSqlData(dsAbn.tAbnContact, true, " where idAbn = " + ID.ToString() + " and Author = " + Constants.Constants.AuthorContact_ODS.ToString() + "  order by DateChange desc");
                    break;

                default:
                    dsAbn.tAbnContact.Clear();
                    break;
            }
        }
        #endregion

        private void tsbImage_Click(object sender, EventArgs e)
        {
            if (dgvAbnDoc.RowCount > 0)
            {
                int IDABN = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
                int IDTYPE = Convert.ToInt32(dgvAbnDoc.CurrentRow.Cells["idDocTypeDGVTBC"].Value);
                int IDLIST = Convert.ToInt32(dgvAbnDoc.CurrentRow.Cells["idDocDGVTBC"].Value);
                Document.FormAbnDogScan fImage = new Document.FormAbnDogScan(IDABN, IDLIST, IDTYPE);
                fImage.SqlSettings = this.SqlSettings;
                fImage.ShowDialog();
            }
        }

        #region Файлы контрагента

        private int inFolder = 0;
        private int parID;

        private void RefreshFolder()
        {
            if (inFolder == 0)
            {
                SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and ParentID = 0 and idAbn = " + ID.ToString() + " order by IsGroup desc,ParentId asc ");
                return;
            }

            SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and (id = " + parID.ToString() + "  or  ParentID = " + parID.ToString() + " ) order by IsGroup desc,ParentId asc ");
        }


        private void tsbAbnFiles_Click(object sender, EventArgs e)
        {
            if (AbnMiniDGV.RowCount > 0)
            {

                Document.FormAbnFiles fFiles = new Document.FormAbnFiles(Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value));
                fFiles.SqlSettings = this.SqlSettings;
                if (fFiles.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        Dictionary<string, FileWatcherArgsAddl> files = new Dictionary<string, FileWatcherArgsAddl>();

        private void tsbAddFile_Click(object sender, EventArgs e)
        {
            AddFileDialog();
        }

        private void AddFileDialog()
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Multiselect = true;
            if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in dlgOpen.FileNames)
                {
                    string filename = AddFile(fileName, null, null, true);
                }
            }
        }
        private string AddFile(string fileName, int? idTemplate = null, byte[] fileData = null, bool saveAndListen = false)
        {
            string shortFileName = System.IO.Path.GetFileName(fileName);
            bool isAdd = true;
            while ((SelectSqlData("tAbn_Files", true, String.Format("where idAbn = {0} AND FileName = '{1}'", ID, shortFileName)).Rows.Count > 0
                || files.ContainsKey(shortFileName)) && saveAndListen)  // если есть такой файл....
            {
                if (MessageBox.Show("Файл с именем " + shortFileName + " уже существует. Изменить имя файла на другое?", "Внимание.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    FormNewFileName frmNewFileName = new FormNewFileName(shortFileName);
                    if (frmNewFileName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        shortFileName = frmNewFileName.FileName;
                }
                else
                {
                    isAdd = false;
                    break;
                }
            }
            if (!isAdd) return null;

            if (saveAndListen)
            {
                FileWatcherArgsAddl f = new FileWatcherArgsAddl(idTemplate, shortFileName, null, FileOpenState.None);
                files.Add(shortFileName, f);

                var row = dsAbn.tAbn_Files.NewtAbn_FilesRow();
                row.idAbn = ID;
                row.FileName = shortFileName;
                row.Deleted = 0;
                row.IsGroup = 0; 

                if (inFolder == 0) row.ParentID = 0; 
                else
                {
                    parID = Convert.ToInt32(dgvAbnFiles["idAbnFile", 0].Value);
                    row.ParentID = parID;
                }

                if (fileData == null)
                {
                    FileBinary file = new FileBinary(fileName);
                    row.File = file.ByteArray;
                    row.Date = file.LastChanged;
                }
                else
                {
                    row.File = fileData;
                    row.Date = DateTime.Now;
                }

                dsAbn.tAbn_Files.AddtAbn_FilesRow(row);
                foreach (var item in dsAbn.tAbn_Files)
                {
                    item.EndEdit();
                }
                int idFile = InsertSqlDataOneRow(dsAbn, dsAbn.tAbn_Files);
                RefreshFolder();//SelectSqlData(dsAbn.tAbn_Files, true, "where idAbn = " + idAbn);
                bsAbn_Files.Position = bsAbn_Files.Find("id", idFile);
                dsAbn.tAbn_Files.Where(r => r.id == idFile).ToList().ForEach(r => { r.AcceptChanges(); r.SetModified(); });
            }
            return shortFileName;
        }


        private void OpenFile(bool isEdit = false)
        {
            if (bsAbn_Files.Current != null)
            {

                DataSetAbn.tAbn_FilesRow r = (DataSetAbn.tAbn_FilesRow)((DataRowView)bsAbn_Files.Current).Row;

                string fileName = r.FileName;
                string folderName = GetDirectoryPath();
                string tmpfileName = FileBinary.GetNewFileNameIsExists(folderName, fileName);

                DateTime dateChange = r.Date;

                byte[] fileData;
                try
                {
                    fileData = r.File;
                }
                catch
                {
                    MessageBox.Show("Нет содержимого файла");
                    return;
                }

                FileBinary file = new FileBinary(fileData, tmpfileName, DateTime.Now);
                // Записали файл во временную папку
                file.SaveToDisk(folderName);
                // Запустили файл
                Process.Start(folderName + "\\" + file.Name);

            }
        }

        private string GetDirectoryPath()
        {
            string dir = ((DataRowView)bsAbn_Files.Current)["idAbn"] is string &&
                string.IsNullOrEmpty(((DataRowView)bsAbn_Files.Current)["idAbn"].ToString()) ?
                ((DataRowView)bsAbn_Files.Current)["idAbn"].ToString() : "tmp";
            var path = System.IO.Path.GetTempPath() + "\\" + dir + "\\";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            return path;
        }

        private void dgvAbnFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int isG = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["isGroup"].Value);
            parID = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["idAbnFile"].Value);

            if (isG == 0)
            {
                OpenFile();
                return;
            }

            if (isG == 1)
            {
                if ((int)dgvAbnFiles.CurrentCell.RowIndex == 0 && inFolder != 0)
                {
                    parID = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["ParentId"].Value);
                    inFolder--;
                }
                else inFolder++; ;
                if (inFolder == 0)
                {
                    SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and ParentID = 0 and idAbn = " + ID.ToString() + " order by IsGroup desc,ParentId asc ");
                    return;
                }

                SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and (id = " + parID.ToString() + "  or  ParentID = " + parID.ToString() + " ) order by IsGroup desc,ParentId asc ");
            }
        }

        private void dgvAbnFiles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (((DataGridView)sender).RowCount > 0) // есть строки
            {
                if (dgvAbnFiles[fileName.Name, e.RowIndex].Value != null && Convert.ToInt32(dgvAbnFiles.Rows[e.RowIndex].Cells["isGroup"].Value) != 1)
                {
                    if (e.ColumnIndex == dgvAbnFiles.Columns[imageFile.Name].Index) // столбец картинки
                    {
                        if (!string.IsNullOrEmpty(System.IO.Path.GetFileName(dgvAbnFiles[fileName.Name, e.RowIndex].Value.ToString())))
                            e.Value = System.IO.Path.GetFileName(dgvAbnFiles[fileName.Name, e.RowIndex].Value.ToString());
                        else
                            e.Value = dgvAbnFiles[fileName.Name, e.RowIndex].Value.ToString();
                    }
                    if (e.ColumnIndex == dgvAbnFiles.Columns[imageFile.Name].Index) // столбец картинки
                    {
                        Icon ico = FormLbr.Classes.FileInfo.IconOfFile(dgvAbnFiles[fileName.Name, e.RowIndex].Value.ToString());
                        if (ico != null) e.Value = ico.ToBitmap();

                    }
                }

                if (Convert.ToInt32(dgvAbnFiles.Rows[e.RowIndex].Cells["isGroup"].Value) == 1)
                {
                    e.CellStyle.ForeColor = Color.Blue;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    if (inFolder > 0 && e.RowIndex == 0)
                    {
                        e.CellStyle.BackColor = Color.LightGray;
                        e.CellStyle.SelectionBackColor = Color.Purple;

                    }
                    if (e.ColumnIndex == dgvAbnFiles.Columns[imageFile.Name].Index) e.Value = imageListFiles.Images["folder.ico"]; // столбец картинки
                    
                }
            }
        }

        private void tsbOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsbDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void DeleteFile()
        {
            if (dgvAbnFiles.SelectedRows != null && dgvAbnFiles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные файлы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    //foreach (DataGridViewRow dgvRow in dgvAbnFiles.SelectedRows)
                    //{
                    //    var rows = dsAbn.tAbn_Files.Where<DataSetAbn.tAbn_FilesRow>(r => r.RowState != DataRowState.Deleted && r.id == (int)dgvRow.Cells["idAbnFile"].Value);

                    //    if (rows.Count() > 0)
                    //    {
                    //        DataSetAbn.tAbn_FilesRow r = rows.First();
                    //        string fileName = r.FileName;
                    //        if (files.ContainsKey(fileName))
                    //        {
                    //            if (files[fileName].Watcher != null)
                    //            {
                    //                files[fileName].Watcher.Stop();
                    //            }
                    //            files.Remove(fileName);
                    //        }
                    //        r.Delete();
                    //        r.EndEdit();
                    //    }
                    //}
                    //DeleteSqlData(dsAbn, dsAbn.tAbn_Files);

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tAbn_Files, true, "where id = " + dgvAbnFiles.CurrentRow.Cells["idAbnFile"].Value.ToString());
                    ds.tAbn_Files.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tAbn_Files.Rows[0]["Deleted"]);
                    ds.tAbn_Files.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tAbn_Files))
                    {
                        if (Convert.ToBoolean(ds.tAbn_Files.Rows[0]["Deleted"])) MessageBox.Show("Файл успешно удален");

                    }

                    RefreshFolder();
                }
            }
        }

        string oldFileName = "";
        private void tsbRenameFile_Click(object sender, EventArgs e)
        {
            RenameFile();
        }
        private void RenameFile()
        {
            if (dgvAbnFiles.CurrentRow != null)
            {
                oldFileName = dgvAbnFiles.CurrentRow.Cells[fileName.Name].Value.ToString();
                dgvAbnFiles.CurrentCell = dgvAbnFiles.CurrentRow.Cells[fileName.Name];
                dgvAbnFiles.CurrentCell.Value = System.IO.Path.GetFileNameWithoutExtension(oldFileName);
                dgvAbnFiles.ReadOnly = false;
                dgvAbnFiles.ReadOnly = false;
                dgvAbnFiles.BeginEdit(true);
            }
        }

        private void tsbSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            if (bsAbn_Files.Current != null)
            {

                DataSetAbn.tAbn_FilesRow r = (DataSetAbn.tAbn_FilesRow)((DataRowView)bsAbn_Files.Current).Row;
                if (r["File"] == DBNull.Value)
                {
                    MessageBox.Show("Нет содержимого файла");
                    return;
                }
                byte[] fileData = r.File;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = r.FileName;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    ByteArrayToFile(dialog.FileName, fileData);

            }
        }


        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                // Open file for reading
                System.IO.FileStream _FileStream =
                   new System.IO.FileStream(fileName, System.IO.FileMode.Create,
                                            System.IO.FileAccess.Write);
                // Writes a block of bytes to this stream using data from
                // a byte array.
                _FileStream.Write(byteArray, 0, byteArray.Length);

                // close file stream
                _FileStream.Close();

                return true;
            }
            catch (Exception _Exception)
            {
                MessageBox.Show(_Exception.Message, _Exception.Source);
                _Exception.ToString();
            }

            // error occured, return false
            return false;
        }

        private void AddFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFileDialog();
        }

        private void EditNAmeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameFile();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void DeleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void dgvAbnFiles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                dgvAbnFiles.ClearSelection();
                dgvAbnFiles.Rows[e.RowIndex].Selected = true;
                dgvAbnFiles.CurrentCell = dgvAbnFiles[e.ColumnIndex, e.RowIndex];
                Rectangle r = dgvAbnFiles.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                contextMenuStripAbnFiles.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            }
        }

        private void dgvAbnFiles_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(oldFileName))
                {
                    string newFileName = e.FormattedValue + System.IO.Path.GetExtension(oldFileName);
                    if (newFileName == oldFileName) return;

                    if (files.ContainsKey(newFileName))
                    {
                        MessageBox.Show("Файл с таким именем уже существует", "");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dgvAbnFiles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvAbnFiles.ReadOnly = true;
            fileName.ReadOnly = true;
            if (dgvAbnFiles[e.ColumnIndex, e.RowIndex].Value != null)
            {
                string newFileName = dgvAbnFiles[e.ColumnIndex, e.RowIndex].Value.ToString() + System.IO.Path.GetExtension(oldFileName);
                if (newFileName == oldFileName)
                {
                    dgvAbnFiles[e.ColumnIndex, e.RowIndex].Value = oldFileName;
                    return;
                }

                if (files.ContainsKey(oldFileName))
                {
                    FileWatcherArgsAddl fw = files[oldFileName];
                    fw.OriginalName = newFileName;
                    files.Remove(oldFileName);
                    files.Add(newFileName, fw);
                }
                dgvAbnFiles[e.ColumnIndex, e.RowIndex].Value = newFileName;
                foreach (DataSetAbn.tAbn_FilesRow row in dsAbn.tAbn_Files)
                {
                    row.EndEdit();
                }
                UpdateSqlData(dsAbn, dsAbn.tAbn_Files);

            }
            oldFileName = null;
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idF = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["idAbnFile"].Value);
            Document.FormAbnFilesSelectFolder fFolder ;
            if (inFolder == 0) fFolder = new Document.FormAbnFilesSelectFolder(ID, idF);
                          else fFolder = new Document.FormAbnFilesSelectFolder(ID, parID);
            fFolder.SqlSettings = this.SqlSettings;
            if (fFolder.ShowDialog() == DialogResult.OK)
            {
                
                if (dsAbn.tAbn_Files.Rows.Count > 0)
                {

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tAbn_Files, true, "where id = " + idF);
                    ds.tAbn_Files.Rows[0]["ParentID"] = ((int)fFolder.SelectedFolder == 510) ? 0 : (int)fFolder.SelectedFolder;
                    ds.tAbn_Files.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tAbn_Files))
                    {

                        RefreshFolder();

                    }
                }

            }
        }

        private void FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inFolder == 0)
            {
                Document.FormAbnFilesAddEditFolder fFolder = new Document.FormAbnFilesAddEditFolder(ID, 0, true);
                fFolder.SqlSettings = this.SqlSettings;
                if (fFolder.ShowDialog() == DialogResult.OK)
                {
                    RefreshFolder();
                }
            }
            else
            {
                Document.FormAbnFilesAddEditFolder fFolder = new Document.FormAbnFilesAddEditFolder(ID, parID, true);
                fFolder.SqlSettings = this.SqlSettings;
                if (fFolder.ShowDialog() == DialogResult.OK)
                {
                    RefreshFolder();
                }
            }
        }

        private void tsbRootFolder_Click(object sender, EventArgs e)
        {
            inFolder = 0;
            RefreshFolder();
        }

        private void dgvAbnFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
            {
                int isG = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["isGroup"].Value);
                parID = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["idAbnFile"].Value);

                if (isG == 0)
                {
                    OpenFile();
                    return;
                }

                if (isG == 1)
                {
                    if ((int)dgvAbnFiles.CurrentCell.RowIndex == 0 && inFolder != 0)
                    {
                        parID = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["ParentId"].Value);
                        inFolder--;
                    }
                    else inFolder++; ;
                    if (inFolder == 0)
                    {
                        SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and ParentID = 0 and idAbn = " + ID.ToString() + " order by IsGroup desc,ParentId asc ");
                        return;
                    }

                    SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and (id = " + parID.ToString() + "  or  ParentID = " + parID.ToString() + " ) order by IsGroup desc,ParentId asc ");
                }
            }
        }

        private void toolStripSplitButtonAdd_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButtonAdd.ShowDropDown();
        }

        #endregion

        private void ClearFieldObject()
        {
            // если нет объектов, очищаем поля-реквизиты объекта
            // верхняя панель
            ObjTariffSTB.Text = "";
            TP_STB.Text = "";
            ObjDogovorSTB.Text = "";
            ObjDogNumberSTB.Text = "";
            ObjCategorySTB.Text = "";
            MastertSTB.Text = "";

            // первая страница
            txtParent.Text = "";
            txtCity.Text = "";
            txtIndex.Text = "";
            txtRaion.Text = "";
            txtHouse.Text = "";
            txtStreet.Text = "";
            ObjCommentrtb.Text = "";
            ObjNettextBox.Text = "";
            ObjSaletextBox.Text = "";
            textBox5.Text = "";
            txtLatitude.Text = "";
            txtLongitude.Text = "";

            // вторая страница - приборы учета
            dsAbn.vG_ObjMeter.Rows.Clear();
            dsAbn.vG_ObjTrans.Rows.Clear();
            dsAbn.vPointPlomb.Rows.Clear();
            dsAbnObjAkt1.vG_MeasurementsOfCounters.Rows.Clear();
            dsAbn.vG_TariffPoint.Rows.Clear();
            dsAbn.vG_PointKLossTrans.Rows.Clear();
            dsAbn.vG_MeterValAll.Rows.Clear();

            MeterDatatextBox.Text = "";
            MeterDigittextBox.Text = "";
            GosPovtextBox.Text = "";
            TransGosPovtextBox.Text = "";
            TransTypetextBox.Text = "";

            // третья страница - начисления
            dsAbn.vG_SchetAll.Rows.Clear();
            ObjKLossTB.Text = "";
            ObjRegtimeTB.Text = "";
            ObjPowerSetTB.Text = "";
            ObjPowerFactTB.Text = "";

            // четвертая страница - заявленная мощность
            dsAbn.tG_ObjMax.Rows.Clear();

            // пятая страница - документы
            dsAbn.vAbnObjDoc_List.Rows.Clear();

            // шестая страница - признаки
            dsAbn.vG_AbnObjFlags.Rows.Clear();
            dsAbn.tAbnObjFlags.Rows.Clear();

            // седьмая страница - ограничения
            dsAbnObjAkt1.vG_LimitingConsumption.Rows.Clear();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AbnMiniDGV.CurrentRow.Cells["AbnidDGVTBC"].Value);
            bool flag;
            if (dsAbnDocum1.tG_AbnNameODS.Rows.Count > 0)
                flag = false;
            else
                flag = true;

            FormAbnNameODS fAdd = new FormAbnNameODS(id, flag);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbnDocum1.tG_AbnNameODS, true, " where idAbn = " + ID.ToString());
            }
        }

        private void txtNameODS_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmiCalcLoss_Click(object sender, EventArgs e)
        {

        }

        private void objMeterdgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < objMeterdgv.RowCount)
            {
                if (objMeterdgv.Rows[e.RowIndex].Cells["antiPlomb"].Value != DBNull.Value)
                    if (objMeterdgv.Rows[e.RowIndex].Cells["antiPlomb"].Value.ToString() == "A")
                    {
                        //((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.Font = new Font(objMeterdgv.DefaultCellStyle.Font, FontStyle.Bold);
                        ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    }
            }
        }

        private void dataGridViewMeterPlomb_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dataGridViewMeterPlomb.RowCount)
            {
                if (dataGridViewMeterPlomb.Rows[e.RowIndex].Cells["commentDataGridViewTextBoxColumn1"].Value != DBNull.Value)
                    if (dataGridViewMeterPlomb.Rows[e.RowIndex].Cells["commentDataGridViewTextBoxColumn1"].Value.ToString().EndsWith("(антимагнитная)"))
                    {
                        //((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.Font = new Font(objMeterdgv.DefaultCellStyle.Font, FontStyle.Bold);
                        ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    }
            }

        }



 
    }
}
