using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLbr;
using RequestForRepair.DataSets;
//using RequestsClient.DataSets;
//using RequestsClient.Properties;

namespace RequestForRepair
{
 
    /// <summary>
    /// Привязка заявок к схеме
    /// </summary>
    internal partial class FormLinkRequestAndSchm : FormBase
    {

        private Dictionary<int, string> LinkObjects = new Dictionary<int, string>();


        internal Dictionary<int, string> GetLinkObjects()
        {
            return this.LinkObjects;
        }
        internal void set_LinkObjects(Dictionary<int, string> link)
        {
            this.LinkObjects = link;
        }
        //public Dictionary<int, string> LinkObjects
        //{
        //    get
        //    {
        //        return this.dictionary_0;
        //    }
        //    set
        //    {
        //        this.dictionary_0 = value;
        //    }
        //}
        private short Num;
        internal short get_Num()
        {
            return this.Num;
        }

        internal void set_Num(short num)
        {
            this.Num = num;
        }
        //public short Num
        //{
        //    get
        //    {
        //        return this.short_0;
        //    }
        //    set
        //    {
        //        this.short_0 = value;
        //    }
        //}

        internal DateTime get_DateBeg()
        {
            return this.dateTimePickerDateBeg.Value;
        }

        internal void set_DateBeg(DateTime dateTime)
        {
            this.dateTimePickerDateBeg.Value = dateTime;
        }

        //public DateTime DateBeg
        //{
        //    get
        //    {
        //        return this.dateTimePickerDateBeg.Value;
        //    }
        //    set
        //    {
        //        this.dateTimePickerDateBeg.Value = value;
        //    }
        //}

        internal DateTime get_DateEnd()
        {
            return this.dateTimePickerDateEnd.Value;
        }

        internal void set_DateEnd(DateTime dateTime)
        {
            this.dateTimePickerDateEnd.Value = dateTime;
        }
        //public DateTime DateEnd
        //{
        //    get
        //    {
        //        return this.dateTimePickerDateEnd.Value;
        //    }
        //    set
        //    {
        //        this.dateTimePickerDateEnd.Value = value;
        //    }
        //}

        internal string Duration
        {
            get
            {
                return this.textBoxDuration.Text;
            }
            set
            {
                this.textBoxDuration.Text = value;
            }
        }

        internal FormLinkRequestAndSchm()
        {
            this.InitializeComponent();
        }

        private void FormLinkRequestAndSchm_Load(object sender, EventArgs e)
        {
            this.Load_SubStation();
            this.listBoxObjects.Items.Clear();
            foreach (int current in this.LinkObjects.Keys)
            {
                this.listBoxObjects.Items.Add(new FormLinkRequestAndSchm.Struct0(current, this.LinkObjects[current]));
            }
        }
        /// <summary>
        /// Формирование списка подстанций
        /// </summary>
        private void Load_SubStation()
        {
            DataSetN dataSetGES = new DataSetN();
            base.SelectSqlData(dataSetGES, dataSetGES.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
            this.treeViewSubstation.BeginUpdate();
            foreach (DataRow dataRow in dataSetGES.tR_Classifier.Rows)
            {
                TreeNode treeNode = this.treeViewSubstation.Nodes.Add(dataRow["SocrName"].ToString());
                treeNode.Tag = dataRow["id"];
                base.SelectSqlData(dataSetGES, dataSetGES.vSchm_ObjList, true, " where typeCodeId = " + dataRow["id"].ToString() + " and deleted = 0 order by name");
                foreach (DataRow current in dataSetGES.vSchm_ObjList)
                {
                    TreeNode node = treeNode.Nodes.Add(current["typeCodeSocr"].ToString() + "-" + current["Name"].ToString());
                    node.Tag = current["id"];
                    node.Nodes.Add("");
                }
            }
            this.treeViewSubstation.EndUpdate();
        }

        private void treeViewSubstation_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeViewSubstation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0 && e.Node.Level > 0)
            {
                e.Node.Nodes.Clear();
                DataSetN dataSetGES;
                switch (e.Node.Level)
                {
                    case 1:
                        {
                            dataSetGES = new DataSetN();
                            base.SelectSqlData(dataSetGES, dataSetGES.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
                            string text = "";
                            foreach (DataRow row1 in dataSetGES.tR_Classifier.Rows)
                            {
                                text = text + row1["id"].ToString() + ",";
                            }
                            text = text.Remove(text.Length - 1);
                            base.SelectSqlData(dataSetGES, dataSetGES.vSchm_ObjList, true, string.Concat(new string[]
                            {                    " where idParent = ",                    e.Node.Tag.ToString(),                    " and typecodeId in (",                    text,                    ") and deleted = 0"                            }));
                            foreach (DataRow row2 in dataSetGES.vSchm_ObjList)
                            {
                                TreeNode node1 = e.Node.Nodes.Add(row2["TypeCodeSocr"].ToString() + " - " + row2["Name"].ToString());
                                node1.Tag = row2["id"];
                                node1.Nodes.Add("");
                            }
                            return;
                            //using (IEnumerator<DataSetGES.Class10> enumerator2 = dataSetGES.vSchm_ObjList.GetEnumerator())
                            //{
                            //    while (enumerator2.MoveNext())
                            //    {
                            //        DataRow current = enumerator2.Current;
                            //        TreeNode node = e.Node.Nodes.Add(current["TypeCodeSocr"].ToString() + " - " + current["Name"].ToString());
                            //        node.Tag = current["id"];
                            //        node.Nodes.Add("");
                            //    }
                            //    return;
                            //}
                            //break;
                        }
                    case 2:
                        dataSetGES = new DataSetN();
                        base.SelectSqlData(dataSetGES, dataSetGES.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                        foreach (DataRow row3 in dataSetGES.vSchm_TreeCellLine)
                        {
                            TreeNode node2 = e.Node.Nodes.Add(row3["FullName"].ToString());
                            node2.Tag = row3["id"];
                            node2.Nodes.Add("");
                        }
                        //using (IEnumerator<DataSetGES.Class11> enumerator3 = dataSetGES.vSchm_TreeCellLine.GetEnumerator())
                        //{
                        //    while (enumerator3.MoveNext())
                        //    {
                        //        DataRow current2 = enumerator3.Current;
                        //        TreeNode node = e.Node.Nodes.Add(current2["FullName"].ToString());
                        //        node.Tag = current2["id"];
                        //        node.Nodes.Add("");
                        //    }
                        //}
                        return;
                    case 3:
                        dataSetGES = new DataSetN();
                        base.SelectSqlData(dataSetGES, dataSetGES.tSchm_Relation, true, " where Edge = " + e.Node.Tag.ToString());
                        if (dataSetGES.tSchm_Relation.Rows.Count > 0)
                        {
                            string text = "";
                            foreach (DataRow row3 in dataSetGES.tSchm_Relation)
                            {
                                text = text + row3["id"].ToString() + ",";
                            }
                            text = text.Remove(text.Length - 1);
                            base.SelectSqlData(dataSetGES, dataSetGES.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
                            foreach (DataRow row4 in dataSetGES.vSchm_ObjList)
                            {
                                e.Node.Nodes.Add(row4["TypeCodeSocr"].ToString() + " - " + row4["Name"].ToString()).Tag = row4["id"];
                            }
                        }
                        dataSetGES = new DataSetN();
                        base.SelectSqlData(dataSetGES, dataSetGES.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                        foreach (DataRow row5 in dataSetGES.vSchm_TreeCellLine)
                        {
                            e.Node.Nodes.Add(row5["FullName"].ToString()).Tag = row5["id"];
                        }
                        return;
                    default:
                        return;
                }

            }
        }

        private void Load_Schm_TreeCellLine(TreeNode node)
        {
            DataSetN dataSetGES = new DataSetN();
            base.SelectSqlData(dataSetGES, dataSetGES.vSchm_TreeCellLine, true, " where ParentLink = " + node.Tag.ToString());
            foreach (DataRow current in dataSetGES.vSchm_TreeCellLine)
            {
                TreeNode treeNode = node.Nodes.Add(current["FullName"].ToString());
                treeNode.Tag = current["id"];
                this.Load_Schm_Relation(treeNode);
                this.Load_Schm_TreeCellLine_1(treeNode);
            }
        }

        private void Load_Schm_Relation(TreeNode treeNode)
        {
            //DataSetGES order = new DataSetGES();
            DataSetN order = new DataSetN();
            base.SelectSqlData(order, order.tSchm_Relation, true, " where Edge = " + treeNode.Tag.ToString());
            if (order.tSchm_Relation.Rows.Count > 0)
            {
                string text = "";
                foreach (DataRow current in order.tSchm_Relation)
                {
                    text = text + current["id"].ToString() + ",";
                }
                text = text.Remove(text.Length - 1);
                base.SelectSqlData(order, order.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
                foreach (DataRow current2 in order.vSchm_ObjList)
                {
                    treeNode.Nodes.Add(current2["TypeCodeSocr"].ToString() + " - " + current2["Name"].ToString()).Tag = current2["id"];
                }
            }
        }

        private void Load_Schm_TreeCellLine_1(TreeNode treeNode)
        {
            //DataSetGES dataSetGES = new DataSetGES();
            DataSetN order = new DataSetN();
            base.SelectSqlData(order, order.vSchm_TreeCellLine, true, " where ParentLink = " + treeNode.Tag.ToString());
            foreach (DataRow current in order.vSchm_TreeCellLine)
            {
                treeNode.Nodes.Add(current["FullName"].ToString()).Tag = current["id"];
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (TreeNode treeNode_ in this.treeViewSubstation.Nodes)
            {
                this.method_12(treeNode_, list);
            }
            foreach (int current in list)
            {
                if (!this.LinkObjects.ContainsKey(current))
                {
                    this.LinkObjects.Add(current, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                    current.ToString()
                    }).ToString());
                }
            }
            this.listBoxObjects.Items.Clear();
            foreach (int current2 in this.LinkObjects.Keys)
            {
                this.listBoxObjects.Items.Add(new FormLinkRequestAndSchm.Struct0(current2, this.LinkObjects[current2]));
            }
        }

        private void method_12(TreeNode treeNode, List<int> list)
        {
            if (treeNode.Checked && treeNode.Tag != null && treeNode.Level > 0)
            {
                list.Add(Convert.ToInt32(treeNode.Tag));
            }
            foreach (TreeNode treeNode_ in treeNode.Nodes)
            {
                this.method_12(treeNode_, list);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            foreach (object current in this.listBoxObjects.SelectedItems)
            {
                this.LinkObjects.Remove(((FormLinkRequestAndSchm.Struct0)current).p0);
            }
            this.listBoxObjects.Items.Clear();
            foreach (int current2 in this.LinkObjects.Keys)
            {
                this.listBoxObjects.Items.Add(new FormLinkRequestAndSchm.Struct0(current2, this.LinkObjects[current2]));
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void tooBtnFind_Click(object sender, EventArgs e)
        {
            List<TreeNode> list_ = new List<TreeNode>();
            list_ = this.method_13(this.treeViewSubstation.Nodes, list_);
            TreeNode treeNode = this.method_14(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, FormLinkRequestAndSchm.eFind.First);
            if (treeNode != null)
            {
                this.treeViewSubstation.SelectedNode = treeNode;
                this.treeViewSubstation.SelectedNode.Expand();
            }
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            List<TreeNode> list_ = new List<TreeNode>();
            list_ = this.method_13(this.treeViewSubstation.Nodes, list_);
            TreeNode treeNode = this.method_14(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, FormLinkRequestAndSchm.eFind.Next);
            if (treeNode != null)
            {
                this.treeViewSubstation.SelectedNode = treeNode;
                this.treeViewSubstation.SelectedNode.Expand();
            }
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            List<TreeNode> list_ = new List<TreeNode>();
            list_ = this.method_13(this.treeViewSubstation.Nodes, list_);
            TreeNode treeNode = this.method_14(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, FormLinkRequestAndSchm.eFind.Prev);
            if (treeNode != null)
            {
                this.treeViewSubstation.SelectedNode = treeNode;
                this.treeViewSubstation.SelectedNode.Expand();
            }
        }

        private void toolTxtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Keys modifiers = e.Modifiers;
                if (modifiers == Keys.None)
                {
                    this.toolBtnFindNext_Click(sender, e);
                    return;
                }
                if (modifiers != Keys.Shift)
                {
                    return;
                }
                this.toolBtnFindPrev_Click(sender, e);
            }
        }

        private List<TreeNode> method_13(TreeNodeCollection treeNodeCollection, List<TreeNode> list)
        {
            foreach (TreeNode treeNode in treeNodeCollection)
            {
                list.Add(treeNode);
                list = this.method_13(treeNode.Nodes, list);
            }
            return list;
        }

        private TreeNode method_14(List<TreeNode> list, TreeNode treeNode, string str1, FormLinkRequestAndSchm.eFind e)
        {
            bool flag = e == FormLinkRequestAndSchm.eFind.First;
            if (e == FormLinkRequestAndSchm.eFind.Prev)
            {
                list.Reverse();
            }
            foreach (TreeNode current in list)
            {
                if (flag && current.Text.ToUpper().Contains(str1.ToUpper()))
                {
                    return current;
                }
                if (current == treeNode)
                {
                    flag = true;
                }
            }
            return null;
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && this.icontainer_0 != null)
        //    {
        //        this.icontainer_0.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private void method_15()
        //{
        //    this.treeView_0 = new TreeView();
        //    this.treeView_1 = new TreeView();
        //    this.listBox_0 = new ListBox();
        //    this.button_0 = new Button();
        //    this.button_1 = new Button();
        //    this.button_2 = new Button();
        //    this.button_3 = new Button();
        //    this.toolStrip_0 = new ToolStrip();
        //    this.toolStripButton_0 = new ToolStripButton();
        //    this.toolStripTextBox_0 = new ToolStripTextBox();
        //    this.toolStripButton_1 = new ToolStripButton();
        //    this.toolStripButton_2 = new ToolStripButton();
        //    this.label_0 = new Label();
        //    this.label_1 = new Label();
        //    this.groupBox_0 = new GroupBox();
        //    this.label_4 = new Label();
        //    this.dateTimePicker_1 = new DateTimePicker();
        //    this.dateTimePicker_0 = new DateTimePicker();
        //    this.label_3 = new Label();
        //    this.label_2 = new Label();
        //    this.textBox_0 = new TextBox();
        //    this.toolStrip_0.SuspendLayout();
        //    this.groupBox_0.SuspendLayout();
        //    base.SuspendLayout();
        //    this.treeView_0.CheckBoxes = true;
        //    this.treeView_0.HideSelection = false;
        //    this.treeView_0.Location = new Point(2, 28);
        //    this.treeView_0.Name = "treeViewSubstation";
        //    this.treeView_0.Size = new Size(210, 430);
        //    this.treeView_0.TabIndex = 0;
        //    this.treeView_0.BeforeExpand += new TreeViewCancelEventHandler(this.treeView_0_BeforeExpand);
        //    this.treeView_0.AfterSelect += new TreeViewEventHandler(this.treeView_0_AfterSelect);
        //    this.treeView_1.CheckBoxes = true;
        //    this.treeView_1.Location = new Point(2, 258);
        //    this.treeView_1.Name = "treeViewSubs";
        //    this.treeView_1.Size = new Size(210, 200);
        //    this.treeView_1.TabIndex = 1;
        //    this.listBox_0.FormattingEnabled = true;
        //    this.listBox_0.Location = new Point(277, 25);
        //    this.listBox_0.Name = "listBoxObjects";
        //    this.listBox_0.SelectionMode = SelectionMode.MultiExtended;
        //    this.listBox_0.Size = new Size(232, 277);
        //    this.listBox_0.Sorted = true;
        //    this.listBox_0.TabIndex = 2;
        //    this.button_0.Location = new Point(218, 28);
        //    this.button_0.Name = "buttonAdd";
        //    this.button_0.Size = new Size(53, 23);
        //    this.button_0.TabIndex = 3;
        //    this.button_0.Text = ">>>";
        //    this.button_0.UseVisualStyleBackColor = true;
        //    this.button_0.Click += new EventHandler(this.button_0_Click);
        //    this.button_1.Location = new Point(218, 57);
        //    this.button_1.Name = "buttonDel";
        //    this.button_1.Size = new Size(53, 23);
        //    this.button_1.TabIndex = 4;
        //    this.button_1.Text = "<<<";
        //    this.button_1.UseVisualStyleBackColor = true;
        //    this.button_1.Click += new EventHandler(this.button_1_Click);
        //    this.button_2.DialogResult = DialogResult.OK;
        //    this.button_2.Location = new Point(3, 464);
        //    this.button_2.Name = "buttonOk";
        //    this.button_2.Size = new Size(75, 23);
        //    this.button_2.TabIndex = 5;
        //    this.button_2.Text = "OK";
        //    this.button_2.UseVisualStyleBackColor = true;
        //    this.button_2.Click += new EventHandler(this.button_2_Click);
        //    this.button_3.DialogResult = DialogResult.Cancel;
        //    this.button_3.Location = new Point(434, 464);
        //    this.button_3.Name = "buttonCancel";
        //    this.button_3.Size = new Size(75, 23);
        //    this.button_3.TabIndex = 6;
        //    this.button_3.Text = "Отмена";
        //    this.button_3.UseVisualStyleBackColor = true;
        //    this.toolStrip_0.Dock = DockStyle.None;
        //    this.toolStrip_0.Items.AddRange(new ToolStripItem[]
        //    {
        //    this.toolStripButton_0,
        //    this.toolStripTextBox_0,
        //    this.toolStripButton_1,
        //    this.toolStripButton_2
        //    });
        //    this.toolStrip_0.Location = new Point(3, 0);
        //    this.toolStrip_0.Name = "toolStrip1";
        //    this.toolStrip_0.Size = new Size(183, 25);
        //    this.toolStrip_0.TabIndex = 7;
        //    this.toolStrip_0.Text = "toolStripTreeSubstations";
        //    this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_0.Image = Resources.Find;
        //    this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_0.Name = "tooBtnFind";
        //    this.toolStripButton_0.Size = new Size(23, 22);
        //    this.toolStripButton_0.Text = "toolStripButton1";
        //    this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        //    this.toolStripTextBox_0.Name = "toolTxtFind";
        //    this.toolStripTextBox_0.Size = new Size(100, 25);
        //    this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
        //    this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_1.Image = Resources.FindNext;
        //    this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_1.Name = "toolBtnFindNext";
        //    this.toolStripButton_1.Size = new Size(23, 22);
        //    this.toolStripButton_1.Text = "toolStripButton1";
        //    this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        //    this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_2.Image = Resources.FindPrev;
        //    this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_2.Name = "toolBtnFindPrev";
        //    this.toolStripButton_2.Size = new Size(23, 22);
        //    this.toolStripButton_2.Text = "toolStripButton2";
        //    this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
        //    this.label_0.AutoSize = true;
        //    this.label_0.Location = new Point(12, 242);
        //    this.label_0.Name = "label1";
        //    this.label_0.Size = new Size(115, 13);
        //    this.label_0.TabIndex = 8;
        //    this.label_0.Text = "Объекты подстанции";
        //    this.label_1.AutoSize = true;
        //    this.label_1.Location = new Point(274, 12);
        //    this.label_1.Name = "label2";
        //    this.label_1.Size = new Size(124, 13);
        //    this.label_1.TabIndex = 9;
        //    this.label_1.Text = "Привязанные объекты";
        //    this.groupBox_0.Controls.Add(this.textBox_0);
        //    this.groupBox_0.Controls.Add(this.label_2);
        //    this.groupBox_0.Controls.Add(this.dateTimePicker_0);
        //    this.groupBox_0.Controls.Add(this.label_3);
        //    this.groupBox_0.Controls.Add(this.dateTimePicker_1);
        //    this.groupBox_0.Controls.Add(this.label_4);
        //    this.groupBox_0.Location = new Point(277, 308);
        //    this.groupBox_0.Name = "groupBoxDuration";
        //    this.groupBox_0.Size = new Size(232, 150);
        //    this.groupBox_0.TabIndex = 10;
        //    this.groupBox_0.TabStop = false;
        //    this.groupBox_0.Text = "Период";
        //    this.label_4.AutoSize = true;
        //    this.label_4.Location = new Point(6, 16);
        //    this.label_4.Name = "label3";
        //    this.label_4.Size = new Size(71, 13);
        //    this.label_4.TabIndex = 0;
        //    this.label_4.Text = "Дата начала";
        //    this.dateTimePicker_1.CustomFormat = "dd.MM.yyyy HH:mm";
        //    this.dateTimePicker_1.Format = DateTimePickerFormat.Custom;
        //    this.dateTimePicker_1.Location = new Point(9, 32);
        //    this.dateTimePicker_1.Name = "dateTimePickerDateBeg";
        //    this.dateTimePicker_1.Size = new Size(217, 20);
        //    this.dateTimePicker_1.TabIndex = 1;
        //    this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
        //    this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
        //    this.dateTimePicker_0.Location = new Point(9, 71);
        //    this.dateTimePicker_0.Name = "dateTimePickerDateEnd";
        //    this.dateTimePicker_0.Size = new Size(217, 20);
        //    this.dateTimePicker_0.TabIndex = 3;
        //    this.label_3.AutoSize = true;
        //    this.label_3.Location = new Point(6, 55);
        //    this.label_3.Name = "label4";
        //    this.label_3.Size = new Size(71, 13);
        //    this.label_3.TabIndex = 2;
        //    this.label_3.Text = "Дата начала";
        //    this.label_2.AutoSize = true;
        //    this.label_2.Location = new Point(6, 94);
        //    this.label_2.Name = "label5";
        //    this.label_2.Size = new Size(80, 13);
        //    this.label_2.TabIndex = 4;
        //    this.label_2.Text = "Длительность";
        //    this.textBox_0.Location = new Point(9, 110);
        //    this.textBox_0.Name = "textBoxDuration";
        //    this.textBox_0.Size = new Size(217, 20);
        //    this.textBox_0.TabIndex = 5;
        //    base.AutoScaleDimensions = new SizeF(6f, 13f);
        //    base.AutoScaleMode = AutoScaleMode.Font;
        //    base.CancelButton = this.button_3;
        //    base.ClientSize = new Size(521, 495);
        //    base.Controls.Add(this.groupBox_0);
        //    base.Controls.Add(this.treeView_0);
        //    base.Controls.Add(this.label_1);
        //    base.Controls.Add(this.label_0);
        //    base.Controls.Add(this.toolStrip_0);
        //    base.Controls.Add(this.button_3);
        //    base.Controls.Add(this.button_2);
        //    base.Controls.Add(this.button_1);
        //    base.Controls.Add(this.button_0);
        //    base.Controls.Add(this.listBox_0);
        //    base.Controls.Add(this.treeView_1);
        //    base.FormBorderStyle = FormBorderStyle.FixedDialog;
        //    base.Name = "FormLinkRequestAndSchm";
        //    base.StartPosition = FormStartPosition.CenterParent;
        //    this.Text = "Привязка заявок к схеме";
        //    base.Load += new EventHandler(this.Form0_Load);
        //    this.toolStrip_0.ResumeLayout(false);
        //    this.toolStrip_0.PerformLayout();
        //    this.groupBox_0.ResumeLayout(false);
        //    this.groupBox_0.PerformLayout();
        //    base.ResumeLayout(false);
        //    base.PerformLayout();
        //}




        private struct Struct0
        {
            public Struct0(int p1, string txt)
            {
                this.str = txt;
                this.p0 = p1;
            }

            public override string ToString()
            {
                return this.str;
            }

            public string str;
            public int p0;
        }

        private enum eFind
        {
            First,
            Next,
            Prev
        }

    }
}