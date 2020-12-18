using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Constants;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;
using FormLbr.Classes;
using System.Diagnostics;
using Legal.DataSet;

namespace Legal.Forms.Document
{
    public partial class FormActBalance : FormLbr.FormBase
    {
        public static FormActBalance instance;
        public int idPar = -1;
        public int IDLIST = -1;
        public int OBJSELECT = -1;
        public int ABNSELECT = -1;
        private string CODE = "";
        //bool isSave = false;


        public FormActBalance()
        {
            InitializeComponent();
            instance = this;
        }

        // загрузка источника данных для грида

        private void FormActBalance_Load(object sender, EventArgs e)
        {
            ActListLoad();
            LoadFileNameTemplate();
        }

        // поиск записи в гриде
        private void dgvFind(int idList)
        {
            bsListAct.Position = bsListAct.Find("IdList", idList);
            LoadActsByAbn(idList);
        }

        // просмотр акта
        private void tsbView_Click(object sender, EventArgs e)
        {
            Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, 1, IDLIST, true);
            frmAktRBP.MdiParent = this.MdiParent;
            frmAktRBP.Show();
        }

        // кнопка экспорта в Word
        private void tsbToWord_Click(object sender, EventArgs e)
        {
            //CreateActRbp(ExportToWord.WithoutFileName);
        }

        // создание акта в Word
        public void CreateActRbp(string AbnName, string fullFileName)
        {
            if (dgvListAct.SelectedRows != null && dgvListAct.SelectedRows.Count > 0)
            {
                // переменные
                #region
                // телефон потребителя
                String PhoneNumber = "";
                string dateDoc = "";
                string numDoc = "";
                string powerMax = "";
                string powerNom = "";
                // для потребителей имеющих договор по транспорту
                String Dogovor = "";
                // адрес потребителя
                string AbnAddress = "";
                #endregion

                // подготовим данные для экспорта
                #region

                // определим владельцев акта - абонента и объект 
                int idAbn = ((DataRowView)bsListAct.Current)["idAbn"] == DBNull.Value
                    ? -1 : Convert.ToInt32(((DataRowView)bsListAct.Current)["idAbn"]);
                int idAbnObj = ((DataRowView)bsListAct.Current)["idAbnObj"] == System.DBNull.Value
                    ? -1 : Convert.ToInt32(((DataRowView)bsListAct.Current)["idAbnObj"]);

                if (idAbn != -1)
                {
                    DocType docType = DocType.Dogovor;
                    // привязка к договору по транспорту
                    SelectSqlData(dsAbnObjAkt1.tAbnDoc_List, true, String.Format(" where idAbn = {0} and idDocType = {1} and isActive <> 0 and Deleted = 0", idAbn, (int)docType), null, true);
                    if (dsAbnObjAkt1.tAbnDoc_List.Rows.Count > 0)
                        Dogovor = String.Format("Приложение №4 к договору № {0} от {1} г.", dsAbnObjAkt1.tAbnDoc_List.First().DocNumber.Trim(), dsAbnObjAkt1.tAbnDoc_List.First().DocDate.ToShortDateString());

                    // добавим юридический адрес
                    SelectSqlData(dsAbnDocum1.tG_AbnAddress, true, String.Format(" where idAbn = {0} and idTypeAddress = {1} order by DateChange desc", idAbn, 54), null, true);
                    if (dsAbnDocum1.tG_AbnAddress.Count > 0)
                        AbnAddress = dsAbnDocum1.tG_AbnAddress.First().Representation;

                    // определим номер телефона
                    SelectSqlData(dsAbnDocum1.tAbnContact, true, " where idAbn = " + idAbn + " and Post LIKE 'ОДС'", null, true);
                    if (dsAbnDocum1.tAbnContact.Count > 0)
                        PhoneNumber = dsAbnDocum1.tAbnContact.First().Phone;
                }
                // все данные акта
                SelectSqlData(dsAbnObjAkt1.tAbnObjDoc_AktRBP, true, String.Format(" where idList = {0}", IDLIST), null, true);

                if (dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["idActTehConnection"] is int)
                {
                    SelectSqlData(dsAbnObjAkt1.tTC_Doc, true, String.Format("WHERE id = {0}", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().idActTehConnection));
                    if (dsAbnObjAkt1.tTC_Doc.Rows.Count > 0)
                    {
                        dateDoc = dsAbnObjAkt1.tTC_Doc.First()["dateDoc"] == DBNull.Value
                            ? "" : dsAbnObjAkt1.tTC_Doc.First().dateDoc.ToShortDateString();
                        numDoc = dsAbnObjAkt1.tTC_Doc.First()["numDoc"] == DBNull.Value
                            ? "" : dsAbnObjAkt1.tTC_Doc.First().numDoc.ToString();
                    }

                    SelectSqlData(dsAbnObjAkt1.tTC_ActTC, true, String.Format("WHERE id = {0}", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().idActTehConnection));
                    if (dsAbnObjAkt1.tTC_ActTC.Rows.Count > 0)
                    {

                        powerMax = dsAbnObjAkt1.tTC_ActTC.First()["PowerSum"] == DBNull.Value
                            ? "" : dsAbnObjAkt1.tTC_ActTC.First().PowerSum.ToString();
                        powerNom = "";
                    }

                    SelectSqlData(dsAbnObjAkt1.vTC_TUPointAttach, true, String.Format(
                        "WHERE idTU = {0} and (typeDoc is null or typeDoc = {1})", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().idActTehConnection, (int)Classes.eTypeDoc.ActTehConnection));
                }
                #endregion

                // создание документа Word на основе шаблона и заполнение полей данными
                #region

                OfficeLB.Word.Application word = null;
                OfficeLB.Word.Selection selection = null;
                try
                {
                    /// Инициализируем экземпляр класса Application и запускаем приложение Word
                    word = new OfficeLB.Word.Application();
                    //                   word.Visible = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("Отсутствует предустановленный MS Office Word", "Ошибка MS Office", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (word != null)
                {
                    try
                    {
                        word.Documents.Open(fullFileName);
                        selection = word.Selection;
                        if (Dogovor.Length > 0)
                            selection.FindAndReplace("[Привязка_кдоговору]", Dogovor, true);
                        else
                        {
                            selection.FindAndReplace("[Привязка_кдоговору]", "", true);
                        }
                        if (AbnName.Length == 0)
                            selection.FindAndReplace("[Абонент_наименование]", "                                                        ,", true);
                        else
                            selection.FindAndReplace("[Абонент_наименование]", AbnName + " " + AbnAddress, true);
                        selection.FindAndReplace("[Телефон]", "32-32-34", true);
                        selection.FindAndReplace("[Телефон2]", PhoneNumber, true);

                        // заполняем поля в шаблоне
                        #region
                        string NumberAct_Region = "";
                        string NumberAct_Date = "";
                        string NumberAct = "";
                        // двухсторонний акт   

                        DataTable dt = SelectSqlData("tR_Classifier", true, "WHERE id = " + dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().NetRegion.ToString());

                        NumberAct_Region = dt.Rows.Count > 0 ? Math.Round((decimal)dt.Rows[0]["Value"], 0).ToString() : "";

                        selection.FindAndReplace("[Номер_района]", NumberAct_Region, true);
                        /// Имя начальника района на подпись
                        String RegionSign = "";

                        SelectSqlData(dsAbnObjAkt1.vP_Worker, true, String.Format(" where ParentKey = ';GroupWorker;HeadRegionApart;' AND Value = {0}",
                            dt.Rows.Count > 0 ? dt.Rows[0]["Value"].ToString().Replace(',', '.') : "-1"),null, true);
                        if (dsAbnObjAkt1.vP_Worker.Rows.Count > 0)
                            RegionSign = dsAbnObjAkt1.vP_Worker.Rows[0]["FIO"].ToString().Trim();

                        selection.FindAndReplace("[Начальник_района]", RegionSign, true);
                        selection.FindAndReplace("[Дата_Акта]", DateTime.Parse(dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().ActData).ToShortDateString(), true);
                        NumberAct_Date = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().ActData;
                        NumberAct = NumberAct_Region + "/" + dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().DataNumber + "/" + DateTime.Parse(NumberAct_Date).Year.ToString().Substring(2, 2);
                        selection.FindAndReplace("[Номер_Акта]", NumberAct, true);

                        if (dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["OrgFace"] == DBNull.Value || dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgFace.Length == 0)
                            selection.FindAndReplace("[Потребитель_влице]", "                                                        ,", true);
                        else
                            selection.FindAndReplace("[Потребитель_влице]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgFace, false);

                        if (dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["OrgBase"] == DBNull.Value || dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBase.Length == 0)
                            selection.FindAndReplace("[Потребитель_Основание]", "                              ,", true);
                        else
                            selection.FindAndReplace("[Потребитель_Основание]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBase, false);

                        //selection.FindAndReplace("[Потребитель_влице]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgFace, true);
                        //selection.FindAndReplace("[Потребитель_Основание]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBase, true);
                        selection.Find.ClearFormatting();
                        selection.Find.Text = "[Сетевая_оборудование]";
                        if (selection.Find.Execute())
                        {
                            selection.FindAndReplace("[Сетевая_оборудование]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBalance, false);
                            selection.FindAndReplace("[Сетевая_оборудование]", "", true);
                        }
                        selection.Find.ClearFormatting();
                        selection.Find.Text = "[Потребитель_оборудование]";
                        if (selection.Find.Execute())
                        {
                            selection.FindAndReplace("[Потребитель_оборудование]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrBalance, false);
                            selection.FindAndReplace("[Потребитель_оборудование]", "", true);
                        }
                        selection.Find.ClearFormatting();
                        selection.Find.Text = "[Граница]";
                        if (selection.Find.Execute())
                        {
                            selection.FindAndReplace("[Граница]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().BorderBalance, false);
                            selection.FindAndReplace("[Граница]", "", true);
                        }
                        selection.FindAndReplace("[Сетевая_эксплуатация]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgExpl, false);
                        selection.FindAndReplace("[Сетевая_эксплуатация]", "", true);
                        selection.FindAndReplace("[Потребитель_эксплуатация]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrExpl, false);
                        selection.FindAndReplace("[Потребитель_эксплуатация]", "", true);
                        selection.FindAndReplace("[Ответственность]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Responsibility, false);
                        selection.FindAndReplace("[Ответственность]", "", true);
                        if (selection.FindAndReplace("[Ответственность2]", "[Ответственность2]", true))
                        {
                            selection.FindAndReplace("[Ответственность2]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Responsibility, false);
                        }
                        selection.FindAndReplace("[Потребитель_допуск]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Admission, false);
                        selection.FindAndReplace("[Потребитель_допуск]", "", true);
                        selection.FindAndReplace("[Потребитель_подпись]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrSignature, true);

                        #region NewAct
                        selection.FindAndReplace("[Дата тех прис]", dateDoc.Length == 0 ? "                  " : dateDoc, true);
                        selection.FindAndReplace("[Номер тех прис]", numDoc.Length == 0 ? "                  " : numDoc, true);
                        selection.FindAndReplace("[Макс мощность]", powerMax.Length == 0 ? "        " : powerMax, true);
                        selection.FindAndReplace("[Ном мощность]", powerNom.Length == 0 ? "        " : powerNom, true);
                        selection.FindAndReplace("[Адрес границы]", "                                                                                   ", true);
                        if (dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["Other"] == DBNull.Value || dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Other.Length == 0)
                            selection.FindAndReplace("[Прочее]", "                                                                                   ", true);
                        else
                            selection.FindAndReplace("[Прочее]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Other, false);

                        if (word.ActiveDocument.Tables.Count == 3
                            && word.ActiveDocument.Tables[1].Columns.Count == 7
                            && word.ActiveDocument.Tables[2].Columns.Count == 2
                            && word.ActiveDocument.Tables[3].Columns.Count == 1)
                        {
                            OfficeLB.Word.Table tablePA = word.ActiveDocument.Tables[1];

                            for (int i = 0; i < dsAbnObjAkt1.vTC_TUPointAttach.Count; i++)
                            {
                                OfficeLB.Word.Row row = null;
                                row = tablePA.Rows[i + 2];
                                OfficeLB.Word.Range rng = row.Cells[1].Range;
                                row.Cells[1].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["AttachmentPoint"].ToString();
                                row.Cells[2].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["PowerSupply"].ToString();
                                row.Cells[3].Range.Text = "";
                                row.Cells[4].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["voltagelevelname"].ToString();
                                row.Cells[5].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["powersum"].ToString();
                                row.Cells[6].Range.Text = "";
                                row.Cells[7].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["Category"].ToString();

                                if (tablePA.Rows.Count != dsAbnObjAkt1.vTC_TUPointAttach.Count + 1)
                                {
                                    tablePA.Rows.Add();
                                }
                            }

                            OfficeLB.Word.Table tableEquipment = word.ActiveDocument.Tables[2];

                            tableEquipment.Rows[2].Cells[1].Range.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["OrgBalance"] == DBNull.Value
                                ? "" : dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBalance;
                            tableEquipment.Rows[2].Cells[2].Range.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["PotrBalance"] == DBNull.Value
                                ? "" : dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrBalance;
                        }

                        #endregion

                        // трехсторонний акт
                        selection.FindAndReplace("[Владелец_имя]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerName, true);
                        selection.FindAndReplace("[Владелец_влице]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief, true);
                        selection.FindAndReplace("[Владелец_основание]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerBase, true);
                        selection.FindAndReplace("[Владелец_оборудование]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrganizExpl, false);
                        selection.FindAndReplace("[Владелец_оборудование]", "", true);
                        selection.FindAndReplace("[Владелец_эксплуатация]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrebExpl, false);
                        selection.FindAndReplace("[Владелец_эксплуатация]", "", true);
                        selection.FindAndReplace("[Граница2]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().BorderExpl, false);
                        selection.FindAndReplace("[Граница2]", "", true);
                        selection.FindAndReplace("[Владелец_подпись]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief2, true);

                        // Дополнительные поля для акта c ТО
                        selection.FindAndReplace("[Номер_ОТО]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbDogByOTONum, false);
                        selection.FindAndReplace("[Номер_ОТО]", "", true);
                        selection.FindAndReplace("[Договор_ОТО2]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbTO2, false);
                        selection.FindAndReplace("[Договор_ОТО2]", "", true);
                        selection.FindAndReplace("[Договор_OTO1]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbTO1, false);
                        selection.FindAndReplace("[Договор_OTO1]", "", true);

                        // Четырехсторонний акт
                        selection.FindAndReplace("[Владелец2_имя]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerName_Four, true);
                        selection.FindAndReplace("[Владелец2_влице]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief2_Four, true);
                        selection.FindAndReplace("[Владелец2_основание]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerBase_Four, true);
                        selection.FindAndReplace("[Владелец2_оборудование]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrganizExpl_Four, false);
                        selection.FindAndReplace("[Владелец2_оборудование]", "", true);
                        selection.FindAndReplace("[Владелец2_эксплуатация]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerExpl_Four, false);
                        selection.FindAndReplace("[Владелец2_эксплуатация]", "", true);
                        selection.FindAndReplace("[Граница3]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Border2Expl_Four, false);
                        selection.FindAndReplace("[Граница3]", "", true);
                        selection.FindAndReplace("[Владелец2_подпись]", dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief2_Four, true);

                        #endregion
                    }
                    catch (Exception ex)
                    {
#if DEBUG
                        MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                        MessageBox.Show("Не удалось создать документ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                    }

                    selection = null;

                    try
                    {
                        word.ActiveDocument.Save();
                        word.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        word.Quit();
#if DEBUG
                        MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                        MessageBox.Show("Не удалось сохранить документ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                    }
                }
                #endregion
            }
        }



        private String GetAbnName(int idAbn)
        {
            string AbnName = "";
            // наименование абонента
            SelectSqlData(dsAbnObjAkt1.vAbn, true, String.Format(" where id = {0}", idAbn), null, true);
            if (dsAbnObjAkt1.vAbn.Rows.Count > 0)
                AbnName = dsAbnObjAkt1.vAbn.First().Name.Trim();
            return AbnName;
        }

        // просмотр акта по двойному клику мыши
        private void dgvListAct_DoubleClick(object sender, EventArgs e)
        {

        }

        // добавление нового акта разграничения балансовой принадлежности
        private void tssbAddActBalance_Click(object sender, EventArgs e)
        {
            FormObjFind f = new FormObjFind();
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                    new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, true, true, ABNSELECT, OBJSELECT, TypeDocValue.ActBalance);
                frmAktRBP.Owner = this;
                frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                frmAktRBP.MdiParent = this.MdiParent;
                frmAktRBP.Show();
            }
        }

        // добавление нового акта разграничения эксплуатационной ответственности
        private void tssbAddActLiability_Click(object sender, EventArgs e)
        {
            FormObjFind f = new FormObjFind();
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                    new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, true, true, ABNSELECT, OBJSELECT, TypeDocValue.ActLiability);
                frmAktRBP.Owner = this;
                frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                frmAktRBP.MdiParent = this.MdiParent;
                frmAktRBP.Show();
            }
        }

        void frmAktRBP_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((Form)sender).DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                ActListLoad();
                dgvFind(sender is Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP ? 
                    ((Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP)sender).IdList : -1);
                //LoadActsByAbn();
            }
        }

        // редактирование акта
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvListAct.SelectedRows != null && dgvListAct.SelectedRows.Count > 0 && IDLIST != -1)
            {
                Int32 idObj = 0;
                if (((DataRowView)bsListAct.Current)["idAbnObj"] != System.DBNull.Value)
                    idObj = Convert.ToInt32(((DataRowView)bsListAct.Current)["idAbnObj"]);
                Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                    new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, idObj, IDLIST);
                frmAktRBP.MdiParent = this.MdiParent;
                frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                frmAktRBP.Show();
            }
        }

        // удаление акта
        private void tsbDel_Click(object sender, EventArgs e)
        {
            if (dgvListAct.SelectedRows != null && dgvListAct.SelectedRows.Count > 0
                && MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int DocIndex = dgvListAct.CurrentRow.Index;

                DataSet.dsAbnObjAct ds = new Legal.DataSet.dsAbnObjAct();

                this.SelectSqlData(ds, ds.tAbnObjDoc_List, true, "where id = " + IDLIST);
                ds.tAbnObjDoc_List.First().Deleted = !ds.tAbnObjDoc_List.First().Deleted;
                ds.tAbnObjDoc_List.Rows[0].EndEdit();
                if (this.UpdateSqlData(ds, ds.tAbnObjDoc_List))
                {
                    if (ds.tAbnObjDoc_List.First().Deleted)
                    {
                        ActListLoad();
                        MessageBox.Show("Документ успешно удален");
                    }
                    else
                    {
                        ActListLoad();
                        MessageBox.Show("Документ успешно восстановлен");
                    }
                    ActListLoad();
                }
            }
        }

        // копирование акта
        private void tsbCopy_Click(object sender, EventArgs e)
        {
            if (dgvListAct.SelectedRows != null && dgvListAct.SelectedRows.Count > 0)
            {
                FormObjFind f = new FormObjFind();
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;

                if (f.ShowDialog() == DialogResult.OK)
                {
                    // скопируем данные в новый акт и откроем его для редактирования
                    // в новом акте установим новый номер акта(последний для сетевого района)
                    Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                        new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, OBJSELECT, IDLIST, ABNSELECT);
                    frmAktRBP.Owner = this;
                    frmAktRBP.MdiParent = this.MdiParent;
                    frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                    frmAktRBP.Show();
                }
            }
        }

        // перенос акта
        private void tsbMove_Click(object sender, EventArgs e)
        {
            if (dgvListAct.SelectedRows != null && dgvListAct.SelectedRows.Count > 0)
            {
                FormObjFind f = new FormObjFind();
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;

                if (f.ShowDialog() == DialogResult.OK)
                {
                    // запишем новые абонент и объект в список документов
                    SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_List, true, " where id = " + IDLIST);
                    dsAbnObjAkt1.tAbnObjDoc_List.First().idAbn = ABNSELECT;
                    dsAbnObjAkt1.tAbnObjDoc_List.First().idAbnObj = OBJSELECT;
                    UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_List);

                    // и откроем его (конструктор для копирования)
                    Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                        new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, OBJSELECT, IDLIST, ABNSELECT);
                    frmAktRBP.Owner = this;
                    frmAktRBP.MdiParent = this.MdiParent;
                    frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                    frmAktRBP.Show();
                }
            }
        }

        // добавление нового акта без привязки к объекту
        private void tssbAddActBalanceAbn_Click(object sender, EventArgs e)
        {
            FormObjFind f = new FormObjFind();
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP = 
                    new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, true, ABNSELECT, TypeDocValue.ActBalance);
                frmAktRBP.Owner = this;
                frmAktRBP.MdiParent = this.MdiParent;
                frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                frmAktRBP.Show();
            }
        }

        private void tssbAddActLiabilityAbn_Click(object sender, EventArgs e)
        {
            FormObjFind f = new FormObjFind();
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                    new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, true, ABNSELECT, TypeDocValue.ActLiability);
                frmAktRBP.Owner = this;
                frmAktRBP.MdiParent = this.MdiParent;
                frmAktRBP.FormClosed += new FormClosedEventHandler(frmAktRBP_FormClosed);
                frmAktRBP.Show();
            }
        }

        // обработка нажатий клавиш
        private void dgvListAct_KeyDown(object sender, KeyEventArgs e)
        {
            if (CODE.Length > 3)
                CODE = "";
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        CODE += '0';
                        break;
                    case Keys.D1:
                        CODE += '1';
                        break;
                    case Keys.D2:
                        CODE += '2';
                        break;
                    case Keys.D3:
                        CODE += '3';
                        break;
                    case Keys.D4:
                        CODE += '4';
                        break;
                    case Keys.D5:
                        CODE += '5';
                        break;
                    case Keys.D6:
                        CODE += '6';
                        break;
                    case Keys.D7:
                        CODE += '7';
                        break;
                    case Keys.D8:
                        CODE += '8';
                        break;
                    case Keys.D9:
                        CODE += '9';
                        break;
                    case Keys.NumPad0:
                        CODE += '0';
                        break;
                    case Keys.NumPad1:
                        CODE += '1';
                        break;
                    case Keys.NumPad2:
                        CODE += '2';
                        break;
                    case Keys.NumPad3:
                        CODE += '3';
                        break;
                    case Keys.NumPad4:
                        CODE += '4';
                        break;
                    case Keys.NumPad5:
                        CODE += '5';
                        break;
                    case Keys.NumPad6:
                        CODE += '6';
                        break;
                    case Keys.NumPad7:
                        CODE += '7';
                        break;
                    case Keys.NumPad8:
                        CODE += '8';
                        break;
                    case Keys.NumPad9:
                        CODE += '9';
                        break;
                    case Keys.Enter:
                        CODE = "";
                        if (dgvListAct.SelectedRows != null && dgvListAct.SelectedRows.Count > 0)
                        {
                            Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                                new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, 1, IDLIST, true);
                            frmAktRBP.MdiParent = this.MdiParent;
                            frmAktRBP.Show();
                            //if (frmAktRBP.ShowDialog() == DialogResult.OK)
                            //{
                            //}
                            //frmAktRBP.Dispose();
                        }
                        break;
                    default:
                        CODE = "";
                        break;
                }
                if (CODE != "")
                    AbnFind();
            }
        }

        // загрузка списка актов
        private void ActListLoad()
        {
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vActBalance, true, "where idList is not null order by CodeAbonent, ObjName");
            bsListAct.ResetBindings(false);
        }

        Dictionary<string, FileWatcherArgsAddl> files = new Dictionary<string, FileWatcherArgsAddl>();

        // добавить в менюшку имена шаблонов
        private void LoadFileNameTemplate()
        {
            DataSql.SqlDataCommand cmd = new DataSql.SqlDataCommand(this.SqlSettings);
            DataTable dt = cmd.SelectSqlData(" SELECT doc.id, doc.FileName " +
                                                " FROM tR_DocTemplate AS doc " +
                                                " INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id " +
                                                " WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 3 and doc.deleted = 0");
            foreach (DataRow r in dt.Rows)
            {

                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = r["FileName"].ToString();
                item.Tag = r["id"];
                item.Click += new EventHandler(tssbExportToWord_Click);
                tssbExportToWord.DropDownItems.Add(item);

                ToolStripMenuItem itemMenu = new ToolStripMenuItem();
                itemMenu.Text = r["FileName"].ToString();
                itemMenu.Tag = r["id"];
                itemMenu.Click += new EventHandler(toolBtnAddFile_Click);
                toolMenuItemAddFile.DropDownItems.Add(itemMenu);

                ToolStripMenuItem itemFileMenu = new ToolStripMenuItem();
                itemFileMenu.Text = r["FileName"].ToString();
                itemFileMenu.Tag = r["id"];
                itemFileMenu.Click += new EventHandler(toolBtnAddFile_Click);
                toolBtnAddFile.DropDownItems.Add(itemFileMenu);
            }
        }

        /// <summary> Получает путь к папке с файлами
        /// </summary>
        /// <returns></returns>
        private string GetDirectoryPath()
        {
            string dir = ((DataRowView)bsListAct.Current)["idAbn"] is string &&
                string.IsNullOrEmpty(((DataRowView)bsListAct.Current)["idAbn"].ToString()) ?
                ((DataRowView)bsListAct.Current)["idAbn"].ToString() : "tmp";
            var path = System.IO.Path.GetTempPath() + "\\" + dir + "\\";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            return path;
        }

        /// <summary> Получает шаблон нового файла 
        /// </summary>
        /// <param name="idTemplate">Идентификатор шаблона</param>
        /// <param name="fileName">Имя шаблона</param>
        /// <param name="fileData">Файл шаблона</param>
        public void GetTepmlate(int idTemplate, out string fileName, out byte[] fileData)
        {
            fileName = "";
            fileData = null;
            string sql = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
            using (SqlConnection conn = new SqlConnection(SqlSettings.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@idTemplate", SqlDbType.Int);
                cmd.Parameters["@idTemplate"].Value = idTemplate;
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fileName = (string)dr.GetValue(0);
                        fileData = (byte[])dr.GetValue(1);
                    }
                }
                catch (Exception ex)
                {
#if DEBUG
                    MessageBox.Show(ex.ToString());
#else
                    MessageBox.Show(ex.Message, ex.Source);
#endif
                }
            }
        }

        void tssbExportToWord_Click(object sender, EventArgs e)
        {
            string path = "", fileName = "";
            ExportToWord(path, fileName, sender, false);
        }

        void toolBtnAddFile_Click(object sender, EventArgs e)
        {
            string path = "", fileName = "";
            ExportToWord(path, fileName, sender, true);
        }

        private void ExportToWord(string path, string fileName, object sender, bool saveAndListen = false)
        {
            string AbnName = GetAbnName(Convert.ToInt32(((DataRowView)bsListAct.Current)["idAbn"] == DBNull.Value ? -1 : ((DataRowView)bsListAct.Current)["idAbn"]));
            /// Загружаем все акты на данный объект
            //LoadActsByAbn(IDLIST);
            var tsmi = (ToolStripMenuItem)sender;
            int idTemplate = (int)tsmi.Tag;
            byte[] fileData;
            string _fileName;
            GetTepmlate(idTemplate, out _fileName, out fileData);

            #region Формирование имени документа
            if (string.IsNullOrEmpty(fileName))
            {
                // дата акта
                DateTime ActDate = DateTime.Parse(((DataRowView)bsListAct.Current)["ActDate"].ToString());

                string AbnName1 = ((DataRowView)bsListAct.Current)["StationList"].ToString() + " " + AbnName
                    + " " + ((DataRowView)bsListAct.Current)["ActNumber"].ToString() + " " + ActDate.ToString("ddMMyy");

                // имя документа = подстанция + потребитель + номер акта + дата акта
                fileName = AbnName1.Replace("\"", string.Empty) + ".doc";
                fileName = fileName.Replace('\\', '_').Replace('/', '_').Replace('"', '_').Replace(':', '_')
                    .Replace('<', '_').Replace('>', '_').Replace('*', '_').Replace(' ', '_').Replace('|', '_');
            }
            #endregion

            var fileExtention = new System.IO.FileInfo(fileName).Extension;

            switch (fileExtention)
            {
                case ".xlt":
                case ".xltx":
                    fileName = fileName.Replace(fileExtention, fileExtention.Replace("t", "s"));
                    break;
                case ".dot":
                case ".dotx":
                    fileName = fileName.Replace(fileExtention, fileExtention.Replace("t", "c"));
                    break;
                case ".xls":
                case ".xlsx":
                    break;
                case ".doc":
                case ".docx":
                    break;
                default:

                    break;
            }

            /// Создание временной/пользовательской папки 
            string folderName = string.IsNullOrEmpty(path) ? GetDirectoryPath() : path;

            //if (File.Exists(folderName + "\\" + fileName))
            //{
            //    File.Delete(folderName + "\\" + fileName);
            //}

            string tmpfileName = FileBinary.GetNewFileNameIsExists(folderName, fileName);

            string shortFileName = AddFileInDocument(fileName, idTemplate, fileData, saveAndListen);

            if (!string.IsNullOrEmpty(shortFileName))
            {
                //isSave = true;
                FileBinary file = new FileBinary(fileData, tmpfileName, DateTime.Now);
                // Записали файл во временную папку
                file.SaveToDisk(folderName);
                // Запустили файл
                fileExtention = new System.IO.FileInfo(fileName).Extension;

                if (saveAndListen)
                {
                    if (files.ContainsKey(shortFileName))
                    {
                        /// Слушаем изменеие файла
                        FileWatcher watcher = new FileWatcher(folderName, file.Name);
                        watcher.AnyChanged += new System.IO.FileSystemEventHandler(watcher_AnyChanged);
                        watcher.Start();

                        files[shortFileName].TempName = tmpfileName;
                        files[shortFileName].Watcher = watcher;
                        files[shortFileName].OpenState = FileOpenState.Editing;
                        //FileWatcherArgsAddl fwargsaddl = new FileWatcherArgsAddl(idTemplate, file.Name, fileName, watcher, FileOpenState.Editing);
                    }
                    else
                        MessageBox.Show("Что то пошло не так");
                }
                CreateActRbp(AbnName, folderName + "\\" + tmpfileName);
            }

        }

        private void LoadActsByAbn(int idList)
        {
            SelectSqlData(dsAbnObjAkt1.tAbnObjDoc_File, true, "where idList = " + idList);
            ResetBSFiles();
        }

        /// <summary> Запись измененного файла в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void watcher_AnyChanged(object sender, System.IO.FileSystemEventArgs e)
        {
            /// Находим 
            var fwargs = from item in files
                         where item.Value.TempName == e.Name
                         select item;

            if (fwargs.Count() > 0)
            {
                /// Считываем измененный файл
                FileBinary file = new FileBinary(e.FullPath);

                //SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File, true,
                //    String.Format("where idList = {0} AND FileName = '{1}' AND idTemplate = {2}",
                //    idList, fwargs.First().Value.OriginalName, fwargs.First().Value.IdTemplate));

               
               

                /// Ищем строку в таблице с файлом
                var dgvRows = from rowFiles in dsAbnObjAkt1.tAbnObjDoc_File
                              where rowFiles.RowState != DataRowState.Deleted && rowFiles.FileName == fwargs.First().Value.OriginalName
                              select rowFiles;

                /// Обновляем данные файла или добавляем новую строку при отсутствии
                if (dgvRows.Count() == 0)
                {
                    var row = dsAbnObjAkt1.tAbnObjDoc_File.NewtAbnObjDoc_FileRow();
                    row.id = dsAbnObjAkt1.tAbnObjDoc_File.Min(min => min.id) < 0 ? dsAbnObjAkt1.tAbnObjDoc_File.Min(min => min.id) - 1 : -1;
                    row.idList = IDLIST;
                    row.FileName = fwargs.First().Value.OriginalName;
                    row.File = file.ByteArray;
                    row.dateChange = file.LastChanged;
                    row.idTemplate = (int)fwargs.First().Value.IdTemplate;
                    dsAbnObjAkt1.tAbnObjDoc_File.AddtAbnObjDoc_FileRow(row);
                }
                else
                {
                    dgvRows.First().File = file.ByteArray;
                    dgvRows.First().dateChange = file.LastChanged;
                }

                foreach (var item in dsAbnObjAkt1.tAbnObjDoc_File)
                {
                    if (item.RowState == DataRowState.Added)
                    {
                        item.AcceptChanges();
                        item.SetModified();
                    }
                    item.EndEdit();
                }
                UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File);
                ResetBSFiles();
            }
        }

        private string AddFileInDocument(string fileName, int? idTemplate = null, byte[] fileData = null, bool saveAndListen = false)
        {
            string shortFileName = System.IO.Path.GetFileName(fileName);
            bool isAdd = true;
            while ((SelectSqlData("tAbnObjDoc_File", true, String.Format("where idList = {0} AND FileName = '{1}'", IDLIST, shortFileName)).Rows.Count > 0
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

                var row = dsAbnObjAkt1.tAbnObjDoc_File.NewtAbnObjDoc_FileRow();
                row.idList = IDLIST;
                row.FileName = shortFileName;
                if (fileData == null)
                {
                    FileBinary file = new FileBinary(fileName);
                    row.File = file.ByteArray;
                    row.dateChange = file.LastChanged;
                }
                else
                {
                    row.File = fileData;
                    row.dateChange = DateTime.Now;
                }
                if (idTemplate != null)
                    row.idTemplate = (int)idTemplate;
                dsAbnObjAkt1.tAbnObjDoc_File.AddtAbnObjDoc_FileRow(row);
                foreach (var item in dsAbnObjAkt1.tAbnObjDoc_File)
                {
                    item.EndEdit();
                }
                int idFile = InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File);
                SelectSqlData(dsAbnObjAkt1.tAbnObjDoc_File, true, "where idList = " + IDLIST);
                bsFiles.Position = bsFiles.Find("id", idFile);
                dsAbnObjAkt1.tAbnObjDoc_File.Where(r => r.id == idFile).ToList().ForEach(r => { r.AcceptChanges(); r.SetModified(); });
            }
            return shortFileName;
        }

        // поиск по номеру абонента
        private void AbnFind()
        {
            if (dgvListAct.SelectedRows != null && dgvListAct.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvListAct.RowCount; i++)
                    if (dgvListAct[2, i].FormattedValue.ToString().Contains(CODE.ToString()))
                    {
                        dgvListAct.CurrentCell = dgvListAct[2, i];
                        return;
                    }
            }
        }

        // создание акта в Word с диалогом сохранения файла
        private void tsbToWordPath_Click(object sender, EventArgs e)
        {
            //CreateActRbp(ExportToWord.WithFileName);
        }


        private void OpenFile(bool isEdit = false)
        {
            if (bsFiles.Current != null)
            {
                dsAbnObjAct.tAbnObjDoc_FileRow r = (dsAbnObjAct.tAbnObjDoc_FileRow)((DataRowView)bsFiles.Current).Row;

                string fileName = r.FileName;
                string folderName = GetDirectoryPath();
                string tmpfileName = FileBinary.GetNewFileNameIsExists(folderName, fileName);

                int? idTemplate = null;
                if (r["idTemplate"] != DBNull.Value)
                    idTemplate = r.idTemplate;
                DateTime dateChange = r.dateChange;

                if (r["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(this.SqlSettings.GetConnectionString()))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("SELECT [File] FROM tTC_DocFile WHERE id = " + r["id"].ToString(), conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                r["File"] = dr["File"];

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                }
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

                if (isEdit)
                {
                    if (files.ContainsKey(fileName))
                    {
                        if (files[fileName].Watcher == null)
                        {
                            FileWatcher watcher = new FileWatcher(folderName, tmpfileName);
                            watcher.AnyChanged += new System.IO.FileSystemEventHandler(watcher_AnyChanged);
                            watcher.Start();
                            files[fileName].Watcher = watcher;
                        }
                        else
                        {
                            files[fileName].Watcher.AnyChanged -= watcher_AnyChanged;
                            files[fileName].Watcher.Stop();
                            FileWatcher watcher = new FileWatcher(folderName, tmpfileName);
                            watcher.AnyChanged += new System.IO.FileSystemEventHandler(watcher_AnyChanged);
                            watcher.Start();
                            files[fileName].Watcher = watcher;
                        }

                        files[fileName].TempName = tmpfileName;
                        files[fileName].OpenState = FileOpenState.Editing;
                    }
                    else  // нету
                    {
                        FileWatcher watcher = new FileWatcher(folderName, tmpfileName);
                        watcher.AnyChanged += new System.IO.FileSystemEventHandler(watcher_AnyChanged);
                        watcher.Start();
                        FileWatcherArgsAddl fwargsaddl = new FileWatcherArgsAddl(idTemplate, fileName, tmpfileName, watcher, FileOpenState.Editing);
                        files.Add(fileName, fwargsaddl);

                    }

                }
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

        /// <summary> Перезагружает биндинг не из своего потока
        /// </summary>
        private void ResetBSFiles()
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(() => bsFiles.ResetBindings(false)));
            else
                bsFiles.ResetBindings(false);
        }

        private void selectFile(string fileName)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(() => bsFiles.Position = bsFiles.Find("FileName", fileName)));
            else
                bsFiles.Position = bsFiles.Find("FileName", fileName);

        }


        /// <summary> Добавить существующий файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolItemAddExistFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Multiselect = true;
            if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in dlgOpen.FileNames)
                {
                    string filename = AddFileInDocument(fileName, null, null, true);
                    //if (!string.IsNullOrEmpty(filename))
                    //isSave = true;
                }
            }
            LoadActsByAbn(IDLIST);
            ResetBSFiles();
        }

        private void toolBtnEditFile_Click(object sender, EventArgs e)
        {
            OpenFile(true);
            //if (bsFiles.Current != null)
            //{
            //    dsAbnObjAct.tAbnObjDoc_FileRow r = (dsAbnObjAct.tAbnObjDoc_FileRow)((DataRowView)bsFiles.Current).Row;
            //    string fileName = r.FileName;
            //    LoadActsByAbn(IDLIST);
            //    selectFile(fileName);
            //}
        }

        private void toolBtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolBtnDelFile_Click(object sender, EventArgs e)
        {

            if (dgvFile.SelectedRows != null && dgvFile.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные файлы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow dgvRow in dgvFile.SelectedRows)
                    {
                        var rows = dsAbnObjAkt1.tAbnObjDoc_File.Where<dsAbnObjAct.tAbnObjDoc_FileRow>(r => r.RowState != DataRowState.Deleted && r.id == (int)dgvRow.Cells["idDgvColumn"].Value);

                        if (rows.Count() > 0)
                        {
                            dsAbnObjAct.tAbnObjDoc_FileRow r = rows.First();
                            string fileName = r.FileName;
                            if (files.ContainsKey(fileName))
                            {
                                if (files[fileName].Watcher != null)
                                {
                                    files[fileName].Watcher.AnyChanged -= watcher_AnyChanged;
                                    files[fileName].Watcher.Stop();
                                }
                                files.Remove(fileName);
                            }
                            r.Delete();
                            r.EndEdit();
                        }
                    }
                    DeleteSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File);
                    LoadActsByAbn(IDLIST);
                }
            }
        }

        string oldFileName = "";
        private void toolBtnRenameFile_Click(object sender, EventArgs e)
        {
            if (dgvFile.CurrentRow != null)
            {
                oldFileName = dgvFile.CurrentRow.Cells[fileNameDgvColumn.Name].Value.ToString();
                dgvFile.CurrentCell = dgvFile.CurrentRow.Cells[fileNameDgvColumn.Name];
                dgvFile.CurrentCell.Value = System.IO.Path.GetFileNameWithoutExtension(oldFileName);
                dgvFile.ReadOnly = false;
                fileNameDgvColumn.ReadOnly = false;
                dgvFile.BeginEdit(true);
            }
        }

        private void toolBtnSaveFile_Click(object sender, EventArgs e)
        {
            if (bsFiles.Current != null)
            {
                dsAbnObjAct.tAbnObjDoc_FileRow r = (dsAbnObjAct.tAbnObjDoc_FileRow)((DataRowView)bsFiles.Current).Row;
                if (r["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(this.SqlSettings.GetConnectionString()))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("SELECT [File] FROM tTC_DocFile WHERE id = " + r["id"].ToString(), conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                                r["File"] = dr["File"];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                }
                byte[] fileData = r.File;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = r.FileName;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    ByteArrayToFile(dialog.FileName, fileData);

            }
        }

        private void dgvFile_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (((DataGridView)sender).RowCount > 0) // есть строки
            {
                if (dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value != null)
                {
                    if (e.ColumnIndex == dgvFile.Columns[imageDgvColumn.Name].Index) // столбец картинки
                    {
                        if (!string.IsNullOrEmpty(System.IO.Path.GetFileName(dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value.ToString())))
                            e.Value = System.IO.Path.GetFileName(dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value.ToString());
                        else
                            e.Value = dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value.ToString();
                    }
                    if (e.ColumnIndex == dgvFile.Columns[imageDgvColumn.Name].Index) // столбец картинки
                    {
                        Icon ico = FormLbr.Classes.FileInfo.IconOfFile(dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value.ToString());
                        if (ico != null) e.Value = ico.ToBitmap();
                    }
                }
            }
        }

        private void dgvFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolBtnOpenFile_Click(sender, e);
        }

        private void dgvFile_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvFile.ReadOnly = true;
            fileNameDgvColumn.ReadOnly = true;
            if (dgvFile[e.ColumnIndex, e.RowIndex].Value != null)
            {
                string newFileName = dgvFile[e.ColumnIndex, e.RowIndex].Value.ToString() + System.IO.Path.GetExtension(oldFileName);
                if (newFileName == oldFileName) return;

                if (files.ContainsKey(oldFileName))
                {
                    FileWatcherArgsAddl fw = files[oldFileName];
                    fw.OriginalName = newFileName;
                    files.Remove(oldFileName);
                    files.Add(newFileName, fw);
                }
                dgvFile[e.ColumnIndex, e.RowIndex].Value = newFileName;
                foreach (dsAbnObjAct.tAbnObjDoc_FileRow row in dsAbnObjAkt1.tAbnObjDoc_File)
                {
                    row.EndEdit();
                }
                UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File);
                //isSave = true;
            }
            oldFileName = null;
        }

        private void dgvFile_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
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

        private void dgvFile_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                dgvFile.ClearSelection();
                dgvFile.Rows[e.RowIndex].Selected = true;
                dgvFile.CurrentCell = dgvFile[e.ColumnIndex, e.RowIndex];
                Rectangle r = dgvFile.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                contextMenuFile.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            }
        }

        private void dgvFile_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }

        private void toolBtnRefreshFile_Click(object sender, EventArgs e)
        {
            LoadActsByAbn(IDLIST);
        }

        private void dgvListAct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListAct.SelectedRows != null && dgvListAct.SelectedRows.Count > 0
                && e.Button == System.Windows.Forms.MouseButtons.Left && e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP = new
                    Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, 1, IDLIST, true);
                frmAktRBP.MdiParent = this.MdiParent;
                frmAktRBP.Show();
            }
        }

        private void bsListAct_CurrentChanged(object sender, EventArgs e)
        {
            if (dgvListAct.CurrentRow != null && ((DataRowView)bsListAct.Current)["idList"] is int)
            {
                IDLIST = Convert.ToInt32(((DataRowView)bsListAct.Current)["idList"]);
                LoadActsByAbn(IDLIST);
            }
            else
            {
                IDLIST = -1;
            }
        }
    }
}
