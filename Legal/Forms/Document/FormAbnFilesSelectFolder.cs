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
    public partial class FormAbnFilesSelectFolder : FormLbr.FormBase
    {
        private int idAbn;
        private int parID;
        private int selectedFolder;

        public int SelectedFolder
        {
            get
            {
                return selectedFolder;
            }
        }
        
        public FormAbnFilesSelectFolder()
        {
            InitializeComponent();
        }

        public FormAbnFilesSelectFolder(int idAbn, int parID)
        {
            InitializeComponent();
            this.idAbn = idAbn;
            this.parID = parID;
        }

        private void FormAbnFilesSelectFolder_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, " where id = 510 or (isGroup = 1 and Deleted = 0 and idAbn = " + idAbn.ToString() +" and id <> " + parID.ToString() + " ) order by idAbn");
        }

        private void dataGridViewFolders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewFolders.CurrentRow != null)
            {
                selectedFolder = Convert.ToInt32(dataGridViewFolders.CurrentRow.Cells["id"].Value);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
