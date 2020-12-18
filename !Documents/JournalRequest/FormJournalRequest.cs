using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
// using JournalRequest;

namespace Documents.Forms.JournalRequest
{
    public partial class FormJournalRequest : FormLbr.FormBase
    {
        public FormJournalRequest()
        {
            InitializeComponent();
        }

        private void FormJournalRequest_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsGES, dsGES.vJ_Request, true);
        }

        #region toolBar
        // добавить задачу
        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditRequest f = new FormAddEditRequest(-1, FormAddEditRequest.eActionRequest.Add);
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectSqlData(dsGES, dsGES.vJ_Request, true);
            }
        }
        // изменить задачу
        private void toolBtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRequest.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для редактирования");
            }
            else
            {
                int idTask = Convert.ToInt32(dgvRequest.CurrentRow.Cells["idDgvTxtColumn"].Value);
                FormAddEditRequest f = new FormAddEditRequest(idTask, FormAddEditRequest.eActionRequest.Edit);
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.SelectSqlData(dsGES, dsGES.vJ_Request, true);
                    dgvRequest.SearchGrid("idDgvtxtColumn", idTask.ToString()); // позиционирование в гриде
                }
            }
        }
        // поменять статус
        private void toolBtnAccept_Click(object sender, EventArgs e)
        {
            if (dgvRequest.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для редактирования");
            }
            else
            {
                int idTask = Convert.ToInt32(dgvRequest.CurrentRow.Cells["idDgvTxtColumn"].Value);
                FormEditRequeststatus f = new FormEditRequeststatus(idTask);
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.SelectSqlData(dsGES, dsGES.vJ_Request, true);
                    dgvRequest.SearchGrid("idDgvtxtColumn", idTask.ToString()); // позиционирование в гриде
                }
            }
        }
        // удалить задачу
        private void toolBtnDel_Click(object sender, EventArgs e)
        {
            if (dgvRequest.CurrentRow == null)
            {
                MessageBox.Show("Не выбрана задача для удаления");
            }
            else
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущую задачу?", "Удаление",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idTask = Convert.ToInt32(dgvRequest.CurrentRow.Cells["idDgvTxtColumn"].Value);
                    dgvRequest.Rows.Remove(dgvRequest.CurrentRow);
                    this.DeleteSqlDataById(dsGES.tJ_Request, idTask);
                }

            }
        }

        private void toolBtnPrint_Click(object sender, EventArgs e)
        {
            if (dgvRequest.CurrentRow == null)
            {
                MessageBox.Show("Не выбрана задача для удаления");
            }
            else
            {
                int idTask = Convert.ToInt32(dgvRequest.CurrentRow.Cells["idDgvTxtColumn"].Value);
                FormReportRequest f = new FormReportRequest(idTask);
                f.SqlSettings = this.SqlSettings;
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
        // обновить
        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            this.SelectSqlData(dsGES, dsGES.vJ_Request, true);
        }
        //отправить почту
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        #region dgvRequest Event
        private void dgvRequest_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idREquest = Convert.ToInt32(dgvRequest["idDgvTxtColumn", e.RowIndex].Value);
                //this.SelectSqlData(dsGES, dsGES.tJ_RequestDoc, true, " where idRequest = " + idREquest.ToString() +
                //    " order by filename");
                this.SelectSqlData(dsRequestDoc, dsRequestDoc.Tables["tJ_Requestdoc"], true, " where idRequest = " + idREquest.ToString() +
                    " order by filename");

                DataRow[] foundRows = dsGES.vJ_Request.Select(" id = " + idREquest.ToString());
                
                RichTextBox richTextBox1 = new RichTextBox();

                try
                {
                    richTextBox.Rtf = (string)(foundRows[0]["TextTask"]);
                }
                catch
                {
                    richTextBox.Text = (string)(foundRows[0]["TextTask"]); ;
                };
            }
        }
       

  
        #endregion

        #region dgvDocs
        // таблица прикрепленных файлов
        private void dgvDocs_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (dgvDocs.RowCount > 0) // есть строки
            {
                if (dgvDocs["filenameDgvTxtColumn", e.RowIndex].Value != null)
                {
                    if (e.ColumnIndex == dgvDocs.Columns["shortFileNameDgvTxtColumn"].Index) // столбец картинки
                    {
                        e.Value = System.IO.Path.GetFileName(dgvDocs["filenameDgvTxtColumn", e.RowIndex].Value.ToString());
                    }
                    if (e.ColumnIndex == dgvDocs.Columns["ColumnImage"].Index) // столбец картинки
                    {
                        Icon ico = Classes.FileInfo.IconOfFile(dgvDocs["filenameDgvTxtColumn", e.RowIndex].Value.ToString());
                        if (ico != null)
                            e.Value = ico.ToBitmap();
                    }
                }
            }
        }
        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocs.CurrentRow == null) return;
            int idDoc = Convert.ToInt32(dgvDocs.CurrentRow.Cells["idDocDgvTxtColumn"].Value);

            if (e.ColumnIndex == dgvDocs.Columns["shortFileNameDgvTxtColumn"].Index)
            {
                this.SelectSqlData(dsGES, dsGES.tJ_RequestDoc, true, "where id = " + idDoc.ToString());
                byte[] byts = (byte[])dsGES.tJ_RequestDoc.FindByid(idDoc)["Document"];
                string tmpname = System.IO.Path.GetTempFileName();
                tmpname = System.IO.Path.ChangeExtension(tmpname, System.IO.Path.GetExtension(dsGES.tJ_RequestDoc.FindByid(idDoc)["FileName"].ToString()));

                FileStream fs = File.Create(tmpname);
                fs.Write(byts, 0, byts.Length);
                fs.Close();

                try
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = tmpname;
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }
        private void dgvDocs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                this.dgvDocs.Rows[e.RowIndex].Selected = true;
                this.dgvDocs.CurrentCell = dgvDocs["columnimage", e.RowIndex];
                ///-----------
                this.contextMenuDgvDoc.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        #endregion

        #region ContextMenu Event
        private void toolMenuOpen_Click(object sender, EventArgs e)
        {
            if (dgvDocs.CurrentRow == null) return;
            int idDoc = Convert.ToInt32(dgvDocs.CurrentRow.Cells["idDocDgvTxtColumn"].Value);

            this.SelectSqlData(dsGES, dsGES.tJ_RequestDoc, true, "where id = " + idDoc.ToString());
            byte[] byts = (byte[])dsGES.tJ_RequestDoc.FindByid(idDoc)["Document"];
            string tmpname = System.IO.Path.GetTempFileName();
            tmpname = System.IO.Path.ChangeExtension(tmpname, System.IO.Path.GetExtension(dsGES.tJ_RequestDoc.FindByid(idDoc)["FileName"].ToString()));

            FileStream fs = File.Create(tmpname);
            fs.Write(byts, 0, byts.Length);
            fs.Close();

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = tmpname;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void toolMenuSave_Click(object sender, EventArgs e)
        {
            try
            {
                int idDoc = Convert.ToInt32(dgvDocs.CurrentRow.Cells["idDocDgvTxtColumn"].Value);
                string fileName = dgvDocs.CurrentRow.Cells["shortFileNameDgvTxtColumn"].Value.ToString();
                string ext = System.IO.Path.GetExtension(fileName);

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "(*" + ext + ")|*" + ext;
                dialog.FileName = fileName;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.SelectSqlData(dsGES, dsGES.tJ_RequestDoc, true, "where id = " + idDoc.ToString());
                    byte[] byts = (byte[])dsGES.tJ_RequestDoc.FindByid(idDoc)["Document"];
                    FileStream fs = File.Create(dialog.FileName);
                    fs.Write(byts, 0, byts.Length);
                    fs.Close();
                    MessageBox.Show("Файл успешно сохранен", "Сохранение");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        #endregion

        private void dgvRequest_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
//Зеленый - выполнено
//Красный - открыто
//Серый - обычный
//Желтый - архивный
                if (dgvRequest["nameStatusTaskDgvTxtColumn", e.RowIndex].Value.ToString() == "Выполненная")
                    e.CellStyle.ForeColor = Color.Green;
                if (dgvRequest["nameStatusTaskDgvTxtColumn", e.RowIndex].Value.ToString() == "Открытая")
                    e.CellStyle.ForeColor = Color.Red;
                if (dgvRequest["nameStatusTaskDgvTxtColumn", e.RowIndex].Value.ToString() == "Архивная")
                    e.CellStyle.ForeColor = Color.Yellow;
                /*if ((int)dgvDocAct["idDocTypeDgvTxtColumn", e.RowIndex].Value == (int)FormLbr.Classes.DocType.ActKO)
                    e.CellStyle.BackColor = Color.WhiteSmoke;
                if (((int)dgvDocAct["idDocTypeDgvTxtColumn", e.RowIndex].Value == (int)FormLbr.Classes.DocType.ActUst) ||
                    ((int)dgvDocAct["idDocTypeDgvTxtColumn", e.RowIndex].Value == (int)FormLbr.Classes.DocType.ActDem))
                    e.CellStyle.ForeColor = Color.Blue;
                if ((int)dgvDocAct["idDocTypeDgvTxtColumn", e.RowIndex].Value == (int)FormLbr.Classes.DocType.ActPerehod)
                    e.CellStyle.ForeColor = Color.Green; ;*/
            }
        }

        private void dgvRequest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idTask = Convert.ToInt32(dgvRequest.CurrentRow.Cells["idDgvTxtColumn"].Value);
                FormAddEditRequest f = new FormAddEditRequest(idTask, FormAddEditRequest.eActionRequest.Edit);
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.SelectSqlData(dsGES, dsGES.vJ_Request, true);
                    dgvRequest.SearchGrid("idDgvtxtColumn", idTask.ToString()); // позиционирование в гриде
                }
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //Form f1 = new Form2();
            //f1.Show();
        }

        private void toolBtnTelefon_Click(object sender, EventArgs e)
        {
            //Form f1 = new Form2();
            //f1.Show();
        }

        



   
 
    }
}
