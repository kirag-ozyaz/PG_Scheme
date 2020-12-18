using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using RequestsClient.Properties;

namespace RequestsClient.Forms
{
	// Token: 0x02000040 RID: 64
	public partial class TemperatureSR : FormBase
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00007960 File Offset: 0x00005B60
		public TemperatureSR()
		{
			this.a();
			this.a = new DateTimePicker();
			this.a.Format = DateTimePickerFormat.Short;
			this.a.Value = new DateTime(DateTime.Now.Year, 1, 1);
			this.a.Size = new Size(100, 20);
			this.d.Items.Insert(1, new ToolStripControlHost(this.a));
			this.b = new DateTimePicker();
			this.b.Format = DateTimePickerFormat.Short;
			this.b.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddDays(-1.0);
			this.b.Size = new Size(100, 20);
			this.d.Items.Insert(3, new ToolStripControlHost(this.b));
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00007A58 File Offset: 0x00005C58
		private void b(object A_0, EventArgs A_1)
		{
			this.b();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00007A60 File Offset: 0x00005C60
		private void b()
		{
			new SqlDataCommand(new SQLSettings("ulges-sql", "SR", "WINDOWS", "", "")).SelectSqlData(this.j.Tables["СоставительНизкого"], false, string.Concat(new string[]
			{
				" where [Дата] >= '",
				this.a.Value.ToString("yyyyMMdd"),
				"' and [Дата] <= '",
				this.b.Value.ToString("yyyyMMdd"),
				"' order by [Дата] desc "
			}), null, false, 0);
			new SqlDataCommand(new SQLSettings("ulges-sql", "SR4", "WINDOWS", "", "")).SelectSqlData(this.y.Tables["СоставительНизкого"], false, string.Concat(new string[]
			{
				" where [Дата] >= '",
				this.a.Value.ToString("yyyyMMdd"),
				"' and [Дата] <= '",
				this.b.Value.ToString("yyyyMMdd"),
				"' order by [Дата] desc "
			}), null, false, 0);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00007BB3 File Offset: 0x00005DB3
		private void a(object A_0, EventArgs A_1)
		{
			this.b();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007BDC File Offset: 0x00005DDC
		private void a()
		{
			this.c = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			this.d = new ToolStrip();
			this.e = new ToolStripLabel();
			this.ak = new ToolStripLabel();
			this.al = new ToolStripButton();
			this.f = new TabControl();
			this.g = new TabPage();
			this.h = new DataGridViewExcelFilter();
			this.am = new DataGridViewFilterDateTimePickerColumn();
			this.an = new DataGridViewTextBoxColumn();
			this.ao = new DataGridViewTextBoxColumn();
			this.ap = new DataGridViewTextBoxColumn();
			this.aq = new DataGridViewTextBoxColumn();
			this.ar = new DataGridViewTextBoxColumn();
			this.@as = new DataGridViewTextBoxColumn();
			this.at = new DataGridViewTextBoxColumn();
			this.au = new DataGridViewTextBoxColumn();
			this.av = new DataGridViewTextBoxColumn();
			this.i = new BindingSource(this.c);
			this.j = new DataSet();
			this.k = new DataTable();
			this.l = new DataColumn();
			this.m = new DataColumn();
			this.n = new DataColumn();
			this.o = new DataColumn();
			this.p = new DataColumn();
			this.q = new DataColumn();
			this.r = new DataColumn();
			this.s = new DataColumn();
			this.t = new DataColumn();
			this.u = new DataColumn();
			this.v = new TabPage();
			this.w = new DataGridViewExcelFilter();
			this.aw = new DataGridViewFilterDateTimePickerColumn();
			this.ax = new DataGridViewTextBoxColumn();
			this.ay = new DataGridViewTextBoxColumn();
			this.az = new DataGridViewTextBoxColumn();
			this.a0 = new DataGridViewTextBoxColumn();
			this.a1 = new DataGridViewTextBoxColumn();
			this.a2 = new DataGridViewTextBoxColumn();
			this.a3 = new DataGridViewTextBoxColumn();
			this.a4 = new DataGridViewTextBoxColumn();
			this.a5 = new DataGridViewTextBoxColumn();
			this.x = new BindingSource(this.c);
			this.y = new DataSet();
			this.z = new DataTable();
			this.aa = new DataColumn();
			this.ab = new DataColumn();
			this.ac = new DataColumn();
			this.ad = new DataColumn();
			this.ae = new DataColumn();
			this.af = new DataColumn();
			this.ag = new DataColumn();
			this.ah = new DataColumn();
			this.ai = new DataColumn();
			this.aj = new DataColumn();
			this.d.SuspendLayout();
			this.f.SuspendLayout();
			this.g.SuspendLayout();
			((ISupportInitialize)this.h).BeginInit();
			((ISupportInitialize)this.i).BeginInit();
			((ISupportInitialize)this.j).BeginInit();
			((ISupportInitialize)this.k).BeginInit();
			this.v.SuspendLayout();
			((ISupportInitialize)this.w).BeginInit();
			((ISupportInitialize)this.x).BeginInit();
			((ISupportInitialize)this.y).BeginInit();
			((ISupportInitialize)this.z).BeginInit();
			base.SuspendLayout();
			this.d.Items.AddRange(new ToolStripItem[]
			{
				this.e,
				this.ak,
				this.al
			});
			this.d.Location = new Point(0, 0);
			this.d.Name = "toolStrip";
			this.d.Size = new Size(851, 25);
			this.d.TabIndex = 0;
			this.d.Text = "toolStrip1";
			this.e.Name = "toolStripLabel1";
			this.e.Size = new Size(47, 22);
			this.e.Text = "Дата от";
			this.ak.Name = "toolStripLabel2";
			this.ak.Size = new Size(48, 22);
			this.ak.Text = "Дата до";
			this.al.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.al.Image = Resources.refresh_16;
			this.al.ImageTransparentColor = Color.Magenta;
			this.al.Name = "toolBtnRefresh";
			this.al.Size = new Size(23, 22);
			this.al.Text = "Обновить";
			this.al.Click += this.a;
			this.f.Controls.Add(this.g);
			this.f.Controls.Add(this.v);
			this.f.Dock = DockStyle.Fill;
			this.f.Location = new Point(0, 25);
			this.f.Name = "tabControl1";
			this.f.SelectedIndex = 0;
			this.f.Size = new Size(851, 451);
			this.f.TabIndex = 1;
			this.g.Controls.Add(this.h);
			this.g.Location = new Point(4, 22);
			this.g.Name = "tabPagePB";
			this.g.Padding = new Padding(3);
			this.g.Size = new Size(843, 425);
			this.g.TabIndex = 0;
			this.g.Text = "Правый берег";
			this.g.UseVisualStyleBackColor = true;
			this.h.AllowUserToAddRows = false;
			this.h.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
			this.h.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.h.AutoGenerateColumns = false;
			this.h.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.h.Columns.AddRange(new DataGridViewColumn[]
			{
				this.am,
				this.an,
				this.ao,
				this.ap,
				this.aq,
				this.ar,
				this.@as,
				this.at,
				this.au,
				this.av
			});
			this.h.DataSource = this.i;
			this.h.Dock = DockStyle.Fill;
			this.h.Location = new Point(3, 3);
			this.h.Name = "dataGridViewExcelFilter1";
			this.h.ReadOnly = true;
			this.h.RowHeadersWidth = 21;
			this.h.Size = new Size(837, 419);
			this.h.TabIndex = 0;
			this.am.DataPropertyName = "Дата";
			dataGridViewCellStyle2.Format = "d";
			this.am.DefaultCellStyle = dataGridViewCellStyle2;
			this.am.HeaderText = "Дата";
			this.am.Name = "датаDataGridViewTextBoxColumn";
			this.am.ReadOnly = true;
			this.am.Resizable = DataGridViewTriState.True;
			this.am.SortMode = DataGridViewColumnSortMode.Automatic;
			this.an.DataPropertyName = "ТемператураНОт";
			this.an.HeaderText = "t Ночь От";
			this.an.Name = "температураНОтDataGridViewTextBoxColumn";
			this.an.ReadOnly = true;
			this.ao.DataPropertyName = "ТемператураНДо";
			this.ao.HeaderText = "t Ночь До";
			this.ao.Name = "температураНДоDataGridViewTextBoxColumn";
			this.ao.ReadOnly = true;
			this.ap.DataPropertyName = "ТемператураДОт";
			this.ap.HeaderText = "t День От";
			this.ap.Name = "температураДОтDataGridViewTextBoxColumn";
			this.ap.ReadOnly = true;
			this.aq.DataPropertyName = "ТемператураДДо";
			this.aq.HeaderText = "t День До";
			this.aq.Name = "температураДДоDataGridViewTextBoxColumn";
			this.aq.ReadOnly = true;
			this.ar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ar.DataPropertyName = "Ветер";
			this.ar.HeaderText = "Ветер";
			this.ar.Name = "ветерDataGridViewTextBoxColumn";
			this.ar.ReadOnly = true;
			this.@as.DataPropertyName = "СкоростьОт";
			this.@as.HeaderText = "СкоростьОт";
			this.@as.Name = "скоростьОтDataGridViewTextBoxColumn";
			this.@as.ReadOnly = true;
			this.at.DataPropertyName = "СкоростьДо";
			this.at.HeaderText = "СкоростьДо";
			this.at.Name = "скоростьДоDataGridViewTextBoxColumn";
			this.at.ReadOnly = true;
			this.au.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.au.DataPropertyName = "Примечание";
			this.au.HeaderText = "Примечание";
			this.au.Name = "примечаниеDataGridViewTextBoxColumn";
			this.au.ReadOnly = true;
			this.av.DataPropertyName = "Составил";
			this.av.HeaderText = "Составил";
			this.av.Name = "составилDataGridViewTextBoxColumn";
			this.av.ReadOnly = true;
			this.i.DataMember = "СоставительНизкого";
			this.i.DataSource = this.j;
			this.j.DataSetName = "NewDataSet";
			this.j.Tables.AddRange(new DataTable[]
			{
				this.k
			});
			this.k.Columns.AddRange(new DataColumn[]
			{
				this.l,
				this.m,
				this.n,
				this.o,
				this.p,
				this.q,
				this.r,
				this.s,
				this.t,
				this.u
			});
			this.k.TableName = "СоставительНизкого";
			this.l.ColumnName = "Дата";
			this.l.DataType = typeof(DateTime);
			this.m.ColumnName = "ТемператураНОт";
			this.m.DataType = typeof(short);
			this.n.ColumnName = "ТемператураНДо";
			this.n.DataType = typeof(short);
			this.o.ColumnName = "ТемператураДОт";
			this.o.DataType = typeof(short);
			this.p.ColumnName = "ТемператураДДо";
			this.p.DataType = typeof(short);
			this.q.ColumnName = "Ветер";
			this.r.ColumnName = "СкоростьОт";
			this.r.DataType = typeof(int);
			this.s.ColumnName = "СкоростьДо";
			this.s.DataType = typeof(int);
			this.t.ColumnName = "Примечание";
			this.u.ColumnName = "Составил";
			this.v.Controls.Add(this.w);
			this.v.Location = new Point(4, 22);
			this.v.Name = "tabPageLB";
			this.v.Padding = new Padding(3);
			this.v.Size = new Size(843, 425);
			this.v.TabIndex = 1;
			this.v.Text = "Левый берег";
			this.v.UseVisualStyleBackColor = true;
			this.w.AllowUserToAddRows = false;
			this.w.AllowUserToDeleteRows = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
			this.w.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.w.AutoGenerateColumns = false;
			this.w.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.w.Columns.AddRange(new DataGridViewColumn[]
			{
				this.aw,
				this.ax,
				this.ay,
				this.az,
				this.a0,
				this.a1,
				this.a2,
				this.a3,
				this.a4,
				this.a5
			});
			this.w.DataSource = this.x;
			this.w.Dock = DockStyle.Fill;
			this.w.Location = new Point(3, 3);
			this.w.Name = "dataGridViewExcelFilter2";
			this.w.ReadOnly = true;
			this.w.RowHeadersWidth = 21;
			this.w.Size = new Size(837, 419);
			this.w.TabIndex = 0;
			this.aw.DataPropertyName = "Дата";
			dataGridViewCellStyle4.Format = "d";
			this.aw.DefaultCellStyle = dataGridViewCellStyle4;
			this.aw.HeaderText = "Дата";
			this.aw.Name = "датаDataGridViewTextBoxColumn1";
			this.aw.ReadOnly = true;
			this.aw.Resizable = DataGridViewTriState.True;
			this.aw.SortMode = DataGridViewColumnSortMode.Automatic;
			this.ax.DataPropertyName = "ТемператураНОт";
			this.ax.HeaderText = "t Ночь От";
			this.ax.Name = "температураНОтDataGridViewTextBoxColumn1";
			this.ax.ReadOnly = true;
			this.ay.DataPropertyName = "ТемператураНДо";
			this.ay.HeaderText = "t Ночь До";
			this.ay.Name = "температураНДоDataGridViewTextBoxColumn1";
			this.ay.ReadOnly = true;
			this.az.DataPropertyName = "ТемператураДОт";
			this.az.HeaderText = "t День От";
			this.az.Name = "температураДОтDataGridViewTextBoxColumn1";
			this.az.ReadOnly = true;
			this.a0.DataPropertyName = "ТемператураДДо";
			this.a0.HeaderText = "t День До";
			this.a0.Name = "температураДДоDataGridViewTextBoxColumn1";
			this.a0.ReadOnly = true;
			this.a1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.a1.DataPropertyName = "Ветер";
			this.a1.HeaderText = "Ветер";
			this.a1.Name = "ветерDataGridViewTextBoxColumn1";
			this.a1.ReadOnly = true;
			this.a2.DataPropertyName = "СкоростьОт";
			this.a2.HeaderText = "СкоростьОт";
			this.a2.Name = "скоростьОтDataGridViewTextBoxColumn1";
			this.a2.ReadOnly = true;
			this.a3.DataPropertyName = "СкоростьДо";
			this.a3.HeaderText = "СкоростьДо";
			this.a3.Name = "скоростьДоDataGridViewTextBoxColumn1";
			this.a3.ReadOnly = true;
			this.a4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.a4.DataPropertyName = "Примечание";
			this.a4.HeaderText = "Примечание";
			this.a4.Name = "примечаниеDataGridViewTextBoxColumn1";
			this.a4.ReadOnly = true;
			this.a5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.a5.DataPropertyName = "Составил";
			this.a5.HeaderText = "Составил";
			this.a5.Name = "составилDataGridViewTextBoxColumn1";
			this.a5.ReadOnly = true;
			this.x.DataMember = "СоставительНизкого";
			this.x.DataSource = this.y;
			this.y.DataSetName = "NewDataSet";
			this.y.Tables.AddRange(new DataTable[]
			{
				this.z
			});
			this.z.Columns.AddRange(new DataColumn[]
			{
				this.aa,
				this.ab,
				this.ac,
				this.ad,
				this.ae,
				this.af,
				this.ag,
				this.ah,
				this.ai,
				this.aj
			});
			this.z.TableName = "СоставительНизкого";
			this.aa.ColumnName = "Дата";
			this.aa.DataType = typeof(DateTime);
			this.ab.ColumnName = "ТемператураНОт";
			this.ab.DataType = typeof(short);
			this.ac.ColumnName = "ТемператураНДо";
			this.ac.DataType = typeof(short);
			this.ad.ColumnName = "ТемператураДОт";
			this.ad.DataType = typeof(short);
			this.ae.ColumnName = "ТемператураДДо";
			this.ae.DataType = typeof(short);
			this.af.ColumnName = "Ветер";
			this.ag.ColumnName = "СкоростьОт";
			this.ag.DataType = typeof(int);
			this.ah.ColumnName = "СкоростьДо";
			this.ah.DataType = typeof(int);
			this.ai.ColumnName = "Примечание";
			this.aj.ColumnName = "Составил";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(851, 476);
			base.Controls.Add(this.f);
			base.Controls.Add(this.d);
			base.Name = "TemperatureSR";
			this.Text = "Реестр температур";
			base.Load += this.b;
			this.d.ResumeLayout(false);
			this.d.PerformLayout();
			this.f.ResumeLayout(false);
			this.g.ResumeLayout(false);
			((ISupportInitialize)this.h).EndInit();
			((ISupportInitialize)this.i).EndInit();
			((ISupportInitialize)this.j).EndInit();
			((ISupportInitialize)this.k).EndInit();
			this.v.ResumeLayout(false);
			((ISupportInitialize)this.w).EndInit();
			((ISupportInitialize)this.x).EndInit();
			((ISupportInitialize)this.y).EndInit();
			((ISupportInitialize)this.z).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000A2 RID: 162
		private DateTimePicker a;

		// Token: 0x040000A3 RID: 163
		private DateTimePicker b;

		// Token: 0x040000A5 RID: 165
		private ToolStrip d;

		// Token: 0x040000A6 RID: 166
		private ToolStripLabel e;

		// Token: 0x040000A7 RID: 167
		private TabControl f;

		// Token: 0x040000A8 RID: 168
		private TabPage g;

		// Token: 0x040000A9 RID: 169
		private DataGridViewExcelFilter h;

		// Token: 0x040000AA RID: 170
		private BindingSource i;

		// Token: 0x040000AB RID: 171
		private DataSet j;

		// Token: 0x040000AC RID: 172
		private DataTable k;

		// Token: 0x040000AD RID: 173
		private DataColumn l;

		// Token: 0x040000AE RID: 174
		private DataColumn m;

		// Token: 0x040000AF RID: 175
		private DataColumn n;

		// Token: 0x040000B0 RID: 176
		private DataColumn o;

		// Token: 0x040000B1 RID: 177
		private DataColumn p;

		// Token: 0x040000B2 RID: 178
		private DataColumn q;

		// Token: 0x040000B3 RID: 179
		private DataColumn r;

		// Token: 0x040000B4 RID: 180
		private DataColumn s;

		// Token: 0x040000B5 RID: 181
		private DataColumn t;

		// Token: 0x040000B6 RID: 182
		private DataColumn u;

		// Token: 0x040000B7 RID: 183
		private TabPage v;

		// Token: 0x040000B8 RID: 184
		private DataGridViewExcelFilter w;

		// Token: 0x040000B9 RID: 185
		private BindingSource x;

		// Token: 0x040000BA RID: 186
		private DataSet y;

		// Token: 0x040000BB RID: 187
		private DataTable z;

		// Token: 0x040000BC RID: 188
		private DataColumn aa;

		// Token: 0x040000BD RID: 189
		private DataColumn ab;

		// Token: 0x040000BE RID: 190
		private DataColumn ac;

		// Token: 0x040000BF RID: 191
		private DataColumn ad;

		// Token: 0x040000C0 RID: 192
		private DataColumn ae;

		// Token: 0x040000C1 RID: 193
		private DataColumn af;

		// Token: 0x040000C2 RID: 194
		private DataColumn ag;

		// Token: 0x040000C3 RID: 195
		private DataColumn ah;

		// Token: 0x040000C4 RID: 196
		private DataColumn ai;

		// Token: 0x040000C5 RID: 197
		private DataColumn aj;

		// Token: 0x040000C6 RID: 198
		private ToolStripLabel ak;

		// Token: 0x040000C7 RID: 199
		private ToolStripButton al;

		// Token: 0x040000C8 RID: 200
		private DataGridViewFilterDateTimePickerColumn am;

		// Token: 0x040000C9 RID: 201
		private DataGridViewTextBoxColumn an;

		// Token: 0x040000CA RID: 202
		private DataGridViewTextBoxColumn ao;

		// Token: 0x040000CB RID: 203
		private DataGridViewTextBoxColumn ap;

		// Token: 0x040000CC RID: 204
		private DataGridViewTextBoxColumn aq;

		// Token: 0x040000CD RID: 205
		private DataGridViewTextBoxColumn ar;

		// Token: 0x040000CE RID: 206
		private DataGridViewTextBoxColumn @as;

		// Token: 0x040000CF RID: 207
		private DataGridViewTextBoxColumn at;

		// Token: 0x040000D0 RID: 208
		private DataGridViewTextBoxColumn au;

		// Token: 0x040000D1 RID: 209
		private DataGridViewTextBoxColumn av;

		// Token: 0x040000D2 RID: 210
		private DataGridViewFilterDateTimePickerColumn aw;

		// Token: 0x040000D3 RID: 211
		private DataGridViewTextBoxColumn ax;

		// Token: 0x040000D4 RID: 212
		private DataGridViewTextBoxColumn ay;

		// Token: 0x040000D5 RID: 213
		private DataGridViewTextBoxColumn az;

		// Token: 0x040000D6 RID: 214
		private DataGridViewTextBoxColumn a0;

		// Token: 0x040000D7 RID: 215
		private DataGridViewTextBoxColumn a1;

		// Token: 0x040000D8 RID: 216
		private DataGridViewTextBoxColumn a2;

		// Token: 0x040000D9 RID: 217
		private DataGridViewTextBoxColumn a3;

		// Token: 0x040000DA RID: 218
		private DataGridViewTextBoxColumn a4;

		// Token: 0x040000DB RID: 219
		private DataGridViewTextBoxColumn a5;
	}
}
