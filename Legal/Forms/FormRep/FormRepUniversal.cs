using Legal.Classes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Legal.Forms.FormRep
{
    public partial class FormRepUniversal : FormLbr.FormBase
    {
        //private Word.Application wordapp;
        //private Word.Document worddocument;
        private string TempPath;
 
        /// <summary>
        /// путь к временному файлу для вставки
        /// </summary>
        private string pathToInsertingDoc { get { return "c:\\dbOrg\\tempWordDoc.doc"; } }

        /// <summary>
        /// выбранный шаблон
        /// </summary>
        public int TEMPLATE = -1;

        /// <summary>
        /// путь к шаблону
        /// </summary>
        public string pathToTemplate = "";

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

        public FormRepUniversal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// конструктор с выбранным шаблоном Word
        /// </summary>
        public FormRepUniversal(int template)
        {
            InitializeComponent();
            TEMPLATE = template;
        }

        /// <summary>
        /// формирование документов Word из шаблона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tR_Classifier, true, " where IsGroup = 0 And ParentKey = ';SKUEE;TEMPLATE;'");
            DataRow[] temp = dsAbnDocum1.tR_Classifier.Select(string.Format("id = '{0}'", TEMPLATE));
            // путь к шаблону
            pathToTemplate = temp[0]["Comment"].ToString();
            try
            {
                // передаем путь к шаблону и метод для формирования
                WordDocument.FillShowTemplate(pathToTemplate, insertTempFile);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при вставке другого документа Word из временного файла в текущий документ Word. Подробности " + error.Message + " " + error.TargetSite);
                return;
            }
        }

        /// <summary>
        /// метод - параметр в к-м в зав-сти от выбранного шаблона происходит формирование нужного документа с реальным содержимым
        /// </summary>
        /// <param name="wordDoc"></param>
        private void insertTempFile(WordDocument wordDoc)
        {
            WordDocument tempWordDoc = null;
            try
            {
                // найдем количество выбранных потребителей
                int countAbn = 0;
                for (int i = 0; i < dgvAbn.RowCount; i++)
                {
                    if (dgvAbn.Rows[i].Cells["SelectCell"].Value != null)
                        countAbn = countAbn + 1;
                }

                pBar.Maximum = countAbn;
                pBar.Minimum = 0;
                txtAbnCount.Text = countAbn.ToString();
                txtAbnNext.Text = "";
                TempPath = Path.GetTempFileName();

                int id = 0;
                int numberDoc = 0;
                // цикл по выбранным потребителям
                for (int i = 0; i < dgvAbn.RowCount; i++)
                {
                    if ((dgvAbn.Rows[i].Cells["SelectCell"].Value != null) && ((bool)dgvAbn.Rows[i].Cells["SelectCell"].Value == true))
                    {
                        id = Convert.ToInt32(dgvAbn.Rows[i].Cells["idDgv"].Value);
                        // формируем временный документ для текущего потребителя
                        tempWordDoc = new WordDocument(pathToTemplate);
                        // заполняем его содержимым
                        switch (TEMPLATE)
                        {
                            case Constants.Constants.TemplMeasurementContract:
                                complexInsertText_TemplMeasurementContract(tempWordDoc, id);
                                break;
                            case Constants.Constants.TemplMeasurementContractNo:
                                complexInsertText_TemplMeasurementContract(tempWordDoc, id);
                                break;
                        }
                        try
                        {
                            // сохраняем временный документ и закрываем его
                            tempWordDoc.Save(pathToInsertingDoc);
                            tempWordDoc.Close();
                            // вставляем временный документ в конец основного и сохраняем
                            wordDoc.InsertPageAtEnd();
                            wordDoc.InsertFile(pathToInsertingDoc);
                            wordDoc.Save(TempPath);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message + " " + error.TargetSite);
                            return;
                        } 
                        numberDoc = numberDoc + 1;
                        txtAbnNext.Text = numberDoc.ToString();
                        pBar.Value = numberDoc;
                    }
                }
                wordDoc.Visible = true;
                MessageBox.Show("Формирование отчета завершено!");
                pBar.Value = 0;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message +  " " + error.StackTrace);
                if (tempWordDoc != null) { tempWordDoc.Close();}
                MessageBox.Show(error.Message + " " + error.StackTrace);
                return;
            }
        }

        /// <summary>
        /// шаблон "Замеры"
        /// </summary>
        /// <param name="wordDoc"></param>
        /// <param name="id"></param>
        private void complexInsertText_TemplMeasurementContract(WordDocument wordDoc, int id)
        {
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnInfo, true, " where idAbn = " + id.ToString());
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.tAbn, true, " where id = " + id.ToString());

            wordDoc.SetSelectionToText("[Абонент_НаименованиеКраткое]");
            wordDoc.Selection.Text.PadRight(50);
            wordDoc.Selection.Text = dsAbnDocum1.tG_AbnInfo.Rows[0]["NameShort"].ToString().Trim();

            wordDoc.SetSelectionToText("[Договор_Номер]");
            wordDoc.Selection.Text = dsAbnDocum1.tAbn.Rows[0]["CodeAbonent"].ToString();

            wordDoc.SetSelectionToText("[Исполнитель]");
            wordDoc.Selection.Text = pExecutor.Text;

            wordDoc.SetSelectionToText("[Телефон]");
            wordDoc.Selection.Text = pPhone.Text;
        }

        /// <summary>
        /// при загрузке формы заполним список потребителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRepUniversal_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsAbnDocum1.vG_Customer, true, "order by CodeAbonent");
        }

        private void dgvAbn_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvAbn.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        /// <summary>
        /// Выбрать всех потребителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgvAbn.RowCount; i++)
            {
                dgvAbn.Rows[i].Cells["SelectCell"].Value = true;
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Отменить выбор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAbn.RowCount; i++)
            {
                dgvAbn.Rows[i].Cells["SelectCell"].Value = false;
            }
        }

 

    }
}
