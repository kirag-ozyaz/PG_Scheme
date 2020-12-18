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
    public partial class FormOrderInspection : FormLbr.FormBase
    {
        private int ID;

        public FormOrderInspection()
        {
            InitializeComponent();
        }

        public FormOrderInspection(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormOrderInspection_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbnDocum1, dsAbnDocum1.vWorkerGroup, true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + " order by FIO");

            cmbManager.DataSource = dsAbnDocum1.vWorkerGroup;
            cmbManager.DisplayMember = "FIO";
            cmbManager.ValueMember = "id";

            this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.vWorkerGroup1, "vWorkerGroup", true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + " order by FIO");

            cmbContractor.DataSource = dsAbnDocum1.vWorkerGroup1;
            cmbContractor.DisplayMember = "FIO";
            cmbContractor.ValueMember = "id";

            this.SelectSqlDataTableOther(dsAbnDocum1, dsAbnDocum1.vWorkerGroup2, "vWorkerGroup", true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL.ToString() + " order by FIO");

            cmbMember.DataSource = dsAbnDocum1.vWorkerGroup2;
            cmbMember.DisplayMember = "FIO";
            cmbMember.ValueMember = "id";

            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tJournalOrdersInspection, true, " where id = " + ID);
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + ID);

            cmbManager.SelectedValue = dsAbnDocum1.tJournalOrdersInspection.Rows[0]["idWorkerManager"];
            cmbContractor.SelectedValue = dsAbnDocum1.tJournalOrdersInspection.Rows[0]["idWorkerContractor"];
            cmbMember.SelectedValue = dsAbnDocum1.tJournalOrdersInspection.Rows[0]["idWorkerMember"];

            txtNumberDocum.Text = dsAbnDocum1.tJournalOrdersInspection.Rows[0]["NumberOrder"].ToString();
            dtDocum.Value = Convert.ToDateTime(dsAbnDocum1.tJournalOrdersInspection.Rows[0]["DateOrder"]);

            //txtAuthor.Text = dsAbnDocum1.tJournalOrdersInspection.Rows[0]["AuthorOrder"].ToString();
            //dtAuthor.Value = Convert.ToDateTime(dsAbnDocum1.tJournalOrdersInspection.Rows[0]["DateCurrent"]);

            if (dsAbnDocum1.tJournalOrdersInspection.Rows[0]["NumberJournal"] != DBNull.Value)
                txtNumberJournal.Text = dsAbnDocum1.tJournalOrdersInspection.Rows[0]["NumberJournal"].ToString();
            if (dsAbnDocum1.tJournalOrdersInspection.Rows[0]["DateJournal"] != DBNull.Value)
                dtJournal.Value = Convert.ToDateTime(dsAbnDocum1.tJournalOrdersInspection.Rows[0]["DateJournal"]);


            //if (DateTime.Now.Date > dtAuthor.Value)
            //{
            //    int ts = (DateTime.Now - dtAuthor.Value).Days;
            //    if (ts  > 3)
            //    {
            //        dtDocum.Enabled = false;

            //        cmbContractor.Enabled = false;
            //        cmbManager.Enabled = false;

            //        btnAddObject.Enabled = false;
            //        btnDelObject.Enabled = false;

            //        btnAddRow.Enabled = false;
            //        btnEditRow.Enabled = false;

            //        txtNumberJournal.Enabled = false;
            //        dtJournal.Enabled = false;

            //        chkStatus.Checked = true;
            //        chkStatus.Enabled = false;

            //        btnOK.Enabled = false;
            //    }
            //}

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((cmbManager.SelectedValue == null) || (cmbContractor.SelectedValue == null))
            {
                MessageBox.Show("Заполните поля <Исполнитель> и <Выдал> перед сохранением ...");
                return;
            }
            else
            {
                int MaxNumber = 0;
                if (txtNumberDocum.Text == "")
                {
                    // найдем максимальный номер документа
                    int dtYear = dtDocum.Value.Year;
                    SelectSqlData(dsAbnDocum1, dsAbnDocum1.vJournalOrdersInspection, true, " where Year(DateOrder) = " + dtYear + " and NumberOrder is not null order by NumberOrder desc");
                    if (dsAbnDocum1.vJournalOrdersInspection.Rows.Count > 0)
                        MaxNumber = (int)dsAbnDocum1.vJournalOrdersInspection.Rows[0]["NumberOrder"];
                    MaxNumber = MaxNumber + 1;
                    txtNumberDocum.Text = MaxNumber.ToString();
                }

                dsAbnDocum1.tJournalOrdersInspection.Rows[0].BeginEdit();
                if (MaxNumber > 0)
                    dsAbnDocum1.tJournalOrdersInspection.Rows[0]["NumberOrder"] = MaxNumber;
                dsAbnDocum1.tJournalOrdersInspection.Rows[0]["DateOrder"] = dtDocum.Value;
                dsAbnDocum1.tJournalOrdersInspection.Rows[0]["idWorkerManager"] = cmbManager.SelectedValue;
                dsAbnDocum1.tJournalOrdersInspection.Rows[0]["idWorkerContractor"] = cmbContractor.SelectedValue;
                
                if (cmbMember.SelectedValue != null)
                    dsAbnDocum1.tJournalOrdersInspection.Rows[0]["idWorkerMember"] = cmbMember.SelectedValue;

                dsAbnDocum1.tJournalOrdersInspection.Rows[0]["NumberJournal"] = txtNumberJournal.Text;
                dsAbnDocum1.tJournalOrdersInspection.Rows[0]["DateJournal"] = dtJournal.Value;

                dsAbnDocum1.tJournalOrdersInspection.Rows[0].EndEdit();
                bool isOk = false;
                isOk = UpdateSqlData(dsAbnDocum1, dsAbnDocum1.tJournalOrdersInspection);
                if (isOk) this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Document.FormOrderObjectAdd fAdd = new Document.FormOrderObjectAdd(ID);
            fAdd.SqlSettings = this.SqlSettings;
            fAdd.ShowDialog();
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + ID);
            Cursor.Current = Cursors.Default;
        }

        private void btnDelObject_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dgvObject.CurrentRow.Cells["DGVid"].Value);
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tOrdersInspection, true, " where id = " + i);
            dsAbnDocum1.tOrdersInspection.Rows[0].BeginEdit();
            dsAbnDocum1.tOrdersInspection.Rows[0]["Deleted"] = -1;
            dsAbnDocum1.tOrdersInspection.Rows[0].EndEdit();
            UpdateSqlData(dsAbnDocum1, dsAbnDocum1.tOrdersInspection);
            dsAbnDocum1.tOrdersInspection.Rows.Clear();
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + ID);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormRep.FormRepOrder fOrder = new FormRep.FormRepOrder(ID);
            fOrder.SqlSettings = this.SqlSettings;
            fOrder.ShowDialog();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.vJournalOrdersInspection_Log, true, " where id_Journal = " + ID + " order by DateCommand desc");
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection_Log, true, " where idJournal = " + ID + " order by DateCommand desc");
            }


        }

        //private void btnAddObject_Graph_Click(object sender, EventArgs e)
        //{
        //    Cursor.Current = Cursors.WaitCursor;
        //    GraphicsInspector.FormGraphicsView fAdd = new GraphicsInspector.FormGraphicsView();
        //    fAdd.SqlSettings = this.SqlSettings;
        //    fAdd.ShowDialog();
        //    SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + ID);
        //    Cursor.Current = Cursors.Default;
        //}

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            Document.FormOrderAddEdit fAdd = new Document.FormOrderAddEdit(-1, true, ID);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + ID);
            }

        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            if (dgvObject.CurrentRow != null)
            {
                int idRowCur = Convert.ToInt32(dgvObject.CurrentRow.Cells["dgvID"].Value);

                Document.FormOrderAddEdit fAdd = new Document.FormOrderAddEdit(Convert.ToInt32(dgvObject.CurrentRow.Cells["dgvID"].Value), false, ID);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + ID);
                }

                dgvObject.CurrentRow.Selected = false;
                for (int i = 0; i < dgvObject.Rows.Count; i++)
                {
                    if ((int)dgvObject.Rows[i].Cells["dgvID"].Value == idRowCur)
                    {
                        //dgvObject.CurrentCell = dgvObject.Rows[i].Cells["dgvID"];
                        dgvObject.Rows[i].Selected = true;
                        break;
                    }
                }

            }
        }

        private void dgvObject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvObject.CurrentRow != null) && (chkStatus.Checked == false))
            {
                int idRowCur = Convert.ToInt32(dgvObject.CurrentRow.Cells["dgvID"].Value);

                Document.FormOrderAddEdit fAdd = new Document.FormOrderAddEdit(Convert.ToInt32(dgvObject.CurrentRow.Cells["dgvID"].Value), false, ID);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    SelectSqlData(dsAbnDocum1, dsAbnDocum1.vOrdersInspection, true, " where idJournal = " + ID);
                }

                dgvObject.CurrentRow.Selected = false;
                for (int i = 0; i < dgvObject.Rows.Count; i++)
                {
                    if ((int)dgvObject.Rows[i].Cells["dgvID"].Value == idRowCur)
                    {
                        //dgvObject.CurrentCell = dgvObject.Rows[i].Cells["dgvID"];
                        dgvObject.Rows[i].Selected = true;
                        break;
                    }
                }
            }
        }

        private void dgvObject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        btnDelObject.PerformClick();
                        break;
                    case Keys.Enter:
                        btnEditRow.PerformClick();
                        break;
                    case Keys.Insert:
                        btnAddRow.PerformClick();
                        break;
                    case Keys.Add:
                        btnAddObject.PerformClick();
                        break;
                }
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            if (dgvObject.CurrentRow.Cells["idObj"].Value != System.DBNull.Value)
            {
                FormOrderAct frm = new FormOrderAct(Convert.ToInt32(dgvObject.CurrentRow.Cells["idObj"].Value), (DateTime)dtDocum.Value.Date, ID);
                frm.SqlSettings = this.SqlSettings;
                //frm.MdiParent = this.MdiParent;
                //frm.Show();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }
    }
}
