using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Documents.Forms.JournalRequest
{
    public partial class FormAddEditRequest : FormLbr.FormBase
    {
        #region Members
        public enum eActionRequest
        {
            Add, Edit, Read
        }

        eActionRequest actionRequest = eActionRequest.Add;
        int idRequest = -1;
        #endregion

        #region Constructors
        public FormAddEditRequest()
        {
            InitializeComponent();
            

        }
        public FormAddEditRequest(int id, eActionRequest actRequest)
        {
            InitializeComponent();
            this.actionRequest = actRequest;
            this.idRequest = id;

            switch (actionRequest)
            {
                case eActionRequest.Add:
                    this.Text = "Новая задача";
                    break;
                case eActionRequest.Edit:
                    this.Text = "Редактировать задачу";
                    break;
                case eActionRequest.Read:
                    this.Text = "Просмотр задачи";
                    break;
            }
        }
        #endregion

        #region Form Events
        // Загрузка формы
        private void FormAddEditRequest_Load(object sender, EventArgs e)
        {

            // грузим справочники
            this.SelectSqlData(dsRef, dsRef.Tables["tUser"], true, " where deleted = 0 order by [name]");
            this.SelectSqlData(dsRef, dsRef.Tables["tR_Classifier"], true,
                " where ParentKey = ';Other;ModulPC;' and isGroup = 0 and deleted = 0 order by [name]");

            // надо пользователя узнать
            this.SelectSqlData(dsGES, dsGES.tUser, true, " where [Login] = SYSTEM_USER ", 1);
            int idUser = -1;
            if (dsGES.tUser.Rows.Count > 0) idUser = Convert.ToInt32(dsGES.tUser.Rows[0]["idUser"]);

            switch (actionRequest)
            {
                case eActionRequest.Add:
                    DataRow dr = dsGES.tJ_Request.NewRow();
                    dr["idUserTask"] = idUser;
                    dr["DateTask"] = System.DateTime.Now;
                    dsGES.tJ_Request.Rows.Add(dr);
                    break;
                case eActionRequest.Edit:
                    this.SelectSqlData(dsGES, dsGES.tJ_Request, true, " where id = " + idRequest.ToString());
                    this.SelectSqlData(dsGES, dsGES.tJ_RequestDoc, true, " where idRequest = " + idRequest.ToString());
                    if (dsGES.tJ_Request.Rows.Count == 0)
                    {
                        MessageBox.Show("Не удалось открыть документ для редактирования");
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.Close();
                    }
                    else
                    {
                        richTextBoxTextTask.Rtf = Convert.ToString(dsGES.tJ_Request.Rows[0]["TextTask"]);
                        if (idUser == -1 || idUser != Convert.ToInt32(dsGES.tJ_Request.Rows[0]["idUserTask"]))
                        { // пользователи не совпадают
                            comboBoxModul.Enabled = false;
                            richTextBoxTextTask.ReadOnly = true;
                            toolStrip.Enabled = false;
                            toolMenuDel.Visible = false;
                            comboBoxWhom.Enabled = false;
                        }

                        if (dsGES.tJ_Request.Rows[0]["idUserWhom"] != DBNull.Value)
                        {
                            if (idUser == Convert.ToInt32(dsGES.tJ_Request.Rows[0]["idUserWhom"]))
                            {
                                comboBoxWhom.Enabled = true;
                                toolStrip.Enabled = true;
                            }
                        }
                    }
                    break;
            }
        }
        // Закрытие формы
        private void FormAddEditRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (comboBoxModul.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбран модуль");
                    e.Cancel = true;
                    return;
                }
                if (String.IsNullOrEmpty(richTextBoxTextTask.Text))
                {
                    MessageBox.Show("Не заполнено поле текста задачи");
                    e.Cancel = true;
                    return;
                }
                // здеся пытаемся сохранить ртф формат
                // при сохранении видно структуру ртф
                if (String.IsNullOrEmpty(richTextBoxTextTask.Text))
                    dsGES.tJ_Request.Rows[0]["TextTask"] = "";
                else
                    dsGES.tJ_Request.Rows[0]["TextTask"] = richTextBoxTextTask.Rtf;
                
                switch (actionRequest)
                {
                    
                    case eActionRequest.Add:
                        dsGES.tJ_Request.Rows[0].EndEdit();
                        idRequest = this.InsertSqlDataOneRow(dsGES, dsGES.tJ_Request);
                        if (idRequest > 0)
                        {
                            foreach (DataRow dr in dsGES.tJ_RequestDoc.Rows)
                            {
                                dr["idRequest"] = idRequest;
                                dr.EndEdit();
                            }
                            this.InsertSqlData(dsGES, dsGES.tJ_RequestDoc);
                        }
                        break;
                    case eActionRequest.Edit:
                        dsGES.tJ_Request.Rows[0].EndEdit();
                        this.UpdateSqlData(dsGES, dsGES.tJ_Request);
                        if (idRequest > 0)
                        {
                            foreach (DataRow dr in dsGES.tJ_RequestDoc.Rows)
                            {
                                if (dr.RowState != DataRowState.Deleted)
                                    dr["idRequest"] = idRequest;
                                dr.EndEdit();
                            }
                            this.InsertSqlData(dsGES, dsGES.tJ_RequestDoc);
                            this.DeleteSqlData(dsGES, dsGES.tJ_RequestDoc);
                        }
                        break;
                }
            }
        }
        #endregion

        #region toolStrip Events
        // добавить файл
        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        DataRow dr = dsGES.tJ_RequestDoc.NewRow();
                        dr["idRequest"] = -1;
                        dr["Document"] = File.ReadAllBytes(dialog.FileNames[i]);
                        dr["FileName"] = dialog.FileNames[i];
                        dsGES.tJ_RequestDoc.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        // удалить файл
        private void toolBtnDel_Click(object sender, EventArgs e)
        {
            if (dgvDocs.CurrentRow != null)
            {
                int idDoc = Convert.ToInt32(dgvDocs.CurrentRow.Cells["idDgvTxtColumn"].Value);
                dgvDocs.Rows.Remove(dgvDocs.CurrentRow);
                /*if (idDoc > 0)  // есть в базе
                {
                    this.DeleteSqlDataById(dsGES.tJ_RequestDoc, idDoc);
                }*/
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного файла");
            }
        }
        #endregion

        #region DgvDocs Events
        // Происходит, когда свойство VirtualMode элемента управления DataGridView имеет значение 
        // true и объекту DataGridView требуется значение для ячейки, необходимое для форматирования 
        // и отображения этой ячейки. (MSDN) :)
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
                        e.Value = ico.ToBitmap();
                    }
                }
            }
        }

        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocs.CurrentRow == null) return;
            int idDoc = Convert.ToInt32(dgvDocs.CurrentRow.Cells["idDgvTxtColumn"].Value);

            if (e.ColumnIndex == dgvDocs.Columns["shortFileNameDgvTxtColumn"].Index)
            {
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

        #region ContextMenu Events
        // открыть файл
        private void toolMenuOpen_Click(object sender, EventArgs e)
        {
            if (dgvDocs.CurrentRow == null) return;
            int idDoc = Convert.ToInt32(dgvDocs.CurrentRow.Cells["idDgvTxtColumn"].Value);

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
        // сохранить файл
        private void toolMenuSave_Click(object sender, EventArgs e)
        {
            try
            {
                int idDoc = Convert.ToInt32(dgvDocs.CurrentRow.Cells["idDgvTxtColumn"].Value);
                string fileName = dgvDocs.CurrentRow.Cells["shortFileNameDgvTxtColumn"].Value.ToString();
                string ext = System.IO.Path.GetExtension(fileName);

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "(*" + ext + ")|*" + ext;
                dialog.FileName = fileName;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
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
        // удалить файл
        private void toolMenuDel_Click(object sender, EventArgs e)
        {
            toolBtnDel_Click(sender, e);
        }
        #endregion

  

        private void dgvDocs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move; // | DragDropEffects.Copy | DragDropEffects.Scroll;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvDocs_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                // В objects хранятся пути к папкам и файлам
                for (int i = 0; i < objects.Length; i++)
                {
                    if (File.GetAttributes(objects[i]) != FileAttributes.Directory)
                    {
                        DataRow dr = dsGES.tJ_RequestDoc.NewRow();
                        dr["idRequest"] = -1;
                        dr["Document"] = File.ReadAllBytes(objects[i]);
                        dr["FileName"] = objects[i];
                        dsGES.tJ_RequestDoc.Rows.Add(dr);
                    }
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

    
    }
}
