using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Object
{
    public partial class FormObjEditComment : FormLbr.FormBase
    {
        int idobj = -1;
        string strObj = "";

        public FormObjEditComment()
        {
            InitializeComponent();
        }

        public FormObjEditComment(int idObj,string strObj)
        {
            InitializeComponent();
            this.idobj = idObj;
            this.strObj = strObj;
        }

        private void FormObjEditComment_Load(object sender, EventArgs e)
        {
            this.Text += " " + strObj ;

            if (this.SelectSqlData(dsAbn.tAbnObjReg, true, " where idAbnObj = " + idobj.ToString()+ " order by DateChange desc", null, false,1))
            {
                if (dsAbn.tAbnObjReg.Rows.Count > 0)
                {
                    rtbComment.Text = dsAbn.tAbnObjReg.Rows[0]["Comment"].ToString();
                }
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            dsAbn.tAbnObjReg.Rows[0]["Comment"] = rtbComment.Text;
            dsAbn.tAbnObjReg.Rows[0].EndEdit();
            this.UpdateSqlData(dsAbn, dsAbn.tAbnObjReg);
             
        }

    }
}
