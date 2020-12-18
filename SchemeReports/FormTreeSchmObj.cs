using ControlsLbr;
using SchemeModelN;
using SchemeModelN.Calculations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchemeReports
{
    public partial class FormTreeSchmObj : FormLbr.FormBase
    {
        private ElectricModel electricModel;
        private DataTable dtSchmCable = new DataTable("SchmCable");
        private delegate TreeDataGridViewNode TreeParametr(TreeDataGridViewNodeCollection nodes, params object[] values);
        /// <summary>
        /// список подстанций
        /// </summary>
        private List<int> listElectricObect = new List<int>();

        public FormTreeSchmObj()
        {
            InitializeComponent();
            //
            //this.subNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //dgvTreeSub.Columns.Remove("idSubColumn");
            //dgvTreeSub.Columns.Remove("busNameColumn");
            //dgvTreeSub.Columns.Remove("idBusColumn");
            //dgvTreeSub.Columns.Remove("cellNameColumn");
            //dgvTreeSub.Columns.Remove("idCellColumn");
            //dgvTreeSub.Columns.Remove("trNameColumn");
            //dgvTreeSub.Columns.Remove("idTrColumn");
            //dgvTreeSub.Columns.Remove("powerColumn");
            //dgvTreeSub.Columns.Remove("loadColumn");
            //dgvTreeSub.Columns.Remove("dateOnColumn");
            //dgvTreeSub.Columns.Remove("noAdmissionKWTColumn");
        }
        /// <summary>
        ///  вернуть режим просомтра документа
        /// </summary>
        /// <returns></returns>
        public bool FormViewMode { get;  set; }

        private void dgvTree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (this.dgvTreeSub[this.trNameColumn.Index, e.RowIndex].Value != null && !string.IsNullOrEmpty(this.dgvTreeSub[this.trNameColumn.Index, e.RowIndex].Value.ToString()))
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
                if (this.dgvTreeSub[this.dateOnColumn.Index, e.RowIndex].Value != null && !string.IsNullOrEmpty(this.dgvTreeSub[this.dateOnColumn.Index, e.RowIndex].Value.ToString()))
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
            }
        }
        private void dgvTree_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right && !this.FormViewMode )
            {
                this.contextMenuDgvTree.Show(Cursor.Position);
            }
        }

        private void tsbLoadTreeSchmema_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
        private void RefreshTable()
        {
            this.tsbLoadTreeSchmema.Enabled = false;
            this.backgroundWorker.RunWorkerAsync();

        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.tsbLoadTreeSchmema.Enabled = true;
        }
        /// <summary>
        /// Очистка таблицы отключенных подстанций
        /// </summary>
        private void dgvTreeNodesSubClear()
        {
            if (this.dgvTreeSub.InvokeRequired)
            {
                this.dgvTreeSub.Invoke(new MethodInvoker(this.dgvTreeNodesSubClear));
                return;
            }
            this.dgvTreeSub.Nodes.Clear();
        }
        /// <summary>
        /// Добавление параметров в дерево отключенных подстанций 
        /// </summary>
        private TreeDataGridViewNode AddTreeParametrSub(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection, params object[] values)
        {
            if (this.dgvTreeSub.InvokeRequired)
            {
                return (TreeDataGridViewNode)this.dgvTreeSub.Invoke(new FormTreeSchmObj.TreeParametr(this.AddTreeParametrSub), new object[]
                {
                treeDataGridViewNodeCollection,
                values
                });
            }
            return treeDataGridViewNodeCollection.Add(values);
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.dgvTreeNodesSubClear();
            // таблица кабелей
            References.SchemeTables.GetTableSchmCable(dtSchmCable, SqlSettings);

            electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(true);

            // все центры питания
            var s1 = electricModel.Objects.Where(w => w.GetType().Equals(typeof(ElectricSubstation)));
            var schmObjCp = s1.Where(w => ((ElectricSubstation)w).TypeSubstation.Equals(eTypeRectangleTool.CP));

            TreeDataGridViewNode SubNodeTreeCP;
            TreeDataGridViewNode SubNodeTreeCell;
            TreeDataGridViewNode SubNodeTreeBus;
            foreach (var itemCP in schmObjCp)
            {
                listElectricObect.Clear();
                SubNodeTreeCP = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                    {
                                    // electricModel.GetParamsElectricObjectById(itemCP.Id).ElectricLineName
                                    itemCP.FullName
                                    });
                // Выдерним все ячейки центра питания
                var c1 = itemCP.ChildObjects.Where(w => w.GetType().Equals(typeof(ElectricLine)));
                var schmObjCells = c1.Where(w => ((ElectricLine)w).IsCell());
                // Выдерним все щины центра питания
                var c0 = itemCP.ChildObjects.Where(w => w.GetType().Equals(typeof(ElectricBus)));
                var schmObjBus = c0.OrderBy(c => c.ToString());
                foreach (var itemBus in schmObjBus)
                {
                    SubNodeTreeBus = this.AddTreeParametrSub(SubNodeTreeCP.Nodes, new object[]
                        {
                            itemBus.ToString()
                        });
                    // получим точки принадлежащие щине
                    var pointEnds = itemBus.ChildObjects.Where(w => w.GetType().Equals(typeof(ElectricPoint)));
                    // Выбрать ячейки, принадлжащие текущей щине
                    foreach (ElectricLine line in schmObjCells)
                    {
                        // если ячейка уже есть
                        if (!listElectricObect.Contains(line.Id))
                            // убрать бы еще межшинные ячейки (???)
                            foreach (ElectricPoint point in line.Ends)
                            {
                                if (pointEnds.Contains(point))
                                {
                                    listElectricObect.Add(line.Id);
                                    SubNodeTreeCell = this.AddTreeParametrSub(SubNodeTreeBus.Nodes, new object[]
                                        {
                                            line.ToString()
                                        });
                                    TreeNodeObj treeNodeObj_ = electricModel.PoweringReportForDrawObject(Convert.ToInt32(line.Id), true);
                                    this.FillTableSubOff(SubNodeTreeCell, treeNodeObj_, true);
                                    //this.FillTableSubOff(SubNodeTreeCell, treeNodeObj_, "", null, true);
                                    break;
                                }
                            }
                    }
                }
            }
        }
        /// <summary>
        /// Заполнить дерево (dgvTree) подстанциями попавшими под отключение
        /// ver. 1
        /// </summary>
        private void FillTableSubOff(TreeDataGridViewNode SubNodeTree, TreeNodeObj RootNodeObj)
        {
            if (RootNodeObj.Tag != null)
            {
                if (RootNodeObj.Tag is ElectricBus)
                {
                    if (this.listElectricObect.Contains(((ElectricBus)RootNodeObj.Tag).Id))
                    {
                        return;
                    }
                    this.listElectricObect.Add(((ElectricBus)RootNodeObj.Tag).Id);
                }
                if (RootNodeObj.Tag is ElectricLine)
                {
                    ElectricLine electricLine = (ElectricLine)RootNodeObj.Tag;
                    if (electricLine.IsCell())
                    {
                        ElectricBus electricBus = null;
                        foreach (ElectricPoint electricPoint in electricLine.Ends)
                        {
                            if (electricPoint.Parent is ElectricBus)
                            {
                                electricBus = (ElectricBus)electricPoint.Parent;
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_10 || electricBus.TypeBus == eTypeShinaTool.Shina_110 || electricBus.TypeBus == eTypeShinaTool.Shina_35)
                                {
                                    break;
                                }
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_6)
                                {
                                    break;
                                }
                                electricBus = null;
                            }
                        }
                        if (electricBus != null)
                        {
                                if (SubNodeTree == null)
                                {
                                    SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                    {
                                        electricBus.Parent.ToString(),
                                        electricBus.Parent.Id,
                                        electricBus.ToString(),
                                        electricBus.Id,
                                        electricLine.ToString(),
                                        electricLine.Id
                                            });
                                }
                                else
                                {
                                    SubNodeTree = this.AddTreeParametrSub(SubNodeTree.Nodes, new object[]
                                    {
                                        electricBus.Parent.ToString(),
                                        electricBus.Parent.Id,
                                        electricBus.ToString(),
                                        electricBus.Id,
                                        electricLine.ToString(),
                                        electricLine.Id
                                    });
                                }
                        }
                    }
                   
                }
            }
            foreach (TreeNodeObj node in RootNodeObj.Nodes)
            {
                this.FillTableSubOff(SubNodeTree, node);
            }
        }
        /// <summary>
        /// Заполнить дерево (dgvTree) подстанциями и линиями попавшими под отключение
        /// ver. 2
        /// </summary>
        private void FillTableSubOff(TreeDataGridViewNode SubNodeTree, TreeNodeObj RootNodeObj, string VoltageLine = "", List<string> ListSub = null, bool SkipNode = false)
        {
            if (RootNodeObj.Tag != null)
            {
                // если SubNodeTree пустое, то это начало ветки
                if (SubNodeTree == null)
                {
                    if (RootNodeObj.Tag is ElectricBus) // шина
                    {
                        string electricBusName = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[] { ((ElectricBus)RootNodeObj.Tag).Id.ToString() }).ToString();


                        var electricSub = (ElectricSubstation)((ElectricObject)RootNodeObj.Tag).Parent;

                        string electricTypeSub = Reference.Tables.GetTypeSubstation(electricSub.TypeSubstation);

                        var qBeg = electricSub.ChildObjects.Where(r => r is ElectricBus);
                        var q1 = from r in qBeg
                                 select new
                                 {
                                     VoltageLineME = Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus),
                                     VoltageLine = Convert.ToDouble(Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                 };
                        VoltageLine = (from r in q1
                                       orderby r.VoltageLine descending
                                       select r).First().VoltageLineME;

                        electricBusName = electricTypeSub + " " + VoltageLine + " кВ " + electricBusName;

                        SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                         {
                            electricBusName,
                            ((ElectricBus)RootNodeObj.Tag).Id
                         });
                    }
                    else if (RootNodeObj.Tag is ElectricLine)
                    {
                        string electricBusName = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[] { ((ElectricLine)RootNodeObj.Tag).Id.ToString() }).ToString();

                        var electricSub = (ElectricSubstation)((ElectricObject)RootNodeObj.Tag).Parent;

                        string electricTypeSub = Reference.Tables.GetTypeSubstation(electricSub.TypeSubstation);

                        var qBeg = electricSub.ChildObjects.Where(r => r is ElectricBus);
                        var q1 = from r in qBeg
                                 select new
                                 {
                                     VoltageLineME = Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus),
                                     VoltageLine = Convert.ToDouble(Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                 };
                        VoltageLine = (from r in q1
                                       orderby r.VoltageLine descending
                                       select r).First().VoltageLineME;

                        electricBusName = electricTypeSub + " " + VoltageLine + " кВ " + electricBusName;

                        SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                        {
                            electricBusName,
                            ((ElectricLine)RootNodeObj.Tag).Id
                        });
                    }
                    else if (RootNodeObj.Tag is ElectricSubstation)
                    {
                        string electricBusName = ((ElectricSubstation)RootNodeObj.Tag).ToString();
                        var electricSub = (ElectricSubstation)((ElectricObject)RootNodeObj.Tag);


                        string electricTypeSub = Reference.Tables.GetTypeSubstation(electricSub.TypeSubstation);
                        var qBeg = electricSub.ChildObjects.Where(r => r is ElectricBus);
                        var q1 = from r in qBeg
                                 select new
                                 {
                                     VoltageLineME = Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus),
                                     VoltageLine = Convert.ToDouble(Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                 };
                        VoltageLine = (from r in q1
                                       orderby r.VoltageLine descending
                                       select r).First().VoltageLineME;
                        electricBusName = electricTypeSub + " " + VoltageLine + " кВ " + electricBusName;
                        SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                        {
                         electricBusName,
                         ((ElectricSubstation)RootNodeObj.Tag).Id
                        });
                    }
                }

                // проверка наличия объекта (шины) в выводимом дереве
                if (RootNodeObj.Tag is ElectricBus)
                {
                    if (this.listElectricObect.Contains(((ElectricBus)RootNodeObj.Tag).Id))
                    {
                        return;
                    }
                    this.listElectricObect.Add(((ElectricBus)RootNodeObj.Tag).Id);

                }
                if (RootNodeObj.Tag is ElectricLine)
                {
                    ElectricLine electricLine = (ElectricLine)RootNodeObj.Tag;
                    if (electricLine.IsCell()) // если ячейка
                    {
                        // ищем щину 
                        ElectricBus electricBus = null;
                        foreach (ElectricPoint electricPoint in electricLine.Ends)
                        {
                            if (electricPoint.Parent is ElectricBus)
                            {
                                electricBus = (ElectricBus)electricPoint.Parent;
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_10 || electricBus.TypeBus == eTypeShinaTool.Shina_110 || electricBus.TypeBus == eTypeShinaTool.Shina_35)
                                {
                                    break;
                                }
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_6)
                                {
                                    break;
                                }
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_04 || electricBus.TypeBus == eTypeShinaTool.Shina_023)
                                {
                                    break;
                                }
                                electricBus = null;
                            }
                        }
                        if (electricBus != null)
                        {

                            VoltageLine = Reference.Tables.GetVoltageObject(electricBus.TypeBus);
                            //string electricBusName = ReferenceTables.CreateReferenceTables.GetTypeSubstation(((ElectricSubstation)((ElectricObject)RootNodeObj.Tag).Parent).TypeSubstation) + " " + VoltageLine + " кВ " + electricBus.Parent.ToString();
                            // подстанция, которой принадлежит ячейка
                            // string electricSubName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)electricBus.Parent).TypeSubstation) + " " + VoltageLine + " кВ " + electricBus.Parent.ToString();

                            var ElectricObject = electricModel.GetParamsElectricObjectById(electricLine.Id, true, true);
                            string electricSubName = ElectricObject.ElectricSubName;

                            // пропуск узла
                            if (!SkipNode)
                            {
                                // если не высокая сторона
                                if (electricBus.TypeBus != eTypeShinaTool.Shina_04 && electricBus.TypeBus != eTypeShinaTool.Shina_023)
                                {
                                    // если SubNodeTree пустое, то это начало ветки
                                    // при SkipNode = false - пропуск блока
                                    if (SubNodeTree == null)
                                    {
                                        SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                        {
                                            //electricBus.Parent.ToString(),
                                            electricSubName,
                                            electricBus.Parent.Id,
                                            electricBus.ToString(),
                                            electricBus.Id,
                                            electricLine.ToString(),
                                            electricLine.Id
                                        });
                                    }
                                    else
                                    {
                                        SubNodeTree = this.AddTreeParametrSub(SubNodeTree.Nodes, new object[]
                                        {
                                            //electricBus.Parent.ToString(), // подстанция
                                            electricSubName,
                                            electricBus.Parent.Id,
                                            electricBus.ToString(), // шина
                                            electricBus.Id,
                                            electricLine.ToString(), // ячейка
                                            electricLine.Id
                                        });
                                    }
                                }
                                else
                                {
                                    //if (ListSub != null || ListSub.Count > 0 ) ListSub.Clear();
                                    ListSub = new List<string>();
                                    ListSub.Add(electricBus.Parent.ToString()); // подстанция
                                    ListSub.Add(electricBus.Parent.Id.ToString());
                                    ListSub.Add(electricBus.ToString()); // шина
                                    ListSub.Add(electricBus.Id.ToString());
                                    ListSub.Add(electricLine.ToString()); // ячейка
                                    ListSub.Add(electricLine.Id.ToString());
                                }
                            }
                        }
                    }
                    else // если не ячейка а кабель
                         // сформируем имя линии, для этого
                         // надо найти тип линии и напряжение линии
                         // можно через шину, но это двигаться вверх долго   
                    {
                        DataRow[] row = dtSchmCable.Select("id = " + electricLine.Id);
                        string electricLineName = "";
                        if (row.Count() > 0)
                            electricLineName = row.First()["TypeCable"] + " " + VoltageLine.Replace(",", ".") + " кВ ";
                        else
                            electricLineName = "КЛ 0.38 кВ ";

                        // если в названии линии нет имени подстанции, то надо ее добавить
                        if (ListSub != null && electricLine.ToString().IndexOf(ListSub[0]) < 0)
                        {
                            electricLineName = electricLineName + ListSub[0] + @"\";
                            ////////var rrr = electricModel.GetFirstSubstation(electricLine.Id);
                            //////TreeNodeObj treeNodeObj = electricModel.PoweringReportForDrawObject(electricLine.Id, false);
                            //////if (treeNodeObj != null)
                            //////{
                            //////    foreach (TreeNodeObj node in treeNodeObj.LeafsList)
                            //////    {
                            //////        // надо найти шину
                            //////        if (node.Tag != null && node.Tag is ElectricBus)
                            //////        {
                            //////            ElectricBus electricBus = (ElectricBus)node.Tag;
                            //////            if (electricBus.Parent != null && electricBus.Parent != null && electricBus.Parent is ElectricSubstation)
                            //////            {
                            //////                var iii = electricBus.Parent;
                            //////                break;
                            //////            }
                            //////        }
                            //////    }
                            //////}
                        }
                        electricLineName = electricLineName + electricLine.ToString();






                        if (SubNodeTree == null)
                        {
                            if (ListSub != null)
                                SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                {
                                        electricLineName, electricLine.Id, ListSub[2], ListSub[3], ListSub[4], ListSub[5]
                                });
                            else
                                SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                {
                                         electricLineName, electricLine.Id
                                });
                        }
                        else
                        {
                            if (ListSub != null)
                                SubNodeTree = this.AddTreeParametrSub(SubNodeTree.Nodes, new object[]
                                        {
                                        electricLineName, electricLine.Id, ListSub[2], ListSub[3], ListSub[4], ListSub[5]
                                       });
                            else
                                SubNodeTree = this.AddTreeParametrSub(SubNodeTree.Nodes, new object[]
                                            {
                                        electricLineName, electricLine.Id
                                            });
                                    }
                    }
                  
                }
                else if (RootNodeObj.Tag is ElectricBus)
                {
                    VoltageLine = Reference.Tables.GetVoltageObject(((ElectricBus)RootNodeObj.Tag).TypeBus);
                }
            }
            foreach (TreeNodeObj node in RootNodeObj.Nodes)
            {
                this.FillTableSubOff(SubNodeTree, node, VoltageLine, ListSub);
            }
        }
        /// <summary>
        /// Заполнить дерево (dgvTree) подстанциями попавшими под отключение
        /// ver. 3
        /// </summary>
        private void FillTableSubOff(TreeDataGridViewNode SubNodeTree, TreeNodeObj RootNodeObj, bool SkipNode = false)
        {
            if (RootNodeObj.Tag != null)
            {
                if (RootNodeObj.Tag is ElectricBus)
                {
                    if (this.listElectricObect.Contains(((ElectricBus)RootNodeObj.Tag).Id))
                    {
                        return;
                    }
                    this.listElectricObect.Add(((ElectricBus)RootNodeObj.Tag).Id);
                }
                if (RootNodeObj.Tag is ElectricLine)
                {
                    ElectricLine electricLine = (ElectricLine)RootNodeObj.Tag;
                    if (electricLine.IsCell())
                    {
                        ElectricBus electricBus = null;
                        foreach (ElectricPoint electricPoint in electricLine.Ends)
                        {
                            if (electricPoint.Parent is ElectricBus)
                            {
                                electricBus = (ElectricBus)electricPoint.Parent;
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_10 || electricBus.TypeBus == eTypeShinaTool.Shina_110 || electricBus.TypeBus == eTypeShinaTool.Shina_35)
                                {
                                    break;
                                }
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_6)
                                {
                                    break;
                                }
                                electricBus = null;
                            }
                        }
                        if (electricBus != null)
                        {
                            // пропуск узла
                            if (!SkipNode)
                            {
                                if (SubNodeTree == null)
                                {
                                    SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                    {
                                        electricBus.Parent.ToString(),
                                        electricBus.Parent.Id,
                                        electricBus.ToString(),
                                        electricBus.Id,
                                        electricLine.ToString(),
                                        electricLine.Id
                                    });
                                }
                                else
                                {
                                    SubNodeTree = this.AddTreeParametrSub(SubNodeTree.Nodes, new object[]
                                    {
                                        electricBus.Parent.ToString(),
                                        electricBus.Parent.Id,
                                        electricBus.ToString(),
                                        electricBus.Id,
                                        electricLine.ToString(),
                                        electricLine.Id
                                    });
                                }
                            }
                        }
                    }

                }
            }
            foreach (TreeNodeObj node in RootNodeObj.Nodes)
            {
                this.FillTableSubOff(SubNodeTree, node, false);
            }
        }
    }
}
