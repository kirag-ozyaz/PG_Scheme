using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Abonent
{
    public partial class FormCopyDoc : FormLbr.FormBase
    {
        private int CA = -1;
        private int idCA = -1;
        private int idPoint = -1;
        private int DocType = -1;

        private int destinationCA;

        public int DestinationCA
        {
            get
            {
                return destinationCA;
            }
        }

        public FormCopyDoc()
        {
            InitializeComponent();
        }

        public FormCopyDoc(int id, int CodeAbonent, int idPoint,int DocType)
        {
            InitializeComponent();
            idCA = id;
            CA = CodeAbonent;
            this.idPoint = idPoint;
            this.DocType = DocType;
        }

        private void FormCopyDoc_Load(object sender, EventArgs e)
        {
            tbAbn.Text = (CA - 1).ToString();
            FindLS(Convert.ToInt32(tbAbn.Text), (int)Constants.AbnType.Private, false);
            this.SelectSqlData(dsAbn, dsAbn.tR_Classifier, true, " where ParentKey in (';TypeDoc;tDocAct;') and isGroup = 0 and deleted = 0");
            comboBoxTypeDoc.SelectedValue = DocType;
            this.SelectSqlData(dsAbn, dsAbn.vR_Zone, true, "");
            comboBoxZone.SelectedValue = 262;
        }

        private void FindLS(int findLS, int typeAbn, bool withDel)
        {
            string where = "";

            if (typeAbn != -1)  // Если выбрали какой то тип
                where = " and TypeAbn = " + typeAbn.ToString();
            where = (withDel) ? where + "" : (where == "") ? " and deleted = 0 " :
                where + " and deleted = 0 ";

            DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();

            where = " where CodeABonent = " + tbAbn.Text + " and TypeAbn = " + ((int)Constants.AbnType.Private).ToString() + where;

            this.SelectSqlData(ds.tAbn, true, where, null, false, 1);
            if (ds.tAbn.Rows.Count > 0) // нашли
            {
                tbAbn.BackColor = Color.LightGreen;
                idCA = (int)ds.tAbn.Rows[0]["id"];
                this.SelectSqlData(dsAbn, dsAbn.vAbnObjPointName, true, " where  CodeAbonent = " + ds.tAbn.Rows[0]["CodeAbonent"].ToString()
                                                                          + " and TypeAbn = " + ((int)Constants.AbnType.Private).ToString());
                
            }
            else
            {
                tbAbn.BackColor = Color.LightCoral;
                dsAbn.vAbnObjPointName.Clear();
                idCA = -1;
                MessageBox.Show("Лицевой счет не найден");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAbnSearch_Click(object sender, EventArgs e)
        {
            FindLS(Convert.ToInt32(tbAbn.Text), (int)Constants.AbnType.Private, false);
        }

        private void tbAbn_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                FindLS(Convert.ToInt32(tbAbn.Text), (int)Constants.AbnType.Private, false);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (comboBoxObj.SelectedValue != null)
            {
                DialogResult dialogResult = MessageBox.Show(comboBoxTypeDoc.Text + " в " + comboBoxObj.Text + ' ' + comboBoxZone.Text
                                                            , "Копирование", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                             try
                             {
                                 con.OpenConnection(SqlSettings);

                                 SqlCommand sqlcom = new SqlCommand("sp_CopyPointDoc", con.Connection);
                                 sqlcom.CommandType = CommandType.StoredProcedure;

                                 sqlcom.Parameters.Add("@idPointSource", SqlDbType.Int);
                                 sqlcom.Parameters["@idPointSource"].Value = idPoint;
                                 sqlcom.Parameters.Add("@idPointDestination", SqlDbType.Int);
                                 sqlcom.Parameters["@idPointDestination"].Value = (int)comboBoxObj.SelectedValue;
                                 sqlcom.Parameters.Add("@DateBeg", SqlDbType.SmallDateTime);
                                 sqlcom.Parameters["@DateBeg"].Value = dtpDateBeg.Value;
                                 sqlcom.Parameters.Add("@DateEnd", SqlDbType.SmallDateTime);
                                 sqlcom.Parameters["@DateEnd"].Value = dtpDateEnd.Value;
                                 sqlcom.Parameters.Add("@idZone", SqlDbType.Int);
                                 sqlcom.Parameters["@idZone"].Value = (int)comboBoxZone.SelectedValue;
                                 sqlcom.Parameters.Add("@TypeDoc", SqlDbType.Int);
                                 sqlcom.Parameters["@TypeDoc"].Value = (int)comboBoxTypeDoc.SelectedValue;

                                 sqlcom.ExecuteNonQuery();

                             }
                             catch (Exception ex) // ошибка соединения
                             {
                                 MessageBox.Show(ex.Message, ex.Source);
                             }
                             finally
                             {
                                 con.CloseConnection();
                                 MessageBox.Show("Данные успешно скопированы.");
                                 destinationCA = Convert.ToInt32(tbAbn.Text);
                                 this.DialogResult = DialogResult.OK;
                             }
                    
                }
            }
        }
    }
}
