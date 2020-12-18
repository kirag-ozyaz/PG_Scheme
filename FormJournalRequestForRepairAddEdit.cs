using System;
using System.Collections;
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
using System.ServiceModel;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using CpqUqHLETpQM1GPco5;
using cuviS0OvlA7biGvOSn;
using CZUM21s3QjGFLaOaSlT;
using DataSql;
using DB6vtwDbcGARY8yZXc;
using FormLbr;
using FormLbr.Classes;
using HsEXfKsq15GfPw4kPLQ;
using j5c8XXscsIc6vD2Fg4l;
using kDqVgKJgtBgVGRux2Q;
using MvaLQQTEtIaq3uG67b;
using pbkZoaB6tFgyiUHIKr;
using ppnZVr6AHhE7WGGKHi;
using RequestsClient.Properties;
using RequestsClient.RequestService;
using SchemeModel;
using SchemeModel.Calculations;
using Uyev3X11Q89JA1jQe0;
using WTbxUfsXa34kJl1qKMV;

namespace RequestsClient.Forms.JournalRequestForRepair
{
	// Token: 0x02000035 RID: 53
	public class FormJournalRequestForRepairAddEdit : FormBase
	{
		// Token: 0x06000218 RID: 536 RVA: 0x0000A9A8 File Offset: 0x00008DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PSpgGiFBsn()
		{
			while (false)
			{
				object obj = null[0];
			}
			return this.cs3eIKVCEg;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000A9C0 File Offset: 0x00008DC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void kvLgjp6DZb(bool value)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.cs3eIKVCEg = value;
			this.YQrg2wn9R8();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000A9E0 File Offset: 0x00008DE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FormJournalRequestForRepairAddEdit()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 8:
					this.abEgNyD5Y6 = -1;
					this.RqkgE4wFvG = -1;
					goto IL_26;
				case 2:
					goto IL_26;
				case 3:
					this.Q9Se39NXKE = -1;
					num = 7;
					continue;
				case 4:
					this.vclgz3ljku = new DateTime(1900, 1, 1);
					goto IL_10A;
				case 5:
					goto IL_93;
				case 6:
					goto IL_10A;
				case 7:
					goto IL_A6;
				case 9:
					return;
				default:
					num = 6;
					if (!true)
					{
						goto IL_93;
					}
					continue;
				}
				IL_E5:
				HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
				FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
				if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					num = 5;
					continue;
				}
				num = 8;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_10A;
				}
				continue;
				IL_93:
				this.ffsghkQnr5 = eActionRequestRepair.Read;
				num = 4;
				if (false)
				{
					goto IL_A6;
				}
				continue;
				IL_26:
				goto IL_93;
				IL_A6:
				this.MXUe8Spw0O = new Dictionary<int, string>();
				this.LEveRtAqeF = -1;
				this.mAWe7Y0Jgh = new List<int>();
				base..ctor();
				this.WvngYeZ1e5();
				this.BFFIau028A();
				num = 9;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_E5;
				}
				continue;
				IL_10A:
				this.DVHeZEqiiZ = new DateTime(9000, 1, 1);
				num = 3;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000AB24 File Offset: 0x00008F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FormJournalRequestForRepairAddEdit(int idRequest, int idDivision, eActionRequestRepair action, bool isCrash = false)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 1 : 7;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 7:
					goto IL_145;
				case 2:
					this.ffsghkQnr5 = eActionRequestRepair.Read;
					num = 9;
					continue;
				case 3:
					this.ffsghkQnr5 = action;
					this.kvLgjp6DZb(isCrash);
					num = 10;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_145;
					}
					continue;
				case 4:
					this.BFFIau028A();
					this.abEgNyD5Y6 = idRequest;
					this.RqkgE4wFvG = idDivision;
					num = 3;
					continue;
				case 6:
					this.abEgNyD5Y6 = -1;
					num = 8;
					continue;
				case 8:
					this.RqkgE4wFvG = -1;
					num = 2;
					continue;
				case 9:
					this.vclgz3ljku = new DateTime(1900, 1, 1);
					this.DVHeZEqiiZ = new DateTime(9000, 1, 1);
					this.Q9Se39NXKE = -1;
					this.MXUe8Spw0O = new Dictionary<int, string>();
					this.LEveRtAqeF = -1;
					this.mAWe7Y0Jgh = new List<int>();
					break;
				case 10:
					return;
				}
				IL_D0:
				FormJournalRequestForRepairAddEdit.Yoo5LhXGr1xgGjP84Qm(this);
				this.WvngYeZ1e5();
				num = 4;
				continue;
				goto IL_D0;
				IL_145:
				FormJournalRequestForRepairAddEdit.gPULnAX1hHRaHBqMgff();
				num = 6;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000AC88 File Offset: 0x00009088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FormJournalRequestForRepairAddEdit(DataRow copy)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			if (false)
			{
				goto IL_1A;
			}
			for (;;)
			{
				IL_A2:
				switch (num)
				{
				case 0:
					HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
					num = 8;
					continue;
				case 1:
					this.BFFIau028A();
					this.abEgNyD5Y6 = -1;
					num = 5;
					continue;
				case 2:
				case 7:
					this.DVHeZEqiiZ = new DateTime(9000, 1, 1);
					break;
				case 3:
					break;
				case 4:
					goto IL_1A;
				case 5:
					goto IL_41;
				case 6:
					goto IL_7E;
				case 8:
					this.abEgNyD5Y6 = -1;
					this.RqkgE4wFvG = -1;
					this.ffsghkQnr5 = eActionRequestRepair.Read;
					this.vclgz3ljku = new DateTime(1900, 1, 1);
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 7;
						continue;
					}
					num = 9;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						return;
					}
					continue;
				case 9:
					break;
				case 10:
					return;
				default:
					num = 4;
					continue;
				}
				IL_140:
				this.Q9Se39NXKE = -1;
				num = 6;
				continue;
				goto IL_140;
			}
			IL_7E:
			this.MXUe8Spw0O = new Dictionary<int, string>();
			this.LEveRtAqeF = -1;
			IL_1A:
			this.mAWe7Y0Jgh = new List<int>();
			base..ctor();
			this.WvngYeZ1e5();
			num = 1;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
				goto IL_A2;
			}
			IL_41:
			this.RqkgE4wFvG = Convert.ToInt32(copy[cDhluYseFOthxgEIXpc.nKHKpgTSVU(3652)]);
			this.ffsghkQnr5 = eActionRequestRepair.Add;
			this.ixYenVOtfo = copy;
			num = 10;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
				goto IL_A2;
			}
			goto IL_A2;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000AE10 File Offset: 0x00009210
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BFFIau028A()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 1:
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.oyre5Btub4).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(3706), true, DataSourceUpdateMode.OnPropertyChanged));
					FormJournalRequestForRepairAddEdit.oMrpG2Xt7vv7bhXXG9H(FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.TKdnD2UOSQ));
					this.TKdnD2UOSQ.DataBindings.Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3768), true, DataSourceUpdateMode.OnPropertyChanged));
					goto IL_2C7;
				case 2:
					goto IL_2C7;
				case 3:
					this.oyre5Btub4.DataBindings.Clear();
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 0;
						continue;
					}
					num = 5;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						return;
					}
					continue;
				case 4:
					FormJournalRequestForRepairAddEdit.eNVU9sXVTPdgEbxSF8w(this.C99elfqXty.DataBindings, new Binding(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(3834), true, DataSourceUpdateMode.OnPropertyChanged));
					num = 8;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_115;
					}
					continue;
				case 5:
					goto IL_BA;
				case 6:
					goto IL_178;
				case 7:
					this.jbcndg5xWg.DataBindings.Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4132), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4144), true, DataSourceUpdateMode.OnPropertyChanged));
					num = 10;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_BA;
					}
					continue;
				case 8:
					goto IL_115;
				case 9:
					break;
				case 10:
					return;
				default:
					num = 9;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_178;
					}
					continue;
				}
				IL_18:
				this.KKYnt0822j.DataBindings.Add(new Binding(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3676), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3886), true, DataSourceUpdateMode.OnPropertyChanged));
				num = 6;
				continue;
				IL_115:
				FormJournalRequestForRepairAddEdit.oMrpG2Xt7vv7bhXXG9H(FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.KKYnt0822j));
				goto IL_18;
				IL_BA:
				FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.C99elfqXty).Clear();
				num = 4;
				continue;
				IL_2C7:
				goto IL_BA;
				IL_178:
				FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.I4xetUTq0V).Clear();
				this.I4xetUTq0V.DataBindings.Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(638), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3946), true, DataSourceUpdateMode.OnPropertyChanged));
				this.M5ZJs51OCB.DataBindings.Clear();
				this.M5ZJs51OCB.DataBindings.Add(new Binding(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4010), true, DataSourceUpdateMode.OnPropertyChanged));
				FormJournalRequestForRepairAddEdit.oMrpG2Xt7vv7bhXXG9H(this.kl0niMXXMI.DataBindings);
				FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.kl0niMXXMI).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4076), true, DataSourceUpdateMode.OnPropertyChanged));
				FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.jbcndg5xWg).Clear();
				num = 7;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B0FC File Offset: 0x000094FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BYPI1covQg()
		{
			while (false)
			{
				object obj = null[0];
			}
			using (SqlConnection sqlConnection = new SqlConnection(FormJournalRequestForRepairAddEdit.MYEP83XkI141am7o5YR(this).GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					object obj2 = new SqlDataAdapter(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4202), sqlConnection);
					DataTable dataTable = new DataTable();
					FormJournalRequestForRepairAddEdit.wKeE0MXd0NuogaNjchC(obj2, dataTable);
					if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable)) > 0 && FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(dataTable.Rows, 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4316)] != DBNull.Value)
					{
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.LoadXml(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(dataTable.Rows, 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4316)].ToString());
						XmlNode xmlNode = FormJournalRequestForRepairAddEdit.k70b6oXmxghxt8PBXca(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4336));
						if (xmlNode != null)
						{
							XmlNode xmlNode2 = FormJournalRequestForRepairAddEdit.k70b6oXmxghxt8PBXca(xmlNode, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4370));
							if (xmlNode2 != null)
							{
								XmlAttribute xmlAttribute = FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode2)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4380)];
								if (xmlAttribute != null)
								{
									this.q5CeeA3ux5 = Convert.ToBoolean(xmlAttribute.Value);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					throw new Exception(FormJournalRequestForRepairAddEdit.VIhy5SXRaCAk0LBkYLo(ex), FormJournalRequestForRepairAddEdit.CVOrcKXEZriCybjLgUW(ex));
				}
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000B250 File Offset: 0x00009650
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void nIKIOLEyLp()
		{
			while (false)
			{
				object obj = null[0];
			}
			try
			{
				this.yJieJApNRL = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4398));
				base.SelectSqlData(this.yJieJApNRL, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4452), null, false, 0);
				DataTable dataTable = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4398));
				FormJournalRequestForRepairAddEdit.uOQuZmXi3rjBekKWKMt(FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512), FormJournalRequestForRepairAddEdit.fubmvOX9d6a46jiTIfX(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
				FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable).Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4524), FormJournalRequestForRepairAddEdit.fubmvOX9d6a46jiTIfX(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
				this.KKYnt0822j.DataSource = dataTable;
				this.KKYnt0822j.DisplayMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(614);
				this.KKYnt0822j.ValueMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(638);
				if (this.q5CeeA3ux5)
				{
					try
					{
						FormJournalRequestForRepairAddEdit.Y2r8rOXeGu55hpFhlAx(new gKOgc5YsGEjMpcbTJE());
						RequestsServiceSoapClient requestsServiceSoapClient = new RequestsServiceSoapClient();
						FormJournalRequestForRepairAddEdit.tBoid2XMnEchHrkhsFA(requestsServiceSoapClient.InnerChannel, new TimeSpan(0, 0, 5));
						foreach (DICTIONARY dictionary in requestsServiceSoapClient.GetDictTypeRegion())
						{
							FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(dataTable.Rows, new object[]
							{
								dictionary.Name,
								FormJournalRequestForRepairAddEdit.pbCtu7X5XYGqJDU32VU(dictionary)
							});
						}
						goto IL_338;
					}
					catch (Exception)
					{
						this.KKYnt0822j.ForeColor = FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe();
						if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable).Count == 0)
						{
							using (IEnumerator enumerator = FormJournalRequestForRepairAddEdit.NLHZ9pX09y9dLHK3wDu(this.yJieJApNRL.Rows))
							{
								while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
									int num;
									if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
									{
										num = 2;
										if (false)
										{
											goto IL_1B4;
										}
									}
									else
									{
										num = 3;
									}
									switch (num)
									{
									case 0:
									case 2:
										IL_1B4:
										FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable), new object[]
										{
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)],
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)]
										});
										break;
									}
								}
							}
						}
						goto IL_338;
					}
				}
				if (dataTable.Rows.Count == 0)
				{
					using (IEnumerator enumerator = this.yJieJApNRL.Rows.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow2 = (DataRow)FormJournalRequestForRepairAddEdit.DbPnp0XhIcN9JOvTklQ(enumerator);
							switch ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 2)
							{
							case 0:
							case 2:
								FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable).Add(new object[]
								{
									FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)),
									dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)]
								});
								break;
							}
						}
					}
				}
				IL_338:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B610 File Offset: 0x00009A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HLwIL63Sgc(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				num = 1;
				if (false)
				{
					goto IL_26;
				}
			}
			else
			{
				num = 2;
				if (false)
				{
					return;
				}
			}
			for (;;)
			{
				IL_DF:
				switch (num)
				{
				case 0:
				case 1:
					goto IL_26;
				case 2:
					goto IL_61;
				case 3:
					goto IL_10E;
				case 4:
					goto IL_131;
				case 5:
					goto IL_42;
				case 6:
					goto IL_8A;
				case 7:
					return;
				default:
					num = 3;
					break;
				}
			}
			IL_26:
			if (FormJournalRequestForRepairAddEdit.FaYqW9XYC3KiLuJ88GO(this.C99elfqXty) == null)
			{
				goto IL_8A;
			}
			num = 5;
			if (!false)
			{
				goto IL_DF;
			}
			IL_42:
			if (FormJournalRequestForRepairAddEdit.FaYqW9XYC3KiLuJ88GO(this.C99elfqXty) == DBNull.Value)
			{
				num = 6;
				goto IL_DF;
			}
			DataRow[] array;
			if (this.yJieJApNRL != null)
			{
				array = this.yJieJApNRL.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4538) + this.C99elfqXty.SelectedValue.ToString());
				goto IL_10E;
			}
			return;
			IL_61:
			FormJournalRequestForRepairAddEdit.iJvHw6XundyImMbTt9G(this.KKYnt0822j, FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)));
			num = 7;
			if (true)
			{
				goto IL_DF;
			}
			IL_8A:
			this.KKYnt0822j.SelectedIndex = -1;
			return;
			IL_10E:
			if (array.Length == 0 || FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)) == DBNull.Value)
			{
				return;
			}
			IL_131:
			goto IL_61;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B760 File Offset: 0x00009B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void swSIvFBAJW(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
			int num;
			if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_121;
				}
			}
			DataRow[] array;
			for (;;)
			{
				IL_6C:
				switch (num)
				{
				case 0:
				case 2:
					if (FormJournalRequestForRepairAddEdit.FaYqW9XYC3KiLuJ88GO(this.KKYnt0822j) == null)
					{
						goto IL_B0;
					}
					break;
				case 1:
					break;
				case 3:
					goto IL_D4;
				case 4:
					break;
				case 5:
					goto IL_28;
				case 6:
					goto IL_121;
				case 7:
					return;
				default:
					num = 6;
					continue;
				}
				IL_9B:
				if (this.KKYnt0822j.SelectedValue == DBNull.Value)
				{
					goto IL_B0;
				}
				if (this.yJieJApNRL == null)
				{
					return;
				}
				num = 5;
				if (false)
				{
					goto IL_D4;
				}
				continue;
				goto IL_9B;
				IL_D4:
				this.C99elfqXty.SelectedValue = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(4592));
				num = 7;
			}
			IL_28:
			array = this.yJieJApNRL.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4558) + this.KKYnt0822j.SelectedValue.ToString());
			if (array.Length != 0)
			{
				goto IL_121;
			}
			return;
			IL_B0:
			FormJournalRequestForRepairAddEdit.DsontcXauIkkEcpw5iv(this.C99elfqXty, -1);
			return;
			IL_121:
			if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(4578)) != DBNull.Value)
			{
				num = 3;
				goto IL_6C;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B8B4 File Offset: 0x00009CB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void m5NI4ke5Cp()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			DataTable dataTable;
			IEnumerator enumerator;
			for (;;)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
					base.SelectSqlData(this.eVoe0Lldbr, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4606), null, false, 0);
					dataTable = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4398));
					num = 2;
					continue;
				case 2:
					goto IL_2AC;
				case 3:
				case 7:
					FormJournalRequestForRepairAddEdit.TxMbiyX8UhL1cbJeFy2(this.TKdnD2UOSQ, dataTable);
					goto IL_21B;
				case 4:
					this.eVoe0Lldbr = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4398));
					num = 1;
					continue;
				case 5:
					break;
				case 6:
					goto IL_21B;
				case 8:
					goto IL_31A;
				default:
					num = 6;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_2AC;
					}
					continue;
				}
				IL_74:
				if (this.q5CeeA3ux5)
				{
					try
					{
						ServicePointManager.CertificatePolicy = new gKOgc5YsGEjMpcbTJE();
						RequestsServiceSoapClient requestsServiceSoapClient = new RequestsServiceSoapClient();
						((IContextChannel)FormJournalRequestForRepairAddEdit.rwsQ8xXBQucaCjDK5eU(requestsServiceSoapClient)).OperationTimeout = new TimeSpan(0, 0, 5);
						foreach (DICTIONARY dictionary in FormJournalRequestForRepairAddEdit.M9siZvXyHLPwpHRUeFw(requestsServiceSoapClient))
						{
							FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable), new object[]
							{
								FormJournalRequestForRepairAddEdit.lJKyxTX6D01Esx5hRES(dictionary),
								FormJournalRequestForRepairAddEdit.pbCtu7X5XYGqJDU32VU(dictionary)
							});
						}
						return;
					}
					catch (Exception)
					{
						this.TKdnD2UOSQ.ForeColor = FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe();
						if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable)) == 0)
						{
							enumerator = this.eVoe0Lldbr.Rows.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									object obj2 = enumerator.Current;
									DataRow dataRow = (DataRow)obj2;
									FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
									switch ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 2)
									{
									case 0:
									case 2:
										dataTable.Rows.Add(new object[]
										{
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)],
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)]
										});
										break;
									}
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								if (disposable != null)
								{
									FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(disposable);
								}
							}
						}
						return;
					}
				}
				if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(dataTable.Rows) == 0)
				{
					enumerator = FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.eVoe0Lldbr).GetEnumerator();
					num = 8;
					continue;
				}
				return;
				IL_245:
				goto IL_74;
				IL_21B:
				this.TKdnD2UOSQ.DisplayMember = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(614);
				this.TKdnD2UOSQ.ValueMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(638);
				goto IL_245;
				IL_2AC:
				dataTable.Columns.Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512), FormJournalRequestForRepairAddEdit.fubmvOX9d6a46jiTIfX(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777225)));
				FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable).Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4524), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
				FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					num = 7;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
					}
				}
				else
				{
					num = 0;
				}
			}
			try
			{
				IL_31A:
				while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
				{
					DataRow dataRow2 = (DataRow)enumerator.Current;
					int num2;
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num2 = 2;
						if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							goto IL_349;
						}
					}
					else
					{
						num2 = 3;
					}
					switch (num2)
					{
					case 0:
					case 2:
						IL_349:
						FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable).Add(new object[]
						{
							dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512)],
							FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(638))
						});
						break;
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(disposable);
				}
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000BCF0 File Offset: 0x0000A0F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void aoVIBnICPf(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				num = 6;
				if (false)
				{
					goto IL_26;
				}
			}
			else
			{
				num = 2;
			}
			for (;;)
			{
				IL_118:
				switch (num)
				{
				case 0:
				case 6:
					goto IL_26;
				case 1:
					if (this.TKdnD2UOSQ.SelectedValue == DBNull.Value)
					{
						num = 5;
						continue;
					}
					if (this.eVoe0Lldbr != null)
					{
						goto IL_40;
					}
					return;
				case 2:
					break;
				case 3:
					goto IL_40;
				case 4:
					break;
				case 5:
					goto IL_EE;
				case 7:
					return;
				default:
					num = 3;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				}
				IL_9E:
				DataRow[] array;
				this.oyre5Btub4.SelectedValue = Convert.ToBoolean(array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(4578)]);
				num = 7;
				continue;
				IL_8E:
				goto IL_9E;
				IL_40:
				array = this.eVoe0Lldbr.Select(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4558) + this.TKdnD2UOSQ.SelectedValue.ToString());
				if (array.Length != 0 && array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(4578)] != DBNull.Value)
				{
					goto IL_8E;
				}
				break;
			}
			return;
			IL_26:
			if (this.TKdnD2UOSQ.SelectedValue != null)
			{
				num = 1;
				goto IL_118;
			}
			IL_EE:
			FormJournalRequestForRepairAddEdit.DsontcXauIkkEcpw5iv(this.oyre5Btub4, -1);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000BE50 File Offset: 0x0000A250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tJRIlGe1K4(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 3;
			for (;;)
			{
				DataRow[] array;
				switch (num)
				{
				case 0:
					goto IL_66;
				case 1:
				case 5:
					if (FormJournalRequestForRepairAddEdit.FaYqW9XYC3KiLuJ88GO(this.oyre5Btub4) == DBNull.Value)
					{
						goto IL_129;
					}
					if (this.eVoe0Lldbr == null)
					{
						return;
					}
					array = this.eVoe0Lldbr.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4666) + Convert.ToInt32(FormJournalRequestForRepairAddEdit.FaYqW9XYC3KiLuJ88GO(this.oyre5Btub4)).ToString());
					if (array.Length == 0)
					{
						return;
					}
					break;
				case 2:
					goto IL_135;
				case 3:
					if (FormJournalRequestForRepairAddEdit.FaYqW9XYC3KiLuJ88GO(this.oyre5Btub4) == null)
					{
						goto IL_129;
					}
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 5;
						continue;
					}
					num = 6;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						return;
					}
					continue;
				case 4:
					break;
				case 6:
					return;
				case 7:
					return;
				default:
					num = 4;
					continue;
				}
				if (array[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)] == DBNull.Value)
				{
					return;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				IL_66:
				this.TKdnD2UOSQ.SelectedValue = array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)];
				num = 7;
			}
			return;
			IL_129:
			this.TKdnD2UOSQ.SelectedIndex = -1;
			IL_135:;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000BFA8 File Offset: 0x0000A3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void mBnIPFsbf5()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 9;
			DataTable dataTable;
			DataTable dataTable2;
			IEnumerator enumerator;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 2:
					dataTable = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4398));
					FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable).Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512), FormJournalRequestForRepairAddEdit.fubmvOX9d6a46jiTIfX(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
					FormJournalRequestForRepairAddEdit.uOQuZmXi3rjBekKWKMt(FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable), cDhluYseFOthxgEIXpc.nKHKpgTSVU(4524), Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777219)));
					num = 8;
					continue;
				case 1:
					goto IL_1F2;
				case 3:
					goto IL_426;
				case 4:
					base.SelectSqlData(this.qwCeo7kn8p, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4686), null, false, 0);
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 7 : 0);
					continue;
				case 6:
					FormJournalRequestForRepairAddEdit.m7yrknXSnVbhabeAIHm(this.EQknHC0OS1, cDhluYseFOthxgEIXpc.nKHKpgTSVU(614));
					break;
				case 8:
					this.EQknHC0OS1.DataSource = dataTable;
					num = 6;
					continue;
				case 9:
					this.qwCeo7kn8p = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4398));
					num = 4;
					if (!true)
					{
						goto IL_1F2;
					}
					continue;
				case 10:
					goto IL_442;
				}
				IL_FA:
				FormJournalRequestForRepairAddEdit.DM0SefXAU37XccbaJW5(this.EQknHC0OS1, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638));
				dataTable2 = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4398));
				FormJournalRequestForRepairAddEdit.uOQuZmXi3rjBekKWKMt(FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable2), cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
				dataTable2.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4524), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
				this.d7YnphvtQ1.DataSource = dataTable2;
				this.d7YnphvtQ1.DisplayMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(614);
				num = 1;
				continue;
				goto IL_FA;
				IL_1F2:
				FormJournalRequestForRepairAddEdit.DM0SefXAU37XccbaJW5(this.d7YnphvtQ1, cDhluYseFOthxgEIXpc.nKHKpgTSVU(638));
				if (this.q5CeeA3ux5)
				{
					try
					{
						FormJournalRequestForRepairAddEdit.Y2r8rOXeGu55hpFhlAx(new gKOgc5YsGEjMpcbTJE());
						RequestsServiceSoapClient requestsServiceSoapClient = new RequestsServiceSoapClient();
						FormJournalRequestForRepairAddEdit.tBoid2XMnEchHrkhsFA(requestsServiceSoapClient.InnerChannel, new TimeSpan(0, 0, 5));
						foreach (DICTIONARY dictionary in requestsServiceSoapClient.GetDictTypeOrganization())
						{
							FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable), new object[]
							{
								dictionary.Name,
								dictionary.Value
							});
							FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable2), new object[]
							{
								FormJournalRequestForRepairAddEdit.lJKyxTX6D01Esx5hRES(dictionary),
								dictionary.Value
							});
						}
						return;
					}
					catch (Exception)
					{
						this.EQknHC0OS1.ForeColor = Color.Red;
						FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.d7YnphvtQ1, FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe());
						if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(dataTable.Rows) == 0)
						{
							using (IEnumerator enumerator = FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.qwCeo7kn8p).GetEnumerator())
							{
								IL_3DC:
								while (enumerator.MoveNext())
								{
									object obj2 = enumerator.Current;
									DataRow dataRow = (DataRow)obj2;
									FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
									int num2 = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 3 : 2;
									for (;;)
									{
										switch (num2)
										{
										case 0:
										case 2:
											dataTable.Rows.Add(new object[]
											{
												FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512)),
												FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638))
											});
											break;
										case 4:
											goto IL_3DC;
										}
										IL_398:
										FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable2).Add(new object[]
										{
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)],
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)]
										});
										num2 = 4;
										continue;
										goto IL_398;
									}
								}
							}
						}
						return;
					}
				}
				if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable)) != 0)
				{
					return;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				IL_426:
				enumerator = this.qwCeo7kn8p.Rows.GetEnumerator();
				num = 10;
			}
			try
			{
				IL_442:
				IL_532:
				while (enumerator.MoveNext())
				{
					DataRow dataRow2 = (DataRow)FormJournalRequestForRepairAddEdit.DbPnp0XhIcN9JOvTklQ(enumerator);
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					int num3 = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 2 : 3;
					for (;;)
					{
						switch (num3)
						{
						case 0:
						case 3:
							dataTable.Rows.Add(new object[]
							{
								dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)],
								dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)]
							});
							break;
						case 4:
							goto IL_532;
						}
						IL_4E4:
						FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(dataTable2.Rows, new object[]
						{
							FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)),
							FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638))
						});
						num3 = 4;
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							continue;
						}
						continue;
						goto IL_4E4;
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(disposable);
				}
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000C55C File Offset: 0x0000A95C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void i0fIwb2bQC()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				num = 3;
				if (!true)
				{
					goto IL_26;
				}
			}
			else
			{
				num = 1;
			}
			DataTable dataTable;
			IEnumerator enumerator;
			for (;;)
			{
				IL_2C1:
				switch (num)
				{
				case 0:
				case 3:
					goto IL_26;
				case 1:
					goto IL_225;
				case 2:
					base.SelectSqlData(this.FT8eucyj8s, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4746), null, false, 0);
					num = 5;
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						continue;
					}
					break;
				default:
					goto IL_2EA;
				case 5:
					dataTable = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4398));
					num = 7;
					continue;
				case 6:
					break;
				case 7:
					FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable).Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512), FormJournalRequestForRepairAddEdit.fubmvOX9d6a46jiTIfX(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777225)));
					FormJournalRequestForRepairAddEdit.uOQuZmXi3rjBekKWKMt(dataTable.Columns, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4524), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
					FormJournalRequestForRepairAddEdit.TxMbiyX8UhL1cbJeFy2(this.H8tnxYcybE, dataTable);
					goto IL_2EA;
				case 8:
					goto IL_314;
				}
				if (this.q5CeeA3ux5)
				{
					try
					{
						FormJournalRequestForRepairAddEdit.Y2r8rOXeGu55hpFhlAx(new gKOgc5YsGEjMpcbTJE());
						RequestsServiceSoapClient requestsServiceSoapClient = new RequestsServiceSoapClient();
						FormJournalRequestForRepairAddEdit.tBoid2XMnEchHrkhsFA(requestsServiceSoapClient.InnerChannel, new TimeSpan(0, 0, 5));
						foreach (DICTIONARY dictionary in requestsServiceSoapClient.GetDictGroupWorks())
						{
							dataTable.Rows.Add(new object[]
							{
								FormJournalRequestForRepairAddEdit.lJKyxTX6D01Esx5hRES(dictionary),
								FormJournalRequestForRepairAddEdit.pbCtu7X5XYGqJDU32VU(dictionary)
							});
						}
						return;
					}
					catch (Exception)
					{
						this.H8tnxYcybE.ForeColor = Color.Red;
						if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(dataTable.Rows) == 0)
						{
							enumerator = FormJournalRequestForRepairAddEdit.NLHZ9pX09y9dLHK3wDu(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.FT8eucyj8s));
							try
							{
								while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									switch (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 3 : 2)
									{
									case 0:
									case 2:
										dataTable.Rows.Add(new object[]
										{
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)],
											dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)]
										});
										break;
									}
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								if (disposable != null)
								{
									FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(disposable);
								}
							}
						}
						return;
					}
				}
				if (dataTable.Rows.Count != 0)
				{
					return;
				}
				enumerator = this.FT8eucyj8s.Rows.GetEnumerator();
				num = 8;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				continue;
				IL_225:
				FormJournalRequestForRepairAddEdit.m7yrknXSnVbhabeAIHm(this.H8tnxYcybE, cDhluYseFOthxgEIXpc.nKHKpgTSVU(614));
				this.H8tnxYcybE.ValueMember = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638);
				num = 6;
				continue;
				IL_2EA:
				goto IL_225;
			}
			try
			{
				IL_314:
				while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
				{
					DataRow dataRow2 = (DataRow)enumerator.Current;
					switch (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 3 : 2)
					{
					case 0:
					case 2:
						FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable), new object[]
						{
							dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512)],
							dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)]
						});
						break;
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			return;
			IL_26:
			this.FT8eucyj8s = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4398));
			num = 2;
			goto IL_2C1;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000C968 File Offset: 0x0000AD68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RBZI5gPOBE()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			DataTable dataTable;
			IEnumerator enumerator;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.vOReMBXseE = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4398));
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 5;
						continue;
					}
					num = 7;
					if (false)
					{
						goto IL_260;
					}
					continue;
				case 1:
				case 7:
					base.SelectSqlData(this.vOReMBXseE, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4806), null, false, 0);
					num = 2;
					continue;
				case 2:
					dataTable = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4398));
					goto IL_55;
				case 3:
					goto IL_55;
				case 4:
					break;
				case 5:
					goto IL_260;
				case 6:
					enumerator = this.vOReMBXseE.Rows.GetEnumerator();
					num = 8;
					if (true)
					{
						continue;
					}
					break;
				case 8:
					goto IL_310;
				default:
					num = 4;
					continue;
				}
				IL_83:
				this.kl0niMXXMI.ValueMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(638);
				if (this.q5CeeA3ux5)
				{
					try
					{
						ServicePointManager.CertificatePolicy = new gKOgc5YsGEjMpcbTJE();
						foreach (DICTIONARY dictionary in FormJournalRequestForRepairAddEdit.Y8vEYrXf0smIDkrrE7N(new RequestsServiceSoapClient
						{
							InnerChannel = 
							{
								OperationTimeout = new TimeSpan(0, 0, 5)
							}
						}))
						{
							FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable), new object[]
							{
								dictionary.Name,
								FormJournalRequestForRepairAddEdit.pbCtu7X5XYGqJDU32VU(dictionary)
							});
						}
						return;
					}
					catch (Exception)
					{
						this.kl0niMXXMI.ForeColor = FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe();
						if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable).Count == 0)
						{
							using (IEnumerator enumerator = this.vOReMBXseE.Rows.GetEnumerator())
							{
								while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									int num2;
									if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
									{
										num2 = 2;
										if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
										{
											goto IL_176;
										}
									}
									else
									{
										num2 = 3;
									}
									switch (num2)
									{
									case 0:
									case 2:
										IL_176:
										FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(dataTable.Rows, new object[]
										{
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)],
											dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)]
										});
										break;
									}
								}
							}
						}
						return;
					}
				}
				if (dataTable.Rows.Count == 0)
				{
					num = 6;
					continue;
				}
				return;
				IL_260:
				dataTable.Columns.Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512), Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777225)));
				dataTable.Columns.Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4524), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
				this.kl0niMXXMI.DataSource = dataTable;
				FormJournalRequestForRepairAddEdit.m7yrknXSnVbhabeAIHm(this.kl0niMXXMI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(614));
				goto IL_83;
				IL_55:
				goto IL_260;
			}
			try
			{
				IL_310:
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					DataRow dataRow2 = (DataRow)obj2;
					switch ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 2)
					{
					case 0:
					case 2:
						FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable), new object[]
						{
							dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512)],
							dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)]
						});
						break;
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(disposable);
				}
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000CD94 File Offset: 0x0000B194
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FCuI96WxL7(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			for (;;)
			{
				DataRow dataRow;
				DataRow dataRow2;
				DataRow[] array2;
				DataRow[] array3;
				DataRow[] array4;
				switch (num)
				{
				case 0:
				{
					DataRow[] array;
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4960)] = array[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)];
					num = 48;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_939;
					}
					continue;
				}
				case 1:
					goto IL_62F;
				case 2:
					goto IL_771;
				case 3:
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5038), this.ixYenVOtfo[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5038)]);
					num = 37;
					continue;
				case 4:
				{
					IL_ACF:
					DataTable dataTable = this.dX2IfI82JW();
					num = 39;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				}
				case 5:
					goto IL_D8E;
				case 6:
					dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5016)] = this.ixYenVOtfo[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5016)];
					num = 3;
					continue;
				case 7:
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900)] = -1;
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4920), "");
					num = 47;
					if (!true)
					{
						goto IL_771;
					}
					continue;
				case 8:
				case 16:
					goto IL_4B3;
				case 9:
					goto IL_481;
				case 10:
					goto IL_3F4;
				case 11:
					goto IL_939;
				case 12:
					this.kvLgjp6DZb(true);
					goto IL_8DB;
				case 13:
					IL_22A:
					if (FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI)), 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)] != DBNull.Value)
					{
						num = 23;
						continue;
					}
					goto IL_968;
				case 14:
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5220)] = array2[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)];
					goto IL_FAB;
				case 15:
				{
					DataTable dataTable;
					if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable).Count <= 0)
					{
						goto IL_BE1;
					}
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5352)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataTable.Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(5380));
					if (dataTable.Rows[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900)] != DBNull.Value)
					{
						num = 34;
						continue;
					}
					goto IL_BE1;
				}
				case 17:
					goto IL_4BE;
				case 18:
					this.RBZI5gPOBE();
					FormJournalRequestForRepairAddEdit.WcgoprXUpy5heHmwvrn(this, null);
					switch (this.ffsghkQnr5)
					{
					case eActionRequestRepair.Add:
						if (this.ixYenVOtfo != null)
						{
							dataRow = FormJournalRequestForRepairAddEdit.IYu1wAXJcSSaZmFv72P(this.y7feOpIJtI.tJ_RequestForRepair);
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4866)] = 0;
							FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4876), FormJournalRequestForRepairAddEdit.fpu0vrXOM4IyU9rHHoe());
							this.MCuIKoXITX(DateTime.Now);
							FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900), this.ixYenVOtfo[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4900)]);
							dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4920)] = this.ixYenVOtfo[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4920)];
							num = 20;
							continue;
						}
						dataRow2 = FormJournalRequestForRepairAddEdit.IYu1wAXJcSSaZmFv72P(this.y7feOpIJtI.tJ_RequestForRepair);
						dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4866)] = 0;
						dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4876)] = DateTime.Now;
						this.MCuIKoXITX(DateTime.Now);
						num = 7;
						if (!true)
						{
							goto IL_6D0;
						}
						continue;
					case eActionRequestRepair.Edit:
						if (this.abEgNyD5Y6 <= 0)
						{
							goto IL_3F4;
						}
						base.SelectSqlData(this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI), true, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(5416), this.abEgNyD5Y6.ToString()));
						num = 33;
						if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							goto IL_37A;
						}
						continue;
					case eActionRequestRepair.Read:
						if (this.abEgNyD5Y6 > 0)
						{
							base.SelectSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepair, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5416) + this.abEgNyD5Y6.ToString());
							FormJournalRequestForRepairAddEdit.IbnHWbrWWsUIXRa2EJl(this, this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDaily, true, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5468), this.abEgNyD5Y6.ToString()));
							base.SelectSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDoc, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5468) + this.abEgNyD5Y6.ToString());
							num = 49;
							continue;
						}
						goto IL_3EE;
					default:
						num = 44;
						continue;
					}
					break;
				case 19:
					if (this.RqkgE4wFvG == 921)
					{
						FormJournalRequestForRepairAddEdit.zU9NPxrr63qbUZdCnml(this.BhgeS5qeIC, false);
					}
					this.YQrg2wn9R8();
					this.NXwgyoTTh8();
					num = 51;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_B23;
					}
					continue;
				case 20:
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)] = this.ixYenVOtfo[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)];
					if (this.yJieJApNRL != null)
					{
						num = 38;
						continue;
					}
					goto IL_C13;
				case 21:
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5016)] = false;
					goto IL_E4D;
				case 22:
					this.CMEI6rWu5X();
					this.nIKIOLEyLp();
					this.m5NI4ke5Cp();
					this.mBnIPFsbf5();
					num = 28;
					continue;
				case 23:
					this.Fvgeg8qmOA = Convert.ToBoolean(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair), 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)]);
					num = 31;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_1BF;
					}
					continue;
				case 24:
					goto IL_1BF;
				case 25:
					this.OcuJaJU1lF.Visible = false;
					goto IL_C6F;
				case 26:
					this.Dk1geQDtVl();
					this.DbfgPWaf8k();
					goto IL_3EE;
				case 27:
					FormJournalRequestForRepairAddEdit.DsontcXauIkkEcpw5iv(this.oyre5Btub4, 0);
					goto IL_A5F;
				case 28:
					IL_8F6:
					this.i0fIwb2bQC();
					num = 18;
					continue;
				case 29:
					if (array3.Length != 0)
					{
						FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5192), array3[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)]);
						dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5220)] = array3[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)];
						goto IL_51E;
					}
					goto IL_51E;
				case 30:
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5192), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array2[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)));
					num = 14;
					continue;
				case 31:
					goto IL_968;
				case 32:
					IL_C7F:
					if (this.cs3eIKVCEg)
					{
						dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136)] = true;
						goto IL_481;
					}
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136)] = false;
					num = 9;
					continue;
				case 33:
					if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair).Count > 0 && FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5444)) != DBNull.Value)
					{
						this.MCuIKoXITX(Convert.ToDateTime(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5444)]));
					}
					FormJournalRequestForRepairAddEdit.IbnHWbrWWsUIXRa2EJl(this, this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDaily, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5468) + this.abEgNyD5Y6.ToString());
					num = 46;
					if (!true)
					{
						goto IL_62F;
					}
					continue;
				case 34:
				{
					DataTable dataTable;
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5396)] = FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable)[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4900)];
					goto IL_BE1;
				}
				case 35:
					goto IL_C69;
				case 36:
					goto IL_D63;
				case 37:
					if (this.eVoe0Lldbr != null)
					{
						array4 = FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(this.eVoe0Lldbr, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4666), Convert.ToInt32(this.ixYenVOtfo[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5016)]).ToString()));
						num = 42;
						continue;
					}
					goto IL_3C2;
				case 38:
				{
					DataRow[] array = this.yJieJApNRL.Select(FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4538), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.ixYenVOtfo, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4948)).ToString()));
					if (array.Length != 0 && array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)] != DBNull.Value)
					{
						num = 0;
						continue;
					}
					goto IL_C13;
				}
				case 39:
				{
					DataTable dataTable;
					base.SelectSqlData(dataTable, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5290), null, false, 0);
					num = 15;
					continue;
				}
				case 40:
					goto IL_3F4;
				case 41:
					break;
				case 42:
					goto IL_37A;
				case 43:
					this.Q9Se39NXKE = Convert.ToInt32(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5510)]);
					num = 13;
					continue;
				case 44:
					goto IL_3F4;
				case 45:
					goto IL_B23;
				case 46:
					goto IL_DA4;
				case 47:
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)] = this.LEveRtAqeF;
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4980)] = "";
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4998)] = "";
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5038)] = this.PSpgGiFBsn();
					if (!this.PSpgGiFBsn())
					{
						dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5016)] = true;
						goto IL_E4D;
					}
					num = 21;
					if (!false)
					{
						continue;
					}
					break;
				case 48:
					goto IL_C13;
				case 49:
					FormJournalRequestForRepairAddEdit.IbnHWbrWWsUIXRa2EJl(this, this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.jVd3R4rLSNpv4WDN18y(this.y7feOpIJtI), true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5468) + this.abEgNyD5Y6.ToString());
					num = 26;
					continue;
				case 50:
					goto IL_6D0;
				case 51:
					return;
				default:
					num = 32;
					continue;
				}
				FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.TKdnD2UOSQ, false);
				num = 12;
				continue;
				IL_1BF:
				this.DbfgPWaf8k();
				num = 10;
				continue;
				IL_8DB:
				if (this.PSpgGiFBsn())
				{
					this.ncKgKECfGZ();
					num = 35;
					continue;
				}
				num = 25;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_8F6;
				}
				continue;
				IL_968:
				if (this.RqkgE4wFvG <= 0)
				{
					this.RqkgE4wFvG = Convert.ToInt32(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5542)]);
				}
				if (FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5566)] != DBNull.Value && FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(5566))))
				{
					FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.oyre5Btub4, false);
					num = 41;
					continue;
				}
				goto IL_8DB;
				IL_3F4:
				if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair).Count <= 0)
				{
					goto IL_8DB;
				}
				if (this.ffsghkQnr5 == eActionRequestRepair.Edit && FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5510)) != DBNull.Value)
				{
					num = 43;
					continue;
				}
				goto IL_22A;
				IL_A5F:
				if (this.aelevmJUSY.SelectedItem != null)
				{
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4920), this.aelevmJUSY.Text);
					num = 40;
					continue;
				}
				goto IL_3F4;
				IL_BE1:
				FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI)).Add(dataRow2);
				if (!this.PSpgGiFBsn())
				{
					FormJournalRequestForRepairAddEdit.DsontcXauIkkEcpw5iv(this.oyre5Btub4, 1);
					goto IL_A5F;
				}
				num = 27;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_C13;
				}
				continue;
				IL_65A:
				FormJournalRequestForRepairAddEdit.HwGAmXr3WG5y8RIbsRA(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI)), dataRow);
				goto IL_3F4;
				IL_FAB:
				if (this.FT8eucyj8s != null)
				{
					DataRow[] array5 = FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(this.FT8eucyj8s, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5156));
					if (array5.Length != 0)
					{
						dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5266)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array5[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(638));
					}
				}
				DataTable dataTable2 = this.dX2IfI82JW();
				base.SelectSqlData(dataTable2, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5290), null, false, 0);
				if (dataTable2.Rows.Count <= 0)
				{
					goto IL_65A;
				}
				dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5352)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataTable2.Rows[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5380));
				num = 11;
				if (false)
				{
					break;
				}
				continue;
				IL_D63:
				array2 = this.qwCeo7kn8p.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(5156));
				if (array2.Length == 0)
				{
					goto IL_FAB;
				}
				num = 30;
				if (!true)
				{
					goto IL_D8E;
				}
				continue;
				IL_4BE:
				goto IL_D63;
				IL_4B3:
				if (this.qwCeo7kn8p != null)
				{
					goto IL_4BE;
				}
				goto IL_FAB;
				IL_B23:
				dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5094)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.ixYenVOtfo, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5094));
				dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5118)] = false;
				if (this.cs3eIKVCEg)
				{
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136), true);
					goto IL_4B3;
				}
				dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136)] = false;
				FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
				num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 36 : 8);
				continue;
				IL_939:
				if (dataTable2.Rows[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900)] != DBNull.Value)
				{
					num = 1;
					continue;
				}
				goto IL_65A;
				IL_62F:
				FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5396), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable2)[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4900)));
				goto IL_65A;
				IL_3EE:
				this.LPwIVWtiSj();
				goto IL_3F4;
				IL_3C2:
				dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5078)] = false;
				num = 45;
				continue;
				IL_37A:
				if (array4.Length != 0 && FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array4[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)) != DBNull.Value)
				{
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5052), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array4[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(638)));
					goto IL_3C2;
				}
				goto IL_3C2;
				IL_481:
				if (this.qwCeo7kn8p == null)
				{
					goto IL_51E;
				}
				array3 = this.qwCeo7kn8p.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(5156));
				num = 29;
				if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					goto IL_4B3;
				}
				continue;
				IL_E4D:
				dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5078)] = false;
				dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5094)] = this.RqkgE4wFvG;
				dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5118)] = false;
				goto IL_C7F;
				IL_51E:
				if (this.FT8eucyj8s == null)
				{
					goto IL_ACF;
				}
				DataRow[] array6 = this.FT8eucyj8s.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(5156));
				if (array6.Length != 0)
				{
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5266)] = array6[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638)];
					num = 4;
					continue;
				}
				goto IL_ACF;
				IL_6D0:
				FormJournalRequestForRepairAddEdit.uhQcjkXpNb6vKcfplhI(this.jbcndg5xWg, false);
				this.hZDebgcu57.Value = DateTime.Now.Date.AddHours(8.0);
				FormJournalRequestForRepairAddEdit.K6cy3wXDMAngTN7rkUp(this.EMnejl09uS, FormJournalRequestForRepairAddEdit.fpu0vrXOM4IyU9rHHoe().Date.AddHours(17.0));
				num = 22;
				continue;
				IL_771:
				this.TD2gxXZG97();
				WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
				num = 50;
				continue;
				IL_C13:
				dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4980)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.ixYenVOtfo, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4980));
				dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4998)] = this.ixYenVOtfo[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4998)];
				num = 6;
				if (false)
				{
					goto IL_C69;
				}
				continue;
				IL_C6F:
				this.DcFISh12jf();
				num = 19;
				continue;
				IL_C69:
				this.CQhgQ5g7jf();
				goto IL_C6F;
				IL_D8E:
				this.BYPI1covQg();
				num = 2;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				IL_DA4:
				base.SelectSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDoc, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5468) + this.abEgNyD5Y6.ToString());
				base.SelectSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairAddress, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5468) + this.abEgNyD5Y6.ToString());
				this.Dk1geQDtVl();
				num = 24;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000DE08 File Offset: 0x0000C208
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void uCUI2Vw7df(object \u0020, FormClosingEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 11;
			for (;;)
			{
				IL_1D8:
				eActionRequestRepair eActionRequestRepair;
				switch (num)
				{
				case 0:
					break;
				case 1:
					goto IL_2CD;
				case 2:
					IL_18:
					FormJournalRequestForRepairAddEdit.RcZTRir7akLPgPuD9hT(this, this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDaily);
					base.DeleteSqlData(this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI));
					this.dGNg8PPlRb();
					num = 8;
					continue;
				case 3:
					while (eActionRequestRepair == eActionRequestRepair.Add)
					{
						this.y7feOpIJtI.tJ_RequestForRepair.Rows[0].EndEdit();
						FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							num = 6;
							if (false)
							{
								return;
							}
							goto IL_1D8;
						}
						else
						{
							num = 1;
							if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
								goto IL_1D8;
							}
						}
					}
					if (eActionRequestRepair == eActionRequestRepair.Edit)
					{
						FormJournalRequestForRepairAddEdit.YBxsONrTuyEDg9Cw8CA(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0]);
						base.UpdateSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepair);
					}
					break;
				case 4:
				case 6:
					this.abEgNyD5Y6 = base.InsertSqlDataOneRow(this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI));
					num = 0;
					continue;
				case 5:
					this.PQGId3fDKF();
					goto IL_2EA;
				case 7:
					goto IL_258;
				case 8:
					this.PJ9gLYJBAm();
					this.jUfg9utKNP();
					this.RFPgr9yT5T();
					num = 5;
					if (!true)
					{
						goto IL_28F;
					}
					continue;
				case 9:
					goto IL_2EA;
				case 10:
					goto IL_28F;
				case 11:
					if (FormJournalRequestForRepairAddEdit.DuDeHnrnW54ebHkIHYP(this) == DialogResult.OK)
					{
						num = 10;
						continue;
					}
					return;
				case 12:
					return;
				default:
					num = 2;
					continue;
				}
				using (IEnumerator<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH> enumerator = FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).GetEnumerator())
				{
					IL_191:
					while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
					{
						DataRow dataRow = enumerator.Current;
						int num2 = 5;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								break;
							case 1:
							case 2:
								if (dataRow.RowState == DataRowState.Deleted)
								{
									goto IL_191;
								}
								if (Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5656))) != this.abEgNyD5Y6)
								{
									goto IL_B7;
								}
								break;
							case 3:
								break;
							case 4:
								goto IL_B7;
							case 5:
								if (dataRow.RowState != DataRowState.Detached)
								{
									FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
									num2 = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 0 : 2);
									continue;
								}
								goto IL_191;
							case 6:
								goto IL_191;
							default:
								num2 = 4;
								if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
								{
									continue;
								}
								break;
							}
							IL_151:
							dataRow.EndEdit();
							num2 = 6;
							if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
								continue;
							}
							continue;
							IL_D2:
							goto IL_151;
							IL_B7:
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678)] = this.abEgNyD5Y6;
							goto IL_D2;
						}
					}
				}
				FormJournalRequestForRepairAddEdit.rtKkoCrl70VwRDQSvNT(this, this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDaily);
				goto IL_18;
				IL_28F:
				if (this.ffsghkQnr5 != eActionRequestRepair.Read && !this.BMbITyEH2N())
				{
					FormJournalRequestForRepairAddEdit.STnyjir2yIXpJ4vPTHx(cDhluYseFOthxgEIXpc.nKHKpgTSVU(5580), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5640), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					num = 7;
					continue;
				}
				eActionRequestRepair = this.ffsghkQnr5;
				num = 3;
				continue;
				IL_2CD:
				this.xaKgAPDTQB();
				this.e3ZgSZPFhN();
				num = 12;
				continue;
				IL_2EA:
				goto IL_2CD;
			}
			IL_258:
			\u0020.Cancel = true;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000E17C File Offset: 0x0000C57C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FYZIA61Cwp(object \u0020, FormClosedEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			base.SaveFormConfig(null);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000E194 File Offset: 0x0000C594
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LPwIVWtiSj()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			if (!true)
			{
				goto IL_1A;
			}
			for (;;)
			{
				IL_7C:
				switch (num)
				{
				case 0:
					this.BAKeTHcuNQ.Enabled = false;
					goto IL_10B;
				case 1:
					this.I4xetUTq0V.Enabled = false;
					num = 0;
					continue;
				case 2:
				case 3:
					FormJournalRequestForRepairAddEdit.uhQcjkXpNb6vKcfplhI(this.hZGeVyEfRI, true);
					this.Po7eAn9peo.ReadOnly = true;
					this.oyre5Btub4.Enabled = false;
					this.boNeyT9U7u.Enabled = false;
					this.HsZefiTdR1.ReadOnly = true;
					FormJournalRequestForRepairAddEdit.uhQcjkXpNb6vKcfplhI(this.G5GekMlON7, true);
					num = 7;
					continue;
				case 4:
					goto IL_10B;
				case 5:
					this.aelevmJUSY.Enabled = false;
					num = 6;
					continue;
				case 6:
					this.FZInULtqG4.Enabled = false;
					this.C99elfqXty.Enabled = false;
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 3;
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							continue;
						}
						continue;
					}
					else
					{
						num = 11;
						if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							continue;
						}
					}
					break;
				case 7:
					this.jbcndg5xWg.ReadOnly = true;
					this.rWoeDxUpjP.Enabled = false;
					num = 1;
					continue;
				case 8:
					goto IL_26;
				case 9:
					break;
				case 10:
					goto IL_1A;
				case 11:
					goto IL_D5;
				case 12:
					return;
				default:
					num = 4;
					continue;
				}
				this.z5knSIxS7w.Enabled = false;
				this.Dv1e6CuU3C.Visible = false;
				num = 12;
				continue;
				IL_10B:
				this.OcuJaJU1lF.Enabled = false;
				this.EQknHC0OS1.Enabled = (this.d7YnphvtQ1.Enabled = (this.H8tnxYcybE.Enabled = false));
				num = 10;
			}
			return;
			IL_1A:
			this.kl0niMXXMI.Enabled = false;
			IL_26:
			IL_D5:
			this.YQrg2wn9R8();
			this.jNxezOc8K1.Enabled = (this.g1HJnTrcyE.Enabled = false);
			FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.Doxna8ogZQ, false);
			num = 9;
			goto IL_7C;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000E3B0 File Offset: 0x0000C7B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MCuIKoXITX(DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 3:
					this.hZDebgcu57.MinDate = this.vclgz3ljku;
					goto IL_29;
				case 2:
					goto IL_29;
				case 4:
					goto IL_8A;
				case 5:
					this.vclgz3ljku = \u0020.AddDays(-1.0).Date;
					num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 4 : 3);
					continue;
				case 6:
					return;
				default:
					num = 0;
					if (!true)
					{
						return;
					}
					continue;
				}
				IL_6D:
				FormJournalRequestForRepairAddEdit.U67NVRrQwg4Va6cZoSs(this.I4xetUTq0V, this.vclgz3ljku);
				num = 6;
				if (!false)
				{
					continue;
				}
				IL_8A:
				FormJournalRequestForRepairAddEdit.U67NVRrQwg4Va6cZoSs(this.M5ZJs51OCB, this.vclgz3ljku);
				goto IL_6D;
				IL_29:
				goto IL_8A;
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000E498 File Offset: 0x0000C898
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void e8jIQGscGs(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000E4A8 File Offset: 0x0000C8A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DcFISh12jf()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			string text;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 2:
				{
					DataTable dataTable;
					dataTable.Columns.Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5730), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
					num = 8;
					continue;
				}
				case 1:
					goto IL_18;
				case 3:
					break;
				case 4:
					text = "";
					num = 5;
					continue;
				case 5:
					if (this.RqkgE4wFvG > 0)
					{
						DataTable dataTable = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5700));
						FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
						num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 9 : 0);
						continue;
					}
					break;
				case 6:
				{
					DataTable dataTable;
					if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(dataTable.Rows) > 0)
					{
						text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(5776) + FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable), 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5730)].ToString();
					}
					break;
				}
				case 7:
					goto IL_2E;
				case 8:
				{
					DataTable dataTable;
					base.SelectSqlData(dataTable, true, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5750), this.RqkgE4wFvG.ToString()), null, false, 0);
					num = 6;
					continue;
				}
				case 9:
					return;
				case 10:
					return;
				case 11:
					return;
				default:
					num = 3;
					continue;
				}
				switch (this.ffsghkQnr5)
				{
				case eActionRequestRepair.Add:
					goto IL_1DA;
				case eActionRequestRepair.Edit:
					if (this.PSpgGiFBsn())
					{
						num = 1;
						continue;
					}
					this.Text = FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(5956), text);
					num = 10;
					continue;
				case eActionRequestRepair.Read:
					if (this.PSpgGiFBsn())
					{
						goto Block_4;
					}
					this.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6056) + text;
					num = 11;
					continue;
				}
				return;
			}
			IL_18:
			this.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5890) + text;
			IL_2E:
			return;
			Block_4:
			this.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6002) + text;
			return;
			IL_1DA:
			if (this.PSpgGiFBsn())
			{
				FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(5782), text));
				return;
			}
			FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(5846), text));
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000E700 File Offset: 0x0000CB00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DataTable pIgIknuYR9()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 6;
			DataTable dataTable;
			for (;;)
			{
				DataColumn column;
				Type type;
				switch (num)
				{
				case 0:
				{
					DataColumn dataColumn;
					dataTable.Columns.Add(dataColumn);
					num = 9;
					continue;
				}
				case 1:
					column = new DataColumn(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6154), Type.GetType(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6164)));
					break;
				case 2:
				case 7:
				{
					DataColumn dataColumn2 = new DataColumn(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146), type);
					dataTable.Columns.Add(dataColumn2);
					num = 1;
					continue;
				}
				case 3:
				{
					DataColumn column2 = new DataColumn(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6194), type);
					dataTable.Columns.Add(column2);
					DataColumn dataColumn2;
					FormJournalRequestForRepairAddEdit.RRROGCrGOZ0IQ9RYp5C(dataTable, new DataColumn[]
					{
						dataColumn2
					});
					DataColumn dataColumn = new DataColumn(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6228), Type.GetType(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6164)));
					dataColumn.Expression = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6252);
					num = 0;
					continue;
				}
				case 5:
					dataTable = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6118));
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 8;
						continue;
					}
					num = 7;
					if (false)
					{
						goto IL_170;
					}
					continue;
				case 6:
					goto IL_170;
				case 9:
					return dataTable;
				}
				IL_18:
				dataTable.Columns.Add(column);
				num = 3;
				continue;
				IL_170:
				type = Type.GetType(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6090));
				num = 5;
				continue;
				goto IL_18;
			}
			return dataTable;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000E898 File Offset: 0x0000CC98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DataTable dX2IfI82JW()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 6;
			DataTable dataTable;
			for (;;)
			{
				DataColumn column;
				Type type;
				DataColumn dataColumn;
				switch (num)
				{
				case 0:
					column = new DataColumn(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512), Type.GetType(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6164)));
					break;
				case 1:
				case 3:
					dataTable = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6574));
					dataColumn = new DataColumn(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6588), type);
					goto IL_78;
				case 2:
					goto IL_78;
				case 4:
					break;
				case 5:
					goto IL_ED;
				case 6:
					goto IL_31;
				case 7:
					dataTable.PrimaryKey = new DataColumn[]
					{
						dataColumn
					};
					num = 8;
					continue;
				case 8:
					return dataTable;
				default:
					num = 4;
					continue;
				}
				dataTable.Columns.Add(column);
				num = 7;
				if (!false)
				{
					continue;
				}
				IL_31:
				type = Type.GetType(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6090));
				num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 5 : 3);
				continue;
				IL_ED:
				dataTable.Columns.Add(dataColumn);
				DataColumn column2 = new DataColumn(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900), type);
				FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable).Add(column2);
				num = 0;
				continue;
				IL_78:
				goto IL_ED;
			}
			return dataTable;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000E9E0 File Offset: 0x0000CDE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CMEI6rWu5X()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 15;
			for (;;)
			{
				DataTable dataTable;
				DataTable dataTable2;
				DataTable dataTable3;
				switch (num)
				{
				case 0:
					FormJournalRequestForRepairAddEdit.DM0SefXAU37XccbaJW5(this.C99elfqXty, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6900));
					num = 9;
					if (false)
					{
						goto IL_186;
					}
					continue;
				case 1:
				case 16:
					base.SelectSqlData(dataTable, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6604), null, false, 0);
					this.lfWeHeTrZJ.DataSource = dataTable;
					num = 12;
					if (!false)
					{
						continue;
					}
					break;
				case 2:
					this.aelevmJUSY.DisplayMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6890);
					FormJournalRequestForRepairAddEdit.DM0SefXAU37XccbaJW5(this.aelevmJUSY, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6900));
					num = 10;
					continue;
				case 3:
					goto IL_F1;
				case 4:
					FormJournalRequestForRepairAddEdit.TxMbiyX8UhL1cbJeFy2(this.aelevmJUSY, dataTable2);
					num = 2;
					continue;
				case 5:
					goto IL_4A7;
				case 6:
					goto IL_112;
				case 7:
					dataTable2 = this.pIgIknuYR9();
					base.SelectSqlData(dataTable2, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(6666), null, false, 0);
					num = 4;
					continue;
				case 8:
					goto IL_441;
				case 9:
					this.C99elfqXty.SelectedIndex = -1;
					dataTable3 = new DataTable();
					FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable3).Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512), Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777225)));
					FormJournalRequestForRepairAddEdit.uOQuZmXi3rjBekKWKMt(FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable3), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4524), FormJournalRequestForRepairAddEdit.fubmvOX9d6a46jiTIfX(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777220)));
					break;
				case 10:
					goto IL_3BA;
				case 11:
					goto IL_211;
				case 12:
					this.lfWeHeTrZJ.DisplayMember = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6638);
					this.lfWeHeTrZJ.ValueMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6650);
					num = 7;
					continue;
				case 13:
					break;
				case 14:
					break;
				case 15:
					goto IL_186;
				case 17:
				{
					DataTable dataTable4 = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5700));
					FormJournalRequestForRepairAddEdit.uOQuZmXi3rjBekKWKMt(dataTable4.Columns, cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
					FormJournalRequestForRepairAddEdit.uOQuZmXi3rjBekKWKMt(FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable4), cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
					base.SelectSqlData(dataTable4, true, FormJournalRequestForRepairAddEdit.KatxDcr49et30cDMVlE(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(7398), 1402, 1401), null, false, 0);
					this.OcuJaJU1lF.DisplayMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512);
					this.OcuJaJU1lF.ValueMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146);
					this.OcuJaJU1lF.DataSource = dataTable4;
					FormJournalRequestForRepairAddEdit.DsontcXauIkkEcpw5iv(this.OcuJaJU1lF, -1);
					num = 18;
					if (!true)
					{
						goto IL_3BA;
					}
					continue;
				}
				case 18:
					return;
				default:
					num = 8;
					continue;
				}
				IL_4F:
				FormJournalRequestForRepairAddEdit.TxMbiyX8UhL1cbJeFy2(this.oyre5Btub4, dataTable3);
				FormJournalRequestForRepairAddEdit.m7yrknXSnVbhabeAIHm(this.oyre5Btub4, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512));
				this.oyre5Btub4.ValueMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(4524);
				if (this.PSpgGiFBsn())
				{
					FormJournalRequestForRepairAddEdit.dUcAiAXvZn2liatlk4a(dataTable3.Rows, new object[]
					{
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(7338),
						false
					});
					goto IL_4A7;
				}
				dataTable3.Rows.Add(new object[]
				{
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(7360),
					false
				});
				num = 5;
				if (false)
				{
					goto IL_F1;
				}
				continue;
				goto IL_4F;
				IL_F1:
				FormJournalRequestForRepairAddEdit.DM0SefXAU37XccbaJW5(this.BAKeTHcuNQ, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6900));
				num = 11;
				if (!false)
				{
					continue;
				}
				IL_112:
				FormJournalRequestForRepairAddEdit.m7yrknXSnVbhabeAIHm(this.C99elfqXty, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512));
				num = 0;
				continue;
				IL_186:
				dataTable = this.dX2IfI82JW();
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					num = 16;
					continue;
				}
				num = 14;
				if (false)
				{
					goto IL_211;
				}
				continue;
				IL_3BA:
				FormJournalRequestForRepairAddEdit.TxMbiyX8UhL1cbJeFy2(this.FZInULtqG4, dataTable2);
				FormJournalRequestForRepairAddEdit.m7yrknXSnVbhabeAIHm(this.FZInULtqG4, cDhluYseFOthxgEIXpc.nKHKpgTSVU(6890));
				this.FZInULtqG4.ValueMember = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6900);
				DataTable dataTable5 = this.pIgIknuYR9();
				base.SelectSqlData(dataTable5, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(6908), null, false, 0);
				FormJournalRequestForRepairAddEdit.TxMbiyX8UhL1cbJeFy2(this.BAKeTHcuNQ, dataTable5);
				this.BAKeTHcuNQ.DisplayMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6890);
				num = 3;
				continue;
				IL_441:
				this.C99elfqXty.DataSource = this.y7feOpIJtI.tR_Classifier;
				num = 6;
				continue;
				IL_211:
				FormJournalRequestForRepairAddEdit.IbnHWbrWWsUIXRa2EJl(this, this.y7feOpIJtI, this.y7feOpIJtI.tR_Classifier, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(7170));
				goto IL_441;
				IL_4A7:
				FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable3).Add(new object[]
				{
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(7378),
					true
				});
				num = 17;
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000EEC8 File Offset: 0x0000D2C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool BMbITyEH2N()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			bool result;
			for (;;)
			{
				switch (num)
				{
				case 0:
					result = false;
					goto IL_40E;
				case 1:
					goto IL_375;
				case 2:
					goto IL_D1;
				case 3:
				case 15:
					goto IL_A2;
				case 4:
					if (this.OcuJaJU1lF.SelectedIndex < 0)
					{
						result = false;
						num = 18;
						continue;
					}
					return result;
				case 5:
					result = true;
					num = 8;
					if (!true)
					{
						return result;
					}
					continue;
				case 6:
					goto IL_35A;
				case 7:
					result = false;
					num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 9 : 15);
					continue;
				case 8:
					if (!string.IsNullOrEmpty(FormJournalRequestForRepairAddEdit.MppBsmrtGcT0TclkiX2(this.FZInULtqG4)))
					{
						goto IL_A2;
					}
					FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.KYLe4Tbd80, FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe());
					num = 7;
					if (false)
					{
						goto IL_35A;
					}
					continue;
				case 9:
					goto IL_199;
				case 10:
					this.Hrwe9GBchc.ForeColor = FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe();
					result = false;
					break;
				case 11:
					if (this.EQknHC0OS1.SelectedIndex < 0)
					{
						this.xL1nFot21u.ForeColor = FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe();
						result = true;
					}
					if (FormJournalRequestForRepairAddEdit.C28iarrwX4jJba1k5If(this.d7YnphvtQ1) < 0)
					{
						this.nv7nWxKZai.ForeColor = FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe();
						result = true;
						num = 16;
						continue;
					}
					goto IL_30E;
				case 12:
					goto IL_71;
				case 13:
					FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.b2vnyhrNSS, Color.Red);
					result = true;
					goto IL_2A;
				case 14:
					goto IL_2A;
				case 16:
					goto IL_30E;
				case 17:
					goto IL_1D7;
				case 18:
					return result;
				default:
					num = 6;
					continue;
				}
				IL_4C:
				if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Rows) <= 0)
				{
					num = 17;
					continue;
				}
				goto IL_16D;
				IL_71:
				if (FormJournalRequestForRepairAddEdit.frGxQ1rVyhal7bXRk7u(this.hZGeVyEfRI.Text))
				{
					this.d6UeKsT72M.ForeColor = Color.Red;
					result = false;
					num = 1;
					continue;
				}
				goto IL_375;
				IL_A2:
				if (FormJournalRequestForRepairAddEdit.C28iarrwX4jJba1k5If(this.C99elfqXty) >= 0)
				{
					goto IL_71;
				}
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.N4DeBMM4KD, Color.Red);
				result = false;
				num = 12;
				if (!true)
				{
					goto Block_5;
				}
				continue;
				IL_16D:
				if (!this.rWoeDxUpjP.Checked || this.RqkgE4wFvG != 920)
				{
					break;
				}
				num = 11;
				if (!true)
				{
					goto IL_199;
				}
				continue;
				Block_5:
				IEnumerator enumerator;
				List<Color> list;
				int num2;
				try
				{
					IL_D1:
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						((Control)obj2).ForeColor = list[num2];
						FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
						int num3;
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							num3 = 2;
							if (false)
							{
								goto IL_109;
							}
						}
						else
						{
							num3 = 3;
						}
						switch (num3)
						{
						case 0:
						case 2:
							IL_109:
							num2++;
							break;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(disposable);
					}
				}
				result = false;
				goto IL_16D;
				IL_199:
				if (this.kl0niMXXMI.SelectedIndex < 0)
				{
					FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.kuRnYPi50V, Color.Red);
					result = false;
				}
				if (!this.PSpgGiFBsn())
				{
					break;
				}
				num = 4;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_1D7;
				}
				continue;
				IL_30E:
				if (this.H8tnxYcybE.SelectedIndex < 0)
				{
					num = 13;
					continue;
				}
				IL_2A:
				goto IL_199;
				IL_35A:
				enumerator = FormJournalRequestForRepairAddEdit.Slq1V5rbU4kx6lNu6SI(this.boNeyT9U7u.Controls);
				num = 2;
				continue;
				IL_1D7:
				list = new List<Color>();
				using (IEnumerator enumerator = FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.boNeyT9U7u).GetEnumerator())
				{
					while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
					{
						Control control = (Control)enumerator.Current;
						FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
						int num4;
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							num4 = 2;
							if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
							}
						}
						else
						{
							num4 = 3;
						}
						switch (num4)
						{
						case 0:
						case 2:
							list.Add(FormJournalRequestForRepairAddEdit.hsSivLrdZGHr9HkqyLW(control));
							break;
						}
					}
				}
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.boNeyT9U7u, Color.Red);
				num2 = 0;
				goto IL_35A;
				IL_375:
				if (string.IsNullOrEmpty(this.Po7eAn9peo.Text))
				{
					this.PTle2wlpsd.ForeColor = FormJournalRequestForRepairAddEdit.Bmkc9fXCvfteQfwx2Qe();
					num = 0;
					continue;
				}
				IL_40E:
				if (this.oyre5Btub4.SelectedIndex >= 0)
				{
					goto IL_4C;
				}
				num = 10;
			}
			return result;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000F348 File Offset: 0x0000D748
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PQGId3fDKF()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 3;
			for (;;)
			{
				IL_D5B:
				switch (num)
				{
				case 0:
					return;
				case 1:
				case 2:
					return;
				case 3:
					while (!this.q5CeeA3ux5)
					{
						FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
						if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							num = 2;
							if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								return;
							}
							goto IL_D5B;
						}
						else
						{
							num = 4;
							if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
								goto IL_D5B;
							}
						}
					}
					if (!this.PSpgGiFBsn())
					{
						num = 0;
						continue;
					}
					if (this.abEgNyD5Y6 == -1)
					{
						return;
					}
					if (!FormJournalRequestForRepairAddEdit.mekat0rFbrDhOBwKbxe(this.rWoeDxUpjP))
					{
						return;
					}
					base.SelectSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepair, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5416) + this.abEgNyD5Y6.ToString());
					if (this.y7feOpIJtI.tJ_RequestForRepair.Rows.Count <= 0)
					{
						return;
					}
					if (this.y7feOpIJtI.tJ_RequestForRepair.Rows[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(7448)] == DBNull.Value)
					{
						num = 6;
						continue;
					}
					goto IL_CED;
				case 4:
					break;
				case 5:
					break;
				case 6:
					try
					{
						RequestsServiceSoapClient requestsServiceSoapClient = new RequestsServiceSoapClient();
						Request request = new Request();
						if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI))[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4866)] != DBNull.Value)
						{
							request.Number = FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair), 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4866)].ToString();
						}
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(4980)) != DBNull.Value)
						{
							request.AddressDisableText = this.y7feOpIJtI.tJ_RequestForRepair.Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4980)].ToString();
						}
						using (SqlConnection sqlConnection = new SqlConnection(FormJournalRequestForRepairAddEdit.MYEP83XkI141am7o5YR(this).GetConnectionString()))
						{
							sqlConnection.Open();
							DbDataAdapter dbDataAdapter = new SqlDataAdapter(FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(7462), this.abEgNyD5Y6.ToString()), sqlConnection);
							DataTable dataTable = new DataTable();
							dbDataAdapter.Fill(dataTable);
							int num2 = 0;
							for (;;)
							{
								int num3;
								DataRow dataRow;
								switch (num2)
								{
								case 0:
									request.AddressHousesDidable = new AddressObjects[dataTable.Rows.Count];
									num3 = 0;
									FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
									num2 = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 6 : 8);
									continue;
								case 1:
								case 8:
									goto IL_5F1;
								case 2:
									goto IL_3D8;
								case 3:
									IL_5A8:
									if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8042)) != DBNull.Value)
									{
										request.AddressHousesDidable[num3].House = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8042)].ToString();
										num2 = 5;
										continue;
									}
									goto IL_598;
								default:
									goto IL_432;
								case 5:
									goto IL_598;
								case 6:
									goto IL_4BF;
								case 7:
									if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(7970)) != DBNull.Value)
									{
										request.AddressHousesDidable[num3].City = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(7970)].ToString();
										num2 = 2;
										continue;
									}
									goto IL_3D8;
								case 9:
									goto IL_5F1;
								}
								IL_4E3:
								if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8002)) != DBNull.Value)
								{
									FormJournalRequestForRepairAddEdit.w6QKF6rP8NjGgwv8fGy(request)[num3].Street = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8002)].ToString();
								}
								if (dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8018)] != DBNull.Value)
								{
									FormJournalRequestForRepairAddEdit.ibvtMprmsn7Do8a6Sij(request.AddressHousesDidable[num3], FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8018)).ToString());
									num2 = 3;
									continue;
								}
								goto IL_5A8;
								IL_4BF:
								request.AddressHousesDidable[num3].CityType = dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(7982)].ToString();
								goto IL_4E3;
								IL_432:
								goto IL_4BF;
								IL_3D8:
								if (dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(7982)] != DBNull.Value)
								{
									goto IL_432;
								}
								goto IL_4E3;
								IL_5F1:
								if (num3 >= FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(dataTable)))
								{
									break;
								}
								dataRow = FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(dataTable.Rows, num3);
								request.AddressHousesDidable[num3] = new AddressObjects();
								num2 = 7;
								continue;
								IL_598:
								num3++;
								num2 = 9;
							}
						}
						base.SelectSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDaily, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5468) + this.abEgNyD5Y6.ToString());
						FormJournalRequestForRepairAddEdit.aDlgBTrg74utY4yLvSb(request, new DateBeginEndList[FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Rows)]);
						for (int i = 0; i < FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepairDaily).Count; i++)
						{
							DataRow dataRow2 = FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI))[i];
							FormJournalRequestForRepairAddEdit.zmwy51rRfAHZYgIlosu(request)[i] = new DateBeginEndList();
							if (dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056)] != DBNull.Value)
							{
								request.DateBeginEnd[i].DateBegin = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056)));
								if (i == 0)
								{
									request.DateBegin = FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056)]);
								}
							}
							if (dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8074)] != DBNull.Value)
							{
								FormJournalRequestForRepairAddEdit.zmwy51rRfAHZYgIlosu(request)[i].DateEnd = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8074)));
								if (i == FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepairDaily)) - 1)
								{
									request.DatePlan = new DateTime?(Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8074))));
									request.DateEnd = new DateTime?(Convert.ToDateTime(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8074)]));
								}
							}
						}
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(5052)) != DBNull.Value)
						{
							FormJournalRequestForRepairAddEdit.HMimyDr9B8qsAAwciGZ(request, (long)FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5052)]));
						}
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(8092)) != DBNull.Value)
						{
							FormJournalRequestForRepairAddEdit.B0gc11rix2s4VIQVDyg(request, FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair), 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8092)].ToString());
						}
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows, 0), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8110)) != DBNull.Value)
						{
							FormJournalRequestForRepairAddEdit.rQ4EysreqtKTj8OgCGA(request, Convert.ToInt32(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(8110)]));
						}
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(8138)) != DBNull.Value)
						{
							request.RefRequestStatusId = (long)Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(8138)));
						}
						if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(8154)] != DBNull.Value)
						{
							request.PerformerOrganizationId = FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8154)));
						}
						if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(5266)] != DBNull.Value)
						{
							request.RefGroupWorksId = (long)Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(5266)));
						}
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(4960)) != DBNull.Value)
						{
							request.RefRegionId = (long)Convert.ToInt32(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows, 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4960)]);
						}
						Response response = requestsServiceSoapClient.SendReq(request);
						if (FormJournalRequestForRepairAddEdit.qed3nBrMGvgZN0lq8CA(response) > 0L)
						{
							FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair), 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8200)] = response.RequestId;
							FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI))[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(8214)] = true;
							FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows, 0).EndEdit();
							base.UpdateSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepair);
						}
						else
						{
							if (FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8230)] == DBNull.Value)
							{
								FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(8230), FormJournalRequestForRepairAddEdit.LpVk5Fr5dNoJnTPYPMU(response));
							}
							else
							{
								FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(8230)] = FormJournalRequestForRepairAddEdit.LpVk5Fr5dNoJnTPYPMU(response) + cDhluYseFOthxgEIXpc.nKHKpgTSVU(8254) + FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair), 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(8230)).ToString();
							}
							if (FormJournalRequestForRepairAddEdit.FawFPdrvw3qGMyilf6m(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI)), 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8230)].ToString()) > 1024)
							{
								FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI))[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(8230)] = this.y7feOpIJtI.tJ_RequestForRepair.Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8230)].ToString().Substring(0, 1024);
							}
							FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows, 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(8214), false);
							FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0].EndEdit();
							base.UpdateSqlData(this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI));
							MessageBox.Show(response.Message, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8264), MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						return;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
						return;
					}
					goto IL_CED;
				case 7:
					IL_1A2:
					if (this.Q9Se39NXKE == Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair), 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(5510))))
					{
						return;
					}
					break;
				case 8:
					goto IL_58;
				case 9:
					goto IL_DA8;
				default:
					num = 7;
					continue;
				}
				IL_18:
				if (FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows, 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5510)]) != 164277)
				{
					goto IL_164;
				}
				num = 8;
				if (!true)
				{
					goto Block_3;
				}
				continue;
				goto IL_18;
				IL_CED:
				if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(5510)) == DBNull.Value)
				{
					return;
				}
				int num4 = Convert.ToInt32(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI))[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(7448)]);
				goto IL_1A2;
				IL_164:
				if (FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair), 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5510)]) == 164280)
				{
					num = 9;
					continue;
				}
				return;
				Block_3:
				try
				{
					IL_58:
					object obj2 = new RequestsServiceSoapClient();
					DateTime dateEnd = DateTime.Now;
					if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8300)) != DBNull.Value)
					{
						dateEnd = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8300)]);
					}
					Response response2 = FormJournalRequestForRepairAddEdit.QoLjesrCq8tiv4ddkXe(obj2, (long)num4, dateEnd);
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					int num5;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num5 = 3;
						goto IL_105;
					}
					num5 = 2;
					if (true)
					{
						goto IL_105;
					}
					IL_E7:
					if (FormJournalRequestForRepairAddEdit.BNuvvor0isMcH63sRIF(response2) != 0)
					{
						goto IL_11A;
					}
					goto IL_144;
					IL_105:
					switch (num5)
					{
					case 0:
					case 2:
						goto IL_E7;
					}
					IL_11A:
					FormJournalRequestForRepairAddEdit.STnyjir2yIXpJ4vPTHx(FormJournalRequestForRepairAddEdit.LpVk5Fr5dNoJnTPYPMU(response2), cDhluYseFOthxgEIXpc.nKHKpgTSVU(8264), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					IL_144:;
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message, ex2.Source);
				}
				goto IL_164;
			}
			return;
			try
			{
				IL_DA8:
				int num4;
				Response response3 = new RequestsServiceSoapClient().RequestCancel((long)num4);
				FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
				int num6;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					num6 = 2;
					if (!false)
					{
						goto IL_DF1;
					}
				}
				else
				{
					num6 = 3;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_E1C;
					}
					goto IL_DF1;
				}
				IL_DD3:
				if (response3.Code != 0)
				{
					goto IL_E06;
				}
				goto IL_E36;
				IL_DF1:
				switch (num6)
				{
				case 0:
				case 2:
					goto IL_DD3;
				}
				IL_E06:
				IL_E1C:
				MessageBox.Show(response3.Message, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8264), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				IL_E36:;
			}
			catch (Exception ex3)
			{
				MessageBox.Show(FormJournalRequestForRepairAddEdit.VIhy5SXRaCAk0LBkYLo(ex3), FormJournalRequestForRepairAddEdit.uvR5uRrxXOx7fWxYma8(ex3));
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00010210 File Offset: 0x0000E610
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cGQIU7Llfn(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.vBCeYf5BJy.Enabled = this.hKaeG4RCUy.Checked;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00010238 File Offset: 0x0000E638
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void gvsIt7q2yI(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.EMnejl09uS.MinDate = this.hZDebgcu57.Value.AddMinutes(1.0);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001027C File Offset: 0x0000E67C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void T0oIDJBCH9(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.WcSC45rhJMaXgDJy79s(this.hZDebgcu57, this.EMnejl09uS.Value.AddMinutes(-1.0));
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000102C0 File Offset: 0x0000E6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void niWIcl59ha()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				goto IL_1E;
			}
			DateTime dateTime;
			for (;;)
			{
				IL_DC:
				switch (num)
				{
				case 0:
					goto IL_1E;
				case 1:
				case 2:
					try
					{
						DataRow dataRow = this.y7feOpIJtI.tJ_RequestForRepairDaily.Where(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH o)
						{
							while (false)
							{
								object obj2 = null[0];
							}
							return o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached;
						}).OrderBy(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH a)
						{
							while (false)
							{
								object obj2 = null[0];
							}
							return a[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8326)];
						}).First<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH>();
						FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
						int num2 = (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 2;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							case 2:
								goto IL_21B;
							case 4:
								goto IL_25C;
							}
							IL_1F5:
							if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8326)] == DBNull.Value)
							{
								goto IL_272;
							}
							num2 = 4;
							if (!true)
							{
								goto IL_21B;
							}
							continue;
							IL_24C:
							goto IL_1F5;
							IL_21B:
							if (dataRow != null)
							{
								goto IL_24C;
							}
							goto IL_272;
						}
						IL_25C:
						dateTime = FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8326)]);
						IL_272:;
					}
					catch
					{
					}
					goto IL_27D;
				case 3:
					IL_2C7:
					goto IL_51;
				case 4:
					break;
				case 5:
					goto IL_10F;
				case 6:
					goto IL_51;
				case 7:
					if (this.y7feOpIJtI.tJ_RequestForRepairDaily.Where(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH o)
					{
						while (false)
						{
							object obj2 = null[0];
						}
						return o.RowState != DataRowState.Deleted && FormJournalRequestForRepairAddEdit.<>c.LpULlYGYFKT7eQRKfoM(o) != DataRowState.Detached;
					}).Count<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH>() <= 0)
					{
						goto IL_27D;
					}
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 1;
						continue;
					}
					num = 6;
					if (!true)
					{
						return;
					}
					continue;
				case 8:
					return;
				default:
					num = 4;
					continue;
				}
				IL_2E:
				DateTime dateTime2 = dateTime2.AddDays(-1.0);
				dateTime = dateTime2.Date;
				num = 5;
				continue;
				IL_51:
				DateTime dateTime3 = dateTime;
				dateTime2 = Convert.ToDateTime(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(5444)]);
				dateTime2 = dateTime2.AddDays(-1.0);
				if (FormJournalRequestForRepairAddEdit.IgbWXAroXagPOKDlV88(dateTime3, dateTime2.Date))
				{
					dateTime2 = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5444)));
					goto IL_2E;
				}
				goto IL_10F;
				IL_27D:
				if (FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows.Count > 0 && FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5444)] != DBNull.Value)
				{
					goto IL_2C7;
				}
				IL_10F:
				this.M5ZJs51OCB.MinDate = dateTime;
				num = 8;
			}
			return;
			IL_1E:
			dateTime = DateTimePicker.MinimumDateTime;
			num = 7;
			goto IL_DC;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000105B8 File Offset: 0x0000E9B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void uWMIpSGpQA(object \u0020, DataGridViewRowsAddedEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 3;
			for (;;)
			{
				DataRow dataRow;
				switch (num)
				{
				case 0:
					break;
				case 1:
					goto IL_157;
				case 2:
				case 5:
					goto IL_81;
				case 3:
					dataRow = FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Where(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH o)
					{
						while (false)
						{
							object obj2 = null[0];
						}
						return FormJournalRequestForRepairAddEdit.<>c.LpULlYGYFKT7eQRKfoM(o) != DataRowState.Deleted && FormJournalRequestForRepairAddEdit.<>c.LpULlYGYFKT7eQRKfoM(o) != DataRowState.Detached;
					}).OrderByDescending(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH a)
					{
						while (false)
						{
							object obj2 = null[0];
						}
						return a.dateEnd;
					}).First<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH>();
					num = 6;
					continue;
				case 4:
					break;
				case 6:
					if (!FormJournalRequestForRepairAddEdit.CQSShrruhUd2qgtSQFw(Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(280))), FormJournalRequestForRepairAddEdit.ScT6TvrYLKmUQi3bFvv(this.hZDebgcu57)))
					{
						goto IL_81;
					}
					FormJournalRequestForRepairAddEdit.WcSC45rhJMaXgDJy79s(this.hZDebgcu57, FormJournalRequestForRepairAddEdit.becu7jraaDLMZ6fOT8i());
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 5;
						continue;
					}
					num = 0;
					if (!true)
					{
						return;
					}
					continue;
				case 7:
					return;
				default:
					num = 1;
					continue;
				}
				IL_132:
				this.SvJIWFXWaY(Convert.ToDateTime(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(280)]));
				num = 7;
				continue;
				IL_15D:
				goto IL_132;
				IL_157:
				this.niWIcl59ha();
				goto IL_15D;
				IL_81:
				this.hZDebgcu57.MinDate = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(280)));
				goto IL_157;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00010734 File Offset: 0x0000EB34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SvJIWFXWaY(DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			if (!true)
			{
				goto IL_1A;
			}
			for (;;)
			{
				IL_117:
				switch (num)
				{
				case 0:
					if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair).Count <= 0)
					{
						return;
					}
					num = 1;
					if (false)
					{
						goto IL_A2;
					}
					continue;
				case 1:
					goto IL_A2;
				case 2:
					if (FormJournalRequestForRepairAddEdit.ttGPFkr8vhdSJ4UrlOh(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(8300), DataRowVersion.Original) == DBNull.Value)
					{
						goto IL_1A;
					}
					break;
				case 3:
				case 6:
					goto IL_46;
				case 4:
					goto IL_6B;
				case 5:
					goto IL_1A;
				case 7:
					return;
				}
				goto IL_13C;
				IL_A2:
				if (FormJournalRequestForRepairAddEdit.qPZSylrqd5J6dH9pUiM(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0), DataRowVersion.Original))
				{
					num = 2;
					continue;
				}
				goto IL_46;
				IL_13C:
				num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 5 : 6);
			}
			IL_1A:
			if (this.PSpgGiFBsn())
			{
				return;
			}
			FormJournalRequestForRepairAddEdit.Age8e7rBwnUnrkBdeKK(this.M5ZJs51OCB, \u0020);
			num = 7;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
				goto IL_117;
			}
			IL_46:
			if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair)[0].HasVersion(DataRowVersion.Original))
			{
				return;
			}
			IL_6B:
			goto IL_1A;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00010894 File Offset: 0x0000EC94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void mkpIHd63xX(object \u0020, DataGridViewRowsRemovedEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
			int num = (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 2 : 1;
			DataRow dataRow;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 1:
					this.niWIcl59ha();
					num = 3;
					continue;
				case 2:
					return;
				case 3:
					if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Rows) <= 0)
					{
						FormJournalRequestForRepairAddEdit.U67NVRrQwg4Va6cZoSs(this.hZDebgcu57, this.vclgz3ljku);
						this.SvJIWFXWaY(this.vclgz3ljku);
						num = 8;
						continue;
					}
					if (this.y7feOpIJtI.tJ_RequestForRepairDaily.Where(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH o)
					{
						while (false)
						{
							object obj2 = null[0];
						}
						return o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached;
					}).Count<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH>() <= 0)
					{
						FormJournalRequestForRepairAddEdit.U67NVRrQwg4Va6cZoSs(this.hZDebgcu57, this.vclgz3ljku);
						this.SvJIWFXWaY(this.vclgz3ljku);
						num = 5;
						continue;
					}
					dataRow = this.y7feOpIJtI.tJ_RequestForRepairDaily.Where(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH o)
					{
						while (false)
						{
							object obj2 = null[0];
						}
						return o.RowState != DataRowState.Deleted && FormJournalRequestForRepairAddEdit.<>c.LpULlYGYFKT7eQRKfoM(o) != DataRowState.Detached;
					}).OrderByDescending(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH a)
					{
						while (false)
						{
							object obj2 = null[0];
						}
						return FormJournalRequestForRepairAddEdit.<>c.MxxEZCGunU7PRnHkotO(a);
					}).First<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH>();
					num = 7;
					if (true)
					{
						continue;
					}
					break;
				default:
					return;
				case 5:
					return;
				case 6:
					goto IL_14D;
				case 7:
					break;
				case 8:
					return;
				}
				this.hZDebgcu57.MinDate = FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(280)]);
				num = 6;
			}
			return;
			IL_14D:
			this.SvJIWFXWaY(Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(280))));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00010A7C File Offset: 0x0000EE7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void B5SIFY0JS6(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 1:
					if (\u0020.RowIndex == FormJournalRequestForRepairAddEdit.QlT8uKrymoMveu6rFJm(this.dSOeiWZtIs.Rows) - 1)
					{
						goto IL_EA;
					}
					return;
				case 2:
					goto IL_EA;
				case 3:
					goto IL_18;
				case 4:
					this.niWIcl59ha();
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 0);
					continue;
				case 5:
					goto IL_B0;
				case 6:
					break;
				case 7:
					return;
				default:
					num = 6;
					continue;
				}
				IL_96:
				this.hZDebgcu57.MaxDate = DateTimePicker.MaximumDateTime;
				num = 5;
				continue;
				IL_18:
				DateTime dateTime = FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(this.dSOeiWZtIs[FormJournalRequestForRepairAddEdit.jMnvLQr6txx4yanbSIv(this.akXnTaWPea), \u0020.RowIndex].Value);
				if (FormJournalRequestForRepairAddEdit.CQSShrruhUd2qgtSQFw(dateTime, this.hZDebgcu57.MaxDate))
				{
					goto IL_96;
				}
				goto IL_B0;
				IL_EA:
				goto IL_18;
				IL_B0:
				this.hZDebgcu57.MinDate = dateTime;
				this.SvJIWFXWaY(dateTime);
				num = 7;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00010BA4 File Offset: 0x0000EFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void x1jIx63cPC(object \u0020, DataGridViewEditingControlShowingEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 4:
					if (!(FormJournalRequestForRepairAddEdit.uFuPAKrNaMfUKtFPrYn(\u0020) is DateTimePicker))
					{
						return;
					}
					break;
				case 1:
					break;
				case 2:
					FormJournalRequestForRepairAddEdit.WcSC45rhJMaXgDJy79s(FormJournalRequestForRepairAddEdit.uFuPAKrNaMfUKtFPrYn(\u0020) as DateTimePicker, new DateTime(9998, 12, 31));
					goto IL_1AE;
				case 3:
					break;
				case 5:
					goto IL_1DF;
				case 6:
					FormJournalRequestForRepairAddEdit.U67NVRrQwg4Va6cZoSs(\u0020.Control as DateTimePicker, this.vclgz3ljku);
					num = 8;
					continue;
				case 7:
					goto IL_280;
				case 8:
					goto IL_44;
				case 9:
					return;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				}
				IL_E7:
				if (!FormJournalRequestForRepairAddEdit.swDRINrScYotCiT6g64(this.dSOeiWZtIs.CurrentCell.OwningColumn.Name, FormJournalRequestForRepairAddEdit.jMnvLQr6txx4yanbSIv(this.hLln6SFMH0)))
				{
					goto IL_1DF;
				}
				FormJournalRequestForRepairAddEdit.WcSC45rhJMaXgDJy79s(\u0020.Control as DateTimePicker, FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(FormJournalRequestForRepairAddEdit.Q1PIoVrArSunLIIFWj5(this.dSOeiWZtIs[this.akXnTaWPea.Name, this.dSOeiWZtIs.CurrentCell.RowIndex])));
				if (this.dSOeiWZtIs.CurrentCell.RowIndex == 0)
				{
					num = 6;
					continue;
				}
				goto IL_44;
				goto IL_E7;
				IL_1AE:
				if (FormJournalRequestForRepairAddEdit.dTHbEFrsbdIkhABdnJl(this.dSOeiWZtIs.CurrentCell) < FormJournalRequestForRepairAddEdit.JX3SuJrOcPWWARk8t3H(this.dSOeiWZtIs).Count - 1)
				{
					num = 7;
					continue;
				}
				break;
				IL_1DF:
				if (!FormJournalRequestForRepairAddEdit.swDRINrScYotCiT6g64(FormJournalRequestForRepairAddEdit.gRV8qvrfUn5Oso6JqbJ(this.dSOeiWZtIs).OwningColumn.Name, this.akXnTaWPea.Name))
				{
					break;
				}
				(\u0020.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dSOeiWZtIs[this.hLln6SFMH0.Name, this.dSOeiWZtIs.CurrentCell.RowIndex].Value);
				if (FormJournalRequestForRepairAddEdit.dTHbEFrsbdIkhABdnJl(this.dSOeiWZtIs.CurrentCell) != FormJournalRequestForRepairAddEdit.QlT8uKrymoMveu6rFJm(FormJournalRequestForRepairAddEdit.JX3SuJrOcPWWARk8t3H(this.dSOeiWZtIs)) - 1)
				{
					goto IL_1AE;
				}
				num = 2;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_280;
				}
				continue;
				IL_44:
				if (FormJournalRequestForRepairAddEdit.dTHbEFrsbdIkhABdnJl(this.dSOeiWZtIs.CurrentCell) > 0)
				{
					(FormJournalRequestForRepairAddEdit.uFuPAKrNaMfUKtFPrYn(\u0020) as DateTimePicker).MinDate = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.LPqkmJrpJ50YZWs9xTD(this.dSOeiWZtIs, this.akXnTaWPea.Name, FormJournalRequestForRepairAddEdit.dTHbEFrsbdIkhABdnJl(FormJournalRequestForRepairAddEdit.gRV8qvrfUn5Oso6JqbJ(this.dSOeiWZtIs)) - 1).Value);
					goto IL_1DF;
				}
				goto IL_1DF;
				IL_280:
				(FormJournalRequestForRepairAddEdit.uFuPAKrNaMfUKtFPrYn(\u0020) as DateTimePicker).MaxDate = FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(FormJournalRequestForRepairAddEdit.Q1PIoVrArSunLIIFWj5(this.dSOeiWZtIs[this.hLln6SFMH0.Name, FormJournalRequestForRepairAddEdit.dTHbEFrsbdIkhABdnJl(this.dSOeiWZtIs.CurrentCell) + 1]));
				num = 9;
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00010E80 File Offset: 0x0000F280
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void snaIyqTYvW(object \u0020, DataGridViewCellFormattingEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 3;
			for (;;)
			{
				DayOfWeek dayOfWeek;
				switch (num)
				{
				case 0:
					goto IL_6C;
				case 1:
					goto IL_176;
				case 2:
				case 5:
					goto IL_1D9;
				case 3:
					if (\u0020.RowIndex < 0)
					{
						return;
					}
					num = 0;
					if (!true)
					{
						goto IL_176;
					}
					continue;
				case 4:
				{
					DateTime dateTime = FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(this.dSOeiWZtIs[this.akXnTaWPea.Name, \u0020.RowIndex].Value);
					num = 9;
					if (false)
					{
						goto IL_1D9;
					}
					continue;
				}
				case 6:
					break;
				case 7:
					break;
				case 8:
					if (dayOfWeek != DayOfWeek.Saturday)
					{
						return;
					}
					break;
				case 9:
				{
					DateTime dateTime;
					dayOfWeek = dateTime.DayOfWeek;
					goto IL_D7;
				}
				case 10:
					return;
				default:
					IL_148:
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 2;
						continue;
					}
					num = 6;
					if (!true)
					{
						goto IL_6C;
					}
					continue;
				}
				IL_18:
				if (FormJournalRequestForRepairAddEdit.UpLWb8rJ9vt2W5ln9p4(FormJournalRequestForRepairAddEdit.qWWP2arZ7RpmanieB4V(this.dSOeiWZtIs), \u0020.ColumnIndex) == this.akXnTaWPea)
				{
					FormJournalRequestForRepairAddEdit.OJ3elcrc91u1XlplrZW(FormJournalRequestForRepairAddEdit.mt1XnRrIfyoSxoHvvpL(\u0020), Color.Red);
					num = 10;
					continue;
				}
				break;
				goto IL_18;
				IL_D7:
				DayOfWeek dayOfWeek2;
				if ((dayOfWeek2 == DayOfWeek.Sunday || dayOfWeek2 == DayOfWeek.Saturday) && FormJournalRequestForRepairAddEdit.UpLWb8rJ9vt2W5ln9p4(this.dSOeiWZtIs.Columns, FormJournalRequestForRepairAddEdit.tA5vpRrUnjN7FsTjiP2(\u0020)) == this.hLln6SFMH0)
				{
					goto IL_148;
				}
				goto IL_1E9;
				IL_176:
				if (FormJournalRequestForRepairAddEdit.LPqkmJrpJ50YZWs9xTD(this.dSOeiWZtIs, this.akXnTaWPea.Name, FormJournalRequestForRepairAddEdit.vbGaKGrDmvoAZn682Tj(\u0020)).Value != null)
				{
					num = 4;
					continue;
				}
				goto IL_D7;
				IL_6C:
				dayOfWeek2 = DayOfWeek.Monday;
				if (FormJournalRequestForRepairAddEdit.Q1PIoVrArSunLIIFWj5(this.dSOeiWZtIs[this.hLln6SFMH0.Name, FormJournalRequestForRepairAddEdit.vbGaKGrDmvoAZn682Tj(\u0020)]) != null)
				{
					DateTime dateTime = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.Q1PIoVrArSunLIIFWj5(FormJournalRequestForRepairAddEdit.LPqkmJrpJ50YZWs9xTD(this.dSOeiWZtIs, this.hLln6SFMH0.Name, FormJournalRequestForRepairAddEdit.vbGaKGrDmvoAZn682Tj(\u0020))));
					dayOfWeek2 = dateTime.DayOfWeek;
				}
				dayOfWeek = DayOfWeek.Monday;
				num = 1;
				continue;
				IL_1E9:
				if (dayOfWeek != DayOfWeek.Sunday)
				{
					num = 8;
					continue;
				}
				goto IL_18;
				IL_1D9:
				FormJournalRequestForRepairAddEdit.mt1XnRrIfyoSxoHvvpL(\u0020).ForeColor = Color.Red;
				goto IL_1E9;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00011088 File Offset: 0x0000F488
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void x2qIrJvtsH(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 9;
			if (!true)
			{
				goto IL_1A;
			}
			DateTime dateTime;
			int num2;
			for (;;)
			{
				IL_33D:
				switch (num)
				{
				case 0:
				{
					bool flag;
					if (!flag)
					{
						return;
					}
					DataRow dataRow = FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Where(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH o)
					{
						while (false)
						{
							object obj2 = null[0];
						}
						return FormJournalRequestForRepairAddEdit.<>c.LpULlYGYFKT7eQRKfoM(o) != DataRowState.Deleted && o.RowState != DataRowState.Detached;
					}).OrderByDescending(delegate(E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH a)
					{
						while (false)
						{
							object obj2 = null[0];
						}
						return FormJournalRequestForRepairAddEdit.<>c.MxxEZCGunU7PRnHkotO(a);
					}).First<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH>();
					num = 10;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_4CF;
					}
					continue;
				}
				case 1:
					goto IL_4CF;
				case 2:
				case 6:
					goto IL_380;
				case 3:
					break;
				case 4:
					goto IL_3EA;
				case 5:
					goto IL_1A;
				case 7:
					dateTime = this.hZDebgcu57.Value;
					dateTime = dateTime.AddDays((double)num2);
					if (dateTime.DayOfWeek != DayOfWeek.Saturday)
					{
						goto IL_3EA;
					}
					goto IL_327;
				case 8:
					goto IL_1AC;
				case 9:
				{
					bool flag = false;
					num = 3;
					continue;
				}
				case 10:
				{
					DataRow dataRow;
					if (FormJournalRequestForRepairAddEdit.CQSShrruhUd2qgtSQFw(Convert.ToDateTime(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(280)]), FormJournalRequestForRepairAddEdit.ScT6TvrYLKmUQi3bFvv(this.hZDebgcu57)))
					{
						FormJournalRequestForRepairAddEdit.WcSC45rhJMaXgDJy79s(this.hZDebgcu57, this.DVHeZEqiiZ);
					}
					this.hZDebgcu57.MinDate = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(280)));
					num = 11;
					if (false)
					{
						return;
					}
					continue;
				}
				case 11:
				{
					this.niWIcl59ha();
					DataRow dataRow;
					this.SvJIWFXWaY(Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(280))));
					num = 12;
					if (!false)
					{
						continue;
					}
					break;
				}
				case 12:
					return;
				default:
					num = 5;
					continue;
				}
				FormJournalRequestForRepairAddEdit.yuJjNUrz5Yko5YH2CyJ(this.dSOeiWZtIs, new DataGridViewRowsAddedEventHandler(this.uWMIpSGpQA));
				FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
				num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 1 : 6);
				continue;
				IL_4CF:
				dateTime = FormJournalRequestForRepairAddEdit.qKAZiEn308C8j8yXGj4(this.hZDebgcu57);
				dateTime = dateTime.AddDays((double)num2);
				num = 8;
				continue;
				IL_3EA:
				goto IL_4CF;
			}
			IL_1AC:
			if (dateTime.DayOfWeek != DayOfWeek.Sunday)
			{
				goto IL_1B8;
			}
			goto IL_327;
			IL_380:
			if (FormJournalRequestForRepairAddEdit.mekat0rFbrDhOBwKbxe(this.hKaeG4RCUy))
			{
				num2 = 0;
				goto IL_1A;
			}
			try
			{
				DataRow dataRow2 = this.y7feOpIJtI.tJ_RequestForRepairDaily.NewRow();
				FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
				int num3;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					num3 = 5;
					if (!true)
					{
						goto IL_78;
					}
				}
				else
				{
					num3 = 4;
					if (!true)
					{
						goto IL_A1;
					}
				}
				for (;;)
				{
					IL_107:
					switch (num3)
					{
					case 0:
					case 5:
						dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5678)] = this.abEgNyD5Y6;
						num3 = 1;
						break;
					case 1:
						goto IL_B3;
					case 2:
						goto IL_78;
					case 3:
						goto IL_8F;
					case 4:
						goto IL_A1;
					case 6:
						goto IL_158;
					default:
						num3 = 2;
						break;
					}
				}
				IL_158:
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.boNeyT9U7u, FormJournalRequestForRepairAddEdit.boZdSGnWwbPWvD83nRP());
				goto IL_18B;
				IL_78:
				FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Rows.Add(dataRow2);
				IL_8F:
				IL_A1:
				bool flag = true;
				num3 = 6;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_107;
				}
				IL_B3:
				FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8056), this.hZDebgcu57.Value);
				dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8074)] = FormJournalRequestForRepairAddEdit.qKAZiEn308C8j8yXGj4(this.EMnejl09uS);
				goto IL_78;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, FormJournalRequestForRepairAddEdit.uvR5uRrxXOx7fWxYma8(ex), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			goto IL_18B;
			IL_1A:
			if (num2 <= (FormJournalRequestForRepairAddEdit.qKAZiEn308C8j8yXGj4(this.EMnejl09uS) - this.hZDebgcu57.Value).Days)
			{
				if (FormJournalRequestForRepairAddEdit.mekat0rFbrDhOBwKbxe(this.vBCeYf5BJy))
				{
					goto IL_1B8;
				}
				num = 7;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
				}
				goto IL_33D;
			}
			IL_18B:
			FormJournalRequestForRepairAddEdit.SNXSXHnLFBNLXi86TqJ(this.dSOeiWZtIs, new DataGridViewRowsAddedEventHandler(this.uWMIpSGpQA));
			num = 0;
			goto IL_33D;
			IL_1B8:
			try
			{
				DataRow dataRow3 = FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).NewRow();
				int num4 = 5;
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_1D4;
					case 1:
					case 2:
						this.y7feOpIJtI.tJ_RequestForRepairDaily.Rows.Add(dataRow3);
						goto IL_1F6;
					case 3:
						goto IL_1F6;
					case 4:
					{
						DataRow dataRow4 = dataRow3;
						string columnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(8074);
						dateTime = this.hZDebgcu57.Value;
						dateTime = dateTime.AddDays((double)num2);
						DateTime date = dateTime.Date;
						dateTime = this.EMnejl09uS.Value;
						dataRow4[columnName] = date + dateTime.TimeOfDay;
						break;
					}
					case 5:
						goto IL_20C;
					case 6:
						goto IL_2F4;
					}
					goto IL_2D8;
					IL_1D4:
					bool flag = true;
					num4 = 6;
					continue;
					IL_1F6:
					goto IL_1D4;
					IL_2D8:
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num4 = 1;
						if (false)
						{
							break;
						}
						continue;
					}
					else
					{
						num4 = 0;
						if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							continue;
						}
					}
					IL_20C:
					dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678)] = this.abEgNyD5Y6;
					DataRow dataRow5 = dataRow3;
					string columnName2 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056);
					dateTime = this.hZDebgcu57.Value;
					dataRow5[columnName2] = dateTime.AddDays((double)num2);
					num4 = 4;
				}
				IL_2F4:
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.boNeyT9U7u, SystemColors.ControlText);
			}
			catch (Exception ex2)
			{
				MessageBox.Show(FormJournalRequestForRepairAddEdit.VIhy5SXRaCAk0LBkYLo(ex2), FormJournalRequestForRepairAddEdit.uvR5uRrxXOx7fWxYma8(ex2), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			IL_327:
			num2++;
			goto IL_1A;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00011624 File Offset: 0x0000FA24
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void fysIiODTLs(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.oyre5Btub4.SelectedIndex >= 0)
			{
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.Hrwe9GBchc, SystemColors.ControlText);
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00011658 File Offset: 0x0000FA58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void slBIY4gJjs(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.aelevmJUSY.SelectedIndex >= 0)
			{
				this.hnQeNIZkPu.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001168C File Offset: 0x0000FA8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rjAIGmyMd1(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (!string.IsNullOrEmpty(this.FZInULtqG4.Text))
			{
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.KYLe4Tbd80, FormJournalRequestForRepairAddEdit.boZdSGnWwbPWvD83nRP());
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000116C4 File Offset: 0x0000FAC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void YUnIjlccXu(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.C99elfqXty.SelectedIndex >= 0)
			{
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.N4DeBMM4KD, SystemColors.ControlText);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000116F8 File Offset: 0x0000FAF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void gygIbKOPTU(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (!string.IsNullOrEmpty(FormJournalRequestForRepairAddEdit.MppBsmrtGcT0TclkiX2(this.hZGeVyEfRI)))
			{
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.d6UeKsT72M, SystemColors.ControlText);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00011730 File Offset: 0x0000FB30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void v4sINLtf5q(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (!string.IsNullOrEmpty(FormJournalRequestForRepairAddEdit.MppBsmrtGcT0TclkiX2(this.Po7eAn9peo)))
			{
				this.PTle2wlpsd.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00011768 File Offset: 0x0000FB68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void U7uIERJrdt(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.kl0niMXXMI.SelectedIndex >= 0)
			{
				this.kuRnYPi50V.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001179C File Offset: 0x0000FB9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void eUIIhaxvel(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.EQknHC0OS1.SelectedIndex >= 0)
			{
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.xL1nFot21u, SystemColors.ControlText);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000117D0 File Offset: 0x0000FBD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tOnIz7ycX5(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.d7YnphvtQ1.SelectedIndex >= 0)
			{
				this.nv7nWxKZai.ForeColor = SystemColors.ControlText;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00011804 File Offset: 0x0000FC04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EA2gZiikTe(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.H8tnxYcybE.SelectedIndex >= 0)
			{
				FormJournalRequestForRepairAddEdit.uVukwJXsHXCQDVe479C(this.b2vnyhrNSS, SystemColors.ControlText);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00011838 File Offset: 0x0000FC38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void uZvg3PHGhU(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.FZInULtqG4.SelectedIndex >= 0)
			{
				this.KYLe4Tbd80.ForeColor = FormJournalRequestForRepairAddEdit.boZdSGnWwbPWvD83nRP();
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001186C File Offset: 0x0000FC6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void C8kgIRdW0Q()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 6;
			for (;;)
			{
				DateTime dateTime;
				DateTime dateTime2;
				DataRow dataRow4;
				switch (num)
				{
				case 0:
				{
					List<string> list;
					try
					{
						IEnumerator enumerator;
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							DataRow dataRow = (DataRow)obj2;
							int num2;
							bool flag;
							if (num2 == (int)Convert.ToInt16(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4866))))
							{
								list.Add(base.CallSQLScalarFunction(cDhluYseFOthxgEIXpc.nKHKpgTSVU(8354), new string[]
								{
									FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)).ToString()
								}).ToString());
							}
							else
							{
								string text;
								if (FormJournalRequestForRepairAddEdit.e2c0xGn2iL2MpARwXSw(list) > 0)
								{
									FormJournalRequestForRepairAddEdit.yLwbP7nT4VLikYhA6hP(list);
									DataRow dataRow2 = FormJournalRequestForRepairAddEdit.IYu1wAXJcSSaZmFv72P(FormJournalRequestForRepairAddEdit.h9W8PinHl7Lh7uAWB7R(this.k16n0HORUW.Tables, this.Glkno10FRw.TableName));
									FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440), "");
									using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
									{
										IL_4C7:
										while (enumerator2.MoveNext())
										{
											string arg = enumerator2.Current;
											int num3 = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 3 : 2;
											for (;;)
											{
												DataRow dataRow3;
												switch (num3)
												{
												case 0:
												case 2:
													dataRow3 = dataRow2;
													break;
												case 4:
													goto IL_4C7;
												}
												IL_48A:
												dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440)] = dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440)] + arg + FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8458);
												num3 = 4;
												continue;
												goto IL_48A;
											}
										}
									}
									FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8440), ((string)dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440)]).Remove(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440)].ToString().Length - 1));
									FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8326), dateTime);
									dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(280)] = dateTime2;
									FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8464), text);
									FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8484), flag);
									FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8344), num2);
									FormJournalRequestForRepairAddEdit.HwGAmXr3WG5y8RIbsRA(FormJournalRequestForRepairAddEdit.CEpLXMnl8CcEQkaX6OP(this.k16n0HORUW)[this.Glkno10FRw.TableName].Rows, dataRow2);
								}
								list = new List<string>();
								list.Add(base.CallSQLScalarFunction(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8354), new string[]
								{
									dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8418)].ToString()
								}).ToString());
								dateTime = Convert.ToDateTime(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8326)]);
								dateTime2 = Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(280)));
								text = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8464)).ToString();
								num2 = (int)Convert.ToInt16(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8344)]);
								flag = false;
							}
							if (!flag)
							{
								flag = this.ptUggyTDS7(Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418))));
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					if (FormJournalRequestForRepairAddEdit.e2c0xGn2iL2MpARwXSw(list) <= 0)
					{
						goto IL_2FE;
					}
					list.Sort();
					num = 2;
					if (false)
					{
						return;
					}
					continue;
				}
				case 1:
				{
					string text;
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow4, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8464), text);
					bool flag;
					dataRow4[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8484)] = flag;
					num = 8;
					continue;
				}
				case 2:
				{
					dataRow4 = this.k16n0HORUW.Tables[this.Glkno10FRw.TableName].NewRow();
					dataRow4[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8440)] = "";
					List<string> list;
					using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
					{
						IL_14F:
						while (enumerator2.MoveNext())
						{
							string arg2 = enumerator2.Current;
							int num4;
							if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								num4 = 2;
							}
							else
							{
								num4 = 3;
								if (false)
								{
									continue;
								}
							}
							for (;;)
							{
								DataRow dataRow3;
								switch (num4)
								{
								case 0:
								case 2:
									dataRow3 = dataRow4;
									break;
								case 4:
									goto IL_14F;
								}
								IL_D1:
								dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440)] = dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440)] + arg2 + FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8458);
								num4 = 4;
								continue;
								goto IL_D1;
							}
						}
					}
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow4, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440), ((string)dataRow4[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440)]).Remove(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow4, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440)).ToString().Length - 1));
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 7 : 9);
					continue;
				}
				case 3:
				{
					if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.PkFuMSnjRjtVa9aAl9k(this.y7feOpIJtI).Rows) <= 0)
					{
						return;
					}
					object obj3 = FormJournalRequestForRepairAddEdit.ojdQAfnXSpDIFp1jkHp(this.y7feOpIJtI.tL_RequestForRepairSchmObjList);
					FormJournalRequestForRepairAddEdit.KPmG77nrGceFmmMq9q9(obj3, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8344));
					DataTable dataTable = FormJournalRequestForRepairAddEdit.i1BQeknnCSfnbHIQ7fu(obj3);
					int num2 = 0;
					bool flag = false;
					List<string> list = new List<string>();
					dateTime = FormJournalRequestForRepairAddEdit.fpu0vrXOM4IyU9rHHoe();
					dateTime2 = DateTime.Now;
					string text = "";
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					num = 0;
					if (!true)
					{
						goto IL_247;
					}
					continue;
				}
				case 4:
				case 9:
					goto IL_247;
				case 6:
					IL_352:
					this.Glkno10FRw.Clear();
					num = 3;
					continue;
				case 8:
				{
					int num2;
					dataRow4[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8344)] = num2;
					num = 10;
					continue;
				}
				case 10:
					FormJournalRequestForRepairAddEdit.HwGAmXr3WG5y8RIbsRA(this.k16n0HORUW.Tables[this.Glkno10FRw.TableName].Rows, dataRow4);
					goto IL_2FE;
				case 11:
					return;
				}
				IL_2B5:
				dataRow4[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(280)] = dateTime2;
				num = 1;
				continue;
				IL_2A5:
				goto IL_2B5;
				IL_247:
				dataRow4[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8326)] = dateTime;
				goto IL_2A5;
				IL_2FE:
				if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(this.k16n0HORUW.Tables[FormJournalRequestForRepairAddEdit.HPgiG2n7nvyb1VVU8Jg(this.Glkno10FRw)].Rows) > 0)
				{
					break;
				}
				this.CeanIEi3ht.Enabled = false;
				num = 11;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_352;
				}
			}
			this.CeanIEi3ht.Enabled = true;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00011F98 File Offset: 0x00010398
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ptUggyTDS7(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return this.abEgNyD5Y6 != -1 && new SqlDataCommand(FormJournalRequestForRepairAddEdit.MYEP83XkI141am7o5YR(this)).SelectSqlData(string.Format(cDhluYseFOthxgEIXpc.nKHKpgTSVU(8504), this.abEgNyD5Y6, \u0020)).Rows.Count > 0;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00012004 File Offset: 0x00010404
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Dk1geQDtVl()
		{
			while (false)
			{
				object obj = null[0];
			}
			base.SelectSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tL_RequestForRepairSchmObjList, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5468) + this.abEgNyD5Y6.ToString());
			this.C8kgIRdW0Q();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00012058 File Offset: 0x00010458
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void YQlgnIUWiF(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				goto IL_1E;
			}
			tdgsyJb7kYIvCkPsM1 tdgsyJb7kYIvCkPsM;
			int num2;
			for (;;)
			{
				IL_69:
				switch (num)
				{
				case 0:
					goto IL_1E;
				case 1:
				case 3:
					tdgsyJb7kYIvCkPsM.SqlSettings = FormJournalRequestForRepairAddEdit.MYEP83XkI141am7o5YR(this);
					num = 2;
					break;
				case 2:
					if (tdgsyJb7kYIvCkPsM.ShowDialog() != DialogResult.OK)
					{
						return;
					}
					num2 = 1;
					num = 4;
					break;
				case 4:
					goto IL_3C;
				case 5:
					goto IL_2CC;
				case 6:
					goto IL_2E2;
				case 7:
					goto IL_CA;
				case 8:
					return;
				default:
					num = 7;
					break;
				}
			}
			return;
			IL_1E:
			tdgsyJb7kYIvCkPsM = new tdgsyJb7kYIvCkPsM1();
			if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				num = 3;
				if (!false)
				{
					goto IL_69;
				}
			}
			else
			{
				num = 6;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_2E2;
				}
				goto IL_69;
			}
			IL_3C:
			if (this.y7feOpIJtI.tL_RequestForRepairSchmObjList.Rows.Count <= 0)
			{
				goto IL_126;
			}
			IL_CA:
			num2 = (int)(this.y7feOpIJtI.tL_RequestForRepairSchmObjList.Where(delegate(E1YGNRmqUpG01b1DWc.HdrwQSvpZhDcM6kbie r)
			{
				while (false)
				{
					object obj2 = null[0];
				}
				return FormJournalRequestForRepairAddEdit.<>c.LpULlYGYFKT7eQRKfoM(r) != DataRowState.Deleted;
			}).Max(delegate(E1YGNRmqUpG01b1DWc.HdrwQSvpZhDcM6kbie x)
			{
				while (false)
				{
					object obj2 = null[0];
				}
				return x.Num;
			}) + 1);
			IL_126:
			this.MXUe8Spw0O = tdgsyJb7kYIvCkPsM.EcpJEUIp5e();
			using (Dictionary<int, string>.KeyCollection.Enumerator enumerator = this.MXUe8Spw0O.Keys.GetEnumerator())
			{
				IL_2A7:
				while (enumerator.MoveNext())
				{
					int num3 = enumerator.Current;
					int num4 = 2;
					for (;;)
					{
						DataRow dataRow;
						switch (num4)
						{
						case 0:
						case 1:
							FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678), this.abEgNyD5Y6);
							num4 = 3;
							if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								goto IL_27F;
							}
							continue;
						case 2:
							goto IL_27F;
						case 3:
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)] = num3;
							goto IL_1DD;
						case 4:
							break;
						case 5:
							break;
						case 6:
							goto IL_1DD;
						case 7:
							goto IL_2A7;
						default:
							num4 = 6;
							if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
								continue;
							}
							continue;
						}
						IL_1BC:
						FormJournalRequestForRepairAddEdit.HwGAmXr3WG5y8RIbsRA(FormJournalRequestForRepairAddEdit.PkFuMSnjRjtVa9aAl9k(this.y7feOpIJtI).Rows, dataRow);
						num4 = 7;
						continue;
						IL_243:
						goto IL_1BC;
						IL_1DD:
						dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(9988)] = FormJournalRequestForRepairAddEdit.BGXVhAnQkFR66jT7qAm(tdgsyJb7kYIvCkPsM);
						FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10006), FormJournalRequestForRepairAddEdit.tPABLUn1S1I1QyVuwl4(tdgsyJb7kYIvCkPsM));
						dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10024)] = tdgsyJb7kYIvCkPsM.Duration;
						dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4866)] = num2;
						goto IL_243;
						IL_27F:
						dataRow = FormJournalRequestForRepairAddEdit.IYu1wAXJcSSaZmFv72P(this.y7feOpIJtI.tL_RequestForRepairSchmObjList);
						num4 = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 5 : 0);
					}
				}
			}
			this.C8kgIRdW0Q();
			IL_2CC:
			IL_2E2:
			this.Ktcg4fYAMu(this.MXUe8Spw0O.Keys.ToList<int>());
			num = 8;
			goto IL_69;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00012384 File Offset: 0x00010784
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tEVgJQTTOb(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.GJHgoSLdep(\u0020, \u0020);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001239C File Offset: 0x0001079C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ocxg039VNk(object \u0020, DataGridViewCellFormattingEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 2 : 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 4:
					if (\u0020.RowIndex < 0)
					{
						return;
					}
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					goto IL_BE;
				case 5:
					if (FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(FormJournalRequestForRepairAddEdit.LPqkmJrpJ50YZWs9xTD(this.wULnq8UnPx, this.RI9Jlhlmpg.Name, \u0020.RowIndex).Value))
					{
						goto IL_BE;
					}
					return;
				case 6:
					return;
				default:
					num = 3;
					continue;
				}
				IL_40:
				if (\u0020.ColumnIndex >= 0)
				{
					num = 5;
					continue;
				}
				break;
				goto IL_40;
				IL_BE:
				\u0020.CellStyle.BackColor = FormJournalRequestForRepairAddEdit.kGCZLVnGeYAIqMbXFV8();
				num = 6;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00012484 File Offset: 0x00010884
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GJHgoSLdep(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 6;
			for (;;)
			{
				IL_13B:
				DataRow dataRow2;
				tdgsyJb7kYIvCkPsM1 tdgsyJb7kYIvCkPsM;
				DataRow[] array2;
				int num2;
				switch (num)
				{
				case 0:
				{
					DataRow dataRow;
					this.MXUe8Spw0O.Add(Convert.ToInt32(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)]), FormJournalRequestForRepairAddEdit.zMJPD0nbqJRijccwvUK(this, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8354), new string[]
					{
						FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)).ToString()
					}).ToString());
					num = 5;
					continue;
				}
				case 1:
				{
					FormJournalRequestForRepairAddEdit.B4Zqe3nVViaEmXvpKjQ(this.MXUe8Spw0O);
					DataRow[] array;
					if (array.Length != 0)
					{
						num = 4;
						continue;
					}
					return;
				}
				case 2:
					while (this.MXUe8Spw0O.ContainsKey(FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)))))
					{
						dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(9988)] = tdgsyJb7kYIvCkPsM.DateBeg;
						FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10006), FormJournalRequestForRepairAddEdit.tPABLUn1S1I1QyVuwl4(tdgsyJb7kYIvCkPsM));
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							num = 13;
							goto IL_13B;
						}
						num = 14;
						if (!false)
						{
							goto IL_13B;
						}
					}
					dataRow2.Delete();
					num = 7;
					continue;
				case 3:
					return;
				case 4:
				{
					tdgsyJb7kYIvCkPsM = new tdgsyJb7kYIvCkPsM1();
					tdgsyJb7kYIvCkPsM.SqlSettings = this.SqlSettings;
					DataRow[] array;
					FormJournalRequestForRepairAddEdit.LjO8B0nkakRL0v2n3BT(tdgsyJb7kYIvCkPsM, Convert.ToDateTime(array[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8056)]));
					tdgsyJb7kYIvCkPsM.DateEnd = FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(8074)));
					FormJournalRequestForRepairAddEdit.oAEbP4ndNPS73yslGdn(tdgsyJb7kYIvCkPsM, FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8464)).ToString());
					tdgsyJb7kYIvCkPsM.Num = Convert.ToInt16(array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(8344)]);
					array2 = array;
					num2 = 0;
					num = 12;
					continue;
				}
				case 5:
					goto IL_104;
				case 6:
				{
					if (FormJournalRequestForRepairAddEdit.BiXsaQn4QrlU4LVgK7l(this.wULnq8UnPx) == null)
					{
						num = 15;
						continue;
					}
					if (Convert.ToBoolean(FormJournalRequestForRepairAddEdit.Q1PIoVrArSunLIIFWj5(FormJournalRequestForRepairAddEdit.fjV8kyntjFErdR0ewD6(this.wULnq8UnPx.CurrentRow)[FormJournalRequestForRepairAddEdit.jMnvLQr6txx4yanbSIv(this.RI9Jlhlmpg)])))
					{
						MessageBox.Show(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10044), cDhluYseFOthxgEIXpc.nKHKpgTSVU(10194), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						num = 3;
						continue;
					}
					DataRow[] array = FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(this.y7feOpIJtI.tL_RequestForRepairSchmObjList, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10226) + FormJournalRequestForRepairAddEdit.W3LhBRnwjswHXoE8JHc(this.wULnq8UnPx.CurrentRow.Cells, this.AZMJB5EVm8.Name).Value.ToString());
					num = 1;
					continue;
				}
				case 7:
					goto IL_424;
				case 8:
					break;
				case 9:
				{
					IL_DE:
					this.MXUe8Spw0O = tdgsyJb7kYIvCkPsM.EcpJEUIp5e();
					DataRow[] array;
					array2 = array;
					num2 = 0;
					break;
				}
				case 10:
				case 13:
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10024)] = tdgsyJb7kYIvCkPsM.Duration;
					this.MXUe8Spw0O.Remove(Convert.ToInt32(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)]));
					goto IL_1DB;
				case 11:
					goto IL_1DB;
				case 12:
					goto IL_108;
				case 14:
					goto IL_40E;
				case 15:
					return;
				case 16:
					return;
				default:
					num = 9;
					continue;
				}
				if (num2 >= array2.Length)
				{
					using (Dictionary<int, string>.KeyCollection.Enumerator enumerator = this.MXUe8Spw0O.Keys.GetEnumerator())
					{
						IL_3DF:
						while (enumerator.MoveNext())
						{
							int num3 = enumerator.Current;
							int num4 = 5;
							for (;;)
							{
								DataRow dataRow3;
								switch (num4)
								{
								case 0:
									goto IL_2E5;
								case 1:
								case 4:
									FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678), this.abEgNyD5Y6);
									goto IL_35A;
								case 2:
									goto IL_35A;
								case 3:
									FormJournalRequestForRepairAddEdit.PkFuMSnjRjtVa9aAl9k(this.y7feOpIJtI).Rows.Add(dataRow3);
									num4 = 7;
									if (!false)
									{
										continue;
									}
									break;
								case 5:
									break;
								case 6:
									goto IL_36A;
								case 7:
									goto IL_3DF;
								default:
									num4 = 6;
									continue;
								}
								dataRow3 = FormJournalRequestForRepairAddEdit.IYu1wAXJcSSaZmFv72P(FormJournalRequestForRepairAddEdit.PkFuMSnjRjtVa9aAl9k(this.y7feOpIJtI));
								if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
								{
									num4 = 0;
									continue;
								}
								num4 = 4;
								if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
								{
									goto IL_2E5;
								}
								continue;
								IL_36A:
								dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(9988)] = tdgsyJb7kYIvCkPsM.DateBeg;
								FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10006), tdgsyJb7kYIvCkPsM.DateEnd);
								dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(10024)] = FormJournalRequestForRepairAddEdit.IsiVX1nP6DZEEJXrLIQ(tdgsyJb7kYIvCkPsM);
								FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow3, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4866), tdgsyJb7kYIvCkPsM.Num);
								num4 = 3;
								continue;
								IL_2E5:
								FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow3, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8418), num3);
								goto IL_36A;
								IL_35A:
								goto IL_2E5;
							}
						}
					}
					this.C8kgIRdW0Q();
					num = 16;
					continue;
				}
				dataRow2 = array2[num2];
				num = 2;
				if (!true)
				{
					goto IL_104;
				}
				continue;
				IL_108:
				if (num2 < array2.Length)
				{
					DataRow dataRow = array2[num2];
					num = 0;
					continue;
				}
				tdgsyJb7kYIvCkPsM.sSNJhR4vgY(this.MXUe8Spw0O);
				if (FormJournalRequestForRepairAddEdit.hkRoPYnF94y2ZY0Pt9b(tdgsyJb7kYIvCkPsM) == DialogResult.OK)
				{
					goto IL_DE;
				}
				return;
				IL_104:
				num2++;
				goto IL_108;
				IL_424:
				num2++;
				num = 8;
				continue;
				IL_40E:
				goto IL_424;
				IL_1DB:
				goto IL_40E;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000129F0 File Offset: 0x00010DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void JsogubfOH2(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
			int num;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
				num = 3;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto Block_3;
				}
			}
			else
			{
				num = 2;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 3:
					goto IL_1C7;
				case 1:
					goto IL_1D8;
				case 2:
					goto IL_2E;
				case 4:
					return;
				default:
					num = 4;
					break;
				}
			}
			IL_1C7:
			IEnumerator enumerator = FormJournalRequestForRepairAddEdit.d9SmGbnmuFCITITtr2r(this.wULnq8UnPx.SelectedRows);
			IL_1D8:
			Block_3:
			try
			{
				IL_2E:
				IL_165:
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)FormJournalRequestForRepairAddEdit.DbPnp0XhIcN9JOvTklQ(enumerator);
					int num2 = 2;
					for (;;)
					{
						int num3;
						DataRow[] array;
						switch (num2)
						{
						case 0:
						case 1:
							num3 = 0;
							break;
						case 2:
							if (Convert.ToBoolean(FormJournalRequestForRepairAddEdit.W3LhBRnwjswHXoE8JHc(FormJournalRequestForRepairAddEdit.fjV8kyntjFErdR0ewD6(dataGridViewRow), this.RI9Jlhlmpg.Name).Value))
							{
								goto Block_5;
							}
							array = FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(this.y7feOpIJtI.tL_RequestForRepairSchmObjList, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10226), dataGridViewRow.Cells[this.AZMJB5EVm8.Name].Value.ToString()));
							FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
							if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								num2 = 0;
								continue;
							}
							num2 = 5;
							if (false)
							{
								goto IL_14E;
							}
							continue;
						case 3:
							goto IL_14E;
						case 4:
							break;
						case 5:
							goto IL_14E;
						case 6:
							goto IL_165;
						default:
							num2 = 4;
							if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
								continue;
							}
							break;
						}
						IL_152:
						if (num3 >= array.Length)
						{
							num2 = 6;
							continue;
						}
						array[num3].Delete();
						IL_14E:
						num3++;
						goto IL_152;
					}
					Block_5:
					MessageBox.Show(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10242), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10194), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			this.C8kgIRdW0Q();
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00012C04 File Offset: 0x00011004
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void jXFgMoUXV2(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			for (;;)
			{
				IEnumerator enumerator;
				GoToSchemaEventArgs goToSchemaEventArgs;
				switch (num)
				{
				case 0:
					try
					{
						IL_163:
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
							int num2 = 0;
							for (;;)
							{
								DataRow[] array;
								int num3;
								switch (num2)
								{
								case 0:
									array = FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(this.y7feOpIJtI.tL_RequestForRepairSchmObjList, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10226) + FormJournalRequestForRepairAddEdit.W3LhBRnwjswHXoE8JHc(FormJournalRequestForRepairAddEdit.fjV8kyntjFErdR0ewD6(dataGridViewRow), this.AZMJB5EVm8.Name).Value.ToString());
									num2 = 4;
									if (!true)
									{
										goto IL_121;
									}
									continue;
								case 1:
								case 2:
									goto IL_14D;
								case 3:
									IL_C5:
									goto IL_121;
								case 4:
									num3 = 0;
									break;
								case 5:
									goto IL_121;
								case 6:
									goto IL_163;
								}
								FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
								num2 = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 5 : 1);
								continue;
								IL_14D:
								DataRow dataRow;
								if (num3 >= array.Length)
								{
									num2 = 6;
									if (false)
									{
										break;
									}
									continue;
								}
								else
								{
									dataRow = array[num3];
									if (!this.MXUe8Spw0O.ContainsKey(FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8418)))))
									{
										goto IL_C5;
									}
								}
								IL_147:
								num3++;
								goto IL_14D;
								IL_121:
								this.MXUe8Spw0O.Add(Convert.ToInt32(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)]), "");
								goto IL_147;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(disposable);
						}
					}
					goToSchemaEventArgs = new GoToSchemaEventArgs(this.MXUe8Spw0O.Keys.ToList<int>());
					break;
				case 1:
				case 2:
					goto IL_1E9;
				case 4:
					goto IL_20A;
				case 6:
					return;
				}
				IL_18:
				FormJournalRequestForRepairAddEdit.fUtXv9ngv8vOxERS16l(this, goToSchemaEventArgs);
				num = 6;
				continue;
				IL_20A:
				this.MXUe8Spw0O.Clear();
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					num = 2;
					continue;
				}
				num = 5;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				IL_1E9:
				enumerator = FormJournalRequestForRepairAddEdit.d9SmGbnmuFCITITtr2r(this.wULnq8UnPx.SelectedRows);
				num = 0;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_20A;
				}
				continue;
				goto IL_18;
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00012E58 File Offset: 0x00011258
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void dGNg8PPlRb()
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
			int num;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto Block_5;
				}
			}
			for (;;)
			{
				IL_8E:
				switch (num)
				{
				case 0:
				case 4:
					goto IL_B9;
				case 1:
					goto IL_CA;
				case 2:
					break;
				case 3:
					FormJournalRequestForRepairAddEdit.RcZTRir7akLPgPuD9hT(this, this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.PkFuMSnjRjtVa9aAl9k(this.y7feOpIJtI));
					FormJournalRequestForRepairAddEdit.F4iPw1nEZ3UnELVUTZC(this, this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.PkFuMSnjRjtVa9aAl9k(this.y7feOpIJtI));
					break;
				case 5:
					goto IL_DC;
				case 6:
					return;
				default:
					num = 2;
					continue;
				}
				FormJournalRequestForRepairAddEdit.Gj6bAHnKgggiih0uhds(this.y7feOpIJtI.tL_RequestForRepairSchmObjList);
				num = 6;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
				}
			}
			IL_B9:
			IEnumerator<E1YGNRmqUpG01b1DWc.HdrwQSvpZhDcM6kbie> enumerator = this.y7feOpIJtI.tL_RequestForRepairSchmObjList.GetEnumerator();
			IL_CA:
			Block_5:
			try
			{
				IL_DC:
				IL_192:
				while (enumerator.MoveNext())
				{
					DataRow dataRow = enumerator.Current;
					int num2 = 0;
					if (!true)
					{
						goto IL_F4;
					}
					for (;;)
					{
						IL_13D:
						switch (num2)
						{
						case 0:
							if (FormJournalRequestForRepairAddEdit.jSgH4onRAFMXGvcH2Fh(dataRow) == DataRowState.Detached)
							{
								goto IL_192;
							}
							FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
							if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								num2 = 4;
								if (!true)
								{
									goto IL_192;
								}
							}
							else
							{
								num2 = 3;
							}
							break;
						case 1:
						case 4:
							goto IL_11F;
						default:
							goto IL_15A;
						case 3:
							goto IL_F4;
						case 5:
							goto IL_192;
						}
					}
					IL_11F:
					if (FormJournalRequestForRepairAddEdit.jSgH4onRAFMXGvcH2Fh(dataRow) == DataRowState.Deleted)
					{
						continue;
					}
					IL_15A:
					IL_F4:
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678)] = this.abEgNyD5Y6;
					dataRow.EndEdit();
					num2 = 5;
					goto IL_13D;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(enumerator);
				}
			}
			base.InsertSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tL_RequestForRepairSchmObjList);
			num = 3;
			if (true)
			{
				goto IL_8E;
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00013048 File Offset: 0x00011448
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void qbFgRTsOoo(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 2:
					goto IL_D6;
				case 1:
					goto IL_8B;
				default:
					goto IL_11D;
				case 4:
					this.I4xetUTq0V.Value = null;
					FormJournalRequestForRepairAddEdit.DsontcXauIkkEcpw5iv(this.kl0niMXXMI, -1);
					num = 7;
					break;
				case 5:
					if (this.rWoeDxUpjP.Checked)
					{
						num = 6;
						if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							goto IL_8B;
						}
					}
					else
					{
						if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair).Count <= 0 || this.I4xetUTq0V.Value == null)
						{
							return;
						}
						num = 4;
					}
					break;
				case 6:
					if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI)).Count <= 0)
					{
						return;
					}
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 0;
					}
					else
					{
						num = 1;
						if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							return;
						}
					}
					break;
				case 7:
					return;
				}
			}
			IL_8B:
			this.I4xetUTq0V.Value = DateTime.Now;
			return;
			IL_D6:
			if (this.I4xetUTq0V.Value != null)
			{
				return;
			}
			IL_11D:
			goto IL_8B;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00013188 File Offset: 0x00011588
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void wTGgCapMoI(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.YQrg2wn9R8();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000131A0 File Offset: 0x000115A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void lZVgX99vto(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000131C0 File Offset: 0x000115C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AX9gqGfduq(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000131E0 File Offset: 0x000115E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UYagm69vbR(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				FormJournalRequestForRepairAddEdit.OKhApfn9l3GRy8aXNok(openFileDialog, true);
				int num = 6;
				for (;;)
				{
					DataRow dataRow;
					int num2;
					switch (num)
					{
					case 0:
						goto IL_9C;
					case 1:
					case 3:
						goto IL_74;
					case 2:
						FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10380), File.ReadAllBytes(openFileDialog.FileNames[num2]));
						num = 0;
						continue;
					case 4:
						goto IL_8A;
					case 5:
						goto IL_131;
					case 6:
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							num2 = 0;
							goto IL_145;
						}
						goto IL_153;
					case 7:
						goto IL_145;
					}
					goto IL_F0;
					IL_145:
					if (num2 >= FormJournalRequestForRepairAddEdit.Hkwnqrne2tgfS8xxPQQ(openFileDialog).Length)
					{
						break;
					}
					dataRow = FormJournalRequestForRepairAddEdit.VZPVrYniBwoOQvPYfkJ(this.y7feOpIJtI).NewRow();
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678)] = this.abEgNyD5Y6;
					num = 2;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_74;
					}
					continue;
					IL_F0:
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 1;
						continue;
					}
					num = 5;
					if (!false)
					{
						continue;
					}
					IL_9C:
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400), Path.GetFileName(FormJournalRequestForRepairAddEdit.Hkwnqrne2tgfS8xxPQQ(openFileDialog)[num2]));
					goto IL_F0;
					IL_131:
					num2++;
					num = 7;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_145;
					}
					continue;
					IL_8A:
					goto IL_131;
					IL_74:
					FormJournalRequestForRepairAddEdit.HwGAmXr3WG5y8RIbsRA(FormJournalRequestForRepairAddEdit.VZPVrYniBwoOQvPYfkJ(this.y7feOpIJtI).Rows, dataRow);
					goto IL_8A;
				}
				IL_153:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001337C File Offset: 0x0001177C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void spvgsQBU6S(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
			int num;
			if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				num = 1;
				if (!true)
				{
					goto IL_2A;
				}
			}
			else
			{
				num = 4;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 1:
					if (this.YoIns0P0S0.CurrentRow != null)
					{
						num = 5;
					}
					else
					{
						MessageBox.Show(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10420));
						num = 6;
						if (false)
						{
							goto IL_9C;
						}
					}
					break;
				case 2:
					goto IL_55;
				case 3:
					return;
				case 4:
					goto IL_9C;
				case 5:
					goto IL_2A;
				case 6:
					return;
				default:
					num = 3;
					break;
				}
			}
			return;
			IL_2A:
			Convert.ToInt32(FormJournalRequestForRepairAddEdit.Q1PIoVrArSunLIIFWj5(FormJournalRequestForRepairAddEdit.fjV8kyntjFErdR0ewD6(this.YoIns0P0S0.CurrentRow)[this.mXdn547ZHM.Name]));
			IL_55:
			IL_9C:
			this.YoIns0P0S0.Rows.Remove(FormJournalRequestForRepairAddEdit.BiXsaQn4QrlU4LVgK7l(this.YoIns0P0S0));
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00013480 File Offset: 0x00011880
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void yM9g7qaZTt(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 5 : 1;
			for (;;)
			{
				byte[] array;
				string text;
				switch (num)
				{
				case 0:
				case 1:
					if (this.YoIns0P0S0.CurrentRow == null)
					{
						num = 3;
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							continue;
						}
					}
					else
					{
						int \u00202 = FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.BiXsaQn4QrlU4LVgK7l(this.YoIns0P0S0).Cells[this.mXdn547ZHM.Name].Value);
						array = (byte[])FormJournalRequestForRepairAddEdit.ppyhq7nMF5jF1YAq621(this.y7feOpIJtI.tJ_RequestForRepairDoc, \u00202)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10380)];
						text = FormJournalRequestForRepairAddEdit.ewrSO0n5DdAvWAZH4u3();
						num = 6;
						if (!true)
						{
							goto IL_D5;
						}
						continue;
					}
					break;
				case 2:
					goto IL_D5;
				case 3:
					return;
				case 4:
					break;
				case 5:
					break;
				case 6:
				{
					int \u00202;
					text = Path.ChangeExtension(text, Path.GetExtension(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.y7feOpIJtI.tJ_RequestForRepairDoc.U927aijt9q(\u00202), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10400)).ToString()));
					goto IL_D5;
				}
				case 7:
					return;
				default:
					num = 2;
					continue;
				}
				IL_44:
				Process process = new Process();
				FormJournalRequestForRepairAddEdit.tscs7Kn0QqX6o4qEykD(FormJournalRequestForRepairAddEdit.nM0tcsnCDhglDbGQ7ln(process), text);
				FormJournalRequestForRepairAddEdit.nM0tcsnCDhglDbGQ7ln(process).UseShellExecute = true;
				process.Start();
				num = 7;
				continue;
				IL_EB:
				goto IL_44;
				IL_D5:
				FileStream fileStream = File.Create(text);
				fileStream.Write(array, 0, array.Length);
				FormJournalRequestForRepairAddEdit.hAk1x6nv3loCOavAEPa(fileStream);
				goto IL_EB;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000135FC File Offset: 0x000119FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Co2gaCxGTV(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			try
			{
				int \u00202 = Convert.ToInt32(FormJournalRequestForRepairAddEdit.Q1PIoVrArSunLIIFWj5(FormJournalRequestForRepairAddEdit.W3LhBRnwjswHXoE8JHc(this.YoIns0P0S0.CurrentRow.Cells, this.mXdn547ZHM.Name)));
				int num = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 4 : 2;
				for (;;)
				{
					SaveFileDialog saveFileDialog;
					string text2;
					switch (num)
					{
					case 0:
					case 2:
						goto IL_145;
					case 1:
					{
						FileStream fileStream = File.Create(saveFileDialog.FileName);
						byte[] array;
						fileStream.Write(array, 0, array.Length);
						fileStream.Close();
						num = 7;
						if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							goto IL_145;
						}
						continue;
					}
					case 5:
						goto IL_CA;
					case 6:
					{
						string text = FormJournalRequestForRepairAddEdit.zF26DUnxUAWLjRIurm5(text2);
						saveFileDialog = new SaveFileDialog();
						FormJournalRequestForRepairAddEdit.A4i0yMnhcyZcd9PrV2U(saveFileDialog, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10476) + text + FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10484) + text);
						num = 5;
						if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							goto IL_CA;
						}
						continue;
					}
					case 7:
						goto IL_17C;
					}
					IL_4F:
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						byte[] array = (byte[])FormJournalRequestForRepairAddEdit.ppyhq7nMF5jF1YAq621(this.y7feOpIJtI.tJ_RequestForRepairDoc, \u00202)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10380)];
						num = 1;
						continue;
					}
					goto IL_196;
					IL_145:
					text2 = FormJournalRequestForRepairAddEdit.W3LhBRnwjswHXoE8JHc(this.YoIns0P0S0.CurrentRow.Cells, FormJournalRequestForRepairAddEdit.jMnvLQr6txx4yanbSIv(this.lahnAiuE7f)).Value.ToString();
					num = 6;
					if (false)
					{
						break;
					}
					continue;
					IL_108:
					goto IL_4F;
					IL_CA:
					saveFileDialog.FileName = text2;
					goto IL_108;
				}
				IL_17C:
				MessageBox.Show(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10494), cDhluYseFOthxgEIXpc.nKHKpgTSVU(10540));
				IL_196:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, FormJournalRequestForRepairAddEdit.uvR5uRrxXOx7fWxYma8(ex));
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000137DC File Offset: 0x00011BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void rTFg1NniZF(object \u0020, DataGridViewCellValueEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_FA;
				case 1:
				case 3:
					if (this.YoIns0P0S0[FormJournalRequestForRepairAddEdit.jMnvLQr6txx4yanbSIv(this.lahnAiuE7f), \u0020.RowIndex].Value != null && \u0020.ColumnIndex == FormJournalRequestForRepairAddEdit.qWWP2arZ7RpmanieB4V(this.YoIns0P0S0)[this.QrTn9EhhGj.Name].Index)
					{
						goto IL_D2;
					}
					return;
				case 2:
					goto IL_D2;
				case 4:
					break;
				case 5:
					goto IL_18;
				case 6:
					return;
				default:
					num = 4;
					continue;
				}
				IL_E2:
				Icon icon;
				\u0020.Value = FormJournalRequestForRepairAddEdit.oTNWCfnuEMle3wDN9c3(icon);
				num = 6;
				if (false)
				{
					goto IL_FA;
				}
				continue;
				IL_18:
				icon = FormJournalRequestForRepairAddEdit.ObieC2nYpJncVEtsUEJ(FormJournalRequestForRepairAddEdit.LPqkmJrpJ50YZWs9xTD(this.YoIns0P0S0, this.lahnAiuE7f.Name, \u0020.RowIndex).Value.ToString());
				goto IL_E2;
				IL_D2:
				goto IL_18;
				IL_FA:
				if (FormJournalRequestForRepairAddEdit.I2fKyQno59of0eQfLs1(this.YoIns0P0S0) <= 0)
				{
					break;
				}
				num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 5 : 3);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0001390C File Offset: 0x00011D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void zVBgO3AqiM(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
			int num = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 6 : 1;
			for (;;)
			{
				int \u00202;
				byte[] array;
				switch (num)
				{
				case 0:
				case 1:
					if (FormJournalRequestForRepairAddEdit.BiXsaQn4QrlU4LVgK7l(this.YoIns0P0S0) == null)
					{
						num = 2;
						if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							return;
						}
						continue;
					}
					else
					{
						\u00202 = Convert.ToInt32(FormJournalRequestForRepairAddEdit.BiXsaQn4QrlU4LVgK7l(this.YoIns0P0S0).Cells[this.mXdn547ZHM.Name].Value);
						num = 3;
						if (!true)
						{
							goto IL_80;
						}
						continue;
					}
					break;
				case 2:
					return;
				case 3:
					if (FormJournalRequestForRepairAddEdit.DBZuSXna80ifLSLsfK5(\u0020) == FormJournalRequestForRepairAddEdit.L20t1knqG7EfLAx201D(FormJournalRequestForRepairAddEdit.qWWP2arZ7RpmanieB4V(this.YoIns0P0S0), this.lahnAiuE7f.Name).Index)
					{
						array = (byte[])FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.ppyhq7nMF5jF1YAq621(FormJournalRequestForRepairAddEdit.VZPVrYniBwoOQvPYfkJ(this.y7feOpIJtI), \u00202), cDhluYseFOthxgEIXpc.nKHKpgTSVU(10380));
						goto IL_80;
					}
					return;
				case 4:
					break;
				case 5:
					goto IL_80;
				case 6:
					break;
				case 7:
					return;
				default:
					num = 5;
					continue;
				}
				IL_96:
				string text = Path.ChangeExtension(text, Path.GetExtension(this.y7feOpIJtI.tJ_RequestForRepairDoc.U927aijt9q(\u00202)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10400)].ToString()));
				object obj2 = FormJournalRequestForRepairAddEdit.kDHMMVn8j1QtBM04oNs(text);
				obj2.Write(array, 0, array.Length);
				obj2.Close();
				Process process = new Process();
				process.StartInfo.FileName = text;
				FormJournalRequestForRepairAddEdit.nM0tcsnCDhglDbGQ7ln(process).UseShellExecute = true;
				process.Start();
				num = 7;
				continue;
				IL_86:
				goto IL_96;
				IL_80:
				text = Path.GetTempFileName();
				goto IL_86;
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00013AB8 File Offset: 0x00011EB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PJ9gLYJBAm()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
				num = 1;
				if (!true)
				{
					goto IL_26;
				}
			}
			else
			{
				num = 5;
			}
			IEnumerator<E1YGNRmqUpG01b1DWc.sTXokjssS01c5hiO5t2> enumerator;
			do
			{
				IL_68:
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 2:
					goto IL_1A1;
				case 3:
					goto IL_B6;
				case 4:
					goto IL_1B1;
				case 5:
					goto IL_26;
				case 6:
					return;
				default:
					num = 4;
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						continue;
					}
					break;
				}
				enumerator = this.y7feOpIJtI.tJ_RequestForRepairDoc.GetEnumerator();
				num = 3;
			}
			while (!false);
			try
			{
				IL_B6:
				while (enumerator.MoveNext())
				{
					DataRow dataRow = enumerator.Current;
					int num2 = 3;
					if (true)
					{
						goto IL_13F;
					}
					IL_CE:
					if (dataRow.RowState == DataRowState.Detached || dataRow.RowState == DataRowState.Deleted)
					{
						continue;
					}
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num2 = 0;
						if (!true)
						{
							goto IL_102;
						}
					}
					else
					{
						num2 = 4;
					}
					IL_13F:
					switch (num2)
					{
					case 0:
					case 1:
						dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678)] = this.abEgNyD5Y6;
						break;
					case 3:
						goto IL_CE;
					case 5:
						continue;
					}
					IL_102:
					dataRow.EndEdit();
					num2 = 5;
					goto IL_13F;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(enumerator);
				}
			}
			FormJournalRequestForRepairAddEdit.rtKkoCrl70VwRDQSvNT(this, this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDoc);
			IL_1A1:
			IL_26:
			FormJournalRequestForRepairAddEdit.RcZTRir7akLPgPuD9hT(this, this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDoc);
			base.DeleteSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairDoc);
			IL_1B1:
			FormJournalRequestForRepairAddEdit.Gj6bAHnKgggiih0uhds(this.y7feOpIJtI.tL_RequestForRepairSchmObjList);
			num = 6;
			goto IL_68;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00013CA0 File Offset: 0x000120A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void aPbgvwwLQh(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 12;
			for (;;)
			{
				DataRow dataRow;
				DataRow dataRow2;
				DataTable dataTable;
				DataTable dataTable2;
				switch (num)
				{
				case 0:
					goto IL_3EF;
				case 1:
				case 17:
					return;
				case 2:
					goto IL_208;
				case 3:
					if (dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4948)] == DBNull.Value)
					{
						dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)] = -1;
					}
					else
					{
						FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948), dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)]);
					}
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4960)] = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4960)];
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4980)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4980));
					num = 15;
					continue;
				case 4:
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5396)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(dataTable.Rows, 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900));
					num = 10;
					continue;
				case 5:
					FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Clear();
					this.y7feOpIJtI.tJ_RequestForRepairDoc.Clear();
					num = 9;
					continue;
				case 6:
					break;
				case 7:
					goto IL_4F6;
				case 8:
					goto IL_439;
				case 9:
					goto IL_47B;
				case 10:
					goto IL_161;
				case 11:
					break;
				case 12:
					if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair).Count <= 0)
					{
						FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
						num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 6 : 17);
						continue;
					}
					dataTable2 = FormJournalRequestForRepairAddEdit.GgZqAPnBFW9doX5m3Vj(this.y7feOpIJtI.tJ_RequestForRepair);
					num = 7;
					continue;
				case 13:
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5118)] = false;
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5192), dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8110)]);
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5220)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8154));
					dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10564)] = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(10564)];
					break;
				case 14:
					goto IL_4E;
				case 15:
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4998)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4998));
					num = 2;
					continue;
				case 16:
					if (dataTable.Rows.Count <= 0)
					{
						goto IL_161;
					}
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5352), dataTable.Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5380)]);
					if (dataTable.Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4900)] == DBNull.Value)
					{
						goto IL_161;
					}
					num = 4;
					if (false)
					{
						goto IL_208;
					}
					continue;
				case 18:
					return;
				default:
					num = 8;
					continue;
				}
				IL_18:
				dataTable = this.dX2IfI82JW();
				base.SelectSqlData(dataTable, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5290), null, false, 0);
				num = 16;
				if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					goto IL_4E;
				}
				continue;
				IL_6E:
				FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4920), dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4920)]);
				num = 3;
				continue;
				IL_47B:
				FormJournalRequestForRepairAddEdit.gsycSvn6fondoMwg6DF(this.y7feOpIJtI.tJ_RequestForRepairDaily);
				dataRow2 = FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).NewRow();
				dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4866)] = 0;
				dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4876)] = FormJournalRequestForRepairAddEdit.fpu0vrXOM4IyU9rHHoe();
				if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900)] == DBNull.Value)
				{
					goto IL_6E;
				}
				num = 14;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_4F6;
				}
				continue;
				IL_4E:
				dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900)] = dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4900)];
				goto IL_6E;
				IL_161:
				if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900)) == DBNull.Value)
				{
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4900), -1);
					num = 0;
					continue;
				}
				IL_3EF:
				this.abEgNyD5Y6 = -1;
				this.ffsghkQnr5 = eActionRequestRepair.Add;
				FormJournalRequestForRepairAddEdit.HwGAmXr3WG5y8RIbsRA(this.y7feOpIJtI.tJ_RequestForRepair.Rows, dataRow2);
				num = 18;
				continue;
				IL_439:
				FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5078), false);
				dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5094)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5094));
				num = 13;
				if (false)
				{
					goto IL_47B;
				}
				continue;
				IL_208:
				if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5016)) == DBNull.Value)
				{
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5016), -1);
				}
				else
				{
					dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5016)] = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5016)];
				}
				dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5566)] = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5566)];
				dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5052)] = dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5052)];
				goto IL_439;
				IL_4F6:
				dataRow = dataTable2.NewRow();
				FormJournalRequestForRepairAddEdit.UbYfjTnygT2vE91V4km(dataRow, dataTable2.Rows[0].ItemArray);
				num = 5;
				continue;
				goto IL_18;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00014200 File Offset: 0x00012600
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override XmlDocument CreateXmlConfig()
		{
			while (false)
			{
				object obj = null[0];
			}
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode xmlNode = xmlDocument.CreateXmlDeclaration(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10588), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10598), null);
			FormJournalRequestForRepairAddEdit.vUJud3nN7tCtRRxujuS(xmlDocument, xmlNode);
			XmlNode xmlNode2 = FormJournalRequestForRepairAddEdit.GOiUNunAGM5qwo1BZeU(xmlDocument, FormJournalRequestForRepairAddEdit.opqSIZnSmoxgdcgvmDc(this));
			FormJournalRequestForRepairAddEdit.vUJud3nN7tCtRRxujuS(xmlDocument, xmlNode2);
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10612));
			xmlAttribute.Value = base.Location.X.ToString();
			FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode2).Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10618));
			xmlAttribute.Value = base.Location.Y.ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(1054));
			if (this.ffsghkQnr5 == eActionRequestRepair.Add && this.C99elfqXty.SelectedValue != null)
			{
				xmlAttribute.Value = this.C99elfqXty.SelectedValue.ToString();
			}
			else
			{
				FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute, this.LEveRtAqeF.ToString());
			}
			xmlNode2.Attributes.Append(xmlAttribute);
			return xmlDocument;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00014334 File Offset: 0x00012734
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ApplyConfig(XmlDocument doc)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			for (;;)
			{
				int? num2;
				XmlAttribute xmlAttribute;
				XmlNode xmlNode;
				int? num3;
				int num4;
				int? num5;
				bool flag;
				bool flag2;
				switch (num)
				{
				case 0:
					goto IL_16F;
				case 1:
					num2 = null;
					num = 6;
					continue;
				case 2:
					goto IL_218;
				case 3:
					goto IL_6C;
				case 4:
					if (xmlAttribute != null)
					{
						num2 = new int?(Convert.ToInt32(xmlAttribute.Value));
					}
					xmlAttribute = xmlNode.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(10618)];
					if (xmlAttribute != null)
					{
						num3 = new int?(Convert.ToInt32(FormJournalRequestForRepairAddEdit.wNsWuanfhV2yohEhOTM(xmlAttribute)));
					}
					if (num2 != null)
					{
						goto IL_6C;
					}
					goto IL_1B9;
				case 5:
				case 9:
					num4 = 0;
					if (num5.GetValueOrDefault() >= num4)
					{
						goto IL_29;
					}
					flag = (num5 != null);
					goto IL_193;
				case 6:
					goto IL_8E;
				case 7:
					if (xmlNode == null)
					{
						return;
					}
					num = 2;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_218;
					}
					continue;
				case 8:
					goto IL_186;
				case 10:
					goto IL_29;
				case 11:
					flag2 = false;
					break;
				case 12:
					goto IL_151;
				case 13:
					return;
				default:
					num = 3;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_151;
					}
					continue;
				}
				IL_46:
				if (flag2)
				{
					num2 = new int?(0);
				}
				num5 = num3;
				num = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 8 : 5);
				continue;
				IL_6C:
				if (num3 == null)
				{
					goto IL_1B9;
				}
				num5 = num2;
				num4 = 0;
				num = 12;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					continue;
				}
				IL_8E:
				num3 = null;
				num = 4;
				continue;
				IL_151:
				if (num5.GetValueOrDefault() < num4)
				{
					flag2 = (num5 != null);
					goto IL_46;
				}
				num = 11;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					continue;
				}
				IL_16F:
				xmlNode = doc.SelectSingleNode(FormJournalRequestForRepairAddEdit.opqSIZnSmoxgdcgvmDc(this));
				num = 7;
				continue;
				IL_1B9:
				xmlAttribute = FormJournalRequestForRepairAddEdit.F7AksDnptBsp1PbhVpB(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(1054));
				if (xmlAttribute != null)
				{
					this.LEveRtAqeF = Convert.ToInt32(xmlAttribute.Value);
					num = 13;
					continue;
				}
				break;
				IL_193:
				if (flag)
				{
					num3 = new int?(0);
				}
				base.Location = new Point(num2.Value, num3.Value);
				goto IL_1B9;
				IL_186:
				flag = false;
				goto IL_193;
				IL_29:
				goto IL_186;
				IL_218:
				xmlAttribute = FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(10612)];
				num = 1;
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001457C File Offset: 0x0001297C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Ktcg4fYAMu(List<int> \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.GRHnGkvVC9.Panel2.Enabled = false;
			this.jNxezOc8K1.Enabled = false;
			this.WYcJoUVlbK.RunWorkerAsync(\u0020);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000145B8 File Offset: 0x000129B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EaxgBgllje(object \u0020, DoWorkEventArgs \u0020)
		{
			while (false)
			{
				object obj3 = null[0];
			}
			int num = 8;
			string text;
			SqlConnection sqlConnection;
			for (;;)
			{
				List<ElectricObject> list;
				switch (num)
				{
				case 0:
					goto IL_30F;
				case 1:
					goto IL_17F;
				case 2:
					Block_5:
					try
					{
						IEnumerator<ElectricObject> enumerator;
						while (enumerator.MoveNext())
						{
							ElectricObject obj2 = enumerator.Current;
							switch (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 3 : 2)
							{
							case 0:
							case 2:
								list.AddRange(this.mkoeCi01If.PoweringReportForDrawObject(obj2, true, true));
								break;
							}
						}
					}
					finally
					{
						IEnumerator<ElectricObject> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					if (list.Count <= 0)
					{
						return;
					}
					num = 1;
					if (false)
					{
						goto IL_17F;
					}
					continue;
				case 3:
				case 10:
					base.SelectSqlData(this.jpMeqgA5CG, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10656), null, false, 0);
					goto IL_6C;
				case 4:
					goto IL_190;
				case 5:
					FormJournalRequestForRepairAddEdit.grwcVbnOIfUeh3J9P3l(this.mkoeCi01If, false);
					break;
				case 6:
				{
					IEnumerable<ElectricObject> enumerable = this.mkoeCi01If.Objects.Where(delegate(ElectricObject obj)
					{
						while (false)
						{
							object obj4 = null[0];
						}
						return <>c__DisplayClass99_.objectsId.Contains(FormJournalRequestForRepairAddEdit.<>c__DisplayClass99_0.VWCNJnG86JnXRovpoh7(obj));
					});
					if (enumerable.Count<ElectricObject>() > 0)
					{
						goto IL_30F;
					}
					return;
				}
				case 7:
				{
					IEnumerable<ElectricObject> enumerable;
					IEnumerator<ElectricObject> enumerator = enumerable.GetEnumerator();
					num = 2;
					continue;
				}
				case 8:
					num = 9;
					continue;
				case 9:
					if (this.mkoeCi01If == null)
					{
						this.mkoeCi01If = new ElectricModel();
						this.mkoeCi01If.SqlSettings = this.SqlSettings;
						num = 5;
						continue;
					}
					break;
				case 11:
					using (List<ElectricObject>.Enumerator enumerator2 = list.GetEnumerator())
					{
						IL_3EE:
						while (enumerator2.MoveNext())
						{
							ElectricObject electricObject = enumerator2.Current;
							int num2 = 3;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								case 1:
									goto IL_349;
								default:
									goto IL_38A;
								case 3:
									if (FormJournalRequestForRepairAddEdit.frGxQ1rVyhal7bXRk7u(text))
									{
										num2 = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 4 : 0);
									}
									else
									{
										text = FormJournalRequestForRepairAddEdit.qK3BLfnU0lFVrvHNSux(text, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10764), FormJournalRequestForRepairAddEdit.CbJpmqnDB1qgAwnievG(electricObject).ToString());
										num2 = 5;
									}
									break;
								case 4:
									goto IL_3BC;
								case 5:
									goto IL_3EE;
								}
							}
							IL_3BC:
							IL_38A:
							continue;
							IL_349:
							text = FormJournalRequestForRepairAddEdit.CbJpmqnDB1qgAwnievG(electricObject).ToString();
						}
					}
					sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
					num = 13;
					continue;
				case 12:
					goto IL_190;
				case 13:
					goto IL_439;
				default:
					num = 0;
					continue;
				}
				if (this.jpMeqgA5CG != null)
				{
					goto IL_6C;
				}
				this.jpMeqgA5CG = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10624));
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					num = 10;
					continue;
				}
				num = 12;
				if (false)
				{
					goto Block_5;
				}
				continue;
				IL_17F:
				text = "";
				num = 11;
				continue;
				IL_21E:
				<>c__DisplayClass99_.objectsId = (List<int>)\u0020.Argument;
				num = 6;
				continue;
				IL_6C:
				if (this.KOseX49R7b == null)
				{
					this.KOseX49R7b = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10694));
					base.SelectSqlData(this.KOseX49R7b, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10656), null, false, 0);
				}
				if (this.dAvem92PLM != null)
				{
					this.dAvem92PLM.Clear();
					goto IL_21E;
				}
				this.dAvem92PLM = new DataTable();
				IL_190:
				FormJournalRequestForRepairAddEdit.uOQuZmXi3rjBekKWKMt(this.dAvem92PLM.Columns, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10720), Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777219)));
				this.dAvem92PLM.Columns.Add(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10744), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
				FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(this.dAvem92PLM).Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(8042), FormJournalRequestForRepairAddEdit.fubmvOX9d6a46jiTIfX(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
				goto IL_21E;
				IL_30F:
				list = new List<ElectricObject>();
				num = 7;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
				}
			}
			try
			{
				IL_439:
				FormJournalRequestForRepairAddEdit.S0wjd7nJagL7msrmBl5(sqlConnection);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10770) + text + cDhluYseFOthxgEIXpc.nKHKpgTSVU(11222), sqlConnection);
				FormJournalRequestForRepairAddEdit.BsPQbenIlb1Voik0cQF(sqlDataAdapter.SelectCommand, 0);
				FormJournalRequestForRepairAddEdit.wKeE0MXd0NuogaNjchC(sqlDataAdapter, this.dAvem92PLM);
			}
			catch (Exception ex)
			{
				FormJournalRequestForRepairAddEdit.PtHR4ynZGJNLVafgh3Q(ex.Message, ex.Source);
			}
			finally
			{
				if (sqlConnection != null)
				{
					((IDisposable)sqlConnection).Dispose();
				}
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00014AA4 File Offset: 0x00012EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Q3lglppsmI(object \u0020, RunWorkerCompletedEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
				num = 3;
				if (false)
				{
					goto IL_26;
				}
			}
			else
			{
				num = 2;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 3:
					goto IL_67;
				case 1:
					goto IL_2BF;
				case 2:
					goto IL_26;
				case 4:
					return;
				default:
					num = 4;
					break;
				}
			}
			try
			{
				IL_67:
				using (IEnumerator enumerator = FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.dAvem92PLM).GetEnumerator())
				{
					IL_264:
					while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						int num2;
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							num2 = 4;
							if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								goto IL_A5;
							}
						}
						else
						{
							num2 = 3;
						}
						DataRow dataRow2;
						for (;;)
						{
							IL_C8:
							switch (num2)
							{
							case 0:
							case 4:
								if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(10744)] == DBNull.Value)
								{
									goto IL_264;
								}
								break;
							case 1:
								break;
							case 2:
								goto IL_195;
							case 3:
								break;
							case 5:
								FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11380), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11404)));
								dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11428)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10744));
								FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8042), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8042)));
								FormJournalRequestForRepairAddEdit.jVd3R4rLSNpv4WDN18y(this.y7feOpIJtI).Rows.Add(dataRow2);
								num2 = 7;
								continue;
							case 6:
								goto IL_A5;
							case 7:
								goto IL_264;
							default:
								num2 = 2;
								continue;
							}
							IL_F7:
							if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8042)] == DBNull.Value || FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(this.y7feOpIJtI.tJ_RequestForRepairAddress, string.Concat(new string[]
							{
								FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11286),
								FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11322)).ToString(),
								FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11342),
								dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8042)].ToString(),
								cDhluYseFOthxgEIXpc.nKHKpgTSVU(11374)
							})).Length != 0)
							{
								goto IL_264;
							}
							num2 = 6;
							if (!true)
							{
								break;
							}
							continue;
							goto IL_F7;
						}
						IL_195:
						FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678), this.abEgNyD5Y6);
						num2 = 5;
						goto IL_C8;
						IL_A5:
						dataRow2 = FormJournalRequestForRepairAddEdit.IYu1wAXJcSSaZmFv72P(this.y7feOpIJtI.tJ_RequestForRepairAddress);
						goto IL_195;
					}
				}
				this.DbfgPWaf8k();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.GRHnGkvVC9.Panel2, true);
			IL_2BF:
			IL_26:
			this.jNxezOc8K1.Enabled = true;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00014DB4 File Offset: 0x000131B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DbfgPWaf8k()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 8;
			for (;;)
			{
				IEnumerator enumerator;
				List<int> list;
				List<int>.Enumerator enumerator2;
				switch (num)
				{
				case 0:
					if (this.jpMeqgA5CG == null)
					{
						FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
						num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 7 : 5);
						continue;
					}
					goto IL_365;
				case 1:
					goto IL_365;
				case 2:
				case 5:
					this.jpMeqgA5CG = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10624));
					base.SelectSqlData(this.jpMeqgA5CG, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10656), null, false, 0);
					num = 1;
					if (!true)
					{
						return;
					}
					continue;
				case 3:
				{
					try
					{
						IL_5A0:
						IL_64F:
						while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
						{
							DataRow dataRow = (DataRow)FormJournalRequestForRepairAddEdit.DbPnp0XhIcN9JOvTklQ(enumerator);
							FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
							int num2 = (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 2 : 3;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								case 3:
									if (list.Contains(FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11428)))))
									{
										goto IL_64F;
									}
									break;
								case 4:
									goto IL_64F;
								}
								IL_5CD:
								list.Add(Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11428))));
								num2 = 4;
								continue;
								goto IL_5CD;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					string text = "";
					break;
				}
				case 4:
				{
					string text;
					try
					{
						IL_546:
						while (enumerator2.MoveNext())
						{
							int num3 = enumerator2.Current;
							int num4 = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 5 : 2;
							for (;;)
							{
								DataRow[] array;
								string text2;
								DataRow[] array2;
								switch (num4)
								{
								case 0:
								case 2:
									array = this.bgxnjGgfZD.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(11514) + num3.ToString());
									break;
								case 1:
									break;
								case 3:
									goto IL_52F;
								case 4:
									text2 = FormJournalRequestForRepairAddEdit.UKEtXKnz5XBfvLh8i0E(text2, FormJournalRequestForRepairAddEdit.FawFPdrvw3qGMyilf6m(text2) - 2);
									text = FormJournalRequestForRepairAddEdit.qK3BLfnU0lFVrvHNSux(text, text2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11572));
									num4 = 8;
									continue;
								case 5:
									break;
								case 6:
									goto IL_4E7;
								case 7:
									text2 = FormJournalRequestForRepairAddEdit.fppspwncISFr9gOZxkb(array[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(512)].ToString(), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11550), array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(544)].ToString(), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11558));
									array2 = array;
									goto IL_4E7;
								case 8:
									goto IL_546;
								default:
									num4 = 6;
									continue;
								}
								IL_4CE:
								if (array.Count<DataRow>() <= 0)
								{
									break;
								}
								num4 = 7;
								if (!true)
								{
									goto IL_4E7;
								}
								continue;
								goto IL_4CE;
								IL_52F:
								int num5;
								if (num5 < array2.Length)
								{
									DataRow dataRow2 = array2[num5];
									text2 = text2 + dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(584)].ToString() + FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11550);
									num5++;
									num4 = 3;
									continue;
								}
								num4 = 4;
								if (false)
								{
									break;
								}
								continue;
								IL_4E7:
								num5 = 0;
								goto IL_52F;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.jbcndg5xWg, text);
					if (!string.IsNullOrEmpty(this.jbcndg5xWg.Text))
					{
						this.psNecTr5ut.ForeColor = FormJournalRequestForRepairAddEdit.boZdSGnWwbPWvD83nRP();
						num = 10;
						continue;
					}
					return;
				}
				case 6:
					break;
				case 7:
					break;
				case 8:
					this.bgxnjGgfZD.Clear();
					num = 0;
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						continue;
					}
					break;
				case 9:
					base.SelectSqlData(this.KOseX49R7b, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10656), null, false, 0);
					goto IL_68;
				case 10:
					return;
				default:
					num = 3;
					continue;
				}
				IL_33:
				enumerator2 = list.GetEnumerator();
				num = 4;
				continue;
				goto IL_33;
				IL_68:
				IEnumerator<E1YGNRmqUpG01b1DWc.LOpcT5sKlE3fdjQXH5N> enumerator3 = this.y7feOpIJtI.tJ_RequestForRepairAddress.GetEnumerator();
				try
				{
					IL_2E3:
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = enumerator3.Current;
						int num6;
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							num6 = 2;
							if (false)
							{
								goto IL_9E;
							}
						}
						else
						{
							num6 = 1;
						}
						DataRow dataRow4;
						for (;;)
						{
							IL_262:
							switch (num6)
							{
							case 0:
							case 2:
								if (dataRow3.RowState == DataRowState.Deleted)
								{
									goto IL_2E3;
								}
								dataRow4 = this.bgxnjGgfZD.NewRow();
								num6 = 3;
								break;
							case 1:
								goto IL_134;
							case 3:
								FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow4, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6146), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146)));
								dataRow4[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11380)] = dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(11380)];
								num6 = 7;
								break;
							case 4:
								goto IL_D4;
							case 5:
								goto IL_124;
							case 6:
								goto IL_9E;
							case 7:
								goto IL_150;
							case 8:
								goto IL_2E3;
							default:
								num6 = 6;
								break;
							}
						}
						IL_150:
						dataRow4[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11428)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow3, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11458));
						dataRow4[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8042)] = dataRow3[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8042)];
						DataRow[] array3 = this.KOseX49R7b.Select(FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(11488), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11380)).ToString()));
						if (array3.Length != 0)
						{
							dataRow4[cDhluYseFOthxgEIXpc.nKHKpgTSVU(512)] = array3[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512)].ToString() + cDhluYseFOthxgEIXpc.nKHKpgTSVU(5776) + array3[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(11502)].ToString();
						}
						DataRow[] array4 = FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(this.jpMeqgA5CG, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11488), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow3, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11428)).ToString()));
						goto IL_9E;
						IL_124:
						goto IL_134;
						IL_D4:
						FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow4, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(544), FormJournalRequestForRepairAddEdit.qK3BLfnU0lFVrvHNSux(array4[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512)].ToString(), cDhluYseFOthxgEIXpc.nKHKpgTSVU(5776), array4[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(11502)].ToString()));
						goto IL_124;
						IL_9E:
						if (array4.Length != 0)
						{
							num6 = 4;
							goto IL_262;
						}
						IL_134:
						this.bgxnjGgfZD.Rows.Add(dataRow4);
						num6 = 8;
						goto IL_262;
					}
				}
				finally
				{
					if (enumerator3 != null)
					{
						FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(enumerator3);
					}
				}
				list = new List<int>();
				enumerator = FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.bgxnjGgfZD).GetEnumerator();
				goto IL_5A0;
				IL_365:
				if (this.KOseX49R7b != null)
				{
					goto IL_68;
				}
				this.KOseX49R7b = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10694));
				num = 9;
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000154E0 File Offset: 0x000138E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void avQgwXctpp(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			for (;;)
			{
				gQW17mt4mbf8QpRu2s gQW17mt4mbf8QpRu2s;
				switch (num)
				{
				case 0:
					goto IL_248;
				case 1:
				case 3:
					FormJournalRequestForRepairAddEdit.q0UdAL23wKqW9mhdvH8(gQW17mt4mbf8QpRu2s, FormJournalRequestForRepairAddEdit.MYEP83XkI141am7o5YR(this));
					goto IL_24;
				case 2:
					goto IL_24;
				case 4:
					break;
				case 5:
					gQW17mt4mbf8QpRu2s = new gQW17mt4mbf8QpRu2s();
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 0;
						continue;
					}
					num = 3;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					break;
				case 6:
					return;
				default:
					num = 4;
					continue;
				}
				IL_56:
				using (IEnumerator enumerator = gQW17mt4mbf8QpRu2s.H260dH6yRC.Rows.GetEnumerator())
				{
					IL_211:
					while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						int num2 = 0;
						if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							goto IL_88;
						}
						for (;;)
						{
							IL_168:
							DataRow dataRow2;
							switch (num2)
							{
							case 0:
								goto IL_88;
							case 1:
							case 2:
								goto IL_1A1;
							case 3:
								goto IL_1E1;
							case 4:
								goto IL_1F1;
							case 5:
								FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11380), dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11380)]);
								break;
							case 6:
								goto IL_211;
							}
							if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
								num2 = 4;
								continue;
							}
							num2 = 1;
							if (false)
							{
								goto IL_1A1;
							}
							continue;
							IL_1F1:
							FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepairAddress).Add(dataRow2);
							num2 = 6;
							continue;
							IL_1E1:
							goto IL_1F1;
							IL_1A1:
							dataRow2[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11428)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10744));
							FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8042), dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8042)]);
							goto IL_1E1;
						}
						IL_88:
						if (FormJournalRequestForRepairAddEdit.jVd3R4rLSNpv4WDN18y(this.y7feOpIJtI).Select(FormJournalRequestForRepairAddEdit.aawCN52W0XO1lRGptcJ(new string[]
						{
							FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11286),
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(11322)].ToString(),
							FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11342),
							dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8042)].ToString(),
							FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11374)
						})).Length == 0)
						{
							DataRow dataRow2 = FormJournalRequestForRepairAddEdit.IYu1wAXJcSSaZmFv72P(this.y7feOpIJtI.tJ_RequestForRepairAddress);
							FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678), this.abEgNyD5Y6);
							num2 = 5;
							goto IL_168;
						}
					}
				}
				this.DbfgPWaf8k();
				num = 6;
				continue;
				IL_248:
				if (gQW17mt4mbf8QpRu2s.ShowDialog() == DialogResult.OK)
				{
					goto IL_56;
				}
				break;
				IL_24:
				goto IL_248;
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0001579C File Offset: 0x00013B9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void fP9g5jvweG(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
			}
			for (;;)
			{
				IL_1B6:
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 3:
					if (MessageBox.Show(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11580), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11682), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						goto IL_44;
					}
					return;
				case 2:
					goto IL_44;
				case 4:
					while (FormJournalRequestForRepairAddEdit.ROHcEo2Ld6KZNtlweMd(this.btQJgjaEtV.SelectedRows) > 0)
					{
						FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
						if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							num = 3;
							goto IL_1B6;
						}
						num = 5;
						if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							goto IL_1B6;
						}
					}
					return;
				case 5:
					goto IL_193;
				case 6:
					return;
				default:
					num = 0;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						return;
					}
					continue;
				}
				IEnumerator enumerator;
				try
				{
					IL_8A:
					IL_15F:
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						int num2 = FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.Q1PIoVrArSunLIIFWj5(((DataGridViewRow)obj2).Cells[this.LAVJMoZ4gI.Name]));
						int num3 = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 1 : 4;
						for (;;)
						{
							DataRow[] array;
							switch (num3)
							{
							case 0:
							case 4:
								array = FormJournalRequestForRepairAddEdit.jVd3R4rLSNpv4WDN18y(this.y7feOpIJtI).Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(11488) + num2.ToString());
								num3 = 3;
								if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
								{
									continue;
								}
								break;
							case 3:
								if (array.Length == 0)
								{
									goto IL_15F;
								}
								break;
							case 5:
								goto IL_15F;
							}
							IL_107:
							array[0].Delete();
							num3 = 5;
							continue;
							goto IL_107;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				this.DbfgPWaf8k();
				num = 6;
				continue;
				IL_193:
				enumerator = this.btQJgjaEtV.SelectedRows.GetEnumerator();
				goto IL_8A;
				IL_44:
				goto IL_193;
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000159A0 File Offset: 0x00013DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void jUfg9utKNP()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
				{
					IEnumerator<E1YGNRmqUpG01b1DWc.LOpcT5sKlE3fdjQXH5N> enumerator = this.y7feOpIJtI.tJ_RequestForRepairAddress.GetEnumerator();
					num = 1;
					continue;
				}
				case 1:
					try
					{
						IL_C6:
						IEnumerator<E1YGNRmqUpG01b1DWc.LOpcT5sKlE3fdjQXH5N> enumerator;
						while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
						{
							DataRow dataRow = enumerator.Current;
							int num2 = 0;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
									{
										num2 = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 3 : 4);
										continue;
									}
									goto IL_C6;
								case 1:
								case 4:
									dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5678)] = this.abEgNyD5Y6;
									break;
								case 5:
									goto IL_C6;
								}
								IL_B6:
								FormJournalRequestForRepairAddEdit.YBxsONrTuyEDg9Cw8CA(dataRow);
								num2 = 5;
								continue;
								goto IL_B6;
							}
						}
					}
					finally
					{
						IEnumerator<E1YGNRmqUpG01b1DWc.LOpcT5sKlE3fdjQXH5N> enumerator;
						if (enumerator != null)
						{
							FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(enumerator);
						}
					}
					base.InsertSqlData(this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.jVd3R4rLSNpv4WDN18y(this.y7feOpIJtI));
					base.UpdateSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairAddress);
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 5 : 4);
					continue;
				case 2:
				case 4:
					base.DeleteSqlData(this.y7feOpIJtI, this.y7feOpIJtI.tJ_RequestForRepairAddress);
					break;
				case 6:
					return;
				}
				IL_1A3:
				FormJournalRequestForRepairAddEdit.PkFuMSnjRjtVa9aAl9k(this.y7feOpIJtI).AcceptChanges();
				num = 6;
				continue;
				goto IL_1A3;
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00015B7C File Offset: 0x00013F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void YQrg2wn9R8()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
			{
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 1:
				case 8:
					if (this.ffsghkQnr5 == eActionRequestRepair.Read)
					{
						num = 9;
						continue;
					}
					if (FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows.Count <= 0)
					{
						FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.gJsJPJ7k5A, false);
						num = 10;
						continue;
					}
					if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows, 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)) == DBNull.Value)
					{
						goto IL_1E3;
					}
					num = 3;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_89;
					}
					continue;
				case 2:
					goto IL_206;
				case 3:
					break;
				case 4:
					goto IL_129;
				case 5:
					if (this.cs3eIKVCEg)
					{
						goto IL_22;
					}
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 8;
						continue;
					}
					num = 0;
					if (false)
					{
						goto IL_129;
					}
					continue;
				case 6:
					goto IL_89;
				case 7:
					return;
				case 9:
					goto IL_22;
				case 10:
					return;
				default:
					num = 2;
					if (true)
					{
						continue;
					}
					break;
				}
				if (!Convert.ToBoolean(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI)), 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5526)]))
				{
					goto IL_1D6;
				}
				num = 4;
				if (!true)
				{
					return;
				}
				continue;
				IL_206:
				if (FormJournalRequestForRepairAddEdit.jSgH4onRAFMXGvcH2Fh(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0)) == DataRowState.Unchanged)
				{
					num = 6;
					continue;
				}
				goto IL_10B;
				IL_129:
				if (FormJournalRequestForRepairAddEdit.jSgH4onRAFMXGvcH2Fh(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI))[0]) != DataRowState.Modified)
				{
					goto IL_206;
				}
				goto IL_89;
			}
			IL_22:
			FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.gJsJPJ7k5A, false);
			return;
			IL_89:
			if (FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepair), 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136), DataRowVersion.Original] != DBNull.Value && FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136), DataRowVersion.Original]))
			{
				FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.gJsJPJ7k5A, false);
				return;
			}
			FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.gJsJPJ7k5A, true);
			return;
			IL_10B:
			FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.gJsJPJ7k5A, true);
			return;
			IL_1D6:
			this.gJsJPJ7k5A.Enabled = false;
			return;
			IL_1E3:
			FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.gJsJPJ7k5A, false);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00015DF4 File Offset: 0x000141F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void xaKgAPDTQB()
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.cs3eIKVCEg)
			{
				try
				{
					MdBMOhVqRSHesLq1WY.iOIMjP7Kww(this.SqlSettings);
					switch (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 3 : 2)
					{
					case 0:
					case 2:
						FormJournalRequestForRepairAddEdit.NjFnm12jOVHAk2usrXp(this.SqlSettings, MdBMOhVqRSHesLq1WY.DmjMGE8HcI(), DateTime.Now);
						break;
					}
					MdBMOhVqRSHesLq1WY.IW0MNKrxsS();
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
				G868F8PfVDPhiDtMmF.qCF8qpg2Wt(FormJournalRequestForRepairAddEdit.MYEP83XkI141am7o5YR(this));
				FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
				int num;
				if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					num = 3;
					goto IL_132;
				}
				num = 2;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					goto IL_132;
				}
				IL_D4:
				FormJournalRequestForRepairAddEdit.YBYoGb2XXI1iU9OtJyi(FormJournalRequestForRepairAddEdit.MYEP83XkI141am7o5YR(this), G868F8PfVDPhiDtMmF.Ey28X7YZCv(), FormJournalRequestForRepairAddEdit.fpu0vrXOM4IyU9rHHoe().Date, FormJournalRequestForRepairAddEdit.fpu0vrXOM4IyU9rHHoe().Date.AddDays(8.0).AddMilliseconds(-1.0));
				goto IL_147;
				IL_132:
				switch (num)
				{
				case 0:
				case 2:
					goto IL_D4;
				}
				IL_147:
				G868F8PfVDPhiDtMmF.AtP8srTQCY();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11702), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00015F9C File Offset: 0x0001439C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void YEmgVGelHs(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			new FormSettingsSender
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00015FD0 File Offset: 0x000143D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ncKgKECfGZ()
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
			int num = (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 2 : 1;
			for (;;)
			{
				DataTable dataTable;
				switch (num)
				{
				case 0:
				case 1:
					if (this.abEgNyD5Y6 == -1)
					{
						num = 6;
						continue;
					}
					dataTable = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11738));
					num = 5;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_A2;
					}
					continue;
				case 2:
					break;
				case 3:
					goto IL_28;
				case 4:
					break;
				case 5:
					goto IL_A2;
				case 6:
					return;
				case 7:
					return;
				default:
					num = 3;
					continue;
				}
				IL_11E:
				this.OcuJaJU1lF.Enabled = false;
				num = 7;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					return;
				}
				continue;
				IL_71:
				goto IL_11E;
				IL_28:
				base.SelectSqlData(dataTable, true, FormJournalRequestForRepairAddEdit.qK3BLfnU0lFVrvHNSux(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11760), this.abEgNyD5Y6.ToString(), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11812)), null, false, 0);
				if (dataTable.Rows.Count > 0)
				{
					goto IL_71;
				}
				return;
				IL_A2:
				dataTable.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
				goto IL_28;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00016118 File Offset: 0x00014518
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CQhgQ5g7jf()
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
			int num;
			if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (false)
				{
					return;
				}
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 4:
					if (this.abEgNyD5Y6 == -1)
					{
						goto IL_34;
					}
					if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format(cDhluYseFOthxgEIXpc.nKHKpgTSVU(11848), this.abEgNyD5Y6)))) > 0)
					{
						num = 2;
						continue;
					}
					return;
				case 1:
					goto IL_34;
				case 2:
					FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.VkYerU8Qhx, false);
					break;
				case 3:
					return;
				case 5:
					break;
				case 6:
					return;
				default:
					num = 5;
					if (false)
					{
						return;
					}
					continue;
				}
				this.dSOeiWZtIs.ReadOnly = true;
				this.rWoeDxUpjP.Enabled = false;
				num = 6;
			}
			IL_34:;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00016220 File Offset: 0x00014620
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool e3ZgSZPFhN()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 1 : 2;
			for (;;)
			{
				E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc;
				switch (num)
				{
				case 0:
				case 2:
					if (this.abEgNyD5Y6 == -1)
					{
						num = 3;
						continue;
					}
					if (!this.PSpgGiFBsn())
					{
						num = 6;
						if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							continue;
						}
						continue;
					}
					else
					{
						e1YGNRmqUpG01b1DWc = new E1YGNRmqUpG01b1DWc();
						num = 5;
						if (false)
						{
							goto Block_8;
						}
						continue;
					}
					break;
				case 3:
					return true;
				case 5:
					FormJournalRequestForRepairAddEdit.IbnHWbrWWsUIXRa2EJl(this, e1YGNRmqUpG01b1DWc, FormJournalRequestForRepairAddEdit.egqnDm2rPfAXSQxyGs6(e1YGNRmqUpG01b1DWc), true, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13292), this.abEgNyD5Y6.ToString()));
					base.SelectSqlData(e1YGNRmqUpG01b1DWc, e1YGNRmqUpG01b1DWc.tL_RequestForRepairSchmObjList, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5468) + this.abEgNyD5Y6.ToString());
					if (!this.rWoeDxUpjP.Checked)
					{
						return true;
					}
					break;
				case 6:
					return true;
				case 7:
				{
					IEnumerator<E1YGNRmqUpG01b1DWc.HdrwQSvpZhDcM6kbie> enumerator = e1YGNRmqUpG01b1DWc.tL_RequestForRepairSchmObjList.GetEnumerator();
					num = 8;
					continue;
				}
				case 8:
					goto IL_300;
				}
				IL_11F:
				using (IEnumerator<E1YGNRmqUpG01b1DWc.vbkxdesYZtbMG08nJRv> enumerator2 = e1YGNRmqUpG01b1DWc.tJ_Damage.GetEnumerator())
				{
					while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator2))
					{
						DataRow dataRow = enumerator2.Current;
						if (!Convert.ToBoolean(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(13342))) && e1YGNRmqUpG01b1DWc.tL_RequestForRepairSchmObjList.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13360) + FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)).ToString()).Length == 0)
						{
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5118)] = true;
							FormJournalRequestForRepairAddEdit.YBxsONrTuyEDg9Cw8CA(dataRow);
							FormJournalRequestForRepairAddEdit.RcZTRir7akLPgPuD9hT(this, e1YGNRmqUpG01b1DWc, e1YGNRmqUpG01b1DWc.tJ_Damage);
							E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc2 = new E1YGNRmqUpG01b1DWc();
							base.SelectSqlData(e1YGNRmqUpG01b1DWc2, e1YGNRmqUpG01b1DWc2.tJ_Damage, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(13388) + dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6146)].ToString());
							IEnumerator<E1YGNRmqUpG01b1DWc.vbkxdesYZtbMG08nJRv> enumerator3 = e1YGNRmqUpG01b1DWc2.tJ_Damage.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									E1YGNRmqUpG01b1DWc.vbkxdesYZtbMG08nJRv vbkxdesYZtbMG08nJRv = enumerator3.Current;
									vbkxdesYZtbMG08nJRv[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5118)] = true;
									FormJournalRequestForRepairAddEdit.YBxsONrTuyEDg9Cw8CA(vbkxdesYZtbMG08nJRv);
									FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
									switch ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 2)
									{
									case 0:
									case 2:
										base.UpdateSqlData(e1YGNRmqUpG01b1DWc2, e1YGNRmqUpG01b1DWc2.tJ_Damage);
										break;
									}
								}
							}
							finally
							{
								if (enumerator3 != null)
								{
									FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(enumerator3);
								}
							}
						}
					}
				}
				FormJournalRequestForRepairAddEdit.IbnHWbrWWsUIXRa2EJl(this, e1YGNRmqUpG01b1DWc, e1YGNRmqUpG01b1DWc.tJ_Damage, true, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13292), this.abEgNyD5Y6.ToString()));
				num = 7;
				continue;
				goto IL_11F;
			}
			return true;
			Block_8:
			try
			{
				IL_300:
				IL_3E4:
				IEnumerator<E1YGNRmqUpG01b1DWc.HdrwQSvpZhDcM6kbie> enumerator;
				while (enumerator.MoveNext())
				{
					DataRow dataRow2 = enumerator.Current;
					int num2 = (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 2;
					DataRow[] array;
					for (;;)
					{
						IL_375:
						switch (num2)
						{
						case 0:
						case 2:
							goto IL_3A2;
						case 1:
							break;
						case 3:
							break;
						case 4:
							goto IL_324;
						case 5:
							goto IL_3E4;
						default:
							num2 = 4;
							if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								goto IL_3A2;
							}
							continue;
						}
						IL_351:
						while (array.Length == 0)
						{
							this.sp9gfuYOeI(Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8418))));
							num2 = 5;
							if (true)
							{
								goto IL_375;
							}
						}
						goto Block_22;
						IL_3D4:
						goto IL_351;
						IL_3A2:
						E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc;
						array = FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(e1YGNRmqUpG01b1DWc.tJ_Damage, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13360), dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)].ToString()));
						goto IL_3D4;
					}
					IL_324:
					continue;
					Block_22:
					this.N0ogkLMNK1(array[0]);
				}
			}
			finally
			{
				IEnumerator<E1YGNRmqUpG01b1DWc.HdrwQSvpZhDcM6kbie> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return true;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00016680 File Offset: 0x00014A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void N0ogkLMNK1(DataRow \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 6;
			for (;;)
			{
				E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc;
				bool flag;
				switch (num)
				{
				case 0:
					this.ETNgTDSfr2(Convert.ToInt32(\u0020[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6146)]), FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepairDaily)[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056))), Convert.ToInt32(\u0020[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8418)]));
					num = 10;
					continue;
				case 1:
					break;
				case 2:
					goto IL_35D;
				case 3:
				{
					IEnumerator<E1YGNRmqUpG01b1DWc.vbkxdesYZtbMG08nJRv> enumerator = e1YGNRmqUpG01b1DWc.tJ_Damage.GetEnumerator();
					try
					{
						IL_1AE:
						while (enumerator.MoveNext())
						{
							DataRow dataRow = enumerator.Current;
							FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
							int num2;
							if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
								num2 = 4;
								if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
								{
									goto IL_119;
								}
							}
							else
							{
								num2 = 3;
								if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
								{
								}
							}
							for (;;)
							{
								IL_179:
								switch (num2)
								{
								case 0:
								case 4:
									goto IL_119;
								case 1:
									goto IL_133;
								case 2:
									goto IL_1A2;
								case 3:
									goto IL_14D;
								case 5:
									goto IL_1AE;
								default:
									num2 = 2;
									if (false)
									{
										goto IL_1A2;
									}
									break;
								}
							}
							IL_119:
							if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13426)) == DBNull.Value)
							{
								continue;
							}
							IL_14D:
							if (FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13426)]))
							{
								goto IL_1A2;
							}
							continue;
							IL_133:
							goto IL_14D;
							IL_1A2:
							flag = true;
							num2 = 5;
							goto IL_179;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(enumerator);
						}
					}
					if (flag)
					{
						return;
					}
					\u0020[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13342)] = 0;
					\u0020[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13444)] = FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepairDaily.Rows, 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056)];
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 7;
						continue;
					}
					num = 2;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_35D;
					}
					continue;
				}
				case 4:
				case 7:
					goto IL_2BE;
				default:
					goto IL_347;
				case 6:
					if (\u0020[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13426)] == DBNull.Value)
					{
						goto IL_395;
					}
					num = 8;
					if (true)
					{
						continue;
					}
					break;
				case 8:
					if (Convert.ToBoolean(\u0020[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13426)]))
					{
						return;
					}
					goto IL_395;
				case 9:
				{
					IEnumerator<E1YGNRmqUpG01b1DWc.vbkxdesYZtbMG08nJRv> enumerator = e1YGNRmqUpG01b1DWc.tJ_Damage.GetEnumerator();
					try
					{
						while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
						{
							E1YGNRmqUpG01b1DWc.vbkxdesYZtbMG08nJRv vbkxdesYZtbMG08nJRv = enumerator.Current;
							vbkxdesYZtbMG08nJRv[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13444)] = FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(this.y7feOpIJtI.tJ_RequestForRepairDaily)[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056)];
							vbkxdesYZtbMG08nJRv.EndEdit();
						}
					}
					finally
					{
						if (enumerator != null)
						{
							FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(enumerator);
						}
					}
					base.UpdateSqlData(e1YGNRmqUpG01b1DWc.tJ_Damage);
					num = 0;
					if (!true)
					{
						goto IL_2BE;
					}
					continue;
				}
				case 10:
					return;
				}
				base.SelectSqlData(e1YGNRmqUpG01b1DWc, e1YGNRmqUpG01b1DWc.tJ_Damage, true, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13388), \u0020[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6146)].ToString()));
				flag = false;
				num = 3;
				continue;
				IL_35D:
				\u0020.EndEdit();
				base.UpdateSqlDataOnlyChange(\u0020.Table);
				num = 9;
				continue;
				IL_347:
				goto IL_35D;
				IL_2BE:
				this.Qfvg6R27an(\u0020, FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Rows, 0)[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8056)]), Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(\u0020, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8418))));
				goto IL_347;
				IL_395:
				e1YGNRmqUpG01b1DWc = new E1YGNRmqUpG01b1DWc();
				num = 1;
				if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					return;
				}
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00016A54 File Offset: 0x00014E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void sp9gfuYOeI(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 0:
					goto IL_91;
				case 1:
				case 4:
				{
					DataRow dataRow;
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13540)] = false;
					this.Qfvg6R27an(dataRow, Convert.ToDateTime(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI))[0], FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8056))), \u0020);
					E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc;
					FormJournalRequestForRepairAddEdit.egqnDm2rPfAXSQxyGs6(e1YGNRmqUpG01b1DWc).Rows.Add(dataRow);
					num = 3;
					continue;
				}
				case 2:
				{
					DataRow dataRow;
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8418), \u0020);
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13508)] = this.abEgNyD5Y6;
					break;
				}
				case 3:
				{
					E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc;
					num2 = base.InsertSqlDataOneRow(e1YGNRmqUpG01b1DWc, e1YGNRmqUpG01b1DWc.tJ_Damage);
					goto IL_26;
				}
				case 5:
				{
					E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc = new E1YGNRmqUpG01b1DWc();
					num = 8;
					continue;
				}
				case 6:
					goto IL_26;
				case 7:
				{
					DataRow dataRow;
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(13444), FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Rows[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056)]);
					num = 2;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				}
				case 8:
				{
					E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc;
					DataRow dataRow = FormJournalRequestForRepairAddEdit.egqnDm2rPfAXSQxyGs6(e1YGNRmqUpG01b1DWc).NewRow();
					dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13462)] = FormJournalRequestForRepairAddEdit.Th6DxQXzbtWFQauQXvK(this.y7feOpIJtI).Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13480)];
					num = 7;
					continue;
				}
				case 9:
					return;
				}
				goto IL_144;
				IL_91:
				if (num2 > 0)
				{
					this.ETNgTDSfr2(num2, Convert.ToDateTime(this.y7feOpIJtI.tJ_RequestForRepairDaily.Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8056)]), \u0020);
					num = 9;
					continue;
				}
				break;
				IL_26:
				goto IL_91;
				IL_144:
				num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 0 : 1);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00016C68 File Offset: 0x00015068
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Qfvg6R27an(DataRow \u0020, DateTime \u0020, int \u0020)
		{
			while (false)
			{
				object obj4 = null[0];
			}
			int num = 1;
			if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
			{
				goto Block_2;
			}
			List<ElectricObject> list;
			DataTable dataTable;
			for (;;)
			{
				IL_2A5:
				switch (num)
				{
				case 0:
				{
					IEnumerable<ElectricObject> source = this.oE9eseB0lU.Objects.Where(delegate(ElectricObject obj)
					{
						while (false)
						{
							object obj5 = null[0];
						}
						return obj.Id == <>c__DisplayClass114_.idSchmObj;
					});
					list = this.oE9eseB0lU.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
					if (FormJournalRequestForRepairAddEdit.Y8bVCg22NrhEi5n7PKy(list) <= 0)
					{
						dataTable.Clear();
						goto IL_263;
					}
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 8;
						continue;
					}
					num = 3;
					if (false)
					{
						return;
					}
					continue;
				}
				case 1:
					num = 9;
					continue;
				case 2:
					goto IL_2F3;
				case 3:
				case 4:
					goto IL_283;
				case 5:
					goto IL_1E;
				case 6:
					goto IL_140;
				case 7:
					goto IL_263;
				case 8:
					goto IL_2F3;
				case 9:
					break;
				case 10:
					return;
				default:
					num = 5;
					if (!false)
					{
						continue;
					}
					break;
				}
				<>c__DisplayClass114_.idSchmObj = \u0020;
				num = 6;
				continue;
				IL_2F3:
				this.FEjgpaiskE(\u0020, dataTable);
				num = 10;
				continue;
				IL_263:
				goto IL_2F3;
			}
			IL_283:
			string text = "";
			List<ElectricObject>.Enumerator enumerator = list.GetEnumerator();
			Block_2:
			try
			{
				IL_1E:
				IL_DF:
				while (enumerator.MoveNext())
				{
					ElectricObject electricObject = enumerator.Current;
					int num2 = 0;
					int num3;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (FormJournalRequestForRepairAddEdit.frGxQ1rVyhal7bXRk7u(text))
							{
								num3 = electricObject.Id;
								FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
								num2 = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 4);
							}
							else
							{
								object obj2 = text;
								object obj3 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(10764);
								num3 = FormJournalRequestForRepairAddEdit.CbJpmqnDB1qgAwnievG(electricObject);
								text = FormJournalRequestForRepairAddEdit.qK3BLfnU0lFVrvHNSux(obj2, obj3, num3.ToString());
								num2 = 5;
							}
							break;
						case 1:
						case 4:
							goto IL_97;
						default:
							goto IL_CF;
						case 3:
							goto IL_65;
						case 5:
							goto IL_DF;
						}
					}
					IL_65:
					IL_CF:
					continue;
					IL_97:
					text = num3.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			new SqlDataCommand(this.SqlSettings).SelectSqlData(dataTable, true, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13618) + text + cDhluYseFOthxgEIXpc.nKHKpgTSVU(13664), new int?(0), false, 0);
			num = 2;
			if (!false)
			{
				goto IL_2A5;
			}
			IL_140:
			int num4 = FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(13480)]);
			if (this.oE9eseB0lU == null || this.oE9eseB0lU.Objects.Count<ElectricObject>() == 0)
			{
				this.oE9eseB0lU = new ElectricModel();
				FormJournalRequestForRepairAddEdit.M3VJuC2n5EjFl9TrMYZ(this.oE9eseB0lU, this.SqlSettings);
				this.oE9eseB0lU.LoadSchema(\u0020);
			}
			TreeNodeObj \u00202 = this.oE9eseB0lU.PoweringReportForDrawObject(<>c__DisplayClass114_.idSchmObj, true);
			List<int> \u00203 = new List<int>();
			FormJournalRequestForRepairAddEdit.j0BgdCCvk8(\u00202, \u00203);
			if (num4 == 1402)
			{
				DataTable \u00204 = FormJournalRequestForRepairAddEdit.DwDgUCgs0j(\u00203, this.SqlSettings);
				this.B98gtXXEJ8(\u0020, \u00204, \u00202);
			}
			dataTable = new DataTable(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13552));
			FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(dataTable).Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13584), Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777219)));
			dataTable.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13598), Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777219)));
			num = 0;
			goto IL_2A5;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00016FE8 File Offset: 0x000153E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ETNgTDSfr2(int \u0020, DateTime \u0020, int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			E1YGNRmqUpG01b1DWc e1YGNRmqUpG01b1DWc;
			DataRow dataRow2;
			for (;;)
			{
				switch (num)
				{
				case 0:
				{
					int num2 = Convert.ToInt32(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(this.y7feOpIJtI.tJ_RequestForRepair.Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(13480)));
					e1YGNRmqUpG01b1DWc = new E1YGNRmqUpG01b1DWc();
					if (num2 == 1402)
					{
						base.SelectSqlData(FormJournalRequestForRepairAddEdit.zgkGf12THQMbsJ9RJ5Z(e1YGNRmqUpG01b1DWc), true, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13876), \u0020.ToString()), null, false, 0);
						DataRow dataRow;
						if (FormJournalRequestForRepairAddEdit.zgkGf12THQMbsJ9RJ5Z(e1YGNRmqUpG01b1DWc).Rows.Count > 0)
						{
							dataRow = FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(e1YGNRmqUpG01b1DWc.tJ_DamageHV.Rows, 0);
						}
						else
						{
							dataRow = e1YGNRmqUpG01b1DWc.tJ_DamageHV.NewRow();
							FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(13914), \u0020);
						}
						if (this.oE9eseB0lU == null || this.oE9eseB0lU.Objects.Count<ElectricObject>() == 0)
						{
							this.oE9eseB0lU = new ElectricModel();
							this.oE9eseB0lU.SqlSettings = FormJournalRequestForRepairAddEdit.MYEP83XkI141am7o5YR(this);
							this.oE9eseB0lU.LoadSchema(\u0020);
						}
						TreeNodeObj \u00202 = FormJournalRequestForRepairAddEdit.H9Wlfo2HJYiFlwml8tU(this.oE9eseB0lU, \u0020, true);
						List<int> \u00203 = new List<int>();
						FormJournalRequestForRepairAddEdit.j0BgdCCvk8(\u00202, \u00203);
						DataTable dataTable = FormJournalRequestForRepairAddEdit.DwDgUCgs0j(\u00203, this.SqlSettings);
						dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13934)] = dataTable.Rows.Count;
						FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13962), 0);
						dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13996)] = FormJournalRequestForRepairAddEdit.gFMvyw2l22drhopM3rc(dataTable, cDhluYseFOthxgEIXpc.nKHKpgTSVU(14028), "");
						dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(14052)] = dataTable.Compute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14068), "");
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(14090)) == DBNull.Value)
						{
							FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(14090), 0.9);
						}
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(14106)) == DBNull.Value)
						{
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14106)] = 0.8;
						}
						if (e1YGNRmqUpG01b1DWc.tJ_DamageHV.Rows.Count > 0)
						{
							dataRow.EndEdit();
							base.UpdateSqlDataOnlyChange(FormJournalRequestForRepairAddEdit.zgkGf12THQMbsJ9RJ5Z(e1YGNRmqUpG01b1DWc));
						}
						else
						{
							FormJournalRequestForRepairAddEdit.HwGAmXr3WG5y8RIbsRA(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(FormJournalRequestForRepairAddEdit.zgkGf12THQMbsJ9RJ5Z(e1YGNRmqUpG01b1DWc)), dataRow);
							base.InsertSqlData(e1YGNRmqUpG01b1DWc.tJ_DamageHV);
						}
					}
					if (num2 == 1401)
					{
						num = 1;
						continue;
					}
					return;
				}
				case 1:
					base.SelectSqlData(e1YGNRmqUpG01b1DWc.tJ_DamageLV, true, FormJournalRequestForRepairAddEdit.VDHQJKXZkBxwfWwMFkj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13876), \u0020.ToString()), null, false, 0);
					num = 2;
					continue;
				case 2:
					if (e1YGNRmqUpG01b1DWc.tJ_DamageLV.Rows.Count > 0)
					{
						dataRow2 = e1YGNRmqUpG01b1DWc.tJ_DamageLV.Rows[0];
						num = 3;
						continue;
					}
					dataRow2 = e1YGNRmqUpG01b1DWc.tJ_DamageLV.NewRow();
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13914), \u0020);
					break;
				case 3:
					break;
				case 4:
				case 6:
					goto IL_290;
				case 5:
					goto IL_297;
				case 7:
					goto IL_314;
				case 8:
					return;
				default:
					IL_3C5:
					FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
					num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 7 : 6);
					continue;
				}
				if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(e1YGNRmqUpG01b1DWc.tJ_DamageLV)) > 0)
				{
					goto IL_3C5;
				}
				e1YGNRmqUpG01b1DWc.tJ_DamageLV.Rows.Add(dataRow2);
				base.InsertSqlData(e1YGNRmqUpG01b1DWc.tJ_DamageLV);
				num = 8;
			}
			IL_290:
			FormJournalRequestForRepairAddEdit.YBxsONrTuyEDg9Cw8CA(dataRow2);
			IL_297:
			IL_314:
			FormJournalRequestForRepairAddEdit.Q8DijC27W05IjUsgkxQ(this, e1YGNRmqUpG01b1DWc.tJ_DamageLV);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000173D4 File Offset: 0x000157D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void j0BgdCCvk8(TreeNodeObj \u0020, List<int> \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			if (\u0020.Tag != null && \u0020.Tag is ElectricLine)
			{
				foreach (ElectricRelation electricRelation in ((ElectricLine)\u0020.Tag).Relations)
				{
					foreach (ElectricObject electricObject in electricRelation.ChildObjects)
					{
						if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && !\u0020.Contains(electricObject.Id))
						{
							\u0020.Add(electricObject.Id);
						}
					}
				}
			}
			foreach (TreeNodeObj \u00202 in \u0020.Nodes)
			{
				FormJournalRequestForRepairAddEdit.j0BgdCCvk8(\u00202, \u0020);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00017520 File Offset: 0x00015920
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static DataTable DwDgUCgs0j(List<int> \u0020, SQLSettings \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14130), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
			dataTable.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14142), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
			dataTable.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14158), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
			dataTable.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14172), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
			dataTable.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14182), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
			dataTable.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14196), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
			dataTable.Clear();
			using (SqlConnection sqlConnection = new SqlConnection(\u0020.GetConnectionString() + cDhluYseFOthxgEIXpc.nKHKpgTSVU(14208)))
			{
				sqlConnection.Open();
				using (SqlCommand sqlCommand = new SqlCommand(bXh6yYHrM4qGkEZ15n.lCjMFOF2qj(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14260)), sqlConnection))
				{
					sqlCommand.CommandTimeout = 0;
					DataTable dataTable2 = new DataTable();
					new SqlDataAdapter(sqlCommand).Fill(dataTable2);
					int num = 0;
					foreach (int num2 in \u0020)
					{
						DataRow[] array = dataTable2.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(11488) + num2.ToString());
						if (array.Length != 0)
						{
							DataRow dataRow = dataTable.NewRow();
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14362)] = array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146)];
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14374)] = array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14390)];
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14158)] = array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14158)];
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14172)] = array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14418)];
							if (array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14446)] != DBNull.Value && !string.IsNullOrEmpty(array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14446)].ToString()))
							{
								dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14182)] = array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14446)];
							}
							if (array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14446)] != DBNull.Value && !string.IsNullOrEmpty(array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14446)].ToString()))
							{
								num += Convert.ToInt32(array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14446)]);
							}
							dataTable.Rows.Add(dataRow);
						}
					}
				}
				using (SqlCommand sqlCommand2 = new SqlCommand(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14466), sqlConnection))
				{
					sqlCommand2.CommandTimeout = 0;
					DataTable dataTable3 = new DataTable();
					new SqlDataAdapter(sqlCommand2).Fill(dataTable3);
					foreach (object obj2 in dataTable.Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						DataRow[] array2 = dataTable3.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18496) + dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14130)].ToString());
						if (array2.Length != 0)
						{
							dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(18524)] = array2[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(18536)];
						}
					}
				}
			}
			return dataTable;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000179B4 File Offset: 0x00015DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void B98gtXXEJ8(DataRow \u0020, DataTable \u0020, TreeNodeObj \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 0;
			for (;;)
			{
				IL_315:
				XmlDocument xmlDocument;
				XmlNode xmlNode;
				XmlNode xmlNode2;
				switch (num)
				{
				case 0:
					xmlDocument = new XmlDocument();
					num = 6;
					continue;
				case 1:
				case 2:
					try
					{
						xmlDocument.LoadXml(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(\u0020, cDhluYseFOthxgEIXpc.nKHKpgTSVU(18542)).ToString());
					}
					catch
					{
					}
					goto IL_3B0;
				case 3:
					goto IL_2A7;
				case 4:
					xmlNode.AppendChild(xmlNode2);
					goto IL_54;
				case 5:
					while (xmlNode2 == null)
					{
						xmlNode2 = xmlDocument.CreateElement(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18576));
						num = 4;
						if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							goto IL_315;
						}
					}
					goto IL_2D1;
				case 6:
					if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(\u0020, cDhluYseFOthxgEIXpc.nKHKpgTSVU(18542)) == DBNull.Value)
					{
						goto IL_3B0;
					}
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 3;
						continue;
					}
					num = 1;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 7:
					IL_297:
					goto IL_2A7;
				case 8:
					goto IL_2D1;
				case 9:
					xmlNode = xmlDocument.CreateElement(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18566));
					FormJournalRequestForRepairAddEdit.vUJud3nN7tCtRRxujuS(xmlDocument, xmlNode);
					break;
				case 10:
					return;
				default:
					num = 8;
					continue;
				}
				IL_31:
				xmlNode2 = xmlNode.SelectSingleNode(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18576));
				num = 5;
				continue;
				IL_2A7:
				XmlNode xmlNode3;
				this.KMwgD1pMt8(xmlNode3, \u0020, \u0020, null);
				\u0020[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18542)] = xmlDocument.InnerXml;
				num = 10;
				continue;
				IL_54:
				using (IEnumerator enumerator = FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(\u0020).GetEnumerator())
				{
					IL_24A:
					while (FormJournalRequestForRepairAddEdit.lVaHCGXx2JoJdsg5mVW(enumerator))
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						int num2 = 8;
						for (;;)
						{
							XmlNode xmlNode4;
							XmlAttribute xmlAttribute;
							switch (num2)
							{
							case 0:
							case 4:
								goto IL_15A;
							case 1:
								goto IL_186;
							case 2:
								goto IL_122;
							case 3:
								xmlNode4.Attributes.Append(xmlAttribute);
								num2 = 9;
								if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
								{
									continue;
								}
								continue;
							case 5:
								goto IL_16C;
							case 6:
								xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14182));
								xmlAttribute.Value = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14182)].ToString();
								xmlNode4.Attributes.Append(xmlAttribute);
								break;
							case 7:
								xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(xmlDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(14130));
								num2 = 2;
								if (false)
								{
									goto IL_122;
								}
								continue;
							case 8:
								xmlNode4 = xmlDocument.CreateElement(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18596));
								xmlNode2.AppendChild(xmlNode4);
								xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(xmlDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(14158));
								xmlAttribute.Value = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14158)].ToString();
								FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode4), xmlAttribute);
								num2 = 7;
								continue;
							case 9:
								goto IL_24A;
							}
							goto IL_22A;
							IL_122:
							FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute, FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(14130)).ToString());
							FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode4).Append(xmlAttribute);
							num2 = 6;
							if (!true)
							{
								goto IL_15A;
							}
							continue;
							IL_22A:
							FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
							if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								num2 = 0;
								if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
								{
									break;
								}
								continue;
							}
							else
							{
								num2 = 1;
								if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
								{
									continue;
								}
								continue;
							}
							IL_186:
							xmlAttribute.Value = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(18524)].ToString();
							num2 = 3;
							continue;
							IL_16C:
							goto IL_186;
							IL_15A:
							xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18524));
							goto IL_16C;
						}
					}
				}
				this.mAWe7Y0Jgh = new List<int>();
				xmlNode3 = FormJournalRequestForRepairAddEdit.GOiUNunAGM5qwo1BZeU(xmlDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18606));
				xmlNode2.AppendChild(xmlNode3);
				goto IL_297;
				IL_2D1:
				FormJournalRequestForRepairAddEdit.ucU6aY2QZOtqi1bSqxl(xmlNode2);
				goto IL_54;
				IL_3B0:
				xmlNode = xmlDocument.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18566));
				if (xmlNode != null)
				{
					goto IL_31;
				}
				num = 9;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00017DD8 File Offset: 0x000161D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void KMwgD1pMt8(XmlNode \u0020, TreeNodeObj \u0020, DataTable \u0020, XmlNode \u0020 = null)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
			int num = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 6 : 1;
			for (;;)
			{
				List<ElectricRelation>.Enumerator enumerator;
				XmlDocument ownerDocument;
				ElectricLine electricLine;
				ElectricBus electricBus;
				switch (num)
				{
				case 0:
				case 1:
					if (\u0020 == null)
					{
						return;
					}
					num = 3;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_9EB;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_9EB;
				case 4:
					try
					{
						while (enumerator.MoveNext())
						{
							ElectricRelation electricRelation = enumerator.Current;
							using (IEnumerator<ElectricObject> enumerator2 = electricRelation.ChildObjects.GetEnumerator())
							{
								IL_97F:
								while (enumerator2.MoveNext())
								{
									ElectricObject electricObject = enumerator2.Current;
									int num2 = 18;
									XmlAttribute xmlAttribute3;
									for (;;)
									{
										XmlAttribute xmlAttribute;
										XmlAttribute xmlAttribute2;
										switch (num2)
										{
										case 0:
											if (FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14182)] == null)
											{
												xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(ownerDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(14182));
												FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020).Append(xmlAttribute);
												num2 = 3;
												continue;
											}
											xmlAttribute = FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14182)];
											goto IL_8C9;
										case 1:
											goto IL_75E;
										case 2:
											goto IL_66F;
										case 3:
											goto IL_8C9;
										case 4:
											goto IL_445;
										case 5:
											FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020).Append(xmlAttribute2);
											goto IL_58B;
										case 6:
											goto IL_887;
										case 7:
											goto IL_52A;
										case 8:
											goto IL_8F8;
										case 9:
										case 11:
											goto IL_6A6;
										case 10:
											if (FormJournalRequestForRepairAddEdit.VaEpSV2k2QmpcZreSnv((ElectricSwitch)electricObject) != TypeSwitch.TransformerTool || \u0020 == null)
											{
												goto IL_97F;
											}
											if (FormJournalRequestForRepairAddEdit.F7AksDnptBsp1PbhVpB(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020), cDhluYseFOthxgEIXpc.nKHKpgTSVU(14130)) != null && !string.IsNullOrEmpty(\u0020.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14130)].Value))
											{
												num2 = 16;
												continue;
											}
											goto IL_8F8;
										case 12:
											goto IL_58B;
										case 13:
											goto IL_32E;
										case 14:
											IL_498:
											xmlAttribute3 = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14142));
											FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020).Append(xmlAttribute3);
											num2 = 17;
											continue;
										case 15:
											goto IL_72C;
										case 16:
											goto IL_787;
										case 17:
											goto IL_72C;
										case 18:
											if (!(electricObject is ElectricSwitch))
											{
												goto IL_97F;
											}
											num2 = 10;
											if (!true)
											{
												goto IL_887;
											}
											continue;
										case 19:
											goto IL_32E;
										case 20:
											goto IL_97F;
										}
										IL_3FE:
										num2 = ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 1 : 11);
										continue;
										IL_32E:
										int? num3;
										if (num3 == null)
										{
											goto IL_66F;
										}
										XmlAttribute xmlAttribute4;
										if (FormJournalRequestForRepairAddEdit.F7AksDnptBsp1PbhVpB(\u0020.Attributes, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18524)) == null)
										{
											xmlAttribute4 = ownerDocument.CreateAttribute(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18524));
											\u0020.Attributes.Append(xmlAttribute4);
											goto IL_6A6;
										}
										xmlAttribute4 = FormJournalRequestForRepairAddEdit.F7AksDnptBsp1PbhVpB(\u0020.Attributes, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18524));
										goto IL_3FE;
										IL_566:
										int? num4;
										if (num4 != null)
										{
											num2 = 0;
											continue;
										}
										goto IL_32E;
										IL_52A:
										DataRow[] array;
										if (array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(14196)] != DBNull.Value)
										{
											num3 = new int?(FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(array[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(14196))));
											goto IL_566;
										}
										goto IL_566;
										IL_445:
										if (FormJournalRequestForRepairAddEdit.frGxQ1rVyhal7bXRk7u(xmlAttribute3.Value))
										{
											break;
										}
										XmlAttribute xmlAttribute5 = xmlAttribute3;
										FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute5, FormJournalRequestForRepairAddEdit.wNsWuanfhV2yohEhOTM(xmlAttribute5) + cDhluYseFOthxgEIXpc.nKHKpgTSVU(18764) + electricObject.ToString());
										num2 = 20;
										if (false)
										{
											goto IL_498;
										}
										continue;
										IL_72C:
										if (string.IsNullOrEmpty(xmlAttribute2.Value))
										{
											FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute2, electricObject.Id.ToString());
											num2 = 4;
											continue;
										}
										XmlAttribute xmlAttribute6 = xmlAttribute2;
										xmlAttribute6.Value = xmlAttribute6.Value + FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18764) + FormJournalRequestForRepairAddEdit.CbJpmqnDB1qgAwnievG(electricObject).ToString();
										goto IL_445;
										IL_8C9:
										if (FormJournalRequestForRepairAddEdit.frGxQ1rVyhal7bXRk7u(xmlAttribute.Value))
										{
											xmlAttribute.Value = num4.ToString();
											num2 = 13;
											continue;
										}
										xmlAttribute.Value = (Convert.ToInt32(FormJournalRequestForRepairAddEdit.wNsWuanfhV2yohEhOTM(xmlAttribute)) + num4).ToString();
										num2 = 19;
										continue;
										IL_887:
										if (FormJournalRequestForRepairAddEdit.F7AksDnptBsp1PbhVpB(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020), cDhluYseFOthxgEIXpc.nKHKpgTSVU(14142)) == null)
										{
											num2 = 14;
											continue;
										}
										xmlAttribute3 = \u0020.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14142)];
										num2 = 15;
										if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
										{
											goto IL_66F;
										}
										continue;
										IL_75E:
										goto IL_887;
										IL_58B:
										goto IL_75E;
										IL_66F:
										if (\u0020.Attributes[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(14130)] == null)
										{
											xmlAttribute2 = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(14130));
											num2 = 5;
											continue;
										}
										xmlAttribute2 = FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14130)];
										num2 = 6;
										if (!true)
										{
											goto IL_787;
										}
										continue;
										IL_6A6:
										if (FormJournalRequestForRepairAddEdit.frGxQ1rVyhal7bXRk7u(xmlAttribute4.Value))
										{
											FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute4, num3.ToString());
											goto IL_66F;
										}
										FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute4, (Convert.ToInt32(xmlAttribute4.Value) + num3).ToString());
										num2 = 2;
										continue;
										IL_787:
										XmlNode xmlNode = FormJournalRequestForRepairAddEdit.GOiUNunAGM5qwo1BZeU(ownerDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18628));
										\u0020.ParentNode.AppendChild(xmlNode);
										this.Myagc9qiNq(xmlNode, FormJournalRequestForRepairAddEdit.wNsWuanfhV2yohEhOTM(\u0020.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(18646)]), FormJournalRequestForRepairAddEdit.wNsWuanfhV2yohEhOTM(\u0020.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(14158)]), FormJournalRequestForRepairAddEdit.F7AksDnptBsp1PbhVpB(\u0020.Attributes, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18664)).Value, \u0020.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(18682)].Value, FormJournalRequestForRepairAddEdit.wNsWuanfhV2yohEhOTM(FormJournalRequestForRepairAddEdit.F7AksDnptBsp1PbhVpB(\u0020.Attributes, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18696))), FormJournalRequestForRepairAddEdit.wNsWuanfhV2yohEhOTM(FormJournalRequestForRepairAddEdit.F7AksDnptBsp1PbhVpB(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020), cDhluYseFOthxgEIXpc.nKHKpgTSVU(18716))), "", "", "");
										\u0020 = xmlNode;
										num2 = 8;
										continue;
										IL_8F8:
										array = \u0020.Select(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18732) + FormJournalRequestForRepairAddEdit.CbJpmqnDB1qgAwnievG(electricObject).ToString());
										num4 = null;
										num3 = null;
										if (array.Length == 0)
										{
											goto IL_566;
										}
										if (array[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18750)] == DBNull.Value)
										{
											goto IL_52A;
										}
										num4 = new int?(FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(array[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(18750)]));
										num2 = 7;
										if (false)
										{
											goto IL_97F;
										}
									}
									FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute3, electricObject.ToString());
								}
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					goto IL_9BE;
				case 5:
					goto IL_2F0;
				case 6:
					break;
				case 7:
					goto IL_177;
				case 8:
					IL_261:
					break;
				case 9:
					using (IEnumerator<ElectricPoint> enumerator3 = electricLine.Ends.GetEnumerator())
					{
						IL_121:
						while (enumerator3.MoveNext())
						{
							ElectricPoint electricPoint = enumerator3.Current;
							FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
							int num5 = (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 5 : 2;
							for (;;)
							{
								switch (num5)
								{
								case 0:
								case 2:
									if (electricPoint.Parent is ElectricBus)
									{
										goto IL_B7;
									}
									goto IL_121;
								case 1:
									goto IL_B7;
								case 3:
									goto IL_5B;
								case 4:
									break;
								case 5:
									goto IL_C7;
								case 6:
									goto IL_121;
								default:
									num5 = 4;
									continue;
								}
								IL_6C:
								if (electricBus.TypeBus == eTypeShinaTool.Shina_110 || FormJournalRequestForRepairAddEdit.najy9B2VQ4Cy10WXr5I(electricBus) == eTypeShinaTool.Shina_35)
								{
									break;
								}
								if (FormJournalRequestForRepairAddEdit.najy9B2VQ4Cy10WXr5I(electricBus) == eTypeShinaTool.Shina_6)
								{
									num5 = 3;
									continue;
								}
								electricBus = null;
								num5 = 6;
								continue;
								IL_C7:
								electricBus = (ElectricBus)FormJournalRequestForRepairAddEdit.cfPsE62wkCRYpE7g8tG(electricPoint);
								if (electricBus.TypeBus != eTypeShinaTool.Shina_10)
								{
									goto IL_6C;
								}
								break;
								IL_B7:
								goto IL_C7;
							}
							IL_5B:
							break;
						}
					}
					if (electricBus != null)
					{
						num = 7;
						if (!false)
						{
							continue;
						}
					}
					break;
				case 10:
					goto IL_1D9;
				case 11:
					if (\u0020.Tag is ElectricBus)
					{
						if (this.mAWe7Y0Jgh.Contains(((ElectricBus)\u0020.Tag).Id))
						{
							return;
						}
						this.mAWe7Y0Jgh.Add(FormJournalRequestForRepairAddEdit.CbJpmqnDB1qgAwnievG((ElectricBus)\u0020.Tag));
					}
					if (!(\u0020.Tag is ElectricLine))
					{
						goto IL_9BE;
					}
					electricLine = (ElectricLine)\u0020.Tag;
					if (FormJournalRequestForRepairAddEdit.qTm4IU2txPICUJD8IZE(electricLine))
					{
						electricBus = null;
						num = 9;
						continue;
					}
					break;
				case 12:
					goto IL_A1D;
				default:
					num = 5;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_1D9;
					}
					continue;
				}
				enumerator = ((ElectricLine)\u0020.Tag).Relations.GetEnumerator();
				num = 4;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_177;
				}
				continue;
				IL_2F0:
				XmlNode xmlNode2 = \u0020;
				num = 10;
				continue;
				IL_177:
				if (\u0020 != null)
				{
					goto IL_2F0;
				}
				xmlNode2 = \u0020;
				goto IL_1E1;
				IL_9BE:
				IEnumerator<TreeNodeObj> enumerator4 = \u0020.Nodes.GetEnumerator();
				num = 12;
				continue;
				IL_9EB:
				if (FormJournalRequestForRepairAddEdit.fO3FWO24gDks9lnto3L(\u0020) == null)
				{
					num = 2;
					continue;
				}
				ownerDocument = \u0020.OwnerDocument;
				if (\u0020.Tag != null)
				{
					num = 11;
					continue;
				}
				goto IL_9BE;
				IL_1E1:
				XmlNode xmlNode3 = ownerDocument.CreateElement(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18628));
				xmlNode2.AppendChild(xmlNode3);
				this.Myagc9qiNq(xmlNode3, FormJournalRequestForRepairAddEdit.cfPsE62wkCRYpE7g8tG(electricBus).ToString(), FormJournalRequestForRepairAddEdit.CbJpmqnDB1qgAwnievG(electricBus.Parent).ToString(), electricBus.ToString(), FormJournalRequestForRepairAddEdit.CbJpmqnDB1qgAwnievG(electricBus).ToString(), electricLine.ToString(), electricLine.Id.ToString(), "", "", "");
				\u0020 = xmlNode3;
				goto IL_261;
				IL_1D9:
				goto IL_1E1;
			}
			return;
			try
			{
				IL_A1D:
				IEnumerator<TreeNodeObj> enumerator4;
				while (enumerator4.MoveNext())
				{
					TreeNodeObj \u00202 = enumerator4.Current;
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					switch ((!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis()) ? 3 : 2)
					{
					case 0:
					case 2:
						this.KMwgD1pMt8(\u0020, \u00202, \u0020, \u0020);
						break;
					}
				}
			}
			finally
			{
				IEnumerator<TreeNodeObj> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000188F4 File Offset: 0x00016CF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Myagc9qiNq(XmlNode \u0020, string \u0020, string \u0020, string \u0020, string \u0020, string \u0020, string \u0020, string \u0020 = "", string \u0020 = "", string \u0020 = "")
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			for (;;)
			{
				XmlAttribute xmlAttribute;
				switch (num)
				{
				case 1:
				{
					if (FormJournalRequestForRepairAddEdit.fO3FWO24gDks9lnto3L(\u0020) == null)
					{
						return;
					}
					XmlDocument ownerDocument = \u0020.OwnerDocument;
					xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(ownerDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18646));
					xmlAttribute.Value = \u0020;
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020), xmlAttribute);
					xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(ownerDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(14158));
					xmlAttribute.Value = \u0020;
					FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020).Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18664));
					xmlAttribute.Value = \u0020;
					FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020).Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18682));
					xmlAttribute.Value = \u0020;
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(\u0020), xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18696));
					xmlAttribute.Value = \u0020;
					\u0020.Attributes.Append(xmlAttribute);
					xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(ownerDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(18716));
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					break;
				}
				case 2:
				case 4:
					FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute, \u0020);
					break;
				case 5:
					if (\u0020 != null)
					{
						num = 1;
						continue;
					}
					return;
				case 6:
					return;
				}
				IL_69:
				\u0020.Attributes.Append(xmlAttribute);
				num = 6;
				continue;
				goto IL_69;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00018A88 File Offset: 0x00016E88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FEjgpaiskE(DataRow \u0020, DataTable \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 8;
			for (;;)
			{
				XmlDocument xmlDocument;
				XmlNode xmlNode;
				XmlNode xmlNode2;
				switch (num)
				{
				case 0:
					FormJournalRequestForRepairAddEdit.vUJud3nN7tCtRRxujuS(xmlDocument, xmlNode);
					break;
				case 1:
				case 5:
					FormJournalRequestForRepairAddEdit.ucU6aY2QZOtqi1bSqxl(xmlNode2);
					goto IL_2BA;
				case 2:
					goto IL_6D;
				case 3:
					goto IL_2BA;
				case 4:
					IL_218:
					if (\u0020[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18542)] != DBNull.Value)
					{
						num = 9;
						continue;
					}
					goto IL_1F1;
				case 6:
					IL_57:
					goto IL_2BA;
				case 7:
					xmlNode = FormJournalRequestForRepairAddEdit.GOiUNunAGM5qwo1BZeU(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(18566));
					num = 0;
					continue;
				case 8:
					xmlDocument = new XmlDocument();
					num = 4;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto Block_3;
					}
					continue;
				case 9:
					goto IL_1CB;
				case 10:
					return;
				default:
					IL_29E:
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 1;
						if (false)
						{
							goto IL_2BA;
						}
						continue;
					}
					else
					{
						num = 3;
						if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							goto Block_2;
						}
						continue;
					}
					break;
				}
				IL_244:
				xmlNode2 = xmlNode.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18770));
				if (xmlNode2 != null)
				{
					goto IL_29E;
				}
				xmlNode2 = xmlDocument.CreateElement(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18770));
				FormJournalRequestForRepairAddEdit.vUJud3nN7tCtRRxujuS(xmlNode, xmlNode2);
				goto IL_57;
				IL_1F1:
				xmlNode = xmlDocument.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18566));
				if (xmlNode != null)
				{
					goto IL_244;
				}
				num = 7;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_218;
				}
				continue;
				Block_3:
				try
				{
					IL_1CB:
					xmlDocument.LoadXml(\u0020[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18542)].ToString());
				}
				catch
				{
				}
				goto IL_1F1;
				Block_2:
				IEnumerator enumerator;
				try
				{
					IL_6D:
					IL_15E:
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)FormJournalRequestForRepairAddEdit.DbPnp0XhIcN9JOvTklQ(enumerator);
						int num2 = 2;
						for (;;)
						{
							XmlNode xmlNode3;
							switch (num2)
							{
							case 0:
								break;
							case 1:
							case 4:
								xmlNode3 = FormJournalRequestForRepairAddEdit.GOiUNunAGM5qwo1BZeU(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(18596));
								xmlNode2.AppendChild(xmlNode3);
								goto IL_13C;
							case 2:
								if (dataRow.RowState != DataRowState.Deleted)
								{
									num2 = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 0 : 4);
									continue;
								}
								goto IL_15E;
							case 3:
								break;
							case 5:
								goto IL_13C;
							case 6:
								goto IL_15E;
							default:
								num2 = 5;
								continue;
							}
							IL_104:
							XmlAttribute xmlAttribute;
							xmlAttribute.Value = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13598)).ToString();
							FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(xmlNode3.Attributes, xmlAttribute);
							num2 = 6;
							if (!true)
							{
								goto IL_13C;
							}
							continue;
							IL_14E:
							goto IL_104;
							IL_13C:
							xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13598));
							goto IL_14E;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				this.OFAgWrYxAu(xmlNode2, \u0020);
				this.H6YgHQa3bt(xmlNode2, \u0020);
				FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(\u0020, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18542), xmlDocument.InnerXml);
				num = 10;
				continue;
				IL_2BA:
				enumerator = FormJournalRequestForRepairAddEdit.NLHZ9pX09y9dLHK3wDu(\u0020.Rows);
				num = 2;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00018D9C File Offset: 0x0001719C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OFAgWrYxAu(XmlNode \u0020, DataTable \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			try
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(\u0020.Rows) > 0)
				{
					string text = "";
					IEnumerator enumerator = \u0020.Rows.GetEnumerator();
					try
					{
						IL_12D:
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							DataRow dataRow = (DataRow)obj2;
							FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
							int num8;
							if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								num8 = 2;
							}
							else
							{
								num8 = 3;
								if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
								{
									continue;
								}
							}
							for (;;)
							{
								switch (num8)
								{
								case 0:
								case 2:
									goto IL_10A;
								case 1:
									break;
								case 3:
									break;
								case 4:
									goto IL_D0;
								case 5:
									goto IL_12D;
								default:
									num8 = 4;
									if (false)
									{
										goto IL_D0;
									}
									continue;
								}
								IL_71:
								if (string.IsNullOrEmpty(text))
								{
									goto Block_8;
								}
								text = FormJournalRequestForRepairAddEdit.qK3BLfnU0lFVrvHNSux(text, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10764), FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13598)).ToString());
								num8 = 5;
								if (!true)
								{
									goto IL_10A;
								}
								continue;
								IL_117:
								goto IL_71;
								IL_10A:
								if (dataRow.RowState != DataRowState.Deleted)
								{
									goto IL_117;
								}
								break;
							}
							IL_D0:
							continue;
							Block_8:
							text = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13598)].ToString();
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(disposable);
						}
					}
					object obj3 = FormJournalRequestForRepairAddEdit.ommREf2d72gCuDqnCmm(new SqlDataCommand(this.SqlSettings), FormJournalRequestForRepairAddEdit.KatxDcr49et30cDMVlE(cDhluYseFOthxgEIXpc.nKHKpgTSVU(18786), FormJournalRequestForRepairAddEdit.UZ0amerEqKv6whRWf4X(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.SfApCFrHib1HYUDsmDO(this.y7feOpIJtI).Rows[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056))).ToString(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(1160)), text));
					num4 = Convert.ToInt32(obj3.Compute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(21830)));
					num5 = Convert.ToInt32(FormJournalRequestForRepairAddEdit.gFMvyw2l22drhopM3rc(obj3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), cDhluYseFOthxgEIXpc.nKHKpgTSVU(21876)));
					num6 = Convert.ToInt32(FormJournalRequestForRepairAddEdit.gFMvyw2l22drhopM3rc(obj3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), cDhluYseFOthxgEIXpc.nKHKpgTSVU(21908)));
					num7 = Convert.ToInt32(obj3.Compute(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(21808), cDhluYseFOthxgEIXpc.nKHKpgTSVU(21940)));
				}
				if (\u0020 != null && FormJournalRequestForRepairAddEdit.fO3FWO24gDks9lnto3L(\u0020) != null)
				{
					XmlDocument ownerDocument = \u0020.OwnerDocument;
					XmlNode xmlNode = ownerDocument.CreateElement(cDhluYseFOthxgEIXpc.nKHKpgTSVU(21970));
					\u0020.AppendChild(xmlNode);
					XmlAttribute xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(ownerDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(21994));
					FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute, num4.ToString());
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(xmlNode.Attributes, xmlAttribute);
					xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(ownerDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(22026));
					FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute, num.ToString());
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(xmlNode.Attributes, xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(22066));
					xmlAttribute.Value = num5.ToString();
					xmlNode.Attributes.Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(22098));
					xmlAttribute.Value = num2.ToString();
					xmlNode.Attributes.Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(22138));
					xmlAttribute.Value = num6.ToString();
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode), xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(22170));
					xmlAttribute.Value = num7.ToString();
					FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode).Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(22198));
					xmlAttribute.Value = num3.ToString();
					xmlNode.Attributes.Append(xmlAttribute);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(FormJournalRequestForRepairAddEdit.VIhy5SXRaCAk0LBkYLo(ex));
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000191A8 File Offset: 0x000175A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void H6YgHQa3bt(XmlNode \u0020, DataTable \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			try
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				if (FormJournalRequestForRepairAddEdit.kFpJp7XFIVNwwPqqXM4(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(\u0020)) > 0)
				{
					string text = "";
					using (IEnumerator enumerator = \u0020.Rows.GetEnumerator())
					{
						IL_126:
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)FormJournalRequestForRepairAddEdit.DbPnp0XhIcN9JOvTklQ(enumerator);
							FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
							int num9 = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 3 : 2;
							for (;;)
							{
								switch (num9)
								{
								case 0:
								case 2:
									if (dataRow.RowState == DataRowState.Deleted)
									{
										goto IL_126;
									}
									break;
								case 1:
									break;
								case 3:
									break;
								case 4:
									goto IL_74;
								case 5:
									goto IL_126;
								default:
									num9 = 4;
									continue;
								}
								IL_E1:
								if (string.IsNullOrEmpty(text))
								{
									break;
								}
								text = FormJournalRequestForRepairAddEdit.qK3BLfnU0lFVrvHNSux(text, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(10764), dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(13598)].ToString());
								num9 = 5;
								continue;
								goto IL_E1;
							}
							IL_74:
							text = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(13598)).ToString();
							continue;
							goto IL_74;
						}
					}
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
					object obj2 = FormJournalRequestForRepairAddEdit.ommREf2d72gCuDqnCmm(sqlDataCommand, cDhluYseFOthxgEIXpc.nKHKpgTSVU(22234) + text + cDhluYseFOthxgEIXpc.nKHKpgTSVU(23786));
					num = Convert.ToInt32(obj2.Compute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), cDhluYseFOthxgEIXpc.nKHKpgTSVU(21830)));
					num2 = FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(obj2.Compute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), cDhluYseFOthxgEIXpc.nKHKpgTSVU(21876)));
					num3 = Convert.ToInt32(FormJournalRequestForRepairAddEdit.gFMvyw2l22drhopM3rc(obj2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(21908)));
					num4 = FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.gFMvyw2l22drhopM3rc(obj2, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(21808), cDhluYseFOthxgEIXpc.nKHKpgTSVU(21940)));
					DataTable dataTable = sqlDataCommand.SelectSqlData(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(23792) + text + cDhluYseFOthxgEIXpc.nKHKpgTSVU(23786));
					num6 = FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(dataTable.Compute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), cDhluYseFOthxgEIXpc.nKHKpgTSVU(24932)));
					num7 = Convert.ToInt32(dataTable.Compute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), cDhluYseFOthxgEIXpc.nKHKpgTSVU(24966)));
					num8 = FormJournalRequestForRepairAddEdit.guwjn3rKRtla0nsHj1R(FormJournalRequestForRepairAddEdit.gFMvyw2l22drhopM3rc(dataTable, cDhluYseFOthxgEIXpc.nKHKpgTSVU(21808), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25038)));
				}
				if (\u0020 != null && \u0020.OwnerDocument != null)
				{
					XmlDocument ownerDocument = \u0020.OwnerDocument;
					XmlNode xmlNode = ownerDocument.CreateElement(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25070));
					\u0020.AppendChild(xmlNode);
					XmlAttribute xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(ownerDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25096));
					xmlAttribute.Value = num.ToString();
					xmlNode.Attributes.Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25130));
					xmlAttribute.Value = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25172);
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(xmlNode.Attributes, xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25178));
					xmlAttribute.Value = num2.ToString();
					FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode).Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25212));
					xmlAttribute.Value = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25172);
					xmlNode.Attributes.Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25254));
					xmlAttribute.Value = num3.ToString();
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(xmlNode.Attributes, xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25288));
					xmlAttribute.Value = num4.ToString();
					xmlNode.Attributes.Append(xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25318));
					FormJournalRequestForRepairAddEdit.GptWRVnsvn4UAC7Y2iu(xmlAttribute, num5.ToString());
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(xmlNode.Attributes, xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25356));
					xmlAttribute.Value = num6.ToString();
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode), xmlAttribute);
					xmlAttribute = ownerDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25388));
					xmlAttribute.Value = num7.ToString();
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode), xmlAttribute);
					xmlAttribute = FormJournalRequestForRepairAddEdit.XmWgSb21ugWFxv80sow(ownerDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25426));
					xmlAttribute.Value = num8.ToString();
					FormJournalRequestForRepairAddEdit.zY2Bdm2G9raJiNM34Uj(xmlNode.Attributes, xmlAttribute);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001968C File Offset: 0x00017A8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static XmlDocument kphgFgJVw5(DataTable \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			if (false)
			{
				goto IL_1A;
			}
			XmlDocument xmlDocument;
			for (;;)
			{
				IL_5B:
				switch (num)
				{
				case 0:
					goto IL_41;
				case 1:
				case 4:
					goto IL_1A;
				case 2:
					goto IL_2B;
				case 3:
					goto IL_A6;
				case 5:
					xmlDocument = new XmlDocument();
					FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						num = 4;
					}
					else
					{
						num = 0;
						if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							goto IL_41;
						}
					}
					break;
				case 6:
					goto IL_BC;
				default:
					num = 3;
					break;
				}
			}
			IEnumerator enumerator;
			XmlNode xmlNode2;
			try
			{
				IL_BC:
				IL_1B2:
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)FormJournalRequestForRepairAddEdit.DbPnp0XhIcN9JOvTklQ(enumerator);
					int num2 = 4;
					if (!true)
					{
						goto IL_D9;
					}
					XmlAttribute xmlAttribute;
					for (;;)
					{
						IL_FD:
						XmlNode xmlNode;
						switch (num2)
						{
						case 0:
							goto IL_12E;
						case 1:
						case 5:
							goto IL_D9;
						default:
							goto IL_11E;
						case 3:
							break;
						case 4:
							if (dataRow.RowState == DataRowState.Deleted)
							{
								goto IL_1B2;
							}
							xmlNode = FormJournalRequestForRepairAddEdit.GOiUNunAGM5qwo1BZeU(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(18596));
							FormJournalRequestForRepairAddEdit.vUJud3nN7tCtRRxujuS(xmlNode2, xmlNode);
							if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
							{
								num2 = 0;
								continue;
							}
							num2 = 5;
							if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
							{
								continue;
							}
							break;
						case 6:
							goto IL_1B2;
						}
						FormJournalRequestForRepairAddEdit.M8yZkGXg0SRP5V3JtC2(xmlNode).Append(xmlAttribute);
						num2 = 6;
						if (!true)
						{
							goto IL_1B2;
						}
					}
					IL_12E:
					xmlAttribute.Value = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(13598)].ToString();
					num2 = 3;
					goto IL_FD;
					IL_11E:
					goto IL_12E;
					IL_D9:
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(13598));
					goto IL_11E;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			return xmlDocument;
			IL_1A:
			xmlNode2 = FormJournalRequestForRepairAddEdit.GOiUNunAGM5qwo1BZeU(xmlDocument, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(18770));
			IL_2B:
			IL_41:
			xmlDocument.AppendChild(xmlNode2);
			IL_A6:
			enumerator = \u0020.Rows.GetEnumerator();
			num = 6;
			goto IL_5B;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00019890 File Offset: 0x00017C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TD2gxXZG97()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 5 : 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 4:
					this.tv9eamhOik = new Dictionary<int, string>();
					num = 7;
					continue;
				case 1:
					this.tv9eamhOik.Add(108, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25668));
					num = 8;
					continue;
				case 2:
					this.tv9eamhOik.Add(2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25476));
					goto IL_3A;
				case 3:
					goto IL_3A;
				case 5:
					goto IL_A0;
				case 6:
					break;
				case 7:
					this.tv9eamhOik.Add(1, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25458));
					num = 2;
					continue;
				case 8:
					return;
				default:
					num = 6;
					continue;
				}
				IL_FB:
				this.tv9eamhOik.Add(104, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25542));
				this.tv9eamhOik.Add(105, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25578));
				this.tv9eamhOik.Add(106, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25598));
				this.tv9eamhOik.Add(7, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25618));
				this.tv9eamhOik.Add(107, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25618));
				num = 1;
				continue;
				IL_A0:
				this.tv9eamhOik.Add(3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25502));
				goto IL_FB;
				IL_3A:
				goto IL_A0;
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00019A14 File Offset: 0x00017E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NXwgyoTTh8()
		{
			while (false)
			{
				object obj = null[0];
			}
			if (this.abEgNyD5Y6 > 0)
			{
				base.SelectSqlData(this.y7feOpIJtI.tJ_RequestForRepairLog, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(25690) + this.abEgNyD5Y6.ToString(), null, false, 0);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00019A74 File Offset: 0x00017E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RFPgr9yT5T()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 17;
			if (true)
			{
				for (;;)
				{
					DataTable \u0020;
					DataRow[] array;
					DataRow dataRow;
					DataTable dataTable;
					DataRow[] array2;
					switch (num)
					{
					case 0:
						goto IL_568;
					case 1:
						this.MrkgiUHSIb(\u0020, 104);
						goto IL_600;
					case 2:
					case 20:
						if (Convert.ToInt32(array[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25984)]) == 7)
						{
							goto IL_1FB;
						}
						goto IL_FC;
					case 3:
						if (!Convert.ToBoolean(FormJournalRequestForRepairAddEdit.ttGPFkr8vhdSJ4UrlOh(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5526), DataRowVersion.Original)))
						{
							num = 10;
							continue;
						}
						break;
					case 4:
						array = dataTable.Select(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25730));
						if (array.Length != 0)
						{
							num = 6;
							continue;
						}
						\u0020 = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(6574));
						dataRow = FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(this.y7feOpIJtI.tJ_RequestForRepair.Rows, 0);
						if (dataRow.RowState != DataRowState.Added)
						{
							goto IL_454;
						}
						this.MrkgiUHSIb(\u0020, 1);
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)) != DBNull.Value && FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526))))
						{
							this.MrkgiUHSIb(\u0020, 2);
						}
						if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136)] != DBNull.Value && Convert.ToBoolean(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136)]))
						{
							this.MrkgiUHSIb(\u0020, 3);
						}
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)) != DBNull.Value && FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)]))
						{
							num = 8;
							continue;
						}
						goto IL_454;
					case 5:
						goto IL_81F;
					case 6:
						return;
					case 7:
						if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526), DataRowVersion.Original] != DBNull.Value && FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5526), DataRowVersion.Original]) && FormJournalRequestForRepairAddEdit.ttGPFkr8vhdSJ4UrlOh(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136), DataRowVersion.Original) != DBNull.Value)
						{
							num = 18;
							continue;
						}
						goto IL_22A;
					case 8:
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136)) != DBNull.Value && Convert.ToBoolean(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136)]))
						{
							num = 27;
							continue;
						}
						goto IL_454;
					case 9:
						goto IL_127;
					case 10:
						if (FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)) != DBNull.Value && Convert.ToBoolean(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)]))
						{
							this.MrkgiUHSIb(\u0020, 106);
						}
						break;
					case 11:
						if (array.Length != 0)
						{
							goto IL_163;
						}
						if (FormJournalRequestForRepairAddEdit.ttGPFkr8vhdSJ4UrlOh(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136), DataRowVersion.Original) == DBNull.Value)
						{
							goto IL_127;
						}
						if (!Convert.ToBoolean(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136), DataRowVersion.Original]))
						{
							num = 9;
							continue;
						}
						goto IL_163;
					case 12:
						if (FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5526)]))
						{
							goto IL_828;
						}
						num = 5;
						if (false)
						{
							goto IL_568;
						}
						continue;
					case 13:
						if (Convert.ToBoolean(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)]))
						{
							num = 22;
							continue;
						}
						goto IL_430;
					case 14:
						goto IL_3C6;
					case 15:
						array2 = FormJournalRequestForRepairAddEdit.ALVmre2bekQLM8N2p3g(dataTable, cDhluYseFOthxgEIXpc.nKHKpgTSVU(26006), FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25938));
						if (array2.Length != 0)
						{
							num = 26;
							continue;
						}
						goto IL_6C1;
					case 16:
						return;
					case 17:
						if (this.y7feOpIJtI.tJ_RequestForRepair.Rows.Count == 0)
						{
							num = 16;
							continue;
						}
						dataTable = this.y7feOpIJtI.tJ_RequestForRepairLog;
						num = 4;
						continue;
					case 18:
						if (!Convert.ToBoolean(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136), DataRowVersion.Original]))
						{
							goto IL_22A;
						}
						goto IL_600;
					case 19:
						goto IL_FC;
					case 21:
						goto IL_1FB;
					case 22:
						this.MrkgiUHSIb(\u0020, 2);
						goto IL_430;
					case 23:
						IL_6DD:
						if (dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5526), DataRowVersion.Original] != DBNull.Value && Convert.ToBoolean(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526), DataRowVersion.Original]) && dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)] != DBNull.Value)
						{
							num = 12;
							continue;
						}
						goto IL_828;
					case 24:
					{
						bool flag;
						try
						{
							IEnumerator<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH> enumerator;
							while (enumerator.MoveNext())
							{
								DataRow dataRow2 = enumerator.Current;
								int num2;
								if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
								{
									num2 = 4;
									if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
									{
										goto IL_769;
									}
								}
								else
								{
									num2 = 3;
								}
								for (;;)
								{
									IL_7A3:
									switch (num2)
									{
									case 0:
									case 4:
										if (FormJournalRequestForRepairAddEdit.jSgH4onRAFMXGvcH2Fh(dataRow2) == DataRowState.Added)
										{
											goto IL_776;
										}
										num2 = 1;
										break;
									case 1:
										goto IL_783;
									default:
										goto IL_7C0;
									case 3:
										goto IL_769;
									case 5:
										goto IL_7E7;
									}
								}
								IL_7E7:
								break;
								IL_783:
								if (dataRow2.RowState == DataRowState.Modified)
								{
									goto IL_776;
								}
								IL_7C0:
								IL_769:
								if (FormJournalRequestForRepairAddEdit.jSgH4onRAFMXGvcH2Fh(dataRow2) != DataRowState.Deleted)
								{
									continue;
								}
								IL_776:
								flag = true;
								num2 = 5;
								goto IL_7A3;
							}
						}
						finally
						{
							IEnumerator<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH> enumerator;
							if (enumerator != null)
							{
								FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(enumerator);
							}
						}
						if (!flag)
						{
							goto IL_6C1;
						}
						num = 15;
						if (false)
						{
							goto IL_81F;
						}
						continue;
					}
					case 25:
						goto IL_6B3;
					case 26:
						goto IL_5C6;
					case 27:
						this.MrkgiUHSIb(\u0020, 104);
						goto IL_454;
					case 28:
						if (array.Length == 0)
						{
							goto IL_FC;
						}
						if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526), DataRowVersion.Original] != DBNull.Value)
						{
							num = 3;
							continue;
						}
						break;
					case 29:
						goto IL_843;
					default:
						num = 23;
						if (!true)
						{
							goto IL_6B3;
						}
						continue;
					}
					array = dataTable.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25892), cDhluYseFOthxgEIXpc.nKHKpgTSVU(25938));
					if (array.Length != 0)
					{
						if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
						{
							num = 14;
							continue;
						}
						num = 2;
						if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
						{
							continue;
						}
					}
					IL_FC:
					if (dataRow.RowState != DataRowState.Added)
					{
						bool flag = false;
						IEnumerator<E1YGNRmqUpG01b1DWc.Di74tBswWw6TucRtQFH> enumerator = this.y7feOpIJtI.tJ_RequestForRepairDaily.GetEnumerator();
						num = 24;
						continue;
					}
					goto IL_6C1;
					IL_454:
					if (FormJournalRequestForRepairAddEdit.jSgH4onRAFMXGvcH2Fh(dataRow) != DataRowState.Modified)
					{
						goto IL_FC;
					}
					array = dataTable.Select(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25764));
					if (array.Length == 0 && (FormJournalRequestForRepairAddEdit.ttGPFkr8vhdSJ4UrlOh(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526), DataRowVersion.Original) == DBNull.Value || !FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(FormJournalRequestForRepairAddEdit.ttGPFkr8vhdSJ4UrlOh(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526), DataRowVersion.Original))) && dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5526)] != DBNull.Value)
					{
						num = 13;
						continue;
					}
					goto IL_430;
					IL_163:
					array = dataTable.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25824));
					if (array.Length == 0)
					{
						num = 7;
						continue;
					}
					goto IL_600;
					IL_127:
					if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136)] != DBNull.Value && FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136)]))
					{
						this.MrkgiUHSIb(\u0020, 3);
						goto IL_163;
					}
					goto IL_163;
					IL_22A:
					if (dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5526)] != DBNull.Value)
					{
						num = 0;
						continue;
					}
					goto IL_600;
					IL_3C6:
					this.MrkgiUHSIb(\u0020, 107);
					num = 19;
					continue;
					IL_1FB:
					goto IL_3C6;
					IL_430:
					array = dataTable.Select(cDhluYseFOthxgEIXpc.nKHKpgTSVU(25794));
					num = 11;
					continue;
					IL_568:
					if (!Convert.ToBoolean(dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5526)]) || FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5136)) == DBNull.Value || !FormJournalRequestForRepairAddEdit.DGOln0rjCJfnHFr9OaL(FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5136))))
					{
						goto IL_600;
					}
					num = 1;
					if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						continue;
					}
					IL_5C6:
					if (Convert.ToInt32(array2[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25984)]) == 105)
					{
						this.MrkgiUHSIb(\u0020, 7);
						num = 25;
						continue;
					}
					this.MrkgiUHSIb(\u0020, 107);
					IL_6C1:
					FormJournalRequestForRepairAddEdit.P1SpEP2FMVrXNYPNknM(this, this.y7feOpIJtI.tJ_RequestForRepairLog);
					num = 29;
					continue;
					IL_6B3:
					goto IL_6C1;
					IL_600:
					array = FormJournalRequestForRepairAddEdit.HG3HIPXcjjiC4r4nkb0(dataTable, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25824));
					if (array.Length != 0)
					{
						goto IL_6DD;
					}
					IL_828:
					array = dataTable.Select(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25858));
					num = 28;
					continue;
					IL_81F:
					this.MrkgiUHSIb(\u0020, 105);
					goto IL_828;
				}
				return;
				try
				{
					IL_843:
					string cmdText = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(26036);
					using (SqlConnection sqlConnection = new SqlConnection(FormJournalRequestForRepairAddEdit.P1Y3af2Pw6Y2VBhJDsy(this.SqlSettings)))
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
					MessageBox.Show(FormJournalRequestForRepairAddEdit.VIhy5SXRaCAk0LBkYLo(ex), ex.Source);
				}
				return;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0001A378 File Offset: 0x00018778
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MrkgiUHSIb(DataTable \u0020, int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 9;
			for (;;)
			{
				DataRow dataRow;
				switch (num)
				{
				case 0:
					break;
				case 1:
					base.SelectSqlData(\u0020, true, cDhluYseFOthxgEIXpc.nKHKpgTSVU(28844), null, false, 0);
					goto IL_1C4;
				case 2:
				case 8:
					FormJournalRequestForRepairAddEdit.s6wSdMXIUq1n1s2ismF(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(28902), DateTime.Now);
					if (\u0020.Rows.Count > 0)
					{
						dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(28920)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(\u0020), 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(6588));
						dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(28942)] = FormJournalRequestForRepairAddEdit.K6NfaiXP1t10bpkhPO6(\u0020.Rows, 0)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(28960)];
						if (\u0020.Rows[0][FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4512)] != DBNull.Value)
						{
							dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(28974)] = FormJournalRequestForRepairAddEdit.JFfwufXokr9neQvFwiO(FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(\u0020)[0], cDhluYseFOthxgEIXpc.nKHKpgTSVU(4512));
						}
					}
					dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25984)] = \u0020;
					goto IL_11F;
				case 3:
					goto IL_11F;
				case 4:
					break;
				case 5:
					goto IL_12F;
				case 6:
					goto IL_151;
				case 7:
					goto IL_259;
				case 9:
					IL_210:
					if (FormJournalRequestForRepairAddEdit.ndhbvCXby6djkL1sHSq(\u0020).Count != 0)
					{
						goto IL_1C4;
					}
					num = 1;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 10:
					return;
				default:
					num = 5;
					continue;
				}
				this.y7feOpIJtI.tJ_RequestForRepairLog.Rows.Add(dataRow);
				num = 10;
				continue;
				IL_1C4:
				dataRow = FormJournalRequestForRepairAddEdit.ghwdnQ2mwVRbtIkoEuR(this.y7feOpIJtI).NewRow();
				dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678)] = this.abEgNyD5Y6;
				FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW();
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					num = 7;
					continue;
				}
				num = 8;
				if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					goto IL_210;
				}
				continue;
				IL_12F:
				dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(29018)] = true;
				num = 4;
				if (!false)
				{
					continue;
				}
				IL_151:
				if (\u0020 > 100)
				{
					goto IL_12F;
				}
				dataRow[FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29018)] = false;
				num = 0;
				continue;
				IL_259:
				if (this.tv9eamhOik.ContainsKey(\u0020))
				{
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(29000)] = this.tv9eamhOik[\u0020];
					num = 6;
					continue;
				}
				goto IL_151;
				IL_11F:
				goto IL_259;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0001A618 File Offset: 0x00018A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Dispose(bool disposing)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					FormJournalRequestForRepairAddEdit.cFo5QHXN0g6HniFoC2c(this.fH1e1A9RNZ);
					break;
				case 1:
				case 2:
					if (this.fH1e1A9RNZ != null)
					{
						num = 0;
						if (false)
						{
							return;
						}
						continue;
					}
					break;
				case 5:
					if (disposing)
					{
						FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis();
						num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 4 : 2);
						continue;
					}
					break;
				case 6:
					return;
				}
				IL_18:
				FormJournalRequestForRepairAddEdit.VvdBRw2giBS2EAg2RBa(this, disposing);
				num = 6;
				continue;
				goto IL_18;
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001A6D4 File Offset: 0x00018AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WvngYeZ1e5()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 236;
			for (;;)
			{
				DataGridViewCellStyle dataGridViewCellStyle;
				DataGridViewCellStyle dataGridViewCellStyle4;
				switch (num)
				{
				case 0:
					goto IL_526B;
				case 1:
					this.reaed0XCF6 = new Label();
					num = 372;
					continue;
				case 2:
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.d6UeKsT72M, 0);
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.d6UeKsT72M, cDhluYseFOthxgEIXpc.nKHKpgTSVU(29754));
					this.jNxezOc8K1.GripStyle = ToolStripGripStyle.Hidden;
					FormJournalRequestForRepairAddEdit.QqJNhj2u5mpiu0ceV1M(this.jNxezOc8K1.Items, new ToolStripItem[]
					{
						this.AF3nZ6Ps4Z,
						this.tdnnXm7uXt,
						this.bq8n3A7OBi,
						this.CeanIEi3ht
					});
					this.jNxezOc8K1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
					num = 273;
					if (!true)
					{
						goto IL_2A40;
					}
					continue;
				case 3:
					goto IL_16DD;
				case 4:
					goto IL_1247;
				case 5:
					this.aelevmJUSY.AutoCompleteSource = AutoCompleteSource.ListItems;
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.aelevmJUSY).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(29064), true));
					FormJournalRequestForRepairAddEdit.wxtbji2ewKZVOuHvHhg(this.aelevmJUSY, true);
					this.aelevmJUSY.Location = new Point(288, 66);
					num = 306;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 6:
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.xL1nFot21u, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32932));
					num = 73;
					continue;
				case 7:
					this.kuRnYPi50V.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
					this.kuRnYPi50V.AutoSize = true;
					num = 315;
					continue;
				case 8:
					goto IL_550C;
				case 9:
					goto IL_B47;
				case 10:
					goto IL_12FC;
				case 11:
					this.G5GekMlON7.Location = new Point(101, 45);
					this.G5GekMlON7.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31696);
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.G5GekMlON7, new Size(527, 20));
					this.G5GekMlON7.TabIndex = 1;
					this.HsZefiTdR1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					num = 184;
					continue;
				case 12:
					this.qUpJJfJyqr.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34630);
					FormJournalRequestForRepairAddEdit.xIyWMkTMNwI84W4tus3(this.qUpJJfJyqr, new Size(23, 22));
					this.qUpJJfJyqr.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34668);
					num = 180;
					continue;
				case 13:
					goto IL_4EA3;
				case 14:
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.ROTnK6JpmV, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(36332));
					num = 255;
					continue;
				case 15:
					FormJournalRequestForRepairAddEdit.eNVU9sXVTPdgEbxSF8w(this.rWoeDxUpjP.DataBindings, new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(31370), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31388), true, DataSourceUpdateMode.OnPropertyChanged));
					this.rWoeDxUpjP.Location = new Point(9, 150);
					num = 185;
					if (false)
					{
						goto IL_DDE;
					}
					continue;
				case 16:
					goto IL_5FBF;
				case 17:
					goto IL_4676;
				case 18:
					this.NbVJf7f7GG.ReadOnly = true;
					this.UaEJ6qjvWD.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29018);
					num = 268;
					continue;
				case 19:
					this.oGkJV73aOo.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678);
					this.oGkJV73aOo.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35698);
					FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.oGkJV73aOo, true);
					this.oGkJV73aOo.Visible = false;
					this.R0pJKyX3qJ.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35772);
					this.R0pJKyX3qJ.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35772);
					num = 144;
					continue;
				case 20:
					this.Ms1nJWxRcR.Size = new Size(730, 643);
					FormJournalRequestForRepairAddEdit.R3laZVT5Orn1G9YC2jl(this.Ms1nJWxRcR, 2);
					num = 99;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_26EF;
					}
					continue;
				case 21:
					this.kl0niMXXMI.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31058);
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.kl0niMXXMI, new Size(379, 21));
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.kl0niMXXMI, 13);
					this.kl0niMXXMI.SelectedIndexChanged += this.U7uIERJrdt;
					num = 7;
					continue;
				case 22:
					this.sqQJSRbNql.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29050);
					this.sqQJSRbNql.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35934);
					num = 59;
					continue;
				case 23:
					goto IL_4296;
				case 24:
					this.FZInULtqG4.Size = new Size(181, 21);
					num = 312;
					continue;
				case 25:
					goto IL_56E3;
				case 26:
					FormJournalRequestForRepairAddEdit.PAyBQJTxeDbQR3vow1v(this.f2QnlcdpJi, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35344));
					this.f2QnlcdpJi.Click += this.spvgsQBU6S;
					num = 126;
					continue;
				case 27:
					goto IL_1A32;
				case 28:
					goto IL_1B6A;
				case 29:
					goto IL_4765;
				case 30:
					FormJournalRequestForRepairAddEdit.pPJdjyTjs5t4OS57PsA(this.ROTnK6JpmV, true);
					this.ROTnK6JpmV.Visible = false;
					num = 356;
					if (false)
					{
						goto IL_2DE0;
					}
					continue;
				case 31:
					this.BhgeS5qeIC.Location = new Point(11, 411);
					num = 183;
					if (!true)
					{
						goto IL_2E53;
					}
					continue;
				case 32:
					this.PTle2wlpsd.Location = new Point(6, 45);
					this.PTle2wlpsd.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29526);
					num = 138;
					continue;
				case 33:
					base.ClientSize = new Size(664, 713);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(base.Controls, this.qTqJTaBgHY);
					num = 173;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 34:
					this.Hrwe9GBchc.Location = new Point(6, 71);
					this.Hrwe9GBchc.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29462);
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.Hrwe9GBchc, new Size(89, 13));
					this.Hrwe9GBchc.TabIndex = 4;
					num = 335;
					continue;
				case 35:
					FormJournalRequestForRepairAddEdit.xwvFLpTTLNMolTdyBMw(this.Ms1nJWxRcR, new Point(4, 22));
					this.Ms1nJWxRcR.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34768);
					num = 166;
					continue;
				case 36:
					this.TKdnD2UOSQ.AutoCompleteSource = AutoCompleteSource.ListItems;
					num = 327;
					continue;
				case 37:
					this.g1HJnTrcyE.TabIndex = 0;
					num = 344;
					continue;
				case 38:
					this.wULnq8UnPx = new DataGridViewExcelFilter();
					num = 244;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_2F0C;
					}
					continue;
				case 39:
					goto IL_26EF;
				case 40:
					goto IL_AB1;
				case 41:
					FormJournalRequestForRepairAddEdit.DAm92fT1p83nmWbvYiI(this.btQJgjaEtV, false);
					this.btQJgjaEtV.AllowUserToDeleteRows = false;
					this.btQJgjaEtV.AutoGenerateColumns = false;
					this.btQJgjaEtV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					num = 360;
					continue;
				case 42:
					this.QQEJ5VCv5Z.ReadOnly = true;
					this.QQEJ5VCv5Z.RowHeadersWidth = 21;
					this.QQEJ5VCv5Z.Size = new Size(724, 637);
					this.QQEJ5VCv5Z.TabIndex = 0;
					num = 132;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_4061;
					}
					continue;
				case 43:
					this.YoIns0P0S0.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(34826);
					num = 141;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_51C5;
					}
					continue;
				case 44:
					goto IL_5E4F;
				case 45:
					goto IL_32BF;
				case 46:
					this.hZGeVyEfRI.Location = new Point(101, 16);
					this.hZGeVyEfRI.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29706);
					this.hZGeVyEfRI.Size = new Size(527, 20);
					num = 385;
					continue;
				case 47:
					this.gJsJPJ7k5A.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(32372);
					this.gJsJPJ7k5A.Size = new Size(121, 17);
					this.gJsJPJ7k5A.TabIndex = 27;
					this.gJsJPJ7k5A.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(32402);
					FormJournalRequestForRepairAddEdit.pPJdjyTjs5t4OS57PsA(this.gJsJPJ7k5A, true);
					num = 321;
					continue;
				case 48:
					this.kcpnME1c9M.DataType = Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777262));
					this.er6n8CvbjI.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(280);
					this.er6n8CvbjI.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777262));
					this.zJ3nR52you.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(8464);
					this.Ui6nCLYZvx.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(8344);
					num = 303;
					continue;
				case 49:
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.dSOeiWZtIs, new Point(178, 8));
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.dSOeiWZtIs, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30480));
					FormJournalRequestForRepairAddEdit.fltXeY2DcaHrEKvDYFT(this.dSOeiWZtIs, 30);
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.dSOeiWZtIs, new Size(456, 130));
					this.dSOeiWZtIs.TabIndex = 12;
					FormJournalRequestForRepairAddEdit.va1crk2U67t3cs4oSaW(this.dSOeiWZtIs, true);
					num = 213;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_32A7;
					}
					continue;
				case 50:
					goto IL_4195;
				case 51:
					this.b2vnyhrNSS = new Label();
					this.d7YnphvtQ1 = new ComboBox();
					this.nv7nWxKZai = new Label();
					this.EQknHC0OS1 = new ComboBox();
					this.xL1nFot21u = new Label();
					this.KKYnt0822j = new ComboBox();
					num = 341;
					if (false)
					{
						goto IL_1528;
					}
					continue;
				case 52:
					this.mqUexv2WmH = new TextBox();
					num = 66;
					continue;
				case 53:
					FormJournalRequestForRepairAddEdit.DDgc4F2aoeE5nTFb38n(this.AF3nZ6Ps4Z, Resources.Im7NYV1iO());
					this.AF3nZ6Ps4Z.ImageTransparentColor = Color.Magenta;
					this.AF3nZ6Ps4Z.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29804);
					this.AF3nZ6Ps4Z.Size = new Size(23, 22);
					num = 333;
					if (!true)
					{
						goto IL_44CA;
					}
					continue;
				case 54:
					this.rgNJku7Xu9.HeaderText = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25984);
					num = 91;
					if (false)
					{
						goto IL_2797;
					}
					continue;
				case 55:
					FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.RI9Jlhlmpg, true);
					this.RI9Jlhlmpg.Visible = false;
					this.K4tnmquBOV.DataMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33848);
					FormJournalRequestForRepairAddEdit.jpYmLkTg8aDh8kR7C2k(this.K4tnmquBOV, this.k16n0HORUW);
					FormJournalRequestForRepairAddEdit.CKj7pcTRNsQjhYuaD0g(this.K4tnmquBOV, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8344));
					this.k16n0HORUW.DataSetName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2694);
					this.k16n0HORUW.Tables.AddRange(new DataTable[]
					{
						this.Glkno10FRw,
						this.gYanOthiX8,
						this.bgxnjGgfZD
					});
					this.Glkno10FRw.Columns.AddRange(new DataColumn[]
					{
						this.IebnutXeZ9,
						this.kcpnME1c9M,
						this.er6n8CvbjI,
						this.zJ3nR52you,
						this.Ui6nCLYZvx,
						this.TacJ18fMBC
					});
					num = 50;
					continue;
				case 56:
					goto IL_248;
				case 57:
					FormJournalRequestForRepairAddEdit.AZwWOx2MtmsmkLVN5RH(this.FZInULtqG4, new EventHandler(this.uZvg3PHGhU));
					num = 258;
					continue;
				case 58:
					this.o6pnNeOUiG = new DataColumn();
					this.VaDnENYonh = new DataColumn();
					num = 215;
					if (false)
					{
						goto IL_1247;
					}
					continue;
				case 59:
					FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.sqQJSRbNql, true);
					num = 81;
					continue;
				case 60:
					this.JqYeWe6KbD.Size = new Size(81, 13);
					num = 127;
					continue;
				case 61:
					this.KYLe4Tbd80.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29170);
					this.KYLe4Tbd80.Size = new Size(76, 13);
					num = 103;
					continue;
				case 62:
					goto IL_DDE;
				case 63:
					this.R0pJKyX3qJ = new DataGridViewTextBoxColumn();
					this.LqrJQsPeFm = new DataGridViewTextBoxColumn();
					this.sqQJSRbNql = new DataGridViewTextBoxColumn();
					this.rgNJku7Xu9 = new DataGridViewTextBoxColumn();
					num = 211;
					continue;
				case 64:
					FormJournalRequestForRepairAddEdit.Fx8k7r2prIDmYHfnReb(this.QQEJ5VCv5Z, false);
					num = 318;
					continue;
				case 65:
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.reaed0XCF6, 9);
					num = 259;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_1294;
					}
					continue;
				case 66:
					this.hnQeNIZkPu = new Label();
					this.gAXeEWFGWu = new Label();
					num = 380;
					continue;
				case 67:
					this.fRlJ4vE12X = new DataGridViewTextBoxColumn();
					this.AZMJB5EVm8 = new DataGridViewTextBoxColumn();
					this.RI9Jlhlmpg = new DataGridViewCheckBoxColumn();
					this.K4tnmquBOV = new BindingSource(this.fH1e1A9RNZ);
					this.k16n0HORUW = new DataSet();
					this.Glkno10FRw = new DataTable();
					this.IebnutXeZ9 = new DataColumn();
					this.kcpnME1c9M = new DataColumn();
					this.er6n8CvbjI = new DataColumn();
					this.zJ3nR52you = new DataColumn();
					this.Ui6nCLYZvx = new DataColumn();
					this.TacJ18fMBC = new DataColumn();
					num = 208;
					if (!true)
					{
						goto IL_2200;
					}
					continue;
				case 68:
					this.TKdnD2UOSQ.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					num = 36;
					continue;
				case 69:
					goto IL_1D89;
				case 70:
					this.XrFnwd9INg.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35448);
					num = 89;
					continue;
				case 71:
					this.tdnnXm7uXt.DisplayStyle = ToolStripItemDisplayStyle.Image;
					this.tdnnXm7uXt.Image = FormJournalRequestForRepairAddEdit.rW6UvV2840p2XvmlJel();
					this.tdnnXm7uXt.ImageTransparentColor = FormJournalRequestForRepairAddEdit.YYuSHy2BDZsWES3vyki();
					FormJournalRequestForRepairAddEdit.vrOmF42y0j24pWR79Pa(this.tdnnXm7uXt, cDhluYseFOthxgEIXpc.nKHKpgTSVU(29882));
					this.tdnnXm7uXt.Size = new Size(23, 22);
					this.tdnnXm7uXt.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29930);
					num = 170;
					if (!true)
					{
						goto IL_5C62;
					}
					continue;
				case 72:
					goto IL_C68;
				case 73:
					this.KKYnt0822j.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.KKYnt0822j.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					num = 198;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_4A67;
					}
					continue;
				case 74:
					this.YxQJup5LHg.HeaderText = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33984);
					this.YxQJup5LHg.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34006);
					num = 190;
					continue;
				case 75:
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.xL1nFot21u, 21);
					num = 6;
					continue;
				case 76:
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.NbVJf7f7GG, cDhluYseFOthxgEIXpc.nKHKpgTSVU(36082));
					this.NbVJf7f7GG.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(36102);
					num = 18;
					continue;
				case 77:
					this.VWNn2NL2TS = new DataGridViewTextBoxColumn();
					this.lahnAiuE7f = new DataGridViewLinkColumn();
					num = 278;
					continue;
				case 78:
					this.VUlJ82xfLS.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678);
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.VUlJ82xfLS, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5678));
					this.VUlJ82xfLS.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34108);
					FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.VUlJ82xfLS, true);
					FormJournalRequestForRepairAddEdit.Pa0crMTPLKMLtMQhd3u(this.VUlJ82xfLS, false);
					num = 239;
					if (false)
					{
						goto IL_2B04;
					}
					continue;
				case 79:
				case 230:
					FormJournalRequestForRepairAddEdit.B37PwE2YaPOSP5ncHRX(this.KKYnt0822j, new EventHandler(this.swSIvFBAJW));
					this.FZInULtqG4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					this.FZInULtqG4.AutoCompleteSource = AutoCompleteSource.ListItems;
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.FZInULtqG4).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4132), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32994), true));
					FormJournalRequestForRepairAddEdit.wxtbji2ewKZVOuHvHhg(this.FZInULtqG4, true);
					this.FZInULtqG4.Location = new Point(101, 62);
					this.FZInULtqG4.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33062);
					num = 24;
					if (!true)
					{
						goto IL_A4F;
					}
					continue;
				case 80:
					this.LqrJQsPeFm.Visible = false;
					this.sqQJSRbNql.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(28974);
					num = 22;
					continue;
				case 81:
					this.rgNJku7Xu9.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(25984);
					num = 54;
					continue;
				case 82:
					this.dSOeiWZtIs.AllowUserToAddRows = false;
					FormJournalRequestForRepairAddEdit.CKPvld2fgZP4OkSoiF6(this.dSOeiWZtIs, false);
					num = 326;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_1051;
					}
					continue;
				case 83:
					goto IL_3A12;
				case 84:
					goto IL_4BAB;
				case 85:
					this.LMVnkuunsG = new DataGridViewTextBoxColumn();
					this.nIBnfX16SG = new DataGridViewTextBoxColumn();
					this.hLln6SFMH0 = new DataGridViewFilterDateTimePickerColumn();
					this.akXnTaWPea = new DataGridViewFilterDateTimePickerColumn();
					this.vBCeYf5BJy = new CheckBox();
					this.hKaeG4RCUy = new CheckBox();
					this.EMnejl09uS = new DateTimePicker();
					num = 88;
					continue;
				case 86:
					this.jbcndg5xWg.DataBindings.Add(new Binding(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4132), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4144), true));
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.jbcndg5xWg, new Point(101, 71));
					num = 216;
					continue;
				case 87:
					goto IL_44E2;
				case 88:
					this.OgTeQRItvM = new Label();
					this.hZDebgcu57 = new DateTimePicker();
					this.uVoewE09vT = new Label();
					this.BhgeS5qeIC = new GroupBox();
					this.kl0niMXXMI = new ComboBox();
					this.kuRnYPi50V = new Label();
					this.jbcndg5xWg = new TextBox();
					this.BAKeTHcuNQ = new ComboBox();
					num = 1;
					if (!true)
					{
						goto IL_B47;
					}
					continue;
				case 89:
					this.XrFnwd9INg.Size = new Size(23, 22);
					this.XrFnwd9INg.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35480);
					FormJournalRequestForRepairAddEdit.R7bt8M2qDmlNM1NviRp(this.XrFnwd9INg, new EventHandler(this.Co2gaCxGTV));
					this.OMgJwJ5vRd.Controls.Add(this.QQEJ5VCv5Z);
					this.OMgJwJ5vRd.Location = new Point(4, 22);
					num = 69;
					continue;
				case 90:
					this.q1fnB5EbgT.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(418);
					FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(this.bgxnjGgfZD).AddRange(new DataColumn[]
					{
						this.omYnbcn0Lm,
						this.o6pnNeOUiG,
						this.VaDnENYonh,
						this.TBmnhB8Zuh,
						this.qhonzR0VkG,
						this.DbGJZUDbOV,
						this.jRsJ3Qrnk2,
						this.HdAJI8Jumk
					});
					FormJournalRequestForRepairAddEdit.gc72w9T9ZMVf8Pgnppi(this.bgxnjGgfZD, cDhluYseFOthxgEIXpc.nKHKpgTSVU(33932));
					num = 178;
					continue;
				case 91:
					FormJournalRequestForRepairAddEdit.DHOVkcT3ewJfO0U6hkl(this.rgNJku7Xu9, cDhluYseFOthxgEIXpc.nKHKpgTSVU(36010));
					num = 379;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_69AA;
					}
					continue;
				case 92:
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.AZMJB5EVm8, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8344));
					this.AZMJB5EVm8.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33728);
					num = 203;
					continue;
				case 93:
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.wULnq8UnPx, cDhluYseFOthxgEIXpc.nKHKpgTSVU(33368));
					FormJournalRequestForRepairAddEdit.BfgJ4aTtbNiKRWZOsR4(this.wULnq8UnPx, true);
					num = 118;
					continue;
				case 94:
					((ISupportInitialize)this.VkBJe6Xc7o).BeginInit();
					this.g1HJnTrcyE.SuspendLayout();
					this.Ms1nJWxRcR.SuspendLayout();
					FormJournalRequestForRepairAddEdit.GsPYk92KHMxWWvtGUFy(this.YoIns0P0S0);
					((ISupportInitialize)this.wtWn793arh).BeginInit();
					FormJournalRequestForRepairAddEdit.nKZUtq2RtiAyOjRL50i(this.Doxna8ogZQ);
					this.OMgJwJ5vRd.SuspendLayout();
					FormJournalRequestForRepairAddEdit.GsPYk92KHMxWWvtGUFy(this.QQEJ5VCv5Z);
					num = 320;
					continue;
				case 95:
					this.b2vnyhrNSS.Location = new Point(388, 368);
					num = 331;
					if (false)
					{
						goto IL_30D8;
					}
					continue;
				case 96:
					this.UheJATZBOd.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6146);
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.UheJATZBOd, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6146));
					num = 3;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_F34;
					}
					continue;
				case 97:
					this.LageL0atao.TabIndex = 0;
					this.LageL0atao.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29050);
					this.aelevmJUSY.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					num = 5;
					continue;
				case 98:
					this.OgTeQRItvM.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30948);
					this.OgTeQRItvM.Size = new Size(19, 13);
					this.OgTeQRItvM.TabIndex = 9;
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.OgTeQRItvM, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30964));
					FormJournalRequestForRepairAddEdit.ctuXt5TXtQYgiPDn6u4(this.hZDebgcu57, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30158));
					this.hZDebgcu57.Format = DateTimePickerFormat.Custom;
					this.hZDebgcu57.Location = new Point(30, 19);
					num = 276;
					if (!true)
					{
						goto IL_1B6A;
					}
					continue;
				case 99:
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.Ms1nJWxRcR, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(34804));
					this.Ms1nJWxRcR.UseVisualStyleBackColor = true;
					this.YoIns0P0S0.AllowUserToAddRows = false;
					this.YoIns0P0S0.AllowUserToDeleteRows = false;
					this.YoIns0P0S0.AutoGenerateColumns = false;
					this.YoIns0P0S0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					FormJournalRequestForRepairAddEdit.uDjqomT4VAhkAee80Tl(this.YoIns0P0S0.Columns, new DataGridViewColumn[]
					{
						this.mXdn547ZHM,
						this.VWNn2NL2TS,
						this.lahnAiuE7f,
						this.dmcnVE0S5N,
						this.QrTn9EhhGj
					});
					this.YoIns0P0S0.DataSource = this.wtWn793arh;
					num = 175;
					continue;
				case 100:
					goto IL_2C98;
				case 101:
					this.nIBnfX16SG.HeaderText = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5678);
					num = 387;
					continue;
				case 102:
					this.Doxna8ogZQ.TabIndex = 0;
					this.Doxna8ogZQ.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1300);
					this.ox7n1cu9hA.DisplayStyle = ToolStripItemDisplayStyle.Image;
					num = 193;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_2C98;
					}
					continue;
				case 103:
					this.KYLe4Tbd80.TabIndex = 4;
					this.KYLe4Tbd80.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29208);
					this.N4DeBMM4KD.AutoSize = true;
					num = 353;
					continue;
				case 104:
					FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.LageL0atao, true);
					this.LageL0atao.Location = new Point(58, 8);
					this.LageL0atao.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29034);
					num = 349;
					continue;
				case 105:
					FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.d6UeKsT72M, true);
					this.d6UeKsT72M.Location = new Point(6, 16);
					num = 287;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_1A32;
					}
					continue;
				case 106:
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.EhhneeGlqI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32298));
					this.EhhneeGlqI.UseVisualStyleBackColor = true;
					num = 284;
					continue;
				case 107:
					this.wULnq8UnPx.DataSource = this.K4tnmquBOV;
					this.wULnq8UnPx.Dock = DockStyle.Fill;
					num = 294;
					continue;
				case 108:
					this.LqrJQsPeFm.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(28942);
					this.LqrJQsPeFm.HeaderText = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(28942);
					this.LqrJQsPeFm.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35866);
					num = 163;
					continue;
				case 109:
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.BhgeS5qeIC.Controls, this.HhaeUjB5lH);
					num = 189;
					if (!true)
					{
						goto IL_EB9;
					}
					continue;
				case 110:
					goto IL_69D7;
				case 111:
					this.z5knSIxS7w.Click += this.aPbgvwwLQh;
					this.vYgJ7S05QP.DisplayStyle = ToolStripItemDisplayStyle.Image;
					FormJournalRequestForRepairAddEdit.DDgc4F2aoeE5nTFb38n(this.vYgJ7S05QP, Resources.FTP);
					this.vYgJ7S05QP.ImageTransparentColor = FormJournalRequestForRepairAddEdit.YYuSHy2BDZsWES3vyki();
					this.vYgJ7S05QP.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33176);
					num = 347;
					continue;
				case 112:
					dataGridViewCellStyle = new DataGridViewCellStyle();
					num = 167;
					continue;
				case 113:
					goto IL_F34;
				case 114:
					this.EQknHC0OS1.Size = new Size(163, 21);
					num = 243;
					continue;
				case 115:
					this.jNxezOc8K1.Size = new Size(724, 25);
					this.jNxezOc8K1.TabIndex = 47;
					this.jNxezOc8K1.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1300);
					this.AF3nZ6Ps4Z.DisplayStyle = ToolStripItemDisplayStyle.Image;
					num = 53;
					continue;
				case 116:
					goto IL_3711;
				case 117:
					this.GRHnGkvVC9.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33334);
					this.GRHnGkvVC9.Orientation = Orientation.Horizontal;
					this.GRHnGkvVC9.Panel1.Controls.Add(this.wULnq8UnPx);
					FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.GRHnGkvVC9.Panel2).Add(this.btQJgjaEtV);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(FormJournalRequestForRepairAddEdit.IQWytxTQobF0Th0Skm9(this.GRHnGkvVC9)), this.g1HJnTrcyE);
					this.GRHnGkvVC9.Size = new Size(724, 612);
					this.GRHnGkvVC9.SplitterDistance = 276;
					this.GRHnGkvVC9.TabIndex = 50;
					num = 340;
					continue;
				case 118:
					this.wULnq8UnPx.RowHeadersWidth = 21;
					FormJournalRequestForRepairAddEdit.yKvphqTwo06vmGxD2pR(this.wULnq8UnPx, DataGridViewRowHeadersWidthSizeMode.DisableResizing);
					this.wULnq8UnPx.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					this.wULnq8UnPx.Size = new Size(724, 276);
					this.wULnq8UnPx.TabIndex = 49;
					FormJournalRequestForRepairAddEdit.YPbHXHTVShC5bELnj8Q(this.wULnq8UnPx, new DataGridViewCellEventHandler(this.tEVgJQTTOb));
					this.wULnq8UnPx.CellFormatting += this.ocxg039VNk;
					this.fYgJOAXHZU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = 362;
					if (!true)
					{
						goto IL_6917;
					}
					continue;
				case 119:
					FormJournalRequestForRepairAddEdit.AZwWOx2MtmsmkLVN5RH(this.aelevmJUSY, new EventHandler(this.slBIY4gJjs));
					this.y7feOpIJtI.DataSetName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29146);
					num = 217;
					continue;
				case 120:
					this.wULnq8UnPx.AllowUserToVisibleColumns = false;
					this.wULnq8UnPx.AutoGenerateColumns = false;
					num = 374;
					continue;
				case 121:
					goto IL_4A67;
				case 122:
					goto IL_4B0E;
				case 123:
					this.btQJgjaEtV = new DataGridViewExcelFilter();
					num = 237;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_184;
					}
					continue;
				case 124:
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.I4xetUTq0V, 7);
					num = 277;
					continue;
				case 125:
					this.Doxna8ogZQ.PerformLayout();
					num = 384;
					if (false)
					{
						goto IL_1C87;
					}
					continue;
				case 126:
					this.hVxnPQA72W.DisplayStyle = ToolStripItemDisplayStyle.Image;
					this.hVxnPQA72W.Image = Resources.UAd3JmH29l();
					this.hVxnPQA72W.ImageTransparentColor = Color.Magenta;
					FormJournalRequestForRepairAddEdit.vrOmF42y0j24pWR79Pa(this.hVxnPQA72W, cDhluYseFOthxgEIXpc.nKHKpgTSVU(35380));
					FormJournalRequestForRepairAddEdit.xIyWMkTMNwI84W4tus3(this.hVxnPQA72W, new Size(23, 22));
					num = 371;
					continue;
				case 127:
					this.JqYeWe6KbD.TabIndex = 3;
					this.JqYeWe6KbD.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31608);
					FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.G5GekMlON7, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormJournalRequestForRepairAddEdit.eNVU9sXVTPdgEbxSF8w(this.G5GekMlON7.DataBindings, new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4132), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31638), true));
					num = 11;
					if (false)
					{
						goto IL_59C3;
					}
					continue;
				case 128:
					goto IL_3D10;
				case 129:
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.GRHnGkvVC9, new Point(3, 28));
					num = 117;
					continue;
				case 130:
					this.DbGJZUDbOV = new DataColumn();
					this.jRsJ3Qrnk2 = new DataColumn();
					num = 261;
					continue;
				case 131:
					this.dSOeiWZtIs = new DataGridView();
					num = 85;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_5CC7;
					}
					continue;
				case 132:
					FormJournalRequestForRepairAddEdit.d2Qbgo2ZnOx7cFOtPJE(this.YgjJ2EKqt4, cDhluYseFOthxgEIXpc.nKHKpgTSVU(28902));
					num = 142;
					continue;
				case 133:
					FormJournalRequestForRepairAddEdit.TJ1s6MTauuEEvdTxbob(FormJournalRequestForRepairAddEdit.IQWytxTQobF0Th0Skm9(this.GRHnGkvVC9));
					this.GRHnGkvVC9.ResumeLayout(false);
					num = 359;
					if (false)
					{
						goto IL_4676;
					}
					continue;
				case 134:
					this.gAXeEWFGWu.Location = new Point(8, 39);
					this.gAXeEWFGWu.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(32080);
					this.gAXeEWFGWu.Size = new Size(84, 13);
					this.gAXeEWFGWu.TabIndex = 16;
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.gAXeEWFGWu, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32096));
					this.MdGehXdP89.CustomFormat = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30158);
					num = 146;
					if (false)
					{
						goto IL_4EA3;
					}
					continue;
				case 135:
					this.xO9ePrsLfp.Controls.Add(this.Po7eAn9peo);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.xO9ePrsLfp), this.hZGeVyEfRI);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.xO9ePrsLfp.Controls, this.d6UeKsT72M);
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.xO9ePrsLfp, new Point(11, 89));
					this.xO9ePrsLfp.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29282);
					this.xO9ePrsLfp.Size = new Size(634, 97);
					num = 253;
					if (false)
					{
						goto IL_4C59;
					}
					continue;
				case 136:
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.xO9ePrsLfp.Controls, this.PTle2wlpsd);
					num = 135;
					continue;
				case 137:
					this.g1HJnTrcyE.ResumeLayout(false);
					num = 210;
					continue;
				case 138:
					this.PTle2wlpsd.Size = new Size(33, 13);
					num = 269;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 139:
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.H8tnxYcybE, new Point(391, 384));
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.H8tnxYcybE, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32440));
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.H8tnxYcybE, new Size(159, 21));
					num = 249;
					continue;
				case 140:
					goto IL_D49;
				case 141:
					goto IL_6061;
				case 142:
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.YgjJ2EKqt4, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1608));
					this.YgjJ2EKqt4.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35570);
					num = 391;
					continue;
				case 143:
				{
					FormJournalRequestForRepairAddEdit.DHOVkcT3ewJfO0U6hkl(this.dmcnVE0S5N, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35064));
					DataGridViewCellStyle dataGridViewCellStyle2;
					FormJournalRequestForRepairAddEdit.VAHV5jTCAl8tdlgcgaE(dataGridViewCellStyle2, null);
					num = 159;
					continue;
				}
				case 144:
					this.R0pJKyX3qJ.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35794);
					FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.R0pJKyX3qJ, true);
					this.R0pJKyX3qJ.Visible = false;
					num = 108;
					continue;
				case 145:
					this.i1pnQHQ2r8.TabIndex = 18;
					num = 298;
					continue;
				case 146:
					FormJournalRequestForRepairAddEdit.eNVU9sXVTPdgEbxSF8w(FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.MdGehXdP89), new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(638), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32126), true));
					this.MdGehXdP89.Enabled = false;
					FormJournalRequestForRepairAddEdit.iHghffT2rfT37fKkltO(this.MdGehXdP89, DateTimePickerFormat.Custom);
					num = 165;
					continue;
				case 147:
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.d7YnphvtQ1, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32658));
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.d7YnphvtQ1, new Size(193, 21));
					num = 197;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 148:
					this.VUlJ82xfLS = new DataGridViewTextBoxColumn();
					this.X68JReQKph = new DataGridViewTextBoxColumn();
					this.LEsJCvsFlo = new DataGridViewTextBoxColumn();
					this.pp6JXxCiZA = new DataGridViewTextBoxColumn();
					this.AmJJqbhcGW = new DataGridViewTextBoxColumn();
					num = 267;
					continue;
				case 149:
					goto IL_5429;
				case 150:
					this.q1fnB5EbgT = new DataColumn();
					this.bgxnjGgfZD = new DataTable();
					this.omYnbcn0Lm = new DataColumn();
					num = 58;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 151:
					FormJournalRequestForRepairAddEdit.d3FFb3Tq1GstUIps4VA(this.GRHnGkvVC9.Panel2, false);
					num = 133;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_235F;
					}
					continue;
				case 152:
					this.YoIns0P0S0.Size = new Size(724, 612);
					this.YoIns0P0S0.TabIndex = 1;
					this.YoIns0P0S0.VirtualMode = true;
					num = 100;
					continue;
				case 153:
					FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.xL1nFot21u, true);
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.xL1nFot21u, new Point(17, 368));
					num = 200;
					continue;
				case 154:
					this.nv7nWxKZai.AutoSize = true;
					this.nv7nWxKZai.Location = new Point(186, 368);
					this.nv7nWxKZai.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32710);
					num = 351;
					continue;
				case 155:
					this.Dv1e6CuU3C.Location = new Point(15, 678);
					this.Dv1e6CuU3C.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31810);
					this.Dv1e6CuU3C.Size = new Size(75, 23);
					this.Dv1e6CuU3C.TabIndex = 10;
					num = 257;
					continue;
				case 156:
					this.Dxiepm5uG7.Size = new Size(77, 13);
					this.Dxiepm5uG7.TabIndex = 4;
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.Dxiepm5uG7, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31564));
					num = 212;
					continue;
				case 157:
					this.OMgJwJ5vRd.TabIndex = 3;
					this.OMgJwJ5vRd.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35544);
					num = 310;
					continue;
				case 158:
					FormJournalRequestForRepairAddEdit.pPJdjyTjs5t4OS57PsA(this.rWoeDxUpjP, true);
					this.rWoeDxUpjP.CheckedChanged += this.qbFgRTsOoo;
					num = 302;
					continue;
				case 159:
				{
					DataGridViewCellStyle dataGridViewCellStyle2;
					this.QrTn9EhhGj.DefaultCellStyle = dataGridViewCellStyle2;
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.QrTn9EhhGj, "");
					this.QrTn9EhhGj.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35132);
					this.QrTn9EhhGj.ReadOnly = true;
					this.QrTn9EhhGj.Resizable = DataGridViewTriState.False;
					num = 232;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_18AA;
					}
					continue;
				}
				case 160:
					FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.BAKeTHcuNQ, AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
					this.BAKeTHcuNQ.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					this.BAKeTHcuNQ.AutoCompleteSource = AutoCompleteSource.ListItems;
					FormJournalRequestForRepairAddEdit.eNVU9sXVTPdgEbxSF8w(FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.BAKeTHcuNQ), new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31158), true));
					this.BAKeTHcuNQ.FormattingEnabled = true;
					this.BAKeTHcuNQ.Location = new Point(412, 145);
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.BAKeTHcuNQ, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31226));
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.BAKeTHcuNQ, new Size(216, 21));
					num = 251;
					continue;
				case 161:
					FormJournalRequestForRepairAddEdit.QqJNhj2u5mpiu0ceV1M(FormJournalRequestForRepairAddEdit.JAMxwvTlJu9faiBC9Og(this.g1HJnTrcyE), new ToolStripItem[]
					{
						this.qUpJJfJyqr,
						this.fNkJ0o0Atj
					});
					this.g1HJnTrcyE.Location = new Point(0, 0);
					this.g1HJnTrcyE.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34594);
					this.g1HJnTrcyE.Size = new Size(724, 25);
					num = 37;
					continue;
				case 162:
					FormJournalRequestForRepairAddEdit.DDgc4F2aoeE5nTFb38n(this.CeanIEi3ht, FormJournalRequestForRepairAddEdit.W2dvau2N7aEQ0eJ4teO());
					FormJournalRequestForRepairAddEdit.peZQcN2SXyR7yhlpaw9(this.CeanIEi3ht, Color.Magenta);
					this.CeanIEi3ht.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30016);
					num = 235;
					continue;
				case 163:
					this.LqrJQsPeFm.ReadOnly = true;
					num = 80;
					continue;
				case 164:
					base.Load += this.FCuI96WxL7;
					((ISupportInitialize)this.y7feOpIJtI).EndInit();
					this.xO9ePrsLfp.ResumeLayout(false);
					FormJournalRequestForRepairAddEdit.TJ1s6MTauuEEvdTxbob(this.xO9ePrsLfp);
					num = 314;
					continue;
				case 165:
					this.MdGehXdP89.Location = new Point(101, 37);
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.MdGehXdP89, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32190));
					this.MdGehXdP89.Size = new Size(181, 20);
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.MdGehXdP89, 17);
					this.MdGehXdP89.Value = new DateTime(2012, 10, 18, 8, 39, 41, 178);
					FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.HgVngSxHtS).Add(this.EhhneeGlqI);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.HgVngSxHtS.Controls, this.DCenneEYOy);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.HgVngSxHtS), this.Ms1nJWxRcR);
					FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.HgVngSxHtS).Add(this.OMgJwJ5vRd);
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.HgVngSxHtS, new Point(0, 0));
					num = 392;
					continue;
				case 166:
					FormJournalRequestForRepairAddEdit.RXonZ3THXGAIAr5WV2b(this.Ms1nJWxRcR, new Padding(3));
					num = 20;
					continue;
				case 167:
				{
					DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
					dataGridViewCellStyle4 = new DataGridViewCellStyle();
					DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
					num = 388;
					if (false)
					{
						goto IL_3EF8;
					}
					continue;
				}
				case 168:
					this.VkBJe6Xc7o = new BindingSource(this.fH1e1A9RNZ);
					this.g1HJnTrcyE = new ToolStrip();
					this.qUpJJfJyqr = new ToolStripButton();
					this.fNkJ0o0Atj = new ToolStripButton();
					this.Ms1nJWxRcR = new TabPage();
					this.YoIns0P0S0 = new DataGridViewExcelFilter();
					this.mXdn547ZHM = new DataGridViewTextBoxColumn();
					num = 77;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_198E;
					}
					continue;
				case 169:
					this.gJsJPJ7k5A = new CheckBox();
					num = 23;
					continue;
				case 170:
					FormJournalRequestForRepairAddEdit.R7bt8M2qDmlNM1NviRp(this.tdnnXm7uXt, new EventHandler(this.GJHgoSLdep));
					FormJournalRequestForRepairAddEdit.tIsTlG26Cq5KEttq2XA(this.bq8n3A7OBi, ToolStripItemDisplayStyle.Image);
					this.bq8n3A7OBi.Image = Resources.ANZh6pKtG();
					this.bq8n3A7OBi.ImageTransparentColor = Color.Magenta;
					FormJournalRequestForRepairAddEdit.vrOmF42y0j24pWR79Pa(this.bq8n3A7OBi, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29960));
					num = 346;
					continue;
				case 171:
					this.fRlJ4vE12X.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33656);
					num = 8;
					if (false)
					{
						goto IL_1D89;
					}
					continue;
				case 172:
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.EhhneeGlqI.Controls, this.boNeyT9U7u);
					FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI).Add(this.aelevmJUSY);
					FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI).Add(this.KYLe4Tbd80);
					this.EhhneeGlqI.Controls.Add(this.BhgeS5qeIC);
					this.EhhneeGlqI.Controls.Add(this.MdGehXdP89);
					num = 290;
					continue;
				case 173:
					goto IL_1528;
				case 174:
					this.AZMJB5EVm8.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8344);
					num = 92;
					continue;
				case 175:
					goto IL_11FC;
				case 176:
					this.HsZefiTdR1.TabIndex = 0;
					this.Dv1e6CuU3C.DialogResult = DialogResult.OK;
					num = 155;
					continue;
				case 177:
					goto IL_5A5;
				case 178:
					FormJournalRequestForRepairAddEdit.pxi9ZCTET6qbSTELNZj(this.omYnbcn0Lm, cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146));
					this.omYnbcn0Lm.DataType = Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777219));
					num = 83;
					continue;
				case 179:
					this.LEsJCvsFlo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					this.LEsJCvsFlo.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(544);
					this.LEsJCvsFlo.FillWeight = 50f;
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.LEsJCvsFlo, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(34256));
					this.LEsJCvsFlo.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(34270);
					FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.LEsJCvsFlo, true);
					FormJournalRequestForRepairAddEdit.d2Qbgo2ZnOx7cFOtPJE(this.pp6JXxCiZA, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11428));
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.pp6JXxCiZA, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11428));
					num = 228;
					if (!true)
					{
						goto IL_47A;
					}
					continue;
				case 180:
					FormJournalRequestForRepairAddEdit.R7bt8M2qDmlNM1NviRp(this.qUpJJfJyqr, new EventHandler(this.avQgwXctpp));
					this.fNkJ0o0Atj.DisplayStyle = ToolStripItemDisplayStyle.Image;
					this.fNkJ0o0Atj.Image = Resources.ANZh6pKtG();
					num = 196;
					continue;
				case 181:
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.EhhneeGlqI.Controls, this.gJsJPJ7k5A);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.EhhneeGlqI.Controls, this.H8tnxYcybE);
					this.EhhneeGlqI.Controls.Add(this.b2vnyhrNSS);
					num = 45;
					if (false)
					{
						goto IL_1EA3;
					}
					continue;
				case 182:
					FormJournalRequestForRepairAddEdit.wxtbji2ewKZVOuHvHhg(this.oyre5Btub4, true);
					this.oyre5Btub4.Items.AddRange(new object[]
					{
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(7338),
						FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(7378)
					});
					num = 289;
					continue;
				case 183:
					goto IL_2891;
				case 184:
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.HsZefiTdR1).Add(new Binding(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(4132), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31720), true));
					this.HsZefiTdR1.Location = new Point(101, 19);
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.HsZefiTdR1, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31782));
					this.HsZefiTdR1.Size = new Size(527, 20);
					num = 176;
					continue;
				case 185:
					this.rWoeDxUpjP.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31444);
					this.rWoeDxUpjP.Size = new Size(92, 17);
					this.rWoeDxUpjP.TabIndex = 6;
					num = 186;
					continue;
				case 186:
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.rWoeDxUpjP, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31476));
					num = 158;
					continue;
				case 187:
					goto IL_235F;
				case 188:
					goto IL_603A;
				case 189:
					goto IL_51C5;
				case 190:
					goto IL_5AD3;
				case 191:
					this.f2QnlcdpJi.Size = new Size(23, 22);
					num = 26;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_5FBF;
					}
					continue;
				case 192:
					FormJournalRequestForRepairAddEdit.TJ1s6MTauuEEvdTxbob(this.BhgeS5qeIC);
					num = 339;
					continue;
				case 193:
					goto IL_28C;
				case 194:
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.LMVnkuunsG, cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146));
					this.LMVnkuunsG.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30500);
					this.LMVnkuunsG.ReadOnly = true;
					this.LMVnkuunsG.Visible = false;
					FormJournalRequestForRepairAddEdit.d2Qbgo2ZnOx7cFOtPJE(this.nIBnfX16SG, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678));
					num = 101;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_4765;
					}
					continue;
				case 195:
					this.HgVngSxHtS = new TabControl();
					this.EhhneeGlqI = new TabPage();
					num = 169;
					if (false)
					{
						goto IL_C68;
					}
					continue;
				case 196:
					FormJournalRequestForRepairAddEdit.peZQcN2SXyR7yhlpaw9(this.fNkJ0o0Atj, FormJournalRequestForRepairAddEdit.YYuSHy2BDZsWES3vyki());
					this.fNkJ0o0Atj.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34700);
					FormJournalRequestForRepairAddEdit.xIyWMkTMNwI84W4tus3(this.fNkJ0o0Atj, new Size(23, 22));
					this.fNkJ0o0Atj.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34738);
					this.fNkJ0o0Atj.Click += this.fP9g5jvweG;
					FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.Ms1nJWxRcR).Add(this.YoIns0P0S0);
					this.Ms1nJWxRcR.Controls.Add(this.Doxna8ogZQ);
					num = 35;
					continue;
				case 197:
					this.d7YnphvtQ1.TabIndex = 24;
					this.d7YnphvtQ1.SelectedIndexChanged += this.tOnIz7ycX5;
					num = 154;
					continue;
				case 198:
					this.KKYnt0822j.AutoCompleteSource = AutoCompleteSource.ListItems;
					FormJournalRequestForRepairAddEdit.eNVU9sXVTPdgEbxSF8w(FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.KKYnt0822j), new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3886), true));
					this.KKYnt0822j.FormattingEnabled = true;
					this.KKYnt0822j.Location = new Point(358, 63);
					num = 334;
					continue;
				case 199:
					goto IL_5C62;
				case 200:
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.xL1nFot21u, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32894));
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.xL1nFot21u, new Size(111, 13));
					num = 75;
					if (false)
					{
						goto IL_1F93;
					}
					continue;
				case 201:
					this.EhhneeGlqI.Controls.Add(this.mqUexv2WmH);
					this.EhhneeGlqI.Controls.Add(this.DB7eF6ajiX);
					num = 357;
					continue;
				case 202:
					goto IL_4A7A;
				case 203:
					this.AZMJB5EVm8.ReadOnly = true;
					FormJournalRequestForRepairAddEdit.Pa0crMTPLKMLtMQhd3u(this.AZMJB5EVm8, false);
					this.RI9Jlhlmpg.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33790);
					this.RI9Jlhlmpg.HeaderText = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33790);
					this.RI9Jlhlmpg.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33810);
					num = 55;
					continue;
				case 204:
					this.b2vnyhrNSS.Size = new Size(74, 13);
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.b2vnyhrNSS, 25);
					this.b2vnyhrNSS.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32544);
					num = 265;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 205:
					goto IL_4B60;
				case 206:
					FormJournalRequestForRepairAddEdit.Lj9OFDTrKfVOhUSVyud(this.EMnejl09uS, DateTimePickerFormat.Custom);
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.EMnejl09uS, new Point(30, 43));
					num = 222;
					if (false)
					{
						goto IL_5394;
					}
					continue;
				case 207:
					FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.dSOeiWZtIs, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
					FormJournalRequestForRepairAddEdit.Fx8k7r2prIDmYHfnReb(this.dSOeiWZtIs, false);
					FormJournalRequestForRepairAddEdit.EsS7gP2OdsEsTUqs4Je(this.dSOeiWZtIs, DataGridViewColumnHeadersHeightSizeMode.AutoSize);
					FormJournalRequestForRepairAddEdit.qWWP2arZ7RpmanieB4V(this.dSOeiWZtIs).AddRange(new DataGridViewColumn[]
					{
						this.LMVnkuunsG,
						this.nIBnfX16SG,
						this.hLln6SFMH0,
						this.akXnTaWPea
					});
					this.dSOeiWZtIs.DataMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30428);
					this.dSOeiWZtIs.DataSource = this.y7feOpIJtI;
					num = 49;
					continue;
				case 208:
					this.gYanOthiX8 = new DataTable();
					this.s7onLWJGpX = new DataColumn();
					this.ngrnvWyUkq = new DataColumn();
					this.R13n4s4744 = new DataColumn();
					num = 150;
					continue;
				case 209:
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.OcuJaJU1lF, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29372));
					this.OcuJaJU1lF.Size = new Size(262, 21);
					this.OcuJaJU1lF.TabIndex = 7;
					num = 68;
					continue;
				case 210:
					this.g1HJnTrcyE.PerformLayout();
					this.Ms1nJWxRcR.ResumeLayout(false);
					this.Ms1nJWxRcR.PerformLayout();
					((ISupportInitialize)this.YoIns0P0S0).EndInit();
					((ISupportInitialize)this.wtWn793arh).EndInit();
					FormJournalRequestForRepairAddEdit.d3FFb3Tq1GstUIps4VA(this.Doxna8ogZQ, false);
					num = 125;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 211:
					this.NbVJf7f7GG = new DataGridViewTextBoxColumn();
					this.UaEJ6qjvWD = new DataGridViewCheckBoxColumn();
					num = 363;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_5429;
					}
					continue;
				case 212:
					FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.JqYeWe6KbD, true);
					num = 40;
					continue;
				case 213:
					this.dSOeiWZtIs.CellEndEdit += this.B5SIFY0JS6;
					this.dSOeiWZtIs.CellFormatting += this.snaIyqTYvW;
					this.dSOeiWZtIs.EditingControlShowing += this.x1jIx63cPC;
					this.dSOeiWZtIs.RowsAdded += this.uWMIpSGpQA;
					FormJournalRequestForRepairAddEdit.j4AVtB2JFCDgsI160K2(this.dSOeiWZtIs, new DataGridViewRowsRemovedEventHandler(this.mkpIHd63xX));
					this.LMVnkuunsG.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146);
					num = 194;
					continue;
				case 214:
					this.hKaeG4RCUy.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30888);
					num = 397;
					continue;
				case 215:
					this.TBmnhB8Zuh = new DataColumn();
					this.qhonzR0VkG = new DataColumn();
					num = 130;
					continue;
				case 216:
					this.jbcndg5xWg.Multiline = true;
					num = 223;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_5D98;
					}
					continue;
				case 217:
					this.y7feOpIJtI.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
					this.KYLe4Tbd80.AutoSize = true;
					this.KYLe4Tbd80.Location = new Point(8, 66);
					num = 61;
					continue;
				case 218:
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.hnQeNIZkPu, new Point(276, 86));
					num = 311;
					continue;
				case 219:
					((ISupportInitialize)this.VkBJe6Xc7o).EndInit();
					num = 137;
					continue;
				case 220:
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.dmcnVE0S5N, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31564));
					num = 143;
					continue;
				case 221:
					FormJournalRequestForRepairAddEdit.RXonZ3THXGAIAr5WV2b(this.EhhneeGlqI, new Padding(3));
					this.EhhneeGlqI.Size = new Size(657, 643);
					this.EhhneeGlqI.TabIndex = 0;
					num = 106;
					continue;
				case 222:
					goto IL_198E;
				case 223:
					this.jbcndg5xWg.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31136);
					this.jbcndg5xWg.ReadOnly = true;
					this.jbcndg5xWg.ScrollBars = ScrollBars.Vertical;
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.jbcndg5xWg, new Size(527, 72));
					this.jbcndg5xWg.TabIndex = 11;
					num = 160;
					continue;
				case 224:
					this.vBCeYf5BJy.Enabled = false;
					num = 285;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_56E3;
					}
					continue;
				case 225:
					this.btQJgjaEtV.Location = new Point(0, 25);
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.btQJgjaEtV, cDhluYseFOthxgEIXpc.nKHKpgTSVU(33960));
					this.btQJgjaEtV.ReadOnly = true;
					this.btQJgjaEtV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.btQJgjaEtV, new Size(724, 307));
					this.btQJgjaEtV.TabIndex = 1;
					this.YxQJup5LHg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					this.YxQJup5LHg.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(512);
					FormJournalRequestForRepairAddEdit.p46eyWTeSoeADUWcLsi(this.YxQJup5LHg, 30f);
					num = 74;
					continue;
				case 226:
					this.yAXJvrM2tq.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33558);
					num = 382;
					continue;
				case 227:
					this.hVxnPQA72W = new ToolStripButton();
					this.XrFnwd9INg = new ToolStripButton();
					this.OMgJwJ5vRd = new TabPage();
					this.QQEJ5VCv5Z = new DataGridViewExcelFilter();
					this.YgjJ2EKqt4 = new DataGridViewTextBoxColumn();
					this.UheJATZBOd = new DataGridViewTextBoxColumn();
					this.oGkJV73aOo = new DataGridViewTextBoxColumn();
					num = 63;
					continue;
				case 228:
					this.pp6JXxCiZA.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34336);
					FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.pp6JXxCiZA, true);
					this.pp6JXxCiZA.Visible = false;
					num = 378;
					continue;
				case 229:
					this.qTqJTaBgHY.Size = new Size(75, 23);
					this.qTqJTaBgHY.TabIndex = 51;
					num = 348;
					continue;
				case 231:
					goto IL_4C59;
				case 232:
					FormJournalRequestForRepairAddEdit.deukkRTF7Rt0wvQiN3n(this.QrTn9EhhGj, 30);
					this.wtWn793arh.DataMember = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35158);
					num = 242;
					if (false)
					{
						goto IL_4195;
					}
					continue;
				case 233:
					goto IL_44CA;
				case 234:
				{
					this.hLln6SFMH0.FillWeight = 50f;
					this.hLln6SFMH0.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30630);
					FormJournalRequestForRepairAddEdit.DHOVkcT3ewJfO0U6hkl(this.hLln6SFMH0, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30646));
					FormJournalRequestForRepairAddEdit.axYLMTTWqs4m57ZAOBK(this.hLln6SFMH0, DataGridViewTriState.True);
					this.akXnTaWPea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					this.akXnTaWPea.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(8074);
					DataGridViewCellStyle dataGridViewCellStyle3;
					dataGridViewCellStyle3.Format = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30158);
					this.akXnTaWPea.DefaultCellStyle = dataGridViewCellStyle3;
					this.akXnTaWPea.FillWeight = 50f;
					this.akXnTaWPea.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30714);
					FormJournalRequestForRepairAddEdit.DHOVkcT3ewJfO0U6hkl(this.akXnTaWPea, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30736));
					this.akXnTaWPea.Resizable = DataGridViewTriState.True;
					this.vBCeYf5BJy.AutoSize = true;
					FormJournalRequestForRepairAddEdit.NBfopwTLpWlFe7WBkQd(this.vBCeYf5BJy, true);
					num = 233;
					continue;
				}
				case 235:
					this.CeanIEi3ht.Size = new Size(23, 22);
					this.CeanIEi3ht.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30056);
					num = 281;
					continue;
				case 236:
					goto IL_2797;
				case 237:
					this.YxQJup5LHg = new DataGridViewTextBoxColumn();
					this.LAVJMoZ4gI = new DataGridViewTextBoxColumn();
					num = 148;
					continue;
				case 238:
					goto IL_3B65;
				case 239:
					this.X68JReQKph.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(11380);
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.X68JReQKph, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11380));
					num = 247;
					if (false)
					{
						goto IL_2671;
					}
					continue;
				case 240:
					this.btQJgjaEtV.Dock = DockStyle.Fill;
					num = 225;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_5A5;
					}
					continue;
				case 241:
					FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.gJsJPJ7k5A, true);
					FormJournalRequestForRepairAddEdit.eNVU9sXVTPdgEbxSF8w(this.gJsJPJ7k5A.DataBindings, new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(31370), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32312), true));
					this.gJsJPJ7k5A.Location = new Point(20, 620);
					num = 47;
					continue;
				case 242:
					FormJournalRequestForRepairAddEdit.jpYmLkTg8aDh8kR7C2k(this.wtWn793arh, this.y7feOpIJtI);
					FormJournalRequestForRepairAddEdit.QqJNhj2u5mpiu0ceV1M(FormJournalRequestForRepairAddEdit.JAMxwvTlJu9faiBC9Og(this.Doxna8ogZQ), new ToolStripItem[]
					{
						this.ox7n1cu9hA,
						this.f2QnlcdpJi,
						this.hVxnPQA72W,
						this.XrFnwd9INg
					});
					this.Doxna8ogZQ.Location = new Point(3, 3);
					this.Doxna8ogZQ.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35206);
					num = 9;
					continue;
				case 243:
					this.EQknHC0OS1.TabIndex = 22;
					this.EQknHC0OS1.SelectedIndexChanged += this.eUIIhaxvel;
					num = 153;
					continue;
				case 244:
					this.fYgJOAXHZU = new DataGridViewTextBoxColumn();
					this.qg8JLSAKNQ = new DataGridViewTextBoxColumn();
					this.yAXJvrM2tq = new DataGridViewTextBoxColumn();
					num = 67;
					continue;
				case 245:
					goto IL_69AA;
				case 246:
					base.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(36400);
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this, cDhluYseFOthxgEIXpc.nKHKpgTSVU(36400));
					FormJournalRequestForRepairAddEdit.pgDCkjTYLq7gr9xYoK9(this, new FormClosingEventHandler(this.uCUI2Vw7df));
					FormJournalRequestForRepairAddEdit.nijWuSTuYfmanHIaNhP(this, new FormClosedEventHandler(this.FYZIA61Cwp));
					num = 164;
					if (false)
					{
						goto IL_3711;
					}
					continue;
				case 247:
					goto IL_3EF8;
				case 248:
					this.qg8JLSAKNQ.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8326);
					this.qg8JLSAKNQ.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30630);
					num = 238;
					continue;
				case 249:
					this.H8tnxYcybE.TabIndex = 26;
					this.H8tnxYcybE.SelectedIndexChanged += this.EA2gZiikTe;
					this.cElnrI7wvf.DataMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(32470);
					this.cElnrI7wvf.DataSource = this.y7feOpIJtI;
					FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.b2vnyhrNSS, true);
					num = 95;
					continue;
				case 250:
					this.DCenneEYOy.Padding = new Padding(3);
					this.DCenneEYOy.Size = new Size(730, 643);
					this.DCenneEYOy.TabIndex = 1;
					this.DCenneEYOy.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33282);
					this.DCenneEYOy.UseVisualStyleBackColor = true;
					num = 296;
					continue;
				case 251:
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.BAKeTHcuNQ, 10);
					this.reaed0XCF6.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
					FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.reaed0XCF6, true);
					this.reaed0XCF6.Location = new Point(329, 151);
					this.reaed0XCF6.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31256);
					this.reaed0XCF6.Size = new Size(77, 13);
					num = 65;
					continue;
				case 252:
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI), this.lfWeHeTrZJ);
					num = 201;
					if (false)
					{
						goto IL_5E4F;
					}
					continue;
				case 253:
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.xO9ePrsLfp, 8);
					this.xO9ePrsLfp.TabStop = false;
					FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.OcuJaJU1lF, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.OcuJaJU1lF).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29304), true));
					this.OcuJaJU1lF.FormattingEnabled = true;
					this.OcuJaJU1lF.Location = new Point(366, 68);
					num = 209;
					continue;
				case 254:
					this.C99elfqXty.Size = new Size(287, 21);
					this.C99elfqXty.TabIndex = 7;
					FormJournalRequestForRepairAddEdit.AZwWOx2MtmsmkLVN5RH(this.C99elfqXty, new EventHandler(this.YUnIjlccXu));
					this.C99elfqXty.SelectedValueChanged += this.HLwIL63Sgc;
					this.xO9ePrsLfp.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.xO9ePrsLfp).Add(this.OcuJaJU1lF);
					num = 355;
					continue;
				case 255:
					goto IL_5D32;
				case 256:
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.EhhneeGlqI.Controls, this.EQknHC0OS1);
					num = 202;
					continue;
				case 257:
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.Dv1e6CuU3C, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31830));
					this.Dv1e6CuU3C.UseVisualStyleBackColor = true;
					this.Dv1e6CuU3C.Click += this.lZVgX99vto;
					this.lfWeHeTrZJ.DataBindings.Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31838), true));
					FormJournalRequestForRepairAddEdit.UWqpjArXYKvNq5q0LAa(this.lfWeHeTrZJ, false);
					this.lfWeHeTrZJ.FormattingEnabled = true;
					this.lfWeHeTrZJ.Location = new Point(101, 5);
					this.lfWeHeTrZJ.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31906);
					this.lfWeHeTrZJ.Size = new Size(181, 21);
					num = 367;
					continue;
				case 258:
					this.i1pnQHQ2r8.Dock = DockStyle.None;
					this.i1pnQHQ2r8.GripStyle = ToolStripGripStyle.Hidden;
					FormJournalRequestForRepairAddEdit.JAMxwvTlJu9faiBC9Og(this.i1pnQHQ2r8).AddRange(new ToolStripItem[]
					{
						this.z5knSIxS7w,
						this.vYgJ7S05QP
					});
					this.i1pnQHQ2r8.Location = new Point(0, 0);
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.i1pnQHQ2r8, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33096));
					this.i1pnQHQ2r8.Size = new Size(26, 25);
					num = 145;
					continue;
				case 259:
					this.reaed0XCF6.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31274);
					num = 307;
					continue;
				case 260:
					goto IL_2F0C;
				case 261:
					this.HdAJI8Jumk = new DataColumn();
					num = 123;
					continue;
				case 262:
					this.TacJ18fMBC.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33790);
					num = 113;
					continue;
				case 263:
					goto IL_42C2;
				case 264:
					this.z5knSIxS7w.ImageTransparentColor = Color.Magenta;
					this.z5knSIxS7w.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33126);
					this.z5knSIxS7w.Size = new Size(23, 22);
					this.z5knSIxS7w.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33152);
					num = 111;
					continue;
				case 265:
					this.d7YnphvtQ1.DataBindings.Add(new Binding(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32572), true));
					this.d7YnphvtQ1.FormattingEnabled = true;
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.d7YnphvtQ1, new Point(189, 384));
					num = 147;
					if (false)
					{
						goto IL_248;
					}
					continue;
				case 266:
					this.aelevmJUSY.Size = new Size(21, 21);
					this.aelevmJUSY.TabIndex = 3;
					this.aelevmJUSY.Visible = false;
					num = 119;
					if (true)
					{
						continue;
					}
					break;
				case 267:
					this.FH5JmNqvLS = new DataGridViewTextBoxColumn();
					num = 168;
					continue;
				case 268:
					this.UaEJ6qjvWD.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29018);
					FormJournalRequestForRepairAddEdit.DHOVkcT3ewJfO0U6hkl(this.UaEJ6qjvWD, cDhluYseFOthxgEIXpc.nKHKpgTSVU(36170));
					this.UaEJ6qjvWD.ReadOnly = true;
					num = 4;
					continue;
				case 269:
					this.PTle2wlpsd.TabIndex = 3;
					this.PTle2wlpsd.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29554);
					num = 345;
					if (false)
					{
						goto IL_49E5;
					}
					continue;
				case 270:
					this.fYgJOAXHZU.SortMode = DataGridViewColumnSortMode.NotSortable;
					num = 248;
					continue;
				case 271:
					this.EQknHC0OS1.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(32860);
					num = 114;
					continue;
				case 272:
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.I4xetUTq0V, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31318));
					num = 343;
					continue;
				case 273:
					this.jNxezOc8K1.Location = new Point(3, 3);
					this.jNxezOc8K1.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29770);
					num = 115;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_16DD;
					}
					continue;
				case 274:
					this.QrTn9EhhGj = new DataGridViewImageColumnNotNull();
					this.wtWn793arh = new BindingSource(this.fH1e1A9RNZ);
					this.Doxna8ogZQ = new ToolStrip();
					this.ox7n1cu9hA = new ToolStripButton();
					num = 373;
					if (!true)
					{
						goto IL_4912;
					}
					continue;
				case 275:
					this.boNeyT9U7u.Location = new Point(11, 192);
					this.boNeyT9U7u.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30094);
					this.boNeyT9U7u.Size = new Size(634, 173);
					this.boNeyT9U7u.TabIndex = 10;
					FormJournalRequestForRepairAddEdit.Icf5QS2AKHMJsXhtLct(this.boNeyT9U7u, false);
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.boNeyT9U7u, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30124));
					this.M5ZJs51OCB.CustomFormat = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30158);
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.M5ZJs51OCB).Add(new Binding(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30194), true));
					this.M5ZJs51OCB.Format = DateTimePickerFormat.Custom;
					this.M5ZJs51OCB.Location = new Point(351, 144);
					num = 330;
					continue;
				case 276:
					this.hZDebgcu57.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30972);
					this.hZDebgcu57.Size = new Size(124, 20);
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.hZDebgcu57, 0);
					this.hZDebgcu57.ValueChanged += this.gvsIt7q2yI;
					num = 288;
					continue;
				case 277:
					goto IL_5CC7;
				case 278:
					this.dmcnVE0S5N = new DataGridViewTextBoxColumn();
					num = 274;
					continue;
				case 279:
					this.HhaeUjB5lH.AutoSize = true;
					this.HhaeUjB5lH.Location = new Point(121, 153);
					num = 291;
					continue;
				case 280:
					goto IL_5F27;
				case 281:
					this.CeanIEi3ht.Click += this.jXFgMoUXV2;
					this.boNeyT9U7u.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.boNeyT9U7u.Controls.Add(this.M5ZJs51OCB);
					this.boNeyT9U7u.Controls.Add(this.BVUnc3Sli2);
					this.boNeyT9U7u.Controls.Add(this.VkYerU8Qhx);
					num = 110;
					continue;
				case 282:
					this.mqUexv2WmH.Size = new Size(287, 20);
					this.mqUexv2WmH.TabIndex = 14;
					this.hnQeNIZkPu.AutoSize = true;
					num = 218;
					continue;
				case 283:
					goto IL_49E5;
				case 284:
					this.gJsJPJ7k5A.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
					num = 241;
					continue;
				case 285:
					this.vBCeYf5BJy.Location = new Point(9, 92);
					num = 231;
					if (!true)
					{
						goto IL_5D32;
					}
					continue;
				case 286:
					goto IL_47A;
				case 287:
					goto IL_4061;
				case 288:
					goto IL_2B04;
				case 289:
					goto IL_1F93;
				case 290:
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI), this.gAXeEWFGWu);
					this.EhhneeGlqI.Controls.Add(this.xO9ePrsLfp);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.EhhneeGlqI.Controls, this.N4DeBMM4KD);
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI), this.hnQeNIZkPu);
					num = 252;
					if (false)
					{
						goto IL_603A;
					}
					continue;
				case 291:
					this.HhaeUjB5lH.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31300);
					this.HhaeUjB5lH.Size = new Size(33, 13);
					this.HhaeUjB5lH.TabIndex = 8;
					this.HhaeUjB5lH.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(1608);
					this.I4xetUTq0V.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.I4xetUTq0V).Add(new Binding(FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(638), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3946), true));
					this.I4xetUTq0V.Location = new Point(160, 147);
					num = 272;
					continue;
				case 292:
					this.vYgJ7S05QP = new ToolStripButton();
					this.DCenneEYOy = new TabPage();
					this.GRHnGkvVC9 = new SplitContainer();
					num = 38;
					continue;
				case 293:
					this.hnQeNIZkPu.Visible = false;
					this.gAXeEWFGWu.AutoSize = true;
					num = 134;
					continue;
				case 294:
					goto IL_42E8;
				case 295:
					this.N4DeBMM4KD.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29254);
					FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.C99elfqXty, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormJournalRequestForRepairAddEdit.EaXXbr2v6WwmZrntatT(this.C99elfqXty, AutoCompleteMode.SuggestAppend);
					FormJournalRequestForRepairAddEdit.Hd1A822C2AlsEijRlOS(this.C99elfqXty, AutoCompleteSource.ListItems);
					this.C99elfqXty.DataBindings.Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(3834), true));
					this.C99elfqXty.FormattingEnabled = true;
					this.C99elfqXty.Location = new Point(358, 36);
					num = 369;
					continue;
				case 296:
					FormJournalRequestForRepairAddEdit.XY0CuxT7mI6uVGjgT6w(this.GRHnGkvVC9, DockStyle.Fill);
					num = 129;
					continue;
				case 297:
					FormJournalRequestForRepairAddEdit.pxi9ZCTET6qbSTELNZj(this.jRsJ3Qrnk2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(584));
					num = 27;
					continue;
				case 298:
					this.i1pnQHQ2r8.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1300);
					this.z5knSIxS7w.DisplayStyle = ToolStripItemDisplayStyle.Image;
					FormJournalRequestForRepairAddEdit.DDgc4F2aoeE5nTFb38n(this.z5knSIxS7w, Resources.ghgYek0Wi());
					num = 264;
					continue;
				case 299:
					this.VkYerU8Qhx.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30382);
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.VkYerU8Qhx, new Size(75, 23));
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.VkYerU8Qhx, 13);
					num = 56;
					continue;
				case 300:
					goto IL_3B9E;
				case 301:
					this.Po7eAn9peo.TabIndex = 2;
					this.Po7eAn9peo.TextChanged += this.v4sINLtf5q;
					FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.hZGeVyEfRI, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.hZGeVyEfRI).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4132), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(29648), true));
					num = 46;
					continue;
				case 302:
					FormJournalRequestForRepairAddEdit.EQnYmDTnmSSjyd2iyQA(this.rWoeDxUpjP, new EventHandler(this.wTGgCapMoI));
					FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.psNecTr5ut, true);
					this.psNecTr5ut.Location = new Point(6, 74);
					this.psNecTr5ut.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31502);
					this.psNecTr5ut.Size = new Size(44, 13);
					this.psNecTr5ut.TabIndex = 5;
					num = 375;
					continue;
				case 303:
					this.Ui6nCLYZvx.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777306));
					num = 262;
					continue;
				case 304:
					this.kl0niMXXMI.FormattingEnabled = true;
					this.kl0niMXXMI.Location = new Point(160, 170);
					num = 21;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_D49;
					}
					continue;
				case 305:
					this.Dv1e6CuU3C = new Button();
					this.lfWeHeTrZJ = new ComboBox();
					this.DB7eF6ajiX = new Label();
					num = 52;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 306:
					goto IL_18AA;
				case 307:
					goto IL_1051;
				case 308:
					this.f2QnlcdpJi.DisplayStyle = ToolStripItemDisplayStyle.Image;
					num = 149;
					continue;
				case 309:
					goto IL_1294;
				case 310:
					this.OMgJwJ5vRd.UseVisualStyleBackColor = true;
					this.QQEJ5VCv5Z.AllowUserToAddRows = false;
					this.QQEJ5VCv5Z.AllowUserToDeleteRows = false;
					num = 64;
					if (!true)
					{
						goto IL_3B65;
					}
					continue;
				case 311:
					this.hnQeNIZkPu.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32034);
					this.hnQeNIZkPu.Size = new Size(56, 13);
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.hnQeNIZkPu, 15);
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.hnQeNIZkPu, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32060));
					num = 293;
					continue;
				case 312:
					goto IL_A4F;
				case 313:
					this.X68JReQKph.ReadOnly = true;
					this.X68JReQKph.Visible = false;
					num = 179;
					continue;
				case 314:
					FormJournalRequestForRepairAddEdit.d3FFb3Tq1GstUIps4VA(this.jNxezOc8K1, false);
					this.jNxezOc8K1.PerformLayout();
					this.boNeyT9U7u.ResumeLayout(false);
					this.boNeyT9U7u.PerformLayout();
					num = 188;
					continue;
				case 315:
					goto IL_184;
				case 316:
					goto IL_2200;
				case 317:
					this.kuRnYPi50V.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31106);
					FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.jbcndg5xWg, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
					this.jbcndg5xWg.BackColor = SystemColors.Window;
					num = 86;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 318:
					goto IL_1D0;
				case 319:
					this.dmcnVE0S5N.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = 283;
					continue;
				case 320:
					((ISupportInitialize)this.K6VJ9XsaK9).BeginInit();
					num = 329;
					continue;
				case 321:
					FormJournalRequestForRepairAddEdit.eNVU9sXVTPdgEbxSF8w(this.H8tnxYcybE.DataBindings, new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.cElnrI7wvf, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5266), true));
					this.H8tnxYcybE.FormattingEnabled = true;
					num = 139;
					if (!true)
					{
						goto IL_2891;
					}
					continue;
				case 322:
					FormJournalRequestForRepairAddEdit.DHOVkcT3ewJfO0U6hkl(this.AmJJqbhcGW, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(34426));
					FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.AmJJqbhcGW, true);
					num = 358;
					continue;
				case 323:
					this.fYgJOAXHZU.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33418);
					this.fYgJOAXHZU.ReadOnly = true;
					num = 270;
					continue;
				case 324:
					goto IL_EB9;
				case 325:
					((ISupportInitialize)this.Glkno10FRw).BeginInit();
					((ISupportInitialize)this.gYanOthiX8).BeginInit();
					((ISupportInitialize)this.bgxnjGgfZD).BeginInit();
					num = 128;
					continue;
				case 326:
					goto IL_32A7;
				case 327:
					FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.TKdnD2UOSQ).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(3768), true));
					num = 13;
					continue;
				case 328:
					goto IL_2DE0;
				case 329:
					base.SuspendLayout();
					num = 104;
					continue;
				case 330:
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.M5ZJs51OCB, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30260));
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.M5ZJs51OCB, new Size(188, 20));
					num = 177;
					continue;
				case 331:
					goto IL_2E11;
				case 332:
					this.boNeyT9U7u = new GroupBox();
					this.M5ZJs51OCB = new NullableDateTimePicker();
					this.BVUnc3Sli2 = new Label();
					this.VkYerU8Qhx = new Button();
					num = 131;
					continue;
				case 333:
					this.AF3nZ6Ps4Z.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29844);
					FormJournalRequestForRepairAddEdit.R7bt8M2qDmlNM1NviRp(this.AF3nZ6Ps4Z, new EventHandler(this.YQlgnIUWiF));
					num = 71;
					continue;
				case 334:
					this.KKYnt0822j.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(32972);
					num = 44;
					continue;
				case 335:
					this.Hrwe9GBchc.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29494);
					this.PTle2wlpsd.AutoSize = true;
					num = 32;
					continue;
				case 336:
					this.BVUnc3Sli2.AutoSize = true;
					this.BVUnc3Sli2.Location = new Point(175, 148);
					this.BVUnc3Sli2.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30306);
					this.BVUnc3Sli2.Size = new Size(176, 13);
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.BVUnc3Sli2, 14);
					this.BVUnc3Sli2.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30322);
					this.VkYerU8Qhx.Location = new Point(9, 115);
					num = 299;
					continue;
				case 337:
					this.VWNn2NL2TS.HeaderText = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5678);
					this.VWNn2NL2TS.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(34908);
					num = 370;
					continue;
				case 338:
					FormJournalRequestForRepairAddEdit.eEkiM2T8Lf8N3vSArv3(this.k16n0HORUW);
					((ISupportInitialize)this.Glkno10FRw).EndInit();
					((ISupportInitialize)this.gYanOthiX8).EndInit();
					num = 84;
					continue;
				case 339:
					this.HgVngSxHtS.ResumeLayout(false);
					this.EhhneeGlqI.ResumeLayout(false);
					this.EhhneeGlqI.PerformLayout();
					num = 300;
					continue;
				case 340:
					FormJournalRequestForRepairAddEdit.DAm92fT1p83nmWbvYiI(this.wULnq8UnPx, false);
					this.wULnq8UnPx.AllowUserToDeleteRows = false;
					num = 120;
					continue;
				case 341:
					this.FZInULtqG4 = new ComboBox();
					this.i1pnQHQ2r8 = new ToolStrip();
					this.z5knSIxS7w = new ToolStripButton();
					num = 292;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 342:
					goto IL_5394;
				case 343:
					this.I4xetUTq0V.Size = new Size(163, 20);
					num = 124;
					if (!true)
					{
						goto IL_3D10;
					}
					continue;
				case 344:
					FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.g1HJnTrcyE, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1300));
					this.qUpJJfJyqr.DisplayStyle = ToolStripItemDisplayStyle.Image;
					FormJournalRequestForRepairAddEdit.DDgc4F2aoeE5nTFb38n(this.qUpJJfJyqr, Resources.Im7NYV1iO());
					this.qUpJJfJyqr.ImageTransparentColor = FormJournalRequestForRepairAddEdit.YYuSHy2BDZsWES3vyki();
					num = 12;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_550C;
					}
					continue;
				case 345:
					FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.Po7eAn9peo, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.Po7eAn9peo.DataBindings.Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4132), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29566), true));
					this.Po7eAn9peo.Location = new Point(101, 42);
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.Po7eAn9peo, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29624));
					this.Po7eAn9peo.Size = new Size(527, 20);
					num = 301;
					continue;
				case 346:
					this.bq8n3A7OBi.Size = new Size(23, 22);
					this.bq8n3A7OBi.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29998);
					FormJournalRequestForRepairAddEdit.R7bt8M2qDmlNM1NviRp(this.bq8n3A7OBi, new EventHandler(this.JsogubfOH2));
					this.CeanIEi3ht.DisplayStyle = ToolStripItemDisplayStyle.Image;
					this.CeanIEi3ht.Enabled = false;
					num = 162;
					continue;
				case 347:
					this.vYgJ7S05QP.Size = new Size(23, 22);
					this.vYgJ7S05QP.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33216);
					this.vYgJ7S05QP.Visible = false;
					FormJournalRequestForRepairAddEdit.R7bt8M2qDmlNM1NviRp(this.vYgJ7S05QP, new EventHandler(this.YEmgVGelHs));
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.DCenneEYOy), this.GRHnGkvVC9);
					num = 394;
					continue;
				case 348:
					this.qTqJTaBgHY.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(36384);
					this.qTqJTaBgHY.UseVisualStyleBackColor = true;
					this.qTqJTaBgHY.Click += this.AX9gqGfduq;
					base.AcceptButton = this.Dv1e6CuU3C;
					num = 0;
					if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						continue;
					}
					continue;
				case 349:
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.LageL0atao, new Size(37, 13));
					num = 97;
					continue;
				case 350:
					FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.ROTnK6JpmV, new Point(240, 682));
					num = 14;
					continue;
				case 351:
					this.nv7nWxKZai.Size = new Size(144, 13);
					num = 260;
					continue;
				case 352:
					FormJournalRequestForRepairAddEdit.uDjqomT4VAhkAee80Tl(FormJournalRequestForRepairAddEdit.qWWP2arZ7RpmanieB4V(this.QQEJ5VCv5Z), new DataGridViewColumn[]
					{
						this.YgjJ2EKqt4,
						this.UheJATZBOd,
						this.oGkJV73aOo,
						this.R0pJKyX3qJ,
						this.LqrJQsPeFm,
						this.sqQJSRbNql,
						this.rgNJku7Xu9,
						this.NbVJf7f7GG,
						this.UaEJ6qjvWD
					});
					this.QQEJ5VCv5Z.DataSource = this.K6VJ9XsaK9;
					this.QQEJ5VCv5Z.Dock = DockStyle.Fill;
					num = 381;
					continue;
				case 353:
					this.N4DeBMM4KD.Location = new Point(305, 39);
					this.N4DeBMM4KD.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29236);
					FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.N4DeBMM4KD, new Size(38, 13));
					this.N4DeBMM4KD.TabIndex = 6;
					num = 295;
					continue;
				case 354:
					this.TKdnD2UOSQ.SelectedValueChanged += this.aoVIBnICPf;
					this.oyre5Btub4.DataBindings.Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(3706), true));
					num = 182;
					if (!true)
					{
						goto IL_3A12;
					}
					continue;
				case 355:
					goto IL_4096;
				case 356:
					this.ROTnK6JpmV.Click += this.aPbgvwwLQh;
					this.WYcJoUVlbK.DoWork += this.EaxgBgllje;
					num = 28;
					continue;
				case 357:
					FormJournalRequestForRepairAddEdit.xwvFLpTTLNMolTdyBMw(this.EhhneeGlqI, new Point(4, 22));
					goto IL_1687;
				case 358:
					this.FH5JmNqvLS.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(614);
					this.FH5JmNqvLS.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(614);
					this.FH5JmNqvLS.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(34490);
					num = 39;
					if (!true)
					{
						goto IL_AB1;
					}
					continue;
				case 359:
					((ISupportInitialize)this.wULnq8UnPx).EndInit();
					((ISupportInitialize)this.K4tnmquBOV).EndInit();
					num = 338;
					continue;
				case 360:
					FormJournalRequestForRepairAddEdit.uDjqomT4VAhkAee80Tl(this.btQJgjaEtV.Columns, new DataGridViewColumn[]
					{
						this.YxQJup5LHg,
						this.LAVJMoZ4gI,
						this.VUlJ82xfLS,
						this.X68JReQKph,
						this.LEsJCvsFlo,
						this.pp6JXxCiZA,
						this.AmJJqbhcGW,
						this.FH5JmNqvLS
					});
					goto IL_5F27;
				case 361:
					this.LAVJMoZ4gI.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146);
					this.LAVJMoZ4gI.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(34068);
					this.LAVJMoZ4gI.ReadOnly = true;
					this.LAVJMoZ4gI.Visible = false;
					num = 78;
					continue;
				case 362:
					break;
				case 363:
					this.K6VJ9XsaK9 = new BindingSource(this.fH1e1A9RNZ);
					this.ROTnK6JpmV = new Button();
					num = 364;
					continue;
				case 364:
					this.WYcJoUVlbK = new BackgroundWorker();
					num = 309;
					continue;
				case 365:
					FormJournalRequestForRepairAddEdit.nKZUtq2RtiAyOjRL50i(this.GRHnGkvVC9.Panel2);
					this.GRHnGkvVC9.SuspendLayout();
					FormJournalRequestForRepairAddEdit.GsPYk92KHMxWWvtGUFy(this.wULnq8UnPx);
					((ISupportInitialize)this.K4tnmquBOV).BeginInit();
					num = 62;
					continue;
				case 366:
					this.AF3nZ6Ps4Z = new ToolStripButton();
					num = 199;
					continue;
				case 367:
					goto IL_66FF;
				case 368:
					goto IL_2380;
				case 369:
					FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.C99elfqXty, cDhluYseFOthxgEIXpc.nKHKpgTSVU(29268));
					num = 254;
					continue;
				case 370:
					FormJournalRequestForRepairAddEdit.Pa0crMTPLKMLtMQhd3u(this.VWNn2NL2TS, false);
					this.lahnAiuE7f.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400);
					num = 386;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_11FC;
					}
					continue;
				case 371:
					goto IL_4912;
				case 372:
					this.HhaeUjB5lH = new Label();
					this.I4xetUTq0V = new NullableDateTimePicker();
					this.rWoeDxUpjP = new CheckBox();
					this.psNecTr5ut = new Label();
					this.Dxiepm5uG7 = new Label();
					this.JqYeWe6KbD = new Label();
					this.G5GekMlON7 = new TextBox();
					this.HsZefiTdR1 = new TextBox();
					num = 305;
					if (!FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
					{
						goto IL_5AD3;
					}
					continue;
				case 373:
					this.f2QnlcdpJi = new ToolStripButton();
					num = 227;
					continue;
				case 374:
					goto IL_6917;
				case 375:
					goto IL_2A40;
				case 376:
					goto IL_1687;
				case 377:
					goto IL_1C87;
				case 378:
					this.AmJJqbhcGW.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					FormJournalRequestForRepairAddEdit.d2Qbgo2ZnOx7cFOtPJE(this.AmJJqbhcGW, cDhluYseFOthxgEIXpc.nKHKpgTSVU(584));
					FormJournalRequestForRepairAddEdit.p46eyWTeSoeADUWcLsi(this.AmJJqbhcGW, 20f);
					this.AmJJqbhcGW.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34416);
					num = 322;
					continue;
				case 379:
					goto IL_30D8;
				case 380:
					goto IL_1EA3;
				case 381:
					this.QQEJ5VCv5Z.Location = new Point(3, 3);
					this.QQEJ5VCv5Z.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1556);
					num = 42;
					if (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
					{
						goto IL_4296;
					}
					continue;
				case 382:
					this.yAXJvrM2tq.ReadOnly = true;
					FormJournalRequestForRepairAddEdit.pupHQgTbuY0rfWZ4swv(this.yAXJvrM2tq, DataGridViewColumnSortMode.NotSortable);
					this.yAXJvrM2tq.Width = 90;
					FormJournalRequestForRepairAddEdit.d2Qbgo2ZnOx7cFOtPJE(this.fRlJ4vE12X, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8464));
					FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.fRlJ4vE12X, cDhluYseFOthxgEIXpc.nKHKpgTSVU(33628));
					num = 171;
					continue;
				case 383:
					this.EhhneeGlqI.SuspendLayout();
					((ISupportInitialize)this.cElnrI7wvf).BeginInit();
					this.i1pnQHQ2r8.SuspendLayout();
					this.DCenneEYOy.SuspendLayout();
					FormJournalRequestForRepairAddEdit.Q8gQje2EAETN4EhsTag(this.GRHnGkvVC9).SuspendLayout();
					num = 365;
					continue;
				case 384:
					goto IL_5D98;
				case 385:
					FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.hZGeVyEfRI, 1);
					this.hZGeVyEfRI.TextChanged += this.gygIbKOPTU;
					num = 105;
					continue;
				case 386:
					this.lahnAiuE7f.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34982);
					this.lahnAiuE7f.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34994);
					this.lahnAiuE7f.ReadOnly = true;
					this.lahnAiuE7f.Resizable = DataGridViewTriState.True;
					this.lahnAiuE7f.SortMode = DataGridViewColumnSortMode.Automatic;
					num = 25;
					continue;
				case 387:
					this.nIBnfX16SG.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30558);
					num = 72;
					continue;
				case 388:
					goto IL_5DBB;
				case 389:
					goto IL_2671;
				case 390:
					this.mqUexv2WmH.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.mqUexv2WmH.DataBindings.Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4132), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31968), true));
					this.mqUexv2WmH.Location = new Point(358, 5);
					this.mqUexv2WmH.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32018);
					this.mqUexv2WmH.ReadOnly = true;
					num = 282;
					continue;
				case 391:
					goto IL_59C3;
				case 392:
					this.HgVngSxHtS.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32242);
					this.HgVngSxHtS.SelectedIndex = 0;
					this.HgVngSxHtS.Size = new Size(665, 669);
					this.HgVngSxHtS.TabIndex = 49;
					num = 181;
					continue;
				case 393:
					this.DCenneEYOy.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33246);
					num = 250;
					continue;
				case 394:
					FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.DCenneEYOy), this.jNxezOc8K1);
					this.DCenneEYOy.Location = new Point(4, 22);
					num = 393;
					continue;
				case 395:
					this.hKaeG4RCUy.CheckedChanged += this.cGQIU7Llfn;
					FormJournalRequestForRepairAddEdit.ctuXt5TXtQYgiPDn6u4(this.EMnejl09uS, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30158));
					num = 206;
					continue;
				case 396:
					goto IL_2E53;
				case 397:
					this.hKaeG4RCUy.UseVisualStyleBackColor = true;
					num = 395;
					continue;
				case 398:
					return;
				default:
					num = 376;
					if (!true)
					{
						goto IL_66FF;
					}
					continue;
				}
				this.fYgJOAXHZU.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440);
				FormJournalRequestForRepairAddEdit.Pxs1sMTk4iZXs71gVuX(dataGridViewCellStyle4, DataGridViewTriState.True);
				FormJournalRequestForRepairAddEdit.U8Cdq9TdtJp0kv5yo0E(this.fYgJOAXHZU, dataGridViewCellStyle4);
				FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.fYgJOAXHZU, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33400));
				num = 323;
				continue;
				IL_184:
				this.kuRnYPi50V.Location = new Point(74, 173);
				FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.kuRnYPi50V, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31080));
				FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.kuRnYPi50V, new Size(80, 13));
				num = 16;
				if (!false)
				{
					continue;
				}
				IL_1D0:
				FormJournalRequestForRepairAddEdit.EsS7gP2OdsEsTUqs4Je(this.QQEJ5VCv5Z, DataGridViewColumnHeadersHeightSizeMode.AutoSize);
				num = 352;
				continue;
				IL_248:
				FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.VkYerU8Qhx, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30408));
				this.VkYerU8Qhx.UseVisualStyleBackColor = true;
				FormJournalRequestForRepairAddEdit.uGJJSR2sXJhWqkoxdqY(this.VkYerU8Qhx, new EventHandler(this.x2qIrJvtsH));
				num = 82;
				if (!false)
				{
					continue;
				}
				IL_28C:
				this.ox7n1cu9hA.Image = FormJournalRequestForRepairAddEdit.Wx6RPET0C0g2oPySNma();
				this.ox7n1cu9hA.ImageTransparentColor = Color.Magenta;
				this.ox7n1cu9hA.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35246);
				this.ox7n1cu9hA.Size = new Size(23, 22);
				this.ox7n1cu9hA.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35276);
				FormJournalRequestForRepairAddEdit.R7bt8M2qDmlNM1NviRp(this.ox7n1cu9hA, new EventHandler(this.UYagm69vbR));
				num = 308;
				continue;
				IL_47A:
				FormJournalRequestForRepairAddEdit.eEkiM2T8Lf8N3vSArv3(this.K6VJ9XsaK9);
				num = 121;
				continue;
				IL_5A5:
				this.M5ZJs51OCB.TabIndex = 16;
				FormJournalRequestForRepairAddEdit.Age8e7rBwnUnrkBdeKK(this.M5ZJs51OCB, new DateTime(2015, 8, 10, 13, 57, 6, 22));
				FormJournalRequestForRepairAddEdit.eeOOKK259Tcfc6HfKLY(this.BVUnc3Sli2, AnchorStyles.Bottom | AnchorStyles.Left);
				num = 336;
				continue;
				IL_A4F:
				this.FZInULtqG4.TabIndex = 19;
				num = 57;
				continue;
				IL_AB1:
				this.JqYeWe6KbD.Location = new Point(6, 22);
				this.JqYeWe6KbD.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31590);
				num = 60;
				continue;
				IL_B47:
				this.Doxna8ogZQ.Size = new Size(724, 25);
				num = 102;
				continue;
				IL_C68:
				this.nIBnfX16SG.Visible = false;
				FormJournalRequestForRepairAddEdit.q2q5Qe2cltAQLet3WP7(this.hLln6SFMH0, DataGridViewAutoSizeColumnMode.Fill);
				this.hLln6SFMH0.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(8056);
				FormJournalRequestForRepairAddEdit.J42syv2z21HnWe9MIjT(dataGridViewCellStyle, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30158));
				this.hLln6SFMH0.DefaultCellStyle = dataGridViewCellStyle;
				num = 234;
				continue;
				IL_D49:
				this.KYLe4Tbd80 = new Label();
				this.N4DeBMM4KD = new Label();
				this.C99elfqXty = new ComboBox();
				this.xO9ePrsLfp = new GroupBox();
				this.OcuJaJU1lF = new ComboBox();
				num = 10;
				continue;
				IL_DDE:
				((ISupportInitialize)this.k16n0HORUW).BeginInit();
				num = 325;
				continue;
				IL_EB9:
				this.qg8JLSAKNQ.Width = 90;
				this.yAXJvrM2tq.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(280);
				FormJournalRequestForRepairAddEdit.ysX2WS2IlahWhI9WQTs(this.yAXJvrM2tq, cDhluYseFOthxgEIXpc.nKHKpgTSVU(30714));
				num = 226;
				continue;
				IL_F34:
				FormJournalRequestForRepairAddEdit.W2SEiWTKdpTuj2VEhEk(this.TacJ18fMBC, Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777220)));
				FormJournalRequestForRepairAddEdit.F0oo1wXKhsvFKTAWurU(this.gYanOthiX8).AddRange(new DataColumn[]
				{
					this.s7onLWJGpX,
					this.ngrnvWyUkq,
					this.R13n4s4744,
					this.q1fnB5EbgT
				});
				FormJournalRequestForRepairAddEdit.gc72w9T9ZMVf8Pgnppi(this.gYanOthiX8, cDhluYseFOthxgEIXpc.nKHKpgTSVU(33884));
				this.s7onLWJGpX.AllowDBNull = false;
				this.s7onLWJGpX.AutoIncrement = true;
				this.s7onLWJGpX.ColumnName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6146);
				FormJournalRequestForRepairAddEdit.W2SEiWTKdpTuj2VEhEk(this.s7onLWJGpX, Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777219)));
				FormJournalRequestForRepairAddEdit.WJu3eoTiPxwuCTHtt4L(this.ngrnvWyUkq, false);
				this.ngrnvWyUkq.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678);
				this.ngrnvWyUkq.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219));
				num = 29;
				continue;
				IL_1051:
				this.HhaeUjB5lH.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
				num = 279;
				continue;
				IL_11FC:
				FormJournalRequestForRepairAddEdit.p741RDTvfgQtbkNKqYP(this.YoIns0P0S0, DockStyle.Fill);
				this.YoIns0P0S0.Location = new Point(3, 28);
				num = 43;
				continue;
				IL_1247:
				this.K6VJ9XsaK9.DataMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(36238);
				FormJournalRequestForRepairAddEdit.jpYmLkTg8aDh8kR7C2k(this.K6VJ9XsaK9, this.y7feOpIJtI);
				num = 245;
				continue;
				IL_1294:
				this.qTqJTaBgHY = new Button();
				((ISupportInitialize)this.y7feOpIJtI).BeginInit();
				this.xO9ePrsLfp.SuspendLayout();
				this.jNxezOc8K1.SuspendLayout();
				this.boNeyT9U7u.SuspendLayout();
				((ISupportInitialize)this.dSOeiWZtIs).BeginInit();
				this.BhgeS5qeIC.SuspendLayout();
				FormJournalRequestForRepairAddEdit.nKZUtq2RtiAyOjRL50i(this.HgVngSxHtS);
				num = 383;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				IL_12FC:
				this.TKdnD2UOSQ = new ComboBox();
				num = 122;
				continue;
				IL_1528:
				FormJournalRequestForRepairAddEdit.TsP0YuTobowBmPJks55(this).Add(this.ROTnK6JpmV);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.TsP0YuTobowBmPJks55(this), this.HgVngSxHtS);
				base.Controls.Add(this.Dv1e6CuU3C);
				num = 246;
				continue;
				IL_1687:
				this.EhhneeGlqI.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(32266);
				num = 221;
				continue;
				IL_16DD:
				FormJournalRequestForRepairAddEdit.DHOVkcT3ewJfO0U6hkl(this.UheJATZBOd, cDhluYseFOthxgEIXpc.nKHKpgTSVU(35638));
				num = 87;
				continue;
				IL_18AA:
				this.aelevmJUSY.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(29124);
				num = 266;
				continue;
				IL_198E:
				this.EMnejl09uS.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30910);
				this.EMnejl09uS.Size = new Size(124, 20);
				this.EMnejl09uS.TabIndex = 1;
				this.EMnejl09uS.ValueChanged += this.T0oIDJBCH9;
				FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.OgTeQRItvM, true);
				FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.OgTeQRItvM, new Point(6, 50));
				num = 98;
				continue;
				IL_1A32:
				this.HdAJI8Jumk.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(614);
				num = 41;
				continue;
				IL_1B6A:
				this.WYcJoUVlbK.RunWorkerCompleted += this.Q3lglppsmI;
				num = 205;
				continue;
				IL_1C87:
				this.aelevmJUSY = new ComboBox();
				this.y7feOpIJtI = new E1YGNRmqUpG01b1DWc();
				num = 140;
				continue;
				IL_1D89:
				this.OMgJwJ5vRd.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35520);
				FormJournalRequestForRepairAddEdit.RXonZ3THXGAIAr5WV2b(this.OMgJwJ5vRd, new Padding(3));
				this.OMgJwJ5vRd.Size = new Size(730, 643);
				num = 157;
				continue;
				IL_1EA3:
				this.MdGehXdP89 = new NullableDateTimePicker();
				num = 195;
				continue;
				IL_1F93:
				FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.oyre5Btub4, new Point(101, 68));
				this.oyre5Btub4.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29434);
				FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.oyre5Btub4, new Size(121, 21));
				this.oyre5Btub4.TabIndex = 5;
				num = 116;
				continue;
				IL_2200:
				FormJournalRequestForRepairAddEdit.q2q5Qe2cltAQLet3WP7(this.NbVJf7f7GG, DataGridViewAutoSizeColumnMode.Fill);
				this.NbVJf7f7GG.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29000);
				num = 76;
				continue;
				IL_235F:
				FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.EQknHC0OS1, new Point(20, 384));
				num = 271;
				continue;
				IL_2380:
				this.btQJgjaEtV.DataSource = this.VkBJe6Xc7o;
				num = 240;
				continue;
				IL_5F27:
				goto IL_2380;
				IL_2671:
				this.Dxiepm5uG7.AutoSize = true;
				this.Dxiepm5uG7.Location = new Point(6, 48);
				FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.Dxiepm5uG7, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31546));
				num = 156;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				continue;
				IL_26EF:
				this.FH5JmNqvLS.ReadOnly = true;
				this.FH5JmNqvLS.Visible = false;
				this.VkBJe6Xc7o.DataMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33932);
				FormJournalRequestForRepairAddEdit.jpYmLkTg8aDh8kR7C2k(this.VkBJe6Xc7o, this.k16n0HORUW);
				this.VkBJe6Xc7o.Sort = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34552);
				num = 161;
				continue;
				IL_2797:
				this.fH1e1A9RNZ = new Container();
				num = 112;
				continue;
				IL_2891:
				this.BhgeS5qeIC.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31032);
				FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.BhgeS5qeIC, new Size(634, 200));
				this.BhgeS5qeIC.TabIndex = 9;
				this.BhgeS5qeIC.TabStop = false;
				this.BhgeS5qeIC.VisibleChanged += this.e8jIQGscGs;
				this.kl0niMXXMI.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
				FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.kl0niMXXMI).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4076), true));
				num = 304;
				continue;
				IL_2A40:
				this.psNecTr5ut.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31530);
				num = 389;
				continue;
				IL_2B04:
				this.uVoewE09vT.AutoSize = true;
				FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.uVoewE09vT, new Point(11, 22));
				FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.uVoewE09vT, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31010));
				FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.uVoewE09vT, new Size(13, 13));
				this.uVoewE09vT.TabIndex = 8;
				FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.uVoewE09vT, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31026));
				this.BhgeS5qeIC.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
				this.BhgeS5qeIC.Controls.Add(this.kl0niMXXMI);
				this.BhgeS5qeIC.Controls.Add(this.kuRnYPi50V);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.BhgeS5qeIC.Controls, this.jbcndg5xWg);
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.BhgeS5qeIC).Add(this.BAKeTHcuNQ);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.BhgeS5qeIC), this.reaed0XCF6);
				num = 109;
				continue;
				IL_2C98:
				this.YoIns0P0S0.CellContentClick += this.zVBgO3AqiM;
				this.YoIns0P0S0.CellValueNeeded += this.rTFg1NniZF;
				this.mXdn547ZHM.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146);
				this.mXdn547ZHM.HeaderText = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(6146);
				this.mXdn547ZHM.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(34844);
				this.mXdn547ZHM.ReadOnly = true;
				this.mXdn547ZHM.Visible = false;
				this.VWNn2NL2TS.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5678);
				num = 337;
				continue;
				IL_2DE0:
				FormJournalRequestForRepairAddEdit.Pa0crMTPLKMLtMQhd3u(this.UheJATZBOd, false);
				FormJournalRequestForRepairAddEdit.d2Qbgo2ZnOx7cFOtPJE(this.oGkJV73aOo, cDhluYseFOthxgEIXpc.nKHKpgTSVU(5678));
				num = 19;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					continue;
				}
				IL_2E11:
				this.b2vnyhrNSS.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(32512);
				num = 204;
				continue;
				IL_2E53:
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.boNeyT9U7u.Controls, this.hZDebgcu57);
				num = 263;
				continue;
				IL_2F0C:
				FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.nv7nWxKZai, 23);
				FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.nv7nWxKZai, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32742));
				FormJournalRequestForRepairAddEdit.hWudIpX4UUXqgaMjHED(this.EQknHC0OS1).Add(new Binding(cDhluYseFOthxgEIXpc.nKHKpgTSVU(3676), this.y7feOpIJtI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32792), true));
				this.EQknHC0OS1.FormattingEnabled = true;
				num = 187;
				continue;
				IL_30D8:
				FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.rgNJku7Xu9, true);
				FormJournalRequestForRepairAddEdit.Pa0crMTPLKMLtMQhd3u(this.rgNJku7Xu9, false);
				num = 316;
				continue;
				IL_32A7:
				this.dSOeiWZtIs.AllowUserToResizeRows = false;
				num = 207;
				if (!false)
				{
					continue;
				}
				IL_32BF:
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI).Add(this.d7YnphvtQ1);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI), this.nv7nWxKZai);
				num = 256;
				continue;
				IL_3711:
				FormJournalRequestForRepairAddEdit.AZwWOx2MtmsmkLVN5RH(this.oyre5Btub4, new EventHandler(this.fysIiODTLs));
				FormJournalRequestForRepairAddEdit.B37PwE2YaPOSP5ncHRX(this.oyre5Btub4, new EventHandler(this.tJRIlGe1K4));
				FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.Hrwe9GBchc, true);
				num = 34;
				continue;
				IL_3A12:
				this.o6pnNeOUiG.ColumnName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(5678);
				this.o6pnNeOUiG.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219));
				FormJournalRequestForRepairAddEdit.pxi9ZCTET6qbSTELNZj(this.VaDnENYonh, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(512));
				FormJournalRequestForRepairAddEdit.pxi9ZCTET6qbSTELNZj(this.TBmnhB8Zuh, cDhluYseFOthxgEIXpc.nKHKpgTSVU(11380));
				FormJournalRequestForRepairAddEdit.W2SEiWTKdpTuj2VEhEk(this.TBmnhB8Zuh, Type.GetTypeFromHandle(FormJournalRequestForRepairAddEdit.LwAUTbXqEZ1mfdmc55N(16777219)));
				FormJournalRequestForRepairAddEdit.pxi9ZCTET6qbSTELNZj(this.qhonzR0VkG, cDhluYseFOthxgEIXpc.nKHKpgTSVU(544));
				this.DbGJZUDbOV.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(11428);
				this.DbGJZUDbOV.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219));
				num = 297;
				continue;
				IL_3B65:
				this.qg8JLSAKNQ.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33488);
				this.qg8JLSAKNQ.ReadOnly = true;
				FormJournalRequestForRepairAddEdit.pupHQgTbuY0rfWZ4swv(this.qg8JLSAKNQ, DataGridViewColumnSortMode.NotSortable);
				num = 324;
				if (!false)
				{
					continue;
				}
				IL_3B9E:
				((ISupportInitialize)this.cElnrI7wvf).EndInit();
				FormJournalRequestForRepairAddEdit.d3FFb3Tq1GstUIps4VA(this.i1pnQHQ2r8, false);
				this.i1pnQHQ2r8.PerformLayout();
				FormJournalRequestForRepairAddEdit.d3FFb3Tq1GstUIps4VA(this.DCenneEYOy, false);
				this.DCenneEYOy.PerformLayout();
				this.GRHnGkvVC9.Panel1.ResumeLayout(false);
				num = 151;
				continue;
				IL_3D10:
				((ISupportInitialize)this.btQJgjaEtV).BeginInit();
				num = 94;
				continue;
				IL_3EF8:
				FormJournalRequestForRepairAddEdit.DHOVkcT3ewJfO0U6hkl(this.X68JReQKph, cDhluYseFOthxgEIXpc.nKHKpgTSVU(34182));
				num = 313;
				continue;
				IL_4061:
				this.d6UeKsT72M.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29728);
				FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.d6UeKsT72M, new Size(45, 13));
				num = 2;
				if (true)
				{
					continue;
				}
				IL_4096:
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.xO9ePrsLfp.Controls, this.TKdnD2UOSQ);
				this.xO9ePrsLfp.Controls.Add(this.oyre5Btub4);
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.xO9ePrsLfp).Add(this.Hrwe9GBchc);
				num = 136;
				continue;
				IL_4195:
				this.Glkno10FRw.TableName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33848);
				this.IebnutXeZ9.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(8440);
				FormJournalRequestForRepairAddEdit.pxi9ZCTET6qbSTELNZj(this.kcpnME1c9M, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(8326));
				num = 48;
				continue;
				IL_4296:
				this.H8tnxYcybE = new ComboBox();
				this.cElnrI7wvf = new BindingSource(this.fH1e1A9RNZ);
				num = 51;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				IL_42C2:
				this.boNeyT9U7u.Controls.Add(this.uVoewE09vT);
				num = 275;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				IL_42E8:
				this.wULnq8UnPx.Location = new Point(0, 0);
				num = 93;
				continue;
				IL_44CA:
				this.vBCeYf5BJy.CheckState = CheckState.Checked;
				num = 224;
				if (true)
				{
					continue;
				}
				IL_44E2:
				FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.UheJATZBOd, true);
				num = 328;
				continue;
				IL_4676:
				this.jNxezOc8K1 = new ToolStrip();
				num = 366;
				continue;
				IL_4765:
				this.R13n4s4744.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400);
				num = 90;
				continue;
				IL_4912:
				FormJournalRequestForRepairAddEdit.PAyBQJTxeDbQR3vow1v(this.hVxnPQA72W, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(35412));
				this.hVxnPQA72W.Click += this.yM9g7qaZTt;
				FormJournalRequestForRepairAddEdit.tIsTlG26Cq5KEttq2XA(this.XrFnwd9INg, ToolStripItemDisplayStyle.Image);
				this.XrFnwd9INg.Image = Resources.Lqh3efR8su();
				FormJournalRequestForRepairAddEdit.peZQcN2SXyR7yhlpaw9(this.XrFnwd9INg, FormJournalRequestForRepairAddEdit.YYuSHy2BDZsWES3vyki());
				num = 70;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				continue;
				IL_49E5:
				this.dmcnVE0S5N.DataPropertyName = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(418);
				num = 220;
				continue;
				IL_4A67:
				FormJournalRequestForRepairAddEdit.fgx9qDTBjxJCM0JJ67r(this, false);
				num = 398;
				if (true)
				{
					continue;
				}
				IL_4A7A:
				this.EhhneeGlqI.Controls.Add(this.xL1nFot21u);
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI).Add(this.KKYnt0822j);
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI).Add(this.FZInULtqG4);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.EhhneeGlqI.Controls, this.i1pnQHQ2r8);
				this.EhhneeGlqI.Controls.Add(this.C99elfqXty);
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.EhhneeGlqI).Add(this.LageL0atao);
				num = 172;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					continue;
				}
				IL_4B0E:
				this.oyre5Btub4 = new ComboBox();
				this.Hrwe9GBchc = new Label();
				this.PTle2wlpsd = new Label();
				this.Po7eAn9peo = new TextBox();
				this.hZGeVyEfRI = new TextBox();
				this.d6UeKsT72M = new Label();
				num = 17;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					continue;
				}
				IL_4B60:
				this.qTqJTaBgHY.DialogResult = DialogResult.Cancel;
				this.qTqJTaBgHY.Location = new Point(574, 678);
				FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.qTqJTaBgHY, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(36356));
				num = 229;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					continue;
				}
				IL_4BAB:
				((ISupportInitialize)this.bgxnjGgfZD).EndInit();
				FormJournalRequestForRepairAddEdit.eEkiM2T8Lf8N3vSArv3(this.btQJgjaEtV);
				num = 219;
				continue;
				IL_4C59:
				FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.vBCeYf5BJy, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30804));
				this.vBCeYf5BJy.Size = new Size(78, 17);
				FormJournalRequestForRepairAddEdit.DBajFH2ovCKgO9W7RWG(this.vBCeYf5BJy, 11);
				FormJournalRequestForRepairAddEdit.TPyCQyr1rSoVdPc1BNC(this.vBCeYf5BJy, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30838));
				FormJournalRequestForRepairAddEdit.pPJdjyTjs5t4OS57PsA(this.vBCeYf5BJy, true);
				this.hKaeG4RCUy.AutoSize = true;
				this.hKaeG4RCUy.Location = new Point(9, 69);
				this.hKaeG4RCUy.Name = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(30858);
				this.hKaeG4RCUy.Size = new Size(83, 17);
				this.hKaeG4RCUy.TabIndex = 10;
				num = 214;
				continue;
				IL_4EA3:
				this.TKdnD2UOSQ.FormattingEnabled = true;
				this.TKdnD2UOSQ.Items.AddRange(new object[]
				{
					FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(7338),
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(7378)
				});
				this.TKdnD2UOSQ.Location = new Point(230, 68);
				FormJournalRequestForRepairAddEdit.Togv3k20GW1VC1LEFj1(this.TKdnD2UOSQ, FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(29402));
				this.TKdnD2UOSQ.Size = new Size(121, 21);
				this.TKdnD2UOSQ.TabIndex = 6;
				num = 354;
				continue;
				IL_51C5:
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.BhgeS5qeIC).Add(this.I4xetUTq0V);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.BhgeS5qeIC), this.rWoeDxUpjP);
				this.BhgeS5qeIC.Controls.Add(this.psNecTr5ut);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.BhgeS5qeIC.Controls, this.Dxiepm5uG7);
				this.BhgeS5qeIC.Controls.Add(this.JqYeWe6KbD);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.BhgeS5qeIC.Controls, this.G5GekMlON7);
				this.BhgeS5qeIC.Controls.Add(this.HsZefiTdR1);
				num = 31;
				if (true)
				{
					continue;
				}
				IL_526B:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				FormJournalRequestForRepairAddEdit.AlCGXWThF2KIxtOVOZZ(this, AutoScaleMode.Font);
				base.CancelButton = this.qTqJTaBgHY;
				num = 33;
				continue;
				IL_5394:
				this.KKYnt0822j.TabIndex = 20;
				num = (FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW() ? 368 : 79);
				continue;
				IL_5429:
				FormJournalRequestForRepairAddEdit.DDgc4F2aoeE5nTFb38n(this.f2QnlcdpJi, Resources.ANZh6pKtG());
				FormJournalRequestForRepairAddEdit.peZQcN2SXyR7yhlpaw9(this.f2QnlcdpJi, Color.Magenta);
				this.f2QnlcdpJi.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(35314);
				num = 191;
				continue;
				IL_550C:
				this.fRlJ4vE12X.ReadOnly = true;
				FormJournalRequestForRepairAddEdit.pupHQgTbuY0rfWZ4swv(this.fRlJ4vE12X, DataGridViewColumnSortMode.NotSortable);
				FormJournalRequestForRepairAddEdit.deukkRTF7Rt0wvQiN3n(this.fRlJ4vE12X, 90);
				num = 174;
				continue;
				IL_56E3:
				this.lahnAiuE7f.Width = 200;
				num = 319;
				continue;
				IL_59C3:
				this.YgjJ2EKqt4.ReadOnly = true;
				num = 96;
				continue;
				IL_5AD3:
				FormJournalRequestForRepairAddEdit.N8r9VGTmf9yBDxGVNmZ(this.YxQJup5LHg, true);
				this.LAVJMoZ4gI.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146);
				num = 361;
				continue;
				IL_5C62:
				this.tdnnXm7uXt = new ToolStripButton();
				this.bq8n3A7OBi = new ToolStripButton();
				this.CeanIEi3ht = new ToolStripButton();
				num = 332;
				continue;
				IL_5CC7:
				FormJournalRequestForRepairAddEdit.Age8e7rBwnUnrkBdeKK(this.I4xetUTq0V, new DateTime(2012, 9, 26, 9, 58, 28, 932));
				this.rWoeDxUpjP.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
				FormJournalRequestForRepairAddEdit.a4YtIK292EObyLVyjgd(this.rWoeDxUpjP, true);
				num = 15;
				continue;
				IL_5D32:
				this.ROTnK6JpmV.Size = new Size(75, 23);
				this.ROTnK6JpmV.TabIndex = 50;
				this.ROTnK6JpmV.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(33152);
				num = 30;
				if (!FormJournalRequestForRepairAddEdit.AuhgiaXQH2hbQAAkBWW())
				{
					continue;
				}
				continue;
				IL_5D98:
				this.OMgJwJ5vRd.ResumeLayout(false);
				((ISupportInitialize)this.QQEJ5VCv5Z).EndInit();
				num = 286;
				if (!false)
				{
					continue;
				}
				IL_5DBB:
				this.LageL0atao = new Label();
				num = 377;
				continue;
				IL_5E4F:
				FormJournalRequestForRepairAddEdit.NyyLIQ2iRC5aAJAivV5(this.KKYnt0822j, new Size(287, 21));
				num = 342;
				continue;
				IL_5FBF:
				this.kuRnYPi50V.TabIndex = 12;
				num = 317;
				continue;
				IL_603A:
				FormJournalRequestForRepairAddEdit.eEkiM2T8Lf8N3vSArv3(this.dSOeiWZtIs);
				this.BhgeS5qeIC.ResumeLayout(false);
				num = 192;
				if (FormJournalRequestForRepairAddEdit.KpAoBLX7vvWq9JtAsis())
				{
					continue;
				}
				IL_6061:
				FormJournalRequestForRepairAddEdit.fltXeY2DcaHrEKvDYFT(this.YoIns0P0S0, 21);
				num = 152;
				continue;
				IL_66FF:
				this.lfWeHeTrZJ.TabIndex = 12;
				this.DB7eF6ajiX.AutoSize = true;
				FormJournalRequestForRepairAddEdit.KyAccT2hoieOHF5MPn2(this.DB7eF6ajiX, new Point(302, 8));
				this.DB7eF6ajiX.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31936);
				this.DB7eF6ajiX.Size = new Size(41, 13);
				this.DB7eF6ajiX.TabIndex = 13;
				this.DB7eF6ajiX.Text = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(31954);
				num = 390;
				continue;
				IL_6917:
				FormJournalRequestForRepairAddEdit.XUwkLwTGtQmKAK0RNQ3(this.wULnq8UnPx, DataGridViewAutoSizeRowsMode.AllCells);
				this.wULnq8UnPx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				FormJournalRequestForRepairAddEdit.uDjqomT4VAhkAee80Tl(this.wULnq8UnPx.Columns, new DataGridViewColumn[]
				{
					this.fYgJOAXHZU,
					this.qg8JLSAKNQ,
					this.yAXJvrM2tq,
					this.fRlJ4vE12X,
					this.AZMJB5EVm8,
					this.RI9Jlhlmpg
				});
				num = 107;
				continue;
				IL_69AA:
				this.K6VJ9XsaK9.Sort = FormJournalRequestForRepairAddEdit.VwY9WJXw1IdUkvaORmQ(36286);
				this.ROTnK6JpmV.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
				num = 350;
				if (!false)
				{
					continue;
				}
				IL_69D7:
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.boNeyT9U7u), this.dSOeiWZtIs);
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.boNeyT9U7u).Add(this.vBCeYf5BJy);
				FormJournalRequestForRepairAddEdit.sBSwhy2xtwuD9mY6Uhc(this.boNeyT9U7u.Controls, this.hKaeG4RCUy);
				FormJournalRequestForRepairAddEdit.Agpa8KrkZ2rjul5BIHG(this.boNeyT9U7u).Add(this.EMnejl09uS);
				this.boNeyT9U7u.Controls.Add(this.OgTeQRItvM);
				num = 396;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000211A8 File Offset: 0x0001F5A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FormJournalRequestForRepairAddEdit()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000211C0 File Offset: 0x0001F5C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KpAoBLX7vvWq9JtAsis()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000211D4 File Offset: 0x0001F5D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AuhgiaXQH2hbQAAkBWW()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000211E8 File Offset: 0x0001F5E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gPULnAX1hHRaHBqMgff()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00021200 File Offset: 0x0001F600
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Yoo5LhXGr1xgGjP84Qm(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0002121C File Offset: 0x0001F61C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hWudIpX4UUXqgaMjHED(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.DataBindings;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00021238 File Offset: 0x0001F638
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oMrpG2Xt7vv7bhXXG9H(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Clear();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00021254 File Offset: 0x0001F654
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VwY9WJXw1IdUkvaORmQ(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00021270 File Offset: 0x0001F670
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eNVU9sXVTPdgEbxSF8w(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Add(A_1);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00021290 File Offset: 0x0001F690
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MYEP83XkI141am7o5YR(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SqlSettings;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000212AC File Offset: 0x0001F6AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int wKeE0MXd0NuogaNjchC(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Fill(A_1);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000212CC File Offset: 0x0001F6CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ndhbvCXby6djkL1sHSq(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Rows;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000212E8 File Offset: 0x0001F6E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int kFpJp7XFIVNwwPqqXM4(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00021304 File Offset: 0x0001F704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object K6NfaiXP1t10bpkhPO6(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00021324 File Offset: 0x0001F724
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object k70b6oXmxghxt8PBXca(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SelectSingleNode(A_1);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00021344 File Offset: 0x0001F744
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M8yZkGXg0SRP5V3JtC2(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Attributes;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00021360 File Offset: 0x0001F760
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VIhy5SXRaCAk0LBkYLo(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Message;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0002137C File Offset: 0x0001F77C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CVOrcKXEZriCybjLgUW(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.InnerException;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00021398 File Offset: 0x0001F798
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F0oo1wXKhsvFKTAWurU(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Columns;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000213B4 File Offset: 0x0001F7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type fubmvOX9d6a46jiTIfX(RuntimeTypeHandle A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000213D0 File Offset: 0x0001F7D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uOQuZmXi3rjBekKWKMt(object A_0, object A_1, Type A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Add(A_1, A_2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000213F4 File Offset: 0x0001F7F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Y2r8rOXeGu55hpFhlAx(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			ServicePointManager.CertificatePolicy = A_0;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00021410 File Offset: 0x0001F810
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tBoid2XMnEchHrkhsFA(object A_0, TimeSpan A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			((IContextChannel)A_0).OperationTimeout = A_1;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00021430 File Offset: 0x0001F830
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long pbCtu7X5XYGqJDU32VU(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0002144C File Offset: 0x0001F84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dUcAiAXvZn2liatlk4a(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Add(A_1);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0002146C File Offset: 0x0001F86C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color Bmkc9fXCvfteQfwx2Qe()
		{
			while (false)
			{
				object obj = null[0];
			}
			return Color.Red;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00021484 File Offset: 0x0001F884
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NLHZ9pX09y9dLHK3wDu(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.GetEnumerator();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000214A0 File Offset: 0x0001F8A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lVaHCGXx2JoJdsg5mVW(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((IEnumerator)A_0).MoveNext();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000214BC File Offset: 0x0001F8BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DbPnp0XhIcN9JOvTklQ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((IEnumerator)A_0).Current;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000214D8 File Offset: 0x0001F8D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JFfwufXokr9neQvFwiO(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000214F8 File Offset: 0x0001F8F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FaYqW9XYC3KiLuJ88GO(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SelectedValue;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00021514 File Offset: 0x0001F914
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iJvHw6XundyImMbTt9G(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SelectedValue = A_1;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00021534 File Offset: 0x0001F934
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DsontcXauIkkEcpw5iv(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SelectedIndex = A_1;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00021554 File Offset: 0x0001F954
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RuntimeTypeHandle LwAUTbXqEZ1mfdmc55N(int token)
		{
			while (false)
			{
				object obj = null[0];
			}
			return nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(token);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00021570 File Offset: 0x0001F970
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TxMbiyX8UhL1cbJeFy2(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DataSource = A_1;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00021590 File Offset: 0x0001F990
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rwsQ8xXBQucaCjDK5eU(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.InnerChannel;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000215AC File Offset: 0x0001F9AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M9siZvXyHLPwpHRUeFw(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.GetDictTypeDisable();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000215C8 File Offset: 0x0001F9C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lJKyxTX6D01Esx5hRES(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Name;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000215E4 File Offset: 0x0001F9E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cFo5QHXN0g6HniFoC2c(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00021600 File Offset: 0x0001FA00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void m7yrknXSnVbhabeAIHm(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DisplayMember = A_1;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00021620 File Offset: 0x0001FA20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DM0SefXAU37XccbaJW5(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ValueMember = A_1;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00021640 File Offset: 0x0001FA40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uVukwJXsHXCQDVe479C(object A_0, Color A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ForeColor = A_1;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00021660 File Offset: 0x0001FA60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Y8vEYrXf0smIDkrrE7N(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.GetDictStatus();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0002167C File Offset: 0x0001FA7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uhQcjkXpNb6vKcfplhI(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ReadOnly = A_1;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0002169C File Offset: 0x0001FA9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime fpu0vrXOM4IyU9rHHoe()
		{
			while (false)
			{
				object obj = null[0];
			}
			return DateTime.Now;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000216B4 File Offset: 0x0001FAB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K6cy3wXDMAngTN7rkUp(object A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Value = A_1;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000216D4 File Offset: 0x0001FAD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WcgoprXUpy5heHmwvrn(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.LoadFormConfig(A_1);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000216F4 File Offset: 0x0001FAF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IYu1wAXJcSSaZmFv72P(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.NewRow();
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00021710 File Offset: 0x0001FB10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void s6wSdMXIUq1n1s2ismF(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0[A_1] = A_2;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00021734 File Offset: 0x0001FB34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VDHQJKXZkBxwfWwMFkj(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 + A_1;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00021754 File Offset: 0x0001FB54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HG3HIPXcjjiC4r4nkb0(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Select(A_1);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00021774 File Offset: 0x0001FB74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Th6DxQXzbtWFQauQXvK(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.tJ_RequestForRepair;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00021790 File Offset: 0x0001FB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HwGAmXr3WG5y8RIbsRA(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Add(A_1);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000217B0 File Offset: 0x0001FBB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IbnHWbrWWsUIXRa2EJl(object A_0, object A_1, object A_2, bool A_3, object A_4)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SelectSqlData(A_1, A_2, A_3, A_4);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000217DC File Offset: 0x0001FBDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jVd3R4rLSNpv4WDN18y(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.tJ_RequestForRepairAddress;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000217F8 File Offset: 0x0001FBF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DGOln0rjCJfnHFr9OaL(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToBoolean(A_0);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00021814 File Offset: 0x0001FC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UWqpjArXYKvNq5q0LAa(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Enabled = A_1;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00021834 File Offset: 0x0001FC34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zU9NPxrr63qbUZdCnml(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Visible = A_1;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00021854 File Offset: 0x0001FC54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DialogResult DuDeHnrnW54ebHkIHYP(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.DialogResult;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00021870 File Offset: 0x0001FC70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DialogResult STnyjir2yIXpJ4vPTHx(object A_0, object A_1, MessageBoxButtons A_2, MessageBoxIcon A_3)
		{
			while (false)
			{
				object obj = null[0];
			}
			return MessageBox.Show(A_0, A_1, A_2, A_3);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00021898 File Offset: 0x0001FC98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YBxsONrTuyEDg9Cw8CA(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.EndEdit();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000218B4 File Offset: 0x0001FCB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SfApCFrHib1HYUDsmDO(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.tJ_RequestForRepairDaily;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000218D0 File Offset: 0x0001FCD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rtKkoCrl70VwRDQSvNT(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.InsertSqlData(A_1, A_2);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000218F4 File Offset: 0x0001FCF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RcZTRir7akLPgPuD9hT(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.UpdateSqlData(A_1, A_2);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00021918 File Offset: 0x0001FD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void U67NVRrQwg4Va6cZoSs(object A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.MinDate = A_1;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00021938 File Offset: 0x0001FD38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TPyCQyr1rSoVdPc1BNC(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Text = A_1;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00021958 File Offset: 0x0001FD58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RRROGCrGOZ0IQ9RYp5C(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.PrimaryKey = A_1;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00021978 File Offset: 0x0001FD78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KatxDcr49et30cDMVlE(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.Format(A_0, A_1, A_2);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0002199C File Offset: 0x0001FD9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MppBsmrtGcT0TclkiX2(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Text;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000219B8 File Offset: 0x0001FDB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int C28iarrwX4jJba1k5If(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SelectedIndex;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000219D4 File Offset: 0x0001FDD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool frGxQ1rVyhal7bXRk7u(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.IsNullOrEmpty(A_0);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000219F0 File Offset: 0x0001FDF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Agpa8KrkZ2rjul5BIHG(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Controls;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00021A0C File Offset: 0x0001FE0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color hsSivLrdZGHr9HkqyLW(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.ForeColor;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00021A28 File Offset: 0x0001FE28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Slq1V5rbU4kx6lNu6SI(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.GetEnumerator();
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00021A44 File Offset: 0x0001FE44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mekat0rFbrDhOBwKbxe(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Checked;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00021A60 File Offset: 0x0001FE60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object w6QKF6rP8NjGgwv8fGy(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.AddressHousesDidable;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00021A7C File Offset: 0x0001FE7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ibvtMprmsn7Do8a6Sij(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.StreetType = A_1;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00021A9C File Offset: 0x0001FE9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aDlgBTrg74utY4yLvSb(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DateBeginEnd = A_1;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00021ABC File Offset: 0x0001FEBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zmwy51rRfAHZYgIlosu(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.DateBeginEnd;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00021AD8 File Offset: 0x0001FED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime UZ0amerEqKv6whRWf4X(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToDateTime(A_0);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00021AF4 File Offset: 0x0001FEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int guwjn3rKRtla0nsHj1R(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToInt32(A_0);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00021B10 File Offset: 0x0001FF10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HMimyDr9B8qsAAwciGZ(object A_0, long value)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.RefTypeDisable = value;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00021B30 File Offset: 0x0001FF30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void B0gc11rix2s4VIQVDyg(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Cause = A_1;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00021B50 File Offset: 0x0001FF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rQ4EysreqtKTj8OgCGA(object A_0, int value)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ToOrganizationId = value;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00021B70 File Offset: 0x0001FF70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long qed3nBrMGvgZN0lq8CA(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.RequestId;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00021B8C File Offset: 0x0001FF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LpVk5Fr5dNoJnTPYPMU(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Message;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00021BA8 File Offset: 0x0001FFA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int FawFPdrvw3qGMyilf6m(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Length;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00021BC4 File Offset: 0x0001FFC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QoLjesrCq8tiv4ddkXe(object A_0, long RequestId, DateTime DateEnd)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Succsess(RequestId, DateEnd);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00021BE8 File Offset: 0x0001FFE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int BNuvvor0isMcH63sRIF(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Code;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00021C04 File Offset: 0x00020004
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uvR5uRrxXOx7fWxYma8(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Source;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00021C20 File Offset: 0x00020020
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WcSC45rhJMaXgDJy79s(object A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.MaxDate = A_1;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00021C40 File Offset: 0x00020040
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IgbWXAroXagPOKDlV88(DateTime A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 < A_1;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00021C60 File Offset: 0x00020060
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime ScT6TvrYLKmUQi3bFvv(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.MaxDate;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00021C7C File Offset: 0x0002007C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CQSShrruhUd2qgtSQFw(DateTime A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 > A_1;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00021C9C File Offset: 0x0002009C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime becu7jraaDLMZ6fOT8i()
		{
			while (false)
			{
				object obj = null[0];
			}
			return DateTimePicker.MaximumDateTime;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00021CB4 File Offset: 0x000200B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qPZSylrqd5J6dH9pUiM(object A_0, DataRowVersion A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.HasVersion(A_1);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00021CD4 File Offset: 0x000200D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ttGPFkr8vhdSJ4UrlOh(object A_0, object A_1, DataRowVersion A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1, A_2];
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00021CF8 File Offset: 0x000200F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Age8e7rBwnUnrkBdeKK(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Value = A_1;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00021D18 File Offset: 0x00020118
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int QlT8uKrymoMveu6rFJm(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00021D34 File Offset: 0x00020134
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jMnvLQr6txx4yanbSIv(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Name;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00021D50 File Offset: 0x00020150
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uFuPAKrNaMfUKtFPrYn(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Control;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00021D6C File Offset: 0x0002016C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool swDRINrScYotCiT6g64(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 == A_1;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00021D8C File Offset: 0x0002018C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q1PIoVrArSunLIIFWj5(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00021DA8 File Offset: 0x000201A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int dTHbEFrsbdIkhABdnJl(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.RowIndex;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00021DC4 File Offset: 0x000201C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gRV8qvrfUn5Oso6JqbJ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.CurrentCell;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00021DE0 File Offset: 0x000201E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LPqkmJrpJ50YZWs9xTD(object A_0, object A_1, int A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1, A_2];
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00021E04 File Offset: 0x00020204
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JX3SuJrOcPWWARk8t3H(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Rows;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00021E20 File Offset: 0x00020220
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int vbGaKGrDmvoAZn682Tj(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.RowIndex;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00021E3C File Offset: 0x0002023C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int tA5vpRrUnjN7FsTjiP2(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.ColumnIndex;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00021E58 File Offset: 0x00020258
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UpLWb8rJ9vt2W5ln9p4(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00021E78 File Offset: 0x00020278
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mt1XnRrIfyoSxoHvvpL(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.CellStyle;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00021E94 File Offset: 0x00020294
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qWWP2arZ7RpmanieB4V(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Columns;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00021EB0 File Offset: 0x000202B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OJ3elcrc91u1XlplrZW(object A_0, Color A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ForeColor = A_1;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00021ED0 File Offset: 0x000202D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yuJjNUrz5Yko5YH2CyJ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.RowsAdded -= A_1;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00021EF0 File Offset: 0x000202F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime qKAZiEn308C8j8yXGj4(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00021F0C File Offset: 0x0002030C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color boZdSGnWwbPWvD83nRP()
		{
			while (false)
			{
				object obj = null[0];
			}
			return SystemColors.ControlText;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00021F24 File Offset: 0x00020324
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SNXSXHnLFBNLXi86TqJ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.RowsAdded += A_1;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00021F44 File Offset: 0x00020344
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PkFuMSnjRjtVa9aAl9k(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.tL_RequestForRepairSchmObjList;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00021F60 File Offset: 0x00020360
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ojdQAfnXSpDIFp1jkHp(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.DefaultView;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00021F7C File Offset: 0x0002037C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KPmG77nrGceFmmMq9q9(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Sort = A_1;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00021F9C File Offset: 0x0002039C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object i1BQeknnCSfnbHIQ7fu(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.ToTable();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00021FB8 File Offset: 0x000203B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int e2c0xGn2iL2MpARwXSw(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00021FD4 File Offset: 0x000203D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yLwbP7nT4VLikYhA6hP(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Sort();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00021FF0 File Offset: 0x000203F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object h9W8PinHl7Lh7uAWB7R(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00022010 File Offset: 0x00020410
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CEpLXMnl8CcEQkaX6OP(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Tables;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0002202C File Offset: 0x0002042C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HPgiG2n7nvyb1VVU8Jg(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.TableName;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00022048 File Offset: 0x00020448
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime BGXVhAnQkFR66jT7qAm(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.DateBeg;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00022064 File Offset: 0x00020464
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime tPABLUn1S1I1QyVuwl4(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.DateEnd;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00022080 File Offset: 0x00020480
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color kGCZLVnGeYAIqMbXFV8()
		{
			while (false)
			{
				object obj = null[0];
			}
			return Color.LightGray;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00022098 File Offset: 0x00020498
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BiXsaQn4QrlU4LVgK7l(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.CurrentRow;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000220B4 File Offset: 0x000204B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fjV8kyntjFErdR0ewD6(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Cells;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000220D0 File Offset: 0x000204D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object W3LhBRnwjswHXoE8JHc(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000220F0 File Offset: 0x000204F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void B4Zqe3nVViaEmXvpKjQ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Clear();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0002210C File Offset: 0x0002050C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LjO8B0nkakRL0v2n3BT(object A_0, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DateBeg = \u0020;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0002212C File Offset: 0x0002052C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oAEbP4ndNPS73yslGdn(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Duration = A_1;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0002214C File Offset: 0x0002054C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zMJPD0nbqJRijccwvUK(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.CallSQLScalarFunction(A_1, A_2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00022170 File Offset: 0x00020570
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DialogResult hkRoPYnF94y2ZY0Pt9b(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.ShowDialog();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0002218C File Offset: 0x0002058C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IsiVX1nP6DZEEJXrLIQ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Duration;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000221A8 File Offset: 0x000205A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d9SmGbnmuFCITITtr2r(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.GetEnumerator();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000221C4 File Offset: 0x000205C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fUtXv9ngv8vOxERS16l(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.OnGoToSchema(A_1);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000221E4 File Offset: 0x000205E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DataRowState jSgH4onRAFMXGvcH2Fh(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.RowState;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00022200 File Offset: 0x00020600
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F4iPw1nEZ3UnELVUTZC(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.DeleteSqlData(A_1, A_2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00022224 File Offset: 0x00020624
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Gj6bAHnKgggiih0uhds(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AcceptChanges();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00022240 File Offset: 0x00020640
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OKhApfn9l3GRy8aXNok(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Multiselect = A_1;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00022260 File Offset: 0x00020660
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VZPVrYniBwoOQvPYfkJ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.tJ_RequestForRepairDoc;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0002227C File Offset: 0x0002067C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Hkwnqrne2tgfS8xxPQQ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.FileNames;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00022298 File Offset: 0x00020698
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ppyhq7nMF5jF1YAq621(object A_0, int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.U927aijt9q(\u0020);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000222B8 File Offset: 0x000206B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ewrSO0n5DdAvWAZH4u3()
		{
			while (false)
			{
				object obj = null[0];
			}
			return Path.GetTempFileName();
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000222D0 File Offset: 0x000206D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hAk1x6nv3loCOavAEPa(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Close();
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000222EC File Offset: 0x000206EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nM0tcsnCDhglDbGQ7ln(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.StartInfo;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00022308 File Offset: 0x00020708
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tscs7Kn0QqX6o4qEykD(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.FileName = A_1;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00022328 File Offset: 0x00020728
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zF26DUnxUAWLjRIurm5(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Path.GetExtension(A_0);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00022344 File Offset: 0x00020744
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void A4i0yMnhcyZcd9PrV2U(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Filter = A_1;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00022364 File Offset: 0x00020764
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int I2fKyQno59of0eQfLs1(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.RowCount;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00022380 File Offset: 0x00020780
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ObieC2nYpJncVEtsUEJ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return dVnYRTNDfVctthapT5.Qnd8AC1nIr(A_0);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0002239C File Offset: 0x0002079C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oTNWCfnuEMle3wDN9c3(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.ToBitmap();
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000223B8 File Offset: 0x000207B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int DBZuSXna80ifLSLsfK5(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.ColumnIndex;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000223D4 File Offset: 0x000207D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L20t1knqG7EfLAx201D(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000223F4 File Offset: 0x000207F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kDHMMVn8j1QtBM04oNs(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return File.Create(A_0);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00022410 File Offset: 0x00020810
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GgZqAPnBFW9doX5m3Vj(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Copy();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0002242C File Offset: 0x0002082C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UbYfjTnygT2vE91V4km(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ItemArray = A_1;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0002244C File Offset: 0x0002084C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gsycSvn6fondoMwg6DF(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Clear();
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00022468 File Offset: 0x00020868
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vUJud3nN7tCtRRxujuS(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.AppendChild(A_1);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00022488 File Offset: 0x00020888
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object opqSIZnSmoxgdcgvmDc(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Name;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000224A4 File Offset: 0x000208A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GOiUNunAGM5qwo1BZeU(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.CreateElement(A_1);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000224C4 File Offset: 0x000208C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GptWRVnsvn4UAC7Y2iu(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Value = A_1;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000224E4 File Offset: 0x000208E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wNsWuanfhV2yohEhOTM(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00022500 File Offset: 0x00020900
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F7AksDnptBsp1PbhVpB(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00022520 File Offset: 0x00020920
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void grwcVbnOIfUeh3J9P3l(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.LoadSchema(A_1);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00022540 File Offset: 0x00020940
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int CbJpmqnDB1qgAwnievG(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Id;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0002255C File Offset: 0x0002095C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qK3BLfnU0lFVrvHNSux(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 + A_1 + A_2;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00022580 File Offset: 0x00020980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void S0wjd7nJagL7msrmBl5(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Open();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0002259C File Offset: 0x0002099C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BsPQbenIlb1Voik0cQF(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CommandTimeout = A_1;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000225BC File Offset: 0x000209BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DialogResult PtHR4ynZGJNLVafgh3Q(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return MessageBox.Show(A_0, A_1);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000225DC File Offset: 0x000209DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fppspwncISFr9gOZxkb(object A_0, object A_1, object A_2, object A_3)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 + A_1 + A_2 + A_3;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00022604 File Offset: 0x00020A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UKEtXKnz5XBfvLh8i0E(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Remove(A_1);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00022624 File Offset: 0x00020A24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void q0UdAL23wKqW9mhdvH8(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SqlSettings = A_1;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00022644 File Offset: 0x00020A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aawCN52W0XO1lRGptcJ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.Concat(A_0);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00022660 File Offset: 0x00020A60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ROHcEo2Ld6KZNtlweMd(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0002267C File Offset: 0x00020A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NjFnm12jOVHAk2usrXp(object A_0, object A_1, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			MdBMOhVqRSHesLq1WY.rFPMi4NUv0(A_0, A_1, \u0020);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000226A0 File Offset: 0x00020AA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YBYoGb2XXI1iU9OtJyi(object A_0, object A_1, DateTime \u0020, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			G868F8PfVDPhiDtMmF.vRO88iHNRg(A_0, A_1, \u0020, \u0020);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000226C8 File Offset: 0x00020AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object egqnDm2rPfAXSQxyGs6(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.tJ_Damage;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000226E4 File Offset: 0x00020AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void M3VJuC2n5EjFl9TrMYZ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SqlSettings = A_1;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00022704 File Offset: 0x00020B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Y8bVCg22NrhEi5n7PKy(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00022720 File Offset: 0x00020B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zgkGf12THQMbsJ9RJ5Z(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.tJ_DamageHV;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0002273C File Offset: 0x00020B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object H9Wlfo2HJYiFlwml8tU(object A_0, int A_1, bool A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.PoweringReportForDrawObject(A_1, A_2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00022760 File Offset: 0x00020B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gFMvyw2l22drhopM3rc(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Compute(A_1, A_2);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00022784 File Offset: 0x00020B84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q8DijC27W05IjUsgkxQ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.UpdateSqlDataOnlyChange(A_1);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000227A4 File Offset: 0x00020BA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ucU6aY2QZOtqi1bSqxl(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.RemoveAll();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000227C0 File Offset: 0x00020BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XmWgSb21ugWFxv80sow(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.CreateAttribute(A_1);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000227E0 File Offset: 0x00020BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zY2Bdm2G9raJiNM34Uj(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Append(A_1);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00022800 File Offset: 0x00020C00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fO3FWO24gDks9lnto3L(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.OwnerDocument;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0002281C File Offset: 0x00020C1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qTm4IU2txPICUJD8IZE(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.IsCell();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00022838 File Offset: 0x00020C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cfPsE62wkCRYpE7g8tG(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Parent;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00022854 File Offset: 0x00020C54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static eTypeShinaTool najy9B2VQ4Cy10WXr5I(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.TypeBus;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00022870 File Offset: 0x00020C70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TypeSwitch VaEpSV2k2QmpcZreSnv(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.TypeSwitch;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0002288C File Offset: 0x00020C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ommREf2d72gCuDqnCmm(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SelectSqlData(A_1);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000228AC File Offset: 0x00020CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ALVmre2bekQLM8N2p3g(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Select(A_1, A_2);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000228D0 File Offset: 0x00020CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P1SpEP2FMVrXNYPNknM(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.InsertSqlData(A_1);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000228F0 File Offset: 0x00020CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object P1Y3af2Pw6Y2VBhJDsy(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.GetConnectionString();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0002290C File Offset: 0x00020D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ghwdnQ2mwVRbtIkoEuR(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.tJ_RequestForRepairLog;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00022928 File Offset: 0x00020D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VvdBRw2giBS2EAg2RBa(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Dispose(A_1);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00022948 File Offset: 0x00020D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nKZUtq2RtiAyOjRL50i(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SuspendLayout();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00022964 File Offset: 0x00020D64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q8gQje2EAETN4EhsTag(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Panel1;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00022980 File Offset: 0x00020D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GsPYk92KHMxWWvtGUFy(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((ISupportInitialize)A_0).BeginInit();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0002299C File Offset: 0x00020D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void a4YtIK292EObyLVyjgd(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoSize = A_1;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000229BC File Offset: 0x00020DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NyyLIQ2iRC5aAJAivV5(object A_0, Size A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Size = A_1;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000229DC File Offset: 0x00020DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wxtbji2ewKZVOuHvHhg(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.FormattingEnabled = A_1;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000229FC File Offset: 0x00020DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AZwWOx2MtmsmkLVN5RH(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SelectedIndexChanged += A_1;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00022A1C File Offset: 0x00020E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eeOOKK259Tcfc6HfKLY(object A_0, AnchorStyles A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Anchor = A_1;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00022A3C File Offset: 0x00020E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EaXXbr2v6WwmZrntatT(object A_0, AutoCompleteMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoCompleteMode = A_1;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00022A5C File Offset: 0x00020E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Hd1A822C2AlsEijRlOS(object A_0, AutoCompleteSource A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoCompleteSource = A_1;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00022A7C File Offset: 0x00020E7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Togv3k20GW1VC1LEFj1(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00022A9C File Offset: 0x00020E9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sBSwhy2xtwuD9mY6Uhc(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Add(A_1);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00022ABC File Offset: 0x00020EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KyAccT2hoieOHF5MPn2(object A_0, Point A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Location = A_1;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00022ADC File Offset: 0x00020EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DBajFH2ovCKgO9W7RWG(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TabIndex = A_1;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00022AFC File Offset: 0x00020EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void B37PwE2YaPOSP5ncHRX(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SelectedValueChanged += A_1;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00022B1C File Offset: 0x00020F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QqJNhj2u5mpiu0ceV1M(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AddRange(A_1);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00022B3C File Offset: 0x00020F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DDgc4F2aoeE5nTFb38n(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Image = A_1;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00022B5C File Offset: 0x00020F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void R7bt8M2qDmlNM1NviRp(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Click += A_1;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00022B7C File Offset: 0x00020F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rW6UvV2840p2XvmlJel()
		{
			while (false)
			{
				object obj = null[0];
			}
			return Resources.pAc3ZrADSe();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00022B94 File Offset: 0x00020F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color YYuSHy2BDZsWES3vyki()
		{
			while (false)
			{
				object obj = null[0];
			}
			return Color.Magenta;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00022BAC File Offset: 0x00020FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vrOmF42y0j24pWR79Pa(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00022BCC File Offset: 0x00020FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tIsTlG26Cq5KEttq2XA(object A_0, ToolStripItemDisplayStyle A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DisplayStyle = A_1;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00022BEC File Offset: 0x00020FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object W2dvau2N7aEQ0eJ4teO()
		{
			while (false)
			{
				object obj = null[0];
			}
			return Resources.UAd3JmH29l();
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00022C04 File Offset: 0x00021004
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void peZQcN2SXyR7yhlpaw9(object A_0, Color A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ImageTransparentColor = A_1;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00022C24 File Offset: 0x00021024
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Icf5QS2AKHMJsXhtLct(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TabStop = A_1;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00022C44 File Offset: 0x00021044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uGJJSR2sXJhWqkoxdqY(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Click += A_1;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00022C64 File Offset: 0x00021064
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CKPvld2fgZP4OkSoiF6(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AllowUserToResizeColumns = A_1;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00022C84 File Offset: 0x00021084
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Fx8k7r2prIDmYHfnReb(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoGenerateColumns = A_1;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00022CA4 File Offset: 0x000210A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EsS7gP2OdsEsTUqs4Je(object A_0, DataGridViewColumnHeadersHeightSizeMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ColumnHeadersHeightSizeMode = A_1;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00022CC4 File Offset: 0x000210C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fltXeY2DcaHrEKvDYFT(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.RowHeadersWidth = A_1;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00022CE4 File Offset: 0x000210E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void va1crk2U67t3cs4oSaW(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.VirtualMode = A_1;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00022D04 File Offset: 0x00021104
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void j4AVtB2JFCDgsI160K2(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.RowsRemoved += A_1;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00022D24 File Offset: 0x00021124
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ysX2WS2IlahWhI9WQTs(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.HeaderText = A_1;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00022D44 File Offset: 0x00021144
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void d2Qbgo2ZnOx7cFOtPJE(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DataPropertyName = A_1;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00022D64 File Offset: 0x00021164
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void q2q5Qe2cltAQLet3WP7(object A_0, DataGridViewAutoSizeColumnMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoSizeMode = A_1;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00022D84 File Offset: 0x00021184
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void J42syv2z21HnWe9MIjT(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Format = A_1;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00022DA4 File Offset: 0x000211A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DHOVkcT3ewJfO0U6hkl(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00022DC4 File Offset: 0x000211C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void axYLMTTWqs4m57ZAOBK(object A_0, DataGridViewTriState A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Resizable = A_1;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00022DE4 File Offset: 0x000211E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NBfopwTLpWlFe7WBkQd(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Checked = A_1;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00022E04 File Offset: 0x00021204
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pPJdjyTjs5t4OS57PsA(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.UseVisualStyleBackColor = A_1;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00022E24 File Offset: 0x00021224
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ctuXt5TXtQYgiPDn6u4(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CustomFormat = A_1;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00022E44 File Offset: 0x00021244
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Lj9OFDTrKfVOhUSVyud(object A_0, DateTimePickerFormat A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Format = A_1;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00022E64 File Offset: 0x00021264
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EQnYmDTnmSSjyd2iyQA(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CheckStateChanged += A_1;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00022E84 File Offset: 0x00021284
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iHghffT2rfT37fKkltO(object A_0, DateTimePickerFormat A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Format = A_1;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00022EA4 File Offset: 0x000212A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xwvFLpTTLNMolTdyBMw(object A_0, Point A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Location = A_1;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00022EC4 File Offset: 0x000212C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RXonZ3THXGAIAr5WV2b(object A_0, Padding A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Padding = A_1;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00022EE4 File Offset: 0x000212E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JAMxwvTlJu9faiBC9Og(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Items;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00022F00 File Offset: 0x00021300
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XY0CuxT7mI6uVGjgT6w(object A_0, DockStyle A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Dock = A_1;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00022F20 File Offset: 0x00021320
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IQWytxTQobF0Th0Skm9(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Panel2;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00022F3C File Offset: 0x0002133C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DAm92fT1p83nmWbvYiI(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AllowUserToAddRows = A_1;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00022F5C File Offset: 0x0002135C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XUwkLwTGtQmKAK0RNQ3(object A_0, DataGridViewAutoSizeRowsMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoSizeRowsMode = A_1;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00022F7C File Offset: 0x0002137C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uDjqomT4VAhkAee80Tl(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AddRange(A_1);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00022F9C File Offset: 0x0002139C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BfgJ4aTtbNiKRWZOsR4(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ReadOnly = A_1;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00022FBC File Offset: 0x000213BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yKvphqTwo06vmGxD2pR(object A_0, DataGridViewRowHeadersWidthSizeMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.RowHeadersWidthSizeMode = A_1;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00022FDC File Offset: 0x000213DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YPbHXHTVShC5bELnj8Q(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CellDoubleClick += A_1;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00022FFC File Offset: 0x000213FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pxs1sMTk4iZXs71gVuX(object A_0, DataGridViewTriState A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.WrapMode = A_1;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0002301C File Offset: 0x0002141C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void U8Cdq9TdtJp0kv5yo0E(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DefaultCellStyle = A_1;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0002303C File Offset: 0x0002143C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pupHQgTbuY0rfWZ4swv(object A_0, DataGridViewColumnSortMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SortMode = A_1;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0002305C File Offset: 0x0002145C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void deukkRTF7Rt0wvQiN3n(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Width = A_1;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0002307C File Offset: 0x0002147C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pa0crMTPLKMLtMQhd3u(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Visible = A_1;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0002309C File Offset: 0x0002149C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void N8r9VGTmf9yBDxGVNmZ(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ReadOnly = A_1;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000230BC File Offset: 0x000214BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jpYmLkTg8aDh8kR7C2k(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DataSource = A_1;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000230DC File Offset: 0x000214DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CKj7pcTRNsQjhYuaD0g(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Sort = A_1;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000230FC File Offset: 0x000214FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pxi9ZCTET6qbSTELNZj(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ColumnName = A_1;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0002311C File Offset: 0x0002151C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void W2SEiWTKdpTuj2VEhEk(object A_0, Type A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DataType = A_1;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0002313C File Offset: 0x0002153C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gc72w9T9ZMVf8Pgnppi(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TableName = A_1;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0002315C File Offset: 0x0002155C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WJu3eoTiPxwuCTHtt4L(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AllowDBNull = A_1;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0002317C File Offset: 0x0002157C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void p46eyWTeSoeADUWcLsi(object A_0, float A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.FillWeight = A_1;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0002319C File Offset: 0x0002159C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xIyWMkTMNwI84W4tus3(object A_0, Size A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Size = A_1;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000231BC File Offset: 0x000215BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void R3laZVT5Orn1G9YC2jl(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TabIndex = A_1;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000231DC File Offset: 0x000215DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void p741RDTvfgQtbkNKqYP(object A_0, DockStyle A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Dock = A_1;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000231FC File Offset: 0x000215FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VAHV5jTCAl8tdlgcgaE(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.NullValue = A_1;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0002321C File Offset: 0x0002161C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Wx6RPET0C0g2oPySNma()
		{
			while (false)
			{
				object obj = null[0];
			}
			return Resources.Im7NYV1iO();
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00023234 File Offset: 0x00021634
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PAyBQJTxeDbQR3vow1v(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Text = A_1;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00023254 File Offset: 0x00021654
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AlCGXWThF2KIxtOVOZZ(object A_0, AutoScaleMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoScaleMode = A_1;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00023274 File Offset: 0x00021674
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TsP0YuTobowBmPJks55(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Controls;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00023290 File Offset: 0x00021690
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pgDCkjTYLq7gr9xYoK9(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.FormClosing += A_1;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000232B0 File Offset: 0x000216B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nijWuSTuYfmanHIaNhP(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.FormClosed += A_1;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000232D0 File Offset: 0x000216D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TJ1s6MTauuEEvdTxbob(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.PerformLayout();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000232EC File Offset: 0x000216EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void d3FFb3Tq1GstUIps4VA(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0002330C File Offset: 0x0002170C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eEkiM2T8Lf8N3vSArv3(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((ISupportInitialize)A_0).EndInit();
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00023328 File Offset: 0x00021728
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fgx9qDTBjxJCM0JJ67r(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x04000092 RID: 146
		private int abEgNyD5Y6;

		// Token: 0x04000093 RID: 147
		private int RqkgE4wFvG;

		// Token: 0x04000094 RID: 148
		private eActionRequestRepair ffsghkQnr5;

		// Token: 0x04000095 RID: 149
		private DateTime vclgz3ljku;

		// Token: 0x04000096 RID: 150
		private DateTime DVHeZEqiiZ;

		// Token: 0x04000097 RID: 151
		private int Q9Se39NXKE;

		// Token: 0x04000098 RID: 152
		private bool cs3eIKVCEg;

		// Token: 0x04000099 RID: 153
		private bool Fvgeg8qmOA;

		// Token: 0x0400009A RID: 154
		private bool q5CeeA3ux5;

		// Token: 0x0400009B RID: 155
		private DataRow ixYenVOtfo;

		// Token: 0x0400009C RID: 156
		private DataTable yJieJApNRL;

		// Token: 0x0400009D RID: 157
		private DataTable eVoe0Lldbr;

		// Token: 0x0400009E RID: 158
		private DataTable qwCeo7kn8p;

		// Token: 0x0400009F RID: 159
		private DataTable FT8eucyj8s;

		// Token: 0x040000A0 RID: 160
		private DataTable vOReMBXseE;

		// Token: 0x040000A1 RID: 161
		private Dictionary<int, string> MXUe8Spw0O;

		// Token: 0x040000A2 RID: 162
		private int LEveRtAqeF;

		// Token: 0x040000A3 RID: 163
		private ElectricModel mkoeCi01If;

		// Token: 0x040000A4 RID: 164
		private DataTable KOseX49R7b;

		// Token: 0x040000A5 RID: 165
		private DataTable jpMeqgA5CG;

		// Token: 0x040000A6 RID: 166
		private DataTable dAvem92PLM;

		// Token: 0x040000A7 RID: 167
		private ElectricModel oE9eseB0lU;

		// Token: 0x040000A8 RID: 168
		private List<int> mAWe7Y0Jgh;

		// Token: 0x040000A9 RID: 169
		private Dictionary<int, string> tv9eamhOik;

		// Token: 0x040000AA RID: 170
		private IContainer fH1e1A9RNZ;

		// Token: 0x040000AB RID: 171
		private E1YGNRmqUpG01b1DWc y7feOpIJtI;

		// Token: 0x040000AC RID: 172
		private Label LageL0atao;

		// Token: 0x040000AD RID: 173
		private ComboBox aelevmJUSY;

		// Token: 0x040000AE RID: 174
		private Label KYLe4Tbd80;

		// Token: 0x040000AF RID: 175
		private Label N4DeBMM4KD;

		// Token: 0x040000B0 RID: 176
		private ComboBox C99elfqXty;

		// Token: 0x040000B1 RID: 177
		private GroupBox xO9ePrsLfp;

		// Token: 0x040000B2 RID: 178
		private Label uVoewE09vT;

		// Token: 0x040000B3 RID: 179
		private ComboBox oyre5Btub4;

		// Token: 0x040000B4 RID: 180
		private Label Hrwe9GBchc;

		// Token: 0x040000B5 RID: 181
		private Label PTle2wlpsd;

		// Token: 0x040000B6 RID: 182
		private TextBox Po7eAn9peo;

		// Token: 0x040000B7 RID: 183
		private TextBox hZGeVyEfRI;

		// Token: 0x040000B8 RID: 184
		private Label d6UeKsT72M;

		// Token: 0x040000B9 RID: 185
		private Label OgTeQRItvM;

		// Token: 0x040000BA RID: 186
		private GroupBox BhgeS5qeIC;

		// Token: 0x040000BB RID: 187
		private TextBox G5GekMlON7;

		// Token: 0x040000BC RID: 188
		private TextBox HsZefiTdR1;

		// Token: 0x040000BD RID: 189
		private Button Dv1e6CuU3C;

		// Token: 0x040000BE RID: 190
		private ComboBox BAKeTHcuNQ;

		// Token: 0x040000BF RID: 191
		private Label reaed0XCF6;

		// Token: 0x040000C0 RID: 192
		private Label HhaeUjB5lH;

		// Token: 0x040000C1 RID: 193
		private NullableDateTimePicker I4xetUTq0V;

		// Token: 0x040000C2 RID: 194
		private CheckBox rWoeDxUpjP;

		// Token: 0x040000C3 RID: 195
		private Label psNecTr5ut;

		// Token: 0x040000C4 RID: 196
		private Label Dxiepm5uG7;

		// Token: 0x040000C5 RID: 197
		private Label JqYeWe6KbD;

		// Token: 0x040000C6 RID: 198
		private ComboBox lfWeHeTrZJ;

		// Token: 0x040000C7 RID: 199
		private Label DB7eF6ajiX;

		// Token: 0x040000C8 RID: 200
		private TextBox mqUexv2WmH;

		// Token: 0x040000C9 RID: 201
		private GroupBox boNeyT9U7u;

		// Token: 0x040000CA RID: 202
		private Button VkYerU8Qhx;

		// Token: 0x040000CB RID: 203
		private DataGridView dSOeiWZtIs;

		// Token: 0x040000CC RID: 204
		private CheckBox vBCeYf5BJy;

		// Token: 0x040000CD RID: 205
		private CheckBox hKaeG4RCUy;

		// Token: 0x040000CE RID: 206
		private DateTimePicker EMnejl09uS;

		// Token: 0x040000CF RID: 207
		private DateTimePicker hZDebgcu57;

		// Token: 0x040000D0 RID: 208
		private Label hnQeNIZkPu;

		// Token: 0x040000D1 RID: 209
		private Label gAXeEWFGWu;

		// Token: 0x040000D2 RID: 210
		private NullableDateTimePicker MdGehXdP89;

		// Token: 0x040000D3 RID: 211
		private ToolStrip jNxezOc8K1;

		// Token: 0x040000D4 RID: 212
		private ToolStripButton AF3nZ6Ps4Z;

		// Token: 0x040000D5 RID: 213
		private ToolStripButton bq8n3A7OBi;

		// Token: 0x040000D6 RID: 214
		private ToolStripButton CeanIEi3ht;

		// Token: 0x040000D7 RID: 215
		private TabControl HgVngSxHtS;

		// Token: 0x040000D8 RID: 216
		private TabPage EhhneeGlqI;

		// Token: 0x040000D9 RID: 217
		private TabPage DCenneEYOy;

		// Token: 0x040000DA RID: 218
		private TabPage Ms1nJWxRcR;

		// Token: 0x040000DB RID: 219
		private DataSet k16n0HORUW;

		// Token: 0x040000DC RID: 220
		private DataTable Glkno10FRw;

		// Token: 0x040000DD RID: 221
		private DataColumn IebnutXeZ9;

		// Token: 0x040000DE RID: 222
		private DataColumn kcpnME1c9M;

		// Token: 0x040000DF RID: 223
		private DataColumn er6n8CvbjI;

		// Token: 0x040000E0 RID: 224
		private DataColumn zJ3nR52you;

		// Token: 0x040000E1 RID: 225
		private DataColumn Ui6nCLYZvx;

		// Token: 0x040000E2 RID: 226
		private ToolStripButton tdnnXm7uXt;

		// Token: 0x040000E3 RID: 227
		private DataGridViewExcelFilter wULnq8UnPx;

		// Token: 0x040000E4 RID: 228
		private BindingSource K4tnmquBOV;

		// Token: 0x040000E5 RID: 229
		private DataGridViewExcelFilter YoIns0P0S0;

		// Token: 0x040000E6 RID: 230
		private BindingSource wtWn793arh;

		// Token: 0x040000E7 RID: 231
		private ToolStrip Doxna8ogZQ;

		// Token: 0x040000E8 RID: 232
		private ToolStripButton ox7n1cu9hA;

		// Token: 0x040000E9 RID: 233
		private DataTable gYanOthiX8;

		// Token: 0x040000EA RID: 234
		private DataColumn s7onLWJGpX;

		// Token: 0x040000EB RID: 235
		private DataColumn ngrnvWyUkq;

		// Token: 0x040000EC RID: 236
		private DataColumn R13n4s4744;

		// Token: 0x040000ED RID: 237
		private DataColumn q1fnB5EbgT;

		// Token: 0x040000EE RID: 238
		private ToolStripButton f2QnlcdpJi;

		// Token: 0x040000EF RID: 239
		private ToolStripButton hVxnPQA72W;

		// Token: 0x040000F0 RID: 240
		private ToolStripButton XrFnwd9INg;

		// Token: 0x040000F1 RID: 241
		private DataGridViewTextBoxColumn mXdn547ZHM;

		// Token: 0x040000F2 RID: 242
		private DataGridViewImageColumnNotNull QrTn9EhhGj;

		// Token: 0x040000F3 RID: 243
		private DataGridViewTextBoxColumn VWNn2NL2TS;

		// Token: 0x040000F4 RID: 244
		private DataGridViewLinkColumn lahnAiuE7f;

		// Token: 0x040000F5 RID: 245
		private DataGridViewTextBoxColumn dmcnVE0S5N;

		// Token: 0x040000F6 RID: 246
		private Button ROTnK6JpmV;

		// Token: 0x040000F7 RID: 247
		private ToolStrip i1pnQHQ2r8;

		// Token: 0x040000F8 RID: 248
		private ToolStripButton z5knSIxS7w;

		// Token: 0x040000F9 RID: 249
		private DataGridViewTextBoxColumn LMVnkuunsG;

		// Token: 0x040000FA RID: 250
		private DataGridViewTextBoxColumn nIBnfX16SG;

		// Token: 0x040000FB RID: 251
		private DataGridViewFilterDateTimePickerColumn hLln6SFMH0;

		// Token: 0x040000FC RID: 252
		private DataGridViewFilterDateTimePickerColumn akXnTaWPea;

		// Token: 0x040000FD RID: 253
		private TextBox jbcndg5xWg;

		// Token: 0x040000FE RID: 254
		private ComboBox FZInULtqG4;

		// Token: 0x040000FF RID: 255
		private ComboBox KKYnt0822j;

		// Token: 0x04000100 RID: 256
		private ComboBox TKdnD2UOSQ;

		// Token: 0x04000101 RID: 257
		private Label BVUnc3Sli2;

		// Token: 0x04000102 RID: 258
		private ComboBox d7YnphvtQ1;

		// Token: 0x04000103 RID: 259
		private Label nv7nWxKZai;

		// Token: 0x04000104 RID: 260
		private ComboBox EQknHC0OS1;

		// Token: 0x04000105 RID: 261
		private Label xL1nFot21u;

		// Token: 0x04000106 RID: 262
		private ComboBox H8tnxYcybE;

		// Token: 0x04000107 RID: 263
		private Label b2vnyhrNSS;

		// Token: 0x04000108 RID: 264
		private BindingSource cElnrI7wvf;

		// Token: 0x04000109 RID: 265
		private ComboBox kl0niMXXMI;

		// Token: 0x0400010A RID: 266
		private Label kuRnYPi50V;

		// Token: 0x0400010B RID: 267
		private SplitContainer GRHnGkvVC9;

		// Token: 0x0400010C RID: 268
		private DataTable bgxnjGgfZD;

		// Token: 0x0400010D RID: 269
		private DataColumn omYnbcn0Lm;

		// Token: 0x0400010E RID: 270
		private DataColumn o6pnNeOUiG;

		// Token: 0x0400010F RID: 271
		private DataColumn VaDnENYonh;

		// Token: 0x04000110 RID: 272
		private DataColumn TBmnhB8Zuh;

		// Token: 0x04000111 RID: 273
		private DataColumn qhonzR0VkG;

		// Token: 0x04000112 RID: 274
		private DataColumn DbGJZUDbOV;

		// Token: 0x04000113 RID: 275
		private DataColumn jRsJ3Qrnk2;

		// Token: 0x04000114 RID: 276
		private DataColumn HdAJI8Jumk;

		// Token: 0x04000115 RID: 277
		private DataGridViewExcelFilter btQJgjaEtV;

		// Token: 0x04000116 RID: 278
		private BindingSource VkBJe6Xc7o;

		// Token: 0x04000117 RID: 279
		private ToolStrip g1HJnTrcyE;

		// Token: 0x04000118 RID: 280
		private ToolStripButton qUpJJfJyqr;

		// Token: 0x04000119 RID: 281
		private ToolStripButton fNkJ0o0Atj;

		// Token: 0x0400011A RID: 282
		private BackgroundWorker WYcJoUVlbK;

		// Token: 0x0400011B RID: 283
		private DataGridViewTextBoxColumn YxQJup5LHg;

		// Token: 0x0400011C RID: 284
		private DataGridViewTextBoxColumn LAVJMoZ4gI;

		// Token: 0x0400011D RID: 285
		private DataGridViewTextBoxColumn VUlJ82xfLS;

		// Token: 0x0400011E RID: 286
		private DataGridViewTextBoxColumn X68JReQKph;

		// Token: 0x0400011F RID: 287
		private DataGridViewTextBoxColumn LEsJCvsFlo;

		// Token: 0x04000120 RID: 288
		private DataGridViewTextBoxColumn pp6JXxCiZA;

		// Token: 0x04000121 RID: 289
		private DataGridViewTextBoxColumn AmJJqbhcGW;

		// Token: 0x04000122 RID: 290
		private DataGridViewTextBoxColumn FH5JmNqvLS;

		// Token: 0x04000123 RID: 291
		private NullableDateTimePicker M5ZJs51OCB;

		// Token: 0x04000124 RID: 292
		private ToolStripButton vYgJ7S05QP;

		// Token: 0x04000125 RID: 293
		private ComboBox OcuJaJU1lF;

		// Token: 0x04000126 RID: 294
		private DataColumn TacJ18fMBC;

		// Token: 0x04000127 RID: 295
		private DataGridViewTextBoxColumn fYgJOAXHZU;

		// Token: 0x04000128 RID: 296
		private DataGridViewTextBoxColumn qg8JLSAKNQ;

		// Token: 0x04000129 RID: 297
		private DataGridViewTextBoxColumn yAXJvrM2tq;

		// Token: 0x0400012A RID: 298
		private DataGridViewTextBoxColumn fRlJ4vE12X;

		// Token: 0x0400012B RID: 299
		private DataGridViewTextBoxColumn AZMJB5EVm8;

		// Token: 0x0400012C RID: 300
		private DataGridViewCheckBoxColumn RI9Jlhlmpg;

		// Token: 0x0400012D RID: 301
		private CheckBox gJsJPJ7k5A;

		// Token: 0x0400012E RID: 302
		private TabPage OMgJwJ5vRd;

		// Token: 0x0400012F RID: 303
		private DataGridViewExcelFilter QQEJ5VCv5Z;

		// Token: 0x04000130 RID: 304
		private BindingSource K6VJ9XsaK9;

		// Token: 0x04000131 RID: 305
		private DataGridViewTextBoxColumn YgjJ2EKqt4;

		// Token: 0x04000132 RID: 306
		private DataGridViewTextBoxColumn UheJATZBOd;

		// Token: 0x04000133 RID: 307
		private DataGridViewTextBoxColumn oGkJV73aOo;

		// Token: 0x04000134 RID: 308
		private DataGridViewTextBoxColumn R0pJKyX3qJ;

		// Token: 0x04000135 RID: 309
		private DataGridViewTextBoxColumn LqrJQsPeFm;

		// Token: 0x04000136 RID: 310
		private DataGridViewTextBoxColumn sqQJSRbNql;

		// Token: 0x04000137 RID: 311
		private DataGridViewTextBoxColumn rgNJku7Xu9;

		// Token: 0x04000138 RID: 312
		private DataGridViewTextBoxColumn NbVJf7f7GG;

		// Token: 0x04000139 RID: 313
		private DataGridViewCheckBoxColumn UaEJ6qjvWD;

		// Token: 0x0400013A RID: 314
		private Button qTqJTaBgHY;
	}
}
