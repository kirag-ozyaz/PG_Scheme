using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLbr.Classes;
using Constants;
using Documents.Forms.JournalCalcLoss;

namespace Prv.Forms.Abonent
{
    public partial class FormAbonent : FormLbr.FormBase
    {
        public static int idCont = -1, idZ = -1;
        public static DateTime actDate ;

        private int firstCodeAbonent = -1;      // первый абонент
        private int lastCodeAbonent = -1;       // последний абонент

        private int codeAbn = -1;
        private int typeAbn = -1;

        private int idAbn = -1, idAbnObj = -1;

        private int ID;
        private int IDOBJSELECT;

        class CmbItem
        {
            public CmbItem()
            {
            }

            public CmbItem(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public string Name { get; set; }
            public int Id { get; set; }

            public override string ToString()
            {
                return Name;
            }

        }

        enum GoAbonent { Next, Prev, Current, First, Last };

        #region FormAbonent Events
        /// <summary>
        /// Конструтор формы "Карточка абонента ФЛ"
        /// </summary>
        public FormAbonent()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Конструтор формы "Карточка абонента ФЛ"
        /// </summary>
        /// <param name="codeAbn">Код абонента</param>
        /// <param name="typeAbn">Тип абонента</param>
        public FormAbonent(int codeAbn, int typeAbn)
        {
            InitializeComponent();
            this.codeAbn = codeAbn;
            this.typeAbn = typeAbn;
        }
        // загрузка формы
        private void FormAbonent_Load(object sender, EventArgs e)
        {
            // Загрузка справочников
            LoadDirectory();

            LoadAddBtnCalcLoss();

            firstCodeAbonent = GetFirstAbonent(toolBtnShowDelAbn.Checked);
            lastCodeAbonent = GetLastAbonent(toolBtnShowDelAbn.Checked);

            if (codeAbn == -1) codeAbn = firstCodeAbonent;
            if (typeAbn != -1) ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id = typeAbn;

            // загрузка абонента
            LoadAbonent(codeAbn, ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id);
        }

        // Нажатие клавишы по форме
        private void FormAbonent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Home:     // ПЕРВЫЙ АБОНЕНТ
                        if ((toolBtnFirstAbn.Visible) && (toolBtnFirstAbn.Enabled))
                            toolBtnFirstAbn_Click(sender, e);
                        break;
                    case Keys.End:      // ПОСЛЕДНИЙ АБОНЕНТ
                        if ((toolBtnLastAbn.Visible) && (toolBtnLastAbn.Enabled))
                            toolBtnLastAbn_Click(sender, e);
                        break;
                    case Keys.PageUp: // ПРЕДЫДУЩИЙ АБОНЕНТ
                        if ((toolBtnPrevAbn.Visible) && (toolBtnPrevAbn.Enabled))
                            toolBtnPrevAbn_Click(sender, e);
                        break;
                    case Keys.PageDown: // СЛЕДУЮЩИЙ АБОНЕНТ
                        if ((toolBtnNextAbn.Visible) && (toolBtnNextAbn.Enabled))
                            toolBtnNextAbn_Click(sender, e);
                        break;
                    case Keys.F:        // ПОИСК Абонента
                        if ((toolBtnAbnFind.Visible) && (toolBtnAbnFind.Enabled))
                            toolBtnAbnFind_Click(sender, e);
                        break;
                    default: break;
                }
            }
        }
        #endregion

        #region LoadData
        #region GetFirstAndLastAbonent
        // Первый абонент
        private int GetFirstAbonent(bool withDel)
        {
            DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
            string typeAbn = "";
            //if (toolComboBoxTypeAbn.SelectedIndex != 0)  // Если выбрали какой то тип
            typeAbn = " where TypeAbn = " + ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id.ToString();
            string delete = (withDel) ? "" : (typeAbn == "") ? " where deleted = 0 " : " and deleted = 0 ";
            this.SelectSqlData(ds.tAbn, true,
                typeAbn + delete + " order by codeabonent asc", null, false, 1);

            if (ds.tAbn.Rows.Count <= 0) return -1;
            else return (int)ds.tAbn.Rows[0]["CodeABonent"];
        }
        // Последний абонент
        private int GetLastAbonent(bool withDel)
        {
            DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
            string typeAbn = "";
            //if (toolComboBoxTypeAbn.SelectedIndex != 0)  // Если выбрали какой то тип
            typeAbn = " where TypeAbn = " + ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id.ToString();
            string delete = (withDel) ? "" : (typeAbn == "") ? " where deleted = 0 " : " and deleted = 0 ";
            this.SelectSqlData(ds.tAbn, true,
                typeAbn + delete + " order by codeabonent desc", null, false, 1);

            if (ds.tAbn.Rows.Count <= 0) return -1;
            else return (int)ds.tAbn.Rows[0]["CodeABonent"];
        }
        #endregion
        // Загрузка справочников
        private void LoadDirectory()
        {
            // Загрузка классификатора
            this.SelectSqlData(dsPrv, dsPrv.tR_Classifier, true,
                " where ParentKey in (';Skuee;TypeAbn;') and isGRoup = 0");
            // Добавить итемы в toolComboBoxTypeAbn
            toolComboBoxTypeAbnAddItems("Потребители ФЛ");
            //Добавить итемы в комбобоксы пересчета дебиторки
            for (DateTime d_c = System.DateTime.Now.AddMonths(1); d_c >= new DateTime(2009, 01, 01);
                d_c = d_c.AddMonths(-1))
            {
                toolStripComboBoxDebBeg.Items.Add(d_c.ToString("MMMM yyyy"));
                toolStripComboBoxDebEnd.Items.Add(d_c.ToString("MMMM yyyy"));
            }
            toolStripComboBoxDebEnd.SelectedIndex = 1;
            toolStripComboBoxDebBeg.SelectedIndex = toolStripComboBoxDebBeg.Items.Count - 1;
        }
        // поиск абонента
        private void FindLS(int findLS, GoAbonent goAbn, int typeAbn, bool withDel)
        {
            string where = "";

            if (typeAbn != -1)  // Если выбрали какой то тип
                where = " and TypeAbn = " + typeAbn.ToString();
            where = (withDel) ? where + "" : (where == "") ? " and deleted = 0 " :
                where + " and deleted = 0 ";

            DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
            switch (goAbn)
            {
                case GoAbonent.Current: // текущий
                    where = " where CodeABonent = " + findLS.ToString() + where;
                    break;
                case GoAbonent.Prev:  // предыдущий
                    where = " where CodeAbonent < " + findLS.ToString() + where + " order by codeabonent desc";
                    break;
                case GoAbonent.Next:  // Следующий
                    where = " where CodeAbonent > " + findLS.ToString() + where + " order by codeabonent asc";
                    break;
                case GoAbonent.First:  // первый
                    where = " where CodeAbonent = " + firstCodeAbonent.ToString() + where;
                    break;
                case GoAbonent.Last:  // последний
                    where = " where CodeAbonent = " + lastCodeAbonent.ToString() + where;
                    break;
            }

            this.SelectSqlData(ds.tAbn, true, where, null, false, 1);
            if (ds.tAbn.Rows.Count > 0) // нашли
            {
                idAbn = (int)ds.tAbn.Rows[0]["id"];
                LoadAbonent((int)ds.tAbn.Rows[0]["CodeAbonent"], typeAbn);
            }
            else
            {
                idAbn = -1;
                MessageBox.Show("Лицевой счет не найден");
            }

        }
        // загрузка абонента
        private void LoadAbonent(int codeAbonent, int typeAbn)
        {
            // Загрузка абонента
            this.SelectSqlData(dsPrv, dsPrv.vAbn, true, " where codeAbonent = " + codeAbonent.ToString() +
                " and typeAbn = " + typeAbn.ToString() + " order by name");

            tstbDopCode.Text = dsPrv.vAbn.Rows[0]["CodeAbnStr"].ToString();

            ChangeStyleConrolsAbn();
            ChangeActiveNavigatorsButtons();

            // загрузка контактной инфо
            this.SelectSqlData(dsPrv, dsPrv.tAbnContact, true, "where idAbn = " + dsPrv.vAbn.Rows[0]["id"].ToString() +
                " order by DateChange desc");

            // Загрузка дерева
            LoadTreeViewAbn(null);
           
        }

        #region LoadTreeViewAbn
        // Загрузка дерева договоров
        private void LoadTreeViewAbn(TreeNode selNode)
        {
            treeViewAbn.Nodes.Clear();
            TreeNode nodeSelect = null;
            foreach (DataRow dr in dsPrv.vAbn.Select("", "name asc")) // Rows() Коллекция изменена, возможно операция перечисления не будет выполнена. |25.06.2014 В.И.Левченко|
            {
                
                TreeNode nodeAbn = new TreeNode("Абонент №" + dr["CodeAbonent"].ToString());  // наименование
                if (dr["CodeAbonent"] != DBNull.Value && Convert.ToInt32(dr["CodeAbonent"]) < 0 &&
                    dr["Name"] != DBNull.Value)
                {
                    nodeAbn.Text += " (" + dr["Name"].ToString() + ") ";
                }

                if (toolBtnShowDelAbn.Checked) // показывать удаленных
                {
                    if (dr["deleted"] != DBNull.Value && Convert.ToBoolean(dr["deleted"]))
                        nodeAbn.ForeColor = Color.Red;
                }
                else
                    if (dr["deleted"] != DBNull.Value && Convert.ToBoolean(dr["deleted"]))
                        continue;

                
                nodeAbn.Tag = "Abn" + dr["Id"].ToString();
                if (toolBtnEditTree.Visible == true) nodeAbn.ContextMenuStrip = contextMenuTree;
                nodeAbn.ImageKey = "AbonentFL.ico";
                nodeAbn.SelectedImageKey = "AbonentFL.ico";
                // primary key
                treeViewAbn.Nodes.Add(nodeAbn);
                // Загрузка объектов
                LoadTreeNodesObj(nodeAbn, selNode);
                if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeAbn.Tag)))
                {   // Выделенная ветвь
                    /*treeViewAbn.SelectedNode*/nodeSelect = nodeAbn;
                    //treeViewAbn.SelectedNode.Expand();
                }
            }
            if (treeViewAbn.Nodes.Count > 0)
                treeViewAbn.Nodes[0].Expand(); // развернуть первый уровень

            if (nodeSelect != null)
            {
                treeViewAbn.SelectedNode = nodeSelect;
                treeViewAbn.SelectedNode.Expand();
            }
            if (selNode == null)
            {
                if (treeViewAbn.Nodes[0].Nodes.Count > 0) // есть объект
                {
                    if (treeViewAbn.Nodes[0].Nodes[0].Nodes.Count > 0) // есть точка
                    {
                        treeViewAbn.SelectedNode = treeViewAbn.Nodes[0].Nodes[0].Nodes[0];  //выделяем точку
                    }
                    else
                        treeViewAbn.SelectedNode = treeViewAbn.Nodes[0].Nodes[0]; // выделяем абонента
                }
                else //нет объектов
                    treeViewAbn.SelectedNode = treeViewAbn.Nodes[0]; // выделяем абонента
            }

        }
        // загрузка объектов
        private void LoadTreeNodesObj(TreeNode root, TreeNode selNode)
        {
            DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
            this.SelectSqlData(ds, ds.vAbnObjAddress, true, " where  (TypeObjNew = " + ((int)Constants.KontragentObjType.AbnObjFL).ToString() + " or TypeObjNew is NULL )and idAbn = " + GetIdFromNodeTag(root.Tag).ToString());

            foreach (DataRow dr in ds.vAbnObjAddress.Select("", "Street, House, HousePrefix, Name"))
            {
                TreeNode node = new TreeNode();
                switch (Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]))
                {
                    case Constants.Constants.TypeAbnPrivate:
                    case Constants.Constants.TypeAbnPrivateNoDog:
                    case Constants.Constants.TypeAbnLegal:
                        string obj = (dr["Name"].ToString() == "") ? "" : " - " + dr["Name"].ToString();
                        node.Text = dr["Street"].ToString() + " " +
                                    dr["House"].ToString() + dr["HousePrefix"].ToString() + obj;
                        break;
                    default:
                        node.Text = dr["Name"].ToString();
                        break;
                }
                node.Tag = "Obj" + dr["Id"].ToString();                   // primary key
                if (toolBtnEditTree.Visible == true) node.ContextMenuStrip = contextMenuTree;
                node.ImageKey = "OfficeHouse.png";
                node.SelectedImageKey = "OfficeHouse.png";
                root.Nodes.Add(node);

                LoadTreeNodesPoint(node, selNode);   // точки учета

                if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(node.Tag)))
                {   // выделяем элемент, если надо
                    treeViewAbn.SelectedNode = node;
                    treeViewAbn.SelectedNode.Expand();
                }
            }
        }
        // загрузка точек учета
        private void LoadTreeNodesPoint(TreeNode root, TreeNode selNode)
        {
            DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
            this.SelectSqlData(ds, ds.vPointRegLast, true, "where IdAbnObj = " + GetIdFromNodeTag(root.Tag).ToString() + " order by id");
            foreach (DataRow dr in ds.vPointRegLast.Rows)
            {
                TreeNode node = new TreeNode(dr["CurrentPoint"].ToString());    // наименование
                node.Tag = "Point" + dr["Id"].ToString();                 // primary key
                if (toolBtnEditTree.Visible == true) node.ContextMenuStrip = contextMenuTree;
                node.ImageKey = "Counter.ico";
                node.SelectedImageKey = "Counter.ico";
                root.Nodes.Add(node);

                if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(node.Tag)))
                { 
                    // выделяем элемент, если надо
                    treeViewAbn.SelectedNode = node;
                    treeViewAbn.SelectedNode.Expand();
                }
            }
        }
        // Возвращает Id из ветки
        private int GetIdFromNodeTag(Object tag)
        {
            string stTag = tag.ToString();

            if (stTag.IndexOf("Abn") >= 0) // ветка абонента
                return Convert.ToInt32(stTag.Substring(3));
            if (stTag.IndexOf("Point") >= 0) // ветка точки
                return Convert.ToInt32(stTag.Substring(5));
            if (stTag.IndexOf("ObjSub") >= 0) // ветка субобъекта
                return Convert.ToInt32(stTag.Substring(6));
            if (stTag.IndexOf("Obj") >= 0) // ветка объекта
                return Convert.ToInt32(stTag.Substring(3));

            return -1;
        }
        #endregion

        #region LoadSelect
        // Загрузка абонента....
        private void LoadSelectAbn(int idAbn)
        {
            #region 12/05/2014 Shumilov A/I/
            this.idAbn = idAbn;
            // Загрузка абонента
            this.SelectSqlData(dsPrv, dsPrv.vAbn, true, " where id = " + idAbn.ToString());
            if (dsPrv.vAbn.Rows.Count > 0)
                tstbDopCode.Text = dsPrv.vAbn.Rows[0]["CodeAbnStr"].ToString();

            ChangeStyleConrolsAbn();
            ChangeActiveNavigatorsButtons();

            // загрузка контактной инфо
            this.SelectSqlData(dsPrv, dsPrv.tAbnContact, true, "where idAbn = " + dsPrv.vAbn.Rows[0]["id"].ToString() +
                " order by DateChange desc");
            #endregion


            dsPrv.vAbnObjAddress.Clear();
            dsPrv.vAbnObjRegLast.Clear();
            dsPrv.tAbnObjReg.Clear();
            dsPrv.vPointRegLast.Clear();
            dsPrv.vPointReg.Clear();
            dsPrv.vDocAct.Clear();
            dsPrv.vL_SchmAbn.Clear();
            dsPrv.vJ_CalcLoss.Clear();
            dsPrv.vAbnObjDoc_List.Clear();
            dsPrv.vPrv_DebitorkaUE.Clear();
            dsPrv.vPrv_Debitorka.Clear();
            dsPrv.tAbnObjFlags.Clear();
            dsPrv.vPrv_AbnObjFlags.Clear();
            dsPrv.tConnect.Clear();
            dsPrv.vDocOpl.Clear();

        }
        private void LoadSelectAbnObj(int idObj)
        {
            idAbnObj = idObj;
            this.SelectSqlData(dsPrv, dsPrv.vAbnObjAddress, true, "where id = " + idObj.ToString());
            this.SelectSqlData(dsPrv, dsPrv.vAbnObjRegLast, true, "where idAbnObj = " + idObj.ToString());
            this.SelectSqlData(dsPrv, dsPrv.tAbnObjReg, true, " where idAbnObj = " + idObj.ToString() + " order by DateChange desc");
            //Признаки
            this.SelectSqlData(dsPrv, dsPrv.vPrv_AbnObjFlags, true, " where idAbnObj = " + idObj.ToString() + " Order by Name desc");
            if (dsPrv.vPrv_AbnObjFlags.Rows.Count > 0) this.SelectSqlData(dsPrv, dsPrv.tAbnObjFlags, true, " where idAbnObj = " + idObj.ToString() + " Order by Date desc");
                else dsPrv.tAbnObjFlags.Clear();

            LoadLinkSchmAbn();
            LoadCalcLoss();

            LoadTP_old();

            LoadDocActs();

            dsPrv.vPointRegLast.Clear();
            dsPrv.vDocAct.Clear();
            dsPrv.vPointReg.Clear();
            //----------this.SelectSqlData(dsPrv, dsPrv.vPointRegLast, true, "where idAbnObj = " + idObj.ToString() + " order by id");
        }
        private void LoadSelectPoint(int p)
        {
            this.SelectSqlData(dsPrv, dsPrv.vPointRegLast, true, "where id = " + p.ToString());
            this.SelectSqlData(dsPrv, dsPrv.vDocAct, true, "where idPoint = " + p.ToString() + " order by DateAct desc");
            this.SelectSqlData(dsPrv, dsPrv.vDocOpl, true, "where idPoint = " + p.ToString() + " order by DateOpl desc");
            this.SelectSqlData(dsPrv, dsPrv.vTariffReg, true, "where idPoint = " + p.ToString() + " order by SetDate desc");
            tabControlDebitorka.SelectedIndex = 0;
            this.SelectSqlData(dsPrv, dsPrv.vPrv_Debitorka, true, "where idPoint = " + p.ToString() + " order by MonthRasch desc");
   
           
            // история по точке учета
            this.SelectSqlData(dsPrv, dsPrv.vPointReg, true, "where idPoint = " + p.ToString() + " order by DateBegin desc");
            bindingSourceCounter.Filter = " Type <> " + ((int)Constants.DevicePointType.TransAmperage).ToString();
            bindingSourceTrans.Filter = " Type = " + ((int)Constants.DevicePointType.TransAmperage).ToString();

            // ПЛОМБИРОВКА
            LoadPlombs();
            SumDeb(p);
        }

        private void LoadLinkSchmAbn()
        {
            // привязка к схеме
            this.SelectSqlData(dsPrv, dsPrv.vL_SchmAbn, true, " where idAbnObj = " + idAbnObj.ToString() + " order by SchmObjName ");
        }

        private void LoadPlombs()
        {
            if (dsPrv.vPointReg.Rows.Count > 0)
            {
                string where = "";
                foreach (DataRow dr in dsPrv.vPointReg.Rows)
                    where += dr["id"].ToString() + ",";
                where = " where idPointReg in (" + where.Remove(where.Length - 1) + ")";
                this.SelectSqlData(dsPrv, dsPrv.vPlombUstDem, true, where + " order by DateDem, DateUst");
            }


            //Сумма кВт в начислениях

        }
        #endregion
        #endregion
        
        //Сумма начислений поинта
        private void SumDeb(int p)
         {
            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
            try
            {
                sql.OpenConnection(this.SqlSettings);
                System.Data.SqlClient.SqlCommand sqlcom2 = new System.Data.SqlClient.SqlCommand("select sum(KWT) from vPrv_Debitorka where idPoint=" + p + " and (MonthRasch >= 200901 or MonthRasch = 2008 or monthrasch = 2007) ", sql.Connection);
                toolStripTextBoxDebitorka.Text = sqlcom2.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                sql.CloseConnection();
            }
        }

        #region toolStripMain Events
        // первый абонент
        private void toolBtnFirstAbn_Click(object sender, EventArgs e)
        {
            FindLS(firstCodeAbonent, GoAbonent.First,
                ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id, toolBtnShowDelAbn.Checked);
        }
        // предыдущий
        private void toolBtnPrevAbn_Click(object sender, EventArgs e)
        {
            FindLS(Convert.ToInt32(txtCurrentCodeAbonent.Text), GoAbonent.Prev,
                ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id, toolBtnShowDelAbn.Checked);
        }
        // следующий
        private void toolBtnNextAbn_Click(object sender, EventArgs e)
        {
            FindLS(Convert.ToInt32(txtCurrentCodeAbonent.Text), GoAbonent.Next,
                ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id, toolBtnShowDelAbn.Checked);
        }
        // последний
        private void toolBtnLastAbn_Click(object sender, EventArgs e)
        {
            FindLS(lastCodeAbonent, GoAbonent.Last,
                ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id, toolBtnShowDelAbn.Checked);
        }
        // показать/скрыть удаленных
        private void toolBtnShowDelAbn_Click(object sender, EventArgs e)
        {
            firstCodeAbonent = GetFirstAbonent(toolBtnShowDelAbn.Checked);
            lastCodeAbonent = GetLastAbonent(toolBtnShowDelAbn.Checked);

            if (!toolBtnShowDelAbn.Checked && //не показывать удаленных
                 Convert.ToBoolean(dsPrv.vAbn.Rows[0]["Deleted"]) == true) // текущий - удалленный
                    FindLS(firstCodeAbonent, GoAbonent.First,((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id, toolBtnShowDelAbn.Checked);
            else
                LoadAbonent((int)dsPrv.vAbn.Rows[0]["CodeAbonent"], ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id);
            ChangeActiveNavigatorsButtons();
        }

        #region AddEditDelAbn
        // Новый абонент
        private void toolBtnAbnAdd_Click(object sender, EventArgs e)
        {
            

            FormAddEditAbn fAdd = new FormAddEditAbn(-1, FormAddEditAbn.ActionAbn.Add);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                firstCodeAbonent = GetFirstAbonent(toolBtnShowDelAbn.Checked);
                lastCodeAbonent = GetLastAbonent(toolBtnShowDelAbn.Checked);

                FindLS(fAdd.CodeAbonent, GoAbonent.Current, fAdd.TypeAbn, toolBtnShowDelAbn.Checked);
                if (dsPrv.vAbn.Rows.Count > 0)
                    toolComboBoxTypeAbn.Text = dsPrv.vAbn.Rows[0]["TypeName"].ToString();

                ChangeActiveNavigatorsButtons();
            }
        }
        // Редактировать абонента
        private void toolBtnAbnEdit_Click(object sender, EventArgs e)
        {
            if (dsPrv.vAbn.Rows.Count > 0)
            {
                FormAddEditAbn fEdit = new FormAddEditAbn(idAbn, FormAddEditAbn.ActionAbn.Edit);
                fEdit.SqlSettings = this.SqlSettings;
                if (fEdit.ShowDialog() == DialogResult.OK)
                {
                    FindLS(fEdit.CodeAbonent, GoAbonent.Current, fEdit.TypeAbn, toolBtnShowDelAbn.Checked);
                    if (dsPrv.vAbn.Rows.Count > 0)
                        toolComboBoxTypeAbn.Text = dsPrv.vAbn.Rows[0]["TypeName"].ToString();
                }
            }
        }
        // Закрыть/открыть абонента
        private void toolBtnAbnActiveDeActive_Click(object sender, EventArgs e)
        {
            if (dsPrv.vAbn.Rows.Count > 0)
            {
                FormAbnStatus fEditStatus = new FormAbnStatus(Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]), (int)dsPrv.vAbn.Rows[0]["CodeAbonent"]);
                fEditStatus.SqlSettings = this.SqlSettings;
                if (fEditStatus.ShowDialog() == DialogResult.OK)
                {
                    LoadAbonent((int)dsPrv.vAbn.Rows[0]["CodeAbonent"], ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id);
                }
            }
            //if (dsPrv.vAbn.Rows.Count > 0)
            //{
            //    if (Convert.ToBoolean(dsPrv.vAbn.Rows[0]["IsActive"])) //активный
            //    {
            //        FormAddEditAbn fDeact = new FormAddEditAbn(Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]), FormAddEditAbn.ActionAbn.Deactive);
            //        fDeact.SqlSettings = this.SqlSettings;
            //        if (fDeact.ShowDialog() == DialogResult.OK)
            //            FindLS(fDeact.CodeAbonent, GoAbonent.Current, fDeact.TypeAbn, toolBtnShowDelAbn.Checked);
            //    }
            //    else // неактивный
            //    {
            //        DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
            //        this.SelectSqlData(ds, ds.tAbnStatus, true, " where idAbn = " + dsPrv.vAbn.Rows[0]["id"].ToString() +
            //            " and isActive = 0 order by Datechange desc", 1);
            //        if (ds.tAbnStatus.Rows.Count > 0)
            //            if (this.DeleteSqlDataById(ds.tAbnStatus, Convert.ToInt32(ds.tAbnStatus.Rows[0]["id"])))
            //                FindLS(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]), GoAbonent.Current, Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]), toolBtnShowDelAbn.Checked);
            //    }
            //}
        }
        // Удалить/восстановить абонента
        private void toolBtnAbnDel_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Удалить лицевой счет?", "Удаление", MessageBoxButtons.YesNo);
           if (dialogResult == DialogResult.Yes)
           {
               DialogResult dialogResult2 = MessageBox.Show("Уверены? ВСЕ ТЕКУЩИЕ ДАННЫЕ БУДУТ ПОТЕРЯНЫ!!!", "Внимание!", MessageBoxButtons.YesNo);
               if (dialogResult2 == DialogResult.Yes)
               {
                   if (dsPrv.vAbn.Rows.Count > 0)
                   {
                       DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
                       this.SelectSqlData(ds, ds.tAbn, true, "where id = " + Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]));
                       ds.tAbn.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tAbn.Rows[0]["Deleted"]);
                       ds.tAbn.Rows[0].EndEdit();
                       if (this.UpdateSqlData(ds, ds.tAbn))
                       {
                           if (Convert.ToBoolean(ds.tAbn.Rows[0]["Deleted"]))
                           {
                               MessageBox.Show("Абонент успешно удален");
                               FindLS(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]), GoAbonent.Next, Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]), toolBtnShowDelAbn.Checked);
                           }
                           else
                           {
                               MessageBox.Show("Абонент успешно восстановлен");
                               FindLS(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]), GoAbonent.Current, Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]), toolBtnShowDelAbn.Checked);
                           }
                       }
                   }
               }
           }
        }
        #endregion
        // Поиск абонента
        private void toolBtnAbnFind_Click(object sender, EventArgs e)
        {
            FormAbnFind fFind = new FormAbnFind();
            fFind.SqlSettings = this.SqlSettings;
            if (fFind.ShowDialog() == DialogResult.OK)
            {

                if (fFind.SelectedTypeAbn == Constants.Constants.TypeAbnLegal
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnNet
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnNet)
                {
                    FormLbr.Classes.ShowFormEventArgs eShow = new FormLbr.Classes.ShowFormEventArgs();
                    eShow.TypeForm = "Legal.Forms.FormAbn, Legal";
                    eShow.FormMode = FormLbr.Classes.eFormMode.Mdi;
                    eShow.Param = new object[2];
                    eShow.Param[0] = fFind.SelectedAbonent;
                    eShow.Param[1] = fFind.SelectedObj;
                    eShow.SQLSettings = this.SqlSettings;
                    this.OnShowForm(eShow);

                }

                if (fFind.SelectedTypeAbn == Constants.Constants.TypeAbnPrivate
                    || fFind.SelectedTypeAbn == Constants.Constants.TypeAbnPrivateNoDog)
                {

                    // найти л/с
                    FindLS(fFind.SelectedAbonent, GoAbonent.Current, fFind.SelectedTypeAbn, toolBtnShowDelAbn.Checked);
                }


            }
        }
        #endregion

        #region toolStripChoiceAbn Events
        // Добавить итемы в типы абонента
        private void toolComboBoxTypeAbnAddItems(String selText)
        {
            toolComboBoxTypeAbn.Items.Clear();
            //toolComboBoxTypeAbn.Items.Add(new CmbItem("Все", -1));

            foreach (DataRow r in dsPrv.tR_Classifier.Select("ParentKey = ';SKuee;TypeAbn;' and " +
                "(id in (" + Constants.Constants.TypeAbnPrivate.ToString() + "," + Constants.Constants.TypeAbnPrivateNoDog.ToString() + "))"))
                toolComboBoxTypeAbn.Items.Add(new CmbItem(r["Name"].ToString(), Convert.ToInt32(r["Id"])));

            toolComboBoxTypeAbn.SelectedText = selText;
            if (toolComboBoxTypeAbn.SelectedIndex < 0) toolComboBoxTypeAbn.SelectedIndex = 0;
        }
        // Выбрать тип абонента
        private void toolComboBoxTypeAbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            firstCodeAbonent = GetFirstAbonent(toolBtnShowDelAbn.Checked);
            lastCodeAbonent = GetLastAbonent(toolBtnShowDelAbn.Checked);

            if (dsPrv.vAbn.Rows.Count > 0)
            {
                if (((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id !=
                    Convert.ToInt32(dsPrv.vAbn.Rows[0]["TypeAbn"]))
                    FindLS(firstCodeAbonent, GoAbonent.Current, ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id,
                        toolBtnShowDelAbn.Checked);
            }
            else
            {
                FindLS(firstCodeAbonent, GoAbonent.Current, ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id,
                      toolBtnShowDelAbn.Checked);
            }
            ChangeActiveNavigatorsButtons();
        }
        // Выбрать абонента
        private void toolTextBoxChangeAbn_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                FindLS(Convert.ToInt32(toolTxtChangeAbn.Text), GoAbonent.Current,
                    ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id, toolBtnShowDelAbn.Checked);
        }
        #endregion

        // Активировать/деактиваировать некоторые кнопки навигатора(в зависимости от абонента)
        private void ChangeActiveNavigatorsButtons()
        {
            // навигатор (может не надо)
            if (Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]) == firstCodeAbonent)
            {
                toolBtnFirstAbn.Enabled = false;
                toolBtnPrevAbn.Enabled = false;
            }
            else
            {
                toolBtnFirstAbn.Enabled = true;
                toolBtnPrevAbn.Enabled = true;
            }
            if (Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]) == lastCodeAbonent)
            {
                toolBtnLastAbn.Enabled = false;
                toolBtnNextAbn.Enabled = false;
            }
            else
            {
                toolBtnLastAbn.Enabled = true;
                toolBtnNextAbn.Enabled = true;
            }
        }
        // Изменить контролы в зависимости от абонента
        private void ChangeStyleConrolsAbn()
        {
           
            if (dsPrv.vAbn.Rows.Count > 0)
            {
                // кнопка удаления абонента
                toolBtnAbnDel.Text = (Convert.ToBoolean(dsPrv.vAbn.Rows[0]["Deleted"])) ? "Восстановить" : "Удалить";
                // кнопка открытия/закрытия абонента
                //if (dsPrv.vAbn.Rows[0]["IsActive"] != DBNull.Value)
                //    toolBtnAbnActiveDeActive.Text = (Convert.ToBoolean(dsPrv.vAbn.Rows[0]["IsActive"])) ? "Закрыть л/с" : "Открыть л/с";

                if (Convert.ToBoolean(dsPrv.vAbn.Rows[0]["Deleted"])) // удален
                {
                    labelCurrentCodeAbonent.ForeColor = Color.Red;
                    labelAbnName.ForeColor = Color.Red;
                    labelAbnControler.ForeColor = Color.Red;
                    labelAbnStatus.ForeColor = Color.Red;
                    labelAbnDateChange.ForeColor = Color.Red;
                }
                else
                {
                    labelCurrentCodeAbonent.ForeColor = System.Drawing.SystemColors.ControlText;
                    labelAbnName.ForeColor = System.Drawing.SystemColors.ControlText;
                    labelAbnControler.ForeColor = System.Drawing.SystemColors.ControlText;
                    labelAbnStatus.ForeColor = System.Drawing.SystemColors.ControlText;
                    labelAbnDateChange.ForeColor = System.Drawing.SystemColors.ControlText;
                }

                if (dsPrv.vAbn.Rows[0]["IsActive"] == DBNull.Value || Convert.ToBoolean(dsPrv.vAbn.Rows[0]["IsActive"])) // активный
                {
                    txtCurrentCodeAbonent.BackColor = System.Drawing.SystemColors.Window;
                    txtAbnName.BackColor = System.Drawing.SystemColors.Window;
                    txtAbnControler.BackColor = System.Drawing.SystemColors.Window;
                    txtAbnStatus.BackColor = System.Drawing.SystemColors.Window;
                    txtAbnDateChange.BackColor = System.Drawing.SystemColors.Window;
                }
                else
                {
                    txtCurrentCodeAbonent.BackColor = Color.LightYellow;
                    txtAbnName.BackColor = Color.LightYellow;
                    txtAbnControler.BackColor = Color.LightYellow;
                    txtAbnStatus.BackColor = Color.LightYellow;
                    txtAbnDateChange.BackColor = Color.LightYellow;
                }
            }
        }

        #region TREEVIEW
        #region treeViewAbn Events
        // Выделение ветки в дереве
        private void treeViewAbn_AfterSelect(object sender, TreeViewEventArgs e)
        {
            idAbnObj = -1;
            switch (e.Node.Level)
            {
                case 0: // выделили абонента
                    idAbn = GetIdFromNodeTag(e.Node.Tag);
                    LoadSelectAbn(idAbn);
                    break;
                case 1: // выделили объект
                    idAbn = GetIdFromNodeTag(e.Node.Parent.Tag);
                    LoadSelectAbn(idAbn);

                    LoadSelectAbnObj(GetIdFromNodeTag(e.Node.Tag));
                    break;
                case 2: // выдедили точку учета
                    idAbn = GetIdFromNodeTag(e.Node.Parent.Parent.Tag);
                    LoadSelectAbn(idAbn);

                    LoadSelectAbnObj(GetIdFromNodeTag(e.Node.Parent.Tag));
                    LoadSelectPoint(GetIdFromNodeTag(e.Node.Tag));
                    break;
            }
        }
        // нажатие мыши
        private void treeViewAbn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // правая кнопка
                treeViewAbn.SelectedNode = treeViewAbn.GetNodeAt(e.X, e.Y);
        }
        #endregion

        #region contextMenuTree Events
        // открытие контекстного меню
        private void contextMenuTree_Opening(object sender, CancelEventArgs e)
        {
            if (treeViewAbn.SelectedNode.Level == 0)
                toolMenuTreeAddPoint.Visible = false;
            else
                toolMenuTreeAddPoint.Visible = true;
        }
        // добавить объект
        private void toolMenuTreeAddAbnObj_Click(object sender, EventArgs e)
        {
            toolMenuItemAddAbnObj_Click(sender, e);
        }
        // добавить точку
        private void toolMenuTreeAddPoint_Click(object sender, EventArgs e)
        {
            toolMenuItemAddPoint_Click(sender, e);
        }
        // редактировать объект/точку.... абонента
        private void toolMenuTreeEdit_Click(object sender, EventArgs e)
        {
            toolBtnEditTree_Click(sender, e);
        }
        // удалить объект/точку
        private void toolMenuTreeDel_Click(object sender, EventArgs e)
        {
            toolBtnDelTree_Click(sender, e);
        }
        #endregion

        #region toolStripTree Events
        private void toolBtnAddTree_Click(object sender, EventArgs e)
        {
            if (treeViewAbn.Nodes.Count == 0)
            {
                toolMenuItemAddAbnObj.Enabled = false;
                toolMenuItemAddPoint.Enabled = false;
            }
            else
            {
                toolMenuItemAddAbnObj.Enabled = true;
                if (treeViewAbn.SelectedNode == treeViewAbn.Nodes[0])
                    toolMenuItemAddPoint.Enabled = false;
                else
                    toolMenuItemAddPoint.Enabled = true;
            }
        }
        // Добавить Объект
        private void toolMenuItemAddAbnObj_Click(object sender, EventArgs e)
        {
            FormAddEditAbnObj fAdd = new FormAddEditAbnObj(idAbn, -1, FormAddEditAbnObj.ActionAbnObj.Add,
                -1, FormAddEditAbnObj.ActionAbnObjReg.Add);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                //LoadAbonent((int)dsPrv.vAbn.Rows[0]["CodeAbonent"], typeAbn);
                LoadTreeViewAbn(treeViewAbn.SelectedNode);
            }

        }
        // Добавить точку учета
        private void toolMenuItemAddPoint_Click(object sender, EventArgs e)
        {
            int idObj = -1;
            switch (treeViewAbn.SelectedNode.Level)
            {
                case 0: // выделен абонент
                    return;
                case 1: // выделен объект
                    idObj = GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag);
                    break;
                case 2: // выделена точка учета
                    idObj = GetIdFromNodeTag(treeViewAbn.SelectedNode.Parent.Tag);
                    break;
                default: break;
            }
            FormAddEditPoint fAdd = new FormAddEditPoint(idObj, -1, FormAddEditPoint.ActionPoint.Installation, 
                -1, FormAddEditPoint.ActionMeter.Installation, -1, FormAddEditPoint.ActionTrans.Installation);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                LoadTreeViewAbn(treeViewAbn.SelectedNode);
            }
        }
        // Редактировать объект/точку
        private void toolBtnEditTree_Click(object sender, EventArgs e)
        {
            if (treeViewAbn.SelectedNode != null)
            {
                switch (treeViewAbn.SelectedNode.Level)
                {
                    case 0: // редактировать абонента
                        if ((toolBtnAbnEdit.Visible) && (toolBtnAbnEdit.Enabled))
                            toolBtnAbnEdit_Click(sender, e);
                        break;
                    case 1: // редактировать объект
                        int idReg = (dsPrv.vAbnObjRegLast.Rows[0]["Id"] == DBNull.Value) ? -1 : Convert.ToInt32(dsPrv.vAbnObjRegLast.Rows[0]["Id"]);
                        FormAddEditAbnObj fEdit = new FormAddEditAbnObj(GetIdFromNodeTag(treeViewAbn.Nodes[0].Tag),
                            GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag), FormAddEditAbnObj.ActionAbnObj.Edit, idReg, FormAddEditAbnObj.ActionAbnObjReg.Edit);
                        fEdit.SqlSettings = this.SqlSettings;
                        if (fEdit.ShowDialog() == DialogResult.OK)
                        {
                            LoadTreeViewAbn(treeViewAbn.SelectedNode);
                        }
                        break;
                    case 2: //редактировать точку
                        FormAddEditPoint fEditPoint = new FormAddEditPoint(GetIdFromNodeTag(treeViewAbn.SelectedNode.Parent.Tag),
                            GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag), FormAddEditPoint.ActionPoint.Edit,
                            -1, FormAddEditPoint.ActionMeter.Read, -1, FormAddEditPoint.ActionTrans.Read);
                        fEditPoint.SqlSettings = this.SqlSettings;
                        if (fEditPoint.ShowDialog() == DialogResult.OK)
                        {
                            LoadTreeViewAbn(treeViewAbn.SelectedNode);
                        }
                        break;
                    default: break;
                }
            }
        }
        // Удалить объект/точку
        private void toolBtnDelTree_Click(object sender, EventArgs e)
        {
            if (treeViewAbn.SelectedNode != null)
            {
                switch (treeViewAbn.SelectedNode.Level)
                {
                    case 1: // удалить объект
                        if (MessageBox.Show("Вы действительно хотите удалить выбранный объект?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MessageBox.Show("На данный момент функция недоступна! Воспользуйтесь функцией открепления объекта или обратитесь к администратору.");
                            //if (this.DeleteSqlDataById(dsPrv.tAbnObj, GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag)))
                            //{
                            //    MessageBox.Show("Объект успешно удален");
                            //    LoadTreeViewAbn(null);
                            //}

                        }
                        break;
                    case 2: // удалить точку
                        if (MessageBox.Show("Вы действительно хотите удалить выбранную точку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (this.DeleteSqlDataById(dsPrv.tPoint, GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag)))
                            {
                                MessageBox.Show("Точка учета успешно удалена");
                                LoadTreeViewAbn(null);
                            }
                        }
                        break;
                    default: break;
                }
            }

        }
        // Просмотр объекта точки (может еще абонента)
        private void toolBtnInfoTree_Click(object sender, EventArgs e)
        {
            if (treeViewAbn.SelectedNode != null)
            {
                switch (treeViewAbn.SelectedNode.Level)
                {
                    case 1: // просмотр объекта
                        int idReg = (dsPrv.vAbnObjRegLast.Rows[0]["Id"] == DBNull.Value) ? -1 : Convert.ToInt32(dsPrv.vAbnObjRegLast.Rows[0]["Id"]);
                        FormAddEditAbnObj f = new FormAddEditAbnObj(GetIdFromNodeTag(treeViewAbn.Nodes[0].Tag),
                            GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag), FormAddEditAbnObj.ActionAbnObj.Read, idReg, FormAddEditAbnObj.ActionAbnObjReg.Read);
                        f.SqlSettings = this.SqlSettings;
                        f.MdiParent = this.MdiParent;
                        f.Show();
                        break;
                    case 2: // просмотр точки
                        break;
                    default: break;
                }
            }
        }
        #endregion

        // Получить id выделенного обеъкта
        private int GetIdSelectedAbnObj()
        {
            int idObj = -1;
            switch (treeViewAbn.SelectedNode.Level)
            {
                case 1: // выделен объект
                    idObj = GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag);
                    break;
                case 2: // выделена точка учета
                    idObj = GetIdFromNodeTag(treeViewAbn.SelectedNode.Parent.Tag);
                    break;
                default: break;
            }
            return idObj;
        }
        // Получить id выделенной точки
        private int GetIdSelectedPoint()
        {
            int idPoint = -1;
            switch (treeViewAbn.SelectedNode.Level)
            {
                case 2: // выделена точка учета
                    idPoint = GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag);
                    break;
                default: break;
            }
            return idPoint;
        }
        #endregion

        #region TABCONTROLMAIN Events
        #region TabPageDocAct
        #region toolStripDocACt
        // Добавить документ
        private void toolBtnDocActAdd_Click(object sender, EventArgs e)
        {
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                FormAddEditDocAct fAdd = new FormAddEditDocAct(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                    idPoint, -1, FormAddEditDocAct.ActionDocAct.Add);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsPrv, dsPrv.vDocAct, true, "where idPoint = " + idPoint.ToString() + " order by DateAct desc");
                }
            }
        }
        // редактировать документ
        private void toolBtnDocActEdit_Click(object sender, EventArgs e)
        {
            if (dgvDocAct.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для редактирования");
                return;
            }
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                int idDoc = Convert.ToInt32(dgvDocAct.CurrentRow.Cells["idDocActDgvTxtColumn"].Value);
                FormAddEditDocAct fAdd = new FormAddEditDocAct(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                    idPoint, idDoc, FormAddEditDocAct.ActionDocAct.Edit);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsPrv, dsPrv.vDocAct, true, "where idPoint = " + idPoint.ToString() + " order by DateAct desc");
                    dgvDocAct.SearchGrid("idDocActDgvtxtColumn", idDoc.ToString()); // позиционирование в гриде
                }
            }
        }
        // удалить документ
        private void toolBtnDocActDel_Click(object sender, EventArgs e)
        {
            if (dgvDocAct.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для удаления");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idDoc = Convert.ToInt32(dgvDocAct.CurrentRow.Cells["idDocActDgvTxtColumn"].Value);
                if (this.DeleteSqlDataById(dsPrv.tDocAct, idDoc))
                {
                    dsPrv.vDocAct.Rows.Find(idDoc).Delete();
                }
            }
            
        }
        // просмотр документа
        private void toolBtnDocActInfo_Click(object sender, EventArgs e)
        {
            if (dgvDocAct.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для просмтора");
                return;
            }
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                int idDoc = Convert.ToInt32(dgvDocAct.CurrentRow.Cells["idDocActDgvTxtColumn"].Value);
                FormAddEditDocAct fAdd = new FormAddEditDocAct(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                    idPoint, idDoc, FormAddEditDocAct.ActionDocAct.Read);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.MdiParent = this.MdiParent;
                fAdd.Show();
            }

        }
        #endregion
        #region DgvDocAct Events
        // нажатие клавиши по гриду
        private void dgvDocAct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.PageDown)
                e.SuppressKeyPress = true;
            if (!e.Control && e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
        // двойной клик
        private void dgvDocAct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                toolBtnDocActEdit_Click(sender, e);
            }
        }
        // клик мышки по ячейки грида
        private void dgvDocAct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                this.dgvDocAct.Rows[e.RowIndex].Selected = true;
                ///-----------
                if (toolBtnEditTree.Visible == true) this.contextMenuDocAct.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        // клик мышки по гриду
        private void dgvDocAct_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right/* && e.RowIndex >= 0*/) // если правой кнопкой
            {
                DataGridView.HitTestInfo hitTestInfo = dgvDocAct.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.None)
                    if (toolBtnEditTree.Visible == true) this.contextMenuDocAct.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        // форматирование ячейки
        private void dgvDocAct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((int)dgvDocAct["idDocTypeDgvTxtColumn", e.RowIndex].Value == (int)Constants.DocType.ActKO)
                    e.CellStyle.BackColor = Color.WhiteSmoke;
                if (((int)dgvDocAct["idDocTypeDgvTxtColumn", e.RowIndex].Value == (int)Constants.DocType.ActUst) ||
                    ((int)dgvDocAct["idDocTypeDgvTxtColumn", e.RowIndex].Value == (int)Constants.DocType.ActDem))
                    e.CellStyle.ForeColor = Color.Blue;
                if ((int)dgvDocAct["idDocTypeDgvTxtColumn", e.RowIndex].Value == (int)Constants.DocType.ActPerehod)
                    e.CellStyle.ForeColor = Color.Green; ;
            }
        }
        #endregion
        #region ContextMenuDocAct
        // добавить документ
        private void toolMenuItemDocActAdd_Click(object sender, EventArgs e)
        {
            toolBtnDocActAdd_Click(sender, e);
        }
        // изменить документ
        private void toolMenuItemDocActEdit_Click(object sender, EventArgs e)
        {
            toolBtnDocActEdit_Click(sender, e);
        }
        // просмотр документа
        private void toolMenuItemDocActInfo_Click(object sender, EventArgs e)
        {
            toolBtnDocActInfo_Click(sender, e);
        }
        // удалить документ
        private void toolMenuItemDocActDel_Click(object sender, EventArgs e)
        {
            toolBtnDocActDel_Click(sender, e);
        }
        #endregion
        #endregion
        #region TabPageAbnObj Events
        #region toolStripAbnObj Events
        // Получить id текущего объекта
        private int GetIdCurrentAbnObj()
        {
            int idAbnObj = -1;
            switch (treeViewAbn.SelectedNode.Level)
            {
                case 1: // выделили объект
                    idAbnObj = GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag);
                    break;
                case 2: // выдедили точку учета
                    idAbnObj = GetIdFromNodeTag(treeViewAbn.SelectedNode.Parent.Tag);
                    break;
                default: break;
            }
            return idAbnObj;
        }
        // добавить, редактировать, посмотреть хар-ку объекта
        private void InsUpdReadObjReg(FormAddEditAbnObj.ActionAbnObjReg act)
        {
            int idAbn = GetIdFromNodeTag(treeViewAbn.Nodes[0].Tag);
            int idAbnObj = GetIdCurrentAbnObj();
            if (idAbnObj == -1)
            {
                MessageBox.Show("Не выделено ни одного объекта");
                return;
            }
            if (act != FormAddEditAbnObj.ActionAbnObjReg.Add)
                if (dgvAbnObjReg.CurrentRow == null)
                {
                    MessageBox.Show("Не выбрана запись для редактирования");
                    return;
                }

            FormAddEditAbnObj f = new FormAddEditAbnObj(idAbn, idAbnObj, FormAddEditAbnObj.ActionAbnObj.Read,
                (int)dgvAbnObjReg.CurrentRow.Cells["idAbnObjRegDgvTxtColumn"].Value, act);
            f.SqlSettings = this.SqlSettings;
            if (act == FormAddEditAbnObj.ActionAbnObjReg.Read)
            {
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadTreeViewAbn(treeViewAbn.SelectedNode);
                }
        }
        // Добавить новую характеристику объекта
        private void toolBtnObjRegAdd_Click(object sender, EventArgs e)
        {
            InsUpdReadObjReg(FormAddEditAbnObj.ActionAbnObjReg.Add);
        }
        // Редактировать хар-ку объекта
        private void toolBtnObjRegEdit_Click(object sender, EventArgs e)
        {
            InsUpdReadObjReg(FormAddEditAbnObj.ActionAbnObjReg.Edit);
        }
        // удалить хар-ку
        private void toolBtnObjRegDel_Click(object sender, EventArgs e)
        {
            if (dgvAbnObjReg.CurrentRow == null)
            {
                MessageBox.Show("Не выбрана запись для удаления");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.DeleteSqlDataById(dsPrv.tAbnObjReg, (int)dgvAbnObjReg.CurrentRow.Cells["idAbnObjRegDgvTxtColumn"].Value))
                {
                    LoadTreeViewAbn(treeViewAbn.SelectedNode);
                    MessageBox.Show("Данные успешно удалены");
                }
            }
        }
        // просмотр
        private void toolBtnObjRegInfo_Click(object sender, EventArgs e)
        {
            InsUpdReadObjReg(FormAddEditAbnObj.ActionAbnObjReg.Read);
        }
        #endregion


        #endregion
        #region TabPagePointReg Events
        #region toolStripPointReg
        // добавление новго счетчика/трансформатора
        private void toolBtnPointRegAdd_Click(object sender, EventArgs e)
        {
            if (tabControlPointReg.SelectedTab == tabPageCounter)  // новый счетчик
            {
                DataRow[] dr = dsPrv.vPointReg.Select(" Type <> " + ((int)Constants.DevicePointType.TransAmperage).ToString(), "DateBegin desc");
                if (dr.Length > 0)
                    if (dr[0]["DateEnd"] == DBNull.Value)  // не демонтирован предыдущий счетчик
                    {
                        MessageBox.Show("Для начала нужно демонтировать предыдущий счетчик");
                        return;
                    }
                int idObj = GetIdSelectedAbnObj();
                int idPoint = GetIdSelectedPoint();
                if ((idObj > 0) && (idPoint > 0))
                {
                    FormAddEditPoint fAdd = new FormAddEditPoint(idObj, idPoint, FormAddEditPoint.ActionPoint.Read,
                        -1, FormAddEditPoint.ActionMeter.Installation, -1, FormAddEditPoint.ActionTrans.Read);
                    if (dr.Length > 0)
                        fAdd.MinDateCounterUst = Convert.ToDateTime(dr[0]["dateEnd"]);
                    fAdd.SqlSettings = this.SqlSettings;
                    if (fAdd.ShowDialog() == DialogResult.OK)
                    {
                        LoadTreeViewAbn(treeViewAbn.SelectedNode);
                    //    this.SelectSqlData(dsPrv, dsPrv.tAbnObjReg, true, " where idAbnObj = " + idObj.ToString() + " order by DateChange desc");
                        LoadSelectPoint(idPoint);
                    }
                }
            }
            if (tabControlPointReg.SelectedTab == tabPageTrans) // новый трансформатор
            {
                DataRow[] dr = dsPrv.vPointReg.Select(" Type = " + ((int)Constants.DevicePointType.TransAmperage).ToString(), "DateBegin desc");
                if (dr.Length > 0)
                    if (dr[0]["DateEnd"] == DBNull.Value)  // не демонтирован предыдущий трансформатор
                    {
                        MessageBox.Show("Для начала нужно демонтировать предыдущий трансформатор");
                        return;
                    }
                int idObj = GetIdSelectedAbnObj();
                int idPoint = GetIdSelectedPoint();
                if ((idObj > 0) && (idPoint > 0))
                {
                    FormAddEditPoint fAdd = new FormAddEditPoint(idObj, idPoint, FormAddEditPoint.ActionPoint.Read,
                        -1, FormAddEditPoint.ActionMeter.Read, -1, FormAddEditPoint.ActionTrans.Installation);
                    if (dr.Length > 0)
                        fAdd.MinDateTransUst = Convert.ToDateTime(dr[0]["dateEnd"]);
                    fAdd.SqlSettings = this.SqlSettings;
                    if (fAdd.ShowDialog() == DialogResult.OK)
                    {
                        LoadSelectPoint(idPoint);
                        //LoadTreeViewAbn(treeViewAbn.SelectedNode);
                    }
                }
            }
        }
        // демонтаж счечткиа/трансформатора
        private void toolStripMenuItemCounterDeinstall_Click(object sender, EventArgs e)
        {
            #region счетчик
            if (tabControlPointReg.SelectedTab == tabPageCounter)  // новый счетчик
            {
                if (dgvCounter.CurrentRow == null)
                {
                    MessageBox.Show("Не выбран счетчик для демонтажа");
                    return;
                }
                if (dgvCounter.CurrentRow.Cells["dateEndCounterDgvTxtColumn"].Value != DBNull.Value)
                {
                    MessageBox.Show("Данный счетчик уже демонтирован");
                    return;
                }

                int idObj = GetIdSelectedAbnObj();
                int idPoint = GetIdSelectedPoint();
                if ((idObj > 0) && (idPoint > 0))
                {
                    int idCounter = Convert.ToInt32(dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value);
                    FormAddEditPoint fDem = new FormAddEditPoint(idObj, idPoint, FormAddEditPoint.ActionPoint.Read,
                        idCounter, FormAddEditPoint.ActionMeter.Deinstallation, -1, FormAddEditPoint.ActionTrans.Read);
                    fDem.SqlSettings = this.SqlSettings;
                    if (fDem.ShowDialog() == DialogResult.OK)
                    {
                        LoadSelectPoint(idPoint);
                    }
                }
            }
            #endregion
            #region трансформатор
            if (tabControlPointReg.SelectedTab == tabPageTrans) // новый трансформатор
            {
                if (dgvTrans.CurrentRow == null)
                {
                    MessageBox.Show("Не выбран трансформатор для демонтажа");
                    return;
                }
                if (dgvTrans.CurrentRow.Cells["dateEndTransDgvTxtColumn"].Value != DBNull.Value)
                {
                    MessageBox.Show("Данный трансформатор уже демонтирован");
                    return;
                }
                int idObj = GetIdSelectedAbnObj();
                int idPoint = GetIdSelectedPoint();
                if ((idObj > 0) && (idPoint > 0))
                {
                    int idTrans = Convert.ToInt32(dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value);
                    FormAddEditPoint fDem = new FormAddEditPoint(idObj, idPoint, FormAddEditPoint.ActionPoint.Read,
                        -1, FormAddEditPoint.ActionMeter.Read, idTrans, FormAddEditPoint.ActionTrans.Deinstallation);
                    fDem.SqlSettings = this.SqlSettings;
                    if (fDem.ShowDialog() == DialogResult.OK)
                    {
                        LoadSelectPoint(idPoint);
                        //LoadTreeViewAbn(treeViewAbn.SelectedNode);
                    }
                }
            }
            #endregion
        }
        // редактировать счетчик/трансформатор
        private void toolMenuItemCounterEdit_Click(object sender, EventArgs e)
        {
            #region counter
            if (tabControlPointReg.SelectedTab == tabPageCounter)  // новый счетчик
            {
                if (dgvCounter.CurrentRow == null)
                {
                    MessageBox.Show("Не выбран счетчик для редактирования");
                    return;
                }

                int idObj = GetIdSelectedAbnObj();
                int idPoint = GetIdSelectedPoint();
                if ((idObj > 0) && (idPoint > 0))
                {
                    int idCounter = Convert.ToInt32(dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value);
                    FormAddEditPoint fDem = new FormAddEditPoint(idObj, idPoint, FormAddEditPoint.ActionPoint.Edit,
                        idCounter, FormAddEditPoint.ActionMeter.Edit, -1, FormAddEditPoint.ActionTrans.Edit);
                    fDem.SqlSettings = this.SqlSettings;
                    if (fDem.ShowDialog() == DialogResult.OK)
                    {
                        LoadTreeViewAbn(treeViewAbn.SelectedNode);
                    }
                }
            }
            #endregion
            #region transformator
            if (tabControlPointReg.SelectedTab == tabPageTrans) // новый трансформатор
            {
                if (dgvTrans.CurrentRow == null)
                {
                    MessageBox.Show("Не выбран трансформатор для редактиования");
                    return;
                }
                int idObj = GetIdSelectedAbnObj();
                int idPoint = GetIdSelectedPoint();
                if ((idObj > 0) && (idPoint > 0))
                {
                    int idTrans = Convert.ToInt32(dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value);
                    FormAddEditPoint fDem = new FormAddEditPoint(idObj, idPoint, FormAddEditPoint.ActionPoint.Read,
                        -1, FormAddEditPoint.ActionMeter.Read, idTrans, FormAddEditPoint.ActionTrans.Edit);
                    fDem.SqlSettings = this.SqlSettings;
                    if (fDem.ShowDialog() == DialogResult.OK)
                    {
                        LoadTreeViewAbn(treeViewAbn.SelectedNode);
                    }
                }
            }
            #endregion
        }
        // удалить счетчик/трансформатор
        private void toolBtnCounterDel_Click(object sender, EventArgs e)
        {
            #region Counter
            if (tabControlPointReg.SelectedTab == tabPageCounter)  // счетчик
            {
                if (dgvCounter.CurrentRow == null)
                {
                    MessageBox.Show("Не выбран счетчик для удаления");
                    return;
                }

                if (Convert.ToInt32(dsPrv.vPointReg.Select(" Type <> " + ((int)Constants.DevicePointType.TransAmperage).ToString(), "DateBegin desc")[0]["id"]) !=
                    Convert.ToInt32(dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value))
                {
                    MessageBox.Show("Удалить можно только последнюю запись");
                    return;
                }

                if (MessageBox.Show("Вы действительно хотите удалить данный счетчик",
                    "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idCounter = Convert.ToInt32(dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value);
                    if (this.DeleteSqlDataById(dsPrv.tPointReg, idCounter))
                        LoadTreeViewAbn(treeViewAbn.SelectedNode);
                }
            }
            #endregion
            #region Transformator
            if (tabControlPointReg.SelectedTab == tabPageTrans)
            {
                if (dgvTrans.CurrentRow == null)
                {
                    MessageBox.Show("Не выбран трансформатор для удаления");
                    return;
                }

                if (Convert.ToInt32(dsPrv.vPointReg.Select(" Type = " + ((int)Constants.DevicePointType.TransAmperage).ToString(), "DateBegin desc")[0]["id"]) !=
                    Convert.ToInt32(dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value))
                {
                    MessageBox.Show("Удалить можно только последнюю запись");
                    return;
                }

                if (MessageBox.Show("Вы действительно хотите удалить данный трансформатор?",
                    "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idTrans = Convert.ToInt32(dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value);
                    if (this.DeleteSqlDataById(dsPrv.tPointReg, idTrans))
                        LoadTreeViewAbn(treeViewAbn.SelectedNode);
                }
            }
            #endregion
        }
        // Просмотр счетчика/трансформатора
        private void toolBtnCounterInfo_Click(object sender, EventArgs e)
        {
            #region Counter
            if (tabControlPointReg.SelectedTab == tabPageCounter)  // счетчик
            {
                if (dgvCounter.CurrentRow == null)
                {
                    MessageBox.Show("Не выбран счетчик для просмотра");
                    return;
                }
                int idObj = GetIdSelectedAbnObj();          // id Объекта
                int idPoint = GetIdSelectedPoint();         // id точки
                if ((idObj > 0) && (idPoint > 0))
                {
                    int idCounter = Convert.ToInt32(dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value);
                    FormAddEditPoint fInfo = new FormAddEditPoint(idObj, idPoint, FormAddEditPoint.ActionPoint.Read,
                        idCounter, FormAddEditPoint.ActionMeter.Read, -1, FormAddEditPoint.ActionTrans.Read);
                    fInfo.SqlSettings = this.SqlSettings;
                    fInfo.MdiParent = this.MdiParent;
                    fInfo.Show();
                }
            }
            #endregion
            #region Transformator
            if (tabControlPointReg.SelectedTab == tabPageTrans)
            {
                if (dgvTrans.CurrentRow == null)
                {
                    MessageBox.Show("Не выбран трансформатор для просмотра");
                    return;
                }
                int idObj = GetIdSelectedAbnObj();          // id Объекта
                int idPoint = GetIdSelectedPoint();         // id точки
                if ((idObj > 0) && (idPoint > 0))
                {
                    int idTrans = Convert.ToInt32(dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value);
                    FormAddEditPoint fInfo = new FormAddEditPoint(idObj, idPoint, FormAddEditPoint.ActionPoint.Read,
                        -1, FormAddEditPoint.ActionMeter.Read, idTrans, FormAddEditPoint.ActionTrans.Read);
                    fInfo.SqlSettings = this.SqlSettings;
                    fInfo.MdiParent = this.MdiParent;
                    fInfo.Show();
                }
            }
            #endregion
        }
        #endregion
        #region dgvCounter Events
        private void dgvCounter_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCounter.CurrentRow != null)
            {
                GetCheckDateCounterKvartalAndYear(dgvCounter.CurrentRow.Cells["dateCheckCounterDgvTxtColumn"].Value);
                bindingSourceCounterPlomb.Filter = " idPointReg = " + dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value.ToString();
            }
            else
                GetCheckDateCounterKvartalAndYear("");

        }
        private void GetCheckDateCounterKvartalAndYear(object value)
        {
            if (value != null)
            {
                if (!String.IsNullOrEmpty(value.ToString()))
                {
                    DateTime checkDate = Convert.ToDateTime(value);
                    txtCounterDateCheckYear.Text = checkDate.Year.ToString();
                    switch (checkDate.Month)
                    {
                        case 1:
                        case 2:
                        case 3: txtCounterDateCheckKvartal.Text = "I"; // первый квартал
                            break;
                        case 4:
                        case 5:
                        case 6: txtCounterDateCheckKvartal.Text = "II";  // второй квартал
                            break;
                        case 7:
                        case 8:
                        case 9: txtCounterDateCheckKvartal.Text = "III";  // третий квартал
                            break;
                        case 10:
                        case 11:
                        case 12: txtCounterDateCheckKvartal.Text = "IV";  // четвертый квартал
                            break;
                    }
                }
                else
                {
                    txtCounterDateCheckKvartal.Text = "";
                    txtCounterDateCheckYear.Text = "";
                }
            }
            else
            {
                txtCounterDateCheckKvartal.Text = "";
                txtCounterDateCheckYear.Text = "";
            }
        }
        private void dgvCounter_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvCounter.CurrentRow != null)                
        }
        // Двойной клик по ячейки
        private void dgvCounter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                toolMenuItemCounterEdit_Click(sender, e); // редактирование
            }
        }
        // форматирование ячеек
        private void dgvCounter_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCounter["dateEndCounterDgvTxtColumn", e.RowIndex].Value != DBNull.Value)
                    e.CellStyle.BackColor = Color.Gainsboro;
            }
        }
        // Клик по ячейки грида
        private void dgvCounter_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                this.dgvCounter.Rows[e.RowIndex].Selected = true;
                ///-----------
                if (toolBtnEditTree.Visible == true) this.contextMenuPointReg.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        // клик мыши по гриду
        private void dgvCounter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // если правой кнопкой
            {
                DataGridView.HitTestInfo hitTestInfo = dgvCounter.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.None)
                    if (toolBtnEditTree.Visible == true) this.contextMenuPointReg.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        #endregion
        #region ContextMenuPointReg контекстное меню грида приборов учета
        // добавить прибор
        private void toolMenuItemPointRegAdd_Click(object sender, EventArgs e)
        {
            toolBtnPointRegAdd_Click(sender, e);
        }
        // редактировать приборн учета
        private void toolMenuItemPointRegEdit_Click(object sender, EventArgs e)
        {
            toolMenuItemCounterEdit_Click(sender, e);
        }
        // демонтировать прибор учета
        private void toolMenuItemPointRegDem_Click(object sender, EventArgs e)
        {
            toolStripMenuItemCounterDeinstall_Click(sender, e);
        }
        // просмотр прибора учета
        private void toolMenuItemPointRegInfo_Click(object sender, EventArgs e)
        {
            toolBtnCounterInfo_Click(sender, e);
        }
        // удалить прибор учета
        private void toolMenuItemPointRegDel_Click(object sender, EventArgs e)
        {
            toolBtnCounterDel_Click(sender, e);
        }
        #endregion
        #region dgvTrans Events
        private void dgvTrans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTrans.CurrentRow != null)
            {
                GetCheckDateTransKvartalAndYear(dgvTrans.CurrentRow.Cells["dateCheckTransDgvTxtColumn"].Value);
                bindingSourceTransPlomb.Filter = " idPointReg = " + dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value.ToString();
            }
            else
                GetCheckDateTransKvartalAndYear("");
        }
        private void GetCheckDateTransKvartalAndYear(object value)
        {
            if (value != null)
            {
                if (!String.IsNullOrEmpty(value.ToString()))
                {
                    DateTime checkDate = Convert.ToDateTime(value);
                    txtTransDateCheckYear.Text = checkDate.Year.ToString();
                    switch (checkDate.Month)
                    {
                        case 1:
                        case 2:
                        case 3: txtTransDateCheckKvartal.Text = "I"; // первый квартал
                            break;
                        case 4:
                        case 5:
                        case 6: txtTransDateCheckKvartal.Text = "II";  // второй квартал
                            break;
                        case 7:
                        case 8:
                        case 9: txtTransDateCheckKvartal.Text = "III";  // третий квартал
                            break;
                        case 10:
                        case 11:
                        case 12: txtTransDateCheckKvartal.Text = "IV";  // четвертый квартал
                            break;
                    }
                }
                else
                {
                    txtTransDateCheckKvartal.Text = "";
                    txtTransDateCheckYear.Text = "";
                }
            }
            else
            {
                txtTransDateCheckKvartal.Text = "";
                txtTransDateCheckYear.Text = "";
            }
        }
        #endregion

        #region dgvCounterPlomb 
        private void dgvCounterPlomb_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvCounterPlomb.RowCount > 0) && (e.RowIndex >= 0))
            {
                if (dgvCounterPlomb["dateDemCounterDgvTxtColumn", e.RowIndex].Value != DBNull.Value)
                    e.CellStyle.ForeColor = Color.Red;
            }
        }
        private void dgvCounterPlomb_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                //dgvCounterPlomb.Rows[e.RowIndex].Selected = true;
                dgvCounterPlomb.CurrentCell = dgvCounterPlomb[0, e.RowIndex];

                toolMenuItemCouterPlombEdit.Enabled = true;
                if (dgvCounterPlomb.CurrentRow.Cells["dateDemCounterDgvTxtColumn"].Value == DBNull.Value)
                    toolMenuItemCouterPlombDem.Enabled = true;
                else
                    toolMenuItemCouterPlombDem.Enabled = false;
                toolMenuItemCouterPlombDel.Enabled = true;


                if (toolBtnEditTree.Visible == true) contextMenuPlomb.Show(System.Windows.Forms.Cursor.Position);
            }

        }
        private void dgvCounterPlomb_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                toolMenuItemCouterPlombEdit.Enabled = false;
                toolMenuItemCouterPlombDem.Enabled = false;
                toolMenuItemCouterPlombDel.Enabled = false;
                if (toolBtnEditTree.Visible == true) contextMenuPlomb.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        #endregion
        #region contextMenuPlomb
        // Установка пломбы
        private void toolMenuItemCouterPlombUst_Click(object sender, EventArgs e)
        {
            int idPointReg;
            if (tabControlPointReg.SelectedTab  == tabPageCounter)
                idPointReg = Convert.ToInt32(dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value);
            else
                idPointReg = Convert.ToInt32(dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value);
            Plombs.FormPlombUstDemEdit fAdd = new Prv.Forms.Plombs.FormPlombUstDemEdit(Prv.Forms.Plombs.FormPlombUstDemEdit.ActionPlomb.Installation,
                -1, idPointReg);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                LoadPlombs();
            }
        }
        // Редактирование пломбы
        private void toolMenuItemCouterPlombEdit_Click(object sender, EventArgs e)
        {
            int idPointReg;
            int idPlomb;
            if (tabControlPointReg.SelectedTab == tabPageCounter)
            {   //счетчик
                idPointReg = Convert.ToInt32(dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value);
                idPlomb = Convert.ToInt32(dgvCounterPlomb.CurrentRow.Cells["idPUstDgvTxtColumn"].Value);
            }
            else
            {   //трансформатор
                idPointReg = Convert.ToInt32(dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value);
                idPlomb = Convert.ToInt32(dgvTransPlomb.CurrentRow.Cells["idPlombTransDgvTxtColumn"].Value);
            }
            Plombs.FormPlombUstDemEdit fDem = new Prv.Forms.Plombs.FormPlombUstDemEdit(Prv.Forms.Plombs.FormPlombUstDemEdit.ActionPlomb.Edit,
                  idPlomb, idPointReg);
            fDem.SqlSettings = this.SqlSettings;
            if (fDem.ShowDialog() == DialogResult.OK)
            {
                LoadPlombs();
            }

        }
        // Демонтаж пломбы
        private void toolMenuItemCouterPlombDem_Click(object sender, EventArgs e)
        {
            int idPointReg;
            int idPlomb;
            if (tabControlPointReg.SelectedTab == tabPageCounter)
            {   //счетчик
                idPointReg = Convert.ToInt32(dgvCounter.CurrentRow.Cells["idCounterDgvTxtColumn"].Value);
                idPlomb = Convert.ToInt32(dgvCounterPlomb.CurrentRow.Cells["idPUstDgvTxtColumn"].Value);
            }
            else
            {   //трансформатор
                idPointReg = Convert.ToInt32(dgvTrans.CurrentRow.Cells["idTransDgvTxtColumn"].Value);
                idPlomb = Convert.ToInt32(dgvTransPlomb.CurrentRow.Cells["idPlombTransDgvTxtColumn"].Value);
            }
            Plombs.FormPlombUstDemEdit fDem = new Prv.Forms.Plombs.FormPlombUstDemEdit(Prv.Forms.Plombs.FormPlombUstDemEdit.ActionPlomb.Deinstallation,
               idPlomb, idPointReg);
            fDem.SqlSettings = this.SqlSettings;
            if (fDem.ShowDialog() == DialogResult.OK)
            {
                LoadPlombs();
            }
        }
        // Удалить установленную пломбу
        private void toolMenuItemCouterPlombDel_Click(object sender, EventArgs e)
        {
            int idPlomb;
            if (tabControlPointReg.SelectedTab == tabPageCounter)   //счетчик
                idPlomb = Convert.ToInt32(dgvCounterPlomb.CurrentRow.Cells["idPUstDgvTxtColumn"].Value);
            else   //трансформатор
                idPlomb = Convert.ToInt32(dgvTransPlomb.CurrentRow.Cells["idPlombTransDgvTxtColumn"].Value);

            if (MessageBox.Show("Вы действительно хотите удалить текущую пломбу?", "Удаление", MessageBoxButtons.YesNo) 
                == DialogResult.Yes)
                if (this.DeleteSqlDataById(new DataSets.DataSetPlomb().tPlomb, idPlomb))
                {
                    LoadPlombs();
                    MessageBox.Show("Пломба успешно удалена");
                }
        }
        #endregion

        #region dgvTransPlomb
        private void dgvTransPlomb_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvTransPlomb.RowCount > 0) && (e.RowIndex >= 0))
            {
                if (dgvTransPlomb["dataDemTransPlombDgvTxtColumn", e.RowIndex].Value != DBNull.Value)
                    e.CellStyle.ForeColor = Color.Red;
            }
        }
        private void dgvTransPlomb_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                //dgvCounterPlomb.Rows[e.RowIndex].Selected = true;
                dgvTransPlomb.CurrentCell = dgvTransPlomb[0, e.RowIndex];

                toolMenuItemCouterPlombEdit.Enabled = true;
                if (dgvTransPlomb.CurrentRow.Cells["dataDemTransPlombDgvTxtColumn"].Value == DBNull.Value)
                    toolMenuItemCouterPlombDem.Enabled = true;
                else
                    toolMenuItemCouterPlombDem.Enabled = false;
                toolMenuItemCouterPlombDel.Enabled = true;


                if (toolBtnEditTree.Visible == true) contextMenuPlomb.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        private void dgvTransPlomb_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                toolMenuItemCouterPlombEdit.Enabled = false;
                toolMenuItemCouterPlombDem.Enabled = false;
                toolMenuItemCouterPlombDel.Enabled = false;
                if (toolBtnEditTree.Visible == true) contextMenuPlomb.Show(System.Windows.Forms.Cursor.Position);
            }
        }
        #endregion
        #endregion
        #region TabPageAbnContact
        #region toolstripAbnContact EVents
        // добавить контактную информацию
        private void tooBtnAbnContactAdd_Click(object sender, EventArgs e)
        {
            FormAddEditAbnContact fAdd = new FormAddEditAbnContact(Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]),
                -1, FormAddEditAbnContact.ActionAbnContact.Add);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsPrv, dsPrv.vAbn, true, " where id = " + dsPrv.vAbn.Rows[0]["id"].ToString());
                    // загрузка контактно инфо
                    this.SelectSqlData(dsPrv, dsPrv.tAbnContact, true, "where idAbn = " + dsPrv.vAbn.Rows[0]["id"].ToString() +
                        " order by DateChange desc");
                }
        }
        // редактировать контактную информацию
        private void tooBtnAbnContactEdit_Click(object sender, EventArgs e)
        {
            if (dgvAbnContact.CurrentRow == null)
            {
                MessageBox.Show("Не выбрана запись для редактирования");
                return;
            }
            int idContact = Convert.ToInt32(dgvAbnContact.CurrentRow.Cells["idAbnContactDgvTxtColumn"].Value);
            FormAddEditAbnContact fAdd = new FormAddEditAbnContact(Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]),
               idContact, FormAddEditAbnContact.ActionAbnContact.Edit);
            fAdd.SqlSettings = this.SqlSettings;
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsPrv, dsPrv.vAbn, true, " where id = " + dsPrv.vAbn.Rows[0]["id"].ToString());
                // загрузка контактно инфо
                this.SelectSqlData(dsPrv, dsPrv.tAbnContact, true, "where idAbn = " + dsPrv.vAbn.Rows[0]["id"].ToString() +
                    " order by DateChange desc");
            }
        }
        // удалить конт инфо
        private void tooBtnAbnContactDel_Click(object sender, EventArgs e)
        {
            if (dgvAbnContact.CurrentRow == null)
            {
                MessageBox.Show("Не выбрана запись для удаления");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить текущую контактную информацию?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idContact = Convert.ToInt32(dgvAbnContact.CurrentRow.Cells["idAbnContactDgvTxtColumn"].Value);

                DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
                this.SelectSqlData(ds.tAbnContact, true, "where idAbn = " + dsPrv.vAbn.Rows[0]["id"].ToString().ToString() + " order by datechange desc", null, false, 2);
                if (Convert.ToInt32(ds.tAbnContact.Rows[0]["id"]) == idContact)
                {
                    this.SelectSqlData(ds, ds.tAbn, true, "where id = " + dsPrv.vAbn.Rows[0]["id"].ToString().ToString());
                    if (ds.tAbnContact.Rows.Count == 2)
                        ds.tAbn.Rows[0]["Name"] = ds.tAbnContact.Rows[1]["F"].ToString() + " " +
                            ds.tAbnContact.Rows[1]["I"].ToString() + " " + ds.tAbnContact.Rows[1]["O"].ToString();
                    else
                        ds.tAbn.Rows[0]["Name"] = "";
                    ds.tAbn.Rows[0].EndEdit();

                    if (this.UpdateSqlData(ds, ds.tAbn))
                        this.SelectSqlData(dsPrv, dsPrv.vAbn, true, " where id = " + dsPrv.vAbn.Rows[0]["id"].ToString());
                }
                if (this.DeleteSqlDataById(dsPrv.tAbnContact, idContact))
                {
                    dsPrv.tAbnContact.Rows.Find(idContact).Delete();
                }
            }

        }
        // просмогтр кон инфо
        private void tooBtnAbnContactInfo_Click(object sender, EventArgs e)
        {
            if (dgvAbnContact.CurrentRow == null)
            {
                MessageBox.Show("Не выбрана запись для просмотра");
                return;
            }
            int idContact = Convert.ToInt32(dgvAbnContact.CurrentRow.Cells["idAbnContactDgvTxtColumn"].Value);
            FormAddEditAbnContact fAdd = new FormAddEditAbnContact(Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]),
               idContact, FormAddEditAbnContact.ActionAbnContact.Read);
            fAdd.SqlSettings = this.SqlSettings;
            fAdd.MdiParent = this.MdiParent;
            fAdd.Show();
        }
        #endregion
        #endregion
        #region TabPageDocOpl
        #region toolstripDocOpl
        //формат ячеек
        private void dgvDocOpl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((bool)dgvDocOpl["tDocOpldeleted", e.RowIndex].Value)
                    e.CellStyle.BackColor = Color.Red;

            }
        }
        //добавить платеж
        private void toolBtnDocOplAdd_Click(object sender, EventArgs e)
        {
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                FormAddEditDocOpl fAdd = new FormAddEditDocOpl(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                    idPoint, -1, FormAddEditDocOpl.ActionDocOpl.Add);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsPrv, dsPrv.vDocOpl, true, "where idPoint = " + idPoint.ToString() + " order by DateOpl desc");
                }
            }
        }
        //редактировать платеж
        private void toolBtnDocOplEdit_Click(object sender, EventArgs e)
        {
            if (dgvDocOpl.CurrentRow == null)
            {
                MessageBox.Show("Не выбран платеж для редактирования");
                return;
            }
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                int idDoc = Convert.ToInt32(dgvDocOpl.CurrentRow.Cells["idDocOplDgvTxtColumn"].Value);
                FormAddEditDocOpl fEdit = new FormAddEditDocOpl(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                    idPoint, idDoc, FormAddEditDocOpl.ActionDocOpl.Edit);
                fEdit.SqlSettings = this.SqlSettings;
                if (fEdit.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsPrv, dsPrv.vDocOpl, true, "where idPoint = " + idPoint.ToString() + " order by DateOpl desc");
                }
            }
        }
        // удалить платеж
        private void toolBtnDocOplDel_Click(object sender, EventArgs e)
        {
            if (dgvDocOpl.CurrentRow == null)
            {
                MessageBox.Show("Не выбран платеж для удаления");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить текущий платеж?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //int idDoc = Convert.ToInt32(dgvDocOpl.CurrentRow.Cells["idDocOplDgvTxtColumn"].Value);
                //if (this.DeleteSqlDataById(dsPrv.tDocOpl, idDoc))
                //{
                //    dsPrv.vDocOpl.Rows.Find(idDoc).Delete();
                //}
                int idPoint = GetIdSelectedPoint();

                if (dsPrv.vDocOpl.Rows.Count > 0)
                {
                    DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
                    this.SelectSqlData(ds, ds.tDocOpl, true, "where id = " + Convert.ToInt32(dgvDocOpl.CurrentRow.Cells["idDocOplDgvTxtColumn"].Value));
                    ds.tDocOpl.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tDocOpl.Rows[0]["Deleted"]);
                    ds.tDocOpl.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tDocOpl))
                    {
                        if (Convert.ToBoolean(ds.tDocOpl.Rows[0]["Deleted"]))
                        {
                            MessageBox.Show("Оплата успешно удалена");
                        }
                        else
                        {
                            MessageBox.Show("Оплата успешно восстановлена");

                        }
                    }
                }

                this.SelectSqlData(dsPrv, dsPrv.vDocOpl, true, "where idPoint = " + idPoint.ToString() + " order by DateOpl desc");
            }
        }
        // просмотр
        private void toolBtnDocOplInfo_Click(object sender, EventArgs e)
        {
            if (dgvDocOpl.CurrentRow == null)
            {
                MessageBox.Show("Не выбран платеж для просмтора");
                return;
            }
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                int idDoc = Convert.ToInt32(dgvDocOpl.CurrentRow.Cells["idDocOplDgvTxtColumn"].Value);
                FormAddEditDocOpl fInfo = new FormAddEditDocOpl(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                    idPoint, idDoc, FormAddEditDocOpl.ActionDocOpl.Read);
                fInfo.SqlSettings = this.SqlSettings;
                fInfo.MdiParent = this.MdiParent;
                fInfo.Show();
            }
        }
        #endregion
        #endregion
        #region TabPageTariff
        #region toolstripTariff
        // новый тариф
        private void toolBtnTariffAdd_Click(object sender, EventArgs e)
        {
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                FormAddEditTariff fAdd = new FormAddEditTariff(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                    idPoint, -1, FormAddEditTariff.ActionTariff.Add);
                fAdd.SqlSettings = this.SqlSettings;
                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsPrv, dsPrv.vTariffReg, true, "where idPoint = " + idPoint.ToString() + " order by SetDate desc");
                }
            }
        }
        // редактировать тариф
        private void toolBtnTariffEdit_Click(object sender, EventArgs e)
        {
            if (dgvTariff.CurrentRow == null)
            {
                MessageBox.Show("Не выбран тариф");
                return;
            }
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                int idTariff = Convert.ToInt32(dgvTariff.CurrentRow.Cells["idTariffDgvTxtColumn"].Value);
                FormAddEditTariff fEdit = new FormAddEditTariff(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                  idPoint, idTariff, FormAddEditTariff.ActionTariff.Edit);
                fEdit.SqlSettings = this.SqlSettings;
                if (fEdit.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsPrv, dsPrv.vTariffReg, true, "where idPoint = " + idPoint.ToString() + " order by SetDate desc");
                }
            }
        }
        // удалить тариф
        private void toolBtnTariffDel_Click(object sender, EventArgs e)
        {
            if (dgvTariff.CurrentRow == null)
            {
                MessageBox.Show("Не выбран тариф для удаления");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить текущий тариф?", "Удаление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idTariff = Convert.ToInt32(dgvTariff.CurrentRow.Cells["idTariffDgvTxtColumn"].Value);
                if (this.DeleteSqlDataById(dsPrv.tTariffReg, idTariff))
                {
                    dsPrv.vTariffReg.Rows.Find(idTariff).Delete();
                }
            }
        }
        // просмотр
        private void toolBtnTariffInfo_Click(object sender, EventArgs e)
        {
            if (dgvTariff.CurrentRow == null)
            {
                MessageBox.Show("Не выбран тариф");
                return;
            }
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {
                int idTariff = Convert.ToInt32(dgvTariff.CurrentRow.Cells["idTariffDgvTxtColumn"].Value);
                FormAddEditTariff fEdit = new FormAddEditTariff(Convert.ToInt32(dsPrv.vAbn.Rows[0]["CodeAbonent"]),
                  idPoint, idTariff, FormAddEditTariff.ActionTariff.Read);
                fEdit.SqlSettings = this.SqlSettings;
                fEdit.MdiParent = this.MdiParent;
                fEdit.Show();
            }

        }
        #endregion



        #endregion

        private void tabControlMain_KeyDown(object sender, KeyEventArgs e)
        {
            #region TabPageDocAct
            // Если активна вкладка документы
            if (tabControlMain.SelectedTab == tabPageDocAct)
            {
                switch (e.Modifiers)
                {
                    case Keys.Control:
                        switch (e.KeyCode)
                        {
                            case Keys.F8:  // удаление документа
                                if ((toolBtnDocActDel.Visible) && (toolBtnDocActDel.Enabled))
                                    toolBtnDocActDel_Click(sender, e);
                                break;
                        }
                        break;
                    case Keys.None:
                        switch (e.KeyCode)
                        {
                            case Keys.F7: // новый документ
                                if ((toolBtnDocActAdd.Visible) && (toolBtnDocActAdd.Enabled))
                                    toolBtnDocActAdd_Click(sender, e);
                                break;
                            case Keys.F4: // редактирование
                                if ((toolBtnDocActEdit.Visible) && (toolBtnDocActEdit.Enabled))
                                    toolBtnDocActEdit_Click(sender, e);
                                break;
                            case Keys.Enter: // просмотр
                                if ((toolBtnDocActInfo.Visible) && (toolBtnDocActInfo.Enabled))
                                    toolBtnDocActInfo_Click(sender, e);
                                break;
                        }
                        break;
                    default: break;
                }
            }
            #endregion 
        }

        #endregion

        private void dgvDebitorka_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void DebToExel_Click(object sender, EventArgs e)
        {
            dgvDebitorka.CopyToExcel(true);
        }

        private void toolStripButtonDebRefresh_Click(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect(); 
            try
            {
                int point = GetIdSelectedPoint();

                sql.OpenConnection(this.SqlSettings); 
                System.Data.SqlClient.SqlCommand sqlcom = new System.Data.SqlClient.SqlCommand("sp_PrvResizeOnePointDeb", sql.Connection);
                sqlcom.CommandType = CommandType.StoredProcedure;        
            	
                sqlcom.Parameters.Add("@idPoint", SqlDbType.Int);
                sqlcom.Parameters["@idPoint"].Value = point;
                sqlcom.Parameters.Add("@MonthBeg", SqlDbType.Int);
                sqlcom.Parameters["@MonthBeg"].Value = Convert.ToInt32(Convert.ToDateTime(toolStripComboBoxDebBeg.SelectedItem).ToString("yyyyMM"));
				sqlcom.Parameters.Add("@MonthEnd", SqlDbType.Int);
                sqlcom.Parameters["@MonthEnd"].Value = Convert.ToInt32(Convert.ToDateTime(toolStripComboBoxDebEnd.SelectedItem).ToString("yyyyMM"));

                sqlcom.ExecuteNonQuery();
                              
                SumDeb(point);

                this.SelectSqlData(dsPrv, dsPrv.vPrv_Debitorka, true, "where idPoint = " + GetIdSelectedPoint().ToString() + " order by MonthRasch desc");
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			finally
			{
				sql.CloseConnection();
			}
        
        
        }

        private void tabControlDebitorka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlDebitorka.SelectedIndex == 0) // если дебиторка УльГЭС
            {
                toolStripButtonDebRefresh.Visible = true;
                toolStripComboBoxDebBeg.Visible = true;
                toolStripComboBoxDebEnd.Visible = true;
                toolStripLabel_do.Visible = true;
                DebToExel.Visible = true;
                
                SumDeb(GetIdSelectedPoint());
            }

          //  MessageBox.Show(tabControlDebitorka.SelectedIndex.ToString());

            if (tabControlDebitorka.SelectedIndex == 1) // если дебиторка УЭ
            {

                toolStripButtonDebRefresh.Visible = false;
                toolStripComboBoxDebBeg.Visible = false;
                toolStripComboBoxDebEnd.Visible = false;
                toolStripLabel_do.Visible = false;
                DebToExel.Visible = false;
;

                int point = GetIdSelectedPoint();
                this.SelectSqlData(dsPrv, dsPrv.vPrv_DebitorkaUE, true, "where idPoint = " + point.ToString() + " order by MonthDeb desc");

                DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                try
                {
                    sql.OpenConnection(this.SqlSettings);
                    System.Data.SqlClient.SqlCommand sqlcom = new System.Data.SqlClient.SqlCommand("select sum(Itog) from vPrv_DebitorkaUE where idPoint=" + point + "  ", sql.Connection);
                    toolStripTextBoxDebitorka.Text = sqlcom.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    sql.CloseConnection();
                }
            }
        }

        private void toolStripButtonRefOp_Click(object sender, EventArgs e)
        {
            Reports.FormAbnOpl fRep = new Reports.FormAbnOpl(Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]), GetIdSelectedPoint());
            fRep.SqlSettings = this.SqlSettings;

            if (fRep.ShowDialog() == DialogResult.OK)
            {
  
            }
        }

        private void tsbAktBezUch_Click(object sender, EventArgs e)
        {
            Reports.FormActBezuch fRep = new Reports.FormActBezuch(Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]), GetIdSelectedPoint());
            fRep.SqlSettings = this.SqlSettings;

            if (fRep.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void FormAbonent_Shown(object sender, EventArgs e)
        {
            // Для отлова контекстного меню
            if (toolBtnAbnAdd.Visible == false)
            {
                if (codeAbn == -1) codeAbn = firstCodeAbonent;
                if (typeAbn != -1) ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id = typeAbn;

                // загрузка абонента
                LoadAbonent(codeAbn, ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id);
            }
        }

        private void tsbCopyOld_Click(object sender, EventArgs e)
        {
            if (dsPrv.vAbn.Rows.Count == 0) return;
            DialogResult dialogResult = MessageBox.Show("Скопировать лицевой счет со старой базы?", "Копирование", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Уверены? ВСЕ ТЕКУЩИЕ ДАННЫЕ БУДУТ ПОТЕРЯНЫ!!!", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    
                    //int CA = Convert.ToInt32(toolTxtChangeAbn.Text);
                    int CA = (int)dsPrv.vAbn.Rows[0]["CodeAbonent"];

                    MessageBox.Show(CA.ToString());//"Данная функция пока недоступна");

                    DataSql.SqlDataConnect sql = new DataSql.SqlDataConnect();
                    try
                    {
                        //int point = GetIdSelectedPoint();

                        sql.OpenConnection(this.SqlSettings);

                        //ищем по старым базам лицевой счет 0-ненайден 1-правый берег 2-левый берег
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT [dbo].[fn_PrvGetAbnOLDBase](" + CA.ToString()+")", sql.Connection);
                        int result = ((int)cmd.ExecuteScalar());
                        //sql.CloseConnection();

                        string proc = "";

                        if (result == 1) proc = "ImportAbonentFromPrvDB";
                        if (result == 2) proc = "ImportAbonentFromPrvDBnc";
                        if (result == 0)
                        {
                            MessageBox.Show("Лицевой счет не найден в старых базах");
                            return;
                        }

                        if (proc != "")
                        {
                            System.Data.SqlClient.SqlCommand sqlcom = new System.Data.SqlClient.SqlCommand(proc, sql.Connection);

                            sqlcom.CommandType = CommandType.StoredProcedure;

                            sqlcom.Parameters.Add("@CodeAbn", SqlDbType.Int);
                            sqlcom.Parameters["@CodeAbn"].Value = CA;

                            sqlcom.ExecuteNonQuery();

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                    finally
                    {
                        MessageBox.Show("Лицевой счет успешно перенесен");
                        sql.CloseConnection();
                        // загрузка абонента
                        LoadAbonent(CA, ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id);
                    }

                }

            }
        }

        //Добавление признака
        private void ObjFlagAddTSB_Click(object sender, EventArgs e)
        {
            int idObj = GetIdSelectedAbnObj();

            if (idObj > 0) 
            {

                Abonent.FormObjFlagAdd fAdd = new Abonent.FormObjFlagAdd(idObj); ;
                fAdd.SqlSettings = this.SqlSettings;

                if (fAdd.ShowDialog() == DialogResult.OK)
                {
                    this.SelectSqlData(dsPrv, dsPrv.vPrv_AbnObjFlags, true, " where idAbnObj = " + idObj.ToString() + " Order by Name desc");
                    this.SelectSqlData(dsPrv, dsPrv.tAbnObjFlags, true, " where idAbnObj = " + idObj.ToString() + " Order by Date desc");
                }
            }
            else
            {
                MessageBox.Show("Нет объектов.");
            }
        }

        private void AbnObjFlagNameDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (AbnObjFlagNameDGV.RowCount > 0) bstAbnObjFlags.Filter = "idFlag =" + AbnObjFlagNameDGV.CurrentRow.Cells["idFlag"].Value.ToString();
        }

        private void ObjFlagDelTSB_Click(object sender, EventArgs e)
        {
            int idObj = GetIdSelectedAbnObj();

            if (AbnObjFlagNameDGV.RowCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить текущий признак?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
                    this.SelectSqlData(ds, ds.tAbnObjFlags, true, "where id = " + AbnObjFlagNameDGV.CurrentRow.Cells["idDGV"].Value.ToString());
                    ds.tAbnObjFlags.Rows[0]["Deleted"] = 1;
                    ds.tAbnObjFlags.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tAbnObjFlags))
                    {
                        this.SelectSqlData(dsPrv, dsPrv.vPrv_AbnObjFlags, true, " where idAbnObj = " + idObj.ToString() + " Order by Name desc");
                        if (dsPrv.vPrv_AbnObjFlags.Rows.Count > 0) this.SelectSqlData(dsPrv, dsPrv.tAbnObjFlags, true, " where idAbnObj = " + idObj.ToString() + " Order by Date desc");
                        else dsPrv.tAbnObjFlags.Clear();
                    }
                }
            }
        }

        private void FlagDateDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(FlagDateDGV.Rows[e.RowIndex].Cells["deleted"].Value) == 1)
                    e.CellStyle.ForeColor = Color.Gainsboro;

            }
        }

        #region toolStripSchmAbn Events
        // привязать к схеме
        private void toolBtnAddSchmObj_Click(object sender, EventArgs e)
        {
            if (idAbnObj != -1)
            {
                Dictionary<int, string> linkObjects = new Dictionary<int, string>();
                foreach (DataRow r in dsPrv.vL_SchmAbn)
                    if (r["TypeDoc"] != DBNull.Value && (Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ActTC 
                        || Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ActRBP
                        || Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ChangeSwitch
                        ))
                    {
                        //if (linkObjects.ContainsKey(Convert.ToInt32(r["idSchmObj"])))
                        //    linkObjects.Remove(Convert.ToInt32(r["idSchmObj"]));
                    }
                    else
                    {
                        if (!linkObjects.ContainsKey(Convert.ToInt32(r["idSchmObj"])))
                            linkObjects.Add(Convert.ToInt32(r["idSchmObj"]), r["SchmObjName"].ToString());
                    }

                Documents.Forms.Scheme.FormLinkAbnObjAndSchm f = new Documents.Forms.Scheme.FormLinkAbnObjAndSchm();
                f.LinkObjects = linkObjects;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    linkObjects = f.LinkObjects;
                    UpdateLinkSchmAbn(linkObjects);
                    LoadLinkSchmAbn();
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать объект");
            }
        }
        private void UpdateLinkSchmAbn(Dictionary<int, string> linkObjects)
        {
            foreach (DataRow r in dsPrv.vL_SchmAbn)
            {
                /*int idSchmObj = Convert.ToInt32(r["idSchmObj"]);
                if (!linkObjects.ContainsKey(idSchmObj))
                    this.DeleteSqlDataById(dsPrv.tL_SchmAbn, Convert.ToInt32(r["id"]));*/
                if (r["TypeDoc"] != DBNull.Value && (Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ActTC
                    || Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ActRBP
                    || Convert.ToInt32(r["TypeDoc"]) == (int)Constants.eTypeDocTC.ChangeSwitch))
                    continue;
                int idSchmObj = Convert.ToInt32(r["idSchmObj"]);
                if (!linkObjects.ContainsKey(idSchmObj))
                    this.DeleteSqlDataById(dsPrv.tL_SchmAbn, Convert.ToInt32(r["id"]));
                else
                    linkObjects.Remove(idSchmObj);
            }
            dsPrv.tL_SchmAbn.Clear();
            foreach (int i in linkObjects.Keys)
            {
                if (dsPrv.tL_SchmAbn.Select("idSchmObj = " + idAbnObj.ToString()).Length <= 0)
                {
                    DataRow newR = dsPrv.tL_SchmAbn.NewRow();
                    newR["idSchmObj"] = i;
                    newR["idAbn"] = idAbn;
                    newR["idAbnObj"] = idAbnObj;
                    dsPrv.tL_SchmAbn.Rows.Add(newR);
                }
            }
            this.InsertSqlData(dsPrv, dsPrv.tL_SchmAbn);
            dsPrv.tL_SchmAbn.Clear();

        }
        // удалить привязку
        private void toolBtnDelSchmObj_Click(object sender, EventArgs e)
        {
            if (dgvLinkSchmAbn.CurrentRow != null)
            {
                DataGridViewRow dgvR = dgvLinkSchmAbn.CurrentRow;
                if (dgvR.Cells[typeDocLinkSchmDgvColumn.Name].Value != null && dgvR.Cells[typeDocLinkSchmDgvColumn.Name].Value != DBNull.Value)
                {
                    if (Convert.ToInt32(dgvR.Cells[typeDocLinkSchmDgvColumn.Name].Value) == (int)Constants.eTypeDocTC.ActTC ||
                        Convert.ToInt32(dgvR.Cells[typeDocLinkSchmDgvColumn.Name].Value) == (int)Constants.eTypeDocTC.ActRBP ||
                        Convert.ToInt32(dgvR.Cells[typeDocLinkSchmDgvColumn.Name].Value) == (int)Constants.eTypeDocTC.ChangeSwitch)
                    {
                        if (Convert.ToBoolean(dgvR.Cells[delDocDgvColumn.Name].Value)) // документ удален
                        {
                            // пока так пускай дальше по коду идет....
                        //    if (MessageBox.Show("Вы действительно хотите удалить текущую привязку?\r\n"))
                        }
                        else
                        {
                            MessageBox.Show("Данную привзяку невозможно удалить");
                            return;
                        }
                    }
                }

                if (MessageBox.Show("Вы действительно хотите удалить текущую привязку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    this.DeleteSqlDataById(dsPrv.tL_SchmAbn, Convert.ToInt32(dgvLinkSchmAbn.CurrentRow.Cells[idLinkSchmAbnDgvColumn.Name].Value));
                    LoadLinkSchmAbn();
                }
            }
        }
      
        private void toolBtnShowSchmObj_Click(object sender, EventArgs e)
        {
            if (dgvLinkSchmAbn.CurrentRow  != null)
            {
                OnGoToSchema(new GoToSchemaEventArgs((int)dgvLinkSchmAbn.CurrentRow.Cells[idSchmObjDgvColumn.Name].Value));
            }
        }

        // Разукрашка грида привзяки к схеме
        private void dgvLinkSchmAbn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (Convert.ToBoolean(dgvLinkSchmAbn[delDocDgvColumn.Name, e.RowIndex].Value)) // если документ удален
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                    DataGridViewCell cell =
                        this.dgvLinkSchmAbn.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.ToolTipText = "Документ удален";
                }
            }
        }
        #endregion

        #region Расчет потерь 17.09.2013 Shumilov A.I.
        private void LoadCalcLoss()
        {
            this.SelectSqlData(dsPrv, dsPrv.vJ_CalcLoss, true, "where idAbnObj = " + idAbnObj.ToString() + " and deleted = 0 order by datecalc desc");
        }
        private void LoadAddBtnCalcLoss()
        {
            DataSets.DataSetPrv.tR_ClassifierDataTable dt = new DataSets.DataSetPrv.tR_ClassifierDataTable();
            this.SelectSqlData(dt, true, "where ParentKey = ';TypeDoc;tJ_CalcLoss;' and isGroup = 0 and deleted = 0 order by name");
            foreach (DataRow r in dt.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(r["Name"].ToString());
                item.Tag = r["id"];
                toolBtnAddCalcLoss.DropDownItems.Add(item);
                item.Click += new EventHandler(toolBtnAddCalc_Click);
            }
        }
        // Добавить расчет
        private void toolBtnAddCalc_Click(object sender, EventArgs e)
        {
            int typeCalc = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
            if (typeCalc == (int)Constants.TypeCalcLoss.TypeTrans)
            {
                Documents.Forms.JournalCalcLoss.FormAddEditCalcTrans f =
                    new Documents.Forms.JournalCalcLoss.FormAddEditCalcTrans(-1, typeCalc, idAbn, idAbnObj);
                f.MdiParent = this.MdiParent;
                f.SqlSettings = this.SqlSettings;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.Show();
            }
            else // КЛ/ВЛ
            {
                Documents.Forms.JournalCalcLoss.FormAddEditCalcCable f = 
                    new Documents.Forms.JournalCalcLoss.FormAddEditCalcCable(-1, typeCalc, idAbn, idAbnObj);
                f.MdiParent = this.MdiParent;
                f.SqlSettings = this.SqlSettings;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.Show();
            }
        }
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((Form)sender).DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //id = ((FormAddEditCalcCable)sender).Id;
                LoadCalcLoss();
            }
        }
        // редактировать расчет
        private void toolBtnEditCalcLoss_Click(object sender, EventArgs e)
        {
            if (dgvCalcLoss.CurrentRow != null)
            {
                int typeCalc = Convert.ToInt32(dgvCalcLoss.CurrentRow.Cells[idTypeCalcDgvColumn.Name].Value);
                int idCalc = Convert.ToInt32(dgvCalcLoss.CurrentRow.Cells[idCalcLossDgvColumn.Name].Value);
                if (typeCalc == (int)Constants.TypeCalcLoss.TypeTrans)
                {
                    Documents.Forms.JournalCalcLoss.FormAddEditCalcTrans f = new Documents.Forms.JournalCalcLoss.FormAddEditCalcTrans(idCalc, typeCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                    f.Show();
                }
                else // КЛ/ВЛ
                {
                    Documents.Forms.JournalCalcLoss.FormAddEditCalcCable f = new Documents.Forms.JournalCalcLoss.FormAddEditCalcCable(idCalc, typeCalc);
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                    f.Show();
                }
            }
        }
        // двойной клик
        private void dgvCalcLoss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (toolBtnEditCalcLoss.Enabled && toolBtnEditCalcLoss.Visible)
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    toolBtnEditCalcLoss_Click(sender, e);
        }
        private void toolBtnInfoCalcLoss_Click(object sender, EventArgs e)
        {
            if (dgvCalcLoss.CurrentRow != null)
            {
                if (Convert.ToInt32(dgvCalcLoss.CurrentRow.Cells[idTypeCalcDgvColumn.Name].Value) ==
                    (int)Constants.TypeCalcLoss.TypeTrans)
                {
                    Documents.Forms.JournalCalcLoss.Report.FormReportCalcLossTrans f =
                       new Documents.Forms.JournalCalcLoss.Report.FormReportCalcLossTrans(Convert.ToInt32(dgvCalcLoss.CurrentRow.Cells[idCalcLossDgvColumn.Name].Value));
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.Show();
                }
                else
                {
                    Documents.Forms.JournalCalcLoss.Report.FormReportCalcLoss f =
                        new Documents.Forms.JournalCalcLoss.Report.FormReportCalcLoss(Convert.ToInt32(dgvCalcLoss.CurrentRow.Cells[idCalcLossDgvColumn.Name].Value));
                    f.MdiParent = this.MdiParent;
                    f.SqlSettings = this.SqlSettings;
                    f.Show();
                }
            }
        }

        private void toolBtnDelCalcLoss_Click(object sender, EventArgs e)
        {
            if (dgvCalcLoss.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные записи?", "Удаление", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string ids = "";
                    foreach (DataGridViewRow row in dgvCalcLoss.SelectedRows)
                    {
                        if (string.IsNullOrEmpty(ids))
                            ids = row.Cells[idCalcLossDgvColumn.Name].Value.ToString();
                        else
                            ids += "," + row.Cells[idCalcLossDgvColumn.Name].Value.ToString();
                    }
                    this.SelectSqlData(dsPrv.tJ_CalcLoss, true, "where id in (" + ids + ")");
                    foreach (DataRow r in dsPrv.tJ_CalcLoss)
                    {
                        r["deleted"] = 1;
                        r.EndEdit();
                    }
                    this.UpdateSqlData(dsPrv, dsPrv.tJ_CalcLoss);
                    LoadCalcLoss();

                    MessageBox.Show("Записи успешно удалены");
                }
            }
            else
                MessageBox.Show("Выделите строки для удаления");
        }
        #endregion

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCalcLossDgvColumn.Visible = false;
        }

        #region Прикрепить объект

        private void AddExistAbnObjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // выберем объекты без владельца для прикрепления

            ID = GetIdFromNodeTag(treeViewAbn.Nodes[0].Tag);

            Legal.Forms.FormObjSelect fSelect = new Legal.Forms.FormObjSelect(ID, 0, Legal.Forms.FormObjSelect.SelectionMethod.Many);
            fSelect.SqlSettings = this.SqlSettings;
            if (fSelect.ShowDialog() == DialogResult.OK)
            {
                if (fSelect.idObjPar > 0)
                {
                    // если выбран один объект
                    IDOBJSELECT = fSelect.idObjPar;
                    
                    // меняем владельца объекта в tAbnObj
                    this.SelectSqlData(dsPrv, dsPrv.tAbnObj, true, " where id = " + IDOBJSELECT.ToString());
                    dsPrv.tAbnObj.Rows[0]["idAbn"] = ID;
                    dsPrv.tAbnObj.Rows[0].EndEdit();
                    UpdateSqlData(dsPrv, dsPrv.tAbnObj);

                    // записываем новые параметры объекта в tAbnObjReg
                    DataTable dt = dsPrv.tAbnObjReg;
                    this.SelectSqlData(dt, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DateChange desc", null, false, 1);
                    DataRow dr = dt.NewRow();
                    dr["idAbn"] = ID;
                    dr["DateChange"] = System.DateTime.Now.Date;
                    dr["idAbnObj"] = dt.Rows[0]["idAbnObj"];
                    dr["idAbnNet"] = dt.Rows[0]["idAbnNet"];
                    dr["idAbnSale"] = dt.Rows[0]["idAbnSale"];
                    dr["idStatus"] = dt.Rows[0]["idStatus"];
                    dr["Regime"] = dt.Rows[0]["Regime"];
                    dr["PowerSet"] = dt.Rows[0]["PowerSet"];
                    dr["PowerOther"] = dt.Rows[0]["PowerOther"];
                    dr["PowerFact"] = dt.Rows[0]["PowerFact"];
                    dr["KLoss"] = dt.Rows[0]["Kloss"];
                    dr["Category"] = dt.Rows[0]["Category"];
                    dr["Comment"] = dt.Rows[0]["Comment"];
                    dr["CommonType"] = dt.Rows[0]["CommonType"];
                    dr["CommonPercent"] = dt.Rows[0]["CommonPercent"];
                    dr["CommonValue"] = dt.Rows[0]["CommonValue"];
                    dr["CalcLoss"] = dt.Rows[0]["CalcLoss"];
                    dr["idTariff"] = dt.Rows[0]["idTariff"];
                    dr["NumberTP"] = dt.Rows[0]["NumberTP"];
                    dr["DateTP"] = dt.Rows[0]["DateTP"];
                    dr["NumberTU"] = dt.Rows[0]["NumberTU"];
                    dr["DateTU"] = dt.Rows[0]["DateTU"];
                    dr["DatePowerFact"] = dt.Rows[0]["DatePowerFact"];
                    dr["idAbnObjSame"] = dt.Rows[0]["idAbnObjSame"];
                    dr["SubNet"] = dt.Rows[0]["SubNet"];
                    dr["SubNetComment"] = dt.Rows[0]["SubNetComment"];

                    dsPrv.tAbnObjReg.Rows.Add(dr);

                    InsertSqlData(dsPrv, dt);
                }
                else
                {
                    // если выбрано несколько объектов
                    for (int i = 0; i < fSelect.idArray.Length; i++)
                    {
                        if (fSelect.idArray[i] > 0) // MessageBox.Show(fSelect.idArray[i].ToString());
                        {
                            IDOBJSELECT = fSelect.idArray[i];

                            this.SelectSqlData(dsPrv, dsPrv.tAbnObj, true, " where id = " + IDOBJSELECT.ToString());
                            dsPrv.tAbnObj.Rows[0]["idAbn"] = ID;
                            dsPrv.tAbnObj.Rows[0].EndEdit();
                            UpdateSqlData(dsPrv, dsPrv.tAbnObj);

                            // записываем новые параметры объекта в tAbnObjReg
                            DataTable dt = dsPrv.tAbnObjReg;
                            this.SelectSqlData(dt, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DateChange desc", null, false, 1);
                            DataRow dr = dt.NewRow();
                            dr["idAbn"] = ID;
                            dr["DateChange"] = System.DateTime.Now.Date;
                            dr["idAbnObj"] = dt.Rows[0]["idAbnObj"];
                            dr["idAbnNet"] = dt.Rows[0]["idAbnNet"];
                            dr["idAbnSale"] = dt.Rows[0]["idAbnSale"];
                            dr["idStatus"] = dt.Rows[0]["idStatus"];
                            dr["Regime"] = dt.Rows[0]["Regime"];
                            dr["PowerSet"] = dt.Rows[0]["PowerSet"];
                            dr["PowerOther"] = dt.Rows[0]["PowerOther"];
                            dr["PowerFact"] = dt.Rows[0]["PowerFact"];
                            dr["KLoss"] = dt.Rows[0]["Kloss"];
                            dr["Category"] = dt.Rows[0]["Category"];
                            dr["Comment"] = dt.Rows[0]["Comment"];
                            dr["CommonType"] = dt.Rows[0]["CommonType"];
                            dr["CommonPercent"] = dt.Rows[0]["CommonPercent"];
                            dr["CommonValue"] = dt.Rows[0]["CommonValue"];
                            dr["CalcLoss"] = dt.Rows[0]["CalcLoss"];
                            dr["idTariff"] = dt.Rows[0]["idTariff"];
                            dr["NumberTP"] = dt.Rows[0]["NumberTP"];
                            dr["DateTP"] = dt.Rows[0]["DateTP"];
                            dr["NumberTU"] = dt.Rows[0]["NumberTU"];
                            dr["DateTU"] = dt.Rows[0]["DateTU"];
                            dr["DatePowerFact"] = dt.Rows[0]["DatePowerFact"];
                            dr["idAbnObjSame"] = dt.Rows[0]["idAbnObjSame"];
                            dr["SubNet"] = dt.Rows[0]["SubNet"];
                            dr["SubNetComment"] = dt.Rows[0]["SubNetComment"];

                            dsPrv.tAbnObjReg.Rows.Add(dr);

                            InsertSqlData(dsPrv, dt);
                        }
                    }

                }

                LoadTreeViewAbn(treeViewAbn.SelectedNode);
            }
        }
        #endregion

        #region Открепить объект
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewAbn.SelectedNode != null)
            {
                switch (treeViewAbn.SelectedNode.Level)
                {
                    case 1: // удалить объект
                        if (MessageBox.Show("Вы действительно хотите открепить выбранный объект?", "Открепление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            int IDOBJSELECT = GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag);
                            // удаляем владельца объекта в tAbnObj
                            this.SelectSqlData(dsPrv, dsPrv.tAbnObj, true, " where id = " + IDOBJSELECT.ToString());
                            dsPrv.tAbnObj.Rows[0]["idAbn"] = 220863;
                            dsPrv.tAbnObj.Rows[0].EndEdit();
                            UpdateSqlData(dsPrv, dsPrv.tAbnObj);

                            // записываем новые параметры объекта в tAbnObjReg
                            DataTable dt = dsPrv.tAbnObjReg;
                            this.SelectSqlData(dt, true, " where idAbnObj = " + IDOBJSELECT.ToString() + " order by DateChange desc", null, false, 1);
                            if (dt.Rows.Count > 0)
                            {
                                DataRow dr = dt.NewRow();
                                dr["idAbn"] = 0;
                                dr["DateChange"] = System.DateTime.Now.Date;
                                dr["idAbnObj"] = dt.Rows[0]["idAbnObj"];
                                dr["idAbnNet"] = dt.Rows[0]["idAbnNet"];
                                dr["idAbnSale"] = dt.Rows[0]["idAbnSale"];
                                dr["idStatus"] = dt.Rows[0]["idStatus"];
                                dr["Regime"] = dt.Rows[0]["Regime"];
                                dr["PowerSet"] = dt.Rows[0]["PowerSet"];
                                dr["PowerOther"] = dt.Rows[0]["PowerOther"];
                                dr["PowerFact"] = dt.Rows[0]["PowerFact"];
                                dr["KLoss"] = dt.Rows[0]["Kloss"];
                                dr["Category"] = dt.Rows[0]["Category"];
                                dr["Comment"] = dt.Rows[0]["Comment"];
                                dr["CommonType"] = dt.Rows[0]["CommonType"];
                                dr["CommonPercent"] = dt.Rows[0]["CommonPercent"];
                                dr["CommonValue"] = dt.Rows[0]["CommonValue"];
                                dr["CalcLoss"] = dt.Rows[0]["CalcLoss"];
                                dr["idTariff"] = dt.Rows[0]["idTariff"];
                                dr["NumberTP"] = dt.Rows[0]["NumberTP"];
                                dr["DateTP"] = dt.Rows[0]["DateTP"];
                                dr["NumberTU"] = dt.Rows[0]["NumberTU"];
                                dr["DateTU"] = dt.Rows[0]["DateTU"];
                                dr["DatePowerFact"] = dt.Rows[0]["DatePowerFact"];
                                dr["idAbnObjSame"] = dt.Rows[0]["idAbnObjSame"];
                                dr["SubNet"] = dt.Rows[0]["SubNet"];
                                dr["SubNetComment"] = dt.Rows[0]["SubNetComment"];

                                dsPrv.tAbnObjReg.Rows.Add(dr);

                                InsertSqlData(dsPrv, dt);
                            }

                            LoadTreeViewAbn(treeViewAbn.SelectedNode);
                        }
                        break;
                    case 2: // удалить точку
                        MessageBox.Show("Нельзя открепить точку.");
                        //if (MessageBox.Show("Вы действительно хотите удалить выбранную точку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        //{
                        //    if (this.DeleteSqlDataById(dsPrv.tPoint, GetIdFromNodeTag(treeViewAbn.SelectedNode.Tag)))
                        //    {
                        //        MessageBox.Show("Точка учета успешно удалена");
                        //        LoadTreeViewAbn(null);
                        //    }
                        //}
                        break;
                    default: break;
                }


            }


        }
        #endregion

        #region Работа с ТП старая база

        private void LoadTP_old()
        {
            // загрузка подключений
            SelectSqlData(dsPrv, dsPrv.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
            dgvTP.Columns[0].Visible = false;
        
        }
        private void LoadDocActs()
        {
            idAbnObj = GetIdSelectedAbnObj();
            //Акты объектов
            this.SelectSqlData(dsPrv, dsPrv.vAbnObjDoc_List, true, " where idAbnObj = " + idAbnObj.ToString() + " Order by DocDate desc");
        }
        private void tsbNewTP_Click(object sender, EventArgs e)
        {
            idAbnObj = GetIdSelectedAbnObj();
            //if (dgvTP.RowCount > 0)
            //{
            Legal.Forms.Object.FormAddEditConnect f = new Legal.Forms.Object.FormAddEditConnect(-1, idAbnObj, Legal.Forms.Object.FormAddEditConnect.ActionСonnect.Add);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                SelectSqlData(dsPrv, dsPrv.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
                dgvTP.Columns[0].Visible = false;
            };
            //}

        }

        private void tsbEditTP_Click(object sender, EventArgs e)
        {
            idAbnObj = GetIdSelectedAbnObj();

            if (dgvTP.RowCount > 0)
            {
                Legal.Forms.Object.FormAddEditConnect f = new Legal.Forms.Object.FormAddEditConnect(Convert.ToInt32(dgvTP.CurrentRow.Cells["idxDataGridViewTextBoxColumn"].Value), idAbnObj, Legal.Forms.Object.FormAddEditConnect.ActionСonnect.Edit);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SelectSqlData(dsPrv, dsPrv.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
                    dgvTP.Columns[0].Visible = false;
                };
            }
            else
            { MessageBox.Show("Нечего редактировать"); }
        }

        private void tsbDelTP_Click(object sender, EventArgs e)
        {
            idAbnObj = GetIdSelectedAbnObj();

            if (dgvTP.RowCount > 0)
            {
                int idx = Convert.ToInt32(dgvTP.CurrentRow.Cells["idxDataGridViewTextBoxColumn"].Value);
                if (MessageBox.Show("Вы действительно хотите удалить текущее подключение?", "Удаление",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
                    this.SelectSqlData(ds, ds.tConnect, true, "where idx = " + idx.ToString());
                    ds.tConnect.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tConnect.Rows[0]["Deleted"]);
                    ds.tConnect.Rows[0].EndEdit();
                    if (this.UpdateSqlData(ds, ds.tConnect))
                    {
                        if (Convert.ToBoolean(ds.tConnect.Rows[0]["Deleted"]))
                        {
                            MessageBox.Show("Подключене успешно удалено.");
                            SelectSqlData(dsPrv, dsPrv.tConnect, true, " where Deleted = 0 and idObj = " + idAbnObj.ToString() + "order by idx desc");
                            dgvTP.Columns[0].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Подключение успешно восстановлено");
                        }
                    }

                }



            }
            else
            { MessageBox.Show("Нечего удалять"); }
        }


        #endregion

        #region Работа с актами объекта

        //Удаление документа объекта
        private void tsbObjDocDel_Click(object sender, EventArgs e)
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление",
                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idObj = GetIdSelectedAbnObj();
                    int idDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value);
                    int idDocType = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idDocObjType"].Value);
                    int DocIndex = dgvObjDoc.CurrentRow.Index;

                    DataSets.DataSetPrv ds= new Prv.DataSets.DataSetPrv();

                    switch (idDocType)
                    {
                        case (int)DocType.ActRBP:

                            this.SelectSqlData(ds, ds.tAbnObjDoc_List, true, "where id = " + idDoc);
                            ds.tAbnObjDoc_List.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tAbnObjDoc_List.Rows[0]["Deleted"]);
                            ds.tAbnObjDoc_List.Rows[0].EndEdit();
                            if (this.UpdateSqlData(ds, ds.tAbnObjDoc_List))
                            {
                                if (Convert.ToBoolean(ds.tAbnObjDoc_List.Rows[0]["Deleted"]))
                                {
                                    this.SelectSqlData(dsPrv, dsPrv.vAbnObjDoc_List, true, " where idAbnObj = " + idObj.ToString() + " order by DocDate desc");

                                    if (dgvObjDoc.RowCount > DocIndex) dgvObjDoc.CurrentCell = dgvObjDoc["ObjdocNumberDGVTBC", DocIndex];


                                    MessageBox.Show("Документ успешно удален");
                                }
                                else
                                {
                                    MessageBox.Show("Документ успешно восстановлен");
                                }
                            }
                            break;

                        case (int)DocType.ActCheck:
                        case (int)DocType.ActMeterInstallation:
                        case (int)DocType.ActMeterDismantling:
                        case (int)DocType.ActMeterkReplacement:
                            this.SelectSqlData(ds.tDocAct_Check, true, "where id = " + idDoc, null, false, 1);
                            this.SelectSqlData(ds.tDocAct, true, "where id = " + ds.tDocAct_Check.Rows[0]["idDocAct"], null, false, 1);
                            ds.tDocAct.Rows[0]["Deleted"] = !Convert.ToBoolean(ds.tDocAct.Rows[0]["Deleted"]);
                            ds.tDocAct.Rows[0].EndEdit();
                            if (this.UpdateSqlData(ds, ds.tDocAct))
                            {
                                if (Convert.ToBoolean(ds.tDocAct.Rows[0]["Deleted"]))
                                {
                                    this.SelectSqlData(dsPrv, dsPrv.vAbnObjDoc_List, true, " where idAbnObj = " + idObj.ToString() + " order by DocDate desc");

                                    if (dgvObjDoc.RowCount > DocIndex) dgvObjDoc.CurrentCell = dgvObjDoc["ObjdocNumberDGVTBC", DocIndex];


                                    MessageBox.Show("Документ успешно удален");
                                }
                                else
                                {
                                    MessageBox.Show("Документ успешно восстановлен");
                                }
                            }
                            break;
                        default:
                            MessageBox.Show("Невозможно удалить текущий документ");
                            break;

                    } //end switch
                }
            }
            else
            {
                MessageBox.Show("Не выбран документ для удаления");
            }
        }

        //Редактирование Документов объекта
        private void tsbObjAktEdit_Click(object sender, EventArgs e)
        {
            if (tsbObjAktEdit.Enabled && tsbObjAktEdit.Visible)
                EditDocObj();
        }

        //Добавление Документов объекта
        private void tsmiAktRBPAdd_Click(object sender, EventArgs e)
        {
            Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP = 
                new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, false, true, Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]), GetIdSelectedAbnObj(), TypeDocValue.ActBalance);
            if (frmAktRBP.ShowDialog() == DialogResult.OK)
            {
                this.SelectSqlData(dsPrv, dsPrv.vAbnObjDoc_List, true, " where idAbnObj = " + GetIdSelectedAbnObj() + " order by DocDate desc");
            }
            frmAktRBP.Dispose();
        }

        //Информация
        private void tsbObjDocInfo_Click(object sender, EventArgs e)
        {
            if (dgvObjDoc.CurrentRow != null)
                switch (Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value))
                {
                    case (int)DocType.DogovorTransferEnergy:
                        break;
                    case (int)DocType.ActUst:
                        break;
                    case (int)DocType.ActDem:
                        break;
                    case (int)DocType.ActKO:
                        break;
                    case (int)DocType.LossCalculation:
                        break;
                    case (int)DocType.ActPerehod:
                        break;
                    // Акт разграничения балансовой принадлежности
                    case (int)DocType.ActRBP:
                        Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                            new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, GetIdSelectedAbnObj(), Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value), true);
                        frmAktRBP.ShowDialog();
                        break;
                    case (int)DocType.ActTP:
                        break;
                    case (int)DocType.ActMeterInstallation:
                    case (int)DocType.ActMeterDismantling:
                    case (int)DocType.ActMeterkReplacement:
                    case (int)DocType.ActCheck:
                        FormLbr.Classes.ShowFormEventArgs eShow = new FormLbr.Classes.ShowFormEventArgs();
                        eShow.TypeForm = "Legal.Forms.FormDocAct_Check, Legal";
                        eShow.FormMode = FormLbr.Classes.eFormMode.Mdi;
                        eShow.Param = new object[3];
                        eShow.Param[0] = this.SqlSettings;
                        eShow.Param[1] =  GetIdSelectedAbnObj();
                        eShow.Param[2] = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value);
                        eShow.SQLSettings = this.SqlSettings;
                        this.OnShowForm(eShow);

                        break;
                    case (int)DocType.Dogovor:
                        break;
                    case (int)DocType.DogovorEnergo:
                        break;
                    #region акт осмотра эл, выполнения ту, акт о тп (22/10/2014 Shumilov A/I/)
                    case (int)eTypeDocTC.ActTC:
                    case (int)eTypeDocTC.ActElectricalInspection:
                    case (int)eTypeDocTC.ActPerformingTU:
                    case (int)eTypeDocTC.ChangeSwitch:
                        ReportActTC();
                        break;
                    #endregion
                    default:
                        break;
                }
        }

        private void EditDocObj()
        {
            if (dgvObjDoc.CurrentRow != null)
                switch (Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value))
                {
                    case (int)DocType.DogovorTransferEnergy:
                        break;
                    case (int)DocType.ActUst:
                        break;
                    case (int)DocType.ActDem:
                        break;
                    case (int)DocType.ActKO:
                        break;
                    case (int)DocType.LossCalculation:
                        break;
                    case (int)DocType.ActPerehod:
                        break;
                    // Акт разграничения балансовой принадлежности
                    case (int)DocType.ActRBP:
                        Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP frmAktRBP =
                            new Documents.Forms.TechnologicalConnection.RBP.FormAbnAktRBP(this.SqlSettings, GetIdSelectedAbnObj(),
                            Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idObjDocDGVBC.Name].Value));
                        frmAktRBP.ShowDialog();
                        break;
                    case (int)DocType.ActTP:
                        break;
                    case (int)DocType.ActMeterInstallation:
                    case (int)DocType.ActMeterDismantling:
                    case (int)DocType.ActMeterkReplacement:
                    case (int)DocType.ActCheck:
                        FormLbr.Classes.ShowFormEventArgs eShow = new FormLbr.Classes.ShowFormEventArgs();
                        eShow.TypeForm = "Legal.Forms.ActCheck.FormDocAct_CheckAdd, Legal";
                        eShow.FormMode = FormLbr.Classes.eFormMode.Mdi;
                        eShow.Param = new object[3];
                        eShow.Param[0] = this.SqlSettings;
                        eShow.Param[1] =  GetIdSelectedAbnObj();
                        eShow.Param[2] = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells["idObjDocDGVBC"].Value);
                        eShow.SQLSettings = this.SqlSettings;
                        this.OnShowForm(eShow);
                        break;
                    case (int)DocType.Dogovor:
                        break;
                    case (int)DocType.DogovorEnergo:
                        break;
                    #region акт осмотра эл, выполнения ту, акт о тп (22/10/2014 Shumilov A/I/)
                    case (int)eTypeDocTC.ActTC:
                    case (int)eTypeDocTC.ActElectricalInspection:
                    case (int)eTypeDocTC.ActPerformingTU:
                    case (int)eTypeDocTC.ChangeSwitch: 
                        EditActTC();
                        break;
                    #endregion
                    default:
                        break;
                }
        }


        #region акт осмотра эл, выполнения ту, акт о тп (22/10/2014 Shumilov A/I/)
        private void EditActTC()
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                int typeDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value);
                int idDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idObjDocDGVBC.Name].Value);

                switch (typeDoc)
                {
                    case (int)eTypeDocTC.ActTC:
                        Documents.Forms.TechnologicalConnection.ActTC.FormTCAddEdit fTC =
                            new Documents.Forms.TechnologicalConnection.ActTC.FormTCAddEdit
                                (idDoc);
                        fTC.SqlSettings = this.SqlSettings;
                        fTC.MdiParent = this.MdiParent;
                        fTC.FormClosed += new FormClosedEventHandler(fTC_FormClosed);
                        fTC.Show();
                        break;
                    case (int)eTypeDocTC.ActPerformingTU:  // акт о выполении ТУ
                        Documents.Forms.TechnologicalConnection.Acts.FormActPerformingTU fPerf =
                            new Documents.Forms.TechnologicalConnection.Acts.FormActPerformingTU(idDoc);
                        fPerf.SqlSettings = this.SqlSettings;
                        fPerf.MdiParent = this.MdiParent;
                        fPerf.FormClosed += new FormClosedEventHandler(fTC_FormClosed);
                        fPerf.Show();
                        break;
                    case (int)eTypeDocTC.ActElectricalInspection:
                        Documents.Forms.TechnologicalConnection.Acts.FormActElectricalInspection f =
                            new Documents.Forms.TechnologicalConnection.Acts.FormActElectricalInspection(idDoc);
                        f.SqlSettings = this.SqlSettings;
                        f.MdiParent = this.MdiParent;
                        f.FormClosed += new FormClosedEventHandler(fTC_FormClosed);
                        f.Show();
                        break;
                    case (int)eTypeDocTC.ChangeSwitch:
                        Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch fChangeSwitch = 
                            new Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch(idDoc);
                        fChangeSwitch.SqlSettings = this.SqlSettings;
                        fChangeSwitch.MdiParent = this.MdiParent;
                        fChangeSwitch.FormClosed += new FormClosedEventHandler(fTC_FormClosed);
                        fChangeSwitch.Show();
                        break;
                }
            }
        }

        void fTC_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((Form)sender).DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                LoadDocActs();
            }
        }

        private void ReportActTC()
        {
            if (dgvObjDoc.CurrentRow != null)
            {
                int idDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idObjDocDGVBC.Name].Value);
                int typeDoc = Convert.ToInt32(dgvObjDoc.CurrentRow.Cells[idDocObjType.Name].Value);

                switch (typeDoc)
                {
                    case (int)eTypeDocTC.ActTC:
                    case (int)eTypeDocTC.ActPerformingTU:  // акт о выполении ТУ
                    case (int)eTypeDocTC.ActElectricalInspection:
                        Documents.Forms.TechnologicalConnection.Acts.FormReportActElectricalInspection f =
                           new Documents.Forms.TechnologicalConnection.Acts.FormReportActElectricalInspection(idDoc);
                        f.SqlSettings = this.SqlSettings;
                        f.MdiParent = this.MdiParent;
                        f.Show();
                        break;
                    case (int)eTypeDocTC.ChangeSwitch:
                        Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch fChSw =
                            new Documents.Forms.TechnologicalConnection.Rebinding.FormDocChangeSwitch(idDoc, true);
                        fChSw.SqlSettings = this.SqlSettings;
                        fChSw.MdiParent = this.MdiParent;
                        fChSw.Show();
                        break;
                }
            }
        }
        #endregion
        #endregion

        #region Поиск по доп. коду
        private void tstbDopCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
            {
                //FindLS(Convert.ToInt32(toolTxtChangeAbn.Text), GoAbonent.Current,
                //((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id, toolBtnShowDelAbn.Checked);
                string where = "where CodeAbnStr = '" + tstbDopCode.Text + "' and deleted = 0";

                DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();

                this.SelectSqlData(ds.tAbn, true, where, null, false, 1);
                if (ds.tAbn.Rows.Count > 0) // нашли
                {
                    idAbn = (int)ds.tAbn.Rows[0]["id"];
                    LoadAbonent((int)ds.tAbn.Rows[0]["CodeAbonent"], ((CmbItem)toolComboBoxTypeAbn.SelectedItem).Id);
                }
                else
                {
                    idAbn = -1;
                    MessageBox.Show("Лицевой счет не найден");
                }
                
            }
        }

        private void toolBtnAddCalcLoss_ButtonClick(object sender, EventArgs e)
        {

        }
        #endregion

        #region Копирование Документов
        private void toolBtnDocActCopy_Click(object sender, EventArgs e)
        {
            int idPoint = GetIdSelectedPoint();
            if (idPoint > 0)
            {

                FormCopyDoc fCopyDoc = new FormCopyDoc(Convert.ToInt32(dsPrv.vAbn.Rows[0]["id"]), (int)dsPrv.vAbn.Rows[0]["CodeAbonent"], idPoint, (int)Constants.DocType.ActKO);
                fCopyDoc.SqlSettings = this.SqlSettings;
                if (fCopyDoc.ShowDialog() == DialogResult.OK)
                {
                    FindLS(fCopyDoc.DestinationCA, GoAbonent.Current, (int)Constants.AbnType.Private, toolBtnShowDelAbn.Checked);
                }
            }
        }
        #endregion

        private void bindingSourceCounter_CurrentChanged(object sender, EventArgs e)
        {

        }






    }
}
