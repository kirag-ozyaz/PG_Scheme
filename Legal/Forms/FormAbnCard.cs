using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Legal.Forms.Object;

namespace Legal.Forms
{
    public partial class FormAbnCard : FormLbr.FormBase
    {
        private int ID;
        private int IDWORKER;
        private int BANKID;
        private int BANKID1;
        private int IDOBJSELECT;

        public FormAbnCard()
        {
            InitializeComponent();
        }
        
        public FormAbnCard(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormAbnCard_Load(object sender, EventArgs e)
        {
            // код и наименование потребителя
            this.SelectSqlData(dsAbnCard1, dsAbnCard1.tAbn, true, " where id = " + ID.ToString(), 1);
            // обслуживающий специалист
            if (dsAbnCard1.tAbn.Rows[0]["idWorker"] != DBNull.Value)
            {
                IDWORKER = (int)dsAbnCard1.tAbn.Rows[0]["idWorker"];
                this.SelectSqlData(dsAbnCard1, dsAbnCard1.tR_Worker, true, " where id = " + IDWORKER.ToString(), 1);
            }
            // реквизиты
            this.SelectSqlData(dsAbnCard1, dsAbnCard1.tG_AbnInfo, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
            // банк плательщика
            if (dsAbnCard1.tG_AbnInfo.Rows[0]["BankID"] != DBNull.Value)
            {
                BANKID = (int)dsAbnCard1.tG_AbnInfo.Rows[0]["BankID"];
                this.SelectSqlData(dsAbnCard1, dsAbnCard1.tBanks, true, " where BankID = " + BANKID.ToString(), 1);
            }
            // банк получателя
            if (dsAbnCard1.tG_AbnInfo.Rows[0]["BankDest"] != DBNull.Value)
            {
                BANKID1 = (int)dsAbnCard1.tG_AbnInfo.Rows[0]["BankDest"];
                this.SelectSqlDataTableOther(dsAbnCard1, dsAbnCard1.tBanks1,"tBanks", true, " where BankID = " + BANKID1.ToString(), 1);
            }

            // адрес
            this.SelectSqlData(dsAbnCard1, dsAbnCard1.tG_AbnAddress, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
            // руководитель
            this.SelectSqlData(dsAbnCard1, dsAbnCard1.tG_AbnChief, true, " where idAbn = " + ID.ToString() + " order by DateChange desc", 1);
            // филиал
            this.SelectSqlData(dsAbnCard1, dsAbnCard1.tG_AbnParent, true, " where idAbn = " + ID.ToString(), 1);
            // контакты
            this.SelectSqlData(dsAbnCard1, dsAbnCard1.tAbnContact, true, " where idAbn = " + ID.ToString(), 1);
            // обьекты
            this.SelectSqlData(dsAbnCard1, dsAbnCard1.vG_Obj, true, " where idAbn = " + ID.ToString());

        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            FormObjAddEdit fAdd = new FormObjAddEdit(-1, -1, FormObjAddEdit.ActionAbnObj.Add, FormObjAddEdit.ActionAbnObjReg.Add,ID);
            fAdd.SqlSettings = this.SqlSettings;

            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbnCard1, dsAbnCard1.vG_Obj, true, " where idAbn = " + ID.ToString(), 1);
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idCol"].Value);
            //int id1 = Convert.ToInt32(dataGridViewObj.CurrentRow.Cells["idReg"].Value);
            FormObjAddEdit fAdd = new FormObjAddEdit(id, -1, FormObjAddEdit.ActionAbnObj.Edit, FormObjAddEdit.ActionAbnObjReg.Edit,ID);
            fAdd.SqlSettings = this.SqlSettings;

            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsAbnCard1, dsAbnCard1.vG_Obj, true, " where idAbn = " + ID.ToString(), 1);
            }
        }

        // удаление объекта из списка
        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            int IDOBJSELECT = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idCol"].Value);
            // удаляем владельца объекта в tAbnObj
            this.SelectSqlData(dsAbnCard1, dsAbnCard1.tAbnObj, true, " where id = " + IDOBJSELECT.ToString());
            dsAbnCard1.tAbnObj.Rows[0]["idAbn"] = 0;
            dsAbnCard1.tAbnObj.Rows[0].EndEdit();
            UpdateSqlData(dsAbnCard1, dsAbnCard1.tAbnObj);

            // записываем новые параметры объекта в tAbnObjReg
            DataTable dt = dsAbnCard1.tAbnObjReg;
            this.SelectSqlData(dsAbnCard1, dt, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DateChange desc", 1);
            DataRow dr = dt.NewRow();
            dr["idAbn"] = 0;
            dr["DateChange"] = System.DateTime.Now.Date;
            dr["idAbnObj"] = dt.Rows[0]["idAbnObj"];
            dr["idAbnNet"] = dt.Rows[0]["idAbnNet"];
            dr["idAbnSale"] = dt.Rows[0]["idAbnSale"];
            dr["idStatus"] = dt.Rows[0]["idStatus"];
            dr["idPermit"] = dt.Rows[0]["idPermit"];
            dr["Regime"] = dt.Rows[0]["Regime"];
            dr["PowerSet"] = dt.Rows[0]["PowerSet"];
            dr["PowerOther"] = dt.Rows[0]["PowerOther"];
            dr["PowerFact"] = dt.Rows[0]["PowerFact"];
            dr["KLoss"] = dt.Rows[0]["Kloss"];
            dr["Category"] = dt.Rows[0]["Category"];
            dr["Comment"] = dt.Rows[0]["Comment"];

            dsAbnCard1.tAbnObjReg.Rows.Add(dr);

            InsertSqlData(dsAbnCard1, dt);

            this.SelectSqlData(dsAbnCard1, dsAbnCard1.vG_Obj, true, " where idAbn = " + ID.ToString());
            

        }

        // добавление существующего объекта в список
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormObjSelect fSelect = new FormObjSelect(ID, 0, FormObjSelect.SelectionMethod.Many);
            fSelect.SqlSettings = this.SqlSettings;
            if (fSelect.ShowDialog() == DialogResult.OK)
            {
                IDOBJSELECT = fSelect.idObjPar;
                // меняем владельца объекта в tAbnObj
                this.SelectSqlData(dsAbnCard1, dsAbnCard1.tAbnObj, true, " where id = " + IDOBJSELECT.ToString());
                dsAbnCard1.tAbnObj.Rows[0]["idAbn"] = ID;
                dsAbnCard1.tAbnObj.Rows[0].EndEdit();
                UpdateSqlData(dsAbnCard1, dsAbnCard1.tAbnObj);

                // записываем новые параметры объекта в tAbnObjReg
                DataTable dt = dsAbnCard1.tAbnObjReg;
                this.SelectSqlData(dsAbnCard1, dt, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DateChange desc", 1);
                DataRow dr = dt.NewRow();
                dr["idAbn"] = ID;
                dr["DateChange"] = System.DateTime.Now.Date;
                dr["idAbnObj"] = dt.Rows[0]["idAbnObj"];
                dr["idAbnNet"] = dt.Rows[0]["idAbnNet"];
                dr["idAbnSale"] = dt.Rows[0]["idAbnSale"];
                dr["idStatus"] = dt.Rows[0]["idStatus"];
                dr["idPermit"] = dt.Rows[0]["idPermit"];
                dr["Regime"] = dt.Rows[0]["Regime"];
                dr["PowerSet"] = dt.Rows[0]["PowerSet"];
                dr["PowerOther"] = dt.Rows[0]["PowerOther"];
                dr["PowerFact"] = dt.Rows[0]["PowerFact"];
                dr["KLoss"] = dt.Rows[0]["Kloss"];
                dr["Category"] = dt.Rows[0]["Category"];
                dr["Comment"] = dt.Rows[0]["Comment"];

                dsAbnCard1.tAbnObjReg.Rows.Add(dr);
                
                InsertSqlData(dsAbnCard1, dt);

                this.SelectSqlData(dsAbnCard1, dsAbnCard1.vG_Obj, true, " where idAbn = " + ID.ToString());
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

 

 
    }
}
