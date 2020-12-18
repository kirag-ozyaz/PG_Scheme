using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace Legal.Forms
{
    public partial class FormAbnDoc_Dogovor : FormLbr.FormBase
    {
        private int IDLIST = -1;
        private int IDABN = -1;
        private int TDogovor;
        private bool isInsert = false, printState = false;  // false - update]
        //private Legal.DataSet.dsAbnDocum ds;
        private Word.Application wordapp;
        private Word.Document worddocument;
        private int IDBANK = -1;
        private DateTime dogDate, prilDate = DateTime.Now;
        private String signature = "Подпись";
        private DateTime DOCDATE;

        public string Prm
        {
            get { return this.txtNumber.Text; }
        }

        public DateTime DogDate
        {
            set { dogDate = value; }
        }

        public DateTime PrilDate
        {
            set { prilDate = value; }
        }

        public String Signature
        {
            set { signature = value; }
        }

        public Boolean PrintState
        {
            set { printState = value; }
        }

        public FormAbnDoc_Dogovor()
        {
            InitializeComponent();
        }
        
        public FormAbnDoc_Dogovor(int id, int id1, int TypeDogovor, bool insert)
        {
            InitializeComponent();
            IDLIST = id1;
            IDABN = id;
            TDogovor = TypeDogovor;
            isInsert = insert;

            this.Text = (isInsert) ? TypeDogovor == (int)Constants.DocType.DogovorEnergo ? "Новый договор энергоснабжения" : "Новый договор передачи" : "Редактирование договора";
        }

        private void FormAbnDoc_Dogovor_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Dog_Method, true);
            this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.vG_Dog_Method1, "vG_Dog_Method", true);
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Dog_Differ, true);
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Dog_Obj, true, " where idList = " + IDLIST.ToString() + " order by NumberObj, NumberSubObj");
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tR_Classifier, true, " where Deleted = 0 AND IsGroup = 0 And ParentKey = ';SKUEE;TEMPLATE;'");

            if (isInsert) // добавление
            {
                DataRow dr = dsAbnDocum1.tAbnDoc_Dogovor.NewRow();
                dr["idList"] = 0;
                dr["idAbn"] = 0;
                dr["DogNumber"] = 0;
                dr["DogDate"] = System.DateTime.Now.Date;
                dr["DateBegin"] = DBNull.Value;
                dr["DateEnd"] = DBNull.Value;
                dr["DateBreak"] = DBNull.Value;
                dr["DateSend"] = DBNull.Value;
                dr["FlagBreak"] = 0;
                dr["Signature"] = 0;
                dr["BasisOF"] = "";
                dr["Difference"] = 0;
                dr["Comment"] = "";
                dr["Trebov"] = 0;
                dr["Akcept"] = 0;
                dr["MethodFirst"] = 0;
                dr["MethodNext"] = 0;
                dr["ManSignature"] = "";
                dsAbnDocum1.tAbnDoc_Dogovor.Rows.Add(dr);
                dsAbnDocum1.tAbnDoc_Dogovor.Rows[0].BeginEdit();

                AbnDoc.TabPages.Remove(tabPageAbnObj); //убрать вкладку объектов

            }
            else //редактирование
            {
                this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tAbnDoc_List, true, " where id = " + IDLIST.ToString());
                this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tAbnDoc_Dogovor, true, " where idList = " + IDLIST.ToString());
                DOCDATE = (DateTime)dsAbnDocum1.tAbnDoc_List[0]["DocDate"]; 
                dsAbnDocum1.tAbnDoc_Dogovor.Rows[0].BeginEdit();
            }
            tabPage3.Show();
            tabPage2.Show();
            tabPageAbnObj.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["DogNumber"] = Convert.ToInt32(txtNumber.Text);
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["DogDate"] = dtDate.Value.Date;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["DateBegin"] = dtBegin.Value.Date;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["DateEnd"] = dtEnd.Value.Date;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["DateBreak"] = dtBreak.Value.Date;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["DateSend"] = dtSend.Value.Date;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["FlagBreak"] = chbBreak.CheckState;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["Signature"] = chbSignature.CheckState;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["BasisOf"] = rtbBasisOf.Text;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["Difference"] = chbDifference.CheckState;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["idDiffer"] = (cmbDifference.SelectedValue == null) ? DBNull.Value : cmbDifference.SelectedValue; ;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["Trebov"] = chbTrebov.CheckState;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["Akcept"] = chbAkcept.CheckState;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["MethodFirst"] = (cmbMethodFirst.SelectedValue == null) ? DBNull.Value : cmbMethodFirst.SelectedValue; ;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["MethodNext"] = (cmbMethodNext.SelectedValue == null) ? DBNull.Value : cmbMethodNext.SelectedValue; ;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["Comment"] = rtbComment.Text;
            dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["ManSignature"] = txtManSign.Text;

            if (isInsert) // добавление
            {
                IDLIST = InsertDocList();
                if (IDLIST < 0)
                {
                    MessageBox.Show("Не удается внести договор в список документов");
                    return;
                }
                dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["idAbn"] = IDABN;
                dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["idList"] = IDLIST;
                dsAbnDocum1.tAbnDoc_Dogovor.Rows[0].EndEdit();
                if (!InsertSqlData(dsAbnDocum1, dsAbnDocum1.tAbnDoc_Dogovor))
                {
                    MessageBox.Show("Не удается сохранить новый договор");
                    return;
                }
            }
            else
            {
                if (!UpdateDocList())
                {
                    MessageBox.Show("Не удается отредактировать список документов");
                    return;
                }
                dsAbnDocum1.tAbnDoc_Dogovor.Rows[0].EndEdit();
                if (!UpdateSqlData(dsAbnDocum1, dsAbnDocum1.tAbnDoc_Dogovor))
                {
                    MessageBox.Show("Не удается отредактировать договор");
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        // добавим договор в список документов
        private int InsertDocList()
        {
            dsAbnDocum1.tAbnDoc_List.Rows.Add(dsAbnDocum1.tAbnDoc_List.NewRow());
            if (String.IsNullOrEmpty(txtNumber.Text))
                return -1;
            dsAbnDocum1.tAbnDoc_List.Rows[0]["idAbn"] = IDABN;
            dsAbnDocum1.tAbnDoc_List.Rows[0]["DocNumber"] = txtNumber.Text;
            dsAbnDocum1.tAbnDoc_List.Rows[0]["DocDate"] = dtDate.Text;
            dsAbnDocum1.tAbnDoc_List.Rows[0]["idDocType"] = TDogovor;//Constants.Constants.TypeDocDogovor;
            dsAbnDocum1.tAbnDoc_List.Rows[0]["isActive"] = (chbBreak.Checked) ? false : true; ;
            dsAbnDocum1.tAbnDoc_List.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsAbnDocum1, dsAbnDocum1.tAbnDoc_List);
        }

        // отредактируем список документов
        private bool UpdateDocList()
        {
            dsAbnDocum1.tAbnDoc_List.Rows[0].BeginEdit();
            if (String.IsNullOrEmpty(txtNumber.Text))
                return false;
            dsAbnDocum1.tAbnDoc_List.Rows[0]["DocNumber"] = txtNumber.Text;
            dsAbnDocum1.tAbnDoc_List.Rows[0]["DocDate"] = dtDate.Text;
            dsAbnDocum1.tAbnDoc_List.Rows[0]["isActive"] = (chbBreak.Checked) ? false : true; ;
            dsAbnDocum1.tAbnDoc_List.Rows[0].EndEdit();
            return this.UpdateSqlData(dsAbnDocum1, dsAbnDocum1.tAbnDoc_List);
        }

        // добавим объект в договор
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int idDog = Convert.ToInt32(dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["id"]); ;
            Object.FormObjDog_Linking fSelect = new Object.FormObjDog_Linking(IDABN, idDog);
            fSelect.SqlSettings = this.SqlSettings;
            if (fSelect.ShowDialog() == DialogResult.OK)
            {
                    dsAbnDocum1.tG_Dog_Obj.Clear();
                    for (int i = 0; i < fSelect.idArray.Length; i++)
                    {
                        if (fSelect.idArray[i] != 0)
                        {
                            DataRow drw = dsAbnDocum1.tG_Dog_Obj.NewRow();
                            drw["idDog"] = dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["id"];
                            drw["idObj"] = fSelect.idArray[i];
                            drw["DateBegin"] = System.DateTime.Parse("01.01." + DateTime.Now.Year.ToString());
                            drw["DateEnd"] = DBNull.Value;
                            dsAbnDocum1.tG_Dog_Obj.Rows.Add(drw);
                        }
                    }
                    InsertSqlData(dsAbnDocum1, dsAbnDocum1.tG_Dog_Obj);
                    this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Dog_Obj, true, " where idList = " + IDLIST.ToString());
            }
        }

        // удалим связь с объектом
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int idRowCur = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idObj"].Value);
            if (dsAbnDocum1.vG_Dog_Obj.Rows.Count > 0)
            {
                const string message = "Вы хотите удалить эту связь с объектом";
                const string caption = "Удаление связи";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteSqlDataById(dsAbnDocum1.tG_Dog_Obj, Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value));
                    this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Dog_Obj, true, " where idList = " + IDLIST.ToString());

                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((int)dataGridView1.Rows[i].Cells["idObj"].Value == idRowCur)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells["idObj"];
                    }
                }
            }
        }

        // отредактируем связь с объектом
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int idRowCur = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idObj"].Value);
            FormAbnDogObj fDog = new FormAbnDogObj(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value));
            fDog.SqlSettings = this.SqlSettings;
            if (fDog.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Dog_Obj, true, " where idList = " + IDLIST.ToString());
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((int)dataGridView1.Rows[i].Cells["idObj"].Value == idRowCur)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells["NumberObj"];
                }
            }
        }

        // менеджер печатных форм
        private void btnViewTemplate_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(lbListTemplate.SelectedValue))
            {
                case Constants.Constants.TemplDogPer:
                    DogovorPer();
                    break;
                case Constants.Constants.TemplListObj:
                    TemplObj(dataGridView1,1);
                    break;
                case Constants.Constants.TemplVolumPower:
                    TemplVolumPower(dataGridView1);
                    break;
                case Constants.Constants.TemplActService:
                    ActService();
                    break;
                case Constants.Constants.TemplDopSogl:
                    DopSogl();
                    break;
                case Constants.Constants.TemplPowerMax:
                    PowerMax();
                    break;
                case Constants.Constants.TemplPowerMax670:
                    PowerMax();
                    break;
                case Constants.Constants.TemplDogPerNew:
                    DogovorPer();
                    break;
                case Constants.Constants.TemplListObjNew:
                    TemplObj(dataGridView1,2);
                    break;
                case Constants.Constants.TemplCalcMethod:
                    CalcMethod();
                    break;
                case Constants.Constants.TemplVolumNew:
                    TemplVolumNew(dataGridView1);
                    break;
                case Constants.Constants.TemplPowerMaxAgreement:
                    PowerMaxAgreement(dataGridView1);
                    break;
                case Constants.Constants.TemplRestrictionContract:
                    DogovorPer();
                    break;
                case Constants.Constants.TemplRestrictionContractNo:
                    DogovorPer();
                    break;
                case Constants.Constants.TemplMeasurementContract:
                    TemplMeasurement(dataGridView1,1);
                    break;
                case Constants.Constants.TemplMeasurementContractNo:
                    TemplMeasurement(dataGridView1,2);
                    break;
                case Constants.Constants.TemplActRBP:
                    PowerMax();
                    break;
                case Constants.Constants.TemplDopSogl2:
                    DopSogl();
                    break;
                case Constants.Constants.TemplKloss:
                    PowerMax();
                    break;
                case Constants.Constants.TemplTerminationContract:
                    DopSogl();
                    break;
                case Constants.Constants.TemplDopSogl3:
                    DopSogl();
                    break;
                case Constants.Constants.TemplOffer:
                    TemplMeasurement(dataGridView1, 1);
                    break;
                case Constants.Constants.TemplDopSogl4:
                    DopSogl();
                    break;
            }
        }

        // печать договора передачи с помощью шаблона
        private void DogovorPer()
        {
            // заполним данные для договора
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnChief, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");

            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnAddress, true, " where idAbn = " + IDABN.ToString() + " and idTypeAddress = " + Convert.ToString(Constants.Constants.AddressMailing) + " order by DateChange desc");
            this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.tG_AbnAddress1, "tG_AbnAddress", true, " where idAbn = " + IDABN.ToString() + " and idTypeAddress = " + Convert.ToString(Constants.Constants.AddressLegal) + " order by DateChange desc");

            if (dsAbnDocum1.tG_AbnInfo.Rows[0]["BankID"] != System.DBNull.Value)
            {
                IDBANK = Convert.ToInt32(dsAbnDocum1.tG_AbnInfo.Rows[0]["BankID"]);
                this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tBanks, true, " where BankID = " + IDBANK.ToString());
            }

            // создадим документ Word
            try
            {
                wordapp = new Word.Application();
                wordapp.Visible = true;
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }

            // определим полное имя файла с шаблоном
            DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
            object template = temp[0]["Comment"];
            object newTemplate = false;
            object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object visible = true;
            worddocument = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
            worddocument.Activate();

            // заменим все поля в документе данными
            SearchAndReplace("[Договор_Номер]", txtNumber.Text);
            if (dtDate.Value.Day < 10)
                SearchAndReplace("[Договор_Дата]", "0" + dtDate.Text);
            else
                SearchAndReplace("[Договор_Дата]", dtDate.Text);
            SearchAndReplace("[Абонент_Основание]", rtbBasisOf.Text);
            SearchAndReplace("[Договор_НачДата]", dtBegin.Text);
            SearchAndReplace("[Договор_КонДата]", dtEnd.Text);

            if (txtManSign.Text != "")
                SearchAndReplace("[Абонент_Подпись]", txtManSign.Text);
            else
                SearchAndReplace("[Абонент_Подпись]", "");

            if (dsAbnDocum1.tG_AbnInfo.Count > 0)
            {

                SearchAndReplace("[Абонент_НаименованиеКраткое]", dsAbnDocum1.tG_AbnInfo.Rows[0]["NameShort"].ToString());
                SearchAndReplace("[Абонент_Наименование]", dsAbnDocum1.tG_AbnInfo.Rows[0]["NameFull"].ToString());
                SearchAndReplace("[Абонент_ИНН]", dsAbnDocum1.tG_AbnInfo.Rows[0]["INN"].ToString());
                SearchAndReplace("[Абонент_КПП]", dsAbnDocum1.tG_AbnInfo.Rows[0]["KPP"].ToString());
                SearchAndReplace("[Абонент_ОКВЕД]", dsAbnDocum1.tG_AbnInfo.Rows[0]["OKVED"].ToString());
                SearchAndReplace("[Абонент_ОКПО]", dsAbnDocum1.tG_AbnInfo.Rows[0]["OKPO"].ToString());

                if (dsAbnDocum1.tG_AbnInfo.Rows[0]["BankAcnt"] != System.DBNull.Value)
                    SearchAndReplace("[Абонент_РасчСчет]", dsAbnDocum1.tG_AbnInfo.Rows[0]["BankAcnt"].ToString());
                else
                    SearchAndReplace("[Абонент_РасчСчет]", "");
            }
            if (dsAbnDocum1.tBanks.Count > 0)
            {
                SearchAndReplace("[Абонент_БанкНаименование]", dsAbnDocum1.tBanks.Rows[0]["NameShort"].ToString());
                SearchAndReplace("[Абонент_БанкГород]", dsAbnDocum1.tBanks.Rows[0]["City"].ToString());
                SearchAndReplace("[Абонент_БанкБИК]", dsAbnDocum1.tBanks.Rows[0]["MFO"].ToString());
                SearchAndReplace("[Абонент_БанкКорСчет]", dsAbnDocum1.tBanks.Rows[0]["CORSCHET"].ToString());
            }
            else
            {
                SearchAndReplace("[Абонент_БанкНаименование]", "");
                SearchAndReplace("[Абонент_БанкГород]", "");
                SearchAndReplace("[Абонент_БанкБИК]", "");
                SearchAndReplace("[Абонент_БанкКорСчет]", "");
            }

            if (dsAbnDocum1.tG_AbnChief.Count > 0)
            {
                SearchAndReplace("[Абонент_Должность]", dsAbnDocum1.tG_AbnChief.Rows[0]["R_Post"].ToString());
                SearchAndReplace("[Абонент_ФамилияИмяОтчество]", dsAbnDocum1.tG_AbnChief.Rows[0]["R_F"].ToString() + " " + dsAbnDocum1.tG_AbnChief.Rows[0]["R_I"].ToString() + " " + dsAbnDocum1.tG_AbnChief.Rows[0]["R_O"].ToString());
            }
            if (dsAbnDocum1.tG_AbnAddress.Count > 0)
                SearchAndReplace("[Абонент_ПочтовыйАдрес]", dsAbnDocum1.tG_AbnAddress.Rows[0]["Representation"].ToString());

            if (dsAbnDocum1.tG_AbnAddress1.Count > 0)
                SearchAndReplace("[Абонент_ЮридическийАдрес]", dsAbnDocum1.tG_AbnAddress1.Rows[0]["Representation"].ToString());
        }

        // поиск и замена текста в документе
        public void SearchAndReplace(string fndText, string fndReplText)
        {
            // Смещаем выделение к началу документа
            object unit = Word.WdUnits.wdStory;
            object extend = Word.WdMovementType.wdMove;
            wordapp.Selection.HomeKey(ref unit, ref extend);

            Word.Find fnd = wordapp.Selection.Find;
            fnd.ClearFormatting();
            fnd.Text = fndText;
            fnd.Replacement.ClearFormatting();
            fnd.Replacement.Text = fndReplText;
            ExecuteReplaceAll(fnd);
        }

        private Boolean ExecuteReplaceAll(Word.Find find)
        {
            return ExecuteReplace(find, Word.WdReplace.wdReplaceAll);
        }

        private Boolean ExecuteReplace(Word.Find find, object replaceOption)
        {
            object findText = Type.Missing;
            object matchCase = Type.Missing;
            object matchWholeWord = Type.Missing;
            object matchWildcards = Type.Missing;
            object matchSoundsLike = Type.Missing;
            object matchAllWordForms = Type.Missing;
            object forward = Type.Missing;
            object wrap = Type.Missing;
            object format = Type.Missing;
            object replaceWith = Type.Missing;
            object replace = replaceOption;
            object matchKashida = Type.Missing;
            object matchDiacritics = Type.Missing;
            object matchAlefHamza = Type.Missing;
            object matchControl = Type.Missing;

            return find.Execute(ref findText, ref matchCase,
            ref matchWholeWord, ref matchWildcards, ref matchSoundsLike,
            ref matchAllWordForms, ref forward, ref wrap, ref format,
            ref replaceWith, ref replace, ref matchKashida,
            ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }

        // печать приложения - список объектов
        private void TemplObj(DataGridView dgvData, int par)
        {
            try
            {
                OfficeLB.Word.Application word;
                DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
                String FileName = temp[0]["Comment"].ToString();
                // заполняем список объектов с реквизитами
                if (par == 1)
                    SelectSqlData(dsAbnDocum1, dsAbnDocum1.view_tmp_ListObj, true, " where idDog = " +  dgvData.SelectedRows[0].Cells["idDog"].Value.ToString());
                else
                    SelectSqlData(dsAbnDocum1, dsAbnDocum1.view_tmp_ListObjNew, true, " where idDog = " + dgvData.SelectedRows[0].Cells["idDog"].Value.ToString());
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnChief, true, " where idAbn = " + IDABN.ToString());
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString());
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_ListObjKLoss, true, " where idDog = " + dgvData.SelectedRows[0].Cells["idDog"].Value.ToString());
                String ChiefName = dsAbnDocum1.tG_AbnChief.Select("DateChange = MAX(DateChange)")[0]["I_F"].ToString();
                String OrgName = dsAbnDocum1.tG_AbnInfo[0]["NameFull"].ToString();

                if (dgvData.SelectedRows.Count > 0)
                {
                    // Открываем форму выбора дат приложения/договора и руководителя
                    FormAbnSelectSign frm = new FormAbnSelectSign(SqlSettings, DOCDATE);
                    frm.ShowDialog();
                    frm.Dispose();
                    if (printState)
                    {
                        try
                        {
                            word = new OfficeLB.Word.Application();   // Запускаем Word
                        }
                        catch (Exception)
                        {
                            throw new Exception("Ошибка MS Office", new Exception("Отсутствует предустановленный MS Office Word"));
                        }
                        word.Visible = false;                                         // Делаем его невидимым, дабы ускорить процесс заполнения данными
                        word.Documents.Add(FileName);                                 // Создаем документ на базе шаблона
                        OfficeLB.Word.Selection selection = word.Selection;
                        selection.FindAndReplace("[Номер приложения]", "1", true);
                        selection.FindAndReplace("[Дата приложения]", prilDate.ToShortDateString(), true);
                        selection.FindAndReplace("[Номер договора]", txtNumber.Text, true);
                        selection.FindAndReplace("[Дата договора]", dogDate.ToShortDateString(), true);
                        selection.FindAndReplace("[Название организации]", OrgName, true);
                        selection.FindAndReplace("[Подпись]", signature, true);
                        selection.FindAndReplace("[Потребитель]", ChiefName, true);

                        if (txtManSign.Text != "")
                            selection.FindAndReplace("[Абонент_Подпись]", txtManSign.Text,true);
                        else
                            selection.FindAndReplace("[Абонент_Подпись]", "",true);


                        OfficeLB.Word.Paragraphs prgphs = selection.Document.Paragraphs;
                        OfficeLB.Word.Rows rows = selection.Document.Tables[1].Rows;
                        OfficeLB.Word.Row newrow = new OfficeLB.Word.Row();

                        OfficeLB.Word.Rows rows2 = selection.Document.Tables[2].Rows;
                        OfficeLB.Word.Row newrow2 = new OfficeLB.Word.Row();

                        string ObjNamePrev = "";
                        if (par == 1)
                            for (int i = 0; i < dsAbnDocum1.view_tmp_ListObj.Rows.Count; i++)
                            {
                                newrow = rows.Add();                                      // Добавляем строку в таблицу
                                newrow.Height = 14.0;                                     // Устанавливаем высоту строки
                                newrow.Range.Orientation = OfficeLB.Word.WdTextOrientation.wdTextOrientationHorizontal;     // Устанавливаем ориентацию страницы альбомной
                                for (int j = 1; j < dsAbnDocum1.view_tmp_ListObj.Columns.Count - 1; j++)
                                {
                                    if ((j > 9) || (ObjNamePrev != dsAbnDocum1.view_tmp_ListObj[i]["Name"].ToString()))
                                        newrow.Range.Cells[j].Range.Text = dsAbnDocum1.view_tmp_ListObj[i][j - 1].ToString();     // Заполняем новую строку данными
                                }
                                ObjNamePrev = dsAbnDocum1.view_tmp_ListObj[i]["Name"].ToString();
                            }
                        else
                            for (int i = 0; i < dsAbnDocum1.view_tmp_ListObjNew.Rows.Count; i++)
                            {
                                newrow = rows.Add();                                      // Добавляем строку в таблицу
                                newrow.Height = 14.0;                                     // Устанавливаем высоту строки
                                newrow.Range.Orientation = OfficeLB.Word.WdTextOrientation.wdTextOrientationHorizontal;     // Устанавливаем ориентацию страницы альбомной
                                for (int j = 1; j < dsAbnDocum1.view_tmp_ListObjNew.Columns.Count - 3; j++)
                                {
                                    if ((j == 7) || (j > 9) || (ObjNamePrev != dsAbnDocum1.view_tmp_ListObjNew[i]["Name"].ToString()))
                                        newrow.Range.Cells[j].Range.Text = dsAbnDocum1.view_tmp_ListObjNew[i][j - 1].ToString();     // Заполняем новую строку данными
                                    if (j == 7) 
                                    {
                                        string strFilter = string.Format("idPoint = '{0}'", dsAbnDocum1.view_tmp_ListObjNew[i]["idPoint"].ToString());
                                        DataRow[] makes = dsAbnDocum1.vG_ListObjKLoss.Select(strFilter); 
                                        if (makes.Length > 0)
                                            newrow.Range.Cells[j].Range.Text = dsAbnDocum1.view_tmp_ListObjNew[i][j - 1].ToString() + "   +***";
                                    }
                                }
                                ObjNamePrev = dsAbnDocum1.view_tmp_ListObjNew[i]["Name"].ToString();
                            }

                        if (par == 2)
                        {
                            for (int i = 0; i < dsAbnDocum1.vG_ListObjKLoss.Rows.Count; i++)
                            {
                                newrow2 = rows2.Add();                                      // Добавляем строку в таблицу
                                newrow2.Height = 14.0;                                     // Устанавливаем высоту строки
                                newrow2.Range.Orientation = OfficeLB.Word.WdTextOrientation.wdTextOrientationHorizontal;     // Устанавливаем ориентацию страницы альбомной
                                for (int j = 1; j < dsAbnDocum1.vG_ListObjKLoss.Columns.Count-1; j++)
                                {
                                    newrow2.Range.Cells[j].Range.Text = dsAbnDocum1.vG_ListObjKLoss[i][j].ToString();     // Заполняем новую строку данными
                                }
                            }
                        }
                        // Перенос последней строки таблицы и примечания на следующую страницу, если не умещается
                        int page_1 = newrow.Range.Information(OfficeLB.Word.WdInformation.wdActiveEndPageNumber);
                        int page_2 = prgphs[prgphs.Count].Range.Information(OfficeLB.Word.WdInformation.wdActiveEndPageNumber);
                        if (page_1 != page_2)
                            newrow.Range.InsertBreak(OfficeLB.Word.WdBreakType.wdPageBreak);
                        word.Visible = true;
                        newrow = null;
                        rows = null;
                        prgphs = null;
                        selection = null;
                        word = null;
                    }
                }
                else
                {
                    MessageBox.Show("Отсутствуют выделенные объекты.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }       

        // печать Дополнительного соглашения Новые реквизиты
        private void DopSogl()
        {
            // заполним данные для договора
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnChief, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");

            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnAddress, true, " where idAbn = " + IDABN.ToString() + " and idTypeAddress = " + Convert.ToString(Constants.Constants.AddressMailing) + " order by DateChange desc");
            this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.tG_AbnAddress1, "tG_AbnAddress", true, " where idAbn = " + IDABN.ToString() + " and idTypeAddress = " + Convert.ToString(Constants.Constants.AddressLegal) + " order by DateChange desc");

            if (dsAbnDocum1.tG_AbnInfo.Rows[0]["BankID"] != DBNull.Value)
            {
                IDBANK = Convert.ToInt32(dsAbnDocum1.tG_AbnInfo.Rows[0]["BankID"]);
                this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tBanks, true, " where BankID = " + IDBANK.ToString());
            }

            // создадим документ Word
            try
            {
                wordapp = new Word.Application();
                wordapp.Visible = true;
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }

            // определим полное имя файла с шаблоном
            DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
            object template = temp[0]["Comment"];
            object newTemplate = false;
            object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object visible = true;
            worddocument = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
            worddocument.Activate();

            // заменим все поля в документе данными
            SearchAndReplace("[Договор_Номер]", txtNumber.Text);
            SearchAndReplace("[Договор_Дата]", dtDate.Text);
            SearchAndReplace("[Абонент_Основание]", rtbBasisOf.Text);
            SearchAndReplace("[Договор_НачДата]", dtBegin.Text);
            SearchAndReplace("[Договор_КонДата]", dtEnd.Text);
            SearchAndReplace("[Договор_Расторжение]", dtBreak.Text);

            if (txtManSign.Text != "")
                SearchAndReplace("[Абонент_Подпись]", txtManSign.Text);
            else
                SearchAndReplace("[Абонент_Подпись]", "          ");



            if (dsAbnDocum1.tG_AbnInfo.Count > 0)
            {
                SearchAndReplace("[Абонент_Наименование]", dsAbnDocum1.tG_AbnInfo.Rows[0]["NameFull"].ToString());
                SearchAndReplace("[Абонент_ИНН]", dsAbnDocum1.tG_AbnInfo.Rows[0]["INN"].ToString());
                SearchAndReplace("[Абонент_КПП]", dsAbnDocum1.tG_AbnInfo.Rows[0]["KPP"].ToString());
                SearchAndReplace("[Абонент_ОКВЕД]", dsAbnDocum1.tG_AbnInfo.Rows[0]["OKVED"].ToString());
                SearchAndReplace("[Абонент_ОКПО]", dsAbnDocum1.tG_AbnInfo.Rows[0]["OKPO"].ToString());
                SearchAndReplace("[Абонент_РасчСчет]", dsAbnDocum1.tG_AbnInfo.Rows[0]["BankAcnt"].ToString());
            }
            if (dsAbnDocum1.tBanks.Count > 0)
            {
                SearchAndReplace("[Абонент_БанкНаименование]", dsAbnDocum1.tBanks.Rows[0]["NameShort"].ToString());
                SearchAndReplace("[Абонент_БанкГород]", dsAbnDocum1.tBanks.Rows[0]["City"].ToString());
                SearchAndReplace("[Абонент_БанкБИК]", dsAbnDocum1.tBanks.Rows[0]["MFO"].ToString());
                SearchAndReplace("[Абонент_БанкКорСчет]", dsAbnDocum1.tBanks.Rows[0]["CORSCHET"].ToString());
            }
            if (dsAbnDocum1.tG_AbnChief.Count > 0)
            {
                SearchAndReplace("[Абонент_Должность]", dsAbnDocum1.tG_AbnChief.Rows[0]["R_Post"].ToString());
                SearchAndReplace("[Абонент_ФамилияИмяОтчество]", dsAbnDocum1.tG_AbnChief.Rows[0]["R_F"].ToString() + " " + dsAbnDocum1.tG_AbnChief.Rows[0]["R_I"].ToString() + " " + dsAbnDocum1.tG_AbnChief.Rows[0]["R_O"].ToString());
                SearchAndReplace("[Абонент_ФамилияИмяОтчество_1]", "");
//                SearchAndReplace("[Абонент_ФамилияИмяОтчество_1]", dsAbnDocum1.tG_AbnChief.Rows[0]["I_I"].ToString().Substring(1, 1) + "." + dsAbnDocum1.tG_AbnChief.Rows[0]["I_O"].ToString().Substring(1, 1) + "." + dsAbnDocum1.tG_AbnChief.Rows[0]["I_F"].ToString());
            }
            if (dsAbnDocum1.tG_AbnAddress.Count > 0)
                SearchAndReplace("[Абонент_ПочтовыйАдрес]", dsAbnDocum1.tG_AbnAddress.Rows[0]["Representation"].ToString());

            if (dsAbnDocum1.tG_AbnAddress1.Count > 0)
                SearchAndReplace("[Абонент_ЮридическийАдрес]", dsAbnDocum1.tG_AbnAddress1.Rows[0]["Representation"].ToString());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Dogovor.FormObjDogovorCopy f = new Dogovor.FormObjDogovorCopy(IDABN, (int)dsAbnDocum1.tAbnDoc_Dogovor.Rows[0]["id"]);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            { this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_Dog_Obj, true, " where idList = " + IDLIST.ToString()); };
        }

        // печать приложения - заявленные объемы и мощности
        private void TemplVolumPower(DataGridView dgvData)
        {
            try
            {
                OfficeLB.Word.Application word;
                DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
                String FileName = temp[0]["Comment"].ToString();
                // заполняем список объектов с реквизитами
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_ObjMax, true, " where idDog = " + IDLIST.ToString());
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnChief, true, " where idAbn = " + IDABN.ToString());
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString());
                String ChiefName = dsAbnDocum1.tG_AbnChief.Select("DateChange = MAX(DateChange)")[0]["I_F"].ToString();
                String OrgName = dsAbnDocum1.tG_AbnInfo[0]["NameFull"].ToString();

                if (dgvData.SelectedRows.Count > 0)
                {
                    //  Открываем форму выбора дат приложения/договора и руководителя
                    FormAbnSelectSign frm = new FormAbnSelectSign(SqlSettings,DOCDATE);
                    frm.ShowDialog();
                    frm.Dispose();
                    if (printState)
                    {
                        try
                        {
                            word = new OfficeLB.Word.Application();    // Запускаем Word
                        }
                        catch (Exception)
                        {
                            throw new Exception("Ошибка MS Office", new Exception("Отсутствует предустановленный MS Office Word"));
                        }

                        word.Visible = true;                                        
                        word.Documents.Add(FileName);                                 // Создаем документ на базе шаблона
                        OfficeLB.Word.Selection selection = word.Selection;
                        selection.FindAndReplace("[Номер приложения]", "2", true);
                        selection.FindAndReplace("[Дата приложения]", prilDate.ToShortDateString(), true);
                        selection.FindAndReplace("[Номер договора]", txtNumber.Text, true);
                        selection.FindAndReplace("[Дата договора]", dogDate.ToShortDateString(), true);
                        selection.FindAndReplace("[Название организации]", OrgName, true);
                        selection.FindAndReplace("[Подпись]", signature, true);
                        selection.FindAndReplace("[Потребитель]", ChiefName, true);

                        if (txtManSign.Text != "")
                            selection.FindAndReplace("[Абонент_Подпись]", txtManSign.Text, true);
                        else
                            selection.FindAndReplace("[Абонент_Подпись]", "", true);


                        OfficeLB.Word.Paragraphs prgphs = selection.Document.Paragraphs;
                        OfficeLB.Word.Rows rows = selection.Document.Tables[1].Rows;
                        OfficeLB.Word.Row newrow = new OfficeLB.Word.Row();
                        OfficeLB.Word.Row newrow1 = new OfficeLB.Word.Row();

                        for (int i = 0; i < dsAbnDocum1.vG_ObjMax.Rows.Count; i++)
                        {
                            newrow1 = rows.Add();
                            newrow1.Height = 10.0;                                     // Устанавливаем высоту строки
                            newrow1.Range.Orientation = OfficeLB.Word.WdTextOrientation.wdTextOrientationHorizontal;     // Устанавливаем ориентацию страницы альбомной
                            newrow1.Range.Cells[1].Range.Text = dsAbnDocum1.vG_ObjMax.Rows[i][2].ToString();     // Заполняем новую строку данными

                            newrow = rows.Add();                                   // Добавляем строку в таблицу
                            newrow.Height = 10.0;                                     // Устанавливаем высоту строки
                            newrow.Range.Orientation = OfficeLB.Word.WdTextOrientation.wdTextOrientationHorizontal;     // Устанавливаем ориентацию страницы альбомной
                            decimal Power = 0;
                            int Volum = 0;
                            for (int j = 1; j < dsAbnDocum1.vG_ObjMax.Columns.Count - 3; j++)
                            {
                                newrow.Range.Cells[j].Range.Text = dsAbnDocum1.vG_ObjMax.Rows[i][j+3].ToString();     // Заполняем новую строку данными
                                if (j==1 || j==3 || j==5 || j==7 || j==9 || j==11 || j==13 || j==15 || j==17 || j==19 || j==21 || j==23)
                                    Power = Power + Convert.ToDecimal(dsAbnDocum1.vG_ObjMax.Rows[i][j + 3]);
                                if (j == 2 || j == 4 || j == 6 || j == 8 || j == 10 || j == 12 || j == 14 || j == 16 || j == 18 || j == 20 || j == 22 || j == 24)
                                    Volum = Volum + Convert.ToInt32(dsAbnDocum1.vG_ObjMax.Rows[i][j + 3]);
                            }
                            Power = Power / 12;
                            newrow.Range.Cells[25].Range.Text = Power.ToString("0.00"); 
                            newrow.Range.Cells[26].Range.Text = Volum.ToString(); 
                            newrow1.Cells.Merge();
                            newrow1.Range.Font.Bold = true;

                        }
                         // Перенос последней строки таблицы и примечания на следующую страницу, если не умещается
                        int page_1 = newrow.Range.Information(OfficeLB.Word.WdInformation.wdActiveEndPageNumber);
                        int page_2 = prgphs[prgphs.Count].Range.Information(OfficeLB.Word.WdInformation.wdActiveEndPageNumber);
                        if (page_1 != page_2)
                            newrow.Range.InsertBreak(OfficeLB.Word.WdBreakType.wdPageBreak);
                        word.Visible = true;
                        newrow = null;
                        rows = null;
                        prgphs = null;
                        selection = null;
                        word = null;
                    }
                }
                else
                {
                    MessageBox.Show("Отсутствуют выделенные объекты.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void PowerMax()
        {
            // заполним данные для договора
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnChief, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");

            // создадим документ Word
            try
            {
                wordapp = new Word.Application();
                wordapp.Visible = true;
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }

            // определим полное имя файла с шаблоном
            DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
            object template = temp[0]["Comment"];
            object newTemplate = false;
            object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object visible = true;
            worddocument = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
            worddocument.Activate();

            // заменим все поля в документе данными

            SearchAndReplace("[Абонент_Номер]", txtNumber.Text);
            if (dsAbnDocum1.tG_AbnInfo.Count > 0)
            {
                SearchAndReplace("[Абонент_Наименование]", dsAbnDocum1.tG_AbnInfo.Rows[0]["NameFull"].ToString());
            }

        }

        private void CalcMethod()
        {
            // Открываем форму выбора дат приложения/договора и руководителя
            FormAbnSelectSign frm = new FormAbnSelectSign(SqlSettings, DOCDATE);
            frm.ShowDialog();
            frm.Dispose();

            // создадим документ Word
            try
            {
                wordapp = new Word.Application();
                wordapp.Visible = true;
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }

            // определим полное имя файла с шаблоном
            DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
            object template = temp[0]["Comment"];
            object newTemplate = false;
            object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object visible = true;

            worddocument = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
            worddocument.Activate();

            // заменим все поля в документе данными
            SearchAndReplace("[Договор_Номер]", txtNumber.Text);
            SearchAndReplace("[Договор_Дата]", dogDate.ToShortDateString());

            if (txtManSign.Text != "")
                SearchAndReplace("[Абонент_Подпись]", txtManSign.Text);
            else
                SearchAndReplace("[Абонент_Подпись]", "");

            SearchAndReplace("[Подпись]", signature);

        }

        private void ActService()
        {
            // Открываем форму выбора дат приложения/договора и руководителя
            FormAbnSelectSign frm = new FormAbnSelectSign(SqlSettings, DOCDATE);
            frm.ShowDialog();
            frm.Dispose();

            // создадим документ Word
            try
            {
                wordapp = new Word.Application();
                wordapp.Visible = true;
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }

            // определим полное имя файла с шаблоном
            DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
            object template = temp[0]["Comment"];
            object newTemplate = false;
            object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object visible = true;

            worddocument = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
            worddocument.Activate();

            //if (dtDate.Value.Day < 10)
            //    SearchAndReplace("[Договор_Дата]", "0" + dtDate.Text);
            //else
            //    SearchAndReplace("[Договор_Дата]", dtDate.Text);

            SearchAndReplace("[Договор_Номер]", txtNumber.Text);
            SearchAndReplace("[Договор_Дата]", dogDate.ToShortDateString());

            if (txtManSign.Text != "")
                SearchAndReplace("[Абонент_Подпись]", txtManSign.Text);
            else
                SearchAndReplace("[Абонент_Подпись]", "");

            SearchAndReplace("[Подпись]", signature);

        }

        // печать приложения - заявленные объемы и мощности
        private void TemplVolumNew(DataGridView dgvData)
        {
            try
            {
                OfficeLB.Word.Application word;
                DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
                String FileName = temp[0]["Comment"].ToString();
                // заполняем список объектов с реквизитами
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnChief, true, " where idAbn = " + IDABN.ToString());
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString());
                String ChiefName = dsAbnDocum1.tG_AbnChief.Select("DateChange = MAX(DateChange)")[0]["I_F"].ToString();
                String OrgName = dsAbnDocum1.tG_AbnInfo[0]["NameFull"].ToString();

                if (dgvData.SelectedRows.Count > 0)
                {
                    //  Открываем форму выбора дат приложения/договора и руководителя
                    FormAbnSelectSign frm = new FormAbnSelectSign(SqlSettings, DOCDATE);
                    frm.ShowDialog();
                    frm.Dispose();
                    if (printState)
                    {
                        SelectSqlData(dsAbnDocum1, dsAbnDocum1.vG_ObjMaxNew, true, " where idDog = " + IDLIST.ToString());
                        //  + " AND [Year] = " + prilDate.Year.ToString()

                        if (dsAbnDocum1.vG_ObjMaxNew.Rows.Count > 0)
                        {
                            try
                            {
                                word = new OfficeLB.Word.Application();    // Запускаем Word
                            }
                            catch (Exception)
                            {
                                throw new Exception("Ошибка MS Office", new Exception("Отсутствует предустановленный MS Office Word"));
                            }

                            word.Visible = true;
                            word.Documents.Add(FileName);                                 // Создаем документ на базе шаблона
                            OfficeLB.Word.Selection selection = word.Selection;
                            selection.FindAndReplace("[Номер приложения]", "2", true);
                            selection.FindAndReplace("[Дата приложения]", prilDate.ToShortDateString(), true);
                            selection.FindAndReplace("[Номер договора]", txtNumber.Text, true);
                            selection.FindAndReplace("[Дата договора]", dogDate.ToShortDateString(), true);
                            selection.FindAndReplace("[Название организации]", OrgName, true);
                            selection.FindAndReplace("[Подпись]", signature, true);
                            selection.FindAndReplace("[Потребитель]", ChiefName, true);
                            selection.FindAndReplace("[Год заявки]", prilDate.Year.ToString(), true);

                            if (txtManSign.Text != "")
                                selection.FindAndReplace("[Абонент_Подпись]", txtManSign.Text, true);
                            else
                                selection.FindAndReplace("[Абонент_Подпись]", "", true);


                            OfficeLB.Word.Paragraphs prgphs = selection.Document.Paragraphs;
                            OfficeLB.Word.Rows rows = selection.Document.Tables[1].Rows;
                            OfficeLB.Word.Row newrow = new OfficeLB.Word.Row();
                            OfficeLB.Word.Row newrow1 = new OfficeLB.Word.Row();

                            for (int i = 0; i < dsAbnDocum1.vG_ObjMaxNew.Rows.Count; i++)
                            {
                                newrow1 = rows.Add();
                                newrow1.Height = 10.0;                                     // Устанавливаем высоту строки
                                newrow1.Range.Orientation = OfficeLB.Word.WdTextOrientation.wdTextOrientationHorizontal;     // Устанавливаем ориентацию страницы альбомной
                                newrow1.Range.Cells[1].Range.Text = dsAbnDocum1.vG_ObjMaxNew.Rows[i][2].ToString();     // Заполняем новую строку данными

                                newrow = rows.Add();                                   // Добавляем строку в таблицу
                                newrow.Height = 10.0;                                     // Устанавливаем высоту строки
                                newrow.Range.Orientation = OfficeLB.Word.WdTextOrientation.wdTextOrientationHorizontal;     // Устанавливаем ориентацию страницы альбомной
                                int Volum = 0;
                                for (int j = 1; j < dsAbnDocum1.vG_ObjMaxNew.Columns.Count - 3; j++)
                                {
                                    newrow.Range.Cells[j].Range.Text = dsAbnDocum1.vG_ObjMaxNew.Rows[i][j + 3].ToString();     // Заполняем новую строку данными
                                    Volum = Volum + Convert.ToInt32(dsAbnDocum1.vG_ObjMaxNew.Rows[i][j + 3]);
                                }
                                newrow.Range.Cells[13].Range.Text = Volum.ToString();
                                newrow1.Cells.Merge();
                                newrow1.Range.Font.Bold = true;

                            }
                            // Перенос последней строки таблицы и примечания на следующую страницу, если не умещается
                            int page_1 = newrow.Range.Information(OfficeLB.Word.WdInformation.wdActiveEndPageNumber);
                            int page_2 = prgphs[prgphs.Count].Range.Information(OfficeLB.Word.WdInformation.wdActiveEndPageNumber);
                            if (page_1 != page_2)
                                newrow.Range.InsertBreak(OfficeLB.Word.WdBreakType.wdPageBreak);
                            word.Visible = true;
                            newrow = null;
                            rows = null;
                            prgphs = null;
                            selection = null;
                            word = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Отсутствуют выделенные объекты.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // соглашение о максимальной мощности
        private void PowerMaxAgreement(DataGridView dgvData)
        {
            try
            {
                OfficeLB.Word.Application word;
                DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
                String FileName = temp[0]["Comment"].ToString();
                // заполняем список объектов с реквизитами
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.view_tmp_PowerMaxAgreement_New, true, " where idDog = " + dgvData.SelectedRows[0].Cells["idDog"].Value.ToString() + " order by NumberObj, NumberSubObj, Name");
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnChief, true, " where idAbn = " + IDABN.ToString());
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString());

                if (dgvData.SelectedRows.Count > 0)
                {
                    try
                    {
                        word = new OfficeLB.Word.Application();   // Запускаем Word
                    }
                    catch (Exception)
                    {
                        throw new Exception("Ошибка MS Office", new Exception("Отсутствует предустановленный MS Office Word"));
                    }
                    word.Visible = false;              
                    word.Documents.Add(FileName);      
                    OfficeLB.Word.Selection selection = word.Selection;
                    selection.FindAndReplace("[Абонент_Наименование]", dsAbnDocum1.tG_AbnInfo.Rows[0]["NameFull"].ToString(), true);
                    if (dsAbnDocum1.tG_AbnChief.Count > 0)
                    {
                        selection.FindAndReplace("[Абонент_Должность]", dsAbnDocum1.tG_AbnChief.Rows[0]["R_Post"].ToString(), true);
                        selection.FindAndReplace("[Абонент_ФамилияИмяОтчество]", dsAbnDocum1.tG_AbnChief.Rows[0]["R_F"].ToString() + " " + dsAbnDocum1.tG_AbnChief.Rows[0]["R_I"].ToString() + " " + dsAbnDocum1.tG_AbnChief.Rows[0]["R_O"].ToString(),true);
                    }

                    if (txtManSign.Text != "")
                        selection.FindAndReplace("[Абонент_Подпись]", txtManSign.Text, true);
                    else
                        selection.FindAndReplace("[Абонент_Подпись]", "", true);

                    selection.FindAndReplace("[Дата]", DateTime.Today.ToShortDateString(), true);
                    selection.FindAndReplace("[Абонент_Основание]", rtbBasisOf.Text, true);

                    OfficeLB.Word.Paragraphs prgphs = selection.Document.Paragraphs;
                    OfficeLB.Word.Rows rows = selection.Document.Tables[1].Rows;
                    OfficeLB.Word.Row newrow = new OfficeLB.Word.Row();

                    for (int i = 0; i < dsAbnDocum1.view_tmp_PowerMaxAgreement_New.Rows.Count; i++)
                    {
                        newrow = rows.Add();                                      // Добавляем строку в таблицу
                        newrow.Height = 14.0;                                     // Устанавливаем высоту строки
                        newrow.Range.Orientation = OfficeLB.Word.WdTextOrientation.wdTextOrientationHorizontal;     // Устанавливаем ориентацию страницы альбомной
                        for (int j = 1; j < dsAbnDocum1.view_tmp_PowerMaxAgreement_New.Columns.Count; j++)
                        {
                            newrow.Range.Cells[j].Range.Text = dsAbnDocum1.view_tmp_PowerMaxAgreement_New[i][j - 1].ToString();     // Заполняем новую строку данными
                        }
                    }
                    word.Visible = true;
                    newrow = null;
                    rows = null;
                    prgphs = null;
                    selection = null;
                    word = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void TemplMeasurement(DataGridView dgvData, int par)
        {
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");

            // Открываем форму выбора дат приложения/договора и руководителя
            //FormAbnSelectSign frm = new FormAbnSelectSign(SqlSettings, DOCDATE);
            //frm.ShowDialog();
            //frm.Dispose();

            // создадим документ Word
            try
            {
                wordapp = new Word.Application();
                wordapp.Visible = true;
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }

            // определим полное имя файла с шаблоном
            DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", lbListTemplate.SelectedValue));
            object template = temp[0]["Comment"];
            object newTemplate = false;
            object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object visible = true;

            worddocument = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
            worddocument.Activate();

            SearchAndReplace("[Абонент_НаименованиеКраткое]", dsAbnDocum1.tG_AbnInfo.Rows[0]["NameShort"].ToString());

            SearchAndReplace("[Договор_Номер]", txtNumber.Text);
            if (par == 1)
                SearchAndReplace("[Договор_Дата]", dogDate.ToShortDateString());

            if (txtManSign.Text != "")
                SearchAndReplace("[Абонент_Подпись]", txtManSign.Text);
            else
                SearchAndReplace("[Абонент_Подпись]", "");

            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tAbn, true, " where id = " + IDABN.ToString());
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_WorkerExt, true, " where idWorker = " + Convert.ToInt32(dsAbnDocum1.tAbn[0]["idWorker"]));
            if (dsAbnDocum1.tG_WorkerExt.Count > 0)
            {
                SearchAndReplace("[Исполнитель]", dsAbnDocum1.tG_WorkerExt.Rows[0]["F"].ToString());
                SearchAndReplace("[Телефон]", dsAbnDocum1.tG_WorkerExt.Rows[0]["Phone"].ToString());
            }
            else
            {
                SearchAndReplace("[Исполнитель]", "");
                SearchAndReplace("[Телефон]", "");
            }
            //SearchAndReplace("[Подпись]", signature);
        }

        private void btnMultiAbn_Click(object sender, EventArgs e)
        {
            FormRep.FormRepUniversal frm = new FormRep.FormRepUniversal(Convert.ToInt32(lbListTemplate.SelectedValue));
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void AbnDoc_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (AbnDoc.SelectedIndex > 3)
            {
                btnOK.Visible = false;
                btnCancel.Visible = false;
            }
            else
            {
                btnOK.Visible = true;
                btnCancel.Visible = true;
            }

            if (AbnDoc.SelectedIndex == 4)
            {
                LoadNet(1);
            }
        }

        public class myList
        {
            private string id, name;
            public string Id
            {
                get { return id; }
            }
            public myList(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {

            string whereNet = "";
            //string xmlRoles = "";


            if (clbOrgNet.CheckedItems.Count <= 0)
            {
                const string message = "Выберите сетевую организацию";
                var result = MessageBox.Show(message);
                return;
            }
            else
            {
                for (int i = 0; i <= (clbOrgNet.CheckedItems.Count) - 1; i++)
                {
                    myList mylist = (myList)clbOrgNet.CheckedItems[i];
                    whereNet += mylist.Id + ",";
                }
                whereNet = whereNet.Remove(whereNet.Length - 1);
            }

            this.Cursor = Cursors.WaitCursor;

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";
                strCmd = "select * from fn_LegNet_Objects(@whereNet) order by CodeAbonent, ObjID";

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                whereNet = whereNet.Replace(",", " ");
                SqlParameter p1 = new SqlParameter("@whereNet", whereNet);
                sqlCmd.Parameters.Add(p1);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                DataTable dt = new DataTable();
                dAdapt.Fill(dt);

                this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");
                this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnChief, true, " where idAbn = " + IDABN.ToString() + " order by DateChange desc");

                String ChiefName = "";
                if (dsAbnDocum1.tG_AbnChief.Rows.Count > 0)
                    ChiefName = dsAbnDocum1.tG_AbnChief[0]["I_F"].ToString();
                String OrgName = dsAbnDocum1.tG_AbnInfo[0]["NameShort"].ToString();

                Excel.Application excelapp = new Excel.Application();

                excelapp.SheetsInNewWorkbook = 1;
                excelapp.Workbooks.Add(Type.Missing);

                Excel.Workbooks excelappworkbooks = excelapp.Workbooks;
                Excel.Workbook excelappworkbook = excelappworkbooks[1];

                Excel.Sheets excelsheets = excelappworkbook.Worksheets;
                Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

                object misValue = System.Reflection.Missing.Value;

                // шрифт для всего листа
                excelworksheet.get_Range("A:R").Font.Name = "Times New Roman";
                excelworksheet.get_Range("A:R").Font.Size = 10;

                // шрифт для наименования отчета
                excelworksheet.get_Range("A4", "R4").Font.Name = "Times New Roman";
                excelworksheet.get_Range("A4", "R4").Font.Bold = true;
                excelworksheet.get_Range("A4", "R4").Font.Size = 16;

                // приложение
                excelworksheet.get_Range("A1", "R1").Merge(misValue);
                excelworksheet.get_Range("A1", "R1").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("A1", "R1").HorizontalAlignment = Excel.Constants.xlRight;
                excelworksheet.get_Range("A1", "R1").Value2 = "Приложение №1 от 01.01.2015 ";

                excelworksheet.get_Range("A2", "R2").Merge(misValue);
                excelworksheet.get_Range("A2", "R2").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("A2", "R2").HorizontalAlignment = Excel.Constants.xlRight;
                excelworksheet.get_Range("A2", "R2").Value2 = "к договору оказания услуг по передаче электроэнергии";

                excelworksheet.get_Range("A3", "R3").Merge(misValue);
                excelworksheet.get_Range("A3", "R3").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("A3", "R3").HorizontalAlignment = Excel.Constants.xlRight;
                excelworksheet.get_Range("A3", "R3").Value2 = "№" + txtNumber.Text + " от " + dtDate.Value.ToShortDateString();

                // наименование отчета
                excelworksheet.get_Range("A4", "R4").Merge(misValue);
                excelworksheet.get_Range("A4", "R4").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("A4", "R4").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("A4", "R4").Value2 = "Перечень точек  присоединения ,поставки и их технические характеристики";

                excelworksheet.get_Range("A6", "R6").RowHeight = 52;
                excelworksheet.get_Range("A7", "R7").RowHeight = 32.5;
                excelworksheet.get_Range("A8", "R8").RowHeight = 69;


                // наименования столбцов
                excelworksheet.get_Range("A6", "A8").Merge(misValue);
                excelworksheet.get_Range("A6", "A8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("A6", "A8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("A6", "A8").Value2 = "№  пункта";
                excelworksheet.get_Range("A6", "A8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("A6", "A8").Borders.Weight = Excel.XlBorderWeight.xlThin;

                excelworksheet.get_Range("B6", "B8").Merge(misValue);
                excelworksheet.get_Range("B6", "B8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("B6", "B8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("B6", "B8").Value2 = "Наименование точки присоединения (поставки)";
                excelworksheet.get_Range("B6", "B8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("B6", "B8").Borders.Weight = Excel.XlBorderWeight.xlThin;

                excelworksheet.get_Range("C6", "C8").Merge(misValue);
                excelworksheet.get_Range("C6", "C8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("C6", "C8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("C6", "C8").Value2 = "Место установки приборов учета потребителей";
                excelworksheet.get_Range("C6", "C8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("C6", "C8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("D6", "D8").Merge(misValue);
                excelworksheet.get_Range("D6", "D8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("D6", "D8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("D6", "D8").Orientation = 90;
                excelworksheet.get_Range("D6", "D8").Value2 = "Расчетный уровень напряжения в точке подключения";
                excelworksheet.get_Range("D6", "D8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("D6", "D8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("E6", "N6").Merge(misValue);
                excelworksheet.get_Range("E6", "N6").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("E6", "N6").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("E6", "N6").Value2 = "приборы (средства) учета электроэнергии";
                excelworksheet.get_Range("E6", "N6").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("E6", "N6").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("E7", "E8").Merge(misValue);
                excelworksheet.get_Range("E7", "E8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("E7", "E8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("E7", "E8").Value2 = "Тип (марка) счётчика";
                excelworksheet.get_Range("E7", "E8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("E7", "E8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("F7", "F8").Merge(misValue);
                excelworksheet.get_Range("F7", "F8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("F7", "F8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("F7", "F8").Value2 = "№ счётчика";
                excelworksheet.get_Range("F7", "F8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("F7", "F8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("G7", "H7").Merge(misValue);
                excelworksheet.get_Range("G7", "H7").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("G7", "H7").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("G7", "H7").Value2 = "Трансформатор напряжения";
                excelworksheet.get_Range("G7", "H7").WrapText = true;
                excelworksheet.get_Range("G7", "H7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("G7", "H7").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("G8", "G8").Merge(misValue);
                excelworksheet.get_Range("G8", "G8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("G8", "G8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("G8", "G8").Value2 = "№";
                excelworksheet.get_Range("G8", "G8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("G8", "G8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("H8", "H8").Merge(misValue);
                excelworksheet.get_Range("H8", "H8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("H8", "H8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("H8", "H8").Value2 = "К-т трансформации";
                excelworksheet.get_Range("H8", "H8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("H8", "H8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("I7", "J7").Merge(misValue);
                excelworksheet.get_Range("I7", "J7").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("I7", "J7").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("I7", "J7").Value2 = "Трансформатор тока";
                excelworksheet.get_Range("I7", "J7").WrapText = true;
                excelworksheet.get_Range("I7", "I7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("I7", "I7").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("I8", "I8").Merge(misValue);
                excelworksheet.get_Range("I8", "I8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("I8", "I8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("I8", "I8").Value2 = "№";
                excelworksheet.get_Range("I8", "I8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("I8", "I8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("J8", "J8").Merge(misValue);
                excelworksheet.get_Range("J8", "J8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("J8", "J8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("J8", "J8").Value2 = "К-т трансформации";
                excelworksheet.get_Range("J8", "J8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("J8", "J8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("K7", "K8").Merge(misValue);
                excelworksheet.get_Range("K7", "K8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("K7", "K8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("K7", "K8").Value2 = "Расчётный к-т";
                excelworksheet.get_Range("K7", "K8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("K7", "K8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("L7", "L8").Merge(misValue);
                excelworksheet.get_Range("L7", "L8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("L7", "L8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("L7", "L8").Orientation = 90;
                excelworksheet.get_Range("L7", "L8").Value2 = "Ответственный за сохранность и работоспособность";
                excelworksheet.get_Range("L7", "L8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("L7", "L8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("M7", "M8").Merge(misValue);
                excelworksheet.get_Range("M7", "M8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("M7", "M8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("M7", "M8").Orientation = 90;
                excelworksheet.get_Range("M7", "M8").Value2 = "Потери от прибора учёта до границы балансовой принадлежности (%)";
                excelworksheet.get_Range("M7", "M8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("M7", "M8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("N7", "N8").Merge(misValue);
                excelworksheet.get_Range("N7", "N8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("N7", "N8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("N7", "N8").Orientation = 90;
                excelworksheet.get_Range("N7", "N8").Value2 = "согласованный расчетный способ";
                excelworksheet.get_Range("N7", "N8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("N7", "N8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("O6", "O8").Merge(misValue);
                excelworksheet.get_Range("O6", "O8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("O6", "O8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("O6", "O8").Orientation = 90;
                excelworksheet.get_Range("O6", "O8").Value2 = "№ акта границ ответственности";
                excelworksheet.get_Range("O6", "O8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("O6", "O8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("P6", "P8").Merge(misValue);
                excelworksheet.get_Range("P6", "P8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("P6", "P8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("P6", "P8").Orientation = 90;
                excelworksheet.get_Range("P6", "P8").Value2 = "категория надежности электроснабжения";
                excelworksheet.get_Range("P6", "P8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("P6", "P8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("Q6", "R6").Merge(misValue);
                excelworksheet.get_Range("Q6", "R6").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("Q6", "R6").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("Q6", "R6").Value2 = "Согласованный уровень аварийной брони, МВт";
                excelworksheet.get_Range("Q6", "R6").WrapText = true;
                excelworksheet.get_Range("Q6", "R6").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("Q6", "R6").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("Q7", "Q8").Merge(misValue);
                excelworksheet.get_Range("Q7", "Q8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("Q7", "Q8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("Q7", "Q8").Value2 = "зима";
                excelworksheet.get_Range("Q7", "Q8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("Q7", "Q8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                excelworksheet.get_Range("R7", "R8").Merge(misValue);
                excelworksheet.get_Range("R7", "R8").VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("R7", "R8").HorizontalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range("R7", "R8").Value2 = "лето";
                excelworksheet.get_Range("R7", "R8").Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range("R7", "R8").Borders.Weight = Excel.XlBorderWeight.xlThin;


                // установим ширину столбцов
                excelworksheet.get_Range("A:A", misValue).ColumnWidth = 7;
                excelworksheet.get_Range("B:B", misValue).ColumnWidth = 55;
                excelworksheet.get_Range("C:C", misValue).ColumnWidth = 26;
                excelworksheet.get_Range("D:D", misValue).ColumnWidth = 6.6;
                excelworksheet.get_Range("E:E", misValue).ColumnWidth = 16.5;
                excelworksheet.get_Range("F:F", misValue).ColumnWidth = 21.3;
                excelworksheet.get_Range("G:G", misValue).ColumnWidth = 8;
                excelworksheet.get_Range("H:H", misValue).ColumnWidth = 8;
                excelworksheet.get_Range("I:I", misValue).ColumnWidth = 8;
                excelworksheet.get_Range("J:J", misValue).ColumnWidth = 8;
                excelworksheet.get_Range("K:K", misValue).ColumnWidth = 10;
                excelworksheet.get_Range("L:L", misValue).ColumnWidth = 13;
                excelworksheet.get_Range("M:M", misValue).ColumnWidth = 10.3;
                excelworksheet.get_Range("N:N", misValue).ColumnWidth = 5.3;
                excelworksheet.get_Range("O:O", misValue).ColumnWidth = 14.2;
                excelworksheet.get_Range("P:P", misValue).ColumnWidth = 5.3;
                excelworksheet.get_Range("Q:Q", misValue).ColumnWidth = 8.2;
                excelworksheet.get_Range("R:R", misValue).ColumnWidth = 13.6;

                excelworksheet.get_Range("A:A", misValue).WrapText = true;
                excelworksheet.get_Range("B:B", misValue).WrapText = true;
                excelworksheet.get_Range("C:C", misValue).WrapText = true;
                excelworksheet.get_Range("D:D", misValue).WrapText = true;
                excelworksheet.get_Range("E:E", misValue).WrapText = true;
                excelworksheet.get_Range("F:F", misValue).WrapText = true;
                excelworksheet.get_Range("G:G", misValue).WrapText = true;
                excelworksheet.get_Range("H:H", misValue).WrapText = true;
                excelworksheet.get_Range("I:I", misValue).WrapText = true;
                excelworksheet.get_Range("J:J", misValue).WrapText = true;
                excelworksheet.get_Range("K:K", misValue).WrapText = true;
                excelworksheet.get_Range("L:L", misValue).WrapText = true;
                excelworksheet.get_Range("M:M", misValue).WrapText = true;
                excelworksheet.get_Range("N:N", misValue).WrapText = true;
                excelworksheet.get_Range("O:O", misValue).WrapText = true;
                excelworksheet.get_Range("P:P", misValue).WrapText = true;
                excelworksheet.get_Range("Q:Q", misValue).WrapText = true;
                excelworksheet.get_Range("R:R", misValue).WrapText = true;


                Excel.Range excelcells;

                // Вывод данных
                int c = 8;
                foreach (DataRow row in dt.Rows)
                {
                    c++;
                    foreach (DataColumn column in dt.Columns)
                    {
                        if (column.Ordinal + 1 < 19)
                        {
                            excelcells = (Excel.Range)excelworksheet.Cells[c + 1, column.Ordinal + 1];
                            if (column.DataType == Type.GetType("System.String"))
                                excelcells.NumberFormat = "@";
                            if (column.DataType == Type.GetType("System.DateTime"))
                                excelcells.NumberFormat = @"ДД.ММ.ГГГГ";
                            if (column.DataType == Type.GetType("System.Boolean"))
                                excelcells.NumberFormat = "@";

                            if (column.ToString() == "№ пункта")
                                excelcells.Value2 = c - 8;
                            else
                                excelcells.Value2 = row[column];
                        }
                    }
                }

                int rw = c + 1; 
                excelworksheet.get_Range(excelworksheet.Cells[9, 1], excelworksheet.Cells[rw, 18]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range(excelworksheet.Cells[9, 1], excelworksheet.Cells[rw, 18]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                excelcells = (Excel.Range)excelworksheet.Cells[c + 2, 2];
                excelcells.Value2 = "Алгоритм определения объема услуг по передаче электроэнергии из сетей Заказчика в сети Исполнителя";

                excelworksheet.get_Range(excelworksheet.Cells[c + 2, 3], excelworksheet.Cells[c + 2, 18]).Merge(misValue);
                excelworksheet.get_Range(excelworksheet.Cells[c + 2, 3], excelworksheet.Cells[c + 2, 18]).Value2 = "W=Wп.13+Wп.16+Wп.17+Wп.18+Wп.19+ Wп.20+Wп.23+Wп.24+Wп.25+Wп.26+Wп.27+Wп.28+Wп.29+Wп.30+Wп.31+Wп32+Wп.33+Wп.34+Wп.35+Wп.36+Wп.37+Wп.38+Wп.39  с учетом всех примечаний отмеченных звездочками";
                excelworksheet.get_Range(excelworksheet.Cells[c + 2, 3], excelworksheet.Cells[c + 2, 18]).VerticalAlignment = Excel.Constants.xlCenter;
                excelworksheet.get_Range(excelworksheet.Cells[c + 2, 3], excelworksheet.Cells[c + 2, 18]).HorizontalAlignment = Excel.Constants.xlCenter;

                excelworksheet.get_Range(excelworksheet.Cells[c + 2, 1], excelworksheet.Cells[c + 2, 18]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelworksheet.get_Range(excelworksheet.Cells[c + 2, 1], excelworksheet.Cells[c + 2, 18]).Borders.Weight = Excel.XlBorderWeight.xlThin;
                
                excelcells = (Excel.Range)excelworksheet.Cells[c + 3, 2];
                excelcells.Value2 = "*** Потери от границы балансовой принадлежности до прибора учёта  определяются согласно Расчета потерь электрической энергии ΔW= Wтр + Wкл ( согласно расчетных листов)";

                
                excelcells = (Excel.Range)excelworksheet.Cells[c + 6, 2];
                excelcells.WrapText = false;
                excelcells.Value2 = "Исполнитель:";
                excelcells = (Excel.Range)excelworksheet.Cells[c + 7, 2];
                excelcells.WrapText = false;
                excelcells.Value2 = OrgName;
                excelcells = (Excel.Range)excelworksheet.Cells[c + 8, 2];
                excelcells.WrapText = false;
                excelcells.Value2 = "________________________/" + ChiefName + "/";

                excelcells = (Excel.Range)excelworksheet.Cells[c + 6, 11];
                excelcells.WrapText = false;
                excelcells.Value2 = "Заказчик:";
                excelcells = (Excel.Range)excelworksheet.Cells[c + 7, 11];
                excelcells.WrapText = false;
                excelcells.Value2 = "МУП УльГЭС";
                excelcells = (Excel.Range)excelworksheet.Cells[c + 8, 11];
                excelcells.WrapText = false;
                excelcells.Value2 = "________________________/А.К.Абубекяров /";

                excelworksheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                excelworksheet.PageSetup.LeftMargin = 8;
                excelworksheet.PageSetup.RightMargin = 6;
                excelworksheet.PageSetup.BottomMargin = 8;
                excelworksheet.PageSetup.TopMargin = 8;
                excelworksheet.PageSetup.Zoom = 55;

                this.Cursor = Cursors.Default;
                excelapp.Visible = true;
                return;

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

        private void btnNetFiltr_Click(object sender, EventArgs e)
        {
            LoadNet(1);

        }

        private void LoadNet(int f)
        {

            // загрузка сетевых организаций
            clbOrgNet.Items.Clear();
            if (f == 1)
            {
                this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.Tables["vG_Net"], "vG_Net", true,
                    " order by NetName ");

                for (int i = 0; i < dsAbnDocum1.vG_Net.Rows.Count; i++)
                {
                    clbOrgNet.Items.Add(new myList(dsAbnDocum1.vG_Net[i]["id"].ToString(), dsAbnDocum1.vG_Net[i]["NetName"].ToString()));
                }
            }
            else
            {
                this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.Tables["tAbn1"], "tAbn", true,
                    " where TypeAbn = " + Constants.Constants.TypeAbnNet + " order by Name ");

                for (int i = 0; i < dsAbnDocum1.tAbn1.Rows.Count; i++)
                {
                    clbOrgNet.Items.Add(new myList(dsAbnDocum1.tAbn1[i]["id"].ToString(), dsAbnDocum1.tAbn1[i]["Name"].ToString()));
                }
            }
        }

        private void btnNetFiltr2_Click(object sender, EventArgs e)
        {
            LoadNet(2);
        }

    }
}
