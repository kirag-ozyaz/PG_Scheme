using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using DataSql;
using SchemeCtrl2.Canvas;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Data.SqlClient;
using SchemeCtrl2.DrawTool;

namespace Test1
{
    public partial class Form1 : FormLbr.FormBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_ClientSizeChanged(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_LocationChanged(object sender, EventArgs e)
        {
            //
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            pageReestrDocs1.SqlSettings = this.SqlSettings;
        }

        private void dtpDateDoc_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the DateTimePicker.ValueChanged event.");
        }

        private void dtpDateDoc_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the DateTimePicker.CloseUp event.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string machineName = "ulges-app";
            var services = ServiceController.GetServices(machineName);
            var service = services.First(s => s.ServiceName == "EIS SchemeService");
            service.Stop();

            service.Start();

        }

        private void toolStripButtonExportExcel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
        internal SchemeCtrl2.WCF.Proxy_Singleton proxy_Singleton_0 = SchemeCtrl2.WCF.Proxy_Singleton.GetInstance();
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string hostName = System.Net.Dns.GetHostName();
                System.Net.IPAddress ipaddress = System.Net.Dns.GetHostByName(hostName).AddressList[0];
                System.ServiceModel.NetTcpBinding netTcpBinding = new System.ServiceModel.NetTcpBinding(System.ServiceModel.SecurityMode.None);
                netTcpBinding.Security.Mode = System.ServiceModel.SecurityMode.None;
                netTcpBinding.SendTimeout = TimeSpan.FromSeconds(10.0);
                netTcpBinding.ReliableSession.Enabled = true;

                //    FormGeneralScheme2 formGeneralScheme2 = new FormGeneralScheme2(new SQLSettings(this.eisSettings.SqlSettings), new EndpointAddress(new Uri("net.tcp://192.168.1.248:22222/WCFSchemeServer").ToString()), 1);
                //
            }
            catch
            {
            }


        }
        /*********************************************************************/
        DataSetScheme dsScheme = new DataSetScheme();
        CanvasControl control = new CanvasControl();
        private void LoadSchemaMain_Click(object sender, EventArgs e)
        {

            SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
            eTypeCanvas typeCanvas = control.TypeCanvas;
            //if (typeCanvas == eTypeCanvas.SchemeMain)
            //{
            sqlDataCommand.SelectSqlData(this.dsScheme.vSchm_ObjListXml, false, " where TypeSchema = " + 1 + " and [Deleted] = 0 ", null, false, 0);
            //this.SendMessage("Объектов в базе: " + this.dsScheme.vSchm_ObjListXml.Rows.Count.ToString(), eMessageType.Information);
            sqlDataCommand.SelectSqlData(this.dsScheme.tSchm_Label, true, "where Tag is null", null, false, 0);
            ////this.SendMessage("Надписей в базе: " + this.dsScheme.tSchm_Label.Rows.Count.ToString(), eMessageType.Information);
            sqlDataCommand.SelectSqlData(this.dsScheme.tSchm_Relation, true, "", null, false, 0);
            //this.SendMessage("Связей в базе: " + this.dsScheme.tSchm_Relation.Rows.Count.ToString(), eMessageType.Information);
            sqlDataCommand.SelectSqlData(this.dsScheme.vSchm_CabSection, true, " where deleted = 0 ", null, false, 0);
            sqlDataCommand.SelectSqlData(this.dsScheme.tSchm_ObjList, false, " where [TypeCodeId] = 940 and [Deleted] = 0 ", null, false, 0);
            sqlDataCommand.SelectSqlData(this.dsScheme.vP_PassportDataReports, true, "where typecodeid in (538,535,537,536) and [CharName] like 'Принадлежность' and [CharValue] like 'Абонентская'", null, false, 0);

            this.LoadMainSchema();
            //}
        }
        private List<SchemeCtrl2.DrawTool.LineToolState> ObjectsWithState =  new List<LineToolState>();
        public Dictionary<int, SchemeCtrl2.DrawTool.PointTool> loadedPoints = new Dictionary<int, PointTool>();
        private List<SchemeCtrl2.Layers.ICanvasLayer> layers = new List<SchemeCtrl2.Layers.ICanvasLayer>();
        internal Dictionary<int, SchemeCtrl2.DrawTool.GroupDrawObjectBase> groups = new Dictionary<int, GroupDrawObjectBase>();
        private SchemeCtrl2.Layers.ICanvasLayer icanvasLayer_0;
        private void LoadMainSchema()
        {
            rtbSchemaMain.Clear();
            if (this.ObjectsWithState != null)
            {
                this.ObjectsWithState.Clear();
            }
            //this.SendMessage("Начало очитски памяти", eMessageType.Information);
            this.loadedPoints.Clear();
            this.loadedPoints = new Dictionary<int, SchemeCtrl2.DrawTool.PointTool>();
            //this.SendMessage("Почистили точки", eMessageType.Information);
            this.layers.Clear();
            //this.SendMessage("Почистили память", eMessageType.Information);
            this.groups.Clear();
            SchemeCtrl2.Layers.DrawingLayer drawingLayer = new SchemeCtrl2.Layers.DrawingLayer("SchemaMain", "SchemaMain", Color.White, 0f);
            
            drawingLayer.Parent = control;
            control.AddLayer(drawingLayer);
            control.ActiveLayer = drawingLayer;
            foreach (object obj7 in this.dsScheme.tSchm_ObjList.Rows)
            {
                DataRow dataRow = (DataRow)obj7;
                SchemeCtrl2.DrawTool.GroupDrawObjectBase groupDrawObjectBase = new SchemeCtrl2.DrawTool.GroupDrawObjectBase();
                groupDrawObjectBase.Id = Convert.ToInt32(dataRow["id"]);
                groupDrawObjectBase.Name = dataRow["Name"].ToString();
                this.groups.Add(groupDrawObjectBase.Id, groupDrawObjectBase);
            }
            SchemeCtrl2.Layers.DrawingLayer obj2 = drawingLayer;
            lock (obj2)
            {
                new XmlDocument();
                string text = "";
                foreach (object obj3 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.eTypeRectangleTool)))
                {
                    SchemeCtrl2.DrawTool.eTypeRectangleTool eTypeRectangleTool = (SchemeCtrl2.DrawTool.eTypeRectangleTool)obj3;
                    text = text + Convert.ToInt32(eTypeRectangleTool).ToString() + ",";
                }
                text = text.Remove(text.Length - 1);
                IEnumerable<DataRow> enumerable = this.dsScheme.vSchm_ObjListXml.Select("TypeCodeId in (" + text + ")");
                text = "";
                foreach (object obj4 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.eTypeShinaTool)))
                {
                    SchemeCtrl2.DrawTool.eTypeShinaTool eTypeShinaTool = (SchemeCtrl2.DrawTool.eTypeShinaTool)obj4;
                    text = text + Convert.ToInt32(eTypeShinaTool).ToString() + ",";
                }
                text = text.Remove(text.Length - 1);
                IEnumerable<DataRow> enumerable2 = this.dsScheme.vSchm_ObjListXml.Select(" TypeCodeId in (" + text + ")");
                // формирование списка ячеек
                text = "";
                foreach (object obj5 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.LineToolType)))
                {
                    SchemeCtrl2.DrawTool.LineToolType lineToolType = (SchemeCtrl2.DrawTool.LineToolType)obj5;
                    if (lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_10 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_6 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_04 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_023)
                    {
                        text = text + Convert.ToInt32(lineToolType).ToString() + ",";
                    }
                }
                text = text.Remove(text.Length - 1);
                var drCells = this.dsScheme.vSchm_ObjListXml.Select("  TypeCodeId in (" + text + ")");
                //
                text = "";
                foreach (object obj6 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.LineToolType)))
                {
                    SchemeCtrl2.DrawTool.LineToolType lineToolType2 = (SchemeCtrl2.DrawTool.LineToolType)obj6;
                    if (lineToolType2 != SchemeCtrl2.DrawTool.LineToolType.CellLine_10 && lineToolType2 != SchemeCtrl2.DrawTool.LineToolType.CellLine_6 && lineToolType2 != SchemeCtrl2.DrawTool.LineToolType.CellLine_04 && lineToolType2 != SchemeCtrl2.DrawTool.LineToolType.CellLine_023)
                    {
                        text = text + Convert.ToInt32(lineToolType2).ToString() + ",";
                    }
                }
                text = text.Remove(text.Length - 1);
                IEnumerable<DataRow> enumerable4 = this.dsScheme.vSchm_ObjListXml.Select("TypeCodeId in (" + text + ")");
                int[] typeCodeId = new int[]
                {
                    556
                };
                DataTable journalData = Passport.Classes.PassportData.GetJournalData(this.SqlSettings, typeCodeId);
                typeCodeId = new int[]
                {
                    546
                };
                DataTable journalData2 = Passport.Classes.PassportData.GetJournalData(this.SqlSettings, typeCodeId);
                DataTable dataTable = new DataTable();
                SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
                SqlCommand sqlCommand = new SqlCommand("select obj.id as id, objChar.Value as lineLength from tSchm_ObjList as obj inner join\r\n                                            tP_Passport on obj.id=tP_Passport.idObjList inner join\r\n                                            tP_ObjectChar as objChar on tP_Passport.id=objChar.idPassport and objChar.idObjChar=182", sqlConnection);
                try
                {
                    sqlConnection.Open();
                    dataTable.Load(sqlCommand.ExecuteReader());
                }
                catch
                {
                }
                Dictionary<int, SchemeCtrl2.DrawTool.DrawObjectBase> dictionary = new Dictionary<int, SchemeCtrl2.DrawTool.DrawObjectBase>();
                foreach (DataRow dataRow2 in enumerable)
                {
                    try
                    {
                        SchemeCtrl2.DrawTool.RectangleTool rectangleTool = new SchemeCtrl2.DrawTool.RectangleTool(dataRow2, drawingLayer);
                        rectangleTool.IsSubscriber = (this.dsScheme.vP_PassportDataReports.Select(string.Format("[IdObj] = {0}", rectangleTool.IdBase)).Length != 0);
                        dictionary.Add(rectangleTool.IdBase, rectangleTool);
                        //rectangleTool.EndDrawEvent += this.newObject_EndDrawEvent;
                        if (dataRow2["idGroup"] != DBNull.Value)
                        {
                            int key = Convert.ToInt32(dataRow2["idGroup"]);
                            if (this.groups.ContainsKey(key))
                            {
                                this.groups[key].Add(rectangleTool);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //this.SendMessage(string.Concat(new string[]
                        //{
                        //    "Не удалось загрузить подстанцию: id = ",
                        //    dataRow2["id"].ToString(),
                        //    " (",
                        //    ex.Message,
                        //    ")"
                        //}), eMessageType.Error);
                    }
                }
                //this.SendMessage("Загружено подстанций: " + enumerable.Count<DataRow>(), eMessageType.Information);
                foreach (DataRow dataRow3 in enumerable2)
                {
                    try
                    {
                        ShinaTool shinaTool = new ShinaTool(dataRow3, drawingLayer);
                        shinaTool.Parent = dictionary[Convert.ToInt32(dataRow3["idParent"])];
                        //shinaTool.EndDrawEvent += this.newObject_EndDrawEvent;
                        int idBase = shinaTool.IdBase;
                        if (dataRow3["idGroup"] != DBNull.Value)
                        {
                            int key2 = Convert.ToInt32(dataRow3["idGroup"]);
                            if (this.groups.ContainsKey(key2))
                            {
                                this.groups[key2].Add(shinaTool);
                            }
                        }
                        DataRow[] array = this.dsScheme.vSchm_ObjListXml.Select(" IdParent = " + shinaTool.IdBase.ToString() + " and typeCodeId = " + 111.ToString());
                        for (int i = 0; i < array.Length; i++)
                        {
                            PointShinaTool pointShinaTool = new PointShinaTool(array[i]);
                            pointShinaTool.Layer = drawingLayer;
                            shinaTool.AddPointShinaTool(pointShinaTool);
                            this.loadedPoints.Add(pointShinaTool.IdBase, pointShinaTool);
                        }
                    }
                    catch
                    {
                        //this.SendMessage("Не удалось загрузить шину: id = " + dataRow3["id"].ToString(), eMessageType.Error);
                    }
                }
                //this.SendMessage("Загружено шин: " + enumerable2.Count<DataRow>(), eMessageType.Information);
                // грузим ячейки
                foreach (DataRow dataRow4 in drCells)
                {
                    try
                    {
                        LineCellTool lineCellTool = new LineCellTool(dataRow4, drawingLayer);
                        if (dictionary.ContainsKey(Convert.ToInt32(dataRow4["IdParent"])))
                        {
                            lineCellTool.Parent = dictionary[Convert.ToInt32(dataRow4["IdParent"])];
                            //lineCellTool.EndDrawEvent += this.newObject_EndDrawEvent;
                            // эта хрень (условие ) здесь не нужно
                            if (dataRow4["idGroup"] != DBNull.Value)
                            {
                                int key3 = Convert.ToInt32(dataRow4["idGroup"]);
                                if (this.groups.ContainsKey(key3))
                                {
                                    this.groups[key3].Add(lineCellTool);
                                }
                            }
                            foreach (Branch branch in lineCellTool.Branches)
                            {
                                foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
                                {
                                    if (drawObjectBase.GetType() == typeof(TransformerTool))
                                    {
                                        TransformerTool transformerTool = (TransformerTool)drawObjectBase;
                                        DataRow[] array2 = journalData.Select("id = " + transformerTool.IdBase.ToString() + " and IdPassport is not null");
                                        if (array2.Length != 0)
                                        {
                                            transformerTool.passportDataRow = array2[0];
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        this.rtbSchemaMain.AppendText("Не удалось загрузить ячейку: id = " + dataRow4["id"].ToString() + "\r\n");
                        //this.SendMessage("Не удалось загрузить ячейку: id = " + dataRow4["id"].ToString(), eMessageType.Error);
                    }
                }
                //this.SendMessage("Загружено ячеек: " + drCells.Count<DataRow>(), eMessageType.Information);
                // грузим линии
                foreach (DataRow dataRow5 in enumerable4)
                {
                    try
                    {
                        LineTool lineTool = new LineTool(dataRow5, drawingLayer);
                        ////lineTool.EndDrawEvent += this.newObject_EndDrawEvent;
                        if (lineTool.Branches.Count == 0)
                        {
                            lineTool.Remove(false, false);
                            //this.SendMessage(string.Concat(new string[]
                            //{
                            //    "Линия ",
                            //    lineTool.ToString(),
                            //    "(id: ",
                            //    lineTool.IdBase.ToString(),
                            //    ") вызвала ошибку при загрузке (не загружена ни одна ветка)"
                            //}), eMessageType.Error);
                        }
                        else
                        {
                            if (!lineTool.Validation())
                            {
                            //    this.SendMessage(lineTool, lineTool.ErrorString, eMessageType.Error);
                            }
                            if (dataRow5["idGroup"] != DBNull.Value)
                            {
                                int key4 = Convert.ToInt32(dataRow5["idGroup"]);
                                if (this.groups.ContainsKey(key4))
                                {
                                    this.groups[key4].Add(lineTool);
                                }
                            }
                            foreach (Branch branch2 in lineTool.Branches)
                            {
                                foreach (DrawObjectBase drawObjectBase2 in branch2.ChildObjects)
                                {
                                    if (drawObjectBase2.GetType() == typeof(TextBranchTool))
                                    {
                                        string text2 = string.Empty;
                                        DataRow[] array3 = dataTable.Select("id=" + lineTool.IdBase.ToString());
                                        if (array3.Length != 0)
                                        {
                                            text2 = array3[0][1].ToString();
                                        }
                                        TextBranchTool textBranchTool = (TextBranchTool)drawObjectBase2;
                                        IEnumerable<DataRow> enumerable5 = this.dsScheme.vSchm_CabSection.Select("idObjList = " + lineTool.IdBase);
                                        if (enumerable5.Count<DataRow>() > 0)
                                        {
                                            decimal d = 0m;
                                            DataRow dataRow6 = null;
                                            decimal num = 0m;
                                            foreach (DataRow dataRow7 in enumerable5)
                                            {
                                                if (!dataRow7.IsNull("Length"))
                                                {
                                                    num += Convert.ToDecimal(dataRow7["Length"]);
                                                    if (dataRow6 == null && !dataRow7.IsNull("Length") && Convert.ToDecimal(dataRow7["Length"]) >= 10m && !dataRow7.IsNull("CrossSection"))
                                                    {
                                                        d = Convert.ToDecimal(dataRow7["CrossSection"]);
                                                        dataRow6 = dataRow7;
                                                    }
                                                    else if (!dataRow7.IsNull("Length") && !dataRow7.IsNull("CrossSection") && Convert.ToDecimal(dataRow7["CrossSection"]) < d && Convert.ToDecimal(dataRow7["Length"]) >= 10m)
                                                    {
                                                        d = Convert.ToDecimal(dataRow7["CrossSection"]);
                                                        dataRow6 = dataRow7;
                                                    }
                                                }
                                            }
                                            if (dataRow6 != null)
                                            {
                                                if (text2 == string.Empty)
                                                {
                                                    text2 = Math.Round(Convert.ToDecimal(num), 0).ToString();
                                                }
                                                textBranchTool.UpdateSQLFields(dataRow6, text2);
                                            }
                                        }
                                        DataRow[] array4 = journalData2.Select("id = " + lineTool.IdBase.ToString());
                                        if (array4.Length != 0)
                                        {
                                            textBranchTool.passportDataRow = array4[0];
                                        }
                                    }
                                    else if (drawObjectBase2.GetType() == typeof(TransformerTool))
                                    {
                                        TransformerTool transformerTool2 = (TransformerTool)drawObjectBase2;
                                        DataRow[] array5 = journalData.Select("id = " + transformerTool2.IdBase.ToString());
                                        if (array5.Length != 0)
                                        {
                                            transformerTool2.passportDataRow = array5[0];
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        //this.SendMessage("Не удалось загрузить линию: id = " + dataRow5["id"].ToString(), eMessageType.Error);
                    }
                }
                //this.SendMessage("Загружено линий: " + enumerable4.Count<DataRow>(), eMessageType.Information);
                foreach (DataRow rLabel in this.dsScheme.tSchm_Label.Rows)
                {
                    if (rLabel["IdParent"] != DBNull.Value)
                    {
                        if (dictionary.ContainsKey(Convert.ToInt32(rLabel["idParent"])))
                        {
                            ((RectangleTool)dictionary[Convert.ToInt32(rLabel["idParent"])]).AddLabelTool(rLabel);
                        }
                        else
                        {
                            LabelTool labelTool = LabelTool.GetLabelTool(rLabel);
                            if (labelTool != null)
                            {
                                IEnumerable<DrawObjectBase> source = from o in this.layers[0].Objects
                                                                     where o.IdBase == Convert.ToInt32(rLabel["idParent"])
                                                                     select o;
                                if (source.Count<DrawObjectBase>() > 0)
                                {
                                    labelTool.Parent = source.First<DrawObjectBase>();
                                    control.AddObject(drawingLayer, labelTool);
                                }
                            }
                        }
                    }
                    else
                    {
                        LabelTool labelTool2 = LabelTool.GetLabelTool(rLabel);
                        if (labelTool2 != null)
                        {
                            control.AddObject(drawingLayer, labelTool2);
                        }
                    }
                }
                if (control.SimulationMode == eSimulationMode.Normal)
                {
                    //foreach (DrawObjectBase drawObjectBase3 in from obj in this.icanvasLayer_0.Objects
                    //                                           where obj is ObjectOnLine
                    //                                           select obj)
                    //{
                    //    ((ObjectOnLine)drawObjectBase3).NormalSectionModeOn = true;
                    //}
                }
                control.OnSimulate();
                control.DoInvalidate(true);
            }
        }


    }
}
