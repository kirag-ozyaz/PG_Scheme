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
using RequestsClient.DataSets;
using RequestsClient.Properties;
using RequestsClient.RequestService;
using SchemeModel;
using SchemeModel.Calculations;

namespace RequestsClient.Forms.JournalRequestForRepair
{
	// Token: 0x02000042 RID: 66
	public partial class FormJournalRequestForRepairAddEdit : FormBase
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00008F09 File Offset: 0x00007109
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00008F11 File Offset: 0x00007111
		private bool IsCrash
		{
			get
			{
				return this.i;
			}
			set
			{
				this.i = value;
				this.i();
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00008F20 File Offset: 0x00007120
		public FormJournalRequestForRepairAddEdit()
		{
			this.a();
			this.ad();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00008F94 File Offset: 0x00007194
		public FormJournalRequestForRepairAddEdit(int idRequest, int idDivision, eActionRequestRepair action, bool isCrash = false)
		{
			this.a();
			this.ad();
			this.a = idRequest;
			this.b = idDivision;
			this.e = action;
			this.IsCrash = isCrash;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00009024 File Offset: 0x00007224
		public FormJournalRequestForRepairAddEdit(DataRow copy)
		{
			this.a();
			this.ad();
			this.a = -1;
			this.b = Convert.ToInt32(copy["idDivision"]);
			this.e = eActionRequestRepair.Add;
			this.l = copy;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000090C0 File Offset: 0x000072C0
		private void ad()
		{
			this.ah.DataBindings.Clear();
			this.ah.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.IsPlanned", true, DataSourceUpdateMode.OnPropertyChanged));
			this.cm.DataBindings.Clear();
			this.cm.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.typeDisable", true, DataSourceUpdateMode.OnPropertyChanged));
			this.ae.DataBindings.Clear();
			this.ae.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.idSR", true, DataSourceUpdateMode.OnPropertyChanged));
			this.cl.DataBindings.Clear();
			this.cl.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.idRegion", true, DataSourceUpdateMode.OnPropertyChanged));
			this.av.DataBindings.Clear();
			this.av.DataBindings.Add(new Binding("Value", this.z, "tJ_RequestForRepair.DateAgreed", true, DataSourceUpdateMode.OnPropertyChanged));
			this.dl.DataBindings.Clear();
			this.dl.DataBindings.Add(new Binding("Value", this.z, "tJ_RequestForRepair.DateFactEnd", true, DataSourceUpdateMode.OnPropertyChanged));
			this.cv.DataBindings.Clear();
			this.cv.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.status", true, DataSourceUpdateMode.OnPropertyChanged));
			this.cj.DataBindings.Clear();
			this.cj.DataBindings.Add(new Binding("Text", this.z, "tJ_RequestForRepair.Address", true, DataSourceUpdateMode.OnPropertyChanged));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00009288 File Offset: 0x00007488
		private void ac()
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
									this.k = Convert.ToBoolean(xmlAttribute.Value);
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

		// Token: 0x0600014C RID: 332 RVA: 0x0000939C File Offset: 0x0000759C
		private void ab()
		{
			try
			{
				this.m = new DataTable("tR_RequestForRepairClient");
				base.SelectSqlData(this.m, true, "where type = 2 order by name", false);
				DataTable dataTable = new DataTable("tR_RequestForRepairClient");
				dataTable.Columns.Add("name", typeof(string));
				dataTable.Columns.Add("value", typeof(int));
				this.cl.DataSource = dataTable;
				this.cl.DisplayMember = "Name";
				this.cl.ValueMember = "Value";
				if (this.k)
				{
					try
					{
						ServicePointManager.CertificatePolicy = new global::a();
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
						goto IL_215;
					}
					catch (Exception)
					{
						this.cl.ForeColor = Color.Red;
						if (dataTable.Rows.Count == 0)
						{
							foreach (object obj in this.m.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								dataTable.Rows.Add(new object[]
								{
									dataRow["name"],
									dataRow["Value"]
								});
							}
						}
						goto IL_215;
					}
				}
				if (dataTable.Rows.Count == 0)
				{
					foreach (object obj2 in this.m.Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						dataTable.Rows.Add(new object[]
						{
							dataRow2["name"],
							dataRow2["Value"]
						});
					}
				}
				IL_215:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00009634 File Offset: 0x00007834
		private void ak(object A_0, EventArgs A_1)
		{
			if (this.ae.SelectedValue == null || this.ae.SelectedValue == DBNull.Value)
			{
				this.cl.SelectedIndex = -1;
				return;
			}
			if (this.m != null)
			{
				DataRow[] array = this.m.Select("GESid = " + this.ae.SelectedValue.ToString());
				if (array.Length != 0 && array[0]["Value"] != DBNull.Value)
				{
					this.cl.SelectedValue = array[0]["Value"];
				}
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000096CC File Offset: 0x000078CC
		private void aj(object A_0, EventArgs A_1)
		{
			if (this.cl.SelectedValue == null || this.cl.SelectedValue == DBNull.Value)
			{
				this.ae.SelectedIndex = -1;
				return;
			}
			if (this.m != null)
			{
				DataRow[] array = this.m.Select("Value = " + this.cl.SelectedValue.ToString());
				if (array.Length != 0 && array[0]["GesId"] != DBNull.Value)
				{
					this.ae.SelectedValue = array[0]["GESId"];
				}
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00009764 File Offset: 0x00007964
		private void aa()
		{
			this.n = new DataTable("tR_RequestForRepairClient");
			base.SelectSqlData(this.n, true, "where type = 1 order by name", false);
			DataTable dataTable = new DataTable("tR_RequestForRepairClient");
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Columns.Add("value", typeof(int));
			this.cm.DataSource = dataTable;
			this.cm.DisplayMember = "Name";
			this.cm.ValueMember = "Value";
			if (this.k)
			{
				try
				{
					ServicePointManager.CertificatePolicy = new global::a();
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
					this.cm.ForeColor = Color.Red;
					if (dataTable.Rows.Count == 0)
					{
						foreach (object obj in this.n.Rows)
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
				foreach (object obj2 in this.n.Rows)
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

		// Token: 0x06000150 RID: 336 RVA: 0x000099B0 File Offset: 0x00007BB0
		private void ai(object A_0, EventArgs A_1)
		{
			if (this.cm.SelectedValue == null || this.cm.SelectedValue == DBNull.Value)
			{
				this.ah.SelectedIndex = -1;
				return;
			}
			if (this.n != null)
			{
				DataRow[] array = this.n.Select("Value = " + this.cm.SelectedValue.ToString());
				if (array.Length != 0 && array[0]["GesId"] != DBNull.Value)
				{
					this.ah.SelectedValue = Convert.ToBoolean(array[0]["GesId"]);
				}
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00009A54 File Offset: 0x00007C54
		private void ah(object A_0, EventArgs A_1)
		{
			if (this.ah.SelectedValue == null || this.ah.SelectedValue == DBNull.Value)
			{
				this.cm.SelectedIndex = -1;
				return;
			}
			if (this.n != null)
			{
				DataRow[] array = this.n.Select("GesId = " + Convert.ToInt32(this.ah.SelectedValue).ToString());
				if (array.Length != 0 && array[0]["Value"] != DBNull.Value)
				{
					this.cm.SelectedValue = array[0]["Value"];
				}
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00009AF4 File Offset: 0x00007CF4
		private void z()
		{
			this.o = new DataTable("tR_RequestForRepairClient");
			base.SelectSqlData(this.o, true, "where type = 3 order by name", false);
			DataTable dataTable = new DataTable("tR_RequestForRepairClient");
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Columns.Add("value", typeof(int));
			this.cq.DataSource = dataTable;
			this.cq.DisplayMember = "Name";
			this.cq.ValueMember = "Value";
			DataTable dataTable2 = new DataTable("tR_RequestForRepairClient");
			dataTable2.Columns.Add("name", typeof(string));
			dataTable2.Columns.Add("value", typeof(int));
			this.co.DataSource = dataTable2;
			this.co.DisplayMember = "Name";
			this.co.ValueMember = "Value";
			if (this.k)
			{
				try
				{
					ServicePointManager.CertificatePolicy = new global::a();
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
					this.cq.ForeColor = Color.Red;
					this.co.ForeColor = Color.Red;
					if (dataTable.Rows.Count == 0)
					{
						foreach (object obj in this.o.Rows)
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
				foreach (object obj2 in this.o.Rows)
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

		// Token: 0x06000153 RID: 339 RVA: 0x00009E54 File Offset: 0x00008054
		private void y()
		{
			this.p = new DataTable("tR_RequestForRepairClient");
			base.SelectSqlData(this.p, true, "where type = 4 order by name", false);
			DataTable dataTable = new DataTable("tR_RequestForRepairClient");
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Columns.Add("value", typeof(int));
			this.cs.DataSource = dataTable;
			this.cs.DisplayMember = "Name";
			this.cs.ValueMember = "Value";
			if (this.k)
			{
				try
				{
					ServicePointManager.CertificatePolicy = new global::a();
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
					this.cs.ForeColor = Color.Red;
					if (dataTable.Rows.Count == 0)
					{
						foreach (object obj in this.p.Rows)
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
				foreach (object obj2 in this.p.Rows)
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

		// Token: 0x06000154 RID: 340 RVA: 0x0000A0A0 File Offset: 0x000082A0
		private void x()
		{
			this.q = new DataTable("tR_RequestForRepairClient");
			base.SelectSqlData(this.q, true, "where type = 5 order by name", false);
			DataTable dataTable = new DataTable("tR_RequestForRepairClient");
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Columns.Add("value", typeof(int));
			this.cv.DataSource = dataTable;
			this.cv.DisplayMember = "Name";
			this.cv.ValueMember = "Value";
			if (this.k)
			{
				try
				{
					ServicePointManager.CertificatePolicy = new global::a();
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
					this.cv.ForeColor = Color.Red;
					if (dataTable.Rows.Count == 0)
					{
						foreach (object obj in this.q.Rows)
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
				foreach (object obj2 in this.q.Rows)
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

		// Token: 0x06000155 RID: 341 RVA: 0x0000A2EC File Offset: 0x000084EC
		private void ag(object A_0, EventArgs A_1)
		{
			this.ac();
			this.d();
			WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
			this.cj.ReadOnly = false;
			this.a9.Value = DateTime.Now.Date.AddHours(8.0);
			this.a8.Value = DateTime.Now.Date.AddHours(17.0);
			this.s();
			this.ab();
			this.aa();
			this.z();
			this.y();
			this.x();
			base.LoadFormConfig(null);
			switch (this.e)
			{
			case eActionRequestRepair.Add:
				if (this.l != null)
				{
					DataRow dataRow = this.z.tJ_RequestForRepair.NewRow();
					dataRow["num"] = 0;
					dataRow["dateCreate"] = DateTime.Now;
					this.b(DateTime.Now);
					dataRow["idWorker"] = this.l["idWorker"];
					dataRow["reguestFiled"] = this.l["reguestFiled"];
					dataRow["idSR"] = this.l["idSR"];
					if (this.m != null)
					{
						DataRow[] array = this.m.Select("GESid = " + this.l["idSR"].ToString());
						if (array.Length != 0 && array[0]["Value"] != DBNull.Value)
						{
							dataRow["idRegion"] = array[0]["Value"];
						}
					}
					dataRow["schmObj"] = this.l["schmObj"];
					dataRow["Purpose"] = this.l["Purpose"];
					dataRow["IsPlanned"] = this.l["IsPlanned"];
					dataRow["crash"] = this.l["crash"];
					if (this.n != null)
					{
						DataRow[] array2 = this.n.Select("GesId = " + Convert.ToInt32(this.l["IsPlanned"]).ToString());
						if (array2.Length != 0 && array2[0]["Value"] != DBNull.Value)
						{
							dataRow["typeDisable"] = array2[0]["Value"];
						}
					}
					dataRow["agreed"] = false;
					dataRow["iddivision"] = this.l["iddivision"];
					dataRow["deleted"] = false;
					if (this.i)
					{
						dataRow["SendSite"] = true;
					}
					else
					{
						dataRow["SendSite"] = false;
					}
					if (this.o != null)
					{
						DataRow[] array3 = this.o.Select("isDefault = true");
						if (array3.Length != 0)
						{
							dataRow["Organization"] = array3[0]["Value"];
							dataRow["performerOrganization"] = array3[0]["Value"];
						}
					}
					if (this.p != null)
					{
						DataRow[] array4 = this.p.Select("isDefault = true");
						if (array4.Length != 0)
						{
							dataRow["groupWorks"] = array4[0]["Value"];
						}
					}
					DataTable dataTable = this.t();
					base.SelectSqlData(dataTable, true, " where [Login] = SYSTEM_USER ", false);
					if (dataTable.Rows.Count > 0)
					{
						dataRow["idUserCreate"] = dataTable.Rows[0]["iduser"];
						if (dataTable.Rows[0]["idWorker"] != DBNull.Value)
						{
							dataRow["IdWorker"] = dataTable.Rows[0]["idWorker"];
						}
					}
					this.z.tJ_RequestForRepair.Rows.Add(dataRow);
				}
				else
				{
					DataRow dataRow2 = this.z.tJ_RequestForRepair.NewRow();
					dataRow2["num"] = 0;
					dataRow2["dateCreate"] = DateTime.Now;
					this.b(DateTime.Now);
					dataRow2["idWorker"] = -1;
					dataRow2["reguestFiled"] = "";
					dataRow2["idSR"] = this.s;
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
					dataRow2["iddivision"] = this.b;
					dataRow2["deleted"] = false;
					if (this.i)
					{
						dataRow2["SendSite"] = true;
					}
					else
					{
						dataRow2["SendSite"] = false;
					}
					if (this.o != null)
					{
						DataRow[] array5 = this.o.Select("isDefault = true");
						if (array5.Length != 0)
						{
							dataRow2["Organization"] = array5[0]["Value"];
							dataRow2["performerOrganization"] = array5[0]["Value"];
						}
					}
					if (this.p != null)
					{
						DataRow[] array6 = this.p.Select("isDefault = true");
						if (array6.Length != 0)
						{
							dataRow2["groupWorks"] = array6[0]["Value"];
						}
					}
					DataTable dataTable2 = this.t();
					base.SelectSqlData(dataTable2, true, " where [Login] = SYSTEM_USER ", false);
					if (dataTable2.Rows.Count > 0)
					{
						dataRow2["idUserCreate"] = dataTable2.Rows[0]["iduser"];
						if (dataTable2.Rows[0]["idWorker"] != DBNull.Value)
						{
							dataRow2["IdWorker"] = dataTable2.Rows[0]["idWorker"];
						}
					}
					this.z.tJ_RequestForRepair.Rows.Add(dataRow2);
					if (this.IsCrash)
					{
						this.ah.SelectedIndex = 0;
					}
					else
					{
						this.ah.SelectedIndex = 1;
					}
					if (this.ab.SelectedItem != null)
					{
						dataRow2["reguestFiled"] = this.ab.Text;
					}
				}
				break;
			case eActionRequestRepair.Edit:
				if (this.a > 0)
				{
					base.SelectSqlData(this.z, this.z.tJ_RequestForRepair, true, " where id = " + this.a.ToString());
					if (this.z.tJ_RequestForRepair.Rows.Count > 0 && this.z.tJ_RequestForRepair.Rows[0]["DateCreate"] != DBNull.Value)
					{
						this.b(Convert.ToDateTime(this.z.tJ_RequestForRepair.Rows[0]["DateCreate"]));
					}
					base.SelectSqlData(this.z, this.z.tJ_RequestForRepairDaily, true, " where idRequest = " + this.a.ToString());
					base.SelectSqlData(this.z, this.z.tJ_RequestForRepairDoc, true, " where idRequest = " + this.a.ToString());
					base.SelectSqlData(this.z, this.z.tJ_RequestForRepairAddress, true, " where idRequest = " + this.a.ToString());
					this.n();
					this.k();
				}
				break;
			case eActionRequestRepair.Read:
				if (this.a > 0)
				{
					base.SelectSqlData(this.z, this.z.tJ_RequestForRepair, true, " where id = " + this.a.ToString());
					base.SelectSqlData(this.z, this.z.tJ_RequestForRepairDaily, true, " where idRequest = " + this.a.ToString());
					base.SelectSqlData(this.z, this.z.tJ_RequestForRepairDoc, true, " where idRequest = " + this.a.ToString());
					base.SelectSqlData(this.z, this.z.tJ_RequestForRepairAddress, true, " where idRequest = " + this.a.ToString());
					this.n();
					this.k();
				}
				this.w();
				break;
			}
			if (this.z.tJ_RequestForRepair.Rows.Count > 0)
			{
				if (this.e == eActionRequestRepair.Edit && this.z.tJ_RequestForRepair.Rows[0]["Status"] != DBNull.Value)
				{
					this.h = Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["Status"]);
				}
				if (this.z.tJ_RequestForRepair.Rows[0]["Agreed"] != DBNull.Value)
				{
					this.j = Convert.ToBoolean(this.z.tJ_RequestForRepair.Rows[0]["Agreed"]);
				}
				if (this.b <= 0)
				{
					this.b = Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["IdDivision"]);
				}
				if (this.z.tJ_RequestForRepair.Rows[0]["Crash"] != DBNull.Value && Convert.ToBoolean(this.z.tJ_RequestForRepair.Rows[0]["Crash"]))
				{
					this.ah.Enabled = false;
					this.cm.Enabled = false;
					this.IsCrash = true;
				}
			}
			if (!this.IsCrash)
			{
				this.dn.Visible = false;
			}
			else
			{
				this.g();
				this.f();
			}
			this.v();
			if (this.b == 921)
			{
				this.ao.Visible = false;
			}
			this.i();
			this.c();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		private void a(object A_0, FormClosingEventArgs A_1)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.e != eActionRequestRepair.Read && !this.r())
				{
					MessageBox.Show("Не введены обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					A_1.Cancel = true;
					return;
				}
				eActionRequestRepair eActionRequestRepair = this.e;
				if (eActionRequestRepair != eActionRequestRepair.Add)
				{
					if (eActionRequestRepair == eActionRequestRepair.Edit)
					{
						this.z.tJ_RequestForRepair.Rows[0].EndEdit();
						base.UpdateSqlData(this.z, this.z.tJ_RequestForRepair);
					}
				}
				else
				{
					this.z.tJ_RequestForRepair.Rows[0].EndEdit();
					this.a = base.InsertSqlDataOneRow(this.z, this.z.tJ_RequestForRepair);
				}
				foreach (DataRow dataRow in this.z.tJ_RequestForRepairDaily)
				{
					if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
					{
						if (Convert.ToInt32(dataRow["idrequest"]) != this.a)
						{
							dataRow["idRequest"] = this.a;
						}
						dataRow.EndEdit();
					}
				}
				base.InsertSqlData(this.z, this.z.tJ_RequestForRepairDaily);
				base.UpdateSqlData(this.z, this.z.tJ_RequestForRepairDaily);
				base.DeleteSqlData(this.z, this.z.tJ_RequestForRepairDaily);
				this.m();
				this.l();
				this.j();
				this.b();
				this.q();
				this.h();
				this.e();
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000AF80 File Offset: 0x00009180
		private void a(object A_0, FormClosedEventArgs A_1)
		{
			base.SaveFormConfig(null);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000AF8C File Offset: 0x0000918C
		private void w()
		{
			this.ab.Enabled = false;
			this.ck.Enabled = false;
			this.ae.Enabled = false;
			this.al.ReadOnly = true;
			this.ak.ReadOnly = true;
			this.ah.Enabled = false;
			this.a3.Enabled = false;
			this.aq.ReadOnly = true;
			this.ap.ReadOnly = true;
			this.cj.ReadOnly = true;
			this.aw.Enabled = false;
			this.av.Enabled = false;
			this.@as.Enabled = false;
			this.dn.Enabled = false;
			this.cq.Enabled = (this.co.Enabled = (this.cs.Enabled = false));
			this.cv.Enabled = false;
			this.i();
			this.bd.Enabled = (this.c9.Enabled = false);
			this.bx.Enabled = false;
			this.ce.Enabled = false;
			this.ar.Visible = false;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000B0BC File Offset: 0x000092BC
		private void b(DateTime A_0)
		{
			this.f = A_0.AddDays(-1.0).Date;
			this.a9.MinDate = this.f;
			this.dl.MinDate = this.f;
			this.av.MinDate = this.f;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000B11A File Offset: 0x0000931A
		private void af(object A_0, EventArgs A_1)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000B11C File Offset: 0x0000931C
		private void v()
		{
			string str = "";
			if (this.b > 0)
			{
				DataTable dataTable = new DataTable("tR_Classifier");
				dataTable.Columns.Add("SocrName", typeof(string));
				base.SelectSqlData(dataTable, true, "where id = " + this.b.ToString(), false);
				if (dataTable.Rows.Count > 0)
				{
					str = " " + dataTable.Rows[0]["SocrName"].ToString();
				}
			}
			switch (this.e)
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

		// Token: 0x0600015C RID: 348 RVA: 0x0000B250 File Offset: 0x00009450
		private DataTable u()
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

		// Token: 0x0600015D RID: 349 RVA: 0x0000B308 File Offset: 0x00009508
		private DataTable t()
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

		// Token: 0x0600015E RID: 350 RVA: 0x0000B390 File Offset: 0x00009590
		private void s()
		{
			DataTable dataTable = this.t();
			base.SelectSqlData(dataTable, true, " order by name ", false);
			this.a0.DataSource = dataTable;
			this.a0.DisplayMember = "NAME";
			this.a0.ValueMember = "IDUSER";
			DataTable dataTable2 = this.u();
			base.SelectSqlData(dataTable2, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
			this.ab.DataSource = dataTable2;
			this.ab.DisplayMember = "FIO";
			this.ab.ValueMember = "ID";
			this.ck.DataSource = dataTable2;
			this.ck.DisplayMember = "FIO";
			this.ck.ValueMember = "ID";
			DataTable dataTable3 = this.u();
			base.SelectSqlData(dataTable3, true, " where ParentKey in (';GroupWorker;ReconcileRequestRepair;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
			this.@as.DataSource = dataTable3;
			this.@as.DisplayMember = "FIO";
			this.@as.ValueMember = "ID";
			base.SelectSqlData(this.z, this.z.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
			this.ae.DataSource = this.z.tR_Classifier;
			this.ae.DisplayMember = "name";
			this.ae.ValueMember = "ID";
			this.ae.SelectedIndex = -1;
			DataTable dataTable4 = new DataTable();
			dataTable4.Columns.Add("name", typeof(string));
			dataTable4.Columns.Add("value", typeof(bool));
			this.ah.DataSource = dataTable4;
			this.ah.DisplayMember = "name";
			this.ah.ValueMember = "value";
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
			base.SelectSqlData(dataTable5, true, string.Format(" where id in ({0}, {1})", 1402, 1401), false);
			this.dn.DisplayMember = "name";
			this.dn.ValueMember = "id";
			this.dn.DataSource = dataTable5;
			this.dn.SelectedIndex = -1;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000B670 File Offset: 0x00009870
		private bool r()
		{
			bool result = true;
			if (string.IsNullOrEmpty(this.ck.Text))
			{
				this.ac.ForeColor = Color.Red;
				result = false;
			}
			if (this.ae.SelectedIndex < 0)
			{
				this.ad.ForeColor = Color.Red;
				result = false;
			}
			if (string.IsNullOrEmpty(this.al.Text))
			{
				this.am.ForeColor = Color.Red;
				result = false;
			}
			if (string.IsNullOrEmpty(this.ak.Text))
			{
				this.aj.ForeColor = Color.Red;
				result = false;
			}
			if (this.ah.SelectedIndex < 0)
			{
				this.ai.ForeColor = Color.Red;
				result = false;
			}
			if (this.z.tJ_RequestForRepairDaily.Rows.Count <= 0)
			{
				List<Color> list = new List<Color>();
				foreach (object obj in this.a3.Controls)
				{
					Control control = (Control)obj;
					list.Add(control.ForeColor);
				}
				this.a3.ForeColor = Color.Red;
				int num = 0;
				foreach (object obj2 in this.a3.Controls)
				{
					((Control)obj2).ForeColor = list[num];
					num++;
				}
				result = false;
			}
			if (this.aw.Checked && this.b == 920)
			{
				if (this.cq.SelectedIndex < 0)
				{
					this.cr.ForeColor = Color.Red;
					result = true;
				}
				if (this.co.SelectedIndex < 0)
				{
					this.cp.ForeColor = Color.Red;
					result = true;
				}
				if (this.cs.SelectedIndex < 0)
				{
					this.ct.ForeColor = Color.Red;
					result = true;
				}
				if (this.cv.SelectedIndex < 0)
				{
					this.cw.ForeColor = Color.Red;
					result = false;
				}
				if (this.IsCrash && this.dn.SelectedIndex < 0)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000B8CC File Offset: 0x00009ACC
		private void q()
		{
			if (!this.k)
			{
				return;
			}
			if (!this.IsCrash)
			{
				return;
			}
			if (this.a == -1)
			{
				return;
			}
			if (!this.aw.Checked)
			{
				return;
			}
			base.SelectSqlData(this.z, this.z.tJ_RequestForRepair, true, " where id = " + this.a.ToString());
			if (this.z.tJ_RequestForRepair.Rows.Count > 0)
			{
				if (this.z.tJ_RequestForRepair.Rows[0]["idRIC"] == DBNull.Value)
				{
					try
					{
						RequestsServiceSoapClient requestsServiceSoapClient = new RequestsServiceSoapClient();
						Request request = new Request();
						if (this.z.tJ_RequestForRepair.Rows[0]["num"] != DBNull.Value)
						{
							request.Number = this.z.tJ_RequestForRepair.Rows[0]["num"].ToString();
						}
						if (this.z.tJ_RequestForRepair.Rows[0]["schmObj"] != DBNull.Value)
						{
							request.AddressDisableText = this.z.tJ_RequestForRepair.Rows[0]["schmObj"].ToString();
						}
						using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
						{
							sqlConnection.Open();
							DbDataAdapter dbDataAdapter = new SqlDataAdapter(" select o.name as city, o.socr as citytype, s.name as street, s.socr as streettype, a.house  from tj_requestforrepairaddress a  inner join tr_kladrstreet s on s.id = a.idkladrstreet  inner join tr_kladrobj o on o.id = s.kladrObjid  where a.idREquest = " + this.a.ToString(), sqlConnection);
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
						base.SelectSqlData(this.z, this.z.tJ_RequestForRepairDaily, true, " where idRequest = " + this.a.ToString());
						request.DateBeginEnd = new DateBeginEndList[this.z.tJ_RequestForRepairDaily.Rows.Count];
						for (int j = 0; j < this.z.tJ_RequestForRepairDaily.Rows.Count; j++)
						{
							DataRow dataRow2 = this.z.tJ_RequestForRepairDaily.Rows[j];
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
								if (j == this.z.tJ_RequestForRepairDaily.Rows.Count - 1)
								{
									request.DatePlan = new DateTime?(Convert.ToDateTime(dataRow2["dateEnd"]));
									request.DateEnd = new DateTime?(Convert.ToDateTime(dataRow2["dateEnd"]));
								}
							}
						}
						if (this.z.tJ_RequestForRepair.Rows[0]["typeDisable"] != DBNull.Value)
						{
							request.RefTypeDisable = (long)Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["typeDisable"]);
						}
						if (this.z.tJ_RequestForRepair.Rows[0]["purpose"] != DBNull.Value)
						{
							request.Cause = this.z.tJ_RequestForRepair.Rows[0]["purpose"].ToString();
						}
						if (this.z.tJ_RequestForRepair.Rows[0]["organization"] != DBNull.Value)
						{
							request.ToOrganizationId = Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["organization"]);
						}
						if (this.z.tJ_RequestForRepair.Rows[0]["status"] != DBNull.Value)
						{
							request.RefRequestStatusId = (long)Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["status"]);
						}
						if (this.z.tJ_RequestForRepair.Rows[0]["performerorganization"] != DBNull.Value)
						{
							request.PerformerOrganizationId = Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["performerorganization"]);
						}
						if (this.z.tJ_RequestForRepair.Rows[0]["groupWorks"] != DBNull.Value)
						{
							request.RefGroupWorksId = (long)Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["groupWorks"]);
						}
						if (this.z.tJ_RequestForRepair.Rows[0]["idRegion"] != DBNull.Value)
						{
							request.RefRegionId = (long)Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["idRegion"]);
						}
						Response response = requestsServiceSoapClient.SendReq(request);
						if (response.RequestId > 0L)
						{
							this.z.tJ_RequestForRepair.Rows[0]["idric"] = response.RequestId;
							this.z.tJ_RequestForRepair.Rows[0]["isSEnd"] = true;
							this.z.tJ_RequestForRepair.Rows[0].EndEdit();
							base.UpdateSqlData(this.z, this.z.tJ_RequestForRepair);
						}
						else
						{
							if (this.z.tJ_RequestForRepair.Rows[0]["messageRic"] == DBNull.Value)
							{
								this.z.tJ_RequestForRepair.Rows[0]["messageRic"] = response.Message;
							}
							else
							{
								this.z.tJ_RequestForRepair.Rows[0]["messageRic"] = response.Message + " \r\n" + this.z.tJ_RequestForRepair.Rows[0]["messageRic"].ToString();
							}
							if (this.z.tJ_RequestForRepair.Rows[0]["messageRic"].ToString().Length > 1024)
							{
								this.z.tJ_RequestForRepair.Rows[0]["messageRic"] = this.z.tJ_RequestForRepair.Rows[0]["messageRic"].ToString().Substring(0, 1024);
							}
							this.z.tJ_RequestForRepair.Rows[0]["isSEnd"] = false;
							this.z.tJ_RequestForRepair.Rows[0].EndEdit();
							base.UpdateSqlData(this.z, this.z.tJ_RequestForRepair);
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
				if (this.z.tJ_RequestForRepair.Rows[0]["Status"] == DBNull.Value)
				{
					return;
				}
				int num = Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["idRIC"]);
				if (this.h != Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["Status"]))
				{
					if (Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["Status"]) == 164277)
					{
						try
						{
							RequestsServiceSoapClient requestsServiceSoapClient2 = new RequestsServiceSoapClient();
							DateTime dateEnd = DateTime.Now;
							if (this.z.tJ_RequestForRepair.Rows[0]["dateFactEnd"] != DBNull.Value)
							{
								dateEnd = Convert.ToDateTime(this.z.tJ_RequestForRepair.Rows[0]["dateFactEnd"]);
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
					if (Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["Status"]) == 164280)
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

		// Token: 0x06000161 RID: 353 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		private void ae(object A_0, EventArgs A_1)
		{
			this.a6.Enabled = this.a7.Checked;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000C404 File Offset: 0x0000A604
		private void ad(object A_0, EventArgs A_1)
		{
			this.a8.MinDate = this.a9.Value.AddMinutes(1.0);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000C438 File Offset: 0x0000A638
		private void ac(object A_0, EventArgs A_1)
		{
			this.a9.MaxDate = this.a8.Value.AddMinutes(-1.0);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000C46C File Offset: 0x0000A66C
		private void p()
		{
			DateTime dateTime = DateTimePicker.MinimumDateTime;
			if (this.z.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.u, bool>(FormJournalRequestForRepairAddEdit.<>c.<>9.a)).Count<DataSetGES.u>() > 0)
			{
				try
				{
					DataRow dataRow = this.z.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.u, bool>(FormJournalRequestForRepairAddEdit.<>c.<>9.b)).OrderBy(new Func<DataSetGES.u, object>(FormJournalRequestForRepairAddEdit.<>c.<>9.c)).First<DataSetGES.u>();
					if (dataRow != null && dataRow["DateBeg"] != DBNull.Value)
					{
						dateTime = Convert.ToDateTime(dataRow["DateBeg"]);
					}
				}
				catch
				{
				}
			}
			if (this.z.tJ_RequestForRepair.Rows.Count > 0 && this.z.tJ_RequestForRepair.Rows[0]["DateCreate"] != DBNull.Value && dateTime < Convert.ToDateTime(this.z.tJ_RequestForRepair.Rows[0]["DateCreate"]).AddDays(-1.0).Date)
			{
				dateTime = Convert.ToDateTime(this.z.tJ_RequestForRepair.Rows[0]["DateCreate"]).AddDays(-1.0).Date;
			}
			this.dl.MinDate = dateTime;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000C624 File Offset: 0x0000A824
		private void a(object A_0, DataGridViewRowsAddedEventArgs A_1)
		{
			DataRow dataRow = this.z.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.u, bool>(FormJournalRequestForRepairAddEdit.<>c.<>9.d)).OrderByDescending(new Func<DataSetGES.u, DateTime>(FormJournalRequestForRepairAddEdit.<>c.<>9.e)).First<DataSetGES.u>();
			if (Convert.ToDateTime(dataRow["DateEnd"]) > this.a9.MaxDate)
			{
				this.a9.MaxDate = DateTimePicker.MaximumDateTime;
			}
			this.a9.MinDate = Convert.ToDateTime(dataRow["DateEnd"]);
			this.p();
			this.a(Convert.ToDateTime(dataRow["DateEnd"]));
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		private void a(DateTime A_0)
		{
			if (this.z.tJ_RequestForRepair.Rows.Count > 0 && ((this.z.tJ_RequestForRepair.Rows[0].HasVersion(DataRowVersion.Original) && this.z.tJ_RequestForRepair.Rows[0]["dateFactEnd", DataRowVersion.Original] == DBNull.Value) || !this.z.tJ_RequestForRepair.Rows[0].HasVersion(DataRowVersion.Original)) && !this.IsCrash)
			{
				this.dl.Value = A_0;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		private void a(object A_0, DataGridViewRowsRemovedEventArgs A_1)
		{
			this.p();
			if (this.z.tJ_RequestForRepairDaily.Rows.Count <= 0)
			{
				this.a9.MinDate = this.f;
				this.a(this.f);
				return;
			}
			if (this.z.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.u, bool>(FormJournalRequestForRepairAddEdit.<>c.<>9.f)).Count<DataSetGES.u>() > 0)
			{
				DataRow dataRow = this.z.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.u, bool>(FormJournalRequestForRepairAddEdit.<>c.<>9.g)).OrderByDescending(new Func<DataSetGES.u, DateTime>(FormJournalRequestForRepairAddEdit.<>c.<>9.h)).First<DataSetGES.u>();
				this.a9.MinDate = Convert.ToDateTime(dataRow["DateEnd"]);
				this.a(Convert.ToDateTime(dataRow["DateEnd"]));
				return;
			}
			this.a9.MinDate = this.f;
			this.a(this.f);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000C8D8 File Offset: 0x0000AAD8
		private void c(object A_0, DataGridViewCellEventArgs A_1)
		{
			this.p();
			if (A_1.RowIndex == this.a5.Rows.Count - 1)
			{
				DateTime dateTime = Convert.ToDateTime(this.a5[this.ci.Name, A_1.RowIndex].Value);
				if (dateTime > this.a9.MaxDate)
				{
					this.a9.MaxDate = DateTimePicker.MaximumDateTime;
				}
				this.a9.MinDate = dateTime;
				this.a(dateTime);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000C964 File Offset: 0x0000AB64
		private void a(object A_0, DataGridViewEditingControlShowingEventArgs A_1)
		{
			if (A_1.Control is DateTimePicker)
			{
				if (this.a5.CurrentCell.OwningColumn.Name == this.ch.Name)
				{
					(A_1.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.a5[this.ci.Name, this.a5.CurrentCell.RowIndex].Value);
					if (this.a5.CurrentCell.RowIndex == 0)
					{
						(A_1.Control as DateTimePicker).MinDate = this.f;
					}
					if (this.a5.CurrentCell.RowIndex > 0)
					{
						(A_1.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.a5[this.ci.Name, this.a5.CurrentCell.RowIndex - 1].Value);
					}
				}
				if (this.a5.CurrentCell.OwningColumn.Name == this.ci.Name)
				{
					(A_1.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.a5[this.ch.Name, this.a5.CurrentCell.RowIndex].Value);
					if (this.a5.CurrentCell.RowIndex == this.a5.Rows.Count - 1)
					{
						(A_1.Control as DateTimePicker).MaxDate = new DateTime(9998, 12, 31);
					}
					if (this.a5.CurrentCell.RowIndex < this.a5.Rows.Count - 1)
					{
						(A_1.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.a5[this.ch.Name, this.a5.CurrentCell.RowIndex + 1].Value);
					}
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		private void b(object A_0, DataGridViewCellFormattingEventArgs A_1)
		{
			if (A_1.RowIndex >= 0)
			{
				DayOfWeek dayOfWeek = DayOfWeek.Monday;
				if (this.a5[this.ch.Name, A_1.RowIndex].Value != null)
				{
					dayOfWeek = Convert.ToDateTime(this.a5[this.ch.Name, A_1.RowIndex].Value).DayOfWeek;
				}
				DayOfWeek dayOfWeek2 = DayOfWeek.Monday;
				if (this.a5[this.ci.Name, A_1.RowIndex].Value != null)
				{
					dayOfWeek2 = Convert.ToDateTime(this.a5[this.ci.Name, A_1.RowIndex].Value).DayOfWeek;
				}
				if ((dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Saturday) && this.a5.Columns[A_1.ColumnIndex] == this.ch)
				{
					A_1.CellStyle.ForeColor = Color.Red;
				}
				if ((dayOfWeek2 == DayOfWeek.Sunday || dayOfWeek2 == DayOfWeek.Saturday) && this.a5.Columns[A_1.ColumnIndex] == this.ci)
				{
					A_1.CellStyle.ForeColor = Color.Red;
				}
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		private void ab(object A_0, EventArgs A_1)
		{
			bool flag = false;
			this.a5.RowsAdded -= this.a;
			if (this.a7.Checked)
			{
				for (int i = 0; i <= (this.a8.Value - this.a9.Value).Days; i++)
				{
					if (this.a6.Checked || (this.a9.Value.AddDays((double)i).DayOfWeek != DayOfWeek.Saturday && this.a9.Value.AddDays((double)i).DayOfWeek != DayOfWeek.Sunday))
					{
						try
						{
							DataRow dataRow = this.z.tJ_RequestForRepairDaily.NewRow();
							dataRow["idRequest"] = this.a;
							dataRow["dateBeg"] = this.a9.Value.AddDays((double)i);
							dataRow["dateEnd"] = this.a9.Value.AddDays((double)i).Date + this.a8.Value.TimeOfDay;
							this.z.tJ_RequestForRepairDaily.Rows.Add(dataRow);
							flag = true;
							this.a3.ForeColor = SystemColors.ControlText;
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
					DataRow dataRow2 = this.z.tJ_RequestForRepairDaily.NewRow();
					dataRow2["idRequest"] = this.a;
					dataRow2["dateBeg"] = this.a9.Value;
					dataRow2["dateEnd"] = this.a8.Value;
					this.z.tJ_RequestForRepairDaily.Rows.Add(dataRow2);
					flag = true;
					this.a3.ForeColor = SystemColors.ControlText;
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			this.a5.RowsAdded += this.a;
			if (flag)
			{
				DataRow dataRow3 = this.z.tJ_RequestForRepairDaily.Where(new Func<DataSetGES.u, bool>(FormJournalRequestForRepairAddEdit.<>c.<>9.i)).OrderByDescending(new Func<DataSetGES.u, DateTime>(FormJournalRequestForRepairAddEdit.<>c.<>9.j)).First<DataSetGES.u>();
				if (Convert.ToDateTime(dataRow3["DateEnd"]) > this.a9.MaxDate)
				{
					this.a9.MaxDate = this.g;
				}
				this.a9.MinDate = Convert.ToDateTime(dataRow3["DateEnd"]);
				this.p();
				this.a(Convert.ToDateTime(dataRow3["DateEnd"]));
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000CFEC File Offset: 0x0000B1EC
		private void aa(object A_0, EventArgs A_1)
		{
			if (this.ah.SelectedIndex >= 0)
			{
				this.ai.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000D00C File Offset: 0x0000B20C
		private void z(object A_0, EventArgs A_1)
		{
			if (this.ab.SelectedIndex >= 0)
			{
				this.ba.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000D02C File Offset: 0x0000B22C
		private void y(object A_0, EventArgs A_1)
		{
			if (!string.IsNullOrEmpty(this.ck.Text))
			{
				this.ac.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000D050 File Offset: 0x0000B250
		private void x(object A_0, EventArgs A_1)
		{
			if (this.ae.SelectedIndex >= 0)
			{
				this.ad.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000D070 File Offset: 0x0000B270
		private void w(object A_0, EventArgs A_1)
		{
			if (!string.IsNullOrEmpty(this.al.Text))
			{
				this.am.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000D094 File Offset: 0x0000B294
		private void v(object A_0, EventArgs A_1)
		{
			if (!string.IsNullOrEmpty(this.ak.Text))
			{
				this.aj.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		private void u(object A_0, EventArgs A_1)
		{
			if (this.cv.SelectedIndex >= 0)
			{
				this.cw.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		private void t(object A_0, EventArgs A_1)
		{
			if (this.cq.SelectedIndex >= 0)
			{
				this.cr.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		private void s(object A_0, EventArgs A_1)
		{
			if (this.co.SelectedIndex >= 0)
			{
				this.cp.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000D118 File Offset: 0x0000B318
		private void r(object A_0, EventArgs A_1)
		{
			if (this.cs.SelectedIndex >= 0)
			{
				this.ct.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000D138 File Offset: 0x0000B338
		private void q(object A_0, EventArgs A_1)
		{
			if (this.ck.SelectedIndex >= 0)
			{
				this.ac.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000D158 File Offset: 0x0000B358
		private void o()
		{
			this.bm.Clear();
			if (this.z.tL_RequestForRepairSchmObjList.Rows.Count > 0)
			{
				DataView defaultView = this.z.tL_RequestForRepairSchmObjList.DefaultView;
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
							DataRow dataRow2 = this.bl.Tables[this.bm.TableName].NewRow();
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
							this.bl.Tables[this.bm.TableName].Rows.Add(dataRow2);
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
						flag = this.b(Convert.ToInt32(dataRow["idSchmObj"]));
					}
				}
				if (list.Count > 0)
				{
					list.Sort();
					DataRow dataRow4 = this.bl.Tables[this.bm.TableName].NewRow();
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
					this.bl.Tables[this.bm.TableName].Rows.Add(dataRow4);
				}
				if (this.bl.Tables[this.bm.TableName].Rows.Count > 0)
				{
					this.bg.Enabled = true;
					return;
				}
				this.bg.Enabled = false;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000D620 File Offset: 0x0000B820
		private bool b(int A_0)
		{
			return this.a != -1 && new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0} and idSchmObj = {1}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", this.a, A_0)).Rows.Count > 0;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000D673 File Offset: 0x0000B873
		private void n()
		{
			base.SelectSqlData(this.z, this.z.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.a.ToString());
			this.o();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		private void p(object A_0, EventArgs A_1)
		{
			c c = new c();
			c.SqlSettings = this.SqlSettings;
			if (c.ShowDialog() == DialogResult.OK)
			{
				int num = 1;
				if (this.z.tL_RequestForRepairSchmObjList.Rows.Count > 0)
				{
					num = (int)(this.z.tL_RequestForRepairSchmObjList.Where(new Func<DataSetGES.s, bool>(FormJournalRequestForRepairAddEdit.<>c.<>9.a)).Max(new Func<DataSetGES.s, short>(FormJournalRequestForRepairAddEdit.<>c.<>9.b)) + 1);
				}
				this.r = c.c();
				foreach (int num2 in this.r.Keys)
				{
					DataRow dataRow = this.z.tL_RequestForRepairSchmObjList.NewRow();
					dataRow["idRequest"] = this.a;
					dataRow["idSchmObj"] = num2;
					dataRow["DAteBeg"] = c.e();
					dataRow["DAteEnd"] = c.f();
					dataRow["duration"] = c.Duration;
					dataRow["num"] = num;
					this.z.tL_RequestForRepairSchmObjList.Rows.Add(dataRow);
				}
				this.o();
				this.a(this.r.Keys.ToList<int>());
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000D860 File Offset: 0x0000BA60
		private void b(object A_0, DataGridViewCellEventArgs A_1)
		{
			this.o(A_0, A_1);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000D86C File Offset: 0x0000BA6C
		private void a(object A_0, DataGridViewCellFormattingEventArgs A_1)
		{
			if (A_1.RowIndex >= 0 && A_1.ColumnIndex >= 0 && Convert.ToBoolean(this.bt[this.du.Name, A_1.RowIndex].Value))
			{
				A_1.CellStyle.BackColor = Color.LightGray;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		private void o(object A_0, EventArgs A_1)
		{
			if (this.bt.CurrentRow == null)
			{
				return;
			}
			if (Convert.ToBoolean(this.bt.CurrentRow.Cells[this.du.Name].Value))
			{
				MessageBox.Show("Редактирование невозможно. Существует согласованный подчиненный документ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			DataRow[] array = this.z.tL_RequestForRepairSchmObjList.Select("num = " + this.bt.CurrentRow.Cells[this.dt.Name].Value.ToString());
			this.r.Clear();
			if (array.Length != 0)
			{
				c c = new c();
				c.SqlSettings = this.SqlSettings;
				c.a(Convert.ToDateTime(array[0]["dateBeg"]));
				c.b(Convert.ToDateTime(array[0]["dateEnd"]));
				c.Duration = array[0]["Duration"].ToString();
				c.a(Convert.ToInt16(array[0]["Num"]));
				foreach (DataRow dataRow in array)
				{
					this.r.Add(Convert.ToInt32(dataRow["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
					{
						dataRow["idSchmObj"].ToString()
					}).ToString());
				}
				c.a(this.r);
				if (c.ShowDialog() == DialogResult.OK)
				{
					this.r = c.c();
					foreach (DataRow dataRow2 in array)
					{
						if (this.r.ContainsKey(Convert.ToInt32(dataRow2["idSchmObj"])))
						{
							dataRow2["DAteBeg"] = c.e();
							dataRow2["DAteEnd"] = c.f();
							dataRow2["duration"] = c.Duration;
							this.r.Remove(Convert.ToInt32(dataRow2["idSchmObj"]));
						}
						else
						{
							dataRow2.Delete();
						}
					}
					foreach (int num in this.r.Keys)
					{
						DataRow dataRow3 = this.z.tL_RequestForRepairSchmObjList.NewRow();
						dataRow3["idRequest"] = this.a;
						dataRow3["idSchmObj"] = num;
						dataRow3["DAteBeg"] = c.e();
						dataRow3["DAteEnd"] = c.f();
						dataRow3["duration"] = c.Duration;
						dataRow3["num"] = c.d();
						this.z.tL_RequestForRepairSchmObjList.Rows.Add(dataRow3);
					}
					this.o();
				}
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000DC04 File Offset: 0x0000BE04
		private void n(object A_0, EventArgs A_1)
		{
			foreach (object obj in this.bt.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (Convert.ToBoolean(dataGridViewRow.Cells[this.du.Name].Value))
				{
					MessageBox.Show("Удаление невозможно. Существует согласованный подчиненный документ.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;
				}
				DataRow[] array = this.z.tL_RequestForRepairSchmObjList.Select("num = " + dataGridViewRow.Cells[this.dt.Name].Value.ToString());
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Delete();
				}
			}
			this.o();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		private void m(object A_0, EventArgs A_1)
		{
			this.r.Clear();
			foreach (object obj in this.bt.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				foreach (DataRow dataRow in this.z.tL_RequestForRepairSchmObjList.Select("num = " + dataGridViewRow.Cells[this.dt.Name].Value.ToString()))
				{
					if (!this.r.ContainsKey(Convert.ToInt32(dataRow["idSchmObj"])))
					{
						this.r.Add(Convert.ToInt32(dataRow["idSchmObj"]), "");
					}
				}
			}
			GoToSchemaEventArgs goToSchemaEventArgs = new GoToSchemaEventArgs(this.r.Keys.ToList<int>());
			this.OnGoToSchema(goToSchemaEventArgs);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000DE10 File Offset: 0x0000C010
		private void m()
		{
			foreach (DataRow dataRow in this.z.tL_RequestForRepairSchmObjList)
			{
				if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
				{
					dataRow["idRequest"] = this.a;
					dataRow.EndEdit();
				}
			}
			base.InsertSqlData(this.z, this.z.tL_RequestForRepairSchmObjList);
			base.UpdateSqlData(this.z, this.z.tL_RequestForRepairSchmObjList);
			base.DeleteSqlData(this.z, this.z.tL_RequestForRepairSchmObjList);
			this.z.tL_RequestForRepairSchmObjList.AcceptChanges();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		private void l(object A_0, EventArgs A_1)
		{
			if (this.aw.Checked)
			{
				if (this.z.tJ_RequestForRepair.Rows.Count > 0 && this.av.Value == null)
				{
					this.av.Value = DateTime.Now;
					return;
				}
			}
			else if (this.z.tJ_RequestForRepair.Rows.Count > 0 && this.av.Value != null)
			{
				this.av.Value = null;
				this.cv.SelectedIndex = -1;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000DF76 File Offset: 0x0000C176
		private void k(object A_0, EventArgs A_1)
		{
			this.i();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000DF7E File Offset: 0x0000C17E
		private void j(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000DF8D File Offset: 0x0000C18D
		private void i(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000DF9C File Offset: 0x0000C19C
		private void h(object A_0, EventArgs A_1)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					for (int i = 0; i < openFileDialog.FileNames.Length; i++)
					{
						DataRow dataRow = this.z.tJ_RequestForRepairDoc.NewRow();
						dataRow["idRequest"] = this.a;
						dataRow["Document"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
						dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
						this.z.tJ_RequestForRepairDoc.Rows.Add(dataRow);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000E06C File Offset: 0x0000C26C
		private void g(object A_0, EventArgs A_1)
		{
			if (this.bv.CurrentRow != null)
			{
				Convert.ToInt32(this.bv.CurrentRow.Cells[this.b7.Name].Value);
				this.bv.Rows.Remove(this.bv.CurrentRow);
				return;
			}
			MessageBox.Show("Не выбрано ни одного файла");
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		private void f(object A_0, EventArgs A_1)
		{
			if (this.bv.CurrentRow == null)
			{
				return;
			}
			int a_ = Convert.ToInt32(this.bv.CurrentRow.Cells[this.b7.Name].Value);
			byte[] array = (byte[])this.z.tJ_RequestForRepairDoc.b(a_)["Document"];
			string text = Path.GetTempFileName();
			text = Path.ChangeExtension(text, Path.GetExtension(this.z.tJ_RequestForRepairDoc.b(a_)["FileName"].ToString()));
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

		// Token: 0x06000188 RID: 392 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		private void e(object A_0, EventArgs A_1)
		{
			try
			{
				int a_ = Convert.ToInt32(this.bv.CurrentRow.Cells[this.b7.Name].Value);
				string text = this.bv.CurrentRow.Cells[this.ca.Name].Value.ToString();
				string extension = Path.GetExtension(text);
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
				saveFileDialog.FileName = text;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					byte[] array = (byte[])this.z.tJ_RequestForRepairDoc.b(a_)["Document"];
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

		// Token: 0x06000189 RID: 393 RVA: 0x0000E2BC File Offset: 0x0000C4BC
		private void a(object A_0, DataGridViewCellValueEventArgs A_1)
		{
			if (this.bv.RowCount > 0 && this.bv[this.ca.Name, A_1.RowIndex].Value != null && A_1.ColumnIndex == this.bv.Columns[this.b8.Name].Index)
			{
				Icon icon = global::i.a(this.bv[this.ca.Name, A_1.RowIndex].Value.ToString());
				A_1.Value = icon.ToBitmap();
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000E360 File Offset: 0x0000C560
		private void a(object A_0, DataGridViewCellEventArgs A_1)
		{
			if (this.bv.CurrentRow == null)
			{
				return;
			}
			int a_ = Convert.ToInt32(this.bv.CurrentRow.Cells[this.b7.Name].Value);
			if (A_1.ColumnIndex == this.bv.Columns[this.ca.Name].Index)
			{
				byte[] array = (byte[])this.z.tJ_RequestForRepairDoc.b(a_)["Document"];
				string text = Path.GetTempFileName();
				text = Path.ChangeExtension(text, Path.GetExtension(this.z.tJ_RequestForRepairDoc.b(a_)["FileName"].ToString()));
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

		// Token: 0x0600018B RID: 395 RVA: 0x0000E460 File Offset: 0x0000C660
		private void l()
		{
			foreach (DataRow dataRow in this.z.tJ_RequestForRepairDoc)
			{
				if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
				{
					dataRow["idRequest"] = this.a;
					dataRow.EndEdit();
				}
			}
			base.InsertSqlData(this.z, this.z.tJ_RequestForRepairDoc);
			base.UpdateSqlData(this.z, this.z.tJ_RequestForRepairDoc);
			base.DeleteSqlData(this.z, this.z.tJ_RequestForRepairDoc);
			this.z.tL_RequestForRepairSchmObjList.AcceptChanges();
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000E534 File Offset: 0x0000C734
		private void d(object A_0, EventArgs A_1)
		{
			if (this.z.tJ_RequestForRepair.Rows.Count <= 0)
			{
				return;
			}
			DataTable dataTable = this.z.tJ_RequestForRepair.Copy();
			DataRow dataRow = dataTable.NewRow();
			dataRow.ItemArray = dataTable.Rows[0].ItemArray;
			this.z.tJ_RequestForRepair.Clear();
			this.z.tJ_RequestForRepairDoc.Clear();
			this.z.tJ_RequestForRepairDaily.Clear();
			DataRow dataRow2 = this.z.tJ_RequestForRepair.NewRow();
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
			DataTable dataTable2 = this.t();
			base.SelectSqlData(dataTable2, true, " where [Login] = SYSTEM_USER ", false);
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
			this.a = -1;
			this.e = eActionRequestRepair.Add;
			this.z.tJ_RequestForRepair.Rows.Add(dataRow2);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000E858 File Offset: 0x0000CA58
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
			if (this.e == eActionRequestRepair.Add && this.ae.SelectedValue != null)
			{
				xmlAttribute.Value = this.ae.SelectedValue.ToString();
			}
			else
			{
				xmlAttribute.Value = this.s.ToString();
			}
			xmlNode.Attributes.Append(xmlAttribute);
			return xmlDocument;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000E95C File Offset: 0x0000CB5C
		protected override void ApplyConfig(XmlDocument doc)
		{
			XmlNode xmlNode = doc.SelectSingleNode(base.Name);
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
					this.s = Convert.ToInt32(xmlAttribute.Value);
				}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000EA72 File Offset: 0x0000CC72
		private void a(List<int> A_0)
		{
			this.cx.Panel2.Enabled = false;
			this.bd.Enabled = false;
			this.dc.RunWorkerAsync(A_0);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		private void a(object A_0, DoWorkEventArgs A_1)
		{
			FormJournalRequestForRepairAddEdit.a a = new FormJournalRequestForRepairAddEdit.a();
			if (this.t == null)
			{
				this.t = new ElectricModel();
				this.t.SqlSettings = this.SqlSettings;
				this.t.LoadSchema(false);
			}
			if (this.v == null)
			{
				this.v = new DataTable("tr_kladrstreet");
				base.SelectSqlData(this.v, true, "where deleted = 0", false);
			}
			if (this.u == null)
			{
				this.u = new DataTable("tr_kladrObj");
				base.SelectSqlData(this.u, true, "where deleted = 0", false);
			}
			if (this.w == null)
			{
				this.w = new DataTable();
				this.w.Columns.Add("KladrObjId", typeof(int));
				this.w.Columns.Add("idstreet", typeof(int));
				this.w.Columns.Add("house", typeof(string));
			}
			else
			{
				this.w.Clear();
			}
			a.a = (List<int>)A_1.Argument;
			IEnumerable<ElectricObject> enumerable = this.t.Objects.Where(new Func<ElectricObject, bool>(a.b));
			if (enumerable.Count<ElectricObject>() > 0)
			{
				List<ElectricObject> list = new List<ElectricObject>();
				foreach (ElectricObject obj in enumerable)
				{
					list.AddRange(this.t.PoweringReportForDrawObject(obj, true, true));
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
							}.Fill(this.w);
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, ex.Source);
						}
					}
				}
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000ED54 File Offset: 0x0000CF54
		private void a(object A_0, RunWorkerCompletedEventArgs A_1)
		{
			try
			{
				foreach (object obj in this.w.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (dataRow["idstreet"] != DBNull.Value && dataRow["house"] != DBNull.Value && this.z.tJ_RequestForRepairAddress.Select(string.Concat(new string[]
					{
						"idKladrStreet = ",
						dataRow["idStreet"].ToString(),
						" and house = '",
						dataRow["house"].ToString(),
						"'"
					})).Length == 0)
					{
						DataRow dataRow2 = this.z.tJ_RequestForRepairAddress.NewRow();
						dataRow2["idRequest"] = this.a;
						dataRow2["idKladrObj"] = dataRow["kladrObjId"];
						dataRow2["idKladrStreet"] = dataRow["idstreet"];
						dataRow2["house"] = dataRow["house"];
						this.z.tJ_RequestForRepairAddress.Rows.Add(dataRow2);
					}
				}
				this.k();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			this.cx.Panel2.Enabled = true;
			this.bd.Enabled = true;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000EF18 File Offset: 0x0000D118
		private void k()
		{
			this.cy.Clear();
			if (this.v == null)
			{
				this.v = new DataTable("tr_kladrstreet");
				base.SelectSqlData(this.v, true, "where deleted = 0", false);
			}
			if (this.u == null)
			{
				this.u = new DataTable("tr_kladrObj");
				base.SelectSqlData(this.u, true, "where deleted = 0", false);
			}
			foreach (DataRow dataRow in this.z.tJ_RequestForRepairAddress)
			{
				if (dataRow.RowState != DataRowState.Deleted)
				{
					DataRow dataRow2 = this.cy.NewRow();
					dataRow2["id"] = dataRow["id"];
					dataRow2["idKladrObj"] = dataRow["idKladrObj"];
					dataRow2["idKladrStreet"] = dataRow["idKladrstreet"];
					dataRow2["house"] = dataRow["house"];
					DataRow[] array = this.u.Select("id = " + dataRow["idKladrObj"].ToString());
					if (array.Length != 0)
					{
						dataRow2["City"] = array[0]["name"].ToString() + " " + array[0]["socr"].ToString();
					}
					DataRow[] array2 = this.v.Select("id = " + dataRow["idKladrStreet"].ToString());
					if (array2.Length != 0)
					{
						dataRow2["Street"] = array2[0]["name"].ToString() + " " + array2[0]["socr"].ToString();
					}
					this.cy.Rows.Add(dataRow2);
				}
			}
			List<int> list = new List<int>();
			foreach (object obj in this.cy.Rows)
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
				DataRow[] array3 = this.cy.Select("idkladrstreet = " + num.ToString());
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
			this.cj.Text = text;
			if (!string.IsNullOrEmpty(this.cj.Text))
			{
				this.ax.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		private void c(object A_0, EventArgs A_1)
		{
			d d = new d();
			d.SqlSettings = this.SqlSettings;
			if (d.ShowDialog() == DialogResult.OK)
			{
				foreach (object obj in d.a.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (this.z.tJ_RequestForRepairAddress.Select(string.Concat(new string[]
					{
						"idKladrStreet = ",
						dataRow["idStreet"].ToString(),
						" and house = '",
						dataRow["house"].ToString(),
						"'"
					})).Length == 0)
					{
						DataRow dataRow2 = this.z.tJ_RequestForRepairAddress.NewRow();
						dataRow2["idRequest"] = this.a;
						dataRow2["idKladrObj"] = dataRow["idKladrObj"];
						dataRow2["idKladrStreet"] = dataRow["idstreet"];
						dataRow2["house"] = dataRow["house"];
						this.z.tJ_RequestForRepairAddress.Rows.Add(dataRow2);
					}
				}
				this.k();
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000F45C File Offset: 0x0000D65C
		private void b(object A_0, EventArgs A_1)
		{
			if (this.c7.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить выбранные строки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				foreach (object obj in this.c7.SelectedRows)
				{
					int num = Convert.ToInt32(((DataGridViewRow)obj).Cells[this.de.Name].Value);
					DataRow[] array = this.z.tJ_RequestForRepairAddress.Select("id = " + num.ToString());
					if (array.Length != 0)
					{
						array[0].Delete();
					}
				}
				this.k();
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000F534 File Offset: 0x0000D734
		private void j()
		{
			foreach (DataRow dataRow in this.z.tJ_RequestForRepairAddress)
			{
				if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
				{
					dataRow["idRequest"] = this.a;
					dataRow.EndEdit();
				}
			}
			base.InsertSqlData(this.z, this.z.tJ_RequestForRepairAddress);
			base.UpdateSqlData(this.z, this.z.tJ_RequestForRepairAddress);
			base.DeleteSqlData(this.z, this.z.tJ_RequestForRepairAddress);
			this.z.tL_RequestForRepairSchmObjList.AcceptChanges();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000F608 File Offset: 0x0000D808
		private void i()
		{
			if (this.i || this.e == eActionRequestRepair.Read)
			{
				this.dv.Enabled = false;
				return;
			}
			if (this.z.tJ_RequestForRepair.Rows.Count <= 0)
			{
				this.dv.Enabled = false;
				return;
			}
			if (this.z.tJ_RequestForRepair.Rows[0]["Agreed"] == DBNull.Value)
			{
				this.dv.Enabled = false;
				return;
			}
			if (!Convert.ToBoolean(this.z.tJ_RequestForRepair.Rows[0]["Agreed"]))
			{
				this.dv.Enabled = false;
				return;
			}
			if (this.z.tJ_RequestForRepair.Rows[0].RowState != DataRowState.Modified && this.z.tJ_RequestForRepair.Rows[0].RowState != DataRowState.Unchanged)
			{
				this.dv.Enabled = true;
				return;
			}
			if (this.z.tJ_RequestForRepair.Rows[0]["SendSite", DataRowVersion.Original] != DBNull.Value && Convert.ToBoolean(this.z.tJ_RequestForRepair.Rows[0]["SendSite", DataRowVersion.Original]))
			{
				this.dv.Enabled = false;
				return;
			}
			this.dv.Enabled = true;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000F784 File Offset: 0x0000D984
		private void h()
		{
			if (this.i)
			{
				try
				{
					global::g.a(this.SqlSettings);
					global::g.a(this.SqlSettings, global::g.c(), DateTime.Now);
					global::g.a();
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
					return;
				}
			}
			try
			{
				global::h.a(this.SqlSettings);
				global::h.a(this.SqlSettings, global::h.c(), DateTime.Now.Date, DateTime.Now.Date.AddDays(8.0).AddMilliseconds(-1.0));
				global::h.a();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message, "Отправка на сайт", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000F868 File Offset: 0x0000DA68
		private void a(object A_0, EventArgs A_1)
		{
			new FormSettingsSender
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000F88C File Offset: 0x0000DA8C
		private void g()
		{
			if (this.a == -1)
			{
				return;
			}
			DataTable dataTable = new DataTable("tJ_damage");
			dataTable.Columns.Add("id", typeof(int));
			base.SelectSqlData(dataTable, true, " where idReqForRepair = " + this.a.ToString() + " and deleted = 0", false);
			if (dataTable.Rows.Count > 0)
			{
				this.dn.Enabled = false;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000F908 File Offset: 0x0000DB08
		private void f()
		{
			if (this.a == -1)
			{
				return;
			}
			if (new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", this.a)).Rows.Count > 0)
			{
				this.a4.Enabled = false;
				this.a5.ReadOnly = true;
				this.aw.Enabled = false;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000F978 File Offset: 0x0000DB78
		private bool e()
		{
			if (this.a == -1)
			{
				return true;
			}
			if (!this.IsCrash)
			{
				return true;
			}
			DataSetGES dataSetGES = new DataSetGES();
			base.SelectSqlData(dataSetGES, dataSetGES.tJ_Damage, true, "where idReqForRepair = " + this.a.ToString());
			base.SelectSqlData(dataSetGES, dataSetGES.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.a.ToString());
			if (this.aw.Checked)
			{
				foreach (DataRow dataRow in dataSetGES.tJ_Damage)
				{
					if (!Convert.ToBoolean(dataRow["Deleted"]) && dataSetGES.tL_RequestForRepairSchmObjList.Select("idSchmObj = " + dataRow["idSchmObj"].ToString()).Length == 0)
					{
						dataRow["deleted"] = true;
						dataRow.EndEdit();
						base.UpdateSqlData(dataSetGES, dataSetGES.tJ_Damage);
						DataSetGES dataSetGES2 = new DataSetGES();
						base.SelectSqlData(dataSetGES2, dataSetGES2.tJ_Damage, true, "where idParent = " + dataRow["id"].ToString());
						foreach (DataSetGES.y y in dataSetGES2.tJ_Damage)
						{
							y["deleted"] = true;
							y.EndEdit();
							base.UpdateSqlData(dataSetGES2, dataSetGES2.tJ_Damage);
						}
					}
				}
				base.SelectSqlData(dataSetGES, dataSetGES.tJ_Damage, true, "where idReqForRepair = " + this.a.ToString());
				foreach (DataRow dataRow2 in dataSetGES.tL_RequestForRepairSchmObjList)
				{
					DataRow[] array = dataSetGES.tJ_Damage.Select("idSchmObj = " + dataRow2["idSchmObj"].ToString());
					if (array.Length != 0)
					{
						this.a(array[0]);
					}
					else
					{
						this.a(Convert.ToInt32(dataRow2["idSchmObj"]));
					}
				}
			}
			return true;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000FBD8 File Offset: 0x0000DDD8
		private void a(DataRow A_0)
		{
			if (A_0["isApply"] != DBNull.Value && Convert.ToBoolean(A_0["isApply"]))
			{
				return;
			}
			DataSetGES dataSetGES = new DataSetGES();
			base.SelectSqlData(dataSetGES, dataSetGES.tJ_Damage, true, "where idParent = " + A_0["id"].ToString());
			bool flag = false;
			foreach (DataRow dataRow in dataSetGES.tJ_Damage)
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
			A_0["Deleted"] = 0;
			A_0["dateDoc"] = this.z.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
			A_0.EndEdit();
			base.UpdateSqlDataOnlyChange(A_0.Table);
			foreach (DataSetGES.y y in dataSetGES.tJ_Damage)
			{
				y["dateDoc"] = this.z.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
				y.EndEdit();
			}
			base.UpdateSqlData(dataSetGES.tJ_Damage);
			this.a(Convert.ToInt32(A_0["id"]), Convert.ToDateTime(this.z.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]), Convert.ToInt32(A_0["idSchmObj"]));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		private void a(int A_0)
		{
			DataSetGES dataSetGES = new DataSetGES();
			DataRow dataRow = dataSetGES.tJ_Damage.NewRow();
			dataRow["TypeDoc"] = this.z.tJ_RequestForRepair.Rows[0]["idTypeDamage"];
			dataRow["dateDoc"] = this.z.tJ_RequestForRepairDaily.Rows[0]["dateBeg"];
			dataRow["idSchmObj"] = A_0;
			dataRow["idReqForRepair"] = this.a;
			dataSetGES.tJ_Damage.Rows.Add(dataRow);
			int num = base.InsertSqlDataOneRow(dataSetGES, dataSetGES.tJ_Damage);
			if (num > 0)
			{
				this.a(num, Convert.ToDateTime(this.z.tJ_RequestForRepairDaily.Rows[0]["dateBeg"]), A_0);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000FE98 File Offset: 0x0000E098
		private void a(int A_0, DateTime A_1, int A_2)
		{
			FormJournalRequestForRepairAddEdit.b b = new FormJournalRequestForRepairAddEdit.b();
			b.a = A_2;
			int num = Convert.ToInt32(this.z.tJ_RequestForRepair.Rows[0]["idTypeDamage"]);
			DataSetGES dataSetGES = new DataSetGES();
			if (num == 1402)
			{
				base.SelectSqlData(dataSetGES.tJ_DamageHV, true, "where idDamage = " + A_0.ToString(), false);
				DataRow dataRow;
				if (dataSetGES.tJ_DamageHV.Rows.Count > 0)
				{
					dataRow = dataSetGES.tJ_DamageHV.Rows[0];
				}
				else
				{
					dataRow = dataSetGES.tJ_DamageHV.NewRow();
					dataRow["idDamage"] = A_0;
				}
				ElectricModel electricModel = new ElectricModel();
				electricModel.SqlSettings = this.SqlSettings;
				electricModel.LoadSchema(A_1);
				TreeNodeObj a_ = electricModel.PoweringReportForDrawObject(b.a, true);
				List<int> list = new List<int>();
				FormJournalRequestForRepairAddEdit.a(a_, list);
				DataTable dataTable = FormJournalRequestForRepairAddEdit.a(list, this.SqlSettings);
				dataRow["countSchmObj"] = dataTable.Rows.Count;
				dataRow["countSchmObjOff"] = 0;
				dataRow["ConnectedPower"] = dataTable.Compute("Sum(Power)", "");
				dataRow["PowerA"] = dataTable.Compute("Sum(Load)", "");
				dataRow["TransOff"] = FormJournalRequestForRepairAddEdit.b(dataTable).InnerXml;
				if (dataRow["CoefFI"] == DBNull.Value)
				{
					dataRow["CoefFI"] = 0.9;
				}
				if (dataRow["CoefSeason"] == DBNull.Value)
				{
					dataRow["CoefSeason"] = 0.8;
				}
				IEnumerable<ElectricObject> source = electricModel.Objects.Where(new Func<ElectricObject, bool>(b.b));
				List<ElectricObject> list2 = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
				DataTable dataTable2 = new DataTable("vl_schmAbnFull");
				dataTable2.Columns.Add("idAbn", typeof(int));
				dataTable2.Columns.Add("idAbnObj", typeof(int));
				if (list2.Count > 0)
				{
					string text = "";
					foreach (ElectricObject electricObject in list2)
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
				dataRow["AbnOff"] = FormJournalRequestForRepairAddEdit.a(dataTable2).InnerXml;
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
				base.SelectSqlData(dataSetGES.tJ_DamageLV, true, "where idDamage = " + A_0.ToString(), false);
				DataRow dataRow2;
				if (dataSetGES.tJ_DamageLV.Rows.Count > 0)
				{
					dataRow2 = dataSetGES.tJ_DamageLV.Rows[0];
				}
				else
				{
					dataRow2 = dataSetGES.tJ_DamageLV.NewRow();
					dataRow2["idDamage"] = A_0;
				}
				ElectricModel electricModel2 = new ElectricModel();
				electricModel2.SqlSettings = this.SqlSettings;
				electricModel2.LoadSchema(A_1);
				electricModel2.PoweringReportForDrawObject(b.a, true);
				IEnumerable<ElectricObject> source2 = electricModel2.Objects.Where(new Func<ElectricObject, bool>(b.c));
				List<ElectricObject> list3 = electricModel2.PoweringReportForDrawObject(source2.First<ElectricObject>(), true, true);
				DataTable dataTable3 = new DataTable("vl_schmAbnFull");
				dataTable3.Columns.Add("idAbn", typeof(int));
				dataTable3.Columns.Add("idAbnObj", typeof(int));
				if (list3.Count > 0)
				{
					string text2 = "";
					foreach (ElectricObject electricObject2 in list3)
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
				dataRow2["AbnOff"] = FormJournalRequestForRepairAddEdit.a(dataTable3).InnerXml;
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

		// Token: 0x0600019F RID: 415 RVA: 0x00010410 File Offset: 0x0000E610
		private static void a(TreeNodeObj A_0, List<int> A_1)
		{
			if (A_0.Tag != null && A_0.Tag is ElectricLine)
			{
				foreach (ElectricRelation electricRelation in ((ElectricLine)A_0.Tag).Relations)
				{
					foreach (ElectricObject electricObject in electricRelation.ChildObjects)
					{
						if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && !A_1.Contains(electricObject.Id))
						{
							A_1.Add(electricObject.Id);
						}
					}
				}
			}
			foreach (TreeNodeObj a_ in A_0.Nodes)
			{
				FormJournalRequestForRepairAddEdit.a(a_, A_1);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00010524 File Offset: 0x0000E724
		private static DataTable a(List<int> A_0, SQLSettings A_1)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("idTr", typeof(int));
			dataTable.Columns.Add("TrName", typeof(string));
			dataTable.Columns.Add("idSub", typeof(int));
			dataTable.Columns.Add("Sub", typeof(string));
			dataTable.Columns.Add("Power", typeof(int));
			dataTable.Columns.Add("load", typeof(int));
			dataTable.Clear();
			using (SqlConnection sqlConnection = new SqlConnection(A_1.GetConnectionString() + ";Connection Timeout=1000"))
			{
				sqlConnection.Open();
				using (SqlCommand sqlCommand = new SqlCommand(global::f.a("RequestsClient.DataSets.GetTransformerSchmObj.sql"), sqlConnection))
				{
					sqlCommand.CommandTimeout = 0;
					DataTable dataTable2 = new DataTable();
					new SqlDataAdapter(sqlCommand).Fill(dataTable2);
					int num = 0;
					foreach (int num2 in A_0)
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
								num += Convert.ToInt32(array[0]["Мощность"]);
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

		// Token: 0x060001A1 RID: 417 RVA: 0x000108D4 File Offset: 0x0000EAD4
		private static XmlDocument b(DataTable A_0)
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode xmlNode = xmlDocument.CreateElement("TransOff");
			xmlDocument.AppendChild(xmlNode);
			foreach (object obj in A_0.Rows)
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

		// Token: 0x060001A2 RID: 418 RVA: 0x00010A38 File Offset: 0x0000EC38
		private static XmlDocument a(DataTable A_0)
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode xmlNode = xmlDocument.CreateElement("AbnOff");
			xmlDocument.AppendChild(xmlNode);
			foreach (object obj in A_0.Rows)
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

		// Token: 0x060001A3 RID: 419 RVA: 0x00010AFC File Offset: 0x0000ECFC
		private void d()
		{
			this.x = new Dictionary<int, string>();
			this.x.Add(1, "Создана");
			this.x.Add(2, "Согласована");
			this.x.Add(3, "Отправлена на сайт");
			this.x.Add(104, "Зарегистрирована");
			this.x.Add(105, "Отменена");
			this.x.Add(106, "В работе");
			this.x.Add(7, "Перенесено время работы");
			this.x.Add(107, "Перенесено время работы");
			this.x.Add(108, "Выполнена");
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00010BB2 File Offset: 0x0000EDB2
		private void c()
		{
			if (this.a > 0)
			{
				base.SelectSqlData(this.z.tJ_RequestForRepairLog, true, "where idRequest = " + this.a.ToString(), false);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00010BE8 File Offset: 0x0000EDE8
		private void b()
		{
			if (this.z.tJ_RequestForRepair.Rows.Count == 0)
			{
				return;
			}
			DataTable dataTable = this.z.tJ_RequestForRepairLog;
			DataRow[] array = dataTable.Select("idCommand = 108");
			if (array.Length != 0)
			{
				return;
			}
			DataTable a_ = new DataTable("tUser");
			DataRow dataRow = this.z.tJ_RequestForRepair.Rows[0];
			if (dataRow.RowState == DataRowState.Added)
			{
				this.a(a_, 1);
				if (dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]))
				{
					this.a(a_, 2);
				}
				if (dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"]))
				{
					this.a(a_, 3);
				}
				if (dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]) && dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"]))
				{
					this.a(a_, 104);
				}
			}
			if (dataRow.RowState == DataRowState.Modified)
			{
				array = dataTable.Select("idCommand = 2");
				if (array.Length == 0 && (dataRow["Agreed", DataRowVersion.Original] == DBNull.Value || !Convert.ToBoolean(dataRow["Agreed", DataRowVersion.Original])) && dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]))
				{
					this.a(a_, 2);
				}
				array = dataTable.Select("idCommand = 3");
				if (array.Length == 0 && (dataRow["SendSite", DataRowVersion.Original] == DBNull.Value || !Convert.ToBoolean(dataRow["SendSite", DataRowVersion.Original])) && dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"]))
				{
					this.a(a_, 3);
				}
				array = dataTable.Select("idCommand = 104");
				if (array.Length == 0 && (dataRow["Agreed", DataRowVersion.Original] == DBNull.Value || !Convert.ToBoolean(dataRow["Agreed", DataRowVersion.Original]) || dataRow["SendSite", DataRowVersion.Original] == DBNull.Value || !Convert.ToBoolean(dataRow["SendSite", DataRowVersion.Original])) && dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]) && dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"]))
				{
					this.a(a_, 104);
				}
				array = dataTable.Select("idCommand = 104");
				if (array.Length != 0 && dataRow["Agreed", DataRowVersion.Original] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed", DataRowVersion.Original]) && dataRow["Agreed"] != DBNull.Value && !Convert.ToBoolean(dataRow["Agreed"]))
				{
					this.a(a_, 105);
				}
				array = dataTable.Select("idCommand = 105");
				if (array.Length != 0)
				{
					if (dataRow["Agreed", DataRowVersion.Original] != DBNull.Value && !Convert.ToBoolean(dataRow["Agreed", DataRowVersion.Original]) && dataRow["Agreed"] != DBNull.Value && Convert.ToBoolean(dataRow["Agreed"]))
					{
						this.a(a_, 106);
					}
					array = dataTable.Select("idCommand in (105, 7)", "datelog desc, id desc");
					if (array.Length != 0 && Convert.ToInt32(array[0]["idCommand"]) == 7)
					{
						this.a(a_, 107);
					}
				}
			}
			if (dataRow.RowState != DataRowState.Added)
			{
				bool flag = false;
				foreach (DataRow dataRow2 in this.z.tJ_RequestForRepairDaily)
				{
					if (dataRow2.RowState == DataRowState.Added || dataRow2.RowState == DataRowState.Modified || dataRow2.RowState == DataRowState.Deleted)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					DataRow[] array2 = dataTable.Select("isSite = true", "datelog desc, id desc");
					if (array2.Length != 0)
					{
						if (Convert.ToInt32(array2[0]["idCommand"]) == 105)
						{
							this.a(a_, 7);
						}
						else
						{
							this.a(a_, 107);
						}
					}
				}
			}
			base.InsertSqlData(this.z.tJ_RequestForRepairLog);
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

		// Token: 0x060001A6 RID: 422 RVA: 0x00011114 File Offset: 0x0000F314
		private void a(DataTable A_0, int A_1)
		{
			if (A_0.Rows.Count == 0)
			{
				base.SelectSqlData(A_0, true, "where [Login] = SYSTEM_USER", false);
			}
			DataRow dataRow = this.z.tJ_RequestForRepairLog.NewRow();
			dataRow["idRequest"] = this.a;
			dataRow["dateLog"] = DateTime.Now;
			if (A_0.Rows.Count > 0)
			{
				dataRow["userLogId"] = A_0.Rows[0]["idUser"];
				dataRow["userLog"] = A_0.Rows[0]["Login"];
				if (A_0.Rows[0]["name"] != DBNull.Value)
				{
					dataRow["userLogName"] = A_0.Rows[0]["name"];
				}
			}
			dataRow["idCommand"] = A_1;
			if (this.x.ContainsKey(A_1))
			{
				dataRow["Command"] = this.x[A_1];
			}
			if (A_1 > 100)
			{
				dataRow["isSite"] = true;
			}
			else
			{
				dataRow["isSite"] = false;
			}
			this.z.tJ_RequestForRepairLog.Rows.Add(dataRow);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000112A0 File Offset: 0x0000F4A0
		private void a()
		{
			this.y = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			this.aa = new Label();
			this.ab = new ComboBox();
			this.z = new DataSetGES();
			this.ac = new Label();
			this.ad = new Label();
			this.ae = new ComboBox();
			this.af = new GroupBox();
			this.dn = new ComboBox();
			this.cm = new ComboBox();
			this.ah = new ComboBox();
			this.ai = new Label();
			this.aj = new Label();
			this.ak = new TextBox();
			this.al = new TextBox();
			this.am = new Label();
			this.bd = new ToolStrip();
			this.be = new ToolStripButton();
			this.bs = new ToolStripButton();
			this.bf = new ToolStripButton();
			this.bg = new ToolStripButton();
			this.a3 = new GroupBox();
			this.dl = new NullableDateTimePicker();
			this.cn = new Label();
			this.a4 = new Button();
			this.a5 = new DataGridView();
			this.cf = new DataGridViewTextBoxColumn();
			this.cg = new DataGridViewTextBoxColumn();
			this.ch = new DataGridViewFilterDateTimePickerColumn();
			this.ci = new DataGridViewFilterDateTimePickerColumn();
			this.a6 = new CheckBox();
			this.a7 = new CheckBox();
			this.a8 = new DateTimePicker();
			this.an = new Label();
			this.a9 = new DateTimePicker();
			this.ag = new Label();
			this.ao = new GroupBox();
			this.cv = new ComboBox();
			this.cw = new Label();
			this.cj = new TextBox();
			this.@as = new ComboBox();
			this.at = new Label();
			this.au = new Label();
			this.av = new NullableDateTimePicker();
			this.aw = new CheckBox();
			this.ax = new Label();
			this.ay = new Label();
			this.az = new Label();
			this.ap = new TextBox();
			this.aq = new TextBox();
			this.ar = new Button();
			this.a0 = new ComboBox();
			this.a1 = new Label();
			this.a2 = new TextBox();
			this.ba = new Label();
			this.bb = new Label();
			this.bc = new NullableDateTimePicker();
			this.bh = new TabControl();
			this.bi = new TabPage();
			this.dv = new CheckBox();
			this.cs = new ComboBox();
			this.cu = new BindingSource(this.y);
			this.ct = new Label();
			this.co = new ComboBox();
			this.cp = new Label();
			this.cq = new ComboBox();
			this.cr = new Label();
			this.cl = new ComboBox();
			this.ck = new ComboBox();
			this.cd = new ToolStrip();
			this.ce = new ToolStripButton();
			this.dm = new ToolStripButton();
			this.bj = new TabPage();
			this.cx = new SplitContainer();
			this.bt = new DataGridViewExcelFilter();
			this.dp = new DataGridViewTextBoxColumn();
			this.dq = new DataGridViewTextBoxColumn();
			this.dr = new DataGridViewTextBoxColumn();
			this.ds = new DataGridViewTextBoxColumn();
			this.dt = new DataGridViewTextBoxColumn();
			this.du = new DataGridViewCheckBoxColumn();
			this.bu = new BindingSource(this.y);
			this.bl = new DataSet();
			this.bm = new DataTable();
			this.bn = new DataColumn();
			this.bo = new DataColumn();
			this.bp = new DataColumn();
			this.bq = new DataColumn();
			this.br = new DataColumn();
			this.@do = new DataColumn();
			this.bz = new DataTable();
			this.b0 = new DataColumn();
			this.b1 = new DataColumn();
			this.b2 = new DataColumn();
			this.b3 = new DataColumn();
			this.cy = new DataTable();
			this.cz = new DataColumn();
			this.c0 = new DataColumn();
			this.c1 = new DataColumn();
			this.c2 = new DataColumn();
			this.c3 = new DataColumn();
			this.c4 = new DataColumn();
			this.c5 = new DataColumn();
			this.c6 = new DataColumn();
			this.c7 = new DataGridViewExcelFilter();
			this.dd = new DataGridViewTextBoxColumn();
			this.de = new DataGridViewTextBoxColumn();
			this.df = new DataGridViewTextBoxColumn();
			this.dg = new DataGridViewTextBoxColumn();
			this.dh = new DataGridViewTextBoxColumn();
			this.di = new DataGridViewTextBoxColumn();
			this.dj = new DataGridViewTextBoxColumn();
			this.dk = new DataGridViewTextBoxColumn();
			this.c8 = new BindingSource(this.y);
			this.c9 = new ToolStrip();
			this.da = new ToolStripButton();
			this.db = new ToolStripButton();
			this.bk = new TabPage();
			this.bv = new DataGridViewExcelFilter();
			this.b7 = new DataGridViewTextBoxColumn();
			this.b9 = new DataGridViewTextBoxColumn();
			this.ca = new DataGridViewLinkColumn();
			this.cb = new DataGridViewTextBoxColumn();
			this.b8 = new DataGridViewImageColumnNotNull();
			this.bw = new BindingSource(this.y);
			this.bx = new ToolStrip();
			this.by = new ToolStripButton();
			this.b4 = new ToolStripButton();
			this.b5 = new ToolStripButton();
			this.b6 = new ToolStripButton();
			this.dw = new TabPage();
			this.dx = new DataGridViewExcelFilter();
			this.dz = new DataGridViewTextBoxColumn();
			this.d0 = new DataGridViewTextBoxColumn();
			this.d1 = new DataGridViewTextBoxColumn();
			this.d2 = new DataGridViewTextBoxColumn();
			this.d3 = new DataGridViewTextBoxColumn();
			this.d4 = new DataGridViewTextBoxColumn();
			this.d5 = new DataGridViewTextBoxColumn();
			this.d6 = new DataGridViewTextBoxColumn();
			this.d7 = new DataGridViewCheckBoxColumn();
			this.dy = new BindingSource(this.y);
			this.cc = new Button();
			this.dc = new BackgroundWorker();
			this.d8 = new Button();
			((ISupportInitialize)this.z).BeginInit();
			this.af.SuspendLayout();
			this.bd.SuspendLayout();
			this.a3.SuspendLayout();
			((ISupportInitialize)this.a5).BeginInit();
			this.ao.SuspendLayout();
			this.bh.SuspendLayout();
			this.bi.SuspendLayout();
			((ISupportInitialize)this.cu).BeginInit();
			this.cd.SuspendLayout();
			this.bj.SuspendLayout();
			this.cx.Panel1.SuspendLayout();
			this.cx.Panel2.SuspendLayout();
			this.cx.SuspendLayout();
			((ISupportInitialize)this.bt).BeginInit();
			((ISupportInitialize)this.bu).BeginInit();
			((ISupportInitialize)this.bl).BeginInit();
			((ISupportInitialize)this.bm).BeginInit();
			((ISupportInitialize)this.bz).BeginInit();
			((ISupportInitialize)this.cy).BeginInit();
			((ISupportInitialize)this.c7).BeginInit();
			((ISupportInitialize)this.c8).BeginInit();
			this.c9.SuspendLayout();
			this.bk.SuspendLayout();
			((ISupportInitialize)this.bv).BeginInit();
			((ISupportInitialize)this.bw).BeginInit();
			this.bx.SuspendLayout();
			this.dw.SuspendLayout();
			((ISupportInitialize)this.dx).BeginInit();
			((ISupportInitialize)this.dy).BeginInit();
			base.SuspendLayout();
			this.aa.AutoSize = true;
			this.aa.Location = new Point(58, 8);
			this.aa.Name = "label1";
			this.aa.Size = new Size(37, 13);
			this.aa.TabIndex = 0;
			this.aa.Text = "Автор";
			this.ab.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.ab.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.ab.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.idWorker", true));
			this.ab.FormattingEnabled = true;
			this.ab.Location = new Point(288, 66);
			this.ab.Name = "cmbWorker";
			this.ab.Size = new Size(21, 21);
			this.ab.TabIndex = 3;
			this.ab.Visible = false;
			this.ab.SelectedIndexChanged += this.z;
			this.z.DataSetName = "DataSetGES";
			this.z.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.ac.AutoSize = true;
			this.ac.Location = new Point(8, 66);
			this.ac.Name = "labelRequestFiled";
			this.ac.Size = new Size(76, 13);
			this.ac.TabIndex = 4;
			this.ac.Text = "Заявку подал";
			this.ad.AutoSize = true;
			this.ad.Location = new Point(305, 39);
			this.ad.Name = "labelSR";
			this.ad.Size = new Size(38, 13);
			this.ad.TabIndex = 6;
			this.ad.Text = "Район";
			this.ae.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ae.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.ae.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.ae.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.idSR", true));
			this.ae.FormattingEnabled = true;
			this.ae.Location = new Point(358, 36);
			this.ae.Name = "cmbSR";
			this.ae.Size = new Size(287, 21);
			this.ae.TabIndex = 7;
			this.ae.SelectedIndexChanged += this.x;
			this.ae.SelectedValueChanged += this.ak;
			this.af.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.af.Controls.Add(this.dn);
			this.af.Controls.Add(this.cm);
			this.af.Controls.Add(this.ah);
			this.af.Controls.Add(this.ai);
			this.af.Controls.Add(this.aj);
			this.af.Controls.Add(this.ak);
			this.af.Controls.Add(this.al);
			this.af.Controls.Add(this.am);
			this.af.Location = new Point(11, 89);
			this.af.Name = "groupBox1";
			this.af.Size = new Size(634, 97);
			this.af.TabIndex = 8;
			this.af.TabStop = false;
			this.dn.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.dn.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.idTypeDamage", true));
			this.dn.FormattingEnabled = true;
			this.dn.Location = new Point(366, 68);
			this.dn.Name = "cmbTypeDamage";
			this.dn.Size = new Size(262, 21);
			this.dn.TabIndex = 7;
			this.cm.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cm.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cm.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.typeDisable", true));
			this.cm.FormattingEnabled = true;
			this.cm.Items.AddRange(new object[]
			{
				"Аварийный",
				"Плановый"
			});
			this.cm.Location = new Point(230, 68);
			this.cm.Name = "cmbTypeDisable";
			this.cm.Size = new Size(121, 21);
			this.cm.TabIndex = 6;
			this.cm.SelectedValueChanged += this.ai;
			this.ah.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.IsPlanned", true));
			this.ah.FormattingEnabled = true;
			this.ah.Items.AddRange(new object[]
			{
				"Аварийный",
				"Плановый"
			});
			this.ah.Location = new Point(101, 68);
			this.ah.Name = "cmbIsPlanned";
			this.ah.Size = new Size(121, 21);
			this.ah.TabIndex = 5;
			this.ah.SelectedIndexChanged += this.aa;
			this.ah.SelectedValueChanged += this.ah;
			this.ai.AutoSize = true;
			this.ai.Location = new Point(6, 71);
			this.ai.Name = "labelIsPlanned";
			this.ai.Size = new Size(89, 13);
			this.ai.TabIndex = 4;
			this.ai.Text = "Вид отключения";
			this.aj.AutoSize = true;
			this.aj.Location = new Point(6, 45);
			this.aj.Name = "labelPurpose";
			this.aj.Size = new Size(33, 13);
			this.aj.TabIndex = 3;
			this.aj.Text = "Цель";
			this.ak.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ak.DataBindings.Add(new Binding("Text", this.z, "tJ_RequestForRepair.Purpose", true));
			this.ak.Location = new Point(101, 42);
			this.ak.Name = "txtPurpose";
			this.ak.Size = new Size(527, 20);
			this.ak.TabIndex = 2;
			this.ak.TextChanged += this.v;
			this.al.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.al.DataBindings.Add(new Binding("Text", this.z, "tJ_RequestForRepair.schmObj", true));
			this.al.Location = new Point(101, 16);
			this.al.Name = "txtObject";
			this.al.Size = new Size(527, 20);
			this.al.TabIndex = 1;
			this.al.TextChanged += this.w;
			this.am.AutoSize = true;
			this.am.Location = new Point(6, 16);
			this.am.Name = "labelObject";
			this.am.Size = new Size(45, 13);
			this.am.TabIndex = 0;
			this.am.Text = "Объект";
			this.bd.GripStyle = ToolStripGripStyle.Hidden;
			this.bd.Items.AddRange(new ToolStripItem[]
			{
				this.be,
				this.bs,
				this.bf,
				this.bg
			});
			this.bd.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.bd.Location = new Point(3, 3);
			this.bd.Name = "toolStripScheme";
			this.bd.Size = new Size(724, 25);
			this.bd.TabIndex = 47;
			this.bd.Text = "toolStrip1";
			this.be.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.be.Image = Resources.ElementAdd;
			this.be.ImageTransparentColor = Color.Magenta;
			this.be.Name = "toolBtnLinkSchmObj";
			this.be.Size = new Size(23, 22);
			this.be.Text = "Привязать к схеме";
			this.be.Click += this.p;
			this.bs.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bs.Image = Resources.ElementEdit;
			this.bs.ImageTransparentColor = Color.Magenta;
			this.bs.Name = "toolBtnLinkSchmObjEdit";
			this.bs.Size = new Size(23, 22);
			this.bs.Text = "Редактировать";
			this.bs.Click += this.o;
			this.bf.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bf.Image = Resources.ElementDel;
			this.bf.ImageTransparentColor = Color.Magenta;
			this.bf.Name = "toolBtnDelSchmObj";
			this.bf.Size = new Size(23, 22);
			this.bf.Text = "Удалить";
			this.bf.Click += this.n;
			this.bg.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bg.Enabled = false;
			this.bg.Image = Resources.ElementInformation;
			this.bg.ImageTransparentColor = Color.Magenta;
			this.bg.Name = "toolBtnViewSChmObj";
			this.bg.Size = new Size(23, 22);
			this.bg.Text = "Показать на схеме";
			this.bg.Click += this.m;
			this.a3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.a3.Controls.Add(this.dl);
			this.a3.Controls.Add(this.cn);
			this.a3.Controls.Add(this.a4);
			this.a3.Controls.Add(this.a5);
			this.a3.Controls.Add(this.a6);
			this.a3.Controls.Add(this.a7);
			this.a3.Controls.Add(this.a8);
			this.a3.Controls.Add(this.an);
			this.a3.Controls.Add(this.a9);
			this.a3.Controls.Add(this.ag);
			this.a3.Location = new Point(11, 192);
			this.a3.Name = "groupBoxDaily";
			this.a3.Size = new Size(634, 173);
			this.a3.TabIndex = 10;
			this.a3.TabStop = false;
			this.a3.Text = "Даты отключения";
			this.dl.CustomFormat = "dd.MM.yyyy HH:mm";
			this.dl.DataBindings.Add(new Binding("Value", this.z, "tJ_RequestForRepair.dateFactEnd", true));
			this.dl.Format = DateTimePickerFormat.Custom;
			this.dl.Location = new Point(351, 144);
			this.dl.Name = "dateTimePickerFactEnd";
			this.dl.Size = new Size(188, 20);
			this.dl.TabIndex = 16;
			this.dl.Value = new DateTime(2015, 8, 10, 13, 57, 6, 22);
			this.cn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.cn.AutoSize = true;
			this.cn.Location = new Point(175, 148);
			this.cn.Name = "label3";
			this.cn.Size = new Size(176, 13);
			this.cn.TabIndex = 14;
			this.cn.Text = "Фактическое время выполнения";
			this.a4.Location = new Point(9, 115);
			this.a4.Name = "buttonDaily";
			this.a4.Size = new Size(75, 23);
			this.a4.TabIndex = 13;
			this.a4.Text = "Добавить";
			this.a4.UseVisualStyleBackColor = true;
			this.a4.Click += this.ab;
			this.a5.AllowUserToAddRows = false;
			this.a5.AllowUserToResizeColumns = false;
			this.a5.AllowUserToResizeRows = false;
			this.a5.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.a5.AutoGenerateColumns = false;
			this.a5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.a5.Columns.AddRange(new DataGridViewColumn[]
			{
				this.cf,
				this.cg,
				this.ch,
				this.ci
			});
			this.a5.DataMember = "tJ_RequestForRepairDaily";
			this.a5.DataSource = this.z;
			this.a5.Location = new Point(178, 8);
			this.a5.Name = "dgvDaily";
			this.a5.RowHeadersWidth = 30;
			this.a5.Size = new Size(456, 130);
			this.a5.TabIndex = 12;
			this.a5.VirtualMode = true;
			this.a5.CellEndEdit += this.c;
			this.a5.CellFormatting += this.b;
			this.a5.EditingControlShowing += this.a;
			this.a5.RowsAdded += this.a;
			this.a5.RowsRemoved += this.a;
			this.cf.DataPropertyName = "id";
			this.cf.HeaderText = "id";
			this.cf.Name = "idDataGridViewTextBoxColumn";
			this.cf.ReadOnly = true;
			this.cf.Visible = false;
			this.cg.DataPropertyName = "idRequest";
			this.cg.HeaderText = "idRequest";
			this.cg.Name = "idRequestDataGridViewTextBoxColumn";
			this.cg.Visible = false;
			this.ch.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ch.DataPropertyName = "dateBeg";
			dataGridViewCellStyle.Format = "dd.MM.yyyy HH:mm";
			this.ch.DefaultCellStyle = dataGridViewCellStyle;
			this.ch.FillWeight = 50f;
			this.ch.HeaderText = "Начало";
			this.ch.Name = "dateBegDataGridViewTextBoxColumn";
			this.ch.Resizable = DataGridViewTriState.True;
			this.ci.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ci.DataPropertyName = "dateEnd";
			dataGridViewCellStyle2.Format = "dd.MM.yyyy HH:mm";
			this.ci.DefaultCellStyle = dataGridViewCellStyle2;
			this.ci.FillWeight = 50f;
			this.ci.HeaderText = "Окончание";
			this.ci.Name = "dateEndDataGridViewTextBoxColumn";
			this.ci.Resizable = DataGridViewTriState.True;
			this.a6.AutoSize = true;
			this.a6.Checked = true;
			this.a6.CheckState = CheckState.Checked;
			this.a6.Enabled = false;
			this.a6.Location = new Point(9, 92);
			this.a6.Name = "checkBoxWeekEnd";
			this.a6.Size = new Size(78, 17);
			this.a6.TabIndex = 11;
			this.a6.Text = "Выходные";
			this.a6.UseVisualStyleBackColor = true;
			this.a7.AutoSize = true;
			this.a7.Location = new Point(9, 69);
			this.a7.Name = "checkBoxDaily";
			this.a7.Size = new Size(83, 17);
			this.a7.TabIndex = 10;
			this.a7.Text = "Ежедневно";
			this.a7.UseVisualStyleBackColor = true;
			this.a7.CheckedChanged += this.ae;
			this.a8.CustomFormat = "dd.MM.yyyy HH:mm";
			this.a8.Format = DateTimePickerFormat.Custom;
			this.a8.Location = new Point(30, 43);
			this.a8.Name = "dateTimePickerEnd";
			this.a8.Size = new Size(124, 20);
			this.a8.TabIndex = 1;
			this.a8.ValueChanged += this.ac;
			this.an.AutoSize = true;
			this.an.Location = new Point(6, 50);
			this.an.Name = "label9";
			this.an.Size = new Size(19, 13);
			this.an.TabIndex = 9;
			this.an.Text = "по";
			this.a9.CustomFormat = "dd.MM.yyyy HH:mm";
			this.a9.Format = DateTimePickerFormat.Custom;
			this.a9.Location = new Point(30, 19);
			this.a9.Name = "dateTimePickerBeg";
			this.a9.Size = new Size(124, 20);
			this.a9.TabIndex = 0;
			this.a9.ValueChanged += this.ad;
			this.ag.AutoSize = true;
			this.ag.Location = new Point(11, 22);
			this.ag.Name = "label8";
			this.ag.Size = new Size(13, 13);
			this.ag.TabIndex = 8;
			this.ag.Text = "с";
			this.ao.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ao.Controls.Add(this.cv);
			this.ao.Controls.Add(this.cw);
			this.ao.Controls.Add(this.cj);
			this.ao.Controls.Add(this.@as);
			this.ao.Controls.Add(this.at);
			this.ao.Controls.Add(this.au);
			this.ao.Controls.Add(this.av);
			this.ao.Controls.Add(this.aw);
			this.ao.Controls.Add(this.ax);
			this.ao.Controls.Add(this.ay);
			this.ao.Controls.Add(this.az);
			this.ao.Controls.Add(this.ap);
			this.ao.Controls.Add(this.aq);
			this.ao.Location = new Point(11, 411);
			this.ao.Name = "groupBoxODS";
			this.ao.Size = new Size(634, 200);
			this.ao.TabIndex = 9;
			this.ao.TabStop = false;
			this.ao.VisibleChanged += this.af;
			this.cv.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.cv.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.status", true));
			this.cv.FormattingEnabled = true;
			this.cv.Location = new Point(160, 170);
			this.cv.Name = "cmbStatus";
			this.cv.Size = new Size(379, 21);
			this.cv.TabIndex = 13;
			this.cv.SelectedIndexChanged += this.u;
			this.cw.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.cw.AutoSize = true;
			this.cw.Location = new Point(74, 173);
			this.cw.Name = "labelStatus";
			this.cw.Size = new Size(80, 13);
			this.cw.TabIndex = 12;
			this.cw.Text = "Статус заявки";
			this.cj.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.cj.BackColor = SystemColors.Window;
			this.cj.DataBindings.Add(new Binding("Text", this.z, "tJ_RequestForRepair.Address", true));
			this.cj.Location = new Point(101, 71);
			this.cj.Multiline = true;
			this.cj.Name = "txtAdress";
			this.cj.ReadOnly = true;
			this.cj.ScrollBars = ScrollBars.Vertical;
			this.cj.Size = new Size(527, 72);
			this.cj.TabIndex = 11;
			this.@as.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.@as.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.@as.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.@as.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.WorkerAgreed", true));
			this.@as.FormattingEnabled = true;
			this.@as.Location = new Point(412, 145);
			this.@as.Name = "cmbDispatcher";
			this.@as.Size = new Size(216, 21);
			this.@as.TabIndex = 10;
			this.at.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.at.AutoSize = true;
			this.at.Location = new Point(329, 151);
			this.at.Name = "label14";
			this.at.Size = new Size(77, 13);
			this.at.TabIndex = 9;
			this.at.Text = "Согласующий";
			this.au.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.au.AutoSize = true;
			this.au.Location = new Point(121, 153);
			this.au.Name = "label13";
			this.au.Size = new Size(33, 13);
			this.au.TabIndex = 8;
			this.au.Text = "Дата";
			this.av.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.av.DataBindings.Add(new Binding("Value", this.z, "tJ_RequestForRepair.DateAgreed", true));
			this.av.Location = new Point(160, 147);
			this.av.Name = "dateTimePickerDateAgreed";
			this.av.Size = new Size(163, 20);
			this.av.TabIndex = 7;
			this.av.Value = new DateTime(2012, 9, 26, 9, 58, 28, 932);
			this.aw.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.aw.AutoSize = true;
			this.aw.DataBindings.Add(new Binding("Checked", this.z, "tJ_RequestForRepair.Agreed", true, DataSourceUpdateMode.OnPropertyChanged));
			this.aw.Location = new Point(9, 150);
			this.aw.Name = "checkBoxAgreed";
			this.aw.Size = new Size(92, 17);
			this.aw.TabIndex = 6;
			this.aw.Text = "Согласовано";
			this.aw.UseVisualStyleBackColor = true;
			this.aw.CheckedChanged += this.l;
			this.aw.CheckStateChanged += this.k;
			this.ax.AutoSize = true;
			this.ax.Location = new Point(6, 74);
			this.ax.Name = "labelAddress";
			this.ax.Size = new Size(44, 13);
			this.ax.TabIndex = 5;
			this.ax.Text = "Адреса";
			this.ay.AutoSize = true;
			this.ay.Location = new Point(6, 48);
			this.ay.Name = "label11";
			this.ay.Size = new Size(77, 13);
			this.ay.TabIndex = 4;
			this.ay.Text = "Комментарий";
			this.az.AutoSize = true;
			this.az.Location = new Point(6, 22);
			this.az.Name = "label10";
			this.az.Size = new Size(81, 13);
			this.az.TabIndex = 3;
			this.az.Text = "Согласовать с";
			this.ap.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ap.DataBindings.Add(new Binding("Text", this.z, "tJ_RequestForRepair.Comment", true));
			this.ap.Location = new Point(101, 45);
			this.ap.Name = "txtComment";
			this.ap.Size = new Size(527, 20);
			this.ap.TabIndex = 1;
			this.aq.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.aq.DataBindings.Add(new Binding("Text", this.z, "tJ_RequestForRepair.AgreeWith", true));
			this.aq.Location = new Point(101, 19);
			this.aq.Name = "txtAgreeWith";
			this.aq.Size = new Size(527, 20);
			this.aq.TabIndex = 0;
			this.ar.DialogResult = DialogResult.OK;
			this.ar.Location = new Point(15, 678);
			this.ar.Name = "buttonOK";
			this.ar.Size = new Size(75, 23);
			this.ar.TabIndex = 10;
			this.ar.Text = "ОК";
			this.ar.UseVisualStyleBackColor = true;
			this.ar.Click += this.j;
			this.a0.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.idUserCreate", true));
			this.a0.Enabled = false;
			this.a0.FormattingEnabled = true;
			this.a0.Location = new Point(101, 5);
			this.a0.Name = "cmbUserCreate";
			this.a0.Size = new Size(181, 21);
			this.a0.TabIndex = 12;
			this.a1.AutoSize = true;
			this.a1.Location = new Point(302, 8);
			this.a1.Name = "label15";
			this.a1.Size = new Size(41, 13);
			this.a1.TabIndex = 13;
			this.a1.Text = "Номер";
			this.a2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.a2.DataBindings.Add(new Binding("Text", this.z, "tJ_RequestForRepair.num", true));
			this.a2.Location = new Point(358, 5);
			this.a2.Name = "txtNum";
			this.a2.ReadOnly = true;
			this.a2.Size = new Size(287, 20);
			this.a2.TabIndex = 14;
			this.ba.AutoSize = true;
			this.ba.Location = new Point(276, 86);
			this.ba.Name = "labelWorker";
			this.ba.Size = new Size(56, 13);
			this.ba.TabIndex = 15;
			this.ba.Text = "Оператор";
			this.ba.Visible = false;
			this.bb.AutoSize = true;
			this.bb.Location = new Point(8, 39);
			this.bb.Name = "label2";
			this.bb.Size = new Size(84, 13);
			this.bb.TabIndex = 16;
			this.bb.Text = "Дата создания";
			this.bc.CustomFormat = "dd.MM.yyyy HH:mm";
			this.bc.DataBindings.Add(new Binding("Value", this.z, "tJ_RequestForRepair.dateCreate", true));
			this.bc.Enabled = false;
			this.bc.Format = DateTimePickerFormat.Custom;
			this.bc.Location = new Point(101, 37);
			this.bc.Name = "dateTimePickerDateCreate";
			this.bc.Size = new Size(181, 20);
			this.bc.TabIndex = 17;
			this.bc.Value = new DateTime(2012, 10, 18, 8, 39, 41, 178);
			this.bh.Controls.Add(this.bi);
			this.bh.Controls.Add(this.bj);
			this.bh.Controls.Add(this.bk);
			this.bh.Controls.Add(this.dw);
			this.bh.Location = new Point(0, 0);
			this.bh.Name = "tabControl";
			this.bh.SelectedIndex = 0;
			this.bh.Size = new Size(665, 669);
			this.bh.TabIndex = 49;
			this.bi.Controls.Add(this.dv);
			this.bi.Controls.Add(this.cs);
			this.bi.Controls.Add(this.ct);
			this.bi.Controls.Add(this.co);
			this.bi.Controls.Add(this.cp);
			this.bi.Controls.Add(this.cq);
			this.bi.Controls.Add(this.cr);
			this.bi.Controls.Add(this.cl);
			this.bi.Controls.Add(this.ck);
			this.bi.Controls.Add(this.cd);
			this.bi.Controls.Add(this.ae);
			this.bi.Controls.Add(this.aa);
			this.bi.Controls.Add(this.a3);
			this.bi.Controls.Add(this.ab);
			this.bi.Controls.Add(this.ac);
			this.bi.Controls.Add(this.ao);
			this.bi.Controls.Add(this.bc);
			this.bi.Controls.Add(this.bb);
			this.bi.Controls.Add(this.af);
			this.bi.Controls.Add(this.ad);
			this.bi.Controls.Add(this.ba);
			this.bi.Controls.Add(this.a0);
			this.bi.Controls.Add(this.a2);
			this.bi.Controls.Add(this.a1);
			this.bi.Location = new Point(4, 22);
			this.bi.Name = "tabPageGeneral";
			this.bi.Padding = new Padding(3);
			this.bi.Size = new Size(657, 643);
			this.bi.TabIndex = 0;
			this.bi.Text = "Общие";
			this.bi.UseVisualStyleBackColor = true;
			this.dv.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.dv.AutoSize = true;
			this.dv.DataBindings.Add(new Binding("Checked", this.z, "tJ_RequestForRepair.SendSite", true));
			this.dv.Location = new Point(20, 620);
			this.dv.Name = "chkSendToSite";
			this.dv.Size = new Size(121, 17);
			this.dv.TabIndex = 27;
			this.dv.Text = "Отправить на сайт";
			this.dv.UseVisualStyleBackColor = true;
			this.cs.DataBindings.Add(new Binding("SelectedValue", this.cu, "groupWorks", true));
			this.cs.FormattingEnabled = true;
			this.cs.Location = new Point(391, 384);
			this.cs.Name = "cmbGroupWorks";
			this.cs.Size = new Size(159, 21);
			this.cs.TabIndex = 26;
			this.cs.SelectedIndexChanged += this.r;
			this.cu.DataMember = "tJ_RequestForRepair";
			this.cu.DataSource = this.z;
			this.ct.AutoSize = true;
			this.ct.Location = new Point(388, 368);
			this.ct.Name = "labelGroupWork";
			this.ct.Size = new Size(74, 13);
			this.ct.TabIndex = 25;
			this.ct.Text = "Группа работ";
			this.co.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.performerOrganization", true));
			this.co.FormattingEnabled = true;
			this.co.Location = new Point(189, 384);
			this.co.Name = "cmbPerformerOrganization";
			this.co.Size = new Size(193, 21);
			this.co.TabIndex = 24;
			this.co.SelectedIndexChanged += this.s;
			this.cp.AutoSize = true;
			this.cp.Location = new Point(186, 368);
			this.cp.Name = "labelPerformer";
			this.cp.Size = new Size(144, 13);
			this.cp.TabIndex = 23;
			this.cp.Text = "Фактический исполнитель";
			this.cq.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.organization", true));
			this.cq.FormattingEnabled = true;
			this.cq.Location = new Point(20, 384);
			this.cq.Name = "cmbOrganization";
			this.cq.Size = new Size(163, 21);
			this.cq.TabIndex = 22;
			this.cq.SelectedIndexChanged += this.t;
			this.cr.AutoSize = true;
			this.cr.Location = new Point(17, 368);
			this.cr.Name = "labelOrganization";
			this.cr.Size = new Size(111, 13);
			this.cr.TabIndex = 21;
			this.cr.Text = "Ответственное лицо";
			this.cl.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.cl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cl.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cl.DataBindings.Add(new Binding("SelectedValue", this.z, "tJ_RequestForRepair.idRegion", true));
			this.cl.FormattingEnabled = true;
			this.cl.Location = new Point(358, 63);
			this.cl.Name = "cmbRegion";
			this.cl.Size = new Size(287, 21);
			this.cl.TabIndex = 20;
			this.cl.SelectedValueChanged += this.aj;
			this.ck.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.ck.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.ck.DataBindings.Add(new Binding("Text", this.z, "tJ_RequestForRepair.reguestFiled", true));
			this.ck.FormattingEnabled = true;
			this.ck.Location = new Point(101, 62);
			this.ck.Name = "txtRequestFiled";
			this.ck.Size = new Size(181, 21);
			this.ck.TabIndex = 19;
			this.ck.SelectedIndexChanged += this.q;
			this.cd.Dock = DockStyle.None;
			this.cd.GripStyle = ToolStripGripStyle.Hidden;
			this.cd.Items.AddRange(new ToolStripItem[]
			{
				this.ce,
				this.dm
			});
			this.cd.Location = new Point(0, 0);
			this.cd.Name = "toolStripMain";
			this.cd.Size = new Size(26, 25);
			this.cd.TabIndex = 18;
			this.cd.Text = "toolStrip1";
			this.ce.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.ce.Image = Resources.CopyBuffer;
			this.ce.ImageTransparentColor = Color.Magenta;
			this.ce.Name = "toolBtnCopy";
			this.ce.Size = new Size(23, 22);
			this.ce.Text = "Копировать";
			this.ce.Click += this.d;
			this.dm.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.dm.Image = Resources.FTP;
			this.dm.ImageTransparentColor = Color.Magenta;
			this.dm.Name = "toolBtnSettingsFTP";
			this.dm.Size = new Size(23, 22);
			this.dm.Text = "Настройки FTP";
			this.dm.Visible = false;
			this.dm.Click += this.a;
			this.bj.Controls.Add(this.cx);
			this.bj.Controls.Add(this.bd);
			this.bj.Location = new Point(4, 22);
			this.bj.Name = "tabPageSwitching";
			this.bj.Padding = new Padding(3);
			this.bj.Size = new Size(730, 643);
			this.bj.TabIndex = 1;
			this.bj.Text = "Оперативные переключения";
			this.bj.UseVisualStyleBackColor = true;
			this.cx.Dock = DockStyle.Fill;
			this.cx.Location = new Point(3, 28);
			this.cx.Name = "splitContainer1";
			this.cx.Orientation = Orientation.Horizontal;
			this.cx.Panel1.Controls.Add(this.bt);
			this.cx.Panel2.Controls.Add(this.c7);
			this.cx.Panel2.Controls.Add(this.c9);
			this.cx.Size = new Size(724, 612);
			this.cx.SplitterDistance = 276;
			this.cx.TabIndex = 50;
			this.bt.AllowUserToAddRows = false;
			this.bt.AllowUserToDeleteRows = false;
			this.bt.AllowUserToVisibleColumns = false;
			this.bt.AutoGenerateColumns = false;
			this.bt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.bt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bt.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dp,
				this.dq,
				this.dr,
				this.ds,
				this.dt,
				this.du
			});
			this.bt.DataSource = this.bu;
			this.bt.Dock = DockStyle.Fill;
			this.bt.Location = new Point(0, 0);
			this.bt.Name = "dgvLinkObjects";
			this.bt.ReadOnly = true;
			this.bt.RowHeadersWidth = 21;
			this.bt.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.bt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.bt.Size = new Size(724, 276);
			this.bt.TabIndex = 49;
			this.bt.CellDoubleClick += this.b;
			this.bt.CellFormatting += this.a;
			this.dp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dp.DataPropertyName = "Objects";
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dp.DefaultCellStyle = dataGridViewCellStyle3;
			this.dp.HeaderText = "Объекты";
			this.dp.Name = "objectsDataGridViewTextBoxColumn1";
			this.dp.ReadOnly = true;
			this.dp.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dq.DataPropertyName = "DateBeg";
			this.dq.HeaderText = "Начало";
			this.dq.Name = "dateBegDataGridViewTextBoxColumn2";
			this.dq.ReadOnly = true;
			this.dq.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dq.Width = 90;
			this.dr.DataPropertyName = "DateEnd";
			this.dr.HeaderText = "Окончание";
			this.dr.Name = "dateEndDataGridViewTextBoxColumn2";
			this.dr.ReadOnly = true;
			this.dr.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dr.Width = 90;
			this.ds.DataPropertyName = "Duration";
			this.ds.HeaderText = "Длительность";
			this.ds.Name = "durationDataGridViewTextBoxColumn1";
			this.ds.ReadOnly = true;
			this.ds.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.ds.Width = 90;
			this.dt.DataPropertyName = "Num";
			this.dt.HeaderText = "Num";
			this.dt.Name = "numDataGridViewTextBoxColumn1";
			this.dt.ReadOnly = true;
			this.dt.Visible = false;
			this.du.DataPropertyName = "Disabled";
			this.du.HeaderText = "Disabled";
			this.du.Name = "disabledDgvColumn";
			this.du.ReadOnly = true;
			this.du.Visible = false;
			this.bu.DataMember = "tableLinkObjects";
			this.bu.DataSource = this.bl;
			this.bu.Sort = "Num";
			this.bl.DataSetName = "NewDataSet";
			this.bl.Tables.AddRange(new DataTable[]
			{
				this.bm,
				this.bz,
				this.cy
			});
			this.bm.Columns.AddRange(new DataColumn[]
			{
				this.bn,
				this.bo,
				this.bp,
				this.bq,
				this.br,
				this.@do
			});
			this.bm.TableName = "tableLinkObjects";
			this.bn.ColumnName = "Objects";
			this.bo.ColumnName = "DateBeg";
			this.bo.DataType = typeof(DateTime);
			this.bp.ColumnName = "DateEnd";
			this.bp.DataType = typeof(DateTime);
			this.bq.ColumnName = "Duration";
			this.br.ColumnName = "Num";
			this.br.DataType = typeof(short);
			this.@do.ColumnName = "Disabled";
			this.@do.DataType = typeof(bool);
			this.bz.Columns.AddRange(new DataColumn[]
			{
				this.b0,
				this.b1,
				this.b2,
				this.b3
			});
			this.bz.TableName = "tJ_RequestForReapirDoc";
			this.b0.AllowDBNull = false;
			this.b0.AutoIncrement = true;
			this.b0.ColumnName = "id";
			this.b0.DataType = typeof(int);
			this.b1.AllowDBNull = false;
			this.b1.ColumnName = "idRequest";
			this.b1.DataType = typeof(int);
			this.b2.ColumnName = "FileName";
			this.b3.ColumnName = "Comment";
			this.cy.Columns.AddRange(new DataColumn[]
			{
				this.cz,
				this.c0,
				this.c1,
				this.c2,
				this.c3,
				this.c4,
				this.c5,
				this.c6
			});
			this.cy.TableName = "tableAddress";
			this.cz.ColumnName = "id";
			this.cz.DataType = typeof(int);
			this.c0.ColumnName = "idRequest";
			this.c0.DataType = typeof(int);
			this.c1.ColumnName = "City";
			this.c2.ColumnName = "idKladrObj";
			this.c2.DataType = typeof(int);
			this.c3.ColumnName = "Street";
			this.c4.ColumnName = "idKladrStreet";
			this.c4.DataType = typeof(int);
			this.c5.ColumnName = "House";
			this.c6.ColumnName = "Name";
			this.c7.AllowUserToAddRows = false;
			this.c7.AllowUserToDeleteRows = false;
			this.c7.AutoGenerateColumns = false;
			this.c7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.c7.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dd,
				this.de,
				this.df,
				this.dg,
				this.dh,
				this.di,
				this.dj,
				this.dk
			});
			this.c7.DataSource = this.c8;
			this.c7.Dock = DockStyle.Fill;
			this.c7.Location = new Point(0, 25);
			this.c7.Name = "dgvAddress";
			this.c7.ReadOnly = true;
			this.c7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.c7.Size = new Size(724, 307);
			this.c7.TabIndex = 1;
			this.dd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dd.DataPropertyName = "City";
			this.dd.FillWeight = 30f;
			this.dd.HeaderText = "Нас пункт";
			this.dd.Name = "cityDataGridViewTextBoxColumn";
			this.dd.ReadOnly = true;
			this.de.DataPropertyName = "id";
			this.de.HeaderText = "id";
			this.de.Name = "idAddressDgvColumn";
			this.de.ReadOnly = true;
			this.de.Visible = false;
			this.df.DataPropertyName = "idRequest";
			this.df.HeaderText = "idRequest";
			this.df.Name = "idRequestDataGridViewTextBoxColumn2";
			this.df.ReadOnly = true;
			this.df.Visible = false;
			this.dg.DataPropertyName = "idKladrObj";
			this.dg.HeaderText = "idKladrObj";
			this.dg.Name = "idKladrObjDataGridViewTextBoxColumn";
			this.dg.ReadOnly = true;
			this.dg.Visible = false;
			this.dh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dh.DataPropertyName = "Street";
			this.dh.FillWeight = 50f;
			this.dh.HeaderText = "Улица";
			this.dh.Name = "streetDataGridViewTextBoxColumn";
			this.dh.ReadOnly = true;
			this.di.DataPropertyName = "idKladrStreet";
			this.di.HeaderText = "idKladrStreet";
			this.di.Name = "idKladrStreetDataGridViewTextBoxColumn";
			this.di.ReadOnly = true;
			this.di.Visible = false;
			this.dj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dj.DataPropertyName = "House";
			this.dj.FillWeight = 20f;
			this.dj.HeaderText = "Дом";
			this.dj.Name = "houseDataGridViewTextBoxColumn";
			this.dj.ReadOnly = true;
			this.dk.DataPropertyName = "Name";
			this.dk.HeaderText = "Name";
			this.dk.Name = "nameDataGridViewTextBoxColumn";
			this.dk.ReadOnly = true;
			this.dk.Visible = false;
			this.c8.DataMember = "tableAddress";
			this.c8.DataSource = this.bl;
			this.c8.Sort = "City, Street, House";
			this.c9.Items.AddRange(new ToolStripItem[]
			{
				this.da,
				this.db
			});
			this.c9.Location = new Point(0, 0);
			this.c9.Name = "toolStripAddress";
			this.c9.Size = new Size(724, 25);
			this.c9.TabIndex = 0;
			this.c9.Text = "toolStrip1";
			this.da.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.da.Image = Resources.ElementAdd;
			this.da.ImageTransparentColor = Color.Magenta;
			this.da.Name = "toolBtnAddAddress";
			this.da.Size = new Size(23, 22);
			this.da.Text = "Добавить адрес";
			this.da.Click += this.c;
			this.db.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.db.Image = Resources.ElementDel;
			this.db.ImageTransparentColor = Color.Magenta;
			this.db.Name = "toolBtnDelAddress";
			this.db.Size = new Size(23, 22);
			this.db.Text = "Удалить адрес";
			this.db.Click += this.b;
			this.bk.Controls.Add(this.bv);
			this.bk.Controls.Add(this.bx);
			this.bk.Location = new Point(4, 22);
			this.bk.Name = "tabPageDocuments";
			this.bk.Padding = new Padding(3);
			this.bk.Size = new Size(730, 643);
			this.bk.TabIndex = 2;
			this.bk.Text = "Документы";
			this.bk.UseVisualStyleBackColor = true;
			this.bv.AllowUserToAddRows = false;
			this.bv.AllowUserToDeleteRows = false;
			this.bv.AutoGenerateColumns = false;
			this.bv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bv.Columns.AddRange(new DataGridViewColumn[]
			{
				this.b7,
				this.b9,
				this.ca,
				this.cb,
				this.b8
			});
			this.bv.DataSource = this.bw;
			this.bv.Dock = DockStyle.Fill;
			this.bv.Location = new Point(3, 28);
			this.bv.Name = "dgvDocs";
			this.bv.RowHeadersWidth = 21;
			this.bv.Size = new Size(724, 612);
			this.bv.TabIndex = 1;
			this.bv.VirtualMode = true;
			this.bv.CellContentClick += this.a;
			this.bv.CellValueNeeded += this.a;
			this.b7.DataPropertyName = "id";
			this.b7.HeaderText = "id";
			this.b7.Name = "idDataGridViewTextBoxColumnDoc";
			this.b7.ReadOnly = true;
			this.b7.Visible = false;
			this.b9.DataPropertyName = "idRequest";
			this.b9.HeaderText = "idRequest";
			this.b9.Name = "idRequestDataGridViewTextBoxColumn1";
			this.b9.Visible = false;
			this.ca.DataPropertyName = "FileName";
			this.ca.HeaderText = "Файл";
			this.ca.Name = "fileNameDataGridViewTextBoxColumn";
			this.ca.ReadOnly = true;
			this.ca.Resizable = DataGridViewTriState.True;
			this.ca.SortMode = DataGridViewColumnSortMode.Automatic;
			this.ca.Width = 200;
			this.cb.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.cb.DataPropertyName = "Comment";
			this.cb.HeaderText = "Комментарий";
			this.cb.Name = "commentDataGridViewTextBoxColumn";
			dataGridViewCellStyle4.NullValue = null;
			this.b8.DefaultCellStyle = dataGridViewCellStyle4;
			this.b8.HeaderText = "";
			this.b8.Name = "ColumnImage";
			this.b8.ReadOnly = true;
			this.b8.Resizable = DataGridViewTriState.False;
			this.b8.Width = 30;
			this.bw.DataMember = "tJ_RequestForRepairDoc";
			this.bw.DataSource = this.z;
			this.bx.Items.AddRange(new ToolStripItem[]
			{
				this.by,
				this.b4,
				this.b5,
				this.b6
			});
			this.bx.Location = new Point(3, 3);
			this.bx.Name = "toolStripDocuments";
			this.bx.Size = new Size(724, 25);
			this.bx.TabIndex = 0;
			this.bx.Text = "toolStrip1";
			this.by.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.by.Image = Resources.ElementAdd;
			this.by.ImageTransparentColor = Color.Magenta;
			this.by.Name = "toolBtnAddDoc";
			this.by.Size = new Size(23, 22);
			this.by.Text = "Добавить документ";
			this.by.Click += this.h;
			this.b4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.b4.Image = Resources.ElementDel;
			this.b4.ImageTransparentColor = Color.Magenta;
			this.b4.Name = "toolBtnDelDoc";
			this.b4.Size = new Size(23, 22);
			this.b4.Text = "Удалить документ";
			this.b4.Click += this.g;
			this.b5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.b5.Image = Resources.ElementInformation;
			this.b5.ImageTransparentColor = Color.Magenta;
			this.b5.Name = "toolBtnViewDoc";
			this.b5.Size = new Size(23, 22);
			this.b5.Text = "Открыть документ";
			this.b5.Click += this.f;
			this.b6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.b6.Image = Resources.ElementGo;
			this.b6.ImageTransparentColor = Color.Magenta;
			this.b6.Name = "toolBtnSaveDoc";
			this.b6.Size = new Size(23, 22);
			this.b6.Text = "Сохранить документ";
			this.b6.Click += this.e;
			this.dw.Controls.Add(this.dx);
			this.dw.Location = new Point(4, 22);
			this.dw.Name = "tabPageLog";
			this.dw.Padding = new Padding(3);
			this.dw.Size = new Size(730, 643);
			this.dw.TabIndex = 3;
			this.dw.Text = "Логирование";
			this.dw.UseVisualStyleBackColor = true;
			this.dx.AllowUserToAddRows = false;
			this.dx.AllowUserToDeleteRows = false;
			this.dx.AutoGenerateColumns = false;
			this.dx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dx.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dz,
				this.d0,
				this.d1,
				this.d2,
				this.d3,
				this.d4,
				this.d5,
				this.d6,
				this.d7
			});
			this.dx.DataSource = this.dy;
			this.dx.Dock = DockStyle.Fill;
			this.dx.Location = new Point(3, 3);
			this.dx.Name = "dataGridViewExcelFilter1";
			this.dx.ReadOnly = true;
			this.dx.RowHeadersWidth = 21;
			this.dx.Size = new Size(724, 637);
			this.dx.TabIndex = 0;
			this.dz.DataPropertyName = "dateLog";
			this.dz.HeaderText = "Дата";
			this.dz.Name = "dateLogDataGridViewTextBoxColumn";
			this.dz.ReadOnly = true;
			this.d0.DataPropertyName = "id";
			this.d0.HeaderText = "id";
			this.d0.Name = "idDataGridViewTextBoxColumn1";
			this.d0.ReadOnly = true;
			this.d0.Visible = false;
			this.d1.DataPropertyName = "idRequest";
			this.d1.HeaderText = "idRequest";
			this.d1.Name = "idRequestDataGridViewTextBoxColumn3";
			this.d1.ReadOnly = true;
			this.d1.Visible = false;
			this.d2.DataPropertyName = "userLogID";
			this.d2.HeaderText = "userLogID";
			this.d2.Name = "userLogIDDataGridViewTextBoxColumn";
			this.d2.ReadOnly = true;
			this.d2.Visible = false;
			this.d3.DataPropertyName = "userLog";
			this.d3.HeaderText = "userLog";
			this.d3.Name = "userLogDataGridViewTextBoxColumn";
			this.d3.ReadOnly = true;
			this.d3.Visible = false;
			this.d4.DataPropertyName = "userLogName";
			this.d4.HeaderText = "Автор";
			this.d4.Name = "userLogNameDataGridViewTextBoxColumn";
			this.d4.ReadOnly = true;
			this.d5.DataPropertyName = "idCommand";
			this.d5.HeaderText = "idCommand";
			this.d5.Name = "idCommandDataGridViewTextBoxColumn";
			this.d5.ReadOnly = true;
			this.d5.Visible = false;
			this.d6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.d6.DataPropertyName = "Command";
			this.d6.HeaderText = "Действие";
			this.d6.Name = "commandDataGridViewTextBoxColumn";
			this.d6.ReadOnly = true;
			this.d7.DataPropertyName = "isSite";
			this.d7.HeaderText = "isSite";
			this.d7.Name = "isSiteDataGridViewCheckBoxColumn";
			this.d7.ReadOnly = true;
			this.dy.DataMember = "tJ_RequestForRepairLog";
			this.dy.DataSource = this.z;
			this.dy.Sort = "dateLog desc, id desc";
			this.cc.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.cc.Location = new Point(240, 682);
			this.cc.Name = "buttonCopy";
			this.cc.Size = new Size(75, 23);
			this.cc.TabIndex = 50;
			this.cc.Text = "Копировать";
			this.cc.UseVisualStyleBackColor = true;
			this.cc.Visible = false;
			this.cc.Click += this.d;
			this.dc.DoWork += this.a;
			this.dc.RunWorkerCompleted += this.a;
			this.d8.DialogResult = DialogResult.Cancel;
			this.d8.Location = new Point(574, 678);
			this.d8.Name = "buttonCancel";
			this.d8.Size = new Size(75, 23);
			this.d8.TabIndex = 51;
			this.d8.Text = "Отмена";
			this.d8.UseVisualStyleBackColor = true;
			this.d8.Click += this.i;
			base.AcceptButton = this.ar;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.d8;
			base.ClientSize = new Size(664, 713);
			base.Controls.Add(this.d8);
			base.Controls.Add(this.cc);
			base.Controls.Add(this.bh);
			base.Controls.Add(this.ar);
			base.Name = "FormJournalRequestForRepairAddEdit";
			this.Text = "FormJournalRequestForRepairAddEdit";
			base.FormClosing += this.a;
			base.FormClosed += this.a;
			base.Load += this.ag;
			((ISupportInitialize)this.z).EndInit();
			this.af.ResumeLayout(false);
			this.af.PerformLayout();
			this.bd.ResumeLayout(false);
			this.bd.PerformLayout();
			this.a3.ResumeLayout(false);
			this.a3.PerformLayout();
			((ISupportInitialize)this.a5).EndInit();
			this.ao.ResumeLayout(false);
			this.ao.PerformLayout();
			this.bh.ResumeLayout(false);
			this.bi.ResumeLayout(false);
			this.bi.PerformLayout();
			((ISupportInitialize)this.cu).EndInit();
			this.cd.ResumeLayout(false);
			this.cd.PerformLayout();
			this.bj.ResumeLayout(false);
			this.bj.PerformLayout();
			this.cx.Panel1.ResumeLayout(false);
			this.cx.Panel2.ResumeLayout(false);
			this.cx.Panel2.PerformLayout();
			this.cx.ResumeLayout(false);
			((ISupportInitialize)this.bt).EndInit();
			((ISupportInitialize)this.bu).EndInit();
			((ISupportInitialize)this.bl).EndInit();
			((ISupportInitialize)this.bm).EndInit();
			((ISupportInitialize)this.bz).EndInit();
			((ISupportInitialize)this.cy).EndInit();
			((ISupportInitialize)this.c7).EndInit();
			((ISupportInitialize)this.c8).EndInit();
			this.c9.ResumeLayout(false);
			this.c9.PerformLayout();
			this.bk.ResumeLayout(false);
			this.bk.PerformLayout();
			((ISupportInitialize)this.bv).EndInit();
			((ISupportInitialize)this.bw).EndInit();
			this.bx.ResumeLayout(false);
			this.bx.PerformLayout();
			this.dw.ResumeLayout(false);
			((ISupportInitialize)this.dx).EndInit();
			((ISupportInitialize)this.dy).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000E0 RID: 224
		private int a = -1;

		// Token: 0x040000E1 RID: 225
		private int b = -1;

		// Token: 0x040000E2 RID: 226
		private const int c = 920;

		// Token: 0x040000E3 RID: 227
		private const int d = 921;

		// Token: 0x040000E4 RID: 228
		private eActionRequestRepair e = eActionRequestRepair.Read;

		// Token: 0x040000E5 RID: 229
		private DateTime f = new DateTime(1900, 1, 1);

		// Token: 0x040000E6 RID: 230
		private DateTime g = new DateTime(9000, 1, 1);

		// Token: 0x040000E7 RID: 231
		private int h = -1;

		// Token: 0x040000E8 RID: 232
		private bool i;

		// Token: 0x040000E9 RID: 233
		private bool j;

		// Token: 0x040000EA RID: 234
		private bool k;

		// Token: 0x040000EB RID: 235
		private DataRow l;

		// Token: 0x040000EC RID: 236
		private DataTable m;

		// Token: 0x040000ED RID: 237
		private DataTable n;

		// Token: 0x040000EE RID: 238
		private DataTable o;

		// Token: 0x040000EF RID: 239
		private DataTable p;

		// Token: 0x040000F0 RID: 240
		private DataTable q;

		// Token: 0x040000F1 RID: 241
		private Dictionary<int, string> r = new Dictionary<int, string>();

		// Token: 0x040000F2 RID: 242
		private int s = -1;

		// Token: 0x040000F3 RID: 243
		private ElectricModel t;

		// Token: 0x040000F4 RID: 244
		private DataTable u;

		// Token: 0x040000F5 RID: 245
		private DataTable v;

		// Token: 0x040000F6 RID: 246
		private DataTable w;

		// Token: 0x040000F7 RID: 247
		private Dictionary<int, string> x;

		// Token: 0x040000F9 RID: 249
		private DataSetGES z;

		// Token: 0x040000FA RID: 250
		private Label aa;

		// Token: 0x040000FB RID: 251
		private ComboBox ab;

		// Token: 0x040000FC RID: 252
		private Label ac;

		// Token: 0x040000FD RID: 253
		private Label ad;

		// Token: 0x040000FE RID: 254
		private ComboBox ae;

		// Token: 0x040000FF RID: 255
		private GroupBox af;

		// Token: 0x04000100 RID: 256
		private Label ag;

		// Token: 0x04000101 RID: 257
		private ComboBox ah;

		// Token: 0x04000102 RID: 258
		private Label ai;

		// Token: 0x04000103 RID: 259
		private Label aj;

		// Token: 0x04000104 RID: 260
		private TextBox ak;

		// Token: 0x04000105 RID: 261
		private TextBox al;

		// Token: 0x04000106 RID: 262
		private Label am;

		// Token: 0x04000107 RID: 263
		private Label an;

		// Token: 0x04000108 RID: 264
		private GroupBox ao;

		// Token: 0x04000109 RID: 265
		private TextBox ap;

		// Token: 0x0400010A RID: 266
		private TextBox aq;

		// Token: 0x0400010B RID: 267
		private Button ar;

		// Token: 0x0400010C RID: 268
		private ComboBox @as;

		// Token: 0x0400010D RID: 269
		private Label at;

		// Token: 0x0400010E RID: 270
		private Label au;

		// Token: 0x0400010F RID: 271
		private NullableDateTimePicker av;

		// Token: 0x04000110 RID: 272
		private CheckBox aw;

		// Token: 0x04000111 RID: 273
		private Label ax;

		// Token: 0x04000112 RID: 274
		private Label ay;

		// Token: 0x04000113 RID: 275
		private Label az;

		// Token: 0x04000114 RID: 276
		private ComboBox a0;

		// Token: 0x04000115 RID: 277
		private Label a1;

		// Token: 0x04000116 RID: 278
		private TextBox a2;

		// Token: 0x04000117 RID: 279
		private GroupBox a3;

		// Token: 0x04000118 RID: 280
		private Button a4;

		// Token: 0x04000119 RID: 281
		private DataGridView a5;

		// Token: 0x0400011A RID: 282
		private CheckBox a6;

		// Token: 0x0400011B RID: 283
		private CheckBox a7;

		// Token: 0x0400011C RID: 284
		private DateTimePicker a8;

		// Token: 0x0400011D RID: 285
		private DateTimePicker a9;

		// Token: 0x0400011E RID: 286
		private Label ba;

		// Token: 0x0400011F RID: 287
		private Label bb;

		// Token: 0x04000120 RID: 288
		private NullableDateTimePicker bc;

		// Token: 0x04000121 RID: 289
		private ToolStrip bd;

		// Token: 0x04000122 RID: 290
		private ToolStripButton be;

		// Token: 0x04000123 RID: 291
		private ToolStripButton bf;

		// Token: 0x04000124 RID: 292
		private ToolStripButton bg;

		// Token: 0x04000125 RID: 293
		private TabControl bh;

		// Token: 0x04000126 RID: 294
		private TabPage bi;

		// Token: 0x04000127 RID: 295
		private TabPage bj;

		// Token: 0x04000128 RID: 296
		private TabPage bk;

		// Token: 0x04000129 RID: 297
		private DataSet bl;

		// Token: 0x0400012A RID: 298
		private DataTable bm;

		// Token: 0x0400012B RID: 299
		private DataColumn bn;

		// Token: 0x0400012C RID: 300
		private DataColumn bo;

		// Token: 0x0400012D RID: 301
		private DataColumn bp;

		// Token: 0x0400012E RID: 302
		private DataColumn bq;

		// Token: 0x0400012F RID: 303
		private DataColumn br;

		// Token: 0x04000130 RID: 304
		private ToolStripButton bs;

		// Token: 0x04000131 RID: 305
		private DataGridViewExcelFilter bt;

		// Token: 0x04000132 RID: 306
		private BindingSource bu;

		// Token: 0x04000133 RID: 307
		private DataGridViewExcelFilter bv;

		// Token: 0x04000134 RID: 308
		private BindingSource bw;

		// Token: 0x04000135 RID: 309
		private ToolStrip bx;

		// Token: 0x04000136 RID: 310
		private ToolStripButton by;

		// Token: 0x04000137 RID: 311
		private DataTable bz;

		// Token: 0x04000138 RID: 312
		private DataColumn b0;

		// Token: 0x04000139 RID: 313
		private DataColumn b1;

		// Token: 0x0400013A RID: 314
		private DataColumn b2;

		// Token: 0x0400013B RID: 315
		private DataColumn b3;

		// Token: 0x0400013C RID: 316
		private ToolStripButton b4;

		// Token: 0x0400013D RID: 317
		private ToolStripButton b5;

		// Token: 0x0400013E RID: 318
		private ToolStripButton b6;

		// Token: 0x0400013F RID: 319
		private DataGridViewTextBoxColumn b7;

		// Token: 0x04000140 RID: 320
		private DataGridViewImageColumnNotNull b8;

		// Token: 0x04000141 RID: 321
		private DataGridViewTextBoxColumn b9;

		// Token: 0x04000142 RID: 322
		private DataGridViewLinkColumn ca;

		// Token: 0x04000143 RID: 323
		private DataGridViewTextBoxColumn cb;

		// Token: 0x04000144 RID: 324
		private Button cc;

		// Token: 0x04000145 RID: 325
		private ToolStrip cd;

		// Token: 0x04000146 RID: 326
		private ToolStripButton ce;

		// Token: 0x04000147 RID: 327
		private DataGridViewTextBoxColumn cf;

		// Token: 0x04000148 RID: 328
		private DataGridViewTextBoxColumn cg;

		// Token: 0x04000149 RID: 329
		private DataGridViewFilterDateTimePickerColumn ch;

		// Token: 0x0400014A RID: 330
		private DataGridViewFilterDateTimePickerColumn ci;

		// Token: 0x0400014B RID: 331
		private TextBox cj;

		// Token: 0x0400014C RID: 332
		private ComboBox ck;

		// Token: 0x0400014D RID: 333
		private ComboBox cl;

		// Token: 0x0400014E RID: 334
		private ComboBox cm;

		// Token: 0x0400014F RID: 335
		private Label cn;

		// Token: 0x04000150 RID: 336
		private ComboBox co;

		// Token: 0x04000151 RID: 337
		private Label cp;

		// Token: 0x04000152 RID: 338
		private ComboBox cq;

		// Token: 0x04000153 RID: 339
		private Label cr;

		// Token: 0x04000154 RID: 340
		private ComboBox cs;

		// Token: 0x04000155 RID: 341
		private Label ct;

		// Token: 0x04000156 RID: 342
		private BindingSource cu;

		// Token: 0x04000157 RID: 343
		private ComboBox cv;

		// Token: 0x04000158 RID: 344
		private Label cw;

		// Token: 0x04000159 RID: 345
		private SplitContainer cx;

		// Token: 0x0400015A RID: 346
		private DataTable cy;

		// Token: 0x0400015B RID: 347
		private DataColumn cz;

		// Token: 0x0400015C RID: 348
		private DataColumn c0;

		// Token: 0x0400015D RID: 349
		private DataColumn c1;

		// Token: 0x0400015E RID: 350
		private DataColumn c2;

		// Token: 0x0400015F RID: 351
		private DataColumn c3;

		// Token: 0x04000160 RID: 352
		private DataColumn c4;

		// Token: 0x04000161 RID: 353
		private DataColumn c5;

		// Token: 0x04000162 RID: 354
		private DataColumn c6;

		// Token: 0x04000163 RID: 355
		private DataGridViewExcelFilter c7;

		// Token: 0x04000164 RID: 356
		private BindingSource c8;

		// Token: 0x04000165 RID: 357
		private ToolStrip c9;

		// Token: 0x04000166 RID: 358
		private ToolStripButton da;

		// Token: 0x04000167 RID: 359
		private ToolStripButton db;

		// Token: 0x04000168 RID: 360
		private BackgroundWorker dc;

		// Token: 0x04000169 RID: 361
		private DataGridViewTextBoxColumn dd;

		// Token: 0x0400016A RID: 362
		private DataGridViewTextBoxColumn de;

		// Token: 0x0400016B RID: 363
		private DataGridViewTextBoxColumn df;

		// Token: 0x0400016C RID: 364
		private DataGridViewTextBoxColumn dg;

		// Token: 0x0400016D RID: 365
		private DataGridViewTextBoxColumn dh;

		// Token: 0x0400016E RID: 366
		private DataGridViewTextBoxColumn di;

		// Token: 0x0400016F RID: 367
		private DataGridViewTextBoxColumn dj;

		// Token: 0x04000170 RID: 368
		private DataGridViewTextBoxColumn dk;

		// Token: 0x04000171 RID: 369
		private NullableDateTimePicker dl;

		// Token: 0x04000172 RID: 370
		private ToolStripButton dm;

		// Token: 0x04000173 RID: 371
		private ComboBox dn;

		// Token: 0x04000174 RID: 372
		private DataColumn @do;

		// Token: 0x04000175 RID: 373
		private DataGridViewTextBoxColumn dp;

		// Token: 0x04000176 RID: 374
		private DataGridViewTextBoxColumn dq;

		// Token: 0x04000177 RID: 375
		private DataGridViewTextBoxColumn dr;

		// Token: 0x04000178 RID: 376
		private DataGridViewTextBoxColumn ds;

		// Token: 0x04000179 RID: 377
		private DataGridViewTextBoxColumn dt;

		// Token: 0x0400017A RID: 378
		private DataGridViewCheckBoxColumn du;

		// Token: 0x0400017B RID: 379
		private CheckBox dv;

		// Token: 0x0400017C RID: 380
		private TabPage dw;

		// Token: 0x0400017D RID: 381
		private DataGridViewExcelFilter dx;

		// Token: 0x0400017E RID: 382
		private BindingSource dy;

		// Token: 0x0400017F RID: 383
		private DataGridViewTextBoxColumn dz;

		// Token: 0x04000180 RID: 384
		private DataGridViewTextBoxColumn d0;

		// Token: 0x04000181 RID: 385
		private DataGridViewTextBoxColumn d1;

		// Token: 0x04000182 RID: 386
		private DataGridViewTextBoxColumn d2;

		// Token: 0x04000183 RID: 387
		private DataGridViewTextBoxColumn d3;

		// Token: 0x04000184 RID: 388
		private DataGridViewTextBoxColumn d4;

		// Token: 0x04000185 RID: 389
		private DataGridViewTextBoxColumn d5;

		// Token: 0x04000186 RID: 390
		private DataGridViewTextBoxColumn d6;

		// Token: 0x04000187 RID: 391
		private DataGridViewCheckBoxColumn d7;

		// Token: 0x04000188 RID: 392
		private Button d8;

		// Token: 0x02000044 RID: 68
		[CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060001B8 RID: 440 RVA: 0x00016024 File Offset: 0x00014224
			internal bool b(ElectricObject A_0)
			{
				return this.a.Contains(A_0.Id);
			}

			// Token: 0x04000196 RID: 406
			public List<int> a;
		}

		// Token: 0x02000045 RID: 69
		[CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060001BA RID: 442 RVA: 0x0001603F File Offset: 0x0001423F
			internal bool b(ElectricObject A_0)
			{
				return A_0.Id == this.a;
			}

			// Token: 0x060001BB RID: 443 RVA: 0x0001604F File Offset: 0x0001424F
			internal bool c(ElectricObject A_0)
			{
				return A_0.Id == this.a;
			}

			// Token: 0x04000197 RID: 407
			public int a;
		}
	}
}
