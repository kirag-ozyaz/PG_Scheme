using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using FormLbr.Classes;
//using RequestsClient.DataSets;
//using RequestForRepair.DataSets;
//using RequestsClient.Properties;
using RequestsClient.RequestService;
using SchemeModel;
using SchemeModel.Calculations;


namespace RequestForRepair
{
    /// <summary>
    /// Журнал аварийных заявок и на ремонт оборудования
    /// версия крайняя
    /// RequestsClient.dll
    /// </summary>/// 
    public partial class FormJournalRequestForRepairAddEdit : FormBase
    {
        private int IdRequest = -1;
        private int IdDivision = -1;
        //private const int int_2 = 920; //ODS_DIVISION
        //private const int int_3 = 921; //PL_DIVISION
        private eActionRequestRepair eActionRequestRepair = eActionRequestRepair.Read;
        private DateTime dateTimeBeg = new DateTime(1900, 1, 1);
        private DateTime dateTimeEnd = new DateTime(9000, 1, 1);
        private int idStatus = -1;
        private bool isCrash;
        private bool isAgreed;
        private bool isSendRIC;
        private Dictionary<int, string> dictionaryIdSchmObj = new Dictionary<int, string>();
        private int idSR = -1;
        private ElectricModel electricModel;
        private DataRow DataRowCurrent;

        private bool IsCrash
        {
            get
            {
                return this.isCrash;
            }
            set
            {
                this.isCrash = value;
                this.EnableIsCrash();
            }
        }
        public FormJournalRequestForRepairAddEdit()
        {
            this.InitializeComponent();
            this.CmdDataBindingsAdd();
        }
        public FormJournalRequestForRepairAddEdit(int idRequest, int idDivision, eActionRequestRepair action, bool isCrash = false)
        {
            this.InitializeComponent();
            this.CmdDataBindingsAdd();
            this.IdRequest = idRequest;
            this.IdDivision = idDivision;
            this.eActionRequestRepair = action;
            this.IsCrash = isCrash;
        }
        public FormJournalRequestForRepairAddEdit(DataRow row)
        {
            this.InitializeComponent();
            this.CmdDataBindingsAdd();
            this.IdRequest = -1;
            this.IdDivision = Convert.ToInt32(row["idDivision"]);
            this.eActionRequestRepair = eActionRequestRepair.Add;
            this.DataRowCurrent = row;
        }

        private void CmdDataBindingsAdd()
        {
            this.cmbIsPlanned.DataBindings.Clear();
            this.cmbIsPlanned.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.IsPlanned", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbTypeDisable.DataBindings.Clear();
            this.cmbTypeDisable.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.typeDisable", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbSR.DataBindings.Clear();
            this.cmbSR.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idSR", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbRegion.DataBindings.Clear();
            this.cmbRegion.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idRegion", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePickerDateAgreed.DataBindings.Clear();
            this.dateTimePickerDateAgreed.DataBindings.Add(new Binding("Value", this.dataSetN, "tJ_RequestForRepair.DateAgreed", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePickerFactEnd.DataBindings.Clear();
            this.dateTimePickerFactEnd.DataBindings.Add(new Binding("Value", this.dataSetN, "tJ_RequestForRepair.DateFactEnd", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbStatus.DataBindings.Clear();
            this.cmbStatus.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.status", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtAdress.DataBindings.Clear();
            this.txtAdress.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.Address", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void method_1()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
            {
                try
                {
                    sqlConnection.Open();
                    DbDataAdapter dbDataAdapter = new SqlDataAdapter("select [Settings] from tSettings where module = 'FTP05'", sqlConnection);
                    DataTable dataTable = new DataTable();
                    dbDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Settings"] != DBNull.Value)
                    {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.LoadXml(dataTable.Rows[0]["Settings"].ToString());
                        XmlNode xmlNode = xmlDocument.SelectSingleNode("ReqForRepairFTP");
                        if (xmlNode != null)
                        {
                            XmlNode xmlNode2 = xmlNode.SelectSingleNode("RIC");
                            if (xmlNode2 != null)
                            {
                                XmlAttribute xmlAttribute = xmlNode2.Attributes["SendRIC"];
                                if (xmlAttribute != null)
                                {
                                    this.isSendRIC = Convert.ToBoolean(xmlAttribute.Value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }
        }

        private void method_2()
        {
            try
            {
                this.tblRequestForRepairClientType2 = new DataTable("tR_RequestForRepairClient");
                base.SelectSqlData(this.tblRequestForRepairClientType2, true, "where type = 2 order by name", null, false, 0);
                DataTable dataTable = new DataTable("tR_RequestForRepairClient");
                dataTable.Columns.Add("name", typeof(string));
                dataTable.Columns.Add("value", typeof(int));
                this.cmbRegion.DataSource = dataTable;
                this.cmbRegion.DisplayMember = "Name";
                this.cmbRegion.ValueMember = "Value";
                if (this.isSendRIC)
                {
                    try
                    {
#pragma warning disable CS0618 // Тип или член устарел
                        ServicePointManager.CertificatePolicy = new _CertificatePolicy();
#pragma warning restore CS0618 // Тип или член устарел
                        foreach (DICTIONARY dictionary in new RequestsServiceSoapClient
                        {
                            InnerChannel =
                            {
                                OperationTimeout = new TimeSpan(0, 0, 5)
                            }
                        }.GetDictTypeRegion())
                        {
                            dataTable.Rows.Add(new object[]
                            {
                                dictionary.Name,
                                dictionary.Value
                            });
                        }
                        // goto IL_21A;
                        return;
                    }
                    catch (Exception)
                    {
                        this.cmbRegion.ForeColor = Color.Red;
                        if (dataTable.Rows.Count == 0)
                        {
                            foreach (object obj in this.tblRequestForRepairClientType2.Rows)
                            {
                                DataRow dataRow = (DataRow)obj;
                                dataTable.Rows.Add(new object[]
                                {
                                    dataRow["name"],
                                    dataRow["Value"]
                                });
                            }
                        }
                        //goto IL_21A;
                        return;
                    }
                }
                if (dataTable.Rows.Count == 0)
                {
                    foreach (object obj2 in this.tblRequestForRepairClientType2.Rows)
                    {
                        DataRow dataRow2 = (DataRow)obj2;
                        dataTable.Rows.Add(new object[]
                        {
                            dataRow2["name"],
                            dataRow2["Value"]
                        });
                    }
                }
                //IL_21A:;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbSR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbSR.SelectedValue != null)
            {
                if (this.cmbSR.SelectedValue != DBNull.Value)
                {
                    if (this.tblRequestForRepairClientType2 != null)
                    {
                        DataRow[] array = this.tblRequestForRepairClientType2.Select("GESid = " + this.cmbSR.SelectedValue.ToString());
                        if (array.Length != 0 && array[0]["Value"] != DBNull.Value)
                        {
                            this.cmbRegion.SelectedValue = array[0]["Value"];
                        }
                    }
                    return;
                }
            }
            this.cmbRegion.SelectedIndex = -1;
        }

        private void cmbRegion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbRegion.SelectedValue != null)
            {
                if (this.cmbRegion.SelectedValue != DBNull.Value)
                {
                    if (this.tblRequestForRepairClientType2 != null)
                    {
                        DataRow[] array = this.tblRequestForRepairClientType2.Select("Value = " + this.cmbRegion.SelectedValue.ToString());
                        if (array.Length != 0 && array[0]["GesId"] != DBNull.Value)
                        {
                            this.cmbSR.SelectedValue = array[0]["GESId"];
                        }
                    }
                    return;
                }
            }
            this.cmbSR.SelectedIndex = -1;
        }

        private void method_3()
        {
            this.tblRequestForRepairClientType1 = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.tblRequestForRepairClientType1, true, "where type = 1 order by name", null, false, 0);
            DataTable dataTable = new DataTable("tR_RequestForRepairClient");
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("value", typeof(int));
            this.cmbTypeDisable.DataSource = dataTable;
            this.cmbTypeDisable.DisplayMember = "Name";
            this.cmbTypeDisable.ValueMember = "Value";
            if (this.isSendRIC)
            {
                try
                {
#pragma warning disable CS0618 // Тип или член устарел
                    ServicePointManager.CertificatePolicy = new _CertificatePolicy();
#pragma warning restore CS0618 // Тип или член устарел
                    foreach (DICTIONARY dictionary in new RequestsServiceSoapClient
                    {
                        InnerChannel =
                        {
                            OperationTimeout = new TimeSpan(0, 0, 5)
                        }
                    }.GetDictTypeDisable())
                    {
                        dataTable.Rows.Add(new object[]
                        {
                            dictionary.Name,
                            dictionary.Value
                        });
                    }
                    return;
                }
                catch (Exception)
                {
                    this.cmbTypeDisable.ForeColor = Color.Red;
                    if (dataTable.Rows.Count == 0)
                    {
                        foreach (object obj in this.tblRequestForRepairClientType1.Rows)
                        {
                            DataRow dataRow = (DataRow)obj;
                            dataTable.Rows.Add(new object[]
                            {
                                dataRow["name"],
                                dataRow["Value"]
                            });
                        }
                    }
                    return;
                }
            }
            if (dataTable.Rows.Count == 0)
            {
                foreach (object obj2 in this.tblRequestForRepairClientType1.Rows)
                {
                    DataRow dataRow2 = (DataRow)obj2;
                    dataTable.Rows.Add(new object[]
                    {
                        dataRow2["name"],
                        dataRow2["Value"]
                    });
                }
            }
        }

        private void cmbTypeDisable_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbTypeDisable.SelectedValue != null)
            {
                if (this.cmbTypeDisable.SelectedValue != DBNull.Value)
                {
                    if (this.tblRequestForRepairClientType1 != null)
                    {
                        DataRow[] array = this.tblRequestForRepairClientType1.Select("Value = " + this.cmbTypeDisable.SelectedValue.ToString());
                        if (array.Length != 0 && array[0]["GesId"] != DBNull.Value)
                        {
                            this.cmbIsPlanned.SelectedValue = Convert.ToBoolean(array[0]["GesId"]);
                        }
                    }
                    return;
                }
            }
            this.cmbIsPlanned.SelectedIndex = -1;
        }

        private void cmbIsPlanned_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbIsPlanned.SelectedValue != null)
            {
                if (this.cmbIsPlanned.SelectedValue != DBNull.Value)
                {
                    if (this.tblRequestForRepairClientType1 != null)
                    {
                        DataRow[] array = this.tblRequestForRepairClientType1.Select("GesId = " + Convert.ToInt32(this.cmbIsPlanned.SelectedValue).ToString());
                        if (array.Length != 0 && array[0]["Value"] != DBNull.Value)
                        {
                            this.cmbTypeDisable.SelectedValue = array[0]["Value"];
                        }
                    }
                    return;
                }
            }
            this.cmbTypeDisable.SelectedIndex = -1;
        }

        private void method_4()
        {
            this.tblRequestForRepairClientType3 = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.tblRequestForRepairClientType3, true, "where type = 3 order by name", null, false, 0);
            DataTable dataTable = new DataTable("tR_RequestForRepairClient");
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("value", typeof(int));
            this.cmbOrganization.DataSource = dataTable;
            this.cmbOrganization.DisplayMember = "Name";
            this.cmbOrganization.ValueMember = "Value";
            DataTable dataTable2 = new DataTable("tR_RequestForRepairClient");
            dataTable2.Columns.Add("name", typeof(string));
            dataTable2.Columns.Add("value", typeof(int));
            this.cmbPerformerOrganization.DataSource = dataTable2;
            this.cmbPerformerOrganization.DisplayMember = "Name";
            this.cmbPerformerOrganization.ValueMember = "Value";
            if (this.isSendRIC)
            {
                try
                {
#pragma warning disable CS0618 // Тип или член устарел
                    ServicePointManager.CertificatePolicy = new _CertificatePolicy();
#pragma warning restore CS0618 // Тип или член устарел
                    foreach (DICTIONARY dictionary in new RequestsServiceSoapClient
                    {
                        InnerChannel =
                        {
                            OperationTimeout = new TimeSpan(0, 0, 5)
                        }
                    }.GetDictTypeOrganization())
                    {
                        dataTable.Rows.Add(new object[]
                        {
                            dictionary.Name,
                            dictionary.Value
                        });
                        dataTable2.Rows.Add(new object[]
                        {
                            dictionary.Name,
                            dictionary.Value
                        });
                    }
                    return;
                }
                catch (Exception)
                {
                    this.cmbOrganization.ForeColor = Color.Red;
                    this.cmbPerformerOrganization.ForeColor = Color.Red;
                    if (dataTable.Rows.Count == 0)
                    {
                        foreach (object obj in this.tblRequestForRepairClientType3.Rows)
                        {
                            DataRow dataRow = (DataRow)obj;
                            dataTable.Rows.Add(new object[]
                            {
                                dataRow["name"],
                                dataRow["Value"]
                            });
                            dataTable2.Rows.Add(new object[]
                            {
                                dataRow["name"],
                                dataRow["Value"]
                            });
                        }
                    }
                    return;
                }
            }
            if (dataTable.Rows.Count == 0)
            {
                foreach (object obj2 in this.tblRequestForRepairClientType3.Rows)
                {
                    DataRow dataRow2 = (DataRow)obj2;
                    dataTable.Rows.Add(new object[]
                    {
                        dataRow2["name"],
                        dataRow2["Value"]
                    });
                    dataTable2.Rows.Add(new object[]
                    {
                        dataRow2["name"],
                        dataRow2["Value"]
                    });
                }
            }
        }

        private void method_5()
        {
            this.tblRequestForRepairClientType4 = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.tblRequestForRepairClientType4, true, "where type = 4 order by name", null, false, 0);
            DataTable dataTable = new DataTable("tR_RequestForRepairClient");
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("value", typeof(int));
            this.cmbGroupWorks.DataSource = dataTable;
            this.cmbGroupWorks.DisplayMember = "Name";
            this.cmbGroupWorks.ValueMember = "Value";
            if (this.isSendRIC)
            {
                try
                {
#pragma warning disable CS0618 // Тип или член устарел
                    ServicePointManager.CertificatePolicy = new _CertificatePolicy();
#pragma warning restore CS0618 // Тип или член устарел
                    foreach (DICTIONARY dictionary in new RequestsServiceSoapClient
                    {
                        InnerChannel =
                        {
                            OperationTimeout = new TimeSpan(0, 0, 5)
                        }
                    }.GetDictGroupWorks())
                    {
                        dataTable.Rows.Add(new object[]
                        {
                            dictionary.Name,
                            dictionary.Value
                        });
                    }
                    return;
                }
                catch (Exception)
                {
                    this.cmbGroupWorks.ForeColor = Color.Red;
                    if (dataTable.Rows.Count == 0)
                    {
                        foreach (object obj in this.tblRequestForRepairClientType4.Rows)
                        {
                            DataRow dataRow = (DataRow)obj;
                            dataTable.Rows.Add(new object[]
                            {
                                dataRow["name"],
                                dataRow["Value"]
                            });
                        }
                    }
                    return;
                }
            }
            if (dataTable.Rows.Count == 0)
            {
                foreach (object obj2 in this.tblRequestForRepairClientType4.Rows)
                {
                    DataRow dataRow2 = (DataRow)obj2;
                    dataTable.Rows.Add(new object[]
                    {
                        dataRow2["name"],
                        dataRow2["Value"]
                    });
                }
            }
        }

        private void FillComboBoxStatus()
        {
            this.tblRequestForRepairClientType5 = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.tblRequestForRepairClientType5, true, "where type = 5 order by name", null, false, 0);
            DataTable dataTable = new DataTable("tR_RequestForRepairClient");
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("value", typeof(int));
            this.cmbStatus.DataSource = dataTable;
            this.cmbStatus.DisplayMember = "Name";
            this.cmbStatus.ValueMember = "Value";
            if (this.isSendRIC)
            {
                try
                {
#pragma warning disable CS0618 // Тип или член устарел
                    ServicePointManager.CertificatePolicy = new _CertificatePolicy();
#pragma warning restore CS0618 // Тип или член устарел
                    foreach (DICTIONARY dictionary in new RequestsServiceSoapClient
                    {
                        InnerChannel =
                        {
                            OperationTimeout = new TimeSpan(0, 0, 5)
                        }
                    }.GetDictStatus())
                    {
                        dataTable.Rows.Add(new object[]
                        {
                            dictionary.Name,
                            dictionary.Value
                        });
                    }
                    return;
                }
                catch (Exception)
                {
                    this.cmbStatus.ForeColor = Color.Red;
                    if (dataTable.Rows.Count == 0)
                    {
                        foreach (object obj in this.tblRequestForRepairClientType5.Rows)
                        {
                            DataRow dataRow = (DataRow)obj;
                            dataTable.Rows.Add(new object[]
                            {
                                dataRow["name"],
                                dataRow["Value"]
                            });
                        }
                    }
                    return;
                }
            }
            if (dataTable.Rows.Count == 0)
            {
                foreach (object obj2 in this.tblRequestForRepairClientType5.Rows)
                {
                    DataRow dataRow2 = (DataRow)obj2;
                    dataTable.Rows.Add(new object[]
                    {
                        dataRow2["name"],
                        dataRow2["Value"]
                    });
                }
            }
        }

        private void FormJournalRequestForRepairAddEdit_Load(object sender, EventArgs e)
        {
            this.method_1();
            this.Get_StatusRequest();
            WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            this.txtAdress.ReadOnly = false;
            this.dateTimePickerBeg.Value = DateTime.Now.Date.AddHours(8.0);
            this.dateTimePickerEnd.Value = DateTime.Now.Date.AddHours(17.0);
            this.FillComboBoxs();
            this.method_2();
            this.method_3();
            this.method_4();
            this.method_5();
            this.FillComboBoxStatus();
            base.LoadFormConfig(null);
            switch (this.eActionRequestRepair)
            {
                case eActionRequestRepair.Add:
                    if (this.DataRowCurrent != null)
                    {
                        DataRow dataRow = this.dataSetN.tJ_RequestForRepair.NewRow();
                        dataRow["num"] = 0;
                        dataRow["dateCreate"] = DateTime.Now;
                        this.SetMinDate(DateTime.Now);
                        dataRow["idWorker"] = this.DataRowCurrent["idWorker"];
                        dataRow["reguestFiled"] = this.DataRowCurrent["reguestFiled"];
                        dataRow["idSR"] = this.DataRowCurrent["idSR"];
                        if (this.tblRequestForRepairClientType2 != null)
                        {
                            DataRow[] array = this.tblRequestForRepairClientType2.Select("GESid = " + this.DataRowCurrent["idSR"].ToString());
                            if (array.Length != 0 && array[0]["Value"] != DBNull.Value)
                            {
                                dataRow["idRegion"] = array[0]["Value"];
                            }
                        }
                        dataRow["schmObj"] = this.DataRowCurrent["schmObj"];
                        dataRow["Purpose"] = this.DataRowCurrent["Purpose"];
                        dataRow["IsPlanned"] = this.DataRowCurrent["IsPlanned"];
                        dataRow["crash"] = this.DataRowCurrent["crash"];
                        if (this.tblRequestForRepairClientType1 != null)
                        {
                            DataRow[] array2 = this.tblRequestForRepairClientType1.Select("GesId = " + Convert.ToInt32(this.DataRowCurrent["IsPlanned"]).ToString());
                            if (array2.Length != 0 && array2[0]["Value"] != DBNull.Value)
                            {
                                dataRow["typeDisable"] = array2[0]["Value"];
                            }
                        }
                        dataRow["agreed"] = false;
                        dataRow["iddivision"] = this.DataRowCurrent["iddivision"];
                        dataRow["deleted"] = false;
                        if (this.isCrash)
                        {
                            dataRow["SendSite"] = true;
                        }
                        else
                        {
                            dataRow["SendSite"] = false;
                        }
                        if (this.tblRequestForRepairClientType3 != null)
                        {
                            DataRow[] array3 = this.tblRequestForRepairClientType3.Select("isDefault = true");
                            if (array3.Length != 0)
                            {
                                dataRow["Organization"] = array3[0]["Value"];
                                dataRow["performerOrganization"] = array3[0]["Value"];
                            }
                        }
                        if (this.tblRequestForRepairClientType4 != null)
                        {
                            DataRow[] array4 = this.tblRequestForRepairClientType4.Select("isDefault = true");
                            if (array4.Length != 0)
                            {
                                dataRow["groupWorks"] = array4[0]["Value"];
                            }
                        }
                        DataTable dataTable = this.GetTableUser();
                        base.SelectSqlData(dataTable, true, " where [Login] = SYSTEM_USER ", null, false, 0);
                        if (dataTable.Rows.Count > 0)
                        {
                            dataRow["idUserCreate"] = dataTable.Rows[0]["iduser"];
                            if (dataTable.Rows[0]["idWorker"] != DBNull.Value)
                            {
                                dataRow["IdWorker"] = dataTable.Rows[0]["idWorker"];
                            }
                        }
                        this.dataSetN.tJ_RequestForRepair.Rows.Add(dataRow);
                    }
                    else
                    {
                        DataRow dataRow2 = this.dataSetN.tJ_RequestForRepair.NewRow();
                        dataRow2["num"] = 0;
                        dataRow2["dateCreate"] = DateTime.Now;
                        this.SetMinDate(DateTime.Now);
                        dataRow2["idWorker"] = -1;
                        dataRow2["reguestFiled"] = "";
                        dataRow2["idSR"] = this.idSR;
                        dataRow2["schmObj"] = "";
                        dataRow2["Purpose"] = "";
                        dataRow2["crash"] = this.IsCrash;
                        if (this.IsCrash)
                        {
                            dataRow2["IsPlanned"] = false;
                        }
                        else
                        {
                            dataRow2["IsPlanned"] = true;
                        }
                        dataRow2["agreed"] = false;
                        dataRow2["iddivision"] = this.IdDivision;
                        dataRow2["deleted"] = false;
                        if (this.isCrash)
                        {
                            dataRow2["SendSite"] = true;
                        }
                        else
                        {
                            dataRow2["SendSite"] = false;
                        }
                        if (this.tblRequestForRepairClientType3 != null)
                        {
                            DataRow[] array5 = this.tblRequestForRepairClientType3.Select("isDefault = true");
                            if (array5.Length != 0)
                            {
                                dataRow2["Organization"] = array5[0]["Value"];
                                dataRow2["performerOrganization"] = array5[0]["Value"];
                            }
                        }
                        if (this.tblRequestForRepairClientType4 != null)
                        {
                            DataRow[] array6 = this.tblRequestForRepairClientType4.Select("isDefault = true");
                            if (array6.Length != 0)
                            {
                                dataRow2["groupWorks"] = array6[0]["Value"];
                            }
                        }
                        DataTable dataTable2 = this.GetTableUser();
                        base.SelectSqlData(dataTable2, true, " where [Login] = SYSTEM_USER ", null, false, 0);
                        if (dataTable2.Rows.Count > 0)
                        {
                            dataRow2["idUserCreate"] = dataTable2.Rows[0]["iduser"];
                            if (dataTable2.Rows[0]["idWorker"] != DBNull.Value)
                            {
                                dataRow2["IdWorker"] = dataTable2.Rows[0]["idWorker"];
                            }
                        }
                        this.dataSetN.tJ_RequestForRepair.Rows.Add(dataRow2);
                        if (this.IsCrash)
                        {
                            this.cmbIsPlanned.SelectedIndex = 0;
                        }
                        else
                        {
                            this.cmbIsPlanned.SelectedIndex = 1;
                        }
                        if (this.cmbWorker.SelectedItem != null)
                        {
                            dataRow2["reguestFiled"] = this.cmbWorker.Text;
                        }
                    }
                    break;
                case eActionRequestRepair.Edit:
                    if (this.IdRequest > 0)
                    {
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
                        if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0 && this.dataSetN.tJ_RequestForRepair.Rows[0]["DateCreate"] != DBNull.Value)
                        {
                            this.SetMinDate(Convert.ToDateTime(this.dataSetN.tJ_RequestForRepair.Rows[0]["DateCreate"]));
                        }
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairAddress, true, " where idRequest = " + this.IdRequest.ToString());
                        this.LoadTableSchmObjects();
                        this.FillTableAddress();
                    }
                    break;
                case eActionRequestRepair.Read:
                    if (this.IdRequest > 0)
                    {
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairAddress, true, " where idRequest = " + this.IdRequest.ToString());
                        this.LoadTableSchmObjects();
                        this.FillTableAddress();
                    }
                    this.method_7();
                    break;
            }
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.eActionRequestRepair == eActionRequestRepair.Edit && this.dataSetN.tJ_RequestForRepair.Rows[0]["Status"] != DBNull.Value)
                {
                    this.idStatus = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["Status"]);
                }
                if (this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"] != DBNull.Value)
                {
                    this.isAgreed = Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"]);
                }
                if (this.IdDivision <= 0)
                {
                    this.IdDivision = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["IdDivision"]);
                }
                if (this.dataSetN.tJ_RequestForRepair.Rows[0]["Crash"] != DBNull.Value && Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["Crash"]))
                {
                    this.cmbIsPlanned.Enabled = false;
                    this.cmbTypeDisable.Enabled = false;
                    this.IsCrash = true;
                }
            }
            if (!this.IsCrash)
            {
                this.cmbTypeDamage.Visible = false;
            }
            else
            {
                this.LoadTypeDamage();
                this.isCountRowsForRepairDaily();
            }
            this.CreateCaptionNames();
            if (this.IdDivision == 921)
            {
                this.groupBoxODS.Visible = false;
            }
            this.EnableIsCrash();
            this.Load_RequestForRepairLog();
        }

        private void FormJournalRequestForRepairAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if (this.eActionRequestRepair != eActionRequestRepair.Read && !this.CheckRequiredFields())
                {
                    MessageBox.Show("Не введены обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    e.Cancel = true;
                    return;
                }
                //eActionRequestRepair eActionRequestRepair = this.eActionRequestRepair;
                switch (eActionRequestRepair)
                {
                    case eActionRequestRepair.Add:
                        this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                        this.IdRequest = base.InsertSqlDataOneRow(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                        break;
                    case eActionRequestRepair.Edit:
                        this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                        base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                        break;
                }

                foreach (DataRow dataRow in this.dataSetN.tJ_RequestForRepairDaily)
                {
                    if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
                    {
                        if (Convert.ToInt32(dataRow["idrequest"]) != this.IdRequest)
                        {
                            dataRow["idRequest"] = this.IdRequest;
                        }
                        dataRow.EndEdit();
                    }
                }
                base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                this.UpdateSchmObjList();
                this.UpdateRepairDoc();
                this.UpdateRepairAddress();
                this.InsertLogToTableRequestForRepairLog();
                this.SendRequestToRIC();
                this.SendRequestToSite();
                this.CreateDocumentDamage();
            }
        }

        private void FormJournalRequestForRepairAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void method_7()
        {
            this.cmbWorker.Enabled = false;
            this.cmbRequestFiled.Enabled = false;
            this.cmbSR.Enabled = false;
            this.txtObject.ReadOnly = true;
            this.txtPurpose.ReadOnly = true;
            this.cmbIsPlanned.Enabled = false;
            this.groupBoxDaily.Enabled = false;
            this.txtAgreeWith.ReadOnly = true;
            this.txtComment.ReadOnly = true;
            this.txtAdress.ReadOnly = true;
            this.checkBoxAgreed.Enabled = false;
            this.dateTimePickerDateAgreed.Enabled = false;
            this.cmbDispatcher.Enabled = false;
            this.cmbTypeDamage.Enabled = false;
            Control control = this.cmbOrganization;
            Control control2 = this.cmbPerformerOrganization;
            this.cmbGroupWorks.Enabled = false;
            control2.Enabled = false;
            control.Enabled = false;
            this.cmbStatus.Enabled = false;
            this.EnableIsCrash();
            Control control3 = this.toolStripScheme;
            this.toolStripAddress.Enabled = false;
            control3.Enabled = false;
            this.toolStripDocuments.Enabled = false;
            this.toolBtnCopy.Enabled = false;
            this.buttonOK.Visible = false;
        }

        private void SetMinDate(DateTime dateTimeMin)
        {
            this.dateTimeBeg = dateTimeMin.AddDays(-1.0).Date;

            this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
            this.dateTimePickerFactEnd.MinDate = this.dateTimeBeg;
            this.dateTimePickerDateAgreed.MinDate = this.dateTimeBeg;
        }

        private void groupBoxODS_VisibleChanged(object sender, EventArgs e)
        {
            //if (!this.groupBoxODS.Visible)
            //{
            //    this.tabControl.Height = 325;
            //    base.Height = 391;
            //    this.buttonCancel.Location = new Point(this.buttonCancel.Location.X, 331);
            //    this.buttonOK.Location = new Point(this.buttonOK.Location.X, 331);
            //}
            //else
            //{
            //    this.tabControl.Height = 581;
            //    base.Height = 647;
            //    this.buttonCancel.Location = new Point(this.buttonCancel.Location.X, 587);
            //    this.buttonOK.Location = new Point(this.buttonOK.Location.X, 587);
            //}
        }

        private void CreateCaptionNames()
        {
            string str = "";
            if (this.IdDivision > 0)
            {
                DataTable dataTable = new DataTable("tR_Classifier");
                dataTable.Columns.Add("SocrName", typeof(string));
                base.SelectSqlData(dataTable, true, "where id = " + this.IdDivision.ToString(), null, false, 0);
                if (dataTable.Rows.Count > 0)
                {
                    str = " " + dataTable.Rows[0]["SocrName"].ToString() + " (N)";
                }
            }
            else
                str = " (N)";
            switch (this.eActionRequestRepair)
            {
                case eActionRequestRepair.Add:
                    if (this.IsCrash)
                    {
                        this.Text = "Создать новую аварийную заявку" + str;
                        return;
                    }
                    this.Text = "Создать новую заявку" + str;
                    return;
                case eActionRequestRepair.Edit:
                    if (this.IsCrash)
                    {
                        this.Text = "Редактирование аварийной заявки" + str;
                        return;
                    }
                    this.Text = "Редактирование заявки" + str;
                    return;
                case eActionRequestRepair.Read:
                    if (this.IsCrash)
                    {
                        this.Text = "Просмотр аварийной заявки" + str;
                        return;
                    }
                    this.Text = "Просмотр заявки" + str;
                    return;
                default:
                    return;
            }
            
        }

        private DataTable GeTabletWorkerGroup()
        {
            Type type = Type.GetType("System.Int32");
            DataTable dataTable = new DataTable("vWorkerGroup");
            DataColumn dataColumn = new DataColumn("id", type);
            dataTable.Columns.Add(dataColumn);
            DataColumn column = new DataColumn("fio", Type.GetType("System.String"));
            dataTable.Columns.Add(column);
            DataColumn column2 = new DataColumn("GroupElectrical", type);
            dataTable.Columns.Add(column2);
            dataTable.PrimaryKey = new DataColumn[]
            {
                dataColumn
            };
            DataColumn dataColumn2 = new DataColumn("GroupRoman", Type.GetType("System.String"));
            dataColumn2.Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))";
            dataTable.Columns.Add(dataColumn2);
            return dataTable;
        }

        private DataTable GetTableUser()
        {
            Type type = Type.GetType("System.Int32");
            DataTable dataTable = new DataTable("tUser");
            DataColumn dataColumn = new DataColumn("idUser", type);
            dataTable.Columns.Add(dataColumn);
            DataColumn column = new DataColumn("idWorker", type);
            dataTable.Columns.Add(column);
            DataColumn column2 = new DataColumn("name", Type.GetType("System.String"));
            dataTable.Columns.Add(column2);
            dataTable.PrimaryKey = new DataColumn[]
            {
                dataColumn
            };
            return dataTable;
        }
        private void FillComboBoxs()
        {
            DataTable dataTable = this.GetTableUser();
            base.SelectSqlData(dataTable, true, " order by name ", null, false, 0);
            this.cmbUserCreate.DataSource = dataTable;
            this.cmbUserCreate.DisplayMember = "NAME";
            this.cmbUserCreate.ValueMember = "IDUSER";
            DataTable dataTable2 = this.GeTabletWorkerGroup();
            base.SelectSqlData(dataTable2, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.cmbWorker.DataSource = dataTable2;
            this.cmbWorker.DisplayMember = "FIO";
            this.cmbWorker.ValueMember = "ID";
            this.cmbRequestFiled.DataSource = dataTable2;
            this.cmbRequestFiled.DisplayMember = "FIO";
            this.cmbRequestFiled.ValueMember = "ID";
            DataTable dataTable3 = this.GeTabletWorkerGroup();
            base.SelectSqlData(dataTable3, true, " where ParentKey in (';GroupWorker;ReconcileRequestRepair;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
            this.cmbDispatcher.DataSource = dataTable3;
            this.cmbDispatcher.DisplayMember = "FIO";
            this.cmbDispatcher.ValueMember = "ID";
            base.SelectSqlData(this.dataSetN, this.dataSetN.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
            this.cmbSR.DataSource = this.dataSetN.tR_Classifier;
            this.cmbSR.DisplayMember = "name";
            this.cmbSR.ValueMember = "ID";
            this.cmbSR.SelectedIndex = -1;
            DataTable dataTable4 = new DataTable();
            dataTable4.Columns.Add("name", typeof(string));
            dataTable4.Columns.Add("value", typeof(bool));
            this.cmbIsPlanned.DataSource = dataTable4;
            this.cmbIsPlanned.DisplayMember = "name";
            this.cmbIsPlanned.ValueMember = "value";
            if (this.IsCrash)
            {
                dataTable4.Rows.Add(new object[]
                {
                    "Аварийный",
                    false
                });
            }
            else
            {
                dataTable4.Rows.Add(new object[]
                {
                    "Срочный",
                    false
                });
            }
            dataTable4.Rows.Add(new object[]
            {
                "Плановый",
                true
            });
            DataTable dataTable5 = new DataTable("tR_Classifier");
            dataTable5.Columns.Add("id", typeof(int));
            dataTable5.Columns.Add("name", typeof(string));
            base.SelectSqlData(dataTable5, true, string.Format(" where id in ({0}, {1})", 1402, 1401), null, false, 0);
            this.cmbTypeDamage.DisplayMember = "name";
            this.cmbTypeDamage.ValueMember = "id";
            this.cmbTypeDamage.DataSource = dataTable5;
            this.cmbTypeDamage.SelectedIndex = -1;
        }

        private bool CheckRequiredFields()
        {
            bool result = true;
            if (string.IsNullOrEmpty(this.cmbRequestFiled.Text))
            {
                this.labelRequestFiled.ForeColor = Color.Red;
                result = false;
            }
            if (this.cmbSR.SelectedIndex < 0)
            {
                this.labelSR.ForeColor = Color.Red;
                result = false;
            }
            if (string.IsNullOrEmpty(this.txtObject.Text))
            {
                this.labelObject.ForeColor = Color.Red;
                result = false;
            }
            if (string.IsNullOrEmpty(this.txtPurpose.Text))
            {
                this.labelPurpose.ForeColor = Color.Red;
                result = false;
            }
            if (this.cmbIsPlanned.SelectedIndex < 0)
            {
                this.labelIsPlanned.ForeColor = Color.Red;
                result = false;
            }
            if (this.dataSetN.tJ_RequestForRepairDaily.Rows.Count <= 0)
            {
                List<Color> list = new List<Color>();
                foreach (object obj in this.groupBoxDaily.Controls)
                {
                    Control control = (Control)obj;
                    list.Add(control.ForeColor);
                }
                this.groupBoxDaily.ForeColor = Color.Red;
                int num = 0;
                foreach (object obj2 in this.groupBoxDaily.Controls)
                {
                    ((Control)obj2).ForeColor = list[num];
                    num++;
                }
                result = false;
            }
            if (this.checkBoxAgreed.Checked && this.IdDivision == 920)
            {
                if (this.cmbOrganization.SelectedIndex < 0)
                {
                    this.labelOrganization.ForeColor = Color.Red;
                    result = true;
                }
                if (this.cmbPerformerOrganization.SelectedIndex < 0)
                {
                    this.labelPerformer.ForeColor = Color.Red;
                    result = true;
                }
                if (this.cmbGroupWorks.SelectedIndex < 0)
                {
                    this.labelGroupWork.ForeColor = Color.Red;
                    result = true;
                }
                if (this.cmbStatus.SelectedIndex < 0)
                {
                    this.labelStatus.ForeColor = Color.Red;
                    result = false;
                }
                if (this.IsCrash && this.cmbTypeDamage.SelectedIndex < 0)
                {
                    result = false;
                }
            }
            return result;
        }
        /// <summary>
        /// Отправка данных в РИЦ
        /// </summary>
        private void SendRequestToRIC()
        {
            if (!this.isSendRIC)
            {
                return;
            }
            if (!this.IsCrash)
            {
                return;
            }
            if (this.IdRequest == -1)
            {
                return;
            }
            if (!this.checkBoxAgreed.Checked)
            {
                return;
            }
            base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.dataSetN.tJ_RequestForRepair.Rows[0]["idRIC"] == DBNull.Value)
                {
                    try
                    {
                        RequestsServiceSoapClient requestsServiceSoapClient = new RequestsServiceSoapClient();
                        Request request = new Request();
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["num"] != DBNull.Value)
                        {
                            request.Number = this.dataSetN.tJ_RequestForRepair.Rows[0]["num"].ToString();
                        }
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["schmObj"] != DBNull.Value)
                        {
                            request.AddressDisableText = this.dataSetN.tJ_RequestForRepair.Rows[0]["schmObj"].ToString();
                        }
                        using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                        {
                            sqlConnection.Open();
                            DbDataAdapter dbDataAdapter = new SqlDataAdapter(" select o.name as city, o.socr as citytype, s.name as street, s.socr as streettype, a.house  from tj_requestforrepairaddress a  inner join tr_kladrstreet s on s.id = a.idkladrstreet  inner join tr_kladrobj o on o.id = s.kladrObjid  where a.idREquest = " + this.IdRequest.ToString(), sqlConnection);
                            DataTable dataTable = new DataTable();
                            dbDataAdapter.Fill(dataTable);
                            request.AddressHousesDidable = new AddressObjects[dataTable.Rows.Count];
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                DataRow dataRow = dataTable.Rows[i];
                                request.AddressHousesDidable[i] = new AddressObjects();
                                if (dataRow["city"] != DBNull.Value)
                                {
                                    request.AddressHousesDidable[i].City = dataRow["city"].ToString();
                                }
                                if (dataRow["citytype"] != DBNull.Value)
                                {
                                    request.AddressHousesDidable[i].CityType = dataRow["citytype"].ToString();
                                }
                                if (dataRow["street"] != DBNull.Value)
                                {
                                    request.AddressHousesDidable[i].Street = dataRow["street"].ToString();
                                }
                                if (dataRow["streettype"] != DBNull.Value)
                                {
                                    request.AddressHousesDidable[i].StreetType = dataRow["streettype"].ToString();
                                }
                                if (dataRow["house"] != DBNull.Value)
                                {
                                    request.AddressHousesDidable[i].House = dataRow["house"].ToString();
                                }
                            }
                        }
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
                        request.DateBeginEnd = new DateBeginEndList[this.dataSetN.tJ_RequestForRepairDaily.Rows.Count];
                        for (int j = 0; j < this.dataSetN.tJ_RequestForRepairDaily.Rows.Count; j++)
                        {
                            DataRow dataRow2 = this.dataSetN.tJ_RequestForRepairDaily.Rows[j];
                            request.DateBeginEnd[j] = new DateBeginEndList();
                            if (dataRow2["dateBeg"] != DBNull.Value)
                            {
                                request.DateBeginEnd[j].DateBegin = Convert.ToDateTime(dataRow2["dateBeg"]);
                                if (j == 0)
                                {
                                    request.DateBegin = Convert.ToDateTime(dataRow2["dateBeg"]);
                                }
                            }
                            if (dataRow2["dateEnd"] != DBNull.Value)
                            {
                                request.DateBeginEnd[j].DateEnd = Convert.ToDateTime(dataRow2["dateEnd"]);
                                if (j == this.dataSetN.tJ_RequestForRepairDaily.Rows.Count - 1)
                                {
                                    request.DatePlan = new DateTime?(Convert.ToDateTime(dataRow2["dateEnd"]));
                                    request.DateEnd = new DateTime?(Convert.ToDateTime(dataRow2["dateEnd"]));
                                }
                            }
                        }
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["typeDisable"] != DBNull.Value)
                        {
                            request.RefTypeDisable = (long)Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["typeDisable"]);
                        }
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["purpose"] != DBNull.Value)
                        {
                            request.Cause = this.dataSetN.tJ_RequestForRepair.Rows[0]["purpose"].ToString();
                        }
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["organization"] != DBNull.Value)
                        {
                            request.ToOrganizationId = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["organization"]);
                        }
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["status"] != DBNull.Value)
                        {
                            request.RefRequestStatusId = (long)Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["status"]);
                        }
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["performerorganization"] != DBNull.Value)
                        {
                            request.PerformerOrganizationId = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["performerorganization"]);
                        }
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["groupWorks"] != DBNull.Value)
                        {
                            request.RefGroupWorksId = (long)Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["groupWorks"]);
                        }
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0]["idRegion"] != DBNull.Value)
                        {
                            request.RefRegionId = (long)Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["idRegion"]);
                        }
                        Response response = requestsServiceSoapClient.SendReq(request);
                        if (response.RequestId > 0L)
                        {
                            this.dataSetN.tJ_RequestForRepair.Rows[0]["idric"] = response.RequestId;
                            this.dataSetN.tJ_RequestForRepair.Rows[0]["isSEnd"] = true;
                            this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                        }
                        else
                        {
                            if (this.dataSetN.tJ_RequestForRepair.Rows[0]["messageRic"] == DBNull.Value)
                            {
                                this.dataSetN.tJ_RequestForRepair.Rows[0]["messageRic"] = response.Message;
                            }
                            else
                            {
                                this.dataSetN.tJ_RequestForRepair.Rows[0]["messageRic"] = response.Message + " \r\n" + this.dataSetN.tJ_RequestForRepair.Rows[0]["messageRic"].ToString();
                            }
                            if (this.dataSetN.tJ_RequestForRepair.Rows[0]["messageRic"].ToString().Length > 1024)
                            {
                                this.dataSetN.tJ_RequestForRepair.Rows[0]["messageRic"] = this.dataSetN.tJ_RequestForRepair.Rows[0]["messageRic"].ToString().Substring(0, 1024);
                            }
                            this.dataSetN.tJ_RequestForRepair.Rows[0]["isSEnd"] = false;
                            this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                            MessageBox.Show(response.Message, "Сообщение из РИЦ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                        return;
                    }
                }
                if (this.dataSetN.tJ_RequestForRepair.Rows[0]["Status"] == DBNull.Value)
                {
                    return;
                }
                int num = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["idRIC"]);
                if (this.idStatus != Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["Status"]))
                {
                    if (Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["Status"]) == 164277)
                    {
                        try
                        {
                            RequestsServiceSoapClient requestsServiceSoapClient2 = new RequestsServiceSoapClient();
                            DateTime dateEnd = DateTime.Now;
                            if (this.dataSetN.tJ_RequestForRepair.Rows[0]["dateFactEnd"] != DBNull.Value)
                            {
                                dateEnd = Convert.ToDateTime(this.dataSetN.tJ_RequestForRepair.Rows[0]["dateFactEnd"]);
                            }
                            Response response2 = requestsServiceSoapClient2.Succsess((long)num, dateEnd);
                            if (response2.Code != 0)
                            {
                                MessageBox.Show(response2.Message, "Сообщение из РИЦ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(ex2.Message, ex2.Source);
                        }
                    }
                    if (Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["Status"]) == 164280)
                    {
                        try
                        {
                            Response response3 = new RequestsServiceSoapClient().RequestCancel((long)num);
                            if (response3.Code != 0)
                            {
                                MessageBox.Show(response3.Message, "Сообщение из РИЦ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                        catch (Exception ex3)
                        {
                            MessageBox.Show(ex3.Message, ex3.Source);
                        }
                    }
                }
            }
        }

        private void checkBoxDaily_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxWeekEnd.Enabled = this.checkBoxDaily.Checked;
        }

        private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value.AddMinutes(1.0);
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value.AddMinutes(-1.0);
        }

        private void method_15()
        {
            DateTime dateTime = DateTimePicker.MinimumDateTime;
            //if (this.dataSetGES_0.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.Class15, bool>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_0)).Count<DataSetGES.Class15>() > 0)
            if (this.dataSetN.tJ_RequestForRepairDaily
                .Where(r => (r.RowState != DataRowState.Deleted && r.RowState != DataRowState.Detached))
                .Count() > 0)

            {
                try
                {
                    //DataRow dataRow = this.dataSetGES_0.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.Class15, bool>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_1)).OrderBy(new Func<DataSetGES.Class15, object>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_2)).First<DataSetGES.Class15>();
                    DataRow dataRow = this.dataSetN.tJ_RequestForRepairDaily
                        .Where(r => (r.RowState != DataRowState.Deleted && r.RowState != DataRowState.Detached))
                        .OrderBy(r => r["DataBeg"])
                        .First();

                    if (dataRow != null && dataRow["DateBeg"] != DBNull.Value)
                    {
                        dateTime = Convert.ToDateTime(dataRow["DateBeg"]);
                    }
                }
                catch
                {
                }
            }
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0 && this.dataSetN.tJ_RequestForRepair.Rows[0]["DateCreate"] != DBNull.Value && dateTime < Convert.ToDateTime(this.dataSetN.tJ_RequestForRepair.Rows[0]["DateCreate"]).AddDays(-1.0).Date)
            {
                dateTime = Convert.ToDateTime(this.dataSetN.tJ_RequestForRepair.Rows[0]["DateCreate"]).AddDays(-1.0).Date;
            }
            this.dateTimePickerFactEnd.MinDate = dateTime;
        }

        private void dgvDaily_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataRow dataRow = this.dataSetGES_0.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.Class15, bool>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_3)).OrderByDescending(new Func<DataSetGES.Class15, DateTime>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_4)).First<DataSetGES.Class15>();
            DataRow dataRow = this.dataSetN.tJ_RequestForRepairDaily
                .Where(r => (r.RowState != DataRowState.Deleted && r.RowState != DataRowState.Detached))
                .OrderByDescending(r => r["DateEnd"])
                .First();
            if (Convert.ToDateTime(dataRow["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
            {
                this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
            }
            this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow["DateEnd"]);
            this.method_15();
            this.method_16(Convert.ToDateTime(dataRow["DateEnd"]));
        }

        private void method_16(DateTime dateTime_2)
        {
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0 && ((this.dataSetN.tJ_RequestForRepair.Rows[0].HasVersion(DataRowVersion.Original) && this.dataSetN.tJ_RequestForRepair.Rows[0]["dateFactEnd", DataRowVersion.Original] == DBNull.Value) || !this.dataSetN.tJ_RequestForRepair.Rows[0].HasVersion(DataRowVersion.Original)) && !this.IsCrash)
            {
                this.dateTimePickerFactEnd.Value = dateTime_2;
            }
        }

        private void dgvDaily_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.method_15();
            if (this.dataSetN.tJ_RequestForRepairDaily.Rows.Count <= 0)
            {
                this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
                this.method_16(this.dateTimeBeg);
                return;
            }
            //if (this.dataSetGES_0.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.Class15, bool>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_5)).Count<DataSetGES.Class15>() > 0)
            if (this.dataSetN.tJ_RequestForRepairDaily
                .Where(r => (r.RowState != DataRowState.Deleted && r.RowState != DataRowState.Detached))
                .Count() > 0)

            {
                //DataRow dataRow = this.dataSetGES_0.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.Class15, bool>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_6)).OrderByDescending(new Func<DataSetGES.Class15, DateTime>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_7)).First<DataSetGES.Class15>();
                DataRow dataRow = this.dataSetN.tJ_RequestForRepairDaily
                    .Where(r => (r.RowState != DataRowState.Deleted && r.RowState != DataRowState.Detached))
                    .OrderByDescending(r => r["DateEnd"])
                    .First();
                this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow["DateEnd"]);
                this.method_16(Convert.ToDateTime(dataRow["DateEnd"]));
                return;
            }
            this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
            this.method_16(this.dateTimeBeg);
        }

        private void dgvDaily_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.method_15();
            if (e.RowIndex == this.dgvDaily.Rows.Count - 1)
            {
                DateTime dateTime = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, e.RowIndex].Value);
                if (dateTime > this.dateTimePickerBeg.MaxDate)
                {
                    this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
                }
                this.dateTimePickerBeg.MinDate = dateTime;
                this.method_16(dateTime);
            }
        }

        private void dgvDaily_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DateTimePicker)
            {
                if (this.dgvDaily.CurrentCell.OwningColumn.Name == this.dateBegDataGridViewTextBoxColumn.Name)
                {
                    (e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex].Value);
                    if (this.dgvDaily.CurrentCell.RowIndex == 0)
                    {
                        (e.Control as DateTimePicker).MinDate = this.dateTimeBeg;
                    }
                    if (this.dgvDaily.CurrentCell.RowIndex > 0)
                    {
                        (e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex - 1].Value);
                    }
                }
                if (this.dgvDaily.CurrentCell.OwningColumn.Name == this.dateEndDataGridViewTextBoxColumn.Name)
                {
                    (e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex].Value);
                    if (this.dgvDaily.CurrentCell.RowIndex == this.dgvDaily.Rows.Count - 1)
                    {
                        (e.Control as DateTimePicker).MaxDate = new DateTime(9998, 12, 31);
                    }
                    if (this.dgvDaily.CurrentCell.RowIndex < this.dgvDaily.Rows.Count - 1)
                    {
                        (e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex + 1].Value);
                    }
                }
            }
        }

        private void dgvDaily_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DayOfWeek dayOfWeek = DayOfWeek.Monday;
                if (this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, e.RowIndex].Value != null)
                {
                    dayOfWeek = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, e.RowIndex].Value).DayOfWeek;
                }
                DayOfWeek dayOfWeek2 = DayOfWeek.Monday;
                if (this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, e.RowIndex].Value != null)
                {
                    dayOfWeek2 = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, e.RowIndex].Value).DayOfWeek;
                }
                if ((dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Saturday) && this.dgvDaily.Columns[e.ColumnIndex] == this.dateBegDataGridViewTextBoxColumn)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if ((dayOfWeek2 == DayOfWeek.Sunday || dayOfWeek2 == DayOfWeek.Saturday) && this.dgvDaily.Columns[e.ColumnIndex] == this.dateEndDataGridViewTextBoxColumn)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void buttonDaily_Click(object sender, EventArgs e)
        {
            bool flag = false;
            this.dgvDaily.RowsAdded -= this.dgvDaily_RowsAdded;
            if (this.checkBoxDaily.Checked)
            {
                for (int i = 0; i <= (this.dateTimePickerEnd.Value - this.dateTimePickerBeg.Value).Days; i++)
                {
                    if (this.checkBoxWeekEnd.Checked || (this.dateTimePickerBeg.Value.AddDays((double)i).DayOfWeek != DayOfWeek.Saturday && this.dateTimePickerBeg.Value.AddDays((double)i).DayOfWeek != DayOfWeek.Sunday))
                    {
                        try
                        {
                            DataRow dataRow = this.dataSetN.tJ_RequestForRepairDaily.NewRow();
                            dataRow["idRequest"] = this.IdRequest;
                            dataRow["dateBeg"] = this.dateTimePickerBeg.Value.AddDays((double)i);
                            dataRow["dateEnd"] = this.dateTimePickerBeg.Value.AddDays((double)i).Date + this.dateTimePickerEnd.Value.TimeOfDay;
                            this.dataSetN.tJ_RequestForRepairDaily.Rows.Add(dataRow);
                            flag = true;
                            this.groupBoxDaily.ForeColor = SystemColors.ControlText;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    DataRow dataRow2 = this.dataSetN.tJ_RequestForRepairDaily.NewRow();
                    dataRow2["idRequest"] = this.IdRequest;
                    dataRow2["dateBeg"] = this.dateTimePickerBeg.Value;
                    dataRow2["dateEnd"] = this.dateTimePickerEnd.Value;
                    this.dataSetN.tJ_RequestForRepairDaily.Rows.Add(dataRow2);
                    flag = true;
                    this.groupBoxDaily.ForeColor = SystemColors.ControlText;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            this.dgvDaily.RowsAdded += this.dgvDaily_RowsAdded;
            if (flag)
            {
                //DataRow dataRow3 = this.dataSetGES_0.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.Class15, bool>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_8)).OrderByDescending(new Func<DataSetGES.Class15, DateTime>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_9)).First<DataSetGES.Class15>();
                DataRow dataRow3 = this.dataSetN.tJ_RequestForRepairDaily
                    .Where(r => (r.RowState != DataRowState.Deleted && r.RowState != DataRowState.Detached))
                    .OrderByDescending(r => r["DateEnd"])
                    .First();
                if (Convert.ToDateTime(dataRow3["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
                {
                    this.dateTimePickerBeg.MaxDate = this.dateTimeEnd;
                }
                this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow3["DateEnd"]);
                this.method_15();
                this.method_16(Convert.ToDateTime(dataRow3["DateEnd"]));
            }
        }

        private void cmbIsPlanned_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbIsPlanned.SelectedIndex >= 0)
            {
                this.labelIsPlanned.ForeColor = SystemColors.ControlText;
            }
        }

        private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbWorker.SelectedIndex >= 0)
            {
                this.labelWorker.ForeColor = SystemColors.ControlText;
            }
        }
        ////private void method_17(object sender, EventArgs e)
        ////{
        ////    if (!string.IsNullOrEmpty(this.txtRequestFiled.Text))
        ////    {
        ////        this.labelRequestFiled.ForeColor = SystemColors.ControlText;
        ////    }
        ////}

        private void cmbSR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSR.SelectedIndex >= 0)
            {
                this.labelSR.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtObject_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtObject.Text))
            {
                this.labelObject.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtPurpose_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPurpose.Text))
            {
                this.labelPurpose.ForeColor = SystemColors.ControlText;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbStatus.SelectedIndex >= 0)
            {
                this.labelStatus.ForeColor = SystemColors.ControlText;
            }
        }

        private void cmbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbOrganization.SelectedIndex >= 0)
            {
                this.labelOrganization.ForeColor = SystemColors.ControlText;
            }
        }

        private void cmbPerformerOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbPerformerOrganization.SelectedIndex >= 0)
            {
                this.labelPerformer.ForeColor = SystemColors.ControlText;
            }
        }

        private void cmbGroupWorks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbGroupWorks.SelectedIndex >= 0)
            {
                this.labelGroupWork.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtRequestFiled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRequestFiled.SelectedIndex >= 0)
            {
                this.labelRequestFiled.ForeColor = SystemColors.ControlText;
            }
        }

        private void LoadTableLinkObjects()
        {
            this.tblLinkObjects.Clear();
            if (this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Count > 0)
            {
                DataView defaultView = this.dataSetN.tL_RequestForRepairSchmObjList.DefaultView;
                defaultView.Sort = "Num";
                DataTable dataTable = defaultView.ToTable();
                int num = 0;
                bool flag = false;
                List<string> list = new List<string>();
                DateTime dateTime = DateTime.Now;
                DateTime dateTime2 = DateTime.Now;
                string value = "";
                foreach (object obj in dataTable.Rows)
                {
                    DataRow dataRow = (DataRow)obj;
                    if (num == (int)Convert.ToInt16(dataRow["num"]))
                    {
                        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                        {
                            dataRow["idSchmObj"].ToString()
                        }).ToString());
                    }
                    else
                    {
                        if (list.Count > 0)
                        {
                            list.Sort();
                            DataRow dataRow2 = this.dataSet_0.Tables[this.tblLinkObjects.TableName].NewRow();
                            dataRow2["Objects"] = "";
                            foreach (string arg in list)
                            {
                                DataRow dataRow3 = dataRow2;
                                dataRow3["Objects"] = dataRow3["Objects"] + arg + "\n";
                            }
                            dataRow2["Objects"] = ((string)dataRow2["Objects"]).Remove(dataRow2["Objects"].ToString().Length - 1);
                            dataRow2["DateBeg"] = dateTime;
                            dataRow2["DateEnd"] = dateTime2;
                            dataRow2["Duration"] = value;
                            dataRow2["disabled"] = flag;
                            dataRow2["Num"] = num;
                            this.dataSet_0.Tables[this.tblLinkObjects.TableName].Rows.Add(dataRow2);
                        }
                        list = new List<string>();
                        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                        {
                            dataRow["idSchmObj"].ToString()
                        }).ToString());
                        dateTime = Convert.ToDateTime(dataRow["DateBeg"]);
                        dateTime2 = Convert.ToDateTime(dataRow["DateEnd"]);
                        value = dataRow["Duration"].ToString();
                        num = (int)Convert.ToInt16(dataRow["Num"]);
                        flag = false;
                    }
                    if (!flag)
                    {
                        flag = this.isCountRowsForRepairDailySchmObj(Convert.ToInt32(dataRow["idSchmObj"]));
                    }
                }
                if (list.Count > 0)
                {
                    list.Sort();
                    DataRow dataRow4 = this.dataSet_0.Tables[this.tblLinkObjects.TableName].NewRow();
                    dataRow4["Objects"] = "";
                    foreach (string arg2 in list)
                    {
                        DataRow dataRow3 = dataRow4;
                        dataRow3["Objects"] = dataRow3["Objects"] + arg2 + "\n";
                    }
                    dataRow4["Objects"] = ((string)dataRow4["Objects"]).Remove(dataRow4["Objects"].ToString().Length - 1);
                    dataRow4["DateBeg"] = dateTime;
                    dataRow4["DateEnd"] = dateTime2;
                    dataRow4["Duration"] = value;
                    dataRow4["disabled"] = flag;
                    dataRow4["Num"] = num;
                    this.dataSet_0.Tables[this.tblLinkObjects.TableName].Rows.Add(dataRow4);
                }
                if (this.dataSet_0.Tables[this.tblLinkObjects.TableName].Rows.Count > 0)
                {
                    this.toolBtnViewSChmObj.Enabled = true;
                    return;
                }
                this.toolBtnViewSChmObj.Enabled = false;
            }
        }
        /// <summary>
        /// проверка отключений по конкретному объекту схемы
        /// </summary>
        /// <param name="idSchmObj"></param>
        /// <returns></returns>
        private bool isCountRowsForRepairDailySchmObj(int idSchmObj)
        {
            return this.IdRequest != -1 && new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0} and idSchmObj = {1}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", this.IdRequest, idSchmObj)).Rows.Count > 0;
        }

        private void LoadTableSchmObjects()
        {
            base.SelectSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.IdRequest.ToString());
            this.LoadTableLinkObjects();
        }

        private void toolBtnLinkSchmObj_Click(object sender, EventArgs e)
        {
            FormLinkRequestAndSchm form = new FormLinkRequestAndSchm();
            form.SqlSettings = this.SqlSettings;
            if (form.ShowDialog() == DialogResult.OK)
            {
                int num = 1;
                if (this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Count > 0)
                {
                    //num = (int)(this.dataSetGES_0.tL_RequestForRepairSchmObjList.Where(new Func<DataSetGES.Class13, bool>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_10)).Max(new Func<DataSetGES.Class13, short>(FormJournalRequestForRepairAddEdit.C_1.C_9.method_11)) + 1);
                    num = (int)(this.dataSetN.tL_RequestForRepairSchmObjList
                        .Where(r => r.RowState != DataRowState.Deleted)
                        .Max(r => r.Num) + 1);
                }
                this.dictionaryIdSchmObj = form.GetLinkObjects();
                foreach (int num2 in this.dictionaryIdSchmObj.Keys)
                {
                    DataRow dataRow = this.dataSetN.tL_RequestForRepairSchmObjList.NewRow();
                    dataRow["idRequest"] = this.IdRequest;
                    dataRow["idSchmObj"] = num2;
                    dataRow["DAteBeg"] = form.get_DateBeg();
                    dataRow["DAteEnd"] = form.get_DateEnd();
                    dataRow["duration"] = form.Duration;
                    dataRow["num"] = num;
                    this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Add(dataRow);
                }
                this.LoadTableLinkObjects();
                this.method_23(this.dictionaryIdSchmObj.Keys.ToList<int>());
            }
        }

        private void dgvLinkObjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolBtnLinkSchmObjEdit_Click(sender, e);
        }

        private void dgvLinkObjects_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && Convert.ToBoolean(this.dgvLinkObjects[this.disabledDgvColumn.Name, e.RowIndex].Value))
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void toolBtnLinkSchmObjEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvLinkObjects.CurrentRow == null)
            {
                return;
            }
            if (Convert.ToBoolean(this.dgvLinkObjects.CurrentRow.Cells[this.disabledDgvColumn.Name].Value))
            {
                MessageBox.Show("Редактирование невозможно. Существует согласованный подчиненный документ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataRow[] array = this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + this.dgvLinkObjects.CurrentRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString());
            this.dictionaryIdSchmObj.Clear();
            if (array.Length != 0)
            {
                FormLinkRequestAndSchm form = new FormLinkRequestAndSchm();
                form.SqlSettings = this.SqlSettings;
                form.set_DateBeg(Convert.ToDateTime(array[0]["dateBeg"]));
                form.set_DateEnd(Convert.ToDateTime(array[0]["dateEnd"]));
                form.Duration = array[0]["Duration"].ToString();
                form.set_Num(Convert.ToInt16(array[0]["Num"]));
                foreach (DataRow dataRow in array)
                {
                    this.dictionaryIdSchmObj.Add(Convert.ToInt32(dataRow["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                        dataRow["idSchmObj"].ToString()
                    }).ToString());
                }
                form.set_LinkObjects(this.dictionaryIdSchmObj);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.dictionaryIdSchmObj = form.GetLinkObjects();
                    foreach (DataRow dataRow2 in array)
                    {
                        if (this.dictionaryIdSchmObj.ContainsKey(Convert.ToInt32(dataRow2["idSchmObj"])))
                        {
                            dataRow2["DAteBeg"] = form.get_DateBeg();
                            dataRow2["DAteEnd"] = form.get_DateEnd();
                            dataRow2["duration"] = form.Duration;
                            this.dictionaryIdSchmObj.Remove(Convert.ToInt32(dataRow2["idSchmObj"]));
                        }
                        else
                        {
                            dataRow2.Delete();
                        }
                    }
                    foreach (int num in this.dictionaryIdSchmObj.Keys)
                    {
                        DataRow dataRow3 = this.dataSetN.tL_RequestForRepairSchmObjList.NewRow();
                        dataRow3["idRequest"] = this.IdRequest;
                        dataRow3["idSchmObj"] = num;
                        dataRow3["DAteBeg"] = form.get_DateBeg();
                        dataRow3["DAteEnd"] = form.get_DateEnd();
                        dataRow3["duration"] = form.Duration;
                        dataRow3["num"] = form.get_Num();
                        this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Add(dataRow3);
                    }
                    this.LoadTableLinkObjects();
                }
            }
        }

        private void toolBtnDelSchmObj_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.dgvLinkObjects.SelectedRows)
            {
                DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                if (Convert.ToBoolean(dataGridViewRow.Cells[this.disabledDgvColumn.Name].Value))
                {
                    MessageBox.Show("Удаление невозможно. Существует согласованный подчиненный документ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                DataRow[] array = this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + dataGridViewRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString());
                for (int i = 0; i < array.Length; i++)
                {
                    array[i].Delete();
                }
            }
            this.LoadTableLinkObjects();
        }

        private void toolBtnViewSChmObj_Click(object sender, EventArgs e)
        {
            this.dictionaryIdSchmObj.Clear();
            foreach (object obj in this.dgvLinkObjects.SelectedRows)
            {
                DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                foreach (DataRow dataRow in this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + dataGridViewRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString()))
                {
                    if (!this.dictionaryIdSchmObj.ContainsKey(Convert.ToInt32(dataRow["idSchmObj"])))
                    {
                        this.dictionaryIdSchmObj.Add(Convert.ToInt32(dataRow["idSchmObj"]), "");
                    }
                }
            }
            GoToSchemaEventArgs e2 = new GoToSchemaEventArgs(this.dictionaryIdSchmObj.Keys.ToList<int>());
            this.OnGoToSchema(e2);
        }
        /// <summary>
        /// обновление таблицы отключенныхобъектов
        /// </summary>
        private void UpdateSchmObjList()
        {
            //foreach (DataRow dataRow in this.dataSetN.tL_RequestForRepairSchmObjList)
            //{
            //    if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
            //    {
            //        dataRow["idRequest"] = this.IdRequest;
            //        dataRow.EndEdit();
            //    }
            //}
            //base.InsertSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            //base.UpdateSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            //base.DeleteSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            //this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
            this.DeleteSqlDataWhere(this.dataSetN.tL_RequestForRepairSchmObjList, string.Format(" WHERE idRequest = {0}", this.IdRequest.ToString()));

            foreach (DataRow dataRow in this.dataSetN.tL_RequestForRepairSchmObjList)
            {
                if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
                {
                    dataRow["idRequest"] = this.dataSetN;
                    dataRow.EndEdit();
                }
                this.InsertSqlDataOneRow(dataRow);
            }

            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void checkBoxAgreed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAgreed.Checked)
            {
                if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0 && this.dateTimePickerDateAgreed.Value == null)
                {
                    this.dateTimePickerDateAgreed.Value = DateTime.Now;
                    return;
                }
            }
            else if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0 && this.dateTimePickerDateAgreed.Value != null)
            {
                this.dateTimePickerDateAgreed.Value = null;
                this.cmbStatus.SelectedIndex = -1;
            }
        }

        private void checkBoxAgreed_CheckStateChanged(object sender, EventArgs e)
        {
            this.EnableIsCrash();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void toolBtnAddDoc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    {
                        DataRow dataRow = this.dataSetN.tJ_RequestForRepairDoc.NewRow();
                        dataRow["idRequest"] = this.IdRequest;
                        dataRow["Document"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
                        dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
                        this.dataSetN.tJ_RequestForRepairDoc.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void toolBtnDelDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                this.dgvDocs.Rows.Remove(this.dgvDocs.CurrentRow);
                return;
            }
            MessageBox.Show("Не выбрано ни одного файла");
        }

        private void toolBtnViewDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow == null)
            {
                return;
            }
            int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
            byte[] array = (byte[])this.dataSetN.tJ_RequestForRepairDoc.FindByid(num)["Document"];
            string text = Path.GetTempFileName();
            text = Path.ChangeExtension(text, Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.FindByid(num)["FileName"].ToString()));
            FileStream fileStream = File.Create(text);
            fileStream.Write(array, 0, array.Length);
            fileStream.Close();
            new Process
            {
                StartInfo =
                {
                    FileName = text,
                    UseShellExecute = true
                }
            }.Start();
        }

        private void toolBtnSaveDoc_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                string text = this.dgvDocs.CurrentRow.Cells[this.fileNameDataGridViewTextBoxColumn.Name].Value.ToString();
                string extension = Path.GetExtension(text);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
                saveFileDialog.FileName = text;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] array = (byte[])this.dataSetN.tJ_RequestForRepairDoc.FindByid(num)["Document"];
                    FileStream fileStream = File.Create(saveFileDialog.FileName);
                    fileStream.Write(array, 0, array.Length);
                    fileStream.Close();
                    MessageBox.Show("Файл успешно сохранен", "Сохранение");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvDocs_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (this.dgvDocs.RowCount > 0 && this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value != null && e.ColumnIndex == this.dgvDocs.Columns[this.ColumnImage.Name].Index)
            {
                // Icon icon = Class5.smethod_0(this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value.ToString());
                Icon icon = FileInfo.IconOfFile(this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value.ToString());
                e.Value = icon.ToBitmap();
            }
        }

        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDocs.CurrentRow == null)
            {
                return;
            }
            int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
            if (e.ColumnIndex == this.dgvDocs.Columns[this.fileNameDataGridViewTextBoxColumn.Name].Index)
            {
                byte[] array = (byte[])this.dataSetN.tJ_RequestForRepairDoc.FindByid(num)["Document"];
                string text = Path.GetTempFileName();
                text = Path.ChangeExtension(text, Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.FindByid(num)["FileName"].ToString()));
                FileStream fileStream = File.Create(text);
                fileStream.Write(array, 0, array.Length);
                fileStream.Close();
                new Process
                {
                    StartInfo =
                    {
                        FileName = text,
                        UseShellExecute = true
                    }
                }.Start();
            }
        }

        private void UpdateRepairDoc()
        {
            foreach (DataRow dataRow in this.dataSetN.tJ_RequestForRepairDoc)
            {
                if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
                {
                    dataRow["idRequest"] = this.IdRequest;
                    dataRow.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count <= 0)
            {
                return;
            }
            DataTable dataTable = this.dataSetN.tJ_RequestForRepair.Copy();
            DataRow dataRow = dataTable.NewRow();
            dataRow.ItemArray = dataTable.Rows[0].ItemArray;
            this.dataSetN.tJ_RequestForRepair.Clear();
            this.dataSetN.tJ_RequestForRepairDoc.Clear();
            this.dataSetN.tJ_RequestForRepairDaily.Clear();
            DataRow dataRow2 = this.dataSetN.tJ_RequestForRepair.NewRow();
            dataRow2["num"] = 0;
            dataRow2["dateCreate"] = DateTime.Now;
            if (dataRow["idWorker"] != DBNull.Value)
            {
                dataRow2["idWorker"] = dataRow["idWorker"];
            }
            dataRow2["reguestFiled"] = dataRow["reguestFiled"];
            if (dataRow["idSR"] == DBNull.Value)
            {
                dataRow2["idSR"] = -1;
            }
            else
            {
                dataRow2["idSR"] = dataRow["idSR"];
            }
            dataRow2["idRegion"] = dataRow["idRegion"];
            dataRow2["schmObj"] = dataRow["schmObj"];
            dataRow2["Purpose"] = dataRow["Purpose"];
            if (dataRow["IsPlanned"] == DBNull.Value)
            {
                dataRow2["IsPlanned"] = -1;
            }
            else
            {
                dataRow2["IsPlanned"] = dataRow["IsPlanned"];
            }
            dataRow2["Crash"] = dataRow["Crash"];
            dataRow2["typeDisable"] = dataRow["typeDisable"];
            dataRow2["agreed"] = false;
            dataRow2["iddivision"] = dataRow["iddivision"];
            dataRow2["deleted"] = false;
            dataRow2["Organization"] = dataRow["organization"];
            dataRow2["performerOrganization"] = dataRow["performerorganization"];
            dataRow2["groupworks"] = dataRow["groupworks"];
            DataTable dataTable2 = this.GetTableUser();
            base.SelectSqlData(dataTable2, true, " where [Login] = SYSTEM_USER ", null, false, 0);
            if (dataTable2.Rows.Count > 0)
            {
                dataRow2["idUserCreate"] = dataTable2.Rows[0]["iduser"];
                if (dataTable2.Rows[0]["idWorker"] != DBNull.Value)
                {
                    dataRow2["IdWorker"] = dataTable2.Rows[0]["idWorker"];
                }
            }
            if (dataRow2["idWorker"] == DBNull.Value)
            {
                dataRow2["idWorker"] = -1;
            }
            this.IdRequest = -1;
            this.eActionRequestRepair = eActionRequestRepair.Add;
            this.dataSetN.tJ_RequestForRepair.Rows.Add(dataRow2);
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(newChild);
            XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
            xmlDocument.AppendChild(xmlNode);
            XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("X");
            xmlAttribute.Value = base.Location.X.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("Y");
            xmlAttribute.Value = base.Location.Y.ToString();
            xmlNode.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("SR");
            if (this.eActionRequestRepair == eActionRequestRepair.Add && this.cmbSR.SelectedValue != null)
            {
                xmlAttribute.Value = this.cmbSR.SelectedValue.ToString();
            }
            else
            {
                xmlAttribute.Value = this.idSR.ToString();
            }
            xmlNode.Attributes.Append(xmlAttribute);
            return xmlDocument;
        }

        protected override void ApplyConfig(XmlDocument xmlDoc)
        {
            XmlNode xmlNode = xmlDoc.SelectSingleNode(base.Name);
            if (xmlNode != null)
            {
                XmlAttribute xmlAttribute = xmlNode.Attributes["X"];
                int? num = null;
                int? num2 = null;
                if (xmlAttribute != null)
                {
                    num = new int?(Convert.ToInt32(xmlAttribute.Value));
                }
                xmlAttribute = xmlNode.Attributes["Y"];
                if (xmlAttribute != null)
                {
                    num2 = new int?(Convert.ToInt32(xmlAttribute.Value));
                }
                if (num != null && num2 != null)
                {
                    if (num < 0)
                    {
                        num = new int?(0);
                    }
                    if (num2 < 0)
                    {
                        num2 = new int?(0);
                    }
                    base.Location = new Point(num.Value, num2.Value);
                }
                xmlAttribute = xmlNode.Attributes["SR"];
                if (xmlAttribute != null)
                {
                    this.idSR = Convert.ToInt32(xmlAttribute.Value);
                }
            }
        }

        private void method_23(List<int> list_0)
        {
            this.splitContainer1.Panel2.Enabled = false;
            this.toolStripScheme.Enabled = false;
            this.backgroundWorker.RunWorkerAsync(list_0);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FormJournalRequestForRepairAddEdit.Class7 @class = new FormJournalRequestForRepairAddEdit.Class7();
            if (this.electricModel == null)
            {
                this.electricModel = new ElectricModel();
                this.electricModel.SqlSettings = this.SqlSettings;
                this.electricModel.LoadSchema(false);
            }
            if (this.tblKladrStreet == null)
            {
                this.tblKladrStreet = new DataTable("tr_kladrstreet");
                base.SelectSqlData(this.tblKladrStreet, true, "where deleted = 0", null, false, 0);
            }
            if (this.tblKladrObj == null)
            {
                this.tblKladrObj = new DataTable("tr_kladrObj");
                base.SelectSqlData(this.tblKladrObj, true, "where deleted = 0", null, false, 0);
            }
            if (this.tblKladrObjAddress == null)
            {
                this.tblKladrObjAddress = new DataTable();
                this.tblKladrObjAddress.Columns.Add("KladrObjId", typeof(int));
                this.tblKladrObjAddress.Columns.Add("idstreet", typeof(int));
                this.tblKladrObjAddress.Columns.Add("house", typeof(string));
            }
            else
            {
                this.tblKladrObjAddress.Clear();
            }
            @class.list_0 = (List<int>)e.Argument;
            IEnumerable<ElectricObject> enumerable = this.electricModel.Objects.Where(new Func<ElectricObject, bool>(@class.method_0));

            //var enumerable = electricModel.Objects.Where(r => ((List<int>)e.Argument).Contains(r.Id));

            if (enumerable.Count<ElectricObject>() > 0)
            {
                List<ElectricObject> list = new List<ElectricObject>();
                foreach (ElectricObject obj in enumerable)
                {
                    list.AddRange(this.electricModel.PoweringReportForDrawObject(obj, true, true));
                }
                if (list.Count > 0)
                {
                    string text = "";
                    foreach (ElectricObject electricObject in list)
                    {
                        if (string.IsNullOrEmpty(text))
                        {
                            text = electricObject.Id.ToString();
                        }
                        else
                        {
                            text = text + "," + electricObject.Id.ToString();
                        }
                    }
                    using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                    {
                        try
                        {
                            sqlConnection.Open();
                            new SqlDataAdapter(" select o.id as KladrObjId, l.id as idStreet, house  from vl_SchmAbnFull l   left join tr_kladrStreet s on l.id = s.id  left join tr_kladrObj o on o.id = s.kladrobjid  where abnActive = 1 and objactive = 1 and idSchmObj in (" + text + ")  group by o.id, l.id, house ", sqlConnection)
                            {
                                SelectCommand =
                                {
                                    CommandTimeout = 0
                                }
                            }.Fill(this.tblKladrObjAddress);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.Source);
                        }
                    }
                }
            }
        }

        private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                foreach (object obj in this.tblKladrObjAddress.Rows)
                {
                    DataRow dataRow = (DataRow)obj;
                    if (dataRow["idstreet"] != DBNull.Value && dataRow["house"] != DBNull.Value && this.dataSetN.tJ_RequestForRepairAddress.Select(string.Concat(new string[]
                    {
                        "idKladrStreet = ",
                        dataRow["idStreet"].ToString(),
                        " and house = '",
                        dataRow["house"].ToString(),
                        "'"
                    })).Length == 0)
                    {
                        DataRow dataRow2 = this.dataSetN.tJ_RequestForRepairAddress.NewRow();
                        dataRow2["idRequest"] = this.IdRequest;
                        dataRow2["idKladrObj"] = dataRow["kladrObjId"];
                        dataRow2["idKladrStreet"] = dataRow["idstreet"];
                        dataRow2["house"] = dataRow["house"];
                        this.dataSetN.tJ_RequestForRepairAddress.Rows.Add(dataRow2);
                    }
                }
                this.FillTableAddress();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            this.splitContainer1.Panel2.Enabled = true;
            this.toolStripScheme.Enabled = true;
        }

        private void FillTableAddress()
        {
            this.tblAddress.Clear();
            if (this.tblKladrStreet == null)
            {
                this.tblKladrStreet = new DataTable("tr_kladrstreet");
                base.SelectSqlData(this.tblKladrStreet, true, "where deleted = 0", null, false, 0);
            }
            if (this.tblKladrObj == null)
            {
                this.tblKladrObj = new DataTable("tr_kladrObj");
                base.SelectSqlData(this.tblKladrObj, true, "where deleted = 0", null, false, 0);
            }
            foreach (DataRow dataRow in this.dataSetN.tJ_RequestForRepairAddress)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    DataRow dataRow2 = this.tblAddress.NewRow();
                    dataRow2["id"] = dataRow["id"];
                    dataRow2["idKladrObj"] = dataRow["idKladrObj"];
                    dataRow2["idKladrStreet"] = dataRow["idKladrstreet"];
                    dataRow2["house"] = dataRow["house"];
                    DataRow[] array = this.tblKladrObj.Select("id = " + dataRow["idKladrObj"].ToString());
                    if (array.Length != 0)
                    {
                        dataRow2["City"] = array[0]["name"].ToString() + " " + array[0]["socr"].ToString();
                    }
                    DataRow[] array2 = this.tblKladrStreet.Select("id = " + dataRow["idKladrStreet"].ToString());
                    if (array2.Length != 0)
                    {
                        dataRow2["Street"] = array2[0]["name"].ToString() + " " + array2[0]["socr"].ToString();
                    }
                    this.tblAddress.Rows.Add(dataRow2);
                }
            }
            List<int> list = new List<int>();
            foreach (object obj in this.tblAddress.Rows)
            {
                DataRow dataRow3 = (DataRow)obj;
                if (!list.Contains(Convert.ToInt32(dataRow3["idKladrStreet"])))
                {
                    list.Add(Convert.ToInt32(dataRow3["idKladrStreet"]));
                }
            }
            string text = "";
            foreach (int num in list)
            {
                DataRow[] array3 = this.tblAddress.Select("idkladrstreet = " + num.ToString());
                if (array3.Count<DataRow>() > 0)
                {
                    string text2 = array3[0]["City"].ToString() + ", " + array3[0]["Street"].ToString() + ", д. ";
                    foreach (DataRow dataRow4 in array3)
                    {
                        text2 = text2 + dataRow4["House"].ToString() + ", ";
                    }
                    text2 = text2.Remove(text2.Length - 2);
                    text = text + text2 + "\r\n";
                }
            }
            this.txtAdress.Text = text;
            if (!string.IsNullOrEmpty(this.txtAdress.Text))
            {
                this.labelAddress.ForeColor = SystemColors.ControlText;
            }
        }

        private void toolBtnAddAddress_Click(object sender, EventArgs e)
        {
            FormRequestForRepairAddAddress form = new FormRequestForRepairAddAddress();
            form.SqlSettings = this.SqlSettings;
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (object row in form.tbl.Rows)
                {
                    DataRow dataRow = (DataRow)row;
                    if (this.dataSetN.tJ_RequestForRepairAddress.Select(string.Concat(new string[]
                    {
                        "idKladrStreet = ",
                        dataRow["idStreet"].ToString(),
                        " and house = '",
                        dataRow["house"].ToString(),
                        "'"
                    })).Length == 0)
                    {
                        DataRow dataRow2 = this.dataSetN.tJ_RequestForRepairAddress.NewRow();
                        dataRow2["idRequest"] = this.IdRequest;
                        dataRow2["idKladrObj"] = dataRow["idKladrObj"];
                        dataRow2["idKladrStreet"] = dataRow["idstreet"];
                        dataRow2["house"] = dataRow["house"];
                        this.dataSetN.tJ_RequestForRepairAddress.Rows.Add(dataRow2);
                    }
                }
                this.FillTableAddress();
            }
        }

        private void toolBtnDelAddress_Click(object sender, EventArgs e)
        {
            if (this.dgvAddress.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить выбранные строки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (object obj in this.dgvAddress.SelectedRows)
                {
                    int num = Convert.ToInt32(((DataGridViewRow)obj).Cells[this.idAddressDgvColumn.Name].Value);
                    DataRow[] array = this.dataSetN.tJ_RequestForRepairAddress.Select("id = " + num.ToString());
                    if (array.Length != 0)
                    {
                        array[0].Delete();
                    }
                }
                this.FillTableAddress();
            }
        }

        private void UpdateRepairAddress()
        {
            foreach (DataRow dataRow in this.dataSetN.tJ_RequestForRepairAddress)
            {
                if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
                {
                    dataRow["idRequest"] = this.IdRequest;
                    dataRow.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairAddress);
            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairAddress);
            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairAddress);
            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void EnableIsCrash()
        {
            if (!this.isCrash)
            {
                if (this.eActionRequestRepair != eActionRequestRepair.Read)
                {
                    if (this.dataSetN.tJ_RequestForRepair.Rows.Count <= 0)
                    {
                        this.chkSendToSite.Enabled = false;
                        return;
                    }
                    if (this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"] == DBNull.Value)
                    {
                        this.chkSendToSite.Enabled = false;
                        return;
                    }
                    if (!Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"]))
                    {
                        this.chkSendToSite.Enabled = false;
                        return;
                    }
                    if (this.dataSetN.tJ_RequestForRepair.Rows[0].RowState != DataRowState.Modified)
                    {
                        if (this.dataSetN.tJ_RequestForRepair.Rows[0].RowState != DataRowState.Unchanged)
                        {
                            this.chkSendToSite.Enabled = true;
                            return;
                        }
                    }
                    if (this.dataSetN.tJ_RequestForRepair.Rows[0]["SendSite", DataRowVersion.Original] != DBNull.Value && Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["SendSite", DataRowVersion.Original]))
                    {
                        this.chkSendToSite.Enabled = false;
                        return;
                    }
                    this.chkSendToSite.Enabled = true;
                    return;
                }
            }
            this.chkSendToSite.Enabled = false;
        }
        /// <summary>
        /// отправка заявок на сайт
        /// </summary>
        private void SendRequestToSite()
        {
            if (this.isCrash)
            {
                try
                {
                    UpLoadCrashToSite.CreateSettingsConnectFTP(this.SqlSettings);
                    UpLoadCrashToSite.CreateHTMLCrash_2(this.SqlSettings, UpLoadCrashToSite.GetFullFileName(), DateTime.Now);
                    UpLoadCrashToSite.StartProcessUpload();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                    //return;
                }
            }
            else
            {
                try
                {
                    UpLoadPlanToSite.CreateSettingsConnectFTP(this.SqlSettings);
                    UpLoadPlanToSite.CreateHTMLPlan(this.SqlSettings, UpLoadPlanToSite.GetFullFileName(), DateTime.Now.Date, DateTime.Now.Date.AddDays(8.0).AddMilliseconds(-1.0));
                    UpLoadPlanToSite.StartProcessUpload();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Отправка на сайт", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void toolBtnSettingsFTP_Click(object sender, EventArgs e)
        {
            new RequestsClient.Forms.JournalRequestForRepair.FormSettingsSender
            {
                SqlSettings = this.SqlSettings,
                MdiParent = base.MdiParent
            }.Show();
        }
        /// <summary>
        /// список типа заявки (ВН или НН)
        /// </summary>
        private void LoadTypeDamage()
        {
            if (this.IdRequest == -1)
            {
                return;
            }
            DataTable dataTable = new DataTable("tJ_damage");
            dataTable.Columns.Add("id", typeof(int));
            base.SelectSqlData(dataTable, true, " where idReqForRepair = " + this.IdRequest.ToString() + " and deleted = 0", null, false, 0);
            if (dataTable.Rows.Count > 0)
            {
                this.cmbTypeDamage.Enabled = false;
            }
        }
        /// <summary>
        /// проверка наличия данныъх в таблице диапозонов отключений
        /// </summary>
        private void isCountRowsForRepairDaily()
        {
            if (this.IdRequest == -1)
            {
                return;
            }
            if (new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", this.IdRequest)).Rows.Count > 0)
            {
                this.buttonDaily.Enabled = false;
                this.dgvDaily.ReadOnly = true;
                this.checkBoxAgreed.Enabled = false;
            }
        }

        private bool CreateDocumentDamage()
        {
            if (this.IdRequest == -1)
            {
                return true;
            }
            if (!this.IsCrash)
            {
                return true;
            }
            //DataSetGES dataSetGES = new DataSetGES();
            RequestForRepair.DataSets.DataSetN dataSetGES = new RequestForRepair.DataSets.DataSetN();
            base.SelectSqlData(dataSetGES, dataSetGES.tJ_Damage, true, "where idReqForRepair = " + this.IdRequest.ToString());
            base.SelectSqlData(dataSetGES, dataSetGES.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.IdRequest.ToString());
            if (this.checkBoxAgreed.Checked)
            {
                foreach (DataRow dataRow in dataSetGES.tJ_Damage)
                {
                    if (!Convert.ToBoolean(dataRow["Deleted"]) && dataSetGES.tL_RequestForRepairSchmObjList.Select("idSchmObj = " + dataRow["idSchmObj"].ToString()).Length == 0)
                    {
                        dataRow["deleted"] = true;
                        dataRow.EndEdit();
                        base.UpdateSqlData(dataSetGES, dataSetGES.tJ_Damage);
                        // DataSetGES dataSetGES2 = new DataSetGES();
                        RequestForRepair.DataSets.DataSetN dataSetGES2 = new RequestForRepair.DataSets.DataSetN();
                        base.SelectSqlData(dataSetGES2, dataSetGES2.tJ_Damage, true, "where idParent = " + dataRow["id"].ToString());
                        // foreach (DataSetN.Class19 @row in dataSetGES2.tJ_Damage)
                        foreach (RequestForRepair.DataSets.DataSetN.tJ_DamageRow row in dataSetGES2.tJ_Damage)
                        {
                            row["deleted"] = true;
                            row.EndEdit();
                            base.UpdateSqlData(dataSetGES2, dataSetGES2.tJ_Damage);
                        }
                    }
                }
                base.SelectSqlData(dataSetGES, dataSetGES.tJ_Damage, true, "where idReqForRepair = " + this.IdRequest.ToString());
                foreach (DataRow dataRow2 in dataSetGES.tL_RequestForRepairSchmObjList)
                {
                    DataRow[] array = dataSetGES.tJ_Damage.Select("idSchmObj = " + dataRow2["idSchmObj"].ToString());
                    if (array.Length != 0)
                    {
                        this.method_31(array[0]);
                    }
                    else
                    {
                        this.method_32(Convert.ToInt32(dataRow2["idSchmObj"]));
                    }
                }
            }
            return true;
        }

        private void method_31(DataRow dataRowCureent)
        {
            if (dataRowCureent["isApply"] != DBNull.Value && Convert.ToBoolean(dataRowCureent["isApply"]))
            {
                return;
            }
            //DataSetGES dataSetGES = new DataSetGES();
            RequestForRepair.DataSets.DataSetN dataSetGES = new RequestForRepair.DataSets.DataSetN();
            base.SelectSqlData(dataSetGES, dataSetGES.tJ_Damage, true, "where idParent = " + dataRowCureent["id"].ToString());
            bool flag = false;
            foreach (DataRow row in dataSetGES.tJ_Damage)
            {
                if (row["isApply"] != DBNull.Value && Convert.ToBoolean(row["isApply"]))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                return;
            }
            dataRowCureent["Deleted"] = 0;
            dataRowCureent["dateDoc"] = this.dataSetN.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
            dataRowCureent.EndEdit();
            base.UpdateSqlDataOnlyChange(dataRowCureent.Table);
            //foreach (DataSetN.Class19 row in dataSetGES.tJ_Damage)
            foreach (RequestForRepair.DataSets.DataSetN.tJ_DamageRow row in dataSetGES.tJ_Damage)
            {
                row["dateDoc"] = this.dataSetN.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
                row.EndEdit();
            }
            base.UpdateSqlData(dataSetGES.tJ_Damage);
            this.method_33(Convert.ToInt32(dataRowCureent["id"]), Convert.ToDateTime(this.dataSetN.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]), Convert.ToInt32(dataRowCureent["idSchmObj"]));
        }

        private void method_32(int idSchmObj)
        {
            //DataSetGES dataSetGES = new DataSetGES();
            RequestForRepair.DataSets.DataSetN dataSetGES = new RequestForRepair.DataSets.DataSetN();
            DataRow dataRow = dataSetGES.tJ_Damage.NewRow();
            dataRow["TypeDoc"] = this.dataSetN.tJ_RequestForRepair.Rows[0]["idTypeDamage"];
            dataRow["dateDoc"] = this.dataSetN.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
            dataRow["idSchmObj"] = idSchmObj;
            dataRow["idReqForRepair"] = this.IdRequest;
            dataSetGES.tJ_Damage.Rows.Add(dataRow);
            int idDamage = base.InsertSqlDataOneRow(dataSetGES, dataSetGES.tJ_Damage);
            if (idDamage > 0)
            {
                this.method_33(idDamage, Convert.ToDateTime(this.dataSetN.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]), idSchmObj);
            }
        }

        
        private void method_33(int idDamage, DateTime dateTime_2, int idSchmObj)
        {
            FormJournalRequestForRepairAddEdit.Class8 @class = new FormJournalRequestForRepairAddEdit.Class8();
            @class.int_0 = idSchmObj;
            int num = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["idTypeDamage"]);
            // DataSetGES dataSetGES = new DataSetGES();
            RequestForRepair.DataSets.DataSetN dataSetGES = new RequestForRepair.DataSets.DataSetN();
            if (num == 1402)
            {
                base.SelectSqlData(dataSetGES.tJ_DamageHV, true, "where idDamage = " + idDamage.ToString(), null, false, 0);
                DataRow dataRow;
                if (dataSetGES.tJ_DamageHV.Rows.Count > 0)
                {
                    dataRow = dataSetGES.tJ_DamageHV.Rows[0];
                }
                else
                {
                    dataRow = dataSetGES.tJ_DamageHV.NewRow();
                    dataRow["idDamage"] = idDamage;
                }
                ElectricModel electricModel = new ElectricModel();
                electricModel.SqlSettings = this.SqlSettings;
                electricModel.LoadSchema(dateTime_2);
                TreeNodeObj treeNodeObj_ = electricModel.PoweringReportForDrawObject(@class.int_0, true);
                List<int> list_ = new List<int>();
                FormJournalRequestForRepairAddEdit.FillTreeNodeTrans(treeNodeObj_, list_);
                DataTable dataTable = FormJournalRequestForRepairAddEdit.TableTransformerSchmObj(list_, new StaticFormData { Sqlsettings = this.SqlSettings, eForm = this });
                dataRow["countSchmObj"] = dataTable.Rows.Count;
                dataRow["countSchmObjOff"] = 0;
                dataRow["ConnectedPower"] = dataTable.Compute("Sum(Power)", "");
                dataRow["PowerA"] = dataTable.Compute("Sum(Load)", "");
                dataRow["TransOff"] = FormJournalRequestForRepairAddEdit.smethod_2(dataTable).InnerXml;
                if (dataRow["CoefFI"] == DBNull.Value)
                {
                    dataRow["CoefFI"] = 0.9;
                }
                if (dataRow["CoefSeason"] == DBNull.Value)
                {
                    dataRow["CoefSeason"] = 0.8;
                }

                IEnumerable<ElectricObject> source = electricModel.Objects.Where(new Func<ElectricObject, bool>(@class.method_0));

                //var source = electricModel.Objects.Where(r => r.Id == idSchmObj);

                List<ElectricObject> list = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
                DataTable dataTable2 = new DataTable("vl_schmAbnFull");
                dataTable2.Columns.Add("idAbn", typeof(int));
                dataTable2.Columns.Add("idAbnObj", typeof(int));
                if (list.Count > 0)
                {
                    string text = "";
                    foreach (ElectricObject electricObject in list)
                    {
                        if (string.IsNullOrEmpty(text))
                        {
                            text = electricObject.Id.ToString();
                        }
                        else
                        {
                            text = text + "," + electricObject.Id.ToString();
                        }
                    }
                    new SqlDataCommand(this.SqlSettings).SelectSqlData(dataTable2, true, " where idSchmObj in (" + text + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
                }
                else
                {
                    dataTable2.Clear();
                }
                dataRow["AbnOff"] = FormJournalRequestForRepairAddEdit.smethod_3(dataTable2).InnerXml;
                if (dataSetGES.tJ_DamageHV.Rows.Count > 0)
                {
                    dataRow.EndEdit();
                    base.UpdateSqlDataOnlyChange(dataSetGES.tJ_DamageHV);
                }
                else
                {
                    dataSetGES.tJ_DamageHV.Rows.Add(dataRow);
                    base.InsertSqlData(dataSetGES.tJ_DamageHV);
                }
            }
            if (num == 1401)
            {
                base.SelectSqlData(dataSetGES.tJ_DamageLV, true, "where idDamage = " + idDamage.ToString(), null, false, 0);
                DataRow dataRow2;
                if (dataSetGES.tJ_DamageLV.Rows.Count > 0)
                {
                    dataRow2 = dataSetGES.tJ_DamageLV.Rows[0];
                }
                else
                {
                    dataRow2 = dataSetGES.tJ_DamageLV.NewRow();
                    dataRow2["idDamage"] = idDamage;
                }
                ElectricModel electricModel2 = new ElectricModel();
                electricModel2.SqlSettings = this.SqlSettings;
                electricModel2.LoadSchema(dateTime_2);
                electricModel2.PoweringReportForDrawObject(@class.int_0, true);

                IEnumerable<ElectricObject> source2 = electricModel2.Objects.Where(new Func<ElectricObject, bool>(@class.method_1));

                //var source2 = electricModel.Objects.Where(r => r.Id == idSchmObj);

                List<ElectricObject> list2 = electricModel2.PoweringReportForDrawObject(source2.First<ElectricObject>(), true, true);
                DataTable dataTable3 = new DataTable("vl_schmAbnFull");
                dataTable3.Columns.Add("idAbn", typeof(int));
                dataTable3.Columns.Add("idAbnObj", typeof(int));
                if (list2.Count > 0)
                {
                    string text2 = "";
                    foreach (ElectricObject electricObject2 in list2)
                    {
                        if (string.IsNullOrEmpty(text2))
                        {
                            text2 = electricObject2.Id.ToString();
                        }
                        else
                        {
                            text2 = text2 + "," + electricObject2.Id.ToString();
                        }
                    }
                    new SqlDataCommand(this.SqlSettings).SelectSqlData(dataTable3, true, " where idSchmObj in (" + text2 + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
                }
                else
                {
                    dataTable3.Clear();
                }
                dataRow2["AbnOff"] = FormJournalRequestForRepairAddEdit.smethod_3(dataTable3).InnerXml;
                if (dataSetGES.tJ_DamageLV.Rows.Count > 0)
                {
                    dataRow2.EndEdit();
                    base.UpdateSqlDataOnlyChange(dataSetGES.tJ_DamageLV);
                    return;
                }
                dataSetGES.tJ_DamageLV.Rows.Add(dataRow2);
                base.InsertSqlData(dataSetGES.tJ_DamageLV);
            }
        }

        private static void FillTreeNodeTrans(TreeNodeObj treeNodeObj_0, List<int> list_0)
        {
            if (treeNodeObj_0.Tag != null && treeNodeObj_0.Tag is ElectricLine)
            {
                foreach (ElectricRelation electricRelation in ((ElectricLine)treeNodeObj_0.Tag).Relations)
                {
                    foreach (ElectricObject electricObject in electricRelation.ChildObjects)
                    {
                        if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && !list_0.Contains(electricObject.Id))
                        {
                            list_0.Add(electricObject.Id);
                        }
                    }
                }
            }
            foreach (TreeNodeObj treeNodeObj_ in treeNodeObj_0.Nodes)
            {
                FormJournalRequestForRepairAddEdit.FillTreeNodeTrans(treeNodeObj_, list_0);
            }
        }
        private static DataTable TableTransformerSchmObj(List<int> list_0, StaticFormData Me)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("idTr", typeof(int));
            dataTable.Columns.Add("TrName", typeof(string));
            dataTable.Columns.Add("idSub", typeof(int));
            dataTable.Columns.Add("Sub", typeof(string));
            dataTable.Columns.Add("Power", typeof(int));
            dataTable.Columns.Add("load", typeof(int));
            dataTable.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(Me.Sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(Me.eForm.GetType(), "FormJournalRequestForRepairAddEdit.SQL.GetTransformerSchmObj.sql"), sqlConnection))
                {
                    sqlCommand.CommandTimeout = 0;
                    DataTable dataTable2 = new DataTable();
                    new SqlDataAdapter(sqlCommand).Fill(dataTable2);
                    int Power = 0;
                    foreach (int num2 in list_0)
                    {
                        DataRow[] array = dataTable2.Select("id = " + num2.ToString());
                        if (array.Length != 0)
                        {
                            DataRow dataRow = dataTable.NewRow();
                            dataRow["idTR"] = array[0]["id"];
                            dataRow["TrNAme"] = array[0]["Наименование"];
                            dataRow["idSub"] = array[0]["idSub"];
                            dataRow["Sub"] = array[0]["Расположение"];
                            if (array[0]["Мощность"] != DBNull.Value && !string.IsNullOrEmpty(array[0]["Мощность"].ToString()))
                            {
                                dataRow["Power"] = array[0]["Мощность"];
                            }
                            if (array[0]["Мощность"] != DBNull.Value && !string.IsNullOrEmpty(array[0]["Мощность"].ToString()))
                            {
                                Power += Convert.ToInt32(array[0]["Мощность"]);
                            }
                            dataTable.Rows.Add(dataRow);
                        }
                    }
                }
                using (SqlCommand sqlCommand2 = new SqlCommand("SELECT mat.idbus, mat.[IdObjList],\r\n                        \t(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) \r\n                        \t then max([Ia]) \telse case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) \r\n                        \t\t\t\t\t                                else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) \r\n                        \t\t\t\t\t                                then max([Ic]) end end end) as I\r\n                         FROM [tJ_MeasAmperageTransf] as mat\r\n                               inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                          where  mat.deleted = 0 and m.[TypeDoc] = 1192\r\n                        \tand ((year(m.[DateD]) = \r\n                        \t\t\t(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \t\t\t\t\telse year(max(dateD)) end from tj_measurement mes \r\n                        \t\t\tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \t\t\t where mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\t\r\n                        \t\t\t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)\r\n                                      and month(m.[DateD]) between 1 and 11)\t\r\n                           or (year(m.[DateD]) =(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \telse year(max(dateD)) end\r\n                        \tfrom tj_measurement mes \r\n                        \tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \twhere mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\r\n                        \t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)-1 and month(m.[DateD])=12)) \r\n                            and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                          group by mat.idBus,  mat.[idObjList]", sqlConnection))
                {
                    sqlCommand2.CommandTimeout = 0;
                    DataTable dataTable3 = new DataTable();
                    new SqlDataAdapter(sqlCommand2).Fill(dataTable3);
                    foreach (object obj in dataTable.Rows)
                    {
                        DataRow dataRow2 = (DataRow)obj;
                        DataRow[] array2 = dataTable3.Select("idObjList = " + dataRow2["idTr"].ToString());
                        if (array2.Length != 0)
                        {
                            dataRow2["Load"] = array2[0]["I"];
                        }
                    }
                }
            }
            return dataTable;
        }

        private static XmlDocument smethod_2(DataTable dataTable_11)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode xmlNode = xmlDocument.CreateElement("TransOff");
            xmlDocument.AppendChild(xmlNode);
            foreach (object obj in dataTable_11.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                XmlNode xmlNode2 = xmlDocument.CreateElement("Row");
                xmlNode.AppendChild(xmlNode2);
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idSub");
                xmlAttribute.Value = dataRow["idSub"].ToString();
                xmlNode2.Attributes.Append(xmlAttribute);
                xmlAttribute = xmlDocument.CreateAttribute("idTr");
                xmlAttribute.Value = dataRow["idTr"].ToString();
                xmlNode2.Attributes.Append(xmlAttribute);
                xmlAttribute = xmlDocument.CreateAttribute("Power");
                xmlAttribute.Value = dataRow["Power"].ToString();
                xmlNode2.Attributes.Append(xmlAttribute);
                xmlAttribute = xmlDocument.CreateAttribute("Load");
                xmlAttribute.Value = dataRow["Load"].ToString();
                xmlNode2.Attributes.Append(xmlAttribute);
            }
            return xmlDocument;
        }

        private static XmlDocument smethod_3(DataTable datatable)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode xmlNode = xmlDocument.CreateElement("AbnOff");
            xmlDocument.AppendChild(xmlNode);
            foreach (object obj in datatable.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    XmlNode xmlNode2 = xmlDocument.CreateElement("Row");
                    xmlNode.AppendChild(xmlNode2);
                    XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idAbnObj");
                    xmlAttribute.Value = dataRow["idAbnObj"].ToString();
                    xmlNode2.Attributes.Append(xmlAttribute);
                }
            }
            return xmlDocument;
        }

        private void Get_StatusRequest()
        {
            this.dictionary_1 = new Dictionary<int, string>();
            this.dictionary_1.Add(1, "Создана");
            this.dictionary_1.Add(2, "Согласована");
            this.dictionary_1.Add(3, "Отправлена на сайт");
            this.dictionary_1.Add(104, "Зарегистрирована");
            this.dictionary_1.Add(105, "Отменена");
            this.dictionary_1.Add(106, "В работе");
            this.dictionary_1.Add(7, "Перенесено время работы");
            this.dictionary_1.Add(107, "Перенесено время работы");
            this.dictionary_1.Add(108, "Выполнена");
        }

        private void Load_RequestForRepairLog()
        {
            if (this.IdRequest > 0)
            {
                base.SelectSqlData(this.dataSetN.tJ_RequestForRepairLog, true, "where idRequest = " + this.IdRequest.ToString(), null, false, 0);
            }
        }

        private void InsertLogToTableRequestForRepairLog()
        {
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count == 0)
            {
                return;
            }
            DataTable tJ_RequestForRepairLog = this.dataSetN.tJ_RequestForRepairLog;
            DataRow[] array = tJ_RequestForRepairLog.Select("idCommand = 108");
            if (array.Length != 0)
            {
                return;
            }
            DataTable dataTableUser = new DataTable("tUser");
            DataRow dataRow = this.dataSetN.tJ_RequestForRepair.Rows[0];
            if (dataRow.RowState == DataRowState.Added)
            {
                this.AddRowTableLogUser(dataTableUser, 1);
                if (dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]))
                {
                    this.AddRowTableLogUser(dataTableUser, 2);
                }
                if (dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"]))
                {
                    this.AddRowTableLogUser(dataTableUser, 3);
                }
                if (dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]) && dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"]))
                {
                    this.AddRowTableLogUser(dataTableUser, 104);
                }
            }
            if (dataRow.RowState == DataRowState.Modified)
            {
                array = tJ_RequestForRepairLog.Select("idCommand = 2");
                if (array.Length == 0 && (dataRow["Agreed", DataRowVersion.Original] == DBNull.Value || !Convert.ToBoolean(dataRow["Agreed", DataRowVersion.Original])) && dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]))
                {
                    this.AddRowTableLogUser(dataTableUser, 2);
                }
                array = tJ_RequestForRepairLog.Select("idCommand = 3");
                if (array.Length == 0 && (dataRow["SendSite", DataRowVersion.Original] == DBNull.Value || !Convert.ToBoolean(dataRow["SendSite", DataRowVersion.Original])) && dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"]))
                {
                    this.AddRowTableLogUser(dataTableUser, 3);
                }
                array = tJ_RequestForRepairLog.Select("idCommand = 104");
                if (array.Length == 0 && (dataRow["Agreed", DataRowVersion.Original] == DBNull.Value || !Convert.ToBoolean(dataRow["Agreed", DataRowVersion.Original]) || dataRow["SendSite", DataRowVersion.Original] == DBNull.Value || !Convert.ToBoolean(dataRow["SendSite", DataRowVersion.Original])) && dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]) && dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"]))
                {
                    this.AddRowTableLogUser(dataTableUser, 104);
                }
                array = tJ_RequestForRepairLog.Select("idCommand = 104");
                if (array.Length != 0 && dataRow["Agreed", DataRowVersion.Original] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed", DataRowVersion.Original]) && dataRow["Agreed"] != DBNull.Value && !Convert.ToBoolean(dataRow["Agreed"]))
                {
                    this.AddRowTableLogUser(dataTableUser, 105);
                }
                array = tJ_RequestForRepairLog.Select("idCommand = 105");
                if (array.Length != 0)
                {
                    if (dataRow["Agreed", DataRowVersion.Original] != DBNull.Value && !Convert.ToBoolean(dataRow["Agreed", DataRowVersion.Original]) && dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]))
                    {
                        this.AddRowTableLogUser(dataTableUser, 106);
                    }
                    array = tJ_RequestForRepairLog.Select("idCommand in (105, 7)", "datelog desc, id desc");
                    if (array.Length != 0 && Convert.ToInt32(array[0]["idCommand"]) == 7)
                    {
                        this.AddRowTableLogUser(dataTableUser, 107);
                    }
                }
            }
            if (dataRow.RowState != DataRowState.Added)
            {
                bool flag = false;
                foreach (DataRow dataRow2 in this.dataSetN.tJ_RequestForRepairDaily)
                {
                    if (dataRow2.RowState != DataRowState.Added && dataRow2.RowState != DataRowState.Modified)
                    {
                        if (dataRow2.RowState != DataRowState.Deleted)
                        {
                            continue;
                        }
                    }
                    flag = true;
                    break;
                }
                if (flag)
                {
                    DataRow[] array2 = tJ_RequestForRepairLog.Select("isSite = true", "datelog desc, id desc");
                    if (array2.Length != 0)
                    {
                        if (Convert.ToInt32(array2[0]["idCommand"]) == 105)
                        {
                            this.AddRowTableLogUser(dataTableUser, 7);
                        }
                        else
                        {
                            this.AddRowTableLogUser(dataTableUser, 107);
                        }
                    }
                }
            }

            base.InsertSqlData(this.dataSetN.tJ_RequestForRepairLog);
            try
            {
                string cmdText = "declare @userlogId int\r\n                                    declare @userLog varchar(128)\r\n                                    declare @userLogName varchar(128)\r\n                                    \r\n                                    select  @userLogid = iduser, @userLog = SYSTEM_USER, @userLogname = name\r\n                                    from tuser where [login] = SYSTEM_USER\r\n                                    \r\n                                    insert into tJ_RequestForRepairLog(idRequest, datelog, userLogId, userLog, userLogName, idCommand, Command, isSite)\r\n                                    (select r.id, getdate(), @userlogId, @userLog, @userLogName, 108, 'Выполнена', 1\r\n                                      from tJ_RequestForRepair r\r\n                                    \tleft join tj_requestForRepairDaily d on d.id = (select top 1 id \r\n                                    \t\t\t\t\t\t\t\t\t\t\t\t\tfrom tJ_RequestForRepairDaily \r\n                                    \t\t\t\t\t\t\t\t\t\t\t\t\twhere idRequest = r.id\r\n                                    \t\t\t\t\t\t\t\t\t\t\t\t\torder by dateEnd desc)\r\n                                    where r.agreed = 1 and r.SendSite = 1\r\n                                    \tand not exists(select id from tJ_RequestForRepairLog where idRequest = r.id and idCommand = 108)\r\n                                    \tand d.dateEnd < getdate()\r\n                                    )";
                using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void AddRowTableLogUser(DataTable table, int int_6)
        {
            if (table.Rows.Count == 0)
            {
                base.SelectSqlData(table, true, "where [Login] = SYSTEM_USER", null, false, 0);
            }
            DataRow dataRow = this.dataSetN.tJ_RequestForRepairLog.NewRow();
            dataRow["idRequest"] = this.IdRequest;
            dataRow["dateLog"] = DateTime.Now;
            if (table.Rows.Count > 0)
            {
                dataRow["userLogId"] = table.Rows[0]["idUser"];
                dataRow["userLog"] = table.Rows[0]["Login"];
                if (table.Rows[0]["name"] != DBNull.Value)
                {
                    dataRow["userLogName"] = table.Rows[0]["name"];
                }
            }
            dataRow["idCommand"] = int_6;
            if (this.dictionary_1.ContainsKey(int_6))
            {
                dataRow["Command"] = this.dictionary_1[int_6];
            }
            if (int_6 > 100)
            {
                dataRow["isSite"] = true;
            }
            else
            {
                dataRow["isSite"] = false;
            }
            this.dataSetN.tJ_RequestForRepairLog.Rows.Add(dataRow);
        }


        [CompilerGenerated]
        private sealed class Class7
        {
            internal bool method_0(ElectricObject electricObject_0)
            {
                return this.list_0.Contains(electricObject_0.Id);
            }

            public List<int> list_0;
        }

        private sealed class Class8
        {
            internal bool method_0(ElectricObject electricObject_0)
            {
                return electricObject_0.Id == this.int_0;
            }

            internal bool method_1(ElectricObject electricObject_0)
            {
                return electricObject_0.Id == this.int_0;
            }

            public int int_0;
        }

    }
}
