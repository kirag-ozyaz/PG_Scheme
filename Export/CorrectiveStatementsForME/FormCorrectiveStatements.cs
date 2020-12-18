using Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StatementsForME
{

    public partial class FormCorrectiveStatements : FormLbr.FormBase
    {
        public FormCorrectiveStatements()
        {


            InitializeComponent();
            this.cmbStatusSendME1 = new System.Windows.Forms.ComboBox();
            this.cmbStatusSendME1.Name = "cmbStatusSendME1";
            this.cmbStatusSendME1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusSendME1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatusSendME1.Size = new System.Drawing.Size(121, 25);
            this.cmbStatusSendME1.FormattingEnabled = true;
            //this.cmbStatusSendME1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStrip.Items.Insert(toolStrip.Items.Count, new ToolStripControlHost(this.cmbStatusSendME1));

            this.dateTimePeriodKWT = new DateTimePicker
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F),
                Width = 120,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "MMMM yyyy",
                Value = DateTime.Now.AddMonths(-1)
            };
            
            int num = 0;
            foreach (var enumerator in this.toolStrip.Items)
            {
                {
                    if ((ToolStripItem)enumerator == this.toolLabelPeriodKWT)
                    {
                        break;
                    }
                    num++;
                }
            }
            this.toolStrip.Items.Insert(num + 1, new ToolStripControlHost(this.dateTimePeriodKWT));
            this.Activate();
        }

        private void toolBtnLoad_Click(object sender, EventArgs e)
        {
            if (this.tabGeneral.SelectedTab == this.tabCorr)
            {
                SendRequestToME sendME = new SendRequestToME();
                sendME.SqlSettings = this.SqlSettings;

                this.dataSetStatement.TableForSendToME.Clear();
                DataTable tableDamage = this.dataSetStatement.TableForSendToME;

                int isSendSiteCrashMe = 0;
                int isSendSitePlanMe = 0; // sendSite = 1
                if (cmbStatusSendME1.SelectedIndex == 0) /*Подготовка для корректировки(3)*/
                {
                    isSendSiteCrashMe = 3;
                    isSendSitePlanMe = 1;
                }
                else if (cmbStatusSendME1.SelectedIndex == 1) /*Готово для отправки(1)*/
                {
                    isSendSiteCrashMe = 1;
                }  
                else if (cmbStatusSendME1.SelectedIndex == 2) /*Отправленная корректировка(6)*/
                {
                    isSendSiteCrashMe = 6;
                }
                else if (cmbStatusSendME1.SelectedIndex == 3) /*Ошибка отправки*/
                {
                    isSendSiteCrashMe = 5;
                }
                else if (cmbStatusSendME1.SelectedIndex == 4) /*Показать все*/
                {
                    isSendSiteCrashMe = 0;
                }
                else
                return;

                DataTableReader reader = new DataTableReader(sendME.LoadData(isSendSiteCrashMe, dateTimePeriodKWT.Value.Year, dateTimePeriodKWT.Value.Month));
                //tableDamage = sendME.LoadData(isSendSiteCrashMe, dateTimePeriodKWT.Value.Year, dateTimePeriodKWT.Value.Month);
                tableDamage.Load(reader);

                reader = new DataTableReader(sendME.LoadDataPlan(isSendSitePlanMe, dateTimePeriodKWT.Value.Year, dateTimePeriodKWT.Value.Month));
                tableDamage.Load(reader);

                bsForSendToME.DataSource = tableDamage;
                dgvSendME.DataSource = bsForSendToME;
            }
            else if (this.tabGeneral.SelectedTab == this.tabTSO)
            {
                SendRequestToME sendME = new SendRequestToME();
                sendME.SqlSettings = this.SqlSettings;

                bsTSO.DataSource = sendME.LoadTableTSO(1);
                dgvTSO.DataSource = bsTSO;
            }
        }
        private void FillComboBoxSendME()
        {
           

            bsClassifier.DataSource = Tables.getTextSendSiteME(SqlSettings);

            this.cmbStatusSendME1.Items.Add("Подготовка для корректировки (3)"); // 3
            this.cmbStatusSendME1.Items.Add("Готово для отправки (1)"); // 1
            this.cmbStatusSendME1.Items.Add("Отправленная корректировка (6)"); // 6
            this.cmbStatusSendME1.Items.Add("Ошибка отправки");
            this.cmbStatusSendME1.Items.Add("Все документы");//0
            this.cmbStatusSendME1.SelectedIndex = 0;
            //this.cmbStatusSendME1.SelectionLength = 0;

            Library.Controls.GetDropDownWidth(this, cmbStatusSendME1);
           
        }
        private void toolBtnExportExcel_Click(object sender, EventArgs e)
        {
            if (this.tabGeneral.SelectedTab == this.tabCorr)
                this.dgvSendME.ExportToExcel();
            else if (this.tabGeneral.SelectedTab == this.tabTSO)
                this.dgvTSO.ExportToExcel();
            
        }

        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            //
        }

        private void FormCorrectiveStatements_Load(object sender, EventArgs e)
        {
           

            FillComboBoxSendME();
            Library.Controls.ControlSelectionLengthComboBox(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void dgvSendME_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                e.Cancel = true;
            }
        }

        private void tsbFullXMLTable_Click(object sender, EventArgs e)
        {
            SendRequestToME sendME = new SendRequestToME();
            sendME.SqlSettings = this.SqlSettings;

            this.dataSetStatement.TableForSendToME.Clear();
            DataTable tableDamage = this.dataSetStatement.TableForSendToME;


            int isSendSiteCrashMe = 0;
            //int isSendSitePlanMe = 0; // sendSite = 1
            DataTableReader reader = new DataTableReader(sendME.LoadData(isSendSiteCrashMe, dateTimePeriodKWT.Value.Year, dateTimePeriodKWT.Value.Month));
            tableDamage.Load(reader);

            foreach (DataRow row in tableDamage.Rows)
            {

                //Plan plan;
                //// передаем в конструктор тип класса
                //XmlSerializer formatter = new XmlSerializer(typeof(Plan));
                //// десериализация
                //using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
                //{
                //    plan = (Plan)formatter.Deserialize(fs);
                //}
            }

            //reader = new DataTableReader(sendME.LoadDataPlan(isSendSitePlanMe, dateTimePeriodKWT.Value.Year, dateTimePeriodKWT.Value.Month));
            //tableDamage.Load(reader);

            //bsForSendToME.DataSource = tableDamage;
            //dgvSendME.DataSource = bsForSendToME;
        }
    }
}
