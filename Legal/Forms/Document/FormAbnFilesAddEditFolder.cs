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
    public partial class FormAbnFilesAddEditFolder : FormLbr.FormBase
    {
        private int idAbn;
        private int idFolder;
        private bool isInsert = true;// добавить папку по умолчанию


        public FormAbnFilesAddEditFolder()
        {
            InitializeComponent();
        }

        public FormAbnFilesAddEditFolder(int idAbn,int idFolder, bool isInsert)
        {
            InitializeComponent();
            this.idAbn = idAbn;
            this.idFolder = idFolder;
            this.isInsert = isInsert;
            this.Text = (isInsert) ? "Добавление папки" : "Редактирование папки";
        }

        private void FormAbnFilesAddFolder_Load(object sender, EventArgs e)
        {
            if (isInsert) // добавление
            {
                DataRow r = dsAbn.tAbn_Files.NewRow();
                r["idAbn"] = idAbn;
                r["Deleted"] = 0;
                r["ParentID"] = idFolder;
                r["IsGroup"] = 1;
                r["Date"] = System.DateTime.Now;
                dsAbn.tAbn_Files.Rows.Add(r);
            }
            else //редактирование
            {
                this.SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, " where id = " + idFolder.ToString());
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            if (isInsert)
            {
                dsAbn.tAbn_Files.Rows[0].EndEdit();
                idFolder = this.InsertSqlDataOneRow(dsAbn, dsAbn.tAbn_Files);
                if (idFolder < 0)
                        isOk = false;
                    else
                        isOk = true;

            }
            else
            {
                dsAbn.tAbn_Files.Rows[0].EndEdit();
                isOk = this.UpdateSqlData(dsAbn, dsAbn.tAbn_Files);
            }
            if (isOk) this.DialogResult = DialogResult.OK;
        }
    }
}
