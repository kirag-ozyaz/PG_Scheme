using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Meter
{
    public partial class FormPointKLoss : FormLbr.FormBase
    {
        private int id;
        private int idPoint;
        private ActionKLoss act;

        public enum ActionKLoss
        {
            /// Добавить
            Add,
            /// Редактировать
            Edit,
        }


        public FormPointKLoss()
        {
            InitializeComponent();
        }

        public FormPointKLoss(int id, int idPoint, ActionKLoss Act)
        {
            InitializeComponent();
            this.id = id;
            this.idPoint = idPoint;

            switch (Act)
            {
                case ActionKLoss.Add:
                    this.Text = "Добавить потери";
                    act = ActionKLoss.Add;
                    break;

                case ActionKLoss.Edit:
                    this.Text = "Редактировать потери";
                    act = ActionKLoss.Edit;
                    break;
            }

        }

        private void FormPointKLoss_Load(object sender, EventArgs e)
        {
            if (act == ActionKLoss.Edit)
            {
                SelectSqlData(dsAbn, dsAbn.tG_PointKLossTrans, true, " where  id = " + id.ToString());
                if (dsAbn.tG_PointKLossTrans.Rows.Count > 0)
                {
                    dtDateChange.Value = Convert.ToDateTime(dsAbn.tG_PointKLossTrans[0]["DateChange"]);
                    numKLoss.Value = Convert.ToDecimal(dsAbn.tG_PointKLossTrans[0]["KLoss"]);
                    txtComment.Text = dsAbn.tG_PointKLossTrans[0]["Comment"].ToString();
                }

            }
            else
            {
                dtDateChange.Value = System.DateTime.Today;
                numKLoss.Value = 0;
                txtComment.Text = "";
                DataRow dr = dsAbn.tG_PointKLossTrans.NewRow();
                dr["idPoint"] = idPoint;
                dr["Date"] = System.DateTime.Today;
                dr["DateChange"] = System.DateTime.Today;
                dr["KLoss"] = 0;
                dr["Deleted"] = 0;
                dsAbn.tG_PointKLossTrans.Rows.Add(dr);
            }

        }

        private int InsertKLoss()
        {
            dsAbn.tG_PointKLossTrans.Rows[0]["DateChange"] = dtDateChange.Value;
            dsAbn.tG_PointKLossTrans.Rows[0]["KLoss"] = numKLoss.Value;
            dsAbn.tG_PointKLossTrans.Rows[0]["Comment"] = txtComment.Text;

            dsAbn.tG_PointKLossTrans.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsAbn, dsAbn.tG_PointKLossTrans);
        }

        private bool UpdateKLoss()
        {
            if (dsAbn.tG_PointKLossTrans.Rows.Count > 0)
            {
                dsAbn.tG_PointKLossTrans.Rows[0]["DateChange"] = dtDateChange.Value;
                dsAbn.tG_PointKLossTrans.Rows[0]["KLoss"] = numKLoss.Value;
                dsAbn.tG_PointKLossTrans.Rows[0]["Comment"] = txtComment.Text;

                dsAbn.tG_PointKLossTrans.Rows[0].EndEdit();

                return this.UpdateSqlData(dsAbn, dsAbn.tG_PointKLossTrans);
            }
            else
                return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (act == ActionKLoss.Edit)
            {

                if (!UpdateKLoss())
                {
                    MessageBox.Show("Не удается отредактировать потери ");
                    return;
                }
            }
            else
            {
                if (InsertKLoss() < 0)
                {
                    MessageBox.Show("Не удается создать потери");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }




    }
}
