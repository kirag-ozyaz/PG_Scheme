using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataSql;

namespace Legal.Forms
{
    public partial class FormAbnSelectSign : FormLbr.FormBase
    {
        private DateTime DOCDATE;
        public FormAbnSelectSign()
        {
            InitializeComponent();
        }
        
        public FormAbnSelectSign(SQLSettings settings, DateTime DocDate)
        {
            InitializeComponent();
            this.SqlSettings = settings;
            DOCDATE = DocDate;
        }

        private void FormAbnSelectSign_Load(object sender, EventArgs e)
        {
            //SelectSqlData(dsInfo1, dsInfo1.tInfo, false, " where (EntryDate < GETDATE()) AND (LeaveDate > GETDATE())", true);
            //cbSignature.DataSource = dsInfo1.tInfo;
            //cbSignature.DisplayMember = "Info_ChiefSale_Short";
            cbSignature.SelectedIndex = 0;
            dtpDogDate.Value = DOCDATE;

        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            FormAbnDoc_Dogovor frm = (FormAbnDoc_Dogovor)Application.OpenForms["FormAbnDoc_Dogovor"];
            frm.PrilDate = dtpPrilDate.Value;
            frm.DogDate = dtpDogDate.Value;
            frm.Signature = cbSignature.Text;
            frm.PrintState = true;
            Close();
        }

    }
}
