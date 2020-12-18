using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAbnDocum : FormLbr.FormBase
    {
        private int IDABN;

 
        public FormAbnDocum()
        {
            InitializeComponent();
        }
        public FormAbnDocum(int idAbn)
        {
            InitializeComponent();
            IDABN = idAbn;
        }
        
        // новый договор
        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbnDoc_Dogovor fDog = new FormAbnDoc_Dogovor(IDABN, -1, (int)Constants.DocType.Dogovor, true);
            fDog.SqlSettings = this.SqlSettings;
            if (fDog.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbnDocum, dsAbnDocum.vAbnDoc_List, true, " where idAbn = " + IDABN.ToString() + "order By DocDate");
            }
        }

        private void FormAbnDocum_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnDocum, dsAbnDocum.vAbnDoc_List, true, " where idAbn = " + IDABN.ToString() + "order By DocDate");
        }

        // редактировать документ
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocList.RowCount > 0)
            {
                int idType = Convert.ToInt32(dataGridViewDocList.CurrentRow.Cells["idDocType"].Value);
                int IDLIST = Convert.ToInt32(dataGridViewDocList.CurrentRow.Cells["id"].Value);

                switch (idType)
                {
                    case (int)Constants.DocType.Dogovor:
                        FormAbnDoc_Dogovor fDog = new FormAbnDoc_Dogovor(IDABN, IDLIST, (int)Constants.DocType.Dogovor, false);
                        fDog.SqlSettings = this.SqlSettings;
                        if (fDog.ShowDialog() == DialogResult.OK)
                        {
                            this.SelectSqlData(dsAbnDocum, dsAbnDocum.vAbnDoc_List, true, " where idAbn = " + IDABN.ToString() + "order By DocDate");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dsAbnDocum.vAbnDoc_List.Rows.Count > 0)
            {
                const string message = "Вы хотите удалить этот документ?";
                const string caption = "Удаление документа";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    int idType = Convert.ToInt32(dataGridViewDocList.CurrentRow.Cells["idDocType"].Value);
                    int IDLIST = Convert.ToInt32(dataGridViewDocList.CurrentRow.Cells["id"].Value);

                    switch (idType)
                    {
                        case (int)Constants.DocType.Dogovor:
                            this.SelectSqlData(dsAbnDocum, dsAbnDocum.tAbnDoc_Dogovor, true, " where idList = " + IDLIST.ToString());
                            DataRow[] row = dsAbnDocum.tAbnDoc_Dogovor.Select();
                            int IDDOG = Convert.ToInt32(row[0]["id"]);

                            if (DeleteSqlDataById(dsAbnDocum.tAbnDoc_Dogovor, IDDOG))
                            {
                                if (DeleteSqlDataById(dsAbnDocum.tAbnDoc_List, IDLIST) == true)
                                    MessageBox.Show("Документ успешно удален");
                            }
                            this.SelectSqlData(dsAbnDocum, dsAbnDocum.vAbnDoc_List, true, " where idAbn = " + IDABN.ToString() + "order By DocDate");
                            break;
                        default:
                            break;
                    }

                }

            }
        }
    }
}
