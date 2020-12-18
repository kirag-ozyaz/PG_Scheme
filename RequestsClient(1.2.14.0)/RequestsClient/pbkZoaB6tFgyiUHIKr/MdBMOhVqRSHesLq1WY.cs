using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using DataSql;
using HsEXfKsq15GfPw4kPLQ;
using j5c8XXscsIc6vD2Fg4l;
using S1vCqGe6FZFwjOZ7Cb;
using WTbxUfsXa34kJl1qKMV;

namespace pbkZoaB6tFgyiUHIKr
{
	// Token: 0x0200007B RID: 123
	internal static class MdBMOhVqRSHesLq1WY
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x00033684 File Offset: 0x00031A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DataTable oD0MxxmH2n(SQLSettings \u0020, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			string text2;
			string text4;
			DataTable dataTable;
			SqlConnection sqlConnection;
			for (;;)
			{
				switch (num)
				{
				case 0:
				{
					string text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(11374) + \u0020.Date.ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(1160)) + cDhluYseFOthxgEIXpc.nKHKpgTSVU(44114);
					string text3;
					text2 = MdBMOhVqRSHesLq1WY.iJud5V1tyondrKn6WH2(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44138), text3, text);
					MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn();
					num = ((!MdBMOhVqRSHesLq1WY.SKdPKk1QLOrJqX9hlji()) ? 1 : 5);
					continue;
				}
				case 2:
				case 5:
					text4 = MdBMOhVqRSHesLq1WY.M5h95p1GRt6oR6xs7XC(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44278), MdBMOhVqRSHesLq1WY.J5QME64TYL.ToString(), cDhluYseFOthxgEIXpc.nKHKpgTSVU(44312));
					break;
				case 4:
				{
					string text3 = MdBMOhVqRSHesLq1WY.M5h95p1GRt6oR6xs7XC(cDhluYseFOthxgEIXpc.nKHKpgTSVU(11374), \u0020.Date.ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(1160)), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11374));
					num = 0;
					if (!false)
					{
						continue;
					}
					break;
				}
				case 6:
					goto IL_13D;
				}
				IL_11F:
				string connectionString = \u0020.GetConnectionString();
				dataTable = new DataTable();
				sqlConnection = new SqlConnection(connectionString);
				num = 6;
				continue;
				goto IL_11F;
			}
			try
			{
				IL_13D:
				MdBMOhVqRSHesLq1WY.Ct1WEY1wOXCt80P2Lxs(sqlConnection);
				MdBMOhVqRSHesLq1WY.S2qTqL1k4WXXF67enkV(new SqlDataAdapter(MdBMOhVqRSHesLq1WY.kqMiJv1VNplQWH4Aeuj(new string[]
				{
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44320),
					text2,
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44414),
					text4,
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44428)
				}), sqlConnection), dataTable);
			}
			catch (Exception ex)
			{
				throw new Exception(MdBMOhVqRSHesLq1WY.yur86q1declm67Ic6RQ(ex), MdBMOhVqRSHesLq1WY.OJalwC1bbmeypZvHGle(ex));
			}
			return dataTable;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0003384C File Offset: 0x00031C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void jwIMyrWuH9(string \u0020, StringBuilder \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			try
			{
				File.Delete(\u0020);
				StreamWriter streamWriter = new StreamWriter(\u0020, true, Encoding.GetEncoding(1251));
				MdBMOhVqRSHesLq1WY.e7N48m1FBRT8SHF6H4y(streamWriter, \u0020.ToString());
				streamWriter.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex.InnerException);
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000338B8 File Offset: 0x00031CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GkxMrR09of(SQLSettings \u0020, string \u0020, DateTime \u0020)
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
			StringBuilder stringBuilder;
			for (;;)
			{
				IL_89C:
				int num2;
				List<string> list;
				string text;
				int num4;
				int num3;
				string text2;
				DataRow dataRow;
				DataRow dataRow2;
				DataTable dataTable;
				int num5;
				string text5;
				switch (num)
				{
				case 0:
					num2++;
					num = 22;
					continue;
				case 1:
					goto IL_1A;
				case 2:
					if (MdBMOhVqRSHesLq1WY.ItTKhF1KifJNUY14T7V(list) > 1 && list.Contains(""))
					{
						list.Remove("");
					}
					list.Sort();
					text = MdBMOhVqRSHesLq1WY.d2LxWM1iUmfdDjy6D1W(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46696), MdBMOhVqRSHesLq1WY.hmSvOs19l49ianT5FeG(list));
					text = text.Replace(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10764), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
					num = 27;
					continue;
				case 3:
					goto IL_3DB;
				case 4:
					num3 = num4;
					num2 = 0;
					goto IL_C49;
				case 5:
					stringBuilder = new StringBuilder();
					num = 30;
					continue;
				case 6:
					num3 = num4;
					num2 = 0;
					break;
				case 7:
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.kqMiJv1VNplQWH4Aeuj(new string[]
					{
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46772),
						text2,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46806),
						Convert.ToDateTime(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)]).ToShortTimeString(),
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46660)
					}));
					stringBuilder.Append(string.Concat(new string[]
					{
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46772),
						text2,
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46806),
						Convert.ToDateTime(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840)]).Date.ToShortDateString(),
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46660)
					}));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.kqMiJv1VNplQWH4Aeuj(new string[]
					{
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46772),
						text2,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46806),
						Convert.ToDateTime(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840)]).ToShortTimeString(),
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46660)
					}));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					num2++;
					goto IL_C49;
				case 8:
				{
					string str = MdBMOhVqRSHesLq1WY.UN0MYbK9CK(dataRow2[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(1054)].ToString());
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46322) + str + MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46452));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					goto IL_36F;
				}
				case 9:
					dataTable = MdBMOhVqRSHesLq1WY.oD0MxxmH2n(\u0020, \u0020);
					num5 = -1;
					num = 23;
					continue;
				case 10:
				{
					string text3;
					string text4;
					if (dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8300)] != DBNull.Value)
					{
						text3 = Convert.ToDateTime(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8300))).Date.ToShortDateString();
						text4 = Convert.ToDateTime(dataRow2[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(8300)]).ToShortTimeString();
					}
					stringBuilder.Append(string.Concat(new string[]
					{
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46772),
						text2,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46606),
						(num2 + 1).ToString(),
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46628),
						text3,
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46660)
					}));
					stringBuilder.Append(string.Concat(new string[]
					{
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46772),
						text2,
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46606),
						(num2 + 1).ToString(),
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46628),
						text4,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46660)
					}));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(45124));
					num = 4;
					continue;
				}
				case 11:
				{
					string str2 = str2 + cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458) + dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)].ToString();
					string str3 = str3 + MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(8458) + dataRow2[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46296)].ToString();
					num = 0;
					continue;
				}
				case 12:
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(45338));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45490));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45652));
					num = 18;
					continue;
				case 13:
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46866));
					num = 37;
					if (!true)
					{
						goto IL_3AD;
					}
					continue;
				case 14:
					goto IL_22F;
				case 15:
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46880));
					num = 31;
					if (!true)
					{
						goto IL_2A7;
					}
					continue;
				case 16:
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46138));
					num = 28;
					if (!MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn())
					{
						continue;
					}
					continue;
				case 17:
					text5 = MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39194)).ToString();
					goto IL_D42;
				case 18:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45836));
					num = 25;
					continue;
				case 19:
					if (!string.IsNullOrEmpty(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39194)].ToString()))
					{
						num = 17;
						continue;
					}
					goto IL_D38;
				case 20:
					goto IL_2A7;
				case 21:
				{
					IL_79:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
					text2 = "";
					if (MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow2, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(8300)) != DBNull.Value)
					{
						text2 = MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46488);
					}
					string text6 = MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow2, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46524)).ToString();
					text6 = MdBMOhVqRSHesLq1WY.rDG1V91EoaF7ncQ6PNR(text6, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10764), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
					text6 = text6.Replace(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46542), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.kqMiJv1VNplQWH4Aeuj(new string[]
					{
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46552),
						text2,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46606),
						(num2 + 1).ToString(),
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46628),
						text6,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46660)
					}));
					if (dataRow2[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(39194)] != DBNull.Value)
					{
						num = 19;
						continue;
					}
					goto IL_D38;
				}
				case 22:
					break;
				case 23:
					num4 = 0;
					goto IL_233;
				case 24:
					if (Convert.ToInt32(dataRow2[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(6146)]) == MdBMOhVqRSHesLq1WY.w2kRM31R7fESmIjZqsC(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(MdBMOhVqRSHesLq1WY.xGfH3c1MopY3pZPLkQ9(MdBMOhVqRSHesLq1WY.vtv7Eq1glXsYLnBOEfL(dataTable), num3), cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146))))
					{
						dataRow = MdBMOhVqRSHesLq1WY.xGfH3c1MopY3pZPLkQ9(MdBMOhVqRSHesLq1WY.vtv7Eq1glXsYLnBOEfL(dataTable), num3);
						num = 13;
						continue;
					}
					goto IL_6EF;
				case 25:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44856));
					num = 20;
					continue;
				case 26:
				case 29:
				{
					stringBuilder.Append(string.Concat(new string[]
					{
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46772),
						text2,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46806),
						Convert.ToDateTime(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840)]).ToShortTimeString(),
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46660)
					}));
					string text3 = "";
					string text4 = "";
					num = 10;
					continue;
				}
				case 27:
					text = MdBMOhVqRSHesLq1WY.rDG1V91EoaF7ncQ6PNR(text, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46542), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.kqMiJv1VNplQWH4Aeuj(new string[]
					{
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46708),
						text2,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46748),
						(num2 + 1).ToString(),
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46628),
						text,
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46660)
					}));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, string.Concat(new string[]
					{
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46772),
						text2,
						cDhluYseFOthxgEIXpc.nKHKpgTSVU(46806),
						MdBMOhVqRSHesLq1WY.u2qFGu1ertOuH5b3VMi(dataRow2[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46270)]).Date.ToShortDateString(),
						MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46660)
					}));
					num = 3;
					continue;
				case 28:
					goto IL_5E;
				case 30:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44618));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44636));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(44654));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(44690));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(44756));
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44776));
					num = 36;
					continue;
				case 31:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46902));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46922));
					MdBMOhVqRSHesLq1WY.jwIMyrWuH9(\u0020, stringBuilder);
					num = 38;
					if (!true)
					{
						goto IL_CAA;
					}
					continue;
				case 32:
					goto IL_3AD;
				case 33:
					IL_6F4:
					goto IL_22F;
				case 34:
					goto IL_36F;
				case 35:
				{
					string str2 = MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)).ToString();
					string str3 = MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46296)).ToString();
					num = 6;
					continue;
				}
				case 36:
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44794));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
					num = 1;
					continue;
				case 37:
					goto IL_CAA;
				case 38:
					return;
				default:
					num = 34;
					continue;
				}
				num3++;
				if (num3 < MdBMOhVqRSHesLq1WY.vtv7Eq1glXsYLnBOEfL(dataTable).Count && Convert.ToInt32(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146)]) == Convert.ToInt32(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataTable.Rows[num3], cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146))))
				{
					num = 11;
					continue;
				}
				if (num5 != MdBMOhVqRSHesLq1WY.w2kRM31R7fESmIjZqsC(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)]))
				{
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
					num = 8;
					continue;
				}
				goto IL_79;
				IL_233:
				if (num4 >= MdBMOhVqRSHesLq1WY.N0dqAK15aGeOLu4vt0t(dataTable.Rows))
				{
					num = 15;
					continue;
				}
				dataRow2 = dataTable.Rows[num4];
				num = 35;
				continue;
				IL_22F:
				num4++;
				goto IL_233;
				IL_6EF:
				num4 += num2;
				goto IL_6F4;
				IL_C49:
				num3++;
				if (num3 >= MdBMOhVqRSHesLq1WY.vtv7Eq1glXsYLnBOEfL(dataTable).Count)
				{
					goto IL_6EF;
				}
				num = 24;
				if (!MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn())
				{
					continue;
				}
				continue;
				IL_2A7:
				stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46008));
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46138));
				MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46008));
				stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46138));
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46008));
				num = 16;
				continue;
				IL_36F:
				num5 = MdBMOhVqRSHesLq1WY.w2kRM31R7fESmIjZqsC(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)));
				num = 21;
				continue;
				IL_3AD:
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
				stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(45140));
				num = 12;
				if (!false)
				{
					continue;
				}
				IL_3DB:
				MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, string.Concat(new string[]
				{
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(46772),
					text2,
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(46806),
					MdBMOhVqRSHesLq1WY.u2qFGu1ertOuH5b3VMi(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)]).ToShortTimeString(),
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(46660)
				}));
				stringBuilder.Append(string.Concat(new string[]
				{
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46772),
					text2,
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46806),
					MdBMOhVqRSHesLq1WY.u2qFGu1ertOuH5b3VMi(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840))).Date.ToShortDateString(),
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46660)
				}));
				num = ((!MdBMOhVqRSHesLq1WY.SKdPKk1QLOrJqX9hlji()) ? 14 : 29);
				continue;
				IL_CAA:
				MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.kqMiJv1VNplQWH4Aeuj(new string[]
				{
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46772),
					text2,
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46806),
					Convert.ToDateTime(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270))).Date.ToShortDateString(),
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46660)
				}));
				num = 7;
				continue;
				IL_D42:
				text = text5;
				list = text.Split(new string[]
				{
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(11572)
				}, StringSplitOptions.None).ToList<string>();
				num = 2;
				continue;
				IL_D38:
				text5 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(46680);
				goto IL_D42;
			}
			return;
			IL_1A:
			stringBuilder.Append(MdBMOhVqRSHesLq1WY.M5h95p1GRt6oR6xs7XC(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44870), \u0020.ToShortDateString(), MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(45084)));
			stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
			num = 32;
			if (!false)
			{
				goto IL_89C;
			}
			IL_5E:
			MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(45124));
			num = 9;
			goto IL_89C;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00034638 File Offset: 0x00032A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rFPMi4NUv0(SQLSettings \u0020, string \u0020, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			for (;;)
			{
				StringBuilder stringBuilder;
				DateTime dateTime;
				string text;
				DataRow dataRow;
				int num2;
				int num3;
				List<string> list;
				DataTable dataTable;
				int num5;
				int num4;
				string text5;
				string text6;
				string str12;
				switch (num)
				{
				case 0:
					goto IL_81C;
				case 1:
					goto IL_17C;
				case 2:
					goto IL_85F;
				case 3:
					goto IL_3D0;
				case 4:
					break;
				case 5:
					stringBuilder = new StringBuilder();
					num = 0;
					if (!MdBMOhVqRSHesLq1WY.SKdPKk1QLOrJqX9hlji())
					{
						return;
					}
					continue;
				case 6:
					goto IL_76C;
				case 7:
					IL_9B:
					dateTime = dateTime.Date;
					text = dateTime.ToShortDateString();
					dateTime = Convert.ToDateTime(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8300)]);
					num = 2;
					continue;
				case 8:
				case 18:
					num2 = -1;
					num = 9;
					continue;
				case 9:
					goto IL_F3;
				case 10:
					goto IL_103;
				case 11:
					num3 = 0;
					goto IL_40A;
				case 12:
					IL_59:
					if (!list.Contains(""))
					{
						goto IL_76C;
					}
					list.Remove("");
					num = 6;
					if (false)
					{
						goto IL_83;
					}
					continue;
				case 13:
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46880));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(52766));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(52952));
					dataTable = MdBMOhVqRSHesLq1WY.BHfTv01vdOjft2fDd4b(\u0020, \u0020);
					MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn();
					if (!MdBMOhVqRSHesLq1WY.SKdPKk1QLOrJqX9hlji())
					{
						num = 21;
						continue;
					}
					num = 18;
					if (MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn())
					{
						goto IL_8DE;
					}
					continue;
				case 14:
				{
					string text2;
					string str = text2;
					string str2 = MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46696);
					DataRow dataRow2;
					dateTime = Convert.ToDateTime(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840)]);
					text2 = str + str2 + dateTime.ToShortTimeString();
					num3++;
					num = 35;
					continue;
				}
				case 15:
				{
					string text3 = "";
					string text4 = "";
					string text2 = "";
					num4 = num5;
					num = 11;
					continue;
				}
				case 16:
					goto IL_8DE;
				case 17:
					if (!string.IsNullOrEmpty(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39194)).ToString()))
					{
						text5 = dataRow[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(39194)].ToString();
						goto IL_56F;
					}
					goto IL_565;
				case 19:
					goto IL_480;
				case 20:
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(52042));
					num = 13;
					continue;
				case 21:
					goto IL_13F;
				case 22:
					num5++;
					goto IL_284;
				case 23:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46922));
					MdBMOhVqRSHesLq1WY.jwIMyrWuH9(\u0020, stringBuilder);
					num = 36;
					if (!true)
					{
						goto IL_480;
					}
					continue;
				case 24:
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44856));
					num = 20;
					continue;
				case 25:
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(51386));
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					num = 24;
					continue;
				case 26:
				{
					string str3 = MdBMOhVqRSHesLq1WY.PeVALf1C0ib3C4eCfD5(dataRow[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(1054)].ToString());
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(53224) + str3 + cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					num2 = MdBMOhVqRSHesLq1WY.w2kRM31R7fESmIjZqsC(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)));
					goto IL_987;
				}
				case 27:
					goto IL_83;
				case 28:
					stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53674));
					num = 30;
					continue;
				case 29:
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(50864));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					num = 32;
					if (!MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn())
					{
						continue;
					}
					break;
				case 30:
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46880));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46902));
					num = 23;
					if (false)
					{
						goto IL_81C;
					}
					continue;
				case 31:
				{
					string str4 = MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46296)).ToString();
					num = 27;
					if (false)
					{
						goto IL_F3;
					}
					continue;
				}
				case 32:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
					num = 25;
					continue;
				case 33:
				{
					if (num4 < dataTable.Rows.Count && MdBMOhVqRSHesLq1WY.w2kRM31R7fESmIjZqsC(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146)]) == MdBMOhVqRSHesLq1WY.w2kRM31R7fESmIjZqsC(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(MdBMOhVqRSHesLq1WY.xGfH3c1MopY3pZPLkQ9(dataTable.Rows, num4), MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(6146))))
					{
						DataRow dataRow2 = MdBMOhVqRSHesLq1WY.xGfH3c1MopY3pZPLkQ9(dataTable.Rows, num4);
						string str5 = text6;
						string str6 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(46696);
						dateTime = Convert.ToDateTime(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)]);
						dateTime = dateTime.Date;
						text6 = str5 + str6 + dateTime.ToShortDateString();
						string text4;
						string str7 = text4;
						string str8 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(46696);
						dateTime = MdBMOhVqRSHesLq1WY.u2qFGu1ertOuH5b3VMi(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)]);
						text4 = str7 + str8 + dateTime.ToShortTimeString();
						string text3;
						object obj2 = text3;
						object obj3 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(46696);
						dateTime = Convert.ToDateTime(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840)]);
						dateTime = dateTime.Date;
						text3 = MdBMOhVqRSHesLq1WY.M5h95p1GRt6oR6xs7XC(obj2, obj3, dateTime.ToShortDateString());
						num = 14;
						continue;
					}
					StringBuilder stringBuilder2 = stringBuilder;
					string str9 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(53438);
					dateTime = MdBMOhVqRSHesLq1WY.u2qFGu1ertOuH5b3VMi(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)));
					dateTime = dateTime.Date;
					stringBuilder2.Append(str9 + dateTime.ToShortDateString() + text6 + cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458));
					num = 34;
					continue;
				}
				case 34:
				{
					StringBuilder stringBuilder3 = stringBuilder;
					object obj4 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(53496);
					dateTime = MdBMOhVqRSHesLq1WY.u2qFGu1ertOuH5b3VMi(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)]);
					string text4;
					stringBuilder3.Append(MdBMOhVqRSHesLq1WY.XygmsN1xmF2motiqfwh(obj4, dateTime.ToShortTimeString(), text4, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458)));
					StringBuilder stringBuilder4 = stringBuilder;
					string str10 = MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53438);
					dateTime = MdBMOhVqRSHesLq1WY.u2qFGu1ertOuH5b3VMi(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46840)));
					dateTime = dateTime.Date;
					string text3;
					stringBuilder4.Append(str10 + dateTime.ToShortDateString() + text3 + MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(8458));
					StringBuilder stringBuilder5 = stringBuilder;
					string str11 = MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53496);
					dateTime = MdBMOhVqRSHesLq1WY.u2qFGu1ertOuH5b3VMi(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840)]);
					string text2;
					stringBuilder5.Append(str11 + dateTime.ToShortTimeString() + text2 + MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(8458));
					text = "";
					str12 = "";
					if (dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8300)] != DBNull.Value)
					{
						dateTime = Convert.ToDateTime(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(8300)]);
						num = 7;
						continue;
					}
					goto IL_17C;
				}
				case 35:
					goto IL_40A;
				case 36:
					return;
				default:
					num = 12;
					continue;
				}
				num5 += num3;
				num = 22;
				continue;
				IL_56F:
				string text7 = text5;
				list = MdBMOhVqRSHesLq1WY.YCOi5C10TvsMsGEDv0i(text7, new string[]
				{
					MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(11572)
				}, StringSplitOptions.None).ToList<string>();
				if (list.Count > 1)
				{
					goto IL_59;
				}
				goto IL_76C;
				IL_565:
				text5 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(46680);
				goto IL_56F;
				IL_987:
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
				string text8 = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46524)].ToString();
				text8 = text8.Replace(cDhluYseFOthxgEIXpc.nKHKpgTSVU(10764), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
				text8 = MdBMOhVqRSHesLq1WY.rDG1V91EoaF7ncQ6PNR(text8, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46542), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
				stringBuilder.Append(string.Format(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53356), text8));
				if (dataRow[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(39194)] != DBNull.Value)
				{
					num = 17;
					continue;
				}
				goto IL_565;
				IL_480:
				string str13;
				if (num4 < dataTable.Rows.Count && MdBMOhVqRSHesLq1WY.w2kRM31R7fESmIjZqsC(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146))) == Convert.ToInt32(MdBMOhVqRSHesLq1WY.xGfH3c1MopY3pZPLkQ9(dataTable.Rows, num4)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146)]))
				{
					str13 = str13 + cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458) + MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)).ToString();
					string str4 = str4 + cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458) + dataRow[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46296)].ToString();
					num = 16;
					continue;
				}
				if (num2 != Convert.ToInt32(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)]))
				{
					MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
					num = 26;
					continue;
				}
				goto IL_987;
				IL_89:
				num4++;
				num = 19;
				if (!true)
				{
					goto IL_9B;
				}
				continue;
				IL_8DE:
				num3++;
				goto IL_89;
				IL_83:
				num4 = num5;
				num3 = 0;
				goto IL_89;
				IL_13F:
				stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44856));
				stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(52972));
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
				num = 3;
				continue;
				IL_103:
				goto IL_13F;
				IL_F3:
				if (MdBMOhVqRSHesLq1WY.N0dqAK15aGeOLu4vt0t(MdBMOhVqRSHesLq1WY.vtv7Eq1glXsYLnBOEfL(dataTable)) == 0)
				{
					goto IL_103;
				}
				goto IL_3D0;
				IL_17C:
				stringBuilder.Append(MdBMOhVqRSHesLq1WY.kOCqCX1h6SV54bQwelf(MdBMOhVqRSHesLq1WY.M5h95p1GRt6oR6xs7XC(cDhluYseFOthxgEIXpc.nKHKpgTSVU(53554), text, cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458)), new object[0]));
				MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.kOCqCX1h6SV54bQwelf(cDhluYseFOthxgEIXpc.nKHKpgTSVU(53614) + str12 + cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458), new object[0]));
				MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(45124));
				num = 4;
				continue;
				IL_284:
				if (num5 >= dataTable.Rows.Count)
				{
					num = 28;
					continue;
				}
				dataRow = MdBMOhVqRSHesLq1WY.xGfH3c1MopY3pZPLkQ9(dataTable.Rows, num5);
				str13 = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)].ToString();
				num = 31;
				continue;
				IL_3D0:
				num5 = 0;
				goto IL_284;
				IL_40A:
				num4++;
				num = 33;
				continue;
				IL_76C:
				list.Sort();
				text7 = string.Join(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46696), list.ToArray());
				text7 = MdBMOhVqRSHesLq1WY.rDG1V91EoaF7ncQ6PNR(text7, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10764), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
				text7 = MdBMOhVqRSHesLq1WY.rDG1V91EoaF7ncQ6PNR(text7, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46542), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
				MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, string.Format(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53416), text7));
				text6 = "";
				num = 15;
				continue;
				IL_81C:
				stringBuilder.Append(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(46942));
				MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(50642));
				MdBMOhVqRSHesLq1WY.cq9K6h1PYjioWPf9ma8(stringBuilder, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(44856));
				num = 29;
				if (MdBMOhVqRSHesLq1WY.SKdPKk1QLOrJqX9hlji())
				{
					continue;
				}
				IL_85F:
				str12 = dateTime.ToShortTimeString();
				num = 1;
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000350C4 File Offset: 0x000334C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string UN0MYbK9CK(string \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (!MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn())
			{
				num = 3;
				if (!MdBMOhVqRSHesLq1WY.SKdPKk1QLOrJqX9hlji())
				{
					goto IL_2A;
				}
			}
			else
			{
				num = 5;
			}
			for (;;)
			{
				IL_76:
				switch (num)
				{
				case 0:
				case 3:
					goto IL_2A;
				case 1:
					goto IL_3F;
				case 2:
					if (\u0020 == cDhluYseFOthxgEIXpc.nKHKpgTSVU(53768))
					{
						goto IL_FA;
					}
					break;
				case 4:
					break;
				case 5:
					goto IL_C0;
				case 6:
					goto IL_DF;
				default:
					num = 4;
					continue;
				}
				if (MdBMOhVqRSHesLq1WY.g6ajmy1o7quFJ1kT96a(\u0020, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53804)))
				{
					goto IL_105;
				}
				num = 6;
			}
			IL_DF:
			return "";
			IL_FA:
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(53912);
			IL_105:
			return MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53958);
			IL_2A:
			if (MdBMOhVqRSHesLq1WY.g6ajmy1o7quFJ1kT96a(\u0020, cDhluYseFOthxgEIXpc.nKHKpgTSVU(53696)))
			{
				return MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53840);
			}
			IL_3F:
			IL_C0:
			if (!(\u0020 == MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53732)))
			{
				num = 2;
				goto IL_76;
			}
			return MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(53874);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000351E8 File Offset: 0x000335E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string DmjMGE8HcI()
		{
			while (false)
			{
				object obj = null[0];
			}
			return MdBMOhVqRSHesLq1WY.L5VMbXcxEp() + MdBMOhVqRSHesLq1WY.X7OMzamvOI;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00035208 File Offset: 0x00033608
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iOIMjP7Kww(SQLSettings \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			using (SqlConnection sqlConnection = new SqlConnection(\u0020.GetConnectionString()))
			{
				try
				{
					MdBMOhVqRSHesLq1WY.Ct1WEY1wOXCt80P2Lxs(sqlConnection);
					DbDataAdapter dbDataAdapter = new SqlDataAdapter(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4202), sqlConnection);
					DataTable dataTable = new DataTable();
					dbDataAdapter.Fill(dataTable);
					if (MdBMOhVqRSHesLq1WY.N0dqAK15aGeOLu4vt0t(dataTable.Rows) > 0 && MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(MdBMOhVqRSHesLq1WY.xGfH3c1MopY3pZPLkQ9(MdBMOhVqRSHesLq1WY.vtv7Eq1glXsYLnBOEfL(dataTable), 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(4316)) != DBNull.Value)
					{
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.LoadXml(MdBMOhVqRSHesLq1WY.rSSidb1mSRowXYg0Vkh(MdBMOhVqRSHesLq1WY.xGfH3c1MopY3pZPLkQ9(dataTable.Rows, 0), cDhluYseFOthxgEIXpc.nKHKpgTSVU(4316)).ToString());
						XmlNode xmlNode = MdBMOhVqRSHesLq1WY.Bb3g461Y0cxvUDW8yDv(xmlDocument, cDhluYseFOthxgEIXpc.nKHKpgTSVU(4336));
						if (xmlNode != null)
						{
							XmlNode xmlNode2 = xmlNode.SelectSingleNode(MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(38836));
							if (xmlNode2 != null)
							{
								XmlAttribute xmlAttribute = xmlNode2.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38930)];
								if (xmlAttribute != null)
								{
									MdBMOhVqRSHesLq1WY.yLDMhg4gVZ = Convert.ToBoolean(MdBMOhVqRSHesLq1WY.paIhCs1ucf72xty3eYB(xmlAttribute));
								}
								else
								{
									MdBMOhVqRSHesLq1WY.yLDMhg4gVZ = false;
								}
								xmlAttribute = MdBMOhVqRSHesLq1WY.J24vwY1aRDteKUt1koZ(xmlNode2.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400));
								if (xmlAttribute != null)
								{
									MdBMOhVqRSHesLq1WY.X7OMzamvOI = xmlAttribute.Value;
								}
								xmlAttribute = xmlNode2.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38946)];
								if (xmlAttribute != null)
								{
									MdBMOhVqRSHesLq1WY.C3S8ZxLTjI = MdBMOhVqRSHesLq1WY.paIhCs1ucf72xty3eYB(xmlAttribute);
								}
								xmlAttribute = xmlNode2.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(38966)];
								if (xmlAttribute != null)
								{
									MdBMOhVqRSHesLq1WY.WPq83ySpp6 = xmlAttribute.Value;
								}
								xmlAttribute = MdBMOhVqRSHesLq1WY.J24vwY1aRDteKUt1koZ(MdBMOhVqRSHesLq1WY.pAXPDS1qV8fW81iSOMp(xmlNode2), cDhluYseFOthxgEIXpc.nKHKpgTSVU(38984));
								if (xmlAttribute != null)
								{
									MdBMOhVqRSHesLq1WY.Fhi8I8LIB8 = MdBMOhVqRSHesLq1WY.paIhCs1ucf72xty3eYB(xmlAttribute);
								}
								xmlAttribute = MdBMOhVqRSHesLq1WY.J24vwY1aRDteKUt1koZ(xmlNode2.Attributes, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(38996));
								if (xmlAttribute != null)
								{
									MdBMOhVqRSHesLq1WY.vbg8goWlI2 = MdBMOhVqRSHesLq1WY.paIhCs1ucf72xty3eYB(xmlAttribute);
								}
								xmlAttribute = MdBMOhVqRSHesLq1WY.pAXPDS1qV8fW81iSOMp(xmlNode2)[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39006)];
								if (xmlAttribute != null)
								{
									MdBMOhVqRSHesLq1WY.ojI8eNxETK = MdBMOhVqRSHesLq1WY.paIhCs1ucf72xty3eYB(xmlAttribute);
									xmlAttribute = MdBMOhVqRSHesLq1WY.J24vwY1aRDteKUt1koZ(xmlNode2.Attributes, MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(39020));
									if (xmlAttribute != null)
									{
										MdBMOhVqRSHesLq1WY.OLj8nHGjqJ = xmlAttribute.Value;
									}
									xmlAttribute = xmlNode2.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39042)];
									if (xmlAttribute != null)
									{
										MdBMOhVqRSHesLq1WY.A8c8JYg1YZ = xmlAttribute.Value;
									}
								}
								XmlNode xmlNode3 = xmlNode2.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39062));
								if (xmlNode3 != null)
								{
									xmlAttribute = MdBMOhVqRSHesLq1WY.pAXPDS1qV8fW81iSOMp(xmlNode3)[MdBMOhVqRSHesLq1WY.KbQmX014d2Y3EWFe7pl(39080)];
									if (xmlAttribute != null)
									{
										MdBMOhVqRSHesLq1WY.KvP801eFt8 = Convert.ToDateTime(MdBMOhVqRSHesLq1WY.paIhCs1ucf72xty3eYB(xmlAttribute));
									}
									xmlAttribute = xmlNode3.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39094)];
									if (xmlAttribute != null)
									{
										MdBMOhVqRSHesLq1WY.ldA8oeG5cY = MdBMOhVqRSHesLq1WY.pGEukS18bD21JJQiqJB(xmlAttribute.Value);
									}
									xmlNode2 = xmlNode.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39288));
									if (xmlNode2 != null && !MdBMOhVqRSHesLq1WY.aEE2Og1yV3QDHTjALQc(MdBMOhVqRSHesLq1WY.zxfq5A1B9jBMDB811U4(xmlNode2)))
									{
										MdBMOhVqRSHesLq1WY.j298uTB8ER = MdBMOhVqRSHesLq1WY.zxfq5A1B9jBMDB811U4(xmlNode2);
									}
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

		// Token: 0x06000D91 RID: 3473 RVA: 0x00035574 File Offset: 0x00033974
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string L5VMbXcxEp()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 5;
			string text;
			for (;;)
			{
				string str;
				switch (num)
				{
				case 0:
				case 1:
					text = Path.GetTempPath() + cDhluYseFOthxgEIXpc.nKHKpgTSVU(54038) + str + cDhluYseFOthxgEIXpc.nKHKpgTSVU(54038);
					goto IL_38;
				case 2:
					goto IL_38;
				case 3:
					goto IL_48;
				case 4:
					break;
				case 5:
					goto IL_A7;
				case 6:
					return text;
				default:
					num = 4;
					continue;
				}
				IL_90:
				Directory.CreateDirectory(text);
				num = 6;
				if (MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn())
				{
					goto IL_A7;
				}
				continue;
				IL_48:
				if (!MdBMOhVqRSHesLq1WY.zhQPV416Hl6btKm8GLp(text))
				{
					goto IL_90;
				}
				break;
				IL_38:
				goto IL_48;
				IL_A7:
				str = cDhluYseFOthxgEIXpc.nKHKpgTSVU(53994);
				MdBMOhVqRSHesLq1WY.SKdPKk1QLOrJqX9hlji();
				num = (MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn() ? 3 : 0);
			}
			return text;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00035650 File Offset: 0x00033A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IW0MNKrxsS()
		{
			while (false)
			{
				object obj = null[0];
			}
			if (MdBMOhVqRSHesLq1WY.yLDMhg4gVZ)
			{
				hHTdIbieaEH23dYXRr.IEq8kSL8Ur(MdBMOhVqRSHesLq1WY.j298uTB8ER, MdBMOhVqRSHesLq1WY.WPq83ySpp6, MdBMOhVqRSHesLq1WY.Fhi8I8LIB8, MdBMOhVqRSHesLq1WY.vbg8goWlI2, MdBMOhVqRSHesLq1WY.DmjMGE8HcI(), MdBMOhVqRSHesLq1WY.ojI8eNxETK, MdBMOhVqRSHesLq1WY.OLj8nHGjqJ, MdBMOhVqRSHesLq1WY.A8c8JYg1YZ);
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000356A4 File Offset: 0x00033AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MdBMOhVqRSHesLq1WY()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			int num = 9;
			for (;;)
			{
				switch (num)
				{
				case 0:
					MdBMOhVqRSHesLq1WY.vbg8goWlI2 = "";
					MdBMOhVqRSHesLq1WY.ojI8eNxETK = "";
					MdBMOhVqRSHesLq1WY.OLj8nHGjqJ = "";
					MdBMOhVqRSHesLq1WY.A8c8JYg1YZ = "";
					MdBMOhVqRSHesLq1WY.KvP801eFt8 = DateTime.MinValue;
					num = 3;
					continue;
				case 1:
					break;
				case 2:
				case 6:
					goto IL_58;
				case 3:
					goto IL_6E;
				case 4:
					goto IL_46;
				case 5:
					MdBMOhVqRSHesLq1WY.yLDMhg4gVZ = true;
					goto IL_46;
				case 7:
					HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
					MdBMOhVqRSHesLq1WY.SKdPKk1QLOrJqX9hlji();
					if (!MdBMOhVqRSHesLq1WY.vjZuBn11xKy1kyW21kn())
					{
						num = 6;
						if (!true)
						{
							return;
						}
						continue;
					}
					else
					{
						num = 8;
						if (false)
						{
							goto IL_58;
						}
						continue;
					}
					break;
				case 8:
					goto IL_88;
				case 9:
					aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
					num = 7;
					continue;
				case 10:
					return;
				default:
					num = 1;
					continue;
				}
				IL_18:
				MdBMOhVqRSHesLq1WY.C3S8ZxLTjI = "";
				MdBMOhVqRSHesLq1WY.WPq83ySpp6 = "";
				MdBMOhVqRSHesLq1WY.Fhi8I8LIB8 = "";
				num = 0;
				continue;
				IL_88:
				MdBMOhVqRSHesLq1WY.X7OMzamvOI = cDhluYseFOthxgEIXpc.nKHKpgTSVU(54044);
				goto IL_18;
				IL_46:
				goto IL_88;
				IL_58:
				MdBMOhVqRSHesLq1WY.J5QME64TYL = 920;
				num = 5;
				if (!false)
				{
					continue;
				}
				IL_6E:
				MdBMOhVqRSHesLq1WY.ldA8oeG5cY = 0;
				MdBMOhVqRSHesLq1WY.j298uTB8ER = "";
				num = 10;
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00035804 File Offset: 0x00033C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M5h95p1GRt6oR6xs7XC(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 + A_1 + A_2;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00035828 File Offset: 0x00033C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KbQmX014d2Y3EWFe7pl(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00035844 File Offset: 0x00033C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iJud5V1tyondrKn6WH2(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.Format(A_0, A_1, A_2);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00035868 File Offset: 0x00033C68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ct1WEY1wOXCt80P2Lxs(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Open();
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00035884 File Offset: 0x00033C84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kqMiJv1VNplQWH4Aeuj(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.Concat(A_0);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x000358A0 File Offset: 0x00033CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int S2qTqL1k4WXXF67enkV(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Fill(A_1);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000358C0 File Offset: 0x00033CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yur86q1declm67Ic6RQ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Message;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000358DC File Offset: 0x00033CDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OJalwC1bbmeypZvHGle(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.InnerException;
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x000358F8 File Offset: 0x00033CF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SKdPKk1QLOrJqX9hlji()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0003590C File Offset: 0x00033D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vjZuBn11xKy1kyW21kn()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00035920 File Offset: 0x00033D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void e7N48m1FBRT8SHF6H4y(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Write(A_1);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00035940 File Offset: 0x00033D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cq9K6h1PYjioWPf9ma8(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Append(A_1);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00035960 File Offset: 0x00033D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rSSidb1mSRowXYg0Vkh(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00035980 File Offset: 0x00033D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vtv7Eq1glXsYLnBOEfL(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Rows;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0003599C File Offset: 0x00033D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int w2kRM31R7fESmIjZqsC(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToInt32(A_0);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000359B8 File Offset: 0x00033DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rDG1V91EoaF7ncQ6PNR(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Replace(A_1, A_2);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000359DC File Offset: 0x00033DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ItTKhF1KifJNUY14T7V(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000359F8 File Offset: 0x00033DF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hmSvOs19l49ianT5FeG(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.ToArray();
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00035A14 File Offset: 0x00033E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d2LxWM1iUmfdDjy6D1W(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.Join(A_0, A_1);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00035A34 File Offset: 0x00033E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime u2qFGu1ertOuH5b3VMi(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToDateTime(A_0);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00035A50 File Offset: 0x00033E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xGfH3c1MopY3pZPLkQ9(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00035A70 File Offset: 0x00033E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int N0dqAK15aGeOLu4vt0t(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00035A8C File Offset: 0x00033E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BHfTv01vdOjft2fDd4b(object A_0, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return MdBMOhVqRSHesLq1WY.oD0MxxmH2n(A_0, \u0020);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00035AAC File Offset: 0x00033EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PeVALf1C0ib3C4eCfD5(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return MdBMOhVqRSHesLq1WY.UN0MYbK9CK(A_0);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00035AC8 File Offset: 0x00033EC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YCOi5C10TvsMsGEDv0i(object A_0, object A_1, StringSplitOptions A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Split(A_1, A_2);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00035AEC File Offset: 0x00033EEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XygmsN1xmF2motiqfwh(object A_0, object A_1, object A_2, object A_3)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 + A_1 + A_2 + A_3;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00035B14 File Offset: 0x00033F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kOCqCX1h6SV54bQwelf(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.Format(A_0, A_1);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00035B34 File Offset: 0x00033F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g6ajmy1o7quFJ1kT96a(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 == A_1;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00035B54 File Offset: 0x00033F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Bb3g461Y0cxvUDW8yDv(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.SelectSingleNode(A_1);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00035B74 File Offset: 0x00033F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object paIhCs1ucf72xty3eYB(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00035B90 File Offset: 0x00033F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object J24vwY1aRDteKUt1koZ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00035BB0 File Offset: 0x00033FB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pAXPDS1qV8fW81iSOMp(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Attributes;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00035BCC File Offset: 0x00033FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int pGEukS18bD21JJQiqJB(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToInt32(A_0);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00035BE8 File Offset: 0x00033FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zxfq5A1B9jBMDB811U4(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.InnerText;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00035C04 File Offset: 0x00034004
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aEE2Og1yV3QDHTjALQc(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.IsNullOrEmpty(A_0);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00035C20 File Offset: 0x00034020
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zhQPV416Hl6btKm8GLp(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Directory.Exists(A_0);
		}

		// Token: 0x040002DE RID: 734
		internal static int J5QME64TYL;

		// Token: 0x040002DF RID: 735
		private static bool yLDMhg4gVZ;

		// Token: 0x040002E0 RID: 736
		private static string X7OMzamvOI;

		// Token: 0x040002E1 RID: 737
		private static string C3S8ZxLTjI;

		// Token: 0x040002E2 RID: 738
		private static string WPq83ySpp6;

		// Token: 0x040002E3 RID: 739
		private static string Fhi8I8LIB8;

		// Token: 0x040002E4 RID: 740
		private static string vbg8goWlI2;

		// Token: 0x040002E5 RID: 741
		private static string ojI8eNxETK;

		// Token: 0x040002E6 RID: 742
		private static string OLj8nHGjqJ;

		// Token: 0x040002E7 RID: 743
		private static string A8c8JYg1YZ;

		// Token: 0x040002E8 RID: 744
		private static DateTime KvP801eFt8;

		// Token: 0x040002E9 RID: 745
		private static int ldA8oeG5cY;

		// Token: 0x040002EA RID: 746
		private static string j298uTB8ER;
	}
}
