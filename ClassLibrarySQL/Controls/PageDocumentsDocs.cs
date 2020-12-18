using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using LibraryTSQL;
using FormLbr;
using DataSql;

namespace Library
{
    public partial class PageReestrDocs : UserControl
    {
        [Browsable(false)]
        public DataSql.SQLSettings SqlSettings { get; set; }
        [Browsable(false)]
        public string TableDocumentDoc { get; set; } = "tJ_DamageDoc";
        [Browsable(false)]
        [Description("Идентификатор документа")]
        public int IdDocument { get; set; } = 0;
        [Browsable(false)]
        [Description("Тип документа")]
        public int TypeDocument { get; set; } = 0;

        public void ComponentInit()
        {
            // "{ ulges - sql2, GES, WINDOWS,, }"
            DataSql.SQLSettings setSql = new SQLSettings();
            setSql.DBName = "GES";
            setSql.ServerDB = "ulges-sql2";
            setSql.Autentification = "WINDOWS";

            if (SqlSettings is null) { SqlSettings = setSql; }
        }
        public PageReestrDocs()
        {
            ComponentInit();
            InitializeComponent();
        }
        public PageReestrDocs(IContainer container)
        {
            ComponentInit();
            container.Add(this);
            InitializeComponent();
        }

        private void toolBtnAddDoc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    {
                        DataRow dataRow = this.dataSetDoc.Tables[TableDocumentDoc].NewRow();
                        dataRow["idDamage"] = this.IdDocument;
                        dataRow["Document"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
                        dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
                        this.dataSetDoc.Tables[TableDocumentDoc].Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void toolBtnDelDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
                this.dgvDocs.Rows.Remove(this.dgvDocs.CurrentRow);
                return;
            }
            MessageBox.Show("Не выбрано ни одного файла");
        }

        private void toolBtnViewDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow == null)
            {
                return;
            }
            int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
            byte[] array = (byte[])this.dataSetDoc.Tables[TableDocumentDoc].Rows.Find(new object[] { num })["Document"];
            string text = Path.GetTempFileName();
            text = Path.ChangeExtension(text, Path.GetExtension(this.dataSetDoc.Tables[TableDocumentDoc].Rows.Find(new object[] { num })["FileName"].ToString()));
            FileStream fileStream = File.Create(text);
            fileStream.Write(array, 0, array.Length);
            fileStream.Close();
            new Process
            {
                StartInfo =
                {
                    FileName = text,
                    UseShellExecute = true
                }
            }.Start();
        }

        private void toolBtnSaveDoc_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
                string text = this.dgvDocs.CurrentRow.Cells[this.fileNameDataGridViewTextBoxColumn.Name].Value.ToString();
                string extension = Path.GetExtension(text);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
                saveFileDialog.FileName = text;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] array = (byte[])this.dataSetDoc.Tables[TableDocumentDoc].Rows.Find(new object[] { num })["Document"];
                    FileStream fileStream = File.Create(saveFileDialog.FileName);
                    fileStream.Write(array, 0, array.Length);
                    fileStream.Close();
                    MessageBox.Show("Файл успешно сохранен", "Сохранение");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvDocs_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (this.dgvDocs.RowCount > 0 && this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value != null && e.ColumnIndex == this.dgvDocs.Columns[this.ColumnImage.Name].Index)
            {
                Icon icon = FileInfo.IconOfFile(this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value.ToString());
                e.Value = icon.ToBitmap();
            }
        }

        private void dgvDocs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
        /// <summary>
        /// сохранение прикрепленных файлов
        /// </summary>
        private void UpdateReestrDocs()
        {
            foreach (DataRow dataRow in this.dataSetDoc.Tables[TableDocumentDoc].AsEnumerable())
            {
                if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
                {
                    dataRow["idDamage"] = this.IdDocument;
                    dataRow.EndEdit();
                }
            }

            LibraryTSQL.SqlDataCommand cc = new LibraryTSQL.SqlDataCommand(SqlSettings);
            cc.InsertSqlData(this.dataSetDoc, this.dataSetDoc.Tables[TableDocumentDoc]);
            cc.UpdateSqlData(this.dataSetDoc, this.dataSetDoc.Tables[TableDocumentDoc]);
            cc.DeleteSqlData(this.dataSetDoc, this.dataSetDoc.Tables[TableDocumentDoc]);
            this.dataSetDoc.Tables[TableDocumentDoc].AcceptChanges();
        }

        private void PageReestrDocs_Load(object sender, EventArgs e)
        {
            //    //LibraryTSQL.SqlDataCommand cc = new LibraryTSQL.SqlDataCommand(SqlSettings);
            //    //cc.SelectSqlData(this.dataSetDoc, this.dataSetDoc.Tables[TableDocumentDoc], false, string.Format(" where idDamage = {0} and typedoc = {1}",  IdDocument, TypeDocument ));
            ComponentInit();
            LibraryTSQL.SqlDataCommand cc = new LibraryTSQL.SqlDataCommand();
            cc.SqlSettings = SqlSettings;
            cc.SelectSqlData(this.dataSetDoc, this.dataSetDoc.Tables[TableDocumentDoc], true, string.Format(" where idDamage = {0} and TypeDoc = {1}", IdDocument, TypeDocument));
        }
    }
}
