using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.InteropServices;



using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using Constants;

namespace Prv.Forms.Exchange
{
    public partial class FormKOinUE : FormLbr.FormBase
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        private DateTime d_beg; //дата начала
        private DateTime d_end; //дата окончания
        private int typeDoc;
        private string strCmd;

        private class ItemChecked
        {

            public string Name { get; set; }
            public int Id { get; set; }

            public ItemChecked()
            {
            }

            public ItemChecked(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public override string ToString()
            {
                return Name;
            }
        }



        public FormKOinUE()
        {
            InitializeComponent();
        }
        private void FormKOinUE_Load(object sender, EventArgs e)
        {
            dTPBeg.Value = System.DateTime.Now.Date;
            dTPEnd.Value = System.DateTime.Now.Date;
            
         
            dsExch.TableKOinUE.Clear();

            groupBoxWait.Visible = false;
            checkBoxRaions.CheckState = CheckState.Checked;

            this.SelectSqlData(dsDocAct, dsDocAct.tR_Classifier, true, " where ParentKey in (';TypeDoc;tDocAct;') and isGroup = 0 and deleted = 0");
            cmbTypeDoc.SelectedValue = DocType.ActKO;

            LoadRaions();

        }

        private void LoadRaions()
        {
            this.SelectSqlData(dsDirectory, dsDirectory.tR_Classifier, true, " where IsGroup = 0 and deleted = 0 " +
                " and ParentKey = ';CityRaion;UlyanovskRaion;' order by name ");
            foreach (DataRow dr in dsDirectory.tR_Classifier.Rows)
            {
                ItemChecked item = new ItemChecked(dr["Name"].ToString(), Convert.ToInt32(dr["Id"]));
                checkedListBoxRaion.Items.Add(item, true);
            }
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            dsExch.TableKOinUE.Clear();
            d_beg = Convert.ToDateTime(dTPBeg.Value); //дата начала
            d_end = Convert.ToDateTime(dTPEnd.Value); //дата окончания
            typeDoc = Convert.ToInt32(cmbTypeDoc.SelectedValue);

            groupBoxWait.Visible = true;
            progressBarEndLess.AutoProgress = true;

            //textBoxFile.Text = "\\\\term-ulges-energo\\c$\\Для УЭ\\КО\\koforue_" +
            //                 d_beg.ToString("yyyyMMdd") + "_" + d_end.ToString("yyyyMMdd");

            textBoxFile.Text = "D:\\UG" + d_end.ToString("yyMMdd"); //textBoxFile.Text = "\\\\term-ulges-energo\\c$\\Для УЭ\\КО\\UG" + d_end.ToString("yyMMdd");

            //Добавление района закоментировано за ненадобностью согласно просьбе от УЭ о изменение формирования названия файла
           // 3. Изменить формат названия имени файла: Имя сформированного файла: 
           //RIYYMMDD.DBF, где:
           //RI – признак сетевой компании (UG — УльГЭС);
           //YY – порядковый номер года (09,….10) даты формирования файла,
           //ММ – порядковый номер месяца (1, …, 12) даты формирования файла;
           //DD – день месяца (01 … 31) даты формирования файла;
           //DBF – расширение файла. 

            //if (checkBoxRaions.Checked == true)
            //{
            //    if ((checkedListBoxRaion.CheckedItems.Count == checkedListBoxRaion.Items.Count) ||
            //         (checkedListBoxRaion.CheckedItems.Count > 0))
            //    {
            //        foreach (ItemChecked item in checkedListBoxRaion.CheckedItems)
            //        {
            //            if (item.Id == 197) { textBoxFile.Text += "_Gel"; }
            //            if (item.Id == 198) { textBoxFile.Text += "_Zas"; }
            //            if (item.Id == 199) { textBoxFile.Text += "_Zav"; }
            //            if (item.Id == 196) { textBoxFile.Text += "_Len"; }
            //            //textBoxFile.Text +=  "_" + item.Id ;
            //        }
            //    }
            //    else { textBoxFile.Text += "_All"; }
            //}
            //else { textBoxFile.Text += "_All"; }

            textBoxFile.Text += ".dbf";
            dataGridViewExcelFilterKOinUE.Enabled = false;
            CreateStrCmd();
            //MessageBox.Show("5");
            bwKOinUE.RunWorkerAsync();
        }

        private void CreateStrCmd()
        {
            strCmd = "select * from  fn_PrvExportDoc (@DateBeg,@DateEnd,@TypeDoc)";
            if (BuildWhereArea() != "") strCmd = strCmd + " where " + BuildWhereArea();


        }
        private string BuildWhereArea()
        {
            string whereArea = "";

            if (checkBoxRaions.Checked == true)
            {
                if ((checkedListBoxRaion.CheckedItems.Count == checkedListBoxRaion.Items.Count) ||
                    (checkedListBoxRaion.CheckedItems.Count <= 0))
                    return whereArea;
                else
                {
                    foreach (ItemChecked item in checkedListBoxRaion.CheckedItems)
                    {
                        whereArea += item.Id + ",";
                    }
                    whereArea = " (Raion in (" + whereArea.Remove(whereArea.Length - 1) + ")) ";
                    return whereArea;
                }
            }
            else
            { return whereArea;
            }
        }

        private void bwKOinUE_DoWork(object sender, DoWorkEventArgs e)
        {
            /*DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            con.OpenConnection(SqlSettings);
            
            SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

            cmd.Parameters.Add("@DateBeg", SqlDbType.SmallDateTime);
            cmd.Parameters["@DateBeg"].Value = d_beg;
            cmd.Parameters.Add("@DateEnd", SqlDbType.SmallDateTime);
            cmd.Parameters["@DateEnd"].Value = d_end;
            cmd.Parameters.Add("@TypeDoc", SqlDbType.SmallInt);
            cmd.Parameters["@TypeDoc"].Value = typeDoc;

            cmd.CommandTimeout = 600;

            SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);
            //MessageBox.Show("1");
            dAdapt.Fill(dsExch, "TableKOinUE");*/
            //MessageBox.Show("2");

        }

        private void bwKOinUE_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                con.OpenConnection(SqlSettings);

                SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

                cmd.Parameters.Add("@DateBeg", SqlDbType.SmallDateTime);
                cmd.Parameters["@DateBeg"].Value = d_beg;
                cmd.Parameters.Add("@DateEnd", SqlDbType.SmallDateTime);
                cmd.Parameters["@DateEnd"].Value = d_end;
                cmd.Parameters.Add("@TypeDoc", SqlDbType.SmallInt);
                cmd.Parameters["@TypeDoc"].Value = typeDoc;

                cmd.CommandTimeout = 600;

                SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                dAdapt.Fill(dsExch, "TableKOinUE");


                if ((e.Error == null) && (!e.Cancelled))
                {
                    dataGridViewExcelFilterKOinUE.DataSource = null;
                    dataGridViewExcelFilterKOinUE.DataSource = dsExch.Tables["TableKOinUE"];
                }
                groupBoxWait.Visible = false;
                progressBarEndLess.AutoProgress = false;
                dataGridViewExcelFilterKOinUE.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void checkBoxRaions_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxRaions.CheckState)
            {
                case CheckState.Checked:
                    groupBoxRaion.Visible = true;
                    break;
                default:
                    groupBoxRaion.Visible = false;
                    break;
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.FileName = textBoxFile.Text;
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = saveFileDialogExport.FileName;
            }

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            // Проверка существования файла
            if (System.IO.File.Exists(textBoxFile.Text))
            {
                if (MessageBox.Show("Файл с таким именем существует.\nПерезаписать файл?", "",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                    System.IO.File.Delete(textBoxFile.Text); // удаляем файл
            }

            groupBoxWait.Visible = true;
            progressBarEndLess.AutoProgress = true;

            bwExp.RunWorkerAsync("");
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            // Проверка существования файла
            if (System.IO.File.Exists(textBoxFile.Text))
            {
                if (MessageBox.Show("Файл с таким именем существует.\nПерезаписать файл?", "",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                    System.IO.File.Delete(textBoxFile.Text); // удаляем файл
            }



            groupBoxWait.Visible = true;
            progressBarEndLess.AutoProgress = true;

            bwExp.RunWorkerAsync("mail");
        }

        private void bwExp_DoWork(object sender, DoWorkEventArgs e)
        {
            StringBuilder fileTemp = new StringBuilder(1024);
            // Получим коротокое имя временного файла
            GetShortPathName(System.IO.Path.GetTempFileName(), fileTemp, fileTemp.Capacity);
            // Папка временного файла
            string dir = System.IO.Path.GetDirectoryName(fileTemp.ToString());
            string fileName = "tmp";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir +
                ";Mode = Share Deny None;Persist Security Info=False;Extended Properties=dBASE IV";
            try
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dir + ";Extended Properties=dbase IV;";
                    con.Open();
                }
                // Имя файла без расширения
                fileName = System.IO.Path.GetFileNameWithoutExtension(fileTemp.ToString());
                System.IO.File.Delete(dir + "\\" + fileName + ".dbf");  // на всякий случай удаляем
                // Создадим таблицу с именем временного файла
                bwExp.ReportProgress(0, "Создание файла");
                string strCom = "CREATE TABLE `" + fileName + "` (Dogovor varchar(20), " +
                    "Nompoint int, " +
                    "Fio varchar(50), " +
                    "Adress varchar(150), " +
                    "Mark varchar(15), " +
                    "Digit int, " +
                    "[Number] varchar(20), " +
                    //"Ind int, " +
                    //"[Zone] varchar(15),  " +
                    "[Date] datetime, " +
                    "[IND1] int," +
                    "[IND2] int," +
                    "[IND3] int," +
                    "[CONST_CODE] int )" 
                     ;


                OleDbCommand cmd = new OleDbCommand(strCom, con);
                cmd.ExecuteNonQuery();
                // Занесем данные
                for (int i = 0; i < dsExch.Tables["TableKOinUE"].Rows.Count; i++)
                {
                    bwExp.ReportProgress((int)(i * 100 / dsExch.Tables["TableKOinUE"].Rows.Count),
                        "Загрузка...\nЗаписей " + i.ToString() + " из " + dsExch.Tables["TableKOinUE"].Rows.Count.ToString());

                    DataRow r = dsExch.Tables["TableKOinUE"].Rows[i];

                    strCom = "insert into `" + fileName +
                     //        "` VALUEs(@dogovor, @fio, @adress, @mark, @digit, @number, @ind, @date)";
                   "` VALUEs(@dogovor, @nompoint, @fio, @adress, @mark, @digit, @number, @date, @ind1, @ind2, @ind3, @constcode)"; //, @ind, @zone


                    cmd = new OleDbCommand(strCom, con);
                    // Параметры функции 
                    OleDbParameter p = new OleDbParameter("@dogovor", r["CodeAbonent"]);//.ToString());
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@nompoint", Convert.ToInt16(r["NomPoint"]));
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@fio", r["fio"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@adress", r["address"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@mark", r["mark"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@digit", r["digit"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@number", r["number"]);
                    cmd.Parameters.Add(p);
                    //p = new OleDbParameter("@ind", r["indicator"]);
                    //cmd.Parameters.Add(p);
                    //p = new OleDbParameter("@zone", r["zone"]);
                    //cmd.Parameters.Add(p);
                    p = new OleDbParameter("@date", r["dateact"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@ind1", r["IND1"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@ind2", r["IND2"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@ind3", r["IND3"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@ind3", r["IND3"]);
                    cmd.Parameters.Add(p);
                    p = new OleDbParameter("@constcode", Convert.ToInt16("0"));
                    cmd.Parameters.Add(p);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) // ошибка соединения
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            //e.Result = dir + "\\" + fileName + ".dbf"; // возвращаем имя созданного файла

            System.IO.File.Move(dir + "\\" + fileName + ".dbf", textBoxFile.Text);

            if (e.Argument.ToString() == "mail")
            {
                bwExp.ReportProgress(100, "Сжатие файла");
                CompressFile(textBoxFile.Text, textBoxFile.Text + ".zip");
                bwExp.ReportProgress(100, "Отправка почты");
                //SendToMail(currentLand + "@ulges.ru", textBoxFile.Text + ".zip");
               SendToMail("PrvDB@ulges.ru", textBoxFile.Text + ".zip");
            //    SendToMail("PrvDBnc@ulges.ru", textBoxFile.Text + ".zip");

            }
        }

        // Сжатие файла
        private void CompressFile(string rfilename, string wfilename)
        {
            System.IO.FileStream infile = new System.IO.FileStream(rfilename,
                System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);

            byte[] buffer = new byte[infile.Length];
            infile.Read(buffer, 0, buffer.Length);
            infile.Close();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.Compression.GZipStream gzs = new System.IO.Compression.GZipStream(ms,
                System.IO.Compression.CompressionMode.Compress, true);
            gzs.Write(buffer, 0, buffer.Length);
            gzs.Close();
            gzs.Dispose();

            System.IO.FileStream outfile = new System.IO.FileStream(wfilename, System.IO.FileMode.Create);
            byte[] buffer2 = new byte[ms.Length];
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            ms.Read(buffer2, 0, buffer2.Length);
            outfile.Write(buffer2, 0, buffer2.Length);
            outfile.Close();
        }

        // Отправка email
        private void SendToMail(string email, string filename)
        {
            //Авторизация на SMTP сервере
            SmtpClient Smtp = new SmtpClient("domino", 25);
            Smtp.Credentials = new NetworkCredential("lev", "u09vdr");

            //Формирование письма
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("PrvDB@ulges.ru"); //email);
            Message.To.Add(new MailAddress("Levchenkovi@ulges.ru"));
            Message.Subject = "КО за период: c " + Convert.ToDateTime(dTPBeg.Value).ToString("dd.MM.yyyy") +
                " по " + Convert.ToDateTime(dTPEnd.Value).ToString("dd.MM.yyyy");
            Message.Body = "ОА МУП 'УльГЭС'";

            if (!String.IsNullOrEmpty(filename))
            {
                //Прикрепляем файл
                Attachment attach = new Attachment(filename, MediaTypeNames.Application.Octet);

                // Добавляем информацию для файла
                ContentDisposition disposition = attach.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(filename);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(filename);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(filename);

                Message.Attachments.Add(attach);
            }

            Smtp.Send(Message);//отправка

            MailMessage Message2 = new MailMessage();
            Message2.From = new MailAddress("PrvDBnc@ulges.ru");
            Message2.To.Add(new MailAddress("Levchenkovi@ulges.ru"));
            Message2.Subject = "КО за период: c " + Convert.ToDateTime(dTPBeg.Value).ToString("dd.MM.yyyy") +
                " по " + Convert.ToDateTime(dTPEnd.Value).ToString("dd.MM.yyyy");
            Message2.Body = "ОА МУП 'УльГЭС'";

            if (!String.IsNullOrEmpty(filename))
            {
                //Прикрепляем файл
                Attachment attach = new Attachment(filename, MediaTypeNames.Application.Octet);

                // Добавляем информацию для файла
                ContentDisposition disposition = attach.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(filename);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(filename);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(filename);

                Message2.Attachments.Add(attach);
            }

            Smtp.Send(Message2);//отправка
        }

        private void bwExp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Error == null) && (!e.Cancelled))
            {
              MessageBox.Show("Данные успешно выгружены");
            }
            groupBoxWait.Visible = false;
            progressBarEndLess.AutoProgress = false;
        }

           
    }
}
