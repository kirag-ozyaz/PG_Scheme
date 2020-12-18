using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Legal.DataSet;
using DataSql;
using Constants;
using FormLbr.Classes;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;
using Legal.Classes;

namespace Legal.Forms
{
    public partial class FormAbnAkt : FormLbr.FormBase
    {

        public int IdList { get; set; }
        public int IdActTehConnection { get; set; }
        public int IdTU { get; set; }
        public int IdAbnObj { get; set; }
        public int IdAbn { get; set; }
        private StateCreate stateCreate;
        private DataRow drAdd;
        private DataRow drAddImg;
        private Boolean INF;
        System.Diagnostics.Process proc = new System.Diagnostics.Process();
        bool st = false;
        bool isShown = false;
        bool isSave = false;
        private TypeDocValue typeDocValue;

        public FormAbnAkt()
        {
            tbdBorderBalance = Activator.CreateInstance<ControlsLbr.WPF.TextBoxDropDown>();
            InitializeComponent();
            InitTextBoxDropDown();
        }

        private void InitTextBoxDropDown()
        {
            this.tbdBorderBalance = new ControlsLbr.WPF.TextBoxDropDown();
            this.hostBorderBalance.Child = this.tbdBorderBalance;
            this.tbdBorderBalance.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

            this.tbdPotrBalance = new ControlsLbr.WPF.TextBoxDropDown();
            this.hostPotrBalance.Child = this.tbdPotrBalance;
            this.tbdPotrBalance.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

            this.tbdOrgBalance = new ControlsLbr.WPF.TextBoxDropDown();
            this.hostOrgBalance.Child = this.tbdOrgBalance;
            this.tbdOrgBalance.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

            this.tbdBorder2Expl = new ControlsLbr.WPF.TextBoxDropDown();
            this.hostBorder2Expl.Child = this.tbdBorder2Expl;
            this.tbdBorder2Expl.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

            this.tbdOwnerExpl = new ControlsLbr.WPF.TextBoxDropDown();
            this.hostOwnerExpl.Child = this.tbdOwnerExpl;
            this.tbdOwnerExpl.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

            this.tbdOrganizExpl = new ControlsLbr.WPF.TextBoxDropDown();
            this.elementHost1.Child = this.tbdOrganizExpl;
            this.tbdOrganizExpl.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

            this.tbdBorder2Expl_Four = new ControlsLbr.WPF.TextBoxDropDown();
            this.hostBorder2Expl_Four.Child = this.tbdBorder2Expl_Four;
            this.tbdBorder2Expl_Four.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

            this.tbdOwnerExpl_Four = new ControlsLbr.WPF.TextBoxDropDown();
            this.hostOwnerExpl_Four.Child = this.tbdOwnerExpl_Four;
            this.tbdOwnerExpl_Four.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

            this.tbdOrganizExpl_Four = new ControlsLbr.WPF.TextBoxDropDown();
            this.hostOrganizExpl_Four.Child = this.tbdOrganizExpl_Four;
            this.tbdOrganizExpl_Four.TextChanged += new System.Windows.Controls.TextChangedEventHandler(textBox_TextChanged);

        }

        private void ComponentsReadOnly(bool value)
        {
            cbActTehConnection.Enabled = value;
            cbRegion.Enabled = value;
            tbActNumber.ReadOnly = value;
            tbAdmission.ReadOnly = value;
            tbdBorder2Expl.ReadOnly = value;
            tbdBorder2Expl_Four.ReadOnly = value;
            tbdBorderBalance.ReadOnly = value;
            tbDogByOTONum.ReadOnly = value;
            tbdOrganizExpl.ReadOnly = value;
            tbdOrganizExpl_Four.ReadOnly = value;
            tbdOrgBalance.ReadOnly = value;
            tbdOwnerExpl.ReadOnly = value;
            tbdOwnerExpl_Four.ReadOnly = value;
            tbdPotrBalance.ReadOnly = value;
            tbOrgBase.ReadOnly = value;
            tbOrgExpl.ReadOnly = value;
            tbOrgFace.ReadOnly = value;
            tbOther.ReadOnly = value;
            tbOwnerBase.ReadOnly = value;
            tbOwnerBase_Four.ReadOnly = value;
            tbOwnerChief.ReadOnly = value;
            tbOwnerChief_Four.ReadOnly = value;
            tbOwnerChief2.ReadOnly = value;
            tbOwnerChief2_Four.ReadOnly = value;
            tbOwnerName.ReadOnly = value;
            tbOwnerName_Four.ReadOnly = value;
            tbPotrExpl.ReadOnly = value;
            tbPotrSignature.ReadOnly = value;
            tbPowerMax.ReadOnly = value;
            tbPowerNom.ReadOnly = value;
            tbResponsibility.ReadOnly = value;
            tbTO1.ReadOnly = value;
            tbTO2.ReadOnly = value;
            tsbImage.Enabled = value;
            tsbRemoveImage.Enabled = value;
            toolBtnAddFile.Enabled = value;
            toolBtnEditFile.Enabled = value;
            toolBtnDelFile.Enabled = value;
            toolBtnRenameFile.Enabled = value;
            btnComplit.Enabled = value;
            btnOrgExpl.Enabled = value;
            btnPotrExpl.Enabled = value;
        }

        #region Constructor
        /// Конструктор формы добавления актов разграничения балансовой принадлежности
        public FormAbnAkt(SQLSettings settings, bool inf, bool inf1, int idAbn, int idAbnObj, TypeDocValue value)
        {
            InitializeComponent();
            InitTextBoxDropDown();
            this.SqlSettings = settings;
            this.IdAbnObj = idAbnObj;
            this.IdAbn = idAbn;
            this.IdActTehConnection = -1;
            AddNewActWithAbnObj(value);
        }

        private void AddNewActWithAbnObj(TypeDocValue value, bool inf = false)
        {
            this.IdList = -1;
            this.INF = inf;
            this.typeDocValue = value;
            this.stateCreate = StateCreate.Add;
            LoadNetRegion();
            LoadDataToTBD();
            LoadFileNameTemplate();
            this.Text = typeDocValue == TypeDocValue.ActBalance ? "Добавление акта разграничения балансовой принадлежности"
                : typeDocValue == TypeDocValue.ActLiability ? "Добавление акта разграничения эксплуатационной ответственности" : "";

            this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnDoc_Dogovor, true, " where idAbn = " + IdAbn.ToString() + " and FlagBreak = 0");

            if ((dsAbnObjAkt1.tAbnDoc_Dogovor.Count > 0) && (dsAbnObjAkt1.tAbnDoc_Dogovor.Rows[0]["BasisOF"] != System.DBNull.Value))
                tbOrgBase.Text = dsAbnObjAkt1.tAbnDoc_Dogovor.First().BasisOF;
            else
                tbOrgBase.Text = "устава";

            tbAdmission.Text = "до границы раздела " + (typeDocValue == TypeDocValue.ActBalance ? "балансовой принадлежности"
                : "эксплуатационной ответственности") + " со стороны потребителя";

            string fio = "";
            string dfio = "";
            this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tG_AbnChief, true, " where idAbn = " + IdAbn.ToString());
            if (dsAbnObjAkt1.tG_AbnChief.Rows.Count > 0)
            {
                fio = dsAbnObjAkt1.tG_AbnChief.First().R_F;
                if ((fio.Length > 0) && (dsAbnObjAkt1.tG_AbnChief.First().R_I.Length > 0))
                    fio = fio + " " + dsAbnObjAkt1.tG_AbnChief.First().R_I.Substring(0, 1) + ".";
                if ((fio.Length > 0) && (dsAbnObjAkt1.tG_AbnChief.First().R_O.Length > 0))
                    fio = fio + " " + dsAbnObjAkt1.tG_AbnChief.First().R_O.Substring(0, 1) + ".";
                dfio = (dsAbnObjAkt1.tG_AbnChief.First()["R_Post"] != DBNull.Value ? dsAbnObjAkt1.tG_AbnChief.First().R_Post : "") + " " + fio;
            }
            tbOrgFace.Text = dfio;

            if (dsAbnObjAkt1.tG_AbnChief.Rows.Count > 0)
            {
                fio = dsAbnObjAkt1.tG_AbnChief.First().I_F;
                if ((fio.Length > 0) && (dsAbnObjAkt1.tG_AbnChief.First().I_I.Length > 0))
                    fio = fio + " " + dsAbnObjAkt1.tG_AbnChief.First().I_I.Substring(0, 1) + ".";
                if ((fio.Length > 0) && (dsAbnObjAkt1.tG_AbnChief.First().I_O.Length > 0))
                    fio = fio + " " + dsAbnObjAkt1.tG_AbnChief.First().I_O.Substring(0, 1) + ".";
            }
            tbPotrSignature.Text = fio;
        }

        /// Конструктор формы добавления актов разграничения балансовой принадлежности без привязки к объекту
        public FormAbnAkt(SQLSettings settings, bool inf, int idAbn, TypeDocValue value)
        {
            InitializeComponent();
            InitTextBoxDropDown();
            this.SqlSettings = settings;
            this.IdAbn = idAbn;
            this.typeDocValue = value;
            this.IdActTehConnection = -1;
            this.IdList = -1;
            this.stateCreate = StateCreate.Add;
            LoadNetRegion();
            LoadDataToTBD();
            LoadFileNameTemplate();

            this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnDoc_Dogovor, true, " where idAbn = " + idAbn.ToString() + " and FlagBreak = 0");

            if ((dsAbnObjAkt1.tAbnDoc_Dogovor.Count > 0) && (dsAbnObjAkt1.tAbnDoc_Dogovor.Rows[0]["BasisOF"] != System.DBNull.Value))
                tbOrgBase.Text = dsAbnObjAkt1.tAbnDoc_Dogovor.First().BasisOF;
            else
                tbOrgBase.Text = "устава";

            tbAdmission.Text = "до границы раздела " + (typeDocValue == TypeDocValue.ActBalance ? "балансовой принадлежности"
                : "эксплуатационной ответственности") + " со стороны потребителя";

            string fio = "";
            string dfio = "";
            this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tG_AbnChief, true, " where idAbn = " + idAbn.ToString());
            if (dsAbnObjAkt1.tG_AbnChief.Rows.Count > 0)
            {
                fio = dsAbnObjAkt1.tG_AbnChief.First().R_F;
                if ((fio.Length > 0) && (dsAbnObjAkt1.tG_AbnChief.First().R_I.Length > 0))
                    fio = fio + " " + dsAbnObjAkt1.tG_AbnChief.First().R_I.Substring(0, 1) + ".";
                if ((fio.Length > 0) && (dsAbnObjAkt1.tG_AbnChief.First().R_O.Length > 0))
                    fio = fio + " " + dsAbnObjAkt1.tG_AbnChief.First().R_O.Substring(0, 1) + ".";
                dfio = (dsAbnObjAkt1.tG_AbnChief.First()["R_Post"] != DBNull.Value ? dsAbnObjAkt1.tG_AbnChief.First().R_Post : "") + " " + fio;
            }
            tbOrgFace.Text = dfio;
            tbPotrSignature.Text = fio;

        }

        /// Конструктор формы редактирования актов разграничения балансовой принадлежности
        public FormAbnAkt(SQLSettings settings, int idAbnObj, int idList)
        {
            InitializeComponent();
            InitTextBoxDropDown();
            this.SqlSettings = settings;
            this.IdAbnObj = idAbnObj;
            this.IdList = idList;
            this.IdActTehConnection = -1;
            this.typeDocValue = GetTypeDocValue(idList);
            this.stateCreate = StateCreate.Edit;
            LoadNetRegion();
            LoadDataToTBD();
            LoadActData(idList);
            LoadFileNameTemplate();

            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_Image, true, "where idList=" + idList + " order by id");
            if (dsAbnObjAkt1.tAbnObjDoc_Image.Count > 0)
            {
                for (int i = 0; i < dsAbnObjAkt1.tAbnObjDoc_Image.Count; i++)
                {
                    if (dsAbnObjAkt1.tAbnObjDoc_Image.Rows[i]["Scan"] != System.DBNull.Value)
                        LoadDataToGridImages((byte[])dsAbnObjAkt1.tAbnObjDoc_Image.Rows[i]["Scan"], (int)dsAbnObjAkt1.tAbnObjDoc_Image.Rows[i]["id"]);
                }
                if (dataGridViewImages.CurrentRow != null)
                    pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            this.Text = "Редактирование акта разграничения " + (typeDocValue == TypeDocValue.ActBalance ?
                "балансовой принадлежности" : "эксплуатационной ответственности");
        }

        /// Конструктор формы просмотра актов разграничения балансовой принадлежности
        public FormAbnAkt(SQLSettings settings, int idAbnObj, int idList, bool inf)
        {
            InitializeComponent();
            InitTextBoxDropDown();
            this.SqlSettings = settings;
            this.IdAbnObj = idAbnObj;
            this.IdList = idList;
            this.IdActTehConnection = -1;
            this.typeDocValue = GetTypeDocValue(idList);
            this.stateCreate = StateCreate.Show;
            LoadNetRegion();
            LoadDataToTBD();
            LoadActData(idList);
            ComponentsReadOnly(false);
            //SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_AktRBP, true, String.Format(" where idList = {0}", idList));
            LoadFileNameTemplate();

            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_Image, true, "where idList=" + idList + " order by id");
            if (dsAbnObjAkt1.tAbnObjDoc_Image.Count > 0)
            {
                for (int i = 0; i < dsAbnObjAkt1.tAbnObjDoc_Image.Count; i++)
                {
                    LoadDataToGridImages((byte[])dsAbnObjAkt1.tAbnObjDoc_Image.Rows[i]["Scan"], (int)dsAbnObjAkt1.tAbnObjDoc_Image.Rows[i]["id"]);
                }
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            this.btnComplit.Enabled = false;

            this.Text = "Просмотр акта разграничения " + (typeDocValue == TypeDocValue.ActBalance ?
                "балансовой принадлежности" : "эксплуатационной ответственности");
        }

        /// Конструктор формы копирования акта
        public FormAbnAkt(SQLSettings settings, int idAbnObj, int idList, int idAbn)
        {
            InitializeComponent();
            InitTextBoxDropDown();
            this.SqlSettings = settings;
            this.IdAbnObj = idAbnObj;
            this.IdList = idList;
            this.IdAbn = idAbn;
            this.IdActTehConnection = -1;
            this.stateCreate = StateCreate.Copy;
            this.typeDocValue = GetTypeDocValue(idList);
            LoadNetRegion();
            LoadDataToTBD();
            LoadFileNameTemplate();
            LoadActData(idList);
            /// Обновим данные о потребителе
            this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnDoc_Dogovor, true, " where idAbn = " + idAbn.ToString() + " and FlagBreak = 0");

            if ((dsAbnObjAkt1.tAbnDoc_Dogovor.Count > 0) && (dsAbnObjAkt1.tAbnDoc_Dogovor.Rows[0]["BasisOF"] != System.DBNull.Value))
                tbOrgBase.Text = dsAbnObjAkt1.tAbnDoc_Dogovor.First().BasisOF;
            else
                tbOrgBase.Text = "устава";

            tbAdmission.Text = "до границы раздела " + (typeDocValue == TypeDocValue.ActBalance ? "балансовой принадлежности"
                : "эксплуатационной ответственности") + " со стороны потребителя";

            string fio = "";
            string dfio = "";
            this.SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tG_AbnChief, true, " where idAbn = " + idAbn.ToString());
            if (dsAbnObjAkt1.tG_AbnChief.Rows.Count > 0)
            {
                fio = dsAbnObjAkt1.tG_AbnChief.First().R_F;
                if ((fio.Length > 0) && (dsAbnObjAkt1.tG_AbnChief.First().R_I.Length > 0))
                    fio = fio + " " + dsAbnObjAkt1.tG_AbnChief.First().R_I.Substring(0, 1) + ".";
                if ((fio.Length > 0) && (dsAbnObjAkt1.tG_AbnChief.First().R_O.Length > 0))
                    fio = fio + " " + dsAbnObjAkt1.tG_AbnChief.First().R_O.Substring(0, 1) + ".";
                dfio = (dsAbnObjAkt1.tG_AbnChief.First()["R_Post"] != DBNull.Value ? dsAbnObjAkt1.tG_AbnChief.First().R_Post : "") + " " + fio;
            }
            tbOrgFace.Text = dfio;
            tbPotrSignature.Text = fio;

            /// Для нового акта новый номер
            MaxNumberAct((int)typeDocValue);
            this.IdList = -1;
            this.Text = "Копирование акта разграничения" + (typeDocValue == TypeDocValue.ActBalance ?
                "балансовой принадлежности" : "эксплуатационной ответственности");
        }

        public FormAbnAkt(SQLSettings settings, int idActTeh, int idTU, TypeDocValue value)
        {
            InitializeComponent();
            InitTextBoxDropDown();
            this.SqlSettings = settings;
            this.IdActTehConnection = idActTeh;
            this.IdTU = idTU;
            string cmd = "select id, idAbn, idAbnObj from vtc_tu where id = " + idTU.ToString();

            DataTable dt = new DataTable();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            if (con.OpenConnection(this.SqlSettings))
            {
                try
                {
                    SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd, con.Connection);
                    dataAdapt.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
            if (dt.Rows.Count > 0)
            {
                IdAbn = dt.Rows[0]["idAbn"] != DBNull.Value ? (int)dt.Rows[0]["idAbn"] : -1;
                IdAbnObj = dt.Rows[0]["idAbnObj"] != DBNull.Value ? (int)dt.Rows[0]["idAbnObj"] : -1;
            }
            else
            {
                IdAbn = -1;
                IdAbnObj = -1;
            }
            AddNewActWithAbnObj(value);
        }
        #endregion

        private void FormAbnAkt_Load(object sender, EventArgs e)
        {
            lbBorder.Text = lbBorder2Expl.Text = lbBorder2Expl_Four.Text = "Границей " + (typeDocValue == TypeDocValue.ActBalance ?
                "балансовой принадлежности" : typeDocValue == TypeDocValue.ActLiability ? "эксплуатационной ответственности" : "") + " сторон является:";
        }

        private TypeDocValue GetTypeDocValue(int idList)
        {
            string query = "select c.Value from tAbnObjDoc_List d join tR_Classifier c on d.idDocType = c.id where d.id = " + idList.ToString();
            int value = 0;
            DataTable dt = new DataTable();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            if (con.OpenConnection(this.SqlSettings))
            {
                try
                {
                    SqlDataAdapter dataAdapt = new SqlDataAdapter(query, con.Connection);
                    dataAdapt.Fill(dt);
                    value = dt.Rows.Count > 0 && dt.Rows[0]["Value"] != DBNull.Value ? Int32.Parse(Math.Round((decimal)dt.Rows[0]["Value"], 0).ToString()) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
            return value > 0 ? (TypeDocValue)value : TypeDocValue.None;
        }

        private void LoadActData(int idList)
        {
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_AktRBP, true, String.Format(" where idList = {0}", idList));
            if (dsAbnObjAkt1.tAbnObjDoc_AktRBP.Count > 0)
            {
                /// Заполнение компонентов информацией из копируемого акта
                // двухсторонний акт 
                IdActTehConnection = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["idActTehConnection"] == DBNull.Value
                    ? -1 : dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().idActTehConnection;
                IdTU = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["idTU"] == DBNull.Value
                    ? -1 : dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().idTU;
                dtpActDate.Value = DateTime.Parse(dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().ActData);
                cbRegion.SelectedValue = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().NetRegion;
                tbActNumber.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().DataNumber;
                tbOrgFace.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgFace;
                tbOrgBase.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBase;
                tbdOrgBalance.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBalance;
                tbdPotrBalance.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrBalance;
                tbdBorderBalance.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().BorderBalance;
                tbOrgExpl.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgExpl;
                tbPotrExpl.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrExpl;
                tbResponsibility.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Responsibility;
                tbAdmission.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Admission;
                tbPotrSignature.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrSignature;
                tbOther.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["Other"] == DBNull.Value
                    ? "" : dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Other;
                // трехсторонний акт
                tbOwnerName.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerName;
                tbOwnerChief.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief;
                tbOwnerBase.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerBase;
                tbdOrganizExpl.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrganizExpl;
                tbdOwnerExpl.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrebExpl;
                tbdBorder2Expl.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().BorderExpl;
                tbOwnerChief2.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief2;
                // Дополнительные поля для акта c ТО
                tbDogByOTONum.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbDogByOTONum;
                tbTO2.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbTO2;
                tbTO1.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbTO1;
                // Четырехсторонний акт
                tbOwnerName_Four.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerName_Four;
                tbOwnerChief_Four.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief_Four;
                tbOwnerBase_Four.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerBase_Four;
                tbdOrganizExpl_Four.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrganizExpl_Four;
                tbdBorder2Expl_Four.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Border2Expl_Four;
                tbdOwnerExpl_Four.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerExpl_Four;
                tbOwnerChief2_Four.Text = dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief2_Four;
            }
        }

        // добавить в менюшку имена шаблонов
        private void LoadFileNameTemplate()
        {
            DataSql.SqlDataCommand cmd = new DataSql.SqlDataCommand(this.SqlSettings);
            DataTable dt = cmd.SelectSqlData(" SELECT doc.id, doc.FileName " +
                                                " FROM tR_DocTemplate AS doc " +
                                                " INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id " +
                                                " WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 3 and doc.deleted = 0");
            foreach (DataRow r in dt.Rows)
            {

                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = r["FileName"].ToString();
                item.Tag = r["id"];
                item.Click += new EventHandler(toolBtnAddFile_Click);
                toolBtnAddFile.DropDownItems.Add(item);

                ToolStripMenuItem itemMenu = new ToolStripMenuItem();
                itemMenu.Text = r["FileName"].ToString();
                itemMenu.Tag = r["id"];
                itemMenu.Click += new EventHandler(toolBtnAddFile_Click);
                toolMenuItemAddFile.DropDownItems.Add(itemMenu);
            }
        }

        void toolBtnAddFile_Click(object sender, EventArgs e)
        {
            string path = "", fileName = "";
            ExportToWord(path, fileName, sender, true);
        }

        /// Загрузка сетевых районов в комбобокс
        private void LoadNetRegion()
        {
            DataTable dt = SelectSqlData("tR_Classifier", true, "WHERE ParentKey = ';NetworkAreas;' AND isGroup = ((0)) AND Deleted = ((0))");
            DataRow dr = dt.NewRow();
            dr["id"] = -1;
            dr["Name"] = "";
            dr["isGroup"] = 0;
            dr["Deleted"] = 0;
            dt.Rows.Add(dr);
            cbRegion.DataSource = dt;
            cbRegion.DisplayMember = "Name";
            cbRegion.ValueMember = "Id";
            cbRegion.SelectedValue = -1;
        }

        /// Заполнение выпадающих списков данными
        private void LoadDataToTBD()
        {
            string connection;
            if (this.SqlSettings.Autentification == "WINDOWS")
                connection = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=true",
                    this.SqlSettings.ServerDB, this.SqlSettings.DBName);
            //connection = String.Format("Provider=SQLNCLI10.1;Integrated Security=SSPI;Persist Security Info=False;User ID={0};Initial Catalog=GES;Data Source=ULGES-SQL2;Initial File Name={1};Server SPN={2}", "","","");
            else
                connection = "Server=" + this.SqlSettings.ServerDB + "; dataBase=" + this.SqlSettings.DBName +
                    "; " + "uid=" + this.SqlSettings.SqlUserConnect + ";pwd=" + this.SqlSettings.SqlPasswConnect +
                    ";Integrated Security=false" + "; Connection TimeOut = 180";

            tbdOrgBalance.TextBoxWidth = hostOrgBalance.Width;
            tbdOrgBalance.Connection = connection;
            tbdOrgBalance.NumberField = 1;
            tbdPotrBalance.TextBoxWidth = hostPotrBalance.Width;
            tbdPotrBalance.Connection = connection;
            tbdPotrBalance.NumberField = 2;
            tbdBorderBalance.TextBoxWidth = hostBorderBalance.Width;
            tbdBorderBalance.Connection = connection;
            tbdBorderBalance.NumberField = 3;
        }

        private void LoadDataToGridImages(Byte[] ImageData, int id)
        {
            try
            {
                Bitmap bmp = ImageCompress.LoadBitmap(ImageData);
                if (bmp != null)
                {
                    dataGridViewImages.Rows.Add(new Bitmap(bmp, 120, 160), bmp, true, id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// Добавление в таблицу tAbnObjDoc_List новой записи
        private Int32 AddDataToList(Int32 idAbnObj, String DocNumber, DateTime date, int idDocType)
        {
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_List, true, " where idAbnObj = " +
                idAbnObj.ToString() + " and  idDocType=" + idDocType.ToString() + " and isActive = 1", true);
            if (dsAbnObjAkt1.tAbnObjDoc_List.Rows.Count > 0)
            {
                dsAbnObjAkt1.tAbnObjDoc_List.First().isActive = false;
                UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_List);
            }

            drAdd = dsAbnObjAkt1.tAbnObjDoc_List.NewRow();
            drAdd["idAbnObj"] = idAbnObj;
            drAdd["DocNumber"] = DocNumber;
            drAdd["DocDate"] = date;
            drAdd["idDocType"] = idDocType;
            drAdd["isActive"] = true;
            drAdd["Deleted"] = false;
            drAdd["idAbn"] = IdAbn;
            dsAbnObjAkt1.tAbnObjDoc_List.Rows.Add(drAdd);
            InsertSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_List);
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_List, true, " where idAbnObj = " + idAbnObj.ToString() + " and  idDocType=" + ((int)idDocType).ToString() + " and  isActive = 1 order by id desc ", true);
            if (dsAbnObjAkt1.tAbnObjDoc_List.Rows.Count > 0)
                return Convert.ToInt32(dsAbnObjAkt1.tAbnObjDoc_List.First().id);
            else
                throw new Exception("Ошибка", new Exception("Не удалось добавить документ")); ;
        }

        /// Сохранение добавления/изменения в БД
        private bool SaveDataToDB()
        {
            if ((cbRegion.SelectedValue == null || (int)cbRegion.SelectedValue == -1) || (tbActNumber.Text == ""))
            {
                MessageBox.Show("Не выбран район или отсутствует номер акта");
                return false;
            }
            else
                try
                {
                    int idTypeDoc = (int)CallSQLScalarFunction("dbo.fn_GetIdClassifier", ";TypeDoc;tAbnObj;", ((Int32)typeDocValue).ToString());

                    //String data = CollectionOfDataFormTabs();
                    btnComplit.DialogResult = System.Windows.Forms.DialogResult.OK;

                    if (IdList == -1)
                    {
                        // новый акт
                        IdList = AddDataToList(IdAbnObj, tbActNumber.Text, dtpActDate.Value, idTypeDoc);
                        if (IdList != -1)
                        {
                            drAdd = dsAbnObjAkt1.tAbnObjDoc_AktRBP.NewRow();
                            drAdd["idList"] = IdList;
                            if (IdActTehConnection != -1)
                                drAdd["idActTehConnection"] = IdActTehConnection;
                            else
                                drAdd["idActTehConnection"] = DBNull.Value;
                            if (IdTU != -1)
                                drAdd["idTU"] = IdTU;
                            else
                                drAdd["idTU"] = DBNull.Value;
                            
                            // двухсторонний акт 
                            drAdd["ActData"] = dtpActDate.Value.ToShortDateString();
                            drAdd["NetRegion"] = (int)cbRegion.SelectedValue;
                            drAdd["DataNumber"] = tbActNumber.Text;
                            drAdd["OrgFace"] = tbOrgFace.Text;
                            drAdd["OrgBase"] = tbOrgBase.Text;
                            drAdd["OrgBalance"] = tbdOrgBalance.Text;
                            drAdd["PotrBalance"] = tbdPotrBalance.Text;
                            drAdd["BorderBalance"] = tbdBorderBalance.Text;
                            drAdd["OrgExpl"] = tbOrgExpl.Text;
                            drAdd["PotrExpl"] = tbPotrExpl.Text;
                            drAdd["Responsibility"] = tbResponsibility.Text;
                            drAdd["Admission"] = tbAdmission.Text;
                            drAdd["PotrSignature"] = tbPotrSignature.Text;
                            drAdd["Other"] = tbOther.Text;
                            // трехсторонний акт
                            drAdd["OwnerName"] = tbOwnerName.Text;
                            drAdd["OwnerChief"] = tbOwnerChief.Text;
                            drAdd["OwnerBase"] = tbOwnerBase.Text;
                            drAdd["OrganizExpl"] = tbdOrganizExpl.Text;
                            drAdd["PotrebExpl"] = tbdOwnerExpl.Text;
                            drAdd["BorderExpl"] = tbdBorder2Expl.Text;
                            drAdd["OwnerChief2"] = tbOwnerChief2.Text;
                            // Дополнительные поля для акта c ТО
                            drAdd["tbDogByOTONum"] = tbDogByOTONum.Text;
                            drAdd["tbTO2"] = tbTO2.Text;
                            drAdd["tbTO1"] = tbTO1.Text;
                            // Четырехсторонний акт
                            drAdd["OwnerName_Four"] = tbOwnerName_Four.Text;
                            drAdd["OwnerChief_Four"] = tbOwnerChief_Four.Text;
                            drAdd["OwnerBase_Four"] = tbOwnerBase_Four.Text;
                            drAdd["OrganizExpl_Four"] = tbdOrganizExpl_Four.Text;
                            drAdd["Border2Expl_Four"] = tbdBorder2Expl_Four.Text;
                            drAdd["OwnerExpl_Four"] = tbdOwnerExpl_Four.Text;
                            drAdd["OwnerChief2_Four"] = tbOwnerChief2_Four.Text;
                            dsAbnObjAkt1.tAbnObjDoc_AktRBP.Rows.Add(drAdd);
                            InsertSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_AktRBP);

                            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbn, true, String.Format("WHERE id = {0} AND TypeAbn = 1038", IdAbn));
                            if (dsAbnObjAkt1.tAbn.Rows.Count == 1)
                            {
                                dsAbnObjAkt1.tAbn.Rows[0]["TypeAbn"] = 207;
                                UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbn);
                            }

                            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObj, true, String.Format("WHERE id = {0} AND typeObj = 1149", IdAbnObj));
                            if (dsAbnObjAkt1.tAbnObj.Rows.Count == 1)
                            {
                                dsAbnObjAkt1.tAbn.Rows[0]["typeObj"] = 1147;
                                UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObj);
                            }

                            if (INF == true && this.Owner != null)
                            {
                                Document.FormActBalance frm = (Document.FormActBalance)this.Owner;
                                // вернем в родительскую форму ID нового акта
                                frm.IDLIST = IdList;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не удалось сохранить акт.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // редактирование акта
                        SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_AktRBP, true, " where idList = " + IdList);
                        SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_List, true, "where id = " + IdList);
                        // двухсторонний акт 
                        if (IdActTehConnection != -1)
                            dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["idActTehConnection"] = IdActTehConnection;
                        else
                            dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["idActTehConnection"] = DBNull.Value;
                        if (IdTU != -1)
                            dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["idTU"] = IdTU;
                        else
                            dsAbnObjAkt1.tAbnObjDoc_AktRBP.First()["idTU"] = DBNull.Value;
                        dsAbnObjAkt1.tAbnObjDoc_List.First().DocDate = dtpActDate.Value;
                        dsAbnObjAkt1.tAbnObjDoc_List.First().DocNumber = tbActNumber.Text;

                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().ActData = dtpActDate.Value.ToShortDateString();
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().NetRegion = (int)cbRegion.SelectedValue;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().DataNumber = tbActNumber.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgFace = tbOrgFace.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBase = tbOrgBase.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgBalance = tbdOrgBalance.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrBalance = tbdPotrBalance.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().BorderBalance = tbdBorderBalance.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrgExpl = tbOrgExpl.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrExpl = tbPotrExpl.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Responsibility = tbResponsibility.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Admission = tbAdmission.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrSignature = tbPotrSignature.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Other = tbOther.Text;
                        // трехсторонний акт
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerName = tbOwnerName.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief = tbOwnerChief.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerBase = tbOwnerBase.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrganizExpl = tbdOrganizExpl.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().PotrebExpl = tbdOwnerExpl.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().BorderExpl = tbdBorder2Expl.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief2 = tbOwnerChief2.Text;
                        // Дополнительные поля для акта c ТО
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbDogByOTONum = tbDogByOTONum.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbTO2 = tbTO2.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().tbTO1 = tbTO1.Text;
                        // Четырехсторонний акт
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerName_Four = tbOwnerName_Four.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief_Four = tbOwnerChief_Four.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerBase_Four = tbOwnerBase_Four.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OrganizExpl_Four = tbdOrganizExpl_Four.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().Border2Expl_Four = tbdBorder2Expl_Four.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerExpl_Four = tbdOwnerExpl_Four.Text;
                        dsAbnObjAkt1.tAbnObjDoc_AktRBP.First().OwnerChief2_Four = tbOwnerChief2_Four.Text;
                        UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_List);
                        UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_AktRBP);
                    }

                    SaveFiles(IdList);
                    this.DialogResult = DialogResult.OK;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
        }

        private void btnOrgExpl_Click(object sender, EventArgs e)
        {
            tbOrgExpl.Text = tbdOrgBalance.Text;
        }

        private void btnPotrExpl_Click(object sender, EventArgs e)
        {
            tbPotrExpl.Text = tbdPotrBalance.Text;
        }

        private void btnComplit_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveDataToDB())
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDogByOTONum_TextChanged(object sender, EventArgs e)
        {
            if (tbDogByOTONum.Text != "")
            {
                tbResponsibility.Text = "";
                tbResponsibility.Enabled = false;
            }
            else tbResponsibility.Enabled = true;
        }

        private void tsbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "JPEG Documents|*.jpg";
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap img = new Bitmap(fileOpen.FileName);

                drAddImg = dsAbnObjAkt1.tAbnObjDoc_Image.NewRow();
                drAddImg["idList"] = IdList;
                drAddImg["Scan"] = ImageCompress.GetCompressBytes((Image)img, 30L);
                dsAbnObjAkt1.tAbnObjDoc_Image.Rows.Add(drAddImg);

                InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_Image);

                drAddImg.AcceptChanges();

                pbScanDoc.Image = ImageCompress.LoadBitmap(fileOpen.FileName);
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
                dataGridViewImages.Rows.Add(new Bitmap(img, 120, 160), ImageCompress.LoadBitmap(fileOpen.FileName), false);

                img.Dispose();
                isSave = true;
            }
        }

        private void dataGridViewImages_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0) // если левой кнопкой
            {
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;

                this.dataGridViewImages.Rows[e.RowIndex].Selected = true;
                dataGridViewImages.CurrentCell = dataGridViewImages[0, e.RowIndex]; //делаем текущей
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
                this.contextMenuStripImage.Show(System.Windows.Forms.Cursor.Position);
            }
        }

        private void tsbRemoveImage_Click(object sender, EventArgs e)
        {
            if (DeleteSqlDataById(dsAbnObjAkt1.tAbnObjDoc_Image, (int)dataGridViewImages.CurrentRow.Cells["id"].Value))
            {
                dataGridViewImages.Rows.RemoveAt(dataGridViewImages.CurrentRow.Index);
                MessageBox.Show("Изображение удалено..");
                isSave = true;
            }
            else
                MessageBox.Show("Изображение удалить не удалось..");
        }

        private void tsbSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";

            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(pbScanDoc.Image, fileSave.FileName);
                MessageBox.Show("Изображение успешно сохранено.");
            }

        }

        // поиск нового номера акта
        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";
            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(pbScanDoc.Image, fileSave.FileName);
            }

            if (fileSave.FileName != "")
            {
                proc.StartInfo.FileName = fileSave.FileName; //указываем имя файла с изображением
                st = true; //указываем, что процесс запускается
                proc.EnableRaisingEvents = true; //при закрытии файла будет вызвано событие Exited
                proc.Exited += new EventHandler(proc_Exited); //добавляем обработчик события
                proc.Start(); //запускаем программу просмотра изображения
            }
            else
            {
                MessageBox.Show("Отсутствует имя файла!");
            }

        }

        void proc_Exited(object sender, EventArgs e)
        {
            st = false;
            proc.Exited -= new EventHandler(proc_Exited); //убираем обработчик
        }

        private void MaxNumberAct(int typeDocValue)
        {
            if ((int)cbRegion.SelectedValue != -1)
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);
                    string strCmd = "";
                    strCmd = "select dbo.fn_GetMaxNumAct(@Region, @ActYear, @TypeDocValue)";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                    SqlParameter p1 = new SqlParameter("@Region", (int)cbRegion.SelectedValue);
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("@ActYear", (int)dtpActDate.Value.Year);
                    sqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter("@TypeDocValue", typeDocValue);
                    sqlCmd.Parameters.Add(p3);

                    sqlCmd.CommandTimeout = 0;

                    string Result = sqlCmd.ExecuteScalar().ToString();

                    tbActNumber.Text = Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
            else
            {
                tbActNumber.Text = "";
            }
        }

        private void cbRegion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbRegion.SelectedValue is int && stateCreate == StateCreate.Add)
            {
                MaxNumberAct((int)typeDocValue);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        #region Files

        Dictionary<string, FileWatcherArgsAddl> files = new Dictionary<string, FileWatcherArgsAddl>();

        /// <summary> Добавить существующий файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolItemAddExistFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Multiselect = true;
            if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in dlgOpen.FileNames)
                {

                    string filename = AddFileInDocument(fileName, null, null, true);
                    if (!string.IsNullOrEmpty(filename))
                        isSave = true;
                }
            }
        }

        private void toolBtnEditFile_Click(object sender, EventArgs e)
        {
            OpenFile(true);
        }

        private void toolBtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolBtnDelFile_Click(object sender, EventArgs e)
        {
            if (bsFiles.Current != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    dsAbnObjAct.tAbnObjDoc_FileRow r = (dsAbnObjAct.tAbnObjDoc_FileRow)((DataRowView)bsFiles.Current).Row;
                    string fileName = r.FileName;
                    if (files.ContainsKey(fileName))
                    {
                        if (files[fileName].Watcher != null)
                        {
                            files[fileName].Watcher.AnyChanged -= watcher_AnyChanged;
                            files[fileName].Watcher.Stop();
                        }
                        files.Remove(fileName);
                    }
                    r.Delete();
                    isSave = true;
                }
            }
        }

        string oldFileName = "";
        private void toolBtnRenameFile_Click(object sender, EventArgs e)
        {
            if (dgvFile.CurrentRow != null)
            {
                oldFileName = dgvFile.CurrentRow.Cells[fileNameDgvColumn.Name].Value.ToString();
                dgvFile.CurrentCell = dgvFile.CurrentRow.Cells[fileNameDgvColumn.Name];
                dgvFile.CurrentCell.Value = System.IO.Path.GetFileNameWithoutExtension(oldFileName);
                dgvFile.ReadOnly = false;
                fileNameDgvColumn.ReadOnly = false;
                dgvFile.BeginEdit(true);
            }
        }

        private void toolBtnSaveFile_Click(object sender, EventArgs e)
        {
            if (bsFiles.Current != null)
            {
                dsAbnObjAct.tAbnObjDoc_FileRow r = (dsAbnObjAct.tAbnObjDoc_FileRow)((DataRowView)bsFiles.Current).Row;
                if (r["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(this.SqlSettings.GetConnectionString()))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("SELECT [File] FROM tTC_DocFile WHERE id = " + r["id"].ToString(), conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                                r["File"] = dr["File"];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                }
                byte[] fileData = r.File;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = r.FileName;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    ByteArrayToFile(dialog.FileName, fileData);

            }
        }

        private void dgvFile_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (((DataGridView)sender).RowCount > 0) // есть строки
            {
                if (dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value != null)
                {
                    if (e.ColumnIndex == dgvFile.Columns[imageDgvColumn.Name].Index) // столбец картинки
                    {
                        if (!string.IsNullOrEmpty(System.IO.Path.GetFileName(dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value.ToString())))
                            e.Value = System.IO.Path.GetFileName(dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value.ToString());
                        else
                            e.Value = dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value.ToString();
                    }
                    if (e.ColumnIndex == dgvFile.Columns[imageDgvColumn.Name].Index) // столбец картинки
                    {
                        Icon ico = FormLbr.Classes.FileInfo.IconOfFile(dgvFile[fileNameDgvColumn.Name, e.RowIndex].Value.ToString());
                        if (ico != null) e.Value = ico.ToBitmap();
                    }
                }
            }
        }

        private void dgvFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolBtnOpenFile_Click(sender, e);
        }

        private void dgvFile_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvFile.ReadOnly = true;
            fileNameDgvColumn.ReadOnly = true;

            string newFileName = dgvFile[e.ColumnIndex, e.RowIndex].Value.ToString() + System.IO.Path.GetExtension(oldFileName);
            if (newFileName == oldFileName) return;

            if (files.ContainsKey(oldFileName))
            {
                FileWatcherArgsAddl fw = files[oldFileName];
                fw.OriginalName = newFileName;
                files.Remove(oldFileName);
                files.Add(newFileName, fw);
            }
            dgvFile[e.ColumnIndex, e.RowIndex].Value = newFileName;
            isSave = true;
            oldFileName = null;
        }

        private void dgvFile_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(oldFileName))
                {
                    string newFileName = e.FormattedValue + System.IO.Path.GetExtension(oldFileName);
                    if (newFileName == oldFileName) return;

                    if (files.ContainsKey(newFileName))
                    {
                        MessageBox.Show("Файл с таким именем уже существует", "");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dgvFile_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                dgvFile.ClearSelection();
                dgvFile.Rows[e.RowIndex].Selected = true;
                dgvFile.CurrentCell = dgvFile[e.ColumnIndex, e.RowIndex];
                Rectangle r = dgvFile.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                contextMenuFile.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            }
        }

        private void dgvFile_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        // создание акта в Word
        public void CreateActRbp(string AbnName, string fullFileName)
        {
            // переменные
            #region
            // телефон потребителя
            String PhoneNumber = "";
            string dateDoc = "";
            string numDoc = "";
            string powerMax = "";
            string powerNom = "";
            // должность и фио потребителя
            // String FaceOrg = "";
            //String OrgSignature = "";

            // для потребителей имеющих договор по транспорту
            String Dogovor = "";
            // путь для сохранения документа Word
            //string FileSavePath = "";
            // адрес потребителя
            string AbnAddress = "";
            #endregion

            // подготовим данные для экспорта
            #region

            DocType docType = DocType.Dogovor;
            // привязка к договору по транспорту
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnDoc_List, true, String.Format(" where idAbn = {0} and idDocType = {1} and isActive <> 0 and Deleted = 0", IdAbn, (int)docType), true);
            if (dsAbnObjAkt1.tAbnDoc_List.Rows.Count > 0)
                Dogovor = String.Format("Приложение №4 к договору № {0} от {1} г.", dsAbnObjAkt1.tAbnDoc_List.First().DocNumber.Trim(), dsAbnObjAkt1.tAbnDoc_List.First().DocDate.ToShortDateString());

            // телефон - нужен телефон ОДС - пока заложен жестко
            //SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tInfo, true, " order by LeaveDate desc");
            //if (dsAbnObjAkt1.tInfo.Rows.Count > 0)
            //    PhoneNumber = dsAbnObjAkt1.tInfo.Rows[0]["Info_Phone"].ToString().Trim();

            // должность и ФИО МУП УльГЭС 
            //SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vAbnAktFaceOrg, true, String.Format("where idclassifier = {0}", (int)docType), true);
            //if (dsAbnObjAkt1.vAbnAktFaceOrg.Rows.Count > 0)
            //{
            //    FaceOrg = dsAbnObjAkt1.vAbnAktFaceOrg.Rows[0]["Post_RP"].ToString().Trim() + " " + dsAbnObjAkt1.vAbnAktFaceOrg.Rows[0]["fio_reversshort"].ToString().Trim();
            //    OrgSignature = dsAbnObjAkt1.vAbnAktFaceOrg.Rows[0]["fio_reversshort"].ToString().Trim();
            //}

            // добавим юридический адрес
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tG_AbnAddress, true, String.Format(" where idAbn = {0} and idTypeAddress = {1} order by DateChange desc", IdAbn, 54), true);
            if (dsAbnDocum1.tG_AbnAddress.Count > 0)
                AbnAddress = dsAbnDocum1.tG_AbnAddress.First().Representation;

            // определим номер телефона
            SelectSqlData(dsAbnDocum1, dsAbnDocum1.tAbnContact, true, " where idAbn = " + IdAbn + " and Post LIKE 'ОДС'", true);
            if (dsAbnDocum1.tAbnContact.Count > 0)
                PhoneNumber = dsAbnDocum1.tAbnContact.First().Phone;

            if (IdActTehConnection != -1)
            {
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tTC_Doc, true, String.Format("WHERE id = {0}", IdActTehConnection));
                if (dsAbnObjAkt1.tTC_Doc.Rows.Count > 0)
                {
                    dateDoc = dsAbnObjAkt1.tTC_Doc.First()["dateDoc"] == DBNull.Value
                        ? "" : dsAbnObjAkt1.tTC_Doc.First().dateDoc.ToShortDateString();
                    numDoc = dsAbnObjAkt1.tTC_Doc.First()["numDoc"] == DBNull.Value
                        ? "" : dsAbnObjAkt1.tTC_Doc.First().numDoc.ToString();
                }

                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tTC_ActTC, true, String.Format("WHERE id = {0}", IdActTehConnection));
                if (dsAbnObjAkt1.tTC_ActTC.Rows.Count > 0)
                {

                    powerMax = dsAbnObjAkt1.tTC_ActTC.First()["PowerSum"] == DBNull.Value
                        ? "" : dsAbnObjAkt1.tTC_ActTC.First().PowerSum.ToString();
                    powerNom = "";
                }

                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vTC_TUPointAttach, true, String.Format("WHERE idTU = {0}", IdActTehConnection));
            }

            #endregion

            // создание документа Word на основе шаблона и заполнение полей данными
            #region

            OfficeLB.Word.Application word = null;
            OfficeLB.Word.Selection selection = null;
            try
            {
                /// Инициализируем экземпляр класса Application и запускаем приложение Word
                word = new OfficeLB.Word.Application();
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутствует предустановленный MS Office Word", "Ошибка MS Office", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (word != null)
            {
                try
                {
                    word.Documents.Open(fullFileName);
                    selection = word.Selection;
                    if (Dogovor.Length > 0)
                        selection.FindAndReplace("[Привязка_кдоговору]", Dogovor, true);
                    else
                    {
                        selection.FindAndReplace("[Привязка_кдоговору]", "", true);
                    }
                    selection.FindAndReplace("[Абонент_наименование]", AbnName + " " + AbnAddress, true);
                    selection.FindAndReplace("[Телефон]", "32-32-34", true);
                    selection.FindAndReplace("[Телефон2]", PhoneNumber, true);

                    // заполняем поля в шаблоне
                    #region
                    string NumberAct_Region = "";
                    string NumberAct = "";
                    // двухсторонний акт

                    DataTable dt = SelectSqlData("tR_Classifier", true, "WHERE id = " + cbRegion.SelectedValue.ToString());

                    NumberAct_Region = dt.Rows.Count > 0 ? Math.Round((decimal)dt.Rows[0]["Value"], 0).ToString() : "";

                    selection.FindAndReplace("[Номер_района]", NumberAct_Region, true);
                    /// Имя начальника района на подпись
                    String RegionSign = "";

                    SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vP_Worker, true, String.Format(" where ParentKey = ';GroupWorker;HeadRegionApart;' AND Value = {0}",
                        dt.Rows.Count > 0 ? dt.Rows[0]["Value"].ToString().Replace(',', '.') : "-1"), true);
                    if (dsAbnObjAkt1.vP_Worker.Rows.Count > 0)
                        RegionSign = dsAbnObjAkt1.vP_Worker.Rows[0]["FIO"].ToString().Trim();

                    selection.FindAndReplace("[Начальник_района]", RegionSign, true);
                    selection.FindAndReplace("[Дата_Акта]", dtpActDate.Value.ToShortDateString(), true);
                    NumberAct = NumberAct_Region + "/" + tbActNumber.Text + "/" + dtpActDate.Value.Year.ToString().Substring(2, 2);
                    selection.FindAndReplace("[Номер_Акта]", NumberAct, true);
                    selection.FindAndReplace("[Потребитель_влице]", tbOrgFace.Text, true);
                    selection.FindAndReplace("[Потребитель_Основание]", tbOrgBase.Text, true);
                    selection.Find.ClearFormatting();
                    selection.Find.Text = "[Сетевая_оборудование]";
                    if (selection.Find.Execute())
                    {
                        selection.FindAndReplace("[Сетевая_оборудование]", tbdOrgBalance.Text, false);
                        selection.FindAndReplace("[Сетевая_оборудование]", "", true);
                    }
                    selection.Find.ClearFormatting();
                    selection.Find.Text = "[Потребитель_оборудование]";
                    if (selection.Find.Execute())
                    {
                        selection.FindAndReplace("[Потребитель_оборудование]", tbdPotrBalance.Text, false);
                        selection.FindAndReplace("[Потребитель_оборудование]", "", true);
                    }
                    selection.Find.ClearFormatting();
                    selection.Find.Text = "[Граница]";
                    if (selection.Find.Execute())
                    {
                        selection.FindAndReplace("[Граница]", tbdBorderBalance.Text, false);
                        selection.FindAndReplace("[Граница]", "", true);
                    }
                    selection.FindAndReplace("[Сетевая_эксплуатация]", tbOrgExpl.Text, false);
                    selection.FindAndReplace("[Сетевая_эксплуатация]", "", true);
                    selection.FindAndReplace("[Потребитель_эксплуатация]", tbPotrExpl.Text, false);
                    selection.FindAndReplace("[Потребитель_эксплуатация]", "", true);
                    selection.FindAndReplace("[Ответственность]", tbResponsibility.Text, false);
                    selection.FindAndReplace("[Ответственность]", "", true);
                    if (selection.FindAndReplace("[Ответственность2]", "[Ответственность2]", true))
                    {
                        selection.FindAndReplace("[Ответственность2]", tbResponsibility.Text, false);
                    }
                    selection.FindAndReplace("[Потребитель_допуск]", tbAdmission.Text, false);
                    selection.FindAndReplace("[Потребитель_допуск]", "", true);
                    selection.FindAndReplace("[Потребитель_подпись]", tbPotrSignature.Text, true);

                    #region NewAct
                    selection.FindAndReplace("[Дата тех прис]", dateDoc.Length == 0 ? "                  " : dateDoc, true);
                    selection.FindAndReplace("[Номер тех прис]", numDoc.Length == 0 ? "                  " : numDoc, true);
                    selection.FindAndReplace("[Макс мощность]", powerMax.Length == 0 ? "        " : powerMax, true);
                    selection.FindAndReplace("[Ном мощность]", powerNom.Length == 0 ? "        " : powerNom, true);
                    selection.FindAndReplace("[Адрес границы]", "                                                               " +
                        "                                                                                                       ", true);
                    if (tbOther.Text.Length > 0)
                        selection.FindAndReplace("[Прочее]", tbOther.Text, false);
                    else
                        selection.FindAndReplace("[Прочее]", "                                                                  " +
                            "                                                                                                 ", true);


                    if (word.ActiveDocument.Tables.Count == 3
                        && word.ActiveDocument.Tables[1].Columns.Count == 7
                        && word.ActiveDocument.Tables[2].Columns.Count == 2
                        && word.ActiveDocument.Tables[3].Columns.Count == 1)
                    {
                        OfficeLB.Word.Table tablePA = word.ActiveDocument.Tables[1];

                        for (int i = 0; i < dsAbnObjAkt1.vTC_TUPointAttach.Count; i++)
                        {
                            OfficeLB.Word.Row row = null;
                            row = tablePA.Rows[i + 2];
                            OfficeLB.Word.Range rng = row.Cells[1].Range;
                            row.Cells[1].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["AttachmentPoint"].ToString();
                            row.Cells[2].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["PowerSupply"].ToString();
                            row.Cells[3].Range.Text = "";
                            row.Cells[4].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["voltagelevelname"].ToString();
                            row.Cells[5].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["powersum"].ToString();
                            row.Cells[6].Range.Text = "";
                            row.Cells[7].Range.Text = dsAbnObjAkt1.vTC_TUPointAttach.Rows[i]["Category"].ToString();

                            if (tablePA.Rows.Count != dsAbnObjAkt1.vTC_TUPointAttach.Count + 1)
                            {
                                tablePA.Rows.Add();
                            }
                        }

                        OfficeLB.Word.Table tableEquipment = word.ActiveDocument.Tables[2];

                        tableEquipment.Rows[2].Cells[1].Range.Text = tbdOrgBalance.Text;
                        tableEquipment.Rows[2].Cells[2].Range.Text = tbdPotrBalance.Text;

                    }

                    #endregion

                    // трехсторонний акт
                    selection.FindAndReplace("[Владелец_имя]", tbOwnerName.Text, true);
                    selection.FindAndReplace("[Владелец_влице]", tbOwnerChief.Text, true);
                    selection.FindAndReplace("[Владелец_основание]", tbOwnerBase.Text, true);
                    selection.FindAndReplace("[Владелец_оборудование]", tbdOrganizExpl.Text, false);
                    selection.FindAndReplace("[Владелец_оборудование]", "", true);
                    selection.FindAndReplace("[Владелец_эксплуатация]", tbdOwnerExpl.Text, false);
                    selection.FindAndReplace("[Владелец_эксплуатация]", "", true);
                    selection.FindAndReplace("[Граница2]", tbdBorder2Expl.Text, false);
                    selection.FindAndReplace("[Граница2]", "", true);
                    selection.FindAndReplace("[Владелец_подпись]", tbOwnerChief2.Text, true);

                    // Дополнительные поля для акта c ТО
                    selection.FindAndReplace("[Номер_ОТО]", tbDogByOTONum.Text, false);
                    selection.FindAndReplace("[Номер_ОТО]", "", true);
                    selection.FindAndReplace("[Договор_ОТО2]", tbTO2.Text, false);
                    selection.FindAndReplace("[Договор_ОТО2]", "", true);
                    selection.FindAndReplace("[Договор_OTO1]", tbTO1.Text, false);
                    selection.FindAndReplace("[Договор_OTO1]", "", true);

                    // Четырехсторонний акт
                    selection.FindAndReplace("[Владелец2_имя]", tbOwnerName_Four.Text, true);
                    selection.FindAndReplace("[Владелец2_влице]", tbOwnerChief2_Four.Text, true);
                    selection.FindAndReplace("[Владелец2_основание]", tbOwnerBase_Four.Text, true);
                    selection.FindAndReplace("[Владелец2_оборудование]", tbdOrganizExpl_Four.Text, false);
                    selection.FindAndReplace("[Владелец2_оборудование]", "", true);
                    selection.FindAndReplace("[Владелец2_эксплуатация]", tbdOwnerExpl_Four.Text, false);
                    selection.FindAndReplace("[Владелец2_эксплуатация]", "", true);
                    selection.FindAndReplace("[Граница3]", tbdBorder2Expl_Four.Text, false);
                    selection.FindAndReplace("[Граница3]", "", true);
                    selection.FindAndReplace("[Владелец2_подпись]", tbOwnerChief2_Four.Text, true);

                    #endregion
                }
                catch (Exception ex)
                {
#if DEBUG
                        MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                    MessageBox.Show("Не удалось создать документ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                }

                selection = null;

                try
                {
                    word.ActiveDocument.Save();
                    word.Visible = true;
                }
                catch (Exception ex)
                {
                    word.Quit();
#if DEBUG
                        MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                    MessageBox.Show("Не удалось сохранить документ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                }
            }
            #endregion
        }


        /// <summary> Получает путь к папке с файлами
        /// </summary>
        /// <returns></returns>
        private string GetDirectoryPath(string NumDoc)
        {
            string dir = string.IsNullOrEmpty(NumDoc) ? NumDoc : "tmp";
            var path = System.IO.Path.GetTempPath() + "\\" + dir + "\\";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            return path;
        }

        /// <summary> Получает шаблон нового файла 
        /// </summary>
        /// <param name="idTemplate">Идентификатор шаблона</param>
        /// <param name="fileName">Имя шаблона</param>
        /// <param name="fileData">Файл шаблона</param>
        public void GetTepmlate(int idTemplate, out string fileName, out byte[] fileData)
        {
            fileName = "";
            fileData = null;
            string sql = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
            using (SqlConnection conn = new SqlConnection(SqlSettings.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@idTemplate", SqlDbType.Int);
                cmd.Parameters["@idTemplate"].Value = idTemplate;
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fileName = (string)dr.GetValue(0);
                        fileData = (byte[])dr.GetValue(1);
                    }
                }
                catch (Exception ex)
                {
#if DEBUG
                    MessageBox.Show(ex.ToString());
#else
                    MessageBox.Show(ex.Message, ex.Source);
#endif
                }
            }
        }

        private void ExportToWord(string path, string fileName, object sender, bool saveAndListen = false)
        {
            string AbnName = GetAbnName(IdAbn);

            var tsmi = (ToolStripMenuItem)sender;
            int idTemplate = (int)tsmi.Tag;
            byte[] fileData;
            string _fileName;
            GetTepmlate(idTemplate, out _fileName, out fileData);

            #region Формирование имени документа
            if (string.IsNullOrEmpty(fileName))
            {
                // дата акта
                DateTime ActDate = dtpActDate.Value;

                string AbnName1 = CallSQLScalarFunction("dbo.TPStr", IdAbnObj.ToString()).ToString()
                    + " " + AbnName + " " + tbActNumber.Text + " " + ActDate.ToString("ddMMyy");

                // имя документа = подстанция + потребитель + номер акта + дата акта
                fileName = AbnName1.Replace("\"", string.Empty) + ".doc";
            }
            #endregion

            var fileExtention = new System.IO.FileInfo(fileName).Extension;

            switch (fileExtention)
            {
                case ".xlt":
                case ".xltx":
                    fileName = fileName.Replace(fileExtention, fileExtention.Replace("t", "s"));
                    break;
                case ".dot":
                case ".dotx":
                    fileName = fileName.Replace(fileExtention, fileExtention.Replace("t", "c"));
                    break;
                case ".xls":
                case ".xlsx":
                    break;
                case ".doc":
                case ".docx":
                    break;
                default:

                    break;
            }

            /// Создание временной/пользовательской папки 
            string folderName = string.IsNullOrEmpty(path) ? GetDirectoryPath(tbActNumber.Text) : path;

            //if (File.Exists(folderName + "\\" + fileName))
            //{
            //    File.Delete(folderName + "\\" + fileName);
            //}

            string tmpfileName = FileBinary.GetNewFileNameIsExists(folderName, fileName);

            string shortFileName = AddFileInDocument(fileName, idTemplate, fileData, saveAndListen);

            if (!string.IsNullOrEmpty(shortFileName))
            {
                isSave = true;
                FileBinary file = new FileBinary(fileData, tmpfileName, DateTime.Now);
                // Записали файл во временную папку
                file.SaveToDisk(folderName);
                // Запустили файл
                fileExtention = new System.IO.FileInfo(fileName).Extension;

                if (saveAndListen)
                {
                    if (files.ContainsKey(shortFileName))
                    {
                        /// Слушаем изменеие файла
                        FileWatcher watcher = new FileWatcher(folderName, file.Name);
                        watcher.AnyChanged += new System.IO.FileSystemEventHandler(watcher_AnyChanged);
                        watcher.Start();

                        files[shortFileName].TempName = tmpfileName;
                        files[shortFileName].Watcher = watcher;
                        files[shortFileName].OpenState = FileOpenState.Editing;
                        //FileWatcherArgsAddl fwargsaddl = new FileWatcherArgsAddl(idTemplate, file.Name, fileName, watcher, FileOpenState.Editing);
                    }
                    else
                        MessageBox.Show("Что то пошло не так");
                }
                CreateActRbp(AbnName, folderName + "\\" + tmpfileName);
            }
        }

        private String GetAbnName(int idAbn)
        {
            string AbnName = "";
            // наименование абонента
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vAbn, true, String.Format(" where id = {0}", idAbn), true);
            if (dsAbnObjAkt1.vAbn.Rows.Count > 0)
                AbnName = dsAbnObjAkt1.vAbn.First().Name.Trim();
            return AbnName;
        }

        /// <summary> Запись измененного файла в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void watcher_AnyChanged(object sender, System.IO.FileSystemEventArgs e)
        {
            /// Находим 
            var fwargs = from item in files
                         where item.Value.TempName == e.Name
                         select item;

            if (fwargs.Count() > 0)
            {
                /// Считываем измененный файл
                FileBinary file = new FileBinary(e.FullPath);

                //SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File, true,
                //    String.Format("where idList = {0} AND FileName = '{1}' AND idTemplate = {2}",
                //    idList, fwargs.First().Value.OriginalName, fwargs.First().Value.IdTemplate));

                /// Ищем строку в таблице с файлом
                var dgvRows = from rowFiles in dsAbnObjAkt1.tAbnObjDoc_File
                              where rowFiles.RowState != DataRowState.Deleted && rowFiles.FileName == fwargs.First().Value.OriginalName
                              select rowFiles;

                /// Обновляем данные файла или добавляем новую строку при отсутствии
                if (dgvRows.Count() == 0)
                {
                    var row = dsAbnObjAkt1.tAbnObjDoc_File.NewtAbnObjDoc_FileRow();
                    row.id = dsAbnObjAkt1.tAbnObjDoc_File.Min(min => min.id) < 0 ? dsAbnObjAkt1.tAbnObjDoc_File.Min(min => min.id) - 1 : -1;
                    row.idList = IdList;
                    row.FileName = fwargs.First().Value.OriginalName;
                    row.File = file.ByteArray;
                    row.dateChange = file.LastChanged;
                    row.idTemplate = (int)fwargs.First().Value.IdTemplate;
                    dsAbnObjAkt1.tAbnObjDoc_File.AddtAbnObjDoc_FileRow(row);
                }
                else
                {
                    dgvRows.First().File = file.ByteArray;
                    dgvRows.First().dateChange = file.LastChanged;
                    dgvRows.First().EndEdit();
                    isSave = true;
                }
                ResetBSFiles();
                isSave = true;
            }
        }

        /// <summary> Перезагружает биндинг не из своего потока
        /// </summary>
        private void ResetBSFiles()
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(() => bsFiles.ResetBindings(false)));
            else
                bsFiles.ResetBindings(false);
        }

        private string AddFileInDocument(string fileName, int? idTemplate = null, byte[] fileData = null, bool saveAndListen = false)
        {
            string shortFileName = System.IO.Path.GetFileName(fileName);
            bool isAdd = true;

            while ((SelectSqlData("tAbnObjDoc_File", true, String.Format("where idList = {0} AND FileName = '{1}'", IdList, shortFileName)).Rows.Count > 0
                || files.ContainsKey(shortFileName)) && saveAndListen)  // если есть такой файл....
            {
                if (MessageBox.Show("Файл с именем " + shortFileName + " уже существует. Изменить имя файла на другое?", "Внимание.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    FormNewFileName frmNewFileName = new FormNewFileName(shortFileName);
                    if (frmNewFileName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        shortFileName = frmNewFileName.FileName;
                }
                else
                {
                    isAdd = false;
                    break;
                }
            }
            if (!isAdd) return null;

            if (saveAndListen)
            {
                FileWatcherArgsAddl f = new FileWatcherArgsAddl(idTemplate, shortFileName, null, FileOpenState.None);
                files.Add(shortFileName, f);

                var row = dsAbnObjAkt1.tAbnObjDoc_File.NewtAbnObjDoc_FileRow();
                row.id = dsAbnObjAkt1.tAbnObjDoc_File.Count > 0 ? dsAbnObjAkt1.tAbnObjDoc_File.Where(r => r.RowState != DataRowState.Deleted).Min(min => min.id) - 1 : -1;
                row.idList = IdList;
                row.FileName = shortFileName;
                if (fileData == null)
                {
                    FileBinary file = new FileBinary(fileName);
                    row.File = file.ByteArray;
                    row.dateChange = file.LastChanged;
                }
                else
                {
                    row.File = fileData;
                    row.dateChange = DateTime.Now;
                }
                if (idTemplate != null)
                    row.idTemplate = (int)idTemplate;
                dsAbnObjAkt1.tAbnObjDoc_File.AddtAbnObjDoc_FileRow(row);

                row.EndEdit();
                isSave = true;
            }
            return shortFileName;
        }

        private void OpenFile(bool isEdit = false)
        {
            if (bsFiles.Current != null)
            {
                dsAbnObjAct.tAbnObjDoc_FileRow r = (dsAbnObjAct.tAbnObjDoc_FileRow)((DataRowView)bsFiles.Current).Row;

                string fileName = r.FileName;
                string folderName = GetDirectoryPath(tbActNumber.Text);
                string tmpfileName = FileBinary.GetNewFileNameIsExists(folderName, fileName);

                int? idTemplate = null;
                if (r["idTemplate"] != DBNull.Value)
                    idTemplate = r.idTemplate;
                DateTime dateChange = r.dateChange;

                if (r["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(this.SqlSettings.GetConnectionString()))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("SELECT [File] FROM tTC_DocFile WHERE id = " + r["id"].ToString(), conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                r["File"] = dr["File"];

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                }
                byte[] fileData;
                try
                {
                    fileData = r.File;
                }
                catch
                {
                    MessageBox.Show("Нет содержимого файла");
                    return;
                }

                FileBinary file = new FileBinary(fileData, tmpfileName, DateTime.Now);
                // Записали файл во временную папку
                file.SaveToDisk(folderName);
                // Запустили файл
                Process.Start(folderName + "\\" + file.Name);

                if (isEdit)
                {
                    if (files.ContainsKey(fileName))
                    {
                        if (files[fileName].Watcher == null)
                        {
                            FileWatcher watcher = new FileWatcher(folderName, tmpfileName);
                            watcher.AnyChanged += new System.IO.FileSystemEventHandler(watcher_AnyChanged);
                            watcher.Start();
                            files[fileName].Watcher = watcher;
                        }
                        else
                        {
                            files[fileName].Watcher.AnyChanged -= watcher_AnyChanged;
                            files[fileName].Watcher.Stop();
                            FileWatcher watcher = new FileWatcher(folderName, tmpfileName);
                            watcher.AnyChanged += new System.IO.FileSystemEventHandler(watcher_AnyChanged);
                            watcher.Start();
                            files[fileName].Watcher = watcher;
                        }

                        files[fileName].TempName = tmpfileName;
                        files[fileName].OpenState = FileOpenState.Editing;
                    }
                    else  // нету
                    {
                        FileWatcher watcher = new FileWatcher(folderName, tmpfileName);
                        watcher.AnyChanged += new System.IO.FileSystemEventHandler(watcher_AnyChanged);
                        watcher.Start();
                        FileWatcherArgsAddl fwargsaddl = new FileWatcherArgsAddl(idTemplate, fileName, tmpfileName, watcher, FileOpenState.Editing);
                        files.Add(fileName, fwargsaddl);

                    }
                    isSave = true;
                }
            }
        }

        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                // Open file for reading
                System.IO.FileStream _FileStream =
                   new System.IO.FileStream(fileName, System.IO.FileMode.Create,
                                            System.IO.FileAccess.Write);
                // Writes a block of bytes to this stream using data from
                // a byte array.
                _FileStream.Write(byteArray, 0, byteArray.Length);

                // close file stream
                _FileStream.Close();

                return true;
            }
            catch (Exception _Exception)
            {
                MessageBox.Show(_Exception.Message, _Exception.Source);
                _Exception.ToString();
            }

            // error occured, return false
            return false;
        }

        private bool SaveFiles(int idList)
        {
            foreach (DataRow r in dsAbnObjAkt1.tAbnObjDoc_File)
            {
                if (r.RowState != DataRowState.Deleted && r.RowState != DataRowState.Detached && Convert.ToInt32(r["idList"]) != idList)
                {
                    r["idList"] = idList;
                    r.EndEdit();
                }
            }

            if (this.InsertSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File))
                if (this.UpdateSqlDataOnlyChange(dsAbnObjAkt1.tAbnObjDoc_File))
                    if (this.DeleteSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File))
                    {
                        dsAbnObjAkt1.tAbnObjDoc_File.AcceptChanges();
                        return true;
                    }


            return false;
        }
        #endregion

        private void tpMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tpMain.SelectedTab == tpFiles && dsAbnObjAkt1.tAbnObjDoc_File.Select(r => r.RowState == DataRowState.Added
                || r.RowState == DataRowState.Modified || r.RowState == DataRowState.Deleted).Count() == 0)
            {
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tAbnObjDoc_File, true, "where idList = " + IdList.ToString());
            }

            if (tpMain.SelectedTab == tpActTehConnection)
            {
                LoadTableTU(IdActTehConnection);
            }
        }

        private void dgvFile_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void FormAbnAkt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stateCreate != StateCreate.Show && DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                if (isSave && MessageBox.Show("Документ изменен. Сохранить текущие изменения?", "Сохранение.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (SaveDataToDB())
                        {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show(ex.Message + Environment.NewLine + "Закрыть окно?", "Ошибка",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            isSave = isShown;
        }

        private void FormAbnAkt_Shown(object sender, EventArgs e)
        {
            isShown = true;
        }

        #region Вкладка "Акт о технологическом присоединении"

        /// <summary> Загружает все акты о технологическом присоединении
        /// </summary>
        /// <param name="idActTehConnection">Идентификатор выбранного акта о технологическом присоединении</param>
        private void LoadTableTU(int idActTehConnection)
        {
            bsActTU.RaiseListChangedEvents = true;
            bsActTU.CurrentChanged -= bsActTU_CurrentChanged;

            string cmd = "select  d.id, d.numdoc, d.datedoc, " +
                             " isnull(d.numdoc + ' ', '') + 'от ' + isnull(convert( varchar(10),d.Datedoc, 104), '') as numDatedoc " +
                      " from ttc_doc d " +
                      " where typeDoc = " + ((int)Legal.Classes.eTypeDoc.ActTehConnection).ToString();
            cmd += "union select -1, null, null, '' order by numDoc, dateDoc ";

            DataTable dt = new DataTable();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            if (con.OpenConnection(this.SqlSettings))
            {
                try
                {
                    SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd, con.Connection);
                    dataAdapt.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }

            bsActTU.DataSource = dt;
            bsActTU.Sort = "numDoc, dateDoc";
            cbActTehConnection.DataSource = bsActTU;
            cbActTehConnection.DisplayMember = "numDateDoc";
            cbActTehConnection.ValueMember = "id";

            if (idActTehConnection != -1)
            {
                bsActTU.Position = bsActTU.Find("id", idActTehConnection);
            }

            bsActTU.CurrentChanged += new EventHandler(bsActTU_CurrentChanged);
            bsActTU.RaiseListChangedEvents = false;

            bsActTU_CurrentChanged(bsActTU, new EventArgs());

        }

        /// <summary> Догружает данные по выбранному акту о технологическом присоединении
        /// </summary>
        private void bsActTU_CurrentChanged(object sender, EventArgs e)
        {
            if (bsActTU.Current != null)
            {
                IdActTehConnection = (int)((DataRowView)bsActTU.Current)["id"];
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tTC_ActTC, true, String.Format("WHERE id = {0} ", IdActTehConnection));
                SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vTC_TUPointAttach, true, String.Format("WHERE idTU = {0} ", IdActTehConnection));
            }
            else
            {
                IdActTehConnection = -1;
                dsAbnObjAkt1.tTC_ActTC.Rows.Clear();
                dsAbnObjAkt1.vTC_TUPointAttach.Rows.Clear();
            }
        }

        #endregion





    }
}
