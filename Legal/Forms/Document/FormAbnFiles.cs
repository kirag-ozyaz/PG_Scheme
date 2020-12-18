using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FormLbr.Classes;
using Legal.DataSet;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Legal.Forms.Document
{
    public partial class FormAbnFiles : FormLbr.FormBase
    {
        private int idAbn;
        private int inFolder = 0;
        private int parID;

        Dictionary<string, FileWatcherArgsAddl> files = new Dictionary<string, FileWatcherArgsAddl>();

        public FormAbnFiles()
        {
            InitializeComponent();
        }

        public FormAbnFiles(int idAbn)
        {
            InitializeComponent();
            this.idAbn = idAbn;
        }

        private void FormAbnFiles_Load(object sender, EventArgs e)
        {
            RefreshFolder();//SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and (isGroup = 1 or ParentID = 0) and idAbn = " + idAbn.ToString() + " order by IsGroup desc,ParentId asc ");
        }

        private void tsbAddFile_Click(object sender, EventArgs e)
        {
            AddFileDialog();
        }

        private void AddFileDialog()
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Multiselect = true;
            if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in dlgOpen.FileNames)
                {
                    string filename = AddFile(fileName, null, null, true);
                }
            }
        }
        private string AddFile(string fileName, int? idTemplate = null, byte[] fileData = null, bool saveAndListen = false)
        {
            string shortFileName = System.IO.Path.GetFileName(fileName);
            bool isAdd = true;
            while ((SelectSqlData("tAbn_Files", true, String.Format("where idAbn = {0} AND FileName = '{1}'", idAbn, shortFileName)).Rows.Count > 0
                || files.ContainsKey(shortFileName)) && saveAndListen)  // если есть такой файл....
            {
                if (MessageBox.Show("Файл с именем " + shortFileName + " уже существует. Изменить имя файла на другое?", "Внимание.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    FormNewFileName frmNewFileName = new FormNewFileName(shortFileName);
                    if (frmNewFileName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        shortFileName = frmNewFileName.FileName;
                }
                else
                {
                    isAdd = false;
                    break;
                }
            }
            if (!isAdd) return null;

            if (saveAndListen)
            {
                FileWatcherArgsAddl f = new FileWatcherArgsAddl(idTemplate, shortFileName, null, FileOpenState.None);
                files.Add(shortFileName, f);

                var row = dsAbn.tAbn_Files.NewtAbn_FilesRow();
                row.idAbn = idAbn;
                row.FileName = shortFileName;
                row.Deleted = 0;
                row.IsGroup = 0;
                if (inFolder == 0) row.ParentID = 0;  else row.ParentID = parID;

                if (fileData == null)
                {
                    FileBinary file = new FileBinary(fileName);
                    row.File = file.ByteArray;
                    row.Date = file.LastChanged;
                }
                else
                {
                    row.File = fileData;
                    row.Date = DateTime.Now;
                }

                dsAbn.tAbn_Files.AddtAbn_FilesRow(row);
                foreach (var item in dsAbn.tAbn_Files)
                {
                    item.EndEdit();
                }
                int idFile = InsertSqlDataOneRow(dsAbn, dsAbn.tAbn_Files);
                RefreshFolder();//SelectSqlData(dsAbn.tAbn_Files, true, "where idAbn = " + idAbn);
                bsAbn_Files.Position = bsAbn_Files.Find("id", idFile);
                dsAbn.tAbn_Files.Where(r => r.id == idFile).ToList().ForEach(r => { r.AcceptChanges(); r.SetModified(); });
            }
            return shortFileName;
        }


        private void OpenFile(bool isEdit = false)
        {
            if (bsAbn_Files.Current != null)
            {

                DataSetAbn.tAbn_FilesRow r = (DataSetAbn.tAbn_FilesRow)((DataRowView)bsAbn_Files.Current).Row;

                string fileName = r.FileName;
                string folderName = GetDirectoryPath();
                string tmpfileName = FileBinary.GetNewFileNameIsExists(folderName, fileName);

               DateTime dateChange = r.Date;

                byte[] fileData;
                try
                {
                    fileData = r.File;
                }
                catch
                {
                    MessageBox.Show("Нет содержимого файла");
                    return;
                }

                FileBinary file = new FileBinary(fileData, tmpfileName, DateTime.Now);
                // Записали файл во временную папку
                file.SaveToDisk(folderName);
                // Запустили файл
                Process.Start(folderName + "\\" + file.Name);

            }
        }

        private string GetDirectoryPath()
        {
            string dir = ((DataRowView)bsAbn_Files.Current)["idAbn"] is string &&
                string.IsNullOrEmpty(((DataRowView)bsAbn_Files.Current)["idAbn"].ToString()) ?
                ((DataRowView)bsAbn_Files.Current)["idAbn"].ToString() : "tmp";
            var path = System.IO.Path.GetTempPath() + "\\" + dir + "\\";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            return path;
        }

        private void dgvAbnFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int isG = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["isGroup"].Value);
            parID = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["id"].Value);

            if (isG == 0)
            {
                OpenFile();
                return;
            }

            if (isG == 1)
            {
                if ((int)dgvAbnFiles.CurrentCell.RowIndex == 0 && inFolder != 0)
                {
                    parID = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["ParentId"].Value);
                    inFolder--;
                }
                else inFolder++; ;
                if (inFolder == 0)
                {
                    SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and ParentID = 0 and idAbn = " + idAbn.ToString() + " order by IsGroup desc,ParentId asc ");
                    return;
                }
               
                SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and (id = " + parID.ToString() + "  or  ParentID = " + parID.ToString() + " ) order by IsGroup desc,ParentId asc ");
            }


        }

        private void RefreshFolder()
        {
            if (inFolder == 0)
            {
                SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and ParentID = 0 and idAbn = " + idAbn.ToString() + " order by IsGroup desc,ParentId asc ");
                return;
            }

            SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and (id = " + parID.ToString() + "  or  ParentID = " + parID.ToString() + " ) order by IsGroup desc,ParentId asc ");
        }

        private void dgvAbnFiles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (((DataGridView)sender).RowCount > 0) // есть строки
            {
                if (dgvAbnFiles[fileName.Name, e.RowIndex].Value != null)
                {
                    if (e.ColumnIndex == dgvAbnFiles.Columns[imageFile.Name].Index) // столбец картинки
                    {
                        if (!string.IsNullOrEmpty(System.IO.Path.GetFileName(dgvAbnFiles[fileName.Name, e.RowIndex].Value.ToString())))
                            e.Value = System.IO.Path.GetFileName(dgvAbnFiles[fileName.Name, e.RowIndex].Value.ToString());
                        else
                            e.Value = dgvAbnFiles[fileName.Name, e.RowIndex].Value.ToString();
                    }
                    if (e.ColumnIndex == dgvAbnFiles.Columns[imageFile.Name].Index) // столбец картинки
                    {
                        Icon ico = FormLbr.Classes.FileInfo.IconOfFile(dgvAbnFiles[fileName.Name, e.RowIndex].Value.ToString());
                        if (ico != null) e.Value = ico.ToBitmap();
                    }
                }

                if (Convert.ToInt32(dgvAbnFiles.Rows[e.RowIndex].Cells["isGroup"].Value) == 1)
                {
                    e.CellStyle.ForeColor = Color.Blue;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }
            }
        }

        private void tsbOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsbDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void DeleteFile()
        {
            if (dgvAbnFiles.SelectedRows != null && dgvAbnFiles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные файлы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    //foreach (DataGridViewRow dgvRow in dgvAbnFiles.SelectedRows)
                    //{
                    //    var rows = dsAbn.tAbn_Files.Where<DataSetAbn.tAbn_FilesRow>(r => r.RowState != DataRowState.Deleted && r.id == (int)dgvRow.Cells["id"].Value);

                    //    if (rows.Count() > 0)
                    //    {
                    //        DataSetAbn.tAbn_FilesRow r = rows.First();
                    //        string fileName = r.FileName;
                    //        if (files.ContainsKey(fileName))
                    //        {
                    //            if (files[fileName].Watcher != null)
                    //            {
                    //                files[fileName].Watcher.Stop();
                    //            }
                    //            files.Remove(fileName);
                    //        }
                    //        r.Delete();
                    //        r.EndEdit();
                    //    }
                    //}
                    //DeleteSqlData(dsAbn, dsAbn.tAbn_Files);

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tAbn_Files, true, "where id = " + dgvAbnFiles.CurrentRow.Cells["id"].Value.ToString());
                    ds.tAbn_Files.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tAbn_Files.Rows[0]["Deleted"]);
                    ds.tAbn_Files.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tAbn_Files))
                    {
                        if (Convert.ToBoolean(ds.tAbn_Files.Rows[0]["Deleted"])) MessageBox.Show("Файл успешно удален");

                    }

                    RefreshFolder();// SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and idAbn = " + idAbn.ToString());
                }
            }
        }

        string oldFileName = "";
        private void tsbRenameFile_Click(object sender, EventArgs e)
        {
            RenameFile();
        }
        private void RenameFile()
        {
            if (dgvAbnFiles.CurrentRow != null)
            {
                oldFileName = dgvAbnFiles.CurrentRow.Cells[fileName.Name].Value.ToString();
                dgvAbnFiles.CurrentCell = dgvAbnFiles.CurrentRow.Cells[fileName.Name];
                dgvAbnFiles.CurrentCell.Value = System.IO.Path.GetFileNameWithoutExtension(oldFileName);
                dgvAbnFiles.ReadOnly = false;
                dgvAbnFiles.ReadOnly = false;
                dgvAbnFiles.BeginEdit(true);
            }
        }

        private void tsbSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            if (bsAbn_Files.Current != null)
            {

                DataSetAbn.tAbn_FilesRow r = (DataSetAbn.tAbn_FilesRow)((DataRowView)bsAbn_Files.Current).Row;
                if (r["File"] == DBNull.Value)
                {
                    MessageBox.Show("Нет содержимого файла");
                    return;
                }
                byte[] fileData = r.File;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = r.FileName;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    ByteArrayToFile(dialog.FileName, fileData);

            }
        }


        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                // Open file for reading
                System.IO.FileStream _FileStream =
                   new System.IO.FileStream(fileName, System.IO.FileMode.Create,
                                            System.IO.FileAccess.Write);
                // Writes a block of bytes to this stream using data from
                // a byte array.
                _FileStream.Write(byteArray, 0, byteArray.Length);

                // close file stream
                _FileStream.Close();

                return true;
            }
            catch (Exception _Exception)
            {
                MessageBox.Show(_Exception.Message, _Exception.Source);
                _Exception.ToString();
            }

            // error occured, return false
            return false;
        }

        private void AddFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFileDialog();
        }

        private void EditNAmeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameFile();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void DeleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void dgvAbnFiles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                dgvAbnFiles.ClearSelection();
                dgvAbnFiles.Rows[e.RowIndex].Selected = true;
                dgvAbnFiles.CurrentCell = dgvAbnFiles[e.ColumnIndex, e.RowIndex];
                Rectangle r = dgvAbnFiles.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                contextMenuStripAbnFiles.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            }
        }

        private void dgvAbnFiles_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(oldFileName))
                {
                    string newFileName = e.FormattedValue + System.IO.Path.GetExtension(oldFileName);
                    if (newFileName == oldFileName) return;

                    if (files.ContainsKey(newFileName))
                    {
                        MessageBox.Show("Файл с таким именем уже существует", "");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dgvAbnFiles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvAbnFiles.ReadOnly = true;
            fileName.ReadOnly = true;
            if (dgvAbnFiles[e.ColumnIndex, e.RowIndex].Value != null)
            {
                string newFileName = dgvAbnFiles[e.ColumnIndex, e.RowIndex].Value.ToString() + System.IO.Path.GetExtension(oldFileName);
                if (newFileName == oldFileName) return;

                if (files.ContainsKey(oldFileName))
                {
                    FileWatcherArgsAddl fw = files[oldFileName];
                    fw.OriginalName = newFileName;
                    files.Remove(oldFileName);
                    files.Add(newFileName, fw);
                }
                dgvAbnFiles[e.ColumnIndex, e.RowIndex].Value = newFileName;
                foreach (DataSetAbn.tAbn_FilesRow row in dsAbn.tAbn_Files)
                {
                    row.EndEdit();
                }
                UpdateSqlData(dsAbn, dsAbn.tAbn_Files);
                
            }
            oldFileName = null;
        }


        private void AddFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inFolder == 0)
            {
                Document.FormAbnFilesAddEditFolder fFolder = new Document.FormAbnFilesAddEditFolder(idAbn, 0, true);
                fFolder.SqlSettings = this.SqlSettings;
                if (fFolder.ShowDialog() == DialogResult.OK)
                {
                    RefreshFolder();// SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and idAbn = " + idAbn.ToString() + " order by IsGroup,ParentId ");
                }
            }
            else
            {
                Document.FormAbnFilesAddEditFolder fFolder = new Document.FormAbnFilesAddEditFolder(idAbn, parID, true);
                fFolder.SqlSettings = this.SqlSettings;
                if (fFolder.ShowDialog() == DialogResult.OK)
                {
                    RefreshFolder();// SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and idAbn = " + idAbn.ToString() + " order by IsGroup,ParentId ");
                }
            }
        }

        private void EditFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document.FormAbnFilesAddEditFolder fFolder = new Document.FormAbnFilesAddEditFolder(idAbn,(int)((DataRowView)bsAbn_Files.Current)["id"], false);
            fFolder.SqlSettings = this.SqlSettings;
            if (fFolder.ShowDialog() == DialogResult.OK)
            {
                RefreshFolder();//SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and idAbn = " + idAbn.ToString() + " order by IsGroup,ParentId ");
            }
        }

        //private void DelFolderToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void AddInFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idF = Convert.ToInt32(dgvAbnFiles.CurrentRow.Cells["id"].Value);
            Document.FormAbnFilesSelectFolder fFolder = new Document.FormAbnFilesSelectFolder(idAbn, parID);
            fFolder.SqlSettings = this.SqlSettings;
            if (fFolder.ShowDialog() == DialogResult.OK)
            {
               // MessageBox.Show(fFolder.SelectedFolder.ToString());
                if (dsAbn.tAbn_Files.Rows.Count > 0)
                {

                    DataSet.DataSetAbn ds = new Legal.DataSet.DataSetAbn();
                    this.SelectSqlData(ds, ds.tAbn_Files, true, "where id = " + idF);
                    ds.tAbn_Files.Rows[0]["ParentID"] = (int)fFolder.SelectedFolder;
                    ds.tAbn_Files.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tAbn_Files))
                    {

                        RefreshFolder();//  SelectSqlData(dsAbn, dsAbn.tAbn_Files, true, "where Deleted = 0 and idAbn = " + idAbn.ToString() + " order by IsGroup , ParentId ");

                    }
                }

            }


        }





    }
}
