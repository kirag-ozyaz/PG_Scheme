using Documents.DataSets;
using Documents.Properties;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Documents.Forms.Measurement
{
    internal class FormAmountFreeCapacity : FormBase
    {
        private BackgroundWorker bwLoadData;
        private Button btnCreateReport;
        private CheckBox chbIsNullIsr;
        private DataSetMeasurementN dsMeasurementN;
        //private DataSetMeasurementN dsMeasurementN;
        private Sort sort;
        private IContainer components = null;
        private ReportViewer rpGeneral;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolStrip tsTree;
        private ToolStripButton tsbShowDeletedObject;
        private ToolStripButton tsbFindObj;
        private ToolStripButton tsbFindNextObj;
        private ToolStripButton tsbSortTree;
        private ToolStripButton tsbRefreshAll;
        private ToolStripProgressBar tspbStatus;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripStatusLabel tsslStatus;
        private ToolStripTextBox tstbFindObj;
        private TreeView trvSchmObj;

        internal FormAmountFreeCapacity()
        {
            this.InitializeComponent();
        }

        private void bwLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_PowerISR_SSTransf, true, "");
        }

        private void bwLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.LoadState(false);
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            IEnumerable<DataSetMeasurementN.vJ_PowerISR_SSTransfRow> enumerable;
            //Class183 class2 = new Class183
            //{
            //    form31_0 = this
            //};
            this.rpGeneral.Clear();
            this.rpGeneral.ShowProgress = true;

            List<int> arrayId = new List<int>();
            arrayId = this.AddCheckedIdInList(this.trvSchmObj.Nodes, arrayId);

            if (!this.chbIsNullIsr.Checked)
            {
                enumerable = this.dsMeasurementN.vJ_PowerISR_SSTransf
                    .Where(r => r["Isr"] != DBNull.Value)
                    .Select(r => r);
            }
            else
            {
                enumerable = this.dsMeasurementN.vJ_PowerISR_SSTransf
                    .Select(r => r);
            }
            // так делают нормальные люди
            /*
            var rowCounts = from row in enumerable
                            where arrayId.Contains(row.idSub)
                        group row by row.idSub into grp
                        select new
                        {
                            idSubstation = grp.Key,
                            countTransf = grp.Count()
                        };
            var rowCounts3 = from row in enumerable
                             where arrayId.Contains(row.idSub)
                             orderby row.NameSub, row["NameTransf"]
                             select new
                             {
                                 nameSubstation = row.NameSub,
                                 nameTransf = ((row["NameTransf"] != DBNull.Value) ? row.NameTransf : ""),
                                 amountFreeCapasity = this.GetAmountFreeCapasity(row["Power"], (from r in rowCounts
                                                                                                where r.idSubstation == row.idSub
                                                                                                select r.countTransf).First<int>(), row["Isr"])
                             };
             */
            var rowCounts = enumerable
                .Where(r => arrayId.Contains(r.idSub))
                .GroupBy(r => new { r.idSub })
                .Select(grp => new { idSubstation = grp.Key.idSub, countTransf = grp.Count() });
            this.dsMeasurementN.dtAmountFreeCapasity.Rows.Clear();

            var rowCounts3 = enumerable
                .Where(r => arrayId.Contains(r.idSub))
                .OrderBy(r => r.NameSub)
                .ThenBy(r => r["NameTransf"])
               // .Select((class2.method_2));
               .Select(row => new
               {
                   nameSubstation = row.NameSub,
                   nameTransf = row["NameTransf"] != DBNull.Value ? row.NameTransf : "",
                   amountFreeCapasity = GetAmountFreeCapasity
                   (row["Power"], rowCounts
                   //.Where(r => r.idSubstation.Equals(row.idSub))
                   .Where(r => r.idSubstation == (row.idSub))
                   .Select(r => new { r.countTransf })
                   .First(), row["Isr"])
               }
                    );

            foreach (var current in rowCounts3)
            {
                this.dsMeasurementN.dtAmountFreeCapasity.AdddtAmountFreeCapasityRow(current.nameSubstation, current.nameTransf, current.amountFreeCapasity);
            }
            BindingSource dataSourceValue = new BindingSource
            {
                DataSource = this.dsMeasurementN.dtAmountFreeCapasity
            };
            this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsAmount", dataSourceValue));
            this.rpGeneral.RefreshReport();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormAmountFreeCapacity_Load(object sender, EventArgs e)
        {
            this.LoadState(true);
            this.bwLoadData.RunWorkerAsync();
            this.RefreshTree(this.sort);
            this.rpGeneral.RefreshReport();
        }

        private void FormAmountFreeCapacity_Shown(object sender, EventArgs e)
        {
        }

        private void LoadState(bool isLoading)
        {
            this.tspbStatus.Style = isLoading ? ProgressBarStyle.Continuous : ProgressBarStyle.Blocks;
            this.tsslStatus.Text = isLoading ? "Выполняется загрузка данных..." : "";
            this.btnCreateReport.Enabled = !isLoading;
        }

        private void RefreshTree(Sort sort)
        {
            string str = (sort == Sort.Asc) ? " ASC" : " DESC";
            this.trvSchmObj.BeginUpdate();
            this.trvSchmObj.Nodes.Clear();
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.tR_Classifier, true, "WHERE ParentKey = ';SCM;PS;' AND Value in (2,4) AND id NOT IN (SELECT p.idObjList FROM tP_Passport AS p INNER JOIN tP_ObjectChar AS oc ON p.id = oc.idPassport AND oc.Deleted = 0 AND oc.idObjChar = 174 AND Value = 293 WHERE p.isActive = 1 AND p.Deleted = 0) ORDER BY Name" + str);
            base.SelectSqlDataTableOther(this.dsMeasurementN, this.dsMeasurementN.tSchm_ObjList1, "tSchm_ObjList", true, "WHERE TypeCodeId IN (" + string.Join(",", this.dsMeasurementN.tR_Classifier
                //.Select<DataSetGES.Class50, string>((C_1.C_9__5_0 ?? (C_1.C_9__5_0 = new Func<DataSetGES.Class50, string>(C_1.C_9.method_0))))
                .Select(r => r.Id.ToString())
                .ToArray()) + ") AND Deleted = ((0)) ORDER BY Name" + str);
            TreeNode node = new TreeNode("Все");
            //////////foreach (var item in this.dsMeasurementN.tR_Classifier)
            //////////{
            //////////    TreeNode node2 = new TreeNode(item.Name);
            //////////    var enumerableRowCollection = from row in this.dsMeasurementN.tSchm_ObjList1
            //////////                                                                                    where row.TypeCodeId == item.Id
            //////////                                                                                    select row;
            //////////    foreach (var current in enumerableRowCollection)
            //////////    {
            //////////        TreeNode node3 = new TreeNode(current.Name);
            //////////        node3.Tag = current.Id;
            //////////        node2.Nodes.Add(node3);
            //////////    }
            //////////    node.Nodes.Add(node2);
            //////////}
            // var -- IEnumerator<DataSetMeasurementN.tR_ClassifierRow>
            using (var enumerator = this.dsMeasurementN.tR_Classifier.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    //Class179 class2 = new Class179
                    //{
                    //    class50_0 = enumerator.Current
                    //};
                    //TreeNode node2 = new TreeNode(class2.class50_0.Name);
                    //foreach (DataSetGES.Class99 row in this.dsMeasurementN.tSchm_ObjList1
                    //.Where<DataSetGES.Class99>(new Func<DataSetGES.Class99, bool>(class2.method_0)))
                    TreeNode node2 = new TreeNode(enumerator.Current.Name);
                    foreach (var row in this.dsMeasurementN.tSchm_ObjList1
                    .Where(row => row.TypeCodeId == enumerator.Current.Id))
                    {
                        TreeNode node3 = new TreeNode(row.Name)
                        {
                            Tag = row.Id
                        };
                        node2.Nodes.Add(node3);
                    }
                    node.Nodes.Add(node2);
                }
            }
            this.trvSchmObj.Nodes.Add(node);
            this.trvSchmObj.EndUpdate();
        }

        private void RefreshSortTree()
        {
            this.tsbSortTree.Image = (this.sort == Sort.Asc) ? Resources.sortZA : Resources.sortAZ;
            this.sort = (this.sort == Sort.Asc) ? Sort.Desc : Sort.Asc;
            this.RefreshExpandedCheckedTree();
        }

        private void RefreshExpandedCheckedTree()
        {
            //Class180 class2 = new Class180
            //{
            //    treeNode_0 = this.trvSchmObj.TopNode
            //};
            TreeNode treeNode_0 = this.trvSchmObj.TopNode;

            List<TreeNode> list1 = new List<TreeNode>();
            this.AddExpandedNodeInList(this.trvSchmObj.Nodes, list1);

            List<TreeNode> list2 = new List<TreeNode>();
            this.AddCheckedNodeInList(this.trvSchmObj.Nodes, list2);

            this.RefreshTree(this.sort);

            /*class2.*/
            // новый список
            List<TreeNode> list_0 = new List<TreeNode>();
            this.AddNodeInList(this.trvSchmObj.Nodes, list_0);

            list1.ForEach(new Action<TreeNode>(oldChecked => list_0
                    .Where(t => (t.Text == oldChecked.Text) || ((t.Tag == oldChecked.Tag) && (t.Text == oldChecked.Text)))
                    .ToList()
                    .ForEach(t => t.Expand())));
            //list1.ForEach(oldChecked =>//delegate (TreeNode oldChecked)
            //{
            //    (from n in list_0
            //     where n.Text == oldChecked.Text || (n.Tag == oldChecked.Tag && n.Text == oldChecked.Text)
            //     select n).ToList<TreeNode>().ForEach(node =>//delegate (TreeNode node)
            //     {
            //         node.Expand();
            //     });
            //});

            list2.ForEach(new Action<TreeNode>(treeNode => list_0
                    .Where(t => (t.Text == treeNode.Text) || ((t.Tag == treeNode.Tag) && (t.Text == treeNode.Text)))
                    .ToList()
                    .ForEach(t => t.Checked = true)));
            //list2.ForEach(oldChecked =>//delegate (TreeNode oldChecked)
            //{
            //    (from n in list_0
            //     where n.Text == oldChecked.Text || (n.Tag == oldChecked.Tag && n.Text == oldChecked.Text)
            //     select n).ToList<TreeNode>().ForEach(node =>//delegate (TreeNode node)
            //     {
            //         node.Checked = true;
            //     });
            //});

            list_0
                .Where(trn => (trn.Text == treeNode_0.Text) || ((trn.Tag == treeNode_0.Tag) && (trn.Text == treeNode_0.Text)))
                .ToList()
                .ForEach(trn => trvSchmObj.TopNode = trn);
            //(from n in list_0
            // where n.Text == treeNode_0.Text || (n.Tag == treeNode_0.Tag && n.Text == treeNode_0.Text)
            // select n).ToList<TreeNode>().ForEach(node =>//delegate (TreeNode node)
            // {
            //     this.trvSchmObj.TopNode = node;
            // });
        }

        private List<int> AddCheckedIdInList(TreeNodeCollection treeNodeCollection, List<int> listNode)
        {
            foreach (TreeNode node in treeNodeCollection)
            {
                if (node.Checked && (node.Tag is int))
                {
                    listNode.Add((int)node.Tag);
                }
                listNode = this.AddCheckedIdInList(node.Nodes, listNode);
            }
            return listNode;
        }

        private string GetAmountFreeCapasity(object power, object countBus, object Isr)
        {
            if (countBus == DBNull.Value)
            {
                return "";
            }
            if (power == DBNull.Value)
            {
                return "";
            }
            if (Isr == DBNull.Value)
            {
                return "";
            }
            double num = (Math.Sqrt(3.0) * 0.4) * ((int)Isr);
            double num2 = Math.Round((((((int)power) * ((((int)countBus) == 1) ? 0.95 : 0.7)) - num) * 0.89), 0);
            if (num2 >= 0.0)
            {
                return num2.ToString();
            }
            return "0";
        }

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tsTree = new System.Windows.Forms.ToolStrip();
            this.tsbShowDeletedObject = new System.Windows.Forms.ToolStripButton();
            this.tstbFindObj = new System.Windows.Forms.ToolStripTextBox();
            this.tsbFindObj = new System.Windows.Forms.ToolStripButton();
            this.tsbFindNextObj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSortTree = new System.Windows.Forms.ToolStripButton();
            this.tsbRefreshAll = new System.Windows.Forms.ToolStripButton();
            this.trvSchmObj = new System.Windows.Forms.TreeView();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.chbIsNullIsr = new System.Windows.Forms.CheckBox();
            this.rpGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsMeasurementN = new Documents.DataSets.DataSetMeasurementN();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bwLoadData = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tsTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurementN)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rpGeneral);
            this.splitContainer1.Size = new System.Drawing.Size(778, 534);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tsTree, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trvSchmObj, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateReport, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chbIsNullIsr, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tsTree
            // 
            this.tsTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbShowDeletedObject,
            this.tstbFindObj,
            this.tsbFindObj,
            this.tsbFindNextObj,
            this.toolStripSeparator10,
            this.tsbSortTree,
            this.tsbRefreshAll});
            this.tsTree.Location = new System.Drawing.Point(0, 0);
            this.tsTree.Name = "tsTree";
            this.tsTree.Size = new System.Drawing.Size(257, 25);
            this.tsTree.TabIndex = 3;
            this.tsTree.Text = "Панель инструментов дерева данных";
            // 
            // tsbShowDeletedObject
            // 
            this.tsbShowDeletedObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowDeletedObject.Image = global::Properties.Resources.ShowDeletedObject;
            this.tsbShowDeletedObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowDeletedObject.Name = "tsbShowDeletedObject";
            this.tsbShowDeletedObject.Size = new System.Drawing.Size(23, 22);
            this.tsbShowDeletedObject.Text = "Отобразить удаленные объекты";
            this.tsbShowDeletedObject.Visible = false;
            // 
            // tstbFindObj
            // 
            this.tstbFindObj.Name = "tstbFindObj";
            this.tstbFindObj.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbFindObj
            // 
            this.tsbFindObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFindObj.Image = global::Properties.Resources.FindObj;
            this.tsbFindObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFindObj.Name = "tsbFindObj";
            this.tsbFindObj.Size = new System.Drawing.Size(23, 22);
            this.tsbFindObj.Text = "Найти";
            this.tsbFindObj.Click += new System.EventHandler(this.tsbFindObj_Click);
            // 
            // tsbFindNextObj
            // 
            this.tsbFindNextObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFindNextObj.Image = global::Properties.Resources.FindNextObj;
            this.tsbFindNextObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFindNextObj.Name = "tsbFindNextObj";
            this.tsbFindNextObj.Size = new System.Drawing.Size(23, 22);
            this.tsbFindNextObj.Text = "Найти далее";
            this.tsbFindNextObj.Click += new System.EventHandler(this.tsbFindNextObj_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSortTree
            // 
            this.tsbSortTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSortTree.Image = global::Properties.Resources.sortAZ;
            this.tsbSortTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSortTree.Name = "tsbSortTree";
            this.tsbSortTree.Size = new System.Drawing.Size(23, 22);
            this.tsbSortTree.Text = "Сортировка";
            this.tsbSortTree.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbSortTree.Click += new System.EventHandler(this.tsbSortTree_Click);
            // 
            // tsbRefreshAll
            // 
            this.tsbRefreshAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefreshAll.Image = global::Properties.Resources.Refresh;
            this.tsbRefreshAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshAll.Name = "tsbRefreshAll";
            this.tsbRefreshAll.Size = new System.Drawing.Size(23, 22);
            this.tsbRefreshAll.Text = "Обновить";
            this.tsbRefreshAll.Click += new System.EventHandler(this.tsbRefreshAll_Click);
            // 
            // trvSchmObj
            // 
            this.trvSchmObj.CheckBoxes = true;
            this.trvSchmObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvSchmObj.Location = new System.Drawing.Point(3, 29);
            this.trvSchmObj.Name = "trvSchmObj";
            this.trvSchmObj.Size = new System.Drawing.Size(251, 448);
            this.trvSchmObj.TabIndex = 4;
            this.trvSchmObj.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvSchmObj_AfterCheck);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateReport.Location = new System.Drawing.Point(3, 505);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(251, 26);
            this.btnCreateReport.TabIndex = 5;
            this.btnCreateReport.Text = "Сформировать отчет";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // chbIsNullIsr
            // 
            this.chbIsNullIsr.AutoSize = true;
            this.chbIsNullIsr.Checked = true;
            this.chbIsNullIsr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsNullIsr.Location = new System.Drawing.Point(10, 483);
            this.chbIsNullIsr.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chbIsNullIsr.Name = "chbIsNullIsr";
            this.chbIsNullIsr.Size = new System.Drawing.Size(232, 16);
            this.chbIsNullIsr.TabIndex = 6;
            this.chbIsNullIsr.Text = "Включая пустые значения св. мощности";
            this.chbIsNullIsr.UseVisualStyleBackColor = true;
            // 
            // rpGeneral
            // 
            this.rpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpGeneral.LocalReport.ReportEmbeddedResource = "Documents.Forms.Measurement.ReportAmountFreeCapacity.rdlc";
            this.rpGeneral.Location = new System.Drawing.Point(0, 0);
            this.rpGeneral.Name = "rvGeneral";
            this.rpGeneral.Size = new System.Drawing.Size(517, 534);
            this.rpGeneral.TabIndex = 0;
            // 
            // dsMeasurementN
            // 
            this.dsMeasurementN.DataSetName = "DataSetGES";
            this.dsMeasurementN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbStatus,
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspbStatus
            // 
            this.tspbStatus.Name = "tspbStatus";
            this.tspbStatus.Size = new System.Drawing.Size(200, 16);
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(118, 17);
            this.tsslStatus.Text = "toolStripStatusLabel1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 540);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bwLoadData
            // 
            this.bwLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadData_DoWork);
            this.bwLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadData_RunWorkerCompleted);
            // 
            // FormAmountFreeCapacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormAmountFreeCapacity";
            this.Text = "Объем свободной мощности";
            this.Load += new System.EventHandler(this.FormAmountFreeCapacity_Load);
            this.Shown += new System.EventHandler(this.FormAmountFreeCapacity_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tsTree.ResumeLayout(false);
            this.tsTree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurementN)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        //private void method_15(TreeNode trn)
        //{
        //    this.trvSchmObj.TopNode = trn;
        //}

        private List<TreeNode> AddNodeInList(TreeNodeCollection treeNodeCollection, List<TreeNode> list)
        {
            foreach (TreeNode node in treeNodeCollection)
            {
                list.Add(node);
                list = this.AddNodeInList(node.Nodes, list);
            }
            return list;
        }

        private List<TreeNode> AddExpandedNodeInList(TreeNodeCollection treeNodeCollection, List<TreeNode> list)
        {
            foreach (TreeNode node in treeNodeCollection)
            {
                if (node.IsExpanded)
                {
                    list.Add(node);
                }
                list = this.AddExpandedNodeInList(node.Nodes, list);
            }
            return list;
        }

        private List<TreeNode> AddCheckedNodeInList(TreeNodeCollection treeNodeCollection, List<TreeNode> list)
        {
            foreach (TreeNode node in treeNodeCollection)
            {
                if (node.Checked)
                {
                    list.Add(node);
                }
                list = this.AddCheckedNodeInList(node.Nodes, list);
            }
            return list;
        }

        private TreeNode SearchNextNode(List<TreeNode> list, TreeNode treeNode, string str)
        {
            bool flag = false;
            foreach (TreeNode node in list)
            {
                if (flag && node.Name.ToUpper().Contains(str.ToUpper()))
                {
                    return node;
                }
                if (node == treeNode)
                {
                    flag = true;
                }
            }
            return null;
        }

        private TreeNode SearchNode(List<TreeNode> list, string str)
        {
            foreach (TreeNode node in list)
            {
                if (node.Name.ToUpper().Contains(str.ToUpper()))
                {
                    return node;
                }
            }
            return null;
        }

        private TreeNode SearchNode(List<TreeNode> list, int num)
        {
            foreach (TreeNode node in list)
            {
                if (((int)node.Tag) == num)
                {
                    return node;
                }
            }
            return null;
        }

        //private bool method_8(TreeNode treeNode_0)
        //{
        //    return (treeNode_0.Nodes[0].Text == "None");
        //}
        // не испоьзуем
        private void tstbFindObj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                List<TreeNode> list = new List<TreeNode>();
                list = this.AddNodeInList(this.trvSchmObj.Nodes, list);
                TreeNode node = this.SearchNode(list, this.tstbFindObj.Text);
                if (node != null)
                {
                    this.trvSchmObj.SelectedNode = node;
                    this.trvSchmObj.SelectedNode.Expand();
                }
            }
        }

        private void tsbFindObj_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.AddNodeInList(this.trvSchmObj.Nodes, list);
            TreeNode node = this.SearchNode(list, this.tstbFindObj.Text);
            if (node != null)
            {
                this.trvSchmObj.Focus();
                this.trvSchmObj.SelectedNode = node;
                this.trvSchmObj.SelectedNode.Expand();
            }
        }

        private void tsbFindNextObj_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.AddNodeInList(this.trvSchmObj.Nodes, list);
            TreeNode node = this.SearchNextNode(list, this.trvSchmObj.SelectedNode, this.tstbFindObj.Text);
            if (node != null)
            {
                this.trvSchmObj.Focus();
                this.trvSchmObj.SelectedNode = node;
                this.trvSchmObj.SelectedNode.Expand();
            }
        }

        private void tsbSortTree_Click(object sender, EventArgs e)
        {
            this.RefreshSortTree();
        }

        private void tsbRefreshAll_Click(object sender, EventArgs e)
        {
            this.LoadState(true);
            this.bwLoadData.RunWorkerAsync();
            this.RefreshExpandedCheckedTree();
        }

        private void trvSchmObj_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //using (IEnumerator enumerator = e.Node.Nodes.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        ((TreeNode)enumerator.Current).Checked = e.Node.Checked;
            //    }
            //}
            foreach (TreeNode treeNode in e.Node.Nodes)
            {
                treeNode.Checked = e.Node.Checked;
            }

        }

        //[Serializable, CompilerGenerated]
        //    private sealed class C_1
        //{
        //    public static readonly FormAmountFreeCapacity.C_1 C_9 = new FormAmountFreeCapacity.C_1();
        //    public static Action<TreeNode> C_9__18_2;
        //    public static Action<TreeNode> C_9__18_5;
        //    public static Func<DataSetGES.Class102, bool> C_9__21_0;
        //    public static Func<DataSetGES.Class102, DataSetGES.Class102> C_9__21_1;
        //    public static Func<Class15<int, int>, int> C_9__21_10;
        //    public static Func<DataSetGES.Class102, int> C_9__21_3;
        //    public static Func<IGrouping<int, DataSetGES.Class102>, Class15<int, int>> C_9__21_4;
        //    public static Func<DataSetGES.Class102, string> C_9__21_6;
        //    public static Func<DataSetGES.Class102, object> C_9__21_7;
        //    public static Func<DataSetGES.Class50, string> C_9__5_0;

        //    internal string method_0(DataSetGES.Class50 class50_0)
        //    {
        //        return class50_0.Id.ToString();
        //    }

        //    internal void method_1(TreeNode t)
        //    {
        //        t.Expand();
        //    }

        //    internal void method_2(TreeNode t)
        //    {
        //        t.Checked = true;
        //    }

        //    internal bool method_3(DataSetGES.Class102 r)
        //    {
        //        return (r["Isr"] != DBNull.Value);
        //    }

        //    internal DataSetGES.Class102 method_4(DataSetGES.Class102 r)
        //    {
        //        return r;
        //    }

        //    internal int method_5(DataSetGES.Class102 r)
        //    {
        //        return r.idSub;
        //    }

        //    internal Class15<int, int> method_6(IGrouping<int, DataSetGES.Class102> r)
        //    {
        //        return new Class15<int, int>(r.Key, r.Count<DataSetGES.Class102>());
        //    }

        //    internal string method_7(DataSetGES.Class102 r)
        //    {
        //        return r.NameSub;
        //    }

        //    internal object method_8(DataSetGES.Class102 r)
        //    {
        //        return r["NameTransf"];
        //    }

        //    internal int method_9(Class15<int, int> class15_0)
        //    {
        //        return class15_0.countTransf;
        //    }
        //}


        //private sealed class Class179
        //{
        //    public DataSetGES.Class50 class50_0;

        //    internal bool method_0(DataSetGES.Class99 r)
        //    {
        //        return (r.TypeCodeId == this.class50_0.Id);
        //    }
        //}


        //private sealed class Class180
        //{
        //    public List<TreeNode> list_0;
        //    public TreeNode treeNode_0;

        //    internal void method_0(TreeNode treeNode_1)
        //    {
        //        FormAmountFreeCapacity.Class181 class2 = new FormAmountFreeCapacity.Class181
        //        {
        //            treeNode_0 = treeNode_1
        //        };
        //        this.list_0
        //                .Where<TreeNode>(t=> (t.Text == class2.treeNode_0.Text) || ((t.Tag == class2.treeNode_0.Tag) && (t.Text == class2.treeNode_0.Text)))
        //                .ToList<TreeNode>()
        //                .ForEach(t=> t.Expand());
        //    }

        //    internal void method_1(TreeNode treeNode_1)
        //    {
        //        FormAmountFreeCapacity.Class182 class2 = new FormAmountFreeCapacity.Class182
        //        {
        //            treeNode_0 = treeNode_1
        //        };
        //            //this.list_0.Where<TreeNode>(new Func<TreeNode, bool>(class2.method_0)).ToList<TreeNode>().ForEach(FormAmountFreeCapacity.C_1.C_9__18_5 ?? (FormAmountFreeCapacity.C_1.C_9__18_5 = new Action<TreeNode>(FormAmountFreeCapacity.C_1.C_9.method_2)));
        //            this.list_0
        //                .Where<TreeNode>(t => (t.Text == class2.treeNode_0.Text) || ((t.Tag == class2.treeNode_0.Tag) && (t.Text == class2.treeNode_0.Text)))
        //                .ToList<TreeNode>()
        //                .ForEach(t => t.Checked = true);
        //        }

        //    internal bool method_2(TreeNode trn)
        //    {
        //        return ((trn.Text == this.treeNode_0.Text) || ((trn.Tag == this.treeNode_0.Tag) && (trn.Text == this.treeNode_0.Text)));
        //    }
        //}


        //private sealed class Class181
        //{
        //    public TreeNode treeNode_0;

        //    internal bool method_0(TreeNode t)
        //    {
        //        return ((t.Text == this.treeNode_0.Text) || ((t.Tag == this.treeNode_0.Tag) && (t.Text == this.treeNode_0.Text)));
        //    }
        //}


        //private sealed class Class182
        //{
        //    public TreeNode treeNode_0;

        //    internal bool method_0(TreeNode t)
        //    {
        //        return ((t.Text == this.treeNode_0.Text) || ((t.Tag == this.treeNode_0.Tag) && (t.Text == this.treeNode_0.Text)));
        //    }
        //}


        //private sealed class Class183
        //{
        //    public FormAmountFreeCapacity form31_0;
        //    public IEnumerable<Class15<int, int>> ienumerable_0;
        //    public List<int> arrayId;

        //    internal bool method_0(DataSetGES.Class102 r)
        //    {
        //        return this.arrayId.Contains(r.idSub);
        //    }

        //    internal bool method_1(DataSetGES.Class102 r)
        //    {
        //        return this.arrayId.Contains(r.idSub);
        //    }

        //    internal Class16<string, string, string> method_2(DataSetGES.Class102 row)
        //    {
        //            //FormAmountFreeCapacity.Class184 xlass184 = new FormAmountFreeCapacity.Class184
        //            //{
        //            //    class102_0 = row
        //            //};
        //            //return new Class16<string, string, string>(
        //            //    xlass184.class102_0.NameSub,
        //            //    (xlass184.class102_0["NameTransf"] != DBNull.Value) ? xlass184.class102_0.NameTransf : "",
        //            //    form31_0.GetAmountFreeCapasity(xlass184.class102_0["Power"], 

        //            //    this.ienumerable_0

        //            //    .Where(new Func<Class15<int, int>, bool>(xlass184.method_0))

        //            //    .Select((C_1.C_9__21_10 ?? (C_1.C_9__21_10 = new Func<Class15<int, int>, int>(C_1.C_9.method_9))))

        //            //    .First(), xlass184.class102_0["Isr"]));
        //            FormAmountFreeCapacity.Class184 xlass184 = new FormAmountFreeCapacity.Class184
        //            {
        //                class102_0 = row
        //            };
        //            return new Class16<string, string, string>(
        //                xlass184.class102_0.NameSub,
        //                (xlass184.class102_0["NameTransf"] != DBNull.Value) ? xlass184.class102_0.NameTransf : "",
        //                form31_0.GetAmountFreeCapasity(xlass184.class102_0["Power"],

        //                this.ienumerable_0

        //                .Where(r => r.idSubstation == xlass184.class102_0.idSub)

        //                .Select(r=> r.countTransf)

        //                .First(), xlass184.class102_0["Isr"]));
        //        }
    }


    //private sealed class Class184
    //{
    //    public DataSetGES.Class102 class102_0;

    //    internal bool method_0(Class15<int, int> r)
    //    {
    //        return (r.idSubstation == this.class102_0.idSub);
    //    }
    //}

    internal enum Sort
    {
        Asc, //0
        Desc //1
    }
}

