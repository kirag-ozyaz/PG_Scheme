using DataSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace UpLoadContractTC
{
    public partial class FormUpload : FormLbr.FormBase
    {
        public FormUpload()
        {
            InitializeComponent();
        }
        //--Журнал договоров
        private void btnUploadContraktTC_Click(object sender, EventArgs e)
        {
            btnUploadAktTC.Enabled = false;
            btnUploadContraktTC.Enabled = false;
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    System.Data.DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData("select  * from vTC_Contract [Contract] left join tTC_DocFile DocFile on DocFile.idDoc = [Contract].id where DocFile.[File] is not null and Year([Contract].dateDoc) = "+cmbUplosdYear.SelectedText+" order by[Contract].id desc");
                    if (dataTable.Rows.Count <= 0)
                    {
                        return;
                    }
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string NameContrakt = row["numDoc"].ToString().Replace("/", "_") + " от " + Convert.ToDateTime(row["DateDoc"]).ToShortDateString();
                        //byte[] array = (byte[])dataTable.Rows[0]["File"];
                        byte[] array = (byte[])row["File"];
                        //string text = Path.GetTempFileName();
                        string text = Path.GetFileName(NameContrakt);
                        //text = Path.ChangeExtension(text, Path.GetExtension(row["FileName"].ToString()));
                        text = text  + Path.GetExtension(row["FileName"].ToString());
                        FileStream fileStream = File.Create(text);
                        fileStream.Write(array, 0, array.Length);
                        fileStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
            btnUploadContraktTC.Enabled = true;
            btnUploadAktTC.Enabled = true;
        }
        //            --Журнал актов технологических присоединений
        private void btnUploadAktTC_Click(object sender, EventArgs e)
        {
            
            btnUploadAktTC.Enabled = false;
            btnUploadContraktTC.Enabled = false;
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    System.Data.DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData("select  * from vTC_Act Act left join tTC_DocFile DocFile on DocFile.idDoc = Act.id where DocFile.[File] is not null and Year([Act].dateDoc) = " + cmbUplosdYear.SelectedText + " order by Act.id desc");
                    if (dataTable.Rows.Count <= 0)
                    {
                        return;
                    }
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string NameContrakt = row["numDoc"].ToString().Replace("/", "_") + " от " + Convert.ToDateTime(row["DateDoc"]).ToShortDateString();
                        //byte[] array = (byte[])dataTable.Rows[0]["File"];
                        byte[] array = (byte[])row["File"];
                        //string text = Path.GetTempFileName();
                        string text = Path.GetFileName(NameContrakt);
                        //text = Path.ChangeExtension(text, Path.GetExtension(row["FileName"].ToString()));
                        text = "Акт ТП №" + text + " ("+Path.GetFileNameWithoutExtension(row["FileName"].ToString())+") " + Path.GetExtension(row["FileName"].ToString());
                        FileStream fileStream = File.Create(text);
                        fileStream.Write(array, 0, array.Length);
                        fileStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
            btnUploadContraktTC.Enabled = true;
            btnUploadAktTC.Enabled = true;
        }

        private void FormUpload_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    System.Data.DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData("select DISTINCT YEAr(DateDoc) year from vTC_Contract [Contract] order by YEAr(DateDoc)");


                    this.cmbUplosdYear.DisplayMember = "year";
                    this.cmbUplosdYear.ValueMember = "year";
                    this.cmbUplosdYear.DataSource = dataTable;
                    this.cmbUplosdYear.SelectedIndex = cmbUplosdYear.FindString(DateTime.Now.Year.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }


                //    System.Data.DataTable dataT

            }
        }
    }
}
