using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Object
{
    public partial class FormAddEditConnect : FormLbr.FormBase
    {
        private int idx;
        private int idAbnObj;
        private ActionСonnect act;

        /// <summary>
        /// Действия над подключением
        /// </summary>
        public enum ActionСonnect
        {
            /// <summary>
            /// Добавить
            /// </summary>
            Add,
            /// <summary>
            /// Редактировать
            /// </summary>
            Edit,
   
        }

         public FormAddEditConnect()
        {
            InitializeComponent();
        }

        public FormAddEditConnect(int idx,int idAbnObj,ActionСonnect ActConn)
        {
            this.idx = idx;
            this.idAbnObj = idAbnObj;
            InitializeComponent();

            switch (ActConn)
            { 
                case ActionСonnect.Add :
                    this.Text = "Добавление подключения";
                    act = ActionСonnect.Add;
                    break;

                case ActionСonnect.Edit:
                    this.Text = "Редактирование подключения";
                    act = ActionСonnect.Edit;
                    break;
        
            }
        }

        private void FormAddEditConnect_Load(object sender, EventArgs e)
        {
            // загрузка подстанций
            string whereType = "";
            foreach (Constants.SchmTypeSubstation type in Enum.GetValues(typeof(Constants.SchmTypeSubstation)))
                if (string.IsNullOrEmpty(whereType)) whereType = ((int)type).ToString();
                else whereType += "," + ((int)type).ToString();
            this.SelectSqlData(dsDop1.vSchm_ObjList, true, " where typeCodeId in (" + whereType + ") and deleted = 0 order by typeCodeSocr, name");

            // загрузка питающих центров
            
            this.SelectSqlData(dsDop1, dsDop1.tSchm_ObjList, true, "where TypeCodeID = 536 and Deleted = 0 order by Name");

            if (act == ActionСonnect.Edit)
            {
                SelectSqlData(dsDop1, dsDop1.tConnect, true, " where  idx = " + idx.ToString() );
                if (dsDop1.tConnect.Rows.Count > 0)
                {
                    cmbTP.Text = dsDop1.tConnect[0]["Name_Group"].ToString();
                    cmbShina.Text = dsDop1.tConnect[0]["Name_Shina"].ToString();
                    txtPrim.Text = dsDop1.tConnect[0]["Comment"].ToString();
                    cmbCenter.Text = dsDop1.tConnect[0]["NameCenter"].ToString();
                    if (dsDop1.tConnect[0]["NumberCell"] != System.DBNull.Value)
                        numCell.Value = (int)dsDop1.tConnect[0]["NumberCell"];
                }

            }
            else
            {
                cmbTP.Text = "";
                cmbShina.Text = "";
                txtPrim.Text = "";
                cmbCenter.Text = "";
                NewAbnObjConnect();
            }
        }

        private void cmbTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTP.SelectedIndex >= 0 && cmbTP.SelectedValue != null)
                InitcmbBus(Convert.ToInt32(cmbTP.SelectedValue));
            else
                cmbShina.DataSource = null;
        }

        private void InitcmbBus(int idSubstation)
        {
            string where = ((int)Constants.SchmTypeBus.Shina_10).ToString() + "," + ((int)Constants.SchmTypeBus.Shina_6).ToString();
            where = where.Remove(where.Length - 1);
            DataTable dt = new DataTable("vSchm_ObjList");
            dt.Columns.Add("id", typeof(System.Int32));
            dt.Columns.Add("Name", typeof(System.String));

            cmbShina.DataSource = dt;
            cmbShina.DisplayMember = "Name";
            cmbShina.ValueMember = "id";

            this.SelectSqlData(dt, true, "where idParent = " + idSubstation.ToString() +
                " and typecodeid in (" + where + ") and deleted = 0 order by typecodeSocr, name");
            cmbShina.SelectedIndex = -1;
        }


        private void NewAbnObjConnect()
        {
            DataRow dr = dsDop1.tConnect.NewRow();
            dr["idObj_old"] = 0;
            dr["UserName"] = System.Environment.UserName.ToString();
            dr["CompName"] = System.Environment.MachineName.ToString();
            dr["DataMod"] = System.DateTime.Now.Date;
            dr["Deleted"] = 0;
            dsDop1.tConnect.Rows.Add(dr);
        }

        // добавление подключения для нового объекта
        private int InsertIntotAbnObjConnect(int AbnObj)
        {
            dsDop1.tConnect.Rows[0]["idObj"] = AbnObj;
            dsDop1.tConnect.Rows[0]["Name_Group"] = cmbTP.Text;
            dsDop1.tConnect.Rows[0]["Name_Shina"] = cmbShina.Text;
            dsDop1.tConnect.Rows[0]["Comment"] = txtPrim.Text;
            dsDop1.tConnect.Rows[0]["NameCenter"] = cmbCenter.Text;
            dsDop1.tConnect.Rows[0]["idCenter"] = cmbCenter.SelectedValue;
            dsDop1.tConnect.Rows[0]["NumberCell"] = numCell.Value;

            dsDop1.tConnect.Rows[0].EndEdit();
            return this.InsertSqlDataOneRow(dsDop1, dsDop1.tConnect);
        }

        // редактировать подключение объекта
        private bool UpdatetAbnObjConnect()
        {
            if (dsDop1.tConnect.Rows.Count > 0)
            {
                dsDop1.tConnect.Rows[0]["Name_Group"] = cmbTP.Text;
                dsDop1.tConnect.Rows[0]["Name_Shina"] = cmbShina.Text;
                dsDop1.tConnect.Rows[0]["Comment"] = txtPrim.Text;
                dsDop1.tConnect.Rows[0]["NameCenter"] = cmbCenter.Text;
                if (cmbCenter.SelectedIndex != -1)
                    dsDop1.tConnect.Rows[0]["idCenter"] = cmbCenter.SelectedValue;
                else
                    dsDop1.tConnect.Rows[0]["idCenter"] = System.DBNull.Value;
                dsDop1.tConnect.Rows[0]["NumberCell"] = numCell.Value;

                dsDop1.tConnect.Rows[0].EndEdit();
                return this.UpdateSqlData(dsDop1, dsDop1.tConnect);
            }
            else
                return false;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttoтSave_Click(object sender, EventArgs e)
        {
            if (act == ActionСonnect.Edit)
            {

                if (!UpdatetAbnObjConnect())
                {
                    MessageBox.Show("Не удается отредактировать подключение");
                    return;
                }
            }
            else
            {
                if (InsertIntotAbnObjConnect(idAbnObj) < 0)
                {
                    MessageBox.Show("Не удается создать подключение");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
