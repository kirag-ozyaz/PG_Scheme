using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using CZUM21s3QjGFLaOaSlT;
using DataSql;
using FormLbr;
using HsEXfKsq15GfPw4kPLQ;
using j5c8XXscsIc6vD2Fg4l;
using RequestsClient.Properties;
using WTbxUfsXa34kJl1qKMV;

namespace RequestsClient.Forms
{
	// Token: 0x02000033 RID: 51
	public partial class TemperatureSR : FormBase
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00008260 File Offset: 0x00006660
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemperatureSR()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 7;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_159;
				case 1:
					TemperatureSR.wmlHW1jdSoy7dhguQca(this.UNW3l6ADjB).Insert(3, new ToolStripControlHost(this.kwm34gVT3t));
					num = 9;
					continue;
				case 2:
					break;
				case 3:
				case 5:
					TemperatureSR.X0YwPtjkLpwlosqUAWx(this.LEN3vghojm, new Size(100, 20));
					goto IL_102;
				default:
					goto IL_102;
				case 6:
					this.LEN3vghojm.Format = DateTimePickerFormat.Short;
					TemperatureSR.wy6EXajVgISneM3B4Yr(this.LEN3vghojm, new DateTime(DateTime.Now.Year, 1, 1));
					if (TemperatureSR.f4ecsHjtAUcmIY5ZDk5())
					{
						num = 0;
						continue;
					}
					num = 5;
					if (TemperatureSR.jxe1V2j4P5gSGL9rlvm())
					{
						continue;
					}
					break;
				case 7:
					HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
					num = 8;
					continue;
				case 8:
					TemperatureSR.ulTRcyjw43uFIjxkX8H(this);
					this.E563LPsPin();
					this.LEN3vghojm = new DateTimePicker();
					num = 6;
					continue;
				case 9:
					return;
				}
				TemperatureSR.wy6EXajVgISneM3B4Yr(this.kwm34gVT3t, new DateTime(DateTime.Now.Year + 1, 1, 1).AddDays(-1.0));
				this.kwm34gVT3t.Size = new Size(100, 20);
				num = 1;
				continue;
				IL_159:
				this.UNW3l6ADjB.Items.Insert(1, new ToolStripControlHost(this.LEN3vghojm));
				this.kwm34gVT3t = new DateTimePicker();
				this.kwm34gVT3t.Format = DateTimePickerFormat.Short;
				num = 2;
				continue;
				IL_102:
				goto IL_159;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00008414 File Offset: 0x00006814
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bv63aPKFYU(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.QbR31OGPc8();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000842C File Offset: 0x0000682C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QbR31OGPc8()
		{
			while (false)
			{
				object obj = null[0];
			}
			new SqlDataCommand(new SQLSettings(cDhluYseFOthxgEIXpc.nKHKpgTSVU(1032), TemperatureSR.ObYheqjbxIqFro1xOaV(1054), TemperatureSR.ObYheqjbxIqFro1xOaV(1062), "", "")).SelectSqlData(this.OIA3AZAIiT.Tables[cDhluYseFOthxgEIXpc.nKHKpgTSVU(1080)], false, string.Concat(new string[]
			{
				TemperatureSR.ObYheqjbxIqFro1xOaV(1120),
				this.LEN3vghojm.Value.ToString(TemperatureSR.ObYheqjbxIqFro1xOaV(1160)),
				cDhluYseFOthxgEIXpc.nKHKpgTSVU(1180),
				TemperatureSR.e0e6vBjFOH8nkvEhTe2(this.kwm34gVT3t).ToString(TemperatureSR.ObYheqjbxIqFro1xOaV(1160)),
				cDhluYseFOthxgEIXpc.nKHKpgTSVU(1218)
			}), null, false, 0);
			new SqlDataCommand(new SQLSettings(cDhluYseFOthxgEIXpc.nKHKpgTSVU(1032), cDhluYseFOthxgEIXpc.nKHKpgTSVU(1268), cDhluYseFOthxgEIXpc.nKHKpgTSVU(1062), "", "")).SelectSqlData(this.KcF3WMcLPT.Tables[cDhluYseFOthxgEIXpc.nKHKpgTSVU(1080)], false, string.Concat(new string[]
			{
				cDhluYseFOthxgEIXpc.nKHKpgTSVU(1120),
				TemperatureSR.e0e6vBjFOH8nkvEhTe2(this.LEN3vghojm).ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(1160)),
				cDhluYseFOthxgEIXpc.nKHKpgTSVU(1180),
				TemperatureSR.e0e6vBjFOH8nkvEhTe2(this.kwm34gVT3t).ToString(cDhluYseFOthxgEIXpc.nKHKpgTSVU(1160)),
				cDhluYseFOthxgEIXpc.nKHKpgTSVU(1218)
			}), null, false, 0);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000085E8 File Offset: 0x000069E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FPr3OO98KU(object \u0020, EventArgs \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			this.QbR31OGPc8();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000086B8 File Offset: 0x00006AB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void E563LPsPin()
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 98;
			for (;;)
			{
				DataGridViewCellStyle dataGridViewCellStyle4;
				switch (num)
				{
				case 0:
					this.bJlII0eZlg.ReadOnly = true;
					num = 99;
					continue;
				case 1:
					this.kHY3hCrdQN.Name = TemperatureSR.ObYheqjbxIqFro1xOaV(1428);
					this.kHY3hCrdQN.Size = new Size(23, 22);
					this.kHY3hCrdQN.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1460);
					num = 35;
					if (false)
					{
						goto IL_7D5;
					}
					continue;
				case 2:
					goto IL_1B05;
				case 3:
					goto IL_1B3D;
				case 4:
					this.GKcIogXbj3 = new DataGridViewTextBoxColumn();
					this.WW132QiVm3 = new BindingSource(this.Xx13B7osBe);
					num = 93;
					continue;
				case 5:
					TemperatureSR.vHNyH3Xnclo7TYsef55(this, false);
					TemperatureSR.MtmaoxX2Ld3esxvoAxX(this);
					num = 107;
					continue;
				case 6:
					this.UNW3l6ADjB.SuspendLayout();
					num = 104;
					continue;
				case 7:
					this.OUSIXuLkyg = new DataGridViewTextBoxColumn();
					this.DwvIqnCJ2U = new DataGridViewTextBoxColumn();
					this.LFcIm7USSk = new DataGridViewTextBoxColumn();
					num = 55;
					if (!true)
					{
						goto IL_180B;
					}
					continue;
				case 8:
					goto IL_DE9;
				case 9:
					this.DZ7Ine7AFn = new DataGridViewTextBoxColumn();
					num = 12;
					continue;
				case 10:
					this.UNW3l6ADjB.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1300);
					num = 13;
					if (false)
					{
						goto IL_12DB;
					}
					continue;
				case 11:
					this.LMFI0TNnIq = new DataGridViewTextBoxColumn();
					num = 4;
					if (!TemperatureSR.jxe1V2j4P5gSGL9rlvm())
					{
						goto IL_11ED;
					}
					continue;
				case 12:
					this.u6GIJfPuJA = new DataGridViewTextBoxColumn();
					num = 11;
					continue;
				case 13:
					TemperatureSR.BZiWnHjEOUfk88Rf5rG(this.JeL3PhRHUL, TemperatureSR.ObYheqjbxIqFro1xOaV(1324));
					this.JeL3PhRHUL.Size = new Size(47, 22);
					TemperatureSR.KccKdhjKWvj17BlpkJp(this.JeL3PhRHUL, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1358));
					num = 51;
					if (!TemperatureSR.jxe1V2j4P5gSGL9rlvm())
					{
						goto IL_81;
					}
					continue;
				case 14:
					this.hF635E6y0O.TabIndex = 0;
					num = 81;
					continue;
				case 15:
					goto IL_814;
				case 16:
					TemperatureSR.SSc7kjjS0UupBF2m1qj(this.J4DIMfGk3O, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1688));
					num = 62;
					continue;
				case 17:
					goto IL_11ED;
				case 18:
					TemperatureSR.DrJwhIjsfRBZq1EwIaf(this.LMFI0TNnIq, DataGridViewAutoSizeColumnMode.Fill);
					num = 24;
					continue;
				case 19:
					this.sIuIsYj06W.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(3436);
					this.sIuIsYj06W.ReadOnly = true;
					num = 69;
					continue;
				case 20:
					goto IL_12F2;
				case 21:
					this.K2N3cnmaeh = new DataGridViewExcelFilter();
					this.Cq5Iu9ZWcH = new DataGridViewFilterDateTimePickerColumn();
					this.J4DIMfGk3O = new DataGridViewTextBoxColumn();
					this.mEBI8YMUsZ = new DataGridViewTextBoxColumn();
					num = 78;
					continue;
				case 22:
					TemperatureSR.KouiDejRlBE64g0bDB3(this.y4539LQ2Pk, 0);
					num = 76;
					if (!true)
					{
						goto IL_1ADA;
					}
					continue;
				case 23:
					this.rkV3d8qBCI.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219));
					this.b2Y3UG9eT7.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2506);
					TemperatureSR.GkZSwDjOIZscTCkHGsB(this.zFf3tuxecq, TemperatureSR.ObYheqjbxIqFro1xOaV(2604));
					TemperatureSR.ybI1Y7j5ZZ4k2QBpwNZ(this.h0v3Dh4fS2.Controls, this.K2N3cnmaeh);
					this.h0v3Dh4fS2.Location = new Point(4, 22);
					this.h0v3Dh4fS2.Name = TemperatureSR.ObYheqjbxIqFro1xOaV(2718);
					this.h0v3Dh4fS2.Padding = new Padding(3);
					this.h0v3Dh4fS2.Size = new Size(843, 425);
					this.h0v3Dh4fS2.TabIndex = 1;
					this.h0v3Dh4fS2.Text = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2740);
					num = 48;
					continue;
				case 24:
					this.LMFI0TNnIq.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2506);
					TemperatureSR.chugT5jA11KZCce2cLS(this.LMFI0TNnIq, TemperatureSR.ObYheqjbxIqFro1xOaV(2506));
					this.LMFI0TNnIq.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2530);
					this.LMFI0TNnIq.ReadOnly = true;
					this.GKcIogXbj3.DataPropertyName = TemperatureSR.ObYheqjbxIqFro1xOaV(2604);
					this.GKcIogXbj3.HeaderText = TemperatureSR.ObYheqjbxIqFro1xOaV(2604);
					TemperatureSR.xkwRo0j6Jv8sUmPPcmy(this.GKcIogXbj3, TemperatureSR.ObYheqjbxIqFro1xOaV(2624));
					this.GKcIogXbj3.ReadOnly = true;
					this.WW132QiVm3.DataMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1080);
					TemperatureSR.fGZSHfjf8sgrxKbpq4p(this.WW132QiVm3, this.OIA3AZAIiT);
					TemperatureSR.jWaAEmjpUGEGIwd3sV2(this.OIA3AZAIiT, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2694));
					this.OIA3AZAIiT.Tables.AddRange(new DataTable[]
					{
						this.y3P3VBsLuX
					});
					this.y3P3VBsLuX.Columns.AddRange(new DataColumn[]
					{
						this.tqZ3Kodgsh,
						this.zYb3QeVx5H,
						this.AW43SIR4os,
						this.GA93kSOkX2,
						this.mIM3fqpte7,
						this.mR436bJj2r,
						this.oW93TBoFya,
						this.rkV3d8qBCI,
						this.b2Y3UG9eT7,
						this.zFf3tuxecq
					});
					this.y3P3VBsLuX.TableName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1080);
					num = 39;
					continue;
				case 25:
					this.K2N3cnmaeh.AllowUserToAddRows = false;
					num = 95;
					continue;
				case 26:
					goto IL_17A9;
				case 27:
					goto IL_FEA;
				case 28:
					this.EIb3pjG4KS.DataSource = this.KcF3WMcLPT;
					TemperatureSR.jWaAEmjpUGEGIwd3sV2(this.KcF3WMcLPT, TemperatureSR.ObYheqjbxIqFro1xOaV(2694));
					TemperatureSR.hb0CKPjZWkwj92FVU0X(this.KcF3WMcLPT).AddRange(new DataTable[]
					{
						this.aga3Hq4RE9
					});
					this.aga3Hq4RE9.Columns.AddRange(new DataColumn[]
					{
						this.rLm3FdsSRo,
						this.wWS3xSX47y,
						this.noQ3yltLTK,
						this.BJo3r4Gx4i,
						this.hfx3iVrXbX,
						this.FJP3YRRh4j,
						this.cwg3Ge3oj7,
						this.BUb3jtZyLk,
						this.WMk3b30b0d,
						this.IOk3Nsg7QM
					});
					num = 92;
					continue;
				case 29:
					goto IL_7D5;
				case 30:
				{
					DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
					DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
					num = 80;
					if (!true)
					{
						goto IL_1A20;
					}
					continue;
				}
				case 31:
					this.KcF3WMcLPT = new DataSet();
					this.aga3Hq4RE9 = new DataTable();
					num = 74;
					if (!TemperatureSR.jxe1V2j4P5gSGL9rlvm())
					{
						goto IL_1899;
					}
					continue;
				case 32:
					this.rEV3EKOjCE = new ToolStripLabel();
					this.kHY3hCrdQN = new ToolStripButton();
					this.RSA3wDKrdp = new TabControl();
					this.hF635E6y0O = new TabPage();
					num = 71;
					continue;
				case 33:
					((ISupportInitialize)this.y3P3VBsLuX).EndInit();
					this.h0v3Dh4fS2.ResumeLayout(false);
					((ISupportInitialize)this.K2N3cnmaeh).EndInit();
					((ISupportInitialize)this.EIb3pjG4KS).EndInit();
					((ISupportInitialize)this.KcF3WMcLPT).EndInit();
					TemperatureSR.VSWCJvXr6Cap2dBjOOb(this.aga3Hq4RE9);
					num = 5;
					continue;
				case 34:
					this.hF635E6y0O.ResumeLayout(false);
					TemperatureSR.VSWCJvXr6Cap2dBjOOb(this.y4539LQ2Pk);
					TemperatureSR.VSWCJvXr6Cap2dBjOOb(this.WW132QiVm3);
					((ISupportInitialize)this.OIA3AZAIiT).EndInit();
					num = 33;
					if (false)
					{
						goto IL_F30;
					}
					continue;
				case 35:
					TemperatureSR.Qrj8baje3MPCIdKFGjR(this.kHY3hCrdQN, new EventHandler(this.FPr3OO98KU));
					TemperatureSR.G4uJ2mjMjmvBZp9b5uC(this.RSA3wDKrdp).Add(this.hF635E6y0O);
					TemperatureSR.ybI1Y7j5ZZ4k2QBpwNZ(this.RSA3wDKrdp.Controls, this.h0v3Dh4fS2);
					this.RSA3wDKrdp.Dock = DockStyle.Fill;
					num = 17;
					continue;
				case 36:
					goto IL_A92;
				case 37:
					this.hfx3iVrXbX.DataType = Type.GetTypeFromHandle(TemperatureSR.NAxEsnjDAHmDlXdwYWN(16777306));
					this.FJP3YRRh4j.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2232);
					this.cwg3Ge3oj7.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2310);
					num = 29;
					continue;
				case 38:
				{
					DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
					this.UNW3l6ADjB = new ToolStrip();
					num = 72;
					continue;
				}
				case 39:
					goto IL_100F;
				case 40:
					TemperatureSR.Ts1Qtajqg7RBYPCqOII(this.y4539LQ2Pk.Columns, new DataGridViewColumn[]
					{
						this.B5g3ziWOu0,
						this.JkJIZie7cf,
						this.NgeI3w6DeC,
						this.bJlII0eZlg,
						this.g1nIgPocOc,
						this.qi7IeNqpnf,
						this.DZ7Ine7AFn,
						this.u6GIJfPuJA,
						this.LMFI0TNnIq,
						this.GKcIogXbj3
					});
					this.y4539LQ2Pk.DataSource = this.WW132QiVm3;
					num = 66;
					continue;
				case 41:
					((ISupportInitialize)this.K2N3cnmaeh).BeginInit();
					((ISupportInitialize)this.EIb3pjG4KS).BeginInit();
					((ISupportInitialize)this.KcF3WMcLPT).BeginInit();
					num = 43;
					if (false)
					{
						goto IL_359;
					}
					continue;
				case 42:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					TemperatureSR.xugMHvjJOCKh4E2i8xZ(this.Cq5Iu9ZWcH, dataGridViewCellStyle3);
					this.Cq5Iu9ZWcH.HeaderText = TemperatureSR.ObYheqjbxIqFro1xOaV(1608);
					num = 102;
					continue;
				}
				case 43:
					((ISupportInitialize)this.aga3Hq4RE9).BeginInit();
					base.SuspendLayout();
					this.UNW3l6ADjB.Items.AddRange(new ToolStripItem[]
					{
						this.JeL3PhRHUL,
						this.rEV3EKOjCE,
						this.kHY3hCrdQN
					});
					this.UNW3l6ADjB.Location = new Point(0, 0);
					this.UNW3l6ADjB.Name = TemperatureSR.ObYheqjbxIqFro1xOaV(1278);
					TemperatureSR.X0YwPtjkLpwlosqUAWx(this.UNW3l6ADjB, new Size(851, 25));
					num = 106;
					if (!TemperatureSR.jxe1V2j4P5gSGL9rlvm())
					{
						goto IL_A92;
					}
					continue;
				case 44:
					TemperatureSR.yxsMJojgVc8kRvH25GB(this.OIA3AZAIiT);
					((ISupportInitialize)this.y3P3VBsLuX).BeginInit();
					num = 70;
					if (!true)
					{
						goto IL_9A4;
					}
					continue;
				case 45:
					TemperatureSR.GkZSwDjOIZscTCkHGsB(this.noQ3yltLTK, TemperatureSR.ObYheqjbxIqFro1xOaV(1824));
					this.noQ3yltLTK.DataType = TemperatureSR.AYrbBbjzcLdNxrthHI2(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777306));
					this.BJo3r4Gx4i.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1960);
					TemperatureSR.YoC2cZjUrhAcAbB6S7W(this.BJo3r4Gx4i, TemperatureSR.AYrbBbjzcLdNxrthHI2(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777306)));
					this.hfx3iVrXbX.ColumnName = TemperatureSR.ObYheqjbxIqFro1xOaV(2096);
					num = 37;
					continue;
				case 46:
					goto IL_1BB;
				case 47:
					this.NgeI3w6DeC = new DataGridViewTextBoxColumn();
					this.bJlII0eZlg = new DataGridViewTextBoxColumn();
					this.g1nIgPocOc = new DataGridViewTextBoxColumn();
					num = 63;
					continue;
				case 48:
					this.h0v3Dh4fS2.UseVisualStyleBackColor = true;
					num = 25;
					continue;
				case 49:
					this.BJo3r4Gx4i = new DataColumn();
					this.hfx3iVrXbX = new DataColumn();
					this.FJP3YRRh4j = new DataColumn();
					this.cwg3Ge3oj7 = new DataColumn();
					num = 100;
					continue;
				case 50:
					TemperatureSR.chugT5jA11KZCce2cLS(this.TuJI7jBpNP, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2604));
					this.TuJI7jBpNP.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(3512);
					this.TuJI7jBpNP.ReadOnly = true;
					this.EIb3pjG4KS.DataMember = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1080);
					num = 28;
					continue;
				case 51:
					this.rEV3EKOjCE.Name = TemperatureSR.ObYheqjbxIqFro1xOaV(1376);
					TemperatureSR.FCXUlIj9ZrHHEW0MYd0(this.rEV3EKOjCE, new Size(48, 22));
					this.rEV3EKOjCE.Text = TemperatureSR.ObYheqjbxIqFro1xOaV(1410);
					num = 97;
					if (!TemperatureSR.f4ecsHjtAUcmIY5ZDk5())
					{
						continue;
					}
					continue;
				case 52:
					TemperatureSR.xkwRo0j6Jv8sUmPPcmy(this.u6GIJfPuJA, TemperatureSR.ObYheqjbxIqFro1xOaV(2432));
					this.u6GIJfPuJA.ReadOnly = true;
					num = 18;
					if (false)
					{
						goto IL_18A;
					}
					continue;
				case 53:
				case 56:
					this.g1nIgPocOc.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2150);
					this.g1nIgPocOc.ReadOnly = true;
					this.qi7IeNqpnf.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					this.qi7IeNqpnf.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2232);
					TemperatureSR.chugT5jA11KZCce2cLS(this.qi7IeNqpnf, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2232));
					this.qi7IeNqpnf.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2246);
					this.qi7IeNqpnf.ReadOnly = true;
					TemperatureSR.SSc7kjjS0UupBF2m1qj(this.DZ7Ine7AFn, TemperatureSR.ObYheqjbxIqFro1xOaV(2310));
					TemperatureSR.chugT5jA11KZCce2cLS(this.DZ7Ine7AFn, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2310));
					this.DZ7Ine7AFn.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2334);
					this.DZ7Ine7AFn.ReadOnly = true;
					TemperatureSR.SSc7kjjS0UupBF2m1qj(this.u6GIJfPuJA, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2408));
					num = 27;
					continue;
				case 54:
					TemperatureSR.gGj1ggjmmNd6T1mIoDa(this.hF635E6y0O);
					((ISupportInitialize)this.y4539LQ2Pk).BeginInit();
					((ISupportInitialize)this.WW132QiVm3).BeginInit();
					num = 44;
					if (!true)
					{
						goto IL_512;
					}
					continue;
				case 55:
					this.sIuIsYj06W = new DataGridViewTextBoxColumn();
					this.TuJI7jBpNP = new DataGridViewTextBoxColumn();
					this.EIb3pjG4KS = new BindingSource(this.Xx13B7osBe);
					num = 31;
					continue;
				case 57:
					TemperatureSR.OvSj9wjahmKVR2XiYHZ(this.K2N3cnmaeh, DataGridViewColumnHeadersHeightSizeMode.AutoSize);
					num = 15;
					continue;
				case 58:
					TemperatureSR.vIkGxhXjmOGYHmCxbpX(this.UNW3l6ADjB, false);
					TemperatureSR.haOfAIXXLS35xOFy2vx(this.UNW3l6ADjB);
					this.RSA3wDKrdp.ResumeLayout(false);
					num = 34;
					continue;
				case 59:
					goto IL_1ADA;
				case 60:
					goto IL_ABA;
				case 61:
					goto IL_81;
				case 62:
					this.J4DIMfGk3O.HeaderText = TemperatureSR.ObYheqjbxIqFro1xOaV(1720);
					this.J4DIMfGk3O.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2882);
					num = 103;
					if (!true)
					{
						goto IL_90B;
					}
					continue;
				case 63:
					this.qi7IeNqpnf = new DataGridViewTextBoxColumn();
					num = 9;
					if (!TemperatureSR.f4ecsHjtAUcmIY5ZDk5())
					{
						continue;
					}
					continue;
				case 64:
					goto IL_9A4;
				case 65:
					goto IL_A6;
				case 66:
					this.y4539LQ2Pk.Dock = DockStyle.Fill;
					this.y4539LQ2Pk.Location = new Point(3, 3);
					num = 83;
					if (false)
					{
						goto IL_C9D;
					}
					continue;
				case 67:
					goto IL_F56;
				case 68:
					TemperatureSR.YoC2cZjUrhAcAbB6S7W(this.BUb3jtZyLk, TemperatureSR.AYrbBbjzcLdNxrthHI2(TemperatureSR.NAxEsnjDAHmDlXdwYWN(16777219)));
					this.WMk3b30b0d.ColumnName = TemperatureSR.ObYheqjbxIqFro1xOaV(2506);
					this.IOk3Nsg7QM.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2604);
					TemperatureSR.kxH7FtX3rOP6NYyEixO(this, new SizeF(6f, 13f));
					num = 79;
					continue;
				case 69:
					this.TuJI7jBpNP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					TemperatureSR.SSc7kjjS0UupBF2m1qj(this.TuJI7jBpNP, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2604));
					num = 50;
					continue;
				case 70:
					goto IL_1899;
				case 71:
					this.y4539LQ2Pk = new DataGridViewExcelFilter();
					this.B5g3ziWOu0 = new DataGridViewFilterDateTimePickerColumn();
					this.JkJIZie7cf = new DataGridViewTextBoxColumn();
					num = 47;
					continue;
				case 72:
					this.JeL3PhRHUL = new ToolStripLabel();
					num = 32;
					continue;
				case 73:
					goto IL_359;
				case 74:
					goto IL_90B;
				case 75:
					goto IL_2EB;
				case 76:
				{
					this.B5g3ziWOu0.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1608);
					DataGridViewCellStyle dataGridViewCellStyle2;
					TemperatureSR.nECblyjyg9kS3LbtPWk(dataGridViewCellStyle2, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1620));
					this.B5g3ziWOu0.DefaultCellStyle = dataGridViewCellStyle2;
					this.B5g3ziWOu0.HeaderText = TemperatureSR.ObYheqjbxIqFro1xOaV(1608);
					TemperatureSR.xkwRo0j6Jv8sUmPPcmy(this.B5g3ziWOu0, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1626));
					this.B5g3ziWOu0.ReadOnly = true;
					this.B5g3ziWOu0.Resizable = DataGridViewTriState.True;
					TemperatureSR.WGf7ZVjNST6t1qc2nDt(this.B5g3ziWOu0, DataGridViewColumnSortMode.Automatic);
					num = 96;
					continue;
				}
				case 77:
				{
					this.Cq5Iu9ZWcH.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1608);
					DataGridViewCellStyle dataGridViewCellStyle3;
					TemperatureSR.nECblyjyg9kS3LbtPWk(dataGridViewCellStyle3, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1620));
					num = 42;
					continue;
				}
				case 78:
					goto IL_512;
				case 79:
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 20;
					continue;
				case 80:
					dataGridViewCellStyle4 = new DataGridViewCellStyle();
					num = 38;
					if (!TemperatureSR.jxe1V2j4P5gSGL9rlvm())
					{
						goto IL_1B3D;
					}
					continue;
				case 81:
				{
					this.hF635E6y0O.Text = TemperatureSR.ObYheqjbxIqFro1xOaV(1528);
					TemperatureSR.TGL7PQjoNtnKjH3pIct(this.hF635E6y0O, true);
					this.y4539LQ2Pk.AllowUserToAddRows = false;
					this.y4539LQ2Pk.AllowUserToDeleteRows = false;
					DataGridViewCellStyle dataGridViewCellStyle;
					dataGridViewCellStyle.BackColor = TemperatureSR.HRgkenjYPdShOkWZW0Y(224, 224, 224);
					TemperatureSR.MZvNetjuqJpcnbYQdAo(this.y4539LQ2Pk, dataGridViewCellStyle);
					this.y4539LQ2Pk.AutoGenerateColumns = false;
					TemperatureSR.OvSj9wjahmKVR2XiYHZ(this.y4539LQ2Pk, DataGridViewColumnHeadersHeightSizeMode.AutoSize);
					num = 40;
					continue;
				}
				case 82:
					this.OUSIXuLkyg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					TemperatureSR.SSc7kjjS0UupBF2m1qj(this.OUSIXuLkyg, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2232));
					this.OUSIXuLkyg.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2232);
					this.OUSIXuLkyg.Name = TemperatureSR.ObYheqjbxIqFro1xOaV(3218);
					num = 75;
					if (!TemperatureSR.jxe1V2j4P5gSGL9rlvm())
					{
						goto IL_2EB;
					}
					continue;
				case 83:
					goto IL_171B;
				case 84:
					this.CGHICS6MED.HeaderText = TemperatureSR.ObYheqjbxIqFro1xOaV(2128);
					num = 8;
					continue;
				case 85:
					goto IL_1367;
				case 86:
					this.NgeI3w6DeC.ReadOnly = true;
					this.bJlII0eZlg.DataPropertyName = TemperatureSR.ObYheqjbxIqFro1xOaV(1960);
					this.bJlII0eZlg.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1992);
					this.bJlII0eZlg.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2014);
					num = 0;
					if (!TemperatureSR.jxe1V2j4P5gSGL9rlvm())
					{
						goto IL_11BC;
					}
					continue;
				case 87:
					goto IL_180B;
				case 88:
					goto IL_18A;
				case 89:
					goto IL_1773;
				case 90:
					this.y3P3VBsLuX = new DataTable();
					num = 105;
					if (false)
					{
						goto IL_FEA;
					}
					continue;
				case 91:
					goto IL_C9D;
				case 92:
					TemperatureSR.AgO04wjcRraHwCxkjh1(this.aga3Hq4RE9, TemperatureSR.ObYheqjbxIqFro1xOaV(1080));
					num = 87;
					continue;
				case 93:
					this.OIA3AZAIiT = new DataSet();
					num = 90;
					continue;
				case 94:
					TemperatureSR.SSc7kjjS0UupBF2m1qj(this.mEBI8YMUsZ, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1824));
					TemperatureSR.chugT5jA11KZCce2cLS(this.mEBI8YMUsZ, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1856));
					TemperatureSR.xkwRo0j6Jv8sUmPPcmy(this.mEBI8YMUsZ, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2966));
					this.mEBI8YMUsZ.ReadOnly = true;
					this.u3wIRHSXA4.DataPropertyName = TemperatureSR.ObYheqjbxIqFro1xOaV(1960);
					this.u3wIRHSXA4.HeaderText = TemperatureSR.ObYheqjbxIqFro1xOaV(1992);
					this.u3wIRHSXA4.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(3050);
					num = 59;
					if (!true)
					{
						goto IL_1700;
					}
					continue;
				case 95:
					goto IL_F30;
				case 96:
					goto IL_1A20;
				case 97:
					goto IL_1A56;
				case 98:
					goto IL_1700;
				case 99:
					this.g1nIgPocOc.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2096);
					this.g1nIgPocOc.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2128);
					break;
				case 100:
					this.BUb3jtZyLk = new DataColumn();
					this.WMk3b30b0d = new DataColumn();
					this.IOk3Nsg7QM = new DataColumn();
					num = 6;
					continue;
				case 101:
					TemperatureSR.chugT5jA11KZCce2cLS(this.sIuIsYj06W, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2506));
					num = 19;
					continue;
				case 102:
					TemperatureSR.xkwRo0j6Jv8sUmPPcmy(this.Cq5Iu9ZWcH, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2818));
					this.Cq5Iu9ZWcH.ReadOnly = true;
					num = 36;
					continue;
				case 103:
					TemperatureSR.xkndRsjI8m8GPYO5Swp(this.J4DIMfGk3O, true);
					num = 94;
					continue;
				case 104:
					goto IL_12DB;
				case 105:
					this.tqZ3Kodgsh = new DataColumn();
					this.zYb3QeVx5H = new DataColumn();
					this.AW43SIR4os = new DataColumn();
					this.GA93kSOkX2 = new DataColumn();
					num = 46;
					if (!true)
					{
						goto IL_DE9;
					}
					continue;
				case 106:
					goto IL_11BC;
				case 107:
					return;
				}
				goto IL_723;
				IL_81:
				this.JkJIZie7cf.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1742);
				num = 73;
				if (!TemperatureSR.f4ecsHjtAUcmIY5ZDk5())
				{
					continue;
				}
				IL_A6:
				this.LFcIm7USSk.Name = TemperatureSR.ObYheqjbxIqFro1xOaV(3360);
				TemperatureSR.xkndRsjI8m8GPYO5Swp(this.LFcIm7USSk, true);
				TemperatureSR.DrJwhIjsfRBZq1EwIaf(this.sIuIsYj06W, DataGridViewAutoSizeColumnMode.Fill);
				TemperatureSR.SSc7kjjS0UupBF2m1qj(this.sIuIsYj06W, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2506));
				num = 101;
				continue;
				IL_18A:
				TemperatureSR.xkndRsjI8m8GPYO5Swp(this.DwvIqnCJ2U, true);
				TemperatureSR.SSc7kjjS0UupBF2m1qj(this.LFcIm7USSk, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2408));
				num = 26;
				if (TemperatureSR.jxe1V2j4P5gSGL9rlvm())
				{
					continue;
				}
				IL_1BB:
				this.mIM3fqpte7 = new DataColumn();
				this.mR436bJj2r = new DataColumn();
				this.oW93TBoFya = new DataColumn();
				this.rkV3d8qBCI = new DataColumn();
				this.b2Y3UG9eT7 = new DataColumn();
				this.zFf3tuxecq = new DataColumn();
				this.h0v3Dh4fS2 = new TabPage();
				num = 21;
				continue;
				IL_2EB:
				this.OUSIXuLkyg.ReadOnly = true;
				TemperatureSR.SSc7kjjS0UupBF2m1qj(this.DwvIqnCJ2U, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2310));
				num = 89;
				continue;
				IL_359:
				this.JkJIZie7cf.ReadOnly = true;
				this.NgeI3w6DeC.DataPropertyName = TemperatureSR.ObYheqjbxIqFro1xOaV(1824);
				TemperatureSR.chugT5jA11KZCce2cLS(this.NgeI3w6DeC, TemperatureSR.ObYheqjbxIqFro1xOaV(1856));
				this.NgeI3w6DeC.Name = TemperatureSR.ObYheqjbxIqFro1xOaV(1878);
				num = 86;
				continue;
				IL_512:
				this.u3wIRHSXA4 = new DataGridViewTextBoxColumn();
				this.CGHICS6MED = new DataGridViewTextBoxColumn();
				num = 7;
				continue;
				IL_723:
				TemperatureSR.jxe1V2j4P5gSGL9rlvm();
				num = (TemperatureSR.f4ecsHjtAUcmIY5ZDk5() ? 2 : 56);
				continue;
				IL_7D5:
				TemperatureSR.YoC2cZjUrhAcAbB6S7W(this.cwg3Ge3oj7, TemperatureSR.AYrbBbjzcLdNxrthHI2(TemperatureSR.NAxEsnjDAHmDlXdwYWN(16777219)));
				this.BUb3jtZyLk.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2408);
				num = 68;
				if (TemperatureSR.jxe1V2j4P5gSGL9rlvm())
				{
					continue;
				}
				IL_814:
				TemperatureSR.Ts1Qtajqg7RBYPCqOII(this.K2N3cnmaeh.Columns, new DataGridViewColumn[]
				{
					this.Cq5Iu9ZWcH,
					this.J4DIMfGk3O,
					this.mEBI8YMUsZ,
					this.u3wIRHSXA4,
					this.CGHICS6MED,
					this.OUSIXuLkyg,
					this.DwvIqnCJ2U,
					this.LFcIm7USSk,
					this.sIuIsYj06W,
					this.TuJI7jBpNP
				});
				this.K2N3cnmaeh.DataSource = this.EIb3pjG4KS;
				this.K2N3cnmaeh.Dock = DockStyle.Fill;
				TemperatureSR.fDpuUMjvKyIrbsVwqnA(this.K2N3cnmaeh, new Point(3, 3));
				num = 64;
				continue;
				IL_90B:
				this.rLm3FdsSRo = new DataColumn();
				this.wWS3xSX47y = new DataColumn();
				this.noQ3yltLTK = new DataColumn();
				num = 49;
				continue;
				IL_9A4:
				TemperatureSR.pdXn7ejCd0Eg97pkath(this.K2N3cnmaeh, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2766));
				this.K2N3cnmaeh.ReadOnly = true;
				this.K2N3cnmaeh.RowHeadersWidth = 21;
				this.K2N3cnmaeh.Size = new Size(837, 419);
				TemperatureSR.KouiDejRlBE64g0bDB3(this.K2N3cnmaeh, 0);
				num = 77;
				continue;
				IL_A92:
				this.Cq5Iu9ZWcH.Resizable = DataGridViewTriState.True;
				this.Cq5Iu9ZWcH.SortMode = DataGridViewColumnSortMode.Automatic;
				num = 16;
				if (TemperatureSR.jxe1V2j4P5gSGL9rlvm())
				{
					continue;
				}
				IL_ABA:
				this.mIM3fqpte7.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777306));
				this.mR436bJj2r.ColumnName = TemperatureSR.ObYheqjbxIqFro1xOaV(2232);
				this.oW93TBoFya.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2310);
				num = 85;
				continue;
				IL_C9D:
				TemperatureSR.YoC2cZjUrhAcAbB6S7W(this.AW43SIR4os, Type.GetTypeFromHandle(TemperatureSR.NAxEsnjDAHmDlXdwYWN(16777306)));
				num = 3;
				continue;
				IL_DE9:
				this.CGHICS6MED.Name = TemperatureSR.ObYheqjbxIqFro1xOaV(3134);
				TemperatureSR.xkndRsjI8m8GPYO5Swp(this.CGHICS6MED, true);
				num = 82;
				continue;
				IL_FEA:
				TemperatureSR.chugT5jA11KZCce2cLS(this.u6GIJfPuJA, TemperatureSR.ObYheqjbxIqFro1xOaV(2408));
				num = 52;
				if (TemperatureSR.jxe1V2j4P5gSGL9rlvm())
				{
					continue;
				}
				IL_100F:
				TemperatureSR.GkZSwDjOIZscTCkHGsB(this.tqZ3Kodgsh, TemperatureSR.ObYheqjbxIqFro1xOaV(1608));
				TemperatureSR.YoC2cZjUrhAcAbB6S7W(this.tqZ3Kodgsh, Type.GetTypeFromHandle(TemperatureSR.NAxEsnjDAHmDlXdwYWN(16777262)));
				TemperatureSR.GkZSwDjOIZscTCkHGsB(this.zYb3QeVx5H, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1688));
				this.zYb3QeVx5H.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777306));
				TemperatureSR.GkZSwDjOIZscTCkHGsB(this.AW43SIR4os, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1824));
				num = 91;
				continue;
				IL_11BC:
				TemperatureSR.KouiDejRlBE64g0bDB3(this.UNW3l6ADjB, 0);
				num = 10;
				continue;
				IL_11ED:
				TemperatureSR.fDpuUMjvKyIrbsVwqnA(this.RSA3wDKrdp, new Point(0, 25));
				TemperatureSR.pdXn7ejCd0Eg97pkath(this.RSA3wDKrdp, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1480));
				TemperatureSR.a1WGeKj08YnWiFX1lR0(this.RSA3wDKrdp, 0);
				TemperatureSR.X0YwPtjkLpwlosqUAWx(this.RSA3wDKrdp, new Size(851, 451));
				this.RSA3wDKrdp.TabIndex = 1;
				TemperatureSR.ybI1Y7j5ZZ4k2QBpwNZ(this.hF635E6y0O.Controls, this.y4539LQ2Pk);
				TemperatureSR.ChxeyqjxdsXMssZBumk(this.hF635E6y0O, new Point(4, 22));
				TemperatureSR.pdXn7ejCd0Eg97pkath(this.hF635E6y0O, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1506));
				TemperatureSR.J7bjUFjhAJonRhQFQqB(this.hF635E6y0O, new Padding(3));
				TemperatureSR.X0YwPtjkLpwlosqUAWx(this.hF635E6y0O, new Size(843, 425));
				num = 14;
				continue;
				IL_12DB:
				this.RSA3wDKrdp.SuspendLayout();
				num = 54;
				if (true)
				{
					continue;
				}
				IL_12F2:
				base.ClientSize = new Size(851, 476);
				base.Controls.Add(this.RSA3wDKrdp);
				TemperatureSR.ybI1Y7j5ZZ4k2QBpwNZ(base.Controls, this.UNW3l6ADjB);
				TemperatureSR.Qt6wAeXW5aIpWfvtgbl(this, cDhluYseFOthxgEIXpc.nKHKpgTSVU(3584));
				TemperatureSR.LKmLH5XLRkio22e5UEW(this, cDhluYseFOthxgEIXpc.nKHKpgTSVU(3614));
				base.Load += this.bv63aPKFYU;
				num = 58;
				if (!false)
				{
					continue;
				}
				IL_1367:
				this.oW93TBoFya.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777219));
				TemperatureSR.GkZSwDjOIZscTCkHGsB(this.rkV3d8qBCI, TemperatureSR.ObYheqjbxIqFro1xOaV(2408));
				num = 23;
				continue;
				IL_1700:
				this.Xx13B7osBe = new Container();
				num = 30;
				if (TemperatureSR.jxe1V2j4P5gSGL9rlvm())
				{
					continue;
				}
				IL_171B:
				this.y4539LQ2Pk.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1556);
				TemperatureSR.WK8GBtj8pNY1sjYgZYu(this.y4539LQ2Pk, true);
				TemperatureSR.wtFVCXjB2pgHGedt8qq(this.y4539LQ2Pk, 21);
				this.y4539LQ2Pk.Size = new Size(837, 419);
				num = 22;
				if (TemperatureSR.jxe1V2j4P5gSGL9rlvm())
				{
					continue;
				}
				IL_1773:
				TemperatureSR.chugT5jA11KZCce2cLS(this.DwvIqnCJ2U, TemperatureSR.ObYheqjbxIqFro1xOaV(2310));
				this.DwvIqnCJ2U.Name = cDhluYseFOthxgEIXpc.nKHKpgTSVU(3284);
				num = 88;
				if (!false)
				{
					continue;
				}
				IL_17A9:
				this.LFcIm7USSk.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2408);
				num = 65;
				continue;
				IL_180B:
				this.rLm3FdsSRo.ColumnName = TemperatureSR.ObYheqjbxIqFro1xOaV(1608);
				this.rLm3FdsSRo.DataType = TemperatureSR.AYrbBbjzcLdNxrthHI2(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777262));
				TemperatureSR.GkZSwDjOIZscTCkHGsB(this.wWS3xSX47y, TemperatureSR.ObYheqjbxIqFro1xOaV(1688));
				this.wWS3xSX47y.DataType = TemperatureSR.AYrbBbjzcLdNxrthHI2(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777306));
				num = 45;
				continue;
				IL_1899:
				this.h0v3Dh4fS2.SuspendLayout();
				num = 41;
				if (!TemperatureSR.f4ecsHjtAUcmIY5ZDk5())
				{
					continue;
				}
				continue;
				IL_1A20:
				TemperatureSR.SSc7kjjS0UupBF2m1qj(this.JkJIZie7cf, cDhluYseFOthxgEIXpc.nKHKpgTSVU(1688));
				this.JkJIZie7cf.HeaderText = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1720);
				num = 61;
				if (!false)
				{
					continue;
				}
				IL_1A56:
				TemperatureSR.b50MYHji3HNlKXpZ5nG(this.kHY3hCrdQN, ToolStripItemDisplayStyle.Image);
				this.kHY3hCrdQN.Image = Resources.RYV3qcVRCG();
				this.kHY3hCrdQN.ImageTransparentColor = Color.Magenta;
				num = 1;
				continue;
				IL_1ADA:
				TemperatureSR.xkndRsjI8m8GPYO5Swp(this.u3wIRHSXA4, true);
				this.CGHICS6MED.DataPropertyName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(2096);
				num = 84;
				continue;
				IL_1B05:
				TemperatureSR.MZvNetjuqJpcnbYQdAo(this.K2N3cnmaeh, dataGridViewCellStyle4);
				this.K2N3cnmaeh.AutoGenerateColumns = false;
				num = 57;
				continue;
				IL_F56:
				goto IL_1B05;
				IL_F30:
				this.K2N3cnmaeh.AllowUserToDeleteRows = false;
				dataGridViewCellStyle4.BackColor = TemperatureSR.HRgkenjYPdShOkWZW0Y(224, 224, 224);
				goto IL_F56;
				IL_1B3D:
				this.GA93kSOkX2.ColumnName = cDhluYseFOthxgEIXpc.nKHKpgTSVU(1960);
				this.GA93kSOkX2.DataType = Type.GetTypeFromHandle(nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(16777306));
				TemperatureSR.GkZSwDjOIZscTCkHGsB(this.mIM3fqpte7, cDhluYseFOthxgEIXpc.nKHKpgTSVU(2096));
				num = 60;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A2E0 File Offset: 0x000086E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TemperatureSR()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			TemperatureSR.no8yKdXTc5aSVj9S94P();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A2F8 File Offset: 0x000086F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ulTRcyjw43uFIjxkX8H(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A314 File Offset: 0x00008714
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wy6EXajVgISneM3B4Yr(object A_0, DateTime A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Value = A_1;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A334 File Offset: 0x00008734
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void X0YwPtjkLpwlosqUAWx(object A_0, Size A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Size = A_1;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A354 File Offset: 0x00008754
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wmlHW1jdSoy7dhguQca(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Items;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A370 File Offset: 0x00008770
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jxe1V2j4P5gSGL9rlvm()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A384 File Offset: 0x00008784
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f4ecsHjtAUcmIY5ZDk5()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A398 File Offset: 0x00008798
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ObYheqjbxIqFro1xOaV(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000A3B4 File Offset: 0x000087B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime e0e6vBjFOH8nkvEhTe2(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Value;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A3D0 File Offset: 0x000087D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mcd8LdjPj8ltQGMeS2V(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Dispose(A_1);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A3F0 File Offset: 0x000087F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gGj1ggjmmNd6T1mIoDa(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SuspendLayout();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A40C File Offset: 0x0000880C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yxsMJojgVc8kRvH25GB(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((ISupportInitialize)A_0).BeginInit();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000A428 File Offset: 0x00008828
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KouiDejRlBE64g0bDB3(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TabIndex = A_1;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A448 File Offset: 0x00008848
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BZiWnHjEOUfk88Rf5rG(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A468 File Offset: 0x00008868
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KccKdhjKWvj17BlpkJp(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Text = A_1;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000A488 File Offset: 0x00008888
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FCXUlIj9ZrHHEW0MYd0(object A_0, Size A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Size = A_1;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000A4A8 File Offset: 0x000088A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void b50MYHji3HNlKXpZ5nG(object A_0, ToolStripItemDisplayStyle A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DisplayStyle = A_1;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000A4C8 File Offset: 0x000088C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Qrj8baje3MPCIdKFGjR(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Click += A_1;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000A4E8 File Offset: 0x000088E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G4uJ2mjMjmvBZp9b5uC(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Controls;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000A504 File Offset: 0x00008904
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ybI1Y7j5ZZ4k2QBpwNZ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Add(A_1);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000A524 File Offset: 0x00008924
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fDpuUMjvKyIrbsVwqnA(object A_0, Point A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Location = A_1;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000A544 File Offset: 0x00008944
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pdXn7ejCd0Eg97pkath(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000A564 File Offset: 0x00008964
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void a1WGeKj08YnWiFX1lR0(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SelectedIndex = A_1;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000A584 File Offset: 0x00008984
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ChxeyqjxdsXMssZBumk(object A_0, Point A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Location = A_1;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000A5A4 File Offset: 0x000089A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void J7bjUFjhAJonRhQFQqB(object A_0, Padding A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Padding = A_1;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000A5C4 File Offset: 0x000089C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TGL7PQjoNtnKjH3pIct(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.UseVisualStyleBackColor = A_1;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000A5E4 File Offset: 0x000089E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color HRgkenjYPdShOkWZW0Y(int A_0, int A_1, int A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Color.FromArgb(A_0, A_1, A_2);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000A608 File Offset: 0x00008A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MZvNetjuqJpcnbYQdAo(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AlternatingRowsDefaultCellStyle = A_1;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000A628 File Offset: 0x00008A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OvSj9wjahmKVR2XiYHZ(object A_0, DataGridViewColumnHeadersHeightSizeMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ColumnHeadersHeightSizeMode = A_1;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000A648 File Offset: 0x00008A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ts1Qtajqg7RBYPCqOII(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AddRange(A_1);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000A668 File Offset: 0x00008A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WK8GBtj8pNY1sjYgZYu(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ReadOnly = A_1;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000A688 File Offset: 0x00008A88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wtFVCXjB2pgHGedt8qq(object A_0, int A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.RowHeadersWidth = A_1;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000A6A8 File Offset: 0x00008AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nECblyjyg9kS3LbtPWk(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Format = A_1;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000A6C8 File Offset: 0x00008AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xkwRo0j6Jv8sUmPPcmy(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000A6E8 File Offset: 0x00008AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WGf7ZVjNST6t1qc2nDt(object A_0, DataGridViewColumnSortMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.SortMode = A_1;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000A708 File Offset: 0x00008B08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SSc7kjjS0UupBF2m1qj(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DataPropertyName = A_1;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000A728 File Offset: 0x00008B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void chugT5jA11KZCce2cLS(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.HeaderText = A_1;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000A748 File Offset: 0x00008B48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DrJwhIjsfRBZq1EwIaf(object A_0, DataGridViewAutoSizeColumnMode A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoSizeMode = A_1;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000A768 File Offset: 0x00008B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fGZSHfjf8sgrxKbpq4p(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DataSource = A_1;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000A788 File Offset: 0x00008B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jWaAEmjpUGEGIwd3sV2(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DataSetName = A_1;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000A7A8 File Offset: 0x00008BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GkZSwDjOIZscTCkHGsB(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ColumnName = A_1;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000A7C8 File Offset: 0x00008BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RuntimeTypeHandle NAxEsnjDAHmDlXdwYWN(int token)
		{
			while (false)
			{
				object obj = null[0];
			}
			return nYiRMDsROepA93gsTfY.PVLX7ZtVhFTAw(token);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000A7E4 File Offset: 0x00008BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YoC2cZjUrhAcAbB6S7W(object A_0, Type A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DataType = A_1;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000A804 File Offset: 0x00008C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xugMHvjJOCKh4E2i8xZ(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.DefaultCellStyle = A_1;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000A824 File Offset: 0x00008C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xkndRsjI8m8GPYO5Swp(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ReadOnly = A_1;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000A844 File Offset: 0x00008C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hb0CKPjZWkwj92FVU0X(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return A_0.Tables;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000A860 File Offset: 0x00008C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AgO04wjcRraHwCxkjh1(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.TableName = A_1;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000A880 File Offset: 0x00008C80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type AYrbBbjzcLdNxrthHI2(RuntimeTypeHandle A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000A89C File Offset: 0x00008C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kxH7FtX3rOP6NYyEixO(object A_0, SizeF A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.AutoScaleDimensions = A_1;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000A8BC File Offset: 0x00008CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Qt6wAeXW5aIpWfvtgbl(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Name = A_1;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000A8DC File Offset: 0x00008CDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LKmLH5XLRkio22e5UEW(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.Text = A_1;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000A8FC File Offset: 0x00008CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vIkGxhXjmOGYHmCxbpX(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000A91C File Offset: 0x00008D1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void haOfAIXXLS35xOFy2vx(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.PerformLayout();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000A938 File Offset: 0x00008D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VSWCJvXr6Cap2dBjOOb(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((ISupportInitialize)A_0).EndInit();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000A954 File Offset: 0x00008D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vHNyH3Xnclo7TYsef55(object A_0, bool A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000A974 File Offset: 0x00008D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MtmaoxX2Ld3esxvoAxX(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0.PerformLayout();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000A990 File Offset: 0x00008D90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void no8yKdXTc5aSVj9S94P()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000054 RID: 84
		private DateTimePicker LEN3vghojm;

		// Token: 0x04000055 RID: 85
		private DateTimePicker kwm34gVT3t;

		// Token: 0x04000057 RID: 87
		private ToolStrip UNW3l6ADjB;

		// Token: 0x04000058 RID: 88
		private ToolStripLabel JeL3PhRHUL;

		// Token: 0x04000059 RID: 89
		private TabControl RSA3wDKrdp;

		// Token: 0x0400005A RID: 90
		private TabPage hF635E6y0O;

		// Token: 0x0400005B RID: 91
		private DataGridViewExcelFilter y4539LQ2Pk;

		// Token: 0x0400005C RID: 92
		private BindingSource WW132QiVm3;

		// Token: 0x0400005D RID: 93
		private DataSet OIA3AZAIiT;

		// Token: 0x0400005E RID: 94
		private DataTable y3P3VBsLuX;

		// Token: 0x0400005F RID: 95
		private DataColumn tqZ3Kodgsh;

		// Token: 0x04000060 RID: 96
		private DataColumn zYb3QeVx5H;

		// Token: 0x04000061 RID: 97
		private DataColumn AW43SIR4os;

		// Token: 0x04000062 RID: 98
		private DataColumn GA93kSOkX2;

		// Token: 0x04000063 RID: 99
		private DataColumn mIM3fqpte7;

		// Token: 0x04000064 RID: 100
		private DataColumn mR436bJj2r;

		// Token: 0x04000065 RID: 101
		private DataColumn oW93TBoFya;

		// Token: 0x04000066 RID: 102
		private DataColumn rkV3d8qBCI;

		// Token: 0x04000067 RID: 103
		private DataColumn b2Y3UG9eT7;

		// Token: 0x04000068 RID: 104
		private DataColumn zFf3tuxecq;

		// Token: 0x04000069 RID: 105
		private TabPage h0v3Dh4fS2;

		// Token: 0x0400006A RID: 106
		private DataGridViewExcelFilter K2N3cnmaeh;

		// Token: 0x0400006B RID: 107
		private BindingSource EIb3pjG4KS;

		// Token: 0x0400006C RID: 108
		private DataSet KcF3WMcLPT;

		// Token: 0x0400006D RID: 109
		private DataTable aga3Hq4RE9;

		// Token: 0x0400006E RID: 110
		private DataColumn rLm3FdsSRo;

		// Token: 0x0400006F RID: 111
		private DataColumn wWS3xSX47y;

		// Token: 0x04000070 RID: 112
		private DataColumn noQ3yltLTK;

		// Token: 0x04000071 RID: 113
		private DataColumn BJo3r4Gx4i;

		// Token: 0x04000072 RID: 114
		private DataColumn hfx3iVrXbX;

		// Token: 0x04000073 RID: 115
		private DataColumn FJP3YRRh4j;

		// Token: 0x04000074 RID: 116
		private DataColumn cwg3Ge3oj7;

		// Token: 0x04000075 RID: 117
		private DataColumn BUb3jtZyLk;

		// Token: 0x04000076 RID: 118
		private DataColumn WMk3b30b0d;

		// Token: 0x04000077 RID: 119
		private DataColumn IOk3Nsg7QM;

		// Token: 0x04000078 RID: 120
		private ToolStripLabel rEV3EKOjCE;

		// Token: 0x04000079 RID: 121
		private ToolStripButton kHY3hCrdQN;

		// Token: 0x0400007A RID: 122
		private DataGridViewFilterDateTimePickerColumn B5g3ziWOu0;

		// Token: 0x0400007B RID: 123
		private DataGridViewTextBoxColumn JkJIZie7cf;

		// Token: 0x0400007C RID: 124
		private DataGridViewTextBoxColumn NgeI3w6DeC;

		// Token: 0x0400007D RID: 125
		private DataGridViewTextBoxColumn bJlII0eZlg;

		// Token: 0x0400007E RID: 126
		private DataGridViewTextBoxColumn g1nIgPocOc;

		// Token: 0x0400007F RID: 127
		private DataGridViewTextBoxColumn qi7IeNqpnf;

		// Token: 0x04000080 RID: 128
		private DataGridViewTextBoxColumn DZ7Ine7AFn;

		// Token: 0x04000081 RID: 129
		private DataGridViewTextBoxColumn u6GIJfPuJA;

		// Token: 0x04000082 RID: 130
		private DataGridViewTextBoxColumn LMFI0TNnIq;

		// Token: 0x04000083 RID: 131
		private DataGridViewTextBoxColumn GKcIogXbj3;

		// Token: 0x04000084 RID: 132
		private DataGridViewFilterDateTimePickerColumn Cq5Iu9ZWcH;

		// Token: 0x04000085 RID: 133
		private DataGridViewTextBoxColumn J4DIMfGk3O;

		// Token: 0x04000086 RID: 134
		private DataGridViewTextBoxColumn mEBI8YMUsZ;

		// Token: 0x04000087 RID: 135
		private DataGridViewTextBoxColumn u3wIRHSXA4;

		// Token: 0x04000088 RID: 136
		private DataGridViewTextBoxColumn CGHICS6MED;

		// Token: 0x04000089 RID: 137
		private DataGridViewTextBoxColumn OUSIXuLkyg;

		// Token: 0x0400008A RID: 138
		private DataGridViewTextBoxColumn DwvIqnCJ2U;

		// Token: 0x0400008B RID: 139
		private DataGridViewTextBoxColumn LFcIm7USSk;

		// Token: 0x0400008C RID: 140
		private DataGridViewTextBoxColumn sIuIsYj06W;

		// Token: 0x0400008D RID: 141
		private DataGridViewTextBoxColumn TuJI7jBpNP;
	}
}
