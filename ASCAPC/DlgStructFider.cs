using DataSql;
using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASCAPC
{
    /// <summary>
    ///  Структура точек измерения
    /// </summary>
    public partial class DlgStructFider : FormBase
    {
        //SQLSettings settingsTok5;
        //SqlDataCommand commandTok5;
        LibraryTSQL.SqlDataCommand tSQL;

        public DlgStructFider()
        {
            InitializeComponent();
            Text = "Структура центров питания (точек измерения)";

            this.controlFider1.IDC_ACT.Checked = true;

            //SQLSettingsTok5 setting = new SQLSettingsTok5();
            //commandTok5 = new SqlDataCommand(setting);

            //this.SqlSettings = new SQLSettings("ulges-sql", "Tok_5", "WINDOWS", "", "");
            //this.commandTok5 = new SqlDataCommand(settingsTok5);
        }

        private void IDC_ACT_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton radioButton = (RadioButton)sender;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Закрыть?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            AddObject(TypeCodes.Node);
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            if (treeViewNodes.Nodes.Count > 0)
            {
                //
                TreeNode currentNode = this.treeViewNodes.SelectedNode;
                //
                TypeCodes typeCode = ((TypeNode)currentNode.Tag).TypeCode;
                // short CodeNode = this.controlFider1.TypeNode.Code;
                if (typeCode == TypeCodes.Node)
                {
                    short CodeNode = this.controlFider1.TypeNode.Code;
                    short CodeObject = this.controlFider1.TypeNode.ParentTypeNode.Code;

                    var dtNodes = this.datasetTOK5.NODES.Where(w => w.OBJECT_CODE == CodeObject && w.NODE_CODE == CodeNode);
                    var dtMTRTYPE = this.datasetTOK5.MTRTYPE.Where(w => w.OBJECT_CODE == CodeObject && w.NODE_CODE == CodeNode);

                    dtNodes.ToList().ForEach(f => f.SetField<bool>("Deleted",true));
                    dtMTRTYPE.ToList().ForEach(f => f.SetField<bool>("Deleted", true));


                    tSQL.UpdateSqlData(this.datasetTOK5.NODES);
                    tSQL.UpdateSqlData(this.datasetTOK5.MTRTYPE);
                    this.treeViewNodes.SelectedNode = currentNode.Parent.Nodes[currentNode.Index];
                }
                else if (typeCode == TypeCodes.Object)
                {
                    short CodeObject = this.controlFider1.TypeNode.Code;

                    var dtObject = this.datasetTOK5.OBJECTS.Where(w => w.OBJECT_CODE == CodeObject);
                    var dtNodes = this.datasetTOK5.NODES.Where(w => w.OBJECT_CODE == CodeObject);
                    var dtMTRTYPE = this.datasetTOK5.MTRTYPE.Where(w => w.OBJECT_CODE == CodeObject);

                    dtObject.ToList().ForEach(f => f.Deleted = true);
                    dtNodes.ToList().ForEach(f => f.Deleted = true);
                    dtMTRTYPE.ToList().ForEach(f => f.Deleted = true);

                    tSQL.UpdateSqlData(this.datasetTOK5.OBJECTS);
                    tSQL.UpdateSqlData(this.datasetTOK5.NODES);
                    tSQL.UpdateSqlData(this.datasetTOK5.MTRTYPE);
                    this.treeViewNodes.SelectedNode = treeViewNodes.Nodes[currentNode.Index];
                }
                currentNode.Remove();
                this.ActiveControl = this.treeViewNodes;
            }
        }

        private void DlgStructFider_Load(object sender, EventArgs e)
        {
            this.treeViewNodes.Nodes.Clear();
            //this.treeViewNodes.Nodes.Add("УльГЭС (активные)");
            this.SqlSettings = new SQLSettings(new SQLSettingsTok5());
            tSQL = new LibraryTSQL.SqlDataCommand();
            tSQL.SqlSettings = this.SqlSettings;
            tSQL.SelectSqlData(this.datasetTOK5.OBJECTS, true);
            tSQL.SelectSqlData(this.datasetTOK5.NODES, true);
            tSQL.SelectSqlData(this.datasetTOK5.MTRTYPE, true);
            //

            //
            foreach (DataRow dataRow in datasetTOK5.OBJECTS.OrderBy(o=>o.OBJECT_NAME).Where(w => w.Deleted == false))
            {
                TreeNode treeObject = new TreeNode(dataRow["OBJECT_NAME"].ToString());
                treeObject.Tag = new TypeNode()
                {
                    Code = Convert.ToInt16(dataRow["OBJECT_CODE"]),
                    Name = dataRow["OBJECT_NAME"].ToString(),
                    TypeCode = TypeCodes.Object,
                    ParentTypeNode = new TypeNode()
                };
                this.treeViewNodes.Nodes.Add(treeObject);
                foreach (DataRow dataRowN in datasetTOK5.NODES.OrderBy(o=>o.NODE_NAME).Where(w=>w.OBJECT_CODE == (short)dataRow["OBJECT_CODE"] && (bool)w.Deleted == false))
                {
                    TreeNode treeNode = new TreeNode(dataRowN["NODE_NAME"].ToString());
                    treeNode.Tag = new TypeNode()
                    {
                        Code = Convert.ToInt16(dataRowN["NODE_CODE"]),
                        Name = dataRowN["NODE_NAME"].ToString(),
                        TypeCode = TypeCodes.Node,
                        CALC_FACTOR = Convert.ToDouble(dataRowN["CALC_FACTOR"]),
                        XML_CODE = Convert.ToString(dataRowN["XML80020_NODECODE"]),

                        ParentTypeNode = ((TypeNode)treeObject.Tag)
                    };

                    var vvv = this.datasetTOK5.MTRTYPE.Where(w=> w.OBJECT_CODE == ((TypeNode)treeObject.Tag).Code && w.NODE_CODE == ((TypeNode)treeNode.Tag).Code);
                    if (vvv.Count() > 0)
                    {
                        ((TypeNode)treeNode.Tag).METER_TYPE = Convert.ToChar(vvv.First().METER_TYPE);
                    }
                    treeObject.Nodes.Add(treeNode);
                }
            }
            //
            this.treeViewNodes.SelectedNode = treeViewNodes.Nodes[0];
            this.ActiveControl = this.treeViewNodes;
        }

        private void treeViewNodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if ((e.Node.Tag).GetType()==typeof(TypeNode))
                {
                    this.controlFider1.TypeNode = ((ASCAPC.TypeNode)e.Node.Tag);
                }
            }
        }

        private void btnEditElement_Click(object sender, EventArgs e)
        {
            EditElement();
        }

        private void btnAddObject_Click_1(object sender, EventArgs e)
        {
            AddObject(TypeCodes.Object);
        }
        /// <summary>
        /// Добавление узла в дерево
        /// </summary>
        /// <param name="typeCode"></param>
        private void AddObject(TypeCodes typeCode)
        {
            //
            TreeNode currentNode = this.treeViewNodes.SelectedNode;
            //
            DlgStructFiderAddEdit frm = new DlgStructFiderAddEdit();
            frm.eAction = References.eActionRequestRepair.Add;
            frm.controlFider1.TypeNode = new TypeNode() { TypeCode = typeCode};
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var typeNode = frm.controlFider1.TypeNode;
                string NameNode = typeNode.Name;
                // 0. Добавим узел
                if (typeCode == TypeCodes.Node)
                {
                    TreeNode ParentTreeNode = this.treeViewNodes.SelectedNode.Level == 0 ? this.treeViewNodes.SelectedNode : this.treeViewNodes.SelectedNode.Parent;
                    short CodeObject = ((TypeNode)ParentTreeNode.Tag).Code;
                    //
                    // 0. Проверим имя узла (не должно повторяться)
                    typeNode.ParentTypeNode = (TypeNode)ParentTreeNode.Tag;
                    if (checkNameNode(NameNode, typeNode))
                    {
                        DialogResult result = MessageBox.Show("Имя уже используется в другом объекте");
                        return;
                    };
                    //
                    DataRow row = this.datasetTOK5.NODES.NewRow();
                    row["NODE_NAME"] = NameNode;
                    row["OBJECT_CODE"] = CodeObject;
                    row["CALC_FACTOR"] = (float)typeNode.CALC_FACTOR;
                    row["XML80020_NODECODE"] = typeNode.XML_CODE;
                    this.datasetTOK5.NODES.Rows.Add(row);
                    //
                    short CodeNode = (short)row["NODE_CODE"];
                    //
                    if (!tSQL.InsertSqlData(this.datasetTOK5.NODES, false)) return;
                    //
                    DataRow rowM = this.datasetTOK5.MTRTYPE.NewRow();
                    rowM["OBJECT_CODE"] = CodeObject;
                    rowM["NODE_CODE"] =   CodeNode;
                    rowM["METER_TYPE"] =   Convert.ToString(typeNode.METER_TYPE);
                    this.datasetTOK5.MTRTYPE.Rows.Add(rowM);
                    //
                    if (!tSQL.InsertSqlData(this.datasetTOK5.MTRTYPE, false)) return;
                    //
                    TreeNode treeObject = new TreeNode(NameNode);
                    treeObject.Tag = new TypeNode() {
                        Code = CodeNode, Name = NameNode, TypeCode = typeCode, ParentTypeNode = ((TypeNode)(ParentTreeNode.Tag)),
                        METER_TYPE = typeNode.METER_TYPE, CALC_FACTOR = typeNode.CALC_FACTOR, XML_CODE = typeNode.XML_CODE};
                    int ChildIndexTree = ParentTreeNode.Nodes.Add(treeObject);
                    //
                    this.treeViewNodes.SelectedNode = ParentTreeNode.Nodes[ChildIndexTree];
                }
                else if (typeCode == TypeCodes.Object)
                {
                    // 0. Проверим имя узла (не должно повторяться)
                    if (checkNameNode(NameNode, typeNode))
                    {
                        DialogResult result = MessageBox.Show("Имя уже используется в другом объекте");
                        return;
                    };
                    // 2. Обновим базу данных
                    DataRow row = this.datasetTOK5.OBJECTS.NewRow();
                    row["OBJECT_NAME"] = NameNode;
                    this.datasetTOK5.OBJECTS.Rows.Add(row);
                    //
                    if (tSQL.InsertSqlData(this.datasetTOK5.OBJECTS, false))
                    {
                        //
                        short CodeNode = (short)row["OBJECT_CODE"];
                        // 1. обновим форму 
                        TreeNode treeObject = new TreeNode(NameNode);
                        treeObject.Tag = new TypeNode() { Code = CodeNode, Name = NameNode, TypeCode = typeCode, ParentTypeNode = new TypeNode() };
                        this.treeViewNodes.Nodes.Add(treeObject);
                        //
                        this.treeViewNodes.SelectedNode = treeViewNodes.Nodes[treeViewNodes.Nodes.Count - 1];
                    }
                }
                this.ActiveControl = this.treeViewNodes;
            }
        }
        /// <summary>
        /// Проверика  дублирования имени узла (не должно повторяться)
        /// </summary>
        /// <param name="nameNode"></param>
        /// <param name="typeNode"></param>
        /// <returns></returns>
        private bool checkNameNode(string nameNode, TypeNode typeNode)
        {
            bool resultat = false;
            if (typeNode.TypeCode == TypeCodes.Node)
            {
                short CodeObject = typeNode.ParentTypeNode.Code;
                var dtNodes = this.datasetTOK5.NODES.Where(w => w.NODE_NAME == nameNode && w.NODE_CODE != typeNode.Code && w.OBJECT_CODE == CodeObject);
                if (dtNodes.Count() > 0)
                {
                    resultat = true;
                }
            }
            else if (typeNode.TypeCode == TypeCodes.Object)
            {
                var dtObject = this.datasetTOK5.OBJECTS.Where(w => w.OBJECT_NAME == nameNode && w.OBJECT_CODE != typeNode.Code);
                if (dtObject.Count()>0)
                {
                    resultat = true;
                }

            }
            return resultat;
        }

        private void treeViewNodes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            EditElement();
        }
        private void EditElement()
        {
            //
            TreeNode currentNode = this.treeViewNodes.SelectedNode;
            // сохраниm старые коды
            short CodeNodeOld = this.controlFider1.TypeNode.Code;
            short CodeParentOld = this.controlFider1.TypeNode.ParentTypeNode.Code;
            //
            DlgStructFiderAddEdit frm = new DlgStructFiderAddEdit();
            frm.eAction = References.eActionRequestRepair.Edit;
            frm.controlFider1.TypeNode = ((ASCAPC.TypeNode)this.treeViewNodes.SelectedNode.Tag);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // 1. обновим форму 
                this.controlFider1.TypeNode = frm.controlFider1.TypeNode;
                // 2. обновим базу данных
                short CodeNode = this.controlFider1.TypeNode.Code;
                short CodeParent = this.controlFider1.TypeNode.ParentTypeNode.Code;
                string NameNode = this.controlFider1.TypeNode.Name;
                // 0. Проверим имя узла (не должно повторяться)
                if (checkNameNode(NameNode, this.controlFider1.TypeNode))
                {
                    DialogResult result = MessageBox.Show("Имя уже используется в другом объекте");
                    return;
                };

                this.treeViewNodes.SelectedNode.Text = NameNode;

                if (this.controlFider1.TypeNode.TypeCode == TypeCodes.Node)
                {
                    var dtObject = this.datasetTOK5.NODES.Where(w => w.OBJECT_CODE == CodeParentOld && w.NODE_CODE == CodeNodeOld);
                    if (dtObject.Count() > 0)
                    {
                        var rwFirstObject = dtObject.First();
                        rwFirstObject.OBJECT_CODE = CodeParent;
                        rwFirstObject.NODE_CODE = CodeNode;
                        rwFirstObject.NODE_NAME = NameNode;
                        rwFirstObject.CALC_FACTOR = (float)this.controlFider1.TypeNode.CALC_FACTOR;
                        rwFirstObject.XML80020_NODECODE = this.controlFider1.TypeNode.XML_CODE;

                        tSQL.UpdateSqlData(this.datasetTOK5.NODES);
                    }
                    var dtMTRTYPE = this.datasetTOK5.MTRTYPE.Where(w => w.OBJECT_CODE == CodeParentOld && w.NODE_CODE == CodeNodeOld);
                    if (dtMTRTYPE.Count() > 0)
                    {
                        var rwMTRTYPE = dtMTRTYPE.First();

                        rwMTRTYPE.OBJECT_CODE = CodeParent;
                        rwMTRTYPE.NODE_CODE = CodeNode;
                        rwMTRTYPE.METER_TYPE = Convert.ToString(this.controlFider1.TypeNode.METER_TYPE);

                        tSQL.UpdateSqlData(this.datasetTOK5.MTRTYPE);

                    }
                }
                else if (this.controlFider1.TypeNode.TypeCode == TypeCodes.Object)
                {
                    var dtObject = this.datasetTOK5.OBJECTS.Where(w => w.OBJECT_CODE == CodeNodeOld);
                    if (dtObject.Count() > 0)
                    {
                        var rwFirstObject = dtObject.First();
                        rwFirstObject.OBJECT_CODE = CodeNode;
                        rwFirstObject.OBJECT_NAME = NameNode;

                        tSQL.UpdateSqlData(this.datasetTOK5.OBJECTS);
                    }
                }

                this.treeViewNodes.SelectedNode = currentNode;
                this.ActiveControl = this.treeViewNodes;
            }

        }
        bool doubleClicked = false;
        private void treeViewNodes_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (doubleClicked)
            {
                doubleClicked = false;
                e.Cancel = true;
            }
        }

        private void treeViewNodes_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (doubleClicked)
            {
                doubleClicked = false;
                e.Cancel = true;
            }
        }

        private void treeViewNodes_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node;
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                node = treeViewNodes.GetNodeAt(e.X, e.Y);
                if (node != null)
                {
                    doubleClicked = true;
                }
            }
        }
    }
}
