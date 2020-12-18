using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Document
{
    public partial class FormOrderObjectAdd : FormLbr.FormBase
    {
        private int IDJournal;

        public FormOrderObjectAdd()
        {
            InitializeComponent();
        }

        public FormOrderObjectAdd(int idJournal)
        {
            InitializeComponent();
            IDJournal = idJournal;
        }

        private void FormOrderObjectAdd_Load(object sender, EventArgs e)
        {
            SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.vG_GraphicPointViewSmall, "vG_GraphicPointViewSmall2", true, " order by codeAbonent, NumberObj");
        }

        private void cmbAdd_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgvObject.RowCount; i++)
            {
                dgvObject.Rows[i].Cells["SelectCell"].Value = true;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cmbDel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgvObject.RowCount; i++)
            {
                dgvObject.Rows[i].Cells["SelectCell"].Value = false;
            }
            Cursor.Current = Cursors.Default;

        }

        private void cmbAddObject_Click(object sender, EventArgs e)
        {
            int j = 0;

            for (int i = 0; i < dgvObject.RowCount; i++)
            {
                if (dgvObject.Rows[i].Cells["SelectCell"].Value != null)
                {
                    if ((bool)dgvObject.Rows[i].Cells["SelectCell"].Value)
                    {
                        this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.vG_GraphicPointOrder1, "vG_GraphicPointOrder", true, " where idObj = " + dgvObject.Rows[i].Cells["idObj"].Value.ToString());

                        for (int k = 0; k < dsAbnDocum1.vG_GraphicPointOrder1.Rows.Count; k++)
                        {
                            DataRow dr = dsAbnDocum1.tOrdersInspection.NewRow();
                            dr["CodeAbonent"] = (int)dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["CodeAbonent"];
                            dr["TypeAbn"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["TypeAbn"];
                            dr["Name"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["Name"];
                            dr["AbnPhone"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["AbnPhone"];
                            dr["Deleted"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["Deleted"];
                            dr["idObj"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["idObj"];
                            dr["NumberObj"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["NumberObj"];
                            dr["NameObj"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["NameObj"];
                            dr["ObjAdress"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["ObjAdress"];
                            dr["idAbn"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["idAbn"];
                            dr["idPoint"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["idPoint"];
                            dr["Number"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["Number"];
                            dr["NameMeter"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["NameMeter"];
                            dr["DateBegin"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["DateBegin"];
                            dr["MeterDCheck"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["MeterDCheck"];
                            dr["MeterDCheckStr"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["MeterDCheckStr"];
                            dr["GosEndMeter"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["GosEndMeter"];
                            dr["NameTrans"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["NameTrans"];
                            dr["TypeTrans"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["TypeTrans"];
                            dr["TransDCheck"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["TransDCheck"];
                            dr["TransDCheckStr"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["TransDCheckStr"];
                            dr["GosEndTrans"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["GosEndTrans"];
                            dr["Ktran"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["Ktran"];
                            dr["Values"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["Values"];
                            dr["DateAct"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["DateAct"];
                            dr["PowerSet"] = dsAbnDocum1.vG_GraphicPointOrder1.Rows[k]["PowerSet"];
                            dr["idJournal"] = IDJournal;
                            dsAbnDocum1.tOrdersInspection.Rows.Add(dr);
                            dsAbnDocum1.tOrdersInspection.Rows[j++].EndEdit();
                        }
                    }
                }
            }
            if (dsAbnDocum1.tOrdersInspection.Rows.Count > 0)
                InsertSqlData(dsAbnDocum1, dsAbnDocum1.tOrdersInspection);

            this.Close();

        }

        private void dgvObject_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvObject.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                dgvObject.Focus();
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < dgvObject.RowCount; i++)
                if (dgvObject[1, i].FormattedValue.ToString().
                    Contains(txtCode.Text.Trim()))
                {
                    dgvObject.CurrentCell = dgvObject[1, i];
                    return;
                }
        }

        private void cmbAddObjectAddress_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string street = dgvObject.CurrentRow.Cells["nameStreet"].Value.ToString();
            string socr = dgvObject.CurrentRow.Cells["socr"].Value.ToString();
            int house = (int)dgvObject.CurrentRow.Cells["house"].Value;
            string housePrefix = dgvObject.CurrentRow.Cells["housePrefix"].Value.ToString();

            for (int i = 0; i < dgvObject.RowCount; i++)
            {
                if((dgvObject.Rows[i].Cells["nameStreet"].Value.ToString() == street) && (dgvObject.Rows[i].Cells["socr"].Value.ToString() == socr))
                    if (((int)dgvObject.Rows[i].Cells["house"].Value == house) && (dgvObject.Rows[i].Cells["housePrefix"].Value.ToString() == housePrefix))
                        dgvObject.Rows[i].Cells["SelectCell"].Value = true;
            }
            Cursor.Current = Cursors.Default;

        }



    }
}
