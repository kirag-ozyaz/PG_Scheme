using FormLbr;
using LibraryTSQL;
using Logger;
using Npgsql;
using SchemeModelN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ExportToPostGIS
{
    public partial class FormExportReference : FormBase
    {
        string ServerPSQL = "192.168.1.33";
        string UserIdPSSQL="postgres";
        string PasswordPSSQL = "psql";
        string DatabasePSSQL = "U10";
        string DatabasePSSQL_GIS = "gis";
        private string connectionString;
        private string connectionString_GIS;
        bool showMessageBox = true;
        // MySQL
        string ServerMySQL = "192.168.1.135"; // "ulges-mysql";
        string UserIdMySQL = "root";
        string PasswordMySQL = "312jDSK-98";
        string DatabaseMySQLCaddy = "caddy";
        int PortMySQL = 3306;

        public FormExportReference()
        {
            InitializeComponent();
            #region Изменим ширину выпадающего списка
            int width = toolStripComboBox1.DropDownWidth;
            Graphics g = CreateGraphics();
            Font font = toolStripComboBox1.Font;
            int vertScrollBarWidth =
                (toolStripComboBox1.Items.Count > toolStripComboBox1.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;
            int newWidth;

            foreach (string s in toolStripComboBox1.Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            this.toolStripComboBox1.DropDownWidth = width;
            this.toolStripComboBox1.Size = new Size(width, this.toolStripComboBox1.Size.Height);
            
            #endregion
            connectionString = "Server=" + ServerPSQL + ";User id=" + UserIdPSSQL + ";Password=" + PasswordPSSQL + ";Database=" + DatabasePSSQL;
            connectionString_GIS = "Server=" + ServerPSQL + ";User id=" + UserIdPSSQL + ";Password=" + PasswordPSSQL + ";Database=" + DatabasePSSQL_GIS;
            toolStripComboBox1.SelectedIndex = 0;
            
        }
        private void ControlSelectionLengthComboBox(Control.ControlCollection controlCollection)
        {
            foreach (Control cb in controlCollection)
            {
                if (cb is ComboBox)
                {
                    cb.Resize += delegate (object sender, EventArgs e)
                    {
                        if (cb is ComboBox && !cb.Focused)
                        {
                            ((ComboBox)cb).SelectionLength = 0;
                        }
                    };
                }
                this.ControlSelectionLengthComboBox(cb.Controls);


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            // NpgsqlCommand com = new NpgsqlCommand("select * from \"PS\".\"Zone\"", conn);
            NpgsqlCommand com = new NpgsqlCommand("select geom, ST_AsText(geom) from \"Events\".\"Alarm\"", conn);
            conn.Open();
            NpgsqlDataReader reader;
             reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    string result = reader.GetString(1);//Получаем значение из второго столбца! Первый это (0)!
                    richTextBox1.AppendText(result + "\r\n");
                }
                catch { }

            }
//comm.ExecuteScalar() — возвращает значение.
//comm.ExecuteNonQuery() — выполняет запрос на изменение данных.
            conn.Close();
        }
  
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            this.toolStripComboBox1.Select(0, 0);
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                //Application.DoEvents();
                richTextBox2.Clear();
                richTextBox2.AppendText("Загружаем абонентов. " + DateTime.Now + "\n\r");
                Application.DoEvents();
                ExportAbonentToGIS();
                richTextBox2.AppendText("Закончили импортировать абонентов. " + DateTime.Now + "\n\r");
                //Application.DoEvents();
            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
                // 1. обновим поисковое представление
                NpgsqlConnection conn_gis = new NpgsqlConnection(connectionString);
                NpgsqlCommand com_gis = new NpgsqlCommand("REFRESH MATERIALIZED VIEW \"gis\".\"lizmap_search\"", conn_gis);
                conn_gis.Open();
                int reader_gis = com_gis.ExecuteNonQuery();
                conn_gis.Close();
                // 2. 
                richTextBox2.Clear();
                richTextBox2.AppendText("Загружаем объекты карты (tMapObj). " + DateTime.Now + "\n\r");
                Application.DoEvents();
                ExportDataTable("Sity", "tMapObj");
                richTextBox2.AppendText("Обновим импортированные данные tMapObj. " + DateTime.Now + "\n\r");
                Application.DoEvents();
                // 3. обновить вьюху vMapObj (корретно формируем улицы, нас. пункты, префиксы)
                // REFRESH MATERIALIZED VIEW "Sity"."vMapObj"
                NpgsqlConnection conn1 = new NpgsqlConnection(connectionString);
                NpgsqlCommand com1 = new NpgsqlCommand("REFRESH MATERIALIZED VIEW \"Sity\".\"vMapObj\"", conn1);
                conn1.Open();
                int reader1 = com1.ExecuteNonQuery();
                conn1.Close();
                //
                // 4. обновить вьюху vMapObjOSM
                // REFRESH MATERIALIZED VIEW "Sity"."vMapObjOSM"
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                // NpgsqlCommand com = new NpgsqlCommand("select * from \"PS\".\"Zone\"", conn);
                NpgsqlCommand com = new NpgsqlCommand("REFRESH MATERIALIZED VIEW \"Sity\".\"vMapObjOSM\"", conn);
                conn.Open();
                int  reader =  com.ExecuteNonQuery() ;
                conn.Close();
                // 5. Заполним корректными данными (названия улиц, районов и т.п.) таблицу MapObjOSM
                string chemaName = "Sity";
                string tableName = "MapObjectOSM";
                DataTable dataTable = new DataTable(tableName);
                pSQL dd = new pSQL
                {
                    connectionString = connectionString,
                    showMessageBox = showMessageBox
                };
                
                richTextBox2.AppendText("Закончили импортировать tMapObj. " + DateTime.Now + "\n\r");
            }
            else if (toolStripComboBox1.SelectedIndex == 3)
            {
                richTextBox2.Clear();
                richTextBox2.AppendText("Загружаем объекты схемы (tSchm_ObjList). " + DateTime.Now + "\n\r");
                Application.DoEvents();
                ExportSchmObjToGIS();
                richTextBox2.AppendText("Закончили ипортировать tSchm_ObjList. " + DateTime.Now + "\n\r");
            }
            else if (toolStripComboBox1.SelectedIndex == 4)
            {
                richTextBox2.Clear();
                richTextBox2.AppendText("Загружаем кладр. " + DateTime.Now + "\n\r");
                Application.DoEvents();
                ExportDataTable("Classifier", "tR_KladrDoma");
                richTextBox2.AppendText("Загрузили tR_KladrDoma. " + DateTime.Now + "\n\r");
                Application.DoEvents();

                ExportDataTable("Classifier", "tR_KladrObj");
                richTextBox2.AppendText("Загрузили tR_KladrObj. " + DateTime.Now + "\n\r");
                Application.DoEvents();

                ExportDataTable("Classifier", "tR_KladrSocr");
                richTextBox2.AppendText("Загрузили tR_KladrSocr. " + DateTime.Now + "\n\r");
                Application.DoEvents();

                ExportDataTable("Classifier", "tR_KladrStreet");
                richTextBox2.AppendText("Загрузили tR_KladrStreet. " + DateTime.Now + "\n\r");
                richTextBox2.AppendText("Закончили ипортировать кладр. " + DateTime.Now + "\n\r");

            }
            else if (toolStripComboBox1.SelectedIndex == 12) // Уличное освещение
            {
                richTextBox2.Clear();
                richTextBox2.AppendText("Загружаем карту уличного освещения. " + DateTime.Now + "\n\r");
                String connectionStringMySQL = "Server=" + ServerMySQL + ";Database=" + DatabaseMySQLCaddy
                              + ";port=" + PortMySQL + ";User Id=" + UserIdMySQL + ";password=" + PasswordMySQL;
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionStringMySQL))
                {
                    try
                    {
                        mySqlConnection.Open();

                        // 0. Классификатор
                        richTextBox2.AppendText("0. Классификатор " + DateTime.Now + "\n\r");
                        Application.DoEvents();
                        DataTable tblClassificator = GetDataTable(DatabaseMySQLCaddy, "classifier", mySqlConnection);
                        pSQL dd = new pSQL
                        {
                            connectionString = connectionString,
                            showMessageBox = showMessageBox
                        };
                        string chemaName = "Classifier";
                        string tableNameC = "ClassifierUO";
                        dd.DeleteSqlData(chemaName, tableNameC);
                        dd.ExportSqlData(tblClassificator, chemaName, tableNameC);

                        // 1. Светильники
                        richTextBox2.AppendText("1. Светильники " + DateTime.Now + "\n\r");
                        Application.DoEvents();

                        DataTable tblPillar = GetDataTable(DatabaseMySQLCaddy, "pillar", mySqlConnection);
                        tblPillar.PrimaryKey = new DataColumn[] { tblPillar.Columns["id"] };
                        chemaName = "NetworkStreetLighting";
                        tableNameC = "PillarsAirCableUON";
                        dd.ExportSqlData(tblPillar, chemaName, tableNameC, "height", "width");
                        
                        #region пример запроса
                        /*
                        String sql = "Select p.id, width, height, cl.name as s_area, build, " +
                            "us.fio as s_master, number, t.name as s_type, more, " +
                            "lt.name as s_light_type, ll.name as s_light_lamp, " +
                            "light_a, light_b, light_c, " +
                            "lt2.name as s_light2_type, ll2.name as s_light2_lamp, " +
                            "light2_a, light2_b, light2_c, " +
                            "a1, a2, a3 " +

                            "from caddy.pillar p " +
                                "left join caddy.classifier cl on cl.idItem = p.area and cl.Group = 'raion' " +
                                "left join caddy.user us on us.id = p.master " +
                                "left join caddy.classifier t on t.idItem = p.area and t.Group = 'pillar' " +
                                "left join caddy.classifier lt on lt.idItem = p.area and lt.Group = 'light_type' " +
                                "left join caddy.classifier ll on ll.idItem = p.area and ll.Group = 'light_lamp' " +
                                "left join caddy.classifier lt2 on lt2.idItem = p.area and lt2.Group = 'light_type' " +
                                "left join caddy.classifier ll2 on ll2.idItem = p.area and ll2.Group = 'light_lamp' " +
                                "order by p.id";
                         */
                        #endregion
                        // 2. Подстанции
                        richTextBox2.AppendText("2. Подстанции " + DateTime.Now + "\n\r");
                        Application.DoEvents();
                        DataTable tblBuild = GetDataTable(DatabaseMySQLCaddy, "build", mySqlConnection);
                        tblBuild.PrimaryKey = new DataColumn[] { tblBuild.Columns["id"] };
                        chemaName = "NetworkStreetLighting";
                        tableNameC = "SubStationUO";
                        dd.ExportSqlData(tblBuild, chemaName, tableNameC, "height", "width");
                        //  2.5. Сформируем массив ид объектов карты (опоры и подстанции)
                        int deltaPillar = 150000;
                        int deltaBuild = 100000;
                        var tMapObjects = tblPillar.AsEnumerable()
                            .Select(s => new { idCaddy = (int)s["idCaddy"] + deltaPillar, height = s["height"], width = s["width"], type = "pillar" })
                            .Union(tblBuild.AsEnumerable()
                            .Select(s => new { idCaddy = (int)s["idCaddy"] + deltaBuild, height = s["height"], width = s["width"], type = "build" }));
                        var dictMapObjects = tMapObjects.ToDictionary(d => d.idCaddy,d=>new { height = d.height, width = d.width });
                        /* Сбрасываеv счётчик последовательности примари кей
                         int last_value  = "select max( id ) + 1 from  "NetworkStreetLighting"."SubStationUO"";
                         ALTER SEQUENCE "NetworkStreetLighting"."SubStationUO_id_seq" RESTART WITH last_value;
                         */

                        // 3. Воздушные линии
                        richTextBox2.AppendText("3. Воздушные линии " + DateTime.Now + "\n\r");
                        Application.DoEvents();
                        DataTable tblLine = GetDataTable(DatabaseMySQLCaddy, "line", mySqlConnection);
                        tblLine.PrimaryKey = new DataColumn[] { tblLine.Columns["id"] };
                        tblLine.Columns.Add("geom", typeof(String));

                        chemaName = "NetworkStreetLighting";
                        tableNameC = "AirCableUO";
                        bool isCreateRowGeom = true;
                        #region проба 1 
                        //foreach (DataRow row in tblLine.Rows)
                        //{

                        //    string strGeom = "st_multi(ST_MakeLine(ARRAY[";

                        //    string points = row["points"].ToString().Replace(" ", String.Empty);

                        //    string[] arrPoints = points.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        //    for (int i = 0; i < arrPoints.Length; i++)
                        //    {
                        //        string[] arrCoordinates = arrPoints[i].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                        //        int idBeg = Convert.ToInt32(arrCoordinates[0]);
                        //        int idEnd = Convert.ToInt32(arrCoordinates[1]);

                        //        var PointBegins = dictMapObjects.Where(k => k.Key == idBeg);
                        //        var PointEnds = dictMapObjects.Where(k => k.Key == idEnd);

                        //        if (PointBegins.Count() > 0 && PointEnds.Count() > 0)
                        //        {
                        //            var PointBegin = PointBegins.First().Value;
                        //            var PointEnd = PointEnds.First().Value;

                        //            string strGeomBegin = $"ST_MakePoint({(PointBegin.height)}, {PointBegin.width})";
                        //            string strGeomEnd = $"ST_MakePoint({(PointEnd.height)}, {PointEnd.width})";
                        //            // если точка уже есть массиве линии, то ее пропускаем
                        //            if (!strGeom.Contains(strGeomBegin))
                        //                strGeom += $"{strGeomBegin},";
                        //            if (!strGeom.Contains(strGeomEnd))
                        //                strGeom += $"{strGeomEnd},";

                        //            strGeom += $"{strGeomBegin}, {strGeomEnd},";
                        //        }
                        //        else
                        //        {
                        //            richTextBox2.AppendText("3.1. ВK: " + row["id"] + "\r");
                        //            richTextBox2.AppendText("3.2. ВK: " + points + "\r");
                        //            if (PointBegins.Count() <= 0)
                        //            {
                        //                richTextBox2.AppendText($"3.3. id { idBeg} начальной точки  не найден " + DateTime.Now + "\r");
                        //            }
                        //            if (PointEnds.Count() <= 0)
                        //            {
                        //                richTextBox2.AppendText($"3.4. id { idEnd} конечной точки  не найден " + DateTime.Now + "\r");
                        //            }
                        //            isCreateRowGeom = false;
                        //            break;
                        //        }
                        //    }
                        //    strGeom = strGeom.Remove(strGeom.Length - 1); // удаляем последний знак, это запятая должна быть
                        //    // strGeom = strGeom.Remove(strGeom.LastIndexOf(","));
                        //    strGeom += "]";
                        //    strGeom += "))";
                        //    if (isCreateRowGeom)
                        //        row["geom"] = strGeom;
                        //    else
                        //        isCreateRowGeom = true;
                        //}
                        #endregion

                        #region проба 2
                        foreach (DataRow row in tblLine.Rows)
                        {
                            string strGeom = "st_multi(ST_LineMerge('MULTILINESTRING (";

                            string points = row["points"].ToString().Replace(" ", String.Empty);
                            // надо проверить, была ли данная линия в спиcке и пропустить если была
                            string[] arrPoints = points.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < arrPoints.Length; i++)
                            {
                                string[] arrCoordinates = arrPoints[i].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                                int idBeg = Convert.ToInt32(arrCoordinates[0]);
                                int idEnd = Convert.ToInt32(arrCoordinates[1]);

                                var PointBegins = dictMapObjects.Where(k => k.Key == idBeg);
                                var PointEnds = dictMapObjects.Where(k => k.Key == idEnd);

                                if (PointBegins.Count() > 0 && PointEnds.Count() > 0)
                                {
                                    var PointBegin = PointBegins.First().Value;
                                    var PointEnd = PointEnds.First().Value;

                                    // Если начальная точка и конечная точка равны, то геометрия будет ошибчной
                                    // пропускаем
                                    if ((double)PointBegin.height == (double)PointEnd.height && (double)PointBegin.width == (double)PointEnd.width)
                                    {
                                        richTextBox2.AppendText("3.5. ВK: " + row["id"] + "\r");
                                        richTextBox2.AppendText("     ВK: " + points + "\r");
                                        richTextBox2.AppendText($"    ВK: координаты начальной {idBeg} и конечной {idEnd} точек равны" + "\r");
                                        isCreateRowGeom = false;
                                        break;
                                    }

                                    string strGeomBegin = $"{(PointBegin.height)} {PointBegin.width}";
                                    string strGeomEnd = $"{(PointEnd.height)} {PointEnd.width}";

                                    strGeom += $"({strGeomBegin}, {strGeomEnd}),";
                                }
                                else
                                {
                                    richTextBox2.AppendText("3.1. ВK: " + row["id"] + "\r");
                                    richTextBox2.AppendText("3.2. ВK: " + points + "\r");
                                    if (PointBegins.Count() <= 0)
                                    {
                                        richTextBox2.AppendText($"3.3. id { idBeg} начальной точки  не найден " + DateTime.Now + "\r");
                                    }
                                    if (PointEnds.Count() <= 0)
                                    {
                                        richTextBox2.AppendText($"3.4. id { idEnd} конечной точки  не найден " + DateTime.Now + "\r");
                                    }
                                    isCreateRowGeom = false;
                                    break;
                                }
                            }
                            strGeom = strGeom.Remove(strGeom.Length - 1); // удаляем последний знак, это запятая должна быть

                            strGeom += ")'";
                            strGeom += "))";
                            if (isCreateRowGeom)
                                row["geom"] = strGeom;
                            else
                                isCreateRowGeom = true;
                        }

                        #endregion

                        dd.ExportSqlDataGeom(tblLine, chemaName, tableNameC);
                        // finish
                        richTextBox2.AppendText("Закончили импортировать данные уличного освещения. " + DateTime.Now + "\n\r");
                    }
                    catch (Exception ex)
                    {

                        if (showMessageBox)
                            MessageBox.Show(ex.Message, ex.Source);
                        else
                            Log.Write(Logger.LogLevel.Error, "ExportToPostGIS", "FormExportReference", "Connect DataBase. ", ex.Message, null);
                    }
                }
            }
        }
        /// <summary>
        /// Получить данные из mysql таблицы при готовом соединении
        /// </summary>
        private DataTable GetDataTable(string databaseMySQL, string tableNameMySQL, MySqlConnection mySqlConnection, string Where = "", string AddColumnSelect = "")
        {
            DataTable tableMySQL = new DataTable(tableNameMySQL);
            try
            {
                using (MySqlDataAdapter daMySql = new MySqlDataAdapter())
                {
                    string strSelect = $"SELECT *{(AddColumnSelect == ""?", id as idCaddy": AddColumnSelect)} FROM  {DatabaseMySQLCaddy}.{tableNameMySQL}";
                    strSelect += Where != "" ?  $" WHERE {Where}":"";


                    MySqlCommand cmd = new MySqlCommand(strSelect, mySqlConnection);
                    daMySql.SelectCommand = cmd;

                    daMySql.Fill(tableMySQL);
                }
            }
            catch (Exception ex)
            {

                if (showMessageBox)
                    MessageBox.Show(ex.Message, ex.Source);
                else
                    Log.Write(Logger.LogLevel.Error, "ExportToPostGIS", "FormExportReference", "LoadData - " + tableNameMySQL, ex.Message, null);
            }
            return tableMySQL;
        }

        /// <summary>
        /// таблица объектов схемы, должна быть заранее создана на серваке
        /// </summary>
        public void ExportSchmObjToGIS()
        {
            // ;SCM;PS;
            string where = " where [TypeCodeId] in (" +
                "535,1275,537,1034,538,536" +
                ") " ;

            SchemeModelN.ElectricModel electricModel = new SchemeModelN.ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema();

            string tableName = "tSchm_ObjList";
            string chemaName = "Sity";
            //
            DataTable dataTable = new DataTable(tableName);
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    string sqlS = "SELECT *, id as idSchmObj FROM  " + tableName + " " + where + " and deleted = 0";
                    dataTable = new DataSql.SqlDataCommand(this.SqlSettings).SelectSqlData(sqlS);
                }
                catch (Exception ex)
                {
                    if (showMessageBox)
                        MessageBox.Show(ex.Message, ex.Source);
                    else
                        Log.Write(Logger.LogLevel.Error, "ExportToPostGIS", "ExportSchmObjToGIS", "LoadData - " + tableName, ex.Message, null);
                }
            }
            //
            dataTable.Columns.Add("FullName", typeof(string));
            dataTable.Columns.Add("LevelVoltage", typeof(string));
            dataTable.Columns.Remove("id");
            dataTable.Columns.Remove("Location");
            dataTable.Columns.Remove("idGroup");
            dataTable.Columns.Remove("Tag");
            dataTable.Columns.Remove("NameP");

            foreach (DataRow row in dataTable.Rows)
            {
                var param = electricModel.GetParamsElectricObjectById(Convert.ToInt32(row["idSchmObj"]));
                row["FullName"] = param.ElectricSubName;
                row["LevelVoltage"] = param.VoltageSub;

            }
            //
            pSQL dd = new pSQL
            {
                connectionString = connectionString,
                showMessageBox = showMessageBox
            };
            dd.DeleteSqlData(chemaName, tableName);
            dd.ExportSqlData(dataTable, chemaName, tableName);
        }
        /// <summary>
        /// таблица абонентов, должна быть заранее создана на серваке
        /// </summary>
        public void ExportAbonentToGIS()
        {
            string tableName = "tSchmAbnFull";
            string chemaName = "Sity";

            DataTable tableSchmAbnFull = new DataTable("vL_SchmAbnFull");
            Reference.Tables.LoadTableSChmAbnFull_2019(tableSchmAbnFull, this.SqlSettings, DateTime.Now);

            pSQL dd = new pSQL
            {
                connectionString = connectionString,
                showMessageBox = showMessageBox
            };
            dd.DeleteSqlData(chemaName, tableName);
            dd.ExportSqlData(tableSchmAbnFull, chemaName, tableName);
           
        }
        /// <summary>
        /// Экспорт данных из mssql в psql
        /// </summary>
        /// <param name="chemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        public void ExportDataTable(string chemaName, string tableName, string where = "")
        {
            DataTable dataTable = new DataTable(tableName);
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    string sqlS = "SELECT * FROM  " + tableName + " " + where;
                    dataTable = new DataSql.SqlDataCommand(this.SqlSettings).SelectSqlData(sqlS);
                    
                }
                catch (Exception ex)
                {
                    if (showMessageBox)
                        MessageBox.Show(ex.Message, ex.Source);
                    else
                        Log.Write(Logger.LogLevel.Error, "ExportToPostGIS", "FormExportReference", "LoadData - " + tableName, ex.Message, null);
                }
            }

            pSQL dd = new pSQL
            {
                connectionString = connectionString,
                showMessageBox = showMessageBox
            };
            dd.DeleteSqlData(chemaName, tableName);
            dd.ExportSqlData(dataTable, chemaName, tableName);
        }

        private void FormExportReference_Load(object sender, EventArgs e)
        {
            this.ControlSelectionLengthComboBox(base.Controls);
        }

        //private void tsbPersonnel_Click(object sender, EventArgs e)
        //{
        //    //
        //    Personnel.Export export = new Personnel.Export();
        //    export.SqlSettings = this.SqlSettings;
        //    export.Start();
        //}
    }
  
}

