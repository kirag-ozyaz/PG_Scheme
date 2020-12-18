using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using CZUM21s3QjGFLaOaSlT;
using FormLbr;
using HsEXfKsq15GfPw4kPLQ;
using j5c8XXscsIc6vD2Fg4l;
using WTbxUfsXa34kJl1qKMV;

namespace RequestsClient.Forms.JournalRequestForRepair
{
	// Token: 0x02000040 RID: 64
	public partial class FormSettingsSender : FormBase
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x00028320 File Offset: 0x00026720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FormSettingsSender()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 8;
			if (!true)
			{
				goto IL_1A;
			}
			DataColumn[] array;
			DataColumn dataColumn;
			for (;;)
			{
				IL_152:
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 6:
					base..ctor();
					break;
				case 2:
					break;
				case 3:
					goto IL_2D;
				case 4:
					goto IL_1A;
				case 5:
					array[0] = dataColumn;
					this.ttNoRVnVea.PrimaryKey = array;
					num = 9;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 7:
					goto IL_DF;
				case 8:
					FormSettingsSender.EVqXrHlAwt88Oob10oO();
					FormSettingsSender.woBBQHlNPqnbmgFGUYy();
					num = (FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 0 : 6);
					continue;
				case 9:
					return;
				default:
					num = 3;
					continue;
				}
				IL_A4:
				this.E8go8bIHq3();
				this.ttNoRVnVea = new DataTable(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38732));
				num = 7;
				continue;
				goto IL_A4;
			}
			IL_DF:
			dataColumn = new DataColumn(FormSettingsSender.p91n9ElsT2I75NJjme3(6146), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219)));
			dataColumn.AutoIncrement = true;
			FormSettingsSender.oEIu1GlpwYp28C0nNqH(FormSettingsSender.RauNemlfTCdy5OlRT9k(this.ttNoRVnVea), dataColumn);
			this.ttNoRVnVea.Columns.Add(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38754), Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777225)));
			goto IL_2D;
			IL_1A:
			array = new DataColumn[1];
			num = 5;
			if (true)
			{
				goto IL_152;
			}
			IL_2D:
			FormSettingsSender.Fn6o9UlUDSPAncnSR2K(this.ttNoRVnVea.Columns, FormSettingsSender.p91n9ElsT2I75NJjme3(38774), FormSettingsSender.NIdqpBlD9NIGUul7plm(FormSettingsSender.O88pWZlOKa3gxPRf7ID(16777225)));
			num = 4;
			goto IL_152;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000284B8 File Offset: 0x000268B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void pZg0iOwJ1I(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (false)
				{
					return;
				}
			}
			for (;;)
			{
				DataRow dataRow;
				switch (num)
				{
				case 0:
				case 4:
					base.SelectSqlData(this.ttNoRVnVea, true, string.Format(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38790), FormSettingsSender.p91n9ElsT2I75NJjme3(38836)), null, false, 0);
					break;
				case 1:
					break;
				case 2:
					dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4316)] = this.bmk0bkoNpA().InnerXml;
					FormSettingsSender.FaBscOlIwhn0V7ZdZ78(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(38850), cDhluYseFOthxgEIXpc.nKHKpgTSVU(38836));
					goto IL_C5;
				case 3:
					goto IL_C5;
				case 5:
					break;
				case 6:
					return;
				case 7:
					return;
				default:
					num = 3;
					continue;
				}
				IL_24:
				if (FormSettingsSender.xXOS12lJhdhvGAKnLIG(this.ttNoRVnVea).Count == 0)
				{
					dataRow = this.ttNoRVnVea.NewRow();
					num = 2;
					continue;
				}
				this.Ttu0NVoC5y();
				num = 7;
				continue;
				IL_C5:
				FormSettingsSender.fURaU3lZkhVQv7GUQxy(this.ttNoRVnVea.Rows, dataRow);
				num = 6;
				continue;
				goto IL_24;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000285FC File Offset: 0x000269FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void We10YR1ukG(object \u0020, FormClosingEventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 7;
			if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
			{
				goto IL_1E;
			}
			for (;;)
			{
				IL_3C:
				switch (num)
				{
				case 0:
					return;
				case 1:
				case 3:
					if (MessageBox.Show(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38866), FormSettingsSender.p91n9ElsT2I75NJjme3(10540), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						return;
					}
					break;
				case 2:
					break;
				case 4:
					break;
				case 5:
					if (!base.InsertSqlData(this.ttNoRVnVea))
					{
						\u0020.Cancel = true;
						num = 0;
						continue;
					}
					if (!FormSettingsSender.x16aux7WOdpnNlVGMpH(this, this.ttNoRVnVea))
					{
						\u0020.Cancel = true;
						num = 9;
						continue;
					}
					return;
				case 6:
					goto IL_C2;
				case 7:
					while (base.DialogResult != DialogResult.OK)
					{
						FormSettingsSender.woBBQHlNPqnbmgFGUYy();
						if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
						{
							num = 3;
							if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
							{
								return;
							}
							goto IL_3C;
						}
						else
						{
							num = 4;
							if (!false)
							{
								goto IL_3C;
							}
						}
					}
					break;
				case 8:
					goto IL_1E;
				case 9:
					return;
				default:
					num = 6;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				}
				IL_153:
				if (this.ttNoRVnVea.Rows.Count == 0)
				{
					num = 8;
					continue;
				}
				goto IL_108;
				goto IL_153;
			}
			return;
			IL_1E:
			DataRow dataRow = this.ttNoRVnVea.NewRow();
			IL_C2:
			FormSettingsSender.FaBscOlIwhn0V7ZdZ78(dataRow, FormSettingsSender.p91n9ElsT2I75NJjme3(4316), FormSettingsSender.X9maiNlcRdcLZm8Mv1e(this.bmk0bkoNpA()));
			FormSettingsSender.FaBscOlIwhn0V7ZdZ78(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(38850), cDhluYseFOthxgEIXpc.nKHKpgTSVU(38836));
			FormSettingsSender.xXOS12lJhdhvGAKnLIG(this.ttNoRVnVea).Add(dataRow);
			IL_108:
			this.ttNoRVnVea.Rows[0][FormSettingsSender.p91n9ElsT2I75NJjme3(4316)] = this.bmk0bkoNpA().InnerXml;
			FormSettingsSender.flbh0U73pKMv01TxQnb(FormSettingsSender.qHZZyZlzdLdFkag1L9M(this.ttNoRVnVea.Rows, 0));
			num = 5;
			goto IL_3C;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000287DC File Offset: 0x00026BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void V9C0GYvNkD(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			base.Close();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000287F4 File Offset: 0x00026BF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ubB0jAfQvC(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormSettingsSender.ljJUHw7LHJUVbVyFCsN(this);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0002880C File Offset: 0x00026C0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private XmlDocument bmk0bkoNpA()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 32;
			if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
			{
			}
			XmlDocument xmlDocument;
			for (;;)
			{
				XmlNode xmlNode;
				XmlAttribute xmlAttribute;
				XmlNode xmlNode2;
				XmlNode xmlNode3;
				XmlNode xmlNode4;
				XmlNode xmlNode5;
				XmlNode xmlNode6;
				XmlNode xmlNode7;
				XmlNode xmlNode8;
				int num2;
				XmlNode xmlNode9;
				XmlNode xmlNode10;
				XmlNode xmlNode11;
				switch (num)
				{
				case 0:
					xmlNode.Attributes.Append(xmlAttribute);
					if (!this.sQVo4WFoAX.Checked)
					{
						goto IL_394;
					}
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39006));
					xmlAttribute.Value = FormSettingsSender.YuHymu7TprrBvBWFHO9(this.RJXoB6SooV);
					num = 26;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 1:
					xmlAttribute.Value = (FormSettingsSender.ItbU5B7lxayHJ134dAY(this.VP8oFnf2vS) * 24m * 60m).ToString();
					goto IL_889;
				case 2:
					goto IL_51B;
				case 3:
					FormSettingsSender.FeoinD727vyYPr15E01(xmlNode2.Attributes, xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39094));
					if (!FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.mtIob811iE))
					{
						goto IL_32F;
					}
					num = 50;
					if (!true)
					{
						goto IL_840;
					}
					continue;
				case 4:
					xmlAttribute.Value = (FormSettingsSender.ItbU5B7lxayHJ134dAY(this.r6JoiXY9j1) * 24m * 60m).ToString();
					num = 29;
					continue;
				case 5:
					goto IL_394;
				case 6:
					goto IL_4AB;
				case 7:
					FormSettingsSender.E7M5Mk7jbwgNgPjWy8L(xmlNode, xmlNode3);
					xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39080));
					xmlAttribute.Value = this.Yu2opE9oes.Value.ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(30158));
					FormSettingsSender.FeoinD727vyYPr15E01(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode3), xmlAttribute);
					xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39094));
					if (this.JxmoDovFMO.Checked)
					{
						xmlAttribute.Value = (FormSettingsSender.ItbU5B7lxayHJ134dAY(this.d5YoxAPEep) * 60m).ToString();
					}
					if (this.kueotpDpaa.Checked)
					{
						num = 1;
						continue;
					}
					goto IL_889;
				case 8:
					xmlNode4.Attributes.Append(xmlAttribute);
					if (this.zeeuq1NopM.Checked)
					{
						xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(39006));
						num = 17;
						continue;
					}
					goto IL_C35;
				case 9:
					FormSettingsSender.FeoinD727vyYPr15E01(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode5), xmlAttribute);
					num = 58;
					continue;
				case 10:
					goto IL_A68;
				case 11:
					xmlAttribute.Value = this.OimupDkga9.Value.ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(30158));
					num = 41;
					continue;
				case 12:
					goto IL_6E4;
				case 13:
					FormSettingsSender.FeoinD727vyYPr15E01(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode), xmlAttribute);
					num = 52;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 14:
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, FormSettingsSender.YuHymu7TprrBvBWFHO9(this.KUNuypHcpG));
					FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode6).Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute(FormSettingsSender.p91n9ElsT2I75NJjme3(39276));
					xmlAttribute.Value = this.w5TuFUb2jt.Text;
					FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode6).Append(xmlAttribute);
					xmlNode7 = FormSettingsSender.w7A3Bc7X3DXTVLO02Fh(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(39062));
					num = 22;
					if (!true)
					{
						goto IL_180;
					}
					continue;
				case 15:
					xmlNode4.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38996));
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.S82usbI3X8.Text);
					num = 8;
					continue;
				case 16:
					goto IL_712;
				case 17:
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.x2auCffKij.Text);
					num = 39;
					continue;
				case 18:
					xmlNode8 = xmlDocument.CreateElement(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39212));
					xmlNode6.AppendChild(xmlNode8);
					num2 = 0;
					goto IL_B28;
				case 19:
					xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(39042));
					xmlAttribute.Value = FormSettingsSender.YuHymu7TprrBvBWFHO9(this.QZlo5bclsp);
					FormSettingsSender.FeoinD727vyYPr15E01(xmlNode.Attributes, xmlAttribute);
					num = 5;
					if (!true)
					{
						goto IL_A68;
					}
					continue;
				case 20:
					xmlAttribute.Value = FormSettingsSender.XsH0av77okxHFlwDrxG(FormSettingsSender.XsH0av77okxHFlwDrxG(FormSettingsSender.ItbU5B7lxayHJ134dAY(this.ehYu6sgrZp), 24m) * 60m, 7m).ToString();
					goto IL_E12;
				case 21:
				case 35:
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38930));
					xmlAttribute.Value = this.RxPugvS30O.Checked.ToString();
					xmlNode4.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400));
					num = 36;
					continue;
				case 22:
					xmlNode6.AppendChild(xmlNode7);
					goto IL_7BF;
				case 23:
					goto IL_180;
				case 24:
					IL_A6:
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, FormSettingsSender.XsH0av77okxHFlwDrxG(FormSettingsSender.XsH0av77okxHFlwDrxG(FormSettingsSender.XsH0av77okxHFlwDrxG(this.EUVortqIPp.Value, 24m), 60m), 7m).ToString());
					goto IL_E3;
				case 25:
					xmlAttribute.Value = (FormSettingsSender.ItbU5B7lxayHJ134dAY(this.m0uudPYZpX) * 60m).ToString();
					break;
				case 26:
					goto IL_840;
				case 27:
					xmlNode9 = xmlDocument.CreateElement(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4336));
					num = 30;
					continue;
				case 28:
					xmlAttribute.Value = this.jVhoE67YN1.Value.ToString(FormSettingsSender.p91n9ElsT2I75NJjme3(30158));
					num = 3;
					if (false)
					{
						goto IL_BA7;
					}
					continue;
				case 29:
					goto IL_2AD;
				case 30:
					IL_8A9:
					FormSettingsSender.E7M5Mk7jbwgNgPjWy8L(xmlDocument, xmlNode9);
					xmlNode = FormSettingsSender.w7A3Bc7X3DXTVLO02Fh(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(38836));
					FormSettingsSender.E7M5Mk7jbwgNgPjWy8L(xmlNode9, xmlNode);
					xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(38930));
					xmlAttribute.Value = this.fwro9xuoth.Checked.ToString();
					num = 53;
					continue;
				case 31:
					IL_2D1:
					FormSettingsSender.FeoinD727vyYPr15E01(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode3), xmlAttribute);
					num = 56;
					continue;
				case 32:
					goto IL_C8F;
				case 33:
					xmlAttribute = xmlDocument.CreateAttribute(FormSettingsSender.p91n9ElsT2I75NJjme3(38984));
					xmlAttribute.Value = this.Uc8uXeCNrg.Text;
					num = 15;
					if (!true)
					{
						goto IL_6E4;
					}
					continue;
				case 34:
					xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39020));
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.OxNolWaRba.Text);
					FormSettingsSender.FeoinD727vyYPr15E01(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode), xmlAttribute);
					num = 19;
					continue;
				case 36:
					goto IL_3EB;
				case 37:
					goto IL_78C;
				case 38:
					FormSettingsSender.E7M5Mk7jbwgNgPjWy8L(xmlNode9, xmlNode4);
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						num = 23;
						continue;
					}
					num = 35;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_4AB;
					}
					continue;
				case 39:
					xmlNode4.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39020));
					goto IL_BE6;
				case 40:
					goto IL_B28;
				case 41:
					FormSettingsSender.FeoinD727vyYPr15E01(xmlNode7.Attributes, xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39094));
					num = 54;
					continue;
				case 42:
					xmlAttribute = xmlDocument.CreateAttribute(FormSettingsSender.p91n9ElsT2I75NJjme3(38966));
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.qsfomPxWc6.Text);
					xmlNode.Attributes.Append(xmlAttribute);
					num = 55;
					continue;
				case 43:
					xmlAttribute.Value = (FormSettingsSender.XsH0av77okxHFlwDrxG(FormSettingsSender.XsH0av77okxHFlwDrxG(this.TW4oHbeOyt.Value, 24m), 60m) * 7m).ToString();
					num = 31;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 44:
					goto IL_32F;
				case 45:
					goto IL_BE6;
				case 46:
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38996));
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, FormSettingsSender.YuHymu7TprrBvBWFHO9(this.tguuBT2lFE));
					FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode10).Append(xmlAttribute);
					num = 16;
					continue;
				case 47:
					xmlAttribute.Value = this.n2Hu5bSws2.Value.ToString();
					FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode10).Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(28960));
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.Tx3uPcd9UZ.Text);
					FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode10).Append(xmlAttribute);
					num = 46;
					continue;
				case 48:
					goto IL_7BF;
				case 49:
					xmlNode6.AppendChild(xmlNode10);
					xmlAttribute = xmlDocument.CreateAttribute(FormSettingsSender.p91n9ElsT2I75NJjme3(614));
					xmlAttribute.Value = this.UXYu2ec0FP.Text;
					num = 37;
					continue;
				case 50:
					xmlAttribute.Value = (this.gO0oYQ1dHf.Value * 60m).ToString();
					num = 44;
					continue;
				case 51:
					xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38996));
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.LirovRKmrk.Text);
					num = 0;
					continue;
				case 52:
					IL_C72:
					xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(38946));
					num = 12;
					if (!true)
					{
						goto IL_C8F;
					}
					continue;
				case 53:
					xmlNode.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute(FormSettingsSender.p91n9ElsT2I75NJjme3(10400));
					xmlAttribute.Value = this.seDoXeDyD6.Text;
					num = 13;
					if (false)
					{
						goto IL_3EB;
					}
					continue;
				case 54:
					goto IL_B0E;
				case 55:
					goto IL_BA7;
				case 56:
					xmlNode4 = xmlDocument.CreateElement(FormSettingsSender.p91n9ElsT2I75NJjme3(956));
					num = 38;
					continue;
				case 57:
					FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode11).Append(xmlAttribute);
					num = 18;
					continue;
				case 58:
					return xmlDocument;
				default:
					num = 45;
					continue;
				}
				IL_48:
				if (this.LADutCXOdb.Checked)
				{
					FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, (FormSettingsSender.ItbU5B7lxayHJ134dAY(this.k71uT9NO8T) * 24m * 60m).ToString());
				}
				if (!FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.x2juUJENsT))
				{
					goto IL_E12;
				}
				num = 20;
				if (!true)
				{
					goto IL_A6;
				}
				continue;
				IL_E3:
				FormSettingsSender.FeoinD727vyYPr15E01(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode2), xmlAttribute);
				num = 10;
				continue;
				IL_2AD:
				if (!this.HQIoG7WF2l.Checked)
				{
					goto IL_E3;
				}
				num = 24;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				continue;
				IL_32F:
				if (FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.ix2oj2wknM))
				{
					num = 4;
					continue;
				}
				goto IL_2AD;
				IL_180:
				xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39080));
				num = 11;
				continue;
				IL_7BF:
				goto IL_180;
				IL_889:
				if (!this.SYeoUtOBCc.Checked)
				{
					goto IL_2D1;
				}
				num = 43;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_8A9;
				}
				continue;
				IL_394:
				xmlNode3 = FormSettingsSender.w7A3Bc7X3DXTVLO02Fh(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(39062));
				num = 7;
				continue;
				IL_3EB:
				xmlAttribute.Value = this.zgCueCPULg.Text;
				FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode4).Append(xmlAttribute);
				num = 6;
				continue;
				IL_4AB:
				xmlAttribute = xmlDocument.CreateAttribute(FormSettingsSender.p91n9ElsT2I75NJjme3(38946));
				FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.fl1uIcLa7X.Text);
				FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode4).Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38966));
				xmlAttribute.Value = FormSettingsSender.YuHymu7TprrBvBWFHO9(this.pBYuomHju0);
				xmlNode4.Attributes.Append(xmlAttribute);
				num = 33;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_51B:
				xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4380));
				FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.LrfujmRk7x.Checked.ToString());
				num = 9;
				continue;
				IL_6E4:
				xmlAttribute.Value = FormSettingsSender.YuHymu7TprrBvBWFHO9(this.BTfo6OSA71);
				xmlNode.Attributes.Append(xmlAttribute);
				num = 42;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_712:
				xmlNode11 = FormSettingsSender.w7A3Bc7X3DXTVLO02Fh(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39178));
				xmlNode6.AppendChild(xmlNode11);
				xmlAttribute = xmlDocument.CreateAttribute(FormSettingsSender.p91n9ElsT2I75NJjme3(39194));
				xmlAttribute.Value = this.pLtuSNtbly.Text;
				xmlNode11.Attributes.Append(xmlAttribute);
				xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(614));
				FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.Rg2uKLCjMO.Text);
				num = 57;
				if (!false)
				{
					continue;
				}
				IL_78C:
				FormSettingsSender.FeoinD727vyYPr15E01(xmlNode10.Attributes, xmlAttribute);
				xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(39166));
				num = 47;
				continue;
				IL_840:
				xmlNode.Attributes.Append(xmlAttribute);
				num = 34;
				continue;
				IL_A68:
				xmlNode6 = FormSettingsSender.w7A3Bc7X3DXTVLO02Fh(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(39110));
				FormSettingsSender.E7M5Mk7jbwgNgPjWy8L(xmlNode9, xmlNode6);
				xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39136));
				xmlAttribute.Value = FormSettingsSender.XVioqh71ooDBkWr0LGp(this.w86uLOZ6Cn).ToString();
				FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode6).Append(xmlAttribute);
				xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400));
				FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.v73u14AJPD.Text);
				FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode6).Append(xmlAttribute);
				xmlNode10 = FormSettingsSender.w7A3Bc7X3DXTVLO02Fh(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39154));
				num = 49;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_B0E;
				}
				continue;
				IL_B28:
				if (num2 >= FormSettingsSender.ojruD97VH83tKclqQGX(FormSettingsSender.Nf2Tal7w6IL4eslCDgJ(this.dshursBUcC)) - 1)
				{
					xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(39258));
					num = 14;
					continue;
				}
				XmlNode xmlNode12 = xmlDocument.CreateElement(FormSettingsSender.p91n9ElsT2I75NJjme3(39236));
				xmlNode8.AppendChild(xmlNode12);
				xmlAttribute = xmlDocument.CreateAttribute(FormSettingsSender.p91n9ElsT2I75NJjme3(39194));
				xmlAttribute.Value = FormSettingsSender.w49Hej7tUiIXyogdY9Y(FormSettingsSender.qcHA1274BdBGHpvwKe5(FormSettingsSender.QOYq3R7G5GT1gGoseHy(this.dshursBUcC.Rows, num2))[this.v51uidnQU1.Name]).ToString();
				FormSettingsSender.FeoinD727vyYPr15E01(xmlNode12.Attributes, xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(614));
				FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, FormSettingsSender.Nf2Tal7w6IL4eslCDgJ(this.dshursBUcC)[num2].Cells[this.RaHuYYIwGE.Name].Value.ToString());
				FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode12).Append(xmlAttribute);
				num2++;
				num = 40;
				continue;
				IL_BA7:
				xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(38984));
				FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.MRFoaqvscI.Text);
				FormSettingsSender.FeoinD727vyYPr15E01(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode), xmlAttribute);
				num = 51;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_BE6;
				}
				continue;
				IL_C35:
				xmlNode2 = FormSettingsSender.w7A3Bc7X3DXTVLO02Fh(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39062));
				FormSettingsSender.E7M5Mk7jbwgNgPjWy8L(xmlNode4, xmlNode2);
				xmlAttribute = xmlDocument.CreateAttribute(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39080));
				num = 28;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_C72;
				}
				continue;
				IL_BE6:
				FormSettingsSender.YXQSm47Hh333PMgh1vq(xmlAttribute, this.WXUu8KMxpD.Text);
				xmlNode4.Attributes.Append(xmlAttribute);
				xmlAttribute = FormSettingsSender.Xgh1Le7r9ciS8nMCteJ(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39042));
				xmlAttribute.Value = FormSettingsSender.YuHymu7TprrBvBWFHO9(this.XGLundBwE3);
				FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode4).Append(xmlAttribute);
				goto IL_C35;
				IL_C8F:
				xmlDocument = new XmlDocument();
				num = 27;
				continue;
				IL_E12:
				FormSettingsSender.FeoinD727vyYPr15E01(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode7), xmlAttribute);
				XmlNode xmlNode13 = xmlDocument.CreateElement(FormSettingsSender.p91n9ElsT2I75NJjme3(39288));
				FormSettingsSender.XSID0X7kflnSLhmBqAO(xmlNode13, this.W85oQ1v70T.Text);
				xmlNode9.AppendChild(xmlNode13);
				xmlNode5 = FormSettingsSender.w7A3Bc7X3DXTVLO02Fh(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4370));
				xmlNode9.AppendChild(xmlNode5);
				num = 2;
				continue;
				IL_B0E:
				if (!FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.g4wuDPMX6y))
				{
					goto IL_48;
				}
				num = 25;
			}
			return xmlDocument;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0002975C File Offset: 0x00027B5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Ttu0NVoC5y()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 33;
			for (;;)
			{
				XmlAttribute xmlAttribute;
				XmlAttribute xmlAttribute2;
				XmlNode xmlNode;
				XmlAttribute xmlAttribute3;
				XmlNode xmlNode2;
				XmlNode xmlNode3;
				XmlNode xmlNode4;
				XmlNode xmlNode5;
				int num3;
				XmlNode xmlNode6;
				XmlNode xmlNode7;
				XmlNode xmlNode8;
				XmlAttribute xmlAttribute4;
				int num4;
				XmlNode xmlNode9;
				switch (num)
				{
				case 0:
					this.fwro9xuoth.Checked = Convert.ToBoolean(FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute));
					goto IL_9D1;
				case 1:
					goto IL_C6A;
				case 2:
					if (xmlAttribute2 != null)
					{
						this.w5TuFUb2jt.Text = xmlAttribute2.Value;
						num = 58;
						continue;
					}
					goto IL_B59;
				case 3:
					break;
				case 4:
					if (xmlNode != null)
					{
						xmlAttribute = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39080));
						num = 55;
						continue;
					}
					break;
				case 5:
					goto IL_768;
				case 6:
					IL_621:
					if (xmlAttribute != null)
					{
						num = 16;
						continue;
					}
					break;
				case 7:
				{
					int num2 = FormSettingsSender.PsZkqu7isn8ONajJOEo(xmlAttribute3.Value);
					num = 61;
					if (false)
					{
						goto IL_44A;
					}
					continue;
				}
				case 8:
					xmlAttribute3 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode2)[FormSettingsSender.p91n9ElsT2I75NJjme3(39080)];
					num = 11;
					continue;
				case 9:
					goto IL_508;
				case 10:
					if (xmlNode3 == null)
					{
						goto IL_5FC;
					}
					xmlAttribute2 = xmlNode3.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(614)];
					if (xmlAttribute2 != null)
					{
						this.UXYu2ec0FP.Text = FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute2);
						num = 59;
						continue;
					}
					goto IL_A39;
				case 11:
					if (xmlAttribute3 != null)
					{
						num = 31;
						continue;
					}
					goto IL_A10;
				case 12:
					this.LirovRKmrk.Text = FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute);
					goto IL_A74;
				case 13:
					this.BTfo6OSA71.Text = xmlAttribute.Value;
					goto IL_2DC;
				case 14:
					goto IL_508;
				case 15:
					IL_AAA:
					xmlAttribute3 = xmlNode4.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38946)];
					if (xmlAttribute3 != null)
					{
						this.fl1uIcLa7X.Text = FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute3);
						num = 34;
						continue;
					}
					goto IL_6AA;
				case 16:
					goto IL_1F1;
				case 17:
					if (xmlAttribute != null)
					{
						num = 12;
						continue;
					}
					goto IL_A74;
				case 18:
					if (xmlAttribute2 != null)
					{
						FormSettingsSender.PcqABe7mBEg9uMisXOp(this.KUNuypHcpG, FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute2));
						num = ((!FormSettingsSender.woBBQHlNPqnbmgFGUYy()) ? 23 : 50);
						continue;
					}
					goto IL_CCC;
				case 19:
					goto IL_CB;
				case 20:
					if (xmlAttribute3 != null)
					{
						this.RxPugvS30O.Checked = Convert.ToBoolean(xmlAttribute3.Value);
						num = 19;
						continue;
					}
					FormSettingsSender.w3qYf77g68Y8YFh41Xg(this.RxPugvS30O, false);
					goto IL_CB;
				case 21:
					goto IL_27B;
				case 22:
					IL_DCF:
					this.zeeuq1NopM.Checked = true;
					goto IL_185;
				case 23:
					goto IL_FA8;
				case 24:
					if (xmlAttribute != null)
					{
						num = 13;
						continue;
					}
					goto IL_2DC;
				case 25:
					if (xmlNode5 == null)
					{
						goto IL_508;
					}
					xmlAttribute2 = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode5.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39080));
					if (xmlAttribute2 != null)
					{
						FormSettingsSender.t2qQXa7RSpNwp6MLCjU(this.OimupDkga9, Convert.ToDateTime(FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute2)));
						num = 54;
						continue;
					}
					goto IL_F4E;
				case 26:
					goto IL_559;
				case 27:
					this.seDoXeDyD6.Text = xmlAttribute.Value;
					goto IL_918;
				case 28:
					break;
				case 29:
					this.k71uT9NO8T.Value = num3 / 1440;
					num = 14;
					if (!true)
					{
						goto IL_27B;
					}
					continue;
				case 30:
					goto IL_F02;
				case 31:
					FormSettingsSender.t2qQXa7RSpNwp6MLCjU(this.jVhoE67YN1, Convert.ToDateTime(xmlAttribute3.Value));
					goto IL_A10;
				case 32:
					if (xmlNode6 != null && !string.IsNullOrEmpty(xmlNode6.InnerText))
					{
						num = 52;
						continue;
					}
					goto IL_986;
				case 33:
					if (FormSettingsSender.xXOS12lJhdhvGAKnLIG(this.ttNoRVnVea).Count <= 0)
					{
						return;
					}
					num = 35;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_975;
					}
					continue;
				case 34:
					goto IL_6AA;
				case 35:
				{
					if (FormSettingsSender.xXOS12lJhdhvGAKnLIG(this.ttNoRVnVea)[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(4316)] == DBNull.Value)
					{
						return;
					}
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(FormSettingsSender.UNqt5N7ddWoBHBO1RFd(this.ttNoRVnVea.Rows[0], FormSettingsSender.p91n9ElsT2I75NJjme3(4316)).ToString());
					xmlNode7 = FormSettingsSender.V3kd5o7bC9JxPmM24jB(xmlDocument, FormSettingsSender.p91n9ElsT2I75NJjme3(4336));
					if (xmlNode7 == null)
					{
						return;
					}
					num = 38;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_185;
					}
					continue;
				}
				case 36:
					goto IL_661;
				case 37:
					goto IL_529;
				case 38:
					xmlNode6 = xmlNode7.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(38836));
					num = 37;
					continue;
				case 39:
					if (xmlAttribute2 != null)
					{
						this.Tx3uPcd9UZ.Text = FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute2);
					}
					xmlAttribute2 = xmlNode3.Attributes[FormSettingsSender.p91n9ElsT2I75NJjme3(38996)];
					if (xmlAttribute2 != null)
					{
						this.tguuBT2lFE.Text = FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute2);
						goto IL_5FC;
					}
					goto IL_5FC;
				case 40:
					if (xmlAttribute != null)
					{
						num = 1;
						continue;
					}
					goto IL_678;
				case 41:
				case 50:
					goto IL_CCC;
				case 42:
					xmlAttribute4 = FormSettingsSender.pLKsRy7Fkb7OixyahVV(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode8), FormSettingsSender.p91n9ElsT2I75NJjme3(4380));
					goto IL_4F8;
				case 43:
					this.w86uLOZ6Cn.Checked = Convert.ToBoolean(FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute2));
					goto IL_9E;
				case 44:
					goto IL_4BA;
				case 45:
					goto IL_44A;
				case 46:
					goto IL_F20;
				case 47:
					goto IL_246;
				case 48:
					goto IL_678;
				case 49:
					FormSettingsSender.fIisxl7K3edl4lv7FCe(this.TW4oHbeOyt, FormSettingsSender.EIK4YG79QmXyfim0J4X(num4 / 10080));
					num = 3;
					continue;
				case 51:
				{
					int num2;
					this.EUVortqIPp.Value = FormSettingsSender.EIK4YG79QmXyfim0J4X(num2 / 10080);
					goto IL_D61;
				}
				case 52:
					goto IL_975;
				case 53:
					this.SYeoUtOBCc.Checked = true;
					num = 49;
					continue;
				case 54:
					goto IL_F4E;
				case 55:
					if (xmlAttribute != null)
					{
						FormSettingsSender.t2qQXa7RSpNwp6MLCjU(this.Yu2opE9oes, Convert.ToDateTime(FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute)));
					}
					xmlAttribute = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39094));
					num = 6;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_CCC;
					}
					continue;
				case 56:
					xmlAttribute2 = xmlNode9.Attributes[FormSettingsSender.p91n9ElsT2I75NJjme3(39194)];
					if (xmlAttribute2 != null)
					{
						FormSettingsSender.PcqABe7mBEg9uMisXOp(this.pLtuSNtbly, FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute2));
					}
					xmlAttribute2 = xmlNode9.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(614)];
					if (xmlAttribute2 != null)
					{
						FormSettingsSender.PcqABe7mBEg9uMisXOp(this.Rg2uKLCjMO, xmlAttribute2.Value);
						num = 5;
						continue;
					}
					goto IL_768;
				case 57:
					this.QZlo5bclsp.Text = FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute);
					num = 30;
					continue;
				case 58:
					goto IL_B59;
				case 59:
					goto IL_A39;
				case 60:
					goto IL_4F8;
				case 61:
				{
					int num2;
					if (num2 == 0)
					{
						this.mtIob811iE.Checked = true;
						FormSettingsSender.fIisxl7K3edl4lv7FCe(this.gO0oYQ1dHf, 0m);
					}
					if (num2 % 10080 == 0)
					{
						this.HQIoG7WF2l.Checked = true;
						num = 51;
						if (!true)
						{
							return;
						}
						continue;
					}
					else
					{
						if (num2 % 1440 == 0)
						{
							this.ix2oj2wknM.Checked = true;
							this.r6JoiXY9j1.Value = num2 / 1440;
							goto IL_D61;
						}
						FormSettingsSender.DaX7XE7EPNsCB4U38gt(this.mtIob811iE, true);
						FormSettingsSender.fIisxl7K3edl4lv7FCe(this.gO0oYQ1dHf, FormSettingsSender.EIK4YG79QmXyfim0J4X(num2 / 60));
						goto IL_D61;
					}
					break;
				}
				case 62:
					goto IL_185;
				case 63:
					return;
				default:
					num = 62;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_F02;
					}
					continue;
				}
				IL_3E:
				xmlNode4 = FormSettingsSender.V3kd5o7bC9JxPmM24jB(xmlNode7, cDhluYseFOthxgEIXpc.nKHKpgTSVU(956));
				if (xmlNode4 != null)
				{
					xmlAttribute3 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode4)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38930)];
					num = 20;
					continue;
				}
				goto IL_D61;
				IL_9E:
				XmlNode xmlNode10;
				xmlNode3 = xmlNode10.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39154));
				num = 10;
				continue;
				IL_B59:
				xmlAttribute2 = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode10.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39136));
				if (xmlAttribute2 != null)
				{
					num = 43;
					continue;
				}
				this.w86uLOZ6Cn.Checked = false;
				goto IL_9E;
				IL_CB:
				xmlAttribute3 = xmlNode4.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400)];
				if (xmlAttribute3 != null)
				{
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.zgCueCPULg, FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute3));
					num = 15;
					continue;
				}
				goto IL_AAA;
				IL_185:
				this.x2auCffKij.Text = FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute3);
				xmlAttribute3 = xmlNode4.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39020)];
				if (xmlAttribute3 != null)
				{
					this.WXUu8KMxpD.Text = xmlAttribute3.Value;
				}
				xmlAttribute3 = FormSettingsSender.pLKsRy7Fkb7OixyahVV(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode4), cDhluYseFOthxgEIXpc.nKHKpgTSVU(39042));
				if (xmlAttribute3 == null)
				{
					goto IL_F32;
				}
				num = 46;
				if (!false)
				{
					continue;
				}
				IL_1F1:
				num4 = Convert.ToInt32(xmlAttribute.Value);
				if (num4 == 0)
				{
					num = 44;
					continue;
				}
				goto IL_661;
				IL_559:
				if (num3 % 10080 == 0)
				{
					this.x2juUJENsT.Checked = true;
					this.ehYu6sgrZp.Value = FormSettingsSender.EIK4YG79QmXyfim0J4X(num3 / 10080);
					goto IL_508;
				}
				if (num3 % 1440 == 0)
				{
					this.LADutCXOdb.Checked = true;
					num = 29;
					continue;
				}
				this.g4wuDPMX6y.Checked = true;
				this.m0uudPYZpX.Value = num3 / 60;
				num = 9;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_246;
				}
				continue;
				IL_F4E:
				xmlAttribute2 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode5)[FormSettingsSender.p91n9ElsT2I75NJjme3(39094)];
				if (xmlAttribute2 == null)
				{
					goto IL_508;
				}
				num3 = Convert.ToInt32(xmlAttribute2.Value);
				if (num3 == 0)
				{
					this.g4wuDPMX6y.Checked = true;
					FormSettingsSender.fIisxl7K3edl4lv7FCe(this.m0uudPYZpX, 0m);
					num = 26;
					continue;
				}
				goto IL_559;
				IL_246:
				if (xmlNode2 != null)
				{
					num = 8;
					continue;
				}
				goto IL_D61;
				IL_2A8:
				xmlAttribute2 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode3)[FormSettingsSender.p91n9ElsT2I75NJjme3(28960)];
				num = 39;
				continue;
				IL_A39:
				xmlAttribute2 = xmlNode3.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39166)];
				if (xmlAttribute2 != null)
				{
					num = 21;
					continue;
				}
				goto IL_2A8;
				IL_27B:
				if (!FormSettingsSender.nJKj6r7eeS2eR1oXRDx(FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute2)))
				{
					FormSettingsSender.fIisxl7K3edl4lv7FCe(this.n2Hu5bSws2, Convert.ToInt32(xmlAttribute2.Value));
					goto IL_2A8;
				}
				goto IL_2A8;
				IL_2DC:
				xmlAttribute = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode6)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38966)];
				if (xmlAttribute != null)
				{
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.qsfomPxWc6, FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute));
				}
				xmlAttribute = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode6)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38984)];
				num = 40;
				continue;
				IL_44A:
				FormSettingsSender.PcqABe7mBEg9uMisXOp(this.RJXoB6SooV, xmlAttribute.Value);
				xmlAttribute = FormSettingsSender.pLKsRy7Fkb7OixyahVV(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode6), cDhluYseFOthxgEIXpc.nKHKpgTSVU(39020));
				if (xmlAttribute != null)
				{
					this.OxNolWaRba.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode6.Attributes[FormSettingsSender.p91n9ElsT2I75NJjme3(39042)];
				if (xmlAttribute == null)
				{
					goto IL_F02;
				}
				num = 57;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_4BA:
				FormSettingsSender.DaX7XE7EPNsCB4U38gt(this.JxmoDovFMO, true);
				FormSettingsSender.fIisxl7K3edl4lv7FCe(this.d5YoxAPEep, 0m);
				num = 36;
				continue;
				IL_508:
				xmlNode6 = FormSettingsSender.V3kd5o7bC9JxPmM24jB(xmlNode7, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39288));
				num = 32;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_529;
				}
				continue;
				IL_D61:
				xmlNode10 = xmlNode7.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39110));
				if (xmlNode10 == null)
				{
					goto IL_508;
				}
				xmlAttribute2 = xmlNode10.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400)];
				if (xmlAttribute2 != null)
				{
					this.v73u14AJPD.Text = xmlAttribute2.Value;
				}
				xmlAttribute2 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode10)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39258)];
				num = 18;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_DCF;
				}
				continue;
				IL_A10:
				xmlAttribute3 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode2)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39094)];
				if (xmlAttribute3 != null)
				{
					num = 7;
					continue;
				}
				goto IL_D61;
				IL_5FC:
				xmlNode9 = FormSettingsSender.V3kd5o7bC9JxPmM24jB(xmlNode10, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39178));
				if (xmlNode9 == null)
				{
					goto IL_768;
				}
				num = 56;
				if (!true)
				{
					goto IL_621;
				}
				continue;
				IL_661:
				if (num4 % 10080 == 0)
				{
					num = 53;
					continue;
				}
				if (num4 % 1440 != 0)
				{
					FormSettingsSender.DaX7XE7EPNsCB4U38gt(this.JxmoDovFMO, true);
					this.d5YoxAPEep.Value = num4 / 60;
					goto IL_3E;
				}
				this.kueotpDpaa.Checked = true;
				this.VP8oFnf2vS.Value = num4 / 1440;
				num = 28;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_C6A;
				}
				continue;
				IL_678:
				xmlAttribute = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode6.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(38996));
				num = 17;
				continue;
				IL_6AA:
				xmlAttribute3 = FormSettingsSender.pLKsRy7Fkb7OixyahVV(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode4), cDhluYseFOthxgEIXpc.nKHKpgTSVU(38966));
				if (xmlAttribute3 != null)
				{
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.pBYuomHju0, FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute3));
				}
				xmlAttribute3 = xmlNode4.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38984)];
				if (xmlAttribute3 != null)
				{
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.Uc8uXeCNrg, xmlAttribute3.Value);
				}
				xmlAttribute3 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode4)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38996)];
				if (xmlAttribute3 != null)
				{
					this.S82usbI3X8.Text = xmlAttribute3.Value;
				}
				xmlAttribute3 = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode4.Attributes, FormSettingsSender.p91n9ElsT2I75NJjme3(39006));
				if (xmlAttribute3 == null)
				{
					goto IL_F32;
				}
				num = 22;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_768:
				this.dshursBUcC.Rows.Clear();
				XmlNode xmlNode11 = xmlNode10.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39212));
				if (xmlNode11 != null)
				{
					using (IEnumerator enumerator = FormSettingsSender.fpheGP7MwMypPwbFFRV(xmlNode11, FormSettingsSender.p91n9ElsT2I75NJjme3(39236)).GetEnumerator())
					{
						IL_8A5:
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							XmlNode xmlNode12 = (XmlNode)obj2;
							string text = "";
							string text2 = "";
							xmlAttribute2 = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode12.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39194));
							if (xmlAttribute2 != null)
							{
								text = xmlAttribute2.Value;
							}
							xmlAttribute2 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode12)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(614)];
							int num5 = 0;
							for (;;)
							{
								switch (num5)
								{
								case 0:
									if (xmlAttribute2 != null)
									{
										FormSettingsSender.LeYg67lSeyEyv7mLyx1();
										num5 = ((!FormSettingsSender.woBBQHlNPqnbmgFGUYy()) ? 3 : 4);
										continue;
									}
									break;
								case 1:
								case 4:
									goto IL_83C;
								case 5:
									goto IL_8A5;
								}
								IL_80F:
								FormSettingsSender.Ekkrg375y78ECMA89Xg(FormSettingsSender.Nf2Tal7w6IL4eslCDgJ(this.dshursBUcC), new object[]
								{
									text,
									text2
								});
								num5 = 5;
								if (!true)
								{
									goto IL_83C;
								}
								continue;
								IL_874:
								goto IL_80F;
								IL_83C:
								text2 = xmlAttribute2.Value;
								goto IL_874;
							}
						}
					}
				}
				xmlNode5 = xmlNode10.SelectSingleNode(FormSettingsSender.p91n9ElsT2I75NJjme3(39062));
				num = 25;
				continue;
				IL_918:
				xmlAttribute = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode6.Attributes, FormSettingsSender.p91n9ElsT2I75NJjme3(38946));
				num = 24;
				continue;
				IL_9D1:
				xmlAttribute = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode6.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400));
				if (xmlAttribute != null)
				{
					num = 27;
					continue;
				}
				goto IL_918;
				IL_986:
				xmlNode8 = FormSettingsSender.V3kd5o7bC9JxPmM24jB(xmlNode7, FormSettingsSender.p91n9ElsT2I75NJjme3(4370));
				if (xmlNode8 != null)
				{
					num = 42;
					continue;
				}
				break;
				IL_975:
				this.W85oQ1v70T.Text = xmlNode6.InnerText;
				goto IL_986;
				IL_A74:
				xmlAttribute = FormSettingsSender.pLKsRy7Fkb7OixyahVV(xmlNode6.Attributes, FormSettingsSender.p91n9ElsT2I75NJjme3(39006));
				if (xmlAttribute == null)
				{
					goto IL_F02;
				}
				FormSettingsSender.w3qYf77g68Y8YFh41Xg(this.sQVo4WFoAX, true);
				num = 45;
				if (false)
				{
					goto IL_AAA;
				}
				continue;
				IL_C6A:
				FormSettingsSender.PcqABe7mBEg9uMisXOp(this.MRFoaqvscI, FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute));
				num = 48;
				continue;
				IL_CCC:
				xmlAttribute2 = FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode10)[FormSettingsSender.p91n9ElsT2I75NJjme3(39276)];
				num = 2;
				continue;
				IL_F02:
				xmlNode = xmlNode6.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39062));
				num = 4;
				if (!true)
				{
					goto IL_F20;
				}
				continue;
				IL_F32:
				xmlNode2 = xmlNode4.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39062));
				num = 47;
				continue;
				IL_F20:
				FormSettingsSender.PcqABe7mBEg9uMisXOp(this.XGLundBwE3, FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute3));
				goto IL_F32;
				IL_FA8:
				if (xmlAttribute4 != null)
				{
					FormSettingsSender.w3qYf77g68Y8YFh41Xg(this.LrfujmRk7x, FormSettingsSender.C0XbYO7vdsTJy6ZHmFi(FormSettingsSender.ItknuK7P9upnqrZ26lQ(xmlAttribute4)));
					num = 63;
					continue;
				}
				break;
				IL_4F8:
				goto IL_FA8;
				IL_529:
				if (xmlNode6 == null)
				{
					goto IL_3E;
				}
				xmlAttribute = FormSettingsSender.pLKsRy7Fkb7OixyahVV(FormSettingsSender.KpA88j7nvkmmYrRpTnl(xmlNode6), cDhluYseFOthxgEIXpc.nKHKpgTSVU(38930));
				if (xmlAttribute == null)
				{
					this.fwro9xuoth.Checked = false;
					goto IL_9D1;
				}
				num = 0;
				if (!true)
				{
					goto IL_559;
				}
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0002A7A0 File Offset: 0x00028BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Ek20Egp2bn(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			for (;;)
			{
				OpenFileDialog openFileDialog;
				switch (num)
				{
				case 0:
				case 2:
					openFileDialog.Multiselect = false;
					break;
				case 4:
					openFileDialog = new OpenFileDialog();
					num = 6;
					continue;
				case 5:
					if (openFileDialog.ShowDialog() != DialogResult.OK)
					{
						return;
					}
					this.W85oQ1v70T.Text = openFileDialog.FileName;
					num = 7;
					if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						continue;
					}
					break;
				case 6:
					FormSettingsSender.N0KGSR7CmQbtQkOuavN(openFileDialog, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39308));
					if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						num = 0;
						if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
						{
							continue;
						}
						continue;
					}
					else
					{
						num = 1;
						if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
						{
							continue;
						}
						continue;
					}
					break;
				case 7:
					return;
				}
				IL_CD:
				openFileDialog.FileName = this.W85oQ1v70T.Text;
				num = 5;
				continue;
				goto IL_CD;
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0002A8A8 File Offset: 0x00028CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void lr60hBiNWK(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			object lirovRKmrk = this.LirovRKmrk;
			object mrfoaqvscI = this.MRFoaqvscI;
			object obj2 = this.seDoXeDyD6;
			object obj3 = this.qsfomPxWc6;
			Control rjxoB6SooV = this.RJXoB6SooV;
			Control qzlo5bclsp = this.QZlo5bclsp;
			object oxNolWaRba = this.OxNolWaRba;
			Control control = this.sQVo4WFoAX;
			bool enabled;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.KROokpgJ7h, enabled = (this.BTfo6OSA71.Enabled = (this.xWyoTABNxr.Enabled = (this.ETVodSvqVE.Enabled = FormSettingsSender.XVioqh71ooDBkWr0LGp(this.fwro9xuoth)))));
			bool enabled2;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(oxNolWaRba, enabled2 = (control.Enabled = enabled));
			bool flag;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(obj3, flag = (rjxoB6SooV.Enabled = (qzlo5bclsp.Enabled = enabled2)));
			bool flag2;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(obj2, flag2 = flag);
			bool flag3;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(mrfoaqvscI, flag3 = flag2);
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(lirovRKmrk, flag3);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0002A984 File Offset: 0x00028D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void YgI0zZFGDy(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 6;
			for (;;)
			{
				SaveFileDialog saveFileDialog;
				switch (num)
				{
				case 0:
				case 1:
					FormSettingsSender.N0KGSR7CmQbtQkOuavN(saveFileDialog, FormSettingsSender.p91n9ElsT2I75NJjme3(39358));
					FormSettingsSender.frr6387xojQ0sUepqE3(saveFileDialog, false);
					goto IL_4F;
				case 2:
					goto IL_4F;
				case 3:
					this.seDoXeDyD6.Text = FormSettingsSender.zL9fYo7u6ZEBItea0pv(saveFileDialog.FileName);
					num = 7;
					continue;
				case 4:
					break;
				case 5:
					goto IL_A6;
				case 6:
					saveFileDialog = new SaveFileDialog();
					FormSettingsSender.woBBQHlNPqnbmgFGUYy();
					num = (FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 5 : 0);
					continue;
				case 7:
					return;
				default:
					num = 4;
					if (false)
					{
						return;
					}
					continue;
				}
				IL_5F:
				FormSettingsSender.QNfjPw7opZGMPwc1DQD(saveFileDialog, this.seDoXeDyD6.Text);
				if (FormSettingsSender.l4kdt37YKmJrm2FE3LZ(saveFileDialog) == DialogResult.OK)
				{
					num = 3;
					continue;
				}
				break;
				IL_A6:
				FormSettingsSender.is0AIk7hTRWrLKAbmp2(saveFileDialog, false);
				goto IL_5F;
				IL_4F:
				goto IL_A6;
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0002AA84 File Offset: 0x00028E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void svToZrl0sY(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			for (;;)
			{
				FolderBrowserDialog folderBrowserDialog;
				switch (num)
				{
				case 1:
				case 2:
					if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
					{
						return;
					}
					break;
				case 4:
					folderBrowserDialog = new FolderBrowserDialog();
					num = 5;
					continue;
				case 5:
					folderBrowserDialog.ShowNewFolderButton = false;
					num = (FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 0 : 1);
					continue;
				case 6:
					return;
				}
				IL_94:
				this.BTfo6OSA71.Text = folderBrowserDialog.SelectedPath;
				num = 6;
				continue;
				goto IL_94;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0002AB40 File Offset: 0x00028F40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void mXoo3SPq1l(object \u0020, EventArgs \u0020)
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
				case 1:
				case 4:
					this.VP8oFnf2vS.Enabled = FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.kueotpDpaa);
					break;
				case 3:
					this.d5YoxAPEep.Enabled = this.JxmoDovFMO.Checked;
					num = (FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 0 : 4);
					continue;
				case 5:
					return;
				}
				IL_44:
				FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.TW4oHbeOyt, this.SYeoUtOBCc.Checked);
				num = 5;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				continue;
				goto IL_44;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0002AC10 File Offset: 0x00029010
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IiWoIBcc82(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.RJXoB6SooV.Enabled = (this.QZlo5bclsp.Enabled = (this.OxNolWaRba.Enabled = (this.sQVo4WFoAX.Checked && this.fwro9xuoth.Checked)));
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0002AC74 File Offset: 0x00029074
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bX3ogd1N9k(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			object s82usbI3X = this.S82usbI3X8;
			Control uc8uXeCNrg = this.Uc8uXeCNrg;
			Control control = this.zgCueCPULg;
			Control control2 = this.pBYuomHju0;
			Control control3 = this.x2auCffKij;
			Control xglundBwE = this.XGLundBwE3;
			Control wxuu8KMxpD = this.WXUu8KMxpD;
			Control control4 = this.zeeuq1NopM;
			Control iaLuZm7bBZ = this.IaLuZm7bBZ;
			Control control5 = this.fl1uIcLa7X;
			Control control6 = this.erfozvOXLo;
			bool enabled;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.CsSoyQ0k8a, enabled = FormSettingsSender.XVioqh71ooDBkWr0LGp(this.RxPugvS30O));
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(s82usbI3X, uc8uXeCNrg.Enabled = (control.Enabled = (control2.Enabled = (control3.Enabled = (xglundBwE.Enabled = (wxuu8KMxpD.Enabled = (control4.Enabled = (iaLuZm7bBZ.Enabled = (control5.Enabled = (control6.Enabled = enabled))))))))));
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0002AD50 File Offset: 0x00029150
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HicoeCpObo(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormSettingsSender.woBBQHlNPqnbmgFGUYy();
			int num = FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 5 : 1;
			for (;;)
			{
				SaveFileDialog saveFileDialog;
				switch (num)
				{
				case 0:
				case 1:
					saveFileDialog = new SaveFileDialog();
					num = 4;
					continue;
				case 2:
					if (FormSettingsSender.l4kdt37YKmJrm2FE3LZ(saveFileDialog) == DialogResult.OK)
					{
						FormSettingsSender.PcqABe7mBEg9uMisXOp(this.zgCueCPULg, Path.GetFileName(saveFileDialog.FileName));
						num = 7;
						continue;
					}
					return;
				case 4:
					saveFileDialog.Filter = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39358);
					num = 6;
					if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						continue;
					}
					break;
				case 6:
					goto IL_6C;
				case 7:
					return;
				}
				IL_48:
				saveFileDialog.CheckPathExists = false;
				saveFileDialog.FileName = FormSettingsSender.YuHymu7TprrBvBWFHO9(this.zgCueCPULg);
				num = 2;
				if (!true)
				{
					goto IL_6C;
				}
				continue;
				IL_AA:
				goto IL_48;
				IL_6C:
				FormSettingsSender.frr6387xojQ0sUepqE3(saveFileDialog, false);
				goto IL_AA;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0002AE54 File Offset: 0x00029254
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void X1VonWpgtg(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			FormSettingsSender.woBBQHlNPqnbmgFGUYy();
			int num;
			if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
			{
				num = 1;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_2E;
				}
			}
			else
			{
				num = 4;
				if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					goto IL_94;
				}
			}
			FolderBrowserDialog folderBrowserDialog;
			for (;;)
			{
				IL_4C:
				switch (num)
				{
				case 0:
				case 1:
					folderBrowserDialog = new FolderBrowserDialog();
					num = 3;
					break;
				case 2:
					goto IL_7E;
				case 3:
					goto IL_77;
				case 4:
					goto IL_2E;
				case 5:
					goto IL_94;
				case 6:
					return;
				default:
					num = 5;
					break;
				}
			}
			IL_77:
			FormSettingsSender.qVDpSE7aBBxSjsf5x9K(folderBrowserDialog, false);
			IL_7E:
			IL_2E:
			if (FormSettingsSender.l4kdt37YKmJrm2FE3LZ(folderBrowserDialog) != DialogResult.OK)
			{
				return;
			}
			IL_94:
			this.fl1uIcLa7X.Text = folderBrowserDialog.SelectedPath;
			num = 6;
			goto IL_4C;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0002AF20 File Offset: 0x00029320
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void tGLoJ0s7GE(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			object obj2 = this.x2auCffKij;
			bool flag;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.XGLundBwE3, flag = (this.WXUu8KMxpD.Enabled = (this.zeeuq1NopM.Checked && this.RxPugvS30O.Checked)));
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(obj2, flag);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0002AF84 File Offset: 0x00029384
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Vqqo0Yl9Ly(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 2 : 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 3:
					FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.gO0oYQ1dHf, this.mtIob811iE.Checked);
					goto IL_3A;
				case 1:
					goto IL_3A;
				case 2:
					goto IL_6C;
				case 4:
					break;
				case 5:
					return;
				default:
					num = 4;
					continue;
				}
				IL_4A:
				this.EUVortqIPp.Enabled = this.HQIoG7WF2l.Checked;
				num = 5;
				if (true)
				{
					continue;
				}
				IL_6C:
				FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.r6JoiXY9j1, FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.ix2oj2wknM));
				goto IL_4A;
				IL_3A:
				goto IL_6C;
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0002B04C File Offset: 0x0002944C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void X3aoo5x97P(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			Control control = this.v73u14AJPD;
			Control control2 = this.duquaoP6wR;
			Control control3 = this.imYuv0vN9Y;
			object obj2 = this.xqFuAPgtM2;
			object obj3 = this.dshursBUcC;
			Control kunuypHcpG = this.KUNuypHcpG;
			object obj4 = this.w5TuFUb2jt;
			bool @checked;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.caWufkkLNs, @checked = this.w86uLOZ6Cn.Checked);
			bool enabled;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(obj4, enabled = @checked);
			bool flag;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(obj3, flag = (kunuypHcpG.Enabled = enabled));
			bool enabled2;
			FormSettingsSender.cmAiYe70EqkV1DNjDVm(obj2, enabled2 = flag);
			control.Enabled = (control2.Enabled = (control3.Enabled = enabled2));
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0002B0E8 File Offset: 0x000294E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void vS4ouQqjyU(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 1;
			if (false)
			{
				goto IL_1A;
			}
			SaveFileDialog saveFileDialog;
			for (;;)
			{
				IL_B3:
				switch (num)
				{
				case 0:
				case 3:
					goto IL_1A;
				case 1:
					saveFileDialog = new SaveFileDialog();
					num = 6;
					continue;
				case 2:
					goto IL_5C;
				case 4:
					goto IL_32;
				case 5:
					FormSettingsSender.frr6387xojQ0sUepqE3(saveFileDialog, false);
					saveFileDialog.OverwritePrompt = false;
					break;
				case 6:
					saveFileDialog.Filter = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39408);
					num = 5;
					continue;
				case 7:
					return;
				}
				FormSettingsSender.woBBQHlNPqnbmgFGUYy();
				num = (FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 2 : 0);
			}
			IL_1A:
			FormSettingsSender.is0AIk7hTRWrLKAbmp2(saveFileDialog, false);
			FormSettingsSender.QNfjPw7opZGMPwc1DQD(saveFileDialog, this.v73u14AJPD.Text);
			IL_32:
			IL_5C:
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.v73u14AJPD.Text = FormSettingsSender.M46IyA7q2q8oH7Dqw9f(saveFileDialog);
				num = 7;
				goto IL_B3;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0002B1E8 File Offset: 0x000295E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IJPoMJCYAJ(object \u0020, EventArgs \u0020)
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
					FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.m0uudPYZpX, FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.g4wuDPMX6y));
					num = (FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 4 : 3);
					continue;
				case 1:
				case 3:
					this.k71uT9NO8T.Enabled = FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.LADutCXOdb);
					break;
				case 5:
					return;
				}
				IL_99:
				FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.ehYu6sgrZp, FormSettingsSender.WRdtFB7QCbjdRjEXiK2(this.x2juUJENsT));
				num = 5;
				continue;
				goto IL_99;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0002B374 File Offset: 0x00029774
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void E8go8bIHq3()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 47;
			for (;;)
			{
				ComponentResourceManager componentResourceManager;
				switch (num)
				{
				case 0:
					goto IL_CA;
				case 1:
					goto IL_2EE3;
				case 2:
					this.pgWoP9MDb0 = new Label();
					this.CP5oww8CcY = new Label();
					this.QZlo5bclsp = new MaskedTextBox();
					this.fwro9xuoth = new CheckBox();
					this.TZ3o2TsyGe = new TabControl();
					this.QpVoAeQsKr = new TabPage();
					this.CsSoyQ0k8a = new GroupBox();
					this.EUVortqIPp = new NumericUpDown();
					num = 193;
					continue;
				case 3:
					this.TZ3o2TsyGe.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					num = 142;
					continue;
				case 4:
					this.mtIob811iE.Checked = true;
					num = 161;
					if (false)
					{
						goto IL_2B88;
					}
					continue;
				case 5:
					goto IL_4630;
				case 6:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.MRFoaqvscI, new Point(90, 118));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.MRFoaqvscI, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39832));
					this.MRFoaqvscI.Size = new Size(389, 20);
					this.MRFoaqvscI.TabIndex = 5;
					this.MRFoaqvscI.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39868);
					num = 172;
					continue;
				case 7:
					this.MQBoO75tUr.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(31830);
					this.MQBoO75tUr.UseVisualStyleBackColor = true;
					this.MQBoO75tUr.Click += this.V9C0GYvNkD;
					num = 236;
					continue;
				case 8:
					goto IL_19EC;
				case 9:
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.v73u14AJPD, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.v73u14AJPD.Location = new Point(90, 29);
					num = 267;
					if (false)
					{
						goto IL_14E2;
					}
					continue;
				case 10:
					goto IL_24DF;
				case 11:
					this.MRFoaqvscI.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					num = 6;
					continue;
				case 12:
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.fl1uIcLa7X, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39496));
					this.RxPugvS30O.AutoSize = true;
					num = 244;
					continue;
				case 13:
					goto IL_1571;
				case 14:
					this.xWyoTABNxr.TabIndex = 23;
					this.xWyoTABNxr.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40838);
					FormSettingsSender.iueI1O7zei1FfvvvnTN(this.xWyoTABNxr, true);
					this.xWyoTABNxr.Click += this.svToZrl0sY;
					num = 279;
					continue;
				case 15:
					this.UYLuVoQJQT = new Label();
					this.Rg2uKLCjMO = new TextBox();
					this.YLFuQV45Zb = new Label();
					this.pLtuSNtbly = new TextBox();
					this.imYuv0vN9Y = new GroupBox();
					this.U7mu4Bv5u2 = new Label();
					this.tguuBT2lFE = new TextBox();
					this.HMGulNhMFS = new Label();
					this.Tx3uPcd9UZ = new TextBox();
					this.WIGuw1gKA0 = new Label();
					num = 44;
					continue;
				case 16:
					this.U7mu4Bv5u2.AutoSize = true;
					num = 45;
					if (false)
					{
						goto IL_19C6;
					}
					continue;
				case 17:
					this.QpVoAeQsKr.Controls.Add(this.zeeuq1NopM);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.QpVoAeQsKr.Controls, this.hASumvj8Xo);
					this.QpVoAeQsKr.Controls.Add(this.S82usbI3X8);
					this.QpVoAeQsKr.Location = new Point(4, 22);
					num = 69;
					continue;
				case 18:
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.So1uJZT4cL, cDhluYseFOthxgEIXpc.nKHKpgTSVU(31256));
					num = 146;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_6CD;
					}
					continue;
				case 19:
					this.tEnohFlmXB = new Label();
					num = 68;
					continue;
				case 20:
					goto IL_EAB;
				case 21:
					this.RxPugvS30O.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40980);
					this.RxPugvS30O.Size = new Size(186, 17);
					this.RxPugvS30O.TabIndex = 39;
					num = 162;
					if (false)
					{
						goto IL_2DF2;
					}
					continue;
				case 22:
					goto IL_1297;
				case 23:
					goto IL_4064;
				case 24:
					this.oUruc1YLci.TabIndex = 2;
					this.oUruc1YLci.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(40696);
					FormSettingsSender.G4Iig7Q2aBo1eTwJVHC(this.OimupDkga9, Cursors.Default);
					this.OimupDkga9.CustomFormat = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30158);
					num = 259;
					continue;
				case 25:
					base.PerformLayout();
					num = 324;
					continue;
				case 26:
					FormSettingsSender.kPPNYg7DiIkGcumpR1Q(this.LirovRKmrk, '*');
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.LirovRKmrk, new Size(389, 20));
					this.LirovRKmrk.TabIndex = 10;
					num = 299;
					continue;
				case 27:
					this.LADutCXOdb = new RadioButton();
					this.g4wuDPMX6y = new RadioButton();
					this.oUruc1YLci = new Label();
					this.OimupDkga9 = new DateTimePicker();
					this.T7FuWmRc4m = new Label();
					this.Nc1uHCgyoZ = new Label();
					this.w5TuFUb2jt = new TextBox();
					this.KTTuxidVAT = new Label();
					num = 229;
					continue;
				case 28:
					FormSettingsSender.a5dFbu7pKVZp0o5xCuJ(this.MQBoO75tUr, DialogResult.OK);
					this.MQBoO75tUr.Location = new Point(12, 556);
					this.MQBoO75tUr.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39906);
					this.MQBoO75tUr.Size = new Size(75, 23);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.MQBoO75tUr, 8);
					num = 7;
					continue;
				case 29:
					this.w86uLOZ6Cn.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(43280);
					this.w86uLOZ6Cn.Size = new Size(124, 17);
					this.w86uLOZ6Cn.TabIndex = 0;
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.w86uLOZ6Cn, FormSettingsSender.p91n9ElsT2I75NJjme3(43318));
					num = 104;
					continue;
				case 30:
					goto IL_2087;
				case 31:
					this.LrfujmRk7x.AutoSize = true;
					goto IL_B34;
				case 32:
					goto IL_2DF2;
				case 33:
					this.dshursBUcC.RowHeadersWidth = 15;
					this.dshursBUcC.Size = new Size(469, 80);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.dshursBUcC, 29);
					this.v51uidnQU1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					FormSettingsSender.iROiZuQl2M3vAUfGCGr(this.v51uidnQU1, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42430));
					this.v51uidnQU1.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42444);
					this.RaHuYYIwGE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = 137;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_3894;
					}
					continue;
				case 34:
					this.zeeuq1NopM.UseVisualStyleBackColor = true;
					this.zeeuq1NopM.CheckedChanged += this.tGLoJ0s7GE;
					this.hASumvj8Xo.AutoSize = true;
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.hASumvj8Xo, new Point(9, 142));
					this.hASumvj8Xo.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41280);
					num = 218;
					continue;
				case 35:
					this.oUruc1YLci.AutoSize = true;
					num = 257;
					continue;
				case 36:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.So1uJZT4cL, new Point(9, 37));
					num = 18;
					continue;
				case 37:
					goto IL_1407;
				case 38:
					this.seDoXeDyD6.TabIndex = 0;
					this.seDoXeDyD6.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(39496);
					this.TTQoqFuIwn.AutoSize = true;
					num = 168;
					if (!true)
					{
						goto IL_1297;
					}
					continue;
				case 39:
					goto IL_526;
				case 40:
					FormSettingsSender.VB1eni7BYS0IAa2W7Y3(this.QpVoAeQsKr);
					num = 83;
					if (false)
					{
						goto IL_322;
					}
					continue;
				case 41:
					goto IL_4939;
				case 42:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.erfozvOXLo, new Size(28, 23));
					this.erfozvOXLo.TabIndex = 43;
					num = 298;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 43:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.x2juUJENsT, new Point(125, 91));
					num = 59;
					continue;
				case 44:
					this.n2Hu5bSws2 = new NumericUpDown();
					this.MT3u9a8ZKO = new Label();
					this.UXYu2ec0FP = new TextBox();
					num = 50;
					continue;
				case 45:
					goto IL_46C5;
				case 46:
					goto IL_24C8;
				case 47:
					componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(33554496)));
					num = 243;
					continue;
				case 48:
					this.zeeuq1NopM = new CheckBox();
					this.hASumvj8Xo = new Label();
					this.S82usbI3X8 = new MaskedTextBox();
					this.rxVoVarjxq = new TabPage();
					this.ETVodSvqVE = new GroupBox();
					num = 106;
					continue;
				case 49:
					FormSettingsSender.kdX8WX7U81tGvrkHnKB(this.RxPugvS30O, CheckState.Checked);
					num = 110;
					continue;
				case 50:
					this.duquaoP6wR = new Button();
					num = 260;
					continue;
				case 51:
					this.k71uT9NO8T.Location = new Point(192, 65);
					num = 312;
					continue;
				case 52:
					goto IL_A9C;
				case 53:
					this.XqioNGM8Cw.Location = new Point(10, 51);
					this.XqioNGM8Cw.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31546);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.XqioNGM8Cw, new Size(104, 13));
					this.XqioNGM8Cw.TabIndex = 2;
					this.XqioNGM8Cw.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40696);
					this.jVhoE67YN1.Cursor = FormSettingsSender.T6gpUUQW1NXI9SHNJd0();
					num = 250;
					continue;
				case 54:
					goto IL_14E2;
				case 55:
					this.gxhuOAdBsA = new Label();
					this.w86uLOZ6Cn = new CheckBox();
					this.GFwoKrhy3e = new Label();
					num = 131;
					continue;
				case 56:
					FormSettingsSender.VB1eni7BYS0IAa2W7Y3(this.TZ3o2TsyGe);
					num = 40;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 57:
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.kueotpDpaa, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40648));
					num = 307;
					if (false)
					{
						goto IL_16DE;
					}
					continue;
				case 58:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.BTfo6OSA71, new Size(358, 20));
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.BTfo6OSA71, 18);
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.BTfo6OSA71, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39496));
					num = 169;
					continue;
				case 59:
					this.x2juUJENsT.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42024);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.x2juUJENsT, new Size(63, 17));
					num = 256;
					continue;
				case 60:
					this.XGLundBwE3.TabIndex = 38;
					this.XGLundBwE3.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39992);
					num = 189;
					continue;
				case 61:
					((ISupportInitialize)this.d5YoxAPEep).BeginInit();
					this.u4Du7XmSxq.SuspendLayout();
					this.caWufkkLNs.SuspendLayout();
					((ISupportInitialize)this.ehYu6sgrZp).BeginInit();
					FormSettingsSender.FlfPRm7yRkFgaIbtA38(this.k71uT9NO8T);
					num = 20;
					continue;
				case 62:
					goto IL_1559;
				case 63:
				case 265:
					goto IL_BC6;
				case 64:
					goto IL_6CD;
				case 65:
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.KTTuxidVAT, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42312));
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.KTTuxidVAT, new Size(94, 13));
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.KTTuxidVAT, 31);
					num = 158;
					continue;
				case 66:
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.ETVodSvqVE.Controls, this.VP8oFnf2vS);
					this.ETVodSvqVE.Controls.Add(this.d5YoxAPEep);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.ETVodSvqVE.Controls, this.SYeoUtOBCc);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.ETVodSvqVE), this.kueotpDpaa);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.ETVodSvqVE), this.JxmoDovFMO);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.ETVodSvqVE.Controls, this.Dp4ocPU9xO);
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.ETVodSvqVE).Add(this.Yu2opE9oes);
					this.ETVodSvqVE.Controls.Add(this.eQkoWFEuy3);
					this.ETVodSvqVE.Location = new Point(10, 222);
					this.ETVodSvqVE.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41378);
					num = 100;
					continue;
				case 67:
					this.rxVoVarjxq.Size = new Size(490, 485);
					FormSettingsSender.i3RULhQr08BQgWwy7eK(this.rxVoVarjxq, 1);
					this.rxVoVarjxq.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(41356);
					this.rxVoVarjxq.UseVisualStyleBackColor = true;
					this.ETVodSvqVE.Controls.Add(this.TW4oHbeOyt);
					num = 66;
					continue;
				case 68:
					this.erfozvOXLo = new Button();
					this.IaLuZm7bBZ = new Button();
					this.tbZu3Icliq = new Label();
					num = 228;
					continue;
				case 69:
					this.QpVoAeQsKr.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40390);
					this.QpVoAeQsKr.Padding = new Padding(3);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.QpVoAeQsKr, new Size(490, 485));
					num = 82;
					if (false)
					{
						goto IL_49C5;
					}
					continue;
				case 70:
					this.OimupDkga9.Location = new Point(80, 19);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.OimupDkga9, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42166));
					this.OimupDkga9.Size = new Size(200, 20);
					this.OimupDkga9.TabIndex = 1;
					this.T7FuWmRc4m.AutoSize = true;
					num = 116;
					continue;
				case 71:
					goto IL_3E55;
				case 72:
					this.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(33216);
					FormSettingsSender.XJ6p40Qk4MsHGK6TMp8(this, new FormClosingEventHandler(this.We10YR1ukG));
					num = 23;
					continue;
				case 73:
					goto IL_19C6;
				case 74:
					goto IL_408E;
				case 75:
					goto IL_1836;
				case 76:
					goto IL_1D50;
				case 77:
					this.pBYuomHju0.TabIndex = 27;
					this.pBYuomHju0.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39648);
					num = 62;
					continue;
				case 78:
					goto IL_42C6;
				case 79:
					FormSettingsSender.fFxyHRQGPxlsfvDSPrM(this, this.xFqoLJhJ3c);
					FormSettingsSender.yEOaggQ4Wyf0M0MIsGW(this, new Size(496, 587));
					num = 184;
					continue;
				case 80:
					this.mAiuMPamrf.AutoSize = true;
					this.mAiuMPamrf.Location = new Point(9, 90);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.mAiuMPamrf, cDhluYseFOthxgEIXpc.nKHKpgTSVU(41120));
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.mAiuMPamrf, new Size(54, 13));
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.mAiuMPamrf, 28);
					this.mAiuMPamrf.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39790);
					this.WXUu8KMxpD.Enabled = false;
					this.WXUu8KMxpD.Location = new Point(134, 191);
					num = 303;
					continue;
				case 81:
					this.eQkoWFEuy3.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30948);
					num = 175;
					continue;
				case 82:
					goto IL_16A7;
				case 83:
					this.CsSoyQ0k8a.SuspendLayout();
					((ISupportInitialize)this.EUVortqIPp).BeginInit();
					num = 85;
					continue;
				case 84:
					this.xqFuAPgtM2.PerformLayout();
					FormSettingsSender.veqap3QFf2rp3lwc2VY(this.imYuv0vN9Y, false);
					this.imYuv0vN9Y.PerformLayout();
					((ISupportInitialize)this.n2Hu5bSws2).EndInit();
					this.DoEuGfHpCZ.ResumeLayout(false);
					num = 261;
					continue;
				case 85:
					((ISupportInitialize)this.r6JoiXY9j1).BeginInit();
					num = 206;
					continue;
				case 86:
					this.JxmoDovFMO.UseVisualStyleBackColor = true;
					this.JxmoDovFMO.CheckedChanged += this.mXoo3SPq1l;
					this.Dp4ocPU9xO.AutoSize = true;
					num = 258;
					if (false)
					{
						goto IL_F7D;
					}
					continue;
				case 87:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.MT3u9a8ZKO, 1);
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.MT3u9a8ZKO, FormSettingsSender.p91n9ElsT2I75NJjme3(43106));
					num = 209;
					continue;
				case 88:
					goto IL_298D;
				case 89:
					this.MT3u9a8ZKO.AutoSize = true;
					num = 145;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_4EB7;
					}
					continue;
				case 90:
					this.xqFuAPgtM2.Size = new Size(469, 74);
					this.xqFuAPgtM2.TabIndex = 27;
					num = 107;
					if (false)
					{
						goto IL_1D50;
					}
					continue;
				case 91:
					goto IL_C2F;
				case 92:
					this.LirovRKmrk.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(39958);
					num = 26;
					continue;
				case 93:
					goto IL_4107;
				case 94:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.W85oQ1v70T, new Size(358, 20));
					this.W85oQ1v70T.TabIndex = 20;
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.W85oQ1v70T, FormSettingsSender.p91n9ElsT2I75NJjme3(43418));
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.XdsoSFJILo, AnchorStyles.Top | AnchorStyles.Right);
					this.XdsoSFJILo.Location = new Point(456, 10);
					num = 32;
					continue;
				case 95:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.cNGo7HW9hU, new Point(7, 121));
					num = 196;
					continue;
				case 96:
					((ISupportInitialize)this.EUVortqIPp).EndInit();
					((ISupportInitialize)this.r6JoiXY9j1).EndInit();
					num = 306;
					continue;
				case 97:
					this.UYLuVoQJQT.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(42498);
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.Rg2uKLCjMO, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.Rg2uKLCjMO.Location = new Point(80, 45);
					num = 149;
					continue;
				case 98:
					FormSettingsSender.UVUaldQ7OAJRFLQFyA1(this.RaHuYYIwGE, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42508));
					num = 194;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_24C8;
					}
					continue;
				case 99:
					goto IL_3FD5;
				case 100:
					this.ETVodSvqVE.Size = new Size(585, 151);
					goto IL_4360;
				case 101:
					this.xqFuAPgtM2.ResumeLayout(false);
					num = 84;
					continue;
				case 102:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.cNGo7HW9hU, 4);
					this.cNGo7HW9hU.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39810);
					num = 11;
					continue;
				case 103:
					this.seDoXeDyD6.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(39458);
					this.seDoXeDyD6.Size = new Size(358, 20);
					num = 38;
					continue;
				case 104:
					this.w86uLOZ6Cn.UseVisualStyleBackColor = true;
					this.w86uLOZ6Cn.CheckedChanged += this.X3aoo5x97P;
					num = 208;
					continue;
				case 105:
					this.QpVoAeQsKr.Controls.Add(this.mAiuMPamrf);
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr).Add(this.WXUu8KMxpD);
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr).Add(this.lJVuRnxP7w);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.QpVoAeQsKr.Controls, this.x2auCffKij);
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr).Add(this.Uc8uXeCNrg);
					num = 17;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_2370;
					}
					continue;
				case 106:
					this.TW4oHbeOyt = new NumericUpDown();
					num = 157;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_4630;
					}
					continue;
				case 107:
					this.xqFuAPgtM2.TabStop = false;
					this.xqFuAPgtM2.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42630);
					this.UYLuVoQJQT.AutoSize = true;
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.UYLuVoQJQT, new Point(6, 48));
					this.UYLuVoQJQT.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42656);
					this.UYLuVoQJQT.Size = new Size(29, 13);
					num = 276;
					continue;
				case 108:
					this.EUVortqIPp.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40500);
					num = 282;
					continue;
				case 109:
					this.duquaoP6wR.Size = new Size(28, 23);
					num = 30;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_2E89;
					}
					continue;
				case 110:
					this.RxPugvS30O.Location = new Point(12, 11);
					num = 21;
					continue;
				case 111:
					this.fwro9xuoth.UseVisualStyleBackColor = true;
					this.fwro9xuoth.CheckedChanged += this.lr60hBiNWK;
					num = 3;
					continue;
				case 112:
					FormSettingsSender.VyJpbZQjUSkwjq60Upw(this.XdsoSFJILo, new EventHandler(this.Ek20Egp2bn));
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.DoEuGfHpCZ).Add(this.LrfujmRk7x);
					num = 22;
					continue;
				case 113:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.lJVuRnxP7w, new Point(9, 116));
					num = 215;
					continue;
				case 114:
					goto IL_373C;
				case 115:
					FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.WIGuw1gKA0, true);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.WIGuw1gKA0, new Point(346, 22));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.WIGuw1gKA0, FormSettingsSender.p91n9ElsT2I75NJjme3(43006));
					num = 254;
					continue;
				case 116:
					this.T7FuWmRc4m.Location = new Point(6, 25);
					num = 219;
					if (!true)
					{
						goto IL_D02;
					}
					continue;
				case 117:
					this.QpVoAeQsKr.ResumeLayout(false);
					FormSettingsSender.aP7jyVQdE12x46GEH3o(this.QpVoAeQsKr);
					this.CsSoyQ0k8a.ResumeLayout(false);
					FormSettingsSender.aP7jyVQdE12x46GEH3o(this.CsSoyQ0k8a);
					num = 96;
					continue;
				case 118:
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.caWufkkLNs).Add(this.oUruc1YLci);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.caWufkkLNs), this.OimupDkga9);
					num = 73;
					continue;
				case 119:
					this.fwro9xuoth.Checked = true;
					FormSettingsSender.kdX8WX7U81tGvrkHnKB(this.fwro9xuoth, CheckState.Checked);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.fwro9xuoth, new Point(10, 16));
					this.fwro9xuoth.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40304);
					num = 186;
					continue;
				case 120:
					this.Yu2opE9oes.CustomFormat = FormSettingsSender.p91n9ElsT2I75NJjme3(30158);
					this.Yu2opE9oes.Format = DateTimePickerFormat.Custom;
					this.Yu2opE9oes.Location = new Point(80, 19);
					num = 182;
					if (false)
					{
						goto IL_298D;
					}
					continue;
				case 121:
					this.eQkoWFEuy3.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40778);
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.xWyoTABNxr, AnchorStyles.Top | AnchorStyles.Right);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.xWyoTABNxr, new Point(451, 63));
					this.xWyoTABNxr.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41636);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.xWyoTABNxr, new Size(28, 23));
					num = 14;
					continue;
				case 122:
					this.TZ3o2TsyGe.TabIndex = 18;
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr).Add(this.CsSoyQ0k8a);
					num = 242;
					continue;
				case 123:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.w86uLOZ6Cn, new Point(10, 6));
					num = 29;
					continue;
				case 124:
					goto IL_2800;
				case 125:
					goto IL_F7D;
				case 126:
					goto IL_448;
				case 127:
					goto IL_28B0;
				case 128:
					goto IL_77C;
				case 129:
					goto IL_2131;
				case 130:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.tbZu3Icliq, new Size(78, 31));
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.tbZu3Icliq, 41);
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.tbZu3Icliq, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40894));
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.fl1uIcLa7X, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.fl1uIcLa7X, new Point(92, 60));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.fl1uIcLa7X, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40946));
					this.fl1uIcLa7X.Size = new Size(356, 20);
					this.fl1uIcLa7X.TabIndex = 40;
					num = 12;
					continue;
				case 131:
					this.W85oQ1v70T = new TextBox();
					num = 154;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_2860;
					}
					continue;
				case 132:
					this.x2auCffKij.Enabled = false;
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.x2auCffKij, new Point(156, 165));
					this.x2auCffKij.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41192);
					this.x2auCffKij.Size = new Size(323, 20);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.x2auCffKij, 34);
					num = 159;
					continue;
				case 133:
					this.x2juUJENsT.CheckedChanged += this.IJPoMJCYAJ;
					num = 93;
					if (!true)
					{
						goto IL_A9C;
					}
					continue;
				case 134:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.Uc8uXeCNrg, 30);
					this.Uc8uXeCNrg.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(39868);
					this.zeeuq1NopM.AutoSize = true;
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.zeeuq1NopM, new Point(12, 167));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.zeeuq1NopM, FormSettingsSender.p91n9ElsT2I75NJjme3(41252));
					this.zeeuq1NopM.Size = new Size(138, 17);
					num = 188;
					continue;
				case 135:
					break;
				case 136:
					goto IL_3894;
				case 137:
					this.RaHuYYIwGE.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42498);
					num = 98;
					if (!true)
					{
						goto IL_3F2B;
					}
					continue;
				case 138:
					this.HMGulNhMFS.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42950);
					this.Tx3uPcd9UZ.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.Tx3uPcd9UZ, new Point(80, 45));
					this.Tx3uPcd9UZ.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42964);
					num = 91;
					continue;
				case 139:
					this.dshursBUcC.Columns.AddRange(new DataGridViewColumn[]
					{
						this.v51uidnQU1,
						this.RaHuYYIwGE
					});
					this.dshursBUcC.Location = new Point(10, 227);
					num = 277;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_1407;
					}
					continue;
				case 140:
					goto IL_17AA;
				case 141:
					this.wiPofGeZmM.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(31010);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.wiPofGeZmM, new Size(78, 31));
					this.wiPofGeZmM.TabIndex = 19;
					this.wiPofGeZmM.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40894);
					this.BTfo6OSA71.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.BTfo6OSA71.Location = new Point(90, 65);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.BTfo6OSA71, cDhluYseFOthxgEIXpc.nKHKpgTSVU(41728));
					num = 58;
					continue;
				case 142:
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.TZ3o2TsyGe), this.QpVoAeQsKr);
					num = 305;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 143:
					this.Yu2opE9oes.Size = new Size(200, 20);
					num = 251;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 144:
					goto IL_3491;
				case 145:
					goto IL_4FB5;
				case 146:
					this.So1uJZT4cL.Size = new Size(64, 13);
					num = 289;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_12D;
					}
					continue;
				case 147:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.CYSuurvDt0, 36);
					this.CYSuurvDt0.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40192);
					num = 80;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_834;
					}
					continue;
				case 148:
					this.n2Hu5bSws2.TabIndex = 2;
					num = 89;
					continue;
				case 149:
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.Rg2uKLCjMO, FormSettingsSender.p91n9ElsT2I75NJjme3(42674));
					this.Rg2uKLCjMO.Size = new Size(383, 20);
					this.Rg2uKLCjMO.TabIndex = 3;
					num = 280;
					continue;
				case 150:
					this.g4wuDPMX6y.Size = new Size(53, 17);
					num = 278;
					continue;
				case 151:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.xFqoLJhJ3c, new Point(409, 556));
					this.xFqoLJhJ3c.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(39920);
					num = 163;
					if (!true)
					{
						goto IL_2131;
					}
					continue;
				case 152:
					goto IL_22A7;
				case 153:
					goto IL_2E89;
				case 154:
					goto IL_D02;
				case 155:
					goto IL_2370;
				case 156:
					goto IL_4360;
				case 157:
					this.VP8oFnf2vS = new NumericUpDown();
					this.d5YoxAPEep = new NumericUpDown();
					num = 268;
					continue;
				case 158:
					this.KTTuxidVAT.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42330);
					this.KUNuypHcpG.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.KUNuypHcpG, new Point(107, 313));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.KUNuypHcpG, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42362));
					num = 152;
					continue;
				case 159:
					this.x2auCffKij.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40116);
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.Uc8uXeCNrg, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.Uc8uXeCNrg, new Point(92, 113));
					this.Uc8uXeCNrg.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41220);
					num = 179;
					continue;
				case 160:
					this.nUDukruyZg.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(42574);
					this.xqFuAPgtM2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.xqFuAPgtM2.Controls, this.UYLuVoQJQT);
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.xqFuAPgtM2).Add(this.Rg2uKLCjMO);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.xqFuAPgtM2.Controls, this.YLFuQV45Zb);
					num = 283;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_1DEE;
					}
					continue;
				case 161:
					goto IL_250B;
				case 162:
					this.RxPugvS30O.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40330);
					FormSettingsSender.iueI1O7zei1FfvvvnTN(this.RxPugvS30O, true);
					num = 310;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_2CD8;
					}
					continue;
				case 163:
					this.xFqoLJhJ3c.Size = new Size(75, 23);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.xFqoLJhJ3c, 9);
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.xFqoLJhJ3c, FormSettingsSender.p91n9ElsT2I75NJjme3(39940));
					num = 317;
					continue;
				case 164:
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq).Add(this.seDoXeDyD6);
					num = 5;
					if (!true)
					{
						goto IL_2800;
					}
					continue;
				case 165:
					goto IL_5174;
				case 166:
					goto IL_2EBA;
				case 167:
					goto IL_5079;
				case 168:
					this.TTQoqFuIwn.Location = new Point(7, 42);
					this.TTQoqFuIwn.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(29034);
					num = 76;
					continue;
				case 169:
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.u4Du7XmSxq), this.caWufkkLNs);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.u4Du7XmSxq.Controls, this.Nc1uHCgyoZ);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.u4Du7XmSxq), this.w5TuFUb2jt);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.u4Du7XmSxq), this.KTTuxidVAT);
					this.u4Du7XmSxq.Controls.Add(this.KUNuypHcpG);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.u4Du7XmSxq.Controls, this.dshursBUcC);
					this.u4Du7XmSxq.Controls.Add(this.nUDukruyZg);
					this.u4Du7XmSxq.Controls.Add(this.xqFuAPgtM2);
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.u4Du7XmSxq).Add(this.imYuv0vN9Y);
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.u4Du7XmSxq).Add(this.duquaoP6wR);
					this.u4Du7XmSxq.Controls.Add(this.v73u14AJPD);
					num = 197;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_11A4;
					}
					continue;
				case 170:
					FormSettingsSender.aP7jyVQdE12x46GEH3o(this.caWufkkLNs);
					((ISupportInitialize)this.ehYu6sgrZp).EndInit();
					num = 240;
					continue;
				case 171:
					this.DoEuGfHpCZ.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(43544);
					this.DoEuGfHpCZ.Padding = new Padding(3);
					num = 124;
					continue;
				case 172:
					FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.O0No1JqLOd, true);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.O0No1JqLOd, new Point(7, 147));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.O0No1JqLOd, cDhluYseFOthxgEIXpc.nKHKpgTSVU(37892));
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.O0No1JqLOd, new Size(68, 13));
					this.O0No1JqLOd.TabIndex = 7;
					this.O0No1JqLOd.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39882);
					num = 28;
					continue;
				case 173:
					FormSettingsSender.RwtMRdQ18rfAQcoTY13(this.DoEuGfHpCZ, true);
					num = 31;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_16A7;
					}
					continue;
				case 174:
					goto IL_322;
				case 175:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.eQkoWFEuy3, new Size(55, 13));
					this.eQkoWFEuy3.TabIndex = 0;
					num = 121;
					continue;
				case 176:
					goto IL_2CD8;
				case 177:
					goto IL_5153;
				case 178:
					this.rxVoVarjxq.Location = new Point(4, 22);
					this.rxVoVarjxq.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41328);
					this.rxVoVarjxq.Padding = new Padding(3);
					num = 67;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 179:
					this.Uc8uXeCNrg.Size = new Size(387, 20);
					num = 134;
					continue;
				case 180:
					goto IL_3B8B;
				case 181:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.hASumvj8Xo, 31);
					this.hASumvj8Xo.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39882);
					this.S82usbI3X8.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					num = 293;
					continue;
				case 182:
					this.Yu2opE9oes.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41604);
					num = 143;
					continue;
				case 183:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.YLFuQV45Zb, new Size(38, 13));
					this.YLFuQV45Zb.TabIndex = 2;
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.YLFuQV45Zb, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42430));
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.pLtuSNtbly, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					num = 323;
					continue;
				case 184:
					base.Controls.Add(this.XdsoSFJILo);
					FormSettingsSender.FOqQ1fQtroQiwvONbQI(this).Add(this.W85oQ1v70T);
					FormSettingsSender.FOqQ1fQtroQiwvONbQI(this).Add(this.GFwoKrhy3e);
					base.Controls.Add(this.TZ3o2TsyGe);
					num = 316;
					continue;
				case 185:
					this.XGLundBwE3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.XGLundBwE3, false);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.XGLundBwE3, new Point(330, 191));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.XGLundBwE3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(41036));
					num = 273;
					continue;
				case 186:
					this.fwro9xuoth.Size = new Size(186, 17);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.fwro9xuoth, 17);
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.fwro9xuoth, FormSettingsSender.p91n9ElsT2I75NJjme3(40330));
					num = 111;
					if (false)
					{
						goto IL_4107;
					}
					continue;
				case 187:
					goto IL_2A52;
				case 188:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.zeeuq1NopM, 33);
					this.zeeuq1NopM.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40042);
					num = 34;
					continue;
				case 189:
					goto IL_416A;
				case 190:
					FormSettingsSender.i3RULhQr08BQgWwy7eK(this.u4Du7XmSxq, 2);
					this.u4Du7XmSxq.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41806);
					this.u4Du7XmSxq.UseVisualStyleBackColor = true;
					this.caWufkkLNs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
					this.caWufkkLNs.Controls.Add(this.ehYu6sgrZp);
					num = 8;
					continue;
				case 191:
					this.XdsoSFJILo.Size = new Size(28, 23);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.XdsoSFJILo, 21);
					num = 212;
					continue;
				case 192:
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.tEnohFlmXB, FormSettingsSender.p91n9ElsT2I75NJjme3(40778));
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.erfozvOXLo, AnchorStyles.Top | AnchorStyles.Right);
					num = 309;
					if (false)
					{
						goto IL_5153;
					}
					continue;
				case 193:
					this.r6JoiXY9j1 = new NumericUpDown();
					this.gO0oYQ1dHf = new NumericUpDown();
					this.HQIoG7WF2l = new RadioButton();
					this.ix2oj2wknM = new RadioButton();
					this.mtIob811iE = new RadioButton();
					this.XqioNGM8Cw = new Label();
					this.jVhoE67YN1 = new DateTimePicker();
					num = 19;
					if (!true)
					{
						goto IL_17AA;
					}
					continue;
				case 194:
					FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.nUDukruyZg, true);
					this.nUDukruyZg.Location = new Point(16, 211);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.nUDukruyZg, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42556));
					this.nUDukruyZg.Size = new Size(66, 13);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.nUDukruyZg, 28);
					num = 160;
					continue;
				case 195:
					goto IL_12D;
				case 196:
					this.cNGo7HW9hU.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(30306);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.cNGo7HW9hU, new Size(61, 13));
					num = 102;
					continue;
				case 197:
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.u4Du7XmSxq), this.gxhuOAdBsA);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.u4Du7XmSxq), this.w86uLOZ6Cn);
					num = 241;
					continue;
				case 198:
					this.VP8oFnf2vS.Location = new Point(80, 98);
					this.VP8oFnf2vS.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(41454);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.VP8oFnf2vS, new Size(120, 20));
					num = 13;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 199:
					goto IL_190D;
				case 200:
					this.YLFuQV45Zb.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(42718);
					num = 183;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 201:
					this.duquaoP6wR.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(40838);
					this.duquaoP6wR.UseVisualStyleBackColor = true;
					FormSettingsSender.VyJpbZQjUSkwjq60Upw(this.duquaoP6wR, new EventHandler(this.vS4ouQqjyU));
					num = 9;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_42C6;
					}
					continue;
				case 202:
					this.caWufkkLNs.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(40476);
					this.ehYu6sgrZp.Enabled = false;
					this.ehYu6sgrZp.Location = new Point(192, 88);
					num = 292;
					continue;
				case 203:
					this.Nc1uHCgyoZ.TabIndex = 33;
					this.Nc1uHCgyoZ.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42246);
					num = 99;
					if (!true)
					{
						goto IL_2A52;
					}
					continue;
				case 204:
					goto IL_1DEE;
				case 205:
					goto IL_1AE2;
				case 206:
					((ISupportInitialize)this.gO0oYQ1dHf).BeginInit();
					this.rxVoVarjxq.SuspendLayout();
					FormSettingsSender.VB1eni7BYS0IAa2W7Y3(this.ETVodSvqVE);
					num = 223;
					continue;
				case 207:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.imYuv0vN9Y, new Size(469, 73));
					num = 128;
					continue;
				case 208:
					this.GFwoKrhy3e.AutoSize = true;
					this.GFwoKrhy3e.Location = new Point(12, 15);
					num = 252;
					continue;
				case 209:
					goto IL_3DB3;
				case 210:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.gO0oYQ1dHf, 8);
					num = 88;
					continue;
				case 211:
					this.m0uudPYZpX.Location = new Point(192, 42);
					this.m0uudPYZpX.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41980);
					this.m0uudPYZpX.Size = new Size(120, 20);
					this.m0uudPYZpX.TabIndex = 8;
					FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.x2juUJENsT, true);
					num = 43;
					continue;
				case 212:
					this.XdsoSFJILo.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(40838);
					FormSettingsSender.iueI1O7zei1FfvvvnTN(this.XdsoSFJILo, true);
					num = 112;
					continue;
				case 213:
					goto IL_2860;
				case 214:
					this.imYuv0vN9Y.Controls.Add(this.tguuBT2lFE);
					num = 262;
					if (false)
					{
						goto IL_3B8B;
					}
					continue;
				case 215:
					goto IL_4A1;
				case 216:
					goto IL_C62;
				case 217:
					this.caWufkkLNs.Location = new Point(7, 365);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.caWufkkLNs, cDhluYseFOthxgEIXpc.nKHKpgTSVU(41838));
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.caWufkkLNs, new Size(472, 117));
					num = 166;
					continue;
				case 218:
					goto IL_443C;
				case 219:
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.T7FuWmRc4m, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42210));
					num = 226;
					continue;
				case 220:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.LADutCXOdb, new Size(46, 17));
					this.LADutCXOdb.TabIndex = 4;
					num = 281;
					continue;
				case 221:
					this.r6JoiXY9j1.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40528);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.r6JoiXY9j1, new Size(120, 20));
					num = 288;
					continue;
				case 222:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.TW4oHbeOyt, new Size(120, 20));
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.TW4oHbeOyt, 11);
					this.VP8oFnf2vS.Enabled = false;
					num = 198;
					continue;
				case 223:
					FormSettingsSender.FlfPRm7yRkFgaIbtA38(this.TW4oHbeOyt);
					FormSettingsSender.FlfPRm7yRkFgaIbtA38(this.VP8oFnf2vS);
					num = 61;
					continue;
				case 224:
					this.dshursBUcC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					num = 139;
					if (true)
					{
						continue;
					}
					break;
				case 225:
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.TZ3o2TsyGe.Controls, this.DoEuGfHpCZ);
					this.TZ3o2TsyGe.Location = new Point(1, 39);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.TZ3o2TsyGe, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32242));
					FormSettingsSender.KspF5I7ZxRCAT5FyhFt(this.TZ3o2TsyGe, 0);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.TZ3o2TsyGe, new Size(498, 511));
					num = 122;
					continue;
				case 226:
					this.T7FuWmRc4m.Size = new Size(55, 13);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.T7FuWmRc4m, 0);
					this.T7FuWmRc4m.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(40778);
					FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.Nc1uHCgyoZ, true);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.Nc1uHCgyoZ, new Point(7, 342));
					num = 135;
					continue;
				case 227:
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr).Add(this.CYSuurvDt0);
					num = 105;
					if (false)
					{
						goto IL_20C0;
					}
					continue;
				case 228:
					this.fl1uIcLa7X = new TextBox();
					this.RxPugvS30O = new CheckBox();
					this.zgCueCPULg = new TextBox();
					this.XGLundBwE3 = new MaskedTextBox();
					this.So1uJZT4cL = new Label();
					num = 46;
					continue;
				case 229:
					this.KUNuypHcpG = new TextBox();
					this.dshursBUcC = new DataGridView();
					num = 54;
					continue;
				case 230:
					this.KROokpgJ7h.Size = new Size(28, 23);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.KROokpgJ7h, 22);
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.KROokpgJ7h, FormSettingsSender.p91n9ElsT2I75NJjme3(40838));
					this.KROokpgJ7h.UseVisualStyleBackColor = true;
					num = 74;
					continue;
				case 231:
					this.W85oQ1v70T.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					FormSettingsSender.crB7uDQQR3ZyQaUHVTC(this.W85oQ1v70T, SystemColors.Window);
					this.W85oQ1v70T.Location = new Point(95, 12);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.W85oQ1v70T, cDhluYseFOthxgEIXpc.nKHKpgTSVU(43400));
					num = 94;
					continue;
				case 232:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.v73u14AJPD, 23);
					this.gxhuOAdBsA.AutoSize = true;
					this.gxhuOAdBsA.Location = new Point(7, 32);
					num = 180;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 233:
					this.k71uT9NO8T.TabIndex = 10;
					num = 211;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_46C5;
					}
					continue;
				case 234:
					this.rxVoVarjxq.Controls.Add(this.TtgosTTpwA);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.rxVoVarjxq.Controls, this.OxNolWaRba);
					this.rxVoVarjxq.Controls.Add(this.cNGo7HW9hU);
					this.rxVoVarjxq.Controls.Add(this.RJXoB6SooV);
					this.rxVoVarjxq.Controls.Add(this.MRFoaqvscI);
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq).Add(this.sQVo4WFoAX);
					this.rxVoVarjxq.Controls.Add(this.O0No1JqLOd);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.rxVoVarjxq.Controls, this.LirovRKmrk);
					num = 178;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_36FB;
					}
					continue;
				case 235:
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.n2Hu5bSws2, AnchorStyles.Top | AnchorStyles.Right);
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.n2Hu5bSws2, new Point(384, 19));
					this.n2Hu5bSws2.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(43036);
					num = 322;
					continue;
				case 236:
					goto IL_834;
				case 237:
					this.HMGulNhMFS.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(42932);
					this.HMGulNhMFS.Size = new Size(38, 13);
					num = 295;
					continue;
				case 238:
					goto IL_D28;
				case 239:
					goto IL_36FB;
				case 240:
					FormSettingsSender.QDAcsHQbdbQhTVYoY5k(this.k71uT9NO8T);
					((ISupportInitialize)this.m0uudPYZpX).EndInit();
					((ISupportInitialize)this.dshursBUcC).EndInit();
					num = 101;
					continue;
				case 241:
					this.u4Du7XmSxq.Location = new Point(4, 22);
					this.u4Du7XmSxq.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41766);
					this.u4Du7XmSxq.Padding = new Padding(3);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.u4Du7XmSxq, new Size(490, 485));
					num = 190;
					continue;
				case 242:
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.QpVoAeQsKr.Controls, this.erfozvOXLo);
					num = 204;
					continue;
				case 243:
					this.seDoXeDyD6 = new TextBox();
					this.TTQoqFuIwn = new Label();
					this.qsfomPxWc6 = new TextBox();
					this.TtgosTTpwA = new Label();
					this.cNGo7HW9hU = new Label();
					num = 41;
					continue;
				case 244:
					goto IL_4301;
				case 245:
					this.pBYuomHju0.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41070);
					num = 114;
					continue;
				case 246:
					this.QpVoAeQsKr.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40416);
					this.QpVoAeQsKr.UseVisualStyleBackColor = true;
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.CsSoyQ0k8a, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
					this.CsSoyQ0k8a.Controls.Add(this.EUVortqIPp);
					num = 140;
					if (!true)
					{
						goto IL_443C;
					}
					continue;
				case 247:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.v73u14AJPD, new Size(358, 20));
					num = 232;
					continue;
				case 248:
					this.tguuBT2lFE.PasswordChar = '*';
					num = 290;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 249:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.JxmoDovFMO, new Point(13, 78));
					this.JxmoDovFMO.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(41574);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.JxmoDovFMO, new Size(53, 17));
					this.JxmoDovFMO.TabIndex = 3;
					FormSettingsSender.w9RJVNQnsTamvfLCqL8(this.JxmoDovFMO, true);
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.JxmoDovFMO, FormSettingsSender.p91n9ElsT2I75NJjme3(40684));
					num = 86;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 250:
					FormSettingsSender.pIVda4QLH0ExWLW9aMh(this.jVhoE67YN1, FormSettingsSender.p91n9ElsT2I75NJjme3(30158));
					this.jVhoE67YN1.Format = DateTimePickerFormat.Custom;
					num = 167;
					continue;
				case 251:
					goto IL_151E;
				case 252:
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.GFwoKrhy3e, FormSettingsSender.p91n9ElsT2I75NJjme3(43356));
					this.GFwoKrhy3e.Size = new Size(77, 13);
					this.GFwoKrhy3e.TabIndex = 19;
					this.GFwoKrhy3e.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(43372);
					num = 231;
					continue;
				case 253:
					this.WXUu8KMxpD.Size = new Size(139, 20);
					this.WXUu8KMxpD.TabIndex = 35;
					num = 216;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_190D;
					}
					continue;
				case 254:
					this.WIGuw1gKA0.Size = new Size(32, 13);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.WIGuw1gKA0, 3);
					this.WIGuw1gKA0.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(43024);
					num = 235;
					continue;
				case 255:
					goto IL_509;
				case 256:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.x2juUJENsT, 5);
					this.x2juUJENsT.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40608);
					this.x2juUJENsT.UseVisualStyleBackColor = true;
					num = 133;
					if (!true)
					{
						goto IL_5079;
					}
					continue;
				case 257:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.oUruc1YLci, new Point(6, 42));
					this.oUruc1YLci.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(42148);
					num = 271;
					continue;
				case 258:
					goto IL_49C5;
				case 259:
					FormSettingsSender.u0PDuvQT7PRgLGdKg5n(this.OimupDkga9, DateTimePickerFormat.Custom);
					num = 70;
					continue;
				case 260:
					goto IL_16DE;
				case 261:
					this.DoEuGfHpCZ.PerformLayout();
					num = 311;
					if (false)
					{
						goto IL_373C;
					}
					continue;
				case 262:
					goto IL_38BA;
				case 263:
					this.CYSuurvDt0.Location = new Point(9, 194);
					num = 285;
					continue;
				case 264:
					goto IL_2B88;
				case 266:
					this.qsfomPxWc6.TabIndex = 2;
					this.qsfomPxWc6.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39648);
					this.TtgosTTpwA.AutoSize = true;
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.TtgosTTpwA, new Point(7, 95));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.TtgosTTpwA, cDhluYseFOthxgEIXpc.nKHKpgTSVU(32080));
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.TtgosTTpwA, new Size(54, 13));
					this.TtgosTTpwA.TabIndex = 3;
					num = 153;
					continue;
				case 267:
					this.v73u14AJPD.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(43214);
					num = 247;
					continue;
				case 268:
					this.SYeoUtOBCc = new RadioButton();
					this.kueotpDpaa = new RadioButton();
					this.JxmoDovFMO = new RadioButton();
					this.Dp4ocPU9xO = new Label();
					this.Yu2opE9oes = new DateTimePicker();
					this.eQkoWFEuy3 = new Label();
					this.xWyoTABNxr = new Button();
					this.KROokpgJ7h = new Button();
					this.wiPofGeZmM = new Label();
					this.BTfo6OSA71 = new TextBox();
					this.u4Du7XmSxq = new TabPage();
					this.caWufkkLNs = new GroupBox();
					this.ehYu6sgrZp = new NumericUpDown();
					num = 269;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_3DB3;
					}
					continue;
				case 269:
					goto IL_3501;
				case 270:
					goto IL_46E8;
				case 271:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.oUruc1YLci, new Size(104, 13));
					num = 24;
					continue;
				case 272:
					this.CP5oww8CcY.Size = new Size(45, 13);
					num = 78;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_4FB5;
					}
					continue;
				case 273:
					FormSettingsSender.kPPNYg7DiIkGcumpR1Q(this.XGLundBwE3, '*');
					this.XGLundBwE3.Size = new Size(149, 20);
					num = 60;
					continue;
				case 274:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.ix2oj2wknM, 4);
					this.ix2oj2wknM.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40648);
					FormSettingsSender.iueI1O7zei1FfvvvnTN(this.ix2oj2wknM, true);
					FormSettingsSender.lrtNSPQ3noEJAFCknbu(this.ix2oj2wknM, new EventHandler(this.Vqqo0Yl9Ly));
					num = 238;
					continue;
				case 275:
					goto IL_2894;
				case 276:
					this.UYLuVoQJQT.TabIndex = 4;
					num = 97;
					continue;
				case 277:
					this.dshursBUcC.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42400);
					num = 33;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						return;
					}
					continue;
				case 278:
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.g4wuDPMX6y, 3);
					this.g4wuDPMX6y.TabStop = true;
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.g4wuDPMX6y, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40684));
					this.g4wuDPMX6y.UseVisualStyleBackColor = true;
					this.g4wuDPMX6y.CheckedChanged += this.IJPoMJCYAJ;
					num = 35;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_448;
					}
					continue;
				case 279:
					goto IL_1B36;
				case 280:
					FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.YLFuQV45Zb, true);
					this.YLFuQV45Zb.Location = new Point(6, 22);
					num = 200;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_3FD5;
					}
					continue;
				case 281:
					this.LADutCXOdb.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40648);
					this.LADutCXOdb.UseVisualStyleBackColor = true;
					num = 287;
					if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						continue;
					}
					continue;
				case 282:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.EUVortqIPp, new Size(120, 20));
					this.EUVortqIPp.TabIndex = 11;
					num = 10;
					continue;
				case 283:
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.xqFuAPgtM2.Controls, this.pLtuSNtbly);
					num = 165;
					continue;
				case 284:
					this.zgCueCPULg.Location = new Point(92, 34);
					num = 264;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_EAB;
					}
					continue;
				case 285:
					this.CYSuurvDt0.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41102);
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.CYSuurvDt0, new Size(119, 13));
					num = 147;
					continue;
				case 286:
					this.ETVodSvqVE.ResumeLayout(false);
					num = 1;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_4476;
					}
					continue;
				case 287:
					this.LADutCXOdb.CheckedChanged += this.IJPoMJCYAJ;
					this.g4wuDPMX6y.AutoSize = true;
					this.g4wuDPMX6y.Checked = true;
					this.g4wuDPMX6y.Location = new Point(125, 45);
					this.g4wuDPMX6y.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(42106);
					num = 150;
					continue;
				case 288:
					this.r6JoiXY9j1.TabIndex = 10;
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.gO0oYQ1dHf, new Point(80, 75));
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.gO0oYQ1dHf, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40554));
					this.gO0oYQ1dHf.Size = new Size(120, 20);
					num = 210;
					continue;
				case 289:
					this.So1uJZT4cL.TabIndex = 26;
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.So1uJZT4cL, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39590));
					num = 127;
					continue;
				case 290:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.tguuBT2lFE, new Size(137, 20));
					this.tguuBT2lFE.TabIndex = 6;
					this.HMGulNhMFS.AutoSize = true;
					this.HMGulNhMFS.Location = new Point(6, 48);
					num = 237;
					if (!true)
					{
						goto IL_4939;
					}
					continue;
				case 291:
					this.sQVo4WFoAX.Location = new Point(10, 172);
					this.sQVo4WFoAX.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40010);
					this.sQVo4WFoAX.Size = new Size(138, 17);
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.sQVo4WFoAX, 11);
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.sQVo4WFoAX, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40042));
					this.sQVo4WFoAX.UseVisualStyleBackColor = true;
					this.sQVo4WFoAX.CheckedChanged += this.IiWoIBcc82;
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.RJXoB6SooV, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.RJXoB6SooV.Enabled = false;
					this.RJXoB6SooV.Location = new Point(154, 170);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.RJXoB6SooV, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40084));
					this.RJXoB6SooV.Size = new Size(325, 20);
					this.RJXoB6SooV.TabIndex = 12;
					num = 176;
					continue;
				case 292:
					this.ehYu6sgrZp.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41894);
					num = 304;
					if (FormSettingsSender.LeYg67lSeyEyv7mLyx1())
					{
						goto IL_2087;
					}
					continue;
				case 293:
					this.S82usbI3X8.Location = new Point(92, 139);
					this.S82usbI3X8.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(41298);
					num = 213;
					continue;
				case 294:
					this.LrfujmRk7x = new CheckBox();
					num = 56;
					continue;
				case 295:
					this.HMGulNhMFS.TabIndex = 5;
					num = 138;
					if (false)
					{
						goto IL_3501;
					}
					continue;
				case 296:
					FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.IaLuZm7bBZ, new Point(451, 32));
					num = 199;
					continue;
				case 297:
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.LADutCXOdb, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42066));
					num = 220;
					continue;
				case 298:
					this.erfozvOXLo.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40838);
					FormSettingsSender.iueI1O7zei1FfvvvnTN(this.erfozvOXLo, true);
					this.erfozvOXLo.Click += this.X1VonWpgtg;
					this.IaLuZm7bBZ.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
					num = 296;
					continue;
				case 299:
					FormSettingsSender.PcqABe7mBEg9uMisXOp(this.LirovRKmrk, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39992));
					num = 195;
					if (!true)
					{
						goto IL_22A7;
					}
					continue;
				case 300:
					FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.WIGuw1gKA0, AnchorStyles.Top | AnchorStyles.Right);
					num = 115;
					if (false)
					{
						goto IL_BC6;
					}
					continue;
				case 301:
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.U7mu4Bv5u2, new Size(45, 13));
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.U7mu4Bv5u2, 7);
					this.U7mu4Bv5u2.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40250);
					num = 144;
					continue;
				case 302:
					goto IL_B34;
				case 303:
					goto IL_11A4;
				case 304:
					this.ehYu6sgrZp.Size = new Size(120, 20);
					this.ehYu6sgrZp.TabIndex = 11;
					FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.k71uT9NO8T, false);
					num = 51;
					if (!true)
					{
						goto IL_416A;
					}
					continue;
				case 305:
					FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.TZ3o2TsyGe).Add(this.rxVoVarjxq);
					FormSettingsSender.jQhDjm7IOShbbhqN09n(this.TZ3o2TsyGe.Controls, this.u4Du7XmSxq);
					num = 225;
					continue;
				case 306:
					((ISupportInitialize)this.gO0oYQ1dHf).EndInit();
					this.rxVoVarjxq.ResumeLayout(false);
					FormSettingsSender.aP7jyVQdE12x46GEH3o(this.rxVoVarjxq);
					num = 286;
					if (!true)
					{
						goto IL_1AE2;
					}
					continue;
				case 307:
					goto IL_3F2B;
				case 308:
					base.AcceptButton = this.MQBoO75tUr;
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 79;
					continue;
				case 309:
					this.erfozvOXLo.Location = new Point(451, 58);
					this.erfozvOXLo.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40800);
					num = 42;
					continue;
				case 310:
					goto IL_4EB7;
				case 311:
					base.ResumeLayout(false);
					num = 25;
					continue;
				case 312:
					this.k71uT9NO8T.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41938);
					this.k71uT9NO8T.Size = new Size(120, 20);
					num = 233;
					continue;
				case 313:
					FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.fwro9xuoth, true);
					num = 119;
					continue;
				case 314:
					this.pBYuomHju0 = new TextBox();
					num = 321;
					continue;
				case 315:
					goto IL_4476;
				case 316:
					goto IL_4319;
				case 317:
					this.xFqoLJhJ3c.UseVisualStyleBackColor = true;
					this.xFqoLJhJ3c.Click += this.ubB0jAfQvC;
					this.LirovRKmrk.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					this.LirovRKmrk.Location = new Point(90, 144);
					num = 92;
					continue;
				case 318:
					this.QZlo5bclsp.Enabled = false;
					this.QZlo5bclsp.Location = new Point(328, 196);
					FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.QZlo5bclsp, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40266));
					this.QZlo5bclsp.PasswordChar = '*';
					FormSettingsSender.l868Y97N7LycF6Gewhl(this.QZlo5bclsp, new Size(151, 20));
					FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.QZlo5bclsp, 16);
					this.QZlo5bclsp.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39992);
					num = 313;
					continue;
				case 319:
					this.O0No1JqLOd = new Label();
					this.MQBoO75tUr = new Button();
					this.xFqoLJhJ3c = new Button();
					this.LirovRKmrk = new MaskedTextBox();
					num = 37;
					continue;
				case 320:
					goto IL_20C0;
				case 321:
					this.CYSuurvDt0 = new Label();
					this.mAiuMPamrf = new Label();
					this.WXUu8KMxpD = new TextBox();
					this.lJVuRnxP7w = new Label();
					this.x2auCffKij = new TextBox();
					this.Uc8uXeCNrg = new TextBox();
					num = 48;
					continue;
				case 322:
					this.n2Hu5bSws2.Size = new Size(79, 20);
					num = 148;
					if (!true)
					{
						goto IL_77C;
					}
					continue;
				case 323:
					this.pLtuSNtbly.Location = new Point(80, 19);
					num = 315;
					if (!true)
					{
						goto IL_1836;
					}
					continue;
				case 324:
					return;
				default:
					num = 156;
					if (!FormSettingsSender.woBBQHlNPqnbmgFGUYy())
					{
						goto IL_3491;
					}
					continue;
				}
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.Nc1uHCgyoZ, FormSettingsSender.p91n9ElsT2I75NJjme3(42228));
				this.Nc1uHCgyoZ.Size = new Size(97, 13);
				num = 203;
				if (!false)
				{
					continue;
				}
				IL_CA:
				this.kueotpDpaa.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41546);
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.kueotpDpaa, new Size(46, 17));
				FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.kueotpDpaa, 4);
				num = 57;
				continue;
				IL_12D:
				this.sQVo4WFoAX.AutoSize = true;
				num = 291;
				continue;
				IL_322:
				this.S82usbI3X8.TabIndex = 32;
				this.S82usbI3X8.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39992);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(this.rxVoVarjxq.Controls, this.ETVodSvqVE);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq).Add(this.xWyoTABNxr);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq).Add(this.KROokpgJ7h);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq).Add(this.wiPofGeZmM);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq), this.BTfo6OSA71);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq).Add(this.fwro9xuoth);
				num = 164;
				continue;
				IL_448:
				FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.ix2oj2wknM, true);
				this.ix2oj2wknM.Location = new Point(13, 101);
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.ix2oj2wknM, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40624));
				this.ix2oj2wknM.Size = new Size(46, 17);
				num = 274;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_4A1:
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.lJVuRnxP7w, FormSettingsSender.p91n9ElsT2I75NJjme3(41174));
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.lJVuRnxP7w, new Size(61, 13));
				FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.lJVuRnxP7w, 29);
				this.lJVuRnxP7w.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(39810);
				this.x2auCffKij.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				num = 132;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_509:
				this.U7mu4Bv5u2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
				num = 16;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_526:
				this.CsSoyQ0k8a.Controls.Add(this.HQIoG7WF2l);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(this.CsSoyQ0k8a.Controls, this.ix2oj2wknM);
				this.CsSoyQ0k8a.Controls.Add(this.mtIob811iE);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.CsSoyQ0k8a).Add(this.XqioNGM8Cw);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.CsSoyQ0k8a), this.jVhoE67YN1);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.CsSoyQ0k8a).Add(this.tEnohFlmXB);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.CsSoyQ0k8a, new Point(12, 217));
				this.CsSoyQ0k8a.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40436);
				this.CsSoyQ0k8a.Size = new Size(467, 254);
				this.CsSoyQ0k8a.TabIndex = 44;
				FormSettingsSender.zd2R9c7cDNd2CCvYgps(this.CsSoyQ0k8a, false);
				this.CsSoyQ0k8a.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(40476);
				num = 239;
				continue;
				IL_6CD:
				this.mtIob811iE.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40658);
				this.mtIob811iE.Size = new Size(53, 17);
				this.mtIob811iE.TabIndex = 3;
				this.mtIob811iE.TabStop = true;
				FormSettingsSender.PcqABe7mBEg9uMisXOp(this.mtIob811iE, FormSettingsSender.p91n9ElsT2I75NJjme3(40684));
				FormSettingsSender.iueI1O7zei1FfvvvnTN(this.mtIob811iE, true);
				FormSettingsSender.lrtNSPQ3noEJAFCknbu(this.mtIob811iE, new EventHandler(this.Vqqo0Yl9Ly));
				this.XqioNGM8Cw.AutoSize = true;
				num = 53;
				continue;
				IL_77C:
				this.imYuv0vN9Y.TabIndex = 26;
				this.imYuv0vN9Y.TabStop = false;
				this.imYuv0vN9Y.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(42814);
				num = 255;
				continue;
				IL_834:
				FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.xFqoLJhJ3c, AnchorStyles.Top | AnchorStyles.Right);
				FormSettingsSender.a5dFbu7pKVZp0o5xCuJ(this.xFqoLJhJ3c, DialogResult.Cancel);
				num = 151;
				continue;
				IL_A9C:
				this.MinimumSize = new Size(500, 514);
				FormSettingsSender.InXaCTQVqk24Rk49ZhC(this, FormSettingsSender.p91n9ElsT2I75NJjme3(43686));
				num = 72;
				continue;
				IL_BC6:
				this.pgWoP9MDb0.TabIndex = 14;
				this.pgWoP9MDb0.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40192);
				FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.CP5oww8CcY, true);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.CP5oww8CcY, new Point(277, 199));
				this.CP5oww8CcY.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40234);
				num = 272;
				if (true)
				{
					continue;
				}
				IL_C2F:
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.Tx3uPcd9UZ, new Size(189, 20));
				this.Tx3uPcd9UZ.TabIndex = 4;
				num = 300;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_C62:
				this.lJVuRnxP7w.AutoSize = true;
				num = 113;
				continue;
				IL_D02:
				this.XdsoSFJILo = new Button();
				this.DoEuGfHpCZ = new TabPage();
				num = 294;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_D28:
				this.mtIob811iE.AutoSize = true;
				num = 4;
				continue;
				IL_EAB:
				((ISupportInitialize)this.m0uudPYZpX).BeginInit();
				FormSettingsSender.FlfPRm7yRkFgaIbtA38(this.dshursBUcC);
				this.xqFuAPgtM2.SuspendLayout();
				FormSettingsSender.VB1eni7BYS0IAa2W7Y3(this.imYuv0vN9Y);
				FormSettingsSender.FlfPRm7yRkFgaIbtA38(this.n2Hu5bSws2);
				num = 155;
				continue;
				IL_F7D:
				this.SYeoUtOBCc.CheckedChanged += this.mXoo3SPq1l;
				FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.kueotpDpaa, true);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.kueotpDpaa, new Point(13, 101));
				num = 0;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				continue;
				IL_11A4:
				this.WXUu8KMxpD.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(41138);
				num = 253;
				continue;
				IL_1297:
				this.DoEuGfHpCZ.Location = new Point(4, 22);
				num = 171;
				continue;
				IL_1407:
				this.sQVo4WFoAX = new CheckBox();
				this.RJXoB6SooV = new TextBox();
				this.OxNolWaRba = new TextBox();
				num = 2;
				continue;
				IL_14E2:
				this.v51uidnQU1 = new DataGridViewTextBoxColumn();
				this.RaHuYYIwGE = new DataGridViewTextBoxColumn();
				this.nUDukruyZg = new Label();
				this.xqFuAPgtM2 = new GroupBox();
				num = 15;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_151E:
				this.Yu2opE9oes.TabIndex = 1;
				this.eQkoWFEuy3.AutoSize = true;
				this.eQkoWFEuy3.Location = new Point(6, 25);
				num = 81;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_1559:
				this.CYSuurvDt0.AutoSize = true;
				num = 263;
				if (true)
				{
					continue;
				}
				IL_1571:
				FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.VP8oFnf2vS, 10);
				this.d5YoxAPEep.Location = new Point(80, 75);
				num = 71;
				continue;
				IL_16A7:
				this.QpVoAeQsKr.TabIndex = 0;
				num = 246;
				continue;
				IL_16DE:
				this.v73u14AJPD = new TextBox();
				num = 55;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				continue;
				IL_17AA:
				FormSettingsSender.jQhDjm7IOShbbhqN09n(this.CsSoyQ0k8a.Controls, this.r6JoiXY9j1);
				num = 136;
				continue;
				IL_1836:
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.LrfujmRk7x, new Point(10, 16));
				this.LrfujmRk7x.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(43578);
				this.LrfujmRk7x.Size = new Size(162, 17);
				this.LrfujmRk7x.TabIndex = 0;
				this.LrfujmRk7x.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(43612);
				this.LrfujmRk7x.UseVisualStyleBackColor = true;
				num = 308;
				continue;
				IL_B34:
				goto IL_1836;
				IL_190D:
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.IaLuZm7bBZ, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40848));
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.IaLuZm7bBZ, new Size(28, 23));
				this.IaLuZm7bBZ.TabIndex = 42;
				this.IaLuZm7bBZ.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40838);
				this.IaLuZm7bBZ.UseVisualStyleBackColor = true;
				FormSettingsSender.VyJpbZQjUSkwjq60Upw(this.IaLuZm7bBZ, new EventHandler(this.HicoeCpObo));
				this.tbZu3Icliq.Location = new Point(9, 57);
				this.tbZu3Icliq.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(31300);
				num = 130;
				continue;
				IL_19C6:
				this.caWufkkLNs.Controls.Add(this.T7FuWmRc4m);
				num = 217;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_19EC:
				FormSettingsSender.jQhDjm7IOShbbhqN09n(this.caWufkkLNs.Controls, this.k71uT9NO8T);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.caWufkkLNs).Add(this.m0uudPYZpX);
				this.caWufkkLNs.Controls.Add(this.x2juUJENsT);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.caWufkkLNs).Add(this.LADutCXOdb);
				this.caWufkkLNs.Controls.Add(this.g4wuDPMX6y);
				num = 118;
				continue;
				IL_1AE2:
				this.tEnohFlmXB.Location = new Point(6, 25);
				this.tEnohFlmXB.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40760);
				this.tEnohFlmXB.Size = new Size(55, 13);
				this.tEnohFlmXB.TabIndex = 0;
				num = 192;
				if (true)
				{
					continue;
				}
				IL_1B36:
				FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.KROokpgJ7h, AnchorStyles.Top | AnchorStyles.Right);
				this.KROokpgJ7h.Location = new Point(451, 37);
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.KROokpgJ7h, FormSettingsSender.p91n9ElsT2I75NJjme3(41678));
				num = 230;
				continue;
				IL_1D50:
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.TTQoqFuIwn, new Size(64, 13));
				this.TTQoqFuIwn.TabIndex = 1;
				num = 187;
				continue;
				IL_1DEE:
				FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr), this.IaLuZm7bBZ);
				this.QpVoAeQsKr.Controls.Add(this.tbZu3Icliq);
				this.QpVoAeQsKr.Controls.Add(this.fl1uIcLa7X);
				this.QpVoAeQsKr.Controls.Add(this.RxPugvS30O);
				this.QpVoAeQsKr.Controls.Add(this.zgCueCPULg);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr), this.XGLundBwE3);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr).Add(this.So1uJZT4cL);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.QpVoAeQsKr).Add(this.IZmu0YbMol);
				this.QpVoAeQsKr.Controls.Add(this.pBYuomHju0);
				num = 227;
				continue;
				IL_2087:
				this.duquaoP6wR.TabIndex = 25;
				num = 201;
				continue;
				IL_20C0:
				this.tguuBT2lFE.Location = new Point(326, 45);
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.tguuBT2lFE, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42894));
				num = 248;
				continue;
				IL_2131:
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.U7mu4Bv5u2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42876));
				num = 301;
				continue;
				IL_22A7:
				this.KUNuypHcpG.Size = new Size(372, 20);
				FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.KUNuypHcpG, 30);
				FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.dshursBUcC, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				FormSettingsSender.uXtTtMQH8bb0JL7VDS6(this.dshursBUcC, SystemColors.Control);
				num = 224;
				continue;
				IL_2370:
				FormSettingsSender.VB1eni7BYS0IAa2W7Y3(this.DoEuGfHpCZ);
				FormSettingsSender.Ck0dpI76MVFS6jY3FAJ(this);
				this.seDoXeDyD6.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				this.seDoXeDyD6.Location = new Point(90, 39);
				num = 103;
				continue;
				IL_24C8:
				this.IZmu0YbMol = new Label();
				num = 314;
				if (true)
				{
					continue;
				}
				IL_24DF:
				this.r6JoiXY9j1.Enabled = false;
				this.r6JoiXY9j1.Location = new Point(80, 98);
				num = 221;
				if (!false)
				{
					continue;
				}
				IL_250B:
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.mtIob811iE, new Point(13, 78));
				num = 64;
				continue;
				IL_2800:
				this.DoEuGfHpCZ.Size = new Size(490, 485);
				this.DoEuGfHpCZ.TabIndex = 3;
				FormSettingsSender.PcqABe7mBEg9uMisXOp(this.DoEuGfHpCZ, cDhluYseFOthxgEIXpc.nKHKpgTSVU(43568));
				num = 173;
				continue;
				IL_2860:
				this.S82usbI3X8.PasswordChar = '*';
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.S82usbI3X8, new Size(387, 20));
				num = 174;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_2894:
				FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.tEnohFlmXB, true);
				num = 205;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_28B0:
				this.IZmu0YbMol.AutoSize = true;
				this.IZmu0YbMol.Location = new Point(279, 194);
				this.IZmu0YbMol.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31936);
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.IZmu0YbMol, new Size(45, 13));
				this.IZmu0YbMol.TabIndex = 37;
				this.IZmu0YbMol.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(40250);
				FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.pBYuomHju0, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				this.pBYuomHju0.Location = new Point(92, 87);
				num = 245;
				continue;
				IL_298D:
				this.HQIoG7WF2l.AutoSize = true;
				this.HQIoG7WF2l.Location = new Point(13, 124);
				this.HQIoG7WF2l.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40582);
				this.HQIoG7WF2l.Size = new Size(63, 17);
				this.HQIoG7WF2l.TabIndex = 5;
				this.HQIoG7WF2l.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40608);
				this.HQIoG7WF2l.UseVisualStyleBackColor = true;
				this.HQIoG7WF2l.CheckedChanged += this.Vqqo0Yl9Ly;
				num = 126;
				continue;
				IL_2A52:
				this.TTQoqFuIwn.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39590);
				this.qsfomPxWc6.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.qsfomPxWc6, new Point(90, 92));
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.qsfomPxWc6, FormSettingsSender.p91n9ElsT2I75NJjme3(39612));
				this.qsfomPxWc6.Size = new Size(389, 20);
				num = 266;
				continue;
				IL_2B88:
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.zgCueCPULg, cDhluYseFOthxgEIXpc.nKHKpgTSVU(41002));
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.zgCueCPULg, new Size(356, 20));
				this.zgCueCPULg.TabIndex = 25;
				this.zgCueCPULg.Text = FormSettingsSender.p91n9ElsT2I75NJjme3(39496);
				num = 185;
				continue;
				IL_2CD8:
				this.RJXoB6SooV.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40116);
				FormSettingsSender.cmAiYe70EqkV1DNjDVm(this.OxNolWaRba, false);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.OxNolWaRba, new Point(132, 196));
				this.OxNolWaRba.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(40152);
				this.OxNolWaRba.Size = new Size(139, 20);
				FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.OxNolWaRba, 13);
				FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.pgWoP9MDb0, true);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.pgWoP9MDb0, new Point(7, 199));
				this.pgWoP9MDb0.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(37908);
				this.pgWoP9MDb0.Size = new Size(119, 13);
				num = (FormSettingsSender.LeYg67lSeyEyv7mLyx1() ? 75 : 265);
				continue;
				IL_2DF2:
				this.XdsoSFJILo.Name = FormSettingsSender.p91n9ElsT2I75NJjme3(43514);
				num = 191;
				continue;
				IL_2E89:
				this.TtgosTTpwA.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(39790);
				this.cNGo7HW9hU.AutoSize = true;
				num = 95;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_2EBA:
				this.caWufkkLNs.TabIndex = 45;
				FormSettingsSender.zd2R9c7cDNd2CCvYgps(this.caWufkkLNs, false);
				num = 202;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_2EE3:
				FormSettingsSender.aP7jyVQdE12x46GEH3o(this.ETVodSvqVE);
				FormSettingsSender.QDAcsHQbdbQhTVYoY5k(this.TW4oHbeOyt);
				((ISupportInitialize)this.VP8oFnf2vS).EndInit();
				((ISupportInitialize)this.d5YoxAPEep).EndInit();
				FormSettingsSender.veqap3QFf2rp3lwc2VY(this.u4Du7XmSxq, false);
				this.u4Du7XmSxq.PerformLayout();
				this.caWufkkLNs.ResumeLayout(false);
				num = 170;
				continue;
				IL_3491:
				this.tguuBT2lFE.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
				num = 320;
				continue;
				IL_3501:
				this.k71uT9NO8T = new NumericUpDown();
				this.m0uudPYZpX = new NumericUpDown();
				this.x2juUJENsT = new RadioButton();
				num = 27;
				continue;
				IL_36FB:
				this.EUVortqIPp.Enabled = false;
				this.EUVortqIPp.Location = new Point(80, 121);
				num = 108;
				continue;
				IL_373C:
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.pBYuomHju0, new Size(387, 20));
				num = 77;
				continue;
				IL_3894:
				FormSettingsSender.jQhDjm7IOShbbhqN09n(this.CsSoyQ0k8a.Controls, this.gO0oYQ1dHf);
				num = 39;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_38BA:
				this.imYuv0vN9Y.Controls.Add(this.HMGulNhMFS);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(this.imYuv0vN9Y.Controls, this.Tx3uPcd9UZ);
				this.imYuv0vN9Y.Controls.Add(this.WIGuw1gKA0);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(this.imYuv0vN9Y.Controls, this.n2Hu5bSws2);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.imYuv0vN9Y).Add(this.MT3u9a8ZKO);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.imYuv0vN9Y).Add(this.UXYu2ec0FP);
				this.imYuv0vN9Y.Location = new Point(10, 55);
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.imYuv0vN9Y, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42786));
				num = 207;
				continue;
				IL_3B8B:
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.gxhuOAdBsA, cDhluYseFOthxgEIXpc.nKHKpgTSVU(43262));
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.gxhuOAdBsA, new Size(64, 13));
				this.gxhuOAdBsA.TabIndex = 24;
				FormSettingsSender.PcqABe7mBEg9uMisXOp(this.gxhuOAdBsA, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39590));
				this.w86uLOZ6Cn.AutoSize = true;
				FormSettingsSender.w3qYf77g68Y8YFh41Xg(this.w86uLOZ6Cn, true);
				FormSettingsSender.kdX8WX7U81tGvrkHnKB(this.w86uLOZ6Cn, CheckState.Checked);
				num = 123;
				continue;
				IL_3DB3:
				FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.UXYu2ec0FP, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.UXYu2ec0FP, new Point(80, 19));
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.UXYu2ec0FP, cDhluYseFOthxgEIXpc.nKHKpgTSVU(43132));
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.UXYu2ec0FP, new Size(260, 20));
				FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.UXYu2ec0FP, 0);
				FormSettingsSender.aVmWoR7OI3T0fvH1Qo3(this.duquaoP6wR, AnchorStyles.Top | AnchorStyles.Right);
				this.duquaoP6wR.Location = new Point(451, 27);
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.duquaoP6wR, cDhluYseFOthxgEIXpc.nKHKpgTSVU(43176));
				num = 109;
				if (FormSettingsSender.woBBQHlNPqnbmgFGUYy())
				{
					continue;
				}
				IL_3E55:
				this.d5YoxAPEep.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(41484);
				this.d5YoxAPEep.Size = new Size(120, 20);
				this.d5YoxAPEep.TabIndex = 8;
				FormSettingsSender.HGTwbu7fTA7oUZBS4hr(this.SYeoUtOBCc, true);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.SYeoUtOBCc, new Point(13, 124));
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.SYeoUtOBCc, cDhluYseFOthxgEIXpc.nKHKpgTSVU(41516));
				this.SYeoUtOBCc.Size = new Size(63, 17);
				this.SYeoUtOBCc.TabIndex = 5;
				FormSettingsSender.PcqABe7mBEg9uMisXOp(this.SYeoUtOBCc, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40608));
				FormSettingsSender.iueI1O7zei1FfvvvnTN(this.SYeoUtOBCc, true);
				num = 125;
				continue;
				IL_3F2B:
				this.kueotpDpaa.UseVisualStyleBackColor = true;
				this.kueotpDpaa.CheckedChanged += this.mXoo3SPq1l;
				this.JxmoDovFMO.AutoSize = true;
				this.JxmoDovFMO.Checked = true;
				num = 249;
				continue;
				IL_3FD5:
				this.w5TuFUb2jt.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.w5TuFUb2jt, new Point(107, 339));
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.w5TuFUb2jt, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42280));
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.w5TuFUb2jt, new Size(372, 20));
				FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.w5TuFUb2jt, 32);
				this.KTTuxidVAT.AutoSize = true;
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.KTTuxidVAT, new Point(7, 316));
				num = 65;
				if (!FormSettingsSender.LeYg67lSeyEyv7mLyx1())
				{
					continue;
				}
				IL_4064:
				base.Load += this.pZg0iOwJ1I;
				this.TZ3o2TsyGe.ResumeLayout(false);
				num = 117;
				if (true)
				{
					continue;
				}
				IL_408E:
				this.KROokpgJ7h.Click += this.YgI0zZFGDy;
				this.wiPofGeZmM.Location = new Point(7, 62);
				num = 141;
				continue;
				IL_4107:
				this.LADutCXOdb.AutoSize = true;
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.LADutCXOdb, new Point(125, 68));
				num = 297;
				continue;
				IL_416A:
				this.So1uJZT4cL.AutoSize = true;
				num = 36;
				continue;
				IL_42C6:
				this.CP5oww8CcY.TabIndex = 15;
				this.CP5oww8CcY.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40250);
				this.QZlo5bclsp.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				num = 318;
				if (true)
				{
					continue;
				}
				IL_4301:
				this.RxPugvS30O.Checked = true;
				num = 49;
				if (true)
				{
					continue;
				}
				IL_4319:
				base.Controls.Add(this.xFqoLJhJ3c);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(base.Controls, this.MQBoO75tUr);
				FormSettingsSender.BeZfpvQwShXBF4BZ3DN(this, (Icon)componentResourceManager.GetObject(cDhluYseFOthxgEIXpc.nKHKpgTSVU(43662)));
				num = 52;
				continue;
				IL_4360:
				this.ETVodSvqVE.TabIndex = 24;
				this.ETVodSvqVE.TabStop = false;
				this.ETVodSvqVE.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40476);
				num = 270;
				continue;
				IL_443C:
				this.hASumvj8Xo.Size = new Size(68, 13);
				num = 181;
				continue;
				IL_4476:
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.pLtuSNtbly, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42736));
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.pLtuSNtbly, new Size(383, 20));
				FormSettingsSender.PbhVmS7s79a1rMRUZ7Z(this.pLtuSNtbly, 1);
				this.imYuv0vN9Y.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				this.imYuv0vN9Y.Controls.Add(this.U7mu4Bv5u2);
				num = 214;
				continue;
				IL_4630:
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq).Add(this.QZlo5bclsp);
				this.rxVoVarjxq.Controls.Add(this.TTQoqFuIwn);
				this.rxVoVarjxq.Controls.Add(this.CP5oww8CcY);
				FormSettingsSender.ajYvCc7Jj0IrFWyOjbb(this.rxVoVarjxq).Add(this.qsfomPxWc6);
				FormSettingsSender.jQhDjm7IOShbbhqN09n(this.rxVoVarjxq.Controls, this.pgWoP9MDb0);
				num = 234;
				continue;
				IL_46C5:
				this.U7mu4Bv5u2.Location = new Point(275, 48);
				num = 129;
				if (true)
				{
					continue;
				}
				IL_46E8:
				this.TW4oHbeOyt.Enabled = false;
				this.TW4oHbeOyt.Location = new Point(80, 121);
				num = 177;
				continue;
				IL_4939:
				this.MRFoaqvscI = new TextBox();
				num = 319;
				continue;
				IL_49C5:
				this.Dp4ocPU9xO.Location = new Point(10, 51);
				this.Dp4ocPU9xO.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(31590);
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.Dp4ocPU9xO, new Size(104, 13));
				this.Dp4ocPU9xO.TabIndex = 2;
				FormSettingsSender.PcqABe7mBEg9uMisXOp(this.Dp4ocPU9xO, cDhluYseFOthxgEIXpc.nKHKpgTSVU(40696));
				this.Yu2opE9oes.Cursor = FormSettingsSender.T6gpUUQW1NXI9SHNJd0();
				num = 120;
				continue;
				IL_4EB7:
				FormSettingsSender.eXV7QnQX0eXa7rMxSw9(this.RxPugvS30O, new EventHandler(this.bX3ogd1N9k));
				this.zgCueCPULg.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				num = 284;
				continue;
				IL_4FB5:
				this.MT3u9a8ZKO.Location = new Point(6, 22);
				this.MT3u9a8ZKO.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(43088);
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.MT3u9a8ZKO, new Size(74, 13));
				num = 87;
				continue;
				IL_5079:
				FormSettingsSender.hgMvK27S4jIaSsrJRSe(this.jVhoE67YN1, new Point(80, 19));
				this.jVhoE67YN1.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(40732);
				FormSettingsSender.l868Y97N7LycF6Gewhl(this.jVhoE67YN1, new Size(200, 20));
				this.jVhoE67YN1.TabIndex = 1;
				num = 275;
				continue;
				IL_5153:
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.TW4oHbeOyt, cDhluYseFOthxgEIXpc.nKHKpgTSVU(41422));
				num = 222;
				if (true)
				{
					continue;
				}
				IL_5174:
				this.xqFuAPgtM2.Location = new Point(10, 134);
				FormSettingsSender.yMQ2ht7AeEPSmNYoCin(this.xqFuAPgtM2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(42598));
				num = 90;
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0003076C File Offset: 0x0002EB6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FormSettingsSender()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00030784 File Offset: 0x0002EB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EVqXrHlAwt88Oob10oO()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0003079C File Offset: 0x0002EB9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object p91n9ElsT2I75NJjme3(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000307B8 File Offset: 0x0002EBB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RauNemlfTCdy5OlRT9k(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Columns;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000307D4 File Offset: 0x0002EBD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oEIu1GlpwYp28C0nNqH(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Add(A_1);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000307F4 File Offset: 0x0002EBF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RuntimeTypeHandle O88pWZlOKa3gxPRf7ID(int token)
		{
			while (false)
			{
				object obj = null[0];
			}
			return nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(token);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00030810 File Offset: 0x0002EC10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type NIdqpBlD9NIGUul7plm(RuntimeTypeHandle A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0003082C File Offset: 0x0002EC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fn6o9UlUDSPAncnSR2K(object A_0, object A_1, Type A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Add(A_1, A_2);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00030850 File Offset: 0x0002EC50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool woBBQHlNPqnbmgFGUYy()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00030864 File Offset: 0x0002EC64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LeYg67lSeyEyv7mLyx1()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00030878 File Offset: 0x0002EC78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xXOS12lJhdhvGAKnLIG(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Rows;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00030894 File Offset: 0x0002EC94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FaBscOlIwhn0V7ZdZ78(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0[A_1] = A_2;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000308B8 File Offset: 0x0002ECB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fURaU3lZkhVQv7GUQxy(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Add(A_1);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000308D8 File Offset: 0x0002ECD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object X9maiNlcRdcLZm8Mv1e(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.InnerXml;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000308F4 File Offset: 0x0002ECF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qHZZyZlzdLdFkag1L9M(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00030914 File Offset: 0x0002ED14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void flbh0U73pKMv01TxQnb(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.EndEdit();
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00030930 File Offset: 0x0002ED30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x16aux7WOdpnNlVGMpH(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.UpdateSqlData(A_1);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00030950 File Offset: 0x0002ED50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ljJUHw7LHJUVbVyFCsN(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Close();
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0003096C File Offset: 0x0002ED6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object E7M5Mk7jbwgNgPjWy8L(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.AppendChild(A_1);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0003098C File Offset: 0x0002ED8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object w7A3Bc7X3DXTVLO02Fh(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.CreateElement(A_1);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000309AC File Offset: 0x0002EDAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xgh1Le7r9ciS8nMCteJ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.CreateAttribute(A_1);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000309CC File Offset: 0x0002EDCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KpA88j7nvkmmYrRpTnl(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Attributes;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000309E8 File Offset: 0x0002EDE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FeoinD727vyYPr15E01(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Append(A_1);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00030A08 File Offset: 0x0002EE08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YuHymu7TprrBvBWFHO9(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Text;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00030A24 File Offset: 0x0002EE24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YXQSm47Hh333PMgh1vq(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Value = A_1;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00030A44 File Offset: 0x0002EE44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static decimal ItbU5B7lxayHJ134dAY(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00030A60 File Offset: 0x0002EE60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static decimal XsH0av77okxHFlwDrxG(decimal A_0, decimal A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 * A_1;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00030A80 File Offset: 0x0002EE80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WRdtFB7QCbjdRjEXiK2(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Checked;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00030A9C File Offset: 0x0002EE9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XVioqh71ooDBkWr0LGp(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Checked;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00030AB8 File Offset: 0x0002EEB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QOYq3R7G5GT1gGoseHy(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00030AD8 File Offset: 0x0002EED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qcHA1274BdBGHpvwKe5(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Cells;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00030AF4 File Offset: 0x0002EEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object w49Hej7tUiIXyogdY9Y(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00030B10 File Offset: 0x0002EF10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Nf2Tal7w6IL4eslCDgJ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Rows;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00030B2C File Offset: 0x0002EF2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ojruD97VH83tKclqQGX(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00030B48 File Offset: 0x0002EF48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XSID0X7kflnSLhmBqAO(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.InnerText = A_1;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00030B68 File Offset: 0x0002EF68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UNqt5N7ddWoBHBO1RFd(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00030B88 File Offset: 0x0002EF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object V3kd5o7bC9JxPmM24jB(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SelectSingleNode(A_1);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00030BA8 File Offset: 0x0002EFA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pLKsRy7Fkb7OixyahVV(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00030BC8 File Offset: 0x0002EFC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ItknuK7P9upnqrZ26lQ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00030BE4 File Offset: 0x0002EFE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PcqABe7mBEg9uMisXOp(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Text = A_1;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00030C04 File Offset: 0x0002F004
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void w3qYf77g68Y8YFh41Xg(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Checked = A_1;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00030C24 File Offset: 0x0002F024
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void t2qQXa7RSpNwp6MLCjU(object A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Value = A_1;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00030C44 File Offset: 0x0002F044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DaX7XE7EPNsCB4U38gt(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Checked = A_1;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00030C64 File Offset: 0x0002F064
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fIisxl7K3edl4lv7FCe(object A_0, decimal A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Value = A_1;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00030C84 File Offset: 0x0002F084
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static decimal EIK4YG79QmXyfim0J4X(int A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00030CA0 File Offset: 0x0002F0A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int PsZkqu7isn8ONajJOEo(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToInt32(A_0);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00030CBC File Offset: 0x0002F0BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nJKj6r7eeS2eR1oXRDx(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.IsNullOrEmpty(A_0);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00030CD8 File Offset: 0x0002F0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fpheGP7MwMypPwbFFRV(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SelectNodes(A_1);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00030CF8 File Offset: 0x0002F0F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Ekkrg375y78ECMA89Xg(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Add(A_1);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00030D18 File Offset: 0x0002F118
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C0XbYO7vdsTJy6ZHmFi(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToBoolean(A_0);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00030D34 File Offset: 0x0002F134
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void N0KGSR7CmQbtQkOuavN(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Filter = A_1;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00030D54 File Offset: 0x0002F154
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cmAiYe70EqkV1DNjDVm(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Enabled = A_1;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00030D74 File Offset: 0x0002F174
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void frr6387xojQ0sUepqE3(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CheckFileExists = A_1;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00030D94 File Offset: 0x0002F194
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void is0AIk7hTRWrLKAbmp2(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CheckPathExists = A_1;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00030DB4 File Offset: 0x0002F1B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QNfjPw7opZGMPwc1DQD(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.FileName = A_1;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00030DD4 File Offset: 0x0002F1D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DialogResult l4kdt37YKmJrm2FE3LZ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.ShowDialog();
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00030DF0 File Offset: 0x0002F1F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zL9fYo7u6ZEBItea0pv(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Path.GetFileName(A_0);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00030E0C File Offset: 0x0002F20C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qVDpSE7aBBxSjsf5x9K(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ShowNewFolderButton = A_1;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00030E2C File Offset: 0x0002F22C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M46IyA7q2q8oH7Dqw9f(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.FileName;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00030E48 File Offset: 0x0002F248
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ATB4gv78dT3WYxfIT7f(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Dispose(A_1);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00030E68 File Offset: 0x0002F268
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VB1eni7BYS0IAa2W7Y3(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SuspendLayout();
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00030E84 File Offset: 0x0002F284
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FlfPRm7yRkFgaIbtA38(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((ISupportInitialize)A_0).BeginInit();
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00030EA0 File Offset: 0x0002F2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ck0dpI76MVFS6jY3FAJ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SuspendLayout();
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00030EBC File Offset: 0x0002F2BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void l868Y97N7LycF6Gewhl(object A_0, Size A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Size = A_1;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00030EDC File Offset: 0x0002F2DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hgMvK27S4jIaSsrJRSe(object A_0, Point A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Location = A_1;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00030EFC File Offset: 0x0002F2FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yMQ2ht7AeEPSmNYoCin(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00030F1C File Offset: 0x0002F31C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PbhVmS7s79a1rMRUZ7Z(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TabIndex = A_1;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00030F3C File Offset: 0x0002F33C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HGTwbu7fTA7oUZBS4hr(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoSize = A_1;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00030F5C File Offset: 0x0002F35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void a5dFbu7pKVZp0o5xCuJ(object A_0, DialogResult A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DialogResult = A_1;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00030F7C File Offset: 0x0002F37C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aVmWoR7OI3T0fvH1Qo3(object A_0, AnchorStyles A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Anchor = A_1;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00030F9C File Offset: 0x0002F39C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kPPNYg7DiIkGcumpR1Q(object A_0, char A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.PasswordChar = A_1;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00030FBC File Offset: 0x0002F3BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kdX8WX7U81tGvrkHnKB(object A_0, CheckState A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CheckState = A_1;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00030FDC File Offset: 0x0002F3DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ajYvCc7Jj0IrFWyOjbb(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Controls;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00030FF8 File Offset: 0x0002F3F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jQhDjm7IOShbbhqN09n(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Add(A_1);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00031018 File Offset: 0x0002F418
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KspF5I7ZxRCAT5FyhFt(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SelectedIndex = A_1;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00031038 File Offset: 0x0002F438
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zd2R9c7cDNd2CCvYgps(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TabStop = A_1;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00031058 File Offset: 0x0002F458
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iueI1O7zei1FfvvvnTN(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.UseVisualStyleBackColor = A_1;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00031078 File Offset: 0x0002F478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lrtNSPQ3noEJAFCknbu(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CheckedChanged += A_1;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00031098 File Offset: 0x0002F498
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object T6gpUUQW1NXI9SHNJd0()
		{
			while (false)
			{
				object obj = null[0];
			}
			return Cursors.Default;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000310B0 File Offset: 0x0002F4B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pIVda4QLH0ExWLW9aMh(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CustomFormat = A_1;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000310D0 File Offset: 0x0002F4D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VyJpbZQjUSkwjq60Upw(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Click += A_1;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000310F0 File Offset: 0x0002F4F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eXV7QnQX0eXa7rMxSw9(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CheckedChanged += A_1;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00031110 File Offset: 0x0002F510
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void i3RULhQr08BQgWwy7eK(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TabIndex = A_1;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00031130 File Offset: 0x0002F530
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void w9RJVNQnsTamvfLCqL8(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TabStop = A_1;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00031150 File Offset: 0x0002F550
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void G4Iig7Q2aBo1eTwJVHC(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Cursor = A_1;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00031170 File Offset: 0x0002F570
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void u0PDuvQT7PRgLGdKg5n(object A_0, DateTimePickerFormat A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Format = A_1;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00031190 File Offset: 0x0002F590
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uXtTtMQH8bb0JL7VDS6(object A_0, Color A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.BackgroundColor = A_1;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000311B0 File Offset: 0x0002F5B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iROiZuQl2M3vAUfGCGr(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.HeaderText = A_1;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000311D0 File Offset: 0x0002F5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UVUaldQ7OAJRFLQFyA1(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000311F0 File Offset: 0x0002F5F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void crB7uDQQR3ZyQaUHVTC(object A_0, Color A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.BackColor = A_1;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00031210 File Offset: 0x0002F610
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RwtMRdQ18rfAQcoTY13(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.UseVisualStyleBackColor = A_1;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00031230 File Offset: 0x0002F630
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fFxyHRQGPxlsfvDSPrM(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.CancelButton = A_1;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00031250 File Offset: 0x0002F650
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yEOaggQ4Wyf0M0MIsGW(object A_0, Size A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ClientSize = A_1;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00031270 File Offset: 0x0002F670
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FOqQ1fQtroQiwvONbQI(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Controls;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0003128C File Offset: 0x0002F68C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BeZfpvQwShXBF4BZ3DN(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Icon = A_1;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000312AC File Offset: 0x0002F6AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void InXaCTQVqk24Rk49ZhC(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000312CC File Offset: 0x0002F6CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XJ6p40Qk4MsHGK6TMp8(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.FormClosing += A_1;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000312EC File Offset: 0x0002F6EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aP7jyVQdE12x46GEH3o(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.PerformLayout();
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00031308 File Offset: 0x0002F708
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QDAcsHQbdbQhTVYoY5k(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((ISupportInitialize)A_0).EndInit();
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00031324 File Offset: 0x0002F724
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void veqap3QFf2rp3lwc2VY(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x0400016E RID: 366
		private DataTable ttNoRVnVea;

		// Token: 0x04000170 RID: 368
		private TextBox seDoXeDyD6;

		// Token: 0x04000171 RID: 369
		private Label TTQoqFuIwn;

		// Token: 0x04000172 RID: 370
		private TextBox qsfomPxWc6;

		// Token: 0x04000173 RID: 371
		private Label TtgosTTpwA;

		// Token: 0x04000174 RID: 372
		private Label cNGo7HW9hU;

		// Token: 0x04000175 RID: 373
		private TextBox MRFoaqvscI;

		// Token: 0x04000176 RID: 374
		private Label O0No1JqLOd;

		// Token: 0x04000177 RID: 375
		private Button MQBoO75tUr;

		// Token: 0x04000178 RID: 376
		private Button xFqoLJhJ3c;

		// Token: 0x04000179 RID: 377
		private MaskedTextBox LirovRKmrk;

		// Token: 0x0400017A RID: 378
		private CheckBox sQVo4WFoAX;

		// Token: 0x0400017B RID: 379
		private TextBox RJXoB6SooV;

		// Token: 0x0400017C RID: 380
		private TextBox OxNolWaRba;

		// Token: 0x0400017D RID: 381
		private Label pgWoP9MDb0;

		// Token: 0x0400017E RID: 382
		private Label CP5oww8CcY;

		// Token: 0x0400017F RID: 383
		private MaskedTextBox QZlo5bclsp;

		// Token: 0x04000180 RID: 384
		private CheckBox fwro9xuoth;

		// Token: 0x04000181 RID: 385
		private TabControl TZ3o2TsyGe;

		// Token: 0x04000182 RID: 386
		private TabPage QpVoAeQsKr;

		// Token: 0x04000183 RID: 387
		private TabPage rxVoVarjxq;

		// Token: 0x04000184 RID: 388
		private Label GFwoKrhy3e;

		// Token: 0x04000185 RID: 389
		private TextBox W85oQ1v70T;

		// Token: 0x04000186 RID: 390
		private Button XdsoSFJILo;

		// Token: 0x04000187 RID: 391
		private Button KROokpgJ7h;

		// Token: 0x04000188 RID: 392
		private Label wiPofGeZmM;

		// Token: 0x04000189 RID: 393
		private TextBox BTfo6OSA71;

		// Token: 0x0400018A RID: 394
		private Button xWyoTABNxr;

		// Token: 0x0400018B RID: 395
		private GroupBox ETVodSvqVE;

		// Token: 0x0400018C RID: 396
		private RadioButton SYeoUtOBCc;

		// Token: 0x0400018D RID: 397
		private RadioButton kueotpDpaa;

		// Token: 0x0400018E RID: 398
		private RadioButton JxmoDovFMO;

		// Token: 0x0400018F RID: 399
		private Label Dp4ocPU9xO;

		// Token: 0x04000190 RID: 400
		private DateTimePicker Yu2opE9oes;

		// Token: 0x04000191 RID: 401
		private Label eQkoWFEuy3;

		// Token: 0x04000192 RID: 402
		private NumericUpDown TW4oHbeOyt;

		// Token: 0x04000193 RID: 403
		private NumericUpDown VP8oFnf2vS;

		// Token: 0x04000194 RID: 404
		private NumericUpDown d5YoxAPEep;

		// Token: 0x04000195 RID: 405
		private GroupBox CsSoyQ0k8a;

		// Token: 0x04000196 RID: 406
		private NumericUpDown EUVortqIPp;

		// Token: 0x04000197 RID: 407
		private NumericUpDown r6JoiXY9j1;

		// Token: 0x04000198 RID: 408
		private NumericUpDown gO0oYQ1dHf;

		// Token: 0x04000199 RID: 409
		private RadioButton HQIoG7WF2l;

		// Token: 0x0400019A RID: 410
		private RadioButton ix2oj2wknM;

		// Token: 0x0400019B RID: 411
		private RadioButton mtIob811iE;

		// Token: 0x0400019C RID: 412
		private Label XqioNGM8Cw;

		// Token: 0x0400019D RID: 413
		private DateTimePicker jVhoE67YN1;

		// Token: 0x0400019E RID: 414
		private Label tEnohFlmXB;

		// Token: 0x0400019F RID: 415
		private Button erfozvOXLo;

		// Token: 0x040001A0 RID: 416
		private Button IaLuZm7bBZ;

		// Token: 0x040001A1 RID: 417
		private Label tbZu3Icliq;

		// Token: 0x040001A2 RID: 418
		private TextBox fl1uIcLa7X;

		// Token: 0x040001A3 RID: 419
		private CheckBox RxPugvS30O;

		// Token: 0x040001A4 RID: 420
		private TextBox zgCueCPULg;

		// Token: 0x040001A5 RID: 421
		private MaskedTextBox XGLundBwE3;

		// Token: 0x040001A6 RID: 422
		private Label So1uJZT4cL;

		// Token: 0x040001A7 RID: 423
		private Label IZmu0YbMol;

		// Token: 0x040001A8 RID: 424
		private TextBox pBYuomHju0;

		// Token: 0x040001A9 RID: 425
		private Label CYSuurvDt0;

		// Token: 0x040001AA RID: 426
		private Label mAiuMPamrf;

		// Token: 0x040001AB RID: 427
		private TextBox WXUu8KMxpD;

		// Token: 0x040001AC RID: 428
		private Label lJVuRnxP7w;

		// Token: 0x040001AD RID: 429
		private TextBox x2auCffKij;

		// Token: 0x040001AE RID: 430
		private TextBox Uc8uXeCNrg;

		// Token: 0x040001AF RID: 431
		private CheckBox zeeuq1NopM;

		// Token: 0x040001B0 RID: 432
		private Label hASumvj8Xo;

		// Token: 0x040001B1 RID: 433
		private MaskedTextBox S82usbI3X8;

		// Token: 0x040001B2 RID: 434
		private TabPage u4Du7XmSxq;

		// Token: 0x040001B3 RID: 435
		private Button duquaoP6wR;

		// Token: 0x040001B4 RID: 436
		private TextBox v73u14AJPD;

		// Token: 0x040001B5 RID: 437
		private Label gxhuOAdBsA;

		// Token: 0x040001B6 RID: 438
		private CheckBox w86uLOZ6Cn;

		// Token: 0x040001B7 RID: 439
		private GroupBox imYuv0vN9Y;

		// Token: 0x040001B8 RID: 440
		private Label U7mu4Bv5u2;

		// Token: 0x040001B9 RID: 441
		private TextBox tguuBT2lFE;

		// Token: 0x040001BA RID: 442
		private Label HMGulNhMFS;

		// Token: 0x040001BB RID: 443
		private TextBox Tx3uPcd9UZ;

		// Token: 0x040001BC RID: 444
		private Label WIGuw1gKA0;

		// Token: 0x040001BD RID: 445
		private NumericUpDown n2Hu5bSws2;

		// Token: 0x040001BE RID: 446
		private Label MT3u9a8ZKO;

		// Token: 0x040001BF RID: 447
		private TextBox UXYu2ec0FP;

		// Token: 0x040001C0 RID: 448
		private GroupBox xqFuAPgtM2;

		// Token: 0x040001C1 RID: 449
		private Label UYLuVoQJQT;

		// Token: 0x040001C2 RID: 450
		private TextBox Rg2uKLCjMO;

		// Token: 0x040001C3 RID: 451
		private Label YLFuQV45Zb;

		// Token: 0x040001C4 RID: 452
		private TextBox pLtuSNtbly;

		// Token: 0x040001C5 RID: 453
		private Label nUDukruyZg;

		// Token: 0x040001C6 RID: 454
		private GroupBox caWufkkLNs;

		// Token: 0x040001C7 RID: 455
		private NumericUpDown ehYu6sgrZp;

		// Token: 0x040001C8 RID: 456
		private NumericUpDown k71uT9NO8T;

		// Token: 0x040001C9 RID: 457
		private NumericUpDown m0uudPYZpX;

		// Token: 0x040001CA RID: 458
		private RadioButton x2juUJENsT;

		// Token: 0x040001CB RID: 459
		private RadioButton LADutCXOdb;

		// Token: 0x040001CC RID: 460
		private RadioButton g4wuDPMX6y;

		// Token: 0x040001CD RID: 461
		private Label oUruc1YLci;

		// Token: 0x040001CE RID: 462
		private DateTimePicker OimupDkga9;

		// Token: 0x040001CF RID: 463
		private Label T7FuWmRc4m;

		// Token: 0x040001D0 RID: 464
		private Label Nc1uHCgyoZ;

		// Token: 0x040001D1 RID: 465
		private TextBox w5TuFUb2jt;

		// Token: 0x040001D2 RID: 466
		private Label KTTuxidVAT;

		// Token: 0x040001D3 RID: 467
		private TextBox KUNuypHcpG;

		// Token: 0x040001D4 RID: 468
		private DataGridView dshursBUcC;

		// Token: 0x040001D5 RID: 469
		private DataGridViewTextBoxColumn v51uidnQU1;

		// Token: 0x040001D6 RID: 470
		private DataGridViewTextBoxColumn RaHuYYIwGE;

		// Token: 0x040001D7 RID: 471
		private TabPage DoEuGfHpCZ;

		// Token: 0x040001D8 RID: 472
		private CheckBox LrfujmRk7x;
	}
}
