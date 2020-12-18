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
using System.Windows.Forms;
using System.Xml;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using FormLbr.Classes;
using RequestForRepairN.DataSets;
using RequestsClient.Properties;
using RequestsClient.RequestService;
using SchemeModel;
using SchemeModel.Calculations;
/// <summary>
/// Документ аварийные заявки  (N2)
/// </summary>
public partial class FormJournalRequestForRepairAddEditCrash : FormBase
{
    //private const int ODS_DIVISION = 920; //ODS_DIVISION
    //private const int PL_DIVISION = 921; //PL_DIVISION
    private int IdDocument = -1;
    private int IdDivision = -1;
    private eActionRequestRepair eAction = eActionRequestRepair.Read;
    private DateTime dateTimeBeg = new DateTime(1900, 1, 1);
    private DateTime dateTimeEnd = new DateTime(9000, 1, 1);

    private int IdStatus = -1;
    /// <summary>
    /// аварийная заявка
    /// </summary>
    private bool IsCrash;
    /// <summary>
    /// согласование 
    /// </summary>
    private bool IsAgreed;
    private bool isSendRIC;

    private DataRow DataRowCurrent;

    private Dictionary<int, string> LinkObjects = new Dictionary<int, string>();
    private Dictionary<int, string> dictionaryStatusRequest;
    private int IdSR = -1;

    private ElectricModel electricModel;
    private ElectricModel eModelStateOperational;
    private List<int> listElectricBus = new List<int>();

    private DataTable tableKladrObj;
    private DataTable tablelKladrStreet;
    private DataTable tableKladrObjAddress;

    private DataTable tableRequestForRepairClient2;
    private DataTable tableRequestForRepairClient1;
    private DataTable tableRequestForRepairClient3;
    private DataTable tableRequestForRepairClient4;
    private DataTable tableRequestForRepairClient5;

    private DataTable dtSchmCable;
    /// <summary>
    /// флаг изменения данных в реквизитах (контролах на форме)
    /// </summary>
    private bool isChangedData;

    private bool GetIsCrash()
    {
        return this.IsCrash;
    }

    private void SetIsCrash(bool value)
    {
        this.IsCrash = value;
        this.EnableIsSendToSite();
    }

    public FormJournalRequestForRepairAddEditCrash()
    {
        this.InitializeComponent();
        this.CmdDataBindingsAdd();
    }

    public FormJournalRequestForRepairAddEditCrash(int idDocument, int idDivision, eActionRequestRepair action, bool isCrash = false)
    {
        this.InitializeComponent();
        this.CmdDataBindingsAdd();
        this.IdDocument = idDocument;
        this.IdDivision = idDivision;
        this.eAction = action;
        this.SetIsCrash(isCrash);
    }

    public FormJournalRequestForRepairAddEditCrash(DataRow copy)
    {
        this.InitializeComponent();
        this.CmdDataBindingsAdd();
        this.IdDocument = -1;
        this.IdDivision = Convert.ToInt32(copy["idDivision"]);
        this.eAction = eActionRequestRepair.Add;
        this.DataRowCurrent = copy;
    }

    private void CmdDataBindingsAdd()
    {
        this.cmbIsPlanned.DataBindings.Clear();
        this.cmbIsPlanned.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.IsPlanned", true, DataSourceUpdateMode.OnPropertyChanged));
        this.cmbTypeDisable.DataBindings.Clear();
        this.cmbTypeDisable.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.typeDisable", true, DataSourceUpdateMode.OnPropertyChanged));
        this.cmbSR.DataBindings.Clear();
        this.cmbSR.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idSR", true, DataSourceUpdateMode.OnPropertyChanged));
        this.cmbRegion.DataBindings.Clear();
        this.cmbRegion.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idRegion", true, DataSourceUpdateMode.OnPropertyChanged));
        this.dateTimePickerDateAgreed.DataBindings.Clear();
        this.dateTimePickerDateAgreed.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_RequestForRepair.DateAgreed", true, DataSourceUpdateMode.OnPropertyChanged));
        this.dateTimePickerFactEnd.DataBindings.Clear();
        this.dateTimePickerFactEnd.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_RequestForRepair.DateFactEnd", true, DataSourceUpdateMode.OnPropertyChanged));
        this.cmbStatus.DataBindings.Clear();
        this.cmbStatus.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.status", true, DataSourceUpdateMode.OnPropertyChanged));
        this.txtAddress.DataBindings.Clear();
        this.txtAddress.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.Address", true, DataSourceUpdateMode.OnPropertyChanged));
    }
    /// <summary>
    /// соединение с FTP сервером РИЦ
    /// </summary>
    private void ConnectGetStatusSendRICToFTPRIC()
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

    private void FillComboBoxRegion()
    {
        try
        {
            this.tableRequestForRepairClient2 = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.tableRequestForRepairClient2, true, "where type = 2 order by name", null, false, 0);

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
                    ServicePointManager.CertificatePolicy = new CertificatePolicy();
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
                    return;
                }
                catch (Exception)
                {
                    this.cmbRegion.ForeColor = Color.Red;
                    if (dataTable.Rows.Count == 0)
                    {
                        foreach (DataRow dataRow in this.tableRequestForRepairClient2.Rows)
                        {
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
                foreach (DataRow dataRow2 in this.tableRequestForRepairClient2.Rows)
                {
                    dataTable.Rows.Add(new object[]
                    {
                            dataRow2["name"],
                            dataRow2["Value"]
                    });
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

    private void cmbSR_SelectedValueChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (this.cmbSR.SelectedValue != null)
        {
            if (this.cmbSR.SelectedValue != DBNull.Value)
            {
                if (this.tableRequestForRepairClient2 != null)
                {
                    DataRow[] array = this.tableRequestForRepairClient2.Select("GESid = " + this.cmbSR.SelectedValue.ToString());
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
        this.isChangedData = true;
        if (this.cmbRegion.SelectedValue != null)
        {
            if (this.cmbRegion.SelectedValue != DBNull.Value)
            {
                if (this.tableRequestForRepairClient2 != null)
                {
                    DataRow[] array = this.tableRequestForRepairClient2.Select("Value = " + this.cmbRegion.SelectedValue.ToString());
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

    private void FillComboBoxTypeDisable()
    {
        this.tableRequestForRepairClient1 = new DataTable("tR_RequestForRepairClient");
        base.SelectSqlData(this.tableRequestForRepairClient1, true, "where type = 1 order by name", null, false, 0);

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
                ServicePointManager.CertificatePolicy = new CertificatePolicy();
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
                    foreach (DataRow dataRow in this.tableRequestForRepairClient1.Rows)
                    {
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
            foreach (DataRow dataRow2 in this.tableRequestForRepairClient1.Rows)
            {
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
        this.isChangedData = true;
        if (this.cmbTypeDisable.SelectedValue != null)
        {
            if (this.cmbTypeDisable.SelectedValue != DBNull.Value)
            {
                if (this.tableRequestForRepairClient1 != null)
                {
                    DataRow[] array = this.tableRequestForRepairClient1.Select("Value = " + this.cmbTypeDisable.SelectedValue.ToString());
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
        this.isChangedData = true;
        if (this.cmbIsPlanned.SelectedValue != null)
        {
            if (this.cmbIsPlanned.SelectedValue != DBNull.Value)
            {
                if (this.tableRequestForRepairClient1 != null)
                {
                    DataRow[] array = this.tableRequestForRepairClient1.Select("GesId = " + Convert.ToInt32(this.cmbIsPlanned.SelectedValue).ToString());
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

    private void FillComboBoxsOrganization()
    {
        this.tableRequestForRepairClient3 = new DataTable("tR_RequestForRepairClient");
        base.SelectSqlData(this.tableRequestForRepairClient3, true, "where type = 3 order by name", null, false, 0);

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
                ServicePointManager.CertificatePolicy = new CertificatePolicy();
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
                    foreach (DataRow dataRow in this.tableRequestForRepairClient3.Rows)
                    {
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
            foreach (DataRow dataRow2 in this.tableRequestForRepairClient3.Rows)
            {
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

    private void FillComboBoxGroupWorks()
    {
        this.tableRequestForRepairClient4 = new DataTable("tR_RequestForRepairClient");
        base.SelectSqlData(this.tableRequestForRepairClient4, true, "where type = 4 order by name", null, false, 0);
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
                ServicePointManager.CertificatePolicy = new CertificatePolicy();
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
                    foreach (DataRow dataRow in this.tableRequestForRepairClient4.Rows)
                    {
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
            foreach (DataRow dataRow2 in this.tableRequestForRepairClient4.Rows)
            {
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
        this.tableRequestForRepairClient5 = new DataTable("tR_RequestForRepairClient");
        base.SelectSqlData(this.tableRequestForRepairClient5, true, "where type = 5 order by name", null, false, 0);
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
                ServicePointManager.CertificatePolicy = new CertificatePolicy();
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
                    foreach (DataRow dataRow in this.tableRequestForRepairClient5.Rows)
                    {
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
            foreach (DataRow dataRow2 in this.tableRequestForRepairClient5.Rows)
            {
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
        //this.dgvAbn.DataSource = this.bsSchmAbnFull;
        //
        this.ConnectGetStatusSendRICToFTPRIC();
        this.GetStatusRequest();
        WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
        this.txtAddress.ReadOnly = false;
        this.dateTimePickerBeg.Value = DateTime.Now.Date.AddHours(8.0);
        this.dateTimePickerEnd.Value = DateTime.Now.Date.AddHours(17.0);
        this.FillComboBoxs();
        this.FillComboBoxRegion();
        this.FillComboBoxTypeDisable();
        this.FillComboBoxsOrganization();
        this.FillComboBoxGroupWorks();
        this.FillComboBoxStatus();
        this.FillDataSourceTypeAbn();
        base.LoadFormConfig(null);
        switch (this.eAction)
        {
            case eActionRequestRepair.Add:
                if (this.DataRowCurrent != null)
                {
                    DataRow dataRow = this.dataSetDamage.tJ_RequestForRepair.NewRow();
                    dataRow["num"] = 0;
                    dataRow["dateCreate"] = DateTime.Now;
                    this.FillingOutTrippingDates(DateTime.Now);
                    dataRow["idWorker"] = this.DataRowCurrent["idWorker"];
                    dataRow["reguestFiled"] = this.DataRowCurrent["reguestFiled"];
                    dataRow["idSR"] = this.DataRowCurrent["idSR"];

                    if (this.tableRequestForRepairClient2 != null)
                    {
                        DataRow[] array = this.tableRequestForRepairClient2.Select("GESid = " + this.DataRowCurrent["idSR"].ToString());
                        if (array.Length != 0 && array[0]["Value"] != DBNull.Value)
                        {
                            dataRow["idRegion"] = array[0]["Value"];
                        }
                    }

                    dataRow["schmObj"] = this.DataRowCurrent["schmObj"];
                    dataRow["Purpose"] = this.DataRowCurrent["Purpose"];
                    dataRow["IsPlanned"] = this.DataRowCurrent["IsPlanned"];
                    dataRow["crash"] = this.DataRowCurrent["crash"];

                    if (this.tableRequestForRepairClient1 != null)
                    {
                        DataRow[] array2 = this.tableRequestForRepairClient1.Select("GesId = " + Convert.ToInt32(this.DataRowCurrent["IsPlanned"]).ToString());
                        if (array2.Length != 0 && array2[0]["Value"] != DBNull.Value)
                        {
                            dataRow["typeDisable"] = array2[0]["Value"];
                        }
                    }

                    dataRow["agreed"] = false;
                    dataRow["iddivision"] = this.DataRowCurrent["iddivision"];
                    dataRow["deleted"] = false;

                    if (this.IsCrash)
                    {
                        dataRow["SendSite"] = true;
                    }
                    else
                    {
                        dataRow["SendSite"] = false;
                    }

                    if (this.tableRequestForRepairClient3 != null)
                    {
                        DataRow[] array3 = this.tableRequestForRepairClient3.Select("isDefault = true");
                        if (array3.Length != 0)
                        {
                            dataRow["Organization"] = array3[0]["Value"];
                            dataRow["performerOrganization"] = array3[0]["Value"];
                        }
                    }

                    if (this.tableRequestForRepairClient4 != null)
                    {
                        DataRow[] array4 = this.tableRequestForRepairClient4.Select("isDefault = true");
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
                    this.dataSetDamage.tJ_RequestForRepair.Rows.Add(dataRow);
                }
                else
                {
                    DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepair.NewRow();
                    dataRow2["num"] = 0;
                    dataRow2["dateCreate"] = DateTime.Now;
                    this.FillingOutTrippingDates(DateTime.Now);
                    dataRow2["idWorker"] = -1;
                    dataRow2["reguestFiled"] = "";
                    dataRow2["idSR"] = this.IdSR;
                    dataRow2["schmObj"] = "";
                    dataRow2["Purpose"] = "";
                    dataRow2["crash"] = this.GetIsCrash();
                    if (this.GetIsCrash())
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
                    if (this.IsCrash)
                    {
                        dataRow2["SendSite"] = true;
                    }
                    else
                    {
                        dataRow2["SendSite"] = false;
                    }
                    if (this.tableRequestForRepairClient3 != null)
                    {
                        DataRow[] array5 = this.tableRequestForRepairClient3.Select("isDefault = true");
                        if (array5.Length != 0)
                        {
                            dataRow2["Organization"] = array5[0]["Value"];
                            dataRow2["performerOrganization"] = array5[0]["Value"];
                        }
                    }
                    if (this.tableRequestForRepairClient4 != null)
                    {
                        DataRow[] array6 = this.tableRequestForRepairClient4.Select("isDefault = true");
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
                    this.dataSetDamage.tJ_RequestForRepair.Rows.Add(dataRow2);
                    if (this.GetIsCrash())
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
                if (this.IdDocument > 0)
                {
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair, true, " where id = " + this.IdDocument.ToString());
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateCreate"] != DBNull.Value)
                    {
                        this.FillingOutTrippingDates(Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateCreate"]));
                    }
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdDocument.ToString());
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdDocument.ToString());
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairAddress, true, " where idRequest = " + this.IdDocument.ToString());
                    this.LoadTableSchmObjects(true);
                    this.FillTableRepairAddress();
                }
                break;
            case eActionRequestRepair.Read:
                if (this.IdDocument > 0)
                {
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair, true, " where id = " + this.IdDocument.ToString());
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdDocument.ToString());
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdDocument.ToString());
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairAddress, true, " where idRequest = " + this.IdDocument.ToString());
                    this.LoadTableSchmObjects(true);
                    this.FillTableRepairAddress();
                }
                this.ControlBloking();
                break;
        }
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0)
        {
            if (this.eAction == eActionRequestRepair.Edit && this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Status"] != DBNull.Value)
            {
                this.IdStatus = Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Status"]);
            }
            if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Agreed"] != DBNull.Value)
            {
                this.IsAgreed = Convert.ToBoolean(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Agreed"]);
            }
            if (this.IdDivision <= 0)
            {
                this.IdDivision = Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["IdDivision"]);
            }
            if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Crash"] != DBNull.Value && Convert.ToBoolean(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Crash"]))
            {
                this.cmbIsPlanned.Enabled = false;
                this.cmbTypeDisable.Enabled = false;
                this.SetIsCrash(true);
            }
        }
        if (!this.GetIsCrash())
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
        this.EnableIsSendToSite();
        this.SelectLogFromTableRequestForRepairLog();
        if (this.IdDocument != -1)
        {
            this.LoadTableTransOff();
            //CreateReferenceTables.LoadTableDamageAbnFullKladr(this.dataSetDamage.tJ_RequestForRepair, this.tableSchmAbnFull, this.SqlSettings, "dateCreate");
            this.LoadTableAbnOff();
            this.LoadTotalCountPoint();
            this.LoadTotalCountAbnObj();
            this.labelCountAbn.Text = "Количество абонентов: " + this.tableSchmAbnFull.DefaultView.ToTable(true, new string[]
            {
                "idAbn"
            }).Rows.Count.ToString();
        }
        //
        this.isChangedData = false;
        //
        this.dgvAddress.ReadOnly = true;
        this.toolBtnAddAddress.Enabled = false;
        this.toolBtnDelAddress.Enabled = false;
    }

    private void FormJournalRequestForRepairAddEdit_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            //if (!this.isChangedData )
            //{ 
            //    base.DialogResult = DialogResult.Cancel;
            //    return;
            //}
            if (this.eAction != eActionRequestRepair.Read && !this.CheckRequiredFields())
            {
                MessageBox.Show("Не введены обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Cancel = true;
                return;
            }
            //eActionRequestRepair eActionRequestRepair = this.eActionRequestRepair;

            this.AppendChildCommentXml();
            this.AppendChildTransOff();

            if (eAction != eActionRequestRepair.Add)
            {
                if (eAction == eActionRequestRepair.Edit)
                {
                    this.dataSetDamage.tJ_RequestForRepair.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair);
                }
            }
            else
            {
                this.dataSetDamage.tJ_RequestForRepair.Rows[0].EndEdit();
                this.IdDocument = base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair);
            }
            foreach (DataRow dataRow in this.dataSetDamage.tJ_RequestForRepairDaily)
            {
                if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
                {
                    if (Convert.ToInt32(dataRow["idrequest"]) != this.IdDocument)
                    {
                        dataRow["idRequest"] = this.IdDocument;
                    }
                    dataRow.EndEdit();
                }
            }

            base.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);
            base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);
            base.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);

            this.UpdateSchmObjList();
            this.UpdateRepairDoc();
            this.UpdateRepairAddress();

            this.InsertLogToTableRequestForRepairLog();
            // отсылка данных
            this.SendRequestToRIC();
            this.SendRequestToSite();
            // создание подчиненного документа
            this.CreateDocumentDamage();
        }
    }

    private void FormJournalRequestForRepairAddEdit_FormClosed(object sender, FormClosedEventArgs e)
    {
        base.SaveFormConfig(null);
    }
    /// <summary>
    ///     блокировка контролов при чтении
    /// </summary>
    private void ControlBloking()
    {
        this.cmbWorker.Enabled = false;
        this.txtRequestFiled.Enabled = false;
        this.cmbSR.Enabled = false;
        this.txtObject.ReadOnly = true;
        this.txtPurpose.ReadOnly = true;
        this.cmbIsPlanned.Enabled = false;
        this.groupBoxDaily.Enabled = false;
        this.txtAgreeWith.ReadOnly = true;
        this.txtComment.ReadOnly = true;
        this.txtAddress.ReadOnly = true;
        this.checkBoxAgreed.Enabled = false;
        this.dateTimePickerDateAgreed.Enabled = false;
        this.cmbDispatcher.Enabled = false;
        this.cmbTypeDamage.Enabled = false;

        this.cmbGroupWorks.Enabled = false;
        this.cmbPerformerOrganization.Enabled = false;
        this.cmbOrganization.Enabled = false;
        this.cmbStatus.Enabled = false;
        this.EnableIsSendToSite();

        this.toolStripAddress.Enabled = false;
        this.toolStripScheme.Enabled = false;
        this.toolStripDocuments.Enabled = false;
        this.toolBtnCopy.Enabled = false;
        this.buttonOK.Visible = false;

    }

    private void FillingOutTrippingDates(DateTime dateTrip)
    {
        this.dateTimeBeg = dateTrip.AddDays(-1.0).Date;
        this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
        this.dateTimePickerFactEnd.MinDate = this.dateTimeBeg;
        this.dateTimePickerDateAgreed.MinDate = this.dateTimeBeg;
    }

    private void groupBoxODS_VisibleChanged(object sender, EventArgs e)
    {
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
                str = " " + dataTable.Rows[0]["SocrName"].ToString();
            }
        }
        switch (this.eAction)
        {
            case eActionRequestRepair.Add:
                if (this.GetIsCrash())
                    this.Text = "Создать новую аварийную заявку" + str;
                else
                    this.Text = "Создать новую заявку" + str;
                break;
            case eActionRequestRepair.Edit:
                if (this.GetIsCrash())
                    this.Text = "Редактирование аварийной заявки" + str;
                else
                    this.Text = "Редактирование заявки" + str;
                break;
            case eActionRequestRepair.Read:
                if (this.GetIsCrash())
                    this.Text = "Просмотр аварийной заявки" + str;
                else
                    this.Text = "Просмотр заявки" + str;
                break;
            default:
                break;
        }
        this.Text = this.Text
            + "  №" + this.dataSetDamage.tJ_RequestForRepair.Rows[0]["num"].ToString()
            + " от " + Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateCreate"]).ToShortDateString();

        this.Text = this.Text + " (N2)";
    }

    private DataTable GetTabletWorkerGroup()
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

        DataTable tableITR = this.GetTabletWorkerGroup();
        base.SelectSqlData(tableITR, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
        this.cmbWorker.DataSource = tableITR;
        this.cmbWorker.DisplayMember = "FIO";
        this.cmbWorker.ValueMember = "ID";

        this.txtRequestFiled.DataSource = tableITR;
        this.txtRequestFiled.DisplayMember = "FIO";
        this.txtRequestFiled.ValueMember = "ID";

        DataTable tableDispatcher = this.GetTabletWorkerGroup();
        base.SelectSqlData(tableDispatcher, true, " where ParentKey in (';GroupWorker;ReconcileRequestRepair;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
        this.cmbDispatcher.DataSource = tableDispatcher;
        this.cmbDispatcher.DisplayMember = "FIO";
        this.cmbDispatcher.ValueMember = "ID";

        base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
        this.cmbSR.DataSource = this.dataSetDamage.tR_Classifier;
        this.cmbSR.DisplayMember = "name";
        this.cmbSR.ValueMember = "ID";
        this.cmbSR.SelectedIndex = -1;
        /*************************/
        DataTable tableIsPlanned = new DataTable();
        tableIsPlanned.Columns.Add("name", typeof(string));
        tableIsPlanned.Columns.Add("value", typeof(bool));
        this.cmbIsPlanned.DataSource = tableIsPlanned;
        this.cmbIsPlanned.DisplayMember = "name";
        this.cmbIsPlanned.ValueMember = "value";
        if (this.GetIsCrash())
        {
            tableIsPlanned.Rows.Add(new object[]
            {
                    "Аварийный",
                    false
            });
        }
        else
        {
            tableIsPlanned.Rows.Add(new object[]
            {
                    "Срочный",
                    false
            });
        }
        tableIsPlanned.Rows.Add(new object[]
        {
                "Плановый",
                true
        });
        /*****************************/
        DataTable tableTypeDamage = new DataTable("tR_Classifier");
        tableTypeDamage.Columns.Add("id", typeof(int));
        tableTypeDamage.Columns.Add("name", typeof(string));
        base.SelectSqlData(tableTypeDamage, true, string.Format(" where id in ({0}, {1})", (int)eTypeDocuments.DamageHV, (int)eTypeDocuments.DamageLV), null, false, 0);
        this.cmbTypeDamage.DisplayMember = "name";
        this.cmbTypeDamage.ValueMember = "id";
        this.cmbTypeDamage.DataSource = tableTypeDamage;
        this.cmbTypeDamage.SelectedIndex = -1;
    }

    private bool CheckRequiredFields()
    {
        bool result = true;
        if (string.IsNullOrEmpty(this.txtRequestFiled.Text))
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
        if (this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Count <= 0)
        {
            List<Color> list = new List<Color>();
            foreach (Control control in this.groupBoxDaily.Controls)
            {
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
            if (this.GetIsCrash() && this.cmbTypeDamage.SelectedIndex < 0)
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
        if (!this.GetIsCrash())
        {
            return;
        }
        if (this.IdDocument == -1)
        {
            return;
        }
        if (!this.checkBoxAgreed.Checked)
        {
            return;
        }
        base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair, true, " where id = " + this.IdDocument.ToString());
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0)
        {
            if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["idRIC"] == DBNull.Value)
            {
                try
                {
                    RequestsServiceSoapClient requestsServiceSoapClient = new RequestsServiceSoapClient();
                    Request request = new Request();
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["num"] != DBNull.Value)
                    {
                        request.Number = this.dataSetDamage.tJ_RequestForRepair.Rows[0]["num"].ToString();
                    }
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["schmObj"] != DBNull.Value)
                    {
                        request.AddressDisableText = this.dataSetDamage.tJ_RequestForRepair.Rows[0]["schmObj"].ToString();
                    }
                    using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                    {
                        sqlConnection.Open();
                        DbDataAdapter dbDataAdapter = new SqlDataAdapter(" select o.name as city, o.socr as citytype, s.name as street, s.socr as streettype, a.house  from tj_requestforrepairaddress a  inner join tr_kladrstreet s on s.id = a.idkladrstreet  inner join tr_kladrobj o on o.id = s.kladrObjid  where a.idREquest = " + this.IdDocument.ToString(), sqlConnection);
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
                    base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdDocument.ToString());
                    request.DateBeginEnd = new DateBeginEndList[this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Count];
                    for (int j = 0; j < this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Count; j++)
                    {
                        DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepairDaily.Rows[j];
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
                            if (j == this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Count - 1)
                            {
                                request.DatePlan = new DateTime?(Convert.ToDateTime(dataRow2["dateEnd"]));
                                request.DateEnd = new DateTime?(Convert.ToDateTime(dataRow2["dateEnd"]));
                            }
                        }
                    }
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["typeDisable"] != DBNull.Value)
                    {
                        request.RefTypeDisable = (long)Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["typeDisable"]);
                    }
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["purpose"] != DBNull.Value)
                    {
                        request.Cause = this.dataSetDamage.tJ_RequestForRepair.Rows[0]["purpose"].ToString();
                    }
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["organization"] != DBNull.Value)
                    {
                        request.ToOrganizationId = Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["organization"]);
                    }
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["status"] != DBNull.Value)
                    {
                        request.RefRequestStatusId = (long)Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["status"]);
                    }
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["performerorganization"] != DBNull.Value)
                    {
                        request.PerformerOrganizationId = Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["performerorganization"]);
                    }
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["groupWorks"] != DBNull.Value)
                    {
                        request.RefGroupWorksId = (long)Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["groupWorks"]);
                    }
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["idRegion"] != DBNull.Value)
                    {
                        request.RefRegionId = (long)Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["idRegion"]);
                    }
                    Response response = requestsServiceSoapClient.SendReq(request);
                    if (response.RequestId > 0L)
                    {
                        this.dataSetDamage.tJ_RequestForRepair.Rows[0]["idric"] = response.RequestId;
                        this.dataSetDamage.tJ_RequestForRepair.Rows[0]["isSEnd"] = true;
                        this.dataSetDamage.tJ_RequestForRepair.Rows[0].EndEdit();
                        base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair);
                    }
                    else
                    {
                        if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["messageRic"] == DBNull.Value)
                        {
                            this.dataSetDamage.tJ_RequestForRepair.Rows[0]["messageRic"] = response.Message;
                        }
                        else
                        {
                            this.dataSetDamage.tJ_RequestForRepair.Rows[0]["messageRic"] = response.Message + " \r\n" + this.dataSetDamage.tJ_RequestForRepair.Rows[0]["messageRic"].ToString();
                        }
                        if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["messageRic"].ToString().Length > 1024)
                        {
                            this.dataSetDamage.tJ_RequestForRepair.Rows[0]["messageRic"] = this.dataSetDamage.tJ_RequestForRepair.Rows[0]["messageRic"].ToString().Substring(0, 1024);
                        }
                        this.dataSetDamage.tJ_RequestForRepair.Rows[0]["isSEnd"] = false;
                        this.dataSetDamage.tJ_RequestForRepair.Rows[0].EndEdit();
                        base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair);
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
            if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Status"] == DBNull.Value)
            {
                return;
            }
            int idRIC = Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["idRIC"]);
            if (this.IdStatus != Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Status"]))
            {
                if (Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Status"]) == 164277)
                {
                    try
                    {
                        RequestsServiceSoapClient requestsServiceSoapClient2 = new RequestsServiceSoapClient();
                        DateTime dateEnd = DateTime.Now;
                        if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["dateFactEnd"] != DBNull.Value)
                        {
                            dateEnd = Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["dateFactEnd"]);
                        }
                        Response response2 = requestsServiceSoapClient2.Succsess((long)idRIC, dateEnd);
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
                if (Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Status"]) == 164280)
                {
                    try
                    {
                        Response response3 = new RequestsServiceSoapClient().RequestCancel((long)idRIC);
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
        this.isChangedData = true;
        this.checkBoxWeekEnd.Enabled = this.checkBoxDaily.Checked;
    }

    private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value.AddMinutes(1.0);
    }

    private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value.AddMinutes(-1.0);
    }

    /// <summary>
    /// сформировать минимально возможную фактическую дату выполнения заявки
    /// </summary>
    private void CreateMinimumRealDateСompletionRequest()
    {
        DateTime dateTime = DateTimePicker.MinimumDateTime;
        if ((from o in this.dataSetDamage.tJ_RequestForRepairDaily
             where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
             select o).Count() > 0)
        {
            try
            {
                DataRow dataRow = (from o in this.dataSetDamage.tJ_RequestForRepairDaily
                                   where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
                                   select o into a
                                   orderby a["DateBeg"]
                                   select a).First();
                if (dataRow != null && dataRow["DateBeg"] != DBNull.Value)
                {
                    dateTime = Convert.ToDateTime(dataRow["DateBeg"]);
                }
            }
            catch
            {
            }
        }
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateCreate"] != DBNull.Value && dateTime < Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateCreate"]).AddDays(-1.0).Date)
        {
            dateTime = Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateCreate"]).AddDays(-1.0).Date;
        }
        this.dateTimePickerFactEnd.MinDate = dateTime;
    }

    private void dgvDaily_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
        DataRow dataRow = (from o in this.dataSetDamage.tJ_RequestForRepairDaily
                           where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
                           select o into a
                           orderby a.dateEnd descending
                           select a).First();
        if (Convert.ToDateTime(dataRow["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
        {
            this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
        }
        this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow["DateEnd"]);
        this.CreateMinimumRealDateСompletionRequest();
        this.CreateRealDateСompletionRequest(Convert.ToDateTime(dataRow["DateEnd"]));
    }
    /// <summary>
    /// сформировать фактическую дату выполнения заявки
    /// </summary>
    private void CreateRealDateСompletionRequest(DateTime dateEnd)
    {
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && ((this.dataSetDamage.tJ_RequestForRepair.Rows[0].HasVersion(DataRowVersion.Original) && this.dataSetDamage.tJ_RequestForRepair.Rows[0]["dateFactEnd", DataRowVersion.Original] == DBNull.Value) || !this.dataSetDamage.tJ_RequestForRepair.Rows[0].HasVersion(DataRowVersion.Original)) && !this.GetIsCrash())
        {
            this.dateTimePickerFactEnd.Value = dateEnd;
        }
    }

    private void dgvDaily_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
        this.CreateMinimumRealDateСompletionRequest();
        if (this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Count <= 0)
        {
            this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
            this.CreateRealDateСompletionRequest(this.dateTimeBeg);
            return;
        }
        if ((from o in this.dataSetDamage.tJ_RequestForRepairDaily
             where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
             select o).Count() > 0)
        {
            DataRow dataRow = (from o in this.dataSetDamage.tJ_RequestForRepairDaily
                               where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
                               select o into a
                               orderby a.dateEnd descending
                               select a).First();
            this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow["DateEnd"]);
            this.CreateRealDateСompletionRequest(Convert.ToDateTime(dataRow["DateEnd"]));
            return;
        }
        this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
        this.CreateRealDateСompletionRequest(this.dateTimeBeg);
    }

    private void dgvDaily_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        this.CreateMinimumRealDateСompletionRequest();
        if (e.RowIndex == this.dgvDaily.Rows.Count - 1)
        {
            DateTime dateTime = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, e.RowIndex].Value);
            if (dateTime > this.dateTimePickerBeg.MaxDate)
            {
                this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
            }
            this.dateTimePickerBeg.MinDate = dateTime;
            this.CreateRealDateСompletionRequest(dateTime);
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
                        DataRow dataRow = this.dataSetDamage.tJ_RequestForRepairDaily.NewRow();
                        dataRow["idRequest"] = this.IdDocument;
                        dataRow["dateBeg"] = this.dateTimePickerBeg.Value.AddDays((double)i);
                        dataRow["dateEnd"] = this.dateTimePickerBeg.Value.AddDays((double)i).Date + this.dateTimePickerEnd.Value.TimeOfDay;
                        this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Add(dataRow);
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
                DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepairDaily.NewRow();
                dataRow2["idRequest"] = this.IdDocument;
                dataRow2["dateBeg"] = this.dateTimePickerBeg.Value;
                dataRow2["dateEnd"] = this.dateTimePickerEnd.Value;
                this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Add(dataRow2);
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
            DataRow dataRow3 = (from o in this.dataSetDamage.tJ_RequestForRepairDaily
                                where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
                                select o into a
                                orderby a.dateEnd descending
                                select a).First();
            if (Convert.ToDateTime(dataRow3["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
            {
                this.dateTimePickerBeg.MaxDate = this.dateTimeEnd;
            }
            this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow3["DateEnd"]);
            this.CreateMinimumRealDateСompletionRequest();
            this.CreateRealDateСompletionRequest(Convert.ToDateTime(dataRow3["DateEnd"]));
        }
    }

    private void cmbIsPlanned_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (this.cmbIsPlanned.SelectedIndex >= 0)
        {
            this.labelIsPlanned.ForeColor = SystemColors.ControlText;
        }
    }

    private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (this.cmbWorker.SelectedIndex >= 0)
        {
            this.labelWorker.ForeColor = SystemColors.ControlText;
        }
    }

    private void txtRequestFiled_TextChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (!string.IsNullOrEmpty(this.txtRequestFiled.Text))
        {
            this.labelRequestFiled.ForeColor = SystemColors.ControlText;
        }
    }

    private void cmbSR_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (this.cmbSR.SelectedIndex >= 0)
        {
            this.labelSR.ForeColor = SystemColors.ControlText;
        }
    }

    private void txtObject_TextChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (!string.IsNullOrEmpty(this.txtObject.Text))
        {
            this.labelObject.ForeColor = SystemColors.ControlText;
        }
    }

    private void txtPurpose_TextChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
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
        this.isChangedData = true;
        if (this.cmbOrganization.SelectedIndex >= 0)
        {
            this.labelOrganization.ForeColor = SystemColors.ControlText;
        }
    }

    private void cmbPerformerOrganization_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (this.cmbPerformerOrganization.SelectedIndex >= 0)
        {
            this.labelPerformer.ForeColor = SystemColors.ControlText;
        }
    }

    private void cmbGroupWorks_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (this.cmbGroupWorks.SelectedIndex >= 0)
        {
            this.labelGroupWork.ForeColor = SystemColors.ControlText;
        }
    }

    private void txtRequestFiled_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (this.txtRequestFiled.SelectedIndex >= 0)
        {
            this.labelRequestFiled.ForeColor = SystemColors.ControlText;
        }
    }
    /// <summary>
    /// загрузить таблицу отключенных объектов
    /// Load - показывает, что документ только что открылся
    /// </summary>
    private void LoadTableLinkObjects(bool Load = false)
    {
        this.tableLinkObjects.Clear();
        this.LinkObjects.Clear();
        if (this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Count > 0)
        {
            //int num = 0;
            foreach (DataRow dataRow in this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows)
            {
                DataRow dataRow2 = this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].NewRow();
                dataRow2["Objects"] = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                                    {
                            dataRow["idSchmObj"].ToString()
                                    }).ToString();

                dataRow2["DateBeg"] = Convert.ToDateTime(dataRow["DateBeg"]);
                dataRow2["DateEnd"] = Convert.ToDateTime(dataRow["DateEnd"]);
                dataRow2["Duration"] = dataRow["Duration"].ToString();
                dataRow2["disabled"] = isCountRowsForRepairDailySchmObj(Convert.ToInt32(dataRow["idSchmObj"]));
                dataRow2["Num"] = dataRow["Num"];

                this.LinkObjects.Add(Convert.ToInt32(dataRow["idSchmObj"]), dataRow2["Objects"].ToString());
                this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].Rows.Add(dataRow2);
            }
            //DataView defaultView = this.dataSetDamage.tL_RequestForRepairSchmObjList.DefaultView;
            //defaultView.Sort = "Num";
            //DataTable dataTable = defaultView.ToTable();
            //int num = 0;
            //bool flag = false;
            //List<string> list = new List<string>();
            //DateTime dateTime = DateTime.Now;
            //DateTime dateTime2 = DateTime.Now;
            //string value = "";
            //foreach (DataRow dataRow in dataTable.Rows)
            //{
            //    if (num == (int)Convert.ToInt16(dataRow["num"]))
            //    {
            //        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
            //        {
            //                dataRow["idSchmObj"].ToString()
            //        }).ToString());
            //    }
            //    else
            //    {
            //        if (list.Count > 0)
            //        {
            //            list.Sort();
            //            DataRow dataRow2 = this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].NewRow();
            //            dataRow2["Objects"] = "";
            //            foreach (string arg in list)
            //            {
            //                DataRow dataRow3 = dataRow2;
            //                dataRow3["Objects"] = dataRow3["Objects"] + arg + "\n";
            //            }
            //            dataRow2["Objects"] = ((string)dataRow2["Objects"]).Remove(dataRow2["Objects"].ToString().Length - 1);
            //            dataRow2["DateBeg"] = dateTime;
            //            dataRow2["DateEnd"] = dateTime2;
            //            dataRow2["Duration"] = value;
            //            dataRow2["disabled"] = flag;
            //            dataRow2["Num"] = num;
            //            this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].Rows.Add(dataRow2);
            //        }
            //        list = new List<string>();
            //        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
            //        {
            //                dataRow["idSchmObj"].ToString()
            //        }).ToString());
            //        dateTime = Convert.ToDateTime(dataRow["DateBeg"]);
            //        dateTime2 = Convert.ToDateTime(dataRow["DateEnd"]);
            //        value = dataRow["Duration"].ToString();
            //        num = (int)Convert.ToInt16(dataRow["Num"]);
            //        flag = false;
            //    }
            //    if (!flag)
            //    {
            //        flag = this.isCountRowsForRepairDailySchmObj(Convert.ToInt32(dataRow["idSchmObj"]));
            //    }
            //}
            //if (list.Count > 0)
            //{
            //    list.Sort();
            //    DataRow dataRow4 = this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].NewRow();
            //    dataRow4["Objects"] = "";
            //    foreach (string arg2 in list)
            //    {
            //        DataRow dataRow3 = dataRow4;
            //        dataRow3["Objects"] = dataRow3["Objects"] + arg2 + "\n";
            //    }
            //    dataRow4["Objects"] = ((string)dataRow4["Objects"]).Remove(dataRow4["Objects"].ToString().Length - 1);
            //    dataRow4["DateBeg"] = dateTime;
            //    dataRow4["DateEnd"] = dateTime2;
            //    dataRow4["Duration"] = value;
            //    dataRow4["disabled"] = flag;
            //    dataRow4["Num"] = num;
            //    this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].Rows.Add(dataRow4);
            //}
            if (this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].Rows.Count > 0)
            {
                this.toolBtnViewSChmObj.Enabled = true;
            }
            else
                this.toolBtnViewSChmObj.Enabled = false;
        }
        if (Load == false) this.RefreshTable();
        //
    }
    /// <summary>
    /// проверка отключений по конкретному объекту схемы
    /// </summary>
    private bool isCountRowsForRepairDailySchmObj(int idSchmObj)
    {
        return this.IdDocument != -1 && new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0} and idSchmObj = {1}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", this.IdDocument, idSchmObj)).Rows.Count > 0;
    }

    private void LoadTableSchmObjects(bool Load = false)
    {
        base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.IdDocument.ToString());
        this.LoadTableLinkObjects(Load);
    }

    private void toolBtnLinkSchmObj_Click(object sender, EventArgs e)
    {
        FormLinkRequestAndSchm frmLink = new FormLinkRequestAndSchm();
        frmLink.SqlSettings = this.SqlSettings;
        if (frmLink.ShowDialog() == DialogResult.OK)
        {
            int num = 0;
            if (this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Count > 0)
            {
                num = (int)(this.dataSetDamage.tL_RequestForRepairSchmObjList
                    .Where(r => r.RowState != DataRowState.Deleted)
                    .Max(r => r.Num) + 1);
            }
            else
                num = 1;
            //this.LinkObjects = frmLink.GetLinkObjects();

            foreach (int ids in frmLink.GetLinkObjects().Keys)
            {
                // 1
                if (!this.LinkObjects.ContainsKey(Convert.ToInt32(ids)))
                {
                    this.LinkObjects.Add(ids, "");
                }
                // 2
                DataRow dataRow = this.dataSetDamage.tL_RequestForRepairSchmObjList.NewRow();
                dataRow["idRequest"] = this.IdDocument;
                dataRow["idSchmObj"] = ids;
                dataRow["DAteBeg"] = frmLink.DateBeg;
                dataRow["DAteEnd"] = frmLink.DateEnd;
                dataRow["duration"] = frmLink.Duration;
                dataRow["num"] = num;
                this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Add(dataRow);
                num++;
            }
            this.LoadTableLinkObjects();
            //this.RefreshTable(this.LinkObjects.Keys.ToList<int>());
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
        DataRow[] array = this.dataSetDamage.tL_RequestForRepairSchmObjList.Select("num = " + this.dgvLinkObjects.CurrentRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString());
        this.LinkObjects.Clear();
        if (array.Length != 0)
        {
            FormLinkRequestAndSchm frmLink = new FormLinkRequestAndSchm();
            frmLink.SqlSettings = this.SqlSettings;
            frmLink.DateBeg = Convert.ToDateTime(array[0]["dateBeg"]);
            frmLink.DateEnd = Convert.ToDateTime(array[0]["dateEnd"]);
            frmLink.Duration = array[0]["Duration"].ToString();
            frmLink.Num = Convert.ToInt16(array[0]["Num"]);
            foreach (DataRow dataRow in array)
            {
                this.LinkObjects.Add(Convert.ToInt32(dataRow["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                {
                        dataRow["idSchmObj"].ToString()
                }).ToString());
            }
            frmLink.SetLinkObjects(this.LinkObjects);
            if (frmLink.ShowDialog() == DialogResult.OK)
            {
                this.LinkObjects = frmLink.GetLinkObjects();
                foreach (DataRow dataRow2 in array)
                {
                    if (this.LinkObjects.ContainsKey(Convert.ToInt32(dataRow2["idSchmObj"])))
                    {
                        dataRow2["DAteBeg"] = frmLink.DateBeg;
                        dataRow2["DAteEnd"] = frmLink.DateEnd;
                        dataRow2["duration"] = frmLink.Duration;
                        this.LinkObjects.Remove(Convert.ToInt32(dataRow2["idSchmObj"]));
                    }
                    else
                    {
                        dataRow2.Delete();
                    }
                }
                foreach (int num in this.LinkObjects.Keys)
                {
                    DataRow dataRow3 = this.dataSetDamage.tL_RequestForRepairSchmObjList.NewRow();
                    dataRow3["idRequest"] = this.IdDocument;
                    dataRow3["idSchmObj"] = num;
                    dataRow3["DAteBeg"] = frmLink.DateBeg;
                    dataRow3["DAteEnd"] = frmLink.DateEnd;
                    dataRow3["duration"] = frmLink.Duration;
                    dataRow3["num"] = frmLink.Num;
                    this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Add(dataRow3);
                }
                this.LoadTableLinkObjects();
            }
        }
    }

    private void toolBtnDelSchmObj_Click(object sender, EventArgs e)
    {
        if (dgvLinkObjects.Rows.Count == 0) return;
        foreach (object obj in this.dgvLinkObjects.SelectedRows)
        {
            DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
            if (Convert.ToBoolean(dataGridViewRow.Cells[this.disabledDgvColumn.Name].Value))
            {
                MessageBox.Show("Удаление невозможно. Существует согласованный подчиненный документ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            DataRow[] dr = this.dataSetDamage.tL_RequestForRepairSchmObjList.Select("num = " + dataGridViewRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString());
            foreach (var row in dr)
            {
                this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Remove(row);
            }

        }
        this.LoadTableLinkObjects();
    }

    private void toolBtnViewSChmObj_Click(object sender, EventArgs e)
    {
        this.LinkObjects.Clear();
        foreach (DataGridViewRow dataGridViewRow in this.dgvLinkObjects.SelectedRows)
        {
            foreach (DataRow dataRow in this.dataSetDamage.tL_RequestForRepairSchmObjList.Select("num = " + dataGridViewRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString()))
            {
                if (!this.LinkObjects.ContainsKey(Convert.ToInt32(dataRow["idSchmObj"])))
                {
                    this.LinkObjects.Add(Convert.ToInt32(dataRow["idSchmObj"]), "");
                }
            }
        }
        GoToSchemaEventArgs e2 = new GoToSchemaEventArgs(this.LinkObjects.Keys.ToList<int>());
        this.OnGoToSchema(e2);
    }
    /// <summary>
    /// обновление таблицы отключенныхо объектов
    /// </summary>
    private void UpdateSchmObjList()
    {
        this.DeleteSqlDataWhere(this.dataSetDamage.tL_RequestForRepairSchmObjList, string.Format(" WHERE idRequest = {0}", this.IdDocument.ToString()));

        foreach (DataRow dataRow in this.dataSetDamage.tL_RequestForRepairSchmObjList)
        {
            if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
            {
                dataRow["idRequest"] = this.IdDocument;
                dataRow.EndEdit();
            }
            this.InsertSqlDataOneRow(dataRow);
        }
        //this.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tL_RequestForRepairSchmObjList);
        //base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tL_RequestForRepairSchmObjList);
        //base.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tL_RequestForRepairSchmObjList);
        this.dataSetDamage.tL_RequestForRepairSchmObjList.AcceptChanges();
    }

    private void checkBoxAgreed_CheckedChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        if (this.checkBoxAgreed.Checked)
        {
            if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dateTimePickerDateAgreed.Value == null)
            {
                this.dateTimePickerDateAgreed.Value = DateTime.Now;
                return;
            }
        }
        else if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dateTimePickerDateAgreed.Value != null)
        {
            this.dateTimePickerDateAgreed.Value = null;
            this.cmbStatus.SelectedIndex = -1;
        }
    }

    private void checkBoxAgreed_CheckStateChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        this.EnableIsSendToSite();
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
                    DataRow dataRow = this.dataSetDamage.tJ_RequestForRepairDoc.NewRow();
                    dataRow["idRequest"] = this.IdDocument;
                    dataRow["Document"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
                    dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
                    this.dataSetDamage.tJ_RequestForRepairDoc.Rows.Add(dataRow);
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
        byte[] array = (byte[])this.dataSetDamage.tJ_RequestForRepairDoc.FindByid(num)["Document"];
        string text = Path.GetTempFileName();
        text = Path.ChangeExtension(text, Path.GetExtension(this.dataSetDamage.tJ_RequestForRepairDoc.FindByid(num)["FileName"].ToString()));
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
                byte[] array = (byte[])this.dataSetDamage.tJ_RequestForRepairDoc.FindByid(num)["Document"];
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
            byte[] array = (byte[])this.dataSetDamage.tJ_RequestForRepairDoc.FindByid(num)["Document"];
            string text = Path.GetTempFileName();
            text = Path.ChangeExtension(text, Path.GetExtension(this.dataSetDamage.tJ_RequestForRepairDoc.FindByid(num)["FileName"].ToString()));
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
    /// <summary>
    /// сохранение прикрепленных файлов
    /// </summary>
    private void UpdateRepairDoc()
    {
        foreach (DataRow dataRow in this.dataSetDamage.tJ_RequestForRepairDoc)
        {
            if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
            {
                dataRow["idRequest"] = this.IdDocument;
                dataRow.EndEdit();
            }
        }

        this.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc);
        base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc);
        base.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc);
        this.dataSetDamage.tJ_RequestForRepairDoc.AcceptChanges();
    }

    private void buttonCopy_Click(object sender, EventArgs e)
    {
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count <= 0)
        {
            return;
        }
        DataTable dataTable = this.dataSetDamage.tJ_RequestForRepair.Copy();
        DataRow dataRow = dataTable.NewRow();
        dataRow.ItemArray = dataTable.Rows[0].ItemArray;
        this.dataSetDamage.tJ_RequestForRepair.Clear();
        this.dataSetDamage.tJ_RequestForRepairDoc.Clear();
        this.dataSetDamage.tJ_RequestForRepairDaily.Clear();
        DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepair.NewRow();
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
        this.IdDocument = -1;
        this.eAction = eActionRequestRepair.Add;
        this.dataSetDamage.tJ_RequestForRepair.Rows.Add(dataRow2);
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
        if (this.eAction == eActionRequestRepair.Add && this.cmbSR.SelectedValue != null)
        {
            xmlAttribute.Value = this.cmbSR.SelectedValue.ToString();
        }
        else
        {
            xmlAttribute.Value = this.IdSR.ToString();
        }
        xmlNode.Attributes.Append(xmlAttribute);
        return xmlDocument;
    }

    protected override void ApplyConfig(XmlDocument doc)
    {
        XmlNode xmlNode = doc.SelectSingleNode(base.Name);
        if (xmlNode != null)
        {
            XmlAttribute xmlAttribute = xmlNode.Attributes["X"];
            int? numX = null;
            int? numY = null;
            if (xmlAttribute != null)
            {
                numX = new int?(Convert.ToInt32(xmlAttribute.Value));
            }
            xmlAttribute = xmlNode.Attributes["Y"];
            if (xmlAttribute != null)
            {
                numY = new int?(Convert.ToInt32(xmlAttribute.Value));
            }
            if (numX != null && numY != null)
            {
                if (numX < 0)
                {
                    numX = new int?(0);
                }
                if (numY < 0)
                {
                    numY = new int?(0);
                }
                base.Location = new Point(numX.Value, numY.Value);
            }
            xmlAttribute = xmlNode.Attributes["SR"];
            if (xmlAttribute != null)
            {
                this.IdSR = Convert.ToInt32(xmlAttribute.Value);
            }
        }
    }
    /// <summary>
    /// заполним таблицs отключенных адресов, трансформаторов, абонентов, подстанций
    /// </summary>
    private void RefreshTable(List<int> list)
    {
        //
        this.progressBar.Visible = true;
        this.labelProgress.Visible = true;
        this.toolBtnRefreshTrans.Enabled = false;
        this.toolBtnRefreshAbn.Enabled = false;
        this.toolBtnDelAbn.Enabled = false;

        this.dgvTrans.Enabled = false;
        this.dgvTrans.DataSource = null;
        this.dgvTreeSub.Enabled = false;

        this.dgvAbn.Enabled = false;
        //this.dgvAbn.DataSource = null;
        //
        this.splitContainer1.Panel2.Enabled = false;
        this.toolStripScheme.Enabled = false;
        this.backgroundWorker.RunWorkerAsync(list);

        buttonOK.Enabled = false;
    }
    private void RefreshTable()
    {
            RefreshTable(LinkObjects.Keys.ToList());
    }

    private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        if (this.electricModel == null)
        {
            this.electricModel = new ElectricModel();
            this.electricModel.SqlSettings = this.SqlSettings;
            this.electricModel.LoadSchema(true);// загрузка схемы по нормальной схеме
        }
        #region  таблица кабелей
        this.dtSchmCable = new DataTable("SchmCable");
        using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Library.ResourceReader.GetStringAssembly(this.GetType(), "RequestForRepairN.SchmCable.sql"), sqlConnection);
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                this.dtSchmCable.Clear();
                sqlDataAdapter.Fill(this.dtSchmCable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        #endregion
        List<int> objectsId = (List<int>)e.Argument;
        //var eLinkObjects = from obj in this.electricModel.Objects
        //                 where objectsId.Contains(obj.Id)
        //                 select obj;
        var eLinkObjects = electricModel.Objects.Where(obj => ((List<int>)e.Argument).Contains(obj.Id));
        this.tableTransOff.Clear();
        this.dgvTreeNodesSubClear();
        this.dgvTreeNodesAbnClear();
        this.tableSchmAbnFull.Clear(); // чистим таблицу абонентов
        this.dataSetDamage.tJ_RequestForRepairAddress.Clear(); // чистим таблицу улиц

        foreach (var obj in eLinkObjects)
        {
            int idSchmObj = obj.Id;
            TreeNodeObj treeNodeObj_ = electricModel.PoweringReportForDrawObject(idSchmObj, true);

            #region трансформаторы - отключенные
            //this.labelProgress.Text = "Получаем отключамые трансформаторы";
            List<int> listTrans = new List<int>();
            FillTreeNodeTrans(treeNodeObj_, listTrans);
            DataTable table = FormJournalRequestForRepairAddEditCrash.FillTableTransOff(listTrans, new StaticFormData { Sqlsettings = this.SqlSettings, eForm = this });
            table.AsEnumerable().CopyToDataTable(tableTransOff, LoadOption.OverwriteChanges);
            #endregion
            #region подстанции - отключенные
            //this.labelProgress.Text = "Получаем отключенные подстанции (дерево отключения)";
            this.listElectricBus = new List<int>();
            this.FillTableSubOff(null, treeNodeObj_);
            #endregion
            #region абоненты - отключенные
            //this.labelProgress.Text = "Получаем отключамых абонентов";
            var source = electricModel.Objects.Where(r => r.Id == idSchmObj);
            List<ElectricObject> listElectricObj = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
            //
            DateTime dateTime = DateTime.Now;
            if (this.dtpDateCreate.Value != null && this.dtpDateCreate.Value != DBNull.Value)
            {
                dateTime = Convert.ToDateTime(this.dtpDateCreate.Value);
            }
            //проверить сохраняются ли абоненты с предыдущего захода по циклам
            Reference.Tables.LoadTableSсhmAbnFullKladr(this.tableSchmAbnFull, this.SqlSettings, listElectricObj, dateTime, false);
            //this.FillTableAbnOff(null);
            this.labelCountAbn.Text = "Количество абонентов: " + this.tableSchmAbnFull.DefaultView.ToTable(true, new string[]
            {
            "idAbn"
            }).Rows.Count.ToString();
            #endregion
        }
        //this.labelProgress.Text = "Формирование реестра улиц и домов";
        #region  заполнение таблиц кладр для заполнения отключенных домов в таблице dgvAddress
        if (this.tablelKladrStreet == null)
        {
            this.tablelKladrStreet = new DataTable("tr_kladrstreet");
            base.SelectSqlData(this.tablelKladrStreet, true, "where deleted = 0", null, false, 0);
        }
        if (this.tableKladrObj == null)
        {
            this.tableKladrObj = new DataTable("tr_kladrObj");
            base.SelectSqlData(this.tableKladrObj, true, "where deleted = 0", null, false, 0);
        }
        if (this.tableKladrObjAddress == null)
        {
            this.tableKladrObjAddress = new DataTable();
            this.tableKladrObjAddress.Columns.Add("KladrObjId", typeof(int));
            this.tableKladrObjAddress.Columns.Add("idstreet", typeof(int));
            this.tableKladrObjAddress.Columns.Add("house", typeof(string));
        }
        else
        {
            this.tableKladrObjAddress.Clear();
        }
        this.FillTableAbnOff(null);
        //if (eLinkObjects.Count() > 0)
        //{
        //    List<ElectricObject> list = new List<ElectricObject>();
        //    foreach (ElectricObject obj in eLinkObjects)
        //    {
        //        //второй раз запрос думаю делать не нада 
        //        list.AddRange(this.electricModel.PoweringReportForDrawObject(obj, true, true));
        //    }
        //    if (list.Count > 0)
        //    {
        //        string text = "";
        //        foreach (ElectricObject obj in list)
        //        {
        //            if (string.IsNullOrEmpty(text))
        //            {
        //                text = obj.Id.ToString();
        //            }
        //            else
        //            {
        //                text = text + "," + obj.Id.ToString();
        //            }
        //        }
        //        using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
        //        {
        //            try
        //            {
        //                sqlConnection.Open();
        //                new SqlDataAdapter(" select o.id as KladrObjId, l.id as idStreet, house  from vl_SchmAbnFull l   left join tr_kladrStreet s on l.id = s.id  left join tr_kladrObj o on o.id = s.kladrobjid  where abnActive = 1 and objactive = 1 and idSchmObj in (" + text + ")  group by o.id, l.id, house ", sqlConnection)
        //                {
        //                    SelectCommand =
        //                        {
        //                            CommandTimeout = 0
        //                        }
        //                }.Fill(this.tableKladrObjAddress);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message, ex.Source);
        //            }
        //        }
        //    }
        //}
        #endregion
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        #region  заполнение отключенных домов в таблице dgvAddress
        try
        {
            var enumAddress = tableSchmAbnFull.AsEnumerable().GroupBy(r => new { KladrObjId = r["KladrObjId"], idStreet = r["idStreet"], house = r["house"] });
            foreach (var row in enumAddress)
                {
                    if (row.Key.idStreet != DBNull.Value && row.Key.house != DBNull.Value && this.dataSetDamage.tJ_RequestForRepairAddress.Select(string.Concat(new string[]
                    {
                        "idKladrStreet = ",
                        row.Key.idStreet.ToString(),
                        " and house = '",
                        row.Key.house.ToString(),
                        "'"
                    })).Length == 0)
                    {
                        DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepairAddress.NewRow();
                        dataRow2["idRequest"] = this.IdDocument;
                        dataRow2["idKladrObj"] = row.Key.KladrObjId;
                        dataRow2["idKladrStreet"] = row.Key.idStreet;
                        dataRow2["house"] = row.Key.house;
                        this.dataSetDamage.tJ_RequestForRepairAddress.Rows.Add(dataRow2);
                    }
                }
            //foreach (DataRow dataRow in this.tableKladrObjAddress.Rows)
            //{
            //    if (dataRow["idstreet"] != DBNull.Value && dataRow["house"] != DBNull.Value && this.dataSetDamage.tJ_RequestForRepairAddress.Select(string.Concat(new string[]
            //    {
            //            "idKladrStreet = ",
            //            dataRow["idStreet"].ToString(),
            //            " and house = '",
            //            dataRow["house"].ToString(),
            //            "'"
            //    })).Length == 0)
            //    {
            //        DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepairAddress.NewRow();
            //        dataRow2["idRequest"] = this.IdRequest;
            //        dataRow2["idKladrObj"] = dataRow["kladrObjId"];
            //        dataRow2["idKladrStreet"] = dataRow["idstreet"];
            //        dataRow2["house"] = dataRow["house"];
            //        this.dataSetDamage.tJ_RequestForRepairAddress.Rows.Add(dataRow2);
            //    }
            //}
            this.FillTableRepairAddress();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source);
        }
        #endregion

        this.splitContainer1.Panel2.Enabled = true;
        this.toolStripScheme.Enabled = true;
        //
        this.progressBar.Visible = false;
        this.labelProgress.Visible = false;
        this.toolBtnRefreshAbn.Enabled = true;
        this.toolBtnDelAbn.Enabled = true;
        this.toolBtnRefreshTrans.Enabled = true;

        this.dgvTrans.Enabled = true;
        this.dgvTrans.DataSource = this.bsTransON;
        this.dgvTreeSub.Enabled = true;

        this.dgvAbn.Enabled = true;
        //this.dgvAbn.DataSource = this.bsSchmAbnFull;
        //
        this.FillCountTrans();
        this.CalculationCountPoints();
        this.CalculationCountConsumersAndMaximumPower();

        buttonOK.Enabled = true;
    }
    /// <summary>
    /// формирование списка отключенных домов текстовой строкой
    /// </summary>
    private void FillTableRepairAddress()
    {
        this.tableAddress.Clear();
        if (this.tablelKladrStreet == null)
        {
            this.tablelKladrStreet = new DataTable("tr_kladrstreet");
            base.SelectSqlData(this.tablelKladrStreet, true, "where deleted = 0", null, false, 0);
        }
        if (this.tableKladrObj == null)
        {
            this.tableKladrObj = new DataTable("tr_kladrObj");
            base.SelectSqlData(this.tableKladrObj, true, "where deleted = 0", null, false, 0);
        }
        foreach (DataRow dataRow in this.dataSetDamage.tJ_RequestForRepairAddress)
        {
            if (dataRow.RowState != DataRowState.Deleted)
            {
                DataRow dataRow2 = this.tableAddress.NewRow();
                dataRow2["id"] = dataRow["id"];
                dataRow2["idKladrObj"] = dataRow["idKladrObj"];
                dataRow2["idKladrStreet"] = dataRow["idKladrstreet"];
                dataRow2["house"] = dataRow["house"];
                DataRow[] arrayObj = this.tableKladrObj.Select("id = " + dataRow["idKladrObj"].ToString());
                if (arrayObj.Length != 0)
                {
                    dataRow2["City"] = arrayObj[0]["name"].ToString() + " " + arrayObj[0]["socr"].ToString();
                }
                DataRow[] arrayStreet = this.tablelKladrStreet.Select("id = " + dataRow["idKladrStreet"].ToString());
                if (arrayStreet.Length != 0)
                {
                    dataRow2["Street"] = arrayStreet[0]["name"].ToString() + " " + arrayStreet[0]["socr"].ToString();
                }
                this.tableAddress.Rows.Add(dataRow2);
            }
        }
        List<int> list = new List<int>();
        foreach (DataRow dataRow in this.tableAddress.Rows)
        {
            if (!list.Contains(Convert.ToInt32(dataRow["idKladrStreet"])))
            {
                list.Add(Convert.ToInt32(dataRow["idKladrStreet"]));
            }
        }
        string text = "";
        foreach (int num in list)
        {
            DataRow[] arrayStreet = this.tableAddress.Select("idkladrstreet = " + num.ToString());
            if (arrayStreet.Count<DataRow>() > 0)
            {
                string text2 = arrayStreet[0]["City"].ToString() + ", " + arrayStreet[0]["Street"].ToString() + ", д. ";
                foreach (DataRow dataRow in arrayStreet)
                {
                    text2 = text2 + dataRow["House"].ToString() + ", ";
                }
                text2 = text2.Remove(text2.Length - 2);
                text = text + text2 + "\r\n";
            }
        }
        this.txtAddress.Text = text;
        if (!string.IsNullOrEmpty(this.txtAddress.Text))
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
            foreach (DataRow dataRow in form.tableKladr.Rows)
            { 
                if (this.dataSetDamage.tJ_RequestForRepairAddress.Select(string.Concat(new string[]
                {
                        "idKladrStreet = ",
                        dataRow["idStreet"].ToString(),
                        " and house = '",
                        dataRow["house"].ToString(),
                        "'"
                })).Length == 0)
                {
                    DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepairAddress.NewRow();
                    dataRow2["idRequest"] = this.IdDocument;
                    dataRow2["idKladrObj"] = dataRow["idKladrObj"];
                    dataRow2["idKladrStreet"] = dataRow["idstreet"];
                    dataRow2["house"] = dataRow["house"];
                    this.dataSetDamage.tJ_RequestForRepairAddress.Rows.Add(dataRow2);
                }
            }
            this.FillTableRepairAddress();
        }
    }

    private void toolBtnDelAddress_Click(object sender, EventArgs e)
    {
        if (this.dgvAddress.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить выбранные строки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            foreach (DataGridViewRow row in this.dgvAddress.SelectedRows)
            {
                int num = Convert.ToInt32(row.Cells[this.idAddressDgvColumn.Name].Value);
                DataRow[] dr = this.dataSetDamage.tJ_RequestForRepairAddress.Select("id = " + num.ToString());
                if (dr.Length != 0)
                {
                    dr[0].Delete();
                }
            }
            this.FillTableRepairAddress();
        }
    }
    /// <summary>
    /// сохранение отключенных адресов 
    /// </summary>
    private void UpdateRepairAddress()
    {
        foreach (DataRow dataRow in this.dataSetDamage.tJ_RequestForRepairAddress)
        {
            if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
            {
                dataRow["idRequest"] = this.IdDocument;
                dataRow.EndEdit();
            }
        }
        
        if (this.dataSetDamage.tJ_RequestForRepairAddress.Count > 0)
        {
            if (this.dataSetDamage.tJ_RequestForRepairAddress.Rows[0].RowState == DataRowState.Added)
            {
                this.DeleteSqlDataWhere(this.dataSetDamage.tJ_RequestForRepairAddress, string.Format(" WHERE idRequest = {0}", this.IdDocument.ToString()));
                this.InsertSqlData(this.dataSetDamage.tJ_RequestForRepairAddress);
            }
            else // полюбаса модификая - удалять ничего не нада
            {
                this.UpdateSqlData(this.dataSetDamage.tJ_RequestForRepairAddress);
                this.DeleteSqlData(this.dataSetDamage.tJ_RequestForRepairAddress);
            }
        }
        //this.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairAddress);
        //this.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairAddress);
        //this.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairAddress);
        this.dataSetDamage.tJ_RequestForRepairAddress.AcceptChanges();
    }

    private void EnableIsSendToSite()
    {
        if (!this.IsCrash)
        {
            if (this.eAction != eActionRequestRepair.Read)
            {
                if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count <= 0)
                {
                    this.chkSendToSite.Enabled = false;
                    return;
                }
                if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Agreed"] == DBNull.Value)
                {
                    this.chkSendToSite.Enabled = false;
                    return;
                }
                if (!Convert.ToBoolean(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Agreed"]))
                {
                    this.chkSendToSite.Enabled = false;
                    return;
                }
                if (this.dataSetDamage.tJ_RequestForRepair.Rows[0].RowState != DataRowState.Modified)
                {
                    if (this.dataSetDamage.tJ_RequestForRepair.Rows[0].RowState != DataRowState.Unchanged)
                    {
                        this.chkSendToSite.Enabled = true;
                        return;
                    }
                }
                if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["SendSite", DataRowVersion.Original] != DBNull.Value && Convert.ToBoolean(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["SendSite", DataRowVersion.Original]))
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
        //if (!this.chkSendToSite.Checked && !this.checkBoxAgreed.Checked) return;
        if (this.IsCrash)
        {
            try
            {
                UpLoadCrashToSite.CreateSettingsConnectFTP(this.SqlSettings);
                UpLoadCrashToSite.CreateHTMLCrashN2(this.SqlSettings, UpLoadCrashToSite.GetFullFileName(), DateTime.Now);
                UpLoadCrashToSite.StartProcessUpload();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        else
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

    private void toolBtnSettingsFTP_Click(object sender, EventArgs e)
    {
        new FormSettingsSender
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
        if (this.IdDocument == -1)
        {
            return;
        }
        DataTable dataTable = new DataTable("tJ_damage");
        dataTable.Columns.Add("id", typeof(int));
        base.SelectSqlData(dataTable, true, " where idReqForRepair = " + this.IdDocument.ToString() + " and deleted = 0", null, false, 0);
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
        if (this.IdDocument == -1)
        {
            return;
        }
        if (new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", this.IdDocument)).Rows.Count > 0)
        {
            this.buttonDaily.Enabled = false;
            this.dgvDaily.ReadOnly = true;
            this.checkBoxAgreed.Enabled = false;
        }
    }
    /// <summary>
    /// Создадим документ аварийного события
    /// </summary>
    /// <returns></returns>
    private bool CreateDocumentDamage()
    {
        if (this.IdDocument == -1) // не новый документ
        {
            return true;
        }
        if (!this.GetIsCrash()) // не плановая работа
        {
            return true;
        }
        DataSetDamage dataSetDamage = new DataSetDamage();
        base.SelectSqlData(dataSetDamage, dataSetDamage.tJ_Damage, true, "where idReqForRepair = " + this.IdDocument.ToString());
        base.SelectSqlData(dataSetDamage, dataSetDamage.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.IdDocument.ToString());
        if (this.checkBoxAgreed.Checked) // если согласовано
        {
            foreach (DataRow dataRow in dataSetDamage.tJ_Damage)
            {
                if (!Convert.ToBoolean(dataRow["Deleted"]) && dataSetDamage.tL_RequestForRepairSchmObjList.Select("idSchmObj = " + dataRow["idSchmObj"].ToString()).Length == 0)
                {
                    dataRow["deleted"] = true;
                    dataRow.EndEdit();
                    base.UpdateSqlData(dataSetDamage, dataSetDamage.tJ_Damage);
                    DataSetDamage dsDamage = new DataSetDamage();
                    base.SelectSqlData(dsDamage, dsDamage.tJ_Damage, true, "where idParent = " + dataRow["id"].ToString());
                    foreach (var row in dsDamage.tJ_Damage)
                    {
                        row["deleted"] = true;
                        row.EndEdit();
                        base.UpdateSqlData(dsDamage, dsDamage.tJ_Damage);
                    }
                }
            }
            base.SelectSqlData(dataSetDamage, dataSetDamage.tJ_Damage, true, "where idReqForRepair = " + this.IdDocument.ToString());
            foreach (DataRow dataRow2 in dataSetDamage.tL_RequestForRepairSchmObjList)
            {
                DataRow[] array = dataSetDamage.tJ_Damage.Select("idSchmObj = " + dataRow2["idSchmObj"].ToString());
                if (array.Length != 0)
                {
                    this.FillSubTablesDocumentDamage(array[0]);
                }
                else
                {
                    this.FillSubTablesDocumentDamage(Convert.ToInt32(dataRow2["idSchmObj"]));
                }
            }
        }
        return true;
    }
    /// <summary>
    /// №1. обновление таблиц документа аварии в подчиненных документах аварии
    /// по вносимой строке/записи
    /// </summary>
    private void FillSubTablesDocumentDamage(DataRow dataRowCureent)
    {
        if (dataRowCureent["isApply"] != DBNull.Value && Convert.ToBoolean(dataRowCureent["isApply"]))
        {
            return;
        }
        DataSetDamage dataSetDamage = new DataSetDamage();
        base.SelectSqlData(dataSetDamage, dataSetDamage.tJ_Damage, true, "where idParent = " + dataRowCureent["id"].ToString());
        bool flag = false;
        foreach (DataRow dataRow in dataSetDamage.tJ_Damage)
        {
            if (dataRow["isApply"] != DBNull.Value && Convert.ToBoolean(dataRow["isApply"]))
            {
                flag = true;
            }
        }
        if (flag)
        {
            return;
        }
        dataRowCureent["Deleted"] = 0;
        dataRowCureent["dateDoc"] = this.dataSetDamage.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
        this.FillSubTablesDocumentDamageForCommentXml(dataRowCureent, Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]), Convert.ToInt32(dataRowCureent["idSchmObj"]));
        dataRowCureent.EndEdit();
        base.UpdateSqlDataOnlyChange(dataRowCureent.Table);
        foreach (var row in dataSetDamage.tJ_Damage)
        {
            row["dateDoc"] = this.dataSetDamage.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
            row.EndEdit();
        }
        base.UpdateSqlData(dataSetDamage.tJ_Damage);
        this.FillSubTablesDocumentDamage2(Convert.ToInt32(dataRowCureent["id"]), Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]), Convert.ToInt32(dataRowCureent["idSchmObj"]));
    }
    /// <summary>
    /// №2. создание документа аварии и заполнение подчиненных таблиц
    /// если есть id  объекта схемы, то создается документ аварии
    /// </summary>
    private void FillSubTablesDocumentDamage(int idSchmObj)
    {
        DataSetDamage dataSetDamage = new DataSetDamage();
        DataRow dataRow = dataSetDamage.tJ_Damage.NewRow();
        dataRow["TypeDoc"] = this.dataSetDamage.tJ_RequestForRepair.Rows[0]["idTypeDamage"];
        dataRow["Deleted"] = 0;
        dataRow["dateDoc"] = this.dataSetDamage.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
        dataRow["idSchmObj"] = idSchmObj;
        dataRow["idReqForRepair"] = this.IdDocument;
        dataRow["is81"] = false;
        this.FillSubTablesDocumentDamageForCommentXml(dataRow, Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]), idSchmObj);
        dataSetDamage.tJ_Damage.Rows.Add(dataRow);
        int idDamage = base.InsertSqlDataOneRow(dataSetDamage, dataSetDamage.tJ_Damage);
        if (idDamage > 0)
        {
            this.FillSubTablesDocumentDamage2(idDamage, Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]), idSchmObj);
        }
    }
    /// <summary>
    /// формируем список отключенных абонентов, трансформаторов, подстанций, комментариев
    /// формируем xml для поля комментариев
    /// </summary>
    private void FillSubTablesDocumentDamageForCommentXml(DataRow dataRowCureent, DateTime dateStatusOperational, int idSchmObj)
    {
        int idTypeDamage = Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["idTypeDamage"]);
        if (this.eModelStateOperational == null || this.eModelStateOperational.Objects.Count<ElectricObject>() == 0)
        {
            this.eModelStateOperational = new ElectricModel();
            this.eModelStateOperational.SqlSettings = this.SqlSettings;
            this.eModelStateOperational.LoadSchema(dateStatusOperational);
        }
        TreeNodeObj treeNodeObj_ = this.eModelStateOperational.PoweringReportForDrawObject(idSchmObj, true);
        // трансформаторы - отключенные
        List<int> listTrans = new List<int>();
        FormJournalRequestForRepairAddEditCrash.FillTreeNodeTrans(treeNodeObj_, listTrans);
        //if (idTypeDamage == (int)eTypeDocuments.DamageHV)
        //{
            DataTable dataTable_ = FormJournalRequestForRepairAddEditCrash.FillTableTransOff(listTrans, new StaticFormData { Sqlsettings = this.SqlSettings, eForm = this });
            this.AppendChildTransOff(dataRowCureent, dataTable_, treeNodeObj_);
        //}
        // абоненты - отключенные
        DataTable dataTable = new DataTable("vl_schmAbnFull");
        dataTable.Columns.Add("idAbn", typeof(int));
        dataTable.Columns.Add("idAbnObj", typeof(int));
        var source = from obj in this.eModelStateOperational.Objects
                                             where obj.Id == idSchmObj
                                             select obj;
        List<ElectricObject> listElectricObj = this.eModelStateOperational.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
        if (listElectricObj.Count > 0)
        {
            string text = "";
            foreach (ElectricObject electricObject in listElectricObj)
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
            new SqlDataCommand(this.SqlSettings).SelectSqlData(dataTable, true, " where idSchmObj in (" + text + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
        }
        else
        {
            dataTable.Clear();
        }
        this.AppendChildCommentXml(dataRowCureent, dataTable);
    }
    /// <summary>
    /// №2. заполнение таблиц в подчиненных документах аварии
    /// формируем список коэффициентов и прочих второстепенных полей
    /// </summary>
    private void FillSubTablesDocumentDamage2(int idDamage, DateTime dateStatusOperational, int idSchmObj)
    {
        int idTypeDamage = Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["idTypeDamage"]);

        RequestForRepairN.DataSets.DataSetDamage dataSetDamage = new RequestForRepairN.DataSets.DataSetDamage();
        if (idTypeDamage == (int)eTypeDocuments.DamageHV)
        {
            base.SelectSqlData(dataSetDamage.tJ_DamageHV, true, "where idDamage = " + idDamage.ToString(), null, false, 0);
            DataRow dataRow;
            if (dataSetDamage.tJ_DamageHV.Rows.Count > 0)
            {
                dataRow = dataSetDamage.tJ_DamageHV.Rows[0];
            }
            else
            {
                dataRow = dataSetDamage.tJ_DamageHV.NewRow();
                dataRow["idDamage"] = idDamage;
            }
            if (this.eModelStateOperational == null || this.eModelStateOperational.Objects.Count<ElectricObject>() == 0)
            {
                this.eModelStateOperational = new ElectricModel();
                this.eModelStateOperational.SqlSettings = this.SqlSettings;
                this.eModelStateOperational.LoadSchema(dateStatusOperational);
            }
            TreeNodeObj treeNodeObj_ = this.eModelStateOperational.PoweringReportForDrawObject(idSchmObj, true);
            // трансформаторы - отключенные
            List<int> listTrans = new List<int>();
            FormJournalRequestForRepairAddEditCrash.FillTreeNodeTrans(treeNodeObj_, listTrans);
            DataTable dataTable = FormJournalRequestForRepairAddEditCrash.FillTableTransOff(listTrans, new StaticFormData { Sqlsettings = this.SqlSettings, eForm = this });
            // коэффициенты
            dataRow["countSchmObj"] = dataTable.Rows.Count;
            dataRow["countSchmObjOff"] = 0;
            dataRow["ConnectedPower"] = dataTable.Compute("Sum(Power)", "");
            dataRow["PowerA"] = dataTable.Compute("Sum(Load)", "");
            if (dataRow["CoefFI"] == DBNull.Value)
            {
                dataRow["CoefFI"] = 0.9;
            }
            if (dataRow["CoefSeason"] == DBNull.Value)
            {
                dataRow["CoefSeason"] = 0.8;
            }
            if (dataSetDamage.tJ_DamageHV.Rows.Count > 0)
            {
                dataRow.EndEdit();
                base.UpdateSqlDataOnlyChange(dataSetDamage.tJ_DamageHV);
            }
            else
            {
                dataSetDamage.tJ_DamageHV.Rows.Add(dataRow);
                base.InsertSqlData(dataSetDamage.tJ_DamageHV);
            }
        }
        if (idTypeDamage == (int)eTypeDocuments.DamageLV)
        {
            base.SelectSqlData(dataSetDamage.tJ_DamageLV, true, "where idDamage = " + idDamage.ToString(), null, false, 0);
            DataRow dataRow2;
            if (dataSetDamage.tJ_DamageLV.Rows.Count > 0)
            {
                dataRow2 = dataSetDamage.tJ_DamageLV.Rows[0];
            }
            else
            {
                dataRow2 = dataSetDamage.tJ_DamageLV.NewRow();
                dataRow2["idDamage"] = idDamage;
            }
            if (dataSetDamage.tJ_DamageLV.Rows.Count > 0)
            {
                dataRow2.EndEdit();
                base.UpdateSqlDataOnlyChange(dataSetDamage.tJ_DamageLV);
                return;
            }
            dataSetDamage.tJ_DamageLV.Rows.Add(dataRow2);
            base.InsertSqlData(dataSetDamage.tJ_DamageLV);
        }
    }
    /// <summary>
    /// Заполнить дерево трансформаторами попавшими под отключение
    /// </summary>
    private static void FillTreeNodeTrans(TreeNodeObj treeNodeObj, List<int> listTrans)
    {
        if (treeNodeObj.Tag != null && treeNodeObj.Tag is ElectricLine)
        {
            foreach (ElectricRelation electricRelation in ((ElectricLine)treeNodeObj.Tag).Relations)
            {
                foreach (ElectricObject electricObject in electricRelation.ChildObjects)
                {
                    if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && !listTrans.Contains(electricObject.Id))
                    {
                        listTrans.Add(electricObject.Id);
                    }
                }
            }
        }
        foreach (TreeNodeObj Obj in treeNodeObj.Nodes)
        {
            FormJournalRequestForRepairAddEditCrash.FillTreeNodeTrans(Obj, listTrans);
        }
    }
    /// <summary>
    /// Заполнить таблицу отключенных трансформаторов
    /// расчет нагрузки и мощности
    /// </summary>
    private static DataTable FillTableTransOff(List<int> listTrans, StaticFormData Me)
    {
        DataTable dataTableResult = new DataTable();
        dataTableResult.Columns.Add("idSub", typeof(int));
        dataTableResult.Columns.Add("Sub", typeof(string));
        dataTableResult.Columns.Add("idTr", typeof(int));
        dataTableResult.Columns.Add("TrName", typeof(string));
        dataTableResult.Columns.Add("Power", typeof(int));
        dataTableResult.Columns.Add("load", typeof(int));
        //dataTableResult.Columns.Add("Voltage", typeof(string));
        dataTableResult.Clear();
        using (SqlConnection sqlConnection = new SqlConnection(Me.Sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
        {
            sqlConnection.Open();
            using (SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(Me.eForm.GetType(), "RequestForRepairN.GetTransformerSchmObj.sql"), sqlConnection))
            {
                sqlCommand.CommandTimeout = 0;
                DataTable dataTableTransformerSchmObj = new DataTable();
                new SqlDataAdapter(sqlCommand).Fill(dataTableTransformerSchmObj);
                int Power = 0;
                foreach (int idTrans in listTrans)
                {
                    DataRow[] array = dataTableTransformerSchmObj.Select("id = " + idTrans.ToString());
                    if (array.Length != 0)
                    {
                        DataRow dataRow = dataTableResult.NewRow();
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
                        //dataRow["Voltage"] = "";
                        dataTableResult.Rows.Add(dataRow);
                    }
                }
            }
            using (SqlCommand sqlCommand2 = new SqlCommand("SELECT mat.idbus, mat.[IdObjList],\r\n                        \t(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) \r\n                        \t then max([Ia]) \telse case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) \r\n                        \t\t\t\t\t                                else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) \r\n                        \t\t\t\t\t                                then max([Ic]) end end end) as I\r\n                         FROM [tJ_MeasAmperageTransf] as mat\r\n                               inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                          where  mat.deleted = 0 and m.[TypeDoc] = 1192\r\n                        \tand ((year(m.[DateD]) = \r\n                        \t\t\t(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \t\t\t\t\telse year(max(dateD)) end from tj_measurement mes \r\n                        \t\t\tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \t\t\t where mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\t\r\n                        \t\t\t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)\r\n                                      and month(m.[DateD]) between 1 and 11)\t\r\n                           or (year(m.[DateD]) =(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \telse year(max(dateD)) end\r\n                        \tfrom tj_measurement mes \r\n                        \tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \twhere mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\r\n                        \t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)-1 and month(m.[DateD])=12)) \r\n                            and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                          group by mat.idBus,  mat.[idObjList]", sqlConnection))
            {
                sqlCommand2.CommandTimeout = 0;
                DataTable dataTableTransformerLoad = new DataTable();
                new SqlDataAdapter(sqlCommand2).Fill(dataTableTransformerLoad);
                foreach (DataRow dataRow2 in dataTableResult.Rows)
                {
                    DataRow[] array2 = dataTableTransformerLoad.Select("idObjList = " + dataRow2["idTr"].ToString());
                    if (array2.Length != 0)
                    {
                        dataRow2["Load"] = array2[0]["I"];
                    }
                }
            }
        }
        return dataTableResult;
    }
    /// <summary>
    /// Сохранение xml-данных отключенных трнасформатора и подстанций
    /// AppendChildTransOff();
    /// </summary>
    private void AppendChildTransOff(DataRow dataRow, DataTable table, TreeNodeObj node)
    {
        XmlDocument xmlDocument = new XmlDocument();
        if (dataRow["CommentXml"] != DBNull.Value)
        {
            try
            {
                xmlDocument.LoadXml(dataRow["CommentXml"].ToString());
            }
            catch
            {
            }
        }
        XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
        if (xmlNode == null)
        {
            xmlNode = xmlDocument.CreateElement("Doc");
            xmlDocument.AppendChild(xmlNode);
        }
        XmlNode xmlNode2 = xmlNode.SelectSingleNode("TransOff");
        if (xmlNode2 != null)
        {
            xmlNode2.RemoveAll();
        }
        else
        {
            xmlNode2 = xmlDocument.CreateElement("TransOff");
            xmlNode.AppendChild(xmlNode2);
        }
        foreach (DataRow row in table.Rows)
        {
            XmlNode xmlNode3 = xmlDocument.CreateElement("Row");
            xmlNode2.AppendChild(xmlNode3);
            XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idSub");
            xmlAttribute.Value = row["idSub"].ToString();
            xmlNode3.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("idTr");
            xmlAttribute.Value = row["idTr"].ToString();
            xmlNode3.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("Power");
            xmlAttribute.Value = row["Power"].ToString();
            xmlNode3.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("Load");
            xmlAttribute.Value = row["Load"].ToString();
            xmlNode3.Attributes.Append(xmlAttribute);
        }
        this.listElectricBus = new List<int>();
        XmlNode xmlNode4 = xmlDocument.CreateElement("TransTree");
        xmlNode2.AppendChild(xmlNode4);
        this.AppendChildSubOff(xmlNode4, node, table, null);
        dataRow["CommentXml"] = xmlDocument.InnerXml;
    }
    /// <summary>
    /// Заполнить дерево подстанциями попавшими под отключение
    /// </summary>
    private void AppendChildSubOff(XmlNode xml, TreeNodeObj treeNodeObj, DataTable table, XmlNode node = null)
    {
        if (xml != null && xml.OwnerDocument != null)
        {
            XmlDocument ownerDocument = xml.OwnerDocument;
            if (treeNodeObj.Tag != null)
            {
                if (treeNodeObj.Tag is ElectricBus)
                {
                    if (this.listElectricBus.Contains(((ElectricBus)treeNodeObj.Tag).Id))
                    {
                        return;
                    }
                    this.listElectricBus.Add(((ElectricBus)treeNodeObj.Tag).Id);
                }
                if (treeNodeObj.Tag is ElectricLine)
                {
                    ElectricLine electricLine = (ElectricLine)treeNodeObj.Tag;
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
                            XmlNode xmlNode;
                            if (node != null)
                            {
                                xmlNode = node;
                            }
                            else
                            {
                                xmlNode = xml;
                            }
                            XmlNode xmlNodeDgv = ownerDocument.CreateElement("NodeDgv");
                            xmlNode.AppendChild(xmlNodeDgv);
                            this.AppendChildNodeSubOff(xmlNodeDgv, electricBus.Parent.ToString(), electricBus.Parent.Id.ToString(), electricBus.ToString(), electricBus.Id.ToString(), electricLine.ToString(), electricLine.Id.ToString(), "", "", "");
                            node = xmlNodeDgv;
                        }
                    }
                    foreach (ElectricRelation electricRelation in ((ElectricLine)treeNodeObj.Tag).Relations)
                    {
                        foreach (ElectricObject electricObject in electricRelation.ChildObjects)
                        {
                            if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && node != null)
                            {
                                if (node.Attributes["idTr"] != null && !string.IsNullOrEmpty(node.Attributes["idTr"].Value))
                                {
                                    XmlNode xmlNodeDgv = ownerDocument.CreateElement("NodeDgv");
                                    node.ParentNode.AppendChild(xmlNodeDgv);
                                    this.AppendChildNodeSubOff(xmlNodeDgv, node.Attributes["SubName"].Value, node.Attributes["idSub"].Value, node.Attributes["BusName"].Value, node.Attributes["idBus"].Value, node.Attributes["CellName"].Value, node.Attributes["idCell"].Value, "", "", "");
                                    node = xmlNodeDgv;
                                }
                                DataRow[] array = table.Select("idTr = " + electricObject.Id.ToString());
                                int? power = null;
                                int? load = null;
                                if (array.Length != 0)
                                {
                                    if (array[0]["power"] != DBNull.Value)
                                    {
                                        power = new int?(Convert.ToInt32(array[0]["power"]));
                                    }
                                    if (array[0]["load"] != DBNull.Value)
                                    {
                                        load = new int?(Convert.ToInt32(array[0]["load"]));
                                    }
                                }
                                if (power != null)
                                {
                                    XmlAttribute xmlAttribute;
                                    if (node.Attributes["Power"] == null)
                                    {
                                        xmlAttribute = ownerDocument.CreateAttribute("Power");
                                        node.Attributes.Append(xmlAttribute);
                                    }
                                    else
                                    {
                                        xmlAttribute = node.Attributes["Power"];
                                    }
                                    if (string.IsNullOrEmpty(xmlAttribute.Value))
                                    {
                                        xmlAttribute.Value = power.ToString();
                                    }
                                    else
                                    {
                                        xmlAttribute.Value = (Convert.ToInt32(xmlAttribute.Value) + power).ToString();
                                    }
                                }
                                if (load != null)
                                {
                                    XmlAttribute xmlAttribute2;
                                    if (node.Attributes["Load"] == null)
                                    {
                                        xmlAttribute2 = ownerDocument.CreateAttribute("Load");
                                        node.Attributes.Append(xmlAttribute2);
                                    }
                                    else
                                    {
                                        xmlAttribute2 = node.Attributes["Load"];
                                    }
                                    if (string.IsNullOrEmpty(xmlAttribute2.Value))
                                    {
                                        xmlAttribute2.Value = load.ToString();
                                    }
                                    else
                                    {
                                        xmlAttribute2.Value = (Convert.ToInt32(xmlAttribute2.Value) + load).ToString();
                                    }
                                }
                                XmlAttribute xmlAttribute3;
                                if (node.Attributes["idTr"] == null)
                                {
                                    xmlAttribute3 = ownerDocument.CreateAttribute("idTr");
                                    node.Attributes.Append(xmlAttribute3);
                                }
                                else
                                {
                                    xmlAttribute3 = node.Attributes["idTr"];
                                }
                                XmlAttribute xmlAttribute4;
                                if (node.Attributes["TrName"] == null)
                                {
                                    xmlAttribute4 = ownerDocument.CreateAttribute("TrName");
                                    node.Attributes.Append(xmlAttribute4);
                                }
                                else
                                {
                                    xmlAttribute4 = node.Attributes["TrName"];
                                }
                                if (string.IsNullOrEmpty(xmlAttribute3.Value))
                                {
                                    xmlAttribute3.Value = electricObject.Id.ToString();
                                }
                                else
                                {
                                    XmlAttribute xmlAttribute5 = xmlAttribute3;
                                    xmlAttribute5.Value = xmlAttribute5.Value + ";" + electricObject.Id.ToString();
                                }
                                if (string.IsNullOrEmpty(xmlAttribute4.Value))
                                {
                                    xmlAttribute4.Value = electricObject.ToString();
                                }
                                else
                                {
                                    XmlAttribute xmlAttribute6 = xmlAttribute4;
                                    xmlAttribute6.Value = xmlAttribute6.Value + ";" + electricObject.ToString();
                                }
                            }
                        }
                    }
                }
            }
            foreach (TreeNodeObj treeNodeObj_ in treeNodeObj.Nodes)
            {
                this.AppendChildSubOff(xml, treeNodeObj_, table, node);
            }
            return;
        }
    }
    /// <summary>
    /// соберем данные для для формирования записи/узел  отключенного рубильника/ячейки подстанции
    /// </summary>
    private void AppendChildNodeSubOff(XmlNode xmlNodeDgv, string SubName, string idSub, string BusName, string idBus, string CellName, string idCell, string s1 = "", string s2 = "", string s3 = "")
    {
        if (xmlNodeDgv != null && xmlNodeDgv.OwnerDocument != null)
        {
            XmlDocument ownerDocument = xmlNodeDgv.OwnerDocument;
            XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("SubName");
            xmlAttribute.Value = SubName;
            xmlNodeDgv.Attributes.Append(xmlAttribute);
            xmlAttribute = ownerDocument.CreateAttribute("idSub");
            xmlAttribute.Value = idSub;
            xmlNodeDgv.Attributes.Append(xmlAttribute);
            xmlAttribute = ownerDocument.CreateAttribute("BusName");
            xmlAttribute.Value = BusName;
            xmlNodeDgv.Attributes.Append(xmlAttribute);
            xmlAttribute = ownerDocument.CreateAttribute("idBus");
            xmlAttribute.Value = idBus;
            xmlNodeDgv.Attributes.Append(xmlAttribute);
            xmlAttribute = ownerDocument.CreateAttribute("CellName");
            xmlAttribute.Value = CellName;
            xmlNodeDgv.Attributes.Append(xmlAttribute);
            xmlAttribute = ownerDocument.CreateAttribute("idCell");
            xmlAttribute.Value = idCell;
            xmlNodeDgv.Attributes.Append(xmlAttribute);
            return;
        }
    }
    /// <summary>
    /// сохраним xml-данные - CommentXml
    /// </summary>
    private void AppendChildCommentXml(DataRow row, DataTable table)
    {
        XmlDocument xmlDocument = new XmlDocument();
        if (row["CommentXml"] != DBNull.Value)
        {
            try
            {
                xmlDocument.LoadXml(row["CommentXml"].ToString());
            }
            catch
            {
            }
        }
        XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
        if (xmlNode == null)
        {
            xmlNode = xmlDocument.CreateElement("Doc");
            xmlDocument.AppendChild(xmlNode);
        }
        XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
        if (xmlNode2 != null)
        {
            xmlNode2.RemoveAll();
        }
        else
        {
            xmlNode2 = xmlDocument.CreateElement("AbnOff");
            xmlNode.AppendChild(xmlNode2);
        }
        foreach (DataRow dataRow in table.Rows)
        {
            if (dataRow.RowState != DataRowState.Deleted)
            {
                XmlNode xmlNode3 = xmlDocument.CreateElement("Row");
                xmlNode2.AppendChild(xmlNode3);
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idAbnObj");
                xmlAttribute.Value = dataRow["idAbnObj"].ToString();
                xmlNode3.Attributes.Append(xmlAttribute);
            }
        }
        this.AppendChildCountPoint(xmlNode2, table);
        this.AppendChildCountAbnObj(xmlNode2, table);
        row["CommentXml"] = xmlDocument.InnerXml;
    }
    /// <summary>
    /// Сохранение в документе узла CountPoint (количество точек поставки)
    /// </summary>
    private void AppendChildCountPoint(XmlNode xml, DataTable table)
    {
        try
        {
            int numCountPointCat1Full = 0;
            int numCountPointCat2Full = 0;
            int numCountPointSource = 0;
            int numCountPointCat1 = 0;
            int numCountPointCat2 = 0;
            int numCountPointCat3 = 0;
            int numCountPointEE = 0;
            if (table.Rows.Count > 0)
            {
                string text = "";
                foreach (DataRow dataRow in table.Rows)
                {
                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        if (string.IsNullOrEmpty(text))
                        {
                            text = dataRow["idAbnObj"].ToString();
                        }
                        else
                        {
                            text = text + "," + dataRow["idAbnObj"].ToString();
                        }
                    }
                }
                DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select ao.id,\r\n                                        case when a.TypeAbn = 231 then -1 -- сетевая организация\r\n                                        else case when a.typeAbn = 206 and r.category is null then 493 -- если у физика нет категории - ставим ему третью\r\n                                        else case when category is null then 493 else r.category end end end as category\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                        left join tPoint p on p.idAbnObj = ao.id and p.dateBegin <= '{0}' and \r\n                                                                (p.dateEnd  >= '{0}' or p.dateEnd is null)\r\n\t                                    /*left join tPointReg pReg on pReg.id = (select top 1 id from tPointReg\r\n\t\t\t\t\t\t\t\t\t\t                                      where idPoint = p.id \r\n\t\t\t\t\t\t\t\t\t\t\t                        and dateBegin <= '{0}' and \r\n                                                                    (dateEnd  >= '{0}' or dateEnd is null)\r\n\t\t\t\t\t\t\t\t\t                                order by dateBegin desc)*/\r\n                                     where ao.id in ({1}) \r\n                                        --and p.id is not null and pREg.id is not null", Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]).ToString("yyyyMMdd"), text));
                numCountPointCat1 = Convert.ToInt32(dataTable.Compute("count(id)", "category in (491,494)"));
                numCountPointCat2 = Convert.ToInt32(dataTable.Compute("count(id)", "category = 492"));
                numCountPointCat3 = Convert.ToInt32(dataTable.Compute("count(id)", "category = 493"));
                numCountPointEE = Convert.ToInt32(dataTable.Compute("count(id)", "category = -1"));
            }
            if (xml != null && xml.OwnerDocument != null)
            {
                XmlDocument ownerDocument = xml.OwnerDocument;
                XmlNode xmlNode = ownerDocument.CreateElement("CountPoint");
                xml.AppendChild(xmlNode);
                XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("countPointCat1");
                xmlAttribute.Value = numCountPointCat1.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointCat1Full");
                xmlAttribute.Value = numCountPointCat1Full.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointCat2");
                xmlAttribute.Value = numCountPointCat2.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointCat2Full");
                xmlAttribute.Value = numCountPointCat2Full.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointCat3");
                xmlAttribute.Value = numCountPointCat3.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointEE");
                xmlAttribute.Value = numCountPointEE.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointSource");
                xmlAttribute.Value = numCountPointSource.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    /// <summary>
    /// Загрузка в документе узла CountAbnObj (количество объектов абонентов)
    /// </summary>
    private void AppendChildCountAbnObj(XmlNode xml, DataTable table)
    {
        try
        {
            int numCountAbnObjCat1 = 0;
            int numCountAbnObjCat2 = 0;
            int numCountAbnObjCat3 = 0;
            int numCountAbnObjEE = 0;
            int numCountAbnObjSource = 0;
            int numCountAbnObj150 = 0;
            int numCountAbnObj150670 = 0;
            int numCountAbnObj670 = 0;
            if (table.Rows.Count > 0)
            {
                string text = "";
                foreach (DataRow dataRow in table.Rows)
                {
                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        if (string.IsNullOrEmpty(text))
                        {
                            text = dataRow["idAbnObj"].ToString();
                        }
                        else
                        {
                            text = text + "," + dataRow["idAbnObj"].ToString();
                        }
                    }
                }
                SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
                DataTable dataTable = sqlDataCommand.SelectSqlData("select ao.id,\r\n                                        case when a.TypeAbn = 231 then -1 -- сетевая организация\r\n                                        else case when a.typeAbn = 206 and r.category is null then 493 -- если у физика нет категории - ставим ему третью\r\n                                        else case when category is null then 493 else r.category end end end as category\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                     where ao.id in (" + text + ")");
                numCountAbnObjCat1 = Convert.ToInt32(dataTable.Compute("count(id)", "category in (491,494)"));
                numCountAbnObjCat2 = Convert.ToInt32(dataTable.Compute("count(id)", "category = 492"));
                numCountAbnObjCat3 = Convert.ToInt32(dataTable.Compute("count(id)", "category = 493"));
                numCountAbnObjEE = Convert.ToInt32(dataTable.Compute("count(id)", "category = -1"));
                DataTable dataTable2 = sqlDataCommand.SelectSqlData("select ao.id,\r\n                                         case when a.TypeAbn = 206 or r.PowerSEt is null then 15\r\n                                        \telse r.PowerSEt end PowerSEt\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                     where ao.id in (" + text + ")");
                numCountAbnObj150 = Convert.ToInt32(dataTable2.Compute("count(id)", "PowerSet <= 150"));
                numCountAbnObj150670 = Convert.ToInt32(dataTable2.Compute("count(id)", "PowerSet > 150 and PowerSet <= 670"));
                numCountAbnObj670 = Convert.ToInt32(dataTable2.Compute("count(id)", "PowerSet > 670"));
            }

            if (xml != null && xml.OwnerDocument != null)
            {
                XmlDocument ownerDocument = xml.OwnerDocument;
                XmlNode xmlNode = ownerDocument.CreateElement("CountAbnObj");
                xml.AppendChild(xmlNode);
                XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat1");
                xmlAttribute.Value = numCountAbnObjCat1.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat1Full");
                xmlAttribute.Value = "0";
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat2");
                xmlAttribute.Value = numCountAbnObjCat2.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat2Full");
                xmlAttribute.Value = "0";
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat3");
                xmlAttribute.Value = numCountAbnObjCat3.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjEE");
                xmlAttribute.Value = numCountAbnObjEE.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjSource");
                xmlAttribute.Value = numCountAbnObjSource.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObj150");
                xmlAttribute.Value = numCountAbnObj150.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObj150670");
                xmlAttribute.Value = numCountAbnObj150670.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObj670");
                xmlAttribute.Value = numCountAbnObj670.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    /// <summary>
    /// Вернуть отключенных абонентов
    /// </summary>
    private static XmlDocument GetTableDisabledAbnObj(DataTable table)
    {
        XmlDocument xmlDocument = new XmlDocument();
        XmlNode xmlNode = xmlDocument.CreateElement("AbnOff");
        xmlDocument.AppendChild(xmlNode);
        foreach (DataRow dataRow in table.Rows)
        {
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

    private void GetStatusRequest()
    {
        this.dictionaryStatusRequest = new Dictionary<int, string>();
        this.dictionaryStatusRequest.Add(1, "Создана");
        this.dictionaryStatusRequest.Add(2, "Согласована");
        this.dictionaryStatusRequest.Add(3, "Отправлена на сайт");
        this.dictionaryStatusRequest.Add(104, "Зарегистрирована");
        this.dictionaryStatusRequest.Add(105, "Отменена");
        this.dictionaryStatusRequest.Add(106, "В работе");
        this.dictionaryStatusRequest.Add(7, "Перенесено время работы");
        this.dictionaryStatusRequest.Add(107, "Перенесено время работы");
        this.dictionaryStatusRequest.Add(108, "Выполнена");
    }
    /// <summary>
    /// получить данные логирования
    /// </summary>
    private void SelectLogFromTableRequestForRepairLog()
    {
        if (this.IdDocument > 0)
        {
            base.SelectSqlData(this.dataSetDamage.tJ_RequestForRepairLog, true, "where idRequest = " + this.IdDocument.ToString(), null, false, 0);
        }
    }
    /// <summary>
    /// перенос данных логирования в базу данных
    /// </summary>
    private void InsertLogToTableRequestForRepairLog()
    {
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count == 0)
        {
            return;
        }
        DataTable tJ_RequestForRepairLog = this.dataSetDamage.tJ_RequestForRepairLog;
        DataRow[] array = tJ_RequestForRepairLog.Select("idCommand = 108");
        if (array.Length != 0)
        {
            return;
        }
        DataTable dataTableUser = new DataTable("tUser");
        DataRow dataRow = this.dataSetDamage.tJ_RequestForRepair.Rows[0];
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
            foreach (DataRow dataRow2 in this.dataSetDamage.tJ_RequestForRepairDaily)
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
        base.InsertSqlData(this.dataSetDamage.tJ_RequestForRepairLog);
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
    /// <summary>
    /// формирование данных логирования
    /// </summary>
    private void AddRowTableLogUser(DataTable dataTableUser, int idCommand)
    {
        if (dataTableUser.Rows.Count == 0)
        {
            base.SelectSqlData(dataTableUser, true, "where [Login] = SYSTEM_USER", null, false, 0);
        }
        DataRow dataRow = this.dataSetDamage.tJ_RequestForRepairLog.NewRow();
        dataRow["idRequest"] = this.IdDocument;
        dataRow["dateLog"] = DateTime.Now;
        if (dataTableUser.Rows.Count > 0)
        {
            dataRow["userLogId"] = dataTableUser.Rows[0]["idUser"];
            dataRow["userLog"] = dataTableUser.Rows[0]["Login"];
            if (dataTableUser.Rows[0]["name"] != DBNull.Value)
            {
                dataRow["userLogName"] = dataTableUser.Rows[0]["name"];
            }
        }
        dataRow["idCommand"] = idCommand;
        if (this.dictionaryStatusRequest.ContainsKey(idCommand))
        {
            dataRow["Command"] = this.dictionaryStatusRequest[idCommand];
        }
        if (idCommand > 100)
        {
            dataRow["isSite"] = true;
        }
        else
        {
            dataRow["isSite"] = false;
        }
        this.dataSetDamage.tJ_RequestForRepairLog.Rows.Add(dataRow);
    }

    #region делаем вкладки для отключенных абонентов и трансформаторов


    #endregion

    private void toolBtnRefreshTrans_Click(object sender, EventArgs e)
    {
        this.RefreshTable();
    }

    private void toolBtnRefreshAbn_Click(object sender, EventArgs e)
    {
        this.RefreshTable();
    }

    private void toolBtnRefreshCountAbn_Click(object sender, EventArgs e)
    {
        this.CalculationCountPoints();
        this.CalculationCountConsumersAndMaximumPower();
    }
#region блок работы с отключенными подстанциями
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
    private delegate TreeDataGridViewNode TreeParametrSub(TreeDataGridViewNodeCollection nodes, params object[] values);
    /// <summary>
    /// Добавление параметров в дерево отключенных подстанций 
    /// </summary>
    private TreeDataGridViewNode AddTreeParametrSub(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection, params object[] values)
    {
        if (this.dgvTreeSub.InvokeRequired)
        {
            return (TreeDataGridViewNode)this.dgvTreeSub.Invoke(new TreeParametrSub(this.AddTreeParametrSub), new object[]
            {
                treeDataGridViewNodeCollection,
                values
            });
        }
        return treeDataGridViewNodeCollection.Add(values);
    }
    /// <summary>
    /// вернуть тип подстанции
    /// </summary>
    //string GetTypeSubstation(SchemeModel.eTypeRectangleTool typesub)
    //{
    //    switch (typesub)
    //    {
    //        case eTypeRectangleTool.TP:
    //            return "ТП";
    //        case eTypeRectangleTool.RP:
    //            return "РП";
    //        default:
    //            return "ПС";
    //    }
    //}
    ///// <summary>
    ///// вернуть напряжение
    ///// </summary>
    //string GetVoltageObject(eTypeShinaTool TypeBus)
    //{
    //    switch (TypeBus)
    //    {
    //        case eTypeShinaTool.Shina_04:
    //            return "0,4";
    //        case eTypeShinaTool.Shina_023:
    //            return "0,23";
    //        case eTypeShinaTool.None:
    //            return "0";
    //        case eTypeShinaTool.Shina_10:
    //            return "10";
    //        case eTypeShinaTool.Shina_6:
    //            return "6";
    //        default:
    //            return TypeBus.ToString().Replace("Shina_", "");
    //    }
    //}
    /// <summary>
    /// Очистка таблицы отключенных абонентов
    /// </summary>
    private void dgvTreeNodesAbnClear()
    {
        if (this.dgvAbn.InvokeRequired)
        {
            this.dgvAbn.Invoke(new MethodInvoker(this.dgvTreeNodesAbnClear));
            return;
        }
        this.dgvAbn.Nodes.Clear();
    }
    private delegate TreeDataGridViewNode TreeParametrAbn(TreeDataGridViewNodeCollection nodes, params object[] values);
    /// <summary>
    /// Добавление параметров в дерево отключенных абонентов 
    /// </summary>
    private TreeDataGridViewNode AddTreeParametrAbn(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection, params object[] values)
    {
        if (this.dgvAbn.InvokeRequired)
        {
            return (TreeDataGridViewNode)this.dgvAbn.Invoke(new TreeParametrAbn(this.AddTreeParametrAbn), new object[]
            {
                treeDataGridViewNodeCollection,
                values
            });
        }
        return treeDataGridViewNodeCollection.Add(values);
    }
    /// <summary>
    /// Заполнить дерево (dgvTreeAbn) объектов абонентов попавшими под отключение
    /// </summary>
    /// <param name="SubNodeTree">формируемое дерево в гриде</param>
    /// <param name="RootNodeObj">передаваемое дерево </param>
    private void FillTableAbnOff(TreeDataGridViewNode SubNodeTree = null)
    {
        if (tableSchmAbnFull.Rows.Count == 0) return;
        int? idSity = null;
        int? idStreet = null;
        string idHouse = null;
        var result = from r in tableSchmAbnFull.AsEnumerable()
                     orderby r["KladrObjid"], r["idStreet"], r["house"].ToString()
                     select r;
        TreeDataGridViewNode SubNodeTreeSity = null;
        TreeDataGridViewNode SubNodeTreeStreet = null;
        TreeDataGridViewNode SubNodeTreeHouse = null;

        foreach (DataRow row in result)
        {
            // соберем названия города и улицы
            DataRow[] arrayObj = this.tableKladrObj.Select("id = " + row["KladrObjid"].ToString());
            string City = arrayObj.Length != 0 ? arrayObj[0]["name"].ToString() + " " + arrayObj[0]["socr"].ToString() : "";

            DataRow[] arrayStreet = this.tablelKladrStreet.Select("id = " + row["idStreet"].ToString());
            string Street = arrayStreet.Length != 0 ? arrayStreet[0]["name"].ToString() + " " + arrayStreet[0]["socr"].ToString() : "";

            // соберем сначало узлы
            if (idSity != (int)row["KladrObjid"])
            {
                idSity = (int)row["KladrObjid"];
                SubNodeTreeSity = this.AddTreeParametrAbn(this.dgvAbn.Nodes, new object[] { City });
                SubNodeTreeSity.Cells[this.kladrObjIdDataGridViewTextBoxColumn.Index].Value = row["kladrObjId"];
            }

            if (idStreet != (int)row["idStreet"])
            {
                idStreet = (int)row["idStreet"];
                SubNodeTreeStreet = this.AddTreeParametrAbn(SubNodeTreeSity.Nodes, new object[] { Street });
                SubNodeTreeStreet.Cells[this.kladrObjIdDataGridViewTextBoxColumn.Index].Value = row["kladrObjId"];
                SubNodeTreeStreet.Cells[this.idStreetDataGridViewTextBoxColumn.Index].Value = row["idStreet"];
            }
            if (idHouse != (string)row["house"])
            {
                idHouse = (string)row["house"];
                SubNodeTreeHouse = this.AddTreeParametrAbn(SubNodeTreeStreet.Nodes, new object[] { row["house"] });
                SubNodeTreeHouse.Cells[this.kladrObjIdDataGridViewTextBoxColumn.Index].Value = row["kladrObjId"];
                SubNodeTreeHouse.Cells[this.idStreetDataGridViewTextBoxColumn.Index].Value = row["idStreet"];
                SubNodeTreeHouse.Cells[this.housesDataGridViewTextBoxColumn.Index].Value = row["house"];
            }

            TreeDataGridViewNode SubNodeTreeAbnObj = this.AddTreeParametrAbn(SubNodeTreeHouse.Nodes, new object[] { ">" });
            // заполним абонентов
            SubNodeTreeAbnObj.Cells[this.codeAbonentDataGridViewTextBoxColumn.Index].Value = row["codeAbonent"];
            SubNodeTreeAbnObj.Cells[this.nameAbnDataGridViewTextBoxColumn.Index].Value = row["nameAbn"];
            SubNodeTreeAbnObj.Cells[this.typeAbnDgvColumn.Index].Value = row["typeAbn"];
            SubNodeTreeAbnObj.Cells[this.nameObjDataGridViewTextBoxColumn.Index].Value = row["nameObj"];
            SubNodeTreeAbnObj.Cells[this.categoryNameDgvColumn.Index].Value = row["categoryName"];
            SubNodeTreeAbnObj.Cells[this.tarifNameDgvColumn.Index].Value = row["tarifName"];
            SubNodeTreeAbnObj.Cells[this.powerSetDgvColumn.Index].Value = row["powerSet"];
            SubNodeTreeAbnObj.Cells[this.countPointDgvColumn.Index].Value = row["countPoint"];
            SubNodeTreeAbnObj.Cells[this.commentODSDgvColumn.Index].Value = row["commentODS"];

            SubNodeTreeAbnObj.Cells[this.idAbnDataGridViewTextBoxColumn.Index].Value = row["idAbn"];
            SubNodeTreeAbnObj.Cells[this.idAbnObjDataGridViewTextBoxColumn.Index].Value = row["idAbnObj"];
            SubNodeTreeAbnObj.Cells[this.idSchmObjDataGridViewTextBoxColumn.Index].Value = row["idSchmObj"];

            SubNodeTreeAbnObj.Cells[this.kladrObjIdDataGridViewTextBoxColumn.Index].Value = row["kladrObjId"];
            SubNodeTreeAbnObj.Cells[this.idStreetDataGridViewTextBoxColumn.Index].Value = row["idStreet"];
            SubNodeTreeAbnObj.Cells[this.housesDataGridViewTextBoxColumn.Index].Value = row["house"];

        }
    }

    /// <summary>
    /// Заполнить дерево (dgvTreeSub) подстанциями попавшими под отключение
    /// </summary>
    /// <param name="SubNodeTree">Подчиненное дерево</param>
    /// <param name="RootNodeObj">Корень-вершина дерева</param>
    /// <param name="VoltageLine">напряжение ветки</param>
    /// <param name="ListSub">список характеристик подстанции</param>
    private void FillTableSubOff(TreeDataGridViewNode SubNodeTree, TreeNodeObj RootNodeObj, string VoltageLine = "", List<string> ListSub = null)
    {
        if (RootNodeObj.Tag != null)
        {
            // если SubNodeTree пустое, то это начало ветки
            if (SubNodeTree == null)
            {
                if (RootNodeObj.Tag is ElectricBus)
                {
                    SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                    {
                    base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                            {
                                ((ElectricBus)RootNodeObj.Tag).Id.ToString()
                            }).ToString(),
                        ((ElectricBus)RootNodeObj.Tag).Id
                    });
                }
                else if (RootNodeObj.Tag is ElectricLine)
                {
                    SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                    {
                    base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                            {
                                ((ElectricLine)RootNodeObj.Tag).Id.ToString()
                            }).ToString(),
                         ((ElectricLine)RootNodeObj.Tag).Id
                    });
                }
                else if (RootNodeObj.Tag is ElectricSubstation)
                {
                    var qBeg = ((SchemeModel.ElectricObject)RootNodeObj.Tag).ChildObjects.Where(r => r is ElectricBus);
                    var q1 = from r in qBeg
                             select new
                             {
                                 VoltageLineME = Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus),
                                 VoltageLine = Convert.ToDouble(Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                             };
                    VoltageLine = (from r in q1
                                   orderby r.VoltageLine descending
                                   select r).First().VoltageLineME;

                    //VoltageLine = ((SchemeModel.ElectricObject)RootNodeObj.Tag).ChildObjects.Where(r => r is ElectricBus).Select(r=>  Convert.ToDouble(GetVoltageObject(((ElectricBus)r).TypeBus).Replace(",", "."))).Max().ToString();

                    string electricBusName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)RootNodeObj.Tag).TypeSubstation) + " " + VoltageLine + " кВ " + ((ElectricSubstation)RootNodeObj.Tag).ToString();


                    SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                    {
                         electricBusName,
                         ((ElectricSubstation)RootNodeObj.Tag).Id
                    });
                }
            }

            if (RootNodeObj.Tag is ElectricBus)
            {
                if (this.listElectricBus.Contains(((ElectricBus)RootNodeObj.Tag).Id))
                {
                    return;
                }
                this.listElectricBus.Add(((ElectricBus)RootNodeObj.Tag).Id);

            }
            if (RootNodeObj.Tag is ElectricLine)
            {
                ElectricLine electricLine = (ElectricLine)RootNodeObj.Tag;
                if (electricLine.IsCell()) // если ячейка
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
                        string electricBusName = ((SchemeModel.ElectricSubstation)electricBus.Parent).TypeSubstation + " " + VoltageLine + " кВ " + electricBus.Parent.ToString();

                        if (electricBus.TypeBus != eTypeShinaTool.Shina_04 && electricBus.TypeBus != eTypeShinaTool.Shina_023)
                        {
                            if (SubNodeTree == null)
                            {
                                SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                {
                                //electricBus.Parent.ToString(),
                                electricBusName,
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
                                electricBusName,
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
                            ListSub.Add(electricBus.Parent.ToString());
                            ListSub.Add(electricBus.Parent.Id.ToString());
                            ListSub.Add(electricBus.ToString());
                            ListSub.Add(electricBus.Id.ToString());
                            ListSub.Add(electricLine.ToString());
                            ListSub.Add(electricLine.Id.ToString());
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
                        electricLineName = row.First()["TypeCable"] + " " + VoltageLine.Replace(".", ",") + " кВ ";
                    else
                        electricLineName = "КЛ 0.38 кВ ";
                    // если в названии линии нет имени подстанции, то надо ее добавить
                    if (ListSub != null && electricLine.ToString().IndexOf(ListSub[0]) < 0)
                        electricLineName = electricLineName + ListSub[0] + @"\";
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
                // заполним используемые трансформаторы в таблице (грид) отключенных подстанций
                foreach (ElectricRelation electricRelation in ((ElectricLine)RootNodeObj.Tag).Relations)
                {
                    foreach (ElectricObject electricObject in electricRelation.ChildObjects)
                    {
                        if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && SubNodeTree != null)
                        {
                            if (SubNodeTree.Cells[this.idTrColumn.Index].Value != null && !string.IsNullOrEmpty(SubNodeTree.Cells[this.idTrColumn.Index].Value.ToString()))
                            {
                                SubNodeTree = SubNodeTree.Parent.Nodes.Add(new object[]
                                {
                                    SubNodeTree.Cells[this.subNameColumn.Index].Value,
                                    SubNodeTree.Cells[this.idSubColumn.Index].Value,
                                    SubNodeTree.Cells[this.busNameColumn.Index].Value,
                                    SubNodeTree.Cells[this.idBusColumn.Index].Value,
                                    SubNodeTree.Cells[this.cellNameColumn.Index].Value,
                                    SubNodeTree.Cells[this.idCellColumn.Index].Value
                                });
                            }
                            DataRow[] array = this.tableTransOff.Select("idTr = " + electricObject.Id.ToString());
                            int? power = null;
                            int? load = null;
                            if (array.Length != 0)
                            {
                                if (array[0]["power"] != DBNull.Value)
                                {
                                    power = new int?(Convert.ToInt32(array[0]["power"]));
                                }
                                if (array[0]["load"] != DBNull.Value)
                                {
                                    load = new int?(Convert.ToInt32(array[0]["load"]));
                                }
                            }
                            if (power != null)
                            {
                                if (SubNodeTree.Cells[8].Value != null && !string.IsNullOrEmpty(SubNodeTree.Cells[8].Value.ToString()))
                                {
                                    SubNodeTree.Cells[8].Value = Convert.ToInt32(SubNodeTree.Cells[8].Value) + power;
                                }
                                else
                                {
                                    SubNodeTree.Cells[8].Value = power;
                                }
                            }
                            if (load != null)
                            {
                                if (SubNodeTree.Cells[9].Value != null && !string.IsNullOrEmpty(SubNodeTree.Cells[9].Value.ToString()))
                                {
                                    SubNodeTree.Cells[9].Value = Convert.ToInt32(SubNodeTree.Cells[9].Value) + load;
                                }
                                else
                                {
                                    SubNodeTree.Cells[9].Value = load;
                                }
                            }
                            if (SubNodeTree.Cells[6].Value != null && !string.IsNullOrEmpty(SubNodeTree.Cells[6].Value.ToString()))
                            {
                                DataGridViewCell dataGridViewCell = SubNodeTree.Cells[6];
                                dataGridViewCell.Value = dataGridViewCell.Value + ";" + electricObject.ToString();
                                DataGridViewCell dataGridViewCell2 = SubNodeTree.Cells[7];
                                dataGridViewCell2.Value = dataGridViewCell2.Value + ";" + electricObject.Id;
                            }
                            else
                            {
                                SubNodeTree.Cells[6].Value = electricObject.ToString();
                                SubNodeTree.Cells[7].Value = electricObject.Id;
                            }
                        }
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

    #endregion

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        this.RefreshTable();
    }

    //private void bsSchmAbnFull_CurrentChanged(object sender, EventArgs e)
    //{

    //}

    #region расчеты итогов
    /// <summary>
    /// заполнить количесиво электроустановок
    /// </summary>
    private void FillCountTrans()
    {
        this.labelCountTr.Text = "Кол-во трансформаторов: " + this.tableTransOff.Rows.Count.ToString();
        this.labelSumPower.Text = "Суммарная мощность: " + this.tableTransOff.Compute("Sum(Power)", "").ToString();
        this.labelSumLoad.Text = "Суммарная нагрузка: " + this.tableTransOff.Compute("Sum(Load)", "").ToString();

    }
    /// <summary>
    /// Расчет количества точек поставки по категориям потребителей
    /// </summary>
    private void CalculationCountPoints()
    {
        NumericUpDown numericUpDown = this.numCountPointCat1Full;
        NumericUpDown numericUpDown2 = this.numCountPointCat2Full;
        decimal value = 0m;
        numericUpDown2.Value = value;
        numericUpDown.Value = value;
        this.numCountPointSource.Value = 0m;
        if (this.tableSchmAbnFull.Rows.Count == 0)
        {
            NumericUpDown numericUpDown3 = this.numCountPointCat1;
            NumericUpDown numericUpDown4 = this.numCountPointCat2;
            NumericUpDown numericUpDown5 = this.numCountPointCat3;
            NumericUpDown numericUpDown6 = this.numCountPointEE;
            NumericUpDown numericUpDown7 = this.numCountPointSource;
            decimal value2 = 0m;
            numericUpDown7.Value = value2;
            numericUpDown3.Value = (numericUpDown4.Value = (numericUpDown5.Value = (numericUpDown6.Value = value2)));
            return;
        }
        if (this.dtpDateCreate.Value != null)
        {
            if (this.dtpDateCreate.Value != DBNull.Value)
            {
                string text = "";
                foreach (object obj in this.tableSchmAbnFull.Rows)
                {
                    DataRow dataRow = (DataRow)obj;
                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        if (string.IsNullOrEmpty(text))
                        {
                            text = dataRow["idAbnObj"].ToString();
                        }
                        else
                        {
                            text = text + "," + dataRow["idAbnObj"].ToString();
                        }
                    }
                }
                DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select ao.id,\r\n                                        case when a.TypeAbn = 231 then -1 -- сетевая организация\r\n                                        else case when a.typeAbn = 206 and r.category is null then 493 -- если у физика нет категории - ставим ему третью\r\n                                        else case when category is null then 493 else r.category end end end as category\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                        left join tPoint p on p.idAbnObj = ao.id and p.dateBegin <= '{0}' and \r\n                                                                (p.dateEnd  >= '{0}' or p.dateEnd is null)\r\n\t                                    /*left join tPointReg pReg on pReg.id = (select top 1 id from tPointReg\r\n\t\t\t\t\t\t\t\t\t\t                                      where idPoint = p.id \r\n\t\t\t\t\t\t\t\t\t\t\t                        and dateBegin <= '{0}' and \r\n                                                                    (dateEnd  >= '{0}' or dateEnd is null)\r\n\t\t\t\t\t\t\t\t\t                                order by dateBegin desc)*/\r\n                                     where ao.id in ({1}) \r\n                                        and p.id is not null --and pREg.id is not null", Convert.ToDateTime(this.dtpDateCreate.Value).ToString("yyyyMMdd"), text));
                this.numCountPointCat1.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category in (491,494)"));
                this.numCountPointCat2.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 492"));
                this.numCountPointCat3.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 493"));
                this.numCountPointEE.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = -1"));
                return;
            }
        }
    }
    /// <summary>
    /// Сохранение в документе узла CountPoint (количество точек поставки)
    /// </summary>
	private void AppendChildCountPoint(XmlNode xml)
    {
        try
        {
            if (xml != null && xml.OwnerDocument != null)
            {
                XmlDocument ownerDocument = xml.OwnerDocument;
                XmlNode xmlNode = ownerDocument.CreateElement("CountPoint");
                xml.AppendChild(xmlNode);
                XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("countPointCat1");
                xmlAttribute.Value = this.numCountPointCat1.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointCat1Full");
                xmlAttribute.Value = this.numCountPointCat1Full.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointCat2");
                xmlAttribute.Value = this.numCountPointCat2.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointCat2Full");
                xmlAttribute.Value = this.numCountPointCat2Full.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointCat3");
                xmlAttribute.Value = this.numCountPointCat3.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointEE");
                xmlAttribute.Value = this.numCountPointEE.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countPointSource");
                xmlAttribute.Value = this.numCountPointSource.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    /// <summary>
    /// Обновление итогов количества точек поставки 
    /// </summary>
	private void LoadTotalCountPoint()
    {
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"] != DBNull.Value)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"].ToString());
                XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                if (xmlNode != null)
                {
                    XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
                    if (xmlNode2 != null)
                    {
                        XmlNode xmlNode3 = xmlNode2.SelectSingleNode("CountPoint");
                        if (xmlNode3 != null)
                        {
                            XmlAttribute xmlAttribute = xmlNode3.Attributes["countPointCat1"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountPointCat1.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countPointCat1Full"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountPointCat1Full.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countPointCat2"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountPointCat2.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countPointCat2Full"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountPointCat2Full.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countPointCat3"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountPointCat3.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countPointEE"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountPointEE.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countPointSource"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountPointSource.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }

    private void numCountPointCat2_ValueChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        this.labelCountPoint.Text = "Количество точек поставки: " + (this.numCountPointCat1.Value + this.numCountPointCat1Full.Value + this.numCountPointCat2.Value + this.numCountPointCat2Full.Value + this.numCountPointCat3.Value + this.numCountPointEE.Value + this.numCountPointSource.Value).ToString();
    }
    /// <summary>
    /// Расчет количества потребителей услуг
    /// </summary>
	private void CalculationCountConsumersAndMaximumPower()
    {
        NumericUpDown numericUpDown = this.numCountAbnObjCat1Full;
        NumericUpDown numericUpDown2 = this.numCountAbnObjCat2Full;
        decimal value = 0m;
        numericUpDown2.Value = value;
        numericUpDown.Value = value;
        this.numCountAbnObjSource.Value = 0m;
        if (this.tableSchmAbnFull.Rows.Count == 0)
        {
            NumericUpDown numericUpDown3 = this.numCountAbnObjCat1;
            NumericUpDown numericUpDown4 = this.numCountAbnObjCat2;
            NumericUpDown numericUpDown5 = this.numCountAbnObjCat3;
            NumericUpDown numericUpDown6 = this.numCountAbnObjEE;
            NumericUpDown numericUpDown7 = this.numCountAbnObjSource;
            decimal value2 = 0m;
            numericUpDown7.Value = value2;
            numericUpDown3.Value = (numericUpDown4.Value = (numericUpDown5.Value = (numericUpDown6.Value = value2)));
            NumericUpDown numericUpDown8 = this.numCountAbnObj150;
            NumericUpDown numericUpDown9 = this.numCountAbnObj150670;
            NumericUpDown numericUpDown10 = this.numCountAbnObj670;
            decimal value3 = 0m;
            numericUpDown10.Value = value3;
            numericUpDown8.Value = (numericUpDown9.Value = value3);
            return;
        }
        string text = "";
        foreach (DataRow dataRow in this.tableSchmAbnFull.Rows)
        {
            if (dataRow.RowState != DataRowState.Deleted)
            {
                if (string.IsNullOrEmpty(text))
                {
                    text = dataRow["idAbnObj"].ToString();
                }
                else
                {
                    text = text + "," + dataRow["idAbnObj"].ToString();
                }
            }
        }
        SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
        DataTable dataTable = sqlDataCommand.SelectSqlData("select ao.id,\r\n                                        case when a.TypeAbn = 231 then -1 -- сетевая организация\r\n                                        else case when a.typeAbn = 206 and r.category is null then 493 -- если у физика нет категории - ставим ему третью\r\n                                        else case when category is null then 493 else r.category end end end as category\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                     where ao.id in (" + text + ")");
        this.numCountAbnObjCat1.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category in (491,494)"));
        this.numCountAbnObjCat2.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 492"));
        this.numCountAbnObjCat3.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 493"));
        this.numCountAbnObjEE.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = -1"));
        dataTable = sqlDataCommand.SelectSqlData("select ao.id,\r\n                                         case when a.TypeAbn = 206 or r.PowerSEt is null then 15\r\n                                        \telse r.PowerSEt end PowerSEt\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                     where ao.id in (" + text + ")");
        this.numCountAbnObj150.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet <= 150"));
        this.numCountAbnObj150670.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet > 150 and PowerSet <= 670"));
        this.numCountAbnObj670.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet > 670"));
    }
    /// <summary>
    /// Загрузка в документе узла CountAbnObj (количество объектов абонентов)
    /// </summary>
	private void AppendChildCountAbnObj(XmlNode xml)
    {
        try
        {
            if (xml != null && xml.OwnerDocument != null)
            {
                XmlDocument ownerDocument = xml.OwnerDocument;
                XmlNode xmlNode = ownerDocument.CreateElement("CountAbnObj");
                xml.AppendChild(xmlNode);
                XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat1");
                xmlAttribute.Value = this.numCountAbnObjCat1.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat1Full");
                xmlAttribute.Value = this.numCountAbnObjCat1Full.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat2");
                xmlAttribute.Value = this.numCountAbnObjCat2.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat2Full");
                xmlAttribute.Value = this.numCountAbnObjCat2Full.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat3");
                xmlAttribute.Value = this.numCountAbnObjCat3.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjEE");
                xmlAttribute.Value = this.numCountAbnObjEE.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObjSource");
                xmlAttribute.Value = this.numCountAbnObjSource.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObj150");
                xmlAttribute.Value = this.numCountAbnObj150.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObj150670");
                xmlAttribute.Value = this.numCountAbnObj150670.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = ownerDocument.CreateAttribute("countAbnObj670");
                xmlAttribute.Value = this.numCountAbnObj670.Value.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    /// <summary>
    /// Загрузка итогов количества абонентов по категориям
    /// </summary>
	private void LoadTotalCountAbnObj()
    {
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"] != DBNull.Value)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"].ToString());
                XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                if (xmlNode != null)
                {
                    XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
                    if (xmlNode2 != null)
                    {
                        XmlNode xmlNode3 = xmlNode2.SelectSingleNode("CountAbnObj");
                        if (xmlNode3 != null)
                        {
                            XmlAttribute xmlAttribute = xmlNode3.Attributes["countAbnObjCat1"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObjCat1.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObjCat1Full"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObjCat1Full.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObjCat2"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObjCat2.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObjCat2Full"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObjCat2Full.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObjCat3"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObjCat3.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObjEE"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObjEE.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObjSource"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObjSource.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObj150"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObj150.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObj150670"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObj150670.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNode3.Attributes["countAbnObj670"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                this.numCountAbnObj670.Value = Convert.ToInt32(xmlAttribute.Value);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }

    private void numCountAbnObjCat2Full_ValueChanged(object sender, EventArgs e)
    {
        this.isChangedData = true;
        this.labelCountAbnObj.Text = "Количество объектов: " + (this.numCountAbnObjCat1.Value + this.numCountAbnObjCat1Full.Value + this.numCountAbnObjCat2.Value + this.numCountAbnObjCat2Full.Value + this.numCountAbnObjCat3.Value + this.numCountAbnObjEE.Value + this.numCountAbnObjSource.Value).ToString();
    }


    #endregion

    private void toolBrnDelAbn_Click(object sender, EventArgs e)
    {
        if (this.dgvAbn.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить выбранные строки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            foreach (TreeDataGridViewNode node in this.dgvAbn.SelectedRows)
            {
                string strWhere = "";
                if (node.Cells[this.kladrObjIdDataGridViewTextBoxColumn.Index].Value != null) strWhere += "KladrObjId = " + node.Cells[this.kladrObjIdDataGridViewTextBoxColumn.Index].Value;
                if (node.Cells[this.idStreetDataGridViewTextBoxColumn.Index].Value   != null) strWhere += " and idStreet = "   + node.Cells[this.idStreetDataGridViewTextBoxColumn.Index].Value;
                if (node.Cells[this.housesDataGridViewTextBoxColumn.Index].Value     != null) strWhere += " and house = '"      + node.Cells[this.housesDataGridViewTextBoxColumn.Index].Value + "'";
                if (node.Cells[this.idAbnObjDataGridViewTextBoxColumn.Index].Value   != null) strWhere += " and idAbnObj = "   + node.Cells[this.idAbnObjDataGridViewTextBoxColumn.Index].Value;


                var foundRows = tableSchmAbnFull.Select(strWhere);

                foreach (var row in foundRows)
                {
                    tableSchmAbnFull.Rows.Remove(row);
                }


                node.Parent.Nodes.Remove(node);
            }
            //1. Заполнить таблицу адресов (рекурсия) --> надо будет заполнить tableSchmAbnFull
            this.dataSetDamage.tJ_RequestForRepairAddress.Clear(); // чистим таблицу улиц
            var enumAddress = tableSchmAbnFull.AsEnumerable().GroupBy(r => new { KladrObjId = r["KladrObjId"], idStreet = r["idStreet"], house = r["house"] });
            foreach (var row in enumAddress)
            {
                if (row.Key.idStreet != DBNull.Value && row.Key.house != DBNull.Value && this.dataSetDamage.tJ_RequestForRepairAddress.Select(string.Concat(new string[]
                {
                        "idKladrStreet = ",
                        row.Key.idStreet.ToString(),
                        " and house = '",
                        row.Key.house.ToString(),
                        "'"
                })).Length == 0)
                {
                    DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepairAddress.NewRow();
                    dataRow2["idRequest"] = this.IdDocument;
                    dataRow2["idKladrObj"] = row.Key.KladrObjId;
                    dataRow2["idKladrStreet"] = row.Key.idStreet;
                    dataRow2["house"] = row.Key.house;
                    this.dataSetDamage.tJ_RequestForRepairAddress.Rows.Add(dataRow2);
                }
            }

            this.FillTableRepairAddress();
            //???2. Найти возможность держать дерево сразу раскрытым

            this.CalculationCountPoints();
            this.CalculationCountConsumersAndMaximumPower();
        }
    }
    private void FillDataSourceTypeAbn()
    {
        DataTable dataTable = Reference.Tables.TableClassifier();
        base.SelectSqlData(dataTable, true, " where  parentKey = ';SKUEE;TypeAbn;' and isGRoup = 0 and deleted  = 0", null, false, 0);
        this.typeAbnDgvColumn.DisplayMember = "name";
        this.typeAbnDgvColumn.ValueMember = "id";
        BindingSource bindingSource = new BindingSource();
        bindingSource.DataSource = dataTable;
        this.typeAbnDgvColumn.DataSource = bindingSource;
    }

    private void FormJournalRequestForRepairAddEdit_Shown(object sender, EventArgs e)
    {
        this.isChangedData = false;
    }
   
    /// <summary>
    /// сохраним xml-данные - CommentXml-отключенные абоненты
    /// </summary>
	private void AppendChildCommentXml()
    {
        XmlDocument xmlDocument = new XmlDocument();
        if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"] != DBNull.Value)
        {
            try
            {
                xmlDocument.LoadXml(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"].ToString());
            }
            catch
            {
            }
        }
        XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
        if (xmlNode == null)
        {
            xmlNode = xmlDocument.CreateElement("Doc");
            xmlDocument.AppendChild(xmlNode);
        }
        XmlNode xmlNodeAbnOff = xmlNode.SelectSingleNode("AbnOff");
        if (xmlNodeAbnOff != null)
        {
            xmlNodeAbnOff.RemoveAll();
        }
        else
        {
            xmlNodeAbnOff = xmlDocument.CreateElement("AbnOff");
            xmlNode.AppendChild(xmlNodeAbnOff);
        }
        //foreach (DataRow dataRow in this.tableSchmAbnFull.Rows)
        //{
        //    if (dataRow.RowState != DataRowState.Deleted)
        //    {
        //        XmlNode xmlNode3 = xmlDocument.CreateElement("Row");
        //        xmlNodeAbnOff.AppendChild(xmlNode3);
        //        XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idAbnObj");
        //        xmlAttribute.Value = dataRow["idAbnObj"].ToString();
        //        xmlNode3.Attributes.Append(xmlAttribute);

        //        xmlAttribute = xmlDocument.CreateAttribute("idSchmObj");
        //        xmlAttribute.Value = dataRow["idSchmObj"].ToString();
        //        xmlNode3.Attributes.Append(xmlAttribute);
        //    }
        //}
        this.AppendChildAbnTree(xmlNodeAbnOff);
        this.AppendChildCountPoint(xmlNodeAbnOff);
        this.AppendChildCountAbnObj(xmlNodeAbnOff);
        this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"] = xmlDocument.InnerXml;
    }
    /// <summary>
    /// сохраняем абонентов деревом
    /// </summary>
    private void AppendChildAbnTree(XmlNode xml)
    {
        if (xml != null && xml.OwnerDocument != null)
        {
            XmlDocument ownerDocument = xml.OwnerDocument;
            if (xml != null)
            {
                XmlNode xmlNode = ownerDocument.CreateElement("AbnTree");
                xml.AppendChild(xmlNode);
                foreach (TreeDataGridViewNode treeDataGridViewNode_ in this.dgvAbn.Nodes)
                {
                    this.AppendChildNodeAbnTree(treeDataGridViewNode_, xmlNode);
                }
            }
            return;
        }
    }
    /// <summary>
    /// сохранение элементов NOde (отдельного узла) таблицы отключенных абонентов
    /// </summary>
    private void AppendChildNodeAbnTree(TreeDataGridViewNode treeDataGridViewNode, XmlNode xmlNode)
    {
        XmlNode xmlNodeDgv = xmlNode.OwnerDocument.CreateElement("NodeDgvAbn");
        xmlNode.AppendChild(xmlNodeDgv);
        foreach (DataGridViewColumn dataGridViewColumn in this.dgvAbn.Columns)
        {
            if (!string.IsNullOrEmpty(dataGridViewColumn.DataPropertyName) && treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value != null)
            {
                XmlAttribute xmlAttribute = xmlNode.OwnerDocument.CreateAttribute(dataGridViewColumn.DataPropertyName);
                xmlAttribute.Value = treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value.ToString();
                xmlNodeDgv.Attributes.Append(xmlAttribute);
            }
        }
            foreach (TreeDataGridViewNode treeDataGridViewNode_ in treeDataGridViewNode.Nodes)
        {
            this.AppendChildNodeAbnTree(treeDataGridViewNode_, xmlNodeDgv);
        }
    }
    /// <summary>
    /// Сохранение xml-данных трнасформатора
    /// </summary>
    private void AppendChildTransOff()
    {
        XmlDocument xmlDocument = new XmlDocument();
        if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"] != DBNull.Value)
        {
            try
            {
                xmlDocument.LoadXml(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"].ToString());
            }
            catch
            {
            }
        }
        XmlNode xmlNodeDoc = xmlDocument.SelectSingleNode("Doc");
        if (xmlNodeDoc == null)
        {
            xmlNodeDoc = xmlDocument.CreateElement("Doc");
            xmlDocument.AppendChild(xmlNodeDoc);
        }
        XmlNode xmlNodeTransOff = xmlNodeDoc.SelectSingleNode("TransOff");
        if (xmlNodeTransOff != null)
        {
            xmlNodeTransOff.RemoveAll();
        }
        else
        {
            xmlNodeTransOff = xmlDocument.CreateElement("TransOff");
            xmlNodeDoc.AppendChild(xmlNodeTransOff);
        }
        foreach (DataRow dataRow in this.tableTransOff.Rows)
        {
            XmlNode xmlNodeRow = xmlDocument.CreateElement("Row");
            xmlNodeTransOff.AppendChild(xmlNodeRow);

            XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idSub");
            xmlAttribute.Value = dataRow["idSub"].ToString();
            xmlNodeRow.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("idTr");
            xmlAttribute.Value = dataRow["idTr"].ToString();
            xmlNodeRow.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("Power");
            xmlAttribute.Value = dataRow["Power"].ToString();
            xmlNodeRow.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("Load");
            xmlAttribute.Value = dataRow["Load"].ToString();
            xmlNodeRow.Attributes.Append(xmlAttribute);
        }
        this.AppendChildSubTree(xmlNodeTransOff);
        this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"] = xmlDocument.InnerXml;
    }
    /// <summary>
    /// сохраняем подстанции
    /// </summary>
    private void AppendChildSubTree(XmlNode xml)
    {
        if (xml != null && xml.OwnerDocument != null)
        {
            XmlDocument ownerDocument = xml.OwnerDocument;
            if (xml != null)
            {
                XmlNode xmlNode = ownerDocument.CreateElement("TransTree");
                xml.AppendChild(xmlNode);
                foreach (TreeDataGridViewNode treeDataGridViewNode_ in this.dgvTreeSub.Nodes)
                {
                    this.AppendChildNodeTransTree(treeDataGridViewNode_, xmlNode);
                }
            }
            return;
        }
    }
    /// <summary>
    /// сохранение элементов NOde (отдельного узла) таблицы отключенных подстанций
    /// </summary>
    private void AppendChildNodeTransTree(TreeDataGridViewNode treeDataGridViewNode, XmlNode xmlNode)
    {
        XmlNode xmlNodeDgv = xmlNode.OwnerDocument.CreateElement("NodeDgv");
        xmlNode.AppendChild(xmlNodeDgv);
        foreach (DataGridViewColumn dataGridViewColumn in this.dgvTreeSub.Columns)
        {
            if (!string.IsNullOrEmpty(dataGridViewColumn.DataPropertyName) && treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value != null)
            {
                XmlAttribute xmlAttribute = xmlNode.OwnerDocument.CreateAttribute(dataGridViewColumn.DataPropertyName);
                xmlAttribute.Value = treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value.ToString();
                xmlNodeDgv.Attributes.Append(xmlAttribute);
            }
        }
        foreach (TreeDataGridViewNode treeDataGridViewNode_ in treeDataGridViewNode.Nodes)
        {
            this.AppendChildNodeTransTree(treeDataGridViewNode_, xmlNodeDgv);
        }
    }
    /// <summary>
    /// загрузка таблицы отключенных трансформатров
    /// + создание структуры - если таблицы не было
    /// </summary>
	private void LoadTableTransOff()
    {
        this.tableTransOff.Clear();
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"] != DBNull.Value)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"].ToString());
                XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                if (xmlNode != null)
                {
                    XmlNode xmlNode2 = xmlNode.SelectSingleNode("TransOff");
                    if (xmlNode2 != null)
                    {
                        List<string> listSub = new List<string>();
                        List<string> listTr = new List<string>();
                        foreach (XmlNode xmlNodeRow in xmlNode2.SelectNodes("Row"))
                        {
                            DataRow dataRow = this.tableTransOff.NewRow();
                            XmlAttribute xmlAttribute = xmlNodeRow.Attributes["idSub"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                dataRow["idSub"] = xmlAttribute.Value;
                                listSub.Add(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNodeRow.Attributes["idTr"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                dataRow["idTr"] = xmlAttribute.Value;
                                listTr.Add(xmlAttribute.Value);
                            }
                            xmlAttribute = xmlNodeRow.Attributes["Power"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                dataRow["Power"] = xmlAttribute.Value;
                            }
                            xmlAttribute = xmlNodeRow.Attributes["Load"];
                            if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                            {
                                dataRow["Load"] = xmlAttribute.Value;
                            }
                            this.tableTransOff.Rows.Add(dataRow);
                        }

                        DataTable dataTable = new DataTable("vSchm_ObjList");
                        dataTable.Columns.Add("id", typeof(int));
                        dataTable.Columns.Add("name", typeof(string));
                        dataTable.Columns.Add("typeCodeSocr", typeof(string));
                        dataTable.Columns.Add("fullname", typeof(string), "typeCodeSocr + '-'+name");
                        if (listSub.Count > 0)
                        {
                            base.SelectSqlData(dataTable, true, " where id in (" + string.Join(",", listSub.ToArray()) + ")", null, false, 0);
                        }
                        DataTable dataTable2 = new DataTable("tSchm_ObjList");
                        dataTable2.Columns.Add("id", typeof(int));
                        dataTable2.Columns.Add("name", typeof(string));
                        if (listTr.Count > 0)
                        {
                            base.SelectSqlData(dataTable2, true, " where id in (" + string.Join(",", listTr.ToArray()) + ")", null, false, 0);
                        }
                        if (dataTable.Rows.Count > 0 || dataTable2.Rows.Count > 0)
                        {
                            foreach (DataRow dataRow2 in this.tableTransOff.Rows)
                            {
                                if (dataRow2["idSub"] != DBNull.Value)
                                {
                                    DataRow[] array = dataTable.Select("id = " + dataRow2["idSub"].ToString());
                                    if (array.Length != 0)
                                    {
                                        dataRow2["Sub"] = array[0]["FullName"];
                                    }
                                }
                                if (dataRow2["idTr"] != DBNull.Value)
                                {
                                    DataRow[] array2 = dataTable2.Select("id = " + dataRow2["idTr"].ToString());
                                    if (array2.Length != 0)
                                    {
                                        dataRow2["TrName"] = array2[0]["Name"];
                                    }
                                }
                            }
                        }
                        this.labelCountTr.Text = "Кол-во трансформаторов: " + this.tableTransOff.Rows.Count.ToString();
                        this.labelSumPower.Text = "Суммарная мощность: " + this.tableTransOff.Compute("Sum(Power)", "").ToString();
                        this.labelSumLoad.Text = "Суммарная нагрузка: " + this.tableTransOff.Compute("Sum(Load)", "").ToString();
                        this.FillDgvTreeSub(xmlDocument);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }
    /// <summary>
    /// заполним datagridview dgvTreeSub и создадим структуру дерева при открытии документа
    /// </summary>
    private void FillDgvTreeSub(XmlDocument xml)
    {
        XmlNode xmlNode = xml.SelectSingleNode("Doc");
        if (xmlNode == null)
        {
            return;
        }
        XmlNode xmlNode2 = xmlNode.SelectSingleNode("TransOff");
        if (xmlNode2 == null)
        {
            return;
        }
        XmlNode xmlNode3 = xmlNode2.SelectSingleNode("TransTree");
        if (xmlNode3 == null)
        {
            return;
        }
        foreach (XmlNode xmlNode_ in xmlNode3.SelectNodes("NodeDgv"))
        {
            this.CreateTreeStructureDgvTreeSub(xmlNode_, this.dgvTreeSub.Nodes);
        }
    }
    /// <summary>
    /// Создадим структуру дерева в таблице dgvTreeSub
    /// при открытии
    /// </summary>
    private void CreateTreeStructureDgvTreeSub(XmlNode xmlNode, TreeDataGridViewNodeCollection treeDataGridViewNodeCollection)
    {
        TreeDataGridViewNode treeDataGridViewNode = treeDataGridViewNodeCollection.Add(new object[0]);
        foreach (DataGridViewColumn dataGridViewColumn in this.dgvTreeSub.Columns)
        {
            if (!string.IsNullOrEmpty(dataGridViewColumn.DataPropertyName))
            {
                XmlAttribute xmlAttribute = xmlNode.Attributes[dataGridViewColumn.DataPropertyName];
                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                {
                    treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value = xmlAttribute.Value;
                }
            }
        }
        foreach (XmlNode xmlNode_ in xmlNode.SelectNodes("NodeDgv"))
        {
            this.CreateTreeStructureDgvTreeSub(xmlNode_, treeDataGridViewNode.Nodes);
        }
    }
    #region Заполним деревянный грид абонентов 
    /// <summary>
    /// загрузка таблицы отключенных абонентов
    /// + создание структуры - если таблицы не было
    /// </summary>
    private void LoadTableAbnOff()
    {
        this.tableSchmAbnFull.Clear();
        if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"] != DBNull.Value)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["CommentXml"].ToString());
                XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                if (xmlNode != null)
                {
                    XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
                    if (xmlNode2 != null)
                    {
                        //foreach (XmlNode xmlNodeRow in xmlNode2.SelectNodes("Row"))
                        //{
                        //    DataRow dataRow = this.tableSchmAbnFull.NewRow();
                        //    XmlAttribute xmlAttribute = xmlNodeRow.Attributes["idSub"];
                        //    if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                        //    {
                        //        dataRow["idSub"] = xmlAttribute.Value;
                        //    }
                        //    xmlAttribute = xmlNodeRow.Attributes["idTr"];
                        //    if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                        //    {
                        //        dataRow["idTr"] = xmlAttribute.Value;
                        //    }
                        //    xmlAttribute = xmlNodeRow.Attributes["Power"];
                        //    if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                        //    {
                        //        dataRow["Power"] = xmlAttribute.Value;
                        //    }
                        //    xmlAttribute = xmlNodeRow.Attributes["Load"];
                        //    if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                        //    {
                        //        dataRow["Load"] = xmlAttribute.Value;
                        //    }
                        //    this.tableSchmAbnFull.Rows.Add(dataRow);
                        //}

                        this.FillDgvTreeAbn(xmlDocument);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }
    /// <summary>
    /// заполним datagridview dgvTreeAbn и создадим структуру дерева при открытии документа
    /// </summary>
    private void FillDgvTreeAbn(XmlDocument xml)
    {
        XmlNode xmlNode = xml.SelectSingleNode("Doc");
        if (xmlNode == null)
        {
            return;
        }
        XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
        if (xmlNode2 == null)
        {
            return;
        }
        XmlNode xmlNode3 = xmlNode2.SelectSingleNode("AbnTree");
        if (xmlNode3 == null)
        {
            return;
        }
        foreach (XmlNode xmlNode_ in xmlNode3.SelectNodes("NodeDgvAbn"))
        {
            this.CreateTreeStructureDgvTreeAbn(xmlNode_, this.dgvAbn.Nodes);
        }
    }
    /// <summary>
    /// Создадим структуру дерева в таблице dgvAbn
    /// при открытии
    /// </summary>
    private void CreateTreeStructureDgvTreeAbn(XmlNode xmlNode, TreeDataGridViewNodeCollection treeDataGridViewNodeCollection)
    {
        TreeDataGridViewNode treeDataGridViewNode = treeDataGridViewNodeCollection.Add(new object[0]);
        DataRow dataRow = this.tableSchmAbnFull.NewRow();
        foreach (DataGridViewColumn dataGridViewColumn in this.dgvAbn.Columns)
        {
            if (!string.IsNullOrEmpty(dataGridViewColumn.DataPropertyName))
            {
                XmlAttribute xmlAttribute = xmlNode.Attributes[dataGridViewColumn.DataPropertyName];
                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                {
                    if (dataGridViewColumn.DataPropertyName == "typeAbn")
                        treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value = Convert.ToInt32(xmlAttribute.Value);
                    else
                        treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value = xmlAttribute.Value;

                    if ((dataGridViewColumn.DataPropertyName == "idAbn" && xmlAttribute.Value != null)  || (dataGridViewColumn.DataPropertyName != "idAddress"))
                        dataRow[dataGridViewColumn.DataPropertyName] = xmlAttribute.Value;
                }
                
            }
        }
        if (dataRow[0] != System.DBNull.Value)
        {
            this.tableSchmAbnFull.Rows.Add(dataRow);
        }

        foreach (XmlNode xmlNode_ in xmlNode.SelectNodes("NodeDgvAbn"))
        {
            this.CreateTreeStructureDgvTreeAbn(xmlNode_, treeDataGridViewNode.Nodes);
        }
    }
    #endregion
}