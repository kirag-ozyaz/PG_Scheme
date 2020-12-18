using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormAuthorizedPerson : FormLbr.FormBase
    {
        private DataRow LastDataRow = null;

        public FormAuthorizedPerson()
        {
            InitializeComponent();
        }

        private void FormAuthorizedPerson__Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCntVal1, dsCntVal1.tG_AuthorPerson, true);
            // платежные документы
            SelectSqlData(dsCntVal1, dsCntVal1.tR_Classifier, true, " where ParentID = " + Constants.Constants.PaymentDoc);
            // приказы 
            SelectSqlDataTableOther(dsCntVal1, dsCntVal1.tR_Classifier1, "tR_Classifier", true, " where ParentID = " + Constants.Constants.DocSignat);
            // уполн. лица
            SelectSqlData(dsCntVal1, dsCntVal1.vWorkerGroup, true, " where idGroup = " + Constants.Constants.WorkerGroupAuthorPerson);
        }

        private void UpdateRowToDatabase()
        {
            if (LastDataRow != null)
            {
                if (LastDataRow.RowState == DataRowState.Modified)
                {
                    UpdateSqlData(dsCntVal1, dsCntVal1.tG_AuthorPerson);
                }
            }
        }

        private void FormAuthorizedPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dsCntVal1.tG_AuthorPerson.Rows.Count > 0)
            {
                for (int curRow = 0; curRow < dsCntVal1.tG_AuthorPerson.Rows.Count; curRow++)
                {
                    if (dsCntVal1.tG_AuthorPerson.Rows[curRow].RowState == DataRowState.Added)
                        InsertSqlDataOneRow(dsCntVal1,dsCntVal1.tG_AuthorPerson);
                    if (dsCntVal1.tG_AuthorPerson.Rows[curRow].RowState == DataRowState.Modified)
                        UpdateSqlData(dsCntVal1, dsCntVal1.tG_AuthorPerson);
                    if (dsCntVal1.tG_AuthorPerson.Rows[curRow].RowState == DataRowState.Deleted)
                        DeleteSqlData(dsCntVal1, dsCntVal1.tG_AuthorPerson);
                }
            }
        }

        private void dsCntValBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // if the user moves to a new row, check if the 
            // last row was changed
            BindingSource thisBindingSource = (BindingSource)sender;
            DataRow ThisDataRow = ((DataRowView)thisBindingSource.Current).Row;
            if (ThisDataRow == LastDataRow)
            {
                // we need to avoid to write a datarow to the 
                // database when it is still processed. Otherwise
                // we get a problem with the event handling of 
                //the DataTable.
                throw new ApplicationException("It seems the" +
                  " PositionChanged event was fired twice for" +
                  " the same row");
            }
            UpdateRowToDatabase();
            // track the current row for next 
            // PositionChanged event
            LastDataRow = ThisDataRow;
        }

        private void dgvAuthorPerson_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 
        }
    }

}
