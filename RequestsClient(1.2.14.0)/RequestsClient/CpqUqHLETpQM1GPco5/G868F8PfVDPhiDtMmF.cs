using System;
using System.Collections;
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

namespace CpqUqHLETpQM1GPco5
{
	// Token: 0x0200007C RID: 124
	internal static class G868F8PfVDPhiDtMmF
	{
		// Token: 0x06000DB8 RID: 3512 RVA: 0x00035C3C File Offset: 0x0003403C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DataTable pPR8Mqdalg(SQLSettings \u0020, DateTime \u0020, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK();
			int num = (!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V()) ? 3 : 6;
			DateTime dateTime;
			DataTable dataTable;
			SqlConnection sqlConnection;
			string text3;
			string text4;
			for (;;)
			{
				string text;
				string text2;
				switch (num)
				{
				case 0:
				case 6:
				{
					object obj2 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(11374);
					dateTime = \u0020.Date;
					text = G868F8PfVDPhiDtMmF.YJ4vn91sBMUh7prO7d4(obj2, dateTime.ToString(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(1160)), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11374));
					num = 4;
					continue;
				}
				case 1:
					dataTable = new DataTable();
					sqlConnection = new SqlConnection(\u0020.GetConnectionString());
					num = 7;
					continue;
				case 2:
					goto IL_C8;
				case 3:
					goto IL_F6;
				case 4:
				{
					object obj3 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(11374);
					dateTime = \u0020.Date;
					text2 = G868F8PfVDPhiDtMmF.YJ4vn91sBMUh7prO7d4(obj3, dateTime.ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(1160)), G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(44114));
					goto IL_C8;
				}
				case 5:
					break;
				case 7:
					goto IL_1BB;
				default:
					num = 5;
					continue;
				}
				IL_28:
				text3 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(44278) + G868F8PfVDPhiDtMmF.qil87Ve7N0.ToString() + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(44312);
				num = 1;
				continue;
				IL_F6:
				text4 = G868F8PfVDPhiDtMmF.u5E9SQ1fPmHXGv43s6t(new string[]
				{
					G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(54078),
					text,
					G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(54118),
					text2,
					G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(54162),
					text,
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(54208),
					text2,
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(54252),
					text,
					G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(54298),
					text2,
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(54342)
				});
				goto IL_28;
				IL_C8:
				goto IL_F6;
			}
			try
			{
				IL_1BB:
				sqlConnection.Open();
				G868F8PfVDPhiDtMmF.MKt3l01pUaKegAwiIPv(new SqlDataAdapter(string.Concat(new string[]
				{
					G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(44320),
					text4,
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(44414),
					text3,
					G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(54352)
				}), sqlConnection), dataTable);
				if (G868F8PfVDPhiDtMmF.O3Rdxe1OCbNaNC9tx45(\u0020.Date, \u0020.Date))
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					try
					{
						IL_38B:
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)G868F8PfVDPhiDtMmF.baHOQg1DSwFCFkoaLtg(enumerator);
							int num2 = 2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									break;
								case 1:
								case 4:
									G868F8PfVDPhiDtMmF.Plkf7T1INoTjNbst0TR(dataRow, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(54606), \u0020.Date);
									goto IL_323;
								case 2:
									if (G868F8PfVDPhiDtMmF.P0dVlg1JoAU0MaS8Znu(\u0020.Date, Convert.ToDateTime(G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(54580)))))
									{
										num2 = (G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK() ? 0 : 4);
										continue;
									}
									goto IL_323;
								case 3:
									break;
								case 5:
									IL_369:
									dateTime = dateTime.AddDays(1.0);
									break;
								case 6:
									goto IL_38B;
								default:
									num2 = 5;
									continue;
								}
								IL_24E:
								if (G868F8PfVDPhiDtMmF.l68AHl1ZtKe7kyxs0Wi(dateTime.AddMinutes(-1.0), Convert.ToDateTime(G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(54632)))))
								{
									DataRow dataRow2 = dataRow;
									string columnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(54658);
									dateTime = \u0020.Date;
									dateTime = dateTime.AddDays(1.0);
									dataRow2[columnName] = dateTime.AddMinutes(-1.0);
									num2 = 6;
									continue;
								}
								break;
								goto IL_24E;
								IL_323:
								dateTime = \u0020.Date;
								goto IL_369;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							G868F8PfVDPhiDtMmF.R43JcK1cXAR8PgUWrtf(disposable);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex.InnerException);
			}
			finally
			{
				if (sqlConnection != null)
				{
					G868F8PfVDPhiDtMmF.R43JcK1cXAR8PgUWrtf(sqlConnection);
				}
			}
			return dataTable;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00036078 File Offset: 0x00034478
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vRO88iHNRg(SQLSettings \u0020, string \u0020, DateTime \u0020, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 6;
			if (false)
			{
				goto IL_1A;
			}
			DataRow dataRow2;
			string text6;
			string text7;
			for (;;)
			{
				IL_305:
				StringBuilder stringBuilder;
				DataRow dataRow;
				string text;
				int num2;
				DataTable dataTable;
				int num3;
				List<string> list;
				string text2;
				int num4;
				string text3;
				string text4;
				string text5;
				int num5;
				switch (num)
				{
				case 0:
					G868F8PfVDPhiDtMmF.aRd8C3WkZN(\u0020, stringBuilder);
					num = 34;
					if (G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK())
					{
						goto IL_2D8;
					}
					continue;
				case 1:
					if (string.IsNullOrEmpty(G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(60260)).ToString()))
					{
						goto IL_139;
					}
					text = G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(60260)).ToString();
					break;
				case 2:
					goto IL_555;
				case 3:
					goto IL_50A;
				case 4:
					goto IL_284;
				case 5:
					IL_900:
					if (num2 < G868F8PfVDPhiDtMmF.qtj8eoGLmBdml28Y76f(G868F8PfVDPhiDtMmF.qApkYaGW7rlStc5ibxk(dataTable)) && G868F8PfVDPhiDtMmF.X1aZASGXErbjGVuRAAN(G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(6146))) == Convert.ToInt32(dataTable.Rows[num2][cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146)]))
					{
						string str = str + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(8458) + dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)].ToString();
						num = 32;
						if (!true)
						{
							goto IL_983;
						}
						continue;
					}
					else
					{
						if (num3 != G868F8PfVDPhiDtMmF.X1aZASGXErbjGVuRAAN(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(4948)]))
						{
							G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
							num = 2;
							continue;
						}
						goto IL_5BC;
					}
					break;
				case 6:
					stringBuilder = new StringBuilder();
					num = 23;
					if (G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK())
					{
						goto IL_284;
					}
					continue;
				case 7:
					goto IL_88C;
				case 8:
					IL_80B:
					text2 = string.Join(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46696), list.ToArray());
					num = 14;
					continue;
				case 9:
				case 10:
					num4 = 0;
					goto IL_7F5;
				case 11:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
					num = 24;
					if (!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V())
					{
						goto IL_555;
					}
					continue;
				case 12:
					dataRow2 = dataTable.Rows[num2];
					text3 = text3 + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46696) + G868F8PfVDPhiDtMmF.pGmi2aGTkYdtTQV9OFj(dataRow2[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46270)]).Date.ToShortDateString();
					text4 = G868F8PfVDPhiDtMmF.YJ4vn91sBMUh7prO7d4(text4, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46696), Convert.ToDateTime(G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow2, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46270))).ToShortTimeString());
					num = 19;
					if (!true)
					{
						goto IL_7D4;
					}
					continue;
				case 13:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
					num = 33;
					if (!true)
					{
						goto IL_19A;
					}
					continue;
				case 14:
					IL_22A:
					text2 = text2.Replace(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(10764), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
					text2 = text2.Replace(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46542), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
					num = 15;
					continue;
				case 15:
					goto IL_983;
				case 16:
					num4++;
					goto IL_7F5;
				case 17:
					goto IL_19A;
				case 18:
					text5 = dataRow[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(39194)].ToString();
					goto IL_1DC;
				case 19:
					goto IL_1A;
				case 20:
					goto IL_496;
				case 21:
					goto IL_2D8;
				case 22:
					G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46922));
					num = 0;
					if (false)
					{
						goto IL_88C;
					}
					continue;
				case 23:
					goto IL_9C9;
				case 24:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(60020));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
					goto IL_3DD;
				case 25:
					goto IL_60C;
				case 26:
					num5++;
					goto IL_8AC;
				case 27:
					goto IL_EE;
				case 28:
					num4++;
					goto IL_EE;
				case 29:
					goto IL_432;
				case 30:
					goto IL_7D4;
				case 31:
					stringBuilder.Append(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(45124));
					stringBuilder.Append(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46880));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(52766));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(52952));
					dataTable = G868F8PfVDPhiDtMmF.o7U4hkG3ZOGOdb51Fph(\u0020, \u0020, \u0020);
					num = 7;
					continue;
				case 32:
				{
					IL_5D9:
					string str2 = str2 + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(8458) + dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46296)].ToString();
					num = 16;
					continue;
				}
				case 33:
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(58922));
					num = 4;
					continue;
				case 34:
					return;
				default:
					num = 3;
					continue;
				}
				IL_143:
				string arg = text;
				stringBuilder.Append(string.Format(cDhluYseFOthxgEIXpc.nKHKpgTSVU(60284), arg));
				num5 += num4;
				num = 26;
				continue;
				IL_139:
				text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(46680);
				goto IL_143;
				IL_19A:
				num2 = num5;
				G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK();
				num = ((!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V()) ? 25 : 9);
				continue;
				IL_1DC:
				text2 = text5;
				list = G868F8PfVDPhiDtMmF.JaNTqoGnSHAtUmsj07X(text2, new string[]
				{
					cDhluYseFOthxgEIXpc.nKHKpgTSVU(11572)
				}, StringSplitOptions.None).ToList<string>();
				if (G868F8PfVDPhiDtMmF.zcVKpPG2wUKRaQPH9QI(list) <= 1 || !list.Contains(""))
				{
					goto IL_7E1;
				}
				num = 30;
				if (!true)
				{
					goto IL_22A;
				}
				continue;
				IL_1D2:
				text5 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(46680);
				goto IL_1DC;
				IL_50A:
				if (!string.IsNullOrEmpty(G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39194)).ToString()))
				{
					num = 18;
					continue;
				}
				goto IL_1D2;
				IL_2D8:
				if (G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39194)) != DBNull.Value)
				{
					goto IL_50A;
				}
				goto IL_1D2;
				IL_284:
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(45124));
				stringBuilder.Append(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(44856));
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(59550));
				num = 31;
				continue;
				IL_8AC:
				if (num5 >= G868F8PfVDPhiDtMmF.qApkYaGW7rlStc5ibxk(dataTable).Count)
				{
					G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(53674));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46880));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(46902));
					num = 22;
					if (!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V())
					{
						goto IL_900;
					}
					continue;
				}
				else
				{
					dataRow = G868F8PfVDPhiDtMmF.SkO5NZGjxPuR0FUpExb(G868F8PfVDPhiDtMmF.qApkYaGW7rlStc5ibxk(dataTable), num5);
					string str = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46270)].ToString();
					string str2 = dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46296)].ToString();
					num = 17;
					if (!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V())
					{
						goto IL_432;
					}
					continue;
				}
				IL_3DD:
				num5 = 0;
				goto IL_8AC;
				IL_88C:
				num3 = -1;
				if (G868F8PfVDPhiDtMmF.qtj8eoGLmBdml28Y76f(G868F8PfVDPhiDtMmF.qApkYaGW7rlStc5ibxk(dataTable)) == 0)
				{
					num = 11;
					continue;
				}
				goto IL_3DD;
				IL_432:
				num2++;
				if (num2 < G868F8PfVDPhiDtMmF.qtj8eoGLmBdml28Y76f(dataTable.Rows) && G868F8PfVDPhiDtMmF.X1aZASGXErbjGVuRAAN(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146)]) == G868F8PfVDPhiDtMmF.X1aZASGXErbjGVuRAAN(dataTable.Rows[num2][cDhluYseFOthxgEIXpc.nKHKpgTSVU(6146)]))
				{
					num = 12;
					if (!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V())
					{
						goto IL_496;
					}
					continue;
				}
				else
				{
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(53438) + G868F8PfVDPhiDtMmF.pGmi2aGTkYdtTQV9OFj(dataRow[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46270)]).Date.ToShortDateString() + text3 + cDhluYseFOthxgEIXpc.nKHKpgTSVU(8458));
					G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(53496) + G868F8PfVDPhiDtMmF.pGmi2aGTkYdtTQV9OFj(dataRow[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46270)]).ToShortTimeString() + text4 + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(8458));
					stringBuilder.Append(G868F8PfVDPhiDtMmF.uT9KrlGHxGLNoVMBrRd(cDhluYseFOthxgEIXpc.nKHKpgTSVU(53438), G868F8PfVDPhiDtMmF.pGmi2aGTkYdtTQV9OFj(dataRow[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46840)]).Date.ToShortDateString(), text6, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(8458)));
					stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(53496) + Convert.ToDateTime(dataRow[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840)]).ToShortTimeString() + text7 + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(8458));
					if (G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, cDhluYseFOthxgEIXpc.nKHKpgTSVU(60260)) != DBNull.Value)
					{
						num = 1;
						continue;
					}
					goto IL_139;
				}
				IL_60C:
				goto IL_432;
				IL_EE:
				goto IL_60C;
				IL_496:
				string text8 = G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46524)).ToString();
				text8 = G868F8PfVDPhiDtMmF.JnW1HhGrSDNDoeNmN8Z(text8, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10764), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
				text8 = text8.Replace(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46542), cDhluYseFOthxgEIXpc.nKHKpgTSVU(11550));
				G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, string.Format(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(53356), text8));
				num = 21;
				continue;
				IL_5BC:
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(44856));
				num = 20;
				if (false)
				{
					goto IL_5D9;
				}
				continue;
				IL_555:
				string str3 = G868F8PfVDPhiDtMmF.t8n8RCZjQF(G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(1054)).ToString());
				G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(53224) + str3 + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(8458));
				stringBuilder.Append(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(45124));
				num3 = G868F8PfVDPhiDtMmF.X1aZASGXErbjGVuRAAN(dataRow[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(4948)]);
				goto IL_5BC;
				IL_7E1:
				list.Sort();
				num = 8;
				continue;
				IL_7D4:
				list.Remove("");
				goto IL_7E1;
				IL_7F5:
				num2++;
				num = 5;
				if (G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK())
				{
					goto IL_80B;
				}
				continue;
				IL_983:
				stringBuilder.Append(string.Format(cDhluYseFOthxgEIXpc.nKHKpgTSVU(53416), text2));
				text3 = "";
				text6 = "";
				text4 = "";
				text7 = "";
				num2 = num5;
				num4 = 0;
				num = 29;
				if (true)
				{
					continue;
				}
				IL_9C9:
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(54684));
				stringBuilder.Append(cDhluYseFOthxgEIXpc.nKHKpgTSVU(50642));
				G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(44856));
				G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, cDhluYseFOthxgEIXpc.nKHKpgTSVU(58614));
				stringBuilder.Append(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(45124));
				stringBuilder.Append(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(44856));
				G868F8PfVDPhiDtMmF.tZqPw01z87VjseoTOhq(stringBuilder, string.Format(cDhluYseFOthxgEIXpc.nKHKpgTSVU(58766), \u0020.ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(58898)), \u0020.ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(58898))));
				num = 13;
			}
			return;
			IL_1A:
			text6 = text6 + cDhluYseFOthxgEIXpc.nKHKpgTSVU(46696) + G868F8PfVDPhiDtMmF.pGmi2aGTkYdtTQV9OFj(dataRow2[cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840)]).Date.ToShortDateString();
			text7 = text7 + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(46696) + Convert.ToDateTime(G868F8PfVDPhiDtMmF.mqvJh11UhueQ3koBCDP(dataRow2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(46840))).ToShortTimeString();
			num = 28;
			goto IL_305;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00036AF8 File Offset: 0x00034EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string t8n8RCZjQF(string \u0020)
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
					if (!(\u0020 == G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(53732)))
					{
						num = 5;
						continue;
					}
					goto IL_ED;
				case 4:
					if (!(\u0020 == cDhluYseFOthxgEIXpc.nKHKpgTSVU(53696)))
					{
						G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK();
						num = ((!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V()) ? 2 : 0);
						continue;
					}
					goto IL_E2;
				case 5:
					if (G868F8PfVDPhiDtMmF.id1MTLGleQacc2aBDsM(\u0020, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(53768)))
					{
						goto IL_F8;
					}
					break;
				case 6:
					goto IL_DD;
				}
				IL_37:
				if (!(\u0020 == G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(53804)))
				{
					num = 6;
					continue;
				}
				goto IL_103;
				goto IL_37;
			}
			IL_DD:
			return "";
			IL_E2:
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(53840);
			IL_ED:
			return G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(53874);
			IL_F8:
			return G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(53912);
			IL_103:
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(53958);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00036C18 File Offset: 0x00035018
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void aRd8C3WkZN(string \u0020, StringBuilder \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			try
			{
				G868F8PfVDPhiDtMmF.F7arCbG7IlUHkVw5Gnp(\u0020);
				StreamWriter streamWriter = new StreamWriter(\u0020, true, Encoding.GetEncoding(1251));
				G868F8PfVDPhiDtMmF.QuXkAhGQ6V5qm47u7bO(streamWriter, \u0020.ToString());
				G868F8PfVDPhiDtMmF.dCErsrG1kXrhxEUQ5rH(streamWriter);
			}
			catch (Exception ex)
			{
				throw new Exception(G868F8PfVDPhiDtMmF.UGP8OAGGaABOKuPIvOv(ex), ex.InnerException);
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00036C84 File Offset: 0x00035084
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string Ey28X7YZCv()
		{
			while (false)
			{
				object obj = null[0];
			}
			return G868F8PfVDPhiDtMmF.Tuh8mwKK7r() + G868F8PfVDPhiDtMmF.HLL81cBjb5;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00036CA4 File Offset: 0x000350A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qCF8qpg2Wt(SQLSettings \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			using (SqlConnection sqlConnection = new SqlConnection(\u0020.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					DbDataAdapter dbDataAdapter = new SqlDataAdapter(cDhluYseFOthxgEIXpc.nKHKpgTSVU(4202), sqlConnection);
					DataTable dataTable = new DataTable();
					dbDataAdapter.Fill(dataTable);
					if (G868F8PfVDPhiDtMmF.qtj8eoGLmBdml28Y76f(G868F8PfVDPhiDtMmF.qApkYaGW7rlStc5ibxk(dataTable)) > 0 && G868F8PfVDPhiDtMmF.SkO5NZGjxPuR0FUpExb(dataTable.Rows, 0)[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(4316)] != DBNull.Value)
					{
						XmlDocument xmlDocument = new XmlDocument();
						G868F8PfVDPhiDtMmF.KITvmeG4fV2RqusAycL(xmlDocument, dataTable.Rows[0][cDhluYseFOthxgEIXpc.nKHKpgTSVU(4316)].ToString());
						XmlNode xmlNode = xmlDocument.SelectSingleNode(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(4336));
						if (xmlNode != null)
						{
							XmlNode xmlNode2 = xmlNode.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(956));
							if (xmlNode2 != null)
							{
								XmlAttribute xmlAttribute = G868F8PfVDPhiDtMmF.G8clRUGtBAEIHRPaAlZ(xmlNode2.Attributes, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(38930));
								if (xmlAttribute != null)
								{
									G868F8PfVDPhiDtMmF.pSg8aB2ZJQ = Convert.ToBoolean(G868F8PfVDPhiDtMmF.i6lXGEGwotBqqZ8CL5V(xmlAttribute));
								}
								else
								{
									G868F8PfVDPhiDtMmF.pSg8aB2ZJQ = false;
								}
								xmlAttribute = G868F8PfVDPhiDtMmF.G8clRUGtBAEIHRPaAlZ(xmlNode2.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(10400));
								if (xmlAttribute != null)
								{
									G868F8PfVDPhiDtMmF.HLL81cBjb5 = xmlAttribute.Value;
								}
								xmlAttribute = G868F8PfVDPhiDtMmF.FcVJROGVZypwu3FQXpj(xmlNode2)[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(38946)];
								if (xmlAttribute != null)
								{
									G868F8PfVDPhiDtMmF.hfw8OGSGMd = G868F8PfVDPhiDtMmF.i6lXGEGwotBqqZ8CL5V(xmlAttribute);
								}
								xmlAttribute = G868F8PfVDPhiDtMmF.G8clRUGtBAEIHRPaAlZ(xmlNode2.Attributes, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(38966));
								if (xmlAttribute != null)
								{
									G868F8PfVDPhiDtMmF.y118LmRRPb = G868F8PfVDPhiDtMmF.i6lXGEGwotBqqZ8CL5V(xmlAttribute);
								}
								xmlAttribute = G868F8PfVDPhiDtMmF.G8clRUGtBAEIHRPaAlZ(xmlNode2.Attributes, G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(38984));
								if (xmlAttribute != null)
								{
									G868F8PfVDPhiDtMmF.HBO8vduJJP = G868F8PfVDPhiDtMmF.i6lXGEGwotBqqZ8CL5V(xmlAttribute);
								}
								xmlAttribute = G868F8PfVDPhiDtMmF.G8clRUGtBAEIHRPaAlZ(xmlNode2.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(38996));
								if (xmlAttribute != null)
								{
									G868F8PfVDPhiDtMmF.utX84tLkv1 = xmlAttribute.Value;
								}
								xmlAttribute = xmlNode2.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39006)];
								if (xmlAttribute != null)
								{
									G868F8PfVDPhiDtMmF.XnD8Bcliqo = G868F8PfVDPhiDtMmF.i6lXGEGwotBqqZ8CL5V(xmlAttribute);
									xmlAttribute = G868F8PfVDPhiDtMmF.G8clRUGtBAEIHRPaAlZ(xmlNode2.Attributes, cDhluYseFOthxgEIXpc.nKHKpgTSVU(39020));
									if (xmlAttribute != null)
									{
										G868F8PfVDPhiDtMmF.mFh8l88ft0 = xmlAttribute.Value;
									}
									xmlAttribute = xmlNode2.Attributes[cDhluYseFOthxgEIXpc.nKHKpgTSVU(39042)];
									if (xmlAttribute != null)
									{
										G868F8PfVDPhiDtMmF.mFW8PbTBwj = xmlAttribute.Value;
									}
								}
								XmlNode xmlNode3 = xmlNode2.SelectSingleNode(cDhluYseFOthxgEIXpc.nKHKpgTSVU(39062));
								if (xmlNode3 != null)
								{
									xmlAttribute = xmlNode3.Attributes[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(39080)];
									if (xmlAttribute != null)
									{
										G868F8PfVDPhiDtMmF.PE18wkEsGk = Convert.ToDateTime(G868F8PfVDPhiDtMmF.i6lXGEGwotBqqZ8CL5V(xmlAttribute));
									}
									xmlAttribute = xmlNode3.Attributes[G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(39094)];
									if (xmlAttribute != null)
									{
										G868F8PfVDPhiDtMmF.T0T85sQfkq = G868F8PfVDPhiDtMmF.e32OqSGkkoHvuVsN1YL(G868F8PfVDPhiDtMmF.i6lXGEGwotBqqZ8CL5V(xmlAttribute));
									}
									xmlNode2 = xmlNode.SelectSingleNode(G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(39288));
									if (xmlNode2 != null && !string.IsNullOrEmpty(xmlNode2.InnerText))
									{
										G868F8PfVDPhiDtMmF.ay789AL2Ld = xmlNode2.InnerText;
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

		// Token: 0x06000DBE RID: 3518 RVA: 0x00037010 File Offset: 0x00035410
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string Tuh8mwKK7r()
		{
			while (false)
			{
				object obj = null[0];
			}
			G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK();
			int num;
			if (G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V())
			{
				num = 3;
				if (!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V())
				{
					goto IL_2E;
				}
			}
			else
			{
				num = 2;
			}
			string text;
			for (;;)
			{
				IL_75:
				switch (num)
				{
				case 0:
				case 3:
					goto IL_A0;
				case 1:
					goto IL_AB;
				case 2:
					goto IL_2E;
				case 4:
					break;
				case 5:
					if (G868F8PfVDPhiDtMmF.Sm2mHoGdBbNNEAiiICt(text))
					{
						return text;
					}
					break;
				case 6:
					return text;
				default:
					num = 4;
					continue;
				}
				Directory.CreateDirectory(text);
				num = 6;
				if (false)
				{
					return text;
				}
			}
			IL_A0:
			string str = cDhluYseFOthxgEIXpc.nKHKpgTSVU(53994);
			IL_AB:
			IL_2E:
			text = Path.GetTempPath() + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(54038) + str + G868F8PfVDPhiDtMmF.jH51vh1AM5ZSZdTwIuk(54038);
			num = 5;
			goto IL_75;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000370EC File Offset: 0x000354EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AtP8srTQCY()
		{
			while (false)
			{
				object obj = null[0];
			}
			if (G868F8PfVDPhiDtMmF.pSg8aB2ZJQ)
			{
				hHTdIbieaEH23dYXRr.IEq8kSL8Ur(G868F8PfVDPhiDtMmF.ay789AL2Ld, G868F8PfVDPhiDtMmF.y118LmRRPb, G868F8PfVDPhiDtMmF.HBO8vduJJP, G868F8PfVDPhiDtMmF.utX84tLkv1, G868F8PfVDPhiDtMmF.Ey28X7YZCv(), G868F8PfVDPhiDtMmF.XnD8Bcliqo, G868F8PfVDPhiDtMmF.mFh8l88ft0, G868F8PfVDPhiDtMmF.mFW8PbTBwj);
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00037140 File Offset: 0x00035540
		[MethodImpl(MethodImplOptions.NoInlining)]
		static G868F8PfVDPhiDtMmF()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			int num = 6;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_5C;
				case 1:
				case 5:
					HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
					num = 8;
					continue;
				case 2:
					G868F8PfVDPhiDtMmF.HLL81cBjb5 = cDhluYseFOthxgEIXpc.nKHKpgTSVU(54044);
					goto IL_A4;
				case 3:
					break;
				case 4:
					goto IL_A4;
				case 6:
					G868F8PfVDPhiDtMmF.vc6ZD4Gbi4mqNv3Op0X();
					G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK();
					num = ((!G868F8PfVDPhiDtMmF.yMDLwM1Nh24MVQKB20V()) ? 9 : 5);
					continue;
				case 7:
					G868F8PfVDPhiDtMmF.PE18wkEsGk = DateTime.MinValue;
					num = 0;
					if (!true)
					{
						goto IL_5C;
					}
					continue;
				case 8:
					G868F8PfVDPhiDtMmF.qil87Ve7N0 = 920;
					G868F8PfVDPhiDtMmF.pSg8aB2ZJQ = true;
					num = 2;
					continue;
				case 9:
					goto IL_B4;
				case 10:
					return;
				default:
					num = 3;
					if (!G868F8PfVDPhiDtMmF.JGctHB1SrU7uqLAwydK())
					{
						continue;
					}
					continue;
				}
				IL_18:
				G868F8PfVDPhiDtMmF.mFW8PbTBwj = "";
				num = 7;
				continue;
				IL_B4:
				G868F8PfVDPhiDtMmF.hfw8OGSGMd = "";
				G868F8PfVDPhiDtMmF.y118LmRRPb = "";
				G868F8PfVDPhiDtMmF.HBO8vduJJP = "";
				G868F8PfVDPhiDtMmF.utX84tLkv1 = "";
				G868F8PfVDPhiDtMmF.XnD8Bcliqo = "";
				G868F8PfVDPhiDtMmF.mFh8l88ft0 = "";
				goto IL_18;
				IL_A4:
				goto IL_B4;
				IL_5C:
				G868F8PfVDPhiDtMmF.T0T85sQfkq = 0;
				G868F8PfVDPhiDtMmF.ay789AL2Ld = "";
				num = 10;
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000372A4 File Offset: 0x000356A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jH51vh1AM5ZSZdTwIuk(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000372C0 File Offset: 0x000356C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YJ4vn91sBMUh7prO7d4(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 + A_1 + A_2;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000372E4 File Offset: 0x000356E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u5E9SQ1fPmHXGv43s6t(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return string.Concat(A_0);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00037300 File Offset: 0x00035700
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int MKt3l01pUaKegAwiIPv(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Fill(A_1);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00037320 File Offset: 0x00035720
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O3Rdxe1OCbNaNC9tx45(DateTime A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 == A_1;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00037340 File Offset: 0x00035740
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object baHOQg1DSwFCFkoaLtg(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((IEnumerator)A_0).Current;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0003735C File Offset: 0x0003575C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mqvJh11UhueQ3koBCDP(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0003737C File Offset: 0x0003577C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P0dVlg1JoAU0MaS8Znu(DateTime A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 > A_1;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0003739C File Offset: 0x0003579C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Plkf7T1INoTjNbst0TR(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0[A_1] = A_2;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000373C0 File Offset: 0x000357C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l68AHl1ZtKe7kyxs0Wi(DateTime A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 < A_1;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x000373E0 File Offset: 0x000357E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void R43JcK1cXAR8PgUWrtf(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x000373FC File Offset: 0x000357FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yMDLwM1Nh24MVQKB20V()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00037410 File Offset: 0x00035810
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JGctHB1SrU7uqLAwydK()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00037424 File Offset: 0x00035824
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tZqPw01z87VjseoTOhq(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Append(A_1);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00037444 File Offset: 0x00035844
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object o7U4hkG3ZOGOdb51Fph(object A_0, DateTime \u0020, DateTime \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return G868F8PfVDPhiDtMmF.pPR8Mqdalg(A_0, \u0020, \u0020);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00037468 File Offset: 0x00035868
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qApkYaGW7rlStc5ibxk(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Rows;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00037484 File Offset: 0x00035884
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int qtj8eoGLmBdml28Y76f(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000374A0 File Offset: 0x000358A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SkO5NZGjxPuR0FUpExb(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000374C0 File Offset: 0x000358C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int X1aZASGXErbjGVuRAAN(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToInt32(A_0);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000374DC File Offset: 0x000358DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JnW1HhGrSDNDoeNmN8Z(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Replace(A_1, A_2);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00037500 File Offset: 0x00035900
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JaNTqoGnSHAtUmsj07X(object A_0, object A_1, StringSplitOptions A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Split(A_1, A_2);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00037524 File Offset: 0x00035924
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int zcVKpPG2wUKRaQPH9QI(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Count;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00037540 File Offset: 0x00035940
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime pGmi2aGTkYdtTQV9OFj(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToDateTime(A_0);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0003755C File Offset: 0x0003595C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uT9KrlGHxGLNoVMBrRd(object A_0, object A_1, object A_2, object A_3)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 + A_1 + A_2 + A_3;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00037584 File Offset: 0x00035984
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool id1MTLGleQacc2aBDsM(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0 == A_1;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000375A4 File Offset: 0x000359A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void F7arCbG7IlUHkVw5Gnp(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			File.Delete(A_0);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000375C0 File Offset: 0x000359C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QuXkAhGQ6V5qm47u7bO(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Write(A_1);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000375E0 File Offset: 0x000359E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dCErsrG1kXrhxEUQ5rH(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Close();
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x000375FC File Offset: 0x000359FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UGP8OAGGaABOKuPIvOv(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Message;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00037618 File Offset: 0x00035A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KITvmeG4fV2RqusAycL(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.LoadXml(A_1);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00037638 File Offset: 0x00035A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G8clRUGtBAEIHRPaAlZ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0[A_1];
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00037658 File Offset: 0x00035A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object i6lXGEGwotBqqZ8CL5V(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00037674 File Offset: 0x00035A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FcVJROGVZypwu3FQXpj(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Attributes;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00037690 File Offset: 0x00035A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int e32OqSGkkoHvuVsN1YL(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Convert.ToInt32(A_0);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000376AC File Offset: 0x00035AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Sm2mHoGdBbNNEAiiICt(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Directory.Exists(A_0);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x000376C8 File Offset: 0x00035AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vc6ZD4Gbi4mqNv3Op0X()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x040002EB RID: 747
		private static int qil87Ve7N0;

		// Token: 0x040002EC RID: 748
		private static bool pSg8aB2ZJQ;

		// Token: 0x040002ED RID: 749
		private static string HLL81cBjb5;

		// Token: 0x040002EE RID: 750
		private static string hfw8OGSGMd;

		// Token: 0x040002EF RID: 751
		private static string y118LmRRPb;

		// Token: 0x040002F0 RID: 752
		private static string HBO8vduJJP;

		// Token: 0x040002F1 RID: 753
		private static string utX84tLkv1;

		// Token: 0x040002F2 RID: 754
		private static string XnD8Bcliqo;

		// Token: 0x040002F3 RID: 755
		private static string mFh8l88ft0;

		// Token: 0x040002F4 RID: 756
		private static string mFW8PbTBwj;

		// Token: 0x040002F5 RID: 757
		private static DateTime PE18wkEsGk;

		// Token: 0x040002F6 RID: 758
		private static int T0T85sQfkq;

		// Token: 0x040002F7 RID: 759
		private static string ay789AL2Ld;
	}
}
