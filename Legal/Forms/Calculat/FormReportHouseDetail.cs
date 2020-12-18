using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControlsLbr;


namespace Legal.Forms.Calculat
{
    public partial class FormReportHouseDetail : FormLbr.FormBase
    {
        private DateTime dtBEGIN;
        private DateTime dtEND;
        private int idMAP; 

        public FormReportHouseDetail()
        {
            InitializeComponent();
        }

        public FormReportHouseDetail(DateTime dtBegin, DateTime dtEnd, Int32 idMap)
        {
            InitializeComponent();
            dtBEGIN = dtBegin;
            dtEND = dtEnd;
            idMAP = idMap;
        }


        private void FormReportHouseDetail_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dsCalc1.tG_HouseDetail.Rows.Clear();
            this.dgv.Columns.Clear();

            #region Вызвать функцию и получить данные

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select * from fn_LegReport_HouseDetail2(@DateBegin, @DateEnd, @idMap) order by AbnType, NameObj";

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                SqlParameter p1 = new SqlParameter("@DateBegin", dtBEGIN.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", dtEND.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@idMap", idMAP.ToString());
                sqlCmd.Parameters.Add(p3);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCalc1, "tG_HouseDetail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
            #endregion

            #region Cоздание временной таблицы
            DataTable dt = new DataTable("dt_HouseDetail");

            dt.Columns.Add(new DataColumn("AbnType", typeof(string)));
            dt.Columns.Add(new DataColumn("Status", typeof(string)));
            dt.Columns.Add(new DataColumn("dtStatus", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("idAbn", typeof(int)));
            dt.Columns.Add(new DataColumn("idObj", typeof(int)));
            dt.Columns.Add(new DataColumn("CodeAbonent", typeof(int)));
            dt.Columns.Add(new DataColumn("NameAbn", typeof(string)));
            dt.Columns.Add(new DataColumn("NameObj", typeof(string)));
            dt.Columns.Add(new DataColumn("TotalQuantity", typeof(int)));
            dt.Columns.Add(new DataColumn("AverageQuantity", typeof(int)));
            dt.Columns.Add(new DataColumn("idObjParent", typeof(int)));
            dt.Columns.Add(new DataColumn("idStatus", typeof(int)));


            var CountMonth = 0;
            if (dtEND.Year == dtBEGIN.Year)
                CountMonth = dtEND.Month - dtBEGIN.Month + 1;
            else
                CountMonth = 12 * (dtEND.Year - dtBEGIN.Year) - dtBEGIN.Month + dtEND.Month + 1;

            string MonthName = "";
            DateTime dtBeg = dtBEGIN;

            for (var i = 0; i < CountMonth; i++)
            {
                if (dtBeg.Month < 10)
                    MonthName = dtBeg.Year.ToString() + "0" + dtBeg.Month.ToString();
                else
                    MonthName = dtBeg.Year.ToString() + dtBeg.Month.ToString();
                dt.Columns.Add(new DataColumn(MonthName, typeof(int)));
                dtBeg = dtBeg.AddMonths(1);
            }


            dsCalc1.Tables.Add(dt);

            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            #endregion

            // назначим источник данных грида
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = bds;

            #region Заполнение таблицы

            int RowsCount = dsCalc1.tG_HouseDetail.Rows.Count;
            int idObjSave = 0;

            DataRow drw = dt.NewRow();

            int TotalQuantityAll = 0;
            int AverageQuantityAll = 0;

            Dictionary<string, int> array = new Dictionary<string, int>();

            for (var i = 0; i < RowsCount; i++)
            {
                if (idObjSave != Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["idObj"]))
                {
                    if (i > 0)
                        dt.Rows.Add(drw);
                    drw = dt.NewRow();
                    drw["AbnType"] = dsCalc1.tG_HouseDetail.Rows[i]["AbnType"];
                    drw["Status"] = dsCalc1.tG_HouseDetail.Rows[i]["Status"];
                    drw["dtStatus"] = dsCalc1.tG_HouseDetail.Rows[i]["dtStatus"];
                    drw["idObj"] = dsCalc1.tG_HouseDetail.Rows[i]["idObj"];
                    drw["CodeAbonent"] = dsCalc1.tG_HouseDetail.Rows[i]["CodeAbonent"];
                    drw["NameAbn"] = dsCalc1.tG_HouseDetail.Rows[i]["NameAbn"];
                    drw["NameObj"] = dsCalc1.tG_HouseDetail.Rows[i]["Nameobj"];
                    drw["TotalQuantity"] = dsCalc1.tG_HouseDetail.Rows[i]["TotalQuantity"];
                    drw["AverageQuantity"] = dsCalc1.tG_HouseDetail.Rows[i]["AverageQuantity"];
                    drw["idObjParent"] = dsCalc1.tG_HouseDetail.Rows[i]["IdObjParent"];
                    drw["idStatus"] = dsCalc1.tG_HouseDetail.Rows[i]["idStatus"];

                    if ((dsCalc1.tG_HouseDetail.Rows[i]["IdObjParent"].ToString() == "") 
                        && (dsCalc1.tG_HouseDetail.Rows[i]["idStatus"].ToString() != "")
                        && (Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["idStatus"]) != 1293 ))
                    {
                        TotalQuantityAll = TotalQuantityAll + Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["TotalQuantity"]);
                        AverageQuantityAll = AverageQuantityAll + Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["AverageQuantity"]);
                    }

                    idObjSave = Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["idObj"]);
                }
                MonthName = Convert.ToString(dsCalc1.tG_HouseDetail.Rows[i]["DateAct"]);
                if (MonthName != "")
                {
                    drw[MonthName] = dsCalc1.tG_HouseDetail.Rows[i]["Quantity"];
                    if (dsCalc1.tG_HouseDetail.Rows[i]["IdObjParent"].ToString() == "")
                    {
                        if (array.ContainsKey(MonthName))
                            array[MonthName] += Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["Quantity"]);
                        else
                            array.Add(MonthName, Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["Quantity"]));
                    }
                }


            }
            dt.Rows.Add(drw);

            drw = dt.NewRow();
            drw["NameAbn"] = "Итого";
            drw["TotalQuantity"] = TotalQuantityAll;
            drw["AverageQuantity"] = AverageQuantityAll;
            foreach (var kvp in array)
            {
                drw[kvp.Key] = kvp.Value;
            }
            dt.Rows.Add(drw);

            #endregion

            #region Формирование столбцов грида

            DataGridViewCellStyle IntStyle = new DataGridViewCellStyle();
            IntStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            IntStyle.Format = "N0";

            DataGridViewCellStyle StringStyle = new DataGridViewCellStyle();
            StringStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DataGridViewCellStyle DecStyle = new DataGridViewCellStyle();
            DecStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DecStyle.Format = "N2";

            DataGridViewCellStyle DecStyle6 = new DataGridViewCellStyle();
            DecStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            DecStyle6.Format = "N6";

            DataGridViewColumn AbnType = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            AbnType.Name = "AbnType";
            DataGridViewColumn Status = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Status.Name = "Status";
            DataGridViewColumn dtStatus = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            dtStatus.Name = "dtStatus";

            
            DataGridViewColumn idAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idAbn.Name = "idAbn";
            DataGridViewColumn idObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idObj.Name = "idObj";
            DataGridViewColumn CodeAbonent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            CodeAbonent.Name = "CodeAbonent";
            DataGridViewColumn NameAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            NameAbn.Name = "NameAbn";
            DataGridViewColumn NameObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            NameObj.Name = "NameObj";

            DataGridViewColumn TotalQuantity = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            TotalQuantity.Name = "TotalQuantity";
            DataGridViewColumn AverageQuantity = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            AverageQuantity.Name = "AverageQuantity";

            DataGridViewColumn idObjParent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idObjParent.Name = "idObjParent";

            DataGridViewColumn idStatus = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idStatus.Name = "idStatus";

            dgv.Columns.Add(AbnType);
            dgv.Columns.Add(Status);
            dgv.Columns.Add(dtStatus);

            dgv.Columns.Add(idAbn);
            dgv.Columns.Add(idObj);
            dgv.Columns.Add(CodeAbonent);
            dgv.Columns.Add(NameAbn);
            dgv.Columns.Add(NameObj);
            dgv.Columns.Add(idObjParent);
            dgv.Columns.Add(idStatus);
            dgv.Columns.Add(TotalQuantity);
            dgv.Columns.Add(AverageQuantity);

            for (var i = 12; i < 12 + CountMonth; i++)
            {
                string ColName = dt.Columns[i].ColumnName;
                DataGridViewColumn Col = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
                Col.Name = ColName;
                dgv.Columns.Add(Col);
                dgv.Columns[ColName].Width = 70;
                dgv.Columns[ColName].HeaderText = ColName;
                dgv.Columns[ColName].ValueType = typeof(int);
                dgv.Columns[ColName].DefaultCellStyle = IntStyle;
                dgv.Columns[ColName].DataPropertyName = ColName;

            }

            dgv.Columns["AbnType"].Width = 100;
            dgv.Columns["AbnType"].HeaderText = "Тип";
            dgv.Columns["AbnType"].ValueType = typeof(string);
            dgv.Columns["AbnType"].DefaultCellStyle = StringStyle;
            dgv.Columns["AbnType"].DataPropertyName = "AbnType";

            dgv.Columns["Status"].Width = 60;
            dgv.Columns["Status"].HeaderText = "Статус";
            dgv.Columns["Status"].ValueType = typeof(string);
            dgv.Columns["Status"].DefaultCellStyle = StringStyle;
            dgv.Columns["Status"].DataPropertyName = "Status";

            dgv.Columns["dtStatus"].Width = 80;
            dgv.Columns["dtStatus"].HeaderText = "Дата";
            dgv.Columns["dtStatus"].ValueType = typeof(string);
            dgv.Columns["dtStatus"].DefaultCellStyle = StringStyle;
            dgv.Columns["dtStatus"].DataPropertyName = "dtStatus";

            
            
            dgv.Columns["idAbn"].Width = 70;
            dgv.Columns["idAbn"].HeaderText = "";
            dgv.Columns["idAbn"].ValueType = typeof(int);
            dgv.Columns["idAbn"].DefaultCellStyle = IntStyle;
            dgv.Columns["idAbn"].DataPropertyName = "idAbn";
            dgv.Columns["idAbn"].Visible = false;

            dgv.Columns["idObj"].Width = 70;
            dgv.Columns["idObj"].HeaderText = "";
            dgv.Columns["idObj"].ValueType = typeof(int);
            dgv.Columns["idObj"].DefaultCellStyle = IntStyle;
            dgv.Columns["idObj"].DataPropertyName = "idObj";
            dgv.Columns["idObj"].Visible = false;

            dgv.Columns["CodeAbonent"].Width = 70;
            dgv.Columns["CodeAbonent"].HeaderText = "Код";
            dgv.Columns["CodeAbonent"].ValueType = typeof(int);
            dgv.Columns["CodeAbonent"].DefaultCellStyle = IntStyle;
            dgv.Columns["CodeAbonent"].DataPropertyName = "CodeAbonent";
            dgv.Columns["CodeAbonent"].Visible = true;

            dgv.Columns["NameAbn"].Width = 150;
            dgv.Columns["NameAbn"].HeaderText = "Потребитель";
            dgv.Columns["NameAbn"].ValueType = typeof(string);
            dgv.Columns["NameAbn"].DefaultCellStyle = StringStyle;
            dgv.Columns["NameAbn"].DataPropertyName = "NameAbn";

            dgv.Columns["NameObj"].Width = 250;
            dgv.Columns["NameObj"].HeaderText = "Объект";
            dgv.Columns["NameObj"].ValueType = typeof(string);
            dgv.Columns["NameObj"].DefaultCellStyle = StringStyle;
            dgv.Columns["NameObj"].DataPropertyName = "NameObj";
            dgv.Columns["NameObj"].Frozen = true;

            dgv.Columns["TotalQuantity"].Width = 70;
            dgv.Columns["TotalQuantity"].HeaderText = "Всего";
            dgv.Columns["TotalQuantity"].ValueType = typeof(int);
            dgv.Columns["TotalQuantity"].DefaultCellStyle = IntStyle;
            dgv.Columns["TotalQuantity"].DataPropertyName = "TotalQuantity";
            dgv.Columns["TotalQuantity"].Visible = true;

            dgv.Columns["AverageQuantity"].Width = 70;
            dgv.Columns["AverageQuantity"].HeaderText = "Среднее";
            dgv.Columns["AverageQuantity"].ValueType = typeof(int);
            dgv.Columns["AverageQuantity"].DefaultCellStyle = IntStyle;
            dgv.Columns["AverageQuantity"].DataPropertyName = "AverageQuantity";
            dgv.Columns["AverageQuantity"].Visible = true;

            dgv.Columns["idObjParent"].Width = 0;
            dgv.Columns["idObjParent"].HeaderText = "";
            dgv.Columns["idObjParent"].ValueType = typeof(int);
            dgv.Columns["idObjParent"].DefaultCellStyle = IntStyle;
            dgv.Columns["idObjParent"].DataPropertyName = "idObjParent";
            dgv.Columns["idObjParent"].Visible = false;

            dgv.Columns["idStatus"].Width = 0;
            dgv.Columns["idStatus"].HeaderText = "";
            dgv.Columns["idStatus"].ValueType = typeof(int);
            dgv.Columns["idStatus"].DefaultCellStyle = IntStyle;
            dgv.Columns["idStatus"].DataPropertyName = "idStatus";
            dgv.Columns["idStatus"].Visible = false;

            #endregion


            this.Cursor = Cursors.Default;

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int CodeAbn = Convert.ToInt32(dgv.CurrentRow.Cells["CodeAbonent"].Value);
            int AbnType = 206;
            if (CodeAbn > 9999) {
                Prv.Forms.Abonent.FormAbonent frm = new Prv.Forms.Abonent.FormAbonent(CodeAbn, AbnType);
                frm.SqlSettings = this.SqlSettings;
                if (frm.ShowDialog() == DialogResult.OK) { }
            }
            else {
                int idObj = Convert.ToInt32(dgv.CurrentRow.Cells["idObj"].Value);
                Legal.Forms.FormAbn frm = new Legal.Forms.FormAbn(CodeAbn, idObj);
                frm.SqlSettings = this.SqlSettings;
                if (frm.ShowDialog() == DialogResult.OK) { }
            }
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["idObjParent"].Value.ToString() != "")
            {
                ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
            }

            if ((dgv.Rows[e.RowIndex].Cells["idStatus"].Value.ToString() != "") && (Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["idStatus"].Value) == 1293))
            {
                ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }
        }








    }
}
